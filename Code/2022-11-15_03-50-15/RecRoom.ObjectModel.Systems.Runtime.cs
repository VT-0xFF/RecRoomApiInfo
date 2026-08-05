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
public sealed class GGCFMEKEAJJ<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class ABDGDNMCHKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::GGCFMEKEAJJ<T> GDIIBBFMKPI;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] CEMCMKMMLEE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public ABDGDNMCHKM(global::GGCFMEKEAJJ<T> GDIIBBFMKPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class HKGBLGPAJKO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::GGCFMEKEAJJ<T> <>4__this;

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
		public HKGBLGPAJKO(int <>1__state)
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
	private const int KNGOJLIHMLL = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> DFENDMDOLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int GKCDBPHDEAA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T GMLDPDCPAEM
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
	private bool EJJLMPDOEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool DNPNGIPMCIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool EGLJEKIMAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KKMBALGBKLD
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
	public int OABDNEKKKBL
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
	public GGCFMEKEAJJ(int CDECJIFLFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public GGCFMEKEAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void NIJILPHHJPD(int NENMOOINMCH, T LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void JIOCFBKPOPN(int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] FNLPBIFGABO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void KEENDCNJPEJ(NativeArray<T> EIOACKOCJCB, int CJMIFBGEMCC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::GGCFMEKEAJJ<>.HKGBLGPAJKO))]
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
	public int FAPJKNPKKHA(T LPGHMHLAPGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool OMBMHDCIFDM(T LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void DMIPKPCMAJL(int HKNAGFEGNJM, int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void ABMCCBCFLHH(int HKNAGFEGNJM, int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void KCFGEDHGGNN(int HKNAGFEGNJM, int DDIAPGBIJDD, int OOJKDAEFAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int INBEILLEIGB(int NENMOOINMCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T JJJAIKHBEMK(int NENMOOINMCH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void JLMGIOOGABD(int NENMOOINMCH, T LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void EPEKLFEIKFO(int NENMOOINMCH, T LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void EDMHIKGOFAI(int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int GBPCOGNACBF(int NKJMIDIDBOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int IEPGACAOPHL(int NKJMIDIDBOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void EFMFHIPPDGL(T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void PKNKKLLJBPA(T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T AGDKJDHHGJK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T BAEDLGLANNK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void AMNGIOOKIDN(int NENMOOINMCH, IReadOnlyCollection<T> OKNNOBIAJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void OCKIPBFEMEL(int NENMOOINMCH, int JCKEGBFMHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void DFAHJMFENHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void LFHEMIICLPO(T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void MDADIPIIOLJ(T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void ICADBNOEKFA(int DDIAPGBIJDD, int OOJKDAEFAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T KGMHIEAAPJC()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T JFEMCGKHPIA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[JICPLAHIAGM]
public static class HAHEONEMHDN
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x217F600", Offset = "0x217E000", VA = "0x18217F600")]
	static HAHEONEMHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7490", Offset = "0x1DC5E90", VA = "0x181DC7490")]
	public static void OLOGACBMBIO<T>(T DNHJJJCEBEN, ref T BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x217F460", Offset = "0x217DE60", VA = "0x18217F460")]
	public static void OLOGACBMBIO(FixedString32 DNHJJJCEBEN, ref string BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x217F420", Offset = "0x217DE20", VA = "0x18217F420")]
	public static void OLOGACBMBIO(string DNHJJJCEBEN, ref FixedString32 BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x217F3F0", Offset = "0x217DDF0", VA = "0x18217F3F0")]
	public static void OLOGACBMBIO(FixedString64 DNHJJJCEBEN, ref string BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x217F5A0", Offset = "0x217DFA0", VA = "0x18217F5A0")]
	public static void OLOGACBMBIO(string DNHJJJCEBEN, ref FixedString64 BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x217F490", Offset = "0x217DE90", VA = "0x18217F490")]
	public static void OLOGACBMBIO(DEANIEMDHLO DNHJJJCEBEN, ref Vector3 BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x217F390", Offset = "0x217DD90", VA = "0x18217F390")]
	public static void OLOGACBMBIO(Vector3 DNHJJJCEBEN, ref DEANIEMDHLO BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x217F2B0", Offset = "0x217DCB0", VA = "0x18217F2B0")]
	public static void OLOGACBMBIO(CJHHNLPLMKE DNHJJJCEBEN, ref Vector4 BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x217F2E0", Offset = "0x217DCE0", VA = "0x18217F2E0")]
	public static void OLOGACBMBIO(Vector4 DNHJJJCEBEN, ref CJHHNLPLMKE BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x217F2B0", Offset = "0x217DCB0", VA = "0x18217F2B0")]
	public static void OLOGACBMBIO(CJHHNLPLMKE DNHJJJCEBEN, ref Quaternion BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x217F2E0", Offset = "0x217DCE0", VA = "0x18217F2E0")]
	public static void OLOGACBMBIO(Quaternion DNHJJJCEBEN, ref CJHHNLPLMKE BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x217F530", Offset = "0x217DF30", VA = "0x18217F530")]
	public static void OLOGACBMBIO(DEANIEMDHLO DNHJJJCEBEN, ref float3 BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x217F390", Offset = "0x217DD90", VA = "0x18217F390")]
	public static void OLOGACBMBIO(float3 DNHJJJCEBEN, ref DEANIEMDHLO BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x217F350", Offset = "0x217DD50", VA = "0x18217F350")]
	public static void OLOGACBMBIO(CJHHNLPLMKE DNHJJJCEBEN, ref float4 BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x217F2E0", Offset = "0x217DCE0", VA = "0x18217F2E0")]
	public static void OLOGACBMBIO(float4 DNHJJJCEBEN, ref CJHHNLPLMKE BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x217F350", Offset = "0x217DD50", VA = "0x18217F350")]
	public static void OLOGACBMBIO(CJHHNLPLMKE DNHJJJCEBEN, ref quaternion BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x217F4C0", Offset = "0x217DEC0", VA = "0x18217F4C0")]
	public static void OLOGACBMBIO(quaternion DNHJJJCEBEN, ref CJHHNLPLMKE BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x217F560", Offset = "0x217DF60", VA = "0x18217F560")]
	public static void OLOGACBMBIO(Entity DNHJJJCEBEN, ref BKLNAHGAKLP BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x217F290", Offset = "0x217DC90", VA = "0x18217F290")]
	public static void OLOGACBMBIO(BKLNAHGAKLP DNHJJJCEBEN, ref Entity BPKLGLCANMF, EHDEHNCFGLN HLNMPCAECGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[EAKKFOPCDBA]
public class OACCDCDMDOD : ComponentSystem, CFMOGGHLNDM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DOMLOFPDLMI EBIOAJAGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F00", Offset = "0x6A3900", VA = "0x1806A4F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public PHMOCMIEEKH KCKPMIGEKBG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81F1C0", Offset = "0x81DBC0", VA = "0x18081F1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x22CCE70", Offset = "0x22CB870", VA = "0x1822CCE70", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
	public OACCDCDMDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[EAKKFOPCDBA]
[UpdateInGroup(typeof(IBMGGKEDHJB))]
internal class OMKIDBPKIMP : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x22CE670", Offset = "0x22CD070", VA = "0x1822CE670", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x22CE5F0", Offset = "0x22CCFF0", VA = "0x1822CE5F0")]
	[Preserve]
	private void EKMMDLONGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public OMKIDBPKIMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[EAKKFOPCDBA]
[UpdateInGroup(typeof(IBMGGKEDHJB))]
internal class KDNEMGIGOHD : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x218A780", Offset = "0x2189180", VA = "0x18218A780", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public KDNEMGIGOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x22D4730", Offset = "0x22D3130", VA = "0x1822D4730")]
		public static ObjectModelConfigAsset PFEOIBHPKGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x752960", Offset = "0x751360", VA = "0x180752960")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[OJEJDFBPPED(FHFOPEOFOPD.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[OJEJDFBPPED(FHFOPEOFOPD.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int CIDEMGIPOEP = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly LOOGELFKPLM ENHDLHMFJLO;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x38AE430", Offset = "0x38ACE30", VA = "0x1838AE430")]
			public static DPCBAIHHPOK FNPJBLJEFFK(int DCCCJBLBDHM)
			{
				return default(DPCBAIHHPOK);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x38AEA70", Offset = "0x38AD470", VA = "0x1838AEA70")]
			private static void LDCCAGGAFDB(CAMBCDMDDIB ECJDNCEBOBG, CAMBCDMDDIB JOCDEPFBALE, DPCBAIHHPOK PKBNFFGFIEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x38AE8A0", Offset = "0x38AD2A0", VA = "0x1838AE8A0")]
			public static int JKDOABBHNDA(GameObject OOAFGPFKNDK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x38AE820", Offset = "0x38AD220", VA = "0x1838AE820")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void IKNBJHJCMKF(CAMBCDMDDIB BCJDDLNACAB, int DCCCJBLBDHM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static MCKMOPCGMKB FOFFAOBPIJI;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static HMMJBABEEJF PADOKDEPFGI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static MCKMOPCGMKB OMCBFLNBFFD
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x22D48F0", Offset = "0x22D32F0", VA = "0x1822D48F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x22D57F0", Offset = "0x22D41F0", VA = "0x1822D57F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static HMMJBABEEJF PGMABAOIGID
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x22D60F0", Offset = "0x22D4AF0", VA = "0x1822D60F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x22D5150", Offset = "0x22D3B50", VA = "0x1822D5150")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool CMKJIOLHEOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x22D4F50", Offset = "0x22D3950", VA = "0x1822D4F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static DOMLOFPDLMI EBIOAJAGMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x22D50B0", Offset = "0x22D3AB0", VA = "0x1822D50B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static PHMOCMIEEKH KCKPMIGEKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x22D5540", Offset = "0x22D3F40", VA = "0x1822D5540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static DFFINCJAHNC ODGKNAIJAFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x22D4B60", Offset = "0x22D3560", VA = "0x1822D4B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static JEGFBKEGILA GFOGBLPFPHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x22D55C0", Offset = "0x22D3FC0", VA = "0x1822D55C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static PPBLJKKDGPH LFJJOAGMHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x22D5E50", Offset = "0x22D4850", VA = "0x1822D5E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static LKBGGDFMKHG AMBJBAGEFBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x22D5640", Offset = "0x22D4040", VA = "0x1822D5640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool AKEENCNLBKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x22D5C40", Offset = "0x22D4640", VA = "0x1822D5C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool BFAJGGKKKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x22D58D0", Offset = "0x22D42D0", VA = "0x1822D58D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool ICCNPEKJEDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x22D5F30", Offset = "0x22D4930", VA = "0x1822D5F30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x22D6090", Offset = "0x22D4A90", VA = "0x1822D6090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool AEIFOBFAAHP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x22D5400", Offset = "0x22D3E00", VA = "0x1822D5400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x22D4DF0", Offset = "0x22D37F0", VA = "0x1822D4DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action KNODAFCMCIP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x22D5F90", Offset = "0x22D4990", VA = "0x1822D5F90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x22D4E50", Offset = "0x22D3850", VA = "0x1822D4E50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x22D4D00", Offset = "0x22D3700", VA = "0x1822D4D00")]
		public static CAMBCDMDDIB EJCMNEKEHKK(GameObject OOAFGPFKNDK)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x22D5ED0", Offset = "0x22D48D0", VA = "0x1822D5ED0")]
		public static bool NKJKIKKHJIF(ByteString IBDMDMLOLOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x22D4BE0", Offset = "0x22D35E0", VA = "0x1822D4BE0")]
		public static MPBFDJNFALM EGBNLFAHFDO(DPCBAIHHPOK PKBNFFGFIEN)
		{
			return default(MPBFDJNFALM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x22D5D20", Offset = "0x22D4720", VA = "0x1822D5D20")]
		public static (ByteString, IDisposable) NJDODOCIOLN()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x22D56C0", Offset = "0x22D40C0", VA = "0x1822D56C0")]
		public static (ByteString, IDisposable) LLPKNDMDPEJ(IEnumerable<CAMBCDMDDIB> EAOELIGDFKD)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x22D4A30", Offset = "0x22D3430", VA = "0x1822D4A30")]
		public static bool CNJNEKMLMKA(GameObject OOAFGPFKNDK, out DPCBAIHHPOK PKBNFFGFIEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x22D5370", Offset = "0x22D3D70", VA = "0x1822D5370")]
		public static bool IJGPEHDGAIE(IEnumerable<DCBEICMMGBC> OAOMNDFMDJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x22D5460", Offset = "0x22D3E60", VA = "0x1822D5460")]
		public static void JECPDEECNGL(bool GCNBMKKLBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x22D5AC0", Offset = "0x22D44C0", VA = "0x1822D5AC0")]
		public static Task MEDKGBHNGKM(bool GCNBMKKLBLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x22D4950", Offset = "0x22D3350", VA = "0x1822D4950")]
		private static HMMJBABEEJF CAIHFFPFLNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x22D47D0", Offset = "0x22D31D0", VA = "0x1822D47D0")]
		private static bool AEPHIFCNDKA()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[OJEJDFBPPED(FHFOPEOFOPD.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x22DAFB0", Offset = "0x22D99B0", VA = "0x1822DAFB0")]
		public static bool OJIBAKOFPFC(DFAIMGIACIM LMJNBHJDIDB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x22DAD80", Offset = "0x22D9780", VA = "0x1822DAD80")]
		public static DFAIMGIACIM MKIHEFFHNPG(GameObject OOAFGPFKNDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x22DAB80", Offset = "0x22D9580", VA = "0x1822DAB80")]
		public static DFAIMGIACIM MKIHEFFHNPG(GameObject OOAFGPFKNDK, DPCBAIHHPOK PKBNFFGFIEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x22DAA80", Offset = "0x22D9480", VA = "0x1822DAA80")]
		public static bool KPHNHJLFNEA(GameObject HDDFHLGDPFJ, string FDMNJOPCFPM, bool HLGLMMCFMKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x22DA880", Offset = "0x22D9280", VA = "0x1822DA880")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void DIDAEKIPCCH(GameObject HDDFHLGDPFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x22DA790", Offset = "0x22D9190", VA = "0x1822DA790")]
		[CompilerGenerated]
		internal static string DDFLEALHKPF((GameObject go, string prefabName) GBGLLILEMPG)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, LPMMFLBNBNB
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool MKHIBFLPINF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6A32E0", Offset = "0x6A1CE0", VA = "0x1806A32E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CAMBCDMDDIB JDFAMBIABIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x909700", Offset = "0x908100", VA = "0x180909700", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(CAMBCDMDDIB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x24C1990", Offset = "0x24C0390", VA = "0x1824C1990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[OJEJDFBPPED(FHFOPEOFOPD.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, DFAIMGIACIM, LPMMFLBNBNB
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string KKIPEAOHMPK = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private EKKPMJOKHDO LPLEHOMFOKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private CAMBCDMDDIB MMCCMEFGKOD;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CAMBCDMDDIB JDFAMBIABIC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x24C6F60", Offset = "0x24C5960", VA = "0x1824C6F60", Slot = "15")]
			get
			{
				return default(CAMBCDMDDIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public MPBFDJNFALM HLMDGOMGGOC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x24C7010", Offset = "0x24C5A10", VA = "0x1824C7010", Slot = "6")]
			get
			{
				return default(MPBFDJNFALM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool MKHIBFLPINF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x24C6F50", Offset = "0x24C5950", VA = "0x1824C6F50", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public EKKPMJOKHDO GMPHDOOPDIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8EADD0", Offset = "0x8E97D0", VA = "0x1808EADD0", Slot = "7")]
			get
			{
				return default(EKKPMJOKHDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private PHMOCMIEEKH KCKPMIGEKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x24C6470", Offset = "0x24C4E70", VA = "0x1824C6470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private NPDHBLHKCNF AFOBIAIKGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x24C6410", Offset = "0x24C4E10", VA = "0x1824C6410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool AAPGMNHEILP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x799F80", Offset = "0x798980", VA = "0x180799F80", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x799F70", Offset = "0x798970", VA = "0x180799F70", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> LHPDMPMEHAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x24C6E10", Offset = "0x24C5810", VA = "0x1824C6E10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x24C7040", Offset = "0x24C5A40", VA = "0x1824C7040")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<DFAIMGIACIM> JILOKCJEKGC
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x24C6EB0", Offset = "0x24C58B0", VA = "0x1824C6EB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x24C70E0", Offset = "0x24C5AE0", VA = "0x1824C70E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x24C6290", Offset = "0x24C4C90", VA = "0x1824C6290")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x24C6C70", Offset = "0x24C5670", VA = "0x1824C6C70", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x24C6920", Offset = "0x24C5320", VA = "0x1824C6920", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x24C6BE0", Offset = "0x24C55E0", VA = "0x1824C6BE0", Slot = "10")]
		public void OnEmbody(CAOOBKKGEDI MKBCEHAIJKD, CAMBCDMDDIB MMCCMEFGKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x24C6C60", Offset = "0x24C5660", VA = "0x1824C6C60", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x24C69D0", Offset = "0x24C53D0", VA = "0x1824C69D0", Slot = "12")]
		public void OnDisembody(bool BJIHEOOEBMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x24C6550", Offset = "0x24C4F50", VA = "0x1824C6550")]
		private void KOHICGKBFBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x24C6650", Offset = "0x24C5050", VA = "0x1824C6650")]
		private void MFPIHDMDGDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x24C66E0", Offset = "0x24C50E0", VA = "0x1824C66E0")]
		private void NINDAIHGBKP(bool CINJFMNBDGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x24C68C0", Offset = "0x24C52C0", VA = "0x1824C68C0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x74B7A0", Offset = "0x74A1A0", VA = "0x18074B7A0", Slot = "9")]
		private GameObject OMLONDDHKNK()
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
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[OJEJDFBPPED(FHFOPEOFOPD.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override MIJMGOMOBGM ANNBOMJIJMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x22E6890", Offset = "0x22E5290", VA = "0x1822E6890", Slot = "6")]
			get
			{
				return default(MIJMGOMOBGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x22E6830", Offset = "0x22E5230", VA = "0x1822E6830")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[OJEJDFBPPED(FHFOPEOFOPD.Registration)]
	public class TransformEntity : MonoBehaviour, LPMMFLBNBNB
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private MIJMGOMOBGM prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private CAMBCDMDDIB BCJDDLNACAB;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual MIJMGOMOBGM ANNBOMJIJMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x748B70", Offset = "0x747570", VA = "0x180748B70", Slot = "6")]
			get
			{
				return default(MIJMGOMOBGM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7FEF20", Offset = "0x7FD920", VA = "0x1807FEF20", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CAMBCDMDDIB JDFAMBIABIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x94F170", Offset = "0x94DB70", VA = "0x18094F170", Slot = "5")]
			get
			{
				return default(CAMBCDMDDIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool MKHIBFLPINF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x69FE40", Offset = "0x69E840", VA = "0x18069FE40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x69FF10", Offset = "0x69E910", VA = "0x18069FF10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal Entity DOCCAFEJPOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal PPBLJKKDGPH LFJJOAGMHIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal NPDHBLHKCNF OKCLFFANOKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x22F89E0", Offset = "0x22F73E0", VA = "0x1822F89E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x22F89D0", Offset = "0x22F73D0", VA = "0x1822F89D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x22F8D90", Offset = "0x22F7790", VA = "0x1822F8D90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x22F8A50", Offset = "0x22F7450", VA = "0x1822F8A50")]
		internal void GICNDCMAEJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x22F8F10", Offset = "0x22F7910", VA = "0x1822F8F10")]
		private bool PMMFELOMCAF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x22F8D60", Offset = "0x22F7760", VA = "0x1822F8D60")]
		private void LPLJFBBMOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x22F8D90", Offset = "0x22F7790", VA = "0x1822F8D90")]
		internal void NDOILGDBOAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x22F8E80", Offset = "0x22F7880", VA = "0x1822F8E80")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x22F9000", Offset = "0x22F7A00", VA = "0x1822F9000")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[GPEKNNAMFFM(typeof(KNKHBCHGAEJ))]
[DNKFJNHNNCA(typeof(HMMJBABEEJF), new string[] { })]
public class PKBLKPBDBOP : ENIBNBHMFBE, EHKOGOCHEPO, HMMJBABEEJF, LMJEAKIHKOP, KNKHBCHGAEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LAGGBJEMAHE KDGPDENJJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private PHMOCMIEEKH ALJPPMMDDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private PNLHBOHNCFH MGOGCFMPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private OEDCBLNEDEI LGEPGJALMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool HHKBONGDECE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public KGBPMICCNIM PNOLMDACAAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6B9700", Offset = "0x6B8100", VA = "0x1806B9700", Slot = "19")]
		get
		{
			return default(KGBPMICCNIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public LAGGBJEMAHE EBIOAJAGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public PNLHBOHNCFH AGJOHNHILPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public PHMOCMIEEKH KCKPMIGEKBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool MMGCNOGJJID
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x69FE40", Offset = "0x69E840", VA = "0x18069FE40", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool KKNNLAGAGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x22DD3D0", Offset = "0x22DBDD0", VA = "0x1822DD3D0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x22DD600", Offset = "0x22DC000", VA = "0x1822DD600", Slot = "20")]
	public void IMNJFGBMJOD(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x820580", Offset = "0x81EF80", VA = "0x180820580")]
	private void LMBJCLDJBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x22DD250", Offset = "0x22DBC50", VA = "0x1822DD250")]
	private void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	private void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x22DD300", Offset = "0x22DBD00", VA = "0x1822DD300", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x22DD800", Offset = "0x22DC200", VA = "0x1822DD800", Slot = "10")]
	public void MPJEKMMAILA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "4")]
	public void ILPLAALCLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x22DD790", Offset = "0x22DC190", VA = "0x1822DD790", Slot = "5")]
	public void KPMFCHAFFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x22DD740", Offset = "0x22DC140", VA = "0x1822DD740", Slot = "6")]
	public void KNOGOEKPLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x22DD360", Offset = "0x22DBD60", VA = "0x1822DD360", Slot = "7")]
	public void EAIKNABCIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x22DD580", Offset = "0x22DBF80", VA = "0x1822DD580", Slot = "8")]
	public bool IJGPEHDGAIE(IEnumerable<DCBEICMMGBC> OAOMNDFMDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x22DD510", Offset = "0x22DBF10", VA = "0x1822DD510", Slot = "9")]
	public void HDAFDLBGHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x22DD070", Offset = "0x22DBA70", VA = "0x1822DD070", Slot = "11")]
	public void APFCLBJLGIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x22DD1D0", Offset = "0x22DBBD0", VA = "0x1822DD1D0", Slot = "12")]
	public void DFGOEIGCCGC(bool DKGGHBNGHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x22DD710", Offset = "0x22DC110", VA = "0x1822DD710")]
	private void IPIMOKLHPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x22DD840", Offset = "0x22DC240", VA = "0x1822DD840", Slot = "13")]
	public ByteString NJDODOCIOLN(out IDisposable MACNEEBFBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x22DD3E0", Offset = "0x22DBDE0", VA = "0x1822DD3E0", Slot = "14")]
	public void GKBAFEAOLLC(ByteString PJIINDGLAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x22DD0E0", Offset = "0x22DBAE0", VA = "0x1822DD0E0")]
	public static PKBLKPBDBOP BJHKCBAGIGH(LAGGBJEMAHE KDGPDENJJDJ, LHIDPAOLOPJ ALIOHCFALJN = LHIDPAOLOPJ.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	private static void NGPBMEGLDJP(LAGGBJEMAHE KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	private static void JEPAFALBBBG(LAGGBJEMAHE KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public PKBLKPBDBOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MFFJNDLADKA
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x22C8810", Offset = "0x22C7210", VA = "0x1822C8810")]
	public static MPBFDJNFALM LBKNPNPADJN(this HMMJBABEEJF PADOKDEPFGI, DPCBAIHHPOK PKBNFFGFIEN, MIJMGOMOBGM PKKAOLKCAGJ)
	{
		return default(MPBFDJNFALM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22C86F0", Offset = "0x22C70F0", VA = "0x1822C86F0")]
	public static JCDNDIPOGFL HLBGIIJOCHM(this HMMJBABEEJF PADOKDEPFGI)
	{
		return default(JCDNDIPOGFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x22C8640", Offset = "0x22C7040", VA = "0x1822C8640")]
	public static CAMBCDMDDIB EJCMNEKEHKK(this HMMJBABEEJF PADOKDEPFGI, Entity EBOGCLNNJGN)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x22C8510", Offset = "0x22C6F10", VA = "0x1822C8510")]
	public static CAMBCDMDDIB EJCMNEKEHKK(this HMMJBABEEJF PADOKDEPFGI, DPCBAIHHPOK PKBNFFGFIEN)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x22C83F0", Offset = "0x22C6DF0", VA = "0x1822C83F0")]
	public static DPCBAIHHPOK AJLOHFFBBNE(this HMMJBABEEJF PADOKDEPFGI, CAMBCDMDDIB BCJDDLNACAB)
	{
		return default(DPCBAIHHPOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum LHIDPAOLOPJ
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
public class EPJKFGDFGEO<T> : global::EDEIKAKMEGB<T>, global::MNOFBDJHDKK<DPCBAIHHPOK, T>, global::KELAGAJLFOB<DPCBAIHHPOK>, POBFPAENEBP, IDisposable, BHEGOIHHKIE where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::KELAGAJLFOB<Entity> GNIPEANGOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate CCHJPCIBCCH;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string PCBAHGDOBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x485F390", Offset = "0x485DD90", VA = "0x18485F390", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type JHJMDINHJLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x486C160", Offset = "0x486AB60", VA = "0x18486C160", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public LJFKOBFLBJG FDJEBJDLKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4859EC0", Offset = "0x48588C0", VA = "0x184859EC0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JNBCHKAAMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x48607A0", Offset = "0x485F1A0", VA = "0x1848607A0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NGODPHOFLFF BGGEDNOFBHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x48713F0", Offset = "0x486FDF0", VA = "0x1848713F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x19EC120", Offset = "0x19EAB20", VA = "0x1819EC120", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x20DA800", Offset = "0x20D9200", VA = "0x1820DA800", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::HMDDPNAHBMG<DPCBAIHHPOK> KNODAFCMCIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x486C950", Offset = "0x486B350", VA = "0x18486C950", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x485FCB0", Offset = "0x485E6B0", VA = "0x18485FCB0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x20F7680", Offset = "0x20F6080", VA = "0x1820F7680")]
	public EPJKFGDFGEO(global::KELAGAJLFOB<Entity> GNIPEANGOCM, PPBLJKKDGPH EAFHJAEOKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x48619B0", Offset = "0x48603B0", VA = "0x1848619B0")]
	private Entity HNGCPLMFKDM(DPCBAIHHPOK PKBNFFGFIEN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x20E5FB0", Offset = "0x20E49B0", VA = "0x1820E5FB0")]
	private DPCBAIHHPOK HNGCPLMFKDM(Entity EBOGCLNNJGN)
	{
		return default(DPCBAIHHPOK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x485C7F0", Offset = "0x485B1F0", VA = "0x18485C7F0", Slot = "4")]
	public T DNANCALJAPO(DPCBAIHHPOK PKBNFFGFIEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x486A0F0", Offset = "0x4868AF0", VA = "0x18486A0F0")]
	public bool LMCGMFHIJLB(DPCBAIHHPOK PKBNFFGFIEN, in T MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x486E200", Offset = "0x486CC00", VA = "0x18486E200")]
	public bool OPOAOMKLLNJ(DPCBAIHHPOK PKBNFFGFIEN, in T MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4861070", Offset = "0x485FA70", VA = "0x184861070", Slot = "9")]
	public bool HHAMBKOEDIN(DPCBAIHHPOK PKBNFFGFIEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x20DA4E0", Offset = "0x20D8EE0", VA = "0x1820DA4E0", Slot = "26")]
	public object BHACKLJBMGO(DPCBAIHHPOK PKBNFFGFIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x48626B0", Offset = "0x48610B0", VA = "0x1848626B0")]
	public bool HPEPKDNPMEG(DPCBAIHHPOK PKBNFFGFIEN, in object MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x20E13C0", Offset = "0x20DFDC0", VA = "0x1820E13C0")]
	public void DNANCALJAPO(DPCBAIHHPOK PKBNFFGFIEN, in FPKEMMGAFGA NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x20EFF00", Offset = "0x20EE900", VA = "0x1820EFF00")]
	public bool LMCGMFHIJLB(DPCBAIHHPOK PKBNFFGFIEN, in DCNFIHFHOLK MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x20F32F0", Offset = "0x20F1CF0", VA = "0x1820F32F0")]
	public bool OPOAOMKLLNJ(DPCBAIHHPOK PKBNFFGFIEN, in DCNFIHFHOLK MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x20ED130", Offset = "0x20EBB30", VA = "0x1820ED130", Slot = "22")]
	public void KILJMGBLKDF(FDHLGFOCCIN HKHJFOAGFPO, [Optional] object ABFHDOGCMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4868F90", Offset = "0x4867990", VA = "0x184868F90", Slot = "15")]
	public void KILJMGBLKDF(DPCBAIHHPOK KFEMFMGCJPM, OBAMLFKPDHI HKHJFOAGFPO, object ABFHDOGCMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x20DA020", Offset = "0x20D8A20", VA = "0x1820DA020", Slot = "14")]
	public bool AGAIFOKOOKO(DPCBAIHHPOK BPKLGLCANMF, DPCBAIHHPOK DNHJJJCEBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x17A13A0", Offset = "0x179FDA0", VA = "0x1817A13A0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4871990", Offset = "0x4870390", VA = "0x184871990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x41C9DB0", Offset = "0x41C87B0", VA = "0x1841C9DB0")]
	public string ELAHFBKAPEK(in DCNFIHFHOLK NJHHAEBDOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x485D720", Offset = "0x485C120", VA = "0x18485D720")]
	private void DNNLHPCDCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x486FA50", Offset = "0x486E450", VA = "0x18486FA50")]
	private void PEPABJOPAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4867E30", Offset = "0x4866830", VA = "0x184867E30")]
	private void JBICMFBLGDI(Entity EBOGCLNNJGN, in DCNFIHFHOLK HIJNDNKMAJM, in DCNFIHFHOLK MIIOPMDNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x486B900", Offset = "0x486A300", VA = "0x18486B900")]
	private void NIANFLMFGFL(Entity EBOGCLNNJGN, in DCNFIHFHOLK HIJNDNKMAJM, in DCNFIHFHOLK MIIOPMDNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x48564A0", Offset = "0x4854EA0", VA = "0x1848564A0")]
	[Conditional("DEBUG_BUILD")]
	private static void CHDNDBEHMAN(Entity EBOGCLNNJGN, DPCBAIHHPOK PKBNFFGFIEN, string OKNFKAJADBM, string AEGBJCEGCDI, [CallerMemberName] string ECBCFCIMADB = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1A607A0", Offset = "0x1A5F1A0", VA = "0x181A607A0", Slot = "5")]
	private bool CLMBNFHILCL(DPCBAIHHPOK KFEMFMGCJPM, in T MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x20E1710", Offset = "0x20E0110", VA = "0x1820E1710", Slot = "6")]
	private bool DNCAPLIFAIP(DPCBAIHHPOK KFEMFMGCJPM, in T MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x20EE8E0", Offset = "0x20ED2E0", VA = "0x1820EE8E0", Slot = "10")]
	private bool KNLEHGOKEGJ(DPCBAIHHPOK KFEMFMGCJPM, in object MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x20DA6A0", Offset = "0x20D90A0", VA = "0x1820DA6A0", Slot = "11")]
	private void BIMNEEOBDDD(DPCBAIHHPOK KFEMFMGCJPM, in FPKEMMGAFGA NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x20F24F0", Offset = "0x20F0EF0", VA = "0x1820F24F0", Slot = "12")]
	private bool OONKFILGAAI(DPCBAIHHPOK KFEMFMGCJPM, in DCNFIHFHOLK MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x20F08E0", Offset = "0x20EF2E0", VA = "0x1820F08E0", Slot = "13")]
	private bool NGNHGGNGHGI(DPCBAIHHPOK KFEMFMGCJPM, in DCNFIHFHOLK MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x20E4180", Offset = "0x20E2B80", VA = "0x1820E4180", Slot = "16")]
	private string FIGDBLJPDJL(in DCNFIHFHOLK NKJMIDIDBOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class DKOBANLLHLA<T> : global::HHMNIGMFFBK<T>, global::MNOFBDJHDKK<CAMBCDMDDIB, T>, global::KELAGAJLFOB<CAMBCDMDDIB>, POBFPAENEBP, IDisposable, FNEDFINGEKN where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly global::KELAGAJLFOB<Entity> GNIPEANGOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Delegate CCHJPCIBCCH;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string PCBAHGDOBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x41CA280", Offset = "0x41C8C80", VA = "0x1841CA280", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Type JHJMDINHJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x41D80C0", Offset = "0x41D6AC0", VA = "0x1841D80C0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public LJFKOBFLBJG FDJEBJDLKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x41C39E0", Offset = "0x41C23E0", VA = "0x1841C39E0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int JNBCHKAAMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x41CB5C0", Offset = "0x41C9FC0", VA = "0x1841CB5C0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NGODPHOFLFF BGGEDNOFBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x41DDE00", Offset = "0x41DC800", VA = "0x1841DDE00", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3571250", Offset = "0x356FC50", VA = "0x183571250", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x355FF20", Offset = "0x355E920", VA = "0x18355FF20", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::HMDDPNAHBMG<CAMBCDMDDIB> KNODAFCMCIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x41D91C0", Offset = "0x41D7BC0", VA = "0x1841D91C0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x41CA850", Offset = "0x41C9250", VA = "0x1841CA850", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x20F7680", Offset = "0x20F6080", VA = "0x1820F7680")]
	public DKOBANLLHLA(global::KELAGAJLFOB<Entity> GNIPEANGOCM, PPBLJKKDGPH EAFHJAEOKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0xCB44D0", Offset = "0xCB2ED0", VA = "0x180CB44D0")]
	private Entity HNGCPLMFKDM(CAMBCDMDDIB BCJDDLNACAB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3566D80", Offset = "0x3565780", VA = "0x183566D80")]
	private CAMBCDMDDIB HNGCPLMFKDM(Entity EBOGCLNNJGN)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x41C5460", Offset = "0x41C3E60", VA = "0x1841C5460", Slot = "4")]
	public T DNANCALJAPO(CAMBCDMDDIB BCJDDLNACAB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x41D6CD0", Offset = "0x41D56D0", VA = "0x1841D6CD0")]
	public bool LMCGMFHIJLB(CAMBCDMDDIB BCJDDLNACAB, in T MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x41DB430", Offset = "0x41D9E30", VA = "0x1841DB430")]
	public bool OPOAOMKLLNJ(CAMBCDMDDIB BCJDDLNACAB, in T MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x41CBDE0", Offset = "0x41CA7E0", VA = "0x1841CBDE0", Slot = "9")]
	public bool HHAMBKOEDIN(CAMBCDMDDIB BCJDDLNACAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x355FCD0", Offset = "0x355E6D0", VA = "0x18355FCD0", Slot = "26")]
	public object BHACKLJBMGO(CAMBCDMDDIB BCJDDLNACAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x41CDC70", Offset = "0x41CC670", VA = "0x1841CDC70")]
	public bool HPEPKDNPMEG(CAMBCDMDDIB BCJDDLNACAB, in object MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3561F60", Offset = "0x3560960", VA = "0x183561F60")]
	public void DNANCALJAPO(CAMBCDMDDIB BCJDDLNACAB, in FPKEMMGAFGA NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x356EBC0", Offset = "0x356D5C0", VA = "0x18356EBC0")]
	public bool LMCGMFHIJLB(CAMBCDMDDIB BCJDDLNACAB, in DCNFIHFHOLK MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3572FB0", Offset = "0x35719B0", VA = "0x183572FB0")]
	public bool OPOAOMKLLNJ(CAMBCDMDDIB BCJDDLNACAB, in DCNFIHFHOLK MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x20ED130", Offset = "0x20EBB30", VA = "0x1820ED130", Slot = "22")]
	public void KILJMGBLKDF(FDHLGFOCCIN HKHJFOAGFPO, [Optional] object ABFHDOGCMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x41D3D90", Offset = "0x41D2790", VA = "0x1841D3D90", Slot = "15")]
	public void KILJMGBLKDF(CAMBCDMDDIB KFEMFMGCJPM, OBAMLFKPDHI HKHJFOAGFPO, object ABFHDOGCMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x355F560", Offset = "0x355DF60", VA = "0x18355F560", Slot = "14")]
	public bool AGAIFOKOOKO(CAMBCDMDDIB BPKLGLCANMF, CAMBCDMDDIB DNHJJJCEBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x41C8AB0", Offset = "0x41C74B0", VA = "0x1841C8AB0")]
	private void DNNLHPCDCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x41DD5C0", Offset = "0x41DBFC0", VA = "0x1841DD5C0")]
	private void PEPABJOPAIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x41CED10", Offset = "0x41CD710", VA = "0x1841CED10")]
	private void JBICMFBLGDI(Entity EBOGCLNNJGN, in DCNFIHFHOLK HIJNDNKMAJM, in DCNFIHFHOLK MIIOPMDNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x41D7BE0", Offset = "0x41D65E0", VA = "0x1841D7BE0")]
	private void NIANFLMFGFL(Entity EBOGCLNNJGN, in DCNFIHFHOLK HIJNDNKMAJM, in DCNFIHFHOLK MIIOPMDNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3565230", Offset = "0x3563C30", VA = "0x183565230", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x41DE260", Offset = "0x41DCC60", VA = "0x1841DE260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x41C9DB0", Offset = "0x41C87B0", VA = "0x1841C9DB0")]
	public string ELAHFBKAPEK(in DCNFIHFHOLK NJHHAEBDOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x355FEA0", Offset = "0x355E8A0", VA = "0x18355FEA0", Slot = "5")]
	private bool FNGOEDFILIE(CAMBCDMDDIB KFEMFMGCJPM, in T MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3560020", Offset = "0x355EA20", VA = "0x183560020", Slot = "6")]
	private bool CGOOAOFABFH(CAMBCDMDDIB KFEMFMGCJPM, in T MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x355FB20", Offset = "0x355E520", VA = "0x18355FB20", Slot = "10")]
	private bool AIPHPKAANPI(CAMBCDMDDIB KFEMFMGCJPM, in object MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x356F900", Offset = "0x356E300", VA = "0x18356F900", Slot = "11")]
	private void MJHEJNABHAO(CAMBCDMDDIB KFEMFMGCJPM, in FPKEMMGAFGA NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x356C620", Offset = "0x356B020", VA = "0x18356C620", Slot = "12")]
	private bool JDANJIOJPNB(CAMBCDMDDIB KFEMFMGCJPM, in DCNFIHFHOLK MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x356F940", Offset = "0x356E340", VA = "0x18356F940", Slot = "13")]
	private bool MOLEBICGMHI(CAMBCDMDDIB KFEMFMGCJPM, in DCNFIHFHOLK MIIOPMDNGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x20E4180", Offset = "0x20E2B80", VA = "0x1820E4180", Slot = "16")]
	private string KLNNDPMIEDI(in DCNFIHFHOLK NKJMIDIDBOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LJAPEEAMNPH : IDisposable, LLECKNIDJAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> KIMOLGKAGOD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> KKFADJGEANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9C65F0", Offset = "0x9C4FF0", VA = "0x1809C65F0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x1862490", Offset = "0x1860E90", VA = "0x181862490")]
	public LJAPEEAMNPH(NativeArray<EntityRemapUtility.EntityRemapInfo> KIMOLGKAGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2192FF0", Offset = "0x21919F0", VA = "0x182192FF0", Slot = "6")]
	public CAMBCDMDDIB MMJLAKEDIOO(CAMBCDMDDIB BCJDDLNACAB)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2192FE0", Offset = "0x21919E0", VA = "0x182192FE0", Slot = "7")]
	public Entity MMJLAKEDIOO(Entity EBOGCLNNJGN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2192F40", Offset = "0x2191940", VA = "0x182192F40", Slot = "8")]
	public IEnumerable<CAMBCDMDDIB> MMJLAKEDIOO(IEnumerable<CAMBCDMDDIB> EAOELIGDFKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2192EE0", Offset = "0x21918E0", VA = "0x182192EE0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[OJEJDFBPPED(FHFOPEOFOPD.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly LOOGELFKPLM LBJMALKMNAH;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int BOBMNDMECCJ;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static LLECKNIDJAH CKHOMKKKIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool PAANLNPNGMC;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> KKFADJGEANL
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x22F1080", Offset = "0x22EFA80", VA = "0x1822F1080")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static bool LGLKKPLHDAP
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x22F12A0", Offset = "0x22EFCA0", VA = "0x1822F12A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x22F1020", Offset = "0x22EFA20", VA = "0x1822F1020")]
		public static SerializationRemapScope CAHBBCACHPH()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x22F1650", Offset = "0x22F0050", VA = "0x1822F1650")]
		public SerializationRemapScope(LLECKNIDJAH FJPMBCGLFDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x22F1190", Offset = "0x22EFB90", VA = "0x1822F1190", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x22F1460", Offset = "0x22EFE60", VA = "0x1822F1460")]
		public static CAMBCDMDDIB MMJLAKEDIOO(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x22F1330", Offset = "0x22EFD30", VA = "0x1822F1330")]
		public static Entity MMJLAKEDIOO(Entity EBOGCLNNJGN)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DNKFJNHNNCA(typeof(PDPECNPKPIB), new string[] { "Editor" })]
[DDOFDCHAEEC(AHJKMAKLGJA.Application)]
public sealed class PDPECNPKPIB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void ELHGAJFPJJK(DPCBAIHHPOK EDJEIOAGFFK, KNBEGDBJHKK PJIINDGLAPJ, bool PCBECOPFHDA);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void IIENCHFCNKG(DPCBAIHHPOK EDJEIOAGFFK, bool PCBECOPFHDA);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void GBNNCLAEHJI(DPCBAIHHPOK EDJEIOAGFFK, ACIALDGCHGB GNIPEANGOCM, in DCNFIHFHOLK NKJMIDIDBOE, bool PCBECOPFHDA);

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event ELHGAJFPJJK IKGKNPFAEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x22DC2E0", Offset = "0x22DACE0", VA = "0x1822DC2E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x22DC600", Offset = "0x22DB000", VA = "0x1822DC600")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event IIENCHFCNKG KAOFMILJJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x22DC420", Offset = "0x22DAE20", VA = "0x1822DC420")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x22DC4C0", Offset = "0x22DAEC0", VA = "0x1822DC4C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event GBNNCLAEHJI CNOIMHDIFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x22DC380", Offset = "0x22DAD80", VA = "0x1822DC380")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x22DC560", Offset = "0x22DAF60", VA = "0x1822DC560")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x22DC6F0", Offset = "0x22DB0F0", VA = "0x1822DC6F0")]
	[Conditional("UNITY_EDITOR")]
	public void MKHNNEPANPE(DPCBAIHHPOK EDJEIOAGFFK, in KNBEGDBJHKK PJIINDGLAPJ, bool PCBECOPFHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x22DC6A0", Offset = "0x22DB0A0", VA = "0x1822DC6A0")]
	[Conditional("UNITY_EDITOR")]
	public void JAJFABGIFFC(DPCBAIHHPOK EDJEIOAGFFK, bool PCBECOPFHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x22DC6C0", Offset = "0x22DB0C0", VA = "0x1822DC6C0")]
	[Conditional("UNITY_EDITOR")]
	public void KBCABBBLBGB(DPCBAIHHPOK EDJEIOAGFFK, ACIALDGCHGB GNIPEANGOCM, in DCNFIHFHOLK NKJMIDIDBOE, bool PCBECOPFHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public PDPECNPKPIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DNKFJNHNNCA(typeof(LEAELDIEDJJ), new string[] { "Editor" })]
[DDOFDCHAEEC(AHJKMAKLGJA.Application)]
public sealed class LEAELDIEDJJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void JMPGFPDBDPC(DPCBAIHHPOK PKBNFFGFIEN, KNBEGDBJHKK PJIINDGLAPJ, bool PCBECOPFHDA);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void ADOJCPPHDJM(DPCBAIHHPOK PKBNFFGFIEN, bool PCBECOPFHDA);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void POLKONLHENM(DPCBAIHHPOK PKBNFFGFIEN, ACIALDGCHGB GNIPEANGOCM, in DCNFIHFHOLK NKJMIDIDBOE, bool PCBECOPFHDA, bool KLDFCAEDHFE);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void EEEFBMLJAEN(DPCBAIHHPOK PKBNFFGFIEN, ACIALDGCHGB GNIPEANGOCM, in DCNFIHFHOLK HIJNDNKMAJM, in DCNFIHFHOLK MIIOPMDNGOD);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void IAEMBHJKCAB(EOOFEIGHJBI KFEMFMGCJPM, ReadOnlyMemory<byte> IKLIFLGKEBP);

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event JMPGFPDBDPC IKGKNPFAEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x21908E0", Offset = "0x218F2E0", VA = "0x1821908E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2191050", Offset = "0x218FA50", VA = "0x182191050")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event ADOJCPPHDJM KAOFMILJJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2190A40", Offset = "0x218F440", VA = "0x182190A40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2190BB0", Offset = "0x218F5B0", VA = "0x182190BB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event JMPGFPDBDPC LKEDDCJFKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2191280", Offset = "0x218FC80", VA = "0x182191280")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2190F50", Offset = "0x218F950", VA = "0x182190F50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event ADOJCPPHDJM BDKKGOJLPNN
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x21911E0", Offset = "0x218FBE0", VA = "0x1821911E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2191320", Offset = "0x218FD20", VA = "0x182191320")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event POLKONLHENM CNOIMHDIFJF
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x21909A0", Offset = "0x218F3A0", VA = "0x1821909A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2190DE0", Offset = "0x218F7E0", VA = "0x182190DE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event EEEFBMLJAEN AHGKELGHHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2190EB0", Offset = "0x218F8B0", VA = "0x182190EB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x21913C0", Offset = "0x218FDC0", VA = "0x1821913C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<string, object> PJGIEKMABMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2191140", Offset = "0x218FB40", VA = "0x182191140")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2190AE0", Offset = "0x218F4E0", VA = "0x182190AE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event IAEMBHJKCAB GBIAJOHBFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2190D10", Offset = "0x218F710", VA = "0x182190D10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2190C70", Offset = "0x218F670", VA = "0x182190C70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2190B80", Offset = "0x218F580", VA = "0x182190B80")]
	[Conditional("UNITY_EDITOR")]
	public void EBBGFDANBDL(DPCBAIHHPOK PKBNFFGFIEN, in KNBEGDBJHKK PJIINDGLAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2190C50", Offset = "0x218F650", VA = "0x182190C50")]
	[Conditional("UNITY_EDITOR")]
	public void FALPCCGEAJE(DPCBAIHHPOK PKBNFFGFIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2191110", Offset = "0x218FB10", VA = "0x182191110")]
	[Conditional("UNITY_EDITOR")]
	public void JMLHBJFKLIN(DPCBAIHHPOK PKBNFFGFIEN, in KNBEGDBJHKK PJIINDGLAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x21910F0", Offset = "0x218FAF0", VA = "0x1821910F0")]
	[Conditional("UNITY_EDITOR")]
	public void ILNICEBFGID(DPCBAIHHPOK PKBNFFGFIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2190DB0", Offset = "0x218F7B0", VA = "0x182190DB0")]
	[Conditional("UNITY_EDITOR")]
	public void GKJIPPEEHGJ(DPCBAIHHPOK PKBNFFGFIEN, ACIALDGCHGB GNIPEANGOCM, in DCNFIHFHOLK NKJMIDIDBOE, bool KLDFCAEDHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2190980", Offset = "0x218F380", VA = "0x182190980")]
	[Conditional("UNITY_EDITOR")]
	public void BDFBCLMPGCB(DPCBAIHHPOK PKBNFFGFIEN, ACIALDGCHGB GNIPEANGOCM, in DCNFIHFHOLK HIJNDNKMAJM, in DCNFIHFHOLK MIIOPMDNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2190FF0", Offset = "0x218F9F0", VA = "0x182190FF0")]
	[Conditional("UNITY_EDITOR")]
	public void IFEONJONGPJ(string KKJOOAJGLJI, object IKLIFLGKEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2190E80", Offset = "0x218F880", VA = "0x182190E80")]
	[Conditional("UNITY_EDITOR")]
	public void HLGDGNJNELL(EOOFEIGHJBI KFEMFMGCJPM, ReadOnlyMemory<byte> IKLIFLGKEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LEAELDIEDJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DNKFJNHNNCA(typeof(GKDLCHGOPPB), new string[] { })]
public class FGMEPCKJPMH : GKDLCHGOPPB
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x217AE10", Offset = "0x2179810", VA = "0x18217AE10", Slot = "5")]
	public void KABAOKLNFCN(object PJJGOJBLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x217AB40", Offset = "0x2179540", VA = "0x18217AB40", Slot = "6")]
	public void APIMDHPLGPF(object PJJGOJBLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x217AD30", Offset = "0x2179730", VA = "0x18217AD30", Slot = "7")]
	public void GKFBEOPKKJL(object PJJGOJBLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x217AC20", Offset = "0x2179620", VA = "0x18217AC20", Slot = "4")]
	public IDisposable CJFCBFNBOIL(object PJJGOJBLNDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public FGMEPCKJPMH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[DNKFJNHNNCA(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	[OJEJDFBPPED(FHFOPEOFOPD.Serialization)]
	internal class BulkInstantiateSceneObjectService : CFMOGGHLNDM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string EBLBCKBDLFO = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[MJIDFIFGMKP]
		private PNLHBOHNCFH MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI FBFHHMCDIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[MJIDFIFGMKP]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[MJIDFIFGMKP]
		private NPDHBLHKCNF IHDGODIAJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private EntityQuery HLECBNDFOKG;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private EntityManager AJHOIKIBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x24B07C0", Offset = "0x24AF1C0", VA = "0x1824B07C0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x24B00B0", Offset = "0x24AEAB0", VA = "0x1824B00B0", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x24B0230", Offset = "0x24AEC30", VA = "0x1824B0230", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x24B0410", Offset = "0x24AEE10", VA = "0x1824B0410")]
		public bool IJGPEHDGAIE(IEnumerable<DCBEICMMGBC> GFPEKPHICAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x24B1050", Offset = "0x24AFA50", VA = "0x1824B1050")]
		public static bool PPEMKANJFNI(DCBEICMMGBC KDMHFDGDHMP, out DPCBAIHHPOK PKBNFFGFIEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x24AFB60", Offset = "0x24AE560", VA = "0x1824AFB60")]
		private void AONGNKJHKOB(Dictionary<DPCBAIHHPOK, DCBEICMMGBC> BINBGBCIPDP, IEnumerable<DCBEICMMGBC> GFPEKPHICAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x24B0590", Offset = "0x24AEF90", VA = "0x1824B0590")]
		private void JEDPFKMNNFN(Dictionary<DPCBAIHHPOK, DCBEICMMGBC> BINBGBCIPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x24B0810", Offset = "0x24AF210", VA = "0x1824B0810")]
		private void MJHHIMDKDDH(Dictionary<DPCBAIHHPOK, DCBEICMMGBC> BINBGBCIPDP, DPCBAIHHPOK PKBNFFGFIEN, string KKJOOAJGLJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x24B0CF0", Offset = "0x24AF6F0", VA = "0x1824B0CF0")]
		private void NDIDNHLEFEE(Dictionary<DPCBAIHHPOK, DCBEICMMGBC> BINBGBCIPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x24AF2C0", Offset = "0x24ADCC0", VA = "0x1824AF2C0")]
		private void AOCOEBGEOEF(Dictionary<DPCBAIHHPOK, DCBEICMMGBC> BINBGBCIPDP, List<DCBEICMMGBC> ALIJCGAIPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x24AFEE0", Offset = "0x24AE8E0", VA = "0x1824AFEE0")]
		private NativeList<DPCBAIHHPOK> CPAMIMJIKFC(Dictionary<DPCBAIHHPOK, DCBEICMMGBC> BINBGBCIPDP)
		{
			return default(NativeList<DPCBAIHHPOK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x24B0240", Offset = "0x24AEC40", VA = "0x1824B0240")]
		private NativeArray<Entity> EBNOFKHLEME(NativeList<DPCBAIHHPOK> FIHJHEBPEOA)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x24AF220", Offset = "0x24ADC20", VA = "0x1824AF220")]
		private static void ABKJCOMCMIB(Dictionary<DPCBAIHHPOK, DCBEICMMGBC> BINBGBCIPDP, DPCBAIHHPOK PKBNFFGFIEN, DCBEICMMGBC KDMHFDGDHMP, string KKJOOAJGLJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[DDOFDCHAEEC(AHJKMAKLGJA.Application)]
	[OJEJDFBPPED(FHFOPEOFOPD.Serialization)]
	[DNKFJNHNNCA(typeof(DebugWorldsService), new string[] { })]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal static bool KKNNLAGAGNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x24C1170", Offset = "0x24BFB70", VA = "0x1824C1170")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x24C11B0", Offset = "0x24BFBB0", VA = "0x1824C11B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		internal static bool FEAGIGDNCBN
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x24C11F0", Offset = "0x24BFBF0", VA = "0x1824C11F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x24C1230", Offset = "0x24BFC30", VA = "0x1824C1230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		public void GIPBKOCDEDG(string KKJOOAJGLJI, EntityManager KACBFFMHDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		public static void LCFMPIKHEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DNKFJNHNNCA(typeof(OEDCBLNEDEI), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.Application)]
internal class OEDCBLNEDEI
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool KKNNLAGAGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB30", Offset = "0x7DA530", VA = "0x1807DBB30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB40", Offset = "0x7DA540", VA = "0x1807DBB40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool MIGMGBIELCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xD5E400", Offset = "0xD5CE00", VA = "0x180D5E400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1B88520", Offset = "0x1B86F20", VA = "0x181B88520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public OEDCBLNEDEI()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[GPEKNNAMFFM(typeof(SerializationService))]
	[DNKFJNHNNCA(typeof(JIMAKGEINEB), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.Serialization)]
	internal class SerializationService : JIMAKGEINEB, IDisposable, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly LOOGELFKPLM NICMPNOKCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[MJIDFIFGMKP]
		private PNLHBOHNCFH MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[MJIDFIFGMKP]
		private DGIHKPBCDBI HNIDBFHKANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[MJIDFIFGMKP]
		private OEDCBLNEDEI LGEPGJALMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private OILOIPKCJDO DCFAMADNFBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private OLLGCDONNNB AJHPEPDDDIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private SerializationRemapScope MACNEEBFBDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool? OKHIKMGPMBN;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool JNNGCBPAKHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x22F3290", Offset = "0x22F1C90", VA = "0x1822F3290", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x22F1940", Offset = "0x22F0340", VA = "0x1822F1940", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool GDOEDOCPCEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x80DF90", Offset = "0x80C990", VA = "0x18080DF90", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x80D9E0", Offset = "0x80C3E0", VA = "0x18080D9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public OLLGCDONNNB NECNFKBCLMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x22F1CE0", Offset = "0x22F06E0", VA = "0x1822F1CE0", Slot = "16")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x22F1D80", Offset = "0x22F0780", VA = "0x1822F1D80", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x22F3160", Offset = "0x22F1B60", VA = "0x1822F3160")]
		public static bool NKJKIKKHJIF(ByteString IBDMDMLOLOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x81F1C0", Offset = "0x81DBC0", VA = "0x18081F1C0")]
		public void HJOOKAEDGPF(OILOIPKCJDO DEDOGJBGPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x22F2DD0", Offset = "0x22F17D0", VA = "0x1822F2DD0", Slot = "5")]
		public void MIJODKICEKN(bool GCNBMKKLBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x22F16E0", Offset = "0x22F00E0", VA = "0x1822F16E0", Slot = "6")]
		public Task ADMAKAHMHHN(bool GCNBMKKLBLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x22F3080", Offset = "0x22F1A80", VA = "0x1822F3080", Slot = "7")]
		public ByteString NJDODOCIOLN(out IDisposable MACNEEBFBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x22F2EA0", Offset = "0x22F18A0", VA = "0x1822F2EA0", Slot = "19")]
		public ByteString NJDODOCIOLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x22F2100", Offset = "0x22F0B00", VA = "0x1822F2100", Slot = "9")]
		public bool GKBAFEAOLLC(ByteString LILJLLMNJED, EFMNHPNKEDK ALIOHCFALJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x22F28E0", Offset = "0x22F12E0", VA = "0x1822F28E0")]
		private bool LDKDAIECPDJ(ByteString LILJLLMNJED, EFMNHPNKEDK ALIOHCFALJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x22F2C00", Offset = "0x22F1600", VA = "0x1822F2C00", Slot = "8")]
		public void LGJFPPKKKIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x22F1D90", Offset = "0x22F0790", VA = "0x1822F1D90", Slot = "10")]
		public bool EAIKNABCIMJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x22F2390", Offset = "0x22F0D90", VA = "0x1822F2390", Slot = "11")]
		public bool IJGPEHDGAIE(IEnumerable<DCBEICMMGBC> OAOMNDFMDJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x22F2800", Offset = "0x22F1200", VA = "0x1822F2800")]
		public bool LDCHEHNHFAI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x22F2160", Offset = "0x22F0B60", VA = "0x1822F2160", Slot = "12")]
		public bool HDAFDLBGHPM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x22F1950", Offset = "0x22F0350", VA = "0x1822F1950")]
		public void CEILGFAHOKE(OLLGCDONNNB.JHHGJDANCHE.KDOJHLOCNKO LFIDNIDJNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x22F33B0", Offset = "0x22F1DB0", VA = "0x1822F33B0")]
		private bool PKGMCNHNMPN(ByteString LILJLLMNJED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x22F1BE0", Offset = "0x22F05E0", VA = "0x1822F1BE0")]
		private void DAIFBJFNIEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x22F2000", Offset = "0x22F0A00", VA = "0x1822F2000")]
		private ByteString EKEGDOBAHDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x22F32A0", Offset = "0x22F1CA0", VA = "0x1822F32A0")]
		private ByteString PFJMKGIFPFG(ByteString IBDMDMLOLOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x22F2060", Offset = "0x22F0A60", VA = "0x1822F2060")]
		private OLLGCDONNNB.JHHGJDANCHE.KDOJHLOCNKO FLIPDGLGFKH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x22F2600", Offset = "0x22F1000", VA = "0x1822F2600")]
		private void JPCBHDCNOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x22F1770", Offset = "0x22F0170", VA = "0x1822F1770", Slot = "13")]
		public bool APFCLBJLGIF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x22F1C30", Offset = "0x22F0630", VA = "0x1822F1C30", Slot = "14")]
		public void DFGOEIGCCGC(bool DKGGHBNGHFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x22F2630", Offset = "0x22F1030", VA = "0x1822F2630")]
		private void LCFMPIKHEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DNKFJNHNNCA(typeof(EMCACLLEGIF), new string[] { })]
[GPEKNNAMFFM(typeof(DGIHKPBCDBI))]
internal class DGIHKPBCDBI : EMCACLLEGIF
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action KPMFCHAFFCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x24BF740", Offset = "0x24BE140", VA = "0x1824BF740", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x24BFA60", Offset = "0x24BE460", VA = "0x1824BFA60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<LLECKNIDJAH> GMEMFIMCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x24BF560", Offset = "0x24BDF60", VA = "0x1824BF560", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x24BF4C0", Offset = "0x24BDEC0", VA = "0x1824BF4C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action NBPJEADFNBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x24BF600", Offset = "0x24BE000", VA = "0x1824BF600", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x24BF880", Offset = "0x24BE280", VA = "0x1824BF880", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action EBFLBFPJFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x24BF920", Offset = "0x24BE320", VA = "0x1824BF920", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x24BF9C0", Offset = "0x24BE3C0", VA = "0x1824BF9C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<LLECKNIDJAH> LEDKAANAEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x24BFB00", Offset = "0x24BE500", VA = "0x1824BFB00", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x24BF6A0", Offset = "0x24BE0A0", VA = "0x1824BF6A0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6EB960", Offset = "0x6EA360", VA = "0x1806EB960")]
	public void LGJFPPKKKIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA70", Offset = "0x6EA470", VA = "0x1806EBA70")]
	public void AKPMLCJFPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F13C0", Offset = "0x7EFDC0", VA = "0x1807F13C0")]
	public void NHPLAAFFCPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x24BF7E0", Offset = "0x24BE1E0", VA = "0x1824BF7E0")]
	public void FCLDFKBAJLL(LLECKNIDJAH CKHOMKKKIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x24BF830", Offset = "0x24BE230", VA = "0x1824BF830")]
	public void HBIENPKEJIM(LLECKNIDJAH CKHOMKKKIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public DGIHKPBCDBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DNKFJNHNNCA(typeof(LKBGGDFMKHG), new string[] { })]
public class GINLJACLFKJ : LKBGGDFMKHG, OKCOAIBIMKN, AHDDAOHEFAN, CFMOGGHLNDM, BGKGLCNGELH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EntityHierarchyParents MBAGNKEDBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private HBNKALMIHFD MCCJMCMAHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private ObjectEmbodimentService OFGCILEINOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private bool HHKBONGDECE;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public global::HHMNIGMFFBK<CAMBCDMDDIB> JGBBHLPMGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6F0", Offset = "0x6AE0F0", VA = "0x1806AF6F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x85EE80", Offset = "0x85D880", VA = "0x18085EE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EntityManager AJHOIKIBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x217E840", Offset = "0x217D240", VA = "0x18217E840")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0xBB36D0", Offset = "0xBB20D0", VA = "0x180BB36D0", Slot = "14")]
	public void LMBJCLDJBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x217DBB0", Offset = "0x217C5B0", VA = "0x18217DBB0", Slot = "15")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x217EB30", Offset = "0x217D530", VA = "0x18217EB30", Slot = "16")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F1450", Offset = "0x7EFE50", VA = "0x1807F1450", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x217ECF0", Offset = "0x217D6F0", VA = "0x18217ECF0")]
	private CAMBCDMDDIB OHDJOELKLLL(Entity EBOGCLNNJGN)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x217DF20", Offset = "0x217C920", VA = "0x18217DF20", Slot = "4")]
	public CAMBCDMDDIB HFMIOHHMJCK(CAMBCDMDDIB BCJDDLNACAB)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x217ED20", Offset = "0x217D720", VA = "0x18217ED20", Slot = "19")]
	public void PGPLHJJOJKI(ref List<CAMBCDMDDIB> CDPILLKGKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x217E010", Offset = "0x217CA10", VA = "0x18217E010", Slot = "20")]
	public IEnumerable<CAMBCDMDDIB> IDDFHLAGAON(CAMBCDMDDIB BCJDDLNACAB, bool EBLHCCBCAHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x217E890", Offset = "0x217D290", VA = "0x18217E890", Slot = "21")]
	public CAMBCDMDDIB LMHHMBOFGOF(CAMBCDMDDIB BCJDDLNACAB, int NENMOOINMCH)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x217E630", Offset = "0x217D030", VA = "0x18217E630", Slot = "22")]
	public int LHGJGCKEMCF(CAMBCDMDDIB BCJDDLNACAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x217DA10", Offset = "0x217C410", VA = "0x18217DA10", Slot = "8")]
	public int CJDHHAODJFB(CAMBCDMDDIB BCJDDLNACAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x217E750", Offset = "0x217D150", VA = "0x18217E750", Slot = "9")]
	public OIAFHGFMCMO LKENBGLLCCH(CAMBCDMDDIB BCJDDLNACAB)
	{
		return default(OIAFHGFMCMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x217E320", Offset = "0x217CD20", VA = "0x18217E320", Slot = "23")]
	public bool JIHKENIHHIH(CAMBCDMDDIB BCJDDLNACAB, out OIAFHGFMCMO PJEKFFBANMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x217DC80", Offset = "0x217C680", VA = "0x18217DC80", Slot = "24")]
	public IEnumerable<CAMBCDMDDIB> FCNKBCKODOP(CAMBCDMDDIB BCJDDLNACAB, bool EBLHCCBCAHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x217EA60", Offset = "0x217D460", VA = "0x18217EA60", Slot = "12")]
	public CAMBCDMDDIB MACLNGAGHFP(CAMBCDMDDIB BGIPIHJGIOM, CAMBCDMDDIB ACFAFPAEJAI)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x217EC20", Offset = "0x217D620", VA = "0x18217EC20", Slot = "13")]
	public bool OAKKIMOAAKP(CAMBCDMDDIB BGIPIHJGIOM, CAMBCDMDDIB ACFAFPAEJAI, out CAMBCDMDDIB KPPDBEKLBMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x217E210", Offset = "0x217CC10", VA = "0x18217E210", Slot = "5")]
	public CAMBCDMDDIB INMLOHDEIIC(CAMBCDMDDIB BCJDDLNACAB)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x217DD50", Offset = "0x217C750", VA = "0x18217DD50", Slot = "11")]
	public bool GGEEMOCPIPE(CAMBCDMDDIB BCJDDLNACAB, CAMBCDMDDIB HBDJLMFKBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x217E4F0", Offset = "0x217CEF0", VA = "0x18217E4F0", Slot = "25")]
	public bool LCEGNLFANNF(CAMBCDMDDIB BCJDDLNACAB, CAMBCDMDDIB AHDACGEMPDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x217DE10", Offset = "0x217C810", VA = "0x18217DE10", Slot = "10")]
	public bool HADBHNHIDJL(CAMBCDMDDIB BCJDDLNACAB, CAMBCDMDDIB BGIPIHJGIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x217EF50", Offset = "0x217D950", VA = "0x18217EF50", Slot = "6")]
	public bool PKNDJFHBPIO(CAMBCDMDDIB BCJDDLNACAB, CAMBCDMDDIB EGNCPOLPGCD, bool FLALBEMBEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x217E2B0", Offset = "0x217CCB0", VA = "0x18217E2B0", Slot = "7")]
	public bool IOOGAKGECJH(CAMBCDMDDIB BCJDDLNACAB, CAMBCDMDDIB EGNCPOLPGCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public GINLJACLFKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
[DNKFJNHNNCA(typeof(NENJKMNFLCL), new string[] { })]
internal class NENJKMNFLCL : CFMOGGHLNDM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[MJIDFIFGMKP]
	private OBGMOBEFLNM CDGNAONMFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<int, MLCLABHKFLP> PFNACKDJBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool HHKBONGDECE;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x22CA9B0", Offset = "0x22C93B0", VA = "0x1822CA9B0", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x22CAA00", Offset = "0x22C9400", VA = "0x1822CAA00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC80", Offset = "0x22C9680", VA = "0x1822CAC80")]
	public MLCLABHKFLP GLHAFIPBCCK(GMGAEIHDIEM OKNFKAJADBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x22CAD80", Offset = "0x22C9780", VA = "0x1822CAD80")]
	public MLCLABHKFLP GLHAFIPBCCK(ACIALDGCHGB EDNCKFCJECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x22CAFA0", Offset = "0x22C99A0", VA = "0x1822CAFA0")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x22CB130", Offset = "0x22C9B30", VA = "0x1822CB130")]
	public NENJKMNFLCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class MLCLABHKFLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<GFLMHAJGBCE> AOAGBBEFNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<PLGLIKALDJI> ONMJLHMFKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<PCMAMIJLKEM> EBKGKGHGCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<PLGLIKALDJI> ALOODLHKPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private bool HHKBONGDECE;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NativeList<GFLMHAJGBCE> BFLBHDAPAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x9C65F0", Offset = "0x9C4FF0", VA = "0x1809C65F0")]
		get
		{
			return default(NativeList<GFLMHAJGBCE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<PLGLIKALDJI> IPALKFNFLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x94F170", Offset = "0x94DB70", VA = "0x18094F170")]
		get
		{
			return default(NativeList<PLGLIKALDJI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<PCMAMIJLKEM> OMDCKACDCAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xBC6F40", Offset = "0xBC5940", VA = "0x180BC6F40")]
		get
		{
			return default(NativeList<PCMAMIJLKEM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<PLGLIKALDJI> OCBKGBNFEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9C6600", Offset = "0x9C5000", VA = "0x1809C6600")]
		get
		{
			return default(NativeList<PLGLIKALDJI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JobHandle LKKNIGFBAKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A43F0", Offset = "0x6A2DF0", VA = "0x1806A43F0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6A4480", Offset = "0x6A2E80", VA = "0x1806A4480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MMGCNOGJJID
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6E2F80", Offset = "0x6E1980", VA = "0x1806E2F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool NKKOEEPHCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x22C9580", Offset = "0x22C7F80", VA = "0x1822C9580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x22C9990", Offset = "0x22C8390", VA = "0x1822C9990")]
	public MLCLABHKFLP(Allocator FAMNMGKAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x22C9630", Offset = "0x22C8030", VA = "0x1822C9630")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x22C9450", Offset = "0x22C7E50", VA = "0x1822C9450")]
	public void DMDPJFLHNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x22C96C0", Offset = "0x22C80C0", VA = "0x1822C96C0")]
	public void MJIKPLNABDE(Entity EBOGCLNNJGN, Entity NKGEBLNPFNO, Entity CLJJCFEFLNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DNKFJNHNNCA(typeof(EHIOJOBKMKA), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
public class EHIOJOBKMKA : CFMOGGHLNDM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[MJIDFIFGMKP]
	private SceneService GBKOJEMNHHK;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x24C36B0", Offset = "0x24C20B0", VA = "0x1824C36B0", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x24C3700", Offset = "0x24C2100", VA = "0x1824C3700", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public EHIOJOBKMKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal abstract class LHOEMMFMKFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private uint IOLICLKAOCD;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public abstract uint AIJJNEJFPAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2192DC0", Offset = "0x21917C0", VA = "0x182192DC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2192DE0", Offset = "0x21917E0", VA = "0x182192DE0")]
	public DPCBAIHHPOK GICGNKCOHGK()
	{
		return default(DPCBAIHHPOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2192E30", Offset = "0x2191830", VA = "0x182192E30")]
	public void IJABIEIAOFH(DPCBAIHHPOK PKBNFFGFIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x166FD40", Offset = "0x166E740", VA = "0x18166FD40", Slot = "6")]
	public virtual void FFPBPCNLABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	protected LHOEMMFMKFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
[DNKFJNHNNCA(typeof(BHDAADBNJHB), new string[] { })]
internal sealed class BHDAADBNJHB : LHOEMMFMKFC, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[MJIDFIFGMKP]
	private PNLHBOHNCFH MGOGCFMPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private uint GGLJLEEFAFM;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override uint AIJJNEJFPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6E5670", Offset = "0x6E4070", VA = "0x1806E5670", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x24AE260", Offset = "0x24ACC60", VA = "0x1824AE260", Slot = "7")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x24AE210", Offset = "0x24ACC10", VA = "0x1824AE210")]
	private void AKEDGBPPHEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x24AE300", Offset = "0x24ACD00", VA = "0x1824AE300", Slot = "6")]
	public override void FFPBPCNLABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
	public BHDAADBNJHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DNKFJNHNNCA(typeof(IHJILKIHBOF), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
internal sealed class IHJILKIHBOF : LHOEMMFMKFC
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override uint AIJJNEJFPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6A0140", Offset = "0x69EB40", VA = "0x1806A0140", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public IHJILKIHBOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
[DNKFJNHNNCA(typeof(EOFAFOGAPOE), new string[] { })]
internal sealed class EOFAFOGAPOE : OKCOAIBIMKN, AHDDAOHEFAN, CFMOGGHLNDM, BGKGLCNGELH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[MJIDFIFGMKP]
	private CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery JLMGGLOFPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery PJIHCOEOHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery GNPOAKOKCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery ILEKMGAAPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private EntityQuery KCPPPABJLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private EntityQuery LEBJLDCBJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private bool HHKBONGDECE;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private EntityManager AJHOIKIBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x24C58A0", Offset = "0x24C42A0", VA = "0x1824C58A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public EntityQuery DMLNMLFLDID
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x909700", Offset = "0x908100", VA = "0x180909700")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityQuery MDINPEEIOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xB818C0", Offset = "0xB802C0", VA = "0x180B818C0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery PAGMDKCCBFA
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7A0810", Offset = "0x79F210", VA = "0x1807A0810")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery EMEOJGBJHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6A43F0", Offset = "0x6A2DF0", VA = "0x1806A43F0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery OLNHGEKAIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6A43E0", Offset = "0x6A2DE0", VA = "0x1806A43E0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery PALPLAKKECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x24C57C0", Offset = "0x24C41C0", VA = "0x1824C57C0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int IEOBNNJFDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x24C5550", Offset = "0x24C3F50", VA = "0x1824C5550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int IEJKCMAMFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x24C5530", Offset = "0x24C3F30", VA = "0x1824C5530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int FHPALLHODOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x24C5DB0", Offset = "0x24C47B0", VA = "0x1824C5DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int AILHBEFHKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x24C5570", Offset = "0x24C3F70", VA = "0x1824C5570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int PDJPMCMIPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x24C57A0", Offset = "0x24C41A0", VA = "0x1824C57A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int EELHOPDJHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x24C5D90", Offset = "0x24C4790", VA = "0x1824C5D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "4")]
	public void LMBJCLDJBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x24C5590", Offset = "0x24C3F90", VA = "0x1824C5590", Slot = "5")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x24C58F0", Offset = "0x24C42F0", VA = "0x1824C58F0", Slot = "6")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x24C5840", Offset = "0x24C4240", VA = "0x1824C5840")]
	private EntityQueryDesc KKECLNHJPIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x24C55E0", Offset = "0x24C3FE0", VA = "0x1824C55E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x24C5640", Offset = "0x24C4040", VA = "0x1824C5640")]
	public HIODIHGJCID FAEOMGJODAI(CAMBCDMDDIB MMCCMEFGKOD)
	{
		return default(HIODIHGJCID);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x24C56F0", Offset = "0x24C40F0", VA = "0x1824C56F0")]
	public HIODIHGJCID FAEOMGJODAI(Entity EBOGCLNNJGN)
	{
		return default(HIODIHGJCID);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x24C5DD0", Offset = "0x24C47D0", VA = "0x1824C5DD0")]
	public MIJMGOMOBGM PGEKFHHBGMN(Entity EBOGCLNNJGN)
	{
		return default(MIJMGOMOBGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x24C5E80", Offset = "0x24C4880", VA = "0x1824C5E80")]
	public EOFAFOGAPOE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[OJEJDFBPPED(FHFOPEOFOPD.All)]
	[DNKFJNHNNCA(typeof(PPBLJKKDGPH), new string[] { })]
	public class ObjectService : CFMOGGHLNDM, PPBLJKKDGPH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly LOOGELFKPLM PHCEEKMDNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[MJIDFIFGMKP]
		private PHMOCMIEEKH ALJPPMMDDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[MJIDFIFGMKP]
		private PNLHBOHNCFH MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[MJIDFIFGMKP]
		private ObjectLifecycleService MBPFMENCMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[MJIDFIFGMKP]
		private ObjectEmbodimentService OFGCILEINOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[MJIDFIFGMKP]
		private ObjectInstantiationService JFOCGIPFIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[MJIDFIFGMKP]
		private EOFAFOGAPOE MCCJMCMAHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private ObjectNetworkToLocalMapService JCHNGOPCAEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool HHKBONGDECE;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public PHMOCMIEEKH KCKPMIGEKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int IEOBNNJFDMB
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x22D8BF0", Offset = "0x22D75F0", VA = "0x1822D8BF0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int IEJKCMAMFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x22D8BD0", Offset = "0x22D75D0", VA = "0x1822D8BD0", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int FHPALLHODOO
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x22DA590", Offset = "0x22D8F90", VA = "0x1822DA590", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int AILHBEFHKMM
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x22D8CC0", Offset = "0x22D76C0", VA = "0x1822D8CC0", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int PDJPMCMIPKF
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x22D9290", Offset = "0x22D7C90", VA = "0x1822D9290", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int EELHOPDJHOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x22DA300", Offset = "0x22D8D00", VA = "0x1822DA300", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<CAMBCDMDDIB, MIJMGOMOBGM> FPENOLHFJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x22DA670", Offset = "0x22D9070", VA = "0x1822DA670", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x22D8B30", Offset = "0x22D7530", VA = "0x1822D8B30", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<CAMBCDMDDIB> BMBKOLJNHKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x22D90D0", Offset = "0x22D7AD0", VA = "0x1822D90D0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x22D8960", Offset = "0x22D7360", VA = "0x1822D8960", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x22D8CE0", Offset = "0x22D76E0", VA = "0x1822D8CE0", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x22D8F50", Offset = "0x22D7950", VA = "0x1822D8F50", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x22DA210", Offset = "0x22D8C10", VA = "0x1822DA210")]
		private void MPEFFMKFPKN(Entity EBOGCLNNJGN, MIJMGOMOBGM PKKAOLKCAGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x22D98C0", Offset = "0x22D82C0", VA = "0x1822D98C0")]
		private void KPJEAAHAOAN(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x22DA4D0", Offset = "0x22D8ED0", VA = "0x1822DA4D0")]
		internal CAMBCDMDDIB OHDJOELKLLL(Entity EBOGCLNNJGN)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x22DA170", Offset = "0x22D8B70", VA = "0x1822DA170", Slot = "41")]
		public OIAFHGFMCMO MOLBNDGAHPH()
		{
			return default(OIAFHGFMCMO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x22D9340", Offset = "0x22D7D40", VA = "0x1822D9340", Slot = "42")]
		public OIAFHGFMCMO GCCCCPAFLJH()
		{
			return default(OIAFHGFMCMO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x22DA4F0", Offset = "0x22D8EF0", VA = "0x1822DA4F0", Slot = "43")]
		public OIAFHGFMCMO OOMCOPEHKDP()
		{
			return default(OIAFHGFMCMO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x22D9260", Offset = "0x22D7C60", VA = "0x1822D9260", Slot = "10")]
		public HIODIHGJCID FAEOMGJODAI(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(HIODIHGJCID);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x22DA5B0", Offset = "0x22D8FB0", VA = "0x1822DA5B0", Slot = "11")]
		public MIJMGOMOBGM PGEKFHHBGMN(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(MIJMGOMOBGM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x22D8C10", Offset = "0x22D7610", VA = "0x1822D8C10")]
		private OIAFHGFMCMO CLJLKPCLNHJ(EntityQuery NBKDJEEFFOH)
		{
			return default(OIAFHGFMCMO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x22D94E0", Offset = "0x22D7EE0", VA = "0x1822D94E0", Slot = "33")]
		public bool HHAMBKOEDIN(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x22D9B90", Offset = "0x22D8590", VA = "0x1822D9B90", Slot = "29")]
		public void LGJCJPODOEB(CAMBCDMDDIB BCJDDLNACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x22D9C00", Offset = "0x22D8600", VA = "0x1822D9C00", Slot = "30")]
		public void LNOHFPOICNF(CAMBCDMDDIB BCJDDLNACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x22D9440", Offset = "0x22D7E40", VA = "0x1822D9440", Slot = "31")]
		public void GNCPPNMILKH(CAMBCDMDDIB BCJDDLNACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x22D9D40", Offset = "0x22D8740", VA = "0x1822D9D40", Slot = "22")]
		public MPBFDJNFALM MDCILGHIJEK(MIJMGOMOBGM PKKAOLKCAGJ, bool HHPJLANHGMD)
		{
			return default(MPBFDJNFALM);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x22D9E00", Offset = "0x22D8800", VA = "0x1822D9E00", Slot = "23")]
		public MPBFDJNFALM MDCILGHIJEK(MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(MPBFDJNFALM);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x22D92B0", Offset = "0x22D7CB0", VA = "0x1822D92B0", Slot = "24")]
		public MPBFDJNFALM FKACOFEIDOK(MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(MPBFDJNFALM);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x22D9950", Offset = "0x22D8350", VA = "0x1822D9950", Slot = "25")]
		public MPBFDJNFALM LBKNPNPADJN(DPCBAIHHPOK PKBNFFGFIEN, MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(MPBFDJNFALM);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x22D9B20", Offset = "0x22D8520", VA = "0x1822D9B20", Slot = "44")]
		public MPBFDJNFALM LFPFKOGGFDG(int PBKBJELIDIE, MIJMGOMOBGM PKKAOLKCAGJ, GameObject OOAFGPFKNDK)
		{
			return default(MPBFDJNFALM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x22D9570", Offset = "0x22D7F70", VA = "0x1822D9570", Slot = "26")]
		public JCDNDIPOGFL HLBGIIJOCHM()
		{
			return default(JCDNDIPOGFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x22D9700", Offset = "0x22D8100", VA = "0x1822D9700", Slot = "45")]
		public LEPDHOMEFPC IIPKCGJIMIG(ANCPEPLHJEH NFMPIOLJBMO)
		{
			return default(LEPDHOMEFPC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x22D9C60", Offset = "0x22D8660", VA = "0x1822D9C60", Slot = "27")]
		public PPEMCAMCLOO LPGPAEIFBOD()
		{
			return default(PPEMCAMCLOO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x22D8780", Offset = "0x22D7180", VA = "0x1822D8780", Slot = "28")]
		public GKDHPEDBNNI AEJNCOLBJMB(BKPIKMGJOND NFMPIOLJBMO)
		{
			return default(GKDHPEDBNNI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x22D9F50", Offset = "0x22D8950", VA = "0x1822D9F50", Slot = "12")]
		public void MKIHEFFHNPG(DPCBAIHHPOK PKBNFFGFIEN, DFAIMGIACIM EJBCCLHPPKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x22DA320", Offset = "0x22D8D20", VA = "0x1822DA320", Slot = "13")]
		public MPBFDJNFALM NOBOKBCMGFG(CAMBCDMDDIB BCJDDLNACAB, [Optional] object KBCPLDFOJJL)
		{
			return default(MPBFDJNFALM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x22D9820", Offset = "0x22D8220", VA = "0x1822D9820", Slot = "14")]
		public bool IPHGNDNNICN(CAMBCDMDDIB BCJDDLNACAB, out DFAIMGIACIM HHGIFHKDCCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x22DA120", Offset = "0x22D8B20", VA = "0x1822DA120", Slot = "46")]
		public Transform MOAJKOHAGGC(CAMBCDMDDIB BCJDDLNACAB, [Optional] object KBCPLDFOJJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x22D93F0", Offset = "0x22D7DF0", VA = "0x1822D93F0", Slot = "16")]
		public bool GDFGLFJBJGL(CAMBCDMDDIB BCJDDLNACAB, out Transform MLMJNFGMBPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x22DA2B0", Offset = "0x22D8CB0", VA = "0x1822DA2B0", Slot = "17")]
		public bool NCHGJDANBJA(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x22D9EE0", Offset = "0x22D88E0", VA = "0x1822D9EE0")]
		public bool MHAPPCNJPCM(DFAIMGIACIM NKJMIDIDBOE, [Optional] object KBCPLDFOJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x22D9EB0", Offset = "0x22D88B0", VA = "0x1822D9EB0", Slot = "47")]
		public bool MHAPPCNJPCM(CAMBCDMDDIB BCJDDLNACAB, [Optional] object KBCPLDFOJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x22D9BE0", Offset = "0x22D85E0", VA = "0x1822D9BE0", Slot = "48")]
		public void LJEGCENOOPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x22D9F70", Offset = "0x22D8970", VA = "0x1822D9F70", Slot = "15")]
		public void MKLNIDIPJOA(DFAIMGIACIM PDHKCBEBPNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x22D9F10", Offset = "0x22D8910", VA = "0x1822D9F10", Slot = "49")]
		public void MJJCFAGNLND(CAMBCDMDDIB BCJDDLNACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x22DA5F0", Offset = "0x22D8FF0", VA = "0x1822DA5F0", Slot = "18")]
		public bool PHPBEMPIHMH(Entity EBOGCLNNJGN, object KBCPLDFOJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x22D8AB0", Offset = "0x22D74B0", VA = "0x1822D8AB0", Slot = "19")]
		public bool BHFGGDBKCKN(Entity EBOGCLNNJGN, object KBCPLDFOJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x22D9690", Offset = "0x22D8090", VA = "0x1822D9690", Slot = "50")]
		public bool ICMCENODBFH(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x22D8A40", Offset = "0x22D7440", VA = "0x1822D8A40", Slot = "51")]
		public bool BGNDNGOBIED(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x22D9630", Offset = "0x22D8030", VA = "0x1822D9630", Slot = "32")]
		public NativeArray<(CAMBCDMDDIB, CAMBCDMDDIB)> HLPEGFGOKMH(NativeArray<CAMBCDMDDIB> NFBGBJGHGCO, Allocator FAMNMGKAFPB)
		{
			return default(NativeArray<(CAMBCDMDDIB, CAMBCDMDDIB)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x22D88C0", Offset = "0x22D72C0", VA = "0x1822D88C0", Slot = "21")]
		public DPCBAIHHPOK AJLOHFFBBNE(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(DPCBAIHHPOK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x22D9170", Offset = "0x22D7B70", VA = "0x1822D9170", Slot = "20")]
		public CAMBCDMDDIB EJCMNEKEHKK(DPCBAIHHPOK PKBNFFGFIEN)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x22D8A00", Offset = "0x22D7400", VA = "0x1822D8A00")]
		private void BDFPGIMDCLJ(MIJMGOMOBGM PKKAOLKCAGJ, CAMBCDMDDIB BCJDDLNACAB, DPCBAIHHPOK PKBNFFGFIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DNKFJNHNNCA(typeof(LNBLKDDFKKK), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
internal sealed class LNBLKDDFKKK : CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private ObjectInstantiationService JFOCGIPFIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[MJIDFIFGMKP]
	private EOFAFOGAPOE MCCJMCMAHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[MJIDFIFGMKP]
	private CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x21948A0", Offset = "0x21932A0", VA = "0x1821948A0", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2194AC0", Offset = "0x21934C0", VA = "0x182194AC0")]
	public NativeArray<(CAMBCDMDDIB, CAMBCDMDDIB)> HLPEGFGOKMH(NativeArray<CAMBCDMDDIB> NFBGBJGHGCO, Allocator FAMNMGKAFPB)
	{
		return default(NativeArray<(CAMBCDMDDIB, CAMBCDMDDIB)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2194BC0", Offset = "0x21935C0", VA = "0x182194BC0")]
	private void IPHGAMBBIJA(NativeMultiHashMap<int, (CAMBCDMDDIB src, CAMBCDMDDIB dst)> OHNKEPNMFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2194410", Offset = "0x2192E10", VA = "0x182194410")]
	private void DABNMDELLMH(NativeMultiHashMap<int, (CAMBCDMDDIB src, CAMBCDMDDIB dst)> OHNKEPNMFJN, int PKKAOLKCAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2194930", Offset = "0x2193330", VA = "0x182194930")]
	private void FCIAJMCNIBG(NativeMultiHashMap<int, (CAMBCDMDDIB src, CAMBCDMDDIB dst)> OHNKEPNMFJN, int PKKAOLKCAGJ, HNAPDCCEHDA CDGNAONMFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2194DA0", Offset = "0x21937A0", VA = "0x182194DA0")]
	private NativeMultiHashMap<int, (CAMBCDMDDIB, CAMBCDMDDIB)> OCMKHHHJHBP(Allocator FAMNMGKAFPB, NativeArray<CAMBCDMDDIB> NFBGBJGHGCO, out NativeArray<(CAMBCDMDDIB src, CAMBCDMDDIB dst)> JKOMMIHMNFP)
	{
		return default(NativeMultiHashMap<int, (CAMBCDMDDIB, CAMBCDMDDIB)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LNBLKDDFKKK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[GPEKNNAMFFM(typeof(TransformService))]
	[DNKFJNHNNCA(typeof(NPDHBLHKCNF), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.TransformSyncing)]
	public class TransformService : NPDHBLHKCNF, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly LOOGELFKPLM KEKDCGCFNMH;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly LOOGELFKPLM KLIENKKEOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private PNLHBOHNCFH MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private EFAKDFLPENE HLDGGAOHOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private CAOOBKKGEDI MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private LKBGGDFMKHG HDFHOPBBCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TransformOwnershipPhase IAFHJDMHECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ObjectEmbodimentService DDEMFDMAJBL;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private EntityManager AJHOIKIBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x22FD6A0", Offset = "0x22FC0A0", VA = "0x1822FD6A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private AMGOMELBDKB JMGIMDJFKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x22FBE50", Offset = "0x22FA850", VA = "0x1822FBE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x22FA870", Offset = "0x22F9270", VA = "0x1822FA870", Slot = "33")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x22FD090", Offset = "0x22FBA90", VA = "0x1822FD090", Slot = "34")]
		public bool KKIPDHEPPLE(Transform MLMJNFGMBPE, out CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x22FD980", Offset = "0x22FC380", VA = "0x1822FD980", Slot = "35")]
		public Transform MJGLJJFCNPN(Entity EBOGCLNNJGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x22FB350", Offset = "0x22F9D50", VA = "0x1822FB350", Slot = "30")]
		public bool GDFGLFJBJGL(Entity EBOGCLNNJGN, out Transform MLMJNFGMBPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x22FDFE0", Offset = "0x22FC9E0", VA = "0x1822FDFE0")]
		private void POOKOEJFKMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x22FD250", Offset = "0x22FBC50", VA = "0x1822FD250", Slot = "29")]
		public void LBDECOIMLPI(Entity EBOGCLNNJGN, out Matrix4x4 MABFHCIMHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x22FD6F0", Offset = "0x22FC0F0", VA = "0x1822FD6F0", Slot = "4")]
		public void MFPIHDMDGDI(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x22FD3A0", Offset = "0x22FBDA0", VA = "0x1822FD3A0")]
		public void LDMNBEPKAGM(Entity EBOGCLNNJGN, Vector3 JJPMPKMDDHD, Quaternion JOJONLKIPPH, Vector3 FIJHMHCNFPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x22FDCD0", Offset = "0x22FC6D0", VA = "0x1822FDCD0")]
		public void PBMLABICEHB(Entity EBOGCLNNJGN, Vector3 JJPMPKMDDHD, Quaternion JOJONLKIPPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x22F9850", Offset = "0x22F8250", VA = "0x1822F9850", Slot = "27")]
		public void BABHFBKPGOC(Entity EBOGCLNNJGN, out Matrix4x4 AKDPEMHOGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x22FBA90", Offset = "0x22FA490", VA = "0x1822FBA90")]
		public void HKNGGHIDAAL(Entity EBOGCLNNJGN, in Matrix4x4 MABFHCIMHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x22FB440", Offset = "0x22F9E40", VA = "0x1822FB440")]
		public void GLCPEKGFIND(Entity EBOGCLNNJGN, in Matrix4x4 MABFHCIMHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x22FAAF0", Offset = "0x22F94F0", VA = "0x1822FAAF0")]
		public void DOBCGFHBCII(Entity EBOGCLNNJGN, in Matrix4x4 GJKPLLPBJDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x22FDEC0", Offset = "0x22FC8C0", VA = "0x1822FDEC0", Slot = "5")]
		public void PHAJEOFHCMD(Entity EBOGCLNNJGN, Vector3 NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x22F91C0", Offset = "0x22F7BC0", VA = "0x1822F91C0", Slot = "6")]
		public Vector3 AIMFAGGOBMC(Entity EBOGCLNNJGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x22FB250", Offset = "0x22F9C50", VA = "0x1822FB250", Slot = "7")]
		public void FPBIOGBHNDH(Entity EBOGCLNNJGN, Quaternion NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x22F90D0", Offset = "0x22F7AD0", VA = "0x1822F90D0", Slot = "8")]
		public Quaternion AACOEFFAMJH(Entity EBOGCLNNJGN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x22FCE60", Offset = "0x22FB860", VA = "0x1822FCE60", Slot = "12")]
		public void KDNBOADBOJJ(Entity EBOGCLNNJGN, Vector3 NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x22FCA60", Offset = "0x22FB460", VA = "0x1822FCA60", Slot = "11")]
		public Vector3 JGNDIGOIAOP(Entity EBOGCLNNJGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x22FC320", Offset = "0x22FAD20", VA = "0x1822FC320")]
		public void JBFFHIOIKLB(Entity EBOGCLNNJGN, Vector3 NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x22FDC30", Offset = "0x22FC630", VA = "0x1822FDC30")]
		private Vector3 OGEFJHJIDOG(Entity EBOGCLNNJGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x22FD8E0", Offset = "0x22FC2E0", VA = "0x1822FD8E0", Slot = "14")]
		public float MIANKDENJOM(Entity EBOGCLNNJGN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x22FA3F0", Offset = "0x22F8DF0", VA = "0x1822FA3F0", Slot = "13")]
		public void CONJPEFFFLG(Entity EBOGCLNNJGN, float NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x22FB160", Offset = "0x22F9B60", VA = "0x1822FB160")]
		private float FAPEIEHLANG(Entity EBOGCLNNJGN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x22FDB90", Offset = "0x22FC590", VA = "0x1822FDB90")]
		public void NDFEOFKJLPH(Entity EBOGCLNNJGN, float JFHCBBBBFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x22FCD80", Offset = "0x22FB780", VA = "0x1822FCD80", Slot = "16")]
		public Vector3 KBALJEDBLCN(Entity EBOGCLNNJGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x22F9860", Offset = "0x22F8260", VA = "0x1822F9860", Slot = "15")]
		public void BBKFLLIMBAO(Entity EBOGCLNNJGN, Vector3 AGJFKHJPGFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x22FCF60", Offset = "0x22FB960", VA = "0x1822FCF60")]
		private Vector3 KJCIJPIMGAD(Entity EBOGCLNNJGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x22FE000", Offset = "0x22FCA00", VA = "0x1822FE000")]
		public void PPENGDMMEJA(Entity EBOGCLNNJGN, Vector3 NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x22FB720", Offset = "0x22FA120", VA = "0x1822FB720")]
		[Conditional("DEBUG_BUILD")]
		private void HEMHLEEEOOL(Entity EBOGCLNNJGN, Vector3 NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x22FACB0", Offset = "0x22F96B0", VA = "0x1822FACB0", Slot = "36")]
		public void EBDGLHJAGJK(Entity EBOGCLNNJGN, Vector3 NHDHEIIIBBI, Quaternion IOCIEOJKCCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x22F9F00", Offset = "0x22F8900", VA = "0x1822F9F00", Slot = "9")]
		public void CEIKHJLBMEI(Entity EBOGCLNNJGN, out Vector3 NHDHEIIIBBI, out Quaternion IOCIEOJKCCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x22FB030", Offset = "0x22F9A30", VA = "0x1822FB030", Slot = "10")]
		public void EHKCFMCLCJE(Entity EBOGCLNNJGN, out Vector3 NHDHEIIIBBI, out Quaternion IOCIEOJKCCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x22FAE10", Offset = "0x22F9810", VA = "0x1822FAE10", Slot = "37")]
		public void EGCEIAOJJFL(Entity EBOGCLNNJGN, Vector3 NHDHEIIIBBI, Quaternion IOCIEOJKCCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x22FB8D0", Offset = "0x22FA2D0", VA = "0x1822FB8D0")]
		public void HGNDNANKKML(Entity EBOGCLNNJGN, Vector3 NHDHEIIIBBI, Quaternion IOCIEOJKCCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x22FA500", Offset = "0x22F8F00", VA = "0x1822FA500", Slot = "17")]
		public void DAPLKDGPBCJ(Entity EBOGCLNNJGN, Vector3 NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x22FDDE0", Offset = "0x22FC7E0", VA = "0x1822FDDE0", Slot = "18")]
		public Vector3 PCFFIKGKNEJ(Entity EBOGCLNNJGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x22FC0E0", Offset = "0x22FAAE0", VA = "0x1822FC0E0", Slot = "19")]
		public void IOGJCPPDHPF(Entity EBOGCLNNJGN, Quaternion NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x22FBF10", Offset = "0x22FA910", VA = "0x1822FBF10", Slot = "20")]
		public Quaternion IDFPIPGKMBC(Entity EBOGCLNNJGN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x22F93F0", Offset = "0x22F7DF0", VA = "0x1822F93F0", Slot = "22")]
		public void ANFBPILGIAB(Entity EBOGCLNNJGN, Vector3 NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x22FCC90", Offset = "0x22FB690", VA = "0x1822FCC90", Slot = "21")]
		public Vector3 JLKBKEKKFCM(Entity EBOGCLNNJGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x22FA980", Offset = "0x22F9380", VA = "0x1822FA980", Slot = "23")]
		public void DJOHGIJCJHA(Entity EBOGCLNNJGN, float PAKDOLHLCIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x22F92D0", Offset = "0x22F7CD0", VA = "0x1822F92D0", Slot = "24")]
		public float AJANKGFICKI(Entity EBOGCLNNJGN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x22F9990", Offset = "0x22F8390", VA = "0x1822F9990", Slot = "25")]
		public void BLMNENOGPHN(Entity EBOGCLNNJGN, Vector3 NMGBIEHMPEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x22FA730", Offset = "0x22F9130", VA = "0x1822FA730", Slot = "26")]
		public Vector3 DCGHNOEKHHE(Entity EBOGCLNNJGN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x22FC3C0", Offset = "0x22FADC0", VA = "0x1822FC3C0", Slot = "31")]
		public void JCHHFLKDACC(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x22FDA40", Offset = "0x22FC440", VA = "0x1822FDA40")]
		private CAMBCDMDDIB MLAEAAAMMGA(Transform MLMJNFGMBPE)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x22FD470", Offset = "0x22FBE70", VA = "0x1822FD470")]
		private static TransformEntity LFGELKMHJDJ(MIJMGOMOBGM NFMPIOLJBMO, GameObject HDDFHLGDPFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x22FCB70", Offset = "0x22FB570", VA = "0x1822FCB70", Slot = "32")]
		public void JJOKNDDOICH(Entity EBOGCLNNJGN, Entity NKGEBLNPFNO, Entity CLJJCFEFLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x22F9E80", Offset = "0x22F8880", VA = "0x1822F9E80")]
		private IFABKFJKIFE CEIKHJLBMEI(Entity EBOGCLNNJGN)
		{
			return default(IFABKFJKIFE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x22FC000", Offset = "0x22FAA00", VA = "0x1822FC000")]
		private bool IMNAHLPKPIA(Entity EBOGCLNNJGN, out Entity EGNCPOLPGCD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x22FB570", Offset = "0x22F9F70", VA = "0x1822FB570")]
		private void GOCCCKBCJCN(Entity EBOGCLNNJGN, out Matrix4x4 MABFHCIMHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x22FA050", Offset = "0x22F8A50", VA = "0x1822FA050")]
		private void CONEOFLHJGM(Entity EBOGCLNNJGN, out Matrix4x4 GJKPLLPBJDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x22FDC20", Offset = "0x22FC620", VA = "0x1822FDC20", Slot = "28")]
		private void OBEBNGLGMPB(Entity EBOGCLNNJGN, in Matrix4x4 AKDPEMHOGAK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DNKFJNHNNCA(typeof(KCKMLLHHKCB), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
internal sealed class KCKMLLHHKCB : CFMOGGHLNDM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[MJIDFIFGMKP]
	private PNLHBOHNCFH MGOGCFMPFGO;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x218A220", Offset = "0x2188C20", VA = "0x18218A220", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x218A2F0", Offset = "0x2188CF0", VA = "0x18218A2F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public KCKMLLHHKCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
[DNKFJNHNNCA(typeof(LHFBFEMJMOK), new string[] { })]
public class LHFBFEMJMOK
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct IEKKOMPCNMM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly LHFBFEMJMOK EGNCPOLPGCD;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x38A9C80", Offset = "0x38A8680", VA = "0x1838A9C80")]
		public IEKKOMPCNMM(LHFBFEMJMOK EGNCPOLPGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x38A9C60", Offset = "0x38A8660", VA = "0x1838A9C60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int IDGJOCPLMBN;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool IDGOMHFEGNI
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8A1150", Offset = "0x89FB50", VA = "0x1808A1150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action APLEMGGFLEC
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2191540", Offset = "0x218FF40", VA = "0x182191540")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x21915E0", Offset = "0x218FFE0", VA = "0x1821915E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x21916A0", Offset = "0x21900A0", VA = "0x1821916A0")]
	public IEKKOMPCNMM NMIINFDEKKD()
	{
		return default(IEKKOMPCNMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x10957F0", Offset = "0x10941F0", VA = "0x1810957F0")]
	public void IGPGCNOMFAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2191680", Offset = "0x2190080", VA = "0x182191680")]
	public void LGGDOOOMJAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHFBFEMJMOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DNKFJNHNNCA(typeof(KIFFMJJMCOB), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
public class KIFFMJJMCOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private int IDGJOCPLMBN;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool KKNNLAGAGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x761070", Offset = "0x75FA70", VA = "0x180761070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xCA99E0", Offset = "0xCA83E0", VA = "0x180CA99E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public KIFFMJJMCOB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DNKFJNHNNCA(typeof(EnableComponentSystemsInScope), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.ComponentSystemTypes)]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	public class EnableComponentSystemsInScope : CFMOGGHLNDM, FOACFLABAOO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct MAOMDPJOEMN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<int> HMEDKCEODGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<int> BBEAMCNAAON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private Dictionary<ComponentSystemBase, int> IPBIMOEGHHE;

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x22ECB10", Offset = "0x22EB510", VA = "0x1822ECB10")]
			public MAOMDPJOEMN(NativeArray<int> HMEDKCEODGG, NativeArray<int> BBEAMCNAAON, Dictionary<ComponentSystemBase, int> IPBIMOEGHHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x22EC890", Offset = "0x22EB290", VA = "0x1822EC890")]
			public void BCIFDDDKNON(IEnumerable<ComponentSystemBase> ALJPPMMDDBF, AHJKMAKLGJA BALJPKGLIIK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class JMHDAPKBIEJ : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x877FD0", Offset = "0x8769D0", VA = "0x180877FD0")]
			[DebuggerHidden]
			public JMHDAPKBIEJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x22EBCC0", Offset = "0x22EA6C0", VA = "0x1822EBCC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x22EBE90", Offset = "0x22EA890", VA = "0x1822EBE90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x22EBDE0", Offset = "0x22EA7E0", VA = "0x1822EBDE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x22EBDE0", Offset = "0x22EA7E0", VA = "0x1822EBDE0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public const AHJKMAKLGJA HCDKNCGCEFB = AHJKMAKLGJA.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly LOOGELFKPLM HKAOFAFHOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI FBFHHMCDIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private World MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private DOMLOFPDLMI KDGPDENJJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private NativeArray<int> FIEBECFAKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private NativeArray<int> BKAGFNOEKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int FDLOHCDDBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private AHJKMAKLGJA EDBKJMLIFKB;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x24C7210", Offset = "0x24C5C10", VA = "0x1824C7210", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x24C7320", Offset = "0x24C5D20", VA = "0x1824C7320", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x24C7290", Offset = "0x24C5C90", VA = "0x1824C7290")]
		[IteratorStateMachine(typeof(JMHDAPKBIEJ))]
		private IEnumerable<ComponentSystemBase> DKAEBFJEEGB(int NJEPHEABALF, int AFPKKIJINFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x24C7CB0", Offset = "0x24C66B0", VA = "0x1824C7CB0", Slot = "5")]
		public void MMCJIMCKEID(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x24C81E0", Offset = "0x24C6BE0", VA = "0x1824C81E0")]
		private void PEMMIFGIFLH(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x24C80E0", Offset = "0x24C6AE0", VA = "0x1824C80E0")]
		public void PEMMIFGIFLH(AHJKMAKLGJA HNMMFFBIMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x24C7D20", Offset = "0x24C6720", VA = "0x1824C7D20")]
		private void NNMCKADALAP(AHJKMAKLGJA HNMMFFBIMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x24C7180", Offset = "0x24C5B80", VA = "0x1824C7180")]
		private void AKMJDOLOFDB(AHJKMAKLGJA HNMMFFBIMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x24C7A80", Offset = "0x24C6480", VA = "0x1824C7A80")]
		private void GLHOGDGHJIJ(AHJKMAKLGJA HNMMFFBIMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x24C7940", Offset = "0x24C6340", VA = "0x1824C7940")]
		private void EFAIIPHILOI(int NJEPHEABALF, int AFPKKIJINFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x24C7AE0", Offset = "0x24C64E0", VA = "0x1824C7AE0")]
		private void JECPDEECNGL(int NJEPHEABALF, int AFPKKIJINFE, bool GCNBMKKLBLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x24C7A60", Offset = "0x24C6460", VA = "0x1824C7A60")]
		private int FHIMACHAPNE(AHJKMAKLGJA HNMMFFBIMDL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x24C73B0", Offset = "0x24C5DB0", VA = "0x1824C73B0")]
		private bool ECJONLBGDKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x24C7FF0", Offset = "0x24C69F0", VA = "0x1824C7FF0")]
		private Dictionary<ComponentSystemBase, int> OMAKOAPBFNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x24C7FB0", Offset = "0x24C69B0", VA = "0x1824C7FB0")]
		private void NPEMKJOKIDF(NativeArray<int> HMEDKCEODGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x24C7C00", Offset = "0x24C6600", VA = "0x1824C7C00")]
		private void KLCCPHDMNCC(NativeArray<int> BBEAMCNAAON, NativeArray<int> HMEDKCEODGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x24C7BA0", Offset = "0x24C65A0", VA = "0x1824C7BA0")]
		private static AHJKMAKLGJA JKBONDFKGLJ(Type NFMPIOLJBMO, AHJKMAKLGJA DJFOKMFDJPD)
		{
			return default(AHJKMAKLGJA);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x24C83C0", Offset = "0x24C6DC0", VA = "0x1824C83C0")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x24C7A00", Offset = "0x24C6400", VA = "0x1824C7A00")]
		[CompilerGenerated]
		private void FGDGFJNHNPG(CFMOGGHLNDM DCNAFFGNFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x24C7CC0", Offset = "0x24C66C0", VA = "0x1824C7CC0")]
		[CompilerGenerated]
		private void NBBENHGHBAI(BGKGLCNGELH DCNAFFGNFBF)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[OJEJDFBPPED(FHFOPEOFOPD.WorldService)]
	[DNKFJNHNNCA(typeof(HIGEHOPBKAJ), new string[] { })]
	public class TickService : CFMOGGHLNDM, HIGEHOPBKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static readonly ProfilerMarker GPFJMEBIPCL;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly ProfilerMarker MMFBGCDLOLJ;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly ProfilerMarker DFMBDCIGHKP;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly ProfilerMarker LDBIDCBHJNJ;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly ProfilerMarker LNPPNNBPBPA;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly ProfilerMarker JFIMKMOJCKO;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly ProfilerMarker PAOLCCFNILO;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly ProfilerMarker KBMFONLNOKD;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly ProfilerMarker OMIHDJBAMNC;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly ProfilerMarker HJOECGHDGMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI FBFHHMCDIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[MJIDFIFGMKP]
		private JIMAKGEINEB AKMKADIDNNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[MJIDFIFGMKP]
		private OEDCBLNEDEI OCHLGAEKIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[MJIDFIFGMKP]
		private TransformOwnershipPhase FIBKLLCCEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[MJIDFIFGMKP]
		private TimeService MNKJIFJCNIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private OLNILFAFOLN MKBCEHAIJKD;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private bool FAIMENIEBAL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x22F7300", Offset = "0x22F5D00", VA = "0x1822F7300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private bool DFLMBEOIBPI
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x22F7F60", Offset = "0x22F6960", VA = "0x1822F7F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool KPLAMILKAKP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x22F7300", Offset = "0x22F5D00", VA = "0x1822F7300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool BGPCAEKINOP
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x22F7300", Offset = "0x22F5D00", VA = "0x1822F7300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x22F7560", Offset = "0x22F5F60", VA = "0x1822F7560", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x22F8250", Offset = "0x22F6C50", VA = "0x1822F8250", Slot = "14")]
		public void OPKLHFMDCDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x22F7440", Offset = "0x22F5E40", VA = "0x1822F7440", Slot = "15")]
		public void CMCBAFDANGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x22F7370", Offset = "0x22F5D70", VA = "0x1822F7370", Slot = "5")]
		public void CAIAIFHMOPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x22F80D0", Offset = "0x22F6AD0", VA = "0x1822F80D0", Slot = "6")]
		public void NJIIJMCDNMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x22F8370", Offset = "0x22F6D70", VA = "0x1822F8370", Slot = "7")]
		public void PLDGIIMCNPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x22F7820", Offset = "0x22F6220", VA = "0x1822F7820", Slot = "8")]
		public void EEDOADPIMKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x22F7DE0", Offset = "0x22F67E0", VA = "0x1822F7DE0", Slot = "9")]
		public void GKIAEBLBHPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x22F79A0", Offset = "0x22F63A0", VA = "0x1822F79A0", Slot = "10")]
		public void GJJKOLPGHID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x22F8000", Offset = "0x22F6A00", VA = "0x1822F8000", Slot = "11")]
		public void KIPBFHBLHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "13")]
		public void IFDLLIIIKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x22F76D0", Offset = "0x22F60D0", VA = "0x1822F76D0", Slot = "12")]
		public void DJIGPICEELF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[OJEJDFBPPED(FHFOPEOFOPD.WorldService)]
	[DNKFJNHNNCA(typeof(CAOOBKKGEDI), new string[] { })]
	public class WorldService : CAOOBKKGEDI, IDisposable, AHDDAOHEFAN
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private OLNILFAFOLN MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool HHKBONGDECE;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public OLNILFAFOLN DLPKPCDMEGK
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public AMGOMELBDKB JMGIMDJFKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x217C2D0", Offset = "0x217ACD0", VA = "0x18217C2D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public EntityManager AJHOIKIBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x2306E20", Offset = "0x2305820", VA = "0x182306E20", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool MMGCNOGJJID
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x7F5D60", Offset = "0x7F4760", VA = "0x1807F5D60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2306E40", Offset = "0x2305840", VA = "0x182306E40", Slot = "10")]
		public void LMBJCLDJBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2306AC0", Offset = "0x23054C0", VA = "0x182306AC0")]
		private void BJHKCBAGIGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2306BD0", Offset = "0x23055D0", VA = "0x182306BD0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2306E00", Offset = "0x2305800", VA = "0x182306E00", Slot = "8")]
		public ComponentSystemBase HBGDKJEMHCP(Type NFMPIOLJBMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DNKFJNHNNCA(typeof(FJPDOHJFMNH), new string[] { })]
public sealed class LHGHEJMODNN : FJPDOHJFMNH, OKCOAIBIMKN, AHDDAOHEFAN, CFMOGGHLNDM, BGKGLCNGELH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class KAGNMKKHJHI : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x909700", Offset = "0x908100", VA = "0x180909700", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x38AB850", Offset = "0x38AA250", VA = "0x1838AB850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC340", Offset = "0x1EBAD40", VA = "0x181EBC340")]
		[DebuggerHidden]
		public KAGNMKKHJHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x38AB540", Offset = "0x38A9F40", VA = "0x1838AB540", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x38AB810", Offset = "0x38AA210", VA = "0x1838AB810", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x38AB770", Offset = "0x38AA170", VA = "0x1838AB770", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x38AB770", Offset = "0x38AA170", VA = "0x1838AB770", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[MJIDFIFGMKP]
	private AJHEAAFBPJF CDGNAONMFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly FDHMHIPEABO ABMJNLDCPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly Dictionary<string, KKEOMGECIIA> LJDJICJLCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<int, GANBGJGAJLD> ONMKBNDOAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<FNEDFINGEKN> PKCMAFDHAID;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public GANBGJGAJLD EFANLMDENBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2191BA0", Offset = "0x21905A0", VA = "0x182191BA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<FNEDFINGEKN> BEBPLIDNIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "7")]
	public void LMBJCLDJBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2191AB0", Offset = "0x21904B0", VA = "0x182191AB0", Slot = "8")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2192430", Offset = "0x2190E30", VA = "0x182192430", Slot = "9")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2191B10", Offset = "0x2190510", VA = "0x182191B10", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2192310", Offset = "0x2190D10", VA = "0x182192310", Slot = "6")]
	public bool MBDOOFOOJEN(FNEDFINGEKN GNIPEANGOCM, out GANBGJGAJLD HLJJLMFOIKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2191C50", Offset = "0x2190650", VA = "0x182191C50")]
	private void JLDMCMGEKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x21916D0", Offset = "0x21900D0", VA = "0x1821916D0")]
	private void BHCOINLFAKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2192530", Offset = "0x2190F30", VA = "0x182192530")]
	private KKEOMGECIIA NFFBBLOIFAF(string IHDIOJGBJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2191BA0", Offset = "0x21905A0", VA = "0x182191BA0")]
	private KKEOMGECIIA IOICIANLBFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2191FE0", Offset = "0x21909E0", VA = "0x182191FE0")]
	private KKEOMGECIIA LIMFDOFDKEK(string IHDIOJGBJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x21918E0", Offset = "0x21902E0", VA = "0x1821918E0")]
	private KKEOMGECIIA DBLPPDFGEPB(string EDPDIONNDAP, string KBCPLDFOJJL, [Optional] KKEOMGECIIA FDKJBKOOOJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x21922A0", Offset = "0x2190CA0", VA = "0x1821922A0")]
	[IteratorStateMachine(typeof(KAGNMKKHJHI))]
	private IEnumerable<(string, string)> MAEMLJJAPGI(string IHDIOJGBJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2191C00", Offset = "0x2190600", VA = "0x182191C00")]
	private bool JHEJNCMPPPA(FNEDFINGEKN GNIPEANGOCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2192450", Offset = "0x2190E50", VA = "0x182192450")]
	private FDHMHIPEABO MNELGNBIJPH(FNEDFINGEKN GNIPEANGOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2192250", Offset = "0x2190C50", VA = "0x182192250")]
	private FDHMHIPEABO LPOJEKEJPFO(FNEDFINGEKN GNIPEANGOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x21923A0", Offset = "0x2190DA0", VA = "0x1821923A0")]
	private FDHMHIPEABO MJPBOGKHKEJ(FNEDFINGEKN GNIPEANGOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x25F0970", Offset = "0x25EF370", VA = "0x1825F0970")]
	private T BKCPPDEHFCE<T>(FNEDFINGEKN GNIPEANGOCM) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2191870", Offset = "0x2190270", VA = "0x182191870")]
	private FieldInfo CGCIJLAOCMM(FNEDFINGEKN GNIPEANGOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2192620", Offset = "0x2191020", VA = "0x182192620")]
	public LHGHEJMODNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2192590", Offset = "0x2190F90", VA = "0x182192590")]
	[CompilerGenerated]
	private int NJMEOKDPLKD(FNEDFINGEKN LDIEPFCHCFG, FNEDFINGEKN KCHCODPDAGF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class KKEOMGECIIA : GANBGJGAJLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly string POCNPGGEBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly KKEOMGECIIA FDKJBKOOOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly List<KKEOMGECIIA> FNAGFINGFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly List<FNEDFINGEKN> CDGNAONMFHE;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public string ODMNEGFLGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public GANBGJGAJLD AGGOPNCEELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<GANBGJGAJLD> ICGCJAKDFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IEnumerable<FNEDFINGEKN> IBHNLBOOKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x218C700", Offset = "0x218B100", VA = "0x18218C700")]
	public KKEOMGECIIA(string KKJOOAJGLJI, KKEOMGECIIA EGNCPOLPGCD)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[OJEJDFBPPED(FHFOPEOFOPD.History)]
	[DNKFJNHNNCA(typeof(JEGFBKEGILA), new string[] { })]
	[GPEKNNAMFFM(typeof(HistoryService))]
	public class HistoryService : CFMOGGHLNDM, IDisposable, JEGFBKEGILA
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private enum ICPJEGPFEOL
		{
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private readonly struct KLGFEPANFBB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly ICPJEGPFEOL BDJHCNBBAGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly HistoryService NGMBPANACIN;

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x38AC4D0", Offset = "0x38AAED0", VA = "0x1838AC4D0")]
			public KLGFEPANFBB(HistoryService NGMBPANACIN, bool KOBBCOMEJKN, uint FDLOHCDDBIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x38AC4A0", Offset = "0x38AAEA0", VA = "0x1838AC4A0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public class NBOFBAANDHN
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct POOLIDGIEFG : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				private readonly NBOFBAANDHN DOFNLMHADCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private readonly bool GCCIHKCPKPE;

				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0x38AE3F0", Offset = "0x38ACDF0", VA = "0x1838AE3F0")]
				public POOLIDGIEFG(NBOFBAANDHN DOFNLMHADCL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x38A66F0", Offset = "0x38A50F0", VA = "0x1838A66F0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct GFBDNPEOFMA : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private readonly NBOFBAANDHN DOFNLMHADCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				private readonly bool GCCIHKCPKPE;

				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x38A6720", Offset = "0x38A5120", VA = "0x1838A6720")]
				public GFBDNPEOFMA(NBOFBAANDHN DOFNLMHADCL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0x38A66F0", Offset = "0x38A50F0", VA = "0x1838A66F0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private readonly HistoryService AHEEFLPCFNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool CGJBGAHPEGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private int ONPEMCNDBGK;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x38AD000", Offset = "0x38ABA00", VA = "0x1838AD000")]
			public NBOFBAANDHN(HistoryService AHEEFLPCFNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x38ACF30", Offset = "0x38AB930", VA = "0x1838ACF30")]
			public bool CGMHCEOCJBH(DPCBAIHHPOK MMCCMEFGKOD, ACIALDGCHGB EDNCKFCJECD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x38ACFB0", Offset = "0x38AB9B0", VA = "0x1838ACFB0")]
			public GFBDNPEOFMA JMDAAJALMAL()
			{
				return default(GFBDNPEOFMA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x38ACF60", Offset = "0x38AB960", VA = "0x1838ACF60")]
			public POOLIDGIEFG GGBJJHBBOME()
			{
				return default(POOLIDGIEFG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class EFOGNLAOGII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public EFOGNLAOGII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x38A4740", Offset = "0x38A3140", VA = "0x1838A4740")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class MGDIOMJCHIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public MGDIOMJCHIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x38ACB80", Offset = "0x38AB580", VA = "0x1838ACB80")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class MKOKCOFNKLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public MKOKCOFNKLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x38ACC60", Offset = "0x38AB660", VA = "0x1838ACC60")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly UndoAction JEOKOGBAKFJ;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly RedoAction MAJLMDNIEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private OBHMFLJMALM HCDIPOEFIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private ActionBuffer ECAADHMHGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private ActionBuffer LOIBFGOILCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private PGHFKCCKPED CNBICCEIDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TransformOwnershipPhase FIBKLLCCEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private PropertyChangeRouterService HDMFKLOEFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private HJBDBCBHBPP MPDCGEEDOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private ICPJEGPFEOL DBMHEEOPDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private NBOFBAANDHN DOFNLMHADCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool HHKBONGDECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private PDOBMNIPJPM MHEJMLFEFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private OBGMOBEFLNM OIOOCGEHHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private ACIALDGCHGB NKFJOHDPOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly GatherPropertiesForUndelete JBIKCGDJCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private uint AJCANNFOHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private uint HGHNHDAADKC;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private NBOFBAANDHN LODPBNIFGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x751840", Offset = "0x750240", VA = "0x180751840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool HNECMHCKBJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x21844A0", Offset = "0x2182EA0", VA = "0x1821844A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool GNKHFKLLEJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x2184010", Offset = "0x2182A10", VA = "0x182184010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool EJHFPCNELNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2184270", Offset = "0x2182C70", VA = "0x182184270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int MFBEAPEFCOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x2184E10", Offset = "0x2183810", VA = "0x182184E10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int EKEBMGMLEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x2183D60", Offset = "0x2182760", VA = "0x182183D60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool IKHGMNLPLJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x21832E0", Offset = "0x2181CE0", VA = "0x1821832E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private bool IHBIKAHPGFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x2184F70", Offset = "0x2183970", VA = "0x182184F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool BGNNMHKBGNH
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x80E360", Offset = "0x80CD60", VA = "0x18080E360", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x80D6E0", Offset = "0x80C0E0", VA = "0x18080D6E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private ActionBuffer BKDNNJCDDPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2183D80", Offset = "0x2182780", VA = "0x182183D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action MMILHFDDIBM
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x2185160", Offset = "0x2183B60", VA = "0x182185160", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x2184870", Offset = "0x2183270", VA = "0x182184870", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action PNAKJGMCIPI
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x2184D70", Offset = "0x2183770", VA = "0x182184D70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x2183240", Offset = "0x2181C40", VA = "0x182183240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x21834D0", Offset = "0x2181ED0", VA = "0x1821834D0", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x21839F0", Offset = "0x21823F0", VA = "0x1821839F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2184C90", Offset = "0x2183690", VA = "0x182184C90")]
		private void MEIEJGINOEG(DPCBAIHHPOK MMCCMEFGKOD, KNBEGDBJHKK JCJOFJPKNME, bool ANNAOEEHANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x21846C0", Offset = "0x21830C0", VA = "0x1821846C0")]
		private void KFDMPCKFIII(DPCBAIHHPOK MMCCMEFGKOD, ACIALDGCHGB EDNCKFCJECD, DCNFIHFHOLK PIKEGMHKKGM, DCNFIHFHOLK MIIOPMDNGOD, bool ANNAOEEHANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x21842A0", Offset = "0x2182CA0", VA = "0x1821842A0")]
		private void JGKFDIKCPAL(DPCBAIHHPOK MMCCMEFGKOD, bool ANNAOEEHANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2184510", Offset = "0x2182F10", VA = "0x182184510", Slot = "14")]
		public IDisposable KCAJJMGCKIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2184810", Offset = "0x2183210", VA = "0x182184810", Slot = "9")]
		public IDisposable LEEELHMBNDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2183DD0", Offset = "0x21827D0", VA = "0x182183DD0", Slot = "6")]
		public UndoAction GFELGMFIJME()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x21850A0", Offset = "0x2183AA0", VA = "0x1821850A0", Slot = "15")]
		public RedoAction ONDPAFAAPAI()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x21832F0", Offset = "0x2181CF0", VA = "0x1821832F0", Slot = "16")]
		public UndoAction CBJCKJCGDID()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2184F80", Offset = "0x2183980", VA = "0x182184F80", Slot = "7")]
		public RedoAction ONDPAFAAPAI(UndoAction HGJMJLMOCJK)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x21833B0", Offset = "0x2181DB0", VA = "0x1821833B0", Slot = "8")]
		public UndoAction CBJCKJCGDID(RedoAction HGJMJLMOCJK)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x21839B0", Offset = "0x21823B0", VA = "0x1821839B0")]
		public bool DOOCKEJEMCF(JNGCOILNCJH DGMJCBDNPNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x21846E0", Offset = "0x21830E0", VA = "0x1821846E0", Slot = "17")]
		public void LCFMPIKHEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2184BD0", Offset = "0x21835D0", VA = "0x182184BD0")]
		public void MDCILGHIJEK(DPCBAIHHPOK MMCCMEFGKOD, KNBEGDBJHKK JCJOFJPKNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2184730", Offset = "0x2183130", VA = "0x182184730")]
		public void LCPMKELCMAA(DPCBAIHHPOK MMCCMEFGKOD, ACIALDGCHGB EDNCKFCJECD, in DCNFIHFHOLK MIIOPMDNGOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2183CB0", Offset = "0x21826B0", VA = "0x182183CB0")]
		public void FEKMLJKHEGB(DPCBAIHHPOK MMCCMEFGKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x2184F30", Offset = "0x2183930", VA = "0x182184F30")]
		private void NMEMKLPPBJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2183D90", Offset = "0x2182790", VA = "0x182183D90")]
		private void GCHJJIAAEOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2184EB0", Offset = "0x21838B0", VA = "0x182184EB0")]
		private void MKFDBAKCONG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2185200", Offset = "0x2183C00", VA = "0x182185200")]
		private IHDDLBGFKED PCFLDGCJNFI()
		{
			return default(IHDDLBGFKED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2183C90", Offset = "0x2182690", VA = "0x182183C90")]
		private uint EKCINKOFADD()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2184480", Offset = "0x2182E80", VA = "0x182184480")]
		private bool JJCKFAAKHKE(out IHDDLBGFKED LBPAPOGAAHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2184D50", Offset = "0x2183750", VA = "0x182184D50")]
		private bool MGHBLEJFLGL(out IHDDLBGFKED LBPAPOGAAHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x2184ED0", Offset = "0x21838D0", VA = "0x182184ED0")]
		private RedoAction NIKCLANMDAM(IHDDLBGFKED LBPAPOGAAHD)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x21840B0", Offset = "0x2182AB0", VA = "0x1821840B0")]
		private UndoAction HIDBPOLJGEK(IHDDLBGFKED LBPAPOGAAHD)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2184910", Offset = "0x2183310", VA = "0x182184910")]
		private IHDDLBGFKED LOKCALNAENJ(IHDDLBGFKED LBPAPOGAAHD, ActionBuffer HOMOIAFFDCH, bool KOBBCOMEJKN)
		{
			return default(IHDDLBGFKED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2183160", Offset = "0x2181B60", VA = "0x182183160")]
		private void AGAEJMKOCNL(Action LBPAPOGAAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x1D62620", Offset = "0x1D61020", VA = "0x181D62620")]
		private T AGAEJMKOCNL<T>(Func<T> IMPJBNCDEDG)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2183980", Offset = "0x2182380", VA = "0x182183980")]
		private KLGFEPANFBB DLGBOONPOLL(bool KOBBCOMEJKN, uint FDLOHCDDBIM)
		{
			return default(KLGFEPANFBB);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x21853E0", Offset = "0x2183DE0", VA = "0x1821853E0")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x2184570", Offset = "0x2182F70", VA = "0x182184570")]
		[CompilerGenerated]
		private UndoAction KDJAIAGMKGL()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2183E90", Offset = "0x2182890", VA = "0x182183E90")]
		[CompilerGenerated]
		private RedoAction GHCIHPANPEG()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2184110", Offset = "0x2182B10", VA = "0x182184110")]
		[CompilerGenerated]
		private UndoAction IAMKBDJHDAB()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class EHHKPFADMJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NativeArray<byte> EIOACKOCJCB;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int PAKKNJKLENP
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x748B70", Offset = "0x747570", VA = "0x180748B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x1862490", Offset = "0x1860E90", VA = "0x181862490")]
	public EHHKPFADMJK(NativeArray<byte> EIOACKOCJCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x24C3650", Offset = "0x24C2050", VA = "0x1824C3650")]
	public static EHHKPFADMJK MFJMDPBHOLK(NativeArray<byte> EIOACKOCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	public T MBFPEMLHKMD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	public NativeArray<T> KIPHMLMCMLP<T>(int LOHIKBMAMJE, Allocator FAMNMGKAFPB) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	public NativeArray<T> HFJDLEFDLMG<T>(Allocator FAMNMGKAFPB) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class DGJFNPCJBEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private NativeArray<byte> EIOACKOCJCB;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public int PAKKNJKLENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x748B70", Offset = "0x747570", VA = "0x180748B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x1862490", Offset = "0x1860E90", VA = "0x181862490")]
	public DGJFNPCJBEB(NativeArray<byte> EIOACKOCJCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x24BFBA0", Offset = "0x24BE5A0", VA = "0x1824BFBA0")]
	public static DGJFNPCJBEB MFJMDPBHOLK(NativeArray<byte> EIOACKOCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x2861BA0", Offset = "0x28605A0", VA = "0x182861BA0")]
	public T MBFPEMLHKMD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	public NativeArray<T> KIPHMLMCMLP<T>(int LOHIKBMAMJE, Allocator FAMNMGKAFPB) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class OBMIJEGDCDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private NativeArray<byte> EIOACKOCJCB;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int PAKKNJKLENP
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x748B70", Offset = "0x747570", VA = "0x180748B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x1862490", Offset = "0x1860E90", VA = "0x181862490")]
	public OBMIJEGDCDE(NativeArray<byte> EIOACKOCJCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x22CE590", Offset = "0x22CCF90", VA = "0x1822CE590")]
	public static OBMIJEGDCDE MFJMDPBHOLK(NativeArray<byte> EIOACKOCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x2210FE0", Offset = "0x220F9E0", VA = "0x182210FE0")]
	public void PDJLBEDLEEP<T>(in T NKJMIDIDBOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x2210EE0", Offset = "0x220F8E0", VA = "0x182210EE0")]
	public void AKOFBBEMNIL<T>(NativeArray<T> DNHJJJCEBEN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	public void FEKLBGHPGFJ<T>(NativeArray<T> NKJMIDIDBOE) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JGEFONIDCAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x2186FE0", Offset = "0x21859E0", VA = "0x182186FE0")]
	public static Span<byte> DBMCDGGLOKG(this NativeArray<byte> EIOACKOCJCB)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x2187170", Offset = "0x2185B70", VA = "0x182187170")]
	public static ReadOnlySpan<byte> MGLHOHIHCDP(this NativeArray<byte> EIOACKOCJCB)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x21870F0", Offset = "0x2185AF0", VA = "0x1821870F0")]
	public static NativeArray<byte> JDHGNJILFDN(this NativeArray<byte> EIOACKOCJCB, int NJEPHEABALF)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x2187070", Offset = "0x2185A70", VA = "0x182187070")]
	public static NativeArray<byte> FONCKAIMIOO(this NativeArray<byte> EIOACKOCJCB, int OOJKDAEFAHE = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x1766590", Offset = "0x1764F90", VA = "0x181766590")]
	public static NativeArray<byte> FONCKAIMIOO<T>(this NativeArray<byte> EIOACKOCJCB, int OOJKDAEFAHE = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x2186F70", Offset = "0x2185970", VA = "0x182186F70")]
	public static NativeArray<byte> CMNJLLECCNE(this NativeArray<byte> EIOACKOCJCB, int OOJKDAEFAHE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x1766530", Offset = "0x1764F30", VA = "0x181766530")]
	public static NativeArray<byte> CMNJLLECCNE<T>(this NativeArray<byte> EIOACKOCJCB, int OOJKDAEFAHE = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x21872F0", Offset = "0x2185CF0", VA = "0x1821872F0")]
	public static NativeArray<byte> NHPBOKMANGN(this NativeArray<byte> EIOACKOCJCB, int OOJKDAEFAHE = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x17665F0", Offset = "0x1764FF0", VA = "0x1817665F0")]
	public static NativeArray<byte> NHPBOKMANGN<T>(this NativeArray<byte> EIOACKOCJCB, int OOJKDAEFAHE = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GKLPJCMDNBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private NativeList<byte> AMMGMIDPNEP;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x1862490", Offset = "0x1860E90", VA = "0x181862490")]
	public GKLPJCMDNBN(NativeList<byte> AMMGMIDPNEP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x217F000", Offset = "0x217DA00", VA = "0x18217F000")]
	public static GKLPJCMDNBN MFJMDPBHOLK(NativeList<byte> EIOACKOCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public void PDJLBEDLEEP<T>(in T NKJMIDIDBOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public void AKOFBBEMNIL<T>(NativeArray<T> NKJMIDIDBOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public void FEKLBGHPGFJ<T>(NativeArray<T> NKJMIDIDBOE) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	[DNKFJNHNNCA(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.PropertyChanges)]
	public class PropertyChangeNetworkRouter : AHDDAOHEFAN, CFMOGGHLNDM, FDHLGFOCCIN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[MJIDFIFGMKP]
		private BFPLPKGOBOB HENKIMNGBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[MJIDFIFGMKP]
		private AMNDMACHLPL CDGNAONMFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[MJIDFIFGMKP]
		private LHFBFEMJMOK FHKJJNEDNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[MJIDFIFGMKP]
		private PropertyChangeRouterService HDMFKLOEFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private OBHMFLJMALM LOILLHLIIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private KDHKKIICGDC NNLEDFHIFGD;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public OBHMFLJMALM KMFNMIAHPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x22E49B0", Offset = "0x22E33B0", VA = "0x1822E49B0")]
		public OBHMFLJMALM.GIMKJJNKGIJ NMIINFDEKKD()
		{
			return default(OBHMFLJMALM.GIMKJJNKGIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x22E48C0", Offset = "0x22E32C0", VA = "0x1822E48C0", Slot = "4")]
		public void LMBJCLDJBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x22E3C90", Offset = "0x22E2690", VA = "0x1822E3C90", Slot = "5")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x22E3F10", Offset = "0x22E2910", VA = "0x1822E3F10", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x22E4130", Offset = "0x22E2B30", VA = "0x1822E4130")]
		public void GFELGMFIJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x22E4870", Offset = "0x22E3270", VA = "0x1822E4870")]
		public void LCFMPIKHEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x22E3B80", Offset = "0x22E2580", VA = "0x1822E3B80")]
		private void CIPHGGBPIIC(DPCBAIHHPOK MMCCMEFGKOD, KNBEGDBJHKK JCJOFJPKNME, bool ANNAOEEHANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x22E42E0", Offset = "0x22E2CE0", VA = "0x1822E42E0")]
		private void GLANDMMFNOD(DPCBAIHHPOK MMCCMEFGKOD, ACIALDGCHGB EDNCKFCJECD, DCNFIHFHOLK PIKEGMHKKGM, DCNFIHFHOLK MIIOPMDNGOD, bool ANNAOEEHANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x22E4390", Offset = "0x22E2D90", VA = "0x1822E4390")]
		private void HHMDFKEHGBI(DPCBAIHHPOK MMCCMEFGKOD, bool ANNAOEEHANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x22E4570", Offset = "0x22E2F70", VA = "0x1822E4570")]
		private void KLJBHNNOBGL(KDHKKIICGDC JAKENEGIGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x22E49F0", Offset = "0x22E33F0", VA = "0x1822E49F0")]
		private void NOFLNFIGCDO(KDHKKIICGDC JAKENEGIGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x22E44B0", Offset = "0x22E2EB0", VA = "0x1822E44B0")]
		private void INCBFJKAPCP(KDHKKIICGDC JAKENEGIGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x22E4490", Offset = "0x22E2E90", VA = "0x1822E4490")]
		private void IGPGCNOMFAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x22E48A0", Offset = "0x22E32A0", VA = "0x1822E48A0")]
		private void LGGDOOOMJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x22E4240", Offset = "0x22E2C40", VA = "0x1822E4240")]
		private void GKMOIGAFGGB(KDHKKIICGDC JAKENEGIGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x4D39390", Offset = "0x4D37D90", VA = "0x184D39390", Slot = "6")]
		private void HPOGIFPEKAD<TKey, T>(global::MNOFBDJHDKK<TKey, T> GNIPEANGOCM, object ABFHDOGCMDC) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[OJEJDFBPPED(FHFOPEOFOPD.History)]
	[DNKFJNHNNCA(typeof(PropertyChangeRouterService), new string[] { })]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public delegate void BGGAANLNCCC(DPCBAIHHPOK MMCCMEFGKOD, KNBEGDBJHKK JCJOFJPKNME, bool ANNAOEEHANH);

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public delegate void HFIDACPIGPC(DPCBAIHHPOK MMCCMEFGKOD, ACIALDGCHGB EDNCKFCJECD, DCNFIHFHOLK PIKEGMHKKGM, DCNFIHFHOLK MIIOPMDNGOD, bool ANNAOEEHANH);

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void NLNPAGKLAJG(DPCBAIHHPOK MMCCMEFGKOD, bool ANNAOEEHANH);

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public BGGAANLNCCC BJHKCBAGIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public HFIDACPIGPC HJHMCGJGBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public NLNPAGKLAJG LGJCJPODOEB;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x22E4C20", Offset = "0x22E3620", VA = "0x1822E4C20")]
		public void MDCILGHIJEK(DPCBAIHHPOK MMCCMEFGKOD, KNBEGDBJHKK JCJOFJPKNME, bool ANNAOEEHANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x22E4BB0", Offset = "0x22E35B0", VA = "0x1822E4BB0")]
		public void LCPMKELCMAA(DPCBAIHHPOK MMCCMEFGKOD, ACIALDGCHGB EDNCKFCJECD, in DCNFIHFHOLK PIKEGMHKKGM, in DCNFIHFHOLK MIIOPMDNGOD, bool ANNAOEEHANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x22E4B90", Offset = "0x22E3590", VA = "0x1822E4B90")]
		public void FEKMLJKHEGB(DPCBAIHHPOK MMCCMEFGKOD, bool ANNAOEEHANH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[DebuggerTypeProxy(typeof(IBEEKAPCDLP))]
	[OJEJDFBPPED(FHFOPEOFOPD.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		internal class IBEEKAPCDLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly ActionBuffer MFPFCCDPGDI;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public int OABDNEKKKBL
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0x22EB5E0", Offset = "0x22E9FE0", VA = "0x1822EB5E0")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public EGFLFFPBCIC[] EJGJBDKKGKA
			{
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x22EB630", Offset = "0x22EA030", VA = "0x1822EB630")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x6B6EE0", Offset = "0x6B58E0", VA = "0x1806B6EE0")]
			public IBEEKAPCDLP(ActionBuffer POJDLJCCJOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x22EB700", Offset = "0x22EA100", VA = "0x1822EB700")]
			[CompilerGenerated]
			private EGFLFFPBCIC GNHABOENLOE(IHDDLBGFKED LBPAPOGAAHD)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		internal class EGFLFFPBCIC : FDHLGFOCCIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly ActionBuffer MFPFCCDPGDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly IHDDLBGFKED LBPAPOGAAHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private List<(KDHKKIICGDC, string, object)> HNIDBFHKANK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private DGJFNPCJBEB LDHEAKJHCED;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public int OABDNEKKKBL
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0x22EAA90", Offset = "0x22E9490", VA = "0x1822EAA90")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public List<(KDHKKIICGDC, string, object)> IDJCEBKAPNJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x22EAF20", Offset = "0x22E9920", VA = "0x1822EAF20")]
			public EGFLFFPBCIC(ActionBuffer POJDLJCCJOH, IHDDLBGFKED LBPAPOGAAHD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x22EAAE0", Offset = "0x22E94E0", VA = "0x1822EAAE0")]
			private string CKGMOMNGAHE(KDHKKIICGDC NNLEDFHIFGD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x22EABE0", Offset = "0x22E95E0", VA = "0x1822EABE0")]
			private void LCHEDBCCHIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x1F26E20", Offset = "0x1F25820", VA = "0x181F26E20", Slot = "4")]
			public void ENHJEHPFHBO<TKey, T>(global::MNOFBDJHDKK<TKey, T> GNIPEANGOCM, [Optional] object ABFHDOGCMDC) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private NativeList<byte> LOABHCNKNPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Stack<IHDDLBGFKED> FPLIOGCIBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly GCCACBDOGGC NHLFHLEJJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly PDOBMNIPJPM MHEJMLFEFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly AMNDMACHLPL CDGNAONMFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly bool IJOOIMGCDHE;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public GIEGBLHCBGB OLJIKHALPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x24AC370", Offset = "0x24AAD70", VA = "0x1824AC370")]
			get
			{
				return default(GIEGBLHCBGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public int OABDNEKKKBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x24ABC80", Offset = "0x24AA680", VA = "0x1824ABC80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x24AC830", Offset = "0x24AB230", VA = "0x1824AC830")]
		public ActionBuffer(PDOBMNIPJPM MHEJMLFEFPN, AMNDMACHLPL CDGNAONMFHE, bool IJOOIMGCDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x24ABCC0", Offset = "0x24AA6C0", VA = "0x1824ABCC0")]
		public bool DEOBPMEFCEB(out IHDDLBGFKED LBPAPOGAAHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x24AC070", Offset = "0x24AAA70", VA = "0x1824AC070")]
		public void LCFMPIKHEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x24ABDC0", Offset = "0x24AA7C0", VA = "0x1824ABDC0")]
		public IHDDLBGFKED GFELGMFIJME(LJILAMBFGLF HNIDBFHKANK, HJBDBCBHBPP MPDCGEEDOHD, uint FMPBPNGGOFM)
		{
			return default(IHDDLBGFKED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x24AC040", Offset = "0x24AAA40", VA = "0x1824AC040")]
		public bool KCKLCHDHFOB(uint FMPBPNGGOFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x24AC3B0", Offset = "0x24AADB0", VA = "0x1824AC3B0")]
		public bool PLHPGGDICKM(uint FMPBPNGGOFM, out IHDDLBGFKED HGJMJLMOCJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x24ABB10", Offset = "0x24AA510", VA = "0x1824ABB10")]
		public void AEKFGGIJEGI(IHDDLBGFKED HGJMJLMOCJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x24AC230", Offset = "0x24AAC30", VA = "0x1824AC230")]
		[Conditional("DEBUG_BUILD")]
		private void LPLGPOKBOPH(IHDDLBGFKED HGJMJLMOCJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x24AC0E0", Offset = "0x24AAAE0", VA = "0x1824AC0E0")]
		private void LOKCALNAENJ(IHDDLBGFKED DPFHIFJMMOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x24AC5A0", Offset = "0x24AAFA0", VA = "0x1824AC5A0")]
		private void PLNFENFGCEF(DGJFNPCJBEB ICLBJCBPKNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x24ABF00", Offset = "0x24AA900", VA = "0x1824ABF00")]
		private void HBIECCELMIM(IHDDLBGFKED LBPAPOGAAHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x24ABF60", Offset = "0x24AA960", VA = "0x1824ABF60")]
		private DGJFNPCJBEB IEJAKDCKAHL(IHDDLBGFKED LBPAPOGAAHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x24ABD50", Offset = "0x24AA750", VA = "0x1824ABD50", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class GCCACBDOGGC : FDHLGFOCCIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly PDOBMNIPJPM MHEJMLFEFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly AMNDMACHLPL CDGNAONMFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private DPCBAIHHPOK MMCCMEFGKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private DGJFNPCJBEB AEFIJLFPGLP;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x75DFF0", Offset = "0x75C9F0", VA = "0x18075DFF0")]
	public GCCACBDOGGC(PDOBMNIPJPM MHEJMLFEFPN, AMNDMACHLPL CDGNAONMFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x1DB1E80", Offset = "0x1DB0880", VA = "0x181DB1E80", Slot = "4")]
	public void ENHJEHPFHBO<TKey, T>(global::MNOFBDJHDKK<TKey, T> LAAFNGFALNH, [Optional] object ABFHDOGCMDC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x217CD30", Offset = "0x217B730", VA = "0x18217CD30")]
	public void KILJMGBLKDF(KDHKKIICGDC NNLEDFHIFGD, ref DGJFNPCJBEB ICLBJCBPKNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class OBHMFLJMALM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct GIMKJJNKGIJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly OBHMFLJMALM EGNCPOLPGCD;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x38A6890", Offset = "0x38A5290", VA = "0x1838A6890")]
		public GIMKJJNKGIJ(OBHMFLJMALM EGNCPOLPGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x38A6870", Offset = "0x38A5270", VA = "0x1838A6870", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected LJILAMBFGLF HNIDBFHKANK;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public LJILAMBFGLF IDJCEBKAPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x22CE0C0", Offset = "0x22CCAC0", VA = "0x1822CE0C0")]
		get
		{
			return default(LJILAMBFGLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool BIAIDKBPMGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x22CE4C0", Offset = "0x22CCEC0", VA = "0x1822CE4C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x22CE4D0", Offset = "0x22CCED0", VA = "0x1822CE4D0")]
	public OBHMFLJMALM(LJILAMBFGLF.JLPOKJAKILF IMKDDCOMFCL = LJILAMBFGLF.JLPOKJAKILF.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x22CE200", Offset = "0x22CCC00", VA = "0x1822CE200")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x22CE3A0", Offset = "0x22CCDA0", VA = "0x1822CE3A0")]
	public void MDCILGHIJEK(DPCBAIHHPOK MMCCMEFGKOD, KNBEGDBJHKK JCJOFJPKNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x22CE210", Offset = "0x22CCC10", VA = "0x1822CE210")]
	public void LCPMKELCMAA(DPCBAIHHPOK MMCCMEFGKOD, ACIALDGCHGB EDNCKFCJECD, in DCNFIHFHOLK MIIOPMDNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x22CDFE0", Offset = "0x22CC9E0", VA = "0x1822CDFE0")]
	public void FEKMLJKHEGB(DPCBAIHHPOK MMCCMEFGKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x22CE100", Offset = "0x22CCB00", VA = "0x1822CE100")]
	public void IGPGCNOMFAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x22CE2A0", Offset = "0x22CCCA0", VA = "0x1822CE2A0")]
	public void LGGDOOOMJAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x22CDFD0", Offset = "0x22CC9D0", VA = "0x1822CDFD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x22CE490", Offset = "0x22CCE90", VA = "0x1822CE490")]
	public GIMKJJNKGIJ NMIINFDEKKD()
	{
		return default(GIMKJJNKGIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct KDHKKIICGDC : IComparable<KDHKKIICGDC>, IEquatable<KDHKKIICGDC>
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static readonly KDHKKIICGDC CIDEMGIPOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public DPCBAIHHPOK MMCCMEFGKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public ACIALDGCHGB EDNCKFCJECD;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool CHKFJDOKALL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x218A360", Offset = "0x2188D60", VA = "0x18218A360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x8012C0", Offset = "0x7FFCC0", VA = "0x1808012C0")]
	public KDHKKIICGDC(DPCBAIHHPOK MMCCMEFGKOD, ACIALDGCHGB EDNCKFCJECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x218A400", Offset = "0x2188E00", VA = "0x18218A400")]
	public void EBKNNPLDAHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x218A370", Offset = "0x2188D70", VA = "0x18218A370", Slot = "4")]
	public int CompareTo(KDHKKIICGDC BPKBHFMGOOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x218A580", Offset = "0x2188F80", VA = "0x18218A580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x218A460", Offset = "0x2188E60", VA = "0x18218A460", Slot = "0")]
	public override bool Equals(object PDHKCBEBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x218A410", Offset = "0x2188E10", VA = "0x18218A410", Slot = "5")]
	public bool Equals(KDHKKIICGDC BPKBHFMGOOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x218A540", Offset = "0x2188F40", VA = "0x18218A540")]
	public static bool MOBCKBANPBO(KDHKKIICGDC KCFHGHIJEEN, KDHKKIICGDC EIBGAMBEABJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x218A3B0", Offset = "0x2188DB0", VA = "0x18218A3B0")]
	public static bool DEKNKNJGCDK(KDHKKIICGDC KCFHGHIJEEN, KDHKKIICGDC EIBGAMBEABJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x218A500", Offset = "0x2188F00", VA = "0x18218A500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[OJEJDFBPPED(FHFOPEOFOPD.History)]
	public class GatherPropertiesForUndelete : OBAMLFKPDHI
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private PDOBMNIPJPM MHEJMLFEFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private DPCBAIHHPOK MMCCMEFGKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private HistoryService AHEEFLPCFNG;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x217F060", Offset = "0x217DA60", VA = "0x18217F060")]
		public void EHLOPMMLLCB(DPCBAIHHPOK MMCCMEFGKOD, PDOBMNIPJPM MHEJMLFEFPN, HistoryService AHEEFLPCFNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x217F170", Offset = "0x217DB70", VA = "0x18217F170", Slot = "4")]
		private void JGEEKBADPBF(POBFPAENEBP GNIPEANGOCM, in DCNFIHFHOLK NKJMIDIDBOE, object ABFHDOGCMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class NBFBOBHBMNC
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x22CA830", Offset = "0x22C9230", VA = "0x1822CA830")]
	public static void NOFLNFIGCDO(LJILAMBFGLF HNIDBFHKANK, KDHKKIICGDC NNLEDFHIFGD, KNBEGDBJHKK JCJOFJPKNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x22CA770", Offset = "0x22C9170", VA = "0x1822CA770")]
	public static void MDPKLDCJLCO(LJILAMBFGLF HNIDBFHKANK, KDHKKIICGDC NNLEDFHIFGD, in DCNFIHFHOLK MIIOPMDNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x22CA5D0", Offset = "0x22C8FD0", VA = "0x1822CA5D0")]
	public static void INCBFJKAPCP(LJILAMBFGLF HNIDBFHKANK, KDHKKIICGDC NNLEDFHIFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x22CA620", Offset = "0x22C9020", VA = "0x1822CA620")]
	public static void JBMDKEHKIDA(LJILAMBFGLF HNIDBFHKANK, KDHKKIICGDC NNLEDFHIFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x22CA720", Offset = "0x22C9120", VA = "0x1822CA720")]
	public static KNBEGDBJHKK LAMAMHHLKAH(LJILAMBFGLF HNIDBFHKANK, KDHKKIICGDC NNLEDFHIFGD)
	{
		return default(KNBEGDBJHKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x3143220", Offset = "0x3141C20", VA = "0x183143220")]
	public static T FBOKMLKOAGH<T>(LJILAMBFGLF HNIDBFHKANK, KDHKKIICGDC NNLEDFHIFGD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x31431F0", Offset = "0x3141BF0", VA = "0x1831431F0")]
	public static T FBOKMLKOAGH<T>(ref DGJFNPCJBEB PJIINDGLAPJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x22CA6D0", Offset = "0x22C90D0", VA = "0x1822CA6D0")]
	public static KNBEGDBJHKK LAMAMHHLKAH(ref DGJFNPCJBEB PJIINDGLAPJ)
	{
		return default(KNBEGDBJHKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct LJILAMBFGLF : IEnumerable<KDHKKIICGDC>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum JLPOKJAKILF
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct GPNDHEBINKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly LJILAMBFGLF AMMGMIDPNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly HJBDBCBHBPP MPDCGEEDOHD;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x38A72F0", Offset = "0x38A5CF0", VA = "0x1838A72F0")]
		public GPNDHEBINKL(LJILAMBFGLF AMMGMIDPNEP, HJBDBCBHBPP MPDCGEEDOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x38A6BC0", Offset = "0x38A55C0", VA = "0x1838A6BC0")]
		public void FPIJENICPAO(NativeList<byte> PLHINEOBEDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x38A72A0", Offset = "0x38A5CA0", VA = "0x1838A72A0")]
		private void OLCKLHDHOHN(KDHKKIICGDC NNLEDFHIFGD, ref OBMIJEGDCDE LPKLIGNCJIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x38A6E60", Offset = "0x38A5860", VA = "0x1838A6E60")]
		private void KCFGHLLLFMH(KDHKKIICGDC NNLEDFHIFGD, ref OBMIJEGDCDE LPKLIGNCJIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x38A69E0", Offset = "0x38A53E0", VA = "0x1838A69E0")]
		private NativeArray<byte> EFFNCJHOIPK(NativeList<byte> PLHINEOBEDC)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x38A6AD0", Offset = "0x38A54D0", VA = "0x1838A6AD0")]
		private NativeArray<byte> FCACMEOINAJ(NativeList<byte> PLHINEOBEDC, int LOHIKBMAMJE)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x38A6EF0", Offset = "0x38A58F0", VA = "0x1838A6EF0")]
		private int NOOFOIAKPBG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x38A7140", Offset = "0x38A5B40", VA = "0x1838A7140")]
		private bool OCANBAAAIGA(KDHKKIICGDC NNLEDFHIFGD, out NativeArray<byte> CKMFLHEANEJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct LDLPBDNEKDC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NativeList<byte> PJIINDGLAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private LJILAMBFGLF AMMGMIDPNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly KDHKKIICGDC JAKENEGIGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly int NJEPHEABALF;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x38AC800", Offset = "0x38AB200", VA = "0x1838AC800")]
		internal LDLPBDNEKDC(LJILAMBFGLF AMMGMIDPNEP, KDHKKIICGDC JAKENEGIGGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x38AC580", Offset = "0x38AAF80", VA = "0x1838AC580", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x38AC5B0", Offset = "0x38AAFB0", VA = "0x1838AC5B0")]
		public void GDMHPBFEMPC(NativeArray<byte> NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x38AC7A0", Offset = "0x38AB1A0", VA = "0x1838AC7A0")]
		public void OKAHPHOEEFE(NativeArray<byte> NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x38AC610", Offset = "0x38AB010", VA = "0x1838AC610")]
		public void KCFGHLLLFMH(in DCNFIHFHOLK NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1F3B150", Offset = "0x1F39B50", VA = "0x181F3B150")]
		public void KCFGHLLLFMH<T>(T NKJMIDIDBOE) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x38AC680", Offset = "0x38AB080", VA = "0x1838AC680")]
		private void LGAHOAKDJIK(int NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x38AC6F0", Offset = "0x38AB0F0", VA = "0x1838AC6F0")]
		private void LGAHOAKDJIK(in DCNFIHFHOLK NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x38AC620", Offset = "0x38AB020", VA = "0x1838AC620")]
		private unsafe void LGAHOAKDJIK(void* DFJPMCDDNCL, int LOHIKBMAMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x38AC5B0", Offset = "0x38AAFB0", VA = "0x1838AC5B0")]
		private void LGAHOAKDJIK(NativeArray<byte> DNHJJJCEBEN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct PALGCHFDNIK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private LJILAMBFGLF AMMGMIDPNEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NativeArray<byte> PJIINDGLAPJ;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x38ADD50", Offset = "0x38AC750", VA = "0x1838ADD50")]
		internal PALGCHFDNIK(LJILAMBFGLF AMMGMIDPNEP, NativeArray<byte> PJIINDGLAPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x38ADA90", Offset = "0x38AC490", VA = "0x1838ADA90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x38ADB90", Offset = "0x38AC590", VA = "0x1838ADB90")]
		public NativeArray<byte> KIPHMLMCMLP(int LOHIKBMAMJE)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x38ADAA0", Offset = "0x38AC4A0", VA = "0x1838ADAA0")]
		public NativeArray<byte> HFJDLEFDLMG()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CE20", Offset = "0x1F4B820", VA = "0x181F4CE20")]
		public T MBFPEMLHKMD<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x38ADC50", Offset = "0x38AC650", VA = "0x1838ADC50")]
		public void MBFPEMLHKMD(in FPKEMMGAFGA NKJMIDIDBOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct HLOLCGAFJEN : IEnumerator<KDHKKIICGDC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly NativeList<KDHKKIICGDC> EIOACKOCJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private int NENMOOINMCH;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public KDHKKIICGDC OLJIKHALPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x38A9840", Offset = "0x38A8240", VA = "0x1838A9840", Slot = "4")]
			get
			{
				return default(KDHKKIICGDC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x38A9800", Offset = "0x38A8200", VA = "0x1838A9800", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x27865A0", Offset = "0x2784FA0", VA = "0x1827865A0")]
		internal HLOLCGAFJEN(NativeList<KDHKKIICGDC> DNHJJJCEBEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x38A96C0", Offset = "0x38A80C0", VA = "0x1838A96C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x38A97C0", Offset = "0x38A81C0", VA = "0x1838A97C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct KGOBJAIJBGJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private const int ODBMEOEOIBM = 0;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private const int FDGLHBOEOOL = 1;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private const int OKMODHJHBIG = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private NativeArray<int> PJIINDGLAPJ;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool CIADPHNANDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x38AC290", Offset = "0x38AAC90", VA = "0x1838AC290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public int PICPALJBDNP
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x38AC360", Offset = "0x38AAD60", VA = "0x1838AC360")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x38AC380", Offset = "0x38AAD80", VA = "0x1838AC380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public JLPOKJAKILF OPBJPDGHKOH
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x38AC410", Offset = "0x38AAE10", VA = "0x1838AC410")]
			get
			{
				return default(JLPOKJAKILF);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x38AC3F0", Offset = "0x38AADF0", VA = "0x1838AC3F0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool BIAIDKBPMGC
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x38AC400", Offset = "0x38AAE00", VA = "0x1838AC400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x38AC3D0", Offset = "0x38AADD0", VA = "0x1838AC3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool OCBNLDLLJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x38AC370", Offset = "0x38AAD70", VA = "0x1838AC370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x38AC340", Offset = "0x38AAD40", VA = "0x1838AC340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x38AC420", Offset = "0x38AAE20", VA = "0x1838AC420")]
		public KGOBJAIJBGJ(JLPOKJAKILF IMKDDCOMFCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x38AC2D0", Offset = "0x38AACD0", VA = "0x1838AC2D0")]
		private int DNANCALJAPO(int DDIAPGBIJDD, int MHJKELDBPDE = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x38AC390", Offset = "0x38AAD90", VA = "0x1838AC390")]
		private void LMCGMFHIJLB(int DDIAPGBIJDD, int NKJMIDIDBOE, int MHJKELDBPDE = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x38AC300", Offset = "0x38AAD00", VA = "0x1838AC300", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private const int FPIMHAHFAEK = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private const int AGNHNAOMHPP = 0;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly KDHKKIICGDC BCOOLJNEOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private NativeHashMap<KDHKKIICGDC, int> MEPDPLOMMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private NativeList<KDHKKIICGDC> HNIDBFHKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private NativeList<int> BKAGFNOEKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private NativeList<byte> MIMJBBMILFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private NativeList<byte> PJIINDGLAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private KGOBJAIJBGJ INOCFKIFMHI;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool BIAIDKBPMGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2193C90", Offset = "0x2192690", VA = "0x182193C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool NKKOEEPHCGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2193710", Offset = "0x2192110", VA = "0x182193710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int PICPALJBDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2193670", Offset = "0x2192070", VA = "0x182193670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int DEKLDKIDBHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2193C50", Offset = "0x2192650", VA = "0x182193C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool CIADPHNANDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x21933D0", Offset = "0x2191DD0", VA = "0x1821933D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2193390", Offset = "0x2191D90", VA = "0x182193390")]
	public static LJILAMBFGLF BJHKCBAGIGH(JLPOKJAKILF IMKDDCOMFCL = JLPOKJAKILF.Last, int KGECJHLAONF = 16, int IIADLEJLJMJ = 256)
	{
		return default(LJILAMBFGLF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2193DA0", Offset = "0x21927A0", VA = "0x182193DA0")]
	private LJILAMBFGLF(JLPOKJAKILF IMKDDCOMFCL, int KGECJHLAONF, int IIADLEJLJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x21934A0", Offset = "0x2191EA0", VA = "0x1821934A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2193730", Offset = "0x2192130", VA = "0x182193730")]
	public LDLPBDNEKDC KLJBHNNOBGL(KDHKKIICGDC JAKENEGIGGH)
	{
		return default(LDLPBDNEKDC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2193410", Offset = "0x2191E10", VA = "0x182193410")]
	public PALGCHFDNIK CJLHGKABJDC(KDHKKIICGDC JAKENEGIGGH)
	{
		return default(PALGCHFDNIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x21938A0", Offset = "0x21922A0", VA = "0x1821938A0")]
	public bool LEBMDMJCCED(KDHKKIICGDC JAKENEGIGGH, out PALGCHFDNIK FDFJIIOLLDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2193680", Offset = "0x2192080", VA = "0x182193680")]
	public bool HJKEIDFBJOE(KDHKKIICGDC JAKENEGIGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2193B80", Offset = "0x2192580", VA = "0x182193B80")]
	public bool NNCCKEHLLJJ(KDHKKIICGDC JAKENEGIGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x21932A0", Offset = "0x2191CA0", VA = "0x1821932A0")]
	public void AIGJOOIDHNP(NativeList<byte> PLHINEOBEDC, HJBDBCBHBPP MPDCGEEDOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x25F0A80", Offset = "0x25EF480", VA = "0x1825F0A80")]
	public T OBNJJMDABHD<T>(KDHKKIICGDC JAKENEGIGGH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x21937C0", Offset = "0x21921C0", VA = "0x1821937C0")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x21936D0", Offset = "0x21920D0", VA = "0x1821936D0")]
	public HLOLCGAFJEN ICBJEBDOHAE()
	{
		return default(HLOLCGAFJEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x21930B0", Offset = "0x2191AB0", VA = "0x1821930B0")]
	private void ABCFBJGOJBD(KDHKKIICGDC JAKENEGIGGH, int NJEPHEABALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2193580", Offset = "0x2191F80", VA = "0x182193580")]
	private void EBKNNPLDAHL(int GBEGILCKBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2193A90", Offset = "0x2192490", VA = "0x182193A90")]
	private void LGOCGLGJGCF(KDHKKIICGDC JAKENEGIGGH, int NJEPHEABALF, int LOHIKBMAMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x25F0A00", Offset = "0x25EF400", VA = "0x1825F0A00")]
	private static T OBNJJMDABHD<T>(NativeArray<byte> EIOACKOCJCB, int DDIAPGBIJDD = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2193CE0", Offset = "0x21926E0", VA = "0x182193CE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2193CA0", Offset = "0x21926A0", VA = "0x182193CA0", Slot = "4")]
	private IEnumerator<KDHKKIICGDC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Preserve]
internal sealed class NAFKOMAEEDP<T> : BHPPPHCOIMM where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private EntityQuery NBKDJEEFFOH;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x1E76CB0", Offset = "0x1E756B0", VA = "0x181E76CB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x1E76DD0", Offset = "0x1E757D0", VA = "0x181E76DD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x1E76E40", Offset = "0x1E75840", VA = "0x181E76E40")]
	public NAFKOMAEEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x1E76C90", Offset = "0x1E75690", VA = "0x181E76C90", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	internal class CleanupRigidbodyExImpl : BHPPPHCOIMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private EntityQuery NBKDJEEFFOH;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x24B5CF0", Offset = "0x24B46F0", VA = "0x1824B5CF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x24B5D90", Offset = "0x24B4790", VA = "0x1824B5D90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Preserve]
internal class CGHGLNGEJOO : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private EntityQuery LDGPPCJAOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x24B1E50", Offset = "0x24B0850", VA = "0x1824B1E50", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x24B1EA0", Offset = "0x24B08A0", VA = "0x1824B1EA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x24B1F30", Offset = "0x24B0930", VA = "0x1824B1F30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public CGHGLNGEJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
internal class ADFIMPCIGNA : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private PropertyDiffStateService GPEMOODJCBA;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x24AB370", Offset = "0x24A9D70", VA = "0x1824AB370", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x24AB3C0", Offset = "0x24A9DC0", VA = "0x1824AB3C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public ADFIMPCIGNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private EntityQuery NBKDJEEFFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private SceneService HLDGGAOHOMB;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x24C19B0", Offset = "0x24C03B0", VA = "0x1824C19B0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x24C1A00", Offset = "0x24C0400", VA = "0x1824C1A00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x24C1A90", Offset = "0x24C0490", VA = "0x1824C1A90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[DNKFJNHNNCA(typeof(CullingBandService), new string[] { })]
	[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	public class CullingBandService : CFMOGGHLNDM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly List<global::OIEIIGDBLKE<KNIHJHENELP>> AFKHMNNLACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI FBFHHMCDIGN;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x24BEC50", Offset = "0x24BD650", VA = "0x1824BEC50", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x24BF280", Offset = "0x24BDC80", VA = "0x1824BF280")]
		public void NHGEOBEFJAG(global::OIEIIGDBLKE<KNIHJHENELP> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x24BEE10", Offset = "0x24BD810", VA = "0x1824BEE10")]
		public void IINOOJFMKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x24BECA0", Offset = "0x24BD6A0", VA = "0x1824BECA0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x24BF340", Offset = "0x24BDD40", VA = "0x1824BF340")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	[DNKFJNHNNCA(typeof(PHBPFOPBBAM), new string[] { })]
	public class PhysicsService : CFMOGGHLNDM, BGKGLCNGELH, PHBPFOPBBAM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly LOOGELFKPLM KJGJEGDEFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private EntityManager KACBFFMHDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private CAOOBKKGEDI MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private GPAPCFEMAGG OBEPGIPAMAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private PropertyEventCallbacksService APCBMNHLIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private global::MCHJKBDIPIH<FDGBKKGPILE> KAKNFAIABMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool HHKBONGDECE;

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<CAMBCDMDDIB, FDGBKKGPILE> IFCBAPMBPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x22E1160", Offset = "0x22DFB60", VA = "0x1822E1160", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x22E1500", Offset = "0x22DFF00", VA = "0x1822E1500", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x22E0FB0", Offset = "0x22DF9B0", VA = "0x1822E0FB0", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x22E1390", Offset = "0x22DFD90", VA = "0x1822E1390", Slot = "5")]
		public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x22E10D0", Offset = "0x22DFAD0", VA = "0x1822E10D0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x22E12C0", Offset = "0x22DFCC0", VA = "0x1822E12C0", Slot = "8")]
		public bool JJAEBOCFBII(CAMBCDMDDIB BCJDDLNACAB, out Collider JJEECJHLDGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x22E1200", Offset = "0x22DFC00", VA = "0x1822E1200")]
		private void JIPMGDBDKOG(Entity EBOGCLNNJGN, ACIALDGCHGB EDNCKFCJECD, DCNFIHFHOLK GKKEBOJKIEH, DCNFIHFHOLK KMKKONJJIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x22E15A0", Offset = "0x22DFFA0", VA = "0x1822E15A0", Slot = "9")]
		public void PBGFIIPLLJA(CAMBCDMDDIB BCJDDLNACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[DNKFJNHNNCA(typeof(NJHICLMHLEK), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	public class RbexService : CFMOGGHLNDM, NJHICLMHLEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private CAOOBKKGEDI FBFHHMCDIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private World MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private JGJBJPMJJOJ DNLBCCOKJFC;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private EntityManager AJHOIKIBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x22E9240", Offset = "0x22E7C40", VA = "0x1822E9240")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x22E7350", Offset = "0x22E5D50", VA = "0x1822E7350", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x22E9880", Offset = "0x22E8280", VA = "0x1822E9880", Slot = "6")]
		public GNFFCDBPNKD NPCNHBELAII(CAMBCDMDDIB BCJDDLNACAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x22E7D90", Offset = "0x22E6790", VA = "0x1822E7D90", Slot = "5")]
		public void FDDHCPMINOB(CAMBCDMDDIB BCJDDLNACAB, GNFFCDBPNKD NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x22E9090", Offset = "0x22E7A90", VA = "0x1822E9090", Slot = "34")]
		public CollisionDetectionMode KNBBDPHOBDL(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x22E9CD0", Offset = "0x22E86D0", VA = "0x1822E9CD0", Slot = "35")]
		public void PNEBMIJGBMP(CAMBCDMDDIB BCJDDLNACAB, CollisionDetectionMode NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x22E8CA0", Offset = "0x22E76A0", VA = "0x1822E8CA0", Slot = "36")]
		public AGMKNMDKBEI JPKGNIFGMFI(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(AGMKNMDKBEI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x22E7120", Offset = "0x22E5B20", VA = "0x1822E7120", Slot = "37")]
		public void CPIDIOJGLCM(CAMBCDMDDIB BCJDDLNACAB, AGMKNMDKBEI NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x22E9030", Offset = "0x22E7A30", VA = "0x1822E9030", Slot = "38")]
		public bool KKJLKPOIMJE(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x22E8340", Offset = "0x22E6D40", VA = "0x1822E8340", Slot = "39")]
		public void GLIIKOAFEKG(CAMBCDMDDIB BCJDDLNACAB, bool NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x22E8510", Offset = "0x22E6F10", VA = "0x1822E8510", Slot = "40")]
		public CAMBCDMDDIB HFMIOHHMJCK(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x22E6980", Offset = "0x22E5380", VA = "0x1822E6980", Slot = "41")]
		public void AGHCFACFKHC(CAMBCDMDDIB BCJDDLNACAB, CAMBCDMDDIB NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x22E8910", Offset = "0x22E7310", VA = "0x1822E8910", Slot = "42")]
		public CAMBCDMDDIB INMLOHDEIIC(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x22E9C50", Offset = "0x22E8650", VA = "0x1822E9C50", Slot = "43")]
		public void PKNDJFHBPIO(CAMBCDMDDIB BCJDDLNACAB, CAMBCDMDDIB NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x22E8770", Offset = "0x22E7170", VA = "0x1822E8770", Slot = "7")]
		public void HNICBHANMKL(CAMBCDMDDIB BCJDDLNACAB, CAMBCDMDDIB NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x22E8F20", Offset = "0x22E7920", VA = "0x1822E8F20", Slot = "8")]
		public void KHIBJALADHC(CAMBCDMDDIB BCJDDLNACAB, CAMBCDMDDIB NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x22E6DC0", Offset = "0x22E57C0", VA = "0x1822E6DC0", Slot = "9")]
		public int CJDHHAODJFB(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x22E9260", Offset = "0x22E7C60", VA = "0x1822E9260", Slot = "10")]
		public CAMBCDMDDIB LMHHMBOFGOF(CAMBCDMDDIB BCJDDLNACAB, int NENMOOINMCH)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x22E8A90", Offset = "0x22E7490", VA = "0x1822E8A90", Slot = "11")]
		public void JOOFLNOLPOH(CAMBCDMDDIB BCJDDLNACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x22E7C60", Offset = "0x22E6660", VA = "0x1822E7C60", Slot = "12")]
		public void FAAABBBBDPK(CAMBCDMDDIB BCJDDLNACAB, object KBCPLDFOJJL, CAMBCDMDDIB NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x22E91B0", Offset = "0x22E7BB0", VA = "0x1822E91B0", Slot = "13")]
		public void LLDNFEAPNDE(CAMBCDMDDIB BCJDDLNACAB, object KBCPLDFOJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x22E7AA0", Offset = "0x22E64A0", VA = "0x1822E7AA0", Slot = "14")]
		public bool ENMNPGCEHBE(CAMBCDMDDIB BCJDDLNACAB, out CAMBCDMDDIB NKJMIDIDBOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x22E86F0", Offset = "0x22E70F0", VA = "0x1822E86F0", Slot = "15")]
		public void HNHLPBHCFKD(CAMBCDMDDIB BCJDDLNACAB, float3 NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x22E6B50", Offset = "0x22E5550", VA = "0x1822E6B50", Slot = "16")]
		public bool BIGHAFMGGOK(CAMBCDMDDIB BCJDDLNACAB, out float3 NKJMIDIDBOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x22E9770", Offset = "0x22E8170", VA = "0x1822E9770", Slot = "17")]
		public void NFNDMCFCLGP(CAMBCDMDDIB BCJDDLNACAB, float3 NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x22E8D40", Offset = "0x22E7740", VA = "0x1822E8D40", Slot = "18")]
		public bool KAOICPPHICA(CAMBCDMDDIB BCJDDLNACAB, out float3 NKJMIDIDBOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x22E75C0", Offset = "0x22E5FC0", VA = "0x1822E75C0", Slot = "26")]
		public float3 DKIKOHCNCMG(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x22E9380", Offset = "0x22E7D80", VA = "0x1822E9380", Slot = "27")]
		public void MBBEGHHKNBC(CAMBCDMDDIB BCJDDLNACAB, float3 NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x22E9A50", Offset = "0x22E8450", VA = "0x1822E9A50", Slot = "28")]
		public float OKFPMKMLOBP(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x22E7FD0", Offset = "0x22E69D0", VA = "0x1822E7FD0", Slot = "29")]
		public void FJNHNOMBNNH(CAMBCDMDDIB BCJDDLNACAB, float NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x22E7400", Offset = "0x22E5E00", VA = "0x1822E7400", Slot = "30")]
		public float DKFOCLCIBKJ(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x22E6A00", Offset = "0x22E5400", VA = "0x1822E6A00", Slot = "31")]
		public void AMMMNJGOJAM(CAMBCDMDDIB BCJDDLNACAB, float NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x22E80A0", Offset = "0x22E6AA0", VA = "0x1822E80A0", Slot = "32")]
		public bool FLFBMAJIGBO(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x22E95C0", Offset = "0x22E7FC0", VA = "0x1822E95C0", Slot = "33")]
		public void MMIKCBMNLNA(CAMBCDMDDIB BCJDDLNACAB, bool NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x22E9AB0", Offset = "0x22E84B0", VA = "0x1822E9AB0", Slot = "19")]
		public void OOAKILGGMLL(CAMBCDMDDIB BCJDDLNACAB, float3 NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x22E8590", Offset = "0x22E6F90", VA = "0x1822E8590", Slot = "20")]
		public bool HMJHIBFKFPF(CAMBCDMDDIB BCJDDLNACAB, out float3 NKJMIDIDBOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x22E7ED0", Offset = "0x22E68D0", VA = "0x1822E7ED0", Slot = "21")]
		public void FGIDAPPANCO(CAMBCDMDDIB BCJDDLNACAB, quaternion NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x22E7940", Offset = "0x22E6340", VA = "0x1822E7940", Slot = "22")]
		public bool ENFNFCAJIKF(CAMBCDMDDIB BCJDDLNACAB, out quaternion NKJMIDIDBOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x22E6EB0", Offset = "0x22E58B0", VA = "0x1822E6EB0", Slot = "23")]
		public bool CNDBIPDEIPE(CAMBCDMDDIB BCJDDLNACAB, out float3 HLDBEIJOEKL, out quaternion BLAJLNBBJPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x22E90F0", Offset = "0x22E7AF0", VA = "0x1822E90F0", Slot = "44")]
		public CGACPKIAMLK KPBFIMLFFOB(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(CGACPKIAMLK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x22E8170", Offset = "0x22E6B70", VA = "0x1822E8170", Slot = "45")]
		public void FPBGJPFAHFG(CAMBCDMDDIB BCJDDLNACAB, CGACPKIAMLK NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x22E8880", Offset = "0x22E7280", VA = "0x1822E8880", Slot = "72")]
		public void IAADFBHPDCL(CAMBCDMDDIB BCJDDLNACAB, object KBCPLDFOJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x22E8410", Offset = "0x22E6E10", VA = "0x1822E8410", Slot = "73")]
		public void HBDLFIGGABF(CAMBCDMDDIB BCJDDLNACAB, object KBCPLDFOJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x22E6D40", Offset = "0x22E5740", VA = "0x1822E6D40", Slot = "74")]
		public bool CIBBAPNMIMK(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x22E8C10", Offset = "0x22E7610", VA = "0x1822E8C10", Slot = "81")]
		public void JPIKFOMEDBJ(CAMBCDMDDIB BCJDDLNACAB, object KBCPLDFOJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x22E8250", Offset = "0x22E6C50", VA = "0x1822E8250", Slot = "82")]
		public void GGLPKPDLKAM(CAMBCDMDDIB BCJDDLNACAB, object KBCPLDFOJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x22E68A0", Offset = "0x22E52A0", VA = "0x1822E68A0", Slot = "83")]
		public bool AENNCENDIHI(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x22E7220", Offset = "0x22E5C20", VA = "0x1822E7220", Slot = "84")]
		public IEnumerable<object> DHBKEFCKDAB(CAMBCDMDDIB BCJDDLNACAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x22E7640", Offset = "0x22E6040", VA = "0x1822E7640", Slot = "46")]
		public bool DLEKHMIBICI(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x22E9400", Offset = "0x22E7E00", VA = "0x1822E9400", Slot = "47")]
		public void MFOLIEEDJFF(CAMBCDMDDIB BCJDDLNACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x22E82E0", Offset = "0x22E6CE0", VA = "0x1822E82E0", Slot = "48")]
		public bool GIBDAOMEGFM(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x22E99E0", Offset = "0x22E83E0", VA = "0x1822E99E0", Slot = "49")]
		public void OJIKPLEDAJH(CAMBCDMDDIB BCJDDLNACAB, bool NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x22E9150", Offset = "0x22E7B50", VA = "0x1822E9150", Slot = "50")]
		public bool LLAODAPDHPM(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x22E81E0", Offset = "0x22E6BE0", VA = "0x1822E81E0", Slot = "51")]
		public void GFKFBKBJKBI(CAMBCDMDDIB BCJDDLNACAB, bool NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x22E71C0", Offset = "0x22E5BC0", VA = "0x1822E71C0", Slot = "52")]
		public RigidbodyConstraints DBBELLJNHHD(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x22E9700", Offset = "0x22E8100", VA = "0x1822E9700", Slot = "53")]
		public void NDMMCJACHID(CAMBCDMDDIB BCJDDLNACAB, RigidbodyConstraints NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x22E9630", Offset = "0x22E8030", VA = "0x1822E9630", Slot = "54")]
		public float MOABBPDBPCN(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x22E89C0", Offset = "0x22E73C0", VA = "0x1822E89C0", Slot = "55")]
		public void IOELOIHFMLB(CAMBCDMDDIB BCJDDLNACAB, float NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x22E8040", Offset = "0x22E6A40", VA = "0x1822E8040", Slot = "56")]
		public float FKLFBGOGLGP(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x22E84A0", Offset = "0x22E6EA0", VA = "0x1822E84A0", Slot = "57")]
		public void HDOJKANDOFK(CAMBCDMDDIB BCJDDLNACAB, float NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x22E8A30", Offset = "0x22E7430", VA = "0x1822E8A30", Slot = "58")]
		public bool JMBGIPBPHOP(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x22E7770", Offset = "0x22E6170", VA = "0x1822E7770", Slot = "59")]
		public void EJIPNJIMLAP(CAMBCDMDDIB BCJDDLNACAB, bool NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x22E83B0", Offset = "0x22E6DB0", VA = "0x1822E83B0", Slot = "60")]
		public bool GMHKHEBKBPM(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x22E9690", Offset = "0x22E8090", VA = "0x1822E9690", Slot = "61")]
		public void MPJECGMAKMH(CAMBCDMDDIB BCJDDLNACAB, bool NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x22E6920", Offset = "0x22E5320", VA = "0x1822E6920", Slot = "62")]
		public int AGEBDLFOBNK(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x22E76A0", Offset = "0x22E60A0", VA = "0x1822E76A0", Slot = "63")]
		public void DMKMPEJOEEA(CAMBCDMDDIB BCJDDLNACAB, int NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x22E6CB0", Offset = "0x22E56B0", VA = "0x1822E6CB0", Slot = "64")]
		public Rigidbody BMIHOEJAJKA(CAMBCDMDDIB BCJDDLNACAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x22E77E0", Offset = "0x22E61E0", VA = "0x1822E77E0", Slot = "65")]
		public void EMFBGHFOKIN(CAMBCDMDDIB BCJDDLNACAB, Rigidbody NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x22E7E40", Offset = "0x22E6840", VA = "0x1822E7E40", Slot = "75")]
		public void FDPDCNLHIBI(CAMBCDMDDIB BCJDDLNACAB, object KBCPLDFOJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x22E9B30", Offset = "0x22E8530", VA = "0x1822E9B30", Slot = "76")]
		public void PDKENJNHHCP(CAMBCDMDDIB BCJDDLNACAB, object KBCPLDFOJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x22E6AD0", Offset = "0x22E54D0", VA = "0x1822E6AD0", Slot = "77")]
		public bool BFDFOFGEMAH(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x22E97F0", Offset = "0x22E81F0", VA = "0x1822E97F0", Slot = "66")]
		public object NMOHOBBIFGF(CAMBCDMDDIB BCJDDLNACAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x22E7460", Offset = "0x22E5E60", VA = "0x1822E7460", Slot = "67")]
		public void DKGDBACIPIB(CAMBCDMDDIB BCJDDLNACAB, object NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x22E9BC0", Offset = "0x22E85C0", VA = "0x1822E9BC0", Slot = "68")]
		public object PHCBENJBKOO(CAMBCDMDDIB BCJDDLNACAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x22E9460", Offset = "0x22E7E60", VA = "0x1822E9460", Slot = "69")]
		public void MGHOOJFMJBH(CAMBCDMDDIB BCJDDLNACAB, object NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x22E6A70", Offset = "0x22E5470", VA = "0x1822E6A70", Slot = "70")]
		public float APKOGKAPDNF(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x22E8100", Offset = "0x22E6B00", VA = "0x1822E8100", Slot = "71")]
		public void FMMCNCDCAGG(CAMBCDMDDIB BCJDDLNACAB, float NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x22E7F40", Offset = "0x22E6940", VA = "0x1822E7F40", Slot = "78")]
		public void FHCHCPCLNPH(CAMBCDMDDIB BCJDDLNACAB, object KBCPLDFOJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x22E8B80", Offset = "0x22E7580", VA = "0x1822E8B80", Slot = "79")]
		public void JPBNIPNNIEA(CAMBCDMDDIB BCJDDLNACAB, object KBCPLDFOJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x22E8EA0", Offset = "0x22E78A0", VA = "0x1822E8EA0", Slot = "80")]
		public bool KEOBOBNNGLM(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x22E7C00", Offset = "0x22E6600", VA = "0x1822E7C00", Slot = "24")]
		public void ENPGBHJBPCE(CAMBCDMDDIB BCJDDLNACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x22E7710", Offset = "0x22E6110", VA = "0x1822E7710", Slot = "25")]
		public void EFPGCHMJHGH(CAMBCDMDDIB BCJDDLNACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x243AD80", Offset = "0x2439780", VA = "0x18243AD80")]
		private void KIHBEADMOJM<T>(CAMBCDMDDIB BCJDDLNACAB, bool NKJMIDIDBOE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x243AC40", Offset = "0x2439640", VA = "0x18243AC40")]
		private bool EPNBIAGEOLL<T>(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x243B3A0", Offset = "0x2439DA0", VA = "0x18243B3A0")]
		private void OMBMHDCIFDM<T>(CAMBCDMDDIB BCJDDLNACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x243ADD0", Offset = "0x24397D0", VA = "0x18243ADD0")]
		private bool MJJLNIMELFH<TC, TV>(CAMBCDMDDIB BCJDDLNACAB, Func<TC, TV> IMPJBNCDEDG, out TV NKJMIDIDBOE) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x243ACA0", Offset = "0x24396A0", VA = "0x18243ACA0")]
		private bool MJJLNIMELFH<T>(CAMBCDMDDIB BCJDDLNACAB, out T NKJMIDIDBOE) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x243AF50", Offset = "0x2439950", VA = "0x18243AF50")]
		private T OFNGJFPJKFH<T>(CAMBCDMDDIB BCJDDLNACAB) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x243B400", Offset = "0x2439E00", VA = "0x18243B400")]
		private void PFEIPMNFHKG<T>(CAMBCDMDDIB BCJDDLNACAB, T NKJMIDIDBOE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x243A470", Offset = "0x2438E70", VA = "0x18243A470")]
		private void AHDANABHPOC<T>(CAMBCDMDDIB BCJDDLNACAB, T NKJMIDIDBOE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x243ACA0", Offset = "0x24396A0", VA = "0x18243ACA0")]
		private bool IGDGHELFCJG<T>(CAMBCDMDDIB BCJDDLNACAB, out T NKJMIDIDBOE) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x243AD20", Offset = "0x2439720", VA = "0x18243AD20")]
		private T JPPOABMOGNK<T>(CAMBCDMDDIB BCJDDLNACAB) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x243ACA0", Offset = "0x24396A0", VA = "0x18243ACA0")]
		private void IIFLEMJFBLK<T>(CAMBCDMDDIB BCJDDLNACAB, T NKJMIDIDBOE) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x243AAD0", Offset = "0x24394D0", VA = "0x18243AAD0")]
		private void BPNGEPAHEGI<T>(CAMBCDMDDIB BCJDDLNACAB, T NKJMIDIDBOE) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x22E7320", Offset = "0x22E5D20", VA = "0x1822E7320")]
		private CAMBCDMDDIB DHBOGMDCMEB(Entity EBOGCLNNJGN)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x22E9910", Offset = "0x22E8310", VA = "0x1822E9910")]
		private DynamicBuffer<Entity> OBOEEBCOGDB(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x243AB80", Offset = "0x2439580", VA = "0x18243AB80")]
		private void ECIGOMBPINO<T>(CAMBCDMDDIB BCJDDLNACAB, object NKJMIDIDBOE, Func<object, T> IMPJBNCDEDG) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		private void LCHEDBCCHIE<T>(ref global::JLLCOHPACPA<T> FPKBPOKFAHB) where T : struct, HPFKDEBDLEN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		private void LCHEDBCCHIE<TC, TV>(ref global::NNAHOGIEPBH<TC, TV> FPKBPOKFAHB) where TC : struct, HPFKDEBDLEN
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
	[DNKFJNHNNCA(typeof(KinematicSleepChangeService), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	public class KinematicSleepChangeService : CFMOGGHLNDM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class KBPAEPMHHLH : IEnumerable<GNFFCDBPNKD>, IEnumerable, IEnumerator<GNFFCDBPNKD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			private GNFFCDBPNKD <>2__current;

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
			private GNFFCDBPNKD System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x877FD0", Offset = "0x8769D0", VA = "0x180877FD0")]
			[DebuggerHidden]
			public KBPAEPMHHLH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x38ABCC0", Offset = "0x38AA6C0", VA = "0x1838ABCC0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x38AB980", Offset = "0x38AA380", VA = "0x1838AB980", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x38ABD40", Offset = "0x38AA740", VA = "0x1838ABD40")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x38ABC80", Offset = "0x38AA680", VA = "0x1838ABC80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x38ABBD0", Offset = "0x38AA5D0", VA = "0x1838ABBD0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GNFFCDBPNKD> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x38ABBD0", Offset = "0x38AA5D0", VA = "0x1838ABBD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> ECGGEKBPKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI FBFHHMCDIGN;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x218E600", Offset = "0x218D000", VA = "0x18218E600", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x218F170", Offset = "0x218DB70", VA = "0x18218F170")]
		public void NHGEOBEFJAG(NativeArray<Entity> GBNPHFOKMOH, bool BGEDMJABACM, bool LKIJJCOLPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x218E7A0", Offset = "0x218D1A0", VA = "0x18218E7A0")]
		public void IINOOJFMKFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x218E9B0", Offset = "0x218D3B0", VA = "0x18218E9B0")]
		private void MEFNICJLJAJ(NativeArray<Entity> GBNPHFOKMOH, bool BGEDMJABACM, bool LKIJJCOLPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x218E570", Offset = "0x218CF70", VA = "0x18218E570")]
		[IteratorStateMachine(typeof(KBPAEPMHHLH))]
		private IEnumerable<GNFFCDBPNKD> BFAKEDMMIBL(NativeArray<Entity> GBNPHFOKMOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x218E650", Offset = "0x218D050", VA = "0x18218E650", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x218F2E0", Offset = "0x218DCE0", VA = "0x18218F2E0")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DefaultMember("Item")]
[DNKFJNHNNCA(typeof(OBGMOBEFLNM), new string[] { })]
public class MHFHDCIHFMN : OBGMOBEFLNM, IEnumerable<FKCOPGJECPA>, IEnumerable, OKCOAIBIMKN, AHDDAOHEFAN, CFMOGGHLNDM, BGKGLCNGELH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[MJIDFIFGMKP]
	private COPHABAACLB CDGNAONMFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Dictionary<(Type, string), int> BFNGCCJGGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private DCKKLECLIEF IHGCPFGBPFE;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x22C8A30", Offset = "0x22C7430", VA = "0x1822C8A30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public FKCOPGJECPA GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x22C8F00", Offset = "0x22C7900", VA = "0x1822C8F00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public FKCOPGJECPA GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x22C8F00", Offset = "0x22C7900", VA = "0x1822C8F00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x22C8C00", Offset = "0x22C7600", VA = "0x1822C8C00", Slot = "11")]
	public void LMBJCLDJBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x22C8A50", Offset = "0x22C7450", VA = "0x1822C8A50", Slot = "12")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "13")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x22C8F20", Offset = "0x22C7920", VA = "0x1822C8F20")]
	private void PLJFBKINNMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0xAA6C50", Offset = "0xAA5650", VA = "0x180AA6C50")]
	private string DMOFMEIPPKK(string KKJOOAJGLJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x22C8950", Offset = "0x22C7350", VA = "0x1822C8950", Slot = "7")]
	public FKCOPGJECPA BMDCBEPCHLO(GMGAEIHDIEM OKNFKAJADBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x22C8C50", Offset = "0x22C7650", VA = "0x1822C8C50")]
	private bool NHEEMFPGJFE(Type IBIJJOHHONN, string KKJOOAJGLJI, out FKCOPGJECPA GPFHBGAIKFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x22C8AD0", Offset = "0x22C74D0", VA = "0x1822C8AD0", Slot = "8")]
	public ACIALDGCHGB GLHOBNMGKBO(GMGAEIHDIEM OKNFKAJADBM)
	{
		return default(ACIALDGCHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x22C8BE0", Offset = "0x22C75E0", VA = "0x1822C8BE0", Slot = "9")]
	public IEnumerator<FKCOPGJECPA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x22C8BE0", Offset = "0x22C75E0", VA = "0x1822C8BE0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x22C91C0", Offset = "0x22C7BC0", VA = "0x1822C91C0")]
	public MHFHDCIHFMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
[DefaultMember("Item")]
public interface HJBDBCBHBPP
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JMIJDAOMJLN(ACIALDGCHGB ENFGKNDHLNI, out int GCDOPBGGNDP);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
[DNKFJNHNNCA(typeof(HJBDBCBHBPP), new string[] { })]
public class PLMGMOPFPKO : CFMOGGHLNDM, BGKGLCNGELH, HJBDBCBHBPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[MJIDFIFGMKP]
	private AMNDMACHLPL CDGNAONMFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly Dictionary<ACIALDGCHGB, int> BAODFPMEFBC;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x22DDD80", Offset = "0x22DC780", VA = "0x1822DDD80", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x22DDA90", Offset = "0x22DC490", VA = "0x1822DDA90", Slot = "6")]
	public bool JMIJDAOMJLN(ACIALDGCHGB ENFGKNDHLNI, out int GCDOPBGGNDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x22DDA30", Offset = "0x22DC430", VA = "0x1822DDA30", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x22DDD70", Offset = "0x22DC770", VA = "0x1822DDD70", Slot = "5")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x22DDB00", Offset = "0x22DC500", VA = "0x1822DDB00")]
	private void JNCDDKNAKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x22DDDE0", Offset = "0x22DC7E0", VA = "0x1822DDDE0")]
	public PLMGMOPFPKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DNKFJNHNNCA(typeof(AMNDMACHLPL), new string[] { })]
[DefaultMember("Item")]
public class POMNNDGJLJJ : AMNDMACHLPL, IEnumerable<BHEGOIHHKIE>, IEnumerable, OKCOAIBIMKN, AHDDAOHEFAN, CFMOGGHLNDM, BGKGLCNGELH, FDHLGFOCCIN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[MJIDFIFGMKP]
	private PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[MJIDFIFGMKP]
	private OBGMOBEFLNM OIOOCGEHHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private BHEGOIHHKIE[] MCNFDCJGMLG;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x22DE000", Offset = "0x22DCA00", VA = "0x1822DE000", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public BHEGOIHHKIE GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x22DE5A0", Offset = "0x22DCFA0", VA = "0x1822DE5A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public BHEGOIHHKIE GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x22DE5A0", Offset = "0x22DCFA0", VA = "0x1822DE5A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "10")]
	public void LMBJCLDJBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x22DE010", Offset = "0x22DCA10", VA = "0x1822DE010", Slot = "11")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "12")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x22DDED0", Offset = "0x22DC8D0", VA = "0x1822DDED0", Slot = "6")]
	public BHEGOIHHKIE BMDCBEPCHLO(GMGAEIHDIEM OKNFKAJADBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x22DE3F0", Offset = "0x22DCDF0", VA = "0x1822DE3F0", Slot = "7")]
	public ACIALDGCHGB GLHOBNMGKBO(GMGAEIHDIEM OKNFKAJADBM)
	{
		return default(ACIALDGCHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x22DE4C0", Offset = "0x22DCEC0", VA = "0x1822DE4C0", Slot = "8")]
	public IEnumerator<BHEGOIHHKIE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x22DE5E0", Offset = "0x22DCFE0", VA = "0x1822DE5E0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x24D42E0", Offset = "0x24D2CE0", VA = "0x1824D42E0", Slot = "13")]
	public void ENHJEHPFHBO<TKey, T>(global::MNOFBDJHDKK<TKey, T> GNIPEANGOCM, [Optional] object ABFHDOGCMDC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x22DE2B0", Offset = "0x22DCCB0", VA = "0x1822DE2B0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public POMNNDGJLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x22DE5A0", Offset = "0x22DCFA0", VA = "0x1822DE5A0")]
	[CompilerGenerated]
	private BHEGOIHHKIE IJEGMCOAGMP(int JEBAMNOFEGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[DNKFJNHNNCA(typeof(AJHEAAFBPJF), new string[] { })]
[DefaultMember("Item")]
public class GAKLPHCOEBO : AJHEAAFBPJF, IEnumerable<FNEDFINGEKN>, IEnumerable, CFMOGGHLNDM, BGKGLCNGELH, FDHLGFOCCIN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[MJIDFIFGMKP]
	private PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[MJIDFIFGMKP]
	private OBGMOBEFLNM OIOOCGEHHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private FNEDFINGEKN[] MCNFDCJGMLG;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x217C6A0", Offset = "0x217B0A0", VA = "0x18217C6A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public FNEDFINGEKN GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x217CAC0", Offset = "0x217B4C0", VA = "0x18217CAC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public FNEDFINGEKN GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x217CAC0", Offset = "0x217B4C0", VA = "0x18217CAC0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x217C7D0", Offset = "0x217B1D0", VA = "0x18217C7D0", Slot = "9")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x217CAD0", Offset = "0x217B4D0", VA = "0x18217CAD0", Slot = "10")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x217C6F0", Offset = "0x217B0F0", VA = "0x18217C6F0")]
	private FNEDFINGEKN CFOMDOKHKDJ(int NENMOOINMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x217C580", Offset = "0x217AF80", VA = "0x18217C580", Slot = "6")]
	public FNEDFINGEKN BMDCBEPCHLO(GMGAEIHDIEM OKNFKAJADBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x217C8E0", Offset = "0x217B2E0", VA = "0x18217C8E0", Slot = "14")]
	public ACIALDGCHGB GLHOBNMGKBO(GMGAEIHDIEM OKNFKAJADBM)
	{
		return default(ACIALDGCHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x217C9B0", Offset = "0x217B3B0", VA = "0x18217C9B0", Slot = "7")]
	public IEnumerator<FNEDFINGEKN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x217C9B0", Offset = "0x217B3B0", VA = "0x18217C9B0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5B50", Offset = "0x1DA4550", VA = "0x181DA5B50", Slot = "11")]
	public void ENHJEHPFHBO<TKey, T>(global::MNOFBDJHDKK<TKey, T> GNIPEANGOCM, [Optional] object ABFHDOGCMDC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x217C840", Offset = "0x217B240", VA = "0x18217C840", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public GAKLPHCOEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x217CAC0", Offset = "0x217B4C0", VA = "0x18217CAC0")]
	[CompilerGenerated]
	private FNEDFINGEKN IJEGMCOAGMP(int JEBAMNOFEGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
[DNKFJNHNNCA(typeof(COPHABAACLB), new string[] { })]
internal class COPHABAACLB : CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private OBGMOBEFLNM OIOOCGEHHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private AJHEAAFBPJF GAKNBEPMNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private AMNDMACHLPL LAKOLENJMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private global::CLOECBDOJED<HNAPDCCEHDA> GLIFANIEIAA;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public DCKKLECLIEF NPOKBOLDMBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6B0AB0", Offset = "0x6AF4B0", VA = "0x1806B0AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8588D0", Offset = "0x8572D0", VA = "0x1808588D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x24B3FE0", Offset = "0x24B29E0", VA = "0x1824B3FE0", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x24B3E20", Offset = "0x24B2820", VA = "0x1824B3E20")]
	private void BHNKFENOFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x1E21290", Offset = "0x1E1FC90", VA = "0x181E21290")]
	public T OPENBEEEBOK<T>() where T : HNAPDCCEHDA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x24B41E0", Offset = "0x24B2BE0", VA = "0x1824B41E0")]
	public FKCOPGJECPA NHNCBKHJDOD(GMGAEIHDIEM KKJOOAJGLJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	public global::MCHJKBDIPIH<T> NHNCBKHJDOD<T>(GMGAEIHDIEM KKJOOAJGLJI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x24B3F10", Offset = "0x24B2910", VA = "0x1824B3F10")]
	public FNEDFINGEKN CHABDPEBJIC(GMGAEIHDIEM KKJOOAJGLJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x1E21210", Offset = "0x1E1FC10", VA = "0x181E21210")]
	public global::DKOBANLLHLA<T> CHABDPEBJIC<T>(GMGAEIHDIEM KKJOOAJGLJI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x24B4110", Offset = "0x24B2B10", VA = "0x1824B4110")]
	public BHEGOIHHKIE EIDGJPNICHB(GMGAEIHDIEM KKJOOAJGLJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	public global::EPJKFGDFGEO<T> EIDGJPNICHB<T>(GMGAEIHDIEM KKJOOAJGLJI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public COPHABAACLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal static class NHCIGLCDNKB
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2209890", Offset = "0x2208290", VA = "0x182209890")]
	public static global::MCHJKBDIPIH<T> NHNCBKHJDOD<T>(this COPHABAACLB NCMLMNDELHI, global::ILAKDLOENDG<T> KKJOOAJGLJI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	public static global::DKOBANLLHLA<T> CHABDPEBJIC<T>(this COPHABAACLB NCMLMNDELHI, global::ILAKDLOENDG<T> KKJOOAJGLJI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	public static global::EPJKFGDFGEO<T> EIDGJPNICHB<T>(this COPHABAACLB NCMLMNDELHI, global::ILAKDLOENDG<T> KKJOOAJGLJI) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
[DNKFJNHNNCA(typeof(BCCJILKFOPO), new string[] { })]
public class BCCJILKFOPO : CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private PDOBMNIPJPM MHEJMLFEFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private ACIALDGCHGB[] JPPGFGOAAFN;

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x24ADE00", Offset = "0x24AC800", VA = "0x1824ADE00", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x24AE090", Offset = "0x24ACA90", VA = "0x1824AE090")]
	public void NINDAIHGBKP(DPCBAIHHPOK PKBNFFGFIEN, bool CINJFMNBDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public BCCJILKFOPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[DNKFJNHNNCA(typeof(KFCMNDDODFK), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
public sealed class KFCMNDDODFK : CFMOGGHLNDM, BGKGLCNGELH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class FGIAFJLEPME : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x877FD0", Offset = "0x8769D0", VA = "0x180877FD0")]
		[DebuggerHidden]
		public FGIAFJLEPME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x38A5900", Offset = "0x38A4300", VA = "0x1838A5900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x38A5550", Offset = "0x38A3F50", VA = "0x1838A5550", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x38A5980", Offset = "0x38A4380", VA = "0x1838A5980")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x38A58C0", Offset = "0x38A42C0", VA = "0x1838A58C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x38A5830", Offset = "0x38A4230", VA = "0x1838A5830", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x38A5830", Offset = "0x38A4230", VA = "0x1838A5830", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private const string DHJBANKBFCN = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<SerializableGuid, DDOKJFHMAIJ> JCODJGLJCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly List<SerializableGuid> OPHKCCNHMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly Dictionary<SerializableGuid, GameObject> JFOCGIPFIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private AJHEAAFBPJF CDGNAONMFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private PNLHBOHNCFH MGOGCFMPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private EMCACLLEGIF AKMKADIDNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private AMGOMELBDKB BHNPFBAANIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private global::HHMNIGMFFBK<DDOKJFHMAIJ> KDILNECEEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GameObject LGLKGMMPMPH;

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x218AF80", Offset = "0x2189980", VA = "0x18218AF80", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x218BE30", Offset = "0x218A830", VA = "0x18218BE30", Slot = "5")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x218B050", Offset = "0x2189A50", VA = "0x18218B050", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x218B1F0", Offset = "0x2189BF0", VA = "0x18218B1F0")]
	private void FILGEFLBFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x218B870", Offset = "0x218A270", VA = "0x18218B870")]
	internal void JKOMPOPFELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x218ADA0", Offset = "0x21897A0", VA = "0x18218ADA0")]
	private void CBFIFJGCKHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x218B770", Offset = "0x218A170", VA = "0x18218B770")]
	private void IFPOJDJHJGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x218AD50", Offset = "0x2189750", VA = "0x18218AD50")]
	[IteratorStateMachine(typeof(FGIAFJLEPME))]
	private IEnumerable<RRCustomPropTag> APOKJHJBPHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x218A8D0", Offset = "0x21892D0", VA = "0x18218A8D0")]
	private void ANEDHBEPKKP(CAMBCDMDDIB BCJDDLNACAB, in DCNFIHFHOLK HIJNDNKMAJM, in DCNFIHFHOLK MIIOPMDNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x218BCF0", Offset = "0x218A6F0", VA = "0x18218BCF0")]
	private void MKIHEFFHNPG(SerializableGuid CAPPBFKKCMA, GameObject OOAFGPFKNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x218B200", Offset = "0x2189C00", VA = "0x18218B200")]
	private void HBPIPPFFKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x218B590", Offset = "0x2189F90", VA = "0x18218B590")]
	private bool HCONDMIKPOH(DDOKJFHMAIJ DNGIAGLACAP, Transform EGNCPOLPGCD, out GameObject LOGLKKHAEGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x218BCA0", Offset = "0x218A6A0", VA = "0x18218BCA0")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x218C000", Offset = "0x218AA00", VA = "0x18218C000")]
	public KFCMNDDODFK()
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
		public SerializableGuid FFIHOLHEFAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x909700", Offset = "0x908100", VA = "0x180909700")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x22E67B0", Offset = "0x22E51B0", VA = "0x1822E67B0")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DNKFJNHNNCA(typeof(FKNLAECFDCA), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
public class FKNLAECFDCA : CFMOGGHLNDM
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const string CKJOJEFKOLK = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private SceneService GBKOJEMNHHK;

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x217C4F0", Offset = "0x217AEF0", VA = "0x18217C4F0", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public FKNLAECFDCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
[DNKFJNHNNCA(typeof(HNLCCCMLHPM), new string[] { })]
public class HNLCCCMLHPM : CFMOGGHLNDM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[MJIDFIFGMKP]
	private EnableComponentSystemsInScope PMAMFHDJMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[MJIDFIFGMKP]
	private SceneService GBKOJEMNHHK;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2181710", Offset = "0x2180110", VA = "0x182181710", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2181780", Offset = "0x2180180", VA = "0x182181780", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x21817C0", Offset = "0x21801C0", VA = "0x1821817C0")]
	private void GLMFOIIGNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x21817E0", Offset = "0x21801E0", VA = "0x1821817E0")]
	private void LOGOHJDDCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public HNLCCCMLHPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DNKFJNHNNCA(typeof(DFFINCJAHNC), new string[] { })]
public class OALJOBFNBDP : CFMOGGHLNDM, BGKGLCNGELH, DFFINCJAHNC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private LKBGGDFMKHG HDFHOPBBCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private EAMOGGBKCFN EKCNEIPPGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private PropertyEventCallbacksService APCBMNHLIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private LocalPlayerScopeSystem AGIEODMAJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private int NBKEAJLMNAI;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool AKEENCNLBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x22CDB80", Offset = "0x22CC580", VA = "0x1822CDB80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public CAMBCDMDDIB GLFJFPFBGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x22CDD10", Offset = "0x22CC710", VA = "0x1822CDD10", Slot = "9")]
		get
		{
			return default(CAMBCDMDDIB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x22CD6F0", Offset = "0x22CC0F0", VA = "0x1822CD6F0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public MPBFDJNFALM OMADKPDJGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x22CDCC0", Offset = "0x22CC6C0", VA = "0x1822CDCC0", Slot = "11")]
		get
		{
			return default(MPBFDJNFALM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x22CD6F0", Offset = "0x22CC0F0", VA = "0x1822CD6F0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public MPBFDJNFALM COLHCGNBKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x22CD6A0", Offset = "0x22CC0A0", VA = "0x1822CD6A0", Slot = "13")]
		get
		{
			return default(MPBFDJNFALM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private uint MMKIDBFNMGA
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x22CD2E0", Offset = "0x22CBCE0", VA = "0x1822CD2E0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event DHKOODAJNIM MMCJIMCKEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x22CD240", Offset = "0x22CBC40", VA = "0x1822CD240", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x22CD830", Offset = "0x22CC230", VA = "0x1822CD830", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x22CD390", Offset = "0x22CBD90", VA = "0x1822CD390", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x22CD9E0", Offset = "0x22CC3E0", VA = "0x1822CD9E0", Slot = "5")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x22CD5F0", Offset = "0x22CBFF0", VA = "0x1822CD5F0", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x22CD040", Offset = "0x22CBA40", VA = "0x1822CD040")]
	private void APGKALGBCOF(Entity EBOGCLNNJGN, ACIALDGCHGB EDNCKFCJECD, DCNFIHFHOLK GKKEBOJKIEH, DCNFIHFHOLK KMKKONJJIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x22CD8D0", Offset = "0x22CC2D0", VA = "0x1822CD8D0", Slot = "14")]
	public CAMBCDMDDIB MACLNGAGHFP(CAMBCDMDDIB BGIPIHJGIOM, CAMBCDMDDIB ACFAFPAEJAI)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x22CDBC0", Offset = "0x22CC5C0", VA = "0x1822CDBC0", Slot = "15")]
	public bool OAKKIMOAAKP(CAMBCDMDDIB BGIPIHJGIOM, CAMBCDMDDIB ACFAFPAEJAI, out CAMBCDMDDIB KPPDBEKLBMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x22CD460", Offset = "0x22CBE60", VA = "0x1822CD460", Slot = "16")]
	public void DOCJBPNFHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x22CD790", Offset = "0x22CC190", VA = "0x1822CD790", Slot = "17")]
	public void HIICCCEAHOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x22CCEE0", Offset = "0x22CB8E0", VA = "0x1822CCEE0", Slot = "18")]
	public bool ALMKFILBBPH(CAMBCDMDDIB HGJMJLMOCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x22CD6F0", Offset = "0x22CC0F0", VA = "0x1822CD6F0")]
	private void KFLJDEGHJHI(CAMBCDMDDIB FOOHBNMPHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public OALJOBFNBDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DNKFJNHNNCA(typeof(OAGKEELJIIK), new string[] { })]
public class HEEOIACFIGG : CFMOGGHLNDM, OAGKEELJIIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private EntityManager KACBFFMHDCF;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2180D30", Offset = "0x217F730", VA = "0x182180D30", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2180CC0", Offset = "0x217F6C0", VA = "0x182180CC0", Slot = "5")]
	public void BAKIKIFFGBO(CAMBCDMDDIB MMCCMEFGKOD, bool NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7CD0", Offset = "0x1DC66D0", VA = "0x181DC7CD0")]
	private void LMCGMFHIJLB<T>(CAMBCDMDDIB MMCCMEFGKOD, bool NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public HEEOIACFIGG()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[DNKFJNHNNCA(typeof(JGLBDOKINNL), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.RenderEffects)]
	public class SelectionService : CFMOGGHLNDM, JGLBDOKINNL
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private EntityManager KACBFFMHDCF;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x22F0EE0", Offset = "0x22EF8E0", VA = "0x1822F0EE0", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x22F0F60", Offset = "0x22EF960", VA = "0x1822F0F60", Slot = "5")]
		public void OHJNFCPOOKF(CAMBCDMDDIB MMCCMEFGKOD, bool NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x22F0E70", Offset = "0x22EF870", VA = "0x1822F0E70", Slot = "6")]
		public void AMIENPKOLKI(CAMBCDMDDIB MMCCMEFGKOD, bool NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7CD0", Offset = "0x1DC66D0", VA = "0x181DC7CD0")]
		private void LMCGMFHIJLB<T>(CAMBCDMDDIB MMCCMEFGKOD, bool NKJMIDIDBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
[DNKFJNHNNCA(typeof(CCCBBOAPLNI), new string[] { })]
internal sealed class CCCBBOAPLNI : CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[MJIDFIFGMKP]
	private ObjectEmbodimentService OFGCILEINOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[MJIDFIFGMKP]
	private CAOOBKKGEDI FBFHHMCDIGN;

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x24B1CF0", Offset = "0x24B06F0", VA = "0x1824B1CF0", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public CCCBBOAPLNI()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[OJEJDFBPPED(FHFOPEOFOPD.Serialization)]
	[DNKFJNHNNCA(typeof(WorldSerialization), new string[] { })]
	[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
	internal sealed class WorldSerialization : CFMOGGHLNDM, OILOIPKCJDO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly LOOGELFKPLM NICMPNOKCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[MJIDFIFGMKP]
		private HIGEHOPBKAJ LHCGGCJEEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[MJIDFIFGMKP]
		private PNLHBOHNCFH MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[MJIDFIFGMKP]
		private SerializationService AKMKADIDNNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[MJIDFIFGMKP]
		private DGIHKPBCDBI HNIDBFHKANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[MJIDFIFGMKP]
		private DebugWorldsService HJLPAMMOOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[MJIDFIFGMKP]
		private BulkInstantiateSceneObjectService NPOLJNMMAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private DOMLOFPDLMI KDGPDENJJDJ;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private OLLGCDONNNB NECNFKBCLMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0x13FE1A0", Offset = "0x13FCBA0", VA = "0x1813FE1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2305E60", Offset = "0x2304860", VA = "0x182305E60", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI AIDBEODHFKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x2305FB0", Offset = "0x23049B0", VA = "0x182305FB0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x2306030", Offset = "0x2304A30", VA = "0x182306030", Slot = "6")]
		public bool HHFNMKPLIMK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x2306190", Offset = "0x2304B90", VA = "0x182306190", Slot = "7")]
		public bool IEFFEDJECNP(IEnumerable<DCBEICMMGBC> OAOMNDFMDJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x2305900", Offset = "0x2304300", VA = "0x182305900", Slot = "5")]
		public ByteString CAHKMJHKANJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x2306530", Offset = "0x2304F30", VA = "0x182306530")]
		private void KAJGOOKKHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x2305D90", Offset = "0x2304790", VA = "0x182305D90")]
		private void CFGDCJENBKK(LJAPEEAMNPH CKHOMKKKIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x2306550", Offset = "0x2304F50", VA = "0x182306550")]
		private void OAKEPINCODO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x23061B0", Offset = "0x2304BB0", VA = "0x1823061B0")]
		private void JABOFEKEMFP(LLECKNIDJAH CKHOMKKKIOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x2305FE0", Offset = "0x23049E0", VA = "0x182305FE0", Slot = "8")]
		public void HDAFDLBGHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x2306490", Offset = "0x2304E90", VA = "0x182306490")]
		private LJAPEEAMNPH JIFMKGICMLN(EntityManager BFKEFEBKFHL, EntityManager FIDFPIOBDFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DNKFJNHNNCA(typeof(EPFBAMBCBIM), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
public class EPFBAMBCBIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly Dictionary<BKPIKMGJOND, string> ALMIICDENJN;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x24C5E90", Offset = "0x24C4890", VA = "0x1824C5E90")]
	public GameObject LENCKJBAFND(BKPIKMGJOND PEGDFIKMGNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x24C5F60", Offset = "0x24C4960", VA = "0x1824C5F60")]
	public EPFBAMBCBIM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	[DNKFJNHNNCA(typeof(TimeService), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	public class TimeService : AHDDAOHEFAN, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[MJIDFIFGMKP]
		private SingletonComponentService IJOLBNDMBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private bool LOPHOMBFKGO;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public TimeData PLJBJELMHKB
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x22F8850", Offset = "0x22F7250", VA = "0x1822F8850")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x22F87D0", Offset = "0x22F71D0", VA = "0x1822F87D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool DBIBDCGFJNE
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x7F5D60", Offset = "0x7F4760", VA = "0x1807F5D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x881D10", Offset = "0x880710", VA = "0x180881D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x881E80", Offset = "0x880880", VA = "0x180881E80", Slot = "4")]
		public void LMBJCLDJBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x22F8780", Offset = "0x22F7180", VA = "0x1822F8780", Slot = "5")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x22F88C0", Offset = "0x22F72C0", VA = "0x1822F88C0")]
		public void NKPJOLEGJPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[OJEJDFBPPED(FHFOPEOFOPD.TransformSyncing)]
	[DNKFJNHNNCA(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
	internal class SetTransformParentIfParentPropertyChanges : CFMOGGHLNDM, BGKGLCNGELH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private NPDHBLHKCNF IHDGODIAJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private global::MCHJKBDIPIH<Entity> EGNCPOLPGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private ObjectEmbodimentService DDEMFDMAJBL;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x22F4900", Offset = "0x22F3300", VA = "0x1822F4900", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x22F4B50", Offset = "0x22F3550", VA = "0x1822F4B50", Slot = "5")]
		public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x22F4970", Offset = "0x22F3370", VA = "0x1822F4970", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x22F4A10", Offset = "0x22F3410", VA = "0x1822F4A10")]
		private void ICPIGJCMBAA(Entity EBOGCLNNJGN, in DCNFIHFHOLK HIJNDNKMAJM, in DCNFIHFHOLK MIIOPMDNGOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[OJEJDFBPPED(FHFOPEOFOPD.Services)]
	[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
	[DNKFJNHNNCA(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	public class EnableTransmissionOnlyInLoadInstance : CFMOGGHLNDM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[MJIDFIFGMKP]
		private KIFFMJJMCOB GCNBMKKLBLC;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private DGCEJPBNJOO MJNFIJPDNDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x24C84C0", Offset = "0x24C6EC0", VA = "0x1824C84C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private CLGKNMADPBA BGGOCFICBJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x24C8470", Offset = "0x24C6E70", VA = "0x1824C8470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x24C83D0", Offset = "0x24C6DD0", VA = "0x1824C83D0", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x24C8450", Offset = "0x24C6E50", VA = "0x1824C8450", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
[DNKFJNHNNCA(typeof(OOBOJPOAFKD), new string[] { })]
public class OOBOJPOAFKD : LMJEAKIHKOP, OKCOAIBIMKN, AHDDAOHEFAN, CFMOGGHLNDM, BGKGLCNGELH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class CNCHCKNCGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public DOMLOFPDLMI services;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public CNCHCKNCGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x38A3770", Offset = "0x38A2170", VA = "0x1838A3770")]
		internal void <InitReferences>b__0(CFMOGGHLNDM svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class MMABEGDDMKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public DOMLOFPDLMI services;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public MMABEGDDMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x38ACC90", Offset = "0x38AB690", VA = "0x1838ACC90")]
		internal void <InitExternal>b__0(BGKGLCNGELH svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	[MJIDFIFGMKP]
	private CAOOBKKGEDI FBFHHMCDIGN;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public KGBPMICCNIM PNOLMDACAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x6B9700", Offset = "0x6B8100", VA = "0x1806B9700", Slot = "4")]
		get
		{
			return default(KGBPMICCNIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private OLNILFAFOLN DLPKPCDMEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x22CF0D0", Offset = "0x22CDAD0", VA = "0x1822CF0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x22CF120", Offset = "0x22CDB20", VA = "0x1822CF120", Slot = "5")]
	public void IMNJFGBMJOD(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x22CF170", Offset = "0x22CDB70", VA = "0x1822CF170", Slot = "6")]
	public void LMBJCLDJBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x22CEEC0", Offset = "0x22CD8C0", VA = "0x1822CEEC0", Slot = "7")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x22CF2A0", Offset = "0x22CDCA0", VA = "0x1822CF2A0", Slot = "8")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x22CEFA0", Offset = "0x22CD9A0", VA = "0x1822CEFA0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x2218100", Offset = "0x2216B00", VA = "0x182218100")]
	private void HPPABEIMHDJ<T>(Action<T> CNIJPLFNGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public OOBOJPOAFKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class PABAPICPAKD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly Func<From, To> AGPOHFNPPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly Func<To, From> BECPDLCBILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public DynamicBuffer<From> MFPFCCDPGDI;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public To GMLDPDCPAEM
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
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool PDKIMMAFNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	public PABAPICPAKD(Func<From, To> AGPOHFNPPAE, Func<To, From> BECPDLCBILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] EIOACKOCJCB, int CJMIFBGEMCC)
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
	public int IndexOf(To LPGHMHLAPGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int NENMOOINMCH, To LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int NENMOOINMCH)
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
public class JKOCOGPJOEG<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly Func<From, To> AGPOHFNPPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly Func<To, From> BECPDLCBILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public List<From> AMMGMIDPNEP;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C6D0", Offset = "0x2D9B0D0", VA = "0x182D9C6D0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C730", Offset = "0x2D9B130", VA = "0x182D9C730", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x2D9C6A0", Offset = "0x2D9B0A0", VA = "0x182D9C6A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool PDKIMMAFNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x799F80", Offset = "0x798980", VA = "0x180799F80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x799F70", Offset = "0x798970", VA = "0x180799F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x25B4900", Offset = "0x25B3300", VA = "0x1825B4900")]
	public JKOCOGPJOEG(Func<From, To> AGPOHFNPPAE, Func<To, From> BECPDLCBILG, bool FMOAHOIEJLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C290", Offset = "0x2D9AC90", VA = "0x182D9C290", Slot = "11")]
	public void Add(To LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x17224B0", Offset = "0x1720EB0", VA = "0x1817224B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C2F0", Offset = "0x2D9ACF0", VA = "0x182D9C2F0", Slot = "13")]
	public bool Contains(To LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C350", Offset = "0x2D9AD50", VA = "0x182D9C350", Slot = "14")]
	public void CopyTo(To[] EIOACKOCJCB, int CJMIFBGEMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C460", Offset = "0x2D9AE60", VA = "0x182D9C460", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C530", Offset = "0x2D9AF30", VA = "0x182D9C530", Slot = "6")]
	public int IndexOf(To LPGHMHLAPGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C590", Offset = "0x2D9AF90", VA = "0x182D9C590", Slot = "7")]
	public void Insert(int NENMOOINMCH, To LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C640", Offset = "0x2D9B040", VA = "0x182D9C640", Slot = "15")]
	public bool Remove(To LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2D9C610", Offset = "0x2D9B010", VA = "0x182D9C610", Slot = "8")]
	public void RemoveAt(int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x1C12DD0", Offset = "0x1C117D0", VA = "0x181C12DD0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DefaultMember("Item")]
public class FOLDEKBLIPG<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private readonly Func<From, To> AGPOHFNPPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Func<To, From> BECPDLCBILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeArray<From> EIOACKOCJCB;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x26A7C10", Offset = "0x26A6610", VA = "0x1826A7C10", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x26A7C60", Offset = "0x26A6660", VA = "0x1826A7C60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x26A7BD0", Offset = "0x26A65D0", VA = "0x1826A7BD0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool PDKIMMAFNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A32E0", Offset = "0x6A1CE0", VA = "0x1806A32E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x1B77440", Offset = "0x1B75E40", VA = "0x181B77440")]
	public FOLDEKBLIPG(Func<From, To> AGPOHFNPPAE, Func<To, From> BECPDLCBILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x26A7790", Offset = "0x26A6190", VA = "0x1826A7790", Slot = "11")]
	public void Add(To LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x26A77D0", Offset = "0x26A61D0", VA = "0x1826A77D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x26A7810", Offset = "0x26A6210", VA = "0x1826A7810", Slot = "13")]
	public bool Contains(To LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x26A78D0", Offset = "0x26A62D0", VA = "0x1826A78D0", Slot = "14")]
	public void CopyTo(To[] EIOACKOCJCB, int CJMIFBGEMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x26A7990", Offset = "0x26A6390", VA = "0x1826A7990", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x26A7AA0", Offset = "0x26A64A0", VA = "0x1826A7AA0", Slot = "6")]
	public int IndexOf(To LPGHMHLAPGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x26A7B10", Offset = "0x26A6510", VA = "0x1826A7B10", Slot = "7")]
	public void Insert(int NENMOOINMCH, To LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x26A7B90", Offset = "0x26A6590", VA = "0x1826A7B90", Slot = "15")]
	public bool Remove(To LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x26A7B50", Offset = "0x26A6550", VA = "0x1826A7B50", Slot = "8")]
	public void RemoveAt(int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x20C8E60", Offset = "0x20C7860", VA = "0x1820C8E60", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class DINIIPMEGNK<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly Func<From, To> AGPOHFNPPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly Func<To, From> BECPDLCBILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeList<From> AMMGMIDPNEP;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To GMLDPDCPAEM
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
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool PDKIMMAFNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	public DINIIPMEGNK(Func<From, To> AGPOHFNPPAE, Func<To, From> BECPDLCBILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] EIOACKOCJCB, int CJMIFBGEMCC)
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
	public int IndexOf(To LPGHMHLAPGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int NENMOOINMCH, To LPGHMHLAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To LPGHMHLAPGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int NENMOOINMCH)
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
public static class DILCKACECGM
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public const string HNJGKGBPMDJ = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public const string DODJKKIIGHE = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public const string BGCMNFMEOFM = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public const string LJLGHHAJAJJ = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public const string CMKCFDOJIEA = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public const string AGFNHKBGDGI = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public const string OILBEMNPJNL = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public const string FEMDPNGJLGF = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class DIKOIMLHKJP
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class JJMFPIICIJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public DOMLOFPDLMI services;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public JJMFPIICIJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x22EBC00", Offset = "0x22EA600", VA = "0x1822EBC00")]
		internal void <InitServices>b__1(CFMOGGHLNDM svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x22EBC60", Offset = "0x22EA660", VA = "0x1822EBC60")]
		internal void <InitServices>b__2(BGKGLCNGELH svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x24BFC00", Offset = "0x24BE600", VA = "0x1824BFC00")]
	public static void AJCLCMDJODD(this OLNILFAFOLN MKBCEHAIJKD, DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x2869230", Offset = "0x2867C30", VA = "0x182869230")]
	public static void HPPABEIMHDJ<T>(this OLNILFAFOLN MKBCEHAIJKD, Action<T> CNIJPLFNGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x28692A0", Offset = "0x2867CA0", VA = "0x1828692A0")]
	public static void LLGGFHPOOHO<T>(this OLNILFAFOLN MKBCEHAIJKD, Action<T> CNIJPLFNGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x28695B0", Offset = "0x2867FB0", VA = "0x1828695B0")]
	public static void LLJPELDCGGG<T>(this OLNILFAFOLN MKBCEHAIJKD, Action<T> CNIJPLFNGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x2869080", Offset = "0x2867A80", VA = "0x182869080")]
	public static void GNKDNDCJIIO<T>(this OLNILFAFOLN MKBCEHAIJKD, Action<T> CNIJPLFNGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x2869760", Offset = "0x2868160", VA = "0x182869760")]
	public static void NEJLPOECNHB<T>(this OLNILFAFOLN MKBCEHAIJKD, Action<T> CNIJPLFNGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x2869440", Offset = "0x2867E40", VA = "0x182869440")]
	public static void LLGGFHPOOHO<T>(IEnumerable<ComponentSystemBase> ALJPPMMDDBF, Action<T> CNIJPLFNGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x2868FC0", Offset = "0x28679C0", VA = "0x182868FC0")]
	private static void GKDHPMCDNDK<T>(object JGOKKFDANJI, Action<T> CNIJPLFNGIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class GJDJPNPGOJM
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class ICLHEGAHNKC
{
	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x2185490", Offset = "0x2183E90", VA = "0x182185490")]
	public static void LHEOCDOCPIJ(ComponentSystemBase JGOKKFDANJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class MAHFMFDJKGC
{
	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	public static bool MMDDDBHAGIN<T>(ref T LDIEPFCHCFG, ref T KCHCODPDAGF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class NOOKKFFOBIM
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class FNEABECDDKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public FNEABECDDKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x22CC6B0", Offset = "0x22CB0B0", VA = "0x1822CC6B0")]
	public static string LFNFCILIGEJ(Transform MLMJNFGMBPE, Transform HGJMJLMOCJK)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[OJEJDFBPPED(FHFOPEOFOPD.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x22F3AF0", Offset = "0x22F24F0", VA = "0x1822F3AF0")]
		public static void OAOEINPMJJJ(this LAGGBJEMAHE KDGPDENJJDJ, LHIDPAOLOPJ ALIOHCFALJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x22F3780", Offset = "0x22F2180", VA = "0x1822F3780")]
		public static void AMDCKIJJIDG(this LAGGBJEMAHE KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x22F3D20", Offset = "0x22F2720", VA = "0x1822F3D20")]
		public static void OAOEINPMJJJ(this LAGGBJEMAHE KDGPDENJJDJ, [Optional] string[] GEBOEBOJNAJ, [Optional] string[] OGJDACFEAMA, [Optional] string[] DKCBOBAGDGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x22F3880", Offset = "0x22F2280", VA = "0x1822F3880")]
		public static void GDOOFHMMINM(this LAGGBJEMAHE KDGPDENJJDJ, params string[] DCBBCBKGCHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x22F36D0", Offset = "0x22F20D0", VA = "0x1822F36D0")]
		public static void AIKOPHFJDID(this LAGGBJEMAHE KDGPDENJJDJ, params string[] DCBBCBKGCHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x22F3E30", Offset = "0x22F2830", VA = "0x1822F3E30")]
		private static string[] OGPGCFLPFKJ(LHIDPAOLOPJ ALIOHCFALJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x22F3930", Offset = "0x22F2330", VA = "0x1822F3930")]
		private static bool MDAFPAGNPGC(LHIDPAOLOPJ ALIOHCFALJN, out string[] PGHLAAPMELP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x69D720", Offset = "0x69C120", VA = "0x18069D720")]
		private static bool DDHCHBEBGIG()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public abstract class MMANBBEKGCP : JEMJAMBMPJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly MethodInfo LHCMFKNPDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly Type[] GBGLLILEMPG;

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x22C9C70", Offset = "0x22C8670", VA = "0x1822C9C70")]
	public MMANBBEKGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action LLJOCHKMPCJ();

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x22C9A80", Offset = "0x22C8480", VA = "0x1822C9A80")]
	public MethodInfo DLAHMNEHEOI(Action LBPAPOGAAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x22C9AC0", Offset = "0x22C84C0", VA = "0x1822C9AC0", Slot = "4")]
	public void MKIHEFFHNPG(Type NFMPIOLJBMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public abstract class PKIBAOHALBI : MMANBBEKGCP
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private enum EJAOECBPPPE
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x22DD8C0", Offset = "0x22DC2C0", VA = "0x1822DD8C0", Slot = "5")]
	public override Action LLJOCHKMPCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void JOJBACOOMAF<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x22DD950", Offset = "0x22DC350", VA = "0x1822DD950")]
	[Preserve]
	public void PDJKIIENPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x22C9C70", Offset = "0x22C8670", VA = "0x1822C9C70")]
	protected PKIBAOHALBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class IMAKAAHALNL : MMANBBEKGCP
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x2185EE0", Offset = "0x21848E0", VA = "0x182185EE0", Slot = "5")]
	public override Action LLJOCHKMPCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void BGMKIFKBFKJ<T>() where T : BIJJBGJKJCO;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x2185F70", Offset = "0x2184970", VA = "0x182185F70")]
	[Preserve]
	public void PDJKIIENPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x2186000", Offset = "0x2184A00", VA = "0x182186000")]
	protected IMAKAAHALNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class IMPFJNKODMP : MMANBBEKGCP
{
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x2186010", Offset = "0x2184A10", VA = "0x182186010", Slot = "5")]
	public override Action LLJOCHKMPCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void GEGAKJIMPHN<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x21860A0", Offset = "0x2184AA0", VA = "0x1821860A0")]
	[Preserve]
	public void PDJKIIENPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2186000", Offset = "0x2184A00", VA = "0x182186000")]
	protected IMPFJNKODMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class CMFFENDMGLO
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x24B28D0", Offset = "0x24B12D0", VA = "0x1824B28D0")]
	public static Entity PCJOPJMDHLD(this EntityManager KACBFFMHDCF)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[OJEJDFBPPED(FHFOPEOFOPD.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class MNFFINPKPJB : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x1B32780", Offset = "0x1B31180", VA = "0x181B32780", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x38ACEC0", Offset = "0x38AB8C0", VA = "0x1838ACEC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x22EB5B0", Offset = "0x22E9FB0", VA = "0x1822EB5B0")]
			[DebuggerHidden]
			public MNFFINPKPJB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x38ACCF0", Offset = "0x38AB6F0", VA = "0x1838ACCF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x38ACE80", Offset = "0x38AB880", VA = "0x1838ACE80", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x38ACDD0", Offset = "0x38AB7D0", VA = "0x1838ACDD0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x38ACDD0", Offset = "0x38AB7D0", VA = "0x1838ACDD0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class KKKFBGCAOIA : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x1B32780", Offset = "0x1B31180", VA = "0x181B32780", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x22EC1B0", Offset = "0x22EABB0", VA = "0x1822EC1B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x22EB5B0", Offset = "0x22E9FB0", VA = "0x1822EB5B0")]
			[DebuggerHidden]
			public KKKFBGCAOIA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x22EC200", Offset = "0x22EAC00", VA = "0x1822EC200", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x22EBED0", Offset = "0x22EA8D0", VA = "0x1822EBED0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x22EC290", Offset = "0x22EAC90", VA = "0x1822EC290")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x22EC170", Offset = "0x22EAB70", VA = "0x1822EC170", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x22EC0C0", Offset = "0x22EAAC0", VA = "0x1822EC0C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x22EC0C0", Offset = "0x22EAAC0", VA = "0x1822EC0C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class EJHBMNKOPIG : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x1B32780", Offset = "0x1B31180", VA = "0x181B32780", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x22EB3F0", Offset = "0x22E9DF0", VA = "0x1822EB3F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x22EB5B0", Offset = "0x22E9FB0", VA = "0x1822EB5B0")]
			[DebuggerHidden]
			public EJHBMNKOPIG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x22EB440", Offset = "0x22E9E40", VA = "0x1822EB440", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x22EAFE0", Offset = "0x22E99E0", VA = "0x1822EAFE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x22EB510", Offset = "0x22E9F10", VA = "0x1822EB510")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x22EB560", Offset = "0x22E9F60", VA = "0x1822EB560")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x22EB3B0", Offset = "0x22E9DB0", VA = "0x1822EB3B0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x22EB310", Offset = "0x22E9D10", VA = "0x1822EB310", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x22EB310", Offset = "0x22E9D10", VA = "0x1822EB310", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2178DF0", Offset = "0x21777F0", VA = "0x182178DF0")]
		public static Entity ILLFLHPGBPK(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2178BC0", Offset = "0x21775C0", VA = "0x182178BC0")]
		public static DynamicBuffer<ChildrenData> HOPEGAKDDHA(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2179930", Offset = "0x2178330", VA = "0x182179930")]
		public static DynamicBuffer<ChildrenData> PEFJADEJIIE(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2178530", Offset = "0x2176F30", VA = "0x182178530")]
		public static NativeArray<Entity> CLENFMPCMMP(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, Allocator FAMNMGKAFPB)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2178660", Offset = "0x2177060", VA = "0x182178660")]
		public static bool EEEKPDCHOIH(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, Allocator FAMNMGKAFPB, out NativeArray<Entity> OAFGJFNHPKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2178E60", Offset = "0x2177860", VA = "0x182178E60")]
		public static NativeArray<Entity> IODHNOMMMMO(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x2179070", Offset = "0x2177A70", VA = "0x182179070")]
		public static Entity LMHHMBOFGOF(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, int NENMOOINMCH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x2178420", Offset = "0x2176E20", VA = "0x182178420")]
		public static int CJDHHAODJFB(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x21796D0", Offset = "0x21780D0", VA = "0x1821796D0")]
		public static void OCAAAEBBMHG(NativeArray<Entity> MBAGNKEDBGA, NativeArray<Entity> DIDIDBBHIMI, EntityManager KACBFFMHDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x21799C0", Offset = "0x21783C0", VA = "0x1821799C0")]
		public static int PODECNBHLCL(this EntityManager KACBFFMHDCF, Entity EGNCPOLPGCD, Entity AHDACGEMPDI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x21788E0", Offset = "0x21772E0", VA = "0x1821788E0")]
		public static bool GGEEMOCPIPE(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, Entity HBDJLMFKBLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2178C50", Offset = "0x2177650", VA = "0x182178C50")]
		public static IEnumerable<Entity> IDDFHLAGAON(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, bool EBLHCCBCAHD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2178FC0", Offset = "0x21779C0", VA = "0x182178FC0")]
		public static bool LCEGNLFANNF(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, Entity AHDACGEMPDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2178A40", Offset = "0x2177440", VA = "0x182178A40")]
		public static bool HADBHNHIDJL(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, Entity BGIPIHJGIOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x2179320", Offset = "0x2177D20", VA = "0x182179320")]
		public static NativeList<Entity> NOFFPEJGJBN(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, bool EBLHCCBCAHD = false, Allocator FAMNMGKAFPB = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x2178760", Offset = "0x2177160", VA = "0x182178760")]
		public static IEnumerable<Entity> FCNKBCKODOP(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, bool EBLHCCBCAHD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x2178AC0", Offset = "0x21774C0", VA = "0x182178AC0")]
		public static Entity HFMIOHHMJCK(this EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x2179530", Offset = "0x2177F30", VA = "0x182179530")]
		public static bool OAKKIMOAAKP(this EntityManager KACBFFMHDCF, Entity BGIPIHJGIOM, Entity ACFAFPAEJAI, out Entity KPPDBEKLBMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x21783A0", Offset = "0x2176DA0", VA = "0x1821783A0")]
		internal static void CCMKPDPFJMC(EntityManager KACBFFMHDCF, Entity EGNCPOLPGCD, Entity AHDACGEMPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x21791A0", Offset = "0x2177BA0", VA = "0x1821791A0")]
		internal static void NBLCMNHBIPM(EntityManager KACBFFMHDCF, Entity EGNCPOLPGCD, Entity AHDACGEMPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x2178230", Offset = "0x2176C30", VA = "0x182178230")]
		[IteratorStateMachine(typeof(MNFFINPKPJB))]
		private static IEnumerable<Entity> BCCIICIAFCM(EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, bool EBLHCCBCAHD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x2178D60", Offset = "0x2177760", VA = "0x182178D60")]
		[IteratorStateMachine(typeof(KKKFBGCAOIA))]
		private static IEnumerable<Entity> IJFKOIDCODF(EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, bool EBLHCCBCAHD = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x21792A0", Offset = "0x2177CA0", VA = "0x1821792A0")]
		[IteratorStateMachine(typeof(EJHBMNKOPIG))]
		private static IEnumerable<Entity> NDJLFONGKGD(EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x21782C0", Offset = "0x2176CC0", VA = "0x1821782C0")]
		private static bool BNHHMIKJALE(EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, Entity HBDJLMFKBLF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[DNKFJNHNNCA(typeof(PHMOCMIEEKH), new string[] { })]
public class LBLLFAMILDF : PHMOCMIEEKH, LMJEAKIHKOP, FOACFLABAOO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private DOMLOFPDLMI KDGPDENJJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private PNLHBOHNCFH MGOGCFMPFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private HIGEHOPBKAJ LHCGGCJEEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private HMMJBABEEJF PADOKDEPFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private LKBGGDFMKHG HDFHOPBBCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private NPDHBLHKCNF IHDGODIAJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private JIMAKGEINEB AKMKADIDNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private OOHJCKLNJKJ BLAKODDBFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private AJHEAAFBPJF CDGNAONMFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private HIOPLOKDODK IBMAMECOFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private BKDLEKAIFKG HBKIBAIBGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private DFFINCJAHNC FDFJIIOLLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private JEGFBKEGILA AHEEFLPCFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private PHBPFOPBBAM BBKHGAFJMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private OAGKEELJIIK MLDHPFBIKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private JGLBDOKINNL DELGALEIEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private PKHFPLBKFGA KPNFEILPOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private GMOEBONBILL FOPIGLELKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private NJHICLMHLEK AFGMBLEFIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private bool HHKBONGDECE;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public DOMLOFPDLMI EBIOAJAGMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public PNLHBOHNCFH AGJOHNHILPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public CAOOBKKGEDI DLPKPCDMEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public HIGEHOPBKAJ OHHJNIMCKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public HMMJBABEEJF PGMABAOIGID
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public PPBLJKKDGPH LFJJOAGMHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x6B0AB0", Offset = "0x6AF4B0", VA = "0x1806B0AB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public LKBGGDFMKHG AMBJBAGEFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6F0", Offset = "0x6AE0F0", VA = "0x1806AF6F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public NPDHBLHKCNF OKCLFFANOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD80", Offset = "0x6AE780", VA = "0x1806AFD80", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public JIMAKGEINEB FCICKMMOJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x6A31C0", Offset = "0x6A1BC0", VA = "0x1806A31C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public OOHJCKLNJKJ BONEKCFKGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D00", Offset = "0x7B7700", VA = "0x1807B8D00", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public AJHEAAFBPJF IBHNLBOOKKK
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x751840", Offset = "0x750240", VA = "0x180751840", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public HIOPLOKDODK PONKIALBJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x6B55C0", Offset = "0x6B3FC0", VA = "0x1806B55C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public BKDLEKAIFKG IBBEOPKNADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x762E40", Offset = "0x761840", VA = "0x180762E40", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public DFFINCJAHNC ODGKNAIJAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x7AD870", Offset = "0x7AC270", VA = "0x1807AD870", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public JEGFBKEGILA GFOGBLPFPHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x7CB580", Offset = "0x7C9F80", VA = "0x1807CB580", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public PHBPFOPBBAM AOKIDCKPMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x6983A0", Offset = "0x696DA0", VA = "0x1806983A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public OAGKEELJIIK AJNEFGFLIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x7602D0", Offset = "0x75ECD0", VA = "0x1807602D0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public JGLBDOKINNL IAKFGKELKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x761310", Offset = "0x75FD10", VA = "0x180761310", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public PKHFPLBKFGA AJKMJMKBPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xA00A40", Offset = "0x9FF440", VA = "0x180A00A40", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public GMOEBONBILL KNLFJHPGJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x9B9C80", Offset = "0x9B8680", VA = "0x1809B9C80", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public NJHICLMHLEK KEAINHPBIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x6A2D60", Offset = "0x6A1760", VA = "0x1806A2D60", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public KGBPMICCNIM PNOLMDACAAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x6EF470", Offset = "0x6EDE70", VA = "0x1806EF470", Slot = "21")]
		get
		{
			return default(KGBPMICCNIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x218FB70", Offset = "0x218E570", VA = "0x18218FB70", Slot = "22")]
	public void IMNJFGBMJOD(DOMLOFPDLMI AIDBEODHFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x1417C70", Offset = "0x1416670", VA = "0x181417C70", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x218FE60", Offset = "0x218E860", VA = "0x18218FE60", Slot = "23")]
	public void MMCJIMCKEID(DOMLOFPDLMI AIDBEODHFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LBLLFAMILDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[DefaultMember("Item")]
public class KBHDHBJAGCB : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class BHCLFGLEKFI : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public KBHDHBJAGCB <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7DBB10", Offset = "0x7DA510", VA = "0x1807DBB10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x38A32A0", Offset = "0x38A1CA0", VA = "0x1838A32A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x78C940", Offset = "0x78B340", VA = "0x18078C940")]
		[DebuggerHidden]
		public BHCLFGLEKFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x38A30F0", Offset = "0x38A1AF0", VA = "0x1838A30F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x38A3260", Offset = "0x38A1C60", VA = "0x1838A3260", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	protected const ulong IGCONKHMDFD = 1uL;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	protected const ulong MJJCDNMEOPM = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	protected const int HLPNEEBGKEG = 8;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	protected const int LDMDDJAJIHD = 6;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public const int DMNBDAMOLEC = 64;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	protected const int JIGBKJIJLIN = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private readonly List<ulong> LJIHDJLMPEK;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x748B70", Offset = "0x747570", VA = "0x180748B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x7FEF20", Offset = "0x7FD920", VA = "0x1807FEF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int MOOABMCOJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4F0", Offset = "0x7D8EF0", VA = "0x1807DA4F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xA15C40", Offset = "0xA14640", VA = "0x180A15C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x2189EF0", Offset = "0x21888F0", VA = "0x182189EF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x2189380", Offset = "0x2187D80", VA = "0x182189380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x218A110", Offset = "0x2188B10", VA = "0x18218A110")]
	public KBHDHBJAGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x218A190", Offset = "0x2188B90", VA = "0x18218A190")]
	public KBHDHBJAGCB(int ODEPOOHCKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x2189540", Offset = "0x2187F40", VA = "0x182189540")]
	public bool CIIMMFLCAHI(int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x2189BD0", Offset = "0x21885D0", VA = "0x182189BD0")]
	public bool LEIIBHJBPLN(int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x21897D0", Offset = "0x21881D0", VA = "0x1821897D0")]
	public bool GAGJDJPANHA(int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x2189530", Offset = "0x2187F30", VA = "0x182189530")]
	public bool CHKFJDOKALL(int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x2189F90", Offset = "0x2188990", VA = "0x182189F90")]
	public void OPNCFHDCNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x218A020", Offset = "0x2188A20", VA = "0x18218A020")]
	public void PNPIFCAINMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x2189CC0", Offset = "0x21886C0", VA = "0x182189CC0")]
	public void LMCGMFHIJLB(int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x2189A80", Offset = "0x2188480", VA = "0x182189A80")]
	public void LCFMPIKHEBH(int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x2189740", Offset = "0x2188140", VA = "0x182189740")]
	public bool EFPDKDNMCDA(int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x2189620", Offset = "0x2188020", VA = "0x182189620")]
	public void DBLOFIEPGFN(int DDIAPGBIJDD, int OOJKDAEFAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x2189850", Offset = "0x2188250", VA = "0x182189850")]
	public void GCLAOBIHLGK(int LFBPKCFMJGF, int GOBOLJKLFOM, int OOJKDAEFAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x2189DB0", Offset = "0x21887B0", VA = "0x182189DB0")]
	public int MJIKPLNABDE(int OOJKDAEFAHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x2189E80", Offset = "0x2188880", VA = "0x182189E80")]
	public int MJIKPLNABDE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2189B80", Offset = "0x2188580", VA = "0x182189B80")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x2189A10", Offset = "0x2188410", VA = "0x182189A10", Slot = "4")]
	[IteratorStateMachine(typeof(BHCLFGLEKFI))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2189A10", Offset = "0x2188410", VA = "0x182189A10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class FNNIOBFLDPI<T> : global::NAJOAEDDKOP<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	protected global::FODAJDNJCCJ<T> FEPANEILBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	protected global::CBBNDKAFNJC<T> DCFAGLLCIJL;

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0xC63980", Offset = "0xC62380", VA = "0x180C63980")]
	public FNNIOBFLDPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x1DE4530", Offset = "0x1DE2F30", VA = "0x181DE4530")]
	public FNNIOBFLDPI(global::FODAJDNJCCJ<T> FEPANEILBKA, global::CBBNDKAFNJC<T> DCFAGLLCIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x1DE3E40", Offset = "0x1DE2840", VA = "0x181DE3E40", Slot = "11")]
	public override T GKBAFEAOLLC(LJNMIBBIFOM MLGGEAMLJNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x1DE4180", Offset = "0x1DE2B80", VA = "0x181DE4180", Slot = "12")]
	public override void NJDODOCIOLN(LJNMIBBIFOM MLGGEAMLJNJ, T NKJMIDIDBOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class PKAJEKJEEKD
{
	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x24D3900", Offset = "0x24D2300", VA = "0x1824D3900")]
	public static ACIALDGCHGB MKIHEFFHNPG<T>(this JKPCBLONCDG CDGNAONMFHE, global::ILAKDLOENDG<T> KKJOOAJGLJI, global::FODAJDNJCCJ<T> FEPANEILBKA, global::CBBNDKAFNJC<T> DCFAGLLCIJL) where T : struct
	{
		return default(ACIALDGCHGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class ADINHBAIAED<T> : global::FNNIOBFLDPI<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2E5BF50", Offset = "0x2E5A950", VA = "0x182E5BF50")]
	public ADINHBAIAED(T IGJJHEFOMKI, T FMFHKMBBDJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class JJJFAIFLBCF<T> : global::NAJOAEDDKOP<T> where T : struct, BIJJBGJKJCO
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x2D98AC0", Offset = "0x2D974C0", VA = "0x182D98AC0", Slot = "11")]
	public override T GKBAFEAOLLC(LJNMIBBIFOM MLGGEAMLJNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x2D98BB0", Offset = "0x2D975B0", VA = "0x182D98BB0", Slot = "12")]
	public override void NJDODOCIOLN(LJNMIBBIFOM MLGGEAMLJNJ, T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x19F9130", Offset = "0x19F7B30", VA = "0x1819F9130")]
	public JJJFAIFLBCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public abstract class HEBNDNJADHO : FHCLLHPGGMP
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public abstract Type GFAMNJFMLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void GKBAFEAOLLC(LJNMIBBIFOM MLGGEAMLJNJ, in FPKEMMGAFGA NKJMIDIDBOE);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void NJDODOCIOLN(LJNMIBBIFOM MLGGEAMLJNJ, in DCNFIHFHOLK NKJMIDIDBOE);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void KILJMGBLKDF(LJNMIBBIFOM MLGGEAMLJNJ, LGGLNDEOAPN HKHJFOAGFPO, [Optional] object ABFHDOGCMDC);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	protected HEBNDNJADHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public abstract class NAJOAEDDKOP<T> : HEBNDNJADHO where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override Type GFAMNJFMLLK
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x1E797D0", Offset = "0x1E781D0", VA = "0x181E797D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T GKBAFEAOLLC(LJNMIBBIFOM MLGGEAMLJNJ);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void NJDODOCIOLN(LJNMIBBIFOM MLGGEAMLJNJ, T NKJMIDIDBOE);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x1E77150", Offset = "0x1E75B50", VA = "0x181E77150", Slot = "8")]
	public override void GKBAFEAOLLC(LJNMIBBIFOM MLGGEAMLJNJ, in FPKEMMGAFGA HGJMJLMOCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x1E788B0", Offset = "0x1E772B0", VA = "0x181E788B0", Slot = "9")]
	public override void NJDODOCIOLN(LJNMIBBIFOM MLGGEAMLJNJ, in DCNFIHFHOLK JAKENEGIGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x1E77B50", Offset = "0x1E76550", VA = "0x181E77B50", Slot = "10")]
	public override void KILJMGBLKDF(LJNMIBBIFOM MLGGEAMLJNJ, LGGLNDEOAPN HKHJFOAGFPO, object ABFHDOGCMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x7CF650", Offset = "0x7CE050", VA = "0x1807CF650")]
	protected NAJOAEDDKOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class EJBGNJFIGIH
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class BBMNIEHPENF
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class CFMCMLJFELO<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
			public CFMCMLJFELO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x2288250", Offset = "0x2286C50", VA = "0x182288250")]
			internal void <RegisterFixedString>b__0(LJNMIBBIFOM p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x2288570", Offset = "0x2286F70", VA = "0x182288570")]
			internal T <RegisterFixedString>b__1(LJNMIBBIFOM p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x22EA190", Offset = "0x22E8B90", VA = "0x1822EA190")]
		public static void MDBFKNJLMLB(BICKABIPEGP LAOKKABHFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x1F25DB0", Offset = "0x1F247B0", VA = "0x181F25DB0")]
		private static void ONLLDPCDBPI<T>(BICKABIPEGP LAOKKABHFCD, int FMFHKMBBDJC) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x1F256D0", Offset = "0x1F240D0", VA = "0x181F256D0")]
		private static void NPFPFCGKLBF<T>(LJNMIBBIFOM JEHKGNEAMEK, T LNKDDMNNFGJ, int FMFHKMBBDJC) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x1F25760", Offset = "0x1F24160", VA = "0x181F25760")]
		private static T OBCNFFBKMEJ<T>(LJNMIBBIFOM JEHKGNEAMEK, int FMFHKMBBDJC) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public BBMNIEHPENF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class IIOMDLIKKMG : PKIBAOHALBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private BICKABIPEGP LAOKKABHFCD;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x1F3AA10", Offset = "0x1F39410", VA = "0x181F3AA10", Slot = "6")]
		public override void JOJBACOOMAF<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x22EB8D0", Offset = "0x22EA2D0", VA = "0x1822EB8D0")]
		public static void KLPMDHLLPCG(BICKABIPEGP LAOKKABHFCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x2186000", Offset = "0x2184A00", VA = "0x182186000")]
		public IIOMDLIKKMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x24C3A60", Offset = "0x24C2460", VA = "0x1824C3A60")]
	public static void HNAIOIPPGFN(BICKABIPEGP LAOKKABHFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x10EFB00", Offset = "0x10EE500", VA = "0x1810EFB00")]
	public static void HNCPOAMBEOP<T>(BICKABIPEGP LAOKKABHFCD, global::FODAJDNJCCJ<T> FEPANEILBKA, global::CBBNDKAFNJC<T> DCFAGLLCIJL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x10EFB90", Offset = "0x10EE590", VA = "0x1810EFB90")]
	public static void MPHHOPFPNGD<T>(BICKABIPEGP CGNILOEHIHM) where T : struct, BIJJBGJKJCO
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
public interface BICKABIPEGP : global::HJONKFHDCKM<BICKABIPEGP>
{
	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKIHEFFHNPG(Type NFMPIOLJBMO, FHCLLHPGGMP CGNILOEHIHM);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FJMGOOAKNCK(Type NFMPIOLJBMO, out FHCLLHPGGMP CGNILOEHIHM);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class MMNIHKDDMIJ
{
	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x22CA0C0", Offset = "0x22C8AC0", VA = "0x1822CA0C0")]
	public static void MKIHEFFHNPG(this BICKABIPEGP NGMBPANACIN, FHCLLHPGGMP CGNILOEHIHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[DNKFJNHNNCA(typeof(JKPCBLONCDG), new string[] { })]
public sealed class HMDKNKOCDKH : JKPCBLONCDG, global::HJONKFHDCKM<JKPCBLONCDG>, AHDDAOHEFAN, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly Dictionary<ACIALDGCHGB, FHCLLHPGGMP> LAOKKABHFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private BICKABIPEGP KEFGDPNKAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private AMNDMACHLPL CDGNAONMFHE;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool CCEEFOOHPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x799F80", Offset = "0x798980", VA = "0x180799F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x799F70", Offset = "0x798970", VA = "0x180799F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x2181690", Offset = "0x2180090", VA = "0x182181690")]
	public HMDKNKOCDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x21815D0", Offset = "0x217FFD0", VA = "0x1821815D0")]
	public HMDKNKOCDKH(Dictionary<ACIALDGCHGB, FHCLLHPGGMP> LAOKKABHFCD, bool MGONBBKMJNN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x2181400", Offset = "0x217FE00", VA = "0x182181400", Slot = "7")]
	public void LMBJCLDJBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x2180FD0", Offset = "0x217F9D0", VA = "0x182180FD0", Slot = "8")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x21813B0", Offset = "0x217FDB0", VA = "0x1821813B0", Slot = "9")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x2181200", Offset = "0x217FC00", VA = "0x182181200", Slot = "4")]
	public ACIALDGCHGB GLHOBNMGKBO(GMGAEIHDIEM KKJOOAJGLJI)
	{
		return default(ACIALDGCHGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x2181460", Offset = "0x217FE60", VA = "0x182181460", Slot = "5")]
	public void MKIHEFFHNPG(ACIALDGCHGB ENFGKNDHLNI, FHCLLHPGGMP CGNILOEHIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2180E90", Offset = "0x217F890", VA = "0x182180E90")]
	[Conditional("DEBUG_BUILD")]
	private void BPDLCCHOBOH(ACIALDGCHGB ENFGKNDHLNI, Type NFMPIOLJBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x2181050", Offset = "0x217FA50", VA = "0x182181050", Slot = "6")]
	public bool FJMGOOAKNCK(ACIALDGCHGB ENFGKNDHLNI, out FHCLLHPGGMP CGNILOEHIHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x21812D0", Offset = "0x217FCD0", VA = "0x1821812D0", Slot = "10")]
	public JKPCBLONCDG JIIFMJMHMHI()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[DNKFJNHNNCA(typeof(BICKABIPEGP), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.TypeSerializer)]
	public sealed class TypeSerializerService : AHDDAOHEFAN, BICKABIPEGP, global::HJONKFHDCKM<BICKABIPEGP>
	{
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly Dictionary<Type, FHCLLHPGGMP> LAOKKABHFCD;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public bool CCEEFOOHPMC
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x7F5D60", Offset = "0x7F4760", VA = "0x1807F5D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x881D10", Offset = "0x880710", VA = "0x180881D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x22FE5D0", Offset = "0x22FCFD0", VA = "0x1822FE5D0")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x22FE650", Offset = "0x22FD050", VA = "0x1822FE650")]
		public TypeSerializerService(Dictionary<Type, FHCLLHPGGMP> LAOKKABHFCD, bool MGONBBKMJNN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x22FE400", Offset = "0x22FCE00", VA = "0x1822FE400", Slot = "4")]
		public void LMBJCLDJBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x22FE460", Offset = "0x22FCE60", VA = "0x1822FE460", Slot = "5")]
		public void MKIHEFFHNPG(Type NFMPIOLJBMO, FHCLLHPGGMP CGNILOEHIHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x22FE240", Offset = "0x22FCC40", VA = "0x1822FE240", Slot = "6")]
		public bool FJMGOOAKNCK(Type NFMPIOLJBMO, out FHCLLHPGGMP CGNILOEHIHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x22FE320", Offset = "0x22FCD20", VA = "0x1822FE320", Slot = "7")]
		public BICKABIPEGP JIIFMJMHMHI()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[DNKFJNHNNCA(typeof(ACFKJOHHEBJ), new string[] { })]
internal sealed class MMHGDCMDAFG : ACFKJOHHEBJ, AHDDAOHEFAN, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly Dictionary<ACIALDGCHGB, DCJHJOINOKK> NAAHMKPLOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private AMNDMACHLPL CDGNAONMFHE;

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x22C9F10", Offset = "0x22C8910", VA = "0x1822C9F10", Slot = "6")]
	public void LMBJCLDJBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x22C9EB0", Offset = "0x22C88B0", VA = "0x1822C9EB0", Slot = "7")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x22C9F60", Offset = "0x22C8960", VA = "0x1822C9F60", Slot = "4")]
	public void MKIHEFFHNPG(ACIALDGCHGB EDNCKFCJECD, Type HLNHGPNEMNL, DCJHJOINOKK KNNNLOEHHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x22C9FD0", Offset = "0x22C89D0", VA = "0x1822C9FD0", Slot = "5")]
	public bool NGBPHIKJCCB(ACIALDGCHGB EDNCKFCJECD, out DCJHJOINOKK KNNNLOEHHPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x22C9D20", Offset = "0x22C8720", VA = "0x1822C9D20")]
	[Conditional("DEBUG_BUILD")]
	private void DBFPKNDOAGB(ACIALDGCHGB EDNCKFCJECD, Type HLNHGPNEMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x22CA040", Offset = "0x22C8A40", VA = "0x1822CA040")]
	public MMHGDCMDAFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[DNKFJNHNNCA(typeof(DGNBGDLCOMI), new string[] { })]
internal sealed class LDNBJEBMLEE : DGNBGDLCOMI, OKCOAIBIMKN, AHDDAOHEFAN, CFMOGGHLNDM, BGKGLCNGELH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private readonly KBHDHBJAGCB GFPJFCPABIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private readonly Dictionary<DPCBAIHHPOK, int> KLLJIBAHLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly Stack<int> OIDNECGADAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	[MJIDFIFGMKP]
	private AMNDMACHLPL CDGNAONMFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	[MJIDFIFGMKP]
	private PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private int POAKAPBIBLC
	{
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2190330", Offset = "0x218ED30", VA = "0x182190330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool KKNNLAGAGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F1260", Offset = "0x7EFC60", VA = "0x1807F1260", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F1650", Offset = "0x7F0050", VA = "0x1807F1650", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x21901F0", Offset = "0x218EBF0", VA = "0x1821901F0", Slot = "6")]
	public void LMBJCLDJBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2190030", Offset = "0x218EA30", VA = "0x182190030", Slot = "7")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x21906D0", Offset = "0x218F0D0", VA = "0x1821906D0", Slot = "8")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x218FF90", Offset = "0x218E990", VA = "0x18218FF90")]
	private void COKHGGJFNDG(CAMBCDMDDIB BCJDDLNACAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x21900B0", Offset = "0x218EAB0", VA = "0x1821900B0", Slot = "4")]
	public bool DPNIOMHFNJM(DPCBAIHHPOK PKBNFFGFIEN, ACIALDGCHGB GNIPEANGOCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2190380", Offset = "0x218ED80", VA = "0x182190380", Slot = "5")]
	public void MBBNGGLANFD(DPCBAIHHPOK PKBNFFGFIEN, Span<ACIALDGCHGB> CDGNAONMFHE, bool CCAFMGCHDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x21901F0", Offset = "0x218EBF0", VA = "0x1821901F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x2190780", Offset = "0x218F180", VA = "0x182190780")]
	public LDNBJEBMLEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class LKFIOKJICIB
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2194030", Offset = "0x2192A30", VA = "0x182194030")]
	public static void FLPNHCEOIMF(this LJNMIBBIFOM MLGGEAMLJNJ, ReadOnlyMemory<byte> DKNHLKBLGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x25F5420", Offset = "0x25F3E20", VA = "0x1825F5420")]
	public static void ODGEDKELGPM<T>(this LJNMIBBIFOM MLGGEAMLJNJ, in T NKJMIDIDBOE) where T : struct, BIJJBGJKJCO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x25F5550", Offset = "0x25F3F50", VA = "0x1825F5550")]
	public static T OJNLAEHDGBI<T>(this LJNMIBBIFOM MLGGEAMLJNJ) where T : struct, BIJJBGJKJCO
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x2194290", Offset = "0x2192C90", VA = "0x182194290")]
	public static void ODGEDKELGPM(this LJNMIBBIFOM MLGGEAMLJNJ, NHOCPCEJFNN OECDMCKDPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x21940B0", Offset = "0x2192AB0", VA = "0x1821940B0")]
	public static NHOCPCEJFNN HKEDJJGPCGI(this LJNMIBBIFOM MLGGEAMLJNJ)
	{
		return default(NHOCPCEJFNN);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x21940E0", Offset = "0x2192AE0", VA = "0x1821940E0")]
	public static void OBBMJBMLJIP(this LJNMIBBIFOM HENKIMNGBED, uint BPJFONPFFPA, bool KFJNNPLHMOO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x2193F10", Offset = "0x2192910", VA = "0x182193F10")]
	public static uint EFFJPIAHFCE(this LJNMIBBIFOM LDHEAKJHCED, bool KFJNNPLHMOO = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class EGMHANKDNLH
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class ONIDKGCNEEM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public ONIDKGCNEEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7200", Offset = "0x3BD5C00", VA = "0x183BD7200")]
		internal void <GetByteEnumDelegates>b__0(LJNMIBBIFOM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x3BD7270", Offset = "0x3BD5C70", VA = "0x183BD7270")]
		internal T <GetByteEnumDelegates>b__1(LJNMIBBIFOM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class KKJOHFHMGOI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public KKJOHFHMGOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x27C85A0", Offset = "0x27C6FA0", VA = "0x1827C85A0")]
		internal void <GetSByteEnumDelegates>b__0(LJNMIBBIFOM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x27C8610", Offset = "0x27C7010", VA = "0x1827C8610")]
		internal T <GetSByteEnumDelegates>b__1(LJNMIBBIFOM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class CKBMHLJFFPF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public CKBMHLJFFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x229BA30", Offset = "0x229A430", VA = "0x18229BA30")]
		internal void <GetShortEnumDelegates>b__0(LJNMIBBIFOM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x229BAA0", Offset = "0x229A4A0", VA = "0x18229BAA0")]
		internal T <GetShortEnumDelegates>b__1(LJNMIBBIFOM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class CHJBLHBBJJB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public CHJBLHBBJJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2289B70", Offset = "0x2288570", VA = "0x182289B70")]
		internal void <GetUShortEnumDelegates>b__0(LJNMIBBIFOM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x2289BE0", Offset = "0x22885E0", VA = "0x182289BE0")]
		internal T <GetUShortEnumDelegates>b__1(LJNMIBBIFOM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class LAGIOLMBIIJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public LAGIOLMBIIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x1B69880", Offset = "0x1B68280", VA = "0x181B69880")]
		internal void <GetIntEnumDelegates>b__0(LJNMIBBIFOM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x1B698E0", Offset = "0x1B682E0", VA = "0x181B698E0")]
		internal T <GetIntEnumDelegates>b__1(LJNMIBBIFOM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class EKEHBJCBFMI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		public EKEHBJCBFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x268CDC0", Offset = "0x268B7C0", VA = "0x18268CDC0")]
		internal void <GetUIntEnumDelegates>b__0(LJNMIBBIFOM b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x268CE20", Offset = "0x268B820", VA = "0x18268CE20")]
		internal T <GetUIntEnumDelegates>b__1(LJNMIBBIFOM b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x10EF8E0", Offset = "0x10EE2E0", VA = "0x1810EF8E0")]
	public static void OIKNDMHBLNE<T>(T IGJJHEFOMKI, T FMFHKMBBDJC, out global::FODAJDNJCCJ<T> KAHJPODFOCO, out global::CBBNDKAFNJC<T> GKPBEIBNFPO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x10EF790", Offset = "0x10EE190", VA = "0x1810EF790")]
	private static void IBFHHLLMDIH<T>(T IGJJHEFOMKI, T FMFHKMBBDJC, out global::FODAJDNJCCJ<T> KAHJPODFOCO, out global::CBBNDKAFNJC<T> GKPBEIBNFPO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x10EF790", Offset = "0x10EE190", VA = "0x1810EF790")]
	private static void JGFHGKJMJIA<T>(T IGJJHEFOMKI, T FMFHKMBBDJC, out global::FODAJDNJCCJ<T> KAHJPODFOCO, out global::CBBNDKAFNJC<T> GKPBEIBNFPO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x10EF4F0", Offset = "0x10EDEF0", VA = "0x1810EF4F0")]
	private static void DNJGHFNMFGH<T>(T IGJJHEFOMKI, T FMFHKMBBDJC, out global::FODAJDNJCCJ<T> KAHJPODFOCO, out global::CBBNDKAFNJC<T> GKPBEIBNFPO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x10EF4F0", Offset = "0x10EDEF0", VA = "0x1810EF4F0")]
	private static void NLJMLNIOLDO<T>(T IGJJHEFOMKI, T FMFHKMBBDJC, out global::FODAJDNJCCJ<T> KAHJPODFOCO, out global::CBBNDKAFNJC<T> GKPBEIBNFPO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x10EF640", Offset = "0x10EE040", VA = "0x1810EF640")]
	private static void JHNJDMDKIFP<T>(T IGJJHEFOMKI, T FMFHKMBBDJC, out global::FODAJDNJCCJ<T> KAHJPODFOCO, out global::CBBNDKAFNJC<T> GKPBEIBNFPO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x10EF640", Offset = "0x10EE040", VA = "0x1810EF640")]
	private static void HECADEKJFEO<T>(T IGJJHEFOMKI, T FMFHKMBBDJC, out global::FODAJDNJCCJ<T> KAHJPODFOCO, out global::CBBNDKAFNJC<T> GKPBEIBNFPO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class JBKCHHJMHPN : LKCPANANAIJ, BGKGLCNGELH
{
	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x21866C0", Offset = "0x21850C0", VA = "0x1821866C0", Slot = "4")]
	private void CPJDNAKAOHB(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void EOMDJLJMJJF(JKPCBLONCDG CDGNAONMFHE);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
	protected JBKCHHJMHPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[KKLLFLCMAAC(typeof(LocalPoseData))]
public sealed class NOEHDBCDGPH : JBKCHHJMHPN
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x22CC460", Offset = "0x22CAE60", VA = "0x1822CC460", Slot = "5")]
	protected override void EOMDJLJMJJF(JKPCBLONCDG CDGNAONMFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0")]
	public NOEHDBCDGPH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.Scope)]
	internal class CopyAuthorityToEntity : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private PNLHBOHNCFH MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private EntityQuery BEFOBPJPFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private EntityQuery GCKMHDKPJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private EntityQuery GBANNBPMDKN;

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x24BBB80", Offset = "0x24BA580", VA = "0x1824BBB80", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x24BC490", Offset = "0x24BAE90", VA = "0x1824BC490", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x24BC610", Offset = "0x24BB010", VA = "0x1824BC610", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x24BC5E0", Offset = "0x24BAFE0", VA = "0x1824BC5E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x24BBBF0", Offset = "0x24BA5F0", VA = "0x1824BBBF0")]
		private void FMMJCIKCJON(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x24BBF30", Offset = "0x24BA930", VA = "0x1824BBF30")]
		private void HPFLGBEONGN(NativeArray<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x24BB7C0", Offset = "0x24BA1C0", VA = "0x1824BB7C0")]
		private void ADNPAGKJNCC(NativeArray<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x24BC2E0", Offset = "0x24BACE0", VA = "0x1824BC2E0")]
		private void MIJNEPMFOKK(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x24BC0D0", Offset = "0x24BAAD0", VA = "0x1824BC0D0")]
		private void IKAANNGBHPH(NativeArray<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x24BBAA0", Offset = "0x24BA4A0", VA = "0x1824BBAA0")]
		private void CONDGOFGJNA(CAMBCDMDDIB BCJDDLNACAB, int GGLJLEEFAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class DNNBCDPEIFI : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private EntityQuery NBKDJEEFFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private PNLHBOHNCFH MGOGCFMPFGO;

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x24BFFA0", Offset = "0x24BE9A0", VA = "0x1824BFFA0", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x24C05D0", Offset = "0x24BEFD0", VA = "0x1824C05D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x24C0690", Offset = "0x24BF090", VA = "0x1824C0690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x24BFFF0", Offset = "0x24BE9F0", VA = "0x1824BFFF0")]
	private void LGFNBHKMEPG(NativeArray<Entity> GBNPHFOKMOH, NativeList<Entity> AFKHMNNLACF, ComponentDataFromEntity<PHJKBFECKLM> BEKLOCMEFNA, BufferFromEntity<ChildrenData> FACHIDNNIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public DNNBCDPEIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class KDIFLPAHIOD : ParentSystemBase<AuthoredParentData, EBOBIFNOFII, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x218A680", Offset = "0x2189080", VA = "0x18218A680", Slot = "14")]
	protected override EntityQueryDesc GFADHLPEKBJ(EntityQueryDesc NBKDJEEFFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x8CBA70", Offset = "0x8CA470", VA = "0x1808CBA70", Slot = "15")]
	protected override EntityQueryDesc IMJBMAOCCED(EntityQueryDesc NBKDJEEFFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x218A640", Offset = "0x2189040", VA = "0x18218A640", Slot = "16")]
	protected override EntityQueryDesc AHCKKGDLMAL(EntityQueryDesc NBKDJEEFFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x218A6C0", Offset = "0x21890C0", VA = "0x18218A6C0", Slot = "17")]
	protected override EntityQueryDesc GLCNGDFMPIA(EntityQueryDesc NBKDJEEFFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x218A740", Offset = "0x2189140", VA = "0x18218A740")]
	public KDIFLPAHIOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x218A700", Offset = "0x2189100", VA = "0x18218A700", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class CBIMADIJIBE : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private EntityQuery NBKDJEEFFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private object HCIGEKENAMK;

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x24B1950", Offset = "0x24B0350", VA = "0x1824B1950", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x24B19D0", Offset = "0x24B03D0", VA = "0x1824B19D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x24B1A70", Offset = "0x24B0470", VA = "0x1824B1A70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public CBIMADIJIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class MPEBHMFAEDA : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery NBKDJEEFFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private object HCIGEKENAMK;

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x22CA1C0", Offset = "0x22C8BC0", VA = "0x1822CA1C0", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x22CA240", Offset = "0x22C8C40", VA = "0x1822CA240", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x22CA2E0", Offset = "0x22C8CE0", VA = "0x1822CA2E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public MPEBHMFAEDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[InternalBufferCapacity(1)]
internal struct HCKAGABHFIE : ISystemStateBufferElementData, IBufferElementData, IEquatable<HCKAGABHFIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public MHKOMGONDLI LGNELGFKAEP;

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x2180CB0", Offset = "0x217F6B0", VA = "0x182180CB0", Slot = "4")]
	public bool Equals(HCKAGABHFIE BPKBHFMGOOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450")]
	public static HCKAGABHFIE MFJMDPBHOLK(MHKOMGONDLI LGNELGFKAEP)
	{
		return default(HCKAGABHFIE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[InternalBufferCapacity(4)]
internal struct DIABJLCHNBP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public MHKOMGONDLI LGNELGFKAEP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450")]
	public static DIABJLCHNBP MFJMDPBHOLK(MHKOMGONDLI LGNELGFKAEP)
	{
		return default(DIABJLCHNBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal abstract class EFBJOLGCKOD : CJKFPNFOLGO
{
	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x24C2D00", Offset = "0x24C1700", VA = "0x1824C2D00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x24C2E90", Offset = "0x24C1890", VA = "0x1824C2E90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	protected EFBJOLGCKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[NIHNMLIMMAM]
internal abstract class CJKFPNFOLGO : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	protected EntityQuery NBKDJEEFFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	protected PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	protected NJHICLMHLEK AFGMBLEFIEH;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	protected abstract CJMIBPFJIDF MHFKBLIHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x24B1FE0", Offset = "0x24B09E0", VA = "0x1824B1FE0", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x24B2050", Offset = "0x24B0A50", VA = "0x1824B2050")]
	protected void FLIKNOEDOLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x24B22D0", Offset = "0x24B0CD0", VA = "0x1824B22D0")]
	protected void OEAHNFKEPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x24B1F70", Offset = "0x24B0970", VA = "0x1824B1F70")]
	protected OIAFHGFMCMO CLJLKPCLNHJ()
	{
		return default(OIAFHGFMCMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	protected CJKFPNFOLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal abstract class LNFHMOCOBEJ : CJKFPNFOLGO
{
	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x2195080", Offset = "0x2193A80", VA = "0x182195080", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x2195210", Offset = "0x2193C10", VA = "0x182195210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x217AB30", Offset = "0x2179530", VA = "0x18217AB30")]
	protected LNFHMOCOBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class BBBFMECPIKG : CJKFPNFOLGO
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x24AD520", Offset = "0x24ABF20", VA = "0x1824AD520", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x24AD630", Offset = "0x24AC030", VA = "0x1824AD630", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	protected BBBFMECPIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class FENNDOFFKDH : EFBJOLGCKOD
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected override CJMIBPFJIDF MHFKBLIHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x217AAC0", Offset = "0x21794C0", VA = "0x18217AAC0", Slot = "15")]
		get
		{
			return default(CJMIBPFJIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x217AB30", Offset = "0x2179530", VA = "0x18217AB30")]
	public FENNDOFFKDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class MIFAMCBCEMO : LNFHMOCOBEJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected override CJMIBPFJIDF MHFKBLIHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x22C9320", Offset = "0x22C7D20", VA = "0x1822C9320", Slot = "15")]
		get
		{
			return default(CJMIBPFJIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x22C9390", Offset = "0x22C7D90", VA = "0x1822C9390")]
	public MIFAMCBCEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x217AB30", Offset = "0x2179530", VA = "0x18217AB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class EBABNGEHHJG : BBBFMECPIKG
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected override CJMIBPFJIDF MHFKBLIHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x24C1EF0", Offset = "0x24C08F0", VA = "0x1824C1EF0", Slot = "15")]
		get
		{
			return default(CJMIBPFJIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public EBABNGEHHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class BHGHMCJNHLO : EFBJOLGCKOD
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override CJMIBPFJIDF MHFKBLIHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x24AE360", Offset = "0x24ACD60", VA = "0x1824AE360", Slot = "15")]
		get
		{
			return default(CJMIBPFJIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public BHGHMCJNHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class EOCCJNGMFEN : LNFHMOCOBEJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override CJMIBPFJIDF MHFKBLIHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x24C54C0", Offset = "0x24C3EC0", VA = "0x1824C54C0", Slot = "15")]
		get
		{
			return default(CJMIBPFJIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x22C9390", Offset = "0x22C7D90", VA = "0x1822C9390")]
	public EOCCJNGMFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x217AB30", Offset = "0x2179530", VA = "0x18217AB30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class LJEJNNCBGMD : BBBFMECPIKG
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override CJMIBPFJIDF MHFKBLIHCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x2193040", Offset = "0x2191A40", VA = "0x182193040", Slot = "15")]
		get
		{
			return default(CJMIBPFJIDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x217AB30", Offset = "0x2179530", VA = "0x18217AB30")]
	public LJEJNNCBGMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct CECIKODEJEN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal struct NFGDMLNPKPO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct PBKNEMHPBPL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly struct CJMIBPFJIDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly ComponentType FHGGMAKHJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly ComponentType AGLFMMDCNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly object KBCPLDFOJJL;

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x24B27D0", Offset = "0x24B11D0", VA = "0x1824B27D0")]
	public CJMIBPFJIDF(ComponentType FHGGMAKHJCA, ComponentType AGLFMMDCNDH, object KBCPLDFOJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x1E1F400", Offset = "0x1E1DE00", VA = "0x181E1F400")]
	public static CJMIBPFJIDF HNGCPLMFKDM<TReq, TTag>(object KBCPLDFOJJL)
	{
		return default(CJMIBPFJIDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class CMGCOLLMPNC
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public const string AHEAGIHMHLP = "Parented";

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public const string CLFHGPHEEMP = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly CJMIBPFJIDF IAKFGKELKGO;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly CJMIBPFJIDF HKEGCBBBKJF;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct MHKOMGONDLI : global::MDCCNADMIFA<MHKOMGONDLI>, AMGKOAKLCKE, IEquatable<MHKOMGONDLI>
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public int HMIPEGLEEME
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x7608C0", Offset = "0x75F2C0", VA = "0x1807608C0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x760940", Offset = "0x75F340", VA = "0x180760940", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public int MIEMBAEOINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x18486F0", Offset = "0x18470F0", VA = "0x1818486F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x1848730", Offset = "0x1847130", VA = "0x181848730", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool CHKFJDOKALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x22C9240", Offset = "0x22C7C40", VA = "0x1822C9240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x22C9280", Offset = "0x22C7C80", VA = "0x1822C9280", Slot = "8")]
	public bool Equals(MHKOMGONDLI BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x22C92D0", Offset = "0x22C7CD0", VA = "0x1822C92D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[NIHNMLIMMAM]
	[OJEJDFBPPED(FHFOPEOFOPD.Connectables)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	public class UpdateConnectableVisuals : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private struct LBJJDFDAIID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public MHKOMGONDLI LGNELGFKAEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public float3 NHDHEIIIBBI;

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x38AC560", Offset = "0x38AAF60", VA = "0x1838AC560")]
			public LBJJDFDAIID(MHKOMGONDLI LGNELGFKAEP, float3 NHDHEIIIBBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x38AC540", Offset = "0x38AAF40", VA = "0x1838AC540")]
			public void JFJMGCLPGME(out MHKOMGONDLI LGNELGFKAEP, out float3 NHDHEIIIBBI)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private struct HHDAPCFCPAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public NativeList<LBJJDFDAIID> list;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
			public HHDAPCFCPAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<DIABJLCHNBP> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private struct MJKAOFHPLBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public NativeList<LBJJDFDAIID> list;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
			public MJKAOFHPLBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<HCKAGABHFIE> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private struct HCPKMDPHIPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public NativeList<LBJJDFDAIID> list;

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
			public HCPKMDPHIPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in NOOMLOHPIEM com, in DynamicBuffer<HCKAGABHFIE> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct GBJMJADELGG : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E2")]
			private struct NFKMIAMIJCC
			{
				[Cpp2IlInjected.Token(Token = "0x20000E3")]
				public struct EINAHJNGGNH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BE")]
					public LambdaParameterValueProvider_Entity.Runtime BFDIEBHDBHA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002BF")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime IFJJOEKPFHN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002C0")]
					public LambdaParameterValueProvider_DynamicBuffer<DIABJLCHNBP>.Runtime EKAFANLEJNH;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002BB")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity OLNAEIIEBBK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002BC")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> GKGIDFEDONH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002BD")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<DIABJLCHNBP> BEBBAANKNJJ;

				[Cpp2IlInjected.Token(Token = "0x600077D")]
				[Cpp2IlInjected.Address(RVA = "0x38AD380", Offset = "0x38ABD80", VA = "0x1838AD380")]
				public void JPLJMLJGDEA(UpdateConnectableVisuals PKCOGNBINGO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077E")]
				[Cpp2IlInjected.Address(RVA = "0x38AD2C0", Offset = "0x38ABCC0", VA = "0x1838AD2C0")]
				public EINAHJNGGNH AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
				{
					return default(EINAHJNGGNH);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public UpdateConnectableVisuals AEFKMLCAHOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public NativeList<LBJJDFDAIID> AMMGMIDPNEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			private NFKMIAMIJCC OOLCPOANPDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NFKMIAMIJCC.EINAHJNGGNH* BMEFAIJKJIP;

			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OAOBLPGJBCM;

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x38A5D90", Offset = "0x38A4790", VA = "0x1838A5D90")]
			internal void GJIGCKOOEBM(Entity EBOGCLNNJGN, WorldPoseData KNEPODFFADN, in DynamicBuffer<DIABJLCHNBP> LPLEHOMFOKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x38A61C0", Offset = "0x38A4BC0", VA = "0x1838A61C0", Slot = "5")]
			public void ReadFromDisplayClass(ref HHDAPCFCPAM AEILCDAFCEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x38A61F0", Offset = "0x38A4BF0", VA = "0x1838A61F0", Slot = "6")]
			public void WriteToDisplayClass(ref HHDAPCFCPAM AEILCDAFCEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x38A5CB0", Offset = "0x38A46B0", VA = "0x1838A5CB0", Slot = "4")]
			public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x38A6080", Offset = "0x38A4A80", VA = "0x1838A6080")]
			public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, ref NFKMIAMIJCC.EINAHJNGGNH AFHMNGPOKJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x38A5FD0", Offset = "0x38A49D0", VA = "0x1838A5FD0")]
			public void JPLJMLJGDEA(UpdateConnectableVisuals PKCOGNBINGO, ref HHDAPCFCPAM AEILCDAFCEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x38A6010", Offset = "0x38A4A10", VA = "0x1838A6010")]
			public unsafe static void KALMFPFGGJA(ArchetypeChunkIterator* OKNKNNMFMKI, void* EBLJDNAFJJC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct BFMPAOPFEBO : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct GIAPBKMDMAP
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				[NoAlias]
				public struct EKEEKMGIMIC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime IFJJOEKPFHN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<HCKAGABHFIE>.Runtime EKAFANLEJNH;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002C4")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> GKGIDFEDONH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002C5")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<HCKAGABHFIE> BEBBAANKNJJ;

				[Cpp2IlInjected.Token(Token = "0x6000784")]
				[Cpp2IlInjected.Address(RVA = "0x38A6800", Offset = "0x38A5200", VA = "0x1838A6800")]
				public void JPLJMLJGDEA(UpdateConnectableVisuals PKCOGNBINGO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x38A6760", Offset = "0x38A5160", VA = "0x1838A6760")]
				public EKEEKMGIMIC AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
				{
					return default(EKEEKMGIMIC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public NativeList<LBJJDFDAIID> AMMGMIDPNEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			private GIAPBKMDMAP OOLCPOANPDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe GIAPBKMDMAP.EKEEKMGIMIC* BMEFAIJKJIP;

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x38A2B80", Offset = "0x38A1580", VA = "0x1838A2B80")]
			internal void GJIGCKOOEBM(in WorldPoseData KNEPODFFADN, in DynamicBuffer<HCKAGABHFIE> LPLEHOMFOKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x22ECD80", Offset = "0x22EB780", VA = "0x1822ECD80", Slot = "5")]
			public void ReadFromDisplayClass(ref MJKAOFHPLBK AEILCDAFCEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x38A2AB0", Offset = "0x38A14B0", VA = "0x1838A2AB0", Slot = "4")]
			public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x38A2D30", Offset = "0x38A1730", VA = "0x1838A2D30")]
			public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, [NoAlias] ref GIAPBKMDMAP.EKEEKMGIMIC AFHMNGPOKJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x38A2C90", Offset = "0x38A1690", VA = "0x1838A2C90")]
			public void JPLJMLJGDEA(UpdateConnectableVisuals PKCOGNBINGO, ref MJKAOFHPLBK AEILCDAFCEO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct JMOLBGIOEIH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct EKDDLGDIDKD
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct EFBMFHCKDBL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CE")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime IFJJOEKPFHN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002CF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<NOOMLOHPIEM>.Runtime DMMIDKOMBJD;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<HCKAGABHFIE>.Runtime EKAFANLEJNH;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CB")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> GKGIDFEDONH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002CC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<NOOMLOHPIEM> DAEDIBCAPOA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002CD")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<HCKAGABHFIE> BEBBAANKNJJ;

				[Cpp2IlInjected.Token(Token = "0x600078B")]
				[Cpp2IlInjected.Address(RVA = "0x38A4870", Offset = "0x38A3270", VA = "0x1838A4870")]
				public void JPLJMLJGDEA(UpdateConnectableVisuals PKCOGNBINGO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0x38A47A0", Offset = "0x38A31A0", VA = "0x1838A47A0")]
				public EFBMFHCKDBL AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
				{
					return default(EFBMFHCKDBL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<LBJJDFDAIID> AMMGMIDPNEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			private EKDDLGDIDKD OOLCPOANPDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe EKDDLGDIDKD.EFBMFHCKDBL* BMEFAIJKJIP;

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x38AB1C0", Offset = "0x38A9BC0", VA = "0x1838AB1C0")]
			internal void GJIGCKOOEBM(in WorldPoseData KNEPODFFADN, in NOOMLOHPIEM BNHLDCCECMF, in DynamicBuffer<HCKAGABHFIE> LPLEHOMFOKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x22ECD80", Offset = "0x22EB780", VA = "0x1822ECD80", Slot = "5")]
			public void ReadFromDisplayClass(ref HCPKMDPHIPN AEILCDAFCEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x38AB140", Offset = "0x38A9B40", VA = "0x1838AB140", Slot = "4")]
			public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x38AB360", Offset = "0x38A9D60", VA = "0x1838AB360")]
			public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, [NoAlias] ref EKDDLGDIDKD.EFBMFHCKDBL AFHMNGPOKJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x38AB320", Offset = "0x38A9D20", VA = "0x1838AB320")]
			public void JPLJMLJGDEA(UpdateConnectableVisuals PKCOGNBINGO, ref HCPKMDPHIPN AEILCDAFCEO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery BBBLDFNGODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery JLFKLAEMFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery GDFJAJBDNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private EntityQuery AMEDNNMFDEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private EntityQuery HMJHLBLIIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private EntityQuery LGJLKBCCKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private EntityQuery LMPEBPAFFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private EntityQuery FFJIFGGJFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private EntityQuery JNGCMMJOGNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EntityQuery NOHLMEGCBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private global::ABDMDAMINJC<MHKOMGONDLI, IOJBBGGLAEM> IMIANDCFCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private GMOEBONBILL FOPIGLELKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private DFFINCJAHNC FDFJIIOLLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private DIEDKDOMLCJ COIEIDOHKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private EntityQuery GMAGFPLFODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private ProfilerMarker EFECHDGEMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private EntityQuery LHMFBMMIHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private EntityQuery GHPIFKDAHHF;

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int OABDNEKKKBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x22FFFB0", Offset = "0x22FE9B0", VA = "0x1822FFFB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x22FFC10", Offset = "0x22FE610", VA = "0x1822FFC10")]
		internal IOJBBGGLAEM ABEPFGAHNEM(MHKOMGONDLI LGNELGFKAEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x23004A0", Offset = "0x22FEEA0", VA = "0x1823004A0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2302ED0", Offset = "0x23018D0", VA = "0x182302ED0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x2303150", Offset = "0x2301B50", VA = "0x182303150", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x23032E0", Offset = "0x2301CE0", VA = "0x1823032E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2303110", Offset = "0x2301B10", VA = "0x182303110", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x2300940", Offset = "0x22FF340", VA = "0x182300940")]
		private void FNKMOHGHAPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2301600", Offset = "0x2300000", VA = "0x182301600")]
		private void JCBONCFCMCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x2301D50", Offset = "0x2300750", VA = "0x182301D50")]
		private void LJEBIBBLKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2303320", Offset = "0x2301D20", VA = "0x182303320", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x2302890", Offset = "0x2301290", VA = "0x182302890")]
		private void OPDLCGHKCDC(EntityQuery BEFOBPJPFJI, EntityQuery MONHGOGIBOB, EntityQuery GCKMHDKPJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x23027C0", Offset = "0x23011C0", VA = "0x1823027C0")]
		private void OMBMHDCIFDM(EntityQuery GCKMHDKPJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2301320", Offset = "0x22FFD20", VA = "0x182301320")]
		private void HBDLJLPNLFN(global::GBAIANKGCDO<Entity> AADCCBDOLON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x2301750", Offset = "0x2300150", VA = "0x182301750")]
		private void JHHJIOKLKAL(global::GBAIANKGCDO<Entity> AIEIMPFCHJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2302420", Offset = "0x2300E20", VA = "0x182302420")]
		private void MFNEFLCEHPD(global::GBAIANKGCDO<Entity> AKDHMPJGLDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2300690", Offset = "0x22FF090", VA = "0x182300690")]
		private void FEKLEJFEOPE(NativeList<MHKOMGONDLI> AAIEPPOKBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2303590", Offset = "0x2301F90", VA = "0x182303590")]
		private NativeList<MHKOMGONDLI> PGNOMOOKBIM(NativeArray<Entity> GBNPHFOKMOH)
		{
			return default(NativeList<MHKOMGONDLI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x22FF5F0", Offset = "0x22FDFF0", VA = "0x1822FF5F0")]
		private void AAJPCBJJFLF(NativeArray<Entity> GBNPHFOKMOH, NativeList<MHKOMGONDLI> AAIEPPOKBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2300A50", Offset = "0x22FF450", VA = "0x182300A50")]
		private void GHBJHLKDIMB(NativeArray<Entity> EMHIOABNIBP, NativeArray<Entity> DOBLDAINCMJ, NativeList<MHKOMGONDLI> OIDNECGADAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x22FFFF0", Offset = "0x22FE9F0", VA = "0x1822FFFF0")]
		private void DGHCLLKMGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2303450", Offset = "0x2301E50", VA = "0x182303450")]
		private global::OIEIIGDBLKE<LBJJDFDAIID> PALKCPLKFGN(EntityQuery NBKDJEEFFOH, Func<NativeList<LBJJDFDAIID>, JobHandle> LHNKFEJLKHB)
		{
			return default(global::OIEIIGDBLKE<LBJJDFDAIID>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x22FFE20", Offset = "0x22FE820", VA = "0x1822FFE20")]
		private JobHandle AEGCAIBMHMO(NativeList<LBJJDFDAIID> AMMGMIDPNEP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2300800", Offset = "0x22FF200", VA = "0x182300800")]
		private JobHandle FMNMOLCHKKG(NativeList<LBJJDFDAIID> AMMGMIDPNEP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x23011F0", Offset = "0x22FFBF0", VA = "0x1823011F0")]
		private JobHandle GJHKFDLLDCI(NativeList<LBJJDFDAIID> AMMGMIDPNEP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2302190", Offset = "0x2300B90", VA = "0x182302190")]
		private void MCMFJNKHCMM(global::OIEIIGDBLKE<LBJJDFDAIID> AMMGMIDPNEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2301860", Offset = "0x2300260", VA = "0x182301860")]
		private void KDFIDLOGBJI(global::OIEIIGDBLKE<LBJJDFDAIID> AMMGMIDPNEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2300560", Offset = "0x22FEF60", VA = "0x182300560")]
		private bool ECEHOCCFAFN(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x23005C0", Offset = "0x22FEFC0", VA = "0x1823005C0")]
		private NativeArray<Entity> EPLCJCBOPNM(Entity EBOGCLNNJGN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x22FFC60", Offset = "0x22FE660", VA = "0x1822FFC60")]
		private MHKOMGONDLI ACJHLIPDFAF(NativeList<MHKOMGONDLI> OIDNECGADAD)
		{
			return default(MHKOMGONDLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2302100", Offset = "0x2300B00", VA = "0x182302100")]
		private void LLKCKFLPFGB(MHKOMGONDLI LGNELGFKAEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2302D70", Offset = "0x2301770", VA = "0x182302D70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x23025C0", Offset = "0x2300FC0", VA = "0x1823025C0")]
		public static EntityQuery MGMIHLAPGAF(ComponentSystemBase PKCOGNBINGO)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2301AF0", Offset = "0x23004F0", VA = "0x182301AF0")]
		public static EntityQuery KINGHFBCHBH(ComponentSystemBase PKCOGNBINGO)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2300F80", Offset = "0x22FF980", VA = "0x182300F80")]
		public static EntityQuery GHGDCHGAOPE(ComponentSystemBase PKCOGNBINGO)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[OJEJDFBPPED(FHFOPEOFOPD.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EntityQuery NBKDJEEFFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private LKBGGDFMKHG HDFHOPBBCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private OLNPDIJAAAB FCJCJGLDKPN;

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x22E32B0", Offset = "0x22E1CB0", VA = "0x1822E32B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x22E3220", Offset = "0x22E1C20", VA = "0x1822E3220", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x22E33B0", Offset = "0x22E1DB0", VA = "0x1822E33B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class NANNOMFFBAJ : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public DFAIMGIACIM OFGCILEINOG;

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public NANNOMFFBAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x6B6EE0", Offset = "0x6B58E0", VA = "0x1806B6EE0")]
	public NANNOMFFBAJ(DFAIMGIACIM OFGCILEINOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x22CA560", Offset = "0x22C8F60", VA = "0x1822CA560", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class MIMPKPCFOBH : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private ObjectEmbodimentService DDEMFDMAJBL;

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x22C93A0", Offset = "0x22C7DA0", VA = "0x1822C93A0", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x22C9400", Offset = "0x22C7E00", VA = "0x1822C9400", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x22C9430", Offset = "0x22C7E30", VA = "0x1822C9430", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	protected MIMPKPCFOBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class EDBLEEJFIJF : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private EntityQuery CFGDOBFBPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private EntityQuery EOKHFPOEOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private EntityQuery ECJDCFJAFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private EntityQuery EBCKPHJCELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private ObjectEmbodimentService KMAKAEAHKOI;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int JLMBOKNKKBN
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x24C2400", Offset = "0x24C0E00", VA = "0x1824C2400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int ODFHOEPDIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x24C2A80", Offset = "0x24C1480", VA = "0x1824C2A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x24C2410", Offset = "0x24C0E10", VA = "0x1824C2410", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x24C2A90", Offset = "0x24C1490", VA = "0x1824C2A90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x24C2C90", Offset = "0x24C1690", VA = "0x1824C2C90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x24C23E0", Offset = "0x24C0DE0", VA = "0x1824C23E0")]
	public int BKOOHEDOGKM(SceneTag HJLNDBMKNHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x24C26F0", Offset = "0x24C10F0", VA = "0x1824C26F0")]
	public int JGDNGEJBEMJ(SceneTag HJLNDBMKNHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x24C2860", Offset = "0x24C1260", VA = "0x1824C2860")]
	protected void NKNKLLDNBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x24C2470", Offset = "0x24C0E70", VA = "0x1824C2470")]
	protected void DIKANHOEBKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x24C2CB0", Offset = "0x24C16B0", VA = "0x1824C2CB0")]
	public global::GBAIANKGCDO<Entity> PHMCGGBJCAM(SceneTag HJLNDBMKNHI, Allocator FAMNMGKAFPB = Allocator.TempJob)
	{
		return default(global::GBAIANKGCDO<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x24C27B0", Offset = "0x24C11B0", VA = "0x1824C27B0")]
	public global::GBAIANKGCDO<Entity> LCFIGHGFOHK(SceneTag HJLNDBMKNHI, Allocator FAMNMGKAFPB = Allocator.TempJob)
	{
		return default(global::GBAIANKGCDO<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x24C25F0", Offset = "0x24C0FF0", VA = "0x1824C25F0")]
	public bool IPBBIEAOHPA(SceneTag HJLNDBMKNHI, out global::GBAIANKGCDO<Entity> OFGCILEINOG, Allocator FAMNMGKAFPB = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x24C2800", Offset = "0x24C1200", VA = "0x1824C2800")]
	public bool NCHGJDANBJA(Entity EBOGCLNNJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x24C2580", Offset = "0x24C0F80", VA = "0x1824C2580")]
	public DFAIMGIACIM HHFHHCOAOJH(Entity EBOGCLNNJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x24C2680", Offset = "0x24C1080", VA = "0x1824C2680")]
	public bool IPHGNDNNICN(Entity EBOGCLNNJGN, out NANNOMFFBAJ OFGCILEINOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x24C2710", Offset = "0x24C1110", VA = "0x1824C2710")]
	public void JHLFEHNMDMJ(Entity EBOGCLNNJGN, NANNOMFFBAJ OFGCILEINOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x24C2750", Offset = "0x24C1150", VA = "0x1824C2750")]
	public bool KHHBKHMDFBF(Entity EBOGCLNNJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void PMNCPDONOCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public EDBLEEJFIJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class JHPKFMHGNDC : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private EntityQuery IJKPMKBFLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private PNLHBOHNCFH MGOGCFMPFGO;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x21875C0", Offset = "0x2185FC0", VA = "0x1821875C0", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x2187680", Offset = "0x2186080", VA = "0x182187680", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x2187740", Offset = "0x2186140", VA = "0x182187740", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x1767D50", Offset = "0x1766750", VA = "0x181767D50")]
	private bool IEGNJCFKICE<TComponentData>(EntityQuery NBKDJEEFFOH, out NativeArray<Entity> GBNPHFOKMOH, out NativeArray<TComponentData> LMCKNIENCJA) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x2187610", Offset = "0x2186010", VA = "0x182187610")]
	public DFAIMGIACIM HHFHHCOAOJH(Entity EBOGCLNNJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public JHPKFMHGNDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[OJEJDFBPPED(FHFOPEOFOPD.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private EntityQuery BJEMDMIFNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private EntityQuery AEHMDJFNCPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private EntityQuery DPILPKPFLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private EntityQuery GBANNBPMDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private PNLHBOHNCFH MGOGCFMPFGO;

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x22F4420", Offset = "0x22F2E20", VA = "0x1822F4420", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x22F4550", Offset = "0x22F2F50", VA = "0x1822F4550", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x22F4780", Offset = "0x22F3180", VA = "0x1822F4780", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x22F4470", Offset = "0x22F2E70", VA = "0x1822F4470")]
		private void MJIKPLNABDE(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x22F44E0", Offset = "0x22F2EE0", VA = "0x1822F44E0")]
		private void OMBMHDCIFDM(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x22F4710", Offset = "0x22F3110", VA = "0x1822F4710", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x22F40C0", Offset = "0x22F2AC0", VA = "0x1822F40C0")]
		private void CJPDDMNBLML(EntityQuery NBKDJEEFFOH, bool BGGOFFFFDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class PBMDGOCBBDI : BHPPPHCOIMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct ALEPKDHJOOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		public ALEPKDHJOOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct JDGPOIGJEKA : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private struct AAHOKGCPEMK
		{
			[Cpp2IlInjected.Token(Token = "0x20000F5")]
			[NoAlias]
			public struct CAOCPDPBGEP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime DOIKOMNNJOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime FNKKPMOKCEK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime HMJKNPPCAIH;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity PJIGEDFEFLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> KMCOOEJACII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> BIPGPMKMNMG;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x38A1B90", Offset = "0x38A0590", VA = "0x1838A1B90")]
			public void JPLJMLJGDEA(PBMDGOCBBDI PKCOGNBINGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x38A1AD0", Offset = "0x38A04D0", VA = "0x1838A1AD0")]
			public CAOCPDPBGEP AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
			{
				return default(CAOCPDPBGEP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private AAHOKGCPEMK OOLCPOANPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe AAHOKGCPEMK.CAOCPDPBGEP* BMEFAIJKJIP;

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x38AAED0", Offset = "0x38A98D0", VA = "0x1838AAED0")]
		internal void GJIGCKOOEBM(Entity MNONFDJDIAK, SplineShapeData FFJJMLKNOBA, DynamicBuffer<LinkedEntityGroup> MFPFCCDPGDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x38AAE00", Offset = "0x38A9800", VA = "0x1838AAE00", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x38AAF40", Offset = "0x38A9940", VA = "0x1838AAF40")]
		public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, [NoAlias] ref AAHOKGCPEMK.CAOCPDPBGEP AFHMNGPOKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x38AAF30", Offset = "0x38A9930", VA = "0x1838AAF30")]
		public void JPLJMLJGDEA(PBMDGOCBBDI PKCOGNBINGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct KCMEKNMEKGC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct DGEDCMFGCIK
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct NMEGKNODBLN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F8")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime DEBAGJALGJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F9")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime DBEDHFGPJAK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity BNJKLNKNHJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> AGAJBMCGPPO;

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0x38A3990", Offset = "0x38A2390", VA = "0x1838A3990")]
			public void JPLJMLJGDEA(PBMDGOCBBDI PKCOGNBINGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x38A3910", Offset = "0x38A2310", VA = "0x1838A3910")]
			public NMEGKNODBLN AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
			{
				return default(NMEGKNODBLN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public BufferFromEntity<LinkedEntityGroup> KFJMMCKFGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private DGEDCMFGCIK OOLCPOANPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe DGEDCMFGCIK.NMEGKNODBLN* BMEFAIJKJIP;

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x38ABE30", Offset = "0x38AA830", VA = "0x1838ABE30")]
		internal void GJIGCKOOEBM(Entity KLDFJAONDKC, SplinePointParentData EJJLGEAPGCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x38AC000", Offset = "0x38AAA00", VA = "0x1838AC000", Slot = "5")]
		public void ReadFromDisplayClass(ref ALEPKDHJOOB AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x38ABD90", Offset = "0x38AA790", VA = "0x1838ABD90", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x38ABF50", Offset = "0x38AA950", VA = "0x1838ABF50")]
		public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, [NoAlias] ref DGEDCMFGCIK.NMEGKNODBLN AFHMNGPOKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x38ABEC0", Offset = "0x38AA8C0", VA = "0x1838ABEC0")]
		public void JPLJMLJGDEA(PBMDGOCBBDI PKCOGNBINGO, ref ALEPKDHJOOB AEILCDAFCEO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private EntityQuery NBKDJEEFFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private EntityQuery AKLNIAHEBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private EntityQuery PKBBLANDEAK;

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x22DBF80", Offset = "0x22DA980", VA = "0x1822DBF80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x22DC030", Offset = "0x22DAA30", VA = "0x1822DC030", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public PBMDGOCBBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x22DBCE0", Offset = "0x22DA6E0", VA = "0x1822DBCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x22DBB40", Offset = "0x22DA540", VA = "0x1822DBB40")]
	public static EntityQuery MIAAEGCAKJM(ComponentSystemBase PKCOGNBINGO)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x22DB9E0", Offset = "0x22DA3E0", VA = "0x1822DB9E0")]
	public static EntityQuery CAEOJGDHEEL(ComponentSystemBase PKCOGNBINGO)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
public sealed class NCPNEKACEND : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private NENJKMNFLCL OBCBMCKPGCC;

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x22CA930", Offset = "0x22C9330", VA = "0x1822CA930", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x22CA990", Offset = "0x22C9390", VA = "0x1822CA990", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public NCPNEKACEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class FABFNEHKFLP : BHPPPHCOIMM, BGKGLCNGELH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct IIJHNAHMOJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NativeList<PLGLIKALDJI> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NativeList<PCMAMIJLKEM> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NativeList<PLGLIKALDJI> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		public IIJHNAHMOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, PBCNGDCKPOL previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
		internal void <OnUpdate>b__2(Entity entity, PBCNGDCKPOL previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct FDAIIKBHONM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct JMHPAJMLLNB
		{
			[Cpp2IlInjected.Token(Token = "0x20000FE")]
			[NoAlias]
			public struct CABEHANGOOA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000307")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime BFDIEBHDBHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000308")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime CJEAPJOPMHL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity OLNAEIIEBBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> HDMNFIPDJPF;

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x38AB0E0", Offset = "0x38A9AE0", VA = "0x1838AB0E0")]
			public void JPLJMLJGDEA(FABFNEHKFLP PKCOGNBINGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x38AB060", Offset = "0x38A9A60", VA = "0x1838AB060")]
			public CABEHANGOOA AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
			{
				return default(CABEHANGOOA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NativeList<PLGLIKALDJI> ONMJLHMFKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private JMHPAJMLLNB OOLCPOANPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JMHPAJMLLNB.CABEHANGOOA* BMEFAIJKJIP;

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x38A4D80", Offset = "0x38A3780", VA = "0x1838A4D80")]
		internal void GJIGCKOOEBM(Entity EBOGCLNNJGN, ParentData LOILLHLIIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x22ECD80", Offset = "0x22EB780", VA = "0x1822ECD80", Slot = "5")]
		public void ReadFromDisplayClass(ref IIJHNAHMOJD AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x38A4CE0", Offset = "0x38A36E0", VA = "0x1838A4CE0", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x38A4E90", Offset = "0x38A3890", VA = "0x1838A4E90")]
		public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, [NoAlias] ref JMHPAJMLLNB.CABEHANGOOA AFHMNGPOKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x38A4E00", Offset = "0x38A3800", VA = "0x1838A4E00")]
		public void JPLJMLJGDEA(FABFNEHKFLP PKCOGNBINGO, ref IIJHNAHMOJD AEILCDAFCEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct BCFJKPEFBOO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct GLHIIPNNEIN
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct IAOHKMKDOGB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030F")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime BFDIEBHDBHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000310")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime CJEAPJOPMHL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000311")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<PBCNGDCKPOL>.Runtime AKFLLLLLLIE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity OLNAEIIEBBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> HDMNFIPDJPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<PBCNGDCKPOL> BPPNNJKFKHM;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x38A6960", Offset = "0x38A5360", VA = "0x1838A6960")]
			public void JPLJMLJGDEA(FABFNEHKFLP PKCOGNBINGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x38A68C0", Offset = "0x38A52C0", VA = "0x1838A68C0")]
			public IAOHKMKDOGB AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
			{
				return default(IAOHKMKDOGB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeList<PCMAMIJLKEM> EBKGKGHGCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private GLHIIPNNEIN OOLCPOANPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe GLHIIPNNEIN.IAOHKMKDOGB* BMEFAIJKJIP;

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x38A23B0", Offset = "0x38A0DB0", VA = "0x1838A23B0")]
		internal void GJIGCKOOEBM(Entity EBOGCLNNJGN, ParentData LOILLHLIIPD, PBCNGDCKPOL ANPMDMMFNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x38A2590", Offset = "0x38A0F90", VA = "0x1838A2590", Slot = "5")]
		public void ReadFromDisplayClass(ref IIJHNAHMOJD AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x38A22E0", Offset = "0x38A0CE0", VA = "0x1838A22E0", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x38A24B0", Offset = "0x38A0EB0", VA = "0x1838A24B0")]
		public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, [NoAlias] ref GLHIIPNNEIN.IAOHKMKDOGB AFHMNGPOKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x38A2470", Offset = "0x38A0E70", VA = "0x1838A2470")]
		public void JPLJMLJGDEA(FABFNEHKFLP PKCOGNBINGO, ref IIJHNAHMOJD AEILCDAFCEO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct FINPIEPGLHC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct NDCIBHFIPEH
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct JJOELPNFINL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000317")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime BFDIEBHDBHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000318")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<PBCNGDCKPOL>.Runtime AKFLLLLLLIE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity OLNAEIIEBBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<PBCNGDCKPOL> BPPNNJKFKHM;

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x38AD0C0", Offset = "0x38ABAC0", VA = "0x1838AD0C0")]
			public void JPLJMLJGDEA(FABFNEHKFLP PKCOGNBINGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x38AD040", Offset = "0x38ABA40", VA = "0x1838AD040")]
			public JJOELPNFINL AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
			{
				return default(JJOELPNFINL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<PLGLIKALDJI> ALOODLHKPBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private NDCIBHFIPEH OOLCPOANPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NDCIBHFIPEH.JJOELPNFINL* BMEFAIJKJIP;

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0x38A5A70", Offset = "0x38A4470", VA = "0x1838A5A70")]
		internal void GJIGCKOOEBM(Entity EBOGCLNNJGN, PBCNGDCKPOL ANPMDMMFNGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x38A5C30", Offset = "0x38A4630", VA = "0x1838A5C30", Slot = "5")]
		public void ReadFromDisplayClass(ref IIJHNAHMOJD AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x38A59D0", Offset = "0x38A43D0", VA = "0x1838A59D0", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x38A5B80", Offset = "0x38A4580", VA = "0x1838A5B80")]
		public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, [NoAlias] ref NDCIBHFIPEH.JJOELPNFINL AFHMNGPOKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x38A5AF0", Offset = "0x38A44F0", VA = "0x1838A5AF0")]
		public void JPLJMLJGDEA(FABFNEHKFLP PKCOGNBINGO, ref IIJHNAHMOJD AEILCDAFCEO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private MLCLABHKFLP FBBIGOLNCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery GLOGIIHAKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private EntityQuery BMNJFNABBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private EntityQuery PGCEEMJMIHF;

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x217A190", Offset = "0x2178B90", VA = "0x18217A190", Slot = "14")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x217A2D0", Offset = "0x2178CD0", VA = "0x18217A2D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public FABFNEHKFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x217A270", Offset = "0x2178C70", VA = "0x18217A270", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x2179D30", Offset = "0x2178730", VA = "0x182179D30")]
	public static EntityQuery HONOCMKMNDE(ComponentSystemBase PKCOGNBINGO)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x2179B00", Offset = "0x2178500", VA = "0x182179B00")]
	public static EntityQuery CNONOIONKNK(ComponentSystemBase PKCOGNBINGO)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x2179F90", Offset = "0x2178990", VA = "0x182179F90")]
	public static EntityQuery KDNBDHOKJKE(ComponentSystemBase PKCOGNBINGO)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[OJEJDFBPPED(FHFOPEOFOPD.Connectables)]
	public class InitializeRigidbodyExHierarchy : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private EntityQuery NBKDJEEFFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private MAPMDJPOPFI MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x21862A0", Offset = "0x2184CA0", VA = "0x1821862A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2186230", Offset = "0x2184C30", VA = "0x182186230", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2186330", Offset = "0x2184D30", VA = "0x182186330", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class KKBOAHBMDOB : ParentSystemBase<ParentData, PBCNGDCKPOL, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x218C600", Offset = "0x218B000", VA = "0x18218C600", Slot = "14")]
	protected override EntityQueryDesc GFADHLPEKBJ(EntityQueryDesc NBKDJEEFFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x8CBA70", Offset = "0x8CA470", VA = "0x1808CBA70", Slot = "15")]
	protected override EntityQueryDesc IMJBMAOCCED(EntityQueryDesc NBKDJEEFFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x218C5C0", Offset = "0x218AFC0", VA = "0x18218C5C0", Slot = "16")]
	protected override EntityQueryDesc AHCKKGDLMAL(EntityQueryDesc NBKDJEEFFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x218C640", Offset = "0x218B040", VA = "0x18218C640", Slot = "17")]
	protected override EntityQueryDesc GLCNGDFMPIA(EntityQueryDesc NBKDJEEFFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x218C6C0", Offset = "0x218B0C0", VA = "0x18218C6C0")]
	public KKBOAHBMDOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x218C680", Offset = "0x218B080", VA = "0x18218C680", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : BHPPPHCOIMM where ParentData : struct, IComponentData, LOEAICEFKPI where PreviousParentData : struct, IComponentData, LOEAICEFKPI where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, LOEAICEFKPI
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[BurstCompile]
		private struct PGPDBBLKMJJ : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter PJBCNEMDJBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter MIDPNAMJJGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public NativeHashMap<Entity, int>.ParallelWriter BLJPOMAPNIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public ArchetypeChunkComponentType<PreviousParentData> KODEMHJJKHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> JOIDODHJOLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			[ReadOnly]
			public ArchetypeChunkEntityType LFOFMAODOAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public uint KEIPKEPJJGI;

			[Cpp2IlInjected.Token(Token = "0x6000817")]
			[Cpp2IlInjected.Address(RVA = "0x2F4CC70", Offset = "0x2F4B670", VA = "0x182F4CC70", Slot = "4")]
			public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000109")]
		[BurstCompile]
		private struct GGCBMPHLBGO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeHashMap<Entity, int> BLJPOMAPNIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> GEKBFEMAAKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public NativeList<Entity> LBKEEIHCHIG;

			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0x1CC28A0", Offset = "0x1CC12A0", VA = "0x181CC28A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010A")]
		[BurstCompile]
		private struct BLKNBAKIGKI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> PJBCNEMDJBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> MIDPNAMJJGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			[ReadOnly]
			public NativeHashMap<Entity, int> BLJPOMAPNIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public BufferFromEntity<ChildrenData> GEKBFEMAAKM;

			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0x3108C20", Offset = "0x3107620", VA = "0x183108C20")]
			private int FOBMJKBDKDA(DynamicBuffer<ChildrenData> DIDIDBBHIMI, Entity EBOGCLNNJGN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x3109200", Offset = "0x3107C00", VA = "0x183109200")]
			private void OIBDKFFDLHP(Entity EGNCPOLPGCD, DynamicBuffer<ChildrenData> DIDIDBBHIMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x3108E40", Offset = "0x3107840", VA = "0x183108E40")]
			private void NKCKICFDDML(Entity EGNCPOLPGCD, DynamicBuffer<ChildrenData> DIDIDBBHIMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x3108960", Offset = "0x3107360", VA = "0x183108960", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct GBPEOOIALGE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public NativeArray<Entity> GIMDIJAPMNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public NativeList<Entity> CAGHDNHGGHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public BufferFromEntity<ChildrenData> GEKBFEMAAKM;

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x1CADD40", Offset = "0x1CAC740", VA = "0x181CADD40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected EntityQuery KBKIPDDGKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected EntityQuery KKHPHJFOLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected EntityQuery MHFGJNCNJBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected EntityQuery JCLANBAIKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected ProfilerMarker GHIAJGENKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected ProfilerMarker OKLIDDEEDPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected ProfilerMarker GAHEJBHAIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected ProfilerMarker EKPDABGNOLG;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x2544990", Offset = "0x2543390", VA = "0x182544990")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x2542FE0", Offset = "0x25419E0", VA = "0x182542FE0")]
		private int FOBMJKBDKDA(DynamicBuffer<ChildrenData> DIDIDBBHIMI, Entity EBOGCLNNJGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x2542E80", Offset = "0x2541880", VA = "0x182542E80")]
		private void DFPBHFMLNML(Entity PNPOJJDCJHE, Entity HKPLBJGGAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x8CBA70", Offset = "0x8CA470", VA = "0x1808CBA70", Slot = "14")]
		protected virtual EntityQueryDesc GFADHLPEKBJ(EntityQueryDesc NBKDJEEFFOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x8CBA70", Offset = "0x8CA470", VA = "0x1808CBA70", Slot = "15")]
		protected virtual EntityQueryDesc IMJBMAOCCED(EntityQueryDesc NBKDJEEFFOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x8CBA70", Offset = "0x8CA470", VA = "0x1808CBA70", Slot = "16")]
		protected virtual EntityQueryDesc AHCKKGDLMAL(EntityQueryDesc NBKDJEEFFOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc GLCNGDFMPIA(EntityQueryDesc NBKDJEEFFOH);

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2544620", Offset = "0x2543020", VA = "0x182544620", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2543850", Offset = "0x2542250", VA = "0x182543850")]
		private void HEBLJKEPKPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2542B60", Offset = "0x2541560", VA = "0x182542B60")]
		private void BGBAGLOMAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2543920", Offset = "0x2542320", VA = "0x182543920")]
		private JobHandle KFIKMHGNMEL(JobHandle PMDPDMNKEOL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x25434A0", Offset = "0x2541EA0", VA = "0x1825434A0")]
		private void GAOKPMLBEHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x25448C0", Offset = "0x25432C0", VA = "0x1825448C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x1E6ACA0", Offset = "0x1E696A0", VA = "0x181E6ACA0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x1E76C90", Offset = "0x1E75690", VA = "0x181E76C90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[AlwaysUpdateSystem]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
public abstract class KONGHCOOFNM : BHPPPHCOIMM, BGKGLCNGELH
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private struct BILCGMNDJLL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public global::OIEIIGDBLKE<Entity> CNMFGNLMNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public global::OIEIIGDBLKE<Entity> MDEGJGPINOI;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x38A3400", Offset = "0x38A1E00", VA = "0x1838A3400")]
		public BILCGMNDJLL(NativeList<Entity> CNMFGNLMNOK, NativeList<Entity> MDEGJGPINOI, JobHandle MDLEMMPHNCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x38A3380", Offset = "0x38A1D80", VA = "0x1838A3380")]
		public JobHandle OBAHDJDIAKE(JobHandle PMDPDMNKEOL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x38A32F0", Offset = "0x38A1CF0", VA = "0x1838A32F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct IOMJCEJPJMH : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[Flags]
		public enum LKDNOEFAHCB
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
		public NativeList<Entity> DMGADBDCCPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[WriteOnly]
		public NativeList<Entity> NFFODCJKDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[ReadOnly]
		public NativeArray<Entity> PFJLOPIEBPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> FGOBFODFKAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[ReadOnly]
		public LDAFGDLEPJJ OPBCDHCPAAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		[ReadOnly]
		public LDAFGDLEPJJ FJCIHOBEMMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> NAKFHKAMDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int EFKCMFGLAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int FJICHNOCKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private LKDNOEFAHCB ALJCNHHOCJK;

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x38AA570", Offset = "0x38A8F70", VA = "0x1838AA570", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x38AA7E0", Offset = "0x38A91E0", VA = "0x1838AA7E0")]
		private void JCLJKLNCBCJ(Entity EBOGCLNNJGN, bool ENOEOJNCLAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x38AA0A0", Offset = "0x38A8AA0", VA = "0x1838AA0A0")]
		private void ADCHOBNJHBH(Entity EBOGCLNNJGN, bool ENOEOJNCLAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x38AA950", Offset = "0x38A9350", VA = "0x1838AA950")]
		public BILCGMNDJLL OFGKOLINKFG(NativeArray<Entity> CDPILLKGKCM, JobHandle PMDPDMNKEOL)
		{
			return default(BILCGMNDJLL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x38AA1B0", Offset = "0x38A8BB0", VA = "0x1838AA1B0")]
		public BILCGMNDJLL AGHHDJDHEFB(NativeArray<Entity> CDPILLKGKCM, JobHandle PMDPDMNKEOL)
		{
			return default(BILCGMNDJLL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x38AA490", Offset = "0x38A8E90", VA = "0x1838AA490")]
		public BILCGMNDJLL CLCHMNHAAJA(NativeList<PLGLIKALDJI> AMMGMIDPNEP, JobHandle PMDPDMNKEOL)
		{
			return default(BILCGMNDJLL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x38AA870", Offset = "0x38A9270", VA = "0x1838AA870")]
		public BILCGMNDJLL JEKFBKANPFM(NativeList<PLGLIKALDJI> AMMGMIDPNEP, JobHandle PMDPDMNKEOL)
		{
			return default(BILCGMNDJLL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x38AA700", Offset = "0x38A9100", VA = "0x1838AA700")]
		public BILCGMNDJLL IFJDKMHNPPH(NativeList<PCMAMIJLKEM> AMMGMIDPNEP, JobHandle PMDPDMNKEOL)
		{
			return default(BILCGMNDJLL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x1F3ABD0", Offset = "0x1F395D0", VA = "0x181F3ABD0")]
		private BILCGMNDJLL BLBHNLEAJKD<T>(NativeList<T> AMMGMIDPNEP, int LKPOAKHFOKB, int KEPHIGEMAKP, LKDNOEFAHCB CCHMICPAKBN, JobHandle PMDPDMNKEOL) where T : struct
		{
			return default(BILCGMNDJLL);
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x38AA230", Offset = "0x38A8C30", VA = "0x1838AA230")]
		private BILCGMNDJLL BLBHNLEAJKD(NativeArray<Entity> GBNPHFOKMOH, int LKPOAKHFOKB, int KEPHIGEMAKP, LKDNOEFAHCB CCHMICPAKBN, JobHandle PMDPDMNKEOL)
		{
			return default(BILCGMNDJLL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly LOOGELFKPLM ENHDLHMFJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private EntityQuery ONDELJOODPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private EntityQuery AAMHHGMHFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private MLCLABHKFLP EJBBHMGJPEK;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	protected abstract ComponentType DNEGHNDHNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	protected abstract ComponentType IFODKMFCPIO
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	protected abstract ComponentType HBFOJHKOLIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x218E530", Offset = "0x218CF30", VA = "0x18218E530")]
	protected KONGHCOOFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x218CF10", Offset = "0x218B910", VA = "0x18218CF10", Slot = "14")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x218D240", Offset = "0x218BC40", VA = "0x18218D240", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x218D470", Offset = "0x218BE70", VA = "0x18218D470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0xED3530", Offset = "0xED1F30", VA = "0x180ED3530", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x218CEB0", Offset = "0x218B8B0", VA = "0x18218CEB0")]
	private void IICPONKIGPI(NativeArray<Entity> AMMGMIDPNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x218CE10", Offset = "0x218B810", VA = "0x18218CE10")]
	private void HBOJDMDOIHA(NativeArray<Entity> AMMGMIDPNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x218D100", Offset = "0x218BB00", VA = "0x18218D100")]
	private void OCEAHGOGMMB(BILCGMNDJLL DDDCHHCAKLJ, string GNPHFOMMBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x218CFF0", Offset = "0x218B9F0", VA = "0x18218CFF0")]
	private void OCEAHGOGMMB(global::OIEIIGDBLKE<Entity> MFFHGIHLKLL, string GNPHFOMMBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x218E3F0", Offset = "0x218CDF0", VA = "0x18218E3F0")]
	private void PMBDFLLKOJA(BILCGMNDJLL DDDCHHCAKLJ, string GNPHFOMMBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x218E2E0", Offset = "0x218CCE0", VA = "0x18218E2E0")]
	private void PMBDFLLKOJA(global::OIEIIGDBLKE<Entity> MFFHGIHLKLL, string GNPHFOMMBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x218CDA0", Offset = "0x218B7A0", VA = "0x18218CDA0")]
	private bool DENDDOPMLBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
public class KHGLPNPMOHP : BHPPPHCOIMM, CFMOGGHLNDM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct CHPHDPBOBKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public KHGLPNPMOHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		public CHPHDPBOBKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct KEICBNIHJOP : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct MPGOHGLOKFM
		{
			[Cpp2IlInjected.Token(Token = "0x2000114")]
			public struct ENEOPBLAKMP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000358")]
				public LambdaParameterValueProvider_Entity.Runtime IOKFLPLNOGJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity NOEKOPHMMGF;

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x38ACF20", Offset = "0x38AB920", VA = "0x1838ACF20")]
			public void JPLJMLJGDEA(KHGLPNPMOHP PKCOGNBINGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x38ACF10", Offset = "0x38AB910", VA = "0x1838ACF10")]
			public ENEOPBLAKMP AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
			{
				return default(ENEOPBLAKMP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public KHGLPNPMOHP AEFKMLCAHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public EntityCommandBuffer FCFBBDAJJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private MPGOHGLOKFM OOLCPOANPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MPGOHGLOKFM.ENEOPBLAKMP* BMEFAIJKJIP;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OAOBLPGJBCM;

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x38AC060", Offset = "0x38AAA60", VA = "0x1838AC060")]
		internal void GJIGCKOOEBM(Entity OIBINBJMLDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x38A2A40", Offset = "0x38A1440", VA = "0x1838A2A40", Slot = "5")]
		public void ReadFromDisplayClass(ref CHPHDPBOBKL AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x38A2A70", Offset = "0x38A1470", VA = "0x1838A2A70", Slot = "6")]
		public void WriteToDisplayClass(ref CHPHDPBOBKL AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x38AC010", Offset = "0x38AAA10", VA = "0x1838AC010", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x38AC220", Offset = "0x38AAC20", VA = "0x1838AC220")]
		public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, ref MPGOHGLOKFM.ENEOPBLAKMP AFHMNGPOKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x38AC170", Offset = "0x38AAB70", VA = "0x1838AC170")]
		public void JPLJMLJGDEA(KHGLPNPMOHP PKCOGNBINGO, ref CHPHDPBOBKL AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x38AC1B0", Offset = "0x38AABB0", VA = "0x1838AC1B0")]
		public unsafe static void KALMFPFGGJA(ArchetypeChunkIterator* OKNKNNMFMKI, void* EBLJDNAFJJC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private ICCDIGPMFMJ LAPKCOGHLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private GPAPCFEMAGG KCGGAKHINBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private EntityQuery GMHOJCPFEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private ProfilerMarker PCCECNPIMMJ;

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x218C410", Offset = "0x218AE10", VA = "0x18218C410", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x218C100", Offset = "0x218AB00", VA = "0x18218C100", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x218C470", Offset = "0x218AE70", VA = "0x18218C470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public KHGLPNPMOHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x218C330", Offset = "0x218AD30", VA = "0x18218C330", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x218C160", Offset = "0x218AB60", VA = "0x18218C160")]
	public static EntityQuery EMKJJIJFLAF(ComponentSystemBase PKCOGNBINGO)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[NIHNMLIMMAM]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
public class OOBLEJGGMCO : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private GPAPCFEMAGG KCGGAKHINBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private SceneService HLDGGAOHOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private EntityQuery NBKDJEEFFOH;

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x22CEA60", Offset = "0x22CD460", VA = "0x1822CEA60", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x22CEAD0", Offset = "0x22CD4D0", VA = "0x1822CEAD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x22CEB70", Offset = "0x22CD570", VA = "0x1822CEB70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public OOBLEJGGMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public struct CBONKODFOND : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public GLHHDFOJNGA LGNELGFKAEP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10")]
	public static CBONKODFOND MFJMDPBHOLK(in GLHHDFOJNGA CGOELOJLCHO)
	{
		return default(CBONKODFOND);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10")]
	public static GLHHDFOJNGA MFJMDPBHOLK(in CBONKODFOND IFMOCIALFBH)
	{
		return default(GLHHDFOJNGA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[AlwaysUpdateSystem]
public class ICCDIGPMFMJ : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x2185460", Offset = "0x2183E60", VA = "0x182185460", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0")]
	public ICCDIGPMFMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[AlwaysUpdateSystem]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
public class PHNENMLPCLA : BHPPPHCOIMM, CFMOGGHLNDM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct CCHDEJOODEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public PHNENMLPCLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		public CCHDEJOODEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
		internal void <OnUpdate>b__0(Entity e, CBONKODFOND ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BFDCBMDHFON : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct PJOHLAGIOJE
		{
			[Cpp2IlInjected.Token(Token = "0x200011C")]
			public struct LGALJANLGLC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public LambdaParameterValueProvider_Entity.Runtime IOKFLPLNOGJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_IComponentData<CBONKODFOND>.Runtime LAGDLOIHKOK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity NOEKOPHMMGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<CBONKODFOND> OENPEIANPDG;

			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0x38ADEF0", Offset = "0x38AC8F0", VA = "0x1838ADEF0")]
			public void JPLJMLJGDEA(PHNENMLPCLA PKCOGNBINGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x38ADE70", Offset = "0x38AC870", VA = "0x1838ADE70")]
			public LGALJANLGLC AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
			{
				return default(LGALJANLGLC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public PHNENMLPCLA AEFKMLCAHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer FCFBBDAJJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private PJOHLAGIOJE OOLCPOANPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PJOHLAGIOJE.LGALJANLGLC* BMEFAIJKJIP;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OAOBLPGJBCM;

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x38A2790", Offset = "0x38A1190", VA = "0x1838A2790")]
		internal void GJIGCKOOEBM(Entity OIBINBJMLDP, CBONKODFOND BMPMEFMMBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x38A2A40", Offset = "0x38A1440", VA = "0x1838A2A40", Slot = "5")]
		public void ReadFromDisplayClass(ref CCHDEJOODEL AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x38A2A70", Offset = "0x38A1470", VA = "0x1838A2A70", Slot = "6")]
		public void WriteToDisplayClass(ref CCHDEJOODEL AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x38A26F0", Offset = "0x38A10F0", VA = "0x1838A26F0", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x38A2990", Offset = "0x38A1390", VA = "0x1838A2990")]
		public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, ref PJOHLAGIOJE.LGALJANLGLC AFHMNGPOKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x38A2890", Offset = "0x38A1290", VA = "0x1838A2890")]
		public void JPLJMLJGDEA(PHNENMLPCLA PKCOGNBINGO, ref CCHDEJOODEL AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x38A2920", Offset = "0x38A1320", VA = "0x1838A2920")]
		public unsafe static void KALMFPFGGJA(ArchetypeChunkIterator* OKNKNNMFMKI, void* EBLJDNAFJJC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private ICCDIGPMFMJ LAPKCOGHLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private GPAPCFEMAGG KCGGAKHINBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery DOPJGPIHOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private ProfilerMarker MLFAFINCDNM;

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x22DCEB0", Offset = "0x22DB8B0", VA = "0x1822DCEB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x22DCBA0", Offset = "0x22DB5A0", VA = "0x1822DCBA0", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x22DCF10", Offset = "0x22DB910", VA = "0x1822DCF10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public PHNENMLPCLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x22DCDD0", Offset = "0x22DB7D0", VA = "0x1822DCDD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x22DCC00", Offset = "0x22DB600", VA = "0x1822DCC00")]
	public static EntityQuery EDCAJLDPMFM(ComponentSystemBase PKCOGNBINGO)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct FDACAGDBJHG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public COAJGMOIFLM IHDGODIAJNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeHashMap<Entity, FIGHGNFLDFK> GBNPHFOKMOH;

			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0x38A4C40", Offset = "0x38A3640", VA = "0x1838A4C40")]
			public FDACAGDBJHG(int CDECJIFLFKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x38A4BC0", Offset = "0x38A35C0", VA = "0x1838A4BC0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[BurstCompile]
		private struct NFJFMPBIOIP : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			[ReadOnly]
			public NativeArray<Entity> GBNPHFOKMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> MPNGIJGPEPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> MHPDPNIKLPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> AIGDCDKHAAI;

			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0x38AD120", Offset = "0x38ABB20", VA = "0x1838AD120", Slot = "4")]
			public void Execute(int NENMOOINMCH, TransformAccess MLMJNFGMBPE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000120")]
		[BurstCompile]
		private struct BCLMKBEDMIO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			public NativeArray<Entity> GBNPHFOKMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> MPNGIJGPEPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> AIGDCDKHAAI;

			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x38A25A0", Offset = "0x38A0FA0", VA = "0x1838A25A0", Slot = "4")]
			public void Execute(int NENMOOINMCH, TransformAccess MLMJNFGMBPE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private GPAPCFEMAGG KCGGAKHINBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private EntityQuery ALKMKOHPOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private EntityQuery IMLHNBFOPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private EntityQuery INLPOOECNJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private EntityQuery JGBLAAICDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private EntityQuery AAGMGKAHIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private JobHandle ICDBADGNAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private FDACAGDBJHG OOMIJICCNLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private FDACAGDBJHG BFIJABDMOGI;

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x22DFF20", Offset = "0x22DE920", VA = "0x1822DFF20", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x22E0500", Offset = "0x22DEF00", VA = "0x1822E0500", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x22DFEE0", Offset = "0x22DE8E0", VA = "0x1822DFEE0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x22E07C0", Offset = "0x22DF1C0", VA = "0x1822E07C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x22DFA00", Offset = "0x22DE400", VA = "0x1822DFA00")]
		private void AEPFNINNGGC(EntityQuery NBKDJEEFFOH, out (global::GBAIANKGCDO<CBONKODFOND> handles, global::GBAIANKGCDO<DDIAOJPNFPA> bounds) PJIINDGLAPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x22DFB40", Offset = "0x22DE540", VA = "0x1822DFB40")]
		private void AIIAFPDCKGI((global::GBAIANKGCDO<CBONKODFOND> handles, global::GBAIANKGCDO<DDIAOJPNFPA> bounds) PJIINDGLAPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x22DFEE0", Offset = "0x22DE8E0", VA = "0x1822DFEE0")]
		private void DBPKCDNEICN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x22DFDA0", Offset = "0x22DE7A0", VA = "0x1822DFDA0")]
		private void CLIDAMHJMGA(EntityQuery NBKDJEEFFOH, out (global::GBAIANKGCDO<Entity> entities, global::GBAIANKGCDO<CBONKODFOND> handles) PJIINDGLAPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x22E00E0", Offset = "0x22DEAE0", VA = "0x1822E00E0")]
		private void NLBJIBIJDDE((global::GBAIANKGCDO<Entity> entities, global::GBAIANKGCDO<CBONKODFOND> handles) PJIINDGLAPJ, FDACAGDBJHG CFFEECEPDJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x22DFF80", Offset = "0x22DE980", VA = "0x1822DFF80")]
		private JobHandle KDFODHEJNHF(FDACAGDBJHG CFFEECEPDJE, ComponentDataFromEntity<WorldPoseData> MPNGIJGPEPH, ComponentDataFromEntity<WorldUniformScaleData> AIGDCDKHAAI, ComponentDataFromEntity<WorldDeformableScaleData> MHPDPNIKLPE)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x22E03D0", Offset = "0x22DEDD0", VA = "0x1822E03D0")]
		private JobHandle OFJHOJJCNJF(FDACAGDBJHG CFFEECEPDJE, ComponentDataFromEntity<WorldPoseData> MPNGIJGPEPH, ComponentDataFromEntity<WorldUniformScaleData> AIGDCDKHAAI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
public struct DEAHLFKFIPG : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[NIHNMLIMMAM]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	public class SplineLocalBoundsSystem : BHPPPHCOIMM
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct OIOEHLPIMGL : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			[ReadOnly]
			public NativeArray<Entity> NHFPCJBNPDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> FACONCCKAPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			[ReadOnly]
			public ComponentDataFromEntity<DDIAOJPNFPA> HDIDDPOKNGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			[WriteOnly]
			public NativeHashMap<Entity, FIGHGNFLDFK>.ParallelWriter EAGINHCICBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter BDHGPIEFEME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter HNMEPCMMFMG;

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x38AD9D0", Offset = "0x38AC3D0", VA = "0x1838AD9D0", Slot = "4")]
			public void Execute(int NENMOOINMCH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[BurstCompile]
		private struct NOGAAHCIGFJ : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			[ReadOnly]
			public NativeArray<Entity> JNLGGBMCPLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> GGDJKIGBOIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> EEBBBDHBPAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> KCJIDJJGOIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<DDIAOJPNFPA> BILBCJHFBLO;

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0x38AD6D0", Offset = "0x38AC0D0", VA = "0x1838AD6D0", Slot = "4")]
			public void Execute(int NENMOOINMCH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private EntityQuery GIMHGPCJIDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery DDOHAIANPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery FFEJPBIJNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery AHMFINKDJED;

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x22F6B00", Offset = "0x22F5500", VA = "0x1822F6B00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x22F6D10", Offset = "0x22F5710", VA = "0x1822F6D10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x22F66F0", Offset = "0x22F50F0", VA = "0x1822F66F0")]
		private JobHandle FAMBNMOFFCN(global::GBAIANKGCDO<Entity> EIOACKOCJCB, int LOHIKBMAMJE, JobHandle PMDPDMNKEOL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x22F6510", Offset = "0x22F4F10", VA = "0x1822F6510")]
		private JobHandle FAMBNMOFFCN(NativeArray<Entity> OGGDAPIKFCJ, int LOHIKBMAMJE, [Optional] JobHandle PMDPDMNKEOL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x22F7230", Offset = "0x22F5C30", VA = "0x1822F7230")]
		private global::GBAIANKGCDO<Entity> PCJAJNJJJPI(EntityQuery NBKDJEEFFOH)
		{
			return default(global::GBAIANKGCDO<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x22F60C0", Offset = "0x22F4AC0", VA = "0x1822F60C0")]
		private (global::OIEIIGDBLKE<Entity>, global::OIEIIGDBLKE<Entity>) DAAEAPHLKIM(global::GBAIANKGCDO<Entity> PPFKLDLPECN)
		{
			return default((global::OIEIIGDBLKE<Entity>, global::OIEIIGDBLKE<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x22F6030", Offset = "0x22F4A30", VA = "0x1822F6030")]
		private void BPGBEEPPHDN(out NativeArray<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x22F5FA0", Offset = "0x22F49A0", VA = "0x1822F5FA0")]
		private void BFJLJKKEBKO(NativeList<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x22F5ED0", Offset = "0x22F48D0", VA = "0x1822F5ED0")]
		private void BFJLJKKEBKO(NativeArray<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x22F5DA0", Offset = "0x22F47A0", VA = "0x1822F5DA0")]
		private void ABFBNDDCELB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		private static void DMBKCKFCMOK(int CCINHAHKDFA, int IDPBMAMMMPD, int CFKHNHOLDGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x22F67D0", Offset = "0x22F51D0", VA = "0x1822F67D0")]
		private static DDIAOJPNFPA LHCKMPMKPCB(NativeArray<Entity> KHDADJHKDNH, ComponentDataFromEntity<SplinePointPositionData> EEBBBDHBPAA, ComponentDataFromEntity<SplinePointScaleData> KCJIDJJGOIH)
		{
			return default(DDIAOJPNFPA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct ODOLOJNFJOA : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[NIHNMLIMMAM]
	[OJEJDFBPPED(FHFOPEOFOPD.Lifecycle)]
	public class DestroyLocalObjects : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		[MJIDFIFGMKP]
		private ObjectNetworkToLocalMapService JCHNGOPCAEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		[MJIDFIFGMKP]
		private ObjectLifecycleService MBPFMENCMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private EntityQuery MDLLKIHIHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery AONOINDLPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery GBANNBPMDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private bool HHKBONGDECE;

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x24C12B0", Offset = "0x24BFCB0", VA = "0x1824C12B0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x24C1320", Offset = "0x24BFD20", VA = "0x1824C1320")]
		public bool FEJPJOLCEIL(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x24C16D0", Offset = "0x24C00D0", VA = "0x1824C16D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x24C1270", Offset = "0x24BFC70", VA = "0x1824C1270", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x24C1800", Offset = "0x24C0200", VA = "0x1824C1800", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x85F690", Offset = "0x85E090", VA = "0x18085F690", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x24C1270", Offset = "0x24BFC70", VA = "0x1824C1270")]
		private void CJDOLMEFMGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x24C1620", Offset = "0x24C0020", VA = "0x1824C1620")]
		private void KAJEEAAGOKB(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x24C13D0", Offset = "0x24BFDD0", VA = "0x1824C13D0")]
		private void GGMAFCOGGNF(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x24C1510", Offset = "0x24BFF10", VA = "0x1824C1510")]
		private void JAHKBBNEHMF(NativeArray<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x24C1820", Offset = "0x24C0220", VA = "0x1824C1820")]
		private void PKFJCFKOCPO(NativeArray<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.NetworkSend)]
	public sealed class EnqueuePropertyDifferenceToNetwork : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private static FDEHJNLJBIB[] JEJKNGEMPLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private NEHJNAJJJGG DCDNGMLMONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private OBGMOBEFLNM OIDCJIFJONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private PropertyDiffStateService KFIKGKNPMLM;

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x21775A0", Offset = "0x2175FA0", VA = "0x1821775A0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2177BE0", Offset = "0x21765E0", VA = "0x182177BE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2177650", Offset = "0x2176050", VA = "0x182177650")]
		private void EIDAFBIOFBB(FDEHJNLJBIB DJCJKODKOMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		private void NJOADDMPIOL(Entity EBOGCLNNJGN, DPCBAIHHPOK PKBNFFGFIEN, FKCOPGJECPA GPFHBGAIKFH, JCBFEPIJLBN LIGJHPKLNHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[OJEJDFBPPED(FHFOPEOFOPD.Callbacks)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	public sealed class PropertyEventCallbacks : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private PropertyEventCallbacksService PCKMABEFMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private PropertyDiffStateService KFIKGKNPMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TransformOwnershipPhase DJCJKODKOMI;

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x22E6650", Offset = "0x22E5050", VA = "0x1822E6650", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x22E66E0", Offset = "0x22E50E0", VA = "0x1822E66E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[OJEJDFBPPED(FHFOPEOFOPD.NetworkSend)]
	internal class TransmitNetworkDataSystem : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private OOHJCKLNJKJ BLAKODDBFNK;

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x22FE1A0", Offset = "0x22FCBA0", VA = "0x1822FE1A0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x22FE1F0", Offset = "0x22FCBF0", VA = "0x1822FE1F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[NIHNMLIMMAM]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	public class CalculateCullingBandChanges : BHPPPHCOIMM, AHDDAOHEFAN, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[BurstCompile]
		private struct BPEHPLMMHNN : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			[ReadOnly]
			public ArchetypeChunkEntityType PEGOMEONLCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> FNBJEPHMBDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			[WriteOnly]
			public NativeList<KNIHJHENELP>.ParallelWriter MGBGEBNEMMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public ArchetypeChunkComponentType<ECMDPPDFOFE> BDGMAFMMGLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public float3 HGJMJLMOCJK;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private static readonly float4x2 FPLPJJGLJDO;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private static readonly float4x2 MLDMBDPHDOA;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			private static readonly int4x2 GMALGGBKDLG;

			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x22EA250", Offset = "0x22E8C50", VA = "0x1822EA250", Slot = "4")]
			public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private static LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private const int GDHHJGEPOON = 10;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private const double DGIODOEDHGG = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private EntityQuery FNJOBOKKFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private EntityQuery BHAKJGLCOPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private double KOHNMHIKNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private PNLHBOHNCFH MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private CullingBandService DEHLPGMCGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private TimeService MNKJIFJCNIC;

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x24B46F0", Offset = "0x24B30F0", VA = "0x1824B46F0", Slot = "14")]
		public void LMBJCLDJBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x24B42B0", Offset = "0x24B2CB0", VA = "0x1824B42B0", Slot = "15")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x24B4700", Offset = "0x24B3100", VA = "0x1824B4700", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x24B4850", Offset = "0x24B3250", VA = "0x1824B4850", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x24B4340", Offset = "0x24B2D40", VA = "0x1824B4340")]
		private bool ECBLCNFIEDE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x24B43B0", Offset = "0x24B2DB0", VA = "0x1824B43B0")]
		private void FEHFEBNIGCF(EntityQuery NBKDJEEFFOH, float3 OCFAPMLNBGH, string KKJOOAJGLJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public struct KNIHJHENELP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public Entity EBOGCLNNJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public EPCBEODPNAD GKKEBOJKIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public EPCBEODPNAD KMKKONJJIBD;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	public class ProcessCullingBandChangeCallbacks : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private CullingBandService DEHLPGMCGNN;

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x22E3140", Offset = "0x22E1B40", VA = "0x1822E3140", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x22E3190", Offset = "0x22E1B90", VA = "0x1822E3190", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[OJEJDFBPPED(FHFOPEOFOPD.Connectables)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	public class UpdateInertialProperties : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private EntityQuery ENIECKHKGEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private NIFANEBEJCH EJHLJMGABMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x2305560", Offset = "0x2303F60", VA = "0x182305560", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x23055D0", Offset = "0x2303FD0", VA = "0x1823055D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2305660", Offset = "0x2304060", VA = "0x182305660", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[NIHNMLIMMAM]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> IKJAJCFPCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> HAONLEFNCJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MLBGHJOAABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private KinematicSleepChangeService BJJHFOPDGFM;

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x24C89E0", Offset = "0x24C73E0", VA = "0x1824C89E0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x24C9560", Offset = "0x24C7F60", VA = "0x1824C9560", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x24C91F0", Offset = "0x24C7BF0", VA = "0x1824C91F0")]
		private void LNJBECFPHHC(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> AMMGMIDPNEP, EntityQueryDesc AHDLHCKHJBN, bool DBADIFDDPED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x24C9300", Offset = "0x24C7D00", VA = "0x1824C9300")]
		private void LNJBECFPHHC(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> AMMGMIDPNEP, EntityQueryDesc AHDLHCKHJBN, bool DBADIFDDPED, bool IOAHNGHJAJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x24C97C0", Offset = "0x24C81C0", VA = "0x1824C97C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x24C8A30", Offset = "0x24C7430", VA = "0x1824C8A30")]
		private void FDEBFOBAKFP(EntityQuery NBKDJEEFFOH, bool IIKGCKNACHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x24C87D0", Offset = "0x24C71D0", VA = "0x1824C87D0")]
		private void BLGGGNAAKFK(EntityQuery NBKDJEEFFOH, bool LKIJJCOLPNF, bool IIKGCKNACHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x24C8D90", Offset = "0x24C7790", VA = "0x1824C8D90")]
		private void IHBPJIEHJCI(NativeArray<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x24C8C20", Offset = "0x24C7620", VA = "0x1824C8C20")]
		private void FKAJGDBGBHJ(NativeList<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x24C9440", Offset = "0x24C7E40", VA = "0x1824C9440")]
		private void OGLPPFMDDPD(NativeArray<Entity> GBNPHFOKMOH, bool LKIJJCOLPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x24C8FB0", Offset = "0x24C79B0", VA = "0x1824C8FB0")]
		private NativeList<Entity> JDMINIIGLFB(NativeArray<Entity> GBNPHFOKMOH)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x24C91B0", Offset = "0x24C7BB0", VA = "0x1824C91B0")]
		private NativeList<Entity> JPBAIKPNPOF(NativeArray<Entity> GBNPHFOKMOH)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x24C8700", Offset = "0x24C7100", VA = "0x1824C8700")]
		private NativeList<Entity> AMFBOEHNPBH(NativeArray<Entity> GBNPHFOKMOH)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x24C8560", Offset = "0x24C6F60", VA = "0x1824C8560")]
		private NativeList<Entity> AKMAKEGFEDL(NativeArray<Entity> GBNPHFOKMOH, bool COJINAPNILN)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x24C8740", Offset = "0x24C7140", VA = "0x1824C8740")]
		private JJIGFEFOMIE BFAKEDMMIBL(NativeArray<Entity> GBNPHFOKMOH)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(JJIGFEFOMIE);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x24C9AE0", Offset = "0x24C84E0", VA = "0x1824C9AE0")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private KinematicSleepChangeService BJJHFOPDGFM;

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x22E31B0", Offset = "0x22E1BB0", VA = "0x1822E31B0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x22E3200", Offset = "0x22E1C00", VA = "0x1822E3200", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : CDOOAJCMHMN
	{
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private static LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery EHCHOADMGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EntityQuery BPKHEAPEMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private EntityQuery EHMNGDJKJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private EntityQuery GPNPLIFKJDI;

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x24C0EE0", Offset = "0x24BF8E0", VA = "0x1824C0EE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x24C10A0", Offset = "0x24BFAA0", VA = "0x1824C10A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x24C0CA0", Offset = "0x24BF6A0", VA = "0x1824C0CA0")]
		private void GIAGEDCLABG(EntityQuery NBKDJEEFFOH, bool IFLFJKDPDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x24C0A60", Offset = "0x24BF460", VA = "0x1824C0A60")]
		private void FNMPMDDGOMP(EntityQuery NBKDJEEFFOH, bool IFLFJKDPDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[OJEJDFBPPED(FHFOPEOFOPD.Scope)]
	internal class AssignPlayerIdsSystem : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private PNLHBOHNCFH MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private EntityQuery FNCDEBMONHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private EntityQuery CPFKKILOOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private SceneService GBKOJEMNHHK;

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x24ACE00", Offset = "0x24AB800", VA = "0x1824ACE00", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x24AD290", Offset = "0x24ABC90", VA = "0x1824AD290", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x24AD3A0", Offset = "0x24ABDA0", VA = "0x1824AD3A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x24ACFB0", Offset = "0x24AB9B0", VA = "0x1824ACFB0")]
		private void JJOPLBLMBDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x24AD0C0", Offset = "0x24ABAC0", VA = "0x1824AD0C0")]
		private void MCEIKMIAOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x24ACAE0", Offset = "0x24AB4E0", VA = "0x1824ACAE0")]
		private void BKMNIOOPEGA(NativeArray<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x24ACE70", Offset = "0x24AB870", VA = "0x1824ACE70")]
		private void IIPKBECBGLO(NativeArray<Entity> GBNPHFOKMOH, int DLADIELMOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x24AD3C0", Offset = "0x24ABDC0", VA = "0x1824AD3C0")]
		private void POBCIJGNBAG(NativeArray<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x24AD230", Offset = "0x24ABC30", VA = "0x1824AD230")]
		private void NOMMJAOIIEC(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		private static void OHKMCEGCJBB(int GGLJLEEFAFM, Transform MLMJNFGMBPE, Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class NFNGFGNPJAA
{
	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x22CB1B0", Offset = "0x22C9BB0", VA = "0x1822CB1B0")]
	public static bool KAMPCIOKLDL(this SystemBase JGOKKFDANJI, out Entity EBOGCLNNJGN)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery JNHJIOKPKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private DFFINCJAHNC IINKBGHBEBH;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x24B6140", Offset = "0x24B4B40", VA = "0x1824B6140", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x24B6190", Offset = "0x24B4B90", VA = "0x1824B6190", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x24B6250", Offset = "0x24B4C50", VA = "0x1824B6250", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[OJEJDFBPPED(FHFOPEOFOPD.Scope)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<PKDNKOEBNEI>, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private const string FMJCFIDEPCC = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private OAGKEELJIIK MLDHPFBIKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EntityQuery GBMAGEFLEOP;

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		private Entity FOHNELIBBDP
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x2195650", Offset = "0x2194050", VA = "0x182195650")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x2195E00", Offset = "0x2194800", VA = "0x182195E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		private Entity MOEAFGFBGCF
		{
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x21959B0", Offset = "0x21943B0", VA = "0x1821959B0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public CAMBCDMDDIB FKEGLNEOPKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0x21956B0", Offset = "0x21940B0", VA = "0x1821956B0")]
			get
			{
				return default(CAMBCDMDDIB);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x2195FC0", Offset = "0x21949C0", VA = "0x182195FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public CAMBCDMDDIB BHCKFHEALDA
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x2195920", Offset = "0x2194320", VA = "0x182195920")]
			get
			{
				return default(CAMBCDMDDIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2195EA0", Offset = "0x21948A0", VA = "0x182195EA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2195820", Offset = "0x2194220", VA = "0x182195820", Slot = "15")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2195F40", Offset = "0x2194940", VA = "0x182195F40", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2195CB0", Offset = "0x21946B0", VA = "0x182195CB0", Slot = "14")]
		protected override void KCHCNBHPPBK(NativeArray<Entity> GBNPHFOKMOH, NativeArray<Entity> GIEJKEMCJPP, NativeArray<Entity> NJGKDOGKCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2195740", Offset = "0x2194140", VA = "0x182195740")]
		private void ANFOBFCOAPF(NativeArray<Entity> GBNPHFOKMOH, NativeArray<Entity> NJGKDOGKCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2195A10", Offset = "0x2194410", VA = "0x182195A10")]
		private void JOJGNJCAMJO(Entity EBOGCLNNJGN, Entity IDGOEHKPKEH, Entity ODIBHPDOIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x26033B0", Offset = "0x2601DB0", VA = "0x1826033B0")]
		private bool FJMGOOAKNCK<T>(out T NKJMIDIDBOE) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x26032F0", Offset = "0x2601CF0", VA = "0x1826032F0")]
		private void FAKGIPPGMHD<T>(T NKJMIDIDBOE) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x2195890", Offset = "0x2194290", VA = "0x182195890")]
		public bool GDABMFJDMJG(CAMBCDMDDIB PMFLHAIBCJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x21958F0", Offset = "0x21942F0", VA = "0x1821958F0")]
		private static bool GEHCBOMBAEK(CAMBCDMDDIB INFJIALLLKA, CAMBCDMDDIB FNDHOMLGMCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x2196080", Offset = "0x2194A80", VA = "0x182196080")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x2195E60", Offset = "0x2194860", VA = "0x182195E60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[OJEJDFBPPED(FHFOPEOFOPD.Scope)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private EntityQuery NBKDJEEFFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x24BE460", Offset = "0x24BCE60", VA = "0x1824BE460", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x24BE710", Offset = "0x24BD110", VA = "0x1824BE710", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x24BE7B0", Offset = "0x24BD1B0", VA = "0x1824BE7B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x24BE5C0", Offset = "0x24BCFC0", VA = "0x1824BE5C0")]
		private NativeArray<Entity> NHJBIEKECBB(int OOJKDAEFAHE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x24BE4B0", Offset = "0x24BCEB0", VA = "0x1824BE4B0")]
		private void DNLEMFPFMEN(NativeArray<Entity> DOILMOJOADC, NativeArray<Entity> JIJGGIJLGDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[OJEJDFBPPED(FHFOPEOFOPD.Scope)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	internal class HideRemotePivotsNotInScope : BHPPPHCOIMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery MLKDIAMNPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery OOMDAAHKDAF;

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x2182FD0", Offset = "0x21819D0", VA = "0x182182FD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x21830C0", Offset = "0x2181AC0", VA = "0x1821830C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal static class LNJJICMLGLO
{
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public const string JBADEMLDBFI = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x25F5D40", Offset = "0x25F4740", VA = "0x1825F5D40")]
	public static NativeArray<T> BLBHNLEAJKD<T>(NativeArray<Entity> GBNPHFOKMOH, EntityManager KACBFFMHDCF) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x21953E0", Offset = "0x2193DE0", VA = "0x1821953E0")]
	public static void GFGJNKNEEBC(EntityQuery NBKDJEEFFOH, EntityManager KACBFFMHDCF, PPBLJKKDGPH EAFHJAEOKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x2195520", Offset = "0x2193F20", VA = "0x182195520")]
	public static void MEHMGGCFBHN(NativeArray<Entity> DOILMOJOADC, PPBLJKKDGPH EAFHJAEOKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x21952B0", Offset = "0x2193CB0", VA = "0x1821952B0")]
	public static void FCMFFABHHPM(NativeArray<Entity> DOILMOJOADC, PPBLJKKDGPH EAFHJAEOKNI)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.Scope)]
	internal class UpdateContainerPivotOnExitScopeSystem : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private EntityQuery NBKDJEEFFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private TransformService IHDGODIAJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private ObjectLifecycleService MBPFMENCMBK;

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2304310", Offset = "0x2302D10", VA = "0x182304310", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2305460", Offset = "0x2303E60", VA = "0x182305460", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2305500", Offset = "0x2303F00", VA = "0x182305500", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2303B00", Offset = "0x2302500", VA = "0x182303B00")]
		private void CODGBADBFNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2304EC0", Offset = "0x23038C0", VA = "0x182304EC0")]
		private void JLKBIBAIEPG(NativeArray<Entity> DOILMOJOADC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x23045F0", Offset = "0x2302FF0", VA = "0x1823045F0")]
		private void IEOAGDBFMAE(NativeArray<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x23043A0", Offset = "0x2302DA0", VA = "0x1823043A0")]
		private void ELJELCNILIB(NativeArray<Entity> JIJGGIJLGDF, NativeArray<RigidTransform> JCECNHMFOAM, NativeArray<RigidTransform> HFLDIEPOJIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x2304FD0", Offset = "0x23039D0", VA = "0x182304FD0")]
		private void NNGIPBFLKAM(NativeArray<RigidTransform> HFLDIEPOJIC, NativeArray<Entity> JIJGGIJLGDF, NativeList<Entity> CEHPPMGBNCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[OJEJDFBPPED(FHFOPEOFOPD.Scope)]
	internal class PostGameplayOnScopeChange : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery JNHJIOKPKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private EntityQuery EMMDFGHEHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private PNLHBOHNCFH MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x22E16F0", Offset = "0x22E00F0", VA = "0x1822E16F0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x22E17D0", Offset = "0x22E01D0", VA = "0x1822E17D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x22E1920", Offset = "0x22E0320", VA = "0x1822E1920", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x22E1760", Offset = "0x22E0160", VA = "0x1822E1760")]
		private void DOKIHKBLMPC(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[OJEJDFBPPED(FHFOPEOFOPD.Scope)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	internal class PreventDisembodiedScopesSystem : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EntityQuery EOJLGAPADHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityHierarchyParents MBAGNKEDBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private DFFINCJAHNC IINKBGHBEBH;

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x22E2FB0", Offset = "0x22E19B0", VA = "0x1822E2FB0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x22E3040", Offset = "0x22E1A40", VA = "0x1822E3040", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x22E30E0", Offset = "0x22E1AE0", VA = "0x1822E30E0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x22E2E20", Offset = "0x22E1820", VA = "0x1822E2E20")]
		private void CMIMCEHJIIP(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.Scope)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<MCFDCLHJELN>
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x22EEF50", Offset = "0x22ED950", VA = "0x1822EEF50", Slot = "14")]
		protected override void KCHCNBHPPBK(NativeArray<Entity> GBNPHFOKMOH, NativeArray<Entity> GIEJKEMCJPP, NativeArray<Entity> NJGKDOGKCEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x22EF0A0", Offset = "0x22EDAA0", VA = "0x1822EF0A0")]
		[BurstCompile]
		private static void KCHCNBHPPBK(NativeArray<Entity> GBNPHFOKMOH, NativeArray<Entity> NJGKDOGKCEJ, ComponentDataFromEntity<global::MEDOIICOLPL> NPPGGAHHNFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x22EF1B0", Offset = "0x22EDBB0", VA = "0x1822EF1B0")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x22EF170", Offset = "0x22EDB70", VA = "0x1822EF170", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[OJEJDFBPPED(FHFOPEOFOPD.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : BHPPPHCOIMM where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private EntityQuery AMFPOPGNGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery HNDJLKECGMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery BJHAFHAMOIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private EntityQuery FBHPJJHKCLC;

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2B90770", Offset = "0x2B8F170", VA = "0x182B90770", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2B90970", Offset = "0x2B8F370", VA = "0x182B90970", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x2B90940", Offset = "0x2B8F340", VA = "0x182B90940", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F980", Offset = "0x2B8E380", VA = "0x182B8F980")]
		private void ELEBAKDGPGA(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FDC0", Offset = "0x2B8E7C0", VA = "0x182B8FDC0")]
		private void MOJLPLNFDOO(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x2B8ECA0", Offset = "0x2B8D6A0", VA = "0x182B8ECA0")]
		private void CEEHDCJLDDJ(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void KCHCNBHPPBK(NativeArray<Entity> GBNPHFOKMOH, NativeArray<Entity> GIEJKEMCJPP, NativeArray<Entity> NJGKDOGKCEJ);

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x1E76E40", Offset = "0x1E75840", VA = "0x181E76E40")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x1E76C90", Offset = "0x1E75690", VA = "0x181E76C90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public sealed class LAOIAIBNKFP : BHPPPHCOIMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private List<(EntityQuery, ComponentType)> MCCJMCMAHMN;

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x218F7A0", Offset = "0x218E1A0", VA = "0x18218F7A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x218F9A0", Offset = "0x218E3A0", VA = "0x18218F9A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x218FAF0", Offset = "0x218E4F0", VA = "0x18218FAF0")]
	public LAOIAIBNKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct NFKCIHDNKDO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public int HMIPEGLEEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public int MIEMBAEOINL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0x217CE10", Offset = "0x217B810", VA = "0x18217CE10")]
	public static Entity MFJMDPBHOLK(NFKCIHDNKDO PJIINDGLAPJ)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x217CE10", Offset = "0x217B810", VA = "0x18217CE10")]
	public static NFKCIHDNKDO MFJMDPBHOLK(Entity EBOGCLNNJGN)
	{
		return default(NFKCIHDNKDO);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct BBOFPLGBDKE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public struct ECJHKPGPIGK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public readonly ComponentType DKBELBDDPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public readonly NativeList<int> BBEAMCNAAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public readonly NativeList<int> OJIGBPGODCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public readonly NativeArray<Entity> GBNPHFOKMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public readonly NativeArray<Entity> GMJMHKAOEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public readonly NativeArray<byte> ANPMDMMFNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly NativeArray<byte> LOILLHLIIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public readonly int KEMBPIGDPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public readonly int KMDBOKHGOJD;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool FDIHEIBMLHO
	{
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x24C2300", Offset = "0x24C0D00", VA = "0x1824C2300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x24C2380", Offset = "0x24C0D80", VA = "0x1824C2380")]
	public ECJHKPGPIGK(ComponentType DKBELBDDPBK, NativeList<int> BBEAMCNAAON, NativeList<int> OJIGBPGODCB, NativeArray<Entity> GBNPHFOKMOH, NativeArray<Entity> GMJMHKAOEIM, NativeArray<byte> ANPMDMMFNGA, NativeArray<byte> LOILLHLIIPD, int KEMBPIGDPAP, int KMDBOKHGOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x24C20E0", Offset = "0x24C0AE0", VA = "0x1824C20E0")]
	private DCNFIHFHOLK JJONBEFELFC(NativeArray<byte> EIOACKOCJCB, int NENMOOINMCH)
	{
		return default(DCNFIHFHOLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	private T JJONBEFELFC<T>(NativeArray<byte> EIOACKOCJCB, int NENMOOINMCH) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x24C1F60", Offset = "0x24C0960", VA = "0x1824C1F60")]
	public DCNFIHFHOLK BHJFPHKKLJK(int NENMOOINMCH)
	{
		return default(DCNFIHFHOLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	public T BHJFPHKKLJK<T>(int NENMOOINMCH) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x24C2090", Offset = "0x24C0A90", VA = "0x1824C2090")]
	public DCNFIHFHOLK GIAEJODLJJP(int NENMOOINMCH)
	{
		return default(DCNFIHFHOLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	public T GIAEJODLJJP<T>(int NENMOOINMCH) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x24C1FB0", Offset = "0x24C09B0", VA = "0x1824C1FB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public readonly struct BBLGMGGDHOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public readonly EntityQuery NBKDJEEFFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public readonly NativeArray<MNFCNEPKHHC> CDGNAONMFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public readonly ComponentType DKBELBDDPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public readonly int KEMBPIGDPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public readonly int KMDBOKHGOJD;

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x24ADDD0", Offset = "0x24AC7D0", VA = "0x1824ADDD0")]
	public BBLGMGGDHOB(ComponentType DKBELBDDPBK, int KEMBPIGDPAP, int KMDBOKHGOJD, EntityQuery NBKDJEEFFOH, NativeArray<MNFCNEPKHHC> CDGNAONMFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x24ADD80", Offset = "0x24AC780", VA = "0x1824ADD80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct JNACNAIFFKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public int NENMOOINMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public int MKNEPGMLNMK;

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x8012C0", Offset = "0x7FFCC0", VA = "0x1808012C0")]
	public JNACNAIFFKH(int NENMOOINMCH, int MKNEPGMLNMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct MNFCNEPKHHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public readonly int DDIAPGBIJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public readonly int GCDOPBGGNDP;

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x8012C0", Offset = "0x7FFCC0", VA = "0x1808012C0")]
	public MNFCNEPKHHC(int DDIAPGBIJDD, int GCDOPBGGNDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public struct JCBFEPIJLBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private readonly ACIALDGCHGB ENFGKNDHLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private readonly int KEMBPIGDPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private unsafe readonly byte* ANPMDMMFNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private unsafe readonly byte* LOILLHLIIPD;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool CHKFJDOKALL
	{
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x2186720", Offset = "0x2185120", VA = "0x182186720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public ACIALDGCHGB PNNCAGKBOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x7608C0", Offset = "0x75F2C0", VA = "0x1807608C0")]
		get
		{
			return default(ACIALDGCHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x2186820", Offset = "0x2185220", VA = "0x182186820")]
	public DCNFIHFHOLK MFDMCIAJMJF(Type NFMPIOLJBMO)
	{
		return default(DCNFIHFHOLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x2186730", Offset = "0x2185130", VA = "0x182186730")]
	public DCNFIHFHOLK HHPJJBLOBIP(Type NFMPIOLJBMO)
	{
		return default(DCNFIHFHOLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x17653B0", Offset = "0x1763DB0", VA = "0x1817653B0")]
	public T MFDMCIAJMJF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x1765390", Offset = "0x1763D90", VA = "0x181765390")]
	public T HHPJJBLOBIP<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2186910", Offset = "0x2185310", VA = "0x182186910")]
	public unsafe JCBFEPIJLBN(ACIALDGCHGB ENFGKNDHLNI, int GCDOPBGGNDP, byte* ANPMDMMFNGA, byte* LOILLHLIIPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class ICOEHCLPJID : GEHLDJEIKIH, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private PropertyDiffStateService KFIKGKNPMLM;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected abstract FDEHJNLJBIB EKKLFGDBCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x21854E0", Offset = "0x2183EE0", VA = "0x1821854E0", Slot = "17")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x2185770", Offset = "0x2184170", VA = "0x182185770", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x2185530", Offset = "0x2183F30", VA = "0x182185530", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	protected ICOEHCLPJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public static class PANGFNHLOEA
{
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] BONJBKDKPND;
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[DefaultMember("Item")]
internal class GFMONEBNBCH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly LOOGELFKPLM ENHDLHMFJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly Dictionary<ComponentType, BBLGMGGDHOB> MJPGHPNIEMI;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public BBLGMGGDHOB GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x217D870", Offset = "0x217C270", VA = "0x18217D870")]
		get
		{
			return default(BBLGMGGDHOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x217CE30", Offset = "0x217B830", VA = "0x18217CE30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x217D900", Offset = "0x217C300", VA = "0x18217D900")]
	public GFMONEBNBCH(CAOOBKKGEDI FBFHHMCDIGN, LOOGELFKPLM ENHDLHMFJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x217D800", Offset = "0x217C200", VA = "0x18217D800")]
	public bool OHBNCLEBFJI(ComponentType DKBELBDDPBK, out BBLGMGGDHOB LFIDNIDJNJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x217D260", Offset = "0x217BC60", VA = "0x18217D260")]
	public Dictionary<ComponentType, BBLGMGGDHOB>.Enumerator ICBJEBDOHAE()
	{
		return default(Dictionary<ComponentType, BBLGMGGDHOB>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x217CE80", Offset = "0x217B880", VA = "0x18217CE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x217D3A0", Offset = "0x217BDA0", VA = "0x18217D3A0")]
	private void OECMPHKAKNL(IEnumerable<HNAPDCCEHDA> AENLIFPFJGG, EntityManager KACBFFMHDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x217D2F0", Offset = "0x217BCF0", VA = "0x18217D2F0")]
	private static int LIBKFCMOEDM(HNAPDCCEHDA GLIFANIEIAA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x217D010", Offset = "0x217BA10", VA = "0x18217D010")]
	private static NativeArray<MNFCNEPKHHC> FBLIHGCKDLN(HNAPDCCEHDA GLIFANIEIAA, Allocator FAMNMGKAFPB = Allocator.Persistent)
	{
		return default(NativeArray<MNFCNEPKHHC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal interface PDJBENPAJCF
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool FDIHEIBMLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	World IEBLHEBKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OKGOANNDDHN(out NativeArray<int> KMDLHMGJFFL, Allocator FAMNMGKAFPB);

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MGOIFLBIFAO(ComponentType DKBELBDDPBK, out ECJHKPGPIGK HMAFACKGMMF, out BBLGMGGDHOB GCLPPECGGNL);

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MGOIFLBIFAO(ComponentType DKBELBDDPBK, out ECJHKPGPIGK HMAFACKGMMF);

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ECJHKPGPIGK KFIGAHMHBNO(ComponentType DKBELBDDPBK);

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AFMMMDLGOML BEGHHOIMLMI();

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ANLAMAJNIKC(JobHandle MDLEMMPHNCE);
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
internal interface GLIHCMJNGEO
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	World IEBLHEBKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	GFMONEBNBCH DDGHKOAHDHC
	{
		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	NPOBPDGGINM AMGEFKPBDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	NativeMultiHashMap<Entity, JCBFEPIJLBN> NKIBKKCCINA
	{
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	JobHandle LNNBIBENLDD
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
	bool LCHEDBCCHIE();

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LCFMPIKHEBH();

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PBPJAGKGJDD(ComponentType DKBELBDDPBK, in ECJHKPGPIGK PKHIOJIECIF);

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IAECDGPPEAI(MIJMGOMOBGM PKKAOLKCAGJ, out Entity CDBJBIDGEMD);
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct AFMMMDLGOML
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public struct MMKDOPMNMNN : IEnumerator<JCBFEPIJLBN>, IEnumerator, IDisposable, IEnumerable<JCBFEPIJLBN>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private readonly NativeMultiHashMap<Entity, JCBFEPIJLBN> BINBGBCIPDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private readonly Entity EBOGCLNNJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private NativeMultiHashMapIterator<Entity> AGELBKCAGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private JCBFEPIJLBN LOILLHLIIPD;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public JCBFEPIJLBN OLJIKHALPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0xAEADD0", Offset = "0xAE97D0", VA = "0x180AEADD0", Slot = "4")]
			get
			{
				return default(JCBFEPIJLBN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0x22ECFD0", Offset = "0x22EB9D0", VA = "0x1822ECFD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x22ED020", Offset = "0x22EBA20", VA = "0x1822ED020")]
		internal MMKDOPMNMNN(NativeMultiHashMap<Entity, JCBFEPIJLBN> BINBGBCIPDP, Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x22ECDC0", Offset = "0x22EB7C0", VA = "0x1822ECDC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x22ECD90", Offset = "0x22EB790", VA = "0x1822ECD90")]
		public MMKDOPMNMNN ICBJEBDOHAE()
		{
			return default(MMKDOPMNMNN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x22ECE90", Offset = "0x22EB890", VA = "0x1822ECE90", Slot = "9")]
		private IEnumerator<JCBFEPIJLBN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x22ECF30", Offset = "0x22EB930", VA = "0x1822ECF30", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly GLIHCMJNGEO LPLEHOMFOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly JobHandle JPABIBMPCME;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public int GGAJHCAAFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x24AB890", Offset = "0x24AA290", VA = "0x1824AB890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool CIADPHNANDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x24AB3E0", Offset = "0x24A9DE0", VA = "0x1824AB3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x1B64B70", Offset = "0x1B63570", VA = "0x181B64B70")]
	public AFMMMDLGOML(GLIHCMJNGEO LPLEHOMFOKG, JobHandle JPABIBMPCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x24AB4C0", Offset = "0x24A9EC0", VA = "0x1824AB4C0")]
	public bool DIKACBMEDKC(Allocator FAMNMGKAFPB, out NativeKeyValueArrays<Entity, JCBFEPIJLBN> HHGIFHKDCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x24AB720", Offset = "0x24AA120", VA = "0x1824AB720")]
	public bool OHAJNFCKNKM(Allocator FAMNMGKAFPB, out (NativeArray<Entity> entities, int uniqueCount) HHGIFHKDCCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x24AB600", Offset = "0x24AA000", VA = "0x1824AB600")]
	public MMKDOPMNMNN EBGOEJGAGPE(Entity EBOGCLNNJGN)
	{
		return default(MMKDOPMNMNN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[DefaultMember("Item")]
internal class NPOBPDGGINM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly LOOGELFKPLM ENHDLHMFJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private readonly List<BBLGMGGDHOB> AMMGMIDPNEP;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public BBLGMGGDHOB GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x22CCD00", Offset = "0x22CB700", VA = "0x1822CCD00")]
		get
		{
			return default(BBLGMGGDHOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x22CC780", Offset = "0x22CB180", VA = "0x1822CC780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x22CCD90", Offset = "0x22CB790", VA = "0x1822CCD90")]
	public NPOBPDGGINM(GFMONEBNBCH MJPGHPNIEMI, CAOOBKKGEDI FBFHHMCDIGN, LOOGELFKPLM ENHDLHMFJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x22CC940", Offset = "0x22CB340", VA = "0x1822CC940")]
	public List<BBLGMGGDHOB>.Enumerator ICBJEBDOHAE()
	{
		return default(List<BBLGMGGDHOB>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x22CC7C0", Offset = "0x22CB1C0", VA = "0x1822CC7C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x22CC9C0", Offset = "0x22CB3C0", VA = "0x1822CC9C0")]
	private void OECMPHKAKNL(GFMONEBNBCH MJPGHPNIEMI, EntityManager KACBFFMHDCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class JIKLJHNLJDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly LOOGELFKPLM ENHDLHMFJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly ObjectInstantiationService JFOCGIPFIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly global::CLOECBDOJED<HNAPDCCEHDA> IHGCPFGBPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly World HAAPHOAKHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly EntityManager KACBFFMHDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private NativeHashMap<int, Entity> BNIMPMJCIHE;

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x2189290", Offset = "0x2187C90", VA = "0x182189290")]
	public JIKLJHNLJDH(ObjectInstantiationService JFOCGIPFIDL, CAOOBKKGEDI FBFHHMCDIGN, LOOGELFKPLM ENHDLHMFJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x2188720", Offset = "0x2187120", VA = "0x182188720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x2188D20", Offset = "0x2187720", VA = "0x182188D20")]
	public bool JDPNPBFEBOM(MIJMGOMOBGM PKKAOLKCAGJ, out Entity CDBJBIDGEMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x2187F50", Offset = "0x2186950", VA = "0x182187F50")]
	private void AOFNNKFJPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x2187A20", Offset = "0x2186420", VA = "0x182187A20")]
	private EntityArchetype ADBOFLIHKKO(EntityArchetype JJEJPMDKLEO)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x2188D80", Offset = "0x2187780", VA = "0x182188D80")]
	public static void JIHBBKDIGFF(EntityManager BFKEFEBKFHL, EntityManager FIDFPIOBDFP, NativeArray<Entity> OAILNMMPLEK, NativeArray<EntityArchetype> FNFKFBECCMF, [Optional] NativeArray<Entity> PHFENFMLELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x21885B0", Offset = "0x2186FB0", VA = "0x1821885B0")]
	[Conditional("DEBUG_BUILD")]
	private static void CMEEFOBCKCA(NativeArray<EntityArchetype> PLLCLBLOMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x21889A0", Offset = "0x21873A0", VA = "0x1821889A0")]
	private static string ELAHFBKAPEK(EntityArchetype FHJHFHLOJMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x2188BE0", Offset = "0x21875E0", VA = "0x182188BE0")]
	[CompilerGenerated]
	internal static void GBBFAJCEOFJ(ref Span<ComponentType> JBHCMAHPKHI, ComponentType NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x21887F0", Offset = "0x21871F0", VA = "0x1821887F0")]
	[CompilerGenerated]
	internal static void EFPNBOIAACO(Span<ComponentType> EIOACKOCJCB, ref Span<ComponentType> JBHCMAHPKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x21891B0", Offset = "0x2187BB0", VA = "0x1821891B0")]
	[CompilerGenerated]
	internal static void OCEDOAJKJMM(Span<ComponentType> EIOACKOCJCB, ref Span<ComponentType> JBHCMAHPKHI, ComponentType FHGGMAKHJCA)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.PropertyChanges)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld NIOFNFBOEKO;

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x24AC970", Offset = "0x24AB370", VA = "0x1824AC970", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x24ACA30", Offset = "0x24AB430", VA = "0x1824ACA30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[AlwaysUpdateSystem]
	[OJEJDFBPPED(FHFOPEOFOPD.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : BHPPPHCOIMM, CFMOGGHLNDM, BGKGLCNGELH
	{
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		[BurstCompile]
		internal struct OPMONEPOBMI : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			[ReadOnly]
			public NativeArray<byte> NDCJPLCIMNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			[ReadOnly]
			public NativeArray<byte> OBLNHMMFPKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			[ReadOnly]
			public NativeArray<MNFCNEPKHHC> IBHNLBOOKKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			[WriteOnly]
			public NativeList<JNACNAIFFKH>.ParallelWriter LNBOMGBACJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public int CLODABEKBGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public int DJIFJDOBKGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public ProfilerMarker PDGGJDPDCEN;

			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x22ED440", Offset = "0x22EBE40", VA = "0x1822ED440", Slot = "4")]
			public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x22ED580", Offset = "0x22EBF80", VA = "0x1822ED580")]
			private unsafe int GDFOCMDKGBN(byte* MLFIONNEAPH, byte* PAHLILOLPHD)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000152")]
		[BurstCompile]
		internal struct NKJBLEDPKNL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			[WriteOnly]
			public NativeList<int> BBEAMCNAAON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			[WriteOnly]
			public NativeList<int> KNNNKADFIKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			[ReadOnly]
			public NativeList<JNACNAIFFKH> AFKHMNNLACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public ProfilerMarker PDGGJDPDCEN;

			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x22ED040", Offset = "0x22EBA40", VA = "0x1822ED040", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000153")]
		[BurstCompile]
		internal struct CGBNBLIJPOF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			[WriteOnly]
			public NativeArray<byte> HLJMEKAOLAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			[ReadOnly]
			public NativeArray<Entity> GBNPHFOKMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			[ReadOnly]
			public LDAFGDLEPJJ EILGKDJJOAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public int KEMBPIGDPAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public ProfilerMarker PDGGJDPDCEN;

			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x22EA7B0", Offset = "0x22E91B0", VA = "0x1822EA7B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct IJOEFBFDHDE : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, JCBFEPIJLBN> BJMKBAMMCBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			[ReadOnly]
			public NativeArray<byte> ANPMDMMFNGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			[ReadOnly]
			public NativeArray<byte> LOILLHLIIPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<Entity> GBNPHFOKMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<MNFCNEPKHHC> PGMCAHMMKFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeList<int> OJIGBPGODCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[ReadOnly]
			public NativeList<int> BBEAMCNAAON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int EHFHLPBAKKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int KMDBOKHGOJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker PDGGJDPDCEN;

			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x22EB980", Offset = "0x22EA380", VA = "0x1822EB980", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private static readonly ProfilerMarker EFDJEDJFBEK;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private static readonly ProfilerMarker KOCNPPEMDON;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private static readonly ProfilerMarker ECLILJJLNEB;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private static readonly ProfilerMarker AECGKDAPADH;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly ProfilerMarker MHJEIONGMCK;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private static readonly ProfilerMarker BCHFIFJIHLE;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private static readonly ProfilerMarker EJHKANFMEEH;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly ProfilerMarker MIFIBNLKCNA;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private static readonly ProfilerMarker GKCHLKHDPOO;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private static readonly ProfilerMarker FDIPPFBPGEO;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private static readonly ProfilerMarker DJOKGBFCLGE;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private static readonly ProfilerMarker BHCAGFIGJNP;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private static readonly ProfilerMarker DMFMMDFDMHC;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private static readonly ProfilerMarker CLPOFHFBBFJ;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private static readonly ProfilerMarker BPPOIMADKEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private PropertyDiffStateService KFIKGKNPMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private EntityQuery BEFOBPJPFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private EntityQuery GCKMHDKPJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private EntityQuery GBANNBPMDKN;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		internal World IEBLHEBKDNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x24B8820", Offset = "0x24B7220", VA = "0x1824B8820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private GLIHCMJNGEO GMPHDOOPDIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x24B7AE0", Offset = "0x24B64E0", VA = "0x1824B7AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x24B7450", Offset = "0x24B5E50", VA = "0x1824B7450", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "15")]
		public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x24B8990", Offset = "0x24B7390", VA = "0x1824B8990", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x24B8B50", Offset = "0x24B7550", VA = "0x1824B8B50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x24B8AE0", Offset = "0x24B74E0", VA = "0x1824B8AE0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x24B6310", Offset = "0x24B4D10", VA = "0x1824B6310")]
		private void ACPDOFBCKGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x24B82D0", Offset = "0x24B6CD0", VA = "0x1824B82D0")]
		internal void GJJABENDCKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x24B7B00", Offset = "0x24B6500", VA = "0x1824B7B00")]
		private void GJJABENDCKL(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x24B65D0", Offset = "0x24B4FD0", VA = "0x1824B65D0")]
		private void APMBBAAICHA(NativeArray<Entity> OAILNMMPLEK, NativeArray<RRObjectPrefabData> JFAFFGGPLOO, ref NativeArray<Entity> DMBJICMFHKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x24B86F0", Offset = "0x24B70F0", VA = "0x1824B86F0")]
		internal void JBDCCIBOEFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x24B82F0", Offset = "0x24B6CF0", VA = "0x1824B82F0")]
		private void JBDCCIBOEFL(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x24B8D90", Offset = "0x24B7790", VA = "0x1824B8D90")]
		internal void PPMHHKBINLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x24B7170", Offset = "0x24B5B70", VA = "0x1824B7170")]
		private void DFOKBHPCNHF(GLIHCMJNGEO LPLEHOMFOKG, BBLGMGGDHOB GCLPPECGGNL, bool DAOCEDFGPFP, ref JobHandle CGBFHAEFFOB, ref JobHandle BLBDGFHPACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x24B7140", Offset = "0x24B5B40", VA = "0x1824B7140")]
		internal bool BIKNELCAALD(in BBLGMGGDHOB PAHLILOLPHD, out JobHandle LGNELGFKAEP, out ECJHKPGPIGK EOPKDEANMHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x24B6810", Offset = "0x24B5210", VA = "0x1824B6810")]
		private bool BIKNELCAALD(in BBLGMGGDHOB PAHLILOLPHD, bool DAOCEDFGPFP, out JobHandle LGNELGFKAEP, out ECJHKPGPIGK EOPKDEANMHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x24B74A0", Offset = "0x24B5EA0", VA = "0x1824B74A0")]
		internal (NativeList<int>, NativeList<int>) ECLGPBEMGOE(NativeList<JNACNAIFFKH> AFKHMNNLACF, int CDECJIFLFKI, JobHandle PMDPDMNKEOL, out JobHandle MDLEMMPHNCE, Allocator FAMNMGKAFPB = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x24B88E0", Offset = "0x24B72E0", VA = "0x1824B88E0")]
		internal static NativeArray<Entity> LHLEAALMJDH(EntityQuery NBKDJEEFFOH, out JobHandle PCJHACAOAPH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x24B78D0", Offset = "0x24B62D0", VA = "0x1824B78D0")]
		internal static NativeArray<byte> FMCJODFHOCD(int GHEBPHBJKNK, out JobHandle PLFEJFDHKII)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x24B8710", Offset = "0x24B7110", VA = "0x1824B8710")]
		internal static NativeArray<byte> JEDMBMEFAFF(EntityQuery NBKDJEEFFOH, int FEFFHDFABJK, out JobHandle PLFEJFDHKII)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x24B8C90", Offset = "0x24B7690", VA = "0x1824B8C90")]
		internal static NativeArray<Entity> PCJAJNJJJPI(EntityQuery NBKDJEEFFOH, out JobHandle PLMMDPLJKBF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x24B7660", Offset = "0x24B6060", VA = "0x1824B7660")]
		internal NativeArray<byte> FLJCPAGDCKD(NativeArray<Entity> GBNPHFOKMOH, BBLGMGGDHOB GCLPPECGGNL, JobHandle PMDPDMNKEOL, out JobHandle MDLEMMPHNCE, Allocator FAMNMGKAFPB = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x24B7950", Offset = "0x24B6350", VA = "0x1824B7950")]
		internal JobHandle GFKJAHFIGCP(in ECJHKPGPIGK PJIINDGLAPJ, in BBLGMGGDHOB GCLPPECGGNL, NativeMultiHashMap<Entity, JCBFEPIJLBN> BJMKBAMMCBA, JobHandle PMDPDMNKEOL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x162BFC0", Offset = "0x162A9C0", VA = "0x18162BFC0")]
		private JobHandle OADMDPMKOCD(JobHandle PKLPODINJAM, JobHandle KNGMCLKLGMG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x162BFC0", Offset = "0x162A9C0", VA = "0x18162BFC0")]
		private JobHandle OADMDPMKOCD(JobHandle PKLPODINJAM, JobHandle KNGMCLKLGMG, JobHandle NPLMHGHBMIK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[OJEJDFBPPED(FHFOPEOFOPD.RenderEffects)]
	internal class PropagateHoverRootTag : KONGHCOOFNM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		public struct EJDGPMEKPLA : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		protected override ComponentType DNEGHNDHNAC
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x22E3A20", Offset = "0x22E2420", VA = "0x1822E3A20", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override ComponentType IFODKMFCPIO
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x22E39F0", Offset = "0x22E23F0", VA = "0x1822E39F0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override ComponentType HBFOJHKOLIN
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x22E39C0", Offset = "0x22E23C0", VA = "0x1822E39C0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x22E3A50", Offset = "0x22E2450", VA = "0x1822E3A50")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[OJEJDFBPPED(FHFOPEOFOPD.RenderEffects)]
	internal class PropagateSelectionRootTag : KONGHCOOFNM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		public struct MCFMJFLIHII : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType DNEGHNDHNAC
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x22E3AC0", Offset = "0x22E24C0", VA = "0x1822E3AC0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType IFODKMFCPIO
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x22E3A90", Offset = "0x22E2490", VA = "0x1822E3A90", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType HBFOJHKOLIN
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x22E3A60", Offset = "0x22E2460", VA = "0x1822E3A60", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x22E3A50", Offset = "0x22E2450", VA = "0x1822E3A50")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[NIHNMLIMMAM]
public class BLELEMGKMBL : CDOOAJCMHMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private EntityQuery NBKDJEEFFOH;

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x24AEB00", Offset = "0x24AD500", VA = "0x1824AEB00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x24AEB90", Offset = "0x24AD590", VA = "0x1824AEB90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public BLELEMGKMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[NIHNMLIMMAM]
public class FJCPBAIEALH : CDOOAJCMHMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct AGCMPJEJIJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		public AGCMPJEJIJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct LKDPLAHGJJK : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200015D")]
		private struct PCPIKJAOLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x200015E")]
			[NoAlias]
			public struct BNCELCOAPJN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000450")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime BFDIEBHDBHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000451")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime FECBLOGLAKF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity OLNAEIIEBBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> CDACFHLEJNK;

			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x38ADE10", Offset = "0x38AC810", VA = "0x1838ADE10")]
			public void JPLJMLJGDEA(FJCPBAIEALH PKCOGNBINGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x38ADD90", Offset = "0x38AC790", VA = "0x1838ADD90")]
			public BNCELCOAPJN AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
			{
				return default(BNCELCOAPJN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public EntityManager KACBFFMHDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public NativeList<Entity> KMMPBNHHAJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private PCPIKJAOLFJ OOLCPOANPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PCPIKJAOLFJ.BNCELCOAPJN* BMEFAIJKJIP;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OAOBLPGJBCM;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LDBNMNEIBFP;

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x38AC940", Offset = "0x38AB340", VA = "0x1838AC940")]
		internal void GJIGCKOOEBM(Entity EBOGCLNNJGN, SplinePointParentData OLLEMKHHKDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x38ACB60", Offset = "0x38AB560", VA = "0x1838ACB60", Slot = "5")]
		public void ReadFromDisplayClass(ref AGCMPJEJIJA AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x38ACB70", Offset = "0x38AB570", VA = "0x1838ACB70", Slot = "6")]
		public void WriteToDisplayClass(ref AGCMPJEJIJA AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x38AC8A0", Offset = "0x38AB2A0", VA = "0x1838AC8A0", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x38ACAB0", Offset = "0x38AB4B0", VA = "0x1838ACAB0")]
		public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, [NoAlias] ref PCPIKJAOLFJ.BNCELCOAPJN AFHMNGPOKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x38AC9B0", Offset = "0x38AB3B0", VA = "0x1838AC9B0")]
		public void JPLJMLJGDEA(FJCPBAIEALH PKCOGNBINGO, ref AGCMPJEJIJA AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x38ACA40", Offset = "0x38AB440", VA = "0x1838ACA40")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void KALMFPFGGJA(ArchetypeChunkIterator* OKNKNNMFMKI, void* EBLJDNAFJJC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery AKLNIAHEBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private ProfilerMarker JHJNLDFGILH;

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x217B280", Offset = "0x2179C80", VA = "0x18217B280", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public FJCPBAIEALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x217B050", Offset = "0x2179A50", VA = "0x18217B050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x217AEF0", Offset = "0x21798F0", VA = "0x18217AEF0")]
	public static EntityQuery MIAAEGCAKJM(ComponentSystemBase PKCOGNBINGO)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[NIHNMLIMMAM]
public class LMENLPGJPHK : CDOOAJCMHMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private EntityQuery LKOPGJIPMEO;

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x21942C0", Offset = "0x2192CC0", VA = "0x1821942C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x2194350", Offset = "0x2192D50", VA = "0x182194350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public LMENLPGJPHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[UpdateAfter(typeof(BLELEMGKMBL))]
public class LDGEINBFLAC : BHPPPHCOIMM
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x218FE80", Offset = "0x218E880", VA = "0x18218FE80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public LDGEINBFLAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public class BHOIDILBMCN : CDOOAJCMHMN, CFMOGGHLNDM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct EEOIDPENILL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public NativeHashMap<DPCBAIHHPOK, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		public EEOIDPENILL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MGMLKEOIGDD : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		private struct KBCIODLPEMN
		{
			[Cpp2IlInjected.Token(Token = "0x2000165")]
			public struct KOBDPDNLFLE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400045D")]
				public LambdaParameterValueProvider_Entity.Runtime BFDIEBHDBHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400045E")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime EIEKIEMABDE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity OLNAEIIEBBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> DFIILICODOH;

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x38AB920", Offset = "0x38AA320", VA = "0x1838AB920")]
			public void JPLJMLJGDEA(BHOIDILBMCN PKCOGNBINGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x38AB8A0", Offset = "0x38AA2A0", VA = "0x1838AB8A0")]
			public KOBDPDNLFLE AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
			{
				return default(KOBDPDNLFLE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public NativeHashMap<DPCBAIHHPOK, Entity> BINBGBCIPDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private KBCIODLPEMN OOLCPOANPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KBCIODLPEMN.KOBDPDNLFLE* BMEFAIJKJIP;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OAOBLPGJBCM;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x22ECBA0", Offset = "0x22EB5A0", VA = "0x1822ECBA0")]
		internal void GJIGCKOOEBM(Entity EBOGCLNNJGN, ObjectNetworkIdComponentData IDAFDPNGPKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x22ECD80", Offset = "0x22EB780", VA = "0x1822ECD80", Slot = "5")]
		public void ReadFromDisplayClass(ref EEOIDPENILL AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x20CBB00", Offset = "0x20CA500", VA = "0x1820CBB00", Slot = "6")]
		public void WriteToDisplayClass(ref EEOIDPENILL AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x22ECB30", Offset = "0x22EB530", VA = "0x1822ECB30", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x22ECCD0", Offset = "0x22EB6D0", VA = "0x1822ECCD0")]
		public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, ref KBCIODLPEMN.KOBDPDNLFLE AFHMNGPOKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x22ECC20", Offset = "0x22EB620", VA = "0x1822ECC20")]
		public void JPLJMLJGDEA(BHOIDILBMCN PKCOGNBINGO, ref EEOIDPENILL AEILCDAFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x22ECC60", Offset = "0x22EB660", VA = "0x1822ECC60")]
		public unsafe static void KALMFPFGGJA(ArchetypeChunkIterator* OKNKNNMFMKI, void* EBLJDNAFJJC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private ObjectNetworkToLocalMapService JCHNGOPCAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private EntityQuery AKLNIAHEBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private ProfilerMarker JHJNLDFGILH;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x24AE3D0", Offset = "0x24ACDD0", VA = "0x1824AE3D0", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x24AE790", Offset = "0x24AD190", VA = "0x1824AE790", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public BHOIDILBMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x24AE590", Offset = "0x24ACF90", VA = "0x1824AE590", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x24AE430", Offset = "0x24ACE30", VA = "0x1824AE430")]
	public static EntityQuery MIAAEGCAKJM(ComponentSystemBase PKCOGNBINGO)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public class BBGNLGPGFED : CDOOAJCMHMN, CFMOGGHLNDM
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct PFFIJOLOFFF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000168")]
		private struct AENDABLPEHG
		{
			[Cpp2IlInjected.Token(Token = "0x2000169")]
			public struct EAIFKJNCFAN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000468")]
				public LambdaParameterValueProvider_Entity.Runtime BFDIEBHDBHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000469")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime LADPHBHFICP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity OLNAEIIEBBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> GLHAGMBDHOO;

			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x38A1F20", Offset = "0x38A0920", VA = "0x1838A1F20")]
			public void JPLJMLJGDEA(BBGNLGPGFED PKCOGNBINGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x38A1EA0", Offset = "0x38A08A0", VA = "0x1838A1EA0")]
			public EAIFKJNCFAN AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
			{
				return default(EAIFKJNCFAN);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public BBGNLGPGFED BCOJLPDMAAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private AENDABLPEHG OOLCPOANPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe AENDABLPEHG.EAIFKJNCFAN* BMEFAIJKJIP;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OAOBLPGJBCM;

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x22ED720", Offset = "0x22EC120", VA = "0x1822ED720")]
		public void GJIGCKOOEBM(Entity EBOGCLNNJGN, ParentData KPGCMCIAAHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x22ED6B0", Offset = "0x22EC0B0", VA = "0x1822ED6B0", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x22ED7F0", Offset = "0x22EC1F0", VA = "0x1822ED7F0")]
		public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, ref AENDABLPEHG.EAIFKJNCFAN AFHMNGPOKJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x22ED740", Offset = "0x22EC140", VA = "0x1822ED740")]
		public void JPLJMLJGDEA(BBGNLGPGFED PKCOGNBINGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x22ED780", Offset = "0x22EC180", VA = "0x1822ED780")]
		public unsafe static void KALMFPFGGJA(ArchetypeChunkIterator* OKNKNNMFMKI, void* EBLJDNAFJJC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private EntityQuery AKLNIAHEBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private ProfilerMarker JHJNLDFGILH;

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x24AD6C0", Offset = "0x24AC0C0", VA = "0x1824AD6C0", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x24ADC70", Offset = "0x24AC670", VA = "0x1824ADC70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public BBGNLGPGFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x24AD720", Offset = "0x24AC120", VA = "0x1824AD720")]
	[CompilerGenerated]
	private void JKEIGEACDPA(Entity EBOGCLNNJGN, ParentData KPGCMCIAAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x24ADA70", Offset = "0x24AC470", VA = "0x1824ADA70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x24AD910", Offset = "0x24AC310", VA = "0x1824AD910")]
	public static EntityQuery MIAAEGCAKJM(ComponentSystemBase PKCOGNBINGO)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public class NKELOPHABHA : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private int HOCOBHMPLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private EntityQuery NBKDJEEFFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private ObjectPrefabs JFOCGIPFIDL;

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x22CBBE0", Offset = "0x22CA5E0", VA = "0x1822CBBE0", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x22CBC30", Offset = "0x22CA630", VA = "0x1822CBC30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x22CBD10", Offset = "0x22CA710", VA = "0x1822CBD10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x22CB840", Offset = "0x22CA240", VA = "0x1822CB840")]
	private void CLDMPADCMBA(Entity EBOGCLNNJGN, MIJMGOMOBGM PKKAOLKCAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public NKELOPHABHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[UpdateBefore(typeof(NKELOPHABHA))]
	[OJEJDFBPPED(FHFOPEOFOPD.Serialization)]
	public class PostLoadAddSceneTagEntity : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private SceneService GBKOJEMNHHK;

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x22E1A30", Offset = "0x22E0430", VA = "0x1822E1A30", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x22E1A80", Offset = "0x22E0480", VA = "0x1822E1A80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[OJEJDFBPPED(FHFOPEOFOPD.Serialization)]
	[GMDIBPFFIEN(AHJKMAKLGJA.OMRoom)]
	public class PostLoadInitializeNetworkId : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		[CompilerGenerated]
		private struct IPPODFFLAFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public NativeHashMap<DPCBAIHHPOK, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
			public IPPODFFLAFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016E")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct AMFNDFPHGDO : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200016F")]
			private struct DIGALFOAEKL
			{
				[Cpp2IlInjected.Token(Token = "0x2000170")]
				[NoAlias]
				public struct DOCHJNKBNPK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400047E")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime BFDIEBHDBHA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400047F")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime DEFLGEDEBEF;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000480")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime EIEKIEMABDE;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity OLNAEIIEBBK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_EntityInQueryIndex JBGJIDHNMDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047D")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> DFIILICODOH;

				[Cpp2IlInjected.Token(Token = "0x6000A19")]
				[Cpp2IlInjected.Address(RVA = "0x38A3AA0", Offset = "0x38A24A0", VA = "0x1838A3AA0")]
				public void JPLJMLJGDEA(PostLoadInitializeNetworkId PKCOGNBINGO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A1A")]
				[Cpp2IlInjected.Address(RVA = "0x38A39F0", Offset = "0x38A23F0", VA = "0x1838A39F0")]
				public DOCHJNKBNPK AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
				{
					return default(DOCHJNKBNPK);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public NativeHashMap<DPCBAIHHPOK, Entity> BINBGBCIPDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private DIGALFOAEKL OOLCPOANPDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe DIGALFOAEKL.DOCHJNKBNPK* BMEFAIJKJIP;

			[Cpp2IlInjected.Token(Token = "0x4000479")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OAOBLPGJBCM;

			[Cpp2IlInjected.Token(Token = "0x400047A")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LDBNMNEIBFP;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x38A2070", Offset = "0x38A0A70", VA = "0x1838A2070")]
			internal void GJIGCKOOEBM(Entity EBOGCLNNJGN, int IEDOKMHGFOO, ref ObjectNetworkIdComponentData IDAFDPNGPKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x22ECD80", Offset = "0x22EB780", VA = "0x1822ECD80", Slot = "5")]
			public void ReadFromDisplayClass(ref IPPODFFLAFC AEILCDAFCEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0x20CBB00", Offset = "0x20CA500", VA = "0x1820CBB00", Slot = "6")]
			public void WriteToDisplayClass(ref IPPODFFLAFC AEILCDAFCEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x38A1F80", Offset = "0x38A0980", VA = "0x1838A1F80", Slot = "4")]
			public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x38A2210", Offset = "0x38A0C10", VA = "0x1838A2210")]
			public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, [NoAlias] ref DIGALFOAEKL.DOCHJNKBNPK AFHMNGPOKJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0x38A2100", Offset = "0x38A0B00", VA = "0x1838A2100")]
			public void JPLJMLJGDEA(PostLoadInitializeNetworkId PKCOGNBINGO, ref IPPODFFLAFC AEILCDAFCEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x38A21A0", Offset = "0x38A0BA0", VA = "0x1838A21A0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void KALMFPFGGJA(ArchetypeChunkIterator* OKNKNNMFMKI, void* EBLJDNAFJJC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[MJIDFIFGMKP]
		private ObjectNetworkToLocalMapService JCHNGOPCAEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		[MJIDFIFGMKP]
		private SceneService HLDGGAOHOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private EntityQuery NBKDJEEFFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private EntityQuery LNBIOOPNKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private ProfilerMarker IHIANPFAILI;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x22E1EF0", Offset = "0x22E08F0", VA = "0x1822E1EF0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x22E2460", Offset = "0x22E0E60", VA = "0x1822E2460", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x22E2100", Offset = "0x22E0B00", VA = "0x1822E2100", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x22E2100", Offset = "0x22E0B00", VA = "0x1822E2100")]
		public void FFMMHJIMHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x22E2500", Offset = "0x22E0F00", VA = "0x1822E2500")]
		private void PKKAAOKALFK(NativeHashMap<DPCBAIHHPOK, Entity> BINBGBCIPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x22E1C90", Offset = "0x22E0690", VA = "0x1822E1C90")]
		private void DAGCDGGHEEG(NativeHashMap<DPCBAIHHPOK, Entity> BINBGBCIPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x22E21D0", Offset = "0x22E0BD0", VA = "0x1822E21D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x22E1F60", Offset = "0x22E0960", VA = "0x1822E1F60")]
		public static EntityQuery ELGCBMGLEAK(ComponentSystemBase PKCOGNBINGO)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
public class KONBPEMPKIF : BHPPPHCOIMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private EntityQuery CFGDOBFBPPH;

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x218CC70", Offset = "0x218B670", VA = "0x18218CC70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x218CD00", Offset = "0x218B700", VA = "0x18218CD00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public KONBPEMPKIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
public class AALDBKMGDBI : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private global::CLOECBDOJED<MHOPCPJOHOK> ICOAFEIODOJ;

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x24A9F60", Offset = "0x24A8960", VA = "0x1824A9F60", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x24AA810", Offset = "0x24A9210", VA = "0x1824AA810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x24A9DD0", Offset = "0x24A87D0", VA = "0x1824A9DD0")]
	private void CPCFJMABEHD(NativeList<EntityArchetype> PLLCLBLOMEP, NativeHashMap<int, FIGHGNFLDFK> GEPDODDBIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x24AA6D0", Offset = "0x24A90D0", VA = "0x1824AA6D0")]
	private Span<int> LNBJBMIJEMA(EntityArchetype FHJHFHLOJMH)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x24AA000", Offset = "0x24A8A00", VA = "0x1824AA000")]
	private bool HNPBIMIPDKK(int FEFFHDFABJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x24AA0D0", Offset = "0x24A8AD0", VA = "0x1824AA0D0")]
	private void IIMNECPPIGP(NativeHashMap<int, FIGHGNFLDFK> GEPDODDBIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public AALDBKMGDBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[OJEJDFBPPED(FHFOPEOFOPD.Serialization)]
	public class PreSerializeRemoveEntities : BHPPPHCOIMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private static LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery DINMLBICEMO;

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x22E2AA0", Offset = "0x22E14A0", VA = "0x1822E2AA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x22E2D20", Offset = "0x22E1720", VA = "0x1822E2D20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[OJEJDFBPPED(FHFOPEOFOPD.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		[CompilerGenerated]
		private struct IANGHPPDMMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public LDAFGDLEPJJ dstComponentData;

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
			[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
			public IANGHPPDMMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x22EAA80", Offset = "0x22E9480", VA = "0x1822EAA80")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct HADFLLIAHKJ : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			[ReadOnly]
			public NativeList<int> BBEAMCNAAON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			[ReadOnly]
			public NativeArray<Entity> GMJMHKAOEIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public LDAFGDLEPJJ AFDHMOGMLON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			[ReadOnly]
			public NativeArray<byte> LOILLHLIIPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public int KEMBPIGDPAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public ComponentType DKBELBDDPBK;

			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0x38A7340", Offset = "0x38A5D40", VA = "0x1838A7340")]
			internal void GJIGCKOOEBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0x38A7520", Offset = "0x38A5F20", VA = "0x1838A7520", Slot = "5")]
			public void ReadFromDisplayClass(ref IANGHPPDMMB AEILCDAFCEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0x38A7330", Offset = "0x38A5D30", VA = "0x1838A7330", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x38A7500", Offset = "0x38A5F00", VA = "0x1838A7500")]
			public void JPLJMLJGDEA(ShadowWorldApplyPropertyDifferencesToShadowWorld PKCOGNBINGO, ref IANGHPPDMMB AEILCDAFCEO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private PropertyDiffStateService KFIKGKNPMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private JobHandle LGIFFEKKMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private JobHandle LIKEAMAIGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private PDJBENPAJCF LPLEHOMFOKG;

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x22F5020", Offset = "0x22F3A20", VA = "0x1822F5020", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x22F4CD0", Offset = "0x22F36D0", VA = "0x1822F4CD0")]
		public JobHandle CCLNNOMLOLC(JobHandle PMDPDMNKEOL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x22F5080", Offset = "0x22F3A80", VA = "0x1822F5080", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x22F4D10", Offset = "0x22F3710", VA = "0x1822F4D10")]
		private bool CJEMBAAAABB(JobHandle PMDPDMNKEOL, int FEFFHDFABJK, out JobHandle LJCGOBJJHCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[ExecuteAlways]
[EAKKFOPCDBA]
[UpdateInGroup(typeof(BHNEECMABCO))]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
internal sealed class LFPNJHCPJDI : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2191460", Offset = "0x218FE60", VA = "0x182191460", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public LFPNJHCPJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[ExecuteAlways]
[EAKKFOPCDBA]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
[UpdateInGroup(typeof(EMOKGMDHBOP))]
internal sealed class JAMNIICJDMC : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2186570", Offset = "0x2184F70", VA = "0x182186570", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public JAMNIICJDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[EAKKFOPCDBA]
[ExecuteAlways]
[UpdateInGroup(typeof(HKMIDKBBHLH))]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
internal sealed class NLNFPJLGBHF : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x22CBEF0", Offset = "0x22CA8F0", VA = "0x1822CBEF0", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public NLNFPJLGBHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[ExecuteAlways]
[EAKKFOPCDBA]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
[UpdateInGroup(typeof(CBJHJIJABNL))]
internal sealed class DGCEJPBNJOO : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x24BF3C0", Offset = "0x24BDDC0", VA = "0x1824BF3C0", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public DGCEJPBNJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal class CMLPBKFEGNK : ICOEHCLPJID
{
	[Cpp2IlInjected.Token(Token = "0x17000122")]
	protected override FDEHJNLJBIB EKKLFGDBCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x6EF470", Offset = "0x6EDE70", VA = "0x1806EF470", Slot = "18")]
		get
		{
			return default(FDEHJNLJBIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x24B2AB0", Offset = "0x24B14B0", VA = "0x1824B2AB0")]
	public CMLPBKFEGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[ExecuteAlways]
[EAKKFOPCDBA]
[UpdateInGroup(typeof(DNBEBJNJPCI))]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
internal sealed class CBIKDCAKALC : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x24B11B0", Offset = "0x24AFBB0", VA = "0x1824B11B0", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public CBIKDCAKALC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class NKHKJDHCGNJ : GFIPAIPJBPC
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public NKHKJDHCGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class HHJKLFCEEDK : ICOEHCLPJID
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	protected override FDEHJNLJBIB EKKLFGDBCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x6A0140", Offset = "0x69EB40", VA = "0x1806A0140", Slot = "18")]
		get
		{
			return default(FDEHJNLJBIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public HHJKLFCEEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[ExecuteAlways]
[EAKKFOPCDBA]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
[UpdateInGroup(typeof(HAHPEEDHECG))]
internal sealed class CNFALBNDNAB : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x24B2AC0", Offset = "0x24B14C0", VA = "0x1824B2AC0", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public CNFALBNDNAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class DDIJOFKCOHH : GFIPAIPJBPC
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public DDIJOFKCOHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class NCMJKLEOLJC : GFIPAIPJBPC
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public NCMJKLEOLJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class CNGOBEGOOFI : BHPPPHCOIMM
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public CNGOBEGOOFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[NIHNMLIMMAM]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
public class PNAKNACIELP : BHPPPHCOIMM, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private TimeService MNKJIFJCNIC;

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x22DDE60", Offset = "0x22DC860", VA = "0x1822DDE60", Slot = "14")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x22DDEB0", Offset = "0x22DC8B0", VA = "0x1822DDEB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public PNAKNACIELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[OJEJDFBPPED(FHFOPEOFOPD.TransformSyncing)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	public class CopyTransformDataFromGameObjects : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[BurstCompile]
		private struct PGGCPIGEPFH : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private const float ONACNKHLGPG = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			[ReadOnly]
			public NativeArray<Entity> GBNPHFOKMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> EKPCJFKHOIE;

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x22ED8A0", Offset = "0x22EC2A0", VA = "0x1822ED8A0", Slot = "4")]
			public void Execute(int NENMOOINMCH, TransformAccess MLMJNFGMBPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0x22EDA60", Offset = "0x22EC460", VA = "0x1822EDA60")]
			private bool IHMBNEGLDMN(float3 KMKKONJJIBD, float3 GKKEBOJKIEH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x22EDAA0", Offset = "0x22EC4A0", VA = "0x1822EDAA0")]
			private bool KLIGAFMIBDA(quaternion KMKKONJJIBD, quaternion GKKEBOJKIEH)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[BurstCompile]
		private struct NPGHCODENAL : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			[ReadOnly]
			public NativeArray<Entity> GBNPHFOKMOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> DLGBOPLCFCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> CENOPEENKEN;

			[Cpp2IlInjected.Token(Token = "0x6000A69")]
			[Cpp2IlInjected.Address(RVA = "0x22ED120", Offset = "0x22EBB20", VA = "0x1822ED120", Slot = "4")]
			public void Execute(int NENMOOINMCH, TransformAccess MLMJNFGMBPE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly LOOGELFKPLM JEKGEOPIPHJ;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private static readonly LOOGELFKPLM BBEALNIGFOE;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private static readonly LOOGELFKPLM ANKFIGACAGG;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private static readonly ProfilerMarker BBHLCMICKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private CDLKPKMAFJJ IKFLCJEPMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private CAOOBKKGEDI FBFHHMCDIGN;

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x24BC6A0", Offset = "0x24BB0A0", VA = "0x1824BC6A0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x24BC710", Offset = "0x24BB110", VA = "0x1824BC710", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x24BC740", Offset = "0x24BB140", VA = "0x1824BC740", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[OJEJDFBPPED(FHFOPEOFOPD.TransformSyncing)]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	public class RegisterTransforms : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct IFHBNILENED : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018A")]
			private struct CPOJKOAMCED
			{
				[Cpp2IlInjected.Token(Token = "0x200018B")]
				public struct JHGDABLMOMB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004B7")]
					public LambdaParameterValueProvider_Entity.Runtime BFDIEBHDBHA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004B8")]
					public LambdaParameterValueProvider_IComponentData<GDMHKLDPMGF>.Runtime IPHLICAFNOI;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004B9")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime NKBGHMMDGMC;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity OLNAEIIEBBK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004B5")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<GDMHKLDPMGF> IKLHKKFJIEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004B6")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> JPGNKMLIPJH;

				[Cpp2IlInjected.Token(Token = "0x6000A84")]
				[Cpp2IlInjected.Address(RVA = "0x38A3890", Offset = "0x38A2290", VA = "0x1838A3890")]
				public void JPLJMLJGDEA(RegisterTransforms PKCOGNBINGO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A85")]
				[Cpp2IlInjected.Address(RVA = "0x38A37D0", Offset = "0x38A21D0", VA = "0x1838A37D0")]
				public JHGDABLMOMB AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
				{
					return default(JHGDABLMOMB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private CPOJKOAMCED OOLCPOANPDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe CPOJKOAMCED.JHGDABLMOMB* BMEFAIJKJIP;

			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate OAOBLPGJBCM;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x38A9DA0", Offset = "0x38A87A0", VA = "0x1838A9DA0")]
			internal void GJIGCKOOEBM(Entity EBOGCLNNJGN, GDMHKLDPMGF CJMIFBGEMCC, Transform MLMJNFGMBPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x38A9CB0", Offset = "0x38A86B0", VA = "0x1838A9CB0", Slot = "4")]
			public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x38A9F20", Offset = "0x38A8920", VA = "0x1838A9F20")]
			public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, ref CPOJKOAMCED.JHGDABLMOMB AFHMNGPOKJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x38A9EA0", Offset = "0x38A88A0", VA = "0x1838A9EA0")]
			public void JPLJMLJGDEA(RegisterTransforms PKCOGNBINGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x38A9EB0", Offset = "0x38A88B0", VA = "0x1838A9EB0")]
			public unsafe static void KALMFPFGGJA(ArchetypeChunkIterator* OKNKNNMFMKI, void* EBLJDNAFJJC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct CAKPLJMCBAK : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct MINHDNIENCF
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				[NoAlias]
				public struct KPPOJBIBENA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004BE")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime BFDIEBHDBHA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004BF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<GDMHKLDPMGF>.Runtime IPHLICAFNOI;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004BC")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity OLNAEIIEBBK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004BD")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<GDMHKLDPMGF> IKLHKKFJIEE;

				[Cpp2IlInjected.Token(Token = "0x6000A8A")]
				[Cpp2IlInjected.Address(RVA = "0x38A3660", Offset = "0x38A2060", VA = "0x1838A3660")]
				public void JPLJMLJGDEA(RegisterTransforms PKCOGNBINGO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8B")]
				[Cpp2IlInjected.Address(RVA = "0x38ACBE0", Offset = "0x38AB5E0", VA = "0x1838ACBE0")]
				public KPPOJBIBENA AGLDCLOBPDF(ref ArchetypeChunk PHICIHAEAEE, int IMLDBKIHOJN, int IGHMMPKLIEG)
				{
					return default(KPPOJBIBENA);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			private MINHDNIENCF OOLCPOANPDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe MINHDNIENCF.KPPOJBIBENA* BMEFAIJKJIP;

			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x38A3580", Offset = "0x38A1F80", VA = "0x1838A3580")]
			internal void GJIGCKOOEBM(Entity EBOGCLNNJGN, GDMHKLDPMGF CJMIFBGEMCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x38A34F0", Offset = "0x38A1EF0", VA = "0x1838A34F0", Slot = "4")]
			public void Execute(ArchetypeChunk FAHOIFKLOIG, int IAHPOJFNEBE, int IAMIDOCEPLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0x38A36C0", Offset = "0x38A20C0", VA = "0x1838A36C0")]
			public void OFKPLPPBDAN(ref ArchetypeChunk FAHOIFKLOIG, [NoAlias] ref MINHDNIENCF.KPPOJBIBENA AFHMNGPOKJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x38A3660", Offset = "0x38A2060", VA = "0x1838A3660")]
			public void JPLJMLJGDEA(RegisterTransforms PKCOGNBINGO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private CDLKPKMAFJJ IKFLCJEPMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private EntityQuery LCINGIJNOMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private EntityQuery KCCENHKKEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private EntityQuery OKBCDEJPAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private EntityQuery LGIBKALPIEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private EntityQuery LGPNBOAIIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private ProfilerMarker DNLEBPAPDGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private EntityQuery GAADPGKPCBP;

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x22EDCB0", Offset = "0x22EC6B0", VA = "0x1822EDCB0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x22EEC20", Offset = "0x22ED620", VA = "0x1822EEC20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x22EEE30", Offset = "0x22ED830", VA = "0x1822EEE30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x22EE320", Offset = "0x22ECD20", VA = "0x1822EE320")]
		private void NIHHCEOMNJK(EntityQuery NBKDJEEFFOH, COAJGMOIFLM IMLENBHHJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x22EDEE0", Offset = "0x22EC8E0", VA = "0x1822EDEE0")]
		private void IHCKDFENEDB(EntityQuery NBKDJEEFFOH, COAJGMOIFLM IMLENBHHJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x22EEDD0", Offset = "0x22ED7D0", VA = "0x1822EEDD0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x22EE560", Offset = "0x22ECF60", VA = "0x1822EE560")]
		private void NNMNPOPONHK(NativeArray<Entity> GBNPHFOKMOH, COAJGMOIFLM IMLENBHHJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x22EE6A0", Offset = "0x22ED0A0", VA = "0x1822EE6A0")]
		[BurstCompile]
		internal static void ODMICNGGJOO(NativeArray<GDMHKLDPMGF> IDMNFHDEHEA, ComponentDataFromEntity<GDMHKLDPMGF> CGGEFHPPLNM, COAJGMOIFLM IMLENBHHJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		private static void IKCBHBOMNHD(Transform MLMJNFGMBPE, Entity EBOGCLNNJGN, int NENMOOINMCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		private static void JPDNAPDAJBJ(Entity EBOGCLNNJGN, int NENMOOINMCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		private static void LLDJDNLJEDC(int NENMOOINMCH, COAJGMOIFLM IMLENBHHJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x22EDD00", Offset = "0x22EC700", VA = "0x1822EDD00")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DJIPEKJMPBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x22EE9B0", Offset = "0x22ED3B0", VA = "0x1822EE9B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x22EDB10", Offset = "0x22EC510", VA = "0x1822EDB10")]
		public static EntityQuery CCLOLDDHIEP(ComponentSystemBase PKCOGNBINGO)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x22EE150", Offset = "0x22ECB50", VA = "0x1822EE150")]
		public static EntityQuery JCKLIOPLBDK(ComponentSystemBase PKCOGNBINGO)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.TransformSyncing)]
	public class CopyTransformDataToGameObjects : BHPPPHCOIMM, CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		[BurstCompile]
		private struct IGGKCABAJHG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> EKPCJFKHOIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			[ReadOnly]
			public NativeArray<Entity> GBNPHFOKMOH;

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x22EB7F0", Offset = "0x22EA1F0", VA = "0x1822EB7F0", Slot = "4")]
			public void Execute(int NENMOOINMCH, TransformAccess MLMJNFGMBPE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[BurstCompile]
		private struct PECJPDGFLBA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> DLGBOPLCFCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[ReadOnly]
			public NativeArray<Entity> GBNPHFOKMOH;

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x22ED610", Offset = "0x22EC010", VA = "0x1822ED610", Slot = "4")]
			public void Execute(int NENMOOINMCH, TransformAccess MLMJNFGMBPE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[BurstCompile]
		private struct ODBNOBIPFHB : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> DLGBOPLCFCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> CENOPEENKEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			[ReadOnly]
			public NativeArray<Entity> GBNPHFOKMOH;

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0x22ED340", Offset = "0x22EBD40", VA = "0x1822ED340", Slot = "4")]
			public void Execute(int NENMOOINMCH, TransformAccess MLMJNFGMBPE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private static readonly LOOGELFKPLM JEKGEOPIPHJ;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private static readonly LOOGELFKPLM BBEALNIGFOE;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private static readonly LOOGELFKPLM ANKFIGACAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private CDLKPKMAFJJ IKFLCJEPMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private EntityQuery BICJBDCLKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private EntityQuery DPLJGIFNAEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private EntityQuery EDFIJLEELNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TransformAccessArray KELKGKJIAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TransformAccessArray EFHIAFODCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TransformAccessArray FHODBHGEILF;

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x24BCBF0", Offset = "0x24BB5F0", VA = "0x1824BCBF0", Slot = "14")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x24BCC40", Offset = "0x24BB640", VA = "0x1824BCC40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x24BCE30", Offset = "0x24BB830", VA = "0x1824BCE30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x24BCEC0", Offset = "0x24BB8C0", VA = "0x1824BCEC0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x24BCEF0", Offset = "0x24BB8F0", VA = "0x1824BCEF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x24BD710", Offset = "0x24BC110", VA = "0x1824BD710")]
		private NativeArray<Entity> PFENEOBPMKM(NativeArray<GDMHKLDPMGF> BBEAMCNAAON, NativeList<Entity> OAILNMMPLEK, TransformAccessArray OEBFFNBPCEM, TransformAccessArray NJMKLAFIAAO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.TransformSyncing)]
	public class CopyTransformParentsToGameObjects : BHPPPHCOIMM, BGKGLCNGELH
	{
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private NENJKMNFLCL OBCBMCKPGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private MLCLABHKFLP NEOFPONMGGP;

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x22E30E0", Offset = "0x22E1AE0", VA = "0x1822E30E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x24BDBC0", Offset = "0x24BC5C0", VA = "0x1824BDBC0", Slot = "14")]
		public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x24BDCD0", Offset = "0x24BC6D0", VA = "0x1824BDCD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x24BDA40", Offset = "0x24BC440", VA = "0x1824BDA40")]
		private static void JHOFFGJBHID(EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, Entity EGNCPOLPGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x24BD9A0", Offset = "0x24BC3A0", VA = "0x1824BD9A0")]
		private static bool GDFGLFJBJGL(EntityManager KACBFFMHDCF, Entity EBOGCLNNJGN, out Transform MLMJNFGMBPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[OJEJDFBPPED(FHFOPEOFOPD.TransformSyncing)]
	public class L2PToL2WHierarchy : BHPPPHCOIMM
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct HJNNAGPEHCL : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> JOGHILJFGKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> LLDLLGBNDKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> FGOBFODFKAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> OILAOLGJAMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			public ArchetypeChunkComponentType<LocalToWorldData> CMGIKHIDAFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> DACBMNPBGND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public uint KEIPKEPJJGI;

			[Cpp2IlInjected.Token(Token = "0x6000AA5")]
			[Cpp2IlInjected.Address(RVA = "0x38A8F00", Offset = "0x38A7900", VA = "0x1838A8F00")]
			[Conditional("DEBUG_BUILD")]
			private void CJFHHDLNDLB(Entity EBOGCLNNJGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0x38A8FD0", Offset = "0x38A79D0", VA = "0x1838A8FD0", Slot = "4")]
			public void Execute(ArchetypeChunk FAHOIFKLOIG, int NENMOOINMCH, int FLGCMCFKDMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0x38A92C0", Offset = "0x38A7CC0", VA = "0x1838A92C0")]
			private void JOIAOCBOKJO(float4x4 JMPAABODCOH, Entity EBOGCLNNJGN, bool GCABMOOHPDC, int MFAINABGBEA = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private EntityQuery ABKKFJJMKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private EntityQuery FMMLACIGNAB;

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x218F360", Offset = "0x218DD60", VA = "0x18218F360", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x218F480", Offset = "0x218DE80", VA = "0x18218F480", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class BIFGGFJNNIB : DGNMLKMPPHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[BurstCompile]
	private struct DEMCANCNFGH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> JOGHILJFGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public ArchetypeChunkComponentType<LocalToWorldData> CMGIKHIDAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public uint KEIPKEPJJGI;

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x22EA900", Offset = "0x22E9300", VA = "0x1822EA900", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int NENMOOINMCH, int FLGCMCFKDMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x22EAA00", Offset = "0x22E9400", VA = "0x1822EAA00")]
		public bool MMDDDBHAGIN(ArchetypeChunk FAHOIFKLOIG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery ABKKFJJMKCK;

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x24AE8D0", Offset = "0x24AD2D0", VA = "0x1824AE8D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x24AEA00", Offset = "0x24AD400", VA = "0x1824AEA00", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle DMGPNIJLOAA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public BIFGGFJNNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public class OBHHHBPMEFH : DGNMLKMPPHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[BurstCompile]
	private struct JAOCBDEHFLE : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> DEBGMAJGAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public ArchetypeChunkComponentType<WorldPoseData> AAHJNLDJHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> CHODPFHGBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> NPKINCNHGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public uint KEIPKEPJJGI;

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x38AA9D0", Offset = "0x38A93D0", VA = "0x1838AA9D0", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int NENMOOINMCH, int FLGCMCFKDMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x38AAD80", Offset = "0x38A9780", VA = "0x1838AAD80")]
		public bool MMDDDBHAGIN(ArchetypeChunk FAHOIFKLOIG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private EntityQuery IHDGODIAJNC;

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x22CDD50", Offset = "0x22CC750", VA = "0x1822CDD50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x22CDE60", Offset = "0x22CC860", VA = "0x1822CDE60", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle DMGPNIJLOAA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30")]
	public OBHHHBPMEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public class KOAJCJDDFKA : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[BurstCompile]
	private struct EBJKIEHPPFG : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> LFNMKFLJAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> OLOOPBPPPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> KGLGIPMNFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public ArchetypeChunkComponentType<LocalToParentData> PPBGPMGBJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public uint KEIPKEPJJGI;

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x38A3B10", Offset = "0x38A2510", VA = "0x1838A3B10", Slot = "4")]
		public void Execute(ArchetypeChunk FAHOIFKLOIG, int NENMOOINMCH, int FLGCMCFKDMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x38A4220", Offset = "0x38A2C20", VA = "0x1838A4220")]
		public bool MMDDDBHAGIN(ArchetypeChunk FAHOIFKLOIG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private EntityQuery IHDGODIAJNC;

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x218C9D0", Offset = "0x218B3D0", VA = "0x18218C9D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x218CB00", Offset = "0x218B500", VA = "0x18218CB00", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle DMGPNIJLOAA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x857EF0", Offset = "0x8568F0", VA = "0x180857EF0")]
	public KOAJCJDDFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[OJEJDFBPPED(FHFOPEOFOPD.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : KONGHCOOFNM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		public struct JIBFBOBDEGJ : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType DNEGHNDHNAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0x22E3B50", Offset = "0x22E2550", VA = "0x1822E3B50", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override ComponentType IFODKMFCPIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x22E3B20", Offset = "0x22E2520", VA = "0x1822E3B20", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override ComponentType HBFOJHKOLIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0x22E3AF0", Offset = "0x22E24F0", VA = "0x1822E3AF0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x22E3A50", Offset = "0x22E2450", VA = "0x1822E3A50")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x2177D30", Offset = "0x2176730", VA = "0x182177D30", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[PDPPFJNHPKG(IAIEFIFAMIP.Game)]
public class IECAFNKPJBF : HOLLHDBLNEC
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public Type OOGAGJAPDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABF")]
		[Cpp2IlInjected.Address(RVA = "0x2185E70", Offset = "0x2184870", VA = "0x182185E70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Type[] ELLNNFMEONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x2185800", Offset = "0x2184200", VA = "0x182185800", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public IECAFNKPJBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[PDPPFJNHPKG(IAIEFIFAMIP.Loading)]
public class EFLPPCDKOEG : HOLLHDBLNEC
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Type OOGAGJAPDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0x6A0140", Offset = "0x69EB40", VA = "0x1806A0140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type[] ELLNNFMEONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x24C2F30", Offset = "0x24C1930", VA = "0x1824C2F30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public EFLPPCDKOEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public sealed class EIGJDDLAICN : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x24C3720", Offset = "0x24C2120", VA = "0x1824C3720", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public EIGJDDLAICN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[PDPPFJNHPKG(IAIEFIFAMIP.Saving)]
public class AIKAPKDNAFP : HOLLHDBLNEC
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type OOGAGJAPDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0x6A0140", Offset = "0x69EB40", VA = "0x1806A0140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type[] ELLNNFMEONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x24AB980", Offset = "0x24AA380", VA = "0x1824AB980", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public AIKAPKDNAFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public sealed class KLOJLKECGAB : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x218C800", Offset = "0x218B200", VA = "0x18218C800", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public KLOJLKECGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[PDPPFJNHPKG(IAIEFIFAMIP.Simulation)]
public class NMDDHGANNDL : HOLLHDBLNEC
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type OOGAGJAPDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x22CC3F0", Offset = "0x22CADF0", VA = "0x1822CC3F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type[] ELLNNFMEONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x22CC040", Offset = "0x22CAA40", VA = "0x1822CC040", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public NMDDHGANNDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[DNKFJNHNNCA(typeof(AKAFFPOEGJD), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
internal class AKAFFPOEGJD : BGKGLCNGELH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private global::LNGOEAOPLBL<AuthoredParentData, EBOBIFNOFII, DGLJGKMGIBN, AuthoredChildrenData> MCJECBBNNJI;

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x24ABA70", Offset = "0x24AA470", VA = "0x1824ABA70", Slot = "4")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public AKAFFPOEGJD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	[OJEJDFBPPED(FHFOPEOFOPD.HierarchySystems)]
	[DNKFJNHNNCA(typeof(EntityHierarchyParents), new string[] { })]
	internal sealed class EntityHierarchyParents : CFMOGGHLNDM, BGKGLCNGELH
	{
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[MJIDFIFGMKP]
		private NPDHBLHKCNF IHDGODIAJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[MJIDFIFGMKP]
		private PropertyChangeNetworkRouter NBKJPJPMJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private global::MCHJKBDIPIH<Entity> GNIPEANGOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private global::LNGOEAOPLBL<ParentData, PBCNGDCKPOL, JCBNCCOCPAA, ChildrenData> MCJECBBNNJI;

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x2177D40", Offset = "0x2176740", VA = "0x182177D40", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x2178040", Offset = "0x2176A40", VA = "0x182178040", Slot = "5")]
		public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x2177F90", Offset = "0x2176990", VA = "0x182177F90")]
		public Entity INMLOHDEIIC(Entity EBOGCLNNJGN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2177FE0", Offset = "0x21769E0", VA = "0x182177FE0")]
		public bool IOOGAKGECJH(Entity EBOGCLNNJGN, Entity CLJJCFEFLNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x2178140", Offset = "0x2176B40", VA = "0x182178140")]
		public bool PKNDJFHBPIO(Entity EBOGCLNNJGN, Entity CLJJCFEFLNI, bool FLALBEMBEGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2177DB0", Offset = "0x21767B0", VA = "0x182177DB0")]
		private bool FBIGHALIDIH(Entity EBOGCLNNJGN, Entity CLJJCFEFLNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[DNKFJNHNNCA(typeof(HBNKALMIHFD), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
internal sealed class HBNKALMIHFD : CFMOGGHLNDM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	[MJIDFIFGMKP]
	private CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery EEEDEHOCIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private bool HHKBONGDECE;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private EntityManager AJHOIKIBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x2180910", Offset = "0x217F310", VA = "0x182180910")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x217FFE0", Offset = "0x217E9E0", VA = "0x18217FFE0", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x21800E0", Offset = "0x217EAE0", VA = "0x1821800E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2180300", Offset = "0x217ED00", VA = "0x182180300")]
	public bool GGEEMOCPIPE(Entity EBOGCLNNJGN, Entity HBDJLMFKBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x2180570", Offset = "0x217EF70", VA = "0x182180570")]
	public IEnumerable<Entity> IDDFHLAGAON(Entity EBOGCLNNJGN, bool EBLHCCBCAHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x21807E0", Offset = "0x217F1E0", VA = "0x1821807E0")]
	public bool LCEGNLFANNF(Entity EBOGCLNNJGN, Entity AHDACGEMPDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x21803C0", Offset = "0x217EDC0", VA = "0x1821803C0")]
	public bool HADBHNHIDJL(Entity EBOGCLNNJGN, Entity BGIPIHJGIOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x2180960", Offset = "0x217F360", VA = "0x182180960")]
	public NativeList<Entity> NOFFPEJGJBN(Entity EBOGCLNNJGN, bool EBLHCCBCAHD = false, Allocator FAMNMGKAFPB = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x2180100", Offset = "0x217EB00", VA = "0x182180100")]
	public IEnumerable<Entity> FCNKBCKODOP(Entity EBOGCLNNJGN, bool EBLHCCBCAHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x21804C0", Offset = "0x217EEC0", VA = "0x1821804C0")]
	public Entity HFMIOHHMJCK(Entity EBOGCLNNJGN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2180C60", Offset = "0x217F660", VA = "0x182180C60")]
	public NativeArray<Entity> PGPLHJJOJKI()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x2180A40", Offset = "0x217F440", VA = "0x182180A40")]
	public bool OAKKIMOAAKP(Entity BGIPIHJGIOM, Entity ACFAFPAEJAI, out Entity KPPDBEKLBMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x21806F0", Offset = "0x217F0F0", VA = "0x1821806F0")]
	private Entity ILLFLHPGBPK(Entity EBOGCLNNJGN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public HBNKALMIHFD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[OJEJDFBPPED(FHFOPEOFOPD.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x24E3D90", Offset = "0x24E2790", VA = "0x1824E3D90")]
		public static void LCHEDBCCHIE<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(DOMLOFPDLMI KDGPDENJJDJ, global::ILAKDLOENDG<Entity> OKNFKAJADBM, out global::LNGOEAOPLBL<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> ELMPECELMPD) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, LOEAICEFKPI where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, LOEAICEFKPI, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x22DE600", Offset = "0x22DD000", VA = "0x1822DE600")]
		public static bool JFMFHKPFHNF(MPBFDJNFALM GMLENJDKNKH)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public class LNGOEAOPLBL<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, LOEAICEFKPI where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, LOEAICEFKPI, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private static readonly LOOGELFKPLM ENHDLHMFJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly global::MCHJKBDIPIH<Entity> GNIPEANGOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly EOFAFOGAPOE GMPHCJCNOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly BHEGOIHHKIE EGNCPOLPGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly EntityManager KACBFFMHDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly MLCLABHKFLP NEOFPONMGGP;

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x27465A0", Offset = "0x2744FA0", VA = "0x1827465A0")]
	public LNGOEAOPLBL(DOMLOFPDLMI KDGPDENJJDJ, global::ILAKDLOENDG<Entity> OKNFKAJADBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x2745770", Offset = "0x2744170", VA = "0x182745770")]
	private bool GALLDGHJNAK(Entity EBOGCLNNJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x2745250", Offset = "0x2743C50", VA = "0x182745250")]
	private bool CBCKCIILJDC(Entity EBOGCLNNJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x2745AB0", Offset = "0x27444B0", VA = "0x182745AB0")]
	public bool IOOGAKGECJH(Entity EBOGCLNNJGN, in Entity CLJJCFEFLNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x27452A0", Offset = "0x2743CA0", VA = "0x1827452A0")]
	public bool CBKNIJACEHE(Entity EBOGCLNNJGN, in Entity CLJJCFEFLNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x27452D0", Offset = "0x2743CD0", VA = "0x1827452D0")]
	private bool CBKNIJACEHE(Entity EBOGCLNNJGN, in Entity CLJJCFEFLNI, bool DFKDNNHGDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	private static void NLHMMDLDLFL(Entity EBOGCLNNJGN, in Entity CLJJCFEFLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	private static void LKNIDILJEAG(Entity EBOGCLNNJGN, in Entity CLJJCFEFLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	private static void PGJJLFKKEII(Entity EBOGCLNNJGN, in Entity CLJJCFEFLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	private static void PBJLHDJJBDL(Entity EBOGCLNNJGN, in Entity CLJJCFEFLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	private static void AJKACDHBNFD(Entity EBOGCLNNJGN, in Entity CLJJCFEFLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x27457D0", Offset = "0x27441D0", VA = "0x1827457D0")]
	private bool GGEEMOCPIPE(Entity EBOGCLNNJGN, Entity HBDJLMFKBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x2745160", Offset = "0x2743B60", VA = "0x182745160")]
	private void BCDAGFLIDMH(Entity EBOGCLNNJGN, in Entity NKGEBLNPFNO, in Entity CLJJCFEFLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x2745DB0", Offset = "0x27447B0", VA = "0x182745DB0")]
	private void PFEANLMBIME(Entity EBOGCLNNJGN, in Entity NKGEBLNPFNO, in Entity CLJJCFEFLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x2744F60", Offset = "0x2743960", VA = "0x182744F60")]
	private bool AOBNCDDFEME(LKANKGBMCJJ BJPEAPOLHEC, in DPCBAIHHPOK NNCBKAEBBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x2745AE0", Offset = "0x27444E0", VA = "0x182745AE0")]
	private void KHIBJALADHC(Entity EGNCPOLPGCD, Entity AHDACGEMPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x2745990", Offset = "0x2744390", VA = "0x182745990")]
	private void HNICBHANMKL(Entity EGNCPOLPGCD, Entity AHDACGEMPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	private void LLDJDNLJEDC(Entity EBOGCLNNJGN, Entity NKGEBLNPFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	private void IKCBHBOMNHD(Entity EBOGCLNNJGN, Entity CLJJCFEFLNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public struct PBHJEOMHBMI : HPFKDEBDLEN, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public KCHDKMDKNCF AHFGFNJIHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x697F10", Offset = "0x696910", VA = "0x180697F10", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(KCHDKMDKNCF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0xDD6BD0", Offset = "0xDD55D0", VA = "0x180DD6BD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[DNKFJNHNNCA(typeof(ObjectEmbodimentService), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.Embodiment)]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	internal sealed class ObjectEmbodimentService : OKCOAIBIMKN, AHDDAOHEFAN, CFMOGGHLNDM, BGKGLCNGELH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private ObjectLifecycleService MBPFMENCMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[MJIDFIFGMKP]
		private NPDHBLHKCNF IHDGODIAJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[MJIDFIFGMKP]
		private PNLHBOHNCFH MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		[MJIDFIFGMKP]
		private EMCACLLEGIF AKMKADIDNNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		[MJIDFIFGMKP]
		private JGJBJPMJJOJ LFKGMNLDLIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		[MJIDFIFGMKP]
		private TransformOwnershipPhase DJCJKODKOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private readonly Dictionary<DPCBAIHHPOK, DFAIMGIACIM> LBGPAAOCFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private EDBLEEJFIJF DNHOABBNOFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private bool HHKBONGDECE;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		private EntityManager AJHOIKIBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0x22D13A0", Offset = "0x22CFDA0", VA = "0x1822D13A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public int JLMBOKNKKBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0x22CFB10", Offset = "0x22CE510", VA = "0x1822CFB10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public int ODFHOEPDIMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x22D2880", Offset = "0x22D1280", VA = "0x1822D2880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x9ACDB0", Offset = "0x9AB7B0", VA = "0x1809ACDB0", Slot = "4")]
		public void LMBJCLDJBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x22CFB30", Offset = "0x22CE530", VA = "0x1822CFB30", Slot = "5")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x22CF530", Offset = "0x22CDF30", VA = "0x1822CF530")]
		public void BMBFIHPMGIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x22D2180", Offset = "0x22D0B80", VA = "0x1822D2180", Slot = "6")]
		public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x22CFC60", Offset = "0x22CE660", VA = "0x1822CFC60", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x22CF510", Offset = "0x22CDF10", VA = "0x1822CF510")]
		public int BKOOHEDOGKM(SceneTag HJLNDBMKNHI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x22D0D30", Offset = "0x22CF730", VA = "0x1822D0D30")]
		public int JGDNGEJBEMJ(SceneTag HJLNDBMKNHI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x22D06D0", Offset = "0x22CF0D0", VA = "0x1822D06D0")]
		public bool ICEEIOKGIEL(Entity EBOGCLNNJGN, Allocator FAMNMGKAFPB, out NativeList<Entity> OOBNOHIBLDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x22D2DC0", Offset = "0x22D17C0", VA = "0x1822D2DC0")]
		public bool PLEBIPHFMIH(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x22D2660", Offset = "0x22D1060", VA = "0x1822D2660")]
		public bool NCHGJDANBJA(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x22D0B70", Offset = "0x22CF570", VA = "0x1822D0B70")]
		public bool IPHGNDNNICN(Entity EBOGCLNNJGN, out DFAIMGIACIM OFGCILEINOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x22D0BE0", Offset = "0x22CF5E0", VA = "0x1822D0BE0")]
		private bool IPHGNDNNICN(Transform MLMJNFGMBPE, out DFAIMGIACIM OFGCILEINOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x22D0D50", Offset = "0x22CF750", VA = "0x1822D0D50")]
		private void JHLFEHNMDMJ(Entity EBOGCLNNJGN, DFAIMGIACIM OFGCILEINOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x22D0EB0", Offset = "0x22CF8B0", VA = "0x1822D0EB0")]
		private bool KHHBKHMDFBF(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x22D1F80", Offset = "0x22D0980", VA = "0x1822D1F80")]
		public void MKIHEFFHNPG(DPCBAIHHPOK PKBNFFGFIEN, DFAIMGIACIM EJBCCLHPPKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x22CF580", Offset = "0x22CDF80", VA = "0x1822CF580")]
		public bool CAGCNCLOLBE(Entity EBOGCLNNJGN, object KBCPLDFOJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x22D17B0", Offset = "0x22D01B0", VA = "0x1822D17B0")]
		public bool MHAPPCNJPCM(CAMBCDMDDIB BCJDDLNACAB, object KBCPLDFOJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x22D13F0", Offset = "0x22CFDF0", VA = "0x1822D13F0")]
		public bool MHAPPCNJPCM(Entity EBOGCLNNJGN, [Optional] object KBCPLDFOJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x22D1B60", Offset = "0x22D0560", VA = "0x1822D1B60")]
		public bool MHAPPCNJPCM(DFAIMGIACIM GMLENJDKNKH, object KBCPLDFOJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x22D1BB0", Offset = "0x22D05B0", VA = "0x1822D1BB0")]
		public bool MJJCFAGNLND(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x22D1B80", Offset = "0x22D0580", VA = "0x1822D1B80")]
		public bool MJJCFAGNLND(DFAIMGIACIM OFGCILEINOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x22D1440", Offset = "0x22CFE40", VA = "0x1822D1440")]
		public bool MHAPPCNJPCM(DFAIMGIACIM OFGCILEINOG, [Optional] object KBCPLDFOJJL, bool KPPPANMEOGF = false, bool LHNECGHBGLF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x22D22D0", Offset = "0x22D0CD0", VA = "0x1822D22D0")]
		public Transform MOAJKOHAGGC(Entity EBOGCLNNJGN, [Optional] object KBCPLDFOJJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x22CFFC0", Offset = "0x22CE9C0", VA = "0x1822CFFC0")]
		public bool GDFGLFJBJGL(Entity EBOGCLNNJGN, out Transform MLMJNFGMBPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x22D2680", Offset = "0x22D1080", VA = "0x1822D2680")]
		public DFAIMGIACIM NOBOKBCMGFG(Entity EBOGCLNNJGN, [Optional] object KBCPLDFOJJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x22D1110", Offset = "0x22CFB10", VA = "0x1822D1110")]
		public void LJEGCENOOPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x22D2980", Offset = "0x22D1380", VA = "0x1822D2980")]
		public void PFEMHBFNLEK(SceneTag HJLNDBMKNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x22D0310", Offset = "0x22CED10", VA = "0x1822D0310")]
		private void HNPELIAOEBL(Entity EBOGCLNNJGN, bool ALJELMOKJLA, bool LOIDAABPFGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x22D0C90", Offset = "0x22CF690", VA = "0x1822D0C90")]
		private void JDKBLPFCDGC(Entity EBOGCLNNJGN, DFAIMGIACIM OFGCILEINOG, bool ALJELMOKJLA, bool LOIDAABPFGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x22D2830", Offset = "0x22D1230", VA = "0x1822D2830")]
		public DFAIMGIACIM OJDENEBKFDJ(Entity EBOGCLNNJGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x22D2D40", Offset = "0x22D1740", VA = "0x1822D2D40")]
		public bool PHPBEMPIHMH(Entity EBOGCLNNJGN, object KBCPLDFOJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x22CF490", Offset = "0x22CDE90", VA = "0x1822CF490")]
		public bool BHFGGDBKCKN(Entity EBOGCLNNJGN, object KBCPLDFOJJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x22CF420", Offset = "0x22CDE20", VA = "0x1822CF420")]
		public bool BGNDNGOBIED(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x22D0920", Offset = "0x22CF320", VA = "0x1822D0920")]
		public bool ICMCENODBFH(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x22D0990", Offset = "0x22CF390", VA = "0x1822D0990")]
		public bool ICMCENODBFH(KCHDKMDKNCF LGNELGFKAEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void PMNCPDONOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x22D2770", Offset = "0x22D1170", VA = "0x1822D2770")]
		private void NPCPIGGENHJ(bool OLLLLKMDDMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x22D0280", Offset = "0x22CEC80", VA = "0x1822D0280")]
		private bool HKKJFJKKEDB(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x22CF380", Offset = "0x22CDD80", VA = "0x1822CF380")]
		private DFAIMGIACIM ANHMNBFMLEI(Entity EBOGCLNNJGN, object KBCPLDFOJJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x22CF920", Offset = "0x22CE320", VA = "0x1822CF920")]
		private DFAIMGIACIM CJMMNMHFNGO(Entity EBOGCLNNJGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x22D2440", Offset = "0x22D0E40", VA = "0x1822D2440")]
		private (Vector3, Quaternion, Vector3) MOEGOHOHEJM(Entity EBOGCLNNJGN)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x22D0A60", Offset = "0x22CF460", VA = "0x1822D0A60")]
		private void IJJIFDDHNDF(Entity EBOGCLNNJGN, MIJMGOMOBGM PKKAOLKCAGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x22D0DF0", Offset = "0x22CF7F0", VA = "0x1822D0DF0")]
		private void JPMGPMHFBLJ(CAMBCDMDDIB BCJDDLNACAB, DFAIMGIACIM EJBCCLHPPKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x22D0090", Offset = "0x22CEA90", VA = "0x1822D0090")]
		private void GNKMCMBCGKD(DFAIMGIACIM EJBCCLHPPKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x22CFD90", Offset = "0x22CE790", VA = "0x1822CFD90")]
		private void FDNGHAHAKEF(DFAIMGIACIM OFGCILEINOG, Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x22D0ED0", Offset = "0x22CF8D0", VA = "0x1822D0ED0")]
		private void LDFFDFCKMLN(Entity EBOGCLNNJGN, DFAIMGIACIM OFGCILEINOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x22D28A0", Offset = "0x22D12A0", VA = "0x1822D28A0")]
		private void PCONDJJFCIA(Entity EBOGCLNNJGN, Transform MLMJNFGMBPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x217ECF0", Offset = "0x217D6F0", VA = "0x18217ECF0")]
		private CAMBCDMDDIB HEDGBNGAOML(Entity EBOGCLNNJGN)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x22D3060", Offset = "0x22D1A60", VA = "0x1822D3060")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x22D01B0", Offset = "0x22CEBB0", VA = "0x1822D01B0")]
		[CompilerGenerated]
		private void HHKBENCPFFK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal static class JFOJOHJAHFL
{
	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x2186F50", Offset = "0x2185950", VA = "0x182186F50")]
	public static DFAIMGIACIM NOBOKBCMGFG(this ObjectEmbodimentService DDEMFDMAJBL, CAMBCDMDDIB BCJDDLNACAB, [Optional] object KBCPLDFOJJL)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[OJEJDFBPPED(FHFOPEOFOPD.Lifecycle)]
	[DNKFJNHNNCA(typeof(ObjectLifecycleService), new string[] { })]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	internal sealed class ObjectLifecycleService : CFMOGGHLNDM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private ObjectEmbodimentService OFGCILEINOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI FBFHHMCDIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private LEAELDIEDJJ LDJOLKJBDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private DestroyLocalObjects NAHBLLDBMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private bool HHKBONGDECE;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager AJHOIKIBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0x22D40F0", Offset = "0x22D2AF0", VA = "0x1822D40F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<Entity, MIJMGOMOBGM> FPENOLHFJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x22D45E0", Offset = "0x22D2FE0", VA = "0x1822D45E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0x22D37A0", Offset = "0x22D21A0", VA = "0x1822D37A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<Entity> IBBLGEEPNDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x22D3920", Offset = "0x22D2320", VA = "0x1822D3920")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0x22D3DF0", Offset = "0x22D27F0", VA = "0x1822D3DF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x22D3840", Offset = "0x22D2240", VA = "0x1822D3840", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1450", Offset = "0x7EFE50", VA = "0x1807F1450", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x22D3B10", Offset = "0x22D2510", VA = "0x1822D3B10")]
		public bool HHAMBKOEDIN(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x22D4680", Offset = "0x22D3080", VA = "0x1822D4680")]
		internal void POCKFLCNOPF(Entity EBOGCLNNJGN, MIJMGOMOBGM PKKAOLKCAGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x22D4140", Offset = "0x22D2B40", VA = "0x1822D4140")]
		public void LNOHFPOICNF(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x22D3B90", Offset = "0x22D2590", VA = "0x1822D3B90")]
		public void ILAFCPJPBPM(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x22D39C0", Offset = "0x22D23C0", VA = "0x1822D39C0")]
		private bool EABJLDNNDLA(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x22D3EF0", Offset = "0x22D28F0", VA = "0x1822D3EF0")]
		public void LGJCJPODOEB(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x22D3C30", Offset = "0x22D2630", VA = "0x1822D3C30")]
		private bool JGNANMCPKNK(Entity EBOGCLNNJGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x22D3A80", Offset = "0x22D2480", VA = "0x1822D3A80")]
		public void GNCPPNMILKH(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x22D3E90", Offset = "0x22D2890", VA = "0x1822D3E90")]
		private void KEBOJJBJHOH(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x22D4180", Offset = "0x22D2B80", VA = "0x1822D4180")]
		private void NLENJKFFJKK(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x22D3BE0", Offset = "0x22D25E0", VA = "0x1822D3BE0")]
		public void JAHKBBNEHMF(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		private void OGNNELGGMIB(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x22D43E0", Offset = "0x22D2DE0", VA = "0x1822D43E0")]
		private void OGCFBDGIOKM(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[DNKFJNHNNCA(typeof(ObjectPrefabs), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.Prefabs)]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	internal class ObjectPrefabs : NJEAHKKJHJL, CFMOGGHLNDM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private sealed class NKAFDGDJGDL : IEnumerable<(BKPIKMGJOND, MIJMGOMOBGM)>, IEnumerable, IEnumerator<(BKPIKMGJOND, MIJMGOMOBGM)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private (BKPIKMGJOND primitiveType, MIJMGOMOBGM prefabType) <>2__current;

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
			private (BKPIKMGJOND, MIJMGOMOBGM) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6C")]
				[Cpp2IlInjected.Address(RVA = "0x1B32780", Offset = "0x1B31180", VA = "0x181B32780", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((BKPIKMGJOND, MIJMGOMOBGM));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000138")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6E")]
				[Cpp2IlInjected.Address(RVA = "0x38AD5E0", Offset = "0x38ABFE0", VA = "0x1838AD5E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x22EB5B0", Offset = "0x22E9FB0", VA = "0x1822EB5B0")]
			[DebuggerHidden]
			public NKAFDGDJGDL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0x38AD400", Offset = "0x38ABE00", VA = "0x1838AD400", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0x38AD5A0", Offset = "0x38ABFA0", VA = "0x1838AD5A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0x38AD500", Offset = "0x38ABF00", VA = "0x1838AD500", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(BKPIKMGJOND, MIJMGOMOBGM)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0x38AD500", Offset = "0x38ABF00", VA = "0x1838AD500", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI FBFHHMCDIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private World MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private readonly Dictionary<MIJMGOMOBGM, Entity> JFOCGIPFIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private readonly Dictionary<MIJMGOMOBGM, EntityArchetype> PLLCLBLOMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private readonly Dictionary<BKPIKMGJOND, MIJMGOMOBGM> ILKGAAIDEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private readonly Dictionary<ANCPEPLHJEH, MIJMGOMOBGM> NIKPFMHEANH;

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int OABDNEKKKBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0x22D7040", Offset = "0x22D5A40", VA = "0x1822D7040")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public EntityManager AJHOIKIBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x22D80E0", Offset = "0x22D6AE0", VA = "0x1822D80E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x22D70E0", Offset = "0x22D5AE0", VA = "0x1822D70E0", Slot = "5")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x22D76B0", Offset = "0x22D60B0", VA = "0x1822D76B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x22D7650", Offset = "0x22D6050", VA = "0x1822D7650")]
		internal IEnumerable<Type> DPLOHHDJJHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x22D6F70", Offset = "0x22D5970", VA = "0x1822D6F70")]
		internal KDECOMFEFKC ACGOKOJAIIA(Type NFMPIOLJBMO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x22D6FE0", Offset = "0x22D59E0", VA = "0x1822D6FE0")]
		public EntityArchetype BACLAEBHGNP(MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x22D7C10", Offset = "0x22D6610", VA = "0x1822D7C10")]
		public NativeHashMap<int, EntityArchetype> FCJIBPKHEBG(Allocator FAMNMGKAFPB = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x22D7D90", Offset = "0x22D6790", VA = "0x1822D7D90")]
		public bool GHEBHDHJGAC(MIJMGOMOBGM PKKAOLKCAGJ, out EntityArchetype FHJHFHLOJMH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x22D74C0", Offset = "0x22D5EC0", VA = "0x1822D74C0", Slot = "4")]
		[IteratorStateMachine(typeof(NKAFDGDJGDL))]
		public IEnumerable<(BKPIKMGJOND, MIJMGOMOBGM)> DMDKGMKGICI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x22D7E00", Offset = "0x22D6800", VA = "0x1822D7E00")]
		public Entity HLPEGFGOKMH(MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x22D81C0", Offset = "0x22D6BC0", VA = "0x1822D81C0")]
		public MIJMGOMOBGM PGEKFHHBGMN(ANCPEPLHJEH NFMPIOLJBMO)
		{
			return default(MIJMGOMOBGM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x22D8160", Offset = "0x22D6B60", VA = "0x1822D8160")]
		public MIJMGOMOBGM PGEKFHHBGMN(BKPIKMGJOND NFMPIOLJBMO)
		{
			return default(MIJMGOMOBGM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x22D8220", Offset = "0x22D6C20", VA = "0x1822D8220")]
		public NativeHashMap<int, Entity> PKIELKECFGO(Allocator FAMNMGKAFPB = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x22D7090", Offset = "0x22D5A90", VA = "0x1822D7090")]
		public IEnumerable<MIJMGOMOBGM> DBMKCIADOEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x22D8100", Offset = "0x22D6B00", VA = "0x1822D8100")]
		public Entity OFJAKIDPOGE(MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x22D8070", Offset = "0x22D6A70", VA = "0x1822D8070")]
		public bool JDPNPBFEBOM(MIJMGOMOBGM PKKAOLKCAGJ, out Entity CDBJBIDGEMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x22D6B20", Offset = "0x22D5520", VA = "0x1822D6B20")]
		private void AAFCODNKICG(KDECOMFEFKC PJBEIONIIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x22D79E0", Offset = "0x22D63E0", VA = "0x1822D79E0")]
		internal void EEANLPADJDD(MIJMGOMOBGM PKKAOLKCAGJ, LOBFHLEPAGP EBFNKJJAGFC, OPJMAKEOONE DIKJLDJLPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x22D7F10", Offset = "0x22D6910", VA = "0x1822D7F10")]
		private void IMDAMFNLBJK(MIJMGOMOBGM PKKAOLKCAGJ, LOBFHLEPAGP LMCKNIENCJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x22D7530", Offset = "0x22D5F30", VA = "0x1822D7530")]
		internal Entity DONNEKCBPPC(MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x22D83E0", Offset = "0x22D6DE0", VA = "0x1822D83E0")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public enum FDEHJNLJBIB
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface PHOKCCHANKO
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	World IEBLHEBKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	GFMONEBNBCH DDGHKOAHDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
internal class FJKGLPFAMLH : GLIHCMJNGEO, PDJBENPAJCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly BCLMPNPPENP HFELALOOPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private readonly FDEHJNLJBIB DJCJKODKOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private readonly List<ECJHKPGPIGK> PMMJLCADHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private NativeMultiHashMap<Entity, JCBFEPIJLBN> GGHAFBCJPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private NativeHashMap<int, int> GKEOPHPFBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private JobHandle NMMGKIBGONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private JobHandle GAPNOMNHNJC;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private World JDFCEPPFKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x217BC10", Offset = "0x217A610", VA = "0x18217BC10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private GFMONEBNBCH IBLENAFNDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x217C2D0", Offset = "0x217ACD0", VA = "0x18217C2D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private NPOBPDGGINM MMMGICKGLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x217BB00", Offset = "0x217A500", VA = "0x18217BB00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private NativeMultiHashMap<Entity, JCBFEPIJLBN> IMAELMFNDIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0xB818C0", Offset = "0xB802C0", VA = "0x180B818C0", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, JCBFEPIJLBN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JobHandle ODHLECBCOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0xABB920", Offset = "0xABA320", VA = "0x180ABB920", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0xABB910", Offset = "0xABA310", VA = "0x180ABB910", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private bool FDJBPIPBPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x217BAF0", Offset = "0x217A4F0", VA = "0x18217BAF0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private World DOGJMEEMIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x217C2F0", Offset = "0x217ACF0", VA = "0x18217C2F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x217C440", Offset = "0x217AE40", VA = "0x18217C440")]
	public FJKGLPFAMLH(BCLMPNPPENP HFELALOOPKG, FDEHJNLJBIB DJCJKODKOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x217C210", Offset = "0x217AC10", VA = "0x18217C210", Slot = "11")]
	private void LNJJFCAJMHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x217B7B0", Offset = "0x217A1B0", VA = "0x18217B7B0", Slot = "10")]
	private bool GBMKAMAKNML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x217BB20", Offset = "0x217A520", VA = "0x18217BB20", Slot = "12")]
	private void KCBJDPNICBJ(ComponentType DKBELBDDPBK, in ECJHKPGPIGK PKHIOJIECIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x217C220", Offset = "0x217AC20", VA = "0x18217C220", Slot = "13")]
	private bool NBNMDCBFMPI(MIJMGOMOBGM PKKAOLKCAGJ, out Entity CDBJBIDGEMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x217B580", Offset = "0x2179F80", VA = "0x18217B580", Slot = "16")]
	private bool DFALNPGECEB(out NativeArray<int> KMDLHMGJFFL, Allocator FAMNMGKAFPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x217BC70", Offset = "0x217A670", VA = "0x18217BC70", Slot = "17")]
	private bool KOEOKOKCFBM(ComponentType DKBELBDDPBK, out ECJHKPGPIGK HMAFACKGMMF, out BBLGMGGDHOB GCLPPECGGNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x217BE30", Offset = "0x217A830", VA = "0x18217BE30", Slot = "18")]
	private bool KOEOKOKCFBM(ComponentType DKBELBDDPBK, out ECJHKPGPIGK HMAFACKGMMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x217C350", Offset = "0x217AD50", VA = "0x18217C350", Slot = "19")]
	private ECJHKPGPIGK POJLMJBIFID(ComponentType DKBELBDDPBK)
	{
		return default(ECJHKPGPIGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x217C290", Offset = "0x217AC90", VA = "0x18217C290", Slot = "20")]
	private AFMMMDLGOML NKDLJNHOHIH()
	{
		return default(AFMMMDLGOML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x217B540", Offset = "0x2179F40", VA = "0x18217B540", Slot = "21")]
	private void CMNLAHAEAIH(JobHandle MDLEMMPHNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x217BF60", Offset = "0x217A960", VA = "0x18217BF60")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x217B8D0", Offset = "0x217A2D0", VA = "0x18217B8D0")]
	private bool GOFOHBJJJND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x217B620", Offset = "0x217A020", VA = "0x18217B620")]
	private int EGOPCBEDGGN()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
internal class BCLMPNPPENP : PHOKCCHANKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public CAOOBKKGEDI FBFHHMCDIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public ObjectInstantiationService JFOCGIPFIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public GFMONEBNBCH MJPGHPNIEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public NPOBPDGGINM CJIEMELFFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public JIKLJHNLJDH BNIMPMJCIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public bool HHKBONGDECE;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public World IEBLHEBKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x24AE1B0", Offset = "0x24ACBB0", VA = "0x1824AE1B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public GFMONEBNBCH DDGHKOAHDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public BCLMPNPPENP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	[OJEJDFBPPED(FHFOPEOFOPD.PropertyChanges)]
	[DNKFJNHNNCA(typeof(PropertyDiffStateService), new string[] { })]
	internal class PropertyDiffStateService : CFMOGGHLNDM, BGKGLCNGELH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		internal readonly struct GDAPCOEFEEJ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private readonly FDEHJNLJBIB DOOEOBKNDNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private readonly PropertyDiffStateService NGMBPANACIN;

			[Cpp2IlInjected.Token(Token = "0x6000B98")]
			[Cpp2IlInjected.Address(RVA = "0x38A66A0", Offset = "0x38A50A0", VA = "0x1838A66A0")]
			public GDAPCOEFEEJ(PropertyDiffStateService NGMBPANACIN, FDEHJNLJBIB KDLIGIJIGGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0x38A6680", Offset = "0x38A5080", VA = "0x1838A6680", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private readonly BCLMPNPPENP HFELALOOPKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private readonly FJKGLPFAMLH[] EFIKLHPOOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private FDEHJNLJBIB GJECOGHCCHJ;

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public PHOKCCHANKO GKPOOLMICDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8C")]
			[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public PDJBENPAJCF JMHOFCBKAKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0x1DDA9B0", Offset = "0x1DD93B0", VA = "0x181DDA9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public GLIHCMJNGEO PDIFGFADBJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0x1DDA9B0", Offset = "0x1DD93B0", VA = "0x181DDA9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x22E4C90", Offset = "0x22E3690", VA = "0x1822E4C90")]
		public PDJBENPAJCF NBBNJBHKOIN(FDEHJNLJBIB DJCJKODKOMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x22E4C90", Offset = "0x22E3690", VA = "0x1822E4C90")]
		public GLIHCMJNGEO BLOHENMEMNL(FDEHJNLJBIB DJCJKODKOMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x22E4CD0", Offset = "0x22E36D0", VA = "0x1822E4CD0", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x22E4EB0", Offset = "0x22E38B0", VA = "0x1822E4EB0", Slot = "5")]
		public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x22E4E50", Offset = "0x22E3850", VA = "0x1822E4E50")]
		public void LCFMPIKHEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x22E4D50", Offset = "0x22E3750", VA = "0x1822E4D50", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x22E4E30", Offset = "0x22E3830", VA = "0x1822E4E30")]
		public GDAPCOEFEEJ INLCLLMOJNP(FDEHJNLJBIB DJCJKODKOMI)
		{
			return default(GDAPCOEFEEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x22E5220", Offset = "0x22E3C20", VA = "0x1822E5220")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	[DNKFJNHNNCA(typeof(SceneService), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.HierarchySystems)]
	internal class SceneService : CFMOGGHLNDM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public static readonly SceneTag AMHOGOPGBIE;

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public const string KENOAHCNNJB = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private const string GFDCPJNKJHF = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		[MJIDFIFGMKP]
		private HIGEHOPBKAJ LHCGGCJEEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		[MJIDFIFGMKP]
		private ObjectEmbodimentService OFGCILEINOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		[MJIDFIFGMKP]
		private EOFAFOGAPOE MCCJMCMAHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		[MJIDFIFGMKP]
		private SingletonComponentService NHJMBGGICKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private EntityQuery NPBJJDDECMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private EntityQuery FGFGPFHOPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private EntityQuery JIADBJGNGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private Entity LCOCBDGJAGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private bool HHKBONGDECE;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public bool CPKOAMGJHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9A")]
			[Cpp2IlInjected.Address(RVA = "0x22EFC00", Offset = "0x22EE600", VA = "0x1822EFC00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public NativeArray<Entity> LHIPJCFEMAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0x6A3A30", Offset = "0x6A2430", VA = "0x1806A3A30")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0x6A2D40", Offset = "0x6A1740", VA = "0x1806A2D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public Entity FMJEOMIIMKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0x22EF1F0", Offset = "0x22EDBF0", VA = "0x1822EF1F0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public SceneTag HNDCHGONBGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x22F00E0", Offset = "0x22EEAE0", VA = "0x1822F00E0")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public Entity OIAMJOBMDEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x22F00E0", Offset = "0x22EEAE0", VA = "0x1822F00E0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x22EF960", Offset = "0x22EE360", VA = "0x1822EF960")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private EntityManager AJHOIKIBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0x22F01A0", Offset = "0x22EEBA0", VA = "0x1822F01A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x22EF9D0", Offset = "0x22EE3D0", VA = "0x1822EF9D0", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x22EFAB0", Offset = "0x22EE4B0", VA = "0x1822EFAB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x22F0DC0", Offset = "0x22EF7C0", VA = "0x1822F0DC0")]
		public void PPKGKNEOBPL(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x22EFCA0", Offset = "0x22EE6A0", VA = "0x1822EFCA0")]
		public NativeArray<Entity> IEFIFCIHPKF(Allocator FAMNMGKAFPB = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x22F0990", Offset = "0x22EF390", VA = "0x1822F0990")]
		public void NBBMKLJMNLJ(Entity HJLNDBMKNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x22F0A90", Offset = "0x22EF490", VA = "0x1822F0A90")]
		public Entity NGPOAFHPHPD(string KKJOOAJGLJI = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x22EF8A0", Offset = "0x22EE2A0", VA = "0x1822EF8A0")]
		public void CCLLBDKPOAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x22EFC50", Offset = "0x22EE650", VA = "0x1822EFC50")]
		public void GLMFOIIGNMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x22EFE60", Offset = "0x22EE860", VA = "0x1822EFE60")]
		public void INDHPCMABMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x22F0BD0", Offset = "0x22EF5D0", VA = "0x1822F0BD0")]
		public void OFHFJDLGAPC(Entity HJLNDBMKNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x22F01F0", Offset = "0x22EEBF0", VA = "0x1822F01F0")]
		public bool MELCBCDOIPO(Entity HJLNDBMKNHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x22F0B10", Offset = "0x22EF510", VA = "0x1822F0B10")]
		public void NOOJOMMFNFF(Entity HJLNDBMKNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x22EFAF0", Offset = "0x22EE4F0", VA = "0x1822EFAF0")]
		public string EJOLBDMMAKB(Entity HJLNDBMKNHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		public void PHMOLLJBJFP(Entity HJLNDBMKNHI, string KKJOOAJGLJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x22F0130", Offset = "0x22EEB30", VA = "0x1822F0130")]
		public bool LCHJMLAJOGK(string KKJOOAJGLJI, out Entity HJLNDBMKNHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x22EFEC0", Offset = "0x22EE8C0", VA = "0x1822EFEC0")]
		public void JGLDFEHFCPA(Entity HJLNDBMKNHI, bool NPMGJCNBDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x22F0BE0", Offset = "0x22EF5E0", VA = "0x1822F0BE0")]
		public void PLLCNCBIEIF(Entity EBOGCLNNJGN, bool EMIFPNPIIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x22F0C60", Offset = "0x22EF660", VA = "0x1822F0C60")]
		public void PLLCNCBIEIF(NativeArray<Entity> GBNPHFOKMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x22F0CD0", Offset = "0x22EF6D0", VA = "0x1822F0CD0")]
		public void PLLCNCBIEIF(EntityQuery NBKDJEEFFOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x22EF5C0", Offset = "0x22EDFC0", VA = "0x1822EF5C0")]
		public void CANJPDNAGEE(Entity EBOGCLNNJGN, Entity HJLNDBMKNHI, bool EMIFPNPIIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x22EF3E0", Offset = "0x22EDDE0", VA = "0x1822EF3E0")]
		public void CANJPDNAGEE(NativeArray<Entity> GBNPHFOKMOH, Entity HJLNDBMKNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x22EF7F0", Offset = "0x22EE1F0", VA = "0x1822EF7F0")]
		public void CANJPDNAGEE(EntityQuery NBKDJEEFFOH, Entity HJLNDBMKNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x22F07E0", Offset = "0x22EF1E0", VA = "0x1822F07E0")]
		private void MNKGBMBKBNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x22F0150", Offset = "0x22EEB50", VA = "0x1822F0150")]
		private void LEDCLCLCMAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x22EF1F0", Offset = "0x22EDBF0", VA = "0x1822EF1F0")]
		private Entity FJNJNFNLNJL()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x22EFFD0", Offset = "0x22EE9D0", VA = "0x1822EFFD0")]
		private void KMKMNAPMDCL(Entity HJLNDBMKNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x22F0580", Offset = "0x22EEF80", VA = "0x1822F0580")]
		private void MFFHBFDNHDE(EntityQuery OBFMFOEPCHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x22F02A0", Offset = "0x22EECA0", VA = "0x1822F02A0")]
		private void MFFHBFDNHDE(NativeArray<Entity> HLDGGAOHOMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x22F0B20", Offset = "0x22EF520", VA = "0x1822F0B20")]
		private void NOOLDKNOMBI(Entity HJLNDBMKNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x22EFCD0", Offset = "0x22EE6D0", VA = "0x1822EFCD0")]
		private void IGCLPLMGAIB(Entity HJLNDBMKNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x22EF340", Offset = "0x22EDD40", VA = "0x1822EF340")]
		private void BHPFCGKAAOL(SceneTag EHFHHFPIAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x22F0180", Offset = "0x22EEB80", VA = "0x1822F0180")]
		private void LJHCOBOMODD(SceneTag EHFHHFPIAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x22F0650", Offset = "0x22EF050", VA = "0x1822F0650")]
		private void MMGEBGDAEHO(SceneTag EHFHHFPIAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x22EF8C0", Offset = "0x22EE2C0", VA = "0x1822EF8C0")]
		private void CKNAKBEHBFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2450270", Offset = "0x244EC70", VA = "0x182450270")]
		private void NMGLBFGAODH<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void DADOEJILIHP(SceneTag EHFHHFPIAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x22F0080", Offset = "0x22EEA80", VA = "0x1822F0080")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void KODMMOEHNID(EntityQuery NBKDJEEFFOH, string KKJOOAJGLJI, SceneTag EHFHHFPIAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x22EFC70", Offset = "0x22EE670", VA = "0x1822EFC70")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void HCBMMICFHLL(Entity HJLNDBMKNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void KOPIEODAEEK(Entity HJLNDBMKNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[DNKFJNHNNCA(typeof(EFAKDFLPENE), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.HierarchySystems)]
	[DDOFDCHAEEC(AHJKMAKLGJA.PhotonRoom)]
	internal class UnitySceneService : CFMOGGHLNDM, EFAKDFLPENE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[MJIDFIFGMKP]
		private SceneService HLDGGAOHOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private readonly Dictionary<int, Entity> IKHODLKJEDB;

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		private EntityManager AJHOIKIBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCB")]
			[Cpp2IlInjected.Address(RVA = "0x22FF340", Offset = "0x22FDD40", VA = "0x1822FF340")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x22FF0C0", Offset = "0x22FDAC0", VA = "0x1822FF0C0", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x22FF400", Offset = "0x22FDE00", VA = "0x1822FF400", Slot = "5")]
		public void PPKGKNEOBPL(CAMBCDMDDIB BCJDDLNACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x22FF150", Offset = "0x22FDB50", VA = "0x1822FF150", Slot = "6")]
		public bool GDEKOBABKAI(CAMBCDMDDIB BCJDDLNACAB, Transform MLMJNFGMBPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x22FF390", Offset = "0x22FDD90", VA = "0x1822FF390")]
		private bool MPLKFDGKJKF(Scene HJLNDBMKNHI, out Entity MCDFAFFKADA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x22FF570", Offset = "0x22FDF70", VA = "0x1822FF570")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[OJEJDFBPPED(FHFOPEOFOPD.ComponentSystemTypes)]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	[DNKFJNHNNCA(typeof(SingletonComponentService), new string[] { })]
	internal sealed class SingletonComponentService : CFMOGGHLNDM, BGKGLCNGELH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		[MJIDFIFGMKP]
		private EOFAFOGAPOE MCCJMCMAHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private Entity EBOGCLNNJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private LOBFHLEPAGP LMCKNIENCJA;

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public int OABDNEKKKBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0x22F5470", Offset = "0x22F3E70", VA = "0x1822F5470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Entity DOCCAFEJPOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager AJHOIKIBFLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x22F5860", Offset = "0x22F4260", VA = "0x1822F5860")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2451A40", Offset = "0x2450440", VA = "0x182451A40")]
		public T DNANCALJAPO<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x2451B00", Offset = "0x2450500", VA = "0x182451B00")]
		public void LMCGMFHIJLB<T>(T NKJMIDIDBOE) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x22F5480", Offset = "0x22F3E80", VA = "0x1822F5480", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x22F58B0", Offset = "0x22F42B0", VA = "0x1822F58B0", Slot = "5")]
		public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x22F58B0", Offset = "0x22F42B0", VA = "0x1822F58B0")]
		private void MDKBCKMDIOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x22F54F0", Offset = "0x22F3EF0", VA = "0x1822F54F0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x22F5A50", Offset = "0x22F4450", VA = "0x1822F5A50")]
		private LOBFHLEPAGP OPIJMHMLNCL()
		{
			return default(LOBFHLEPAGP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		private static void KHDMBPPAHAG(int OOJKDAEFAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
		private static void ECPHCFDMLKG(Type NFMPIOLJBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x22F57C0", Offset = "0x22F41C0", VA = "0x1822F57C0")]
		private static void HHDBDPPKDPC(Type NFMPIOLJBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001B9")]
internal struct DMMEOCKICJO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
[DNKFJNHNNCA(typeof(JGJBJPMJJOJ), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
internal sealed class JGJBJPMJJOJ : CFMOGGHLNDM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	[MJIDFIFGMKP]
	private CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private global::NNAHOGIEPBH<FEMFPADICHP, Entity> NIPFPPBEEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private global::JLLCOHPACPA<CBLONAMFFKG> OHIOEDCIPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private global::JLLCOHPACPA<BILEFBHPKPL> CLFGDMPHIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private global::JLLCOHPACPA<DPPDDMOPGCK> JFPNHCLEBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private global::JLLCOHPACPA<AHFFEELGGGD> HEEEIAJJNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private global::JLLCOHPACPA<PBHJEOMHBMI> DDEMFDMAJBL;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public global::PGMCMCFAJCB<Entity> NBBPAPFKODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public KDHOHGHKHIH CKNNBDPAAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public KDHOHGHKHIH KEPNOCHPMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public KDHOHGHKHIH ALDNFHAIFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CF0", Offset = "0x6AF6F0", VA = "0x1806B0CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public KDHOHGHKHIH JPCJAAKBEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x6B0AB0", Offset = "0x6AF4B0", VA = "0x1806B0AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public KDHOHGHKHIH KCFLGJGNDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x6AF6F0", Offset = "0x6AE0F0", VA = "0x1806AF6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private EntityManager AJHOIKIBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2187570", Offset = "0x2185F70", VA = "0x182187570")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x2187370", Offset = "0x2185D70", VA = "0x182187370", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x2187480", Offset = "0x2185E80", VA = "0x182187480", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x1767B30", Offset = "0x1766530", VA = "0x181767B30")]
	private void LCHEDBCCHIE<T>(ref global::JLLCOHPACPA<T> FPKBPOKFAHB) where T : struct, HPFKDEBDLEN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x1767B30", Offset = "0x1766530", VA = "0x181767B30")]
	private void LCHEDBCCHIE<TC, TV>(ref global::NNAHOGIEPBH<TC, TV> FPKBPOKFAHB) where TC : struct, HPFKDEBDLEN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public JGJBJPMJJOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[DNKFJNHNNCA(typeof(CDLKPKMAFJJ), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
internal sealed class CDLKPKMAFJJ : AHDDAOHEFAN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private COAJGMOIFLM DKPGKIPLCNC;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public COAJGMOIFLM JJJDFMNAANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x20CB8A0", Offset = "0x20CA2A0", VA = "0x1820CB8A0")]
		get
		{
			return default(COAJGMOIFLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x24B1DC0", Offset = "0x24B07C0", VA = "0x1824B1DC0", Slot = "4")]
	public void LMBJCLDJBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x24B1DB0", Offset = "0x24B07B0", VA = "0x1824B1DB0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public CDLKPKMAFJJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	[DNKFJNHNNCA(typeof(TransformOwnershipPhase), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		public enum MMLKIHNGGGB
		{
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001BE")]
		public struct OEFLIFFOOKC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private MMLKIHNGGGB IEBGFLJLAGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			private readonly TransformOwnershipPhase EGNCPOLPGCD;

			[Cpp2IlInjected.Token(Token = "0x6000BF8")]
			[Cpp2IlInjected.Address(RVA = "0x38AD980", Offset = "0x38AC380", VA = "0x1838AD980")]
			public OEFLIFFOOKC(TransformOwnershipPhase EGNCPOLPGCD, MMLKIHNGGGB DJCJKODKOMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0x38AD960", Offset = "0x38AC360", VA = "0x1838AD960", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public MMLKIHNGGGB DJCJKODKOMI;

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public MMLKIHNGGGB HJNCAGKPGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF0")]
			[Cpp2IlInjected.Address(RVA = "0x6983B0", Offset = "0x696DB0", VA = "0x1806983B0")]
			get
			{
				return default(MMLKIHNGGGB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF1")]
			[Cpp2IlInjected.Address(RVA = "0x7EA9B0", Offset = "0x7E93B0", VA = "0x1807EA9B0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool IMPACPLNFCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0x22F9070", Offset = "0x22F7A70", VA = "0x1822F9070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool HLPCHOGOKMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0xD86460", Offset = "0xD84E60", VA = "0x180D86460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x22F9040", Offset = "0x22F7A40", VA = "0x1822F9040")]
		public OEFLIFFOOKC HAKDGJPLPJF()
		{
			return default(OEFLIFFOOKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x22F9010", Offset = "0x22F7A10", VA = "0x1822F9010")]
		public OEFLIFFOOKC COCGKPGBBKG()
		{
			return default(OEFLIFFOOKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[DNKFJNHNNCA(typeof(PKHFPLBKFGA), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.Circuits)]
	public class CircuitsService : CFMOGGHLNDM, PKHFPLBKFGA
	{
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		[MJIDFIFGMKP]
		private LCENPMLJAKP MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private EntityManager KACBFFMHDCF;

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x24B5170", Offset = "0x24B3B70", VA = "0x1824B5170", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x24B57E0", Offset = "0x24B41E0", VA = "0x1824B57E0", Slot = "5")]
		public bool OGIJGHPHKPI(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x24B5650", Offset = "0x24B4050", VA = "0x1824B5650", Slot = "7")]
		public Guid MPCHBBPIDJE(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x24B4AC0", Offset = "0x24B34C0", VA = "0x1824B4AC0", Slot = "8")]
		public void BGMHMGBAKPC(CAMBCDMDDIB BCJDDLNACAB, Guid PFIEMJAMJJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x24B5580", Offset = "0x24B3F80", VA = "0x1824B5580", Slot = "9")]
		public Guid LCMDCAGGDFL(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x24B5320", Offset = "0x24B3D20", VA = "0x1824B5320", Slot = "10")]
		public void HINOFKHFMGJ(CAMBCDMDDIB BCJDDLNACAB, Guid EOGFAKPPIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x24B5790", Offset = "0x24B4190", VA = "0x1824B5790", Slot = "11")]
		public bool NMEBBKJKKLG(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x24B5720", Offset = "0x24B4120", VA = "0x1824B5720", Slot = "12")]
		public void MPGPCCFHDKB(CAMBCDMDDIB BCJDDLNACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x24B58E0", Offset = "0x24B42E0", VA = "0x1824B58E0", Slot = "13")]
		public void PAOADCJAAEK(CAMBCDMDDIB HGJMJLMOCJK, CAMBCDMDDIB EGNCPOLPGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x24B5000", Offset = "0x24B3A00", VA = "0x1824B5000")]
		private void DHFKHGAIOCB(JBBLNBIIMNB BGHOHMLPNIP, CAMBCDMDDIB EGNCPOLPGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x24B4E70", Offset = "0x24B3870", VA = "0x1824B4E70")]
		private void CJLINACMOJA(JBBLNBIIMNB BGHOHMLPNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x24B4D20", Offset = "0x24B3720", VA = "0x1824B4D20")]
		private bool BHIJLEBIIMK(MPBFDJNFALM PDHKCBEBPNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x24B5210", Offset = "0x24B3C10", VA = "0x1824B5210")]
		private bool FBBAKHOFGJG(MPBFDJNFALM PDHKCBEBPNG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x24B52C0", Offset = "0x24B3CC0", VA = "0x1824B52C0", Slot = "6")]
		public bool GCFOPDLKNFL(CAMBCDMDDIB MMCCMEFGKOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[OJEJDFBPPED(FHFOPEOFOPD.Connectables)]
	[DNKFJNHNNCA(typeof(GMOEBONBILL), new string[] { })]
	internal class ConnectableService : GMOEBONBILL, CFMOGGHLNDM, BGKGLCNGELH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		[CompilerGenerated]
		private sealed class LPIGMCHCIBG : IEnumerable<CAMBCDMDDIB>, IEnumerable, IEnumerator<CAMBCDMDDIB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			private CAMBCDMDDIB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private CAMBCDMDDIB localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public CAMBCDMDDIB <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700015D")]
			private CAMBCDMDDIB System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C30")]
				[Cpp2IlInjected.Address(RVA = "0x909700", Offset = "0x908100", VA = "0x180909700", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(CAMBCDMDDIB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C32")]
				[Cpp2IlInjected.Address(RVA = "0x22EC6D0", Offset = "0x22EB0D0", VA = "0x1822EC6D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x1EBC340", Offset = "0x1EBAD40", VA = "0x181EBC340")]
			[DebuggerHidden]
			public LPIGMCHCIBG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x22EC720", Offset = "0x22EB120", VA = "0x1822EC720", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x22EC2E0", Offset = "0x22EACE0", VA = "0x1822EC2E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x22EC7F0", Offset = "0x22EB1F0", VA = "0x1822EC7F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x22EC840", Offset = "0x22EB240", VA = "0x1822EC840")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0x22EC690", Offset = "0x22EB090", VA = "0x1822EC690", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0x22EC5E0", Offset = "0x22EAFE0", VA = "0x1822EC5E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CAMBCDMDDIB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0x22EC5E0", Offset = "0x22EAFE0", VA = "0x1822EC5E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private static readonly LOOGELFKPLM KJGJEGDEFNP;

		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public const int MJPILBJAOEO = 0;

		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public const int EKHDHIBLNMK = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private NPDHBLHKCNF IHDGODIAJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private CAOOBKKGEDI MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private PNLHBOHNCFH MGOGCFMPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private PropertyEventCallbacksService APCBMNHLIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private global::MCHJKBDIPIH<Entity> GPCEBPOHLON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private global::MCHJKBDIPIH<float3> BFHLLEMKHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private global::MCHJKBDIPIH<quaternion> OJPAGOEMOPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private global::MCHJKBDIPIH<Entity> EGNCPOLPGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private global::MCHJKBDIPIH<float3> JJPMPKMDDHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private global::MCHJKBDIPIH<quaternion> JOJONLKIPPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private HashSet<Entity> HPKIKNJBMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private HashSet<Entity> MGMFHHDEIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private EntityQuery EEEDEHOCIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private bool HHKBONGDECE;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public Func<IOJBBGGLAEM> GHHLNIGPNBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x6A2D60", Offset = "0x6A1760", VA = "0x1806A2D60", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x6A2D50", Offset = "0x6A1750", VA = "0x1806A2D50", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action<CAMBCDMDDIB, CAMBCDMDDIB> PLFCNPKHAAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x24BA590", Offset = "0x24B8F90", VA = "0x1824BA590", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x24BA490", Offset = "0x24B8E90", VA = "0x1824BA490", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<CAMBCDMDDIB, CAMBCDMDDIB> NNEPFJMCGOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x24BA630", Offset = "0x24B9030", VA = "0x1824BA630", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0x24BAC20", Offset = "0x24B9620", VA = "0x1824BAC20", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<CAMBCDMDDIB, CAMBCDMDDIB, CAMBCDMDDIB> OGGCFLFBPEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x24B9FE0", Offset = "0x24B89E0", VA = "0x1824B9FE0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0x24BA080", Offset = "0x24B8A80", VA = "0x1824BA080", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<CAMBCDMDDIB> AGOCLFBOIND
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x24BA1B0", Offset = "0x24B8BB0", VA = "0x1824BA1B0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x24B9B10", Offset = "0x24B8510", VA = "0x1824B9B10", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x24B9BB0", Offset = "0x24B85B0", VA = "0x1824B9BB0", Slot = "25")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x24BA6D0", Offset = "0x24B90D0", VA = "0x1824BA6D0", Slot = "26")]
		public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x24B9D30", Offset = "0x24B8730", VA = "0x1824B9D30", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x24BA3A0", Offset = "0x24B8DA0", VA = "0x1824BA3A0")]
		private void GGEMNCEKFHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x24BB280", Offset = "0x24B9C80", VA = "0x1824BB280")]
		private void OIIDPPFKMGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x24BB0C0", Offset = "0x24B9AC0", VA = "0x1824BB0C0")]
		private void OGOHOJOKLJL(Entity EBOGCLNNJGN, ACIALDGCHGB EDNCKFCJECD, DCNFIHFHOLK GKKEBOJKIEH, DCNFIHFHOLK KMKKONJJIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x24BA530", Offset = "0x24B8F30", VA = "0x1824BA530")]
		private void IFJKDNHDEPI(Entity EBOGCLNNJGN, ACIALDGCHGB EDNCKFCJECD, DCNFIHFHOLK GKKEBOJKIEH, DCNFIHFHOLK KMKKONJJIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x162BFC0", Offset = "0x162A9C0", VA = "0x18162BFC0", Slot = "14")]
		public CAMBCDMDDIB BEICMLGEPMC(CAMBCDMDDIB BCJDDLNACAB, int OMLKPMPOBHL)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0xB36220", Offset = "0xB34C20", VA = "0x180B36220", Slot = "15")]
		public Color AEJLFNFGHDF(CAMBCDMDDIB BCJDDLNACAB, int OMLKPMPOBHL)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x24BB3F0", Offset = "0x24B9DF0", VA = "0x1824BB3F0", Slot = "16")]
		public float3 OLCEHMBFHJE(CAMBCDMDDIB BCJDDLNACAB, int OMLKPMPOBHL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x24BB5D0", Offset = "0x24B9FD0", VA = "0x1824BB5D0", Slot = "17")]
		public bool PHCFMMAHOKC(CAMBCDMDDIB BCJDDLNACAB, CAMBCDMDDIB GHMAENHAHLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x24BAB70", Offset = "0x24B9570", VA = "0x1824BAB70", Slot = "18")]
		public CAMBCDMDDIB NELAPPAAJGD(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x24BA250", Offset = "0x24B8C50", VA = "0x1824BA250", Slot = "21")]
		public void GFOGJKIDGAF(CAMBCDMDDIB BCJDDLNACAB, Vector3 IJBMDEBMHMN, Quaternion ABMJIMFAJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x24B9A70", Offset = "0x24B8470", VA = "0x1824B9A70", Slot = "23")]
		public float3 BIBCPMFFOGF(MEFKBKFOGED GFJJKAJGMKF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x24BA120", Offset = "0x24B8B20", VA = "0x1824BA120", Slot = "24")]
		public quaternion FPINIALCBCH(MEFKBKFOGED GFJJKAJGMKF)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x24B9EE0", Offset = "0x24B88E0", VA = "0x1824B9EE0", Slot = "28")]
		public RigidTransform EDKBDCKCLBO(MEFKBKFOGED GFJJKAJGMKF)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x24BACC0", Offset = "0x24B96C0", VA = "0x1824BACC0", Slot = "22")]
		public bool NLNNKPKFKJG(CAMBCDMDDIB BCJDDLNACAB, out RigidTransform KAPLBKFHEIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x24BA400", Offset = "0x24B8E00", VA = "0x1824BA400", Slot = "19")]
		[IteratorStateMachine(typeof(LPIGMCHCIBG))]
		public IEnumerable<CAMBCDMDDIB> HFBDKCKIENL(CAMBCDMDDIB BCJDDLNACAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x24BAF60", Offset = "0x24B9960", VA = "0x1824BAF60", Slot = "20")]
		public CAMBCDMDDIB OGNFJAPMMAA(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x24B98A0", Offset = "0x24B82A0", VA = "0x1824B98A0", Slot = "29")]
		public void ALMPFDIBFHO(ref List<CAMBCDMDDIB> CDPILLKGKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x24BAE40", Offset = "0x24B9840", VA = "0x1824BAE40")]
		private Entity OGNFJAPMMAA(Entity EBOGCLNNJGN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x24BB710", Offset = "0x24BA110", VA = "0x1824BB710")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	[DNKFJNHNNCA(typeof(ObjectInstantiationService), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.Prefabs)]
	internal sealed class ObjectInstantiationService : CFMOGGHLNDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI MKBCEHAIJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		[MJIDFIFGMKP]
		private IHJILKIHBOF DKIKPEJKJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		[MJIDFIFGMKP]
		private BHDAADBNJHB MKCECLKBIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		[MJIDFIFGMKP]
		private ObjectNetworkToLocalMapService JCHNGOPCAEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		[MJIDFIFGMKP]
		private ObjectLifecycleService MBPFMENCMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		[MJIDFIFGMKP]
		private ObjectPrefabs JFOCGIPFIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[MJIDFIFGMKP]
		private LNBLKDDFKKK PDJGOBHGFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private LEAELDIEDJJ LDJOLKJBDLL;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public int IEJKCMAMFNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000C35")]
			[Cpp2IlInjected.Address(RVA = "0x22D31D0", Offset = "0x22D1BD0", VA = "0x1822D31D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x22D3270", Offset = "0x22D1C70", VA = "0x1822D3270", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x22D33A0", Offset = "0x22D1DA0", VA = "0x1822D33A0")]
		public Entity FKACOFEIDOK(MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x22D3650", Offset = "0x22D2050", VA = "0x1822D3650")]
		public Entity LBKNPNPADJN(DPCBAIHHPOK PKBNFFGFIEN, MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x22D34E0", Offset = "0x22D1EE0", VA = "0x1822D34E0")]
		public Entity MDCILGHIJEK(MIJMGOMOBGM PKKAOLKCAGJ, bool HHPJLANHGMD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x22D3530", Offset = "0x22D1F30", VA = "0x1822D3530")]
		public Entity MDCILGHIJEK(MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x22D36B0", Offset = "0x22D20B0", VA = "0x1822D36B0")]
		public Entity LPGPAEIFBOD()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x22D30E0", Offset = "0x22D1AE0", VA = "0x1822D30E0")]
		public Entity AEJNCOLBJMB(BKPIKMGJOND NFMPIOLJBMO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x22D35C0", Offset = "0x22D1FC0", VA = "0x1822D35C0")]
		public Entity IIPKCGJIMIG(ANCPEPLHJEH NFMPIOLJBMO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x22D3570", Offset = "0x22D1F70", VA = "0x1822D3570")]
		public NativeArray<(CAMBCDMDDIB, CAMBCDMDDIB)> HLPEGFGOKMH(NativeArray<CAMBCDMDDIB> NFBGBJGHGCO, Allocator FAMNMGKAFPB)
		{
			return default(NativeArray<(CAMBCDMDDIB, CAMBCDMDDIB)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x22D3220", Offset = "0x22D1C20", VA = "0x1822D3220")]
		public IEnumerable<MIJMGOMOBGM> DBMKCIADOEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x22D3170", Offset = "0x22D1B70", VA = "0x1822D3170")]
		public EntityArchetype BACLAEBHGNP(MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x22D36F0", Offset = "0x22D20F0", VA = "0x1822D36F0")]
		public Entity OFJAKIDPOGE(MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x22D3530", Offset = "0x22D1F30", VA = "0x1822D3530")]
		private Entity HIJHCBFKLCP(MIJMGOMOBGM PKKAOLKCAGJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x22D34E0", Offset = "0x22D1EE0", VA = "0x1822D34E0")]
		private Entity HIJHCBFKLCP(MIJMGOMOBGM PKKAOLKCAGJ, bool HHPJLANHGMD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x22D33C0", Offset = "0x22D1DC0", VA = "0x1822D33C0")]
		private Entity HIJHCBFKLCP(MIJMGOMOBGM PKKAOLKCAGJ, DPCBAIHHPOK PKBNFFGFIEN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[OJEJDFBPPED(FHFOPEOFOPD.Physics)]
	[DNKFJNHNNCA(typeof(GPAPCFEMAGG), new string[] { })]
	public sealed class PhysicsSceneColliderService : GPAPCFEMAGG, EKMDGKGKJEO, AHDDAOHEFAN, CFMOGGHLNDM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private const string MKAMKLALIKL = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private const int EKNKHBDNMIG = -1;

		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private const int BPAALEBKDOE = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		[MJIDFIFGMKP]
		private EMCACLLEGIF AKMKADIDNNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private Collider[] FNCGIJFPJPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private RaycastHit[] EOAMJNDLBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private global::ABDMDAMINJC<GLHHDFOJNGA, BoxCollider> MNGCAJLNBOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private Scene HJLNDBMKNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private PhysicsScene DJEKCFOIJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private GameObject CDBJBIDGEMD;

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public int APEJCLBFBGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x22DEC40", Offset = "0x22DD640", VA = "0x1822DEC40", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x22DF720", Offset = "0x22DE120", VA = "0x1822DF720", Slot = "9")]
		public void LMBJCLDJBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x22DEC80", Offset = "0x22DD680", VA = "0x1822DEC80", Slot = "10")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x22DED40", Offset = "0x22DD740", VA = "0x1822DED40", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x22DEA70", Offset = "0x22DD470", VA = "0x1822DEA70", Slot = "4")]
		public GLHHDFOJNGA CMIJIBKEAIP(Entity EBOGCLNNJGN)
		{
			return default(GLHHDFOJNGA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x22DF180", Offset = "0x22DDB80", VA = "0x1822DF180", Slot = "5")]
		public void JOJPOOMCPBE(NativeArray<GLHHDFOJNGA> CGCONEFBPBJ, NativeArray<DDIAOJPNFPA> DKDHAMFEDAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x22DE950", Offset = "0x22DD350", VA = "0x1822DE950", Slot = "6")]
		public void CDPAAKPLNBF(GLHHDFOJNGA LGNELGFKAEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x22DF0E0", Offset = "0x22DDAE0", VA = "0x1822DF0E0", Slot = "7")]
		public bool JDMHMEDINLF(GLHHDFOJNGA LGNELGFKAEP, out Collider JJEECJHLDGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x22DF390", Offset = "0x22DDD90", VA = "0x1822DF390")]
		public bool KHBODJCGHHD(in float3 FGKLEBPPEJI, in float3 KOIMEOLNHNL, float DDIDJKAFDDK, Allocator FAMNMGKAFPB, out NativeArray<Entity> GBNPHFOKMOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x22DEE40", Offset = "0x22DD840", VA = "0x1822DEE40")]
		private void EEILGCLNOFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x7DF240", Offset = "0x7DDC40", VA = "0x1807DF240")]
		private void OCEFHNCMDCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x22DEA20", Offset = "0x22DD420", VA = "0x1822DEA20")]
		private void CFCKOLFLMKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0xADA730", Offset = "0xAD9130", VA = "0x180ADA730")]
		private void ILEBOMFGEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x22DE640", Offset = "0x22DD040", VA = "0x1822DE640")]
		private BoxCollider ANLIELJOIEC(Entity EBOGCLNNJGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x22DEBC0", Offset = "0x22DD5C0", VA = "0x1822DEBC0")]
		private void DBFLMKOMBDM(BoxCollider LJMNCBIJALI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x22DEE90", Offset = "0x22DD890", VA = "0x1822DEE90")]
		[Conditional("UNITY_EDITOR")]
		private void IIKPIDIHAFI(GameObject OOAFGPFKNDK, Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x22DE760", Offset = "0x22DD160", VA = "0x1822DE760")]
		private void BNAEJEMBEJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x22DF8A0", Offset = "0x22DE2A0", VA = "0x1822DF8A0")]
		private void OPCPFFEMFNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x22DEED0", Offset = "0x22DD8D0", VA = "0x1822DEED0")]
		private void JCJJLANNEGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x22DF6B0", Offset = "0x22DE0B0", VA = "0x1822DF6B0")]
		private void LKBBDJOOPCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x22DF6A0", Offset = "0x22DE0A0", VA = "0x1822DF6A0")]
		private void KKEMGINHGDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x22DF6E0", Offset = "0x22DE0E0", VA = "0x1822DF6E0")]
		private void LKOKNLEABAG(Scene EKEILBHDHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x22DF890", Offset = "0x22DE290", VA = "0x1822DF890", Slot = "8")]
		private bool NBCKNDEIMMA(in float3 FGKLEBPPEJI, in float3 KOIMEOLNHNL, float DDIDJKAFDDK, Allocator FAMNMGKAFPB, out NativeArray<Entity> GBNPHFOKMOH)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
[DNKFJNHNNCA(typeof(BKDLEKAIFKG), new string[] { })]
public sealed class EFNDPCMNOFJ : BKDLEKAIFKG, CFMOGGHLNDM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	private struct NMMIHDODGHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public float DDANOCEMCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public uint HPHDMDPPHPC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private EKMDGKGKJEO JKMJJPPPFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private AKHALIAJCHE OECCFPGHCKJ;

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x24C3020", Offset = "0x24C1A20", VA = "0x1824C3020", Slot = "5")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x24C31D0", Offset = "0x24C1BD0", VA = "0x1824C31D0")]
	public bool KHBODJCGHHD(in float3 FGKLEBPPEJI, in float3 KOIMEOLNHNL, float DDIDJKAFDDK, out HNFEBOKPAEP PHNBFLJNKII, out Entity FCKONEBKLFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x24C3090", Offset = "0x24C1A90", VA = "0x1824C3090")]
	public static bool FOCBNHGKFJM(in Span<HNFEBOKPAEP> EJIOOKBKAGG, float DDIDJKAFDDK, out int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x24C3190", Offset = "0x24C1B90", VA = "0x1824C3190")]
	public static float GBLJFJEILBG(float DDANOCEMCFE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public EFNDPCMNOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x24C31C0", Offset = "0x24C1BC0", VA = "0x1824C31C0", Slot = "4")]
	private bool KBNHDFAGCGI(in float3 FGKLEBPPEJI, in float3 KOIMEOLNHNL, float DDIDJKAFDDK, out HNFEBOKPAEP PHNBFLJNKII, out Entity FCKONEBKLFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
[DNKFJNHNNCA(typeof(AKHALIAJCHE), new string[] { })]
public sealed class HODHIDJFBFD : AKHALIAJCHE, CFMOGGHLNDM
{
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[BurstCompile]
	private struct HCIOIBMJPIB : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[ReadOnly]
		public NativeArray<Entity> GBNPHFOKMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[ReadOnly]
		public float3 CEKGCBFJGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[ReadOnly]
		public float3 EBCKGPPJPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> PONKKKOLAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> MCHLACNNOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> GGDJKIGBOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> IHPCCBLKJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> KCJIDJJGOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		[WriteOnly]
		public NativeArray<HNFEBOKPAEP> PAFIFDNMACN;

		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private static readonly HNFEBOKPAEP APNJKPGJKGF;

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x38A77F0", Offset = "0x38A61F0", VA = "0x1838A77F0", Slot = "4")]
		public void Execute(int NENMOOINMCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x38A7720", Offset = "0x38A6120", VA = "0x1838A7720")]
		private static float3 CFGINFEGDGA(in float4x4 OIFCJGBGOGB, in float3 JEHKGNEAMEK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x38A7560", Offset = "0x38A5F60", VA = "0x1838A7560")]
		private static float3 CEBFMMLBCGG(in float4x4 OIFCJGBGOGB, in float3 GJJCEGJKENH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x38A7AD0", Offset = "0x38A64D0", VA = "0x1838A7AD0")]
		private static float3 FKHKJJBACGM(in float4x4 OIFCJGBGOGB, in float3 JEHKGNEAMEK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x38A85F0", Offset = "0x38A6FF0", VA = "0x1838A85F0")]
		private static float3 LOIKCLKAGBN(in float4x4 OIFCJGBGOGB, in float3 GJJCEGJKENH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x38A7BD0", Offset = "0x38A65D0", VA = "0x1838A7BD0")]
		private bool GDOHKFPPOMB(in float3 FGKLEBPPEJI, in float3 KOIMEOLNHNL, in NativeArray<Entity> FKEAPPADOOH, out float3 PHNBFLJNKII, out float3 FOAJMMCBCNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x38A7F20", Offset = "0x38A6920", VA = "0x1838A7F20")]
		public static bool JOEPGAMFJMP(in float3 DIEEOOGCLNO, in float3 EIDAMHABGCE, in float3 GJBNEBJILCL, in float3 AMBGCDCPLBL, float LNEGJCOEOMB, float DJNNHLBPOAP, out float IEEKPPIPNKF, out float3 JMEPHEBPBHC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityManager KACBFFMHDCF;

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x2182A70", Offset = "0x2181470", VA = "0x182182A70", Slot = "5")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x2182AF0", Offset = "0x21814F0", VA = "0x182182AF0")]
	public void KHBODJCGHHD(in NativeArray<Entity> GBNPHFOKMOH, in float3 FGKLEBPPEJI, in float3 KOIMEOLNHNL, in NativeArray<HNFEBOKPAEP> OBEBGBFDBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public HODHIDJFBFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x2182A60", Offset = "0x2181460", VA = "0x182182A60", Slot = "4")]
	private void CFBMINAGNOF(in NativeArray<Entity> GBNPHFOKMOH, in float3 FGKLEBPPEJI, in float3 KOIMEOLNHNL, in NativeArray<HNFEBOKPAEP> OBEBGBFDBGD)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[DNKFJNHNNCA(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[OJEJDFBPPED(FHFOPEOFOPD.Embodiment)]
	[DDOFDCHAEEC(AHJKMAKLGJA.OMRoom)]
	internal sealed class ObjectNetworkToLocalMapService : CFMOGGHLNDM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		[MJIDFIFGMKP]
		private CAOOBKKGEDI FBFHHMCDIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		[MJIDFIFGMKP]
		private IHJILKIHBOF LEGMPBKCIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		[MJIDFIFGMKP]
		private BHDAADBNJHB GIPKGBKOFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private PPBLJKKDGPH EAFHJAEOKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private NativeHashMap<DPCBAIHHPOK, Entity> CLHELNFKCIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private EntityManager KACBFFMHDCF;

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		internal NativeHashMap<DPCBAIHHPOK, Entity> GLDKAAEDKJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C72")]
			[Cpp2IlInjected.Address(RVA = "0xBC6F40", Offset = "0xBC5940", VA = "0x180BC6F40")]
			get
			{
				return default(NativeHashMap<DPCBAIHHPOK, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		internal uint IKKCJOEAKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0x22D6770", Offset = "0x22D5170", VA = "0x1822D6770")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool MMGCNOGJJID
		{
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x7518A0", Offset = "0x7502A0", VA = "0x1807518A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0x750750", Offset = "0x74F150", VA = "0x180750750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x22D64D0", Offset = "0x22D4ED0", VA = "0x1822D64D0", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x22D65F0", Offset = "0x22D4FF0", VA = "0x1822D65F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x22D67A0", Offset = "0x22D51A0", VA = "0x1822D67A0")]
		public void LCFMPIKHEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x22D6910", Offset = "0x22D5310", VA = "0x1822D6910")]
		public void PBHAGPEEKKG(DPCBAIHHPOK PKBNFFGFIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x22D6740", Offset = "0x22D5140", VA = "0x1822D6740")]
		private CAMBCDMDDIB HEDGBNGAOML(Entity EBOGCLNNJGN)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x22D6660", Offset = "0x22D5060", VA = "0x1822D6660")]
		public CAMBCDMDDIB EJCMNEKEHKK(DPCBAIHHPOK PKBNFFGFIEN)
		{
			return default(CAMBCDMDDIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x22D6310", Offset = "0x22D4D10", VA = "0x1822D6310")]
		public DPCBAIHHPOK AJLOHFFBBNE(CAMBCDMDDIB BCJDDLNACAB)
		{
			return default(DPCBAIHHPOK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x22D6820", Offset = "0x22D5220", VA = "0x1822D6820")]
		public void MKJGLDFHEFH(Entity EBOGCLNNJGN, DPCBAIHHPOK PKBNFFGFIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x22D6470", Offset = "0x22D4E70", VA = "0x1822D6470")]
		public void DEEPHNGJPJF(Entity EBOGCLNNJGN, DPCBAIHHPOK PKBNFFGFIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x22D68B0", Offset = "0x22D52B0", VA = "0x1822D68B0")]
		public void NACPPKMKLKH(Entity EBOGCLNNJGN, DPCBAIHHPOK PKBNFFGFIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x22D63A0", Offset = "0x22D4DA0", VA = "0x1822D63A0")]
		public void DANAOKDGPPF(Entity EBOGCLNNJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[DNKFJNHNNCA(typeof(PropertyEventCallbacksService), new string[] { })]
	[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
	[OJEJDFBPPED(FHFOPEOFOPD.Callbacks)]
	public class PropertyEventCallbacksService : CFMOGGHLNDM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		private struct KPNHNJKNGIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public FDLCKIMILNN MLFGBBGKHEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public Type NFMPIOLJBMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public int GCDOPBGGNDP;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		private struct DGMBDGMHCLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public KPNHNJKNGIA[] CDGNAONMFHE;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CC")]
		public delegate void FDLCKIMILNN(Entity EBOGCLNNJGN, ACIALDGCHGB EDNCKFCJECD, DCNFIHFHOLK GKKEBOJKIEH, DCNFIHFHOLK KMKKONJJIBD);

		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private static readonly LOOGELFKPLM ENHDLHMFJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private readonly Dictionary<ACIALDGCHGB, FDLCKIMILNN> MBNIEDNBCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private readonly Dictionary<int, DGMBDGMHCLD> EBGMNBGBONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private OBGMOBEFLNM CDGNAONMFHE;

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action ICHPBALEPHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000C83")]
			[Cpp2IlInjected.Address(RVA = "0x22E5FC0", Offset = "0x22E49C0", VA = "0x1822E5FC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0x22E5A70", Offset = "0x22E4470", VA = "0x1822E5A70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action JAPMOEBHALH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0x22E5F20", Offset = "0x22E4920", VA = "0x1822E5F20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x22E59D0", Offset = "0x22E43D0", VA = "0x1822E59D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x22E5800", Offset = "0x22E4200", VA = "0x1822E5800", Slot = "4")]
		public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x22E5850", Offset = "0x22E4250", VA = "0x1822E5850", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x22E6060", Offset = "0x22E4A60", VA = "0x1822E6060")]
		public void MKIHEFFHNPG(ACIALDGCHGB EDNCKFCJECD, FDLCKIMILNN MLFGBBGKHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x22E58E0", Offset = "0x22E42E0", VA = "0x1822E58E0")]
		public void EPNEEGPIJCB(ACIALDGCHGB EDNCKFCJECD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x22E5B10", Offset = "0x22E4510", VA = "0x1822E5B10")]
		internal void HABKGMPLCOG(PDJBENPAJCF LPLEHOMFOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0x22E52C0", Offset = "0x22E3CC0", VA = "0x1822E52C0")]
		private void BMLLLDBNLIJ(PDJBENPAJCF LPLEHOMFOKG, int FEFFHDFABJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x22E61D0", Offset = "0x22E4BD0", VA = "0x1822E61D0")]
		private void NBOMFEMFLMM(FKCOPGJECPA GPFHBGAIKFH, LJFKOBFLBJG JODDEOBGGAC, KPNHNJKNGIA LFFKKOBDKEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x22E5DA0", Offset = "0x22E47A0", VA = "0x1822E5DA0")]
		private DGMBDGMHCLD HBEFNDODCGO(FKCOPGJECPA GPFHBGAIKFH, LJFKOBFLBJG JODDEOBGGAC)
		{
			return default(DGMBDGMHCLD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x22E6450", Offset = "0x22E4E50", VA = "0x1822E6450")]
		private KPNHNJKNGIA PDCLANLAKHL(DGMBDGMHCLD GCLPPECGGNL, FKCOPGJECPA GPFHBGAIKFH, LJFKOBFLBJG JODDEOBGGAC)
		{
			return default(KPNHNJKNGIA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x22E6590", Offset = "0x22E4F90", VA = "0x1822E6590")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[DNKFJNHNNCA(typeof(HIOPLOKDODK), new string[] { })]
public class HOALCNHPMOF : CFMOGGHLNDM, BGKGLCNGELH, HIOPLOKDODK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[CompilerGenerated]
	private sealed class EMIBENEJMBP : IEnumerable<CAMBCDMDDIB>, IEnumerable, IEnumerator<CAMBCDMDDIB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private CAMBCDMDDIB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public HOALCNHPMOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private CAMBCDMDDIB splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public CAMBCDMDDIB <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		private CAMBCDMDDIB System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAD")]
			[Cpp2IlInjected.Address(RVA = "0x909700", Offset = "0x908100", VA = "0x180909700", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CAMBCDMDDIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0x38A4B70", Offset = "0x38A3570", VA = "0x1838A4B70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC340", Offset = "0x1EBAD40", VA = "0x181EBC340")]
		[DebuggerHidden]
		public EMIBENEJMBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x38A49C0", Offset = "0x38A33C0", VA = "0x1838A49C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0x38A4B30", Offset = "0x38A3530", VA = "0x1838A4B30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x38A4A80", Offset = "0x38A3480", VA = "0x1838A4A80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CAMBCDMDDIB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x38A4A80", Offset = "0x38A3480", VA = "0x1838A4A80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private PPBLJKKDGPH EAFHJAEOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private GMLKFPKNCLH FAHPDFOJCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private ObjectInstantiationService JFOCGIPFIDL;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private EntityManager AJHOIKIBFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x21825C0", Offset = "0x2180FC0", VA = "0x1821825C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private AMGOMELBDKB JMGIMDJFKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2182200", Offset = "0x2180C00", VA = "0x182182200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x2181B20", Offset = "0x2180520", VA = "0x182181B20", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x2182670", Offset = "0x2181070", VA = "0x182182670", Slot = "5")]
	public void MLFEFPEGAJE(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x2181BB0", Offset = "0x21805B0", VA = "0x182181BB0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x2181810", Offset = "0x2180210", VA = "0x182181810")]
	private void CDJMOKPHMCA(Entity PCHIPBMKPMF, in DCNFIHFHOLK HIJNDNKMAJM, in DCNFIHFHOLK MIIOPMDNGOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x2182610", Offset = "0x2181010", VA = "0x182182610", Slot = "14")]
	public CAMBCDMDDIB LPGPAEIFBOD()
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x2182490", Offset = "0x2180E90", VA = "0x182182490", Slot = "10")]
	public void KDELMAMLIAP(CAMBCDMDDIB BCJDDLNACAB, GCLBIIKJJEE INOCFKIFMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x2181C60", Offset = "0x2180660", VA = "0x182181C60", Slot = "9")]
	public GCLBIIKJJEE EPMCNMKBKMD(CAMBCDMDDIB BCJDDLNACAB)
	{
		return default(GCLBIIKJJEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x2181F00", Offset = "0x2180900", VA = "0x182181F00", Slot = "11")]
	public CAMBCDMDDIB HPFBPLGAAFF(CAMBCDMDDIB MNONFDJDIAK, [Optional] Vector3? NHDHEIIIBBI, [Optional] Quaternion? IOCIEOJKCCH, [Optional] Vector3? MMFEMDOMCCJ)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x2182580", Offset = "0x2180F80", VA = "0x182182580", Slot = "15")]
	public CAMBCDMDDIB LGLGJJJOBDB(CAMBCDMDDIB JALHFIGAEED, int NENMOOINMCH, [Optional] Vector3? NHDHEIIIBBI, [Optional] Quaternion? IOCIEOJKCCH, [Optional] Vector3? MMFEMDOMCCJ)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x2181E10", Offset = "0x2180810", VA = "0x182181E10", Slot = "7")]
	public CAMBCDMDDIB FFMMHBCONPB(CAMBCDMDDIB JALHFIGAEED, int NENMOOINMCH)
	{
		return default(CAMBCDMDDIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x2181D50", Offset = "0x2180750", VA = "0x182181D50", Slot = "16")]
	public void EPMLEFFFLJP(CAMBCDMDDIB JALHFIGAEED, CAMBCDMDDIB KLDFJAONDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x21822F0", Offset = "0x2180CF0", VA = "0x1821822F0", Slot = "12")]
	public void KDDBGOJEDHA(CAMBCDMDDIB JALHFIGAEED, int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x2182800", Offset = "0x2181200", VA = "0x182182800", Slot = "17")]
	public void OKJCCAECEBG(CAMBCDMDDIB JALHFIGAEED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x2182250", Offset = "0x2180C50", VA = "0x182182250", Slot = "8")]
	public int KBFNJFECHBF(CAMBCDMDDIB JALHFIGAEED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x2182770", Offset = "0x2181170", VA = "0x182182770", Slot = "6")]
	[IteratorStateMachine(typeof(EMIBENEJMBP))]
	public IEnumerable<CAMBCDMDDIB> NOAOBFCFLNH(CAMBCDMDDIB JALHFIGAEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x2181A90", Offset = "0x2180490", VA = "0x182181A90")]
	private bool CPMCHHDPCBC(CAMBCDMDDIB JALHFIGAEED, out NativeArray<Entity> DIDIDBBHIMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x21829A0", Offset = "0x21813A0", VA = "0x1821829A0")]
	private NativeArray<Entity> OLDADPFMCOB(CAMBCDMDDIB JALHFIGAEED)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public HOALCNHPMOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[DNKFJNHNNCA(typeof(PGHFKCCKPED), new string[] { })]
[DDOFDCHAEEC(AHJKMAKLGJA.LoadInstance)]
internal sealed class PGHFKCCKPED : CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private CAOOBKKGEDI MKBCEHAIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private TransformOwnershipPhase FIBKLLCCEMI;

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private OLNILFAFOLN DLPKPCDMEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x22DC790", Offset = "0x22DB190", VA = "0x1822DC790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x22DC710", Offset = "0x22DB110", VA = "0x1822DC710", Slot = "4")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x22DCAB0", Offset = "0x22DB4B0", VA = "0x1822DCAB0")]
	public void KEIEANOCKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x22DC7E0", Offset = "0x22DB1E0", VA = "0x1822DC7E0")]
	public void JMDKFIIEMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public PGHFKCCKPED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public readonly struct CJLDEELIELH : IEquatable<CJLDEELIELH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private readonly int FEFFHDFABJK;

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public Type JHJMDINHJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0x24B2680", Offset = "0x24B1080", VA = "0x1824B2680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x24B2760", Offset = "0x24B1160", VA = "0x1824B2760")]
	public CJLDEELIELH(Type NFMPIOLJBMO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x24B25D0", Offset = "0x24B0FD0", VA = "0x1824B25D0")]
	public static CJLDEELIELH MFJMDPBHOLK(Type NFMPIOLJBMO)
	{
		return default(CJLDEELIELH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x24B2630", Offset = "0x24B1030", VA = "0x1824B2630")]
	public static Type MFJMDPBHOLK(CJLDEELIELH LGNELGFKAEP)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x8204E0", Offset = "0x81EEE0", VA = "0x1808204E0")]
	public static bool MOBCKBANPBO(CJLDEELIELH LDIEPFCHCFG, CJLDEELIELH KCHCODPDAGF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x8204E0", Offset = "0x81EEE0", VA = "0x1808204E0")]
	public static bool DEKNKNJGCDK(CJLDEELIELH LDIEPFCHCFG, CJLDEELIELH KCHCODPDAGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x7F56E0", Offset = "0x7F40E0", VA = "0x1807F56E0", Slot = "4")]
	public bool Equals(CJLDEELIELH BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x24B2550", Offset = "0x24B0F50", VA = "0x1824B2550", Slot = "0")]
	public override bool Equals(object PDHKCBEBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x7608C0", Offset = "0x75F2C0", VA = "0x1807608C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x24B26E0", Offset = "0x24B10E0", VA = "0x1824B26E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
public static class JCGNPGOJFHJ
{
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private static Dictionary<Type, int> MADEEAOMDBI;

	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private static List<Type> KOOBBIOBLIC;

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x2186DE0", Offset = "0x21857E0", VA = "0x182186DE0")]
	static JCGNPGOJFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x1765500", Offset = "0x1763F00", VA = "0x181765500")]
	public static bool MJIKPLNABDE<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x2186D70", Offset = "0x2185770", VA = "0x182186D70")]
	public static bool MJIKPLNABDE(Type NFMPIOLJBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x2186C00", Offset = "0x2185600", VA = "0x182186C00")]
	private static bool MJIKPLNABDE(Type NFMPIOLJBMO, out int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x17653D0", Offset = "0x1763DD0", VA = "0x1817653D0")]
	public static int FABMACHPALK<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0x21869D0", Offset = "0x21853D0", VA = "0x1821869D0")]
	public static int FABMACHPALK(Type NFMPIOLJBMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x1765460", Offset = "0x1763E60", VA = "0x181765460")]
	public static bool FJMGOOAKNCK<T>(out int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0x2186B60", Offset = "0x2185560", VA = "0x182186B60")]
	public static bool FJMGOOAKNCK(Type NFMPIOLJBMO, out int NENMOOINMCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0x2186930", Offset = "0x2185330", VA = "0x182186930")]
	public static Type DNANCALJAPO(int NENMOOINMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0x2186A40", Offset = "0x2185440", VA = "0x182186A40")]
	public static bool FJMGOOAKNCK(int NENMOOINMCH, out Type NFMPIOLJBMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[DefaultMember("Item")]
public struct KOIBHOIKJGK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private T[] PJIINDGLAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private int LOHIKBMAMJE;

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public int PAKKNJKLENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x1236D20", Offset = "0x1235720", VA = "0x181236D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public T GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x1761F80", Offset = "0x1760980", VA = "0x181761F80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Span<T> LMLNKDENLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x27D3A70", Offset = "0x27D2470", VA = "0x1827D3A70")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool CIADPHNANDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0xBFEE40", Offset = "0xBFD840", VA = "0x180BFEE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x27D3B10", Offset = "0x27D2510", VA = "0x1827D3B10")]
	public KOIBHOIKJGK(int LOHIKBMAMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x27D39C0", Offset = "0x27D23C0", VA = "0x1827D39C0")]
	public int FAPJKNPKKHA(T NKJMIDIDBOE, int NJEPHEABALF, int OOJKDAEFAHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x27D3900", Offset = "0x27D2300", VA = "0x1827D3900", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
[DefaultMember("Item")]
public struct OHLLKGOBPAO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private global::KOIBHOIKJGK<T> PJIINDGLAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private int LOHIKBMAMJE;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0x246C7F0", Offset = "0x246B1F0", VA = "0x18246C7F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int PAKKNJKLENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x6983B0", Offset = "0x696DB0", VA = "0x1806983B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0x246C290", Offset = "0x246AC90", VA = "0x18246C290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public int KKMBALGBKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x246B9C0", Offset = "0x246A3C0", VA = "0x18246B9C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x246C9E0", Offset = "0x246B3E0", VA = "0x18246C9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool CIADPHNANDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x246B3C0", Offset = "0x2469DC0", VA = "0x18246B3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Span<T> LMLNKDENLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD8")]
		[Cpp2IlInjected.Address(RVA = "0x246C6A0", Offset = "0x246B0A0", VA = "0x18246C6A0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x246CB60", Offset = "0x246B560", VA = "0x18246CB60")]
	public OHLLKGOBPAO(int LOHIKBMAMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x246C460", Offset = "0x246AE60", VA = "0x18246C460")]
	public T NBKFBDOENDH(int NENMOOINMCH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x246C4B0", Offset = "0x246AEB0", VA = "0x18246C4B0")]
	public void NECGFBDMFAH(T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x246B660", Offset = "0x246A060", VA = "0x18246B660")]
	public void CLOKNJFEDHK(Span<T> AMMGMIDPNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x246C350", Offset = "0x246AD50", VA = "0x18246C350")]
	public void MJIKPLNABDE(T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x246C520", Offset = "0x246AF20", VA = "0x18246C520")]
	private void NGKGKACMBNK(int CDECJIFLFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x246BBC0", Offset = "0x246A5C0", VA = "0x18246BBC0")]
	public void HMOHCCLKEOM(Span<T> BKLDDIKBPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x246B7D0", Offset = "0x246A1D0", VA = "0x18246B7D0")]
	public void DJENEDPLKKM(int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x246C010", Offset = "0x246AA10", VA = "0x18246C010")]
	public void JBHPLMBHMJP(int CAIBHNEFLMP, int AFPKKIJINFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x246C230", Offset = "0x246AC30", VA = "0x18246C230")]
	public void JIOCFBKPOPN(int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x246BE00", Offset = "0x246A800", VA = "0x18246BE00")]
	public void ICADBNOEKFA(int CAIBHNEFLMP, int AFPKKIJINFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x246B300", Offset = "0x2469D00", VA = "0x18246B300")]
	public void BGCHGOECBMG(int CDECJIFLFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x246CA30", Offset = "0x246B430", VA = "0x18246CA30")]
	public void PNEAENELGND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x246B9F0", Offset = "0x246A3F0", VA = "0x18246B9F0")]
	public int FAPJKNPKKHA(T NKJMIDIDBOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x246B400", Offset = "0x2469E00", VA = "0x18246B400")]
	public bool CLJNJIAEHOP(T NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x246B970", Offset = "0x246A370", VA = "0x18246B970", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x246CAF0", Offset = "0x246B4F0", VA = "0x18246CAF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x246C2E0", Offset = "0x246ACE0", VA = "0x18246C2E0")]
	public static Span<T> MFJMDPBHOLK(global::OHLLKGOBPAO<T> AMMGMIDPNEP)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x246B830", Offset = "0x246A230", VA = "0x18246B830")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void DNHOEHKIEKM(int NKJMIDIDBOE, int LOHIKBMAMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void PHJNIGLMIMC(int LOHIKBMAMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x246C880", Offset = "0x246B280", VA = "0x18246C880")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void PHJNIGLMIMC(int LOHIKBMAMJE, int NENMOOINMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x246BA80", Offset = "0x246A480", VA = "0x18246BA80")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void GMNGCOLPNMN(int NKJMIDIDBOE, int LOHIKBMAMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x246B460", Offset = "0x2469E60", VA = "0x18246B460")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CLMBDMFPNNP(int CAIBHNEFLMP, int AFPKKIJINFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF0")]
	[Cpp2IlInjected.Address(RVA = "0x246B1C0", Offset = "0x2469BC0", VA = "0x18246B1C0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private static void AAEIJMNHBPC(int NKJMIDIDBOE, int LOHIKBMAMJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public struct COAJGMOIFLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private const int KJLIDILNPGB = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private NativeList<Entity> GBNPHFOKMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private TransformAccessArray IHDGODIAJNC;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int OABDNEKKKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x24B3B00", Offset = "0x24B2500", VA = "0x1824B3B00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public NativeList<Entity> IEBMMOKEPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0xB93020", Offset = "0xB91A20", VA = "0x180B93020")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public TransformAccessArray KABPDDFIDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool MMGCNOGJJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x24B3D80", Offset = "0x24B2780", VA = "0x1824B3D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF1")]
	[Cpp2IlInjected.Address(RVA = "0x24B3DA0", Offset = "0x24B27A0", VA = "0x1824B3DA0")]
	public COAJGMOIFLM(int CDECJIFLFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x24B3D30", Offset = "0x24B2730", VA = "0x1824B3D30")]
	public Entity PEKNHJNOPAN(int NENMOOINMCH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x24B3C10", Offset = "0x24B2610", VA = "0x1824B3C10")]
	public Transform MJGLJJFCNPN(int NENMOOINMCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x24B3AB0", Offset = "0x24B24B0", VA = "0x1824B3AB0")]
	public void BPIOGFAOFNF(int CDECJIFLFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x24B3C20", Offset = "0x24B2620", VA = "0x1824B3C20")]
	public int MJIKPLNABDE(Transform MLMJNFGMBPE, Entity EBOGCLNNJGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x24B3B10", Offset = "0x24B2510", VA = "0x1824B3B10")]
	public int DJENEDPLKKM(int NENMOOINMCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x24B3B90", Offset = "0x24B2590", VA = "0x1824B3B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x24B3CF0", Offset = "0x24B26F0", VA = "0x1824B3CF0")]
	private void OJLIMJGFPNM(int LLCJPPJIBIA = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
internal class PAHBPGOJNOM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private NativeHashMap<CJLDEELIELH, int2> CJGABBAOKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private NativeList<byte> MFPFCCDPGDI;

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x22DB7D0", Offset = "0x22DA1D0", VA = "0x1822DB7D0")]
	public PAHBPGOJNOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x22DB560", Offset = "0x22D9F60", VA = "0x1822DB560")]
	public void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	public void LMCGMFHIJLB<T>(T NKJMIDIDBOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	public T DNANCALJAPO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x22DB5C0", Offset = "0x22D9FC0", VA = "0x1822DB5C0")]
	public void LMCGMFHIJLB(Type NFMPIOLJBMO, DCNFIHFHOLK NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x22DB0F0", Offset = "0x22D9AF0", VA = "0x1822DB0F0")]
	public DCNFIHFHOLK DNANCALJAPO(Type NFMPIOLJBMO)
	{
		return default(DCNFIHFHOLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x22DB3A0", Offset = "0x22D9DA0", VA = "0x1822DB3A0")]
	private NativeArray<byte> FBDIGFJNFFJ(int2 ONPCJMMBIFB)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x22DB300", Offset = "0x22D9D00", VA = "0x1822DB300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x22DB440", Offset = "0x22D9E40", VA = "0x1822DB440", Slot = "1")]
	~PAHBPGOJNOM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D6")]
public struct DELKCMAOHCK<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000177")]
	internal static T EDONKBBONCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	public static global::DELKCMAOHCK<T> MFJMDPBHOLK(T NKJMIDIDBOE)
	{
		return default(global::DELKCMAOHCK<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	public static T MFJMDPBHOLK(global::DELKCMAOHCK<T> DJFOKMFDJPD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public static class NHNLOMODPBI
{
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	private static readonly PAHBPGOJNOM CKNANHGAPFP;

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x22CB420", Offset = "0x22C9E20", VA = "0x1822CB420")]
	internal static void LCFMPIKHEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	public static void LMCGMFHIJLB<T>(T NKJMIDIDBOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x22CB4D0", Offset = "0x22C9ED0", VA = "0x1822CB4D0")]
	public static void LMCGMFHIJLB(Type NFMPIOLJBMO, DCNFIHFHOLK NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	public static T DNANCALJAPO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0D")]
	[Cpp2IlInjected.Address(RVA = "0x22CB380", Offset = "0x22C9D80", VA = "0x1822CB380")]
	public static DCNFIHFHOLK DNANCALJAPO(Type NFMPIOLJBMO)
	{
		return default(DCNFIHFHOLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public class IOAPKECMLHG : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	public static readonly IOAPKECMLHG MHJMHHILEFG;

	[Cpp2IlInjected.Token(Token = "0x6000D0F")]
	[Cpp2IlInjected.Address(RVA = "0x2186130", Offset = "0x2184B30", VA = "0x182186130", Slot = "4")]
	public bool Equals(LinkedEntityGroup GKGDNAPOGPF, LinkedEntityGroup JLKLDCLDEEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D10")]
	[Cpp2IlInjected.Address(RVA = "0x2186150", Offset = "0x2184B50", VA = "0x182186150", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup PDHKCBEBPNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public IOAPKECMLHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
internal class ONAEKEGAPPE
{
	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	[Conditional("DEBUG_BUILD")]
	public static void ALMMNJAOJJC(in Vector3 NHDHEIIIBBI, in Quaternion IOCIEOJKCCH, in Vector3 MMFEMDOMCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	[Conditional("DEBUG_BUILD")]
	public static void DDJGPOMICGK(in Vector3 MCLABJJHAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	[Conditional("DEBUG_BUILD")]
	public static void IHFHCIOEPNJ(in Quaternion IOCIEOJKCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	[Conditional("DEBUG_BUILD")]
	public static void CNGGLNOPEJA(in Vector3 MACIPLJMOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	[Conditional("DEBUG_BUILD")]
	public static void HNGFJDMGNHN(in Vector3 MACIPLJMOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	[Conditional("DEBUG_BUILD")]
	public static void IMGFJPPDHMD(in float AKLELLFNGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x22CE930", Offset = "0x22CD330", VA = "0x1822CE930")]
	[Conditional("DEBUG_BUILD")]
	public static void GBDAPHDILAC(in float3 NKJMIDIDBOE, string PJJGOJBLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	[Conditional("DEBUG_BUILD")]
	public static void IHLGFKOHPDK(in float NKJMIDIDBOE, string PJJGOJBLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	[Cpp2IlInjected.Address(RVA = "0x22CEA10", Offset = "0x22CD410", VA = "0x1822CEA10")]
	[Conditional("DEBUG_BUILD")]
	public static void IHLGFKOHPDK(in Vector3 NKJMIDIDBOE, string PJJGOJBLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x22CE9E0", Offset = "0x22CD3E0", VA = "0x1822CE9E0")]
	[Conditional("DEBUG_BUILD")]
	public static void IHLGFKOHPDK(in Quaternion NKJMIDIDBOE, string PJJGOJBLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x22CE920", Offset = "0x22CD320", VA = "0x1822CE920")]
	[Conditional("DEBUG_BUILD")]
	public static void FHHEHJKJDCN(in float NKJMIDIDBOE, string PJJGOJBLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x22CE8E0", Offset = "0x22CD2E0", VA = "0x1822CE8E0")]
	[Conditional("DEBUG_BUILD")]
	public static void FHHEHJKJDCN(in Vector3 NKJMIDIDBOE, string PJJGOJBLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x22CE8B0", Offset = "0x22CD2B0", VA = "0x1822CE8B0")]
	[Conditional("DEBUG_BUILD")]
	public static void FHHEHJKJDCN(in Quaternion NKJMIDIDBOE, string PJJGOJBLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public ONAEKEGAPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public struct PCMAMIJLKEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	public Entity EBOGCLNNJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	public Entity NKGEBLNPFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	public Entity CLJJCFEFLNI;

	[Cpp2IlInjected.Token(Token = "0x6000D21")]
	[Cpp2IlInjected.Address(RVA = "0x22DC2D0", Offset = "0x22DACD0", VA = "0x1822DC2D0")]
	public PCMAMIJLKEM(Entity EBOGCLNNJGN, Entity NKGEBLNPFNO, Entity CLJJCFEFLNI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	[Cpp2IlInjected.Address(RVA = "0x22DC290", Offset = "0x22DAC90", VA = "0x1822DC290")]
	public static PCMAMIJLKEM MFJMDPBHOLK((Entity entity, Entity oldParent, Entity newParent) GKLIPCAPFJD)
	{
		return default(PCMAMIJLKEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	[Cpp2IlInjected.Address(RVA = "0x22DC270", Offset = "0x22DAC70", VA = "0x1822DC270")]
	public void JFJMGCLPGME(out Entity EBOGCLNNJGN, out Entity NKGEBLNPFNO, out Entity CLJJCFEFLNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public struct PLGLIKALDJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public Entity EBOGCLNNJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public Entity EGNCPOLPGCD;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x22DDA20", Offset = "0x22DC420", VA = "0x1822DDA20")]
	public PLGLIKALDJI(Entity EBOGCLNNJGN, Entity EGNCPOLPGCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	[Cpp2IlInjected.Address(RVA = "0x22DD9F0", Offset = "0x22DC3F0", VA = "0x1822DD9F0")]
	public static PLGLIKALDJI MFJMDPBHOLK((Entity entity, Entity parent) GKLIPCAPFJD)
	{
		return default(PLGLIKALDJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x22DD9E0", Offset = "0x22DC3E0", VA = "0x1822DD9E0")]
	public void JFJMGCLPGME(out Entity EBOGCLNNJGN, out Entity EGNCPOLPGCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
public struct CCLGIBKOOPE<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private GCHandle LGNELGFKAEP;

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool FIGEHHHGKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0x218A360", Offset = "0x2188D60", VA = "0x18218A360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public T EDONKBBONCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0x21DC760", Offset = "0x21DB160", VA = "0x1821DC760")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0x21DC6A0", Offset = "0x21DB0A0", VA = "0x1821DC6A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	[Cpp2IlInjected.Address(RVA = "0x21DC800", Offset = "0x21DB200", VA = "0x1821DC800")]
	public CCLGIBKOOPE(T NKJMIDIDBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x21DC670", Offset = "0x21DB070", VA = "0x1821DC670", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public enum MBPDLPKFDDK
{
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct GFLMHAJGBCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	public MBPDLPKFDDK JEJJMBGMCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	public int GBEGILCKBNO;

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x8012C0", Offset = "0x7FFCC0", VA = "0x1808012C0")]
	public GFLMHAJGBCE(MBPDLPKFDDK JEJJMBGMCML, int GBEGILCKBNO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D2D")]
	[Cpp2IlInjected.Address(RVA = "0x217CE10", Offset = "0x217B810", VA = "0x18217CE10")]
	public static GFLMHAJGBCE MFJMDPBHOLK((MBPDLPKFDDK eventType, int eventIndex) GKGDNAPOGPF)
	{
		return default(GFLMHAJGBCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x217CE00", Offset = "0x217B800", VA = "0x18217CE00")]
	public void JFJMGCLPGME(out MBPDLPKFDDK JEJJMBGMCML, out int GBEGILCKBNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
[DNKFJNHNNCA(typeof(EKMDGKGKJEO), new string[] { })]
public sealed class NGHGKJCBHGE : EKMDGKGKJEO, CFMOGGHLNDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private GPAPCFEMAGG KCGGAKHINBE;

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x22CB240", Offset = "0x22C9C40", VA = "0x1822CB240", Slot = "5")]
	public void DIEKKCMGMDL(DOMLOFPDLMI KDGPDENJJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x22CB290", Offset = "0x22C9C90", VA = "0x1822CB290")]
	public bool KHBODJCGHHD(in float3 FGKLEBPPEJI, in float3 KOIMEOLNHNL, float DDIDJKAFDDK, Allocator FAMNMGKAFPB, out NativeArray<Entity> GBNPHFOKMOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public NGHGKJCBHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x22CB290", Offset = "0x22C9C90", VA = "0x1822CB290", Slot = "4")]
	private bool NBCKNDEIMMA(in float3 FGKLEBPPEJI, in float3 KOIMEOLNHNL, float DDIDJKAFDDK, Allocator FAMNMGKAFPB, out NativeArray<Entity> GBNPHFOKMOH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
[EAKKFOPCDBA]
[UpdateInGroup(typeof(PLJKCOPECHA))]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
internal sealed class FAMOEJJDCNN : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x217A590", Offset = "0x2178F90", VA = "0x18217A590", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public FAMOEJJDCNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[EAKKFOPCDBA]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
[UpdateInGroup(typeof(FHIIJFHKBKH))]
public sealed class HKCAJOHJAFG : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x2180DB0", Offset = "0x217F7B0", VA = "0x182180DB0", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public HKCAJOHJAFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[EAKKFOPCDBA]
[UpdateInGroup(typeof(EJICOLKNOJP))]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
internal sealed class ADAJCIPBBJJ : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x24AAC60", Offset = "0x24A9660", VA = "0x1824AAC60", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public ADAJCIPBBJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
internal class FPNCCCCKNID : GFIPAIPJBPC
{
	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public FPNCCCCKNID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[ExecuteAlways]
[EAKKFOPCDBA]
[GMDIBPFFIEN(AHJKMAKLGJA.LoadInstance)]
[UpdateInGroup(typeof(OAKCEFNCIMP))]
internal sealed class CLGKNMADPBA : GEHLDJEIKIH
{
	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x24B27F0", Offset = "0x24B11F0", VA = "0x1824B27F0", Slot = "16")]
	protected override ComponentSystemBase GJJGBNJIDNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x217AAB0", Offset = "0x21794B0", VA = "0x18217AAB0")]
	public CLGKNMADPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[HJICCHMFEGP(typeof(AuthoredLocalPoseData))]
public sealed class DNIFPLEDADF : AGABKDEAFFH
{
	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x24BFF10", Offset = "0x24BE910", VA = "0x1824BFF10", Slot = "8")]
	protected override bool NJMFGBJKOHH(ReadOnlySpan<AuthoredLocalPoseData> BKLDDIKBPBA, EHDEHNCFGLN HLNMPCAECGF, out ReadOnlySpan<byte> IBDMDMLOLOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x24BFE50", Offset = "0x24BE850", VA = "0x1824BFE50", Slot = "9")]
	protected override bool CHKLGIPMIDG(int FDLOHCDDBIM, Span<AuthoredLocalPoseData> BKLDDIKBPBA, in ReadOnlySpan<byte> IBDMDMLOLOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D43")]
	[Cpp2IlInjected.Address(RVA = "0x24BFF90", Offset = "0x24BE990", VA = "0x1824BFF90")]
	public DNIFPLEDADF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[HJICCHMFEGP(typeof(LocalPoseData))]
public sealed class AANDIEGLAEI : KFHGNPEIIPD
{
	[Cpp2IlInjected.Token(Token = "0x6000D44")]
	[Cpp2IlInjected.Address(RVA = "0x24AABD0", Offset = "0x24A95D0", VA = "0x1824AABD0", Slot = "8")]
	protected override bool NJMFGBJKOHH(ReadOnlySpan<LocalPoseData> BKLDDIKBPBA, EHDEHNCFGLN HLNMPCAECGF, out ReadOnlySpan<byte> IBDMDMLOLOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D45")]
	[Cpp2IlInjected.Address(RVA = "0x24AAB10", Offset = "0x24A9510", VA = "0x1824AAB10", Slot = "9")]
	protected override bool CHKLGIPMIDG(int FDLOHCDDBIM, Span<LocalPoseData> BKLDDIKBPBA, in ReadOnlySpan<byte> IBDMDMLOLOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x24AAC50", Offset = "0x24A9650", VA = "0x1824AAC50")]
	public AANDIEGLAEI()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001E7")]
	[Preserve]
	internal class _RRAssemblyIndex : ODIDKPKCBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000D47")]
		[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0x2307A50", Offset = "0x2306450", VA = "0x182307A50", Slot = "6")]
		public sealed override void OAOEINPMJJJ(NBLCNNHCPAE MLFGBBGKHEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0x2306FA0", Offset = "0x23059A0", VA = "0x182306FA0", Slot = "4")]
		public sealed override void HGKEFMKAFGI()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001E8")]
public class LHIPOBGMLKE
{
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private static byte[] PNBNOGIJBMC;

	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private static int DGEFGPNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static int GBGLKCBJBIA;

	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private static BigInteger EPCGLFJDNLL;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHIPOBGMLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x2192790", Offset = "0x2191190", VA = "0x182192790")]
	private static string GKOJACPJHAL(byte[] KCHCODPDAGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x21928A0", Offset = "0x21912A0", VA = "0x1821928A0")]
	public static string MEDIDALCMKC(byte[] GHEBPHBJKNK, bool FPEGHFMMINI)
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
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
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
