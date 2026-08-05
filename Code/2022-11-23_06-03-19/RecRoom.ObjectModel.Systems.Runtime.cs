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
	[Cpp2IlInjected.Address(RVA = "0x3049180", Offset = "0x3047F80", VA = "0x183049180")]
	static HIMBCODCAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2D98050", Offset = "0x2D96E50", VA = "0x182D98050")]
	public static void HAPLAILGCII<T>(T HOGBBBFDPKI, ref T DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3049120", Offset = "0x3047F20", VA = "0x183049120")]
	public static void HAPLAILGCII(FixedString32 HOGBBBFDPKI, ref string DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x30490E0", Offset = "0x3047EE0", VA = "0x1830490E0")]
	public static void HAPLAILGCII(string HOGBBBFDPKI, ref FixedString32 DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3049150", Offset = "0x3047F50", VA = "0x183049150")]
	public static void HAPLAILGCII(FixedString64 HOGBBBFDPKI, ref string DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3048EF0", Offset = "0x3047CF0", VA = "0x183048EF0")]
	public static void HAPLAILGCII(string HOGBBBFDPKI, ref FixedString64 DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3048FE0", Offset = "0x3047DE0", VA = "0x183048FE0")]
	public static void HAPLAILGCII(CNBNEFCLPII HOGBBBFDPKI, ref Vector3 DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3049010", Offset = "0x3047E10", VA = "0x183049010")]
	public static void HAPLAILGCII(Vector3 HOGBBBFDPKI, ref CNBNEFCLPII DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3048E10", Offset = "0x3047C10", VA = "0x183048E10")]
	public static void HAPLAILGCII(ONKMONCCEIJ HOGBBBFDPKI, ref Vector4 DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3048E80", Offset = "0x3047C80", VA = "0x183048E80")]
	public static void HAPLAILGCII(Vector4 HOGBBBFDPKI, ref ONKMONCCEIJ DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3048E10", Offset = "0x3047C10", VA = "0x183048E10")]
	public static void HAPLAILGCII(ONKMONCCEIJ HOGBBBFDPKI, ref Quaternion DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3048E80", Offset = "0x3047C80", VA = "0x183048E80")]
	public static void HAPLAILGCII(Quaternion HOGBBBFDPKI, ref ONKMONCCEIJ DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3048F50", Offset = "0x3047D50", VA = "0x183048F50")]
	public static void HAPLAILGCII(CNBNEFCLPII HOGBBBFDPKI, ref float3 DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3049010", Offset = "0x3047E10", VA = "0x183049010")]
	public static void HAPLAILGCII(float3 HOGBBBFDPKI, ref CNBNEFCLPII DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3048E40", Offset = "0x3047C40", VA = "0x183048E40")]
	public static void HAPLAILGCII(ONKMONCCEIJ HOGBBBFDPKI, ref float4 DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3048E80", Offset = "0x3047C80", VA = "0x183048E80")]
	public static void HAPLAILGCII(float4 HOGBBBFDPKI, ref ONKMONCCEIJ DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3048E40", Offset = "0x3047C40", VA = "0x183048E40")]
	public static void HAPLAILGCII(ONKMONCCEIJ HOGBBBFDPKI, ref quaternion DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3049070", Offset = "0x3047E70", VA = "0x183049070")]
	public static void HAPLAILGCII(quaternion HOGBBBFDPKI, ref ONKMONCCEIJ DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3048FA0", Offset = "0x3047DA0", VA = "0x183048FA0")]
	public static void HAPLAILGCII(Entity HOGBBBFDPKI, ref EAKODDPCJDE DKIFKKDEOHM, IEAJMBBOLLL MKCMLPCNJGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3048F80", Offset = "0x3047D80", VA = "0x183048F80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x674BA0", Offset = "0x6739A0", VA = "0x180674BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HFBJLIMBJCJ OIAHPJDJAHB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x721260", Offset = "0x720060", VA = "0x180721260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3404BC0", Offset = "0x34039C0", VA = "0x183404BC0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
	public AHIEIGILMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x30317D0", Offset = "0x30305D0", VA = "0x1830317D0", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3031750", Offset = "0x3030550", VA = "0x183031750")]
	[Preserve]
	private void HGPDFJKGCEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public PPGGGOLLAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3057C30", Offset = "0x3056A30", VA = "0x183057C30", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public LFAJEALJKKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3026320", Offset = "0x3025120", VA = "0x183026320")]
		public static ObjectModelConfigAsset PPAEFENCNOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AD0", Offset = "0x6D58D0", VA = "0x1806D6AD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F2C380", Offset = "0x3F2B180", VA = "0x183F2C380")]
			public static ELJHNEOGEBP FIJDJMPBION(int EJAHJEKIEAG)
			{
				return default(ELJHNEOGEBP);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3F2C020", Offset = "0x3F2AE20", VA = "0x183F2C020")]
			private static void BFCLMDGFLNJ(IOBECAADPPL EOBAPNHIDPG, IOBECAADPPL FJCPBNOHAPC, ELJHNEOGEBP FFJHOAAMJMD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x3F2C1B0", Offset = "0x3F2AFB0", VA = "0x183F2C1B0")]
			public static int FHKCMEEHGHA(GameObject ENOCMPCACJI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3F2C770", Offset = "0x3F2B570", VA = "0x183F2C770")]
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
			[Cpp2IlInjected.Address(RVA = "0x3027780", Offset = "0x3026580", VA = "0x183027780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3027A40", Offset = "0x3026840", VA = "0x183027A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static CKDAIJCFICL NNOGECKBPOG
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x30264F0", Offset = "0x30252F0", VA = "0x1830264F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x30268E0", Offset = "0x30256E0", VA = "0x1830268E0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool MPGGMKFNFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x30277E0", Offset = "0x30265E0", VA = "0x1830277E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static PGEEJALGCGE LDOEMEGKBCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3027B20", Offset = "0x3026920", VA = "0x183027B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static HFBJLIMBJCJ OIAHPJDJAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3027080", Offset = "0x3025E80", VA = "0x183027080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LHNBKEDDAHF NJJHLCFOCPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3026670", Offset = "0x3025470", VA = "0x183026670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static CGEDEAJAIJO CCKOPMBDMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3026EE0", Offset = "0x3025CE0", VA = "0x183026EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static BLGCKCAEBNA EKBGIHOCMFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3026D70", Offset = "0x3025B70", VA = "0x183026D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static NDJGAFFBPCH PKEGKBMDJJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3027E40", Offset = "0x3026C40", VA = "0x183027E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool NBJDJJDGLLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3027640", Offset = "0x3026440", VA = "0x183027640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool MKBBGDGPAGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x30266F0", Offset = "0x30254F0", VA = "0x1830266F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool CFOHIKABMBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x30275E0", Offset = "0x30263E0", VA = "0x1830275E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x3026610", Offset = "0x3025410", VA = "0x183026610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool MMJHAIKHCOE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x3027720", Offset = "0x3026520", VA = "0x183027720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x3027CF0", Offset = "0x3026AF0", VA = "0x183027CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action JLDPCGLOKKD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3027940", Offset = "0x3026740", VA = "0x183027940")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3027100", Offset = "0x3025F00", VA = "0x183027100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3026DF0", Offset = "0x3025BF0", VA = "0x183026DF0")]
		public static IOBECAADPPL FEEDHGOGJCP(GameObject ENOCMPCACJI)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3027200", Offset = "0x3026000", VA = "0x183027200")]
		public static bool HAHFMLGMGED(ByteString MEFFDBODCGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3026F60", Offset = "0x3025D60", VA = "0x183026F60")]
		public static MFPKOBHCDLK FOPFDIPOBCG(ELJHNEOGEBP FFJHOAAMJMD)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3026B60", Offset = "0x3025960", VA = "0x183026B60")]
		public static (ByteString, IDisposable) CLPGJOCDFOA()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3027BC0", Offset = "0x30269C0", VA = "0x183027BC0")]
		public static (ByteString, IDisposable) OEMICKMDFJI(IEnumerable<IOBECAADPPL> MIDBODKMKIJ)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x30263C0", Offset = "0x30251C0", VA = "0x1830263C0")]
		public static bool AJHBGFMPDJP(GameObject ENOCMPCACJI, out ELJHNEOGEBP FFJHOAAMJMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3027D50", Offset = "0x3026B50", VA = "0x183027D50")]
		public static bool OOFHELPOEED(IEnumerable<KPBHHJNMPGI> JNPPLACLHGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3026C90", Offset = "0x3025A90", VA = "0x183026C90")]
		public static void EEFBGNFDBDE(bool DHOJGMOHHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3027260", Offset = "0x3026060", VA = "0x183027260")]
		public static Task HPDNEIPMNKO(bool DHOJGMOHHOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3027500", Offset = "0x3026300", VA = "0x183027500")]
		private static CKDAIJCFICL IGJEMGAGPOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x30273E0", Offset = "0x30261E0", VA = "0x1830273E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x302C4B0", Offset = "0x302B2B0", VA = "0x18302C4B0")]
		public static bool DADIJENPEME(IAEGHKEFOHF BIGAHGNBDLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x302C560", Offset = "0x302B360", VA = "0x18302C560")]
		public static IAEGHKEFOHF EHMHLLLMBAF(GameObject ENOCMPCACJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x302C790", Offset = "0x302B590", VA = "0x18302C790")]
		public static IAEGHKEFOHF EHMHLLLMBAF(GameObject ENOCMPCACJI, ELJHNEOGEBP FFJHOAAMJMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x302C3B0", Offset = "0x302B1B0", VA = "0x18302C3B0")]
		public static bool CAJOFGDHJFL(GameObject HCKEHDIEAIK, string BEKHBMMBGHO, bool OIHKIJANKEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x302C990", Offset = "0x302B790", VA = "0x18302C990")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void FMECODKKJOE(GameObject HCKEHDIEAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x302CB90", Offset = "0x302B990", VA = "0x18302CB90")]
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
			[Cpp2IlInjected.Address(RVA = "0x668120", Offset = "0x666F20", VA = "0x180668120", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public IOBECAADPPL BIKFLMMEOOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6CF580", Offset = "0x6CE380", VA = "0x1806CF580", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(IOBECAADPPL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x735850", Offset = "0x734650", VA = "0x180735850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6529C0", Offset = "0x6517C0", VA = "0x1806529C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3421730", Offset = "0x3420530", VA = "0x183421730", Slot = "15")]
			get
			{
				return default(IOBECAADPPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public MFPKOBHCDLK DPFBOJFINBN
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x34217E0", Offset = "0x34205E0", VA = "0x1834217E0", Slot = "6")]
			get
			{
				return default(MFPKOBHCDLK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool MKNOGDLMDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x3421720", Offset = "0x3420520", VA = "0x183421720", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IHGCIGLLFKA PDCFCDHBBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6BDB40", Offset = "0x6BC940", VA = "0x1806BDB40", Slot = "7")]
			get
			{
				return default(IHGCIGLLFKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private HFBJLIMBJCJ OIAHPJDJAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x3420EB0", Offset = "0x341FCB0", VA = "0x183420EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private JOBGNDCAMAM AIMCCKBDHJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x3420E50", Offset = "0x341FC50", VA = "0x183420E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool HJMACANLLMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x77EBA0", Offset = "0x77D9A0", VA = "0x18077EBA0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x77EC20", Offset = "0x77DA20", VA = "0x18077EC20", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> IAJCDKDADBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x34215E0", Offset = "0x34203E0", VA = "0x1834215E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3421810", Offset = "0x3420610", VA = "0x183421810")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<IAEGHKEFOHF> FGCIGIEOIKP
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x3421680", Offset = "0x3420480", VA = "0x183421680", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x34218B0", Offset = "0x34206B0", VA = "0x1834218B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x34209F0", Offset = "0x341F7F0", VA = "0x1834209F0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3421440", Offset = "0x3420240", VA = "0x183421440", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3421080", Offset = "0x341FE80", VA = "0x183421080", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x34213B0", Offset = "0x34201B0", VA = "0x1834213B0", Slot = "10")]
		public void OnEmbody(EEHCKCIAPAN AEEDEJIEEFL, IOBECAADPPL IBGBBCHPJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3421430", Offset = "0x3420230", VA = "0x183421430", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x34211A0", Offset = "0x341FFA0", VA = "0x1834211A0", Slot = "12")]
		public void OnDisembody(bool JMHJCNMKLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x3420D50", Offset = "0x341FB50", VA = "0x183420D50")]
		private void EMEPNBPGKKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3420F90", Offset = "0x341FD90", VA = "0x183420F90")]
		private void IHDDNHABLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3420B70", Offset = "0x341F970", VA = "0x183420B70")]
		private void BHKJAPMCHOA(bool ODDBKPJIGNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3421020", Offset = "0x341FE20", VA = "0x183421020", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6529C0", Offset = "0x6517C0", VA = "0x1806529C0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xF55A60", Offset = "0xF54860", VA = "0x180F55A60", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x6529C0", Offset = "0x6517C0", VA = "0x1806529C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3039D10", Offset = "0x3038B10", VA = "0x183039D10", Slot = "6")]
			get
			{
				return default(OADLDHPKENB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3039CB0", Offset = "0x3038AB0", VA = "0x183039CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x671970", Offset = "0x670770", VA = "0x180671970", Slot = "6")]
			get
			{
				return default(OADLDHPKENB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7047B0", Offset = "0x7035B0", VA = "0x1807047B0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IOBECAADPPL BIKFLMMEOOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6C17C0", Offset = "0x6C05C0", VA = "0x1806C17C0", Slot = "5")]
			get
			{
				return default(IOBECAADPPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool MKNOGDLMDCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6EDE20", Offset = "0x6ECC20", VA = "0x1806EDE20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x895130", Offset = "0x893F30", VA = "0x180895130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal Entity CDCPMNPKIHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal BLGCKCAEBNA EKBGIHOCMFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal JOBGNDCAMAM BBLKMPHNEAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x32B52D0", Offset = "0x32B40D0", VA = "0x1832B52D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x32B4EC0", Offset = "0x32B3CC0", VA = "0x1832B4EC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x32B4ED0", Offset = "0x32B3CD0", VA = "0x1832B4ED0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x32B4FC0", Offset = "0x32B3DC0", VA = "0x1832B4FC0")]
		internal void FNJOFAEFPIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x32B5400", Offset = "0x32B4200", VA = "0x1832B5400")]
		private bool PCPPNDBPHNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x32B5340", Offset = "0x32B4140", VA = "0x1832B5340")]
		private void LFMLCAJHMGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x32B4ED0", Offset = "0x32B3CD0", VA = "0x1832B4ED0")]
		internal void CGILPHFOCHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x32B5370", Offset = "0x32B4170", VA = "0x1832B5370")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x32B54F0", Offset = "0x32B42F0", VA = "0x1832B54F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBBAF10", Offset = "0xBB9D10", VA = "0x180BBAF10", Slot = "19")]
		get
		{
			return default(AHPBGKKBONO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public FEGPLAEFMOI LDOEMEGKBCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public MCFPIPCNFDN JHMDIDKKOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public HFBJLIMBJCJ OIAHPJDJAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool AACDAEOPAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE20", Offset = "0x6ECC20", VA = "0x1806EDE20", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool PAOBNFNAFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3055A70", Offset = "0x3054870", VA = "0x183055A70", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x30556D0", Offset = "0x30544D0", VA = "0x1830556D0", Slot = "20")]
	public void LHCOLCBEPCK(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x9BB410", Offset = "0x9BA210", VA = "0x1809BB410")]
	private void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3055250", Offset = "0x3054050", VA = "0x183055250")]
	private void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	private void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x30553E0", Offset = "0x30541E0", VA = "0x1830553E0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x30555F0", Offset = "0x30543F0", VA = "0x1830555F0", Slot = "10")]
	public void HAEFFNNFOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "4")]
	public void HPCCMFHOKGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3055860", Offset = "0x3054660", VA = "0x183055860", Slot = "5")]
	public void MFGMDDJEENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3055440", Offset = "0x3054240", VA = "0x183055440", Slot = "6")]
	public void EAGINIEFBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3055490", Offset = "0x3054290", VA = "0x183055490", Slot = "7")]
	public void FOGMCMNIEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3055A80", Offset = "0x3054880", VA = "0x183055A80", Slot = "8")]
	public bool OOFHELPOEED(IEnumerable<KPBHHJNMPGI> JNPPLACLHGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3055A00", Offset = "0x3054800", VA = "0x183055A00", Slot = "9")]
	public void NHJFFFEKKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3055660", Offset = "0x3054460", VA = "0x183055660", Slot = "11")]
	public void KDBCJFDIBNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x30557E0", Offset = "0x30545E0", VA = "0x1830557E0", Slot = "12")]
	public void MDFOLHHLPFL(bool OFIHIKCKNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3055630", Offset = "0x3054430", VA = "0x183055630")]
	private void HCKPBLLMLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3055300", Offset = "0x3054100", VA = "0x183055300", Slot = "13")]
	public ByteString CLPGJOCDFOA(out IDisposable ABGOLHJFIJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x30558D0", Offset = "0x30546D0", VA = "0x1830558D0", Slot = "14")]
	public void MNOLKCHHLIP(ByteString JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3055500", Offset = "0x3054300", VA = "0x183055500")]
	public static KONPIIIEAJC GLBIKEOEKPG(FEGPLAEFMOI HFDOFHJBJGD, IMFOEJGFLNN MBNFLPKEEGH = IMFOEJGFLNN.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	private static void INEIGOGMALF(FEGPLAEFMOI HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	private static void MALADBIKIAO(FEGPLAEFMOI HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public KONPIIIEAJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NPAKLOPBCBN
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x301C6B0", Offset = "0x301B4B0", VA = "0x18301C6B0")]
	public static MFPKOBHCDLK BBEBKABPFOC(this CKDAIJCFICL NBPHCOAFDNK, ELJHNEOGEBP FFJHOAAMJMD, OADLDHPKENB FKEOEHMKOOO)
	{
		return default(MFPKOBHCDLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x301C9D0", Offset = "0x301B7D0", VA = "0x18301C9D0")]
	public static OEHLCFMEIAB HKGIPEPAOCC(this CKDAIJCFICL NBPHCOAFDNK)
	{
		return default(OEHLCFMEIAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x301C920", Offset = "0x301B720", VA = "0x18301C920")]
	public static IOBECAADPPL FEEDHGOGJCP(this CKDAIJCFICL NBPHCOAFDNK, Entity LLEBIIAHFDD)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x301C7F0", Offset = "0x301B5F0", VA = "0x18301C7F0")]
	public static IOBECAADPPL FEEDHGOGJCP(this CKDAIJCFICL NBPHCOAFDNK, ELJHNEOGEBP FFJHOAAMJMD)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x301CAF0", Offset = "0x301B8F0", VA = "0x18301CAF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x382AC90", Offset = "0x3829A90", VA = "0x18382AC90", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type MACDLFHPGNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3827010", Offset = "0x3825E10", VA = "0x183827010", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FIOMMIJIHBF EGCAHIONBKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3825840", Offset = "0x3824640", VA = "0x183825840", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int IECABHILINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3826B20", Offset = "0x3825920", VA = "0x183826B20", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IKOPFDFGIPG GIIPMLBAOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x382DA50", Offset = "0x382C850", VA = "0x18382DA50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x23EFDC0", Offset = "0x23EEBC0", VA = "0x1823EFDC0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x3827A20", Offset = "0x3826820", VA = "0x183827A20", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::PCLPPLPNNDP<ELJHNEOGEBP> JLDPCGLOKKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x382A420", Offset = "0x3829220", VA = "0x18382A420", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x38273B0", Offset = "0x38261B0", VA = "0x1838273B0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3832370", Offset = "0x3831170", VA = "0x183832370")]
	public HDDCHEPFNLD(global::IDGMOCNLFGC<Entity> GCEENFOFNFL, BLGCKCAEBNA EFJCPEJOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x382A710", Offset = "0x3829510", VA = "0x18382A710")]
	private Entity LEEEFIBDGIA(ELJHNEOGEBP FFJHOAAMJMD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x382A630", Offset = "0x3829430", VA = "0x18382A630")]
	private ELJHNEOGEBP LEEEFIBDGIA(Entity LLEBIIAHFDD)
	{
		return default(ELJHNEOGEBP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3827B20", Offset = "0x3826920", VA = "0x183827B20", Slot = "4")]
	public T HMFHOBMDMGG(ELJHNEOGEBP FFJHOAAMJMD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x382BA20", Offset = "0x382A820", VA = "0x18382BA20")]
	public bool NMFBOCJEJOB(ELJHNEOGEBP FFJHOAAMJMD, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x382E330", Offset = "0x382D130", VA = "0x18382E330")]
	public bool ONIEOJAKANA(ELJHNEOGEBP FFJHOAAMJMD, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3826E00", Offset = "0x3825C00", VA = "0x183826E00", Slot = "9")]
	public bool FONENOMBNOF(ELJHNEOGEBP FFJHOAAMJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3829590", Offset = "0x3828390", VA = "0x183829590", Slot = "26")]
	public object JGBPAAPKKLK(ELJHNEOGEBP FFJHOAAMJMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3826330", Offset = "0x3825130", VA = "0x183826330")]
	public bool AJMLBPKCBLJ(ELJHNEOGEBP FFJHOAAMJMD, in object IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3828DB0", Offset = "0x3827BB0", VA = "0x183828DB0")]
	public void HMFHOBMDMGG(ELJHNEOGEBP FFJHOAAMJMD, in PMECDNBONOH GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x382AE20", Offset = "0x3829C20", VA = "0x18382AE20")]
	public bool NMFBOCJEJOB(ELJHNEOGEBP FFJHOAAMJMD, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x382E700", Offset = "0x382D500", VA = "0x18382E700")]
	public bool ONIEOJAKANA(ELJHNEOGEBP FFJHOAAMJMD, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3829720", Offset = "0x3828520", VA = "0x183829720", Slot = "22")]
	public void KGEJHADOBPB(CPCNLIBKLCB EHGIDPAFOKH, [Optional] object EDPENIGJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3829750", Offset = "0x3828550", VA = "0x183829750", Slot = "15")]
	public void KGEJHADOBPB(ELJHNEOGEBP BIMCDHOFDCP, BBPNDNFFEFA EHGIDPAFOKH, object EDPENIGJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3827960", Offset = "0x3826760", VA = "0x183827960", Slot = "14")]
	public bool HBNCLABAILL(ELJHNEOGEBP DKIFKKDEOHM, ELJHNEOGEBP HOGBBBFDPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x28AB1D0", Offset = "0x28A9FD0", VA = "0x1828AB1D0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3831FB0", Offset = "0x3830DB0", VA = "0x183831FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3825A40", Offset = "0x3824840", VA = "0x183825A40")]
	public string AEKNGOPJJEL(in EKBGHCIKEGG PEFOOCOGGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x382CAB0", Offset = "0x382B8B0", VA = "0x18382CAB0")]
	private void NPBAEECDKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x382C230", Offset = "0x382B030", VA = "0x18382C230")]
	private void NNEBNPNLBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x38301C0", Offset = "0x382EFC0", VA = "0x1838301C0")]
	private void POAOKFGBMEH(Entity LLEBIIAHFDD, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3829450", Offset = "0x3828250", VA = "0x183829450")]
	private void HPHHCEKMBPD(Entity LLEBIIAHFDD, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x382E9B0", Offset = "0x382D7B0", VA = "0x18382E9B0")]
	[Conditional("DEBUG_BUILD")]
	private static void PJLBPCOAKKL(Entity LLEBIIAHFDD, ELJHNEOGEBP FFJHOAAMJMD, string BBEHMKMODBA, string OOPFHPKJFAK, [CallerMemberName] string OEFLJIGICBN = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2F0B200", Offset = "0x2F0A000", VA = "0x182F0B200", Slot = "5")]
	private bool KFILONOONKJ(ELJHNEOGEBP BIMCDHOFDCP, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3166060", Offset = "0x3164E60", VA = "0x183166060", Slot = "6")]
	private bool DHPGCNKAGOM(ELJHNEOGEBP BIMCDHOFDCP, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x334DBE0", Offset = "0x334C9E0", VA = "0x18334DBE0", Slot = "10")]
	private bool FBFHJKPKKDG(ELJHNEOGEBP BIMCDHOFDCP, in object IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3826930", Offset = "0x3825730", VA = "0x183826930", Slot = "11")]
	private void DKMDEFFFPFO(ELJHNEOGEBP BIMCDHOFDCP, in PMECDNBONOH GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3829100", Offset = "0x3827F00", VA = "0x183829100", Slot = "12")]
	private bool HNJIFLOKKEO(ELJHNEOGEBP BIMCDHOFDCP, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3826960", Offset = "0x3825760", VA = "0x183826960", Slot = "13")]
	private bool EEIABOODPDD(ELJHNEOGEBP BIMCDHOFDCP, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3825890", Offset = "0x3824690", VA = "0x183825890", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x3FF6210", Offset = "0x3FF5010", VA = "0x183FF6210", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Type MACDLFHPGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1DA0", Offset = "0x3FF0BA0", VA = "0x183FF1DA0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public FIOMMIJIHBF EGCAHIONBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0350", Offset = "0x3FEF150", VA = "0x183FF0350", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int IECABHILINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1700", Offset = "0x3FF0500", VA = "0x183FF1700", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IKOPFDFGIPG GIIPMLBAOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3FF9810", Offset = "0x3FF8610", VA = "0x183FF9810", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2040", Offset = "0x3FF0E40", VA = "0x183FF2040", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2C10", Offset = "0x3FF1A10", VA = "0x183FF2C10", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::PCLPPLPNNDP<IOBECAADPPL> JLDPCGLOKKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3FF5BA0", Offset = "0x3FF49A0", VA = "0x183FF5BA0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3FF21A0", Offset = "0x3FF0FA0", VA = "0x183FF21A0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3832370", Offset = "0x3831170", VA = "0x183832370")]
	public AMDLBDOEOBO(global::IDGMOCNLFGC<Entity> GCEENFOFNFL, BLGCKCAEBNA EFJCPEJOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1D1ECB0", Offset = "0x1D1DAB0", VA = "0x181D1ECB0")]
	private Entity LEEEFIBDGIA(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x39B8720", Offset = "0x39B7520", VA = "0x1839B8720")]
	private IOBECAADPPL LEEEFIBDGIA(Entity LLEBIIAHFDD)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3FF36C0", Offset = "0x3FF24C0", VA = "0x183FF36C0", Slot = "4")]
	public T HMFHOBMDMGG(IOBECAADPPL DKHOCCDNDOH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3FF6430", Offset = "0x3FF5230", VA = "0x183FF6430")]
	public bool NMFBOCJEJOB(IOBECAADPPL DKHOCCDNDOH, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3FF9A80", Offset = "0x3FF8880", VA = "0x183FF9A80")]
	public bool ONIEOJAKANA(IOBECAADPPL DKHOCCDNDOH, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3FF1A20", Offset = "0x3FF0820", VA = "0x183FF1A20", Slot = "9")]
	public bool FONENOMBNOF(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF4D60", Offset = "0x3FF3B60", VA = "0x183FF4D60", Slot = "26")]
	public object JGBPAAPKKLK(IOBECAADPPL DKHOCCDNDOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3FF0940", Offset = "0x3FEF740", VA = "0x183FF0940")]
	public bool AJMLBPKCBLJ(IOBECAADPPL DKHOCCDNDOH, in object IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3FF4040", Offset = "0x3FF2E40", VA = "0x183FF4040")]
	public void HMFHOBMDMGG(IOBECAADPPL DKHOCCDNDOH, in PMECDNBONOH GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3FF7460", Offset = "0x3FF6260", VA = "0x183FF7460")]
	public bool NMFBOCJEJOB(IOBECAADPPL DKHOCCDNDOH, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3FFA350", Offset = "0x3FF9150", VA = "0x183FFA350")]
	public bool ONIEOJAKANA(IOBECAADPPL DKHOCCDNDOH, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3829720", Offset = "0x3828520", VA = "0x183829720", Slot = "22")]
	public void KGEJHADOBPB(CPCNLIBKLCB EHGIDPAFOKH, [Optional] object EDPENIGJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5250", Offset = "0x3FF4050", VA = "0x183FF5250", Slot = "15")]
	public void KGEJHADOBPB(IOBECAADPPL BIMCDHOFDCP, BBPNDNFFEFA EHGIDPAFOKH, object EDPENIGJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3FF2A60", Offset = "0x3FF1860", VA = "0x183FF2A60", Slot = "14")]
	public bool HBNCLABAILL(IOBECAADPPL DKIFKKDEOHM, IOBECAADPPL HOGBBBFDPKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3FF90E0", Offset = "0x3FF7EE0", VA = "0x183FF90E0")]
	private void NPBAEECDKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3FF7D70", Offset = "0x3FF6B70", VA = "0x183FF7D70")]
	private void NNEBNPNLBOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3FFC530", Offset = "0x3FFB330", VA = "0x183FFC530")]
	private void POAOKFGBMEH(Entity LLEBIIAHFDD, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3FF4B90", Offset = "0x3FF3990", VA = "0x183FF4B90")]
	private void HPHHCEKMBPD(Entity LLEBIIAHFDD, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x39B60E0", Offset = "0x39B4EE0", VA = "0x1839B60E0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3FFD030", Offset = "0x3FFBE30", VA = "0x183FFD030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3825A40", Offset = "0x3824840", VA = "0x183825A40")]
	public string AEKNGOPJJEL(in EKBGHCIKEGG PEFOOCOGGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x39B6BC0", Offset = "0x39B59C0", VA = "0x1839B6BC0", Slot = "5")]
	private bool NMBJFJNDAPP(IOBECAADPPL BIMCDHOFDCP, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x39B60A0", Offset = "0x39B4EA0", VA = "0x1839B60A0", Slot = "6")]
	private bool DCKFNOGMEOF(IOBECAADPPL BIMCDHOFDCP, in T IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x334DC10", Offset = "0x334CA10", VA = "0x18334DC10", Slot = "10")]
	private bool AFICPNKGIHF(IOBECAADPPL BIMCDHOFDCP, in object IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x39B8420", Offset = "0x39B7220", VA = "0x1839B8420", Slot = "11")]
	private void LCEAMGEHFPH(IOBECAADPPL BIMCDHOFDCP, in PMECDNBONOH GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x39B8890", Offset = "0x39B7690", VA = "0x1839B8890", Slot = "12")]
	private bool MNCIHFEJIKO(IOBECAADPPL BIMCDHOFDCP, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x39B6060", Offset = "0x39B4E60", VA = "0x1839B6060", Slot = "13")]
	private bool ALLHAEICBOC(IOBECAADPPL BIMCDHOFDCP, in EKBGHCIKEGG IOOLGMDKBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3825890", Offset = "0x3824690", VA = "0x183825890", Slot = "16")]
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
		[Cpp2IlInjected.Address(RVA = "0x694580", Offset = "0x693380", VA = "0x180694580", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x122AF60", Offset = "0x1229D60", VA = "0x18122AF60")]
	public NELJHPCAMDK(NativeArray<EntityRemapUtility.EntityRemapInfo> KMPPIJKOEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x301A900", Offset = "0x3019700", VA = "0x18301A900", Slot = "6")]
	public IOBECAADPPL LALMGCKAKDD(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x301A950", Offset = "0x3019750", VA = "0x18301A950", Slot = "7")]
	public Entity LALMGCKAKDD(Entity LLEBIIAHFDD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x301A960", Offset = "0x3019760", VA = "0x18301A960", Slot = "8")]
	public IEnumerable<IOBECAADPPL> LALMGCKAKDD(IEnumerable<IOBECAADPPL> MIDBODKMKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x301A8A0", Offset = "0x30196A0", VA = "0x18301A8A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x32AD910", Offset = "0x32AC710", VA = "0x1832AD910")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static bool DNEMJMCMOCB
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x32ADA20", Offset = "0x32AC820", VA = "0x1832ADA20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x32AD620", Offset = "0x32AC420", VA = "0x1832AD620")]
		public static SerializationRemapScope KEAEHBAHBFH()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x32ADB40", Offset = "0x32AC940", VA = "0x1832ADB40")]
		public SerializationRemapScope(PFFOAGAAAPP AADIDIAMCCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x32AD510", Offset = "0x32AC310", VA = "0x1832AD510", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x32AD7B0", Offset = "0x32AC5B0", VA = "0x1832AD7B0")]
		public static IOBECAADPPL LALMGCKAKDD(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x32AD680", Offset = "0x32AC480", VA = "0x1832AD680")]
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
		[Cpp2IlInjected.Address(RVA = "0x34095F0", Offset = "0x34083F0", VA = "0x1834095F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x34098B0", Offset = "0x34086B0", VA = "0x1834098B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event EBPDNEAKFNF BHHFDOOKDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x34096B0", Offset = "0x34084B0", VA = "0x1834096B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3409810", Offset = "0x3408610", VA = "0x183409810")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event EODGAALKLCG CBPCFHBCEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3409550", Offset = "0x3408350", VA = "0x183409550")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3409750", Offset = "0x3408550", VA = "0x183409750")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x34097F0", Offset = "0x34085F0", VA = "0x1834097F0")]
	[Conditional("UNITY_EDITOR")]
	public void NOOGCJFCFAL(ELJHNEOGEBP DHPFEELIAKK, in CBDNIJIKHKI JLFCOOGLPMP, bool CJEAHGLLLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3409690", Offset = "0x3408490", VA = "0x183409690")]
	[Conditional("UNITY_EDITOR")]
	public void JMOLBLONOAB(ELJHNEOGEBP DHPFEELIAKK, bool CJEAHGLLLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3409520", Offset = "0x3408320", VA = "0x183409520")]
	[Conditional("UNITY_EDITOR")]
	public void CBENKJFMMPJ(ELJHNEOGEBP DHPFEELIAKK, EBLKGKAPHAO GCEENFOFNFL, in EKBGHCIKEGG GKFICKKHACC, bool CJEAHGLLLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3057220", Offset = "0x3056020", VA = "0x183057220")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x30579B0", Offset = "0x30567B0", VA = "0x1830579B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event PGILIODFGBM BHHFDOOKDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3057670", Offset = "0x3056470", VA = "0x183057670")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3057850", Offset = "0x3056650", VA = "0x183057850")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event NMAHDLHMDLE EMJCJDLEKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3057430", Offset = "0x3056230", VA = "0x183057430")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3057360", Offset = "0x3056160", VA = "0x183057360")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event PGILIODFGBM EJKJFJKPKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3057500", Offset = "0x3056300", VA = "0x183057500")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3057B90", Offset = "0x3056990", VA = "0x183057B90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event FOPKOKKCHOF CBPCFHBCEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3057180", Offset = "0x3055F80", VA = "0x183057180")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3057730", Offset = "0x3056530", VA = "0x183057730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event DALADBAGJFF NPELOLJCMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x30578F0", Offset = "0x30566F0", VA = "0x1830578F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x30572C0", Offset = "0x30560C0", VA = "0x1830572C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<string, object> IKGGMJKIPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3057AF0", Offset = "0x30568F0", VA = "0x183057AF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x30570B0", Offset = "0x3055EB0", VA = "0x1830570B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event EHKABHPLGNL LJCGLJKLKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x30575D0", Offset = "0x30563D0", VA = "0x1830575D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3057A50", Offset = "0x3056850", VA = "0x183057A50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x30575A0", Offset = "0x30563A0", VA = "0x1830575A0")]
	[Conditional("UNITY_EDITOR")]
	public void KACAAIGBIKO(ELJHNEOGEBP FFJHOAAMJMD, in CBDNIJIKHKI JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x30577D0", Offset = "0x30565D0", VA = "0x1830577D0")]
	[Conditional("UNITY_EDITOR")]
	public void MICCMNILJEB(ELJHNEOGEBP FFJHOAAMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x3057150", Offset = "0x3055F50", VA = "0x183057150")]
	[Conditional("UNITY_EDITOR")]
	public void DANHNKMPIJM(ELJHNEOGEBP FFJHOAAMJMD, in CBDNIJIKHKI JLFCOOGLPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x3057710", Offset = "0x3056510", VA = "0x183057710")]
	[Conditional("UNITY_EDITOR")]
	public void KOIAFHNDIAO(ELJHNEOGEBP FFJHOAAMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x30574D0", Offset = "0x30562D0", VA = "0x1830574D0")]
	[Conditional("UNITY_EDITOR")]
	public void HOJPJLKKHFF(ELJHNEOGEBP FFJHOAAMJMD, EBLKGKAPHAO GCEENFOFNFL, in EKBGHCIKEGG GKFICKKHACC, bool GPHOGKOEAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x3057990", Offset = "0x3056790", VA = "0x183057990")]
	[Conditional("UNITY_EDITOR")]
	public void OHLOCEIDHLL(ELJHNEOGEBP FFJHOAAMJMD, EBLKGKAPHAO GCEENFOFNFL, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x30577F0", Offset = "0x30565F0", VA = "0x1830577F0")]
	[Conditional("UNITY_EDITOR")]
	public void OAOLNGLKNME(string NLCIGFDKGEE, object OICHLBNIOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x3057400", Offset = "0x3056200", VA = "0x183057400")]
	[Conditional("UNITY_EDITOR")]
	public void GLKNPGAEPHO(HCLOKFAILEI BIMCDHOFDCP, ReadOnlyMemory<byte> OICHLBNIOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public LBONPJJMDCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DAMCBGMFJNJ(typeof(OEAAIOGMMFJ), new string[] { })]
public class FJDEHMCJMJG : OEAAIOGMMFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3042550", Offset = "0x3041350", VA = "0x183042550", Slot = "5")]
	public void MGKBBCGBMCF(object HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3042470", Offset = "0x3041270", VA = "0x183042470", Slot = "6")]
	public void LMNGFKHEOAN(object HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3042390", Offset = "0x3041190", VA = "0x183042390", Slot = "7")]
	public void JIGNEJOOMDJ(object HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3042280", Offset = "0x3041080", VA = "0x183042280", Slot = "4")]
	public IDisposable GHMGLDCDLEB(object HDKJDEIGPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x340DB40", Offset = "0x340C940", VA = "0x18340DB40")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x340BDD0", Offset = "0x340ABD0", VA = "0x18340BDD0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x340C480", Offset = "0x340B280", VA = "0x18340C480", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x340DB90", Offset = "0x340C990", VA = "0x18340DB90")]
		public bool OOFHELPOEED(IEnumerable<KPBHHJNMPGI> GPNIFCAJBPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x340D550", Offset = "0x340C350", VA = "0x18340D550")]
		public static bool MJKONGIHJEM(KPBHHJNMPGI BOBJBDACGIL, out ELJHNEOGEBP FFJHOAAMJMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x340CF60", Offset = "0x340BD60", VA = "0x18340CF60")]
		private void INOEBBCOIHK(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ, IEnumerable<KPBHHJNMPGI> GPNIFCAJBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x340CD30", Offset = "0x340BB30", VA = "0x18340CD30")]
		private void FFOPDPOPKBL(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x340D660", Offset = "0x340C460", VA = "0x18340D660")]
		private void MKKDDPGJLML(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ, ELJHNEOGEBP FFJHOAAMJMD, string NLCIGFDKGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x340C120", Offset = "0x340AF20", VA = "0x18340C120")]
		private void DODDPGFKOMI(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x340C490", Offset = "0x340B290", VA = "0x18340C490")]
		private void EHNIJAOOCGA(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ, List<KPBHHJNMPGI> DEBDIHHEBLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x340BF50", Offset = "0x340AD50", VA = "0x18340BF50")]
		private NativeList<ELJHNEOGEBP> BLAOAKDAOKI(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ)
		{
			return default(NativeList<ELJHNEOGEBP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x340D2E0", Offset = "0x340C0E0", VA = "0x18340D2E0")]
		private NativeArray<Entity> JDPJJFBKOGL(NativeList<ELJHNEOGEBP> EDAEDMAFDDI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x340D4B0", Offset = "0x340C2B0", VA = "0x18340D4B0")]
		private static void LPOANLJOFCG(Dictionary<ELJHNEOGEBP, KPBHHJNMPGI> FAEKHNNILJJ, ELJHNEOGEBP FFJHOAAMJMD, KPBHHJNMPGI BOBJBDACGIL, string NLCIGFDKGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x341DBC0", Offset = "0x341C9C0", VA = "0x18341DBC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x341DB80", Offset = "0x341C980", VA = "0x18341DB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		internal static bool POPGINMEJEC
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x341DB00", Offset = "0x341C900", VA = "0x18341DB00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x341DB40", Offset = "0x341C940", VA = "0x18341DB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		public void DMHNIJDDNHN(string NLCIGFDKGEE, EntityManager CLLNDNAAIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		public static void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CC600", Offset = "0x6CB400", VA = "0x1806CC600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6CC620", Offset = "0x6CB420", VA = "0x1806CC620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool LCAFBNMCIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6CC610", Offset = "0x6CB410", VA = "0x1806CC610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6CC630", Offset = "0x6CB430", VA = "0x1806CC630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x32ADBD0", Offset = "0x32AC9D0", VA = "0x1832ADBD0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x32ADF60", Offset = "0x32ACD60", VA = "0x1832ADF60", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool GHMFEBCFPJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x83F530", Offset = "0x83E330", VA = "0x18083F530", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x83FCC0", Offset = "0x83EAC0", VA = "0x18083FCC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public AKBOANNKIFN ODPABGFJECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x32ADBE0", Offset = "0x32AC9E0", VA = "0x1832ADBE0", Slot = "16")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x32AE640", Offset = "0x32AD440", VA = "0x1832AE640", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x32AEE60", Offset = "0x32ADC60", VA = "0x1832AEE60")]
		public static bool HAHFMLGMGED(ByteString MEFFDBODCGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x721260", Offset = "0x720060", VA = "0x180721260")]
		public void DEOGHFBIFON(HMGGJADOIMB ABLAIFJNIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x32AEF90", Offset = "0x32ADD90", VA = "0x1832AEF90", Slot = "5")]
		public void IKAMGNEEKKF(bool DHOJGMOHHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x32AE2D0", Offset = "0x32AD0D0", VA = "0x1832AE2D0", Slot = "6")]
		public Task DIJMGFAHLJP(bool DHOJGMOHHOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x32AE150", Offset = "0x32ACF50", VA = "0x1832AE150", Slot = "7")]
		public ByteString CLPGJOCDFOA(out IDisposable ABGOLHJFIJF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x32ADF70", Offset = "0x32ACD70", VA = "0x1832ADF70", Slot = "19")]
		public ByteString CLPGJOCDFOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x32AF630", Offset = "0x32AE430", VA = "0x1832AF630", Slot = "9")]
		public bool MNOLKCHHLIP(ByteString LLBACIACODL, KAHOHIEBNCF MBNFLPKEEGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x32AF260", Offset = "0x32AE060", VA = "0x1832AF260")]
		private bool LKHBNCGOLEK(ByteString LLBACIACODL, KAHOHIEBNCF MBNFLPKEEGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x32AE360", Offset = "0x32AD160", VA = "0x1832AE360", Slot = "8")]
		public void DLENKBBIHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x32AEA20", Offset = "0x32AD820", VA = "0x1832AEA20", Slot = "10")]
		public bool FOGMCMNIEAB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x32AF8C0", Offset = "0x32AE6C0", VA = "0x1832AF8C0", Slot = "11")]
		public bool OOFHELPOEED(IEnumerable<KPBHHJNMPGI> JNPPLACLHGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x32AE650", Offset = "0x32AD450", VA = "0x1832AE650")]
		public bool FAPKMEMBOGD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x32AF690", Offset = "0x32AE490", VA = "0x1832AF690", Slot = "12")]
		public bool NHJFFFEKKHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x32ADC80", Offset = "0x32ACA80", VA = "0x1832ADC80")]
		public void BKDMMLJBBDB(AKBOANNKIFN.DMCMPHFHIHA.GJGMMINMIID FILNOJDGMDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x32AE730", Offset = "0x32AD530", VA = "0x1832AE730")]
		private bool FCJNCEJPFEF(ByteString LLBACIACODL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x32ADF10", Offset = "0x32ACD10", VA = "0x1832ADF10")]
		private void CBKMBGIFDFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x32AE9C0", Offset = "0x32AD7C0", VA = "0x1832AE9C0")]
		private ByteString FKJOPBFOPMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x32AE530", Offset = "0x32AD330", VA = "0x1832AE530")]
		private ByteString DMFINCFKAIN(ByteString MEFFDBODCGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x32AE230", Offset = "0x32AD030", VA = "0x1832AE230")]
		private AKBOANNKIFN.DMCMPHFHIHA.GJGMMINMIID DBNIINCFBDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x32AF230", Offset = "0x32AE030", VA = "0x1832AF230")]
		private void KKIELDHGKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x32AF060", Offset = "0x32ADE60", VA = "0x1832AF060", Slot = "13")]
		public bool KDBCJFDIBNM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x32AF580", Offset = "0x32AE380", VA = "0x1832AF580", Slot = "14")]
		public void MDFOLHHLPFL(bool OFIHIKCKNMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x32AEC90", Offset = "0x32ADA90", VA = "0x1832AEC90")]
		private void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x340E120", Offset = "0x340CF20", VA = "0x18340E120", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x340E4E0", Offset = "0x340D2E0", VA = "0x18340E4E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<PFFOAGAAAPP> ADFEOFDFMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x340E3A0", Offset = "0x340D1A0", VA = "0x18340E3A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x340E260", Offset = "0x340D060", VA = "0x18340E260", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action GKKNCKHFJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x340E300", Offset = "0x340D100", VA = "0x18340E300", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x340E580", Offset = "0x340D380", VA = "0x18340E580", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action CAKKPMPEGBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x340E1C0", Offset = "0x340CFC0", VA = "0x18340E1C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x340E080", Offset = "0x340CE80", VA = "0x18340E080", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<PFFOAGAAAPP> LAEKLDBCGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x340E620", Offset = "0x340D420", VA = "0x18340E620", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x340E440", Offset = "0x340D240", VA = "0x18340E440", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1476B60", Offset = "0x1475960", VA = "0x181476B60")]
	public void DLENKBBIHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1B9CDD0", Offset = "0x1B9BBD0", VA = "0x181B9CDD0")]
	public void DOPCNLFKEDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x19EEB40", Offset = "0x19ED940", VA = "0x1819EEB40")]
	public void MFCKIIMENCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x340E6C0", Offset = "0x340D4C0", VA = "0x18340E6C0")]
	public void PECJHMIOPNG(PFFOAGAAAPP BOOMEIJCBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x340E030", Offset = "0x340CE30", VA = "0x18340E030")]
	public void AAGMNNKDCMD(PFFOAGAAAPP BOOMEIJCBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x652A00", Offset = "0x651800", VA = "0x180652A00", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x652C90", Offset = "0x651A90", VA = "0x180652C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EntityManager FAINNDBCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3051560", Offset = "0x3050360", VA = "0x183051560")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7A99D0", Offset = "0x7A87D0", VA = "0x1807A99D0", Slot = "14")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3050390", Offset = "0x304F190", VA = "0x183050390", Slot = "15")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x30515B0", Offset = "0x30503B0", VA = "0x1830515B0", Slot = "16")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0xA5B240", Offset = "0xA5A040", VA = "0x180A5B240", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3021660", Offset = "0x3020460", VA = "0x183021660")]
	private IOBECAADPPL KPDLDNMJLLL(Entity LLEBIIAHFDD)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3050AB0", Offset = "0x304F8B0", VA = "0x183050AB0", Slot = "4")]
	public IOBECAADPPL IENNNAFGFNJ(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3050460", Offset = "0x304F260", VA = "0x183050460", Slot = "19")]
	public void BBCNGMBMGMH(ref List<IOBECAADPPL> DFMCPPMHIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3051360", Offset = "0x3050160", VA = "0x183051360", Slot = "20")]
	public IEnumerable<IOBECAADPPL> OEGOHCELJAI(IOBECAADPPL DKHOCCDNDOH, bool HOJIMILIDNA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3050FE0", Offset = "0x304FDE0", VA = "0x183050FE0", Slot = "21")]
	public IOBECAADPPL MMFPKICCFCA(IOBECAADPPL DKHOCCDNDOH, int BNNEENLPEFO)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3050EC0", Offset = "0x304FCC0", VA = "0x183050EC0", Slot = "22")]
	public int MDOMKMPHBAP(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x30516A0", Offset = "0x30504A0", VA = "0x1830516A0", Slot = "8")]
	public int PEOBNLMKOKI(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x30511B0", Offset = "0x304FFB0", VA = "0x1830511B0", Slot = "9")]
	public CDDJMIAEBFF MNFKOJBKCKK(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(CDDJMIAEBFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x3050690", Offset = "0x304F490", VA = "0x183050690", Slot = "23")]
	public bool DAFPDNAKGFF(IOBECAADPPL DKHOCCDNDOH, out CDDJMIAEBFF BBFDGAIKNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x3050D40", Offset = "0x304FB40", VA = "0x183050D40", Slot = "24")]
	public IEnumerable<IOBECAADPPL> LBLBJIKOPHN(IOBECAADPPL DKHOCCDNDOH, bool HOJIMILIDNA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x3050C70", Offset = "0x304FA70", VA = "0x183050C70", Slot = "12")]
	public IOBECAADPPL KIGGLEINDHC(IOBECAADPPL ADDDKDIDHPJ, IOBECAADPPL LCEKCMGAGEI)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x3050BA0", Offset = "0x304F9A0", VA = "0x183050BA0", Slot = "13")]
	public bool KCBAGPAHKEE(IOBECAADPPL ADDDKDIDHPJ, IOBECAADPPL LCEKCMGAGEI, out IOBECAADPPL BKMGHCEAABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x3050860", Offset = "0x304F660", VA = "0x183050860", Slot = "5")]
	public IOBECAADPPL DJKFCHELMJI(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x30512A0", Offset = "0x30500A0", VA = "0x1830512A0", Slot = "11")]
	public bool NLDBNJEFDEH(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL NMJJIOLIMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x3050900", Offset = "0x304F700", VA = "0x183050900", Slot = "25")]
	public bool HDGJJPALPML(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL DBNJJKLOCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x3051840", Offset = "0x3050640", VA = "0x183051840", Slot = "10")]
	public bool PGPKCLNGJPJ(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL ADDDKDIDHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x3050E10", Offset = "0x304FC10", VA = "0x183050E10", Slot = "6")]
	public bool LHJCDGMFADO(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL GEOFAMNLJNK, bool CHPHLJOKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x3050A40", Offset = "0x304F840", VA = "0x183050A40", Slot = "7")]
	public bool HKIAAFFILCD(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL GEOFAMNLJNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x340E710", Offset = "0x340D510", VA = "0x18340E710", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x340E760", Offset = "0x340D560", VA = "0x18340E760", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x340EB70", Offset = "0x340D970", VA = "0x18340EB70")]
	public EAAOOBCMLAD LDPPLEPCPJK(PMBKKKKDOIF BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x340EC70", Offset = "0x340DA70", VA = "0x18340EC70")]
	public EAAOOBCMLAD LDPPLEPCPJK(EBLKGKAPHAO KBPOLLDMHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x340E9E0", Offset = "0x340D7E0", VA = "0x18340E9E0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x340EE90", Offset = "0x340DC90", VA = "0x18340EE90")]
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
		[Cpp2IlInjected.Address(RVA = "0x694580", Offset = "0x693380", VA = "0x180694580")]
		get
		{
			return default(NativeList<NJAEBHKONED>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<CAIGEBHNCMM> MHEPHCNFOND
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6C17C0", Offset = "0x6C05C0", VA = "0x1806C17C0")]
		get
		{
			return default(NativeList<CAIGEBHNCMM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<CPMOBHMFHFP> NCFNPLOJOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8E20B0", Offset = "0x8E0EB0", VA = "0x1808E20B0")]
		get
		{
			return default(NativeList<CPMOBHMFHFP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<CAIGEBHNCMM> CJJBNCPHPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B5390", Offset = "0x7B4190", VA = "0x1807B5390")]
		get
		{
			return default(NativeList<CAIGEBHNCMM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JobHandle BKGGOCNKAKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6C1690", Offset = "0x6C0490", VA = "0x1806C1690")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1B90C00", Offset = "0x1B8FA00", VA = "0x181B90C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool AACDAEOPAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x72D150", Offset = "0x72BF50", VA = "0x18072D150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool MLCHHGLGNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x341E860", Offset = "0x341D660", VA = "0x18341E860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x341EDA0", Offset = "0x341DBA0", VA = "0x18341EDA0")]
	public EAAOOBCMLAD(Allocator PBEDBDBGIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x341EBE0", Offset = "0x341D9E0", VA = "0x18341EBE0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x341EC70", Offset = "0x341DA70", VA = "0x18341EC70")]
	public void OJNONIJIFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x341E910", Offset = "0x341D710", VA = "0x18341E910")]
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
	[Cpp2IlInjected.Address(RVA = "0x30471F0", Offset = "0x3045FF0", VA = "0x1830471F0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3047240", Offset = "0x3046040", VA = "0x183047240", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0xD19D70", Offset = "0xD18B70", VA = "0x180D19D70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x301B860", Offset = "0x301A660", VA = "0x18301B860")]
	public ELJHNEOGEBP GECODMKPHFO()
	{
		return default(ELJHNEOGEBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x301B8B0", Offset = "0x301A6B0", VA = "0x18301B8B0")]
	public void HGHOOHBDAKM(ELJHNEOGEBP FFJHOAAMJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1694710", Offset = "0x1693510", VA = "0x181694710", Slot = "6")]
	public virtual void FBGINNLGAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F190", Offset = "0x64DF90", VA = "0x18064F190", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x340DEE0", Offset = "0x340CCE0", VA = "0x18340DEE0", Slot = "7")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x340DFE0", Offset = "0x340CDE0", VA = "0x18340DFE0")]
	private void IJJJDHMONCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x340DF80", Offset = "0x340CD80", VA = "0x18340DF80", Slot = "6")]
	public override void FBGINNLGAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
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
		[Cpp2IlInjected.Address(RVA = "0x6681A0", Offset = "0x666FA0", VA = "0x1806681A0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
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
		[Cpp2IlInjected.Address(RVA = "0x3405A60", Offset = "0x3404860", VA = "0x183405A60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public EntityQuery MIOKJKFCJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6CF580", Offset = "0x6CE380", VA = "0x1806CF580")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityQuery MNAHMGFJHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x69EA40", Offset = "0x69D840", VA = "0x18069EA40")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery NOPNHEHJPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x65D650", Offset = "0x65C450", VA = "0x18065D650")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery MOKJIIBJLEL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6C1690", Offset = "0x6C0490", VA = "0x1806C1690")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery KMEJOKGPONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6C1780", Offset = "0x6C0580", VA = "0x1806C1780")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery EPGEJPNGAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x34057C0", Offset = "0x34045C0", VA = "0x1834057C0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int FPBPGMMCKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3405670", Offset = "0x3404470", VA = "0x183405670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int LHABKJIKBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x34058C0", Offset = "0x34046C0", VA = "0x1834058C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int BCLIAIHMKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3405F50", Offset = "0x3404D50", VA = "0x183405F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int DIDPKJIDHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3405690", Offset = "0x3404490", VA = "0x183405690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int BLJFNHJIFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x34058A0", Offset = "0x34046A0", VA = "0x1834058A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int APFOGEGGMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x34058E0", Offset = "0x34046E0", VA = "0x1834058E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "4")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x3405620", Offset = "0x3404420", VA = "0x183405620", Slot = "5")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x3405AB0", Offset = "0x34048B0", VA = "0x183405AB0", Slot = "6")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3405840", Offset = "0x3404640", VA = "0x183405840")]
	private EntityQueryDesc FIDOMOLJMKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x3405760", Offset = "0x3404560", VA = "0x183405760", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3405900", Offset = "0x3404700", VA = "0x183405900")]
	public KPCHKKCKBJJ NIJCJBHNDEI(IOBECAADPPL IBGBBCHPJJF)
	{
		return default(KPCHKKCKBJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x34059B0", Offset = "0x34047B0", VA = "0x1834059B0")]
	public KPCHKKCKBJJ NIJCJBHNDEI(Entity LLEBIIAHFDD)
	{
		return default(KPCHKKCKBJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x34056B0", Offset = "0x34044B0", VA = "0x1834056B0")]
	public OADLDHPKENB DEOOPJFHNNH(Entity LLEBIIAHFDD)
	{
		return default(OADLDHPKENB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3405F70", Offset = "0x3404D70", VA = "0x183405F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int FPBPGMMCKJI
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x302AA50", Offset = "0x3029850", VA = "0x18302AA50", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int LHABKJIKBDC
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x302B960", Offset = "0x302A760", VA = "0x18302B960", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int BCLIAIHMKBM
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x302C310", Offset = "0x302B110", VA = "0x18302C310", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int DIDPKJIDHNP
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x302AB10", Offset = "0x3029910", VA = "0x18302AB10", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int BLJFNHJIFIC
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x302B480", Offset = "0x302A280", VA = "0x18302B480", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int APFOGEGGMHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x302C0D0", Offset = "0x302AED0", VA = "0x18302C0D0", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<IOBECAADPPL, OADLDHPKENB> JKKKCONJDDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x302A6A0", Offset = "0x30294A0", VA = "0x18302A6A0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x302A9B0", Offset = "0x30297B0", VA = "0x18302A9B0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<IOBECAADPPL> MCDKIJEJMFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x302B270", Offset = "0x302A070", VA = "0x18302B270", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x302B9D0", Offset = "0x302A7D0", VA = "0x18302B9D0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x302A430", Offset = "0x3029230", VA = "0x18302A430", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x302AD70", Offset = "0x3029B70", VA = "0x18302AD70", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x302AA70", Offset = "0x3029870", VA = "0x18302AA70")]
		private void BIFFFAEPCDP(Entity LLEBIIAHFDD, OADLDHPKENB FKEOEHMKOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x302C130", Offset = "0x302AF30", VA = "0x18302C130")]
		private void NDMKPJNHFGM(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x302BE90", Offset = "0x302AC90", VA = "0x18302BE90")]
		internal IOBECAADPPL KPDLDNMJLLL(Entity LLEBIIAHFDD)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x302AF10", Offset = "0x3029D10", VA = "0x18302AF10", Slot = "41")]
		public CDDJMIAEBFF ECEBNNCCOBB()
		{
			return default(CDDJMIAEBFF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x302C260", Offset = "0x302B060", VA = "0x18302C260", Slot = "42")]
		public CDDJMIAEBFF PHHGOOCOPED()
		{
			return default(CDDJMIAEBFF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x302A910", Offset = "0x3029710", VA = "0x18302A910", Slot = "43")]
		public CDDJMIAEBFF BBMCNGNNHMF()
		{
			return default(CDDJMIAEBFF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x302C230", Offset = "0x302B030", VA = "0x18302C230", Slot = "10")]
		public KPCHKKCKBJJ NIJCJBHNDEI(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(KPCHKKCKBJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x302ACF0", Offset = "0x3029AF0", VA = "0x18302ACF0", Slot = "11")]
		public OADLDHPKENB DEOOPJFHNNH(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(OADLDHPKENB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x302AC40", Offset = "0x3029A40", VA = "0x18302AC40")]
		private CDDJMIAEBFF DDKJCHDPEGP(EntityQuery NJIBLOIMOJA)
		{
			return default(CDDJMIAEBFF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x302B1E0", Offset = "0x3029FE0", VA = "0x18302B1E0", Slot = "33")]
		public bool FONENOMBNOF(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x302BA70", Offset = "0x302A870", VA = "0x18302BA70", Slot = "29")]
		public void KDKECGLKPJA(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x302B8A0", Offset = "0x302A6A0", VA = "0x18302B8A0", Slot = "30")]
		public void HNJDDIFBIFG(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x302B510", Offset = "0x302A310", VA = "0x18302B510", Slot = "31")]
		public void HFPMFHPHKJM(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x302B310", Offset = "0x302A110", VA = "0x18302B310", Slot = "22")]
		public MFPKOBHCDLK HCPNNJMCDBO(OADLDHPKENB FKEOEHMKOOO, bool KCJPFJDMHDE)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x302B400", Offset = "0x302A200", VA = "0x18302B400", Slot = "23")]
		public MFPKOBHCDLK HCPNNJMCDBO(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x302ABB0", Offset = "0x30299B0", VA = "0x18302ABB0", Slot = "24")]
		public MFPKOBHCDLK CMKBHBIKKLG(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x302A740", Offset = "0x3029540", VA = "0x18302A740", Slot = "25")]
		public MFPKOBHCDLK BBEBKABPFOC(ELJHNEOGEBP FFJHOAAMJMD, OADLDHPKENB FKEOEHMKOOO)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x302BFB0", Offset = "0x302ADB0", VA = "0x18302BFB0", Slot = "44")]
		public MFPKOBHCDLK MFMNBNMJJLB(int JKCKEDCDOEI, OADLDHPKENB FKEOEHMKOOO, GameObject ENOCMPCACJI)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x302B760", Offset = "0x302A560", VA = "0x18302B760", Slot = "26")]
		public OEHLCFMEIAB HKGIPEPAOCC()
		{
			return default(OEHLCFMEIAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x302BBE0", Offset = "0x302A9E0", VA = "0x18302BBE0", Slot = "45")]
		public BEFNEJPCLCN KHOBNGEHLKF(NFAEFFLJLPD BIEGICDMJCM)
		{
			return default(BEFNEJPCLCN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x302C020", Offset = "0x302AE20", VA = "0x18302C020", Slot = "27")]
		public JHBDPEEMJNG MJFCMEDMLAE()
		{
			return default(JHBDPEEMJNG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x302BAC0", Offset = "0x302A8C0", VA = "0x18302BAC0", Slot = "28")]
		public PILKLNFGMCM KHIJCCNCJJA(CKLKKHOPBLL BIEGICDMJCM)
		{
			return default(PILKLNFGMCM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x302AFB0", Offset = "0x3029DB0", VA = "0x18302AFB0", Slot = "12")]
		public void EHMHLLLMBAF(ELJHNEOGEBP FFJHOAAMJMD, IAEGHKEFOHF DJGPJGBFCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x302BCE0", Offset = "0x302AAE0", VA = "0x18302BCE0", Slot = "13")]
		public MFPKOBHCDLK KOGFABJEPCO(IOBECAADPPL DKHOCCDNDOH, [Optional] object JJFHDFJGCDG)
		{
			return default(MFPKOBHCDLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x302BEB0", Offset = "0x302ACB0", VA = "0x18302BEB0", Slot = "14")]
		public bool LFCLKAMJJHD(IOBECAADPPL DKHOCCDNDOH, out IAEGHKEFOHF BMBFIGGJLDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x302AFD0", Offset = "0x3029DD0", VA = "0x18302AFD0", Slot = "46")]
		public Transform EICBEGAJFIO(IOBECAADPPL DKHOCCDNDOH, [Optional] object JJFHDFJGCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x302B980", Offset = "0x302A780", VA = "0x18302B980", Slot = "16")]
		public bool JCBPEMMLHHC(IOBECAADPPL DKHOCCDNDOH, out Transform KAMDPLLJPAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x302B110", Offset = "0x3029F10", VA = "0x18302B110", Slot = "17")]
		public bool FEOLDMHKLBA(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x302BF80", Offset = "0x302AD80", VA = "0x18302BF80")]
		public bool MBLEKNDNMJF(IAEGHKEFOHF GKFICKKHACC, [Optional] object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x302BF50", Offset = "0x302AD50", VA = "0x18302BF50", Slot = "47")]
		public bool MBLEKNDNMJF(IOBECAADPPL DKHOCCDNDOH, [Optional] object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x302AEF0", Offset = "0x3029CF0", VA = "0x18302AEF0", Slot = "48")]
		public void EACAKCNLMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x302B5B0", Offset = "0x302A3B0", VA = "0x18302B5B0", Slot = "15")]
		public void HGCNIJCLDNO(IAEGHKEFOHF KMFLGGMLFJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x302AD30", Offset = "0x3029B30", VA = "0x18302AD30", Slot = "49")]
		public void DGOFNAPNLLM(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x302AB30", Offset = "0x3029930", VA = "0x18302AB30", Slot = "18")]
		public bool BOLFGPMHGFA(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x302B160", Offset = "0x3029F60", VA = "0x18302B160", Slot = "19")]
		public bool FKAOODJLIPP(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x302B4A0", Offset = "0x302A2A0", VA = "0x18302B4A0", Slot = "50")]
		public bool HFJCFCGMDPD(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x302C1C0", Offset = "0x302AFC0", VA = "0x18302C1C0", Slot = "51")]
		public bool NFEPDLIEMIB(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x302B900", Offset = "0x302A700", VA = "0x18302B900", Slot = "32")]
		public NativeArray<(IOBECAADPPL, IOBECAADPPL)> HOELGELKEPN(NativeArray<IOBECAADPPL> PDHJHNDNLLA, Allocator PBEDBDBGIPF)
		{
			return default(NativeArray<(IOBECAADPPL, IOBECAADPPL)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x302B800", Offset = "0x302A600", VA = "0x18302B800", Slot = "21")]
		public ELJHNEOGEBP HLAFIPJDKEG(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(ELJHNEOGEBP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x302B020", Offset = "0x3029E20", VA = "0x18302B020", Slot = "20")]
		public IOBECAADPPL FEEDHGOGJCP(ELJHNEOGEBP FFJHOAAMJMD)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x302C0F0", Offset = "0x302AEF0", VA = "0x18302C0F0")]
		private void MMDMIKBJDCB(OADLDHPKENB FKEOEHMKOOO, IOBECAADPPL DKHOCCDNDOH, ELJHNEOGEBP FFJHOAAMJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x302DD60", Offset = "0x302CB60", VA = "0x18302DD60", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x302E620", Offset = "0x302D420", VA = "0x18302E620")]
	public NativeArray<(IOBECAADPPL, IOBECAADPPL)> HOELGELKEPN(NativeArray<IOBECAADPPL> PDHJHNDNLLA, Allocator PBEDBDBGIPF)
	{
		return default(NativeArray<(IOBECAADPPL, IOBECAADPPL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x302E440", Offset = "0x302D240", VA = "0x18302E440")]
	private void GHKDJCBPPAO(NativeMultiHashMap<int, (IOBECAADPPL src, IOBECAADPPL dst)> MEDKODGAKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x302DDF0", Offset = "0x302CBF0", VA = "0x18302DDF0")]
	private void CFEMINFKJCC(NativeMultiHashMap<int, (IOBECAADPPL src, IOBECAADPPL dst)> MEDKODGAKKM, int FKEOEHMKOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x302E2B0", Offset = "0x302D0B0", VA = "0x18302E2B0")]
	private void DHPNDMILNKI(NativeMultiHashMap<int, (IOBECAADPPL src, IOBECAADPPL dst)> MEDKODGAKKM, int FKEOEHMKOOO, OCECHDCDPOJ HFDCOKODHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x302E720", Offset = "0x302D520", VA = "0x18302E720")]
	private NativeMultiHashMap<int, (IOBECAADPPL, IOBECAADPPL)> MDONIDDBJIH(Allocator PBEDBDBGIPF, NativeArray<IOBECAADPPL> PDHJHNDNLLA, out NativeArray<(IOBECAADPPL src, IOBECAADPPL dst)> NICAJNDACAL)
	{
		return default(NativeMultiHashMap<int, (IOBECAADPPL, IOBECAADPPL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x32B9870", Offset = "0x32B8670", VA = "0x1832B9870")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private DKCCOABIFKH NBPAAHMKIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x32B9120", Offset = "0x32B7F20", VA = "0x1832B9120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x32B5710", Offset = "0x32B4510", VA = "0x1832B5710", Slot = "33")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x32B6B40", Offset = "0x32B5940", VA = "0x1832B6B40", Slot = "34")]
		public bool GMLIGBEENEK(Transform KAMDPLLJPAH, out IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x32B5A40", Offset = "0x32B4840", VA = "0x1832B5A40", Slot = "35")]
		public Transform ALNLJDPANJK(Entity LLEBIIAHFDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x32B7DC0", Offset = "0x32B6BC0", VA = "0x1832B7DC0", Slot = "30")]
		public bool JCBPEMMLHHC(Entity LLEBIIAHFDD, out Transform KAMDPLLJPAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x32B8BC0", Offset = "0x32B79C0", VA = "0x1832B8BC0")]
		private void MCCFNAMKFAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x32B9C50", Offset = "0x32B8A50", VA = "0x1832B9C50", Slot = "29")]
		public void PLIGLHGBAGN(Entity LLEBIIAHFDD, out Matrix4x4 GHAKBOOBHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x32B78F0", Offset = "0x32B66F0", VA = "0x1832B78F0", Slot = "4")]
		public void IHDDNHABLEI(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x32B5B00", Offset = "0x32B4900", VA = "0x1832B5B00")]
		public void BFPDFLACGDF(Entity LLEBIIAHFDD, Vector3 LDFDHMMJHKJ, Quaternion FFJKKBHOOAD, Vector3 BBOMBFCOECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x32B8AB0", Offset = "0x32B78B0", VA = "0x1832B8AB0")]
		public void LPEMLPHEGFD(Entity LLEBIIAHFDD, Vector3 LDFDHMMJHKJ, Quaternion FFJKKBHOOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x32B6B30", Offset = "0x32B5930", VA = "0x1832B6B30", Slot = "27")]
		public void GCMMDJODJOG(Entity LLEBIIAHFDD, out Matrix4x4 LOHMBGKFONM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x32B81F0", Offset = "0x32B6FF0", VA = "0x1832B81F0")]
		public void KHOOABIGBKK(Entity LLEBIIAHFDD, in Matrix4x4 GHAKBOOBHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x32B7FD0", Offset = "0x32B6DD0", VA = "0x1832B7FD0")]
		public void JGEIAOPMIGJ(Entity LLEBIIAHFDD, in Matrix4x4 GHAKBOOBHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x32B6760", Offset = "0x32B5560", VA = "0x1832B6760")]
		public void FDIKFFPEOAJ(Entity LLEBIIAHFDD, in Matrix4x4 LGNKGFFLMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x32B7AE0", Offset = "0x32B68E0", VA = "0x1832B7AE0", Slot = "5")]
		public void IIGCMNAHEEM(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x32B9760", Offset = "0x32B8560", VA = "0x1832B9760", Slot = "6")]
		public Vector3 OGMEJNOPKIG(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x32B6D00", Offset = "0x32B5B00", VA = "0x1832B6D00", Slot = "7")]
		public void HCIMLKEKEGD(Entity LLEBIIAHFDD, Quaternion GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x32B8100", Offset = "0x32B6F00", VA = "0x1832B8100", Slot = "8")]
		public Quaternion KHECIBFIDFA(Entity LLEBIIAHFDD)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x32B8F80", Offset = "0x32B7D80", VA = "0x1832B8F80", Slot = "12")]
		public void MLLMOHDIEAN(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x32B89A0", Offset = "0x32B77A0", VA = "0x1832B89A0", Slot = "11")]
		public Vector3 LODBGHKNMFG(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x32B6190", Offset = "0x32B4F90", VA = "0x1832B6190")]
		public void DCHNKNBMGKD(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x32B9080", Offset = "0x32B7E80", VA = "0x1832B9080")]
		private Vector3 NOABFLADDHG(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x32B91E0", Offset = "0x32B7FE0", VA = "0x1832B91E0", Slot = "14")]
		public float NOLBODPKAIP(Entity LLEBIIAHFDD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x32B9B40", Offset = "0x32B8940", VA = "0x1832B9B40", Slot = "13")]
		public void PJJHINIBHKH(Entity LLEBIIAHFDD, float GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x32B8CC0", Offset = "0x32B7AC0", VA = "0x1832B8CC0")]
		private float MFAEEOOMFMP(Entity LLEBIIAHFDD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x32B66D0", Offset = "0x32B54D0", VA = "0x1832B66D0")]
		public void FDENABGCBDO(Entity LLEBIIAHFDD, float ACDGDLHMKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x32B8BE0", Offset = "0x32B79E0", VA = "0x1832B8BE0", Slot = "16")]
		public Vector3 MCGCOLLLJFK(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x32B6230", Offset = "0x32B5030", VA = "0x1832B6230", Slot = "15")]
		public void EEAKENOGMEN(Entity LLEBIIAHFDD, Vector3 KGGFKDAFODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x32B6370", Offset = "0x32B5170", VA = "0x1832B6370")]
		private Vector3 EMOJPODLPEF(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x32B60C0", Offset = "0x32B4EC0", VA = "0x1832B60C0")]
		public void CPHPPFHJEFC(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x32B6E00", Offset = "0x32B5C00", VA = "0x1832B6E00")]
		[Conditional("DEBUG_BUILD")]
		private void HLAHFNPGBOD(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x32B55B0", Offset = "0x32B43B0", VA = "0x1832B55B0", Slot = "36")]
		public void ABALAFELJND(Entity LLEBIIAHFDD, Vector3 DKGAADMNOOM, Quaternion MPLPNDNEAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x32B8E30", Offset = "0x32B7C30", VA = "0x1832B8E30", Slot = "9")]
		public void MGIGIPIDLIH(Entity LLEBIIAHFDD, out Vector3 DKGAADMNOOM, out Quaternion MPLPNDNEAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x32B98C0", Offset = "0x32B86C0", VA = "0x1832B98C0", Slot = "10")]
		public void OMJCHKEJCIH(Entity LLEBIIAHFDD, out Vector3 DKGAADMNOOM, out Quaternion MPLPNDNEAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x32B5820", Offset = "0x32B4620", VA = "0x1832B5820", Slot = "37")]
		public void AKJEACGFEKE(Entity LLEBIIAHFDD, Vector3 DKGAADMNOOM, Quaternion MPLPNDNEAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x32B7C00", Offset = "0x32B6A00", VA = "0x1832B7C00")]
		public void JBFBPHOGMOJ(Entity LLEBIIAHFDD, Vector3 DKGAADMNOOM, Quaternion MPLPNDNEAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x32B64A0", Offset = "0x32B52A0", VA = "0x1832B64A0", Slot = "17")]
		public void FBLCCHGHILK(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x32B88C0", Offset = "0x32B76C0", VA = "0x1832B88C0", Slot = "18")]
		public Vector3 LKOKJKAIOIA(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x32B7250", Offset = "0x32B6050", VA = "0x1832B7250", Slot = "19")]
		public void IBJDHJLCLKC(Entity LLEBIIAHFDD, Quaternion GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x32B6FB0", Offset = "0x32B5DB0", VA = "0x1832B6FB0", Slot = "20")]
		public Quaternion HMLMDEOMJAN(Entity LLEBIIAHFDD)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x32B7490", Offset = "0x32B6290", VA = "0x1832B7490", Slot = "22")]
		public void IFPCAPAAKPN(Entity LLEBIIAHFDD, Vector3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x32B6920", Offset = "0x32B5720", VA = "0x1832B6920", Slot = "21")]
		public Vector3 FDOGMMGCOEN(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x32BA440", Offset = "0x32B9240", VA = "0x1832BA440", Slot = "23")]
		public void PPPNLBFCJFD(Entity LLEBIIAHFDD, float EGFILNDJKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x32B7EB0", Offset = "0x32B6CB0", VA = "0x1832B7EB0", Slot = "24")]
		public float JDBDDFJHOEH(Entity LLEBIIAHFDD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x32B5BD0", Offset = "0x32B49D0", VA = "0x1832B5BD0", Slot = "25")]
		public void CHHLDHPCMMB(Entity LLEBIIAHFDD, Vector3 JENKAHPOBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x32B9280", Offset = "0x32B8080", VA = "0x1832B9280", Slot = "26")]
		public Vector3 OABMAPMDEOE(Entity LLEBIIAHFDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x32B9DA0", Offset = "0x32B8BA0", VA = "0x1832B9DA0", Slot = "31")]
		public void PPNOENJNOFM(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x32B99F0", Offset = "0x32B87F0", VA = "0x1832B99F0")]
		private IOBECAADPPL PGCICELADOB(Transform KAMDPLLJPAH)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x32B85B0", Offset = "0x32B73B0", VA = "0x1832B85B0")]
		private static TransformEntity KMHKBFDPGMA(OADLDHPKENB BIEGICDMJCM, GameObject HCKEHDIEAIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x32B6A10", Offset = "0x32B5810", VA = "0x1832B6A10", Slot = "32")]
		public void FMGLKIBNGOO(Entity LLEBIIAHFDD, Entity KAEGMLMLAJA, Entity JJHAACNMGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x32B8DB0", Offset = "0x32B7BB0", VA = "0x1832B8DB0")]
		private KBFBMIPJNPL MGIGIPIDLIH(Entity LLEBIIAHFDD)
		{
			return default(KBFBMIPJNPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x32B87E0", Offset = "0x32B75E0", VA = "0x1832B87E0")]
		private bool LKGKJANJDBO(Entity LLEBIIAHFDD, out Entity GEOFAMNLJNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x32B70A0", Offset = "0x32B5EA0", VA = "0x1832B70A0")]
		private void IBIBKHDJHGN(Entity LLEBIIAHFDD, out Matrix4x4 GHAKBOOBHJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x32B93C0", Offset = "0x32B81C0", VA = "0x1832B93C0")]
		private void OBDFHIJJDPP(Entity LLEBIIAHFDD, out Matrix4x4 LGNKGFFLMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x32B6360", Offset = "0x32B5160", VA = "0x1832B6360", Slot = "28")]
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
	[Cpp2IlInjected.Address(RVA = "0x3030460", Offset = "0x302F260", VA = "0x183030460", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x3030530", Offset = "0x302F330", VA = "0x183030530", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x32A9590", Offset = "0x32A8390", VA = "0x1832A9590")]
		public MPCMPBDOOAJ(DEGJKJKDLPE GEOFAMNLJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x32A9570", Offset = "0x32A8370", VA = "0x1832A9570", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x19D69C0", Offset = "0x19D57C0", VA = "0x1819D69C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action IHPCAFGJOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x341B7D0", Offset = "0x341A5D0", VA = "0x18341B7D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x341B730", Offset = "0x341A530", VA = "0x18341B730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x341B890", Offset = "0x341A690", VA = "0x18341B890")]
	public MPCMPBDOOAJ LDPILBHHNFH()
	{
		return default(MPCMPBDOOAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x85E7E0", Offset = "0x85D5E0", VA = "0x18085E7E0")]
	public void PMGJFJIAKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x341B870", Offset = "0x341A670", VA = "0x18341B870")]
	public void KKJEAOGKMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x895A20", Offset = "0x894820", VA = "0x180895A20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x895AB0", Offset = "0x8948B0", VA = "0x180895AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F2BAF0", Offset = "0x3F2A8F0", VA = "0x183F2BAF0")]
			public OHOMNAAHBDO(NativeArray<int> PKJIGGECDGK, NativeArray<int> EMLNAJJBPOG, Dictionary<ComponentSystemBase, int> DPIFDIMDPPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x3F2B870", Offset = "0x3F2A670", VA = "0x183F2B870")]
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
				[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
			[DebuggerHidden]
			public GGDADDJAKPD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x3F26930", Offset = "0x3F25730", VA = "0x183F26930", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x3F26B00", Offset = "0x3F25900", VA = "0x183F26B00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x3F26A50", Offset = "0x3F25850", VA = "0x183F26A50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x3F26A50", Offset = "0x3F25850", VA = "0x183F26A50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x303D1C0", Offset = "0x303BFC0", VA = "0x18303D1C0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x303D2E0", Offset = "0x303C0E0", VA = "0x18303D2E0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x303D430", Offset = "0x303C230", VA = "0x18303D430")]
		[IteratorStateMachine(typeof(GGDADDJAKPD))]
		private IEnumerable<ComponentSystemBase> FLHEONDAKAH(int HOKMFDPKLJA, int OCMAALMMILB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x303E2D0", Offset = "0x303D0D0", VA = "0x18303E2D0", Slot = "5")]
		public void PGNCABCBGBJ(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x303D570", Offset = "0x303C370", VA = "0x18303D570")]
		private void HHOOEHNKNPJ(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x303D6C0", Offset = "0x303C4C0", VA = "0x18303D6C0")]
		public void HHOOEHNKNPJ(JIJBLGHADKE CJLOHKHKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x303D9D0", Offset = "0x303C7D0", VA = "0x18303D9D0")]
		private void MFBNMNBOABJ(JIJBLGHADKE CJLOHKHKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x303E2E0", Offset = "0x303D0E0", VA = "0x18303E2E0")]
		private void PIDHHEDJGJB(JIJBLGHADKE CJLOHKHKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x303D910", Offset = "0x303C710", VA = "0x18303D910")]
		private void KPNEMMFDCEM(JIJBLGHADKE CJLOHKHKFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x303DC80", Offset = "0x303CA80", VA = "0x18303DC80")]
		private void ONPDFLHJOKF(int HOKMFDPKLJA, int OCMAALMMILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x303D370", Offset = "0x303C170", VA = "0x18303D370")]
		private void EEFBGNFDBDE(int HOKMFDPKLJA, int OCMAALMMILB, bool DHOJGMOHHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x303DC60", Offset = "0x303CA60", VA = "0x18303DC60")]
		private int OMFCDJDHNKI(JIJBLGHADKE CJLOHKHKFCM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x303DD40", Offset = "0x303CB40", VA = "0x18303DD40")]
		private bool PGLFJBOBKLD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x303D7C0", Offset = "0x303C5C0", VA = "0x18303D7C0")]
		private Dictionary<ComponentSystemBase, int> JCDLECKEKJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x303D2A0", Offset = "0x303C0A0", VA = "0x18303D2A0")]
		private void DKJPLKEKGDF(NativeArray<int> PKJIGGECDGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x303D4C0", Offset = "0x303C2C0", VA = "0x18303D4C0")]
		private void HBOHPCKFPLP(NativeArray<int> EMLNAJJBPOG, NativeArray<int> PKJIGGECDGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x303D8B0", Offset = "0x303C6B0", VA = "0x18303D8B0")]
		private static JIJBLGHADKE JHLDJLBMFGK(Type BIEGICDMJCM, JIJBLGHADKE BJJKLHEAKLF)
		{
			return default(JIJBLGHADKE);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x303E400", Offset = "0x303D200", VA = "0x18303E400")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x303D970", Offset = "0x303C770", VA = "0x18303D970")]
		[CompilerGenerated]
		private void LLJKBIFLEKB(OHFJHEDBJHF MMBOEGCIFOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x303D240", Offset = "0x303C040", VA = "0x18303D240")]
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
			[Cpp2IlInjected.Address(RVA = "0x32B4300", Offset = "0x32B3100", VA = "0x1832B4300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private bool NMBOFDCLNAN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x32B44C0", Offset = "0x32B32C0", VA = "0x1832B44C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool LGHDIOGIOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x32B4300", Offset = "0x32B3100", VA = "0x1832B4300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool OIAKCIAOGFF
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x32B4300", Offset = "0x32B3100", VA = "0x1832B4300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x32B37F0", Offset = "0x32B25F0", VA = "0x1832B37F0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x32B3A30", Offset = "0x32B2830", VA = "0x1832B3A30", Slot = "14")]
		public void DBHLANONDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x32B3B50", Offset = "0x32B2950", VA = "0x1832B3B50", Slot = "15")]
		public void DJKIGJJOPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x32B3960", Offset = "0x32B2760", VA = "0x1832B3960", Slot = "5")]
		public void CBPENPLMJAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x32B3C70", Offset = "0x32B2A70", VA = "0x1832B3C70", Slot = "6")]
		public void EOIOBJHFAIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x32B46E0", Offset = "0x32B34E0", VA = "0x1832B46E0", Slot = "7")]
		public void PDGIPGAJNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x32B4560", Offset = "0x32B3360", VA = "0x1832B4560", Slot = "8")]
		public void OMFEJEGFEHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x32B4860", Offset = "0x32B3660", VA = "0x1832B4860", Slot = "9")]
		public void POONBEDCDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x32B3EC0", Offset = "0x32B2CC0", VA = "0x1832B3EC0", Slot = "10")]
		public void GLHKIDNPJDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x32B3DF0", Offset = "0x32B2BF0", VA = "0x1832B3DF0", Slot = "11")]
		public void FPCDOODFELG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "13")]
		public void NDHHBMAIDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x32B4370", Offset = "0x32B3170", VA = "0x1832B4370", Slot = "12")]
		public void IHEMIJFEAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public DKCCOABIFKH NBPAAHMKIPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x301DF30", Offset = "0x301CD30", VA = "0x18301DF30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x32C2A60", Offset = "0x32C1860", VA = "0x1832C2A60", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool AACDAEOPAIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x726EF0", Offset = "0x725CF0", VA = "0x180726EF0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x32C2930", Offset = "0x32C1730", VA = "0x1832C2930", Slot = "10")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x32C2820", Offset = "0x32C1620", VA = "0x1832C2820")]
		private void GLBIKEOEKPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x32C25F0", Offset = "0x32C13F0", VA = "0x1832C25F0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x32C2A40", Offset = "0x32C1840", VA = "0x1832C2A40", Slot = "8")]
		public ComponentSystemBase LMHMNNPCBNI(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6CF580", Offset = "0x6CE380", VA = "0x1806CF580", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F268E0", Offset = "0x3F256E0", VA = "0x183F268E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x6CF620", Offset = "0x6CE420", VA = "0x1806CF620")]
		[DebuggerHidden]
		public GEMBMJPKHNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x3F265D0", Offset = "0x3F253D0", VA = "0x183F265D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x3F268A0", Offset = "0x3F256A0", VA = "0x183F268A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x3F26800", Offset = "0x3F25600", VA = "0x183F26800", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x3F26800", Offset = "0x3F25600", VA = "0x183F26800", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x305D1B0", Offset = "0x305BFB0", VA = "0x18305D1B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<HLPDKNGJOIH> NFCDLNOFPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x305C710", Offset = "0x305B510", VA = "0x18305C710", Slot = "8")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x305D570", Offset = "0x305C370", VA = "0x18305D570", Slot = "9")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x305CAC0", Offset = "0x305B8C0", VA = "0x18305CAC0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x305D4E0", Offset = "0x305C2E0", VA = "0x18305D4E0", Slot = "6")]
	public bool NMPFLBADLAK(HLPDKNGJOIH GCEENFOFNFL, out OFBDBNCAANB MKEBBFCGOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x305CB50", Offset = "0x305B950", VA = "0x18305CB50")]
	private void EBLCIJFDNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x305D340", Offset = "0x305C140", VA = "0x18305D340")]
	private void KLKEDCGOOML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x305D590", Offset = "0x305C390", VA = "0x18305D590")]
	private IMCOEDLDCBA PMCBLGEIALO(string HLDDMFJGIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x305D1B0", Offset = "0x305BFB0", VA = "0x18305D1B0")]
	private IMCOEDLDCBA HPHNDCDMEHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x305C800", Offset = "0x305B600", VA = "0x18305C800")]
	private IMCOEDLDCBA DJBFBMPINPP(string HLDDMFJGIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x305CEE0", Offset = "0x305BCE0", VA = "0x18305CEE0")]
	private IMCOEDLDCBA GIGEAGBMKFE(string GEMBNOGNCGO, string JJFHDFJGCDG, [Optional] IMCOEDLDCBA DFPHOBNBGMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x305D0B0", Offset = "0x305BEB0", VA = "0x18305D0B0")]
	[IteratorStateMachine(typeof(GEMBMJPKHNN))]
	private IEnumerable<(string, string)> HMLIBAJJOAH(string HLDDMFJGIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x305D2F0", Offset = "0x305C0F0", VA = "0x18305D2F0")]
	private bool JKKLPGGEHNH(HLPDKNGJOIH GCEENFOFNFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x305D210", Offset = "0x305C010", VA = "0x18305D210")]
	private CMNFDIIGBFP IGCNNMAFJAM(HLPDKNGJOIH GCEENFOFNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x305CA70", Offset = "0x305B870", VA = "0x18305CA70")]
	private CMNFDIIGBFP DPMALEFNPNG(HLPDKNGJOIH GCEENFOFNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x305D120", Offset = "0x305BF20", VA = "0x18305D120")]
	private CMNFDIIGBFP HOFPEFFBCNG(HLPDKNGJOIH GCEENFOFNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B3D880", Offset = "0x2B3C680", VA = "0x182B3D880")]
	private T PGBIBMODGLC<T>(HLPDKNGJOIH GCEENFOFNFL) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x305C630", Offset = "0x305B430", VA = "0x18305C630")]
	private FieldInfo ABJENNJOPIH(HLPDKNGJOIH GCEENFOFNFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x305D5F0", Offset = "0x305C3F0", VA = "0x18305D5F0")]
	public MOOBIPDFDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x305C770", Offset = "0x305B570", VA = "0x18305C770")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public OFBDBNCAANB MPNHLJEMILM
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<OFBDBNCAANB> JEOGLOBMCMD
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IEnumerable<HLPDKNGJOIH> MDNKEJMDPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x304E9F0", Offset = "0x304D7F0", VA = "0x18304E9F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F28D50", Offset = "0x3F27B50", VA = "0x183F28D50")]
			public KFFOFJJFLEE(HistoryService EBNNPKINFJN, bool DLNKDNMKAJE, uint OPAPEIICLLC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x3F28D20", Offset = "0x3F27B20", VA = "0x183F28D20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F24F60", Offset = "0x3F23D60", VA = "0x183F24F60")]
				public FCGLEGLCPEM(FMJEOFKLAPC DEKNKGENFOI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x3F24EF0", Offset = "0x3F23CF0", VA = "0x183F24EF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F24F20", Offset = "0x3F23D20", VA = "0x183F24F20")]
				public FBDAELGFFGI(FMJEOFKLAPC DEKNKGENFOI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0x3F24EF0", Offset = "0x3F23CF0", VA = "0x183F24EF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F25E10", Offset = "0x3F24C10", VA = "0x183F25E10")]
			public FMJEOFKLAPC(HistoryService LAGIBNJDAAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x3F25D90", Offset = "0x3F24B90", VA = "0x183F25D90")]
			public bool IEMGPGNIPJG(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x3F25DC0", Offset = "0x3F24BC0", VA = "0x183F25DC0")]
			public FBDAELGFFGI NMDBBOJHPIN()
			{
				return default(FBDAELGFFGI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x3F25D40", Offset = "0x3F24B40", VA = "0x183F25D40")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public MFLOHCHFKML()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x3F2AAC0", Offset = "0x3F298C0", VA = "0x183F2AAC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public KLPDAMDBGOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x3F29180", Offset = "0x3F27F80", VA = "0x183F29180")]
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
			[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
			public ECIAODHFCOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x3F248D0", Offset = "0x3F236D0", VA = "0x183F248D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6EBEE0", Offset = "0x6EACE0", VA = "0x1806EBEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool PEEOHENOGEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x304BEF0", Offset = "0x304ACF0", VA = "0x18304BEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool GDKJPIBBFCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x304AFC0", Offset = "0x3049DC0", VA = "0x18304AFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool MDLKKDDINNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x304BEC0", Offset = "0x304ACC0", VA = "0x18304BEC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int ONCGLDJOEAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x304C1F0", Offset = "0x304AFF0", VA = "0x18304C1F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int ENHOLPOOILM
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x304C1D0", Offset = "0x304AFD0", VA = "0x18304C1D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool DAOCBLNCILA
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x304B460", Offset = "0x304A260", VA = "0x18304B460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private bool GOCNJIBGJGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x304BC80", Offset = "0x304AA80", VA = "0x18304BC80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool AFLNKEFMNKI
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xB00CB0", Offset = "0xAFFAB0", VA = "0x180B00CB0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xB00CE0", Offset = "0xAFFAE0", VA = "0x180B00CE0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private ActionBuffer FBNJDMNMKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x304C6D0", Offset = "0x304B4D0", VA = "0x18304C6D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action JFIGJHFDONI
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x304BCB0", Offset = "0x304AAB0", VA = "0x18304BCB0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x304C550", Offset = "0x304B350", VA = "0x18304C550", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action PAOGCFIAPCE
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x304C7B0", Offset = "0x304B5B0", VA = "0x18304C7B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x304B700", Offset = "0x304A500", VA = "0x18304B700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x304AB10", Offset = "0x3049910", VA = "0x18304AB10", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x304B800", Offset = "0x304A600", VA = "0x18304B800", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x304B060", Offset = "0x3049E60", VA = "0x18304B060")]
		private void ALDGCEFMENE(ELJHNEOGEBP IBGBBCHPJJF, CBDNIJIKHKI OHLAHMOJLKO, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x304CC70", Offset = "0x304BA70", VA = "0x18304CC70")]
		private void PNAEOCCBJHE(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG DMFCDDGFOMD, EKBGHCIKEGG IOOLGMDKBMN, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x304C370", Offset = "0x304B170", VA = "0x18304C370")]
		private void LFLPHHCBKLB(ELJHNEOGEBP IBGBBCHPJJF, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x304C170", Offset = "0x304AF70", VA = "0x18304C170", Slot = "14")]
		public IDisposable JAIMDJLNPAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x304B7A0", Offset = "0x304A5A0", VA = "0x18304B7A0", Slot = "9")]
		public IDisposable DEFPONBPPFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x304C290", Offset = "0x304B090", VA = "0x18304C290", Slot = "6")]
		public UndoAction KJCOELNOOIF()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x304B280", Offset = "0x304A080", VA = "0x18304B280", Slot = "15")]
		public RedoAction BGHACECAOIO()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x304BBC0", Offset = "0x304A9C0", VA = "0x18304BBC0", Slot = "16")]
		public UndoAction EKKIOLMIBCP()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x304B340", Offset = "0x304A140", VA = "0x18304B340", Slot = "7")]
		public RedoAction BGHACECAOIO(UndoAction EHPFANFOFFJ)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x304BAA0", Offset = "0x304A8A0", VA = "0x18304BAA0", Slot = "8")]
		public UndoAction EKKIOLMIBCP(RedoAction EHPFANFOFFJ)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x304C060", Offset = "0x304AE60", VA = "0x18304C060")]
		public bool HOIBCDGIDGC(HAKMMILMCEL OHAFKLLCGOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x304BF50", Offset = "0x304AD50", VA = "0x18304BF50", Slot = "17")]
		public void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x304BFA0", Offset = "0x304ADA0", VA = "0x18304BFA0")]
		public void HCPNNJMCDBO(ELJHNEOGEBP IBGBBCHPJJF, CBDNIJIKHKI OHLAHMOJLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x304C5F0", Offset = "0x304B3F0", VA = "0x18304C5F0")]
		public void MCLJDJGOIAO(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK, in EKBGHCIKEGG IOOLGMDKBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x304C700", Offset = "0x304B500", VA = "0x18304C700")]
		public void PAHKHPEICKF(ELJHNEOGEBP IBGBBCHPJJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x304CB10", Offset = "0x304B910", VA = "0x18304CB10")]
		private void PHDFNOOPFPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x304C0A0", Offset = "0x304AEA0", VA = "0x18304C0A0")]
		private void IBOCJEEMFII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x304C350", Offset = "0x304B150", VA = "0x18304C350")]
		private void LBHEDBIBNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x304CB70", Offset = "0x304B970", VA = "0x18304CB70")]
		private GMPPFOMGOIP PKALDDHBCIH()
		{
			return default(GMPPFOMGOIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x304BC90", Offset = "0x304AA90", VA = "0x18304BC90")]
		private uint FAHOCELMKDO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x304CB50", Offset = "0x304B950", VA = "0x18304CB50")]
		private bool PIMNEGCKMML(out GMPPFOMGOIP KDJGJCHCIKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x304C6E0", Offset = "0x304B4E0", VA = "0x18304C6E0")]
		private bool MJFMADEEBEB(out GMPPFOMGOIP KDJGJCHCIKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x304B470", Offset = "0x304A270", VA = "0x18304B470")]
		private RedoAction CBLLLACCKBP(GMPPFOMGOIP KDJGJCHCIKK)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x304C0E0", Offset = "0x304AEE0", VA = "0x18304C0E0")]
		private UndoAction IFIBIKKHNKO(GMPPFOMGOIP KDJGJCHCIKK)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x304C850", Offset = "0x304B650", VA = "0x18304C850")]
		private GMPPFOMGOIP PEHACFGONOI(GMPPFOMGOIP KDJGJCHCIKK, ActionBuffer KFGOCJLPDGC, bool DLNKDNMKAJE)
		{
			return default(GMPPFOMGOIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x304B4D0", Offset = "0x304A2D0", VA = "0x18304B4D0")]
		private void CHACGNDHHIC(Action KDJGJCHCIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2D9F670", Offset = "0x2D9E470", VA = "0x182D9F670")]
		private T CHACGNDHHIC<T>(Func<T> PMMFFGGLOBI)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x304C140", Offset = "0x304AF40", VA = "0x18304C140")]
		private KFFOFJJFLEE IMJBMMMFDKA(bool DLNKDNMKAJE, uint OPAPEIICLLC)
		{
			return default(KFFOFJJFLEE);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x304CD70", Offset = "0x304BB70", VA = "0x18304CD70")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x304B5B0", Offset = "0x304A3B0", VA = "0x18304B5B0")]
		[CompilerGenerated]
		private UndoAction CIOOHOBLJFP()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x304BD50", Offset = "0x304AB50", VA = "0x18304BD50")]
		[CompilerGenerated]
		private RedoAction GEHDEMDKIII()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x304B120", Offset = "0x3049F20", VA = "0x18304B120")]
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
		[Cpp2IlInjected.Address(RVA = "0x671970", Offset = "0x670770", VA = "0x180671970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x122AF60", Offset = "0x1229D60", VA = "0x18122AF60")]
	public CAJBEFJMLEI(NativeArray<byte> EJLDCNGHIAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x340DDA0", Offset = "0x340CBA0", VA = "0x18340DDA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x671970", Offset = "0x670770", VA = "0x180671970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x122AF60", Offset = "0x1229D60", VA = "0x18122AF60")]
	public NHJNOGJCPIM(NativeArray<byte> EJLDCNGHIAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x301BAB0", Offset = "0x301A8B0", VA = "0x18301BAB0")]
	public static NHJNOGJCPIM KPOCFOKDNEC(NativeArray<byte> EJLDCNGHIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x3247860", Offset = "0x3246660", VA = "0x183247860")]
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
		[Cpp2IlInjected.Address(RVA = "0x671970", Offset = "0x670770", VA = "0x180671970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x122AF60", Offset = "0x1229D60", VA = "0x18122AF60")]
	public KCNPIEBFGML(NativeArray<byte> EJLDCNGHIAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x3052090", Offset = "0x3050E90", VA = "0x183052090")]
	public static KCNPIEBFGML KPOCFOKDNEC(NativeArray<byte> EJLDCNGHIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x2907260", Offset = "0x2906060", VA = "0x182907260")]
	public void NBEDHNHDFEM<T>(in T GKFICKKHACC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2907160", Offset = "0x2905F60", VA = "0x182907160")]
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
	[Cpp2IlInjected.Address(RVA = "0x3042FF0", Offset = "0x3041DF0", VA = "0x183042FF0")]
	public static Span<byte> CDCKNJICGJB(this NativeArray<byte> EJLDCNGHIAK)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x3043100", Offset = "0x3041F00", VA = "0x183043100")]
	public static ReadOnlySpan<byte> GAGEIOCHFNI(this NativeArray<byte> EJLDCNGHIAK)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x3043080", Offset = "0x3041E80", VA = "0x183043080")]
	public static NativeArray<byte> DECEBLBFJFK(this NativeArray<byte> EJLDCNGHIAK, int HOKMFDPKLJA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x3042F70", Offset = "0x3041D70", VA = "0x183042F70")]
	public static NativeArray<byte> BGHBOAFAPBJ(this NativeArray<byte> EJLDCNGHIAK, int CGKKILDEEIJ = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x337BC30", Offset = "0x337AA30", VA = "0x18337BC30")]
	public static NativeArray<byte> BGHBOAFAPBJ<T>(this NativeArray<byte> EJLDCNGHIAK, int CGKKILDEEIJ = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x3043300", Offset = "0x3042100", VA = "0x183043300")]
	public static NativeArray<byte> OCKBPNAOEEN(this NativeArray<byte> EJLDCNGHIAK, int CGKKILDEEIJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x337D1D0", Offset = "0x337BFD0", VA = "0x18337D1D0")]
	public static NativeArray<byte> OCKBPNAOEEN<T>(this NativeArray<byte> EJLDCNGHIAK, int CGKKILDEEIJ = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x3043280", Offset = "0x3042080", VA = "0x183043280")]
	public static NativeArray<byte> HJGEADCGNLA(this NativeArray<byte> EJLDCNGHIAK, int CGKKILDEEIJ = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x337BC90", Offset = "0x337AA90", VA = "0x18337BC90")]
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
	[Cpp2IlInjected.Address(RVA = "0x122AF60", Offset = "0x1229D60", VA = "0x18122AF60")]
	public CKJPIMKKBID(NativeList<byte> LENGKEKMOEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x340EF10", Offset = "0x340DD10", VA = "0x18340EF10")]
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
			[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x3037A60", Offset = "0x3036860", VA = "0x183037A60")]
		public PHDLJHDBIMF.CKFMEAKFNDD LDPILBHHNFH()
		{
			return default(PHDLJHDBIMF.CKFMEAKFNDD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x3037940", Offset = "0x3036740", VA = "0x183037940", Slot = "4")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x3036F90", Offset = "0x3035D90", VA = "0x183036F90", Slot = "5")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x30373F0", Offset = "0x30361F0", VA = "0x1830373F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x3037830", Offset = "0x3036630", VA = "0x183037830")]
		public void KJCOELNOOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x3037710", Offset = "0x3036510", VA = "0x183037710")]
		public void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x3037E90", Offset = "0x3036C90", VA = "0x183037E90")]
		private void PJBNACMEFEB(ELJHNEOGEBP IBGBBCHPJJF, CBDNIJIKHKI OHLAHMOJLKO, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x3037340", Offset = "0x3036140", VA = "0x183037340")]
		private void DCOAGIKHEDK(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG DMFCDDGFOMD, EKBGHCIKEGG IOOLGMDKBMN, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x3037610", Offset = "0x3036410", VA = "0x183037610")]
		private void GCPOMLMKHIM(ELJHNEOGEBP IBGBBCHPJJF, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x3037AA0", Offset = "0x30368A0", VA = "0x183037AA0")]
		private void LFAEFFCBACC(ADMBCAGJIHO GPNGGDGNOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x3037210", Offset = "0x3036010", VA = "0x183037210")]
		private void CDHMBGEDEOB(ADMBCAGJIHO GPNGGDGNOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x3037DD0", Offset = "0x3036BD0", VA = "0x183037DD0")]
		private void NDMCPKJMKFH(ADMBCAGJIHO GPNGGDGNOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x3037FA0", Offset = "0x3036DA0", VA = "0x183037FA0")]
		private void PMGJFJIAKLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x3037920", Offset = "0x3036720", VA = "0x183037920")]
		private void KKJEAOGKMBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x3037740", Offset = "0x3036540", VA = "0x183037740")]
		private void GOLFMCKEIHJ(ADMBCAGJIHO GPNGGDGNOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x42566A0", Offset = "0x42554A0", VA = "0x1842566A0", Slot = "6")]
		private void ENPPCJGNHNJ<TKey, T>(global::JKHOGOMAANC<TKey, T> GCEENFOFNFL, object EDPENIGJGLF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3038010", Offset = "0x3036E10", VA = "0x183038010")]
		public void HCPNNJMCDBO(ELJHNEOGEBP IBGBBCHPJJF, CBDNIJIKHKI OHLAHMOJLKO, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x3038030", Offset = "0x3036E30", VA = "0x183038030")]
		public void MCLJDJGOIAO(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK, in EKBGHCIKEGG DMFCDDGFOMD, in EKBGHCIKEGG IOOLGMDKBMN, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x30380A0", Offset = "0x3036EA0", VA = "0x1830380A0")]
		public void PAHKHPEICKF(ELJHNEOGEBP IBGBBCHPJJF, bool IHPCEBHCPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x32A8F20", Offset = "0x32A7D20", VA = "0x1832A8F20")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public HHMAMHCDFMN[] CHKMBJBNJJC
			{
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x32A8E50", Offset = "0x32A7C50", VA = "0x1832A8E50")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
			public KOCPJBKALIG(ActionBuffer GLIPLLPKFJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x32A8F70", Offset = "0x32A7D70", VA = "0x1832A8F70")]
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
				[Cpp2IlInjected.Address(RVA = "0x32A8530", Offset = "0x32A7330", VA = "0x1832A8530")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public List<(ADMBCAGJIHO, string, object)> MHHJFFJLHLO
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x32A8680", Offset = "0x32A7480", VA = "0x1832A8680")]
			public HHMAMHCDFMN(ActionBuffer GLIPLLPKFJK, GMPPFOMGOIP KDJGJCHCIKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x32A8580", Offset = "0x32A7380", VA = "0x1832A8580")]
			private string GPLOGLOILPE(ADMBCAGJIHO EEKKNDHOHCG)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x32A81F0", Offset = "0x32A6FF0", VA = "0x1832A81F0")]
			private void BLNLPEOGOOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x30D79B0", Offset = "0x30D67B0", VA = "0x1830D79B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3406A40", Offset = "0x3405840", VA = "0x183406A40")]
			get
			{
				return default(IPDEBOIIBOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public int EONFJIOMKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x34063F0", Offset = "0x34051F0", VA = "0x1834063F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x3406EC0", Offset = "0x3405CC0", VA = "0x183406EC0")]
		public ActionBuffer(NHMIEEEHOBN LPFIHLDFGAL, IPCBIFCIILJ HFDCOKODHFK, bool PELFIBLKAOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x34061F0", Offset = "0x3404FF0", VA = "0x1834061F0")]
		public bool BJHLOEENGCE(out GMPPFOMGOIP KDJGJCHCIKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x34067E0", Offset = "0x34055E0", VA = "0x1834067E0")]
		public void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x3406A80", Offset = "0x3405880", VA = "0x183406A80")]
		public GMPPFOMGOIP KJCOELNOOIF(NEONIHENGJC NEDADCIFNEM, LAIOJMOLDGG FGKPEHNKLAL, uint GCEMIFHHBAO)
		{
			return default(GMPPFOMGOIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x34061C0", Offset = "0x3404FC0", VA = "0x1834061C0")]
		public bool BCNHDOOHOFP(uint GCEMIFHHBAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x3406850", Offset = "0x3405650", VA = "0x183406850")]
		public bool IDPLGGGLFHL(uint GCEMIFHHBAO, out GMPPFOMGOIP EHPFANFOFFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x3406280", Offset = "0x3405080", VA = "0x183406280")]
		public void CPPAHIOHGAN(GMPPFOMGOIP EHPFANFOFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x3406BC0", Offset = "0x34059C0", VA = "0x183406BC0")]
		[Conditional("DEBUG_BUILD")]
		private void LHCFNPALCEB(GMPPFOMGOIP EHPFANFOFFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x3406D60", Offset = "0x3405B60", VA = "0x183406D60")]
		private void PEHACFGONOI(GMPPFOMGOIP DAPBEPPIHJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x3406560", Offset = "0x3405360", VA = "0x183406560")]
		private void FAHLJOPKDOC(NHJNOGJCPIM JPBCOPIKIPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3406D00", Offset = "0x3405B00", VA = "0x183406D00")]
		private void OOILCPNCJFM(GMPPFOMGOIP KDJGJCHCIKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x3406430", Offset = "0x3405230", VA = "0x183406430")]
		private NHJNOGJCPIM DPBIGJKEHJB(GMPPFOMGOIP KDJGJCHCIKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x34064F0", Offset = "0x34052F0", VA = "0x1834064F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EE4A0", Offset = "0x6ED2A0", VA = "0x1806EE4A0")]
	public GDDDJDJEMIB(NHMIEEEHOBN LPFIHLDFGAL, IPCBIFCIILJ HFDCOKODHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x3381650", Offset = "0x3380450", VA = "0x183381650", Slot = "4")]
	public void HKFMGALIEPK<TKey, T>(global::JKHOGOMAANC<TKey, T> FMAGINAIDLO, [Optional] object EDPENIGJGLF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x3043370", Offset = "0x3042170", VA = "0x183043370")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F22170", Offset = "0x3F20F70", VA = "0x183F22170")]
		public CKFMEAKFNDD(PHDLJHDBIMF GEOFAMNLJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x3F22150", Offset = "0x3F20F50", VA = "0x183F22150", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x302EC70", Offset = "0x302DA70", VA = "0x18302EC70")]
		get
		{
			return default(NEONIHENGJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool KKEPKLMKHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x302EB60", Offset = "0x302D960", VA = "0x18302EB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x302EF50", Offset = "0x302DD50", VA = "0x18302EF50")]
	public PHDLJHDBIMF(NEONIHENGJC.HMFDILLHEGL DPADBFKBHKN = NEONIHENGJC.HMFDILLHEGL.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x302EA60", Offset = "0x302D860", VA = "0x18302EA60")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x302EA70", Offset = "0x302D870", VA = "0x18302EA70")]
	public void HCPNNJMCDBO(ELJHNEOGEBP IBGBBCHPJJF, CBDNIJIKHKI OHLAHMOJLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x302ECE0", Offset = "0x302DAE0", VA = "0x18302ECE0")]
	public void MCLJDJGOIAO(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x302ED70", Offset = "0x302DB70", VA = "0x18302ED70")]
	public void PAHKHPEICKF(ELJHNEOGEBP IBGBBCHPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x302EE50", Offset = "0x302DC50", VA = "0x18302EE50")]
	public void PMGJFJIAKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x302EB70", Offset = "0x302D970", VA = "0x18302EB70")]
	public void KKJEAOGKMBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x302EA50", Offset = "0x302D850", VA = "0x18302EA50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x302ECB0", Offset = "0x302DAB0", VA = "0x18302ECB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2597700", Offset = "0x2596500", VA = "0x182597700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6BD570", Offset = "0x6BC370", VA = "0x1806BD570")]
	public ADMBCAGJIHO(ELJHNEOGEBP IBGBBCHPJJF, EBLKGKAPHAO KBPOLLDMHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x3404AA0", Offset = "0x34038A0", VA = "0x183404AA0")]
	public void LBHIDKOONBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x34048F0", Offset = "0x34036F0", VA = "0x1834048F0", Slot = "4")]
	public int CompareTo(ADMBCAGJIHO MCLIMJFDMCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x3404B00", Offset = "0x3403900", VA = "0x183404B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x3404980", Offset = "0x3403780", VA = "0x183404980", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x3404930", Offset = "0x3403730", VA = "0x183404930", Slot = "5")]
	public bool Equals(ADMBCAGJIHO MCLIMJFDMCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x3404A60", Offset = "0x3403860", VA = "0x183404A60")]
	public static bool IKJLJMIELNH(ADMBCAGJIHO MGIINGKDNDK, ADMBCAGJIHO GNLBKLBDKBA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x3404AB0", Offset = "0x34038B0", VA = "0x183404AB0")]
	public static bool NKIHKFGIBBG(ADMBCAGJIHO MGIINGKDNDK, ADMBCAGJIHO GNLBKLBDKBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x3404A20", Offset = "0x3403820", VA = "0x183404A20", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x3045F70", Offset = "0x3044D70", VA = "0x183045F70")]
		public void LIBBDBBCEBA(ELJHNEOGEBP IBGBBCHPJJF, NHMIEEEHOBN LPFIHLDFGAL, HistoryService LAGIBNJDAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x3046080", Offset = "0x3044E80", VA = "0x183046080", Slot = "4")]
		private void NCHDODBILKN(MLDLKMLLJME GCEENFOFNFL, in EKBGHCIKEGG GKFICKKHACC, object EDPENIGJGLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class DBBGCLIEIEG
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x341ABC0", Offset = "0x34199C0", VA = "0x18341ABC0")]
	public static void CDHMBGEDEOB(NEONIHENGJC NEDADCIFNEM, ADMBCAGJIHO EEKKNDHOHCG, CBDNIJIKHKI OHLAHMOJLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x341ACC0", Offset = "0x3419AC0", VA = "0x18341ACC0")]
	public static void FGKMFIGNKJA(NEONIHENGJC NEDADCIFNEM, ADMBCAGJIHO EEKKNDHOHCG, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x341AED0", Offset = "0x3419CD0", VA = "0x18341AED0")]
	public static void NDMCPKJMKFH(NEONIHENGJC NEDADCIFNEM, ADMBCAGJIHO EEKKNDHOHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x341AE20", Offset = "0x3419C20", VA = "0x18341AE20")]
	public static void JMNLKAJACCK(NEONIHENGJC NEDADCIFNEM, ADMBCAGJIHO EEKKNDHOHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x341ADD0", Offset = "0x3419BD0", VA = "0x18341ADD0")]
	public static CBDNIJIKHKI GILPGOPMANC(NEONIHENGJC NEDADCIFNEM, ADMBCAGJIHO EEKKNDHOHCG)
	{
		return default(CBDNIJIKHKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x273EF40", Offset = "0x273DD40", VA = "0x18273EF40")]
	public static T FGDKOHNHNHK<T>(NEONIHENGJC NEDADCIFNEM, ADMBCAGJIHO EEKKNDHOHCG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x273EF10", Offset = "0x273DD10", VA = "0x18273EF10")]
	public static T FGDKOHNHNHK<T>(ref NHJNOGJCPIM JLFCOOGLPMP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x341AD80", Offset = "0x3419B80", VA = "0x18341AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F259B0", Offset = "0x3F247B0", VA = "0x183F259B0")]
		public FFEDGPFKECM(NEONIHENGJC LENGKEKMOEB, LAIOJMOLDGG FGKPEHNKLAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F25560", Offset = "0x3F24360", VA = "0x183F25560")]
		public void PEGFMBDDJKL(NativeList<byte> HPPBGHGOBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x3F25800", Offset = "0x3F24600", VA = "0x183F25800")]
		private void PGEBFPENKDK(ADMBCAGJIHO EEKKNDHOHCG, ref KCNPIEBFGML PHMLAMDMIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x3F25190", Offset = "0x3F23F90", VA = "0x183F25190")]
		private void GEKKMLDILJP(ADMBCAGJIHO EEKKNDHOHCG, ref KCNPIEBFGML PHMLAMDMIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F250A0", Offset = "0x3F23EA0", VA = "0x183F250A0")]
		private NativeArray<byte> BOJCIOEFKGD(NativeList<byte> HPPBGHGOBLD)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F25220", Offset = "0x3F24020", VA = "0x183F25220")]
		private NativeArray<byte> HCNFLCIAALH(NativeList<byte> HPPBGHGOBLD, int PMIIGNOLFGJ)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F25310", Offset = "0x3F24110", VA = "0x183F25310")]
		private int MPJAODKOEAB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x3F25850", Offset = "0x3F24650", VA = "0x183F25850")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F2ADA0", Offset = "0x3F29BA0", VA = "0x183F2ADA0")]
		internal MPHGNCFIKKB(NEONIHENGJC LENGKEKMOEB, ADMBCAGJIHO GPNGGDGNOJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AB20", Offset = "0x3F29920", VA = "0x183F2AB20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F2ACE0", Offset = "0x3F29AE0", VA = "0x183F2ACE0")]
		public void NOGMKBCDOFK(NativeArray<byte> GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AB50", Offset = "0x3F29950", VA = "0x183F2AB50")]
		public void EICCOPFAGBF(NativeArray<byte> GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x3F2ABB0", Offset = "0x3F299B0", VA = "0x183F2ABB0")]
		public void GEKKMLDILJP(in EKBGHCIKEGG GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x2C98960", Offset = "0x2C97760", VA = "0x182C98960")]
		public void GEKKMLDILJP<T>(T GKFICKKHACC) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x3F2ABC0", Offset = "0x3F299C0", VA = "0x183F2ABC0")]
		private void LIDHBEOHKNN(int GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AC30", Offset = "0x3F29A30", VA = "0x183F2AC30")]
		private void LIDHBEOHKNN(in EKBGHCIKEGG GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AD40", Offset = "0x3F29B40", VA = "0x183F2AD40")]
		private unsafe void LIDHBEOHKNN(void* GCMOCENHMPH, int PMIIGNOLFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x3F2ACE0", Offset = "0x3F29AE0", VA = "0x183F2ACE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F2B560", Offset = "0x3F2A360", VA = "0x183F2B560")]
		internal NKAKNGEAMFF(NEONIHENGJC LENGKEKMOEB, NativeArray<byte> JLFCOOGLPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B490", Offset = "0x3F2A290", VA = "0x183F2B490", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B4A0", Offset = "0x3F2A2A0", VA = "0x183F2B4A0")]
		public NativeArray<byte> MBNKNEEMGIK(int PMIIGNOLFGJ)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B3A0", Offset = "0x3F2A1A0", VA = "0x183F2B3A0")]
		public NativeArray<byte> CJGMJIAAMBJ()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x2C99250", Offset = "0x2C98050", VA = "0x182C99250")]
		public T ADOBPOEJHEB<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B2A0", Offset = "0x3F2A0A0", VA = "0x183F2B2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F22100", Offset = "0x3F20F00", VA = "0x183F22100", Slot = "4")]
			get
			{
				return default(ADMBCAGJIHO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x3F220C0", Offset = "0x3F20EC0", VA = "0x183F220C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x336C190", Offset = "0x336AF90", VA = "0x18336C190")]
		internal CABCGINNHEG(NativeList<ADMBCAGJIHO> HOGBBBFDPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3F21F80", Offset = "0x3F20D80", VA = "0x183F21F80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3F22080", Offset = "0x3F20E80", VA = "0x183F22080", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F2B680", Offset = "0x3F2A480", VA = "0x183F2B680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public int PGDECNFGLPA
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x3F2B780", Offset = "0x3F2A580", VA = "0x183F2B780")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x3F2B660", Offset = "0x3F2A460", VA = "0x183F2B660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public HMFDILLHEGL BDGMIAEAAFO
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x3F2B670", Offset = "0x3F2A470", VA = "0x183F2B670")]
			get
			{
				return default(HMFDILLHEGL);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x3F2B770", Offset = "0x3F2A570", VA = "0x183F2B770")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool KKEPKLMKHMH
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x3F2B760", Offset = "0x3F2A560", VA = "0x183F2B760")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x3F2B7D0", Offset = "0x3F2A5D0", VA = "0x183F2B7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool EIFBGDJBBHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x3F2B730", Offset = "0x3F2A530", VA = "0x183F2B730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x3F2B740", Offset = "0x3F2A540", VA = "0x183F2B740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B7F0", Offset = "0x3F2A5F0", VA = "0x183F2B7F0")]
		public OGJBCNCGCIG(HMFDILLHEGL DPADBFKBHKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B700", Offset = "0x3F2A500", VA = "0x183F2B700")]
		private int HMFHOBMDMGG(int HPNBOGMLOLG, int DOFCPLMBMDE = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B790", Offset = "0x3F2A590", VA = "0x183F2B790")]
		private void NMFBOCJEJOB(int HPNBOGMLOLG, int GKFICKKHACC, int DOFCPLMBMDE = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B6C0", Offset = "0x3F2A4C0", VA = "0x183F2B6C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x301B170", Offset = "0x3019F70", VA = "0x18301B170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool MLCHHGLGNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x301AA00", Offset = "0x3019800", VA = "0x18301AA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int PGDECNFGLPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x301B4F0", Offset = "0x301A2F0", VA = "0x18301B4F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int EAMBHFJBPML
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x301AE00", Offset = "0x3019C00", VA = "0x18301AE00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool MOCJDAMLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x301AA20", Offset = "0x3019820", VA = "0x18301AA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x301AF20", Offset = "0x3019D20", VA = "0x18301AF20")]
	public static NEONIHENGJC GLBIKEOEKPG(HMFDILLHEGL DPADBFKBHKN = HMFDILLHEGL.Last, int FBJGICBLDOC = 16, int EIOILGMGLBD = 256)
	{
		return default(NEONIHENGJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x301B6F0", Offset = "0x301A4F0", VA = "0x18301B6F0")]
	private NEONIHENGJC(HMFDILLHEGL DPADBFKBHKN, int FBJGICBLDOC, int EIOILGMGLBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x301AAF0", Offset = "0x30198F0", VA = "0x18301AAF0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x301B270", Offset = "0x301A070", VA = "0x18301B270")]
	public MPHGNCFIKKB LFAEFFCBACC(ADMBCAGJIHO GPNGGDGNOJH)
	{
		return default(MPHGNCFIKKB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x301AA60", Offset = "0x3019860", VA = "0x18301AA60")]
	public NKAKNGEAMFF DFLHBEMGOIJ(ADMBCAGJIHO GPNGGDGNOJH)
	{
		return default(NKAKNGEAMFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x301AC10", Offset = "0x3019A10", VA = "0x18301AC10")]
	public bool ENHEOKPGMAE(ADMBCAGJIHO GPNGGDGNOJH, out NKAKNGEAMFF OBKGOOLKCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x301B050", Offset = "0x3019E50", VA = "0x18301B050")]
	public bool JHMCGHJCCDK(ADMBCAGJIHO GPNGGDGNOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x301B0A0", Offset = "0x3019EA0", VA = "0x18301B0A0")]
	public bool JJKGIMKEAKC(ADMBCAGJIHO GPNGGDGNOJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x301AF60", Offset = "0x3019D60", VA = "0x18301AF60")]
	public void HNKJNMKKLJF(NativeList<byte> HPPBGHGOBLD, LAIOJMOLDGG FGKPEHNKLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x3C12C60", Offset = "0x3C11A60", VA = "0x183C12C60")]
	public T DKHIEHMEGIE<T>(ADMBCAGJIHO GPNGGDGNOJH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x301AE40", Offset = "0x3019C40", VA = "0x18301AE40")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x301ABD0", Offset = "0x30199D0", VA = "0x18301ABD0")]
	public CABCGINNHEG EMHOENNLHOC()
	{
		return default(CABCGINNHEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x301B300", Offset = "0x301A100", VA = "0x18301B300")]
	private void LJKCFJJJJOC(ADMBCAGJIHO GPNGGDGNOJH, int HOKMFDPKLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x301B180", Offset = "0x3019F80", VA = "0x18301B180")]
	private void LBHIDKOONBO(int NAKPIAAEFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x301B500", Offset = "0x301A300", VA = "0x18301B500")]
	private void NOJFGHEBHLN(ADMBCAGJIHO GPNGGDGNOJH, int HOKMFDPKLJA, int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x3C12BE0", Offset = "0x3C119E0", VA = "0x183C12BE0")]
	private static T DKHIEHMEGIE<T>(NativeArray<byte> EJLDCNGHIAK, int HPNBOGMLOLG = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x301B630", Offset = "0x301A430", VA = "0x18301B630", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x301B5F0", Offset = "0x301A3F0", VA = "0x18301B5F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2BDCD40", Offset = "0x2BDBB40", VA = "0x182BDCD40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2BDCE60", Offset = "0x2BDBC60", VA = "0x182BDCE60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2BDCED0", Offset = "0x2BDBCD0", VA = "0x182BDCED0")]
	public NHDCALDGKDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2BDCD20", Offset = "0x2BDBB20", VA = "0x182BDCD20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x34114D0", Offset = "0x34102D0", VA = "0x1834114D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x3411570", Offset = "0x3410370", VA = "0x183411570", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3407BB0", Offset = "0x34069B0", VA = "0x183407BB0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x3407C00", Offset = "0x3406A00", VA = "0x183407C00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x3407C90", Offset = "0x3406A90", VA = "0x183407C90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public BAOEMFEFIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x30461A0", Offset = "0x3044FA0", VA = "0x1830461A0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x30461F0", Offset = "0x3044FF0", VA = "0x1830461F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public HAMFOEEFEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x341E320", Offset = "0x341D120", VA = "0x18341E320", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x341E370", Offset = "0x341D170", VA = "0x18341E370", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x341E400", Offset = "0x341D200", VA = "0x18341E400", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x341A450", Offset = "0x3419250", VA = "0x18341A450", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x341AA80", Offset = "0x3419880", VA = "0x18341AA80")]
		public void PEOFOOEADCA(global::BNGAOKMFDEK<HPLOFGACNGG> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x341A610", Offset = "0x3419410", VA = "0x18341A610")]
		public void IIGPMKNGHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x341A4A0", Offset = "0x34192A0", VA = "0x18341A4A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x341AB40", Offset = "0x3419940", VA = "0x18341AB40")]
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
			[Cpp2IlInjected.Address(RVA = "0x30347C0", Offset = "0x30335C0", VA = "0x1830347C0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x30349D0", Offset = "0x30337D0", VA = "0x1830349D0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x30343C0", Offset = "0x30331C0", VA = "0x1830343C0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x3034860", Offset = "0x3033660", VA = "0x183034860", Slot = "5")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x30344E0", Offset = "0x30332E0", VA = "0x1830344E0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x30346F0", Offset = "0x30334F0", VA = "0x1830346F0", Slot = "8")]
		public bool MHGEGFEMDEL(IOBECAADPPL DKHOCCDNDOH, out Collider KIHMMOLIPKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x3034630", Offset = "0x3033430", VA = "0x183034630")]
		private void LABPFJEEIPH(Entity LLEBIIAHFDD, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG KNAEAKFNOOB, EKBGHCIKEGG OCBHJKLFMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x3034570", Offset = "0x3033370", VA = "0x183034570", Slot = "9")]
		public void HFFOMMPOGAK(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x303CEC0", Offset = "0x303BCC0", VA = "0x18303CEC0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x3039EE0", Offset = "0x3038CE0", VA = "0x183039EE0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x303C580", Offset = "0x303B380", VA = "0x18303C580", Slot = "6")]
		public JJBGGEMNFLN LHGHMGCKJGM(IOBECAADPPL DKHOCCDNDOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x303A7F0", Offset = "0x30395F0", VA = "0x18303A7F0", Slot = "5")]
		public void DGEJPBLIOMP(IOBECAADPPL DKHOCCDNDOH, JJBGGEMNFLN GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x303AA20", Offset = "0x3039820", VA = "0x18303AA20", Slot = "34")]
		public CollisionDetectionMode EDGBNOCJKIM(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x303B6A0", Offset = "0x303A4A0", VA = "0x18303B6A0", Slot = "35")]
		public void HPACHJBCJMB(IOBECAADPPL DKHOCCDNDOH, CollisionDetectionMode GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x303BFC0", Offset = "0x303ADC0", VA = "0x18303BFC0", Slot = "36")]
		public NIKBOPNLEII JKGIJKCIABC(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(NIKBOPNLEII);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x303B280", Offset = "0x303A080", VA = "0x18303B280", Slot = "37")]
		public void GMDPEJECMOO(IOBECAADPPL DKHOCCDNDOH, NIKBOPNLEII GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x303C260", Offset = "0x303B060", VA = "0x18303C260", Slot = "38")]
		public bool KJDHAOMDMIF(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x303AD00", Offset = "0x3039B00", VA = "0x18303AD00", Slot = "39")]
		public void FCHEFJMJJDM(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x303BB60", Offset = "0x303A960", VA = "0x18303BB60", Slot = "40")]
		public IOBECAADPPL IENNNAFGFNJ(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x303BBE0", Offset = "0x303A9E0", VA = "0x18303BBE0", Slot = "41")]
		public void IJKDOGNKHOG(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x303A8A0", Offset = "0x30396A0", VA = "0x18303A8A0", Slot = "42")]
		public IOBECAADPPL DJKFCHELMJI(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x303C610", Offset = "0x303B410", VA = "0x18303C610", Slot = "43")]
		public void LHJCDGMFADO(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x303BE30", Offset = "0x303AC30", VA = "0x18303BE30", Slot = "7")]
		public void JDFBMCLFMDD(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x303B030", Offset = "0x3039E30", VA = "0x18303B030", Slot = "8")]
		public void GCAONDBJOCG(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x303CF70", Offset = "0x303BD70", VA = "0x18303CF70", Slot = "9")]
		public int PEOBNLMKOKI(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x303C9E0", Offset = "0x303B7E0", VA = "0x18303C9E0", Slot = "10")]
		public IOBECAADPPL MMFPKICCFCA(IOBECAADPPL DKHOCCDNDOH, int BNNEENLPEFO)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x303B540", Offset = "0x303A340", VA = "0x18303B540", Slot = "11")]
		public void HHCBKCPNHID(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x303C0D0", Offset = "0x303AED0", VA = "0x18303C0D0", Slot = "12")]
		public void KAEJLAJLAJC(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG, IOBECAADPPL GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x3039F90", Offset = "0x3038D90", VA = "0x183039F90", Slot = "13")]
		public void ADKKMBFLCIJ(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x303B320", Offset = "0x303A120", VA = "0x18303B320", Slot = "14")]
		public bool GMPEGHIDDDI(IOBECAADPPL DKHOCCDNDOH, out IOBECAADPPL GKFICKKHACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x303A770", Offset = "0x3039570", VA = "0x18303A770", Slot = "15")]
		public void DCJONNNAHCE(IOBECAADPPL DKHOCCDNDOH, float3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x303A3F0", Offset = "0x30391F0", VA = "0x18303A3F0", Slot = "16")]
		public bool BNGLMOAKPBG(IOBECAADPPL DKHOCCDNDOH, out float3 GKFICKKHACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x303ABF0", Offset = "0x30399F0", VA = "0x18303ABF0", Slot = "17")]
		public void EKICEJLBDCB(IOBECAADPPL DKHOCCDNDOH, float3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x303BC60", Offset = "0x303AA60", VA = "0x18303BC60", Slot = "18")]
		public bool IKPMJCPBOND(IOBECAADPPL DKHOCCDNDOH, out float3 GKFICKKHACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x303AD70", Offset = "0x3039B70", VA = "0x18303AD70", Slot = "26")]
		public float3 FEGAEGKLEFB(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x303A310", Offset = "0x3039110", VA = "0x18303A310", Slot = "27")]
		public void BLPOFFDBAOF(IOBECAADPPL DKHOCCDNDOH, float3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x3039D20", Offset = "0x3038B20", VA = "0x183039D20", Slot = "28")]
		public float AAHHNOMCAKC(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x303AB80", Offset = "0x3039980", VA = "0x18303AB80", Slot = "29")]
		public void EIPCBICCOBK(IOBECAADPPL DKHOCCDNDOH, float GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x303CD40", Offset = "0x303BB40", VA = "0x18303CD40", Slot = "30")]
		public float OAJADHFCCGO(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x303A950", Offset = "0x3039750", VA = "0x18303A950", Slot = "31")]
		public void DOCKKPDCLPG(IOBECAADPPL DKHOCCDNDOH, float GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x303A9C0", Offset = "0x30397C0", VA = "0x18303A9C0", Slot = "32")]
		public bool ECAIOAKBHJC(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x303CCD0", Offset = "0x303BAD0", VA = "0x18303CCD0", Slot = "33")]
		public void OADFNGDKDEK(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x303CBC0", Offset = "0x303B9C0", VA = "0x18303CBC0", Slot = "19")]
		public void NFKCPODOOFL(IOBECAADPPL DKHOCCDNDOH, float3 GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x303A150", Offset = "0x3038F50", VA = "0x18303A150", Slot = "20")]
		public bool BGIAGLNMAKD(IOBECAADPPL DKHOCCDNDOH, out float3 GKFICKKHACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x303A620", Offset = "0x3039420", VA = "0x18303A620", Slot = "21")]
		public void CNABGMBFAAH(IOBECAADPPL DKHOCCDNDOH, quaternion GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x303D060", Offset = "0x303BE60", VA = "0x18303D060", Slot = "22")]
		public bool PHKNDIBCBBP(IOBECAADPPL DKHOCCDNDOH, out quaternion GKFICKKHACC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x303B710", Offset = "0x303A510", VA = "0x18303B710", Slot = "23")]
		public bool IAALHBLJBJN(IOBECAADPPL DKHOCCDNDOH, out float3 OPFCFCMDOPF, out quaternion FHAHIJHNKCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x303A5C0", Offset = "0x30393C0", VA = "0x18303A5C0", Slot = "44")]
		public CNIOBGEFFJI CHBHNMENNLG(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(CNIOBGEFFJI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x303B630", Offset = "0x303A430", VA = "0x18303B630", Slot = "45")]
		public void HMOJMHIAENP(IOBECAADPPL DKHOCCDNDOH, CNIOBGEFFJI GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x303CE30", Offset = "0x303BC30", VA = "0x18303CE30", Slot = "72")]
		public void OINGGHPGHJI(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x303AFA0", Offset = "0x3039DA0", VA = "0x18303AFA0", Slot = "73")]
		public void GBPEBMDLGKK(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x303AE60", Offset = "0x3039C60", VA = "0x18303AE60", Slot = "74")]
		public bool FJPIFLEOPOL(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x303BA70", Offset = "0x303A870", VA = "0x18303BA70", Slot = "81")]
		public void IDFBPIIPMIJ(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x303C950", Offset = "0x303B750", VA = "0x18303C950", Slot = "82")]
		public void MLIGFHEEIJE(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x303A690", Offset = "0x3039490", VA = "0x18303A690", Slot = "83")]
		public bool DBBOIJIDJCO(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x303AA80", Offset = "0x3039880", VA = "0x18303AA80", Slot = "84")]
		public IEnumerable<object> EFECIDLEPCI(IOBECAADPPL DKHOCCDNDOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x303C200", Offset = "0x303B000", VA = "0x18303C200", Slot = "46")]
		public bool KCGADNIEGPF(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x303BB00", Offset = "0x303A900", VA = "0x18303BB00", Slot = "47")]
		public void IEANFMCGNDH(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x303B480", Offset = "0x303A280", VA = "0x18303B480", Slot = "48")]
		public bool HAEOBEPKIAD(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x303C690", Offset = "0x303B490", VA = "0x18303C690", Slot = "49")]
		public void LHOFBPIOJNK(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x303A2B0", Offset = "0x30390B0", VA = "0x18303A2B0", Slot = "50")]
		public bool BIMBKJEDEFF(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x303ADF0", Offset = "0x3039BF0", VA = "0x18303ADF0", Slot = "51")]
		public void FILPMINMLCA(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x303C8F0", Offset = "0x303B6F0", VA = "0x18303C8F0", Slot = "52")]
		public RigidbodyConstraints MGDFNLGGDAA(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x303B1A0", Offset = "0x3039FA0", VA = "0x18303B1A0", Slot = "53")]
		public void GGEGCLIFGMG(IOBECAADPPL DKHOCCDNDOH, RigidbodyConstraints GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x303AEE0", Offset = "0x3039CE0", VA = "0x18303AEE0", Slot = "54")]
		public float FLANNKKGAAL(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x303A020", Offset = "0x3038E20", VA = "0x18303A020", Slot = "55")]
		public void AKPFAOPEABC(IOBECAADPPL DKHOCCDNDOH, float GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x303CB00", Offset = "0x303B900", VA = "0x18303CB00", Slot = "56")]
		public float MOBNINPJHNM(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x303BA00", Offset = "0x303A800", VA = "0x18303BA00", Slot = "57")]
		public void ICGJJEELNFI(IOBECAADPPL DKHOCCDNDOH, float GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x303B4E0", Offset = "0x303A2E0", VA = "0x18303B4E0", Slot = "58")]
		public bool HDDOJPAPEFG(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x303BDC0", Offset = "0x303ABC0", VA = "0x18303BDC0", Slot = "59")]
		public void IPECKBMFEID(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x303A390", Offset = "0x3039190", VA = "0x18303A390", Slot = "60")]
		public bool BNBAMLEHCLE(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x303C060", Offset = "0x303AE60", VA = "0x18303C060", Slot = "61")]
		public void JNOHHLKBKEI(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x303B140", Offset = "0x3039F40", VA = "0x18303B140", Slot = "62")]
		public int GDALBEBCCIF(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x303A550", Offset = "0x3039350", VA = "0x18303A550", Slot = "63")]
		public void CDILBEBDIOC(IOBECAADPPL DKHOCCDNDOH, int GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x303CEE0", Offset = "0x303BCE0", VA = "0x18303CEE0", Slot = "64")]
		public Rigidbody OMLDNMNPONF(IOBECAADPPL DKHOCCDNDOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x3039D80", Offset = "0x3038B80", VA = "0x183039D80", Slot = "65")]
		public void ABDHMHEDHBF(IOBECAADPPL DKHOCCDNDOH, Rigidbody GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x303CC40", Offset = "0x303BA40", VA = "0x18303CC40", Slot = "75")]
		public void NHJBPKICKMJ(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x303CDA0", Offset = "0x303BBA0", VA = "0x18303CDA0", Slot = "76")]
		public void ODFJOIAILBI(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x303BF40", Offset = "0x303AD40", VA = "0x18303BF40", Slot = "77")]
		public bool JFOBNEPONIJ(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x303A090", Offset = "0x3038E90", VA = "0x18303A090", Slot = "66")]
		public object AOHAMNLJCMI(IOBECAADPPL DKHOCCDNDOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x303C2C0", Offset = "0x303B0C0", VA = "0x18303C2C0", Slot = "67")]
		public void KJIOOALPOAI(IOBECAADPPL DKHOCCDNDOH, object GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x303AC70", Offset = "0x3039A70", VA = "0x18303AC70", Slot = "68")]
		public object ELPDMCMECEJ(IOBECAADPPL DKHOCCDNDOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x303C700", Offset = "0x303B500", VA = "0x18303C700", Slot = "69")]
		public void MCCMMCDDPPP(IOBECAADPPL DKHOCCDNDOH, object GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x303CB60", Offset = "0x303B960", VA = "0x18303CB60", Slot = "70")]
		public float NCJPNODLAMB(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x303B210", Offset = "0x303A010", VA = "0x18303B210", Slot = "71")]
		public void GLEFIEFHIHK(IOBECAADPPL DKHOCCDNDOH, float GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x303C420", Offset = "0x303B220", VA = "0x18303C420", Slot = "78")]
		public void KKHJKEHALKP(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x303C860", Offset = "0x303B660", VA = "0x18303C860", Slot = "79")]
		public void MFLNODCHCJK(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x303B980", Offset = "0x303A780", VA = "0x18303B980", Slot = "80")]
		public bool IBFHHGMFDMM(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x303AF40", Offset = "0x3039D40", VA = "0x18303AF40", Slot = "24")]
		public void FNLGDHOLHOE(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x303A710", Offset = "0x3039510", VA = "0x18303A710", Slot = "25")]
		public void DBLAEJDMPBG(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x387E8E0", Offset = "0x387D6E0", VA = "0x18387E8E0")]
		private void OGFJJPKDPEF<T>(IOBECAADPPL DKHOCCDNDOH, bool GKFICKKHACC) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x426BD10", Offset = "0x426AB10", VA = "0x18426BD10")]
		private bool GJEGIGLPKBM<T>(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x426BC00", Offset = "0x426AA00", VA = "0x18426BC00")]
		private void DOHHNJJEEIG<T>(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x426BE30", Offset = "0x426AC30", VA = "0x18426BE30")]
		private bool JIEBNIILFCM<TC, TV>(IOBECAADPPL DKHOCCDNDOH, Func<TC, TV> PMMFFGGLOBI, out TV GKFICKKHACC) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x387EE80", Offset = "0x387DC80", VA = "0x18387EE80")]
		private bool JIEBNIILFCM<T>(IOBECAADPPL DKHOCCDNDOH, out T GKFICKKHACC) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x426C010", Offset = "0x426AE10", VA = "0x18426C010")]
		private T NNBCMJCEKDP<T>(IOBECAADPPL DKHOCCDNDOH) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x387E930", Offset = "0x387D730", VA = "0x18387E930")]
		private void OOMHGODPDDH<T>(IOBECAADPPL DKHOCCDNDOH, T GKFICKKHACC) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x426B5A0", Offset = "0x426A3A0", VA = "0x18426B5A0")]
		private void CCEGOLNGCFA<T>(IOBECAADPPL DKHOCCDNDOH, T GKFICKKHACC) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x387EE80", Offset = "0x387DC80", VA = "0x18387EE80")]
		private bool PDBOKAHNOEC<T>(IOBECAADPPL DKHOCCDNDOH, out T GKFICKKHACC) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x426BFB0", Offset = "0x426ADB0", VA = "0x18426BFB0")]
		private T MAOGCHGEPOJ<T>(IOBECAADPPL DKHOCCDNDOH) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x387EE80", Offset = "0x387DC80", VA = "0x18387EE80")]
		private void IIKMANBOGLD<T>(IOBECAADPPL DKHOCCDNDOH, T GKFICKKHACC) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x426BC60", Offset = "0x426AA60", VA = "0x18426BC60")]
		private void FFAOGMBHHCD<T>(IOBECAADPPL DKHOCCDNDOH, T GKFICKKHACC) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x303A120", Offset = "0x3038F20", VA = "0x18303A120")]
		private IOBECAADPPL BCANHHMFGHM(Entity LLEBIIAHFDD)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x303C4B0", Offset = "0x303B2B0", VA = "0x18303C4B0")]
		private DynamicBuffer<Entity> KNCEAKPFOHP(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x426BD70", Offset = "0x426AB70", VA = "0x18426BD70")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
			[DebuggerHidden]
			public BCOEIMLKHGE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x3F21640", Offset = "0x3F20440", VA = "0x183F21640", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x3F21300", Offset = "0x3F20100", VA = "0x183F21300", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x3F216C0", Offset = "0x3F204C0", VA = "0x183F216C0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x3F21600", Offset = "0x3F20400", VA = "0x183F21600", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x3F21550", Offset = "0x3F20350", VA = "0x183F21550", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JJBGGEMNFLN> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x3F21550", Offset = "0x3F20350", VA = "0x183F21550", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3055B60", Offset = "0x3054960", VA = "0x183055B60", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x3056760", Offset = "0x3055560", VA = "0x183056760")]
		public void PEOFOOEADCA(NativeArray<Entity> FNMNPGEEPJI, bool KGNOBIJBGHH, bool KOOGAHOBCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x3055D00", Offset = "0x3054B00", VA = "0x183055D00")]
		public void IIGPMKNGHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x3055FA0", Offset = "0x3054DA0", VA = "0x183055FA0")]
		private void OHLHOONAPGB(NativeArray<Entity> FNMNPGEEPJI, bool KGNOBIJBGHH, bool KOOGAHOBCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x3055F10", Offset = "0x3054D10", VA = "0x183055F10")]
		[IteratorStateMachine(typeof(BCOEIMLKHGE))]
		private IEnumerable<JJBGGEMNFLN> JIBHLMACMGI(NativeArray<Entity> FNMNPGEEPJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x3055BB0", Offset = "0x30549B0", VA = "0x183055BB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x30568D0", Offset = "0x30556D0", VA = "0x1830568D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x304E180", Offset = "0x304CF80", VA = "0x18304E180", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public FPHEKKDEPIJ OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x304E1A0", Offset = "0x304CFA0", VA = "0x18304E1A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public FPHEKKDEPIJ OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x304E1A0", Offset = "0x304CFA0", VA = "0x18304E1A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x304E5A0", Offset = "0x304D3A0", VA = "0x18304E5A0", Slot = "11")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x304E100", Offset = "0x304CF00", VA = "0x18304E100", Slot = "12")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "13")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x304E6D0", Offset = "0x304D4D0", VA = "0x18304E6D0")]
	private void OJNAKICNFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3090", Offset = "0x1DE1E90", VA = "0x181DE3090")]
	private string LEPHKOOCLOJ(string NLCIGFDKGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x304E5F0", Offset = "0x304D3F0", VA = "0x18304E5F0", Slot = "7")]
	public FPHEKKDEPIJ MGLBJDODELB(PMBKKKKDOIF BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x304E1E0", Offset = "0x304CFE0", VA = "0x18304E1E0")]
	private bool IDLBANBJMEM(Type GHGAIHKFDCM, string NLCIGFDKGEE, out FPHEKKDEPIJ LGPKKGCJHDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x304E490", Offset = "0x304D290", VA = "0x18304E490", Slot = "8")]
	public EBLKGKAPHAO IDLNJNJGIMG(PMBKKKKDOIF BBEHMKMODBA)
	{
		return default(EBLKGKAPHAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x304E1C0", Offset = "0x304CFC0", VA = "0x18304E1C0", Slot = "9")]
	public IEnumerator<FPHEKKDEPIJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x304E1C0", Offset = "0x304CFC0", VA = "0x18304E1C0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x304E970", Offset = "0x304D770", VA = "0x18304E970")]
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
		[Cpp2IlInjected.Address(RVA = "0x3409C80", Offset = "0x3408A80", VA = "0x183409C80", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x3409CE0", Offset = "0x3408AE0", VA = "0x183409CE0", Slot = "6")]
	public bool MHBDMIIAHNA(EBLKGKAPHAO GLGEGPNMJGF, out int LBLAPKMJFKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x34099B0", Offset = "0x34087B0", VA = "0x1834099B0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x3409D50", Offset = "0x3408B50", VA = "0x183409D50", Slot = "5")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x3409A10", Offset = "0x3408810", VA = "0x183409A10")]
	private void DEBEEKKKKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x3409D60", Offset = "0x3408B60", VA = "0x183409D60")]
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
		[Cpp2IlInjected.Address(RVA = "0x3043C10", Offset = "0x3042A10", VA = "0x183043C10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public HLBEOPKMMDF OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x3043D60", Offset = "0x3042B60", VA = "0x183043D60", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public HLBEOPKMMDF OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x3043D60", Offset = "0x3042B60", VA = "0x183043D60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "10")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x3043970", Offset = "0x3042770", VA = "0x183043970", Slot = "11")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "12")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3043F50", Offset = "0x3042D50", VA = "0x183043F50", Slot = "6")]
	public HLBEOPKMMDF MGLBJDODELB(PMBKKKKDOIF BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x3043E80", Offset = "0x3042C80", VA = "0x183043E80", Slot = "7")]
	public EBLKGKAPHAO IDLNJNJGIMG(PMBKKKKDOIF BBEHMKMODBA)
	{
		return default(EBLKGKAPHAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x3043DA0", Offset = "0x3042BA0", VA = "0x183043DA0", Slot = "8")]
	public IEnumerator<HLBEOPKMMDF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x3044080", Offset = "0x3042E80", VA = "0x183044080", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x3389010", Offset = "0x3387E10", VA = "0x183389010", Slot = "13")]
	public void HKFMGALIEPK<TKey, T>(global::JKHOGOMAANC<TKey, T> GCEENFOFNFL, [Optional] object EDPENIGJGLF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x3043C20", Offset = "0x3042A20", VA = "0x183043C20", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public GEEMLFOADIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x3043D60", Offset = "0x3042B60", VA = "0x183043D60")]
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
		[Cpp2IlInjected.Address(RVA = "0x304D330", Offset = "0x304C130", VA = "0x18304D330", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public HLPDKNGJOIH OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x304D420", Offset = "0x304C220", VA = "0x18304D420", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public HLPDKNGJOIH OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x304D420", Offset = "0x304C220", VA = "0x18304D420", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x304D2C0", Offset = "0x304C0C0", VA = "0x18304D2C0", Slot = "9")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x304D810", Offset = "0x304C610", VA = "0x18304D810", Slot = "10")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x304D610", Offset = "0x304C410", VA = "0x18304D610")]
	private HLPDKNGJOIH IGJCGELNFAH(int BNNEENLPEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x304D6F0", Offset = "0x304C4F0", VA = "0x18304D6F0", Slot = "6")]
	public HLPDKNGJOIH MGLBJDODELB(PMBKKKKDOIF BBEHMKMODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x304D540", Offset = "0x304C340", VA = "0x18304D540", Slot = "14")]
	public EBLKGKAPHAO IDLNJNJGIMG(PMBKKKKDOIF BBEHMKMODBA)
	{
		return default(EBLKGKAPHAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x304D430", Offset = "0x304C230", VA = "0x18304D430", Slot = "7")]
	public IEnumerator<HLPDKNGJOIH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x304D430", Offset = "0x304C230", VA = "0x18304D430", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2DA1AA0", Offset = "0x2DA08A0", VA = "0x182DA1AA0", Slot = "11")]
	public void HKFMGALIEPK<TKey, T>(global::JKHOGOMAANC<TKey, T> GCEENFOFNFL, [Optional] object EDPENIGJGLF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x304D380", Offset = "0x304C180", VA = "0x18304D380", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public IDFNOOAOLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x304D420", Offset = "0x304C220", VA = "0x18304D420")]
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
		[Cpp2IlInjected.Address(RVA = "0x64F720", Offset = "0x64E520", VA = "0x18064F720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x6500E0", Offset = "0x64EEE0", VA = "0x1806500E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x341B8C0", Offset = "0x341A6C0", VA = "0x18341B8C0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x341B9F0", Offset = "0x341A7F0", VA = "0x18341B9F0")]
	private void EKNJNMDHOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x26E3A40", Offset = "0x26E2840", VA = "0x1826E3A40")]
	public T NELIEDNCPFG<T>() where T : OCECHDCDPOJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x341BC80", Offset = "0x341AA80", VA = "0x18341BC80")]
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
	[Cpp2IlInjected.Address(RVA = "0x341BAE0", Offset = "0x341A8E0", VA = "0x18341BAE0")]
	public HLPDKNGJOIH GJNNMCIGLOE(PMBKKKKDOIF NLCIGFDKGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x26E39C0", Offset = "0x26E27C0", VA = "0x1826E39C0")]
	public global::AMDLBDOEOBO<T> GJNNMCIGLOE<T>(PMBKKKKDOIF NLCIGFDKGEE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x341BBB0", Offset = "0x341A9B0", VA = "0x18341BBB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public DEPJHLBJFBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal static class GHEKLJIOPOF
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2D856C0", Offset = "0x2D844C0", VA = "0x182D856C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3408C60", Offset = "0x3407A60", VA = "0x183408C60", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x3408EF0", Offset = "0x3407CF0", VA = "0x183408EF0")]
	public void BHKJAPMCHOA(ELJHNEOGEBP FFJHOAAMJMD, bool ODDBKPJIGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6CD690", Offset = "0x6CC490", VA = "0x1806CD690")]
		[DebuggerHidden]
		public BBOEPELNAEJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x3F211C0", Offset = "0x3F1FFC0", VA = "0x183F211C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x3F20E10", Offset = "0x3F1FC10", VA = "0x183F20E10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x3F21240", Offset = "0x3F20040", VA = "0x183F21240")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x3F21180", Offset = "0x3F1FF80", VA = "0x183F21180", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x3F210F0", Offset = "0x3F1FEF0", VA = "0x183F210F0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x3F210F0", Offset = "0x3F1FEF0", VA = "0x183F210F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x301EEB0", Offset = "0x301DCB0", VA = "0x18301EEB0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x30202C0", Offset = "0x301F0C0", VA = "0x1830202C0", Slot = "5")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x301F170", Offset = "0x301DF70", VA = "0x18301F170", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x301F160", Offset = "0x301DF60", VA = "0x18301F160")]
	private void CICFDDJNPAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x301FA10", Offset = "0x301E810", VA = "0x18301FA10")]
	internal void MIIMFHAHDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x301F830", Offset = "0x301E630", VA = "0x18301F830")]
	private void KNFEKOLAFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x3020540", Offset = "0x301F340", VA = "0x183020540")]
	private void PMPIPBFFDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x30204F0", Offset = "0x301F2F0", VA = "0x1830204F0")]
	[IteratorStateMachine(typeof(BBOEPELNAEJ))]
	private IEnumerable<RRCustomPropTag> OLLJFDGNMNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x301FE40", Offset = "0x301EC40", VA = "0x18301FE40")]
	private void NCMMJFLKDFO(IOBECAADPPL DKHOCCDNDOH, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x301F310", Offset = "0x301E110", VA = "0x18301F310")]
	private void EHMHLLLMBAF(SerializableGuid LNKDDEDGKJH, GameObject ENOCMPCACJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x301F450", Offset = "0x301E250", VA = "0x18301F450")]
	private void EMDHGCOFPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x301EF80", Offset = "0x301DD80", VA = "0x18301EF80")]
	private bool BELFMLFLDCK(BAIPPHODGCI HOBODMININO, Transform GEOFAMNLJNK, out GameObject CFBIOKMMOEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x301F7E0", Offset = "0x301E5E0", VA = "0x18301F7E0")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x3020640", Offset = "0x301F440", VA = "0x183020640")]
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
			[Cpp2IlInjected.Address(RVA = "0x6CF580", Offset = "0x6CE380", VA = "0x1806CF580")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x3039C30", Offset = "0x3038A30", VA = "0x183039C30")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x6529C0", Offset = "0x6517C0", VA = "0x1806529C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x304A8F0", Offset = "0x30496F0", VA = "0x18304A8F0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3020B30", Offset = "0x301F930", VA = "0x183020B30", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x3020BC0", Offset = "0x301F9C0", VA = "0x183020BC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x3020BA0", Offset = "0x301F9A0", VA = "0x183020BA0")]
	private void AHMBPFMCKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x3020C00", Offset = "0x301FA00", VA = "0x183020C00")]
	private void PGMEIKNKPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3031080", Offset = "0x302FE80", VA = "0x183031080", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public IOBECAADPPL NOLFCLJOHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x3031520", Offset = "0x3030320", VA = "0x183031520", Slot = "9")]
		get
		{
			return default(IOBECAADPPL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x3030D40", Offset = "0x302FB40", VA = "0x183030D40", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public MFPKOBHCDLK NCMKIIJCJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x3031370", Offset = "0x3030170", VA = "0x183031370", Slot = "11")]
		get
		{
			return default(MFPKOBHCDLK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x3030D40", Offset = "0x302FB40", VA = "0x183030D40", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public MFPKOBHCDLK NPDGGDGFOBO
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x3031560", Offset = "0x3030360", VA = "0x183031560", Slot = "13")]
		get
		{
			return default(MFPKOBHCDLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private uint INHCCLJBHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x3030E90", Offset = "0x302FC90", VA = "0x183030E90")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event ODEMOPJLFII PGNCABCBGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x3030F40", Offset = "0x302FD40", VA = "0x183030F40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x30312D0", Offset = "0x30300D0", VA = "0x1830312D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x30308E0", Offset = "0x302F6E0", VA = "0x1830308E0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x30315B0", Offset = "0x30303B0", VA = "0x1830315B0", Slot = "5")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x3030DE0", Offset = "0x302FBE0", VA = "0x183030DE0", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x30309B0", Offset = "0x302F7B0", VA = "0x1830309B0")]
	private void BIPCIHPAKNF(Entity LLEBIIAHFDD, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG KNAEAKFNOOB, EKBGHCIKEGG OCBHJKLFMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x30311C0", Offset = "0x302FFC0", VA = "0x1830311C0", Slot = "14")]
	public IOBECAADPPL KIGGLEINDHC(IOBECAADPPL ADDDKDIDHPJ, IOBECAADPPL LCEKCMGAGEI)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x30310C0", Offset = "0x302FEC0", VA = "0x1830310C0", Slot = "15")]
	public bool KCBAGPAHKEE(IOBECAADPPL ADDDKDIDHPJ, IOBECAADPPL LCEKCMGAGEI, out IOBECAADPPL BKMGHCEAABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x3030BB0", Offset = "0x302F9B0", VA = "0x183030BB0", Slot = "16")]
	public void BMCHDMKDJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x3030FE0", Offset = "0x302FDE0", VA = "0x183030FE0", Slot = "17")]
	public void JFJAEFAGCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x30313C0", Offset = "0x30301C0", VA = "0x1830313C0", Slot = "18")]
	public bool LPFNGDNALNE(IOBECAADPPL EHPFANFOFFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x3030D40", Offset = "0x302FB40", VA = "0x183030D40")]
	private void LCGKJPGHBCP(IOBECAADPPL GKKANKKOLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x305AE00", Offset = "0x3059C00", VA = "0x18305AE00", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x305AE80", Offset = "0x3059C80", VA = "0x18305AE80", Slot = "5")]
	public void DOLNBNBMHOO(IOBECAADPPL IBGBBCHPJJF, bool GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2DDDC80", Offset = "0x2DDCA80", VA = "0x182DDDC80")]
	private void NMFBOCJEJOB<T>(IOBECAADPPL IBGBBCHPJJF, bool GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x32AD360", Offset = "0x32AC160", VA = "0x1832AD360", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x32AD3E0", Offset = "0x32AC1E0", VA = "0x1832AD3E0", Slot = "5")]
		public void KDGKHGHGKPP(IOBECAADPPL IBGBBCHPJJF, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x32AD450", Offset = "0x32AC250", VA = "0x1832AD450", Slot = "6")]
		public void NCPHKIFGEGI(IOBECAADPPL IBGBBCHPJJF, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2DDDC80", Offset = "0x2DDCA80", VA = "0x182DDDC80")]
		private void NMFBOCJEJOB<T>(IOBECAADPPL IBGBBCHPJJF, bool GKFICKKHACC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x304F260", Offset = "0x304E060", VA = "0x18304F260", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1108410", Offset = "0x1107210", VA = "0x181108410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x32C1430", Offset = "0x32C0230", VA = "0x1832C1430", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE BPEEICHBHFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x32C1670", Offset = "0x32C0470", VA = "0x1832C1670", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x32C23B0", Offset = "0x32C11B0", VA = "0x1832C23B0", Slot = "6")]
		public bool NCNCMKKFBNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x32C1650", Offset = "0x32C0450", VA = "0x1832C1650", Slot = "7")]
		public bool BDGPCLMJPHE(IEnumerable<KPBHHJNMPGI> JNPPLACLHGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x32C1740", Offset = "0x32C0540", VA = "0x1832C1740", Slot = "5")]
		public ByteString JNACBIDAHJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x32C2390", Offset = "0x32C1190", VA = "0x1832C2390")]
		private void MFKLNAEKLBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x32C1580", Offset = "0x32C0380", VA = "0x1832C1580")]
		private void AGMNDHPCCIP(NELJHPCAMDK BOOMEIJCBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x32C1BD0", Offset = "0x32C09D0", VA = "0x1832C1BD0")]
		private void KDKFFIPLDGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x32C20B0", Offset = "0x32C0EB0", VA = "0x1832C20B0")]
		private void LKCDIBPGJNN(PFFOAGAAAPP BOOMEIJCBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x32C2510", Offset = "0x32C1310", VA = "0x1832C2510", Slot = "8")]
		public void NHJFFFEKKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x32C16A0", Offset = "0x32C04A0", VA = "0x1832C16A0")]
		private NELJHPCAMDK GNIAGPDBDGL(EntityManager LPIKKOEGLIJ, EntityManager DKNGLDMHBMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x304A4F0", Offset = "0x30492F0", VA = "0x18304A4F0")]
	public GameObject LAJDCFAJJAK(CKLKKHOPBLL DIKOGDNLGKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x304A5C0", Offset = "0x30493C0", VA = "0x18304A5C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x32B4CC0", Offset = "0x32B3AC0", VA = "0x1832B4CC0")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x32B4DF0", Offset = "0x32B3BF0", VA = "0x1832B4DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool JDAAPCPMLFI
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x726EF0", Offset = "0x725CF0", VA = "0x180726EF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x786A00", Offset = "0x785800", VA = "0x180786A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x8F8B10", Offset = "0x8F7910", VA = "0x1808F8B10", Slot = "4")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x32B4C70", Offset = "0x32B3A70", VA = "0x1832B4C70", Slot = "5")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x32B4D30", Offset = "0x32B3B30", VA = "0x1832B4D30")]
		public void CLMACCGHNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x32B0DF0", Offset = "0x32AFBF0", VA = "0x1832B0DF0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x32B1040", Offset = "0x32AFE40", VA = "0x1832B1040", Slot = "5")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x32B0FA0", Offset = "0x32AFDA0", VA = "0x1832B0FA0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x32B0E60", Offset = "0x32AFC60", VA = "0x1832B0E60")]
		private void CBOOHBGEHAF(Entity LLEBIIAHFDD, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x303E490", Offset = "0x303D290", VA = "0x18303E490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private BFLEMBEOHEL FHKHMHKBKBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x303E500", Offset = "0x303D300", VA = "0x18303E500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x303E410", Offset = "0x303D210", VA = "0x18303E410", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x303E4E0", Offset = "0x303D2E0", VA = "0x18303E4E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BGPJNKFENHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x3F21D20", Offset = "0x3F20B20", VA = "0x183F21D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public ALCLLINFNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x3F20CD0", Offset = "0x3F1FAD0", VA = "0x183F20CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xBBAF10", Offset = "0xBB9D10", VA = "0x180BBAF10", Slot = "4")]
		get
		{
			return default(AHPBGKKBONO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private LGIKDIEECOD IAMBCCOEDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x302DD10", Offset = "0x302CB10", VA = "0x18302DD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x302DBE0", Offset = "0x302C9E0", VA = "0x18302DBE0", Slot = "5")]
	public void LHCOLCBEPCK(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x302DAB0", Offset = "0x302C8B0", VA = "0x18302DAB0", Slot = "6")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x302D8A0", Offset = "0x302C6A0", VA = "0x18302D8A0", Slot = "7")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x302DC30", Offset = "0x302CA30", VA = "0x18302DC30", Slot = "8")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x302D980", Offset = "0x302C780", VA = "0x18302D980", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x2DAFA70", Offset = "0x2DAE870", VA = "0x182DAFA70")]
	private void FGFALEOFPOP<T>(Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x33451E0", Offset = "0x3343FE0", VA = "0x1833451E0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x3345240", Offset = "0x3344040", VA = "0x183345240", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x33451B0", Offset = "0x3343FB0", VA = "0x1833451B0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x77EBA0", Offset = "0x77D9A0", VA = "0x18077EBA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x77EC20", Offset = "0x77DA20", VA = "0x18077EC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x3345120", Offset = "0x3343F20", VA = "0x183345120")]
	public HLDFHJMCCJJ(Func<From, To> IEPBJFBIJCM, Func<To, From> FGIDPBOLFPN, bool PHLJIIECGMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x3344D40", Offset = "0x3343B40", VA = "0x183344D40", Slot = "11")]
	public void Add(To MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2884520", Offset = "0x2883320", VA = "0x182884520", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x3344DA0", Offset = "0x3343BA0", VA = "0x183344DA0", Slot = "13")]
	public bool Contains(To MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x3344E00", Offset = "0x3343C00", VA = "0x183344E00", Slot = "14")]
	public void CopyTo(To[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x3344F10", Offset = "0x3343D10", VA = "0x183344F10", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x3344F80", Offset = "0x3343D80", VA = "0x183344F80", Slot = "6")]
	public int IndexOf(To MPIBAJOJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x3344FE0", Offset = "0x3343DE0", VA = "0x183344FE0", Slot = "7")]
	public void Insert(int BNNEENLPEFO, To MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x3345090", Offset = "0x3343E90", VA = "0x183345090", Slot = "15")]
	public bool Remove(To MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x3345060", Offset = "0x3343E60", VA = "0x183345060", Slot = "8")]
	public void RemoveAt(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x33450F0", Offset = "0x3343EF0", VA = "0x1833450F0", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D84BA0", Offset = "0x3D839A0", VA = "0x183D84BA0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x3D84BF0", Offset = "0x3D839F0", VA = "0x183D84BF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D84B60", Offset = "0x3D83960", VA = "0x183D84B60", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool MIDGGJPOHOA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x668120", Offset = "0x666F20", VA = "0x180668120", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x259F230", Offset = "0x259E030", VA = "0x18259F230")]
	public BCGHODBJJMC(Func<From, To> IEPBJFBIJCM, Func<To, From> FGIDPBOLFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D84770", Offset = "0x3D83570", VA = "0x183D84770", Slot = "11")]
	public void Add(To MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D847B0", Offset = "0x3D835B0", VA = "0x183D847B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D847F0", Offset = "0x3D835F0", VA = "0x183D847F0", Slot = "13")]
	public bool Contains(To MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D848B0", Offset = "0x3D836B0", VA = "0x183D848B0", Slot = "14")]
	public void CopyTo(To[] EJLDCNGHIAK, int BGCNDKINPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D84970", Offset = "0x3D83770", VA = "0x183D84970", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D84A30", Offset = "0x3D83830", VA = "0x183D84A30", Slot = "6")]
	public int IndexOf(To MPIBAJOJAPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D84AA0", Offset = "0x3D838A0", VA = "0x183D84AA0", Slot = "7")]
	public void Insert(int BNNEENLPEFO, To MPIBAJOJAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x3D84B20", Offset = "0x3D83920", VA = "0x183D84B20", Slot = "15")]
	public bool Remove(To MPIBAJOJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x3D84AE0", Offset = "0x3D838E0", VA = "0x183D84AE0", Slot = "8")]
	public void RemoveAt(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x251CC50", Offset = "0x251BA50", VA = "0x18251CC50", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public COFHODGBHBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x3F22C70", Offset = "0x3F21A70", VA = "0x183F22C70")]
		internal void <InitServices>b__1(OHFJHEDBJHF svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F22CD0", Offset = "0x3F21AD0", VA = "0x183F22CD0")]
		internal void <InitServices>b__2(HMFGCABFMPC svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x3020C30", Offset = "0x301FA30", VA = "0x183020C30")]
	public static void BPDPGKDLBFA(this LGIKDIEECOD AEEDEJIEEFL, PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x32549D0", Offset = "0x32537D0", VA = "0x1832549D0")]
	public static void FGFALEOFPOP<T>(this LGIKDIEECOD AEEDEJIEEFL, Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x3254BB0", Offset = "0x32539B0", VA = "0x183254BB0")]
	public static void FOGIIIFGBON<T>(this LGIKDIEECOD AEEDEJIEEFL, Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x3254820", Offset = "0x3253620", VA = "0x183254820")]
	public static void ENPNFKMAPMB<T>(this LGIKDIEECOD AEEDEJIEEFL, Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x3254D50", Offset = "0x3253B50", VA = "0x183254D50")]
	public static void KMALHHPAIDH<T>(this LGIKDIEECOD AEEDEJIEEFL, Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x32545B0", Offset = "0x32533B0", VA = "0x1832545B0")]
	public static void DPHDIMAJMNN<T>(this LGIKDIEECOD AEEDEJIEEFL, Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x3254A40", Offset = "0x3253840", VA = "0x183254A40")]
	public static void FOGIIIFGBON<T>(IEnumerable<ComponentSystemBase> PCMOOAJDLNB, Action<T> OFCBPHMKBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x3254760", Offset = "0x3253560", VA = "0x183254760")]
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
	[Cpp2IlInjected.Address(RVA = "0x3020740", Offset = "0x301F540", VA = "0x183020740")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public BCOCIADIPHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x301BB20", Offset = "0x301A920", VA = "0x18301BB20")]
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
		[Cpp2IlInjected.Address(RVA = "0x32AFD80", Offset = "0x32AEB80", VA = "0x1832AFD80")]
		public static void FEOLDJENCJJ(this FEGPLAEFMOI HFDOFHJBJGD, IMFOEJGFLNN MBNFLPKEEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x32B0260", Offset = "0x32AF060", VA = "0x1832B0260")]
		public static void KJFDBPJDEPG(this FEGPLAEFMOI HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x32AFC70", Offset = "0x32AEA70", VA = "0x1832AFC70")]
		public static void FEOLDJENCJJ(this FEGPLAEFMOI HFDOFHJBJGD, [Optional] string[] PNEAJOPIFPI, [Optional] string[] PDJFKHNHEFB, [Optional] string[] JNCKALKDEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x32AFBC0", Offset = "0x32AE9C0", VA = "0x1832AFBC0")]
		public static void CNKFCAGBKOA(this FEGPLAEFMOI HFDOFHJBJGD, params string[] PLHBKKLFOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x32B01B0", Offset = "0x32AEFB0", VA = "0x1832B01B0")]
		public static void GOMEEFOMFLH(this FEGPLAEFMOI HFDOFHJBJGD, params string[] PLHBKKLFOOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x32AFFB0", Offset = "0x32AEDB0", VA = "0x1832AFFB0")]
		private static string[] GGAHOKMODLC(IMFOEJGFLNN MBNFLPKEEGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x32B0360", Offset = "0x32AF160", VA = "0x1832B0360")]
		private static bool PJCHMCAOPKA(IMFOEJGFLNN MBNFLPKEEGH, out string[] GNLGCLEFBLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6681B0", Offset = "0x666FB0", VA = "0x1806681B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3405230", Offset = "0x3404030", VA = "0x183405230")]
	public AMFKNHKJGHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action BCFDAENEDAF();

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x34051F0", Offset = "0x3403FF0", VA = "0x1834051F0")]
	public MethodInfo MPKCHGILMNM(Action KDJGJCHCIKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x3405040", Offset = "0x3403E40", VA = "0x183405040", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x30305A0", Offset = "0x302F3A0", VA = "0x1830305A0", Slot = "5")]
	public override Action BCFDAENEDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void ICHOEHPKEKD<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x3030630", Offset = "0x302F430", VA = "0x183030630")]
	[Preserve]
	public void CIKOLKINFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x302D890", Offset = "0x302C690", VA = "0x18302D890")]
	protected PMEJJIODGLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class PCOCNCIFCPC : AMFKNHKJGHK
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x302D770", Offset = "0x302C570", VA = "0x18302D770", Slot = "5")]
	public override Action BCFDAENEDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void IPCCAACDKCF<T>() where T : HHCBFJCPHFB;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x302D800", Offset = "0x302C600", VA = "0x18302D800")]
	[Preserve]
	public void CIKOLKINFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x302D890", Offset = "0x302C690", VA = "0x18302D890")]
	protected PCOCNCIFCPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class JNLOEDNAGBO : AMFKNHKJGHK
{
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x3051950", Offset = "0x3050750", VA = "0x183051950", Slot = "5")]
	public override Action BCFDAENEDAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void KJGAMEJBJMC<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x30519E0", Offset = "0x30507E0", VA = "0x1830519E0")]
	[Preserve]
	public void CIKOLKINFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x302D890", Offset = "0x302C690", VA = "0x18302D890")]
	protected JNLOEDNAGBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class AOJMMEPIBDL
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x3405F80", Offset = "0x3404D80", VA = "0x183405F80")]
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
				[Cpp2IlInjected.Address(RVA = "0x1731AE0", Offset = "0x17308E0", VA = "0x181731AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F24AD0", Offset = "0x3F238D0", VA = "0x183F24AD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x3F22830", Offset = "0x3F21630", VA = "0x183F22830")]
			[DebuggerHidden]
			public ECKGDLBNKAM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x3F24900", Offset = "0x3F23700", VA = "0x183F24900", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x3F24A90", Offset = "0x3F23890", VA = "0x183F24A90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x3F249E0", Offset = "0x3F237E0", VA = "0x183F249E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x3F249E0", Offset = "0x3F237E0", VA = "0x183F249E0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1731AE0", Offset = "0x17308E0", VA = "0x181731AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F22B40", Offset = "0x3F21940", VA = "0x183F22B40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x3F22830", Offset = "0x3F21630", VA = "0x183F22830")]
			[DebuggerHidden]
			public CNPNNKINJJG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x3F22B90", Offset = "0x3F21990", VA = "0x183F22B90", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x3F22860", Offset = "0x3F21660", VA = "0x183F22860", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x3F22C20", Offset = "0x3F21A20", VA = "0x183F22C20")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x3F22B00", Offset = "0x3F21900", VA = "0x183F22B00", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x3F22A50", Offset = "0x3F21850", VA = "0x183F22A50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x3F22A50", Offset = "0x3F21850", VA = "0x183F22A50", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x1731AE0", Offset = "0x17308E0", VA = "0x181731AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F22670", Offset = "0x3F21470", VA = "0x183F22670", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x3F22830", Offset = "0x3F21630", VA = "0x183F22830")]
			[DebuggerHidden]
			public CNLHHAHEDHN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x3F226C0", Offset = "0x3F214C0", VA = "0x183F226C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x3F22260", Offset = "0x3F21060", VA = "0x183F22260", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x3F22790", Offset = "0x3F21590", VA = "0x183F22790")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x3F227E0", Offset = "0x3F215E0", VA = "0x183F227E0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x3F22630", Offset = "0x3F21430", VA = "0x183F22630", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x3F22590", Offset = "0x3F21390", VA = "0x183F22590", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x3F22590", Offset = "0x3F21390", VA = "0x183F22590", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static readonly FNIDFMEJGMB CBDAGBGGFJM;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x3041B10", Offset = "0x3040910", VA = "0x183041B10")]
		public static Entity MJGKPNPKLCE(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x3040870", Offset = "0x303F670", VA = "0x183040870")]
		public static DynamicBuffer<ChildrenData> ABAMDIJGCIG(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x30410E0", Offset = "0x303FEE0", VA = "0x1830410E0")]
		public static DynamicBuffer<ChildrenData> FEDHOEGKNBM(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x3040B10", Offset = "0x303F910", VA = "0x183040B10")]
		public static NativeArray<Entity> BACADGPIJEL(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Allocator PBEDBDBGIPF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x3041760", Offset = "0x3040560", VA = "0x183041760")]
		public static bool KDDEMFMDCBI(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Allocator PBEDBDBGIPF, out NativeArray<Entity> IIGJIFCGHIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x3040D20", Offset = "0x303FB20", VA = "0x183040D20")]
		public static NativeArray<Entity> CELHEPNBKPM(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x3041B80", Offset = "0x3040980", VA = "0x183041B80")]
		public static Entity MMFPKICCFCA(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, int BNNEENLPEFO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x3041F20", Offset = "0x3040D20", VA = "0x183041F20")]
		public static int PEOBNLMKOKI(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x3040E80", Offset = "0x303FC80", VA = "0x183040E80")]
		public static void COHBCADGNJA(NativeArray<Entity> MCPLHLPJDOB, NativeArray<Entity> KPOBDKLHLOL, EntityManager CLLNDNAAIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x3041A60", Offset = "0x3040860", VA = "0x183041A60")]
		public static int MGMJAGBJING(this EntityManager CLLNDNAAIKP, Entity GEOFAMNLJNK, Entity DBNJJKLOCGM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x3041CB0", Offset = "0x3040AB0", VA = "0x183041CB0")]
		public static bool NLDBNJEFDEH(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Entity NMJJIOLIMGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x3041E10", Offset = "0x3040C10", VA = "0x183041E10")]
		public static IEnumerable<Entity> OEGOHCELJAI(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, bool HOJIMILIDNA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x30412F0", Offset = "0x30400F0", VA = "0x1830412F0")]
		public static bool HDGJJPALPML(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Entity DBNJJKLOCGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x3042030", Offset = "0x3040E30", VA = "0x183042030")]
		public static bool PGPKCLNGJPJ(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Entity ADDDKDIDHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x3040900", Offset = "0x303F700", VA = "0x183040900")]
		public static NativeList<Entity> AILKEPHEJLI(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, bool HOJIMILIDNA = false, Allocator PBEDBDBGIPF = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x3041860", Offset = "0x3040660", VA = "0x183041860")]
		public static IEnumerable<Entity> LBLBJIKOPHN(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, bool HOJIMILIDNA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x3041430", Offset = "0x3040230", VA = "0x183041430")]
		public static Entity IENNNAFGFNJ(this EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x30415C0", Offset = "0x30403C0", VA = "0x1830415C0")]
		public static bool KCBAGPAHKEE(this EntityManager CLLNDNAAIKP, Entity ADDDKDIDHPJ, Entity LCEKCMGAGEI, out Entity BKMGHCEAABD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x3041170", Offset = "0x303FF70", VA = "0x183041170")]
		internal static void GBACKPGELDL(EntityManager CLLNDNAAIKP, Entity GEOFAMNLJNK, Entity DBNJJKLOCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x30411F0", Offset = "0x303FFF0", VA = "0x1830411F0")]
		internal static void HAHFHBOCMOM(EntityManager CLLNDNAAIKP, Entity GEOFAMNLJNK, Entity DBNJJKLOCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x3041530", Offset = "0x3040330", VA = "0x183041530")]
		[IteratorStateMachine(typeof(ECKGDLBNKAM))]
		private static IEnumerable<Entity> IHPILBHEOLI(EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, bool HOJIMILIDNA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x30413A0", Offset = "0x30401A0", VA = "0x1830413A0")]
		[IteratorStateMachine(typeof(CNPNNKINJJG))]
		private static IEnumerable<Entity> HNIIBFAMBCH(EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, bool HOJIMILIDNA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x30419E0", Offset = "0x30407E0", VA = "0x1830419E0")]
		[IteratorStateMachine(typeof(CNLHHAHEDHN))]
		private static IEnumerable<Entity> LLOLGACPBAH(EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x3040C40", Offset = "0x303FA40", VA = "0x183040C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public MCFPIPCNFDN JHMDIDKKOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public EEHCKCIAPAN IAMBCCOEDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public HMCNJNGCNFE EDMMPBCKJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public CKDAIJCFICL NNOGECKBPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public BLGCKCAEBNA EKBGIHOCMFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x64F720", Offset = "0x64E520", VA = "0x18064F720", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public NDJGAFFBPCH PKEGKBMDJJG
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x652A00", Offset = "0x651800", VA = "0x180652A00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public JOBGNDCAMAM BBLKMPHNEAI
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x656280", Offset = "0x655080", VA = "0x180656280", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public LJHKOFPCONB NBHOOAPKPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x73A460", Offset = "0x739260", VA = "0x18073A460", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public HBEDANEOEFD HBHJHLDECID
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE90", Offset = "0x6ECC90", VA = "0x1806EDE90", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public OFDPPBHBKCF MDNKEJMDPCM
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x6EBEE0", Offset = "0x6EACE0", VA = "0x1806EBEE0", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public CPPNPEKOALL DDFIAFJOFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x6EBEF0", Offset = "0x6EACF0", VA = "0x1806EBEF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public BGOAEBFPKAN MCAPGJHFGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x65F410", Offset = "0x65E210", VA = "0x18065F410", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public LHNBKEDDAHF NJJHLCFOCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x694570", Offset = "0x693370", VA = "0x180694570", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public CGEDEAJAIJO CCKOPMBDMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x7133D0", Offset = "0x7121D0", VA = "0x1807133D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public ILOELKJEBPE MLFOPEGHEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x6C6550", Offset = "0x6C5350", VA = "0x1806C6550", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public IAEAFPAPBEN PCLFLCOGEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AF0", Offset = "0x6F38F0", VA = "0x1806F4AF0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public NFJLHIJFPAP JDCDOGHPFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x665A80", Offset = "0x664880", VA = "0x180665A80", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public NMCFLAICADE NPMGNJDOBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x6EBF00", Offset = "0x6EAD00", VA = "0x1806EBF00", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public EKMBBEOBHCH HENNOHLOEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x65AC30", Offset = "0x659A30", VA = "0x18065AC30", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public PEGFCDNOKHB ENMAJKJJAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x65ACF0", Offset = "0x659AF0", VA = "0x18065ACF0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public AHPBGKKBONO FBGBCINBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x74DCF0", Offset = "0x74CAF0", VA = "0x18074DCF0", Slot = "21")]
		get
		{
			return default(AHPBGKKBONO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x3404C30", Offset = "0x3403A30", VA = "0x183404C30", Slot = "22")]
	public void LHCOLCBEPCK(PGEEJALGCGE BPEEICHBHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x2469A70", Offset = "0x2468870", VA = "0x182469A70", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x3404F20", Offset = "0x3403D20", VA = "0x183404F20", Slot = "23")]
	public void PGNCABCBGBJ(PGEEJALGCGE BPEEICHBHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C1B90", Offset = "0x6C0990", VA = "0x1806C1B90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F28950", Offset = "0x3F27750", VA = "0x183F28950", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x6F1F00", Offset = "0x6F0D00", VA = "0x1806F1F00")]
		[DebuggerHidden]
		public JBAOOKJDFLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x3F287A0", Offset = "0x3F275A0", VA = "0x183F287A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x3F28910", Offset = "0x3F27710", VA = "0x183F28910", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x671970", Offset = "0x670770", VA = "0x180671970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x7047B0", Offset = "0x7035B0", VA = "0x1807047B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int FHFKECIMGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x704770", Offset = "0x703570", VA = "0x180704770")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x7047C0", Offset = "0x7035C0", VA = "0x1807047C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x3046680", Offset = "0x3045480", VA = "0x183046680")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x30468E0", Offset = "0x30456E0", VA = "0x1830468E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x3047030", Offset = "0x3045E30", VA = "0x183047030")]
	public HCOCICIBOHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x3046FA0", Offset = "0x3045DA0", VA = "0x183046FA0")]
	public HCOCICIBOHJ(int BMBMFEJNLIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x30463E0", Offset = "0x30451E0", VA = "0x1830463E0")]
	public bool EPJKFHCELEM(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x3046A90", Offset = "0x3045890", VA = "0x183046A90")]
	public bool IGNGFCONNFK(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x3046D40", Offset = "0x3045B40", VA = "0x183046D40")]
	public bool MGMFPFCGJEH(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x3046C10", Offset = "0x3045A10", VA = "0x183046C10")]
	public bool ILPKKNHIECH(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x3046210", Offset = "0x3045010", VA = "0x183046210")]
	public void BKABFKFJJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x3046DC0", Offset = "0x3045BC0", VA = "0x183046DC0")]
	public void NFMEJPNMIDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x3046EB0", Offset = "0x3045CB0", VA = "0x183046EB0")]
	public void NMFBOCJEJOB(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x3046770", Offset = "0x3045570", VA = "0x183046770")]
	public void GJPIAAEOJAL(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x3046B80", Offset = "0x3045980", VA = "0x183046B80")]
	public bool IICJGCDBNOO(int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x3046C20", Offset = "0x3045A20", VA = "0x183046C20")]
	public void MCEAPOJGNOA(int HPNBOGMLOLG, int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x30464C0", Offset = "0x30452C0", VA = "0x1830464C0")]
	public void FBHHBCLDNAO(int BEFJFPBKMMC, int DFFNEOCPAMF, int CGKKILDEEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x30462A0", Offset = "0x30450A0", VA = "0x1830462A0")]
	public int ELGBPIMHCCH(int CGKKILDEEIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x3046370", Offset = "0x3045170", VA = "0x183046370")]
	public int ELGBPIMHCCH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x3046720", Offset = "0x3045520", VA = "0x183046720")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x3046870", Offset = "0x3045670", VA = "0x183046870", Slot = "4")]
	[IteratorStateMachine(typeof(JBAOOKJDFLK))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x3046870", Offset = "0x3045670", VA = "0x183046870", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x1A89F80", Offset = "0x1A88D80", VA = "0x181A89F80")]
	public OOMMCEBOHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x3840930", Offset = "0x383F730", VA = "0x183840930")]
	public OOMMCEBOHAF(global::KOEPKCJHKNK<T> KKIKIOMPACD, global::EJMMMBCHJMF<T> KMACGJHLGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x38405F0", Offset = "0x383F3F0", VA = "0x1838405F0", Slot = "11")]
	public override T MNOLKCHHLIP(FBLOOANMBAP MGAGEIKHIFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x3840240", Offset = "0x383F040", VA = "0x183840240", Slot = "12")]
	public override void CLPGJOCDFOA(FBLOOANMBAP MGAGEIKHIFC, T GKFICKKHACC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class HGBADOGMCEE
{
	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A070", Offset = "0x2D88E70", VA = "0x182D8A070")]
	public static EBLKGKAPHAO EHMHLLLMBAF<T>(this ICLHPLIDGLM HFDCOKODHFK, global::GPAKIDKFMKC<T> NLCIGFDKGEE, global::KOEPKCJHKNK<T> KKIKIOMPACD, global::EJMMMBCHJMF<T> KMACGJHLGJP) where T : struct
	{
		return default(EBLKGKAPHAO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class NOBMNNBKCMN<T> : global::OOMMCEBOHAF<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2BEAF90", Offset = "0x2BE9D90", VA = "0x182BEAF90")]
	public NOBMNNBKCMN(T HKPINKIDAGP, T MFHJKPMAGKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class IHOBDKFOEBC<T> : global::EIEGCCEOGGL<T> where T : struct, HHCBFJCPHFB
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x1F3AA90", Offset = "0x1F39890", VA = "0x181F3AA90", Slot = "11")]
	public override T MNOLKCHHLIP(FBLOOANMBAP MGAGEIKHIFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x1F3AA20", Offset = "0x1F39820", VA = "0x181F3AA20", Slot = "12")]
	public override void CLPGJOCDFOA(FBLOOANMBAP MGAGEIKHIFC, T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x1F3AB40", Offset = "0x1F39940", VA = "0x181F3AB40")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x331C4F0", Offset = "0x331B2F0", VA = "0x18331C4F0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x331BC00", Offset = "0x331AA00", VA = "0x18331BC00", Slot = "8")]
	public override void MNOLKCHHLIP(FBLOOANMBAP MGAGEIKHIFC, in PMECDNBONOH EHPFANFOFFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x331A050", Offset = "0x3318E50", VA = "0x18331A050", Slot = "9")]
	public override void CLPGJOCDFOA(FBLOOANMBAP MGAGEIKHIFC, in EKBGHCIKEGG GPNGGDGNOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x331A970", Offset = "0x3319770", VA = "0x18331A970", Slot = "10")]
	public override void KGEJHADOBPB(FBLOOANMBAP MGAGEIKHIFC, OGMHHGNLNGH EHGIDPAFOKH, object EDPENIGJGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x176B080", Offset = "0x1769E80", VA = "0x18176B080")]
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
			[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
			public PEDGLIHIKJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x306DA10", Offset = "0x306C810", VA = "0x18306DA10")]
			internal void <RegisterFixedString>b__0(FBLOOANMBAP p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x306DBE0", Offset = "0x306C9E0", VA = "0x18306DBE0")]
			internal T <RegisterFixedString>b__1(FBLOOANMBAP p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AE40", Offset = "0x3F29C40", VA = "0x183F2AE40")]
		public static void PCEGIKFNJKA(EIIGGLKHNAH DKBHOLHDIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x2C98A50", Offset = "0x2C97850", VA = "0x182C98A50")]
		private static void CBMPDEDBMCG<T>(EIIGGLKHNAH DKBHOLHDIDD, int MFHJKPMAGKE) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x2C98B70", Offset = "0x2C97970", VA = "0x182C98B70")]
		private static void CEIBFOEDIGH<T>(FBLOOANMBAP KNNJFFBFLLC, T MINMGIMIPFB, int MFHJKPMAGKE) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x2C98C00", Offset = "0x2C97A00", VA = "0x182C98C00")]
		private static T LAKJHLDIICJ<T>(FBLOOANMBAP KNNJFFBFLLC, int MFHJKPMAGKE) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C85E80", Offset = "0x2C84C80", VA = "0x182C85E80", Slot = "6")]
		public override void ICHOEHPKEKD<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x3F23470", Offset = "0x3F22270", VA = "0x183F23470")]
		public static void IIJFNGOBNPM(EIIGGLKHNAH DKBHOLHDIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x3F23520", Offset = "0x3F22320", VA = "0x183F23520")]
		public DCLJHIPKAGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x3052720", Offset = "0x3051520", VA = "0x183052720")]
	public static void COKFLBGGNAI(EIIGGLKHNAH DKBHOLHDIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x42DDC20", Offset = "0x42DCA20", VA = "0x1842DDC20")]
	public static void FNKCDMPNLLG<T>(EIIGGLKHNAH DKBHOLHDIDD, global::KOEPKCJHKNK<T> KKIKIOMPACD, global::EJMMMBCHJMF<T> KMACGJHLGJP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x42DDCB0", Offset = "0x42DCAB0", VA = "0x1842DDCB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x304DBF0", Offset = "0x304C9F0", VA = "0x18304DBF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x77EBA0", Offset = "0x77D9A0", VA = "0x18077EBA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x77EC20", Offset = "0x77DA20", VA = "0x18077EC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x3030150", Offset = "0x302EF50", VA = "0x183030150")]
	public PKNAOIDMDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x30301D0", Offset = "0x302EFD0", VA = "0x1830301D0")]
	public PKNAOIDMDLB(Dictionary<EBLKGKAPHAO, OBKJCEBKCCG> DKBHOLHDIDD, bool KMKNMACIINI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x3030010", Offset = "0x302EE10", VA = "0x183030010", Slot = "7")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x302FA10", Offset = "0x302E810", VA = "0x18302FA10", Slot = "8")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x302FEF0", Offset = "0x302ECF0", VA = "0x18302FEF0", Slot = "9")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x302FF40", Offset = "0x302ED40", VA = "0x18302FF40", Slot = "4")]
	public EBLKGKAPHAO IDLNJNJGIMG(PMBKKKKDOIF NLCIGFDKGEE)
	{
		return default(EBLKGKAPHAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x302FA90", Offset = "0x302E890", VA = "0x18302FA90", Slot = "5")]
	public void EHMHLLLMBAF(EBLKGKAPHAO GLGEGPNMJGF, OBKJCEBKCCG HCCBCGGLKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x302FC00", Offset = "0x302EA00", VA = "0x18302FC00")]
	[Conditional("DEBUG_BUILD")]
	private void FAJLMHNAGLP(EBLKGKAPHAO GLGEGPNMJGF, Type BIEGICDMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x302FD40", Offset = "0x302EB40", VA = "0x18302FD40", Slot = "6")]
	public bool GIGGJMBFKKD(EBLKGKAPHAO GLGEGPNMJGF, out OBKJCEBKCCG HCCBCGGLKDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x3030070", Offset = "0x302EE70", VA = "0x183030070", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x726EF0", Offset = "0x725CF0", VA = "0x180726EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x786A00", Offset = "0x785800", VA = "0x180786A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x32BAAB0", Offset = "0x32B98B0", VA = "0x1832BAAB0")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x32BAB30", Offset = "0x32B9930", VA = "0x1832BAB30")]
		public TypeSerializerService(Dictionary<Type, OBKJCEBKCCG> DKBHOLHDIDD, bool KMKNMACIINI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x32BA920", Offset = "0x32B9720", VA = "0x1832BA920", Slot = "4")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x32BA720", Offset = "0x32B9520", VA = "0x1832BA720", Slot = "5")]
		public void EHMHLLLMBAF(Type BIEGICDMJCM, OBKJCEBKCCG HCCBCGGLKDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x32BA840", Offset = "0x32B9640", VA = "0x1832BA840", Slot = "6")]
		public bool GIGGJMBFKKD(Type BIEGICDMJCM, out OBKJCEBKCCG HCCBCGGLKDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x32BA980", Offset = "0x32B9780", VA = "0x1832BA980", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x304CFF0", Offset = "0x304BDF0", VA = "0x18304CFF0", Slot = "6")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x304CF20", Offset = "0x304BD20", VA = "0x18304CF20", Slot = "7")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x304CF80", Offset = "0x304BD80", VA = "0x18304CF80", Slot = "4")]
	public void EHMHLLLMBAF(EBLKGKAPHAO KBPOLLDMHFK, Type MEEEBFGFJIC, FIJPOFPCCDH FDCFGEMPDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x304D040", Offset = "0x304BE40", VA = "0x18304D040", Slot = "5")]
	public bool LOMOOEPGEHH(EBLKGKAPHAO KBPOLLDMHFK, out FIJPOFPCCDH FDCFGEMPDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x304D0B0", Offset = "0x304BEB0", VA = "0x18304D0B0")]
	[Conditional("DEBUG_BUILD")]
	private void PLNKIKBCAFD(EBLKGKAPHAO KBPOLLDMHFK, Type MEEEBFGFJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x304D240", Offset = "0x304C040", VA = "0x18304D240")]
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
		[Cpp2IlInjected.Address(RVA = "0x30472E0", Offset = "0x30460E0", VA = "0x1830472E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool PAOBNFNAFOL
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x652C20", Offset = "0x651A20", VA = "0x180652C20", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x652CA0", Offset = "0x651AA0", VA = "0x180652CA0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x3047330", Offset = "0x3046130", VA = "0x183047330", Slot = "6")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x3047260", Offset = "0x3046060", VA = "0x183047260", Slot = "7")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x30479A0", Offset = "0x30467A0", VA = "0x1830479A0", Slot = "8")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x30475B0", Offset = "0x30463B0", VA = "0x1830475B0")]
	private void MIOLDPOLFFJ(IOBECAADPPL DKHOCCDNDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x3047470", Offset = "0x3046270", VA = "0x183047470", Slot = "4")]
	public bool KOAHOMJNFEJ(ELJHNEOGEBP FFJHOAAMJMD, EBLKGKAPHAO GCEENFOFNFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x3047650", Offset = "0x3046450", VA = "0x183047650", Slot = "5")]
	public void NOLBIPGMLAM(ELJHNEOGEBP FFJHOAAMJMD, Span<EBLKGKAPHAO> HFDCOKODHFK, bool CAALOIGDJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x3047330", Offset = "0x3046130", VA = "0x183047330", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x3047A50", Offset = "0x3046850", VA = "0x183047A50")]
	public HHCPEIACMND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class OIKFOKDBOGO
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x301ED40", Offset = "0x301DB40", VA = "0x18301ED40")]
	public static void PKLJJAPFDPK(this FBLOOANMBAP MGAGEIKHIFC, ReadOnlyMemory<byte> BFIOPBMAOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x3253360", Offset = "0x3252160", VA = "0x183253360")]
	public static void FEBNLFJNNAM<T>(this FBLOOANMBAP MGAGEIKHIFC, in T GKFICKKHACC) where T : struct, HHCBFJCPHFB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x32531E0", Offset = "0x3251FE0", VA = "0x1832531E0")]
	public static T DOOCBKLHJBN<T>(this FBLOOANMBAP MGAGEIKHIFC) where T : struct, HHCBFJCPHFB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x301EA40", Offset = "0x301D840", VA = "0x18301EA40")]
	public static void FEBNLFJNNAM(this FBLOOANMBAP MGAGEIKHIFC, BCHEGBBHMEO LNPKKMJLCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x301EA10", Offset = "0x301D810", VA = "0x18301EA10")]
	public static BCHEGBBHMEO DDCCAFKGJCD(this FBLOOANMBAP MGAGEIKHIFC)
	{
		return default(BCHEGBBHMEO);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x301EB90", Offset = "0x301D990", VA = "0x18301EB90")]
	public static void MEAKJGFCKDP(this FBLOOANMBAP FHGALIAOBLC, uint PCEDODOJPPO, bool PPGBONBHODL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x301EA70", Offset = "0x301D870", VA = "0x18301EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public MLAACEJHHGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x28BF260", Offset = "0x28BE060", VA = "0x1828BF260")]
		internal void <GetByteEnumDelegates>b__0(FBLOOANMBAP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x28BF2D0", Offset = "0x28BE0D0", VA = "0x1828BF2D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public KLNLKPNHDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x35FC320", Offset = "0x35FB120", VA = "0x1835FC320")]
		internal void <GetSByteEnumDelegates>b__0(FBLOOANMBAP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x35FC390", Offset = "0x35FB190", VA = "0x1835FC390")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public HCCJONPLGIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x38252F0", Offset = "0x38240F0", VA = "0x1838252F0")]
		internal void <GetShortEnumDelegates>b__0(FBLOOANMBAP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x3825360", Offset = "0x3824160", VA = "0x183825360")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public MMMPKBFEKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x3783B20", Offset = "0x3782920", VA = "0x183783B20")]
		internal void <GetUShortEnumDelegates>b__0(FBLOOANMBAP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x3783B90", Offset = "0x3782990", VA = "0x183783B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public MOIEFPBJCGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x3787740", Offset = "0x3786540", VA = "0x183787740")]
		internal void <GetIntEnumDelegates>b__0(FBLOOANMBAP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x37877A0", Offset = "0x37865A0", VA = "0x1837877A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1767C30", Offset = "0x1766A30", VA = "0x181767C30")]
		public OIFNEKNNAEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x2F216D0", Offset = "0x2F204D0", VA = "0x182F216D0")]
		internal void <GetUIntEnumDelegates>b__0(FBLOOANMBAP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x2F21730", Offset = "0x2F20530", VA = "0x182F21730")]
		internal T <GetUIntEnumDelegates>b__1(FBLOOANMBAP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x28EFBF0", Offset = "0x28EE9F0", VA = "0x1828EFBF0")]
	public static void CFMBDIBIHIL<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x28EFAA0", Offset = "0x28EE8A0", VA = "0x1828EFAA0")]
	private static void PLJEGKMDGCH<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x28EFAA0", Offset = "0x28EE8A0", VA = "0x1828EFAA0")]
	private static void AJKBDINGFBB<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x28EFE10", Offset = "0x28EEC10", VA = "0x1828EFE10")]
	private static void GCKNMCNOIBL<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x28EFE10", Offset = "0x28EEC10", VA = "0x1828EFE10")]
	private static void JECKFBIKEMO<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x28EFF60", Offset = "0x28EED60", VA = "0x1828EFF60")]
	private static void IDCMMGBKBFD<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x28EFF60", Offset = "0x28EED60", VA = "0x1828EFF60")]
	private static void HPBKJEKEJED<T>(T HKPINKIDAGP, T MFHJKPMAGKE, out global::KOEPKCJHKNK<T> BCCEFKJMPEN, out global::EJMMMBCHJMF<T> CDCJPCELGDF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class PJFPOHADGAA : OCCCFKPBJLI, HMFGCABFMPC
{
	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x302F120", Offset = "0x302DF20", VA = "0x18302F120", Slot = "4")]
	private void GLLDHAGLBII(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void NPHPEAODLEE(ICLHPLIDGLM HFDCOKODHFK);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
	protected PJFPOHADGAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[IAAENPILNCG(typeof(LocalPoseData))]
public sealed class IMPCAMFCJPE : PJFPOHADGAA
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x304F010", Offset = "0x304DE10", VA = "0x18304F010", Slot = "5")]
	protected override void NPHPEAODLEE(ICLHPLIDGLM HFDCOKODHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3417020", Offset = "0x3415E20", VA = "0x183417020", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x3417CF0", Offset = "0x3416AF0", VA = "0x183417CF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x3417E70", Offset = "0x3416C70", VA = "0x183417E70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x3417E40", Offset = "0x3416C40", VA = "0x183417E40", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x3417090", Offset = "0x3415E90", VA = "0x183417090")]
		private void DGOCIDGHHOD(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x3417A70", Offset = "0x3416870", VA = "0x183417A70")]
		private void NHFGIFBKIPO(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x3417580", Offset = "0x3416380", VA = "0x183417580")]
		private void HKEJDJCHHIA(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x34173D0", Offset = "0x34161D0", VA = "0x1834173D0")]
		private void HCEKFJKKBNP(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x3417860", Offset = "0x3416660", VA = "0x183417860")]
		private void HLOAMEGFIMO(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x3417C10", Offset = "0x3416A10", VA = "0x183417C10")]
		private void OHKEONNPAJJ(IOBECAADPPL DKHOCCDNDOH, int DEPHGHGHIPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x341BD50", Offset = "0x341AB50", VA = "0x18341BD50", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x341C380", Offset = "0x341B180", VA = "0x18341C380", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x341C440", Offset = "0x341B240", VA = "0x18341C440", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x341BDA0", Offset = "0x341ABA0", VA = "0x18341BDA0")]
	private void EEFGJMDDOPD(NativeArray<Entity> FNMNPGEEPJI, NativeList<Entity> PDDBOFHMBMM, ComponentDataFromEntity<PMLDECKNLAK> ACFBIJBMEBF, BufferFromEntity<ChildrenData> PIJKPDLNMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public DJFNNCLBNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class AOMEGDGACFG : ParentSystemBase<AuthoredParentData, JGHIKCNOOHM, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x34060C0", Offset = "0x3404EC0", VA = "0x1834060C0", Slot = "14")]
	protected override EntityQueryDesc KMNFJOOCPJF(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x7BBCA0", Offset = "0x7BAAA0", VA = "0x1807BBCA0", Slot = "15")]
	protected override EntityQueryDesc DFGBELAPBIC(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x3406100", Offset = "0x3404F00", VA = "0x183406100", Slot = "16")]
	protected override EntityQueryDesc OIHMCIJFFBN(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x3406080", Offset = "0x3404E80", VA = "0x183406080", Slot = "17")]
	protected override EntityQueryDesc BECNHEEIAMJ(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x3406180", Offset = "0x3404F80", VA = "0x183406180")]
	public AOMEGDGACFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x3406140", Offset = "0x3404F40", VA = "0x183406140", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x304F660", Offset = "0x304E460", VA = "0x18304F660", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x304F6E0", Offset = "0x304E4E0", VA = "0x18304F6E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x304F780", Offset = "0x304E580", VA = "0x18304F780", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public JBECNIGAKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3020790", Offset = "0x301F590", VA = "0x183020790", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x3020810", Offset = "0x301F610", VA = "0x183020810", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x30208B0", Offset = "0x301F6B0", VA = "0x1830208B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public OLDKIADPBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x340DE00", Offset = "0x340CC00", VA = "0x18340DE00", Slot = "4")]
	public bool Equals(CJBDKPMJKHI MCLIMJFDMCF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x6949A0", Offset = "0x6937A0", VA = "0x1806949A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6949A0", Offset = "0x6937A0", VA = "0x1806949A0")]
	public static ABOJJOFDAAP KPOCFOKDNEC(CAOPLFMILCI DKBLPJPHEMF)
	{
		return default(ABOJJOFDAAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal abstract class DCNGCHEELNJ : DEFANIGDOCO
{
	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x341AF20", Offset = "0x3419D20", VA = "0x18341AF20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x341B0B0", Offset = "0x3419EB0", VA = "0x18341B0B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	protected DCNGCHEELNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x341B150", Offset = "0x3419F50", VA = "0x18341B150", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x341B4B0", Offset = "0x341A2B0", VA = "0x18341B4B0")]
	protected void FAGNKKJNMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x341B1C0", Offset = "0x3419FC0", VA = "0x18341B1C0")]
	protected void CEODBMIDNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x341B440", Offset = "0x341A240", VA = "0x18341B440")]
	protected CDDJMIAEBFF DDKJCHDPEGP()
	{
		return default(CDDJMIAEBFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	protected DEFANIGDOCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal abstract class PAGNJFPAGMD : DEFANIGDOCO
{
	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x302CD10", Offset = "0x302BB10", VA = "0x18302CD10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x302CEA0", Offset = "0x302BCA0", VA = "0x18302CEA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x301EE30", Offset = "0x301DC30", VA = "0x18301EE30")]
	protected PAGNJFPAGMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class BCNNBBKJPNE : DEFANIGDOCO
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x34082C0", Offset = "0x34070C0", VA = "0x1834082C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x34083D0", Offset = "0x34071D0", VA = "0x1834083D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	protected BCNNBBKJPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x341EE90", Offset = "0x341DC90", VA = "0x18341EE90", Slot = "15")]
		get
		{
			return default(OGNKEIDFOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public EBBOAOMMADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3420470", Offset = "0x341F270", VA = "0x183420470", Slot = "15")]
		get
		{
			return default(OGNKEIDFOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x34204E0", Offset = "0x341F2E0", VA = "0x1834204E0")]
	public EOIJLLNMIFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x301EE30", Offset = "0x301DC30", VA = "0x18301EE30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3042140", Offset = "0x3040F40", VA = "0x183042140", Slot = "15")]
		get
		{
			return default(OGNKEIDFOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x301EE30", Offset = "0x301DC30", VA = "0x18301EE30")]
	public FCEKFGEMPPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x301EDC0", Offset = "0x301DBC0", VA = "0x18301EDC0", Slot = "15")]
		get
		{
			return default(OGNKEIDFOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x301EE30", Offset = "0x301DC30", VA = "0x18301EE30")]
	public OIMKMPBGEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x301EE40", Offset = "0x301DC40", VA = "0x18301EE40", Slot = "15")]
		get
		{
			return default(OGNKEIDFOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x301EE30", Offset = "0x301DC30", VA = "0x18301EE30")]
	public OJGMPNNGNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3404F40", Offset = "0x3403D40", VA = "0x183404F40", Slot = "15")]
		get
		{
			return default(OGNKEIDFOOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public AKGPFJGHMAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x301E9F0", Offset = "0x301D7F0", VA = "0x18301E9F0")]
	public OGNKEIDFOOL(ComponentType DIIJEEFKGBP, ComponentType OKDNGJDIOCM, object JJFHDFJGCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x3252B00", Offset = "0x3251900", VA = "0x183252B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6945A0", Offset = "0x6933A0", VA = "0x1806945A0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x695E20", Offset = "0x694C20", VA = "0x180695E20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public int BDCBCEKMBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x6CF8F0", Offset = "0x6CE6F0", VA = "0x1806CF8F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x6CF900", Offset = "0x6CE700", VA = "0x1806CF900", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool ILPKKNHIECH
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x340DE50", Offset = "0x340CC50", VA = "0x18340DE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x340DE00", Offset = "0x340CC00", VA = "0x18340DE00", Slot = "8")]
	public bool Equals(CAOPLFMILCI MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x340DE90", Offset = "0x340CC90", VA = "0x18340DE90", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F27C30", Offset = "0x3F26A30", VA = "0x183F27C30")]
			public HJFBICMAOFP(CAOPLFMILCI DKBLPJPHEMF, float3 DKGAADMNOOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x3F27C10", Offset = "0x3F26A10", VA = "0x183F27C10")]
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
			[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
			public LKPPFFJDOIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
			public OMLNAGLAPPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
			public EJPLNNGHJAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F22E80", Offset = "0x3F21C80", VA = "0x183F22E80")]
				public void GKLJKDAGGIM(UpdateConnectableVisuals GFHLMIDFMDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077E")]
				[Cpp2IlInjected.Address(RVA = "0x3F22F00", Offset = "0x3F21D00", VA = "0x183F22F00")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F28220", Offset = "0x3F27020", VA = "0x183F28220")]
			internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, WorldPoseData MBHPMANAMCC, in DynamicBuffer<ABOJJOFDAAP> OPCGPJFHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x3F28730", Offset = "0x3F27530", VA = "0x183F28730", Slot = "5")]
			public void ReadFromDisplayClass(ref LKPPFFJDOIG LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x3F28760", Offset = "0x3F27560", VA = "0x183F28760", Slot = "6")]
			public void WriteToDisplayClass(ref LKPPFFJDOIG LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x3F28460", Offset = "0x3F27260", VA = "0x183F28460", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x3F285F0", Offset = "0x3F273F0", VA = "0x183F285F0")]
			public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, ref CPKHLLCOGMI.PKLKGGPDPJE FAHLNAJJNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x3F285B0", Offset = "0x3F273B0", VA = "0x183F285B0")]
			public void GKLJKDAGGIM(UpdateConnectableVisuals GFHLMIDFMDH, ref LKPPFFJDOIG LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x3F28540", Offset = "0x3F27340", VA = "0x183F28540")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F28C10", Offset = "0x3F27A10", VA = "0x183F28C10")]
				public void GKLJKDAGGIM(UpdateConnectableVisuals GFHLMIDFMDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x3F28C80", Offset = "0x3F27A80", VA = "0x183F28C80")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F27ED0", Offset = "0x3F26CD0", VA = "0x183F27ED0")]
			internal void CCKNMJAJJNM(in WorldPoseData MBHPMANAMCC, in DynamicBuffer<CJBDKPMJKHI> OPCGPJFHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0xC85E70", Offset = "0xC84C70", VA = "0x180C85E70", Slot = "5")]
			public void ReadFromDisplayClass(ref OMLNAGLAPPG LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x3F27FE0", Offset = "0x3F26DE0", VA = "0x183F27FE0", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x3F28150", Offset = "0x3F26F50", VA = "0x183F28150")]
			public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref JPOLAHEONJM.HDEABFCMPFH FAHLNAJJNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x3F280B0", Offset = "0x3F26EB0", VA = "0x183F280B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F2BEC0", Offset = "0x3F2ACC0", VA = "0x183F2BEC0")]
				public void GKLJKDAGGIM(UpdateConnectableVisuals GFHLMIDFMDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0x3F2BF50", Offset = "0x3F2AD50", VA = "0x183F2BF50")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F20990", Offset = "0x3F1F790", VA = "0x183F20990")]
			internal void CCKNMJAJJNM(in WorldPoseData MBHPMANAMCC, in JIHAIGKEFFM IHNEPFIEBPB, in DynamicBuffer<CJBDKPMJKHI> OPCGPJFHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0xC85E70", Offset = "0xC84C70", VA = "0x180C85E70", Slot = "5")]
			public void ReadFromDisplayClass(ref EJPLNNGHJAJ LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x3F20AF0", Offset = "0x3F1F8F0", VA = "0x183F20AF0", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x3F20BB0", Offset = "0x3F1F9B0", VA = "0x183F20BB0")]
			public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref POPLMFCBMON.LEGDHPLDAFM FAHLNAJJNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x3F20B70", Offset = "0x3F1F970", VA = "0x183F20B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x32BBF30", Offset = "0x32BAD30", VA = "0x1832BBF30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x32BF500", Offset = "0x32BE300", VA = "0x1832BF500")]
		internal FELBJINOHJJ PHFMJGEGBPP(CAOPLFMILCI DKBLPJPHEMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x32BB120", Offset = "0x32B9F20", VA = "0x1832BB120", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x32BE910", Offset = "0x32BD710", VA = "0x1832BE910", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x32BEB90", Offset = "0x32BD990", VA = "0x1832BEB90", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x32BED20", Offset = "0x32BDB20", VA = "0x1832BED20", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x32BEB50", Offset = "0x32BD950", VA = "0x1832BEB50", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x32BD330", Offset = "0x32BC130", VA = "0x1832BD330")]
		private void IGFJBPFNBIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x32BD1E0", Offset = "0x32BBFE0", VA = "0x1832BD1E0")]
		private void IDJKKMDOOON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x32BCD60", Offset = "0x32BBB60", VA = "0x1832BCD60")]
		private void GGLHAALBKNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x32BED60", Offset = "0x32BDB60", VA = "0x1832BED60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x32BE2D0", Offset = "0x32BD0D0", VA = "0x1832BE2D0")]
		private void LPIFGEKCIOM(EntityQuery JENEOMCAPBE, EntityQuery IPFHHMKILIK, EntityQuery AKCGHHEOAEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x32BBF70", Offset = "0x32BAD70", VA = "0x1832BBF70")]
		private void DOHHNJJEEIG(EntityQuery AKCGHHEOAEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x32BC970", Offset = "0x32BB770", VA = "0x1832BC970")]
		private void GABJCONFNNC(global::GHKNLLBEIFC<Entity> MFMIPEIFDHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x32BCC50", Offset = "0x32BBA50", VA = "0x1832BCC50")]
		private void GBBEBPJADGG(global::GHKNLLBEIFC<Entity> PADGGACIMJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x32BDCD0", Offset = "0x32BCAD0", VA = "0x1832BDCD0")]
		private void KHMNLNKEMON(global::GHKNLLBEIFC<Entity> BJKHIAGLNJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x32BBDC0", Offset = "0x32BABC0", VA = "0x1832BBDC0")]
		private void CGGEMMFGCPF(NativeList<CAOPLFMILCI> GLFECICOPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x32BB470", Offset = "0x32BA270", VA = "0x1832BB470")]
		private NativeList<CAOPLFMILCI> AJAAJILMKGH(NativeArray<Entity> FNMNPGEEPJI)
		{
			return default(NativeList<CAOPLFMILCI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x32BD6B0", Offset = "0x32BC4B0", VA = "0x1832BD6B0")]
		private void JGINBGNCPCF(NativeArray<Entity> FNMNPGEEPJI, NativeList<CAOPLFMILCI> GLFECICOPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x32BEE90", Offset = "0x32BDC90", VA = "0x1832BEE90")]
		private void PCJAFBJIGEK(NativeArray<Entity> INCNBPCPOJH, NativeArray<Entity> KDFKCICKCCF, NativeList<CAOPLFMILCI> CKGPGEGHFJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x32BC040", Offset = "0x32BAE40", VA = "0x1832BC040")]
		private void EJJIHPMNHNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x32BBAC0", Offset = "0x32BA8C0", VA = "0x1832BBAC0")]
		private global::BNGAOKMFDEK<HJFBICMAOFP> BDOPCPLFDHJ(EntityQuery NJIBLOIMOJA, Func<NativeList<HJFBICMAOFP>, JobHandle> NJJKEPCLKGP)
		{
			return default(global::BNGAOKMFDEK<HJFBICMAOFP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x32BC550", Offset = "0x32BB350", VA = "0x1832BC550")]
		private JobHandle FCLDNEMJKLM(NativeList<HJFBICMAOFP> LENGKEKMOEB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x32BF3C0", Offset = "0x32BE1C0", VA = "0x1832BF3C0")]
		private JobHandle PDPIPHHDHHC(NativeList<HJFBICMAOFP> LENGKEKMOEB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x32BB990", Offset = "0x32BA790", VA = "0x1832BB990")]
		private JobHandle BCGEKKIDDNC(NativeList<HJFBICMAOFP> LENGKEKMOEB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x32BB1E0", Offset = "0x32B9FE0", VA = "0x1832BB1E0")]
		private void ADEGEJLALMK(global::BNGAOKMFDEK<HJFBICMAOFP> LENGKEKMOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x32BC6E0", Offset = "0x32BB4E0", VA = "0x1832BC6E0")]
		private void FEMPCINJBIC(global::BNGAOKMFDEK<HJFBICMAOFP> LENGKEKMOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x32BC4F0", Offset = "0x32BB2F0", VA = "0x1832BC4F0")]
		private bool FCCKCMOGGAC(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x32BD110", Offset = "0x32BBF10", VA = "0x1832BD110")]
		private NativeArray<Entity> HHFIOGJMHGI(Entity LLEBIIAHFDD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x32BBC00", Offset = "0x32BAA00", VA = "0x1832BBC00")]
		private CAOPLFMILCI BPLIBEFCEAF(NativeList<CAOPLFMILCI> CKGPGEGHFJA)
		{
			return default(CAOPLFMILCI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x32BF550", Offset = "0x32BE350", VA = "0x1832BF550")]
		private void PKCODKNDIEH(CAOPLFMILCI DKBLPJPHEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x32BE7B0", Offset = "0x32BD5B0", VA = "0x1832BE7B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x32BDE70", Offset = "0x32BCC70", VA = "0x1832BDE70")]
		public static EntityQuery KMEHOPINACO(ComponentSystemBase GFHLMIDFMDH)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x32BE070", Offset = "0x32BCE70", VA = "0x1832BE070")]
		public static EntityQuery LMKKLBPJKDL(ComponentSystemBase GFHLMIDFMDH)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x32BD440", Offset = "0x32BC240", VA = "0x1832BD440")]
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
		[Cpp2IlInjected.Address(RVA = "0x30366C0", Offset = "0x30354C0", VA = "0x1830366C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x3036630", Offset = "0x3035430", VA = "0x183036630", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x30367C0", Offset = "0x30355C0", VA = "0x1830367C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public BIAPBKCCAGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x6EED00", Offset = "0x6EDB00", VA = "0x1806EED00")]
	public BIAPBKCCAGM(IAEGHKEFOHF DPCGPJIEFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x3409210", Offset = "0x3408010", VA = "0x183409210", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x30421B0", Offset = "0x3040FB0", VA = "0x1830421B0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x3042210", Offset = "0x3041010", VA = "0x183042210", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x3042240", Offset = "0x3041040", VA = "0x183042240", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	protected FCHHBIADLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x305A7D0", Offset = "0x30595D0", VA = "0x18305A7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int HBEHIIKMMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x305A540", Offset = "0x3059340", VA = "0x18305A540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x305A4E0", Offset = "0x30592E0", VA = "0x18305A4E0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x305ABA0", Offset = "0x30599A0", VA = "0x18305ABA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x305ADA0", Offset = "0x3059BA0", VA = "0x18305ADA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x305AB80", Offset = "0x3059980", VA = "0x18305AB80")]
	public int OIMLPEECHCL(SceneTag IEGFBJCKFAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x305A5F0", Offset = "0x30593F0", VA = "0x18305A5F0")]
	public int DFKHICOABHK(SceneTag IEGFBJCKFAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x305A960", Offset = "0x3059760", VA = "0x18305A960")]
	protected void NIPAKIJLNID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x305A850", Offset = "0x3059650", VA = "0x18305A850")]
	protected void LIOIFCBKAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x305A5A0", Offset = "0x30593A0", VA = "0x18305A5A0")]
	public global::GHKNLLBEIFC<Entity> CFCDBAGNCHM(SceneTag IEGFBJCKFAP, Allocator PBEDBDBGIPF = Allocator.TempJob)
	{
		return default(global::GHKNLLBEIFC<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x305A550", Offset = "0x3059350", VA = "0x18305A550")]
	public global::GHKNLLBEIFC<Entity> CEMDAALKEKD(SceneTag IEGFBJCKFAP, Allocator PBEDBDBGIPF = Allocator.TempJob)
	{
		return default(global::GHKNLLBEIFC<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x305A6E0", Offset = "0x30594E0", VA = "0x18305A6E0")]
	public bool FPMPGMBNCIH(SceneTag IEGFBJCKFAP, out global::GHKNLLBEIFC<Entity> DPCGPJIEFDH, Allocator PBEDBDBGIPF = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x305A610", Offset = "0x3059410", VA = "0x18305A610")]
	public bool FEOLDMHKLBA(Entity LLEBIIAHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x305A670", Offset = "0x3059470", VA = "0x18305A670")]
	public IAEGHKEFOHF FPCGIAGCFMP(Entity LLEBIIAHFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x305A7E0", Offset = "0x30595E0", VA = "0x18305A7E0")]
	public bool LFCLKAMJJHD(Entity LLEBIIAHFDD, out BIAPBKCCAGM DPCGPJIEFDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x305ADC0", Offset = "0x3059BC0", VA = "0x18305ADC0")]
	public void PLNMOHEFKNP(Entity LLEBIIAHFDD, BIAPBKCCAGM DPCGPJIEFDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x305A770", Offset = "0x3059570", VA = "0x18305A770")]
	public bool IJLCDGHNMAI(Entity LLEBIIAHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void JJMEBKCFFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public LKENFMAMPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x304FA00", Offset = "0x304E800", VA = "0x18304FA00", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x304FAC0", Offset = "0x304E8C0", VA = "0x18304FAC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x304FB80", Offset = "0x304E980", VA = "0x18304FB80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x28EECE0", Offset = "0x28EDAE0", VA = "0x1828EECE0")]
	private bool KFPEIBMAEHO<TComponentData>(EntityQuery NJIBLOIMOJA, out NativeArray<Entity> FNMNPGEEPJI, out NativeArray<TComponentData> ECOKHAGGAGC) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x304FA50", Offset = "0x304E850", VA = "0x18304FA50")]
	public IAEGHKEFOHF FPCGIAGCFMP(Entity LLEBIIAHFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public JFDLIDANCMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x32B05B0", Offset = "0x32AF3B0", VA = "0x1832B05B0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x32B0A40", Offset = "0x32AF840", VA = "0x1832B0A40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x32B0C70", Offset = "0x32AFA70", VA = "0x1832B0C70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x32B0670", Offset = "0x32AF470", VA = "0x1832B0670")]
		private void ELGBPIMHCCH(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x32B0600", Offset = "0x32AF400", VA = "0x1832B0600")]
		private void DOHHNJJEEIG(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x32B0C00", Offset = "0x32AFA00", VA = "0x1832B0C00", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x32B06E0", Offset = "0x32AF4E0", VA = "0x1832B06E0")]
		private void MAGDOKEIOLO(EntityQuery NJIBLOIMOJA, bool FAGHFMDMOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		public BCGFLCINPFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F27C50", Offset = "0x3F26A50", VA = "0x183F27C50")]
			public void GKLJKDAGGIM(OCFBAMKGADC GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x3F27CD0", Offset = "0x3F26AD0", VA = "0x183F27CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F29BF0", Offset = "0x3F289F0", VA = "0x183F29BF0")]
		internal void CCKNMJAJJNM(Entity DKJMIMOCJNG, SplineShapeData KBICBGPAOHG, DynamicBuffer<LinkedEntityGroup> NFMJIELOGNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F29C50", Offset = "0x3F28A50", VA = "0x183F29C50", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x3F29D30", Offset = "0x3F28B30", VA = "0x183F29D30")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref ICNIOPCAAPG.INAEPEIDOMM FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F29D20", Offset = "0x3F28B20", VA = "0x183F29D20")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F296E0", Offset = "0x3F284E0", VA = "0x183F296E0")]
			public void GKLJKDAGGIM(OCFBAMKGADC GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x3F29740", Offset = "0x3F28540", VA = "0x183F29740")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F25AD0", Offset = "0x3F248D0", VA = "0x183F25AD0")]
		internal void CCKNMJAJJNM(Entity HHODAAKNPCC, SplinePointParentData FCNFNODDPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x1359460", Offset = "0x1358260", VA = "0x181359460", Slot = "5")]
		public void ReadFromDisplayClass(ref BCGFLCINPFF LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x3F25B60", Offset = "0x3F24960", VA = "0x183F25B60", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F25C90", Offset = "0x3F24A90", VA = "0x183F25C90")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref LGDDCDBBODF.OLHCFIDJFAL FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F25C00", Offset = "0x3F24A00", VA = "0x183F25C00")]
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
	[Cpp2IlInjected.Address(RVA = "0x301E700", Offset = "0x301D500", VA = "0x18301E700", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x301E7B0", Offset = "0x301D5B0", VA = "0x18301E7B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public OCFBAMKGADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x301E460", Offset = "0x301D260", VA = "0x18301E460", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x301E2C0", Offset = "0x301D0C0", VA = "0x18301E2C0")]
	public static EntityQuery JFOFCMOJMOK(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x301E160", Offset = "0x301CF60", VA = "0x18301E160")]
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
	[Cpp2IlInjected.Address(RVA = "0x301A820", Offset = "0x3019620", VA = "0x18301A820", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x301A880", Offset = "0x3019680", VA = "0x18301A880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public NCEPJJFKEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		public FJKFMPHHEDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, FJFDCFFBHDE previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F20D30", Offset = "0x3F1FB30", VA = "0x183F20D30")]
			public void GKLJKDAGGIM(ENFEPNDNPJF GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x3F20D90", Offset = "0x3F1FB90", VA = "0x183F20D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x32A8C70", Offset = "0x32A7A70", VA = "0x1832A8C70")]
		internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, ParentData LBIAANDOGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xC85E70", Offset = "0xC84C70", VA = "0x180C85E70", Slot = "5")]
		public void ReadFromDisplayClass(ref FJKFMPHHEDN LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x32A8CF0", Offset = "0x32A7AF0", VA = "0x1832A8CF0", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x32A8DA0", Offset = "0x32A7BA0", VA = "0x1832A8DA0")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref BBIIDEJHFFM.GBECFIILNGG FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x32A8D60", Offset = "0x32A7B60", VA = "0x1832A8D60")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F21D80", Offset = "0x3F20B80", VA = "0x183F21D80")]
			public void GKLJKDAGGIM(ENFEPNDNPJF GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x3F21E00", Offset = "0x3F20C00", VA = "0x183F21E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x32A9DA0", Offset = "0x32A8BA0", VA = "0x1832A9DA0")]
		internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, ParentData LBIAANDOGFM, FJFDCFFBHDE IFLDPJLJJLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x32A9FF0", Offset = "0x32A8DF0", VA = "0x1832A9FF0", Slot = "5")]
		public void ReadFromDisplayClass(ref FJKFMPHHEDN LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x32A9E60", Offset = "0x32A8C60", VA = "0x1832A9E60", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F10", Offset = "0x32A8D10", VA = "0x1832A9F10")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref BLEBAAAGCMB.JCNGLAHIGHG FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x32A9ED0", Offset = "0x32A8CD0", VA = "0x1832A9ED0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F208B0", Offset = "0x3F1F6B0", VA = "0x183F208B0")]
			public void GKLJKDAGGIM(ENFEPNDNPJF GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x3F20910", Offset = "0x3F1F710", VA = "0x183F20910")]
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
		[Cpp2IlInjected.Address(RVA = "0x32A97E0", Offset = "0x32A85E0", VA = "0x1832A97E0")]
		internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, FJFDCFFBHDE IFLDPJLJJLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x32A99C0", Offset = "0x32A87C0", VA = "0x1832A99C0", Slot = "5")]
		public void ReadFromDisplayClass(ref FJKFMPHHEDN LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x32A9860", Offset = "0x32A8660", VA = "0x1832A9860", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x32A9910", Offset = "0x32A8710", VA = "0x1832A9910")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref ADAODMDCMDE.DIKAFBLJGEN FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x32A98D0", Offset = "0x32A86D0", VA = "0x1832A98D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x341FE10", Offset = "0x341EC10", VA = "0x18341FE10", Slot = "14")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x34201B0", Offset = "0x341EFB0", VA = "0x1834201B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public ENFEPNDNPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x3420150", Offset = "0x341EF50", VA = "0x183420150", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x341FEF0", Offset = "0x341ECF0", VA = "0x18341FEF0")]
	public static EntityQuery ONDOKAPBINF(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x341FBE0", Offset = "0x341E9E0", VA = "0x18341FBE0")]
	public static EntityQuery MMBPKGOGPLA(ComponentSystemBase GFHLMIDFMDH)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x341F9E0", Offset = "0x341E7E0", VA = "0x18341F9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x304F390", Offset = "0x304E190", VA = "0x18304F390", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x304F320", Offset = "0x304E120", VA = "0x18304F320", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x304F420", Offset = "0x304E220", VA = "0x18304F420", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class HFNCNBKCPDK : ParentSystemBase<ParentData, FJFDCFFBHDE, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x30470F0", Offset = "0x3045EF0", VA = "0x1830470F0", Slot = "14")]
	protected override EntityQueryDesc KMNFJOOCPJF(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x7BBCA0", Offset = "0x7BAAA0", VA = "0x1807BBCA0", Slot = "15")]
	protected override EntityQueryDesc DFGBELAPBIC(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x3047130", Offset = "0x3045F30", VA = "0x183047130", Slot = "16")]
	protected override EntityQueryDesc OIHMCIJFFBN(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x30470B0", Offset = "0x3045EB0", VA = "0x1830470B0", Slot = "17")]
	protected override EntityQueryDesc BECNHEEIAMJ(EntityQueryDesc NJIBLOIMOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x30471B0", Offset = "0x3045FB0", VA = "0x1830471B0")]
	public HFNCNBKCPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x3047170", Offset = "0x3045F70", VA = "0x183047170", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BE5A30", Offset = "0x2BE4830", VA = "0x182BE5A30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2BCCD70", Offset = "0x2BCBB70", VA = "0x182BCCD70", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x339A8D0", Offset = "0x33996D0", VA = "0x18339A8D0")]
			private int CNNLEOAMFHB(DynamicBuffer<ChildrenData> KPOBDKLHLOL, Entity LLEBIIAHFDD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x339A660", Offset = "0x3399460", VA = "0x18339A660")]
			private void CJGLMNNMMDH(Entity GEOFAMNLJNK, DynamicBuffer<ChildrenData> KPOBDKLHLOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x339A2A0", Offset = "0x33990A0", VA = "0x18339A2A0")]
			private void BPDDIFMCOHH(Entity GEOFAMNLJNK, DynamicBuffer<ChildrenData> KPOBDKLHLOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x339A9E0", Offset = "0x33997E0", VA = "0x18339A9E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x28894D0", Offset = "0x28882D0", VA = "0x1828894D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x30C0440", Offset = "0x30BF240", VA = "0x1830C0440")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x30BF1C0", Offset = "0x30BDFC0", VA = "0x1830BF1C0")]
		private int CNNLEOAMFHB(DynamicBuffer<ChildrenData> KPOBDKLHLOL, Entity LLEBIIAHFDD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x30BF410", Offset = "0x30BE210", VA = "0x1830BF410")]
		private void IEJDLPBDLNA(Entity DLPPAJNBCBG, Entity FMMBMPIEFCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCA0", Offset = "0x7BAAA0", VA = "0x1807BBCA0", Slot = "14")]
		protected virtual EntityQueryDesc KMNFJOOCPJF(EntityQueryDesc NJIBLOIMOJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCA0", Offset = "0x7BAAA0", VA = "0x1807BBCA0", Slot = "15")]
		protected virtual EntityQueryDesc DFGBELAPBIC(EntityQueryDesc NJIBLOIMOJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x7BBCA0", Offset = "0x7BAAA0", VA = "0x1807BBCA0", Slot = "16")]
		protected virtual EntityQueryDesc OIHMCIJFFBN(EntityQueryDesc NJIBLOIMOJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc BECNHEEIAMJ(EntityQueryDesc NJIBLOIMOJA);

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x30BFF70", Offset = "0x30BED70", VA = "0x1830BFF70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x30BFB30", Offset = "0x30BE930", VA = "0x1830BFB30")]
		private void MILPLNHPLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x30BE2F0", Offset = "0x30BD0F0", VA = "0x1830BE2F0")]
		private void ABGOLHEKGKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x30BEBA0", Offset = "0x30BD9A0", VA = "0x1830BEBA0")]
		private JobHandle CGAKJOEFILD(JobHandle EJNAMLGMMHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x30BF570", Offset = "0x30BE370", VA = "0x1830BF570")]
		private void IOAFOKPCOJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x30C0210", Offset = "0x30BF010", VA = "0x1830C0210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x2AECAB0", Offset = "0x2AEB8B0", VA = "0x182AECAB0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCD20", Offset = "0x2BDBB20", VA = "0x182BDCD20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F28B20", Offset = "0x3F27920", VA = "0x183F28B20")]
		public JPBFOBKCIFA(NativeList<Entity> BGOPNGOGNMD, NativeList<Entity> LDKKKOFAPHG, JobHandle BLJNDDIDOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x3F28AA0", Offset = "0x3F278A0", VA = "0x183F28AA0")]
		public JobHandle MDPLMPHJHML(JobHandle EJNAMLGMMHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x3F28A10", Offset = "0x3F27810", VA = "0x183F28A10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F23690", Offset = "0x3F22490", VA = "0x183F23690", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x3F23DD0", Offset = "0x3F22BD0", VA = "0x183F23DD0")]
		private void PJODJMLCDBC(Entity LLEBIIAHFDD, bool JEJKGBFFNJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x3F23980", Offset = "0x3F22780", VA = "0x183F23980")]
		private void IJCCAEFIBII(Entity LLEBIIAHFDD, bool JEJKGBFFNJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x3F23900", Offset = "0x3F22700", VA = "0x183F23900")]
		public JPBFOBKCIFA GLPPOHEIFIM(NativeArray<Entity> DFMCPPMHIBK, JobHandle EJNAMLGMMHG)
		{
			return default(JPBFOBKCIFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x3F23530", Offset = "0x3F22330", VA = "0x183F23530")]
		public JPBFOBKCIFA ANHAMADLBCO(NativeArray<Entity> DFMCPPMHIBK, JobHandle EJNAMLGMMHG)
		{
			return default(JPBFOBKCIFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x3F23A90", Offset = "0x3F22890", VA = "0x183F23A90")]
		public JPBFOBKCIFA JPFLOEMDDNE(NativeList<CAIGEBHNCMM> LENGKEKMOEB, JobHandle EJNAMLGMMHG)
		{
			return default(JPBFOBKCIFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x3F235B0", Offset = "0x3F223B0", VA = "0x183F235B0")]
		public JPBFOBKCIFA DFJAJFEBJLD(NativeList<CAIGEBHNCMM> LENGKEKMOEB, JobHandle EJNAMLGMMHG)
		{
			return default(JPBFOBKCIFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x3F23820", Offset = "0x3F22620", VA = "0x183F23820")]
		public JPBFOBKCIFA FOCGLMOBLMC(NativeList<CPMOBHMFHFP> LENGKEKMOEB, JobHandle EJNAMLGMMHG)
		{
			return default(JPBFOBKCIFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x2C862F0", Offset = "0x2C850F0", VA = "0x182C862F0")]
		private JPBFOBKCIFA ONNDOAPHHCA<T>(NativeList<T> LENGKEKMOEB, int BNNFILIACEF, int GDENOEMAIPG, MFLNLIHIGND GGBPGDBFPKJ, JobHandle EJNAMLGMMHG) where T : struct
		{
			return default(JPBFOBKCIFA);
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x3F23B70", Offset = "0x3F22970", VA = "0x183F23B70")]
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
	[Cpp2IlInjected.Address(RVA = "0x305A4A0", Offset = "0x30592A0", VA = "0x18305A4A0")]
	protected LJGIGCFJLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x3059320", Offset = "0x3058120", VA = "0x183059320", Slot = "14")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x3059400", Offset = "0x3058200", VA = "0x183059400", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x3059630", Offset = "0x3058430", VA = "0x183059630", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x93B9A0", Offset = "0x93A7A0", VA = "0x18093B9A0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x3058E20", Offset = "0x3057C20", VA = "0x183058E20")]
	private void FCEAHEFJBGK(NativeArray<Entity> LENGKEKMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x3058D10", Offset = "0x3057B10", VA = "0x183058D10")]
	private void ADCADDCEGNA(NativeArray<Entity> LENGKEKMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x3058F90", Offset = "0x3057D90", VA = "0x183058F90")]
	private void FNOMJHMMMIG(JPBFOBKCIFA HKNNJLCHMPE, string CGPGGBMCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x3058E80", Offset = "0x3057C80", VA = "0x183058E80")]
	private void FNOMJHMMMIG(global::BNGAOKMFDEK<Entity> NEFMOGMOOKN, string CGPGGBMCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x30591E0", Offset = "0x3057FE0", VA = "0x1830591E0")]
	private void JIOJBEBHCKG(JPBFOBKCIFA HKNNJLCHMPE, string CGPGGBMCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x30590D0", Offset = "0x3057ED0", VA = "0x1830590D0")]
	private void JIOJBEBHCKG(global::BNGAOKMFDEK<Entity> NEFMOGMOOKN, string CGPGGBMCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x3058DB0", Offset = "0x3057BB0", VA = "0x183058DB0")]
	private bool ADGCEBFMOHF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		public GDIOHBOLPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F24FA0", Offset = "0x3F23DA0", VA = "0x183F24FA0")]
			public void GKLJKDAGGIM(PJHOJCPLAHI GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x3F24FB0", Offset = "0x3F23DB0", VA = "0x183F24FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F2A840", Offset = "0x3F29640", VA = "0x183F2A840")]
		internal void CCKNMJAJJNM(Entity AENGIJLJHJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x3F29110", Offset = "0x3F27F10", VA = "0x183F29110", Slot = "5")]
		public void ReadFromDisplayClass(ref GDIOHBOLPCJ LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x3F29140", Offset = "0x3F27F40", VA = "0x183F29140", Slot = "6")]
		public void WriteToDisplayClass(ref GDIOHBOLPCJ LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A950", Offset = "0x3F29750", VA = "0x183F2A950", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AA50", Offset = "0x3F29850", VA = "0x183F2AA50")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, ref FEFHHJFNOAN.PIKFGOMOAEF FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x3F2AA10", Offset = "0x3F29810", VA = "0x183F2AA10")]
		public void GKLJKDAGGIM(PJHOJCPLAHI GFHLMIDFMDH, ref GDIOHBOLPCJ LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A9A0", Offset = "0x3F297A0", VA = "0x183F2A9A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x302F490", Offset = "0x302E290", VA = "0x18302F490", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x302F180", Offset = "0x302DF80", VA = "0x18302F180", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x302F4F0", Offset = "0x302E2F0", VA = "0x18302F4F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public PJHOJCPLAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x302F3B0", Offset = "0x302E1B0", VA = "0x18302F3B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x302F1E0", Offset = "0x302DFE0", VA = "0x18302F1E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3042900", Offset = "0x3041700", VA = "0x183042900", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x3042970", Offset = "0x3041770", VA = "0x183042970", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x3042A10", Offset = "0x3041810", VA = "0x183042A10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public FLFJFOAOHPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6506E0", Offset = "0x64F4E0", VA = "0x1806506E0")]
	public static OKCMKDFJJHK KPOCFOKDNEC(in PFMNCAAGPOA FIGEMIBODDE)
	{
		return default(OKCMKDFJJHK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x6506E0", Offset = "0x64F4E0", VA = "0x1806506E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3042630", Offset = "0x3041430", VA = "0x183042630", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0")]
	public FKIFMBMBEBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		public BPHJHBCHANF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F24FC0", Offset = "0x3F23DC0", VA = "0x183F24FC0")]
			public void GKLJKDAGGIM(GDKDJKHEADC GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x3F25020", Offset = "0x3F23E20", VA = "0x183F25020")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F28DC0", Offset = "0x3F27BC0", VA = "0x183F28DC0")]
		internal void CCKNMJAJJNM(Entity AENGIJLJHJA, OKCMKDFJJHK JCHECGJKGFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x3F29110", Offset = "0x3F27F10", VA = "0x183F29110", Slot = "5")]
		public void ReadFromDisplayClass(ref BPHJHBCHANF LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x3F29140", Offset = "0x3F27F40", VA = "0x183F29140", Slot = "6")]
		public void WriteToDisplayClass(ref BPHJHBCHANF LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x3F28EC0", Offset = "0x3F27CC0", VA = "0x183F28EC0", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x3F29060", Offset = "0x3F27E60", VA = "0x183F29060")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, ref FEOLMAMJJFJ.AHGIKLPDEOH FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x3F28FD0", Offset = "0x3F27DD0", VA = "0x183F28FD0")]
		public void GKLJKDAGGIM(GDKDJKHEADC GFHLMIDFMDH, ref BPHJHBCHANF LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x3F28F60", Offset = "0x3F27D60", VA = "0x183F28F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x30437B0", Offset = "0x30425B0", VA = "0x1830437B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x30434A0", Offset = "0x30422A0", VA = "0x1830434A0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x3043810", Offset = "0x3042610", VA = "0x183043810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public GDKDJKHEADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x30436D0", Offset = "0x30424D0", VA = "0x1830436D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x3043500", Offset = "0x3042300", VA = "0x183043500")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F2A1C0", Offset = "0x3F28FC0", VA = "0x183F2A1C0")]
			public MBEHLICOOJE(int BPGPHKEJPBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x3F2A140", Offset = "0x3F28F40", VA = "0x183F2A140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F2AF00", Offset = "0x3F29D00", VA = "0x183F2AF00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F22D30", Offset = "0x3F21B30", VA = "0x183F22D30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3032E10", Offset = "0x3031C10", VA = "0x183032E10", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x3033910", Offset = "0x3032710", VA = "0x183033910", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x30338D0", Offset = "0x30326D0", VA = "0x1830338D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x3033BD0", Offset = "0x30329D0", VA = "0x183033BD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x3033660", Offset = "0x3032460", VA = "0x183033660")]
		private void MOHJPMKJPCG(EntityQuery NJIBLOIMOJA, out (global::GHKNLLBEIFC<OKCMKDFJJHK> handles, global::GHKNLLBEIFC<FLJBFMJPKBF> bounds) JLFCOOGLPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x3032E70", Offset = "0x3031C70", VA = "0x183032E70")]
		private void COEELGENAKB((global::GHKNLLBEIFC<OKCMKDFJJHK> handles, global::GHKNLLBEIFC<FLJBFMJPKBF> bounds) JLFCOOGLPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x30338D0", Offset = "0x30326D0", VA = "0x1830338D0")]
		private void ONKAEICCGKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x30330D0", Offset = "0x3031ED0", VA = "0x1830330D0")]
		private void DPBOPIFFMDB(EntityQuery NJIBLOIMOJA, out (global::GHKNLLBEIFC<Entity> entities, global::GHKNLLBEIFC<OKCMKDFJJHK> handles) JLFCOOGLPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x3033210", Offset = "0x3032010", VA = "0x183033210")]
		private void FGLAHCNPFIC((global::GHKNLLBEIFC<Entity> entities, global::GHKNLLBEIFC<OKCMKDFJJHK> handles) JLFCOOGLPMP, MBEHLICOOJE GJJAOAGKAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x3033500", Offset = "0x3032300", VA = "0x183033500")]
		private JobHandle JEMOEGDGDKM(MBEHLICOOJE GJJAOAGKAFC, ComponentDataFromEntity<WorldPoseData> FMEJNAGGOAC, ComponentDataFromEntity<WorldUniformScaleData> CFKFCBEGCBL, ComponentDataFromEntity<WorldDeformableScaleData> LNCHJDKJJKJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x30337A0", Offset = "0x30325A0", VA = "0x1830337A0")]
		private JobHandle NOELHBNEEBB(MBEHLICOOJE GJJAOAGKAFC, ComponentDataFromEntity<WorldPoseData> FMEJNAGGOAC, ComponentDataFromEntity<WorldUniformScaleData> CFKFCBEGCBL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F221A0", Offset = "0x3F20FA0", VA = "0x183F221A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F27980", Offset = "0x3F26780", VA = "0x183F27980", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x32B3070", Offset = "0x32B1E70", VA = "0x1832B3070", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x32B3280", Offset = "0x32B2080", VA = "0x1832B3280", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x32B26E0", Offset = "0x32B14E0", VA = "0x1832B26E0")]
		private JobHandle EJMNAMHHDFJ(global::GHKNLLBEIFC<Entity> EJLDCNGHIAK, int PMIIGNOLFGJ, JobHandle EJNAMLGMMHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x32B27C0", Offset = "0x32B15C0", VA = "0x1832B27C0")]
		private JobHandle EJMNAMHHDFJ(NativeArray<Entity> MPLOHGHLFIE, int PMIIGNOLFGJ, [Optional] JobHandle EJNAMLGMMHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x32B2B90", Offset = "0x32B1990", VA = "0x1832B2B90")]
		private global::GHKNLLBEIFC<Entity> GFDPMPHDEBP(EntityQuery NJIBLOIMOJA)
		{
			return default(global::GHKNLLBEIFC<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x32B2290", Offset = "0x32B1090", VA = "0x1832B2290")]
		private (global::BNGAOKMFDEK<Entity>, global::BNGAOKMFDEK<Entity>) CEAGKDLCKOB(global::GHKNLLBEIFC<Entity> GNLLMPHHBAI)
		{
			return default((global::BNGAOKMFDEK<Entity>, global::BNGAOKMFDEK<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x32B2B00", Offset = "0x32B1900", VA = "0x1832B2B00")]
		private void FONIGCOJPFG(out NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x32B29A0", Offset = "0x32B17A0", VA = "0x1832B29A0")]
		private void FABPGIGHDKN(NativeList<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x32B2A30", Offset = "0x32B1830", VA = "0x1832B2A30")]
		private void FABPGIGHDKN(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x32B2C10", Offset = "0x32B1A10", VA = "0x1832B2C10")]
		private void KEAEMIIKAFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		private static void CDABGPLFCCF(int ODCNHGKPGHB, int KHINMIBBGKB, int DDECJHOFPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x32B2D40", Offset = "0x32B1B40", VA = "0x1832B2D40")]
		private static FLJBFMJPKBF LOEDCDGJJNE(NativeArray<Entity> GPHNKPFOGNC, ComponentDataFromEntity<SplinePointPositionData> KFHBJGHAHGO, ComponentDataFromEntity<SplinePointScaleData> DPEELJNKMNF)
		{
			return default(FLJBFMJPKBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x341DC00", Offset = "0x341CA00", VA = "0x18341DC00", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x341DC70", Offset = "0x341CA70", VA = "0x18341DC70")]
		public bool EGOLEHHFAKF(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x341E0D0", Offset = "0x341CED0", VA = "0x18341E0D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x341DD20", Offset = "0x341CB20", VA = "0x18341DD20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x341E200", Offset = "0x341D000", VA = "0x18341E200", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x15032A0", Offset = "0x15020A0", VA = "0x1815032A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x341DD20", Offset = "0x341CB20", VA = "0x18341DD20")]
		private void GHHONKIACMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x341E220", Offset = "0x341D020", VA = "0x18341E220")]
		private void PFCBDIAFFJH(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x341DF90", Offset = "0x341CD90", VA = "0x18341DF90")]
		private void MEDBDGAOKAK(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x341DD60", Offset = "0x341CB60", VA = "0x18341DD60")]
		private void GHMIAIGFAAN(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x341DE70", Offset = "0x341CC70", VA = "0x18341DE70")]
		private void HCHAJOEFLAN(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x303FBF0", Offset = "0x303E9F0", VA = "0x18303FBF0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x3040230", Offset = "0x303F030", VA = "0x183040230", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x303FCA0", Offset = "0x303EAA0", VA = "0x18303FCA0")]
		private void MMOHCPKMKHH(DBJHEIPMAIM FGMCPHKBIAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		private void BKLEIIACPDF(Entity LLEBIIAHFDD, ELJHNEOGEBP FFJHOAAMJMD, FPHEKKDEPIJ LGPKKGCJHDG, GEKCNMCMNCD DCGEEIGCBII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3039AA0", Offset = "0x30388A0", VA = "0x183039AA0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x3039B30", Offset = "0x3038930", VA = "0x183039B30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x32BA680", Offset = "0x32B9480", VA = "0x1832BA680", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x32BA6D0", Offset = "0x32B94D0", VA = "0x1832BA6D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x32A9060", Offset = "0x32A7E60", VA = "0x1832A9060", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x340FB90", Offset = "0x340E990", VA = "0x18340FB90", Slot = "14")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x340FA90", Offset = "0x340E890", VA = "0x18340FA90", Slot = "15")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x340FEE0", Offset = "0x340ECE0", VA = "0x18340FEE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x3410030", Offset = "0x340EE30", VA = "0x183410030", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x340FB20", Offset = "0x340E920", VA = "0x18340FB20")]
		private bool IMEPHINCBHD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x340FBA0", Offset = "0x340E9A0", VA = "0x18340FBA0")]
		private void OONPEMBDCCG(EntityQuery NJIBLOIMOJA, float3 BPHNMAGMINJ, string NLCIGFDKGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3036550", Offset = "0x3035350", VA = "0x183036550", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x30365A0", Offset = "0x30353A0", VA = "0x1830365A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x32C1090", Offset = "0x32BFE90", VA = "0x1832C1090", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x32C1100", Offset = "0x32BFF00", VA = "0x1832C1100", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x32C1190", Offset = "0x32BFF90", VA = "0x1832C1190", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x303E5A0", Offset = "0x303D3A0", VA = "0x18303E5A0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x303F5A0", Offset = "0x303E3A0", VA = "0x18303F5A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x303ED70", Offset = "0x303DB70", VA = "0x18303ED70")]
		private void JDHDBMBFMMN(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> LENGKEKMOEB, EntityQueryDesc LPEILMOBCMF, bool GKFAIECOKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x303EE80", Offset = "0x303DC80", VA = "0x18303EE80")]
		private void JDHDBMBFMMN(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> LENGKEKMOEB, EntityQueryDesc LPEILMOBCMF, bool GKFAIECOKJO, bool HOCGGBCFNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x303F800", Offset = "0x303E600", VA = "0x18303F800", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x303E5F0", Offset = "0x303D3F0", VA = "0x18303E5F0")]
		private void CGNMHNNEAKM(EntityQuery NJIBLOIMOJA, bool JMFJCLLHFFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x303F270", Offset = "0x303E070", VA = "0x18303F270")]
		private void LLPDOKCFHAG(EntityQuery NJIBLOIMOJA, bool KOOGAHOBCMH, bool JMFJCLLHFFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x303F050", Offset = "0x303DE50", VA = "0x18303F050")]
		private void LBAOEFLAGEE(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x303E820", Offset = "0x303D620", VA = "0x18303E820")]
		private void DLAPJPFJGPO(NativeList<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x303F480", Offset = "0x303E280", VA = "0x18303F480")]
		private void NIJGPHBNDIC(NativeArray<Entity> FNMNPGEEPJI, bool KOOGAHOBCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x303EB70", Offset = "0x303D970", VA = "0x18303EB70")]
		private NativeList<Entity> JDDJHOCCIJI(NativeArray<Entity> FNMNPGEEPJI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x303E990", Offset = "0x303D790", VA = "0x18303E990")]
		private NativeList<Entity> DLGIKPOMAAB(NativeArray<Entity> FNMNPGEEPJI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x303E7E0", Offset = "0x303D5E0", VA = "0x18303E7E0")]
		private NativeList<Entity> DKCLABOMMJP(NativeArray<Entity> FNMNPGEEPJI)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x303E9D0", Offset = "0x303D7D0", VA = "0x18303E9D0")]
		private NativeList<Entity> FKHBPBKOEBP(NativeArray<Entity> FNMNPGEEPJI, bool LMFDLFNFMAH)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x303EFC0", Offset = "0x303DDC0", VA = "0x18303EFC0")]
		private LDFOFEBKOEG JIBHLMACMGI(NativeArray<Entity> FNMNPGEEPJI)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(LDFOFEBKOEG);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x303FB20", Offset = "0x303E920", VA = "0x18303FB20")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x30365C0", Offset = "0x30353C0", VA = "0x1830365C0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x3036610", Offset = "0x3035410", VA = "0x183036610", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x341D870", Offset = "0x341C670", VA = "0x18341D870", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x341DA30", Offset = "0x341C830", VA = "0x18341DA30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x341D3F0", Offset = "0x341C1F0", VA = "0x18341D3F0")]
		private void GBIEMMHFGJA(EntityQuery NJIBLOIMOJA, bool JJPEDAIHJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x341D630", Offset = "0x341C430", VA = "0x18341D630")]
		private void GMAAJIEKJGA(EntityQuery NJIBLOIMOJA, bool JJPEDAIHJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3407170", Offset = "0x3405F70", VA = "0x183407170", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x3407A30", Offset = "0x3406830", VA = "0x183407A30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x3407B40", Offset = "0x3406940", VA = "0x183407B40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x3407920", Offset = "0x3406720", VA = "0x183407920")]
		private void IFANCMBEGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x3407560", Offset = "0x3406360", VA = "0x183407560")]
		private void FLGKKHFNHBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x3407240", Offset = "0x3406040", VA = "0x183407240")]
		private void DKJEHDCIIJF(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x34077E0", Offset = "0x34065E0", VA = "0x1834077E0")]
		private void HOELLFFGPMK(NativeArray<Entity> FNMNPGEEPJI, int CDFPGFBELGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x34076D0", Offset = "0x34064D0", VA = "0x1834076D0")]
		private void GAKAFHGMGKD(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x34071E0", Offset = "0x3405FE0", VA = "0x1834071E0")]
		private void AFGIBOODMBK(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		private static void EIBIMOBJDNI(int DEPHGHGHIPL, Transform KAMDPLLJPAH, Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class ALCBKEFFPIP
{
	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x3404FB0", Offset = "0x3403DB0", VA = "0x183404FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3411920", Offset = "0x3410720", VA = "0x183411920", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x3411970", Offset = "0x3410770", VA = "0x183411970", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x3411A30", Offset = "0x3410830", VA = "0x183411A30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x305BC30", Offset = "0x305AA30", VA = "0x18305BC30")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x305BDC0", Offset = "0x305ABC0", VA = "0x18305BDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		private Entity IOMKCLJBFAF
		{
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x305BE20", Offset = "0x305AC20", VA = "0x18305BE20")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public IOBECAADPPL HEHFNJBEBKN
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0x305BC90", Offset = "0x305AA90", VA = "0x18305BC90")]
			get
			{
				return default(IOBECAADPPL);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x305BD50", Offset = "0x305AB50", VA = "0x18305BD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public IOBECAADPPL IMMDJKNBGMO
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x305BE80", Offset = "0x305AC80", VA = "0x18305BE80")]
			get
			{
				return default(IOBECAADPPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x305C480", Offset = "0x305B280", VA = "0x18305C480", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x305BBC0", Offset = "0x305A9C0", VA = "0x18305BBC0", Slot = "15")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x305C520", Offset = "0x305B320", VA = "0x18305C520", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x305C290", Offset = "0x305B090", VA = "0x18305C290", Slot = "14")]
		protected override void NLLHMOLKCJM(NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> GIPIIBFAOKH, NativeArray<Entity> PJIIAMBEGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x305C1B0", Offset = "0x305AFB0", VA = "0x18305C1B0")]
		private void HJONDJPPHCK(NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> PJIIAMBEGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x305BF10", Offset = "0x305AD10", VA = "0x18305BF10")]
		private void HDAGOAMBOLH(Entity LLEBIIAHFDD, Entity INDIEGGJNFJ, Entity ONPPJKNNPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B277F0", Offset = "0x2B265F0", VA = "0x182B277F0")]
		private bool GIGGJMBFKKD<T>(out T GKFICKKHACC) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B27880", Offset = "0x2B26680", VA = "0x182B27880")]
		private void JKMJNDCPNKA<T>(T GKFICKKHACC) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x305C3E0", Offset = "0x305B1E0", VA = "0x18305C3E0")]
		public bool OLFNGJHIJAC(IOBECAADPPL CIFNOLAMFLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x305BD20", Offset = "0x305AB20", VA = "0x18305BD20")]
		private static bool EMKCCGMDDME(IOBECAADPPL GOBOKNGJFJC, IOBECAADPPL MMCBNIJDLKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x305C5F0", Offset = "0x305B3F0", VA = "0x18305C5F0")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x305C440", Offset = "0x305B240", VA = "0x18305C440", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3419C60", Offset = "0x3418A60", VA = "0x183419C60", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x3419F10", Offset = "0x3418D10", VA = "0x183419F10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x3419FB0", Offset = "0x3418DB0", VA = "0x183419FB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x3419CB0", Offset = "0x3418AB0", VA = "0x183419CB0")]
		private NativeArray<Entity> BBGPOKDEFCO(int CGKKILDEEIJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x3419E00", Offset = "0x3418C00", VA = "0x183419E00")]
		private void JMANCAMEGLE(NativeArray<Entity> PHELHGHGHND, NativeArray<Entity> CHJMGPIMDMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x304A980", Offset = "0x3049780", VA = "0x18304A980", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x304AA70", Offset = "0x3049870", VA = "0x18304AA70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2EFC4E0", Offset = "0x2EFB2E0", VA = "0x182EFC4E0")]
	public static NativeArray<T> ONNDOAPHHCA<T>(NativeArray<Entity> FNMNPGEEPJI, EntityManager CLLNDNAAIKP) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x304DE90", Offset = "0x304CC90", VA = "0x18304DE90")]
	public static void HEHBOGKFKGA(EntityQuery NJIBLOIMOJA, EntityManager CLLNDNAAIKP, BLGCKCAEBNA EFJCPEJOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x304DD60", Offset = "0x304CB60", VA = "0x18304DD60")]
	public static void HCKBCMKDPDN(NativeArray<Entity> PHELHGHGHND, BLGCKCAEBNA EFJCPEJOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x304DFD0", Offset = "0x304CDD0", VA = "0x18304DFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x32BF630", Offset = "0x32BE430", VA = "0x1832BF630", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x32C05B0", Offset = "0x32BF3B0", VA = "0x1832C05B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x32C0650", Offset = "0x32BF450", VA = "0x1832C0650", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x32BF6C0", Offset = "0x32BE4C0", VA = "0x1832BF6C0")]
		private void CGEFBIIAGCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x32C0660", Offset = "0x32BF460", VA = "0x1832C0660")]
		private void PEMLOJAHBJL(NativeArray<Entity> PHELHGHGHND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x32C0770", Offset = "0x32BF570", VA = "0x1832C0770")]
		private void PNLMMNMDECI(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x32C0360", Offset = "0x32BF160", VA = "0x1832C0360")]
		private void KDGAMFAHKNN(NativeArray<Entity> CHJMGPIMDMK, NativeArray<RigidTransform> FBAPGPAGLFP, NativeArray<RigidTransform> JJJKAGKOHAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x32BFED0", Offset = "0x32BECD0", VA = "0x1832BFED0")]
		private void JFKEGIDENOK(NativeArray<RigidTransform> JJJKAGKOHAM, NativeArray<Entity> CHJMGPIMDMK, NativeList<Entity> ICPGOECIOMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3034B00", Offset = "0x3033900", VA = "0x183034B00", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x3034BE0", Offset = "0x30339E0", VA = "0x183034BE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x3034D30", Offset = "0x3033B30", VA = "0x183034D30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x3034B70", Offset = "0x3033970", VA = "0x183034B70")]
		private void LODONELGLGO(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3036230", Offset = "0x3035030", VA = "0x183036230", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x3036450", Offset = "0x3035250", VA = "0x183036450", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x30364F0", Offset = "0x30352F0", VA = "0x1830364F0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x30362C0", Offset = "0x30350C0", VA = "0x1830362C0")]
		private void KGPLLCDDEHE(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x32AB440", Offset = "0x32AA240", VA = "0x1832AB440", Slot = "14")]
		protected override void NLLHMOLKCJM(NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> GIPIIBFAOKH, NativeArray<Entity> PJIIAMBEGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x32AB590", Offset = "0x32AA390", VA = "0x1832AB590")]
		[BurstCompile]
		private static void NLLHMOLKCJM(NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> PJIIAMBEGCK, ComponentDataFromEntity<global::FPOADFOOMMJ> NBFLFBBJIFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x32AB6A0", Offset = "0x32AA4A0", VA = "0x1832AB6A0")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x32AB660", Offset = "0x32AA460", VA = "0x1832AB660", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3162C30", Offset = "0x3161A30", VA = "0x183162C30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x3163000", Offset = "0x3161E00", VA = "0x183163000", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x3162FD0", Offset = "0x3161DD0", VA = "0x183162FD0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x3161F50", Offset = "0x3160D50", VA = "0x183161F50")]
		private void EIDIJKFMNHJ(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x3161330", Offset = "0x3160130", VA = "0x183161330")]
		private void ACHPPJBEAPB(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x3162390", Offset = "0x3161190", VA = "0x183162390")]
		private void NBAPOLLIKKD(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void NLLHMOLKCJM(NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> GIPIIBFAOKH, NativeArray<Entity> PJIIAMBEGCK);

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCED0", Offset = "0x2BDBCD0", VA = "0x182BDCED0")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCD20", Offset = "0x2BDBB20", VA = "0x182BDCD20", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x302F640", Offset = "0x302E440", VA = "0x18302F640", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x302F840", Offset = "0x302E640", VA = "0x18302F840", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x302F990", Offset = "0x302E790", VA = "0x18302F990")]
	public PJLOBOJOALK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x134C070", Offset = "0x134AE70", VA = "0x18134C070")]
	public static Entity KPOCFOKDNEC(LABPOBLIGKO JLFCOOGLPMP)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x134C070", Offset = "0x134AE70", VA = "0x18134C070")]
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
		[Cpp2IlInjected.Address(RVA = "0x340F5A0", Offset = "0x340E3A0", VA = "0x18340F5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x340F9C0", Offset = "0x340E7C0", VA = "0x18340F9C0")]
	public CPEEMCFAHKB(ComponentType JIOJHELJNAL, NativeList<int> EMLNAJJBPOG, NativeList<int> DLDEFHKDCIC, NativeArray<Entity> FNMNPGEEPJI, NativeArray<Entity> LIHINNFLNAF, NativeArray<byte> IFLDPJLJJLN, NativeArray<byte> LBIAANDOGFM, int NMIODJBKPJP, int JJFOJIJIHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x340F700", Offset = "0x340E500", VA = "0x18340F700")]
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
	[Cpp2IlInjected.Address(RVA = "0x340F920", Offset = "0x340E720", VA = "0x18340F920")]
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
	[Cpp2IlInjected.Address(RVA = "0x340F970", Offset = "0x340E770", VA = "0x18340F970")]
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
	[Cpp2IlInjected.Address(RVA = "0x340F620", Offset = "0x340E420", VA = "0x18340F620", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3408290", Offset = "0x3407090", VA = "0x183408290")]
	public BCLCKEMNKIB(ComponentType JIOJHELJNAL, int NMIODJBKPJP, int JJFOJIJIHBI, EntityQuery NJIBLOIMOJA, NativeArray<EEEPDOOOMHK> HFDCOKODHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x3408240", Offset = "0x3407040", VA = "0x183408240", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BD570", Offset = "0x6BC370", VA = "0x1806BD570")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BD570", Offset = "0x6BC370", VA = "0x1806BD570")]
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
		[Cpp2IlInjected.Address(RVA = "0x3044280", Offset = "0x3043080", VA = "0x183044280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public EBLKGKAPHAO KNHOMHPCCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x6945A0", Offset = "0x6933A0", VA = "0x1806945A0")]
		get
		{
			return default(EBLKGKAPHAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x3044190", Offset = "0x3042F90", VA = "0x183044190")]
	public EKBGHCIKEGG HCMECHPJIPA(Type BIEGICDMJCM)
	{
		return default(EKBGHCIKEGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x30440A0", Offset = "0x3042EA0", VA = "0x1830440A0")]
	public EKBGHCIKEGG BINOKDJKPAC(Type BIEGICDMJCM)
	{
		return default(EKBGHCIKEGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x2D83DD0", Offset = "0x2D82BD0", VA = "0x182D83DD0")]
	public T HCMECHPJIPA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x2D83DB0", Offset = "0x2D82BB0", VA = "0x182D83DB0")]
	public T BINOKDJKPAC<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x3044290", Offset = "0x3043090", VA = "0x183044290")]
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
	[Cpp2IlInjected.Address(RVA = "0x3056D90", Offset = "0x3055B90", VA = "0x183056D90", Slot = "17")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x3057020", Offset = "0x3055E20", VA = "0x183057020", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x3056DE0", Offset = "0x3055BE0", VA = "0x183056DE0", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	protected LANANOJNKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x341CD30", Offset = "0x341BB30", VA = "0x18341CD30")]
		get
		{
			return default(BCLCKEMNKIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x341CAB0", Offset = "0x341B8B0", VA = "0x18341CAB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x341D2E0", Offset = "0x341C0E0", VA = "0x18341D2E0")]
	public DPNDFOCCADL(EEHCKCIAPAN KJEBDBMGNJF, FNIDFMEJGMB CBDAGBGGFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x341CDC0", Offset = "0x341BBC0", VA = "0x18341CDC0")]
	public bool GINCMLLPDOD(ComponentType JIOJHELJNAL, out BCLCKEMNKIB FILNOJDGMDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x341CCA0", Offset = "0x341BAA0", VA = "0x18341CCA0")]
	public Dictionary<ComponentType, BCLCKEMNKIB>.Enumerator EMHOENNLHOC()
	{
		return default(Dictionary<ComponentType, BCLCKEMNKIB>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x341CB00", Offset = "0x341B900", VA = "0x18341CB00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x341CE30", Offset = "0x341BC30", VA = "0x18341CE30")]
	private void MIBIBABCCND(IEnumerable<OCECHDCDPOJ> HEFGKLNDMDO, EntityManager CLLNDNAAIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x341D230", Offset = "0x341C030", VA = "0x18341D230")]
	private static int MPFCJCAJABK(OCECHDCDPOJ PJEPJFLNNEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x341C810", Offset = "0x341B610", VA = "0x18341C810")]
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
			[Cpp2IlInjected.Address(RVA = "0x772540", Offset = "0x771340", VA = "0x180772540", Slot = "4")]
			get
			{
				return default(GEKCNMCMNCD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0x32A8C00", Offset = "0x32A7A00", VA = "0x1832A8C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x32A8C50", Offset = "0x32A7A50", VA = "0x1832A8C50")]
		internal JNDPHLDMECH(NativeMultiHashMap<Entity, GEKCNMCMNCD> FAEKHNNILJJ, Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x32A89F0", Offset = "0x32A77F0", VA = "0x1832A89F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x32A89C0", Offset = "0x32A77C0", VA = "0x1832A89C0")]
		public JNDPHLDMECH EMHOENNLHOC()
		{
			return default(JNDPHLDMECH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x32A8AC0", Offset = "0x32A78C0", VA = "0x1832A8AC0", Slot = "9")]
		private IEnumerator<GEKCNMCMNCD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x32A8B60", Offset = "0x32A7960", VA = "0x1832A8B60", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x340B740", Offset = "0x340A540", VA = "0x18340B740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool MOCJDAMLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x340B830", Offset = "0x340A630", VA = "0x18340B830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x25210C0", Offset = "0x251FEC0", VA = "0x1825210C0")]
	public BOMPDGMHJDM(FKGNDDGLAFM OPCGPJFHEJB, JobHandle ILKOPJOIBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x340BBA0", Offset = "0x340A9A0", VA = "0x18340BBA0")]
	public bool MFKPLEMDAOE(Allocator PBEDBDBGIPF, out NativeKeyValueArrays<Entity, GEKCNMCMNCD> BMBFIGGJLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x340BA30", Offset = "0x340A830", VA = "0x18340BA30")]
	public bool HECFBGJIICK(Allocator PBEDBDBGIPF, out (NativeArray<Entity> entities, int uniqueCount) BMBFIGGJLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x340B910", Offset = "0x340A710", VA = "0x18340B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x3044BD0", Offset = "0x30439D0", VA = "0x183044BD0")]
		get
		{
			return default(BCLCKEMNKIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int EONFJIOMKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x3044990", Offset = "0x3043790", VA = "0x183044990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x3044FA0", Offset = "0x3043DA0", VA = "0x183044FA0")]
	public GIMLBHPKKEP(DPNDFOCCADL JOCNBHOKKAE, EEHCKCIAPAN KJEBDBMGNJF, FNIDFMEJGMB CBDAGBGGFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x3044B50", Offset = "0x3043950", VA = "0x183044B50")]
	public List<BCLCKEMNKIB>.Enumerator EMHOENNLHOC()
	{
		return default(List<BCLCKEMNKIB>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x30449D0", Offset = "0x30437D0", VA = "0x1830449D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x3044C60", Offset = "0x3043A60", VA = "0x183044C60")]
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
	[Cpp2IlInjected.Address(RVA = "0x340B650", Offset = "0x340A450", VA = "0x18340B650")]
	public BNONGLPKANE(ObjectInstantiationService DEBJMFLLNHC, EEHCKCIAPAN KJEBDBMGNJF, FNIDFMEJGMB CBDAGBGGFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x340A020", Offset = "0x3408E20", VA = "0x18340A020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x340B5F0", Offset = "0x340A3F0", VA = "0x18340B5F0")]
	public bool OJFKBJNEHAM(OADLDHPKENB FKEOEHMKOOO, out Entity CNGLOEJDOMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x340ACA0", Offset = "0x3409AA0", VA = "0x18340ACA0")]
	private void INMGDHCJBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x340A340", Offset = "0x3409140", VA = "0x18340A340")]
	private EntityArchetype IIALABCJMJP(EntityArchetype CAKJMNMGICO)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x340A870", Offset = "0x3409670", VA = "0x18340A870")]
	public static void ILDOJAOKDGK(EntityManager LPIKKOEGLIJ, EntityManager DKNGLDMHBMP, NativeArray<Entity> OHKHEJKMDKP, NativeArray<EntityArchetype> KHCGOKBHBGE, [Optional] NativeArray<Entity> BDCIEPLJNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x340A1D0", Offset = "0x3408FD0", VA = "0x18340A1D0")]
	[Conditional("DEBUG_BUILD")]
	private static void IGFIPEEMMMC(NativeArray<EntityArchetype> IMDOBIMILJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x3409DE0", Offset = "0x3408BE0", VA = "0x183409DE0")]
	private static string AEKNGOPJJEL(EntityArchetype HNNIEOPALKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x340B4B0", Offset = "0x340A2B0", VA = "0x18340B4B0")]
	[CompilerGenerated]
	internal static void LGEPFIBBEGH(ref Span<ComponentType> OCFFNHAAOAP, ComponentType GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x340B300", Offset = "0x340A100", VA = "0x18340B300")]
	[CompilerGenerated]
	internal static void JPAIGIGBJFG(Span<ComponentType> EJLDCNGHIAK, ref Span<ComponentType> OCFFNHAAOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x340A0F0", Offset = "0x3408EF0", VA = "0x18340A0F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3407000", Offset = "0x3405E00", VA = "0x183407000", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x34070C0", Offset = "0x3405EC0", VA = "0x1834070C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x32A75A0", Offset = "0x32A63A0", VA = "0x1832A75A0", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x32A76E0", Offset = "0x32A64E0", VA = "0x1832A76E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x32A6F10", Offset = "0x32A5D10", VA = "0x1832A6F10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x32A99D0", Offset = "0x32A87D0", VA = "0x1832A99D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x32A9B20", Offset = "0x32A8920", VA = "0x1832A9B20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3412990", Offset = "0x3411790", VA = "0x183412990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private FKGNDDGLAFM PDCFCDHBBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x34136B0", Offset = "0x34124B0", VA = "0x1834136B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x3411AF0", Offset = "0x34108F0", VA = "0x183411AF0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "15")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x3414A50", Offset = "0x3413850", VA = "0x183414A50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x3414C10", Offset = "0x3413A10", VA = "0x183414C10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x3414BA0", Offset = "0x34139A0", VA = "0x183414BA0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x34133B0", Offset = "0x34121B0", VA = "0x1834133B0")]
		private void IMHLKHOKNBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x34123C0", Offset = "0x34111C0", VA = "0x1834123C0")]
		internal void EPGIAEDNEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x3411BF0", Offset = "0x34109F0", VA = "0x183411BF0")]
		private void EPGIAEDNEHH(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x3412750", Offset = "0x3411550", VA = "0x183412750")]
		private void GMPHDAPPLEL(NativeArray<Entity> OHKHEJKMDKP, NativeArray<RRObjectPrefabData> GCNDHOEOECI, ref NativeArray<Entity> LFPHGHDMEHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x3414A30", Offset = "0x3413830", VA = "0x183414A30")]
		internal void ODMPLKOFIOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x3414630", Offset = "0x3413430", VA = "0x183414630")]
		private void ODMPLKOFIOO(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x34136D0", Offset = "0x34124D0", VA = "0x1834136D0")]
		internal void KNPGADAPCNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x3414000", Offset = "0x3412E00", VA = "0x183414000")]
		private void LAILJHNGEBP(FKGNDDGLAFM OPCGPJFHEJB, BCLCKEMNKIB MEOBJDMPABM, bool LOENOKEFIGA, ref JobHandle FHAFGAPMJIJ, ref JobHandle PHANOIBCMHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x3412A50", Offset = "0x3411850", VA = "0x183412A50")]
		internal bool HOHBJGNCJCJ(in BCLCKEMNKIB NMNKGKHKMCB, out JobHandle DKBLPJPHEMF, out CPEEMCFAHKB IPKLHAGMEEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x3412A80", Offset = "0x3411880", VA = "0x183412A80")]
		private bool HOHBJGNCJCJ(in BCLCKEMNKIB NMNKGKHKMCB, bool LOENOKEFIGA, out JobHandle DKBLPJPHEMF, out CPEEMCFAHKB IPKLHAGMEEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x3414470", Offset = "0x3413270", VA = "0x183414470")]
		internal (NativeList<int>, NativeList<int>) NNLGDHJLPCC(NativeList<JCFJEHIDNLE> PDDBOFHMBMM, int BPGPHKEJPBF, JobHandle EJNAMLGMMHG, out JobHandle BLJNDDIDOIN, Allocator PBEDBDBGIPF = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x3411B40", Offset = "0x3410940", VA = "0x183411B40")]
		internal static NativeArray<Entity> BCIBJMKHLHE(EntityQuery NJIBLOIMOJA, out JobHandle PLOIHNLAILD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x34142E0", Offset = "0x34130E0", VA = "0x1834142E0")]
		internal static NativeArray<byte> MHNAJIJNGJH(int EHAMCGPFFID, out JobHandle AKGNNAPOLAK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x3414360", Offset = "0x3413160", VA = "0x183414360")]
		internal static NativeArray<byte> MMKFMHMGMHC(EntityQuery NJIBLOIMOJA, int BGAEBMDLBPN, out JobHandle AKGNNAPOLAK)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x3412650", Offset = "0x3411450", VA = "0x183412650")]
		internal static NativeArray<Entity> GFDPMPHDEBP(EntityQuery NJIBLOIMOJA, out JobHandle PCDMIGHNFCN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x34123E0", Offset = "0x34111E0", VA = "0x1834123E0")]
		internal NativeArray<byte> FHMAFBOLEJB(NativeArray<Entity> FNMNPGEEPJI, BCLCKEMNKIB MEOBJDMPABM, JobHandle EJNAMLGMMHG, out JobHandle BLJNDDIDOIN, Allocator PBEDBDBGIPF = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x3413E70", Offset = "0x3412C70", VA = "0x183413E70")]
		internal JobHandle KOFOANAHAOP(in CPEEMCFAHKB JLFCOOGLPMP, in BCLCKEMNKIB MEOBJDMPABM, NativeMultiHashMap<Entity, GEKCNMCMNCD> GMFDFPOAIDK, JobHandle EJNAMLGMMHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x24EA180", Offset = "0x24E8F80", VA = "0x1824EA180")]
		private JobHandle IMEIJCPJCFD(JobHandle LMDHBBCCOPF, JobHandle HFMMPBGICHB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x24EA180", Offset = "0x24E8F80", VA = "0x1824EA180")]
		private JobHandle IMEIJCPJCFD(JobHandle LMDHBBCCOPF, JobHandle HFMMPBGICHB, JobHandle AAGCBJPFBPE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3036E30", Offset = "0x3035C30", VA = "0x183036E30", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override ComponentType FNGLFBHNMKO
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x3036E00", Offset = "0x3035C00", VA = "0x183036E00", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override ComponentType LPDOHFENIEH
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x3036DD0", Offset = "0x3035BD0", VA = "0x183036DD0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x3036E60", Offset = "0x3035C60", VA = "0x183036E60")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3036ED0", Offset = "0x3035CD0", VA = "0x183036ED0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType FNGLFBHNMKO
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x3036EA0", Offset = "0x3035CA0", VA = "0x183036EA0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType LPDOHFENIEH
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x3036E70", Offset = "0x3035C70", VA = "0x183036E70", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x3036E60", Offset = "0x3035C60", VA = "0x183036E60")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3408460", Offset = "0x3407260", VA = "0x183408460", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x34084F0", Offset = "0x34072F0", VA = "0x1834084F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public BDKJHGHPCAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		public DBFDLDOMJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F259F0", Offset = "0x3F247F0", VA = "0x183F259F0")]
			public void GKLJKDAGGIM(NOBFNDJAKMK GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x3F25A50", Offset = "0x3F24850", VA = "0x183F25A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F262F0", Offset = "0x3F250F0", VA = "0x183F262F0")]
		internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, SplinePointParentData DEDMBANHEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F265B0", Offset = "0x3F253B0", VA = "0x183F265B0", Slot = "5")]
		public void ReadFromDisplayClass(ref DBFDLDOMJJP LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F265C0", Offset = "0x3F253C0", VA = "0x183F265C0", Slot = "6")]
		public void WriteToDisplayClass(ref DBFDLDOMJJP LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F26360", Offset = "0x3F25160", VA = "0x183F26360", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x3F26500", Offset = "0x3F25300", VA = "0x183F26500")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref FFJBICKFCHF.GFFLBGEGKOI FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x3F26470", Offset = "0x3F25270", VA = "0x183F26470")]
		public void GKLJKDAGGIM(NOBFNDJAKMK GFHLMIDFMDH, ref DBFDLDOMJJP LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F26400", Offset = "0x3F25200", VA = "0x183F26400")]
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
	[Cpp2IlInjected.Address(RVA = "0x301C3F0", Offset = "0x301B1F0", VA = "0x18301C3F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public NOBFNDJAKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x301C1C0", Offset = "0x301AFC0", VA = "0x18301C1C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x301C060", Offset = "0x301AE60", VA = "0x18301C060")]
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
	[Cpp2IlInjected.Address(RVA = "0x301B960", Offset = "0x301A760", VA = "0x18301B960", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x301B9F0", Offset = "0x301A7F0", VA = "0x18301B9F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public NHHMABIGJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[UpdateAfter(typeof(BDKJHGHPCAM))]
public class BHJKCNNNJGE : OMEJOMKMFOF
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x3409010", Offset = "0x3407E10", VA = "0x183409010", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public BHJKCNNNJGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		public JLLCIENDGDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F2BB10", Offset = "0x3F2A910", VA = "0x183F2BB10")]
			public void GKLJKDAGGIM(EPMJAJNMJOL GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x3F2BB70", Offset = "0x3F2A970", VA = "0x183F2BB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F29410", Offset = "0x3F28210", VA = "0x183F29410")]
		internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, ObjectNetworkIdComponentData PPLJNJDEBHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0xC85E70", Offset = "0xC84C70", VA = "0x180C85E70", Slot = "5")]
		public void ReadFromDisplayClass(ref JLLCIENDGDM LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D55680", Offset = "0x2D54480", VA = "0x182D55680", Slot = "6")]
		public void WriteToDisplayClass(ref JLLCIENDGDM LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x3F29490", Offset = "0x3F28290", VA = "0x183F29490", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F29630", Offset = "0x3F28430", VA = "0x183F29630")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, ref OLJEBGDJMJP.OOLFNDMJELA FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F295A0", Offset = "0x3F283A0", VA = "0x183F295A0")]
		public void GKLJKDAGGIM(EPMJAJNMJOL GFHLMIDFMDH, ref JLLCIENDGDM LAOMKEKPBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F29530", Offset = "0x3F28330", VA = "0x183F29530")]
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
	[Cpp2IlInjected.Address(RVA = "0x34204F0", Offset = "0x341F2F0", VA = "0x1834204F0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x34208B0", Offset = "0x341F6B0", VA = "0x1834208B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public EPMJAJNMJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x34206B0", Offset = "0x341F4B0", VA = "0x1834206B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x3420550", Offset = "0x341F350", VA = "0x183420550")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F21EA0", Offset = "0x3F20CA0", VA = "0x183F21EA0")]
			public void GKLJKDAGGIM(ECNKJGEOKLJ GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x3F21F00", Offset = "0x3F20D00", VA = "0x183F21F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x32A5A00", Offset = "0x32A4800", VA = "0x1832A5A00")]
		public void CCKNMJAJJNM(Entity LLEBIIAHFDD, ParentData CHOLHCKOODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x32A5A20", Offset = "0x32A4820", VA = "0x1832A5A20", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x32A5B40", Offset = "0x32A4940", VA = "0x1832A5B40")]
		public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, ref BPDHOMKHOGD.JEFNEBKFGHO FAHLNAJJNAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x32A5B00", Offset = "0x32A4900", VA = "0x1832A5B00")]
		public void GKLJKDAGGIM(ECNKJGEOKLJ GFHLMIDFMDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x32A5A90", Offset = "0x32A4890", VA = "0x1832A5A90")]
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
	[Cpp2IlInjected.Address(RVA = "0x341EF00", Offset = "0x341DD00", VA = "0x18341EF00", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x341F4B0", Offset = "0x341E2B0", VA = "0x18341F4B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public ECNKJGEOKLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x341EF60", Offset = "0x341DD60", VA = "0x18341EF60")]
	[CompilerGenerated]
	private void EJMGJNLNABM(Entity LLEBIIAHFDD, ParentData CHOLHCKOODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x341F2B0", Offset = "0x341E0B0", VA = "0x18341F2B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x341F150", Offset = "0x341DF50", VA = "0x18341F150")]
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
	[Cpp2IlInjected.Address(RVA = "0x301CC10", Offset = "0x301BA10", VA = "0x18301CC10", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x301D000", Offset = "0x301BE00", VA = "0x18301D000", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x301D0E0", Offset = "0x301BEE0", VA = "0x18301D0E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x301CC60", Offset = "0x301BA60", VA = "0x18301CC60")]
	private void DPLALKCBHIE(Entity LLEBIIAHFDD, OADLDHPKENB FKEOEHMKOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public OAGAKCAOOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3034E40", Offset = "0x3033C40", VA = "0x183034E40", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x3034E90", Offset = "0x3033C90", VA = "0x183034E90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
			public APNIFCGHIND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F26CC0", Offset = "0x3F25AC0", VA = "0x183F26CC0")]
				public void GKLJKDAGGIM(PostLoadInitializeNetworkId GFHLMIDFMDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A1A")]
				[Cpp2IlInjected.Address(RVA = "0x3F26D30", Offset = "0x3F25B30", VA = "0x183F26D30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F26DE0", Offset = "0x3F25BE0", VA = "0x183F26DE0")]
			internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, int MLBMANBHNCL, ref ObjectNetworkIdComponentData PPLJNJDEBHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0xC85E70", Offset = "0xC84C70", VA = "0x180C85E70", Slot = "5")]
			public void ReadFromDisplayClass(ref APNIFCGHIND LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0x2D55680", Offset = "0x2D54480", VA = "0x182D55680", Slot = "6")]
			public void WriteToDisplayClass(ref APNIFCGHIND LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x3F26E70", Offset = "0x3F25C70", VA = "0x183F26E70", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x3F27070", Offset = "0x3F25E70", VA = "0x183F27070")]
			public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref GOJLHPCCNFE.CKJLCCMGNNL FAHLNAJJNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0x3F26FD0", Offset = "0x3F25DD0", VA = "0x183F26FD0")]
			public void GKLJKDAGGIM(PostLoadInitializeNetworkId GFHLMIDFMDH, ref APNIFCGHIND LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x3F26F60", Offset = "0x3F25D60", VA = "0x183F26F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x30350A0", Offset = "0x3033EA0", VA = "0x1830350A0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x3035C20", Offset = "0x3034A20", VA = "0x183035C20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x30358C0", Offset = "0x30346C0", VA = "0x1830358C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x30358C0", Offset = "0x30346C0", VA = "0x1830358C0")]
		public void OCAEKOFPLPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x3035110", Offset = "0x3033F10", VA = "0x183035110")]
		private void ACLOLNIEPID(NativeHashMap<ELJHNEOGEBP, Entity> FAEKHNNILJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x3035660", Offset = "0x3034460", VA = "0x183035660")]
		private void NLEKJOBAFAJ(NativeHashMap<ELJHNEOGEBP, Entity> FAEKHNNILJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x3035990", Offset = "0x3034790", VA = "0x183035990", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x3035CC0", Offset = "0x3034AC0", VA = "0x183035CC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x304CDF0", Offset = "0x304BBF0", VA = "0x18304CDF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x304CE80", Offset = "0x304BC80", VA = "0x18304CE80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public IBEFPKIDNKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3045230", Offset = "0x3044030", VA = "0x183045230", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x3045C70", Offset = "0x3044A70", VA = "0x183045C70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x30454E0", Offset = "0x30442E0", VA = "0x1830454E0")]
	private void EIFDICJLJPO(NativeList<EntityArchetype> IMDOBIMILJG, NativeHashMap<int, OIGDPEFJPLN> MCOPIMGBLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x30452D0", Offset = "0x30440D0", VA = "0x1830452D0")]
	private Span<int> CCHPJFGMCNC(EntityArchetype HNNIEOPALKC)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x3045410", Offset = "0x3044210", VA = "0x183045410")]
	private bool EIANIAJKPBF(int BGAEBMDLBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x3045670", Offset = "0x3044470", VA = "0x183045670")]
	private void MJKJOAFPCIK(NativeHashMap<int, OIGDPEFJPLN> MCOPIMGBLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public GPGMELIBGAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3035EB0", Offset = "0x3034CB0", VA = "0x183035EB0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x3036130", Offset = "0x3034F30", VA = "0x183036130", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
			public NGKAGOGMIOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x32A7F70", Offset = "0x32A6D70", VA = "0x1832A7F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F291E0", Offset = "0x3F27FE0", VA = "0x183F291E0")]
			internal void CCKNMJAJJNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0x3F293D0", Offset = "0x3F281D0", VA = "0x183F293D0", Slot = "5")]
			public void ReadFromDisplayClass(ref NGKAGOGMIOF LAOMKEKPBEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0x3F293A0", Offset = "0x3F281A0", VA = "0x183F293A0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x3F293B0", Offset = "0x3F281B0", VA = "0x183F293B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x32B11C0", Offset = "0x32AFFC0", VA = "0x1832B11C0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x32B1220", Offset = "0x32B0020", VA = "0x1832B1220")]
		public JobHandle DBICDGJOIGK(JobHandle EJNAMLGMMHG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x32B1570", Offset = "0x32B0370", VA = "0x1832B1570", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x32B1260", Offset = "0x32B0060", VA = "0x1832B1260")]
		private bool MEIKGDGJGKD(JobHandle EJNAMLGMMHG, int BGAEBMDLBPN, out JobHandle MNHBLNJHMBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3054180", Offset = "0x3052F80", VA = "0x183054180", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public KJEAKJPMMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x34047A0", Offset = "0x34035A0", VA = "0x1834047A0", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public ACLIEOECLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x34093D0", Offset = "0x34081D0", VA = "0x1834093D0", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public BIHOJOPMFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x304DA70", Offset = "0x304C870", VA = "0x18304DA70", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public IEBENGHHJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x74DCF0", Offset = "0x74CAF0", VA = "0x18074DCF0", Slot = "18")]
		get
		{
			return default(DBJHEIPMAIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public KJLEENOAOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x302CF40", Offset = "0x302BD40", VA = "0x18302CF40", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public PAMILFAIAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class HIAEBKLNJPK : BHBEGOLDLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public HIAEBKLNJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6681A0", Offset = "0x666FA0", VA = "0x1806681A0", Slot = "18")]
		get
		{
			return default(DBJHEIPMAIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public HCNFMFGACEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3054260", Offset = "0x3053060", VA = "0x183054260", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public KLDCNPFKDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class ALBHLIDLINA : BHBEGOLDLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public ALBHLIDLINA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class CEDIEMKPAIG : BHBEGOLDLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public CEDIEMKPAIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class HGKOMCOJCAM : OMEJOMKMFOF
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public HGKOMCOJCAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x304DCF0", Offset = "0x304CAF0", VA = "0x18304DCF0", Slot = "14")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x304DD40", Offset = "0x304CB40", VA = "0x18304DD40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public IHNKOGAOPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x32A7F80", Offset = "0x32A6D80", VA = "0x1832A7F80", Slot = "4")]
			public void Execute(int BNNEENLPEFO, TransformAccess KAMDPLLJPAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0x32A81B0", Offset = "0x32A6FB0", VA = "0x1832A81B0")]
			private bool MEOFPHMOLLA(float3 OCBHJKLFMDP, float3 KNAEAKFNOOB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x32A8140", Offset = "0x32A6F40", VA = "0x1832A8140")]
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
			[Cpp2IlInjected.Address(RVA = "0x32A95C0", Offset = "0x32A83C0", VA = "0x1832A95C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3417F00", Offset = "0x3416D00", VA = "0x183417F00", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x3417F70", Offset = "0x3416D70", VA = "0x183417F70", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x3417FA0", Offset = "0x3416DA0", VA = "0x183417FA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F27D90", Offset = "0x3F26B90", VA = "0x183F27D90")]
				public void GKLJKDAGGIM(RegisterTransforms GFHLMIDFMDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A85")]
				[Cpp2IlInjected.Address(RVA = "0x3F27E10", Offset = "0x3F26C10", VA = "0x183F27E10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F2A260", Offset = "0x3F29060", VA = "0x183F2A260")]
			internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, HBDFAGMJCIE BGCNDKINPDJ, Transform KAMDPLLJPAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x3F2A360", Offset = "0x3F29160", VA = "0x183F2A360", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x3F2A4D0", Offset = "0x3F292D0", VA = "0x183F2A4D0")]
			public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, ref IKFPFJNFCIN.DFJGPOKGGEB FAHLNAJJNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x3F2A4C0", Offset = "0x3F292C0", VA = "0x183F2A4C0")]
			public void GKLJKDAGGIM(RegisterTransforms GFHLMIDFMDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x3F2A450", Offset = "0x3F29250", VA = "0x183F2A450")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F247C0", Offset = "0x3F235C0", VA = "0x183F247C0")]
				public void GKLJKDAGGIM(RegisterTransforms GFHLMIDFMDH)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8B")]
				[Cpp2IlInjected.Address(RVA = "0x3F27140", Offset = "0x3F25F40", VA = "0x183F27140")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F24650", Offset = "0x3F23450", VA = "0x183F24650")]
			internal void CCKNMJAJJNM(Entity LLEBIIAHFDD, HBDFAGMJCIE BGCNDKINPDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x3F24730", Offset = "0x3F23530", VA = "0x183F24730", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int EOMAOLLPGDL, int ELDKPJHNGOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0x3F24820", Offset = "0x3F23620", VA = "0x183F24820")]
			public void LCGHHHKOFDP(ref ArchetypeChunk CNILJNKKOIK, [NoAlias] ref HENNLOBCDNM.NCOGMFFGACM FAHLNAJJNAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x3F247C0", Offset = "0x3F235C0", VA = "0x183F247C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x32AA1E0", Offset = "0x32A8FE0", VA = "0x1832AA1E0", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x32AB110", Offset = "0x32A9F10", VA = "0x1832AB110", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x32AB320", Offset = "0x32AA120", VA = "0x1832AB320", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x32AA5A0", Offset = "0x32A93A0", VA = "0x1832AA5A0")]
		private void EEEHHKHBJNC(EntityQuery NJIBLOIMOJA, NNEFJHMAAJD PBCNCKEIKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x32AAC30", Offset = "0x32A9A30", VA = "0x1832AAC30")]
		private void LGIHGKEDFKA(EntityQuery NJIBLOIMOJA, NNEFJHMAAJD PBCNCKEIKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x32AB2C0", Offset = "0x32AA0C0", VA = "0x1832AB2C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x32AAAF0", Offset = "0x32A98F0", VA = "0x1832AAAF0")]
		private void JOMEPIBOCLH(NativeArray<Entity> FNMNPGEEPJI, NNEFJHMAAJD PBCNCKEIKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x32AA7E0", Offset = "0x32A95E0", VA = "0x1832AA7E0")]
		[BurstCompile]
		internal static void JDNMENKFMDD(NativeArray<HBDFAGMJCIE> LDMGHOPMIAD, ComponentDataFromEntity<HBDFAGMJCIE> MDFLIOGIIID, NNEFJHMAAJD PBCNCKEIKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		private static void AMGHECHEMOD(Transform KAMDPLLJPAH, Entity LLEBIIAHFDD, int BNNEENLPEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		private static void JHAFFHKIFGM(Entity LLEBIIAHFDD, int BNNEENLPEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		private static void KCPAHODMMGC(int BNNEENLPEFO, NNEFJHMAAJD PBCNCKEIKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x32AA000", Offset = "0x32A8E00", VA = "0x1832AA000")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void AAIIBHIFHCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x32AAEA0", Offset = "0x32A9CA0", VA = "0x1832AAEA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x32AA400", Offset = "0x32A9200", VA = "0x1832AA400")]
		public static EntityQuery CCDOOOAPINL(ComponentSystemBase GFHLMIDFMDH)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x32AA230", Offset = "0x32A9030", VA = "0x1832AA230")]
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
			[Cpp2IlInjected.Address(RVA = "0x32A88E0", Offset = "0x32A76E0", VA = "0x1832A88E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x32A8740", Offset = "0x32A7540", VA = "0x1832A8740", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x32A87E0", Offset = "0x32A75E0", VA = "0x1832A87E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3418450", Offset = "0x3417250", VA = "0x183418450", Slot = "14")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x3418620", Offset = "0x3417420", VA = "0x183418620", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x3418810", Offset = "0x3417610", VA = "0x183418810", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x34188A0", Offset = "0x34176A0", VA = "0x1834188A0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x34188D0", Offset = "0x34176D0", VA = "0x1834188D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x34184A0", Offset = "0x34172A0", VA = "0x1834184A0")]
		private NativeArray<Entity> LJKLBCCAKOO(NativeArray<HBDFAGMJCIE> EMLNAJJBPOG, NativeList<Entity> OHKHEJKMDKP, TransformAccessArray CNFNIAOGDMI, TransformAccessArray LNPOFCDEHDP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x30364F0", Offset = "0x30352F0", VA = "0x1830364F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x3419420", Offset = "0x3418220", VA = "0x183419420", Slot = "14")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x3419530", Offset = "0x3418330", VA = "0x183419530", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x34192A0", Offset = "0x34180A0", VA = "0x1834192A0")]
		private static void OHANADCKCNM(EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, Entity GEOFAMNLJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x3419200", Offset = "0x3418000", VA = "0x183419200")]
		private static bool JCBPEMMLHHC(EntityManager CLLNDNAAIKP, Entity LLEBIIAHFDD, out Transform KAMDPLLJPAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F278B0", Offset = "0x3F266B0", VA = "0x183F278B0")]
			[Conditional("DEBUG_BUILD")]
			private void PCFGNOBPMKE(Entity LLEBIIAHFDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0x3F271C0", Offset = "0x3F25FC0", VA = "0x183F271C0", Slot = "4")]
			public void Execute(ArchetypeChunk CNILJNKKOIK, int BNNEENLPEFO, int MMAJILFCCGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0x3F274B0", Offset = "0x3F262B0", VA = "0x183F274B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3056950", Offset = "0x3055750", VA = "0x183056950", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x3056A70", Offset = "0x3055870", VA = "0x183056A70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F26B40", Offset = "0x3F25940", VA = "0x183F26B40", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int BNNEENLPEFO, int MMAJILFCCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x3F26C40", Offset = "0x3F25A40", VA = "0x183F26C40")]
		public bool IAAAGEFBFAH(ArchetypeChunk CNILJNKKOIK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery OIFJKNFCHGE;

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x3058AE0", Offset = "0x30578E0", VA = "0x183058AE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x3058C10", Offset = "0x3057A10", VA = "0x183058C10", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle FJEEDCCNLHF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public LGKIIHFHEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F297C0", Offset = "0x3F285C0", VA = "0x183F297C0", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int BNNEENLPEFO, int MMAJILFCCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x3F29B70", Offset = "0x3F28970", VA = "0x183F29B70")]
		public bool IAAAGEFBFAH(ArchetypeChunk CNILJNKKOIK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private EntityQuery KKELBBDIJCG;

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x3049B60", Offset = "0x3048960", VA = "0x183049B60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x3049C70", Offset = "0x3048A70", VA = "0x183049C70", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle FJEEDCCNLHF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40")]
	public HJCIDACDICK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F23E60", Offset = "0x3F22C60", VA = "0x183F23E60", Slot = "4")]
		public void Execute(ArchetypeChunk CNILJNKKOIK, int BNNEENLPEFO, int MMAJILFCCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x3F24570", Offset = "0x3F23370", VA = "0x183F24570")]
		public bool IAAAGEFBFAH(ArchetypeChunk CNILJNKKOIK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private EntityQuery KKELBBDIJCG;

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x304FFB0", Offset = "0x304EDB0", VA = "0x18304FFB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x30500E0", Offset = "0x304EEE0", VA = "0x1830500E0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle FJEEDCCNLHF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF0", Offset = "0x7CDAF0", VA = "0x1807CECF0")]
	public JKBACEFFNEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3036F60", Offset = "0x3035D60", VA = "0x183036F60", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override ComponentType FNGLFBHNMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x3036F30", Offset = "0x3035D30", VA = "0x183036F30", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override ComponentType LPDOHFENIEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0x3036F00", Offset = "0x3035D00", VA = "0x183036F00", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x3036E60", Offset = "0x3035C60", VA = "0x183036E60")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x14D0D40", Offset = "0x14CFB40", VA = "0x1814D0D40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x30442B0", Offset = "0x30430B0", VA = "0x1830442B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Type[] FGIAFNBEECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x3044320", Offset = "0x3043120", VA = "0x183044320", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6681A0", Offset = "0x666FA0", VA = "0x1806681A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type[] FGIAFNBEECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x340BCE0", Offset = "0x340AAE0", VA = "0x18340BCE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public BPNGFIPDCDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public sealed class EFLFDNJEMGD : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x341F5C0", Offset = "0x341E3C0", VA = "0x18341F5C0", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public EFLFDNJEMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6681A0", Offset = "0x666FA0", VA = "0x1806681A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type[] FGIAFNBEECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x3405530", Offset = "0x3404330", VA = "0x183405530", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public ANJPCIIOKKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public sealed class PLCPFLFHNJK : PHGAEFHEOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x3030290", Offset = "0x302F090", VA = "0x183030290", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public PLCPFLFHNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x301A400", Offset = "0x3019200", VA = "0x18301A400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type[] FGIAFNBEECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x301A470", Offset = "0x3019270", VA = "0x18301A470", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3042D60", Offset = "0x3041B60", VA = "0x183042D60", Slot = "4")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3040380", Offset = "0x303F180", VA = "0x183040380", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x3040720", Offset = "0x303F520", VA = "0x183040720", Slot = "5")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x30403F0", Offset = "0x303F1F0", VA = "0x1830403F0")]
		public Entity DJKFCHELMJI(Entity LLEBIIAHFDD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x3040440", Offset = "0x303F240", VA = "0x183040440")]
		public bool HKIAAFFILCD(Entity LLEBIIAHFDD, Entity JJHAACNMGFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x3040680", Offset = "0x303F480", VA = "0x183040680")]
		public bool LHJCDGMFADO(Entity LLEBIIAHFDD, Entity JJHAACNMGFO, bool CHPHLJOKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x30404A0", Offset = "0x303F2A0", VA = "0x1830404A0")]
		private bool JDIPELLFNNO(Entity LLEBIIAHFDD, Entity JJHAACNMGFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x305BA70", Offset = "0x305A870", VA = "0x18305BA70")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x305AEF0", Offset = "0x3059CF0", VA = "0x18305AEF0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x305B120", Offset = "0x3059F20", VA = "0x18305B120", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x305B830", Offset = "0x305A630", VA = "0x18305B830")]
	public bool NLDBNJEFDEH(Entity LLEBIIAHFDD, Entity NMJJIOLIMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x305B8F0", Offset = "0x305A6F0", VA = "0x18305B8F0")]
	public IEnumerable<Entity> OEGOHCELJAI(Entity LLEBIIAHFDD, bool HOJIMILIDNA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x305B140", Offset = "0x3059F40", VA = "0x18305B140")]
	public bool HDGJJPALPML(Entity LLEBIIAHFDD, Entity DBNJJKLOCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x305BAC0", Offset = "0x305A8C0", VA = "0x18305BAC0")]
	public bool PGPKCLNGJPJ(Entity LLEBIIAHFDD, Entity ADDDKDIDHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x305AFF0", Offset = "0x3059DF0", VA = "0x18305AFF0")]
	public NativeList<Entity> AILKEPHEJLI(Entity LLEBIIAHFDD, bool HOJIMILIDNA = false, Allocator PBEDBDBGIPF = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x305B540", Offset = "0x305A340", VA = "0x18305B540")]
	public IEnumerable<Entity> LBLBJIKOPHN(Entity LLEBIIAHFDD, bool HOJIMILIDNA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x305B270", Offset = "0x305A070", VA = "0x18305B270")]
	public Entity IENNNAFGFNJ(Entity LLEBIIAHFDD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x305B0D0", Offset = "0x3059ED0", VA = "0x18305B0D0")]
	public NativeArray<Entity> BBCNGMBMGMH()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x305B320", Offset = "0x305A120", VA = "0x18305B320")]
	public bool KCBAGPAHKEE(Entity ADDDKDIDHPJ, Entity LCEKCMGAGEI, out Entity BKMGHCEAABD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x305B740", Offset = "0x305A540", VA = "0x18305B740")]
	private Entity MJGKPNPKLCE(Entity LLEBIIAHFDD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DB79B0", Offset = "0x2DB67B0", VA = "0x182DB79B0")]
		public static void BLNLPEOGOOG<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(PGEEJALGCGE HFDOFHJBJGD, global::GPAKIDKFMKC<Entity> BBEHMKMODBA, out global::CGIPMGPHDJK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> NJHEKOHHLCP) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, JIGEDONNEFC where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, JIGEDONNEFC, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x3031A10", Offset = "0x3030810", VA = "0x183031A10")]
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
	[Cpp2IlInjected.Address(RVA = "0x33F0AB0", Offset = "0x33EF8B0", VA = "0x1833F0AB0")]
	public CGIPMGPHDJK(PGEEJALGCGE HFDOFHJBJGD, global::GPAKIDKFMKC<Entity> BBEHMKMODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x33EFAE0", Offset = "0x33EE8E0", VA = "0x1833EFAE0")]
	private bool GEPJLJJDIHJ(Entity LLEBIIAHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x33F0410", Offset = "0x33EF210", VA = "0x1833F0410")]
	private bool POMHFDCKGPD(Entity LLEBIIAHFDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x33EFC90", Offset = "0x33EEA90", VA = "0x1833EFC90")]
	public bool HKIAAFFILCD(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x33F0220", Offset = "0x33EF020", VA = "0x1833F0220")]
	public bool JEFEBMEICLK(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x33EFDE0", Offset = "0x33EEBE0", VA = "0x1833EFDE0")]
	private bool JEFEBMEICLK(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO, bool LEIIDLJOFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	private static void GOJGDDJKMMJ(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	private static void AHADLPEFNPN(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	private static void IAHCIOOOEJG(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	private static void KENIONIEPGE(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	private static void MDOCPIFMJOG(Entity LLEBIIAHFDD, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x33F0250", Offset = "0x33EF050", VA = "0x1833F0250")]
	private bool NLDBNJEFDEH(Entity LLEBIIAHFDD, Entity NMJJIOLIMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x33EFBA0", Offset = "0x33EE9A0", VA = "0x1833EFBA0")]
	private void GGMHOEOCIJE(Entity LLEBIIAHFDD, in Entity KAEGMLMLAJA, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x33EF410", Offset = "0x33EE210", VA = "0x1833EF410")]
	private void COCCFIDEPMD(Entity LLEBIIAHFDD, in Entity KAEGMLMLAJA, in Entity JJHAACNMGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x33EF7B0", Offset = "0x33EE5B0", VA = "0x1833EF7B0")]
	private bool FOPOKINIIOF(NBKGNKNEBLA MMEPAJOGBCG, in ELJHNEOGEBP ILLHAAGJBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x33EF9B0", Offset = "0x33EE7B0", VA = "0x1833EF9B0")]
	private void GCAONDBJOCG(Entity GEOFAMNLJNK, Entity DBNJJKLOCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x33EFD50", Offset = "0x33EEB50", VA = "0x1833EFD50")]
	private void JDFBMCLFMDD(Entity GEOFAMNLJNK, Entity DBNJJKLOCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	private void KCPAHODMMGC(Entity LLEBIIAHFDD, Entity KAEGMLMLAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6506E0", Offset = "0x64F4E0", VA = "0x1806506E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(ECALDJBELBI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x65D820", Offset = "0x65C620", VA = "0x18065D820", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x30245F0", Offset = "0x30233F0", VA = "0x1830245F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public int LJMLBAGHLCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0x3023220", Offset = "0x3022020", VA = "0x183023220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public int HBEHIIKMMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x30210C0", Offset = "0x301FEC0", VA = "0x1830210C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x1563330", Offset = "0x1562130", VA = "0x181563330", Slot = "4")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x3020E80", Offset = "0x301FC80", VA = "0x183020E80", Slot = "5")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x30228A0", Offset = "0x30216A0", VA = "0x1830228A0")]
		public void HBCCNGJCDAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x3024640", Offset = "0x3023440", VA = "0x183024640", Slot = "6")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x3021B00", Offset = "0x3020900", VA = "0x183021B00", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x30245D0", Offset = "0x30233D0", VA = "0x1830245D0")]
		public int OIMLPEECHCL(SceneTag IEGFBJCKFAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x3021690", Offset = "0x3020490", VA = "0x183021690")]
		public int DFKHICOABHK(SceneTag IEGFBJCKFAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x30228F0", Offset = "0x30216F0", VA = "0x1830228F0")]
		public bool HECBAEPNNDN(Entity LLEBIIAHFDD, Allocator PBEDBDBGIPF, out NativeList<Entity> KLMDHDMFOEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x3022650", Offset = "0x3021450", VA = "0x183022650")]
		public bool GIBIOPECHFP(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x30225B0", Offset = "0x30213B0", VA = "0x1830225B0")]
		public bool FEOLDMHKLBA(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x3023830", Offset = "0x3022630", VA = "0x183023830")]
		public bool LFCLKAMJJHD(Entity LLEBIIAHFDD, out IAEGHKEFOHF DPCGPJIEFDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x30238A0", Offset = "0x30226A0", VA = "0x1830238A0")]
		private bool LFCLKAMJJHD(Transform KAMDPLLJPAH, out IAEGHKEFOHF DPCGPJIEFDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x30249C0", Offset = "0x30237C0", VA = "0x1830249C0")]
		private void PLNMOHEFKNP(Entity LLEBIIAHFDD, IAEGHKEFOHF DPCGPJIEFDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x30230E0", Offset = "0x3021EE0", VA = "0x1830230E0")]
		private bool IJLCDGHNMAI(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x3021EC0", Offset = "0x3020CC0", VA = "0x183021EC0")]
		public void EHMHLLLMBAF(ELJHNEOGEBP FFJHOAAMJMD, IAEGHKEFOHF DJGPJGBFCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x3021220", Offset = "0x3020020", VA = "0x183021220")]
		public bool BOOCFLMOEMK(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x3023950", Offset = "0x3022750", VA = "0x183023950")]
		public bool MBLEKNDNMJF(IOBECAADPPL DKHOCCDNDOH, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x3024070", Offset = "0x3022E70", VA = "0x183024070")]
		public bool MBLEKNDNMJF(Entity LLEBIIAHFDD, [Optional] object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x30240C0", Offset = "0x3022EC0", VA = "0x1830240C0")]
		public bool MBLEKNDNMJF(IAEGHKEFOHF BDEPBKMNBCE, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x30216E0", Offset = "0x30204E0", VA = "0x1830216E0")]
		public bool DGOFNAPNLLM(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x30216B0", Offset = "0x30204B0", VA = "0x1830216B0")]
		public bool DGOFNAPNLLM(IAEGHKEFOHF DPCGPJIEFDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x3023D00", Offset = "0x3022B00", VA = "0x183023D00")]
		public bool MBLEKNDNMJF(IAEGHKEFOHF DPCGPJIEFDH, [Optional] object JJFHDFJGCDG, bool JOGFOOOHGFG = false, bool PFGOMMKDMKL = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x30220C0", Offset = "0x3020EC0", VA = "0x1830220C0")]
		public Transform EICBEGAJFIO(Entity LLEBIIAHFDD, [Optional] object JJFHDFJGCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x3023240", Offset = "0x3022040", VA = "0x183023240")]
		public bool JCBPEMMLHHC(Entity LLEBIIAHFDD, out Transform KAMDPLLJPAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x3023740", Offset = "0x3022540", VA = "0x183023740")]
		public IAEGHKEFOHF KOGFABJEPCO(Entity LLEBIIAHFDD, [Optional] object JJFHDFJGCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x3021C30", Offset = "0x3020A30", VA = "0x183021C30")]
		public void EACAKCNLMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x30241A0", Offset = "0x3022FA0", VA = "0x1830241A0")]
		public void NEJFDHNHMPF(SceneTag IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x3022C80", Offset = "0x3021A80", VA = "0x183022C80")]
		private void IBICBPLBJBK(Entity LLEBIIAHFDD, bool PKIPEBDNJEO, bool CLADFGPLOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x30215C0", Offset = "0x30203C0", VA = "0x1830215C0")]
		private void BPIANOMCKIG(Entity LLEBIIAHFDD, IAEGHKEFOHF DPCGPJIEFDH, bool PKIPEBDNJEO, bool CLADFGPLOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x3021AB0", Offset = "0x30208B0", VA = "0x183021AB0")]
		public IAEGHKEFOHF DJFAAIGKFKG(Entity LLEBIIAHFDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x30211A0", Offset = "0x301FFA0", VA = "0x1830211A0")]
		public bool BOLFGPMHGFA(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x30225D0", Offset = "0x30213D0", VA = "0x1830225D0")]
		public bool FKAOODJLIPP(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x3024560", Offset = "0x3023360", VA = "0x183024560")]
		public bool NFEPDLIEMIB(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x3022B40", Offset = "0x3021940", VA = "0x183022B40")]
		public bool HFJCFCGMDPD(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x3022BB0", Offset = "0x30219B0", VA = "0x183022BB0")]
		public bool HFJCFCGMDPD(ECALDJBELBI DKBLPJPHEMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void JJMEBKCFFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x30210E0", Offset = "0x301FEE0", VA = "0x1830210E0")]
		private void BNCEGFAAGFK(bool OONKNMNHLIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x3022230", Offset = "0x3021030", VA = "0x183022230")]
		private bool EIPIJDFCJON(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x3023040", Offset = "0x3021E40", VA = "0x183023040")]
		private IAEGHKEFOHF IFKECEGLBGP(Entity LLEBIIAHFDD, object JJFHDFJGCDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x3023550", Offset = "0x3022350", VA = "0x183023550")]
		private IAEGHKEFOHF JOCPAGHPJOJ(Entity LLEBIIAHFDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x30222C0", Offset = "0x30210C0", VA = "0x1830222C0")]
		private (Vector3, Quaternion, Vector3) EJHMCMJDNFC(Entity LLEBIIAHFDD)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x3020FB0", Offset = "0x301FDB0", VA = "0x183020FB0")]
		private void AFKMLBCIJHF(Entity LLEBIIAHFDD, OADLDHPKENB FKEOEHMKOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x30240E0", Offset = "0x3022EE0", VA = "0x1830240E0")]
		private void MEGHOBENLKP(IOBECAADPPL DKHOCCDNDOH, IAEGHKEFOHF DJGPJGBFCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x3023100", Offset = "0x3021F00", VA = "0x183023100")]
		private void ILMCIKMIMIE(IAEGHKEFOHF DJGPJGBFCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x3024790", Offset = "0x3023590", VA = "0x183024790")]
		private void OKMDGJPIEEI(IAEGHKEFOHF DPCGPJIEFDH, Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x3023310", Offset = "0x3022110", VA = "0x183023310")]
		private void JNKHAHDNCPD(Entity LLEBIIAHFDD, IAEGHKEFOHF DPCGPJIEFDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x3024A50", Offset = "0x3023850", VA = "0x183024A50")]
		private void PMBHODJGDCB(Entity LLEBIIAHFDD, Transform KAMDPLLJPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x3021660", Offset = "0x3020460", VA = "0x183021660")]
		private IOBECAADPPL CFMDJONBEKN(Entity LLEBIIAHFDD)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x3024B80", Offset = "0x3023980", VA = "0x183024B80")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x30224E0", Offset = "0x30212E0", VA = "0x1830224E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3042260", Offset = "0x3041060", VA = "0x183042260")]
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
			[Cpp2IlInjected.Address(RVA = "0x3026280", Offset = "0x3025080", VA = "0x183026280")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<Entity, OADLDHPKENB> JKKKCONJDDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x3025470", Offset = "0x3024270", VA = "0x183025470")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0x3025510", Offset = "0x3024310", VA = "0x183025510")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<Entity> KFPBKIEFJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x30261E0", Offset = "0x3024FE0", VA = "0x1830261E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0x3025C80", Offset = "0x3024A80", VA = "0x183025C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x3025390", Offset = "0x3024190", VA = "0x183025390", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B240", Offset = "0xA5A040", VA = "0x180A5B240", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x30256C0", Offset = "0x30244C0", VA = "0x1830256C0")]
		public bool FONENOMBNOF(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x3026180", Offset = "0x3024F80", VA = "0x183026180")]
		internal void MCPDDMJDBPC(Entity LLEBIIAHFDD, OADLDHPKENB FKEOEHMKOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x3025A80", Offset = "0x3024880", VA = "0x183025A80")]
		public void HNJDDIFBIFG(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x30255B0", Offset = "0x30243B0", VA = "0x1830255B0")]
		public void CKMHIJEDKHF(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x3025600", Offset = "0x3024400", VA = "0x183025600")]
		private bool DPMELFLAKPB(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x3025D20", Offset = "0x3024B20", VA = "0x183025D20")]
		public void KDKECGLKPJA(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x3025AC0", Offset = "0x30248C0", VA = "0x183025AC0")]
		private bool IAPGMBIDGBE(Entity LLEBIIAHFDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x30259F0", Offset = "0x30247F0", VA = "0x1830259F0")]
		public void HFPMFHPHKJM(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x3025790", Offset = "0x3024590", VA = "0x183025790")]
		private void GJFCGBCEBDM(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x3025F20", Offset = "0x3024D20", VA = "0x183025F20")]
		private void KGKOLNGMEDG(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x3025740", Offset = "0x3024540", VA = "0x183025740")]
		public void GHMIAIGFAAN(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		private void HJPPMHEKAGG(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x30257F0", Offset = "0x30245F0", VA = "0x1830257F0")]
		private void HCEDJNAABHK(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x1731AE0", Offset = "0x17308E0", VA = "0x181731AE0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x3F2BDD0", Offset = "0x3F2ABD0", VA = "0x183F2BDD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x3F22830", Offset = "0x3F21630", VA = "0x183F22830")]
			[DebuggerHidden]
			public PCCBGGBJJNG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0x3F2BBF0", Offset = "0x3F2A9F0", VA = "0x183F2BBF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0x3F2BD90", Offset = "0x3F2AB90", VA = "0x183F2BD90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0x3F2BCF0", Offset = "0x3F2AAF0", VA = "0x183F2BCF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(CKLKKHOPBLL, OADLDHPKENB)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0x3F2BCF0", Offset = "0x3F2AAF0", VA = "0x183F2BCF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3029010", Offset = "0x3027E10", VA = "0x183029010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x3029FB0", Offset = "0x3028DB0", VA = "0x183029FB0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x30287D0", Offset = "0x30275D0", VA = "0x1830287D0", Slot = "5")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x3029060", Offset = "0x3027E60", VA = "0x183029060", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x30294D0", Offset = "0x30282D0", VA = "0x1830294D0")]
		internal IEnumerable<Type> GLGFDHOEKIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x3028BB0", Offset = "0x30279B0", VA = "0x183028BB0")]
		internal CBHBFIGOJJC BGBJHDPJPFE(Type BIEGICDMJCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x3028C20", Offset = "0x3027A20", VA = "0x183028C20")]
		public EntityArchetype BGIJKCJPACC(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x3029CC0", Offset = "0x3028AC0", VA = "0x183029CC0")]
		public NativeHashMap<int, EntityArchetype> JOFNKCMPBBC(Allocator PBEDBDBGIPF = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x3029460", Offset = "0x3028260", VA = "0x183029460")]
		public bool GGGEPPDMJAM(OADLDHPKENB FKEOEHMKOOO, out EntityArchetype HNNIEOPALKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x30293F0", Offset = "0x30281F0", VA = "0x1830293F0", Slot = "4")]
		[IteratorStateMachine(typeof(PCCBGGBJJNG))]
		public IEnumerable<(CKLKKHOPBLL, OADLDHPKENB)> EJGGFAKDIJP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x3029BB0", Offset = "0x30289B0", VA = "0x183029BB0")]
		public Entity HOELGELKEPN(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x3028E90", Offset = "0x3027C90", VA = "0x183028E90")]
		public OADLDHPKENB DEOOPJFHNNH(NFAEFFLJLPD BIEGICDMJCM)
		{
			return default(OADLDHPKENB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x3028E30", Offset = "0x3027C30", VA = "0x183028E30")]
		public OADLDHPKENB DEOOPJFHNNH(CKLKKHOPBLL BIEGICDMJCM)
		{
			return default(OADLDHPKENB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x3029E40", Offset = "0x3028C40", VA = "0x183029E40")]
		public NativeHashMap<int, Entity> NGEJDCAKHOG(Allocator PBEDBDBGIPF = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x3028C80", Offset = "0x3027A80", VA = "0x183028C80")]
		public IEnumerable<OADLDHPKENB> BPNNFLIHJCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x3029390", Offset = "0x3028190", VA = "0x183029390")]
		public Entity EALMKFHLDHO(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x3029FD0", Offset = "0x3028DD0", VA = "0x183029FD0")]
		public bool OJFKBJNEHAM(OADLDHPKENB FKEOEHMKOOO, out Entity CNGLOEJDOMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x3029760", Offset = "0x3028560", VA = "0x183029760")]
		private void HEOLEHHENBD(CBHBFIGOJJC EGLDBKANHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x3029530", Offset = "0x3028330", VA = "0x183029530")]
		internal void GNNCHHEOBMA(OADLDHPKENB FKEOEHMKOOO, FEBPDFEEBHG PEHGAICDNFL, JAOIHGPNOHJ HOBLDAOCCCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x3028CD0", Offset = "0x3027AD0", VA = "0x183028CD0")]
		private void CCAPHKONKOI(OADLDHPKENB FKEOEHMKOOO, FEBPDFEEBHG ECOKHAGGAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x3028EF0", Offset = "0x3027CF0", VA = "0x183028EF0")]
		internal Entity DHAMELJAOPJ(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x302A090", Offset = "0x3028E90", VA = "0x18302A090")]
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
		[Cpp2IlInjected.Address(RVA = "0x301DCA0", Offset = "0x301CAA0", VA = "0x18301DCA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private DPNDFOCCADL HKEACGFNIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x301DF30", Offset = "0x301CD30", VA = "0x18301DF30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private GIMLBHPKKEP FDFDIFALMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x7029C0", Offset = "0x7017C0", VA = "0x1807029C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private NativeMultiHashMap<Entity, GEKCNMCMNCD> JPIJPICEMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x69EA40", Offset = "0x69D840", VA = "0x18069EA40", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, GEKCNMCMNCD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JobHandle AGHBGNDOKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x6C17B0", Offset = "0x6C05B0", VA = "0x1806C17B0", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0xB00D20", Offset = "0xAFFB20", VA = "0x180B00D20", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private bool AAKNGNKAPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x301D320", Offset = "0x301C120", VA = "0x18301D320", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private World NPGNFOCNKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x301D2C0", Offset = "0x301C0C0", VA = "0x18301D2C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x301E0B0", Offset = "0x301CEB0", VA = "0x18301E0B0")]
	public OCBHPOAFHKL(GDHNKHLBLBK DGBCJBAMILD, DBJHEIPMAIM FGMCPHKBIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x301DAB0", Offset = "0x301C8B0", VA = "0x18301DAB0", Slot = "11")]
	private void HHLFPJBFCMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x301DBB0", Offset = "0x301C9B0", VA = "0x18301DBB0", Slot = "10")]
	private bool HPBDCOPCHHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x301DF50", Offset = "0x301CD50", VA = "0x18301DF50", Slot = "12")]
	private void MAHLCHGGJGC(ComponentType JIOJHELJNAL, in CPEEMCFAHKB LBAGLBIEDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x301E080", Offset = "0x301CE80", VA = "0x18301E080", Slot = "13")]
	private bool PNIOKIKLCAO(OADLDHPKENB FKEOEHMKOOO, out Entity CNGLOEJDOMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x301DD00", Offset = "0x301CB00", VA = "0x18301DD00", Slot = "16")]
	private bool KCJODIFGPIK(out NativeArray<int> FOFDGMLFLEB, Allocator PBEDBDBGIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x301D930", Offset = "0x301C730", VA = "0x18301D930", Slot = "17")]
	private bool GLJKJBNHECA(ComponentType JIOJHELJNAL, out CPEEMCFAHKB DPMEJCEEHOC, out BCLCKEMNKIB MEOBJDMPABM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x301D800", Offset = "0x301C600", VA = "0x18301D800", Slot = "18")]
	private bool GLJKJBNHECA(ComponentType JIOJHELJNAL, out CPEEMCFAHKB DPMEJCEEHOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x301DAC0", Offset = "0x301C8C0", VA = "0x18301DAC0", Slot = "19")]
	private CPEEMCFAHKB HLCCGKDLLIM(ComponentType JIOJHELJNAL)
	{
		return default(CPEEMCFAHKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x301DDA0", Offset = "0x301CBA0", VA = "0x18301DDA0", Slot = "20")]
	private BOMPDGMHJDM KIEIKPEFEKA()
	{
		return default(BOMPDGMHJDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x301E040", Offset = "0x301CE40", VA = "0x18301E040", Slot = "21")]
	private void PLOGMGOJPEN(JobHandle BLJNDDIDOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x301D550", Offset = "0x301C350", VA = "0x18301D550")]
	public void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x301D330", Offset = "0x301C130", VA = "0x18301D330")]
	private bool GBAEDFDFLCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x301DDE0", Offset = "0x301CBE0", VA = "0x18301DDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3043440", Offset = "0x3042240", VA = "0x183043440", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public DPNDFOCCADL OLOCLANFPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F289C0", Offset = "0x3F277C0", VA = "0x183F289C0")]
			public JCOMGALMPGI(PropertyDiffStateService EBNNPKINFJN, DBJHEIPMAIM PCMNBPHPOPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0x3F289A0", Offset = "0x3F277A0", VA = "0x183F289A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public DJJBHNJFKFC JCMDNLIPNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0x3038270", Offset = "0x3037070", VA = "0x183038270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public FKGNDDGLAFM HJLILEGCFGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0x3038270", Offset = "0x3037070", VA = "0x183038270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0xB7A0F0", Offset = "0xB78EF0", VA = "0x180B7A0F0")]
		public DJJBHNJFKFC GLFAHELNCHG(DBJHEIPMAIM FGMCPHKBIAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0xB7A0F0", Offset = "0xB78EF0", VA = "0x180B7A0F0")]
		public FKGNDDGLAFM NEHIJBOLBBJ(DBJHEIPMAIM FGMCPHKBIAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x3038110", Offset = "0x3036F10", VA = "0x183038110", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x3038330", Offset = "0x3037130", VA = "0x183038330", Slot = "5")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x30382B0", Offset = "0x30370B0", VA = "0x1830382B0")]
		public void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x3038190", Offset = "0x3036F90", VA = "0x183038190", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x3038310", Offset = "0x3037110", VA = "0x183038310")]
		public JCOMGALMPGI IGPGPMKIHNN(DBJHEIPMAIM FGMCPHKBIAK)
		{
			return default(JCOMGALMPGI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x3038670", Offset = "0x3037470", VA = "0x183038670")]
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
			[Cpp2IlInjected.Address(RVA = "0x32ABED0", Offset = "0x32AACD0", VA = "0x1832ABED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public NativeArray<Entity> FGHCCKPIOGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0x6C1790", Offset = "0x6C0590", VA = "0x1806C1790")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0x1B8FE80", Offset = "0x1B8EC80", VA = "0x181B8FE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public Entity NHNMIDECFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0x32ABB00", Offset = "0x32AA900", VA = "0x1832ABB00")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public SceneTag NPLHJHNEGEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x32AC260", Offset = "0x32AB060", VA = "0x1832AC260")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public Entity HFOBIEJJLLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x32AC260", Offset = "0x32AB060", VA = "0x1832AC260")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x32AC920", Offset = "0x32AB720", VA = "0x1832AC920")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0x32AD280", Offset = "0x32AC080", VA = "0x1832AD280")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x32AB6E0", Offset = "0x32AA4E0", VA = "0x1832AB6E0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x32ABD70", Offset = "0x32AAB70", VA = "0x1832ABD70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x32AC2D0", Offset = "0x32AB0D0", VA = "0x1832AC2D0")]
		public void JPGNBEJGFKC(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x32AC840", Offset = "0x32AB640", VA = "0x1832AC840")]
		public NativeArray<Entity> KMBFOAFKKEA(Allocator PBEDBDBGIPF = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x32ABC50", Offset = "0x32AAA50", VA = "0x1832ABC50")]
		public void DEOLFEHEIGA(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x32AC990", Offset = "0x32AB790", VA = "0x1832AC990")]
		public Entity NPIGMIKDCCE(string NLCIGFDKGEE = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x32AC2B0", Offset = "0x32AB0B0", VA = "0x1832AC2B0")]
		public void JJABMNLIADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x32AB950", Offset = "0x32AA750", VA = "0x1832AB950")]
		public void AHMBPFMCKMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x32AC200", Offset = "0x32AB000", VA = "0x1832AC200")]
		public void HKIEOFLJNIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x32AB970", Offset = "0x32AA770", VA = "0x1832AB970")]
		public void BFHNELPIJEC(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x32AC870", Offset = "0x32AB670", VA = "0x1832AC870")]
		public bool MDGFADLBGOB(Entity IEGFBJCKFAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x32ABEC0", Offset = "0x32AACC0", VA = "0x1832ABEC0")]
		public void FMIKGCANBBM(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x32AC730", Offset = "0x32AB530", VA = "0x1832AC730")]
		public string KJOMBMMNFFL(Entity IEGFBJCKFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		public void NNGGOFHKKGB(Entity IEGFBJCKFAP, string NLCIGFDKGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x32AD2D0", Offset = "0x32AC0D0", VA = "0x1832AD2D0")]
		public bool OPJOLBKJCPN(string NLCIGFDKGEE, out Entity IEGFBJCKFAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x32ABDB0", Offset = "0x32AABB0", VA = "0x1832ABDB0")]
		public void EFDBMEBCDNE(Entity IEGFBJCKFAP, bool MKNDCHHPAAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x32AC310", Offset = "0x32AB110", VA = "0x1832AC310")]
		public void KEACKEMANBO(Entity LLEBIIAHFDD, bool GAHNJBCBOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x32AC480", Offset = "0x32AB280", VA = "0x1832AC480")]
		public void KEACKEMANBO(NativeArray<Entity> FNMNPGEEPJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x32AC390", Offset = "0x32AB190", VA = "0x1832AC390")]
		public void KEACKEMANBO(EntityQuery NJIBLOIMOJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x32ACFA0", Offset = "0x32ABDA0", VA = "0x1832ACFA0")]
		public void ODINILLALNF(Entity LLEBIIAHFDD, Entity IEGFBJCKFAP, bool GAHNJBCBOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x32ACDC0", Offset = "0x32ABBC0", VA = "0x1832ACDC0")]
		public void ODINILLALNF(NativeArray<Entity> FNMNPGEEPJI, Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x32AD1D0", Offset = "0x32ABFD0", VA = "0x1832AD1D0")]
		public void ODINILLALNF(EntityQuery NJIBLOIMOJA, Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x32ABF50", Offset = "0x32AAD50", VA = "0x1832ABF50")]
		private void GJPADODNBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x32ABF20", Offset = "0x32AAD20", VA = "0x1832ABF20")]
		private void GJOGMNPADKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x32ABB00", Offset = "0x32AA900", VA = "0x1832ABB00")]
		private Entity DEEGGOHPFDP()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x32AB980", Offset = "0x32AA780", VA = "0x1832AB980")]
		private void BGPLLCIMCIL(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x32ACCF0", Offset = "0x32ABAF0", VA = "0x1832ACCF0")]
		private void OACODADDBJO(EntityQuery IKMPKAEJJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x32ACA10", Offset = "0x32AB810", VA = "0x1832ACA10")]
		private void OACODADDBJO(NativeArray<Entity> OIICOGEJBID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x32AC680", Offset = "0x32AB480", VA = "0x1832AC680")]
		private void KHNCIIGFLPN(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x32AC4F0", Offset = "0x32AB2F0", VA = "0x1832AC4F0")]
		private void KEGAABLGIEM(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x32ABA60", Offset = "0x32AA860", VA = "0x1832ABA60")]
		private void CMHEGAOJPDM(SceneTag NHCEBMBHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x32ABD50", Offset = "0x32AAB50", VA = "0x1832ABD50")]
		private void DPMJLBAFFCN(SceneTag NHCEBMBHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x32AB7C0", Offset = "0x32AA5C0", VA = "0x1832AB7C0")]
		private void AGJCMJLKFGM(SceneTag NHCEBMBHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x32AC100", Offset = "0x32AAF00", VA = "0x1832AC100")]
		private void GNFBKDCBCIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x3893300", Offset = "0x3892100", VA = "0x183893300")]
		private void OGGFHBBDLDL<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void BEPHCFCBENF(SceneTag NHCEBMBHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x32AC1A0", Offset = "0x32AAFA0", VA = "0x1832AC1A0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void GNJIDOPGEEJ(EntityQuery NJIBLOIMOJA, string NLCIGFDKGEE, SceneTag NHCEBMBHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x32ABA30", Offset = "0x32AA830", VA = "0x1832ABA30")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void CCDECAEIPKK(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void FPDCJIFGJNH(Entity IEGFBJCKFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x32BB050", Offset = "0x32B9E50", VA = "0x1832BB050")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x32BABF0", Offset = "0x32B99F0", VA = "0x1832BABF0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x32BACF0", Offset = "0x32B9AF0", VA = "0x1832BACF0", Slot = "5")]
		public void JPGNBEJGFKC(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x32BAE60", Offset = "0x32B9C60", VA = "0x1832BAE60", Slot = "6")]
		public bool KDIOLKDJBFL(IOBECAADPPL DKHOCCDNDOH, Transform KAMDPLLJPAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x32BAC80", Offset = "0x32B9A80", VA = "0x1832BAC80")]
		private bool JIDMLMHEGHE(Scene IEGFBJCKFAP, out Entity LNNNFOKNAOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x32BB0A0", Offset = "0x32B9EA0", VA = "0x1832BB0A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x32B19D0", Offset = "0x32B07D0", VA = "0x1832B19D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Entity CDCPMNPKIHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager FAINNDBCGDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x32B21F0", Offset = "0x32B0FF0", VA = "0x1832B21F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x3894C30", Offset = "0x3893A30", VA = "0x183894C30")]
		public T HMFHOBMDMGG<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x3894CF0", Offset = "0x3893AF0", VA = "0x183894CF0")]
		public void NMFBOCJEJOB<T>(T GKFICKKHACC) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x32B1960", Offset = "0x32B0760", VA = "0x1832B1960", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x32B1CB0", Offset = "0x32B0AB0", VA = "0x1832B1CB0", Slot = "5")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x32B1CB0", Offset = "0x32B0AB0", VA = "0x1832B1CB0")]
		private void GAOOKPDLJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x32B19E0", Offset = "0x32B07E0", VA = "0x1832B19E0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x32B1EF0", Offset = "0x32B0CF0", VA = "0x1832B1EF0")]
		private FEBPDFEEBHG OCAEAGGBPCA()
		{
			return default(FEBPDFEEBHG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		private static void NCPLMEAFIMJ(int CGKKILDEEIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
		private static void HPPKJEHEOLN(Type BIEGICDMJCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x32B1E50", Offset = "0x32B0C50", VA = "0x1832B1E50")]
		private static void LCJLBCBLACN(Type BIEGICDMJCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public GELKDICEMGM BENLBOJEHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public GELKDICEMGM ANPCBJDELNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public GELKDICEMGM BOAJKBOMOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x670E50", Offset = "0x66FC50", VA = "0x180670E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public GELKDICEMGM DKIEFMOAGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x64F720", Offset = "0x64E520", VA = "0x18064F720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public GELKDICEMGM ONKPDNCPLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x652A00", Offset = "0x651800", VA = "0x180652A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private EntityManager FAINNDBCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x34054E0", Offset = "0x34042E0", VA = "0x1834054E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x34052E0", Offset = "0x34040E0", VA = "0x1834052E0", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x34053F0", Offset = "0x34041F0", VA = "0x1834053F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x21CC5B0", Offset = "0x21CB3B0", VA = "0x1821CC5B0")]
	private void BLNLPEOGOOG<T>(ref global::PBJIHBFONCG<T> MPPBBBHMGNE) where T : struct, NEJDHLEFDKK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x21CC5B0", Offset = "0x21CB3B0", VA = "0x1821CC5B0")]
	private void BLNLPEOGOOG<TC, TV>(ref global::AFDHPHLDLGD<TC, TV> MPPBBBHMGNE) where TC : struct, NEJDHLEFDKK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xEDF190", Offset = "0xEDDF90", VA = "0x180EDF190")]
		get
		{
			return default(NNEFJHMAAJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x3409960", Offset = "0x3408760", VA = "0x183409960", Slot = "4")]
	public void LBEJDBOEOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x3409950", Offset = "0x3408750", VA = "0x183409950", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F23420", Offset = "0x3F22220", VA = "0x183F23420")]
			public DALPDADMLGN(TransformOwnershipPhase GEOFAMNLJNK, AMOOKDFHMCI FGMCPHKBIAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0x3F23400", Offset = "0x3F22200", VA = "0x183F23400", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6695E0", Offset = "0x6683E0", VA = "0x1806695E0")]
			get
			{
				return default(AMOOKDFHMCI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF1")]
			[Cpp2IlInjected.Address(RVA = "0x6C1BA0", Offset = "0x6C09A0", VA = "0x1806C1BA0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool FFFBFIJCFFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0x1012F40", Offset = "0x1011D40", VA = "0x181012F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool DLLLFGCPFNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x1C4E740", Offset = "0x1C4D540", VA = "0x181C4E740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x32B5500", Offset = "0x32B4300", VA = "0x1832B5500")]
		public DALPDADMLGN CGHIJJODGEO()
		{
			return default(DALPDADMLGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x32B5530", Offset = "0x32B4330", VA = "0x1832B5530")]
		public DALPDADMLGN OABHNBAIHLM()
		{
			return default(DALPDADMLGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3410350", Offset = "0x340F150", VA = "0x183410350", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x3410970", Offset = "0x340F770", VA = "0x183410970", Slot = "5")]
		public bool EKGKADHGOHE(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x3410B30", Offset = "0x340F930", VA = "0x183410B30", Slot = "7")]
		public Guid JNFAOAHMNMD(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x3410710", Offset = "0x340F510", VA = "0x183410710", Slot = "8")]
		public void EHPALCMGIMM(IOBECAADPPL DKHOCCDNDOH, Guid AEOGKHCDJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x3410D90", Offset = "0x340FB90", VA = "0x183410D90", Slot = "9")]
		public Guid NCJDGJCCCNG(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x3410E60", Offset = "0x340FC60", VA = "0x183410E60", Slot = "10")]
		public void NJAHGMKKFIF(IOBECAADPPL DKHOCCDNDOH, Guid CACOMCKALGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x3410A70", Offset = "0x340F870", VA = "0x183410A70", Slot = "11")]
		public bool FINGKDHNNDD(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x3410AC0", Offset = "0x340F8C0", VA = "0x183410AC0", Slot = "12")]
		public void IBJMEMCBDAH(IOBECAADPPL DKHOCCDNDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x34110C0", Offset = "0x340FEC0", VA = "0x1834110C0", Slot = "13")]
		public void PJIFNCEKDIO(IOBECAADPPL EHPFANFOFFJ, IOBECAADPPL GEOFAMNLJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x3410540", Offset = "0x340F340", VA = "0x183410540")]
		private void BDNNBHMIMFH(ODJCHDGAKOE OHOEEFLINMK, IOBECAADPPL GEOFAMNLJNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x3410C00", Offset = "0x340FA00", VA = "0x183410C00")]
		private void MNKLDBELFJB(ODJCHDGAKOE OHOEEFLINMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x34103F0", Offset = "0x340F1F0", VA = "0x1834103F0")]
		private bool ADAJJHMBKIM(MFPKOBHCDLK KMFLGGMLFJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x34102A0", Offset = "0x340F0A0", VA = "0x1834102A0")]
		private bool ABCONEGICDO(MFPKOBHCDLK KMFLGGMLFJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x34106B0", Offset = "0x340F4B0", VA = "0x1834106B0", Slot = "6")]
		public bool BJHJPLHHPME(IOBECAADPPL IBGBBCHPJJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6CF580", Offset = "0x6CE380", VA = "0x1806CF580", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x32A73E0", Offset = "0x32A61E0", VA = "0x1832A73E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x6CF620", Offset = "0x6CE420", VA = "0x1806CF620")]
			[DebuggerHidden]
			public DFJHPFMHIOP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x32A7430", Offset = "0x32A6230", VA = "0x1832A7430", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x32A6FF0", Offset = "0x32A5DF0", VA = "0x1832A6FF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x32A7500", Offset = "0x32A6300", VA = "0x1832A7500")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x32A7550", Offset = "0x32A6350", VA = "0x1832A7550")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0x32A73A0", Offset = "0x32A61A0", VA = "0x1832A73A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0x32A72F0", Offset = "0x32A60F0", VA = "0x1832A72F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IOBECAADPPL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0x32A72F0", Offset = "0x32A60F0", VA = "0x1832A72F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x65ACF0", Offset = "0x659AF0", VA = "0x18065ACF0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x65AEA0", Offset = "0x659CA0", VA = "0x18065AEA0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action<IOBECAADPPL, IOBECAADPPL> FNDGPAIFNPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x34162B0", Offset = "0x34150B0", VA = "0x1834162B0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x3416010", Offset = "0x3414E10", VA = "0x183416010", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<IOBECAADPPL, IOBECAADPPL> ACAJAAMOFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x3415500", Offset = "0x3414300", VA = "0x183415500", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0x34164F0", Offset = "0x34152F0", VA = "0x1834164F0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<IOBECAADPPL, IOBECAADPPL, IOBECAADPPL> NJOOMMEPIMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x3415100", Offset = "0x3413F00", VA = "0x183415100", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0x3416210", Offset = "0x3415010", VA = "0x183416210", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<IOBECAADPPL> PBKNHLPGMBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x3415820", Offset = "0x3414620", VA = "0x183415820", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x3416110", Offset = "0x3414F10", VA = "0x183416110", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x34152F0", Offset = "0x34140F0", VA = "0x1834152F0", Slot = "25")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x3416710", Offset = "0x3415510", VA = "0x183416710", Slot = "26")]
		public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x3415A00", Offset = "0x3414800", VA = "0x183415A00", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x34160B0", Offset = "0x3414EB0", VA = "0x1834160B0")]
		private void HNOJKDAIFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x3416D70", Offset = "0x3415B70", VA = "0x183416D70")]
		private void PPGFGMFMLAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x3416BB0", Offset = "0x34159B0", VA = "0x183416BB0")]
		private void PBLGDHADCNK(Entity LLEBIIAHFDD, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG KNAEAKFNOOB, EKBGHCIKEGG OCBHJKLFMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x34161B0", Offset = "0x3414FB0", VA = "0x1834161B0")]
		private void IGOMDDOHLMI(Entity LLEBIIAHFDD, EBLKGKAPHAO KBPOLLDMHFK, EKBGHCIKEGG KNAEAKFNOOB, EKBGHCIKEGG OCBHJKLFMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x24EA180", Offset = "0x24E8F80", VA = "0x1824EA180", Slot = "14")]
		public IOBECAADPPL LNMAHJLADNI(IOBECAADPPL DKHOCCDNDOH, int IHGMGOCCNON)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x19A34D0", Offset = "0x19A22D0", VA = "0x1819A34D0", Slot = "15")]
		public Color LJEIGNJPKLB(IOBECAADPPL DKHOCCDNDOH, int IHGMGOCCNON)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x3415C60", Offset = "0x3414A60", VA = "0x183415C60", Slot = "16")]
		public float3 EOFJDDOPGDC(IOBECAADPPL DKHOCCDNDOH, int IHGMGOCCNON)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x3415BB0", Offset = "0x34149B0", VA = "0x183415BB0", Slot = "17")]
		public bool EGBLGMFAHDK(IOBECAADPPL DKHOCCDNDOH, IOBECAADPPL KIEHIJDIGFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x34158C0", Offset = "0x34146C0", VA = "0x1834158C0", Slot = "18")]
		public IOBECAADPPL CJPGOFCPNMB(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x34151A0", Offset = "0x3413FA0", VA = "0x1834151A0", Slot = "21")]
		public void ABHMOHCGNLA(IOBECAADPPL DKHOCCDNDOH, Vector3 MKIHHFBJJGN, Quaternion PPNKJHLAKEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x3416450", Offset = "0x3415250", VA = "0x183416450", Slot = "23")]
		public float3 MOLNIJINIFE(MPJDICPJEKH JCJOBGHJFHL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x3415970", Offset = "0x3414770", VA = "0x183415970", Slot = "24")]
		public quaternion DDOOBPNBMJE(MPJDICPJEKH JCJOBGHJFHL)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x3416350", Offset = "0x3415150", VA = "0x183416350", Slot = "28")]
		public RigidTransform KIFODFDAPCC(MPJDICPJEKH JCJOBGHJFHL)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x3416590", Offset = "0x3415390", VA = "0x183416590", Slot = "22")]
		public bool OHOMDHPOMAI(IOBECAADPPL DKHOCCDNDOH, out RigidTransform ONKKOPCHPEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x3415470", Offset = "0x3414270", VA = "0x183415470", Slot = "19")]
		[IteratorStateMachine(typeof(DFJHPFMHIOP))]
		public IEnumerable<IOBECAADPPL> AEAPHGIOGBJ(IOBECAADPPL DKHOCCDNDOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x34156C0", Offset = "0x34144C0", VA = "0x1834156C0", Slot = "20")]
		public IOBECAADPPL BIDIHIMLIFL(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x3415E40", Offset = "0x3414C40", VA = "0x183415E40", Slot = "29")]
		public void GMMJFMIEKCE(ref List<IOBECAADPPL> DFMCPPMHIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x34155A0", Offset = "0x34143A0", VA = "0x1834155A0")]
		private Entity BIDIHIMLIFL(Entity LLEBIIAHFDD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x3416F70", Offset = "0x3415D70", VA = "0x183416F70")]
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
			[Cpp2IlInjected.Address(RVA = "0x3024FB0", Offset = "0x3023DB0", VA = "0x183024FB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x3024C00", Offset = "0x3023A00", VA = "0x183024C00", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x3024E40", Offset = "0x3023C40", VA = "0x183024E40")]
		public Entity CMKBHBIKKLG(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x3024D30", Offset = "0x3023B30", VA = "0x183024D30")]
		public Entity BBEBKABPFOC(ELJHNEOGEBP FFJHOAAMJMD, OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x3024ED0", Offset = "0x3023CD0", VA = "0x183024ED0")]
		public Entity HCPNNJMCDBO(OADLDHPKENB FKEOEHMKOOO, bool KCJPFJDMHDE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x3024EC0", Offset = "0x3023CC0", VA = "0x183024EC0")]
		public Entity HCPNNJMCDBO(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x3025100", Offset = "0x3023F00", VA = "0x183025100")]
		public Entity MJFCMEDMLAE()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x3025000", Offset = "0x3023E00", VA = "0x183025000")]
		public Entity KHIJCCNCJJA(CKLKKHOPBLL BIEGICDMJCM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x3025080", Offset = "0x3023E80", VA = "0x183025080")]
		public Entity KHOBNGEHLKF(NFAEFFLJLPD BIEGICDMJCM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x3024F60", Offset = "0x3023D60", VA = "0x183024F60")]
		public NativeArray<(IOBECAADPPL, IOBECAADPPL)> HOELGELKEPN(NativeArray<IOBECAADPPL> PDHJHNDNLLA, Allocator PBEDBDBGIPF)
		{
			return default(NativeArray<(IOBECAADPPL, IOBECAADPPL)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x3024DF0", Offset = "0x3023BF0", VA = "0x183024DF0")]
		public IEnumerable<OADLDHPKENB> BPNNFLIHJCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x3024D90", Offset = "0x3023B90", VA = "0x183024D90")]
		public EntityArchetype BGIJKCJPACC(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x3024E60", Offset = "0x3023C60", VA = "0x183024E60")]
		public Entity EALMKFHLDHO(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x30251A0", Offset = "0x3023FA0", VA = "0x1830251A0")]
		private Entity NPIDNGBOMFN(OADLDHPKENB FKEOEHMKOOO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x3025110", Offset = "0x3023F10", VA = "0x183025110")]
		private Entity NPIDNGBOMFN(OADLDHPKENB FKEOEHMKOOO, bool KCJPFJDMHDE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x3025220", Offset = "0x3024020", VA = "0x183025220")]
		private Entity NPIDNGBOMFN(OADLDHPKENB FKEOEHMKOOO, ELJHNEOGEBP FFJHOAAMJMD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x30324F0", Offset = "0x30312F0", VA = "0x1830324F0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x3032340", Offset = "0x3031140", VA = "0x183032340", Slot = "9")]
		public void LBEJDBOEOKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x3031A50", Offset = "0x3030850", VA = "0x183031A50", Slot = "10")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x3031E10", Offset = "0x3030C10", VA = "0x183031E10", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x3031CC0", Offset = "0x3030AC0", VA = "0x183031CC0", Slot = "4")]
		public PFMNCAAGPOA DCEGMKGONFB(Entity LLEBIIAHFDD)
		{
			return default(PFMNCAAGPOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x3031F10", Offset = "0x3030D10", VA = "0x183031F10", Slot = "5")]
		public void FNJLLMLOGEJ(NativeArray<PFMNCAAGPOA> EDNKBFACCBI, NativeArray<FLJBFMJPKBF> BDLOKEMJJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x3032240", Offset = "0x3031040", VA = "0x183032240", Slot = "6")]
		public void JGPJDMKECAM(PFMNCAAGPOA DKBLPJPHEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x3032AA0", Offset = "0x30318A0", VA = "0x183032AA0", Slot = "7")]
		public bool NALJILADCDM(PFMNCAAGPOA DKBLPJPHEMF, out Collider KIHMMOLIPKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x3032790", Offset = "0x3031590", VA = "0x183032790")]
		public bool MONBAJCOINP(in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, float BNDBJFDKNPP, Allocator PBEDBDBGIPF, out NativeArray<Entity> FNMNPGEEPJI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x3031C70", Offset = "0x3030A70", VA = "0x183031C70")]
		private void CNMDBLACLJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x65C5B0", Offset = "0x65B3B0", VA = "0x18065C5B0")]
		private void NCBCBPFIIKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x3032530", Offset = "0x3031330", VA = "0x183032530")]
		private void MIEOHNHHGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x1B5AF90", Offset = "0x1B59D90", VA = "0x181B5AF90")]
		private void KDMJBDDBLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x3031B50", Offset = "0x3030950", VA = "0x183031B50")]
		private BoxCollider CFBFCBAGGPD(Entity LLEBIIAHFDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x3032B40", Offset = "0x3031940", VA = "0x183032B40")]
		private void NKJODIDAOJG(BoxCollider JCJFKODMEAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x30324B0", Offset = "0x30312B0", VA = "0x1830324B0")]
		[Conditional("UNITY_EDITOR")]
		private void LDABOMLKGOG(GameObject ENOCMPCACJI, Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x3032BD0", Offset = "0x30319D0", VA = "0x183032BD0")]
		private void PFBLFMILPNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x3032120", Offset = "0x3030F20", VA = "0x183032120")]
		private void HGNJCCJMGDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x3032580", Offset = "0x3031380", VA = "0x183032580")]
		private void MJJBLBIIDMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x3032310", Offset = "0x3031110", VA = "0x183032310")]
		private void JLLLFKJKLIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x3032230", Offset = "0x3031030", VA = "0x183032230")]
		private void HMAIHMMIOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x3031B10", Offset = "0x3030910", VA = "0x183031B10")]
		private void BIBEKOKLCOM(Scene EDHJEJLJKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x3032BC0", Offset = "0x30319C0", VA = "0x183032BC0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x340EF70", Offset = "0x340DD70", VA = "0x18340EF70", Slot = "5")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x340F120", Offset = "0x340DF20", VA = "0x18340F120")]
	public bool MONBAJCOINP(in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, float BNDBJFDKNPP, out LDEMHFFKMJA JMANGKEIMKL, out Entity JIBKKEGHDFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x340EFE0", Offset = "0x340DDE0", VA = "0x18340EFE0")]
	public static bool EEAMGGJEEKE(in Span<LDEMHFFKMJA> NMIGPODFJPC, float BNDBJFDKNPP, out int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x340F0F0", Offset = "0x340DEF0", VA = "0x18340F0F0")]
	public static float HBBFMCOKMFC(float ACKCJINFPBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public CLMNGKAHJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x340F0E0", Offset = "0x340DEE0", VA = "0x18340F0E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x32A5CC0", Offset = "0x32A4AC0", VA = "0x1832A5CC0", Slot = "4")]
		public void Execute(int BNNEENLPEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x32A5BF0", Offset = "0x32A49F0", VA = "0x1832A5BF0")]
		private static float3 EPFAHMGOHOG(in float4x4 BFMGJHLMDCF, in float3 KNNJFFBFLLC)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x32A6CE0", Offset = "0x32A5AE0", VA = "0x1832A6CE0")]
		private static float3 MANNPBNHKOL(in float4x4 BFMGJHLMDCF, in float3 EIEOEGFMKEB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x32A5FA0", Offset = "0x32A4DA0", VA = "0x1832A5FA0")]
		private static float3 GIOEKAHLOGB(in float4x4 BFMGJHLMDCF, in float3 KNNJFFBFLLC)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x32A6AC0", Offset = "0x32A58C0", VA = "0x1832A6AC0")]
		private static float3 LFOBEAOCFAC(in float4x4 BFMGJHLMDCF, in float3 EIEOEGFMKEB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x32A60A0", Offset = "0x32A4EA0", VA = "0x1832A60A0")]
		private bool HLJMEBPGBIB(in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, in NativeArray<Entity> GGIAPIKIKNH, out float3 JMANGKEIMKL, out float3 LCGGEIEGEMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x32A63F0", Offset = "0x32A51F0", VA = "0x1832A63F0")]
		public static bool IBCDBEEAJJN(in float3 JAIPDBGOMKM, in float3 IIJDNKGDMDP, in float3 MCHFLPBEDEK, in float3 CLMJFCGNBPH, float MDGOFEABDJP, float OMBIPCFENEK, out float NDJEJACDKEB, out float3 HBHJEHMNJME)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityManager CLLNDNAAIKP;

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x3407CD0", Offset = "0x3406AD0", VA = "0x183407CD0", Slot = "5")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x3407D60", Offset = "0x3406B60", VA = "0x183407D60")]
	public void MONBAJCOINP(in NativeArray<Entity> FNMNPGEEPJI, in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, in NativeArray<LDEMHFFKMJA> MDDCMLHCIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public BCEOMPMDMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x3407D50", Offset = "0x3406B50", VA = "0x183407D50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E20B0", Offset = "0x8E0EB0", VA = "0x1808E20B0")]
			get
			{
				return default(NativeHashMap<ELJHNEOGEBP, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		internal uint PPDLLCINMBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0x3028500", Offset = "0x3027300", VA = "0x183028500")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool AACDAEOPAIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x6745E0", Offset = "0x6733E0", VA = "0x1806745E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x674AD0", Offset = "0x6738D0", VA = "0x180674AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x3027FC0", Offset = "0x3026DC0", VA = "0x183027FC0", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x3028170", Offset = "0x3026F70", VA = "0x183028170", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x3028320", Offset = "0x3027120", VA = "0x183028320")]
		public void GJPIAAEOJAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x3028530", Offset = "0x3027330", VA = "0x183028530")]
		public void OGOOAHIPOBJ(ELJHNEOGEBP FFJHOAAMJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x3028140", Offset = "0x3026F40", VA = "0x183028140")]
		private IOBECAADPPL CFMDJONBEKN(Entity LLEBIIAHFDD)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x30281E0", Offset = "0x3026FE0", VA = "0x1830281E0")]
		public IOBECAADPPL FEEDHGOGJCP(ELJHNEOGEBP FFJHOAAMJMD)
		{
			return default(IOBECAADPPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x3028470", Offset = "0x3027270", VA = "0x183028470")]
		public ELJHNEOGEBP HLAFIPJDKEG(IOBECAADPPL DKHOCCDNDOH)
		{
			return default(ELJHNEOGEBP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x30286F0", Offset = "0x30274F0", VA = "0x1830286F0")]
		public void POKNHJBIMCE(Entity LLEBIIAHFDD, ELJHNEOGEBP FFJHOAAMJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x30280E0", Offset = "0x3026EE0", VA = "0x1830280E0")]
		public void BOFJHMHGCNK(Entity LLEBIIAHFDD, ELJHNEOGEBP FFJHOAAMJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x30282C0", Offset = "0x30270C0", VA = "0x1830282C0")]
		public void FPFHLEEEBFO(Entity LLEBIIAHFDD, ELJHNEOGEBP FFJHOAAMJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x30283A0", Offset = "0x30271A0", VA = "0x1830283A0")]
		public void HCFKHHNMKFG(Entity LLEBIIAHFDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3039440", Offset = "0x3038240", VA = "0x183039440")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0x30398F0", Offset = "0x30386F0", VA = "0x1830398F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action NHCHFBAOMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0x30389E0", Offset = "0x30377E0", VA = "0x1830389E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x3038C80", Offset = "0x3037A80", VA = "0x183038C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x3038710", Offset = "0x3037510", VA = "0x183038710", Slot = "4")]
		public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x3038A80", Offset = "0x3037880", VA = "0x183038A80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x3038B10", Offset = "0x3037910", VA = "0x183038B10")]
		public void EHMHLLLMBAF(EBLKGKAPHAO KBPOLLDMHFK, BGECCGMLMIN PKPGAEOFIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x3039350", Offset = "0x3038150", VA = "0x183039350")]
		public void JBEMCCBAFHO(EBLKGKAPHAO KBPOLLDMHFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x3039660", Offset = "0x3038460", VA = "0x183039660")]
		internal void PIDBAJFFBNN(DJJBHNJFKFC OPCGPJFHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0x3038D20", Offset = "0x3037B20", VA = "0x183038D20")]
		private void FFDKJBFAGGC(DJJBHNJFKFC OPCGPJFHEJB, int BGAEBMDLBPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x3038760", Offset = "0x3037560", VA = "0x183038760")]
		private void CPBKFBNCCJD(FPHEKKDEPIJ LGPKKGCJHDG, FIOMMIJIHBF NAKDLIMKJJM, CICKGNDJHIH JJHOKNDGMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x30394E0", Offset = "0x30382E0", VA = "0x1830394E0")]
		private BFIOILDIGEF MEMKHEHJIFE(FPHEKKDEPIJ LGPKKGCJHDG, FIOMMIJIHBF NAKDLIMKJJM)
		{
			return default(BFIOILDIGEF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x3039260", Offset = "0x3038060", VA = "0x183039260")]
		private CICKGNDJHIH HDIFFJJDBLC(BFIOILDIGEF MEOBJDMPABM, FPHEKKDEPIJ LGPKKGCJHDG, FIOMMIJIHBF NAKDLIMKJJM)
		{
			return default(CICKGNDJHIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x30399E0", Offset = "0x30387E0", VA = "0x1830399E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6CF580", Offset = "0x6CE380", VA = "0x1806CF580", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F2B250", Offset = "0x3F2A050", VA = "0x183F2B250", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x6CF620", Offset = "0x6CE420", VA = "0x1806CF620")]
		[DebuggerHidden]
		public NIPBDABMIJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B0A0", Offset = "0x3F29EA0", VA = "0x183F2B0A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B210", Offset = "0x3F2A010", VA = "0x183F2B210", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B160", Offset = "0x3F29F60", VA = "0x183F2B160", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IOBECAADPPL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x3F2B160", Offset = "0x3F29F60", VA = "0x183F2B160", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3048A40", Offset = "0x3047840", VA = "0x183048A40")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private DKCCOABIFKH NBPAAHMKIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x3048980", Offset = "0x3047780", VA = "0x183048980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x3047C70", Offset = "0x3046A70", VA = "0x183047C70", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x3048A90", Offset = "0x3047890", VA = "0x183048A90", Slot = "5")]
	public void OJPFNPOJAIL(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x3048340", Offset = "0x3047140", VA = "0x183048340", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x3048B90", Offset = "0x3047990", VA = "0x183048B90")]
	private void PGKICGFFCBB(Entity HNBNLLKPAMD, in EKBGHCIKEGG NGJIGMLFLLA, in EKBGHCIKEGG IOOLGMDKBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x3048920", Offset = "0x3047720", VA = "0x183048920", Slot = "14")]
	public IOBECAADPPL MJFCMEDMLAE()
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x30483F0", Offset = "0x30471F0", VA = "0x1830483F0", Slot = "10")]
	public void EKBKDKEFFBE(IOBECAADPPL DKHOCCDNDOH, MGFCLCMDHID ENIALHNPBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x30487D0", Offset = "0x30475D0", VA = "0x1830487D0", Slot = "9")]
	public MGFCLCMDHID KEEDCNJLFLB(IOBECAADPPL DKHOCCDNDOH)
	{
		return default(MGFCLCMDHID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x3047DE0", Offset = "0x3046BE0", VA = "0x183047DE0", Slot = "11")]
	public IOBECAADPPL DBFMHLFNHAH(IOBECAADPPL DKJMIMOCJNG, [Optional] Vector3? DKGAADMNOOM, [Optional] Quaternion? MPLPNDNEAPK, [Optional] Vector3? OLIFDPKHJEC)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x3047D00", Offset = "0x3046B00", VA = "0x183047D00", Slot = "15")]
	public IOBECAADPPL ADHCIOCCAEF(IOBECAADPPL FMMJCODIJBA, int BNNEENLPEFO, [Optional] Vector3? DKGAADMNOOM, [Optional] Quaternion? MPLPNDNEAPK, [Optional] Vector3? OLIFDPKHJEC)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x30484B0", Offset = "0x30472B0", VA = "0x1830484B0", Slot = "7")]
	public IOBECAADPPL GKDMKALFMBB(IOBECAADPPL FMMJCODIJBA, int BNNEENLPEFO)
	{
		return default(IOBECAADPPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x3048280", Offset = "0x3047080", VA = "0x183048280", Slot = "16")]
	public void DOPDMOBAOFN(IOBECAADPPL FMMJCODIJBA, IOBECAADPPL HHODAAKNPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x30480E0", Offset = "0x3046EE0", VA = "0x1830480E0", Slot = "12")]
	public void DJLENOLAHEP(IOBECAADPPL FMMJCODIJBA, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x30485A0", Offset = "0x30473A0", VA = "0x1830485A0", Slot = "17")]
	public void JGFDNFNJHJK(IOBECAADPPL FMMJCODIJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x3047D40", Offset = "0x3046B40", VA = "0x183047D40", Slot = "8")]
	public int AOIENNFPGDN(IOBECAADPPL FMMJCODIJBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x3048890", Offset = "0x3047690", VA = "0x183048890", Slot = "6")]
	[IteratorStateMachine(typeof(NIPBDABMIJD))]
	public IEnumerable<IOBECAADPPL> MCACMLIHPPC(IOBECAADPPL FMMJCODIJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x3048740", Offset = "0x3047540", VA = "0x183048740")]
	private bool JPOOJJKKOCN(IOBECAADPPL FMMJCODIJBA, out NativeArray<Entity> KPOBDKLHLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x3047BB0", Offset = "0x30469B0", VA = "0x183047BB0")]
	private NativeArray<Entity> AAFPHDCGPDC(IOBECAADPPL FMMJCODIJBA)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3058A90", Offset = "0x3057890", VA = "0x183058A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x3058650", Offset = "0x3057450", VA = "0x183058650", Slot = "4")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x30589A0", Offset = "0x30577A0", VA = "0x1830589A0")]
	public void NOOADEJEPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x30586D0", Offset = "0x30574D0", VA = "0x1830586D0")]
	public void IOCMNCHKFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x30426E0", Offset = "0x30414E0", VA = "0x1830426E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x3042840", Offset = "0x3041640", VA = "0x183042840")]
	public FLEAMIMIFOO(Type BIEGICDMJCM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x30427C0", Offset = "0x30415C0", VA = "0x1830427C0")]
	public static FLEAMIMIFOO KPOCFOKDNEC(Type BIEGICDMJCM)
	{
		return default(FLEAMIMIFOO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x30427F0", Offset = "0x30415F0", VA = "0x1830427F0")]
	public static Type KPOCFOKDNEC(FLEAMIMIFOO DKBLPJPHEMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E40", Offset = "0x6CFC40", VA = "0x1806D0E40")]
	public static bool IKJLJMIELNH(FLEAMIMIFOO LEOEMBMBFBC, FLEAMIMIFOO GHDGKPNPOBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x6D0E40", Offset = "0x6CFC40", VA = "0x1806D0E40")]
	public static bool NKIHKFGIBBG(FLEAMIMIFOO LEOEMBMBFBC, FLEAMIMIFOO GHDGKPNPOBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x6D0A00", Offset = "0x6CF800", VA = "0x1806D0A00", Slot = "4")]
	public bool Equals(FLEAMIMIFOO MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x3042660", Offset = "0x3041460", VA = "0x183042660", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x6945A0", Offset = "0x6933A0", VA = "0x1806945A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x3042810", Offset = "0x3041610", VA = "0x183042810", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3051F20", Offset = "0x3050D20", VA = "0x183051F20")]
	static JOFAJHCMOPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x28F84C0", Offset = "0x28F72C0", VA = "0x1828F84C0")]
	public static bool ELGBPIMHCCH<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x3051BE0", Offset = "0x30509E0", VA = "0x183051BE0")]
	public static bool ELGBPIMHCCH(Type BIEGICDMJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x3051A70", Offset = "0x3050870", VA = "0x183051A70")]
	private static bool ELGBPIMHCCH(Type BIEGICDMJCM, out int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x28F85F0", Offset = "0x28F73F0", VA = "0x1828F85F0")]
	public static int KAAMKKLEPKC<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0x3051EB0", Offset = "0x3050CB0", VA = "0x183051EB0")]
	public static int KAAMKKLEPKC(Type BIEGICDMJCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x28F8550", Offset = "0x28F7350", VA = "0x1828F8550")]
	public static bool GIGGJMBFKKD<T>(out int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0x3051C50", Offset = "0x3050A50", VA = "0x183051C50")]
	public static bool GIGGJMBFKKD(Type BIEGICDMJCM, out int BNNEENLPEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0x3051E10", Offset = "0x3050C10", VA = "0x183051E10")]
	public static Type HMFHOBMDMGG(int BNNEENLPEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0x3051CF0", Offset = "0x3050AF0", VA = "0x183051CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D4910", Offset = "0x6D3710", VA = "0x1806D4910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public T OPKHBNOGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x2597400", Offset = "0x2596200", VA = "0x182597400")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Span<T> IJKLJFCPNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x2597440", Offset = "0x2596240", VA = "0x182597440")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool MOCJDAMLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0x895100", Offset = "0x893F00", VA = "0x180895100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x2597590", Offset = "0x2596390", VA = "0x182597590")]
	public ILNKBMENBMN(int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x25974E0", Offset = "0x25962E0", VA = "0x1825974E0")]
	public int NJHNFHMHPKP(T GKFICKKHACC, int HOKMFDPKLJA, int CGKKILDEEIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x2597340", Offset = "0x2596140", VA = "0x182597340", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x33461C0", Offset = "0x3344FC0", VA = "0x1833461C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int ONIEICNEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x6695E0", Offset = "0x6683E0", VA = "0x1806695E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0x3346E50", Offset = "0x3345C50", VA = "0x183346E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public int ODJEFCECEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x3345A70", Offset = "0x3344870", VA = "0x183345A70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x3346E00", Offset = "0x3345C00", VA = "0x183346E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool MOCJDAMLGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x3345CE0", Offset = "0x3344AE0", VA = "0x183345CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Span<T> IJKLJFCPNDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD8")]
		[Cpp2IlInjected.Address(RVA = "0x3346A10", Offset = "0x3345810", VA = "0x183346A10")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x33473C0", Offset = "0x33461C0", VA = "0x1833473C0")]
	public HLHBPJICIEM(int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x3345A20", Offset = "0x3344820", VA = "0x183345A20")]
	public T AMHEONNAKAE(int BNNEENLPEFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x33466C0", Offset = "0x33454C0", VA = "0x1833466C0")]
	public void IPBGPNMPFBC(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x3346C30", Offset = "0x3345A30", VA = "0x183346C30")]
	public void LFOALHHAKED(Span<T> LENGKEKMOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x3345EB0", Offset = "0x3344CB0", VA = "0x183345EB0")]
	public void ELGBPIMHCCH(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x3346730", Offset = "0x3345530", VA = "0x183346730")]
	private void JGKFODNAOGE(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x3345AA0", Offset = "0x33448A0", VA = "0x183345AA0")]
	public void CIOCKIHBBLE(Span<T> CKIGFGIEPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x3346DA0", Offset = "0x3345BA0", VA = "0x183346DA0")]
	public void LJFPNHIPEPF(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x3346FE0", Offset = "0x3345DE0", VA = "0x183346FE0")]
	public void NIIPNPGNCJL(int GPJOCANBBFF, int OCMAALMMILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x3346450", Offset = "0x3345250", VA = "0x183346450")]
	public void IFFLOFKJNLP(int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x33464B0", Offset = "0x33452B0", VA = "0x1833464B0")]
	public void IJKOEFHGNEH(int GPJOCANBBFF, int OCMAALMMILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x3345FC0", Offset = "0x3344DC0", VA = "0x183345FC0")]
	public void EOEFHHKOEKK(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x3347290", Offset = "0x3346090", VA = "0x183347290")]
	public void OMLABMPDPFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x3347200", Offset = "0x3346000", VA = "0x183347200")]
	public int NJHNFHMHPKP(T GKFICKKHACC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x3346B60", Offset = "0x3345960", VA = "0x183346B60")]
	public bool KOOJGAMNGBI(T GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x3345E60", Offset = "0x3344C60", VA = "0x183345E60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x3347350", Offset = "0x3346150", VA = "0x183347350", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x3346BC0", Offset = "0x33459C0", VA = "0x183346BC0")]
	public static Span<T> KPOCFOKDNEC(global::HLHBPJICIEM<T> LENGKEKMOEB)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x3346080", Offset = "0x3344E80", VA = "0x183346080")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void FANPLINEAPE(int GKFICKKHACC, int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void JJKNDABEBED(int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x33468B0", Offset = "0x33456B0", VA = "0x1833468B0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void JJKNDABEBED(int PMIIGNOLFGJ, int BNNEENLPEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x3346EA0", Offset = "0x3345CA0", VA = "0x183346EA0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void NEGBJHDDMHK(int GKFICKKHACC, int PMIIGNOLFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x3346250", Offset = "0x3345050", VA = "0x183346250")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void ICGGEJFKGMD(int GPJOCANBBFF, int OCMAALMMILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF0")]
	[Cpp2IlInjected.Address(RVA = "0x3345D20", Offset = "0x3344B20", VA = "0x183345D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x301BCB0", Offset = "0x301AAB0", VA = "0x18301BCB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public NativeList<Entity> LDPOBABEIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x65E2E0", Offset = "0x65D0E0", VA = "0x18065E2E0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public TransformAccessArray NPMGMALKLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x6506F0", Offset = "0x64F4F0", VA = "0x1806506F0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool AACDAEOPAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x301BBF0", Offset = "0x301A9F0", VA = "0x18301BBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF1")]
	[Cpp2IlInjected.Address(RVA = "0x301BEE0", Offset = "0x301ACE0", VA = "0x18301BEE0")]
	public NNEFJHMAAJD(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x301BE10", Offset = "0x301AC10", VA = "0x18301BE10")]
	public Entity IEHDMAJLCAD(int BNNEENLPEFO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x301BC10", Offset = "0x301AA10", VA = "0x18301BC10")]
	public Transform ALNLJDPANJK(int BNNEENLPEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x301BC60", Offset = "0x301AA60", VA = "0x18301BC60")]
	public void DBHEJFMMFJD(int BPGPHKEJPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x301BD40", Offset = "0x301AB40", VA = "0x18301BD40")]
	public int ELGBPIMHCCH(Transform KAMDPLLJPAH, Entity LLEBIIAHFDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x301BE60", Offset = "0x301AC60", VA = "0x18301BE60")]
	public int LJFPNHIPEPF(int BNNEENLPEFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x301BCC0", Offset = "0x301AAC0", VA = "0x18301BCC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x301BC20", Offset = "0x301AA20", VA = "0x18301BC20")]
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
	[Cpp2IlInjected.Address(RVA = "0x30585B0", Offset = "0x30573B0", VA = "0x1830585B0")]
	public LGDEIKNECGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x3057FE0", Offset = "0x3056DE0", VA = "0x183057FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3058370", Offset = "0x3057170", VA = "0x183058370")]
	public void NMFBOCJEJOB(Type BIEGICDMJCM, EKBGHCIKEGG GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x3058040", Offset = "0x3056E40", VA = "0x183058040")]
	public EKBGHCIKEGG HMFHOBMDMGG(Type BIEGICDMJCM)
	{
		return default(EKBGHCIKEGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x3057D80", Offset = "0x3056B80", VA = "0x183057D80")]
	private NativeArray<byte> ADBOFBMDIGH(int2 IIDJCPNCMBP)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x3057E20", Offset = "0x3056C20", VA = "0x183057E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x3057EC0", Offset = "0x3056CC0", VA = "0x183057EC0", Slot = "1")]
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
	[Cpp2IlInjected.Address(RVA = "0x30306C0", Offset = "0x302F4C0", VA = "0x1830306C0")]
	internal static void GJPIAAEOJAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	public static void NMFBOCJEJOB<T>(T GKFICKKHACC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x30307D0", Offset = "0x302F5D0", VA = "0x1830307D0")]
	public static void NMFBOCJEJOB(Type BIEGICDMJCM, EKBGHCIKEGG GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	public static T HMFHOBMDMGG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0D")]
	[Cpp2IlInjected.Address(RVA = "0x3030730", Offset = "0x302F530", VA = "0x183030730")]
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
	[Cpp2IlInjected.Address(RVA = "0x301BF60", Offset = "0x301AD60", VA = "0x18301BF60", Slot = "4")]
	public bool Equals(LinkedEntityGroup IODEOJKDCNL, LinkedEntityGroup FNMMGECGLAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D10")]
	[Cpp2IlInjected.Address(RVA = "0x301BF80", Offset = "0x301AD80", VA = "0x18301BF80", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup KMFLGGMLFJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public NNMDHIEOIAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
internal class GLLJEDMAHHM
{
	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("DEBUG_BUILD")]
	public static void PLKOCHLFKOB(in Vector3 DKGAADMNOOM, in Quaternion MPLPNDNEAPK, in Vector3 OLIFDPKHJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("DEBUG_BUILD")]
	public static void NCMDPLKGEFB(in Vector3 BDEMGCFFCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("DEBUG_BUILD")]
	public static void MFNNBLFKPJM(in Quaternion MPLPNDNEAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("DEBUG_BUILD")]
	public static void CFDIBHJDKGN(in Vector3 FIBPLMLJJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("DEBUG_BUILD")]
	public static void NPCIPBBMABP(in Vector3 FIBPLMLJJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("DEBUG_BUILD")]
	public static void HFNBMCFPNAG(in float KLMPOMAKOBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x3045180", Offset = "0x3043F80", VA = "0x183045180")]
	[Conditional("DEBUG_BUILD")]
	public static void GKPDPHNFACC(in float3 GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	[Cpp2IlInjected.Address(RVA = "0x654D20", Offset = "0x653B20", VA = "0x180654D20")]
	[Conditional("DEBUG_BUILD")]
	public static void EEFKNDOLACM(in float GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	[Cpp2IlInjected.Address(RVA = "0x3045100", Offset = "0x3043F00", VA = "0x183045100")]
	[Conditional("DEBUG_BUILD")]
	public static void EEFKNDOLACM(in Vector3 GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x3045150", Offset = "0x3043F50", VA = "0x183045150")]
	[Conditional("DEBUG_BUILD")]
	public static void EEFKNDOLACM(in Quaternion GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x30450F0", Offset = "0x3043EF0", VA = "0x1830450F0")]
	[Conditional("DEBUG_BUILD")]
	public static void BJNJFNEDKFE(in float GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x30450B0", Offset = "0x3043EB0", VA = "0x1830450B0")]
	[Conditional("DEBUG_BUILD")]
	public static void BJNJFNEDKFE(in Vector3 GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x3045080", Offset = "0x3043E80", VA = "0x183045080")]
	[Conditional("DEBUG_BUILD")]
	public static void BJNJFNEDKFE(in Quaternion GKFICKKHACC, string HDKJDEIGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x340FA80", Offset = "0x340E880", VA = "0x18340FA80")]
	public CPMOBHMFHFP(Entity LLEBIIAHFDD, Entity KAEGMLMLAJA, Entity JJHAACNMGFO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	[Cpp2IlInjected.Address(RVA = "0x340FA20", Offset = "0x340E820", VA = "0x18340FA20")]
	public static CPMOBHMFHFP KPOCFOKDNEC((Entity entity, Entity oldParent, Entity newParent) JIBDKICFEPD)
	{
		return default(CPMOBHMFHFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	[Cpp2IlInjected.Address(RVA = "0x340FA60", Offset = "0x340E860", VA = "0x18340FA60")]
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
	[Cpp2IlInjected.Address(RVA = "0x895690", Offset = "0x894490", VA = "0x180895690")]
	public CAIGEBHNCMM(Entity LLEBIIAHFDD, Entity GEOFAMNLJNK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	[Cpp2IlInjected.Address(RVA = "0x340DD60", Offset = "0x340CB60", VA = "0x18340DD60")]
	public static CAIGEBHNCMM KPOCFOKDNEC((Entity entity, Entity parent) JIBDKICFEPD)
	{
		return default(CAIGEBHNCMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x340DD90", Offset = "0x340CB90", VA = "0x18340DD90")]
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
		[Cpp2IlInjected.Address(RVA = "0x2597700", Offset = "0x2596500", VA = "0x182597700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public T AMPEKKPGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0x2597800", Offset = "0x2596600", VA = "0x182597800")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0x2597710", Offset = "0x2596510", VA = "0x182597710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	[Cpp2IlInjected.Address(RVA = "0x25978A0", Offset = "0x25966A0", VA = "0x1825978A0")]
	public IMIGNKKLBNK(T GKFICKKHACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x25977D0", Offset = "0x25965D0", VA = "0x1825977D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BD570", Offset = "0x6BC370", VA = "0x1806BD570")]
	public NJAEBHKONED(HKINPNONFAF PLHKAGLEICI, int NAKPIAAEFIC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D2D")]
	[Cpp2IlInjected.Address(RVA = "0x134C070", Offset = "0x134AE70", VA = "0x18134C070")]
	public static NJAEBHKONED KPOCFOKDNEC((HKINPNONFAF eventType, int eventIndex) IODEOJKDCNL)
	{
		return default(NJAEBHKONED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x301BB10", Offset = "0x301A910", VA = "0x18301BB10")]
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
	[Cpp2IlInjected.Address(RVA = "0x3050250", Offset = "0x304F050", VA = "0x183050250", Slot = "5")]
	public void ACBMFNKOJMD(PGEEJALGCGE HFDOFHJBJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x30502A0", Offset = "0x304F0A0", VA = "0x1830502A0")]
	public bool MONBAJCOINP(in float3 JFLCBFNJLGK, in float3 KCEELMOLFJC, float BNDBJFDKNPP, Allocator PBEDBDBGIPF, out NativeArray<Entity> FNMNPGEEPJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public JKOKMPJDECL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x30502A0", Offset = "0x304F0A0", VA = "0x1830502A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x304EAF0", Offset = "0x304D8F0", VA = "0x18304EAF0", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public IMGAANIFIJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x302F040", Offset = "0x302DE40", VA = "0x18302F040", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public PHNFEFBNMNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3049DE0", Offset = "0x3048BE0", VA = "0x183049DE0", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public HKHFHPJOIJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
internal class MBANIBCHKDP : BHBEGOLDLHM
{
	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public MBANIBCHKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x3408B80", Offset = "0x3407980", VA = "0x183408B80", Slot = "16")]
	protected override ComponentSystemBase HHLKDNFBDIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x302D760", Offset = "0x302C560", VA = "0x18302D760")]
	public BFLEMBEOHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[NIINPNOELJA(typeof(AuthoredLocalPoseData))]
public sealed class JJFNIKENDIF : OPKDABCPCBE
{
	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x304FE60", Offset = "0x304EC60", VA = "0x18304FE60", Slot = "8")]
	protected override bool HNNCLEKANIL(ReadOnlySpan<AuthoredLocalPoseData> CKIGFGIEPDP, IEAJMBBOLLL MKCMLPCNJGL, out ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x304FEE0", Offset = "0x304ECE0", VA = "0x18304FEE0", Slot = "9")]
	protected override bool NAJLBOJHHKN(int OPAPEIICLLC, Span<AuthoredLocalPoseData> CKIGFGIEPDP, in ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D43")]
	[Cpp2IlInjected.Address(RVA = "0x304FFA0", Offset = "0x304EDA0", VA = "0x18304FFA0")]
	public JJFNIKENDIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[NIINPNOELJA(typeof(LocalPoseData))]
public sealed class BIDOPDKDIPF : DFJOKOMHDFL
{
	[Cpp2IlInjected.Token(Token = "0x6000D44")]
	[Cpp2IlInjected.Address(RVA = "0x3409280", Offset = "0x3408080", VA = "0x183409280", Slot = "8")]
	protected override bool HNNCLEKANIL(ReadOnlySpan<LocalPoseData> CKIGFGIEPDP, IEAJMBBOLLL MKCMLPCNJGL, out ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D45")]
	[Cpp2IlInjected.Address(RVA = "0x3409300", Offset = "0x3408100", VA = "0x183409300", Slot = "9")]
	protected override bool NAJLBOJHHKN(int OPAPEIICLLC, Span<LocalPoseData> CKIGFGIEPDP, in ReadOnlySpan<byte> MEFFDBODCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x34093C0", Offset = "0x34081C0", VA = "0x1834093C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x671070", Offset = "0x66FE70", VA = "0x180671070")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0x32C2AD0", Offset = "0x32C18D0", VA = "0x1832C2AD0", Slot = "6")]
		public sealed override void FEOLDJENCJJ(OFPBJBCBPFJ PKPGAEOFIGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0x32C3A70", Offset = "0x32C2870", VA = "0x1832C3A70", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x30520F0", Offset = "0x3050EF0", VA = "0x1830520F0")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x3052200", Offset = "0x3051000", VA = "0x183052200")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
