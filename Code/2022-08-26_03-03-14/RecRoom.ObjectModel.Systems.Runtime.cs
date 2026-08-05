using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Google.Protobuf;
using Mono.Math;
using RecRoom.Components;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.Systems;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
[DefaultMember("Item")]
public sealed class DJKBLJDEBIM<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class DAHJICGEDIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::DJKBLJDEBIM<T> APKEBOOGHGO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] NGJHLCKDBLL
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public DAHJICGEDIK(global::DJKBLJDEBIM<T> APKEBOOGHGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class DNEPEBDLKLM : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::DJKBLJDEBIM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <count>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "4")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[DebuggerHidden]
		public DNEPEBDLKLM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const int IDLNJMLCCIP = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> MGEIFFANCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int ILKJLJKOMED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private bool KJLHILCOCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool MMIOJGMABJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool MENEEBPIDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LNGADAPJAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	public DJKBLJDEBIM(int LAODCMGHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public DJKBLJDEBIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void PIKMDDMGAGA(int HIANDEDCLIF, T IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void FNJJGGMAHAD(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] NAAOBDLEDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void IAJHFGNNFDC(NativeArray<T> LBLDONKHBCF, int BPPENCELOKN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::DJKBLJDEBIM<>.DNEPEBDLKLM))]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	public int DPCKACGJMLB(T IGAPBICELKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool JNIHJKFEBJI(T IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void KDBKJMGIDNN(int PPGAJOBADKP, int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void JIEIJLMBIKJ(int PPGAJOBADKP, int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void KPKPBOCMGHO(int PPGAJOBADKP, int FPKCCNCOJGI, int BKKGFAKFDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int HHGGBBIGJBO(int HIANDEDCLIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T JOJMDBGCIIM(int HIANDEDCLIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void FPNBIGLDLKN(int HIANDEDCLIF, T IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void KNFIEDILGDP(int HIANDEDCLIF, T IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void LEGBAAKDHEE(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int BLLEDCMIPFE(int KGJOJGIPNPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int DIDKJINHLBC(int KGJOJGIPNPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void NLLKCPFJEEN(T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void BOMKGHBPCAD(T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T BCBGCOMFJEC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T OJMMOBANEEK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void KAIDFEOBBCF(int HIANDEDCLIF, IReadOnlyCollection<T> PEJODNFDFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void AOALPNELBNJ(int HIANDEDCLIF, int POCNJGOPJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void NCFJPGCDLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void KLDIBNBBMJA(T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void MBFLNPCMJMM(T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void BDIGMIHDDNP(int FPKCCNCOJGI, int BKKGFAKFDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T JPAFPLEHDHE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T BLBPHKANEJP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[LGLOKJFMMGB]
public static class KCFJADCFNBD
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2373AB0", Offset = "0x23726B0", VA = "0x182373AB0")]
	static KCFJADCFNBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2D450A0", Offset = "0x2D43CA0", VA = "0x182D450A0")]
	public static void GDPAMAPBGDO<T>(T MAGJNDGNDNI, ref T GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2373A80", Offset = "0x2372680", VA = "0x182373A80")]
	public static void GDPAMAPBGDO(FixedString32 MAGJNDGNDNI, ref string GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x23739D0", Offset = "0x23725D0", VA = "0x1823739D0")]
	public static void GDPAMAPBGDO(string MAGJNDGNDNI, ref FixedString32 GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2373800", Offset = "0x2372400", VA = "0x182373800")]
	public static void GDPAMAPBGDO(FixedString64 MAGJNDGNDNI, ref string GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2373830", Offset = "0x2372430", VA = "0x182373830")]
	public static void GDPAMAPBGDO(string MAGJNDGNDNI, ref FixedString64 GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1EBB270", Offset = "0x1EB9E70", VA = "0x181EBB270")]
	public static void GDPAMAPBGDO(JNOEGPKGMBA MAGJNDGNDNI, ref Vector3 GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2373970", Offset = "0x2372570", VA = "0x182373970")]
	public static void GDPAMAPBGDO(Vector3 MAGJNDGNDNI, ref JNOEGPKGMBA GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x23738F0", Offset = "0x23724F0", VA = "0x1823738F0")]
	public static void GDPAMAPBGDO(LGDOIPCOGCC MAGJNDGNDNI, ref Vector4 GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2373920", Offset = "0x2372520", VA = "0x182373920")]
	public static void GDPAMAPBGDO(Vector4 MAGJNDGNDNI, ref LGDOIPCOGCC GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x23738F0", Offset = "0x23724F0", VA = "0x1823738F0")]
	public static void GDPAMAPBGDO(LGDOIPCOGCC MAGJNDGNDNI, ref Quaternion GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2373920", Offset = "0x2372520", VA = "0x182373920")]
	public static void GDPAMAPBGDO(Quaternion MAGJNDGNDNI, ref LGDOIPCOGCC GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x23737C0", Offset = "0x23723C0", VA = "0x1823737C0")]
	public static void GDPAMAPBGDO(JNOEGPKGMBA MAGJNDGNDNI, ref float3 GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2373970", Offset = "0x2372570", VA = "0x182373970")]
	public static void GDPAMAPBGDO(float3 MAGJNDGNDNI, ref JNOEGPKGMBA GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2373A20", Offset = "0x2372620", VA = "0x182373A20")]
	public static void GDPAMAPBGDO(LGDOIPCOGCC MAGJNDGNDNI, ref float4 GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2373920", Offset = "0x2372520", VA = "0x182373920")]
	public static void GDPAMAPBGDO(float4 MAGJNDGNDNI, ref LGDOIPCOGCC GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2373A20", Offset = "0x2372620", VA = "0x182373A20")]
	public static void GDPAMAPBGDO(LGDOIPCOGCC MAGJNDGNDNI, ref quaternion GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x23738A0", Offset = "0x23724A0", VA = "0x1823738A0")]
	public static void GDPAMAPBGDO(quaternion MAGJNDGNDNI, ref LGDOIPCOGCC GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2373A40", Offset = "0x2372640", VA = "0x182373A40")]
	public static void GDPAMAPBGDO(Entity MAGJNDGNDNI, ref IOHIAFGPGGM GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x23738D0", Offset = "0x23724D0", VA = "0x1823738D0")]
	public static void GDPAMAPBGDO(IOHIAFGPGGM MAGJNDGNDNI, ref Entity GHPFDMEEDOP, PAFBNCGGKDO AGDOOHGFMOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LPLPHKHEJPF : HMECPPGNBDI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int ANGBGINDADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMIGFMBEJGM GHFCMNLGBOA(Entity OCMABEPCGDM);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFODHFCIAFH(NativeArray<CMIGFMBEJGM> CPMPJGKLBAD, NativeArray<DMENKOJAMJB> FLJOMBKKJJA);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ODBMOEGJFKI(CMIGFMBEJGM CGGCCCAGOLF);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EFHDJNBFNEH(CMIGFMBEJGM CGGCCCAGOLF, out Collider PCJIIECCPGC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NFGOFKINMIG]
public class GCBNOBEMHGM : ComponentSystem, HKFIKAGKAAK
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DEGAMIMEMLN FIEBOMHOKHP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x616D70", Offset = "0x615970", VA = "0x180616D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BDNIJAOEAEJ FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x710440", Offset = "0x70F040", VA = "0x180710440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2366480", Offset = "0x2365080", VA = "0x182366480", Slot = "14")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480")]
	public GCBNOBEMHGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CreateAssetMenu]
	public class ObjectModelConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x26B7E80", Offset = "0x26B6A80", VA = "0x1826B7E80")]
		public static ObjectModelConfigAsset ALNHNMHILDC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xDDC560", Offset = "0xDDB160", VA = "0x180DDC560")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[GOMFNBMFGBH(ELBDNIJMKBJ.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int EIEGJHHNOAD = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly LJFAOMOPGNF FFJIMJJJOGA;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x26BB710", Offset = "0x26BA310", VA = "0x1826BB710")]
			public static GEGPJNFMCPG BDHBMJOFIDA(int PHGBNHCIEGC)
			{
				return default(GEGPJNFMCPG);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x26BB8A0", Offset = "0x26BA4A0", VA = "0x1826BB8A0")]
			public static int NOANIIMGICC(GameObject MHECAANKLIB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x26BBA10", Offset = "0x26BA610", VA = "0x1826BBA10")]
			[Conditional("UNITY_EDITOR")]
			[Conditional("DEBUG_BUILD")]
			private static void OELALEDIELJ(OLACMNNNFCK AIJKIAIKFDH, int PHGBNHCIEGC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static EAFDIMGMAFM NBELCHPBKDK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static EGCFDCFHPMF FJANDPPHOJP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static EAFDIMGMAFM JDJMLCKEJIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x26B9260", Offset = "0x26B7E60", VA = "0x1826B9260")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x26B83D0", Offset = "0x26B6FD0", VA = "0x1826B83D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static EGCFDCFHPMF NJEANANPJDE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x26B8CF0", Offset = "0x26B78F0", VA = "0x1826B8CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x26B8E50", Offset = "0x26B7A50", VA = "0x1826B8E50")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool AJPLEJHADLO
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x26B8820", Offset = "0x26B7420", VA = "0x1826B8820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static BDNIJAOEAEJ FLGGGNNJALI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x26B8C80", Offset = "0x26B7880", VA = "0x1826B8C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static JFDNCMBCKCA JLLLBFHKFBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x26B86F0", Offset = "0x26B72F0", VA = "0x1826B86F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static BNDFEICOCDN NPJIANAICGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x26B8110", Offset = "0x26B6D10", VA = "0x1826B8110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static PNPPGDJCNCL BMKPBNENOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x26B7F00", Offset = "0x26B6B00", VA = "0x1826B7F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static FDNCDAIFHHA EDAFGIAPEHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x26B84A0", Offset = "0x26B70A0", VA = "0x1826B84A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool IKIEIANKFAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x26B7FD0", Offset = "0x26B6BD0", VA = "0x1826B7FD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x26B8B90", Offset = "0x26B7790", VA = "0x1826B8B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool FCHAIAOIAAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x26B81E0", Offset = "0x26B6DE0", VA = "0x1826B81E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x26B88E0", Offset = "0x26B74E0", VA = "0x1826B88E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool AIAGOFEIPMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x26B87C0", Offset = "0x26B73C0", VA = "0x1826B87C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x26B8570", Offset = "0x26B7170", VA = "0x1826B8570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action DLLPDOAGIEN
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x26B8940", Offset = "0x26B7540", VA = "0x1826B8940")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x26B95A0", Offset = "0x26B81A0", VA = "0x1826B95A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x26B8FA0", Offset = "0x26B7BA0", VA = "0x1826B8FA0")]
		public static OLACMNNNFCK NBOBFLKDCHO(GameObject MHECAANKLIB)
		{
			return default(OLACMNNNFCK);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x26B96A0", Offset = "0x26B82A0", VA = "0x1826B96A0")]
		public static GEGPJNFMCPG OJFOEHBFNEO(GameObject MHECAANKLIB)
		{
			return default(GEGPJNFMCPG);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x26B8A80", Offset = "0x26B7680", VA = "0x1826B8A80")]
		public static NIJAIOMNHOO IMODPBECBDP(GEGPJNFMCPG PJIBLINGJGM)
		{
			return default(NIJAIOMNHOO);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x26B8A40", Offset = "0x26B7640", VA = "0x1826B8A40")]
		public static NIJAIOMNHOO IMODPBECBDP(OLACMNNNFCK AIJKIAIKFDH)
		{
			return default(NIJAIOMNHOO);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x26B8240", Offset = "0x26B6E40", VA = "0x1826B8240")]
		public static (ByteString, IDisposable) CGMPPIJDMHM()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x26B90D0", Offset = "0x26B7CD0", VA = "0x1826B90D0")]
		public static (ByteString, IDisposable) NPHNNEDGGJC(IEnumerable<OLACMNNNFCK> HGLJHPGPPDC)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x26B9430", Offset = "0x26B8030", VA = "0x1826B9430")]
		public static bool OHBKOCHBODN(GameObject MHECAANKLIB, out GEGPJNFMCPG PJIBLINGJGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x26B92C0", Offset = "0x26B7EC0", VA = "0x1826B92C0")]
		public static bool OFCDBBPPLKA(GameObject MHECAANKLIB, out bool GPGPNBIENLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x26B85D0", Offset = "0x26B71D0", VA = "0x1826B85D0")]
		private static EGCFDCFHPMF EOJLAPPDJGH()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DMMCHPHHGCM
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2634F30", Offset = "0x2633B30", VA = "0x182634F30")]
	public static DCFEMLAEOED KIEPKILKNCN(GameObject MHECAANKLIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2635000", Offset = "0x2633C00", VA = "0x182635000")]
	public static DCFEMLAEOED KIEPKILKNCN(GameObject MHECAANKLIB, GEGPJNFMCPG PJIBLINGJGM)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class DisembodiedObjectView : MonoBehaviour, AMLIMGALOLN
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public OLACMNNNFCK IBMOHDDKOOP
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5ED000", Offset = "0x5EBC00", VA = "0x1805ED000", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(OLACMNNNFCK);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x26AFE10", Offset = "0x26AEA10", VA = "0x1826AFE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleComponent]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, DCFEMLAEOED, AMLIMGALOLN
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string AFAILMECDDO = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private OLACMNNNFCK DJJOBHOILOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private EDGMFANNLAF IADJLOGDJJD;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public OLACMNNNFCK IBMOHDDKOOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8FDA50", Offset = "0x8FC650", VA = "0x1808FDA50", Slot = "11")]
			get
			{
				return default(OLACMNNNFCK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public NIJAIOMNHOO BDNPBKKLIGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x26B0E40", Offset = "0x26AFA40", VA = "0x1826B0E40", Slot = "4")]
			get
			{
				return default(NIJAIOMNHOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private BDNIJAOEAEJ FLGGGNNJALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x26B05D0", Offset = "0x26AF1D0", VA = "0x1826B05D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private DLIOKHGJHNN KECCCPMFMKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x26B0490", Offset = "0x26AF090", VA = "0x1826B0490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public EDGMFANNLAF KFCHNBEOHAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x63D0F0", Offset = "0x63BCF0", VA = "0x18063D0F0", Slot = "5")]
			get
			{
				return default(EDGMFANNLAF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool FBDMEKJCKGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x7DDE70", Offset = "0x7DCA70", VA = "0x1807DDE70", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7DDEF0", Offset = "0x7DCAF0", VA = "0x1807DDEF0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> LALHPFPCNMO
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x26B0DA0", Offset = "0x26AF9A0", VA = "0x1826B0DA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x26B0E70", Offset = "0x26AFA70", VA = "0x1826B0E70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x26B03C0", Offset = "0x26AEFC0", VA = "0x1826B03C0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x26B0C50", Offset = "0x26AF850", VA = "0x1826B0C50", Slot = "13")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x26B08B0", Offset = "0x26AF4B0", VA = "0x1826B08B0", Slot = "14")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x26B0BC0", Offset = "0x26AF7C0", VA = "0x1826B0BC0", Slot = "8")]
		public void OnEmbody(BHBECLCNBCK JFAHNIMFMGP, OLACMNNNFCK DJJOBHOILOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x26B0C40", Offset = "0x26AF840", VA = "0x1826B0C40", Slot = "9")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x26B0970", Offset = "0x26AF570", VA = "0x1826B0970", Slot = "10")]
		public void OnDisembody(bool IIMCHILOLIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x26B07A0", Offset = "0x26AF3A0", VA = "0x1826B07A0")]
		private void OCLGINNPMPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x26B0510", Offset = "0x26AF110", VA = "0x1826B0510")]
		private void KDINJPLNBON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x26B0620", Offset = "0x26AF220", VA = "0x1826B0620")]
		private void LCGDDCAALFC(bool KOEKJIEOIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x10A8020", Offset = "0x10A6C20", VA = "0x1810A8020", Slot = "7")]
		private GameObject NEAJFPKEMHM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Registration)]
	public sealed class TransformEntity : MonoBehaviour, AMLIMGALOLN
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private CMECOJAJFAB prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private OLACMNNNFCK AIJKIAIKFDH;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public CMECOJAJFAB LCBMGLHBBDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x678670", Offset = "0x677270", VA = "0x180678670")]
			get
			{
				return default(CMECOJAJFAB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x73E910", Offset = "0x73D510", VA = "0x18073E910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public OLACMNNNFCK IBMOHDDKOOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8FDA50", Offset = "0x8FC650", VA = "0x1808FDA50", Slot = "4")]
			get
			{
				return default(OLACMNNNFCK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal Entity LHHBOIJJOCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal PNPPGDJCNCL BMKPBNENOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal DLIOKHGJHNN NEOMBDCOKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x5850800", Offset = "0x584F400", VA = "0x185850800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x58503B0", Offset = "0x584EFB0", VA = "0x1858503B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x58503C0", Offset = "0x584EFC0", VA = "0x1858503C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x58504C0", Offset = "0x584F0C0", VA = "0x1858504C0")]
		internal void NEDKCOBOAHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x58503C0", Offset = "0x584EFC0", VA = "0x1858503C0")]
		internal void EMMKKOCKPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5850730", Offset = "0x584F330", VA = "0x185850730")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x58508C0", Offset = "0x584F4C0", VA = "0x1858508C0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Flags]
public enum EKDNEGGKDMK
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	IncludeMock = 4,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	IncludeEditor = 8,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[MHBJLGEIMOG(typeof(EGCFDCFHPMF), new string[] { })]
public class GNLLAMMHFME : EGCFDCFHPMF, IDisposable, CELPKLDEEEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public DEGAMIMEMLN FIEBOMHOKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4A0", Offset = "0x5EB0A0", VA = "0x1805EC4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public JDDPPIAFHCO OGHJOOKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x616D70", Offset = "0x615970", VA = "0x180616D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public BDNIJAOEAEJ FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x710440", Offset = "0x70F040", VA = "0x180710440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool IKIEIANKFAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2367D20", Offset = "0x2366920", VA = "0x182367D20", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2368690", Offset = "0x2367290", VA = "0x182368690", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public PNNEAMBELML PJAILHEIIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x615720", Offset = "0x614320", VA = "0x180615720", Slot = "15")]
		get
		{
			return default(PNNEAMBELML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x23680F0", Offset = "0x2366CF0", VA = "0x1823680F0")]
	public static GNLLAMMHFME DPFIJBHMAAN(HMLFHMLPJEO CMPGNIIOOGE, EKDNEGGKDMK AJKANCOMGHN = EKDNEGGKDMK.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x23683E0", Offset = "0x2366FE0", VA = "0x1823683E0")]
	private static void FEFDGAEEAHI(HMLFHMLPJEO CMPGNIIOOGE, EKDNEGGKDMK AJKANCOMGHN = EKDNEGGKDMK.ExcludeIgnore)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2367D80", Offset = "0x2366980", VA = "0x182367D80")]
	private static void CBLNFNGILAM(HMLFHMLPJEO CMPGNIIOOGE, EKDNEGGKDMK AJKANCOMGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2368B10", Offset = "0x2367710", VA = "0x182368B10")]
	private static string[] OLMFPCMABGL(EKDNEGGKDMK AJKANCOMGHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2368890", Offset = "0x2367490", VA = "0x182368890")]
	private static bool LEJBOLKIBFK(EKDNEGGKDMK AJKANCOMGHN, out string[] OANENIBPABH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2368760", Offset = "0x2367360", VA = "0x182368760")]
	private static void JOGJEDLDBMF(HMLFHMLPJEO CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2368540", Offset = "0x2367140", VA = "0x182368540", Slot = "16")]
	public void HICLPHNLMNF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x100E670", Offset = "0x100D270", VA = "0x18100E670")]
	private void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2368C50", Offset = "0x2367850", VA = "0x182368C50")]
	private void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	private void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2368260", Offset = "0x2366E60", VA = "0x182368260", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2368A30", Offset = "0x2367630", VA = "0x182368A30", Slot = "19")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x23684D0", Offset = "0x23670D0", VA = "0x1823684D0", Slot = "9")]
	public void HFGBGLEFMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "10")]
	public void LINKHNDCNGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2368620", Offset = "0x2367220", VA = "0x182368620", Slot = "11")]
	public void JCNDCNBGKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x23682F0", Offset = "0x2366EF0", VA = "0x1823682F0", Slot = "7")]
	public void EFBLDOLKNNC(ByteString OAGMKJFIKKL, MGJJCLGNAJN AJKANCOMGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x23689C0", Offset = "0x23675C0", VA = "0x1823689C0", Slot = "8")]
	public void LJHKKFBAEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2368820", Offset = "0x2367420", VA = "0x182368820", Slot = "12")]
	public void JPIJHPOKJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2368AA0", Offset = "0x23676A0", VA = "0x182368AA0", Slot = "13")]
	public void NNAJJKACHNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2368010", Offset = "0x2366C10", VA = "0x182368010", Slot = "20")]
	public ByteString CGMPPIJDMHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0")]
	private static bool OIGLKCFKGLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GNLLAMMHFME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NCMNHHABECD
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x26B39F0", Offset = "0x26B25F0", VA = "0x1826B39F0")]
	public static NIJAIOMNHOO CIIKAHOEEGC(this EGCFDCFHPMF FJANDPPHOJP, GEGPJNFMCPG PJIBLINGJGM, CMECOJAJFAB LBEKIEDKPCN)
	{
		return default(NIJAIOMNHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x26B3B10", Offset = "0x26B2710", VA = "0x1826B3B10")]
	public static ANMPIPGPBIJ INJJBKJOIPH(this EGCFDCFHPMF FJANDPPHOJP)
	{
		return default(ANMPIPGPBIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x26B3C10", Offset = "0x26B2810", VA = "0x1826B3C10")]
	public static OLACMNNNFCK NBOBFLKDCHO(this EGCFDCFHPMF FJANDPPHOJP, Entity OCMABEPCGDM)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x26B3CB0", Offset = "0x26B28B0", VA = "0x1826B3CB0")]
	public static OLACMNNNFCK NBOBFLKDCHO(this EGCFDCFHPMF FJANDPPHOJP, GEGPJNFMCPG PJIBLINGJGM)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x26B3DC0", Offset = "0x26B29C0", VA = "0x1826B3DC0")]
	public static GEGPJNFMCPG OJFOEHBFNEO(this EGCFDCFHPMF FJANDPPHOJP, OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(GEGPJNFMCPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public class LFDLMLAPGKM<T> : global::MFOLKMBMNHP<T>, global::GJOMGFAOOGO<GEGPJNFMCPG, T>, global::GNBEEICGICM<GEGPJNFMCPG>, AAIBJIBIIGL, IDisposable, BIIMOMDCJGN where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly global::GNBEEICGICM<Entity> MDENPOJAPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly PNPPGDJCNCL LCAGHKIOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Delegate GNEKDFOCHOA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string DNLLPFFBEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4544C90", Offset = "0x4543890", VA = "0x184544C90", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Type JPAONBFFOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4544FD0", Offset = "0x4543BD0", VA = "0x184544FD0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public PDFLHPLNHMF BHGGBLDCKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4543FD0", Offset = "0x4542BD0", VA = "0x184543FD0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int DFLEKDLCGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4544BA0", Offset = "0x45437A0", VA = "0x184544BA0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HHCCLCGFJEG FOHELBMCEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4545F90", Offset = "0x4544B90", VA = "0x184545F90", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x39B0550", Offset = "0x39AF150", VA = "0x1839B0550", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x39B04E0", Offset = "0x39AF0E0", VA = "0x1839B04E0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event global::KPOBJDLJONK<GEGPJNFMCPG> OHEKIBMGEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4542440", Offset = "0x4541040", VA = "0x184542440", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4546030", Offset = "0x4544C30", VA = "0x184546030", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x39B47B0", Offset = "0x39B33B0", VA = "0x1839B47B0")]
	public LFDLMLAPGKM(global::GNBEEICGICM<Entity> MDENPOJAPFE, PNPPGDJCNCL LCAGHKIOCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4546490", Offset = "0x4545090", VA = "0x184546490")]
	private Entity OIJCCGOAGBB(GEGPJNFMCPG PJIBLINGJGM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x39B3870", Offset = "0x39B2470", VA = "0x1839B3870")]
	private GEGPJNFMCPG OIJCCGOAGBB(Entity OCMABEPCGDM)
	{
		return default(GEGPJNFMCPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4544870", Offset = "0x4543470", VA = "0x184544870", Slot = "4")]
	public T JHLAPKAGPFG(GEGPJNFMCPG PJIBLINGJGM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4543440", Offset = "0x4542040", VA = "0x184543440")]
	public bool GELHLBKPBFF(GEGPJNFMCPG PJIBLINGJGM, in T FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4546A40", Offset = "0x4545640", VA = "0x184546A40")]
	public bool OOMIGGLFHGN(GEGPJNFMCPG PJIBLINGJGM, in T FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x45420D0", Offset = "0x4540CD0", VA = "0x1845420D0", Slot = "9")]
	public bool CAACINLFJOH(GEGPJNFMCPG PJIBLINGJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x39B02B0", Offset = "0x39AEEB0", VA = "0x1839B02B0", Slot = "26")]
	public object BPGMDPGIGKG(GEGPJNFMCPG PJIBLINGJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4546F60", Offset = "0x4545B60", VA = "0x184546F60")]
	public bool PDEGPMMCJHN(GEGPJNFMCPG PJIBLINGJGM, in object FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x39B1F40", Offset = "0x39B0B40", VA = "0x1839B1F40")]
	public void JHLAPKAGPFG(GEGPJNFMCPG PJIBLINGJGM, in EJMAFNBMMGI KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x39B12A0", Offset = "0x39AFEA0", VA = "0x1839B12A0")]
	public bool GELHLBKPBFF(GEGPJNFMCPG PJIBLINGJGM, in CJHLIFJIIDK FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x39B3DF0", Offset = "0x39B29F0", VA = "0x1839B3DF0")]
	public bool OOMIGGLFHGN(GEGPJNFMCPG PJIBLINGJGM, in CJHLIFJIIDK FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x39AF400", Offset = "0x39AE000", VA = "0x1839AF400", Slot = "21")]
	public void BEFHONAIJPO(POEIGJOFIAI HKGCALJNCCI, [Optional] object NAEOEJMOBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4540D80", Offset = "0x453F980", VA = "0x184540D80", Slot = "15")]
	public void BEFHONAIJPO(GEGPJNFMCPG KKDEFIFHPNN, IAIJJIAPNDG HKGCALJNCCI, object NAEOEJMOBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x39B27F0", Offset = "0x39B13F0", VA = "0x1839B27F0", Slot = "14")]
	public bool LCAMBDBAHHD(GEGPJNFMCPG GHPFDMEEDOP, GEGPJNFMCPG MAGJNDGNDNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1FD3DA0", Offset = "0x1FD29A0", VA = "0x181FD3DA0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4547580", Offset = "0x4546180", VA = "0x184547580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4543C30", Offset = "0x4542830", VA = "0x184543C30")]
	public string GFEEPGJPLML(in CJHLIFJIIDK CNJCJKGEEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4545470", Offset = "0x4544070", VA = "0x184545470")]
	private void LMOHDHOEKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4545B70", Offset = "0x4544770", VA = "0x184545B70")]
	private void NFBOKDBGPCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x45430A0", Offset = "0x4541CA0", VA = "0x1845430A0")]
	private void GEJMEMBALPI(Entity OCMABEPCGDM, in CJHLIFJIIDK NBOLFCPAICP, in CJHLIFJIIDK FMKHLEANADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4543EB0", Offset = "0x4542AB0", VA = "0x184543EB0")]
	private void ICGNLCMCGAM(Entity OCMABEPCGDM, in CJHLIFJIIDK NBOLFCPAICP, in CJHLIFJIIDK FMKHLEANADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x45416E0", Offset = "0x45402E0", VA = "0x1845416E0")]
	[Conditional("DEBUG_BUILD")]
	private static void BOJKMDPEAHI(Entity OCMABEPCGDM, GEGPJNFMCPG PJIBLINGJGM, string OHDKCBCOIKL, string OEPINGPALAN, [CallerMemberName] string OMKCGMGNDOA = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1800", Offset = "0x2BC0400", VA = "0x182BC1800", Slot = "5")]
	private bool FALAPCJBKNE(GEGPJNFMCPG KKDEFIFHPNN, in T FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1BF0", Offset = "0x2BC07F0", VA = "0x182BC1BF0", Slot = "6")]
	private bool FIGOOKBKKHJ(GEGPJNFMCPG KKDEFIFHPNN, in T FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x39B1270", Offset = "0x39AFE70", VA = "0x1839B1270", Slot = "23")]
	private string GEJNCJNELGA(in CJHLIFJIIDK KGJOJGIPNPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x39B1A10", Offset = "0x39B0610", VA = "0x1839B1A10", Slot = "10")]
	private bool GPADGEEMMPI(GEGPJNFMCPG KKDEFIFHPNN, in object FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x39B3470", Offset = "0x39B2070", VA = "0x1839B3470", Slot = "11")]
	private void NFGBJCPBNOM(GEGPJNFMCPG KKDEFIFHPNN, in EJMAFNBMMGI KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x39B19E0", Offset = "0x39B05E0", VA = "0x1839B19E0", Slot = "12")]
	private bool GMCIIKDGLMJ(GEGPJNFMCPG KKDEFIFHPNN, in CJHLIFJIIDK FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2D01CC0", Offset = "0x2D008C0", VA = "0x182D01CC0", Slot = "13")]
	private bool FCDCNBPNIAL(GEGPJNFMCPG KKDEFIFHPNN, in CJHLIFJIIDK FMKHLEANADK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class PCAMDBAEOGP<T> : global::MGBAHOPOBPI<T>, global::GJOMGFAOOGO<OLACMNNNFCK, T>, global::GNBEEICGICM<OLACMNNNFCK>, AAIBJIBIIGL, IDisposable, CNAIOOCFPBI where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::GNBEEICGICM<Entity> MDENPOJAPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly PNPPGDJCNCL LCAGHKIOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate GNEKDFOCHOA;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string DNLLPFFBEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4AF9F60", Offset = "0x4AF8B60", VA = "0x184AF9F60", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type JPAONBFFOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4AFA210", Offset = "0x4AF8E10", VA = "0x184AFA210", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public PDFLHPLNHMF BHGGBLDCKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4AF9830", Offset = "0x4AF8430", VA = "0x184AF9830", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DFLEKDLCGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4AF9EC0", Offset = "0x4AF8AC0", VA = "0x184AF9EC0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public HHCCLCGFJEG FOHELBMCEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4AFAA20", Offset = "0x4AF9620", VA = "0x184AFAA20", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4AF88F0", Offset = "0x4AF74F0", VA = "0x184AF88F0", Slot = "23")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3A189A0", Offset = "0x3A175A0", VA = "0x183A189A0", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::KPOBJDLJONK<OLACMNNNFCK> OHEKIBMGEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4AF8A40", Offset = "0x4AF7640", VA = "0x184AF8A40", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4AFAB20", Offset = "0x4AF9720", VA = "0x184AFAB20", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x39B47B0", Offset = "0x39B33B0", VA = "0x1839B47B0")]
	public PCAMDBAEOGP(global::GNBEEICGICM<Entity> MDENPOJAPFE, PNPPGDJCNCL LCAGHKIOCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1C98F10", Offset = "0x1C97B10", VA = "0x181C98F10")]
	private Entity OIJCCGOAGBB(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A19D70", Offset = "0x3A18970", VA = "0x183A19D70")]
	private OLACMNNNFCK OIJCCGOAGBB(Entity OCMABEPCGDM)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9880", Offset = "0x4AF8480", VA = "0x184AF9880", Slot = "4")]
	public T JHLAPKAGPFG(OLACMNNNFCK AIJKIAIKFDH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4AF94D0", Offset = "0x4AF80D0", VA = "0x184AF94D0")]
	public bool GELHLBKPBFF(OLACMNNNFCK AIJKIAIKFDH, in T FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4AFAEA0", Offset = "0x4AF9AA0", VA = "0x184AFAEA0")]
	public bool OOMIGGLFHGN(OLACMNNNFCK AIJKIAIKFDH, in T FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8770", Offset = "0x4AF7370", VA = "0x184AF8770", Slot = "9")]
	public bool CAACINLFJOH(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4AF86E0", Offset = "0x4AF72E0", VA = "0x184AF86E0", Slot = "25")]
	public object BPGMDPGIGKG(OLACMNNNFCK AIJKIAIKFDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB250", Offset = "0x4AF9E50", VA = "0x184AFB250")]
	public bool PDEGPMMCJHN(OLACMNNNFCK AIJKIAIKFDH, in object FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9DA0", Offset = "0x4AF89A0", VA = "0x184AF9DA0")]
	public void JHLAPKAGPFG(OLACMNNNFCK AIJKIAIKFDH, in EJMAFNBMMGI KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9280", Offset = "0x4AF7E80", VA = "0x184AF9280")]
	public bool GELHLBKPBFF(OLACMNNNFCK AIJKIAIKFDH, in CJHLIFJIIDK FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4AFAD70", Offset = "0x4AF9970", VA = "0x184AFAD70")]
	public bool OOMIGGLFHGN(OLACMNNNFCK AIJKIAIKFDH, in CJHLIFJIIDK FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x39AF400", Offset = "0x39AE000", VA = "0x1839AF400", Slot = "21")]
	public void BEFHONAIJPO(POEIGJOFIAI HKGCALJNCCI, [Optional] object NAEOEJMOBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4AF84B0", Offset = "0x4AF70B0", VA = "0x184AF84B0", Slot = "15")]
	public void BEFHONAIJPO(OLACMNNNFCK KKDEFIFHPNN, IAIJJIAPNDG HKGCALJNCCI, object NAEOEJMOBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4AFA000", Offset = "0x4AF8C00", VA = "0x184AFA000", Slot = "14")]
	public bool LCAMBDBAHHD(OLACMNNNFCK GHPFDMEEDOP, OLACMNNNFCK MAGJNDGNDNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4AFA2D0", Offset = "0x4AF8ED0", VA = "0x184AFA2D0")]
	private void LMOHDHOEKLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4AFA810", Offset = "0x4AF9410", VA = "0x184AFA810")]
	private void NFBOKDBGPCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4AF8AF0", Offset = "0x4AF76F0", VA = "0x184AF8AF0")]
	private void GEJMEMBALPI(Entity OCMABEPCGDM, in CJHLIFJIIDK NBOLFCPAICP, in CJHLIFJIIDK FMKHLEANADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4AF96A0", Offset = "0x4AF82A0", VA = "0x184AF96A0")]
	private void ICGNLCMCGAM(Entity OCMABEPCGDM, in CJHLIFJIIDK NBOLFCPAICP, in CJHLIFJIIDK FMKHLEANADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3A18A20", Offset = "0x3A17620", VA = "0x183A18A20", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x4AFB440", Offset = "0x4AFA040", VA = "0x184AFB440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3A189A0", Offset = "0x3A175A0", VA = "0x183A189A0", Slot = "5")]
	private bool FKNALCIMHDJ(OLACMNNNFCK KKDEFIFHPNN, in T FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3A19700", Offset = "0x3A18300", VA = "0x183A19700", Slot = "6")]
	private bool KIAAAJEJAFB(OLACMNNNFCK KKDEFIFHPNN, in T FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3A18540", Offset = "0x3A17140", VA = "0x183A18540", Slot = "10")]
	private bool AIDPMFNLGHL(OLACMNNNFCK KKDEFIFHPNN, in object FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3A19A70", Offset = "0x3A18670", VA = "0x183A19A70", Slot = "11")]
	private void NCPJFKIGHEH(OLACMNNNFCK KKDEFIFHPNN, in EJMAFNBMMGI KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3A19130", Offset = "0x3A17D30", VA = "0x183A19130", Slot = "12")]
	private bool GLDKJNNBHEB(OLACMNNNFCK KKDEFIFHPNN, in CJHLIFJIIDK FMKHLEANADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3A189E0", Offset = "0x3A175E0", VA = "0x183A189E0", Slot = "13")]
	private bool DBKFJBCAGMJ(OLACMNNNFCK KKDEFIFHPNN, in CJHLIFJIIDK FMKHLEANADK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EEGMEMCJJHG : IDisposable, HOJCIPGJMNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> PEKGFGHMEAP;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> AKDCPDIONFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA40", Offset = "0x8FC640", VA = "0x1808FDA40", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xD64B80", Offset = "0xD63780", VA = "0x180D64B80")]
	public EEGMEMCJJHG(NativeArray<EntityRemapUtility.EntityRemapInfo> PEKGFGHMEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2636480", Offset = "0x2635080", VA = "0x182636480", Slot = "6")]
	public OLACMNNNFCK KJCFLDKONAB(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2636470", Offset = "0x2635070", VA = "0x182636470", Slot = "7")]
	public Entity KJCFLDKONAB(Entity OCMABEPCGDM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x26364D0", Offset = "0x26350D0", VA = "0x1826364D0", Slot = "8")]
	public IEnumerable<OLACMNNNFCK> KJCFLDKONAB(IEnumerable<OLACMNNNFCK> HGLJHPGPPDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2636410", Offset = "0x2635010", VA = "0x182636410", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Serialization, new string[] { "Remap" })]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string LNOOAJPDMKG = "Remap";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly LJFAOMOPGNF HKFGKCPJEJH;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static int OBGLDDFDNHI;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static HOJCIPGJMNP GNCHJNIKDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool INNNKIDDMBI;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> AKDCPDIONFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x26BD1C0", Offset = "0x26BBDC0", VA = "0x1826BD1C0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static bool BEBDHJPDNJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x26BCE50", Offset = "0x26BBA50", VA = "0x1826BCE50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x26BD160", Offset = "0x26BBD60", VA = "0x1826BD160")]
		public static SerializationRemapScope KPKDPFHGIML()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x26BD340", Offset = "0x26BBF40", VA = "0x1826BD340")]
		public SerializationRemapScope(HOJCIPGJMNP KNMMPEEPBNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x26BCD50", Offset = "0x26BB950", VA = "0x1826BCD50", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x26BD010", Offset = "0x26BBC10", VA = "0x1826BD010")]
		public static OLACMNNNFCK KJCFLDKONAB(OLACMNNNFCK AIJKIAIKFDH)
		{
			return default(OLACMNNNFCK);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x26BCEE0", Offset = "0x26BBAE0", VA = "0x1826BCEE0")]
		public static Entity KJCFLDKONAB(Entity OCMABEPCGDM)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[MHBJLGEIMOG(typeof(FDNCDAIFHHA), new string[] { })]
public class IAOGJLCAPOI : FDNCDAIFHHA, POIJNBNBJIE, CCILBHCKADC, HKFIKAGKAAK, GEPKKGPMACB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private PNPPGDJCNCL LCAGHKIOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityHierarchyParents FDHPNOAHJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityHierarchyChildren HIGOGPMFHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private BBMAEPBFOJE IAMBEOMBAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private ObjectEmbodimentService MPHBIKLMOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::MGBAHOPOBPI<OLACMNNNFCK> CFPOOABENIK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5FFD70", Offset = "0x5FE970", VA = "0x1805FFD70", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x686FC0", Offset = "0x685BC0", VA = "0x180686FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xC7C5E0", Offset = "0xC7B1E0", VA = "0x180C7C5E0", Slot = "13")]
	public void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x236C4D0", Offset = "0x236B0D0", VA = "0x18236C4D0", Slot = "14")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x236C400", Offset = "0x236B000", VA = "0x18236C400", Slot = "15")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x236C1F0", Offset = "0x236ADF0", VA = "0x18236C1F0")]
	private OLACMNNNFCK IFOLMIHIJBP(Entity OCMABEPCGDM)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x236C220", Offset = "0x236AE20", VA = "0x18236C220", Slot = "18")]
	public OLACMNNNFCK ILAJCIAIJDO(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x236BE80", Offset = "0x236AA80", VA = "0x18236BE80", Slot = "19")]
	public void HEEKALJAFEF(ref List<OLACMNNNFCK> FBGPEJDOHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x236C290", Offset = "0x236AE90", VA = "0x18236C290", Slot = "20")]
	public IEnumerable<OLACMNNNFCK> IPDEACIOKMN(OLACMNNNFCK AIJKIAIKFDH, bool CBLGJABHGDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x236BC60", Offset = "0x236A860", VA = "0x18236BC60", Slot = "21")]
	public OLACMNNNFCK DAPKLBIKMBK(OLACMNNNFCK AIJKIAIKFDH, int HIANDEDCLIF)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x236C020", Offset = "0x236AC20", VA = "0x18236C020", Slot = "22")]
	public int HJOMBKMDCNB(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x236BE50", Offset = "0x236AA50", VA = "0x18236BE50", Slot = "7")]
	public int GFBHOGJBGOC(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x236BBC0", Offset = "0x236A7C0", VA = "0x18236BBC0", Slot = "8")]
	public GFHDAMOBKPG AKIOAFJOKLM(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(GFHDAMOBKPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x236C330", Offset = "0x236AF30", VA = "0x18236C330", Slot = "23")]
	public IEnumerable<OLACMNNNFCK> KCOPOEIDDEM(OLACMNNNFCK AIJKIAIKFDH, bool CBLGJABHGDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x236C0D0", Offset = "0x236ACD0", VA = "0x18236C0D0", Slot = "11")]
	public OLACMNNNFCK HPFCHDMGGGI(OLACMNNNFCK JEGDMKPCECO, OLACMNNNFCK CNDMHGAOPGD)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x236BD70", Offset = "0x236A970", VA = "0x18236BD70", Slot = "12")]
	public bool EKBLKLILKFF(OLACMNNNFCK JEGDMKPCECO, OLACMNNNFCK CNDMHGAOPGD, out OLACMNNNFCK JPILMHHADCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x236BCD0", Offset = "0x236A8D0", VA = "0x18236BCD0", Slot = "4")]
	public OLACMNNNFCK DPNLFEGJALJ(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x236BD40", Offset = "0x236A940", VA = "0x18236BD40", Slot = "10")]
	public bool EAHMDJKDIOJ(OLACMNNNFCK AIJKIAIKFDH, OLACMNNNFCK MCHPJLFOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x236C1C0", Offset = "0x236ADC0", VA = "0x18236C1C0", Slot = "24")]
	public bool IDBAJDENNNC(OLACMNNNFCK AIJKIAIKFDH, OLACMNNNFCK ACGOMEFGGLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x236BB90", Offset = "0x236A790", VA = "0x18236BB90", Slot = "9")]
	public bool AGDDOPKFFCH(OLACMNNNFCK AIJKIAIKFDH, OLACMNNNFCK JEGDMKPCECO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x236C3D0", Offset = "0x236AFD0", VA = "0x18236C3D0", Slot = "5")]
	public bool KMBIIDLEBDG(OLACMNNNFCK AIJKIAIKFDH, OLACMNNNFCK MKOLBPGKLJP, bool CFGNJOFBFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x236BC30", Offset = "0x236A830", VA = "0x18236BC30", Slot = "6")]
	public bool CFCLBILFFDO(OLACMNNNFCK AIJKIAIKFDH, OLACMNNNFCK MKOLBPGKLJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xF05C10", Offset = "0xF04810", VA = "0x180F05C10", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public IAOGJLCAPOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class ACAEIGFMODO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeList<AEKCLLLDNHE> MIDPDMFFNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private NativeList<JJNFBNLEEON> NEIIHGAIMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private NativeList<AEKCLLLDNHE> LHFPBGAOCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeList<AEKCLLLDNHE> IHGFHCJNOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA40", Offset = "0x8FC640", VA = "0x1808FDA40")]
		get
		{
			return default(NativeList<AEKCLLLDNHE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeList<JJNFBNLEEON> GMELNMHDDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA50", Offset = "0x8FC650", VA = "0x1808FDA50")]
		get
		{
			return default(NativeList<JJNFBNLEEON>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeList<AEKCLLLDNHE> DMEJCGLMDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xECB570", Offset = "0xECA170", VA = "0x180ECB570")]
		get
		{
			return default(NativeList<AEKCLLLDNHE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JBLGCJEBMBD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x262BCF0", Offset = "0x262A8F0", VA = "0x18262BCF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x262BF80", Offset = "0x262AB80", VA = "0x18262BF80")]
	public ACAEIGFMODO(Allocator HGKGLCNFHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x262BF20", Offset = "0x262AB20", VA = "0x18262BF20")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x262BC50", Offset = "0x262A850", VA = "0x18262BC50")]
	public void BMILBDCJANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x262BD70", Offset = "0x262A970", VA = "0x18262BD70")]
	public void LFMPFEAFMAL(Entity OCMABEPCGDM, Entity CPGJLPOPHBK, Entity BIMAKIIINII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[IBGAMCLMLFP(typeof(DMOLBBGANCB))]
[MHBJLGEIMOG(typeof(MEPFJBJLAPB), new string[] { })]
internal class MEPFJBJLAPB : HKFIKAGKAAK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly Dictionary<int, ACAEIGFMODO> BABKJILHBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private FAMHHBOFMMF LGAGLKFDFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private DMOLBBGANCB GCALAGNGEDP;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2378500", Offset = "0x2377100", VA = "0x182378500", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x23785C0", Offset = "0x23771C0", VA = "0x1823785C0")]
	public ACAEIGFMODO PNALHPDDMBM(BDHIOHAFMEG OHDKCBCOIKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2378790", Offset = "0x2377390", VA = "0x182378790")]
	public ACAEIGFMODO PNALHPDDMBM(LOGKGBLPOOD IPGOEGFNLNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x23783D0", Offset = "0x2376FD0", VA = "0x1823783D0")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2378240", Offset = "0x2376E40", VA = "0x182378240", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x23788A0", Offset = "0x23774A0", VA = "0x1823788A0")]
	public MEPFJBJLAPB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.History)]
	[DebuggerTypeProxy(typeof(NOLBDPCBHEC))]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		internal class NOLBDPCBHEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private readonly ActionBuffer LGIIJIKLGAE;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public int NGNMMFPKHGG
			{
				[Cpp2IlInjected.Token(Token = "0x6000155")]
				[Cpp2IlInjected.Address(RVA = "0x26B5110", Offset = "0x26B3D10", VA = "0x1826B5110")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public GPAOCPANPKD[] LFHOJNHDBHM
			{
				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x26B4F90", Offset = "0x26B3B90", VA = "0x1826B4F90")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x721660", Offset = "0x720260", VA = "0x180721660")]
			public NOLBDPCBHEC(ActionBuffer PPOJFJMNDND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x26B5030", Offset = "0x26B3C30", VA = "0x1826B5030")]
			[CompilerGenerated]
			private GPAOCPANPKD CJJLBHPHMEH(INDLONCDGDD KINCGCMCJLI)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal class GPAOCPANPKD : POEIGJOFIAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private readonly ActionBuffer LGIIJIKLGAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private readonly INDLONCDGDD KINCGCMCJLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private List<(ELNFPIKMDEK, string, object)> IHOIPNEDJNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private ADBJIOAFJHA GLGFLHANMEH;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public int NGNMMFPKHGG
			{
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x26B27A0", Offset = "0x26B13A0", VA = "0x1826B27A0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public List<(ELNFPIKMDEK, string, object)> JAGENIDDEGL
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x26B28E0", Offset = "0x26B14E0", VA = "0x1826B28E0")]
			public GPAOCPANPKD(ActionBuffer PPOJFJMNDND, INDLONCDGDD KINCGCMCJLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x26B27F0", Offset = "0x26B13F0", VA = "0x1826B27F0")]
			private string OCGLNLPHEPA(ELNFPIKMDEK BHNFIJIMKJP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x26B24C0", Offset = "0x26B10C0", VA = "0x1826B24C0")]
			private void HILHGJFFAMN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x22EF020", Offset = "0x22EDC20", VA = "0x1822EF020", Slot = "4")]
			public void FOFDHHCJLDL<TKey, T>(global::GJOMGFAOOGO<TKey, T> MDENPOJAPFE, [Optional] object NAEOEJMOBMH) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private NativeList<byte> HBJAADBDAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Stack<INDLONCDGDD> NDOBJKPCPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly EOIMELKMPPF FINDJDIBCHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly DGMHFGJILHI DPCBGLAGGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly JDGCMEDKNHD GCALAGNGEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly bool HJKPHGIPGBP;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public OCODFBLNHLK IJPBKONCNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x26A8F00", Offset = "0x26A7B00", VA = "0x1826A8F00")]
			get
			{
				return default(OCODFBLNHLK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int NGNMMFPKHGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x26A9160", Offset = "0x26A7D60", VA = "0x1826A9160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x26A9270", Offset = "0x26A7E70", VA = "0x1826A9270")]
		public ActionBuffer(DGMHFGJILHI DPCBGLAGGGP, JDGCMEDKNHD GCALAGNGEDP, bool HJKPHGIPGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x26A8670", Offset = "0x26A7270", VA = "0x1826A8670")]
		public bool BLGFHLCKNOD(out INDLONCDGDD KINCGCMCJLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x26A8F40", Offset = "0x26A7B40", VA = "0x1826A8F40")]
		public void LONCNHKPMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x26A8FA0", Offset = "0x26A7BA0", VA = "0x1826A8FA0")]
		public INDLONCDGDD MBKPDOCFBCM(AFOMEECCFOG IHOIPNEDJNI, EEALACFKCAN NAPFNNNHCOO, uint CMMGEPMFJDB)
		{
			return default(INDLONCDGDD);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x26A88C0", Offset = "0x26A74C0", VA = "0x1826A88C0")]
		public bool FINEEGFKCGJ(uint CMMGEPMFJDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x26A8D40", Offset = "0x26A7940", VA = "0x1826A8D40")]
		public bool LDKENJIIJLE(uint CMMGEPMFJDB, out INDLONCDGDD FNPGAOOPMNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x26A8760", Offset = "0x26A7360", VA = "0x1826A8760")]
		public void EDJIBECNDGC(INDLONCDGDD FNPGAOOPMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x26A88F0", Offset = "0x26A74F0", VA = "0x1826A88F0")]
		[Conditional("DEBUG_BUILD")]
		private void GPLCFIBNKOM(INDLONCDGDD FNPGAOOPMNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x26A91A0", Offset = "0x26A7DA0", VA = "0x1826A91A0")]
		private void PGGOGEIMFEF(INDLONCDGDD AIIJIJPOINP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x26A8AF0", Offset = "0x26A76F0", VA = "0x1826A8AF0")]
		private void JKAMMDAJLKA(ADBJIOAFJHA PGDFKHJEMEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x26A9100", Offset = "0x26A7D00", VA = "0x1826A9100")]
		private void NKGINGIMGGG(INDLONCDGDD KINCGCMCJLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x26A8A30", Offset = "0x26A7630", VA = "0x1826A8A30")]
		private ADBJIOAFJHA IEBMEJMHDFM(INDLONCDGDD KINCGCMCJLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x26A8700", Offset = "0x26A7300", VA = "0x1826A8700", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class EOIMELKMPPF : POEIGJOFIAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly DGMHFGJILHI DPCBGLAGGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly JDGCMEDKNHD GCALAGNGEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private GEGPJNFMCPG DJJOBHOILOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private ADBJIOAFJHA DHAJDNGLIKJ;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5FF990", Offset = "0x5FE590", VA = "0x1805FF990")]
	public EOIMELKMPPF(DGMHFGJILHI DPCBGLAGGGP, JDGCMEDKNHD GCALAGNGEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x233FCB0", Offset = "0x233E8B0", VA = "0x18233FCB0", Slot = "4")]
	public void FOFDHHCJLDL<TKey, T>(global::GJOMGFAOOGO<TKey, T> MAHIDOKBGJP, [Optional] object NAEOEJMOBMH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2638BF0", Offset = "0x26377F0", VA = "0x182638BF0")]
	public void BEFHONAIJPO(ELNFPIKMDEK BHNFIJIMKJP, ref ADBJIOAFJHA PGDFKHJEMEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PDEBCHPLELL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct FPEPBNDINKA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly PDEBCHPLELL MKOLBPGKLJP;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x26B21C0", Offset = "0x26B0DC0", VA = "0x1826B21C0")]
		public FPEPBNDINKA(PDEBCHPLELL MKOLBPGKLJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x26B20C0", Offset = "0x26B0CC0", VA = "0x1826B20C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected AFOMEECCFOG IHOIPNEDJNI;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AFOMEECCFOG JAGENIDDEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x215AC40", Offset = "0x2159840", VA = "0x18215AC40")]
		get
		{
			return default(AFOMEECCFOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool HBEOMPANLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x26B9C70", Offset = "0x26B8870", VA = "0x1826B9C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x26B9C80", Offset = "0x26B8880", VA = "0x1826B9C80")]
	public PDEBCHPLELL(AFOMEECCFOG.EENDABEHHBN KBGAKCIKMFB = AFOMEECCFOG.EENDABEHHBN.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x26B9A90", Offset = "0x26B8690", VA = "0x1826B9A90")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x26B9AA0", Offset = "0x26B86A0", VA = "0x1826B9AA0")]
	public void MAKPCLMEKLM(GEGPJNFMCPG DJJOBHOILOH, NACGOIKMGBD NCMIOOKGKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x26B9910", Offset = "0x26B8510", VA = "0x1826B9910")]
	public void ICIGNHPMEOJ(GEGPJNFMCPG DJJOBHOILOH, LOGKGBLPOOD IPGOEGFNLNJ, in CJHLIFJIIDK FMKHLEANADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x26B9B90", Offset = "0x26B8790", VA = "0x1826B9B90")]
	public void MEFONJBJIPL(GEGPJNFMCPG DJJOBHOILOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x26B9820", Offset = "0x26B8420", VA = "0x1826B9820")]
	public void GMLOPMBELMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x26B99A0", Offset = "0x26B85A0", VA = "0x1826B99A0")]
	public void INJMALCLDFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x26B97E0", Offset = "0x26B83E0", VA = "0x1826B97E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x26B97F0", Offset = "0x26B83F0", VA = "0x1826B97F0")]
	public FPEPBNDINKA EGLPICINJKG()
	{
		return default(FPEPBNDINKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct ELNFPIKMDEK : IComparable<ELNFPIKMDEK>, IEquatable<ELNFPIKMDEK>
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly ELNFPIKMDEK EIEGJHHNOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public GEGPJNFMCPG DJJOBHOILOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public LOGKGBLPOOD IPGOEGFNLNJ;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool PDABALEFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x2638410", Offset = "0x2637010", VA = "0x182638410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x775D30", Offset = "0x774930", VA = "0x180775D30")]
	public ELNFPIKMDEK(GEGPJNFMCPG DJJOBHOILOH, LOGKGBLPOOD IPGOEGFNLNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2638240", Offset = "0x2636E40", VA = "0x182638240")]
	public void CAJIBACLMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x26382A0", Offset = "0x2636EA0", VA = "0x1826382A0", Slot = "4")]
	public int CompareTo(ELNFPIKMDEK NPKIIGGBCCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2638460", Offset = "0x2637060", VA = "0x182638460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x26382E0", Offset = "0x2636EE0", VA = "0x1826382E0", Slot = "0")]
	public override bool Equals(object EBMPLNBFAKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2638380", Offset = "0x2636F80", VA = "0x182638380", Slot = "5")]
	public bool Equals(ELNFPIKMDEK NPKIIGGBCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2638420", Offset = "0x2637020", VA = "0x182638420")]
	public static bool NHPMPBNMAAP(ELNFPIKMDEK EHGLDEHJCJA, ELNFPIKMDEK POGMGOCOOHC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2638250", Offset = "0x2636E50", VA = "0x182638250")]
	public static bool CLDCOCNHPOO(ELNFPIKMDEK EHGLDEHJCJA, ELNFPIKMDEK POGMGOCOOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x26383D0", Offset = "0x2636FD0", VA = "0x1826383D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FDBHFPKFKKI : IAIJJIAPNDG
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private DGMHFGJILHI DPCBGLAGGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private GEGPJNFMCPG DJJOBHOILOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private JFNAGEICNEF PEMKBFMOAOD;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x263AB00", Offset = "0x2639700", VA = "0x18263AB00")]
	public void PIEGBJJEGLJ(GEGPJNFMCPG DJJOBHOILOH, DGMHFGJILHI DPCBGLAGGGP, JFNAGEICNEF PEMKBFMOAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x263AA40", Offset = "0x2639640", VA = "0x18263AA40", Slot = "4")]
	private void LJKJNMDPADE(AAIBJIBIIGL MDENPOJAPFE, in CJHLIFJIIDK KGJOJGIPNPH, object NAEOEJMOBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public FDBHFPKFKKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class MGFHECIKHCH
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2378A10", Offset = "0x2377610", VA = "0x182378A10")]
	public static void APKBAKIONAK(AFOMEECCFOG IHOIPNEDJNI, ELNFPIKMDEK BHNFIJIMKJP, NACGOIKMGBD NCMIOOKGKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2378BD0", Offset = "0x23777D0", VA = "0x182378BD0")]
	public static void JEMALMCJKGJ(AFOMEECCFOG IHOIPNEDJNI, ELNFPIKMDEK BHNFIJIMKJP, in CJHLIFJIIDK FMKHLEANADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2378D90", Offset = "0x2377990", VA = "0x182378D90")]
	public static void PHACBMHGHHP(AFOMEECCFOG IHOIPNEDJNI, ELNFPIKMDEK BHNFIJIMKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2378CC0", Offset = "0x23778C0", VA = "0x182378CC0")]
	public static void NHKLLNLIHFN(AFOMEECCFOG IHOIPNEDJNI, ELNFPIKMDEK BHNFIJIMKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2378B30", Offset = "0x2377730", VA = "0x182378B30")]
	public static NACGOIKMGBD FJJGCICJLPL(AFOMEECCFOG IHOIPNEDJNI, ELNFPIKMDEK BHNFIJIMKJP)
	{
		return default(NACGOIKMGBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x20274F0", Offset = "0x20260F0", VA = "0x1820274F0")]
	public static T LILHBHNDLNN<T>(AFOMEECCFOG IHOIPNEDJNI, ELNFPIKMDEK BHNFIJIMKJP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x20274B0", Offset = "0x20260B0", VA = "0x1820274B0")]
	public static T LILHBHNDLNN<T>(ref ADBJIOAFJHA OAGMKJFIKKL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2378B80", Offset = "0x2377780", VA = "0x182378B80")]
	public static NACGOIKMGBD FJJGCICJLPL(ref ADBJIOAFJHA OAGMKJFIKKL)
	{
		return default(NACGOIKMGBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[CGNFOFHPMEM(typeof(BNDFEICOCDN))]
[MHBJLGEIMOG(typeof(JFNAGEICNEF), new string[] { })]
public class JFNAGEICNEF : HKFIKAGKAAK, IDisposable, BNDFEICOCDN
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum NGLDDIIDIBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Undoing,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Redoing
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct ANNEBIHMDEH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly NGLDDIIDIBP DABILCLJKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly JFNAGEICNEF DNIGLLFHMCE;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x23642A0", Offset = "0x2362EA0", VA = "0x1823642A0")]
		public ANNEBIHMDEH(JFNAGEICNEF DNIGLLFHMCE, bool IMOCHOMDJFE, uint MAAFFLODELA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2364270", Offset = "0x2362E70", VA = "0x182364270", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class IBNBEFJGCIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public struct AODGNLLEFIK : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private readonly IBNBEFJGCIP APPBMIEBDNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private readonly bool ADKNFKMEDIO;

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x2364340", Offset = "0x2362F40", VA = "0x182364340")]
			public AODGNLLEFIK(IBNBEFJGCIP APPBMIEBDNJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x2364310", Offset = "0x2362F10", VA = "0x182364310", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public struct HOJJJMMJECC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private readonly IBNBEFJGCIP APPBMIEBDNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly bool ADKNFKMEDIO;

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x236BB50", Offset = "0x236A750", VA = "0x18236BB50")]
			public HOJJJMMJECC(IBNBEFJGCIP APPBMIEBDNJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x2364310", Offset = "0x2362F10", VA = "0x182364310", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly JFNAGEICNEF PEMKBFMOAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private bool CAAIGMEAKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int FHAPBMCOCLD;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x236C670", Offset = "0x236B270", VA = "0x18236C670")]
		public IBNBEFJGCIP(JFNAGEICNEF PEMKBFMOAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x236C5F0", Offset = "0x236B1F0", VA = "0x18236C5F0")]
		public bool BPLPGJOAHFE(GEGPJNFMCPG DJJOBHOILOH, LOGKGBLPOOD IPGOEGFNLNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x236C5A0", Offset = "0x236B1A0", VA = "0x18236C5A0")]
		public HOJJJMMJECC ALHODMCDPBG()
		{
			return default(HOJJJMMJECC);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x236C620", Offset = "0x236B220", VA = "0x18236C620")]
		public AODGNLLEFIK FBFCGCAOGOC()
		{
			return default(AODGNLLEFIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class JOMLEHMMNIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JFNAGEICNEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public UndoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public JOMLEHMMNIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2373430", Offset = "0x2372030", VA = "0x182373430")]
		internal RedoAction <Undo>b__0()
		{
			return default(RedoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CIPDHCEANFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public JFNAGEICNEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public RedoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public CIPDHCEANFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2365740", Offset = "0x2364340", VA = "0x182365740")]
		internal UndoAction <Redo>b__0()
		{
			return default(UndoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class OBCHMJNDIKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public OBCHMJNDIKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x23790D0", Offset = "0x2377CD0", VA = "0x1823790D0")]
		internal bool <SyncProperties>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly UndoAction EMNPHPJBFPI;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly RedoAction MCFHCAEMBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private PDEBCHPLELL FMBBKEPEKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private ActionBuffer AMPLHLNGLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private ActionBuffer AALPFLAKKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private FAMHHBOFMMF LGAGLKFDFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private AJECPHMBCBB CKBALLNFJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private TransformOwnershipPhase JLCDBIKPJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private EEALACFKCAN NAPFNNNHCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NGLDDIIDIBP FAECJCLGHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private uint HOMGFKMPCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private uint FKEHCOGCFAH;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private IBNBEFJGCIP IHEHFBLKLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x5F2620", Offset = "0x5F1220", VA = "0x1805F2620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool MLNHEONHIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x23726C0", Offset = "0x23712C0", VA = "0x1823726C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool LPBGAJPLELB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2371D10", Offset = "0x2370910", VA = "0x182371D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KCFJAONPOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2372050", Offset = "0x2370C50", VA = "0x182372050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int NLEIIICFIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x23714C0", Offset = "0x23700C0", VA = "0x1823714C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int PBFAECGGKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2372030", Offset = "0x2370C30", VA = "0x182372030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private bool IKCNACBKCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2371C50", Offset = "0x2370850", VA = "0x182371C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private bool PGMOGGIOJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2372740", Offset = "0x2371340", VA = "0x182372740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool COCJNOEELHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x747AB0", Offset = "0x7466B0", VA = "0x180747AB0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x747B00", Offset = "0x746700", VA = "0x180747B00", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private ActionBuffer LHECFLOJAPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x23721E0", Offset = "0x2370DE0", VA = "0x1823721E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action ENIIILPAFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2372290", Offset = "0x2370E90", VA = "0x182372290", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2372900", Offset = "0x2371500", VA = "0x182372900", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action PFBOCNCGKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2371680", Offset = "0x2370280", VA = "0x182371680")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x23720E0", Offset = "0x2370CE0", VA = "0x1823720E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2372D30", Offset = "0x2371930", VA = "0x182372D30")]
	public JFNAGEICNEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2372750", Offset = "0x2371350", VA = "0x182372750", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2371A00", Offset = "0x2370600", VA = "0x182371A00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2371D60", Offset = "0x2370960", VA = "0x182371D60", Slot = "14")]
	public IDisposable FOKGHAKHCNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2372210", Offset = "0x2370E10", VA = "0x182372210", Slot = "9")]
	public IDisposable LLJGHBJGLIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2372430", Offset = "0x2371030", VA = "0x182372430", Slot = "6")]
	public UndoAction MBKPDOCFBCM()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2371880", Offset = "0x2370480", VA = "0x182371880", Slot = "15")]
	public RedoAction DPBLACKALKN()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2371ED0", Offset = "0x2370AD0", VA = "0x182371ED0", Slot = "16")]
	public UndoAction HKEEANOECEL()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2371910", Offset = "0x2370510", VA = "0x182371910", Slot = "7")]
	public RedoAction DPBLACKALKN(UndoAction FNPGAOOPMNE)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2371DE0", Offset = "0x23709E0", VA = "0x182371DE0", Slot = "8")]
	public UndoAction HKEEANOECEL(RedoAction FNPGAOOPMNE)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2372670", Offset = "0x2371270", VA = "0x182372670")]
	public bool NOGFDOIJFKF(HOFFGBEPKBC ODNMCGGJLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2372330", Offset = "0x2370F30", VA = "0x182372330", Slot = "17")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2372380", Offset = "0x2370F80", VA = "0x182372380")]
	public void MAKPCLMEKLM(GEGPJNFMCPG DJJOBHOILOH, NACGOIKMGBD NCMIOOKGKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2371F60", Offset = "0x2370B60", VA = "0x182371F60")]
	public void ICIGNHPMEOJ(GEGPJNFMCPG DJJOBHOILOH, LOGKGBLPOOD IPGOEGFNLNJ, in CJHLIFJIIDK FMKHLEANADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x23724C0", Offset = "0x23710C0", VA = "0x1823724C0")]
	public void MEFONJBJIPL(GEGPJNFMCPG DJJOBHOILOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2371AF0", Offset = "0x23706F0", VA = "0x182371AF0")]
	private void EMDHBEACBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2371510", Offset = "0x2370110", VA = "0x182371510")]
	private void BFDDCJLNKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2371C30", Offset = "0x2370830", VA = "0x182371C30")]
	private void EPFPACGFNDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2371550", Offset = "0x2370150", VA = "0x182371550")]
	private INDLONCDGDD BONCFADHEEK()
	{
		return default(INDLONCDGDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x23721F0", Offset = "0x2370DF0", VA = "0x1823721F0")]
	private uint LGEPFLJLBCA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2371660", Offset = "0x2370260", VA = "0x182371660")]
	private bool DMBFFOGKONC(out INDLONCDGDD KINCGCMCJLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2371640", Offset = "0x2370240", VA = "0x182371640")]
	private bool CPNIGJAKBFL(out INDLONCDGDD KINCGCMCJLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2372180", Offset = "0x2370D80", VA = "0x182372180")]
	private RedoAction LCBAHPLAKKK(INDLONCDGDD KINCGCMCJLI)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2372080", Offset = "0x2370C80", VA = "0x182372080")]
	private UndoAction KKAFCKLCLBI(INDLONCDGDD KINCGCMCJLI)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x23729A0", Offset = "0x23715A0", VA = "0x1823729A0")]
	private INDLONCDGDD PGGOGEIMFEF(INDLONCDGDD KINCGCMCJLI, ActionBuffer HPFGIOLALHM, bool IMOCHOMDJFE)
	{
		return default(INDLONCDGDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2371C60", Offset = "0x2370860", VA = "0x182371C60")]
	private void FJHFMKLONHN(Action KINCGCMCJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2020930", Offset = "0x201F530", VA = "0x182020930")]
	private T FJHFMKLONHN<T>(Func<T> IPMEHJLOOID)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2371810", Offset = "0x2370410", VA = "0x182371810")]
	private ANNEBIHMDEH DOGODLGBKLK(bool IMOCHOMDJFE, uint MAAFFLODELA)
	{
		return default(ANNEBIHMDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2371720", Offset = "0x2370320", VA = "0x182371720")]
	[CompilerGenerated]
	private UndoAction DMIHOCPDHJF()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2372560", Offset = "0x2371160", VA = "0x182372560")]
	[CompilerGenerated]
	private RedoAction NMGLHMFEHLN()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x2371B30", Offset = "0x2370730", VA = "0x182371B30")]
	[CompilerGenerated]
	private UndoAction ENBKEELAFCN()
	{
		return default(UndoAction);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct AFOMEECCFOG : IEnumerable<ELNFPIKMDEK>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum EENDABEHHBN
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private struct HNOJKOGADAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly AFOMEECCFOG FPPBJGHNMLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly EEALACFKCAN NAPFNNNHCOO;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x263CFA0", Offset = "0x263BBA0", VA = "0x18263CFA0")]
		public HNOJKOGADAO(AFOMEECCFOG FPPBJGHNMLI, EEALACFKCAN NAPFNNNHCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x263CD10", Offset = "0x263B910", VA = "0x18263CD10")]
		public void PGOMFPMDJKF(NativeList<byte> HAFHDPBBELM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x263C7D0", Offset = "0x263B3D0", VA = "0x18263C7D0")]
		private void IAFNBDOFOKE(ELNFPIKMDEK BHNFIJIMKJP, ref HHIDEAGOJKO KNNDHIJOJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x263C820", Offset = "0x263B420", VA = "0x18263C820")]
		private void IEJPIJPBDLP(ELNFPIKMDEK BHNFIJIMKJP, ref HHIDEAGOJKO KNNDHIJOJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x263CA10", Offset = "0x263B610", VA = "0x18263CA10")]
		private NativeArray<byte> OGAPOAKFFIH(NativeList<byte> HAFHDPBBELM)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x263C700", Offset = "0x263B300", VA = "0x18263C700")]
		private NativeArray<byte> FEBIFJDMEPB(NativeList<byte> HAFHDPBBELM, int LEHFCNIEMMI)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x263CAF0", Offset = "0x263B6F0", VA = "0x18263CAF0")]
		private int OPLMAMNIFCB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x263C8B0", Offset = "0x263B4B0", VA = "0x18263C8B0")]
		private bool NGEHMMEKCFK(ELNFPIKMDEK BHNFIJIMKJP, out NativeArray<byte> PGFKEHDILMF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct BNEBIIGGCGC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NativeList<byte> OAGMKJFIKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private AFOMEECCFOG FPPBJGHNMLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly ELNFPIKMDEK FNNHACEFOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly int HGAEFGJCCPH;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x26338D0", Offset = "0x26324D0", VA = "0x1826338D0")]
		internal BNEBIIGGCGC(AFOMEECCFOG FPPBJGHNMLI, ELNFPIKMDEK FNNHACEFOCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x2633640", Offset = "0x2632240", VA = "0x182633640", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x2633800", Offset = "0x2632400", VA = "0x182633800")]
		public void OBOFHNBHJNG(NativeArray<byte> KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2633860", Offset = "0x2632460", VA = "0x182633860")]
		public void GIPAOBKFBEI(NativeArray<byte> KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x26338C0", Offset = "0x26324C0", VA = "0x1826338C0")]
		public void IEJPIJPBDLP(in CJHLIFJIIDK KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1FA99C0", Offset = "0x1FA85C0", VA = "0x181FA99C0")]
		public void IEJPIJPBDLP<T>(T KGJOJGIPNPH) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x2633670", Offset = "0x2632270", VA = "0x182633670")]
		private void FBKLJAFKEKI(int KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x26336E0", Offset = "0x26322E0", VA = "0x1826336E0")]
		private void FBKLJAFKEKI(in CJHLIFJIIDK KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x26337A0", Offset = "0x26323A0", VA = "0x1826337A0")]
		private unsafe void FBKLJAFKEKI(void* KNJIMKAPPCM, int LEHFCNIEMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x2633800", Offset = "0x2632400", VA = "0x182633800")]
		private void FBKLJAFKEKI(NativeArray<byte> MAGJNDGNDNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct IGKMPNCCHAA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private AFOMEECCFOG FPPBJGHNMLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NativeArray<byte> OAGMKJFIKKL;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x263D2B0", Offset = "0x263BEB0", VA = "0x18263D2B0")]
		internal IGKMPNCCHAA(AFOMEECCFOG FPPBJGHNMLI, NativeArray<byte> OAGMKJFIKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x263D130", Offset = "0x263BD30", VA = "0x18263D130", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x263D140", Offset = "0x263BD40", VA = "0x18263D140")]
		public NativeArray<byte> MOIICNDMGBM(int LEHFCNIEMMI)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x263D0C0", Offset = "0x263BCC0", VA = "0x18263D0C0")]
		public NativeArray<byte> AJHAELHPENG()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1EA3C10", Offset = "0x1EA2810", VA = "0x181EA3C10")]
		public T NPMCKJHAPDE<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x263D230", Offset = "0x263BE30", VA = "0x18263D230")]
		public void NPMCKJHAPDE(in EJMAFNBMMGI KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct HMFHFAKHOHB : IEnumerator<ELNFPIKMDEK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly NativeArray<ELNFPIKMDEK> LBLDONKHBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int HIANDEDCLIF;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public ELNFPIKMDEK IJPBKONCNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x263C6E0", Offset = "0x263B2E0", VA = "0x18263C6E0", Slot = "4")]
			get
			{
				return default(ELNFPIKMDEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x263C680", Offset = "0x263B280", VA = "0x18263C680", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x263C6D0", Offset = "0x263B2D0", VA = "0x18263C6D0")]
		internal HMFHFAKHOHB(NativeArray<ELNFPIKMDEK> MAGJNDGNDNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x263C5B0", Offset = "0x263B1B0", VA = "0x18263C5B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x263C630", Offset = "0x263B230", VA = "0x18263C630", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private struct HFAALLBGKFB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private const int CLMBMEIECIL = 0;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private const int CCNACDGONBO = 1;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const int PPPAHNAOGIH = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private NativeArray<int> OAGMKJFIKKL;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public int CDPMHOILCKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x263C3C0", Offset = "0x263AFC0", VA = "0x18263C3C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x263C4A0", Offset = "0x263B0A0", VA = "0x18263C4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public EENDABEHHBN DLIECNPBMFE
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x263C450", Offset = "0x263B050", VA = "0x18263C450")]
			get
			{
				return default(EENDABEHHBN);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x263C4F0", Offset = "0x263B0F0", VA = "0x18263C4F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool HBEOMPANLLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x263C510", Offset = "0x263B110", VA = "0x18263C510")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x263C3D0", Offset = "0x263AFD0", VA = "0x18263C3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool FDGBEFDFAJF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x263C4B0", Offset = "0x263B0B0", VA = "0x18263C4B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x263C3F0", Offset = "0x263AFF0", VA = "0x18263C3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x263C520", Offset = "0x263B120", VA = "0x18263C520")]
		public HFAALLBGKFB(EENDABEHHBN KBGAKCIKMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x263C4C0", Offset = "0x263B0C0", VA = "0x18263C4C0")]
		private int JHLAPKAGPFG(int FPKCCNCOJGI, int CMPAPPAEHCK = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x263C460", Offset = "0x263B060", VA = "0x18263C460")]
		private void GELHLBKPBFF(int FPKCCNCOJGI, int KGJOJGIPNPH, int CMPAPPAEHCK = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x263C410", Offset = "0x263B010", VA = "0x18263C410", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private const int LHILBBALLAM = -1;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int MCEJJBGDIOF = 0;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly ELNFPIKMDEK ONIBAKPJLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private NativeHashMap<ELNFPIKMDEK, int> FJHOAINNMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private NativeList<ELNFPIKMDEK> IHOIPNEDJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private NativeList<int> CEABBCDDKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private NativeList<byte> NBINIFDLCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NativeList<byte> OAGMKJFIKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private HFAALLBGKFB BEMMPFFAJLN;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool HBEOMPANLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x262CB40", Offset = "0x262B740", VA = "0x18262CB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool JBLGCJEBMBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x262C1E0", Offset = "0x262ADE0", VA = "0x18262C1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int CDPMHOILCKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x262C110", Offset = "0x262AD10", VA = "0x18262C110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int FNHOMNFANED
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x262CB50", Offset = "0x262B750", VA = "0x18262CB50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x262C1F0", Offset = "0x262ADF0", VA = "0x18262C1F0")]
	public static AFOMEECCFOG DPFIJBHMAAN(EENDABEHHBN KBGAKCIKMFB = EENDABEHHBN.Last, int IMAAIKDNBAB = 16, int OCOICEGOPBJ = 256)
	{
		return default(AFOMEECCFOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x262CD10", Offset = "0x262B910", VA = "0x18262CD10")]
	private AFOMEECCFOG(EENDABEHHBN KBGAKCIKMFB, int IMAAIKDNBAB, int OCOICEGOPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x262C250", Offset = "0x262AE50", VA = "0x18262C250", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x262C650", Offset = "0x262B250", VA = "0x18262C650")]
	public BNEBIIGGCGC FHENEHBGNDF(ELNFPIKMDEK FNNHACEFOCO)
	{
		return default(BNEBIIGGCGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x262C900", Offset = "0x262B500", VA = "0x18262C900")]
	public IGKMPNCCHAA KLIBGJIOOFD(ELNFPIKMDEK FNNHACEFOCO)
	{
		return default(IGKMPNCCHAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x262C320", Offset = "0x262AF20", VA = "0x18262C320")]
	public bool EFEEGLBHNCD(ELNFPIKMDEK FNNHACEFOCO, out IGKMPNCCHAA LOPBOOCOLJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x262C740", Offset = "0x262B340", VA = "0x18262C740")]
	public bool FOINPNMKDGG(ELNFPIKMDEK FNNHACEFOCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x262C790", Offset = "0x262B390", VA = "0x18262C790")]
	public bool JHIMJLJGMEA(ELNFPIKMDEK FNNHACEFOCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x262C9E0", Offset = "0x262B5E0", VA = "0x18262C9E0")]
	public void LCINHGEMEDG(NativeList<byte> HAFHDPBBELM, EEALACFKCAN NAPFNNNHCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E9C7B0", Offset = "0x1E9B3B0", VA = "0x181E9C7B0")]
	public T MBOMINHFCOP<T>(ELNFPIKMDEK FNNHACEFOCO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x262CAB0", Offset = "0x262B6B0", VA = "0x18262CAB0")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x262CB90", Offset = "0x262B790", VA = "0x18262CB90")]
	public HMFHFAKHOHB OKMFHIDEJFI()
	{
		return default(HMFHFAKHOHB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x262C490", Offset = "0x262B090", VA = "0x18262C490")]
	private void FCNAOCIEHNN(ELNFPIKMDEK FNNHACEFOCO, int HGAEFGJCCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x262C120", Offset = "0x262AD20", VA = "0x18262C120")]
	private void CAJIBACLMLC(int KPHMPLDFIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x262C840", Offset = "0x262B440", VA = "0x18262C840")]
	private void JKPDOLBFLHE(ELNFPIKMDEK FNNHACEFOCO, int HGAEFGJCCPH, int LEHFCNIEMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1E9C910", Offset = "0x1E9B510", VA = "0x181E9C910")]
	private static T MBOMINHFCOP<T>(NativeArray<byte> LBLDONKHBCF, int FPKCCNCOJGI = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x262CC50", Offset = "0x262B850", VA = "0x18262CC50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x262CC00", Offset = "0x262B800", VA = "0x18262CC00", Slot = "4")]
	private IEnumerator<ELNFPIKMDEK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class MPKJLGMNBDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private NativeArray<byte> LBLDONKHBCF;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int BBJDPOLPLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x678670", Offset = "0x677270", VA = "0x180678670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xD64B80", Offset = "0xD63780", VA = "0x180D64B80")]
	public MPKJLGMNBDH(NativeArray<byte> LBLDONKHBCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2379070", Offset = "0x2377C70", VA = "0x182379070")]
	public static MPKJLGMNBDH GOPIOOMOEDD(NativeArray<byte> LBLDONKHBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	public T NPMCKJHAPDE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	public NativeArray<T> MOIICNDMGBM<T>(int LEHFCNIEMMI, Allocator HGKGLCNFHPJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	public NativeArray<T> AJHAELHPENG<T>(Allocator HGKGLCNFHPJ) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class ADBJIOAFJHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private NativeArray<byte> LBLDONKHBCF;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int BBJDPOLPLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x678670", Offset = "0x677270", VA = "0x180678670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xD64B80", Offset = "0xD63780", VA = "0x180D64B80")]
	public ADBJIOAFJHA(NativeArray<byte> LBLDONKHBCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x262C050", Offset = "0x262AC50", VA = "0x18262C050")]
	public static ADBJIOAFJHA GOPIOOMOEDD(NativeArray<byte> LBLDONKHBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x1E9A690", Offset = "0x1E99290", VA = "0x181E9A690")]
	public T NPMCKJHAPDE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	public NativeArray<T> MOIICNDMGBM<T>(int LEHFCNIEMMI, Allocator HGKGLCNFHPJ) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class HHIDEAGOJKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private NativeArray<byte> LBLDONKHBCF;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int BBJDPOLPLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x678670", Offset = "0x677270", VA = "0x180678670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xD64B80", Offset = "0xD63780", VA = "0x180D64B80")]
	public HHIDEAGOJKO(NativeArray<byte> LBLDONKHBCF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x236A290", Offset = "0x2368E90", VA = "0x18236A290")]
	public static HHIDEAGOJKO GOPIOOMOEDD(NativeArray<byte> LBLDONKHBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2D41D00", Offset = "0x2D40900", VA = "0x182D41D00")]
	public void PIIHMJEHKFJ<T>(in T KGJOJGIPNPH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2D41BF0", Offset = "0x2D407F0", VA = "0x182D41BF0")]
	public void CKHPMCJIJJP<T>(NativeArray<T> MAGJNDGNDNI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	public void AOKAACEGBGF<T>(NativeArray<T> KGJOJGIPNPH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class BPKDAMCNOFI
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x2633B30", Offset = "0x2632730", VA = "0x182633B30")]
	public static Span<byte> MBGBGGNMLCI(this NativeArray<byte> LBLDONKHBCF)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2633BB0", Offset = "0x26327B0", VA = "0x182633BB0")]
	public static ReadOnlySpan<byte> PGLOOECKDPD(this NativeArray<byte> LBLDONKHBCF)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2633AC0", Offset = "0x26326C0", VA = "0x182633AC0")]
	public static NativeArray<byte> LJEIAFMFNBJ(this NativeArray<byte> LBLDONKHBCF, int HGAEFGJCCPH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x26339E0", Offset = "0x26325E0", VA = "0x1826339E0")]
	public static NativeArray<byte> BKANPCKDKJJ(this NativeArray<byte> LBLDONKHBCF, int BKKGFAKFDNB = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x34EC070", Offset = "0x34EAC70", VA = "0x1834EC070")]
	public static NativeArray<byte> BKANPCKDKJJ<T>(this NativeArray<byte> LBLDONKHBCF, int BKKGFAKFDNB = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2633A50", Offset = "0x2632650", VA = "0x182633A50")]
	public static NativeArray<byte> CGAEDNBDHLJ(this NativeArray<byte> LBLDONKHBCF, int BKKGFAKFDNB)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x34EC0D0", Offset = "0x34EACD0", VA = "0x1834EC0D0")]
	public static NativeArray<byte> CGAEDNBDHLJ<T>(this NativeArray<byte> LBLDONKHBCF, int BKKGFAKFDNB = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2633970", Offset = "0x2632570", VA = "0x182633970")]
	public static NativeArray<byte> AGMCCGLPHKN(this NativeArray<byte> LBLDONKHBCF, int BKKGFAKFDNB = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x34EADB0", Offset = "0x34E99B0", VA = "0x1834EADB0")]
	public static NativeArray<byte> AGMCCGLPHKN<T>(this NativeArray<byte> LBLDONKHBCF, int BKKGFAKFDNB = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class GKCEEFIIINA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private NativeList<byte> FPPBJGHNMLI;

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0xD64B80", Offset = "0xD63780", VA = "0x180D64B80")]
	public GKCEEFIIINA(NativeList<byte> FPPBJGHNMLI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2367CB0", Offset = "0x23668B0", VA = "0x182367CB0")]
	public static GKCEEFIIINA GOPIOOMOEDD(NativeList<byte> LBLDONKHBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	public void PIIHMJEHKFJ<T>(in T KGJOJGIPNPH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	public void CKHPMCJIJJP<T>(NativeArray<T> KGJOJGIPNPH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	public void AOKAACEGBGF<T>(NativeArray<T> KGJOJGIPNPH) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.PropertyChanges)]
	[MHBJLGEIMOG(typeof(PropertyChangeNetworkRouter), new string[] { })]
	public class PropertyChangeNetworkRouter : CCILBHCKADC, HKFIKAGKAAK, POEIGJOFIAI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private PDEBCHPLELL NHILDHCHLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private BIJOBGIJDDE FGCLHPLIFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private JDGCMEDKNHD GCALAGNGEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private JJKLIPHNGMC PJLEPPJJBAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private ELNFPIKMDEK BHNFIJIMKJP;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public PDEBCHPLELL ICJJIJLKDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x26BC4B0", Offset = "0x26BB0B0", VA = "0x1826BC4B0")]
		public PDEBCHPLELL.FPEPBNDINKA EGLPICINJKG()
		{
			return default(PDEBCHPLELL.FPEPBNDINKA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x26BC8D0", Offset = "0x26BB4D0", VA = "0x1826BC8D0", Slot = "4")]
		public void NGNFNBOGJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x26BC9F0", Offset = "0x26BB5F0", VA = "0x1826BC9F0", Slot = "5")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x26BC780", Offset = "0x26BB380", VA = "0x1826BC780")]
		public void MBKPDOCFBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x26BC4F0", Offset = "0x26BB0F0", VA = "0x1826BC4F0")]
		private void FHENEHBGNDF(ELNFPIKMDEK FNNHACEFOCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x26BC2B0", Offset = "0x26BAEB0", VA = "0x1826BC2B0")]
		private void APKBAKIONAK(ELNFPIKMDEK FNNHACEFOCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x26BCA80", Offset = "0x26BB680", VA = "0x1826BCA80")]
		private void PHACBMHGHHP(ELNFPIKMDEK FNNHACEFOCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x26BC740", Offset = "0x26BB340", VA = "0x1826BC740")]
		private void GMLOPMBELMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x26BC760", Offset = "0x26BB360", VA = "0x1826BC760")]
		private void INJMALCLDFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x26BC3E0", Offset = "0x26BAFE0", VA = "0x1826BC3E0")]
		private void CINJMCCCMMF(ELNFPIKMDEK FNNHACEFOCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x22F50D0", Offset = "0x22F3CD0", VA = "0x1822F50D0", Slot = "6")]
		private void COKGAIHLLPN<TKey, T>(global::GJOMGFAOOGO<TKey, T> MDENPOJAPFE, object NAEOEJMOBMH) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x26BC470", Offset = "0x26BB070", VA = "0x1826BC470", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[MHBJLGEIMOG(typeof(CLMJPPGIGCM), new string[] { })]
public class CLMJPPGIGCM : HKFIKAGKAAK, GEPKKGPMACB
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly FDBHFPKFKKI KDLDCAEGOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private DGMHFGJILHI DPCBGLAGGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private DMOLBBGANCB GCALAGNGEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private JFNAGEICNEF PEMKBFMOAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private PropertyChangeNetworkRouter GELHOPIHJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private LOGKGBLPOOD JGFOPPOOCFM;

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2634520", Offset = "0x2633120", VA = "0x182634520", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x26342C0", Offset = "0x2632EC0", VA = "0x1826342C0", Slot = "5")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2634270", Offset = "0x2632E70", VA = "0x182634270")]
	public void MAKPCLMEKLM(GEGPJNFMCPG DJJOBHOILOH, NACGOIKMGBD NCMIOOKGKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x26340C0", Offset = "0x2632CC0", VA = "0x1826340C0")]
	public void ICIGNHPMEOJ(GEGPJNFMCPG DJJOBHOILOH, LOGKGBLPOOD IPGOEGFNLNJ, in CJHLIFJIIDK HOMEBBNJHJM, in CJHLIFJIIDK FMKHLEANADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2634390", Offset = "0x2632F90", VA = "0x182634390")]
	public void MEFONJBJIPL(GEGPJNFMCPG DJJOBHOILOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x26340A0", Offset = "0x2632CA0", VA = "0x1826340A0")]
	private void FLABMHAFCME(GEGPJNFMCPG DJJOBHOILOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2634070", Offset = "0x2632C70", VA = "0x182634070")]
	public void CDAHPMEONKF(GEGPJNFMCPG DJJOBHOILOH, LOGKGBLPOOD IPGOEGFNLNJ, in CJHLIFJIIDK HOMEBBNJHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2634100", Offset = "0x2632D00", VA = "0x182634100")]
	private void JOOJLHOHLFM(GEGPJNFMCPG DJJOBHOILOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2634620", Offset = "0x2633220", VA = "0x182634620")]
	public CLMJPPGIGCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal abstract class FBLIGDIKMKD : HKFIKAGKAAK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private FAMHHBOFMMF LGAGLKFDFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private uint EKFGKGBLGMF;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public abstract uint NNHDOJDNMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x2639210", Offset = "0x2637E10", VA = "0x182639210", Slot = "7")]
	public virtual void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2639030", Offset = "0x2637C30", VA = "0x182639030", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x26391C0", Offset = "0x2637DC0", VA = "0x1826391C0")]
	public GEGPJNFMCPG NCPFMNFECPH()
	{
		return default(GEGPJNFMCPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2639130", Offset = "0x2637D30", VA = "0x182639130")]
	public void IGKNGAMANNE(GEGPJNFMCPG NFBGOIJEFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x26391B0", Offset = "0x2637DB0", VA = "0x1826391B0", Slot = "8")]
	public virtual void MFLCPIEJCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	protected FBLIGDIKMKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[MHBJLGEIMOG(typeof(KCMHMBMGMLH), new string[] { })]
internal sealed class KCMHMBMGMLH : FBLIGDIKMKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private JDDPPIAFHCO NOMIILNDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private uint OFMNEHOBEDK;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public override uint NNHDOJDNMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5ED390", Offset = "0x5EBF90", VA = "0x1805ED390", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x23740C0", Offset = "0x2372CC0", VA = "0x1823740C0", Slot = "7")]
	public override void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2374070", Offset = "0x2372C70", VA = "0x182374070")]
	private void MLOGCBMDDDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2374010", Offset = "0x2372C10", VA = "0x182374010", Slot = "8")]
	public override void MFLCPIEJCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480")]
	public KCMHMBMGMLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[MHBJLGEIMOG(typeof(DOEOBGNPDCP), new string[] { })]
internal sealed class DOEOBGNPDCP : FBLIGDIKMKD
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public override uint NNHDOJDNMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x619E80", Offset = "0x618A80", VA = "0x180619E80", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public DOEOBGNPDCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[MHBJLGEIMOG(typeof(PHPABLLJDIC), new string[] { })]
[IBGAMCLMLFP(typeof(BHBECLCNBCK))]
internal sealed class PHPABLLJDIC : POIJNBNBJIE, CCILBHCKADC, HKFIKAGKAAK, GEPKKGPMACB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private BHBECLCNBCK JFAHNIMFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private PNPPGDJCNCL LCAGHKIOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private EntityQuery LCAKKNELIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private EntityQuery KNEKPJGLHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private EntityQuery MNLEGMCPKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private EntityManager JGHLJDFOODE
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x26BAD00", Offset = "0x26B9900", VA = "0x1826BAD00")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EntityQuery DPJPHPCHMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xECB570", Offset = "0xECA170", VA = "0x180ECB570")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public EntityQuery GEGHNEDNNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8EDC70", Offset = "0x8EC870", VA = "0x1808EDC70")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EntityQuery KHLKPJEBMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x26BA710", Offset = "0x26B9310", VA = "0x1826BA710")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int BDEPJHADJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x26BA790", Offset = "0x26B9390", VA = "0x1826BA790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int APIEBBKHJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x26BA6B0", Offset = "0x26B92B0", VA = "0x1826BA6B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int LLJOOOFFFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x26BA5E0", Offset = "0x26B91E0", VA = "0x1826BA5E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "4")]
	public void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x26BAC80", Offset = "0x26B9880", VA = "0x1826BAC80", Slot = "5")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x26BA950", Offset = "0x26B9550", VA = "0x1826BA950", Slot = "6")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x26BA7B0", Offset = "0x26B93B0", VA = "0x1826BA7B0")]
	public GFHDAMOBKPG JBHFHGBJOHN()
	{
		return default(GFHDAMOBKPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x26BA850", Offset = "0x26B9450", VA = "0x1826BA850")]
	public GFHDAMOBKPG JDHGNGDFFJH()
	{
		return default(GFHDAMOBKPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x26BAD50", Offset = "0x26B9950", VA = "0x1826BAD50")]
	public GFHDAMOBKPG PMIPFGMILFK()
	{
		return default(GFHDAMOBKPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x26BABD0", Offset = "0x26B97D0", VA = "0x1826BABD0")]
	public IFCMLGGILLI MDFJJHGEBIB(OLACMNNNFCK DJJOBHOILOH)
	{
		return default(IFCMLGGILLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x26BAB20", Offset = "0x26B9720", VA = "0x1826BAB20")]
	public IFCMLGGILLI MDFJJHGEBIB(Entity OCMABEPCGDM)
	{
		return default(IFCMLGGILLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x26BA600", Offset = "0x26B9200", VA = "0x1826BA600")]
	public CMECOJAJFAB DAHCABLJMIA(Entity OCMABEPCGDM)
	{
		return default(CMECOJAJFAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x26BA6D0", Offset = "0x26B92D0", VA = "0x1826BA6D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x26BA530", Offset = "0x26B9130", VA = "0x1826BA530")]
	private GFHDAMOBKPG AFAMNJBNPFD(EntityQuery LJHHKNNHAFE)
	{
		return default(GFHDAMOBKPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x26BADF0", Offset = "0x26B99F0", VA = "0x1826BADF0")]
	public PHPABLLJDIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[MHBJLGEIMOG(typeof(PNPPGDJCNCL), new string[] { })]
public class ICIAKIGIIEJ : HKFIKAGKAAK, PNPPGDJCNCL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private BHBECLCNBCK JFAHNIMFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private JDDPPIAFHCO NOMIILNDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private ObjectLifecycleService AFFPNCMAGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private ObjectEmbodimentService MPHBIKLMOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private ObjectPrefabCreationService PNALABGJPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private ObjectNetworkToLocalMapService FBKDDNILPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PHPABLLJDIC IAMBEOMBAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private FAMHHBOFMMF LGAGLKFDFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public BDNIJAOEAEJ FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x236D630", Offset = "0x236C230", VA = "0x18236D630", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private EntityManager JGHLJDFOODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x236DEA0", Offset = "0x236CAA0", VA = "0x18236DEA0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int BDEPJHADJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x236CF00", Offset = "0x236BB00", VA = "0x18236CF00", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int APIEBBKHJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x236CA10", Offset = "0x236B610", VA = "0x18236CA10", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int LLJOOOFFFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x236C6B0", Offset = "0x236B2B0", VA = "0x18236C6B0", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int LOFNLMCKNKP
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x236D9D0", Offset = "0x236C5D0", VA = "0x18236D9D0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int MBIGNBJABEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x236D190", Offset = "0x236BD90", VA = "0x18236D190", Slot = "44")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<OLACMNNNFCK, CMECOJAJFAB> EMLABCEDMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x236D570", Offset = "0x236C170", VA = "0x18236D570", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x236DAF0", Offset = "0x236C6F0", VA = "0x18236DAF0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<OLACMNNNFCK> CKLIGLIHAAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x236D080", Offset = "0x236BC80", VA = "0x18236D080", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x236DBC0", Offset = "0x236C7C0", VA = "0x18236DBC0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x236DC60", Offset = "0x236C860", VA = "0x18236DC60", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x236CE60", Offset = "0x236BA60", VA = "0x18236CE60")]
	private void GGDIKPGNAIK(Entity OCMABEPCGDM, CMECOJAJFAB LBEKIEDKPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x236C6D0", Offset = "0x236B2D0", VA = "0x18236C6D0")]
	private void BJKFMAOMKEI(Entity OCMABEPCGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x236D120", Offset = "0x236BD20", VA = "0x18236D120")]
	internal OLACMNNNFCK IFOLMIHIJBP(Entity OCMABEPCGDM)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x236D770", Offset = "0x236C370", VA = "0x18236D770", Slot = "36")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	private void EBIHGNNAOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x236CA30", Offset = "0x236B630", VA = "0x18236CA30", Slot = "38")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x236D260", Offset = "0x236BE60", VA = "0x18236D260", Slot = "11")]
	public GFHDAMOBKPG JBHFHGBJOHN()
	{
		return default(GFHDAMOBKPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x236D2A0", Offset = "0x236BEA0", VA = "0x18236D2A0", Slot = "41")]
	public GFHDAMOBKPG JDHGNGDFFJH()
	{
		return default(GFHDAMOBKPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x236DEF0", Offset = "0x236CAF0", VA = "0x18236DEF0", Slot = "42")]
	public GFHDAMOBKPG PMIPFGMILFK()
	{
		return default(GFHDAMOBKPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x236D970", Offset = "0x236C570", VA = "0x18236D970", Slot = "12")]
	public IFCMLGGILLI MDFJJHGEBIB(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(IFCMLGGILLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x236C9D0", Offset = "0x236B5D0", VA = "0x18236C9D0", Slot = "13")]
	public CMECOJAJFAB DAHCABLJMIA(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(CMECOJAJFAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x236C7B0", Offset = "0x236B3B0", VA = "0x18236C7B0", Slot = "35")]
	public bool CAACINLFJOH(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x236DA10", Offset = "0x236C610", VA = "0x18236DA10", Slot = "31")]
	public void MOANCCAMPPP(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x236D6A0", Offset = "0x236C2A0", VA = "0x18236D6A0", Slot = "32")]
	public void LEPAFNJMDJH(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x236CE30", Offset = "0x236BA30", VA = "0x18236CE30", Slot = "33")]
	public void GENHPMKNFBO(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x236D9A0", Offset = "0x236C5A0", VA = "0x18236D9A0", Slot = "37")]
	public void MGGAELLGHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x236D8F0", Offset = "0x236C4F0", VA = "0x18236D8F0", Slot = "25")]
	public NIJAIOMNHOO MAKPCLMEKLM(CMECOJAJFAB LBEKIEDKPCN)
	{
		return default(NIJAIOMNHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x236D6F0", Offset = "0x236C2F0", VA = "0x18236D6F0", Slot = "26")]
	public NIJAIOMNHOO LINIIDLAFGB(CMECOJAJFAB LBEKIEDKPCN)
	{
		return default(NIJAIOMNHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x236C8D0", Offset = "0x236B4D0", VA = "0x18236C8D0", Slot = "27")]
	public NIJAIOMNHOO CIIKAHOEEGC(GEGPJNFMCPG PJIBLINGJGM, CMECOJAJFAB LBEKIEDKPCN)
	{
		return default(NIJAIOMNHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x236D1B0", Offset = "0x236BDB0", VA = "0x18236D1B0", Slot = "28")]
	public ANMPIPGPBIJ INJJBKJOIPH()
	{
		return default(ANMPIPGPBIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x236C7E0", Offset = "0x236B3E0", VA = "0x18236C7E0", Slot = "43")]
	public EMNJFMALKFJ CCLEBNHPCMF(JLAGNLCEABL LIJLAEFJGCI)
	{
		return default(EMNJFMALKFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x236CD60", Offset = "0x236B960", VA = "0x18236CD60", Slot = "29")]
	public ICMKMEOPNCP FLFOCNDOJDB()
	{
		return default(ICMKMEOPNCP);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x236CC70", Offset = "0x236B870", VA = "0x18236CC70", Slot = "30")]
	public PMDGNJFCLOI FDLHEELIDBF(HNGFAHNAKGA LIJLAEFJGCI)
	{
		return default(PMDGNJFCLOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x236D610", Offset = "0x236C210", VA = "0x18236D610", Slot = "15")]
	public void KIEPKILKNCN(GEGPJNFMCPG PJIBLINGJGM, DCFEMLAEOED MPPBCOBNMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x236CF20", Offset = "0x236BB20", VA = "0x18236CF20", Slot = "16")]
	public NIJAIOMNHOO GJJJIKECOBM(OLACMNNNFCK AIJKIAIKFDH, [Optional] object KJKNLGILOFJ)
	{
		return default(NIJAIOMNHOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x236D2E0", Offset = "0x236BEE0", VA = "0x18236D2E0", Slot = "17")]
	public bool JIJGEKFIGAG(OLACMNNNFCK AIJKIAIKFDH, out DCFEMLAEOED MIILAJKCKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x236DE50", Offset = "0x236CA50", VA = "0x18236DE50", Slot = "45")]
	public Transform PBOMICHDFFI(OLACMNNNFCK AIJKIAIKFDH, [Optional] object KJKNLGILOFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x236D030", Offset = "0x236BC30", VA = "0x18236D030", Slot = "19")]
	public bool HLICONCCCHB(OLACMNNNFCK AIJKIAIKFDH, out Transform BHPNFBEEMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x236D150", Offset = "0x236BD50", VA = "0x18236D150", Slot = "20")]
	public bool IHHKOCLPKGP(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x236DAA0", Offset = "0x236C6A0", VA = "0x18236DAA0")]
	public bool NDCMKCIPONE(DCFEMLAEOED KGJOJGIPNPH, [Optional] object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x236DAC0", Offset = "0x236C6C0", VA = "0x18236DAC0", Slot = "46")]
	public bool NDCMKCIPONE(OLACMNNNFCK AIJKIAIKFDH, [Optional] object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x236D550", Offset = "0x236C150", VA = "0x18236D550", Slot = "47")]
	public void JLPPDNNBING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x236D330", Offset = "0x236BF30", VA = "0x18236D330", Slot = "18")]
	public void JKILOOENFCD(DCFEMLAEOED EBMPLNBFAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x236C890", Offset = "0x236B490", VA = "0x18236C890", Slot = "48")]
	public void CDMCPOLNFEM(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x236D680", Offset = "0x236C280", VA = "0x18236D680", Slot = "21")]
	public void LEDODGGAFMD(Entity OCMABEPCGDM, object KJKNLGILOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x236D9F0", Offset = "0x236C5F0", VA = "0x18236D9F0", Slot = "22")]
	public bool MKGAPOGLBHP(Entity OCMABEPCGDM, object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x236CD40", Offset = "0x236B940", VA = "0x18236CD40", Slot = "49")]
	public bool FHOEAEMPIAC(Entity OCMABEPCGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x236C9B0", Offset = "0x236B5B0", VA = "0x18236C9B0", Slot = "50")]
	public bool DADCOIIIOOC(Entity OCMABEPCGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x236C760", Offset = "0x236B360", VA = "0x18236C760", Slot = "34")]
	public NativeArray<(OLACMNNNFCK, OLACMNNNFCK)> BMFKHGCIIMB(NativeArray<OLACMNNNFCK> BCDDKJBGLOL, Allocator HGKGLCNFHPJ)
	{
		return default(NativeArray<(OLACMNNNFCK, OLACMNNNFCK)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x236DB90", Offset = "0x236C790", VA = "0x18236DB90", Slot = "24")]
	public GEGPJNFMCPG OJFOEHBFNEO(OLACMNNNFCK AIJKIAIKFDH)
	{
		return default(GEGPJNFMCPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x236DA60", Offset = "0x236C660", VA = "0x18236DA60", Slot = "23")]
	public OLACMNNNFCK NBOBFLKDCHO(GEGPJNFMCPG PJIBLINGJGM)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public ICIAKIGIIEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[MHBJLGEIMOG(typeof(HLMMNONOKJE), new string[] { })]
internal sealed class HLMMNONOKJE : HKFIKAGKAAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private ObjectPrefabCreationService PNALABGJPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PHPABLLJDIC IAMBEOMBAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private IEEMDNAPKGD JFAHNIMFMGP;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x236BAA0", Offset = "0x236A6A0", VA = "0x18236BAA0", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x236B1E0", Offset = "0x2369DE0", VA = "0x18236B1E0")]
	public NativeArray<(OLACMNNNFCK, OLACMNNNFCK)> BMFKHGCIIMB(NativeArray<OLACMNNNFCK> BCDDKJBGLOL, Allocator HGKGLCNFHPJ)
	{
		return default(NativeArray<(OLACMNNNFCK, OLACMNNNFCK)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x236B490", Offset = "0x236A090", VA = "0x18236B490")]
	private void JAEKFPHNMLK(NativeMultiHashMap<int, (OLACMNNNFCK src, OLACMNNNFCK dst)> PFBAHJLMAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x236B620", Offset = "0x236A220", VA = "0x18236B620")]
	private void LKMGMOLDBNI(NativeMultiHashMap<int, (OLACMNNNFCK src, OLACMNNNFCK dst)> PFBAHJLMAHG, int LBEKIEDKPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x236B310", Offset = "0x2369F10", VA = "0x18236B310")]
	private void CPHAPHCMJBG(NativeMultiHashMap<int, (OLACMNNNFCK src, OLACMNNNFCK dst)> PFBAHJLMAHG, int LBEKIEDKPCN, BMGOEDLPBCC GCALAGNGEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x236B820", Offset = "0x236A420", VA = "0x18236B820")]
	private NativeMultiHashMap<int, (OLACMNNNFCK, OLACMNNNFCK)> MGGPAJDKABD(Allocator HGKGLCNFHPJ, NativeArray<OLACMNNNFCK> BCDDKJBGLOL, out NativeArray<(OLACMNNNFCK src, OLACMNNNFCK dst)> KAAPKPMMFOI)
	{
		return default(NativeMultiHashMap<int, (OLACMNNNFCK, OLACMNNNFCK)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public HLMMNONOKJE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Physics, new string[] { "Callbacks" })]
	[MHBJLGEIMOG(typeof(CGDNGNAEAEB), new string[] { })]
	public class PhysicsService : HKFIKAGKAAK, GEPKKGPMACB, CGDNGNAEAEB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private const string HMNKPHEJHGF = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private static readonly LJFAOMOPGNF GBFAHFKFDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private EntityManager EJMLDDGCGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private PNPPGDJCNCL LCAGHKIOCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private BHBECLCNBCK JFAHNIMFMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private LPLPHKHEJPF GOBNCKEJNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private PropertyEventCallbacksService BFLBJHJBHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private global::OPNPNKDOEBI<EFIPFMNBNEP> MMHPFJINJDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool JMNCCKFMNPP;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<OLACMNNNFCK, EFIPFMNBNEP> LDJMFHIIANF
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x26BBF70", Offset = "0x26BAB70", VA = "0x1826BBF70", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x26BBED0", Offset = "0x26BAAD0", VA = "0x1826BBED0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x26BC140", Offset = "0x26BAD40", VA = "0x1826BC140", Slot = "4")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x26BC010", Offset = "0x26BAC10", VA = "0x1826BC010", Slot = "5")]
		public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x26BBE40", Offset = "0x26BAA40", VA = "0x1826BBE40", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x26BBB20", Offset = "0x26BA720", VA = "0x1826BBB20", Slot = "8")]
		public void CFMEOAJHJLM(OLACMNNNFCK AIJKIAIKFDH, Vector3 PPELONMPOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x26BBD20", Offset = "0x26BA920", VA = "0x1826BBD20", Slot = "9")]
		public bool DPBFMIFIKKP(OLACMNNNFCK AIJKIAIKFDH, out Collider PCJIIECCPGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x26BBC70", Offset = "0x26BA870", VA = "0x1826BBC70")]
		private void DMLAOBNBBHI(Entity OCMABEPCGDM, LOGKGBLPOOD IPGOEGFNLNJ, CJHLIFJIIDK HKEHKHLKJGF, CJHLIFJIIDK DIPKCPLHHFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x26BBBD0", Offset = "0x26BA7D0", VA = "0x1826BBBD0", Slot = "10")]
		public void DABDDLKBAAA(OLACMNNNFCK AIJKIAIKFDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public PhysicsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class DMJDGNJDGCD : OPGBJHDIFOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly string DCEJMCMJJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly DMJDGNJDGCD PJNGAGOGAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly List<DMJDGNJDGCD> IGOAEKINAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly List<CNAIOOCFPBI> GCALAGNGEDP;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string HGFKPNBBHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public OPGBJHDIFOD OCEDBDOODNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public IEnumerable<OPGBJHDIFOD> LCDHICJAIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public IEnumerable<CNAIOOCFPBI> ALNEDOGAKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2634E60", Offset = "0x2633A60", VA = "0x182634E60")]
	public DMJDGNJDGCD(string FHNLBBBEDLN, DMJDGNJDGCD MKOLBPGKLJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[MHBJLGEIMOG(typeof(JMOLPEEPLPD), new string[] { })]
[IBGAMCLMLFP(typeof(ODHGFDMHCDN))]
public sealed class JDHNHBCJKIP : JMOLPEEPLPD, POIJNBNBJIE, CCILBHCKADC, HKFIKAGKAAK, GEPKKGPMACB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class EJIDEGEFNKL : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x5ED000", Offset = "0x5EBC00", VA = "0x1805ED000", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x2366090", Offset = "0x2364C90", VA = "0x182366090", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA157D0", Offset = "0xA143D0", VA = "0x180A157D0")]
		[DebuggerHidden]
		public EJIDEGEFNKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x2365D90", Offset = "0x2364990", VA = "0x182365D90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x2366040", Offset = "0x2364C40", VA = "0x182366040", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2365FA0", Offset = "0x2364BA0", VA = "0x182365FA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2365FA0", Offset = "0x2364BA0", VA = "0x182365FA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly NKGHJKEILFF HNKHBJJOLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<string, DMJDGNJDGCD> KIOJKFIPAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly Dictionary<int, OPGBJHDIFOD> ADHCAPPFCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<CNAIOOCFPBI> PKNEGMKKKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private ODHGFDMHCDN GCALAGNGEDP;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public OPGBJHDIFOD ECJELJADPEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x23704A0", Offset = "0x236F0A0", VA = "0x1823704A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public List<CNAIOOCFPBI> LCMOOCKGDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
	public void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2370B50", Offset = "0x236F750", VA = "0x182370B50", Slot = "8")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2370A50", Offset = "0x236F650", VA = "0x182370A50", Slot = "9")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2370270", Offset = "0x236EE70", VA = "0x182370270", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2370A70", Offset = "0x236F670", VA = "0x182370A70", Slot = "6")]
	public bool MLIBNAGMIDF(CNAIOOCFPBI MDENPOJAPFE, out OPGBJHDIFOD MFEOBENMMAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2370680", Offset = "0x236F280", VA = "0x182370680")]
	private void JPEKGBIGNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2370500", Offset = "0x236F100", VA = "0x182370500")]
	private void IGIMJNOCBCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2370330", Offset = "0x236EF30", VA = "0x182370330")]
	private DMJDGNJDGCD GEFKDCJBFFO(string EHLMHMONAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x23704A0", Offset = "0x236F0A0", VA = "0x1823704A0")]
	private DMJDGNJDGCD IFJLBJBCGPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x236FF10", Offset = "0x236EB10", VA = "0x18236FF10")]
	private DMJDGNJDGCD ACMIDDGNEIJ(string EHLMHMONAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2370C00", Offset = "0x236F800", VA = "0x182370C00")]
	private DMJDGNJDGCD POBNBICHNEK(string ABEDOAAIHDK, string KJKNLGILOFJ, [Optional] DMJDGNJDGCD PJNGAGOGAFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x23702C0", Offset = "0x236EEC0", VA = "0x1823702C0")]
	[IteratorStateMachine(typeof(EJIDEGEFNKL))]
	private IEnumerable<(string, string)> EDCEGLGDCML(string EHLMHMONAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2370BB0", Offset = "0x236F7B0", VA = "0x182370BB0")]
	private bool PJLOMFGIODD(CNAIOOCFPBI MDENPOJAPFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x23703E0", Offset = "0x236EFE0", VA = "0x1823703E0")]
	private NKGHJKEILFF IBIBPBJALAB(CNAIOOCFPBI MDENPOJAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2370390", Offset = "0x236EF90", VA = "0x182370390")]
	private NKGHJKEILFF HMMHLDNBHND(CNAIOOCFPBI MDENPOJAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2370200", Offset = "0x236EE00", VA = "0x182370200")]
	private NKGHJKEILFF BIBMKHDHDDB(CNAIOOCFPBI MDENPOJAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x20206E0", Offset = "0x201F2E0", VA = "0x1820206E0")]
	private T JNGKJJKDIEJ<T>(CNAIOOCFPBI MDENPOJAPFE) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2370AF0", Offset = "0x236F6F0", VA = "0x182370AF0")]
	private FieldInfo OJJHKHKDOCM(CNAIOOCFPBI MDENPOJAPFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2370CF0", Offset = "0x236F8F0", VA = "0x182370CF0")]
	public JDHNHBCJKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2370160", Offset = "0x236ED60", VA = "0x182370160")]
	[CompilerGenerated]
	private int AONONGBBBFP(CNAIOOCFPBI FNKIIBFNLFB, CNAIOOCFPBI EDLPJGEPJPK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[IBGAMCLMLFP(typeof(HICHFOGIHHE))]
[DefaultMember("Item")]
[MHBJLGEIMOG(typeof(DMOLBBGANCB), new string[] { })]
public class AIBDKAFIDCI : DMOLBBGANCB, IEnumerable<FCAJCLOJKEA>, IEnumerable, POIJNBNBJIE, CCILBHCKADC, HKFIKAGKAAK, GEPKKGPMACB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly Dictionary<(Type, string), int> FJFPNHBAFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private HICHFOGIHHE GCALAGNGEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private HFMKNHEBJPF FCADEJJBLCG;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x26304C0", Offset = "0x262F0C0", VA = "0x1826304C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public FCAJCLOJKEA GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x26301C0", Offset = "0x262EDC0", VA = "0x1826301C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public FCAJCLOJKEA GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x26301C0", Offset = "0x262EDC0", VA = "0x1826301C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2630470", Offset = "0x262F070", VA = "0x182630470", Slot = "11")]
	public void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x26304E0", Offset = "0x262F0E0", VA = "0x1826304E0", Slot = "12")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "13")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x262FD10", Offset = "0x262E910", VA = "0x18262FD10")]
	private void BLPMFAKOHJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1D998E0", Offset = "0x1D984E0", VA = "0x181D998E0")]
	private string NIEPCANHHEN(string FHNLBBBEDLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x26300E0", Offset = "0x262ECE0", VA = "0x1826300E0", Slot = "7")]
	public FCAJCLOJKEA EIPNDAPIEGF(BDHIOHAFMEG OHDKCBCOIKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2630200", Offset = "0x262EE00", VA = "0x182630200")]
	private bool HBEBNOHKFEC(Type PIKMLOGMBBA, string FHNLBBBEDLN, out FCAJCLOJKEA IOBOHFJFMJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x262FFD0", Offset = "0x262EBD0", VA = "0x18262FFD0", Slot = "8")]
	public LOGKGBLPOOD DDLLOIBHPCA(BDHIOHAFMEG OHDKCBCOIKL)
	{
		return default(LOGKGBLPOOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x26301E0", Offset = "0x262EDE0", VA = "0x1826301E0", Slot = "9")]
	public IEnumerator<FCAJCLOJKEA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x26301E0", Offset = "0x262EDE0", VA = "0x1826301E0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2630560", Offset = "0x262F160", VA = "0x182630560")]
	public AIBDKAFIDCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[DefaultMember("Item")]
public interface EEALACFKCAN
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AGAAPJDGKGH(LOGKGBLPOOD DJHPMDEHJMK, out int OEBMILJLIAL);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[IBGAMCLMLFP(typeof(JDGCMEDKNHD))]
[MHBJLGEIMOG(typeof(EEALACFKCAN), new string[] { })]
[DefaultMember("Item")]
public class LMIIDDAGOIP : HKFIKAGKAAK, GEPKKGPMACB, EEALACFKCAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<LOGKGBLPOOD, int> LOEEJFKBEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private JDGCMEDKNHD GCALAGNGEDP;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x2375730", Offset = "0x2374330", VA = "0x182375730", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x23756C0", Offset = "0x23742C0", VA = "0x1823756C0", Slot = "6")]
	public bool AGAAPJDGKGH(LOGKGBLPOOD DJHPMDEHJMK, out int OEBMILJLIAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x23759F0", Offset = "0x23745F0", VA = "0x1823759F0", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x23759E0", Offset = "0x23745E0", VA = "0x1823759E0", Slot = "5")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2375790", Offset = "0x2374390", VA = "0x182375790")]
	private void JFCMEBPDKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2375A50", Offset = "0x2374650", VA = "0x182375A50")]
	public LMIIDDAGOIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[MHBJLGEIMOG(typeof(JDGCMEDKNHD), new string[] { })]
[DefaultMember("Item")]
[IBGAMCLMLFP(typeof(DMOLBBGANCB))]
public class EMDBCHFBFOD : JDGCMEDKNHD, IEnumerable<BIIMOMDCJGN>, IEnumerable, POIJNBNBJIE, CCILBHCKADC, HKFIKAGKAAK, GEPKKGPMACB, POEIGJOFIAI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private PNPPGDJCNCL LCAGHKIOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private DMOLBBGANCB PGFLDGHMNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private BIIMOMDCJGN[] PDFPJHAFBNG;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2638930", Offset = "0x2637530", VA = "0x182638930", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public BIIMOMDCJGN GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2638840", Offset = "0x2637440", VA = "0x182638840", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public BIIMOMDCJGN GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2638840", Offset = "0x2637440", VA = "0x182638840", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "10")]
	public void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2638940", Offset = "0x2637540", VA = "0x182638940", Slot = "11")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "12")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2638710", Offset = "0x2637310", VA = "0x182638710", Slot = "6")]
	public BIIMOMDCJGN EIPNDAPIEGF(BDHIOHAFMEG OHDKCBCOIKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2638500", Offset = "0x2637100", VA = "0x182638500", Slot = "7")]
	public LOGKGBLPOOD DDLLOIBHPCA(BDHIOHAFMEG OHDKCBCOIKL)
	{
		return default(LOGKGBLPOOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2638880", Offset = "0x2637480", VA = "0x182638880", Slot = "8")]
	public IEnumerator<BIIMOMDCJGN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2638BD0", Offset = "0x26377D0", VA = "0x182638BD0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x2337070", Offset = "0x2335C70", VA = "0x182337070", Slot = "13")]
	public void FOFDHHCJLDL<TKey, T>(global::GJOMGFAOOGO<TKey, T> MDENPOJAPFE, [Optional] object NAEOEJMOBMH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x26385D0", Offset = "0x26371D0", VA = "0x1826385D0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public EMDBCHFBFOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2638840", Offset = "0x2637440", VA = "0x182638840")]
	[CompilerGenerated]
	private BIIMOMDCJGN FDGDFFMDEHO(int JNJLPHNJHIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[DefaultMember("Item")]
[IBGAMCLMLFP(typeof(DMOLBBGANCB))]
[MHBJLGEIMOG(typeof(ODHGFDMHCDN), new string[] { })]
public class ABLNLOPKOFG : ODHGFDMHCDN, IEnumerable<CNAIOOCFPBI>, IEnumerable, POIJNBNBJIE, CCILBHCKADC, HKFIKAGKAAK, GEPKKGPMACB, POEIGJOFIAI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private PNPPGDJCNCL LCAGHKIOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private DMOLBBGANCB PGFLDGHMNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private CNAIOOCFPBI[] PDFPJHAFBNG;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x262BB20", Offset = "0x262A720", VA = "0x18262BB20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public CNAIOOCFPBI GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x262B700", Offset = "0x262A300", VA = "0x18262B700", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public CNAIOOCFPBI GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x262B700", Offset = "0x262A300", VA = "0x18262B700", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "9")]
	public void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x262BB70", Offset = "0x262A770", VA = "0x18262BB70", Slot = "10")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x262B8D0", Offset = "0x262A4D0", VA = "0x18262B8D0", Slot = "11")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x262B710", Offset = "0x262A310", VA = "0x18262B710")]
	private CNAIOOCFPBI GNPOKIPMBCJ(int HIANDEDCLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x262B5E0", Offset = "0x262A1E0", VA = "0x18262B5E0", Slot = "6")]
	public CNAIOOCFPBI EIPNDAPIEGF(BDHIOHAFMEG OHDKCBCOIKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x262B470", Offset = "0x262A070", VA = "0x18262B470", Slot = "15")]
	public LOGKGBLPOOD DDLLOIBHPCA(BDHIOHAFMEG OHDKCBCOIKL)
	{
		return default(LOGKGBLPOOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x262B7F0", Offset = "0x262A3F0", VA = "0x18262B7F0", Slot = "7")]
	public IEnumerator<CNAIOOCFPBI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x262B7F0", Offset = "0x262A3F0", VA = "0x18262B7F0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F830", Offset = "0x1F9E430", VA = "0x181F9F830", Slot = "12")]
	public void FOFDHHCJLDL<TKey, T>(global::GJOMGFAOOGO<TKey, T> MDENPOJAPFE, [Optional] object NAEOEJMOBMH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x262B540", Offset = "0x262A140", VA = "0x18262B540", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public ABLNLOPKOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x262B700", Offset = "0x262A300", VA = "0x18262B700")]
	[CompilerGenerated]
	private CNAIOOCFPBI FHGJJKKFFAB(int JNJLPHNJHIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[MHBJLGEIMOG(typeof(HICHFOGIHHE), new string[] { })]
[IBGAMCLMLFP(typeof(BHBECLCNBCK))]
internal class HICHFOGIHHE : HKFIKAGKAAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private BHBECLCNBCK JFAHNIMFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private DMOLBBGANCB PGFLDGHMNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private ODHGFDMHCDN OMCAACIFPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private JDGCMEDKNHD IKAINHPGHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private global::MGMBGHBGHPD<BMGOEDLPBCC> FCDBFCFIAKD;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public HFMKNHEBJPF MKPKFGFMNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x5ED010", Offset = "0x5EBC10", VA = "0x1805ED010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x5ED020", Offset = "0x5EBC20", VA = "0x1805ED020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x236A950", Offset = "0x2369550", VA = "0x18236A950", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x236A790", Offset = "0x2369390", VA = "0x18236A790")]
	private void FCBECJEDPJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1E3F130", Offset = "0x1E3DD30", VA = "0x181E3F130")]
	public T JMGECLNPDNP<T>() where T : BMGOEDLPBCC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x236A880", Offset = "0x2369480", VA = "0x18236A880")]
	public FCAJCLOJKEA GIBBILHHCOI(BDHIOHAFMEG FHNLBBBEDLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	public global::OPNPNKDOEBI<T> GIBBILHHCOI<T>(BDHIOHAFMEG FHNLBBBEDLN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x236A6C0", Offset = "0x23692C0", VA = "0x18236A6C0")]
	public CNAIOOCFPBI BEMEOHKFNFP(BDHIOHAFMEG FHNLBBBEDLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3132EA0", Offset = "0x3131AA0", VA = "0x183132EA0")]
	public global::PCAMDBAEOGP<T> BEMEOHKFNFP<T>(BDHIOHAFMEG FHNLBBBEDLN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x236A5F0", Offset = "0x23691F0", VA = "0x18236A5F0")]
	public BIIMOMDCJGN ACMLDGEIMLF(BDHIOHAFMEG FHNLBBBEDLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	public global::LFDLMLAPGKM<T> ACMLDGEIMLF<T>(BDHIOHAFMEG FHNLBBBEDLN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public HICHFOGIHHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class AIJEGPEBBPH
{
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3121010", Offset = "0x311FC10", VA = "0x183121010")]
	public static global::OPNPNKDOEBI<T> GIBBILHHCOI<T>(this HICHFOGIHHE JANNOOLHKPG, global::AABHEEDMDPC<T> FHNLBBBEDLN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	public static global::PCAMDBAEOGP<T> BEMEOHKFNFP<T>(this HICHFOGIHHE JANNOOLHKPG, global::AABHEEDMDPC<T> FHNLBBBEDLN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	public static global::LFDLMLAPGKM<T> ACMLDGEIMLF<T>(this HICHFOGIHHE JANNOOLHKPG, global::AABHEEDMDPC<T> FHNLBBBEDLN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[MHBJLGEIMOG(typeof(AHFEIIGKGAM), new string[] { })]
public sealed class AHFEIIGKGAM : HKFIKAGKAAK, GEPKKGPMACB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class EFKHBPMPDPF : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x6FD3E0", Offset = "0x6FBFE0", VA = "0x1806FD3E0")]
		[DebuggerHidden]
		public EFKHBPMPDPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x26368E0", Offset = "0x26354E0", VA = "0x1826368E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2636560", Offset = "0x2635160", VA = "0x182636560", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x2636980", Offset = "0x2635580", VA = "0x182636980")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2636890", Offset = "0x2635490", VA = "0x182636890", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2636800", Offset = "0x2635400", VA = "0x182636800", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2636800", Offset = "0x2635400", VA = "0x182636800", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const string JJEKLJEPMGD = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Dictionary<SerializableGuid, GPILGPICAJM> JBEKBDCJJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly List<SerializableGuid> GLLDMAEFECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly Dictionary<SerializableGuid, GameObject> PNALABGJPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private PNPPGDJCNCL LCAGHKIOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private ODHGFDMHCDN GCALAGNGEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private JDDPPIAFHCO NOMIILNDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private LBMBOABFHDF KEEOMJACPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private BHBECLCNBCK JFAHNIMFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private BOCEAGHBLMC LPFHOFODDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private global::MGBAHOPOBPI<GPILGPICAJM> HCFNJMMIINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GameObject BMCIFHHMOLC;

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x262E2E0", Offset = "0x262CEE0", VA = "0x18262E2E0", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x262DB20", Offset = "0x262C720", VA = "0x18262DB20", Slot = "5")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x262CEB0", Offset = "0x262BAB0", VA = "0x18262CEB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x262D340", Offset = "0x262BF40", VA = "0x18262D340")]
	private void FIJHBHJJCHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x262D610", Offset = "0x262C210", VA = "0x18262D610")]
	internal void LIONPMOPHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x262DCE0", Offset = "0x262C8E0", VA = "0x18262DCE0")]
	private void MJIGLPLPNEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x262DA40", Offset = "0x262C640", VA = "0x18262DA40")]
	private void LPFPJBOKIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x262E3B0", Offset = "0x262CFB0", VA = "0x18262E3B0")]
	[IteratorStateMachine(typeof(EFKHBPMPDPF))]
	private IEnumerable<RRCustomPropTag> OPBOGKIHDGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x262DEB0", Offset = "0x262CAB0", VA = "0x18262DEB0")]
	private void OIMCCOPDAPN(OLACMNNNFCK AIJKIAIKFDH, in CJHLIFJIIDK NBOLFCPAICP, in CJHLIFJIIDK FMKHLEANADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x262D500", Offset = "0x262C100", VA = "0x18262D500")]
	private void KIEPKILKNCN(SerializableGuid JLMDLFJCONJ, GameObject MHECAANKLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x262D000", Offset = "0x262BC00", VA = "0x18262D000")]
	private void EAABOHLOMIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x262D350", Offset = "0x262BF50", VA = "0x18262D350")]
	private bool JALNHPCMBNG(GPILGPICAJM GKCALOIKJEC, Transform MKOLBPGKLJP, out GameObject EJKNEJBEEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x262D9F0", Offset = "0x262C5F0", VA = "0x18262D9F0")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x262E410", Offset = "0x262D010", VA = "0x18262E410")]
	public AHFEIIGKGAM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public SerializableGuid CJFDNBHHLLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x5ED000", Offset = "0x5EBC00", VA = "0x1805ED000")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x26BCB30", Offset = "0x26BB730", VA = "0x1826BCB30")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[MHBJLGEIMOG(typeof(JFDNCMBCKCA), new string[] { })]
public class MBOEHMHONOM : HKFIKAGKAAK, JFDNCMBCKCA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private const string HMNHMICBKEH = "ScopeService";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private NIJAIOMNHOO LOPBOOCOLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private PNPPGDJCNCL LCAGHKIOCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private FDNCDAIFHHA MJBPHLMDKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private BINMKOFKKMO AMAFNBACLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private ObjectEmbodimentService MPHBIKLMOEK;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public OLACMNNNFCK LGPNCHLNMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x5ED000", Offset = "0x5EBC00", VA = "0x1805ED000", Slot = "7")]
		get
		{
			return default(OLACMNNNFCK);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2376E60", Offset = "0x2375A60", VA = "0x182376E60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public NIJAIOMNHOO BHDOEEJPAGH
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED000", Offset = "0x5EBC00", VA = "0x1805ED000", Slot = "9")]
		get
		{
			return default(NIJAIOMNHOO);
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x2376E60", Offset = "0x2375A60", VA = "0x182376E60", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event CNOEFOMINIM AGCPOOKOOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x23770B0", Offset = "0x2375CB0", VA = "0x1823770B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2376A20", Offset = "0x2375620", VA = "0x182376A20", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2377320", Offset = "0x2375F20", VA = "0x182377320", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2376AC0", Offset = "0x23756C0", VA = "0x182376AC0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2376E80", Offset = "0x2375A80", VA = "0x182376E80", Slot = "11")]
	public OLACMNNNFCK HPFCHDMGGGI(OLACMNNNFCK JEGDMKPCECO, OLACMNNNFCK CNDMHGAOPGD)
	{
		return default(OLACMNNNFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2376B90", Offset = "0x2375790", VA = "0x182376B90", Slot = "12")]
	public bool EKBLKLILKFF(OLACMNNNFCK JEGDMKPCECO, OLACMNNNFCK CNDMHGAOPGD, out OLACMNNNFCK JPILMHHADCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2376F90", Offset = "0x2375B90", VA = "0x182376F90", Slot = "13")]
	public void LGEBCIHGBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x23769F0", Offset = "0x23755F0", VA = "0x1823769F0", Slot = "14")]
	public void CEAHIJKMAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x23773F0", Offset = "0x2375FF0", VA = "0x1823773F0", Slot = "15")]
	public bool ONFGCPOGHOJ(OLACMNNNFCK FNPGAOOPMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2377150", Offset = "0x2375D50", VA = "0x182377150")]
	private bool MGJBEFHIAFI(OLACMNNNFCK JBFLKBAHIPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2376C90", Offset = "0x2375890", VA = "0x182376C90")]
	private void FJAEAJFDIHJ(NIJAIOMNHOO EBMPLNBFAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public MBOEHMHONOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[MHBJLGEIMOG(typeof(BINMKOFKKMO), new string[] { })]
public class OJLGCKPEHHA : HKFIKAGKAAK, BINMKOFKKMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private EntityManager EJMLDDGCGJO;

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x26B5A00", Offset = "0x26B4600", VA = "0x1826B5A00", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x26B5990", Offset = "0x26B4590", VA = "0x1826B5990", Slot = "5")]
	public void HNHMPOMKLDK(OLACMNNNFCK DJJOBHOILOH, bool KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x22FA950", Offset = "0x22F9550", VA = "0x1822FA950")]
	private void GELHLBKPBFF<T>(OLACMNNNFCK DJJOBHOILOH, bool KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public OJLGCKPEHHA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[MHBJLGEIMOG(typeof(ENJBBMGPMHG), new string[] { })]
	[GOMFNBMFGBH(ELBDNIJMKBJ.RenderEffects)]
	public class SelectionService : HKFIKAGKAAK, ENJBBMGPMHG
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private EntityManager EJMLDDGCGJO;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x26BCC90", Offset = "0x26BB890", VA = "0x1826BCC90", Slot = "4")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x26BCBB0", Offset = "0x26BB7B0", VA = "0x1826BCBB0", Slot = "5")]
		public void JNAPFEBNPGA(OLACMNNNFCK DJJOBHOILOH, bool KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x26BCC20", Offset = "0x26BB820", VA = "0x1826BCC20", Slot = "6")]
		public void MHHCKCBOHOJ(OLACMNNNFCK DJJOBHOILOH, bool KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x22FA950", Offset = "0x22F9550", VA = "0x1822FA950")]
		private void GELHLBKPBFF<T>(OLACMNNNFCK DJJOBHOILOH, bool KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[MHBJLGEIMOG(typeof(MDONMFNCNJF), new string[] { })]
public class JJEHFKELJOL : MDONMFNCNJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool OIMMLAJMHDI;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool IKIEIANKFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6177B0", Offset = "0x6163B0", VA = "0x1806177B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x23731A0", Offset = "0x2371DA0", VA = "0x1823731A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<bool> MDIJCNPOIIF
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x2373100", Offset = "0x2371D00", VA = "0x182373100", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x2373060", Offset = "0x2371C60", VA = "0x182373060", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public JJEHFKELJOL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Serialization, new string[] { "Timing" })]
	[MHBJLGEIMOG(typeof(LBMBOABFHDF), new string[] { })]
	public class SerializationService : HKFIKAGKAAK, LBMBOABFHDF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct NAGPEJHFCFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public FMLAJBDHIOA EGPGIMGGIGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public FMLAJBDHIOA HPCMMMKJFKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public FMLAJBDHIOA DGFBOFNGJKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public FMLAJBDHIOA AKGKEFENOOJ;

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x26B38B0", Offset = "0x26B24B0", VA = "0x1826B38B0")]
			public static NAGPEJHFCFD HILHGJFFAMN()
			{
				return default(NAGPEJHFCFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
			[Conditional("DEBUG_WORLDS")]
			public void BMILBDCJANP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct FMLAJBDHIOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
			public FMLAJBDHIOA(string ELDEGBGONOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
			public void LCAMBDBAHHD(EntityManager ELDEGBGONOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
			public void BMILBDCJANP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private const string BLPFPGMJPBM = "Timing";

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static readonly LJFAOMOPGNF DEBMIKHJFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private DEGAMIMEMLN CMPGNIIOOGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private BHBECLCNBCK JFAHNIMFMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private MDONMFNCNJF IELCLDABHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private PNPPGDJCNCL LCAGHKIOCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private SerializationRemapScope GMDDEAIKHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private PHPABLLJDIC IAMBEOMBAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private PPAAHGLEEIB AMFHDICBIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private bool? GBCLHNHJPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private NAGPEJHFCFD EGFMLMFPEDI;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool NLFGOEMGEDB
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x26BFB10", Offset = "0x26BE710", VA = "0x1826BFB10", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x26BEC50", Offset = "0x26BD850", VA = "0x1826BEC50", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action JCNDCNBGKIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x26BF7C0", Offset = "0x26BE3C0", VA = "0x1826BF7C0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x26BE230", Offset = "0x26BCE30", VA = "0x1826BE230", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<HOJCIPGJMNP> DONBNCEKGOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x26BF510", Offset = "0x26BE110", VA = "0x1826BF510", Slot = "21")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x26BF720", Offset = "0x26BE320", VA = "0x1826BF720", Slot = "22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action IKBBCBPEHLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x26BF680", Offset = "0x26BE280", VA = "0x1826BF680", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x26BE4B0", Offset = "0x26BD0B0", VA = "0x1826BE4B0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action LOJEELHIPMK
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x26BE850", Offset = "0x26BD450", VA = "0x1826BE850", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x26BEBB0", Offset = "0x26BD7B0", VA = "0x1826BEBB0", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<HOJCIPGJMNP> KLFFIIHHNFB
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x26BFF00", Offset = "0x26BEB00", VA = "0x1826BFF00", Slot = "23")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x26BDE20", Offset = "0x26BCA20", VA = "0x1826BDE20", Slot = "24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x26BFC50", Offset = "0x26BE850", VA = "0x1826BFC50", Slot = "4")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x26BF0F0", Offset = "0x26BDCF0", VA = "0x1826BF0F0", Slot = "11")]
		public void KEHAMHELBOC(bool BGCPHEKMBDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x26BDBC0", Offset = "0x26BC7C0", VA = "0x1826BDBC0", Slot = "13")]
		public ByteString CGMPPIJDMHM(out IDisposable GMDDEAIKHMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x26BDA10", Offset = "0x26BC610", VA = "0x1826BDA10", Slot = "12")]
		public ByteString CGMPPIJDMHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x26BE2D0", Offset = "0x26BCED0", VA = "0x1826BE2D0", Slot = "16")]
		public bool EFBLDOLKNNC(ByteString BBHKBAHFEIG, MGJJCLGNAJN AJKANCOMGHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x26BF280", Offset = "0x26BDE80", VA = "0x1826BF280", Slot = "17")]
		public bool LJHKKFBAEIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x26BE8F0", Offset = "0x26BD4F0", VA = "0x1826BE8F0", Slot = "14")]
		public void HFGBGLEFMAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x26BEF50", Offset = "0x26BDB50", VA = "0x1826BEF50", Slot = "27")]
		public void KCKJOPMILFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x26BE310", Offset = "0x26BCF10", VA = "0x1826BE310", Slot = "15")]
		public void EOJDKEMAKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x26BEC60", Offset = "0x26BD860", VA = "0x1826BEC60", Slot = "18")]
		public bool JPIJHPOKJLL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x26BF8C0", Offset = "0x26BE4C0", VA = "0x1826BF8C0", Slot = "19")]
		public bool NNAJJKACHNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x26BFD50", Offset = "0x26BE950", VA = "0x1826BFD50")]
		private void ONLKOIHHKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x10176E0", Offset = "0x10162E0", VA = "0x1810176E0")]
		private void KBAGPMACEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x26BD8F0", Offset = "0x26BC4F0", VA = "0x1826BD8F0")]
		private void BHOGMILGHAA(EEGMEMCJJHG GNCHJNIKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x26BF860", Offset = "0x26BE460", VA = "0x1826BF860")]
		private ByteString NGHEBIADLJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x26BFE00", Offset = "0x26BEA00", VA = "0x1826BFE00")]
		private ByteString OPCGOIGMADN(ByteString HJKNKKDBKMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x26BF5B0", Offset = "0x26BE1B0", VA = "0x1826BF5B0")]
		private bool NBNNLDBFLGM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x26BDEC0", Offset = "0x26BCAC0", VA = "0x1826BDEC0")]
		private void EABPGCDPJIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x26BD5A0", Offset = "0x26BC1A0", VA = "0x1826BD5A0")]
		private void BHEHMICBHAA(out ByteString HJKNKKDBKMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x26BE550", Offset = "0x26BD150", VA = "0x1826BE550")]
		private bool FJMAEGAJFLK(ByteString BBHKBAHFEIG, MGJJCLGNAJN AJKANCOMGHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x26C0160", Offset = "0x26BED60", VA = "0x1826C0160")]
		private bool PKAKNNFBCMB(ByteString BBHKBAHFEIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x26BD3D0", Offset = "0x26BBFD0", VA = "0x1826BD3D0")]
		private bool BDIPENLFKFE(PPAAHGLEEIB.HNMDCCKDKAD.JFLKKPFAENP ELFLHAPPPBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x26BE900", Offset = "0x26BD500", VA = "0x1826BE900")]
		private void JDCNLJOBOFP(HOJCIPGJMNP GNCHJNIKDOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x26BFBB0", Offset = "0x26BE7B0", VA = "0x1826BFBB0")]
		private EEGMEMCJJHG OBILIFOAJIH(EntityManager DHINOEGHFBO, EntityManager IMGEIANHDLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x26BFFA0", Offset = "0x26BEBA0", VA = "0x1826BFFA0")]
		private void PDEOOGPNGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x26BF350", Offset = "0x26BDF50", VA = "0x1826BF350")]
		private void LONCNHKPMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x26BF240", Offset = "0x26BDE40", VA = "0x1826BF240")]
		private void LCPIJFGDHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x26BFB20", Offset = "0x26BE720", VA = "0x1826BFB20")]
		private PPAAHGLEEIB.HNMDCCKDKAD.JFLKKPFAENP NPCKMHNGCFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[MHBJLGEIMOG(typeof(OLIKBBLBADA), new string[] { })]
public class OLIKBBLBADA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly Dictionary<HNGFAHNAKGA, string> OACBGOOFHNG;

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x26B7130", Offset = "0x26B5D30", VA = "0x1826B7130")]
	public GameObject LJCPGCHGDCL(HNGFAHNAKGA HHBPCJGFJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x26B71E0", Offset = "0x26B5DE0", VA = "0x1826B71E0")]
	public OLIKBBLBADA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[MHBJLGEIMOG(typeof(IFOJNFCCBDG), new string[] { })]
public class IFAIGOIGPBN : IFOJNFCCBDG
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x236E0E0", Offset = "0x236CCE0", VA = "0x18236E0E0", Slot = "5")]
	public void LPGOBCDBFJJ(object CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x236E1A0", Offset = "0x236CDA0", VA = "0x18236E1A0", Slot = "6")]
	public void OAIIGIHILLI(object CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x236E020", Offset = "0x236CC20", VA = "0x18236E020", Slot = "7")]
	public void IBLLINDIJBM(object CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x236DF30", Offset = "0x236CB30", VA = "0x18236DF30", Slot = "4")]
	public IDisposable HKONILLIMPH(object CIJKLAFFGJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public IFAIGOIGPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[MHBJLGEIMOG(typeof(FJKDEOKBEGE), new string[] { })]
public class PLOHMJNMHHE : HKFIKAGKAAK, FJKDEOKBEGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private BHBECLCNBCK JFAHNIMFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private FOJAKKAEGJD FOGOLJODMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private MDONMFNCNJF NICJBMKKLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private TransformOwnershipPhase JLCDBIKPJNF;

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x26BB4B0", Offset = "0x26BA0B0", VA = "0x1826BB4B0", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x26BB560", Offset = "0x26BA160", VA = "0x1826BB560", Slot = "6")]
	public void PEFAELNIEBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x26BB2A0", Offset = "0x26B9EA0", VA = "0x1826BB2A0", Slot = "5")]
	public void KLDFELOJGNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x26BB080", Offset = "0x26B9C80", VA = "0x1826BB080", Slot = "7")]
	public void HAMMAJILEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x26BB1A0", Offset = "0x26B9DA0", VA = "0x1826BB1A0", Slot = "8")]
	public void HHLNDLBCPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x26BAEC0", Offset = "0x26B9AC0", VA = "0x1826BAEC0", Slot = "9")]
	public void DIFIHABAJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x26BB440", Offset = "0x26BA040", VA = "0x1826BB440", Slot = "10")]
	public void NDMNBIEPINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x26BB3A0", Offset = "0x26B9FA0", VA = "0x1826BB3A0", Slot = "11")]
	public void LIJCOMBIAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public PLOHMJNMHHE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[MHBJLGEIMOG(typeof(DLIOKHGJHNN), new string[] { })]
	[GOMFNBMFGBH(ELBDNIJMKBJ.TransformSyncing)]
	public class TransformService : DLIOKHGJHNN, HKFIKAGKAAK, GEPKKGPMACB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private BHBECLCNBCK JFAHNIMFMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private PNPPGDJCNCL LCAGHKIOCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private FDNCDAIFHHA MJBPHLMDKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TransformOwnershipPhase JLBCBKJPJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private global::OPNPNKDOEBI<Entity> MKOLBPGKLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private ObjectEmbodimentService EDAMELHACNP;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private EntityManager JGHLJDFOODE
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x58557F0", Offset = "0x58543F0", VA = "0x1858557F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		private BOCEAGHBLMC CCJAAPJEOKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x5851510", Offset = "0x5850110", VA = "0x185851510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x5855160", Offset = "0x5853D60", VA = "0x185855160", Slot = "33")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x5854340", Offset = "0x5852F40", VA = "0x185854340", Slot = "34")]
		public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x5851490", Offset = "0x5850090", VA = "0x185851490", Slot = "35")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x5850D70", Offset = "0x584F970", VA = "0x185850D70", Slot = "36")]
		public bool BEEJCJLNDIA(Transform BHPNFBEEMHL, out OLACMNNNFCK AIJKIAIKFDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x5852300", Offset = "0x5850F00", VA = "0x185852300", Slot = "37")]
		public Transform IBILDJBADNC(Entity OCMABEPCGDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5852210", Offset = "0x5850E10", VA = "0x185852210", Slot = "31")]
		public bool HLICONCCCHB(Entity OCMABEPCGDM, out Transform BHPNFBEEMHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x58523C0", Offset = "0x5850FC0", VA = "0x1858523C0")]
		private void ICDMIMCNKKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5852040", Offset = "0x5850C40", VA = "0x185852040", Slot = "30")]
		public void HGEMLEJPCMD(Entity OCMABEPCGDM, out Matrix4x4 FHNJKEKHMCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5853A10", Offset = "0x5852610", VA = "0x185853A10", Slot = "4")]
		public void KDINJPLNBON(Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5851700", Offset = "0x5850300", VA = "0x185851700")]
		private void EHLJIEEHNMM(Entity OCMABEPCGDM, Vector3 BDAEFIHNJEN, Quaternion IBJBIKHAMJF, Vector3 AOEHEOLLFGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5851AE0", Offset = "0x58506E0", VA = "0x185851AE0")]
		private void FOLEKONNDKO(Entity OCMABEPCGDM, Vector3 BDAEFIHNJEN, Quaternion IBJBIKHAMJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5852D90", Offset = "0x5851990", VA = "0x185852D90", Slot = "28")]
		public void IPJHDGNOFIL(Entity OCMABEPCGDM, out Matrix4x4 DKADKIELFLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5853EE0", Offset = "0x5852AE0", VA = "0x185853EE0")]
		public void LLAHIPLMCJH(Entity OCMABEPCGDM, in Matrix4x4 FHNJKEKHMCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5853CD0", Offset = "0x58528D0", VA = "0x185853CD0")]
		private void LEKPCKGIFLO(Entity OCMABEPCGDM, in Matrix4x4 FOIHFHILNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x58515D0", Offset = "0x58501D0", VA = "0x1858515D0", Slot = "5")]
		public void EBKHBHECNEG(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x58519D0", Offset = "0x58505D0", VA = "0x1858519D0", Slot = "6")]
		public Vector3 FOHKPGILPBN(Entity OCMABEPCGDM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5851240", Offset = "0x584FE40", VA = "0x185851240", Slot = "7")]
		public void DFCLFDLGLEE(Entity OCMABEPCGDM, Quaternion KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5854440", Offset = "0x5853040", VA = "0x185854440", Slot = "8")]
		public Quaternion MCMKHAJPEGE(Entity OCMABEPCGDM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5851F40", Offset = "0x5850B40", VA = "0x185851F40", Slot = "13")]
		public void GNOEIMLDADP(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5852F00", Offset = "0x5851B00", VA = "0x185852F00", Slot = "12")]
		public Vector3 JHCGCIKLPLM(Entity OCMABEPCGDM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x5853040", Offset = "0x5851C40", VA = "0x185853040")]
		private void JHMBOAMBBME(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5853560", Offset = "0x5852160", VA = "0x185853560")]
		private Vector3 KAONJGOKABM(Entity OCMABEPCGDM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5854680", Offset = "0x5853280", VA = "0x185854680", Slot = "15")]
		public float NFHPLAECMJG(Entity OCMABEPCGDM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x5852880", Offset = "0x5851480", VA = "0x185852880", Slot = "14")]
		public void IKDOMCGDEII(Entity OCMABEPCGDM, float KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x5851E60", Offset = "0x5850A60", VA = "0x185851E60")]
		private float GLDEHCDKFGB(Entity OCMABEPCGDM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x5855760", Offset = "0x5854360", VA = "0x185855760")]
		private void PDMKPOMBJIM(Entity OCMABEPCGDM, float CKELBMJKLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x58545A0", Offset = "0x58531A0", VA = "0x1858545A0", Slot = "17")]
		public Vector3 MNIAODDEKBE(Entity OCMABEPCGDM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x5852710", Offset = "0x5851310", VA = "0x185852710", Slot = "16")]
		public void IJFIPOEPFDF(Entity OCMABEPCGDM, Vector3 LIMILLILMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x58518B0", Offset = "0x58504B0", VA = "0x1858518B0")]
		private Vector3 EOPODPEMHNE(Entity OCMABEPCGDM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x58523E0", Offset = "0x5850FE0", VA = "0x1858523E0")]
		private void IFBNACEKFDG(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5852BD0", Offset = "0x58517D0", VA = "0x185852BD0")]
		[Conditional("DEBUG_BUILD")]
		private void IOAECGALMOH(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x58529F0", Offset = "0x58515F0", VA = "0x1858529F0", Slot = "9")]
		public void IMDHPODFHEG(Entity OCMABEPCGDM, Vector3 JACLPJHPOFC, Quaternion AHDCMPCBKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x58555B0", Offset = "0x58541B0", VA = "0x1858555B0", Slot = "10")]
		public void PBOKMGLMJHA(Entity OCMABEPCGDM, out Vector3 JACLPJHPOFC, out Quaternion AHDCMPCBKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x58533C0", Offset = "0x5851FC0", VA = "0x1858533C0", Slot = "11")]
		public void JKBHFCBPJEJ(Entity OCMABEPCGDM, out Vector3 JACLPJHPOFC, out Quaternion AHDCMPCBKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x58524B0", Offset = "0x58510B0", VA = "0x1858524B0", Slot = "18")]
		public void IFFONKIKELC(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x5852DA0", Offset = "0x58519A0", VA = "0x185852DA0", Slot = "19")]
		public Vector3 JFHLDABLNCH(Entity OCMABEPCGDM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x58530E0", Offset = "0x5851CE0", VA = "0x1858530E0", Slot = "20")]
		public void JHMECBBMFPD(Entity OCMABEPCGDM, Quaternion KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x5850F00", Offset = "0x584FB00", VA = "0x185850F00", Slot = "21")]
		public Quaternion BHOEHHALFHP(Entity OCMABEPCGDM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x5853630", Offset = "0x5852230", VA = "0x185853630", Slot = "23")]
		public void KAPPMFCFPLF(Entity OCMABEPCGDM, Vector3 KGJOJGIPNPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5851390", Offset = "0x584FF90", VA = "0x185851390", Slot = "22")]
		public Vector3 DGNPNDHINKL(Entity OCMABEPCGDM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5855230", Offset = "0x5853E30", VA = "0x185855230", Slot = "24")]
		public void OPACKLALHKD(Entity OCMABEPCGDM, float KDCKJAONIPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x58508D0", Offset = "0x584F4D0", VA = "0x1858508D0", Slot = "25")]
		public float AEBEINLINHE(Entity OCMABEPCGDM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5854720", Offset = "0x5853320", VA = "0x185854720", Slot = "26")]
		public void NJPKAAFHIAP(Entity OCMABEPCGDM, Vector3 MJHLACKLGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x58510E0", Offset = "0x584FCE0", VA = "0x1858510E0", Slot = "27")]
		public Vector3 CBEKIGIHCBF(Entity OCMABEPCGDM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5854D60", Offset = "0x5853960", VA = "0x185854D60", Slot = "32")]
		public void OGJICNIOAJI(Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5854B70", Offset = "0x5853770", VA = "0x185854B70")]
		private void OBPGODMAEJA(Entity OCMABEPCGDM, in CJHLIFJIIDK NBOLFCPAICP, in CJHLIFJIIDK FMKHLEANADK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5854C30", Offset = "0x5853830", VA = "0x185854C30")]
		private void OBPGODMAEJA(Entity OCMABEPCGDM, in Entity CPGJLPOPHBK, in Entity BIMAKIIINII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5855530", Offset = "0x5854130", VA = "0x185855530")]
		private HOBBEDGNOKF PBOKMGLMJHA(Entity OCMABEPCGDM)
		{
			return default(HOBBEDGNOKF);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5851000", Offset = "0x584FC00", VA = "0x185851000")]
		private bool BJEAMEAHFFO(Entity OCMABEPCGDM, out Entity MKOLBPGKLJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5851C30", Offset = "0x5850830", VA = "0x185851C30")]
		private void GDJHLPBGDJN(Entity OCMABEPCGDM, out Matrix4x4 FHNJKEKHMCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x58509F0", Offset = "0x584F5F0", VA = "0x1858509F0")]
		public void AKCOAHEEHHB(Entity OCMABEPCGDM, out Matrix4x4 FOIHFHILNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5851230", Offset = "0x584FE30", VA = "0x185851230", Slot = "29")]
		private void CFJJKNJHJNK(Entity OCMABEPCGDM, in Matrix4x4 DKADKIELFLM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[MHBJLGEIMOG(typeof(JJKLIPHNGMC), new string[] { })]
public class JJKLIPHNGMC
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct KPHPOCOHLBH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly JJKLIPHNGMC MKOLBPGKLJP;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2374C50", Offset = "0x2373850", VA = "0x182374C50")]
		public KPHPOCOHLBH(JJKLIPHNGMC MKOLBPGKLJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x2374C10", Offset = "0x2373810", VA = "0x182374C10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int CPDLFLJGDEK;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool ANPDKAMJHDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x1262560", Offset = "0x1261160", VA = "0x181262560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action JDMELAHCGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2373300", Offset = "0x2371F00", VA = "0x182373300")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2373260", Offset = "0x2371E60", VA = "0x182373260")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2373200", Offset = "0x2371E00", VA = "0x182373200")]
	public KPHPOCOHLBH EGLPICINJKG()
	{
		return default(KPHPOCOHLBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0xFE1AD0", Offset = "0xFE06D0", VA = "0x180FE1AD0")]
	public void GMLOPMBELMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2373240", Offset = "0x2371E40", VA = "0x182373240")]
	public void INJMALCLDFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public JJKLIPHNGMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[MHBJLGEIMOG(typeof(BHBECLCNBCK), new string[] { })]
[IBGAMCLMLFP(typeof(EGCFDCFHPMF))]
public class FFFMCMKKFGI : BHBECLCNBCK, IDisposable, POIJNBNBJIE, CCILBHCKADC, HKFIKAGKAAK, GEPKKGPMACB
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class PNJIIAKKBJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public DEGAMIMEMLN services;

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public PNJIIAKKBJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x23793A0", Offset = "0x2377FA0", VA = "0x1823793A0")]
		internal void <InitReferences>b__0(HKFIKAGKAAK svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class DHDMHJAFOJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public DEGAMIMEMLN services;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public DHDMHJAFOJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x23657B0", Offset = "0x23643B0", VA = "0x1823657B0")]
		internal void <InitExternal>b__0(GEPKKGPMACB svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker GENFGNEJCPD;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker PLEEJMOEIDP;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker PPCFOHLDHHL;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly ProfilerMarker LHAOAPDEFKF;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly ProfilerMarker CNGFIMNMBBN;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly ProfilerMarker OKNKOOIHOCL;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly ProfilerMarker IFBDENLHDHB;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly ProfilerMarker KAEJOPECJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private IEEMDNAPKGD JFAHNIMFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public IEEMDNAPKGD BONNMJFMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public BOCEAGHBLMC CCJAAPJEOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x263B0C0", Offset = "0x2639CC0", VA = "0x18263B0C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EntityManager JGHLJDFOODE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x263BD90", Offset = "0x263A990", VA = "0x18263BD90", Slot = "9")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public BDNIJAOEAEJ FLGGGNNJALI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x710440", Offset = "0x70F040", VA = "0x180710440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action JMOCFLKFDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x263ACD0", Offset = "0x26398D0", VA = "0x18263ACD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x263B450", Offset = "0x263A050", VA = "0x18263B450", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x263B870", Offset = "0x263A470", VA = "0x18263B870", Slot = "21")]
	public void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x263BBA0", Offset = "0x263A7A0", VA = "0x18263BBA0", Slot = "22")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x263B7C0", Offset = "0x263A3C0", VA = "0x18263B7C0", Slot = "23")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x263BC80", Offset = "0x263A880", VA = "0x18263BC80", Slot = "11")]
	public void PDFHIIDCDPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x263B5E0", Offset = "0x263A1E0", VA = "0x18263B5E0", Slot = "12")]
	public void ILKEDGCDBCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x263B200", Offset = "0x2639E00", VA = "0x18263B200", Slot = "14")]
	public void FGAJFFMKEGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x263B6D0", Offset = "0x263A2D0", VA = "0x18263B6D0", Slot = "15")]
	public void KCKMCNLOINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x263B320", Offset = "0x2639F20", VA = "0x18263B320", Slot = "13")]
	public void GLAJABEPNFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x263B0E0", Offset = "0x2639CE0", VA = "0x18263B0E0", Slot = "16")]
	public void EBDPBIBNAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x263B4F0", Offset = "0x263A0F0", VA = "0x18263B4F0", Slot = "17")]
	public void IFPEOLCCOAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x263BAB0", Offset = "0x263A6B0", VA = "0x18263BAB0", Slot = "18")]
	public void OJLJIIHCNNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x263B2F0", Offset = "0x2639EF0", VA = "0x18263B2F0", Slot = "19")]
	public void GJJDAIEKOHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x263B410", Offset = "0x263A010", VA = "0x18263B410", Slot = "24")]
	public void HAFAFDKGJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x263AD70", Offset = "0x2639970", VA = "0x18263AD70")]
	private void DPFIJBHMAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x263AED0", Offset = "0x2639AD0", VA = "0x18263AED0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x263BD70", Offset = "0x263A970", VA = "0x18263BD70", Slot = "10")]
	public ComponentSystemBase PGOKLMDKLEE(Type LIJLAEFJGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x263B1D0", Offset = "0x2639DD0", VA = "0x18263B1D0")]
	public bool EIMAKGFNJGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public FFFMCMKKFGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class AKMKKCEDLHD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly Func<From, To> IGPHAIGDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly Func<To, From> IHHPOLINCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public DynamicBuffer<From> LGIIJIKLGAE;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public To GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool IDIBHBMOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	public AKMKKCEDLHD(Func<From, To> IGPHAIGDIDM, Func<To, From> IHHPOLINCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] LBLDONKHBCF, int BPPENCELOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To IGAPBICELKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int HIANDEDCLIF, To IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[DefaultMember("Item")]
public class LDCFIJMKOII<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly Func<From, To> IGPHAIGDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Func<To, From> IHHPOLINCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public List<From> FPPBJGHNMLI;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public To GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x4540AC0", Offset = "0x453F6C0", VA = "0x184540AC0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x4540B20", Offset = "0x453F720", VA = "0x184540B20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x4540A90", Offset = "0x453F690", VA = "0x184540A90", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool IDIBHBMOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x66D990", Offset = "0x66C590", VA = "0x18066D990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xA3B180", Offset = "0xA39D80", VA = "0x180A3B180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x3667EC0", Offset = "0x3666AC0", VA = "0x183667EC0")]
	public LDCFIJMKOII(Func<From, To> IGPHAIGDIDM, Func<To, From> IHHPOLINCOO, bool CBJFFCIPOCL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x45406E0", Offset = "0x453F2E0", VA = "0x1845406E0", Slot = "11")]
	public void Add(To IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x2194760", Offset = "0x2193360", VA = "0x182194760", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x4540740", Offset = "0x453F340", VA = "0x184540740", Slot = "13")]
	public bool Contains(To IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x45407A0", Offset = "0x453F3A0", VA = "0x1845407A0", Slot = "14")]
	public void CopyTo(To[] LBLDONKHBCF, int BPPENCELOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x45408B0", Offset = "0x453F4B0", VA = "0x1845408B0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x4540920", Offset = "0x453F520", VA = "0x184540920", Slot = "6")]
	public int IndexOf(To IGAPBICELKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x4540980", Offset = "0x453F580", VA = "0x184540980", Slot = "7")]
	public void Insert(int HIANDEDCLIF, To IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x4540A30", Offset = "0x453F630", VA = "0x184540A30", Slot = "15")]
	public bool Remove(To IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x4540A00", Offset = "0x453F600", VA = "0x184540A00", Slot = "8")]
	public void RemoveAt(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2D96B80", Offset = "0x2D95780", VA = "0x182D96B80", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class GHEFMNLBJAD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Func<From, To> IGPHAIGDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Func<To, From> IHHPOLINCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<From> LBLDONKHBCF;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public To GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x4E2ED30", Offset = "0x4E2D930", VA = "0x184E2ED30", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x4E2ED80", Offset = "0x4E2D980", VA = "0x184E2ED80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x4E2ECF0", Offset = "0x4E2D8F0", VA = "0x184E2ECF0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool IDIBHBMOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFE0", Offset = "0x5EBBE0", VA = "0x1805ECFE0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x366BEF0", Offset = "0x366AAF0", VA = "0x18366BEF0")]
	public GHEFMNLBJAD(Func<From, To> IGPHAIGDIDM, Func<To, From> IHHPOLINCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x4E2E8B0", Offset = "0x4E2D4B0", VA = "0x184E2E8B0", Slot = "11")]
	public void Add(To IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x4E2E900", Offset = "0x4E2D500", VA = "0x184E2E900", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x4E2E950", Offset = "0x4E2D550", VA = "0x184E2E950", Slot = "13")]
	public bool Contains(To IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EA10", Offset = "0x4E2D610", VA = "0x184E2EA10", Slot = "14")]
	public void CopyTo(To[] LBLDONKHBCF, int BPPENCELOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EAD0", Offset = "0x4E2D6D0", VA = "0x184E2EAD0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EB90", Offset = "0x4E2D790", VA = "0x184E2EB90", Slot = "6")]
	public int IndexOf(To IGAPBICELKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EC00", Offset = "0x4E2D800", VA = "0x184E2EC00", Slot = "7")]
	public void Insert(int HIANDEDCLIF, To IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x4E2ECA0", Offset = "0x4E2D8A0", VA = "0x184E2ECA0", Slot = "15")]
	public bool Remove(To IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x4E2EC50", Offset = "0x4E2D850", VA = "0x184E2EC50", Slot = "8")]
	public void RemoveAt(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x1FD46E0", Offset = "0x1FD32E0", VA = "0x181FD46E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public class JJPEILOMFCM<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly Func<From, To> IGPHAIGDIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Func<To, From> IHHPOLINCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeList<From> FPPBJGHNMLI;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public To GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool IDIBHBMOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	public JJPEILOMFCM(Func<From, To> IGPHAIGDIDM, Func<To, From> IHHPOLINCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] LBLDONKHBCF, int BPPENCELOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To IGAPBICELKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int HIANDEDCLIF, To IGAPBICELKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To IGAPBICELKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class IJHCGHMFIHA
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public const string CCDLCKIKONK = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public const string AHPCLDNNDNH = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const string GCADGGBHLHN = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public const string PKDLFOKFCDM = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public const string PCBKKGBIJCF = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public const string JHDMBDFNBMA = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public const string GKOKIIMOGMK = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class HGEFLPOKDDI
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class JAHPFHILFHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public DEGAMIMEMLN services;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public JAHPFHILFHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x236FC60", Offset = "0x236E860", VA = "0x18236FC60")]
		internal void <InitServices>b__1(HKFIKAGKAAK svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x236FCC0", Offset = "0x236E8C0", VA = "0x18236FCC0")]
		internal void <InitServices>b__2(GEPKKGPMACB svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x236A0E0", Offset = "0x2368CE0", VA = "0x18236A0E0")]
	public static void DFPINAFKBJK(this IEEMDNAPKGD JFAHNIMFMGP, DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x38B9730", Offset = "0x38B8330", VA = "0x1838B9730")]
	public static void PHGODHLJCOB<T>(this IEEMDNAPKGD JFAHNIMFMGP, Action<T> AMPOJACJKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x38B9940", Offset = "0x38B8540", VA = "0x1838B9940")]
	public static void PNPCBLLNELC<T>(this IEEMDNAPKGD JFAHNIMFMGP, Action<T> AMPOJACJKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x38B93F0", Offset = "0x38B7FF0", VA = "0x1838B93F0")]
	public static void OOGFADKNFDN<T>(this IEEMDNAPKGD JFAHNIMFMGP, Action<T> AMPOJACJKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x38B97A0", Offset = "0x38B83A0", VA = "0x1838B97A0")]
	public static void PLKKKOJMCOJ<T>(this IEEMDNAPKGD JFAHNIMFMGP, Action<T> AMPOJACJKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x38B9590", Offset = "0x38B8190", VA = "0x1838B9590")]
	public static void PFHGJKLINIF<T>(this IEEMDNAPKGD JFAHNIMFMGP, Action<T> AMPOJACJKNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x38B9330", Offset = "0x38B7F30", VA = "0x1838B9330")]
	private static void DFGLBIEDHLG<T>(object NLIFFPLFBDI, Action<T> AMPOJACJKNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class OBLKMLAKMBL
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class PKKDANGFPDI
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	public static bool PKPOAPJFGGA<T>(ref T FNKIIBFNLFB, ref T EDLPJGEPJPK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class GBJGLJHKFCB
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class KLNFNDLBPOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public KLNFNDLBPOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2366380", Offset = "0x2364F80", VA = "0x182366380")]
	public static string GEGEJGNNIJB(Transform BHPNFBEEMHL, Transform FNPGAOOPMNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class MMILHCJCNHE : LMBGBEAEDIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly MethodInfo OADEHEJDFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Type[] ALIJPBPLEAE;

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2378FB0", Offset = "0x2377BB0", VA = "0x182378FB0")]
	public MMILHCJCNHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action GIIEEPHPCLC();

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2378F70", Offset = "0x2377B70", VA = "0x182378F70")]
	public MethodInfo NDGIIBJPODH(Action KINCGCMCJLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2378DE0", Offset = "0x23779E0", VA = "0x182378DE0", Slot = "4")]
	public void KIEPKILKNCN(Type LIJLAEFJGCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public abstract class JHBFMHKOKIF : MMILHCJCNHE
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private enum CPALNCGEBPB
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2372F80", Offset = "0x2371B80", VA = "0x182372F80", Slot = "5")]
	public override Action GIIEEPHPCLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void JJPELBGAFMK<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2372F00", Offset = "0x2371B00", VA = "0x182372F00")]
	[Preserve]
	public void DFLIOLOOALB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2372EF0", Offset = "0x2371AF0", VA = "0x182372EF0")]
	protected JHBFMHKOKIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class JFOKNOPGALL : MMILHCJCNHE
{
	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2372E70", Offset = "0x2371A70", VA = "0x182372E70", Slot = "5")]
	public override Action GIIEEPHPCLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void CHFNAFFPMLH<T>() where T : MHGHNPKFAFL;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2372DF0", Offset = "0x23719F0", VA = "0x182372DF0")]
	[Preserve]
	public void DFLIOLOOALB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2372EF0", Offset = "0x2371AF0", VA = "0x182372EF0")]
	protected JFOKNOPGALL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class KDDFCHAINII : MMILHCJCNHE
{
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x23741E0", Offset = "0x2372DE0", VA = "0x1823741E0", Slot = "5")]
	public override Action GIIEEPHPCLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void AGKOLPCAGKM<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2374160", Offset = "0x2372D60", VA = "0x182374160")]
	[Preserve]
	public void DFLIOLOOALB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2372EF0", Offset = "0x2371AF0", VA = "0x182372EF0")]
	protected KDDFCHAINII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[MHBJLGEIMOG(typeof(BDNIJAOEAEJ), new string[] { })]
public class MBPIHFPOFOF : CELPKLDEEEG, BDNIJAOEAEJ
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public DEGAMIMEMLN FIEBOMHOKHP
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC490", Offset = "0x5EB090", VA = "0x1805EC490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public JDDPPIAFHCO OGHJOOKJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4A0", Offset = "0x5EB0A0", VA = "0x1805EC4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public BHBECLCNBCK BONNMJFMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDF0", Offset = "0x5ED9F0", VA = "0x1805EEDF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x616D70", Offset = "0x615970", VA = "0x180616D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public FJKDEOKBEGE LMJJJJNFFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x710440", Offset = "0x70F040", VA = "0x180710440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public EGCFDCFHPMF NJEANANPJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x614A30", Offset = "0x613630", VA = "0x180614A30", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x724880", Offset = "0x723480", VA = "0x180724880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public PNPPGDJCNCL BMKPBNENOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x5ED010", Offset = "0x5EBC10", VA = "0x1805ED010", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x5ED020", Offset = "0x5EBC20", VA = "0x1805ED020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public FDNCDAIFHHA EDAFGIAPEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x5FFD70", Offset = "0x5FE970", VA = "0x1805FFD70", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x686FC0", Offset = "0x685BC0", VA = "0x180686FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public DLIOKHGJHNN NEOMBDCOKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x63F130", Offset = "0x63DD30", VA = "0x18063F130", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x6799F0", Offset = "0x6785F0", VA = "0x1806799F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public LBMBOABFHDF EALDJLPFMAE
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x610720", Offset = "0x60F320", VA = "0x180610720", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x679920", Offset = "0x678520", VA = "0x180679920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public FOJAKKAEGJD BAFEKHBBHFA
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE220", Offset = "0x5FCE20", VA = "0x1805FE220", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x686370", Offset = "0x684F70", VA = "0x180686370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public MDONMFNCNJF ABFCKKIPNIP
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x5F2630", Offset = "0x5F1230", VA = "0x1805F2630", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x5FFEE0", Offset = "0x5FEAE0", VA = "0x1805FFEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public ODHGFDMHCDN ALNEDOGAKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x5F2620", Offset = "0x5F1220", VA = "0x1805F2620", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x679B80", Offset = "0x678780", VA = "0x180679B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public DILLBIDCLLI KJLHAFJFHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x610660", Offset = "0x60F260", VA = "0x180610660", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x5F2640", Offset = "0x5F1240", VA = "0x1805F2640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public EEMFEBEOLOO IIMEPKAIKKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x610670", Offset = "0x60F270", VA = "0x180610670", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x5FE250", Offset = "0x5FCE50", VA = "0x1805FE250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public JFDNCMBCKCA JLLLBFHKFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x5FFEA0", Offset = "0x5FEAA0", VA = "0x1805FFEA0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x5FE230", Offset = "0x5FCE30", VA = "0x1805FE230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public BNDFEICOCDN NPJIANAICGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x626080", Offset = "0x624C80", VA = "0x180626080", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x6877E0", Offset = "0x6863E0", VA = "0x1806877E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CGDNGNAEAEB DFOPPEKOFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x63F140", Offset = "0x63DD40", VA = "0x18063F140", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x7CCBF0", Offset = "0x7CB7F0", VA = "0x1807CCBF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public BINMKOFKKMO IDKCIBEDLPI
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x675C40", Offset = "0x674840", VA = "0x180675C40", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x686E10", Offset = "0x685A10", VA = "0x180686E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public ENJBBMGPMHG GNPBDCHBHON
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x6106E0", Offset = "0x60F2E0", VA = "0x1806106E0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE240", Offset = "0x5FCE40", VA = "0x1805FE240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public PNNEAMBELML PJAILHEIIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6B7390", Offset = "0x6B5F90", VA = "0x1806B7390", Slot = "4")]
		get
		{
			return default(PNNEAMBELML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2377510", Offset = "0x2376110", VA = "0x182377510", Slot = "5")]
	public void HICLPHNLMNF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public MBPIHFPOFOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
public class IIFPKCFOHOB : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class AEFGHCPGHHI : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public IIFPKCFOHOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x610710", Offset = "0x60F310", VA = "0x180610710", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x2364220", Offset = "0x2362E20", VA = "0x182364220", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD7D0", Offset = "0x6FC3D0", VA = "0x1806FD7D0")]
		[DebuggerHidden]
		public AEFGHCPGHHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2364060", Offset = "0x2362C60", VA = "0x182364060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x23641D0", Offset = "0x2362DD0", VA = "0x1823641D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400018D")]
	protected const ulong KNEPPGIEKHM = 1uL;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	protected const ulong AEJGJIJCIJC = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	protected const int MLKOMAHHGGF = 8;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	protected const int BOGMCKJIIDF = 6;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int FPBFJAGGFLC = 64;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	protected const int FGBAOFHDDOM = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly List<ulong> EGJHEPHPDOG;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x678670", Offset = "0x677270", VA = "0x180678670")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x73E910", Offset = "0x73D510", VA = "0x18073E910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public int IOOLHKPCKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x73E8D0", Offset = "0x73D4D0", VA = "0x18073E8D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x73E900", Offset = "0x73D500", VA = "0x18073E900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x236E740", Offset = "0x236D340", VA = "0x18236E740")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x236E360", Offset = "0x236CF60", VA = "0x18236E360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x236F070", Offset = "0x236DC70", VA = "0x18236F070")]
	public IIFPKCFOHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x236EF50", Offset = "0x236DB50", VA = "0x18236EF50")]
	public IIFPKCFOHOB(int MBMIACCJFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x236E670", Offset = "0x236D270", VA = "0x18236E670")]
	public bool EJGBFJKOPNE(int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x236E940", Offset = "0x236D540", VA = "0x18236E940")]
	public bool HIOLOHCCNCN(int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x236E260", Offset = "0x236CE60", VA = "0x18236E260")]
	public bool BFNCGMBBNHD(int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x236EF40", Offset = "0x236DB40", VA = "0x18236EF40")]
	public bool PDABALEFEIL(int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x236E2E0", Offset = "0x236CEE0", VA = "0x18236E2E0")]
	public void CAGIEACJCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x236E500", Offset = "0x236D100", VA = "0x18236E500")]
	public void COJFMJPIIEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x236E7E0", Offset = "0x236D3E0", VA = "0x18236E7E0")]
	public void GELHLBKPBFF(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x236EBA0", Offset = "0x236D7A0", VA = "0x18236EBA0")]
	public void LONCNHKPMCG(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x236E5E0", Offset = "0x236D1E0", VA = "0x18236E5E0")]
	public bool DJEHAFPHMKN(int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x236EE30", Offset = "0x236DA30", VA = "0x18236EE30")]
	public void OAHFCJBGPCJ(int FPKCCNCOJGI, int BKKGFAKFDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x236EC90", Offset = "0x236D890", VA = "0x18236EC90")]
	public void NNCHFANEPLH(int GJJHHCKBLGD, int HHCNFMAKKIK, int BKKGFAKFDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x236EA20", Offset = "0x236D620", VA = "0x18236EA20")]
	public int LFMPFEAFMAL(int BKKGFAKFDNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x236EAE0", Offset = "0x236D6E0", VA = "0x18236EAE0")]
	public int LFMPFEAFMAL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x236EB50", Offset = "0x236D750", VA = "0x18236EB50")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x236E8D0", Offset = "0x236D4D0", VA = "0x18236E8D0", Slot = "4")]
	[IteratorStateMachine(typeof(AEFGHCPGHHI))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x236E8D0", Offset = "0x236D4D0", VA = "0x18236E8D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class GKLMJLOGPEH<T> : global::MJPIHDHGBCJ<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	protected global::ILHNNKLLKGP<T> ICNFAPBEJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	protected global::KCFABAMIMAB<T> LKFGPLLOHKE;

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x1FC5B80", Offset = "0x1FC4780", VA = "0x181FC5B80")]
	public GKLMJLOGPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x226B360", Offset = "0x2269F60", VA = "0x18226B360")]
	public GKLMJLOGPEH(global::ILHNNKLLKGP<T> ICNFAPBEJNI, global::KCFABAMIMAB<T> LKFGPLLOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x226B020", Offset = "0x2269C20", VA = "0x18226B020", Slot = "11")]
	public override T EFBLDOLKNNC(IKIDEMPJGGM AOMLNNKAJKE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x226AC70", Offset = "0x2269870", VA = "0x18226AC70", Slot = "12")]
	public override void CGMPPIJDMHM(IKIDEMPJGGM AOMLNNKAJKE, T KGJOJGIPNPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class IGFDEDNGJCH
{
	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x20CE370", Offset = "0x20CCF70", VA = "0x1820CE370")]
	public static LOGKGBLPOOD KIEPKILKNCN<T>(this INLHJOGNGJK GCALAGNGEDP, global::AABHEEDMDPC<T> FHNLBBBEDLN, global::ILHNNKLLKGP<T> ICNFAPBEJNI, global::KCFABAMIMAB<T> LKFGPLLOHKE) where T : struct
	{
		return default(LOGKGBLPOOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class AFFIBFKDNMG<T> : global::GKLMJLOGPEH<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2D951E0", Offset = "0x2D93DE0", VA = "0x182D951E0")]
	public AFFIBFKDNMG(T BBPNPMFNJED, T PFDMIIOLPIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class OPDIGFALMCG<T> : global::MJPIHDHGBCJ<T> where T : struct, MHGHNPKFAFL
{
	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x497E2B0", Offset = "0x497CEB0", VA = "0x18497E2B0", Slot = "11")]
	public override T EFBLDOLKNNC(IKIDEMPJGGM AOMLNNKAJKE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x497E1B0", Offset = "0x497CDB0", VA = "0x18497E1B0", Slot = "12")]
	public override void CGMPPIJDMHM(IKIDEMPJGGM AOMLNNKAJKE, T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x21834A0", Offset = "0x21820A0", VA = "0x1821834A0")]
	public OPDIGFALMCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class CNPPDMICIJO : AENIEIDJNIK
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public abstract Type JFMKFLEJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void EFBLDOLKNNC(IKIDEMPJGGM AOMLNNKAJKE, in EJMAFNBMMGI KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void CGMPPIJDMHM(IKIDEMPJGGM AOMLNNKAJKE, in CJHLIFJIIDK KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void BEFHONAIJPO(IKIDEMPJGGM AOMLNNKAJKE, EJNLIIMNDDH HKGCALJNCCI, [Optional] object NAEOEJMOBMH);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	protected CNPPDMICIJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class MJPIHDHGBCJ<T> : CNPPDMICIJO where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public override Type JFMKFLEJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A22A50", Offset = "0x2A21650", VA = "0x182A22A50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T EFBLDOLKNNC(IKIDEMPJGGM AOMLNNKAJKE);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void CGMPPIJDMHM(IKIDEMPJGGM AOMLNNKAJKE, T KGJOJGIPNPH);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x2A21DA0", Offset = "0x2A209A0", VA = "0x182A21DA0", Slot = "8")]
	public override void EFBLDOLKNNC(IKIDEMPJGGM AOMLNNKAJKE, in EJMAFNBMMGI FNPGAOOPMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A217B0", Offset = "0x2A203B0", VA = "0x182A217B0", Slot = "9")]
	public override void CGMPPIJDMHM(IKIDEMPJGGM AOMLNNKAJKE, in CJHLIFJIIDK FNNHACEFOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A205E0", Offset = "0x2A1F1E0", VA = "0x182A205E0", Slot = "10")]
	public override void BEFHONAIJPO(IKIDEMPJGGM AOMLNNKAJKE, EJNLIIMNDDH HKGCALJNCCI, object NAEOEJMOBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x2870A30", Offset = "0x286F630", VA = "0x182870A30")]
	protected MJPIHDHGBCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class AHHEDMCBGCH
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class JBMALMDANDD
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class MINGMBMNLLA<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
			public MINGMBMNLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x2872B90", Offset = "0x2871790", VA = "0x182872B90")]
			internal void <RegisterFixedString>b__0(IKIDEMPJGGM p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x2872E10", Offset = "0x2871A10", VA = "0x182872E10")]
			internal T <RegisterFixedString>b__1(IKIDEMPJGGM p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x263D410", Offset = "0x263C010", VA = "0x18263D410")]
		public static void NNBEMKIJFNJ(FAEOBMIIOFC JMDOFDJFGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD600", Offset = "0x1FAC200", VA = "0x181FAD600")]
		private static void GOBDAOLHLHM<T>(FAEOBMIIOFC JMDOFDJFGBC, int PFDMIIOLPIG) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD720", Offset = "0x1FAC320", VA = "0x181FAD720")]
		private static void INHMNIENHOI<T>(IKIDEMPJGGM JJMMEHEHCFO, T BMIMFPIIMDL, int PFDMIIOLPIG) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x1EA3CB0", Offset = "0x1EA28B0", VA = "0x181EA3CB0")]
		private static T GCIENNMNFHF<T>(IKIDEMPJGGM JJMMEHEHCFO, int PFDMIIOLPIG) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public JBMALMDANDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class FANOAPENGPA : JHBFMHKOKIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private FAEOBMIIOFC JMDOFDJFGBC;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x1FABCF0", Offset = "0x1FAA8F0", VA = "0x181FABCF0", Slot = "6")]
		public override void JJPELBGAFMK<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x2638FA0", Offset = "0x2637BA0", VA = "0x182638FA0")]
		public static void JMCMOAPGGBO(FAEOBMIIOFC JMDOFDJFGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x2639020", Offset = "0x2637C20", VA = "0x182639020")]
		public FANOAPENGPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x262E4E0", Offset = "0x262D0E0", VA = "0x18262E4E0")]
	public static void DHBDAPIPPGC(FAEOBMIIOFC JMDOFDJFGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6C00", Offset = "0x1FA5800", VA = "0x181FA6C00")]
	public static void BCNBHEMGHIK<T>(FAEOBMIIOFC JMDOFDJFGBC, global::ILHNNKLLKGP<T> ICNFAPBEJNI, global::KCFABAMIMAB<T> LKFGPLLOHKE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FA6C90", Offset = "0x1FA5890", VA = "0x181FA6C90")]
	public static void EHLLMDJHMCA<T>(FAEOBMIIOFC ODCFKLLJCFB) where T : struct, MHGHNPKFAFL
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface FAEOBMIIOFC : global::AHLBPBPFKGM<FAEOBMIIOFC>
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIEPKILKNCN(Type LIJLAEFJGCI, AENIEIDJNIK ODCFKLLJCFB);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool POIHJJLHJCC(Type LIJLAEFJGCI, out AENIEIDJNIK ODCFKLLJCFB);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class KKGOCDOBKPN
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2374AC0", Offset = "0x23736C0", VA = "0x182374AC0")]
	public static void KIEPKILKNCN(this FAEOBMIIOFC DNIGLLFHMCE, AENIEIDJNIK ODCFKLLJCFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[MHBJLGEIMOG(typeof(INLHJOGNGJK), new string[] { })]
public sealed class HJENJKJECFF : INLHJOGNGJK, global::AHLBPBPFKGM<INLHJOGNGJK>, CCILBHCKADC, HKFIKAGKAAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly Dictionary<LOGKGBLPOOD, AENIEIDJNIK> JMDOFDJFGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private FAEOBMIIOFC IFMFDEDHCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private JDGCMEDKNHD GCALAGNGEDP;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool CDHMDBBNKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x66D990", Offset = "0x66C590", VA = "0x18066D990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xA3B180", Offset = "0xA39D80", VA = "0x180A3B180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x236B170", Offset = "0x2369D70", VA = "0x18236B170")]
	public HJENJKJECFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x236B0C0", Offset = "0x2369CC0", VA = "0x18236B0C0")]
	public HJENJKJECFF(Dictionary<LOGKGBLPOOD, AENIEIDJNIK> JMDOFDJFGBC, bool FPFGFMIALBM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x236AE70", Offset = "0x2369A70", VA = "0x18236AE70", Slot = "7")]
	public void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x236AEC0", Offset = "0x2369AC0", VA = "0x18236AEC0", Slot = "8")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x236AE20", Offset = "0x2369A20", VA = "0x18236AE20", Slot = "9")]
	public void LONCNHKPMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x236AA50", Offset = "0x2369650", VA = "0x18236AA50", Slot = "4")]
	public LOGKGBLPOOD DDLLOIBHPCA(BDHIOHAFMEG FHNLBBBEDLN)
	{
		return default(LOGKGBLPOOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x236AD00", Offset = "0x2369900", VA = "0x18236AD00", Slot = "5")]
	public void KIEPKILKNCN(LOGKGBLPOOD DJHPMDEHJMK, AENIEIDJNIK ODCFKLLJCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x236ABF0", Offset = "0x23697F0", VA = "0x18236ABF0")]
	[Conditional("DEBUG_BUILD")]
	private void DNNIEDPCNNB(LOGKGBLPOOD DJHPMDEHJMK, Type LIJLAEFJGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x236AF40", Offset = "0x2369B40", VA = "0x18236AF40", Slot = "6")]
	public bool POIHJJLHJCC(LOGKGBLPOOD DJHPMDEHJMK, out AENIEIDJNIK ODCFKLLJCFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x236AB20", Offset = "0x2369720", VA = "0x18236AB20", Slot = "10")]
	public INLHJOGNGJK DJGGNJCKKCO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[MHBJLGEIMOG(typeof(FAEOBMIIOFC), new string[] { })]
public sealed class NHNABCDLJFO : CCILBHCKADC, FAEOBMIIOFC, global::AHLBPBPFKGM<FAEOBMIIOFC>
{
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly Dictionary<Type, AENIEIDJNIK> JMDOFDJFGBC;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool CDHMDBBNKCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x71AFE0", Offset = "0x719BE0", VA = "0x18071AFE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CD0", Offset = "0x7BF8D0", VA = "0x1807C0CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x26B4860", Offset = "0x26B3460", VA = "0x1826B4860")]
	public NHNABCDLJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x26B47B0", Offset = "0x26B33B0", VA = "0x1826B47B0")]
	public NHNABCDLJFO(Dictionary<Type, AENIEIDJNIK> JMDOFDJFGBC, bool FPFGFMIALBM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x26B4650", Offset = "0x26B3250", VA = "0x1826B4650", Slot = "4")]
	public void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x26B4560", Offset = "0x26B3160", VA = "0x1826B4560", Slot = "5")]
	public void KIEPKILKNCN(Type LIJLAEFJGCI, AENIEIDJNIK ODCFKLLJCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x26B46B0", Offset = "0x26B32B0", VA = "0x1826B46B0", Slot = "6")]
	public bool POIHJJLHJCC(Type LIJLAEFJGCI, out AENIEIDJNIK ODCFKLLJCFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x26B4490", Offset = "0x26B3090", VA = "0x1826B4490", Slot = "7")]
	public FAEOBMIIOFC DJGGNJCKKCO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[MHBJLGEIMOG(typeof(HHHGPLGMGKP), new string[] { })]
internal sealed class HFFOPJIOKMA : HHHGPLGMGKP, CCILBHCKADC, HKFIKAGKAAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly Dictionary<LOGKGBLPOOD, BPCOBFEGIJF> JAOCJOEEJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private JDGCMEDKNHD GCALAGNGEDP;

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2369FC0", Offset = "0x2368BC0", VA = "0x182369FC0", Slot = "6")]
	public void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x236A010", Offset = "0x2368C10", VA = "0x18236A010", Slot = "7")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2369F50", Offset = "0x2368B50", VA = "0x182369F50", Slot = "4")]
	public void KIEPKILKNCN(LOGKGBLPOOD IPGOEGFNLNJ, Type ADFIFPIDFMD, BPCOBFEGIJF KAEIIPHPFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2369D90", Offset = "0x2368990", VA = "0x182369D90", Slot = "5")]
	public bool DFEFFANPIAB(LOGKGBLPOOD IPGOEGFNLNJ, out BPCOBFEGIJF KAEIIPHPFDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2369E00", Offset = "0x2368A00", VA = "0x182369E00")]
	[Conditional("DEBUG_BUILD")]
	private void DFLLDKKCJEB(LOGKGBLPOOD IPGOEGFNLNJ, Type ADFIFPIDFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x236A070", Offset = "0x2368C70", VA = "0x18236A070")]
	public HFFOPJIOKMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[MHBJLGEIMOG(typeof(MBOEOCBCOCB), new string[] { })]
[IBGAMCLMLFP(typeof(JDGCMEDKNHD))]
internal sealed class PENOPBJFLCF : MBOEOCBCOCB, POIJNBNBJIE, CCILBHCKADC, HKFIKAGKAAK, GEPKKGPMACB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly IIFPKCFOHOB DMOBJPOJGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly Dictionary<GEGPJNFMCPG, int> FAEBHMALMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Stack<int> FGHPEPNEAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private JDGCMEDKNHD GCALAGNGEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private PNPPGDJCNCL LCAGHKIOCIC;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private int OMPDGNFPHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x26BA0E0", Offset = "0x26B8CE0", VA = "0x1826BA0E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool EANPKPEFEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x66E8B0", Offset = "0x66D4B0", VA = "0x18066E8B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x73C890", Offset = "0x73B490", VA = "0x18073C890", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x26B9E80", Offset = "0x26B8A80", VA = "0x1826B9E80", Slot = "6")]
	public void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x26BA370", Offset = "0x26B8F70", VA = "0x1826BA370", Slot = "7")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x26BA230", Offset = "0x26B8E30", VA = "0x1826BA230", Slot = "8")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x26BA190", Offset = "0x26B8D90", VA = "0x1826BA190")]
	private void LAEBJBANBPP(OLACMNNNFCK AIJKIAIKFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x26BA2C0", Offset = "0x26B8EC0", VA = "0x1826BA2C0", Slot = "4")]
	public bool MHAIICDGCFD(GEGPJNFMCPG PJIBLINGJGM, LOGKGBLPOOD MDENPOJAPFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x26B9F50", Offset = "0x26B8B50", VA = "0x1826B9F50", Slot = "5")]
	public void GGBNLILMOAH(GEGPJNFMCPG PJIBLINGJGM, Span<LOGKGBLPOOD> GCALAGNGEDP, bool NIEIIACNEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x26B9E80", Offset = "0x26B8A80", VA = "0x1826B9E80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x26BA3F0", Offset = "0x26B8FF0", VA = "0x1826BA3F0")]
	public PENOPBJFLCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class JEDNFKIIDPF
{
	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2370E00", Offset = "0x236FA00", VA = "0x182370E00")]
	public static void DHCEKOOMOND(this IKIDEMPJGGM AOMLNNKAJKE, ReadOnlyMemory<byte> IHKJKEPDMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2D43BA0", Offset = "0x2D427A0", VA = "0x182D43BA0")]
	public static void IEOBKPDECOJ<T>(this IKIDEMPJGGM AOMLNNKAJKE, in T KGJOJGIPNPH) where T : struct, MHGHNPKFAFL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x2020790", Offset = "0x201F390", VA = "0x182020790")]
	public static T EGDKJINICCC<T>(this IKIDEMPJGGM AOMLNNKAJKE) where T : struct, MHGHNPKFAFL
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2371030", Offset = "0x236FC30", VA = "0x182371030")]
	public static void IEOBKPDECOJ(this IKIDEMPJGGM AOMLNNKAJKE, EPALEFLJHEP JKKBPPBNGGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2371060", Offset = "0x236FC60", VA = "0x182371060")]
	public static EPALEFLJHEP JMIJDODEAIB(this IKIDEMPJGGM AOMLNNKAJKE)
	{
		return default(EPALEFLJHEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2370E80", Offset = "0x236FA80", VA = "0x182370E80")]
	public static void GFMMMLBPMPH(this IKIDEMPJGGM FGCLHPLIFAM, uint ABJNELBFPBM, bool KOFBPIHEFID = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x2371090", Offset = "0x236FC90", VA = "0x182371090")]
	public static uint NOBLHBHLBNP(this IKIDEMPJGGM GLGFLHANMEH, bool KOFBPIHEFID = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class FOGNOEBGFKD
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class KGHCLFECBEA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public KGHCLFECBEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x29AEFA0", Offset = "0x29ADBA0", VA = "0x1829AEFA0")]
		internal void <GetByteEnumDelegates>b__0(IKIDEMPJGGM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x29AF010", Offset = "0x29ADC10", VA = "0x1829AF010")]
		internal T <GetByteEnumDelegates>b__1(IKIDEMPJGGM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class GDGCIJBCHFM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public GDGCIJBCHFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x29A8640", Offset = "0x29A7240", VA = "0x1829A8640")]
		internal void <GetSByteEnumDelegates>b__0(IKIDEMPJGGM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x29A86B0", Offset = "0x29A72B0", VA = "0x1829A86B0")]
		internal T <GetSByteEnumDelegates>b__1(IKIDEMPJGGM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class CEILFNHOLJO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public CEILFNHOLJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x29A1060", Offset = "0x299FC60", VA = "0x1829A1060")]
		internal void <GetShortEnumDelegates>b__0(IKIDEMPJGGM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x29A10D0", Offset = "0x299FCD0", VA = "0x1829A10D0")]
		internal T <GetShortEnumDelegates>b__1(IKIDEMPJGGM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class ECJNIJMEHAM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public ECJNIJMEHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x29A2CE0", Offset = "0x29A18E0", VA = "0x1829A2CE0")]
		internal void <GetUShortEnumDelegates>b__0(IKIDEMPJGGM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x29A2D50", Offset = "0x29A1950", VA = "0x1829A2D50")]
		internal T <GetUShortEnumDelegates>b__1(IKIDEMPJGGM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class JGAKBOFKJGA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public JGAKBOFKJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x29AEEE0", Offset = "0x29ADAE0", VA = "0x1829AEEE0")]
		internal void <GetIntEnumDelegates>b__0(IKIDEMPJGGM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x29AEF40", Offset = "0x29ADB40", VA = "0x1829AEF40")]
		internal T <GetIntEnumDelegates>b__1(IKIDEMPJGGM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class HPFMDNKABBJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x1EA9200", Offset = "0x1EA7E00", VA = "0x181EA9200")]
		public HPFMDNKABBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x29ADBD0", Offset = "0x29AC7D0", VA = "0x1829ADBD0")]
		internal void <GetUIntEnumDelegates>b__0(IKIDEMPJGGM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x29ADC30", Offset = "0x29AC830", VA = "0x1829ADC30")]
		internal T <GetUIntEnumDelegates>b__1(IKIDEMPJGGM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x38A6A80", Offset = "0x38A5680", VA = "0x1838A6A80")]
	public static void EMDEHJMEILA<T>(T BBPNPMFNJED, T PFDMIIOLPIG, out global::ILHNNKLLKGP<T> EGBJFOLJNCL, out global::KCFABAMIMAB<T> DIFCPGHBAOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x38A6DC0", Offset = "0x38A59C0", VA = "0x1838A6DC0")]
	private static void PAJKMGFKCJE<T>(T BBPNPMFNJED, T PFDMIIOLPIG, out global::ILHNNKLLKGP<T> EGBJFOLJNCL, out global::KCFABAMIMAB<T> DIFCPGHBAOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x38A6DC0", Offset = "0x38A59C0", VA = "0x1838A6DC0")]
	private static void LMFMBCDFBFI<T>(T BBPNPMFNJED, T PFDMIIOLPIG, out global::ILHNNKLLKGP<T> EGBJFOLJNCL, out global::KCFABAMIMAB<T> DIFCPGHBAOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x38A6C70", Offset = "0x38A5870", VA = "0x1838A6C70")]
	private static void HDFONENJCPH<T>(T BBPNPMFNJED, T PFDMIIOLPIG, out global::ILHNNKLLKGP<T> EGBJFOLJNCL, out global::KCFABAMIMAB<T> DIFCPGHBAOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x38A6C70", Offset = "0x38A5870", VA = "0x1838A6C70")]
	private static void FCICHHADEFB<T>(T BBPNPMFNJED, T PFDMIIOLPIG, out global::ILHNNKLLKGP<T> EGBJFOLJNCL, out global::KCFABAMIMAB<T> DIFCPGHBAOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x38A6F10", Offset = "0x38A5B10", VA = "0x1838A6F10")]
	private static void NIJNJCFKNEP<T>(T BBPNPMFNJED, T PFDMIIOLPIG, out global::ILHNNKLLKGP<T> EGBJFOLJNCL, out global::KCFABAMIMAB<T> DIFCPGHBAOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x38A6F10", Offset = "0x38A5B10", VA = "0x1838A6F10")]
	private static void NIHMEIMDBAK<T>(T BBPNPMFNJED, T PFDMIIOLPIG, out global::ILHNNKLLKGP<T> EGBJFOLJNCL, out global::KCFABAMIMAB<T> DIFCPGHBAOF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public abstract class JJDJANHKKMD : JKDPGOGJIHE, GEPKKGPMACB
{
	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2373000", Offset = "0x2371C00", VA = "0x182373000", Slot = "4")]
	private void CLCOCLIANKP(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void PKOHCIDMICD(INLHJOGNGJK GCALAGNGEDP);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480")]
	protected JJDJANHKKMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[NJDAPFLEPFB(typeof(LocalPoseData))]
public sealed class GIAMLFKKGEH : JJDJANHKKMD
{
	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2367AC0", Offset = "0x23666C0", VA = "0x182367AC0", Slot = "5")]
	protected override void PKOHCIDMICD(INLHJOGNGJK GCALAGNGEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480")]
	public GIAMLFKKGEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[InternalBufferCapacity(1)]
internal struct APAFMJDJPNK : ISystemStateBufferElementData, IBufferElementData, IEquatable<APAFMJDJPNK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public DFFMNBPBBBC CGGCCCAGOLF;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x2631D10", Offset = "0x2630910", VA = "0x182631D10", Slot = "4")]
	public bool Equals(APAFMJDJPNK NPKIIGGBCCI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F60", Offset = "0x6A0B60", VA = "0x1806A1F60")]
	public static APAFMJDJPNK GOPIOOMOEDD(DFFMNBPBBBC CGGCCCAGOLF)
	{
		return default(APAFMJDJPNK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[InternalBufferCapacity(4)]
internal struct IHEGPFNFMIH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public DFFMNBPBBBC CGGCCCAGOLF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F60", Offset = "0x6A0B60", VA = "0x1806A1F60")]
	public static IHEGPFNFMIH GOPIOOMOEDD(DFFMNBPBBBC CGGCCCAGOLF)
	{
		return default(IHEGPFNFMIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
internal struct DFFMNBPBBBC : global::POBAFBEGBJN<DFFMNBPBBBC>, FBMJPDGBHLO, IEquatable<DFFMNBPBBBC>
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public int PAOIHHHPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x8AB500", Offset = "0x8AA100", VA = "0x1808AB500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x925AC0", Offset = "0x9246C0", VA = "0x180925AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public int EKKPBKBJINC
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4E0", Offset = "0x8AA0E0", VA = "0x1808AB4E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x8FF2D0", Offset = "0x8FDED0", VA = "0x1808FF2D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool PDABALEFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2634AE0", Offset = "0x26336E0", VA = "0x182634AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x2631D10", Offset = "0x2630910", VA = "0x182631D10", Slot = "8")]
	public bool Equals(DFFMNBPBBBC NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x2634B20", Offset = "0x2633720", VA = "0x182634B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class OOJICJENNJD : global::JGAPEKEIJCF<AuthoredParentData, LDLGNIMIDMK, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x26B7CC0", Offset = "0x26B68C0", VA = "0x1826B7CC0", Slot = "14")]
	protected override EntityQueryDesc NHIHKCEDDDE(EntityQueryDesc LJHHKNNHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x787EA0", Offset = "0x786AA0", VA = "0x180787EA0", Slot = "15")]
	protected override EntityQueryDesc MPPDGHENJEO(EntityQueryDesc LJHHKNNHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x26B7C40", Offset = "0x26B6840", VA = "0x1826B7C40", Slot = "16")]
	protected override EntityQueryDesc BDJBLIGEKGG(EntityQueryDesc LJHHKNNHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x26B7C80", Offset = "0x26B6880", VA = "0x1826B7C80", Slot = "17")]
	protected override EntityQueryDesc IPLJBDPMAMA(EntityQueryDesc LJHHKNNHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x26B7D40", Offset = "0x26B6940", VA = "0x1826B7D40")]
	public OOJICJENNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x26B7D00", Offset = "0x26B6900", VA = "0x1826B7D00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Connectables)]
	public class UpdateConnectableVisuals : GDMMHGMPDDN, HKFIKAGKAAK
	{
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		private struct BPHNKPMGGPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public DFFMNBPBBBC CGGCCCAGOLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public float3 JACLPJHPOFC;

			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x237A080", Offset = "0x2378C80", VA = "0x18237A080")]
			public BPHNKPMGGPN(DFFMNBPBBBC CGGCCCAGOLF, float3 JACLPJHPOFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x237A060", Offset = "0x2378C60", VA = "0x18237A060")]
			public void DPBHKONDICC(out DFFMNBPBBBC CGGCCCAGOLF, out float3 JACLPJHPOFC)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private struct IOPMFFNEOGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public NativeList<BPHNKPMGGPN> list;

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
			public IOPMFFNEOGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<IHEGPFNFMIH> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private struct CLJHPEEMMEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public NativeList<BPHNKPMGGPN> list;

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
			public CLJHPEEMMEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<APAFMJDJPNK> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private struct HMHKKJCHEIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public NativeList<BPHNKPMGGPN> list;

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
			public HMHKKJCHEIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in CEJJHCLKOFC com, in DynamicBuffer<APAFMJDJPNK> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LMJBGPPDPFG : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200009C")]
			private struct CHMOMJKILCA
			{
				[Cpp2IlInjected.Token(Token = "0x200009D")]
				public struct LLJKHGGOCND
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000205")]
					public LambdaParameterValueProvider_Entity.Runtime NDGPFFGEEJN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000206")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime JHECEPKENCE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000207")]
					public LambdaParameterValueProvider_DynamicBuffer<IHEGPFNFMIH>.Runtime GNBDEGCGMCP;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000202")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity BPCAGDMEHOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000203")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> OKDKIKODBGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000204")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<IHEGPFNFMIH> LADENDNMAMK;

				[Cpp2IlInjected.Token(Token = "0x600057A")]
				[Cpp2IlInjected.Address(RVA = "0x237A150", Offset = "0x2378D50", VA = "0x18237A150")]
				public void NKMFOFOBAPA(UpdateConnectableVisuals BGEDHHBKNNK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600057B")]
				[Cpp2IlInjected.Address(RVA = "0x237A0A0", Offset = "0x2378CA0", VA = "0x18237A0A0")]
				public LLJKHGGOCND AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
				{
					return default(LLJKHGGOCND);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public UpdateConnectableVisuals INPGGNBGDDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public NativeList<BPHNKPMGGPN> FPPBJGHNMLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			private CHMOMJKILCA CGENFBJNHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe CHMOMJKILCA.LLJKHGGOCND* ADICLHDIIDC;

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KDFHADKIOEI;

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x237CA20", Offset = "0x237B620", VA = "0x18237CA20")]
			internal void KDPNCNEOCOC(Entity OCMABEPCGDM, WorldPoseData PILBCDGLPCJ, in DynamicBuffer<IHEGPFNFMIH> IADJLOGDJJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x237CDB0", Offset = "0x237B9B0", VA = "0x18237CDB0", Slot = "5")]
			public void ReadFromDisplayClass(ref IOPMFFNEOGH DDKABHBJHOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x237CDE0", Offset = "0x237B9E0", VA = "0x18237CDE0", Slot = "6")]
			public void WriteToDisplayClass(ref IOPMFFNEOGH DDKABHBJHOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x237C940", Offset = "0x237B540", VA = "0x18237C940", Slot = "4")]
			public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0x237CC40", Offset = "0x237B840", VA = "0x18237CC40")]
			public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, ref CHMOMJKILCA.LLJKHGGOCND DJNNMIKDINL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0x237CD70", Offset = "0x237B970", VA = "0x18237CD70")]
			public void NKMFOFOBAPA(UpdateConnectableVisuals BGEDHHBKNNK, ref IOPMFFNEOGH DDKABHBJHOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x237C8E0", Offset = "0x237B4E0", VA = "0x18237C8E0")]
			public unsafe static void DPLLDFFOLDG(ArchetypeChunkIterator* IGAACBAHKGC, void* PFDJCNBMCPN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct ANMGIJMEGJD : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200009F")]
			private struct OIIBPJGJEOE
			{
				[Cpp2IlInjected.Token(Token = "0x20000A0")]
				[NoAlias]
				public struct JPACNPEHLDM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400020D")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime JHECEPKENCE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400020E")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<APAFMJDJPNK>.Runtime GNBDEGCGMCP;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400020B")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> OKDKIKODBGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<APAFMJDJPNK> LADENDNMAMK;

				[Cpp2IlInjected.Token(Token = "0x6000581")]
				[Cpp2IlInjected.Address(RVA = "0x237DCB0", Offset = "0x237C8B0", VA = "0x18237DCB0")]
				public void NKMFOFOBAPA(UpdateConnectableVisuals BGEDHHBKNNK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000582")]
				[Cpp2IlInjected.Address(RVA = "0x237DC10", Offset = "0x237C810", VA = "0x18237DC10")]
				public JPACNPEHLDM AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
				{
					return default(JPACNPEHLDM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public NativeList<BPHNKPMGGPN> FPPBJGHNMLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private OIIBPJGJEOE CGENFBJNHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe OIIBPJGJEOE.JPACNPEHLDM* ADICLHDIIDC;

			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0x2379E10", Offset = "0x2378A10", VA = "0x182379E10")]
			internal void KDPNCNEOCOC(in WorldPoseData PILBCDGLPCJ, in DynamicBuffer<APAFMJDJPNK> IADJLOGDJJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x23714A0", Offset = "0x23700A0", VA = "0x1823714A0", Slot = "5")]
			public void ReadFromDisplayClass(ref CLJHPEEMMEF DDKABHBJHOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x2379D40", Offset = "0x2378940", VA = "0x182379D40", Slot = "4")]
			public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x2379F10", Offset = "0x2378B10", VA = "0x182379F10")]
			public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, [NoAlias] ref OIIBPJGJEOE.JPACNPEHLDM DJNNMIKDINL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x2379FD0", Offset = "0x2378BD0", VA = "0x182379FD0")]
			public void NKMFOFOBAPA(UpdateConnectableVisuals BGEDHHBKNNK, ref CLJHPEEMMEF DDKABHBJHOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct MKABBMPILIE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			private struct NHGAALDGMHC
			{
				[Cpp2IlInjected.Token(Token = "0x20000A3")]
				[NoAlias]
				public struct KCLIPBDCAMN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000215")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime JHECEPKENCE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000216")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<CEJJHCLKOFC>.Runtime MBDHADFLLCO;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000217")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<APAFMJDJPNK>.Runtime GNBDEGCGMCP;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000212")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> OKDKIKODBGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000213")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<CEJJHCLKOFC> ABDPDFOBLFN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000214")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<APAFMJDJPNK> LADENDNMAMK;

				[Cpp2IlInjected.Token(Token = "0x6000588")]
				[Cpp2IlInjected.Address(RVA = "0x58502E0", Offset = "0x584EEE0", VA = "0x1858502E0")]
				public void NKMFOFOBAPA(UpdateConnectableVisuals BGEDHHBKNNK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000589")]
				[Cpp2IlInjected.Address(RVA = "0x5850230", Offset = "0x584EE30", VA = "0x185850230")]
				public KCLIPBDCAMN AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
				{
					return default(KCLIPBDCAMN);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public NativeList<BPHNKPMGGPN> FPPBJGHNMLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private NHGAALDGMHC CGENFBJNHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NHGAALDGMHC.KCLIPBDCAMN* ADICLHDIIDC;

			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x237D6E0", Offset = "0x237C2E0", VA = "0x18237D6E0")]
			internal void KDPNCNEOCOC(in WorldPoseData PILBCDGLPCJ, in CEJJHCLKOFC NDALILHELLI, in DynamicBuffer<APAFMJDJPNK> IADJLOGDJJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x23714A0", Offset = "0x23700A0", VA = "0x1823714A0", Slot = "5")]
			public void ReadFromDisplayClass(ref HMHKKJCHEIP DDKABHBJHOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x237D650", Offset = "0x237C250", VA = "0x18237D650", Slot = "4")]
			public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x237D830", Offset = "0x237C430", VA = "0x18237D830")]
			public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, [NoAlias] ref NHGAALDGMHC.KCLIPBDCAMN DJNNMIKDINL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x237D920", Offset = "0x237C520", VA = "0x18237D920")]
			public void NKMFOFOBAPA(UpdateConnectableVisuals BGEDHHBKNNK, ref HMHKKJCHEIP DDKABHBJHOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private EntityQuery EALDNGFLJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private EntityQuery DLFHFGNEBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private EntityQuery CCEDMMLBOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private EntityQuery LBLPHEHFJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private EntityQuery KBMEOEIGDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private EntityQuery KLOMIIDIBAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private EntityQuery CPPLBKLEGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private EntityQuery ECFLAGFOIKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private EntityQuery NEGFPNNMPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private global::LMBOEJIDHPD<DFFMNBPBBBC, KEMNBMLDFFK> OPODPOMGNOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private DDKELKICOBG IEEOMFDNJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private PNPPGDJCNCL LCAGHKIOCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private JFDNCMBCKCA LOPBOOCOLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private EntityQuery HNJFCJFPJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private ProfilerMarker DNHMAFJJAFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private EntityQuery BMDJLGBCACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private EntityQuery DOHPMDLAGCD;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public int NGNMMFPKHGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0x238E020", Offset = "0x238CC20", VA = "0x18238E020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x238ED70", Offset = "0x238D970", VA = "0x18238ED70")]
		internal KEMNBMLDFFK PEMOOEEOHCN(DFFMNBPBBBC CGGCCCAGOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x238E0E0", Offset = "0x238CCE0", VA = "0x18238E0E0", Slot = "14")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x238EBA0", Offset = "0x238D7A0", VA = "0x18238EBA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x238E9D0", Offset = "0x238D5D0", VA = "0x18238E9D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x238C020", Offset = "0x238AC20", VA = "0x18238C020")]
		private void FDDOOFCGFFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x238EC70", Offset = "0x238D870", VA = "0x18238EC70")]
		private void PEBLGEBABCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x238BCF0", Offset = "0x238A8F0", VA = "0x18238BCF0")]
		private void EHGEGCIKFEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x238EBE0", Offset = "0x238D7E0", VA = "0x18238EBE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x238D5E0", Offset = "0x238C1E0", VA = "0x18238D5E0")]
		private void KLCBFOGAMFB(EntityQuery AINMGNPBCJD, EntityQuery NOPENHLDKKL, EntityQuery IMMAAOMKPAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x238B7A0", Offset = "0x238A3A0", VA = "0x18238B7A0")]
		private void DJAKFDPAFHF(global::AMBNDEDFEAL<Entity> IJBONIBDNAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x238B350", Offset = "0x2389F50", VA = "0x18238B350")]
		private void AMDGLCDMEGJ(global::AMBNDEDFEAL<Entity> MFDAAFFHANP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x238EDC0", Offset = "0x238D9C0", VA = "0x18238EDC0")]
		private void PNILGMAPPBG(global::AMBNDEDFEAL<Entity> HLKHAIOBBDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x238B660", Offset = "0x238A260", VA = "0x18238B660")]
		private void DFNGFOADEMC(NativeList<DFFMNBPBBBC> KOEHMBMGMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x238C440", Offset = "0x238B040", VA = "0x18238C440")]
		private NativeList<DFFMNBPBBBC> GIKNFADOHJA(NativeArray<Entity> MJFGMCFCBDM)
		{
			return default(NativeList<DFFMNBPBBBC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x238CEB0", Offset = "0x238BAB0", VA = "0x18238CEB0")]
		private void KCNINEMOAKF(NativeArray<Entity> MJFGMCFCBDM, NativeList<DFFMNBPBBBC> KOEHMBMGMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x238E290", Offset = "0x238CE90", VA = "0x18238E290")]
		private void ONKOHJGCCGE(NativeArray<Entity> NAGHBFEDKJI, NativeArray<Entity> JIABIKNDGJF, NativeList<DFFMNBPBBBC> FGHPEPNEAHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x238D9B0", Offset = "0x238C5B0", VA = "0x18238D9B0")]
		private void NHJDDMAPNDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x238EEE0", Offset = "0x238DAE0", VA = "0x18238EEE0")]
		private global::EOLIJDAIKKF<BPHNKPMGGPN> PNNHGJJEONN(EntityQuery LJHHKNNHAFE, Func<NativeList<BPHNKPMGGPN>, JobHandle> FOALCICLKLP)
		{
			return default(global::EOLIJDAIKKF<BPHNKPMGGPN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x238C100", Offset = "0x238AD00", VA = "0x18238C100")]
		private JobHandle FFNEEDKFJIB(NativeList<BPHNKPMGGPN> FPPBJGHNMLI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x238BBD0", Offset = "0x238A7D0", VA = "0x18238BBD0")]
		private JobHandle DOFFKIGDFFA(NativeList<BPHNKPMGGPN> FPPBJGHNMLI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x238CAD0", Offset = "0x238B6D0", VA = "0x18238CAD0")]
		private JobHandle JFJKHFMDMLC(NativeList<BPHNKPMGGPN> FPPBJGHNMLI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x238B450", Offset = "0x238A050", VA = "0x18238B450")]
		private void DADIFICHDJF(global::EOLIJDAIKKF<BPHNKPMGGPN> FPPBJGHNMLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x238C8C0", Offset = "0x238B4C0", VA = "0x18238C8C0")]
		private void HPDGNGBOMPB(global::EOLIJDAIKKF<BPHNKPMGGPN> FPPBJGHNMLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x238B3E0", Offset = "0x2389FE0", VA = "0x18238B3E0")]
		private bool CKFHECNJGLD(Entity OCMABEPCGDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x238CC10", Offset = "0x238B810", VA = "0x18238CC10")]
		private NativeArray<Entity> JGGLAFIPDDF(Entity OCMABEPCGDM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x238C2D0", Offset = "0x238AED0", VA = "0x18238C2D0")]
		private DFFMNBPBBBC GFJDJGKMFOP(NativeList<DFFMNBPBBBC> FGHPEPNEAHJ)
		{
			return default(DFFMNBPBBBC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x238E060", Offset = "0x238CC60", VA = "0x18238E060")]
		private void OFNMDJHFNCD(DFFMNBPBBBC CGGCCCAGOLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x238E8B0", Offset = "0x238D4B0", VA = "0x18238E8B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x238CCE0", Offset = "0x238B8E0", VA = "0x18238CCE0")]
		public static EntityQuery KCNHALIMMIJ(ComponentSystemBase BGEDHHBKNNK)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x238B9A0", Offset = "0x238A5A0", VA = "0x18238B9A0")]
		public static EntityQuery DMHPODDOMOP(ComponentSystemBase BGEDHHBKNNK)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x238D3B0", Offset = "0x238BFB0", VA = "0x18238D3B0")]
		public static EntityQuery KFDBLHGNEFL(ComponentSystemBase BGEDHHBKNNK)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class DCKCKPBOMKE : GDMMHGMPDDN, HKFIKAGKAAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private EntityQuery HBFEINKAKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private JDDPPIAFHCO NOMIILNDOJF;

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2634960", Offset = "0x2633560", VA = "0x182634960", Slot = "14")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x26349B0", Offset = "0x26335B0", VA = "0x1826349B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2634A50", Offset = "0x2633650", VA = "0x182634A50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x26346F0", Offset = "0x26332F0", VA = "0x1826346F0")]
	protected void FCKJKGCKFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x312E420", Offset = "0x312D020", VA = "0x18312E420")]
	private bool ENBOJMKBIPB<TComponentData>(EntityQuery LJHHKNNHAFE, out NativeArray<Entity> MJFGMCFCBDM, out NativeArray<TComponentData> PDBANHEHPOA) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x2634A60", Offset = "0x2633660", VA = "0x182634A60")]
	public DCFEMLAEOED POOFLDHFAFP(Entity OCMABEPCGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public DCKCKPBOMKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(SimulationSystemGroup))]
public class FOAAHDFBEPL : GDMMHGMPDDN, HKFIKAGKAAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private ObjectEmbodimentService EDAMELHACNP;

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x2366180", Offset = "0x2364D80", VA = "0x182366180", Slot = "14")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x23661E0", Offset = "0x2364DE0", VA = "0x1823661E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2366210", Offset = "0x2364E10", VA = "0x182366210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public FOAAHDFBEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class AOJCKCOKMFP : GDMMHGMPDDN, HKFIKAGKAAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private EntityQuery MIMPMMOPFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private EntityQuery BLKEKGKONCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private EntityQuery PCIFFJIJNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private EntityQuery EIBKFDCENLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private ObjectEmbodimentService AEDAMJMNKLH;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public int LOFNLMCKNKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x2631A10", Offset = "0x2630610", VA = "0x182631A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int MBIGNBJABEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x2631920", Offset = "0x2630520", VA = "0x182631920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2631A20", Offset = "0x2630620", VA = "0x182631A20", Slot = "14")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2631A80", Offset = "0x2630680", VA = "0x182631A80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2631C30", Offset = "0x2630830", VA = "0x182631C30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2631680", Offset = "0x2630280", VA = "0x182631680")]
	protected void FHFGPJNFOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2631240", Offset = "0x262FE40", VA = "0x182631240")]
	protected void AJDCGIFGBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2631590", Offset = "0x2630190", VA = "0x182631590")]
	private bool ENBOJMKBIPB(EntityQuery LJHHKNNHAFE, out NativeArray<Entity> MJFGMCFCBDM, out NativeArray<CBABPMMCIBA> CPMPJGKLBAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x2631CD0", Offset = "0x26308D0", VA = "0x182631CD0")]
	public global::AMBNDEDFEAL<Entity> PPPMCELNBLH(Allocator HGKGLCNFHPJ)
	{
		return default(global::AMBNDEDFEAL<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x26314C0", Offset = "0x26300C0", VA = "0x1826314C0")]
	public global::AMBNDEDFEAL<Entity> DCFNHNHHIIH(Allocator HGKGLCNFHPJ)
	{
		return default(global::AMBNDEDFEAL<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x2631500", Offset = "0x2630100", VA = "0x182631500")]
	public bool EFBBCFKKKEJ(Allocator HGKGLCNFHPJ, out global::AMBNDEDFEAL<Entity> MPHBIKLMOEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x26318B0", Offset = "0x26304B0", VA = "0x1826318B0")]
	public bool IHHKOCLPKGP(Entity OCMABEPCGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x2631C50", Offset = "0x2630850", VA = "0x182631C50")]
	public DCFEMLAEOED POOFLDHFAFP(Entity OCMABEPCGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x2631930", Offset = "0x2630530", VA = "0x182631930")]
	public bool JIJGEKFIGAG(Entity OCMABEPCGDM, out EANCAPJPPOK MPHBIKLMOEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x2631470", Offset = "0x2630070", VA = "0x182631470")]
	public void DCBKIHBLIBK(Entity OCMABEPCGDM, EANCAPJPPOK MPHBIKLMOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x26319A0", Offset = "0x26305A0", VA = "0x1826319A0")]
	public bool MCCLGKCJKBJ(Entity OCMABEPCGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public AOJCKCOKMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class EANCAPJPPOK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public DCFEMLAEOED MPHBIKLMOEK;

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public EANCAPJPPOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x721660", Offset = "0x720260", VA = "0x180721660")]
	public EANCAPJPPOK(DCFEMLAEOED MPHBIKLMOEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(GMNHNGCMLMH))]
public class HEHHEMBLIII : GDMMHGMPDDN
{
	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public HEHHEMBLIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public abstract class ANJIEMLBMFE : GDMMHGMPDDN, HKFIKAGKAAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private MEPFJBJLAPB PAKABGINJPL;

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x2630F00", Offset = "0x262FB00", VA = "0x182630F00", Slot = "14")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2630F60", Offset = "0x262FB60", VA = "0x182630F60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	protected ANJIEMLBMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class EFMFFJKGLOM : GDMMHGMPDDN, GEPKKGPMACB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct NDMNMFNENJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public NativeList<AEKCLLLDNHE> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public NativeList<JJNFBNLEEON> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public NativeList<AEKCLLLDNHE> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		public NDMNMFNENJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, GNFHMKOLIFD previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
		internal void <OnUpdate>b__2(Entity entity, GNFHMKOLIFD previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HCLNKDCFBOL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		private struct CAHJBCMNAII
		{
			[Cpp2IlInjected.Token(Token = "0x20000AE")]
			[NoAlias]
			public struct NMCNGNNFDDA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400022E")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime NDGPFFGEEJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400022F")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime LLCHJOJLDJD;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity BPCAGDMEHOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> NAHMJFNKDMA;

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x2633DA0", Offset = "0x26329A0", VA = "0x182633DA0")]
			public void NKMFOFOBAPA(EFMFFJKGLOM BGEDHHBKNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x2633D20", Offset = "0x2632920", VA = "0x182633D20")]
			public NMCNGNNFDDA AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
			{
				return default(NMCNGNNFDDA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public NativeList<AEKCLLLDNHE> MIDPDMFFNLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private CAHJBCMNAII CGENFBJNHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe CAHJBCMNAII.NMCNGNNFDDA* ADICLHDIIDC;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x263C210", Offset = "0x263AE10", VA = "0x18263C210")]
		internal void KDPNCNEOCOC(Entity OCMABEPCGDM, ParentData NHILDHCHLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x23714A0", Offset = "0x23700A0", VA = "0x1823714A0", Slot = "5")]
		public void ReadFromDisplayClass(ref NDMNMFNENJP DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x263C170", Offset = "0x263AD70", VA = "0x18263C170", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x263C280", Offset = "0x263AE80", VA = "0x18263C280")]
		public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, [NoAlias] ref CAHJBCMNAII.NMCNGNNFDDA DJNNMIKDINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x263C330", Offset = "0x263AF30", VA = "0x18263C330")]
		public void NKMFOFOBAPA(EFMFFJKGLOM BGEDHHBKNNK, ref NDMNMFNENJP DDKABHBJHOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct JKIGLNJBACO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		private struct JBJNMHFFCEO
		{
			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[NoAlias]
			public struct LGAHIOOADPA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime NDGPFFGEEJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime LLCHJOJLDJD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<GNFHMKOLIFD>.Runtime INPDAKGHGNF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity BPCAGDMEHOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> NAHMJFNKDMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<GNFHMKOLIFD> KFLBLAAGEAB;

			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x263D390", Offset = "0x263BF90", VA = "0x18263D390")]
			public void NKMFOFOBAPA(EFMFFJKGLOM BGEDHHBKNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x263D2F0", Offset = "0x263BEF0", VA = "0x18263D2F0")]
			public LGAHIOOADPA AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
			{
				return default(LGAHIOOADPA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public NativeList<JJNFBNLEEON> NEIIHGAIMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private JBJNMHFFCEO CGENFBJNHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JBJNMHFFCEO.LGAHIOOADPA* ADICLHDIIDC;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x263D570", Offset = "0x263C170", VA = "0x18263D570")]
		internal void KDPNCNEOCOC(Entity OCMABEPCGDM, ParentData NHILDHCHLPL, GNFHMKOLIFD IJHKBBAPBME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x263D740", Offset = "0x263C340", VA = "0x18263D740", Slot = "5")]
		public void ReadFromDisplayClass(ref NDMNMFNENJP DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x263D4A0", Offset = "0x263C0A0", VA = "0x18263D4A0", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x263D630", Offset = "0x263C230", VA = "0x18263D630")]
		public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, [NoAlias] ref JBJNMHFFCEO.LGAHIOOADPA DJNNMIKDINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x263D700", Offset = "0x263C300", VA = "0x18263D700")]
		public void NKMFOFOBAPA(EFMFFJKGLOM BGEDHHBKNNK, ref NDMNMFNENJP DDKABHBJHOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct GIBJFAFKBLI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		private struct NGMICFIPKJB
		{
			[Cpp2IlInjected.Token(Token = "0x20000B4")]
			[NoAlias]
			public struct OMBJDJHHBDC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023E")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime NDGPFFGEEJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400023F")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<GNFHMKOLIFD>.Runtime INPDAKGHGNF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity BPCAGDMEHOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<GNFHMKOLIFD> KFLBLAAGEAB;

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x263D7D0", Offset = "0x263C3D0", VA = "0x18263D7D0")]
			public void NKMFOFOBAPA(EFMFFJKGLOM BGEDHHBKNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x263D750", Offset = "0x263C350", VA = "0x18263D750")]
			public OMBJDJHHBDC AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
			{
				return default(OMBJDJHHBDC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public NativeList<AEKCLLLDNHE> LHFPBGAOCDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private NGMICFIPKJB CGENFBJNHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NGMICFIPKJB.OMBJDJHHBDC* ADICLHDIIDC;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x263BFB0", Offset = "0x263ABB0", VA = "0x18263BFB0")]
		internal void KDPNCNEOCOC(Entity OCMABEPCGDM, GNFHMKOLIFD IJHKBBAPBME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x263C160", Offset = "0x263AD60", VA = "0x18263C160", Slot = "5")]
		public void ReadFromDisplayClass(ref NDMNMFNENJP DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x263BF10", Offset = "0x263AB10", VA = "0x18263BF10", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x263C020", Offset = "0x263AC20", VA = "0x18263C020")]
		public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, [NoAlias] ref NGMICFIPKJB.OMBJDJHHBDC DJNNMIKDINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x263C0D0", Offset = "0x263ACD0", VA = "0x18263C0D0")]
		public void NKMFOFOBAPA(EFMFFJKGLOM BGEDHHBKNNK, ref NDMNMFNENJP DDKABHBJHOE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private ACAEIGFMODO FACCEJKKEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private EntityQuery AKNJHPKJDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private EntityQuery HOOOEFMFGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private EntityQuery DACJEKKAGOG;

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x2636FB0", Offset = "0x2635BB0", VA = "0x182636FB0", Slot = "14")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x2637080", Offset = "0x2635C80", VA = "0x182637080", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public EFMFFJKGLOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x2634010", Offset = "0x2632C10", VA = "0x182634010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2636B80", Offset = "0x2635780", VA = "0x182636B80")]
	public static EntityQuery GOFKPJKJBGO(ComponentSystemBase BGEDHHBKNNK)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x2636DB0", Offset = "0x26359B0", VA = "0x182636DB0")]
	public static EntityQuery KFLEFGNFNCH(ComponentSystemBase BGEDHHBKNNK)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x26369C0", Offset = "0x26355C0", VA = "0x1826369C0")]
	public static EntityQuery ENMDLGALLDK(ComponentSystemBase BGEDHHBKNNK)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class GAKMKIPJOAF : global::JGAPEKEIJCF<ParentData, GNFHMKOLIFD, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x23662C0", Offset = "0x2364EC0", VA = "0x1823662C0", Slot = "14")]
	protected override EntityQueryDesc NHIHKCEDDDE(EntityQueryDesc LJHHKNNHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x787EA0", Offset = "0x786AA0", VA = "0x180787EA0", Slot = "15")]
	protected override EntityQueryDesc MPPDGHENJEO(EntityQueryDesc LJHHKNNHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x2366240", Offset = "0x2364E40", VA = "0x182366240", Slot = "16")]
	protected override EntityQueryDesc BDJBLIGEKGG(EntityQueryDesc LJHHKNNHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x2366280", Offset = "0x2364E80", VA = "0x182366280", Slot = "17")]
	protected override EntityQueryDesc IPLJBDPMAMA(EntityQueryDesc LJHHKNNHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x2366340", Offset = "0x2364F40", VA = "0x182366340")]
	public GAKMKIPJOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x2366300", Offset = "0x2364F00", VA = "0x182366300", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public abstract class JGAPEKEIJCF<ParentData, PreviousParentData, ChildrenData> : NPPAKIFENEO where ParentData : struct, IComponentData, LDFMEFPABAI where PreviousParentData : struct, IComponentData, LDFMEFPABAI where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, LDFMEFPABAI
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[BurstCompile]
	private struct BEOKCHINIKI : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public NativeMultiHashMap<Entity, Entity>.ParallelWriter LLBGMBAKIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public NativeMultiHashMap<Entity, Entity>.ParallelWriter IAKMGMMBIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public NativeHashMap<Entity, int>.ParallelWriter EIJPGOPEDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public ArchetypeChunkComponentType<PreviousParentData> OIJIKHKPLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		[ReadOnly]
		public ArchetypeChunkComponentType<ParentData> LBDJGOKAOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		[ReadOnly]
		public ArchetypeChunkEntityType EHMHMMCAJDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public uint CNBOOFGEIHA;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x3EBE940", Offset = "0x3EBD540", VA = "0x183EBE940", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[BurstCompile]
	private struct BNKBGJAPKKM : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		[ReadOnly]
		public NativeHashMap<Entity, int> EIJPGOPEDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> BJABDNNHFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public NativeList<Entity> BODAHODBLHD;

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x3EBEDA0", Offset = "0x3EBD9A0", VA = "0x183EBEDA0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[BurstCompile]
	private struct KPGHBGFNNBD : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		[ReadOnly]
		public NativeMultiHashMap<Entity, Entity> LLBGMBAKIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		[ReadOnly]
		public NativeMultiHashMap<Entity, Entity> IAKMGMMBIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		[ReadOnly]
		public NativeHashMap<Entity, int> EIJPGOPEDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public BufferFromEntity<ChildrenData> BJABDNNHFNH;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2920", Offset = "0x3ED1520", VA = "0x183ED2920")]
		private int APLCMHKPKAE(DynamicBuffer<ChildrenData> HIGOGPMFHCJ, Entity OCMABEPCGDM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2C70", Offset = "0x3ED1870", VA = "0x183ED2C70")]
		private void BDMKPOEHMIG(Entity MKOLBPGKLJP, DynamicBuffer<ChildrenData> HIGOGPMFHCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3210", Offset = "0x3ED1E10", VA = "0x183ED3210")]
		private void GLKGCELELIE(Entity MKOLBPGKLJP, DynamicBuffer<ChildrenData> HIGOGPMFHCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2DC0", Offset = "0x3ED19C0", VA = "0x183ED2DC0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[BurstCompile]
	private struct MEDFKAJHBNJ : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public NativeArray<Entity> JIHFLADBGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public NativeList<Entity> KKHMGMKNEKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public BufferFromEntity<ChildrenData> BJABDNNHFNH;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x3ED34A0", Offset = "0x3ED20A0", VA = "0x183ED34A0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	protected EntityQuery BFDNNOMFJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	protected EntityQuery KEHPCDAFGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected EntityQuery FDHGMEPIEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected EntityQuery PADOICNEKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	protected ProfilerMarker LKEKKAABKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	protected ProfilerMarker JOOKNGBNHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	protected ProfilerMarker HJKPDGNEBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	protected ProfilerMarker DHLAENMBEMA;

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x3EC4770", Offset = "0x3EC3370", VA = "0x183EC4770")]
	public JGAPEKEIJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2A50", Offset = "0x3EC1650", VA = "0x183EC2A50")]
	private int APLCMHKPKAE(DynamicBuffer<ChildrenData> HIGOGPMFHCJ, Entity OCMABEPCGDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2770", Offset = "0x3EC1370", VA = "0x183EC2770")]
	private void AONBPJPPPOK(Entity NEACNGKJCME, Entity APKFECLPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x787EA0", Offset = "0x786AA0", VA = "0x180787EA0", Slot = "14")]
	protected virtual EntityQueryDesc NHIHKCEDDDE(EntityQueryDesc LJHHKNNHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x787EA0", Offset = "0x786AA0", VA = "0x180787EA0", Slot = "15")]
	protected virtual EntityQueryDesc MPPDGHENJEO(EntityQueryDesc LJHHKNNHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x787EA0", Offset = "0x786AA0", VA = "0x180787EA0", Slot = "16")]
	protected virtual EntityQueryDesc BDJBLIGEKGG(EntityQueryDesc LJHHKNNHAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	protected abstract EntityQueryDesc IPLJBDPMAMA(EntityQueryDesc LJHHKNNHAFE);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x3EC4170", Offset = "0x3EC2D70", VA = "0x183EC4170", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x3EC36A0", Offset = "0x3EC22A0", VA = "0x183EC36A0")]
	private void FIDIIKIILFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3FB0", Offset = "0x3EC2BB0", VA = "0x183EC3FB0")]
	private void NBEDEDLPNOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2C50", Offset = "0x3EC1850", VA = "0x183EC2C50")]
	private void BCGODLFDEIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3790", Offset = "0x3EC2390", VA = "0x183EC3790")]
	private void IHKEGBNAGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x3EC46B0", Offset = "0x3EC32B0", VA = "0x183EC46B0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle AKMHODPNCMG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x3C1EAA0", Offset = "0x3C1D6A0", VA = "0x183C1EAA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[AlwaysUpdateSystem]
	[GOMFNBMFGBH(ELBDNIJMKBJ.RenderEffects)]
	public abstract class PropagateTagsBase<TRootTag, TDescendantTag, TRootSystemTag> : GDMMHGMPDDN, GEPKKGPMACB where TRootTag : struct, IComponentData where TDescendantTag : struct, IComponentData where TRootSystemTag : struct, ISystemStateComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		private struct ELPJNKPKHNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public global::EOLIJDAIKKF<Entity> DGGHIBBAINF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public global::EOLIJDAIKKF<Entity> BBNCADHJHGO;

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x3CEC1D0", Offset = "0x3CEADD0", VA = "0x183CEC1D0")]
			public ELPJNKPKHNO(NativeList<Entity> DGGHIBBAINF, NativeList<Entity> BBNCADHJHGO, JobHandle NKBLFABEMGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x3CEC150", Offset = "0x3CEAD50", VA = "0x183CEC150")]
			public JobHandle DAKEMNBEBJK(JobHandle LIOENDEGGJH)
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x3CEBF60", Offset = "0x3CEAB60", VA = "0x183CEBF60")]
			public void BMILBDCJANP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[BurstCompile]
		private struct MPHHIKGILGH : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20000BE")]
			[Flags]
			public enum HMPEBLMBFNA
			{
				[Cpp2IlInjected.Token(Token = "0x400026A")]
				ReadParentFromArray = 1,
				[Cpp2IlInjected.Token(Token = "0x400026B")]
				FetchParentFromEntity = 2,
				[Cpp2IlInjected.Token(Token = "0x400026C")]
				AncestorTagValue = 4,
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				ConstNoAncestorTag = 0,
				[Cpp2IlInjected.Token(Token = "0x400026E")]
				ConstHasAncestorTag = 4
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			[WriteOnly]
			public NativeList<Entity> GOAHFEJJOIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			[WriteOnly]
			public NativeList<Entity> NHKBMKNKHBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			[ReadOnly]
			public NativeArray<Entity> BCBMILDEKDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> BPCFEBIHNPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			[ReadOnly]
			public ComponentDataFromEntity<TRootTag> FJHMNABEJLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			[ReadOnly]
			public ComponentDataFromEntity<TDescendantTag> KCJGKCIECGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			[ReadOnly]
			public ComponentDataFromEntity<ParentData> JEEPGJHEKAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000266")]
			public int MOBFANIGNAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public int MNHOEMKPFNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private HMPEBLMBFNA AOLCNLDKEPF;

			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x3CF28B0", Offset = "0x3CF14B0", VA = "0x183CF28B0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x3CF2E80", Offset = "0x3CF1A80", VA = "0x183CF2E80")]
			private void KIFEKFJGEAO(Entity OCMABEPCGDM, bool JBCBFFBCAKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x3CF37C0", Offset = "0x3CF23C0", VA = "0x183CF37C0")]
			private void ODPMEDLHJLK(Entity OCMABEPCGDM, bool JBCBFFBCAKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x3CF2BE0", Offset = "0x3CF17E0", VA = "0x183CF2BE0")]
			public ELPJNKPKHNO ILNOLJNAJHP(NativeArray<Entity> FBGPEJDOHHH, JobHandle LIOENDEGGJH)
			{
				return default(ELPJNKPKHNO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x3CF33C0", Offset = "0x3CF1FC0", VA = "0x183CF33C0")]
			public ELPJNKPKHNO NMHNDCMHBDD(NativeArray<Entity> FBGPEJDOHHH, JobHandle LIOENDEGGJH)
			{
				return default(ELPJNKPKHNO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x3CF3040", Offset = "0x3CF1C40", VA = "0x183CF3040")]
			public ELPJNKPKHNO NKKDHGHLBMC(NativeList<AEKCLLLDNHE> FPPBJGHNMLI, JobHandle LIOENDEGGJH)
			{
				return default(ELPJNKPKHNO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x3CF1ED0", Offset = "0x3CF0AD0", VA = "0x183CF1ED0")]
			public ELPJNKPKHNO DCJJNHIOIMF(NativeList<AEKCLLLDNHE> FPPBJGHNMLI, JobHandle LIOENDEGGJH)
			{
				return default(ELPJNKPKHNO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x3CF2170", Offset = "0x3CF0D70", VA = "0x183CF2170")]
			public ELPJNKPKHNO EEDMEFNAFCL(NativeList<JJNFBNLEEON> FPPBJGHNMLI, JobHandle LIOENDEGGJH)
			{
				return default(ELPJNKPKHNO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x3135110", Offset = "0x3133D10", VA = "0x183135110")]
			private ELPJNKPKHNO PPFEHFFDMOI<T>(NativeList<T> FPPBJGHNMLI, int BCODJBPHPMJ, int MEBNPOBHMAP, HMPEBLMBFNA FALFKKIACAA, JobHandle LIOENDEGGJH) where T : struct
			{
				return default(ELPJNKPKHNO);
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x3CF38E0", Offset = "0x3CF24E0", VA = "0x183CF38E0")]
			private ELPJNKPKHNO PPFEHFFDMOI(NativeArray<Entity> MJFGMCFCBDM, int BCODJBPHPMJ, int MEBNPOBHMAP, HMPEBLMBFNA FALFKKIACAA, JobHandle LIOENDEGGJH)
			{
				return default(ELPJNKPKHNO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private EntityQuery PJGCBIIKMFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private EntityQuery DFIHIDIHGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private ACAEIGFMODO JLPEPGBNBEM;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4A20", Offset = "0x3CF3620", VA = "0x183CF4A20", Slot = "14")]
		public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4D20", Offset = "0x3CF3920", VA = "0x183CF4D20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x3CF6820", Offset = "0x3CF5420", VA = "0x183CF6820", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7490", Offset = "0x3CF6090", VA = "0x183CF7490")]
		private void PDDBNLHFACA(NativeArray<Entity> FPPBJGHNMLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x3CF48E0", Offset = "0x3CF34E0", VA = "0x183CF48E0")]
		private void KADNGBBKJEE(NativeArray<Entity> FPPBJGHNMLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4280", Offset = "0x3CF2E80", VA = "0x183CF4280")]
		private void BCPKEHBCENA(ELPJNKPKHNO JIGLLMBBOFN, string PMIEAEPDHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x3CF43D0", Offset = "0x3CF2FD0", VA = "0x183CF43D0")]
		private void BCPKEHBCENA(global::EOLIJDAIKKF<Entity> PBHHCFGEDBL, string PMIEAEPDHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x3CF46A0", Offset = "0x3CF32A0", VA = "0x183CF46A0")]
		private void HOBECDMCGJL(ELPJNKPKHNO JIGLLMBBOFN, string PMIEAEPDHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x3CF45B0", Offset = "0x3CF31B0", VA = "0x183CF45B0")]
		private void HOBECDMCGJL(global::EOLIJDAIKKF<Entity> PBHHCFGEDBL, string PMIEAEPDHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4BC0", Offset = "0x3CF37C0", VA = "0x183CF4BC0")]
		private bool NMHKJPHLJJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7570", Offset = "0x3CF6170", VA = "0x183CF7570")]
		protected PropagateTagsBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x3C1EAA0", Offset = "0x3C1D6A0", VA = "0x183C1EAA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct DMENKOJAMJB : ISystemStateComponentData, IComponentData, IEquatable<DMENKOJAMJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public float3 GAJDGCKODFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public float3 BPNNOLFAMPN;

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x2634DE0", Offset = "0x26339E0", VA = "0x182634DE0", Slot = "4")]
	public bool Equals(DMENKOJAMJB NPKIIGGBCCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class OCEDNPMDBBC : GDMMHGMPDDN, HKFIKAGKAAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct HBBPBPNECBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public OCEDNPMDBBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		public HBBPBPNECBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct KCACOBOCJLM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		private struct KGMNCBHIHAM
		{
			[Cpp2IlInjected.Token(Token = "0x20000C4")]
			public struct ALGHJBJAMPC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027D")]
				public LambdaParameterValueProvider_Entity.Runtime OEIHJHIFKJC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity BELCOJINABM;

			[Cpp2IlInjected.Token(Token = "0x6000617")]
			[Cpp2IlInjected.Address(RVA = "0x26B3260", Offset = "0x26B1E60", VA = "0x1826B3260")]
			public void NKMFOFOBAPA(OCEDNPMDBBC BGEDHHBKNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x26B3250", Offset = "0x26B1E50", VA = "0x1826B3250")]
			public ALGHJBJAMPC AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
			{
				return default(ALGHJBJAMPC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public OCEDNPMDBBC INPGGNBGDDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public EntityCommandBuffer EJKOGNAICIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private KGMNCBHIHAM CGENFBJNHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KGMNCBHIHAM.ALGHJBJAMPC* ADICLHDIIDC;

		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KDFHADKIOEI;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x26B2EE0", Offset = "0x26B1AE0", VA = "0x1826B2EE0")]
		internal void KDPNCNEOCOC(Entity PKPFAHAEBCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x263DB70", Offset = "0x263C770", VA = "0x18263DB70", Slot = "5")]
		public void ReadFromDisplayClass(ref HBBPBPNECBK DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x263DBA0", Offset = "0x263C7A0", VA = "0x18263DBA0", Slot = "6")]
		public void WriteToDisplayClass(ref HBBPBPNECBK DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x26B2E80", Offset = "0x26B1A80", VA = "0x1826B2E80", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x26B2FE0", Offset = "0x26B1BE0", VA = "0x1826B2FE0")]
		public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, ref KGMNCBHIHAM.ALGHJBJAMPC DJNNMIKDINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x26B3050", Offset = "0x26B1C50", VA = "0x1826B3050")]
		public void NKMFOFOBAPA(OCEDNPMDBBC BGEDHHBKNNK, ref HBBPBPNECBK DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x26B2E20", Offset = "0x26B1A20", VA = "0x1826B2E20")]
		public unsafe static void DPLLDFFOLDG(ArchetypeChunkIterator* IGAACBAHKGC, void* PFDJCNBMCPN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private BJMLDLDMPNN BGPIABGOPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private LPLPHKHEJPF KHDJEFJLLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private EntityQuery BKPDLONDJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private ProfilerMarker APNAOHLFIHL;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x26B55C0", Offset = "0x26B41C0", VA = "0x1826B55C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x26B5360", Offset = "0x26B3F60", VA = "0x1826B5360", Slot = "14")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x26B5620", Offset = "0x26B4220", VA = "0x1826B5620", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public OCEDNPMDBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x26B53C0", Offset = "0x26B3FC0", VA = "0x1826B53C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x26B57A0", Offset = "0x26B43A0", VA = "0x1826B57A0")]
	public static EntityQuery PHIFAGDHPBB(ComponentSystemBase BGEDHHBKNNK)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public struct DENIMHKEFDN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public CMIGFMBEJGM CGGCCCAGOLF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0")]
	public static DENIMHKEFDN GOPIOOMOEDD(in CMIGFMBEJGM LFPGIJIPHPG)
	{
		return default(DENIMHKEFDN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C0FE0", VA = "0x1807C23E0")]
	public static CMIGFMBEJGM GOPIOOMOEDD(in DENIMHKEFDN EDOGHPDPGBD)
	{
		return default(CMIGFMBEJGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[MHBJLGEIMOG(typeof(LPLPHKHEJPF), new string[] { })]
public sealed class EBFCIENHKKK : LPLPHKHEJPF, HMECPPGNBDI, CCILBHCKADC, HKFIKAGKAAK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private const int ADHAAFMMCGA = -1;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private const int NPCOHNLLBCH = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private Collider[] KMCHIGAHBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private RaycastHit[] IPLDLNOANKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private global::LMBOEJIDHPD<CMIGFMBEJGM, BoxCollider> JPPONDDHEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private Scene CKMHEJALMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private PhysicsScene LJFGPEFBJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private GameObject PAMDOGALOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private LBMBOABFHDF KEEOMJACPKA;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int ANGBGINDADK
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2635460", Offset = "0x2634060", VA = "0x182635460", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x2636170", Offset = "0x2634D70", VA = "0x182636170", Slot = "10")]
	public void NGNFNBOGJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x2636360", Offset = "0x2634F60", VA = "0x182636360", Slot = "11")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x26355A0", Offset = "0x26341A0", VA = "0x1826355A0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x2635BC0", Offset = "0x26347C0", VA = "0x182635BC0", Slot = "5")]
	public CMIGFMBEJGM GHFCMNLGBOA(Entity OCMABEPCGDM)
	{
		return default(CMIGFMBEJGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x2635DA0", Offset = "0x26349A0", VA = "0x182635DA0", Slot = "6")]
	public void MFODHFCIAFH(NativeArray<CMIGFMBEJGM> CPMPJGKLBAD, NativeArray<DMENKOJAMJB> FLJOMBKKJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x26362C0", Offset = "0x2634EC0", VA = "0x1826362C0", Slot = "7")]
	public void ODBMOEGJFKI(CMIGFMBEJGM CGGCCCAGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x2635990", Offset = "0x2634590", VA = "0x182635990", Slot = "8")]
	public bool EFHDJNBFNEH(CMIGFMBEJGM CGGCCCAGOLF, out Collider PCJIIECCPGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x2635680", Offset = "0x2634280", VA = "0x182635680")]
	public bool ECOKJLMGFIF(in float3 OBECBBNHKAL, in float3 NIIKOIAOGAL, float EIJHLGKIBNG, Allocator HGKGLCNFHPJ, out NativeArray<Entity> MJFGMCFCBDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x2635400", Offset = "0x2634000", VA = "0x182635400")]
	private void BOAAAGHMKMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x8B2280", Offset = "0x8B0E80", VA = "0x1808B2280")]
	private void MLALHIEJCAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x2635D20", Offset = "0x2634920", VA = "0x182635D20")]
	private void HNFJCDJCBJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x9DB5D0", Offset = "0x9DA1D0", VA = "0x1809DB5D0")]
	private void KMCDKMEJBLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x26354A0", Offset = "0x26340A0", VA = "0x1826354A0")]
	private BoxCollider DAFBHCCNFEI(Entity OCMABEPCGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x2635290", Offset = "0x2633E90", VA = "0x182635290")]
	private void AOEFJJDGPLH(BoxCollider FMEPHKJGDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x2635CE0", Offset = "0x26348E0", VA = "0x182635CE0")]
	[Conditional("UNITY_EDITOR")]
	private void GIIOENFDFOL(GameObject MHECAANKLIB, Entity OCMABEPCGDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x2635A30", Offset = "0x2634630", VA = "0x182635A30")]
	private void ENALCPKNFID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x2635310", Offset = "0x2633F10", VA = "0x182635310")]
	private void BMKHHIPDMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x2635FA0", Offset = "0x2634BA0", VA = "0x182635FA0")]
	private void MLDBNIIMHHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x2635D70", Offset = "0x2634970", VA = "0x182635D70")]
	private void MDNGGEMHNEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x2635590", Offset = "0x2634190", VA = "0x182635590")]
	private void DDHHHLOIKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x2635B80", Offset = "0x2634780", VA = "0x182635B80")]
	private void EOGJKPIFJIK(Scene CMNHLHODPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public EBFCIENHKKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x2635450", Offset = "0x2634050", VA = "0x182635450", Slot = "9")]
	private bool CDNOJAOOLLJ(in float3 OBECBBNHKAL, in float3 NIIKOIAOGAL, float EIJHLGKIBNG, Allocator HGKGLCNFHPJ, out NativeArray<Entity> MJFGMCFCBDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class BJMLDLDMPNN : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0")]
	public BJMLDLDMPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class BCHEMIIFLDF : GDMMHGMPDDN, HKFIKAGKAAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct DOKJFIJGNDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public BCHEMIIFLDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		public DOKJFIJGNDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
		internal void <OnUpdate>b__0(Entity e, DENIMHKEFDN ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct NIJJGOGJPIE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		private struct IDHACJJECJH
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			public struct PBIMKIEOMGE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000295")]
				public LambdaParameterValueProvider_Entity.Runtime OEIHJHIFKJC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000296")]
				public LambdaParameterValueProvider_IComponentData<DENIMHKEFDN>.Runtime JFGPGHOKBDI;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity BELCOJINABM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<DENIMHKEFDN> EFOPLCEKALI;

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x263D060", Offset = "0x263BC60", VA = "0x18263D060")]
			public void NKMFOFOBAPA(BCHEMIIFLDF BGEDHHBKNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x263CFE0", Offset = "0x263BBE0", VA = "0x18263CFE0")]
			public PBIMKIEOMGE AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
			{
				return default(PBIMKIEOMGE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public BCHEMIIFLDF INPGGNBGDDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public EntityCommandBuffer EJKOGNAICIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private IDHACJJECJH CGENFBJNHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IDHACJJECJH.PBIMKIEOMGE* ADICLHDIIDC;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KDFHADKIOEI;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x263D930", Offset = "0x263C530", VA = "0x18263D930")]
		internal void KDPNCNEOCOC(Entity PKPFAHAEBCB, DENIMHKEFDN KNNACIMOECC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x263DB70", Offset = "0x263C770", VA = "0x18263DB70", Slot = "5")]
		public void ReadFromDisplayClass(ref DOKJFIJGNDD DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x263DBA0", Offset = "0x263C7A0", VA = "0x18263DBA0", Slot = "6")]
		public void WriteToDisplayClass(ref DOKJFIJGNDD DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x263D890", Offset = "0x263C490", VA = "0x18263D890", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x263DA30", Offset = "0x263C630", VA = "0x18263DA30")]
		public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, ref IDHACJJECJH.PBIMKIEOMGE DJNNMIKDINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x263DAE0", Offset = "0x263C6E0", VA = "0x18263DAE0")]
		public void NKMFOFOBAPA(BCHEMIIFLDF BGEDHHBKNNK, ref DOKJFIJGNDD DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x263D830", Offset = "0x263C430", VA = "0x18263D830")]
		public unsafe static void DPLLDFFOLDG(ArchetypeChunkIterator* IGAACBAHKGC, void* PFDJCNBMCPN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private BJMLDLDMPNN BGPIABGOPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private LPLPHKHEJPF KHDJEFJLLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery CPCBNJFEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private ProfilerMarker FODEFJAFLJI;

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x2632F20", Offset = "0x2631B20", VA = "0x182632F20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x2632CC0", Offset = "0x26318C0", VA = "0x182632CC0", Slot = "14")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x2632F80", Offset = "0x2631B80", VA = "0x182632F80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public BCHEMIIFLDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x2632D20", Offset = "0x2631920", VA = "0x182632D20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x2632B30", Offset = "0x2631730", VA = "0x182632B30")]
	public static EntityQuery HJMOPDNKKJC(ComponentSystemBase BGEDHHBKNNK)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : GDMMHGMPDDN, HKFIKAGKAAK
	{
		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		private struct ENGPHFAGMKJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			public AJMOBODEMMA NGCBDOCNCGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			public NativeHashMap<Entity, CLMGAOKFIAE> MJFGMCFCBDM;

			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x237AB50", Offset = "0x2379750", VA = "0x18237AB50")]
			public ENGPHFAGMKJ(int LAODCMGHKOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x237AAE0", Offset = "0x23796E0", VA = "0x18237AAE0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		[BurstCompile]
		private struct KHOFFMGBLEH : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			[ReadOnly]
			public NativeArray<Entity> MJFGMCFCBDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> EJAJMLGPLII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> HILFCGLJNLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> LBEHDJNPLBB;

			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0x237C1B0", Offset = "0x237ADB0", VA = "0x18237C1B0", Slot = "4")]
			public void Execute(int HIANDEDCLIF, TransformAccess BHPNFBEEMHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[BurstCompile]
		private struct EHBNAGHAOCJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			[ReadOnly]
			public NativeArray<Entity> MJFGMCFCBDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> EJAJMLGPLII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> LBEHDJNPLBB;

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0x237A960", Offset = "0x2379560", VA = "0x18237A960", Slot = "4")]
			public void Execute(int HIANDEDCLIF, TransformAccess BHPNFBEEMHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private LPLPHKHEJPF KHDJEFJLLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private EntityQuery HEDALLJBOEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private EntityQuery MDFGFJFOIME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery IDIJHAPIAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery AAEFOFKAEDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery HMJLELFLNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private JobHandle DMPEKHBNHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private ENGPHFAGMKJ CJGNIAOKDIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private ENGPHFAGMKJ PLPMLOEKBON;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x2384A20", Offset = "0x2383620", VA = "0x182384A20", Slot = "14")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x2384A80", Offset = "0x2383680", VA = "0x182384A80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x2384CC0", Offset = "0x23838C0", VA = "0x182384CC0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x2384CD0", Offset = "0x23838D0", VA = "0x182384CD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x23848C0", Offset = "0x23834C0", VA = "0x1823848C0")]
		private void MJNBKHGHPIO(EntityQuery LJHHKNNHAFE, out (global::AMBNDEDFEAL<DENIMHKEFDN> handles, global::AMBNDEDFEAL<DMENKOJAMJB> bounds) OAGMKJFIKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x2384560", Offset = "0x2383160", VA = "0x182384560")]
		private void FINKMKEFBAP((global::AMBNDEDFEAL<DENIMHKEFDN> handles, global::AMBNDEDFEAL<DMENKOJAMJB> bounds) OAGMKJFIKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x23840A0", Offset = "0x2382CA0", VA = "0x1823840A0")]
		private void BJNMBGCJOMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x2384400", Offset = "0x2383000", VA = "0x182384400")]
		private void DNHCDJBDCPO(EntityQuery LJHHKNNHAFE, out (global::AMBNDEDFEAL<Entity> entities, global::AMBNDEDFEAL<DENIMHKEFDN> handles) OAGMKJFIKKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x23841A0", Offset = "0x2382DA0", VA = "0x1823841A0")]
		private void BLLCDFGIMAA((global::AMBNDEDFEAL<Entity> entities, global::AMBNDEDFEAL<DENIMHKEFDN> handles) OAGMKJFIKKL, ENGPHFAGMKJ APNOOOLFECP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x2384770", Offset = "0x2383370", VA = "0x182384770")]
		private JobHandle KACBAFEIKCI(ENGPHFAGMKJ APNOOOLFECP, ComponentDataFromEntity<WorldPoseData> EJAJMLGPLII, ComponentDataFromEntity<WorldUniformScaleData> LBEHDJNPLBB, ComponentDataFromEntity<WorldDeformableScaleData> HILFCGLJNLF)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x2385530", Offset = "0x2384130", VA = "0x182385530")]
		private JobHandle PKKALEJNBKG(ENGPHFAGMKJ APNOOOLFECP, ComponentDataFromEntity<WorldPoseData> EJAJMLGPLII, ComponentDataFromEntity<WorldUniformScaleData> LBEHDJNPLBB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[MHBJLGEIMOG(typeof(EEMFEBEOLOO), new string[] { })]
public sealed class ONLOCFOLNND : EEMFEBEOLOO, HKFIKAGKAAK
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private struct CIEHNKPODBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public float AFLFLBHMLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public uint GDDOOGGEKFM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private HMECPPGNBDI CKFFNOMMJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private JJAOJIEGHON GBBKKCOCPEM;

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x26B7B40", Offset = "0x26B6740", VA = "0x1826B7B40", Slot = "5")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x26B7620", Offset = "0x26B6220", VA = "0x1826B7620")]
	public bool ECOKJLMGFIF(in float3 OBECBBNHKAL, in float3 NIIKOIAOGAL, float EIJHLGKIBNG, out DIBJLGOBLGJ KPKONOMMOKC, out Entity HMEJLHDILOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x26B7A10", Offset = "0x26B6610", VA = "0x1826B7A10")]
	public static bool HKBAAGPILAD(in Span<DIBJLGOBLGJ> GFLHBMAGHPF, float EIJHLGKIBNG, out int HIANDEDCLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x26B7B10", Offset = "0x26B6710", VA = "0x1826B7B10")]
	public static float KLOGLMFLJCC(float AFLFLBHMLCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public ONLOCFOLNND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x26B7B00", Offset = "0x26B6700", VA = "0x1826B7B00", Slot = "4")]
	private bool JJFGMCDBNBN(in float3 OBECBBNHKAL, in float3 NIIKOIAOGAL, float EIJHLGKIBNG, out DIBJLGOBLGJ KPKONOMMOKC, out Entity HMEJLHDILOI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct BNDBLBCBCHG : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Physics)]
	public class SplineLocalBoundsSystem : GDMMHGMPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[BurstCompile]
		private struct MIJABHBMMEH : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			[ReadOnly]
			public NativeArray<Entity> MDNNEGGLIAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> CEEDAICPMNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			[ReadOnly]
			public ComponentDataFromEntity<DMENKOJAMJB> HFNDDCCOKHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			[WriteOnly]
			public NativeHashMap<Entity, CLMGAOKFIAE>.ParallelWriter IBIBEJIJLHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter CBHMJMCFKHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter NKJIFKINFON;

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x237CE20", Offset = "0x237BA20", VA = "0x18237CE20", Slot = "4")]
			public void Execute(int HIANDEDCLIF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[BurstCompile]
		private struct GKNBAJAICEO : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[ReadOnly]
			public NativeArray<Entity> KFJDAIEHMGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> IKPOABIFEKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> CEEDAICPMNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<DMENKOJAMJB> GNFLCOACEHK;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x237BCC0", Offset = "0x237A8C0", VA = "0x18237BCC0", Slot = "4")]
			public void Execute(int HIANDEDCLIF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery ELNLNLOEHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery AHLEIIDAKIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery BAMKKKAONIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery KPPBDNEBCDG;

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x238AA20", Offset = "0x2389620", VA = "0x18238AA20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x238ABC0", Offset = "0x23897C0", VA = "0x18238ABC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x2389FA0", Offset = "0x2388BA0", VA = "0x182389FA0")]
		private JobHandle GPKKBJJDMJI(global::AMBNDEDFEAL<Entity> LBLDONKHBCF, int LEHFCNIEMMI, JobHandle LIOENDEGGJH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x2389DE0", Offset = "0x23889E0", VA = "0x182389DE0")]
		private JobHandle GPKKBJJDMJI(NativeArray<Entity> BBFNCHEFOOO, int LEHFCNIEMMI, [Optional] JobHandle LIOENDEGGJH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x2389CD0", Offset = "0x23888D0", VA = "0x182389CD0")]
		private global::AMBNDEDFEAL<Entity> DAEECPKKEJM(EntityQuery LJHHKNNHAFE)
		{
			return default(global::AMBNDEDFEAL<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x238A070", Offset = "0x2388C70", VA = "0x18238A070")]
		private (global::EOLIJDAIKKF<Entity>, global::EOLIJDAIKKF<Entity>) IDMNBDMNILF(global::AMBNDEDFEAL<Entity> NCFLJAENDMI)
		{
			return default((global::EOLIJDAIKKF<Entity>, global::EOLIJDAIKKF<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x2389D60", Offset = "0x2388960", VA = "0x182389D60")]
		private void GNNPMLLGLDH(out NativeArray<Entity> MJFGMCFCBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x238A440", Offset = "0x2389040", VA = "0x18238A440")]
		private void KFLJBNFFILH(NativeList<Entity> MJFGMCFCBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x238A4C0", Offset = "0x23890C0", VA = "0x18238A4C0")]
		private void KFLJBNFFILH(NativeArray<Entity> MJFGMCFCBDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x238A580", Offset = "0x2389180", VA = "0x18238A580")]
		private void NBLANKHPJNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		private static void CDMPFLLNPHJ(int KMBOAFHOAEK, int NPICKIOLEOH, int JAJFFJBCEPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x238A6A0", Offset = "0x23892A0", VA = "0x18238A6A0")]
		private static DMENKOJAMJB OMBLIBOBBFF(NativeArray<Entity> EIKNCKOCANF, ComponentDataFromEntity<SplinePointData> CEEDAICPMNK)
		{
			return default(DMENKOJAMJB);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[MHBJLGEIMOG(typeof(JJAOJIEGHON), new string[] { })]
public sealed class GCEEHMLBLCA : JJAOJIEGHON, HKFIKAGKAAK
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[BurstCompile]
	private struct BPFPCJNCOFF : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		[ReadOnly]
		public NativeArray<Entity> MJFGMCFCBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		[ReadOnly]
		public float3 DFALPKAMLJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		[ReadOnly]
		public float3 PCIFMKDIBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> FJMFAIPKDHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> AFAAILPJOME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> IKPOABIFEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointData> CEEDAICPMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[WriteOnly]
		public NativeArray<DIBJLGOBLGJ> KBMJAFOLPKL;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static readonly DIBJLGOBLGJ LJGEILJHIFJ;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x2364560", Offset = "0x2363160", VA = "0x182364560", Slot = "4")]
		public void Execute(int HIANDEDCLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x2365610", Offset = "0x2364210", VA = "0x182365610")]
		private static float3 PBMGHLIKLPJ(in float4x4 HOMKLCHJMDG, in float3 JJMMEHEHCFO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x2364390", Offset = "0x2362F90", VA = "0x182364390")]
		private static float3 DDGOMDKOLMC(in float4x4 HOMKLCHJMDG, in float3 DBIDCCIFBHE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x23652E0", Offset = "0x2363EE0", VA = "0x1823652E0")]
		private static float3 LPBIACCNGDI(in float4x4 HOMKLCHJMDG, in float3 JJMMEHEHCFO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x23653E0", Offset = "0x2363FE0", VA = "0x1823653E0")]
		private static float3 MLOAOBFLMGI(in float4x4 HOMKLCHJMDG, in float3 DBIDCCIFBHE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x2364F90", Offset = "0x2363B90", VA = "0x182364F90")]
		private bool KGFGMKKKIOA(in float3 OBECBBNHKAL, in float3 NIIKOIAOGAL, in NativeArray<Entity> HOFMCNCDDAB, out float3 KPKONOMMOKC, out float3 DOGBEAKOJOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x2364890", Offset = "0x2363490", VA = "0x182364890")]
		public static bool IIIIEMJADFO(in float3 JECMGLNJGNM, in float3 DMIMCDOGKNN, in float3 GLGAOMNDJCA, in float3 IODHNOOEAKJ, float PGNMMAPOLJF, float DBJFPFBCIBA, out float LDKDBEMBOCB, out float3 BNCANALGMGM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private EntityManager EJMLDDGCGJO;

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x2366700", Offset = "0x2365300", VA = "0x182366700", Slot = "5")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x23664F0", Offset = "0x23650F0", VA = "0x1823664F0")]
	public void ECOKJLMGFIF(in NativeArray<Entity> MJFGMCFCBDM, in float3 OBECBBNHKAL, in float3 NIIKOIAOGAL, in NativeArray<DIBJLGOBLGJ> NDAIKGDIIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GCEEHMLBLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x23664F0", Offset = "0x23650F0", VA = "0x1823664F0", Slot = "4")]
	private void NMDFDBPPGEK(in NativeArray<Entity> MJFGMCFCBDM, in float3 OBECBBNHKAL, in float3 NIIKOIAOGAL, in NativeArray<DIBJLGOBLGJ> NDAIKGDIIFE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct FBAOABKOKJI : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Lifecycle)]
	public class DestroyLocalObjects : GDMMHGMPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private bool JMNCCKFMNPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private EntityQuery HMKCIJJBPJC;

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x26AFB90", Offset = "0x26AE790", VA = "0x1826AFB90")]
		public bool OAEKANNNPPH(Entity OCMABEPCGDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x26AFC30", Offset = "0x26AE830", VA = "0x1826AFC30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x26AFCB0", Offset = "0x26AE8B0", VA = "0x1826AFCB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x120CA50", Offset = "0x120B650", VA = "0x18120CA50", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.NetworkSend)]
	public abstract class EnqueuePropertyDifferenceToNetwork : GDMMHGMPDDN, HKFIKAGKAAK
	{
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private CJAOPNMFBHF DELDDCJAPNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private PNPPGDJCNCL LCAGHKIOCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private DMOLBBGANCB DABBJFEADJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private FEEAFAEFFFL IADJLOGDJJD;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		protected abstract ComputePropertyDifferences FBHDONOMAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x26B0F10", Offset = "0x26AFB10", VA = "0x1826B0F10", Slot = "14")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x26B0FC0", Offset = "0x26AFBC0", VA = "0x1826B0FC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		private void DPKJNGJFNOH(Entity OCMABEPCGDM, GEGPJNFMCPG PJIBLINGJGM, FCAJCLOJKEA IOBOHFJFMJM, OMLJIMOKBJA KAOBFCBJBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		protected EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Callbacks)]
	public abstract class PropertyEventCallbacks : GDMMHGMPDDN, HKFIKAGKAAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private PropertyEventCallbacksService AOINJCPCJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private FEEAFAEFFFL IADJLOGDJJD;

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x2388970", Offset = "0x2387570", VA = "0x182388970", Slot = "14")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x23889F0", Offset = "0x23875F0", VA = "0x1823889F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		protected PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public abstract class EJJHJAJEDJK : GDMMHGMPDDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private List<(EntityQuery, ComponentType)> IAMBEOMBAPK;

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x2637F20", Offset = "0x2636B20", VA = "0x182637F20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x26380F0", Offset = "0x2636CF0", VA = "0x1826380F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x2633130", Offset = "0x2631D30", VA = "0x182633130")]
	protected EJJHJAJEDJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal struct NCPGNPFHLCN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public int PAOIHHHPKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public int EKKPBKBJINC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x26B3EC0", Offset = "0x26B2AC0", VA = "0x1826B3EC0")]
	public static Entity GOPIOOMOEDD(NCPGNPFHLCN OAGMKJFIKKL)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x26B3EC0", Offset = "0x26B2AC0", VA = "0x1826B3EC0")]
	public static NCPGNPFHLCN GOPIOOMOEDD(Entity OCMABEPCGDM)
	{
		return default(NCPGNPFHLCN);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal struct LMGJCDBOJAH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct EHHMIMOJCNN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public readonly ComponentType KLFNKNLAGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public readonly NativeList<int> KDDCEBHGJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public readonly NativeList<int> GNJPIBGHCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public readonly NativeArray<Entity> MJFGMCFCBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public readonly NativeArray<Entity> OHCLPFGLBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public readonly NativeArray<byte> IJHKBBAPBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public readonly NativeArray<byte> NHILDHCHLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public readonly int LHEICHLOPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public readonly int PMHNEAOGNIF;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool GPMENIJCNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x2637BF0", Offset = "0x26367F0", VA = "0x182637BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2637DE0", Offset = "0x26369E0", VA = "0x182637DE0")]
	public EHHMIMOJCNN(ComponentType KLFNKNLAGBI, NativeList<int> KDDCEBHGJHK, NativeList<int> GNJPIBGHCJE, NativeArray<Entity> MJFGMCFCBDM, NativeArray<Entity> OHCLPFGLBEK, NativeArray<byte> IJHKBBAPBME, NativeArray<byte> NHILDHCHLPL, int LHEICHLOPJI, int PMHNEAOGNIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x2637AD0", Offset = "0x26366D0", VA = "0x182637AD0")]
	private CJHLIFJIIDK BKPGLBIJKAI(NativeArray<byte> LBLDONKHBCF, int HIANDEDCLIF)
	{
		return default(CJHLIFJIIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	private T BKPGLBIJKAI<T>(NativeArray<byte> LBLDONKHBCF, int HIANDEDCLIF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x2637D90", Offset = "0x2636990", VA = "0x182637D90")]
	public CJHLIFJIIDK KGCMAIMGNNJ(int HIANDEDCLIF)
	{
		return default(CJHLIFJIIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	public T KGCMAIMGNNJ<T>(int HIANDEDCLIF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x2637D40", Offset = "0x2636940", VA = "0x182637D40")]
	public CJHLIFJIIDK HNEMFBPBMFI(int HIANDEDCLIF)
	{
		return default(CJHLIFJIIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	public T HNEMFBPBMFI<T>(int HIANDEDCLIF) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x2637C60", Offset = "0x2636860", VA = "0x182637C60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public struct BCFEJIFODGF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public readonly EntityQuery LJHHKNNHAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public readonly NativeArray<PIPFIMDPIFK> GCALAGNGEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public readonly ComponentType KLFNKNLAGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public readonly int LHEICHLOPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public readonly int PMHNEAOGNIF;

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x2632B00", Offset = "0x2631700", VA = "0x182632B00")]
	public BCFEJIFODGF(ComponentType KLFNKNLAGBI, int LHEICHLOPJI, int PMHNEAOGNIF, EntityQuery LJHHKNNHAFE, NativeArray<PIPFIMDPIFK> GCALAGNGEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x2632AB0", Offset = "0x26316B0", VA = "0x182632AB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal struct JJMJOFGIIHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public int HIANDEDCLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public int BGNEEBHEAJP;

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x775D30", Offset = "0x774930", VA = "0x180775D30")]
	public JJMJOFGIIHA(int HIANDEDCLIF, int BGNEEBHEAJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public struct PIPFIMDPIFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public readonly int FPKCCNCOJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public readonly int OEBMILJLIAL;

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x775D30", Offset = "0x774930", VA = "0x180775D30")]
	public PIPFIMDPIFK(int FPKCCNCOJGI, int OEBMILJLIAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public struct OMLJIMOKBJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly LOGKGBLPOOD DJHPMDEHJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private readonly int LHEICHLOPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private unsafe readonly byte* IJHKBBAPBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private unsafe readonly byte* NHILDHCHLPL;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool PDABALEFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x26B75F0", Offset = "0x26B61F0", VA = "0x1826B75F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public LOGKGBLPOOD ICNLNAJKHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x8AB500", Offset = "0x8AA100", VA = "0x1808AB500")]
		get
		{
			return default(LOGKGBLPOOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x26B7430", Offset = "0x26B6030", VA = "0x1826B7430")]
	public CJHLIFJIIDK AAGHOKFPDMN(Type LIJLAEFJGCI)
	{
		return default(CJHLIFJIIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x26B7510", Offset = "0x26B6110", VA = "0x1826B7510")]
	public CJHLIFJIIDK EHPMBEICKNA(Type LIJLAEFJGCI)
	{
		return default(CJHLIFJIIDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x202AAE0", Offset = "0x20296E0", VA = "0x18202AAE0")]
	public T AAGHOKFPDMN<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x202AB00", Offset = "0x2029700", VA = "0x18202AB00")]
	public T EHPMBEICKNA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x26B7600", Offset = "0x26B6200", VA = "0x1826B7600")]
	public unsafe OMLJIMOKBJA(LOGKGBLPOOD DJHPMDEHJMK, int OEBMILJLIAL, byte* IJHKBBAPBME, byte* NHILDHCHLPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class NGNGIGNHMMK
{
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] DFEPMMHFBBK;
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[DefaultMember("Item")]
internal class MDJEIHJFEJO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private readonly Dictionary<ComponentType, BCFEJIFODGF> FEIPDFCACKP;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public BCFEJIFODGF GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x23779B0", Offset = "0x23765B0", VA = "0x1823779B0")]
		get
		{
			return default(BCFEJIFODGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2378070", Offset = "0x2376C70", VA = "0x182378070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x2378150", Offset = "0x2376D50", VA = "0x182378150")]
	public MDJEIHJFEJO(BHBECLCNBCK NJMNPDHNNLL, LJFAOMOPGNF FFJIMJJJOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x23780C0", Offset = "0x2376CC0", VA = "0x1823780C0")]
	public Dictionary<ComponentType, BCFEJIFODGF>.Enumerator OKMFHIDEJFI()
	{
		return default(Dictionary<ComponentType, BCFEJIFODGF>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x2377780", Offset = "0x2376380", VA = "0x182377780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x2377A30", Offset = "0x2376630", VA = "0x182377A30")]
	private void JFBCJBONANL(IEnumerable<BMGOEDLPBCC> JJNMIJEJIJL, EntityManager EJMLDDGCGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x2377900", Offset = "0x2376500", VA = "0x182377900")]
	private static int ENHMJJADKPP(BMGOEDLPBCC FCDBFCFIAKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x2377E20", Offset = "0x2376A20", VA = "0x182377E20")]
	private static NativeArray<PIPFIMDPIFK> MKCBIHEFOGA(BMGOEDLPBCC FCDBFCFIAKD, Allocator HGKGLCNFHPJ = Allocator.Persistent)
	{
		return default(NativeArray<PIPFIMDPIFK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal interface FEEAFAEFFFL
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	World OGOLPPAGPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PMFPONGFFGN(out NativeArray<int> ALGMKBECKKO, Allocator HGKGLCNFHPJ);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GAAFFEGFLKG(ComponentType KLFNKNLAGBI, out EHHMIMOJCNN KGLAPILOILO, out BCFEJIFODGF GMPDMIJGEHC);

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GAAFFEGFLKG(ComponentType KLFNKNLAGBI, out EHHMIMOJCNN KGLAPILOILO);

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EHHMIMOJCNN LIJOLJELOLO(ComponentType KLFNKNLAGBI);

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NIOMOKDFMAH KOGMBHEJEAB();

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JELJDDDFALM(JobHandle NKBLFABEMGA);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal interface FNJHKEKGBGD
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	World OGOLPPAGPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	MDJEIHJFEJO JEPIDHJIJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	LHNFCENAJJN FNEJLCHHLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	NativeMultiHashMap<Entity, OMLJIMOKBJA> IDDPAFPAFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	JobHandle JJBOLCJJDJO
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HILHGJFFAMN();

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LONCNHKPMCG();

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DMOPFFMGMMK(ComponentType KLFNKNLAGBI, in EHHMIMOJCNN LPAMEGKAGCD);

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JLACMNIEMDI(CMECOJAJFAB LBEKIEDKPCN, out Entity PAMDOGALOKE);
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[MHBJLGEIMOG(typeof(PropertyDiffStateService), new string[] { })]
	[GOMFNBMFGBH(ELBDNIJMKBJ.PropertyChanges)]
	internal class PropertyDiffStateService : HKFIKAGKAAK, GEPKKGPMACB, FNJHKEKGBGD, FEEAFAEFFFL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private BHBECLCNBCK NJMNPDHNNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private ObjectPrefabCreationService PNALABGJPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private FAMHHBOFMMF LGAGLKFDFDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private MDJEIHJFEJO FEIPDFCACKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private LHNFCENAJJN BFFLHPKKMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private FCACHBMMHDE MLKMNIFACIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private List<EHHMIMOJCNN> KBJECPLMAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private NativeMultiHashMap<Entity, OMLJIMOKBJA> JDIIFKKBJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private NativeHashMap<int, int> IIPEBFJEKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private JobHandle FIMMIOBOFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private JobHandle IBFBOHGBCHH;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public bool GPMENIJCNIK
		{
			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x23869F0", Offset = "0x23855F0", VA = "0x1823869F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		private World GEGHKJBOEFH
		{
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x2386990", Offset = "0x2385590", VA = "0x182386990", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		private MDJEIHJFEJO GOCFKCAFIAA
		{
			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		private LHNFCENAJJN BODLIBJJPGA
		{
			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x614A30", Offset = "0x613630", VA = "0x180614A30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private NativeMultiHashMap<Entity, OMLJIMOKBJA> BOPGCKGEAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0xF16E90", Offset = "0xF15A90", VA = "0x180F16E90", Slot = "9")]
			get
			{
				return default(NativeMultiHashMap<Entity, OMLJIMOKBJA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		private JobHandle KNPMJOAEMPN
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x8EDDD0", Offset = "0x8EC9D0", VA = "0x1808EDDD0", Slot = "10")]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x8EDE80", Offset = "0x8ECA80", VA = "0x1808EDE80", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		private World PKJAOKCMMAH
		{
			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x2386C10", Offset = "0x2385810", VA = "0x182386C10", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x23874C0", Offset = "0x23860C0", VA = "0x1823874C0", Slot = "13")]
		private void NEIFANEOEIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2387650", Offset = "0x2386250", VA = "0x182387650", Slot = "12")]
		private void OMOKMDHHAND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x23874D0", Offset = "0x23860D0", VA = "0x1823874D0", Slot = "14")]
		private void OAJJLCHMCEN(ComponentType KLFNKNLAGBI, in EHHMIMOJCNN LPAMEGKAGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2386BF0", Offset = "0x23857F0", VA = "0x182386BF0", Slot = "15")]
		private bool IEIEMJNHJGL(CMECOJAJFAB LBEKIEDKPCN, out Entity PAMDOGALOKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2386C70", Offset = "0x2385870", VA = "0x182386C70", Slot = "17")]
		private bool KFKNIODKDFK(out NativeArray<int> ALGMKBECKKO, Allocator HGKGLCNFHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2387320", Offset = "0x2385F20", VA = "0x182387320", Slot = "18")]
		private bool MFIOABBAJMH(ComponentType KLFNKNLAGBI, out EHHMIMOJCNN KGLAPILOILO, out BCFEJIFODGF GMPDMIJGEHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x2387210", Offset = "0x2385E10", VA = "0x182387210", Slot = "19")]
		private bool MFIOABBAJMH(ComponentType KLFNKNLAGBI, out EHHMIMOJCNN KGLAPILOILO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x2386AC0", Offset = "0x23856C0", VA = "0x182386AC0", Slot = "20")]
		private EHHMIMOJCNN EBKAIOGIOIE(ComponentType KLFNKNLAGBI)
		{
			return default(EHHMIMOJCNN);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x2387480", Offset = "0x2386080", VA = "0x182387480", Slot = "21")]
		private NIOMOKDFMAH NBCAFKFLFBE()
		{
			return default(NIOMOKDFMAH);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x23875A0", Offset = "0x23861A0", VA = "0x1823875A0", Slot = "22")]
		private void OBJPLDELJNN(JobHandle NKBLFABEMGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x23875E0", Offset = "0x23861E0", VA = "0x1823875E0", Slot = "4")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x2387070", Offset = "0x2385C70", VA = "0x182387070", Slot = "5")]
		public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x2386A00", Offset = "0x2385600", VA = "0x182386A00", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2386E50", Offset = "0x2385A50", VA = "0x182386E50")]
		private void LONCNHKPMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x23867D0", Offset = "0x23853D0", VA = "0x1823867D0")]
		private bool BANGEKHDNJP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x2386D00", Offset = "0x2385900", VA = "0x182386D00")]
		private int LGAPPEKNKME()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x2387750", Offset = "0x2386350", VA = "0x182387750")]
		public PropertyDiffStateService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal struct NIOMOKDFMAH
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public struct INDODLGJFIJ : IEnumerator<OMLJIMOKBJA>, IEnumerator, IDisposable, IEnumerable<OMLJIMOKBJA>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly NativeMultiHashMap<Entity, OMLJIMOKBJA> BBDNOECODFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly Entity OCMABEPCGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private NativeMultiHashMapIterator<Entity> MOGDLPLJDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private OMLJIMOKBJA NHILDHCHLPL;

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public OMLJIMOKBJA IJPBKONCNPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0xC02F40", Offset = "0xC01B40", VA = "0x180C02F40", Slot = "4")]
			get
			{
				return default(OMLJIMOKBJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x26B2DA0", Offset = "0x26B19A0", VA = "0x1826B2DA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x26B2DF0", Offset = "0x26B19F0", VA = "0x1826B2DF0")]
		internal INDODLGJFIJ(NativeMultiHashMap<Entity, OMLJIMOKBJA> BBDNOECODFL, Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x26B2B70", Offset = "0x26B1770", VA = "0x1826B2B70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x26B2C10", Offset = "0x26B1810", VA = "0x1826B2C10")]
		public INDODLGJFIJ OKMFHIDEJFI()
		{
			return default(INDODLGJFIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x26B2C40", Offset = "0x26B1840", VA = "0x1826B2C40", Slot = "9")]
		private IEnumerator<OMLJIMOKBJA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x26B2CF0", Offset = "0x26B18F0", VA = "0x1826B2CF0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private readonly FNJHKEKGBGD IADJLOGDJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private readonly JobHandle KAKEBGAPPJL;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public int GPEDFLNLDID
	{
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x26B48D0", Offset = "0x26B34D0", VA = "0x1826B48D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool GAJOLDEOPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x26B4B00", Offset = "0x26B3700", VA = "0x1826B4B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x24C94F0", Offset = "0x24C80F0", VA = "0x1824C94F0")]
	public NIOMOKDFMAH(FNJHKEKGBGD IADJLOGDJJD, JobHandle KAKEBGAPPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x26B49C0", Offset = "0x26B35C0", VA = "0x1826B49C0")]
	public bool GODNGGKGHKP(Allocator HGKGLCNFHPJ, out NativeKeyValueArrays<Entity, OMLJIMOKBJA> MIILAJKCKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x26B4CF0", Offset = "0x26B38F0", VA = "0x1826B4CF0")]
	public bool KELCKIACEIO(Allocator HGKGLCNFHPJ, out (NativeArray<Entity> entities, int uniqueCount) MIILAJKCKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x26B4BE0", Offset = "0x26B37E0", VA = "0x1826B4BE0")]
	public INDODLGJFIJ JOAKFLMPIHJ(Entity OCMABEPCGDM)
	{
		return default(INDODLGJFIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[DefaultMember("Item")]
internal class LHNFCENAJJN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private readonly List<BCFEJIFODGF> FPPBJGHNMLI;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public BCFEJIFODGF GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x2374E60", Offset = "0x2373A60", VA = "0x182374E60")]
		get
		{
			return default(BCFEJIFODGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x2375230", Offset = "0x2373E30", VA = "0x182375230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x23752F0", Offset = "0x2373EF0", VA = "0x1823752F0")]
	public LHNFCENAJJN(MDJEIHJFEJO FEIPDFCACKP, BHBECLCNBCK NJMNPDHNNLL, LJFAOMOPGNF FFJIMJJJOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x2375270", Offset = "0x2373E70", VA = "0x182375270")]
	public List<BCFEJIFODGF>.Enumerator OKMFHIDEJFI()
	{
		return default(List<BCFEJIFODGF>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x2374CE0", Offset = "0x23738E0", VA = "0x182374CE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x2374EF0", Offset = "0x2373AF0", VA = "0x182374EF0")]
	private void JFBCJBONANL(MDJEIHJFEJO FEIPDFCACKP, EntityManager EJMLDDGCGJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal class FCACHBMMHDE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private readonly ObjectPrefabCreationService PNALABGJPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private readonly global::MGMBGHBGHPD<BMGOEDLPBCC> FCADEJJBLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private readonly World KNBPPIHJCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private readonly EntityManager EJMLDDGCGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private NativeHashMap<int, Entity> MLKMNIFACIO;

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x263A950", Offset = "0x2639550", VA = "0x18263A950")]
	public FCACHBMMHDE(ObjectPrefabCreationService PNALABGJPMO, BHBECLCNBCK NJMNPDHNNLL, LJFAOMOPGNF FFJIMJJJOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x2639450", Offset = "0x2638050", VA = "0x182639450", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x2639320", Offset = "0x2637F20", VA = "0x182639320")]
	public bool BIMGLPCMALN(CMECOJAJFAB LBEKIEDKPCN, out Entity PAMDOGALOKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x263A370", Offset = "0x2638F70", VA = "0x18263A370")]
	private void PDDHLEAEAAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x2639E70", Offset = "0x2638A70", VA = "0x182639E70")]
	private EntityArchetype PBIMMEBBBLN(EntityArchetype NNIMGPNKOJN)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x2639970", Offset = "0x2638570", VA = "0x182639970")]
	public static void NBNKGPODBMN(EntityManager DHINOEGHFBO, EntityManager IMGEIANHDLC, NativeArray<Entity> PFCNIGLGCGA, NativeArray<EntityArchetype> DPHKPDLHADO, [Optional] NativeArray<Entity> NDMPMLPAAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x2639D10", Offset = "0x2638910", VA = "0x182639D10")]
	[Conditional("DEBUG_BUILD")]
	private static void OHPOOHHDEDG(NativeArray<EntityArchetype> PFOFBDLLIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x26394B0", Offset = "0x26380B0", VA = "0x1826394B0")]
	private static string GFEEPGJPLML(EntityArchetype FMENGPOHLND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x2639830", Offset = "0x2638430", VA = "0x182639830")]
	[CompilerGenerated]
	internal static void NACEIABGEOK(ref Span<ComponentType> LKAMBKAMODI, ComponentType KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x2639690", Offset = "0x2638290", VA = "0x182639690")]
	[CompilerGenerated]
	internal static void IFMHMFDIIKE(Span<ComponentType> LBLDONKHBCF, ref Span<ComponentType> LKAMBKAMODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x2639380", Offset = "0x2637F80", VA = "0x182639380")]
	[CompilerGenerated]
	internal static void DEPOMOPBMIL(Span<ComponentType> LBLDONKHBCF, ref Span<ComponentType> LKAMBKAMODI, ComponentType ONBOIAGDNAN)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.PropertyChanges)]
	public abstract class ApplyPropertyDifferences : GDMMHGMPDDN, HKFIKAGKAAK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private struct CEBHMFIGEKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public GOIKPPLOOOI dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
			public CEBHMFIGEKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct APFIJNNFFNB : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			[ReadOnly]
			public NativeArray<byte> NHILDHCHLPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			[ReadOnly]
			public NativeList<int> KDDCEBHGJHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			[ReadOnly]
			public NativeArray<Entity> OHCLPFGLBEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public int LHEICHLOPJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public GOIKPPLOOOI BMIBPMLFDDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public ComponentType KLFNKNLAGBI;

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x26A8470", Offset = "0x26A7070", VA = "0x1826A8470")]
			internal void KDPNCNEOCOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x26A8630", Offset = "0x26A7230", VA = "0x1826A8630", Slot = "5")]
			public void ReadFromDisplayClass(ref CEBHMFIGEKH DDKABHBJHOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x26A8460", Offset = "0x26A7060", VA = "0x1826A8460", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x26A8610", Offset = "0x26A7210", VA = "0x1826A8610")]
			public void NKMFOFOBAPA(ApplyPropertyDifferences BGEDHHBKNNK, ref CEBHMFIGEKH DDKABHBJHOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private FEEAFAEFFFL IADJLOGDJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private JobHandle FIMMIOBOFLA;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x26A96B0", Offset = "0x26A82B0", VA = "0x1826A96B0")]
		public void KBJMPKKPODE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x26A96C0", Offset = "0x26A82C0", VA = "0x1826A96C0", Slot = "14")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x26A9720", Offset = "0x26A8320", VA = "0x1826A9720", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x26A9390", Offset = "0x26A7F90", VA = "0x1826A9390")]
		private bool AMJBLNNJPHL(JobHandle LIOENDEGGJH, int OINILPILIOE, out JobHandle KDCIEKNBDGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		protected ApplyPropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.PropertyChanges)]
	public abstract class ComputePropertyDifferences : GDMMHGMPDDN, HKFIKAGKAAK, GEPKKGPMACB
	{
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[BurstCompile]
		internal struct KDFJNEFJDHO : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			[ReadOnly]
			public NativeArray<byte> CDHJLEIGMHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeArray<byte> IOAJMFLFGBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public NativeArray<PIPFIMDPIFK> ALNEDOGAKGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			[WriteOnly]
			public NativeList<JJMJOFGIIHA>.ParallelWriter HNHFCFMIIBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public int HCLHIJPAMHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public int LEKINLHFADH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public ProfilerMarker AALCPGDJIEB;

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x26B3090", Offset = "0x26B1C90", VA = "0x1826B3090", Slot = "4")]
			public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x26B31C0", Offset = "0x26B1DC0", VA = "0x1826B31C0")]
			private unsafe int KAGOHNLALGG(byte* KFDAJNJBFEP, byte* DGHFPMGLNEJ)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		[BurstCompile]
		internal struct DKGCMAOOKGK : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			[WriteOnly]
			public NativeList<int> KDDCEBHGJHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			[WriteOnly]
			public NativeList<int> DBIFGCMMBEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			[ReadOnly]
			public NativeList<JJMJOFGIIHA> NNJBIANOCAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public ProfilerMarker AALCPGDJIEB;

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x26AFAD0", Offset = "0x26AE6D0", VA = "0x1826AFAD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		[BurstCompile]
		internal struct GDOCLMHLPCF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			[WriteOnly]
			public NativeArray<byte> JKPMEAIMEHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			[ReadOnly]
			public NativeArray<Entity> MJFGMCFCBDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			[ReadOnly]
			public GOIKPPLOOOI HLEGOHAPEJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public int LHEICHLOPJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public ProfilerMarker AALCPGDJIEB;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x26B22D0", Offset = "0x26B0ED0", VA = "0x1826B22D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		[BurstCompile]
		internal struct BOPMNIAJECE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, OMLJIMOKBJA> JDICCOGAIKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public NativeArray<byte> IJHKBBAPBME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public NativeArray<byte> NHILDHCHLPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			[ReadOnly]
			public NativeArray<Entity> MJFGMCFCBDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeArray<PIPFIMDPIFK> CKFHHHJBCFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public NativeList<int> GNJPIBGHCJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			[ReadOnly]
			public NativeList<int> KDDCEBHGJHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public int LDAENDJICPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public int PMHNEAOGNIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public ProfilerMarker AALCPGDJIEB;

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x26A9A30", Offset = "0x26A8630", VA = "0x1826A9A30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private static readonly ProfilerMarker DPNEJKBLDMP;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private static readonly ProfilerMarker INIEDHJPDHN;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly ProfilerMarker DHJPBKDDNFF;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private static readonly ProfilerMarker EJILFHNKNLO;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private static readonly ProfilerMarker OIGGJBPKHLP;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private static readonly ProfilerMarker ILKAFEJBDLK;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly ProfilerMarker IBEFAAJGJMH;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private static readonly ProfilerMarker MDFADIPFOBM;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static readonly ProfilerMarker OAHBKAFDANJ;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private static readonly ProfilerMarker HBDOGNBLDGD;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private static readonly ProfilerMarker NNDNMGHBOJN;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private static readonly ProfilerMarker GCOHOHNNMAA;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private static readonly ProfilerMarker NNDKACLCJAI;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private static readonly ProfilerMarker ELCIBBBLEKL;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private static readonly ProfilerMarker JGIKBMOIIBE;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private static readonly ProfilerMarker ECENLOCGLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private FNJHKEKGBGD IADJLOGDJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private ApplyPropertyDifferences GMIBKKHJBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private EntityQuery NJJELMGFCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private EntityQuery MIJEBGPCHHG;

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		protected abstract ApplyPropertyDifferences DBDJFNOBFAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		internal World OGOLPPAGPHP
		{
			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0x26AB170", Offset = "0x26A9D70", VA = "0x1826AB170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x26AB8D0", Offset = "0x26AA4D0", VA = "0x1826AB8D0")]
		internal BCFEJIFODGF NBFLKIDGJFI(ComponentType KLFNKNLAGBI)
		{
			return default(BCFEJIFODGF);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x26AC670", Offset = "0x26AB270", VA = "0x1826AC670", Slot = "14")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "15")]
		public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x26AC6D0", Offset = "0x26AB2D0", VA = "0x1826AC6D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x26AC820", Offset = "0x26AB420", VA = "0x1826AC820", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x26AC7D0", Offset = "0x26AB3D0", VA = "0x1826AC7D0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x26AA8E0", Offset = "0x26A94E0", VA = "0x1826AA8E0")]
		private void DAJOLNMMMGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x26AB7E0", Offset = "0x26AA3E0", VA = "0x1826AB7E0")]
		private void LDBEPMIAPPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x26AAB90", Offset = "0x26A9790", VA = "0x1826AAB90")]
		internal void DHOAOKIEHEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x26AB5D0", Offset = "0x26AA1D0", VA = "0x1826AB5D0")]
		private void KLCEPMAGGDE(NativeArray<Entity> PFCNIGLGCGA, NativeArray<RRObjectPrefabData> AFOMLLMAJBF, ref NativeArray<Entity> MNOFJJHAOMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x26A9E60", Offset = "0x26A8A60", VA = "0x1826A9E60")]
		internal void BGJPKDOBBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x26AA120", Offset = "0x26A8D20", VA = "0x1826AA120")]
		internal void BNCAFIKLKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x26AC380", Offset = "0x26AAF80", VA = "0x1826AC380")]
		private void OKNPBKBFBGE(BCFEJIFODGF GMPDMIJGEHC, bool ABJLDADPNOL, ref JobHandle NBBEIIFBMKO, ref JobHandle MMPENIIBHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x26AC350", Offset = "0x26AAF50", VA = "0x1826AC350")]
		internal bool NNDADJDHBCC(in BCFEJIFODGF DGHFPMGLNEJ, out JobHandle CGGCCCAGOLF, out EHHMIMOJCNN GLBHMMDEGHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x26ABB00", Offset = "0x26AA700", VA = "0x1826ABB00")]
		private bool NNDADJDHBCC(in BCFEJIFODGF DGHFPMGLNEJ, bool ABJLDADPNOL, out JobHandle CGGCCCAGOLF, out EHHMIMOJCNN GLBHMMDEGHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x26AB3B0", Offset = "0x26A9FB0", VA = "0x1826AB3B0")]
		internal (NativeList<int>, NativeList<int>) KICIDDKKBBO(NativeList<JJMJOFGIIHA> NNJBIANOCAK, int LAODCMGHKOP, JobHandle LIOENDEGGJH, out JobHandle NKBLFABEMGA, Allocator HGKGLCNFHPJ = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x26AB310", Offset = "0x26A9F10", VA = "0x1826AB310")]
		internal static NativeArray<Entity> KFGHONBACKG(EntityQuery LJHHKNNHAFE, out JobHandle PFFLFLLEJMK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x26AB550", Offset = "0x26AA150", VA = "0x1826AB550")]
		internal static NativeArray<byte> KJAGPNNBGAB(int IAIFCDOPKGE, out JobHandle HKCAJDOLNKI)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x26AB1C0", Offset = "0x26A9DC0", VA = "0x1826AB1C0")]
		internal static NativeArray<byte> FHFMPGODJBF(EntityQuery LJHHKNNHAFE, int OINILPILIOE, out JobHandle HKCAJDOLNKI)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x26AA7B0", Offset = "0x26A93B0", VA = "0x1826AA7B0")]
		internal static NativeArray<Entity> DAEECPKKEJM(EntityQuery LJHHKNNHAFE, out JobHandle HFMJMFJEAHK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x26A9C70", Offset = "0x26A8870", VA = "0x1826A9C70")]
		internal NativeArray<byte> AEPAJIGLOPI(NativeArray<Entity> MJFGMCFCBDM, BCFEJIFODGF GMPDMIJGEHC, JobHandle LIOENDEGGJH, out JobHandle NKBLFABEMGA, Allocator HGKGLCNFHPJ = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x26AB970", Offset = "0x26AA570", VA = "0x1826AB970")]
		internal JobHandle NFHAMCFLJEF(in EHHMIMOJCNN OAGMKJFIKKL, in BCFEJIFODGF GMPDMIJGEHC, NativeMultiHashMap<Entity, OMLJIMOKBJA> JDICCOGAIKG, JobHandle LIOENDEGGJH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x2573880", Offset = "0x2572480", VA = "0x182573880")]
		private JobHandle ICIPKACILEK(JobHandle ONHOLKNFCCC, JobHandle DLOOBECLIKO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x2573880", Offset = "0x2572480", VA = "0x182573880")]
		private JobHandle ICIPKACILEK(JobHandle ONHOLKNFCCC, JobHandle DLOOBECLIKO, JobHandle IGFGEELLPFL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		protected ComputePropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal abstract class JBJEBOPIGJO : PropagateTagsBase<global::CFLMDAHOOGL, global::IPHDBJNHIDO, JBJEBOPIGJO.LEDDLEKBPOL>
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public struct LEDDLEKBPOL : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x2366120", Offset = "0x2364D20", VA = "0x182366120")]
	protected JBJEBOPIGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x23660E0", Offset = "0x2364CE0", VA = "0x1823660E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal abstract class ONNJLEMOAEG : PropagateTagsBase<GAKOBEDNLHP, global::KADHOJFHADO, ONNJLEMOAEG.GFFJGOEELMN>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public struct GFFJGOEELMN : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x26B7BE0", Offset = "0x26B67E0", VA = "0x1826B7BE0")]
	protected ONNJLEMOAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x26B7BA0", Offset = "0x26B67A0", VA = "0x1826B7BA0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class KJEDEFGDMHA : FMDEGFFIOHG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct BJIKLKMAAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public NativeArray<int> array;

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		public BJIKLKMAAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
		internal void <OnUpdate>b__0(ref AuthoredLocalPoseData localPose)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct JEKJLLKDPKM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct MFBBEDLKIBP
		{
			[Cpp2IlInjected.Token(Token = "0x20000FE")]
			[NoAlias]
			public struct OPOGMLNCHHF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400034E")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData>.Runtime MBLGEELKKPM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData> NHLGCHCDGKF;

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x2378960", Offset = "0x2377560", VA = "0x182378960")]
			public void NKMFOFOBAPA(KJEDEFGDMHA BGEDHHBKNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x2378910", Offset = "0x2377510", VA = "0x182378910")]
			public OPOGMLNCHHF AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
			{
				return default(OPOGMLNCHHF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public NativeArray<int> LBLDONKHBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private MFBBEDLKIBP CGENFBJNHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MFBBEDLKIBP.OPOGMLNCHHF* ADICLHDIIDC;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KDFHADKIOEI;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JFKLCFCJPBP;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x2371290", Offset = "0x236FE90", VA = "0x182371290")]
		internal void KDPNCNEOCOC(ref AuthoredLocalPoseData MKFLJILLCAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x23714A0", Offset = "0x23700A0", VA = "0x1823714A0", Slot = "5")]
		public void ReadFromDisplayClass(ref BJIKLKMAAJA DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x23714B0", Offset = "0x23700B0", VA = "0x1823714B0", Slot = "6")]
		public void WriteToDisplayClass(ref BJIKLKMAAJA DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x2371210", Offset = "0x236FE10", VA = "0x182371210", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x2371390", Offset = "0x236FF90", VA = "0x182371390")]
		public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, [NoAlias] ref MFBBEDLKIBP.OPOGMLNCHHF DJNNMIKDINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x2371420", Offset = "0x2370020", VA = "0x182371420")]
		public void NKMFOFOBAPA(KJEDEFGDMHA BGEDHHBKNNK, ref BJIKLKMAAJA DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x23711B0", Offset = "0x236FDB0", VA = "0x1823711B0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void DPLLDFFOLDG(ArchetypeChunkIterator* IGAACBAHKGC, void* PFDJCNBMCPN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private EntityQuery KCBFOBNLPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private ProfilerMarker NLAGNCJFPPK;

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x23748B0", Offset = "0x23734B0", VA = "0x1823748B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public KJEDEFGDMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x23746D0", Offset = "0x23732D0", VA = "0x1823746D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x23745A0", Offset = "0x23731A0", VA = "0x1823745A0")]
	public static EntityQuery AHIELEFFCEF(ComponentSystemBase BGEDHHBKNNK)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public class IPBKPNEACJO : FMDEGFFIOHG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct OMMDMECKPIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		public OMMDMECKPIK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct JDEPDBHOAJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public EntityManager entityManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public OMMDMECKPIK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		public JDEPDBHOAJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct HHIFENCGDBB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct IMOBPJJLNHA
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct DAGEPLICIFH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400035C")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime NDGPFFGEEJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400035D")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointData>.Runtime CIBIJJOEMCN;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity BPCAGDMEHOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointData> FMJLILFHBIP;

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x236F3E0", Offset = "0x236DFE0", VA = "0x18236F3E0")]
			public void NKMFOFOBAPA(IPBKPNEACJO BGEDHHBKNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x236F360", Offset = "0x236DF60", VA = "0x18236F360")]
			public DAGEPLICIFH AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
			{
				return default(DAGEPLICIFH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public EntityManager EJMLDDGCGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public NativeList<Entity> BEGADEOJLLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private IMOBPJJLNHA CGENFBJNHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IMOBPJJLNHA.DAGEPLICIFH* ADICLHDIIDC;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KDFHADKIOEI;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JFKLCFCJPBP;

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x236A3F0", Offset = "0x2368FF0", VA = "0x18236A3F0")]
		internal void KDPNCNEOCOC(Entity OCMABEPCGDM, SplinePointData KFDINOECEFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x236A5D0", Offset = "0x23691D0", VA = "0x18236A5D0", Slot = "5")]
		public void ReadFromDisplayClass(ref JDEPDBHOAJJ DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x236A5E0", Offset = "0x23691E0", VA = "0x18236A5E0", Slot = "6")]
		public void WriteToDisplayClass(ref JDEPDBHOAJJ DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x236A350", Offset = "0x2368F50", VA = "0x18236A350", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x236A470", Offset = "0x2369070", VA = "0x18236A470")]
		public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, [NoAlias] ref IMOBPJJLNHA.DAGEPLICIFH DJNNMIKDINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x236A540", Offset = "0x2369140", VA = "0x18236A540")]
		public void NKMFOFOBAPA(IPBKPNEACJO BGEDHHBKNNK, ref JDEPDBHOAJJ DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x236A2F0", Offset = "0x2368EF0", VA = "0x18236A2F0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void DPLLDFFOLDG(ArchetypeChunkIterator* IGAACBAHKGC, void* PFDJCNBMCPN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private EntityQuery KCBFOBNLPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private ProfilerMarker NLAGNCJFPPK;

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x236F9C0", Offset = "0x236E5C0", VA = "0x18236F9C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public IPBKPNEACJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x236F7E0", Offset = "0x236E3E0", VA = "0x18236F7E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x236F6B0", Offset = "0x236E2B0", VA = "0x18236F6B0")]
	public static EntityQuery AHIELEFFCEF(ComponentSystemBase BGEDHHBKNNK)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public class PDFNICOJFHB : FMDEGFFIOHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private EntityQuery NICLBMKJMDC;

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x26B9D40", Offset = "0x26B8940", VA = "0x1826B9D40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x26B9DC0", Offset = "0x26B89C0", VA = "0x1826B9DC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public PDFNICOJFHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class BIOHNHBBAAL : FMDEGFFIOHG, HKFIKAGKAAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct BCKHGBIHLBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public NativeHashMap<GEGPJNFMCPG, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		public BCKHGBIHLBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct AOIJHEGKOME : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		private struct EICOCLJLKLH
		{
			[Cpp2IlInjected.Token(Token = "0x200010A")]
			public struct KNHAINFBIGI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000369")]
				public LambdaParameterValueProvider_Entity.Runtime NDGPFFGEEJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime IHMGGFLFDNH;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity BPCAGDMEHOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CLIOOEEOOEL;

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0x2637EC0", Offset = "0x2636AC0", VA = "0x182637EC0")]
			public void NKMFOFOBAPA(BIOHNHBBAAL BGEDHHBKNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x2637E40", Offset = "0x2636A40", VA = "0x182637E40")]
			public KNHAINFBIGI AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
			{
				return default(KNHAINFBIGI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public NativeHashMap<GEGPJNFMCPG, Entity> BBDNOECODFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private EICOCLJLKLH CGENFBJNHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe EICOCLJLKLH.KNHAINFBIGI* ADICLHDIIDC;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KDFHADKIOEI;

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2631080", Offset = "0x262FC80", VA = "0x182631080")]
		internal void KDPNCNEOCOC(Entity OCMABEPCGDM, ObjectNetworkIdComponentData FOGEKMCMCIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x23714A0", Offset = "0x23700A0", VA = "0x1823714A0", Slot = "5")]
		public void ReadFromDisplayClass(ref BCKHGBIHLBI DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x23714B0", Offset = "0x23700B0", VA = "0x1823714B0", Slot = "6")]
		public void WriteToDisplayClass(ref BCKHGBIHLBI DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2630FE0", Offset = "0x262FBE0", VA = "0x182630FE0", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2631100", Offset = "0x262FD00", VA = "0x182631100")]
		public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, ref EICOCLJLKLH.KNHAINFBIGI DJNNMIKDINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x26311B0", Offset = "0x262FDB0", VA = "0x1826311B0")]
		public void NKMFOFOBAPA(BIOHNHBBAAL BGEDHHBKNNK, ref BCKHGBIHLBI DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2630F80", Offset = "0x262FB80", VA = "0x182630F80")]
		public unsafe static void DPLLDFFOLDG(ArchetypeChunkIterator* IGAACBAHKGC, void* PFDJCNBMCPN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private ObjectNetworkToLocalMapService FBKDDNILPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private EntityQuery KCBFOBNLPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private ProfilerMarker NLAGNCJFPPK;

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x26332D0", Offset = "0x2631ED0", VA = "0x1826332D0", Slot = "14")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x26334E0", Offset = "0x26320E0", VA = "0x1826334E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public BIOHNHBBAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x2633330", Offset = "0x2631F30", VA = "0x182633330", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x26331A0", Offset = "0x2631DA0", VA = "0x1826331A0")]
	public static EntityQuery AHIELEFFCEF(ComponentSystemBase BGEDHHBKNNK)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Embodiment)]
	public class PostLoadInitializeEmbodiment : GDMMHGMPDDN, HKFIKAGKAAK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[CompilerGenerated]
		private struct BGKPIFNJHHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public NativeList<GEGPJNFMCPG> networkIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public BufferFromEntity<ChildrenData> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public ComponentDataFromEntity<SerializedEmbodiedData> embodiedFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> networkIdFromEntity;

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
			public BGKPIFNJHHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
			internal void <AddEmbodiedTopologically>b__0(Entity entity, ObjectNetworkIdComponentData component)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct DAJEKHIFCAH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200010E")]
			private struct CLFENCCEPOL
			{
				[Cpp2IlInjected.Token(Token = "0x200010F")]
				[NoAlias]
				public struct GFCEIPIMNFO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000382")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime NDGPFFGEEJN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000383")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime OOKIHOJABPP;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000380")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity BPCAGDMEHOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000381")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> GIJOOBGHFCB;

				[Cpp2IlInjected.Token(Token = "0x600077B")]
				[Cpp2IlInjected.Address(RVA = "0x237A250", Offset = "0x2378E50", VA = "0x18237A250")]
				public void NKMFOFOBAPA(PostLoadInitializeEmbodiment BGEDHHBKNNK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077C")]
				[Cpp2IlInjected.Address(RVA = "0x237A1D0", Offset = "0x2378DD0", VA = "0x18237A1D0")]
				public GFCEIPIMNFO AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
				{
					return default(GFCEIPIMNFO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeList<Entity> MJFGMCFCBDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public NativeList<GEGPJNFMCPG> CGCACBLIEKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public BufferFromEntity<ChildrenData> IHGFLLOKOKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public ComponentDataFromEntity<SerializedEmbodiedData> BENPGJGPMEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> JPKHBKFFFJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			private CLFENCCEPOL CGENFBJNHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe CLFENCCEPOL.GFCEIPIMNFO* ADICLHDIIDC;

			[Cpp2IlInjected.Token(Token = "0x400037E")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KDFHADKIOEI;

			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JFKLCFCJPBP;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x237A5B0", Offset = "0x23791B0", VA = "0x18237A5B0")]
			internal void KDPNCNEOCOC(Entity OCMABEPCGDM, ObjectNetworkIdComponentData DGHFPMGLNEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x237A420", Offset = "0x2379020", VA = "0x18237A420")]
			internal void DFDKCOPLIHM(Entity OCMABEPCGDM, ObjectNetworkIdComponentData DGHFPMGLNEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x237A690", Offset = "0x2379290", VA = "0x18237A690")]
			internal void NIIOANLJHGK(Entity OCMABEPCGDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x237A850", Offset = "0x2379450", VA = "0x18237A850", Slot = "5")]
			public void ReadFromDisplayClass(ref BGKPIFNJHHH DDKABHBJHOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x237A8A0", Offset = "0x23794A0", VA = "0x18237A8A0", Slot = "6")]
			public void WriteToDisplayClass(ref BGKPIFNJHHH DDKABHBJHOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x237A500", Offset = "0x2379100", VA = "0x18237A500", Slot = "4")]
			public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x237A5E0", Offset = "0x23791E0", VA = "0x18237A5E0")]
			public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, [NoAlias] ref CLFENCCEPOL.GFCEIPIMNFO DJNNMIKDINL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x237A7C0", Offset = "0x23793C0", VA = "0x18237A7C0")]
			public void NKMFOFOBAPA(PostLoadInitializeEmbodiment BGEDHHBKNNK, ref BGKPIFNJHHH DDKABHBJHOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x237A4A0", Offset = "0x23790A0", VA = "0x18237A4A0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void DPLLDFFOLDG(ArchetypeChunkIterator* IGAACBAHKGC, void* PFDJCNBMCPN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private EntityQuery MIMPMMOPFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private JDDPPIAFHCO NOMIILNDOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private PNPPGDJCNCL LCAGHKIOCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private DLIOKHGJHNN NGCBDOCNCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private EntityQuery OGAICPGOLAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private ProfilerMarker PECGBBJDNOP;

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2386050", Offset = "0x2384C50", VA = "0x182386050", Slot = "14")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x23861E0", Offset = "0x2384DE0", VA = "0x1823861E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2386260", Offset = "0x2384E60", VA = "0x182386260", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2385830", Offset = "0x2384430", VA = "0x182385830")]
		private void BIIGOKDGCNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2385CD0", Offset = "0x23848D0", VA = "0x182385CD0")]
		private NativeArray<GLIHGKJNDBF> IMIAKEBIAHN(NativeArray<GEGPJNFMCPG> CGCACBLIEKG)
		{
			return default(NativeArray<GLIHGKJNDBF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x23862F0", Offset = "0x2384EF0", VA = "0x1823862F0")]
		private void PAHAFCNJNJM(NativeList<Entity> MJFGMCFCBDM, NativeList<GEGPJNFMCPG> CGCACBLIEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x23856B0", Offset = "0x23842B0", VA = "0x1823856B0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void AKFEEKLBEOH(NativeList<GEGPJNFMCPG> CGCACBLIEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		private static void KNCGDDBBPBO(NativeList<GEGPJNFMCPG> CGCACBLIEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		public PostLoadInitializeEmbodiment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x23860E0", Offset = "0x2384CE0", VA = "0x1823860E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2385B10", Offset = "0x2384710", VA = "0x182385B10")]
		public static EntityQuery CIHHJINJFGB(ComponentSystemBase BGEDHHBKNNK)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public class LNJFJAIJLBE : GDMMHGMPDDN, HKFIKAGKAAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct BIGHLOKKOCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public NativeHashMap<GEGPJNFMCPG, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		public BIGHLOKKOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2364380", Offset = "0x2362F80", VA = "0x182364380")]
		internal void <OnUpdate>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct KEDNFKAABHL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct KBCMCGOCJDG
		{
			[Cpp2IlInjected.Token(Token = "0x2000114")]
			[NoAlias]
			public struct FLIKAPAKNFD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000390")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime NDGPFFGEEJN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000391")]
				[NoAlias]
				public LambdaParameterValueProvider_EntityInQueryIndex.Runtime JNHKFGAFPNJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000392")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime IHMGGFLFDNH;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity BPCAGDMEHOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_EntityInQueryIndex KGKIOLEKCPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CLIOOEEOOEL;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x2373560", Offset = "0x2372160", VA = "0x182373560")]
			public void NKMFOFOBAPA(LNJFJAIJLBE BGEDHHBKNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x23734A0", Offset = "0x23720A0", VA = "0x1823734A0")]
			public FLIKAPAKNFD AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
			{
				return default(FLIKAPAKNFD);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public NativeHashMap<GEGPJNFMCPG, Entity> BBDNOECODFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private KBCMCGOCJDG CGENFBJNHDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KBCMCGOCJDG.FLIKAPAKNFD* ADICLHDIIDC;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KDFHADKIOEI;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate JFKLCFCJPBP;

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x23743B0", Offset = "0x2372FB0", VA = "0x1823743B0")]
		internal void KDPNCNEOCOC(Entity OCMABEPCGDM, int DHFEBIGDPFN, ref ObjectNetworkIdComponentData FOGEKMCMCIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x23714A0", Offset = "0x23700A0", VA = "0x1823714A0", Slot = "5")]
		public void ReadFromDisplayClass(ref BIGHLOKKOCM DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x23714B0", Offset = "0x23700B0", VA = "0x1823714B0", Slot = "6")]
		public void WriteToDisplayClass(ref BIGHLOKKOCM DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x23742C0", Offset = "0x2372EC0", VA = "0x1823742C0", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x2374440", Offset = "0x2373040", VA = "0x182374440")]
		public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, [NoAlias] ref KBCMCGOCJDG.FLIKAPAKNFD DJNNMIKDINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x2374500", Offset = "0x2373100", VA = "0x182374500")]
		public void NKMFOFOBAPA(LNJFJAIJLBE BGEDHHBKNNK, ref BIGHLOKKOCM DDKABHBJHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x2374260", Offset = "0x2372E60", VA = "0x182374260")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void DPLLDFFOLDG(ArchetypeChunkIterator* IGAACBAHKGC, void* PFDJCNBMCPN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private ObjectNetworkToLocalMapService FBKDDNILPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private EntityQuery KCBFOBNLPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private ProfilerMarker NLAGNCJFPPK;

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x2375C90", Offset = "0x2374890", VA = "0x182375C90", Slot = "14")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x2375ED0", Offset = "0x2374AD0", VA = "0x182375ED0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public LNJFJAIJLBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x2375CF0", Offset = "0x23748F0", VA = "0x182375CF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x2375B60", Offset = "0x2374760", VA = "0x182375B60")]
	public static EntityQuery AHIELEFFCEF(ComponentSystemBase BGEDHHBKNNK)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public class JBHPFLDJLBM : GDMMHGMPDDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private EntityQuery MIMPMMOPFGN;

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x236FD20", Offset = "0x236E920", VA = "0x18236FD20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x236FDA0", Offset = "0x236E9A0", VA = "0x18236FDA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public JBHPFLDJLBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public class GHHIDMJPNEC : GDMMHGMPDDN, HKFIKAGKAAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private BHBECLCNBCK JFAHNIMFMGP;

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x2367760", Offset = "0x2366360", VA = "0x182367760", Slot = "14")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x23677C0", Offset = "0x23663C0", VA = "0x1823677C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x2367590", Offset = "0x2366190", VA = "0x182367590")]
	private void EHBJEPKPLAM(NativeList<EntityArchetype> PFOFBDLLIDM, NativeHashMap<int, CLMGAOKFIAE> OCCODBOKGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x2366F50", Offset = "0x2365B50", VA = "0x182366F50")]
	private void BPBCDDINLIF(NativeHashMap<int, CLMGAOKFIAE> OCCODBOKGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public GHHIDMJPNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x2367450", Offset = "0x2366050", VA = "0x182367450")]
	[CompilerGenerated]
	internal static Span<int> EDJJOHBCCGJ(EntityArchetype FMENGPOHLND)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Serialization)]
	public class PreSerializeRemoveEntities : GDMMHGMPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private static LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery MIJEBGPCHHG;

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x2386520", Offset = "0x2385120", VA = "0x182386520", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x2386740", Offset = "0x2385340", VA = "0x182386740", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[NFGOFKINMIG]
[ExecuteAlways]
[UpdateInGroup(typeof(NNGMJKHEMLP))]
internal sealed class BHBDHBMOGPE : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public BHBDHBMOGPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[NFGOFKINMIG]
[UpdateAfter(typeof(BHBDHBMOGPE))]
[UpdateInGroup(typeof(NNGMJKHEMLP))]
internal sealed class MJJJOFKFKII : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public MJJJOFKFKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[ExecuteAlways]
[NFGOFKINMIG]
[UpdateInGroup(typeof(FHLDCJIMBAF))]
internal sealed class BEDOOBMFEGD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public BEDOOBMFEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[ExecuteAlways]
[NFGOFKINMIG]
[UpdateInGroup(typeof(KLDIMHIKONI))]
internal sealed class FCIGHIFMGMN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public FCIGHIFMGMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
[NFGOFKINMIG]
[ExecuteAlways]
[UpdateInGroup(typeof(PADMAICGBGP))]
internal sealed class GMNHNGCMLMH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public GMNHNGCMLMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
[NFGOFKINMIG]
[ExecuteAlways]
[UpdateInGroup(typeof(EDCAHLMDKIK))]
internal sealed class BPPCEIDMAPA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public BPPCEIDMAPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[NFGOFKINMIG]
[ExecuteAlways]
[UpdateInGroup(typeof(SimulationSystemGroup))]
internal sealed class MNGBJPKABJN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public MNGBJPKABJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
[NFGOFKINMIG]
[ExecuteAlways]
[UpdateInGroup(typeof(LHBFAJLGMFC))]
internal sealed class MNDKDAMDNIL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public MNDKDAMDNIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[ExecuteAlways]
[NFGOFKINMIG]
[UpdateInGroup(typeof(SimulationSystemGroup))]
internal sealed class DDFLCIKFHOD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public DDFLCIKFHOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataFromGameObjects : GDMMHGMPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct EKLELFJEDDP : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private const float NODJFLIFBKC = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public NativeArray<Entity> MJFGMCFCBDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> NEBNFJLNHOD;

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x26AFE60", Offset = "0x26AEA60", VA = "0x1826AFE60", Slot = "4")]
			public void Execute(int HIANDEDCLIF, TransformAccess BHPNFBEEMHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x26B00B0", Offset = "0x26AECB0", VA = "0x1826B00B0")]
			private bool KBKPNMNOONN(float3 DIPKCPLHHFM, float3 HKEHKHLKJGF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x26AFE30", Offset = "0x26AEA30", VA = "0x1826AFE30")]
			private bool DDCIELDGKDG(quaternion DIPKCPLHHFM, quaternion HKEHKHLKJGF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x26B0140", Offset = "0x26AED40", VA = "0x1826B0140")]
			private static bool NPFFMOBCIGL(float3 FNKIIBFNLFB, float3 EDLPJGEPJPK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x26B0100", Offset = "0x26AED00", VA = "0x1826B0100")]
			private static bool NPFFMOBCIGL(quaternion EHGLDEHJCJA, quaternion POGMGOCOOHC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x26B0050", Offset = "0x26AEC50", VA = "0x1826B0050")]
			private static bool HCHAOKKHIAK(float DJICDBBPIKE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x26B0060", Offset = "0x26AEC60", VA = "0x1826B0060")]
			private static float IBCGCEOMPKC(quaternion EBJICHJEKAB, quaternion FGLPNLCIOKH)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct HHNABPJCHEB : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			[ReadOnly]
			public NativeArray<Entity> MJFGMCFCBDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> ILGHAODAHMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> NMLOMLKGINL;

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x26B2990", Offset = "0x26B1590", VA = "0x1826B2990", Slot = "4")]
			public void Execute(int HIANDEDCLIF, TransformAccess BHPNFBEEMHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private const string HPMGJKLNLBN = "Pose";

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private const string JOFCPBLCJMF = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private const string DAFEFAAHBJO = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private static readonly ProfilerMarker MFJIHEMEFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private RegisterTransforms AFFOJOLDOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TransformAccessArray AONPIDEMEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private BHBECLCNBCK NJMNPDHNNLL;

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x26AEAB0", Offset = "0x26AD6B0", VA = "0x1826AEAB0")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x26AEB10", Offset = "0x26AD710", VA = "0x1826AEB10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x26AEB80", Offset = "0x26AD780", VA = "0x1826AEB80", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x26AEBF0", Offset = "0x26AD7F0", VA = "0x1826AEBF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.TransformSyncing)]
	public class RegisterTransforms : GDMMHGMPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct MNNOKKABALL : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000127")]
			private struct CMJCCHKPJEL
			{
				[Cpp2IlInjected.Token(Token = "0x2000128")]
				public struct FJAJIFMLHKD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003B7")]
					public LambdaParameterValueProvider_Entity.Runtime NDGPFFGEEJN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003B8")]
					public LambdaParameterValueProvider_IComponentData<DAJBKHGJPKB>.Runtime HFGFDJCFGLF;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40003B9")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime FHEGIAEDLGA;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity BPCAGDMEHOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003B5")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<DAJBKHGJPKB> JDJPMHPJAKA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003B6")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> LEAEHNHMJJN;

				[Cpp2IlInjected.Token(Token = "0x60007D6")]
				[Cpp2IlInjected.Address(RVA = "0x237A3A0", Offset = "0x2378FA0", VA = "0x18237A3A0")]
				public void NKMFOFOBAPA(RegisterTransforms BGEDHHBKNNK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007D7")]
				[Cpp2IlInjected.Address(RVA = "0x237A2B0", Offset = "0x2378EB0", VA = "0x18237A2B0")]
				public FJAJIFMLHKD AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
				{
					return default(FJAJIFMLHKD);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			private CMJCCHKPJEL CGENFBJNHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe CMJCCHKPJEL.FJAJIFMLHKD* ADICLHDIIDC;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KDFHADKIOEI;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x237DA50", Offset = "0x237C650", VA = "0x18237DA50")]
			internal void KDPNCNEOCOC(Entity OCMABEPCGDM, DAJBKHGJPKB BPPENCELOKN, Transform BHPNFBEEMHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x237D9C0", Offset = "0x237C5C0", VA = "0x18237D9C0", Slot = "4")]
			public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x237DB30", Offset = "0x237C730", VA = "0x18237DB30")]
			public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, ref CMJCCHKPJEL.FJAJIFMLHKD DJNNMIKDINL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x237DC00", Offset = "0x237C800", VA = "0x18237DC00")]
			public void NKMFOFOBAPA(RegisterTransforms BGEDHHBKNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0x237D960", Offset = "0x237C560", VA = "0x18237D960")]
			public unsafe static void DPLLDFFOLDG(ArchetypeChunkIterator* IGAACBAHKGC, void* PFDJCNBMCPN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000129")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct JCHDOIFKBID : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200012A")]
			private struct JCCOLMDALIB
			{
				[Cpp2IlInjected.Token(Token = "0x200012B")]
				[NoAlias]
				public struct JIIAECKPIHC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003BE")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime NDGPFFGEEJN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003BF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<DAJBKHGJPKB>.Runtime HFGFDJCFGLF;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003BC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity BPCAGDMEHOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003BD")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<DAJBKHGJPKB> JDJPMHPJAKA;

				[Cpp2IlInjected.Token(Token = "0x60007DC")]
				[Cpp2IlInjected.Address(RVA = "0x237BF40", Offset = "0x237AB40", VA = "0x18237BF40")]
				public void NKMFOFOBAPA(RegisterTransforms BGEDHHBKNNK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007DD")]
				[Cpp2IlInjected.Address(RVA = "0x237BEC0", Offset = "0x237AAC0", VA = "0x18237BEC0")]
				public JIIAECKPIHC AEKKHODLMIP(ref ArchetypeChunk ACHMFLNPBNO, int IHLNMDKHPFG, int DMAANCGHNIK)
				{
					return default(JIIAECKPIHC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			private JCCOLMDALIB CGENFBJNHDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe JCCOLMDALIB.JIIAECKPIHC* ADICLHDIIDC;

			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0x237C040", Offset = "0x237AC40", VA = "0x18237C040")]
			internal void KDPNCNEOCOC(Entity OCMABEPCGDM, DAJBKHGJPKB BPPENCELOKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0x237BFA0", Offset = "0x237ABA0", VA = "0x18237BFA0", Slot = "4")]
			public void Execute(ArchetypeChunk JMFDNAKFNAC, int MCGABOLBBIM, int DHDCHJKECGP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0x237C100", Offset = "0x237AD00", VA = "0x18237C100")]
			public void LONNBPMNJAC(ref ArchetypeChunk JMFDNAKFNAC, [NoAlias] ref JCCOLMDALIB.JIIAECKPIHC DJNNMIKDINL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DB")]
			[Cpp2IlInjected.Address(RVA = "0x237BF40", Offset = "0x237AB40", VA = "0x18237BF40")]
			public void NKMFOFOBAPA(RegisterTransforms BGEDHHBKNNK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private LGKODEBJIHG MJJAEMLFAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private AJMOBODEMMA FLOFDFFIAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private EntityQuery JLLDLDCEHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private EntityQuery HPBIPIHIBPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private EntityQuery IELGJJNIKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private EntityQuery CBCMJABBEBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private ProfilerMarker KNFBIALLBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private EntityQuery LFKLOIOMAJC;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public AJMOBODEMMA NAAEFOBBPJP
		{
			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x903690", Offset = "0x902290", VA = "0x180903690")]
			get
			{
				return default(AJMOBODEMMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x2389310", Offset = "0x2387F10", VA = "0x182389310", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x23894A0", Offset = "0x23880A0", VA = "0x1823894A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x23894B0", Offset = "0x23880B0", VA = "0x1823894B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x2389B50", Offset = "0x2388750", VA = "0x182389B50")]
		private void PCGNMGHLCOG(NativeArray<Entity> MJFGMCFCBDM, AJMOBODEMMA CLOJHFLDMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x2388A20", Offset = "0x2387620", VA = "0x182388A20")]
		[BurstCompile]
		internal static void BCBGEBOBDGK(NativeArray<DAJBKHGJPKB> IJPDIDIPJOP, ComponentDataFromEntity<DAJBKHGJPKB> BFLBBOBHBDC, AJMOBODEMMA CLOJHFLDMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		private static void IPACILPIFGO(Transform BHPNFBEEMHL, Entity OCMABEPCGDM, int HIANDEDCLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		private static void IJFPPOKIJGD(Entity OCMABEPCGDM, int HIANDEDCLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		private static void JCOJDIFKJDJ(int HIANDEDCLIF, AJMOBODEMMA CLOJHFLDMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x2389950", Offset = "0x2388550", VA = "0x182389950")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void PCEFBOMBGIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x2388FD0", Offset = "0x2387BD0", VA = "0x182388FD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x2388E70", Offset = "0x2387A70", VA = "0x182388E70")]
		public static EntityQuery MPKCJJGPBNE(ComponentSystemBase BGEDHHBKNNK)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x2388CE0", Offset = "0x23878E0", VA = "0x182388CE0")]
		public static EntityQuery MHICLKCHJOG(ComponentSystemBase BGEDHHBKNNK)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataToGameObjects : GDMMHGMPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		[BurstCompile]
		private struct GHHCJCNJHBJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> NEBNFJLNHOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			[ReadOnly]
			public NativeArray<Entity> MJFGMCFCBDM;

			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x26B2390", Offset = "0x26B0F90", VA = "0x1826B2390", Slot = "4")]
			public void Execute(int HIANDEDCLIF, TransformAccess BHPNFBEEMHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct OAAPNHHMAFL : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> ILGHAODAHMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			[ReadOnly]
			public NativeArray<Entity> MJFGMCFCBDM;

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x26B5160", Offset = "0x26B3D60", VA = "0x1826B5160", Slot = "4")]
			public void Execute(int HIANDEDCLIF, TransformAccess BHPNFBEEMHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012F")]
		[BurstCompile]
		private struct OPFBPPJIAAL : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> ILGHAODAHMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> NMLOMLKGINL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			[ReadOnly]
			public NativeArray<Entity> MJFGMCFCBDM;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x26B7D80", Offset = "0x26B6980", VA = "0x1826B7D80", Slot = "4")]
			public void Execute(int HIANDEDCLIF, TransformAccess BHPNFBEEMHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private const string HPMGJKLNLBN = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private const string JOFCPBLCJMF = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private const string DAFEFAAHBJO = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private static readonly LJFAOMOPGNF ECGNMMCGNDD;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private static readonly LJFAOMOPGNF KMCCNMLKLKK;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private static readonly LJFAOMOPGNF KOPDPCPMDIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private NOKELFOLDGP AFFOJOLDOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private JobHandle MFDAOACAOPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery NBDKNGBEHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private EntityQuery AHNNBJMGKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private EntityQuery LGPHMBNCNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private TransformAccessArray PJFFLCGIMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TransformAccessArray DCKBFCEFEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TransformAccessArray NAJFGCJBPDN;

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x26AF0E0", Offset = "0x26ADCE0", VA = "0x1826AF0E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x26AF2F0", Offset = "0x26ADEF0", VA = "0x1826AF2F0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x8FDA50", Offset = "0x8FC650", VA = "0x1808FDA50")]
		internal JobHandle ALOHKODBDNH()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x26AF330", Offset = "0x26ADF30", VA = "0x1826AF330", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0x26AEF50", Offset = "0x26ADB50", VA = "0x1826AEF50")]
		private NativeArray<Entity> KCPLDPNKBPP(NativeArray<DAJBKHGJPKB> KDDCEBHGJHK, NativeList<Entity> PFCNIGLGCGA, TransformAccessArray KCEAJDOBDON, TransformAccessArray KHMLGELCOAL)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public class MBAGBKMIAKA : GDMMHGMPDDN, GEPKKGPMACB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private MEPFJBJLAPB PAKABGINJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private ACAEIGFMODO IMIIFABFDDB;

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x23762D0", Offset = "0x2374ED0", VA = "0x1823762D0", Slot = "14")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x23763B0", Offset = "0x2374FB0", VA = "0x1823763B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x2376060", Offset = "0x2374C60", VA = "0x182376060")]
	private static void ACANIJKCPFP(EntityManager EJMLDDGCGJO, Entity OCMABEPCGDM, Entity MKOLBPGKLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x23761F0", Offset = "0x2374DF0", VA = "0x1823761F0")]
	private static Transform IBILDJBADNC(EntityManager EJMLDDGCGJO, Entity OCMABEPCGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public MBAGBKMIAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.TransformSyncing)]
	public class L2PToL2WHierarchy : GDMMHGMPDDN
	{
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		[BurstCompile]
		private struct MJCCJHOKMIG : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> KAAHKJHGIJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> DEJOBFCAOCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> BPCFEBIHNPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> KLOFILGNLBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public ArchetypeChunkComponentType<LocalToWorldData> GMIFGICMLJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> INBLGCECAJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public uint CNBOOFGEIHA;

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x237D220", Offset = "0x237BE20", VA = "0x18237D220")]
			[Conditional("DEBUG_BUILD")]
			private void BKOLJCCIEEF(Entity OCMABEPCGDM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x237D2C0", Offset = "0x237BEC0", VA = "0x18237D2C0", Slot = "4")]
			public void Execute(ArchetypeChunk JMFDNAKFNAC, int HIANDEDCLIF, int FBADGICHEEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x237D5A0", Offset = "0x237C1A0", VA = "0x18237D5A0")]
			private bool PKPOAPJFGGA(ArchetypeChunk JMFDNAKFNAC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x237CED0", Offset = "0x237BAD0", VA = "0x18237CED0")]
			private void ADKGHNEKKNN(float4x4 MEMCCBHIAJB, Entity OCMABEPCGDM, bool EKLEMAHFFMM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery PNKDCHKDCAK;

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x237C5F0", Offset = "0x237B1F0", VA = "0x18237C5F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x237C680", Offset = "0x237B280", VA = "0x18237C680", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
public class KBKMGEOAHAJ : NPPAKIFENEO
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[BurstCompile]
	private struct GHGOKPGAGBN : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> KAAHKJHGIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public ArchetypeChunkComponentType<LocalToWorldData> GMIFGICMLJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public uint CNBOOFGEIHA;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x2366DC0", Offset = "0x23659C0", VA = "0x182366DC0", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int HIANDEDCLIF, int FBADGICHEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2366ED0", Offset = "0x2365AD0", VA = "0x182366ED0")]
		public bool PKPOAPJFGGA(ArchetypeChunk JMFDNAKFNAC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private EntityQuery PNKDCHKDCAK;

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x23735D0", Offset = "0x23721D0", VA = "0x1823735D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x23736D0", Offset = "0x23722D0", VA = "0x1823736D0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle AKMHODPNCMG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public KBKMGEOAHAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
public class AHLJKFLAHGJ : NPPAKIFENEO
{
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[BurstCompile]
	private struct PPFGPKGNKBA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> BPJBNLHGFHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public ArchetypeChunkComponentType<WorldPoseData> LGJFEFENFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> OGNALCADKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> IDLHDDIOGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public uint CNBOOFGEIHA;

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x263E770", Offset = "0x263D370", VA = "0x18263E770", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int HIANDEDCLIF, int FBADGICHEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x263EB10", Offset = "0x263D710", VA = "0x18263EB10")]
		public bool PKPOAPJFGGA(ArchetypeChunk JMFDNAKFNAC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private EntityQuery NGCBDOCNCGO;

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x262FAC0", Offset = "0x262E6C0", VA = "0x18262FAC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x262FBB0", Offset = "0x262E7B0", VA = "0x18262FBB0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle AKMHODPNCMG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public AHLJKFLAHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
public class INEFEDELCCC : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[BurstCompile]
	private struct DLNDPCGFBEI : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> CLJOPCNBAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> PHPEMLCBAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> BPOFCEKCFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public ArchetypeChunkComponentType<LocalToParentData> JOPKHJIPGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public uint CNBOOFGEIHA;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x2365810", Offset = "0x2364410", VA = "0x182365810", Slot = "4")]
		public void Execute(ArchetypeChunk JMFDNAKFNAC, int HIANDEDCLIF, int FBADGICHEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x2365CC0", Offset = "0x23648C0", VA = "0x182365CC0")]
		public bool PKPOAPJFGGA(ArchetypeChunk JMFDNAKFNAC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private EntityQuery NGCBDOCNCGO;

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x236F440", Offset = "0x236E040", VA = "0x18236F440", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x236F550", Offset = "0x236E150", VA = "0x18236F550", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle AKMHODPNCMG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0")]
	public INEFEDELCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal abstract class LMOJOKAAIFJ : PropagateTagsBase<global::PDHADMJJNEP, global::KADJJKJODIN, LMOJOKAAIFJ.JHMCEDFNMCH>
{
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	public struct JHMCEDFNMCH : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x2375B00", Offset = "0x2374700", VA = "0x182375B00")]
	protected LMOJOKAAIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0x2375AC0", Offset = "0x23746C0", VA = "0x182375AC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[BKKFDCFMCDO(FLELDCIJFOA.Game)]
public class NEDDOLFIHDN : LHFFACOBHNF
{
	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public Type FOKNLFKLHED
	{
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x26B3EE0", Offset = "0x26B2AE0", VA = "0x1826B3EE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public Type[] CAPGDNEBHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x26B3F40", Offset = "0x26B2B40", VA = "0x1826B3F40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public NEDDOLFIHDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
[BKKFDCFMCDO(FLELDCIJFOA.Loading)]
public class JDDNLNCHAED : LHFFACOBHNF
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Type FOKNLFKLHED
	{
		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x619E80", Offset = "0x618A80", VA = "0x180619E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Type[] CAPGDNEBHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x236FE30", Offset = "0x236EA30", VA = "0x18236FE30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public JDDNLNCHAED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public sealed class OLFFFPABCHF : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public OLFFFPABCHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(OLFFFPABCHF))]
public sealed class AJOMDDICCJL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public AJOMDDICCJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
[NFGOFKINMIG]
[UpdateAfter(typeof(AJOMDDICCJL))]
[UpdateInGroup(typeof(OLFFFPABCHF))]
public sealed class OIAPGNOGFKL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public OIAPGNOGFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
[BKKFDCFMCDO(FLELDCIJFOA.Saving)]
public class NAFMEJIBMJI : LHFFACOBHNF
{
	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public Type FOKNLFKLHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x619E80", Offset = "0x618A80", VA = "0x180619E80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Type[] CAPGDNEBHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x26B37D0", Offset = "0x26B23D0", VA = "0x1826B37D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public NAFMEJIBMJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class OPLKEHAEBBL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public OPLKEHAEBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
[BKKFDCFMCDO(FLELDCIJFOA.Simulation)]
public class IKDIOBPFCGM : LHFFACOBHNF
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Type FOKNLFKLHED
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x236F0E0", Offset = "0x236DCE0", VA = "0x18236F0E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Type[] CAPGDNEBHCK
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x236F140", Offset = "0x236DD40", VA = "0x18236F140", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public IKDIOBPFCGM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Connectables, new string[] { "Callbacks" })]
	[MHBJLGEIMOG(typeof(DDKELKICOBG), new string[] { })]
	internal class ConnectableService : DDKELKICOBG, HKFIKAGKAAK, GEPKKGPMACB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		[CompilerGenerated]
		private sealed class KHOFJIJNFAD : IEnumerable<OLACMNNNFCK>, IEnumerable, IEnumerator<OLACMNNNFCK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			private OLACMNNNFCK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			private OLACMNNNFCK localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public OLACMNNNFCK <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x170000EB")]
			private OLACMNNNFCK System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000845")]
				[Cpp2IlInjected.Address(RVA = "0x5ED000", Offset = "0x5EBC00", VA = "0x1805ED000", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(OLACMNNNFCK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EC")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000847")]
				[Cpp2IlInjected.Address(RVA = "0x26B3610", Offset = "0x26B2210", VA = "0x1826B3610", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0xA157D0", Offset = "0xA143D0", VA = "0x180A157D0")]
			[DebuggerHidden]
			public KHOFJIJNFAD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0x26B3660", Offset = "0x26B2260", VA = "0x1826B3660", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000842")]
			[Cpp2IlInjected.Address(RVA = "0x26B3270", Offset = "0x26B1E70", VA = "0x1826B3270", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000843")]
			[Cpp2IlInjected.Address(RVA = "0x26B3750", Offset = "0x26B2350", VA = "0x1826B3750")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0x26B3790", Offset = "0x26B2390", VA = "0x1826B3790")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(RVA = "0x26B35C0", Offset = "0x26B21C0", VA = "0x1826B35C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0x26B3510", Offset = "0x26B2110", VA = "0x1826B3510", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<OLACMNNNFCK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0x26B3510", Offset = "0x26B2110", VA = "0x1826B3510", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private const string HMNKPHEJHGF = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly LJFAOMOPGNF GBFAHFKFDIM;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public const int JHLCCNDMHCC = 0;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public const int FEFEOMJDALF = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private PNPPGDJCNCL LCAGHKIOCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private DLIOKHGJHNN NGCBDOCNCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private BHBECLCNBCK JFAHNIMFMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private JDDPPIAFHCO NOMIILNDOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private PropertyEventCallbacksService BFLBJHJBHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private global::IFAHEBIDIGM<AuthoredParentData, LDLGNIMIDMK, FPCEGCFLDMM, AuthoredChildrenData> AHCNMPAMPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private global::OPNPNKDOEBI<Entity> OOBBJCDMBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private global::OPNPNKDOEBI<float3> FGDIPMEMAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private global::OPNPNKDOEBI<quaternion> LPPLLEMLGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private global::OPNPNKDOEBI<Entity> MKOLBPGKLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private global::OPNPNKDOEBI<float3> BDAEFIHNJEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private global::OPNPNKDOEBI<quaternion> IBJBIKHAMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private HashSet<Entity> OEPJKIGEOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private HashSet<Entity> NBCMNCEILEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private EntityQuery COBDAEMANNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private bool JMNCCKFMNPP;

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public Func<KEMNBMLDFFK> MNIIEBPOOEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0x610700", Offset = "0x60F300", VA = "0x180610700", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000829")]
			[Cpp2IlInjected.Address(RVA = "0x5FE260", Offset = "0x5FCE60", VA = "0x1805FE260", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<OLACMNNNFCK, OLACMNNNFCK> LDBKMKINJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0x26AD190", Offset = "0x26ABD90", VA = "0x1826AD190", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0x26ACBC0", Offset = "0x26AB7C0", VA = "0x1826ACBC0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<OLACMNNNFCK, OLACMNNNFCK> PKKAFMNIEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x26AE280", Offset = "0x26ACE80", VA = "0x1826AE280", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0x26AD6B0", Offset = "0x26AC2B0", VA = "0x1826AD6B0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<OLACMNNNFCK, OLACMNNNFCK, OLACMNNNFCK> AOBHNMEAKIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0x26ADB80", Offset = "0x26AC780", VA = "0x1826ADB80", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0x26ACE20", Offset = "0x26ABA20", VA = "0x1826ACE20", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<OLACMNNNFCK> AEKMLOCMLEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0x26ACEC0", Offset = "0x26ABAC0", VA = "0x1826ACEC0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000827")]
			[Cpp2IlInjected.Address(RVA = "0x26AD230", Offset = "0x26ABE30", VA = "0x1826AD230", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x26AE590", Offset = "0x26AD190", VA = "0x1826AE590", Slot = "23")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x26ADE50", Offset = "0x26ACA50", VA = "0x1826ADE50", Slot = "24")]
		public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x26AD000", Offset = "0x26ABC00", VA = "0x1826AD000", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x26AD750", Offset = "0x26AC350", VA = "0x1826AD750")]
		private void HPPCCOIOKBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x26AE6B0", Offset = "0x26AD2B0", VA = "0x1826AE6B0")]
		private void OMPDLOJMPPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x26AD7B0", Offset = "0x26AC3B0", VA = "0x1826AD7B0")]
		private void IDCHCLDDANC(Entity OCMABEPCGDM, LOGKGBLPOOD IPGOEGFNLNJ, CJHLIFJIIDK HKEHKHLKJGF, CJHLIFJIIDK DIPKCPLHHFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x26AD2D0", Offset = "0x26ABED0", VA = "0x1826AD2D0")]
		private void FKNAEPOIFKB(Entity OCMABEPCGDM, LOGKGBLPOOD IPGOEGFNLNJ, CJHLIFJIIDK HKEHKHLKJGF, CJHLIFJIIDK DIPKCPLHHFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x2573880", Offset = "0x2572480", VA = "0x182573880", Slot = "14")]
		public OLACMNNNFCK PMIBDGIMMJC(OLACMNNNFCK AIJKIAIKFDH, int IJDEIMGEPFP)
		{
			return default(OLACMNNNFCK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x103D5C0", Offset = "0x103C1C0", VA = "0x18103D5C0", Slot = "15")]
		public Color GFNCNKCBLKG(OLACMNNNFCK AIJKIAIKFDH, int IJDEIMGEPFP)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x26AE320", Offset = "0x26ACF20", VA = "0x1826AE320", Slot = "16")]
		public float3 NHJKHKDNJJK(OLACMNNNFCK AIJKIAIKFDH, int IJDEIMGEPFP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x26ADD80", Offset = "0x26AC980", VA = "0x1826ADD80", Slot = "17")]
		public void KMBIIDLEBDG(OLACMNNNFCK AIJKIAIKFDH, OLACMNNNFCK AJCFEJDFIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x26ACF60", Offset = "0x26ABB60", VA = "0x1826ACF60", Slot = "18")]
		public OLACMNNNFCK DPNLFEGJALJ(OLACMNNNFCK AIJKIAIKFDH)
		{
			return default(OLACMNNNFCK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x26AD330", Offset = "0x26ABF30", VA = "0x1826AD330", Slot = "21")]
		public void FOINGKPDIGF(OLACMNNNFCK AIJKIAIKFDH, Vector3 EOBGKFKPJNE, Quaternion GPJEIMOFPOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x26ADC20", Offset = "0x26AC820", VA = "0x1826ADC20", Slot = "26")]
		public (Vector3, Quaternion) JKBHFCBPJEJ(OLACMNNNFCK AIJKIAIKFDH)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x26AE800", Offset = "0x26AD400", VA = "0x1826AE800", Slot = "27")]
		public (Vector3, Quaternion) PBOKMGLMJHA(OLACMNNNFCK AIJKIAIKFDH)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x26ACC60", Offset = "0x26AB860", VA = "0x1826ACC60", Slot = "22")]
		public (Vector3, Quaternion, bool) CIADLLBLDMN(OLACMNNNFCK AIJKIAIKFDH)
		{
			return default((Vector3, Quaternion, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x26AE500", Offset = "0x26AD100", VA = "0x1826AE500", Slot = "19")]
		[IteratorStateMachine(typeof(KHOFJIJNFAD))]
		public IEnumerable<OLACMNNNFCK> OCEHEBEFEOF(OLACMNNNFCK AIJKIAIKFDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x26ADA60", Offset = "0x26AC660", VA = "0x1826ADA60", Slot = "20")]
		public OLACMNNNFCK ILAJCIAIJDO(OLACMNNNFCK AIJKIAIKFDH)
		{
			return default(OLACMNNNFCK);
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x26AD540", Offset = "0x26AC140", VA = "0x1826AD540", Slot = "28")]
		public void HEEKALJAFEF(ref List<OLACMNNNFCK> FBGPEJDOHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x26AD960", Offset = "0x26AC560", VA = "0x1826AD960")]
		private Entity ILAJCIAIJDO(Entity OCMABEPCGDM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x26AEA10", Offset = "0x26AD610", VA = "0x1826AEA10")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.HierarchySystems)]
	[MHBJLGEIMOG(typeof(EntityHierarchyChildren), new string[] { })]
	internal sealed class EntityHierarchyChildren : HKFIKAGKAAK
	{
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private BHBECLCNBCK JFAHNIMFMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private BBMAEPBFOJE IAMBEOMBAPK;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		private EntityManager JGHLJDFOODE
		{
			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x26B2020", Offset = "0x26B0C20", VA = "0x1826B2020")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x26B1ED0", Offset = "0x26B0AD0", VA = "0x1826B1ED0", Slot = "4")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x26B1B60", Offset = "0x26B0760", VA = "0x1826B1B60")]
		internal void FPABBGGNFGE(Entity MKOLBPGKLJP, Entity ACGOMEFGGLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x26B1F50", Offset = "0x26B0B50", VA = "0x1826B1F50")]
		internal void PFBPOJFCODM(Entity MKOLBPGKLJP, Entity ACGOMEFGGLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x26B1770", Offset = "0x26B0370", VA = "0x1826B1770")]
		private int BJPOBELEHKM(Entity MKOLBPGKLJP, Entity ACGOMEFGGLL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x26B1DB0", Offset = "0x26B09B0", VA = "0x1826B1DB0")]
		internal DynamicBuffer<ChildrenData> HDPGBPPOLHL(Entity OCMABEPCGDM)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x26B1960", Offset = "0x26B0560", VA = "0x1826B1960")]
		internal DynamicBuffer<ChildrenData> EALODLEGBPD(Entity OCMABEPCGDM)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x26B1E70", Offset = "0x26B0A70", VA = "0x1826B1E70")]
		public NativeArray<Entity> HOLFOCICGHO(Entity OCMABEPCGDM, Allocator HGKGLCNFHPJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x26B15C0", Offset = "0x26B01C0", VA = "0x1826B15C0")]
		public bool BFEADFKJAEC(Entity OCMABEPCGDM, Allocator HGKGLCNFHPJ, out NativeArray<Entity> LBILNGMAFPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x26B1A20", Offset = "0x26B0620", VA = "0x1826B1A20")]
		public NativeArray<Entity> ELOJCLGOBMI(Entity OCMABEPCGDM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x26B1850", Offset = "0x26B0450", VA = "0x1826B1850")]
		public Entity DAPKLBIKMBK(Entity OCMABEPCGDM, int HIANDEDCLIF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0x26B1CC0", Offset = "0x26B08C0", VA = "0x1826B1CC0")]
		public int GFBHOGJBGOC(Entity OCMABEPCGDM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public EntityHierarchyChildren()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[MHBJLGEIMOG(typeof(EntityHierarchyEvents), new string[] { })]
	[GOMFNBMFGBH(ELBDNIJMKBJ.HierarchySystems)]
	internal sealed class EntityHierarchyEvents : HKFIKAGKAAK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private BHBECLCNBCK JFAHNIMFMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private ObjectEmbodimentService MPHBIKLMOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private ObjectLifecycleService AFFPNCMAGIK;

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x237AD00", Offset = "0x2379900", VA = "0x18237AD00", Slot = "4")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x237ABF0", Offset = "0x23797F0", VA = "0x18237ABF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		private void LKPMENOIDHJ(NIJAIOMNHOO MPHBIKLMOEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		private void HICOGPAAIMH(NIJAIOMNHOO MPHBIKLMOEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
		private void LAEBJBANBPP(Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public EntityHierarchyEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.HierarchySystems)]
	[MHBJLGEIMOG(typeof(EntityHierarchyParents), new string[] { })]
	internal sealed class EntityHierarchyParents : HKFIKAGKAAK, GEPKKGPMACB
	{
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private DLIOKHGJHNN NGCBDOCNCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private global::OPNPNKDOEBI<Entity> MDENPOJAPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private PropertyChangeNetworkRouter GELHOPIHJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private global::IFAHEBIDIGM<ParentData, GNFHMKOLIFD, EPONONFBHIP, ChildrenData> AHCNMPAMPMB;

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x237B590", Offset = "0x237A190", VA = "0x18237B590", Slot = "4")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x237B4B0", Offset = "0x237A0B0", VA = "0x18237B4B0", Slot = "5")]
		public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x237B3C0", Offset = "0x2379FC0", VA = "0x18237B3C0")]
		public Entity DPNLFEGJALJ(Entity OCMABEPCGDM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x237B0D0", Offset = "0x2379CD0", VA = "0x18237B0D0")]
		public bool CFCLBILFFDO(Entity OCMABEPCGDM, Entity BIMAKIIINII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x237B410", Offset = "0x237A010", VA = "0x18237B410")]
		public bool KMBIIDLEBDG(Entity OCMABEPCGDM, Entity BIMAKIIINII, bool CFGNJOFBFIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x237B130", Offset = "0x2379D30", VA = "0x18237B130")]
		private bool DJLHFIDJACP(Entity OCMABEPCGDM, Entity BIMAKIIINII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[IBGAMCLMLFP(typeof(BHBECLCNBCK))]
[MHBJLGEIMOG(typeof(BBMAEPBFOJE), new string[] { })]
internal sealed class BBMAEPBFOJE : HKFIKAGKAAK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class PFOJEGGLBMB : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public BBMAEPBFOJE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600087A")]
			[Cpp2IlInjected.Address(RVA = "0x16EC4E0", Offset = "0x16EB0E0", VA = "0x1816EC4E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600087C")]
			[Cpp2IlInjected.Address(RVA = "0x263E310", Offset = "0x263CF10", VA = "0x18263E310", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x237C5C0", Offset = "0x237B1C0", VA = "0x18237C5C0")]
		[DebuggerHidden]
		public PFOJEGGLBMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x263E170", Offset = "0x263CD70", VA = "0x18263E170", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x263E2C0", Offset = "0x263CEC0", VA = "0x18263E2C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x263E210", Offset = "0x263CE10", VA = "0x18263E210", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x263E210", Offset = "0x263CE10", VA = "0x18263E210", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class PPAOHODFPPL : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public BBMAEPBFOJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private IEnumerator<Entity> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0x16EC4E0", Offset = "0x16EB0E0", VA = "0x1816EC4E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0x263E620", Offset = "0x263D220", VA = "0x18263E620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x237C5C0", Offset = "0x237B1C0", VA = "0x18237C5C0")]
		[DebuggerHidden]
		public PPAOHODFPPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x263E670", Offset = "0x263D270", VA = "0x18263E670", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x263E360", Offset = "0x263CF60", VA = "0x18263E360", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x263E720", Offset = "0x263D320", VA = "0x18263E720")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x263E5D0", Offset = "0x263D1D0", VA = "0x18263E5D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x263E520", Offset = "0x263D120", VA = "0x18263E520", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x263E520", Offset = "0x263D120", VA = "0x18263E520", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class OOENIGNFIIN : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public BBMAEPBFOJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private ChildrenData <childData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private IEnumerator<Entity> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0x16EC4E0", Offset = "0x16EB0E0", VA = "0x1816EC4E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x263DF90", Offset = "0x263CB90", VA = "0x18263DF90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x237C5C0", Offset = "0x237B1C0", VA = "0x18237C5C0")]
		[DebuggerHidden]
		public OOENIGNFIIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x263DFE0", Offset = "0x263CBE0", VA = "0x18263DFE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x263DBE0", Offset = "0x263C7E0", VA = "0x18263DBE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x263E0E0", Offset = "0x263CCE0", VA = "0x18263E0E0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x263E120", Offset = "0x263CD20", VA = "0x18263E120")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x263DF40", Offset = "0x263CB40", VA = "0x18263DF40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x263DE90", Offset = "0x263CA90", VA = "0x18263DE90", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x263DE90", Offset = "0x263CA90", VA = "0x18263DE90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private BHBECLCNBCK JFAHNIMFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private EntityHierarchyParents FDHPNOAHJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private EntityHierarchyChildren HIGOGPMFHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private EntityQuery COBDAEMANNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private bool JMNCCKFMNPP;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private EntityManager JGHLJDFOODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x2632A60", Offset = "0x2631660", VA = "0x182632A60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x2632950", Offset = "0x2631550", VA = "0x182632950", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x2631F00", Offset = "0x2630B00", VA = "0x182631F00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x2631F20", Offset = "0x2630B20", VA = "0x182631F20")]
	public bool EAHMDJKDIOJ(Entity OCMABEPCGDM, Entity MCHPJLFOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x26322B0", Offset = "0x2630EB0", VA = "0x1826322B0")]
	public bool GLGDBPHLPPJ(Entity OCMABEPCGDM, Entity MCHPJLFOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x26325B0", Offset = "0x26311B0", VA = "0x1826325B0")]
	public IEnumerable<Entity> IPDEACIOKMN(Entity OCMABEPCGDM, bool CBLGJABHGDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x26326E0", Offset = "0x26312E0", VA = "0x1826326E0")]
	[IteratorStateMachine(typeof(PFOJEGGLBMB))]
	private IEnumerable<Entity> JGIEAGEHILO(Entity OCMABEPCGDM, bool CBLGJABHGDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x2632460", Offset = "0x2631060", VA = "0x182632460")]
	public bool IDBAJDENNNC(Entity OCMABEPCGDM, Entity ACGOMEFGGLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x2631D60", Offset = "0x2630960", VA = "0x182631D60")]
	public bool AGDDOPKFFCH(Entity OCMABEPCGDM, Entity JEGDMKPCECO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x2632780", Offset = "0x2631380", VA = "0x182632780")]
	public IEnumerable<Entity> KCOPOEIDDEM(Entity OCMABEPCGDM, bool CBLGJABHGDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x26328B0", Offset = "0x26314B0", VA = "0x1826328B0")]
	[IteratorStateMachine(typeof(PPAOHODFPPL))]
	private IEnumerable<Entity> NHMKMAFFKPP(Entity OCMABEPCGDM, bool CBLGJABHGDN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x26323E0", Offset = "0x2630FE0", VA = "0x1826323E0")]
	[IteratorStateMachine(typeof(OOENIGNFIIN))]
	private IEnumerable<Entity> IAEFMGHDHKM(Entity OCMABEPCGDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x2632520", Offset = "0x2631120", VA = "0x182632520")]
	public Entity ILAJCIAIJDO(Entity OCMABEPCGDM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x2632390", Offset = "0x2630F90", VA = "0x182632390")]
	public NativeArray<Entity> HEEKALJAFEF()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0x26320C0", Offset = "0x2630CC0", VA = "0x1826320C0")]
	public bool EKBLKLILKFF(Entity JEGDMKPCECO, Entity CNDMHGAOPGD, out Entity JPILMHHADCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public BBMAEPBFOJE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x22F4F80", Offset = "0x22F3B80", VA = "0x1822F4F80")]
		public static void HILHGJFFAMN<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData>(DEGAMIMEMLN CMPGNIIOOGE, global::AABHEEDMDPC<Entity> OHDKCBCOIKL, out global::IFAHEBIDIGM<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> JCHCJAAAPLE) where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, LDFMEFPABAI where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, LDFMEFPABAI, IEquatable<ChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2384060", Offset = "0x2382C60", VA = "0x182384060")]
		public static bool CKHLICGHOEB(NIJAIOMNHOO FJAGFNGNGHD)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
public class IFAHEBIDIGM<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, LDFMEFPABAI where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, LDFMEFPABAI, IEquatable<ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private static readonly LJFAOMOPGNF FFJIMJJJOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly BHBECLCNBCK JFAHNIMFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly global::OPNPNKDOEBI<Entity> MDENPOJAPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly PHPABLLJDIC CGKFOGMFCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private readonly BIIMOMDCJGN MKOLBPGKLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly EntityManager EJMLDDGCGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private readonly ACAEIGFMODO IMIIFABFDDB;

	[Cpp2IlInjected.Token(Token = "0x6000894")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9B60", Offset = "0x2CA8760", VA = "0x182CA9B60")]
	public IFAHEBIDIGM(DEGAMIMEMLN CMPGNIIOOGE, global::AABHEEDMDPC<Entity> OHDKCBCOIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000895")]
	[Cpp2IlInjected.Address(RVA = "0x2CA99A0", Offset = "0x2CA85A0", VA = "0x182CA99A0")]
	private bool MBEPMCNIFCN(Entity OCMABEPCGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0x2CA95E0", Offset = "0x2CA81E0", VA = "0x182CA95E0")]
	private bool HACKJEADPHM(Entity OCMABEPCGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9630", Offset = "0x2CA8230", VA = "0x182CA9630")]
	public bool HPBPBKJHOGK(Entity OCMABEPCGDM, in Entity BIMAKIIINII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	private static void EEGDDALAKMG(Entity OCMABEPCGDM, Entity BIMAKIIINII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	private static void EIPPHGEANEF(Entity OCMABEPCGDM, Entity BIMAKIIINII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8FD0", Offset = "0x2CA7BD0", VA = "0x182CA8FD0")]
	private bool EAHMDJKDIOJ(Entity OCMABEPCGDM, Entity MCHPJLFOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600089B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9860", Offset = "0x2CA8460", VA = "0x182CA9860")]
	private void LMCPKICIENN(Entity OCMABEPCGDM, in Entity CPGJLPOPHBK, in Entity BIMAKIIINII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA92A0", Offset = "0x2CA7EA0", VA = "0x182CA92A0")]
	private void FBCBLKANGLF(Entity OCMABEPCGDM, in Entity CPGJLPOPHBK, in Entity BIMAKIIINII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8C50", Offset = "0x2CA7850", VA = "0x182CA8C50")]
	private bool DEDENALNHDD(OOJKCBLFFGH IAADOHDBECD, in GEGPJNFMCPG LBAEOCPDKMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600089E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9170", Offset = "0x2CA7D70", VA = "0x182CA9170")]
	private void EJDGEDKCCFP(Entity MKOLBPGKLJP, Entity ACGOMEFGGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8B10", Offset = "0x2CA7710", VA = "0x182CA8B10")]
	private void BGLLMBLHMEJ(Entity MKOLBPGKLJP, Entity ACGOMEFGGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A0")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	private void JCOJDIFKJDJ(Entity OCMABEPCGDM, Entity CPGJLPOPHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A1")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	private void IPACILPIFGO(Entity OCMABEPCGDM, Entity BIMAKIIINII)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.HierarchySystems)]
	[MHBJLGEIMOG(typeof(TransformOwnershipPhase), new string[] { })]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x200014F")]
		public enum OELBCJOPEDP
		{
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x2000150")]
		public struct DKGMMHIDJCC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private OELBCJOPEDP OEBBFNLNMDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private readonly TransformOwnershipPhase MKOLBPGKLJP;

			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0x237A910", Offset = "0x2379510", VA = "0x18237A910")]
			public DKGMMHIDJCC(TransformOwnershipPhase MKOLBPGKLJP, OELBCJOPEDP JMOKNJANCIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0x237A8F0", Offset = "0x23794F0", VA = "0x18237A8F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public OELBCJOPEDP JMOKNJANCIM;

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public OELBCJOPEDP KKDMACDOKOH
		{
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x5ECED0", Offset = "0x5EBAD0", VA = "0x1805ECED0")]
			get
			{
				return default(OELBCJOPEDP);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEE0", Offset = "0x5EBAE0", VA = "0x1805ECEE0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public bool CACAJJGGEBI
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x9CA310", Offset = "0x9C8F10", VA = "0x1809CA310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public bool ECCJICCOIIA
		{
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0x9C3BB0", Offset = "0x9C27B0", VA = "0x1809C3BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x238B1A0", Offset = "0x2389DA0", VA = "0x18238B1A0")]
		public DKGMMHIDJCC PPEKOIJKLNC()
		{
			return default(DKGMMHIDJCC);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x238B150", Offset = "0x2389D50", VA = "0x18238B150")]
		public DKGMMHIDJCC PENBIMIBPOO()
		{
			return default(DKGMMHIDJCC);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public TransformOwnershipPhase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
public struct CBABPMMCIBA : global::POBAFBEGBJN<CBABPMMCIBA>, FBMJPDGBHLO, IEquatable<CBABPMMCIBA>
{
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly CBABPMMCIBA EIEGJHHNOAD;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public int PAOIHHHPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x8AB500", Offset = "0x8AA100", VA = "0x1808AB500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x925AC0", Offset = "0x9246C0", VA = "0x180925AC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public int EKKPBKBJINC
	{
		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4E0", Offset = "0x8AA0E0", VA = "0x1808AB4E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x8FF2D0", Offset = "0x8FDED0", VA = "0x1808FF2D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool PDABALEFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x2633E50", Offset = "0x2632A50", VA = "0x182633E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B2")]
	[Cpp2IlInjected.Address(RVA = "0x2633E00", Offset = "0x2632A00", VA = "0x182633E00", Slot = "8")]
	public bool Equals(CBABPMMCIBA NPKIIGGBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B3")]
	[Cpp2IlInjected.Address(RVA = "0x2633E90", Offset = "0x2632A90", VA = "0x182633E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
public struct CEEHELJFIDO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public CBABPMMCIBA CGGCCCAGOLF;
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct EFNLBHPMOKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private const int EALEMOCDHFE = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private readonly Stack<HashSet<object>> FGHPEPNEAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private global::LMBOEJIDHPD<CBABPMMCIBA, HashSet<object>> MCKFIKPIDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private EntityManager EJMLDDGCGJO;

	[Cpp2IlInjected.Token(Token = "0x60008B5")]
	[Cpp2IlInjected.Address(RVA = "0x26379F0", Offset = "0x26365F0", VA = "0x1826379F0")]
	public EFNLBHPMOKL(EntityManager EJMLDDGCGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0x26377C0", Offset = "0x26363C0", VA = "0x1826377C0")]
	public void LEDODGGAFMD(Entity OCMABEPCGDM, object KJKNLGILOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0x26378A0", Offset = "0x26364A0", VA = "0x1826378A0")]
	public bool MKGAPOGLBHP(Entity OCMABEPCGDM, object KJKNLGILOFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B8")]
	[Cpp2IlInjected.Address(RVA = "0x2637660", Offset = "0x2636260", VA = "0x182637660")]
	public bool FHOEAEMPIAC(Entity OCMABEPCGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B9")]
	[Cpp2IlInjected.Address(RVA = "0x26375C0", Offset = "0x26361C0", VA = "0x1826375C0")]
	public bool FHOEAEMPIAC(CBABPMMCIBA CGGCCCAGOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BA")]
	[Cpp2IlInjected.Address(RVA = "0x2637450", Offset = "0x2636050", VA = "0x182637450")]
	public bool DADCOIIIOOC(Entity OCMABEPCGDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0x2637520", Offset = "0x2636120", VA = "0x182637520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0x2637560", Offset = "0x2636160", VA = "0x182637560")]
	private void EHMHIGCGPCL(HashSet<object> DMGNKKBAANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0x26376A0", Offset = "0x26362A0", VA = "0x1826376A0")]
	private bool FLDFEIOACKP(Entity OCMABEPCGDM, out CBABPMMCIBA CGGCCCAGOLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BE")]
	[Cpp2IlInjected.Address(RVA = "0x26373E0", Offset = "0x2635FE0", VA = "0x1826373E0")]
	private void CGLLHICNHLP(Entity OCMABEPCGDM, CBABPMMCIBA CGGCCCAGOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BF")]
	[Cpp2IlInjected.Address(RVA = "0x2637760", Offset = "0x2636360", VA = "0x182637760")]
	private bool GPDKCAKDONL(CBABPMMCIBA GKEFMIIBIAL, out HashSet<object> DMGNKKBAANE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C0")]
	[Cpp2IlInjected.Address(RVA = "0x2637360", Offset = "0x2635F60", VA = "0x182637360")]
	private HashSet<object> AGDIBHGEKAH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
[MHBJLGEIMOG(typeof(FAMHHBOFMMF), new string[] { })]
public sealed class FAMHHBOFMMF
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action NEEJHEPENEP
	{
		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2638E60", Offset = "0x2637A60", VA = "0x182638E60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2638F00", Offset = "0x2637B00", VA = "0x182638F00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action AHPLKGMNDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2638DC0", Offset = "0x26379C0", VA = "0x182638DC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2638D20", Offset = "0x2637920", VA = "0x182638D20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x1099760", Offset = "0x1098360", VA = "0x181099760")]
	public void EKGCPNODJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x101BDA0", Offset = "0x101A9A0", VA = "0x18101BDA0")]
	public void LCOFMMCLBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public FAMHHBOFMMF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[MHBJLGEIMOG(typeof(ObjectEmbodimentService), new string[] { })]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Embodiment)]
	internal sealed class ObjectEmbodimentService : POIJNBNBJIE, CCILBHCKADC, HKFIKAGKAAK, GEPKKGPMACB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private readonly Dictionary<GEGPJNFMCPG, DCFEMLAEOED> JEOFFFOBNMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private BHBECLCNBCK JFAHNIMFMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private PNPPGDJCNCL LCAGHKIOCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private DLIOKHGJHNN NGCBDOCNCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private JDDPPIAFHCO NOMIILNDOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private AOJCKCOKMFP HJLBJPLIGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private EFNLBHPMOKL IJFHNKNKCLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private EntityHierarchyChildren HIGOGPMFHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private ObjectLifecycleService AFFPNCMAGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TransformOwnershipPhase JMOKNJANCIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private bool JMNCCKFMNPP;

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		private EntityManager JGHLJDFOODE
		{
			[Cpp2IlInjected.Token(Token = "0x60008CC")]
			[Cpp2IlInjected.Address(RVA = "0x2380AE0", Offset = "0x237F6E0", VA = "0x182380AE0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public int LOFNLMCKNKP
		{
			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0x237FB40", Offset = "0x237E740", VA = "0x18237FB40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int MBIGNBJABEO
		{
			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0x237F190", Offset = "0x237DD90", VA = "0x18237F190")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<NIJAIOMNHOO> KFBGKKFIBND
		{
			[Cpp2IlInjected.Token(Token = "0x60008C8")]
			[Cpp2IlInjected.Address(RVA = "0x237E270", Offset = "0x237CE70", VA = "0x18237E270")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008C9")]
			[Cpp2IlInjected.Address(RVA = "0x237EE30", Offset = "0x237DA30", VA = "0x18237EE30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<NIJAIOMNHOO> OCKIPBGDDOG
		{
			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x237DF90", Offset = "0x237CB90", VA = "0x18237DF90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0x237FB70", Offset = "0x237E770", VA = "0x18237FB70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x23803C0", Offset = "0x237EFC0", VA = "0x1823803C0", Slot = "4")]
		public void NGNFNBOGJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x2380670", Offset = "0x237F270", VA = "0x182380670", Slot = "5")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x237F9A0", Offset = "0x237E5A0", VA = "0x18237F9A0", Slot = "6")]
		public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x237E340", Offset = "0x237CF40", VA = "0x18237E340", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x237EFA0", Offset = "0x237DBA0", VA = "0x18237EFA0")]
		public bool HOIACNCHMEM(Entity OCMABEPCGDM, Allocator HGKGLCNFHPJ, out NativeList<Entity> EAOINHCNBIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x237EC60", Offset = "0x237D860", VA = "0x18237EC60")]
		public global::AMBNDEDFEAL<Entity> FJOOCCGOPEI(Allocator HGKGLCNFHPJ)
		{
			return default(global::AMBNDEDFEAL<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x237F170", Offset = "0x237DD70", VA = "0x18237F170")]
		public bool IHHKOCLPKGP(Entity OCMABEPCGDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x237F1B0", Offset = "0x237DDB0", VA = "0x18237F1B0")]
		public bool JIJGEKFIGAG(Entity OCMABEPCGDM, out DCFEMLAEOED MPHBIKLMOEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x237F220", Offset = "0x237DE20", VA = "0x18237F220")]
		private bool JIJGEKFIGAG(Transform BHPNFBEEMHL, out DCFEMLAEOED MPHBIKLMOEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x237E480", Offset = "0x237D080", VA = "0x18237E480")]
		internal bool EBBPFKLGOLC(Entity OCMABEPCGDM, out EANCAPJPPOK MPHBIKLMOEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x237E1E0", Offset = "0x237CDE0", VA = "0x18237E1E0")]
		private void DCBKIHBLIBK(Entity OCMABEPCGDM, DCFEMLAEOED MPHBIKLMOEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x237F980", Offset = "0x237E580", VA = "0x18237F980")]
		private bool MCCLGKCJKBJ(Entity OCMABEPCGDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x237F6F0", Offset = "0x237E2F0", VA = "0x18237F6F0")]
		public void KIEPKILKNCN(GEGPJNFMCPG PJIBLINGJGM, DCFEMLAEOED MPPBCOBNMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x237ECA0", Offset = "0x237D8A0", VA = "0x18237ECA0")]
		public bool GBEHGNBHMOM(Entity OCMABEPCGDM, object KJKNLGILOFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x2380150", Offset = "0x237ED50", VA = "0x182380150")]
		public bool NDCMKCIPONE(OLACMNNNFCK AIJKIAIKFDH, object KJKNLGILOFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x237FC30", Offset = "0x237E830", VA = "0x18237FC30")]
		public bool NDCMKCIPONE(Entity OCMABEPCGDM, [Optional] object KJKNLGILOFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x237FC10", Offset = "0x237E810", VA = "0x18237FC10")]
		public bool NDCMKCIPONE(DCFEMLAEOED FJAGFNGNGHD, object KJKNLGILOFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x237DEB0", Offset = "0x237CAB0", VA = "0x18237DEB0")]
		public bool CDMCPOLNFEM(Entity OCMABEPCGDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x237DF60", Offset = "0x237CB60", VA = "0x18237DF60")]
		public bool CDMCPOLNFEM(DCFEMLAEOED MPHBIKLMOEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x237FD20", Offset = "0x237E920", VA = "0x18237FD20")]
		public bool NDCMKCIPONE(DCFEMLAEOED MPHBIKLMOEK, [Optional] object KJKNLGILOFJ, bool CJFDGGNEKPC = false, bool HNNHBNLJHKB = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x2380850", Offset = "0x237F450", VA = "0x182380850")]
		public Transform PBOMICHDFFI(Entity OCMABEPCGDM, [Optional] object KJKNLGILOFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x237EED0", Offset = "0x237DAD0", VA = "0x18237EED0")]
		public bool HLICONCCCHB(Entity OCMABEPCGDM, out Transform BHPNFBEEMHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x237ED60", Offset = "0x237D960", VA = "0x18237ED60")]
		public DCFEMLAEOED GJJJIKECOBM(Entity OCMABEPCGDM, [Optional] object KJKNLGILOFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x237F2C0", Offset = "0x237DEC0", VA = "0x18237F2C0")]
		public void JLPPDNNBING()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x237E4A0", Offset = "0x237D0A0", VA = "0x18237E4A0")]
		public void EBPFBEFOADJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x23803D0", Offset = "0x237EFD0", VA = "0x1823803D0")]
		private void NPHOLCLFNEJ(Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x237E7D0", Offset = "0x237D3D0", VA = "0x18237E7D0")]
		public DCFEMLAEOED EELILIOBFDC(Entity OCMABEPCGDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x237F970", Offset = "0x237E570", VA = "0x18237F970")]
		public void LEDODGGAFMD(Entity OCMABEPCGDM, object KJKNLGILOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x237FB60", Offset = "0x237E760", VA = "0x18237FB60")]
		public bool MKGAPOGLBHP(Entity OCMABEPCGDM, object KJKNLGILOFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x237E1D0", Offset = "0x237CDD0", VA = "0x18237E1D0")]
		public bool DADCOIIIOOC(Entity OCMABEPCGDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x237EC40", Offset = "0x237D840", VA = "0x18237EC40")]
		public bool FHOEAEMPIAC(Entity OCMABEPCGDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x237EC50", Offset = "0x237D850", VA = "0x18237EC50")]
		public bool FHOEAEMPIAC(CBABPMMCIBA CGGCCCAGOLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x237F820", Offset = "0x237E420", VA = "0x18237F820")]
		private void KNHABDONFAN(bool DMDFAIGCLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x2380A50", Offset = "0x237F650", VA = "0x182380A50")]
		private bool PDLHIDGODFI(Entity OCMABEPCGDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x237FAD0", Offset = "0x237E6D0", VA = "0x18237FAD0")]
		private DCFEMLAEOED MDLBHABKDIE(Entity OCMABEPCGDM, object KJKNLGILOFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x237E030", Offset = "0x237CC30", VA = "0x18237E030")]
		private DCFEMLAEOED CIPJEEMLILF(Entity OCMABEPCGDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x237F4E0", Offset = "0x237E0E0", VA = "0x18237F4E0")]
		private (Vector3, Quaternion, Vector3) KHJLJMFLGEK(Entity OCMABEPCGDM)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x237DD10", Offset = "0x237C910", VA = "0x18237DD10")]
		private void AFJIAOJMIGO(Entity OCMABEPCGDM, CMECOJAJFAB LBEKIEDKPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2380220", Offset = "0x237EE20", VA = "0x182380220")]
		private void NFEBDLLILOE(OLACMNNNFCK AIJKIAIKFDH, DCFEMLAEOED MPPBCOBNMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x237E820", Offset = "0x237D420", VA = "0x18237E820")]
		private void EHLDMNJIJFP(DCFEMLAEOED MPHBIKLMOEK, Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2380B30", Offset = "0x237F730", VA = "0x182380B30")]
		private void PNOFBDKNHPD(Entity OCMABEPCGDM, DCFEMLAEOED MPHBIKLMOEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2380D50", Offset = "0x237F950", VA = "0x182380D50")]
		private void POMAJKBBANO(Entity OCMABEPCGDM, Transform BHPNFBEEMHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x237E310", Offset = "0x237CF10", VA = "0x18237E310")]
		private OLACMNNNFCK DJGKOLKAFEB(Entity OCMABEPCGDM)
		{
			return default(OLACMNNNFCK);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x2380E80", Offset = "0x237FA80", VA = "0x182380E80")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x237DE00", Offset = "0x237CA00", VA = "0x18237DE00")]
		[CompilerGenerated]
		private void CCHBDBIHGJP()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal static class NNHHEKOCMPJ
{
	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0x26B4E40", Offset = "0x26B3A40", VA = "0x1826B4E40")]
	public static DCFEMLAEOED GJJJIKECOBM(this ObjectEmbodimentService EDAMELHACNP, OLACMNNNFCK AIJKIAIKFDH, [Optional] object KJKNLGILOFJ)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Lifecycle)]
	[MHBJLGEIMOG(typeof(ObjectLifecycleService), new string[] { })]
	internal sealed class ObjectLifecycleService : HKFIKAGKAAK
	{
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private BHBECLCNBCK NJMNPDHNNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private ObjectEmbodimentService MPHBIKLMOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private ObjectNetworkToLocalMapService FBKDDNILPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private EntityHierarchyChildren HIGOGPMFHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private BBMAEPBFOJE IAMBEOMBAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private EntityHierarchyParents FDHPNOAHJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private ABMAMPEGJKD AIBBNPKPCNP;

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		private EntityManager JGHLJDFOODE
		{
			[Cpp2IlInjected.Token(Token = "0x6000902")]
			[Cpp2IlInjected.Address(RVA = "0x2381D50", Offset = "0x2380950", VA = "0x182381D50")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<Entity, CMECOJAJFAB> EMLABCEDMOE
		{
			[Cpp2IlInjected.Token(Token = "0x60008FE")]
			[Cpp2IlInjected.Address(RVA = "0x2381590", Offset = "0x2380190", VA = "0x182381590")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008FF")]
			[Cpp2IlInjected.Address(RVA = "0x2381AF0", Offset = "0x23806F0", VA = "0x182381AF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<Entity> CKLIGLIHAAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000900")]
			[Cpp2IlInjected.Address(RVA = "0x23813C0", Offset = "0x237FFC0", VA = "0x1823813C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000901")]
			[Cpp2IlInjected.Address(RVA = "0x2381B90", Offset = "0x2380790", VA = "0x182381B90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x2381C30", Offset = "0x2380830", VA = "0x182381C30", Slot = "4")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x2381130", Offset = "0x237FD30", VA = "0x182381130")]
		public bool CAACINLFJOH(Entity OCMABEPCGDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x23816C0", Offset = "0x23802C0", VA = "0x1823816C0")]
		internal void LLAPPGAKECK(Entity OCMABEPCGDM, CMECOJAJFAB LBEKIEDKPCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x2381630", Offset = "0x2380230", VA = "0x182381630")]
		public void LEPAFNJMDJH(Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x23819B0", Offset = "0x23805B0", VA = "0x1823819B0")]
		public void MOANCCAMPPP(Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x2381460", Offset = "0x2380060", VA = "0x182381460")]
		private bool JDGLLACJPOL(Entity OCMABEPCGDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x2381320", Offset = "0x237FF20", VA = "0x182381320")]
		public void GENHPMKNFBO(Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x2380EF0", Offset = "0x237FAF0", VA = "0x182380EF0")]
		private void AJEBNOFOJPO(Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x2380F20", Offset = "0x237FB20", VA = "0x182380F20")]
		private void BFHBKAEGPEM(Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x2381720", Offset = "0x2380320", VA = "0x182381720")]
		private void LLBFMHILBEJ(Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x23811B0", Offset = "0x237FDB0", VA = "0x1823811B0")]
		private void ELBIPFPFGHM(Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Embodiment)]
	[MHBJLGEIMOG(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : HKFIKAGKAAK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private NativeHashMap<GEGPJNFMCPG, Entity> EMOOHKAINNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private BHBECLCNBCK NJMNPDHNNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private PNPPGDJCNCL LCAGHKIOCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private EntityManager EJMLDDGCGJO;

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		internal NativeHashMap<GEGPJNFMCPG, Entity> JPHNCFAOAIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000911")]
			[Cpp2IlInjected.Address(RVA = "0x8FDA40", Offset = "0x8FC640", VA = "0x1808FDA40")]
			get
			{
				return default(NativeHashMap<GEGPJNFMCPG, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2382260", Offset = "0x2380E60", VA = "0x182382260", Slot = "4")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2381E20", Offset = "0x2380A20", VA = "0x182381E20", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x23820A0", Offset = "0x2380CA0", VA = "0x1823820A0")]
		public void LONCNHKPMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2381DF0", Offset = "0x23809F0", VA = "0x182381DF0")]
		private OLACMNNNFCK DJGKOLKAFEB(Entity OCMABEPCGDM)
		{
			return default(OLACMNNNFCK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2382100", Offset = "0x2380D00", VA = "0x182382100")]
		public OLACMNNNFCK NBOBFLKDCHO(GEGPJNFMCPG PJIBLINGJGM)
		{
			return default(OLACMNNNFCK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x23821D0", Offset = "0x2380DD0", VA = "0x1823821D0")]
		public GEGPJNFMCPG OJFOEHBFNEO(OLACMNNNFCK AIJKIAIKFDH)
		{
			return default(GEGPJNFMCPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x2381EE0", Offset = "0x2380AE0", VA = "0x182381EE0")]
		public void JPMAHKCMKCE(Entity OCMABEPCGDM, GEGPJNFMCPG PJIBLINGJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2381F70", Offset = "0x2380B70", VA = "0x182381F70")]
		public void KNGNIFBCJJO(Entity OCMABEPCGDM, GEGPJNFMCPG PJIBLINGJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x2381E80", Offset = "0x2380A80", VA = "0x182381E80")]
		public void FBCJHFCKDJJ(Entity OCMABEPCGDM, GEGPJNFMCPG PJIBLINGJGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x2381FD0", Offset = "0x2380BD0", VA = "0x182381FD0")]
		public void LKDPGGHEHHC(Entity OCMABEPCGDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal class OKCKNNEEFJP : IKBKLCEIKJI
{
	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public MHAFPGDIKFN ACEDCJNDAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x26B5A70", Offset = "0x26B4670", VA = "0x1826B5A70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MHAFPGDIKFN);
		}
		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x26B6010", Offset = "0x26B4C10", VA = "0x1826B6010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public MHAFPGDIKFN HGLKAKNJJCM
	{
		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x26B60E0", Offset = "0x26B4CE0", VA = "0x1826B60E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(MHAFPGDIKFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x26B5AD0", Offset = "0x26B46D0", VA = "0x1826B5AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public MHAFPGDIKFN IIEHNPMADDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x26B5EC0", Offset = "0x26B4AC0", VA = "0x1826B5EC0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(MHAFPGDIKFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x26B5C90", Offset = "0x26B4890", VA = "0x1826B5C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public MHAFPGDIKFN LBNMCMPENOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x26B5F30", Offset = "0x26B4B30", VA = "0x1826B5F30", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(MHAFPGDIKFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x26B5FA0", Offset = "0x26B4BA0", VA = "0x1826B5FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public MHAFPGDIKFN APLPMDNIHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x26B6150", Offset = "0x26B4D50", VA = "0x1826B6150", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(MHAFPGDIKFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x26B5C20", Offset = "0x26B4820", VA = "0x1826B5C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public MHAFPGDIKFN IGABLDGKEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x26B5BB0", Offset = "0x26B47B0", VA = "0x1826B5BB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(MHAFPGDIKFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x26B5B40", Offset = "0x26B4740", VA = "0x1826B5B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public MHAFPGDIKFN LOPJAKHBFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x26B5D70", Offset = "0x26B4970", VA = "0x1826B5D70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(MHAFPGDIKFN);
		}
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x26B61C0", Offset = "0x26B4DC0", VA = "0x1826B61C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public MHAFPGDIKFN CFNHDOKDJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x26B62A0", Offset = "0x26B4EA0", VA = "0x1826B62A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(MHAFPGDIKFN);
		}
		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x26B6230", Offset = "0x26B4E30", VA = "0x1826B6230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public MHAFPGDIKFN OJGEJKPNFML
	{
		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x26B6070", Offset = "0x26B4C70", VA = "0x1826B6070", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(MHAFPGDIKFN);
		}
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x26B5E50", Offset = "0x26B4A50", VA = "0x1826B5E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public MHAFPGDIKFN BLPNINBKDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x26B5D00", Offset = "0x26B4900", VA = "0x1826B5D00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(MHAFPGDIKFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x26B5DE0", Offset = "0x26B49E0", VA = "0x1826B5DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000931")]
	[Cpp2IlInjected.Address(RVA = "0x26B6310", Offset = "0x26B4F10", VA = "0x1826B6310")]
	public OKCKNNEEFJP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Prefabs)]
	[IBGAMCLMLFP(typeof(BHBECLCNBCK))]
	[MHBJLGEIMOG(typeof(ObjectPrefabCreationService), new string[] { })]
	internal sealed class ObjectPrefabCreationService : POIJNBNBJIE, CCILBHCKADC, HKFIKAGKAAK, GEPKKGPMACB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private BHBECLCNBCK JFAHNIMFMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private DOEOBGNPDCP PGINIGMMAKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private KCMHMBMGMLH PBBGEACMLFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private ObjectNetworkToLocalMapService FBKDDNILPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private ObjectLifecycleService AFFPNCMAGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private ObjectPrefabs PNALABGJPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private HLMMNONOKJE GJDCHFNFBCI;

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public int BDEPJHADJDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000945")]
			[Cpp2IlInjected.Address(RVA = "0x2382950", Offset = "0x2381550", VA = "0x182382950")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "4")]
		public void NGNFNBOGJKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x2382AB0", Offset = "0x23816B0", VA = "0x182382AB0", Slot = "5")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x2382A20", Offset = "0x2381620", VA = "0x182382A20", Slot = "6")]
		public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2382750", Offset = "0x2381350", VA = "0x182382750", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2382800", Offset = "0x2381400", VA = "0x182382800")]
		private void GIDBNEINMJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2382C00", Offset = "0x2381800", VA = "0x182382C00")]
		public void PKMFLNNJPEB(bool CJFDGGNEKPC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x2382800", Offset = "0x2381400", VA = "0x182382800")]
		private void ECHOBMHMIFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x23824D0", Offset = "0x23810D0", VA = "0x1823824D0")]
		public Entity BMFKHGCIIMB(CMECOJAJFAB LBEKIEDKPCN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x23823E0", Offset = "0x2380FE0", VA = "0x1823823E0")]
		public Entity BMFKHGCIIMB(CMECOJAJFAB LBEKIEDKPCN, GEGPJNFMCPG PJIBLINGJGM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x2382A00", Offset = "0x2381600", VA = "0x182382A00")]
		public Entity LINIIDLAFGB(CMECOJAJFAB LBEKIEDKPCN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x23825A0", Offset = "0x23811A0", VA = "0x1823825A0")]
		public Entity CIIKAHOEEGC(GEGPJNFMCPG PJIBLINGJGM, CMECOJAJFAB LBEKIEDKPCN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x23824D0", Offset = "0x23810D0", VA = "0x1823824D0")]
		public Entity MAKPCLMEKLM(CMECOJAJFAB LBEKIEDKPCN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x2382910", Offset = "0x2381510", VA = "0x182382910")]
		public Entity FLFOCNDOJDB()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x2382880", Offset = "0x2381480", VA = "0x182382880")]
		public Entity FDLHEELIDBF(HNGFAHNAKGA LIJLAEFJGCI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x2382510", Offset = "0x2381110", VA = "0x182382510")]
		public Entity CCLEBNHPCMF(JLAGNLCEABL LIJLAEFJGCI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x2382480", Offset = "0x2381080", VA = "0x182382480")]
		public NativeArray<(OLACMNNNFCK, OLACMNNNFCK)> BMFKHGCIIMB(NativeArray<OLACMNNNFCK> BCDDKJBGLOL, Allocator HGKGLCNFHPJ)
		{
			return default(NativeArray<(OLACMNNNFCK, OLACMNNNFCK)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x2382830", Offset = "0x2381430", VA = "0x182382830")]
		public IEnumerable<CMECOJAJFAB> ENEHMGJHBEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x23829A0", Offset = "0x23815A0", VA = "0x1823829A0")]
		public EntityArchetype LCCHBBPALPP(CMECOJAJFAB LBEKIEDKPCN)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x2382380", Offset = "0x2380F80", VA = "0x182382380")]
		public Entity AEAJAEDCBFK(CMECOJAJFAB LBEKIEDKPCN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x2382640", Offset = "0x2381240", VA = "0x182382640")]
		private Entity CJMBDLMMKHM(CMECOJAJFAB LBEKIEDKPCN, GEGPJNFMCPG PJIBLINGJGM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ObjectPrefabCreationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Prefabs)]
	internal class ObjectPrefabs : OMPFHPKIHIB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200015C")]
		[CompilerGenerated]
		private sealed class KJPPBJDAMAH : IEnumerable<(HNGFAHNAKGA, CMECOJAJFAB)>, IEnumerable, IEnumerator<(HNGFAHNAKGA, CMECOJAJFAB)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private (HNGFAHNAKGA primitiveType, CMECOJAJFAB prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700010E")]
			private (HNGFAHNAKGA, CMECOJAJFAB) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000961")]
				[Cpp2IlInjected.Address(RVA = "0x16EC4E0", Offset = "0x16EB0E0", VA = "0x1816EC4E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((HNGFAHNAKGA, CMECOJAJFAB));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000963")]
				[Cpp2IlInjected.Address(RVA = "0x237C570", Offset = "0x237B170", VA = "0x18237C570", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600095E")]
			[Cpp2IlInjected.Address(RVA = "0x237C5C0", Offset = "0x237B1C0", VA = "0x18237C5C0")]
			[DebuggerHidden]
			public KJPPBJDAMAH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095F")]
			[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000960")]
			[Cpp2IlInjected.Address(RVA = "0x237C390", Offset = "0x237AF90", VA = "0x18237C390", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000962")]
			[Cpp2IlInjected.Address(RVA = "0x237C520", Offset = "0x237B120", VA = "0x18237C520", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0x237C480", Offset = "0x237B080", VA = "0x18237C480", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(HNGFAHNAKGA, CMECOJAJFAB)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0x237C480", Offset = "0x237B080", VA = "0x18237C480", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private readonly World JFAHNIMFMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private readonly Dictionary<CMECOJAJFAB, Entity> PNALABGJPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private readonly Dictionary<CMECOJAJFAB, EntityArchetype> PFOFBDLLIDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private readonly OKCKNNEEFJP BGABHAENGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private readonly Dictionary<HNGFAHNAKGA, CMECOJAJFAB> PKLEFGMGDDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private readonly Dictionary<JLAGNLCEABL, CMECOJAJFAB> GLMALENHNDO;

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		private IKBKLCEIKJI BLLIEFNJNEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0x6150C0", Offset = "0x613CC0", VA = "0x1806150C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public int NGNMMFPKHGG
		{
			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0x2383BC0", Offset = "0x23827C0", VA = "0x182383BC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public EntityManager JGHLJDFOODE
		{
			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0x1A556B0", Offset = "0x1A542B0", VA = "0x181A556B0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x2383CF0", Offset = "0x23828F0", VA = "0x182383CF0")]
		public ObjectPrefabs(World JFAHNIMFMGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x2383500", Offset = "0x2382100", VA = "0x182383500")]
		private void HNAOLGGIPNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x2383B30", Offset = "0x2382730", VA = "0x182383B30")]
		internal IEnumerable<Type> JLMENEAANOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x2382D80", Offset = "0x2381980", VA = "0x182382D80")]
		internal NFPGFGDIFCL AHNBHHCGKBH(Type LIJLAEFJGCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x2383110", Offset = "0x2381D10", VA = "0x182383110")]
		internal void EDCGFPAKENB(NFPGFGDIFCL JBPICCJKABG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0x2383800", Offset = "0x2382400", VA = "0x182383800")]
		internal void INNBKGPPDEK(CMECOJAJFAB LBEKIEDKPCN, MHAFPGDIKFN EKOEHAPKDIB, CIICOMNJJDE LEIHKFLMHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x2383A00", Offset = "0x2382600", VA = "0x182383A00")]
		private void JCBGCKGILLJ(CMECOJAJFAB LBEKIEDKPCN, MHAFPGDIKFN PDBANHEHPOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x2383C80", Offset = "0x2382880", VA = "0x182383C80")]
		public void PKMFLNNJPEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x2383B60", Offset = "0x2382760", VA = "0x182383B60")]
		public EntityArchetype LCCHBBPALPP(CMECOJAJFAB LBEKIEDKPCN)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x2383C10", Offset = "0x2382810", VA = "0x182383C10", Slot = "4")]
		[IteratorStateMachine(typeof(KJPPBJDAMAH))]
		public IEnumerable<(HNGFAHNAKGA, CMECOJAJFAB)> OONOPHGEGGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x2382DF0", Offset = "0x23819F0", VA = "0x182382DF0")]
		public Entity BMFKHGCIIMB(CMECOJAJFAB LBEKIEDKPCN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x2382F30", Offset = "0x2381B30", VA = "0x182382F30")]
		public CMECOJAJFAB DAHCABLJMIA(JLAGNLCEABL LIJLAEFJGCI)
		{
			return default(CMECOJAJFAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x2382ED0", Offset = "0x2381AD0", VA = "0x182382ED0")]
		public CMECOJAJFAB DAHCABLJMIA(HNGFAHNAKGA LIJLAEFJGCI)
		{
			return default(CMECOJAJFAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x2382F90", Offset = "0x2381B90", VA = "0x182382F90", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x23834B0", Offset = "0x23820B0", VA = "0x1823834B0")]
		public IEnumerable<CMECOJAJFAB> ENEHMGJHBEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x2382D20", Offset = "0x2381920", VA = "0x182382D20")]
		public Entity AEAJAEDCBFK(CMECOJAJFAB LBEKIEDKPCN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x2383700", Offset = "0x2382300", VA = "0x182383700")]
		internal Entity HNMBOFPADNK(CMECOJAJFAB LBEKIEDKPCN)
		{
			return default(Entity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[MHBJLGEIMOG(typeof(PropertyEventCallbacksService), new string[] { })]
	[GOMFNBMFGBH(ELBDNIJMKBJ.Callbacks)]
	public class PropertyEventCallbacksService : HKFIKAGKAAK
	{
		[Cpp2IlInjected.Token(Token = "0x200015E")]
		private struct PBPMAILGJKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public FDMOIMEDHPO KCGMNIDCJMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public Type LIJLAEFJGCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public int OEBMILJLIAL;
		}

		[Cpp2IlInjected.Token(Token = "0x200015F")]
		private struct BOLAMFAPLBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public PBPMAILGJKI[] GCALAGNGEDP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000160")]
		public delegate void FDMOIMEDHPO(Entity OCMABEPCGDM, LOGKGBLPOOD IPGOEGFNLNJ, CJHLIFJIIDK HKEHKHLKJGF, CJHLIFJIIDK DIPKCPLHHFM);

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private static readonly LJFAOMOPGNF FFJIMJJJOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private readonly Dictionary<LOGKGBLPOOD, FDMOIMEDHPO> CAFNNDOJIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private readonly Dictionary<int, BOLAMFAPLBL> IMJMNHBHEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private DMOLBBGANCB GCALAGNGEDP;

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action BNPDBPAMOLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0x23877C0", Offset = "0x23863C0", VA = "0x1823877C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000967")]
			[Cpp2IlInjected.Address(RVA = "0x2387FC0", Offset = "0x2386BC0", VA = "0x182387FC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action CEIGJCOLOOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000968")]
			[Cpp2IlInjected.Address(RVA = "0x2388290", Offset = "0x2386E90", VA = "0x182388290")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000969")]
			[Cpp2IlInjected.Address(RVA = "0x2387C60", Offset = "0x2386860", VA = "0x182387C60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x2388330", Offset = "0x2386F30", VA = "0x182388330", Slot = "4")]
		public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x2387E50", Offset = "0x2386A50", VA = "0x182387E50")]
		public void KIEPKILKNCN(LOGKGBLPOOD IPGOEGFNLNJ, FDMOIMEDHPO KCGMNIDCJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x2387AA0", Offset = "0x23866A0", VA = "0x182387AA0")]
		public void FDPECGBCCFP(LOGKGBLPOOD IPGOEGFNLNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x2387860", Offset = "0x2386460", VA = "0x182387860")]
		internal void DMMAHIMDEIG(FEEAFAEFFFL IADJLOGDJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x2388390", Offset = "0x2386F90", VA = "0x182388390")]
		private void PDBMADGIHNI(FEEAFAEFFFL IADJLOGDJJD, int OINILPILIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x2388060", Offset = "0x2386C60", VA = "0x182388060")]
		private void OCJCILJNGMB(FCAJCLOJKEA IOBOHFJFMJM, PDFLHPLNHMF GJKBIFDJJEP, PBPMAILGJKI FNDLGMAOEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x2387D00", Offset = "0x2386900", VA = "0x182387D00")]
		private BOLAMFAPLBL ILEALHNMEBJ(FCAJCLOJKEA IOBOHFJFMJM, PDFLHPLNHMF GJKBIFDJJEP)
		{
			return default(BOLAMFAPLBL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x2387B80", Offset = "0x2386780", VA = "0x182387B80")]
		private PBPMAILGJKI FPFFGJIOOLE(BOLAMFAPLBL GMPDMIJGEHC, FCAJCLOJKEA IOBOHFJFMJM, PDFLHPLNHMF GJKBIFDJJEP)
		{
			return default(PBPMAILGJKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0x23888D0", Offset = "0x23874D0", VA = "0x1823888D0")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
[MHBJLGEIMOG(typeof(DILLBIDCLLI), new string[] { })]
public class GOFPGILBFJP : HKFIKAGKAAK, GEPKKGPMACB, DILLBIDCLLI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class OCBHKEAJGBM : IEnumerable<NHHMKJOCNML>, IEnumerable, IEnumerator<NHHMKJOCNML>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private NHHMKJOCNML <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public GOFPGILBFJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private AFJDDNJABHB spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public AFJDDNJABHB <>3__spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		private NHHMKJOCNML System.Collections.Generic.IEnumerator<RecRoom.Components.SplinePoint>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x5ED000", Offset = "0x5EBC00", VA = "0x1805ED000", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NHHMKJOCNML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0x2379350", Offset = "0x2377F50", VA = "0x182379350", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0xA157D0", Offset = "0xA143D0", VA = "0x180A157D0")]
		[DebuggerHidden]
		public OCBHKEAJGBM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x2379100", Offset = "0x2377D00", VA = "0x182379100", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x2379300", Offset = "0x2377F00", VA = "0x182379300", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x2379250", Offset = "0x2377E50", VA = "0x182379250", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NHHMKJOCNML> System.Collections.Generic.IEnumerable<RecRoom.Components.SplinePoint>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x2379250", Offset = "0x2377E50", VA = "0x182379250", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private BHBECLCNBCK JFAHNIMFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private EKJEHNOGHHP DLGJBCGDDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private ObjectPrefabCreationService PNALABGJPMO;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private EntityManager JGHLJDFOODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x2369790", Offset = "0x2368390", VA = "0x182369790")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private BOCEAGHBLMC CCJAAPJEOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0x2368ED0", Offset = "0x2367AD0", VA = "0x182368ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x2369670", Offset = "0x2368270", VA = "0x182369670", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x2369390", Offset = "0x2367F90", VA = "0x182369390", Slot = "5")]
	public void MCGGEKIPLEO(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x2368E40", Offset = "0x2367A40", VA = "0x182368E40", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x2369B00", Offset = "0x2368700", VA = "0x182369B00")]
	private void PPBOMNEAGEO(Entity HGJDGAMEIAC, in CJHLIFJIIDK NBOLFCPAICP, in CJHLIFJIIDK FMKHLEANADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x2368F90", Offset = "0x2367B90", VA = "0x182368F90", Slot = "12")]
	public AFJDDNJABHB FLFOCNDOJDB()
	{
		return default(AFJDDNJABHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x23697E0", Offset = "0x23683E0", VA = "0x1823697E0", Slot = "6")]
	public NHHMKJOCNML POIPGOBFHBE(AFJDDNJABHB DPJJKLGNPDI, [Optional] Vector3? JACLPJHPOFC, [Optional] Quaternion? AHDCMPCBKHJ, [Optional] Vector3? LIDNCELIAFO)
	{
		return default(NHHMKJOCNML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x2368D60", Offset = "0x2367960", VA = "0x182368D60", Slot = "13")]
	public NHHMKJOCNML BBGNCPBALID(AFJDDNJABHB DPJJKLGNPDI, int HIANDEDCLIF, [Optional] Vector3? JACLPJHPOFC, [Optional] Quaternion? AHDCMPCBKHJ, [Optional] Vector3? LIDNCELIAFO)
	{
		return default(NHHMKJOCNML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x2369270", Offset = "0x2367E70", VA = "0x182369270", Slot = "7")]
	public NHHMKJOCNML JLJKLBPFINK(AFJDDNJABHB DPJJKLGNPDI, int HIANDEDCLIF)
	{
		return default(NHHMKJOCNML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x2368CD0", Offset = "0x23678D0", VA = "0x182368CD0", Slot = "14")]
	public void ALGDFOGAPKJ(AFJDDNJABHB DPJJKLGNPDI, NHHMKJOCNML DINLMIBFENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x2369020", Offset = "0x2367C20", VA = "0x182369020", Slot = "8")]
	public void ICFMPGABKFK(AFJDDNJABHB DPJJKLGNPDI, int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0x23694E0", Offset = "0x23680E0", VA = "0x1823694E0", Slot = "15")]
	public void NKAALJMCDBF(AFJDDNJABHB DPJJKLGNPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0x23696F0", Offset = "0x23682F0", VA = "0x1823696F0", Slot = "9")]
	public int PFPLCBOEKMP(AFJDDNJABHB DPJJKLGNPDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x2369450", Offset = "0x2368050", VA = "0x182369450", Slot = "10")]
	[IteratorStateMachine(typeof(OCBHKEAJGBM))]
	public IEnumerable<NHHMKJOCNML> NFEGDOBDNCG(AFJDDNJABHB DPJJKLGNPDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x2368DB0", Offset = "0x23679B0", VA = "0x182368DB0")]
	private bool BLAGMDBGLPI(AFJDDNJABHB DPJJKLGNPDI, out NativeArray<Entity> HIGOGPMFHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x23691C0", Offset = "0x2367DC0", VA = "0x1823691C0")]
	private NativeArray<Entity> IFMBBNHLGDN(AFJDDNJABHB DPJJKLGNPDI)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GOFPGILBFJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[MHBJLGEIMOG(typeof(AJECPHMBCBB), new string[] { })]
internal sealed class AJECPHMBCBB : HKFIKAGKAAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private BHBECLCNBCK JFAHNIMFMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private TransformOwnershipPhase JLCDBIKPJNF;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private IEEMDNAPKGD BONNMJFMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x26309C0", Offset = "0x262F5C0", VA = "0x1826309C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x2630A10", Offset = "0x262F610", VA = "0x182630A10", Slot = "4")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0x2630890", Offset = "0x262F490", VA = "0x182630890")]
	public void JLIIBLJKIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0x26305D0", Offset = "0x262F1D0", VA = "0x1826305D0")]
	public void FDEIPBKAJLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000996")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public AJECPHMBCBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
[DefaultMember("Item")]
public struct HKLPDEJLGON<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private T[] OAGMKJFIKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private int LEHFCNIEMMI;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public int BBJDPOLPLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4B0", Offset = "0x8AA0B0", VA = "0x1808AB4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public T GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x2870B10", Offset = "0x286F710", VA = "0x182870B10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Span<T> BEDGHNACFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x2CA40B0", Offset = "0x2CA2CB0", VA = "0x182CA40B0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool GAJOLDEOPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0xBC1190", Offset = "0xBBFD90", VA = "0x180BC1190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4150", Offset = "0x2CA2D50", VA = "0x182CA4150")]
	public HKLPDEJLGON(int LEHFCNIEMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3F40", Offset = "0x2CA2B40", VA = "0x182CA3F40")]
	public int DPCKACGJMLB(T KGJOJGIPNPH, int HGAEFGJCCPH, int BKKGFAKFDNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600099D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA3FF0", Offset = "0x2CA2BF0", VA = "0x182CA3FF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
[DefaultMember("Item")]
public struct DANAJMENMGB<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private global::HKLPDEJLGON<T> OAGMKJFIKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private int LEHFCNIEMMI;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public T GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x2F5DE10", Offset = "0x2F5CA10", VA = "0x182F5DE10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public int BBJDPOLPLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECED0", Offset = "0x5EBAD0", VA = "0x1805ECED0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x2F5D520", Offset = "0x2F5C120", VA = "0x182F5D520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public int LNGADAPJAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x2F5EA80", Offset = "0x2F5D680", VA = "0x182F5EA80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x2F5DC70", Offset = "0x2F5C870", VA = "0x182F5DC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool GAJOLDEOPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x2F5E500", Offset = "0x2F5D100", VA = "0x182F5E500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Span<T> BEDGHNACFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x2F5E590", Offset = "0x2F5D190", VA = "0x182F5E590")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x2F5ECB0", Offset = "0x2F5D8B0", VA = "0x182F5ECB0")]
	public DANAJMENMGB(int LEHFCNIEMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E540", Offset = "0x2F5D140", VA = "0x182F5E540")]
	public T JOGBNMDCDKM(int HIANDEDCLIF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x2F5DCC0", Offset = "0x2F5C8C0", VA = "0x182F5DCC0")]
	public void CLHJDKDIHGM(T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x2F5D690", Offset = "0x2F5C290", VA = "0x182F5D690")]
	public void BDBJHEPEMKC(Span<T> FPPBJGHNMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E800", Offset = "0x2F5D400", VA = "0x182F5E800")]
	public void LFMPFEAFMAL(T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x2F5EAB0", Offset = "0x2F5D6B0", VA = "0x182F5EAB0")]
	private void OPABKLJHFCC(int LAODCMGHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x2F5D9F0", Offset = "0x2F5C5F0", VA = "0x182F5D9F0")]
	public void BHLBJEJJMFO(Span<T> FNLGPCALBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E910", Offset = "0x2F5D510", VA = "0x182F5E910")]
	public void MGLBCPCJJMB(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E090", Offset = "0x2F5CC90", VA = "0x182F5E090")]
	public void HDFPLBDBNDE(int IHCNPEIKNDA, int OFINKJCDEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0x2F5DFC0", Offset = "0x2F5CBC0", VA = "0x182F5DFC0")]
	public void FNJJGGMAHAD(int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AF")]
	[Cpp2IlInjected.Address(RVA = "0x2F5D7F0", Offset = "0x2F5C3F0", VA = "0x182F5D7F0")]
	public void BDIGMIHDDNP(int IHCNPEIKNDA, int OFINKJCDEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0x2F5D570", Offset = "0x2F5C170", VA = "0x182F5D570")]
	public void ABMKOEHIKGO(int LAODCMGHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B1")]
	[Cpp2IlInjected.Address(RVA = "0x2F5DBB0", Offset = "0x2F5C7B0", VA = "0x182F5DBB0")]
	public void BMADBACPHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B2")]
	[Cpp2IlInjected.Address(RVA = "0x2F5DD30", Offset = "0x2F5C930", VA = "0x182F5DD30")]
	public int DPCKACGJMLB(T KGJOJGIPNPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x2F5D630", Offset = "0x2F5C230", VA = "0x182F5D630")]
	public bool ACOKKIFAPKJ(T KGJOJGIPNPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x2F5DDC0", Offset = "0x2F5C9C0", VA = "0x182F5DDC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x2F5EC50", Offset = "0x2F5D850", VA = "0x182F5EC50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E020", Offset = "0x2F5CC20", VA = "0x182F5E020")]
	public static Span<T> GOPIOOMOEDD(global::DANAJMENMGB<T> FPPBJGHNMLI)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E2A0", Offset = "0x2F5CEA0", VA = "0x182F5E2A0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void HPHENPADKBN(int KGJOJGIPNPH, int LEHFCNIEMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void JCFNBNOPCGC(int LEHFCNIEMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B9")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E3B0", Offset = "0x2F5CFB0", VA = "0x182F5E3B0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void JCFNBNOPCGC(int LEHFCNIEMMI, int HIANDEDCLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BA")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E970", Offset = "0x2F5D570", VA = "0x182F5E970")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void NLBNHICGFEN(int KGJOJGIPNPH, int LEHFCNIEMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E660", Offset = "0x2F5D260", VA = "0x182F5E660")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void LDIOFKCHOFH(int IHCNPEIKNDA, int OFINKJCDEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0x2F5DEB0", Offset = "0x2F5CAB0", VA = "0x182F5DEB0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void FMDDKKJOBNK(int KGJOJGIPNPH, int LEHFCNIEMMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public struct AJMOBODEMMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private const int JEONJJCIHOB = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private NativeList<Entity> MJFGMCFCBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private TransformAccessArray NGCBDOCNCGO;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public int NGNMMFPKHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2630E20", Offset = "0x262FA20", VA = "0x182630E20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public NativeList<Entity> JOGBCBNIAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0xB5B810", Offset = "0xB5A410", VA = "0x180B5B810")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public TransformAccessArray JLGGIJGJKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1D0", Offset = "0x5EADD0", VA = "0x1805EC1D0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009BD")]
	[Cpp2IlInjected.Address(RVA = "0x2630E70", Offset = "0x262FA70", VA = "0x182630E70")]
	public AJMOBODEMMA(int LAODCMGHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C1")]
	[Cpp2IlInjected.Address(RVA = "0x2630B40", Offset = "0x262F740", VA = "0x182630B40")]
	public Entity APNAOJGJEPH(int HIANDEDCLIF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C2")]
	[Cpp2IlInjected.Address(RVA = "0x2630CC0", Offset = "0x262F8C0", VA = "0x182630CC0")]
	public Transform IBILDJBADNC(int HIANDEDCLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0x2630C70", Offset = "0x262F870", VA = "0x182630C70")]
	public void HAMIJOCBEPK(int LAODCMGHKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x2630C00", Offset = "0x262F800", VA = "0x182630C00")]
	public void GOENPPICPAP(int CMBOJCLIKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x2630CD0", Offset = "0x262F8D0", VA = "0x182630CD0")]
	public int LFMPFEAFMAL(Transform BHPNFBEEMHL, Entity OCMABEPCGDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x2630DA0", Offset = "0x262F9A0", VA = "0x182630DA0")]
	public int MGLBCPCJJMB(int HIANDEDCLIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x2630B90", Offset = "0x262F790", VA = "0x182630B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x2630E30", Offset = "0x262FA30", VA = "0x182630E30")]
	private void OEAPCGCAJBL(int MEBMJNEMGFG = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
public class DGMMEPHDJAP : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly DGMMEPHDJAP KEBFNIGMDAM;

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x2634B90", Offset = "0x2633790", VA = "0x182634B90", Slot = "4")]
	public bool Equals(LinkedEntityGroup FEMNKHHBNAG, LinkedEntityGroup FAKOIENNMNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x2634BB0", Offset = "0x26337B0", VA = "0x182634BB0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup EBMPLNBFAKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public DGMMEPHDJAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal class LKAHBNKNGPP
{
	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	[Conditional("DEBUG_BUILD")]
	public static void AOOPEAECNCO(in Vector3 JACLPJHPOFC, in Quaternion AHDCMPCBKHJ, in Vector3 LIDNCELIAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	[Conditional("DEBUG_BUILD")]
	public static void CJOLCCNDJGE(in Vector3 CCGNOJOEEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	[Conditional("DEBUG_BUILD")]
	public static void KDPBGGDEGLF(in Quaternion AHDCMPCBKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	[Conditional("DEBUG_BUILD")]
	public static void BJKIKHMHGML(in Vector3 LPPFKPLNKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	[Conditional("DEBUG_BUILD")]
	public static void BOJEMDHPLAA(in Vector3 LPPFKPLNKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	[Conditional("DEBUG_BUILD")]
	public static void KEGADLNMDHD(in float MKJKCLCOGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x23753C0", Offset = "0x2373FC0", VA = "0x1823753C0")]
	[Conditional("DEBUG_BUILD")]
	public static void CAHJNDPKJNG(in float3 KGJOJGIPNPH, string CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	[Conditional("DEBUG_BUILD")]
	public static void FCPLGDOMJMD(in float KGJOJGIPNPH, string CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x23754F0", Offset = "0x23740F0", VA = "0x1823754F0")]
	[Conditional("DEBUG_BUILD")]
	public static void FCPLGDOMJMD(in Vector3 KGJOJGIPNPH, string CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x2375460", Offset = "0x2374060", VA = "0x182375460")]
	[Conditional("DEBUG_BUILD")]
	public static void FCPLGDOMJMD(in Quaternion KGJOJGIPNPH, string CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x2375590", Offset = "0x2374190", VA = "0x182375590")]
	[Conditional("DEBUG_BUILD")]
	public static void FIGLGPEGKFO(in float KGJOJGIPNPH, string CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x23755A0", Offset = "0x23741A0", VA = "0x1823755A0")]
	[Conditional("DEBUG_BUILD")]
	public static void FIGLGPEGKFO(in Vector3 KGJOJGIPNPH, string CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x2375640", Offset = "0x2374240", VA = "0x182375640")]
	[Conditional("DEBUG_BUILD")]
	public static void FIGLGPEGKFO(in Quaternion KGJOJGIPNPH, string CIJKLAFFGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public LKAHBNKNGPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public struct JJNFBNLEEON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public Entity OCMABEPCGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public Entity CPGJLPOPHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public Entity BIMAKIIINII;

	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x2373400", Offset = "0x2372000", VA = "0x182373400")]
	public JJNFBNLEEON(Entity OCMABEPCGDM, Entity CPGJLPOPHBK, Entity BIMAKIIINII)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x23733C0", Offset = "0x2371FC0", VA = "0x1823733C0")]
	public static JJNFBNLEEON GOPIOOMOEDD((Entity entity, Entity oldParent, Entity newParent) EOINJMPCCHJ)
	{
		return default(JJNFBNLEEON);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x23733A0", Offset = "0x2371FA0", VA = "0x1823733A0")]
	public void DPBHKONDICC(out Entity OCMABEPCGDM, out Entity CPGJLPOPHBK, out Entity BIMAKIIINII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public struct AEKCLLLDNHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public Entity OCMABEPCGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public Entity MKOLBPGKLJP;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0xDBC450", Offset = "0xDBB050", VA = "0x180DBC450")]
	public AEKCLLLDNHE(Entity OCMABEPCGDM, Entity MKOLBPGKLJP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x262C0E0", Offset = "0x262ACE0", VA = "0x18262C0E0")]
	public static AEKCLLLDNHE GOPIOOMOEDD((Entity entity, Entity parent) EOINJMPCCHJ)
	{
		return default(AEKCLLLDNHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x262C0D0", Offset = "0x262ACD0", VA = "0x18262C0D0")]
	public void DPBHKONDICC(out Entity OCMABEPCGDM, out Entity MKOLBPGKLJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
public struct KHLOKHEMELF<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private GCHandle CGGCCCAGOLF;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool KFNCLJJBJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x2638410", Offset = "0x2637010", VA = "0x182638410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public T ONGHMHAEIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x3EEAB10", Offset = "0x3EE9710", VA = "0x183EEAB10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x3EEAA50", Offset = "0x3EE9650", VA = "0x183EEAA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x3EEABB0", Offset = "0x3EE97B0", VA = "0x183EEABB0")]
	public KHLOKHEMELF(T KGJOJGIPNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E5")]
	[Cpp2IlInjected.Address(RVA = "0x3EEAA20", Offset = "0x3EE9620", VA = "0x183EEAA20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(OPLKEHAEBBL))]
public sealed class FOAHNAACDOA : JBHPFLDJLBM
{
	[Cpp2IlInjected.Token(Token = "0x60009E6")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public FOAHNAACDOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
[NFGOFKINMIG]
[UpdateAfter(typeof(FOAHNAACDOA))]
[UpdateInGroup(typeof(OPLKEHAEBBL))]
public sealed class ODNBIDADIJA : PreSerializeRemoveEntities
{
	[Cpp2IlInjected.Token(Token = "0x60009E8")]
	[Cpp2IlInjected.Address(RVA = "0x26B5930", Offset = "0x26B4530", VA = "0x1826B5930")]
	public ODNBIDADIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E9")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(OPLKEHAEBBL))]
[UpdateAfter(typeof(ODNBIDADIJA))]
public sealed class ONGGHOHDJEJ : GHHIDMJPNEC
{
	[Cpp2IlInjected.Token(Token = "0x60009EA")]
	[Cpp2IlInjected.Address(RVA = "0x2373420", Offset = "0x2372020", VA = "0x182373420")]
	public ONGGHOHDJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EB")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(OIAPGNOGFKL))]
public class PJGCHFEFPLE : IPBKPNEACJO
{
	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0x2373420", Offset = "0x2372020", VA = "0x182373420")]
	public PJGCHFEFPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0x26BAE00", Offset = "0x26B9A00", VA = "0x1826BAE00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(OIAPGNOGFKL))]
public class NNCFCOAJFBE : PDFNICOJFHB
{
	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public NNCFCOAJFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(OIAPGNOGFKL))]
public class MNFCPGONGLP : KJEDEFGDMHA
{
	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public MNFCPGONGLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2379060", Offset = "0x2377C60", VA = "0x182379060", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(AJOMDDICCJL))]
public sealed class NOFBHBEHIAH : GAKMKIPJOAF
{
	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x2634B80", Offset = "0x2633780", VA = "0x182634B80")]
	public NOFBHBEHIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x2634B70", Offset = "0x2633770", VA = "0x182634B70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(DDFLCIKFHOD))]
internal class ABMAMPEGJKD : DestroyLocalObjects
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x262BBF0", Offset = "0x262A7F0", VA = "0x18262BBF0")]
	public ABMAMPEGJKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(DDFLCIKFHOD))]
[UpdateAfter(typeof(ABMAMPEGJKD))]
internal class OEAMDNLODGN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public OEAMDNLODGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(MNGBJPKABJN))]
internal class ODGPGHOCCKO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public ODGPGHOCCKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
[NFGOFKINMIG]
[UpdateAfter(typeof(ODGPGHOCCKO))]
[UpdateInGroup(typeof(MNGBJPKABJN))]
internal class OHKJLIGNGOA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public OHKJLIGNGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[NFGOFKINMIG]
[UpdateAfter(typeof(OHKJLIGNGOA))]
[UpdateInGroup(typeof(MNGBJPKABJN))]
internal class JMBCJPAHADH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public JMBCJPAHADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(JMBCJPAHADH))]
internal class ADFMLADILAF : ONNJLEMOAEG
{
	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x262C0C0", Offset = "0x262ACC0", VA = "0x18262C0C0")]
	public ADFMLADILAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x262C0B0", Offset = "0x262ACB0", VA = "0x18262C0B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(JMBCJPAHADH))]
internal class FIEPGFOAKFF : JBJEBOPIGJO
{
	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x2366120", Offset = "0x2364D20", VA = "0x182366120")]
	public FIEPGFOAKFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0x23660E0", Offset = "0x2364CE0", VA = "0x1823660E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(JMBCJPAHADH))]
internal class BEGAEJLJIMN : LMOJOKAAIFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A02")]
	[Cpp2IlInjected.Address(RVA = "0x2633120", Offset = "0x2631D20", VA = "0x182633120")]
	public BEGAEJLJIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x2633110", Offset = "0x2631D10", VA = "0x182633110", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(OHKJLIGNGOA))]
internal sealed class CJKHAAICEEM : EFMFFJKGLOM
{
	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public CJKHAAICEEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x2634010", Offset = "0x2632C10", VA = "0x182634010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[NFGOFKINMIG]
[UpdateAfter(typeof(CJKHAAICEEM))]
[UpdateInGroup(typeof(OHKJLIGNGOA))]
internal sealed class DGBDMHOIKGN : GAKMKIPJOAF
{
	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x2634B80", Offset = "0x2633780", VA = "0x182634B80")]
	public DGBDMHOIKGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x2634B70", Offset = "0x2633770", VA = "0x182634B70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(OEAMDNLODGN))]
internal sealed class PGMGNPNCBIL : OOJICJENNJD
{
	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x26B7D40", Offset = "0x26B6940", VA = "0x1826B7D40")]
	public PGMGNPNCBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x26B7D00", Offset = "0x26B6900", VA = "0x1826B7D00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(OEAMDNLODGN))]
internal sealed class NOKELFOLDGP : RegisterTransforms
{
	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x26B4F30", Offset = "0x26B3B30", VA = "0x1826B4F30")]
	public NOKELFOLDGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x26B4F20", Offset = "0x26B3B20", VA = "0x1826B4F20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[NFGOFKINMIG]
[UpdateAfter(typeof(NOKELFOLDGP))]
[UpdateInGroup(typeof(OEAMDNLODGN))]
internal sealed class NAJAPHOHHLJ : CopyTransformDataFromGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x26B38E0", Offset = "0x26B24E0", VA = "0x1826B38E0")]
	public NAJAPHOHHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(MNDKDAMDNIL))]
internal class MEPPOFDDEJO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public MEPPOFDDEJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(MNDKDAMDNIL))]
internal class DMLICKCLLAG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public DMLICKCLLAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[NFGOFKINMIG]
[ExecuteAlways]
[UpdateInGroup(typeof(MNDKDAMDNIL))]
[UpdateAfter(typeof(MEPPOFDDEJO))]
internal sealed class ECLOGDOCNAM : AOJCKCOKMFP
{
	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public ECLOGDOCNAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[ExecuteAlways]
[NFGOFKINMIG]
[UpdateAfter(typeof(ECLOGDOCNAM))]
[UpdateInGroup(typeof(MNDKDAMDNIL))]
internal sealed class FDJLIONMHPD : DCKCKPBOMKE
{
	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public FDJLIONMHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
[NFGOFKINMIG]
[UpdateAfter(typeof(ECLOGDOCNAM))]
[UpdateInGroup(typeof(MNDKDAMDNIL))]
internal sealed class PKKGFMBLINN : ANJIEMLBMFE
{
	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x2373420", Offset = "0x2372020", VA = "0x182373420")]
	public PKKGFMBLINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
[AlwaysUpdateSystem]
[NFGOFKINMIG]
[UpdateInGroup(typeof(DMLICKCLLAG))]
internal sealed class PLDAIAIDANM : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	protected override ApplyPropertyDifferences DBDJFNOBFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0x26BAE10", Offset = "0x26B9A10", VA = "0x1826BAE10", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x26BAE60", Offset = "0x26B9A60", VA = "0x1826BAE60")]
	public PLDAIAIDANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[NFGOFKINMIG]
[UpdateAfter(typeof(PLDAIAIDANM))]
[UpdateInGroup(typeof(DMLICKCLLAG))]
internal sealed class COBHIBKAFMG : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x2634690", Offset = "0x2633290", VA = "0x182634690")]
	public COBHIBKAFMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
[NFGOFKINMIG]
[UpdateAfter(typeof(PLDAIAIDANM))]
[UpdateInGroup(typeof(DMLICKCLLAG))]
internal sealed class AHKJHMGMMBN : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x2373420", Offset = "0x2372020", VA = "0x182373420")]
	public AHKJHMGMMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
[NFGOFKINMIG]
[UpdateAfter(typeof(AHKJHMGMMBN))]
[UpdateInGroup(typeof(DMLICKCLLAG))]
internal sealed class AJIEIOBPIPB : EnqueuePropertyDifferenceToNetwork
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	protected override ComputePropertyDifferences FBHDONOMAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x2630A90", Offset = "0x262F690", VA = "0x182630A90", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x2630AE0", Offset = "0x262F6E0", VA = "0x182630AE0")]
	public AJIEIOBPIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(DMLICKCLLAG))]
[UpdateAfter(typeof(AJIEIOBPIPB))]
internal sealed class BHPCKKFOFCO : EJJHJAJEDJK
{
	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x2633130", Offset = "0x2631D30", VA = "0x182633130")]
	public BHPCKKFOFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(MEPPOFDDEJO))]
internal sealed class LGKODEBJIHG : CopyTransformDataToGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x2374C80", Offset = "0x2373880", VA = "0x182374C80")]
	public LGKODEBJIHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(MEPPOFDDEJO))]
internal sealed class POOBCFFOJDF : MBAGBKMIAKA
{
	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x2373420", Offset = "0x2372020", VA = "0x182373420")]
	public POOBCFFOJDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A27")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(MNGBJPKABJN))]
internal class EAHDNLJAHEE : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A28")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public EAHDNLJAHEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(MNGBJPKABJN))]
[UpdateAfter(typeof(EAHDNLJAHEE))]
internal sealed class PFPFFLJNEPJ : UpdateConnectableVisuals
{
	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x26BA4D0", Offset = "0x26B90D0", VA = "0x1826BA4D0")]
	public PFPFFLJNEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2B")]
	[Cpp2IlInjected.Address(RVA = "0x26BA4C0", Offset = "0x26B90C0", VA = "0x1826BA4C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[NFGOFKINMIG]
[ExecuteAlways]
[UpdateAfter(typeof(EAHDNLJAHEE))]
[UpdateInGroup(typeof(MNGBJPKABJN))]
internal sealed class NHJNICPCPLO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public NHJNICPCPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[NFGOFKINMIG]
[ExecuteAlways]
[UpdateInGroup(typeof(NHJNICPCPLO))]
internal sealed class DLBMCKENNNG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public DLBMCKENNNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
[ExecuteAlways]
[NFGOFKINMIG]
[UpdateInGroup(typeof(NHJNICPCPLO))]
[UpdateAfter(typeof(DLBMCKENNNG))]
internal sealed class MOCCMNGNDFB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A30")]
	[Cpp2IlInjected.Address(RVA = "0x2367D10", Offset = "0x2366910", VA = "0x182367D10")]
	public MOCCMNGNDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A31")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(MOCCMNGNDFB))]
internal sealed class JMHEAIPHPCK : OCEDNPMDBBC
{
	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0x2373420", Offset = "0x2372020", VA = "0x182373420")]
	public JMHEAIPHPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0x2373410", Offset = "0x2372010", VA = "0x182373410", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(MOCCMNGNDFB))]
[UpdateAfter(typeof(JMHEAIPHPCK))]
internal sealed class AKHKBNPDJIJ : BCHEMIIFLDF
{
	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public AKHKBNPDJIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x2630EF0", Offset = "0x262FAF0", VA = "0x182630EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(MOCCMNGNDFB))]
[UpdateAfter(typeof(AKHKBNPDJIJ))]
internal sealed class AGHGOBJJAIA : BJMLDLDMPNN
{
	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0")]
	public AGHGOBJJAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(MOCCMNGNDFB))]
[UpdateAfter(typeof(AGHGOBJJAIA))]
internal class DNHIAMCHMNC : PhysicsSceneUpdateCollidersSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x2635230", Offset = "0x2633E30", VA = "0x182635230")]
	public DNHIAMCHMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(DLBMCKENNNG))]
internal sealed class GEOKALJDOEL : SplineLocalBoundsSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x2366770", Offset = "0x2365370", VA = "0x182366770")]
	public GEOKALJDOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(EAHDNLJAHEE))]
internal sealed class NFJOGLMEJCC : INEFEDELCCC
{
	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public NFJOGLMEJCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
[NFGOFKINMIG]
[UpdateAfter(typeof(NFJOGLMEJCC))]
[UpdateInGroup(typeof(EAHDNLJAHEE))]
internal sealed class MFNIHIOEDPL : L2PToL2WHierarchy
{
	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x23789B0", Offset = "0x23775B0", VA = "0x1823789B0")]
	public MFNIHIOEDPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
[NFGOFKINMIG]
[UpdateAfter(typeof(NFJOGLMEJCC))]
[UpdateInGroup(typeof(EAHDNLJAHEE))]
internal sealed class LMNEGDFGPPM : KBKMGEOAHAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230")]
	public LMNEGDFGPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
[NFGOFKINMIG]
[UpdateAfter(typeof(LMNEGDFGPPM))]
[UpdateInGroup(typeof(EAHDNLJAHEE))]
[UpdateAfter(typeof(MFNIHIOEDPL))]
internal sealed class NFFEGLBMPFA : AHLJKFLAHGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x2373420", Offset = "0x2372020", VA = "0x182373420")]
	public NFFEGLBMPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(MJJJOFKFKII))]
internal class KJOPIHAKBCJ : BIOHNHBBAAL
{
	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x2373420", Offset = "0x2372020", VA = "0x182373420")]
	public KJOPIHAKBCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0x2374AB0", Offset = "0x23736B0", VA = "0x182374AB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(BHBDHBMOGPE))]
internal sealed class ACHDAPLOIPK : LNJFJAIJLBE
{
	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x2373420", Offset = "0x2372020", VA = "0x182373420")]
	public ACHDAPLOIPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x262C040", Offset = "0x262AC40", VA = "0x18262C040", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(BHBDHBMOGPE))]
[UpdateAfter(typeof(ACHDAPLOIPK))]
internal class FDHFJGPKEJD : PostLoadInitializeEmbodiment
{
	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x263AC70", Offset = "0x2639870", VA = "0x18263AC70")]
	public FDHFJGPKEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x263AC60", Offset = "0x2639860", VA = "0x18263AC60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
[NFGOFKINMIG]
[AlwaysUpdateSystem]
[UpdateInGroup(typeof(BHBDHBMOGPE))]
[UpdateAfter(typeof(FDHFJGPKEJD))]
internal sealed class PNPILMIONEB : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override ApplyPropertyDifferences DBDJFNOBFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(RVA = "0x26BB660", Offset = "0x26BA260", VA = "0x1826BB660", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x26BB6B0", Offset = "0x26BA2B0", VA = "0x1826BB6B0")]
	public PNPILMIONEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x7506E0", Offset = "0x74F2E0", VA = "0x1807506E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[NFGOFKINMIG]
[UpdateInGroup(typeof(BHBDHBMOGPE))]
[UpdateAfter(typeof(PNPILMIONEB))]
internal sealed class HBPBKMNBJIP : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x2369D30", Offset = "0x2368930", VA = "0x182369D30")]
	public HBPBKMNBJIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[NFGOFKINMIG]
[UpdateAfter(typeof(PNPILMIONEB))]
[UpdateInGroup(typeof(BHBDHBMOGPE))]
internal sealed class DHADFEPNFKP : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x2373420", Offset = "0x2372020", VA = "0x182373420")]
	public DHADFEPNFKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x2366230", Offset = "0x2364E30", VA = "0x182366230", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
[MHBJLGEIMOG(typeof(HMECPPGNBDI), new string[] { })]
public sealed class CFPMONECKFO : HMECPPGNBDI, HKFIKAGKAAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private LPLPHKHEJPF KHDJEFJLLKL;

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x2633FC0", Offset = "0x2632BC0", VA = "0x182633FC0", Slot = "5")]
	public void OMDIDBLNGMF(DEGAMIMEMLN CMPGNIIOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x2633EE0", Offset = "0x2632AE0", VA = "0x182633EE0")]
	public bool ECOKJLMGFIF(in float3 OBECBBNHKAL, in float3 NIIKOIAOGAL, float EIJHLGKIBNG, Allocator HGKGLCNFHPJ, out NativeArray<Entity> MJFGMCFCBDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public CFPMONECKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x2633EE0", Offset = "0x2632AE0", VA = "0x182633EE0", Slot = "4")]
	private bool CDNOJAOOLLJ(in float3 OBECBBNHKAL, in float3 NIIKOIAOGAL, float EIJHLGKIBNG, Allocator HGKGLCNFHPJ, out NativeArray<Entity> MJFGMCFCBDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[JKKNHDGKACM(typeof(AuthoredLocalPoseData))]
public sealed class OBBEMAGMCNH : NHPCKCFINFM
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x26B5210", Offset = "0x26B3E10", VA = "0x1826B5210", Slot = "8")]
	protected override bool DAJIKKJPFJJ(ReadOnlySpan<AuthoredLocalPoseData> FNLGPCALBEM, PAFBNCGGKDO AGDOOHGFMOM, out ReadOnlySpan<byte> HJKNKKDBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x26B5290", Offset = "0x26B3E90", VA = "0x1826B5290", Slot = "9")]
	protected override bool DPIMGKAHLNA(int MAAFFLODELA, Span<AuthoredLocalPoseData> FNLGPCALBEM, in ReadOnlySpan<byte> HJKNKKDBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x26B5350", Offset = "0x26B3F50", VA = "0x1826B5350")]
	public OBBEMAGMCNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[JKKNHDGKACM(typeof(LocalPoseData))]
public sealed class DHGMBNCIAFJ : LBMNAGDLPDC
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x2634C90", Offset = "0x2633890", VA = "0x182634C90", Slot = "8")]
	protected override bool DAJIKKJPFJJ(ReadOnlySpan<LocalPoseData> FNLGPCALBEM, PAFBNCGGKDO AGDOOHGFMOM, out ReadOnlySpan<byte> HJKNKKDBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x2634D10", Offset = "0x2633910", VA = "0x182634D10", Slot = "9")]
	protected override bool DPIMGKAHLNA(int MAAFFLODELA, Span<LocalPoseData> FNLGPCALBEM, in ReadOnlySpan<byte> HJKNKKDBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x2634DD0", Offset = "0x26339D0", VA = "0x182634DD0")]
	public DHGMBNCIAFJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[Preserve]
	internal class _RRAssemblyIndex : DGENKNGBBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC480", Offset = "0x5EB080", VA = "0x1805EC480")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x238F060", Offset = "0x238DC60", VA = "0x18238F060", Slot = "6")]
		public sealed override void CBLNFNGILAM(ENOEKOONOEP KCGMNIDCJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0x238F810", Offset = "0x238E410", VA = "0x18238F810", Slot = "4")]
		public sealed override void JHENDOAEKLB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
internal class NAPIEGELPGJ : ContainerPropertyBag<EANCAPJPPOK>
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	private class NOBMKOIANLI : Property<EANCAPJPPOK, DCFEMLAEOED>
	{
		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public override string DNLLPFFBEAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5F")]
			[Cpp2IlInjected.Address(RVA = "0x26B4EF0", Offset = "0x26B3AF0", VA = "0x1826B4EF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public override bool IDIBHBMOFCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000A60")]
			[Cpp2IlInjected.Address(RVA = "0x5ECEC0", Offset = "0x5EBAC0", VA = "0x1805ECEC0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x26B4EB0", Offset = "0x26B3AB0", VA = "0x1826B4EB0")]
		public NOBMKOIANLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x26B4E60", Offset = "0x26B3A60", VA = "0x1826B4E60", Slot = "11")]
		public override DCFEMLAEOED GetValue(ref EANCAPJPPOK NBELCHPBKDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x26B4E80", Offset = "0x26B3A80", VA = "0x1826B4E80", Slot = "12")]
		public override void SetValue(ref EANCAPJPPOK NBELCHPBKDK, DCFEMLAEOED KGJOJGIPNPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x26B3940", Offset = "0x26B2540", VA = "0x1826B3940")]
	public NAPIEGELPGJ()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x5850360", Offset = "0x584EF60", VA = "0x185850360")]
		[RuntimeInitializeOnLoadMethod]
		[Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001A7")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x2366B00", Offset = "0x2365700", VA = "0x182366B00")]
	private static string PBMOEILNFIF(byte[] EDLPJGEPJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x23667D0", Offset = "0x23653D0", VA = "0x1823667D0")]
	public static string EICDLCDOCAE(byte[] IAIFCDOPKGE, bool LFDDCGMHEMH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
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
