using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using Mono.Math;
using RecRoom.Components;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.Systems;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Core;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
public sealed class AJGIJBFEMAK<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class EJOFJHEMNJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::AJGIJBFEMAK<T> GPJKEDFCCAO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] AOMEOHNGFGB
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public EJOFJHEMNJA(global::AJGIJBFEMAK<T> GPJKEDFCCAO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class GDOJAJMFPBE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::AJGIJBFEMAK<T> <>4__this;

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
		public GDOJAJMFPBE(int <>1__state)
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
	private const int KAFGKAOIMNA = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> DODBGOONILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int FHBNCPPECMJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T OPKHBNOGHCE
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
	private bool ONEAKNMADMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool GKEGMDBILIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool GCMKHKONDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ODJEFCECEMG
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
	public int EONFJIOMKJN
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
	public AJGIJBFEMAK(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public AJGIJBFEMAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void ELGAMDPPEBI(int BNNEENLPEFO, T MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void IFFLOFKJNLP(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] HCHCDCPPAPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void CPHLJHEMCND(NativeArray<T> EJLDCNGHIAK, int BGCNDKINPDJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::AJGIJBFEMAK<>.GDOJAJMFPBE))]
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
	public int NJHNFHMHPKP(T MPIBAJOJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool DOHHNJJEEIG(T MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void IMPCFBJHJNE(int CLEALKECGJA, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void BFEMAAEHAEK(int CLEALKECGJA, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void IJNDOPBDKEN(int CLEALKECGJA, int HPNBOGMLOLG, int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int NOHGACIDHJJ(int BNNEENLPEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T KCLOANBAELH(int BNNEENLPEFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void GCCBPLFJBHO(int BNNEENLPEFO, T MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void NNKCDCGMHGJ(int BNNEENLPEFO, T MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void BHOLDDGBIGM(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int FFOLHNJJHEK(int GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int PAGKHFGFAFE(int GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void NGIHEIAPDMD(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void KILGLMJLBNK(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T KCPEKGFDNCN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T KGBPALFJOGK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void NGJKNKJCPBB(int BNNEENLPEFO, IReadOnlyCollection<T> BDLMAMHCIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void CLGPPLJMFLB(int BNNEENLPEFO, int GNMFPMEBEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void NHGEMPHHBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void HBGJEADGDPC(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void JGKEAAEOIJA(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void IJKOEFHGNEH(int HPNBOGMLOLG, int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T DJGLDEDONPD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T KNODKDJMCEN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[LFLHCBGKOFK]
public static class HIMBCODCAAF
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAC20", Offset = "0x2AA9820", VA = "0x182AAAC20")]
	static HIMBCODCAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2C806D0", Offset = "0x2C7F2D0", VA = "0x182C806D0")]
	public static void HAPLAILGCII<T>(T HOGBBBFDPKI, ref T DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2AAABC0", Offset = "0x2AA97C0", VA = "0x182AAABC0")]
	public static void HAPLAILGCII(FixedString32 HOGBBBFDPKI, ref string DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAB80", Offset = "0x2AA9780", VA = "0x182AAAB80")]
	public static void HAPLAILGCII(string HOGBBBFDPKI, ref FixedString32 DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2AAABF0", Offset = "0x2AA97F0", VA = "0x182AAABF0")]
	public static void HAPLAILGCII(FixedString64 HOGBBBFDPKI, ref string DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA990", Offset = "0x2AA9590", VA = "0x182AAA990")]
	public static void HAPLAILGCII(string HOGBBBFDPKI, ref FixedString64 DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAA80", Offset = "0x2AA9680", VA = "0x182AAAA80")]
	public static void HAPLAILGCII(CNBNEFCLPII HOGBBBFDPKI, ref Vector3 DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAAB0", Offset = "0x2AA96B0", VA = "0x182AAAAB0")]
	public static void HAPLAILGCII(Vector3 HOGBBBFDPKI, ref CNBNEFCLPII DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA8B0", Offset = "0x2AA94B0", VA = "0x182AAA8B0")]
	public static void HAPLAILGCII(ONKMONCCEIJ HOGBBBFDPKI, ref Vector4 DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA920", Offset = "0x2AA9520", VA = "0x182AAA920")]
	public static void HAPLAILGCII(Vector4 HOGBBBFDPKI, ref ONKMONCCEIJ DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA8B0", Offset = "0x2AA94B0", VA = "0x182AAA8B0")]
	public static void HAPLAILGCII(ONKMONCCEIJ HOGBBBFDPKI, ref Quaternion DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA920", Offset = "0x2AA9520", VA = "0x182AAA920")]
	public static void HAPLAILGCII(Quaternion HOGBBBFDPKI, ref ONKMONCCEIJ DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA9F0", Offset = "0x2AA95F0", VA = "0x182AAA9F0")]
	public static void HAPLAILGCII(CNBNEFCLPII HOGBBBFDPKI, ref float3 DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAAB0", Offset = "0x2AA96B0", VA = "0x182AAAAB0")]
	public static void HAPLAILGCII(float3 HOGBBBFDPKI, ref CNBNEFCLPII DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA8E0", Offset = "0x2AA94E0", VA = "0x182AAA8E0")]
	public static void HAPLAILGCII(ONKMONCCEIJ HOGBBBFDPKI, ref float4 DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA920", Offset = "0x2AA9520", VA = "0x182AAA920")]
	public static void HAPLAILGCII(float4 HOGBBBFDPKI, ref ONKMONCCEIJ DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA8E0", Offset = "0x2AA94E0", VA = "0x182AAA8E0")]
	public static void HAPLAILGCII(ONKMONCCEIJ HOGBBBFDPKI, ref quaternion DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAB10", Offset = "0x2AA9710", VA = "0x182AAAB10")]
	public static void HAPLAILGCII(quaternion HOGBBBFDPKI, ref ONKMONCCEIJ DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAA40", Offset = "0x2AA9640", VA = "0x182AAAA40")]
	public static void HAPLAILGCII(Entity HOGBBBFDPKI, ref EAKODDPCJDE DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2AAAA20", Offset = "0x2AA9620", VA = "0x182AAAA20")]
	public static void HAPLAILGCII(EAKODDPCJDE HOGBBBFDPKI, ref Entity DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OPLAMEBGNBC]
public class AHIEIGILMEM : ComponentSystem, OHFJHEDBJHF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PGEEJALGCGE LDOEMEGKBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x678130", Offset = "0x676D30", VA = "0x180678130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HFBJLIMBJCJ OIAHPJDJAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7DC0", VA = "0x1806B91C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D050", Offset = "0x2F8BC50", VA = "0x182F8D050", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
	public AHIEIGILMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OPLAMEBGNBC]
[UpdateInGroup(typeof(NDFCAEHCOAK))]
internal class PPGGGOLLAHN : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2A93270", Offset = "0x2A91E70", VA = "0x182A93270", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2A931F0", Offset = "0x2A91DF0", VA = "0x182A931F0")]
	[Preserve]
	private void HGPDFJKGCEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public PPGGGOLLAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[OPLAMEBGNBC]
[UpdateInGroup(typeof(NDFCAEHCOAK))]
internal class LFAJEALJKKJ : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2AB96D0", Offset = "0x2AB82D0", VA = "0x182AB96D0", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public LFAJEALJKKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CreateAssetMenu]
	public class ObjectModelConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2A87DC0", Offset = "0x2A869C0", VA = "0x182A87DC0")]
		public static ObjectModelConfigAsset PPAEFENCNOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xF00AE0", Offset = "0xEFF6E0", VA = "0x180F00AE0")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[HFIGNCEGOKM(DDEOJCINOPG.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[HFIGNCEGOKM(DDEOJCINOPG.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int AFLCPHCCBKP = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly FNIDFMEJGMB CBDAGBGGFJM;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x3DDDE70", Offset = "0x3DDCA70", VA = "0x183DDDE70")]
			public static ELJHNEOGEBP FIJDJMPBION(int EJAHJEKIEAG)
			{
				return default(ELJHNEOGEBP);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3DDDB10", Offset = "0x3DDC710", VA = "0x183DDDB10")]
			private static void BFCLMDGFLNJ(IOBECAADPPL EOBAPNHIDPG, IOBECAADPPL FJCPBNOHAPC, ELJHNEOGEBP FFJHOAAMJMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x3DDDCA0", Offset = "0x3DDC8A0", VA = "0x183DDDCA0")]
			public static int FHKCMEEHGHA(GameObject ENOCMPCACJI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3DDE260", Offset = "0x3DDCE60", VA = "0x183DDE260")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void LHDPFIPNPAF(IOBECAADPPL DKHOCCDNDOH, int EJAHJEKIEAG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static HGCFMABKDDJ FLBJMLJLEGK;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static CKDAIJCFICL NBPHCOAFDNK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static HGCFMABKDDJ FEFJCNCBGDN
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2A89220", Offset = "0x2A87E20", VA = "0x182A89220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2A894E0", Offset = "0x2A880E0", VA = "0x182A894E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static CKDAIJCFICL NNOGECKBPOG
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2A87F90", Offset = "0x2A86B90", VA = "0x182A87F90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2A88380", Offset = "0x2A86F80", VA = "0x182A88380")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool MPGGMKFNFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2A89280", Offset = "0x2A87E80", VA = "0x182A89280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static PGEEJALGCGE LDOEMEGKBCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2A895C0", Offset = "0x2A881C0", VA = "0x182A895C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static HFBJLIMBJCJ OIAHPJDJAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2A88B20", Offset = "0x2A87720", VA = "0x182A88B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LHNBKEDDAHF NJJHLCFOCPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2A88110", Offset = "0x2A86D10", VA = "0x182A88110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static CGEDEAJAIJO CCKOPMBDMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2A88980", Offset = "0x2A87580", VA = "0x182A88980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static BLGCKCAEBNA EKBGIHOCMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2A88810", Offset = "0x2A87410", VA = "0x182A88810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static NDJGAFFBPCH PKEGKBMDJJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2A898E0", Offset = "0x2A884E0", VA = "0x182A898E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool NBJDJJDGLLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2A890E0", Offset = "0x2A87CE0", VA = "0x182A890E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool MKBBGDGPAGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2A88190", Offset = "0x2A86D90", VA = "0x182A88190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool CFOHIKABMBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2A89080", Offset = "0x2A87C80", VA = "0x182A89080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2A880B0", Offset = "0x2A86CB0", VA = "0x182A880B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool MMJHAIKHCOE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2A891C0", Offset = "0x2A87DC0", VA = "0x182A891C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2A89790", Offset = "0x2A88390", VA = "0x182A89790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action JLDPCGLOKKD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2A893E0", Offset = "0x2A87FE0", VA = "0x182A893E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2A88BA0", Offset = "0x2A877A0", VA = "0x182A88BA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2A88890", Offset = "0x2A87490", VA = "0x182A88890")]
		public static IOBECAADPPL FEEDHGOGJCP(GameObject ENOCMPCACJI)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2A88CA0", Offset = "0x2A878A0", VA = "0x182A88CA0")]
		public static bool HAHFMLGMGED(ByteString MEFFDBODCGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2A88A00", Offset = "0x2A87600", VA = "0x182A88A00")]
		public static MFPKOBHCDLK FOPFDIPOBCG(ELJHNEOGEBP FFJHOAAMJMD)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2A88600", Offset = "0x2A87200", VA = "0x182A88600")]
		public static (ByteString, IDisposable) CLPGJOCDFOA()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2A89660", Offset = "0x2A88260", VA = "0x182A89660")]
		public static (ByteString, IDisposable) OEMICKMDFJI(IEnumerable<IOBECAADPPL> MIDBODKMKIJ)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2A87E60", Offset = "0x2A86A60", VA = "0x182A87E60")]
		public static bool AJHBGFMPDJP(GameObject ENOCMPCACJI, out ELJHNEOGEBP FFJHOAAMJMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2A897F0", Offset = "0x2A883F0", VA = "0x182A897F0")]
		public static bool OOFHELPOEED(IEnumerable<KPBHHJNMPGI> JNPPLACLHGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2A88730", Offset = "0x2A87330", VA = "0x182A88730")]
		public static void EEFBGNFDBDE(bool DHOJGMOHHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2A88D00", Offset = "0x2A87900", VA = "0x182A88D00")]
		public static Task HPDNEIPMNKO(bool DHOJGMOHHOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2A88FA0", Offset = "0x2A87BA0", VA = "0x182A88FA0")]
		private static CKDAIJCFICL IGJEMGAGPOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2A88E80", Offset = "0x2A87A80", VA = "0x182A88E80")]
		private static bool HPGPHOJKKMF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[HFIGNCEGOKM(DDEOJCINOPG.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DF50", Offset = "0x2A8CB50", VA = "0x182A8DF50")]
		public static bool DADIJENPEME(IAEGHKEFOHF BIGAHGNBDLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E000", Offset = "0x2A8CC00", VA = "0x182A8E000")]
		public static IAEGHKEFOHF EHMHLLLMBAF(GameObject ENOCMPCACJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E230", Offset = "0x2A8CE30", VA = "0x182A8E230")]
		public static IAEGHKEFOHF EHMHLLLMBAF(GameObject ENOCMPCACJI, ELJHNEOGEBP FFJHOAAMJMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DE50", Offset = "0x2A8CA50", VA = "0x182A8DE50")]
		public static bool CAJOFGDHJFL(GameObject HCKEHDIEAIK, string BEKHBMMBGHO, bool OIHKIJANKEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E430", Offset = "0x2A8D030", VA = "0x182A8E430")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void FMECODKKJOE(GameObject HCKEHDIEAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2A8E630", Offset = "0x2A8D230", VA = "0x182A8E630")]
		[CompilerGenerated]
		internal static string JHFCOOECGNP((GameObject go, string prefabName) MAGEMABOILP)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, LEEPAKIJGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool MKNOGDLMDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696C20", VA = "0x180698020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public IOBECAADPPL BIKFLMMEOOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696C40", VA = "0x180698040", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(IOBECAADPPL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x2DFA500", Offset = "0x2DF9100", VA = "0x182DFA500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[HFIGNCEGOKM(DDEOJCINOPG.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, IAEGHKEFOHF, LEEPAKIJGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string BLHOMDFFJKB = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private IHGCIGLLFKA OPCGPJFHEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IOBECAADPPL IBGBBCHPJJF;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public IOBECAADPPL BIKFLMMEOOF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2FA9BC0", Offset = "0x2FA87C0", VA = "0x182FA9BC0", Slot = "15")]
			get
			{
				return default(IOBECAADPPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public MFPKOBHCDLK DPFBOJFINBN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2FA9C70", Offset = "0x2FA8870", VA = "0x182FA9C70", Slot = "6")]
			get
			{
				return default(MFPKOBHCDLK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool MKNOGDLMDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2FA9BB0", Offset = "0x2FA87B0", VA = "0x182FA9BB0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IHGCIGLLFKA PDCFCDHBBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9E78C0", Offset = "0x9E64C0", VA = "0x1809E78C0", Slot = "7")]
			get
			{
				return default(IHGCIGLLFKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private HFBJLIMBJCJ OIAHPJDJAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x2FA9340", Offset = "0x2FA7F40", VA = "0x182FA9340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private JOBGNDCAMAM AIMCCKBDHJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2FA92E0", Offset = "0x2FA7EE0", VA = "0x182FA92E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool HJMACANLLMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766B80", VA = "0x180767F80", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x731170", Offset = "0x72FD70", VA = "0x180731170", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> IAJCDKDADBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2FA9A70", Offset = "0x2FA8670", VA = "0x182FA9A70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2FA9CA0", Offset = "0x2FA88A0", VA = "0x182FA9CA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<IAEGHKEFOHF> FGCIGIEOIKP
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2FA9B10", Offset = "0x2FA8710", VA = "0x182FA9B10", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2FA9D40", Offset = "0x2FA8940", VA = "0x182FA9D40", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2FA8E80", Offset = "0x2FA7A80", VA = "0x182FA8E80")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2FA98D0", Offset = "0x2FA84D0", VA = "0x182FA98D0", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2FA9510", Offset = "0x2FA8110", VA = "0x182FA9510", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2FA9840", Offset = "0x2FA8440", VA = "0x182FA9840", Slot = "10")]
		public void OnEmbody(EEHCKCIAPAN AEEDEJIEEFL, IOBECAADPPL IBGBBCHPJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2FA98C0", Offset = "0x2FA84C0", VA = "0x182FA98C0", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA9630", Offset = "0x2FA8230", VA = "0x182FA9630", Slot = "12")]
		public void OnDisembody(bool JMHJCNMKLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2FA91E0", Offset = "0x2FA7DE0", VA = "0x182FA91E0")]
		private void EMEPNBPGKKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2FA9420", Offset = "0x2FA8020", VA = "0x182FA9420")]
		private void IHDDNHABLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2FA9000", Offset = "0x2FA7C00", VA = "0x182FA9000")]
		private void BHKJAPMCHOA(bool ODDBKPJIGNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2FA94B0", Offset = "0x2FA80B0", VA = "0x182FA94B0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1182670", Offset = "0x1181270", VA = "0x181182670", Slot = "9")]
		private GameObject KAMHEAOEAHM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[HFIGNCEGOKM(DDEOJCINOPG.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override OADLDHPKENB HIANPFOIJFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2A9B7B0", Offset = "0x2A9A3B0", VA = "0x182A9B7B0", Slot = "6")]
			get
			{
				return default(OADLDHPKENB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B750", Offset = "0x2A9A350", VA = "0x182A9B750")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[HFIGNCEGOKM(DDEOJCINOPG.Registration)]
	public class TransformEntity : MonoBehaviour, LEEPAKIJGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private OADLDHPKENB prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IOBECAADPPL DKHOCCDNDOH;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual OADLDHPKENB HIANPFOIJFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6777D0", VA = "0x180678BD0", Slot = "6")]
			get
			{
				return default(OADLDHPKENB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x71B410", Offset = "0x71A010", VA = "0x18071B410", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IOBECAADPPL BIKFLMMEOOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCD1120", Offset = "0xCCFD20", VA = "0x180CD1120", Slot = "5")]
			get
			{
				return default(IOBECAADPPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool MKNOGDLMDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675C30", VA = "0x180677030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x812720", Offset = "0x811320", VA = "0x180812720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal Entity CDCPMNPKIHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal BLGCKCAEBNA EKBGIHOCMFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal JOBGNDCAMAM BBLKMPHNEAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2D86DE0", Offset = "0x2D859E0", VA = "0x182D86DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D869D0", Offset = "0x2D855D0", VA = "0x182D869D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D869E0", Offset = "0x2D855E0", VA = "0x182D869E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2D86AD0", Offset = "0x2D856D0", VA = "0x182D86AD0")]
		internal void FNJOFAEFPIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D86F10", Offset = "0x2D85B10", VA = "0x182D86F10")]
		private bool PCPPNDBPHNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D86E50", Offset = "0x2D85A50", VA = "0x182D86E50")]
		private void LFMLCAJHMGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D869E0", Offset = "0x2D855E0", VA = "0x182D869E0")]
		internal void CGILPHFOCHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D86E80", Offset = "0x2D85A80", VA = "0x182D86E80")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D87000", Offset = "0x2D85C00", VA = "0x182D87000")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[IAGJGLKEJDP(typeof(AHBAMJDCEOG))]
[DAMCBGMFJNJ(typeof(CKDAIJCFICL), new string[] { })]
public class KONPIIIEAJC : LKADCDBLCDN, PPOMMDPBBOP, CKDAIJCFICL, OIAIMMLKKAN, AHBAMJDCEOG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private FEGPLAEFMOI HFDOFHJBJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private HFBJLIMBJCJ PCMOOAJDLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MCFPIPCNFDN KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private PKOBMDDCGBM NKIINCCIBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public AHPBGKKBONO FBGBCINBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C84C0", Offset = "0x8C70C0", VA = "0x1808C84C0", Slot = "19")]
		get
		{
			return default(AHPBGKKBONO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public FEGPLAEFMOI LDOEMEGKBCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public MCFPIPCNFDN JHMDIDKKOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public HFBJLIMBJCJ OIAHPJDJAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool AACDAEOPAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675C30", VA = "0x180677030", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool PAOBNFNAFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7510", Offset = "0x2AB6110", VA = "0x182AB7510", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2AB7170", Offset = "0x2AB5D70", VA = "0x182AB7170", Slot = "20")]
	public void LHCOLCBEPCK(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7C9810", Offset = "0x7C8410", VA = "0x1807C9810")]
	private void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6CF0", Offset = "0x2AB58F0", VA = "0x182AB6CF0")]
	private void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	private void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6E80", Offset = "0x2AB5A80", VA = "0x182AB6E80", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2AB7090", Offset = "0x2AB5C90", VA = "0x182AB7090", Slot = "10")]
	public void HAEFFNNFOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "4")]
	public void HPCCMFHOKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2AB7300", Offset = "0x2AB5F00", VA = "0x182AB7300", Slot = "5")]
	public void MFGMDDJEENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6EE0", Offset = "0x2AB5AE0", VA = "0x182AB6EE0", Slot = "6")]
	public void EAGINIEFBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6F30", Offset = "0x2AB5B30", VA = "0x182AB6F30", Slot = "7")]
	public void FOGMCMNIEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2AB7520", Offset = "0x2AB6120", VA = "0x182AB7520", Slot = "8")]
	public bool OOFHELPOEED(IEnumerable<KPBHHJNMPGI> JNPPLACLHGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2AB74A0", Offset = "0x2AB60A0", VA = "0x182AB74A0", Slot = "9")]
	public void NHJFFFEKKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2AB7100", Offset = "0x2AB5D00", VA = "0x182AB7100", Slot = "11")]
	public void KDBCJFDIBNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2AB7280", Offset = "0x2AB5E80", VA = "0x182AB7280", Slot = "12")]
	public void MDFOLHHLPFL(bool OFIHIKCKNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2AB70D0", Offset = "0x2AB5CD0", VA = "0x182AB70D0")]
	private void HCKPBLLMLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6DA0", Offset = "0x2AB59A0", VA = "0x182AB6DA0", Slot = "13")]
	public ByteString CLPGJOCDFOA(out IDisposable ABGOLHJFIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2AB7370", Offset = "0x2AB5F70", VA = "0x182AB7370", Slot = "14")]
	public void MNOLKCHHLIP(ByteString JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2AB6FA0", Offset = "0x2AB5BA0", VA = "0x182AB6FA0")]
	public static KONPIIIEAJC GLBIKEOEKPG(FEGPLAEFMOI HFDOFHJBJGD, IMFOEJGFLNN MBNFLPKEEGH = IMFOEJGFLNN.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	private static void INEIGOGMALF(FEGPLAEFMOI HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	private static void MALADBIKIAO(FEGPLAEFMOI HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KONPIIIEAJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NPAKLOPBCBN
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E150", Offset = "0x2A7CD50", VA = "0x182A7E150")]
	public static MFPKOBHCDLK BBEBKABPFOC(this CKDAIJCFICL NBPHCOAFDNK, ELJHNEOGEBP FFJHOAAMJMD, OADLDHPKENB FKEOEHMKOOO)
	{
		return default(MFPKOBHCDLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E470", Offset = "0x2A7D070", VA = "0x182A7E470")]
	public static OEHLCFMEIAB HKGIPEPAOCC(this CKDAIJCFICL NBPHCOAFDNK)
	{
		return default(OEHLCFMEIAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E3C0", Offset = "0x2A7CFC0", VA = "0x182A7E3C0")]
	public static IOBECAADPPL FEEDHGOGJCP(this CKDAIJCFICL NBPHCOAFDNK, Entity LLEBIIAHFDD)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E290", Offset = "0x2A7CE90", VA = "0x182A7E290")]
	public static IOBECAADPPL FEEDHGOGJCP(this CKDAIJCFICL NBPHCOAFDNK, ELJHNEOGEBP FFJHOAAMJMD)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E590", Offset = "0x2A7D190", VA = "0x182A7E590")]
	public static ELJHNEOGEBP HLAFIPJDKEG(this CKDAIJCFICL NBPHCOAFDNK, IOBECAADPPL DKHOCCDNDOH)
	{
		return default(ELJHNEOGEBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum IMFOEJGFLNN
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class HDDCHEPFNLD<T> : global::KAGKJGEIBJF<T>, global::JKHOGOMAANC<ELJHNEOGEBP, T>, global::IDGMOCNLFGC<ELJHNEOGEBP>, MLDLKMLLJME, IDisposable, HLBEOPKMMDF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::IDGMOCNLFGC<Entity> GCEENFOFNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate JGEEJJBFLAJ;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string GJLDGPDNPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3D65B60", Offset = "0x3D64760", VA = "0x183D65B60", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type MACDLFHPGNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3D5DBA0", Offset = "0x3D5C7A0", VA = "0x183D5DBA0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FIOMMIJIHBF EGCAHIONBKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3D5AA50", Offset = "0x3D59650", VA = "0x183D5AA50", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int IECABHILINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D5D0C0", Offset = "0x3D5BCC0", VA = "0x183D5D0C0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IKOPFDFGIPG GIIPMLBAOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3D6BD90", Offset = "0x3D6A990", VA = "0x183D6BD90", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1AFC670", Offset = "0x1AFB270", VA = "0x181AFC670", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3D5F0A0", Offset = "0x3D5DCA0", VA = "0x183D5F0A0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::PCLPPLPNNDP<ELJHNEOGEBP> JLDPCGLOKKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3D64A70", Offset = "0x3D63670", VA = "0x183D64A70", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3D5E3D0", Offset = "0x3D5CFD0", VA = "0x183D5E3D0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3638540", Offset = "0x3637140", VA = "0x183638540")]
	public HDDCHEPFNLD(global::IDGMOCNLFGC<Entity> GCEENFOFNFL, BLGCKCAEBNA EFJCPEJOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3D653A0", Offset = "0x3D63FA0", VA = "0x183D653A0")]
	private Entity LEEEFIBDGIA(ELJHNEOGEBP FFJHOAAMJMD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3D64DE0", Offset = "0x3D639E0", VA = "0x183D64DE0")]
	private ELJHNEOGEBP LEEEFIBDGIA(Entity LLEBIIAHFDD)
	{
		return default(ELJHNEOGEBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3D5F500", Offset = "0x3D5E100", VA = "0x183D5F500", Slot = "4")]
	public T HMFHOBMDMGG(ELJHNEOGEBP FFJHOAAMJMD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3D67560", Offset = "0x3D66160", VA = "0x183D67560")]
	public bool NMFBOCJEJOB(ELJHNEOGEBP FFJHOAAMJMD, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3D6CD70", Offset = "0x3D6B970", VA = "0x183D6CD70")]
	public bool ONIEOJAKANA(ELJHNEOGEBP FFJHOAAMJMD, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3D5D750", Offset = "0x3D5C350", VA = "0x183D5D750", Slot = "9")]
	public bool FONENOMBNOF(ELJHNEOGEBP FFJHOAAMJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3D62BA0", Offset = "0x3D617A0", VA = "0x183D62BA0", Slot = "26")]
	public object JGBPAAPKKLK(ELJHNEOGEBP FFJHOAAMJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3D5C080", Offset = "0x3D5AC80", VA = "0x183D5C080")]
	public bool AJMLBPKCBLJ(ELJHNEOGEBP FFJHOAAMJMD, in object IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3D61AA0", Offset = "0x3D606A0", VA = "0x183D61AA0")]
	public void HMFHOBMDMGG(ELJHNEOGEBP FFJHOAAMJMD, in PMECDNBONOH GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3D65ED0", Offset = "0x3D64AD0", VA = "0x183D65ED0")]
	public bool NMFBOCJEJOB(ELJHNEOGEBP FFJHOAAMJMD, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3D6C260", Offset = "0x3D6AE60", VA = "0x183D6C260")]
	public bool ONIEOJAKANA(ELJHNEOGEBP FFJHOAAMJMD, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x36322C0", Offset = "0x3630EC0", VA = "0x1836322C0", Slot = "22")]
	public void KGEJHADOBPB(CPCNLIBKLCB EHGIDPAFOKH, [Optional] object EDPENIGJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3D63390", Offset = "0x3D61F90", VA = "0x183D63390", Slot = "15")]
	public void KGEJHADOBPB(ELJHNEOGEBP BIMCDHOFDCP, BBPNDNFFEFA EHGIDPAFOKH, object EDPENIGJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3D5EAB0", Offset = "0x3D5D6B0", VA = "0x183D5EAB0", Slot = "14")]
	public bool HBNCLABAILL(ELJHNEOGEBP DKIFKKDEOHM, ELJHNEOGEBP HOGBBBFDPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2699890", Offset = "0x2698490", VA = "0x182699890", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3D751F0", Offset = "0x3D73DF0", VA = "0x183D751F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3BAD400", Offset = "0x3BAC000", VA = "0x183BAD400")]
	public string AEKNGOPJJEL(in EKBGHCIKEGG PEFOOCOGGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3D6A030", Offset = "0x3D68C30", VA = "0x183D6A030")]
	private void NPBAEECDKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3D688B0", Offset = "0x3D674B0", VA = "0x183D688B0")]
	private void NNEBNPNLBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3D71A70", Offset = "0x3D70670", VA = "0x183D71A70")]
	private void POAOKFGBMEH(Entity LLEBIIAHFDD, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3D627B0", Offset = "0x3D613B0", VA = "0x183D627B0")]
	private void HPHHCEKMBPD(Entity LLEBIIAHFDD, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DE80", Offset = "0x3D6CA80", VA = "0x183D6DE80")]
	[Conditional("DEBUG_BUILD")]
	private static void PJLBPCOAKKL(Entity LLEBIIAHFDD, ELJHNEOGEBP FFJHOAAMJMD, string BBEHMKMODBA, string OOPFHPKJFAK, [CallerMemberName] string OEFLJIGICBN = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2278280", Offset = "0x2276E80", VA = "0x182278280", Slot = "5")]
	private bool KFILONOONKJ(ELJHNEOGEBP BIMCDHOFDCP, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3109770", Offset = "0x3108370", VA = "0x183109770", Slot = "6")]
	private bool DHPGCNKAGOM(ELJHNEOGEBP BIMCDHOFDCP, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x39BB110", Offset = "0x39B9D10", VA = "0x1839BB110", Slot = "10")]
	private bool FBFHJKPKKDG(ELJHNEOGEBP BIMCDHOFDCP, in object IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3D5CCA0", Offset = "0x3D5B8A0", VA = "0x183D5CCA0", Slot = "11")]
	private void DKMDEFFFPFO(ELJHNEOGEBP BIMCDHOFDCP, in PMECDNBONOH GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3D62140", Offset = "0x3D60D40", VA = "0x183D62140", Slot = "12")]
	private bool HNJIFLOKKEO(ELJHNEOGEBP BIMCDHOFDCP, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3D5CCD0", Offset = "0x3D5B8D0", VA = "0x183D5CCD0", Slot = "13")]
	private bool EEIABOODPDD(ELJHNEOGEBP BIMCDHOFDCP, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x362F820", Offset = "0x362E420", VA = "0x18362F820", Slot = "16")]
	private string AAJECMFIDAI(in EKBGHCIKEGG GKFICKKHACC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class AMDLBDOEOBO<T> : global::EDNHLHPJOPH<T>, global::JKHOGOMAANC<IOBECAADPPL, T>, global::IDGMOCNLFGC<IOBECAADPPL>, MLDLKMLLJME, IDisposable, HLPDKNGJOIH where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly global::IDGMOCNLFGC<Entity> GCEENFOFNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Delegate JGEEJJBFLAJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string GJLDGPDNPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3BB1830", Offset = "0x3BB0430", VA = "0x183BB1830", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Type MACDLFHPGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3BAE7E0", Offset = "0x3BAD3E0", VA = "0x183BAE7E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public FIOMMIJIHBF EGCAHIONBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3BAD220", Offset = "0x3BABE20", VA = "0x183BAD220", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int IECABHILINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3BAE280", Offset = "0x3BACE80", VA = "0x183BAE280", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IKOPFDFGIPG GIIPMLBAOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3FF0", Offset = "0x3BB2BF0", VA = "0x183BB3FF0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3630090", Offset = "0x362EC90", VA = "0x183630090", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3BAF130", Offset = "0x3BADD30", VA = "0x183BAF130", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::PCLPPLPNNDP<IOBECAADPPL> JLDPCGLOKKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3BB1370", Offset = "0x3BAFF70", VA = "0x183BB1370", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3BAEA70", Offset = "0x3BAD670", VA = "0x183BAEA70", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3638540", Offset = "0x3637140", VA = "0x183638540")]
	public AMDLBDOEOBO(global::IDGMOCNLFGC<Entity> GCEENFOFNFL, BLGCKCAEBNA EFJCPEJOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x136CB30", Offset = "0x136B730", VA = "0x18136CB30")]
	private Entity LEEEFIBDGIA(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x36330B0", Offset = "0x3631CB0", VA = "0x1836330B0")]
	private IOBECAADPPL LEEEFIBDGIA(Entity LLEBIIAHFDD)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3BAF870", Offset = "0x3BAE470", VA = "0x183BAF870", Slot = "4")]
	public T HMFHOBMDMGG(IOBECAADPPL DKHOCCDNDOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3BB1970", Offset = "0x3BB0570", VA = "0x183BB1970")]
	public bool NMFBOCJEJOB(IOBECAADPPL DKHOCCDNDOH, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3BB41C0", Offset = "0x3BB2DC0", VA = "0x183BB41C0")]
	public bool ONIEOJAKANA(IOBECAADPPL DKHOCCDNDOH, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE500", Offset = "0x3BAD100", VA = "0x183BAE500", Slot = "9")]
	public bool FONENOMBNOF(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3BB0980", Offset = "0x3BAF580", VA = "0x183BB0980", Slot = "26")]
	public object JGBPAAPKKLK(IOBECAADPPL DKHOCCDNDOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3BAD790", Offset = "0x3BAC390", VA = "0x183BAD790")]
	public bool AJMLBPKCBLJ(IOBECAADPPL DKHOCCDNDOH, in object IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3BAFE70", Offset = "0x3BAEA70", VA = "0x183BAFE70")]
	public void HMFHOBMDMGG(IOBECAADPPL DKHOCCDNDOH, in PMECDNBONOH GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3BB24E0", Offset = "0x3BB10E0", VA = "0x183BB24E0")]
	public bool NMFBOCJEJOB(IOBECAADPPL DKHOCCDNDOH, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3BB4760", Offset = "0x3BB3360", VA = "0x183BB4760")]
	public bool ONIEOJAKANA(IOBECAADPPL DKHOCCDNDOH, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x36322C0", Offset = "0x3630EC0", VA = "0x1836322C0", Slot = "22")]
	public void KGEJHADOBPB(CPCNLIBKLCB EHGIDPAFOKH, [Optional] object EDPENIGJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3BB0D60", Offset = "0x3BAF960", VA = "0x183BB0D60", Slot = "15")]
	public void KGEJHADOBPB(IOBECAADPPL BIMCDHOFDCP, BBPNDNFFEFA EHGIDPAFOKH, object EDPENIGJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEFC0", Offset = "0x3BADBC0", VA = "0x183BAEFC0", Slot = "14")]
	public bool HBNCLABAILL(IOBECAADPPL DKIFKKDEOHM, IOBECAADPPL HOGBBBFDPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3BB38C0", Offset = "0x3BB24C0", VA = "0x183BB38C0")]
	private void NPBAEECDKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3BB29B0", Offset = "0x3BB15B0", VA = "0x183BB29B0")]
	private void NNEBNPNLBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5E00", Offset = "0x3BB4A00", VA = "0x183BB5E00")]
	private void POAOKFGBMEH(Entity LLEBIIAHFDD, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3BB07B0", Offset = "0x3BAF3B0", VA = "0x183BB07B0")]
	private void HPHHCEKMBPD(Entity LLEBIIAHFDD, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x362F7F0", Offset = "0x362E3F0", VA = "0x18362F7F0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6860", Offset = "0x3BB5460", VA = "0x183BB6860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3BAD400", Offset = "0x3BAC000", VA = "0x183BAD400")]
	public string AEKNGOPJJEL(in EKBGHCIKEGG PEFOOCOGGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3630870", Offset = "0x362F470", VA = "0x183630870", Slot = "5")]
	private bool NMBJFJNDAPP(IOBECAADPPL BIMCDHOFDCP, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x362F7B0", Offset = "0x362E3B0", VA = "0x18362F7B0", Slot = "6")]
	private bool DCKFNOGMEOF(IOBECAADPPL BIMCDHOFDCP, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC2A80", Offset = "0x2BC1680", VA = "0x182BC2A80", Slot = "10")]
	private bool AFICPNKGIHF(IOBECAADPPL BIMCDHOFDCP, in object IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3632C50", Offset = "0x3631850", VA = "0x183632C50", Slot = "11")]
	private void LCEAMGEHFPH(IOBECAADPPL BIMCDHOFDCP, in PMECDNBONOH GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x36332C0", Offset = "0x3631EC0", VA = "0x1836332C0", Slot = "12")]
	private bool MNCIHFEJIKO(IOBECAADPPL BIMCDHOFDCP, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x362F770", Offset = "0x362E370", VA = "0x18362F770", Slot = "13")]
	private bool ALLHAEICBOC(IOBECAADPPL BIMCDHOFDCP, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x362F820", Offset = "0x362E420", VA = "0x18362F820", Slot = "16")]
	private string EKIPBDFMICC(in EKBGHCIKEGG GKFICKKHACC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NELJHPCAMDK : IDisposable, PFFOAGAAAPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> KMPPIJKOEHO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> KLDKJDELCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xDA4D10", Offset = "0xDA3910", VA = "0x180DA4D10", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xDAA6B0", Offset = "0xDA92B0", VA = "0x180DAA6B0")]
	public NELJHPCAMDK(NativeArray<EntityRemapUtility.EntityRemapInfo> KMPPIJKOEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C380", Offset = "0x2A7AF80", VA = "0x182A7C380", Slot = "6")]
	public IOBECAADPPL LALMGCKAKDD(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C3D0", Offset = "0x2A7AFD0", VA = "0x182A7C3D0", Slot = "7")]
	public Entity LALMGCKAKDD(Entity LLEBIIAHFDD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C3E0", Offset = "0x2A7AFE0", VA = "0x182A7C3E0", Slot = "8")]
	public IEnumerable<IOBECAADPPL> LALMGCKAKDD(IEnumerable<IOBECAADPPL> MIDBODKMKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C320", Offset = "0x2A7AF20", VA = "0x182A7C320", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[HFIGNCEGOKM(DDEOJCINOPG.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly FNIDFMEJGMB COEOOBJAENN;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int ONCPBNMMFMC;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static PFFOAGAAAPP BOOMEIJCBCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool BBJKKLBJGHJ;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> KLDKJDELCPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x2D7F420", Offset = "0x2D7E020", VA = "0x182D7F420")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static bool DNEMJMCMOCB
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2D7F530", Offset = "0x2D7E130", VA = "0x182D7F530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F130", Offset = "0x2D7DD30", VA = "0x182D7F130")]
		public static SerializationRemapScope KEAEHBAHBFH()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F650", Offset = "0x2D7E250", VA = "0x182D7F650")]
		public SerializationRemapScope(PFFOAGAAAPP AADIDIAMCCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F020", Offset = "0x2D7DC20", VA = "0x182D7F020", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F2C0", Offset = "0x2D7DEC0", VA = "0x182D7F2C0")]
		public static IOBECAADPPL LALMGCKAKDD(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F190", Offset = "0x2D7DD90", VA = "0x182D7F190")]
		public static Entity LALMGCKAKDD(Entity LLEBIIAHFDD)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DAMCBGMFJNJ(typeof(BJHJFJONAEF), new string[] { "Editor" })]
[GGOLPMFKOCH(JIJBLGHADKE.Application)]
public sealed class BJHJFJONAEF
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void ABPFCCPCIII(ELJHNEOGEBP DHPFEELIAKK, CBDNIJIKHKI JLFCOOGLPMP, bool CJEAHGLLLCI);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void EBPDNEAKFNF(ELJHNEOGEBP DHPFEELIAKK, bool CJEAHGLLLCI);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void EODGAALKLCG(ELJHNEOGEBP DHPFEELIAKK, EBLKGKAPHAO GCEENFOFNFL, in EKBGHCIKEGG GKFICKKHACC, bool CJEAHGLLLCI);

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event ABPFCCPCIII JBCEAECMFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2F91A80", Offset = "0x2F90680", VA = "0x182F91A80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2F91D40", Offset = "0x2F90940", VA = "0x182F91D40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event EBPDNEAKFNF BHHFDOOKDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2F91B40", Offset = "0x2F90740", VA = "0x182F91B40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2F91CA0", Offset = "0x2F908A0", VA = "0x182F91CA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event EODGAALKLCG CBPCFHBCEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2F919E0", Offset = "0x2F905E0", VA = "0x182F919E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2F91BE0", Offset = "0x2F907E0", VA = "0x182F91BE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2F91C80", Offset = "0x2F90880", VA = "0x182F91C80")]
	[Conditional("UNITY_EDITOR")]
	public void NOOGCJFCFAL(ELJHNEOGEBP DHPFEELIAKK, in CBDNIJIKHKI JLFCOOGLPMP, bool CJEAHGLLLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2F91B20", Offset = "0x2F90720", VA = "0x182F91B20")]
	[Conditional("UNITY_EDITOR")]
	public void JMOLBLONOAB(ELJHNEOGEBP DHPFEELIAKK, bool CJEAHGLLLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2F919B0", Offset = "0x2F905B0", VA = "0x182F919B0")]
	[Conditional("UNITY_EDITOR")]
	public void CBENKJFMMPJ(ELJHNEOGEBP DHPFEELIAKK, EBLKGKAPHAO GCEENFOFNFL, in EKBGHCIKEGG GKFICKKHACC, bool CJEAHGLLLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public BJHJFJONAEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DAMCBGMFJNJ(typeof(LBONPJJMDCB), new string[] { "Editor" })]
[GGOLPMFKOCH(JIJBLGHADKE.Application)]
public sealed class LBONPJJMDCB
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void NMAHDLHMDLE(ELJHNEOGEBP FFJHOAAMJMD, CBDNIJIKHKI JLFCOOGLPMP, bool CJEAHGLLLCI);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void PGILIODFGBM(ELJHNEOGEBP FFJHOAAMJMD, bool CJEAHGLLLCI);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void FOPKOKKCHOF(ELJHNEOGEBP FFJHOAAMJMD, EBLKGKAPHAO GCEENFOFNFL, in EKBGHCIKEGG GKFICKKHACC, bool CJEAHGLLLCI, bool GPHOGKOEAGP);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void DALADBAGJFF(ELJHNEOGEBP FFJHOAAMJMD, EBLKGKAPHAO GCEENFOFNFL, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void EHKABHPLGNL(HCLOKFAILEI BIMCDHOFDCP, ReadOnlyMemory<byte> OICHLBNIOCE);

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event NMAHDLHMDLE JBCEAECMFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8CC0", Offset = "0x2AB78C0", VA = "0x182AB8CC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9450", Offset = "0x2AB8050", VA = "0x182AB9450")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event PGILIODFGBM BHHFDOOKDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9110", Offset = "0x2AB7D10", VA = "0x182AB9110")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB92F0", Offset = "0x2AB7EF0", VA = "0x182AB92F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event NMAHDLHMDLE EMJCJDLEKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8ED0", Offset = "0x2AB7AD0", VA = "0x182AB8ED0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8E00", Offset = "0x2AB7A00", VA = "0x182AB8E00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event PGILIODFGBM EJKJFJKPKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8FA0", Offset = "0x2AB7BA0", VA = "0x182AB8FA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9630", Offset = "0x2AB8230", VA = "0x182AB9630")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event FOPKOKKCHOF CBPCFHBCEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8C20", Offset = "0x2AB7820", VA = "0x182AB8C20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2AB91D0", Offset = "0x2AB7DD0", VA = "0x182AB91D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event DALADBAGJFF NPELOLJCMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9390", Offset = "0x2AB7F90", VA = "0x182AB9390")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8D60", Offset = "0x2AB7960", VA = "0x182AB8D60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<string, object> IKGGMJKIPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9590", Offset = "0x2AB8190", VA = "0x182AB9590")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8B50", Offset = "0x2AB7750", VA = "0x182AB8B50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event EHKABHPLGNL LJCGLJKLKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2AB9070", Offset = "0x2AB7C70", VA = "0x182AB9070")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2AB94F0", Offset = "0x2AB80F0", VA = "0x182AB94F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9040", Offset = "0x2AB7C40", VA = "0x182AB9040")]
	[Conditional("UNITY_EDITOR")]
	public void KACAAIGBIKO(ELJHNEOGEBP FFJHOAAMJMD, in CBDNIJIKHKI JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9270", Offset = "0x2AB7E70", VA = "0x182AB9270")]
	[Conditional("UNITY_EDITOR")]
	public void MICCMNILJEB(ELJHNEOGEBP FFJHOAAMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8BF0", Offset = "0x2AB77F0", VA = "0x182AB8BF0")]
	[Conditional("UNITY_EDITOR")]
	public void DANHNKMPIJM(ELJHNEOGEBP FFJHOAAMJMD, in CBDNIJIKHKI JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2AB91B0", Offset = "0x2AB7DB0", VA = "0x182AB91B0")]
	[Conditional("UNITY_EDITOR")]
	public void KOIAFHNDIAO(ELJHNEOGEBP FFJHOAAMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8F70", Offset = "0x2AB7B70", VA = "0x182AB8F70")]
	[Conditional("UNITY_EDITOR")]
	public void HOJPJLKKHFF(ELJHNEOGEBP FFJHOAAMJMD, EBLKGKAPHAO GCEENFOFNFL, in EKBGHCIKEGG GKFICKKHACC, bool GPHOGKOEAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9430", Offset = "0x2AB8030", VA = "0x182AB9430")]
	[Conditional("UNITY_EDITOR")]
	public void OHLOCEIDHLL(ELJHNEOGEBP FFJHOAAMJMD, EBLKGKAPHAO GCEENFOFNFL, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9290", Offset = "0x2AB7E90", VA = "0x182AB9290")]
	[Conditional("UNITY_EDITOR")]
	public void OAOLNGLKNME(string NLCIGFDKGEE, object OICHLBNIOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8EA0", Offset = "0x2AB7AA0", VA = "0x182AB8EA0")]
	[Conditional("UNITY_EDITOR")]
	public void GLKNPGAEPHO(HCLOKFAILEI BIMCDHOFDCP, ReadOnlyMemory<byte> OICHLBNIOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public LBONPJJMDCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DAMCBGMFJNJ(typeof(OEAAIOGMMFJ), new string[] { })]
public class FJDEHMCJMJG : OEAAIOGMMFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3FF0", Offset = "0x2AA2BF0", VA = "0x182AA3FF0", Slot = "5")]
	public void MGKBBCGBMCF(object HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3F10", Offset = "0x2AA2B10", VA = "0x182AA3F10", Slot = "6")]
	public void LMNGFKHEOAN(object HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3E30", Offset = "0x2AA2A30", VA = "0x182AA3E30", Slot = "7")]
	public void JIGNEJOOMDJ(object HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3D20", Offset = "0x2AA2920", VA = "0x182AA3D20", Slot = "4")]
	public IDisposable GHMGLDCDLEB(object HDKJDEIGPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public FJDEHMCJMJG()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[DAMCBGMFJNJ(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	[HFIGNCEGOKM(DDEOJCINOPG.Serialization)]
	internal class BulkInstantiateSceneObjectService : OHFJHEDBJHF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string IJNGGGNMFKE = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[NHBEJKCIJLO]
		private MCFPIPCNFDN KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN KJEBDBMGNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[NHBEJKCIJLO]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[NHBEJKCIJLO]
		private JOBGNDCAMAM KKELBBDIJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private EntityQuery JJGHACOHAFM;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x2F95FD0", Offset = "0x2F94BD0", VA = "0x182F95FD0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2F94260", Offset = "0x2F92E60", VA = "0x182F94260", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2F94910", Offset = "0x2F93510", VA = "0x182F94910", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2F96020", Offset = "0x2F94C20", VA = "0x182F96020")]
		public bool OOFHELPOEED(IEnumerable<KPBHHJNMPGI> GPNIFCAJBPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2F959E0", Offset = "0x2F945E0", VA = "0x182F959E0")]
		public static bool MJKONGIHJEM(KPBHHJNMPGI BOBJBDACGIL, out ELJHNEOGEBP FFJHOAAMJMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2F953F0", Offset = "0x2F93FF0", VA = "0x182F953F0")]
		private void INOEBBCOIHK(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ, IEnumerable<KPBHHJNMPGI> GPNIFCAJBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2F951C0", Offset = "0x2F93DC0", VA = "0x182F951C0")]
		private void FFOPDPOPKBL(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2F95AF0", Offset = "0x2F946F0", VA = "0x182F95AF0")]
		private void MKKDDPGJLML(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ, ELJHNEOGEBP FFJHOAAMJMD, string NLCIGFDKGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2F945B0", Offset = "0x2F931B0", VA = "0x182F945B0")]
		private void DODDPGFKOMI(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2F94920", Offset = "0x2F93520", VA = "0x182F94920")]
		private void EHNIJAOOCGA(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ, List<KPBHHJNMPGI> DEBDIHHEBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2F943E0", Offset = "0x2F92FE0", VA = "0x182F943E0")]
		private NativeList<ELJHNEOGEBP> BLAOAKDAOKI(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ)
		{
			return default(NativeList<ELJHNEOGEBP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2F95770", Offset = "0x2F94370", VA = "0x182F95770")]
		private NativeArray<Entity> JDPJJFBKOGL(NativeList<ELJHNEOGEBP> EDAEDMAFDDI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2F95940", Offset = "0x2F94540", VA = "0x182F95940")]
		private static void LPOANLJOFCG(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ, ELJHNEOGEBP FFJHOAAMJMD, KPBHHJNMPGI BOBJBDACGIL, string NLCIGFDKGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[GGOLPMFKOCH(JIJBLGHADKE.Application)]
	[HFIGNCEGOKM(DDEOJCINOPG.Serialization)]
	[DAMCBGMFJNJ(typeof(DebugWorldsService), new string[] { })]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal static bool PAOBNFNAFOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x2FA6050", Offset = "0x2FA4C50", VA = "0x182FA6050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2FA6010", Offset = "0x2FA4C10", VA = "0x182FA6010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		internal static bool POPGINMEJEC
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x2FA5F90", Offset = "0x2FA4B90", VA = "0x182FA5F90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x2FA5FD0", Offset = "0x2FA4BD0", VA = "0x182FA5FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		public void DMHNIJDDNHN(string NLCIGFDKGEE, EntityManager CLLNDNAAIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		public static void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DAMCBGMFJNJ(typeof(PKOBMDDCGBM), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.Application)]
internal class PKOBMDDCGBM
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool PAOBNFNAFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x67B250", Offset = "0x679E50", VA = "0x18067B250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x67B270", Offset = "0x679E70", VA = "0x18067B270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool LCAFBNMCIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x776570", Offset = "0x775170", VA = "0x180776570")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x776580", Offset = "0x775180", VA = "0x180776580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public PKOBMDDCGBM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[IAGJGLKEJDP(typeof(SerializationService))]
	[DAMCBGMFJNJ(typeof(LJHKOFPCONB), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.Serialization)]
	internal class SerializationService : LJHKOFPCONB, IDisposable, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly FNIDFMEJGMB DFMIEEBHCKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[NHBEJKCIJLO]
		private MCFPIPCNFDN KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[NHBEJKCIJLO]
		private CGLBCJNHGCM NEDADCIFNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[NHBEJKCIJLO]
		private PKOBMDDCGBM NKIINCCIBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private HMGGJADOIMB LNMBGNOCCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private AKBOANNKIFN OBLJBJCGPGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private SerializationRemapScope ABGOLHJFIJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool? MJELFKJDNLI;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool PNLCDHENCAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x2D7F6E0", Offset = "0x2D7E2E0", VA = "0x182D7F6E0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x2D7FA70", Offset = "0x2D7E670", VA = "0x182D7FA70", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool GHMFEBCFPJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x71ACE0", Offset = "0x7198E0", VA = "0x18071ACE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x71B490", Offset = "0x71A090", VA = "0x18071B490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public AKBOANNKIFN ODPABGFJECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F6F0", Offset = "0x2D7E2F0", VA = "0x182D7F6F0", Slot = "16")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2D80150", Offset = "0x2D7ED50", VA = "0x182D80150", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2D80970", Offset = "0x2D7F570", VA = "0x182D80970")]
		public static bool HAHFMLGMGED(ByteString MEFFDBODCGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6B91C0", Offset = "0x6B7DC0", VA = "0x1806B91C0")]
		public void DEOGHFBIFON(HMGGJADOIMB ABLAIFJNIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2D80AA0", Offset = "0x2D7F6A0", VA = "0x182D80AA0", Slot = "5")]
		public void IKAMGNEEKKF(bool DHOJGMOHHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FDE0", Offset = "0x2D7E9E0", VA = "0x182D7FDE0", Slot = "6")]
		public Task DIJMGFAHLJP(bool DHOJGMOHHOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FC60", Offset = "0x2D7E860", VA = "0x182D7FC60", Slot = "7")]
		public ByteString CLPGJOCDFOA(out IDisposable ABGOLHJFIJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FA80", Offset = "0x2D7E680", VA = "0x182D7FA80", Slot = "19")]
		public ByteString CLPGJOCDFOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2D81140", Offset = "0x2D7FD40", VA = "0x182D81140", Slot = "9")]
		public bool MNOLKCHHLIP(ByteString LLBACIACODL, KAHOHIEBNCF MBNFLPKEEGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D80D70", Offset = "0x2D7F970", VA = "0x182D80D70")]
		private bool LKHBNCGOLEK(ByteString LLBACIACODL, KAHOHIEBNCF MBNFLPKEEGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FE70", Offset = "0x2D7EA70", VA = "0x182D7FE70", Slot = "8")]
		public void DLENKBBIHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D80530", Offset = "0x2D7F130", VA = "0x182D80530", Slot = "10")]
		public bool FOGMCMNIEAB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2D813D0", Offset = "0x2D7FFD0", VA = "0x182D813D0", Slot = "11")]
		public bool OOFHELPOEED(IEnumerable<KPBHHJNMPGI> JNPPLACLHGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2D80160", Offset = "0x2D7ED60", VA = "0x182D80160")]
		public bool FAPKMEMBOGD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2D811A0", Offset = "0x2D7FDA0", VA = "0x182D811A0", Slot = "12")]
		public bool NHJFFFEKKHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2D7F790", Offset = "0x2D7E390", VA = "0x182D7F790")]
		public void BKDMMLJBBDB(AKBOANNKIFN.DMCMPHFHIHA.GJGMMINMIID FILNOJDGMDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2D80240", Offset = "0x2D7EE40", VA = "0x182D80240")]
		private bool FCJNCEJPFEF(ByteString LLBACIACODL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FA20", Offset = "0x2D7E620", VA = "0x182D7FA20")]
		private void CBKMBGIFDFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2D804D0", Offset = "0x2D7F0D0", VA = "0x182D804D0")]
		private ByteString FKJOPBFOPMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x2D80040", Offset = "0x2D7EC40", VA = "0x182D80040")]
		private ByteString DMFINCFKAIN(ByteString MEFFDBODCGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2D7FD40", Offset = "0x2D7E940", VA = "0x182D7FD40")]
		private AKBOANNKIFN.DMCMPHFHIHA.GJGMMINMIID DBNIINCFBDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2D80D40", Offset = "0x2D7F940", VA = "0x182D80D40")]
		private void KKIELDHGKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D80B70", Offset = "0x2D7F770", VA = "0x182D80B70", Slot = "13")]
		public bool KDBCJFDIBNM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D81090", Offset = "0x2D7FC90", VA = "0x182D81090", Slot = "14")]
		public void MDFOLHHLPFL(bool OFIHIKCKNMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D807A0", Offset = "0x2D7F3A0", VA = "0x182D807A0")]
		private void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DAMCBGMFJNJ(typeof(IODHNFLDMAC), new string[] { })]
[IAGJGLKEJDP(typeof(CGLBCJNHGCM))]
internal class CGLBCJNHGCM : IODHNFLDMAC
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action MFGMDDJEENL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2F965B0", Offset = "0x2F951B0", VA = "0x182F965B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2F96970", Offset = "0x2F95570", VA = "0x182F96970", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<PFFOAGAAAPP> ADFEOFDFMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2F96830", Offset = "0x2F95430", VA = "0x182F96830", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2F966F0", Offset = "0x2F952F0", VA = "0x182F966F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action GKKNCKHFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x2F96790", Offset = "0x2F95390", VA = "0x182F96790", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x2F96A10", Offset = "0x2F95610", VA = "0x182F96A10", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action CAKKPMPEGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2F96650", Offset = "0x2F95250", VA = "0x182F96650", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2F96510", Offset = "0x2F95110", VA = "0x182F96510", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<PFFOAGAAAPP> LAEKLDBCGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2F96AB0", Offset = "0x2F956B0", VA = "0x182F96AB0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2F968D0", Offset = "0x2F954D0", VA = "0x182F968D0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1364A40", Offset = "0x1363640", VA = "0x181364A40")]
	public void DLENKBBIHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1634440", Offset = "0x1633040", VA = "0x181634440")]
	public void DOPCNLFKEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x15270D0", Offset = "0x1525CD0", VA = "0x1815270D0")]
	public void MFCKIIMENCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2F96B50", Offset = "0x2F95750", VA = "0x182F96B50")]
	public void PECJHMIOPNG(PFFOAGAAAPP BOOMEIJCBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2F964C0", Offset = "0x2F950C0", VA = "0x182F964C0")]
	public void AAGMNNKDCMD(PFFOAGAAAPP BOOMEIJCBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public CGLBCJNHGCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DAMCBGMFJNJ(typeof(NDJGAFFBPCH), new string[] { })]
public class JNHMPGJDLBH : NDJGAFFBPCH, PFBMKGBLLGM, KGABHKADGEM, OHFJHEDBJHF, HMFGCABFMPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EntityHierarchyParents MCPLHLPJDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private LPBEHADBKMD PBCKDJKFIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private ObjectEmbodimentService DPCGPJIEFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public global::EDNHLHPJOPH<IOBECAADPPL> MJECJCHPAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x67E580", Offset = "0x67D180", VA = "0x18067E580", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x67E5A0", Offset = "0x67D1A0", VA = "0x18067E5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EntityManager FAINNDBCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3000", Offset = "0x2AB1C00", VA = "0x182AB3000")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x146FEF0", Offset = "0x146EAF0", VA = "0x18146FEF0", Slot = "14")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1E30", Offset = "0x2AB0A30", VA = "0x182AB1E30", Slot = "15")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3050", Offset = "0x2AB1C50", VA = "0x182AB3050", Slot = "16")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x82C9E0", Offset = "0x82B5E0", VA = "0x18082C9E0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A83100", Offset = "0x2A81D00", VA = "0x182A83100")]
	private IOBECAADPPL KPDLDNMJLLL(Entity LLEBIIAHFDD)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2550", Offset = "0x2AB1150", VA = "0x182AB2550", Slot = "4")]
	public IOBECAADPPL IENNNAFGFNJ(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1F00", Offset = "0x2AB0B00", VA = "0x182AB1F00", Slot = "19")]
	public void BBCNGMBMGMH(ref List<IOBECAADPPL> DFMCPPMHIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2E00", Offset = "0x2AB1A00", VA = "0x182AB2E00", Slot = "20")]
	public IEnumerable<IOBECAADPPL> OEGOHCELJAI(IOBECAADPPL DKHOCCDNDOH, bool HOJIMILIDNA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2A80", Offset = "0x2AB1680", VA = "0x182AB2A80", Slot = "21")]
	public IOBECAADPPL MMFPKICCFCA(IOBECAADPPL DKHOCCDNDOH, int BNNEENLPEFO)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2960", Offset = "0x2AB1560", VA = "0x182AB2960", Slot = "22")]
	public int MDOMKMPHBAP(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3140", Offset = "0x2AB1D40", VA = "0x182AB3140", Slot = "8")]
	public int PEOBNLMKOKI(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2C50", Offset = "0x2AB1850", VA = "0x182AB2C50", Slot = "9")]
	public CDDJMIAEBFF MNFKOJBKCKK(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(CDDJMIAEBFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2130", Offset = "0x2AB0D30", VA = "0x182AB2130", Slot = "23")]
	public bool DAFPDNAKGFF(IOBECAADPPL DKHOCCDNDOH, out CDDJMIAEBFF BBFDGAIKNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2AB27E0", Offset = "0x2AB13E0", VA = "0x182AB27E0", Slot = "24")]
	public IEnumerable<IOBECAADPPL> LBLBJIKOPHN(IOBECAADPPL DKHOCCDNDOH, bool HOJIMILIDNA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2710", Offset = "0x2AB1310", VA = "0x182AB2710", Slot = "12")]
	public IOBECAADPPL KIGGLEINDHC(IOBECAADPPL ADDDKDIDHPJ, IOBECAADPPL LCEKCMGAGEI)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2640", Offset = "0x2AB1240", VA = "0x182AB2640", Slot = "13")]
	public bool KCBAGPAHKEE(IOBECAADPPL ADDDKDIDHPJ, IOBECAADPPL LCEKCMGAGEI, out IOBECAADPPL BKMGHCEAABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2300", Offset = "0x2AB0F00", VA = "0x182AB2300", Slot = "5")]
	public IOBECAADPPL DJKFCHELMJI(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2D40", Offset = "0x2AB1940", VA = "0x182AB2D40", Slot = "11")]
	public bool NLDBNJEFDEH(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL NMJJIOLIMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AB23A0", Offset = "0x2AB0FA0", VA = "0x182AB23A0", Slot = "25")]
	public bool HDGJJPALPML(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL DBNJJKLOCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2AB32E0", Offset = "0x2AB1EE0", VA = "0x182AB32E0", Slot = "10")]
	public bool PGPKCLNGJPJ(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL ADDDKDIDHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2AB28B0", Offset = "0x2AB14B0", VA = "0x182AB28B0", Slot = "6")]
	public bool LHJCDGMFADO(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL GEOFAMNLJNK, bool CHPHLJOKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2AB24E0", Offset = "0x2AB10E0", VA = "0x182AB24E0", Slot = "7")]
	public bool HKIAAFFILCD(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL GEOFAMNLJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public JNHMPGJDLBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
[DAMCBGMFJNJ(typeof(CILKMKKIBEF), new string[] { })]
internal class CILKMKKIBEF : OHFJHEDBJHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[NHBEJKCIJLO]
	private MGNHPFHGDHE HFDCOKODHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<int, EAAOOBCMLAD> JNDLBHICODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2F96BA0", Offset = "0x2F957A0", VA = "0x182F96BA0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2F96BF0", Offset = "0x2F957F0", VA = "0x182F96BF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2F97000", Offset = "0x2F95C00", VA = "0x182F97000")]
	public EAAOOBCMLAD LDPPLEPCPJK(PMBKKKKDOIF BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2F97100", Offset = "0x2F95D00", VA = "0x182F97100")]
	public EAAOOBCMLAD LDPPLEPCPJK(EBLKGKAPHAO KBPOLLDMHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2F96E70", Offset = "0x2F95A70", VA = "0x182F96E70")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2F97320", Offset = "0x2F95F20", VA = "0x182F97320")]
	public CILKMKKIBEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class EAAOOBCMLAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<NJAEBHKONED> DONADGGMMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<CAIGEBHNCMM> FFLPKDKCKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<CPMOBHMFHFP> KMPFMNDJNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<CAIGEBHNCMM> PGBKIDHBINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NativeList<NJAEBHKONED> FIEPAMIEKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xDA4D10", Offset = "0xDA3910", VA = "0x180DA4D10")]
		get
		{
			return default(NativeList<NJAEBHKONED>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<CAIGEBHNCMM> MHEPHCNFOND
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xCD1120", Offset = "0xCCFD20", VA = "0x180CD1120")]
		get
		{
			return default(NativeList<CAIGEBHNCMM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<CPMOBHMFHFP> NCFNPLOJOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x10EF940", Offset = "0x10EE540", VA = "0x1810EF940")]
		get
		{
			return default(NativeList<CPMOBHMFHFP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<CAIGEBHNCMM> CJJBNCPHPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x10EF8F0", Offset = "0x10EE4F0", VA = "0x1810EF8F0")]
		get
		{
			return default(NativeList<CAIGEBHNCMM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JobHandle BKGGOCNKAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x13C54A0", Offset = "0x13C40A0", VA = "0x1813C54A0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x165ECE0", Offset = "0x165D8E0", VA = "0x18165ECE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool AACDAEOPAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F7B40", Offset = "0x9F6740", VA = "0x1809F7B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool MLCHHGLGNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x2FA6CF0", Offset = "0x2FA58F0", VA = "0x182FA6CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7230", Offset = "0x2FA5E30", VA = "0x182FA7230")]
	public EAAOOBCMLAD(Allocator PBEDBDBGIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7070", Offset = "0x2FA5C70", VA = "0x182FA7070")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7100", Offset = "0x2FA5D00", VA = "0x182FA7100")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2FA6DA0", Offset = "0x2FA59A0", VA = "0x182FA6DA0")]
	public void ELGBPIMHCCH(Entity LLEBIIAHFDD, Entity KAEGMLMLAJA, Entity JJHAACNMGFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DAMCBGMFJNJ(typeof(HGGMMPGBLGF), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
public class HGGMMPGBLGF : OHFJHEDBJHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[NHBEJKCIJLO]
	private SceneService HMMCBLIILHF;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8C90", Offset = "0x2AA7890", VA = "0x182AA8C90", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8CE0", Offset = "0x2AA78E0", VA = "0x182AA8CE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public HGGMMPGBLGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal abstract class NFJBNJJIKHA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private uint HCLNIJDMCEH;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public abstract uint IJOMPMAGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9E55F0", Offset = "0x9E41F0", VA = "0x1809E55F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D2E0", Offset = "0x2A7BEE0", VA = "0x182A7D2E0")]
	public ELJHNEOGEBP GECODMKPHFO()
	{
		return default(ELJHNEOGEBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D330", Offset = "0x2A7BF30", VA = "0x182A7D330")]
	public void HGHOOHBDAKM(ELJHNEOGEBP FFJHOAAMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x10F53E0", Offset = "0x10F3FE0", VA = "0x1810F53E0", Slot = "6")]
	public virtual void FBGINNLGAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	protected NFJBNJJIKHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
[DAMCBGMFJNJ(typeof(CCMLDGMLHBE), new string[] { })]
internal sealed class CCMLDGMLHBE : NFJBNJJIKHA, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[NHBEJKCIJLO]
	private MCFPIPCNFDN KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private uint DEPHGHGHIPL;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override uint IJOMPMAGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x677010", Offset = "0x675C10", VA = "0x180677010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2F96370", Offset = "0x2F94F70", VA = "0x182F96370", Slot = "7")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2F96470", Offset = "0x2F95070", VA = "0x182F96470")]
	private void IJJJDHMONCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2F96410", Offset = "0x2F95010", VA = "0x182F96410", Slot = "6")]
	public override void FBGINNLGAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
	public CCMLDGMLHBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DAMCBGMFJNJ(typeof(CHMBFFBOMKL), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
internal sealed class CHMBFFBOMKL : NFJBNJJIKHA
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override uint IJOMPMAGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CD70", VA = "0x18067E170", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
	public CHMBFFBOMKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
[DAMCBGMFJNJ(typeof(AOHDOMEMLII), new string[] { })]
internal sealed class AOHDOMEMLII : PFBMKGBLLGM, KGABHKADGEM, OHFJHEDBJHF, HMFGCABFMPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[NHBEJKCIJLO]
	private EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery JCLOFGGCPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery MMFJFLLNHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery JHILOHCIDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery HHOIINGHABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private EntityQuery GPGNGBAANDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private EntityQuery FJDBNAPOEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private EntityManager FAINNDBCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DEF0", Offset = "0x2F8CAF0", VA = "0x182F8DEF0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public EntityQuery MIOKJKFCJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696C40", VA = "0x180698040")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityQuery MNAHMGFJHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x698030", Offset = "0x696C30", VA = "0x180698030")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery NOPNHEHJPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x135AAB0", Offset = "0x13596B0", VA = "0x18135AAB0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery MOKJIIBJLEL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x13C54A0", Offset = "0x13C40A0", VA = "0x1813C54A0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery KMEJOKGPONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1484330", Offset = "0x1482F30", VA = "0x181484330")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery EPGEJPNGAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DC50", Offset = "0x2F8C850", VA = "0x182F8DC50")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int FPBPGMMCKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DB00", Offset = "0x2F8C700", VA = "0x182F8DB00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int LHABKJIKBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DD50", Offset = "0x2F8C950", VA = "0x182F8DD50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int BCLIAIHMKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E3E0", Offset = "0x2F8CFE0", VA = "0x182F8E3E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int DIDPKJIDHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DB20", Offset = "0x2F8C720", VA = "0x182F8DB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int BLJFNHJIFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DD30", Offset = "0x2F8C930", VA = "0x182F8DD30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int APFOGEGGMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2F8DD70", Offset = "0x2F8C970", VA = "0x182F8DD70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "4")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2F8DAB0", Offset = "0x2F8C6B0", VA = "0x182F8DAB0", Slot = "5")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2F8DF40", Offset = "0x2F8CB40", VA = "0x182F8DF40", Slot = "6")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2F8DCD0", Offset = "0x2F8C8D0", VA = "0x182F8DCD0")]
	private EntityQueryDesc FIDOMOLJMKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2F8DBF0", Offset = "0x2F8C7F0", VA = "0x182F8DBF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2F8DD90", Offset = "0x2F8C990", VA = "0x182F8DD90")]
	public KPCHKKCKBJJ NIJCJBHNDEI(IOBECAADPPL IBGBBCHPJJF)
	{
		return default(KPCHKKCKBJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2F8DE40", Offset = "0x2F8CA40", VA = "0x182F8DE40")]
	public KPCHKKCKBJJ NIJCJBHNDEI(Entity LLEBIIAHFDD)
	{
		return default(KPCHKKCKBJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2F8DB40", Offset = "0x2F8C740", VA = "0x182F8DB40")]
	public OADLDHPKENB DEOOPJFHNNH(Entity LLEBIIAHFDD)
	{
		return default(OADLDHPKENB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E400", Offset = "0x2F8D000", VA = "0x182F8E400")]
	public AOHDOMEMLII()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[HFIGNCEGOKM(DDEOJCINOPG.All)]
	[DAMCBGMFJNJ(typeof(BLGCKCAEBNA), new string[] { })]
	public class ObjectService : OHFJHEDBJHF, BLGCKCAEBNA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly FNIDFMEJGMB HNPOCLHPOBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[NHBEJKCIJLO]
		private HFBJLIMBJCJ PCMOOAJDLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[NHBEJKCIJLO]
		private MCFPIPCNFDN KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[NHBEJKCIJLO]
		private ObjectLifecycleService KOGKJOIDDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[NHBEJKCIJLO]
		private ObjectEmbodimentService DPCGPJIEFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[NHBEJKCIJLO]
		private ObjectInstantiationService DEBJMFLLNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[NHBEJKCIJLO]
		private AOHDOMEMLII PBCKDJKFIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private ObjectNetworkToLocalMapService LDFFPBKCNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool IBOHJGMEBIO;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public HFBJLIMBJCJ OIAHPJDJAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int FPBPGMMCKJI
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x2A8C4F0", Offset = "0x2A8B0F0", VA = "0x182A8C4F0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int LHABKJIKBDC
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D400", Offset = "0x2A8C000", VA = "0x182A8D400", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int BCLIAIHMKBM
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x2A8DDB0", Offset = "0x2A8C9B0", VA = "0x182A8DDB0", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int DIDPKJIDHNP
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x2A8C5B0", Offset = "0x2A8B1B0", VA = "0x182A8C5B0", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int BLJFNHJIFIC
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2A8CF20", Offset = "0x2A8BB20", VA = "0x182A8CF20", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int APFOGEGGMHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2A8DB70", Offset = "0x2A8C770", VA = "0x182A8DB70", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<IOBECAADPPL, OADLDHPKENB> JKKKCONJDDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x2A8C140", Offset = "0x2A8AD40", VA = "0x182A8C140", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x2A8C450", Offset = "0x2A8B050", VA = "0x182A8C450", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<IOBECAADPPL> MCDKIJEJMFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2A8CD10", Offset = "0x2A8B910", VA = "0x182A8CD10", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x2A8D470", Offset = "0x2A8C070", VA = "0x182A8D470", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BED0", Offset = "0x2A8AAD0", VA = "0x182A8BED0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C810", Offset = "0x2A8B410", VA = "0x182A8C810", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C510", Offset = "0x2A8B110", VA = "0x182A8C510")]
		private void BIFFFAEPCDP(Entity LLEBIIAHFDD, OADLDHPKENB FKEOEHMKOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DBD0", Offset = "0x2A8C7D0", VA = "0x182A8DBD0")]
		private void NDMKPJNHFGM(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D930", Offset = "0x2A8C530", VA = "0x182A8D930")]
		internal IOBECAADPPL KPDLDNMJLLL(Entity LLEBIIAHFDD)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C9B0", Offset = "0x2A8B5B0", VA = "0x182A8C9B0", Slot = "41")]
		public CDDJMIAEBFF ECEBNNCCOBB()
		{
			return default(CDDJMIAEBFF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DD00", Offset = "0x2A8C900", VA = "0x182A8DD00", Slot = "42")]
		public CDDJMIAEBFF PHHGOOCOPED()
		{
			return default(CDDJMIAEBFF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C3B0", Offset = "0x2A8AFB0", VA = "0x182A8C3B0", Slot = "43")]
		public CDDJMIAEBFF BBMCNGNNHMF()
		{
			return default(CDDJMIAEBFF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DCD0", Offset = "0x2A8C8D0", VA = "0x182A8DCD0", Slot = "10")]
		public KPCHKKCKBJJ NIJCJBHNDEI(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(KPCHKKCKBJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C790", Offset = "0x2A8B390", VA = "0x182A8C790", Slot = "11")]
		public OADLDHPKENB DEOOPJFHNNH(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(OADLDHPKENB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C6E0", Offset = "0x2A8B2E0", VA = "0x182A8C6E0")]
		private CDDJMIAEBFF DDKJCHDPEGP(EntityQuery NJIBLOIMOJA)
		{
			return default(CDDJMIAEBFF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CC80", Offset = "0x2A8B880", VA = "0x182A8CC80", Slot = "33")]
		public bool FONENOMBNOF(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D510", Offset = "0x2A8C110", VA = "0x182A8D510", Slot = "29")]
		public void KDKECGLKPJA(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D340", Offset = "0x2A8BF40", VA = "0x182A8D340", Slot = "30")]
		public void HNJDDIFBIFG(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CFB0", Offset = "0x2A8BBB0", VA = "0x182A8CFB0", Slot = "31")]
		public void HFPMFHPHKJM(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CDB0", Offset = "0x2A8B9B0", VA = "0x182A8CDB0", Slot = "22")]
		public MFPKOBHCDLK HCPNNJMCDBO(OADLDHPKENB FKEOEHMKOOO, bool KCJPFJDMHDE)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CEA0", Offset = "0x2A8BAA0", VA = "0x182A8CEA0", Slot = "23")]
		public MFPKOBHCDLK HCPNNJMCDBO(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C650", Offset = "0x2A8B250", VA = "0x182A8C650", Slot = "24")]
		public MFPKOBHCDLK CMKBHBIKKLG(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C1E0", Offset = "0x2A8ADE0", VA = "0x182A8C1E0", Slot = "25")]
		public MFPKOBHCDLK BBEBKABPFOC(ELJHNEOGEBP FFJHOAAMJMD, OADLDHPKENB FKEOEHMKOOO)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DA50", Offset = "0x2A8C650", VA = "0x182A8DA50", Slot = "44")]
		public MFPKOBHCDLK MFMNBNMJJLB(int JKCKEDCDOEI, OADLDHPKENB FKEOEHMKOOO, GameObject ENOCMPCACJI)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D200", Offset = "0x2A8BE00", VA = "0x182A8D200", Slot = "26")]
		public OEHLCFMEIAB HKGIPEPAOCC()
		{
			return default(OEHLCFMEIAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D680", Offset = "0x2A8C280", VA = "0x182A8D680", Slot = "45")]
		public BEFNEJPCLCN KHOBNGEHLKF(NFAEFFLJLPD BIEGICDMJCM)
		{
			return default(BEFNEJPCLCN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DAC0", Offset = "0x2A8C6C0", VA = "0x182A8DAC0", Slot = "27")]
		public JHBDPEEMJNG MJFCMEDMLAE()
		{
			return default(JHBDPEEMJNG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D560", Offset = "0x2A8C160", VA = "0x182A8D560", Slot = "28")]
		public PILKLNFGMCM KHIJCCNCJJA(CKLKKHOPBLL BIEGICDMJCM)
		{
			return default(PILKLNFGMCM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CA50", Offset = "0x2A8B650", VA = "0x182A8CA50", Slot = "12")]
		public void EHMHLLLMBAF(ELJHNEOGEBP FFJHOAAMJMD, IAEGHKEFOHF DJGPJGBFCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D780", Offset = "0x2A8C380", VA = "0x182A8D780", Slot = "13")]
		public MFPKOBHCDLK KOGFABJEPCO(IOBECAADPPL DKHOCCDNDOH, [Optional] object JJFHDFJGCDG)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D950", Offset = "0x2A8C550", VA = "0x182A8D950", Slot = "14")]
		public bool LFCLKAMJJHD(IOBECAADPPL DKHOCCDNDOH, out IAEGHKEFOHF BMBFIGGJLDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CA70", Offset = "0x2A8B670", VA = "0x182A8CA70", Slot = "46")]
		public Transform EICBEGAJFIO(IOBECAADPPL DKHOCCDNDOH, [Optional] object JJFHDFJGCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D420", Offset = "0x2A8C020", VA = "0x182A8D420", Slot = "16")]
		public bool JCBPEMMLHHC(IOBECAADPPL DKHOCCDNDOH, out Transform KAMDPLLJPAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CBB0", Offset = "0x2A8B7B0", VA = "0x182A8CBB0", Slot = "17")]
		public bool FEOLDMHKLBA(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DA20", Offset = "0x2A8C620", VA = "0x182A8DA20")]
		public bool MBLEKNDNMJF(IAEGHKEFOHF GKFICKKHACC, [Optional] object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D9F0", Offset = "0x2A8C5F0", VA = "0x182A8D9F0", Slot = "47")]
		public bool MBLEKNDNMJF(IOBECAADPPL DKHOCCDNDOH, [Optional] object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C990", Offset = "0x2A8B590", VA = "0x182A8C990", Slot = "48")]
		public void EACAKCNLMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D050", Offset = "0x2A8BC50", VA = "0x182A8D050", Slot = "15")]
		public void HGCNIJCLDNO(IAEGHKEFOHF KMFLGGMLFJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C7D0", Offset = "0x2A8B3D0", VA = "0x182A8C7D0", Slot = "49")]
		public void DGOFNAPNLLM(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8C5D0", Offset = "0x2A8B1D0", VA = "0x182A8C5D0", Slot = "18")]
		public bool BOLFGPMHGFA(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CC00", Offset = "0x2A8B800", VA = "0x182A8CC00", Slot = "19")]
		public bool FKAOODJLIPP(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CF40", Offset = "0x2A8BB40", VA = "0x182A8CF40", Slot = "50")]
		public bool HFJCFCGMDPD(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DC60", Offset = "0x2A8C860", VA = "0x182A8DC60", Slot = "51")]
		public bool NFEPDLIEMIB(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D3A0", Offset = "0x2A8BFA0", VA = "0x182A8D3A0", Slot = "32")]
		public NativeArray<(IOBECAADPPL, IOBECAADPPL)> HOELGELKEPN(NativeArray<IOBECAADPPL> PDHJHNDNLLA, Allocator PBEDBDBGIPF)
		{
			return default(NativeArray<(IOBECAADPPL, IOBECAADPPL)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2A8D2A0", Offset = "0x2A8BEA0", VA = "0x182A8D2A0", Slot = "21")]
		public ELJHNEOGEBP HLAFIPJDKEG(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(ELJHNEOGEBP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2A8CAC0", Offset = "0x2A8B6C0", VA = "0x182A8CAC0", Slot = "20")]
		public IOBECAADPPL FEEDHGOGJCP(ELJHNEOGEBP FFJHOAAMJMD)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2A8DB90", Offset = "0x2A8C790", VA = "0x182A8DB90")]
		private void MMDMIKBJDCB(OADLDHPKENB FKEOEHMKOOO, IOBECAADPPL DKHOCCDNDOH, ELJHNEOGEBP FFJHOAAMJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DAMCBGMFJNJ(typeof(PGOJBPGALLI), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
internal sealed class PGOJBPGALLI : OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private ObjectInstantiationService DEBJMFLLNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[NHBEJKCIJLO]
	private AOHDOMEMLII PBCKDJKFIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[NHBEJKCIJLO]
	private EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F800", Offset = "0x2A8E400", VA = "0x182A8F800", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2A900C0", Offset = "0x2A8ECC0", VA = "0x182A900C0")]
	public NativeArray<(IOBECAADPPL, IOBECAADPPL)> HOELGELKEPN(NativeArray<IOBECAADPPL> PDHJHNDNLLA, Allocator PBEDBDBGIPF)
	{
		return default(NativeArray<(IOBECAADPPL, IOBECAADPPL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FEE0", Offset = "0x2A8EAE0", VA = "0x182A8FEE0")]
	private void GHKDJCBPPAO(NativeMultiHashMap<int, (IOBECAADPPL src, IOBECAADPPL dst)> MEDKODGAKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F890", Offset = "0x2A8E490", VA = "0x182A8F890")]
	private void CFEMINFKJCC(NativeMultiHashMap<int, (IOBECAADPPL src, IOBECAADPPL dst)> MEDKODGAKKM, int FKEOEHMKOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2A8FD50", Offset = "0x2A8E950", VA = "0x182A8FD50")]
	private void DHPNDMILNKI(NativeMultiHashMap<int, (IOBECAADPPL src, IOBECAADPPL dst)> MEDKODGAKKM, int FKEOEHMKOOO, OCECHDCDPOJ HFDCOKODHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2A901C0", Offset = "0x2A8EDC0", VA = "0x182A901C0")]
	private NativeMultiHashMap<int, (IOBECAADPPL, IOBECAADPPL)> MDONIDDBJIH(Allocator PBEDBDBGIPF, NativeArray<IOBECAADPPL> PDHJHNDNLLA, out NativeArray<(IOBECAADPPL src, IOBECAADPPL dst)> NICAJNDACAL)
	{
		return default(NativeMultiHashMap<int, (IOBECAADPPL, IOBECAADPPL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public PGOJBPGALLI()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[IAGJGLKEJDP(typeof(TransformService))]
	[DAMCBGMFJNJ(typeof(JOBGNDCAMAM), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.TransformSyncing)]
	public class TransformService : JOBGNDCAMAM, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly FNIDFMEJGMB PJGLHKCLCNA;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly FNIDFMEJGMB IHINGNIBGEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private MCFPIPCNFDN KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private PFLCMKPFOMC OIICOGEJBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private EEHCKCIAPAN AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private NDJGAFFBPCH JFKPFEJELNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TransformOwnershipPhase HEIONBIKDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ObjectEmbodimentService MNJGLAAEFPK;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2D8B380", Offset = "0x2D89F80", VA = "0x182D8B380")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private DKCCOABIFKH NBPAAHMKIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2D8AC30", Offset = "0x2D89830", VA = "0x182D8AC30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2D87220", Offset = "0x2D85E20", VA = "0x182D87220", Slot = "33")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2D88650", Offset = "0x2D87250", VA = "0x182D88650", Slot = "34")]
		public bool GMLIGBEENEK(Transform KAMDPLLJPAH, out IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2D87550", Offset = "0x2D86150", VA = "0x182D87550", Slot = "35")]
		public Transform ALNLJDPANJK(Entity LLEBIIAHFDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2D898D0", Offset = "0x2D884D0", VA = "0x182D898D0", Slot = "30")]
		public bool JCBPEMMLHHC(Entity LLEBIIAHFDD, out Transform KAMDPLLJPAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A6D0", Offset = "0x2D892D0", VA = "0x182D8A6D0")]
		private void MCCFNAMKFAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B760", Offset = "0x2D8A360", VA = "0x182D8B760", Slot = "29")]
		public void PLIGLHGBAGN(Entity LLEBIIAHFDD, out Matrix4x4 GHAKBOOBHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2D89400", Offset = "0x2D88000", VA = "0x182D89400", Slot = "4")]
		public void IHDDNHABLEI(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2D87610", Offset = "0x2D86210", VA = "0x182D87610")]
		public void BFPDFLACGDF(Entity LLEBIIAHFDD, Vector3 LDFDHMMJHKJ, Quaternion FFJKKBHOOAD, Vector3 BBOMBFCOECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A5C0", Offset = "0x2D891C0", VA = "0x182D8A5C0")]
		public void LPEMLPHEGFD(Entity LLEBIIAHFDD, Vector3 LDFDHMMJHKJ, Quaternion FFJKKBHOOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2D88640", Offset = "0x2D87240", VA = "0x182D88640", Slot = "27")]
		public void GCMMDJODJOG(Entity LLEBIIAHFDD, out Matrix4x4 LOHMBGKFONM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2D89D00", Offset = "0x2D88900", VA = "0x182D89D00")]
		public void KHOOABIGBKK(Entity LLEBIIAHFDD, in Matrix4x4 GHAKBOOBHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2D89AE0", Offset = "0x2D886E0", VA = "0x182D89AE0")]
		public void JGEIAOPMIGJ(Entity LLEBIIAHFDD, in Matrix4x4 GHAKBOOBHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2D88270", Offset = "0x2D86E70", VA = "0x182D88270")]
		public void FDIKFFPEOAJ(Entity LLEBIIAHFDD, in Matrix4x4 LGNKGFFLMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x2D895F0", Offset = "0x2D881F0", VA = "0x182D895F0", Slot = "5")]
		public void IIGCMNAHEEM(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B270", Offset = "0x2D89E70", VA = "0x182D8B270", Slot = "6")]
		public Vector3 OGMEJNOPKIG(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2D88810", Offset = "0x2D87410", VA = "0x182D88810", Slot = "7")]
		public void HCIMLKEKEGD(Entity LLEBIIAHFDD, Quaternion GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2D89C10", Offset = "0x2D88810", VA = "0x182D89C10", Slot = "8")]
		public Quaternion KHECIBFIDFA(Entity LLEBIIAHFDD)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AA90", Offset = "0x2D89690", VA = "0x182D8AA90", Slot = "12")]
		public void MLLMOHDIEAN(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A4B0", Offset = "0x2D890B0", VA = "0x182D8A4B0", Slot = "11")]
		public Vector3 LODBGHKNMFG(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2D87CA0", Offset = "0x2D868A0", VA = "0x182D87CA0")]
		public void DCHNKNBMGKD(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AB90", Offset = "0x2D89790", VA = "0x182D8AB90")]
		private Vector3 NOABFLADDHG(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2D8ACF0", Offset = "0x2D898F0", VA = "0x182D8ACF0", Slot = "14")]
		public float NOLBODPKAIP(Entity LLEBIIAHFDD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B650", Offset = "0x2D8A250", VA = "0x182D8B650", Slot = "13")]
		public void PJJHINIBHKH(Entity LLEBIIAHFDD, float GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A7D0", Offset = "0x2D893D0", VA = "0x182D8A7D0")]
		private float MFAEEOOMFMP(Entity LLEBIIAHFDD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2D881E0", Offset = "0x2D86DE0", VA = "0x182D881E0")]
		public void FDENABGCBDO(Entity LLEBIIAHFDD, float ACDGDLHMKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A6F0", Offset = "0x2D892F0", VA = "0x182D8A6F0", Slot = "16")]
		public Vector3 MCGCOLLLJFK(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2D87D40", Offset = "0x2D86940", VA = "0x182D87D40", Slot = "15")]
		public void EEAKENOGMEN(Entity LLEBIIAHFDD, Vector3 KGGFKDAFODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2D87E80", Offset = "0x2D86A80", VA = "0x182D87E80")]
		private Vector3 EMOJPODLPEF(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2D87BD0", Offset = "0x2D867D0", VA = "0x182D87BD0")]
		public void CPHPPFHJEFC(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2D88910", Offset = "0x2D87510", VA = "0x182D88910")]
		[Conditional("DEBUG_BUILD")]
		private void HLAHFNPGBOD(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2D870C0", Offset = "0x2D85CC0", VA = "0x182D870C0", Slot = "36")]
		public void ABALAFELJND(Entity LLEBIIAHFDD, Vector3 DKGAADMNOOM, Quaternion MPLPNDNEAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A940", Offset = "0x2D89540", VA = "0x182D8A940", Slot = "9")]
		public void MGIGIPIDLIH(Entity LLEBIIAHFDD, out Vector3 DKGAADMNOOM, out Quaternion MPLPNDNEAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B3D0", Offset = "0x2D89FD0", VA = "0x182D8B3D0", Slot = "10")]
		public void OMJCHKEJCIH(Entity LLEBIIAHFDD, out Vector3 DKGAADMNOOM, out Quaternion MPLPNDNEAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2D87330", Offset = "0x2D85F30", VA = "0x182D87330", Slot = "37")]
		public void AKJEACGFEKE(Entity LLEBIIAHFDD, Vector3 DKGAADMNOOM, Quaternion MPLPNDNEAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2D89710", Offset = "0x2D88310", VA = "0x182D89710")]
		public void JBFBPHOGMOJ(Entity LLEBIIAHFDD, Vector3 DKGAADMNOOM, Quaternion MPLPNDNEAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2D87FB0", Offset = "0x2D86BB0", VA = "0x182D87FB0", Slot = "17")]
		public void FBLCCHGHILK(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A3D0", Offset = "0x2D88FD0", VA = "0x182D8A3D0", Slot = "18")]
		public Vector3 LKOKJKAIOIA(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2D88D60", Offset = "0x2D87960", VA = "0x182D88D60", Slot = "19")]
		public void IBJDHJLCLKC(Entity LLEBIIAHFDD, Quaternion GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2D88AC0", Offset = "0x2D876C0", VA = "0x182D88AC0", Slot = "20")]
		public Quaternion HMLMDEOMJAN(Entity LLEBIIAHFDD)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2D88FA0", Offset = "0x2D87BA0", VA = "0x182D88FA0", Slot = "22")]
		public void IFPCAPAAKPN(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2D88430", Offset = "0x2D87030", VA = "0x182D88430", Slot = "21")]
		public Vector3 FDOGMMGCOEN(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2D8BF50", Offset = "0x2D8AB50", VA = "0x182D8BF50", Slot = "23")]
		public void PPPNLBFCJFD(Entity LLEBIIAHFDD, float EGFILNDJKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2D899C0", Offset = "0x2D885C0", VA = "0x182D899C0", Slot = "24")]
		public float JDBDDFJHOEH(Entity LLEBIIAHFDD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2D876E0", Offset = "0x2D862E0", VA = "0x182D876E0", Slot = "25")]
		public void CHHLDHPCMMB(Entity LLEBIIAHFDD, Vector3 JENKAHPOBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AD90", Offset = "0x2D89990", VA = "0x182D8AD90", Slot = "26")]
		public Vector3 OABMAPMDEOE(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B8B0", Offset = "0x2D8A4B0", VA = "0x182D8B8B0", Slot = "31")]
		public void PPNOENJNOFM(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2D8B500", Offset = "0x2D8A100", VA = "0x182D8B500")]
		private IOBECAADPPL PGCICELADOB(Transform KAMDPLLJPAH)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A0C0", Offset = "0x2D88CC0", VA = "0x182D8A0C0")]
		private static TransformEntity KMHKBFDPGMA(OADLDHPKENB BIEGICDMJCM, GameObject HCKEHDIEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2D88520", Offset = "0x2D87120", VA = "0x182D88520", Slot = "32")]
		public void FMGLKIBNGOO(Entity LLEBIIAHFDD, Entity KAEGMLMLAJA, Entity JJHAACNMGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A8C0", Offset = "0x2D894C0", VA = "0x182D8A8C0")]
		private KBFBMIPJNPL MGIGIPIDLIH(Entity LLEBIIAHFDD)
		{
			return default(KBFBMIPJNPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2D8A2F0", Offset = "0x2D88EF0", VA = "0x182D8A2F0")]
		private bool LKGKJANJDBO(Entity LLEBIIAHFDD, out Entity GEOFAMNLJNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2D88BB0", Offset = "0x2D877B0", VA = "0x182D88BB0")]
		private void IBIBKHDJHGN(Entity LLEBIIAHFDD, out Matrix4x4 GHAKBOOBHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AED0", Offset = "0x2D89AD0", VA = "0x182D8AED0")]
		private void OBDFHIJJDPP(Entity LLEBIIAHFDD, out Matrix4x4 LGNKGFFLMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2D87E70", Offset = "0x2D86A70", VA = "0x182D87E70", Slot = "28")]
		private void EILAJOICKAP(Entity LLEBIIAHFDD, in Matrix4x4 LOHMBGKFONM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DAMCBGMFJNJ(typeof(PLNNKIEPIKP), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
internal sealed class PLNNKIEPIKP : OHFJHEDBJHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[NHBEJKCIJLO]
	private MCFPIPCNFDN KNPPOFLONHP;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2A91F00", Offset = "0x2A90B00", VA = "0x182A91F00", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2A91FD0", Offset = "0x2A90BD0", VA = "0x182A91FD0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public PLNNKIEPIKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
[DAMCBGMFJNJ(typeof(DEGJKJKDLPE), new string[] { })]
public class DEGJKJKDLPE
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct MPCMPBDOOAJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly DEGJKJKDLPE GEOFAMNLJNK;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D7B0A0", Offset = "0x2D79CA0", VA = "0x182D7B0A0")]
		public MPCMPBDOOAJ(DEGJKJKDLPE GEOFAMNLJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D7B080", Offset = "0x2D79C80", VA = "0x182D7B080", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int HLIHCMIFEEC;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool DDLLJOGDCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x15A0DF0", Offset = "0x159F9F0", VA = "0x1815A0DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action IHPCAFGJOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2FA3C60", Offset = "0x2FA2860", VA = "0x182FA3C60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2FA3BC0", Offset = "0x2FA27C0", VA = "0x182FA3BC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3D20", Offset = "0x2FA2920", VA = "0x182FA3D20")]
	public MPCMPBDOOAJ LDPILBHHNFH()
	{
		return default(MPCMPBDOOAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x1AA5DF0", Offset = "0x1AA49F0", VA = "0x181AA5DF0")]
	public void PMGJFJIAKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3D00", Offset = "0x2FA2900", VA = "0x182FA3D00")]
	public void KKJEAOGKMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public DEGJKJKDLPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DAMCBGMFJNJ(typeof(GPFDLOIJJBP), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
public class GPFDLOIJJBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private int HLIHCMIFEEC;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool PAOBNFNAFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xE9FA10", Offset = "0xE9E610", VA = "0x180E9FA10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x885E20", Offset = "0x884A20", VA = "0x180885E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public GPFDLOIJJBP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DAMCBGMFJNJ(typeof(EnableComponentSystemsInScope), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.ComponentSystemTypes)]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	public class EnableComponentSystemsInScope : OHFJHEDBJHF, BFHAHCPNLAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct OHOMNAAHBDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<int> PKJIGGECDGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<int> EMLNAJJBPOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private Dictionary<ComponentSystemBase, int> DPIFDIMDPPM;

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD5E0", Offset = "0x3DDC1E0", VA = "0x183DDD5E0")]
			public OHOMNAAHBDO(NativeArray<int> PKJIGGECDGK, NativeArray<int> EMLNAJJBPOG, Dictionary<ComponentSystemBase, int> DPIFDIMDPPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD360", Offset = "0x3DDBF60", VA = "0x183DDD360")]
			public void IGEPHEDHJAL(IEnumerable<ComponentSystemBase> PCMOOAJDLNB, JIJBLGHADKE CFDJNNENHMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class GGDADDJAKPD : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private ComponentSystemBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public EnableComponentSystemsInScope <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private int start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>3__start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private int end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>3__end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700006B")]
			ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
			[DebuggerHidden]
			public GGDADDJAKPD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x3DD8420", Offset = "0x3DD7020", VA = "0x183DD8420", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x3DD85F0", Offset = "0x3DD71F0", VA = "0x183DD85F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x3DD8540", Offset = "0x3DD7140", VA = "0x183DD8540", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x3DD8540", Offset = "0x3DD7140", VA = "0x183DD8540", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public const JIJBLGHADKE KKOAOLFPCOI = JIJBLGHADKE.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly FNIDFMEJGMB JIKBAFJKAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN KJEBDBMGNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private World AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private PGEEJALGCGE HFDOFHJBJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private NativeArray<int> NBHHGMDALHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private NativeArray<int> HBHIKLILDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int OPAPEIICLLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private JIJBLGHADKE LAFNHIOIKBP;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EC60", Offset = "0x2A9D860", VA = "0x182A9EC60", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2A9ED80", Offset = "0x2A9D980", VA = "0x182A9ED80", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EED0", Offset = "0x2A9DAD0", VA = "0x182A9EED0")]
		[IteratorStateMachine(typeof(GGDADDJAKPD))]
		private IEnumerable<ComponentSystemBase> FLHEONDAKAH(int HOKMFDPKLJA, int OCMAALMMILB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FD70", Offset = "0x2A9E970", VA = "0x182A9FD70", Slot = "5")]
		public void PGNCABCBGBJ(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F010", Offset = "0x2A9DC10", VA = "0x182A9F010")]
		private void HHOOEHNKNPJ(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F160", Offset = "0x2A9DD60", VA = "0x182A9F160")]
		public void HHOOEHNKNPJ(JIJBLGHADKE CJLOHKHKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F470", Offset = "0x2A9E070", VA = "0x182A9F470")]
		private void MFBNMNBOABJ(JIJBLGHADKE CJLOHKHKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FD80", Offset = "0x2A9E980", VA = "0x182A9FD80")]
		private void PIDHHEDJGJB(JIJBLGHADKE CJLOHKHKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F3B0", Offset = "0x2A9DFB0", VA = "0x182A9F3B0")]
		private void KPNEMMFDCEM(JIJBLGHADKE CJLOHKHKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F720", Offset = "0x2A9E320", VA = "0x182A9F720")]
		private void ONPDFLHJOKF(int HOKMFDPKLJA, int OCMAALMMILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EE10", Offset = "0x2A9DA10", VA = "0x182A9EE10")]
		private void EEFBGNFDBDE(int HOKMFDPKLJA, int OCMAALMMILB, bool DHOJGMOHHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F700", Offset = "0x2A9E300", VA = "0x182A9F700")]
		private int OMFCDJDHNKI(JIJBLGHADKE CJLOHKHKFCM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F7E0", Offset = "0x2A9E3E0", VA = "0x182A9F7E0")]
		private bool PGLFJBOBKLD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F260", Offset = "0x2A9DE60", VA = "0x182A9F260")]
		private Dictionary<ComponentSystemBase, int> JCDLECKEKJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x2A9ED40", Offset = "0x2A9D940", VA = "0x182A9ED40")]
		private void DKJPLKEKGDF(NativeArray<int> PKJIGGECDGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EF60", Offset = "0x2A9DB60", VA = "0x182A9EF60")]
		private void HBOHPCKFPLP(NativeArray<int> EMLNAJJBPOG, NativeArray<int> PKJIGGECDGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F350", Offset = "0x2A9DF50", VA = "0x182A9F350")]
		private static JIJBLGHADKE JHLDJLBMFGK(Type BIEGICDMJCM, JIJBLGHADKE BJJKLHEAKLF)
		{
			return default(JIJBLGHADKE);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FEA0", Offset = "0x2A9EAA0", VA = "0x182A9FEA0")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x2A9F410", Offset = "0x2A9E010", VA = "0x182A9F410")]
		[CompilerGenerated]
		private void LLJKBIFLEKB(OHFJHEDBJHF MMBOEGCIFOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A9ECE0", Offset = "0x2A9D8E0", VA = "0x182A9ECE0")]
		[CompilerGenerated]
		private void BECDJLOHMCE(HMFGCABFMPC MMBOEGCIFOD)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[HFIGNCEGOKM(DDEOJCINOPG.WorldService)]
	[DAMCBGMFJNJ(typeof(HMCNJNGCNFE), new string[] { })]
	public class TickService : OHFJHEDBJHF, HMCNJNGCNFE
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static readonly ProfilerMarker BBLIJJKNGKH;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly ProfilerMarker PPLNMLMMDGH;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly ProfilerMarker EEOPOELLKNA;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly ProfilerMarker FDOJOHPDFMH;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly ProfilerMarker HCPKIFHONNI;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly ProfilerMarker AAIEEIPOLLC;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly ProfilerMarker DGIFLEFEGBI;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly ProfilerMarker PELHDGNFKFD;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly ProfilerMarker OGMIKGEDHCI;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly ProfilerMarker JPJIOIMNAMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN KJEBDBMGNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[NHBEJKCIJLO]
		private LJHKOFPCONB PFNEAPNCEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[NHBEJKCIJLO]
		private PKOBMDDCGBM LPGMONBIEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[NHBEJKCIJLO]
		private TransformOwnershipPhase BGCOGDCHDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[NHBEJKCIJLO]
		private TimeService MHIJNFDOFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private LGIKDIEECOD AEEDEJIEEFL;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private bool BJJLCKEPDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x2D85E10", Offset = "0x2D84A10", VA = "0x182D85E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private bool NMBOFDCLNAN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x2D85FD0", Offset = "0x2D84BD0", VA = "0x182D85FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool LGHDIOGIOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x2D85E10", Offset = "0x2D84A10", VA = "0x182D85E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool OIAKCIAOGFF
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x2D85E10", Offset = "0x2D84A10", VA = "0x182D85E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2D85300", Offset = "0x2D83F00", VA = "0x182D85300", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2D85540", Offset = "0x2D84140", VA = "0x182D85540", Slot = "14")]
		public void DBHLANONDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2D85660", Offset = "0x2D84260", VA = "0x182D85660", Slot = "15")]
		public void DJKIGJJOPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D85470", Offset = "0x2D84070", VA = "0x182D85470", Slot = "5")]
		public void CBPENPLMJAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2D85780", Offset = "0x2D84380", VA = "0x182D85780", Slot = "6")]
		public void EOIOBJHFAIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2D861F0", Offset = "0x2D84DF0", VA = "0x182D861F0", Slot = "7")]
		public void PDGIPGAJNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D86070", Offset = "0x2D84C70", VA = "0x182D86070", Slot = "8")]
		public void OMFEJEGFEHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D86370", Offset = "0x2D84F70", VA = "0x182D86370", Slot = "9")]
		public void POONBEDCDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D859D0", Offset = "0x2D845D0", VA = "0x182D859D0", Slot = "10")]
		public void GLHKIDNPJDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D85900", Offset = "0x2D84500", VA = "0x182D85900", Slot = "11")]
		public void FPCDOODFELG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "13")]
		public void NDHHBMAIDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D85E80", Offset = "0x2D84A80", VA = "0x182D85E80", Slot = "12")]
		public void IHEMIJFEAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[HFIGNCEGOKM(DDEOJCINOPG.WorldService)]
	[DAMCBGMFJNJ(typeof(EEHCKCIAPAN), new string[] { })]
	public class WorldService : EEHCKCIAPAN, IDisposable, KGABHKADGEM
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private LGIKDIEECOD AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool IBOHJGMEBIO;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public LGIKDIEECOD IAMBCCOEDHO
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public DKCCOABIFKH NBPAAHMKIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x2A7F9D0", Offset = "0x2A7E5D0", VA = "0x182A7F9D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x2D94570", Offset = "0x2D93170", VA = "0x182D94570", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool AACDAEOPAIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6904D0", VA = "0x1806918D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2D94440", Offset = "0x2D93040", VA = "0x182D94440", Slot = "10")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2D94330", Offset = "0x2D92F30", VA = "0x182D94330")]
		private void GLBIKEOEKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2D94100", Offset = "0x2D92D00", VA = "0x182D94100", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D94550", Offset = "0x2D93150", VA = "0x182D94550", Slot = "8")]
		public ComponentSystemBase LMHMNNPCBNI(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DAMCBGMFJNJ(typeof(OFEOFFEAPKN), new string[] { })]
public sealed class MOOBIPDFDCI : OFEOFFEAPKN, PFBMKGBLLGM, KGABHKADGEM, OHFJHEDBJHF, HMFGCABFMPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class GEMBMJPKHNN : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696C40", VA = "0x180698040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x3DD83D0", Offset = "0x3DD6FD0", VA = "0x183DD83D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xAB8140", Offset = "0xAB6D40", VA = "0x180AB8140")]
		[DebuggerHidden]
		public GEMBMJPKHNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x3DD80C0", Offset = "0x3DD6CC0", VA = "0x183DD80C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x3DD8390", Offset = "0x3DD6F90", VA = "0x183DD8390", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x3DD82F0", Offset = "0x3DD6EF0", VA = "0x183DD82F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x3DD82F0", Offset = "0x3DD6EF0", VA = "0x183DD82F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[NHBEJKCIJLO]
	private OFDPPBHBKCF HFDCOKODHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly CMNFDIIGBFP AHDFHHIPKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly Dictionary<string, IMCOEDLDCBA> MFFJPCBJMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<int, OFBDBNCAANB> DGFEFCFMPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<HLPDKNGJOIH> GEPFLJKDGPN;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public OFBDBNCAANB OCMMOFPCKHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEC50", Offset = "0x2ABD850", VA = "0x182ABEC50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<HLPDKNGJOIH> NFCDLNOFPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2ABE1B0", Offset = "0x2ABCDB0", VA = "0x182ABE1B0", Slot = "8")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2ABF010", Offset = "0x2ABDC10", VA = "0x182ABF010", Slot = "9")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2ABE560", Offset = "0x2ABD160", VA = "0x182ABE560", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2ABEF80", Offset = "0x2ABDB80", VA = "0x182ABEF80", Slot = "6")]
	public bool NMPFLBADLAK(HLPDKNGJOIH GCEENFOFNFL, out OFBDBNCAANB MKEBBFCGOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2ABE5F0", Offset = "0x2ABD1F0", VA = "0x182ABE5F0")]
	private void EBLCIJFDNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2ABEDE0", Offset = "0x2ABD9E0", VA = "0x182ABEDE0")]
	private void KLKEDCGOOML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2ABF030", Offset = "0x2ABDC30", VA = "0x182ABF030")]
	private IMCOEDLDCBA PMCBLGEIALO(string HLDDMFJGIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2ABEC50", Offset = "0x2ABD850", VA = "0x182ABEC50")]
	private IMCOEDLDCBA HPHNDCDMEHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2ABE2A0", Offset = "0x2ABCEA0", VA = "0x182ABE2A0")]
	private IMCOEDLDCBA DJBFBMPINPP(string HLDDMFJGIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2ABE980", Offset = "0x2ABD580", VA = "0x182ABE980")]
	private IMCOEDLDCBA GIGEAGBMKFE(string GEMBNOGNCGO, string JJFHDFJGCDG, [Optional] IMCOEDLDCBA DFPHOBNBGMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2ABEB50", Offset = "0x2ABD750", VA = "0x182ABEB50")]
	[IteratorStateMachine(typeof(GEMBMJPKHNN))]
	private IEnumerable<(string, string)> HMLIBAJJOAH(string HLDDMFJGIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2ABED90", Offset = "0x2ABD990", VA = "0x182ABED90")]
	private bool JKKLPGGEHNH(HLPDKNGJOIH GCEENFOFNFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2ABECB0", Offset = "0x2ABD8B0", VA = "0x182ABECB0")]
	private CMNFDIIGBFP IGCNNMAFJAM(HLPDKNGJOIH GCEENFOFNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2ABE510", Offset = "0x2ABD110", VA = "0x182ABE510")]
	private CMNFDIIGBFP DPMALEFNPNG(HLPDKNGJOIH GCEENFOFNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2ABEBC0", Offset = "0x2ABD7C0", VA = "0x182ABEBC0")]
	private CMNFDIIGBFP HOFPEFFBCNG(HLPDKNGJOIH GCEENFOFNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2ACAF50", Offset = "0x2AC9B50", VA = "0x182ACAF50")]
	private T PGBIBMODGLC<T>(HLPDKNGJOIH GCEENFOFNFL) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2ABE0D0", Offset = "0x2ABCCD0", VA = "0x182ABE0D0")]
	private FieldInfo ABJENNJOPIH(HLPDKNGJOIH GCEENFOFNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2ABF090", Offset = "0x2ABDC90", VA = "0x182ABF090")]
	public MOOBIPDFDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2ABE210", Offset = "0x2ABCE10", VA = "0x182ABE210")]
	[CompilerGenerated]
	private int BBGGGPEHBGP(HLPDKNGJOIH LEOEMBMBFBC, HLPDKNGJOIH GHDGKPNPOBN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class IMCOEDLDCBA : OFBDBNCAANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly string CMDFKBOILDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly IMCOEDLDCBA DFPHOBNBGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly List<IMCOEDLDCBA> EODGABLHBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly List<HLPDKNGJOIH> HFDCOKODHFK;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public string AMMOPLMFOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public OFBDBNCAANB MPNHLJEMILM
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<OFBDBNCAANB> JEOGLOBMCMD
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IEnumerable<HLPDKNGJOIH> MDNKEJMDPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0490", Offset = "0x2AAF090", VA = "0x182AB0490")]
	public IMCOEDLDCBA(string NLCIGFDKGEE, IMCOEDLDCBA GEOFAMNLJNK)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[HFIGNCEGOKM(DDEOJCINOPG.History)]
	[DAMCBGMFJNJ(typeof(CGEDEAJAIJO), new string[] { })]
	[IAGJGLKEJDP(typeof(HistoryService))]
	public class HistoryService : OHFJHEDBJHF, IDisposable, CGEDEAJAIJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private enum PJEMLKAHKCA
		{
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private readonly struct KFFOFJJFLEE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly PJEMLKAHKCA CCKDFCOGNCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly HistoryService EBNNPKINFJN;

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA840", Offset = "0x3DD9440", VA = "0x183DDA840")]
			public KFFOFJJFLEE(HistoryService EBNNPKINFJN, bool DLNKDNMKAJE, uint OPAPEIICLLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA810", Offset = "0x3DD9410", VA = "0x183DDA810", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public class FMJEOFKLAPC
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct FCGLEGLCPEM : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				private readonly FMJEOFKLAPC DEKNKGENFOI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private readonly bool IHEPAJJBLBK;

				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0x3DD6A40", Offset = "0x3DD5640", VA = "0x183DD6A40")]
				public FCGLEGLCPEM(FMJEOFKLAPC DEKNKGENFOI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x3DD69D0", Offset = "0x3DD55D0", VA = "0x183DD69D0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct FBDAELGFFGI : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private readonly FMJEOFKLAPC DEKNKGENFOI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				private readonly bool IHEPAJJBLBK;

				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x3DD6A00", Offset = "0x3DD5600", VA = "0x183DD6A00")]
				public FBDAELGFFGI(FMJEOFKLAPC DEKNKGENFOI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0x3DD69D0", Offset = "0x3DD55D0", VA = "0x183DD69D0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private readonly HistoryService LAGIBNJDAAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool HMEODPFIGEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private int DACHMKGJHIM;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x3DD7900", Offset = "0x3DD6500", VA = "0x183DD7900")]
			public FMJEOFKLAPC(HistoryService LAGIBNJDAAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x3DD7880", Offset = "0x3DD6480", VA = "0x183DD7880")]
			public bool IEMGPGNIPJG(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x3DD78B0", Offset = "0x3DD64B0", VA = "0x183DD78B0")]
			public FBDAELGFFGI NMDBBOJHPIN()
			{
				return default(FBDAELGFFGI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x3DD7830", Offset = "0x3DD6430", VA = "0x183DD7830")]
			public FCGLEGLCPEM HABIKABIFIA()
			{
				return default(FCGLEGLCPEM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class MFLOHCHFKML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public MFLOHCHFKML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x3DDC5B0", Offset = "0x3DDB1B0", VA = "0x183DDC5B0")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class KLPDAMDBGOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public KLPDAMDBGOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x3DDAC70", Offset = "0x3DD9870", VA = "0x183DDAC70")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class ECIAODHFCOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
			public ECIAODHFCOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x3DD63B0", Offset = "0x3DD4FB0", VA = "0x183DD63B0")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly UndoAction JKOMOHGBHEA;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly RedoAction ENGCDBANDJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private PHDLJHDBIMF EIEBHEAPGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private ActionBuffer ANLCKKLOICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private ActionBuffer DLMBHEBJPJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private LGJKHPCIMFN IMINMHPFHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TransformOwnershipPhase BGCOGDCHDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private PropertyChangeRouterService JODFMOCJBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private LAIOJMOLDGG FGKPEHNKLAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private PJEMLKAHKCA BJDOBPHGEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private FMJEOFKLAPC DEKNKGENFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool IBOHJGMEBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private NHMIEEEHOBN LPFIHLDFGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private MGNHPFHGDHE LMDAEAFPNJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private EBLKGKAPHAO FJMPLGHEGOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly GatherPropertiesForUndelete OHPOBLGIDMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private uint NNJKHJOGLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private uint MHFELLFAOMI;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private FMJEOFKLAPC DPDHOMJCCHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x68D770", Offset = "0x68C370", VA = "0x18068D770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool PEEOHENOGEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD990", Offset = "0x2AAC590", VA = "0x182AAD990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool GDKJPIBBFCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x2AACA60", Offset = "0x2AAB660", VA = "0x182AACA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool MDLKKDDINNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD960", Offset = "0x2AAC560", VA = "0x182AAD960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int ONCGLDJOEAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x2AADC90", Offset = "0x2AAC890", VA = "0x182AADC90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int ENHOLPOOILM
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x2AADC70", Offset = "0x2AAC870", VA = "0x182AADC70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool DAOCBLNCILA
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x2AACF00", Offset = "0x2AABB00", VA = "0x182AACF00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private bool GOCNJIBGJGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD720", Offset = "0x2AAC320", VA = "0x182AAD720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool AFLNKEFMNKI
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x9496F0", Offset = "0x9482F0", VA = "0x1809496F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x11A6A20", Offset = "0x11A5620", VA = "0x1811A6A20", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private ActionBuffer FBNJDMNMKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE170", Offset = "0x2AACD70", VA = "0x182AAE170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action JFIGJHFDONI
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD750", Offset = "0x2AAC350", VA = "0x182AAD750", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x2AADFF0", Offset = "0x2AACBF0", VA = "0x182AADFF0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action PAOGCFIAPCE
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x2AAE250", Offset = "0x2AACE50", VA = "0x182AAE250")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x2AAD1A0", Offset = "0x2AABDA0", VA = "0x182AAD1A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC5B0", Offset = "0x2AAB1B0", VA = "0x182AAC5B0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD2A0", Offset = "0x2AABEA0", VA = "0x182AAD2A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2AACB00", Offset = "0x2AAB700", VA = "0x182AACB00")]
		private void ALDGCEFMENE(ELJHNEOGEBP IBGBBCHPJJF, CBDNIJIKHKI OHLAHMOJLKO, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE710", Offset = "0x2AAD310", VA = "0x182AAE710")]
		private void PNAEOCCBJHE(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG DMFCDDGFOMD, EKBGHCIKEGG IOOLGMDKBMN, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2AADE10", Offset = "0x2AACA10", VA = "0x182AADE10")]
		private void LFLPHHCBKLB(ELJHNEOGEBP IBGBBCHPJJF, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2AADC10", Offset = "0x2AAC810", VA = "0x182AADC10", Slot = "14")]
		public IDisposable JAIMDJLNPAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD240", Offset = "0x2AABE40", VA = "0x182AAD240", Slot = "9")]
		public IDisposable DEFPONBPPFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2AADD30", Offset = "0x2AAC930", VA = "0x182AADD30", Slot = "6")]
		public UndoAction KJCOELNOOIF()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2AACD20", Offset = "0x2AAB920", VA = "0x182AACD20", Slot = "15")]
		public RedoAction BGHACECAOIO()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD660", Offset = "0x2AAC260", VA = "0x182AAD660", Slot = "16")]
		public UndoAction EKKIOLMIBCP()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2AACDE0", Offset = "0x2AAB9E0", VA = "0x182AACDE0", Slot = "7")]
		public RedoAction BGHACECAOIO(UndoAction EHPFANFOFFJ)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD540", Offset = "0x2AAC140", VA = "0x182AAD540", Slot = "8")]
		public UndoAction EKKIOLMIBCP(RedoAction EHPFANFOFFJ)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2AADB00", Offset = "0x2AAC700", VA = "0x182AADB00")]
		public bool HOIBCDGIDGC(HAKMMILMCEL OHAFKLLCGOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD9F0", Offset = "0x2AAC5F0", VA = "0x182AAD9F0", Slot = "17")]
		public void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2AADA40", Offset = "0x2AAC640", VA = "0x182AADA40")]
		public void HCPNNJMCDBO(ELJHNEOGEBP IBGBBCHPJJF, CBDNIJIKHKI OHLAHMOJLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE090", Offset = "0x2AACC90", VA = "0x182AAE090")]
		public void MCLJDJGOIAO(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK, in EKBGHCIKEGG IOOLGMDKBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE1A0", Offset = "0x2AACDA0", VA = "0x182AAE1A0")]
		public void PAHKHPEICKF(ELJHNEOGEBP IBGBBCHPJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE5B0", Offset = "0x2AAD1B0", VA = "0x182AAE5B0")]
		private void PHDFNOOPFPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2AADB40", Offset = "0x2AAC740", VA = "0x182AADB40")]
		private void IBOCJEEMFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2AADDF0", Offset = "0x2AAC9F0", VA = "0x182AADDF0")]
		private void LBHEDBIBNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE610", Offset = "0x2AAD210", VA = "0x182AAE610")]
		private GMPPFOMGOIP PKALDDHBCIH()
		{
			return default(GMPPFOMGOIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD730", Offset = "0x2AAC330", VA = "0x182AAD730")]
		private uint FAHOCELMKDO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE5F0", Offset = "0x2AAD1F0", VA = "0x182AAE5F0")]
		private bool PIMNEGCKMML(out GMPPFOMGOIP KDJGJCHCIKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE180", Offset = "0x2AACD80", VA = "0x182AAE180")]
		private bool MJFMADEEBEB(out GMPPFOMGOIP KDJGJCHCIKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x2AACF10", Offset = "0x2AABB10", VA = "0x182AACF10")]
		private RedoAction CBLLLACCKBP(GMPPFOMGOIP KDJGJCHCIKK)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x2AADB80", Offset = "0x2AAC780", VA = "0x182AADB80")]
		private UndoAction IFIBIKKHNKO(GMPPFOMGOIP KDJGJCHCIKK)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE2F0", Offset = "0x2AACEF0", VA = "0x182AAE2F0")]
		private GMPPFOMGOIP PEHACFGONOI(GMPPFOMGOIP KDJGJCHCIKK, ActionBuffer KFGOCJLPDGC, bool DLNKDNMKAJE)
		{
			return default(GMPPFOMGOIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2AACF70", Offset = "0x2AABB70", VA = "0x182AACF70")]
		private void CHACGNDHHIC(Action KDJGJCHCIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2C87CF0", Offset = "0x2C868F0", VA = "0x182C87CF0")]
		private T CHACGNDHHIC<T>(Func<T> PMMFFGGLOBI)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2AADBE0", Offset = "0x2AAC7E0", VA = "0x182AADBE0")]
		private KFFOFJJFLEE IMJBMMMFDKA(bool DLNKDNMKAJE, uint OPAPEIICLLC)
		{
			return default(KFFOFJJFLEE);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2AAE810", Offset = "0x2AAD410", VA = "0x182AAE810")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD050", Offset = "0x2AABC50", VA = "0x182AAD050")]
		[CompilerGenerated]
		private UndoAction CIOOHOBLJFP()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2AAD7F0", Offset = "0x2AAC3F0", VA = "0x182AAD7F0")]
		[CompilerGenerated]
		private RedoAction GEHDEMDKIII()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2AACBC0", Offset = "0x2AAB7C0", VA = "0x182AACBC0")]
		[CompilerGenerated]
		private UndoAction BCNACMOKDKN()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class CAJBEFJMLEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NativeArray<byte> EJLDCNGHIAK;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int ONIEICNEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6777D0", VA = "0x180678BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xDAA6B0", Offset = "0xDA92B0", VA = "0x180DAA6B0")]
	public CAJBEFJMLEI(NativeArray<byte> EJLDCNGHIAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2F96230", Offset = "0x2F94E30", VA = "0x182F96230")]
	public static CAJBEFJMLEI KPOCFOKDNEC(NativeArray<byte> EJLDCNGHIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	public T ADOBPOEJHEB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	public NativeArray<T> MBNKNEEMGIK<T>(int PMIIGNOLFGJ, Allocator PBEDBDBGIPF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	public NativeArray<T> CJGMJIAAMBJ<T>(Allocator PBEDBDBGIPF) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class NHJNOGJCPIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private NativeArray<byte> EJLDCNGHIAK;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public int ONIEICNEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6777D0", VA = "0x180678BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0xDAA6B0", Offset = "0xDA92B0", VA = "0x180DAA6B0")]
	public NHJNOGJCPIM(NativeArray<byte> EJLDCNGHIAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D530", Offset = "0x2A7C130", VA = "0x182A7D530")]
	public static NHJNOGJCPIM KPOCFOKDNEC(NativeArray<byte> EJLDCNGHIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x32B19D0", Offset = "0x32B05D0", VA = "0x1832B19D0")]
	public T ADOBPOEJHEB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	public NativeArray<T> MBNKNEEMGIK<T>(int PMIIGNOLFGJ, Allocator PBEDBDBGIPF) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class KCNPIEBFGML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private NativeArray<byte> EJLDCNGHIAK;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int ONIEICNEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6777D0", VA = "0x180678BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xDAA6B0", Offset = "0xDA92B0", VA = "0x180DAA6B0")]
	public KCNPIEBFGML(NativeArray<byte> EJLDCNGHIAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3B30", Offset = "0x2AB2730", VA = "0x182AB3B30")]
	public static KCNPIEBFGML KPOCFOKDNEC(NativeArray<byte> EJLDCNGHIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x234D340", Offset = "0x234BF40", VA = "0x18234D340")]
	public void NBEDHNHDFEM<T>(in T GKFICKKHACC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x234D240", Offset = "0x234BE40", VA = "0x18234D240")]
	public void LNICOICMGDM<T>(NativeArray<T> HOGBBBFDPKI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	public void IDOEHLGNLNM<T>(NativeArray<T> GKFICKKHACC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class GCCHKIDPCNL
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4A90", Offset = "0x2AA3690", VA = "0x182AA4A90")]
	public static Span<byte> CDCKNJICGJB(this NativeArray<byte> EJLDCNGHIAK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4BA0", Offset = "0x2AA37A0", VA = "0x182AA4BA0")]
	public static ReadOnlySpan<byte> GAGEIOCHFNI(this NativeArray<byte> EJLDCNGHIAK)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4B20", Offset = "0x2AA3720", VA = "0x182AA4B20")]
	public static NativeArray<byte> DECEBLBFJFK(this NativeArray<byte> EJLDCNGHIAK, int HOKMFDPKLJA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4A10", Offset = "0x2AA3610", VA = "0x182AA4A10")]
	public static NativeArray<byte> BGHBOAFAPBJ(this NativeArray<byte> EJLDCNGHIAK, int CGKKILDEEIJ = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x3505BA0", Offset = "0x35047A0", VA = "0x183505BA0")]
	public static NativeArray<byte> BGHBOAFAPBJ<T>(this NativeArray<byte> EJLDCNGHIAK, int CGKKILDEEIJ = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4DA0", Offset = "0x2AA39A0", VA = "0x182AA4DA0")]
	public static NativeArray<byte> OCKBPNAOEEN(this NativeArray<byte> EJLDCNGHIAK, int CGKKILDEEIJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x3507140", Offset = "0x3505D40", VA = "0x183507140")]
	public static NativeArray<byte> OCKBPNAOEEN<T>(this NativeArray<byte> EJLDCNGHIAK, int CGKKILDEEIJ = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4D20", Offset = "0x2AA3920", VA = "0x182AA4D20")]
	public static NativeArray<byte> HJGEADCGNLA(this NativeArray<byte> EJLDCNGHIAK, int CGKKILDEEIJ = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x3505C00", Offset = "0x3504800", VA = "0x183505C00")]
	public static NativeArray<byte> HJGEADCGNLA<T>(this NativeArray<byte> EJLDCNGHIAK, int CGKKILDEEIJ = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class CKJPIMKKBID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private NativeList<byte> LENGKEKMOEB;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xDAA6B0", Offset = "0xDA92B0", VA = "0x180DAA6B0")]
	public CKJPIMKKBID(NativeList<byte> LENGKEKMOEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2F973A0", Offset = "0x2F95FA0", VA = "0x182F973A0")]
	public static CKJPIMKKBID KPOCFOKDNEC(NativeList<byte> EJLDCNGHIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public void NBEDHNHDFEM<T>(in T GKFICKKHACC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public void LNICOICMGDM<T>(NativeArray<T> GKFICKKHACC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public void IDOEHLGNLNM<T>(NativeArray<T> GKFICKKHACC) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	[DAMCBGMFJNJ(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.PropertyChanges)]
	public class PropertyChangeNetworkRouter : KGABHKADGEM, OHFJHEDBJHF, CPCNLIBKLCB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[NHBEJKCIJLO]
		private NIKKMCMENKO FHGALIAOBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[NHBEJKCIJLO]
		private IPCBIFCIILJ HFDCOKODHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[NHBEJKCIJLO]
		private DEGJKJKDLPE ACCEIPEFLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[NHBEJKCIJLO]
		private PropertyChangeRouterService JODFMOCJBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private PHDLJHDBIMF LBIAANDOGFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private ADMBCAGJIHO EEKKNDHOHCG;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public PHDLJHDBIMF GJMOMEECBBA
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2A99500", Offset = "0x2A98100", VA = "0x182A99500")]
		public PHDLJHDBIMF.CKFMEAKFNDD LDPILBHHNFH()
		{
			return default(PHDLJHDBIMF.CKFMEAKFNDD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x2A993E0", Offset = "0x2A97FE0", VA = "0x182A993E0", Slot = "4")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2A98A30", Offset = "0x2A97630", VA = "0x182A98A30", Slot = "5")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2A98E90", Offset = "0x2A97A90", VA = "0x182A98E90", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x2A992D0", Offset = "0x2A97ED0", VA = "0x182A992D0")]
		public void KJCOELNOOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x2A991B0", Offset = "0x2A97DB0", VA = "0x182A991B0")]
		public void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x2A99930", Offset = "0x2A98530", VA = "0x182A99930")]
		private void PJBNACMEFEB(ELJHNEOGEBP IBGBBCHPJJF, CBDNIJIKHKI OHLAHMOJLKO, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x2A98DE0", Offset = "0x2A979E0", VA = "0x182A98DE0")]
		private void DCOAGIKHEDK(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG DMFCDDGFOMD, EKBGHCIKEGG IOOLGMDKBMN, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x2A990B0", Offset = "0x2A97CB0", VA = "0x182A990B0")]
		private void GCPOMLMKHIM(ELJHNEOGEBP IBGBBCHPJJF, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2A99540", Offset = "0x2A98140", VA = "0x182A99540")]
		private void LFAEFFCBACC(ADMBCAGJIHO GPNGGDGNOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x2A98CB0", Offset = "0x2A978B0", VA = "0x182A98CB0")]
		private void CDHMBGEDEOB(ADMBCAGJIHO GPNGGDGNOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x2A99870", Offset = "0x2A98470", VA = "0x182A99870")]
		private void NDMCPKJMKFH(ADMBCAGJIHO GPNGGDGNOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x2A99A40", Offset = "0x2A98640", VA = "0x182A99A40")]
		private void PMGJFJIAKLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x2A993C0", Offset = "0x2A97FC0", VA = "0x182A993C0")]
		private void KKJEAOGKMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x2A991E0", Offset = "0x2A97DE0", VA = "0x182A991E0")]
		private void GOLFMCKEIHJ(ADMBCAGJIHO GPNGGDGNOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C280", Offset = "0x3D3AE80", VA = "0x183D3C280", Slot = "6")]
		private void ENPPCJGNHNJ<TKey, T>(global::JKHOGOMAANC<TKey, T> GCEENFOFNFL, object EDPENIGJGLF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[HFIGNCEGOKM(DDEOJCINOPG.History)]
	[DAMCBGMFJNJ(typeof(PropertyChangeRouterService), new string[] { })]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public delegate void MAPKNFKHBJB(ELJHNEOGEBP IBGBBCHPJJF, CBDNIJIKHKI OHLAHMOJLKO, bool IHPCEBHCPAN);

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public delegate void ACGLGIDBPFM(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG DMFCDDGFOMD, EKBGHCIKEGG IOOLGMDKBMN, bool IHPCEBHCPAN);

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void MECOGKEEJII(ELJHNEOGEBP IBGBBCHPJJF, bool IHPCEBHCPAN);

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public MAPKNFKHBJB GLBIKEOEKPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public ACGLGIDBPFM DHHJMOHDDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public MECOGKEEJII KDKECGLKPJA;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x2A99AB0", Offset = "0x2A986B0", VA = "0x182A99AB0")]
		public void HCPNNJMCDBO(ELJHNEOGEBP IBGBBCHPJJF, CBDNIJIKHKI OHLAHMOJLKO, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x2A99AD0", Offset = "0x2A986D0", VA = "0x182A99AD0")]
		public void MCLJDJGOIAO(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK, in EKBGHCIKEGG DMFCDDGFOMD, in EKBGHCIKEGG IOOLGMDKBMN, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x2A99B40", Offset = "0x2A98740", VA = "0x182A99B40")]
		public void PAHKHPEICKF(ELJHNEOGEBP IBGBBCHPJJF, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[DebuggerTypeProxy(typeof(KOCPJBKALIG))]
	[HFIGNCEGOKM(DDEOJCINOPG.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		internal class KOCPJBKALIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly ActionBuffer NFMJIELOGNG;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public int EONFJIOMKJN
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0x2D7AA30", Offset = "0x2D79630", VA = "0x182D7AA30")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public HHMAMHCDFMN[] CHKMBJBNJJC
			{
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x2D7A960", Offset = "0x2D79560", VA = "0x182D7A960")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676B40", VA = "0x180677F40")]
			public KOCPJBKALIG(ActionBuffer GLIPLLPKFJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x2D7AA80", Offset = "0x2D79680", VA = "0x182D7AA80")]
			[CompilerGenerated]
			private HHMAMHCDFMN ELNMJONANEL(GMPPFOMGOIP KDJGJCHCIKK)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		internal class HHMAMHCDFMN : CPCNLIBKLCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly ActionBuffer NFMJIELOGNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly GMPPFOMGOIP KDJGJCHCIKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private List<(ADMBCAGJIHO, string, object)> NEDADCIFNEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private NHJNOGJCPIM LDNLHJMBEIM;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public int EONFJIOMKJN
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0x2D7A030", Offset = "0x2D78C30", VA = "0x182D7A030")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public List<(ADMBCAGJIHO, string, object)> MHHJFFJLHLO
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A180", Offset = "0x2D78D80", VA = "0x182D7A180")]
			public HHMAMHCDFMN(ActionBuffer GLIPLLPKFJK, GMPPFOMGOIP KDJGJCHCIKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A080", Offset = "0x2D78C80", VA = "0x182D7A080")]
			private string GPLOGLOILPE(ADMBCAGJIHO EEKKNDHOHCG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x2D79CF0", Offset = "0x2D788F0", VA = "0x182D79CF0")]
			private void BLNLPEOGOOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x2D59300", Offset = "0x2D57F00", VA = "0x182D59300", Slot = "4")]
			public void HKFMGALIEPK<TKey, T>(global::JKHOGOMAANC<TKey, T> GCEENFOFNFL, [Optional] object EDPENIGJGLF) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private NativeList<byte> HPOOCPGAFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Stack<GMPPFOMGOIP> ONJOJJPKJMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly GDDDJDJEMIB LJLCKDFMJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly NHMIEEEHOBN LPFIHLDFGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly IPCBIFCIILJ HFDCOKODHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly bool PELFIBLKAOO;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public IPDEBOIIBOL FPPIFCEMCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x2F8EED0", Offset = "0x2F8DAD0", VA = "0x182F8EED0")]
			get
			{
				return default(IPDEBOIIBOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public int EONFJIOMKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x2F8E880", Offset = "0x2F8D480", VA = "0x182F8E880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F350", Offset = "0x2F8DF50", VA = "0x182F8F350")]
		public ActionBuffer(NHMIEEEHOBN LPFIHLDFGAL, IPCBIFCIILJ HFDCOKODHFK, bool PELFIBLKAOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E680", Offset = "0x2F8D280", VA = "0x182F8E680")]
		public bool BJHLOEENGCE(out GMPPFOMGOIP KDJGJCHCIKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2F8EC70", Offset = "0x2F8D870", VA = "0x182F8EC70")]
		public void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2F8EF10", Offset = "0x2F8DB10", VA = "0x182F8EF10")]
		public GMPPFOMGOIP KJCOELNOOIF(NEONIHENGJC NEDADCIFNEM, LAIOJMOLDGG FGKPEHNKLAL, uint GCEMIFHHBAO)
		{
			return default(GMPPFOMGOIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E650", Offset = "0x2F8D250", VA = "0x182F8E650")]
		public bool BCNHDOOHOFP(uint GCEMIFHHBAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2F8ECE0", Offset = "0x2F8D8E0", VA = "0x182F8ECE0")]
		public bool IDPLGGGLFHL(uint GCEMIFHHBAO, out GMPPFOMGOIP EHPFANFOFFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E710", Offset = "0x2F8D310", VA = "0x182F8E710")]
		public void CPPAHIOHGAN(GMPPFOMGOIP EHPFANFOFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F050", Offset = "0x2F8DC50", VA = "0x182F8F050")]
		[Conditional("DEBUG_BUILD")]
		private void LHCFNPALCEB(GMPPFOMGOIP EHPFANFOFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F1F0", Offset = "0x2F8DDF0", VA = "0x182F8F1F0")]
		private void PEHACFGONOI(GMPPFOMGOIP DAPBEPPIHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E9F0", Offset = "0x2F8D5F0", VA = "0x182F8E9F0")]
		private void FAHLJOPKDOC(NHJNOGJCPIM JPBCOPIKIPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F190", Offset = "0x2F8DD90", VA = "0x182F8F190")]
		private void OOILCPNCJFM(GMPPFOMGOIP KDJGJCHCIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E8C0", Offset = "0x2F8D4C0", VA = "0x182F8E8C0")]
		private NHJNOGJCPIM DPBIGJKEHJB(GMPPFOMGOIP KDJGJCHCIKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2F8E980", Offset = "0x2F8D580", VA = "0x182F8E980", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class GDDDJDJEMIB : CPCNLIBKLCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly NHMIEEEHOBN LPFIHLDFGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly IPCBIFCIILJ HFDCOKODHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private ELJHNEOGEBP IBGBBCHPJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private NHJNOGJCPIM BMFIAELBKOG;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6776E0", Offset = "0x6762E0", VA = "0x1806776E0")]
	public GDDDJDJEMIB(NHMIEEEHOBN LPFIHLDFGAL, IPCBIFCIILJ HFDCOKODHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x350B5C0", Offset = "0x350A1C0", VA = "0x18350B5C0", Slot = "4")]
	public void HKFMGALIEPK<TKey, T>(global::JKHOGOMAANC<TKey, T> FMAGINAIDLO, [Optional] object EDPENIGJGLF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4E10", Offset = "0x2AA3A10", VA = "0x182AA4E10")]
	public void KGEJHADOBPB(ADMBCAGJIHO EEKKNDHOHCG, ref NHJNOGJCPIM JPBCOPIKIPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class PHDLJHDBIMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct CKFMEAKFNDD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly PHDLJHDBIMF GEOFAMNLJNK;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3C50", Offset = "0x3DD2850", VA = "0x183DD3C50")]
		public CKFMEAKFNDD(PHDLJHDBIMF GEOFAMNLJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3C30", Offset = "0x3DD2830", VA = "0x183DD3C30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected NEONIHENGJC NEDADCIFNEM;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public NEONIHENGJC MHHJFFJLHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2A90710", Offset = "0x2A8F310", VA = "0x182A90710")]
		get
		{
			return default(NEONIHENGJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool KKEPKLMKHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2A90600", Offset = "0x2A8F200", VA = "0x182A90600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2A909F0", Offset = "0x2A8F5F0", VA = "0x182A909F0")]
	public PHDLJHDBIMF(NEONIHENGJC.HMFDILLHEGL DPADBFKBHKN = NEONIHENGJC.HMFDILLHEGL.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x2A90500", Offset = "0x2A8F100", VA = "0x182A90500")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A90510", Offset = "0x2A8F110", VA = "0x182A90510")]
	public void HCPNNJMCDBO(ELJHNEOGEBP IBGBBCHPJJF, CBDNIJIKHKI OHLAHMOJLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A90780", Offset = "0x2A8F380", VA = "0x182A90780")]
	public void MCLJDJGOIAO(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x2A90810", Offset = "0x2A8F410", VA = "0x182A90810")]
	public void PAHKHPEICKF(ELJHNEOGEBP IBGBBCHPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x2A908F0", Offset = "0x2A8F4F0", VA = "0x182A908F0")]
	public void PMGJFJIAKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x2A90610", Offset = "0x2A8F210", VA = "0x182A90610")]
	public void KKJEAOGKMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x2A904F0", Offset = "0x2A8F0F0", VA = "0x182A904F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x2A90750", Offset = "0x2A8F350", VA = "0x182A90750")]
	public CKFMEAKFNDD LDPILBHHNFH()
	{
		return default(CKFMEAKFNDD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct ADMBCAGJIHO : IComparable<ADMBCAGJIHO>, IEquatable<ADMBCAGJIHO>
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static readonly ADMBCAGJIHO AFLCPHCCBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public ELJHNEOGEBP IBGBBCHPJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public EBLKGKAPHAO KBPOLLDMHFK;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool ILPKKNHIECH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x18080E0", Offset = "0x1806CE0", VA = "0x1818080E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x698050", Offset = "0x696C50", VA = "0x180698050")]
	public ADMBCAGJIHO(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CF30", Offset = "0x2F8BB30", VA = "0x182F8CF30")]
	public void LBHIDKOONBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CD80", Offset = "0x2F8B980", VA = "0x182F8CD80", Slot = "4")]
	public int CompareTo(ADMBCAGJIHO MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CF90", Offset = "0x2F8BB90", VA = "0x182F8CF90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CE10", Offset = "0x2F8BA10", VA = "0x182F8CE10", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CDC0", Offset = "0x2F8B9C0", VA = "0x182F8CDC0", Slot = "5")]
	public bool Equals(ADMBCAGJIHO MCLIMJFDMCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CEF0", Offset = "0x2F8BAF0", VA = "0x182F8CEF0")]
	public static bool IKJLJMIELNH(ADMBCAGJIHO MGIINGKDNDK, ADMBCAGJIHO GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CF40", Offset = "0x2F8BB40", VA = "0x182F8CF40")]
	public static bool NKIHKFGIBBG(ADMBCAGJIHO MGIINGKDNDK, ADMBCAGJIHO GNLBKLBDKBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CEB0", Offset = "0x2F8BAB0", VA = "0x182F8CEB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[HFIGNCEGOKM(DDEOJCINOPG.History)]
	public class GatherPropertiesForUndelete : BBPNDNFFEFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private NHMIEEEHOBN LPFIHLDFGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private ELJHNEOGEBP IBGBBCHPJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private HistoryService LAGIBNJDAAK;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7A10", Offset = "0x2AA6610", VA = "0x182AA7A10")]
		public void LIBBDBBCEBA(ELJHNEOGEBP IBGBBCHPJJF, NHMIEEEHOBN LPFIHLDFGAL, HistoryService LAGIBNJDAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7B20", Offset = "0x2AA6720", VA = "0x182AA7B20", Slot = "4")]
		private void NCHDODBILKN(MLDLKMLLJME GCEENFOFNFL, in EKBGHCIKEGG GKFICKKHACC, object EDPENIGJGLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class DBBGCLIEIEG
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3050", Offset = "0x2FA1C50", VA = "0x182FA3050")]
	public static void CDHMBGEDEOB(NEONIHENGJC NEDADCIFNEM, ADMBCAGJIHO EEKKNDHOHCG, CBDNIJIKHKI OHLAHMOJLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3150", Offset = "0x2FA1D50", VA = "0x182FA3150")]
	public static void FGKMFIGNKJA(NEONIHENGJC NEDADCIFNEM, ADMBCAGJIHO EEKKNDHOHCG, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3360", Offset = "0x2FA1F60", VA = "0x182FA3360")]
	public static void NDMCPKJMKFH(NEONIHENGJC NEDADCIFNEM, ADMBCAGJIHO EEKKNDHOHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2FA32B0", Offset = "0x2FA1EB0", VA = "0x182FA32B0")]
	public static void JMNLKAJACCK(NEONIHENGJC NEDADCIFNEM, ADMBCAGJIHO EEKKNDHOHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3260", Offset = "0x2FA1E60", VA = "0x182FA3260")]
	public static CBDNIJIKHKI GILPGOPMANC(NEONIHENGJC NEDADCIFNEM, ADMBCAGJIHO EEKKNDHOHCG)
	{
		return default(CBDNIJIKHKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x22FC7A0", Offset = "0x22FB3A0", VA = "0x1822FC7A0")]
	public static T FGDKOHNHNHK<T>(NEONIHENGJC NEDADCIFNEM, ADMBCAGJIHO EEKKNDHOHCG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x22FC770", Offset = "0x22FB370", VA = "0x1822FC770")]
	public static T FGDKOHNHNHK<T>(ref NHJNOGJCPIM JLFCOOGLPMP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3210", Offset = "0x2FA1E10", VA = "0x182FA3210")]
	public static CBDNIJIKHKI GILPGOPMANC(ref NHJNOGJCPIM JLFCOOGLPMP)
	{
		return default(CBDNIJIKHKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct NEONIHENGJC : IEnumerable<ADMBCAGJIHO>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum HMFDILLHEGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct FFEDGPFKECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly NEONIHENGJC LENGKEKMOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly LAIOJMOLDGG FGKPEHNKLAL;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7490", Offset = "0x3DD6090", VA = "0x183DD7490")]
		public FFEDGPFKECM(NEONIHENGJC LENGKEKMOEB, LAIOJMOLDGG FGKPEHNKLAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7040", Offset = "0x3DD5C40", VA = "0x183DD7040")]
		public void PEGFMBDDJKL(NativeList<byte> HPPBGHGOBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x3DD72E0", Offset = "0x3DD5EE0", VA = "0x183DD72E0")]
		private void PGEBFPENKDK(ADMBCAGJIHO EEKKNDHOHCG, ref KCNPIEBFGML PHMLAMDMIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6C70", Offset = "0x3DD5870", VA = "0x183DD6C70")]
		private void GEKKMLDILJP(ADMBCAGJIHO EEKKNDHOHCG, ref KCNPIEBFGML PHMLAMDMIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6B80", Offset = "0x3DD5780", VA = "0x183DD6B80")]
		private NativeArray<byte> BOJCIOEFKGD(NativeList<byte> HPPBGHGOBLD)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6D00", Offset = "0x3DD5900", VA = "0x183DD6D00")]
		private NativeArray<byte> HCNFLCIAALH(NativeList<byte> HPPBGHGOBLD, int PMIIGNOLFGJ)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6DF0", Offset = "0x3DD59F0", VA = "0x183DD6DF0")]
		private int MPJAODKOEAB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7330", Offset = "0x3DD5F30", VA = "0x183DD7330")]
		private bool PLELEIHEMGH(ADMBCAGJIHO EEKKNDHOHCG, out NativeArray<byte> HPKIEGILCCE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct MPHGNCFIKKB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NativeList<byte> JLFCOOGLPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private NEONIHENGJC LENGKEKMOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly ADMBCAGJIHO GPNGGDGNOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly int HOKMFDPKLJA;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC890", Offset = "0x3DDB490", VA = "0x183DDC890")]
		internal MPHGNCFIKKB(NEONIHENGJC LENGKEKMOEB, ADMBCAGJIHO GPNGGDGNOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC610", Offset = "0x3DDB210", VA = "0x183DDC610", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC7D0", Offset = "0x3DDB3D0", VA = "0x183DDC7D0")]
		public void NOGMKBCDOFK(NativeArray<byte> GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC640", Offset = "0x3DDB240", VA = "0x183DDC640")]
		public void EICCOPFAGBF(NativeArray<byte> GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC6A0", Offset = "0x3DDB2A0", VA = "0x183DDC6A0")]
		public void GEKKMLDILJP(in EKBGHCIKEGG GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x3453830", Offset = "0x3452430", VA = "0x183453830")]
		public void GEKKMLDILJP<T>(T GKFICKKHACC) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC6B0", Offset = "0x3DDB2B0", VA = "0x183DDC6B0")]
		private void LIDHBEOHKNN(int GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC720", Offset = "0x3DDB320", VA = "0x183DDC720")]
		private void LIDHBEOHKNN(in EKBGHCIKEGG GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC830", Offset = "0x3DDB430", VA = "0x183DDC830")]
		private unsafe void LIDHBEOHKNN(void* GCMOCENHMPH, int PMIIGNOLFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC7D0", Offset = "0x3DDB3D0", VA = "0x183DDC7D0")]
		private void LIDHBEOHKNN(NativeArray<byte> HOGBBBFDPKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct NKAKNGEAMFF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private NEONIHENGJC LENGKEKMOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NativeArray<byte> JLFCOOGLPMP;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD050", Offset = "0x3DDBC50", VA = "0x183DDD050")]
		internal NKAKNGEAMFF(NEONIHENGJC LENGKEKMOEB, NativeArray<byte> JLFCOOGLPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCF80", Offset = "0x3DDBB80", VA = "0x183DDCF80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCF90", Offset = "0x3DDBB90", VA = "0x183DDCF90")]
		public NativeArray<byte> MBNKNEEMGIK(int PMIIGNOLFGJ)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCE90", Offset = "0x3DDBA90", VA = "0x183DDCE90")]
		public NativeArray<byte> CJGMJIAAMBJ()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x3454120", Offset = "0x3452D20", VA = "0x183454120")]
		public T ADOBPOEJHEB<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCD90", Offset = "0x3DDB990", VA = "0x183DDCD90")]
		public void ADOBPOEJHEB(in PMECDNBONOH GKFICKKHACC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct CABCGINNHEG : IEnumerator<ADMBCAGJIHO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly NativeList<ADMBCAGJIHO> EJLDCNGHIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private int BNNEENLPEFO;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public ADMBCAGJIHO FPPIFCEMCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x3DD3BE0", Offset = "0x3DD27E0", VA = "0x183DD3BE0", Slot = "4")]
			get
			{
				return default(ADMBCAGJIHO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x3DD3BA0", Offset = "0x3DD27A0", VA = "0x183DD3BA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x2EC2570", Offset = "0x2EC1170", VA = "0x182EC2570")]
		internal CABCGINNHEG(NativeList<ADMBCAGJIHO> HOGBBBFDPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3A60", Offset = "0x3DD2660", VA = "0x183DD3A60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3B60", Offset = "0x3DD2760", VA = "0x183DD3B60", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct OGJBCNCGCIG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private const int CDGMKGBJPIB = 0;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private const int NGDMLNPDEFF = 1;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private const int AFNNKOIODJN = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private NativeArray<int> JLFCOOGLPMP;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool MOCJDAMLGBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD170", Offset = "0x3DDBD70", VA = "0x183DDD170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public int PGDECNFGLPA
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD270", Offset = "0x3DDBE70", VA = "0x183DDD270")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD150", Offset = "0x3DDBD50", VA = "0x183DDD150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public HMFDILLHEGL BDGMIAEAAFO
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD160", Offset = "0x3DDBD60", VA = "0x183DDD160")]
			get
			{
				return default(HMFDILLHEGL);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD260", Offset = "0x3DDBE60", VA = "0x183DDD260")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool KKEPKLMKHMH
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD250", Offset = "0x3DDBE50", VA = "0x183DDD250")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD2C0", Offset = "0x3DDBEC0", VA = "0x183DDD2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool EIFBGDJBBHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD220", Offset = "0x3DDBE20", VA = "0x183DDD220")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD230", Offset = "0x3DDBE30", VA = "0x183DDD230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD2E0", Offset = "0x3DDBEE0", VA = "0x183DDD2E0")]
		public OGJBCNCGCIG(HMFDILLHEGL DPADBFKBHKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD1F0", Offset = "0x3DDBDF0", VA = "0x183DDD1F0")]
		private int HMFHOBMDMGG(int HPNBOGMLOLG, int DOFCPLMBMDE = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD280", Offset = "0x3DDBE80", VA = "0x183DDD280")]
		private void NMFBOCJEJOB(int HPNBOGMLOLG, int GKFICKKHACC, int DOFCPLMBMDE = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x3DDD1B0", Offset = "0x3DDBDB0", VA = "0x183DDD1B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private const int GPGLAGLENIB = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private const int LIPGFBMJJEA = 0;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly ADMBCAGJIHO EEOFCBMJFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private NativeHashMap<ADMBCAGJIHO, int> KJBGFIABFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private NativeList<ADMBCAGJIHO> NEDADCIFNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private NativeList<int> HBHIKLILDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private NativeList<byte> FONAKDHHGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private NativeList<byte> JLFCOOGLPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private OGJBCNCGCIG ENIALHNPBKC;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool KKEPKLMKHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2A7CBF0", Offset = "0x2A7B7F0", VA = "0x182A7CBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool MLCHHGLGNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C480", Offset = "0x2A7B080", VA = "0x182A7C480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int PGDECNFGLPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2A7CF70", Offset = "0x2A7BB70", VA = "0x182A7CF70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int EAMBHFJBPML
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C880", Offset = "0x2A7B480", VA = "0x182A7C880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool MOCJDAMLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C4A0", Offset = "0x2A7B0A0", VA = "0x182A7C4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C9A0", Offset = "0x2A7B5A0", VA = "0x182A7C9A0")]
	public static NEONIHENGJC GLBIKEOEKPG(HMFDILLHEGL DPADBFKBHKN = HMFDILLHEGL.Last, int FBJGICBLDOC = 16, int EIOILGMGLBD = 256)
	{
		return default(NEONIHENGJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D170", Offset = "0x2A7BD70", VA = "0x182A7D170")]
	private NEONIHENGJC(HMFDILLHEGL DPADBFKBHKN, int FBJGICBLDOC, int EIOILGMGLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C570", Offset = "0x2A7B170", VA = "0x182A7C570", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CCF0", Offset = "0x2A7B8F0", VA = "0x182A7CCF0")]
	public MPHGNCFIKKB LFAEFFCBACC(ADMBCAGJIHO GPNGGDGNOJH)
	{
		return default(MPHGNCFIKKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C4E0", Offset = "0x2A7B0E0", VA = "0x182A7C4E0")]
	public NKAKNGEAMFF DFLHBEMGOIJ(ADMBCAGJIHO GPNGGDGNOJH)
	{
		return default(NKAKNGEAMFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C690", Offset = "0x2A7B290", VA = "0x182A7C690")]
	public bool ENHEOKPGMAE(ADMBCAGJIHO GPNGGDGNOJH, out NKAKNGEAMFF OBKGOOLKCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CAD0", Offset = "0x2A7B6D0", VA = "0x182A7CAD0")]
	public bool JHMCGHJCCDK(ADMBCAGJIHO GPNGGDGNOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CB20", Offset = "0x2A7B720", VA = "0x182A7CB20")]
	public bool JJKGIMKEAKC(ADMBCAGJIHO GPNGGDGNOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C9E0", Offset = "0x2A7B5E0", VA = "0x182A7C9E0")]
	public void HNKJNMKKLJF(NativeList<byte> HPPBGHGOBLD, LAIOJMOLDGG FGKPEHNKLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x32AB160", Offset = "0x32A9D60", VA = "0x1832AB160")]
	public T DKHIEHMEGIE<T>(ADMBCAGJIHO GPNGGDGNOJH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C8C0", Offset = "0x2A7B4C0", VA = "0x182A7C8C0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C650", Offset = "0x2A7B250", VA = "0x182A7C650")]
	public CABCGINNHEG EMHOENNLHOC()
	{
		return default(CABCGINNHEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CD80", Offset = "0x2A7B980", VA = "0x182A7CD80")]
	private void LJKCFJJJJOC(ADMBCAGJIHO GPNGGDGNOJH, int HOKMFDPKLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CC00", Offset = "0x2A7B800", VA = "0x182A7CC00")]
	private void LBHIDKOONBO(int NAKPIAAEFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CF80", Offset = "0x2A7BB80", VA = "0x182A7CF80")]
	private void NOJFGHEBHLN(ADMBCAGJIHO GPNGGDGNOJH, int HOKMFDPKLJA, int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x32AB0E0", Offset = "0x32A9CE0", VA = "0x1832AB0E0")]
	private static T DKHIEHMEGIE<T>(NativeArray<byte> EJLDCNGHIAK, int HPNBOGMLOLG = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D0B0", Offset = "0x2A7BCB0", VA = "0x182A7D0B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D070", Offset = "0x2A7BC70", VA = "0x182A7D070", Slot = "4")]
	private IEnumerator<ADMBCAGJIHO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Preserve]
internal sealed class NHDCALDGKDJ<T> : OMEJOMKMFOF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private EntityQuery NJIBLOIMOJA;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2699FB0", Offset = "0x2698BB0", VA = "0x182699FB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x269A0D0", Offset = "0x2698CD0", VA = "0x18269A0D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x269A140", Offset = "0x2698D40", VA = "0x18269A140")]
	public NHDCALDGKDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2699F90", Offset = "0x2698B90", VA = "0x182699F90", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	internal class CleanupRigidbodyExImpl : OMEJOMKMFOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private EntityQuery NJIBLOIMOJA;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2F99960", Offset = "0x2F98560", VA = "0x182F99960", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2F99A00", Offset = "0x2F98600", VA = "0x182F99A00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Preserve]
internal class BAOEMFEFIBK : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private EntityQuery GCFHJHJPMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2F90040", Offset = "0x2F8EC40", VA = "0x182F90040", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2F90090", Offset = "0x2F8EC90", VA = "0x182F90090", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2F90120", Offset = "0x2F8ED20", VA = "0x182F90120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public BAOEMFEFIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
internal class HAMFOEEFEKE : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private PropertyDiffStateService PDDDKKFHDEJ;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7C40", Offset = "0x2AA6840", VA = "0x182AA7C40", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7C90", Offset = "0x2AA6890", VA = "0x182AA7C90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public HAMFOEEFEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private EntityQuery NJIBLOIMOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private SceneService OIICOGEJBID;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2FA67B0", Offset = "0x2FA53B0", VA = "0x182FA67B0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2FA6800", Offset = "0x2FA5400", VA = "0x182FA6800", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA6890", Offset = "0x2FA5490", VA = "0x182FA6890", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[DAMCBGMFJNJ(typeof(CullingBandService), new string[] { })]
	[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	public class CullingBandService : OHFJHEDBJHF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly List<global::BNGAOKMFDEK<HPLOFGACNGG>> PDDBOFHMBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN KJEBDBMGNJF;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2FA28E0", Offset = "0x2FA14E0", VA = "0x182FA28E0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2F10", Offset = "0x2FA1B10", VA = "0x182FA2F10")]
		public void PEOFOOEADCA(global::BNGAOKMFDEK<HPLOFGACNGG> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2AA0", Offset = "0x2FA16A0", VA = "0x182FA2AA0")]
		public void IIGPMKNGHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2930", Offset = "0x2FA1530", VA = "0x182FA2930", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2FD0", Offset = "0x2FA1BD0", VA = "0x182FA2FD0")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	[DAMCBGMFJNJ(typeof(ILOELKJEBPE), new string[] { })]
	public class PhysicsService : OHFJHEDBJHF, HMFGCABFMPC, ILOELKJEBPE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly FNIDFMEJGMB MKOIAFMCLEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private EntityManager CLLNDNAAIKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private EEHCKCIAPAN AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NPHLGLMBAHC FFFFALDNGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private PropertyEventCallbacksService PDAOAKHGMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private global::HFPFDBLLPPK<IDCMDHEBAPD> HJMNGJOEFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool IBOHJGMEBIO;

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<IOBECAADPPL, IDCMDHEBAPD> EELNILBIHEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x2A96260", Offset = "0x2A94E60", VA = "0x182A96260", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x2A96470", Offset = "0x2A95070", VA = "0x182A96470", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2A95E60", Offset = "0x2A94A60", VA = "0x182A95E60", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2A96300", Offset = "0x2A94F00", VA = "0x182A96300", Slot = "5")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x2A95F80", Offset = "0x2A94B80", VA = "0x182A95F80", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2A96190", Offset = "0x2A94D90", VA = "0x182A96190", Slot = "8")]
		public bool MHGEGFEMDEL(IOBECAADPPL DKHOCCDNDOH, out Collider KIHMMOLIPKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2A960D0", Offset = "0x2A94CD0", VA = "0x182A960D0")]
		private void LABPFJEEIPH(Entity LLEBIIAHFDD, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG KNAEAKFNOOB, EKBGHCIKEGG OCBHJKLFMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x2A96010", Offset = "0x2A94C10", VA = "0x182A96010", Slot = "9")]
		public void HFFOMMPOGAK(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[DAMCBGMFJNJ(typeof(PEGFCDNOKHB), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	public class RbexService : OHFJHEDBJHF, PEGFCDNOKHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private EEHCKCIAPAN KJEBDBMGNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private World AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private ANAIOGLOEGC AKFDFJHEHKO;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x2A9E960", Offset = "0x2A9D560", VA = "0x182A9E960")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B980", Offset = "0x2A9A580", VA = "0x182A9B980", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E020", Offset = "0x2A9CC20", VA = "0x182A9E020", Slot = "6")]
		public JJBGGEMNFLN LHGHMGCKJGM(IOBECAADPPL DKHOCCDNDOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C290", Offset = "0x2A9AE90", VA = "0x182A9C290", Slot = "5")]
		public void DGEJPBLIOMP(IOBECAADPPL DKHOCCDNDOH, JJBGGEMNFLN GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C4C0", Offset = "0x2A9B0C0", VA = "0x182A9C4C0", Slot = "34")]
		public CollisionDetectionMode EDGBNOCJKIM(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D140", Offset = "0x2A9BD40", VA = "0x182A9D140", Slot = "35")]
		public void HPACHJBCJMB(IOBECAADPPL DKHOCCDNDOH, CollisionDetectionMode GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DA60", Offset = "0x2A9C660", VA = "0x182A9DA60", Slot = "36")]
		public NIKBOPNLEII JKGIJKCIABC(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(NIKBOPNLEII);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CD20", Offset = "0x2A9B920", VA = "0x182A9CD20", Slot = "37")]
		public void GMDPEJECMOO(IOBECAADPPL DKHOCCDNDOH, NIKBOPNLEII GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DD00", Offset = "0x2A9C900", VA = "0x182A9DD00", Slot = "38")]
		public bool KJDHAOMDMIF(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C7A0", Offset = "0x2A9B3A0", VA = "0x182A9C7A0", Slot = "39")]
		public void FCHEFJMJJDM(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D600", Offset = "0x2A9C200", VA = "0x182A9D600", Slot = "40")]
		public IOBECAADPPL IENNNAFGFNJ(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D680", Offset = "0x2A9C280", VA = "0x182A9D680", Slot = "41")]
		public void IJKDOGNKHOG(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C340", Offset = "0x2A9AF40", VA = "0x182A9C340", Slot = "42")]
		public IOBECAADPPL DJKFCHELMJI(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E0B0", Offset = "0x2A9CCB0", VA = "0x182A9E0B0", Slot = "43")]
		public void LHJCDGMFADO(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D8D0", Offset = "0x2A9C4D0", VA = "0x182A9D8D0", Slot = "7")]
		public void JDFBMCLFMDD(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CAD0", Offset = "0x2A9B6D0", VA = "0x182A9CAD0", Slot = "8")]
		public void GCAONDBJOCG(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EA10", Offset = "0x2A9D610", VA = "0x182A9EA10", Slot = "9")]
		public int PEOBNLMKOKI(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E480", Offset = "0x2A9D080", VA = "0x182A9E480", Slot = "10")]
		public IOBECAADPPL MMFPKICCFCA(IOBECAADPPL DKHOCCDNDOH, int BNNEENLPEFO)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CFE0", Offset = "0x2A9BBE0", VA = "0x182A9CFE0", Slot = "11")]
		public void HHCBKCPNHID(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DB70", Offset = "0x2A9C770", VA = "0x182A9DB70", Slot = "12")]
		public void KAEJLAJLAJC(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG, IOBECAADPPL GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BA30", Offset = "0x2A9A630", VA = "0x182A9BA30", Slot = "13")]
		public void ADKKMBFLCIJ(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CDC0", Offset = "0x2A9B9C0", VA = "0x182A9CDC0", Slot = "14")]
		public bool GMPEGHIDDDI(IOBECAADPPL DKHOCCDNDOH, out IOBECAADPPL GKFICKKHACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C210", Offset = "0x2A9AE10", VA = "0x182A9C210", Slot = "15")]
		public void DCJONNNAHCE(IOBECAADPPL DKHOCCDNDOH, float3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BE90", Offset = "0x2A9AA90", VA = "0x182A9BE90", Slot = "16")]
		public bool BNGLMOAKPBG(IOBECAADPPL DKHOCCDNDOH, out float3 GKFICKKHACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C690", Offset = "0x2A9B290", VA = "0x182A9C690", Slot = "17")]
		public void EKICEJLBDCB(IOBECAADPPL DKHOCCDNDOH, float3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D700", Offset = "0x2A9C300", VA = "0x182A9D700", Slot = "18")]
		public bool IKPMJCPBOND(IOBECAADPPL DKHOCCDNDOH, out float3 GKFICKKHACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C810", Offset = "0x2A9B410", VA = "0x182A9C810", Slot = "26")]
		public float3 FEGAEGKLEFB(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BDB0", Offset = "0x2A9A9B0", VA = "0x182A9BDB0", Slot = "27")]
		public void BLPOFFDBAOF(IOBECAADPPL DKHOCCDNDOH, float3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B7C0", Offset = "0x2A9A3C0", VA = "0x182A9B7C0", Slot = "28")]
		public float AAHHNOMCAKC(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C620", Offset = "0x2A9B220", VA = "0x182A9C620", Slot = "29")]
		public void EIPCBICCOBK(IOBECAADPPL DKHOCCDNDOH, float GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E7E0", Offset = "0x2A9D3E0", VA = "0x182A9E7E0", Slot = "30")]
		public float OAJADHFCCGO(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C3F0", Offset = "0x2A9AFF0", VA = "0x182A9C3F0", Slot = "31")]
		public void DOCKKPDCLPG(IOBECAADPPL DKHOCCDNDOH, float GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C460", Offset = "0x2A9B060", VA = "0x182A9C460", Slot = "32")]
		public bool ECAIOAKBHJC(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E770", Offset = "0x2A9D370", VA = "0x182A9E770", Slot = "33")]
		public void OADFNGDKDEK(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E660", Offset = "0x2A9D260", VA = "0x182A9E660", Slot = "19")]
		public void NFKCPODOOFL(IOBECAADPPL DKHOCCDNDOH, float3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BBF0", Offset = "0x2A9A7F0", VA = "0x182A9BBF0", Slot = "20")]
		public bool BGIAGLNMAKD(IOBECAADPPL DKHOCCDNDOH, out float3 GKFICKKHACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C0C0", Offset = "0x2A9ACC0", VA = "0x182A9C0C0", Slot = "21")]
		public void CNABGMBFAAH(IOBECAADPPL DKHOCCDNDOH, quaternion GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2A9EB00", Offset = "0x2A9D700", VA = "0x182A9EB00", Slot = "22")]
		public bool PHKNDIBCBBP(IOBECAADPPL DKHOCCDNDOH, out quaternion GKFICKKHACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D1B0", Offset = "0x2A9BDB0", VA = "0x182A9D1B0", Slot = "23")]
		public bool IAALHBLJBJN(IOBECAADPPL DKHOCCDNDOH, out float3 OPFCFCMDOPF, out quaternion FHAHIJHNKCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C060", Offset = "0x2A9AC60", VA = "0x182A9C060", Slot = "44")]
		public CNIOBGEFFJI CHBHNMENNLG(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(CNIOBGEFFJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D0D0", Offset = "0x2A9BCD0", VA = "0x182A9D0D0", Slot = "45")]
		public void HMOJMHIAENP(IOBECAADPPL DKHOCCDNDOH, CNIOBGEFFJI GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E8D0", Offset = "0x2A9D4D0", VA = "0x182A9E8D0", Slot = "72")]
		public void OINGGHPGHJI(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CA40", Offset = "0x2A9B640", VA = "0x182A9CA40", Slot = "73")]
		public void GBPEBMDLGKK(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C900", Offset = "0x2A9B500", VA = "0x182A9C900", Slot = "74")]
		public bool FJPIFLEOPOL(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D510", Offset = "0x2A9C110", VA = "0x182A9D510", Slot = "81")]
		public void IDFBPIIPMIJ(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E3F0", Offset = "0x2A9CFF0", VA = "0x182A9E3F0", Slot = "82")]
		public void MLIGFHEEIJE(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C130", Offset = "0x2A9AD30", VA = "0x182A9C130", Slot = "83")]
		public bool DBBOIJIDJCO(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C520", Offset = "0x2A9B120", VA = "0x182A9C520", Slot = "84")]
		public IEnumerable<object> EFECIDLEPCI(IOBECAADPPL DKHOCCDNDOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DCA0", Offset = "0x2A9C8A0", VA = "0x182A9DCA0", Slot = "46")]
		public bool KCGADNIEGPF(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D5A0", Offset = "0x2A9C1A0", VA = "0x182A9D5A0", Slot = "47")]
		public void IEANFMCGNDH(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CF20", Offset = "0x2A9BB20", VA = "0x182A9CF20", Slot = "48")]
		public bool HAEOBEPKIAD(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E130", Offset = "0x2A9CD30", VA = "0x182A9E130", Slot = "49")]
		public void LHOFBPIOJNK(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BD50", Offset = "0x2A9A950", VA = "0x182A9BD50", Slot = "50")]
		public bool BIMBKJEDEFF(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C890", Offset = "0x2A9B490", VA = "0x182A9C890", Slot = "51")]
		public void FILPMINMLCA(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E390", Offset = "0x2A9CF90", VA = "0x182A9E390", Slot = "52")]
		public RigidbodyConstraints MGDFNLGGDAA(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CC40", Offset = "0x2A9B840", VA = "0x182A9CC40", Slot = "53")]
		public void GGEGCLIFGMG(IOBECAADPPL DKHOCCDNDOH, RigidbodyConstraints GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C980", Offset = "0x2A9B580", VA = "0x182A9C980", Slot = "54")]
		public float FLANNKKGAAL(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BAC0", Offset = "0x2A9A6C0", VA = "0x182A9BAC0", Slot = "55")]
		public void AKPFAOPEABC(IOBECAADPPL DKHOCCDNDOH, float GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E5A0", Offset = "0x2A9D1A0", VA = "0x182A9E5A0", Slot = "56")]
		public float MOBNINPJHNM(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D4A0", Offset = "0x2A9C0A0", VA = "0x182A9D4A0", Slot = "57")]
		public void ICGJJEELNFI(IOBECAADPPL DKHOCCDNDOH, float GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CF80", Offset = "0x2A9BB80", VA = "0x182A9CF80", Slot = "58")]
		public bool HDDOJPAPEFG(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D860", Offset = "0x2A9C460", VA = "0x182A9D860", Slot = "59")]
		public void IPECKBMFEID(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BE30", Offset = "0x2A9AA30", VA = "0x182A9BE30", Slot = "60")]
		public bool BNBAMLEHCLE(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DB00", Offset = "0x2A9C700", VA = "0x182A9DB00", Slot = "61")]
		public void JNOHHLKBKEI(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CBE0", Offset = "0x2A9B7E0", VA = "0x182A9CBE0", Slot = "62")]
		public int GDALBEBCCIF(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BFF0", Offset = "0x2A9ABF0", VA = "0x182A9BFF0", Slot = "63")]
		public void CDILBEBDIOC(IOBECAADPPL DKHOCCDNDOH, int GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E980", Offset = "0x2A9D580", VA = "0x182A9E980", Slot = "64")]
		public Rigidbody OMLDNMNPONF(IOBECAADPPL DKHOCCDNDOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B820", Offset = "0x2A9A420", VA = "0x182A9B820", Slot = "65")]
		public void ABDHMHEDHBF(IOBECAADPPL DKHOCCDNDOH, Rigidbody GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E6E0", Offset = "0x2A9D2E0", VA = "0x182A9E6E0", Slot = "75")]
		public void NHJBPKICKMJ(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E840", Offset = "0x2A9D440", VA = "0x182A9E840", Slot = "76")]
		public void ODFJOIAILBI(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D9E0", Offset = "0x2A9C5E0", VA = "0x182A9D9E0", Slot = "77")]
		public bool JFOBNEPONIJ(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BB30", Offset = "0x2A9A730", VA = "0x182A9BB30", Slot = "66")]
		public object AOHAMNLJCMI(IOBECAADPPL DKHOCCDNDOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DD60", Offset = "0x2A9C960", VA = "0x182A9DD60", Slot = "67")]
		public void KJIOOALPOAI(IOBECAADPPL DKHOCCDNDOH, object GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C710", Offset = "0x2A9B310", VA = "0x182A9C710", Slot = "68")]
		public object ELPDMCMECEJ(IOBECAADPPL DKHOCCDNDOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E1A0", Offset = "0x2A9CDA0", VA = "0x182A9E1A0", Slot = "69")]
		public void MCCMMCDDPPP(IOBECAADPPL DKHOCCDNDOH, object GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E600", Offset = "0x2A9D200", VA = "0x182A9E600", Slot = "70")]
		public float NCJPNODLAMB(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2A9CCB0", Offset = "0x2A9B8B0", VA = "0x182A9CCB0", Slot = "71")]
		public void GLEFIEFHIHK(IOBECAADPPL DKHOCCDNDOH, float GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DEC0", Offset = "0x2A9CAC0", VA = "0x182A9DEC0", Slot = "78")]
		public void KKHJKEHALKP(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9E300", Offset = "0x2A9CF00", VA = "0x182A9E300", Slot = "79")]
		public void MFLNODCHCJK(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9D420", Offset = "0x2A9C020", VA = "0x182A9D420", Slot = "80")]
		public bool IBFHHGMFDMM(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C9E0", Offset = "0x2A9B5E0", VA = "0x182A9C9E0", Slot = "24")]
		public void FNLGDHOLHOE(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9C1B0", Offset = "0x2A9ADB0", VA = "0x182A9C1B0", Slot = "25")]
		public void DBLAEJDMPBG(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E0C0", Offset = "0x3D9CCC0", VA = "0x183D9E0C0")]
		private void OGFJJPKDPEF<T>(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D8F0", Offset = "0x3D9C4F0", VA = "0x183D9D8F0")]
		private bool GJEGIGLPKBM<T>(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D7E0", Offset = "0x3D9C3E0", VA = "0x183D9D7E0")]
		private void DOHHNJJEEIG<T>(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x3D9DA90", Offset = "0x3D9C690", VA = "0x183D9DA90")]
		private bool JIEBNIILFCM<TC, TV>(IOBECAADPPL DKHOCCDNDOH, Func<TC, TV> PMMFFGGLOBI, out TV GKFICKKHACC) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x3D9DA10", Offset = "0x3D9C610", VA = "0x183D9DA10")]
		private bool JIEBNIILFCM<T>(IOBECAADPPL DKHOCCDNDOH, out T GKFICKKHACC) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x3D9DC70", Offset = "0x3D9C870", VA = "0x183D9DC70")]
		private T NNBCMJCEKDP<T>(IOBECAADPPL DKHOCCDNDOH) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E110", Offset = "0x3D9CD10", VA = "0x183D9E110")]
		private void OOMHGODPDDH<T>(IOBECAADPPL DKHOCCDNDOH, T GKFICKKHACC) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D180", Offset = "0x3D9BD80", VA = "0x183D9D180")]
		private void CCEGOLNGCFA<T>(IOBECAADPPL DKHOCCDNDOH, T GKFICKKHACC) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x3D9DA10", Offset = "0x3D9C610", VA = "0x183D9DA10")]
		private bool PDBOKAHNOEC<T>(IOBECAADPPL DKHOCCDNDOH, out T GKFICKKHACC) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x3D9DC10", Offset = "0x3D9C810", VA = "0x183D9DC10")]
		private T MAOGCHGEPOJ<T>(IOBECAADPPL DKHOCCDNDOH) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x3D9DA10", Offset = "0x3D9C610", VA = "0x183D9DA10")]
		private void IIKMANBOGLD<T>(IOBECAADPPL DKHOCCDNDOH, T GKFICKKHACC) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D840", Offset = "0x3D9C440", VA = "0x183D9D840")]
		private void FFAOGMBHHCD<T>(IOBECAADPPL DKHOCCDNDOH, T GKFICKKHACC) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9BBC0", Offset = "0x2A9A7C0", VA = "0x182A9BBC0")]
		private IOBECAADPPL BCANHHMFGHM(Entity LLEBIIAHFDD)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9DF50", Offset = "0x2A9CB50", VA = "0x182A9DF50")]
		private DynamicBuffer<Entity> KNCEAKPFOHP(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D950", Offset = "0x3D9C550", VA = "0x183D9D950")]
		private void HMOHHCCONEL<T>(IOBECAADPPL DKHOCCDNDOH, object GKFICKKHACC, Func<object, T> PMMFFGGLOBI) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		private void BLNLPEOGOOG<T>(ref global::PBJIHBFONCG<T> MPPBBBHMGNE) where T : struct, NEJDHLEFDKK
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		private void BLNLPEOGOOG<TC, TV>(ref global::AFDHPHLDLGD<TC, TV> MPPBBBHMGNE) where TC : struct, NEJDHLEFDKK
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
	[DAMCBGMFJNJ(typeof(KinematicSleepChangeService), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	public class KinematicSleepChangeService : OHFJHEDBJHF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class BCOEIMLKHGE : IEnumerable<JJBGGEMNFLN>, IEnumerable, IEnumerator<JJBGGEMNFLN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			private JJBGGEMNFLN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public KinematicSleepChangeService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			private NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public NativeArray<Entity> <>3__entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			private EntityManager <entityManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x170000A1")]
			private JJBGGEMNFLN System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A2")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004BB")]
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
			[DebuggerHidden]
			public BCOEIMLKHGE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x3DD3120", Offset = "0x3DD1D20", VA = "0x183DD3120", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2DE0", Offset = "0x3DD19E0", VA = "0x183DD2DE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x3DD31A0", Offset = "0x3DD1DA0", VA = "0x183DD31A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x3DD30E0", Offset = "0x3DD1CE0", VA = "0x183DD30E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x3DD3030", Offset = "0x3DD1C30", VA = "0x183DD3030", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JJBGGEMNFLN> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x3DD3030", Offset = "0x3DD1C30", VA = "0x183DD3030", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> PJDHFHJGFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN KJEBDBMGNJF;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7600", Offset = "0x2AB6200", VA = "0x182AB7600", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8200", Offset = "0x2AB6E00", VA = "0x182AB8200")]
		public void PEOFOOEADCA(NativeArray<Entity> FNMNPGEEPJI, bool KGNOBIJBGHH, bool KOOGAHOBCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x2AB77A0", Offset = "0x2AB63A0", VA = "0x182AB77A0")]
		public void IIGPMKNGHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7A40", Offset = "0x2AB6640", VA = "0x182AB7A40")]
		private void OHLHOONAPGB(NativeArray<Entity> FNMNPGEEPJI, bool KGNOBIJBGHH, bool KOOGAHOBCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB79B0", Offset = "0x2AB65B0", VA = "0x182AB79B0")]
		[IteratorStateMachine(typeof(BCOEIMLKHGE))]
		private IEnumerable<JJBGGEMNFLN> JIBHLMACMGI(NativeArray<Entity> FNMNPGEEPJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x2AB7650", Offset = "0x2AB6250", VA = "0x182AB7650", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8370", Offset = "0x2AB6F70", VA = "0x182AB8370")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DefaultMember("Item")]
[DAMCBGMFJNJ(typeof(MGNHPFHGDHE), new string[] { })]
public class IJPNJLNLDOK : MGNHPFHGDHE, IEnumerable<FPHEKKDEPIJ>, IEnumerable, PFBMKGBLLGM, KGABHKADGEM, OHFJHEDBJHF, HMFGCABFMPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[NHBEJKCIJLO]
	private DEPJHLBJFBO HFDCOKODHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Dictionary<(Type, string), int> FPIFFIOCGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private OAOIELOKBKA NAGOBAKMPDH;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFC20", Offset = "0x2AAE820", VA = "0x182AAFC20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public FPHEKKDEPIJ OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFC40", Offset = "0x2AAE840", VA = "0x182AAFC40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public FPHEKKDEPIJ OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AAFC40", Offset = "0x2AAE840", VA = "0x182AAFC40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0040", Offset = "0x2AAEC40", VA = "0x182AB0040", Slot = "11")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2AAFBA0", Offset = "0x2AAE7A0", VA = "0x182AAFBA0", Slot = "12")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "13")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0170", Offset = "0x2AAED70", VA = "0x182AB0170")]
	private void OJNAKICNFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x15318F0", Offset = "0x15304F0", VA = "0x1815318F0")]
	private string LEPHKOOCLOJ(string NLCIGFDKGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0090", Offset = "0x2AAEC90", VA = "0x182AB0090", Slot = "7")]
	public FPHEKKDEPIJ MGLBJDODELB(PMBKKKKDOIF BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2AAFC80", Offset = "0x2AAE880", VA = "0x182AAFC80")]
	private bool IDLBANBJMEM(Type GHGAIHKFDCM, string NLCIGFDKGEE, out FPHEKKDEPIJ LGPKKGCJHDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AAFF30", Offset = "0x2AAEB30", VA = "0x182AAFF30", Slot = "8")]
	public EBLKGKAPHAO IDLNJNJGIMG(PMBKKKKDOIF BBEHMKMODBA)
	{
		return default(EBLKGKAPHAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AAFC60", Offset = "0x2AAE860", VA = "0x182AAFC60", Slot = "9")]
	public IEnumerator<FPHEKKDEPIJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2AAFC60", Offset = "0x2AAE860", VA = "0x182AAFC60", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0410", Offset = "0x2AAF010", VA = "0x182AB0410")]
	public IJPNJLNLDOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
[DefaultMember("Item")]
public interface LAIOJMOLDGG
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHBDMIIAHNA(EBLKGKAPHAO GLGEGPNMJGF, out int LBLAPKMJFKP);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
[DAMCBGMFJNJ(typeof(LAIOJMOLDGG), new string[] { })]
public class BNIKNLOKOJD : OHFJHEDBJHF, HMFGCABFMPC, LAIOJMOLDGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[NHBEJKCIJLO]
	private IPCBIFCIILJ HFDCOKODHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly Dictionary<EBLKGKAPHAO, int> EFBIIFELLEM;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x2F92110", Offset = "0x2F90D10", VA = "0x182F92110", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2F92170", Offset = "0x2F90D70", VA = "0x182F92170", Slot = "6")]
	public bool MHBDMIIAHNA(EBLKGKAPHAO GLGEGPNMJGF, out int LBLAPKMJFKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x2F91E40", Offset = "0x2F90A40", VA = "0x182F91E40", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2F921E0", Offset = "0x2F90DE0", VA = "0x182F921E0", Slot = "5")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2F91EA0", Offset = "0x2F90AA0", VA = "0x182F91EA0")]
	private void DEBEEKKKKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2F921F0", Offset = "0x2F90DF0", VA = "0x182F921F0")]
	public BNIKNLOKOJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DAMCBGMFJNJ(typeof(IPCBIFCIILJ), new string[] { })]
[DefaultMember("Item")]
public class GEEMLFOADIM : IPCBIFCIILJ, IEnumerable<HLBEOPKMMDF>, IEnumerable, PFBMKGBLLGM, KGABHKADGEM, OHFJHEDBJHF, HMFGCABFMPC, CPCNLIBKLCB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[NHBEJKCIJLO]
	private BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[NHBEJKCIJLO]
	private MGNHPFHGDHE LMDAEAFPNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private HLBEOPKMMDF[] AJBAMJLGDLG;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA56B0", Offset = "0x2AA42B0", VA = "0x182AA56B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public HLBEOPKMMDF OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5800", Offset = "0x2AA4400", VA = "0x182AA5800", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public HLBEOPKMMDF OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5800", Offset = "0x2AA4400", VA = "0x182AA5800", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "10")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5410", Offset = "0x2AA4010", VA = "0x182AA5410", Slot = "11")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "12")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AA59F0", Offset = "0x2AA45F0", VA = "0x182AA59F0", Slot = "6")]
	public HLBEOPKMMDF MGLBJDODELB(PMBKKKKDOIF BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5920", Offset = "0x2AA4520", VA = "0x182AA5920", Slot = "7")]
	public EBLKGKAPHAO IDLNJNJGIMG(PMBKKKKDOIF BBEHMKMODBA)
	{
		return default(EBLKGKAPHAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5840", Offset = "0x2AA4440", VA = "0x182AA5840", Slot = "8")]
	public IEnumerator<HLBEOPKMMDF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5B20", Offset = "0x2AA4720", VA = "0x182AA5B20", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x3512F80", Offset = "0x3511B80", VA = "0x183512F80", Slot = "13")]
	public void HKFMGALIEPK<TKey, T>(global::JKHOGOMAANC<TKey, T> GCEENFOFNFL, [Optional] object EDPENIGJGLF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2AA56C0", Offset = "0x2AA42C0", VA = "0x182AA56C0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public GEEMLFOADIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5800", Offset = "0x2AA4400", VA = "0x182AA5800")]
	[CompilerGenerated]
	private HLBEOPKMMDF GAFELCLHBDG(int OJFFKHAMPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[DAMCBGMFJNJ(typeof(OFDPPBHBKCF), new string[] { })]
[DefaultMember("Item")]
public class IDFNOOAOLBK : OFDPPBHBKCF, IEnumerable<HLPDKNGJOIH>, IEnumerable, OHFJHEDBJHF, HMFGCABFMPC, CPCNLIBKLCB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[NHBEJKCIJLO]
	private BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[NHBEJKCIJLO]
	private MGNHPFHGDHE LMDAEAFPNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private HLPDKNGJOIH[] AJBAMJLGDLG;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEDD0", Offset = "0x2AAD9D0", VA = "0x182AAEDD0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public HLPDKNGJOIH OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEEC0", Offset = "0x2AADAC0", VA = "0x182AAEEC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public HLPDKNGJOIH OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AAEEC0", Offset = "0x2AADAC0", VA = "0x182AAEEC0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2AAED60", Offset = "0x2AAD960", VA = "0x182AAED60", Slot = "9")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF2B0", Offset = "0x2AADEB0", VA = "0x182AAF2B0", Slot = "10")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF0B0", Offset = "0x2AADCB0", VA = "0x182AAF0B0")]
	private HLPDKNGJOIH IGJCGELNFAH(int BNNEENLPEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF190", Offset = "0x2AADD90", VA = "0x182AAF190", Slot = "6")]
	public HLPDKNGJOIH MGLBJDODELB(PMBKKKKDOIF BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEFE0", Offset = "0x2AADBE0", VA = "0x182AAEFE0", Slot = "14")]
	public EBLKGKAPHAO IDLNJNJGIMG(PMBKKKKDOIF BBEHMKMODBA)
	{
		return default(EBLKGKAPHAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEED0", Offset = "0x2AADAD0", VA = "0x182AAEED0", Slot = "7")]
	public IEnumerator<HLPDKNGJOIH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEED0", Offset = "0x2AADAD0", VA = "0x182AAEED0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C8A120", Offset = "0x2C88D20", VA = "0x182C8A120", Slot = "11")]
	public void HKFMGALIEPK<TKey, T>(global::JKHOGOMAANC<TKey, T> GCEENFOFNFL, [Optional] object EDPENIGJGLF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEE20", Offset = "0x2AADA20", VA = "0x182AAEE20", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public IDFNOOAOLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEEC0", Offset = "0x2AADAC0", VA = "0x182AAEEC0")]
	[CompilerGenerated]
	private HLPDKNGJOIH GAFELCLHBDG(int OJFFKHAMPMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
[DAMCBGMFJNJ(typeof(DEPJHLBJFBO), new string[] { })]
internal class DEPJHLBJFBO : OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private MGNHPFHGDHE LMDAEAFPNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private OFDPPBHBKCF KHPPIJICGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private IPCBIFCIILJ HJEMENFBIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private global::HAEGCKHPDHM<OCECHDCDPOJ> PJEPJFLNNEJ;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public OAOIELOKBKA OOGGEOPAOID
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67D170", VA = "0x18067E570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x67E590", Offset = "0x67D190", VA = "0x18067E590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3D50", Offset = "0x2FA2950", VA = "0x182FA3D50", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3E80", Offset = "0x2FA2A80", VA = "0x182FA3E80")]
	private void EKNJNMDHOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2304800", Offset = "0x2303400", VA = "0x182304800")]
	public T NELIEDNCPFG<T>() where T : OCECHDCDPOJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4110", Offset = "0x2FA2D10", VA = "0x182FA4110")]
	public FPHEKKDEPIJ IMPKKPDCKII(PMBKKKKDOIF NLCIGFDKGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	public global::HFPFDBLLPPK<T> IMPKKPDCKII<T>(PMBKKKKDOIF NLCIGFDKGEE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3F70", Offset = "0x2FA2B70", VA = "0x182FA3F70")]
	public HLPDKNGJOIH GJNNMCIGLOE(PMBKKKKDOIF NLCIGFDKGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2304780", Offset = "0x2303380", VA = "0x182304780")]
	public global::AMDLBDOEOBO<T> GJNNMCIGLOE<T>(PMBKKKKDOIF NLCIGFDKGEE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4040", Offset = "0x2FA2C40", VA = "0x182FA4040")]
	public HLBEOPKMMDF HMBAJDHNNOJ(PMBKKKKDOIF NLCIGFDKGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	public global::HDDCHEPFNLD<T> HMBAJDHNNOJ<T>(PMBKKKKDOIF NLCIGFDKGEE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public DEPJHLBJFBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal static class GHEKLJIOPOF
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x3520860", Offset = "0x351F460", VA = "0x183520860")]
	public static global::HFPFDBLLPPK<T> IMPKKPDCKII<T>(this DEPJHLBJFBO PEJHFLIFILH, global::GPAKIDKFMKC<T> NLCIGFDKGEE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	public static global::AMDLBDOEOBO<T> GJNNMCIGLOE<T>(this DEPJHLBJFBO PEJHFLIFILH, global::GPAKIDKFMKC<T> NLCIGFDKGEE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	public static global::HDDCHEPFNLD<T> HMBAJDHNNOJ<T>(this DEPJHLBJFBO PEJHFLIFILH, global::GPAKIDKFMKC<T> NLCIGFDKGEE) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
[DAMCBGMFJNJ(typeof(BGADPEKHCND), new string[] { })]
public class BGADPEKHCND : OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private NHMIEEEHOBN LPFIHLDFGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private EBLKGKAPHAO[] NHLMGHAKIHE;

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2F910F0", Offset = "0x2F8FCF0", VA = "0x182F910F0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2F91380", Offset = "0x2F8FF80", VA = "0x182F91380")]
	public void BHKJAPMCHOA(ELJHNEOGEBP FFJHOAAMJMD, bool ODDBKPJIGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public BGADPEKHCND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[DAMCBGMFJNJ(typeof(OKAGLPNHEMM), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
public sealed class OKAGLPNHEMM : OHFJHEDBJHF, HMFGCABFMPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class BBOEPELNAEJ : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E8010", VA = "0x1808E9410")]
		[DebuggerHidden]
		public BBOEPELNAEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2CA0", Offset = "0x3DD18A0", VA = "0x183DD2CA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x3DD28F0", Offset = "0x3DD14F0", VA = "0x183DD28F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2D20", Offset = "0x3DD1920", VA = "0x183DD2D20")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2C60", Offset = "0x3DD1860", VA = "0x183DD2C60", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2BD0", Offset = "0x3DD17D0", VA = "0x183DD2BD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x3DD2BD0", Offset = "0x3DD17D0", VA = "0x183DD2BD0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private const string HAAEIKEGBCA = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<SerializableGuid, BAIPPHODGCI> MFJMBAIFIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly List<SerializableGuid> JELPHBNEACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly Dictionary<SerializableGuid, GameObject> DEBJMFLLNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private OFDPPBHBKCF HFDCOKODHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private MCFPIPCNFDN KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private IODHNFLDMAC PFNEAPNCEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private DKCCOABIFKH PDOJIOEBHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private global::EDNHLHPJOPH<BAIPPHODGCI> KMDHECOGMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GameObject KKOIKCPGLEA;

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2A80950", Offset = "0x2A7F550", VA = "0x182A80950", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2A81D60", Offset = "0x2A80960", VA = "0x182A81D60", Slot = "5")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2A80C10", Offset = "0x2A7F810", VA = "0x182A80C10", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2A80C00", Offset = "0x2A7F800", VA = "0x182A80C00")]
	private void CICFDDJNPAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2A814B0", Offset = "0x2A800B0", VA = "0x182A814B0")]
	internal void MIIMFHAHDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2A812D0", Offset = "0x2A7FED0", VA = "0x182A812D0")]
	private void KNFEKOLAFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2A81FE0", Offset = "0x2A80BE0", VA = "0x182A81FE0")]
	private void PMPIPBFFDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2A81F90", Offset = "0x2A80B90", VA = "0x182A81F90")]
	[IteratorStateMachine(typeof(BBOEPELNAEJ))]
	private IEnumerable<RRCustomPropTag> OLLJFDGNMNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2A818E0", Offset = "0x2A804E0", VA = "0x182A818E0")]
	private void NCMMJFLKDFO(IOBECAADPPL DKHOCCDNDOH, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2A80DB0", Offset = "0x2A7F9B0", VA = "0x182A80DB0")]
	private void EHMHLLLMBAF(SerializableGuid LNKDDEDGKJH, GameObject ENOCMPCACJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2A80EF0", Offset = "0x2A7FAF0", VA = "0x182A80EF0")]
	private void EMDHGCOFPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2A80A20", Offset = "0x2A7F620", VA = "0x182A80A20")]
	private bool BELFMLFLDCK(BAIPPHODGCI HOBODMININO, Transform GEOFAMNLJNK, out GameObject CFBIOKMMOEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2A81280", Offset = "0x2A7FE80", VA = "0x182A81280")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x2A820E0", Offset = "0x2A80CE0", VA = "0x182A820E0")]
	public OKAGLPNHEMM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public SerializableGuid DLLHABIGPLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696C40", VA = "0x180698040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B6D0", Offset = "0x2A9A2D0", VA = "0x182A9B6D0")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xF03490", Offset = "0xF02090", VA = "0x180F03490")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DAMCBGMFJNJ(typeof(HONCFGDAIDN), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
public class HONCFGDAIDN : OHFJHEDBJHF
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const string FDAHKCLIGAO = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private SceneService HMMCBLIILHF;

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC390", Offset = "0x2AAAF90", VA = "0x182AAC390", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public HONCFGDAIDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
[DAMCBGMFJNJ(typeof(OLKKPOIPKPL), new string[] { })]
public class OLKKPOIPKPL : OHFJHEDBJHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[NHBEJKCIJLO]
	private EnableComponentSystemsInScope IIFEHDBBHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[NHBEJKCIJLO]
	private SceneService HMMCBLIILHF;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2A825D0", Offset = "0x2A811D0", VA = "0x182A825D0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2A82660", Offset = "0x2A81260", VA = "0x182A82660", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2A82640", Offset = "0x2A81240", VA = "0x182A82640")]
	private void AHMBPFMCKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2A826A0", Offset = "0x2A812A0", VA = "0x182A826A0")]
	private void PGMEIKNKPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public OLKKPOIPKPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DAMCBGMFJNJ(typeof(LHNBKEDDAHF), new string[] { })]
public class PONONOEFDGG : OHFJHEDBJHF, HMFGCABFMPC, LHNBKEDDAHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private NDJGAFFBPCH JFKPFEJELNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private MOGGBLMAIPP LJIHPFNNPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private PropertyEventCallbacksService PDAOAKHGMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private LocalPlayerScopeSystem EECDNOGLDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private int MMGEFEDJDAL;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool NBJDJJDGLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x2A92B20", Offset = "0x2A91720", VA = "0x182A92B20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public IOBECAADPPL NOLFCLJOHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x2A92FC0", Offset = "0x2A91BC0", VA = "0x182A92FC0", Slot = "9")]
		get
		{
			return default(IOBECAADPPL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x2A927E0", Offset = "0x2A913E0", VA = "0x182A927E0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public MFPKOBHCDLK NCMKIIJCJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x2A92E10", Offset = "0x2A91A10", VA = "0x182A92E10", Slot = "11")]
		get
		{
			return default(MFPKOBHCDLK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x2A927E0", Offset = "0x2A913E0", VA = "0x182A927E0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public MFPKOBHCDLK NPDGGDGFOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x2A93000", Offset = "0x2A91C00", VA = "0x182A93000", Slot = "13")]
		get
		{
			return default(MFPKOBHCDLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private uint INHCCLJBHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2A92930", Offset = "0x2A91530", VA = "0x182A92930")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event ODEMOPJLFII PGNCABCBGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x2A929E0", Offset = "0x2A915E0", VA = "0x182A929E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x2A92D70", Offset = "0x2A91970", VA = "0x182A92D70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x2A92380", Offset = "0x2A90F80", VA = "0x182A92380", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2A93050", Offset = "0x2A91C50", VA = "0x182A93050", Slot = "5")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x2A92880", Offset = "0x2A91480", VA = "0x182A92880", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2A92450", Offset = "0x2A91050", VA = "0x182A92450")]
	private void BIPCIHPAKNF(Entity LLEBIIAHFDD, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG KNAEAKFNOOB, EKBGHCIKEGG OCBHJKLFMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2A92C60", Offset = "0x2A91860", VA = "0x182A92C60", Slot = "14")]
	public IOBECAADPPL KIGGLEINDHC(IOBECAADPPL ADDDKDIDHPJ, IOBECAADPPL LCEKCMGAGEI)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2A92B60", Offset = "0x2A91760", VA = "0x182A92B60", Slot = "15")]
	public bool KCBAGPAHKEE(IOBECAADPPL ADDDKDIDHPJ, IOBECAADPPL LCEKCMGAGEI, out IOBECAADPPL BKMGHCEAABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2A92650", Offset = "0x2A91250", VA = "0x182A92650", Slot = "16")]
	public void BMCHDMKDJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2A92A80", Offset = "0x2A91680", VA = "0x182A92A80", Slot = "17")]
	public void JFJAEFAGCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2A92E60", Offset = "0x2A91A60", VA = "0x182A92E60", Slot = "18")]
	public bool LPFNGDNALNE(IOBECAADPPL EHPFANFOFFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2A927E0", Offset = "0x2A913E0", VA = "0x182A927E0")]
	private void LCGKJPGHBCP(IOBECAADPPL GKKANKKOLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public PONONOEFDGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DAMCBGMFJNJ(typeof(IAEAFPAPBEN), new string[] { })]
public class LMBNKDBCPPA : OHFJHEDBJHF, IAEAFPAPBEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private EntityManager CLLNDNAAIKP;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC8A0", Offset = "0x2ABB4A0", VA = "0x182ABC8A0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC920", Offset = "0x2ABB520", VA = "0x182ABC920", Slot = "5")]
	public void DOLNBNBMHOO(IOBECAADPPL IBGBBCHPJJF, bool GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x29FED50", Offset = "0x29FD950", VA = "0x1829FED50")]
	private void NMFBOCJEJOB<T>(IOBECAADPPL IBGBBCHPJJF, bool GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public LMBNKDBCPPA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[DAMCBGMFJNJ(typeof(NFJLHIJFPAP), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.RenderEffects)]
	public class SelectionService : OHFJHEDBJHF, NFJLHIJFPAP
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private EntityManager CLLNDNAAIKP;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7EE70", Offset = "0x2D7DA70", VA = "0x182D7EE70", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2D7EEF0", Offset = "0x2D7DAF0", VA = "0x182D7EEF0", Slot = "5")]
		public void KDGKHGHGKPP(IOBECAADPPL IBGBBCHPJJF, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2D7EF60", Offset = "0x2D7DB60", VA = "0x182D7EF60", Slot = "6")]
		public void NCPHKIFGEGI(IOBECAADPPL IBGBBCHPJJF, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x29FED50", Offset = "0x29FD950", VA = "0x1829FED50")]
		private void NMFBOCJEJOB<T>(IOBECAADPPL IBGBBCHPJJF, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
[DAMCBGMFJNJ(typeof(IOECMAHAPJE), new string[] { })]
internal sealed class IOECMAHAPJE : OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[NHBEJKCIJLO]
	private ObjectEmbodimentService DPCGPJIEFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[NHBEJKCIJLO]
	private EEHCKCIAPAN KJEBDBMGNJF;

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0D00", Offset = "0x2AAF900", VA = "0x182AB0D00", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public IOECMAHAPJE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[HFIGNCEGOKM(DDEOJCINOPG.Serialization)]
	[DAMCBGMFJNJ(typeof(WorldSerialization), new string[] { })]
	[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
	internal sealed class WorldSerialization : OHFJHEDBJHF, HMGGJADOIMB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly FNIDFMEJGMB DFMIEEBHCKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[NHBEJKCIJLO]
		private HMCNJNGCNFE JPDFIACDDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[NHBEJKCIJLO]
		private MCFPIPCNFDN KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[NHBEJKCIJLO]
		private SerializationService PFNEAPNCEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[NHBEJKCIJLO]
		private CGLBCJNHGCM NEDADCIFNEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[NHBEJKCIJLO]
		private DebugWorldsService GCCDLKPFKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[NHBEJKCIJLO]
		private BulkInstantiateSceneObjectService PLLGCLFMJIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private PGEEJALGCGE HFDOFHJBJGD;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private AKBOANNKIFN ODPABGFJECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0xCF6300", Offset = "0xCF4F00", VA = "0x180CF6300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2D92F40", Offset = "0x2D91B40", VA = "0x182D92F40", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE BPEEICHBHFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x2D93180", Offset = "0x2D91D80", VA = "0x182D93180", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x2D93EC0", Offset = "0x2D92AC0", VA = "0x182D93EC0", Slot = "6")]
		public bool NCNCMKKFBNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x2D93160", Offset = "0x2D91D60", VA = "0x182D93160", Slot = "7")]
		public bool BDGPCLMJPHE(IEnumerable<KPBHHJNMPGI> JNPPLACLHGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x2D93250", Offset = "0x2D91E50", VA = "0x182D93250", Slot = "5")]
		public ByteString JNACBIDAHJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x2D93EA0", Offset = "0x2D92AA0", VA = "0x182D93EA0")]
		private void MFKLNAEKLBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x2D93090", Offset = "0x2D91C90", VA = "0x182D93090")]
		private void AGMNDHPCCIP(NELJHPCAMDK BOOMEIJCBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x2D936E0", Offset = "0x2D922E0", VA = "0x182D936E0")]
		private void KDKFFIPLDGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x2D93BC0", Offset = "0x2D927C0", VA = "0x182D93BC0")]
		private void LKCDIBPGJNN(PFFOAGAAAPP BOOMEIJCBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x2D94020", Offset = "0x2D92C20", VA = "0x182D94020", Slot = "8")]
		public void NHJFFFEKKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x2D931B0", Offset = "0x2D91DB0", VA = "0x182D931B0")]
		private NELJHPCAMDK GNIAGPDBDGL(EntityManager LPIKKOEGLIJ, EntityManager DKNGLDMHBMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DAMCBGMFJNJ(typeof(HLDEMOEEODE), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
public class HLDEMOEEODE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly Dictionary<CKLKKHOPBLL, string> FHBFFNJLJMA;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2AABF90", Offset = "0x2AAAB90", VA = "0x182AABF90")]
	public GameObject LAJDCFAJJAK(CKLKKHOPBLL DIKOGDNLGKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2AAC060", Offset = "0x2AAAC60", VA = "0x182AAC060")]
	public HLDEMOEEODE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	[DAMCBGMFJNJ(typeof(TimeService), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	public class TimeService : KGABHKADGEM, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[NHBEJKCIJLO]
		private SingletonComponentService DFENKOICECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private bool AJBJGEOLFEM;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public TimeData EKJKODFECND
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x2D867D0", Offset = "0x2D853D0", VA = "0x182D867D0")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x2D86900", Offset = "0x2D85500", VA = "0x182D86900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool JDAAPCPMLFI
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6904D0", VA = "0x1806918D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x6B3000", Offset = "0x6B1C00", VA = "0x1806B3000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1325FE0", Offset = "0x1324BE0", VA = "0x181325FE0", Slot = "4")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x2D86780", Offset = "0x2D85380", VA = "0x182D86780", Slot = "5")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2D86840", Offset = "0x2D85440", VA = "0x182D86840")]
		public void CLMACCGHNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[HFIGNCEGOKM(DDEOJCINOPG.TransformSyncing)]
	[DAMCBGMFJNJ(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
	internal class SetTransformParentIfParentPropertyChanges : OHFJHEDBJHF, HMFGCABFMPC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private JOBGNDCAMAM KKELBBDIJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private global::HFPFDBLLPPK<Entity> GEOFAMNLJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private ObjectEmbodimentService MNJGLAAEFPK;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2D82900", Offset = "0x2D81500", VA = "0x182D82900", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2D82B50", Offset = "0x2D81750", VA = "0x182D82B50", Slot = "5")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2D82AB0", Offset = "0x2D816B0", VA = "0x182D82AB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2D82970", Offset = "0x2D81570", VA = "0x182D82970")]
		private void CBOOHBGEHAF(Entity LLEBIIAHFDD, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[HFIGNCEGOKM(DDEOJCINOPG.Services)]
	[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
	[DAMCBGMFJNJ(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	public class EnableTransmissionOnlyInLoadInstance : OHFJHEDBJHF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[NHBEJKCIJLO]
		private GPFDLOIJJBP DHOJGMOHHOC;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private IEBENGHHJMI JCGCNPECBNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x2A9FF30", Offset = "0x2A9EB30", VA = "0x182A9FF30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private BFLEMBEOHEL FHKHMHKBKBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x2A9FFA0", Offset = "0x2A9EBA0", VA = "0x182A9FFA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FEB0", Offset = "0x2A9EAB0", VA = "0x182A9FEB0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2A9FF80", Offset = "0x2A9EB80", VA = "0x182A9FF80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
[DAMCBGMFJNJ(typeof(PGKNIBKAJKB), new string[] { })]
public class PGKNIBKAJKB : OIAIMMLKKAN, PFBMKGBLLGM, KGABHKADGEM, OHFJHEDBJHF, HMFGCABFMPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class BGPJNKFENHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public PGEEJALGCGE services;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public BGPJNKFENHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3800", Offset = "0x3DD2400", VA = "0x183DD3800")]
		internal void <InitReferences>b__0(OHFJHEDBJHF svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class ALCLLINFNDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public PGEEJALGCGE services;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public ALCLLINFNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD27B0", Offset = "0x3DD13B0", VA = "0x183DD27B0")]
		internal void <InitExternal>b__0(HMFGCABFMPC svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	[NHBEJKCIJLO]
	private EEHCKCIAPAN KJEBDBMGNJF;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public AHPBGKKBONO FBGBCINBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x8C84C0", Offset = "0x8C70C0", VA = "0x1808C84C0", Slot = "4")]
		get
		{
			return default(AHPBGKKBONO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private LGIKDIEECOD IAMBCCOEDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F7B0", Offset = "0x2A8E3B0", VA = "0x182A8F7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F680", Offset = "0x2A8E280", VA = "0x182A8F680", Slot = "5")]
	public void LHCOLCBEPCK(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F550", Offset = "0x2A8E150", VA = "0x182A8F550", Slot = "6")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F340", Offset = "0x2A8DF40", VA = "0x182A8F340", Slot = "7")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F6D0", Offset = "0x2A8E2D0", VA = "0x182A8F6D0", Slot = "8")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F420", Offset = "0x2A8E020", VA = "0x182A8F420", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x313B7A0", Offset = "0x313A3A0", VA = "0x18313B7A0")]
	private void FGFALEOFPOP<T>(Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public PGKNIBKAJKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class IINCABDFHEJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly Func<From, To> IEPBJFBIJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly Func<To, From> FGIDPBOLFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public DynamicBuffer<From> NFMJIELOGNG;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public To OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	public IINCABDFHEJ(Func<From, To> IEPBJFBIJCM, Func<To, From> FGIDPBOLFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To MPIBAJOJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int BNNEENLPEFO, To MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[DefaultMember("Item")]
public class HLDFHJMCCJJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly Func<From, To> IEPBJFBIJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly Func<To, From> FGIDPBOLFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public List<From> LENGKEKMOEB;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB0B0", Offset = "0x2BB9CB0", VA = "0x182BBB0B0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB110", Offset = "0x2BB9D10", VA = "0x182BBB110", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB080", Offset = "0x2BB9C80", VA = "0x182BBB080", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766B80", VA = "0x180767F80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x731170", Offset = "0x72FD70", VA = "0x180731170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAFF0", Offset = "0x2BB9BF0", VA = "0x182BBAFF0")]
	public HLDFHJMCCJJ(Func<From, To> IEPBJFBIJCM, Func<To, From> FGIDPBOLFPN, bool PHLJIIECGMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAC10", Offset = "0x2BB9810", VA = "0x182BBAC10", Slot = "11")]
	public void Add(To MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x28963B0", Offset = "0x2894FB0", VA = "0x1828963B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAC70", Offset = "0x2BB9870", VA = "0x182BBAC70", Slot = "13")]
	public bool Contains(To MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2BBACD0", Offset = "0x2BB98D0", VA = "0x182BBACD0", Slot = "14")]
	public void CopyTo(To[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2BBADE0", Offset = "0x2BB99E0", VA = "0x182BBADE0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAE50", Offset = "0x2BB9A50", VA = "0x182BBAE50", Slot = "6")]
	public int IndexOf(To MPIBAJOJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAEB0", Offset = "0x2BB9AB0", VA = "0x182BBAEB0", Slot = "7")]
	public void Insert(int BNNEENLPEFO, To MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAF60", Offset = "0x2BB9B60", VA = "0x182BBAF60", Slot = "15")]
	public bool Remove(To MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAF30", Offset = "0x2BB9B30", VA = "0x182BBAF30", Slot = "8")]
	public void RemoveAt(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAFC0", Offset = "0x2BB9BC0", VA = "0x182BBAFC0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DefaultMember("Item")]
public class BCGHODBJJMC<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private readonly Func<From, To> IEPBJFBIJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Func<To, From> FGIDPBOLFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeArray<From> EJLDCNGHIAK;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x528A130", Offset = "0x5288D30", VA = "0x18528A130", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x528A180", Offset = "0x5288D80", VA = "0x18528A180", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x528A0F0", Offset = "0x5288CF0", VA = "0x18528A0F0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x698020", Offset = "0x696C20", VA = "0x180698020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x250A8D0", Offset = "0x25094D0", VA = "0x18250A8D0")]
	public BCGHODBJJMC(Func<From, To> IEPBJFBIJCM, Func<To, From> FGIDPBOLFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x5289D00", Offset = "0x5288900", VA = "0x185289D00", Slot = "11")]
	public void Add(To MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x5289D40", Offset = "0x5288940", VA = "0x185289D40", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x5289D80", Offset = "0x5288980", VA = "0x185289D80", Slot = "13")]
	public bool Contains(To MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x5289E40", Offset = "0x5288A40", VA = "0x185289E40", Slot = "14")]
	public void CopyTo(To[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x5289F00", Offset = "0x5288B00", VA = "0x185289F00", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x5289FC0", Offset = "0x5288BC0", VA = "0x185289FC0", Slot = "6")]
	public int IndexOf(To MPIBAJOJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x528A030", Offset = "0x5288C30", VA = "0x18528A030", Slot = "7")]
	public void Insert(int BNNEENLPEFO, To MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x528A0B0", Offset = "0x5288CB0", VA = "0x18528A0B0", Slot = "15")]
	public bool Remove(To MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x528A070", Offset = "0x5288C70", VA = "0x18528A070", Slot = "8")]
	public void RemoveAt(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x200C710", Offset = "0x200B310", VA = "0x18200C710", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class ECGACHKMMIG<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly Func<From, To> IEPBJFBIJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly Func<To, From> FGIDPBOLFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeList<From> LENGKEKMOEB;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	public ECGACHKMMIG(Func<From, To> IEPBJFBIJCM, Func<To, From> FGIDPBOLFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To MPIBAJOJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int BNNEENLPEFO, To MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class GBJJHLKFFFB
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public const string DOAEPMPFOPA = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public const string ADDCJGEOAPB = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public const string FJKHIFAOALP = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public const string GJMJCFCCCPH = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public const string LIKFKGDIDAJ = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public const string DNMHANDBNED = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public const string FNEPNJINLBH = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public const string NJIIGOAOOLF = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class OLPFEJBBEOI
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class COFHODGBHBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public PGEEJALGCGE services;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public COFHODGBHBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4750", Offset = "0x3DD3350", VA = "0x183DD4750")]
		internal void <InitServices>b__1(OHFJHEDBJHF svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x3DD47B0", Offset = "0x3DD33B0", VA = "0x183DD47B0")]
		internal void <InitServices>b__2(HMFGCABFMPC svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A826D0", Offset = "0x2A812D0", VA = "0x182A826D0")]
	public static void BPDPGKDLBFA(this LGIKDIEECOD AEEDEJIEEFL, PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x2B638E0", Offset = "0x2B624E0", VA = "0x182B638E0")]
	public static void FGFALEOFPOP<T>(this LGIKDIEECOD AEEDEJIEEFL, Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x2B63AC0", Offset = "0x2B626C0", VA = "0x182B63AC0")]
	public static void FOGIIIFGBON<T>(this LGIKDIEECOD AEEDEJIEEFL, Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x2B63730", Offset = "0x2B62330", VA = "0x182B63730")]
	public static void ENPNFKMAPMB<T>(this LGIKDIEECOD AEEDEJIEEFL, Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x2B63C60", Offset = "0x2B62860", VA = "0x182B63C60")]
	public static void KMALHHPAIDH<T>(this LGIKDIEECOD AEEDEJIEEFL, Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B634C0", Offset = "0x2B620C0", VA = "0x182B634C0")]
	public static void DPHDIMAJMNN<T>(this LGIKDIEECOD AEEDEJIEEFL, Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x2B63950", Offset = "0x2B62550", VA = "0x182B63950")]
	public static void FOGIIIFGBON<T>(IEnumerable<ComponentSystemBase> PCMOOAJDLNB, Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B63670", Offset = "0x2B62270", VA = "0x182B63670")]
	private static void EMIDKNMPKFL<T>(object AKNBNHOMNEL, Action<T> OFCBPHMKBKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class IMLFBHOCLNK
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class OKDPJANCNJC
{
	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A821E0", Offset = "0x2A80DE0", VA = "0x182A821E0")]
	public static void IEBDNGOPLPJ(ComponentSystemBase AKNBNHOMNEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class CEJEGEKJPLF
{
	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	public static bool IAAAGEFBFAH<T>(ref T LEOEMBMBFBC, ref T GHDGKPNPOBN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class NMGEAJFOOFF
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class BCOCIADIPHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public BCOCIADIPHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D5C0", Offset = "0x2A7C1C0", VA = "0x182A7D5C0")]
	public static string FLGHDIGMFJK(Transform KAMDPLLJPAH, Transform EHPFANFOFFJ)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[HFIGNCEGOKM(DDEOJCINOPG.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D81890", Offset = "0x2D80490", VA = "0x182D81890")]
		public static void FEOLDJENCJJ(this FEGPLAEFMOI HFDOFHJBJGD, IMFOEJGFLNN MBNFLPKEEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x2D81D70", Offset = "0x2D80970", VA = "0x182D81D70")]
		public static void KJFDBPJDEPG(this FEGPLAEFMOI HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x2D81780", Offset = "0x2D80380", VA = "0x182D81780")]
		public static void FEOLDJENCJJ(this FEGPLAEFMOI HFDOFHJBJGD, [Optional] string[] PNEAJOPIFPI, [Optional] string[] PDJFKHNHEFB, [Optional] string[] JNCKALKDEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x2D816D0", Offset = "0x2D802D0", VA = "0x182D816D0")]
		public static void CNKFCAGBKOA(this FEGPLAEFMOI HFDOFHJBJGD, params string[] PLHBKKLFOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2D81CC0", Offset = "0x2D808C0", VA = "0x182D81CC0")]
		public static void GOMEEFOMFLH(this FEGPLAEFMOI HFDOFHJBJGD, params string[] PLHBKKLFOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2D81AC0", Offset = "0x2D806C0", VA = "0x182D81AC0")]
		private static string[] GGAHOKMODLC(IMFOEJGFLNN MBNFLPKEEGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2D81E70", Offset = "0x2D80A70", VA = "0x182D81E70")]
		private static bool PJCHMCAOPKA(IMFOEJGFLNN MBNFLPKEEGH, out string[] GNLGCLEFBLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679900", VA = "0x18067AD00")]
		private static bool EIGCPOLBHKK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public abstract class AMFKNHKJGHK : HALLEIJLOEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly MethodInfo JKEHHBOBJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly Type[] MAGEMABOILP;

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D6C0", Offset = "0x2F8C2C0", VA = "0x182F8D6C0")]
	public AMFKNHKJGHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action BCFDAENEDAF();

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D680", Offset = "0x2F8C280", VA = "0x182F8D680")]
	public MethodInfo MPKCHGILMNM(Action KDJGJCHCIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D4D0", Offset = "0x2F8C0D0", VA = "0x182F8D4D0", Slot = "4")]
	public void EHMHLLLMBAF(Type BIEGICDMJCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public abstract class PMEJJIODGLK : AMFKNHKJGHK
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private enum ODIAGAGGPLC
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A92040", Offset = "0x2A90C40", VA = "0x182A92040", Slot = "5")]
	public override Action BCFDAENEDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void ICHOEHPKEKD<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A920D0", Offset = "0x2A90CD0", VA = "0x182A920D0")]
	[Preserve]
	public void CIKOLKINFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F330", Offset = "0x2A8DF30", VA = "0x182A8F330")]
	protected PMEJJIODGLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class PCOCNCIFCPC : AMFKNHKJGHK
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F210", Offset = "0x2A8DE10", VA = "0x182A8F210", Slot = "5")]
	public override Action BCFDAENEDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void IPCCAACDKCF<T>() where T : HHCBFJCPHFB;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F2A0", Offset = "0x2A8DEA0", VA = "0x182A8F2A0")]
	[Preserve]
	public void CIKOLKINFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F330", Offset = "0x2A8DF30", VA = "0x182A8F330")]
	protected PCOCNCIFCPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class JNLOEDNAGBO : AMFKNHKJGHK
{
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x2AB33F0", Offset = "0x2AB1FF0", VA = "0x182AB33F0", Slot = "5")]
	public override Action BCFDAENEDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void KJGAMEJBJMC<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3480", Offset = "0x2AB2080", VA = "0x182AB3480")]
	[Preserve]
	public void CIKOLKINFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F330", Offset = "0x2A8DF30", VA = "0x182A8F330")]
	protected JNLOEDNAGBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class AOJMMEPIBDL
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E410", Offset = "0x2F8D010", VA = "0x182F8E410")]
	public static Entity ANEGFLHBEHC(this EntityManager CLLNDNAAIKP)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[HFIGNCEGOKM(DDEOJCINOPG.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class ECKGDLBNKAM : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.Token(Token = "0x170000CC")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600060C")]
				[Cpp2IlInjected.Address(RVA = "0x11924F0", Offset = "0x11910F0", VA = "0x1811924F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CD")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600060E")]
				[Cpp2IlInjected.Address(RVA = "0x3DD65B0", Offset = "0x3DD51B0", VA = "0x183DD65B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4310", Offset = "0x3DD2F10", VA = "0x183DD4310")]
			[DebuggerHidden]
			public ECKGDLBNKAM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x3DD63E0", Offset = "0x3DD4FE0", VA = "0x183DD63E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x3DD6570", Offset = "0x3DD5170", VA = "0x183DD6570", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x3DD64C0", Offset = "0x3DD50C0", VA = "0x183DD64C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x3DD64C0", Offset = "0x3DD50C0", VA = "0x183DD64C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class CNPNNKINJJG : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000204")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private IEnumerator<Entity> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000615")]
				[Cpp2IlInjected.Address(RVA = "0x11924F0", Offset = "0x11910F0", VA = "0x1811924F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000617")]
				[Cpp2IlInjected.Address(RVA = "0x3DD4620", Offset = "0x3DD3220", VA = "0x183DD4620", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4310", Offset = "0x3DD2F10", VA = "0x183DD4310")]
			[DebuggerHidden]
			public CNPNNKINJJG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4670", Offset = "0x3DD3270", VA = "0x183DD4670", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4340", Offset = "0x3DD2F40", VA = "0x183DD4340", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4700", Offset = "0x3DD3300", VA = "0x183DD4700")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x3DD45E0", Offset = "0x3DD31E0", VA = "0x183DD45E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4530", Offset = "0x3DD3130", VA = "0x183DD4530", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4530", Offset = "0x3DD3130", VA = "0x183DD4530", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class CNLHHAHEDHN : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private ChildrenData <childData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private IEnumerator<Entity> <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600061F")]
				[Cpp2IlInjected.Address(RVA = "0x11924F0", Offset = "0x11910F0", VA = "0x1811924F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000621")]
				[Cpp2IlInjected.Address(RVA = "0x3DD4150", Offset = "0x3DD2D50", VA = "0x183DD4150", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4310", Offset = "0x3DD2F10", VA = "0x183DD4310")]
			[DebuggerHidden]
			public CNLHHAHEDHN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x3DD41A0", Offset = "0x3DD2DA0", VA = "0x183DD41A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x3DD3D40", Offset = "0x3DD2940", VA = "0x183DD3D40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4270", Offset = "0x3DD2E70", VA = "0x183DD4270")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x3DD42C0", Offset = "0x3DD2EC0", VA = "0x183DD42C0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4110", Offset = "0x3DD2D10", VA = "0x183DD4110", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4070", Offset = "0x3DD2C70", VA = "0x183DD4070", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4070", Offset = "0x3DD2C70", VA = "0x183DD4070", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA35B0", Offset = "0x2AA21B0", VA = "0x182AA35B0")]
		public static Entity MJGKPNPKLCE(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2310", Offset = "0x2AA0F10", VA = "0x182AA2310")]
		public static DynamicBuffer<ChildrenData> ABAMDIJGCIG(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2B80", Offset = "0x2AA1780", VA = "0x182AA2B80")]
		public static DynamicBuffer<ChildrenData> FEDHOEGKNBM(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA25B0", Offset = "0x2AA11B0", VA = "0x182AA25B0")]
		public static NativeArray<Entity> BACADGPIJEL(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Allocator PBEDBDBGIPF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3200", Offset = "0x2AA1E00", VA = "0x182AA3200")]
		public static bool KDDEMFMDCBI(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Allocator PBEDBDBGIPF, out NativeArray<Entity> IIGJIFCGHIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA27C0", Offset = "0x2AA13C0", VA = "0x182AA27C0")]
		public static NativeArray<Entity> CELHEPNBKPM(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3620", Offset = "0x2AA2220", VA = "0x182AA3620")]
		public static Entity MMFPKICCFCA(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, int BNNEENLPEFO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA39C0", Offset = "0x2AA25C0", VA = "0x182AA39C0")]
		public static int PEOBNLMKOKI(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2920", Offset = "0x2AA1520", VA = "0x182AA2920")]
		public static void COHBCADGNJA(NativeArray<Entity> MCPLHLPJDOB, NativeArray<Entity> KPOBDKLHLOL, EntityManager CLLNDNAAIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3500", Offset = "0x2AA2100", VA = "0x182AA3500")]
		public static int MGMJAGBJING(this EntityManager CLLNDNAAIKP, Entity GEOFAMNLJNK, Entity DBNJJKLOCGM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3750", Offset = "0x2AA2350", VA = "0x182AA3750")]
		public static bool NLDBNJEFDEH(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Entity NMJJIOLIMGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA38B0", Offset = "0x2AA24B0", VA = "0x182AA38B0")]
		public static IEnumerable<Entity> OEGOHCELJAI(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, bool HOJIMILIDNA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2D90", Offset = "0x2AA1990", VA = "0x182AA2D90")]
		public static bool HDGJJPALPML(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Entity DBNJJKLOCGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3AD0", Offset = "0x2AA26D0", VA = "0x182AA3AD0")]
		public static bool PGPKCLNGJPJ(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Entity ADDDKDIDHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA23A0", Offset = "0x2AA0FA0", VA = "0x182AA23A0")]
		public static NativeList<Entity> AILKEPHEJLI(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, bool HOJIMILIDNA = false, Allocator PBEDBDBGIPF = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3300", Offset = "0x2AA1F00", VA = "0x182AA3300")]
		public static IEnumerable<Entity> LBLBJIKOPHN(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, bool HOJIMILIDNA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2ED0", Offset = "0x2AA1AD0", VA = "0x182AA2ED0")]
		public static Entity IENNNAFGFNJ(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3060", Offset = "0x2AA1C60", VA = "0x182AA3060")]
		public static bool KCBAGPAHKEE(this EntityManager CLLNDNAAIKP, Entity ADDDKDIDHPJ, Entity LCEKCMGAGEI, out Entity BKMGHCEAABD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2C10", Offset = "0x2AA1810", VA = "0x182AA2C10")]
		internal static void GBACKPGELDL(EntityManager CLLNDNAAIKP, Entity GEOFAMNLJNK, Entity DBNJJKLOCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2C90", Offset = "0x2AA1890", VA = "0x182AA2C90")]
		internal static void HAHFHBOCMOM(EntityManager CLLNDNAAIKP, Entity GEOFAMNLJNK, Entity DBNJJKLOCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2FD0", Offset = "0x2AA1BD0", VA = "0x182AA2FD0")]
		[IteratorStateMachine(typeof(ECKGDLBNKAM))]
		private static IEnumerable<Entity> IHPILBHEOLI(EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, bool HOJIMILIDNA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2E40", Offset = "0x2AA1A40", VA = "0x182AA2E40")]
		[IteratorStateMachine(typeof(CNPNNKINJJG))]
		private static IEnumerable<Entity> HNIIBFAMBCH(EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, bool HOJIMILIDNA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3480", Offset = "0x2AA2080", VA = "0x182AA3480")]
		[IteratorStateMachine(typeof(CNLHHAHEDHN))]
		private static IEnumerable<Entity> LLOLGACPBAH(EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x2AA26E0", Offset = "0x2AA12E0", VA = "0x182AA26E0")]
		private static bool BPKGBFLMJDJ(EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Entity NMJJIOLIMGA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[DAMCBGMFJNJ(typeof(HFBJLIMBJCJ), new string[] { })]
public class AJINGDKPJEE : HFBJLIMBJCJ, OIAIMMLKKAN, BFHAHCPNLAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private PGEEJALGCGE HFDOFHJBJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private MCFPIPCNFDN KNPPOFLONHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private HMCNJNGCNFE JPDFIACDDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private CKDAIJCFICL NBPHCOAFDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private NDJGAFFBPCH JFKPFEJELNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private JOBGNDCAMAM KKELBBDIJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private LJHKOFPCONB PFNEAPNCEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private HBEDANEOEFD PCJNBNNIDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private OFDPPBHBKCF HFDCOKODHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private CPPNPEKOALL NJDOHHKIJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private BGOAEBFPKAN NMHJBMPNNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private LHNBKEDDAHF OBKGOOLKCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private CGEDEAJAIJO LAGIBNJDAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private ILOELKJEBPE CDJJPOJICIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private IAEAFPAPBEN HIODAMNALPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private NFJLHIJFPAP BKHKGKEOGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private NMCFLAICADE JJCPEBDMNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private EKMBBEOBHCH CIKFHEBMKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private PEGFCDNOKHB JKDGBJKFGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public PGEEJALGCGE LDOEMEGKBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public MCFPIPCNFDN JHMDIDKKOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public EEHCKCIAPAN IAMBCCOEDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public HMCNJNGCNFE EDMMPBCKJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public CKDAIJCFICL NNOGECKBPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public BLGCKCAEBNA EKBGIHOCMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67D170", VA = "0x18067E570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public NDJGAFFBPCH PKEGKBMDJJG
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x67E580", Offset = "0x67D180", VA = "0x18067E580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public JOBGNDCAMAM BBLKMPHNEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x6770D0", Offset = "0x675CD0", VA = "0x1806770D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public LJHKOFPCONB NBHOOAPKPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x68D760", Offset = "0x68C360", VA = "0x18068D760", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public HBEDANEOEFD HBHJHLDECID
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x6770B0", Offset = "0x675CB0", VA = "0x1806770B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public OFDPPBHBKCF MDNKEJMDPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x68D770", Offset = "0x68C370", VA = "0x18068D770", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public CPPNPEKOALL DDFIAFJOFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x68D780", Offset = "0x68C380", VA = "0x18068D780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public BGOAEBFPKAN MCAPGJHFGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x68D700", Offset = "0x68C300", VA = "0x18068D700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public LHNBKEDDAHF NJJHLCFOCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x68D710", Offset = "0x68C310", VA = "0x18068D710", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public CGEDEAJAIJO CCKOPMBDMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x6B36D0", Offset = "0x6B22D0", VA = "0x1806B36D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public ILOELKJEBPE MLFOPEGHEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x67DD80", Offset = "0x67C980", VA = "0x18067DD80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public IAEAFPAPBEN PCLFLCOGEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x67DE20", Offset = "0x67CA20", VA = "0x18067DE20", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public NFJLHIJFPAP JDCDOGHPFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x6B36A0", Offset = "0x6B22A0", VA = "0x1806B36A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public NMCFLAICADE NPMGNJDOBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x68D720", Offset = "0x68C320", VA = "0x18068D720", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public EKMBBEOBHCH HENNOHLOEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x68D730", Offset = "0x68C330", VA = "0x18068D730", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public PEGFCDNOKHB ENMAJKJJAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x68D750", Offset = "0x68C350", VA = "0x18068D750", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public AHPBGKKBONO FBGBCINBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x69DAA0", Offset = "0x69C6A0", VA = "0x18069DAA0", Slot = "21")]
		get
		{
			return default(AHPBGKKBONO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D0C0", Offset = "0x2F8BCC0", VA = "0x182F8D0C0", Slot = "22")]
	public void LHCOLCBEPCK(PGEEJALGCGE BPEEICHBHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x1F63CF0", Offset = "0x1F628F0", VA = "0x181F63CF0", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D3B0", Offset = "0x2F8BFB0", VA = "0x182F8D3B0", Slot = "23")]
	public void PGNCABCBGBJ(PGEEJALGCGE BPEEICHBHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public AJINGDKPJEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[DefaultMember("Item")]
public class HCOCICIBOHJ : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class JBAOOKJDFLK : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public HCOCICIBOHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x68D790", Offset = "0x68C390", VA = "0x18068D790", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA440", Offset = "0x3DD9040", VA = "0x183DDA440", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x67B200", Offset = "0x679E00", VA = "0x18067B200")]
		[DebuggerHidden]
		public JBAOOKJDFLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA290", Offset = "0x3DD8E90", VA = "0x183DDA290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA400", Offset = "0x3DD9000", VA = "0x183DDA400", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	protected const ulong BJBGNNPKICK = 1uL;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	protected const ulong OABBAPIFDAH = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	protected const int IDDPLALNLDB = 8;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	protected const int CJJNJOCBBOL = 6;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public const int FLJMPMDEKDD = 64;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	protected const int HKIHKLFMLDG = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private readonly List<ulong> JAFLMPAEHIA;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6777D0", VA = "0x180678BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x71B410", Offset = "0x71A010", VA = "0x18071B410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int FHFKECIMGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x692C90", Offset = "0x691890", VA = "0x180692C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x71B320", Offset = "0x719F20", VA = "0x18071B320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8120", Offset = "0x2AA6D20", VA = "0x182AA8120")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8380", Offset = "0x2AA6F80", VA = "0x182AA8380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8AD0", Offset = "0x2AA76D0", VA = "0x182AA8AD0")]
	public HCOCICIBOHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8A40", Offset = "0x2AA7640", VA = "0x182AA8A40")]
	public HCOCICIBOHJ(int BMBMFEJNLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7E80", Offset = "0x2AA6A80", VA = "0x182AA7E80")]
	public bool EPJKFHCELEM(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8530", Offset = "0x2AA7130", VA = "0x182AA8530")]
	public bool IGNGFCONNFK(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x2AA87E0", Offset = "0x2AA73E0", VA = "0x182AA87E0")]
	public bool MGMFPFCGJEH(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x2AA86B0", Offset = "0x2AA72B0", VA = "0x182AA86B0")]
	public bool ILPKKNHIECH(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7CB0", Offset = "0x2AA68B0", VA = "0x182AA7CB0")]
	public void BKABFKFJJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8860", Offset = "0x2AA7460", VA = "0x182AA8860")]
	public void NFMEJPNMIDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8950", Offset = "0x2AA7550", VA = "0x182AA8950")]
	public void NMFBOCJEJOB(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8210", Offset = "0x2AA6E10", VA = "0x182AA8210")]
	public void GJPIAAEOJAL(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8620", Offset = "0x2AA7220", VA = "0x182AA8620")]
	public bool IICJGCDBNOO(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA86C0", Offset = "0x2AA72C0", VA = "0x182AA86C0")]
	public void MCEAPOJGNOA(int HPNBOGMLOLG, int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7F60", Offset = "0x2AA6B60", VA = "0x182AA7F60")]
	public void FBHHBCLDNAO(int BEFJFPBKMMC, int DFFNEOCPAMF, int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7D40", Offset = "0x2AA6940", VA = "0x182AA7D40")]
	public int ELGBPIMHCCH(int CGKKILDEEIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7E10", Offset = "0x2AA6A10", VA = "0x182AA7E10")]
	public int ELGBPIMHCCH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2AA81C0", Offset = "0x2AA6DC0", VA = "0x182AA81C0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8310", Offset = "0x2AA6F10", VA = "0x182AA8310", Slot = "4")]
	[IteratorStateMachine(typeof(JBAOOKJDFLK))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8310", Offset = "0x2AA6F10", VA = "0x182AA8310", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class OOMMCEBOHAF<T> : global::EIEGCCEOGGL<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	protected global::KOEPKCJHKNK<T> KKIKIOMPACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	protected global::EJMMMBCHJMF<T> KMACGJHLGJP;

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x1552B20", Offset = "0x1551720", VA = "0x181552B20")]
	public OOMMCEBOHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x276C3E0", Offset = "0x276AFE0", VA = "0x18276C3E0")]
	public OOMMCEBOHAF(global::KOEPKCJHKNK<T> KKIKIOMPACD, global::EJMMMBCHJMF<T> KMACGJHLGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x276C0A0", Offset = "0x276ACA0", VA = "0x18276C0A0", Slot = "11")]
	public override T MNOLKCHHLIP(FBLOOANMBAP MGAGEIKHIFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x276BCF0", Offset = "0x276A8F0", VA = "0x18276BCF0", Slot = "12")]
	public override void CLPGJOCDFOA(FBLOOANMBAP MGAGEIKHIFC, T GKFICKKHACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class HGBADOGMCEE
{
	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x3525120", Offset = "0x3523D20", VA = "0x183525120")]
	public static EBLKGKAPHAO EHMHLLLMBAF<T>(this ICLHPLIDGLM HFDCOKODHFK, global::GPAKIDKFMKC<T> NLCIGFDKGEE, global::KOEPKCJHKNK<T> KKIKIOMPACD, global::EJMMMBCHJMF<T> KMACGJHLGJP) where T : struct
	{
		return default(EBLKGKAPHAO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class NOBMNNBKCMN<T> : global::OOMMCEBOHAF<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x33859E0", Offset = "0x33845E0", VA = "0x1833859E0")]
	public NOBMNNBKCMN(T HKPINKIDAGP, T MFHJKPMAGKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class IHOBDKFOEBC<T> : global::EIEGCCEOGGL<T> where T : struct, HHCBFJCPHFB
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x17F7A20", Offset = "0x17F6620", VA = "0x1817F7A20", Slot = "11")]
	public override T MNOLKCHHLIP(FBLOOANMBAP MGAGEIKHIFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x17F79B0", Offset = "0x17F65B0", VA = "0x1817F79B0", Slot = "12")]
	public override void CLPGJOCDFOA(FBLOOANMBAP MGAGEIKHIFC, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x17F7AD0", Offset = "0x17F66D0", VA = "0x1817F7AD0")]
	public IHOBDKFOEBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public abstract class OHIGGHNONAL : OBKJCEBKCCG
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public abstract Type GIIKDEPGDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void MNOLKCHHLIP(FBLOOANMBAP MGAGEIKHIFC, in PMECDNBONOH GKFICKKHACC);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void CLPGJOCDFOA(FBLOOANMBAP MGAGEIKHIFC, in EKBGHCIKEGG GKFICKKHACC);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void KGEJHADOBPB(FBLOOANMBAP MGAGEIKHIFC, OGMHHGNLNGH EHGIDPAFOKH, [Optional] object EDPENIGJGLF);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	protected OHIGGHNONAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public abstract class EIEGCCEOGGL<T> : OHIGGHNONAL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override Type GIIKDEPGDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEA70", Offset = "0x2DFD670", VA = "0x182DFEA70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T MNOLKCHHLIP(FBLOOANMBAP MGAGEIKHIFC);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void CLPGJOCDFOA(FBLOOANMBAP MGAGEIKHIFC, T GKFICKKHACC);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x2DFE180", Offset = "0x2DFCD80", VA = "0x182DFE180", Slot = "8")]
	public override void MNOLKCHHLIP(FBLOOANMBAP MGAGEIKHIFC, in PMECDNBONOH EHPFANFOFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2DFC5D0", Offset = "0x2DFB1D0", VA = "0x182DFC5D0", Slot = "9")]
	public override void CLPGJOCDFOA(FBLOOANMBAP MGAGEIKHIFC, in EKBGHCIKEGG GPNGGDGNOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x2DFCEF0", Offset = "0x2DFBAF0", VA = "0x182DFCEF0", Slot = "10")]
	public override void KGEJHADOBPB(FBLOOANMBAP MGAGEIKHIFC, OGMHHGNLNGH EHGIDPAFOKH, object EDPENIGJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x1336860", Offset = "0x1335460", VA = "0x181336860")]
	protected EIEGCCEOGGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class KFJDFNMFHEG
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class NAEFABMFDEK
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class PEDGLIHIKJO<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
			public PEDGLIHIKJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x2B4A940", Offset = "0x2B49540", VA = "0x182B4A940")]
			internal void <RegisterFixedString>b__0(FBLOOANMBAP p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x2B4AB10", Offset = "0x2B49710", VA = "0x182B4AB10")]
			internal T <RegisterFixedString>b__1(FBLOOANMBAP p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC930", Offset = "0x3DDB530", VA = "0x183DDC930")]
		public static void PCEGIKFNJKA(EIIGGLKHNAH DKBHOLHDIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x3453920", Offset = "0x3452520", VA = "0x183453920")]
		private static void CBMPDEDBMCG<T>(EIIGGLKHNAH DKBHOLHDIDD, int MFHJKPMAGKE) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x3453A40", Offset = "0x3452640", VA = "0x183453A40")]
		private static void CEIBFOEDIGH<T>(FBLOOANMBAP KNNJFFBFLLC, T MINMGIMIPFB, int MFHJKPMAGKE) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x3453AD0", Offset = "0x34526D0", VA = "0x183453AD0")]
		private static T LAKJHLDIICJ<T>(FBLOOANMBAP KNNJFFBFLLC, int MFHJKPMAGKE) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public NAEFABMFDEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class DCLJHIPKAGN : PMEJJIODGLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private EIIGGLKHNAH DKBHOLHDIDD;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x344C660", Offset = "0x344B260", VA = "0x18344C660", Slot = "6")]
		public override void ICHOEHPKEKD<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD4F50", Offset = "0x3DD3B50", VA = "0x183DD4F50")]
		public static void IIJFNGOBNPM(EIIGGLKHNAH DKBHOLHDIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5000", Offset = "0x3DD3C00", VA = "0x183DD5000")]
		public DCLJHIPKAGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x2AB41C0", Offset = "0x2AB2DC0", VA = "0x182AB41C0")]
	public static void COKFLBGGNAI(EIIGGLKHNAH DKBHOLHDIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x23518A0", Offset = "0x23504A0", VA = "0x1823518A0")]
	public static void FNKCDMPNLLG<T>(EIIGGLKHNAH DKBHOLHDIDD, global::KOEPKCJHKNK<T> KKIKIOMPACD, global::EJMMMBCHJMF<T> KMACGJHLGJP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x2351930", Offset = "0x2350530", VA = "0x182351930")]
	public static void JPHBBKGMDMM<T>(EIIGGLKHNAH HCCBCGGLKDB) where T : struct, HHCBFJCPHFB
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
public interface EIIGGLKHNAH : global::GBHMBPPBAGM<EIIGGLKHNAH>
{
	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHMHLLLMBAF(Type BIEGICDMJCM, OBKJCEBKCCG HCCBCGGLKDB);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GIGGJMBFKKD(Type BIEGICDMJCM, out OBKJCEBKCCG HCCBCGGLKDB);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class IEFBNJGCBKJ
{
	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF690", Offset = "0x2AAE290", VA = "0x182AAF690")]
	public static void EHMHLLLMBAF(this EIIGGLKHNAH EBNNPKINFJN, OBKJCEBKCCG HCCBCGGLKDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[DAMCBGMFJNJ(typeof(ICLHPLIDGLM), new string[] { })]
public sealed class PKNAOIDMDLB : ICLHPLIDGLM, global::GBHMBPPBAGM<ICLHPLIDGLM>, KGABHKADGEM, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly Dictionary<EBLKGKAPHAO, OBKJCEBKCCG> DKBHOLHDIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private EIIGGLKHNAH PKGJNPCJHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private IPCBIFCIILJ HFDCOKODHFK;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool AADGLDALGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x767F80", Offset = "0x766B80", VA = "0x180767F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x731170", Offset = "0x72FD70", VA = "0x180731170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x2A91BF0", Offset = "0x2A907F0", VA = "0x182A91BF0")]
	public PKNAOIDMDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x2A91C70", Offset = "0x2A90870", VA = "0x182A91C70")]
	public PKNAOIDMDLB(Dictionary<EBLKGKAPHAO, OBKJCEBKCCG> DKBHOLHDIDD, bool KMKNMACIINI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x2A91AB0", Offset = "0x2A906B0", VA = "0x182A91AB0", Slot = "7")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x2A914B0", Offset = "0x2A900B0", VA = "0x182A914B0", Slot = "8")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x2A91990", Offset = "0x2A90590", VA = "0x182A91990", Slot = "9")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x2A919E0", Offset = "0x2A905E0", VA = "0x182A919E0", Slot = "4")]
	public EBLKGKAPHAO IDLNJNJGIMG(PMBKKKKDOIF NLCIGFDKGEE)
	{
		return default(EBLKGKAPHAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x2A91530", Offset = "0x2A90130", VA = "0x182A91530", Slot = "5")]
	public void EHMHLLLMBAF(EBLKGKAPHAO GLGEGPNMJGF, OBKJCEBKCCG HCCBCGGLKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2A916A0", Offset = "0x2A902A0", VA = "0x182A916A0")]
	[Conditional("DEBUG_BUILD")]
	private void FAJLMHNAGLP(EBLKGKAPHAO GLGEGPNMJGF, Type BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x2A917E0", Offset = "0x2A903E0", VA = "0x182A917E0", Slot = "6")]
	public bool GIGGJMBFKKD(EBLKGKAPHAO GLGEGPNMJGF, out OBKJCEBKCCG HCCBCGGLKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x2A91B10", Offset = "0x2A90710", VA = "0x182A91B10", Slot = "10")]
	public ICLHPLIDGLM PALDOONLBKG()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[DAMCBGMFJNJ(typeof(EIIGGLKHNAH), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.TypeSerializer)]
	public sealed class TypeSerializerService : KGABHKADGEM, EIIGGLKHNAH, global::GBHMBPPBAGM<EIIGGLKHNAH>
	{
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly Dictionary<Type, OBKJCEBKCCG> DKBHOLHDIDD;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public bool AADGLDALGOE
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6904D0", VA = "0x1806918D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x6B3000", Offset = "0x6B1C00", VA = "0x1806B3000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C5C0", Offset = "0x2D8B1C0", VA = "0x182D8C5C0")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C640", Offset = "0x2D8B240", VA = "0x182D8C640")]
		public TypeSerializerService(Dictionary<Type, OBKJCEBKCCG> DKBHOLHDIDD, bool KMKNMACIINI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C430", Offset = "0x2D8B030", VA = "0x182D8C430", Slot = "4")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C230", Offset = "0x2D8AE30", VA = "0x182D8C230", Slot = "5")]
		public void EHMHLLLMBAF(Type BIEGICDMJCM, OBKJCEBKCCG HCCBCGGLKDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C350", Offset = "0x2D8AF50", VA = "0x182D8C350", Slot = "6")]
		public bool GIGGJMBFKKD(Type BIEGICDMJCM, out OBKJCEBKCCG HCCBCGGLKDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C490", Offset = "0x2D8B090", VA = "0x182D8C490", Slot = "7")]
		public EIIGGLKHNAH PALDOONLBKG()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[DAMCBGMFJNJ(typeof(JFLEAHECAEL), new string[] { })]
internal sealed class IDEFDCDFKDO : JFLEAHECAEL, KGABHKADGEM, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly Dictionary<EBLKGKAPHAO, FIJPOFPCCDH> JLJOHFDAIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private IPCBIFCIILJ HFDCOKODHFK;

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEA90", Offset = "0x2AAD690", VA = "0x182AAEA90", Slot = "6")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x2AAE9C0", Offset = "0x2AAD5C0", VA = "0x182AAE9C0", Slot = "7")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEA20", Offset = "0x2AAD620", VA = "0x182AAEA20", Slot = "4")]
	public void EHMHLLLMBAF(EBLKGKAPHAO KBPOLLDMHFK, Type MEEEBFGFJIC, FIJPOFPCCDH FDCFGEMPDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEAE0", Offset = "0x2AAD6E0", VA = "0x182AAEAE0", Slot = "5")]
	public bool LOMOOEPGEHH(EBLKGKAPHAO KBPOLLDMHFK, out FIJPOFPCCDH FDCFGEMPDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x2AAEB50", Offset = "0x2AAD750", VA = "0x182AAEB50")]
	[Conditional("DEBUG_BUILD")]
	private void PLNKIKBCAFD(EBLKGKAPHAO KBPOLLDMHFK, Type MEEEBFGFJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x2AAECE0", Offset = "0x2AAD8E0", VA = "0x182AAECE0")]
	public IDEFDCDFKDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[DAMCBGMFJNJ(typeof(EFOGDMGBIMI), new string[] { })]
internal sealed class HHCPEIACMND : EFOGDMGBIMI, PFBMKGBLLGM, KGABHKADGEM, OHFJHEDBJHF, HMFGCABFMPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private readonly HCOCICIBOHJ OCNPEPAPGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private readonly Dictionary<ELJHNEOGEBP, int> CFHEPPACLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly Stack<int> CKGPGEGHFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	[NHBEJKCIJLO]
	private IPCBIFCIILJ HFDCOKODHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	[NHBEJKCIJLO]
	private BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private int NGKKGDFMJIG
	{
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA8D80", Offset = "0x2AA7980", VA = "0x182AA8D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool PAOBNFNAFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x742540", Offset = "0x741140", VA = "0x180742540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x96AC90", Offset = "0x969890", VA = "0x18096AC90", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8DD0", Offset = "0x2AA79D0", VA = "0x182AA8DD0", Slot = "6")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8D00", Offset = "0x2AA7900", VA = "0x182AA8D00", Slot = "7")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9440", Offset = "0x2AA8040", VA = "0x182AA9440", Slot = "8")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9050", Offset = "0x2AA7C50", VA = "0x182AA9050")]
	private void MIOLDPOLFFJ(IOBECAADPPL DKHOCCDNDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8F10", Offset = "0x2AA7B10", VA = "0x182AA8F10", Slot = "4")]
	public bool KOAHOMJNFEJ(ELJHNEOGEBP FFJHOAAMJMD, EBLKGKAPHAO GCEENFOFNFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2AA90F0", Offset = "0x2AA7CF0", VA = "0x182AA90F0", Slot = "5")]
	public void NOLBIPGMLAM(ELJHNEOGEBP FFJHOAAMJMD, Span<EBLKGKAPHAO> HFDCOKODHFK, bool CAALOIGDJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8DD0", Offset = "0x2AA79D0", VA = "0x182AA8DD0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x2AA94F0", Offset = "0x2AA80F0", VA = "0x182AA94F0")]
	public HHCPEIACMND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class OIKFOKDBOGO
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A807E0", Offset = "0x2A7F3E0", VA = "0x182A807E0")]
	public static void PKLJJAPFDPK(this FBLOOANMBAP MGAGEIKHIFC, ReadOnlyMemory<byte> BFIOPBMAOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B62270", Offset = "0x2B60E70", VA = "0x182B62270")]
	public static void FEBNLFJNNAM<T>(this FBLOOANMBAP MGAGEIKHIFC, in T GKFICKKHACC) where T : struct, HHCBFJCPHFB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x2B620F0", Offset = "0x2B60CF0", VA = "0x182B620F0")]
	public static T DOOCBKLHJBN<T>(this FBLOOANMBAP MGAGEIKHIFC) where T : struct, HHCBFJCPHFB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A804E0", Offset = "0x2A7F0E0", VA = "0x182A804E0")]
	public static void FEBNLFJNNAM(this FBLOOANMBAP MGAGEIKHIFC, BCHEGBBHMEO LNPKKMJLCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A804B0", Offset = "0x2A7F0B0", VA = "0x182A804B0")]
	public static BCHEGBBHMEO DDCCAFKGJCD(this FBLOOANMBAP MGAGEIKHIFC)
	{
		return default(BCHEGBBHMEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A80630", Offset = "0x2A7F230", VA = "0x182A80630")]
	public static void MEAKJGFCKDP(this FBLOOANMBAP FHGALIAOBLC, uint PCEDODOJPPO, bool PPGBONBHODL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x2A80510", Offset = "0x2A7F110", VA = "0x182A80510")]
	public static uint FLACGIBIDFE(this FBLOOANMBAP LDNLHJMBEIM, bool PPGBONBHODL = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class JJBODHKEOJK
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class MLAACEJHHGB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public MLAACEJHHGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x2550180", Offset = "0x254ED80", VA = "0x182550180")]
		internal void <GetByteEnumDelegates>b__0(FBLOOANMBAP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x25501F0", Offset = "0x254EDF0", VA = "0x1825501F0")]
		internal T <GetByteEnumDelegates>b__1(FBLOOANMBAP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class KLNLKPNHDAA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public KLNLKPNHDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x32C0F30", Offset = "0x32BFB30", VA = "0x1832C0F30")]
		internal void <GetSByteEnumDelegates>b__0(FBLOOANMBAP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x32C0FA0", Offset = "0x32BFBA0", VA = "0x1832C0FA0")]
		internal T <GetSByteEnumDelegates>b__1(FBLOOANMBAP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class HCCJONPLGIP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public HCCJONPLGIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x3D5A320", Offset = "0x3D58F20", VA = "0x183D5A320")]
		internal void <GetShortEnumDelegates>b__0(FBLOOANMBAP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x3D5A390", Offset = "0x3D58F90", VA = "0x183D5A390")]
		internal T <GetShortEnumDelegates>b__1(FBLOOANMBAP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class MMMPKBFEKIE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public MMMPKBFEKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2553B00", Offset = "0x2552700", VA = "0x182553B00")]
		internal void <GetUShortEnumDelegates>b__0(FBLOOANMBAP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2553B70", Offset = "0x2552770", VA = "0x182553B70")]
		internal T <GetUShortEnumDelegates>b__1(FBLOOANMBAP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class MOIEFPBJCGA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public MOIEFPBJCGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x2557A50", Offset = "0x2556650", VA = "0x182557A50")]
		internal void <GetIntEnumDelegates>b__0(FBLOOANMBAP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x2557AB0", Offset = "0x25566B0", VA = "0x182557AB0")]
		internal T <GetIntEnumDelegates>b__1(FBLOOANMBAP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class OIFNEKNNAEB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x1333410", Offset = "0x1332010", VA = "0x181333410")]
		public OIFNEKNNAEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2756BA0", Offset = "0x27557A0", VA = "0x182756BA0")]
		internal void <GetUIntEnumDelegates>b__0(FBLOOANMBAP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2756C00", Offset = "0x2755800", VA = "0x182756C00")]
		internal T <GetUIntEnumDelegates>b__1(FBLOOANMBAP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x2334A50", Offset = "0x2333650", VA = "0x182334A50")]
	public static void CFMBDIBIHIL<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x2334900", Offset = "0x2333500", VA = "0x182334900")]
	private static void PLJEGKMDGCH<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x2334900", Offset = "0x2333500", VA = "0x182334900")]
	private static void AJKBDINGFBB<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2334C70", Offset = "0x2333870", VA = "0x182334C70")]
	private static void GCKNMCNOIBL<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2334C70", Offset = "0x2333870", VA = "0x182334C70")]
	private static void JECKFBIKEMO<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2334DC0", Offset = "0x23339C0", VA = "0x182334DC0")]
	private static void IDCMMGBKBFD<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2334DC0", Offset = "0x23339C0", VA = "0x182334DC0")]
	private static void HPBKJEKEJED<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class PJFPOHADGAA : OCCCFKPBJLI, HMFGCABFMPC
{
	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A90BC0", Offset = "0x2A8F7C0", VA = "0x182A90BC0", Slot = "4")]
	private void GLLDHAGLBII(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void NPHPEAODLEE(ICLHPLIDGLM HFDCOKODHFK);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
	protected PJFPOHADGAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[IAAENPILNCG(typeof(LocalPoseData))]
public sealed class IMPCAMFCJPE : PJFPOHADGAA
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0AB0", Offset = "0x2AAF6B0", VA = "0x182AB0AB0", Slot = "5")]
	protected override void NPHPEAODLEE(ICLHPLIDGLM HFDCOKODHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0")]
	public IMPCAMFCJPE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.Scope)]
	internal class CopyAuthorityToEntity : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private MCFPIPCNFDN KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private EntityQuery JENEOMCAPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private EntityQuery AKCGHHEOAEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private EntityQuery HBIOBHKPEGB;

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2F9F4B0", Offset = "0x2F9E0B0", VA = "0x182F9F4B0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0180", Offset = "0x2F9ED80", VA = "0x182FA0180", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0300", Offset = "0x2F9EF00", VA = "0x182FA0300", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2FA02D0", Offset = "0x2F9EED0", VA = "0x182FA02D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2F9F520", Offset = "0x2F9E120", VA = "0x182F9F520")]
		private void DGOCIDGHHOD(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2F9FF00", Offset = "0x2F9EB00", VA = "0x182F9FF00")]
		private void NHFGIFBKIPO(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2F9FA10", Offset = "0x2F9E610", VA = "0x182F9FA10")]
		private void HKEJDJCHHIA(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x2F9F860", Offset = "0x2F9E460", VA = "0x182F9F860")]
		private void HCEKFJKKBNP(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2F9FCF0", Offset = "0x2F9E8F0", VA = "0x182F9FCF0")]
		private void HLOAMEGFIMO(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2FA00A0", Offset = "0x2F9ECA0", VA = "0x182FA00A0")]
		private void OHKEONNPAJJ(IOBECAADPPL DKHOCCDNDOH, int DEPHGHGHIPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class DJFNNCLBNPJ : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private EntityQuery NJIBLOIMOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private MCFPIPCNFDN KNPPOFLONHP;

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x2FA41E0", Offset = "0x2FA2DE0", VA = "0x182FA41E0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4810", Offset = "0x2FA3410", VA = "0x182FA4810", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x2FA48D0", Offset = "0x2FA34D0", VA = "0x182FA48D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4230", Offset = "0x2FA2E30", VA = "0x182FA4230")]
	private void EEFGJMDDOPD(NativeArray<Entity> FNMNPGEEPJI, NativeList<Entity> PDDBOFHMBMM, ComponentDataFromEntity<PMLDECKNLAK> ACFBIJBMEBF, BufferFromEntity<ChildrenData> PIJKPDLNMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public DJFNNCLBNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class AOMEGDGACFG : ParentSystemBase<AuthoredParentData, JGHIKCNOOHM, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E550", Offset = "0x2F8D150", VA = "0x182F8E550", Slot = "14")]
	protected override EntityQueryDesc KMNFJOOCPJF(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x7226B0", Offset = "0x7212B0", VA = "0x1807226B0", Slot = "15")]
	protected override EntityQueryDesc DFGBELAPBIC(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E590", Offset = "0x2F8D190", VA = "0x182F8E590", Slot = "16")]
	protected override EntityQueryDesc OIHMCIJFFBN(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E510", Offset = "0x2F8D110", VA = "0x182F8E510", Slot = "17")]
	protected override EntityQueryDesc BECNHEEIAMJ(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E610", Offset = "0x2F8D210", VA = "0x182F8E610")]
	public AOMEGDGACFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x2F8E5D0", Offset = "0x2F8D1D0", VA = "0x182F8E5D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class JBECNIGAKKO : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private EntityQuery NJIBLOIMOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private object ACFPHJNDMPN;

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1100", Offset = "0x2AAFD00", VA = "0x182AB1100", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1180", Offset = "0x2AAFD80", VA = "0x182AB1180", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1220", Offset = "0x2AAFE20", VA = "0x182AB1220", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public JBECNIGAKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class OLDKIADPBMK : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery NJIBLOIMOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private object ACFPHJNDMPN;

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x2A82230", Offset = "0x2A80E30", VA = "0x182A82230", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x2A822B0", Offset = "0x2A80EB0", VA = "0x182A822B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x2A82350", Offset = "0x2A80F50", VA = "0x182A82350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public OLDKIADPBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[InternalBufferCapacity(1)]
internal struct CJBDKPMJKHI : ISystemStateBufferElementData, IBufferElementData, IEquatable<CJBDKPMJKHI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public CAOPLFMILCI DKBLPJPHEMF;

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x2F96290", Offset = "0x2F94E90", VA = "0x182F96290", Slot = "4")]
	public bool Equals(CJBDKPMJKHI MCLIMJFDMCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x773100", VA = "0x180774500")]
	public static CJBDKPMJKHI KPOCFOKDNEC(CAOPLFMILCI DKBLPJPHEMF)
	{
		return default(CJBDKPMJKHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[InternalBufferCapacity(4)]
internal struct ABOJJOFDAAP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public CAOPLFMILCI DKBLPJPHEMF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x773100", VA = "0x180774500")]
	public static ABOJJOFDAAP KPOCFOKDNEC(CAOPLFMILCI DKBLPJPHEMF)
	{
		return default(ABOJJOFDAAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal abstract class DCNGCHEELNJ : DEFANIGDOCO
{
	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x2FA33B0", Offset = "0x2FA1FB0", VA = "0x182FA33B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3540", Offset = "0x2FA2140", VA = "0x182FA3540", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	protected DCNGCHEELNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[GDGGJDPAMIC]
internal abstract class DEFANIGDOCO : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	protected EntityQuery NJIBLOIMOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	protected BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	protected PEGFCDNOKHB JKDGBJKFGIO;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	protected abstract OGNKEIDFOOL NPIGDLIHDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x2FA35E0", Offset = "0x2FA21E0", VA = "0x182FA35E0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3940", Offset = "0x2FA2540", VA = "0x182FA3940")]
	protected void FAGNKKJNMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x2FA3650", Offset = "0x2FA2250", VA = "0x182FA3650")]
	protected void CEODBMIDNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA38D0", Offset = "0x2FA24D0", VA = "0x182FA38D0")]
	protected CDDJMIAEBFF DDKJCHDPEGP()
	{
		return default(CDDJMIAEBFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	protected DEFANIGDOCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal abstract class PAGNJFPAGMD : DEFANIGDOCO
{
	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E7B0", Offset = "0x2A8D3B0", VA = "0x182A8E7B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E940", Offset = "0x2A8D540", VA = "0x182A8E940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x2A808D0", Offset = "0x2A7F4D0", VA = "0x182A808D0")]
	protected PAGNJFPAGMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class BCNNBBKJPNE : DEFANIGDOCO
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x2F90750", Offset = "0x2F8F350", VA = "0x182F90750", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x2F90860", Offset = "0x2F8F460", VA = "0x182F90860", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	protected BCNNBBKJPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class EBBOAOMMADK : DCNGCHEELNJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected override OGNKEIDFOOL NPIGDLIHDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA7320", Offset = "0x2FA5F20", VA = "0x182FA7320", Slot = "15")]
		get
		{
			return default(OGNKEIDFOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public EBBOAOMMADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class EOIJLLNMIFE : PAGNJFPAGMD
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected override OGNKEIDFOOL NPIGDLIHDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x2FA8900", Offset = "0x2FA7500", VA = "0x182FA8900", Slot = "15")]
		get
		{
			return default(OGNKEIDFOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8970", Offset = "0x2FA7570", VA = "0x182FA8970")]
	public EOIJLLNMIFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x2A808D0", Offset = "0x2A7F4D0", VA = "0x182A808D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class FCEKFGEMPPE : BCNNBBKJPNE
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected override OGNKEIDFOOL NPIGDLIHDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x2AA3BE0", Offset = "0x2AA27E0", VA = "0x182AA3BE0", Slot = "15")]
		get
		{
			return default(OGNKEIDFOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2A808D0", Offset = "0x2A7F4D0", VA = "0x182A808D0")]
	public FCEKFGEMPPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class OIMKMPBGEFL : DCNGCHEELNJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override OGNKEIDFOOL NPIGDLIHDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x2A80860", Offset = "0x2A7F460", VA = "0x182A80860", Slot = "15")]
		get
		{
			return default(OGNKEIDFOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x2A808D0", Offset = "0x2A7F4D0", VA = "0x182A808D0")]
	public OIMKMPBGEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class OJGMPNNGNEH : PAGNJFPAGMD
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override OGNKEIDFOOL NPIGDLIHDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x2A808E0", Offset = "0x2A7F4E0", VA = "0x182A808E0", Slot = "15")]
		get
		{
			return default(OGNKEIDFOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x2A808D0", Offset = "0x2A7F4D0", VA = "0x182A808D0")]
	public OJGMPNNGNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class AKGPFJGHMAO : BCNNBBKJPNE
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override OGNKEIDFOOL NPIGDLIHDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x2F8D3D0", Offset = "0x2F8BFD0", VA = "0x182F8D3D0", Slot = "15")]
		get
		{
			return default(OGNKEIDFOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public AKGPFJGHMAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct EGILLNIGEPO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal struct HPPFFIENPAM : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct APHGNOHDFON : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly struct OGNKEIDFOOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly ComponentType DIIJEEFKGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly ComponentType OKDNGJDIOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly object JJFHDFJGCDG;

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x2A80490", Offset = "0x2A7F090", VA = "0x182A80490")]
	public OGNKEIDFOOL(ComponentType DIIJEEFKGBP, ComponentType OKDNGJDIOCM, object JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x2B61A10", Offset = "0x2B60610", VA = "0x182B61A10")]
	public static OGNKEIDFOOL LEEEFIBDGIA<TReq, TTag>(object JJFHDFJGCDG)
	{
		return default(OGNKEIDFOOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class EMFOFPPLBFF
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public const string NDDAHNPBNCA = "Parented";

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public const string NJIEHMJLAMB = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly OGNKEIDFOOL JDCDOGHPFJD;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly OGNKEIDFOOL KNAPDHCIENB;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct CAOPLFMILCI : global::LHEMAHBEHEJ<CAOPLFMILCI>, MKBPDIMFNJC, IEquatable<CAOPLFMILCI>
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public int OMNKALCAHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727A20", VA = "0x180728E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x728D90", Offset = "0x727990", VA = "0x180728D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public int BDCBCEKMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B60", Offset = "0x8B4760", VA = "0x1808B5B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0xEC96C0", Offset = "0xEC82C0", VA = "0x180EC96C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool ILPKKNHIECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2F962E0", Offset = "0x2F94EE0", VA = "0x182F962E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2F96290", Offset = "0x2F94E90", VA = "0x182F96290", Slot = "8")]
	public bool Equals(CAOPLFMILCI MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x2F96320", Offset = "0x2F94F20", VA = "0x182F96320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[GDGGJDPAMIC]
	[HFIGNCEGOKM(DDEOJCINOPG.Connectables)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	public class UpdateConnectableVisuals : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private struct HJFBICMAOFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public CAOPLFMILCI DKBLPJPHEMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public float3 DKGAADMNOOM;

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x3DD9720", Offset = "0x3DD8320", VA = "0x183DD9720")]
			public HJFBICMAOFP(CAOPLFMILCI DKBLPJPHEMF, float3 DKGAADMNOOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x3DD9700", Offset = "0x3DD8300", VA = "0x183DD9700")]
			public void MAOBKBKJKAJ(out CAOPLFMILCI DKBLPJPHEMF, out float3 DKGAADMNOOM)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private struct LKPPFFJDOIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public NativeList<HJFBICMAOFP> list;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
			public LKPPFFJDOIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<ABOJJOFDAAP> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private struct OMLNAGLAPPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public NativeList<HJFBICMAOFP> list;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
			public OMLNAGLAPPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<CJBDKPMJKHI> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private struct EJPLNNGHJAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public NativeList<HJFBICMAOFP> list;

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
			public EJPLNNGHJAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in JIHAIGKEFFM com, in DynamicBuffer<CJBDKPMJKHI> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct JAIHMKMOIPB : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E2")]
			private struct CPKHLLCOGMI
			{
				[Cpp2IlInjected.Token(Token = "0x20000E3")]
				public struct PKLKGGPDPJE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BE")]
					public LambdaParameterValueProvider_Entity.Runtime HJBCEBNAHHG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002BF")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MHHPNAKGAOA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002C0")]
					public LambdaParameterValueProvider_DynamicBuffer<ABOJJOFDAAP>.Runtime CLBKAHCCJPM;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002BB")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity DPFMNEOBEKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002BC")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> HKFKACPNCBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002BD")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<ABOJJOFDAAP> NJNEFPPKJAP;

				[Cpp2IlInjected.Token(Token = "0x600077D")]
				[Cpp2IlInjected.Address(RVA = "0x3DD4960", Offset = "0x3DD3560", VA = "0x183DD4960")]
				public void GKLJKDAGGIM(UpdateConnectableVisuals GFHLMIDFMDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077E")]
				[Cpp2IlInjected.Address(RVA = "0x3DD49E0", Offset = "0x3DD35E0", VA = "0x183DD49E0")]
				public PKLKGGPDPJE HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
				{
					return default(PKLKGGPDPJE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public UpdateConnectableVisuals MLNDFFFPEIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public NativeList<HJFBICMAOFP> LENGKEKMOEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			private CPKHLLCOGMI MOCCMIIFDDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe CPKHLLCOGMI.PKLKGGPDPJE* NKKBCHLLBEJ;

			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate ENKNKDHOKFC;

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x3DD9D10", Offset = "0x3DD8910", VA = "0x183DD9D10")]
			internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, WorldPoseData MBHPMANAMCC, in DynamicBuffer<ABOJJOFDAAP> OPCGPJFHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA220", Offset = "0x3DD8E20", VA = "0x183DDA220", Slot = "5")]
			public void ReadFromDisplayClass(ref LKPPFFJDOIG LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA250", Offset = "0x3DD8E50", VA = "0x183DDA250", Slot = "6")]
			public void WriteToDisplayClass(ref LKPPFFJDOIG LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x3DD9F50", Offset = "0x3DD8B50", VA = "0x183DD9F50", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA0E0", Offset = "0x3DD8CE0", VA = "0x183DDA0E0")]
			public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, ref CPKHLLCOGMI.PKLKGGPDPJE FAHLNAJJNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA0A0", Offset = "0x3DD8CA0", VA = "0x183DDA0A0")]
			public void GKLJKDAGGIM(UpdateConnectableVisuals GFHLMIDFMDH, ref LKPPFFJDOIG LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA030", Offset = "0x3DD8C30", VA = "0x183DDA030")]
			public unsafe static void FIKCEGMOMMK(ArchetypeChunkIterator* NKPBBGCKHML, void* MOGAJEFFDEG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct IPEMAGOIMPM : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct JPOLAHEONJM
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				[NoAlias]
				public struct HDEABFCMPFH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MHHPNAKGAOA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<CJBDKPMJKHI>.Runtime CLBKAHCCJPM;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002C4")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> HKFKACPNCBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002C5")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<CJBDKPMJKHI> NJNEFPPKJAP;

				[Cpp2IlInjected.Token(Token = "0x6000784")]
				[Cpp2IlInjected.Address(RVA = "0x3DDA700", Offset = "0x3DD9300", VA = "0x183DDA700")]
				public void GKLJKDAGGIM(UpdateConnectableVisuals GFHLMIDFMDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x3DDA770", Offset = "0x3DD9370", VA = "0x183DDA770")]
				public HDEABFCMPFH HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
				{
					return default(HDEABFCMPFH);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public NativeList<HJFBICMAOFP> LENGKEKMOEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			private JPOLAHEONJM MOCCMIIFDDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe JPOLAHEONJM.HDEABFCMPFH* NKKBCHLLBEJ;

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x3DD99C0", Offset = "0x3DD85C0", VA = "0x183DD99C0")]
			internal void CCKNMJAJJNM(in WorldPoseData MBHPMANAMCC, in DynamicBuffer<CJBDKPMJKHI> OPCGPJFHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A950", Offset = "0x2D79550", VA = "0x182D7A950", Slot = "5")]
			public void ReadFromDisplayClass(ref OMLNAGLAPPG LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x3DD9AD0", Offset = "0x3DD86D0", VA = "0x183DD9AD0", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x3DD9C40", Offset = "0x3DD8840", VA = "0x183DD9C40")]
			public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref JPOLAHEONJM.HDEABFCMPFH FAHLNAJJNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x3DD9BA0", Offset = "0x3DD87A0", VA = "0x183DD9BA0")]
			public void GKLJKDAGGIM(UpdateConnectableVisuals GFHLMIDFMDH, ref OMLNAGLAPPG LAOMKEKPBEJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct AEOJPMMLKJP : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct POPLMFCBMON
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct LEGDHPLDAFM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CE")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MHHPNAKGAOA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002CF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<JIHAIGKEFFM>.Runtime OFOJIINDPPL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<CJBDKPMJKHI>.Runtime CLBKAHCCJPM;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CB")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> HKFKACPNCBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002CC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<JIHAIGKEFFM> AHPNPDAOBAG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002CD")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<CJBDKPMJKHI> NJNEFPPKJAP;

				[Cpp2IlInjected.Token(Token = "0x600078B")]
				[Cpp2IlInjected.Address(RVA = "0x3DDD9B0", Offset = "0x3DDC5B0", VA = "0x183DDD9B0")]
				public void GKLJKDAGGIM(UpdateConnectableVisuals GFHLMIDFMDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0x3DDDA40", Offset = "0x3DDC640", VA = "0x183DDDA40")]
				public LEGDHPLDAFM HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
				{
					return default(LEGDHPLDAFM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<HJFBICMAOFP> LENGKEKMOEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			private POPLMFCBMON MOCCMIIFDDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe POPLMFCBMON.LEGDHPLDAFM* NKKBCHLLBEJ;

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2470", Offset = "0x3DD1070", VA = "0x183DD2470")]
			internal void CCKNMJAJJNM(in WorldPoseData MBHPMANAMCC, in JIHAIGKEFFM IHNEPFIEBPB, in DynamicBuffer<CJBDKPMJKHI> OPCGPJFHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A950", Offset = "0x2D79550", VA = "0x182D7A950", Slot = "5")]
			public void ReadFromDisplayClass(ref EJPLNNGHJAJ LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x3DD25D0", Offset = "0x3DD11D0", VA = "0x183DD25D0", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2690", Offset = "0x3DD1290", VA = "0x183DD2690")]
			public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref POPLMFCBMON.LEGDHPLDAFM FAHLNAJJNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2650", Offset = "0x3DD1250", VA = "0x183DD2650")]
			public void GKLJKDAGGIM(UpdateConnectableVisuals GFHLMIDFMDH, ref EJPLNNGHJAJ LAOMKEKPBEJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery CGLLEBIJLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery EBOFKEOJBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery DLNCMEBBGGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private EntityQuery HKNPPEMCAMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private EntityQuery JMMNAMDALGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private EntityQuery OIPMCNANILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private EntityQuery BECHJIGBLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private EntityQuery CILKHOHCDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private EntityQuery PBNEECLJEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EntityQuery CBFMNGNHAPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private global::FIGNPHGKAHK<CAOPLFMILCI, FELBJINOHJJ> EMKLCMONODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private EKMBBEOBHCH CIKFHEBMKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private LHNBKEDDAHF OBKGOOLKCPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private AOMMDCBFHIK ODCOIMOFOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private EntityQuery CKABPPIMKOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private ProfilerMarker BJNBNLLCKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private EntityQuery KGFELCKJPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private EntityQuery DPBBMHKMPOP;

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int EONFJIOMKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x2D8DA40", Offset = "0x2D8C640", VA = "0x182D8DA40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2D91010", Offset = "0x2D8FC10", VA = "0x182D91010")]
		internal FELBJINOHJJ PHFMJGEGBPP(CAOPLFMILCI DKBLPJPHEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2D8CC30", Offset = "0x2D8B830", VA = "0x182D8CC30", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2D90420", Offset = "0x2D8F020", VA = "0x182D90420", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x2D906A0", Offset = "0x2D8F2A0", VA = "0x182D906A0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2D90830", Offset = "0x2D8F430", VA = "0x182D90830", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2D90660", Offset = "0x2D8F260", VA = "0x182D90660", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x2D8EE40", Offset = "0x2D8DA40", VA = "0x182D8EE40")]
		private void IGFJBPFNBIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2D8ECF0", Offset = "0x2D8D8F0", VA = "0x182D8ECF0")]
		private void IDJKKMDOOON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E870", Offset = "0x2D8D470", VA = "0x182D8E870")]
		private void GGLHAALBKNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2D90870", Offset = "0x2D8F470", VA = "0x182D90870", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FDE0", Offset = "0x2D8E9E0", VA = "0x182D8FDE0")]
		private void LPIFGEKCIOM(EntityQuery JENEOMCAPBE, EntityQuery IPFHHMKILIK, EntityQuery AKCGHHEOAEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2D8DA80", Offset = "0x2D8C680", VA = "0x182D8DA80")]
		private void DOHHNJJEEIG(EntityQuery AKCGHHEOAEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E480", Offset = "0x2D8D080", VA = "0x182D8E480")]
		private void GABJCONFNNC(global::GHKNLLBEIFC<Entity> MFMIPEIFDHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E760", Offset = "0x2D8D360", VA = "0x182D8E760")]
		private void GBBEBPJADGG(global::GHKNLLBEIFC<Entity> PADGGACIMJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F7E0", Offset = "0x2D8E3E0", VA = "0x182D8F7E0")]
		private void KHMNLNKEMON(global::GHKNLLBEIFC<Entity> BJKHIAGLNJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D8D0", Offset = "0x2D8C4D0", VA = "0x182D8D8D0")]
		private void CGGEMMFGCPF(NativeList<CAOPLFMILCI> GLFECICOPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2D8CF80", Offset = "0x2D8BB80", VA = "0x182D8CF80")]
		private NativeList<CAOPLFMILCI> AJAAJILMKGH(NativeArray<Entity> FNMNPGEEPJI)
		{
			return default(NativeList<CAOPLFMILCI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F1C0", Offset = "0x2D8DDC0", VA = "0x182D8F1C0")]
		private void JGINBGNCPCF(NativeArray<Entity> FNMNPGEEPJI, NativeList<CAOPLFMILCI> GLFECICOPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2D909A0", Offset = "0x2D8F5A0", VA = "0x182D909A0")]
		private void PCJAFBJIGEK(NativeArray<Entity> INCNBPCPOJH, NativeArray<Entity> KDFKCICKCCF, NativeList<CAOPLFMILCI> CKGPGEGHFJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2D8DB50", Offset = "0x2D8C750", VA = "0x182D8DB50")]
		private void EJJIHPMNHNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D5D0", Offset = "0x2D8C1D0", VA = "0x182D8D5D0")]
		private global::BNGAOKMFDEK<HJFBICMAOFP> BDOPCPLFDHJ(EntityQuery NJIBLOIMOJA, Func<NativeList<HJFBICMAOFP>, JobHandle> NJJKEPCLKGP)
		{
			return default(global::BNGAOKMFDEK<HJFBICMAOFP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E060", Offset = "0x2D8CC60", VA = "0x182D8E060")]
		private JobHandle FCLDNEMJKLM(NativeList<HJFBICMAOFP> LENGKEKMOEB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2D90ED0", Offset = "0x2D8FAD0", VA = "0x182D90ED0")]
		private JobHandle PDPIPHHDHHC(NativeList<HJFBICMAOFP> LENGKEKMOEB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D4A0", Offset = "0x2D8C0A0", VA = "0x182D8D4A0")]
		private JobHandle BCGEKKIDDNC(NativeList<HJFBICMAOFP> LENGKEKMOEB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2D8CCF0", Offset = "0x2D8B8F0", VA = "0x182D8CCF0")]
		private void ADEGEJLALMK(global::BNGAOKMFDEK<HJFBICMAOFP> LENGKEKMOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E1F0", Offset = "0x2D8CDF0", VA = "0x182D8E1F0")]
		private void FEMPCINJBIC(global::BNGAOKMFDEK<HJFBICMAOFP> LENGKEKMOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E000", Offset = "0x2D8CC00", VA = "0x182D8E000")]
		private bool FCCKCMOGGAC(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2D8EC20", Offset = "0x2D8D820", VA = "0x182D8EC20")]
		private NativeArray<Entity> HHFIOGJMHGI(Entity LLEBIIAHFDD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D710", Offset = "0x2D8C310", VA = "0x182D8D710")]
		private CAOPLFMILCI BPLIBEFCEAF(NativeList<CAOPLFMILCI> CKGPGEGHFJA)
		{
			return default(CAOPLFMILCI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2D91060", Offset = "0x2D8FC60", VA = "0x182D91060")]
		private void PKCODKNDIEH(CAOPLFMILCI DKBLPJPHEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2D902C0", Offset = "0x2D8EEC0", VA = "0x182D902C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2D8F980", Offset = "0x2D8E580", VA = "0x182D8F980")]
		public static EntityQuery KMEHOPINACO(ComponentSystemBase GFHLMIDFMDH)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2D8FB80", Offset = "0x2D8E780", VA = "0x182D8FB80")]
		public static EntityQuery LMKKLBPJKDL(ComponentSystemBase GFHLMIDFMDH)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2D8EF50", Offset = "0x2D8DB50", VA = "0x182D8EF50")]
		public static EntityQuery IGKLCJAOFJP(ComponentSystemBase GFHLMIDFMDH)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[HFIGNCEGOKM(DDEOJCINOPG.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EntityQuery NJIBLOIMOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private NDJGAFFBPCH JFKPFEJELNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private CNJGENKFHHK CCOKILMELNA;

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x2A98160", Offset = "0x2A96D60", VA = "0x182A98160", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x2A980D0", Offset = "0x2A96CD0", VA = "0x182A980D0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x2A98260", Offset = "0x2A96E60", VA = "0x182A98260", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class BIAPBKCCAGM : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public IAEGHKEFOHF DPCGPJIEFDH;

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public BIAPBKCCAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x677F40", Offset = "0x676B40", VA = "0x180677F40")]
	public BIAPBKCCAGM(IAEGHKEFOHF DPCGPJIEFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x2F916A0", Offset = "0x2F902A0", VA = "0x182F916A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class FCHHBIADLOP : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private ObjectEmbodimentService MNJGLAAEFPK;

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3C50", Offset = "0x2AA2850", VA = "0x182AA3C50", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3CB0", Offset = "0x2AA28B0", VA = "0x182AA3CB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3CE0", Offset = "0x2AA28E0", VA = "0x182AA3CE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	protected FCHHBIADLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class LKENFMAMPOC : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private EntityQuery CPKNEGOPBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private EntityQuery NJCLGAOLKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private EntityQuery AIIHDHAJNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private EntityQuery AGONCLAMABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private ObjectEmbodimentService LNADFPLFIDK;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int LJMLBAGHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x2ABC270", Offset = "0x2ABAE70", VA = "0x182ABC270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int HBEHIIKMMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x2ABBFE0", Offset = "0x2ABABE0", VA = "0x182ABBFE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x2ABBF80", Offset = "0x2ABAB80", VA = "0x182ABBF80", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC640", Offset = "0x2ABB240", VA = "0x182ABC640", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC840", Offset = "0x2ABB440", VA = "0x182ABC840", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC620", Offset = "0x2ABB220", VA = "0x182ABC620")]
	public int OIMLPEECHCL(SceneTag IEGFBJCKFAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC090", Offset = "0x2ABAC90", VA = "0x182ABC090")]
	public int DFKHICOABHK(SceneTag IEGFBJCKFAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC400", Offset = "0x2ABB000", VA = "0x182ABC400")]
	protected void NIPAKIJLNID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC2F0", Offset = "0x2ABAEF0", VA = "0x182ABC2F0")]
	protected void LIOIFCBKAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC040", Offset = "0x2ABAC40", VA = "0x182ABC040")]
	public global::GHKNLLBEIFC<Entity> CFCDBAGNCHM(SceneTag IEGFBJCKFAP, Allocator PBEDBDBGIPF = Allocator.TempJob)
	{
		return default(global::GHKNLLBEIFC<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x2ABBFF0", Offset = "0x2ABABF0", VA = "0x182ABBFF0")]
	public global::GHKNLLBEIFC<Entity> CEMDAALKEKD(SceneTag IEGFBJCKFAP, Allocator PBEDBDBGIPF = Allocator.TempJob)
	{
		return default(global::GHKNLLBEIFC<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC180", Offset = "0x2ABAD80", VA = "0x182ABC180")]
	public bool FPMPGMBNCIH(SceneTag IEGFBJCKFAP, out global::GHKNLLBEIFC<Entity> DPCGPJIEFDH, Allocator PBEDBDBGIPF = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC0B0", Offset = "0x2ABACB0", VA = "0x182ABC0B0")]
	public bool FEOLDMHKLBA(Entity LLEBIIAHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC110", Offset = "0x2ABAD10", VA = "0x182ABC110")]
	public IAEGHKEFOHF FPCGIAGCFMP(Entity LLEBIIAHFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC280", Offset = "0x2ABAE80", VA = "0x182ABC280")]
	public bool LFCLKAMJJHD(Entity LLEBIIAHFDD, out BIAPBKCCAGM DPCGPJIEFDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC860", Offset = "0x2ABB460", VA = "0x182ABC860")]
	public void PLNMOHEFKNP(Entity LLEBIIAHFDD, BIAPBKCCAGM DPCGPJIEFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC210", Offset = "0x2ABAE10", VA = "0x182ABC210")]
	public bool IJLCDGHNMAI(Entity LLEBIIAHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void JJMEBKCFFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public LKENFMAMPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class JFDLIDANCMH : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private EntityQuery POPEKJKEHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private MCFPIPCNFDN KNPPOFLONHP;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x2AB14A0", Offset = "0x2AB00A0", VA = "0x182AB14A0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1560", Offset = "0x2AB0160", VA = "0x182AB1560", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1620", Offset = "0x2AB0220", VA = "0x182AB1620", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x2333B40", Offset = "0x2332740", VA = "0x182333B40")]
	private bool KFPEIBMAEHO<TComponentData>(EntityQuery NJIBLOIMOJA, out NativeArray<Entity> FNMNPGEEPJI, out NativeArray<TComponentData> ECOKHAGGAGC) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x2AB14F0", Offset = "0x2AB00F0", VA = "0x182AB14F0")]
	public IAEGHKEFOHF FPCGIAGCFMP(Entity LLEBIIAHFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public JFDLIDANCMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[HFIGNCEGOKM(DDEOJCINOPG.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private EntityQuery PNAEJHOPFDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private EntityQuery KFHNDIBEENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private EntityQuery NCEEBAEOJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private EntityQuery HBIOBHKPEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private MCFPIPCNFDN KNPPOFLONHP;

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x2D820C0", Offset = "0x2D80CC0", VA = "0x182D820C0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D82550", Offset = "0x2D81150", VA = "0x182D82550", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D82780", Offset = "0x2D81380", VA = "0x182D82780", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D82180", Offset = "0x2D80D80", VA = "0x182D82180")]
		private void ELGBPIMHCCH(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x2D82110", Offset = "0x2D80D10", VA = "0x182D82110")]
		private void DOHHNJJEEIG(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x2D82710", Offset = "0x2D81310", VA = "0x182D82710", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x2D821F0", Offset = "0x2D80DF0", VA = "0x182D821F0")]
		private void MAGDOKEIOLO(EntityQuery NJIBLOIMOJA, bool FAGHFMDMOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class OCFBAMKGADC : OMEJOMKMFOF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct BCGFLCINPFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		public BCGFLCINPFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct MAHAKJJNADM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private struct ICNIOPCAAPG
		{
			[Cpp2IlInjected.Token(Token = "0x20000F5")]
			[NoAlias]
			public struct INAEPEIDOMM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime KJDNJGHMKDP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime HONJKPDEJMP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime NAOALIJILCM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity NDDHLDNOMOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> JDEONMJKGNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> FIPNHLJNNML;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x3DD9740", Offset = "0x3DD8340", VA = "0x183DD9740")]
			public void GKLJKDAGGIM(OCFBAMKGADC GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x3DD97C0", Offset = "0x3DD83C0", VA = "0x183DD97C0")]
			public INAEPEIDOMM HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
			{
				return default(INAEPEIDOMM);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private ICNIOPCAAPG MOCCMIIFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ICNIOPCAAPG.INAEPEIDOMM* NKKBCHLLBEJ;

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB6E0", Offset = "0x3DDA2E0", VA = "0x183DDB6E0")]
		internal void CCKNMJAJJNM(Entity DKJMIMOCJNG, SplineShapeData KBICBGPAOHG, DynamicBuffer<LinkedEntityGroup> NFMJIELOGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB740", Offset = "0x3DDA340", VA = "0x183DDB740", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB820", Offset = "0x3DDA420", VA = "0x183DDB820")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref ICNIOPCAAPG.INAEPEIDOMM FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB810", Offset = "0x3DDA410", VA = "0x183DDB810")]
		public void GKLJKDAGGIM(OCFBAMKGADC GFHLMIDFMDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FJNHEKMHAFK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct LGDDCDBBODF
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct OLHCFIDJFAL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F8")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime IEOMMNILINE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F9")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime JCMPJDMNAKK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity FNKNFLJJJGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> NEKKPHHOMFK;

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0x3DDB1D0", Offset = "0x3DD9DD0", VA = "0x183DDB1D0")]
			public void GKLJKDAGGIM(OCFBAMKGADC GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x3DDB230", Offset = "0x3DD9E30", VA = "0x183DDB230")]
			public OLHCFIDJFAL HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
			{
				return default(OLHCFIDJFAL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public BufferFromEntity<LinkedEntityGroup> JHDHEOKGNJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private LGDDCDBBODF MOCCMIIFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LGDDCDBBODF.OLHCFIDJFAL* NKKBCHLLBEJ;

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x3DD75B0", Offset = "0x3DD61B0", VA = "0x183DD75B0")]
		internal void CCKNMJAJJNM(Entity HHODAAKNPCC, SplinePointParentData FCNFNODDPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7820", Offset = "0x3DD6420", VA = "0x183DD7820", Slot = "5")]
		public void ReadFromDisplayClass(ref BCGFLCINPFF LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7640", Offset = "0x3DD6240", VA = "0x183DD7640", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7770", Offset = "0x3DD6370", VA = "0x183DD7770")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref LGDDCDBBODF.OLHCFIDJFAL FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x3DD76E0", Offset = "0x3DD62E0", VA = "0x183DD76E0")]
		public void GKLJKDAGGIM(OCFBAMKGADC GFHLMIDFMDH, ref BCGFLCINPFF LAOMKEKPBEJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private EntityQuery NJIBLOIMOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private EntityQuery KPPEMABAKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private EntityQuery NDOMOFNHJHP;

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A801A0", Offset = "0x2A7EDA0", VA = "0x182A801A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A80250", Offset = "0x2A7EE50", VA = "0x182A80250", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public OCFBAMKGADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FF00", Offset = "0x2A7EB00", VA = "0x182A7FF00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FD60", Offset = "0x2A7E960", VA = "0x182A7FD60")]
	public static EntityQuery JFOFCMOJMOK(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FC00", Offset = "0x2A7E800", VA = "0x182A7FC00")]
	public static EntityQuery DPACNMNFPJA(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
public sealed class NCEPJJFKEPC : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private CILKMKKIBEF GMPFBLKMEOB;

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C2A0", Offset = "0x2A7AEA0", VA = "0x182A7C2A0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C300", Offset = "0x2A7AF00", VA = "0x182A7C300", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public NCEPJJFKEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class ENFEPNDNPJF : OMEJOMKMFOF, HMFGCABFMPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct FJKFMPHHEDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NativeList<CAIGEBHNCMM> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NativeList<CPMOBHMFHFP> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NativeList<CAIGEBHNCMM> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		public FJKFMPHHEDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, FJFDCFFBHDE previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
		internal void <OnUpdate>b__2(Entity entity, FJFDCFFBHDE previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct KKFNHEIAIFA : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct BBIIDEJHFFM
		{
			[Cpp2IlInjected.Token(Token = "0x20000FE")]
			[NoAlias]
			public struct GBECFIILNGG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000307")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HJBCEBNAHHG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000308")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime ALJELCDEFHG;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity DPFMNEOBEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> IODEMGPEKGC;

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2810", Offset = "0x3DD1410", VA = "0x183DD2810")]
			public void GKLJKDAGGIM(ENFEPNDNPJF GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2870", Offset = "0x3DD1470", VA = "0x183DD2870")]
			public GBECFIILNGG HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
			{
				return default(GBECFIILNGG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NativeList<CAIGEBHNCMM> FFLPKDKCKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private BBIIDEJHFFM MOCCMIIFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BBIIDEJHFFM.GBECFIILNGG* NKKBCHLLBEJ;

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A770", Offset = "0x2D79370", VA = "0x182D7A770")]
		internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, ParentData LBIAANDOGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A950", Offset = "0x2D79550", VA = "0x182D7A950", Slot = "5")]
		public void ReadFromDisplayClass(ref FJKFMPHHEDN LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A7F0", Offset = "0x2D793F0", VA = "0x182D7A7F0", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A8A0", Offset = "0x2D794A0", VA = "0x182D7A8A0")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref BBIIDEJHFFM.GBECFIILNGG FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A860", Offset = "0x2D79460", VA = "0x182D7A860")]
		public void GKLJKDAGGIM(ENFEPNDNPJF GFHLMIDFMDH, ref FJKFMPHHEDN LAOMKEKPBEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct PPAMBPDDNAI : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct BLEBAAAGCMB
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct JCNGLAHIGHG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030F")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HJBCEBNAHHG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000310")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime ALJELCDEFHG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000311")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<FJFDCFFBHDE>.Runtime KFBJOBEGLMC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity DPFMNEOBEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> IODEMGPEKGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<FJFDCFFBHDE> HDMCFHAHGEI;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x3DD3860", Offset = "0x3DD2460", VA = "0x183DD3860")]
			public void GKLJKDAGGIM(ENFEPNDNPJF GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x3DD38E0", Offset = "0x3DD24E0", VA = "0x183DD38E0")]
			public JCNGLAHIGHG HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
			{
				return default(JCNGLAHIGHG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeList<CPMOBHMFHFP> KMPFMNDJNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private BLEBAAAGCMB MOCCMIIFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BLEBAAAGCMB.JCNGLAHIGHG* NKKBCHLLBEJ;

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x2D7B8B0", Offset = "0x2D7A4B0", VA = "0x182D7B8B0")]
		internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, ParentData LBIAANDOGFM, FJFDCFFBHDE IFLDPJLJJLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D7BB00", Offset = "0x2D7A700", VA = "0x182D7BB00", Slot = "5")]
		public void ReadFromDisplayClass(ref FJKFMPHHEDN LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D7B970", Offset = "0x2D7A570", VA = "0x182D7B970", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x2D7BA20", Offset = "0x2D7A620", VA = "0x182D7BA20")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref BLEBAAAGCMB.JCNGLAHIGHG FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x2D7B9E0", Offset = "0x2D7A5E0", VA = "0x182D7B9E0")]
		public void GKLJKDAGGIM(ENFEPNDNPJF GFHLMIDFMDH, ref FJKFMPHHEDN LAOMKEKPBEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct NLHINMBKHJN : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct ADAODMDCMDE
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct DIKAFBLJGEN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000317")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HJBCEBNAHHG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000318")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<FJFDCFFBHDE>.Runtime KFBJOBEGLMC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity DPFMNEOBEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<FJFDCFFBHDE> HDMCFHAHGEI;

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x3DD2390", Offset = "0x3DD0F90", VA = "0x183DD2390")]
			public void GKLJKDAGGIM(ENFEPNDNPJF GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x3DD23F0", Offset = "0x3DD0FF0", VA = "0x183DD23F0")]
			public DIKAFBLJGEN HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
			{
				return default(DIKAFBLJGEN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<CAIGEBHNCMM> PGBKIDHBINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private ADAODMDCMDE MOCCMIIFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ADAODMDCMDE.DIKAFBLJGEN* NKKBCHLLBEJ;

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0x2D7B2F0", Offset = "0x2D79EF0", VA = "0x182D7B2F0")]
		internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, FJFDCFFBHDE IFLDPJLJJLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x2D7B4D0", Offset = "0x2D7A0D0", VA = "0x182D7B4D0", Slot = "5")]
		public void ReadFromDisplayClass(ref FJKFMPHHEDN LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x2D7B370", Offset = "0x2D79F70", VA = "0x182D7B370", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x2D7B420", Offset = "0x2D7A020", VA = "0x182D7B420")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref ADAODMDCMDE.DIKAFBLJGEN FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x2D7B3E0", Offset = "0x2D79FE0", VA = "0x182D7B3E0")]
		public void GKLJKDAGGIM(ENFEPNDNPJF GFHLMIDFMDH, ref FJKFMPHHEDN LAOMKEKPBEJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private EAAOOBCMLAD JHLIMFAOKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery AOACLMIKNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private EntityQuery NLGIFCDPJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private EntityQuery AHHPBFBFJON;

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x2FA82A0", Offset = "0x2FA6EA0", VA = "0x182FA82A0", Slot = "14")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8640", Offset = "0x2FA7240", VA = "0x182FA8640", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public ENFEPNDNPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x2FA85E0", Offset = "0x2FA71E0", VA = "0x182FA85E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8380", Offset = "0x2FA6F80", VA = "0x182FA8380")]
	public static EntityQuery ONDOKAPBINF(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8070", Offset = "0x2FA6C70", VA = "0x182FA8070")]
	public static EntityQuery MMBPKGOGPLA(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7E70", Offset = "0x2FA6A70", VA = "0x182FA7E70")]
	public static EntityQuery IPHJALNGCCJ(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[HFIGNCEGOKM(DDEOJCINOPG.Connectables)]
	public class InitializeRigidbodyExHierarchy : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private EntityQuery NJIBLOIMOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private IOABMLLFOEC KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0E30", Offset = "0x2AAFA30", VA = "0x182AB0E30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0DC0", Offset = "0x2AAF9C0", VA = "0x182AB0DC0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AB0EC0", Offset = "0x2AAFAC0", VA = "0x182AB0EC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class HFNCNBKCPDK : ParentSystemBase<ParentData, FJFDCFFBHDE, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8B90", Offset = "0x2AA7790", VA = "0x182AA8B90", Slot = "14")]
	protected override EntityQueryDesc KMNFJOOCPJF(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x7226B0", Offset = "0x7212B0", VA = "0x1807226B0", Slot = "15")]
	protected override EntityQueryDesc DFGBELAPBIC(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8BD0", Offset = "0x2AA77D0", VA = "0x182AA8BD0", Slot = "16")]
	protected override EntityQueryDesc OIHMCIJFFBN(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8B50", Offset = "0x2AA7750", VA = "0x182AA8B50", Slot = "17")]
	protected override EntityQueryDesc BECNHEEIAMJ(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8C50", Offset = "0x2AA7850", VA = "0x182AA8C50")]
	public HFNCNBKCPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x2AA8C10", Offset = "0x2AA7810", VA = "0x182AA8C10", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : OMEJOMKMFOF where ParentData : struct, IComponentData, JIGEDONNEFC where PreviousParentData : struct, IComponentData, JIGEDONNEFC where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, JIGEDONNEFC
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[BurstCompile]
		private struct NIHONCFOCLA : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter JPJBPNGOMNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter BMNMFGLABNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public NativeHashMap<Entity, int>.ParallelWriter AFLDDNAOKHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public ArchetypeChunkComponentType<PreviousParentData> JDDFHPHPDCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> AAFNCECCNIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			[ReadOnly]
			public ArchetypeChunkEntityType ICMPEKDOFDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public uint BBEIAHBPPCB;

			[Cpp2IlInjected.Token(Token = "0x6000817")]
			[Cpp2IlInjected.Address(RVA = "0x33804B0", Offset = "0x337F0B0", VA = "0x1833804B0", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000109")]
		[BurstCompile]
		private struct NEHNDAIOKBK : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeHashMap<Entity, int> AFLDDNAOKHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> FEMDBEAHDBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public NativeList<Entity> JIIBDAPJBJD;

			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0x2689CF0", Offset = "0x26888F0", VA = "0x182689CF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010A")]
		[BurstCompile]
		private struct FOIKNLGFIGJ : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> JPJBPNGOMNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> BMNMFGLABNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			[ReadOnly]
			public NativeHashMap<Entity, int> AFLDDNAOKHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public BufferFromEntity<ChildrenData> FEMDBEAHDBC;

			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0x28A2380", Offset = "0x28A0F80", VA = "0x1828A2380")]
			private int CNNLEOAMFHB(DynamicBuffer<ChildrenData> KPOBDKLHLOL, Entity LLEBIIAHFDD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x28A2110", Offset = "0x28A0D10", VA = "0x1828A2110")]
			private void CJGLMNNMMDH(Entity GEOFAMNLJNK, DynamicBuffer<ChildrenData> KPOBDKLHLOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x28A1D50", Offset = "0x28A0950", VA = "0x1828A1D50")]
			private void BPDDIFMCOHH(Entity GEOFAMNLJNK, DynamicBuffer<ChildrenData> KPOBDKLHLOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x28A2490", Offset = "0x28A1090", VA = "0x1828A2490", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct FIOIOHJHDPL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public NativeArray<Entity> DEFNGPACMKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public NativeList<Entity> AIMCOHFHBLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public BufferFromEntity<ChildrenData> FEMDBEAHDBC;

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x289B310", Offset = "0x2899F10", VA = "0x18289B310", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected EntityQuery FDHGHMMCHDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected EntityQuery NJCPICPGFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected EntityQuery FNJICEGFELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected EntityQuery ANHLEBBGCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected ProfilerMarker JDHKFABFNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected ProfilerMarker KPMKNPJCIOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected ProfilerMarker FFNFABMBAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected ProfilerMarker GJBCGOPFGIF;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x2B37AF0", Offset = "0x2B366F0", VA = "0x182B37AF0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x2B36870", Offset = "0x2B35470", VA = "0x182B36870")]
		private int CNNLEOAMFHB(DynamicBuffer<ChildrenData> KPOBDKLHLOL, Entity LLEBIIAHFDD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x2B36AC0", Offset = "0x2B356C0", VA = "0x182B36AC0")]
		private void IEJDLPBDLNA(Entity DLPPAJNBCBG, Entity FMMBMPIEFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x7226B0", Offset = "0x7212B0", VA = "0x1807226B0", Slot = "14")]
		protected virtual EntityQueryDesc KMNFJOOCPJF(EntityQueryDesc NJIBLOIMOJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x7226B0", Offset = "0x7212B0", VA = "0x1807226B0", Slot = "15")]
		protected virtual EntityQueryDesc DFGBELAPBIC(EntityQueryDesc NJIBLOIMOJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x7226B0", Offset = "0x7212B0", VA = "0x1807226B0", Slot = "16")]
		protected virtual EntityQueryDesc OIHMCIJFFBN(EntityQueryDesc NJIBLOIMOJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc BECNHEEIAMJ(EntityQueryDesc NJIBLOIMOJA);

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2B37620", Offset = "0x2B36220", VA = "0x182B37620", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2B371E0", Offset = "0x2B35DE0", VA = "0x182B371E0")]
		private void MILPLNHPLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2B359A0", Offset = "0x2B345A0", VA = "0x182B359A0")]
		private void ABGOLHEKGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2B36250", Offset = "0x2B34E50", VA = "0x182B36250")]
		private JobHandle CGAKJOEFILD(JobHandle EJNAMLGMMHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2B36C20", Offset = "0x2B35820", VA = "0x182B36C20")]
		private void IOAFOKPCOJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x2B378C0", Offset = "0x2B364C0", VA = "0x182B378C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x2685EE0", Offset = "0x2684AE0", VA = "0x182685EE0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x2699F90", Offset = "0x2698B90", VA = "0x182699F90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[AlwaysUpdateSystem]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
public abstract class LJGIGCFJLFM : OMEJOMKMFOF, HMFGCABFMPC
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private struct JPBFOBKCIFA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public global::BNGAOKMFDEK<Entity> BGOPNGOGNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public global::BNGAOKMFDEK<Entity> LDKKKOFAPHG;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA610", Offset = "0x3DD9210", VA = "0x183DDA610")]
		public JPBFOBKCIFA(NativeList<Entity> BGOPNGOGNMD, NativeList<Entity> LDKKKOFAPHG, JobHandle BLJNDDIDOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA590", Offset = "0x3DD9190", VA = "0x183DDA590")]
		public JobHandle MDPLMPHJHML(JobHandle EJNAMLGMMHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA500", Offset = "0x3DD9100", VA = "0x183DDA500", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct DINOKMPDDOL : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[Flags]
		public enum MFLNLIHIGND
		{
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[WriteOnly]
		public NativeList<Entity> FMCNIEHAJCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[WriteOnly]
		public NativeList<Entity> HKEPNPHKOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[ReadOnly]
		public NativeArray<Entity> OCMHNPJDCKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> KKJOINPPLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[ReadOnly]
		public LFHLPPKAALB NJOPFHLKMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		[ReadOnly]
		public LFHLPPKAALB MGMEACPEOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> BLDENJJECIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int CPENMJDOBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int MCNFPOMOGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private MFLNLIHIGND PBGJMONMPOE;

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5170", Offset = "0x3DD3D70", VA = "0x183DD5170", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x3DD58B0", Offset = "0x3DD44B0", VA = "0x183DD58B0")]
		private void PJODJMLCDBC(Entity LLEBIIAHFDD, bool JEJKGBFFNJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5460", Offset = "0x3DD4060", VA = "0x183DD5460")]
		private void IJCCAEFIBII(Entity LLEBIIAHFDD, bool JEJKGBFFNJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x3DD53E0", Offset = "0x3DD3FE0", VA = "0x183DD53E0")]
		public JPBFOBKCIFA GLPPOHEIFIM(NativeArray<Entity> DFMCPPMHIBK, JobHandle EJNAMLGMMHG)
		{
			return default(JPBFOBKCIFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5010", Offset = "0x3DD3C10", VA = "0x183DD5010")]
		public JPBFOBKCIFA ANHAMADLBCO(NativeArray<Entity> DFMCPPMHIBK, JobHandle EJNAMLGMMHG)
		{
			return default(JPBFOBKCIFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5570", Offset = "0x3DD4170", VA = "0x183DD5570")]
		public JPBFOBKCIFA JPFLOEMDDNE(NativeList<CAIGEBHNCMM> LENGKEKMOEB, JobHandle EJNAMLGMMHG)
		{
			return default(JPBFOBKCIFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5090", Offset = "0x3DD3C90", VA = "0x183DD5090")]
		public JPBFOBKCIFA DFJAJFEBJLD(NativeList<CAIGEBHNCMM> LENGKEKMOEB, JobHandle EJNAMLGMMHG)
		{
			return default(JPBFOBKCIFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5300", Offset = "0x3DD3F00", VA = "0x183DD5300")]
		public JPBFOBKCIFA FOCGLMOBLMC(NativeList<CPMOBHMFHFP> LENGKEKMOEB, JobHandle EJNAMLGMMHG)
		{
			return default(JPBFOBKCIFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x344CAD0", Offset = "0x344B6D0", VA = "0x18344CAD0")]
		private JPBFOBKCIFA ONNDOAPHHCA<T>(NativeList<T> LENGKEKMOEB, int BNNFILIACEF, int GDENOEMAIPG, MFLNLIHIGND GGBPGDBFPKJ, JobHandle EJNAMLGMMHG) where T : struct
		{
			return default(JPBFOBKCIFA);
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5650", Offset = "0x3DD4250", VA = "0x183DD5650")]
		private JPBFOBKCIFA ONNDOAPHHCA(NativeArray<Entity> FNMNPGEEPJI, int BNNFILIACEF, int GDENOEMAIPG, MFLNLIHIGND GGBPGDBFPKJ, JobHandle EJNAMLGMMHG)
		{
			return default(JPBFOBKCIFA);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly FNIDFMEJGMB CBDAGBGGFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private EntityQuery CBNPEAFIOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private EntityQuery DDKHCDIJPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private EAAOOBCMLAD HDCBAOLAIGN;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	protected abstract ComponentType EHLMHLBPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	protected abstract ComponentType FNGLFBHNMKO
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	protected abstract ComponentType LPDOHFENIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x2ABBF40", Offset = "0x2ABAB40", VA = "0x182ABBF40")]
	protected LJGIGCFJLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x2ABADC0", Offset = "0x2AB99C0", VA = "0x182ABADC0", Slot = "14")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x2ABAEA0", Offset = "0x2AB9AA0", VA = "0x182ABAEA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x2ABB0D0", Offset = "0x2AB9CD0", VA = "0x182ABB0D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x780510", Offset = "0x77F110", VA = "0x180780510", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA8C0", Offset = "0x2AB94C0", VA = "0x182ABA8C0")]
	private void FCEAHEFJBGK(NativeArray<Entity> LENGKEKMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA7B0", Offset = "0x2AB93B0", VA = "0x182ABA7B0")]
	private void ADCADDCEGNA(NativeArray<Entity> LENGKEKMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x2ABAA30", Offset = "0x2AB9630", VA = "0x182ABAA30")]
	private void FNOMJHMMMIG(JPBFOBKCIFA HKNNJLCHMPE, string CGPGGBMCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA920", Offset = "0x2AB9520", VA = "0x182ABA920")]
	private void FNOMJHMMMIG(global::BNGAOKMFDEK<Entity> NEFMOGMOOKN, string CGPGGBMCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x2ABAC80", Offset = "0x2AB9880", VA = "0x182ABAC80")]
	private void JIOJBEBHCKG(JPBFOBKCIFA HKNNJLCHMPE, string CGPGGBMCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x2ABAB70", Offset = "0x2AB9770", VA = "0x182ABAB70")]
	private void JIOJBEBHCKG(global::BNGAOKMFDEK<Entity> NEFMOGMOOKN, string CGPGGBMCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA850", Offset = "0x2AB9450", VA = "0x182ABA850")]
	private bool ADGCEBFMOHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
public class PJHOJCPLAHI : OMEJOMKMFOF, OHFJHEDBJHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct GDIOHBOLPCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public PJHOJCPLAHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		public GDIOHBOLPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MFKNLGIMIDE : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct FEFHHJFNOAN
		{
			[Cpp2IlInjected.Token(Token = "0x2000114")]
			public struct PIKFGOMOAEF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000358")]
				public LambdaParameterValueProvider_Entity.Runtime EIGPGFJGJDE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity IPGOFDADNGH;

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x3DD6A80", Offset = "0x3DD5680", VA = "0x183DD6A80")]
			public void GKLJKDAGGIM(PJHOJCPLAHI GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x3DD6A90", Offset = "0x3DD5690", VA = "0x183DD6A90")]
			public PIKFGOMOAEF HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
			{
				return default(PIKFGOMOAEF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public PJHOJCPLAHI MLNDFFFPEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public EntityCommandBuffer GPAIMNJDCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private FEFHHJFNOAN MOCCMIIFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FEFHHJFNOAN.PIKFGOMOAEF* NKKBCHLLBEJ;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate ENKNKDHOKFC;

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC330", Offset = "0x3DDAF30", VA = "0x183DDC330")]
		internal void CCKNMJAJJNM(Entity AENGIJLJHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAC00", Offset = "0x3DD9800", VA = "0x183DDAC00", Slot = "5")]
		public void ReadFromDisplayClass(ref GDIOHBOLPCJ LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAC30", Offset = "0x3DD9830", VA = "0x183DDAC30", Slot = "6")]
		public void WriteToDisplayClass(ref GDIOHBOLPCJ LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC440", Offset = "0x3DDB040", VA = "0x183DDC440", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC540", Offset = "0x3DDB140", VA = "0x183DDC540")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, ref FEFHHJFNOAN.PIKFGOMOAEF FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC500", Offset = "0x3DDB100", VA = "0x183DDC500")]
		public void GKLJKDAGGIM(PJHOJCPLAHI GFHLMIDFMDH, ref GDIOHBOLPCJ LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC490", Offset = "0x3DDB090", VA = "0x183DDC490")]
		public unsafe static void FIKCEGMOMMK(ArchetypeChunkIterator* NKPBBGCKHML, void* MOGAJEFFDEG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private FKIFMBMBEBM JCCPCLEEMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private NPHLGLMBAHC OKOFKHFHDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private EntityQuery EODGINOANKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private ProfilerMarker IBJFANJCOJM;

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x2A90F30", Offset = "0x2A8FB30", VA = "0x182A90F30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2A90C20", Offset = "0x2A8F820", VA = "0x182A90C20", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2A90F90", Offset = "0x2A8FB90", VA = "0x182A90F90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public PJHOJCPLAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2A90E50", Offset = "0x2A8FA50", VA = "0x182A90E50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x2A90C80", Offset = "0x2A8F880", VA = "0x182A90C80")]
	public static EntityQuery FBKBEGHMLNL(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[GDGGJDPAMIC]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
public class FLFJFOAOHPA : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private NPHLGLMBAHC OKOFKHFHDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private SceneService OIICOGEJBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private EntityQuery NJIBLOIMOJA;

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA43A0", Offset = "0x2AA2FA0", VA = "0x182AA43A0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4410", Offset = "0x2AA3010", VA = "0x182AA4410", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA44B0", Offset = "0x2AA30B0", VA = "0x182AA44B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public FLFJFOAOHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public struct OKCMKDFJJHK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public PFMNCAAGPOA DKBLPJPHEMF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675C00", VA = "0x180677000")]
	public static OKCMKDFJJHK KPOCFOKDNEC(in PFMNCAAGPOA FIGEMIBODDE)
	{
		return default(OKCMKDFJJHK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675C00", VA = "0x180677000")]
	public static PFMNCAAGPOA KPOCFOKDNEC(in OKCMKDFJJHK FIJFGEJAEBG)
	{
		return default(PFMNCAAGPOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[AlwaysUpdateSystem]
public class FKIFMBMBEBM : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x2AA40D0", Offset = "0x2AA2CD0", VA = "0x182AA40D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0")]
	public FKIFMBMBEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[AlwaysUpdateSystem]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
public class GDKDJKHEADC : OMEJOMKMFOF, OHFJHEDBJHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct BPHJHBCHANF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public GDKDJKHEADC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		public BPHJHBCHANF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
		internal void <OnUpdate>b__0(Entity e, OKCMKDFJJHK ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct KLHEABOBGJG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct FEOLMAMJJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x200011C")]
			public struct AHGIKLPDEOH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public LambdaParameterValueProvider_Entity.Runtime EIGPGFJGJDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_IComponentData<OKCMKDFJJHK>.Runtime LPCOMILLCMA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity IPGOFDADNGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<OKCMKDFJJHK> NKPJBHFJIJH;

			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0x3DD6AA0", Offset = "0x3DD56A0", VA = "0x183DD6AA0")]
			public void GKLJKDAGGIM(GDKDJKHEADC GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x3DD6B00", Offset = "0x3DD5700", VA = "0x183DD6B00")]
			public AHGIKLPDEOH HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
			{
				return default(AHGIKLPDEOH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public GDKDJKHEADC MLNDFFFPEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer GPAIMNJDCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private FEOLMAMJJFJ MOCCMIIFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FEOLMAMJJFJ.AHGIKLPDEOH* NKKBCHLLBEJ;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate ENKNKDHOKFC;

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA8B0", Offset = "0x3DD94B0", VA = "0x183DDA8B0")]
		internal void CCKNMJAJJNM(Entity AENGIJLJHJA, OKCMKDFJJHK JCHECGJKGFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAC00", Offset = "0x3DD9800", VA = "0x183DDAC00", Slot = "5")]
		public void ReadFromDisplayClass(ref BPHJHBCHANF LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAC30", Offset = "0x3DD9830", VA = "0x183DDAC30", Slot = "6")]
		public void WriteToDisplayClass(ref BPHJHBCHANF LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA9B0", Offset = "0x3DD95B0", VA = "0x183DDA9B0", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAB50", Offset = "0x3DD9750", VA = "0x183DDAB50")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, ref FEOLMAMJJFJ.AHGIKLPDEOH FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAAC0", Offset = "0x3DD96C0", VA = "0x183DDAAC0")]
		public void GKLJKDAGGIM(GDKDJKHEADC GFHLMIDFMDH, ref BPHJHBCHANF LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAA50", Offset = "0x3DD9650", VA = "0x183DDAA50")]
		public unsafe static void FIKCEGMOMMK(ArchetypeChunkIterator* NKPBBGCKHML, void* MOGAJEFFDEG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private FKIFMBMBEBM JCCPCLEEMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private NPHLGLMBAHC OKOFKHFHDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery LEJGFANEGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private ProfilerMarker HNHAFODBFAG;

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5250", Offset = "0x2AA3E50", VA = "0x182AA5250", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4F40", Offset = "0x2AA3B40", VA = "0x182AA4F40", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x2AA52B0", Offset = "0x2AA3EB0", VA = "0x182AA52B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public GDKDJKHEADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5170", Offset = "0x2AA3D70", VA = "0x182AA5170", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4FA0", Offset = "0x2AA3BA0", VA = "0x182AA4FA0")]
	public static EntityQuery JIMIOIOMCLC(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct MBEHLICOOJE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public NNEFJHMAAJD KKELBBDIJCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeHashMap<Entity, OIGDPEFJPLN> FNMNPGEEPJI;

			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0x3DDBCB0", Offset = "0x3DDA8B0", VA = "0x183DDBCB0")]
			public MBEHLICOOJE(int BPGPHKEJPBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x3DDBC30", Offset = "0x3DDA830", VA = "0x183DDBC30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[BurstCompile]
		private struct NGBGNGLKAGO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			[ReadOnly]
			public NativeArray<Entity> FNMNPGEEPJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> FMEJNAGGOAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> LNCHJDKJJKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> CFKFCBEGCBL;

			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0x3DDC9F0", Offset = "0x3DDB5F0", VA = "0x183DDC9F0", Slot = "4")]
			public void Execute(int BNNEENLPEFO, TransformAccess KAMDPLLJPAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000120")]
		[BurstCompile]
		private struct CPDGHOOENME : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			public NativeArray<Entity> FNMNPGEEPJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> FMEJNAGGOAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> CFKFCBEGCBL;

			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4810", Offset = "0x3DD3410", VA = "0x183DD4810", Slot = "4")]
			public void Execute(int BNNEENLPEFO, TransformAccess KAMDPLLJPAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private NPHLGLMBAHC OKOFKHFHDED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private EntityQuery PNLNHPIOEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private EntityQuery BAFJGMPINLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private EntityQuery FNNDHPGFOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private EntityQuery HIGJFHPLLKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private EntityQuery ONPINIJLEAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private JobHandle JCCGEIDNOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private MBEHLICOOJE JBIOKPBKCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private MBEHLICOOJE NAJMHDOOBAH;

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x2A948B0", Offset = "0x2A934B0", VA = "0x182A948B0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x2A953B0", Offset = "0x2A93FB0", VA = "0x182A953B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x2A95370", Offset = "0x2A93F70", VA = "0x182A95370", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x2A95670", Offset = "0x2A94270", VA = "0x182A95670", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x2A95100", Offset = "0x2A93D00", VA = "0x182A95100")]
		private void MOHJPMKJPCG(EntityQuery NJIBLOIMOJA, out (global::GHKNLLBEIFC<OKCMKDFJJHK> handles, global::GHKNLLBEIFC<FLJBFMJPKBF> bounds) JLFCOOGLPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x2A94910", Offset = "0x2A93510", VA = "0x182A94910")]
		private void COEELGENAKB((global::GHKNLLBEIFC<OKCMKDFJJHK> handles, global::GHKNLLBEIFC<FLJBFMJPKBF> bounds) JLFCOOGLPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x2A95370", Offset = "0x2A93F70", VA = "0x182A95370")]
		private void ONKAEICCGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x2A94B70", Offset = "0x2A93770", VA = "0x182A94B70")]
		private void DPBOPIFFMDB(EntityQuery NJIBLOIMOJA, out (global::GHKNLLBEIFC<Entity> entities, global::GHKNLLBEIFC<OKCMKDFJJHK> handles) JLFCOOGLPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x2A94CB0", Offset = "0x2A938B0", VA = "0x182A94CB0")]
		private void FGLAHCNPFIC((global::GHKNLLBEIFC<Entity> entities, global::GHKNLLBEIFC<OKCMKDFJJHK> handles) JLFCOOGLPMP, MBEHLICOOJE GJJAOAGKAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x2A94FA0", Offset = "0x2A93BA0", VA = "0x182A94FA0")]
		private JobHandle JEMOEGDGDKM(MBEHLICOOJE GJJAOAGKAFC, ComponentDataFromEntity<WorldPoseData> FMEJNAGGOAC, ComponentDataFromEntity<WorldUniformScaleData> CFKFCBEGCBL, ComponentDataFromEntity<WorldDeformableScaleData> LNCHJDKJJKJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x2A95240", Offset = "0x2A93E40", VA = "0x182A95240")]
		private JobHandle NOELHBNEEBB(MBEHLICOOJE GJJAOAGKAFC, ComponentDataFromEntity<WorldPoseData> FMEJNAGGOAC, ComponentDataFromEntity<WorldUniformScaleData> CFKFCBEGCBL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
public struct CFKBMGFCBHG : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[GDGGJDPAMIC]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	public class SplineLocalBoundsSystem : OMEJOMKMFOF
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct CMJHMJIPBNL : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			[ReadOnly]
			public NativeArray<Entity> MMHOCJBIMKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> HKGHMPNEKLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			[ReadOnly]
			public ComponentDataFromEntity<FLJBFMJPKBF> LAIDPLPMLFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			[WriteOnly]
			public NativeHashMap<Entity, OIGDPEFJPLN>.ParallelWriter IHJIJMGPNKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter HALCBFNDGCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter FPNFNLDACEF;

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x3DD3C80", Offset = "0x3DD2880", VA = "0x183DD3C80", Slot = "4")]
			public void Execute(int BNNEENLPEFO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[BurstCompile]
		private struct HIDEKIAIMDD : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			[ReadOnly]
			public NativeArray<Entity> HNDAGLDOMJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> LOGHJCBBGLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> KFHBJGHAHGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> DPEELJNKMNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<FLJBFMJPKBF> EOLAHLFLJPJ;

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0x3DD9470", Offset = "0x3DD8070", VA = "0x183DD9470", Slot = "4")]
			public void Execute(int BNNEENLPEFO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private EntityQuery DJFLPEAAFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery NOOALDGJMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery NDOGONPEFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery ICOHGABGEFD;

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x2D84B80", Offset = "0x2D83780", VA = "0x182D84B80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x2D84D90", Offset = "0x2D83990", VA = "0x182D84D90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x2D841F0", Offset = "0x2D82DF0", VA = "0x182D841F0")]
		private JobHandle EJMNAMHHDFJ(global::GHKNLLBEIFC<Entity> EJLDCNGHIAK, int PMIIGNOLFGJ, JobHandle EJNAMLGMMHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x2D842D0", Offset = "0x2D82ED0", VA = "0x182D842D0")]
		private JobHandle EJMNAMHHDFJ(NativeArray<Entity> MPLOHGHLFIE, int PMIIGNOLFGJ, [Optional] JobHandle EJNAMLGMMHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x2D846A0", Offset = "0x2D832A0", VA = "0x182D846A0")]
		private global::GHKNLLBEIFC<Entity> GFDPMPHDEBP(EntityQuery NJIBLOIMOJA)
		{
			return default(global::GHKNLLBEIFC<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x2D83DA0", Offset = "0x2D829A0", VA = "0x182D83DA0")]
		private (global::BNGAOKMFDEK<Entity>, global::BNGAOKMFDEK<Entity>) CEAGKDLCKOB(global::GHKNLLBEIFC<Entity> GNLLMPHHBAI)
		{
			return default((global::BNGAOKMFDEK<Entity>, global::BNGAOKMFDEK<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x2D84610", Offset = "0x2D83210", VA = "0x182D84610")]
		private void FONIGCOJPFG(out NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2D844B0", Offset = "0x2D830B0", VA = "0x182D844B0")]
		private void FABPGIGHDKN(NativeList<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2D84540", Offset = "0x2D83140", VA = "0x182D84540")]
		private void FABPGIGHDKN(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2D84720", Offset = "0x2D83320", VA = "0x182D84720")]
		private void KEAEMIIKAFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		private static void CDABGPLFCCF(int ODCNHGKPGHB, int KHINMIBBGKB, int DDECJHOFPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2D84850", Offset = "0x2D83450", VA = "0x182D84850")]
		private static FLJBFMJPKBF LOEDCDGJJNE(NativeArray<Entity> GPHNKPFOGNC, ComponentDataFromEntity<SplinePointPositionData> KFHBJGHAHGO, ComponentDataFromEntity<SplinePointScaleData> DPEELJNKMNF)
		{
			return default(FLJBFMJPKBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct CEBAIDADFLN : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[GDGGJDPAMIC]
	[HFIGNCEGOKM(DDEOJCINOPG.Lifecycle)]
	public class DestroyLocalObjects : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		[NHBEJKCIJLO]
		private ObjectNetworkToLocalMapService LDFFPBKCNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		[NHBEJKCIJLO]
		private ObjectLifecycleService KOGKJOIDDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private EntityQuery BLPHALHOPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery NKJJLPFHGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery HBIOBHKPEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private bool IBOHJGMEBIO;

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA6090", Offset = "0x2FA4C90", VA = "0x182FA6090", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x2FA6100", Offset = "0x2FA4D00", VA = "0x182FA6100")]
		public bool EGOLEHHFAKF(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x2FA6560", Offset = "0x2FA5160", VA = "0x182FA6560", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x2FA61B0", Offset = "0x2FA4DB0", VA = "0x182FA61B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x2FA6690", Offset = "0x2FA5290", VA = "0x182FA6690", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xFD8AC0", Offset = "0xFD76C0", VA = "0x180FD8AC0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x2FA61B0", Offset = "0x2FA4DB0", VA = "0x182FA61B0")]
		private void GHHONKIACMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2FA66B0", Offset = "0x2FA52B0", VA = "0x182FA66B0")]
		private void PFCBDIAFFJH(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2FA6420", Offset = "0x2FA5020", VA = "0x182FA6420")]
		private void MEDBDGAOKAK(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2FA61F0", Offset = "0x2FA4DF0", VA = "0x182FA61F0")]
		private void GHMIAIGFAAN(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2FA6300", Offset = "0x2FA4F00", VA = "0x182FA6300")]
		private void HCHAJOEFLAN(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.NetworkSend)]
	public sealed class EnqueuePropertyDifferenceToNetwork : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private static DBJHEIPMAIM[] IHAKELJEGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private HHDBMEKKBLC NFIAIKMJJBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private MGNHPFHGDHE GACAPANDCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private PropertyDiffStateService MJKCKKJPBKL;

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1690", Offset = "0x2AA0290", VA = "0x182AA1690", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1CD0", Offset = "0x2AA08D0", VA = "0x182AA1CD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1740", Offset = "0x2AA0340", VA = "0x182AA1740")]
		private void MMOHCPKMKHH(DBJHEIPMAIM FGMCPHKBIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		private void BKLEIIACPDF(Entity LLEBIIAHFDD, ELJHNEOGEBP FFJHOAAMJMD, FPHEKKDEPIJ LGPKKGCJHDG, GEKCNMCMNCD DCGEEIGCBII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[HFIGNCEGOKM(DDEOJCINOPG.Callbacks)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	public sealed class PropertyEventCallbacks : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private PropertyEventCallbacksService JFENCDCNGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private PropertyDiffStateService MJKCKKJPBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TransformOwnershipPhase FGMCPHKBIAK;

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B540", Offset = "0x2A9A140", VA = "0x182A9B540", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B5D0", Offset = "0x2A9A1D0", VA = "0x182A9B5D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[HFIGNCEGOKM(DDEOJCINOPG.NetworkSend)]
	internal class TransmitNetworkDataSystem : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private HBEDANEOEFD PCJNBNNIDGF;

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C190", Offset = "0x2D8AD90", VA = "0x182D8C190", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C1E0", Offset = "0x2D8ADE0", VA = "0x182D8C1E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[GDGGJDPAMIC]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	public class CalculateCullingBandChanges : OMEJOMKMFOF, KGABHKADGEM, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[BurstCompile]
		private struct LMHMGEKGJME : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			[ReadOnly]
			public ArchetypeChunkEntityType BJCBKAEMEEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> EBAGMFIBAAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			[WriteOnly]
			public NativeList<HPLOFGACNGG>.ParallelWriter BNIGCDEFHPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public ArchetypeChunkComponentType<ADOODLDAMIP> LLMMIJJKFNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public float3 EHPFANFOFFJ;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private static readonly float4x2 HBEKOKCHIKH;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private static readonly float4x2 KJAIBOAKFFB;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			private static readonly int4x2 PLBOKPPMHOD;

			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x2D7AB70", Offset = "0x2D79770", VA = "0x182D7AB70", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private static FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private const int BIHBPIIMAGE = 10;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private const double OEKCIGIDIOG = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private EntityQuery PDIDKOMGGDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private EntityQuery GCLNIGLMJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private double EHLLHLODPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private MCFPIPCNFDN KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private CullingBandService FLMIEJDEEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private TimeService MHIJNFDOFCE;

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2F98020", Offset = "0x2F96C20", VA = "0x182F98020", Slot = "14")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x2F97F20", Offset = "0x2F96B20", VA = "0x182F97F20", Slot = "15")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2F98370", Offset = "0x2F96F70", VA = "0x182F98370", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2F984C0", Offset = "0x2F970C0", VA = "0x182F984C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2F97FB0", Offset = "0x2F96BB0", VA = "0x182F97FB0")]
		private bool IMEPHINCBHD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2F98030", Offset = "0x2F96C30", VA = "0x182F98030")]
		private void OONPEMBDCCG(EntityQuery NJIBLOIMOJA, float3 BPHNMAGMINJ, string NLCIGFDKGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public struct HPLOFGACNGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public Entity LLEBIIAHFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public ENBFOGEPFIO KNAEAKFNOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public ENBFOGEPFIO OCBHJKLFMDP;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	public class ProcessCullingBandChangeCallbacks : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private CullingBandService FLMIEJDEEIG;

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x2A97FF0", Offset = "0x2A96BF0", VA = "0x182A97FF0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x2A98040", Offset = "0x2A96C40", VA = "0x182A98040", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[HFIGNCEGOKM(DDEOJCINOPG.Connectables)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	public class UpdateInertialProperties : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private EntityQuery MODOCJEIBNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private AOFPJJGNONH PPEDAJLKCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x2D92BA0", Offset = "0x2D917A0", VA = "0x182D92BA0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x2D92C10", Offset = "0x2D91810", VA = "0x182D92C10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2D92CA0", Offset = "0x2D918A0", VA = "0x182D92CA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[GDGGJDPAMIC]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> FCMEBBFFNJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> APAPHOMLDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DBHKOMFEPDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private KinematicSleepChangeService LOACGHHAGAK;

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0040", Offset = "0x2A9EC40", VA = "0x182AA0040", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1040", Offset = "0x2A9FC40", VA = "0x182AA1040", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0810", Offset = "0x2A9F410", VA = "0x182AA0810")]
		private void JDHDBMBFMMN(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> LENGKEKMOEB, EntityQueryDesc LPEILMOBCMF, bool GKFAIECOKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0920", Offset = "0x2A9F520", VA = "0x182AA0920")]
		private void JDHDBMBFMMN(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> LENGKEKMOEB, EntityQueryDesc LPEILMOBCMF, bool GKFAIECOKJO, bool HOCGGBCFNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA12A0", Offset = "0x2A9FEA0", VA = "0x182AA12A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0090", Offset = "0x2A9EC90", VA = "0x182AA0090")]
		private void CGNMHNNEAKM(EntityQuery NJIBLOIMOJA, bool JMFJCLLHFFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0D10", Offset = "0x2A9F910", VA = "0x182AA0D10")]
		private void LLPDOKCFHAG(EntityQuery NJIBLOIMOJA, bool KOOGAHOBCMH, bool JMFJCLLHFFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0AF0", Offset = "0x2A9F6F0", VA = "0x182AA0AF0")]
		private void LBAOEFLAGEE(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA02C0", Offset = "0x2A9EEC0", VA = "0x182AA02C0")]
		private void DLAPJPFJGPO(NativeList<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0F20", Offset = "0x2A9FB20", VA = "0x182AA0F20")]
		private void NIJGPHBNDIC(NativeArray<Entity> FNMNPGEEPJI, bool KOOGAHOBCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0610", Offset = "0x2A9F210", VA = "0x182AA0610")]
		private NativeList<Entity> JDDJHOCCIJI(NativeArray<Entity> FNMNPGEEPJI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0430", Offset = "0x2A9F030", VA = "0x182AA0430")]
		private NativeList<Entity> DLGIKPOMAAB(NativeArray<Entity> FNMNPGEEPJI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0280", Offset = "0x2A9EE80", VA = "0x182AA0280")]
		private NativeList<Entity> DKCLABOMMJP(NativeArray<Entity> FNMNPGEEPJI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0470", Offset = "0x2A9F070", VA = "0x182AA0470")]
		private NativeList<Entity> FKHBPBKOEBP(NativeArray<Entity> FNMNPGEEPJI, bool LMFDLFNFMAH)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AA0A60", Offset = "0x2A9F660", VA = "0x182AA0A60")]
		private LDFOFEBKOEG JIBHLMACMGI(NativeArray<Entity> FNMNPGEEPJI)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(LDFOFEBKOEG);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AA15C0", Offset = "0x2AA01C0", VA = "0x182AA15C0")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private KinematicSleepChangeService LOACGHHAGAK;

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x2A98060", Offset = "0x2A96C60", VA = "0x182A98060", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x2A980B0", Offset = "0x2A96CB0", VA = "0x182A980B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : HKNPFPHAGAE
	{
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private static FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery OKFEDBFMFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EntityQuery MCNLEAOMLIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private EntityQuery HJGPPNBIMCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private EntityQuery OBLJLJBHGHA;

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5D00", Offset = "0x2FA4900", VA = "0x182FA5D00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5EC0", Offset = "0x2FA4AC0", VA = "0x182FA5EC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5880", Offset = "0x2FA4480", VA = "0x182FA5880")]
		private void GBIEMMHFGJA(EntityQuery NJIBLOIMOJA, bool JJPEDAIHJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x2FA5AC0", Offset = "0x2FA46C0", VA = "0x182FA5AC0")]
		private void GMAAJIEKJGA(EntityQuery NJIBLOIMOJA, bool JJPEDAIHJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[HFIGNCEGOKM(DDEOJCINOPG.Scope)]
	internal class AssignPlayerIdsSystem : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private MCFPIPCNFDN KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private EntityQuery LBAAOIDFEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private EntityQuery EAOEALGHAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private SceneService HMMCBLIILHF;

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F600", Offset = "0x2F8E200", VA = "0x182F8F600", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x2F8FEC0", Offset = "0x2F8EAC0", VA = "0x182F8FEC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x2F8FFD0", Offset = "0x2F8EBD0", VA = "0x182F8FFD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x2F8FDB0", Offset = "0x2F8E9B0", VA = "0x182F8FDB0")]
		private void IFANCMBEGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F9F0", Offset = "0x2F8E5F0", VA = "0x182F8F9F0")]
		private void FLGKKHFNHBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F6D0", Offset = "0x2F8E2D0", VA = "0x182F8F6D0")]
		private void DKJEHDCIIJF(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x2F8FC70", Offset = "0x2F8E870", VA = "0x182F8FC70")]
		private void HOELLFFGPMK(NativeArray<Entity> FNMNPGEEPJI, int CDFPGFBELGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x2F8FB60", Offset = "0x2F8E760", VA = "0x182F8FB60")]
		private void GAKAFHGMGKD(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F670", Offset = "0x2F8E270", VA = "0x182F8F670")]
		private void AFGIBOODMBK(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		private static void EIBIMOBJDNI(int DEPHGHGHIPL, Transform KAMDPLLJPAH, Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class ALCBKEFFPIP
{
	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D440", Offset = "0x2F8C040", VA = "0x182F8D440")]
	public static bool BLFCGNAADKF(this SystemBase AKNBNHOMNEL, out Entity LLEBIIAHFDD)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery LFOGJNCHHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private LHNBKEDDAHF AAPCJGGAIHF;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x2F99DB0", Offset = "0x2F989B0", VA = "0x182F99DB0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2F99E00", Offset = "0x2F98A00", VA = "0x182F99E00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x2F99EC0", Offset = "0x2F98AC0", VA = "0x182F99EC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[HFIGNCEGOKM(DDEOJCINOPG.Scope)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<EJKOCDNNPFI>, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private const string CPDGEFBBCIP = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private IAEAFPAPBEN HIODAMNALPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EntityQuery MKBKHNIPFGE;

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		private Entity AMINNFHAGAO
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD6D0", Offset = "0x2ABC2D0", VA = "0x182ABD6D0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD860", Offset = "0x2ABC460", VA = "0x182ABD860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		private Entity IOMKCLJBFAF
		{
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD8C0", Offset = "0x2ABC4C0", VA = "0x182ABD8C0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public IOBECAADPPL HEHFNJBEBKN
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD730", Offset = "0x2ABC330", VA = "0x182ABD730")]
			get
			{
				return default(IOBECAADPPL);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD7F0", Offset = "0x2ABC3F0", VA = "0x182ABD7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public IOBECAADPPL IMMDJKNBGMO
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x2ABD920", Offset = "0x2ABC520", VA = "0x182ABD920")]
			get
			{
				return default(IOBECAADPPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDF20", Offset = "0x2ABCB20", VA = "0x182ABDF20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD660", Offset = "0x2ABC260", VA = "0x182ABD660", Slot = "15")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDFC0", Offset = "0x2ABCBC0", VA = "0x182ABDFC0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDD30", Offset = "0x2ABC930", VA = "0x182ABDD30", Slot = "14")]
		protected override void NLLHMOLKCJM(NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> GIPIIBFAOKH, NativeArray<Entity> PJIIAMBEGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDC50", Offset = "0x2ABC850", VA = "0x182ABDC50")]
		private void HJONDJPPHCK(NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> PJIIAMBEGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD9B0", Offset = "0x2ABC5B0", VA = "0x182ABD9B0")]
		private void HDAGOAMBOLH(Entity LLEBIIAHFDD, Entity INDIEGGJNFJ, Entity ONPPJKNNPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E160", Offset = "0x2A0CD60", VA = "0x182A0E160")]
		private bool GIGGJMBFKKD<T>(out T GKFICKKHACC) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E1F0", Offset = "0x2A0CDF0", VA = "0x182A0E1F0")]
		private void JKMJNDCPNKA<T>(T GKFICKKHACC) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDE80", Offset = "0x2ABCA80", VA = "0x182ABDE80")]
		public bool OLFNGJHIJAC(IOBECAADPPL CIFNOLAMFLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD7C0", Offset = "0x2ABC3C0", VA = "0x182ABD7C0")]
		private static bool EMKCCGMDDME(IOBECAADPPL GOBOKNGJFJC, IOBECAADPPL MMCBNIJDLKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x2ABE090", Offset = "0x2ABCC90", VA = "0x182ABE090")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDEE0", Offset = "0x2ABCAE0", VA = "0x182ABDEE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[HFIGNCEGOKM(DDEOJCINOPG.Scope)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private EntityQuery NJIBLOIMOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x2FA20F0", Offset = "0x2FA0CF0", VA = "0x182FA20F0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2FA23A0", Offset = "0x2FA0FA0", VA = "0x182FA23A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2440", Offset = "0x2FA1040", VA = "0x182FA2440", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2140", Offset = "0x2FA0D40", VA = "0x182FA2140")]
		private NativeArray<Entity> BBGPOKDEFCO(int CGKKILDEEIJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2290", Offset = "0x2FA0E90", VA = "0x182FA2290")]
		private void JMANCAMEGLE(NativeArray<Entity> PHELHGHGHND, NativeArray<Entity> CHJMGPIMDMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[HFIGNCEGOKM(DDEOJCINOPG.Scope)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	internal class HideRemotePivotsNotInScope : OMEJOMKMFOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery EAFKAPFFICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery AKMKELPCIEA;

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC420", Offset = "0x2AAB020", VA = "0x182AAC420", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x2AAC510", Offset = "0x2AAB110", VA = "0x182AAC510", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal static class IHPLLHDIADM
{
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public const string GDJADLIBOPA = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x25FC4B0", Offset = "0x25FB0B0", VA = "0x1825FC4B0")]
	public static NativeArray<T> ONNDOAPHHCA<T>(NativeArray<Entity> FNMNPGEEPJI, EntityManager CLLNDNAAIKP) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF930", Offset = "0x2AAE530", VA = "0x182AAF930")]
	public static void HEHBOGKFKGA(EntityQuery NJIBLOIMOJA, EntityManager CLLNDNAAIKP, BLGCKCAEBNA EFJCPEJOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF800", Offset = "0x2AAE400", VA = "0x182AAF800")]
	public static void HCKBCMKDPDN(NativeArray<Entity> PHELHGHGHND, BLGCKCAEBNA EFJCPEJOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x2AAFA70", Offset = "0x2AAE670", VA = "0x182AAFA70")]
	public static void NAFOFDIHCAD(NativeArray<Entity> PHELHGHGHND, BLGCKCAEBNA EFJCPEJOMJG)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.Scope)]
	internal class UpdateContainerPivotOnExitScopeSystem : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private EntityQuery NJIBLOIMOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private TransformService KKELBBDIJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private ObjectLifecycleService KOGKJOIDDKK;

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2D91140", Offset = "0x2D8FD40", VA = "0x182D91140", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2D920C0", Offset = "0x2D90CC0", VA = "0x182D920C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2D92160", Offset = "0x2D90D60", VA = "0x182D92160", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2D911D0", Offset = "0x2D8FDD0", VA = "0x182D911D0")]
		private void CGEFBIIAGCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2D92170", Offset = "0x2D90D70", VA = "0x182D92170")]
		private void PEMLOJAHBJL(NativeArray<Entity> PHELHGHGHND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2D92280", Offset = "0x2D90E80", VA = "0x182D92280")]
		private void PNLMMNMDECI(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2D91E70", Offset = "0x2D90A70", VA = "0x182D91E70")]
		private void KDGAMFAHKNN(NativeArray<Entity> CHJMGPIMDMK, NativeArray<RigidTransform> FBAPGPAGLFP, NativeArray<RigidTransform> JJJKAGKOHAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x2D919E0", Offset = "0x2D905E0", VA = "0x182D919E0")]
		private void JFKEGIDENOK(NativeArray<RigidTransform> JJJKAGKOHAM, NativeArray<Entity> CHJMGPIMDMK, NativeList<Entity> ICPGOECIOMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[HFIGNCEGOKM(DDEOJCINOPG.Scope)]
	internal class PostGameplayOnScopeChange : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery LFOGJNCHHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private EntityQuery KJLPMLAHEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private MCFPIPCNFDN KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x2A965A0", Offset = "0x2A951A0", VA = "0x182A965A0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x2A96680", Offset = "0x2A95280", VA = "0x182A96680", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2A967D0", Offset = "0x2A953D0", VA = "0x182A967D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x2A96610", Offset = "0x2A95210", VA = "0x182A96610")]
		private void LODONELGLGO(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[HFIGNCEGOKM(DDEOJCINOPG.Scope)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	internal class PreventDisembodiedScopesSystem : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EntityQuery ICLEMKBDFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityHierarchyParents MCPLHLPJDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private LHNBKEDDAHF AAPCJGGAIHF;

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x2A97CD0", Offset = "0x2A968D0", VA = "0x182A97CD0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x2A97EF0", Offset = "0x2A96AF0", VA = "0x182A97EF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x2A97F90", Offset = "0x2A96B90", VA = "0x182A97F90", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x2A97D60", Offset = "0x2A96960", VA = "0x182A97D60")]
		private void KGPLLCDDEHE(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.Scope)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<PAPLPHNEHKP>
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2D7CF50", Offset = "0x2D7BB50", VA = "0x182D7CF50", Slot = "14")]
		protected override void NLLHMOLKCJM(NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> GIPIIBFAOKH, NativeArray<Entity> PJIIAMBEGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D0A0", Offset = "0x2D7BCA0", VA = "0x182D7D0A0")]
		[BurstCompile]
		private static void NLLHMOLKCJM(NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> PJIIAMBEGCK, ComponentDataFromEntity<global::FPOADFOOMMJ> NBFLFBBJIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D1B0", Offset = "0x2D7BDB0", VA = "0x182D7D1B0")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D170", Offset = "0x2D7BD70", VA = "0x182D7D170", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[HFIGNCEGOKM(DDEOJCINOPG.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : OMEJOMKMFOF where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private EntityQuery KFIFCJABAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery HELILDPDHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery AOMOBPNGEEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private EntityQuery LMOJFGNCGKM;

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x3106260", Offset = "0x3104E60", VA = "0x183106260", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x3106630", Offset = "0x3105230", VA = "0x183106630", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x3106600", Offset = "0x3105200", VA = "0x183106600", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x3105580", Offset = "0x3104180", VA = "0x183105580")]
		private void EIDIJKFMNHJ(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x3104960", Offset = "0x3103560", VA = "0x183104960")]
		private void ACHPPJBEAPB(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x31059C0", Offset = "0x31045C0", VA = "0x1831059C0")]
		private void NBAPOLLIKKD(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void NLLHMOLKCJM(NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> GIPIIBFAOKH, NativeArray<Entity> PJIIAMBEGCK);

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x269A140", Offset = "0x2698D40", VA = "0x18269A140")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2699F90", Offset = "0x2698B90", VA = "0x182699F90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public sealed class PJLOBOJOALK : OMEJOMKMFOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private List<(EntityQuery, ComponentType)> PBCKDJKFIBO;

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x2A910E0", Offset = "0x2A8FCE0", VA = "0x182A910E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x2A912E0", Offset = "0x2A8FEE0", VA = "0x182A912E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x2A91430", Offset = "0x2A90030", VA = "0x182A91430")]
	public PJLOBOJOALK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct LABPOBLIGKO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public int OMNKALCAHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public int BDCBCEKMBAK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D590", Offset = "0x2A7C190", VA = "0x182A7D590")]
	public static Entity KPOCFOKDNEC(LABPOBLIGKO JLFCOOGLPMP)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D590", Offset = "0x2A7C190", VA = "0x182A7D590")]
	public static LABPOBLIGKO KPOCFOKDNEC(Entity LLEBIIAHFDD)
	{
		return default(LABPOBLIGKO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct LPGPPLPOIAB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public struct CPEEMCFAHKB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public readonly ComponentType JIOJHELJNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public readonly NativeList<int> EMLNAJJBPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public readonly NativeList<int> DLDEFHKDCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public readonly NativeArray<Entity> FNMNPGEEPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public readonly NativeArray<Entity> LIHINNFLNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public readonly NativeArray<byte> IFLDPJLJJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly NativeArray<byte> LBIAANDOGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public readonly int NMIODJBKPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public readonly int JJFOJIJIHBI;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool ODKBGPPOFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x2F97A30", Offset = "0x2F96630", VA = "0x182F97A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x2F97E50", Offset = "0x2F96A50", VA = "0x182F97E50")]
	public CPEEMCFAHKB(ComponentType JIOJHELJNAL, NativeList<int> EMLNAJJBPOG, NativeList<int> DLDEFHKDCIC, NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> LIHINNFLNAF, NativeArray<byte> IFLDPJLJJLN, NativeArray<byte> LBIAANDOGFM, int NMIODJBKPJP, int JJFOJIJIHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x2F97B90", Offset = "0x2F96790", VA = "0x182F97B90")]
	private EKBGHCIKEGG FMJCNPCANFJ(NativeArray<byte> EJLDCNGHIAK, int BNNEENLPEFO)
	{
		return default(EKBGHCIKEGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	private T FMJCNPCANFJ<T>(NativeArray<byte> EJLDCNGHIAK, int BNNEENLPEFO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x2F97DB0", Offset = "0x2F969B0", VA = "0x182F97DB0")]
	public EKBGHCIKEGG JLMKEDJJGPM(int BNNEENLPEFO)
	{
		return default(EKBGHCIKEGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	public T JLMKEDJJGPM<T>(int BNNEENLPEFO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x2F97E00", Offset = "0x2F96A00", VA = "0x182F97E00")]
	public EKBGHCIKEGG PKCAMLNGHOE(int BNNEENLPEFO)
	{
		return default(EKBGHCIKEGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	public T PKCAMLNGHOE<T>(int BNNEENLPEFO) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x2F97AB0", Offset = "0x2F966B0", VA = "0x182F97AB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public readonly struct BCLCKEMNKIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public readonly EntityQuery NJIBLOIMOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public readonly NativeArray<EEEPDOOOMHK> HFDCOKODHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public readonly ComponentType JIOJHELJNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public readonly int NMIODJBKPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public readonly int JJFOJIJIHBI;

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x2F90720", Offset = "0x2F8F320", VA = "0x182F90720")]
	public BCLCKEMNKIB(ComponentType JIOJHELJNAL, int NMIODJBKPJP, int JJFOJIJIHBI, EntityQuery NJIBLOIMOJA, NativeArray<EEEPDOOOMHK> HFDCOKODHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x2F906D0", Offset = "0x2F8F2D0", VA = "0x182F906D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct JCFJEHIDNLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public int BNNEENLPEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public int FLJCLAFPGIG;

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x698050", Offset = "0x696C50", VA = "0x180698050")]
	public JCFJEHIDNLE(int BNNEENLPEFO, int FLJCLAFPGIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct EEEPDOOOMHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public readonly int HPNBOGMLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public readonly int LBLAPKMJFKP;

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x698050", Offset = "0x696C50", VA = "0x180698050")]
	public EEEPDOOOMHK(int HPNBOGMLOLG, int LBLAPKMJFKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public struct GEKCNMCMNCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private readonly EBLKGKAPHAO GLGEGPNMJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private readonly int NMIODJBKPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private unsafe readonly byte* IFLDPJLJJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private unsafe readonly byte* LBIAANDOGFM;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool ILPKKNHIECH
	{
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5D20", Offset = "0x2AA4920", VA = "0x182AA5D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public EBLKGKAPHAO KNHOMHPCCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727A20", VA = "0x180728E20")]
		get
		{
			return default(EBLKGKAPHAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5C30", Offset = "0x2AA4830", VA = "0x182AA5C30")]
	public EKBGHCIKEGG HCMECHPJIPA(Type BIEGICDMJCM)
	{
		return default(EKBGHCIKEGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5B40", Offset = "0x2AA4740", VA = "0x182AA5B40")]
	public EKBGHCIKEGG BINOKDJKPAC(Type BIEGICDMJCM)
	{
		return default(EKBGHCIKEGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x351EF70", Offset = "0x351DB70", VA = "0x18351EF70")]
	public T HCMECHPJIPA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x351EF50", Offset = "0x351DB50", VA = "0x18351EF50")]
	public T BINOKDJKPAC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5D30", Offset = "0x2AA4930", VA = "0x182AA5D30")]
	public unsafe GEKCNMCMNCD(EBLKGKAPHAO GLGEGPNMJGF, int LBLAPKMJFKP, byte* IFLDPJLJJLN, byte* LBIAANDOGFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class LANANOJNKOO : PHGAEFHEOPI, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private PropertyDiffStateService MJKCKKJPBKL;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected abstract DBJHEIPMAIM FEOMCDHDECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8830", Offset = "0x2AB7430", VA = "0x182AB8830", Slot = "17")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8AC0", Offset = "0x2AB76C0", VA = "0x182AB8AC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x2AB8880", Offset = "0x2AB7480", VA = "0x182AB8880", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	protected LANANOJNKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public static class GAAJMILNFDO
{
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] BFJJECDPAIN;
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[DefaultMember("Item")]
internal class DPNDFOCCADL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly FNIDFMEJGMB CBDAGBGGFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly Dictionary<ComponentType, BCLCKEMNKIB> JOCNBHOKKAE;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public BCLCKEMNKIB OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA51C0", Offset = "0x2FA3DC0", VA = "0x182FA51C0")]
		get
		{
			return default(BCLCKEMNKIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x2FA4F40", Offset = "0x2FA3B40", VA = "0x182FA4F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5770", Offset = "0x2FA4370", VA = "0x182FA5770")]
	public DPNDFOCCADL(EEHCKCIAPAN KJEBDBMGNJF, FNIDFMEJGMB CBDAGBGGFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5250", Offset = "0x2FA3E50", VA = "0x182FA5250")]
	public bool GINCMLLPDOD(ComponentType JIOJHELJNAL, out BCLCKEMNKIB FILNOJDGMDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x2FA5130", Offset = "0x2FA3D30", VA = "0x182FA5130")]
	public Dictionary<ComponentType, BCLCKEMNKIB>.Enumerator EMHOENNLHOC()
	{
		return default(Dictionary<ComponentType, BCLCKEMNKIB>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4F90", Offset = "0x2FA3B90", VA = "0x182FA4F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x2FA52C0", Offset = "0x2FA3EC0", VA = "0x182FA52C0")]
	private void MIBIBABCCND(IEnumerable<OCECHDCDPOJ> HEFGKLNDMDO, EntityManager CLLNDNAAIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x2FA56C0", Offset = "0x2FA42C0", VA = "0x182FA56C0")]
	private static int MPFCJCAJABK(OCECHDCDPOJ PJEPJFLNNEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x2FA4CA0", Offset = "0x2FA38A0", VA = "0x182FA4CA0")]
	private static NativeArray<EEEPDOOOMHK> CLPICADNMDF(OCECHDCDPOJ PJEPJFLNNEJ, Allocator PBEDBDBGIPF = Allocator.Persistent)
	{
		return default(NativeArray<EEEPDOOOMHK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal interface DJJBHNJFKFC
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool ODKBGPPOFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	World HDBHOPCOJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MMOBABKFFNE(out NativeArray<int> FOFDGMLFLEB, Allocator PBEDBDBGIPF);

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GKJHJDKAHLF(ComponentType JIOJHELJNAL, out CPEEMCFAHKB DPMEJCEEHOC, out BCLCKEMNKIB MEOBJDMPABM);

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GKJHJDKAHLF(ComponentType JIOJHELJNAL, out CPEEMCFAHKB DPMEJCEEHOC);

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CPEEMCFAHKB GAKPBGFBBKI(ComponentType JIOJHELJNAL);

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BOMPDGMHJDM GCJFEEMFGKO();

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EOAPGMKKFEC(JobHandle BLJNDDIDOIN);
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
internal interface FKGNDDGLAFM
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	World HDBHOPCOJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	DPNDFOCCADL OLOCLANFPFI
	{
		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	GIMLBHPKKEP CLMCKBDJOGG
	{
		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	NativeMultiHashMap<Entity, GEKCNMCMNCD> BPLBCAHDKEM
	{
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	JobHandle KFGEHIOMFDN
	{
		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BLNLPEOGOOG();

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GJPIAAEOJAL();

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHMALDPGACC(ComponentType JIOJHELJNAL, in CPEEMCFAHKB LBAGLBIEDBA);

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EOLBFOFLMLO(OADLDHPKENB FKEOEHMKOOO, out Entity CNGLOEJDOMG);
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct BOMPDGMHJDM
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public struct JNDPHLDMECH : IEnumerator<GEKCNMCMNCD>, IEnumerator, IDisposable, IEnumerable<GEKCNMCMNCD>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private readonly NativeMultiHashMap<Entity, GEKCNMCMNCD> FAEKHNNILJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private readonly Entity LLEBIIAHFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private NativeMultiHashMapIterator<Entity> JPFMGPEMMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private GEKCNMCMNCD LBIAANDOGFM;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public GEKCNMCMNCD FPPIFCEMCLH
		{
			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0xD96BD0", Offset = "0xD957D0", VA = "0x180D96BD0", Slot = "4")]
			get
			{
				return default(GEKCNMCMNCD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A700", Offset = "0x2D79300", VA = "0x182D7A700", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A750", Offset = "0x2D79350", VA = "0x182D7A750")]
		internal JNDPHLDMECH(NativeMultiHashMap<Entity, GEKCNMCMNCD> FAEKHNNILJJ, Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A4F0", Offset = "0x2D790F0", VA = "0x182D7A4F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A4C0", Offset = "0x2D790C0", VA = "0x182D7A4C0")]
		public JNDPHLDMECH EMHOENNLHOC()
		{
			return default(JNDPHLDMECH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A5C0", Offset = "0x2D791C0", VA = "0x182D7A5C0", Slot = "9")]
		private IEnumerator<GEKCNMCMNCD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A660", Offset = "0x2D79260", VA = "0x182D7A660", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly FKGNDDGLAFM OPCGPJFHEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly JobHandle ILKOPJOIBCC;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public int PCJFJFGKJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x2F93BD0", Offset = "0x2F927D0", VA = "0x182F93BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool MOCJDAMLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x2F93CC0", Offset = "0x2F928C0", VA = "0x182F93CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x2010B80", Offset = "0x200F780", VA = "0x182010B80")]
	public BOMPDGMHJDM(FKGNDDGLAFM OPCGPJFHEJB, JobHandle ILKOPJOIBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x2F94030", Offset = "0x2F92C30", VA = "0x182F94030")]
	public bool MFKPLEMDAOE(Allocator PBEDBDBGIPF, out NativeKeyValueArrays<Entity, GEKCNMCMNCD> BMBFIGGJLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x2F93EC0", Offset = "0x2F92AC0", VA = "0x182F93EC0")]
	public bool HECFBGJIICK(Allocator PBEDBDBGIPF, out (NativeArray<Entity> entities, int uniqueCount) BMBFIGGJLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x2F93DA0", Offset = "0x2F929A0", VA = "0x182F93DA0")]
	public JNDPHLDMECH HDFJIAJJIHO(Entity LLEBIIAHFDD)
	{
		return default(JNDPHLDMECH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[DefaultMember("Item")]
internal class GIMLBHPKKEP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly FNIDFMEJGMB CBDAGBGGFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private readonly List<BCLCKEMNKIB> LENGKEKMOEB;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public BCLCKEMNKIB OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6670", Offset = "0x2AA5270", VA = "0x182AA6670")]
		get
		{
			return default(BCLCKEMNKIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x2AA6430", Offset = "0x2AA5030", VA = "0x182AA6430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6A40", Offset = "0x2AA5640", VA = "0x182AA6A40")]
	public GIMLBHPKKEP(DPNDFOCCADL JOCNBHOKKAE, EEHCKCIAPAN KJEBDBMGNJF, FNIDFMEJGMB CBDAGBGGFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x2AA65F0", Offset = "0x2AA51F0", VA = "0x182AA65F0")]
	public List<BCLCKEMNKIB>.Enumerator EMHOENNLHOC()
	{
		return default(List<BCLCKEMNKIB>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6470", Offset = "0x2AA5070", VA = "0x182AA6470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6700", Offset = "0x2AA5300", VA = "0x182AA6700")]
	private void MIBIBABCCND(DPNDFOCCADL JOCNBHOKKAE, EntityManager CLLNDNAAIKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class BNONGLPKANE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly FNIDFMEJGMB CBDAGBGGFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly ObjectInstantiationService DEBJMFLLNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly global::HAEGCKHPDHM<OCECHDCDPOJ> NAGOBAKMPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly World OJFIHOOFCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly EntityManager CLLNDNAAIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private NativeHashMap<int, Entity> IFOCKLKDDGO;

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x2F93AE0", Offset = "0x2F926E0", VA = "0x182F93AE0")]
	public BNONGLPKANE(ObjectInstantiationService DEBJMFLLNHC, EEHCKCIAPAN KJEBDBMGNJF, FNIDFMEJGMB CBDAGBGGFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x2F924B0", Offset = "0x2F910B0", VA = "0x182F924B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x2F93A80", Offset = "0x2F92680", VA = "0x182F93A80")]
	public bool OJFKBJNEHAM(OADLDHPKENB FKEOEHMKOOO, out Entity CNGLOEJDOMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x2F93130", Offset = "0x2F91D30", VA = "0x182F93130")]
	private void INMGDHCJBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x2F927D0", Offset = "0x2F913D0", VA = "0x182F927D0")]
	private EntityArchetype IIALABCJMJP(EntityArchetype CAKJMNMGICO)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x2F92D00", Offset = "0x2F91900", VA = "0x182F92D00")]
	public static void ILDOJAOKDGK(EntityManager LPIKKOEGLIJ, EntityManager DKNGLDMHBMP, NativeArray<Entity> OHKHEJKMDKP, NativeArray<EntityArchetype> KHCGOKBHBGE, [Optional] NativeArray<Entity> BDCIEPLJNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x2F92660", Offset = "0x2F91260", VA = "0x182F92660")]
	[Conditional("DEBUG_BUILD")]
	private static void IGFIPEEMMMC(NativeArray<EntityArchetype> IMDOBIMILJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x2F92270", Offset = "0x2F90E70", VA = "0x182F92270")]
	private static string AEKNGOPJJEL(EntityArchetype HNNIEOPALKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x2F93940", Offset = "0x2F92540", VA = "0x182F93940")]
	[CompilerGenerated]
	internal static void LGEPFIBBEGH(ref Span<ComponentType> OCFFNHAAOAP, ComponentType GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x2F93790", Offset = "0x2F92390", VA = "0x182F93790")]
	[CompilerGenerated]
	internal static void JPAIGIGBJFG(Span<ComponentType> EJLDCNGHIAK, ref Span<ComponentType> OCFFNHAAOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x2F92580", Offset = "0x2F91180", VA = "0x182F92580")]
	[CompilerGenerated]
	internal static void GIDONFDNAAM(Span<ComponentType> EJLDCNGHIAK, ref Span<ComponentType> OCFFNHAAOAP, ComponentType DIIJEEFKGBP)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.PropertyChanges)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld OEHCGIODPLD;

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F490", Offset = "0x2F8E090", VA = "0x182F8F490", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x2F8F550", Offset = "0x2F8E150", VA = "0x182F8F550", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[AlwaysUpdateSystem]
	[HFIGNCEGOKM(DDEOJCINOPG.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : OMEJOMKMFOF, OHFJHEDBJHF, HMFGCABFMPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		[BurstCompile]
		internal struct DPMCCMAPLCK : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			[ReadOnly]
			public NativeArray<byte> BDKHPDFKMCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			[ReadOnly]
			public NativeArray<byte> KHNCKMHFIHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			[ReadOnly]
			public NativeArray<EEEPDOOOMHK> MDNKEJMDPCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			[WriteOnly]
			public NativeList<JCFJEHIDNLE>.ParallelWriter GLGLABJHEBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public int GAEEPKJNBAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public int EMCDLHCNPGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public ProfilerMarker PNDBCBILDIL;

			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x2D790A0", Offset = "0x2D77CA0", VA = "0x182D790A0", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x2D791E0", Offset = "0x2D77DE0", VA = "0x182D791E0")]
			private unsafe int GIBMBELLJKL(byte* PPALHIEFBCO, byte* NMNKGKHKMCB)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000152")]
		[BurstCompile]
		internal struct DBAIFGMOJDD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			[WriteOnly]
			public NativeList<int> EMLNAJJBPOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			[WriteOnly]
			public NativeList<int> FPKGLLMOLGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			[ReadOnly]
			public NativeList<JCFJEHIDNLE> PDDBOFHMBMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public ProfilerMarker PNDBCBILDIL;

			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x2D78A10", Offset = "0x2D77610", VA = "0x182D78A10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000153")]
		[BurstCompile]
		internal struct OFKIIABCGIC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			[WriteOnly]
			public NativeArray<byte> PODJGFLGOJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			[ReadOnly]
			public NativeArray<Entity> FNMNPGEEPJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			[ReadOnly]
			public LFHLPPKAALB MEEAFBMAGLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public int NMIODJBKPJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public ProfilerMarker PNDBCBILDIL;

			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x2D7B4E0", Offset = "0x2D7A0E0", VA = "0x182D7B4E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct PNLMNLCNMIC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, GEKCNMCMNCD> GMFDFPOAIDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			[ReadOnly]
			public NativeArray<byte> IFLDPJLJJLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			[ReadOnly]
			public NativeArray<byte> LBIAANDOGFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<Entity> FNMNPGEEPJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<EEEPDOOOMHK> PNLEMHPBOLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeList<int> DLDEFHKDCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[ReadOnly]
			public NativeList<int> EMLNAJJBPOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int GHGPKHBDBCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int JJFOJIJIHBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker PNDBCBILDIL;

			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x2D7B630", Offset = "0x2D7A230", VA = "0x182D7B630", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private static readonly ProfilerMarker CDFJLLIGBMN;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private static readonly ProfilerMarker MLDAPPKJCIG;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private static readonly ProfilerMarker OFLMKBHHMFL;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private static readonly ProfilerMarker JENOHHLOGBO;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly ProfilerMarker OGKBFBKBKGF;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private static readonly ProfilerMarker CPBOKFCKIKG;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private static readonly ProfilerMarker FEEAKAMOBNA;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly ProfilerMarker ABIONKEKGNO;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private static readonly ProfilerMarker KFCOPJKBIJA;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private static readonly ProfilerMarker LNFAEJHAGEN;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private static readonly ProfilerMarker COAGFNLBPBB;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private static readonly ProfilerMarker AOJIDKFLGFO;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private static readonly ProfilerMarker GCFGINMHGPN;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private static readonly ProfilerMarker JDNEACLEHGH;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private static readonly ProfilerMarker CEOFPBACOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private PropertyDiffStateService MJKCKKJPBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private EntityQuery JENEOMCAPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private EntityQuery AKCGHHEOAEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private EntityQuery HBIOBHKPEGB;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		internal World HDBHOPCOJGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x2F9AE20", Offset = "0x2F99A20", VA = "0x182F9AE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private FKGNDDGLAFM PDCFCDHBBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x2F9BB40", Offset = "0x2F9A740", VA = "0x182F9BB40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x2F99F80", Offset = "0x2F98B80", VA = "0x182F99F80", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "15")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x2F9CEE0", Offset = "0x2F9BAE0", VA = "0x182F9CEE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D0A0", Offset = "0x2F9BCA0", VA = "0x182F9D0A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D030", Offset = "0x2F9BC30", VA = "0x182F9D030", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x2F9B840", Offset = "0x2F9A440", VA = "0x182F9B840")]
		private void IMHLKHOKNBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x2F9A850", Offset = "0x2F99450", VA = "0x182F9A850")]
		internal void EPGIAEDNEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x2F9A080", Offset = "0x2F98C80", VA = "0x182F9A080")]
		private void EPGIAEDNEHH(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x2F9ABE0", Offset = "0x2F997E0", VA = "0x182F9ABE0")]
		private void GMPHDAPPLEL(NativeArray<Entity> OHKHEJKMDKP, NativeArray<RRObjectPrefabData> GCNDHOEOECI, ref NativeArray<Entity> LFPHGHDMEHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x2F9CEC0", Offset = "0x2F9BAC0", VA = "0x182F9CEC0")]
		internal void ODMPLKOFIOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x2F9CAC0", Offset = "0x2F9B6C0", VA = "0x182F9CAC0")]
		private void ODMPLKOFIOO(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x2F9BB60", Offset = "0x2F9A760", VA = "0x182F9BB60")]
		internal void KNPGADAPCNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C490", Offset = "0x2F9B090", VA = "0x182F9C490")]
		private void LAILJHNGEBP(FKGNDDGLAFM OPCGPJFHEJB, BCLCKEMNKIB MEOBJDMPABM, bool LOENOKEFIGA, ref JobHandle FHAFGAPMJIJ, ref JobHandle PHANOIBCMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x2F9AEE0", Offset = "0x2F99AE0", VA = "0x182F9AEE0")]
		internal bool HOHBJGNCJCJ(in BCLCKEMNKIB NMNKGKHKMCB, out JobHandle DKBLPJPHEMF, out CPEEMCFAHKB IPKLHAGMEEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x2F9AF10", Offset = "0x2F99B10", VA = "0x182F9AF10")]
		private bool HOHBJGNCJCJ(in BCLCKEMNKIB NMNKGKHKMCB, bool LOENOKEFIGA, out JobHandle DKBLPJPHEMF, out CPEEMCFAHKB IPKLHAGMEEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C900", Offset = "0x2F9B500", VA = "0x182F9C900")]
		internal (NativeList<int>, NativeList<int>) NNLGDHJLPCC(NativeList<JCFJEHIDNLE> PDDBOFHMBMM, int BPGPHKEJPBF, JobHandle EJNAMLGMMHG, out JobHandle BLJNDDIDOIN, Allocator PBEDBDBGIPF = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x2F99FD0", Offset = "0x2F98BD0", VA = "0x182F99FD0")]
		internal static NativeArray<Entity> BCIBJMKHLHE(EntityQuery NJIBLOIMOJA, out JobHandle PLOIHNLAILD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C770", Offset = "0x2F9B370", VA = "0x182F9C770")]
		internal static NativeArray<byte> MHNAJIJNGJH(int EHAMCGPFFID, out JobHandle AKGNNAPOLAK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C7F0", Offset = "0x2F9B3F0", VA = "0x182F9C7F0")]
		internal static NativeArray<byte> MMKFMHMGMHC(EntityQuery NJIBLOIMOJA, int BGAEBMDLBPN, out JobHandle AKGNNAPOLAK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2F9AAE0", Offset = "0x2F996E0", VA = "0x182F9AAE0")]
		internal static NativeArray<Entity> GFDPMPHDEBP(EntityQuery NJIBLOIMOJA, out JobHandle PCDMIGHNFCN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2F9A870", Offset = "0x2F99470", VA = "0x182F9A870")]
		internal NativeArray<byte> FHMAFBOLEJB(NativeArray<Entity> FNMNPGEEPJI, BCLCKEMNKIB MEOBJDMPABM, JobHandle EJNAMLGMMHG, out JobHandle BLJNDDIDOIN, Allocator PBEDBDBGIPF = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C300", Offset = "0x2F9AF00", VA = "0x182F9C300")]
		internal JobHandle KOFOANAHAOP(in CPEEMCFAHKB JLFCOOGLPMP, in BCLCKEMNKIB MEOBJDMPABM, NativeMultiHashMap<Entity, GEKCNMCMNCD> GMFDFPOAIDK, JobHandle EJNAMLGMMHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6B00", Offset = "0x1FB5700", VA = "0x181FB6B00")]
		private JobHandle IMEIJCPJCFD(JobHandle LMDHBBCCOPF, JobHandle HFMMPBGICHB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6B00", Offset = "0x1FB5700", VA = "0x181FB6B00")]
		private JobHandle IMEIJCPJCFD(JobHandle LMDHBBCCOPF, JobHandle HFMMPBGICHB, JobHandle AAGCBJPFBPE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[HFIGNCEGOKM(DDEOJCINOPG.RenderEffects)]
	internal class PropagateHoverRootTag : LJGIGCFJLFM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		public struct CIIJFNKEECE : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		protected override ComponentType EHLMHLBPCCM
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x2A988D0", Offset = "0x2A974D0", VA = "0x182A988D0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override ComponentType FNGLFBHNMKO
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x2A988A0", Offset = "0x2A974A0", VA = "0x182A988A0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override ComponentType LPDOHFENIEH
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x2A98870", Offset = "0x2A97470", VA = "0x182A98870", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2A98900", Offset = "0x2A97500", VA = "0x182A98900")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[HFIGNCEGOKM(DDEOJCINOPG.RenderEffects)]
	internal class PropagateSelectionRootTag : LJGIGCFJLFM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		public struct MLNHNJPCNPM : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType EHLMHLBPCCM
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x2A98970", Offset = "0x2A97570", VA = "0x182A98970", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType FNGLFBHNMKO
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x2A98940", Offset = "0x2A97540", VA = "0x182A98940", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType LPDOHFENIEH
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x2A98910", Offset = "0x2A97510", VA = "0x182A98910", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2A98900", Offset = "0x2A97500", VA = "0x182A98900")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[GDGGJDPAMIC]
public class BDKJHGHPCAM : HKNPFPHAGAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private EntityQuery NJIBLOIMOJA;

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x2F908F0", Offset = "0x2F8F4F0", VA = "0x182F908F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x2F90980", Offset = "0x2F8F580", VA = "0x182F90980", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public BDKJHGHPCAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[GDGGJDPAMIC]
public class NOBFNDJAKMK : HKNPFPHAGAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct DBFDLDOMJJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		public DBFDLDOMJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct GBEDIKFMEHL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200015D")]
		private struct FFJBICKFCHF
		{
			[Cpp2IlInjected.Token(Token = "0x200015E")]
			[NoAlias]
			public struct GFFLBGEGKOI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000450")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime HJBCEBNAHHG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000451")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime OHLELPFMIHL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity DPFMNEOBEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> NEKNOBFGONN;

			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x3DD74D0", Offset = "0x3DD60D0", VA = "0x183DD74D0")]
			public void GKLJKDAGGIM(NOBFNDJAKMK GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x3DD7530", Offset = "0x3DD6130", VA = "0x183DD7530")]
			public GFFLBGEGKOI HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
			{
				return default(GFFLBGEGKOI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public EntityManager CLLNDNAAIKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public NativeList<Entity> IDDIHBJPCIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private FFJBICKFCHF MOCCMIIFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FFJBICKFCHF.GFFLBGEGKOI* NKKBCHLLBEJ;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate ENKNKDHOKFC;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate CJDAHDEBLJK;

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7DE0", Offset = "0x3DD69E0", VA = "0x183DD7DE0")]
		internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, SplinePointParentData DEDMBANHEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x3DD80A0", Offset = "0x3DD6CA0", VA = "0x183DD80A0", Slot = "5")]
		public void ReadFromDisplayClass(ref DBFDLDOMJJP LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x3DD80B0", Offset = "0x3DD6CB0", VA = "0x183DD80B0", Slot = "6")]
		public void WriteToDisplayClass(ref DBFDLDOMJJP LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7E50", Offset = "0x3DD6A50", VA = "0x183DD7E50", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7FF0", Offset = "0x3DD6BF0", VA = "0x183DD7FF0")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref FFJBICKFCHF.GFFLBGEGKOI FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7F60", Offset = "0x3DD6B60", VA = "0x183DD7F60")]
		public void GKLJKDAGGIM(NOBFNDJAKMK GFHLMIDFMDH, ref DBFDLDOMJJP LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7EF0", Offset = "0x3DD6AF0", VA = "0x183DD7EF0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void FIKCEGMOMMK(ArchetypeChunkIterator* NKPBBGCKHML, void* MOGAJEFFDEG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery KPPEMABAKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private ProfilerMarker KEGMJCJEABC;

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DE90", Offset = "0x2A7CA90", VA = "0x182A7DE90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public NOBFNDJAKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DC60", Offset = "0x2A7C860", VA = "0x182A7DC60", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DB00", Offset = "0x2A7C700", VA = "0x182A7DB00")]
	public static EntityQuery JFOFCMOJMOK(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[GDGGJDPAMIC]
public class NHHMABIGJHE : HKNPFPHAGAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private EntityQuery HBFMHNGDHNM;

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D3E0", Offset = "0x2A7BFE0", VA = "0x182A7D3E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D470", Offset = "0x2A7C070", VA = "0x182A7D470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public NHHMABIGJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[UpdateAfter(typeof(BDKJHGHPCAM))]
public class BHJKCNNNJGE : OMEJOMKMFOF
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x2F914A0", Offset = "0x2F900A0", VA = "0x182F914A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public BHJKCNNNJGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public class EPMJAJNMJOL : HKNPFPHAGAE, OHFJHEDBJHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct JLLCIENDGDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public NativeHashMap<ELJHNEOGEBP, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		public JLLCIENDGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct LEKIPNHBLOL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		private struct OLJEBGDJMJP
		{
			[Cpp2IlInjected.Token(Token = "0x2000165")]
			public struct OOLFNDMJELA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400045D")]
				public LambdaParameterValueProvider_Entity.Runtime HJBCEBNAHHG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400045E")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime JEGPJEJHHPC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity DPFMNEOBEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> DHLEKNOCDJG;

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD600", Offset = "0x3DDC200", VA = "0x183DDD600")]
			public void GKLJKDAGGIM(EPMJAJNMJOL GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD660", Offset = "0x3DDC260", VA = "0x183DDD660")]
			public OOLFNDMJELA HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
			{
				return default(OOLFNDMJELA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public NativeHashMap<ELJHNEOGEBP, Entity> FAEKHNNILJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private OLJEBGDJMJP MOCCMIIFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe OLJEBGDJMJP.OOLFNDMJELA* NKKBCHLLBEJ;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate ENKNKDHOKFC;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAF00", Offset = "0x3DD9B00", VA = "0x183DDAF00")]
		internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, ObjectNetworkIdComponentData PPLJNJDEBHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2D7A950", Offset = "0x2D79550", VA = "0x182D7A950", Slot = "5")]
		public void ReadFromDisplayClass(ref JLLCIENDGDM LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x232E350", Offset = "0x232CF50", VA = "0x18232E350", Slot = "6")]
		public void WriteToDisplayClass(ref JLLCIENDGDM LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAF80", Offset = "0x3DD9B80", VA = "0x183DDAF80", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB120", Offset = "0x3DD9D20", VA = "0x183DDB120")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, ref OLJEBGDJMJP.OOLFNDMJELA FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB090", Offset = "0x3DD9C90", VA = "0x183DDB090")]
		public void GKLJKDAGGIM(EPMJAJNMJOL GFHLMIDFMDH, ref JLLCIENDGDM LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB020", Offset = "0x3DD9C20", VA = "0x183DDB020")]
		public unsafe static void FIKCEGMOMMK(ArchetypeChunkIterator* NKPBBGCKHML, void* MOGAJEFFDEG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private ObjectNetworkToLocalMapService LDFFPBKCNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private EntityQuery KPPEMABAKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private ProfilerMarker KEGMJCJEABC;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8980", Offset = "0x2FA7580", VA = "0x182FA8980", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8D40", Offset = "0x2FA7940", VA = "0x182FA8D40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public EPMJAJNMJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x2FA8B40", Offset = "0x2FA7740", VA = "0x182FA8B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x2FA89E0", Offset = "0x2FA75E0", VA = "0x182FA89E0")]
	public static EntityQuery JFOFCMOJMOK(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public class ECNKJGEOKLJ : HKNPFPHAGAE, OHFJHEDBJHF
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct ADBPPAIFJPM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000168")]
		private struct BPDHOMKHOGD
		{
			[Cpp2IlInjected.Token(Token = "0x2000169")]
			public struct JEFNEBKFGHO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000468")]
				public LambdaParameterValueProvider_Entity.Runtime HJBCEBNAHHG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000469")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime MNMEAMOJHON;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity DPFMNEOBEKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> NCBJALLJFOK;

			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x3DD3980", Offset = "0x3DD2580", VA = "0x183DD3980")]
			public void GKLJKDAGGIM(ECNKJGEOKLJ GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x3DD39E0", Offset = "0x3DD25E0", VA = "0x183DD39E0")]
			public JEFNEBKFGHO HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
			{
				return default(JEFNEBKFGHO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public ECNKJGEOKLJ MLDAJMDPKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private BPDHOMKHOGD MOCCMIIFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BPDHOMKHOGD.JEFNEBKFGHO* NKKBCHLLBEJ;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate ENKNKDHOKFC;

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D77500", Offset = "0x2D76100", VA = "0x182D77500")]
		public void CCKNMJAJJNM(Entity LLEBIIAHFDD, ParentData CHOLHCKOODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x2D77520", Offset = "0x2D76120", VA = "0x182D77520", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x2D77640", Offset = "0x2D76240", VA = "0x182D77640")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, ref BPDHOMKHOGD.JEFNEBKFGHO FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x2D77600", Offset = "0x2D76200", VA = "0x182D77600")]
		public void GKLJKDAGGIM(ECNKJGEOKLJ GFHLMIDFMDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x2D77590", Offset = "0x2D76190", VA = "0x182D77590")]
		public unsafe static void FIKCEGMOMMK(ArchetypeChunkIterator* NKPBBGCKHML, void* MOGAJEFFDEG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private EntityQuery KPPEMABAKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private ProfilerMarker KEGMJCJEABC;

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7390", Offset = "0x2FA5F90", VA = "0x182FA7390", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7940", Offset = "0x2FA6540", VA = "0x182FA7940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public ECNKJGEOKLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2FA73F0", Offset = "0x2FA5FF0", VA = "0x182FA73F0")]
	[CompilerGenerated]
	private void EJMGJNLNABM(Entity LLEBIIAHFDD, ParentData CHOLHCKOODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7740", Offset = "0x2FA6340", VA = "0x182FA7740", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x2FA75E0", Offset = "0x2FA61E0", VA = "0x182FA75E0")]
	public static EntityQuery JFOFCMOJMOK(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public class OAGAKCAOOPL : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private int JHEDHNJKLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private EntityQuery NJIBLOIMOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private ObjectPrefabs DEBJMFLLNHC;

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E6B0", Offset = "0x2A7D2B0", VA = "0x182A7E6B0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A7EAA0", Offset = "0x2A7D6A0", VA = "0x182A7EAA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A7EB80", Offset = "0x2A7D780", VA = "0x182A7EB80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x2A7E700", Offset = "0x2A7D300", VA = "0x182A7E700")]
	private void DPLALKCBHIE(Entity LLEBIIAHFDD, OADLDHPKENB FKEOEHMKOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public OAGAKCAOOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[UpdateBefore(typeof(OAGAKCAOOPL))]
	[HFIGNCEGOKM(DDEOJCINOPG.Serialization)]
	public class PostLoadAddSceneTagEntity : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private SceneService HMMCBLIILHF;

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x2A968E0", Offset = "0x2A954E0", VA = "0x182A968E0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x2A96930", Offset = "0x2A95530", VA = "0x182A96930", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[HFIGNCEGOKM(DDEOJCINOPG.Serialization)]
	[GMHCLNCMPDG(JIJBLGHADKE.OMRoom)]
	public class PostLoadInitializeNetworkId : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		[CompilerGenerated]
		private struct APNIFCGHIND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public NativeHashMap<ELJHNEOGEBP, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
			public APNIFCGHIND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016E")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct GOKBHGFCPDP : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200016F")]
			private struct GOJLHPCCNFE
			{
				[Cpp2IlInjected.Token(Token = "0x2000170")]
				[NoAlias]
				public struct CKJLCCMGNNL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400047E")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime HJBCEBNAHHG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400047F")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime JAPJAGAFLHD;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000480")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime JEGPJEJHHPC;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity DPFMNEOBEKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_EntityInQueryIndex GGKDKIBNIPA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047D")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> DHLEKNOCDJG;

				[Cpp2IlInjected.Token(Token = "0x6000A19")]
				[Cpp2IlInjected.Address(RVA = "0x3DD87B0", Offset = "0x3DD73B0", VA = "0x183DD87B0")]
				public void GKLJKDAGGIM(PostLoadInitializeNetworkId GFHLMIDFMDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A1A")]
				[Cpp2IlInjected.Address(RVA = "0x3DD8820", Offset = "0x3DD7420", VA = "0x183DD8820")]
				public CKJLCCMGNNL HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
				{
					return default(CKJLCCMGNNL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public NativeHashMap<ELJHNEOGEBP, Entity> FAEKHNNILJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private GOJLHPCCNFE MOCCMIIFDDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe GOJLHPCCNFE.CKJLCCMGNNL* NKKBCHLLBEJ;

			[Cpp2IlInjected.Token(Token = "0x4000479")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate ENKNKDHOKFC;

			[Cpp2IlInjected.Token(Token = "0x400047A")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate CJDAHDEBLJK;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x3DD88D0", Offset = "0x3DD74D0", VA = "0x183DD88D0")]
			internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, int MLBMANBHNCL, ref ObjectNetworkIdComponentData PPLJNJDEBHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A950", Offset = "0x2D79550", VA = "0x182D7A950", Slot = "5")]
			public void ReadFromDisplayClass(ref APNIFCGHIND LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0x232E350", Offset = "0x232CF50", VA = "0x18232E350", Slot = "6")]
			public void WriteToDisplayClass(ref APNIFCGHIND LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x3DD8960", Offset = "0x3DD7560", VA = "0x183DD8960", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x3DD8B60", Offset = "0x3DD7760", VA = "0x183DD8B60")]
			public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref GOJLHPCCNFE.CKJLCCMGNNL FAHLNAJJNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0x3DD8AC0", Offset = "0x3DD76C0", VA = "0x183DD8AC0")]
			public void GKLJKDAGGIM(PostLoadInitializeNetworkId GFHLMIDFMDH, ref APNIFCGHIND LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x3DD8A50", Offset = "0x3DD7650", VA = "0x183DD8A50")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void FIKCEGMOMMK(ArchetypeChunkIterator* NKPBBGCKHML, void* MOGAJEFFDEG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[NHBEJKCIJLO]
		private ObjectNetworkToLocalMapService LDFFPBKCNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		[NHBEJKCIJLO]
		private SceneService OIICOGEJBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private EntityQuery NJIBLOIMOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private EntityQuery AHEEMDJMAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private ProfilerMarker ELINFENBHLD;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x2A96B40", Offset = "0x2A95740", VA = "0x182A96B40", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x2A976C0", Offset = "0x2A962C0", VA = "0x182A976C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x2A97360", Offset = "0x2A95F60", VA = "0x182A97360", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x2A97360", Offset = "0x2A95F60", VA = "0x182A97360")]
		public void OCAEKOFPLPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x2A96BB0", Offset = "0x2A957B0", VA = "0x182A96BB0")]
		private void ACLOLNIEPID(NativeHashMap<ELJHNEOGEBP, Entity> FAEKHNNILJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x2A97100", Offset = "0x2A95D00", VA = "0x182A97100")]
		private void NLEKJOBAFAJ(NativeHashMap<ELJHNEOGEBP, Entity> FAEKHNNILJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x2A97430", Offset = "0x2A96030", VA = "0x182A97430", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x2A97760", Offset = "0x2A96360", VA = "0x182A97760")]
		public static EntityQuery PAOIAHBBBGI(ComponentSystemBase GFHLMIDFMDH)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
public class IBEFPKIDNKJ : OMEJOMKMFOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private EntityQuery CPKNEGOPBOM;

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x2AAE890", Offset = "0x2AAD490", VA = "0x182AAE890", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x2AAE920", Offset = "0x2AAD520", VA = "0x182AAE920", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public IBEFPKIDNKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
public class GPGMELIBGAN : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private global::HAEGCKHPDHM<EJMMDFNNNIA> OPPNKLBKHAN;

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6CD0", Offset = "0x2AA58D0", VA = "0x182AA6CD0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7710", Offset = "0x2AA6310", VA = "0x182AA7710", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6F80", Offset = "0x2AA5B80", VA = "0x182AA6F80")]
	private void EIFDICJLJPO(NativeList<EntityArchetype> IMDOBIMILJG, NativeHashMap<int, OIGDPEFJPLN> MCOPIMGBLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6D70", Offset = "0x2AA5970", VA = "0x182AA6D70")]
	private Span<int> CCHPJFGMCNC(EntityArchetype HNNIEOPALKC)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6EB0", Offset = "0x2AA5AB0", VA = "0x182AA6EB0")]
	private bool EIANIAJKPBF(int BGAEBMDLBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x2AA7110", Offset = "0x2AA5D10", VA = "0x182AA7110")]
	private void MJKJOAFPCIK(NativeHashMap<int, OIGDPEFJPLN> MCOPIMGBLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public GPGMELIBGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[HFIGNCEGOKM(DDEOJCINOPG.Serialization)]
	public class PreSerializeRemoveEntities : OMEJOMKMFOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private static FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery INJKLLDPLDH;

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2A97950", Offset = "0x2A96550", VA = "0x182A97950", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2A97BD0", Offset = "0x2A967D0", VA = "0x182A97BD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[HFIGNCEGOKM(DDEOJCINOPG.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		[CompilerGenerated]
		private struct NGKAGOGMIOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public LFHLPPKAALB dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x6000A33")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
			public NGKAGOGMIOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x2D79A70", Offset = "0x2D78670", VA = "0x182D79A70")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LBBMLEEEHDC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			[ReadOnly]
			public NativeList<int> EMLNAJJBPOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			[ReadOnly]
			public NativeArray<Entity> LIHINNFLNAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public LFHLPPKAALB IJJCOPBLIAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			[ReadOnly]
			public NativeArray<byte> LBIAANDOGFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public int NMIODJBKPJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public ComponentType JIOJHELJNAL;

			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0x3DDACD0", Offset = "0x3DD98D0", VA = "0x183DDACD0")]
			internal void CCKNMJAJJNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0x3DDAEC0", Offset = "0x3DD9AC0", VA = "0x183DDAEC0", Slot = "5")]
			public void ReadFromDisplayClass(ref NGKAGOGMIOF LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0x3DDAE90", Offset = "0x3DD9A90", VA = "0x183DDAE90", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x3DDAEA0", Offset = "0x3DD9AA0", VA = "0x183DDAEA0")]
			public void GKLJKDAGGIM(ShadowWorldApplyPropertyDifferencesToShadowWorld GFHLMIDFMDH, ref NGKAGOGMIOF LAOMKEKPBEJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private PropertyDiffStateService MJKCKKJPBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private JobHandle BPOIKHNBFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private JobHandle CNLOBNDAJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private DJJBHNJFKFC OPCGPJFHEJB;

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x2D82CD0", Offset = "0x2D818D0", VA = "0x182D82CD0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x2D82D30", Offset = "0x2D81930", VA = "0x182D82D30")]
		public JobHandle DBICDGJOIGK(JobHandle EJNAMLGMMHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x2D83080", Offset = "0x2D81C80", VA = "0x182D83080", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x2D82D70", Offset = "0x2D81970", VA = "0x182D82D70")]
		private bool MEIKGDGJGKD(JobHandle EJNAMLGMMHG, int BGAEBMDLBPN, out JobHandle MNHBLNJHMBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[ExecuteAlways]
[OPLAMEBGNBC]
[UpdateInGroup(typeof(JKEIGPDDDOI))]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
internal sealed class KJEAKJPMMIE : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5C20", Offset = "0x2AB4820", VA = "0x182AB5C20", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public KJEAKJPMMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[ExecuteAlways]
[OPLAMEBGNBC]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
[UpdateInGroup(typeof(ICPFKLKOHFJ))]
internal sealed class ACLIEOECLJH : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2F8CC30", Offset = "0x2F8B830", VA = "0x182F8CC30", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public ACLIEOECLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[OPLAMEBGNBC]
[ExecuteAlways]
[UpdateInGroup(typeof(OJNKOOMMBEP))]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
internal sealed class BIHOJOPMFDL : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x2F91860", Offset = "0x2F90460", VA = "0x182F91860", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public BIHOJOPMFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[ExecuteAlways]
[OPLAMEBGNBC]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
[UpdateInGroup(typeof(IIOOIELHEMK))]
internal sealed class IEBENGHHJMI : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF510", Offset = "0x2AAE110", VA = "0x182AAF510", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public IEBENGHHJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal class KJLEENOAOAD : LANANOJNKOO
{
	[Cpp2IlInjected.Token(Token = "0x17000122")]
	protected override DBJHEIPMAIM FEOMCDHDECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x69DAA0", Offset = "0x69C6A0", VA = "0x18069DAA0", Slot = "18")]
		get
		{
			return default(DBJHEIPMAIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public KJLEENOAOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[ExecuteAlways]
[OPLAMEBGNBC]
[UpdateInGroup(typeof(CDMCEDHHDIO))]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
internal sealed class PAMILFAIAFA : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x2A8E9E0", Offset = "0x2A8D5E0", VA = "0x182A8E9E0", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public PAMILFAIAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class HIAEBKLNJPK : BHBEGOLDLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public HIAEBKLNJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class HCNFMFGACEM : LANANOJNKOO
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	protected override DBJHEIPMAIM FEOMCDHDECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CD70", VA = "0x18067E170", Slot = "18")]
		get
		{
			return default(DBJHEIPMAIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public HCNFMFGACEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[ExecuteAlways]
[OPLAMEBGNBC]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
[UpdateInGroup(typeof(FKHMAEJEEFI))]
internal sealed class KLDCNPFKDEP : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x2AB5D00", Offset = "0x2AB4900", VA = "0x182AB5D00", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public KLDCNPFKDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class ALBHLIDLINA : BHBEGOLDLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public ALBHLIDLINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class CEDIEMKPAIG : BHBEGOLDLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public CEDIEMKPAIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class HGKOMCOJCAM : OMEJOMKMFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public HGKOMCOJCAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[GDGGJDPAMIC]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
public class IHNKOGAOPFB : OMEJOMKMFOF, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private TimeService MHIJNFDOFCE;

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF790", Offset = "0x2AAE390", VA = "0x182AAF790", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x2AAF7E0", Offset = "0x2AAE3E0", VA = "0x182AAF7E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public IHNKOGAOPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[HFIGNCEGOKM(DDEOJCINOPG.TransformSyncing)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	public class CopyTransformDataFromGameObjects : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[BurstCompile]
		private struct HEDOIDFGDDO : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private const float IOPMOMOOEAK = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			[ReadOnly]
			public NativeArray<Entity> FNMNPGEEPJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> APFLGCENJNK;

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x2D79A80", Offset = "0x2D78680", VA = "0x182D79A80", Slot = "4")]
			public void Execute(int BNNEENLPEFO, TransformAccess KAMDPLLJPAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0x2D79CB0", Offset = "0x2D788B0", VA = "0x182D79CB0")]
			private bool MEOFPHMOLLA(float3 OCBHJKLFMDP, float3 KNAEAKFNOOB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x2D79C40", Offset = "0x2D78840", VA = "0x182D79C40")]
			private bool GBAJILGGGNO(quaternion OCBHJKLFMDP, quaternion KNAEAKFNOOB)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[BurstCompile]
		private struct NBAGPEFKJBK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			[ReadOnly]
			public NativeArray<Entity> FNMNPGEEPJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> PIEFNOMGMAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> OFJIGDCBFIC;

			[Cpp2IlInjected.Token(Token = "0x6000A69")]
			[Cpp2IlInjected.Address(RVA = "0x2D7B0D0", Offset = "0x2D79CD0", VA = "0x182D7B0D0", Slot = "4")]
			public void Execute(int BNNEENLPEFO, TransformAccess KAMDPLLJPAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly FNIDFMEJGMB LMJFFDOEDAB;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private static readonly FNIDFMEJGMB KKKCFOHHPFH;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private static readonly FNIDFMEJGMB ECOPIOJKEAG;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private static readonly ProfilerMarker LFLKJJHACKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private BLGPDOEOCBH GIEFELIPMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private EEHCKCIAPAN KJEBDBMGNJF;

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0390", Offset = "0x2F9EF90", VA = "0x182FA0390", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0400", Offset = "0x2F9F000", VA = "0x182FA0400", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0430", Offset = "0x2F9F030", VA = "0x182FA0430", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[HFIGNCEGOKM(DDEOJCINOPG.TransformSyncing)]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	public class RegisterTransforms : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct MCCNHKAEFJJ : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018A")]
			private struct IKFPFJNFCIN
			{
				[Cpp2IlInjected.Token(Token = "0x200018B")]
				public struct DFJGPOKGGEB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004B7")]
					public LambdaParameterValueProvider_Entity.Runtime HJBCEBNAHHG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004B8")]
					public LambdaParameterValueProvider_IComponentData<HBDFAGMJCIE>.Runtime DNANLMIHFPL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004B9")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime KDEJKHJFEKO;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity DPFMNEOBEKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004B5")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<HBDFAGMJCIE> NNDGCHNKPCH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004B6")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> IKFOGHGDNNJ;

				[Cpp2IlInjected.Token(Token = "0x6000A84")]
				[Cpp2IlInjected.Address(RVA = "0x3DD9880", Offset = "0x3DD8480", VA = "0x183DD9880")]
				public void GKLJKDAGGIM(RegisterTransforms GFHLMIDFMDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A85")]
				[Cpp2IlInjected.Address(RVA = "0x3DD9900", Offset = "0x3DD8500", VA = "0x183DD9900")]
				public DFJGPOKGGEB HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
				{
					return default(DFJGPOKGGEB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private IKFPFJNFCIN MOCCMIIFDDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe IKFPFJNFCIN.DFJGPOKGGEB* NKKBCHLLBEJ;

			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate ENKNKDHOKFC;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x3DDBD50", Offset = "0x3DDA950", VA = "0x183DDBD50")]
			internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, HBDFAGMJCIE BGCNDKINPDJ, Transform KAMDPLLJPAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x3DDBE50", Offset = "0x3DDAA50", VA = "0x183DDBE50", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x3DDBFC0", Offset = "0x3DDABC0", VA = "0x183DDBFC0")]
			public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, ref IKFPFJNFCIN.DFJGPOKGGEB FAHLNAJJNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x3DDBFB0", Offset = "0x3DDABB0", VA = "0x183DDBFB0")]
			public void GKLJKDAGGIM(RegisterTransforms GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x3DDBF40", Offset = "0x3DDAB40", VA = "0x183DDBF40")]
			public unsafe static void FIKCEGMOMMK(ArchetypeChunkIterator* NKPBBGCKHML, void* MOGAJEFFDEG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct DPCFAPFCFJC : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct HENNLOBCDNM
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				[NoAlias]
				public struct NCOGMFFGACM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004BE")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime HJBCEBNAHHG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004BF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<HBDFAGMJCIE>.Runtime DNANLMIHFPL;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004BC")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity DPFMNEOBEKI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004BD")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<HBDFAGMJCIE> NNDGCHNKPCH;

				[Cpp2IlInjected.Token(Token = "0x6000A8A")]
				[Cpp2IlInjected.Address(RVA = "0x3DD62A0", Offset = "0x3DD4EA0", VA = "0x183DD62A0")]
				public void GKLJKDAGGIM(RegisterTransforms GFHLMIDFMDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8B")]
				[Cpp2IlInjected.Address(RVA = "0x3DD8C30", Offset = "0x3DD7830", VA = "0x183DD8C30")]
				public NCOGMFFGACM HDKEDPBCBNO(ref ArchetypeChunk GPHFJJHJEAF, int DBBFJKFIIMD, int IEGFFICLBJC)
				{
					return default(NCOGMFFGACM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			private HENNLOBCDNM MOCCMIIFDDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe HENNLOBCDNM.NCOGMFFGACM* NKKBCHLLBEJ;

			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x3DD6130", Offset = "0x3DD4D30", VA = "0x183DD6130")]
			internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, HBDFAGMJCIE BGCNDKINPDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x3DD6210", Offset = "0x3DD4E10", VA = "0x183DD6210", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0x3DD6300", Offset = "0x3DD4F00", VA = "0x183DD6300")]
			public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref HENNLOBCDNM.NCOGMFFGACM FAHLNAJJNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x3DD62A0", Offset = "0x3DD4EA0", VA = "0x183DD62A0")]
			public void GKLJKDAGGIM(RegisterTransforms GFHLMIDFMDH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private BLGPDOEOCBH GIEFELIPMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private EntityQuery LAJCIAKMEJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private EntityQuery KJKAOJHABJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private EntityQuery EBPPKPKGEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private EntityQuery CBALHHDOCGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private EntityQuery MCIOKMNNJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private ProfilerMarker HJJLCMHBHPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private EntityQuery DIECOGHKJEB;

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x2D7BCF0", Offset = "0x2D7A8F0", VA = "0x182D7BCF0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x2D7CC20", Offset = "0x2D7B820", VA = "0x182D7CC20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x2D7CE30", Offset = "0x2D7BA30", VA = "0x182D7CE30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C0B0", Offset = "0x2D7ACB0", VA = "0x182D7C0B0")]
		private void EEEHHKHBJNC(EntityQuery NJIBLOIMOJA, NNEFJHMAAJD PBCNCKEIKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C740", Offset = "0x2D7B340", VA = "0x182D7C740")]
		private void LGIHGKEDFKA(EntityQuery NJIBLOIMOJA, NNEFJHMAAJD PBCNCKEIKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x2D7CDD0", Offset = "0x2D7B9D0", VA = "0x182D7CDD0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C600", Offset = "0x2D7B200", VA = "0x182D7C600")]
		private void JOMEPIBOCLH(NativeArray<Entity> FNMNPGEEPJI, NNEFJHMAAJD PBCNCKEIKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C2F0", Offset = "0x2D7AEF0", VA = "0x182D7C2F0")]
		[BurstCompile]
		internal static void JDNMENKFMDD(NativeArray<HBDFAGMJCIE> LDMGHOPMIAD, ComponentDataFromEntity<HBDFAGMJCIE> MDFLIOGIIID, NNEFJHMAAJD PBCNCKEIKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		private static void AMGHECHEMOD(Transform KAMDPLLJPAH, Entity LLEBIIAHFDD, int BNNEENLPEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		private static void JHAFFHKIFGM(Entity LLEBIIAHFDD, int BNNEENLPEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		private static void KCPAHODMMGC(int BNNEENLPEFO, NNEFJHMAAJD PBCNCKEIKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x2D7BB10", Offset = "0x2D7A710", VA = "0x182D7BB10")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void AAIIBHIFHCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x2D7C9B0", Offset = "0x2D7B5B0", VA = "0x182D7C9B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x2D7BF10", Offset = "0x2D7AB10", VA = "0x182D7BF10")]
		public static EntityQuery CCDOOOAPINL(ComponentSystemBase GFHLMIDFMDH)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x2D7BD40", Offset = "0x2D7A940", VA = "0x182D7BD40")]
		public static EntityQuery AMHJGGKJAGL(ComponentSystemBase GFHLMIDFMDH)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.TransformSyncing)]
	public class CopyTransformDataToGameObjects : OMEJOMKMFOF, OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		[BurstCompile]
		private struct JJIEFPHONIJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> APFLGCENJNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			[ReadOnly]
			public NativeArray<Entity> FNMNPGEEPJI;

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A3E0", Offset = "0x2D78FE0", VA = "0x182D7A3E0", Slot = "4")]
			public void Execute(int BNNEENLPEFO, TransformAccess KAMDPLLJPAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[BurstCompile]
		private struct HPHOGKDCLLA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> PIEFNOMGMAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[ReadOnly]
			public NativeArray<Entity> FNMNPGEEPJI;

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A240", Offset = "0x2D78E40", VA = "0x182D7A240", Slot = "4")]
			public void Execute(int BNNEENLPEFO, TransformAccess KAMDPLLJPAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[BurstCompile]
		private struct JFGKLLJIIGC : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> PIEFNOMGMAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> OFJIGDCBFIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			[ReadOnly]
			public NativeArray<Entity> FNMNPGEEPJI;

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0x2D7A2E0", Offset = "0x2D78EE0", VA = "0x182D7A2E0", Slot = "4")]
			public void Execute(int BNNEENLPEFO, TransformAccess KAMDPLLJPAH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private static readonly FNIDFMEJGMB LMJFFDOEDAB;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private static readonly FNIDFMEJGMB KKKCFOHHPFH;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private static readonly FNIDFMEJGMB ECOPIOJKEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private BLGPDOEOCBH GIEFELIPMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private EntityQuery GIHLFAKIDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private EntityQuery JBIAFNKFKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private EntityQuery ACPOKIBGOBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TransformAccessArray JJKMBBNKIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TransformAccessArray CEGGKFICNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TransformAccessArray AAONBJGGMGJ;

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x2FA08E0", Offset = "0x2F9F4E0", VA = "0x182FA08E0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0AB0", Offset = "0x2F9F6B0", VA = "0x182FA0AB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0CA0", Offset = "0x2F9F8A0", VA = "0x182FA0CA0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0D30", Offset = "0x2F9F930", VA = "0x182FA0D30", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0D60", Offset = "0x2F9F960", VA = "0x182FA0D60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2FA0930", Offset = "0x2F9F530", VA = "0x182FA0930")]
		private NativeArray<Entity> LJKLBCCAKOO(NativeArray<HBDFAGMJCIE> EMLNAJJBPOG, NativeList<Entity> OHKHEJKMDKP, TransformAccessArray CNFNIAOGDMI, TransformAccessArray LNPOFCDEHDP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.TransformSyncing)]
	public class CopyTransformParentsToGameObjects : OMEJOMKMFOF, HMFGCABFMPC
	{
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private CILKMKKIBEF GMPFBLKMEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private EAAOOBCMLAD HCNMCJADDJL;

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x2A97F90", Offset = "0x2A96B90", VA = "0x182A97F90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x2FA18B0", Offset = "0x2FA04B0", VA = "0x182FA18B0", Slot = "14")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA19C0", Offset = "0x2FA05C0", VA = "0x182FA19C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x2FA1730", Offset = "0x2FA0330", VA = "0x182FA1730")]
		private static void OHANADCKCNM(EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Entity GEOFAMNLJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x2FA1690", Offset = "0x2FA0290", VA = "0x182FA1690")]
		private static bool JCBPEMMLHHC(EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, out Transform KAMDPLLJPAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[HFIGNCEGOKM(DDEOJCINOPG.TransformSyncing)]
	public class L2PToL2WHierarchy : OMEJOMKMFOF
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct HHNPDDMKEKF : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> HOOLOPMAAHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> LBKOGOJPHLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> KKJOINPPLHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> GBHJGAKDCJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			public ArchetypeChunkComponentType<LocalToWorldData> OLKNJBDFMHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> BPFNBPKPGLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public uint BBEIAHBPPCB;

			[Cpp2IlInjected.Token(Token = "0x6000AA5")]
			[Cpp2IlInjected.Address(RVA = "0x3DD93A0", Offset = "0x3DD7FA0", VA = "0x183DD93A0")]
			[Conditional("DEBUG_BUILD")]
			private void PCFGNOBPMKE(Entity LLEBIIAHFDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0x3DD8CB0", Offset = "0x3DD78B0", VA = "0x183DD8CB0", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int BNNEENLPEFO, int MMAJILFCCGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0x3DD8FA0", Offset = "0x3DD7BA0", VA = "0x183DD8FA0")]
			private void OFFKJEBLNHC(float4x4 IDEKEHMFOOB, Entity LLEBIIAHFDD, bool DHMBCHLFAPM, int EMDDAPNEEHK = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private EntityQuery OIFJKNFCHGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private EntityQuery JBFDMJJECPI;

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x2AB83F0", Offset = "0x2AB6FF0", VA = "0x182AB83F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x2AB8510", Offset = "0x2AB7110", VA = "0x182AB8510", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class LGKIIHFHEHD : CGKIMGNLKPC
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[BurstCompile]
	private struct GJIDFAPHFFG : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> HOOLOPMAAHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public ArchetypeChunkComponentType<LocalToWorldData> OLKNJBDFMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public uint BBEIAHBPPCB;

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x3DD8630", Offset = "0x3DD7230", VA = "0x183DD8630", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int BNNEENLPEFO, int MMAJILFCCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x3DD8730", Offset = "0x3DD7330", VA = "0x183DD8730")]
		public bool IAAAGEFBFAH(ArchetypeChunk CNILJNKKOIK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery OIFJKNFCHGE;

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA580", Offset = "0x2AB9180", VA = "0x182ABA580", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA6B0", Offset = "0x2AB92B0", VA = "0x182ABA6B0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle FJEEDCCNLHF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public LGKIIHFHEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public class HJCIDACDICK : CGKIMGNLKPC
{
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[BurstCompile]
	private struct LPKKEJCOEJE : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> LFECADPBIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public ArchetypeChunkComponentType<WorldPoseData> JCKPHEJPPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> HBBGENHEEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> KCIGCENFFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public uint BBEIAHBPPCB;

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB2B0", Offset = "0x3DD9EB0", VA = "0x183DDB2B0", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int BNNEENLPEFO, int MMAJILFCCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB660", Offset = "0x3DDA260", VA = "0x183DDB660")]
		public bool IAAAGEFBFAH(ArchetypeChunk CNILJNKKOIK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private EntityQuery KKELBBDIJCG;

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB600", Offset = "0x2AAA200", VA = "0x182AAB600", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB710", Offset = "0x2AAA310", VA = "0x182AAB710", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle FJEEDCCNLHF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40")]
	public HJCIDACDICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public class JKBACEFFNEO : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[BurstCompile]
	private struct DLIMFFIIFOL : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> NGAHLNGLHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> BJJBIGKLEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> NIECALBNLBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public ArchetypeChunkComponentType<LocalToParentData> DHGEFKPJLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public uint BBEIAHBPPCB;

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x3DD5940", Offset = "0x3DD4540", VA = "0x183DD5940", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int BNNEENLPEFO, int MMAJILFCCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x3DD6050", Offset = "0x3DD4C50", VA = "0x183DD6050")]
		public bool IAAAGEFBFAH(ArchetypeChunk CNILJNKKOIK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private EntityQuery KKELBBDIJCG;

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1A50", Offset = "0x2AB0650", VA = "0x182AB1A50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1B80", Offset = "0x2AB0780", VA = "0x182AB1B80", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle FJEEDCCNLHF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x6DECE0", Offset = "0x6DD8E0", VA = "0x1806DECE0")]
	public JKBACEFFNEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[HFIGNCEGOKM(DDEOJCINOPG.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : LJGIGCFJLFM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		public struct HPEEPLJKPCL : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType EHLMHLBPCCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0x2A98A00", Offset = "0x2A97600", VA = "0x182A98A00", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override ComponentType FNGLFBHNMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x2A989D0", Offset = "0x2A975D0", VA = "0x182A989D0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override ComponentType LPDOHFENIEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0x2A989A0", Offset = "0x2A975A0", VA = "0x182A989A0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x2A98900", Offset = "0x2A97500", VA = "0x182A98900")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0xF87B40", Offset = "0xF86740", VA = "0x180F87B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[COFLBKKDFAJ(KDONHBHPBNG.Game)]
public class GGMKMJKODIE : GGGPKHLAKHC
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public Type PKEJLOOOFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABF")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5D50", Offset = "0x2AA4950", VA = "0x182AA5D50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Type[] FGIAFNBEECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5DC0", Offset = "0x2AA49C0", VA = "0x182AA5DC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public GGMKMJKODIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[COFLBKKDFAJ(KDONHBHPBNG.Loading)]
public class BPNGFIPDCDI : GGGPKHLAKHC
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Type PKEJLOOOFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CD70", VA = "0x18067E170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type[] FGIAFNBEECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x2F94170", Offset = "0x2F92D70", VA = "0x182F94170", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public BPNGFIPDCDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public sealed class EFLFDNJEMGD : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x2FA7A50", Offset = "0x2FA6650", VA = "0x182FA7A50", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public EFLFDNJEMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[COFLBKKDFAJ(KDONHBHPBNG.Saving)]
public class ANJPCIIOKKM : GGGPKHLAKHC
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type PKEJLOOOFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CD70", VA = "0x18067E170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type[] FGIAFNBEECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x2F8D9C0", Offset = "0x2F8C5C0", VA = "0x182F8D9C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public ANJPCIIOKKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public sealed class PLCPFLFHNJK : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x2A91D30", Offset = "0x2A90930", VA = "0x182A91D30", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public PLCPFLFHNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[COFLBKKDFAJ(KDONHBHPBNG.Simulation)]
public class NCEJFPEHLHK : GGGPKHLAKHC
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type PKEJLOOOFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BE80", Offset = "0x2A7AA80", VA = "0x182A7BE80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type[] FGIAFNBEECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BEF0", Offset = "0x2A7AAF0", VA = "0x182A7BEF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public NCEJFPEHLHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[DAMCBGMFJNJ(typeof(FPNEIPINEAH), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
internal class FPNEIPINEAH : HMFGCABFMPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private global::CGIPMGPHDJK<AuthoredParentData, JGHIKCNOOHM, OEGFJDMDGMA, AuthoredChildrenData> KEMGMCGNOOM;

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4800", Offset = "0x2AA3400", VA = "0x182AA4800", Slot = "4")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public FPNEIPINEAH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	[HFIGNCEGOKM(DDEOJCINOPG.HierarchySystems)]
	[DAMCBGMFJNJ(typeof(EntityHierarchyParents), new string[] { })]
	internal sealed class EntityHierarchyParents : OHFJHEDBJHF, HMFGCABFMPC
	{
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[NHBEJKCIJLO]
		private JOBGNDCAMAM KKELBBDIJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[NHBEJKCIJLO]
		private PropertyChangeNetworkRouter KMCOGBENCBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private global::HFPFDBLLPPK<Entity> GCEENFOFNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private global::CGIPMGPHDJK<ParentData, FJFDCFFBHDE, LGEJCELLDDI, ChildrenData> KEMGMCGNOOM;

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1E20", Offset = "0x2AA0A20", VA = "0x182AA1E20", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x2AA21C0", Offset = "0x2AA0DC0", VA = "0x182AA21C0", Slot = "5")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1E90", Offset = "0x2AA0A90", VA = "0x182AA1E90")]
		public Entity DJKFCHELMJI(Entity LLEBIIAHFDD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1EE0", Offset = "0x2AA0AE0", VA = "0x182AA1EE0")]
		public bool HKIAAFFILCD(Entity LLEBIIAHFDD, Entity JJHAACNMGFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x2AA2120", Offset = "0x2AA0D20", VA = "0x182AA2120")]
		public bool LHJCDGMFADO(Entity LLEBIIAHFDD, Entity JJHAACNMGFO, bool CHPHLJOKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA1F40", Offset = "0x2AA0B40", VA = "0x182AA1F40")]
		private bool JDIPELLFNNO(Entity LLEBIIAHFDD, Entity JJHAACNMGFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[DAMCBGMFJNJ(typeof(LPBEHADBKMD), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
internal sealed class LPBEHADBKMD : OHFJHEDBJHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	[NHBEJKCIJLO]
	private EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery BPAHOIDHMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private bool IBOHJGMEBIO;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private EntityManager FAINNDBCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x2ABD510", Offset = "0x2ABC110", VA = "0x182ABD510")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x2ABC990", Offset = "0x2ABB590", VA = "0x182ABC990", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x2ABCBC0", Offset = "0x2ABB7C0", VA = "0x182ABCBC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD2D0", Offset = "0x2ABBED0", VA = "0x182ABD2D0")]
	public bool NLDBNJEFDEH(Entity LLEBIIAHFDD, Entity NMJJIOLIMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD390", Offset = "0x2ABBF90", VA = "0x182ABD390")]
	public IEnumerable<Entity> OEGOHCELJAI(Entity LLEBIIAHFDD, bool HOJIMILIDNA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x2ABCBE0", Offset = "0x2ABB7E0", VA = "0x182ABCBE0")]
	public bool HDGJJPALPML(Entity LLEBIIAHFDD, Entity DBNJJKLOCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD560", Offset = "0x2ABC160", VA = "0x182ABD560")]
	public bool PGPKCLNGJPJ(Entity LLEBIIAHFDD, Entity ADDDKDIDHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x2ABCA90", Offset = "0x2ABB690", VA = "0x182ABCA90")]
	public NativeList<Entity> AILKEPHEJLI(Entity LLEBIIAHFDD, bool HOJIMILIDNA = false, Allocator PBEDBDBGIPF = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x2ABCFE0", Offset = "0x2ABBBE0", VA = "0x182ABCFE0")]
	public IEnumerable<Entity> LBLBJIKOPHN(Entity LLEBIIAHFDD, bool HOJIMILIDNA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2ABCD10", Offset = "0x2ABB910", VA = "0x182ABCD10")]
	public Entity IENNNAFGFNJ(Entity LLEBIIAHFDD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2ABCB70", Offset = "0x2ABB770", VA = "0x182ABCB70")]
	public NativeArray<Entity> BBCNGMBMGMH()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x2ABCDC0", Offset = "0x2ABB9C0", VA = "0x182ABCDC0")]
	public bool KCBAGPAHKEE(Entity ADDDKDIDHPJ, Entity LCEKCMGAGEI, out Entity BKMGHCEAABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x2ABD1E0", Offset = "0x2ABBDE0", VA = "0x182ABD1E0")]
	private Entity MJGKPNPKLCE(Entity LLEBIIAHFDD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public LPBEHADBKMD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[HFIGNCEGOKM(DDEOJCINOPG.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x3143670", Offset = "0x3142270", VA = "0x183143670")]
		public static void BLNLPEOGOOG<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(PGEEJALGCGE HFDOFHJBJGD, global::GPAKIDKFMKC<Entity> BBEHMKMODBA, out global::CGIPMGPHDJK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> NJHEKOHHLCP) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, JIGEDONNEFC where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, JIGEDONNEFC, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x2A934B0", Offset = "0x2A920B0", VA = "0x182A934B0")]
		public static bool ONMEOBADCPC(MFPKOBHCDLK BDEPBKMNBCE)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public class CGIPMGPHDJK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, JIGEDONNEFC where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, JIGEDONNEFC, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private static readonly FNIDFMEJGMB CBDAGBGGFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly global::HFPFDBLLPPK<Entity> GCEENFOFNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly AOHDOMEMLII FOKLAKGHONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly HLBEOPKMMDF GEOFAMNLJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly EntityManager CLLNDNAAIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly EAAOOBCMLAD HCNMCJADDJL;

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x309FC80", Offset = "0x309E880", VA = "0x18309FC80")]
	public CGIPMGPHDJK(PGEEJALGCGE HFDOFHJBJGD, global::GPAKIDKFMKC<Entity> BBEHMKMODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x309ECB0", Offset = "0x309D8B0", VA = "0x18309ECB0")]
	private bool GEPJLJJDIHJ(Entity LLEBIIAHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x309F5E0", Offset = "0x309E1E0", VA = "0x18309F5E0")]
	private bool POMHFDCKGPD(Entity LLEBIIAHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x309EE60", Offset = "0x309DA60", VA = "0x18309EE60")]
	public bool HKIAAFFILCD(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x309F3F0", Offset = "0x309DFF0", VA = "0x18309F3F0")]
	public bool JEFEBMEICLK(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x309EFB0", Offset = "0x309DBB0", VA = "0x18309EFB0")]
	private bool JEFEBMEICLK(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO, bool LEIIDLJOFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	private static void GOJGDDJKMMJ(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	private static void AHADLPEFNPN(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	private static void IAHCIOOOEJG(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	private static void KENIONIEPGE(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	private static void MDOCPIFMJOG(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x309F420", Offset = "0x309E020", VA = "0x18309F420")]
	private bool NLDBNJEFDEH(Entity LLEBIIAHFDD, Entity NMJJIOLIMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x309ED70", Offset = "0x309D970", VA = "0x18309ED70")]
	private void GGMHOEOCIJE(Entity LLEBIIAHFDD, in Entity KAEGMLMLAJA, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x309E5E0", Offset = "0x309D1E0", VA = "0x18309E5E0")]
	private void COCCFIDEPMD(Entity LLEBIIAHFDD, in Entity KAEGMLMLAJA, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x309E980", Offset = "0x309D580", VA = "0x18309E980")]
	private bool FOPOKINIIOF(NBKGNKNEBLA MMEPAJOGBCG, in ELJHNEOGEBP ILLHAAGJBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x309EB80", Offset = "0x309D780", VA = "0x18309EB80")]
	private void GCAONDBJOCG(Entity GEOFAMNLJNK, Entity DBNJJKLOCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x309EF20", Offset = "0x309DB20", VA = "0x18309EF20")]
	private void JDFBMCLFMDD(Entity GEOFAMNLJNK, Entity DBNJJKLOCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	private void KCPAHODMMGC(Entity LLEBIIAHFDD, Entity KAEGMLMLAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	private void AMGHECHEMOD(Entity LLEBIIAHFDD, Entity JJHAACNMGFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public struct LEAIEINEBGN : NEJDHLEFDKK, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public ECALDJBELBI JJELKCAHCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x677000", Offset = "0x675C00", VA = "0x180677000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(ECALDJBELBI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x6DC4E0", Offset = "0x6DB0E0", VA = "0x1806DC4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[DAMCBGMFJNJ(typeof(ObjectEmbodimentService), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.Embodiment)]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	internal sealed class ObjectEmbodimentService : PFBMKGBLLGM, KGABHKADGEM, OHFJHEDBJHF, HMFGCABFMPC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private ObjectLifecycleService KOGKJOIDDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[NHBEJKCIJLO]
		private JOBGNDCAMAM KKELBBDIJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[NHBEJKCIJLO]
		private MCFPIPCNFDN KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		[NHBEJKCIJLO]
		private IODHNFLDMAC PFNEAPNCEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		[NHBEJKCIJLO]
		private ANAIOGLOEGC HBIPPHEOFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		[NHBEJKCIJLO]
		private TransformOwnershipPhase FGMCPHKBIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private readonly Dictionary<ELJHNEOGEBP, IAEGHKEFOHF> BOGKEAKPGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private LKENFMAMPOC FFGLEONGEJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private bool IBOHJGMEBIO;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		private EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0x2A86090", Offset = "0x2A84C90", VA = "0x182A86090")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public int LJMLBAGHLCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0x2A84CC0", Offset = "0x2A838C0", VA = "0x182A84CC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public int HBEHIIKMMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x2A82B60", Offset = "0x2A81760", VA = "0x182A82B60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x1025B30", Offset = "0x1024730", VA = "0x181025B30", Slot = "4")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x2A82920", Offset = "0x2A81520", VA = "0x182A82920", Slot = "5")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x2A84340", Offset = "0x2A82F40", VA = "0x182A84340")]
		public void HBCCNGJCDAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x2A860E0", Offset = "0x2A84CE0", VA = "0x182A860E0", Slot = "6")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x2A835A0", Offset = "0x2A821A0", VA = "0x182A835A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x2A86070", Offset = "0x2A84C70", VA = "0x182A86070")]
		public int OIMLPEECHCL(SceneTag IEGFBJCKFAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x2A83130", Offset = "0x2A81D30", VA = "0x182A83130")]
		public int DFKHICOABHK(SceneTag IEGFBJCKFAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x2A84390", Offset = "0x2A82F90", VA = "0x182A84390")]
		public bool HECBAEPNNDN(Entity LLEBIIAHFDD, Allocator PBEDBDBGIPF, out NativeList<Entity> KLMDHDMFOEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x2A840F0", Offset = "0x2A82CF0", VA = "0x182A840F0")]
		public bool GIBIOPECHFP(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x2A84050", Offset = "0x2A82C50", VA = "0x182A84050")]
		public bool FEOLDMHKLBA(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x2A852D0", Offset = "0x2A83ED0", VA = "0x182A852D0")]
		public bool LFCLKAMJJHD(Entity LLEBIIAHFDD, out IAEGHKEFOHF DPCGPJIEFDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x2A85340", Offset = "0x2A83F40", VA = "0x182A85340")]
		private bool LFCLKAMJJHD(Transform KAMDPLLJPAH, out IAEGHKEFOHF DPCGPJIEFDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x2A86460", Offset = "0x2A85060", VA = "0x182A86460")]
		private void PLNMOHEFKNP(Entity LLEBIIAHFDD, IAEGHKEFOHF DPCGPJIEFDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x2A84B80", Offset = "0x2A83780", VA = "0x182A84B80")]
		private bool IJLCDGHNMAI(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x2A83960", Offset = "0x2A82560", VA = "0x182A83960")]
		public void EHMHLLLMBAF(ELJHNEOGEBP FFJHOAAMJMD, IAEGHKEFOHF DJGPJGBFCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x2A82CC0", Offset = "0x2A818C0", VA = "0x182A82CC0")]
		public bool BOOCFLMOEMK(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x2A853F0", Offset = "0x2A83FF0", VA = "0x182A853F0")]
		public bool MBLEKNDNMJF(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x2A85B10", Offset = "0x2A84710", VA = "0x182A85B10")]
		public bool MBLEKNDNMJF(Entity LLEBIIAHFDD, [Optional] object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x2A85B60", Offset = "0x2A84760", VA = "0x182A85B60")]
		public bool MBLEKNDNMJF(IAEGHKEFOHF BDEPBKMNBCE, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x2A83180", Offset = "0x2A81D80", VA = "0x182A83180")]
		public bool DGOFNAPNLLM(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x2A83150", Offset = "0x2A81D50", VA = "0x182A83150")]
		public bool DGOFNAPNLLM(IAEGHKEFOHF DPCGPJIEFDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x2A857A0", Offset = "0x2A843A0", VA = "0x182A857A0")]
		public bool MBLEKNDNMJF(IAEGHKEFOHF DPCGPJIEFDH, [Optional] object JJFHDFJGCDG, bool JOGFOOOHGFG = false, bool PFGOMMKDMKL = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x2A83B60", Offset = "0x2A82760", VA = "0x182A83B60")]
		public Transform EICBEGAJFIO(Entity LLEBIIAHFDD, [Optional] object JJFHDFJGCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x2A84CE0", Offset = "0x2A838E0", VA = "0x182A84CE0")]
		public bool JCBPEMMLHHC(Entity LLEBIIAHFDD, out Transform KAMDPLLJPAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2A851E0", Offset = "0x2A83DE0", VA = "0x182A851E0")]
		public IAEGHKEFOHF KOGFABJEPCO(Entity LLEBIIAHFDD, [Optional] object JJFHDFJGCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2A836D0", Offset = "0x2A822D0", VA = "0x182A836D0")]
		public void EACAKCNLMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2A85C40", Offset = "0x2A84840", VA = "0x182A85C40")]
		public void NEJFDHNHMPF(SceneTag IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x2A84720", Offset = "0x2A83320", VA = "0x182A84720")]
		private void IBICBPLBJBK(Entity LLEBIIAHFDD, bool PKIPEBDNJEO, bool CLADFGPLOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x2A83060", Offset = "0x2A81C60", VA = "0x182A83060")]
		private void BPIANOMCKIG(Entity LLEBIIAHFDD, IAEGHKEFOHF DPCGPJIEFDH, bool PKIPEBDNJEO, bool CLADFGPLOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x2A83550", Offset = "0x2A82150", VA = "0x182A83550")]
		public IAEGHKEFOHF DJFAAIGKFKG(Entity LLEBIIAHFDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x2A82C40", Offset = "0x2A81840", VA = "0x182A82C40")]
		public bool BOLFGPMHGFA(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x2A84070", Offset = "0x2A82C70", VA = "0x182A84070")]
		public bool FKAOODJLIPP(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2A86000", Offset = "0x2A84C00", VA = "0x182A86000")]
		public bool NFEPDLIEMIB(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x2A845E0", Offset = "0x2A831E0", VA = "0x182A845E0")]
		public bool HFJCFCGMDPD(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x2A84650", Offset = "0x2A83250", VA = "0x182A84650")]
		public bool HFJCFCGMDPD(ECALDJBELBI DKBLPJPHEMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void JJMEBKCFFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x2A82B80", Offset = "0x2A81780", VA = "0x182A82B80")]
		private void BNCEGFAAGFK(bool OONKNMNHLIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2A83CD0", Offset = "0x2A828D0", VA = "0x182A83CD0")]
		private bool EIPIJDFCJON(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2A84AE0", Offset = "0x2A836E0", VA = "0x182A84AE0")]
		private IAEGHKEFOHF IFKECEGLBGP(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x2A84FF0", Offset = "0x2A83BF0", VA = "0x182A84FF0")]
		private IAEGHKEFOHF JOCPAGHPJOJ(Entity LLEBIIAHFDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x2A83D60", Offset = "0x2A82960", VA = "0x182A83D60")]
		private (Vector3, Quaternion, Vector3) EJHMCMJDNFC(Entity LLEBIIAHFDD)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x2A82A50", Offset = "0x2A81650", VA = "0x182A82A50")]
		private void AFKMLBCIJHF(Entity LLEBIIAHFDD, OADLDHPKENB FKEOEHMKOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x2A85B80", Offset = "0x2A84780", VA = "0x182A85B80")]
		private void MEGHOBENLKP(IOBECAADPPL DKHOCCDNDOH, IAEGHKEFOHF DJGPJGBFCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x2A84BA0", Offset = "0x2A837A0", VA = "0x182A84BA0")]
		private void ILMCIKMIMIE(IAEGHKEFOHF DJGPJGBFCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x2A86230", Offset = "0x2A84E30", VA = "0x182A86230")]
		private void OKMDGJPIEEI(IAEGHKEFOHF DPCGPJIEFDH, Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x2A84DB0", Offset = "0x2A839B0", VA = "0x182A84DB0")]
		private void JNKHAHDNCPD(Entity LLEBIIAHFDD, IAEGHKEFOHF DPCGPJIEFDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x2A864F0", Offset = "0x2A850F0", VA = "0x182A864F0")]
		private void PMBHODJGDCB(Entity LLEBIIAHFDD, Transform KAMDPLLJPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x2A83100", Offset = "0x2A81D00", VA = "0x182A83100")]
		private IOBECAADPPL CFMDJONBEKN(Entity LLEBIIAHFDD)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x2A86620", Offset = "0x2A85220", VA = "0x182A86620")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2A83F80", Offset = "0x2A82B80", VA = "0x182A83F80")]
		[CompilerGenerated]
		private void ELDHADDGGNG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal static class FELJDFPKDAC
{
	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x2AA3D00", Offset = "0x2AA2900", VA = "0x182AA3D00")]
	public static IAEGHKEFOHF KOGFABJEPCO(this ObjectEmbodimentService MNJGLAAEFPK, IOBECAADPPL DKHOCCDNDOH, [Optional] object JJFHDFJGCDG)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[HFIGNCEGOKM(DDEOJCINOPG.Lifecycle)]
	[DAMCBGMFJNJ(typeof(ObjectLifecycleService), new string[] { })]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	internal sealed class ObjectLifecycleService : OHFJHEDBJHF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private ObjectEmbodimentService DPCGPJIEFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN KJEBDBMGNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private LBONPJJMDCB PFBOJJELPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private DestroyLocalObjects ILFNLHPDLFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private bool IBOHJGMEBIO;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0x2A87D20", Offset = "0x2A86920", VA = "0x182A87D20")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<Entity, OADLDHPKENB> JKKKCONJDDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x2A86F10", Offset = "0x2A85B10", VA = "0x182A86F10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0x2A86FB0", Offset = "0x2A85BB0", VA = "0x182A86FB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<Entity> KFPBKIEFJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x2A87C80", Offset = "0x2A86880", VA = "0x182A87C80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0x2A87720", Offset = "0x2A86320", VA = "0x182A87720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2A86E30", Offset = "0x2A85A30", VA = "0x182A86E30", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x82C9E0", Offset = "0x82B5E0", VA = "0x18082C9E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2A87160", Offset = "0x2A85D60", VA = "0x182A87160")]
		public bool FONENOMBNOF(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x2A87C20", Offset = "0x2A86820", VA = "0x182A87C20")]
		internal void MCPDDMJDBPC(Entity LLEBIIAHFDD, OADLDHPKENB FKEOEHMKOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2A87520", Offset = "0x2A86120", VA = "0x182A87520")]
		public void HNJDDIFBIFG(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x2A87050", Offset = "0x2A85C50", VA = "0x182A87050")]
		public void CKMHIJEDKHF(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2A870A0", Offset = "0x2A85CA0", VA = "0x182A870A0")]
		private bool DPMELFLAKPB(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2A877C0", Offset = "0x2A863C0", VA = "0x182A877C0")]
		public void KDKECGLKPJA(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x2A87560", Offset = "0x2A86160", VA = "0x182A87560")]
		private bool IAPGMBIDGBE(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2A87490", Offset = "0x2A86090", VA = "0x182A87490")]
		public void HFPMFHPHKJM(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2A87230", Offset = "0x2A85E30", VA = "0x182A87230")]
		private void GJFCGBCEBDM(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2A879C0", Offset = "0x2A865C0", VA = "0x182A879C0")]
		private void KGKOLNGMEDG(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2A871E0", Offset = "0x2A85DE0", VA = "0x182A871E0")]
		public void GHMIAIGFAAN(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		private void HJPPMHEKAGG(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2A87290", Offset = "0x2A85E90", VA = "0x182A87290")]
		private void HCEDJNAABHK(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[DAMCBGMFJNJ(typeof(ObjectPrefabs), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.Prefabs)]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	internal class ObjectPrefabs : BDJJCEGPPNF, OHFJHEDBJHF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private sealed class PCCBGGBJJNG : IEnumerable<(CKLKKHOPBLL, OADLDHPKENB)>, IEnumerable, IEnumerator<(CKLKKHOPBLL, OADLDHPKENB)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private (CKLKKHOPBLL primitiveType, OADLDHPKENB prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x17000137")]
			private (CKLKKHOPBLL, OADLDHPKENB) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6C")]
				[Cpp2IlInjected.Address(RVA = "0x11924F0", Offset = "0x11910F0", VA = "0x1811924F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((CKLKKHOPBLL, OADLDHPKENB));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000138")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6E")]
				[Cpp2IlInjected.Address(RVA = "0x3DDD8C0", Offset = "0x3DDC4C0", VA = "0x183DDD8C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4310", Offset = "0x3DD2F10", VA = "0x183DD4310")]
			[DebuggerHidden]
			public PCCBGGBJJNG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD6E0", Offset = "0x3DDC2E0", VA = "0x183DDD6E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD880", Offset = "0x3DDC480", VA = "0x183DDD880", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD7E0", Offset = "0x3DDC3E0", VA = "0x183DDD7E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(CKLKKHOPBLL, OADLDHPKENB)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0x3DDD7E0", Offset = "0x3DDC3E0", VA = "0x183DDD7E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN KJEBDBMGNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private World AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private readonly Dictionary<OADLDHPKENB, Entity> DEBJMFLLNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private readonly Dictionary<OADLDHPKENB, EntityArchetype> IMDOBIMILJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private readonly Dictionary<CKLKKHOPBLL, OADLDHPKENB> KCMLGANJNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private readonly Dictionary<NFAEFFLJLPD, OADLDHPKENB> IDHHEDJHJAL;

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int EONFJIOMKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0x2A8AAB0", Offset = "0x2A896B0", VA = "0x182A8AAB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x2A8BA50", Offset = "0x2A8A650", VA = "0x182A8BA50")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A270", Offset = "0x2A88E70", VA = "0x182A8A270", Slot = "5")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AB00", Offset = "0x2A89700", VA = "0x182A8AB00", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AF70", Offset = "0x2A89B70", VA = "0x182A8AF70")]
		internal IEnumerable<Type> GLGFDHOEKIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A650", Offset = "0x2A89250", VA = "0x182A8A650")]
		internal CBHBFIGOJJC BGBJHDPJPFE(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A6C0", Offset = "0x2A892C0", VA = "0x182A8A6C0")]
		public EntityArchetype BGIJKCJPACC(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B760", Offset = "0x2A8A360", VA = "0x182A8B760")]
		public NativeHashMap<int, EntityArchetype> JOFNKCMPBBC(Allocator PBEDBDBGIPF = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AF00", Offset = "0x2A89B00", VA = "0x182A8AF00")]
		public bool GGGEPPDMJAM(OADLDHPKENB FKEOEHMKOOO, out EntityArchetype HNNIEOPALKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AE90", Offset = "0x2A89A90", VA = "0x182A8AE90", Slot = "4")]
		[IteratorStateMachine(typeof(PCCBGGBJJNG))]
		public IEnumerable<(CKLKKHOPBLL, OADLDHPKENB)> EJGGFAKDIJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B650", Offset = "0x2A8A250", VA = "0x182A8B650")]
		public Entity HOELGELKEPN(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A930", Offset = "0x2A89530", VA = "0x182A8A930")]
		public OADLDHPKENB DEOOPJFHNNH(NFAEFFLJLPD BIEGICDMJCM)
		{
			return default(OADLDHPKENB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A8D0", Offset = "0x2A894D0", VA = "0x182A8A8D0")]
		public OADLDHPKENB DEOOPJFHNNH(CKLKKHOPBLL BIEGICDMJCM)
		{
			return default(OADLDHPKENB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B8E0", Offset = "0x2A8A4E0", VA = "0x182A8B8E0")]
		public NativeHashMap<int, Entity> NGEJDCAKHOG(Allocator PBEDBDBGIPF = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A720", Offset = "0x2A89320", VA = "0x182A8A720")]
		public IEnumerable<OADLDHPKENB> BPNNFLIHJCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AE30", Offset = "0x2A89A30", VA = "0x182A8AE30")]
		public Entity EALMKFHLDHO(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BA70", Offset = "0x2A8A670", VA = "0x182A8BA70")]
		public bool OJFKBJNEHAM(OADLDHPKENB FKEOEHMKOOO, out Entity CNGLOEJDOMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2A8B200", Offset = "0x2A89E00", VA = "0x182A8B200")]
		private void HEOLEHHENBD(CBHBFIGOJJC EGLDBKANHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x2A8AFD0", Offset = "0x2A89BD0", VA = "0x182A8AFD0")]
		internal void GNNCHHEOBMA(OADLDHPKENB FKEOEHMKOOO, FEBPDFEEBHG PEHGAICDNFL, JAOIHGPNOHJ HOBLDAOCCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A770", Offset = "0x2A89370", VA = "0x182A8A770")]
		private void CCAPHKONKOI(OADLDHPKENB FKEOEHMKOOO, FEBPDFEEBHG ECOKHAGGAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A990", Offset = "0x2A89590", VA = "0x182A8A990")]
		internal Entity DHAMELJAOPJ(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x2A8BB30", Offset = "0x2A8A730", VA = "0x182A8BB30")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public enum DBJHEIPMAIM
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface LPIBEGOKOJB
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	World HDBHOPCOJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	DPNDFOCCADL OLOCLANFPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
internal class OCBHPOAFHKL : FKGNDDGLAFM, DJJBHNJFKFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly GDHNKHLBLBK DGBCJBAMILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private readonly DBJHEIPMAIM FGMCPHKBIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private readonly List<CPEEMCFAHKB> GAEMHLFALLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private NativeMultiHashMap<Entity, GEKCNMCMNCD> ADFPKKDJJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private NativeHashMap<int, int> FBOLEHMLEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private JobHandle CBFGAJCBPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private JobHandle LEINMECODNN;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private World OHPKNCCEHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F740", Offset = "0x2A7E340", VA = "0x182A7F740", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private DPNDFOCCADL HKEACGFNIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2A7F9D0", Offset = "0x2A7E5D0", VA = "0x182A7F9D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private GIMLBHPKKEP FDFDIFALMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x68BD40", Offset = "0x68A940", VA = "0x18068BD40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private NativeMultiHashMap<Entity, GEKCNMCMNCD> JPIJPICEMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x698030", Offset = "0x696C30", VA = "0x180698030", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, GEKCNMCMNCD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JobHandle AGHBGNDOKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x13C5490", Offset = "0x13C4090", VA = "0x1813C5490", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x13D8AE0", Offset = "0x13D76E0", VA = "0x1813D8AE0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private bool AAKNGNKAPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7EDC0", Offset = "0x2A7D9C0", VA = "0x182A7EDC0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private World NPGNFOCNKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7ED60", Offset = "0x2A7D960", VA = "0x182A7ED60", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FB50", Offset = "0x2A7E750", VA = "0x182A7FB50")]
	public OCBHPOAFHKL(GDHNKHLBLBK DGBCJBAMILD, DBJHEIPMAIM FGMCPHKBIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F550", Offset = "0x2A7E150", VA = "0x182A7F550", Slot = "11")]
	private void HHLFPJBFCMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F650", Offset = "0x2A7E250", VA = "0x182A7F650", Slot = "10")]
	private bool HPBDCOPCHHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F9F0", Offset = "0x2A7E5F0", VA = "0x182A7F9F0", Slot = "12")]
	private void MAHLCHGGJGC(ComponentType JIOJHELJNAL, in CPEEMCFAHKB LBAGLBIEDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FB20", Offset = "0x2A7E720", VA = "0x182A7FB20", Slot = "13")]
	private bool PNIOKIKLCAO(OADLDHPKENB FKEOEHMKOOO, out Entity CNGLOEJDOMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F7A0", Offset = "0x2A7E3A0", VA = "0x182A7F7A0", Slot = "16")]
	private bool KCJODIFGPIK(out NativeArray<int> FOFDGMLFLEB, Allocator PBEDBDBGIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F3D0", Offset = "0x2A7DFD0", VA = "0x182A7F3D0", Slot = "17")]
	private bool GLJKJBNHECA(ComponentType JIOJHELJNAL, out CPEEMCFAHKB DPMEJCEEHOC, out BCLCKEMNKIB MEOBJDMPABM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F2A0", Offset = "0x2A7DEA0", VA = "0x182A7F2A0", Slot = "18")]
	private bool GLJKJBNHECA(ComponentType JIOJHELJNAL, out CPEEMCFAHKB DPMEJCEEHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F560", Offset = "0x2A7E160", VA = "0x182A7F560", Slot = "19")]
	private CPEEMCFAHKB HLCCGKDLLIM(ComponentType JIOJHELJNAL)
	{
		return default(CPEEMCFAHKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F840", Offset = "0x2A7E440", VA = "0x182A7F840", Slot = "20")]
	private BOMPDGMHJDM KIEIKPEFEKA()
	{
		return default(BOMPDGMHJDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x2A7FAE0", Offset = "0x2A7E6E0", VA = "0x182A7FAE0", Slot = "21")]
	private void PLOGMGOJPEN(JobHandle BLJNDDIDOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x2A7EFF0", Offset = "0x2A7DBF0", VA = "0x182A7EFF0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x2A7EDD0", Offset = "0x2A7D9D0", VA = "0x182A7EDD0")]
	private bool GBAEDFDFLCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x2A7F880", Offset = "0x2A7E480", VA = "0x182A7F880")]
	private int LGLONHGMHLJ()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
internal class GDHNKHLBLBK : LPIBEGOKOJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public EEHCKCIAPAN KJEBDBMGNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public ObjectInstantiationService DEBJMFLLNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public DPNDFOCCADL JOCNBHOKKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public GIMLBHPKKEP NGOIDBPIDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public BNONGLPKANE IFOCKLKDDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public bool IBOHJGMEBIO;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public World HDBHOPCOJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4EE0", Offset = "0x2AA3AE0", VA = "0x182AA4EE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public DPNDFOCCADL OLOCLANFPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public GDHNKHLBLBK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	[HFIGNCEGOKM(DDEOJCINOPG.PropertyChanges)]
	[DAMCBGMFJNJ(typeof(PropertyDiffStateService), new string[] { })]
	internal class PropertyDiffStateService : OHFJHEDBJHF, HMFGCABFMPC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		internal readonly struct JCOMGALMPGI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private readonly DBJHEIPMAIM OHHHKGLEBMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private readonly PropertyDiffStateService EBNNPKINFJN;

			[Cpp2IlInjected.Token(Token = "0x6000B98")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA4B0", Offset = "0x3DD90B0", VA = "0x183DDA4B0")]
			public JCOMGALMPGI(PropertyDiffStateService EBNNPKINFJN, DBJHEIPMAIM PCMNBPHPOPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0x3DDA490", Offset = "0x3DD9090", VA = "0x183DDA490", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private readonly GDHNKHLBLBK DGBCJBAMILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private readonly OCBHPOAFHKL[] LGDNIILCAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private DBJHEIPMAIM NOJKAEBLJBJ;

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public LPIBEGOKOJB ELDOPOPAPAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8C")]
			[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public DJJBHNJFKFC JCMDNLIPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0x2A99D10", Offset = "0x2A98910", VA = "0x182A99D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public FKGNDDGLAFM HJLILEGCFGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0x2A99D10", Offset = "0x2A98910", VA = "0x182A99D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x8D7880", Offset = "0x8D6480", VA = "0x1808D7880")]
		public DJJBHNJFKFC GLFAHELNCHG(DBJHEIPMAIM FGMCPHKBIAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x8D7880", Offset = "0x8D6480", VA = "0x1808D7880")]
		public FKGNDDGLAFM NEHIJBOLBBJ(DBJHEIPMAIM FGMCPHKBIAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x2A99BB0", Offset = "0x2A987B0", VA = "0x182A99BB0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x2A99DD0", Offset = "0x2A989D0", VA = "0x182A99DD0", Slot = "5")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x2A99D50", Offset = "0x2A98950", VA = "0x182A99D50")]
		public void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x2A99C30", Offset = "0x2A98830", VA = "0x182A99C30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x2A99DB0", Offset = "0x2A989B0", VA = "0x182A99DB0")]
		public JCOMGALMPGI IGPGPMKIHNN(DBJHEIPMAIM FGMCPHKBIAK)
		{
			return default(JCOMGALMPGI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A110", Offset = "0x2A98D10", VA = "0x182A9A110")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	[DAMCBGMFJNJ(typeof(SceneService), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.HierarchySystems)]
	internal class SceneService : OHFJHEDBJHF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public static readonly SceneTag DHMMLNFCJFJ;

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public const string CDMDCGDHNHD = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private const string LFLNEKFBLBH = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		[NHBEJKCIJLO]
		private HMCNJNGCNFE JPDFIACDDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		[NHBEJKCIJLO]
		private ObjectEmbodimentService DPCGPJIEFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		[NHBEJKCIJLO]
		private AOHDOMEMLII PBCKDJKFIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		[NHBEJKCIJLO]
		private SingletonComponentService DHJAHMCPPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private EntityQuery FOEFCEPCLII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private EntityQuery CLKNCAKFCBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private EntityQuery COEKJINANOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private Entity DHCDEPPHJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private bool IBOHJGMEBIO;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public bool BALCLPKDCFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9A")]
			[Cpp2IlInjected.Address(RVA = "0x2D7D9E0", Offset = "0x2D7C5E0", VA = "0x182D7D9E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public NativeArray<Entity> FGHCCKPIOGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0x165ED20", Offset = "0x165D920", VA = "0x18165ED20")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0x165DF40", Offset = "0x165CB40", VA = "0x18165DF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public Entity NHNMIDECFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0x2D7D610", Offset = "0x2D7C210", VA = "0x182D7D610")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public SceneTag NPLHJHNEGEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x2D7DD70", Offset = "0x2D7C970", VA = "0x182D7DD70")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public Entity HFOBIEJJLLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x2D7DD70", Offset = "0x2D7C970", VA = "0x182D7DD70")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x2D7E430", Offset = "0x2D7D030", VA = "0x182D7E430")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0x2D7ED90", Offset = "0x2D7D990", VA = "0x182D7ED90")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D1F0", Offset = "0x2D7BDF0", VA = "0x182D7D1F0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D880", Offset = "0x2D7C480", VA = "0x182D7D880", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DDE0", Offset = "0x2D7C9E0", VA = "0x182D7DDE0")]
		public void JPGNBEJGFKC(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E350", Offset = "0x2D7CF50", VA = "0x182D7E350")]
		public NativeArray<Entity> KMBFOAFKKEA(Allocator PBEDBDBGIPF = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D760", Offset = "0x2D7C360", VA = "0x182D7D760")]
		public void DEOLFEHEIGA(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E4A0", Offset = "0x2D7D0A0", VA = "0x182D7E4A0")]
		public Entity NPIGMIKDCCE(string NLCIGFDKGEE = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DDC0", Offset = "0x2D7C9C0", VA = "0x182D7DDC0")]
		public void JJABMNLIADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D460", Offset = "0x2D7C060", VA = "0x182D7D460")]
		public void AHMBPFMCKMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DD10", Offset = "0x2D7C910", VA = "0x182D7DD10")]
		public void HKIEOFLJNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D480", Offset = "0x2D7C080", VA = "0x182D7D480")]
		public void BFHNELPIJEC(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E380", Offset = "0x2D7CF80", VA = "0x182D7E380")]
		public bool MDGFADLBGOB(Entity IEGFBJCKFAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D9D0", Offset = "0x2D7C5D0", VA = "0x182D7D9D0")]
		public void FMIKGCANBBM(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E240", Offset = "0x2D7CE40", VA = "0x182D7E240")]
		public string KJOMBMMNFFL(Entity IEGFBJCKFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		public void NNGGOFHKKGB(Entity IEGFBJCKFAP, string NLCIGFDKGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x2D7EDE0", Offset = "0x2D7D9E0", VA = "0x182D7EDE0")]
		public bool OPJOLBKJCPN(string NLCIGFDKGEE, out Entity IEGFBJCKFAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D8C0", Offset = "0x2D7C4C0", VA = "0x182D7D8C0")]
		public void EFDBMEBCDNE(Entity IEGFBJCKFAP, bool MKNDCHHPAAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DE20", Offset = "0x2D7CA20", VA = "0x182D7DE20")]
		public void KEACKEMANBO(Entity LLEBIIAHFDD, bool GAHNJBCBOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DF90", Offset = "0x2D7CB90", VA = "0x182D7DF90")]
		public void KEACKEMANBO(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DEA0", Offset = "0x2D7CAA0", VA = "0x182D7DEA0")]
		public void KEACKEMANBO(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x2D7EAB0", Offset = "0x2D7D6B0", VA = "0x182D7EAB0")]
		public void ODINILLALNF(Entity LLEBIIAHFDD, Entity IEGFBJCKFAP, bool GAHNJBCBOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E8D0", Offset = "0x2D7D4D0", VA = "0x182D7E8D0")]
		public void ODINILLALNF(NativeArray<Entity> FNMNPGEEPJI, Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x2D7ECE0", Offset = "0x2D7D8E0", VA = "0x182D7ECE0")]
		public void ODINILLALNF(EntityQuery NJIBLOIMOJA, Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DA60", Offset = "0x2D7C660", VA = "0x182D7DA60")]
		private void GJPADODNBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DA30", Offset = "0x2D7C630", VA = "0x182D7DA30")]
		private void GJOGMNPADKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D610", Offset = "0x2D7C210", VA = "0x182D7D610")]
		private Entity DEEGGOHPFDP()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D490", Offset = "0x2D7C090", VA = "0x182D7D490")]
		private void BGPLLCIMCIL(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E800", Offset = "0x2D7D400", VA = "0x182D7E800")]
		private void OACODADDBJO(EntityQuery IKMPKAEJJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E520", Offset = "0x2D7D120", VA = "0x182D7E520")]
		private void OACODADDBJO(NativeArray<Entity> OIICOGEJBID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E190", Offset = "0x2D7CD90", VA = "0x182D7E190")]
		private void KHNCIIGFLPN(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E000", Offset = "0x2D7CC00", VA = "0x182D7E000")]
		private void KEGAABLGIEM(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D570", Offset = "0x2D7C170", VA = "0x182D7D570")]
		private void CMHEGAOJPDM(SceneTag NHCEBMBHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D860", Offset = "0x2D7C460", VA = "0x182D7D860")]
		private void DPMJLBAFFCN(SceneTag NHCEBMBHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D2D0", Offset = "0x2D7BED0", VA = "0x182D7D2D0")]
		private void AGJCMJLKFGM(SceneTag NHCEBMBHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DC10", Offset = "0x2D7C810", VA = "0x182D7DC10")]
		private void GNFBKDCBCIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x3A0EA80", Offset = "0x3A0D680", VA = "0x183A0EA80")]
		private void OGGFHBBDLDL<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void BEPHCFCBENF(SceneTag NHCEBMBHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2D7DCB0", Offset = "0x2D7C8B0", VA = "0x182D7DCB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void GNJIDOPGEEJ(EntityQuery NJIBLOIMOJA, string NLCIGFDKGEE, SceneTag NHCEBMBHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2D7D540", Offset = "0x2D7C140", VA = "0x182D7D540")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void CCDECAEIPKK(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void FPDCJIFGJNH(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[DAMCBGMFJNJ(typeof(PFLCMKPFOMC), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.HierarchySystems)]
	[GGOLPMFKOCH(JIJBLGHADKE.PhotonRoom)]
	internal class UnitySceneService : OHFJHEDBJHF, PFLCMKPFOMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[NHBEJKCIJLO]
		private SceneService OIICOGEJBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private readonly Dictionary<int, Entity> CICDJNGJFPC;

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		private EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCB")]
			[Cpp2IlInjected.Address(RVA = "0x2D8CB60", Offset = "0x2D8B760", VA = "0x182D8CB60")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C700", Offset = "0x2D8B300", VA = "0x182D8C700", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C800", Offset = "0x2D8B400", VA = "0x182D8C800", Slot = "5")]
		public void JPGNBEJGFKC(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C970", Offset = "0x2D8B570", VA = "0x182D8C970", Slot = "6")]
		public bool KDIOLKDJBFL(IOBECAADPPL DKHOCCDNDOH, Transform KAMDPLLJPAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C790", Offset = "0x2D8B390", VA = "0x182D8C790")]
		private bool JIDMLMHEGHE(Scene IEGFBJCKFAP, out Entity LNNNFOKNAOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2D8CBB0", Offset = "0x2D8B7B0", VA = "0x182D8CBB0")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[HFIGNCEGOKM(DDEOJCINOPG.ComponentSystemTypes)]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	[DAMCBGMFJNJ(typeof(SingletonComponentService), new string[] { })]
	internal sealed class SingletonComponentService : OHFJHEDBJHF, HMFGCABFMPC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		[NHBEJKCIJLO]
		private AOHDOMEMLII PBCKDJKFIBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private Entity LLEBIIAHFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private FEBPDFEEBHG ECOKHAGGAGC;

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public int EONFJIOMKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0x2D834E0", Offset = "0x2D820E0", VA = "0x182D834E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Entity CDCPMNPKIHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x2D83D00", Offset = "0x2D82900", VA = "0x182D83D00")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x3A103B0", Offset = "0x3A0EFB0", VA = "0x183A103B0")]
		public T HMFHOBMDMGG<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x3A10470", Offset = "0x3A0F070", VA = "0x183A10470")]
		public void NMFBOCJEJOB<T>(T GKFICKKHACC) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2D83470", Offset = "0x2D82070", VA = "0x182D83470", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2D837C0", Offset = "0x2D823C0", VA = "0x182D837C0", Slot = "5")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2D837C0", Offset = "0x2D823C0", VA = "0x182D837C0")]
		private void GAOOKPDLJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2D834F0", Offset = "0x2D820F0", VA = "0x182D834F0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2D83A00", Offset = "0x2D82600", VA = "0x182D83A00")]
		private FEBPDFEEBHG OCAEAGGBPCA()
		{
			return default(FEBPDFEEBHG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		private static void NCPLMEAFIMJ(int CGKKILDEEIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
		private static void HPPKJEHEOLN(Type BIEGICDMJCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x2D83960", Offset = "0x2D82560", VA = "0x182D83960")]
		private static void LCJLBCBLACN(Type BIEGICDMJCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001B9")]
internal struct PFLNIBMKJAA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
[DAMCBGMFJNJ(typeof(ANAIOGLOEGC), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
internal sealed class ANAIOGLOEGC : OHFJHEDBJHF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	[NHBEJKCIJLO]
	private EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private global::AFDHPHLDLGD<BDDFPHFDFLC, Entity> NKMIFFFHCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private global::PBJIHBFONCG<FCPEEAAFLKN> LIFHFAECCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private global::PBJIHBFONCG<GIEBMICNGDP> OOJMNJAMAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private global::PBJIHBFONCG<HFAJFLOHGDO> ALEECMDJBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private global::PBJIHBFONCG<HFGJCJPBNAL> JDHPOFPFAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private global::PBJIHBFONCG<LEAIEINEBGN> MNJGLAAEFPK;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public global::ALJMPJGEOPC<Entity> FBJMFACKPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public GELKDICEMGM BENLBOJEHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public GELKDICEMGM ANPCBJDELNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public GELKDICEMGM BOAJKBOMOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x68D6F0", Offset = "0x68C2F0", VA = "0x18068D6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public GELKDICEMGM DKIEFMOAGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67D170", VA = "0x18067E570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public GELKDICEMGM ONKPDNCPLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x67E580", Offset = "0x67D180", VA = "0x18067E580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private EntityManager FAINNDBCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2F8D970", Offset = "0x2F8C570", VA = "0x182F8D970")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D770", Offset = "0x2F8C370", VA = "0x182F8D770", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x2F8D880", Offset = "0x2F8C480", VA = "0x182F8D880", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x1A9EDE0", Offset = "0x1A9D9E0", VA = "0x181A9EDE0")]
	private void BLNLPEOGOOG<T>(ref global::PBJIHBFONCG<T> MPPBBBHMGNE) where T : struct, NEJDHLEFDKK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x1A9EDE0", Offset = "0x1A9D9E0", VA = "0x181A9EDE0")]
	private void BLNLPEOGOOG<TC, TV>(ref global::AFDHPHLDLGD<TC, TV> MPPBBBHMGNE) where TC : struct, NEJDHLEFDKK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public ANAIOGLOEGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[DAMCBGMFJNJ(typeof(BLGPDOEOCBH), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
internal sealed class BLGPDOEOCBH : KGABHKADGEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private NNEFJHMAAJD NGOCLAIPHND;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public NNEFJHMAAJD CICEAJHPCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x2011CA0", Offset = "0x20108A0", VA = "0x182011CA0")]
		get
		{
			return default(NNEFJHMAAJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x2F91DF0", Offset = "0x2F909F0", VA = "0x182F91DF0", Slot = "4")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x2F91DE0", Offset = "0x2F909E0", VA = "0x182F91DE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public BLGPDOEOCBH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	[DAMCBGMFJNJ(typeof(TransformOwnershipPhase), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		public enum AMOOKDFHMCI
		{
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001BE")]
		public struct DALPDADMLGN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private AMOOKDFHMCI GOHOCNCKNOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			private readonly TransformOwnershipPhase GEOFAMNLJNK;

			[Cpp2IlInjected.Token(Token = "0x6000BF8")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4F00", Offset = "0x3DD3B00", VA = "0x183DD4F00")]
			public DALPDADMLGN(TransformOwnershipPhase GEOFAMNLJNK, AMOOKDFHMCI FGMCPHKBIAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0x3DD4EE0", Offset = "0x3DD3AE0", VA = "0x183DD4EE0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public AMOOKDFHMCI FGMCPHKBIAK;

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public AMOOKDFHMCI PFCLGBDPMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF0")]
			[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675C40", VA = "0x180677040")]
			get
			{
				return default(AMOOKDFHMCI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF1")]
			[Cpp2IlInjected.Address(RVA = "0x697F30", Offset = "0x696B30", VA = "0x180697F30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool FFFBFIJCFFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0xC199E0", Offset = "0xC185E0", VA = "0x180C199E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool DLLLFGCPFNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x16E2020", Offset = "0x16E0C20", VA = "0x1816E2020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x2D87010", Offset = "0x2D85C10", VA = "0x182D87010")]
		public DALPDADMLGN CGHIJJODGEO()
		{
			return default(DALPDADMLGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x2D87040", Offset = "0x2D85C40", VA = "0x182D87040")]
		public DALPDADMLGN OABHNBAIHLM()
		{
			return default(DALPDADMLGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[DAMCBGMFJNJ(typeof(NMCFLAICADE), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.Circuits)]
	public class CircuitsService : OHFJHEDBJHF, NMCFLAICADE
	{
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		[NHBEJKCIJLO]
		private NODGBOMFADG KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private EntityManager CLLNDNAAIKP;

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x2F987E0", Offset = "0x2F973E0", VA = "0x182F987E0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x2F98E00", Offset = "0x2F97A00", VA = "0x182F98E00", Slot = "5")]
		public bool EKGKADHGOHE(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x2F98FC0", Offset = "0x2F97BC0", VA = "0x182F98FC0", Slot = "7")]
		public Guid JNFAOAHMNMD(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x2F98BA0", Offset = "0x2F977A0", VA = "0x182F98BA0", Slot = "8")]
		public void EHPALCMGIMM(IOBECAADPPL DKHOCCDNDOH, Guid AEOGKHCDJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x2F99220", Offset = "0x2F97E20", VA = "0x182F99220", Slot = "9")]
		public Guid NCJDGJCCCNG(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2F992F0", Offset = "0x2F97EF0", VA = "0x182F992F0", Slot = "10")]
		public void NJAHGMKKFIF(IOBECAADPPL DKHOCCDNDOH, Guid CACOMCKALGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x2F98F00", Offset = "0x2F97B00", VA = "0x182F98F00", Slot = "11")]
		public bool FINGKDHNNDD(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x2F98F50", Offset = "0x2F97B50", VA = "0x182F98F50", Slot = "12")]
		public void IBJMEMCBDAH(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x2F99550", Offset = "0x2F98150", VA = "0x182F99550", Slot = "13")]
		public void PJIFNCEKDIO(IOBECAADPPL EHPFANFOFFJ, IOBECAADPPL GEOFAMNLJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x2F989D0", Offset = "0x2F975D0", VA = "0x182F989D0")]
		private void BDNNBHMIMFH(ODJCHDGAKOE OHOEEFLINMK, IOBECAADPPL GEOFAMNLJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x2F99090", Offset = "0x2F97C90", VA = "0x182F99090")]
		private void MNKLDBELFJB(ODJCHDGAKOE OHOEEFLINMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x2F98880", Offset = "0x2F97480", VA = "0x182F98880")]
		private bool ADAJJHMBKIM(MFPKOBHCDLK KMFLGGMLFJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x2F98730", Offset = "0x2F97330", VA = "0x182F98730")]
		private bool ABCONEGICDO(MFPKOBHCDLK KMFLGGMLFJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x2F98B40", Offset = "0x2F97740", VA = "0x182F98B40", Slot = "6")]
		public bool BJHJPLHHPME(IOBECAADPPL IBGBBCHPJJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[HFIGNCEGOKM(DDEOJCINOPG.Connectables)]
	[DAMCBGMFJNJ(typeof(EKMBBEOBHCH), new string[] { })]
	internal class ConnectableService : EKMBBEOBHCH, OHFJHEDBJHF, HMFGCABFMPC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		[CompilerGenerated]
		private sealed class DFJHPFMHIOP : IEnumerable<IOBECAADPPL>, IEnumerable, IEnumerator<IOBECAADPPL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			private IOBECAADPPL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private IOBECAADPPL localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public IOBECAADPPL <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700015D")]
			private IOBECAADPPL System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C30")]
				[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696C40", VA = "0x180698040", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(IOBECAADPPL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C32")]
				[Cpp2IlInjected.Address(RVA = "0x2D78EE0", Offset = "0x2D77AE0", VA = "0x182D78EE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8140", Offset = "0xAB6D40", VA = "0x180AB8140")]
			[DebuggerHidden]
			public DFJHPFMHIOP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2D78F30", Offset = "0x2D77B30", VA = "0x182D78F30", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x2D78AF0", Offset = "0x2D776F0", VA = "0x182D78AF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x2D79000", Offset = "0x2D77C00", VA = "0x182D79000")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x2D79050", Offset = "0x2D77C50", VA = "0x182D79050")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0x2D78EA0", Offset = "0x2D77AA0", VA = "0x182D78EA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0x2D78DF0", Offset = "0x2D779F0", VA = "0x182D78DF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IOBECAADPPL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0x2D78DF0", Offset = "0x2D779F0", VA = "0x182D78DF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private static readonly FNIDFMEJGMB MKOIAFMCLEN;

		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public const int DCHECMHMFJH = 0;

		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public const int HBAKBOMNJJE = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private JOBGNDCAMAM KKELBBDIJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private EEHCKCIAPAN AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private MCFPIPCNFDN KNPPOFLONHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private PropertyEventCallbacksService PDAOAKHGMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private global::HFPFDBLLPPK<Entity> EBPGNPNOKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private global::HFPFDBLLPPK<float3> NLBPGCJGCNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private global::HFPFDBLLPPK<quaternion> JLNPCMPLFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private global::HFPFDBLLPPK<Entity> GEOFAMNLJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private global::HFPFDBLLPPK<float3> LDFDHMMJHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private global::HFPFDBLLPPK<quaternion> FFJKKBHOOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private HashSet<Entity> PPOKECKHIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private HashSet<Entity> NMCJCPNAJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private EntityQuery BPAHOIDHMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private bool IBOHJGMEBIO;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public Func<FELBJINOHJJ> FBOLNGOPHNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x68D750", Offset = "0x68C350", VA = "0x18068D750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x7AA4E0", Offset = "0x7A90E0", VA = "0x1807AA4E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action<IOBECAADPPL, IOBECAADPPL> FNDGPAIFNPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E740", Offset = "0x2F9D340", VA = "0x182F9E740", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E4A0", Offset = "0x2F9D0A0", VA = "0x182F9E4A0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<IOBECAADPPL, IOBECAADPPL> ACAJAAMOFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x2F9D990", Offset = "0x2F9C590", VA = "0x182F9D990", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E980", Offset = "0x2F9D580", VA = "0x182F9E980", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<IOBECAADPPL, IOBECAADPPL, IOBECAADPPL> NJOOMMEPIMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x2F9D590", Offset = "0x2F9C190", VA = "0x182F9D590", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E6A0", Offset = "0x2F9D2A0", VA = "0x182F9E6A0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<IOBECAADPPL> PBKNHLPGMBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x2F9DCB0", Offset = "0x2F9C8B0", VA = "0x182F9DCB0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x2F9E5A0", Offset = "0x2F9D1A0", VA = "0x182F9E5A0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D780", Offset = "0x2F9C380", VA = "0x182F9D780", Slot = "25")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2F9EBA0", Offset = "0x2F9D7A0", VA = "0x182F9EBA0", Slot = "26")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DE90", Offset = "0x2F9CA90", VA = "0x182F9DE90", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E540", Offset = "0x2F9D140", VA = "0x182F9E540")]
		private void HNOJKDAIFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x2F9F200", Offset = "0x2F9DE00", VA = "0x182F9F200")]
		private void PPGFGMFMLAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2F9F040", Offset = "0x2F9DC40", VA = "0x182F9F040")]
		private void PBLGDHADCNK(Entity LLEBIIAHFDD, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG KNAEAKFNOOB, EKBGHCIKEGG OCBHJKLFMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E640", Offset = "0x2F9D240", VA = "0x182F9E640")]
		private void IGOMDDOHLMI(Entity LLEBIIAHFDD, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG KNAEAKFNOOB, EKBGHCIKEGG OCBHJKLFMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6B00", Offset = "0x1FB5700", VA = "0x181FB6B00", Slot = "14")]
		public IOBECAADPPL LNMAHJLADNI(IOBECAADPPL DKHOCCDNDOH, int IHGMGOCCNON)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x1401390", Offset = "0x13FFF90", VA = "0x181401390", Slot = "15")]
		public Color LJEIGNJPKLB(IOBECAADPPL DKHOCCDNDOH, int IHGMGOCCNON)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E0F0", Offset = "0x2F9CCF0", VA = "0x182F9E0F0", Slot = "16")]
		public float3 EOFJDDOPGDC(IOBECAADPPL DKHOCCDNDOH, int IHGMGOCCNON)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E040", Offset = "0x2F9CC40", VA = "0x182F9E040", Slot = "17")]
		public bool EGBLGMFAHDK(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL KIEHIJDIGFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DD50", Offset = "0x2F9C950", VA = "0x182F9DD50", Slot = "18")]
		public IOBECAADPPL CJPGOFCPNMB(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D630", Offset = "0x2F9C230", VA = "0x182F9D630", Slot = "21")]
		public void ABHMOHCGNLA(IOBECAADPPL DKHOCCDNDOH, Vector3 MKIHHFBJJGN, Quaternion PPNKJHLAKEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E8E0", Offset = "0x2F9D4E0", VA = "0x182F9E8E0", Slot = "23")]
		public float3 MOLNIJINIFE(MPJDICPJEKH JCJOBGHJFHL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DE00", Offset = "0x2F9CA00", VA = "0x182F9DE00", Slot = "24")]
		public quaternion DDOOBPNBMJE(MPJDICPJEKH JCJOBGHJFHL)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E7E0", Offset = "0x2F9D3E0", VA = "0x182F9E7E0", Slot = "28")]
		public RigidTransform KIFODFDAPCC(MPJDICPJEKH JCJOBGHJFHL)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x2F9EA20", Offset = "0x2F9D620", VA = "0x182F9EA20", Slot = "22")]
		public bool OHOMDHPOMAI(IOBECAADPPL DKHOCCDNDOH, out RigidTransform ONKKOPCHPEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x2F9D900", Offset = "0x2F9C500", VA = "0x182F9D900", Slot = "19")]
		[IteratorStateMachine(typeof(DFJHPFMHIOP))]
		public IEnumerable<IOBECAADPPL> AEAPHGIOGBJ(IOBECAADPPL DKHOCCDNDOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DB50", Offset = "0x2F9C750", VA = "0x182F9DB50", Slot = "20")]
		public IOBECAADPPL BIDIHIMLIFL(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x2F9E2D0", Offset = "0x2F9CED0", VA = "0x182F9E2D0", Slot = "29")]
		public void GMMJFMIEKCE(ref List<IOBECAADPPL> DFMCPPMHIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x2F9DA30", Offset = "0x2F9C630", VA = "0x182F9DA30")]
		private Entity BIDIHIMLIFL(Entity LLEBIIAHFDD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x2F9F400", Offset = "0x2F9E000", VA = "0x182F9F400")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	[DAMCBGMFJNJ(typeof(ObjectInstantiationService), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.Prefabs)]
	internal sealed class ObjectInstantiationService : OHFJHEDBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN AEEDEJIEEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		[NHBEJKCIJLO]
		private CHMBFFBOMKL PKOEJJAGGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		[NHBEJKCIJLO]
		private CCMLDGMLHBE KMJLLHGCEID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		[NHBEJKCIJLO]
		private ObjectNetworkToLocalMapService LDFFPBKCNCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		[NHBEJKCIJLO]
		private ObjectLifecycleService KOGKJOIDDKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		[NHBEJKCIJLO]
		private ObjectPrefabs DEBJMFLLNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[NHBEJKCIJLO]
		private PGOJBPGALLI JIDENELGNPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private LBONPJJMDCB PFBOJJELPCE;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public int LHABKJIKBDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000C35")]
			[Cpp2IlInjected.Address(RVA = "0x2A86A50", Offset = "0x2A85650", VA = "0x182A86A50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x2A866A0", Offset = "0x2A852A0", VA = "0x182A866A0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x2A868E0", Offset = "0x2A854E0", VA = "0x182A868E0")]
		public Entity CMKBHBIKKLG(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x2A867D0", Offset = "0x2A853D0", VA = "0x182A867D0")]
		public Entity BBEBKABPFOC(ELJHNEOGEBP FFJHOAAMJMD, OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x2A86970", Offset = "0x2A85570", VA = "0x182A86970")]
		public Entity HCPNNJMCDBO(OADLDHPKENB FKEOEHMKOOO, bool KCJPFJDMHDE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x2A86960", Offset = "0x2A85560", VA = "0x182A86960")]
		public Entity HCPNNJMCDBO(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x2A86BA0", Offset = "0x2A857A0", VA = "0x182A86BA0")]
		public Entity MJFCMEDMLAE()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x2A86AA0", Offset = "0x2A856A0", VA = "0x182A86AA0")]
		public Entity KHIJCCNCJJA(CKLKKHOPBLL BIEGICDMJCM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x2A86B20", Offset = "0x2A85720", VA = "0x182A86B20")]
		public Entity KHOBNGEHLKF(NFAEFFLJLPD BIEGICDMJCM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2A86A00", Offset = "0x2A85600", VA = "0x182A86A00")]
		public NativeArray<(IOBECAADPPL, IOBECAADPPL)> HOELGELKEPN(NativeArray<IOBECAADPPL> PDHJHNDNLLA, Allocator PBEDBDBGIPF)
		{
			return default(NativeArray<(IOBECAADPPL, IOBECAADPPL)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2A86890", Offset = "0x2A85490", VA = "0x182A86890")]
		public IEnumerable<OADLDHPKENB> BPNNFLIHJCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2A86830", Offset = "0x2A85430", VA = "0x182A86830")]
		public EntityArchetype BGIJKCJPACC(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x2A86900", Offset = "0x2A85500", VA = "0x182A86900")]
		public Entity EALMKFHLDHO(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x2A86C40", Offset = "0x2A85840", VA = "0x182A86C40")]
		private Entity NPIDNGBOMFN(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x2A86BB0", Offset = "0x2A857B0", VA = "0x182A86BB0")]
		private Entity NPIDNGBOMFN(OADLDHPKENB FKEOEHMKOOO, bool KCJPFJDMHDE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x2A86CC0", Offset = "0x2A858C0", VA = "0x182A86CC0")]
		private Entity NPIDNGBOMFN(OADLDHPKENB FKEOEHMKOOO, ELJHNEOGEBP FFJHOAAMJMD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[HFIGNCEGOKM(DDEOJCINOPG.Physics)]
	[DAMCBGMFJNJ(typeof(NPHLGLMBAHC), new string[] { })]
	public sealed class PhysicsSceneColliderService : NPHLGLMBAHC, NDAHHDGMMMK, KGABHKADGEM, OHFJHEDBJHF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private const string PMAOFEPLAFP = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private const int KLKLHAKLONG = -1;

		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private const int DBGHLEJGGPM = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		[NHBEJKCIJLO]
		private IODHNFLDMAC PFNEAPNCEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private Collider[] MMAHONGPINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private RaycastHit[] CNGPACGKCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private global::FIGNPHGKAHK<PFMNCAAGPOA, BoxCollider> HJIHDEBPMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private Scene IEGFBJCKFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private PhysicsScene DNJMAKEHOPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private GameObject CNGLOEJDOMG;

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public int KMJCBCMJAJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x2A93F90", Offset = "0x2A92B90", VA = "0x182A93F90", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x2A93DE0", Offset = "0x2A929E0", VA = "0x182A93DE0", Slot = "9")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x2A934F0", Offset = "0x2A920F0", VA = "0x182A934F0", Slot = "10")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x2A938B0", Offset = "0x2A924B0", VA = "0x182A938B0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x2A93760", Offset = "0x2A92360", VA = "0x182A93760", Slot = "4")]
		public PFMNCAAGPOA DCEGMKGONFB(Entity LLEBIIAHFDD)
		{
			return default(PFMNCAAGPOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x2A939B0", Offset = "0x2A925B0", VA = "0x182A939B0", Slot = "5")]
		public void FNJLLMLOGEJ(NativeArray<PFMNCAAGPOA> EDNKBFACCBI, NativeArray<FLJBFMJPKBF> BDLOKEMJJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x2A93CE0", Offset = "0x2A928E0", VA = "0x182A93CE0", Slot = "6")]
		public void JGPJDMKECAM(PFMNCAAGPOA DKBLPJPHEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x2A94540", Offset = "0x2A93140", VA = "0x182A94540", Slot = "7")]
		public bool NALJILADCDM(PFMNCAAGPOA DKBLPJPHEMF, out Collider KIHMMOLIPKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x2A94230", Offset = "0x2A92E30", VA = "0x182A94230")]
		public bool MONBAJCOINP(in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, float BNDBJFDKNPP, Allocator PBEDBDBGIPF, out NativeArray<Entity> FNMNPGEEPJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x2A93710", Offset = "0x2A92310", VA = "0x182A93710")]
		private void CNMDBLACLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0xCD9AE0", Offset = "0xCD86E0", VA = "0x180CD9AE0")]
		private void NCBCBPFIIKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x2A93FD0", Offset = "0x2A92BD0", VA = "0x182A93FD0")]
		private void MIEOHNHHGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x162E480", Offset = "0x162D080", VA = "0x18162E480")]
		private void KDMJBDDBLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x2A935F0", Offset = "0x2A921F0", VA = "0x182A935F0")]
		private BoxCollider CFBFCBAGGPD(Entity LLEBIIAHFDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x2A945E0", Offset = "0x2A931E0", VA = "0x182A945E0")]
		private void NKJODIDAOJG(BoxCollider JCJFKODMEAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x2A93F50", Offset = "0x2A92B50", VA = "0x182A93F50")]
		[Conditional("UNITY_EDITOR")]
		private void LDABOMLKGOG(GameObject ENOCMPCACJI, Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x2A94670", Offset = "0x2A93270", VA = "0x182A94670")]
		private void PFBLFMILPNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x2A93BC0", Offset = "0x2A927C0", VA = "0x182A93BC0")]
		private void HGNJCCJMGDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x2A94020", Offset = "0x2A92C20", VA = "0x182A94020")]
		private void MJJBLBIIDMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x2A93DB0", Offset = "0x2A929B0", VA = "0x182A93DB0")]
		private void JLLLFKJKLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2A93CD0", Offset = "0x2A928D0", VA = "0x182A93CD0")]
		private void HMAIHMMIOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2A935B0", Offset = "0x2A921B0", VA = "0x182A935B0")]
		private void BIBEKOKLCOM(Scene EDHJEJLJKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x2A94660", Offset = "0x2A93260", VA = "0x182A94660", Slot = "8")]
		private bool OFJNDCBPIEJ(in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, float BNDBJFDKNPP, Allocator PBEDBDBGIPF, out NativeArray<Entity> FNMNPGEEPJI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
[DAMCBGMFJNJ(typeof(BGOAEBFPKAN), new string[] { })]
public sealed class CLMNGKAHJHJ : BGOAEBFPKAN, OHFJHEDBJHF
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	private struct AMJLHBLPBOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public float ACKCJINFPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public uint GMOOJEKFFCN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private NDAHHDGMMMK MMNJDNIMEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private MDEMGPMKNJE JJFHCBEFBGM;

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x2F97400", Offset = "0x2F96000", VA = "0x182F97400", Slot = "5")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x2F975B0", Offset = "0x2F961B0", VA = "0x182F975B0")]
	public bool MONBAJCOINP(in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, float BNDBJFDKNPP, out LDEMHFFKMJA JMANGKEIMKL, out Entity JIBKKEGHDFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x2F97470", Offset = "0x2F96070", VA = "0x182F97470")]
	public static bool EEAMGGJEEKE(in Span<LDEMHFFKMJA> NMIGPODFJPC, float BNDBJFDKNPP, out int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x2F97580", Offset = "0x2F96180", VA = "0x182F97580")]
	public static float HBBFMCOKMFC(float ACKCJINFPBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public CLMNGKAHJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x2F97570", Offset = "0x2F96170", VA = "0x182F97570", Slot = "4")]
	private bool FODHEJPBHCH(in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, float BNDBJFDKNPP, out LDEMHFFKMJA JMANGKEIMKL, out Entity JIBKKEGHDFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
[DAMCBGMFJNJ(typeof(MDEMGPMKNJE), new string[] { })]
public sealed class BCEOMPMDMFD : MDEMGPMKNJE, OHFJHEDBJHF
{
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[BurstCompile]
	private struct BOMOOABMJOM : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[ReadOnly]
		public NativeArray<Entity> FNMNPGEEPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[ReadOnly]
		public float3 DMKCKNNPDNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[ReadOnly]
		public float3 CBEADECMMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> KGLOIBJFFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> DJEPIFAMOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> LOGHJCBBGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> FMGDFBHJJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> DPEELJNKMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		[WriteOnly]
		public NativeArray<LDEMHFFKMJA> OLJKOAAHNMP;

		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private static readonly LDEMHFFKMJA NKPPKIOIHON;

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x2D777C0", Offset = "0x2D763C0", VA = "0x182D777C0", Slot = "4")]
		public void Execute(int BNNEENLPEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2D776F0", Offset = "0x2D762F0", VA = "0x182D776F0")]
		private static float3 EPFAHMGOHOG(in float4x4 BFMGJHLMDCF, in float3 KNNJFFBFLLC)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x2D787E0", Offset = "0x2D773E0", VA = "0x182D787E0")]
		private static float3 MANNPBNHKOL(in float4x4 BFMGJHLMDCF, in float3 EIEOEGFMKEB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2D77AA0", Offset = "0x2D766A0", VA = "0x182D77AA0")]
		private static float3 GIOEKAHLOGB(in float4x4 BFMGJHLMDCF, in float3 KNNJFFBFLLC)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x2D785C0", Offset = "0x2D771C0", VA = "0x182D785C0")]
		private static float3 LFOBEAOCFAC(in float4x4 BFMGJHLMDCF, in float3 EIEOEGFMKEB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2D77BA0", Offset = "0x2D767A0", VA = "0x182D77BA0")]
		private bool HLJMEBPGBIB(in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, in NativeArray<Entity> GGIAPIKIKNH, out float3 JMANGKEIMKL, out float3 LCGGEIEGEMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2D77EF0", Offset = "0x2D76AF0", VA = "0x182D77EF0")]
		public static bool IBCDBEEAJJN(in float3 JAIPDBGOMKM, in float3 IIJDNKGDMDP, in float3 MCHFLPBEDEK, in float3 CLMJFCGNBPH, float MDGOFEABDJP, float OMBIPCFENEK, out float NDJEJACDKEB, out float3 HBHJEHMNJME)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityManager CLLNDNAAIKP;

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x2F90160", Offset = "0x2F8ED60", VA = "0x182F90160", Slot = "5")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x2F901F0", Offset = "0x2F8EDF0", VA = "0x182F901F0")]
	public void MONBAJCOINP(in NativeArray<Entity> FNMNPGEEPJI, in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, in NativeArray<LDEMHFFKMJA> MDDCMLHCIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public BCEOMPMDMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x2F901E0", Offset = "0x2F8EDE0", VA = "0x182F901E0", Slot = "4")]
	private void KFMJNECLNIG(in NativeArray<Entity> FNMNPGEEPJI, in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, in NativeArray<LDEMHFFKMJA> MDDCMLHCIBN)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[DAMCBGMFJNJ(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[HFIGNCEGOKM(DDEOJCINOPG.Embodiment)]
	[GGOLPMFKOCH(JIJBLGHADKE.OMRoom)]
	internal sealed class ObjectNetworkToLocalMapService : OHFJHEDBJHF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		[NHBEJKCIJLO]
		private EEHCKCIAPAN KJEBDBMGNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		[NHBEJKCIJLO]
		private CHMBFFBOMKL POLFOPCHMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		[NHBEJKCIJLO]
		private CCMLDGMLHBE APPHFAIFCLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private BLGCKCAEBNA EFJCPEJOMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private NativeHashMap<ELJHNEOGEBP, Entity> IKHCKLCMCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private EntityManager CLLNDNAAIKP;

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		internal NativeHashMap<ELJHNEOGEBP, Entity> LMFJKPMMLIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C72")]
			[Cpp2IlInjected.Address(RVA = "0x10EF940", Offset = "0x10EE540", VA = "0x1810EF940")]
			get
			{
				return default(NativeHashMap<ELJHNEOGEBP, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		internal uint PPDLLCINMBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0x2A89FA0", Offset = "0x2A88BA0", VA = "0x182A89FA0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool AACDAEOPAIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x826CE0", Offset = "0x8258E0", VA = "0x180826CE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0xDE6B70", Offset = "0xDE5770", VA = "0x180DE6B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x2A89A60", Offset = "0x2A88660", VA = "0x182A89A60", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x2A89C10", Offset = "0x2A88810", VA = "0x182A89C10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x2A89DC0", Offset = "0x2A889C0", VA = "0x182A89DC0")]
		public void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x2A89FD0", Offset = "0x2A88BD0", VA = "0x182A89FD0")]
		public void OGOOAHIPOBJ(ELJHNEOGEBP FFJHOAAMJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x2A89BE0", Offset = "0x2A887E0", VA = "0x182A89BE0")]
		private IOBECAADPPL CFMDJONBEKN(Entity LLEBIIAHFDD)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x2A89C80", Offset = "0x2A88880", VA = "0x182A89C80")]
		public IOBECAADPPL FEEDHGOGJCP(ELJHNEOGEBP FFJHOAAMJMD)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x2A89F10", Offset = "0x2A88B10", VA = "0x182A89F10")]
		public ELJHNEOGEBP HLAFIPJDKEG(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(ELJHNEOGEBP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x2A8A190", Offset = "0x2A88D90", VA = "0x182A8A190")]
		public void POKNHJBIMCE(Entity LLEBIIAHFDD, ELJHNEOGEBP FFJHOAAMJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x2A89B80", Offset = "0x2A88780", VA = "0x182A89B80")]
		public void BOFJHMHGCNK(Entity LLEBIIAHFDD, ELJHNEOGEBP FFJHOAAMJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x2A89D60", Offset = "0x2A88960", VA = "0x182A89D60")]
		public void FPFHLEEEBFO(Entity LLEBIIAHFDD, ELJHNEOGEBP FFJHOAAMJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x2A89E40", Offset = "0x2A88A40", VA = "0x182A89E40")]
		public void HCFKHHNMKFG(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[DAMCBGMFJNJ(typeof(PropertyEventCallbacksService), new string[] { })]
	[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
	[HFIGNCEGOKM(DDEOJCINOPG.Callbacks)]
	public class PropertyEventCallbacksService : OHFJHEDBJHF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		private struct CICKGNDJHIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public BGECCGMLMIN PKPGAEOFIGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public Type BIEGICDMJCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public int LBLAPKMJFKP;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		private struct BFIOILDIGEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public CICKGNDJHIH[] HFDCOKODHFK;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CC")]
		public delegate void BGECCGMLMIN(Entity LLEBIIAHFDD, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG KNAEAKFNOOB, EKBGHCIKEGG OCBHJKLFMDP);

		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private readonly Dictionary<EBLKGKAPHAO, BGECCGMLMIN> HPCIMOHKBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private readonly Dictionary<int, BFIOILDIGEF> LHGEMBGEDLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private MGNHPFHGDHE HFDCOKODHFK;

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action CIPEMDNMJCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C83")]
			[Cpp2IlInjected.Address(RVA = "0x2A9AEE0", Offset = "0x2A99AE0", VA = "0x182A9AEE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0x2A9B390", Offset = "0x2A99F90", VA = "0x182A9B390")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action NHCHFBAOMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0x2A9A480", Offset = "0x2A99080", VA = "0x182A9A480")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x2A9A720", Offset = "0x2A99320", VA = "0x182A9A720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A1B0", Offset = "0x2A98DB0", VA = "0x182A9A1B0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A520", Offset = "0x2A99120", VA = "0x182A9A520", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A5B0", Offset = "0x2A991B0", VA = "0x182A9A5B0")]
		public void EHMHLLLMBAF(EBLKGKAPHAO KBPOLLDMHFK, BGECCGMLMIN PKPGAEOFIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x2A9ADF0", Offset = "0x2A999F0", VA = "0x182A9ADF0")]
		public void JBEMCCBAFHO(EBLKGKAPHAO KBPOLLDMHFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B100", Offset = "0x2A99D00", VA = "0x182A9B100")]
		internal void PIDBAJFFBNN(DJJBHNJFKFC OPCGPJFHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A7C0", Offset = "0x2A993C0", VA = "0x182A9A7C0")]
		private void FFDKJBFAGGC(DJJBHNJFKFC OPCGPJFHEJB, int BGAEBMDLBPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x2A9A200", Offset = "0x2A98E00", VA = "0x182A9A200")]
		private void CPBKFBNCCJD(FPHEKKDEPIJ LGPKKGCJHDG, FIOMMIJIHBF NAKDLIMKJJM, CICKGNDJHIH JJHOKNDGMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x2A9AF80", Offset = "0x2A99B80", VA = "0x182A9AF80")]
		private BFIOILDIGEF MEMKHEHJIFE(FPHEKKDEPIJ LGPKKGCJHDG, FIOMMIJIHBF NAKDLIMKJJM)
		{
			return default(BFIOILDIGEF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x2A9AD00", Offset = "0x2A99900", VA = "0x182A9AD00")]
		private CICKGNDJHIH HDIFFJJDBLC(BFIOILDIGEF MEOBJDMPABM, FPHEKKDEPIJ LGPKKGCJHDG, FIOMMIJIHBF NAKDLIMKJJM)
		{
			return default(CICKGNDJHIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x2A9B480", Offset = "0x2A9A080", VA = "0x182A9B480")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[DAMCBGMFJNJ(typeof(CPPNPEKOALL), new string[] { })]
public class HHHHCMLFIKA : OHFJHEDBJHF, HMFGCABFMPC, CPPNPEKOALL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[CompilerGenerated]
	private sealed class NIPBDABMIJD : IEnumerable<IOBECAADPPL>, IEnumerable, IEnumerator<IOBECAADPPL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private IOBECAADPPL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public HHHHCMLFIKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private IOBECAADPPL splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public IOBECAADPPL <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		private IOBECAADPPL System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAD")]
			[Cpp2IlInjected.Address(RVA = "0x698040", Offset = "0x696C40", VA = "0x180698040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(IOBECAADPPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0x3DDCD40", Offset = "0x3DDB940", VA = "0x183DDCD40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0xAB8140", Offset = "0xAB6D40", VA = "0x180AB8140")]
		[DebuggerHidden]
		public NIPBDABMIJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCB90", Offset = "0x3DDB790", VA = "0x183DDCB90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCD00", Offset = "0x3DDB900", VA = "0x183DDCD00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCC50", Offset = "0x3DDB850", VA = "0x183DDCC50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IOBECAADPPL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCC50", Offset = "0x3DDB850", VA = "0x183DDCC50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private BLGCKCAEBNA EFJCPEJOMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private OIOFNJOAHBN DHAKEEJDECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private ObjectInstantiationService DEBJMFLLNHC;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private EntityManager FAINNDBCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA4E0", Offset = "0x2AA90E0", VA = "0x182AAA4E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private DKCCOABIFKH NBPAAHMKIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA420", Offset = "0x2AA9020", VA = "0x182AAA420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9710", Offset = "0x2AA8310", VA = "0x182AA9710", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA530", Offset = "0x2AA9130", VA = "0x182AAA530", Slot = "5")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9DE0", Offset = "0x2AA89E0", VA = "0x182AA9DE0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA630", Offset = "0x2AA9230", VA = "0x182AAA630")]
	private void PGKICGFFCBB(Entity HNBNLLKPAMD, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA3C0", Offset = "0x2AA8FC0", VA = "0x182AAA3C0", Slot = "14")]
	public IOBECAADPPL MJFCMEDMLAE()
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9E90", Offset = "0x2AA8A90", VA = "0x182AA9E90", Slot = "10")]
	public void EKBKDKEFFBE(IOBECAADPPL DKHOCCDNDOH, MGFCLCMDHID ENIALHNPBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA270", Offset = "0x2AA8E70", VA = "0x182AAA270", Slot = "9")]
	public MGFCLCMDHID KEEDCNJLFLB(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(MGFCLCMDHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9880", Offset = "0x2AA8480", VA = "0x182AA9880", Slot = "11")]
	public IOBECAADPPL DBFMHLFNHAH(IOBECAADPPL DKJMIMOCJNG, [Optional] Vector3? DKGAADMNOOM, [Optional] Quaternion? MPLPNDNEAPK, [Optional] Vector3? OLIFDPKHJEC)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x2AA97A0", Offset = "0x2AA83A0", VA = "0x182AA97A0", Slot = "15")]
	public IOBECAADPPL ADHCIOCCAEF(IOBECAADPPL FMMJCODIJBA, int BNNEENLPEFO, [Optional] Vector3? DKGAADMNOOM, [Optional] Quaternion? MPLPNDNEAPK, [Optional] Vector3? OLIFDPKHJEC)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9F50", Offset = "0x2AA8B50", VA = "0x182AA9F50", Slot = "7")]
	public IOBECAADPPL GKDMKALFMBB(IOBECAADPPL FMMJCODIJBA, int BNNEENLPEFO)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9D20", Offset = "0x2AA8920", VA = "0x182AA9D20", Slot = "16")]
	public void DOPDMOBAOFN(IOBECAADPPL FMMJCODIJBA, IOBECAADPPL HHODAAKNPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9B80", Offset = "0x2AA8780", VA = "0x182AA9B80", Slot = "12")]
	public void DJLENOLAHEP(IOBECAADPPL FMMJCODIJBA, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA040", Offset = "0x2AA8C40", VA = "0x182AAA040", Slot = "17")]
	public void JGFDNFNJHJK(IOBECAADPPL FMMJCODIJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x2AA97E0", Offset = "0x2AA83E0", VA = "0x182AA97E0", Slot = "8")]
	public int AOIENNFPGDN(IOBECAADPPL FMMJCODIJBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA330", Offset = "0x2AA8F30", VA = "0x182AAA330", Slot = "6")]
	[IteratorStateMachine(typeof(NIPBDABMIJD))]
	public IEnumerable<IOBECAADPPL> MCACMLIHPPC(IOBECAADPPL FMMJCODIJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA1E0", Offset = "0x2AA8DE0", VA = "0x182AAA1E0")]
	private bool JPOOJJKKOCN(IOBECAADPPL FMMJCODIJBA, out NativeArray<Entity> KPOBDKLHLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9650", Offset = "0x2AA8250", VA = "0x182AA9650")]
	private NativeArray<Entity> AAFPHDCGPDC(IOBECAADPPL FMMJCODIJBA)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public HHHHCMLFIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[DAMCBGMFJNJ(typeof(LGJKHPCIMFN), new string[] { })]
[GGOLPMFKOCH(JIJBLGHADKE.LoadInstance)]
internal sealed class LGJKHPCIMFN : OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private EEHCKCIAPAN AEEDEJIEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private TransformOwnershipPhase BGCOGDCHDPA;

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private LGIKDIEECOD IAMBCCOEDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x2ABA530", Offset = "0x2AB9130", VA = "0x182ABA530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA0F0", Offset = "0x2AB8CF0", VA = "0x182ABA0F0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA440", Offset = "0x2AB9040", VA = "0x182ABA440")]
	public void NOOADEJEPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA170", Offset = "0x2AB8D70", VA = "0x182ABA170")]
	public void IOCMNCHKFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public LGJKHPCIMFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public readonly struct FLEAMIMIFOO : IEquatable<FLEAMIMIFOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private readonly int BGAEBMDLBPN;

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public Type MACDLFHPGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0x2AA4180", Offset = "0x2AA2D80", VA = "0x182AA4180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x2AA42E0", Offset = "0x2AA2EE0", VA = "0x182AA42E0")]
	public FLEAMIMIFOO(Type BIEGICDMJCM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4260", Offset = "0x2AA2E60", VA = "0x182AA4260")]
	public static FLEAMIMIFOO KPOCFOKDNEC(Type BIEGICDMJCM)
	{
		return default(FLEAMIMIFOO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4290", Offset = "0x2AA2E90", VA = "0x182AA4290")]
	public static Type KPOCFOKDNEC(FLEAMIMIFOO DKBLPJPHEMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0xBAD660", Offset = "0xBAC260", VA = "0x180BAD660")]
	public static bool IKJLJMIELNH(FLEAMIMIFOO LEOEMBMBFBC, FLEAMIMIFOO GHDGKPNPOBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0xBAD660", Offset = "0xBAC260", VA = "0x180BAD660")]
	public static bool NKIHKFGIBBG(FLEAMIMIFOO LEOEMBMBFBC, FLEAMIMIFOO GHDGKPNPOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x8586A0", Offset = "0x8572A0", VA = "0x1808586A0", Slot = "4")]
	public bool Equals(FLEAMIMIFOO MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4100", Offset = "0x2AA2D00", VA = "0x182AA4100", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x728E20", Offset = "0x727A20", VA = "0x180728E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x2AA42B0", Offset = "0x2AA2EB0", VA = "0x182AA42B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
public static class JOFAJHCMOPO
{
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private static Dictionary<Type, int> BMNCKKLHLBB;

	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private static List<Type> COKCGGHOICB;

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x2AB39C0", Offset = "0x2AB25C0", VA = "0x182AB39C0")]
	static JOFAJHCMOPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x233D310", Offset = "0x233BF10", VA = "0x18233D310")]
	public static bool ELGBPIMHCCH<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3680", Offset = "0x2AB2280", VA = "0x182AB3680")]
	public static bool ELGBPIMHCCH(Type BIEGICDMJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3510", Offset = "0x2AB2110", VA = "0x182AB3510")]
	private static bool ELGBPIMHCCH(Type BIEGICDMJCM, out int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x233D440", Offset = "0x233C040", VA = "0x18233D440")]
	public static int KAAMKKLEPKC<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3950", Offset = "0x2AB2550", VA = "0x182AB3950")]
	public static int KAAMKKLEPKC(Type BIEGICDMJCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x233D3A0", Offset = "0x233BFA0", VA = "0x18233D3A0")]
	public static bool GIGGJMBFKKD<T>(out int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0x2AB36F0", Offset = "0x2AB22F0", VA = "0x182AB36F0")]
	public static bool GIGGJMBFKKD(Type BIEGICDMJCM, out int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0x2AB38B0", Offset = "0x2AB24B0", VA = "0x182AB38B0")]
	public static Type HMFHOBMDMGG(int BNNEENLPEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3790", Offset = "0x2AB2390", VA = "0x182AB3790")]
	public static bool GIGGJMBFKKD(int BNNEENLPEFO, out Type BIEGICDMJCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[DefaultMember("Item")]
public struct ILNKBMENBMN<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private T[] JLFCOOGLPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private int PMIIGNOLFGJ;

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public int ONIEICNEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x7765E0", Offset = "0x7751E0", VA = "0x1807765E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x1807DE0", Offset = "0x18069E0", VA = "0x181807DE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Span<T> IJKLJFCPNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x1807E20", Offset = "0x1806A20", VA = "0x181807E20")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool MOCJDAMLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0x92EFA0", Offset = "0x92DBA0", VA = "0x18092EFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x1807F70", Offset = "0x1806B70", VA = "0x181807F70")]
	public ILNKBMENBMN(int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x1807EC0", Offset = "0x1806AC0", VA = "0x181807EC0")]
	public int NJHNFHMHPKP(T GKFICKKHACC, int HOKMFDPKLJA, int CGKKILDEEIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x1807D20", Offset = "0x1806920", VA = "0x181807D20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
[DefaultMember("Item")]
public struct HLHBPJICIEM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private global::ILNKBMENBMN<T> JLFCOOGLPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private int PMIIGNOLFGJ;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC090", Offset = "0x2BBAC90", VA = "0x182BBC090")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int ONIEICNEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675C40", VA = "0x180677040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0x2BBCD20", Offset = "0x2BBB920", VA = "0x182BBCD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public int ODJEFCECEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB940", Offset = "0x2BBA540", VA = "0x182BBB940")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x2BBCCD0", Offset = "0x2BBB8D0", VA = "0x182BBCCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool MOCJDAMLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x2BBBBB0", Offset = "0x2BBA7B0", VA = "0x182BBBBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Span<T> IJKLJFCPNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD8")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC8E0", Offset = "0x2BBB4E0", VA = "0x182BBC8E0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x2BBD290", Offset = "0x2BBBE90", VA = "0x182BBD290")]
	public HLHBPJICIEM(int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB8F0", Offset = "0x2BBA4F0", VA = "0x182BBB8F0")]
	public T AMHEONNAKAE(int BNNEENLPEFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC590", Offset = "0x2BBB190", VA = "0x182BBC590")]
	public void IPBGPNMPFBC(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCB00", Offset = "0x2BBB700", VA = "0x182BBCB00")]
	public void LFOALHHAKED(Span<T> LENGKEKMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBD80", Offset = "0x2BBA980", VA = "0x182BBBD80")]
	public void ELGBPIMHCCH(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC600", Offset = "0x2BBB200", VA = "0x182BBC600")]
	private void JGKFODNAOGE(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB970", Offset = "0x2BBA570", VA = "0x182BBB970")]
	public void CIOCKIHBBLE(Span<T> CKIGFGIEPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCC70", Offset = "0x2BBB870", VA = "0x182BBCC70")]
	public void LJFPNHIPEPF(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCEB0", Offset = "0x2BBBAB0", VA = "0x182BBCEB0")]
	public void NIIPNPGNCJL(int GPJOCANBBFF, int OCMAALMMILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC320", Offset = "0x2BBAF20", VA = "0x182BBC320")]
	public void IFFLOFKJNLP(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC380", Offset = "0x2BBAF80", VA = "0x182BBC380")]
	public void IJKOEFHGNEH(int GPJOCANBBFF, int OCMAALMMILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBE90", Offset = "0x2BBAA90", VA = "0x182BBBE90")]
	public void EOEFHHKOEKK(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x2BBD160", Offset = "0x2BBBD60", VA = "0x182BBD160")]
	public void OMLABMPDPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x2BBD0D0", Offset = "0x2BBBCD0", VA = "0x182BBD0D0")]
	public int NJHNFHMHPKP(T GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCA30", Offset = "0x2BBB630", VA = "0x182BBCA30")]
	public bool KOOJGAMNGBI(T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBD30", Offset = "0x2BBA930", VA = "0x182BBBD30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x2BBD220", Offset = "0x2BBBE20", VA = "0x182BBD220", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCA90", Offset = "0x2BBB690", VA = "0x182BBCA90")]
	public static Span<T> KPOCFOKDNEC(global::HLHBPJICIEM<T> LENGKEKMOEB)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBF50", Offset = "0x2BBAB50", VA = "0x182BBBF50")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void FANPLINEAPE(int GKFICKKHACC, int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void JJKNDABEBED(int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC780", Offset = "0x2BBB380", VA = "0x182BBC780")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void JJKNDABEBED(int PMIIGNOLFGJ, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCD70", Offset = "0x2BBB970", VA = "0x182BBCD70")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void NEGBJHDDMHK(int GKFICKKHACC, int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC120", Offset = "0x2BBAD20", VA = "0x182BBC120")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void ICGGEJFKGMD(int GPJOCANBBFF, int OCMAALMMILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF0")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBBF0", Offset = "0x2BBA7F0", VA = "0x182BBBBF0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private static void DFLFDDBAJMP(int GKFICKKHACC, int PMIIGNOLFGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public struct NNEFJHMAAJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private const int GMDABLAOLAG = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private NativeList<Entity> FNMNPGEEPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private TransformAccessArray KKELBBDIJCG;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D750", Offset = "0x2A7C350", VA = "0x182A7D750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public NativeList<Entity> LDPOBABEIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0xD07D60", Offset = "0xD06960", VA = "0x180D07D60")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public TransformAccessArray NPMGMALKLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6776C0", VA = "0x180678AC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool AACDAEOPAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D690", Offset = "0x2A7C290", VA = "0x182A7D690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF1")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D980", Offset = "0x2A7C580", VA = "0x182A7D980")]
	public NNEFJHMAAJD(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D8B0", Offset = "0x2A7C4B0", VA = "0x182A7D8B0")]
	public Entity IEHDMAJLCAD(int BNNEENLPEFO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D6B0", Offset = "0x2A7C2B0", VA = "0x182A7D6B0")]
	public Transform ALNLJDPANJK(int BNNEENLPEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D700", Offset = "0x2A7C300", VA = "0x182A7D700")]
	public void DBHEJFMMFJD(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D7E0", Offset = "0x2A7C3E0", VA = "0x182A7D7E0")]
	public int ELGBPIMHCCH(Transform KAMDPLLJPAH, Entity LLEBIIAHFDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D900", Offset = "0x2A7C500", VA = "0x182A7D900")]
	public int LJFPNHIPEPF(int BNNEENLPEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D760", Offset = "0x2A7C360", VA = "0x182A7D760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D6C0", Offset = "0x2A7C2C0", VA = "0x182A7D6C0")]
	private void BMFLDOIDONB(int ALPHMDODPNC = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
internal class LGDEIKNECGI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private NativeHashMap<FLEAMIMIFOO, int2> JGIPFEGGHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private NativeList<byte> NFMJIELOGNG;

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x2ABA050", Offset = "0x2AB8C50", VA = "0x182ABA050")]
	public LGDEIKNECGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9A80", Offset = "0x2AB8680", VA = "0x182AB9A80")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	public void NMFBOCJEJOB<T>(T GKFICKKHACC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	public T HMFHOBMDMGG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9E10", Offset = "0x2AB8A10", VA = "0x182AB9E10")]
	public void NMFBOCJEJOB(Type BIEGICDMJCM, EKBGHCIKEGG GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9AE0", Offset = "0x2AB86E0", VA = "0x182AB9AE0")]
	public EKBGHCIKEGG HMFHOBMDMGG(Type BIEGICDMJCM)
	{
		return default(EKBGHCIKEGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9820", Offset = "0x2AB8420", VA = "0x182AB9820")]
	private NativeArray<byte> ADBOFBMDIGH(int2 IIDJCPNCMBP)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x2AB98C0", Offset = "0x2AB84C0", VA = "0x182AB98C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x2AB9960", Offset = "0x2AB8560", VA = "0x182AB9960", Slot = "1")]
	~LGDEIKNECGI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D6")]
public struct EPILJIILHEM<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000177")]
	internal static T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	public static global::EPILJIILHEM<T> KPOCFOKDNEC(T GKFICKKHACC)
	{
		return default(global::EPILJIILHEM<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	public static T KPOCFOKDNEC(global::EPILJIILHEM<T> BJJKLHEAKLF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public static class PMMFAEGAAMO
{
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	private static readonly LGDEIKNECGI IFLFACDBGCP;

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x2A92160", Offset = "0x2A90D60", VA = "0x182A92160")]
	internal static void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	public static void NMFBOCJEJOB<T>(T GKFICKKHACC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x2A92270", Offset = "0x2A90E70", VA = "0x182A92270")]
	public static void NMFBOCJEJOB(Type BIEGICDMJCM, EKBGHCIKEGG GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	public static T HMFHOBMDMGG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0D")]
	[Cpp2IlInjected.Address(RVA = "0x2A921D0", Offset = "0x2A90DD0", VA = "0x182A921D0")]
	public static EKBGHCIKEGG HMFHOBMDMGG(Type BIEGICDMJCM)
	{
		return default(EKBGHCIKEGG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public class NNMDHIEOIAA : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	public static readonly NNMDHIEOIAA BLGCIDCPBFE;

	[Cpp2IlInjected.Token(Token = "0x6000D0F")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DA00", Offset = "0x2A7C600", VA = "0x182A7DA00", Slot = "4")]
	public bool Equals(LinkedEntityGroup IODEOJKDCNL, LinkedEntityGroup FNMMGECGLAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D10")]
	[Cpp2IlInjected.Address(RVA = "0x2A7DA20", Offset = "0x2A7C620", VA = "0x182A7DA20", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup KMFLGGMLFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public NNMDHIEOIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
internal class GLLJEDMAHHM
{
	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void PLKOCHLFKOB(in Vector3 DKGAADMNOOM, in Quaternion MPLPNDNEAPK, in Vector3 OLIFDPKHJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void NCMDPLKGEFB(in Vector3 BDEMGCFFCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void MFNNBLFKPJM(in Quaternion MPLPNDNEAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void CFDIBHJDKGN(in Vector3 FIBPLMLJJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void NPCIPBBMABP(in Vector3 FIBPLMLJJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void HFNBMCFPNAG(in float KLMPOMAKOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6C20", Offset = "0x2AA5820", VA = "0x182AA6C20")]
	[Conditional("DEBUG_BUILD")]
	public static void GKPDPHNFACC(in float3 GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68FAB0", VA = "0x180690EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void EEFKNDOLACM(in float GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6BA0", Offset = "0x2AA57A0", VA = "0x182AA6BA0")]
	[Conditional("DEBUG_BUILD")]
	public static void EEFKNDOLACM(in Vector3 GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6BF0", Offset = "0x2AA57F0", VA = "0x182AA6BF0")]
	[Conditional("DEBUG_BUILD")]
	public static void EEFKNDOLACM(in Quaternion GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6B90", Offset = "0x2AA5790", VA = "0x182AA6B90")]
	[Conditional("DEBUG_BUILD")]
	public static void BJNJFNEDKFE(in float GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6B50", Offset = "0x2AA5750", VA = "0x182AA6B50")]
	[Conditional("DEBUG_BUILD")]
	public static void BJNJFNEDKFE(in Vector3 GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x2AA6B20", Offset = "0x2AA5720", VA = "0x182AA6B20")]
	[Conditional("DEBUG_BUILD")]
	public static void BJNJFNEDKFE(in Quaternion GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public GLLJEDMAHHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public struct CPMOBHMFHFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	public Entity LLEBIIAHFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	public Entity KAEGMLMLAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	public Entity JJHAACNMGFO;

	[Cpp2IlInjected.Token(Token = "0x6000D21")]
	[Cpp2IlInjected.Address(RVA = "0x2F97F10", Offset = "0x2F96B10", VA = "0x182F97F10")]
	public CPMOBHMFHFP(Entity LLEBIIAHFDD, Entity KAEGMLMLAJA, Entity JJHAACNMGFO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	[Cpp2IlInjected.Address(RVA = "0x2F97EB0", Offset = "0x2F96AB0", VA = "0x182F97EB0")]
	public static CPMOBHMFHFP KPOCFOKDNEC((Entity entity, Entity oldParent, Entity newParent) JIBDKICFEPD)
	{
		return default(CPMOBHMFHFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	[Cpp2IlInjected.Address(RVA = "0x2F97EF0", Offset = "0x2F96AF0", VA = "0x182F97EF0")]
	public void MAOBKBKJKAJ(out Entity LLEBIIAHFDD, out Entity KAEGMLMLAJA, out Entity JJHAACNMGFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public struct CAIGEBHNCMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public Entity LLEBIIAHFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public Entity GEOFAMNLJNK;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0xF8DFC0", Offset = "0xF8CBC0", VA = "0x180F8DFC0")]
	public CAIGEBHNCMM(Entity LLEBIIAHFDD, Entity GEOFAMNLJNK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	[Cpp2IlInjected.Address(RVA = "0x2F961F0", Offset = "0x2F94DF0", VA = "0x182F961F0")]
	public static CAIGEBHNCMM KPOCFOKDNEC((Entity entity, Entity parent) JIBDKICFEPD)
	{
		return default(CAIGEBHNCMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x2F96220", Offset = "0x2F94E20", VA = "0x182F96220")]
	public void MAOBKBKJKAJ(out Entity LLEBIIAHFDD, out Entity GEOFAMNLJNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
public struct IMIGNKKLBNK<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private GCHandle DKBLPJPHEMF;

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool JGFGLAHGLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0x18080E0", Offset = "0x1806CE0", VA = "0x1818080E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0x18081E0", Offset = "0x1806DE0", VA = "0x1818081E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0x18080F0", Offset = "0x1806CF0", VA = "0x1818080F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	[Cpp2IlInjected.Address(RVA = "0x1808280", Offset = "0x1806E80", VA = "0x181808280")]
	public IMIGNKKLBNK(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x18081B0", Offset = "0x1806DB0", VA = "0x1818081B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public enum HKINPNONFAF
{
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct NJAEBHKONED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	public HKINPNONFAF PLHKAGLEICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	public int NAKPIAAEFIC;

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x698050", Offset = "0x696C50", VA = "0x180698050")]
	public NJAEBHKONED(HKINPNONFAF PLHKAGLEICI, int NAKPIAAEFIC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D2D")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D590", Offset = "0x2A7C190", VA = "0x182A7D590")]
	public static NJAEBHKONED KPOCFOKDNEC((HKINPNONFAF eventType, int eventIndex) IODEOJKDCNL)
	{
		return default(NJAEBHKONED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D5B0", Offset = "0x2A7C1B0", VA = "0x182A7D5B0")]
	public void MAOBKBKJKAJ(out HKINPNONFAF PLHKAGLEICI, out int NAKPIAAEFIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
[DAMCBGMFJNJ(typeof(NDAHHDGMMMK), new string[] { })]
public sealed class JKOKMPJDECL : NDAHHDGMMMK, OHFJHEDBJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private NPHLGLMBAHC OKOFKHFHDED;

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1CF0", Offset = "0x2AB08F0", VA = "0x182AB1CF0", Slot = "5")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1D40", Offset = "0x2AB0940", VA = "0x182AB1D40")]
	public bool MONBAJCOINP(in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, float BNDBJFDKNPP, Allocator PBEDBDBGIPF, out NativeArray<Entity> FNMNPGEEPJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public JKOKMPJDECL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1D40", Offset = "0x2AB0940", VA = "0x182AB1D40", Slot = "4")]
	private bool OFJNDCBPIEJ(in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, float BNDBJFDKNPP, Allocator PBEDBDBGIPF, out NativeArray<Entity> FNMNPGEEPJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
[OPLAMEBGNBC]
[UpdateInGroup(typeof(JJFJNGHFJIF))]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
internal sealed class IMGAANIFIJJ : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x2AB0590", Offset = "0x2AAF190", VA = "0x182AB0590", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public IMGAANIFIJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[OPLAMEBGNBC]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
[UpdateInGroup(typeof(PPAGBHHMAFC))]
public sealed class PHNFEFBNMNC : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x2A90AE0", Offset = "0x2A8F6E0", VA = "0x182A90AE0", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public PHNFEFBNMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[OPLAMEBGNBC]
[UpdateInGroup(typeof(LCHFDMBMNHG))]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
internal sealed class HKHFHPJOIJC : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x2AAB880", Offset = "0x2AAA480", VA = "0x182AAB880", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public HKHFHPJOIJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
internal class MBANIBCHKDP : BHBEGOLDLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public MBANIBCHKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[ExecuteAlways]
[OPLAMEBGNBC]
[GMHCLNCMPDG(JIJBLGHADKE.LoadInstance)]
[UpdateInGroup(typeof(EABLAKNILLA))]
internal sealed class BFLEMBEOHEL : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x2F91010", Offset = "0x2F8FC10", VA = "0x182F91010", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x2A8F200", Offset = "0x2A8DE00", VA = "0x182A8F200")]
	public BFLEMBEOHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[NIINPNOELJA(typeof(AuthoredLocalPoseData))]
public sealed class JJFNIKENDIF : OPKDABCPCBE
{
	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1900", Offset = "0x2AB0500", VA = "0x182AB1900", Slot = "8")]
	protected override bool HNNCLEKANIL(ReadOnlySpan<AuthoredLocalPoseData> CKIGFGIEPDP, IEAJMBBOLLL MKCMLPCNJGL, out ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1980", Offset = "0x2AB0580", VA = "0x182AB1980", Slot = "9")]
	protected override bool NAJLBOJHHKN(int OPAPEIICLLC, Span<AuthoredLocalPoseData> CKIGFGIEPDP, in ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D43")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1A40", Offset = "0x2AB0640", VA = "0x182AB1A40")]
	public JJFNIKENDIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[NIINPNOELJA(typeof(LocalPoseData))]
public sealed class BIDOPDKDIPF : DFJOKOMHDFL
{
	[Cpp2IlInjected.Token(Token = "0x6000D44")]
	[Cpp2IlInjected.Address(RVA = "0x2F91710", Offset = "0x2F90310", VA = "0x182F91710", Slot = "8")]
	protected override bool HNNCLEKANIL(ReadOnlySpan<LocalPoseData> CKIGFGIEPDP, IEAJMBBOLLL MKCMLPCNJGL, out ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D45")]
	[Cpp2IlInjected.Address(RVA = "0x2F91790", Offset = "0x2F90390", VA = "0x182F91790", Slot = "9")]
	protected override bool NAJLBOJHHKN(int OPAPEIICLLC, Span<LocalPoseData> CKIGFGIEPDP, in ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x2F91850", Offset = "0x2F90450", VA = "0x182F91850")]
	public BIDOPDKDIPF()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001E7")]
	[Preserve]
	internal class _RRAssemblyIndex : OJPIMOLMMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000D47")]
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677740", VA = "0x180678B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0x2D945E0", Offset = "0x2D931E0", VA = "0x182D945E0", Slot = "6")]
		public sealed override void FEOLDJENCJJ(OFPBJBCBPFJ PKPGAEOFIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0x2D95580", Offset = "0x2D94180", VA = "0x182D95580", Slot = "4")]
		public sealed override void LHIOLPAIHGM()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001E8")]
public class KEJBIFLOMJJ
{
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private static byte[] POAMPPAGKIJ;

	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private static int DNBFJGDJLJG;

	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static int JPELDCGMMIM;

	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private static BigInteger LIKOKONEDPL;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3B90", Offset = "0x2AB2790", VA = "0x182AB3B90")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3CA0", Offset = "0x2AB28A0", VA = "0x182AB3CA0")]
	public static string HPJOPLJIOMI(byte[] EHAMCGPFFID, bool BLMJHFAPIFG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001E9")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20001EA")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000D4E")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001EB")]
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
