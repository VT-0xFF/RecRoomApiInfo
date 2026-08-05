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
public sealed class PLCKCCNKFLL<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class LAMKJBONBGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::PLCKCCNKFLL<T> MHJDHCNCDPH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] NKEABGEOHHK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public LAMKJBONBGP(global::PLCKCCNKFLL<T> MHJDHCNCDPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class INHGLDHNOEH : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::PLCKCCNKFLL<T> <>4__this;

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
		public INHGLDHNOEH(int <>1__state)
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
	private const int AOJPGCOHMFP = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> EBCNPPJONOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int HHIFIGKHJAF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T HIMPFAAIFFL
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
	private bool BOLKCDBAAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool ICEJOOJNMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool BNNLNOELNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HIDCIHPOCOB
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
	public int IGGNICCPKKG
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
	public PLCKCCNKFLL(int OAKAJHNNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public PLCKCCNKFLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void ALACLPOFPEF(int HMJKJGLHFKE, T BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void MPEIJCCPMAM(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] DGKKAOADICN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void BJDCKJJCGCG(NativeArray<T> ICPECNGAFCL, int LMNNOEJODCP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::PLCKCCNKFLL<>.INHGLDHNOEH))]
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
	public int PIPJCOJIJLM(T BKADPMHNDEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool GKDAOIMBAHJ(T BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void AEIJPFIFILA(int KBELPCLKEMB, int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void MNIIDPMJFGO(int KBELPCLKEMB, int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void PGHHEFBAMJB(int KBELPCLKEMB, int FHAPAHAAKAH, int LKJCGNNPEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int IMJJMEHMBHM(int HMJKJGLHFKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T ENILBEDCEGH(int HMJKJGLHFKE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void HNNBODPKAII(int HMJKJGLHFKE, T BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void DPMFDNKJBGO(int HMJKJGLHFKE, T BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void PFAHMDLDCIL(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int BEOHEKCHGJC(int IGDJJEECDAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int MGDMMCIGJBF(int IGDJJEECDAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void EMHEFOGAMEG(T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void OPJHPPIHNHG(T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T ALIENACOIHN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T LOKDJLCKLAE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void COPDMJHJGKG(int HMJKJGLHFKE, IReadOnlyCollection<T> NMDCGDFABNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void HBICALBHNOM(int HMJKJGLHFKE, int ADIJOHPLGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void PJBKNHKCPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void DNCAFLNCCFM(T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void EIJELBCIJDN(T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void NJBMBBDGCEK(int FHAPAHAAKAH, int LKJCGNNPEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T COOLLAMFAFL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T EHBADOOCBPA()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[OGKBFABIIKG]
public static class KNFJJBGIENE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2BC95F0", Offset = "0x2BC89F0", VA = "0x182BC95F0")]
	static KNFJJBGIENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x25B6330", Offset = "0x25B5730", VA = "0x1825B6330")]
	public static void JMBJLHBDPGB<T>(T OHCPCHAKDAC, ref T JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2BC93F0", Offset = "0x2BC87F0", VA = "0x182BC93F0")]
	public static void JMBJLHBDPGB(FixedString32 OHCPCHAKDAC, ref string JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2BC92E0", Offset = "0x2BC86E0", VA = "0x182BC92E0")]
	public static void JMBJLHBDPGB(string OHCPCHAKDAC, ref FixedString32 JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2BC93C0", Offset = "0x2BC87C0", VA = "0x182BC93C0")]
	public static void JMBJLHBDPGB(FixedString64 OHCPCHAKDAC, ref string JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9360", Offset = "0x2BC8760", VA = "0x182BC9360")]
	public static void JMBJLHBDPGB(string OHCPCHAKDAC, ref FixedString64 JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9590", Offset = "0x2BC8990", VA = "0x182BC9590")]
	public static void JMBJLHBDPGB(KCGBKOBBNLI OHCPCHAKDAC, ref Vector3 JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9280", Offset = "0x2BC8680", VA = "0x182BC9280")]
	public static void JMBJLHBDPGB(Vector3 OHCPCHAKDAC, ref KCGBKOBBNLI JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9420", Offset = "0x2BC8820", VA = "0x182BC9420")]
	public static void JMBJLHBDPGB(HNKJCEPLOMN OHCPCHAKDAC, ref Vector4 JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9520", Offset = "0x2BC8920", VA = "0x182BC9520")]
	public static void JMBJLHBDPGB(Vector4 OHCPCHAKDAC, ref HNKJCEPLOMN JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9420", Offset = "0x2BC8820", VA = "0x182BC9420")]
	public static void JMBJLHBDPGB(HNKJCEPLOMN OHCPCHAKDAC, ref Quaternion JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9520", Offset = "0x2BC8920", VA = "0x182BC9520")]
	public static void JMBJLHBDPGB(Quaternion OHCPCHAKDAC, ref HNKJCEPLOMN JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2BC95C0", Offset = "0x2BC89C0", VA = "0x182BC95C0")]
	public static void JMBJLHBDPGB(KCGBKOBBNLI OHCPCHAKDAC, ref float3 JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9280", Offset = "0x2BC8680", VA = "0x182BC9280")]
	public static void JMBJLHBDPGB(float3 OHCPCHAKDAC, ref KCGBKOBBNLI JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9320", Offset = "0x2BC8720", VA = "0x182BC9320")]
	public static void JMBJLHBDPGB(HNKJCEPLOMN OHCPCHAKDAC, ref float4 JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9520", Offset = "0x2BC8920", VA = "0x182BC9520")]
	public static void JMBJLHBDPGB(float4 OHCPCHAKDAC, ref HNKJCEPLOMN JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9320", Offset = "0x2BC8720", VA = "0x182BC9320")]
	public static void JMBJLHBDPGB(HNKJCEPLOMN OHCPCHAKDAC, ref quaternion JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2BC94B0", Offset = "0x2BC88B0", VA = "0x182BC94B0")]
	public static void JMBJLHBDPGB(quaternion OHCPCHAKDAC, ref HNKJCEPLOMN JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9450", Offset = "0x2BC8850", VA = "0x182BC9450")]
	public static void JMBJLHBDPGB(Entity OHCPCHAKDAC, ref OFIOAPBELNM JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9490", Offset = "0x2BC8890", VA = "0x182BC9490")]
	public static void JMBJLHBDPGB(OFIOAPBELNM OHCPCHAKDAC, ref Entity JNOODDLMHDD, OBEFJIDEFOJ JDIPGKNLNAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NIILAANKHKM]
public class EEOFMJOKDPP : ComponentSystem, LNLPIGELLPM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CLFAHLJOOKN NDOKDKDNGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x679130", Offset = "0x678530", VA = "0x180679130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public APFPCLEOLKC BDCPKBMPNNB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BA1C0", Offset = "0x6B95C0", VA = "0x1806BA1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2B94EE0", Offset = "0x2B942E0", VA = "0x182B94EE0", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
	public EEOFMJOKDPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NIILAANKHKM]
[UpdateInGroup(typeof(NMAMPKJMJKG))]
internal class MHBANJIFNGB : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1D50", Offset = "0x2BD1150", VA = "0x182BD1D50", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1F90", Offset = "0x2BD1390", VA = "0x182BD1F90")]
	[Preserve]
	private void KFEPBALIJFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public MHBANJIFNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NIILAANKHKM]
[UpdateInGroup(typeof(NMAMPKJMJKG))]
internal class NICIGIMCJMA : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x29D7880", Offset = "0x29D6C80", VA = "0x1829D7880", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public NICIGIMCJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x29E33C0", Offset = "0x29E27C0", VA = "0x1829E33C0")]
		public static ObjectModelConfigAsset MNEHDFMPMIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xEE1590", Offset = "0xEE0990", VA = "0x180EE1590")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[JLJFNDDLCBO(CBGNDNDJKHL.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int EAAMJEPFANE = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly DLHDGHMPCLG HCDIHNPPHMM;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x4335880", Offset = "0x4334C80", VA = "0x184335880")]
			public static JCHOAKCKPKK EHJLGOEKKIC(int OAMIPHACCGF)
			{
				return default(JCHOAKCKPKK);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x43356F0", Offset = "0x4334AF0", VA = "0x1843356F0")]
			private static void CKFBCOPHGAN(MOLBNKBNJLI DCJOLCHOKFI, MOLBNKBNJLI CBBBMABJIHI, JCHOAKCKPKK OMKLELDMIKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x4335C70", Offset = "0x4335070", VA = "0x184335C70")]
			public static int KFLOKPFHLNG(GameObject FLFBOHHHJJB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x4335E40", Offset = "0x4335240", VA = "0x184335E40")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void ONKHKNGMCBG(MOLBNKBNJLI AFGGEMMDNNF, int OAMIPHACCGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static MMBGCEPKKOC CKGKDHACBKE;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static EAEIHBAGMAO JOGJFLEFHAI;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static MMBGCEPKKOC JHKANIDIPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x29E34C0", Offset = "0x29E28C0", VA = "0x1829E34C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x29E4120", Offset = "0x29E3520", VA = "0x1829E4120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static EAEIHBAGMAO BCOENIFILMH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x29E3620", Offset = "0x29E2A20", VA = "0x1829E3620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x29E3C30", Offset = "0x29E3030", VA = "0x1829E3C30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool HOGECKAIIBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x29E39D0", Offset = "0x29E2DD0", VA = "0x1829E39D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static CLFAHLJOOKN NDOKDKDNGFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x29E4200", Offset = "0x29E3600", VA = "0x1829E4200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static APFPCLEOLKC BDCPKBMPNNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x29E4DA0", Offset = "0x29E41A0", VA = "0x1829E4DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static PENOFJBLKNM PGHAENCANCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x29E4AA0", Offset = "0x29E3EA0", VA = "0x1829E4AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static PAIHKGLKBFJ LIDDMMEMCCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x29E40A0", Offset = "0x29E34A0", VA = "0x1829E40A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static FOKCOLGHCMD NHJFLKKBDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x29E3870", Offset = "0x29E2C70", VA = "0x1829E3870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static GONOMBLLIBK HHMAHAKHJJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x29E38F0", Offset = "0x29E2CF0", VA = "0x1829E38F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool HHOFJIGAILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x29E4E20", Offset = "0x29E4220", VA = "0x1829E4E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool CIPFGMLEOCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x29E4480", Offset = "0x29E3880", VA = "0x1829E4480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool MNEEDLPBKGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x29E3460", Offset = "0x29E2860", VA = "0x1829E3460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x29E4C60", Offset = "0x29E4060", VA = "0x1829E4C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool FANDJOAGPNH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x29E47A0", Offset = "0x29E3BA0", VA = "0x1829E47A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x29E3970", Offset = "0x29E2D70", VA = "0x1829E3970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action MEHLGLPEDBB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x29E3B30", Offset = "0x29E2F30", VA = "0x1829E3B30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x29E3520", Offset = "0x29E2920", VA = "0x1829E3520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x29E4390", Offset = "0x29E3790", VA = "0x1829E4390")]
		public static MOLBNKBNJLI HCFMGPPNBIF(GameObject FLFBOHHHJJB)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x29E4C00", Offset = "0x29E4000", VA = "0x1829E4C00")]
		public static bool LOMLFGFIIGC(ByteString BIPDDAIIHHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x29E3F80", Offset = "0x29E3380", VA = "0x1829E3F80")]
		public static MJBBCNDEMML FIAAPHEPHPO(JCHOAKCKPKK OMKLELDMIKD)
		{
			return default(MJBBCNDEMML);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x29E3E50", Offset = "0x29E3250", VA = "0x1829E3E50")]
		public static (ByteString, IDisposable) FBLBIDAIACI()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x29E4670", Offset = "0x29E3A70", VA = "0x1829E4670")]
		public static (ByteString, IDisposable) IAILNMFLOHE(IEnumerable<MOLBNKBNJLI> NIFJDIAEFGK)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x29E3740", Offset = "0x29E2B40", VA = "0x1829E3740")]
		public static bool BKKFLGIIJFC(GameObject FLFBOHHHJJB, out JCHOAKCKPKK OMKLELDMIKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x29E42A0", Offset = "0x29E36A0", VA = "0x1829E42A0")]
		public static bool GMAHJCHKGPF(IEnumerable<FANAPLKCHPF> HEBJGGPOLHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x29E4CC0", Offset = "0x29E40C0", VA = "0x1829E4CC0")]
		public static void NACOHOLCNHH(bool NCFLAPIBDMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x29E4800", Offset = "0x29E3C00", VA = "0x1829E4800")]
		public static Task IDJLKLNJDHB(bool NCFLAPIBDMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x29E4B20", Offset = "0x29E3F20", VA = "0x1829E4B20")]
		private static EAEIHBAGMAO LIOJHCHHMLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x29E4980", Offset = "0x29E3D80", VA = "0x1829E4980")]
		private static bool IJOCBPLDPLC()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x29E9570", Offset = "0x29E8970", VA = "0x1829E9570")]
		public static bool CNOAALLBJOK(GHHFOHNOLPM IJACDOHPJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x29E9920", Offset = "0x29E8D20", VA = "0x1829E9920")]
		public static GHHFOHNOLPM JGOJGDHNHPP(GameObject FLFBOHHHJJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x29E9720", Offset = "0x29E8B20", VA = "0x1829E9720")]
		public static GHHFOHNOLPM JGOJGDHNHPP(GameObject FLFBOHHHJJB, JCHOAKCKPKK OMKLELDMIKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x29E9620", Offset = "0x29E8A20", VA = "0x1829E9620")]
		public static bool FFEOCPDGIJK(GameObject GEMPPKOEIPE, string AAGKJCIKDND, bool HMCIJGCBGCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x29E9B50", Offset = "0x29E8F50", VA = "0x1829E9B50")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void JOBEBPIKLII(GameObject GEMPPKOEIPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x29E9480", Offset = "0x29E8880", VA = "0x1829E9480")]
		[CompilerGenerated]
		internal static string BBEBNHDGNKH((GameObject go, string prefabName) MMLIFJCNOMF)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, BHLFJIENHBI
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool MMIGCPEOPKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x699020", Offset = "0x698420", VA = "0x180699020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public MOLBNKBNJLI LMHNINBJGMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x699040", Offset = "0x698440", VA = "0x180699040", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(MOLBNKBNJLI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x2B93D30", Offset = "0x2B93130", VA = "0x182B93D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[JLJFNDDLCBO(CBGNDNDJKHL.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, GHHFOHNOLPM, BHLFJIENHBI
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string IOMEOHCAKDO = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private NNJDCFENACE OHACFAMPHAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MOLBNKBNJLI OACDBCDEFBJ;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public MOLBNKBNJLI LMHNINBJGMA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2B96C10", Offset = "0x2B96010", VA = "0x182B96C10", Slot = "15")]
			get
			{
				return default(MOLBNKBNJLI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public MJBBCNDEMML GIAADHNLHOF
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2B96CC0", Offset = "0x2B960C0", VA = "0x182B96CC0", Slot = "6")]
			get
			{
				return default(MJBBCNDEMML);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool MMIGCPEOPKL
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2B96C00", Offset = "0x2B96000", VA = "0x182B96C00", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NNJDCFENACE OOHCKBPJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9E88C0", Offset = "0x9E7CC0", VA = "0x1809E88C0", Slot = "7")]
			get
			{
				return default(NNJDCFENACE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private APFPCLEOLKC BDCPKBMPNNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x2B964F0", Offset = "0x2B958F0", VA = "0x182B964F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private KAPLNDGMNPC PDKPKEPAJNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2B96240", Offset = "0x2B95640", VA = "0x182B96240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool LANJCEEHGGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x768F80", Offset = "0x768380", VA = "0x180768F80", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x732170", Offset = "0x731570", VA = "0x180732170", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> APPLHIMPKEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x2B96AC0", Offset = "0x2B95EC0", VA = "0x182B96AC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2B96CF0", Offset = "0x2B960F0", VA = "0x182B96CF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<GHHFOHNOLPM> BEMHEOKPJEA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2B96B60", Offset = "0x2B95F60", VA = "0x182B96B60", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2B96D90", Offset = "0x2B96190", VA = "0x182B96D90", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B95FD0", Offset = "0x2B953D0", VA = "0x182B95FD0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B96920", Offset = "0x2B95D20", VA = "0x182B96920", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B965D0", Offset = "0x2B959D0", VA = "0x182B965D0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B96890", Offset = "0x2B95C90", VA = "0x182B96890", Slot = "10")]
		public void OnEmbody(NHLELLEJLGC KIEEJCIFMFE, MOLBNKBNJLI OACDBCDEFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2B96910", Offset = "0x2B95D10", VA = "0x182B96910", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2B96680", Offset = "0x2B95A80", VA = "0x182B96680", Slot = "12")]
		public void OnDisembody(bool CBJNDDBEHPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2B962A0", Offset = "0x2B956A0", VA = "0x182B962A0")]
		private void GIMJCAJOAHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2B961B0", Offset = "0x2B955B0", VA = "0x182B961B0")]
		private void CBAHCLPMHIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2B963A0", Offset = "0x2B957A0", VA = "0x182B963A0")]
		private void JHAOJEHBMHM(bool LOIHHCHJGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2B96490", Offset = "0x2B95890", VA = "0x182B96490", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1054460", Offset = "0x1053860", VA = "0x181054460", Slot = "9")]
		private GameObject ECDKHGFMCEC()
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
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[JLJFNDDLCBO(CBGNDNDJKHL.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override APCEPJKMKDM DNKOIHKIPAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x29F43E0", Offset = "0x29F37E0", VA = "0x1829F43E0", Slot = "6")]
			get
			{
				return default(APCEPJKMKDM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x29F4380", Offset = "0x29F3780", VA = "0x1829F4380")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[JLJFNDDLCBO(CBGNDNDJKHL.Registration)]
	public class TransformEntity : MonoBehaviour, BHLFJIENHBI
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private APCEPJKMKDM prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private MOLBNKBNJLI AFGGEMMDNNF;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual APCEPJKMKDM DNKOIHKIPAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0", Slot = "6")]
			get
			{
				return default(APCEPJKMKDM);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x71C410", Offset = "0x71B810", VA = "0x18071C410", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public MOLBNKBNJLI LMHNINBJGMA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCB1B40", Offset = "0xCB0F40", VA = "0x180CB1B40", Slot = "5")]
			get
			{
				return default(MOLBNKBNJLI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool MMIGCPEOPKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x678030", Offset = "0x677430", VA = "0x180678030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x813720", Offset = "0x812B20", VA = "0x180813720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal Entity BIMHONKFKHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal FOKCOLGHCMD NHJFLKKBDHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal KAPLNDGMNPC JLJIEEENAIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x2CAC7F0", Offset = "0x2CABBF0", VA = "0x182CAC7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC650", Offset = "0x2CABA50", VA = "0x182CAC650")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC700", Offset = "0x2CABB00", VA = "0x182CAC700")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC890", Offset = "0x2CABC90", VA = "0x182CAC890")]
		internal void LJAJKOINHPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC660", Offset = "0x2CABA60", VA = "0x182CAC660")]
		private bool FCLHHAAJOEM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC860", Offset = "0x2CABC60", VA = "0x182CAC860")]
		private void KLDDOIMADHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC700", Offset = "0x2CABB00", VA = "0x182CAC700")]
		internal void FLGFHANBACE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2CACBA0", Offset = "0x2CABFA0", VA = "0x182CACBA0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2CACC80", Offset = "0x2CAC080", VA = "0x182CACC80")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[JJCBNHCEDIO(typeof(LCCHFDCPEHE))]
[NDGJMMLBLBO(typeof(EAEIHBAGMAO), new string[] { })]
public class LKKPBBEAJIG : FLKCFHJEEIO, EABOAMMCGPI, EAEIHBAGMAO, AHNBHABGBNB, LCCHFDCPEHE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private PMJCGABOKOD IFCDDJDBLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private APFPCLEOLKC FCGMOLCPBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private LLOINIJEHPN GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private MANDPKBPCIG LCELIFFKEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IONFNBCFBFH GKFCHINCBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C94C0", Offset = "0x8C88C0", VA = "0x1808C94C0", Slot = "19")]
		get
		{
			return default(IONFNBCFBFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public PMJCGABOKOD NDOKDKDNGFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public LLOINIJEHPN JGFGAHEDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public APFPCLEOLKC BDCPKBMPNNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool NMHLJFGMGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x678030", Offset = "0x677430", VA = "0x180678030", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DGHOOJGKDDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFB00", Offset = "0x2BCEF00", VA = "0x182BCFB00", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF4D0", Offset = "0x2BCE8D0", VA = "0x182BCF4D0", Slot = "20")]
	public void APMAKEGPFLO(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7CA810", Offset = "0x7C9C10", VA = "0x1807CA810")]
	private void FFHOKNLNLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFCB0", Offset = "0x2BCF0B0", VA = "0x182BCFCB0")]
	private void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	private void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF690", Offset = "0x2BCEA90", VA = "0x182BCF690", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF650", Offset = "0x2BCEA50", VA = "0x182BCF650", Slot = "10")]
	public void CFPONFFOKKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
	public void KKJCHBMIONB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF5E0", Offset = "0x2BCE9E0", VA = "0x182BCF5E0", Slot = "5")]
	public void APNEDGGEGMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF7D0", Offset = "0x2BCEBD0", VA = "0x182BCF7D0", Slot = "6")]
	public void FNAENLIAFAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFA60", Offset = "0x2BCEE60", VA = "0x182BCFA60", Slot = "7")]
	public void GPCJEHOLBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF980", Offset = "0x2BCED80", VA = "0x182BCF980", Slot = "8")]
	public bool GMAHJCHKGPF(IEnumerable<FANAPLKCHPF> HEBJGGPOLHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF910", Offset = "0x2BCED10", VA = "0x182BCF910", Slot = "9")]
	public void GBPFFDAANPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFC40", Offset = "0x2BCF040", VA = "0x182BCFC40", Slot = "11")]
	public void NGABEEMPMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF450", Offset = "0x2BCE850", VA = "0x182BCF450", Slot = "12")]
	public void AHONLGEAIPA(bool NKAIKNCAGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFAD0", Offset = "0x2BCEED0", VA = "0x182BCFAD0")]
	private void HDEBKEBDBGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF6F0", Offset = "0x2BCEAF0", VA = "0x182BCF6F0", Slot = "13")]
	public ByteString FBLBIDAIACI(out IDisposable CIKJMIFHOLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFB10", Offset = "0x2BCEF10", VA = "0x182BCFB10", Slot = "14")]
	public void LOHKEOMODAB(ByteString PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF820", Offset = "0x2BCEC20", VA = "0x182BCF820")]
	public static LKKPBBEAJIG FNICMNFMKAL(PMJCGABOKOD IFCDDJDBLKM, PIBKLBMCIOB AOFGAGALOCP = PIBKLBMCIOB.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	private static void MCLEBDNEHHF(PMJCGABOKOD IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	private static void KDAPAMNCOCB(PMJCGABOKOD IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public LKKPBBEAJIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GKPELGKADIO
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB5F0", Offset = "0x2BBA9F0", VA = "0x182BBB5F0")]
	public static MJBBCNDEMML BPFKIPKCGPJ(this EAEIHBAGMAO JOGJFLEFHAI, JCHOAKCKPKK OMKLELDMIKD, APCEPJKMKDM BKEDDPMCLJC)
	{
		return default(MJBBCNDEMML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB910", Offset = "0x2BBAD10", VA = "0x182BBB910")]
	public static GIHAGJBGBCN IHKKGFJJNLO(this EAEIHBAGMAO JOGJFLEFHAI)
	{
		return default(GIHAGJBGBCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB860", Offset = "0x2BBAC60", VA = "0x182BBB860")]
	public static MOLBNKBNJLI HCFMGPPNBIF(this EAEIHBAGMAO JOGJFLEFHAI, Entity NOADJCMIKEF)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB730", Offset = "0x2BBAB30", VA = "0x182BBB730")]
	public static MOLBNKBNJLI HCFMGPPNBIF(this EAEIHBAGMAO JOGJFLEFHAI, JCHOAKCKPKK OMKLELDMIKD)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBA30", Offset = "0x2BBAE30", VA = "0x182BBBA30")]
	public static JCHOAKCKPKK POJPFCFFABO(this EAEIHBAGMAO JOGJFLEFHAI, MOLBNKBNJLI AFGGEMMDNNF)
	{
		return default(JCHOAKCKPKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum PIBKLBMCIOB
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
public class KFJKPBJLMIA<T> : global::IGKECHFMOPE<T>, global::CGELFOKBEAG<JCHOAKCKPKK, T>, global::NFJJJCLNINK<JCHOAKCKPKK>, JADEFGIHAPF, IDisposable, HECNDLCBEON where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::NFJJJCLNINK<Entity> PDLHECKEFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate FHCFIDLOMMG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string GAELEJJHLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x33966E0", Offset = "0x3395AE0", VA = "0x1833966E0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type AKDIGOBFKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3389B40", Offset = "0x3388F40", VA = "0x183389B40", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HBHFLIIDJCA AGPIEKKCNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x3391E00", Offset = "0x3391200", VA = "0x183391E00", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BGHPLCHJNIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3386B10", Offset = "0x3385F10", VA = "0x183386B10", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FBJCPEJEDDD MFDLJAGLOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3386610", Offset = "0x3385A10", VA = "0x183386610", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1EFCC40", Offset = "0x1EFC040", VA = "0x181EFCC40", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x33932A0", Offset = "0x33926A0", VA = "0x1833932A0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::LDOJCJDPDHB<JCHOAKCKPKK> MEHLGLPEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x3389570", Offset = "0x3388970", VA = "0x183389570", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3386270", Offset = "0x3385670", VA = "0x183386270", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x32A5850", Offset = "0x32A4C50", VA = "0x1832A5850")]
	public KFJKPBJLMIA(global::NFJJJCLNINK<Entity> PDLHECKEFMN, FOKCOLGHCMD PIPGPNJGNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x33887F0", Offset = "0x3387BF0", VA = "0x1833887F0")]
	private Entity DKOALHGANJG(JCHOAKCKPKK OMKLELDMIKD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x32A08D0", Offset = "0x329FCD0", VA = "0x1832A08D0")]
	private JCHOAKCKPKK DKOALHGANJG(Entity NOADJCMIKEF)
	{
		return default(JCHOAKCKPKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x338E510", Offset = "0x338D910", VA = "0x18338E510", Slot = "4")]
	public T JLHLNIPLDNM(JCHOAKCKPKK OMKLELDMIKD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3390CE0", Offset = "0x33900E0", VA = "0x183390CE0")]
	public bool KNBGLHDOKIA(JCHOAKCKPKK OMKLELDMIKD, in T NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x338BFE0", Offset = "0x338B3E0", VA = "0x18338BFE0")]
	public bool HLAGCIABKCD(JCHOAKCKPKK OMKLELDMIKD, in T NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x338A9D0", Offset = "0x3389DD0", VA = "0x18338A9D0", Slot = "9")]
	public bool HGNKBEMEDCJ(JCHOAKCKPKK OMKLELDMIKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3396A50", Offset = "0x3395E50", VA = "0x183396A50", Slot = "26")]
	public object NAOKHJBBHNP(JCHOAKCKPKK OMKLELDMIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x339A8C0", Offset = "0x3399CC0", VA = "0x18339A8C0")]
	public bool PAAEDINFLDN(JCHOAKCKPKK OMKLELDMIKD, in object NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x338E880", Offset = "0x338DC80", VA = "0x18338E880")]
	public void JLHLNIPLDNM(JCHOAKCKPKK OMKLELDMIKD, in LCJNEDPGPKG IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x3390970", Offset = "0x338FD70", VA = "0x183390970")]
	public bool KNBGLHDOKIA(JCHOAKCKPKK OMKLELDMIKD, in PEABCJAGJAH NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x338C180", Offset = "0x338B580", VA = "0x18338C180")]
	public bool HLAGCIABKCD(JCHOAKCKPKK OMKLELDMIKD, in PEABCJAGJAH NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x32A3040", Offset = "0x32A2440", VA = "0x1832A3040", Slot = "22")]
	public void LLJNHDKGDNB(JPMGOPHCIKO AKLLJAGFMDH, [Optional] object GKMHGIGLKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3392B30", Offset = "0x3391F30", VA = "0x183392B30", Slot = "15")]
	public void LLJNHDKGDNB(JCHOAKCKPKK FOJIGKKHICE, CPMBOJGNMDD AKLLJAGFMDH, object GKMHGIGLKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x339AF80", Offset = "0x339A380", VA = "0x18339AF80", Slot = "14")]
	public bool PGNDNBFJNLK(JCHOAKCKPKK JNOODDLMHDD, JCHOAKCKPKK OHCPCHAKDAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2391490", Offset = "0x2390890", VA = "0x182391490", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x339B8B0", Offset = "0x339ACB0", VA = "0x18339B8B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3385830", Offset = "0x3384C30", VA = "0x183385830")]
	public string ALGJFNADCFK(in PEABCJAGJAH BPGFECJFNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x338D2F0", Offset = "0x338C6F0", VA = "0x18338D2F0")]
	private void JHLNKLFBGMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3387040", Offset = "0x3386440", VA = "0x183387040")]
	private void CHGOONGCOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3394460", Offset = "0x3393860", VA = "0x183394460")]
	private void MMKFNGONCHN(Entity NOADJCMIKEF, in PEABCJAGJAH EIKDBDKEAPN, in PEABCJAGJAH NDKJFJECHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3389D40", Offset = "0x3389140", VA = "0x183389D40")]
	private void GBEDIGHPBJO(Entity NOADJCMIKEF, in PEABCJAGJAH EIKDBDKEAPN, in PEABCJAGJAH NDKJFJECHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3398560", Offset = "0x3397960", VA = "0x183398560")]
	[Conditional("DEBUG_BUILD")]
	private static void OGLFCBJCCBD(Entity NOADJCMIKEF, JCHOAKCKPKK OMKLELDMIKD, string JLNILGJAKJL, string BANMHGGLELE, [CallerMemberName] string DJJLKKBGDFN = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x251E7A0", Offset = "0x251DBA0", VA = "0x18251E7A0", Slot = "5")]
	private bool JMMODCKNHOF(JCHOAKCKPKK FOJIGKKHICE, in T NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2BE0380", Offset = "0x2BDF780", VA = "0x182BE0380", Slot = "6")]
	private bool OJIKEBHNOCC(JCHOAKCKPKK FOJIGKKHICE, in T NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x29D34D0", Offset = "0x29D28D0", VA = "0x1829D34D0", Slot = "10")]
	private bool MGBJNHJEBGM(JCHOAKCKPKK FOJIGKKHICE, in object NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x32A34F0", Offset = "0x32A28F0", VA = "0x1832A34F0", Slot = "11")]
	private void MIFPMANFNAD(JCHOAKCKPKK FOJIGKKHICE, in LCJNEDPGPKG IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x32A1850", Offset = "0x32A0C50", VA = "0x1832A1850", Slot = "12")]
	private bool HPCPOMGOFMI(JCHOAKCKPKK FOJIGKKHICE, in PEABCJAGJAH NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x32A4340", Offset = "0x32A3740", VA = "0x1832A4340", Slot = "13")]
	private bool MPGLMMLNMOG(JCHOAKCKPKK FOJIGKKHICE, in PEABCJAGJAH NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x32A1F10", Offset = "0x32A1310", VA = "0x1832A1F10", Slot = "16")]
	private string JJCGAJMGNHL(in PEABCJAGJAH IGDJJEECDAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DefaultMember("Item")]
public class CKHIIFEFCFK<T> : global::ODBJEBNEDIM<T>, global::CGELFOKBEAG<MOLBNKBNJLI, T>, global::NFJJJCLNINK<MOLBNKBNJLI>, JADEFGIHAPF, IDisposable, MCLHOLCKNPA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly global::NFJJJCLNINK<Entity> PDLHECKEFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Delegate FHCFIDLOMMG;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string GAELEJJHLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A8E890", Offset = "0x3A8DC90", VA = "0x183A8E890", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Type AKDIGOBFKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3A81020", Offset = "0x3A80420", VA = "0x183A81020", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public HBHFLIIDJCA AGPIEKKCNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3A89B40", Offset = "0x3A88F40", VA = "0x183A89B40", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int BGHPLCHJNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3A7EB70", Offset = "0x3A7DF70", VA = "0x183A7EB70", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public FBJCPEJEDDD MFDLJAGLOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3A7E5D0", Offset = "0x3A7D9D0", VA = "0x183A7E5D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public T HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3A81B20", Offset = "0x3A80F20", VA = "0x183A81B20", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3A8B1A0", Offset = "0x3A8A5A0", VA = "0x183A8B1A0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::LDOJCJDPDHB<MOLBNKBNJLI> MEHLGLPEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A80830", Offset = "0x3A7FC30", VA = "0x183A80830", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3A7DC70", Offset = "0x3A7D070", VA = "0x183A7DC70", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x32A5850", Offset = "0x32A4C50", VA = "0x1832A5850")]
	public CKHIIFEFCFK(global::NFJJJCLNINK<Entity> PDLHECKEFMN, FOKCOLGHCMD PIPGPNJGNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x158B5E0", Offset = "0x158A9E0", VA = "0x18158B5E0")]
	private Entity DKOALHGANJG(MOLBNKBNJLI AFGGEMMDNNF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3A80540", Offset = "0x3A7F940", VA = "0x183A80540")]
	private MOLBNKBNJLI DKOALHGANJG(Entity NOADJCMIKEF)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x3A863F0", Offset = "0x3A857F0", VA = "0x183A863F0", Slot = "4")]
	public T JLHLNIPLDNM(MOLBNKBNJLI AFGGEMMDNNF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3A88220", Offset = "0x3A87620", VA = "0x183A88220")]
	public bool KNBGLHDOKIA(MOLBNKBNJLI AFGGEMMDNNF, in T NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3A82F50", Offset = "0x3A82350", VA = "0x183A82F50")]
	public bool HLAGCIABKCD(MOLBNKBNJLI AFGGEMMDNNF, in T NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3A81EB0", Offset = "0x3A812B0", VA = "0x183A81EB0", Slot = "9")]
	public bool HGNKBEMEDCJ(MOLBNKBNJLI AFGGEMMDNNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3A8EBB0", Offset = "0x3A8DFB0", VA = "0x183A8EBB0", Slot = "26")]
	public object NAOKHJBBHNP(MOLBNKBNJLI AFGGEMMDNNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3A8FBC0", Offset = "0x3A8EFC0", VA = "0x183A8FBC0")]
	public bool PAAEDINFLDN(MOLBNKBNJLI AFGGEMMDNNF, in object NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3A87F50", Offset = "0x3A87350", VA = "0x183A87F50")]
	public void JLHLNIPLDNM(MOLBNKBNJLI AFGGEMMDNNF, in LCJNEDPGPKG IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3A88700", Offset = "0x3A87B00", VA = "0x183A88700")]
	public bool KNBGLHDOKIA(MOLBNKBNJLI AFGGEMMDNNF, in PEABCJAGJAH NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x3A825F0", Offset = "0x3A819F0", VA = "0x183A825F0")]
	public bool HLAGCIABKCD(MOLBNKBNJLI AFGGEMMDNNF, in PEABCJAGJAH NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x32A3040", Offset = "0x32A2440", VA = "0x1832A3040", Slot = "22")]
	public void LLJNHDKGDNB(JPMGOPHCIKO AKLLJAGFMDH, [Optional] object GKMHGIGLKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3A8A160", Offset = "0x3A89560", VA = "0x183A8A160", Slot = "15")]
	public void LLJNHDKGDNB(MOLBNKBNJLI FOJIGKKHICE, CPMBOJGNMDD AKLLJAGFMDH, object GKMHGIGLKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3A909F0", Offset = "0x3A8FDF0", VA = "0x183A909F0", Slot = "14")]
	public bool PGNDNBFJNLK(MOLBNKBNJLI JNOODDLMHDD, MOLBNKBNJLI OHCPCHAKDAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3A84F30", Offset = "0x3A84330", VA = "0x183A84F30")]
	private void JHLNKLFBGMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3A7EDE0", Offset = "0x3A7E1E0", VA = "0x183A7EDE0")]
	private void CHGOONGCOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3A8CB90", Offset = "0x3A8BF90", VA = "0x183A8CB90")]
	private void MMKFNGONCHN(Entity NOADJCMIKEF, in PEABCJAGJAH EIKDBDKEAPN, in PEABCJAGJAH NDKJFJECHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3A81350", Offset = "0x3A80750", VA = "0x183A81350")]
	private void GBEDIGHPBJO(Entity NOADJCMIKEF, in PEABCJAGJAH EIKDBDKEAPN, in PEABCJAGJAH NDKJFJECHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3A80DB0", Offset = "0x3A801B0", VA = "0x183A80DB0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3A91290", Offset = "0x3A90690", VA = "0x183A91290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x3385830", Offset = "0x3384C30", VA = "0x183385830")]
	public string ALGJFNADCFK(in PEABCJAGJAH BPGFECJFNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3A81260", Offset = "0x3A80660", VA = "0x183A81260", Slot = "5")]
	private bool ELNKHLDALCF(MOLBNKBNJLI FOJIGKKHICE, in T NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3A81AE0", Offset = "0x3A80EE0", VA = "0x183A81AE0", Slot = "6")]
	private bool HBJIPEBBMLD(MOLBNKBNJLI FOJIGKKHICE, in T NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3A4F9E0", Offset = "0x3A4EDE0", VA = "0x183A4F9E0", Slot = "10")]
	private bool JKEKEPHKGBL(MOLBNKBNJLI FOJIGKKHICE, in object NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3A83D70", Offset = "0x3A83170", VA = "0x183A83D70", Slot = "11")]
	private void IFJAFFGIDEE(MOLBNKBNJLI FOJIGKKHICE, in LCJNEDPGPKG IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E980", Offset = "0x3A8DD80", VA = "0x183A8E980", Slot = "12")]
	private bool MPDPFFLMIBM(MOLBNKBNJLI FOJIGKKHICE, in PEABCJAGJAH NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3A7E400", Offset = "0x3A7D800", VA = "0x183A7E400", Slot = "13")]
	private bool BMFGGGAIKKM(MOLBNKBNJLI FOJIGKKHICE, in PEABCJAGJAH NDKJFJECHPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x32A1F10", Offset = "0x32A1310", VA = "0x1832A1F10", Slot = "16")]
	private string MMJDIDAPJKJ(in PEABCJAGJAH IGDJJEECDAF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MBFACJCILKL : IDisposable, JDNEAEGGDIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> LKFJMNCPGCI;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> PEFJBDNIEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xD85780", Offset = "0xD84B80", VA = "0x180D85780", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0xD8B120", Offset = "0xD8A520", VA = "0x180D8B120")]
	public MBFACJCILKL(NativeArray<EntityRemapUtility.EntityRemapInfo> LKFJMNCPGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2BD13A0", Offset = "0x2BD07A0", VA = "0x182BD13A0", Slot = "6")]
	public MOLBNKBNJLI DELGEIOFCPD(MOLBNKBNJLI AFGGEMMDNNF)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1390", Offset = "0x2BD0790", VA = "0x182BD1390", Slot = "7")]
	public Entity DELGEIOFCPD(Entity NOADJCMIKEF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2BD12F0", Offset = "0x2BD06F0", VA = "0x182BD12F0", Slot = "8")]
	public IEnumerable<MOLBNKBNJLI> DELGEIOFCPD(IEnumerable<MOLBNKBNJLI> NIFJDIAEFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2BD13F0", Offset = "0x2BD07F0", VA = "0x182BD13F0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private static readonly DLHDGHMPCLG CILBKIHIGPE;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static int CKEPNMNDHCJ;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static JDNEAEGGDIG AILDDPCONMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool HDGPPNKNAEO;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> PEFJBDNIEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x2CA5130", Offset = "0x2CA4530", VA = "0x182CA5130")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static bool OFCIHJFJKCG
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2CA4F30", Offset = "0x2CA4330", VA = "0x182CA4F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA50D0", Offset = "0x2CA44D0", VA = "0x182CA50D0")]
		public static SerializationRemapScope HALLPNKCMNP()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA52D0", Offset = "0x2CA46D0", VA = "0x182CA52D0")]
		public SerializationRemapScope(JDNEAEGGDIG PMBOPCKMJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4FC0", Offset = "0x2CA43C0", VA = "0x182CA4FC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4CA0", Offset = "0x2CA40A0", VA = "0x182CA4CA0")]
		public static MOLBNKBNJLI DELGEIOFCPD(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4E00", Offset = "0x2CA4200", VA = "0x182CA4E00")]
		public static Entity DELGEIOFCPD(Entity NOADJCMIKEF)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[NDGJMMLBLBO(typeof(FGFBHEPDPJD), new string[] { "Editor" })]
[DAPOABPDMCD(GPPMCHFFAPH.Application)]
public sealed class FGFBHEPDPJD
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate void PFCGNBKNFOI(JCHOAKCKPKK EDANMEFBKLK, GAKKJFKJMJN PNMIIEJFOON, bool JCKKGEJLICG);

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public delegate void AJIBGBLDMME(JCHOAKCKPKK EDANMEFBKLK, bool JCKKGEJLICG);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void MBOCFMCHLNJ(JCHOAKCKPKK EDANMEFBKLK, EEJFBJIDABN PDLHECKEFMN, in PEABCJAGJAH IGDJJEECDAF, bool JCKKGEJLICG);

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PFCGNBKNFOI NEPAKLIOODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7850", Offset = "0x2BB6C50", VA = "0x182BB7850")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7940", Offset = "0x2BB6D40", VA = "0x182BB7940")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event AJIBGBLDMME DICBBLPMAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x2BB79E0", Offset = "0x2BB6DE0", VA = "0x182BB79E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x2BB77B0", Offset = "0x2BB6BB0", VA = "0x182BB77B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event MBOCFMCHLNJ HMPIFNDIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7710", Offset = "0x2BB6B10", VA = "0x182BB7710")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7670", Offset = "0x2BB6A70", VA = "0x182BB7670")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7A80", Offset = "0x2BB6E80", VA = "0x182BB7A80")]
	[Conditional("UNITY_EDITOR")]
	public void PGIJEDBEMFM(JCHOAKCKPKK EDANMEFBKLK, in GAKKJFKJMJN PNMIIEJFOON, bool JCKKGEJLICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7920", Offset = "0x2BB6D20", VA = "0x182BB7920")]
	[Conditional("UNITY_EDITOR")]
	public void IFKFFILHPKO(JCHOAKCKPKK EDANMEFBKLK, bool JCKKGEJLICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2BB78F0", Offset = "0x2BB6CF0", VA = "0x182BB78F0")]
	[Conditional("UNITY_EDITOR")]
	public void GANNMEBPHIJ(JCHOAKCKPKK EDANMEFBKLK, EEJFBJIDABN PDLHECKEFMN, in PEABCJAGJAH IGDJJEECDAF, bool JCKKGEJLICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public FGFBHEPDPJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[NDGJMMLBLBO(typeof(FMOIFIJGKDN), new string[] { "Editor" })]
[DAPOABPDMCD(GPPMCHFFAPH.Application)]
public sealed class FMOIFIJGKDN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void HLOEGJGEJGP(JCHOAKCKPKK OMKLELDMIKD, GAKKJFKJMJN PNMIIEJFOON, bool JCKKGEJLICG);

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public delegate void JAFPOBNCJMJ(JCHOAKCKPKK OMKLELDMIKD, bool JCKKGEJLICG);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void NECCCFLPLPA(JCHOAKCKPKK OMKLELDMIKD, EEJFBJIDABN PDLHECKEFMN, in PEABCJAGJAH IGDJJEECDAF, bool JCKKGEJLICG, bool BLIEMLEDDBK);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void FJMCJGDFBGH(JCHOAKCKPKK OMKLELDMIKD, EEJFBJIDABN PDLHECKEFMN, in PEABCJAGJAH EIKDBDKEAPN, in PEABCJAGJAH NDKJFJECHPC);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void BMOMAOMFEML(EAMKGFPIIBN FOJIGKKHICE, ReadOnlyMemory<byte> NEIPJLDAIJA);

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event HLOEGJGEJGP NEPAKLIOODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8430", Offset = "0x2BB7830", VA = "0x182BB8430")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8690", Offset = "0x2BB7A90", VA = "0x182BB8690")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event JAFPOBNCJMJ DICBBLPMAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8870", Offset = "0x2BB7C70", VA = "0x182BB8870")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8250", Offset = "0x2BB7650", VA = "0x182BB8250")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event HLOEGJGEJGP IIHBAJCFFBE
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7FE0", Offset = "0x2BB73E0", VA = "0x182BB7FE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2BB82F0", Offset = "0x2BB76F0", VA = "0x182BB82F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event JAFPOBNCJMJ OACDLAAGPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8730", Offset = "0x2BB7B30", VA = "0x182BB8730")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8080", Offset = "0x2BB7480", VA = "0x182BB8080")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event NECCCFLPLPA HMPIFNDIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8150", Offset = "0x2BB7550", VA = "0x182BB8150")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2BB7F20", Offset = "0x2BB7320", VA = "0x182BB7F20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event FJMCJGDFBGH JEJMHDKFDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8910", Offset = "0x2BB7D10", VA = "0x182BB8910")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2BB84D0", Offset = "0x2BB78D0", VA = "0x182BB84D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<string, object> IJAKPMIFGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8390", Offset = "0x2BB7790", VA = "0x182BB8390")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2BB87D0", Offset = "0x2BB7BD0", VA = "0x182BB87D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event BMOMAOMFEML OFNKGBEOEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2BB89D0", Offset = "0x2BB7DD0", VA = "0x182BB89D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8590", Offset = "0x2BB7990", VA = "0x182BB8590")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8A70", Offset = "0x2BB7E70", VA = "0x182BB8A70")]
	[Conditional("UNITY_EDITOR")]
	public void OLPHBAANBFD(JCHOAKCKPKK OMKLELDMIKD, in GAKKJFKJMJN PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2BB89B0", Offset = "0x2BB7DB0", VA = "0x182BB89B0")]
	[Conditional("UNITY_EDITOR")]
	public void OGHADPDLGOL(JCHOAKCKPKK OMKLELDMIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8660", Offset = "0x2BB7A60", VA = "0x182BB8660")]
	[Conditional("UNITY_EDITOR")]
	public void KFHPKPDCKEF(JCHOAKCKPKK OMKLELDMIKD, in GAKKJFKJMJN PNMIIEJFOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7FC0", Offset = "0x2BB73C0", VA = "0x182BB7FC0")]
	[Conditional("UNITY_EDITOR")]
	public void AGMLPNAIGOK(JCHOAKCKPKK OMKLELDMIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8120", Offset = "0x2BB7520", VA = "0x182BB8120")]
	[Conditional("UNITY_EDITOR")]
	public void BAIENEEMIMA(JCHOAKCKPKK OMKLELDMIKD, EEJFBJIDABN PDLHECKEFMN, in PEABCJAGJAH IGDJJEECDAF, bool BLIEMLEDDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8570", Offset = "0x2BB7970", VA = "0x182BB8570")]
	[Conditional("UNITY_EDITOR")]
	public void IBJHELBPIGB(JCHOAKCKPKK OMKLELDMIKD, EEJFBJIDABN PDLHECKEFMN, in PEABCJAGJAH EIKDBDKEAPN, in PEABCJAGJAH NDKJFJECHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB81F0", Offset = "0x2BB75F0", VA = "0x182BB81F0")]
	[Conditional("UNITY_EDITOR")]
	public void BPANCJIEMNM(string DHKKANIEGMN, object NEIPJLDAIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8630", Offset = "0x2BB7A30", VA = "0x182BB8630")]
	[Conditional("UNITY_EDITOR")]
	public void JDGGFFOEJJE(EAMKGFPIIBN FOJIGKKHICE, ReadOnlyMemory<byte> NEIPJLDAIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public FMOIFIJGKDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[NDGJMMLBLBO(typeof(HMKJJEJKECA), new string[] { })]
public class CIAEBFLNAOJ : HMKJJEJKECA
{
	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2B85580", Offset = "0x2B84980", VA = "0x182B85580", Slot = "5")]
	public void DFNDFEBIINI(object KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2B854A0", Offset = "0x2B848A0", VA = "0x182B854A0", Slot = "6")]
	public void CFBMCCCKNIM(object KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2B853C0", Offset = "0x2B847C0", VA = "0x182B853C0", Slot = "7")]
	public void BILEACJFIBF(object KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2B85660", Offset = "0x2B84A60", VA = "0x182B85660", Slot = "4")]
	public IDisposable EBOEKGPABAG(object KAKCNEMJMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public CIAEBFLNAOJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[NDGJMMLBLBO(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	[JLJFNDDLCBO(CBGNDNDJKHL.Serialization)]
	internal class BulkInstantiateSceneObjectService : LNLPIGELLPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public const string EJKNFFAPABI = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[HIGIANBBMBE]
		private LLOINIJEHPN GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIJOKICGGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[HIGIANBBMBE]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[HIGIANBBMBE]
		private KAPLNDGMNPC EDICDNMPJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private EntityQuery IPABECLOLFJ;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private EntityManager HDMAFEMIPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x2B818C0", Offset = "0x2B80CC0", VA = "0x182B818C0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2B82BD0", Offset = "0x2B81FD0", VA = "0x182B82BD0", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2B81730", Offset = "0x2B80B30", VA = "0x182B81730", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x2B81740", Offset = "0x2B80B40", VA = "0x182B81740")]
		public bool GMAHJCHKGPF(IEnumerable<FANAPLKCHPF> POHCOMDELPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2B81C90", Offset = "0x2B81090", VA = "0x182B81C90")]
		public static bool MFJAGNAAFKM(FANAPLKCHPF EMCPHLBMEHO, out JCHOAKCKPKK OMKLELDMIKD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2B81910", Offset = "0x2B80D10", VA = "0x182B81910")]
		private void KNCNEICGHHG(Dictionary<JCHOAKCKPKK, FANAPLKCHPF> LJGGGAEIPBP, IEnumerable<FANAPLKCHPF> POHCOMDELPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2B82100", Offset = "0x2B81500", VA = "0x182B82100")]
		private void NJBGENJOILF(Dictionary<JCHOAKCKPKK, FANAPLKCHPF> LJGGGAEIPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2B80E10", Offset = "0x2B80210", VA = "0x182B80E10")]
		private void ANNCICNBCDN(Dictionary<JCHOAKCKPKK, FANAPLKCHPF> LJGGGAEIPBP, JCHOAKCKPKK OMKLELDMIKD, string DHKKANIEGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2B81DA0", Offset = "0x2B811A0", VA = "0x182B81DA0")]
		private void MFOKLPAAFDP(Dictionary<JCHOAKCKPKK, FANAPLKCHPF> LJGGGAEIPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2B82330", Offset = "0x2B81730", VA = "0x182B82330")]
		private void PANBBOHBNJF(Dictionary<JCHOAKCKPKK, FANAPLKCHPF> LJGGGAEIPBP, List<FANAPLKCHPF> DFIPJAHLEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2B814C0", Offset = "0x2B808C0", VA = "0x182B814C0")]
		private NativeList<JCHOAKCKPKK> DEHGLOCDNHC(Dictionary<JCHOAKCKPKK, FANAPLKCHPF> LJGGGAEIPBP)
		{
			return default(NativeList<JCHOAKCKPKK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2B812F0", Offset = "0x2B806F0", VA = "0x182B812F0")]
		private NativeArray<Entity> CHKNCPPDHOB(NativeList<JCHOAKCKPKK> GNCOCNHKJPD)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2B81690", Offset = "0x2B80A90", VA = "0x182B81690")]
		private static void DLKMEGHOAJH(Dictionary<JCHOAKCKPKK, FANAPLKCHPF> LJGGGAEIPBP, JCHOAKCKPKK OMKLELDMIKD, FANAPLKCHPF EMCPHLBMEHO, string DHKKANIEGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[DAPOABPDMCD(GPPMCHFFAPH.Application)]
	[JLJFNDDLCBO(CBGNDNDJKHL.Serialization)]
	[NDGJMMLBLBO(typeof(DebugWorldsService), new string[] { })]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		internal static bool DGHOOJGKDDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x2B93590", Offset = "0x2B92990", VA = "0x182B93590")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2B93550", Offset = "0x2B92950", VA = "0x182B93550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		internal static bool OFOGJBMLPAP
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x2B935D0", Offset = "0x2B929D0", VA = "0x182B935D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x2B93510", Offset = "0x2B92910", VA = "0x182B93510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public void COFEOLNJJOH(string DHKKANIEGMN, EntityManager GKHNMAAJNKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public static void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[NDGJMMLBLBO(typeof(MANDPKBPCIG), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.Application)]
internal class MANDPKBPCIG
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool DGHOOJGKDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x67C250", Offset = "0x67B650", VA = "0x18067C250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x67C270", Offset = "0x67B670", VA = "0x18067C270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool DKGGDBJCLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x777570", Offset = "0x776970", VA = "0x180777570")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x777580", Offset = "0x776980", VA = "0x180777580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MANDPKBPCIG()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[JJCBNHCEDIO(typeof(SerializationService))]
	[NDGJMMLBLBO(typeof(ACFOFFHKLLK), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.Serialization)]
	internal class SerializationService : ACFOFFHKLLK, IDisposable, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly DLHDGHMPCLG EDDAPCEJNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[HIGIANBBMBE]
		private LLOINIJEHPN GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[HIGIANBBMBE]
		private MINGLGEBPNG BMEDMCDHJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[HIGIANBBMBE]
		private MANDPKBPCIG LCELIFFKEIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private CGEKNJCHDAC HLACALCAIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private BPOMAKJFFCG PAHAHEJCJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private SerializationRemapScope CIKJMIFHOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool? HPIHMBDNFCP;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool DEPOLIOIPMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x2CA6790", Offset = "0x2CA5B90", VA = "0x182CA6790", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x2CA7140", Offset = "0x2CA6540", VA = "0x182CA7140", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool OLFAEAEELKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x71BCE0", Offset = "0x71B0E0", VA = "0x18071BCE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x71C490", Offset = "0x71B890", VA = "0x18071C490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public BPOMAKJFFCG BPBBMEAIPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7220", Offset = "0x2CA6620", VA = "0x182CA7220", Slot = "16")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA58A0", Offset = "0x2CA4CA0", VA = "0x182CA58A0", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6800", Offset = "0x2CA5C00", VA = "0x182CA6800")]
		public static bool LOMLFGFIIGC(ByteString BIPDDAIIHHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6BA1C0", Offset = "0x6B95C0", VA = "0x1806BA1C0")]
		public void DDALFGHKOOG(CGEKNJCHDAC NLFKHOCCBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7150", Offset = "0x2CA6550", VA = "0x182CA7150", Slot = "5")]
		public void PDGIKDCKPPB(bool NCFLAPIBDMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA58B0", Offset = "0x2CA4CB0", VA = "0x182CA58B0", Slot = "6")]
		public Task ENMEPFFBGHE(bool NCFLAPIBDMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5940", Offset = "0x2CA4D40", VA = "0x182CA5940", Slot = "7")]
		public ByteString FBLBIDAIACI(out IDisposable CIKJMIFHOLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5A20", Offset = "0x2CA4E20", VA = "0x182CA5A20", Slot = "19")]
		public ByteString FBLBIDAIACI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x2CA67A0", Offset = "0x2CA5BA0", VA = "0x182CA67A0", Slot = "9")]
		public bool LOHKEOMODAB(ByteString EAOENJOELBD, ENEDIEMKKIM AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6DF0", Offset = "0x2CA61F0", VA = "0x182CA6DF0")]
		private bool NPIPNIEAION(ByteString EAOENJOELBD, ENEDIEMKKIM AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x2CA55E0", Offset = "0x2CA49E0", VA = "0x182CA55E0", Slot = "8")]
		public void CCCILJGEJNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x2CA60A0", Offset = "0x2CA54A0", VA = "0x182CA60A0", Slot = "10")]
		public bool GPCJEHOLBIA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5E30", Offset = "0x2CA5230", VA = "0x182CA5E30", Slot = "11")]
		public bool GMAHJCHKGPF(IEnumerable<FANAPLKCHPF> HEBJGGPOLHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA65A0", Offset = "0x2CA59A0", VA = "0x182CA65A0")]
		public bool HPEAOJMGOMF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5C00", Offset = "0x2CA5000", VA = "0x182CA5C00", Slot = "12")]
		public bool GBPFFDAANPA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6310", Offset = "0x2CA5710", VA = "0x182CA6310")]
		public void HAOLMIHAFCP(BPOMAKJFFCG.LLGLKFAAIIF.BDIDBINABDO IJBJEBDOLMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6B60", Offset = "0x2CA5F60", VA = "0x182CA6B60")]
		private bool NMBMEPMJGJF(ByteString EAOENJOELBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2CA57B0", Offset = "0x2CA4BB0", VA = "0x182CA57B0")]
		private void CDFCLMODFCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6B00", Offset = "0x2CA5F00", VA = "0x182CA6B00")]
		private ByteString NJGNJFFGACM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6680", Offset = "0x2CA5A80", VA = "0x182CA6680")]
		private ByteString LGIFJNEANML(ByteString BIPDDAIIHHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5800", Offset = "0x2CA4C00", VA = "0x182CA5800")]
		private BPOMAKJFFCG.LLGLKFAAIIF.BDIDBINABDO CDLFKJFHMLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7110", Offset = "0x2CA6510", VA = "0x182CA7110")]
		private void OLEFPCFGGPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2CA6930", Offset = "0x2CA5D30", VA = "0x182CA6930", Slot = "13")]
		public bool NGABEEMPMEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5360", Offset = "0x2CA4760", VA = "0x182CA5360", Slot = "14")]
		public void AHONLGEAIPA(bool NKAIKNCAGJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2CA5410", Offset = "0x2CA4810", VA = "0x182CA5410")]
		private void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[NDGJMMLBLBO(typeof(AMNPCKPOIGI), new string[] { })]
[JJCBNHCEDIO(typeof(MINGLGEBPNG))]
internal class MINGLGEBPNG : AMNPCKPOIGI
{
	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action APNEDGGEGMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x29D6610", Offset = "0x29D5A10", VA = "0x1829D6610", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x29D67F0", Offset = "0x29D5BF0", VA = "0x1829D67F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JDNEAEGGDIG> JDOJDFNEDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x29D6430", Offset = "0x29D5830", VA = "0x1829D6430", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x29D6200", Offset = "0x29D5600", VA = "0x1829D6200", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action ABEKJMCLCML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x29D66B0", Offset = "0x29D5AB0", VA = "0x1829D66B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x29D6340", Offset = "0x29D5740", VA = "0x1829D6340", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action KLNBOOFJKIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x29D64D0", Offset = "0x29D58D0", VA = "0x1829D64D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x29D6750", Offset = "0x29D5B50", VA = "0x1829D6750", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<JDNEAEGGDIG> NLDAAMIOKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x29D62A0", Offset = "0x29D56A0", VA = "0x1829D62A0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x29D6570", Offset = "0x29D5970", VA = "0x1829D6570", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x100B810", Offset = "0x100AC10", VA = "0x18100B810")]
	public void CCCILJGEJNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1150870", Offset = "0x114FC70", VA = "0x181150870")]
	public void MBOBNCFNMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1150740", Offset = "0x114FB40", VA = "0x181150740")]
	public void HMNANHAKBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x29D6890", Offset = "0x29D5C90", VA = "0x1829D6890")]
	public void PLFAODJLJDJ(JDNEAEGGDIG AILDDPCONMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x29D63E0", Offset = "0x29D57E0", VA = "0x1829D63E0")]
	public void DHGKLGHHEKH(JDNEAEGGDIG AILDDPCONMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MINGLGEBPNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[NDGJMMLBLBO(typeof(GONOMBLLIBK), new string[] { })]
public class CDOFEOFOCCE : GONOMBLLIBK, GGFJAKOLADN, MCPGEGOMHPG, LNLPIGELLPM, ENMEIFNEMLK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EntityHierarchyParents INBNACIKDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private AMHOHILPKGK MOHHDKEKALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private ObjectEmbodimentService EDKNHLFIHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public global::ODBJEBNEDIM<MOLBNKBNJLI> AEPDHOKLCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x67F580", Offset = "0x67E980", VA = "0x18067F580", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x67F5A0", Offset = "0x67E9A0", VA = "0x18067F5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private EntityManager HDMAFEMIPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2B83E60", Offset = "0x2B83260", VA = "0x182B83E60")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x16FAC40", Offset = "0x16FA040", VA = "0x1816FAC40", Slot = "14")]
	public void FFHOKNLNLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2B846B0", Offset = "0x2B83AB0", VA = "0x182B846B0", Slot = "15")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2B83290", Offset = "0x2B82690", VA = "0x182B83290", Slot = "16")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x82D9E0", Offset = "0x82CDE0", VA = "0x18082D9E0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x29DFD90", Offset = "0x29DF190", VA = "0x1829DFD90")]
	private MOLBNKBNJLI GNFFPLECGCG(Entity NOADJCMIKEF)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2B83600", Offset = "0x2B82A00", VA = "0x182B83600", Slot = "4")]
	public MOLBNKBNJLI FDDELAHPCJN(MOLBNKBNJLI AFGGEMMDNNF)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2B838E0", Offset = "0x2B82CE0", VA = "0x182B838E0", Slot = "19")]
	public void GNINBKHAPJE(ref List<MOLBNKBNJLI> BKAJFMOPMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2B84110", Offset = "0x2B83510", VA = "0x182B84110", Slot = "20")]
	public IEnumerable<MOLBNKBNJLI> MCPDDLPGDOL(MOLBNKBNJLI AFGGEMMDNNF, bool MHPOMONJNNI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2B84310", Offset = "0x2B83710", VA = "0x182B84310", Slot = "21")]
	public MOLBNKBNJLI MIMLOFNJLBE(MOLBNKBNJLI AFGGEMMDNNF, int HMJKJGLHFKE)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2B83EB0", Offset = "0x2B832B0", VA = "0x182B83EB0", Slot = "22")]
	public int KNLPFCMNAAK(MOLBNKBNJLI AFGGEMMDNNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2B83C20", Offset = "0x2B83020", VA = "0x182B83C20", Slot = "8")]
	public int ILMDLNCPDGK(MOLBNKBNJLI AFGGEMMDNNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2B83450", Offset = "0x2B82850", VA = "0x182B83450", Slot = "9")]
	public PMKCJIGDPOI DAELJCGMBHP(MOLBNKBNJLI AFGGEMMDNNF)
	{
		return default(PMKCJIGDPOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x2B844E0", Offset = "0x2B838E0", VA = "0x182B844E0", Slot = "23")]
	public bool NGCNBKNOKNM(MOLBNKBNJLI AFGGEMMDNNF, out PMKCJIGDPOI JBIJDGMGECB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x2B836F0", Offset = "0x2B82AF0", VA = "0x182B836F0", Slot = "24")]
	public IEnumerable<MOLBNKBNJLI> FGNCMEHEPDA(MOLBNKBNJLI AFGGEMMDNNF, bool MHPOMONJNNI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2B83380", Offset = "0x2B82780", VA = "0x182B83380", Slot = "12")]
	public MOLBNKBNJLI COKNPOLCDDK(MOLBNKBNJLI LMKFELFNIAK, MOLBNKBNJLI MHLBIJCJLAF)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2B831C0", Offset = "0x2B825C0", VA = "0x182B831C0", Slot = "13")]
	public bool CIAEECBOFKJ(MOLBNKBNJLI LMKFELFNIAK, MOLBNKBNJLI MHLBIJCJLAF, out MOLBNKBNJLI CIAGICGLOHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B83DC0", Offset = "0x2B831C0", VA = "0x182B83DC0", Slot = "5")]
	public MOLBNKBNJLI IONCGDONMPM(MOLBNKBNJLI AFGGEMMDNNF)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2B83540", Offset = "0x2B82940", VA = "0x182B83540", Slot = "11")]
	public bool DJJKFGBLEGJ(MOLBNKBNJLI AFGGEMMDNNF, MOLBNKBNJLI BFMALIMGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2B83FD0", Offset = "0x2B833D0", VA = "0x182B83FD0", Slot = "25")]
	public bool LLKINPIFLGK(MOLBNKBNJLI AFGGEMMDNNF, MOLBNKBNJLI JKAAFIAPPME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2B83B10", Offset = "0x2B82F10", VA = "0x182B83B10", Slot = "10")]
	public bool HAFGFLCKEOI(MOLBNKBNJLI AFGGEMMDNNF, MOLBNKBNJLI LMKFELFNIAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B83830", Offset = "0x2B82C30", VA = "0x182B83830", Slot = "6")]
	public bool GHJLFEJPDIG(MOLBNKBNJLI AFGGEMMDNNF, MOLBNKBNJLI JFCNGAACNEO, bool OIHCFIOFIIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B837C0", Offset = "0x2B82BC0", VA = "0x182B837C0", Slot = "7")]
	public bool FJLPJNBNCOH(MOLBNKBNJLI AFGGEMMDNNF, MOLBNKBNJLI JFCNGAACNEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public CDOFEOFOCCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
[NDGJMMLBLBO(typeof(ODOEMDIJMKD), new string[] { })]
internal class ODOEMDIJMKD : LNLPIGELLPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[HIGIANBBMBE]
	private FFMELNGKBPP OEKBACMEEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Dictionary<int, HBJNCCNFNHC> GELNMJGDEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x29DA660", Offset = "0x29D9A60", VA = "0x1829DA660", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x29DA510", Offset = "0x29D9910", VA = "0x1829DA510", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x29DA090", Offset = "0x29D9490", VA = "0x1829DA090")]
	public HBJNCCNFNHC AMPCEEPLIPM(PCCBFFGCINK JLNILGJAKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x29DA2A0", Offset = "0x29D96A0", VA = "0x1829DA2A0")]
	public HBJNCCNFNHC AMPCEEPLIPM(EEJFBJIDABN FCLBEIEGADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x29DA3F0", Offset = "0x29D97F0", VA = "0x1829DA3F0")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x29DA6B0", Offset = "0x29D9AB0", VA = "0x1829DA6B0")]
	public ODOEMDIJMKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public sealed class HBJNCCNFNHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeList<HFLBLBGKEBE> FBGFJJPIJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeList<IEBEIBNAHNC> DDCFNPABLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeList<AMKCICGGHCJ> PCFEOICMJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private NativeList<IEBEIBNAHNC> OFAHLEPDIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NativeList<HFLBLBGKEBE> JGCMJIIBBCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xD85780", Offset = "0xD84B80", VA = "0x180D85780")]
		get
		{
			return default(NativeList<HFLBLBGKEBE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NativeList<IEBEIBNAHNC> JMBLBMBKEPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B40", Offset = "0xCB0F40", VA = "0x180CB1B40")]
		get
		{
			return default(NativeList<IEBEIBNAHNC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NativeList<AMKCICGGHCJ> LBBDHFHMAMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x100D100", Offset = "0x100C500", VA = "0x18100D100")]
		get
		{
			return default(NativeList<AMKCICGGHCJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<IEBEIBNAHNC> LNGENJPGBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1030610", Offset = "0x102FA10", VA = "0x181030610")]
		get
		{
			return default(NativeList<IEBEIBNAHNC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JobHandle IKHIFKJBDFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x100D080", Offset = "0x100C480", VA = "0x18100D080")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x100D090", Offset = "0x100C490", VA = "0x18100D090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool NMHLJFGMGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F8B40", Offset = "0x9F7F40", VA = "0x1809F8B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool GLFKMGPGAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BBCD20", Offset = "0x2BBC120", VA = "0x182BBCD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCF00", Offset = "0x2BBC300", VA = "0x182BBCF00")]
	public HBJNCCNFNHC(Allocator JLPBABJNDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCC90", Offset = "0x2BBC090", VA = "0x182BBCC90")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCDD0", Offset = "0x2BBC1D0", VA = "0x182BBCDD0")]
	public void NPNFNKBABCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC990", Offset = "0x2BBBD90", VA = "0x182BBC990")]
	public void AKBMAMDKLNI(Entity NOADJCMIKEF, Entity OOHIPCPJDEM, Entity CNMJLCOJOLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[NDGJMMLBLBO(typeof(LPHIIALAGPL), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
public class LPHIIALAGPL : LNLPIGELLPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[HIGIANBBMBE]
	private SceneService MEAJMIEKOFI;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFD80", Offset = "0x2BCF180", VA = "0x182BCFD80", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2BCFD60", Offset = "0x2BCF160", VA = "0x182BCFD60", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public LPHIIALAGPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal abstract class APGEGEDICMC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private uint DJEJMGHMGBF;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public abstract uint OHFOOOODHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9E65F0", Offset = "0x9E59F0", VA = "0x1809E65F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DEF0", Offset = "0x2B7D2F0", VA = "0x182B7DEF0")]
	public JCHOAKCKPKK KFDAFDCHKPF()
	{
		return default(JCHOAKCKPKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DF40", Offset = "0x2B7D340", VA = "0x182B7DF40")]
	public void NPFEMILNBKN(JCHOAKCKPKK OMKLELDMIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x13A2060", Offset = "0x13A1460", VA = "0x1813A2060", Slot = "6")]
	public virtual void DKMEPNBBIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	protected APGEGEDICMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
[NDGJMMLBLBO(typeof(DMFFLNPOJOF), new string[] { })]
internal sealed class DMFFLNPOJOF : APGEGEDICMC, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	[HIGIANBBMBE]
	private LLOINIJEHPN GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private uint DLDPNOCIKPH;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override uint OHFOOOODHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x678010", Offset = "0x677410", VA = "0x180678010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2B91890", Offset = "0x2B90C90", VA = "0x182B91890", Slot = "7")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2B91840", Offset = "0x2B90C40", VA = "0x182B91840")]
	private void NDPJACFPJDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2B917E0", Offset = "0x2B90BE0", VA = "0x182B917E0", Slot = "6")]
	public override void DKMEPNBBIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public DMFFLNPOJOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[NDGJMMLBLBO(typeof(AHOBANHALBL), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
internal sealed class AHOBANHALBL : APGEGEDICMC
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override uint OHFOOOODHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public AHOBANHALBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
[NDGJMMLBLBO(typeof(HNMINHINCFB), new string[] { })]
internal sealed class HNMINHINCFB : GGFJAKOLADN, MCPGEGOMHPG, LNLPIGELLPM, ENMEIFNEMLK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[HIGIANBBMBE]
	private NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private EntityQuery BJEJBFBIBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private EntityQuery MAAOCEGEAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private EntityQuery AMDFMJCNHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private EntityQuery MJPKMMHEJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private EntityQuery CPIGLEHMGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private EntityQuery BCBDKLEKKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private EntityManager HDMAFEMIPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1080", Offset = "0x2BC0480", VA = "0x182BC1080")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public EntityQuery BBMLPIDMCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x699040", Offset = "0x698440", VA = "0x180699040")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EntityQuery CBBHIPDFAEF
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x699030", Offset = "0x698430", VA = "0x180699030")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery JCEDDPFLIGO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x11FA460", Offset = "0x11F9860", VA = "0x1811FA460")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery HMPPFCFMGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x100D080", Offset = "0x100C480", VA = "0x18100D080")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery JNLJEBKIOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x170F7E0", Offset = "0x170EBE0", VA = "0x18170F7E0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery JLBBEBKNCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1000", Offset = "0x2BC0400", VA = "0x182BC1000")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int EBIBGKBFBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0FE0", Offset = "0x2BC03E0", VA = "0x182BC0FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int NBKJKEKJIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0F40", Offset = "0x2BC0340", VA = "0x182BC0F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int NJLGMHHLLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0FC0", Offset = "0x2BC03C0", VA = "0x182BC0FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int HNENEFPMEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1250", Offset = "0x2BC0650", VA = "0x182BC1250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int NGLFBCGNMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0F20", Offset = "0x2BC0320", VA = "0x182BC0F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int DKFFGOHBKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2BC10D0", Offset = "0x2BC04D0", VA = "0x182BC10D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
	public void FFHOKNLNLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1270", Offset = "0x2BC0670", VA = "0x182BC1270", Slot = "5")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0A80", Offset = "0x2BBFE80", VA = "0x182BC0A80", Slot = "6")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0A20", Offset = "0x2BBFE20", VA = "0x182BC0A20")]
	private EntityQueryDesc BHEBMAHAEKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0F60", Offset = "0x2BC0360", VA = "0x182BC0F60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2BC11A0", Offset = "0x2BC05A0", VA = "0x182BC11A0")]
	public HKAODOKOPPA NOCAFGOMHOE(MOLBNKBNJLI OACDBCDEFBJ)
	{
		return default(HKAODOKOPPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC10F0", Offset = "0x2BC04F0", VA = "0x182BC10F0")]
	public HKAODOKOPPA NOCAFGOMHOE(Entity NOADJCMIKEF)
	{
		return default(HKAODOKOPPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0970", Offset = "0x2BBFD70", VA = "0x182BC0970")]
	public APCEPJKMKDM AAAJLOIGMEP(Entity NOADJCMIKEF)
	{
		return default(APCEPJKMKDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2BC12C0", Offset = "0x2BC06C0", VA = "0x182BC12C0")]
	public HNMINHINCFB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[JLJFNDDLCBO(CBGNDNDJKHL.All)]
	[NDGJMMLBLBO(typeof(FOKCOLGHCMD), new string[] { })]
	public class ObjectService : LNLPIGELLPM, FOKCOLGHCMD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly DLHDGHMPCLG GPMDACCCHIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[HIGIANBBMBE]
		private APFPCLEOLKC FCGMOLCPBPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[HIGIANBBMBE]
		private LLOINIJEHPN GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[HIGIANBBMBE]
		private ObjectLifecycleService MLGFPIININH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[HIGIANBBMBE]
		private ObjectEmbodimentService EDKNHLFIHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[HIGIANBBMBE]
		private ObjectInstantiationService EINHMHCOFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[HIGIANBBMBE]
		private HNMINHINCFB MOHHDKEKALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private ObjectNetworkToLocalMapService DDKCFDAIGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool HIBODKPCONP;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public APFPCLEOLKC BDCPKBMPNNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int EBIBGKBFBNG
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x29E82A0", Offset = "0x29E76A0", VA = "0x1829E82A0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int NBKJKEKJIDA
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x29E7E70", Offset = "0x29E7270", VA = "0x1829E7E70", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public int NJLGMHHLLCG
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x29E8060", Offset = "0x29E7460", VA = "0x1829E8060", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int HNENEFPMEAM
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x29E8F40", Offset = "0x29E8340", VA = "0x1829E8F40", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int NGLFBCGNMPN
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x29E7C30", Offset = "0x29E7030", VA = "0x1829E7C30", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int DKFFGOHBKID
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x29E8A20", Offset = "0x29E7E20", VA = "0x1829E8A20", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<MOLBNKBNJLI, APCEPJKMKDM> BFPDEFGKMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x29E85F0", Offset = "0x29E79F0", VA = "0x1829E85F0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x29E8740", Offset = "0x29E7B40", VA = "0x1829E8740", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<MOLBNKBNJLI> MOFKGLLDAAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x29E7790", Offset = "0x29E6B90", VA = "0x1829E7790", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x29E8EA0", Offset = "0x29E82A0", VA = "0x1829E8EA0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x29E90F0", Offset = "0x29E84F0", VA = "0x1829E90F0", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x29E7E90", Offset = "0x29E7290", VA = "0x1829E7E90", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x29E74F0", Offset = "0x29E68F0", VA = "0x1829E74F0")]
		private void AFLAPMCEOBM(Entity NOADJCMIKEF, APCEPJKMKDM BKEDDPMCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x29E8690", Offset = "0x29E7A90", VA = "0x1829E8690")]
		private void JGLGCLNINNA(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x29E82C0", Offset = "0x29E76C0", VA = "0x1829E82C0")]
		internal MOLBNKBNJLI GNFFPLECGCG(Entity NOADJCMIKEF)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x29E7950", Offset = "0x29E6D50", VA = "0x1829E7950", Slot = "41")]
		public PMKCJIGDPOI BOBBPCNOKFI()
		{
			return default(PMKCJIGDPOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x29E8FC0", Offset = "0x29E83C0", VA = "0x1829E8FC0", Slot = "42")]
		public PMKCJIGDPOI OOJENLHDKGF()
		{
			return default(PMKCJIGDPOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x29E8E00", Offset = "0x29E8200", VA = "0x1829E8E00", Slot = "43")]
		public PMKCJIGDPOI OAMDLLHEEKB()
		{
			return default(PMKCJIGDPOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x29E8D20", Offset = "0x29E8120", VA = "0x1829E8D20", Slot = "10")]
		public HKAODOKOPPA NOCAFGOMHOE(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(HKAODOKOPPA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x29E7470", Offset = "0x29E6870", VA = "0x1829E7470", Slot = "11")]
		public APCEPJKMKDM AAAJLOIGMEP(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(APCEPJKMKDM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x29E8BF0", Offset = "0x29E7FF0", VA = "0x1829E8BF0")]
		private PMKCJIGDPOI MEGBFHLGION(EntityQuery JHDPAHIHIEJ)
		{
			return default(PMKCJIGDPOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x29E84A0", Offset = "0x29E78A0", VA = "0x1829E84A0", Slot = "33")]
		public bool HGNKBEMEDCJ(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x29E8DB0", Offset = "0x29E81B0", VA = "0x1829E8DB0", Slot = "29")]
		public void NPMFLDOJCPB(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x29E8D50", Offset = "0x29E8150", VA = "0x1829E8D50", Slot = "30")]
		public void NODIFKMPMND(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x29E7D30", Offset = "0x29E7130", VA = "0x1829E7D30", Slot = "31")]
		public void COKPKCAAOBJ(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x29E88B0", Offset = "0x29E7CB0", VA = "0x1829E88B0", Slot = "22")]
		public MJBBCNDEMML LENFEBGDMNK(APCEPJKMKDM BKEDDPMCLJC, bool NJFCIICKMND)
		{
			return default(MJBBCNDEMML);
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x29E8970", Offset = "0x29E7D70", VA = "0x1829E8970", Slot = "23")]
		public MJBBCNDEMML LENFEBGDMNK(APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(MJBBCNDEMML);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x29E8820", Offset = "0x29E7C20", VA = "0x1829E8820", Slot = "24")]
		public MJBBCNDEMML KLAMPCOOJFE(APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(MJBBCNDEMML);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x29E79F0", Offset = "0x29E6DF0", VA = "0x1829E79F0", Slot = "25")]
		public MJBBCNDEMML BPFKIPKCGPJ(JCHOAKCKPKK OMKLELDMIKD, APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(MJBBCNDEMML);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x29E8080", Offset = "0x29E7480", VA = "0x1829E8080", Slot = "44")]
		public MJBBCNDEMML FIFPMNAOPHN(int EDLLKFCDPBE, APCEPJKMKDM BKEDDPMCLJC, GameObject FLFBOHHHJJB)
		{
			return default(MJBBCNDEMML);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x29E8530", Offset = "0x29E7930", VA = "0x1829E8530", Slot = "26")]
		public GIHAGJBGBCN IHKKGFJJNLO()
		{
			return default(GIHAGJBGBCN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x29E7830", Offset = "0x29E6C30", VA = "0x1829E7830", Slot = "45")]
		public CLBKMJBBPPC BNDENKEHBHE(HJJKLCIJMGP FPPBLNEEHBP)
		{
			return default(CLBKMJBBPPC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x29E7C50", Offset = "0x29E7050", VA = "0x1829E7C50", Slot = "27")]
		public MIKKFDHAOOE COAICNDGEKM()
		{
			return default(MIKKFDHAOOE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x29E80F0", Offset = "0x29E74F0", VA = "0x1829E80F0", Slot = "28")]
		public HJGAOGOELKD FNKFHLANIFP(EOLBHDKIGHE FPPBLNEEHBP)
		{
			return default(HJGAOGOELKD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x29E8720", Offset = "0x29E7B20", VA = "0x1829E8720", Slot = "12")]
		public void JGOJGDHNHPP(JCHOAKCKPKK OMKLELDMIKD, GHHFOHNOLPM JMOOMLNHCFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x29E7590", Offset = "0x29E6990", VA = "0x1829E7590", Slot = "13")]
		public MJBBCNDEMML BHBJPCCLNNB(MOLBNKBNJLI AFGGEMMDNNF, [Optional] object MJNGPHMPILM)
		{
			return default(MJBBCNDEMML);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x29E7DD0", Offset = "0x29E71D0", VA = "0x1829E7DD0", Slot = "14")]
		public bool DAEHJILGNJN(MOLBNKBNJLI AFGGEMMDNNF, out GHHFOHNOLPM MHKNFNJAIIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x29E7740", Offset = "0x29E6B40", VA = "0x1829E7740", Slot = "46")]
		public Transform BJLODAMNIKM(MOLBNKBNJLI AFGGEMMDNNF, [Optional] object MJNGPHMPILM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x29E8010", Offset = "0x29E7410", VA = "0x1829E8010", Slot = "16")]
		public bool EDJHDGCFPJM(MOLBNKBNJLI AFGGEMMDNNF, out Transform KFAGMEKKLDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x29E83F0", Offset = "0x29E77F0", VA = "0x1829E83F0", Slot = "17")]
		public bool HCOIBJLOEOM(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x29E8440", Offset = "0x29E7840", VA = "0x1829E8440")]
		public bool HDHBMMGDIBB(GHHFOHNOLPM IGDJJEECDAF, [Optional] object MJNGPHMPILM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x29E8470", Offset = "0x29E7870", VA = "0x1829E8470", Slot = "47")]
		public bool HDHBMMGDIBB(MOLBNKBNJLI AFGGEMMDNNF, [Optional] object MJNGPHMPILM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x29E82E0", Offset = "0x29E76E0", VA = "0x1829E82E0", Slot = "48")]
		public void HAEIFCIEMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x29E8A40", Offset = "0x29E7E40", VA = "0x1829E8A40", Slot = "15")]
		public void LMCHFFKCFDP(GHHFOHNOLPM JLBINKLPHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x29E74B0", Offset = "0x29E68B0", VA = "0x1829E74B0", Slot = "49")]
		public void AAALBIOELEL(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x29E8CA0", Offset = "0x29E80A0", VA = "0x1829E8CA0", Slot = "18")]
		public bool NEPPNDEPOAB(Entity NOADJCMIKEF, object MJNGPHMPILM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x29E9070", Offset = "0x29E8470", VA = "0x1829E9070", Slot = "19")]
		public bool OPINFFIBJNO(Entity NOADJCMIKEF, object MJNGPHMPILM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x29E8230", Offset = "0x29E7630", VA = "0x1829E8230", Slot = "50")]
		public bool GDFLCCOAAAL(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x29E7BC0", Offset = "0x29E6FC0", VA = "0x1829E7BC0", Slot = "51")]
		public bool CCCEGLIHGFK(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x29E8F60", Offset = "0x29E8360", VA = "0x1829E8F60", Slot = "32")]
		public NativeArray<(MOLBNKBNJLI, MOLBNKBNJLI)> OMPDCCJCDBC(NativeArray<MOLBNKBNJLI> NBALOLEMJAH, Allocator JLPBABJNDBH)
		{
			return default(NativeArray<(MOLBNKBNJLI, MOLBNKBNJLI)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x29E9360", Offset = "0x29E8760", VA = "0x1829E9360", Slot = "21")]
		public JCHOAKCKPKK POJPFCFFABO(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(JCHOAKCKPKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x29E8300", Offset = "0x29E7700", VA = "0x1829E8300", Slot = "20")]
		public MOLBNKBNJLI HCFMGPPNBIF(JCHOAKCKPKK OMKLELDMIKD)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x29E87E0", Offset = "0x29E7BE0", VA = "0x1829E87E0")]
		private void KEDFEDBMAPI(APCEPJKMKDM BKEDDPMCLJC, MOLBNKBNJLI AFGGEMMDNNF, JCHOAKCKPKK OMKLELDMIKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NDGJMMLBLBO(typeof(DNCKDPFKPCD), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
internal sealed class DNCKDPFKPCD : LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private ObjectInstantiationService EINHMHCOFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[HIGIANBBMBE]
	private HNMINHINCFB MOHHDKEKALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[HIGIANBBMBE]
	private NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2B92990", Offset = "0x2B91D90", VA = "0x182B92990", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2B92890", Offset = "0x2B91C90", VA = "0x182B92890")]
	public NativeArray<(MOLBNKBNJLI, MOLBNKBNJLI)> OMPDCCJCDBC(NativeArray<MOLBNKBNJLI> NBALOLEMJAH, Allocator JLPBABJNDBH)
	{
		return default(NativeArray<(MOLBNKBNJLI, MOLBNKBNJLI)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2B91DB0", Offset = "0x2B911B0", VA = "0x182B91DB0")]
	private void DCPIAFFGIFF(NativeMultiHashMap<int, (MOLBNKBNJLI src, MOLBNKBNJLI dst)> GLOBPACFEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2B91F90", Offset = "0x2B91390", VA = "0x182B91F90")]
	private void HGPHCDDGBIE(NativeMultiHashMap<int, (MOLBNKBNJLI src, MOLBNKBNJLI dst)> GLOBPACFEML, int BKEDDPMCLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2B92700", Offset = "0x2B91B00", VA = "0x182B92700")]
	private void OECLCFLMEAP(NativeMultiHashMap<int, (MOLBNKBNJLI src, MOLBNKBNJLI dst)> GLOBPACFEML, int BKEDDPMCLJC, GAPCPBFJDMJ OEKBACMEEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2B92420", Offset = "0x2B91820", VA = "0x182B92420")]
	private NativeMultiHashMap<int, (MOLBNKBNJLI, MOLBNKBNJLI)> NGNJPCODEPB(Allocator JLPBABJNDBH, NativeArray<MOLBNKBNJLI> NBALOLEMJAH, out NativeArray<(MOLBNKBNJLI src, MOLBNKBNJLI dst)> LPICNGFDLGC)
	{
		return default(NativeMultiHashMap<int, (MOLBNKBNJLI, MOLBNKBNJLI)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public DNCKDPFKPCD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[JJCBNHCEDIO(typeof(TransformService))]
	[NDGJMMLBLBO(typeof(KAPLNDGMNPC), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.TransformSyncing)]
	public class TransformService : KAPLNDGMNPC, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly DLHDGHMPCLG LCPKKNJELKA;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly DLHDGHMPCLG FGEBBFPAGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private LLOINIJEHPN GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private ILADOCJIBPM EKPOPNOIBMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private NHLELLEJLGC KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private GONOMBLLIBK MIKBKPPJJCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TransformOwnershipPhase DPIHBEEFFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ObjectEmbodimentService LIBFGCDLBNG;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private EntityManager HDMAFEMIPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2CAFC90", Offset = "0x2CAF090", VA = "0x182CAFC90")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private GDHFGEGLFMK GBPJMMGCLOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x2CADBC0", Offset = "0x2CACFC0", VA = "0x182CADBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1C30", Offset = "0x2CB1030", VA = "0x182CB1C30", Slot = "33")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2CACD40", Offset = "0x2CAC140", VA = "0x182CACD40", Slot = "34")]
		public bool AACANLGOKKJ(Transform KFAGMEKKLDA, out MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2CAFAB0", Offset = "0x2CAEEB0", VA = "0x182CAFAB0", Slot = "35")]
		public Transform JHFEJDPMLDH(Entity NOADJCMIKEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2CADC80", Offset = "0x2CAD080", VA = "0x182CADC80", Slot = "30")]
		public bool EDJHDGCFPJM(Entity NOADJCMIKEF, out Transform KFAGMEKKLDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2CAF8C0", Offset = "0x2CAECC0", VA = "0x182CAF8C0")]
		private void IJKFIGNPGAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2CAE360", Offset = "0x2CAD760", VA = "0x182CAE360", Slot = "29")]
		public void ENGJEDOPOCK(Entity NOADJCMIKEF, out Matrix4x4 GLBHDGOLGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD200", Offset = "0x2CAC600", VA = "0x182CAD200", Slot = "4")]
		public void CBAHCLPMHIH(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2CAE860", Offset = "0x2CADC60", VA = "0x182CAE860")]
		public void GAEJIOKOPFL(Entity NOADJCMIKEF, Vector3 BMHPNHLDACF, Quaternion BHFNLNKHCPA, Vector3 ECNGIAOMCJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1060", Offset = "0x2CB0460", VA = "0x182CB1060")]
		public void MPOCMHHCKNL(Entity NOADJCMIKEF, Vector3 BMHPNHLDACF, Quaternion BHFNLNKHCPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB0470", Offset = "0x2CAF870", VA = "0x182CB0470", Slot = "27")]
		public void KMPGKJGODLP(Entity NOADJCMIKEF, out Matrix4x4 CJMECOPHOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2CADF90", Offset = "0x2CAD390", VA = "0x182CADF90")]
		public void EIECLAJJLFO(Entity NOADJCMIKEF, in Matrix4x4 GLBHDGOLGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2CAEAE0", Offset = "0x2CADEE0", VA = "0x182CAEAE0")]
		public void GGBGDKFLFBF(Entity NOADJCMIKEF, in Matrix4x4 GLBHDGOLGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD960", Offset = "0x2CACD60", VA = "0x182CAD960")]
		public void DBNCGCKHNOL(Entity NOADJCMIKEF, in Matrix4x4 OKNJOKNHIDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x2CAEC10", Offset = "0x2CAE010", VA = "0x182CAEC10", Slot = "5")]
		public void GHAGDNMMNFC(Entity NOADJCMIKEF, Vector3 IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x2CB0480", Offset = "0x2CAF880", VA = "0x182CB0480", Slot = "6")]
		public Vector3 KPONEAEAFIK(Entity NOADJCMIKEF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1200", Offset = "0x2CB0600", VA = "0x182CB1200", Slot = "7")]
		public void NIDNAPLCLEE(Entity NOADJCMIKEF, Quaternion IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x2CB06A0", Offset = "0x2CAFAA0", VA = "0x182CB06A0", Slot = "8")]
		public Quaternion LEOKMBJJNGD(Entity NOADJCMIKEF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1B30", Offset = "0x2CB0F30", VA = "0x182CB1B30", Slot = "12")]
		public void PENCEOFCHDC(Entity NOADJCMIKEF, Vector3 IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x2CAFCE0", Offset = "0x2CAF0E0", VA = "0x182CAFCE0", Slot = "11")]
		public Vector3 KCMJNJCNIEE(Entity NOADJCMIKEF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x2CAE7C0", Offset = "0x2CADBC0", VA = "0x182CAE7C0")]
		public void FBLLBBEPONB(Entity NOADJCMIKEF, Vector3 IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x2CADB20", Offset = "0x2CACF20", VA = "0x182CADB20")]
		private Vector3 DHACALHFHIL(Entity NOADJCMIKEF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x2CAFA10", Offset = "0x2CAEE10", VA = "0x182CAFA10", Slot = "14")]
		public float JBNHKNAPNGI(Entity NOADJCMIKEF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x2CB0590", Offset = "0x2CAF990", VA = "0x182CB0590", Slot = "13")]
		public void KPPLKOEDIJK(Entity NOADJCMIKEF, float IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x2CAEE00", Offset = "0x2CAE200", VA = "0x182CAEE00")]
		private float HCDEPBOAOCO(Entity NOADJCMIKEF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1170", Offset = "0x2CB0570", VA = "0x182CB1170")]
		public void NHCCICNOHGG(Entity NOADJCMIKEF, float LFCBGILJGLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD120", Offset = "0x2CAC520", VA = "0x182CAD120", Slot = "16")]
		public Vector3 BKMFOJFEODD(Entity NOADJCMIKEF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1A00", Offset = "0x2CB0E00", VA = "0x182CB1A00", Slot = "15")]
		public void PEELMAPFFGA(Entity NOADJCMIKEF, Vector3 MAOFGOAMOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2CACFF0", Offset = "0x2CAC3F0", VA = "0x182CACFF0")]
		private Vector3 AEENPOLNMFJ(Entity NOADJCMIKEF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2CAED30", Offset = "0x2CAE130", VA = "0x182CAED30")]
		public void GHFKOEJNIDH(Entity NOADJCMIKEF, Vector3 IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2CB0C80", Offset = "0x2CB0080", VA = "0x182CB0C80")]
		[Conditional("DEBUG_BUILD")]
		private void MGGMEGLIFGF(Entity NOADJCMIKEF, Vector3 IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2CB18A0", Offset = "0x2CB0CA0", VA = "0x182CB18A0", Slot = "36")]
		public void PDAPMLJMHHK(Entity NOADJCMIKEF, Vector3 EFKMIDDCAKM, Quaternion IAPKIBMDFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD3F0", Offset = "0x2CAC7F0", VA = "0x182CAD3F0", Slot = "9")]
		public void CINJIIFHCCH(Entity NOADJCMIKEF, out Vector3 EFKMIDDCAKM, out Quaternion IAPKIBMDFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2CAF8E0", Offset = "0x2CAECE0", VA = "0x182CAF8E0", Slot = "10")]
		public void JADDBLAHHPC(Entity NOADJCMIKEF, out Vector3 EFKMIDDCAKM, out Quaternion IAPKIBMDFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2CB0250", Offset = "0x2CAF650", VA = "0x182CB0250", Slot = "37")]
		public void KMHINIIKFOM(Entity NOADJCMIKEF, Vector3 EFKMIDDCAKM, Quaternion IAPKIBMDFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2CAF700", Offset = "0x2CAEB00", VA = "0x182CAF700")]
		public void IHPEPJHGCJB(Entity NOADJCMIKEF, Vector3 EFKMIDDCAKM, Quaternion IAPKIBMDFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2CAE590", Offset = "0x2CAD990", VA = "0x182CAE590", Slot = "17")]
		public void FBEPMELFLCD(Entity NOADJCMIKEF, Vector3 IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2CAE4B0", Offset = "0x2CAD8B0", VA = "0x182CAE4B0", Slot = "18")]
		public Vector3 FANNNHKNCNN(Entity NOADJCMIKEF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1300", Offset = "0x2CB0700", VA = "0x182CB1300", Slot = "19")]
		public void NJMJOJEKIIH(Entity NOADJCMIKEF, Quaternion IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2CB17B0", Offset = "0x2CB0BB0", VA = "0x182CB17B0", Slot = "20")]
		public Quaternion PCGAEKKGNBL(Entity NOADJCMIKEF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2CAFDF0", Offset = "0x2CAF1F0", VA = "0x182CAFDF0", Slot = "22")]
		public void KDMBGPEHHBG(Entity NOADJCMIKEF, Vector3 IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2CACF00", Offset = "0x2CAC300", VA = "0x182CACF00", Slot = "21")]
		public Vector3 AEBEHPEJGOH(Entity NOADJCMIKEF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2CAF590", Offset = "0x2CAE990", VA = "0x182CAF590", Slot = "23")]
		public void HMNCANODKMD(Entity NOADJCMIKEF, float PIJNOLMHIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2CAFB70", Offset = "0x2CAEF70", VA = "0x182CAFB70", Slot = "24")]
		public float JJGJFJJCHLK(Entity NOADJCMIKEF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2CB0790", Offset = "0x2CAFB90", VA = "0x182CB0790", Slot = "25")]
		public void LKHCEFDGCPE(Entity NOADJCMIKEF, Vector3 EKKGNIDANDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2CADD70", Offset = "0x2CAD170", VA = "0x182CADD70", Slot = "26")]
		public Vector3 EDKLDNKFMDI(Entity NOADJCMIKEF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2CAEEF0", Offset = "0x2CAE2F0", VA = "0x182CAEEF0", Slot = "31")]
		public void HDBEFIPBMKN(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1660", Offset = "0x2CB0A60", VA = "0x182CB1660")]
		private MOLBNKBNJLI NLELAKIEIJE(Transform KFAGMEKKLDA)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2CB0E30", Offset = "0x2CB0230", VA = "0x182CB0E30")]
		private static TransformEntity MPCNELIICJD(APCEPJKMKDM FPPBLNEEHBP, GameObject GEMPPKOEIPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1540", Offset = "0x2CB0940", VA = "0x182CB1540", Slot = "32")]
		public void NKNJBIIBDHB(Entity NOADJCMIKEF, Entity OOHIPCPJDEM, Entity CNMJLCOJOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD540", Offset = "0x2CAC940", VA = "0x182CAD540")]
		private CMBLACIJPGJ CINJIIFHCCH(Entity NOADJCMIKEF)
		{
			return default(CMBLACIJPGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2CADEB0", Offset = "0x2CAD2B0", VA = "0x182CADEB0")]
		private bool EFMEFJJGJBC(Entity NOADJCMIKEF, out Entity JFCNGAACNEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2CAE930", Offset = "0x2CADD30", VA = "0x182CAE930")]
		private void GBHCGIOHGJI(Entity NOADJCMIKEF, out Matrix4x4 GLBHDGOLGOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2CAD5C0", Offset = "0x2CAC9C0", VA = "0x182CAD5C0")]
		private void CMNGFIDHFLC(Entity NOADJCMIKEF, out Matrix4x4 OKNJOKNHIDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2CAE350", Offset = "0x2CAD750", VA = "0x182CAE350", Slot = "28")]
		private void ENBLDGJOEPP(Entity NOADJCMIKEF, in Matrix4x4 CJMECOPHOCN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[NDGJMMLBLBO(typeof(LINHICHIPIE), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
internal sealed class LINHICHIPIE : LNLPIGELLPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[HIGIANBBMBE]
	private LLOINIJEHPN GEEOPHADFKF;

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF320", Offset = "0x2BCE720", VA = "0x182BCF320", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF2B0", Offset = "0x2BCE6B0", VA = "0x182BCF2B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public LINHICHIPIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
[NDGJMMLBLBO(typeof(ALDGECKNKCD), new string[] { })]
public class ALDGECKNKCD
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct DGMAKHCIJEF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly ALDGECKNKCD JFCNGAACNEO;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E620", Offset = "0x2C9DA20", VA = "0x182C9E620")]
		public DGMAKHCIJEF(ALDGECKNKCD JFCNGAACNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E600", Offset = "0x2C9DA00", VA = "0x182C9E600", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private int OOPHEOKCLLH;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool CMGDNIAJACE
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x15663B0", Offset = "0x15657B0", VA = "0x1815663B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action LPLEACDDDKK
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2B7CCB0", Offset = "0x2B7C0B0", VA = "0x182B7CCB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2B7CDA0", Offset = "0x2B7C1A0", VA = "0x182B7CDA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B7CD50", Offset = "0x2B7C150", VA = "0x182B7CD50")]
	public DGMAKHCIJEF JOECFHOHDEN()
	{
		return default(DGMAKHCIJEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x1626760", Offset = "0x1625B60", VA = "0x181626760")]
	public void FGBNIMJIHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B7CD80", Offset = "0x2B7C180", VA = "0x182B7CD80")]
	public void KALIKGPKOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public ALDGECKNKCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[NDGJMMLBLBO(typeof(NPOFHBIKFNM), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
public class NPOFHBIKFNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private int OOPHEOKCLLH;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool DGHOOJGKDDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xE804C0", Offset = "0xE7F8C0", VA = "0x180E804C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x886E20", Offset = "0x886220", VA = "0x180886E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NPOFHBIKFNM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[NDGJMMLBLBO(typeof(EnableComponentSystemsInScope), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.ComponentSystemTypes)]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	public class EnableComponentSystemsInScope : LNLPIGELLPM, MCAGGOKLPEK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct HEKOHMDJHID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private NativeArray<int> HIEFLMJJACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private NativeArray<int> EJCKALBJGLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private Dictionary<ComponentSystemBase, int> OHLAPBGIMNC;

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F8D0", Offset = "0x2C9ECD0", VA = "0x182C9F8D0")]
			public HEKOHMDJHID(NativeArray<int> HIEFLMJJACG, NativeArray<int> EJCKALBJGLG, Dictionary<ComponentSystemBase, int> OHLAPBGIMNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F650", Offset = "0x2C9EA50", VA = "0x182C9F650")]
			public void MADECFHACKD(IEnumerable<ComponentSystemBase> FCGMOLCPBPL, GPPMCHFFAPH HMDCEHNAPCN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class HJPFNMHMPDE : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
			[DebuggerHidden]
			public HJPFNMHMPDE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F8F0", Offset = "0x2C9ECF0", VA = "0x182C9F8F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x2C9FAC0", Offset = "0x2C9EEC0", VA = "0x182C9FAC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x2C9FA10", Offset = "0x2C9EE10", VA = "0x182C9FA10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x2C9FA10", Offset = "0x2C9EE10", VA = "0x182C9FA10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public const GPPMCHFFAPH CIKEHFCDNHF = GPPMCHFFAPH.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly DLHDGHMPCLG NCFKOGHPFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIJOKICGGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private World KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private CLFAHLJOOKN IFCDDJDBLKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private NativeArray<int> NNLIHADGEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private NativeArray<int> GPEFEBCIAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int FMCKDMNHLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private GPPMCHFFAPH OMBCFOICDOK;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2B97F60", Offset = "0x2B97360", VA = "0x182B97F60", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B973C0", Offset = "0x2B967C0", VA = "0x182B973C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B97BC0", Offset = "0x2B96FC0", VA = "0x182B97BC0")]
		[IteratorStateMachine(typeof(HJPFNMHMPDE))]
		private IEnumerable<ComponentSystemBase> NAPNHPBEGNO(int BKLFOLNGODN, int AJIMECHHNCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2B97550", Offset = "0x2B96950", VA = "0x182B97550", Slot = "5")]
		public void GNDKKHFOLJI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2B97D50", Offset = "0x2B97150", VA = "0x182B97D50")]
		private void NCFAKHAHBJB(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2B97C50", Offset = "0x2B97050", VA = "0x182B97C50")]
		public void NCFAKHAHBJB(GPPMCHFFAPH IKBCAPLILHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x2B97780", Offset = "0x2B96B80", VA = "0x182B97780")]
		private void JHNOGINBECI(GPPMCHFFAPH IKBCAPLILHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x2B97A10", Offset = "0x2B96E10", VA = "0x182B97A10")]
		private void LHPOPLDMMEM(GPPMCHFFAPH IKBCAPLILHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2B97F00", Offset = "0x2B97300", VA = "0x182B97F00")]
		private void PDEDKKIJNKP(GPPMCHFFAPH IKBCAPLILHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x2B97450", Offset = "0x2B96850", VA = "0x182B97450")]
		private void EBOPGAOICLJ(int BKLFOLNGODN, int AJIMECHHNCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x2B97B00", Offset = "0x2B96F00", VA = "0x182B97B00")]
		private void NACOHOLCNHH(int BKLFOLNGODN, int AJIMECHHNCA, bool NCFLAPIBDMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x2B97560", Offset = "0x2B96960", VA = "0x182B97560")]
		private int HAIFOPNLLFM(GPPMCHFFAPH IKBCAPLILHK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B96E30", Offset = "0x2B96230", VA = "0x182B96E30")]
		private bool DCAFAHPPHAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B97690", Offset = "0x2B96A90", VA = "0x182B97690")]
		private Dictionary<ComponentSystemBase, int> JGMIDMDNOMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x2B97510", Offset = "0x2B96910", VA = "0x182B97510")]
		private void GEKPCINCDMJ(NativeArray<int> HIEFLMJJACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x2B975E0", Offset = "0x2B969E0", VA = "0x182B975E0")]
		private void JEKGDKHIGBK(NativeArray<int> EJCKALBJGLG, NativeArray<int> HIEFLMJJACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B97AA0", Offset = "0x2B96EA0", VA = "0x182B97AA0")]
		private static GPPMCHFFAPH MLPINPJLEEF(Type FPPBLNEEHBP, GPPMCHFFAPH HNGNIFMJFIP)
		{
			return default(GPPMCHFFAPH);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B98070", Offset = "0x2B97470", VA = "0x182B98070")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B97EA0", Offset = "0x2B972A0", VA = "0x182B97EA0")]
		[CompilerGenerated]
		private void NGCKFLONNKP(LNLPIGELLPM KJPDAHLDBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B97580", Offset = "0x2B96980", VA = "0x182B97580")]
		[CompilerGenerated]
		private void ILMHJHBLPHG(ENMEIFNEMLK KJPDAHLDBND)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[JLJFNDDLCBO(CBGNDNDJKHL.WorldService)]
	[NDGJMMLBLBO(typeof(GBCBOOEHEAG), new string[] { })]
	public class TickService : LNLPIGELLPM, GBCBOOEHEAG
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static readonly ProfilerMarker BOLKEIPHEBA;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly ProfilerMarker LELHHHMKEOK;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly ProfilerMarker EKBOIHFIGIC;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly ProfilerMarker CPCLBPIGEHF;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly ProfilerMarker HMKPLHOBHBH;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly ProfilerMarker NODJMBCBCGA;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly ProfilerMarker GCIPAJNIFOF;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly ProfilerMarker IAODEAPEMLJ;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly ProfilerMarker ADMNIMEOPCP;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly ProfilerMarker NMNEGPFNNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIJOKICGGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[HIGIANBBMBE]
		private ACFOFFHKLLK BHJKPHAEBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[HIGIANBBMBE]
		private MANDPKBPCIG KNLKAIOEGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[HIGIANBBMBE]
		private TransformOwnershipPhase FLKIELBJKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[HIGIANBBMBE]
		private TimeService NHCOCKHKBLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private FBFMDKPKBLB KIEEJCIFMFE;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private bool DEFBDGFNAPE
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x2CAAF80", Offset = "0x2CAA380", VA = "0x182CAAF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private bool CGOIBLAACFO
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x2CAB170", Offset = "0x2CAA570", VA = "0x182CAB170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private bool ILODFCIDBKF
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x2CAAF80", Offset = "0x2CAA380", VA = "0x182CAAF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool FMGPDCENCML
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x2CAAF80", Offset = "0x2CAA380", VA = "0x182CAAF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC000", Offset = "0x2CAB400", VA = "0x182CAC000", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2CABAA0", Offset = "0x2CAAEA0", VA = "0x182CABAA0", Slot = "14")]
		public void OCCMLIMADHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB830", Offset = "0x2CAAC30", VA = "0x182CAB830", Slot = "15")]
		public void LFBGMAHABBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB390", Offset = "0x2CAA790", VA = "0x182CAB390", Slot = "5")]
		public void EOJAMFIHIOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB530", Offset = "0x2CAA930", VA = "0x182CAB530", Slot = "6")]
		public void KBFCLHAPCCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2CAAFF0", Offset = "0x2CAA3F0", VA = "0x182CAAFF0", Slot = "7")]
		public void CIMLDMIMLAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB6B0", Offset = "0x2CAAAB0", VA = "0x182CAB6B0", Slot = "8")]
		public void LEPAJBPKAGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB210", Offset = "0x2CAA610", VA = "0x182CAB210", Slot = "9")]
		public void DDOALCILGPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2CABBC0", Offset = "0x2CAAFC0", VA = "0x182CABBC0", Slot = "10")]
		public void ONPPNIDHCDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB460", Offset = "0x2CAA860", VA = "0x182CAB460", Slot = "11")]
		public void JGPPFHOLHDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "13")]
		public void LCADBFEINBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2CAB950", Offset = "0x2CAAD50", VA = "0x182CAB950", Slot = "12")]
		public void NMOHDKJAKGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[JLJFNDDLCBO(CBGNDNDJKHL.WorldService)]
	[NDGJMMLBLBO(typeof(NHLELLEJLGC), new string[] { })]
	public class WorldService : NHLELLEJLGC, IDisposable, MCPGEGOMHPG
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private FBFMDKPKBLB KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool HIBODKPCONP;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public FBFMDKPKBLB GEMNOHGEBLC
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public GDHFGEGLFMK GBPJMMGCLOL
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x29DC930", Offset = "0x29DBD30", VA = "0x1829DC930", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public EntityManager HDMAFEMIPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x2CBA3A0", Offset = "0x2CB97A0", VA = "0x182CBA3A0", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool NMHLJFGMGOF
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x6928D0", Offset = "0x691CD0", VA = "0x1806928D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA180", Offset = "0x2CB9580", VA = "0x182CBA180", Slot = "10")]
		public void FFHOKNLNLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA290", Offset = "0x2CB9690", VA = "0x182CBA290")]
		private void FNICMNFMKAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9F50", Offset = "0x2CB9350", VA = "0x182CB9F50", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9F30", Offset = "0x2CB9330", VA = "0x182CB9F30", Slot = "8")]
		public ComponentSystemBase BHLCPJEFMPF(Type FPPBLNEEHBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[NDGJMMLBLBO(typeof(BJKLIKDFIPA), new string[] { })]
public sealed class JFCIAIMJPDG : BJKLIKDFIPA, GGFJAKOLADN, MCPGEGOMHPG, LNLPIGELLPM, ENMEIFNEMLK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class FOFKAMNIGIP : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x699040", Offset = "0x698440", VA = "0x180699040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x432DBE0", Offset = "0x432CFE0", VA = "0x18432DBE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97F60", VA = "0x180A98B60")]
		[DebuggerHidden]
		public FOFKAMNIGIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x432D8D0", Offset = "0x432CCD0", VA = "0x18432D8D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x432DBA0", Offset = "0x432CFA0", VA = "0x18432DBA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x432DB00", Offset = "0x432CF00", VA = "0x18432DB00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x432DB00", Offset = "0x432CF00", VA = "0x18432DB00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[HIGIANBBMBE]
	private DNDLCINBGLP OEKBACMEEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly EIIPILMMOGB FLGMIOAEDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly Dictionary<string, KADJEFHOBPF> MJIAMOMBDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<int, DNCGINCJMGE> NLBNMPJMFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<MCLHOLCKNPA> LHKBEJGEJDM;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public DNCGINCJMGE JKAKPJDGKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BC6010", Offset = "0x2BC5410", VA = "0x182BC6010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<MCLHOLCKNPA> JFILBCIANFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
	public void FFHOKNLNLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x2BC64E0", Offset = "0x2BC58E0", VA = "0x182BC64E0", Slot = "8")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5E60", Offset = "0x2BC5260", VA = "0x182BC5E60", Slot = "9")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5F80", Offset = "0x2BC5380", VA = "0x182BC5F80", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5E80", Offset = "0x2BC5280", VA = "0x182BC5E80", Slot = "6")]
	public bool DCJEACGOLHA(MCLHOLCKNPA PDLHECKEFMN, out DNCGINCJMGE EOONLHGBECH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5780", Offset = "0x2BC4B80", VA = "0x182BC5780")]
	private void ABOJIJFICMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x2BC65A0", Offset = "0x2BC59A0", VA = "0x182BC65A0")]
	private void PNMBPGJBMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6540", Offset = "0x2BC5940", VA = "0x182BC6540")]
	private KADJEFHOBPF PHELCGMEGIL(string FHMACDMAMJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6010", Offset = "0x2BC5410", VA = "0x182BC6010")]
	private KADJEFHOBPF MKJPCOGJOPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5BF0", Offset = "0x2BC4FF0", VA = "0x182BC5BF0")]
	private KADJEFHOBPF CDNLFMMIKFA(string FHMACDMAMJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6070", Offset = "0x2BC5470", VA = "0x182BC6070")]
	private KADJEFHOBPF EGABAMDGGLK(string GKBEAKNFHBF, string MJNGPHMPILM, [Optional] KADJEFHOBPF EAILFJOMPEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5F10", Offset = "0x2BC5310", VA = "0x182BC5F10")]
	[IteratorStateMachine(typeof(FOFKAMNIGIP))]
	private IEnumerable<(string, string)> DEPNAHNHEEE(string FHMACDMAMJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6360", Offset = "0x2BC5760", VA = "0x182BC6360")]
	private bool FNNAHIFFKFK(MCLHOLCKNPA PDLHECKEFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5B10", Offset = "0x2BC4F10", VA = "0x182BC5B10")]
	private EIIPILMMOGB ACOMJNMJMAF(MCLHOLCKNPA PDLHECKEFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6490", Offset = "0x2BC5890", VA = "0x182BC6490")]
	private EIIPILMMOGB JDFNAACGIAK(MCLHOLCKNPA PDLHECKEFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6240", Offset = "0x2BC5640", VA = "0x182BC6240")]
	private EIIPILMMOGB FDAGLOHONGM(MCLHOLCKNPA PDLHECKEFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2D0F7A0", Offset = "0x2D0EBA0", VA = "0x182D0F7A0")]
	private T LDKKHAKIKEB<T>(MCLHOLCKNPA PDLHECKEFMN) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x2BC63B0", Offset = "0x2BC57B0", VA = "0x182BC63B0")]
	private FieldInfo GGGJFBDFAOE(MCLHOLCKNPA PDLHECKEFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6740", Offset = "0x2BC5B40", VA = "0x182BC6740")]
	public JFCIAIMJPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2BC62D0", Offset = "0x2BC56D0", VA = "0x182BC62D0")]
	[CompilerGenerated]
	private int FLOLADDBLNM(MCLHOLCKNPA GHJDMBPGMHF, MCLHOLCKNPA IKDBBHHKFLJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public sealed class KADJEFHOBPF : DNCGINCJMGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public readonly string GBBCNPEPNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public readonly KADJEFHOBPF EAILFJOMPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public readonly List<KADJEFHOBPF> IJOOKDLJHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public readonly List<MCLHOLCKNPA> OEKBACMEEFA;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public string HEBHPBBFLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public DNCGINCJMGE COOCIJKPKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<DNCGINCJMGE> NJMEPJCIKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public IEnumerable<MCLHOLCKNPA> PJDMIDKLEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7D20", Offset = "0x2BC7120", VA = "0x182BC7D20")]
	public KADJEFHOBPF(string DHKKANIEGMN, KADJEFHOBPF JFCNGAACNEO)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[JLJFNDDLCBO(CBGNDNDJKHL.History)]
	[NDGJMMLBLBO(typeof(PAIHKGLKBFJ), new string[] { })]
	[JJCBNHCEDIO(typeof(HistoryService))]
	public class HistoryService : LNLPIGELLPM, IDisposable, PAIHKGLKBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private enum OJLOLJMMOEK
		{
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private readonly struct ANCHBIPLALH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly OJLOLJMMOEK JDFMMEEIHLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly HistoryService IIHJMACAMDH;

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x432A4B0", Offset = "0x43298B0", VA = "0x18432A4B0")]
			public ANCHBIPLALH(HistoryService IIHJMACAMDH, bool GKCALFMCDMB, uint FMCKDMNHLLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x432A480", Offset = "0x4329880", VA = "0x18432A480", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public class CBNIKJOKGAM
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			public struct LFGLOPCPMGH : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				private readonly CBNIKJOKGAM HOJCMPMFJFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private readonly bool ODOBPDJMFCC;

				[Cpp2IlInjected.Token(Token = "0x6000345")]
				[Cpp2IlInjected.Address(RVA = "0x4331ED0", Offset = "0x43312D0", VA = "0x184331ED0")]
				public LFGLOPCPMGH(CBNIKJOKGAM HOJCMPMFJFK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000346")]
				[Cpp2IlInjected.Address(RVA = "0x432D170", Offset = "0x432C570", VA = "0x18432D170", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct FEDELADBNCN : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				private readonly CBNIKJOKGAM HOJCMPMFJFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				private readonly bool ODOBPDJMFCC;

				[Cpp2IlInjected.Token(Token = "0x6000347")]
				[Cpp2IlInjected.Address(RVA = "0x432D1A0", Offset = "0x432C5A0", VA = "0x18432D1A0")]
				public FEDELADBNCN(CBNIKJOKGAM HOJCMPMFJFK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0x432D170", Offset = "0x432C570", VA = "0x18432D170", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private readonly HistoryService NPNAEFOFPIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool EENIPEFEKAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private int BBHNNBGCNCF;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x432AC20", Offset = "0x432A020", VA = "0x18432AC20")]
			public CBNIKJOKGAM(HistoryService NPNAEFOFPIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x432ABF0", Offset = "0x4329FF0", VA = "0x18432ABF0")]
			public bool FKLPJPPEFOJ(JCHOAKCKPKK OACDBCDEFBJ, EEJFBJIDABN FCLBEIEGADL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x432AB50", Offset = "0x4329F50", VA = "0x18432AB50")]
			public FEDELADBNCN COMLDFBOJIF()
			{
				return default(FEDELADBNCN);
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x432ABA0", Offset = "0x4329FA0", VA = "0x18432ABA0")]
			public LFGLOPCPMGH DIAFCLDOJPB()
			{
				return default(LFGLOPCPMGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class LFPDPNNPHOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public LFPDPNNPHOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x4331F10", Offset = "0x4331310", VA = "0x184331F10")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private sealed class HIBJCOPKPCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public HIBJCOPKPCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x432E3F0", Offset = "0x432D7F0", VA = "0x18432E3F0")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class AJFGANEHCOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public AJFGANEHCOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x432A450", Offset = "0x4329850", VA = "0x18432A450")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static readonly UndoAction OEJNJEBCGIJ;

		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private static readonly RedoAction PNOBFOCGOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private OHMHDLHOIOJ PPCPOILJBNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private ActionBuffer OFHKALGPIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private ActionBuffer HDOGJCDCEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private PCGLHKLCLGJ DBGMPMLGKNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TransformOwnershipPhase FLKIELBJKJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private PropertyChangeRouterService MDLECLDMEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private PFMPKBKACLC NLKAALKLBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private OJLOLJMMOEK CACNIOLJLCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private CBNIKJOKGAM HOJCMPMFJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private bool HIBODKPCONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private CAOLOHBLMEA CGGANPEEADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private FFMELNGKBPP KLECKDCDMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private EEJFBJIDABN NPJEOCGKCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly GatherPropertiesForUndelete LELOIAMCKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private uint FNICEABJIDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private uint FAHCECJILJB;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private CBNIKJOKGAM EOBNLEBNBIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x68E770", Offset = "0x68DB70", VA = "0x18068E770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool GEBPAACKCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2B60", Offset = "0x2BC1F60", VA = "0x182BC2B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool CDIOIPCEAMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x2BC21E0", Offset = "0x2BC15E0", VA = "0x182BC21E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool HCJDNADBDBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2BC25C0", Offset = "0x2BC19C0", VA = "0x182BC25C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public int NPOFKNOPFBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1BD0", Offset = "0x2BC0FD0", VA = "0x182BC1BD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int AOKELMLEBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x2BC25F0", Offset = "0x2BC19F0", VA = "0x182BC25F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		private bool CKJJKEDIJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x2BC1720", Offset = "0x2BC0B20", VA = "0x182BC1720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private bool GBGOIMLLHPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x2BC16C0", Offset = "0x2BC0AC0", VA = "0x182BC16C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool IFDKNOEJJFF
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x94A6F0", Offset = "0x949AF0", VA = "0x18094A6F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x1064060", Offset = "0x1063460", VA = "0x181064060", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private ActionBuffer BOHGHIPMMBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2CD0", Offset = "0x2BC20D0", VA = "0x182BC2CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action BCMBIBOIADJ
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2650", Offset = "0x2BC1A50", VA = "0x182BC2650", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2460", Offset = "0x2BC1860", VA = "0x182BC2460", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action MLHLGJHMDPB
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x2BC2500", Offset = "0x2BC1900", VA = "0x182BC2500")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x2BC3520", Offset = "0x2BC2920", VA = "0x182BC3520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3070", Offset = "0x2BC2470", VA = "0x182BC3070", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1C70", Offset = "0x2BC1070", VA = "0x182BC1C70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3660", Offset = "0x2BC2A60", VA = "0x182BC3660")]
		private void PPPBJFIJDOJ(JCHOAKCKPKK OACDBCDEFBJ, GAKKJFKJMJN DJHEEMHONEB, bool KMFBMLPACBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1FC0", Offset = "0x2BC13C0", VA = "0x182BC1FC0")]
		private void GBNNEIDOAPC(JCHOAKCKPKK OACDBCDEFBJ, EEJFBJIDABN FCLBEIEGADL, PEABCJAGJAH ECKMNACMGDC, PEABCJAGJAH NDKJFJECHPC, bool KMFBMLPACBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2280", Offset = "0x2BC1680", VA = "0x182BC2280")]
		private void JCIGLMNMPHP(JCHOAKCKPKK OACDBCDEFBJ, bool KMFBMLPACBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2BC35C0", Offset = "0x2BC29C0", VA = "0x182BC35C0", Slot = "14")]
		public IDisposable PNDOHOEBNOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2990", Offset = "0x2BC1D90", VA = "0x182BC2990", Slot = "9")]
		public IDisposable LIKJBKEGPNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2040", Offset = "0x2BC1440", VA = "0x182BC2040", Slot = "6")]
		public UndoAction HMHBGNFILKD()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2D10", Offset = "0x2BC2110", VA = "0x182BC2D10", Slot = "15")]
		public RedoAction NOAPDEFOPOG()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2810", Offset = "0x2BC1C10", VA = "0x182BC2810", Slot = "16")]
		public UndoAction KMEGAFJPLIL()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2DD0", Offset = "0x2BC21D0", VA = "0x182BC2DD0", Slot = "7")]
		public RedoAction NOAPDEFOPOG(UndoAction BCPKCLKDOEP)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2BC26F0", Offset = "0x2BC1AF0", VA = "0x182BC26F0", Slot = "8")]
		public UndoAction KMEGAFJPLIL(RedoAction BCPKCLKDOEP)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2610", Offset = "0x2BC1A10", VA = "0x182BC2610")]
		public bool KFBFLPLHNOF(NCFGDMEOFPG MFHIFJFMDAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2BC16D0", Offset = "0x2BC0AD0", VA = "0x182BC16D0", Slot = "17")]
		public void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2BC28D0", Offset = "0x2BC1CD0", VA = "0x182BC28D0")]
		public void LENFEBGDMNK(JCHOAKCKPKK OACDBCDEFBJ, GAKKJFKJMJN DJHEEMHONEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1580", Offset = "0x2BC0980", VA = "0x182BC1580")]
		public void AANMCDKHAJC(JCHOAKCKPKK OACDBCDEFBJ, EEJFBJIDABN FCLBEIEGADL, in PEABCJAGJAH NDKJFJECHPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1F10", Offset = "0x2BC1310", VA = "0x182BC1F10")]
		public void FABELEMAPJD(JCHOAKCKPKK OACDBCDEFBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1680", Offset = "0x2BC0A80", VA = "0x182BC1680")]
		private void AJOGKHBACMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3620", Offset = "0x2BC2A20", VA = "0x182BC3620")]
		private void PPLCHFEHAEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1660", Offset = "0x2BC0A60", VA = "0x182BC1660")]
		private void AGOMGJAFKPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2BD0", Offset = "0x2BC1FD0", VA = "0x182BC2BD0")]
		private GIJBJHMNNJJ NBKFLGNKINJ()
		{
			return default(GIJBJHMNNJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x2BC29F0", Offset = "0x2BC1DF0", VA = "0x182BC29F0")]
		private uint MFDIOKCDEEN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2BC25A0", Offset = "0x2BC19A0", VA = "0x182BC25A0")]
		private bool JLJBAPHDNGL(out GIJBJHMNNJJ LECDCDLGAEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3050", Offset = "0x2BC2450", VA = "0x182BC3050")]
		private bool PEEJEDJMJHL(out GIJBJHMNNJJ LECDCDLGAEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1FE0", Offset = "0x2BC13E0", VA = "0x182BC1FE0")]
		private RedoAction GEABAKAAOMM(GIJBJHMNNJJ LECDCDLGAEL)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1730", Offset = "0x2BC0B30", VA = "0x182BC1730")]
		private UndoAction DHBPNPPFFCN(GIJBJHMNNJJ LECDCDLGAEL)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1790", Offset = "0x2BC0B90", VA = "0x182BC1790")]
		private GIJBJHMNNJJ DHFELAFJKKJ(GIJBJHMNNJJ LECDCDLGAEL, ActionBuffer DFDOIGMFPKH, bool GKCALFMCDMB)
		{
			return default(GIJBJHMNNJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2100", Offset = "0x2BC1500", VA = "0x182BC2100")]
		private void ICEOLAFHEBK(Action LECDCDLGAEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x1F7CA20", Offset = "0x1F7BE20", VA = "0x181F7CA20")]
		private T ICEOLAFHEBK<T>(Func<T> GPLLJFGLBLN)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2CE0", Offset = "0x2BC20E0", VA = "0x182BC2CE0")]
		private ANCHBIPLALH NHJHDJNFPMO(bool GKCALFMCDMB, uint FMCKDMNHLLD)
		{
			return default(ANCHBIPLALH);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC3800", Offset = "0x2BC2C00", VA = "0x182BC3800")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2A10", Offset = "0x2BC1E10", VA = "0x182BC2A10")]
		[CompilerGenerated]
		private UndoAction MOJGNBEJBGD()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2BC1A50", Offset = "0x2BC0E50", VA = "0x182BC1A50")]
		[CompilerGenerated]
		private RedoAction DKGALILFDNE()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2BC2EF0", Offset = "0x2BC22F0", VA = "0x182BC2EF0")]
		[CompilerGenerated]
		private UndoAction PCGGBDJMFAM()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class IJJEGPEGJHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NativeArray<byte> ICPECNGAFCL;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public int GCBADAOHFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xD8B120", Offset = "0xD8A520", VA = "0x180D8B120")]
	public IJJEGPEGJHN(NativeArray<byte> ICPECNGAFCL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4480", Offset = "0x2BC3880", VA = "0x182BC4480")]
	public static IJJEGPEGJHN GFKKOGBEPBN(NativeArray<byte> ICPECNGAFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	public T PNKEKNIEDCD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	public NativeArray<T> OBKDDNIDOHM<T>(int BFFLFOJBLOH, Allocator JLPBABJNDBH) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	public NativeArray<T> CCEMCFEIJPO<T>(Allocator JLPBABJNDBH) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class KCPFAMABNJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private NativeArray<byte> ICPECNGAFCL;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public int GCBADAOHFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0xD8B120", Offset = "0xD8A520", VA = "0x180D8B120")]
	public KCPFAMABNJE(NativeArray<byte> ICPECNGAFCL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7E20", Offset = "0x2BC7220", VA = "0x182BC7E20")]
	public static KCPFAMABNJE GFKKOGBEPBN(NativeArray<byte> ICPECNGAFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x25AC690", Offset = "0x25ABA90", VA = "0x1825AC690")]
	public T PNKEKNIEDCD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	public NativeArray<T> OBKDDNIDOHM<T>(int BFFLFOJBLOH, Allocator JLPBABJNDBH) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class LJDMEKOBICC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private NativeArray<byte> ICPECNGAFCL;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int GCBADAOHFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xD8B120", Offset = "0xD8A520", VA = "0x180D8B120")]
	public LJDMEKOBICC(NativeArray<byte> ICPECNGAFCL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF3F0", Offset = "0x2BCE7F0", VA = "0x182BCF3F0")]
	public static LJDMEKOBICC GFKKOGBEPBN(NativeArray<byte> ICPECNGAFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x25C0E70", Offset = "0x25C0270", VA = "0x1825C0E70")]
	public void CMMPLAFLCLM<T>(in T IGDJJEECDAF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x25C0ED0", Offset = "0x25C02D0", VA = "0x1825C0ED0")]
	public void JIEFMFKHEPD<T>(NativeArray<T> OHCPCHAKDAC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	public void HDHHMGJIODO<T>(NativeArray<T> IGDJJEECDAF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NNKDACAPJCC
{
	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x29D8AE0", Offset = "0x29D7EE0", VA = "0x1829D8AE0")]
	public static Span<byte> HDKOCCAOEKI(this NativeArray<byte> ICPECNGAFCL)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x29D8870", Offset = "0x29D7C70", VA = "0x1829D8870")]
	public static ReadOnlySpan<byte> AFMCFAOOCNH(this NativeArray<byte> ICPECNGAFCL)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x29D8B70", Offset = "0x29D7F70", VA = "0x1829D8B70")]
	public static NativeArray<byte> PGHHCKCEHHD(this NativeArray<byte> ICPECNGAFCL, int BKLFOLNGODN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x29D89F0", Offset = "0x29D7DF0", VA = "0x1829D89F0")]
	public static NativeArray<byte> CEBJEPLDNGK(this NativeArray<byte> ICPECNGAFCL, int LKJCGNNPEOE = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x30E1D00", Offset = "0x30E1100", VA = "0x1830E1D00")]
	public static NativeArray<byte> CEBJEPLDNGK<T>(this NativeArray<byte> ICPECNGAFCL, int LKJCGNNPEOE = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x29D8A70", Offset = "0x29D7E70", VA = "0x1829D8A70")]
	public static NativeArray<byte> FIDFCGDGKMG(this NativeArray<byte> ICPECNGAFCL, int LKJCGNNPEOE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x30E1D60", Offset = "0x30E1160", VA = "0x1830E1D60")]
	public static NativeArray<byte> FIDFCGDGKMG<T>(this NativeArray<byte> ICPECNGAFCL, int LKJCGNNPEOE = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x29D8BF0", Offset = "0x29D7FF0", VA = "0x1829D8BF0")]
	public static NativeArray<byte> PILOCOIHDJK(this NativeArray<byte> ICPECNGAFCL, int LKJCGNNPEOE = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x30E1DC0", Offset = "0x30E11C0", VA = "0x1830E1DC0")]
	public static NativeArray<byte> PILOCOIHDJK<T>(this NativeArray<byte> ICPECNGAFCL, int LKJCGNNPEOE = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class CEHMACOIPKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private NativeList<byte> MOBONMBAIDJ;

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xD8B120", Offset = "0xD8A520", VA = "0x180D8B120")]
	public CEHMACOIPKK(NativeList<byte> MOBONMBAIDJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2B84780", Offset = "0x2B83B80", VA = "0x182B84780")]
	public static CEHMACOIPKK GFKKOGBEPBN(NativeList<byte> ICPECNGAFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public void CMMPLAFLCLM<T>(in T IGDJJEECDAF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public void JIEFMFKHEPD<T>(NativeArray<T> IGDJJEECDAF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public void HDHHMGJIODO<T>(NativeArray<T> IGDJJEECDAF) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	[NDGJMMLBLBO(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.PropertyChanges)]
	public class PropertyChangeNetworkRouter : MCPGEGOMHPG, LNLPIGELLPM, JPMGOPHCIKO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[HIGIANBBMBE]
		private DIHCDHLHMBK MPHPGBJPKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[HIGIANBBMBE]
		private NLELCAEKFFF OEKBACMEEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[HIGIANBBMBE]
		private ALDGECKNKCD HFLGLFEIMCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[HIGIANBBMBE]
		private PropertyChangeRouterService MDLECLDMEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private OHMHDLHOIOJ NDIBANACJCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private DJFMEJMCAOI AOCNGIFBFBK;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public OHMHDLHOIOJ EMADCAGKKAI
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x29F2220", Offset = "0x29F1620", VA = "0x1829F2220")]
		public OHMHDLHOIOJ.EGPGGECJFAM JOECFHOHDEN()
		{
			return default(OHMHDLHOIOJ.EGPGGECJFAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x29F1D00", Offset = "0x29F1100", VA = "0x1829F1D00", Slot = "4")]
		public void FFHOKNLNLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x29F2340", Offset = "0x29F1740", VA = "0x1829F2340", Slot = "5")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x29F1880", Offset = "0x29F0C80", VA = "0x1829F1880", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x29F1E10", Offset = "0x29F1210", VA = "0x1829F1E10")]
		public void HMHBGNFILKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x29F1850", Offset = "0x29F0C50", VA = "0x1829F1850")]
		public void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x29F1BF0", Offset = "0x29F0FF0", VA = "0x1829F1BF0")]
		private void FECBIPIJMDO(JCHOAKCKPKK OACDBCDEFBJ, GAKKJFKJMJN DJHEEMHONEB, bool KMFBMLPACBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x29F17A0", Offset = "0x29F0BA0", VA = "0x1829F17A0")]
		private void BKGBDHNJHOH(JCHOAKCKPKK OACDBCDEFBJ, EEJFBJIDABN FCLBEIEGADL, PEABCJAGJAH ECKMNACMGDC, PEABCJAGJAH NDKJFJECHPC, bool KMFBMLPACBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x29F16A0", Offset = "0x29F0AA0", VA = "0x1829F16A0")]
		private void BEEEBNOHKDJ(JCHOAKCKPKK OACDBCDEFBJ, bool KMFBMLPACBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x29F1F20", Offset = "0x29F1320", VA = "0x1829F1F20")]
		private void IOLCNKLJPDO(DJFMEJMCAOI KOEICPMBJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x29F1AA0", Offset = "0x29F0EA0", VA = "0x1829F1AA0")]
		private void EBHLALAMACF(DJFMEJMCAOI KOEICPMBJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x29F2280", Offset = "0x29F1680", VA = "0x1829F2280")]
		private void OBPAMFNHAHC(DJFMEJMCAOI KOEICPMBJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x29F1DF0", Offset = "0x29F11F0", VA = "0x1829F1DF0")]
		private void FGBNIMJIHLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x29F2260", Offset = "0x29F1660", VA = "0x1829F2260")]
		private void KALIKGPKOMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x29F1600", Offset = "0x29F0A00", VA = "0x1829F1600")]
		private void AMMCMJDLENP(DJFMEJMCAOI KOEICPMBJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x3D6C3C0", Offset = "0x3D6B7C0", VA = "0x183D6C3C0", Slot = "6")]
		private void GDEFOJLGCCP<TKey, T>(global::CGELFOKBEAG<TKey, T> PDLHECKEFMN, object GKMHGIGLKCO) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[JLJFNDDLCBO(CBGNDNDJKHL.History)]
	[NDGJMMLBLBO(typeof(PropertyChangeRouterService), new string[] { })]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public delegate void ABOKEHKLIEH(JCHOAKCKPKK OACDBCDEFBJ, GAKKJFKJMJN DJHEEMHONEB, bool KMFBMLPACBN);

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public delegate void EKJOMCOFBMH(JCHOAKCKPKK OACDBCDEFBJ, EEJFBJIDABN FCLBEIEGADL, PEABCJAGJAH ECKMNACMGDC, PEABCJAGJAH NDKJFJECHPC, bool KMFBMLPACBN);

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public delegate void KPPKAHNDFJN(JCHOAKCKPKK OACDBCDEFBJ, bool KMFBMLPACBN);

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public ABOKEHKLIEH FNICMNFMKAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public EKJOMCOFBMH NILJKFHKIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public KPPKAHNDFJN NPMFLDOJCPB;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x29F26A0", Offset = "0x29F1AA0", VA = "0x1829F26A0")]
		public void LENFEBGDMNK(JCHOAKCKPKK OACDBCDEFBJ, GAKKJFKJMJN DJHEEMHONEB, bool KMFBMLPACBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x29F2610", Offset = "0x29F1A10", VA = "0x1829F2610")]
		public void AANMCDKHAJC(JCHOAKCKPKK OACDBCDEFBJ, EEJFBJIDABN FCLBEIEGADL, in PEABCJAGJAH ECKMNACMGDC, in PEABCJAGJAH NDKJFJECHPC, bool KMFBMLPACBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x29F2680", Offset = "0x29F1A80", VA = "0x1829F2680")]
		public void FABELEMAPJD(JCHOAKCKPKK OACDBCDEFBJ, bool KMFBMLPACBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[DebuggerTypeProxy(typeof(FIFGELPMGOJ))]
	[JLJFNDDLCBO(CBGNDNDJKHL.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		internal class FIFGELPMGOJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly ActionBuffer CCBBJEPJPEO;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public int IGGNICCPKKG
			{
				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0x2C9E810", Offset = "0x2C9DC10", VA = "0x182C9E810")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public CPADAAKMKEJ[] OIPPIGFKEPB
			{
				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x2C9E650", Offset = "0x2C9DA50", VA = "0x182C9E650")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
			public FIFGELPMGOJ(ActionBuffer JNEBMEMEDFL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x2C9E720", Offset = "0x2C9DB20", VA = "0x182C9E720")]
			[CompilerGenerated]
			private CPADAAKMKEJ LBNBHNCCOON(GIJBJHMNNJJ LECDCDLGAEL)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		internal class CPADAAKMKEJ : JPMGOPHCIKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly ActionBuffer CCBBJEPJPEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly GIJBJHMNNJJ LECDCDLGAEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private List<(DJFMEJMCAOI, string, object)> BMEDMCDHJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private KCPFAMABNJE HMLGAEKBLFL;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public int IGGNICCPKKG
			{
				[Cpp2IlInjected.Token(Token = "0x60003AA")]
				[Cpp2IlInjected.Address(RVA = "0x2C9E380", Offset = "0x2C9D780", VA = "0x182C9E380")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public List<(DJFMEJMCAOI, string, object)> LDLDHJGFPGK
			{
				[Cpp2IlInjected.Token(Token = "0x60003AB")]
				[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x2C9E4D0", Offset = "0x2C9D8D0", VA = "0x182C9E4D0")]
			public CPADAAKMKEJ(ActionBuffer JNEBMEMEDFL, GIJBJHMNNJJ LECDCDLGAEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x2C9E3D0", Offset = "0x2C9D7D0", VA = "0x182C9E3D0")]
			private string MFMANLMDEJJ(DJFMEJMCAOI AOCNGIFBFBK)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x2C9E040", Offset = "0x2C9D440", VA = "0x182C9E040")]
			private void KELJHIKJDOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x29F8CD0", Offset = "0x29F80D0", VA = "0x1829F8CD0", Slot = "4")]
			public void LMIGLAAPADK<TKey, T>(global::CGELFOKBEAG<TKey, T> PDLHECKEFMN, [Optional] object GKMHGIGLKCO) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private NativeList<byte> DAFHLMNKNIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Stack<GIJBJHMNNJJ> PGGMOBKNBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private readonly FCHGJEIJKCH KCBHPMNBECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private readonly CAOLOHBLMEA CGGANPEEADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly NLELCAEKFFF OEKBACMEEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly bool CNHLKEFPNPJ;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public CIGBGJEPLLM BHDIBOCECJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x2B7EB00", Offset = "0x2B7DF00", VA = "0x182B7EB00")]
			get
			{
				return default(CIGBGJEPLLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public int IGGNICCPKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x2B7EB40", Offset = "0x2B7DF40", VA = "0x182B7EB40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2B7ECC0", Offset = "0x2B7E0C0", VA = "0x182B7ECC0")]
		public ActionBuffer(CAOLOHBLMEA CGGANPEEADB, NLELCAEKFFF OEKBACMEEFA, bool CNHLKEFPNPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E060", Offset = "0x2B7D460", VA = "0x182B7E060")]
		public bool DAGGBJKKKIB(out GIJBJHMNNJJ LECDCDLGAEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2B7DFF0", Offset = "0x2B7D3F0", VA = "0x182B7DFF0")]
		public void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E3E0", Offset = "0x2B7D7E0", VA = "0x182B7E3E0")]
		public GIJBJHMNNJJ HMHBGNFILKD(MHIDCLAHLFA BMEDMCDHJAD, PFMPKBKACLC NLKAALKLBEL, uint ILFPHLFIPEL)
		{
			return default(GIJBJHMNNJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x2B7EB80", Offset = "0x2B7DF80", VA = "0x182B7EB80")]
		public bool NLPGCCDGNFI(uint ILFPHLFIPEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E660", Offset = "0x2B7DA60", VA = "0x182B7E660")]
		public bool IIIOHCLLAGM(uint ILFPHLFIPEL, out GIJBJHMNNJJ BCPKCLKDOEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E270", Offset = "0x2B7D670", VA = "0x182B7E270")]
		public void HJKPBODDFIF(GIJBJHMNNJJ BCPKCLKDOEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E520", Offset = "0x2B7D920", VA = "0x182B7E520")]
		[Conditional("DEBUG_BUILD")]
		private void ICLCHPMKJGJ(GIJBJHMNNJJ BCPKCLKDOEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E0F0", Offset = "0x2B7D4F0", VA = "0x182B7E0F0")]
		private void DHFELAFJKKJ(GIJBJHMNNJJ BDMPJNJHOHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E8B0", Offset = "0x2B7DCB0", VA = "0x182B7E8B0")]
		private void KHIOFJJFIDC(KCPFAMABNJE LIEHOMNIBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E850", Offset = "0x2B7DC50", VA = "0x182B7E850")]
		private void JOKAHNGNFJE(GIJBJHMNNJJ LECDCDLGAEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x2B7EBB0", Offset = "0x2B7DFB0", VA = "0x182B7EBB0")]
		private KCPFAMABNJE OJONABLMIAI(GIJBJHMNNJJ LECDCDLGAEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B7E200", Offset = "0x2B7D600", VA = "0x182B7E200", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class FCHGJEIJKCH : JPMGOPHCIKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly CAOLOHBLMEA CGGANPEEADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly NLELCAEKFFF OEKBACMEEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private JCHOAKCKPKK OACDBCDEFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private KCPFAMABNJE ALFCAFKPJMF;

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6786E0", Offset = "0x677AE0", VA = "0x1806786E0")]
	public FCHGJEIJKCH(CAOLOHBLMEA CGGANPEEADB, NLELCAEKFFF OEKBACMEEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x2E87A30", Offset = "0x2E86E30", VA = "0x182E87A30", Slot = "4")]
	public void LMIGLAAPADK<TKey, T>(global::CGELFOKBEAG<TKey, T> FFDHLJKHNCL, [Optional] object GKMHGIGLKCO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x2BB72A0", Offset = "0x2BB66A0", VA = "0x182BB72A0")]
	public void LLJNHDKGDNB(DJFMEJMCAOI AOCNGIFBFBK, ref KCPFAMABNJE LIEHOMNIBOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class OHMHDLHOIOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct EGPGGECJFAM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly OHMHDLHOIOJ JFCNGAACNEO;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x432C0D0", Offset = "0x432B4D0", VA = "0x18432C0D0")]
		public EGPGGECJFAM(OHMHDLHOIOJ JFCNGAACNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x432C0B0", Offset = "0x432B4B0", VA = "0x18432C0B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	protected MHIDCLAHLFA BMEDMCDHJAD;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public MHIDCLAHLFA LDLDHJGFPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x29DBCB0", Offset = "0x29DB0B0", VA = "0x1829DBCB0")]
		get
		{
			return default(MHIDCLAHLFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool IBNMDOGHEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x29DC100", Offset = "0x29DB500", VA = "0x1829DC100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x29DC110", Offset = "0x29DB510", VA = "0x1829DC110")]
	public OHMHDLHOIOJ(MHIDCLAHLFA.FPKDALGDECP BNFGINFPDCF = MHIDCLAHLFA.FPKDALGDECP.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x29DBCA0", Offset = "0x29DB0A0", VA = "0x1829DBCA0")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x29DC010", Offset = "0x29DB410", VA = "0x1829DC010")]
	public void LENFEBGDMNK(JCHOAKCKPKK OACDBCDEFBJ, GAKKJFKJMJN DJHEEMHONEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x29DBC10", Offset = "0x29DB010", VA = "0x1829DBC10")]
	public void AANMCDKHAJC(JCHOAKCKPKK OACDBCDEFBJ, EEJFBJIDABN FCLBEIEGADL, in PEABCJAGJAH NDKJFJECHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x29DBD00", Offset = "0x29DB100", VA = "0x1829DBD00")]
	public void FABELEMAPJD(JCHOAKCKPKK OACDBCDEFBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x29DBDE0", Offset = "0x29DB1E0", VA = "0x1829DBDE0")]
	public void FGBNIMJIHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x29DBF10", Offset = "0x29DB310", VA = "0x1829DBF10")]
	public void KALIKGPKOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x29DBCF0", Offset = "0x29DB0F0", VA = "0x1829DBCF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x29DBEE0", Offset = "0x29DB2E0", VA = "0x1829DBEE0")]
	public EGPGGECJFAM JOECFHOHDEN()
	{
		return default(EGPGGECJFAM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct DJFMEJMCAOI : IComparable<DJFMEJMCAOI>, IEquatable<DJFMEJMCAOI>
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public static readonly DJFMEJMCAOI EAAMJEPFANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public JCHOAKCKPKK OACDBCDEFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public EEJFBJIDABN FCLBEIEGADL;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool EFFOACKHLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x25C83E0", Offset = "0x25C77E0", VA = "0x1825C83E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x699050", Offset = "0x698450", VA = "0x180699050")]
	public DJFMEJMCAOI(JCHOAKCKPKK OACDBCDEFBJ, EEJFBJIDABN FCLBEIEGADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2B91560", Offset = "0x2B90960", VA = "0x182B91560")]
	public void BABNJGFMKJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x2B91570", Offset = "0x2B90970", VA = "0x182B91570", Slot = "4")]
	public int CompareTo(DJFMEJMCAOI EPJIAIAEMFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B91720", Offset = "0x2B90B20", VA = "0x182B91720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x2B91600", Offset = "0x2B90A00", VA = "0x182B91600", Slot = "0")]
	public override bool Equals(object JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B915B0", Offset = "0x2B909B0", VA = "0x182B915B0", Slot = "5")]
	public bool Equals(DJFMEJMCAOI EPJIAIAEMFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x2B916E0", Offset = "0x2B90AE0", VA = "0x182B916E0")]
	public static bool LPAHFDMKICD(DJFMEJMCAOI LBABLKMFGKM, DJFMEJMCAOI MGCAIGBBIIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x2B91510", Offset = "0x2B90910", VA = "0x182B91510")]
	public static bool AFMDFHOMNJI(DJFMEJMCAOI LBABLKMFGKM, DJFMEJMCAOI MGCAIGBBIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x2B916A0", Offset = "0x2B90AA0", VA = "0x182B916A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[JLJFNDDLCBO(CBGNDNDJKHL.History)]
	public class GatherPropertiesForUndelete : CPMBOJGNMDD
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private CAOLOHBLMEA CGGANPEEADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private JCHOAKCKPKK OACDBCDEFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private HistoryService NPNAEFOFPIE;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC200", Offset = "0x2BBB600", VA = "0x182BBC200")]
		public void MFCLMEHDJKF(JCHOAKCKPKK OACDBCDEFBJ, CAOLOHBLMEA CGGANPEEADB, HistoryService NPNAEFOFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC130", Offset = "0x2BBB530", VA = "0x182BBC130", Slot = "4")]
		private void HKPGDBAGGDH(JADEFGIHAPF PDLHECKEFMN, in PEABCJAGJAH IGDJJEECDAF, object GKMHGIGLKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class NMGKOEOOOPL
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x29D80E0", Offset = "0x29D74E0", VA = "0x1829D80E0")]
	public static void EBHLALAMACF(MHIDCLAHLFA BMEDMCDHJAD, DJFMEJMCAOI AOCNGIFBFBK, GAKKJFKJMJN DJHEEMHONEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x29D81E0", Offset = "0x29D75E0", VA = "0x1829D81E0")]
	public static void IIFHHJLBPGM(MHIDCLAHLFA BMEDMCDHJAD, DJFMEJMCAOI AOCNGIFBFBK, in PEABCJAGJAH NDKJFJECHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x29D83F0", Offset = "0x29D77F0", VA = "0x1829D83F0")]
	public static void OBPAMFNHAHC(MHIDCLAHLFA BMEDMCDHJAD, DJFMEJMCAOI AOCNGIFBFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x29D8340", Offset = "0x29D7740", VA = "0x1829D8340")]
	public static void LMMICIBFAJG(MHIDCLAHLFA BMEDMCDHJAD, DJFMEJMCAOI AOCNGIFBFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x29D82A0", Offset = "0x29D76A0", VA = "0x1829D82A0")]
	public static GAKKJFKJMJN KFEJLCNFMKB(MHIDCLAHLFA BMEDMCDHJAD, DJFMEJMCAOI AOCNGIFBFBK)
	{
		return default(GAKKJFKJMJN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x30E1160", Offset = "0x30E0560", VA = "0x1830E1160")]
	public static T GFPLFKPBLPG<T>(MHIDCLAHLFA BMEDMCDHJAD, DJFMEJMCAOI AOCNGIFBFBK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x30E1130", Offset = "0x30E0530", VA = "0x1830E1130")]
	public static T GFPLFKPBLPG<T>(ref KCPFAMABNJE PNMIIEJFOON) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x29D82F0", Offset = "0x29D76F0", VA = "0x1829D82F0")]
	public static GAKKJFKJMJN KFEJLCNFMKB(ref KCPFAMABNJE PNMIIEJFOON)
	{
		return default(GAKKJFKJMJN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct MHIDCLAHLFA : IEnumerable<DJFMEJMCAOI>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum FPKDALGDECP
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct MKFIIKFMFHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly MHIDCLAHLFA MOBONMBAIDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly PFMPKBKACLC NLKAALKLBEL;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x4333390", Offset = "0x4332790", VA = "0x184333390")]
		public MKFIIKFMFHH(MHIDCLAHLFA MOBONMBAIDJ, PFMPKBKACLC NLKAALKLBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x4332A80", Offset = "0x4331E80", VA = "0x184332A80")]
		public void BGJKHFHDKFL(NativeList<byte> DJGPEPEBOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x4332E10", Offset = "0x4332210", VA = "0x184332E10")]
		private void CBCDELIGDGG(DJFMEJMCAOI AOCNGIFBFBK, ref LJDMEKOBICC HPBHHKPKPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x4333300", Offset = "0x4332700", VA = "0x184333300")]
		private void OPBFGADPMMI(DJFMEJMCAOI AOCNGIFBFBK, ref LJDMEKOBICC HPBHHKPKPAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x4332D20", Offset = "0x4332120", VA = "0x184332D20")]
		private NativeArray<byte> BMNCPLAIOLF(NativeList<byte> DJGPEPEBOGE)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x43330B0", Offset = "0x43324B0", VA = "0x1843330B0")]
		private NativeArray<byte> MPNOPOCKAMJ(NativeList<byte> DJGPEPEBOGE, int BFFLFOJBLOH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x4332E60", Offset = "0x4332260", VA = "0x184332E60")]
		private int EHBIMGJFDFF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x43331A0", Offset = "0x43325A0", VA = "0x1843331A0")]
		private bool NEJPJPFDJGP(DJFMEJMCAOI AOCNGIFBFBK, out NativeArray<byte> FKMFHMCBAHN)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct FABMENIJLPF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private NativeList<byte> PNMIIEJFOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private MHIDCLAHLFA MOBONMBAIDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly DJFMEJMCAOI KOEICPMBJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private readonly int BKLFOLNGODN;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x432CFF0", Offset = "0x432C3F0", VA = "0x18432CFF0")]
		internal FABMENIJLPF(MHIDCLAHLFA MOBONMBAIDJ, DJFMEJMCAOI KOEICPMBJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x432CD70", Offset = "0x432C170", VA = "0x18432CD70", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x432CDA0", Offset = "0x432C1A0", VA = "0x18432CDA0")]
		public void HCPKCJODKEO(NativeArray<byte> IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x432CF80", Offset = "0x432C380", VA = "0x18432CF80")]
		public void KHCCEJFFEEN(NativeArray<byte> IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x432CFE0", Offset = "0x432C3E0", VA = "0x18432CFE0")]
		public void OPBFGADPMMI(in PEABCJAGJAH IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x273FA80", Offset = "0x273EE80", VA = "0x18273FA80")]
		public void OPBFGADPMMI<T>(T IGDJJEECDAF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x432CEB0", Offset = "0x432C2B0", VA = "0x18432CEB0")]
		private void IPLIEDADDKL(int IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x432CE00", Offset = "0x432C200", VA = "0x18432CE00")]
		private void IPLIEDADDKL(in PEABCJAGJAH IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x432CF20", Offset = "0x432C320", VA = "0x18432CF20")]
		private unsafe void IPLIEDADDKL(void* BPNADEHDMGC, int BFFLFOJBLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x432CDA0", Offset = "0x432C1A0", VA = "0x18432CDA0")]
		private void IPLIEDADDKL(NativeArray<byte> OHCPCHAKDAC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public struct PAODEMHIKEL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private MHIDCLAHLFA MOBONMBAIDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private NativeArray<byte> PNMIIEJFOON;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x43343C0", Offset = "0x43337C0", VA = "0x1843343C0")]
		internal PAODEMHIKEL(MHIDCLAHLFA MOBONMBAIDJ, NativeArray<byte> PNMIIEJFOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x43341F0", Offset = "0x43335F0", VA = "0x1843341F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x4334200", Offset = "0x4333600", VA = "0x184334200")]
		public NativeArray<byte> OBKDDNIDOHM(int BFFLFOJBLOH)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x4334100", Offset = "0x4333500", VA = "0x184334100")]
		public NativeArray<byte> CCEMCFEIJPO()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x275DE40", Offset = "0x275D240", VA = "0x18275DE40")]
		public T PNKEKNIEDCD<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x43342C0", Offset = "0x43336C0", VA = "0x1843342C0")]
		public void PNKEKNIEDCD(in LCJNEDPGPKG IGDJJEECDAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public struct LJEOMHKJCIE : IEnumerator<DJFMEJMCAOI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly NativeList<DJFMEJMCAOI> ICPECNGAFCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private int HMJKJGLHFKE;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public DJFMEJMCAOI BHDIBOCECJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x43321B0", Offset = "0x43315B0", VA = "0x1843321B0", Slot = "4")]
			get
			{
				return default(DJFMEJMCAOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x4332170", Offset = "0x4331570", VA = "0x184332170", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x301E790", Offset = "0x301DB90", VA = "0x18301E790")]
		internal LJEOMHKJCIE(NativeList<DJFMEJMCAOI> OHCPCHAKDAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x4332030", Offset = "0x4331430", VA = "0x184332030", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4332130", Offset = "0x4331530", VA = "0x184332130", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	private struct JGOPJAPKFEG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private const int GEEBFMGLAAB = 0;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private const int PHJLENGJGLC = 1;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private const int HFMEAJAAMKP = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private NativeArray<int> PNMIIEJFOON;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool IGFHGDGAIFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x432F770", Offset = "0x432EB70", VA = "0x18432F770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public int AEIKBPOHIJG
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x432F640", Offset = "0x432EA40", VA = "0x18432F640")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x432F620", Offset = "0x432EA20", VA = "0x18432F620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public FPKDALGDECP HDJBANHLNFK
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x432F630", Offset = "0x432EA30", VA = "0x18432F630")]
			get
			{
				return default(FPKDALGDECP);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x432F6A0", Offset = "0x432EAA0", VA = "0x18432F6A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool IBNMDOGHEEM
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x432F740", Offset = "0x432EB40", VA = "0x18432F740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x432F6B0", Offset = "0x432EAB0", VA = "0x18432F6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool MGENHMIKHDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x432F650", Offset = "0x432EA50", VA = "0x18432F650")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x432F750", Offset = "0x432EB50", VA = "0x18432F750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x432F7B0", Offset = "0x432EBB0", VA = "0x18432F7B0")]
		public JGOPJAPKFEG(FPKDALGDECP BNFGINFPDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x432F6D0", Offset = "0x432EAD0", VA = "0x18432F6D0")]
		private int JLHLNIPLDNM(int FHAPAHAAKAH, int OEOLHKBIGOP = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x432F700", Offset = "0x432EB00", VA = "0x18432F700")]
		private void KNBGLHDOKIA(int FHAPAHAAKAH, int IGDJJEECDAF, int OEOLHKBIGOP = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x432F660", Offset = "0x432EA60", VA = "0x18432F660", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private const int OCLPBIIIHKK = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private const int BIMJKHAEEKE = 0;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly DJFMEJMCAOI HCFFHLLPDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private NativeHashMap<DJFMEJMCAOI, int> NFBDAIIDDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private NativeList<DJFMEJMCAOI> BMEDMCDHJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private NativeList<int> GPEFEBCIAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private NativeList<byte> JDNBCPLCODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private NativeList<byte> PNMIIEJFOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private JGOPJAPKFEG CNMIOIIAHLH;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool IBNMDOGHEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2890", Offset = "0x2BD1C90", VA = "0x182BD2890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool GLFKMGPGAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2870", Offset = "0x2BD1C70", VA = "0x182BD2870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int AEIKBPOHIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2190", Offset = "0x2BD1590", VA = "0x182BD2190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int LMAHJOEDDNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2BD2570", Offset = "0x2BD1970", VA = "0x182BD2570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool IGFHGDGAIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x2BD29D0", Offset = "0x2BD1DD0", VA = "0x182BD29D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2BD25B0", Offset = "0x2BD19B0", VA = "0x182BD25B0")]
	public static MHIDCLAHLFA FNICMNFMKAL(FPKDALGDECP BNFGINFPDCF = FPKDALGDECP.Last, int FMFDGAGNONG = 16, int BBMPNALDOAD = 256)
	{
		return default(MHIDCLAHLFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2D00", Offset = "0x2BD2100", VA = "0x182BD2D00")]
	private MHIDCLAHLFA(FPKDALGDECP BNFGINFPDCF, int FMFDGAGNONG, int BBMPNALDOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2490", Offset = "0x2BD1890", VA = "0x182BD2490", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2BD25F0", Offset = "0x2BD19F0", VA = "0x182BD25F0")]
	public FABMENIJLPF IOLCNKLJPDO(DJFMEJMCAOI KOEICPMBJFP)
	{
		return default(FABMENIJLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2010", Offset = "0x2BD1410", VA = "0x182BD2010")]
	public PAODEMHIKEL ACPPJCICEHA(DJFMEJMCAOI KOEICPMBJFP)
	{
		return default(PAODEMHIKEL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2680", Offset = "0x2BD1A80", VA = "0x182BD2680")]
	public bool JHJJOJDJODA(DJFMEJMCAOI KOEICPMBJFP, out PAODEMHIKEL JLIMLKIFDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2350", Offset = "0x2BD1750", VA = "0x182BD2350")]
	public bool CEBKNDBANAO(DJFMEJMCAOI KOEICPMBJFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2280", Offset = "0x2BD1680", VA = "0x182BD2280")]
	public bool BPCBGNPOFKG(DJFMEJMCAOI KOEICPMBJFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2BD28A0", Offset = "0x2BD1CA0", VA = "0x182BD28A0")]
	public void PBNJJJLGDLC(NativeList<byte> DJGPEPEBOGE, PFMPKBKACLC NLKAALKLBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x255FFF0", Offset = "0x255F3F0", VA = "0x18255FFF0")]
	public T GKJHPELBGMO<T>(DJFMEJMCAOI KOEICPMBJFP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2BD21A0", Offset = "0x2BD15A0", VA = "0x182BD21A0")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2990", Offset = "0x2BD1D90", VA = "0x182BD2990")]
	public LJEOMHKJCIE PEKBJENCCON()
	{
		return default(LJEOMHKJCIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2A10", Offset = "0x2BD1E10", VA = "0x182BD2A10")]
	private void PNOCKPPOMBA(DJFMEJMCAOI KOEICPMBJFP, int BKLFOLNGODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2BD20A0", Offset = "0x2BD14A0", VA = "0x182BD20A0")]
	private void BABNJGFMKJB(int PPENGGAAFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2BD23A0", Offset = "0x2BD17A0", VA = "0x182BD23A0")]
	private void DAGMJBOKEPE(DJFMEJMCAOI KOEICPMBJFP, int BKLFOLNGODN, int BFFLFOJBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2560180", Offset = "0x255F580", VA = "0x182560180")]
	private static T GKJHPELBGMO<T>(NativeArray<byte> ICPECNGAFCL, int FHAPAHAAKAH = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2C40", Offset = "0x2BD2040", VA = "0x182BD2C40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2C00", Offset = "0x2BD2000", VA = "0x182BD2C00", Slot = "4")]
	private IEnumerator<DJFMEJMCAOI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[Preserve]
internal sealed class CKGJEINDIMB<T> : LOFKNNMMOFJ where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private EntityQuery JHDPAHIHIEJ;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DAC0", Offset = "0x3A7CEC0", VA = "0x183A7DAC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x3A7DB50", Offset = "0x3A7CF50", VA = "0x183A7DB50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD250", Offset = "0x2BDC650", VA = "0x182BDD250")]
	public CKGJEINDIMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2BDCDD0", Offset = "0x2BDC1D0", VA = "0x182BDCDD0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	internal class CleanupRigidbodyExImpl : LOFKNNMMOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private EntityQuery JHDPAHIHIEJ;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2B875C0", Offset = "0x2B869C0", VA = "0x182B875C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2B87660", Offset = "0x2B86A60", VA = "0x182B87660", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Preserve]
internal class MOKMNBOFBAI : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private EntityQuery AJKNIGFPPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x29D7380", Offset = "0x29D6780", VA = "0x1829D7380", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x29D72B0", Offset = "0x29D66B0", VA = "0x1829D72B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x29D7340", Offset = "0x29D6740", VA = "0x1829D7340", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public MOKMNBOFBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
internal class NEFADPMCJAO : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private PropertyDiffStateService KIOLODANKMA;

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x29D77E0", Offset = "0x29D6BE0", VA = "0x1829D77E0", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x29D7770", Offset = "0x29D6B70", VA = "0x1829D7770", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public NEFADPMCJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private EntityQuery JHDPAHIHIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private SceneService EKPOPNOIBMD;

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x2B941F0", Offset = "0x2B935F0", VA = "0x182B941F0", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2B93D50", Offset = "0x2B93150", VA = "0x182B93D50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2B93DE0", Offset = "0x2B931E0", VA = "0x182B93DE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[NDGJMMLBLBO(typeof(CullingBandService), new string[] { })]
	[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	public class CullingBandService : LNLPIGELLPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly List<global::LAJJDKPAKGO<LAKFHPPCOBH>> MIGAEKBCKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIJOKICGGNE;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2B90B60", Offset = "0x2B8FF60", VA = "0x182B90B60", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2B90510", Offset = "0x2B8F910", VA = "0x182B90510")]
		public void ADHIOMIAFKF(global::LAJJDKPAKGO<LAKFHPPCOBH> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2B906F0", Offset = "0x2B8FAF0", VA = "0x182B906F0")]
		public void FLOEINEIEIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2B90580", Offset = "0x2B8F980", VA = "0x182B90580", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2B90C00", Offset = "0x2B90000", VA = "0x182B90C00")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	[NDGJMMLBLBO(typeof(PCBKHJEIBHN), new string[] { })]
	public class PhysicsService : LNLPIGELLPM, ENMEIFNEMLK, PCBKHJEIBHN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly DLHDGHMPCLG BJNOPGDKOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private EntityManager GKHNMAAJNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private NHLELLEJLGC KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private FFGAOMNGKBA BJMBDEEAFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private PropertyEventCallbacksService DJLHEMGEDMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private global::OHMGOCMDBOD<MADLJMCJGDI> AOLDEHIPDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool HIBODKPCONP;

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<MOLBNKBNJLI, MADLJMCJGDI> CKFDJEIIAKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x29EECF0", Offset = "0x29EE0F0", VA = "0x1829EECF0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x29EED90", Offset = "0x29EE190", VA = "0x1829EED90", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x29EEFB0", Offset = "0x29EE3B0", VA = "0x1829EEFB0", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x29EE820", Offset = "0x29EDC20", VA = "0x1829EE820", Slot = "5")]
		public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x29EEAC0", Offset = "0x29EDEC0", VA = "0x1829EEAC0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x29EEC20", Offset = "0x29EE020", VA = "0x1829EEC20", Slot = "8")]
		public bool HDDCMBCAFAK(MOLBNKBNJLI AFGGEMMDNNF, out Collider MPOAAHNPLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x29EEEF0", Offset = "0x29EE2F0", VA = "0x1829EEEF0")]
		private void NOKPIHCCOMM(Entity NOADJCMIKEF, EEJFBJIDABN FCLBEIEGADL, PEABCJAGJAH EMCJDFHKAFD, PEABCJAGJAH ADNCLAHHBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x29EEE30", Offset = "0x29EE230", VA = "0x1829EEE30", Slot = "9")]
		public void MBBNOLBCHCH(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[NDGJMMLBLBO(typeof(DJJJIFEINIH), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	public class RbexService : LNLPIGELLPM, DJJJIFEINIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private NHLELLEJLGC KIJOKICGGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private World KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private MCECGEJPKFL MDDDBPDMEKO;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		private EntityManager HDMAFEMIPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x29F6070", Offset = "0x29F5470", VA = "0x1829F6070")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x29F7420", Offset = "0x29F6820", VA = "0x1829F7420", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x29F5DB0", Offset = "0x29F51B0", VA = "0x1829F5DB0", Slot = "6")]
		public AEGKIDLHAJA JGBHDHEHFGA(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x29F69D0", Offset = "0x29F5DD0", VA = "0x1829F69D0", Slot = "5")]
		public void MGMHHNHDFDN(MOLBNKBNJLI AFGGEMMDNNF, AEGKIDLHAJA IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x29F60F0", Offset = "0x29F54F0", VA = "0x1829F60F0", Slot = "34")]
		public CollisionDetectionMode KCEJBPFKBBM(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x29F6520", Offset = "0x29F5920", VA = "0x1829F6520", Slot = "35")]
		public void KNKNFKHLCEF(MOLBNKBNJLI AFGGEMMDNNF, CollisionDetectionMode IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x29F7560", Offset = "0x29F6960", VA = "0x1829F7560", Slot = "36")]
		public CCMIJJFALNJ PGLMPPLFEFJ(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(CCMIJJFALNJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x29F5210", Offset = "0x29F4610", VA = "0x1829F5210", Slot = "37")]
		public void FOBBKEKHJFM(MOLBNKBNJLI AFGGEMMDNNF, CCMIJJFALNJ IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x29F59D0", Offset = "0x29F4DD0", VA = "0x1829F59D0", Slot = "38")]
		public bool IEKFCHLDIJH(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x29F50E0", Offset = "0x29F44E0", VA = "0x1829F50E0", Slot = "39")]
		public void FJEFBDJHFEA(MOLBNKBNJLI AFGGEMMDNNF, bool IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x29F4FF0", Offset = "0x29F43F0", VA = "0x1829F4FF0", Slot = "40")]
		public MOLBNKBNJLI FDDELAHPCJN(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x29F7310", Offset = "0x29F6710", VA = "0x1829F7310", Slot = "41")]
		public void OGKHJIFOKKE(MOLBNKBNJLI AFGGEMMDNNF, MOLBNKBNJLI IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x29F5D00", Offset = "0x29F5100", VA = "0x1829F5D00", Slot = "42")]
		public MOLBNKBNJLI IONCGDONMPM(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x29F52B0", Offset = "0x29F46B0", VA = "0x1829F52B0", Slot = "43")]
		public void GHJLFEJPDIG(MOLBNKBNJLI AFGGEMMDNNF, MOLBNKBNJLI IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x29F6700", Offset = "0x29F5B00", VA = "0x1829F6700", Slot = "7")]
		public void LJBOEABGKKO(MOLBNKBNJLI AFGGEMMDNNF, MOLBNKBNJLI IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x29F57A0", Offset = "0x29F4BA0", VA = "0x1829F57A0", Slot = "8")]
		public void HKBMMHHGPCM(MOLBNKBNJLI AFGGEMMDNNF, MOLBNKBNJLI IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x29F5B80", Offset = "0x29F4F80", VA = "0x1829F5B80", Slot = "9")]
		public int ILMDLNCPDGK(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x29F6AE0", Offset = "0x29F5EE0", VA = "0x1829F6AE0", Slot = "10")]
		public MOLBNKBNJLI MIMLOFNJLBE(MOLBNKBNJLI AFGGEMMDNNF, int HMJKJGLHFKE)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x29F49B0", Offset = "0x29F3DB0", VA = "0x1829F49B0", Slot = "11")]
		public void BNFICDHDHFK(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x29F6FB0", Offset = "0x29F63B0", VA = "0x1829F6FB0", Slot = "12")]
		public void NKAAOFHEALE(MOLBNKBNJLI AFGGEMMDNNF, object MJNGPHMPILM, MOLBNKBNJLI IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x29F4AA0", Offset = "0x29F3EA0", VA = "0x1829F4AA0", Slot = "13")]
		public void CEGLHOBONFL(MOLBNKBNJLI AFGGEMMDNNF, object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x29F71B0", Offset = "0x29F65B0", VA = "0x1829F71B0", Slot = "14")]
		public bool OGFBOMADFJI(MOLBNKBNJLI AFGGEMMDNNF, out MOLBNKBNJLI IGDJJEECDAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x29F53A0", Offset = "0x29F47A0", VA = "0x1829F53A0", Slot = "15")]
		public void GMFJAAJKEIN(MOLBNKBNJLI AFGGEMMDNNF, float3 IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x29F5640", Offset = "0x29F4A40", VA = "0x1829F5640", Slot = "16")]
		public bool HJFDFPKPHCE(MOLBNKBNJLI AFGGEMMDNNF, out float3 IGDJJEECDAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x29F61C0", Offset = "0x29F55C0", VA = "0x1829F61C0", Slot = "17")]
		public void KHCPLMFOPGA(MOLBNKBNJLI AFGGEMMDNNF, float3 IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x29F6CF0", Offset = "0x29F60F0", VA = "0x1829F6CF0", Slot = "18")]
		public bool NHPNNEAOFJN(MOLBNKBNJLI AFGGEMMDNNF, out float3 IGDJJEECDAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x29F6810", Offset = "0x29F5C10", VA = "0x1829F6810", Slot = "26")]
		public float3 LKNKIJCAKLD(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x29F4D20", Offset = "0x29F4120", VA = "0x1829F4D20", Slot = "27")]
		public void EDMDNMPOIKG(MOLBNKBNJLI AFGGEMMDNNF, float3 IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x29F54B0", Offset = "0x29F48B0", VA = "0x1829F54B0", Slot = "28")]
		public float GPPKHJEKDOH(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x29F4840", Offset = "0x29F3C40", VA = "0x1829F4840", Slot = "29")]
		public void AOFNDIGNFKF(MOLBNKBNJLI AFGGEMMDNNF, float IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x29F5A30", Offset = "0x29F4E30", VA = "0x1829F5A30", Slot = "30")]
		public float IFJLBPBJBFK(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x29F43F0", Offset = "0x29F37F0", VA = "0x1829F43F0", Slot = "31")]
		public void ACOBFNFKOJD(MOLBNKBNJLI AFGGEMMDNNF, float IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x29F6890", Offset = "0x29F5C90", VA = "0x1829F6890", Slot = "32")]
		public bool LLBPDJNDCFE(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x29F55D0", Offset = "0x29F49D0", VA = "0x1829F55D0", Slot = "33")]
		public void HIOLHBJLIBL(MOLBNKBNJLI AFGGEMMDNNF, bool IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x29F4BA0", Offset = "0x29F3FA0", VA = "0x1829F4BA0", Slot = "19")]
		public void CKMMNOBLMPN(MOLBNKBNJLI AFGGEMMDNNF, float3 IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x29F5F10", Offset = "0x29F5310", VA = "0x1829F5F10", Slot = "20")]
		public bool JJHFCDKFIGM(MOLBNKBNJLI AFGGEMMDNNF, out float3 IGDJJEECDAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x29F7600", Offset = "0x29F6A00", VA = "0x1829F7600", Slot = "21")]
		public void PHDKPGABPKI(MOLBNKBNJLI AFGGEMMDNNF, quaternion IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x29F4E90", Offset = "0x29F4290", VA = "0x1829F4E90", Slot = "22")]
		public bool FBGMBABMLAL(MOLBNKBNJLI AFGGEMMDNNF, out quaternion IGDJJEECDAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x29F6240", Offset = "0x29F5640", VA = "0x1829F6240", Slot = "23")]
		public bool KKMEJEPBFCB(MOLBNKBNJLI AFGGEMMDNNF, out float3 KJIEGLIKLHL, out quaternion EJINEGINNLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x29F5B20", Offset = "0x29F4F20", VA = "0x1829F5B20", Slot = "44")]
		public OMABPCEAJCN IJPAFMLEGPL(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(OMABPCEAJCN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x29F64B0", Offset = "0x29F58B0", VA = "0x1829F64B0", Slot = "45")]
		public void KNFCEHHBMBJ(MOLBNKBNJLI AFGGEMMDNNF, OMABPCEAJCN IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x29F4720", Offset = "0x29F3B20", VA = "0x1829F4720", Slot = "72")]
		public void AKJIKPNHPKB(MOLBNKBNJLI AFGGEMMDNNF, object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x29F5C70", Offset = "0x29F5070", VA = "0x1829F5C70", Slot = "73")]
		public void IMECHAPFLEI(MOLBNKBNJLI AFGGEMMDNNF, object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x29F65F0", Offset = "0x29F59F0", VA = "0x1829F65F0", Slot = "74")]
		public bool LELDDIDOPPC(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x29F5A90", Offset = "0x29F4E90", VA = "0x1829F5A90", Slot = "81")]
		public void IIELMECOFMH(MOLBNKBNJLI AFGGEMMDNNF, object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x29F74D0", Offset = "0x29F68D0", VA = "0x1829F74D0", Slot = "82")]
		public void PGDIHNPFNJD(MOLBNKBNJLI AFGGEMMDNNF, object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x29F4640", Offset = "0x29F3A40", VA = "0x1829F4640", Slot = "83")]
		public bool AFBDCGEAMAN(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x29F4C20", Offset = "0x29F4020", VA = "0x1829F4C20", Slot = "84")]
		public IEnumerable<object> DOKAECBBDKI(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x29F6090", Offset = "0x29F5490", VA = "0x1829F6090", Slot = "46")]
		public bool JNNMDBADNPM(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x29F7670", Offset = "0x29F6A70", VA = "0x1829F7670", Slot = "47")]
		public void PKDKPDJFPNK(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x29F5570", Offset = "0x29F4970", VA = "0x1829F5570", Slot = "48")]
		public bool HEFDIICBHGO(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x29F68F0", Offset = "0x29F5CF0", VA = "0x1829F68F0", Slot = "49")]
		public void LNCKEJMGDLP(MOLBNKBNJLI AFGGEMMDNNF, bool IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x29F51B0", Offset = "0x29F45B0", VA = "0x1829F51B0", Slot = "50")]
		public bool FLBHBLPOMFL(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x29F48B0", Offset = "0x29F3CB0", VA = "0x1829F48B0", Slot = "51")]
		public void BIIAMHHOOGD(MOLBNKBNJLI AFGGEMMDNNF, bool IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x29F6590", Offset = "0x29F5990", VA = "0x1829F6590", Slot = "52")]
		public RigidbodyConstraints LBOMNHAMJCE(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x29F4E20", Offset = "0x29F4220", VA = "0x1829F4E20", Slot = "53")]
		public void EIECFMLLKAN(MOLBNKBNJLI AFGGEMMDNNF, RigidbodyConstraints IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x29F70E0", Offset = "0x29F64E0", VA = "0x1829F70E0", Slot = "54")]
		public float NKIOLEKBFME(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x29F5070", Offset = "0x29F4470", VA = "0x1829F5070", Slot = "55")]
		public void FGLIBKCBNDC(MOLBNKBNJLI AFGGEMMDNNF, float IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x29F5150", Offset = "0x29F4550", VA = "0x1829F5150", Slot = "56")]
		public float FJEHIDNEHHA(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x29F5330", Offset = "0x29F4730", VA = "0x1829F5330", Slot = "57")]
		public void GHMEJGGOAJI(MOLBNKBNJLI AFGGEMMDNNF, float IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x29F6A80", Offset = "0x29F5E80", VA = "0x1829F6A80", Slot = "58")]
		public bool MHAIGPKAEGI(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x29F6960", Offset = "0x29F5D60", VA = "0x1829F6960", Slot = "59")]
		public void MAPFMMCCCLI(MOLBNKBNJLI AFGGEMMDNNF, bool IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x29F46C0", Offset = "0x29F3AC0", VA = "0x1829F46C0", Slot = "60")]
		public bool AGMFFCAPNBI(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x29F7140", Offset = "0x29F6540", VA = "0x1829F7140", Slot = "61")]
		public void ODNMICBPIHE(MOLBNKBNJLI AFGGEMMDNNF, bool IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x29F7830", Offset = "0x29F6C30", VA = "0x1829F7830", Slot = "62")]
		public int PPFCHCKGNOC(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x29F4B30", Offset = "0x29F3F30", VA = "0x1829F4B30", Slot = "63")]
		public void CFPJMNBDEAG(MOLBNKBNJLI AFGGEMMDNNF, int IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x29F47B0", Offset = "0x29F3BB0", VA = "0x1829F47B0", Slot = "64")]
		public Rigidbody ALOKOFCJCDE(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x29F76D0", Offset = "0x29F6AD0", VA = "0x1829F76D0", Slot = "65")]
		public void PLAFGLKANNP(MOLBNKBNJLI AFGGEMMDNNF, Rigidbody IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x29F7390", Offset = "0x29F6790", VA = "0x1829F7390", Slot = "75")]
		public void OPDIHGNGFPB(MOLBNKBNJLI AFGGEMMDNNF, object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x29F6670", Offset = "0x29F5A70", VA = "0x1829F6670", Slot = "76")]
		public void LGEDOMCACOD(MOLBNKBNJLI AFGGEMMDNNF, object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x29F4DA0", Offset = "0x29F41A0", VA = "0x1829F4DA0", Slot = "77")]
		public bool EGKAKJFFCLG(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x29F58B0", Offset = "0x29F4CB0", VA = "0x1829F58B0", Slot = "66")]
		public object HMEGLBKNJLB(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x29F6E50", Offset = "0x29F6250", VA = "0x1829F6E50", Slot = "67")]
		public void NIGIMFDNFPL(MOLBNKBNJLI AFGGEMMDNNF, object IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x29F5420", Offset = "0x29F4820", VA = "0x1829F5420", Slot = "68")]
		public object GPODPEDKDNJ(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x29F4460", Offset = "0x29F3860", VA = "0x1829F4460", Slot = "69")]
		public void AEJBGOHHKFO(MOLBNKBNJLI AFGGEMMDNNF, object IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x29F6C90", Offset = "0x29F6090", VA = "0x1829F6C90", Slot = "70")]
		public float NGCANPGMMFL(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x29F6150", Offset = "0x29F5550", VA = "0x1829F6150", Slot = "71")]
		public void KCHHHANJEOB(MOLBNKBNJLI AFGGEMMDNNF, float IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x29F4920", Offset = "0x29F3D20", VA = "0x1829F4920", Slot = "78")]
		public void BMBDBDPJCEK(MOLBNKBNJLI AFGGEMMDNNF, object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x29F5940", Offset = "0x29F4D40", VA = "0x1829F5940", Slot = "79")]
		public void IEDBDJMHHGJ(MOLBNKBNJLI AFGGEMMDNNF, object MJNGPHMPILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x29F45C0", Offset = "0x29F39C0", VA = "0x1829F45C0", Slot = "80")]
		public bool AELPHJGMHNJ(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x29F5510", Offset = "0x29F4910", VA = "0x1829F5510", Slot = "24")]
		public void HBOGKJILMLL(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x29F6C30", Offset = "0x29F6030", VA = "0x1829F6C30", Slot = "25")]
		public void NFCLFHHGNMP(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x3D823F0", Offset = "0x3D817F0", VA = "0x183D823F0")]
		private void LJJFAJODLCN<T>(MOLBNKBNJLI AFGGEMMDNNF, bool IGDJJEECDAF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x3D82440", Offset = "0x3D81840", VA = "0x183D82440")]
		private bool LOKMHJGAOAP<T>(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x3D815A0", Offset = "0x3D809A0", VA = "0x183D815A0")]
		private void GKDAOIMBAHJ<T>(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x3D821B0", Offset = "0x3D815B0", VA = "0x183D821B0")]
		private bool JCCFNCAKMBE<TC, TV>(MOLBNKBNJLI AFGGEMMDNNF, Func<TC, TV> GPLLJFGLBLN, out TV IGDJJEECDAF) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x3D81020", Offset = "0x3D80420", VA = "0x183D81020")]
		private bool JCCFNCAKMBE<T>(MOLBNKBNJLI AFGGEMMDNNF, out T IGDJJEECDAF) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x3D810A0", Offset = "0x3D804A0", VA = "0x183D810A0")]
		private T DBEJGMLJAPJ<T>(MOLBNKBNJLI AFGGEMMDNNF) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x3D81600", Offset = "0x3D80A00", VA = "0x183D81600")]
		private void HPJBMGOECBI<T>(MOLBNKBNJLI AFGGEMMDNNF, T IGDJJEECDAF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x3D81B50", Offset = "0x3D80F50", VA = "0x183D81B50")]
		private void IEECEJPHMLI<T>(MOLBNKBNJLI AFGGEMMDNNF, T IGDJJEECDAF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x3D81020", Offset = "0x3D80420", VA = "0x183D81020")]
		private bool FNGOIBMGGKC<T>(MOLBNKBNJLI AFGGEMMDNNF, out T IGDJJEECDAF) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x3D824A0", Offset = "0x3D818A0", VA = "0x183D824A0")]
		private T PNDHBINJEPC<T>(MOLBNKBNJLI AFGGEMMDNNF) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x3D81020", Offset = "0x3D80420", VA = "0x183D81020")]
		private void BHDIEFCNFCB<T>(MOLBNKBNJLI AFGGEMMDNNF, T IGDJJEECDAF) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x3D814F0", Offset = "0x3D808F0", VA = "0x183D814F0")]
		private void DHOBHBABFHO<T>(MOLBNKBNJLI AFGGEMMDNNF, T IGDJJEECDAF) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x29F6C00", Offset = "0x29F6000", VA = "0x1829F6C00")]
		private MOLBNKBNJLI MLGGEBHINBD(Entity NOADJCMIKEF)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x29F5E40", Offset = "0x29F5240", VA = "0x1829F5E40")]
		private DynamicBuffer<Entity> JHMEGAJDNML(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x3D82330", Offset = "0x3D81730", VA = "0x183D82330")]
		private void LHLMNOPBGJG<T>(MOLBNKBNJLI AFGGEMMDNNF, object IGDJJEECDAF, Func<object, T> GPLLJFGLBLN) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		private void KELJHIKJDOE<T>(ref global::PBPLGHILKPA<T> AOIGECIOMCP) where T : struct, IOPHLCGDAFI
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		private void KELJHIKJDOE<TC, TV>(ref global::GBMKOGAENAJ<TC, TV> AOIGECIOMCP) where TC : struct, IOPHLCGDAFI
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
	[NDGJMMLBLBO(typeof(KinematicSleepChangeService), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	public class KinematicSleepChangeService : LNLPIGELLPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class NFJGDLHGIGD : IEnumerable<AEGKIDLHAJA>, IEnumerable, IEnumerator<AEGKIDLHAJA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			private AEGKIDLHAJA <>2__current;

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
			private AEGKIDLHAJA System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004B9")]
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
			[DebuggerHidden]
			public NFJGDLHGIGD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x4333CF0", Offset = "0x43330F0", VA = "0x184333CF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004B7")]
			[Cpp2IlInjected.Address(RVA = "0x43339B0", Offset = "0x4332DB0", VA = "0x1843339B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004B8")]
			[Cpp2IlInjected.Address(RVA = "0x4333D70", Offset = "0x4333170", VA = "0x184333D70")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x4333CB0", Offset = "0x43330B0", VA = "0x184333CB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x4333C00", Offset = "0x4333000", VA = "0x184333C00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AEGKIDLHAJA> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0x4333C00", Offset = "0x4333000", VA = "0x184333C00", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> FNFIDMFCOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIJOKICGGNE;

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAD30", Offset = "0x2BCA130", VA = "0x182BCAD30", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA060", Offset = "0x2BC9460", VA = "0x182BCA060")]
		public void ADHIOMIAFKF(NativeArray<Entity> NPCFKLDOKOP, bool KJCBLHMGLAN, bool HFHPNDPNEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAA90", Offset = "0x2BC9E90", VA = "0x182BCAA90")]
		public void FLOEINEIEIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA180", Offset = "0x2BC9580", VA = "0x182BCA180")]
		private void AEDCNAPDFAJ(NativeArray<Entity> NPCFKLDOKOP, bool KJCBLHMGLAN, bool HFHPNDPNEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2BCACA0", Offset = "0x2BCA0A0", VA = "0x182BCACA0")]
		[IteratorStateMachine(typeof(NFJGDLHGIGD))]
		private IEnumerable<AEGKIDLHAJA> HCJNKFNDHDL(NativeArray<Entity> NPCFKLDOKOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x2BCA940", Offset = "0x2BC9D40", VA = "0x182BCA940", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x2BCADD0", Offset = "0x2BCA1D0", VA = "0x182BCADD0")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DefaultMember("Item")]
[NDGJMMLBLBO(typeof(FFMELNGKBPP), new string[] { })]
public class GFJOPHGACOK : FFMELNGKBPP, IEnumerable<FPGGICJALNG>, IEnumerable, GGFJAKOLADN, MCPGEGOMHPG, LNLPIGELLPM, ENMEIFNEMLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[HIGIANBBMBE]
	private MLABINPKFIE OEKBACMEEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly Dictionary<(Type, string), int> DCOKKHPDGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private DLPFOAPHCGJ JKEBNCGMFDM;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x2BBAA10", Offset = "0x2BB9E10", VA = "0x182BBAA10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public FPGGICJALNG HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA660", Offset = "0x2BB9A60", VA = "0x182BBA660", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public FPGGICJALNG HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA660", Offset = "0x2BB9A60", VA = "0x182BBA660", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA5F0", Offset = "0x2BB99F0", VA = "0x182BBA5F0", Slot = "11")]
	public void FFHOKNLNLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2BBADE0", Offset = "0x2BBA1E0", VA = "0x182BBADE0", Slot = "12")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "13")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAA30", Offset = "0x2BB9E30", VA = "0x182BBAA30")]
	private void NNAKIEKBPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x15B1B30", Offset = "0x15B0F30", VA = "0x1815B1B30")]
	private string NIEIIIAMOMD(string DHKKANIEGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA680", Offset = "0x2BB9A80", VA = "0x182BBA680", Slot = "7")]
	public FPGGICJALNG IIGGMLDNHEC(PCCBFFGCINK JLNILGJAKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA760", Offset = "0x2BB9B60", VA = "0x182BBA760")]
	private bool LBJOLDNBEEE(Type FPGLNAGBBFA, string DHKKANIEGMN, out FPGGICJALNG PKAAAJAKBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2BBACD0", Offset = "0x2BBA0D0", VA = "0x182BBACD0", Slot = "8")]
	public EEJFBJIDABN OCDLCKNINDE(PCCBFFGCINK JLNILGJAKJL)
	{
		return default(EEJFBJIDABN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA640", Offset = "0x2BB9A40", VA = "0x182BBA640", Slot = "9")]
	public IEnumerator<FPGGICJALNG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA640", Offset = "0x2BB9A40", VA = "0x182BBA640", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAE60", Offset = "0x2BBA260", VA = "0x182BBAE60")]
	public GFJOPHGACOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
[DefaultMember("Item")]
public interface PFMPKBKACLC
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADIAHNNFOHO(EEJFBJIDABN KDFBMFGPICB, out int DEBAMGFBJEH);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
[NDGJMMLBLBO(typeof(PFMPKBKACLC), new string[] { })]
public class NMHCFCDOIPJ : LNLPIGELLPM, ENMEIFNEMLK, PFMPKBKACLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[HIGIANBBMBE]
	private NLELCAEKFFF OEKBACMEEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly Dictionary<EEJFBJIDABN, int> AGCCPANIJNP;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public int HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x29D8730", Offset = "0x29D7B30", VA = "0x1829D8730", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x29D8440", Offset = "0x29D7840", VA = "0x1829D8440", Slot = "6")]
	public bool ADIAHNNFOHO(EEJFBJIDABN KDFBMFGPICB, out int DEBAMGFBJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x29D8790", Offset = "0x29D7B90", VA = "0x1829D8790", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x29D84B0", Offset = "0x29D78B0", VA = "0x1829D84B0", Slot = "5")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x29D84C0", Offset = "0x29D78C0", VA = "0x1829D84C0")]
	private void GOBHHDGGEAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x29D87F0", Offset = "0x29D7BF0", VA = "0x1829D87F0")]
	public NMHCFCDOIPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[NDGJMMLBLBO(typeof(NLELCAEKFFF), new string[] { })]
[DefaultMember("Item")]
public class EDNIANMFIOL : NLELCAEKFFF, IEnumerable<HECNDLCBEON>, IEnumerable, GGFJAKOLADN, MCPGEGOMHPG, LNLPIGELLPM, ENMEIFNEMLK, JPMGOPHCIKO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[HIGIANBBMBE]
	private FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[HIGIANBBMBE]
	private FFMELNGKBPP KLECKDCDMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private HECNDLCBEON[] JOHDLKAEOFL;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x2B94620", Offset = "0x2B93A20", VA = "0x182B94620", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public HECNDLCBEON HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x2B944B0", Offset = "0x2B938B0", VA = "0x182B944B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public HECNDLCBEON HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B944B0", Offset = "0x2B938B0", VA = "0x182B944B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "10")]
	public void FFHOKNLNLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x2B94700", Offset = "0x2B93B00", VA = "0x182B94700", Slot = "11")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "12")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2B944F0", Offset = "0x2B938F0", VA = "0x182B944F0", Slot = "6")]
	public HECNDLCBEON IIGGMLDNHEC(PCCBFFGCINK JLNILGJAKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2B94630", Offset = "0x2B93A30", VA = "0x182B94630", Slot = "7")]
	public EEJFBJIDABN OCDLCKNINDE(PCCBFFGCINK JLNILGJAKJL)
	{
		return default(EEJFBJIDABN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2B943D0", Offset = "0x2B937D0", VA = "0x182B943D0", Slot = "8")]
	public IEnumerator<HECNDLCBEON> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2B949A0", Offset = "0x2B93DA0", VA = "0x182B949A0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x26D4C70", Offset = "0x26D4070", VA = "0x1826D4C70", Slot = "13")]
	public void LMIGLAAPADK<TKey, T>(global::CGELFOKBEAG<TKey, T> PDLHECKEFMN, [Optional] object GKMHGIGLKCO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2B94290", Offset = "0x2B93690", VA = "0x182B94290", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public EDNIANMFIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2B944B0", Offset = "0x2B938B0", VA = "0x182B944B0")]
	[CompilerGenerated]
	private HECNDLCBEON HIEADMNDJOB(int FNHGJOONKOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[NDGJMMLBLBO(typeof(DNDLCINBGLP), new string[] { })]
[DefaultMember("Item")]
public class PGNECJNAFAH : DNDLCINBGLP, IEnumerable<MCLHOLCKNPA>, IEnumerable, LNLPIGELLPM, ENMEIFNEMLK, JPMGOPHCIKO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	[HIGIANBBMBE]
	private FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	[HIGIANBBMBE]
	private FFMELNGKBPP KLECKDCDMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private MCLHOLCKNPA[] JOHDLKAEOFL;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x29EAEF0", Offset = "0x29EA2F0", VA = "0x1829EAEF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public MCLHOLCKNPA HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x29EADC0", Offset = "0x29EA1C0", VA = "0x1829EADC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public MCLHOLCKNPA HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x29EADC0", Offset = "0x29EA1C0", VA = "0x1829EADC0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x29EB010", Offset = "0x29EA410", VA = "0x1829EB010", Slot = "9")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x29EA8D0", Offset = "0x29E9CD0", VA = "0x1829EA8D0", Slot = "10")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x29EABD0", Offset = "0x29E9FD0", VA = "0x1829EABD0")]
	private MCLHOLCKNPA GFGOHHEODIA(int HMJKJGLHFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x29EADD0", Offset = "0x29EA1D0", VA = "0x1829EADD0", Slot = "6")]
	public MCLHOLCKNPA IIGGMLDNHEC(PCCBFFGCINK JLNILGJAKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x29EAF40", Offset = "0x29EA340", VA = "0x1829EAF40", Slot = "14")]
	public EEJFBJIDABN OCDLCKNINDE(PCCBFFGCINK JLNILGJAKJL)
	{
		return default(EEJFBJIDABN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x29EACB0", Offset = "0x29EA0B0", VA = "0x1829EACB0", Slot = "7")]
	public IEnumerator<MCLHOLCKNPA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x29EACB0", Offset = "0x29EA0B0", VA = "0x1829EACB0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x1FD1D40", Offset = "0x1FD1140", VA = "0x181FD1D40", Slot = "11")]
	public void LMIGLAAPADK<TKey, T>(global::CGELFOKBEAG<TKey, T> PDLHECKEFMN, [Optional] object GKMHGIGLKCO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x29EAB30", Offset = "0x29E9F30", VA = "0x1829EAB30", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public PGNECJNAFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x29EADC0", Offset = "0x29EA1C0", VA = "0x1829EADC0")]
	[CompilerGenerated]
	private MCLHOLCKNPA HIEADMNDJOB(int FNHGJOONKOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
[NDGJMMLBLBO(typeof(MLABINPKFIE), new string[] { })]
internal class MLABINPKFIE : LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private FFMELNGKBPP KLECKDCDMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private DNDLCINBGLP IEELDDAHCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private NLELCAEKFFF NOLFBOBGOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private global::ECNCBCGDDPA<GAPCPBFJDMJ> FACBMGLIPGD;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public DLPFOAPHCGJ HICJJNPPOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x67F570", Offset = "0x67E970", VA = "0x18067F570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x67F590", Offset = "0x67E990", VA = "0x18067F590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x29D6C40", Offset = "0x29D6040", VA = "0x1829D6C40", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x29D68E0", Offset = "0x29D5CE0", VA = "0x1829D68E0")]
	private void EJLMLCLGHKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2566DA0", Offset = "0x25661A0", VA = "0x182566DA0")]
	public T DJJDFPKFNLE<T>() where T : GAPCPBFJDMJ
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x29D6AA0", Offset = "0x29D5EA0", VA = "0x1829D6AA0")]
	public FPGGICJALNG GMCBIMHEGHP(PCCBFFGCINK DHKKANIEGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	public global::OHMGOCMDBOD<T> GMCBIMHEGHP<T>(PCCBFFGCINK DHKKANIEGMN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x29D69D0", Offset = "0x29D5DD0", VA = "0x1829D69D0")]
	public MCLHOLCKNPA GEGFEIAINNH(PCCBFFGCINK DHKKANIEGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2566DD0", Offset = "0x25661D0", VA = "0x182566DD0")]
	public global::CKHIIFEFCFK<T> GEGFEIAINNH<T>(PCCBFFGCINK DHKKANIEGMN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x29D6B70", Offset = "0x29D5F70", VA = "0x1829D6B70")]
	public HECNDLCBEON NHEALDHBLCM(PCCBFFGCINK DHKKANIEGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	public global::KFJKPBJLMIA<T> NHEALDHBLCM<T>(PCCBFFGCINK DHKKANIEGMN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MLABINPKFIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
internal static class KIKCEDDMOJG
{
	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x25B5C30", Offset = "0x25B5030", VA = "0x1825B5C30")]
	public static global::OHMGOCMDBOD<T> GMCBIMHEGHP<T>(this MLABINPKFIE BPJKLBMMFFM, global::HEIJCHPBGLA<T> DHKKANIEGMN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	public static global::CKHIIFEFCFK<T> GEGFEIAINNH<T>(this MLABINPKFIE BPJKLBMMFFM, global::HEIJCHPBGLA<T> DHKKANIEGMN) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	public static global::KFJKPBJLMIA<T> NHEALDHBLCM<T>(this MLABINPKFIE BPJKLBMMFFM, global::HEIJCHPBGLA<T> DHKKANIEGMN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
[NDGJMMLBLBO(typeof(LDDCJNLPPBN), new string[] { })]
public class LDDCJNLPPBN : LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private CAOLOHBLMEA CGGANPEEADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private EEJFBJIDABN[] APEPPKCGBFM;

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD370", Offset = "0x2BCC770", VA = "0x182BCD370", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD250", Offset = "0x2BCC650", VA = "0x182BCD250")]
	public void JHAOJEHBMHM(JCHOAKCKPKK OMKLELDMIKD, bool LOIHHCHJGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public LDDCJNLPPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[NDGJMMLBLBO(typeof(HIJBMMLCGNI), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
public sealed class HIJBMMLCGNI : LNLPIGELLPM, ENMEIFNEMLK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class CEOLNPBLHKN : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x8EA410", Offset = "0x8E9810", VA = "0x1808EA410")]
		[DebuggerHidden]
		public CEOLNPBLHKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x432B290", Offset = "0x432A690", VA = "0x18432B290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x432AEE0", Offset = "0x432A2E0", VA = "0x18432AEE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x432B310", Offset = "0x432A710", VA = "0x18432B310")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x432B250", Offset = "0x432A650", VA = "0x18432B250", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x432B1C0", Offset = "0x432A5C0", VA = "0x18432B1C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x432B1C0", Offset = "0x432A5C0", VA = "0x18432B1C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private const string FEGEGOKLJPC = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<SerializableGuid, MDIMEGHCOPE> FAJALGPKIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly List<SerializableGuid> INIEIBIPOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly Dictionary<SerializableGuid, GameObject> EINHMHCOFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private DNDLCINBGLP OEKBACMEEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private LLOINIJEHPN GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private AMNPCKPOIGI BHJKPHAEBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private GDHFGEGLFMK BPDPPIDNPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private global::ODBJEBNEDIM<MDIMEGHCOPE> JLPJICJFFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GameObject GMHGAJCPJNG;

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF5C0", Offset = "0x2BBE9C0", VA = "0x182BBF5C0", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE0B0", Offset = "0x2BBD4B0", VA = "0x182BBE0B0", Slot = "5")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE280", Offset = "0x2BBD680", VA = "0x182BBE280", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE7B0", Offset = "0x2BBDBB0", VA = "0x182BBE7B0")]
	private void IHKLKBOFHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE9A0", Offset = "0x2BBDDA0", VA = "0x182BBE9A0")]
	internal void JFEGKLMAPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE7C0", Offset = "0x2BBDBC0", VA = "0x182BBE7C0")]
	private void IMCKAJMPMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDF60", Offset = "0x2BBD360", VA = "0x182BBDF60")]
	private void ADOLKILAIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2BBEF10", Offset = "0x2BBE310", VA = "0x182BBEF10")]
	[IteratorStateMachine(typeof(CEOLNPBLHKN))]
	private IEnumerable<RRCustomPropTag> NKEFIFKOKKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2BBEF60", Offset = "0x2BBE360", VA = "0x182BBEF60")]
	private void NKIIAIFOFFH(MOLBNKBNJLI AFGGEMMDNNF, in PEABCJAGJAH EIKDBDKEAPN, in PEABCJAGJAH NDKJFJECHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2BBEDD0", Offset = "0x2BBE1D0", VA = "0x182BBEDD0")]
	private void JGOJGDHNHPP(SerializableGuid NOCBJPFIBOM, GameObject FLFBOHHHJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE420", Offset = "0x2BBD820", VA = "0x182BBE420")]
	private void EFLMGAGJCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF3E0", Offset = "0x2BBE7E0", VA = "0x182BBF3E0")]
	private bool OAFDANFMOGM(MDIMEGHCOPE MDAHKDLIPMA, Transform JFCNGAACNEO, out GameObject AGBKKGEFEHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE060", Offset = "0x2BBD460", VA = "0x182BBE060")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF690", Offset = "0x2BBEA90", VA = "0x182BBF690")]
	public HIJBMMLCGNI()
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
		public SerializableGuid BNPOOEOJPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x699040", Offset = "0x698440", VA = "0x180699040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x29F4300", Offset = "0x29F3700", VA = "0x1829F4300")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[NDGJMMLBLBO(typeof(KMCNOEBNFPC), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
public class KMCNOEBNFPC : LNLPIGELLPM
{
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const string AKDMKHJMMIN = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private SceneService MEAJMIEKOFI;

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC91F0", Offset = "0x2BC85F0", VA = "0x182BC91F0", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public KMCNOEBNFPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
[NDGJMMLBLBO(typeof(FDFMGCPEEAN), new string[] { })]
public class FDFMGCPEEAN : LNLPIGELLPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[HIGIANBBMBE]
	private EnableComponentSystemsInScope LCGEPOALPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[HIGIANBBMBE]
	private SceneService MEAJMIEKOFI;

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7460", Offset = "0x2BB6860", VA = "0x182BB7460", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7420", Offset = "0x2BB6820", VA = "0x182BB7420", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7400", Offset = "0x2BB6800", VA = "0x182BB7400")]
	private void CEGDDFOFEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2BB73D0", Offset = "0x2BB67D0", VA = "0x182BB73D0")]
	private void ALHGODNGDFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public FDFMGCPEEAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[NDGJMMLBLBO(typeof(PENOFJBLKNM), new string[] { })]
public class HJJBIHHLMIN : LNLPIGELLPM, ENMEIFNEMLK, PENOFJBLKNM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private GONOMBLLIBK MIKBKPPJJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private LKDPEJPCDLD LBDABGCKAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private PropertyEventCallbacksService DJLHEMGEDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private LocalPlayerScopeSystem EJMEAECPCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private int BLCIGJMGFOP;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool HHOFJIGAILD
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x2BC07A0", Offset = "0x2BBFBA0", VA = "0x182BC07A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public MOLBNKBNJLI HNNKNJOMNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x2BC04D0", Offset = "0x2BBF8D0", VA = "0x182BC04D0", Slot = "9")]
		get
		{
			return default(MOLBNKBNJLI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0290", Offset = "0x2BBF690", VA = "0x182BC0290", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public MJBBCNDEMML CKFBCGLOBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF8B0", Offset = "0x2BBECB0", VA = "0x182BBF8B0", Slot = "11")]
		get
		{
			return default(MJBBCNDEMML);
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x2BC0290", Offset = "0x2BBF690", VA = "0x182BC0290", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public MJBBCNDEMML PALNJCBHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x2BC06E0", Offset = "0x2BBFAE0", VA = "0x182BC06E0", Slot = "13")]
		get
		{
			return default(MJBBCNDEMML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private uint CJONCLELNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF800", Offset = "0x2BBEC00", VA = "0x182BBF800")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event CEPFLCDDECN GNDKKHFOLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFDA0", Offset = "0x2BBF1A0", VA = "0x182BBFDA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x2BBFF50", Offset = "0x2BBF350", VA = "0x182BBFF50", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0840", Offset = "0x2BBFC40", VA = "0x182BC0840", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2BBFC00", Offset = "0x2BBF000", VA = "0x182BBFC00", Slot = "5")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x2BBFFF0", Offset = "0x2BBF3F0", VA = "0x182BBFFF0", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC02B0", Offset = "0x2BBF6B0", VA = "0x182BC02B0")]
	private void IMIOPAMCFHP(Entity NOADJCMIKEF, EEJFBJIDABN FCLBEIEGADL, PEABCJAGJAH EMCJDFHKAFD, PEABCJAGJAH ADNCLAHHBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2BBFE40", Offset = "0x2BBF240", VA = "0x182BBFE40", Slot = "14")]
	public MOLBNKBNJLI COKNPOLCDDK(MOLBNKBNJLI LMKFELFNIAK, MOLBNKBNJLI MHLBIJCJLAF)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2BBFB00", Offset = "0x2BBEF00", VA = "0x182BBFB00", Slot = "15")]
	public bool CIAEECBOFKJ(MOLBNKBNJLI LMKFELFNIAK, MOLBNKBNJLI MHLBIJCJLAF, out MOLBNKBNJLI CIAGICGLOHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2BBF970", Offset = "0x2BBED70", VA = "0x182BBF970", Slot = "16")]
	public void BCCCJKLJMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2BC04B0", Offset = "0x2BBF8B0", VA = "0x182BC04B0", Slot = "17")]
	public void JEGOPIAKPLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2BC00A0", Offset = "0x2BBF4A0", VA = "0x182BC00A0", Slot = "18")]
	public bool GBDIKABMDKM(MOLBNKBNJLI BCPKCLKDOEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0570", Offset = "0x2BBF970", VA = "0x182BC0570")]
	private void MMIPFJAGPIH(MOLBNKBNJLI HFLFDOALLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HJJBIHHLMIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[NDGJMMLBLBO(typeof(PHJMGMMMDFN), new string[] { })]
public class HODLJDLBFEM : LNLPIGELLPM, PHJMGMMMDFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private EntityManager GKHNMAAJNKF;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1340", Offset = "0x2BC0740", VA = "0x182BC1340", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2BC12D0", Offset = "0x2BC06D0", VA = "0x182BC12D0", Slot = "5")]
	public void FOJKIBDJLLI(MOLBNKBNJLI OACDBCDEFBJ, bool IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A390", Offset = "0x1F79790", VA = "0x181F7A390")]
	private void KNBGLHDOKIA<T>(MOLBNKBNJLI OACDBCDEFBJ, bool IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HODLJDLBFEM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[NDGJMMLBLBO(typeof(DIBCCIIGIIF), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.RenderEffects)]
	public class SelectionService : LNLPIGELLPM, DIBCCIIGIIF
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private EntityManager GKHNMAAJNKF;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4BD0", Offset = "0x2CA3FD0", VA = "0x182CA4BD0", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4AF0", Offset = "0x2CA3EF0", VA = "0x182CA4AF0", Slot = "5")]
		public void ILMDIKEOKGL(MOLBNKBNJLI OACDBCDEFBJ, bool IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4B60", Offset = "0x2CA3F60", VA = "0x182CA4B60", Slot = "6")]
		public void OCOJJNMGDLM(MOLBNKBNJLI OACDBCDEFBJ, bool IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A390", Offset = "0x1F79790", VA = "0x181F7A390")]
		private void KNBGLHDOKIA<T>(MOLBNKBNJLI OACDBCDEFBJ, bool IGDJJEECDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
[NDGJMMLBLBO(typeof(NKEEKCHEOPL), new string[] { })]
internal sealed class NKEEKCHEOPL : LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	[HIGIANBBMBE]
	private ObjectEmbodimentService EDKNHLFIHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[HIGIANBBMBE]
	private NHLELLEJLGC KIJOKICGGNE;

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x29D79D0", Offset = "0x29D6DD0", VA = "0x1829D79D0", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NKEEKCHEOPL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Serialization)]
	[NDGJMMLBLBO(typeof(WorldSerialization), new string[] { })]
	[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
	internal sealed class WorldSerialization : LNLPIGELLPM, CGEKNJCHDAC, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private static readonly DLHDGHMPCLG EDDAPCEJNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[HIGIANBBMBE]
		private GBCBOOEHEAG PLHAMBBHMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[HIGIANBBMBE]
		private LLOINIJEHPN GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[HIGIANBBMBE]
		private SerializationService BHJKPHAEBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[HIGIANBBMBE]
		private MINGLGEBPNG BMEDMCDHJAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[HIGIANBBMBE]
		private DebugWorldsService AFFAOJHFELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[HIGIANBBMBE]
		private BulkInstantiateSceneObjectService JAGNPANGJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private CLFAHLJOOKN IFCDDJDBLKM;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		private BPOMAKJFFCG BPBBMEAIPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000543")]
			[Cpp2IlInjected.Address(RVA = "0xCD6D40", Offset = "0xCD6140", VA = "0x180CD6D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9BF0", Offset = "0x2CB8FF0", VA = "0x182CB9BF0", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN OOALDKGGDMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8E40", Offset = "0x2CB8240", VA = "0x182CB8E40", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9D40", Offset = "0x2CB9140", VA = "0x182CB9D40", Slot = "6")]
		public bool PKPKHLOIGLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8E70", Offset = "0x2CB8270", VA = "0x182CB8E70", Slot = "7")]
		public bool EAPGKGEAPIP(IEnumerable<FANAPLKCHPF> HEBJGGPOLHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9260", Offset = "0x2CB8660", VA = "0x182CB9260", Slot = "5")]
		public ByteString KDJJNHBIKID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x2CB96F0", Offset = "0x2CB8AF0", VA = "0x182CB96F0")]
		private void LCGFKDBHLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8D70", Offset = "0x2CB8170", VA = "0x182CB8D70")]
		private void APIALLDKFGI(MBFACJCILKL AILDDPCONMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB9710", Offset = "0x2CB8B10", VA = "0x182CB9710")]
		private void LEDLOIFPDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8F80", Offset = "0x2CB8380", VA = "0x182CB8F80")]
		private void IEDELDGIIHC(JDNEAEGGDIG AILDDPCONMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8E90", Offset = "0x2CB8290", VA = "0x182CB8E90", Slot = "8")]
		public void GBPFFDAANPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8EE0", Offset = "0x2CB82E0", VA = "0x182CB8EE0")]
		private MBFACJCILKL HJOAEGJBJDL(EntityManager LINAKECBAOI, EntityManager MDOCLMBGOPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[NDGJMMLBLBO(typeof(ELKJIELAAEA), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
public class ELKJIELAAEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly Dictionary<EOLBHDKIGHE, string> INCNJPLPBDF;

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2B952B0", Offset = "0x2B946B0", VA = "0x182B952B0")]
	public GameObject IAPNFLADAFK(EOLBHDKIGHE DNIMECBIKOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2B95380", Offset = "0x2B94780", VA = "0x182B95380")]
	public ELKJIELAAEA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	[NDGJMMLBLBO(typeof(TimeService), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	public class TimeService : MCPGEGOMHPG, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[HIGIANBBMBE]
		private SingletonComponentService HACPNEEHEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private bool ABKNHOAJDMC;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public TimeData IFLDGIEJEEO
		{
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x2CAC400", Offset = "0x2CAB800", VA = "0x182CAC400")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x2CAC530", Offset = "0x2CAB930", VA = "0x182CAC530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool HPGGPPIDEGO
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x6928D0", Offset = "0x691CD0", VA = "0x1806928D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x6B4000", Offset = "0x6B3400", VA = "0x1806B4000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x15A3710", Offset = "0x15A2B10", VA = "0x1815A3710", Slot = "4")]
		public void FFHOKNLNLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC5B0", Offset = "0x2CAB9B0", VA = "0x182CAC5B0", Slot = "5")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2CAC470", Offset = "0x2CAB870", VA = "0x182CAC470")]
		public void NFFFJODGOIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[JLJFNDDLCBO(CBGNDNDJKHL.TransformSyncing)]
	[NDGJMMLBLBO(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
	internal class SetTransformParentIfParentPropertyChanges : LNLPIGELLPM, ENMEIFNEMLK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private KAPLNDGMNPC EDICDNMPJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private global::OHMGOCMDBOD<Entity> JFCNGAACNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private ObjectEmbodimentService LIBFGCDLBNG;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8890", Offset = "0x2CA7C90", VA = "0x182CA8890", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8580", Offset = "0x2CA7980", VA = "0x182CA8580", Slot = "5")]
		public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2CA86B0", Offset = "0x2CA7AB0", VA = "0x182CA86B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8750", Offset = "0x2CA7B50", VA = "0x182CA8750")]
		private void LKNJGPIKEIK(Entity NOADJCMIKEF, in PEABCJAGJAH EIKDBDKEAPN, in PEABCJAGJAH NDKJFJECHPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Services)]
	[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
	[NDGJMMLBLBO(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	public class EnableTransmissionOnlyInLoadInstance : LNLPIGELLPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[HIGIANBBMBE]
		private NPOFHBIKFNM NCFLAPIBDMB;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private EJMBECLPMOF OOFIMKKCEGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0x2B980F0", Offset = "0x2B974F0", VA = "0x182B980F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		private PFJFMCDJAOF ANHLJDKAPOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x2B98080", Offset = "0x2B97480", VA = "0x182B98080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2B98140", Offset = "0x2B97540", VA = "0x182B98140", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2B980D0", Offset = "0x2B974D0", VA = "0x182B980D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
[NDGJMMLBLBO(typeof(AAIJAKKGEMA), new string[] { })]
public class AAIJAKKGEMA : AHNBHABGBNB, GGFJAKOLADN, MCPGEGOMHPG, LNLPIGELLPM, ENMEIFNEMLK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class DGFMLLMMMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public CLFAHLJOOKN services;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public DGFMLLMMMDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E5A0", Offset = "0x2C9D9A0", VA = "0x182C9E5A0")]
		internal void <InitReferences>b__0(LNLPIGELLPM svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class OMAJALPBCBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public CLFAHLJOOKN services;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public OMAJALPBCBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA25A0", Offset = "0x2CA19A0", VA = "0x182CA25A0")]
		internal void <InitExternal>b__0(ENMEIFNEMLK svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	[HIGIANBBMBE]
	private NHLELLEJLGC KIJOKICGGNE;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public IONFNBCFBFH GKFCHINCBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x8C94C0", Offset = "0x8C88C0", VA = "0x1808C94C0", Slot = "4")]
		get
		{
			return default(IONFNBCFBFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private FBFMDKPKBLB GEMNOHGEBLC
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x2B7BD10", Offset = "0x2B7B110", VA = "0x182B7BD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B980", Offset = "0x2B7AD80", VA = "0x182B7B980", Slot = "5")]
	public void APMAKEGPFLO(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BBE0", Offset = "0x2B7AFE0", VA = "0x182B7BBE0", Slot = "6")]
	public void FFHOKNLNLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BD60", Offset = "0x2B7B160", VA = "0x182B7BD60", Slot = "7")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B9D0", Offset = "0x2B7ADD0", VA = "0x182B7B9D0", Slot = "8")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BAB0", Offset = "0x2B7AEB0", VA = "0x182B7BAB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x15D51E0", Offset = "0x15D45E0", VA = "0x1815D51E0")]
	private void HINIEPNAPIC<T>(Action<T> FLGGFOBECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public AAIJAKKGEMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class GFJFHELKBKO<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private readonly Func<From, To> GPNBAJLFPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private readonly Func<To, From> KOKNBHPJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public DynamicBuffer<From> CCBBJEPJPEO;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public To HIMPFAAIFFL
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
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool DMJNBBKFGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	public GFJFHELKBKO(Func<From, To> GPNBAJLFPAC, Func<To, From> KOKNBHPJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] ICPECNGAFCL, int LMNNOEJODCP)
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
	public int IndexOf(To BKADPMHNDEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int HMJKJGLHFKE, To BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int HMJKJGLHFKE)
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
public class NOIFEKEJCJD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private readonly Func<From, To> GPNBAJLFPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly Func<To, From> KOKNBHPJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public List<From> MOBONMBAIDJ;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x39D4C80", Offset = "0x39D4080", VA = "0x1839D4C80", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x39D4CE0", Offset = "0x39D40E0", VA = "0x1839D4CE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x39D4C50", Offset = "0x39D4050", VA = "0x1839D4C50", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool DMJNBBKFGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x768F80", Offset = "0x768380", VA = "0x180768F80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x732170", Offset = "0x731570", VA = "0x180732170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x27ED320", Offset = "0x27EC720", VA = "0x1827ED320")]
	public NOIFEKEJCJD(Func<From, To> GPNBAJLFPAC, Func<To, From> KOKNBHPJDNK, bool MFAHGLHJJKF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x39D48A0", Offset = "0x39D3CA0", VA = "0x1839D48A0", Slot = "11")]
	public void Add(To BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x3892340", Offset = "0x3891740", VA = "0x183892340", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x39D4900", Offset = "0x39D3D00", VA = "0x1839D4900", Slot = "13")]
	public bool Contains(To BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x39D4960", Offset = "0x39D3D60", VA = "0x1839D4960", Slot = "14")]
	public void CopyTo(To[] ICPECNGAFCL, int LMNNOEJODCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x39D4A70", Offset = "0x39D3E70", VA = "0x1839D4A70", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x39D4AE0", Offset = "0x39D3EE0", VA = "0x1839D4AE0", Slot = "6")]
	public int IndexOf(To BKADPMHNDEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x39D4B40", Offset = "0x39D3F40", VA = "0x1839D4B40", Slot = "7")]
	public void Insert(int HMJKJGLHFKE, To BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x39D4BF0", Offset = "0x39D3FF0", VA = "0x1839D4BF0", Slot = "15")]
	public bool Remove(To BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x39D4BC0", Offset = "0x39D3FC0", VA = "0x1839D4BC0", Slot = "8")]
	public void RemoveAt(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x28E3730", Offset = "0x28E2B30", VA = "0x1828E3730", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DefaultMember("Item")]
public class AMPEGGJADPM<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private readonly Func<From, To> GPNBAJLFPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Func<To, From> KOKNBHPJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeArray<From> ICPECNGAFCL;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x31021D0", Offset = "0x31015D0", VA = "0x1831021D0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x3102220", Offset = "0x3101620", VA = "0x183102220", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x3102190", Offset = "0x3101590", VA = "0x183102190", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool DMJNBBKFGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x699020", Offset = "0x698420", VA = "0x180699020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x296B610", Offset = "0x296AA10", VA = "0x18296B610")]
	public AMPEGGJADPM(Func<From, To> GPNBAJLFPAC, Func<To, From> KOKNBHPJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x3101DA0", Offset = "0x31011A0", VA = "0x183101DA0", Slot = "11")]
	public void Add(To BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x3101DE0", Offset = "0x31011E0", VA = "0x183101DE0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x3101E20", Offset = "0x3101220", VA = "0x183101E20", Slot = "13")]
	public bool Contains(To BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x3101EE0", Offset = "0x31012E0", VA = "0x183101EE0", Slot = "14")]
	public void CopyTo(To[] ICPECNGAFCL, int LMNNOEJODCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x3101FA0", Offset = "0x31013A0", VA = "0x183101FA0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x3102060", Offset = "0x3101460", VA = "0x183102060", Slot = "6")]
	public int IndexOf(To BKADPMHNDEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x31020D0", Offset = "0x31014D0", VA = "0x1831020D0", Slot = "7")]
	public void Insert(int HMJKJGLHFKE, To BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x3102150", Offset = "0x3101550", VA = "0x183102150", Slot = "15")]
	public bool Remove(To BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x3102110", Offset = "0x3101510", VA = "0x183102110", Slot = "8")]
	public void RemoveAt(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x1BA1ED0", Offset = "0x1BA12D0", VA = "0x181BA1ED0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class HLAOMKNHENJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly Func<From, To> GPNBAJLFPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly Func<To, From> KOKNBHPJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeList<From> MOBONMBAIDJ;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To HIMPFAAIFFL
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
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool DMJNBBKFGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	public HLAOMKNHENJ(Func<From, To> GPNBAJLFPAC, Func<To, From> KOKNBHPJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] ICPECNGAFCL, int LMNNOEJODCP)
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
	public int IndexOf(To BKADPMHNDEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int HMJKJGLHFKE, To BKADPMHNDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To BKADPMHNDEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int HMJKJGLHFKE)
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
public static class IEIIADDNMOM
{
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public const string KNMCLNFHFAK = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public const string ICKLIKNBIIC = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public const string BBJIJNNMPFE = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public const string LPBCKIAEJLN = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public const string HNCFPHFNCHH = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public const string JIIFCKLMGIJ = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public const string DEFEFCDBHBN = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public const string EGOPNBBFAEI = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class IENEJIFFJGP
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class KDBNMMKGFCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public CLFAHLJOOKN services;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public KDBNMMKGFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x4330110", Offset = "0x432F510", VA = "0x184330110")]
		internal void <InitServices>b__1(LNLPIGELLPM svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x4330170", Offset = "0x432F570", VA = "0x184330170")]
		internal void <InitServices>b__2(ENMEIFNEMLK svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3A10", Offset = "0x2BC2E10", VA = "0x182BC3A10")]
	public static void FLOELNHEEGN(this FBFMDKPKBLB KIEEJCIFMFE, CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F3A0", Offset = "0x1F7E7A0", VA = "0x181F7F3A0")]
	public static void HINIEPNAPIC<T>(this FBFMDKPKBLB KIEEJCIFMFE, Action<T> FLGGFOBECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F090", Offset = "0x1F7E490", VA = "0x181F7F090")]
	public static void FAHGJBELHBI<T>(this FBFMDKPKBLB KIEEJCIFMFE, Action<T> FLGGFOBECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EEE0", Offset = "0x1F7E2E0", VA = "0x181F7EEE0")]
	public static void DLFHECKDNBP<T>(this FBFMDKPKBLB KIEEJCIFMFE, Action<T> FLGGFOBECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F4D0", Offset = "0x1F7E8D0", VA = "0x181F7F4D0")]
	public static void PNIPNMBIMOE<T>(this FBFMDKPKBLB KIEEJCIFMFE, Action<T> FLGGFOBECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F7ED30", Offset = "0x1F7E130", VA = "0x181F7ED30")]
	public static void BBGAAHCNPBF<T>(this FBFMDKPKBLB KIEEJCIFMFE, Action<T> FLGGFOBECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F230", Offset = "0x1F7E630", VA = "0x181F7F230")]
	public static void FAHGJBELHBI<T>(IEnumerable<ComponentSystemBase> FCGMOLCPBPL, Action<T> FLGGFOBECBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F410", Offset = "0x1F7E810", VA = "0x181F7F410")]
	private static void HOGCCAKFPGN<T>(object PLEONGBKEBJ, Action<T> FLGGFOBECBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class OABCIHGCJCF
{
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class NGNIGGHPOLM
{
	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x29D7830", Offset = "0x29D6C30", VA = "0x1829D7830")]
	public static void FLJOIEAKJEH(ComponentSystemBase PLEONGBKEBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class IKGBBKLDJNN
{
	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	public static bool DKIINAMGGNL<T>(ref T GHJDMBPGMHF, ref T IKDBBHHKFLJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class FLEOCNNECKL
{
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class ICPKAIDDBIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ICPKAIDDBIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7E50", Offset = "0x2BB7250", VA = "0x182BB7E50")]
	public static string FKGIICKDLLG(Transform KFAGMEKKLDA, Transform BCPKCLKDOEP)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7660", Offset = "0x2CA6A60", VA = "0x182CA7660")]
		public static void FOLCGPFLFII(this PMJCGABOKOD IFCDDJDBLKM, PIBKLBMCIOB AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7A50", Offset = "0x2CA6E50", VA = "0x182CA7A50")]
		public static void KMCCCGJHPNL(this PMJCGABOKOD IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7550", Offset = "0x2CA6950", VA = "0x182CA7550")]
		public static void FOLCGPFLFII(this PMJCGABOKOD IFCDDJDBLKM, [Optional] string[] JOINEOPLJGC, [Optional] string[] DMDAGLMLJDG, [Optional] string[] CJNNPLCFOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7C00", Offset = "0x2CA7000", VA = "0x182CA7C00")]
		public static void LGJCDIGLFLB(this PMJCGABOKOD IFCDDJDBLKM, params string[] KPDAFMMAONF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7B50", Offset = "0x2CA6F50", VA = "0x182CA7B50")]
		public static void LABAANBIAFF(this PMJCGABOKOD IFCDDJDBLKM, params string[] KPDAFMMAONF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7350", Offset = "0x2CA6750", VA = "0x182CA7350")]
		private static string[] BKCBOLPEAMI(PIBKLBMCIOB AOFGAGALOCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7890", Offset = "0x2CA6C90", VA = "0x182CA7890")]
		private static bool ILLFNKEKBCA(PIBKLBMCIOB AOFGAGALOCP, out string[] AOMNKEJHPBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00")]
		private static bool PCBIMHMGKFG()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public abstract class BEKGFDFDNEH : CMGNOKEPMHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly MethodInfo PNMKJBKGHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly Type[] MMLIFJCNOMF;

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x2B7FBC0", Offset = "0x2B7EFC0", VA = "0x182B7FBC0")]
	public BEKGFDFDNEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action EOKFGMPKMJG();

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x2B7FB80", Offset = "0x2B7EF80", VA = "0x182B7FB80")]
	public MethodInfo LCICLKOHAAL(Action LECDCDLGAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F9D0", Offset = "0x2B7EDD0", VA = "0x182B7F9D0", Slot = "4")]
	public void JGOJGDHNHPP(Type FPPBLNEEHBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public abstract class PEBBEGHPJEE : BEKGFDFDNEH
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private enum JHHGPMMJNIC
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x29EA6D0", Offset = "0x29E9AD0", VA = "0x1829EA6D0", Slot = "5")]
	public override Action EOKFGMPKMJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void NPKOKGBAKIG<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x29EA760", Offset = "0x29E9B60", VA = "0x1829EA760")]
	[Preserve]
	public void FKCCMEBAEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x29DB5F0", Offset = "0x29DA9F0", VA = "0x1829DB5F0")]
	protected PEBBEGHPJEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class OGPIKFDFEMG : BEKGFDFDNEH
{
	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x29DB4D0", Offset = "0x29DA8D0", VA = "0x1829DB4D0", Slot = "5")]
	public override Action EOKFGMPKMJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void DLHILNJOAOF<T>() where T : PIFGLOGIBDL;

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x29DB560", Offset = "0x29DA960", VA = "0x1829DB560")]
	[Preserve]
	public void FKCCMEBAEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x29DB5F0", Offset = "0x29DA9F0", VA = "0x1829DB5F0")]
	protected OGPIKFDFEMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class DBPCBHAKDOL : BEKGFDFDNEH
{
	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x2B90D60", Offset = "0x2B90160", VA = "0x182B90D60", Slot = "5")]
	public override Action EOKFGMPKMJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void EKDOFNEOGHJ<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0x2B90DF0", Offset = "0x2B901F0", VA = "0x182B90DF0")]
	[Preserve]
	public void FKCCMEBAEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x2B7FBC0", Offset = "0x2B7EFC0", VA = "0x182B7FBC0")]
	protected DBPCBHAKDOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public static class EHJIBJMPKAB
{
	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x2B94F50", Offset = "0x2B94350", VA = "0x182B94F50")]
	public static Entity JPCNCPGAKKF(this EntityManager GKHNMAAJNKF)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[JLJFNDDLCBO(CBGNDNDJKHL.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A2")]
		[CompilerGenerated]
		private sealed class GJEHCBPIPJC : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x24E8F80", Offset = "0x24E8380", VA = "0x1824E8F80", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2C9EBB0", Offset = "0x2C9DFB0", VA = "0x182C9EBB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EC00", Offset = "0x2C9E000", VA = "0x182C9EC00")]
			[DebuggerHidden]
			public GJEHCBPIPJC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x2C9E9E0", Offset = "0x2C9DDE0", VA = "0x182C9E9E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EB70", Offset = "0x2C9DF70", VA = "0x182C9EB70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EAC0", Offset = "0x2C9DEC0", VA = "0x182C9EAC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EAC0", Offset = "0x2C9DEC0", VA = "0x182C9EAC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class OHPHBOBDBOB : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x24E8F80", Offset = "0x24E8380", VA = "0x1824E8F80", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2CA2470", Offset = "0x2CA1870", VA = "0x182CA2470", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EC00", Offset = "0x2C9E000", VA = "0x182C9EC00")]
			[DebuggerHidden]
			public OHPHBOBDBOB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x2CA24C0", Offset = "0x2CA18C0", VA = "0x182CA24C0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2190", Offset = "0x2CA1590", VA = "0x182CA2190", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2550", Offset = "0x2CA1950", VA = "0x182CA2550")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2430", Offset = "0x2CA1830", VA = "0x182CA2430", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2380", Offset = "0x2CA1780", VA = "0x182CA2380", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2380", Offset = "0x2CA1780", VA = "0x182CA2380", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class NAGBABNECNO : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x24E8F80", Offset = "0x24E8380", VA = "0x1824E8F80", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x2CA1EF0", Offset = "0x2CA12F0", VA = "0x182CA1EF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EC00", Offset = "0x2C9E000", VA = "0x182C9EC00")]
			[DebuggerHidden]
			public NAGBABNECNO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x2CA1F40", Offset = "0x2CA1340", VA = "0x182CA1F40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x2CA1AE0", Offset = "0x2CA0EE0", VA = "0x182CA1AE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2010", Offset = "0x2CA1410", VA = "0x182CA2010")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2060", Offset = "0x2CA1460", VA = "0x182CA2060")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x2CA1EB0", Offset = "0x2CA12B0", VA = "0x182CA1EB0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x2CA1E10", Offset = "0x2CA1210", VA = "0x182CA1E10", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x2CA1E10", Offset = "0x2CA1210", VA = "0x182CA1E10", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AA20", Offset = "0x2B99E20", VA = "0x182B9AA20")]
		public static Entity EOELABBDKKM(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AF90", Offset = "0x2B9A390", VA = "0x182B9AF90")]
		public static DynamicBuffer<ChildrenData> GMLOFCPKLNK(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B950", Offset = "0x2B9AD50", VA = "0x182B9B950")]
		public static DynamicBuffer<ChildrenData> NKJMCAFFKDP(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B1B0", Offset = "0x2B9A5B0", VA = "0x182B9B1B0")]
		public static NativeArray<Entity> LBAPKAOCLBA(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, Allocator JLPBABJNDBH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AE10", Offset = "0x2B9A210", VA = "0x182B9AE10")]
		public static bool FPIGPMDDMED(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, Allocator JLPBABJNDBH, out NativeArray<Entity> GJJOJNKJNAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A4E0", Offset = "0x2B998E0", VA = "0x182B9A4E0")]
		public static NativeArray<Entity> AAFLPOFLIJP(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B790", Offset = "0x2B9AB90", VA = "0x182B9B790")]
		public static Entity MIMLOFNJLBE(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, int HMJKJGLHFKE)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B0A0", Offset = "0x2B9A4A0", VA = "0x182B9B0A0")]
		public static int ILMDLNCPDGK(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B420", Offset = "0x2B9A820", VA = "0x182B9B420")]
		public static void MBCPDPJKNEI(NativeArray<Entity> INBNACIKDKM, NativeArray<Entity> HEIHGIHIMEK, EntityManager GKHNMAAJNKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BC70", Offset = "0x2B9B070", VA = "0x182B9BC70")]
		public static int PGLHGMMCAMM(this EntityManager GKHNMAAJNKF, Entity JFCNGAACNEO, Entity JKAAFIAPPME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A8C0", Offset = "0x2B99CC0", VA = "0x182B9A8C0")]
		public static bool DJJKFGBLEGJ(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, Entity BFMALIMGJBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B680", Offset = "0x2B9AA80", VA = "0x182B9B680")]
		public static IEnumerable<Entity> MCPDDLPGDOL(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, bool MHPOMONJNNI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B2E0", Offset = "0x2B9A6E0", VA = "0x182B9B2E0")]
		public static bool LLKINPIFLGK(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, Entity JKAAFIAPPME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B020", Offset = "0x2B9A420", VA = "0x182B9B020")]
		public static bool HAFGFLCKEOI(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, Entity LMKFELFNIAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B9E0", Offset = "0x2B9ADE0", VA = "0x182B9B9E0")]
		public static NativeList<Entity> NMNKBDFLFAK(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, bool MHPOMONJNNI = false, Allocator JLPBABJNDBH = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AB90", Offset = "0x2B99F90", VA = "0x182B9AB90")]
		public static IEnumerable<Entity> FGNCMEHEPDA(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, bool MHPOMONJNNI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AA90", Offset = "0x2B99E90", VA = "0x182B9AA90")]
		public static Entity FDDELAHPCJN(this EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A720", Offset = "0x2B99B20", VA = "0x182B9A720")]
		public static bool CIAEECBOFKJ(this EntityManager GKHNMAAJNKF, Entity LMKFELFNIAK, Entity MHLBIJCJLAF, out Entity CIAGICGLOHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x2B9BBF0", Offset = "0x2B9AFF0", VA = "0x182B9BBF0")]
		internal static void OCLHLHNNIAJ(EntityManager GKHNMAAJNKF, Entity JFCNGAACNEO, Entity JKAAFIAPPME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AD10", Offset = "0x2B9A110", VA = "0x182B9AD10")]
		internal static void FOHFOELGGOO(EntityManager GKHNMAAJNKF, Entity JFCNGAACNEO, Entity JKAAFIAPPME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B8C0", Offset = "0x2B9ACC0", VA = "0x182B9B8C0")]
		[IteratorStateMachine(typeof(GJEHCBPIPJC))]
		private static IEnumerable<Entity> NIDMJONDCDC(EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, bool MHPOMONJNNI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x2B9B390", Offset = "0x2B9A790", VA = "0x182B9B390")]
		[IteratorStateMachine(typeof(OHPHBOBDBOB))]
		private static IEnumerable<Entity> LPIBPMDIDLM(EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, bool MHPOMONJNNI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x2B9AF10", Offset = "0x2B9A310", VA = "0x182B9AF10")]
		[IteratorStateMachine(typeof(NAGBABNECNO))]
		private static IEnumerable<Entity> GGGADMHLGCE(EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A640", Offset = "0x2B99A40", VA = "0x182B9A640")]
		private static bool BOCJCBHHJBH(EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, Entity BFMALIMGJBJ)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[NDGJMMLBLBO(typeof(APFPCLEOLKC), new string[] { })]
public class OJJJNLCOFHJ : APFPCLEOLKC, AHNBHABGBNB, MCAGGOKLPEK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private CLFAHLJOOKN IFCDDJDBLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private LLOINIJEHPN GEEOPHADFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private GBCBOOEHEAG PLHAMBBHMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private EAEIHBAGMAO JOGJFLEFHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private GONOMBLLIBK MIKBKPPJJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private KAPLNDGMNPC EDICDNMPJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private ACFOFFHKLLK BHJKPHAEBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private HGMEOMFEGBD CAIKFPBEKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private DNDLCINBGLP OEKBACMEEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private MJMALLMJACO BKAPMIMEAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private LHKNIMEJMPF HIDNMPKKGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private PENOFJBLKNM JLIMLKIFDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private PAIHKGLKBFJ NPNAEFOFPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private PCBKHJEIBHN JMNJCBELACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private PHJMGMMMDFN IDOKKODNEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private DIBCCIIGIIF KLLMKANEGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private DGKMBHEFMLJ NJJGAODELDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private MBFAONBDNHH BILBONHPOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private DJJJIFEINIH BCFNKEDGEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public CLFAHLJOOKN NDOKDKDNGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public LLOINIJEHPN JGFGAHEDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public NHLELLEJLGC GEMNOHGEBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public GBCBOOEHEAG ANKMKOMJLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public EAEIHBAGMAO BCOENIFILMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public FOKCOLGHCMD NHJFLKKBDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x67F570", Offset = "0x67E970", VA = "0x18067F570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public GONOMBLLIBK HHMAHAKHJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x67F580", Offset = "0x67E980", VA = "0x18067F580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public KAPLNDGMNPC JLJIEEENAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x6780D0", Offset = "0x6774D0", VA = "0x1806780D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public ACFOFFHKLLK BJKLCBNGIAF
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x68E760", Offset = "0x68DB60", VA = "0x18068E760", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public HGMEOMFEGBD OIDLNIMONGL
	{
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x6780B0", Offset = "0x6774B0", VA = "0x1806780B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public DNDLCINBGLP PJDMIDKLEPL
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x68E770", Offset = "0x68DB70", VA = "0x18068E770", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public MJMALLMJACO HEAAPGDJJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x68E780", Offset = "0x68DB80", VA = "0x18068E780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public LHKNIMEJMPF LDGBPBHKFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x68E700", Offset = "0x68DB00", VA = "0x18068E700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public PENOFJBLKNM PGHAENCANCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x68E710", Offset = "0x68DB10", VA = "0x18068E710", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public PAIHKGLKBFJ LIDDMMEMCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x6B46D0", Offset = "0x6B3AD0", VA = "0x1806B46D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public PCBKHJEIBHN BCBKHOFAHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x67ED80", Offset = "0x67E180", VA = "0x18067ED80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public PHJMGMMMDFN PCOKOHCOOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x67EE20", Offset = "0x67E220", VA = "0x18067EE20", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public DIBCCIIGIIF NNKDELKAOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x6B46A0", Offset = "0x6B3AA0", VA = "0x1806B46A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public DGKMBHEFMLJ COKLCPFGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x68E720", Offset = "0x68DB20", VA = "0x18068E720", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public MBFAONBDNHH DDHGJPOOIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x68E730", Offset = "0x68DB30", VA = "0x18068E730", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public DJJJIFEINIH ACOFEEMINLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x68E750", Offset = "0x68DB50", VA = "0x18068E750", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public IONFNBCFBFH GKFCHINCBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x69EAA0", Offset = "0x69DEA0", VA = "0x18069EAA0", Slot = "21")]
		get
		{
			return default(IONFNBCFBFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x29DD120", Offset = "0x29DC520", VA = "0x1829DD120", Slot = "22")]
	public void APMAKEGPFLO(CLFAHLJOOKN OOALDKGGDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x1F4B1C0", Offset = "0x1F4A5C0", VA = "0x181F4B1C0", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x29DD410", Offset = "0x29DC810", VA = "0x1829DD410", Slot = "23")]
	public void GNDKKHFOLJI(CLFAHLJOOKN OOALDKGGDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public OJJJNLCOFHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[DefaultMember("Item")]
public class GCFBGGJFPOP : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class DBEHMIHPNBC : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public GCFBGGJFPOP <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x68E790", Offset = "0x68DB90", VA = "0x18068E790", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x432BC30", Offset = "0x432B030", VA = "0x18432BC30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
		[DebuggerHidden]
		public DBEHMIHPNBC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x432BA80", Offset = "0x432AE80", VA = "0x18432BA80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x432BBF0", Offset = "0x432AFF0", VA = "0x18432BBF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022E")]
	protected const ulong GLCAKLCHFCP = 1uL;

	[Cpp2IlInjected.Token(Token = "0x400022F")]
	protected const ulong JKBMOLLKEKF = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000230")]
	protected const int MOCMNCFNNAL = 8;

	[Cpp2IlInjected.Token(Token = "0x4000231")]
	protected const int CMBNDKEPNPH = 6;

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public const int OJJJNMFBJNL = 64;

	[Cpp2IlInjected.Token(Token = "0x4000233")]
	protected const int FELLLIHHJIK = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private readonly List<ulong> KGPAJJLCPCP;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x71C410", Offset = "0x71B810", VA = "0x18071C410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public int GGFKDFNCKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x693C90", Offset = "0x693090", VA = "0x180693C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x71C320", Offset = "0x71B720", VA = "0x18071C320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x2BB9C80", Offset = "0x2BB9080", VA = "0x182BB9C80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x2BBA0F0", Offset = "0x2BB94F0", VA = "0x182BBA0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA390", Offset = "0x2BB9790", VA = "0x182BBA390")]
	public GCFBGGJFPOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA410", Offset = "0x2BB9810", VA = "0x182BBA410")]
	public GCFBGGJFPOP(int FFBFONPNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9920", Offset = "0x2BB8D20", VA = "0x182BB9920")]
	public bool CEPOJAOELLL(int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9A90", Offset = "0x2BB8E90", VA = "0x182BB9A90")]
	public bool GFGGCMCPMDN(int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9A00", Offset = "0x2BB8E00", VA = "0x182BB9A00")]
	public bool COHHPCFDICG(int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9A80", Offset = "0x2BB8E80", VA = "0x182BB9A80")]
	public bool EFFOACKHLFJ(int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9600", Offset = "0x2BB8A00", VA = "0x182BB9600")]
	public void ADKJHJMJKPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA2A0", Offset = "0x2BB96A0", VA = "0x182BBA2A0")]
	public void MPCIPOIBKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA000", Offset = "0x2BB9400", VA = "0x182BBA000")]
	public void KNBGLHDOKIA(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9820", Offset = "0x2BB8C20", VA = "0x182BB9820")]
	public void BNMOGLEIOOC(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9B80", Offset = "0x2BB8F80", VA = "0x182BB9B80")]
	public bool GPPJMNDNEDJ(int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9D20", Offset = "0x2BB9120", VA = "0x182BB9D20")]
	public void IMIMFJPCENL(int FHAPAHAAKAH, int LKJCGNNPEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9E40", Offset = "0x2BB9240", VA = "0x182BB9E40")]
	public void JGEKJJLKEHK(int JOEHIOLFBGJ, int IJAPHJMEHJM, int LKJCGNNPEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9690", Offset = "0x2BB8A90", VA = "0x182BB9690")]
	public int AKBMAMDKLNI(int LKJCGNNPEOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9760", Offset = "0x2BB8B60", VA = "0x182BB9760")]
	public int AKBMAMDKLNI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2BB97D0", Offset = "0x2BB8BD0", VA = "0x182BB97D0")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9C10", Offset = "0x2BB9010", VA = "0x182BB9C10", Slot = "4")]
	[IteratorStateMachine(typeof(DBEHMIHPNBC))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9C10", Offset = "0x2BB9010", VA = "0x182BB9C10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class EDIPHBIAGPA<T> : global::JHGNLFBKBLH<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	protected global::BABPOGBEMPF<T> EAGCMHBCBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	protected global::ANJGAEPAHKL<T> MIPKBJHHLOO;

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x158D680", Offset = "0x158CA80", VA = "0x18158D680")]
	public EDIPHBIAGPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x3D17190", Offset = "0x3D16590", VA = "0x183D17190")]
	public EDIPHBIAGPA(global::BABPOGBEMPF<T> EAGCMHBCBKG, global::ANJGAEPAHKL<T> MIPKBJHHLOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x3173640", Offset = "0x3172A40", VA = "0x183173640", Slot = "11")]
	public override T LOHKEOMODAB(MCFAEMGCANP HLOAABLBBPO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x3D16AD0", Offset = "0x3D15ED0", VA = "0x183D16AD0", Slot = "12")]
	public override void FBLBIDAIACI(MCFAEMGCANP HLOAABLBBPO, T IGDJJEECDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class NMBBALCDINF
{
	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x30DFB50", Offset = "0x30DEF50", VA = "0x1830DFB50")]
	public static EEJFBJIDABN JGOJGDHNHPP<T>(this MHOLCOHFGAD OEKBACMEEFA, global::HEIJCHPBGLA<T> DHKKANIEGMN, global::BABPOGBEMPF<T> EAGCMHBCBKG, global::ANJGAEPAHKL<T> MIPKBJHHLOO) where T : struct
	{
		return default(EEJFBJIDABN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class HGGIKLNCHHJ<T> : global::EDIPHBIAGPA<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2FCF1F0", Offset = "0x2FCE5F0", VA = "0x182FCF1F0")]
	public HGGIKLNCHHJ(T CMBNEELHPGN, T HKHDBDONGCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public sealed class JIHMJDNMBCA<T> : global::JHGNLFBKBLH<T> where T : struct, PIFGLOGIBDL
{
	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x20AD470", Offset = "0x20AC870", VA = "0x1820AD470", Slot = "11")]
	public override T LOHKEOMODAB(MCFAEMGCANP HLOAABLBBPO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x20AD3A0", Offset = "0x20AC7A0", VA = "0x1820AD3A0", Slot = "12")]
	public override void FBLBIDAIACI(MCFAEMGCANP HLOAABLBBPO, T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x20AD520", Offset = "0x20AC920", VA = "0x1820AD520")]
	public JIHMJDNMBCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public abstract class GHBHIGMNEFD : NHFGGJNOOKG
{
	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public abstract Type EKPLAIIHJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void LOHKEOMODAB(MCFAEMGCANP HLOAABLBBPO, in LCJNEDPGPKG IGDJJEECDAF);

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void FBLBIDAIACI(MCFAEMGCANP HLOAABLBBPO, in PEABCJAGJAH IGDJJEECDAF);

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void LLJNHDKGDNB(MCFAEMGCANP HLOAABLBBPO, GJEPAJDHBKG AKLLJAGFMDH, [Optional] object GKMHGIGLKCO);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	protected GHBHIGMNEFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public abstract class JHGNLFBKBLH<T> : GHBHIGMNEFD where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public override Type EKPLAIIHJMG
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x20A9A50", Offset = "0x20A8E50", VA = "0x1820A9A50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T LOHKEOMODAB(MCFAEMGCANP HLOAABLBBPO);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void FBLBIDAIACI(MCFAEMGCANP HLOAABLBBPO, T IGDJJEECDAF);

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x20AB2C0", Offset = "0x20AA6C0", VA = "0x1820AB2C0", Slot = "8")]
	public override void LOHKEOMODAB(MCFAEMGCANP HLOAABLBBPO, in LCJNEDPGPKG BCPKCLKDOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x20A8E30", Offset = "0x20A8230", VA = "0x1820A8E30", Slot = "9")]
	public override void FBLBIDAIACI(MCFAEMGCANP HLOAABLBBPO, in PEABCJAGJAH KOEICPMBJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x20A9C90", Offset = "0x20A9090", VA = "0x1820A9C90", Slot = "10")]
	public override void LLJNHDKGDNB(MCFAEMGCANP HLOAABLBBPO, GJEPAJDHBKG AKLLJAGFMDH, object GKMHGIGLKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x11101F0", Offset = "0x110F5F0", VA = "0x1811101F0")]
	protected JHGNLFBKBLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class MIMAJMLHJOD
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	private class IOMDODMCDMG
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class KMKGICCPEKK<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
			public KMKGICCPEKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x296A310", Offset = "0x2969710", VA = "0x18296A310")]
			internal void <RegisterFixedString>b__0(MCFAEMGCANP p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x296A480", Offset = "0x2969880", VA = "0x18296A480")]
			internal T <RegisterFixedString>b__1(MCFAEMGCANP p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x432ECA0", Offset = "0x432E0A0", VA = "0x18432ECA0")]
		public static void CMILEKPGPMJ(JNDPFCKLALE EALIDBKEJIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x2741010", Offset = "0x2740410", VA = "0x182741010")]
		private static void MBJMAPEJMHG<T>(JNDPFCKLALE EALIDBKEJIK, int HKHDBDONGCO) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x2741130", Offset = "0x2740530", VA = "0x182741130")]
		private static void MKENFGNINNH<T>(MCFAEMGCANP ENPADDIHOCB, T FHHDDMKIIBK, int HKHDBDONGCO) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x27409C0", Offset = "0x273FDC0", VA = "0x1827409C0")]
		private static T FBJOJKFAGHD<T>(MCFAEMGCANP ENPADDIHOCB, int HKHDBDONGCO) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public IOMDODMCDMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private class POJFJKKLPDE : PEBBEGHPJEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private JNDPFCKLALE EALIDBKEJIK;

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x275E020", Offset = "0x275D420", VA = "0x18275E020", Slot = "6")]
		public override void NPKOKGBAKIG<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x4335610", Offset = "0x4334A10", VA = "0x184335610")]
		public static void LHOIPBDFGGJ(JNDPFCKLALE EALIDBKEJIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x43356C0", Offset = "0x4334AC0", VA = "0x1843356C0")]
		public POJFJKKLPDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x2BD30C0", Offset = "0x2BD24C0", VA = "0x182BD30C0")]
	public static void OMDLPIEGLKI(JNDPFCKLALE EALIDBKEJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x2566CA0", Offset = "0x25660A0", VA = "0x182566CA0")]
	public static void LALFJPLOEGH<T>(JNDPFCKLALE EALIDBKEJIK, global::BABPOGBEMPF<T> EAGCMHBCBKG, global::ANJGAEPAHKL<T> MIPKBJHHLOO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x2566D30", Offset = "0x2566130", VA = "0x182566D30")]
	public static void NJFHLFOCICI<T>(JNDPFCKLALE ABEAJHEEIJP) where T : struct, PIFGLOGIBDL
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
public interface JNDPFCKLALE : global::PMFIMIOMLEP<JNDPFCKLALE>
{
	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGOJGDHNHPP(Type FPPBLNEEHBP, NHFGGJNOOKG ABEAJHEEIJP);

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIJHOGNBHHL(Type FPPBLNEEHBP, out NHFGGJNOOKG ABEAJHEEIJP);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public static class MLEPNIDCEBJ
{
	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x29D6D70", Offset = "0x29D6170", VA = "0x1829D6D70")]
	public static void JGOJGDHNHPP(this JNDPFCKLALE IIHJMACAMDH, NHFGGJNOOKG ABEAJHEEIJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[NDGJMMLBLBO(typeof(MHOLCOHFGAD), new string[] { })]
public sealed class JBGMHFAKAHF : MHOLCOHFGAD, global::PMFIMIOMLEP<MHOLCOHFGAD>, MCPGEGOMHPG, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private readonly Dictionary<EEJFBJIDABN, NHFGGJNOOKG> EALIDBKEJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private JNDPFCKLALE LNFOANBACFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private NLELCAEKFFF OEKBACMEEFA;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool BAFMPLABLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x768F80", Offset = "0x768380", VA = "0x180768F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x732170", Offset = "0x731570", VA = "0x180732170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x2BC54C0", Offset = "0x2BC48C0", VA = "0x182BC54C0")]
	public JBGMHFAKAHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5400", Offset = "0x2BC4800", VA = "0x182BC5400")]
	public JBGMHFAKAHF(Dictionary<EEJFBJIDABN, NHFGGJNOOKG> EALIDBKEJIK, bool CIJLOPKHHKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4E50", Offset = "0x2BC4250", VA = "0x182BC4E50", Slot = "7")]
	public void FFHOKNLNLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5380", Offset = "0x2BC4780", VA = "0x182BC5380", Slot = "8")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4E00", Offset = "0x2BC4200", VA = "0x182BC4E00", Slot = "9")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x2BC52B0", Offset = "0x2BC46B0", VA = "0x182BC52B0", Slot = "4")]
	public EEJFBJIDABN OCDLCKNINDE(PCCBFFGCINK DHKKANIEGMN)
	{
		return default(EEJFBJIDABN);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5060", Offset = "0x2BC4460", VA = "0x182BC5060", Slot = "5")]
	public void JGOJGDHNHPP(EEJFBJIDABN KDFBMFGPICB, NHFGGJNOOKG ABEAJHEEIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4CC0", Offset = "0x2BC40C0", VA = "0x182BC4CC0")]
	[Conditional("DEBUG_BUILD")]
	private void AIFDJNIIGJA(EEJFBJIDABN KDFBMFGPICB, Type FPPBLNEEHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4EB0", Offset = "0x2BC42B0", VA = "0x182BC4EB0", Slot = "6")]
	public bool HIJHOGNBHHL(EEJFBJIDABN KDFBMFGPICB, out NHFGGJNOOKG ABEAJHEEIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x2BC51D0", Offset = "0x2BC45D0", VA = "0x182BC51D0", Slot = "10")]
	public MHOLCOHFGAD MNHGJDFIIFE()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[NDGJMMLBLBO(typeof(JNDPFCKLALE), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.TypeSerializer)]
	public sealed class TypeSerializerService : MCPGEGOMHPG, JNDPFCKLALE, global::PMFIMIOMLEP<JNDPFCKLALE>
	{
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private readonly Dictionary<Type, NHFGGJNOOKG> EALIDBKEJIK;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public bool BAFMPLABLHO
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0x6928D0", Offset = "0x691CD0", VA = "0x1806928D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x6B4000", Offset = "0x6B3400", VA = "0x1806B4000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2240", Offset = "0x2CB1640", VA = "0x182CB2240")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x2CB22C0", Offset = "0x2CB16C0", VA = "0x182CB22C0")]
		public TypeSerializerService(Dictionary<Type, NHFGGJNOOKG> EALIDBKEJIK, bool CIJLOPKHHKM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1EB0", Offset = "0x2CB12B0", VA = "0x182CB1EB0", Slot = "4")]
		public void FFHOKNLNLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1FF0", Offset = "0x2CB13F0", VA = "0x182CB1FF0", Slot = "5")]
		public void JGOJGDHNHPP(Type FPPBLNEEHBP, NHFGGJNOOKG ABEAJHEEIJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1F10", Offset = "0x2CB1310", VA = "0x182CB1F10", Slot = "6")]
		public bool HIJHOGNBHHL(Type FPPBLNEEHBP, out NHFGGJNOOKG ABEAJHEEIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2110", Offset = "0x2CB1510", VA = "0x182CB2110", Slot = "7")]
		public JNDPFCKLALE MNHGJDFIIFE()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[NDGJMMLBLBO(typeof(DNHDMKNIKLA), new string[] { })]
internal sealed class LIMKOJGINFF : DNHDMKNIKLA, MCPGEGOMHPG, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private readonly Dictionary<EEJFBJIDABN, LJPKMHFFBAJ> FMDKLIGBGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private NLELCAEKFFF OEKBACMEEFA;

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x2BCEF10", Offset = "0x2BCE310", VA = "0x182BCEF10", Slot = "6")]
	public void FFHOKNLNLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF1D0", Offset = "0x2BCE5D0", VA = "0x182BCF1D0", Slot = "7")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x2BCEFD0", Offset = "0x2BCE3D0", VA = "0x182BCEFD0", Slot = "4")]
	public void JGOJGDHNHPP(EEJFBJIDABN FCLBEIEGADL, Type COGNMIDKFFI, LJPKMHFFBAJ BHIGMIHOCPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x2BCEF60", Offset = "0x2BCE360", VA = "0x182BCEF60", Slot = "5")]
	public bool IODHJLBIENF(EEJFBJIDABN FCLBEIEGADL, out LJPKMHFFBAJ BHIGMIHOCPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF040", Offset = "0x2BCE440", VA = "0x182BCF040")]
	[Conditional("DEBUG_BUILD")]
	private void NEMFKKIMLCN(EEJFBJIDABN FCLBEIEGADL, Type COGNMIDKFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x2BCF230", Offset = "0x2BCE630", VA = "0x182BCF230")]
	public LIMKOJGINFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[NDGJMMLBLBO(typeof(MNFECCIPHJB), new string[] { })]
internal sealed class JILHBEOLPNE : MNFECCIPHJB, GGFJAKOLADN, MCPGEGOMHPG, LNLPIGELLPM, ENMEIFNEMLK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private readonly GCFBGGJFPOP OJKJAKKGOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private readonly Dictionary<JCHOAKCKPKK, int> DNDEKCLPPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly Stack<int> FCCCBEOBLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	[HIGIANBBMBE]
	private NLELCAEKFFF OEKBACMEEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	[HIGIANBBMBE]
	private FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private int LOJLHMDKLPI
	{
		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7630", Offset = "0x2BC6A30", VA = "0x182BC7630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool DGHOOJGKDDB
	{
		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x743540", Offset = "0x742940", VA = "0x180743540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x96BC90", Offset = "0x96B090", VA = "0x18096BC90", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7080", Offset = "0x2BC6480", VA = "0x182BC7080", Slot = "6")]
	public void FFHOKNLNLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2BC75B0", Offset = "0x2BC69B0", VA = "0x182BC75B0", Slot = "7")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6FD0", Offset = "0x2BC63D0", VA = "0x182BC6FD0", Slot = "8")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7510", Offset = "0x2BC6910", VA = "0x182BC7510")]
	private void NBDHKCJMPGP(MOLBNKBNJLI AFGGEMMDNNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6E90", Offset = "0x2BC6290", VA = "0x182BC6E90", Slot = "4")]
	public bool BEIJNHOJPJK(JCHOAKCKPKK OMKLELDMIKD, EEJFBJIDABN PDLHECKEFMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2BC71C0", Offset = "0x2BC65C0", VA = "0x182BC71C0", Slot = "5")]
	public void IGLLLFNPGPE(JCHOAKCKPKK OMKLELDMIKD, Span<EEJFBJIDABN> OEKBACMEEFA, bool DJNPPGALOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7080", Offset = "0x2BC6480", VA = "0x182BC7080", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7680", Offset = "0x2BC6A80", VA = "0x182BC7680")]
	public JILHBEOLPNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public static class FHLCBALHCIJ
{
	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7AA0", Offset = "0x2BB6EA0", VA = "0x182BB7AA0")]
	public static void CEOILBMHFBN(this MCFAEMGCANP HLOAABLBBPO, ReadOnlyMemory<byte> PLKHPHKOBBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C89770", Offset = "0x2C88B70", VA = "0x182C89770")]
	public static void DDHKDCKBDDF<T>(this MCFAEMGCANP HLOAABLBBPO, in T IGDJJEECDAF) where T : struct, PIFGLOGIBDL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x2C898A0", Offset = "0x2C88CA0", VA = "0x182C898A0")]
	public static T EEALKBBBFOK<T>(this MCFAEMGCANP HLOAABLBBPO) where T : struct, PIFGLOGIBDL
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7B20", Offset = "0x2BB6F20", VA = "0x182BB7B20")]
	public static void DDHKDCKBDDF(this MCFAEMGCANP HLOAABLBBPO, KIGMOHNBBON JAPLHPDFKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7E20", Offset = "0x2BB7220", VA = "0x182BB7E20")]
	public static KIGMOHNBBON IONLBHKCIAO(this MCFAEMGCANP HLOAABLBBPO)
	{
		return default(KIGMOHNBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7C70", Offset = "0x2BB7070", VA = "0x182BB7C70")]
	public static void IOLAKOJNFDB(this MCFAEMGCANP MPHPGBJPKDG, uint OLGIKPFLCID, bool EBLJJGEOBPI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7B50", Offset = "0x2BB6F50", VA = "0x182BB7B50")]
	public static uint EHHNEDDAIHP(this MCFAEMGCANP HMLGAEKBLFL, bool EBLJJGEOBPI = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public static class BDBNPHFNEJL
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class IFCNEPBGPIN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public IFCNEPBGPIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x1BB07E0", Offset = "0x1BAFBE0", VA = "0x181BB07E0")]
		internal void <GetByteEnumDelegates>b__0(MCFAEMGCANP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x1BB0850", Offset = "0x1BAFC50", VA = "0x181BB0850")]
		internal T <GetByteEnumDelegates>b__1(MCFAEMGCANP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class BKIFINAKINN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public BKIFINAKINN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x238F4C0", Offset = "0x238E8C0", VA = "0x18238F4C0")]
		internal void <GetSByteEnumDelegates>b__0(MCFAEMGCANP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x238F530", Offset = "0x238E930", VA = "0x18238F530")]
		internal T <GetSByteEnumDelegates>b__1(MCFAEMGCANP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class LOBIADDIJDC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public LOBIADDIJDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x309B6A0", Offset = "0x309AAA0", VA = "0x18309B6A0")]
		internal void <GetShortEnumDelegates>b__0(MCFAEMGCANP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x309B710", Offset = "0x309AB10", VA = "0x18309B710")]
		internal T <GetShortEnumDelegates>b__1(MCFAEMGCANP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class GHIHKPFNEBB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public GHIHKPFNEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x2792750", Offset = "0x2791B50", VA = "0x182792750")]
		internal void <GetUShortEnumDelegates>b__0(MCFAEMGCANP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x27927C0", Offset = "0x2791BC0", VA = "0x1827927C0")]
		internal T <GetUShortEnumDelegates>b__1(MCFAEMGCANP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class BADKNLEDAPJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public BADKNLEDAPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x45F6F30", Offset = "0x45F6330", VA = "0x1845F6F30")]
		internal void <GetIntEnumDelegates>b__0(MCFAEMGCANP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x45F6F90", Offset = "0x45F6390", VA = "0x1845F6F90")]
		internal T <GetIntEnumDelegates>b__1(MCFAEMGCANP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class DMPJOLFHFNF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public DMPJOLFHFNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x31654C0", Offset = "0x31648C0", VA = "0x1831654C0")]
		internal void <GetUIntEnumDelegates>b__0(MCFAEMGCANP b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x3165520", Offset = "0x3164920", VA = "0x183165520")]
		internal T <GetUIntEnumDelegates>b__1(MCFAEMGCANP b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x2A1B310", Offset = "0x2A1A710", VA = "0x182A1B310")]
	public static void CHOKGEDADJI<T>(T CMBNEELHPGN, T HKHDBDONGCO, out global::BABPOGBEMPF<T> KPCKMMDCIIG, out global::ANJGAEPAHKL<T> IKPKHPEPHFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A1B680", Offset = "0x2A1AA80", VA = "0x182A1B680")]
	private static void OJEJCBALJIG<T>(T CMBNEELHPGN, T HKHDBDONGCO, out global::BABPOGBEMPF<T> KPCKMMDCIIG, out global::ANJGAEPAHKL<T> IKPKHPEPHFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A1B680", Offset = "0x2A1AA80", VA = "0x182A1B680")]
	private static void FOJLFPAMDMK<T>(T CMBNEELHPGN, T HKHDBDONGCO, out global::BABPOGBEMPF<T> KPCKMMDCIIG, out global::ANJGAEPAHKL<T> IKPKHPEPHFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A1B1C0", Offset = "0x2A1A5C0", VA = "0x182A1B1C0")]
	private static void LGCCGCJMGHJ<T>(T CMBNEELHPGN, T HKHDBDONGCO, out global::BABPOGBEMPF<T> KPCKMMDCIIG, out global::ANJGAEPAHKL<T> IKPKHPEPHFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2A1B1C0", Offset = "0x2A1A5C0", VA = "0x182A1B1C0")]
	private static void CFJIEOILIMC<T>(T CMBNEELHPGN, T HKHDBDONGCO, out global::BABPOGBEMPF<T> KPCKMMDCIIG, out global::ANJGAEPAHKL<T> IKPKHPEPHFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2A1B530", Offset = "0x2A1A930", VA = "0x182A1B530")]
	private static void JBOPOMMCHME<T>(T CMBNEELHPGN, T HKHDBDONGCO, out global::BABPOGBEMPF<T> KPCKMMDCIIG, out global::ANJGAEPAHKL<T> IKPKHPEPHFK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2A1B530", Offset = "0x2A1A930", VA = "0x182A1B530")]
	private static void FEEKFPIHOAB<T>(T CMBNEELHPGN, T HKHDBDONGCO, out global::BABPOGBEMPF<T> KPCKMMDCIIG, out global::ANJGAEPAHKL<T> IKPKHPEPHFK) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class HJKKEHBKEHI : IMCJFCGBGHJ, ENMEIFNEMLK
{
	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0910", Offset = "0x2BBFD10", VA = "0x182BC0910", Slot = "4")]
	private void KCMPMNEBMGP(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void FJLKJBHGCLF(MHOLCOHFGAD OEKBACMEEFA);

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
	protected HJKKEHBKEHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[MNBFNOGKLGN(typeof(LocalPoseData))]
public sealed class MICDFNAEFBC : HJKKEHBKEHI
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x2BD2E70", Offset = "0x2BD2270", VA = "0x182BD2E70", Slot = "5")]
	protected override void FJLKJBHGCLF(MHOLCOHFGAD OEKBACMEEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
	public MICDFNAEFBC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.Scope)]
	internal class CopyAuthorityToEntity : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private LLOINIJEHPN GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private EntityQuery DOILICGBFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private EntityQuery JPOOBOCKIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private EntityQuery AHLPEAALMII;

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DEB0", Offset = "0x2B8D2B0", VA = "0x182B8DEB0", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DCF0", Offset = "0x2B8D0F0", VA = "0x182B8DCF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DE70", Offset = "0x2B8D270", VA = "0x182B8DE70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DE40", Offset = "0x2B8D240", VA = "0x182B8DE40", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D520", Offset = "0x2B8C920", VA = "0x182B8D520")]
		private void HOABJDAIILL(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D2A0", Offset = "0x2B8C6A0", VA = "0x182B8D2A0")]
		private void BPPJKGNLNJL(NativeArray<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DA10", Offset = "0x2B8CE10", VA = "0x182B8DA10")]
		private void OKEBGEGCNFF(NativeArray<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D860", Offset = "0x2B8CC60", VA = "0x182B8D860")]
		private void IAPFMHFALAG(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D090", Offset = "0x2B8C490", VA = "0x182B8D090")]
		private void BIMFAIHAEDM(NativeArray<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B8D440", Offset = "0x2B8C840", VA = "0x182B8D440")]
		private void CIKLHFAPNLO(MOLBNKBNJLI AFGGEMMDNNF, int DLDPNOCIKPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class HELDCFIDIEE : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private EntityQuery JHDPAHIHIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private LLOINIJEHPN GEEOPHADFKF;

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDA60", Offset = "0x2BBCE60", VA = "0x182BBDA60", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x2BBD5D0", Offset = "0x2BBC9D0", VA = "0x182BBD5D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x2BBD690", Offset = "0x2BBCA90", VA = "0x182BBD690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCFF0", Offset = "0x2BBC3F0", VA = "0x182BBCFF0")]
	private void BFDAAKCDLNM(NativeArray<Entity> NPCFKLDOKOP, NativeList<Entity> MIGAEKBCKPF, ComponentDataFromEntity<JGJAGGLADEJ> HEKPMKBNHFK, BufferFromEntity<ChildrenData> GJOONDKICPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public HELDCFIDIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public class ABHBMDFIBAD : ParentSystemBase<AuthoredParentData, GGMLJPFLIIC, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BEC0", Offset = "0x2B7B2C0", VA = "0x182B7BEC0", Slot = "14")]
	protected override EntityQueryDesc NLBKGKLDKMD(EntityQueryDesc JHDPAHIHIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x7236B0", Offset = "0x722AB0", VA = "0x1807236B0", Slot = "15")]
	protected override EntityQueryDesc JCFCOGKLFHK(EntityQueryDesc JHDPAHIHIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BE40", Offset = "0x2B7B240", VA = "0x182B7BE40", Slot = "16")]
	protected override EntityQueryDesc BHGFOHCDDJD(EntityQueryDesc JHDPAHIHIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BE80", Offset = "0x2B7B280", VA = "0x182B7BE80", Slot = "17")]
	protected override EntityQueryDesc GMKJBNDGAGD(EntityQueryDesc JHDPAHIHIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BF40", Offset = "0x2B7B340", VA = "0x182B7BF40")]
	public ABHBMDFIBAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BF00", Offset = "0x2B7B300", VA = "0x182B7BF00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal class IOINFABOMIK : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private EntityQuery JHDPAHIHIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private object MCMIHAENOFJ;

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4800", Offset = "0x2BC3C00", VA = "0x182BC4800", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC44E0", Offset = "0x2BC38E0", VA = "0x182BC44E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4580", Offset = "0x2BC3980", VA = "0x182BC4580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public IOINFABOMIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class MADMFIDCBEE : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery JHDPAHIHIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private object MCMIHAENOFJ;

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0B60", Offset = "0x2BCFF60", VA = "0x182BD0B60", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0840", Offset = "0x2BCFC40", VA = "0x182BD0840", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x2BD08E0", Offset = "0x2BCFCE0", VA = "0x182BD08E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public MADMFIDCBEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[InternalBufferCapacity(1)]
internal struct JBHKFHBDJML : ISystemStateBufferElementData, IBufferElementData, IEquatable<JBHKFHBDJML>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public EIBFIBPGPGA CPAMCPHEBME;

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5540", Offset = "0x2BC4940", VA = "0x182BC5540", Slot = "4")]
	public bool Equals(JBHKFHBDJML EPJIAIAEMFF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
	public static JBHKFHBDJML GFKKOGBEPBN(EIBFIBPGPGA CPAMCPHEBME)
	{
		return default(JBHKFHBDJML);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[InternalBufferCapacity(4)]
internal struct LAJGNPBMNGB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public EIBFIBPGPGA CPAMCPHEBME;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
	public static LAJGNPBMNGB GFKKOGBEPBN(EIBFIBPGPGA CPAMCPHEBME)
	{
		return default(LAJGNPBMNGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal abstract class JCOGIJMNBJG : JIHEIPKEBPB
{
	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x2BC5550", Offset = "0x2BC4950", VA = "0x182BC5550", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2BC56E0", Offset = "0x2BC4AE0", VA = "0x182BC56E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	protected JCOGIJMNBJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[GBCOPIHPADE]
internal abstract class JIHEIPKEBPB : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	protected EntityQuery JHDPAHIHIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	protected FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	protected DJJJIFEINIH BCFNKEDGEDJ;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	protected abstract BCOIIMEBNCL NMADGMNIKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6E20", Offset = "0x2BC6220", VA = "0x182BC6E20", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6B30", Offset = "0x2BC5F30", VA = "0x182BC6B30")]
	protected void JBEIKAJCCBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC68B0", Offset = "0x2BC5CB0", VA = "0x182BC68B0")]
	protected void GDDBHIDFFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC6DB0", Offset = "0x2BC61B0", VA = "0x182BC6DB0")]
	protected PMKCJIGDPOI MEGBFHLGION()
	{
		return default(PMKCJIGDPOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	protected JIHEIPKEBPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal abstract class KHCALKHINFH : JIHEIPKEBPB
{
	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8380", Offset = "0x2BC7780", VA = "0x182BC8380", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8510", Offset = "0x2BC7910", VA = "0x182BC8510", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	protected KHCALKHINFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class FFICHJCEAJA : JIHEIPKEBPB
{
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x2BB74D0", Offset = "0x2BB68D0", VA = "0x182BB74D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x2BB75E0", Offset = "0x2BB69E0", VA = "0x182BB75E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	protected FFICHJCEAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class HJFMOMPFDME : JCOGIJMNBJG
{
	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected override BCOIIMEBNCL NMADGMNIKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBF790", Offset = "0x2BBEB90", VA = "0x182BBF790", Slot = "15")]
		get
		{
			return default(BCOIIMEBNCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public HJFMOMPFDME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal class CIJDPKAANHM : KHCALKHINFH
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected override BCOIIMEBNCL NMADGMNIKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x2B85770", Offset = "0x2B84B70", VA = "0x182B85770", Slot = "15")]
		get
		{
			return default(BCOIIMEBNCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x29D72A0", Offset = "0x29D66A0", VA = "0x1829D72A0")]
	public CIJDPKAANHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class MOIEPENBMFG : FFICHJCEAJA
{
	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected override BCOIIMEBNCL NMADGMNIKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0x29D7230", Offset = "0x29D6630", VA = "0x1829D7230", Slot = "15")]
		get
		{
			return default(BCOIIMEBNCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x29D72A0", Offset = "0x29D66A0", VA = "0x1829D72A0")]
	public MOIEPENBMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class JNCDMADEMHI : JCOGIJMNBJG
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override BCOIIMEBNCL NMADGMNIKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x2BC7CB0", Offset = "0x2BC70B0", VA = "0x182BC7CB0", Slot = "15")]
		get
		{
			return default(BCOIIMEBNCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public JNCDMADEMHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class OMADNNCKLJF : KHCALKHINFH
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override BCOIIMEBNCL NMADGMNIKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x29DD430", Offset = "0x29DC830", VA = "0x1829DD430", Slot = "15")]
		get
		{
			return default(BCOIIMEBNCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x29D72A0", Offset = "0x29D66A0", VA = "0x1829D72A0")]
	public OMADNNCKLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class FPAHCAMJOAB : FFICHJCEAJA
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override BCOIIMEBNCL NMADGMNIKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x2BB8BF0", Offset = "0x2BB7FF0", VA = "0x182BB8BF0", Slot = "15")]
		get
		{
			return default(BCOIIMEBNCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public FPAHCAMJOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal struct EJDJPCLBLBI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal struct FGEIPPODEBG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct HLKNLNBLAKM : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public readonly struct BCOIIMEBNCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly ComponentType IGAPKNCJKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly ComponentType BIKNPFJKBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly object MJNGPHMPILM;

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F9B0", Offset = "0x2B7EDB0", VA = "0x182B7F9B0")]
	public BCOIIMEBNCL(ComponentType IGAPKNCJKBI, ComponentType BIKNPFJKBJN, object MJNGPHMPILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x2A1B140", Offset = "0x2A1A540", VA = "0x182A1B140")]
	public static BCOIIMEBNCL DKOALHGANJG<TReq, TTag>(object MJNGPHMPILM)
	{
		return default(BCOIIMEBNCL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public static class DENAIMOCGLH
{
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public const string LNCGLPICPKC = "Parented";

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public const string EGJCCHBMFPG = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly BCOIIMEBNCL NNKDELKAOBM;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly BCOIIMEBNCL MPGKIGPFPCI;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct EIBFIBPGPGA : global::GPFPNOKLPCO<EIBFIBPGPGA>, PIEOKMGFPCE, IEquatable<EIBFIBPGPGA>
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public int IJHDILKKDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x729E20", Offset = "0x729220", VA = "0x180729E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x729D90", Offset = "0x729190", VA = "0x180729D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public int BBEGHBAAMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x8B6B60", Offset = "0x8B5F60", VA = "0x1808B6B60", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0xEAA170", Offset = "0xEA9570", VA = "0x180EAA170", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool EFFOACKHLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2B95050", Offset = "0x2B94450", VA = "0x182B95050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2B95090", Offset = "0x2B94490", VA = "0x182B95090", Slot = "8")]
	public bool Equals(EIBFIBPGPGA EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x2B950E0", Offset = "0x2B944E0", VA = "0x182B950E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[GBCOPIHPADE]
	[JLJFNDDLCBO(CBGNDNDJKHL.Connectables)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	public class UpdateConnectableVisuals : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		private struct KEBCKHIPFLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public EIBFIBPGPGA CPAMCPHEBME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public float3 EFKMIDDCAKM;

			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x43301F0", Offset = "0x432F5F0", VA = "0x1843301F0")]
			public KEBCKHIPFLB(EIBFIBPGPGA CPAMCPHEBME, float3 EFKMIDDCAKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0x43301D0", Offset = "0x432F5D0", VA = "0x1843301D0")]
			public void ADGEHKFIFPI(out EIBFIBPGPGA CPAMCPHEBME, out float3 EFKMIDDCAKM)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private struct MLCEIBAKJDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public NativeList<KEBCKHIPFLB> list;

			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
			public MLCEIBAKJDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<LAJGNPBMNGB> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private struct KDGLPLNELKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public NativeList<KEBCKHIPFLB> list;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
			public KDGLPLNELKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<JBHKFHBDJML> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private struct OBIOFENGNJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public NativeList<KEBCKHIPFLB> list;

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
			public OBIOFENGNJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in AJKOOCLDDHB com, in DynamicBuffer<JBHKFHBDJML> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct EIMIIPFPLNF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E2")]
			private struct LLFJPLCBMEL
			{
				[Cpp2IlInjected.Token(Token = "0x20000E3")]
				public struct CCNBFGAHCAL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002BE")]
					public LambdaParameterValueProvider_Entity.Runtime FFFFPJKPAID;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002BF")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime NIFDPODCAPN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002C0")]
					public LambdaParameterValueProvider_DynamicBuffer<LAJGNPBMNGB>.Runtime PLLCNOMELLI;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002BB")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity JFGOCIGDAGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002BC")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> HNAJNFNEAOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002BD")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<LAJGNPBMNGB> HMINHFDHOGC;

				[Cpp2IlInjected.Token(Token = "0x600077D")]
				[Cpp2IlInjected.Address(RVA = "0x4332860", Offset = "0x4331C60", VA = "0x184332860")]
				public void EKCCIAECPJB(UpdateConnectableVisuals CCBOANOIBAC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077E")]
				[Cpp2IlInjected.Address(RVA = "0x43328E0", Offset = "0x4331CE0", VA = "0x1843328E0")]
				public CCNBFGAHCAL PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
				{
					return default(CCNBFGAHCAL);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public UpdateConnectableVisuals LHEHPPMHEDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public NativeList<KEBCKHIPFLB> MOBONMBAIDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			private LLFJPLCBMEL LMJJNNPOADP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe LLFJPLCBMEL.CCNBFGAHCAL* MDJEFIMEJIL;

			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate FJAIFPDNJOA;

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x432C3D0", Offset = "0x432B7D0", VA = "0x18432C3D0")]
			internal void ONOBDMKDAMO(Entity NOADJCMIKEF, WorldPoseData ABPFJKOCECH, in DynamicBuffer<LAJGNPBMNGB> OHACFAMPHAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x432C610", Offset = "0x432BA10", VA = "0x18432C610", Slot = "5")]
			public void ReadFromDisplayClass(ref MLCEIBAKJDF BNHKJLMLEEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x432C640", Offset = "0x432BA40", VA = "0x18432C640", Slot = "6")]
			public void WriteToDisplayClass(ref MLCEIBAKJDF BNHKJLMLEEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x432C1B0", Offset = "0x432B5B0", VA = "0x18432C1B0", Slot = "4")]
			public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0x432C290", Offset = "0x432B690", VA = "0x18432C290")]
			public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, ref LLFJPLCBMEL.CCNBFGAHCAL EHNBJOCHNCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077B")]
			[Cpp2IlInjected.Address(RVA = "0x432C170", Offset = "0x432B570", VA = "0x18432C170")]
			public void EKCCIAECPJB(UpdateConnectableVisuals CCBOANOIBAC, ref MLCEIBAKJDF BNHKJLMLEEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x432C100", Offset = "0x432B500", VA = "0x18432C100")]
			public unsafe static void DCIIHCJLOHN(ArchetypeChunkIterator* KALOJDJCBJG, void* DDDPFMDHKNE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct HLNBFPGJMNF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct PNNCOHFMJDA
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				[NoAlias]
				public struct AAJMNFINNBM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002C6")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime NIFDPODCAPN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002C7")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<JBHKFHBDJML>.Runtime PLLCNOMELLI;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002C4")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> HNAJNFNEAOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002C5")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<JBHKFHBDJML> HMINHFDHOGC;

				[Cpp2IlInjected.Token(Token = "0x6000784")]
				[Cpp2IlInjected.Address(RVA = "0x4335270", Offset = "0x4334670", VA = "0x184335270")]
				public void EKCCIAECPJB(UpdateConnectableVisuals CCBOANOIBAC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000785")]
				[Cpp2IlInjected.Address(RVA = "0x43352E0", Offset = "0x43346E0", VA = "0x1843352E0")]
				public AAJMNFINNBM PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
				{
					return default(AAJMNFINNBM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public NativeList<KEBCKHIPFLB> MOBONMBAIDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			private PNNCOHFMJDA LMJJNNPOADP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe PNNCOHFMJDA.AAJMNFINNBM* MDJEFIMEJIL;

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x432E980", Offset = "0x432DD80", VA = "0x18432E980")]
			internal void ONOBDMKDAMO(in WorldPoseData ABPFJKOCECH, in DynamicBuffer<JBHKFHBDJML> OHACFAMPHAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2BC0", Offset = "0x2CA1FC0", VA = "0x182CA2BC0", Slot = "5")]
			public void ReadFromDisplayClass(ref KDGLPLNELKC BNHKJLMLEEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x432E7E0", Offset = "0x432DBE0", VA = "0x18432E7E0", Slot = "4")]
			public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0x432E8B0", Offset = "0x432DCB0", VA = "0x18432E8B0")]
			public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, [NoAlias] ref PNNCOHFMJDA.AAJMNFINNBM EHNBJOCHNCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x432E740", Offset = "0x432DB40", VA = "0x18432E740")]
			public void EKCCIAECPJB(UpdateConnectableVisuals CCBOANOIBAC, ref KDGLPLNELKC BNHKJLMLEEJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct KKHLCCDILIG : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct FHCJOFMBKMJ
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct AIEFIKGHGMM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002CE")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime NIFDPODCAPN;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002CF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<AJKOOCLDDHB>.Runtime IOMHGABKJGI;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D0")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<JBHKFHBDJML>.Runtime PLLCNOMELLI;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CB")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> HNAJNFNEAOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002CC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<AJKOOCLDDHB> EMBNEIKDOEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002CD")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<JBHKFHBDJML> HMINHFDHOGC;

				[Cpp2IlInjected.Token(Token = "0x600078B")]
				[Cpp2IlInjected.Address(RVA = "0x432D330", Offset = "0x432C730", VA = "0x18432D330")]
				public void EKCCIAECPJB(UpdateConnectableVisuals CCBOANOIBAC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600078C")]
				[Cpp2IlInjected.Address(RVA = "0x432D3C0", Offset = "0x432C7C0", VA = "0x18432D3C0")]
				public AIEFIKGHGMM PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
				{
					return default(AIEFIKGHGMM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<KEBCKHIPFLB> MOBONMBAIDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			private FHCJOFMBKMJ LMJJNNPOADP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe FHCJOFMBKMJ.AIEFIKGHGMM* MDJEFIMEJIL;

			[Cpp2IlInjected.Token(Token = "0x6000786")]
			[Cpp2IlInjected.Address(RVA = "0x43303F0", Offset = "0x432F7F0", VA = "0x1843303F0")]
			internal void ONOBDMKDAMO(in WorldPoseData ABPFJKOCECH, in AJKOOCLDDHB IINAHAKAEFP, in DynamicBuffer<JBHKFHBDJML> OHACFAMPHAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000787")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2BC0", Offset = "0x2CA1FC0", VA = "0x182CA2BC0", Slot = "5")]
			public void ReadFromDisplayClass(ref OBIOFENGNJJ BNHKJLMLEEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000788")]
			[Cpp2IlInjected.Address(RVA = "0x4330250", Offset = "0x432F650", VA = "0x184330250", Slot = "4")]
			public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x43302D0", Offset = "0x432F6D0", VA = "0x1843302D0")]
			public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, [NoAlias] ref FHCJOFMBKMJ.AIEFIKGHGMM EHNBJOCHNCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x4330210", Offset = "0x432F610", VA = "0x184330210")]
			public void EKCCIAECPJB(UpdateConnectableVisuals CCBOANOIBAC, ref OBIOFENGNJJ BNHKJLMLEEJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery HAKKFIKDHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery KDIJHPIMNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery DHDDCELFCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private EntityQuery NGEOKMIDNDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private EntityQuery JLHBDCIBGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private EntityQuery DIEPJKDNPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private EntityQuery DKHGILCGMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private EntityQuery EPAJKFOKHFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private EntityQuery CDHPGPFIMCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EntityQuery FPCIMGKJLDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private global::DAMBNPJKGIF<EIBFIBPGPGA, LAMNMLPBGEO> KEBONCLGBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private MBFAONBDNHH BILBONHPOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private PENOFJBLKNM JLIMLKIFDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private IEDDNJCMJHM BLFCNMJPLOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private EntityQuery GBKMONAKFOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private ProfilerMarker EKKEONNOILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private EntityQuery MHBOGJMEIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private EntityQuery OGKLMPGBKGJ;

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int IGGNICCPKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x2CB5340", Offset = "0x2CB4740", VA = "0x182CB5340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2B90", Offset = "0x2CB1F90", VA = "0x182CB2B90")]
		internal LAMNMLPBGEO BAHDJCNMACF(EIBFIBPGPGA CPAMCPHEBME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6E60", Offset = "0x2CB6260", VA = "0x182CB6E60", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2CB68E0", Offset = "0x2CB5CE0", VA = "0x182CB68E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6B60", Offset = "0x2CB5F60", VA = "0x182CB6B60", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6CF0", Offset = "0x2CB60F0", VA = "0x182CB6CF0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6B20", Offset = "0x2CB5F20", VA = "0x182CB6B20", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3C20", Offset = "0x2CB3020", VA = "0x182CB3C20")]
		private void DJDMNDJNPLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x2CB51F0", Offset = "0x2CB45F0", VA = "0x182CB51F0")]
		private void LPOCLKNCGEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6170", Offset = "0x2CB5570", VA = "0x182CB6170")]
		private void OEADHNDHCAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6D30", Offset = "0x2CB6130", VA = "0x182CB6D30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x2CB41A0", Offset = "0x2CB35A0", VA = "0x182CB41A0")]
		private void FHBKGIAODCG(EntityQuery DOILICGBFKE, EntityQuery BLADCNLMNHE, EntityQuery JPOOBOCKIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4810", Offset = "0x2CB3C10", VA = "0x182CB4810")]
		private void GKDAOIMBAHJ(EntityQuery JPOOBOCKIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3940", Offset = "0x2CB2D40", VA = "0x182CB3940")]
		private void DCEEBELJLLH(global::OPHMNPOEIJD<Entity> JDGBGOJNHGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3FC0", Offset = "0x2CB33C0", VA = "0x182CB3FC0")]
		private void DOIPKCEFNPP(global::OPHMNPOEIJD<Entity> AOHAIGHCLJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5FD0", Offset = "0x2CB53D0", VA = "0x182CB5FD0")]
		private void OCENCCIFAHN(global::OPHMNPOEIJD<Entity> MOOIDFKMKKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5080", Offset = "0x2CB4480", VA = "0x182CB5080")]
		private void LLJCNFGADHH(NativeList<EIBFIBPGPGA> NKDFMAEPJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5380", Offset = "0x2CB4780", VA = "0x182CB5380")]
		private NativeList<EIBFIBPGPGA> MEKICIJFBIP(NativeArray<Entity> NPCFKLDOKOP)
		{
			return default(NativeList<EIBFIBPGPGA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3320", Offset = "0x2CB2720", VA = "0x182CB3320")]
		private void CNHHLCEHMFP(NativeArray<Entity> NPCFKLDOKOP, NativeList<EIBFIBPGPGA> NKDFMAEPJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5AA0", Offset = "0x2CB4EA0", VA = "0x182CB5AA0")]
		private void NNGNLDFMJPI(NativeArray<Entity> LBEAPCMLNFK, NativeArray<Entity> OEOMJMJKIKJ, NativeList<EIBFIBPGPGA> FCCCBEOBLKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2E70", Offset = "0x2CB2270", VA = "0x182CB2E70")]
		private void CGEBNDEFIMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4C90", Offset = "0x2CB4090", VA = "0x182CB4C90")]
		private global::LAJJDKPAKGO<KEBCKHIPFLB> KGKEDKNNNEN(EntityQuery JHDPAHIHIEJ, Func<NativeList<KEBCKHIPFLB>, JobHandle> GMFIEAIKJMM)
		{
			return default(global::LAJJDKPAKGO<KEBCKHIPFLB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4680", Offset = "0x2CB3A80", VA = "0x182CB4680")]
		private JobHandle GIDAAMNEKFH(NativeList<KEBCKHIPFLB> MOBONMBAIDJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4B50", Offset = "0x2CB3F50", VA = "0x182CB4B50")]
		private JobHandle IKBHKBFOLFD(NativeList<KEBCKHIPFLB> MOBONMBAIDJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2A60", Offset = "0x2CB1E60", VA = "0x182CB2A60")]
		private JobHandle AMJFIOBPPJF(NativeList<KEBCKHIPFLB> MOBONMBAIDJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2BE0", Offset = "0x2CB1FE0", VA = "0x182CB2BE0")]
		private void CFIJOOHAPPH(global::LAJJDKPAKGO<KEBCKHIPFLB> MOBONMBAIDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2CB3D30", Offset = "0x2CB3130", VA = "0x182CB3D30")]
		private void DNJMKAHAJKH(global::LAJJDKPAKGO<KEBCKHIPFLB> MOBONMBAIDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2CB5020", Offset = "0x2CB4420", VA = "0x182CB5020")]
		private bool KOLPIPHCPAD(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2CB40D0", Offset = "0x2CB34D0", VA = "0x182CB40D0")]
		private NativeArray<Entity> EFEIOLEEEGJ(Entity NOADJCMIKEF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4E60", Offset = "0x2CB4260", VA = "0x182CB4E60")]
		private EIBFIBPGPGA KNOLLMCCOGM(NativeList<EIBFIBPGPGA> FCCCBEOBLKF)
		{
			return default(EIBFIBPGPGA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4DD0", Offset = "0x2CB41D0", VA = "0x182CB4DD0")]
		private void KKOALIFCCEG(EIBFIBPGPGA CPAMCPHEBME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6780", Offset = "0x2CB5B80", VA = "0x182CB6780", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2CB58A0", Offset = "0x2CB4CA0", VA = "0x182CB58A0")]
		public static EntityQuery NCHACMCNJFP(ComponentSystemBase CCBOANOIBAC)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6520", Offset = "0x2CB5920", VA = "0x182CB6520")]
		public static EntityQuery OIGEDGOCPEN(ComponentSystemBase CCBOANOIBAC)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2CB48E0", Offset = "0x2CB3CE0", VA = "0x182CB48E0")]
		public static EntityQuery HILMINCNOBP(ComponentSystemBase CCBOANOIBAC)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[JLJFNDDLCBO(CBGNDNDJKHL.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EntityQuery JHDPAHIHIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private GONOMBLLIBK MIKBKPPJJCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private OLDGHDMCGOO LGIAELDPCMF;

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x29F0CA0", Offset = "0x29F00A0", VA = "0x1829F0CA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x29F1360", Offset = "0x29F0760", VA = "0x1829F1360", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x29F0DA0", Offset = "0x29F01A0", VA = "0x1829F0DA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class OMAJPPKIFKD : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public GHHFOHNOLPM EDKNHLFIHOP;

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public OMAJPPKIFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
	public OMAJPPKIFKD(GHHFOHNOLPM EDKNHLFIHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x29DD4A0", Offset = "0x29DC8A0", VA = "0x1829DD4A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class PPIAMMAEOMB : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private ObjectEmbodimentService LIBFGCDLBNG;

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x29EBE10", Offset = "0x29EB210", VA = "0x1829EBE10", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x29EBDC0", Offset = "0x29EB1C0", VA = "0x1829EBDC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x29EBDF0", Offset = "0x29EB1F0", VA = "0x1829EBDF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	protected PPIAMMAEOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class ENKDNJPMIFI : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private EntityQuery CLIGANFGFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private EntityQuery IOHKGPEFEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	private EntityQuery ILKOJMAJLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private EntityQuery FDBHMBKOAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	private ObjectEmbodimentService GLINEHPINHA;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int DMMLDCPKEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x2B95AD0", Offset = "0x2B94ED0", VA = "0x182B95AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int DJGPOFBJJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x2B95990", Offset = "0x2B94D90", VA = "0x182B95990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x2B95D50", Offset = "0x2B95150", VA = "0x182B95D50", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x2B95B30", Offset = "0x2B94F30", VA = "0x182B95B30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x2B95D30", Offset = "0x2B95130", VA = "0x182B95D30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B959A0", Offset = "0x2B94DA0", VA = "0x182B959A0")]
	public int JOEGIDFEMOP(SceneTag MJJNOEJBKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x2B95780", Offset = "0x2B94B80", VA = "0x182B95780")]
	public int DDHAGHEMAPL(SceneTag MJJNOEJBKMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B95DB0", Offset = "0x2B951B0", VA = "0x182B95DB0")]
	protected void POKODMDJIKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B959C0", Offset = "0x2B94DC0", VA = "0x182B959C0")]
	protected void KBMCFHLPHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B95890", Offset = "0x2B94C90", VA = "0x182B95890")]
	public global::OPHMNPOEIJD<Entity> IABBCBFOIBM(SceneTag MJJNOEJBKMP, Allocator JLPBABJNDBH = Allocator.TempJob)
	{
		return default(global::OPHMNPOEIJD<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B95AE0", Offset = "0x2B94EE0", VA = "0x182B95AE0")]
	public global::OPHMNPOEIJD<Entity> ONGOOOEMHEE(SceneTag MJJNOEJBKMP, Allocator JLPBABJNDBH = Allocator.TempJob)
	{
		return default(global::OPHMNPOEIJD<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B957A0", Offset = "0x2B94BA0", VA = "0x182B957A0")]
	public bool EFEALIEBBBH(SceneTag MJJNOEJBKMP, out global::OPHMNPOEIJD<Entity> EDKNHLFIHOP, Allocator JLPBABJNDBH = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B95830", Offset = "0x2B94C30", VA = "0x182B95830")]
	public bool HCOIBJLOEOM(Entity NOADJCMIKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x2B95920", Offset = "0x2B94D20", VA = "0x182B95920")]
	public GHHFOHNOLPM IFBJHMDJLDG(Entity NOADJCMIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x2B95710", Offset = "0x2B94B10", VA = "0x182B95710")]
	public bool DAEHJILGNJN(Entity NOADJCMIKEF, out OMAJPPKIFKD EDKNHLFIHOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x2B958E0", Offset = "0x2B94CE0", VA = "0x182B958E0")]
	public void IEEPJIECGMO(Entity NOADJCMIKEF, OMAJPPKIFKD EDKNHLFIHOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x2B956B0", Offset = "0x2B94AB0", VA = "0x182B956B0")]
	public bool CPLNPHEEEIK(Entity NOADJCMIKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void AGOALBBGKAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public ENKDNJPMIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class FBCILGNMOJI : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	private EntityQuery ENFNPMJFLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	private LLOINIJEHPN GEEOPHADFKF;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7250", Offset = "0x2BB6650", VA = "0x182BB7250", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6EB0", Offset = "0x2BB62B0", VA = "0x182BB6EB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6F70", Offset = "0x2BB6370", VA = "0x182BB6F70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x2E87800", Offset = "0x2E86C00", VA = "0x182E87800")]
	private bool OPCDCNNAIMM<TComponentData>(EntityQuery JHDPAHIHIEJ, out NativeArray<Entity> NPCFKLDOKOP, out NativeArray<TComponentData> BJEBHLCDKKJ) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6E40", Offset = "0x2BB6240", VA = "0x182BB6E40")]
	public GHHFOHNOLPM IFBJHMDJLDG(Entity NOADJCMIKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public FBCILGNMOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private EntityQuery IIAJPFCPLPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private EntityQuery LFPHDIDMEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private EntityQuery BADEBLCIDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private EntityQuery AHLPEAALMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private LLOINIJEHPN GEEOPHADFKF;

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA84E0", Offset = "0x2CA78E0", VA = "0x182CA84E0", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8180", Offset = "0x2CA7580", VA = "0x182CA8180", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x2CA83B0", Offset = "0x2CA77B0", VA = "0x182CA83B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7D40", Offset = "0x2CA7140", VA = "0x182CA7D40")]
		private void AKBMAMDKLNI(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8110", Offset = "0x2CA7510", VA = "0x182CA8110")]
		private void GKDAOIMBAHJ(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8340", Offset = "0x2CA7740", VA = "0x182CA8340", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x2CA7DB0", Offset = "0x2CA71B0", VA = "0x182CA7DB0")]
		private void BNBDPGMNFMF(EntityQuery JHDPAHIHIEJ, bool BNMAEDNLOCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal sealed class GAFFFLOGBCH : LOFKNNMMOFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct NNNCJOBBLBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public NNNCJOBBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct PGPODNMKONA : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		private struct MOOPOPNEMIL
		{
			[Cpp2IlInjected.Token(Token = "0x20000F5")]
			[NoAlias]
			public struct DDJAKCFDLOG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F0")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime DENFIHILNKH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F1")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime NMOKGLLGHAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002F2")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime MAENGFGJGCD;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity IKAFDLFKBGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> OJMEANLDIAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> JLEKHIACNJB;

			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x43333D0", Offset = "0x43327D0", VA = "0x1843333D0")]
			public void EKCCIAECPJB(GAFFFLOGBCH CCBOANOIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x4333450", Offset = "0x4332850", VA = "0x184333450")]
			public DDJAKCFDLOG PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
			{
				return default(DDJAKCFDLOG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private MOOPOPNEMIL LMJJNNPOADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MOOPOPNEMIL.DDJAKCFDLOG* MDJEFIMEJIL;

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x4335130", Offset = "0x4334530", VA = "0x184335130")]
		internal void ONOBDMKDAMO(Entity JMNNANPLJEH, SplineShapeData FAHGJOEFBKN, DynamicBuffer<LinkedEntityGroup> CCBBJEPJPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x4334F40", Offset = "0x4334340", VA = "0x184334F40", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x4335010", Offset = "0x4334410", VA = "0x184335010")]
		public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, [NoAlias] ref MOOPOPNEMIL.DDJAKCFDLOG EHNBJOCHNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x4334F30", Offset = "0x4334330", VA = "0x184334F30")]
		public void EKCCIAECPJB(GAFFFLOGBCH CCBOANOIBAC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct CDIKMIHLPDB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct IJGCOEKKIAE
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct GEFLFPAENOC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002F8")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FEFDHDEDMKF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40002F9")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime DBOKPAALJBF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F6")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity AKEJLMGFBLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40002F7")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> NMJHMKLONMA;

			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0x432EBC0", Offset = "0x432DFC0", VA = "0x18432EBC0")]
			public void EKCCIAECPJB(GAFFFLOGBCH CCBOANOIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x432EC20", Offset = "0x432E020", VA = "0x18432EC20")]
			public GEFLFPAENOC PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
			{
				return default(GEFLFPAENOC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public BufferFromEntity<LinkedEntityGroup> NJLPBOBLHOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private IJGCOEKKIAE LMJJNNPOADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe IJGCOEKKIAE.GEFLFPAENOC* MDJEFIMEJIL;

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x432AE40", Offset = "0x432A240", VA = "0x18432AE40")]
		internal void ONOBDMKDAMO(Entity DJEPACMMDHI, SplinePointParentData BJGEDNFHKEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x432AED0", Offset = "0x432A2D0", VA = "0x18432AED0", Slot = "5")]
		public void ReadFromDisplayClass(ref NNNCJOBBLBL BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x432ACF0", Offset = "0x432A0F0", VA = "0x18432ACF0", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x432AD90", Offset = "0x432A190", VA = "0x18432AD90")]
		public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, [NoAlias] ref IJGCOEKKIAE.GEFLFPAENOC EHNBJOCHNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x432AC60", Offset = "0x432A060", VA = "0x18432AC60")]
		public void EKCCIAECPJB(GAFFFLOGBCH CCBOANOIBAC, ref NNNCJOBBLBL BNHKJLMLEEJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private EntityQuery JHDPAHIHIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private EntityQuery EPADGDCGFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private EntityQuery HHAHLNGMLFE;

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9310", Offset = "0x2BB8710", VA = "0x182BB9310", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x2BB93C0", Offset = "0x2BB87C0", VA = "0x182BB93C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public GAFFFLOGBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9070", Offset = "0x2BB8470", VA = "0x182BB9070", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8ED0", Offset = "0x2BB82D0", VA = "0x182BB8ED0")]
	public static EntityQuery LPEMBMDBLMP(ComponentSystemBase CCBOANOIBAC)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8D70", Offset = "0x2BB8170", VA = "0x182BB8D70")]
	public static EntityQuery JFMFNJNIGNF(ComponentSystemBase CCBOANOIBAC)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
public sealed class MNJCIJCDJAO : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private ODOEMDIJMKD MDMBONKOKCD;

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x29D71D0", Offset = "0x29D65D0", VA = "0x1829D71D0", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x29D71B0", Offset = "0x29D65B0", VA = "0x1829D71B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public MNJCIJCDJAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class CHAOCPKFJAA : LOFKNNMMOFJ, ENMEIFNEMLK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct DDEFFHDLNAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public NativeList<IEBEIBNAHNC> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public NativeList<AMKCICGGHCJ> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public NativeList<IEBEIBNAHNC> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public DDEFFHDLNAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, HDBNINAKBDA previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
		internal void <OnUpdate>b__2(Entity entity, HDBNINAKBDA previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct PKAMMOEEJLF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct LBGNJPMJEFL
		{
			[Cpp2IlInjected.Token(Token = "0x20000FE")]
			[NoAlias]
			public struct OFLADHHLKFE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000307")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FFFFPJKPAID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000308")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime NODLBEBFEAJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity JFGOCIGDAGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> IMDMIJPGCLB;

			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x4331910", Offset = "0x4330D10", VA = "0x184331910")]
			public void EKCCIAECPJB(CHAOCPKFJAA CCBOANOIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x4331970", Offset = "0x4330D70", VA = "0x184331970")]
			public OFLADHHLKFE PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
			{
				return default(OFLADHHLKFE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NativeList<IEBEIBNAHNC> DDCFNPABLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private LBGNJPMJEFL LMJJNNPOADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LBGNJPMJEFL.OFLADHHLKFE* MDJEFIMEJIL;

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2B40", Offset = "0x2CA1F40", VA = "0x182CA2B40")]
		internal void ONOBDMKDAMO(Entity NOADJCMIKEF, ParentData NDIBANACJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2BC0", Offset = "0x2CA1FC0", VA = "0x182CA2BC0", Slot = "5")]
		public void ReadFromDisplayClass(ref DDEFFHDLNAE BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2A20", Offset = "0x2CA1E20", VA = "0x182CA2A20", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2A90", Offset = "0x2CA1E90", VA = "0x182CA2A90")]
		public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, [NoAlias] ref LBGNJPMJEFL.OFLADHHLKFE EHNBJOCHNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x2CA29E0", Offset = "0x2CA1DE0", VA = "0x182CA29E0")]
		public void EKCCIAECPJB(CHAOCPKFJAA CCBOANOIBAC, ref DDEFFHDLNAE BNHKJLMLEEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct BGBKIKIFGGO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct BJIGNOCAPJO
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct CEPBLDLBANP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030F")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FFFFPJKPAID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000310")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime NODLBEBFEAJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000311")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<HDBNINAKBDA>.Runtime GKJODDPADDA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity JFGOCIGDAGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> IMDMIJPGCLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<HDBNINAKBDA> OFDPBAIFEKC;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x432A660", Offset = "0x4329A60", VA = "0x18432A660")]
			public void EKCCIAECPJB(CHAOCPKFJAA CCBOANOIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x432A6E0", Offset = "0x4329AE0", VA = "0x18432A6E0")]
			public CEPBLDLBANP PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
			{
				return default(CEPBLDLBANP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public NativeList<AMKCICGGHCJ> PCFEOICMJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private BJIGNOCAPJO LMJJNNPOADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BJIGNOCAPJO.CEPBLDLBANP* MDJEFIMEJIL;

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DF70", Offset = "0x2C9D370", VA = "0x182C9DF70")]
		internal void ONOBDMKDAMO(Entity NOADJCMIKEF, ParentData NDIBANACJCD, HDBNINAKBDA DCDGNDLINEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E030", Offset = "0x2C9D430", VA = "0x182C9E030", Slot = "5")]
		public void ReadFromDisplayClass(ref DDEFFHDLNAE BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DE20", Offset = "0x2C9D220", VA = "0x182C9DE20", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DE90", Offset = "0x2C9D290", VA = "0x182C9DE90")]
		public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, [NoAlias] ref BJIGNOCAPJO.CEPBLDLBANP EHNBJOCHNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C9DDE0", Offset = "0x2C9D1E0", VA = "0x182C9DDE0")]
		public void EKCCIAECPJB(CHAOCPKFJAA CCBOANOIBAC, ref DDEFFHDLNAE BNHKJLMLEEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct LIIJBKPMIGJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct MKBDCPHBLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct LINEGABNMLI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000317")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FFFFPJKPAID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000318")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<HDBNINAKBDA>.Runtime GKJODDPADDA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity JFGOCIGDAGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<HDBNINAKBDA> OFDPBAIFEKC;

			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x43329A0", Offset = "0x4331DA0", VA = "0x1843329A0")]
			public void EKCCIAECPJB(CHAOCPKFJAA CCBOANOIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x4332A00", Offset = "0x4331E00", VA = "0x184332A00")]
			public LINEGABNMLI PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
			{
				return default(LINEGABNMLI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<IEBEIBNAHNC> OFAHLEPDIEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private MKBDCPHBLLJ LMJJNNPOADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MKBDCPHBLLJ.LINEGABNMLI* MDJEFIMEJIL;

		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1130", Offset = "0x2CA0530", VA = "0x182CA1130")]
		internal void ONOBDMKDAMO(Entity NOADJCMIKEF, HDBNINAKBDA DCDGNDLINEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA11B0", Offset = "0x2CA05B0", VA = "0x182CA11B0", Slot = "5")]
		public void ReadFromDisplayClass(ref DDEFFHDLNAE BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1010", Offset = "0x2CA0410", VA = "0x182CA1010", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1080", Offset = "0x2CA0480", VA = "0x182CA1080")]
		public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, [NoAlias] ref MKBDCPHBLLJ.LINEGABNMLI EHNBJOCHNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA0FD0", Offset = "0x2CA03D0", VA = "0x182CA0FD0")]
		public void EKCCIAECPJB(CHAOCPKFJAA CCBOANOIBAC, ref DDEFFHDLNAE BNHKJLMLEEJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private HBJNCCNFNHC BEHKMFHFIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery EJJJDDLIDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private EntityQuery JGLEEBFCHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private EntityQuery GICJKJDPJIC;

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x2B84B30", Offset = "0x2B83F30", VA = "0x182B84B30", Slot = "14")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2B85100", Offset = "0x2B84500", VA = "0x182B85100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public CHAOCPKFJAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x2B850A0", Offset = "0x2B844A0", VA = "0x182B850A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x2B84E40", Offset = "0x2B84240", VA = "0x182B84E40")]
	public static EntityQuery MDDBPLKDECG(ComponentSystemBase CCBOANOIBAC)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x2B84C10", Offset = "0x2B84010", VA = "0x182B84C10")]
	public static EntityQuery DGPDBINKMEK(ComponentSystemBase CCBOANOIBAC)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B84930", Offset = "0x2B83D30", VA = "0x182B84930")]
	public static EntityQuery CBJKKGFJEIA(ComponentSystemBase CCBOANOIBAC)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Connectables)]
	public class InitializeRigidbodyExHierarchy : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private EntityQuery JHDPAHIHIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private KNBINECLDFH GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4980", Offset = "0x2BC3D80", VA = "0x182BC4980", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4C00", Offset = "0x2BC4000", VA = "0x182BC4C00", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BC4A10", Offset = "0x2BC3E10", VA = "0x182BC4A10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class HHACBNKDICM : ParentSystemBase<ParentData, HDBNINAKBDA, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDEA0", Offset = "0x2BBD2A0", VA = "0x182BBDEA0", Slot = "14")]
	protected override EntityQueryDesc NLBKGKLDKMD(EntityQueryDesc JHDPAHIHIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x7236B0", Offset = "0x722AB0", VA = "0x1807236B0", Slot = "15")]
	protected override EntityQueryDesc JCFCOGKLFHK(EntityQueryDesc JHDPAHIHIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDE20", Offset = "0x2BBD220", VA = "0x182BBDE20", Slot = "16")]
	protected override EntityQueryDesc BHGFOHCDDJD(EntityQueryDesc JHDPAHIHIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDE60", Offset = "0x2BBD260", VA = "0x182BBDE60", Slot = "17")]
	protected override EntityQueryDesc GMKJBNDGAGD(EntityQueryDesc JHDPAHIHIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDF20", Offset = "0x2BBD320", VA = "0x182BBDF20")]
	public HHACBNKDICM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDEE0", Offset = "0x2BBD2E0", VA = "0x182BBDEE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : LOFKNNMMOFJ where ParentData : struct, IComponentData, AHLBNOBKMEI where PreviousParentData : struct, IComponentData, AHLBNOBKMEI where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, AHLBNOBKMEI
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[BurstCompile]
		private struct CIILOJCPHFA : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter EFJABKIJBEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter EFEFJOEGFJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public NativeHashMap<Entity, int>.ParallelWriter NMOJOGHMMHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public ArchetypeChunkComponentType<PreviousParentData> GICJBBAPCDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> IIOIEGNBPIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			[ReadOnly]
			public ArchetypeChunkEntityType BOJPCGNBDAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			public uint JNNFIEPMAHI;

			[Cpp2IlInjected.Token(Token = "0x6000817")]
			[Cpp2IlInjected.Address(RVA = "0x3A7D420", Offset = "0x3A7C820", VA = "0x183A7D420", Slot = "4")]
			public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000109")]
		[BurstCompile]
		private struct FAOGLPCOPID : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeHashMap<Entity, int> NMOJOGHMMHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> BMLMIMFIHOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public NativeList<Entity> PMFFLMEHFOH;

			[Cpp2IlInjected.Token(Token = "0x6000818")]
			[Cpp2IlInjected.Address(RVA = "0x2528840", Offset = "0x2527C40", VA = "0x182528840", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010A")]
		[BurstCompile]
		private struct HPKAKDJLNFI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> EFJABKIJBEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> EFEFJOEGFJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			[ReadOnly]
			public NativeHashMap<Entity, int> NMOJOGHMMHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public BufferFromEntity<ChildrenData> BMLMIMFIHOB;

			[Cpp2IlInjected.Token(Token = "0x6000819")]
			[Cpp2IlInjected.Address(RVA = "0x35EBB50", Offset = "0x35EAF50", VA = "0x1835EBB50")]
			private int JACGALCCJCC(DynamicBuffer<ChildrenData> HEIHGIHIMEK, Entity NOADJCMIKEF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600081A")]
			[Cpp2IlInjected.Address(RVA = "0x35EB3C0", Offset = "0x35EA7C0", VA = "0x1835EB3C0")]
			private void ANGHNBNJGIO(Entity JFCNGAACNEO, DynamicBuffer<ChildrenData> HEIHGIHIMEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081B")]
			[Cpp2IlInjected.Address(RVA = "0x35EB520", Offset = "0x35EA920", VA = "0x1835EB520")]
			private void DGNDAAPKHAP(Entity JFCNGAACNEO, DynamicBuffer<ChildrenData> HEIHGIHIMEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600081C")]
			[Cpp2IlInjected.Address(RVA = "0x35EB8E0", Offset = "0x35EACE0", VA = "0x1835EB8E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct PHBCEHEKFFH : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public NativeArray<Entity> NNKIPPLFJOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public NativeList<Entity> BACNDKNLMGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public BufferFromEntity<ChildrenData> BMLMIMFIHOB;

			[Cpp2IlInjected.Token(Token = "0x600081D")]
			[Cpp2IlInjected.Address(RVA = "0x28E3790", Offset = "0x28E2B90", VA = "0x1828E3790", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected EntityQuery AKEDOHPNAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected EntityQuery AGCHMCHAGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected EntityQuery DFEGPIFINDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected EntityQuery DHLEAFENPGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected ProfilerMarker LBHPFHMBNDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected ProfilerMarker HEMIGEELHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected ProfilerMarker KCCJJBEFFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected ProfilerMarker OIJDLICDHGF;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x2DD34B0", Offset = "0x2DD28B0", VA = "0x182DD34B0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x2DD29D0", Offset = "0x2DD1DD0", VA = "0x182DD29D0")]
		private int JACGALCCJCC(DynamicBuffer<ChildrenData> HEIHGIHIMEK, Entity NOADJCMIKEF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2BB0", Offset = "0x2DD1FB0", VA = "0x182DD2BB0")]
		private void ONFOCLKBJCH(Entity PGOJLBOOBPI, Entity KNGLIKPNIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x7236B0", Offset = "0x722AB0", VA = "0x1807236B0", Slot = "14")]
		protected virtual EntityQueryDesc NLBKGKLDKMD(EntityQueryDesc JHDPAHIHIEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x7236B0", Offset = "0x722AB0", VA = "0x1807236B0", Slot = "15")]
		protected virtual EntityQueryDesc JCFCOGKLFHK(EntityQueryDesc JHDPAHIHIEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x7236B0", Offset = "0x722AB0", VA = "0x1807236B0", Slot = "16")]
		protected virtual EntityQueryDesc BHGFOHCDDJD(EntityQueryDesc JHDPAHIHIEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc GMKJBNDGAGD(EntityQueryDesc JHDPAHIHIEJ);

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3110", Offset = "0x2DD2510", VA = "0x182DD3110", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1EF0", Offset = "0x2DD12F0", VA = "0x182DD1EF0")]
		private void FIMKLMBFHBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2650", Offset = "0x2DD1A50", VA = "0x182DD2650")]
		private void GMPLKOBGKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x2DD1490", Offset = "0x2DD0890", VA = "0x182DD1490")]
		private JobHandle DDKJGEJFCEO(JobHandle IOPKJPIPCAB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2090", Offset = "0x2DD1490", VA = "0x182DD2090")]
		private void FLNIIIFOECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x2DD33E0", Offset = "0x2DD27E0", VA = "0x182DD33E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x2DD33B0", Offset = "0x2DD27B0", VA = "0x182DD33B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCDD0", Offset = "0x2BDC1D0", VA = "0x182BDCDD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[AlwaysUpdateSystem]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
public abstract class LGCNEAPNBIM : LOFKNNMMOFJ, ENMEIFNEMLK
{
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private struct PDEBFOKONCH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public global::LAJJDKPAKGO<Entity> PAPBOHIAPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public global::LAJJDKPAKGO<Entity> BABNKGBPBKO;

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x4334510", Offset = "0x4333910", VA = "0x184334510")]
		public PDEBFOKONCH(NativeList<Entity> PAPBOHIAPIF, NativeList<Entity> BABNKGBPBKO, JobHandle JAACMKMPHFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x4334400", Offset = "0x4333800", VA = "0x184334400")]
		public JobHandle AGBLFBDHMIK(JobHandle IOPKJPIPCAB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x4334480", Offset = "0x4333880", VA = "0x184334480", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct PEPNHCGGFJE : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[Flags]
		public enum EPFBCGICEAH
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
		public NativeList<Entity> OMLBEJENLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[WriteOnly]
		public NativeList<Entity> JDNCHJLMGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[ReadOnly]
		public NativeArray<Entity> MPENCBKPAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> DCKNONEKMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[ReadOnly]
		public GHPFKCKCCJM BBBIKPNOOGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		[ReadOnly]
		public GHPFKCKCCJM CLGJAADGIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> NDCFLOCIJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public int GFDBCLABAFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int ELEJGHGPFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private EPFBCGICEAH LEEEKIFGBFO;

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x43349B0", Offset = "0x4333DB0", VA = "0x1843349B0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x4334600", Offset = "0x4333A00", VA = "0x184334600")]
		private void ANPKCKPJNBI(Entity NOADJCMIKEF, bool PAOLCAEFINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x4334E20", Offset = "0x4334220", VA = "0x184334E20")]
		private void KONIOPIADCD(Entity NOADJCMIKEF, bool PAOLCAEFINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x4334B40", Offset = "0x4333F40", VA = "0x184334B40")]
		public PDEBFOKONCH JNJPKJGBCNO(NativeArray<Entity> BKAJFMOPMLJ, JobHandle IOPKJPIPCAB)
		{
			return default(PDEBFOKONCH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x4334850", Offset = "0x4333C50", VA = "0x184334850")]
		public PDEBFOKONCH CBAKECGHCDI(NativeArray<Entity> BKAJFMOPMLJ, JobHandle IOPKJPIPCAB)
		{
			return default(PDEBFOKONCH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x43348D0", Offset = "0x4333CD0", VA = "0x1843348D0")]
		public PDEBFOKONCH CFKMAFHCFNH(NativeList<IEBEIBNAHNC> MOBONMBAIDJ, JobHandle IOPKJPIPCAB)
		{
			return default(PDEBFOKONCH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x4334690", Offset = "0x4333A90", VA = "0x184334690")]
		public PDEBFOKONCH BNKOBLKMLNN(NativeList<IEBEIBNAHNC> MOBONMBAIDJ, JobHandle IOPKJPIPCAB)
		{
			return default(PDEBFOKONCH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x4334770", Offset = "0x4333B70", VA = "0x184334770")]
		public PDEBFOKONCH CADIHJGOCID(NativeList<AMKCICGGHCJ> MOBONMBAIDJ, JobHandle IOPKJPIPCAB)
		{
			return default(PDEBFOKONCH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x275DEE0", Offset = "0x275D2E0", VA = "0x18275DEE0")]
		private PDEBFOKONCH KOHDPOCMGID<T>(NativeList<T> MOBONMBAIDJ, int IAHIFNKNJCH, int BEKKNCHHEEB, EPFBCGICEAH JHDOIDGIHDG, JobHandle IOPKJPIPCAB) where T : struct
		{
			return default(PDEBFOKONCH);
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x4334BC0", Offset = "0x4333FC0", VA = "0x184334BC0")]
		private PDEBFOKONCH KOHDPOCMGID(NativeArray<Entity> NPCFKLDOKOP, int IAHIFNKNJCH, int BEKKNCHHEEB, EPFBCGICEAH JHDOIDGIHDG, JobHandle IOPKJPIPCAB)
		{
			return default(PDEBFOKONCH);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private readonly DLHDGHMPCLG HCDIHNPPHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	private EntityQuery CJCMLILHHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	private EntityQuery PLJEFCNAADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	private HBJNCCNFNHC CJAFIOLACJG;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	protected abstract ComponentType IKBMCJMJDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	protected abstract ComponentType LMMFNNCGOBL
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	protected abstract ComponentType CIAIKDECJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x2BCEED0", Offset = "0x2BCE2D0", VA = "0x182BCEED0")]
	protected LGCNEAPNBIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD860", Offset = "0x2BCCC60", VA = "0x182BCD860", Slot = "14")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x2BCDB50", Offset = "0x2BCCF50", VA = "0x182BCDB50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x2BCDD80", Offset = "0x2BCD180", VA = "0x182BCDD80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x781510", Offset = "0x780910", VA = "0x180781510", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD940", Offset = "0x2BCCD40", VA = "0x182BCD940")]
	private void LDIJAPBCKGJ(NativeArray<Entity> MOBONMBAIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD9A0", Offset = "0x2BCCDA0", VA = "0x182BCD9A0")]
	private void MAEALMMFAMN(NativeArray<Entity> MOBONMBAIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x2BCED90", Offset = "0x2BCE190", VA = "0x182BCED90")]
	private void PJJMPGHJALG(PDEBFOKONCH LAJKMFOIDNJ, string MGGNIJBJPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x2BCEC80", Offset = "0x2BCE080", VA = "0x182BCEC80")]
	private void PJJMPGHJALG(global::LAJJDKPAKGO<Entity> CAFCHJGJJHI, string MGGNIJBJPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD720", Offset = "0x2BCCB20", VA = "0x182BCD720")]
	private void AKOPLFBGOHL(PDEBFOKONCH LAJKMFOIDNJ, string MGGNIJBJPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD610", Offset = "0x2BCCA10", VA = "0x182BCD610")]
	private void AKOPLFBGOHL(global::LAJJDKPAKGO<Entity> CAFCHJGJJHI, string MGGNIJBJPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x2BCDA40", Offset = "0x2BCCE40", VA = "0x182BCDA40")]
	private bool NPHJEMOFFPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
public class OHIKOFMKBNP : LOFKNNMMOFJ, LNLPIGELLPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct HDGCLBMELKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public OHIKOFMKBNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public HDGCLBMELKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HJNOAEOAGBF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct PPAECPODMKH
		{
			[Cpp2IlInjected.Token(Token = "0x2000114")]
			public struct BHNAFBKJMMF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000358")]
				public LambdaParameterValueProvider_Entity.Runtime BKIDPLMDPNG;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity EBOKBBPJKGA;

			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0x43356D0", Offset = "0x4334AD0", VA = "0x1843356D0")]
			public void EKCCIAECPJB(OHIKOFMKBNP CCBOANOIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084B")]
			[Cpp2IlInjected.Address(RVA = "0x43356E0", Offset = "0x4334AE0", VA = "0x1843356E0")]
			public BHNAFBKJMMF PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
			{
				return default(BHNAFBKJMMF);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public OHIKOFMKBNP LHEHPPMHEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public EntityCommandBuffer OFMKAFEDNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private PPAECPODMKH LMJJNNPOADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PPAECPODMKH.BHNAFBKJMMF* MDJEFIMEJIL;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate FJAIFPDNJOA;

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x432E630", Offset = "0x432DA30", VA = "0x18432E630")]
		internal void ONOBDMKDAMO(Entity PNJNNEOHMAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x432BA10", Offset = "0x432AE10", VA = "0x18432BA10", Slot = "5")]
		public void ReadFromDisplayClass(ref HDGCLBMELKO BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x432BA40", Offset = "0x432AE40", VA = "0x18432BA40", Slot = "6")]
		public void WriteToDisplayClass(ref HDGCLBMELKO BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x432E570", Offset = "0x432D970", VA = "0x18432E570", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x432E5C0", Offset = "0x432D9C0", VA = "0x18432E5C0")]
		public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, ref PPAECPODMKH.BHNAFBKJMMF EHNBJOCHNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x432E530", Offset = "0x432D930", VA = "0x18432E530")]
		public void EKCCIAECPJB(OHIKOFMKBNP CCBOANOIBAC, ref HDGCLBMELKO BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x432E4C0", Offset = "0x432D8C0", VA = "0x18432E4C0")]
		public unsafe static void DCIIHCJLOHN(ArchetypeChunkIterator* KALOJDJCBJG, void* DDDPFMDHKNE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private HOMCCEMGEKC LFLJNCNDNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private FFGAOMNGKBA AADPIDIMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private EntityQuery MIALMEBENNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private ProfilerMarker APDDACAKOPD;

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x29DB8B0", Offset = "0x29DACB0", VA = "0x1829DB8B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x29DBA60", Offset = "0x29DAE60", VA = "0x1829DBA60", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x29DB910", Offset = "0x29DAD10", VA = "0x1829DB910", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public OHIKOFMKBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x29DB7D0", Offset = "0x29DABD0", VA = "0x1829DB7D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x29DB600", Offset = "0x29DAA00", VA = "0x1829DB600")]
	public static EntityQuery AIHEMGHALGC(ComponentSystemBase CCBOANOIBAC)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[GBCOPIHPADE]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
public class PBCGEGNJJBO : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private FFGAOMNGKBA AADPIDIMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private SceneService EKPOPNOIBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private EntityQuery JHDPAHIHIEJ;

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x29EA1D0", Offset = "0x29E95D0", VA = "0x1829EA1D0", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x29E9DE0", Offset = "0x29E91E0", VA = "0x1829E9DE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x29E9E80", Offset = "0x29E9280", VA = "0x1829E9E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public PBCGEGNJJBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public struct BHLLOEFJBHA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	public LCGHEKCHLDL CPAMCPHEBME;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000")]
	public static BHLLOEFJBHA GFKKOGBEPBN(in LCGHEKCHLDL FLKFKDOKHOG)
	{
		return default(BHLLOEFJBHA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000")]
	public static LCGHEKCHLDL GFKKOGBEPBN(in BHLLOEFJBHA GDJEKEIFHGD)
	{
		return default(LCGHEKCHLDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[AlwaysUpdateSystem]
public class HOMCCEMGEKC : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x2BC13C0", Offset = "0x2BC07C0", VA = "0x182BC13C0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0")]
	public HOMCCEMGEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[AlwaysUpdateSystem]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
public class JMEBGHALENA : LOFKNNMMOFJ, LNLPIGELLPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[CompilerGenerated]
	private struct NOELBCLMCAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public JMEBGHALENA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public NOELBCLMCAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
		internal void <OnUpdate>b__0(Entity e, BHLLOEFJBHA ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct CKFMFEDBHMC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct EABABNCGHBH
		{
			[Cpp2IlInjected.Token(Token = "0x200011C")]
			public struct FANHNLMADKG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public LambdaParameterValueProvider_Entity.Runtime BKIDPLMDPNG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_IComponentData<BHLLOEFJBHA>.Runtime NNIPJDNDABO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity EBOKBBPJKGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<BHLLOEFJBHA> PHMMKICFNNM;

			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0x432BC80", Offset = "0x432B080", VA = "0x18432BC80")]
			public void EKCCIAECPJB(JMEBGHALENA CCBOANOIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x432BCE0", Offset = "0x432B0E0", VA = "0x18432BCE0")]
			public FANHNLMADKG PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
			{
				return default(FANHNLMADKG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public JMEBGHALENA LHEHPPMHEDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer OFMKAFEDNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private EABABNCGHBH LMJJNNPOADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe EABABNCGHBH.FANHNLMADKG* MDJEFIMEJIL;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate FJAIFPDNJOA;

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x432B910", Offset = "0x432AD10", VA = "0x18432B910")]
		internal void ONOBDMKDAMO(Entity PNJNNEOHMAF, BHLLOEFJBHA OKINPNJEJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x432BA10", Offset = "0x432AE10", VA = "0x18432BA10", Slot = "5")]
		public void ReadFromDisplayClass(ref NOELBCLMCAE BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x432BA40", Offset = "0x432AE40", VA = "0x18432BA40", Slot = "6")]
		public void WriteToDisplayClass(ref NOELBCLMCAE BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x432B7C0", Offset = "0x432ABC0", VA = "0x18432B7C0", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x432B860", Offset = "0x432AC60", VA = "0x18432B860")]
		public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, ref EABABNCGHBH.FANHNLMADKG EHNBJOCHNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x432B730", Offset = "0x432AB30", VA = "0x18432B730")]
		public void EKCCIAECPJB(JMEBGHALENA CCBOANOIBAC, ref NOELBCLMCAE BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x432B6C0", Offset = "0x432AAC0", VA = "0x18432B6C0")]
		public unsafe static void DCIIHCJLOHN(ArchetypeChunkIterator* KALOJDJCBJG, void* DDDPFMDHKNE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private HOMCCEMGEKC LFLJNCNDNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private FFGAOMNGKBA AADPIDIMPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery DPFFCFOGLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private ProfilerMarker INNAPOHKKNM;

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7A90", Offset = "0x2BC6E90", VA = "0x182BC7A90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7C50", Offset = "0x2BC7050", VA = "0x182BC7C50", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7AF0", Offset = "0x2BC6EF0", VA = "0x182BC7AF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public JMEBGHALENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC79B0", Offset = "0x2BC6DB0", VA = "0x182BC79B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC77E0", Offset = "0x2BC6BE0", VA = "0x182BC77E0")]
	public static EntityQuery CNFPOOMMEBM(ComponentSystemBase CCBOANOIBAC)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct LEEJGCKMPHM : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public AMEAPFGBPJG EDICDNMPJLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeHashMap<Entity, IMOBLFIBELG> NPCFKLDOKOP;

			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0x4331A70", Offset = "0x4330E70", VA = "0x184331A70")]
			public LEEJGCKMPHM(int OAKAJHNNELN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x43319F0", Offset = "0x4330DF0", VA = "0x1843319F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		[BurstCompile]
		private struct JFPIJCAFACF : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			[ReadOnly]
			public NativeArray<Entity> NPCFKLDOKOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> CAPEBLKJIKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> GEOJPPIKBFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> MBOPLODGOFC;

			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0x432F480", Offset = "0x432E880", VA = "0x18432F480", Slot = "4")]
			public void Execute(int HMJKJGLHFKE, TransformAccess KFAGMEKKLDA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000120")]
		[BurstCompile]
		private struct FGJLJMKGDAD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			public NativeArray<Entity> NPCFKLDOKOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> CAPEBLKJIKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> MBOPLODGOFC;

			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x432D1E0", Offset = "0x432C5E0", VA = "0x18432D1E0", Slot = "4")]
			public void Execute(int HMJKJGLHFKE, TransformAccess KFAGMEKKLDA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private FFGAOMNGKBA AADPIDIMPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private EntityQuery NBKFLBHAAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private EntityQuery MAPHGOAFFGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private EntityQuery IAIDOBIEDLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private EntityQuery DGPEECJDBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private EntityQuery PBNJMMMGFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private JobHandle BNDCKCDEIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private LEEJGCKMPHM FGHJONFGGJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private LEEJGCKMPHM KDGKELBDBDL;

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x29EE770", Offset = "0x29EDB70", VA = "0x1829EE770", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x29EDD10", Offset = "0x29ED110", VA = "0x1829EDD10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x29EDA70", Offset = "0x29ECE70", VA = "0x1829EDA70", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x29EDFD0", Offset = "0x29ED3D0", VA = "0x1829EDFD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x29ED690", Offset = "0x29ECA90", VA = "0x1829ED690")]
		private void FLNKCAPBBPH(EntityQuery JHDPAHIHIEJ, out (global::OPHMNPOEIJD<BHLLOEFJBHA> handles, global::OPHMNPOEIJD<HEKNCGOBJJM> bounds) PNMIIEJFOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x29EDAB0", Offset = "0x29ECEB0", VA = "0x1829EDAB0")]
		private void OCIHPICDBOP((global::OPHMNPOEIJD<BHLLOEFJBHA> handles, global::OPHMNPOEIJD<HEKNCGOBJJM> bounds) PNMIIEJFOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x29EDA70", Offset = "0x29ECE70", VA = "0x1829EDA70")]
		private void KNBKNOAPBGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x29ED930", Offset = "0x29ECD30", VA = "0x1829ED930")]
		private void JLGJJIDDEKO(EntityQuery JHDPAHIHIEJ, out (global::OPHMNPOEIJD<Entity> entities, global::OPHMNPOEIJD<BHLLOEFJBHA> handles) PNMIIEJFOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x29ED270", Offset = "0x29EC670", VA = "0x1829ED270")]
		private void CLDHJGJAADE((global::OPHMNPOEIJD<Entity> entities, global::OPHMNPOEIJD<BHLLOEFJBHA> handles) PNMIIEJFOON, LEEJGCKMPHM GKDAJBJDGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x29ED7D0", Offset = "0x29ECBD0", VA = "0x1829ED7D0")]
		private JobHandle GEIMFJDLFKC(LEEJGCKMPHM GKDAJBJDGBP, ComponentDataFromEntity<WorldPoseData> CAPEBLKJIKO, ComponentDataFromEntity<WorldUniformScaleData> MBOPLODGOFC, ComponentDataFromEntity<WorldDeformableScaleData> GEOJPPIKBFI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x29ED560", Offset = "0x29EC960", VA = "0x1829ED560")]
		private JobHandle FKLHKGPGMHD(LEEJGCKMPHM GKDAJBJDGBP, ComponentDataFromEntity<WorldPoseData> CAPEBLKJIKO, ComponentDataFromEntity<WorldUniformScaleData> MBOPLODGOFC)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
public struct ADFBPILNNNP : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[GBCOPIHPADE]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	public class SplineLocalBoundsSystem : LOFKNNMMOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct LHHCJCALKIE : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			[ReadOnly]
			public NativeArray<Entity> EEMDHCPJKPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> BFLEILKBLBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			[ReadOnly]
			public ComponentDataFromEntity<HEKNCGOBJJM> HFMOGBPKBIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			[WriteOnly]
			public NativeHashMap<Entity, IMOBLFIBELG>.ParallelWriter BDMKBKNJPHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter AFEMBEHCGNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter DEJCFOJMENO;

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x4331F70", Offset = "0x4331370", VA = "0x184331F70", Slot = "4")]
			public void Execute(int HMJKJGLHFKE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[BurstCompile]
		private struct POCCPBAIIJM : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			[ReadOnly]
			public NativeArray<Entity> EJPDNKAPFOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> CLOKPDEMPJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> MJLNCGAIEAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> HFDOJEONIDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<HEKNCGOBJJM> ACALEIDJFPN;

			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0x4335380", Offset = "0x4334780", VA = "0x184335380", Slot = "4")]
			public void Execute(int HMJKJGLHFKE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private EntityQuery BANNLMAEIDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery IBDCOEPKILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery IPMKBFPOFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery LBMHFLEBHCK;

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA800", Offset = "0x2CA9C00", VA = "0x182CAA800", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x2CAAA10", Offset = "0x2CA9E10", VA = "0x182CAAA10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9FB0", Offset = "0x2CA93B0", VA = "0x182CA9FB0")]
		private JobHandle HMGFJEFHPEM(global::OPHMNPOEIJD<Entity> ICPECNGAFCL, int BFFLFOJBLOH, JobHandle IOPKJPIPCAB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9DD0", Offset = "0x2CA91D0", VA = "0x182CA9DD0")]
		private JobHandle HMGFJEFHPEM(NativeArray<Entity> PDEGNFICLHB, int BFFLFOJBLOH, [Optional] JobHandle IOPKJPIPCAB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9D50", Offset = "0x2CA9150", VA = "0x182CA9D50")]
		private global::OPHMNPOEIJD<Entity> GPNDMPIEIJE(EntityQuery JHDPAHIHIEJ)
		{
			return default(global::OPHMNPOEIJD<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA3B0", Offset = "0x2CA97B0", VA = "0x182CAA3B0")]
		private (global::LAJJDKPAKGO<Entity>, global::LAJJDKPAKGO<Entity>) OBLMKOHGFNG(global::OPHMNPOEIJD<Entity> AFHADBBIJGD)
		{
			return default((global::LAJJDKPAKGO<Entity>, global::LAJJDKPAKGO<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA1F0", Offset = "0x2CA95F0", VA = "0x182CAA1F0")]
		private void JKNLGHKKMNK(out NativeArray<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA090", Offset = "0x2CA9490", VA = "0x182CAA090")]
		private void JHOKJIENKNL(NativeList<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA120", Offset = "0x2CA9520", VA = "0x182CAA120")]
		private void JHOKJIENKNL(NativeArray<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2CAA280", Offset = "0x2CA9680", VA = "0x182CAA280")]
		private void LMMIPCCGCKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		private static void PCCFNGGHCBH(int GANIMDMKOOI, int HOIFHKCGLDD, int IBFAPHPMCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9A20", Offset = "0x2CA8E20", VA = "0x182CA9A20")]
		private static HEKNCGOBJJM EDHLPIGCJBL(NativeArray<Entity> HLDFGGCKGHI, ComponentDataFromEntity<SplinePointPositionData> MJLNCGAIEAK, ComponentDataFromEntity<SplinePointScaleData> HFDOJEONIDF)
		{
			return default(HEKNCGOBJJM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal struct BJCNADHEMML : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[GBCOPIHPADE]
	[JLJFNDDLCBO(CBGNDNDJKHL.Lifecycle)]
	public class DestroyLocalObjects : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		[HIGIANBBMBE]
		private ObjectNetworkToLocalMapService DDKCFDAIGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		[HIGIANBBMBE]
		private ObjectLifecycleService MLGFPIININH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private EntityQuery IBMAPJDJKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery GDHEDENALGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery AHLPEAALMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private bool HIBODKPCONP;

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2B93C70", Offset = "0x2B93070", VA = "0x182B93C70", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x2B93860", Offset = "0x2B92C60", VA = "0x182B93860")]
		public bool FAKMKALLPKM(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x2B93B20", Offset = "0x2B92F20", VA = "0x182B93B20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x2B93910", Offset = "0x2B92D10", VA = "0x182B93910", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x2B93C50", Offset = "0x2B93050", VA = "0x182B93C50", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x12636A0", Offset = "0x1262AA0", VA = "0x1812636A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x2B93910", Offset = "0x2B92D10", VA = "0x182B93910")]
		private void JEPECMNCHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2B93A70", Offset = "0x2B92E70", VA = "0x182B93A70")]
		private void NPJDGEBHIIF(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2B93610", Offset = "0x2B92A10", VA = "0x182B93610")]
		private void ABNGFBINNGF(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2B93750", Offset = "0x2B92B50", VA = "0x182B93750")]
		private void DCLJAEAHDLH(NativeArray<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2B93950", Offset = "0x2B92D50", VA = "0x182B93950")]
		private void MHINNAPDLGF(NativeArray<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.NetworkSend)]
	public sealed class EnqueuePropertyDifferenceToNetwork : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private static NLOAJENALFM[] HAOFLPCADAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private HKKOGEPEJEA INICJGOJCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private FFMELNGKBPP FJJOJKLODEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private PropertyDiffStateService BNJGCBOJDEP;

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x2B99EB0", Offset = "0x2B992B0", VA = "0x182B99EB0", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2B99DF0", Offset = "0x2B991F0", VA = "0x182B99DF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2B99860", Offset = "0x2B98C60", VA = "0x182B99860")]
		private void HILBJPODKBN(NLOAJENALFM BADJHMHKPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		private void GINEFFGBIAD(Entity NOADJCMIKEF, JCHOAKCKPKK OMKLELDMIKD, FPGGICJALNG PKAAAJAKBGK, GMLMFELCCEC HCGDCMHABFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Callbacks)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	public sealed class PropertyEventCallbacks : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private PropertyEventCallbacksService LHHJJDCDFNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private PropertyDiffStateService BNJGCBOJDEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private TransformOwnershipPhase BADJHMHKPJJ;

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x29F4270", Offset = "0x29F3670", VA = "0x1829F4270", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x29F4170", Offset = "0x29F3570", VA = "0x1829F4170", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[JLJFNDDLCBO(CBGNDNDJKHL.NetworkSend)]
	internal class TransmitNetworkDataSystem : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private HGMEOMFEGBD CAIKFPBEKLJ;

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1E60", Offset = "0x2CB1260", VA = "0x182CB1E60", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x2CB1E10", Offset = "0x2CB1210", VA = "0x182CB1E10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[GBCOPIHPADE]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	public class CalculateCullingBandChanges : LOFKNNMMOFJ, MCPGEGOMHPG, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		[BurstCompile]
		private struct JGHBLEGJNIC : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			[ReadOnly]
			public ArchetypeChunkEntityType MIDKECEBKDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> BCIIJAAGHBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			[WriteOnly]
			public NativeList<LAKFHPPCOBH>.ParallelWriter DOKOJPGGFHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public ArchetypeChunkComponentType<LFPLFABEMLD> MANJEKGFFNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public float3 BCPKCLKDOEP;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private static readonly float4x2 ABEJOFPDLCG;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private static readonly float4x2 FPFLJLFNNDP;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			private static readonly int4x2 MFDJAHPJNNN;

			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x2CA0540", Offset = "0x2C9F940", VA = "0x182CA0540", Slot = "4")]
			public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private static DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private const int APFNJEKLPPB = 10;

		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private const double LNCGOJFLEOH = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private EntityQuery IOLCELCGHBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private EntityQuery NAHPEKFEGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private double INOFEOHFLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private LLOINIJEHPN GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private CullingBandService ELJPGOIACFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private TimeService NHCOCKHKBLA;

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B85B70", Offset = "0x2B84F70", VA = "0x182B85B70", Slot = "14")]
		public void FFHOKNLNLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x2B86230", Offset = "0x2B85630", VA = "0x182B86230", Slot = "15")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B85EC0", Offset = "0x2B852C0", VA = "0x182B85EC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B86010", Offset = "0x2B85410", VA = "0x182B86010", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2B85B00", Offset = "0x2B84F00", VA = "0x182B85B00")]
		private bool ALPFCGPAKBJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2B85B80", Offset = "0x2B84F80", VA = "0x182B85B80")]
		private void MFMEFDGOCNM(EntityQuery JHDPAHIHIEJ, float3 OFIBFMEDCNM, string DHKKANIEGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public struct LAKFHPPCOBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	public Entity NOADJCMIKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	public MIAPNMCOIGB EMCJDFHKAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	public MIAPNMCOIGB ADNCLAHHBEC;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	public class ProcessCullingBandChangeCallbacks : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private CullingBandService ELJPGOIACFN;

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x29F0BE0", Offset = "0x29EFFE0", VA = "0x1829F0BE0", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x29F0BC0", Offset = "0x29EFFC0", VA = "0x1829F0BC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Connectables)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	public class UpdateInertialProperties : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private EntityQuery NNAOEIMAKLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private FNOAHGOMEEJ PMJIOKOABOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8D00", Offset = "0x2CB8100", VA = "0x182CB8D00", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x2CB89D0", Offset = "0x2CB7DD0", VA = "0x182CB89D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8A60", Offset = "0x2CB7E60", VA = "0x182CB8A60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[GBCOPIHPADE]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> CIOLOBBMPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> PAOPMIIIEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> HKMNPDHEJHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private KinematicSleepChangeService BJGGHEKOPJH;

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B996F0", Offset = "0x2B98AF0", VA = "0x182B996F0", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B98F70", Offset = "0x2B98370", VA = "0x182B98F70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2B994A0", Offset = "0x2B988A0", VA = "0x182B994A0")]
		private void PBCOPMBDAIO(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MOBONMBAIDJ, EntityQueryDesc CLPMHEHGLDJ, bool GAOHKMMENID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x2B995B0", Offset = "0x2B989B0", VA = "0x182B995B0")]
		private void PBCOPMBDAIO(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MOBONMBAIDJ, EntityQueryDesc CLPMHEHGLDJ, bool GAOHKMMENID, bool EAMJDCGEMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x2B991D0", Offset = "0x2B985D0", VA = "0x182B991D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2B98380", Offset = "0x2B97780", VA = "0x182B98380")]
		private void ANCJCOBPGIM(EntityQuery JHDPAHIHIEJ, bool KDHGJKDDJOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2B985B0", Offset = "0x2B979B0", VA = "0x182B985B0")]
		private void DICNMPPGBOB(EntityQuery JHDPAHIHIEJ, bool HFHPNDPNEOL, bool KDHGJKDDJOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2B98920", Offset = "0x2B97D20", VA = "0x182B98920")]
		private void EMJICFICLNJ(NativeArray<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2B98210", Offset = "0x2B97610", VA = "0x182B98210")]
		private void AHJONDFMLJM(NativeList<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2B98800", Offset = "0x2B97C00", VA = "0x182B98800")]
		private void EKDPEOIBOCL(NativeArray<Entity> NPCFKLDOKOP, bool HFHPNDPNEOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2B98BD0", Offset = "0x2B97FD0", VA = "0x182B98BD0")]
		private NativeList<Entity> NBIOFKDGOHO(NativeArray<Entity> NPCFKLDOKOP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x2B98570", Offset = "0x2B97970", VA = "0x182B98570")]
		private NativeList<Entity> BONGOJJMCMN(NativeArray<Entity> NPCFKLDOKOP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x2B987C0", Offset = "0x2B97BC0", VA = "0x182B987C0")]
		private NativeList<Entity> DPBELGMNNKN(NativeArray<Entity> NPCFKLDOKOP)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x2B98DD0", Offset = "0x2B981D0", VA = "0x182B98DD0")]
		private NativeList<Entity> NKBHCFHLCMA(NativeArray<Entity> NPCFKLDOKOP, bool OMLHLIKOCNN)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x2B98B40", Offset = "0x2B97F40", VA = "0x182B98B40")]
		private HOEKOMKJJFB HCJNKFNDHDL(NativeArray<Entity> NPCFKLDOKOP)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(HOEKOMKJJFB);
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x2B99790", Offset = "0x2B98B90", VA = "0x182B99790")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private KinematicSleepChangeService BJGGHEKOPJH;

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x29F0C50", Offset = "0x29F0050", VA = "0x1829F0C50", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x29F0C30", Offset = "0x29F0030", VA = "0x1829F0C30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : PKIGKAPJAOK
	{
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private static DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private EntityQuery MEOOHFJLJPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private EntityQuery GMIKNPFJGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private EntityQuery NIINNKPLLIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private EntityQuery MECBDCIGPOG;

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2B93280", Offset = "0x2B92680", VA = "0x182B93280", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x2B93440", Offset = "0x2B92840", VA = "0x182B93440", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x2B92E00", Offset = "0x2B92200", VA = "0x182B92E00")]
		private void ANGJALIODEC(EntityQuery JHDPAHIHIEJ, bool GONKEOOFGON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B93040", Offset = "0x2B92440", VA = "0x182B93040")]
		private void LPNJEKILBFG(EntityQuery JHDPAHIHIEJ, bool GONKEOOFGON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Scope)]
	internal class AssignPlayerIdsSystem : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private LLOINIJEHPN GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private EntityQuery HIGDEOCFIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private EntityQuery KDPIIGBHCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private SceneService MEAJMIEKOFI;

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F5D0", Offset = "0x2B7E9D0", VA = "0x182B7F5D0", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F4A0", Offset = "0x2B7E8A0", VA = "0x182B7F4A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F5B0", Offset = "0x2B7E9B0", VA = "0x182B7F5B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F220", Offset = "0x2B7E620", VA = "0x182B7F220")]
		private void HMFNOKDKPFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F330", Offset = "0x2B7E730", VA = "0x182B7F330")]
		private void JADAJBKDBPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F640", Offset = "0x2B7EA40", VA = "0x182B7F640")]
		private void PJDOPDMIOEE(NativeArray<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x2B7F0E0", Offset = "0x2B7E4E0", VA = "0x182B7F0E0")]
		private void HHANOJPHEPE(NativeArray<Entity> NPCFKLDOKOP, int ILOHELMECIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x2B7EFD0", Offset = "0x2B7E3D0", VA = "0x182B7EFD0")]
		private void EOEDICECKJI(NativeArray<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2B7EF70", Offset = "0x2B7E370", VA = "0x182B7EF70")]
		private void EABEIBIOENP(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		private static void OFBOADDIGAO(int DLDPNOCIKPH, Transform KFAGMEKKLDA, Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
internal static class KOANMLBPCMC
{
	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9FD0", Offset = "0x2BC93D0", VA = "0x182BC9FD0")]
	public static bool AINKHGGLLDG(this SystemBase PLEONGBKEBJ, out Entity NOADJCMIKEF)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery IJEIMAENBLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private PENOFJBLKNM KMNCJICGJPP;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B87B40", Offset = "0x2B86F40", VA = "0x182B87B40", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B87A10", Offset = "0x2B86E10", VA = "0x182B87A10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x2B87AD0", Offset = "0x2B86ED0", VA = "0x182B87AD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Scope)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<MJGOJPDCEKO>, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private const string LBAFLEEGGOB = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private PHJMGMMMDFN IDOKKODNEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private EntityQuery OLMPCDLHAEK;

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		private Entity FBHCFGMKEEM
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0010", Offset = "0x2BCF410", VA = "0x182BD0010")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0x2BCFFB0", Offset = "0x2BCF3B0", VA = "0x182BCFFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		private Entity ANNDPJPDDBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x2BD00A0", Offset = "0x2BCF4A0", VA = "0x182BD00A0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public MOLBNKBNJLI CLAKCHAJBJC
		{
			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0x2BCFDD0", Offset = "0x2BCF1D0", VA = "0x182BCFDD0")]
			get
			{
				return default(MOLBNKBNJLI);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x2BD0240", Offset = "0x2BCF640", VA = "0x182BD0240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public MOLBNKBNJLI MLPNGECGNFM
		{
			[Cpp2IlInjected.Token(Token = "0x60008F2")]
			[Cpp2IlInjected.Address(RVA = "0x2BD02B0", Offset = "0x2BCF6B0", VA = "0x182BD02B0")]
			get
			{
				return default(MOLBNKBNJLI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0620", Offset = "0x2BCFA20", VA = "0x182BD0620", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0740", Offset = "0x2BCFB40", VA = "0x182BD0740", Slot = "15")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2BD06C0", Offset = "0x2BCFAC0", VA = "0x182BD06C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2BCFE60", Offset = "0x2BCF260", VA = "0x182BCFE60", Slot = "14")]
		protected override void BMDBPGBGDNO(NativeArray<Entity> NPCFKLDOKOP, NativeArray<Entity> PIEMMACENAP, NativeArray<Entity> ODAFPDGLMBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0100", Offset = "0x2BCF500", VA = "0x182BD0100")]
		private void JHLEKAKCOHJ(NativeArray<Entity> NPCFKLDOKOP, NativeArray<Entity> ODAFPDGLMBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0340", Offset = "0x2BCF740", VA = "0x182BD0340")]
		private void OLJAAIAJFIN(Entity NOADJCMIKEF, Entity OLKJNNMDHAL, Entity AFMMGGNCOCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x321E820", Offset = "0x321DC20", VA = "0x18321E820")]
		private bool HIJHOGNBHHL<T>(out T IGDJJEECDAF) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x321E760", Offset = "0x321DB60", VA = "0x18321E760")]
		private void CJCMGJAHJPM<T>(T IGDJJEECDAF) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x2BD01E0", Offset = "0x2BCF5E0", VA = "0x182BD01E0")]
		public bool KHEMGOOLKID(MOLBNKBNJLI JFNLNEKLEAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0070", Offset = "0x2BCF470", VA = "0x182BD0070")]
		private static bool JEFCOCJGEJH(MOLBNKBNJLI EDHCCOGJDJN, MOLBNKBNJLI GOGBGMNJABH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BD0800", Offset = "0x2BCFC00", VA = "0x182BD0800")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BD05E0", Offset = "0x2BCF9E0", VA = "0x182BD05E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Scope)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private EntityQuery JHDPAHIHIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x2B90470", Offset = "0x2B8F870", VA = "0x182B90470", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FF80", Offset = "0x2B8F380", VA = "0x182B8FF80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2B90020", Offset = "0x2B8F420", VA = "0x182B90020", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FE30", Offset = "0x2B8F230", VA = "0x182B8FE30")]
		private NativeArray<Entity> OBFJCBGMDMF(int LKJCGNNPEOE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x2B8FD20", Offset = "0x2B8F120", VA = "0x182B8FD20")]
		private void FPDHGIBEKPE(NativeArray<Entity> JPEBDFCCMBE, NativeArray<Entity> IFOLEICFMOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Scope)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	internal class HideRemotePivotsNotInScope : LOFKNNMMOFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery IACKPHFBPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery PHDAFOEOLMH;

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x2BC13F0", Offset = "0x2BC07F0", VA = "0x182BC13F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x2BC14E0", Offset = "0x2BC08E0", VA = "0x182BC14E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal static class NDKOCNBCECL
{
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public const string BOMEJKAOBKE = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x600090C")]
	[Cpp2IlInjected.Address(RVA = "0x30DCC30", Offset = "0x30DC030", VA = "0x1830DCC30")]
	public static NativeArray<T> KOHDPOCMGID<T>(NativeArray<Entity> NPCFKLDOKOP, EntityManager GKHNMAAJNKF) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x29D73D0", Offset = "0x29D67D0", VA = "0x1829D73D0")]
	public static void CBANCGOMDOP(EntityQuery JHDPAHIHIEJ, EntityManager GKHNMAAJNKF, FOKCOLGHCMD PIPGPNJGNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x29D7640", Offset = "0x29D6A40", VA = "0x1829D7640")]
	public static void PNKJLGMECPH(NativeArray<Entity> JPEBDFCCMBE, FOKCOLGHCMD PIPGPNJGNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x29D7510", Offset = "0x29D6910", VA = "0x1829D7510")]
	public static void FAMAEOIFAEM(NativeArray<Entity> JPEBDFCCMBE, FOKCOLGHCMD PIPGPNJGNIL)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.Scope)]
	internal class UpdateContainerPivotOnExitScopeSystem : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private EntityQuery JHDPAHIHIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private TransformService EDICDNMPJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private ObjectLifecycleService MLGFPIININH;

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2CB88F0", Offset = "0x2CB7CF0", VA = "0x182CB88F0", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8840", Offset = "0x2CB7C40", VA = "0x182CB8840", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2CB88E0", Offset = "0x2CB7CE0", VA = "0x182CB88E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2CB6F70", Offset = "0x2CB6370", VA = "0x182CB6F70")]
		private void AGJEGNCFMKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2CB82A0", Offset = "0x2CB76A0", VA = "0x182CB82A0")]
		private void KKEDJACHDDM(NativeArray<Entity> JPEBDFCCMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2CB7780", Offset = "0x2CB6B80", VA = "0x182CB7780")]
		private void BBIDHGHKHIN(NativeArray<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2CB8050", Offset = "0x2CB7450", VA = "0x182CB8050")]
		private void FMFOEJBCBGD(NativeArray<Entity> IFOLEICFMOD, NativeArray<RigidTransform> OMPLEBILPBB, NativeArray<RigidTransform> ADKDOKKBKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x2CB83B0", Offset = "0x2CB77B0", VA = "0x182CB83B0")]
		private void MNECBANECFP(NativeArray<RigidTransform> ADKDOKKBKBI, NativeArray<Entity> IFOLEICFMOD, NativeList<Entity> ILOKIOKBNKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Scope)]
	internal class PostGameplayOnScopeChange : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery IJEIMAENBLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private EntityQuery DGMMEABEHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private LLOINIJEHPN GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x29EF3E0", Offset = "0x29EE7E0", VA = "0x1829EF3E0", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x29EF1D0", Offset = "0x29EE5D0", VA = "0x1829EF1D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x29EF320", Offset = "0x29EE720", VA = "0x1829EF320", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x29EF160", Offset = "0x29EE560", VA = "0x1829EF160")]
		private void GHHOIKHKLNK(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Scope)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	internal class PreventDisembodiedScopesSystem : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EntityQuery EIFEAIFIHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityHierarchyParents INBNACIKDKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private PENOFJBLKNM KMNCJICGJPP;

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x29F0AE0", Offset = "0x29EFEE0", VA = "0x1829F0AE0", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x29F0A30", Offset = "0x29EFE30", VA = "0x1829F0A30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x29F0AD0", Offset = "0x29EFED0", VA = "0x1829F0AD0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x29F08A0", Offset = "0x29EFCA0", VA = "0x1829F08A0")]
		private void FJIOOEEEKIE(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.Scope)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<JBBJMJJDODD>
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2BD0", Offset = "0x2CA1FD0", VA = "0x182CA2BD0", Slot = "14")]
		protected override void BMDBPGBGDNO(NativeArray<Entity> NPCFKLDOKOP, NativeArray<Entity> PIEMMACENAP, NativeArray<Entity> ODAFPDGLMBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2D20", Offset = "0x2CA2120", VA = "0x182CA2D20")]
		[BurstCompile]
		private static void BMDBPGBGDNO(NativeArray<Entity> NPCFKLDOKOP, NativeArray<Entity> ODAFPDGLMBN, ComponentDataFromEntity<global::EPAEDEHOOHH> IEMHGLHHPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2E30", Offset = "0x2CA2230", VA = "0x182CA2E30")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2DF0", Offset = "0x2CA21F0", VA = "0x182CA2DF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : LOFKNNMMOFJ where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private EntityQuery JHDBLFDJOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery BKLLGBKEPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery CGDENEKADFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private EntityQuery IHMPBLHGNCB;

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCDF0", Offset = "0x2BDC1F0", VA = "0x182BDCDF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD1C0", Offset = "0x2BDC5C0", VA = "0x182BDD1C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD190", Offset = "0x2BDC590", VA = "0x182BDD190", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC1B0", Offset = "0x2BDB5B0", VA = "0x182BDC1B0")]
		private void GEIDMDGPAJK(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x2BDC5F0", Offset = "0x2BDB9F0", VA = "0x182BDC5F0")]
		private void NPLIGCKKDMK(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x2BDB4D0", Offset = "0x2BDA8D0", VA = "0x182BDB4D0")]
		private void AFHHNEDHDBI(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void BMDBPGBGDNO(NativeArray<Entity> NPCFKLDOKOP, NativeArray<Entity> PIEMMACENAP, NativeArray<Entity> ODAFPDGLMBN);

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2BDD250", Offset = "0x2BDC650", VA = "0x182BDD250")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCDD0", Offset = "0x2BDC1D0", VA = "0x182BDCDD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
public sealed class GLFHCCDFJJO : LOFKNNMMOFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	private List<(EntityQuery, ComponentType)> MOHHDKEKALA;

	[Cpp2IlInjected.Token(Token = "0x6000937")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBB50", Offset = "0x2BBAF50", VA = "0x182BBBB50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000938")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBD50", Offset = "0x2BBB150", VA = "0x182BBBD50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000939")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBEA0", Offset = "0x2BBB2A0", VA = "0x182BBBEA0")]
	public GLFHCCDFJJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093A")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct JOPENNGOLHC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	public int IJHDILKKDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	public int BBEGHBAAMGP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDAC0", Offset = "0x2BBCEC0", VA = "0x182BBDAC0")]
	public static Entity GFKKOGBEPBN(JOPENNGOLHC PNMIIEJFOON)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDAC0", Offset = "0x2BBCEC0", VA = "0x182BBDAC0")]
	public static JOPENNGOLHC GFKKOGBEPBN(Entity NOADJCMIKEF)
	{
		return default(JOPENNGOLHC);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct HDFGIBCKHBJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public struct DMOCJLJENND : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	public readonly ComponentType JNPJOKNNCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	public readonly NativeList<int> EJCKALBJGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	public readonly NativeList<int> OJLNJAPNHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	public readonly NativeArray<Entity> NPCFKLDOKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	public readonly NativeArray<Entity> MLDMPMFIFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	public readonly NativeArray<byte> DCDGNDLINEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly NativeArray<byte> NDIBANACJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public readonly int DMFGBKDHBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public readonly int CHFKHCLJJCK;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool ALAEMNAHAHN
	{
		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x2B91CD0", Offset = "0x2B910D0", VA = "0x182B91CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x2B91D50", Offset = "0x2B91150", VA = "0x182B91D50")]
	public DMOCJLJENND(ComponentType JNPJOKNNCJF, NativeList<int> EJCKALBJGLG, NativeList<int> OJLNJAPNHML, NativeArray<Entity> NPCFKLDOKOP, NativeArray<Entity> MLDMPMFIFBD, NativeArray<byte> DCDGNDLINEF, NativeArray<byte> NDIBANACJCD, int DMFGBKDHBAC, int CHFKHCLJJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x2B91AB0", Offset = "0x2B90EB0", VA = "0x182B91AB0")]
	private PEABCJAGJAH JFBGNFMMCFD(NativeArray<byte> ICPECNGAFCL, int HMJKJGLHFKE)
	{
		return default(PEABCJAGJAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	private T JFBGNFMMCFD<T>(NativeArray<byte> ICPECNGAFCL, int HMJKJGLHFKE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x2B91A60", Offset = "0x2B90E60", VA = "0x182B91A60")]
	public PEABCJAGJAH FPBMNFKMNBC(int HMJKJGLHFKE)
	{
		return default(PEABCJAGJAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	public T FPBMNFKMNBC<T>(int HMJKJGLHFKE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x2B91930", Offset = "0x2B90D30", VA = "0x182B91930")]
	public PEABCJAGJAH DIMGBKOJCJI(int HMJKJGLHFKE)
	{
		return default(PEABCJAGJAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	public T DIMGBKOJCJI<T>(int HMJKJGLHFKE) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x2B91980", Offset = "0x2B90D80", VA = "0x182B91980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public readonly struct BIOPNJAEFAF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public readonly EntityQuery JHDPAHIHIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public readonly NativeArray<NDCOJIPDPGC> OEKBACMEEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public readonly ComponentType JNPJOKNNCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	public readonly int DMFGBKDHBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	public readonly int CHFKHCLJJCK;

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x2B80DE0", Offset = "0x2B801E0", VA = "0x182B80DE0")]
	public BIOPNJAEFAF(ComponentType JNPJOKNNCJF, int DMFGBKDHBAC, int CHFKHCLJJCK, EntityQuery JHDPAHIHIEJ, NativeArray<NDCOJIPDPGC> OEKBACMEEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x2B80D90", Offset = "0x2B80190", VA = "0x182B80D90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct HJEAGFELBGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	public int HMJKJGLHFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public int KKBIBGELFFG;

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x699050", Offset = "0x698450", VA = "0x180699050")]
	public HJEAGFELBGM(int HMJKJGLHFKE, int KKBIBGELFFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct NDCOJIPDPGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public readonly int FHAPAHAAKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public readonly int DEBAMGFBJEH;

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x699050", Offset = "0x698450", VA = "0x180699050")]
	public NDCOJIPDPGC(int FHAPAHAAKAH, int DEBAMGFBJEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public struct GMLMFELCCEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	private readonly EEJFBJIDABN KDFBMFGPICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	private readonly int DMFGBKDHBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private unsafe readonly byte* DCDGNDLINEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private unsafe readonly byte* NDIBANACJCD;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool EFFOACKHLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBC010", Offset = "0x2BBB410", VA = "0x182BBC010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public EEJFBJIDABN JHEAENOKMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x729E20", Offset = "0x729220", VA = "0x180729E20")]
		get
		{
			return default(EEJFBJIDABN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC020", Offset = "0x2BBB420", VA = "0x182BBC020")]
	public PEABCJAGJAH PLMLPGECCHB(Type FPPBLNEEHBP)
	{
		return default(PEABCJAGJAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x2BBBF20", Offset = "0x2BBB320", VA = "0x182BBBF20")]
	public PEABCJAGJAH CCILGAPMOBO(Type FPPBLNEEHBP)
	{
		return default(PEABCJAGJAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EC80", Offset = "0x1F6E080", VA = "0x181F6EC80")]
	public T PLMLPGECCHB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EC60", Offset = "0x1F6E060", VA = "0x181F6EC60")]
	public T CCILGAPMOBO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC110", Offset = "0x2BBB510", VA = "0x182BBC110")]
	public unsafe GMLMFELCCEC(EEJFBJIDABN KDFBMFGPICB, int DEBAMGFBJEH, byte* DCDGNDLINEF, byte* NDIBANACJCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal abstract class MMBIKHNFNCD : CGHAJPCIAGI, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private PropertyDiffStateService BNJGCBOJDEP;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected abstract NLOAJENALFM PALAAPMBKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x29D7150", Offset = "0x29D6550", VA = "0x1829D7150", Slot = "17")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x29D70B0", Offset = "0x29D64B0", VA = "0x1829D70B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x29D6E70", Offset = "0x29D6270", VA = "0x1829D6E70", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	protected MMBIKHNFNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public static class AHHJOPPODNB
{
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] JEKLOAKHAOC;
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[DefaultMember("Item")]
internal class OBKBMHJLOIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly DLHDGHMPCLG HCDIHNPPHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly Dictionary<ComponentType, BIOPNJAEFAF> CBCNHJOHDGG;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public BIOPNJAEFAF HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x29D90F0", Offset = "0x29D84F0", VA = "0x1829D90F0")]
		get
		{
			return default(BIOPNJAEFAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x29D9180", Offset = "0x29D8580", VA = "0x1829D9180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	[Cpp2IlInjected.Address(RVA = "0x29D9A10", Offset = "0x29D8E10", VA = "0x1829D9A10")]
	public OBKBMHJLOIB(NHLELLEJLGC KIJOKICGGNE, DLHDGHMPCLG HCDIHNPPHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	[Cpp2IlInjected.Address(RVA = "0x29D9080", Offset = "0x29D8480", VA = "0x1829D9080")]
	public bool GAMCGCGFADK(ComponentType JNPJOKNNCJF, out BIOPNJAEFAF IJBJEBDOLMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	[Cpp2IlInjected.Address(RVA = "0x29D9980", Offset = "0x29D8D80", VA = "0x1829D9980")]
	public Dictionary<ComponentType, BIOPNJAEFAF>.Enumerator PEKBJENCCON()
	{
		return default(Dictionary<ComponentType, BIOPNJAEFAF>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x29D8EF0", Offset = "0x29D82F0", VA = "0x1829D8EF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x29D91D0", Offset = "0x29D85D0", VA = "0x1829D91D0")]
	private void NANOKFCMJNM(IEnumerable<GAPCPBFJDMJ> ANINBOKNBML, EntityManager GKHNMAAJNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x29D98D0", Offset = "0x29D8CD0", VA = "0x1829D98D0")]
	private static int OMHBLDPJIIJ(GAPCPBFJDMJ FACBMGLIPGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x29D9630", Offset = "0x29D8A30", VA = "0x1829D9630")]
	private static NativeArray<NDCOJIPDPGC> ODMGAMDAMLM(GAPCPBFJDMJ FACBMGLIPGD, Allocator JLPBABJNDBH = Allocator.Persistent)
	{
		return default(NativeArray<NDCOJIPDPGC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal interface IJGOABCPHPF
{
	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool ALAEMNAHAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	World GBENHADGLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MFHEHDOOFGP(out NativeArray<int> GLFMADCFEPH, Allocator JLPBABJNDBH);

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HOPKFGKDGHH(ComponentType JNPJOKNNCJF, out DMOCJLJENND HABFLBKGIKH, out BIOPNJAEFAF KPBJLEKIMFF);

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HOPKFGKDGHH(ComponentType JNPJOKNNCJF, out DMOCJLJENND HABFLBKGIKH);

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DMOCJLJENND KFHKBPLMBBG(ComponentType JNPJOKNNCJF);

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AKJEFONBMMI POOLIOEFPLK();

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HDBPLMMPBDA(JobHandle JAACMKMPHFI);
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
internal interface HCJCLJLDNOK
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	World GBENHADGLKA
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	OBKBMHJLOIB OHPIHEINELB
	{
		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	GHNILEILBLO INPLJPKGNNI
	{
		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	NativeMultiHashMap<Entity, GMLMFELCCEC> DDEKDKJCCHC
	{
		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	JobHandle EBHBIPBPPFB
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
	bool KELJHIKJDOE();

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BNMOGLEIOOC();

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HDHDIFFKIHD(ComponentType JNPJOKNNCJF, in DMOCJLJENND NCLBIHHOKFJ);

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OOFJDFOPNHN(APCEPJKMKDM BKEDDPMCLJC, out Entity JLHMEAKALNB);
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal struct AKJEFONBMMI
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	public struct MFCOCIDBAGJ : IEnumerator<GMLMFELCCEC>, IEnumerator, IDisposable, IEnumerable<GMLMFELCCEC>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private readonly NativeMultiHashMap<Entity, GMLMFELCCEC> LJGGGAEIPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private readonly Entity NOADJCMIKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private NativeMultiHashMapIterator<Entity> DMHCHDCEFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private GMLMFELCCEC NDIBANACJCD;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		public GMLMFELCCEC BHDIBOCECJI
		{
			[Cpp2IlInjected.Token(Token = "0x600097E")]
			[Cpp2IlInjected.Address(RVA = "0xD77610", Offset = "0xD76A10", VA = "0x180D77610", Slot = "4")]
			get
			{
				return default(GMLMFELCCEC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600097F")]
			[Cpp2IlInjected.Address(RVA = "0x2CA1850", Offset = "0x2CA0C50", VA = "0x182CA1850", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600097A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA18A0", Offset = "0x2CA0CA0", VA = "0x182CA18A0")]
		internal MFCOCIDBAGJ(NativeMultiHashMap<Entity, GMLMFELCCEC> LJGGGAEIPBP, Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600097D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1610", Offset = "0x2CA0A10", VA = "0x182CA1610", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000980")]
		[Cpp2IlInjected.Address(RVA = "0x2CA16E0", Offset = "0x2CA0AE0", VA = "0x182CA16E0")]
		public MFCOCIDBAGJ PEKBJENCCON()
		{
			return default(MFCOCIDBAGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000981")]
		[Cpp2IlInjected.Address(RVA = "0x2CA1710", Offset = "0x2CA0B10", VA = "0x182CA1710", Slot = "9")]
		private IEnumerator<GMLMFELCCEC> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000982")]
		[Cpp2IlInjected.Address(RVA = "0x2CA17B0", Offset = "0x2CA0BB0", VA = "0x182CA17B0", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly HCJCLJLDNOK OHACFAMPHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly JobHandle FNGIIDNMGJC;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public int OLDCMIGBIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x2B7C850", Offset = "0x2B7BC50", VA = "0x182B7C850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool IGFHGDGAIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x2B7CBD0", Offset = "0x2B7BFD0", VA = "0x182B7CBD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x1D57CA0", Offset = "0x1D570A0", VA = "0x181D57CA0")]
	public AKJEFONBMMI(HCJCLJLDNOK OHACFAMPHAM, JobHandle FNGIIDNMGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C710", Offset = "0x2B7BB10", VA = "0x182B7C710")]
	public bool CBIGHHPHLBL(Allocator JLPBABJNDBH, out NativeKeyValueArrays<Entity, GMLMFELCCEC> MHKNFNJAIIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C940", Offset = "0x2B7BD40", VA = "0x182B7C940")]
	public bool ILMPCKDIIPI(Allocator JLPBABJNDBH, out (NativeArray<Entity> entities, int uniqueCount) MHKNFNJAIIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x2B7CAB0", Offset = "0x2B7BEB0", VA = "0x182B7CAB0")]
	public MFCOCIDBAGJ PDJMKCNAOPH(Entity NOADJCMIKEF)
	{
		return default(MFCOCIDBAGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[DefaultMember("Item")]
internal class GHNILEILBLO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	private readonly DLHDGHMPCLG HCDIHNPPHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	private readonly List<BIOPNJAEFAF> MOBONMBAIDJ;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public BIOPNJAEFAF HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB060", Offset = "0x2BBA460", VA = "0x182BBB060")]
		get
		{
			return default(BIOPNJAEFAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB0F0", Offset = "0x2BBA4F0", VA = "0x182BBB0F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB4F0", Offset = "0x2BBA8F0", VA = "0x182BBB4F0")]
	public GHNILEILBLO(OBKBMHJLOIB CBCNHJOHDGG, NHLELLEJLGC KIJOKICGGNE, DLHDGHMPCLG HCDIHNPPHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB470", Offset = "0x2BBA870", VA = "0x182BBB470")]
	public List<BIOPNJAEFAF>.Enumerator PEKBJENCCON()
	{
		return default(List<BIOPNJAEFAF>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x2BBAEE0", Offset = "0x2BBA2E0", VA = "0x182BBAEE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB130", Offset = "0x2BBA530", VA = "0x182BBB130")]
	private void NANOKFCMJNM(OBKBMHJLOIB CBCNHJOHDGG, EntityManager GKHNMAAJNKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class LBGPMNCANKE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	private readonly DLHDGHMPCLG HCDIHNPPHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private readonly ObjectInstantiationService EINHMHCOFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private readonly global::ECNCBCGDDPA<GAPCPBFJDMJ> JKEBNCGMFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly World OJNPBOJPPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly EntityManager GKHNMAAJNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private NativeHashMap<int, Entity> KLABEDFFMEG;

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD160", Offset = "0x2BCC560", VA = "0x182BCD160")]
	public LBGPMNCANKE(ObjectInstantiationService EINHMHCOFBL, NHLELLEJLGC KIJOKICGGNE, DLHDGHMPCLG HCDIHNPPHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC340", Offset = "0x2BCB740", VA = "0x182BCC340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD100", Offset = "0x2BCC500", VA = "0x182BCD100")]
	public bool PKONOOGOACH(APCEPJKMKDM BKEDDPMCLJC, out Entity JLHMEAKALNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x2BCBB30", Offset = "0x2BCAF30", VA = "0x182BCBB30")]
	private void CDDPFAJGPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC840", Offset = "0x2BCBC40", VA = "0x182BCC840")]
	private EntityArchetype FKEFBMOIIEM(EntityArchetype NGLAMBAOBHG)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC410", Offset = "0x2BCB810", VA = "0x182BCC410")]
	public static void FHEJGLHFEBA(EntityManager LINAKECBAOI, EntityManager MDOCLMBGOPL, NativeArray<Entity> CLKOPKILJMP, NativeArray<EntityArchetype> DOLJKHBHAGM, [Optional] NativeArray<Entity> BACECEODEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x2BCCF90", Offset = "0x2BCC390", VA = "0x182BCCF90")]
	[Conditional("DEBUG_BUILD")]
	private static void OKCIILBKEGM(NativeArray<EntityArchetype> JPPLMAIBBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB8F0", Offset = "0x2BCACF0", VA = "0x182BCB8F0")]
	private static string ALGJFNADCFK(EntityArchetype GMPHNAMECNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x2BCCD70", Offset = "0x2BCC170", VA = "0x182BCCD70")]
	[CompilerGenerated]
	internal static void LDFBGAEOAFI(ref Span<ComponentType> JKNEBFNAKMG, ComponentType IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x2BCC190", Offset = "0x2BCB590", VA = "0x182BCC190")]
	[CompilerGenerated]
	internal static void DKKFBJDKJKA(Span<ComponentType> ICPECNGAFCL, ref Span<ComponentType> JKNEBFNAKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x2BCCEB0", Offset = "0x2BCC2B0", VA = "0x182BCCEB0")]
	[CompilerGenerated]
	internal static void LJKOFAJBFFH(Span<ComponentType> ICPECNGAFCL, ref Span<ComponentType> JKNEBFNAKMG, ComponentType IGAPKNCJKBI)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.PropertyChanges)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld EKMHLJNODEN;

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x2B7EEB0", Offset = "0x2B7E2B0", VA = "0x182B7EEB0", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x2B7EE00", Offset = "0x2B7E200", VA = "0x182B7EE00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[AlwaysUpdateSystem]
	[JLJFNDDLCBO(CBGNDNDJKHL.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : LOFKNNMMOFJ, LNLPIGELLPM, ENMEIFNEMLK
	{
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		[BurstCompile]
		internal struct KCKMCBJJKCA : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			[ReadOnly]
			public NativeArray<byte> FLEIPOFHOKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			[ReadOnly]
			public NativeArray<byte> MINOPNGBADL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			[ReadOnly]
			public NativeArray<NDCOJIPDPGC> PJDMIDKLEPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			[WriteOnly]
			public NativeList<HJEAGFELBGM>.ParallelWriter ELDNADBKEOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public int POHOONJPPCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public int NHGKFKOIILH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public ProfilerMarker EMMIJIMGOLL;

			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x2CA0D20", Offset = "0x2CA0120", VA = "0x182CA0D20", Slot = "4")]
			public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x2CA0E60", Offset = "0x2CA0260", VA = "0x182CA0E60")]
			private unsafe int LHFEEPINMIK(byte* JAICMPGGFMD, byte* HEKOHKDELMN)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000152")]
		[BurstCompile]
		internal struct KOKICPGPIGK : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			[WriteOnly]
			public NativeList<int> EJCKALBJGLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			[WriteOnly]
			public NativeList<int> OIOEGGKIHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			[ReadOnly]
			public NativeList<HJEAGFELBGM> MIGAEKBCKPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public ProfilerMarker EMMIJIMGOLL;

			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0x2CA0EF0", Offset = "0x2CA02F0", VA = "0x182CA0EF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000153")]
		[BurstCompile]
		internal struct HLIHDBDFPCD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			[WriteOnly]
			public NativeArray<byte> JBNKFDFEAGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			[ReadOnly]
			public NativeArray<Entity> NPCFKLDOKOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			[ReadOnly]
			public GHPFKCKCCJM PMMAONLHBLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			public int DMFGBKDHBAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public ProfilerMarker EMMIJIMGOLL;

			[Cpp2IlInjected.Token(Token = "0x60009B8")]
			[Cpp2IlInjected.Address(RVA = "0x2C9FB00", Offset = "0x2C9EF00", VA = "0x182C9FB00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct KBLLMCPLDMC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, GMLMFELCCEC> HBCIDAAKFGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			[ReadOnly]
			public NativeArray<byte> DCDGNDLINEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			[ReadOnly]
			public NativeArray<byte> NDIBANACJCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<Entity> NPCFKLDOKOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<NDCOJIPDPGC> JBEGFEHPGKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeList<int> OJLNJAPNHML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[ReadOnly]
			public NativeList<int> EJCKALBJGLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int CFDJIOAIMFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int CHFKHCLJJCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker EMMIJIMGOLL;

			[Cpp2IlInjected.Token(Token = "0x60009B9")]
			[Cpp2IlInjected.Address(RVA = "0x2CA0AA0", Offset = "0x2C9FEA0", VA = "0x182CA0AA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private static readonly ProfilerMarker AOFMHJBDHIA;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private static readonly ProfilerMarker CIGDJLLIDGF;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private static readonly ProfilerMarker KMABHICBKEF;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private static readonly ProfilerMarker GIEPHMKJIEB;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly ProfilerMarker KBEMCCDHKDE;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private static readonly ProfilerMarker GABLLIIPGJB;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private static readonly ProfilerMarker PNOAPMCAJOL;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private static readonly ProfilerMarker GHMJPMBNOMP;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private static readonly ProfilerMarker FOFGIANEKMD;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private static readonly ProfilerMarker OPLCLDKIJPI;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private static readonly ProfilerMarker KJBDAPJEKLD;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private static readonly ProfilerMarker KDBGGPNKFNG;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private static readonly ProfilerMarker ADFOJAOFLCA;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private static readonly ProfilerMarker IIKDBJAMNMG;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private static readonly ProfilerMarker BCJBCBACFDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private PropertyDiffStateService BNJGCBOJDEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private EntityQuery DOILICGBFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private EntityQuery JPOOBOCKIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private EntityQuery AHLPEAALMII;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		internal World GBENHADGLKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x2B888C0", Offset = "0x2B87CC0", VA = "0x182B888C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private HCJCLJLDNOK OOHCKBPJKAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x2B88B90", Offset = "0x2B87F90", VA = "0x182B88B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AA90", Offset = "0x2B89E90", VA = "0x182B8AA90", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "15")]
		public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A790", Offset = "0x2B89B90", VA = "0x182B8A790", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A950", Offset = "0x2B89D50", VA = "0x182B8A950", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A8E0", Offset = "0x2B89CE0", VA = "0x182B8A8E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x2B87BE0", Offset = "0x2B86FE0", VA = "0x182B87BE0")]
		private void DGKMMJDEDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B89960", Offset = "0x2B88D60", VA = "0x182B89960")]
		internal void MCBLLEBMGHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B89190", Offset = "0x2B88590", VA = "0x182B89190")]
		private void MCBLLEBMGHK(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x2B8A550", Offset = "0x2B89950", VA = "0x182B8A550")]
		private void OCAIFLEPDBL(NativeArray<Entity> CLKOPKILJMP, NativeArray<RRObjectPrefabData> PCOIDJDHALD, ref NativeArray<Entity> EICMLCFFAPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B88D70", Offset = "0x2B88170", VA = "0x182B88D70")]
		internal void MAGAOFKNDEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B88D90", Offset = "0x2B88190", VA = "0x182B88D90")]
		private void MAGAOFKNDEJ(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B87EA0", Offset = "0x2B872A0", VA = "0x182B87EA0")]
		internal void EENKHGNOCGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B8AAE0", Offset = "0x2B89EE0", VA = "0x182B8AAE0")]
		private void PIPOGHAKGFC(HCJCLJLDNOK OHACFAMPHAM, BIOPNJAEFAF KPBJLEKIMFF, bool MEJMGBDAMLC, ref JobHandle CDHNAMHDNLH, ref JobHandle BAMJGCLAOJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B89BF0", Offset = "0x2B88FF0", VA = "0x182B89BF0")]
		internal bool NNFDIBCHIDB(in BIOPNJAEFAF HEKOHKDELMN, out JobHandle CPAMCPHEBME, out DMOCJLJENND MELFLBHGBHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B89C20", Offset = "0x2B89020", VA = "0x182B89C20")]
		private bool NNFDIBCHIDB(in BIOPNJAEFAF HEKOHKDELMN, bool MEJMGBDAMLC, out JobHandle CPAMCPHEBME, out DMOCJLJENND MELFLBHGBHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A9")]
		[Cpp2IlInjected.Address(RVA = "0x2B88BB0", Offset = "0x2B87FB0", VA = "0x182B88BB0")]
		internal (NativeList<int>, NativeList<int>) KPDLEAADAFK(NativeList<HJEAGFELBGM> MIGAEKBCKPF, int OAKAJHNNELN, JobHandle IOPKJPIPCAB, out JobHandle JAACMKMPHFI, Allocator JLPBABJNDBH = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x2B88600", Offset = "0x2B87A00", VA = "0x182B88600")]
		internal static NativeArray<Entity> GNNHBJPOEFM(EntityQuery JHDPAHIHIEJ, out JobHandle BBENBPFHHGJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x2B88B10", Offset = "0x2B87F10", VA = "0x182B88B10")]
		internal static NativeArray<byte> KCLCJOKOGML(int EEMDNKKFCBK, out JobHandle LGNAGAFPIDO)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x2B887B0", Offset = "0x2B87BB0", VA = "0x182B887B0")]
		internal static NativeArray<byte> HLDCLFNOEOH(EntityQuery JHDPAHIHIEJ, int LGKEBNGGJEG, out JobHandle LGNAGAFPIDO)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2B886B0", Offset = "0x2B87AB0", VA = "0x182B886B0")]
		internal static NativeArray<Entity> GPNDMPIEIJE(EntityQuery JHDPAHIHIEJ, out JobHandle OECGEEGAGGM)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2B89980", Offset = "0x2B88D80", VA = "0x182B89980")]
		internal NativeArray<byte> MJIHFDMDIDI(NativeArray<Entity> NPCFKLDOKOP, BIOPNJAEFAF KPBJLEKIMFF, JobHandle IOPKJPIPCAB, out JobHandle JAACMKMPHFI, Allocator JLPBABJNDBH = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x2B88980", Offset = "0x2B87D80", VA = "0x182B88980")]
		internal JobHandle KAIIGJFKPPA(in DMOCJLJENND PNMIIEJFOON, in BIOPNJAEFAF KPBJLEKIMFF, NativeMultiHashMap<Entity, GMLMFELCCEC> HBCIDAAKFGK, JobHandle IOPKJPIPCAB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x1FA25A0", Offset = "0x1FA19A0", VA = "0x181FA25A0")]
		private JobHandle LENNAIBLLDP(JobHandle JOMHGLNADAB, JobHandle GHOIGLIMCCA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x1FA25A0", Offset = "0x1FA19A0", VA = "0x181FA25A0")]
		private JobHandle LENNAIBLLDP(JobHandle JOMHGLNADAB, JobHandle GHOIGLIMCCA, JobHandle FLPEOCDNADJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[JLJFNDDLCBO(CBGNDNDJKHL.RenderEffects)]
	internal class PropagateHoverRootTag : LGCNEAPNBIM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000156")]
		public struct COPPEHGNCHD : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		protected override ComponentType IKBMCJMJDGG
		{
			[Cpp2IlInjected.Token(Token = "0x60009BA")]
			[Cpp2IlInjected.Address(RVA = "0x29F1470", Offset = "0x29F0870", VA = "0x1829F1470", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override ComponentType LMMFNNCGOBL
		{
			[Cpp2IlInjected.Token(Token = "0x60009BB")]
			[Cpp2IlInjected.Address(RVA = "0x29F14A0", Offset = "0x29F08A0", VA = "0x1829F14A0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override ComponentType CIAIKDECJDK
		{
			[Cpp2IlInjected.Token(Token = "0x60009BC")]
			[Cpp2IlInjected.Address(RVA = "0x29F1440", Offset = "0x29F0840", VA = "0x1829F1440", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x29F14D0", Offset = "0x29F08D0", VA = "0x1829F14D0")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[JLJFNDDLCBO(CBGNDNDJKHL.RenderEffects)]
	internal class PropagateSelectionRootTag : LGCNEAPNBIM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000158")]
		public struct GJADOKAGHLP : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType IKBMCJMJDGG
		{
			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x29F1510", Offset = "0x29F0910", VA = "0x1829F1510", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType LMMFNNCGOBL
		{
			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0x29F1540", Offset = "0x29F0940", VA = "0x1829F1540", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType CIAIKDECJDK
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x29F14E0", Offset = "0x29F08E0", VA = "0x1829F14E0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x29F14D0", Offset = "0x29F08D0", VA = "0x1829F14D0")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
[GBCOPIHPADE]
public class OMGHGBAAMKG : PKIGKAPJAOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private EntityQuery JHDPAHIHIEJ;

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x29DD510", Offset = "0x29DC910", VA = "0x1829DD510", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x29DD5A0", Offset = "0x29DC9A0", VA = "0x1829DD5A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public OMGHGBAAMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
[GBCOPIHPADE]
public class MDNKNIDEEDC : PKIGKAPJAOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct LHHKONOHIPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public LHHKONOHIPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct LFFOPMKLKLM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200015D")]
		private struct LFAOHIEDHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x200015E")]
			[NoAlias]
			public struct GHFEKDAAIBO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000450")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FFFFPJKPAID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000451")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime KPLOKEFJJMG;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity JFGOCIGDAGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> MKHCPOJEGNL;

			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x4331B10", Offset = "0x4330F10", VA = "0x184331B10")]
			public void EKCCIAECPJB(MDNKNIDEEDC CCBOANOIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x4331B70", Offset = "0x4330F70", VA = "0x184331B70")]
			public GHFEKDAAIBO PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
			{
				return default(GHFEKDAAIBO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public EntityManager GKHNMAAJNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public NativeList<Entity> KDECKBAPBHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private LFAOHIEDHOJ LMJJNNPOADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe LFAOHIEDHOJ.GHFEKDAAIBO* MDJEFIMEJIL;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate FJAIFPDNJOA;

		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PLBPILCDOPJ;

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x4331E40", Offset = "0x4331240", VA = "0x184331E40")]
		internal void ONOBDMKDAMO(Entity NOADJCMIKEF, SplinePointParentData COCHOPELBHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x4331EB0", Offset = "0x43312B0", VA = "0x184331EB0", Slot = "5")]
		public void ReadFromDisplayClass(ref LHHKONOHIPD BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x4331EC0", Offset = "0x43312C0", VA = "0x184331EC0", Slot = "6")]
		public void WriteToDisplayClass(ref LHHKONOHIPD BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x4331CF0", Offset = "0x43310F0", VA = "0x184331CF0", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x4331D90", Offset = "0x4331190", VA = "0x184331D90")]
		public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, [NoAlias] ref LFAOHIEDHOJ.GHFEKDAAIBO EHNBJOCHNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x4331C60", Offset = "0x4331060", VA = "0x184331C60")]
		public void EKCCIAECPJB(MDNKNIDEEDC CCBOANOIBAC, ref LHHKONOHIPD BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x4331BF0", Offset = "0x4330FF0", VA = "0x184331BF0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void DCIIHCJLOHN(ArchetypeChunkIterator* KALOJDJCBJG, void* DDDPFMDHKNE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery EPADGDCGFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private ProfilerMarker JJAEHPBDAEJ;

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1A90", Offset = "0x2BD0E90", VA = "0x182BD1A90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public MDNKNIDEEDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1860", Offset = "0x2BD0C60", VA = "0x182BD1860", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1700", Offset = "0x2BD0B00", VA = "0x182BD1700")]
	public static EntityQuery LPEMBMDBLMP(ComponentSystemBase CCBOANOIBAC)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015F")]
[GBCOPIHPADE]
public class IAJFKEGKFDC : PKIGKAPJAOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private EntityQuery KHPGHBIMMPI;

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3880", Offset = "0x2BC2C80", VA = "0x182BC3880", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3910", Offset = "0x2BC2D10", VA = "0x182BC3910", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public IAJFKEGKFDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[UpdateAfter(typeof(OMGHGBAAMKG))]
public class GABFIBEAMEJ : LOFKNNMMOFJ
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8C60", Offset = "0x2BB8060", VA = "0x182BB8C60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public GABFIBEAMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
public class KECLLLNPODH : PKIGKAPJAOK, LNLPIGELLPM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private struct AKKJLLAPKEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public NativeHashMap<JCHOAKCKPKK, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public AKKJLLAPKEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct JMGPLGCJEHO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		private struct PNBPHPPEBND
		{
			[Cpp2IlInjected.Token(Token = "0x2000165")]
			public struct JMHLAOFJBNB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400045D")]
				public LambdaParameterValueProvider_Entity.Runtime FFFFPJKPAID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400045E")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime JFDGKLDIFKC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity JFGOCIGDAGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CIMEGACNFNK;

			[Cpp2IlInjected.Token(Token = "0x60009EC")]
			[Cpp2IlInjected.Address(RVA = "0x4335190", Offset = "0x4334590", VA = "0x184335190")]
			public void EKCCIAECPJB(KECLLLNPODH CCBOANOIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009ED")]
			[Cpp2IlInjected.Address(RVA = "0x43351F0", Offset = "0x43345F0", VA = "0x1843351F0")]
			public JMHLAOFJBNB PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
			{
				return default(JMHLAOFJBNB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public NativeHashMap<JCHOAKCKPKK, Entity> LJGGGAEIPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private PNBPHPPEBND LMJJNNPOADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PNBPHPPEBND.JMHLAOFJBNB* MDJEFIMEJIL;

		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate FJAIFPDNJOA;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x432FA80", Offset = "0x432EE80", VA = "0x18432FA80")]
		internal void ONOBDMKDAMO(Entity NOADJCMIKEF, ObjectNetworkIdComponentData JFHCOEMHJHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2BC0", Offset = "0x2CA1FC0", VA = "0x182CA2BC0", Slot = "5")]
		public void ReadFromDisplayClass(ref AKKJLLAPKEH BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x2765B40", Offset = "0x2764F40", VA = "0x182765B40", Slot = "6")]
		public void WriteToDisplayClass(ref AKKJLLAPKEH BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x432F930", Offset = "0x432ED30", VA = "0x18432F930", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x432F9D0", Offset = "0x432EDD0", VA = "0x18432F9D0")]
		public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, ref PNBPHPPEBND.JMHLAOFJBNB EHNBJOCHNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x432F8A0", Offset = "0x432ECA0", VA = "0x18432F8A0")]
		public void EKCCIAECPJB(KECLLLNPODH CCBOANOIBAC, ref AKKJLLAPKEH BNHKJLMLEEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x432F830", Offset = "0x432EC30", VA = "0x18432F830")]
		public unsafe static void DCIIHCJLOHN(ArchetypeChunkIterator* KALOJDJCBJG, void* DDDPFMDHKNE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private ObjectNetworkToLocalMapService DDKCFDAIGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private EntityQuery EPADGDCGFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	private ProfilerMarker JJAEHPBDAEJ;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8320", Offset = "0x2BC7720", VA = "0x182BC8320", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x2BC81E0", Offset = "0x2BC75E0", VA = "0x182BC81E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public KECLLLNPODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7FE0", Offset = "0x2BC73E0", VA = "0x182BC7FE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x2BC7E80", Offset = "0x2BC7280", VA = "0x182BC7E80")]
	public static EntityQuery LPEMBMDBLMP(ComponentSystemBase CCBOANOIBAC)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public class OGCIFHKJFKO : PKIGKAPJAOK, LNLPIGELLPM
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct JEPIJKKLEMH : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000168")]
		private struct FANCPEKBKDE
		{
			[Cpp2IlInjected.Token(Token = "0x2000169")]
			public struct PCCPAEJGNNJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000468")]
				public LambdaParameterValueProvider_Entity.Runtime FFFFPJKPAID;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000469")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime HHINKPFNCDO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity JFGOCIGDAGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> GMNCHDGFCAL;

			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x432D090", Offset = "0x432C490", VA = "0x18432D090")]
			public void EKCCIAECPJB(OGCIFHKJFKO CCBOANOIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x432D0F0", Offset = "0x432C4F0", VA = "0x18432D0F0")]
			public PCCPAEJGNNJ PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
			{
				return default(PCCPAEJGNNJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public OGCIFHKJFKO BOCDJCBEJGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private FANCPEKBKDE LMJJNNPOADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FANCPEKBKDE.PCCPAEJGNNJ* MDJEFIMEJIL;

		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate FJAIFPDNJOA;

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x432F460", Offset = "0x432E860", VA = "0x18432F460")]
		public void ONOBDMKDAMO(Entity NOADJCMIKEF, ParentData LHIKOCNBFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x432F310", Offset = "0x432E710", VA = "0x18432F310", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x432F3B0", Offset = "0x432E7B0", VA = "0x18432F3B0")]
		public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, ref FANCPEKBKDE.PCCPAEJGNNJ EHNBJOCHNCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x432F290", Offset = "0x432E690", VA = "0x18432F290")]
		public void EKCCIAECPJB(OGCIFHKJFKO CCBOANOIBAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x432F220", Offset = "0x432E620", VA = "0x18432F220")]
		public unsafe static void DCIIHCJLOHN(ArchetypeChunkIterator* KALOJDJCBJG, void* DDDPFMDHKNE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private EntityQuery EPADGDCGFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private ProfilerMarker JJAEHPBDAEJ;

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x29DB280", Offset = "0x29DA680", VA = "0x1829DB280", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x29DB170", Offset = "0x29DA570", VA = "0x1829DB170", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public OGCIFHKJFKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x29DB2E0", Offset = "0x29DA6E0", VA = "0x1829DB2E0")]
	[CompilerGenerated]
	private void PIFHFEHIMHJ(Entity NOADJCMIKEF, ParentData LHIKOCNBFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x29DAF70", Offset = "0x29DA370", VA = "0x1829DAF70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x29DAE10", Offset = "0x29DA210", VA = "0x1829DAE10")]
	public static EntityQuery LPEMBMDBLMP(ComponentSystemBase CCBOANOIBAC)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public class LADPLDFBGNH : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private int FALNODLBMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private EntityQuery JHDPAHIHIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private ObjectPrefabs EINHMHCOFBL;

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB8A0", Offset = "0x2BCACA0", VA = "0x182BCB8A0", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB5E0", Offset = "0x2BCA9E0", VA = "0x182BCB5E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB6C0", Offset = "0x2BCAAC0", VA = "0x182BCB6C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x2BCB290", Offset = "0x2BCA690", VA = "0x182BCB290")]
	private void ABNKHNHEMIN(Entity NOADJCMIKEF, APCEPJKMKDM BKEDDPMCLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public LADPLDFBGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[UpdateBefore(typeof(LADPLDFBGNH))]
	[JLJFNDDLCBO(CBGNDNDJKHL.Serialization)]
	public class PostLoadAddSceneTagEntity : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private SceneService MEAJMIEKOFI;

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x29EF660", Offset = "0x29EEA60", VA = "0x1829EF660", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x29EF4A0", Offset = "0x29EE8A0", VA = "0x1829EF4A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Serialization)]
	[OKNDCPNCELC(GPPMCHFFAPH.OMRoom)]
	public class PostLoadInitializeNetworkId : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016D")]
		[CompilerGenerated]
		private struct BDLDBAGNOGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public NativeHashMap<JCHOAKCKPKK, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
			public BDLDBAGNOGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016E")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct CIDFEJEKJBO : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200016F")]
			private struct OCOHIOGIOCI
			{
				[Cpp2IlInjected.Token(Token = "0x2000170")]
				[NoAlias]
				public struct ELHNHKJELDF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400047E")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime FFFFPJKPAID;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400047F")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime OKNGDBBEHND;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000480")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime JFDGKLDIFKC;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity JFGOCIGDAGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_EntityInQueryIndex CIBLOOFNHGH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047D")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CIMEGACNFNK;

				[Cpp2IlInjected.Token(Token = "0x6000A19")]
				[Cpp2IlInjected.Address(RVA = "0x4333FE0", Offset = "0x43333E0", VA = "0x184333FE0")]
				public void EKCCIAECPJB(PostLoadInitializeNetworkId CCBOANOIBAC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A1A")]
				[Cpp2IlInjected.Address(RVA = "0x4334050", Offset = "0x4333450", VA = "0x184334050")]
				public ELHNHKJELDF PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
				{
					return default(ELHNHKJELDF);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public NativeHashMap<JCHOAKCKPKK, Entity> LJGGGAEIPBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private OCOHIOGIOCI LMJJNNPOADP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe OCOHIOGIOCI.ELHNHKJELDF* MDJEFIMEJIL;

			[Cpp2IlInjected.Token(Token = "0x4000479")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate FJAIFPDNJOA;

			[Cpp2IlInjected.Token(Token = "0x400047A")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate PLBPILCDOPJ;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x432B630", Offset = "0x432AA30", VA = "0x18432B630")]
			internal void ONOBDMKDAMO(Entity NOADJCMIKEF, int JKLCAKPAJNI, ref ObjectNetworkIdComponentData JFHCOEMHJHO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x2CA2BC0", Offset = "0x2CA1FC0", VA = "0x182CA2BC0", Slot = "5")]
			public void ReadFromDisplayClass(ref BDLDBAGNOGH BNHKJLMLEEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0x2765B40", Offset = "0x2764F40", VA = "0x182765B40", Slot = "6")]
			public void WriteToDisplayClass(ref BDLDBAGNOGH BNHKJLMLEEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x432B470", Offset = "0x432A870", VA = "0x18432B470", Slot = "4")]
			public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x432B560", Offset = "0x432A960", VA = "0x18432B560")]
			public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, [NoAlias] ref OCOHIOGIOCI.ELHNHKJELDF EHNBJOCHNCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0x432B3D0", Offset = "0x432A7D0", VA = "0x18432B3D0")]
			public void EKCCIAECPJB(PostLoadInitializeNetworkId CCBOANOIBAC, ref BDLDBAGNOGH BNHKJLMLEEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x432B360", Offset = "0x432A760", VA = "0x18432B360")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void DCIIHCJLOHN(ArchetypeChunkIterator* KALOJDJCBJG, void* DDDPFMDHKNE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[HIGIANBBMBE]
		private ObjectNetworkToLocalMapService DDKCFDAIGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		[HIGIANBBMBE]
		private SceneService EKPOPNOIBMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private EntityQuery JHDPAHIHIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private EntityQuery MNEFCPFJHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private ProfilerMarker GIMHIOKMNPB;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x29F0460", Offset = "0x29EF860", VA = "0x1829F0460", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x29F03B0", Offset = "0x29EF7B0", VA = "0x1829F03B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A08")]
		[Cpp2IlInjected.Address(RVA = "0x29F0450", Offset = "0x29EF850", VA = "0x1829F0450", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A09")]
		[Cpp2IlInjected.Address(RVA = "0x29EFB00", Offset = "0x29EEF00", VA = "0x1829EFB00")]
		public void OBOBKDEPGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0A")]
		[Cpp2IlInjected.Address(RVA = "0x29EFBD0", Offset = "0x29EEFD0", VA = "0x1829EFBD0")]
		private void ONCNPMLMHCE(NativeHashMap<JCHOAKCKPKK, Entity> LJGGGAEIPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0B")]
		[Cpp2IlInjected.Address(RVA = "0x29EF8A0", Offset = "0x29EECA0", VA = "0x1829EF8A0")]
		private void NPPDFOOPEMO(NativeHashMap<JCHOAKCKPKK, Entity> LJGGGAEIPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x29F0120", Offset = "0x29EF520", VA = "0x1829F0120", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x29EF700", Offset = "0x29EEB00", VA = "0x1829EF700")]
		public static EntityQuery LOFEAOPBDLB(ComponentSystemBase CCBOANOIBAC)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
public class BIIEJKPDGAB : LOFKNNMMOFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private EntityQuery CLIGANFGFMM;

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x2B80C60", Offset = "0x2B80060", VA = "0x182B80C60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x2B80CF0", Offset = "0x2B800F0", VA = "0x182B80CF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public BIIEJKPDGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
public class PIGJBPKJCKE : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private global::ECNCBCGDDPA<BEECNEOJECG> BIELOLLDIFP;

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x29EBD20", Offset = "0x29EB120", VA = "0x1829EBD20", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x29EBA20", Offset = "0x29EAE20", VA = "0x1829EBA20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x29EB680", Offset = "0x29EAA80", VA = "0x1829EB680")]
	private void HPFNHIIKECA(NativeList<EntityArchetype> JPPLMAIBBGO, NativeHashMap<int, IMOBLFIBELG> JHEAOHPMMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x29EB8E0", Offset = "0x29EACE0", VA = "0x1829EB8E0")]
	private Span<int> OBKLHJAFAGN(EntityArchetype GMPHNAMECNH)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x29EB810", Offset = "0x29EAC10", VA = "0x1829EB810")]
	private bool NJELDHDNFNJ(int LGKEBNGGJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x29EB080", Offset = "0x29EA480", VA = "0x1829EB080")]
	private void GNFNHHLPHPD(NativeHashMap<int, IMOBLFIBELG> JHEAOHPMMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public PIGJBPKJCKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000173")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Serialization)]
	public class PreSerializeRemoveEntities : LOFKNNMMOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private static DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery GLEOIKMPDID;

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x29F0520", Offset = "0x29EF920", VA = "0x1829F0520", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x29F07A0", Offset = "0x29EFBA0", VA = "0x1829F07A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[JLJFNDDLCBO(CBGNDNDJKHL.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		[CompilerGenerated]
		private struct GFFHNCDCLHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public GHPFKCKCCJM dstComponentData;

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
			[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
			public GFFHNCDCLHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A34")]
			[Cpp2IlInjected.Address(RVA = "0x2C9E590", Offset = "0x2C9D990", VA = "0x182C9E590")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[BurstCompile]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct LKGLBAPMDMP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			[ReadOnly]
			public NativeList<int> EJCKALBJGLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			[ReadOnly]
			public NativeArray<Entity> MLDMPMFIFBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public GHPFKCKCCJM NGGNNHPIBBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			[ReadOnly]
			public NativeArray<byte> NDIBANACJCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public int DMFGBKDHBAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public ComponentType JNPJOKNNCJF;

			[Cpp2IlInjected.Token(Token = "0x6000A35")]
			[Cpp2IlInjected.Address(RVA = "0x4332660", Offset = "0x4331A60", VA = "0x184332660")]
			internal void ONOBDMKDAMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A36")]
			[Cpp2IlInjected.Address(RVA = "0x4332820", Offset = "0x4331C20", VA = "0x184332820", Slot = "5")]
			public void ReadFromDisplayClass(ref GFFHNCDCLHE BNHKJLMLEEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A37")]
			[Cpp2IlInjected.Address(RVA = "0x4332650", Offset = "0x4331A50", VA = "0x184332650", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A38")]
			[Cpp2IlInjected.Address(RVA = "0x4332630", Offset = "0x4331A30", VA = "0x184332630")]
			public void EKCCIAECPJB(ShadowWorldApplyPropertyDifferencesToShadowWorld CCBOANOIBAC, ref GFFHNCDCLHE BNHKJLMLEEJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private PropertyDiffStateService BNJGCBOJDEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private JobHandle DCAOEGCHNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private JobHandle JLPBNDANADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private IJGOABCPHPF OHACFAMPHAM;

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9040", Offset = "0x2CA8440", VA = "0x182CA9040", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8C60", Offset = "0x2CA8060", VA = "0x182CA8C60")]
		public JobHandle NFBMJEEPDPJ(JobHandle IOPKJPIPCAB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8CA0", Offset = "0x2CA80A0", VA = "0x182CA8CA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8950", Offset = "0x2CA7D50", VA = "0x182CA8950")]
		private bool GBIMNIMGDOJ(JobHandle IOPKJPIPCAB, int LGKEBNGGJEG, out JobHandle OIDHKNIDMMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[ExecuteAlways]
[NIILAANKHKM]
[UpdateInGroup(typeof(AKLPCMBBDGP))]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
internal sealed class DBKMNIJGHOC : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2B90C80", Offset = "0x2B90080", VA = "0x182B90C80", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public DBKMNIJGHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[ExecuteAlways]
[NIILAANKHKM]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
[UpdateInGroup(typeof(PCNOCMLMLLL))]
internal sealed class FNCLFGFKGPD : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB8AA0", Offset = "0x2BB7EA0", VA = "0x182BB8AA0", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public FNCLFGFKGPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[NIILAANKHKM]
[ExecuteAlways]
[UpdateInGroup(typeof(IPAFJMCLHGI))]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
internal sealed class CFHPPJPCOLC : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x2B847E0", Offset = "0x2B83BE0", VA = "0x182B847E0", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public CFHPPJPCOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[ExecuteAlways]
[NIILAANKHKM]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
[UpdateInGroup(typeof(MGFOACDGJAL))]
internal sealed class EJMBECLPMOF : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x2B95130", Offset = "0x2B94530", VA = "0x182B95130", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public EJMBECLPMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal class LDHOPCHJKIO : MMBIKHNFNCD
{
	[Cpp2IlInjected.Token(Token = "0x17000122")]
	protected override NLOAJENALFM PALAAPMBKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x69EAA0", Offset = "0x69DEA0", VA = "0x18069EAA0", Slot = "18")]
		get
		{
			return default(NLOAJENALFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD600", Offset = "0x2BCCA00", VA = "0x182BCD600")]
	public LDHOPCHJKIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[ExecuteAlways]
[NIILAANKHKM]
[UpdateInGroup(typeof(DLOPILJGGDC))]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
internal sealed class IIINBJDGBAC : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3C60", Offset = "0x2BC3060", VA = "0x182BC3C60", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public IIINBJDGBAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
internal class BIOCANBNEOG : ADABOGHGFDG
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public BIOCANBNEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class LIBACFFNMEN : MMBIKHNFNCD
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	protected override NLOAJENALFM PALAAPMBKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "18")]
		get
		{
			return default(NLOAJENALFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x2BCD600", Offset = "0x2BCCA00", VA = "0x182BCD600")]
	public LIBACFFNMEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[ExecuteAlways]
[NIILAANKHKM]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
[UpdateInGroup(typeof(CIKJNEFGFPD))]
internal sealed class BHJFJOKNBDP : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x2B7FC70", Offset = "0x2B7F070", VA = "0x182B7FC70", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public BHJFJOKNBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class OPJMIHJKHOA : ADABOGHGFDG
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public OPJMIHJKHOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class CPDECOONOMO : ADABOGHGFDG
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public CPDECOONOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class IDJPFDFACKP : LOFKNNMMOFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public IDJPFDFACKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[GBCOPIHPADE]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
public class DFJGABNIJAM : LOFKNNMMOFJ, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	private TimeService NHCOCKHKBLA;

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2B91310", Offset = "0x2B90710", VA = "0x182B91310", Slot = "14")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x2B912F0", Offset = "0x2B906F0", VA = "0x182B912F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public DFJGABNIJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[JLJFNDDLCBO(CBGNDNDJKHL.TransformSyncing)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	public class CopyTransformDataFromGameObjects : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[BurstCompile]
		private struct HAOIIFFFMEM : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private const float MLCPCIPDPLF = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			[ReadOnly]
			public NativeArray<Entity> NPCFKLDOKOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> KKHBLGCCAKE;

			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F490", Offset = "0x2C9E890", VA = "0x182C9F490", Slot = "4")]
			public void Execute(int HMJKJGLHFKE, TransformAccess KFAGMEKKLDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A67")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F450", Offset = "0x2C9E850", VA = "0x182C9F450")]
			private bool BLPOGFEHEHF(float3 ADNCLAHHBEC, float3 EMCJDFHKAFD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A68")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F3E0", Offset = "0x2C9E7E0", VA = "0x182C9F3E0")]
			private bool BFFFNJKPOFK(quaternion ADNCLAHHBEC, quaternion EMCJDFHKAFD)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000186")]
		[BurstCompile]
		private struct MJJDHNBACLH : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			[ReadOnly]
			public NativeArray<Entity> NPCFKLDOKOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> LLEGPIDNGJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> FOBJCGBDPPG;

			[Cpp2IlInjected.Token(Token = "0x6000A69")]
			[Cpp2IlInjected.Address(RVA = "0x2CA18C0", Offset = "0x2CA0CC0", VA = "0x182CA18C0", Slot = "4")]
			public void Execute(int HMJKJGLHFKE, TransformAccess KFAGMEKKLDA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly DLHDGHMPCLG EIPEMAAEAJI;

		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private static readonly DLHDGHMPCLG FFIJDIKNCCK;

		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private static readonly DLHDGHMPCLG LNGDOFLEIPD;

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private static readonly ProfilerMarker KPOHNJLAKKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private MCNEBNEEKDO CEDJLBLPDNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private NHLELLEJLGC KIJOKICGGNE;

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E310", Offset = "0x2B8D710", VA = "0x182B8E310", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DF70", Offset = "0x2B8D370", VA = "0x182B8DF70", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x2B8DFA0", Offset = "0x2B8D3A0", VA = "0x182B8DFA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A65")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[JLJFNDDLCBO(CBGNDNDJKHL.TransformSyncing)]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	public class RegisterTransforms : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct EEPCJMPNCNF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018A")]
			private struct APHFDPLINCF
			{
				[Cpp2IlInjected.Token(Token = "0x200018B")]
				public struct EHDMMHKHCFJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004B7")]
					public LambdaParameterValueProvider_Entity.Runtime FFFFPJKPAID;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004B8")]
					public LambdaParameterValueProvider_IComponentData<OBMFMEFEIJG>.Runtime BMMFPKEEABO;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004B9")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime LIFAHJHDELG;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity JFGOCIGDAGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004B5")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<OBMFMEFEIJG> MKBGAHFCFIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004B6")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> NGPOAPNDBCO;

				[Cpp2IlInjected.Token(Token = "0x6000A84")]
				[Cpp2IlInjected.Address(RVA = "0x432A520", Offset = "0x4329920", VA = "0x18432A520")]
				public void EKCCIAECPJB(RegisterTransforms CCBOANOIBAC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A85")]
				[Cpp2IlInjected.Address(RVA = "0x432A5A0", Offset = "0x43299A0", VA = "0x18432A5A0")]
				public EHDMMHKHCFJ PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
				{
					return default(EHDMMHKHCFJ);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private APHFDPLINCF LMJJNNPOADP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe APHFDPLINCF.EHDMMHKHCFJ* MDJEFIMEJIL;

			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate FJAIFPDNJOA;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x432BFB0", Offset = "0x432B3B0", VA = "0x18432BFB0")]
			internal void ONOBDMKDAMO(Entity NOADJCMIKEF, OBMFMEFEIJG LMNNOEJODCP, Transform KFAGMEKKLDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x432BDE0", Offset = "0x432B1E0", VA = "0x18432BDE0", Slot = "4")]
			public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x432BED0", Offset = "0x432B2D0", VA = "0x18432BED0")]
			public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, ref APHFDPLINCF.EHDMMHKHCFJ EHNBJOCHNCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x432BDD0", Offset = "0x432B1D0", VA = "0x18432BDD0")]
			public void EKCCIAECPJB(RegisterTransforms CCBOANOIBAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x432BD60", Offset = "0x432B160", VA = "0x18432BD60")]
			public unsafe static void DCIIHCJLOHN(ArchetypeChunkIterator* KALOJDJCBJG, void* DDDPFMDHKNE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct NKBNCJNDFIB : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct AAFNFCBEAPI
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				[NoAlias]
				public struct KMLJLDFGKGO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004BE")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime FFFFPJKPAID;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004BF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<OBMFMEFEIJG>.Runtime BMMFPKEEABO;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004BC")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity JFGOCIGDAGP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004BD")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<OBMFMEFEIJG> MKBGAHFCFIM;

				[Cpp2IlInjected.Token(Token = "0x6000A8A")]
				[Cpp2IlInjected.Address(RVA = "0x432A080", Offset = "0x4329480", VA = "0x18432A080")]
				public void EKCCIAECPJB(RegisterTransforms CCBOANOIBAC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A8B")]
				[Cpp2IlInjected.Address(RVA = "0x432A0E0", Offset = "0x43294E0", VA = "0x18432A0E0")]
				public KMLJLDFGKGO PMFLMJEIKFA(ref ArchetypeChunk MNJMDEGHILP, int KPLKIBABPFN, int MDKDEBNBHHE)
				{
					return default(KMLJLDFGKGO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			private AAFNFCBEAPI LMJJNNPOADP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe AAFNFCBEAPI.KMLJLDFGKGO* MDJEFIMEJIL;

			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x4333F00", Offset = "0x4333300", VA = "0x184333F00")]
			internal void ONOBDMKDAMO(Entity NOADJCMIKEF, OBMFMEFEIJG LMNNOEJODCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x4333DC0", Offset = "0x43331C0", VA = "0x184333DC0", Slot = "4")]
			public void Execute(ArchetypeChunk PPHKNFIBCEA, int PBMFIGFDOII, int LGNDKNJJOHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0x4333E50", Offset = "0x4333250", VA = "0x184333E50")]
			public void OCFFOKHEFFM(ref ArchetypeChunk PPHKNFIBCEA, [NoAlias] ref AAFNFCBEAPI.KMLJLDFGKGO EHNBJOCHNCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x432A080", Offset = "0x4329480", VA = "0x18432A080")]
			public void EKCCIAECPJB(RegisterTransforms CCBOANOIBAC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private MCNEBNEEKDO CEDJLBLPDNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private EntityQuery GHNHENFDNML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private EntityQuery PHJMDBHIICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private EntityQuery GLHPGGHPKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private EntityQuery NDOIACPKKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private EntityQuery LOLKEIDDADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private ProfilerMarker ONONOLDKLIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private EntityQuery EFOHAABBGPN;

		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x29F8C30", Offset = "0x29F8030", VA = "0x1829F8C30", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6B")]
		[Cpp2IlInjected.Address(RVA = "0x29F8950", Offset = "0x29F7D50", VA = "0x1829F8950", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6C")]
		[Cpp2IlInjected.Address(RVA = "0x29F8B60", Offset = "0x29F7F60", VA = "0x1829F8B60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6D")]
		[Cpp2IlInjected.Address(RVA = "0x29F7890", Offset = "0x29F6C90", VA = "0x1829F7890")]
		private void EOOOCCBBPKM(EntityQuery JHDPAHIHIEJ, AMEAPFGBPJG OAOJIFLLMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6E")]
		[Cpp2IlInjected.Address(RVA = "0x29F7E80", Offset = "0x29F7280", VA = "0x1829F7E80")]
		private void HBBHLIMDIHE(EntityQuery JHDPAHIHIEJ, AMEAPFGBPJG OAOJIFLLMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A6F")]
		[Cpp2IlInjected.Address(RVA = "0x29F8B00", Offset = "0x29F7F00", VA = "0x1829F8B00", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x29F80F0", Offset = "0x29F74F0", VA = "0x1829F80F0")]
		private void KMFFHGKFHIH(NativeArray<Entity> NPCFKLDOKOP, AMEAPFGBPJG OAOJIFLLMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A71")]
		[Cpp2IlInjected.Address(RVA = "0x29F83D0", Offset = "0x29F77D0", VA = "0x1829F83D0")]
		[BurstCompile]
		internal static void NNLOLLJDIMP(NativeArray<OBMFMEFEIJG> JENHKJCGHIJ, ComponentDataFromEntity<OBMFMEFEIJG> BLMINAJJIAF, AMEAPFGBPJG OAOJIFLLMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A72")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		private static void GDCMAPNHPLC(Transform KFAGMEKKLDA, Entity NOADJCMIKEF, int HMJKJGLHFKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A73")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		private static void FFEHHMDGLND(Entity NOADJCMIKEF, int HMJKJGLHFKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A74")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		private static void OCMANAHIIAO(int HMJKJGLHFKE, AMEAPFGBPJG OAOJIFLLMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x29F7CA0", Offset = "0x29F70A0", VA = "0x1829F7CA0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void GFCFJECOFEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A78")]
		[Cpp2IlInjected.Address(RVA = "0x29F86E0", Offset = "0x29F7AE0", VA = "0x1829F86E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x29F8230", Offset = "0x29F7630", VA = "0x1829F8230")]
		public static EntityQuery MIMDIEOCBFO(ComponentSystemBase CCBOANOIBAC)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x29F7AD0", Offset = "0x29F6ED0", VA = "0x1829F7AD0")]
		public static EntityQuery GDOECDBEKBF(ComponentSystemBase CCBOANOIBAC)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.TransformSyncing)]
	public class CopyTransformDataToGameObjects : LOFKNNMMOFJ, LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x2000190")]
		[BurstCompile]
		private struct OBNHGONKFFD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> KKHBLGCCAKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			[ReadOnly]
			public NativeArray<Entity> NPCFKLDOKOP;

			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x2CA20B0", Offset = "0x2CA14B0", VA = "0x182CA20B0", Slot = "4")]
			public void Execute(int HMJKJGLHFKE, TransformAccess KFAGMEKKLDA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000191")]
		[BurstCompile]
		private struct BCMELKLDEGI : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> LLEGPIDNGJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[ReadOnly]
			public NativeArray<Entity> NPCFKLDOKOP;

			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0x2C9DD40", Offset = "0x2C9D140", VA = "0x182C9DD40", Slot = "4")]
			public void Execute(int HMJKJGLHFKE, TransformAccess KFAGMEKKLDA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[BurstCompile]
		private struct IICKHCOHEOG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> LLEGPIDNGJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> FOBJCGBDPPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			[ReadOnly]
			public NativeArray<Entity> NPCFKLDOKOP;

			[Cpp2IlInjected.Token(Token = "0x6000A97")]
			[Cpp2IlInjected.Address(RVA = "0x2C9FC50", Offset = "0x2C9F050", VA = "0x182C9FC50", Slot = "4")]
			public void Execute(int HMJKJGLHFKE, TransformAccess KFAGMEKKLDA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private static readonly DLHDGHMPCLG EIPEMAAEAJI;

		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private static readonly DLHDGHMPCLG FFIJDIKNCCK;

		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private static readonly DLHDGHMPCLG LNGDOFLEIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private MCNEBNEEKDO CEDJLBLPDNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private EntityQuery OANKBECHDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private EntityQuery ENIKHAGDLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private EntityQuery IJNCMAMOAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TransformAccessArray EGAMCIHIBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private TransformAccessArray JDPIMNDBFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private TransformAccessArray PJOFFJFMEBG;

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F110", Offset = "0x2B8E510", VA = "0x182B8F110", Slot = "14")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E640", Offset = "0x2B8DA40", VA = "0x182B8E640", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E830", Offset = "0x2B8DC30", VA = "0x182B8E830", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E8C0", Offset = "0x2B8DCC0", VA = "0x182B8E8C0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E8F0", Offset = "0x2B8DCF0", VA = "0x182B8E8F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2B8E4C0", Offset = "0x2B8D8C0", VA = "0x182B8E4C0")]
		private NativeArray<Entity> ODMBPFFGLGC(NativeArray<OBMFMEFEIJG> EJCKALBJGLG, NativeList<Entity> CLKOPKILJMP, TransformAccessArray OMCDFIEJGBO, TransformAccessArray AGEAJANDKIN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.TransformSyncing)]
	public class CopyTransformParentsToGameObjects : LOFKNNMMOFJ, ENMEIFNEMLK
	{
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private ODOEMDIJMKD MDMBONKOKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private HBJNCCNFNHC LGFABECCLDM;

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x29F0AD0", Offset = "0x29EFED0", VA = "0x1829F0AD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F270", Offset = "0x2B8E670", VA = "0x182B8F270", Slot = "14")]
		public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F5A0", Offset = "0x2B8E9A0", VA = "0x182B8F5A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F420", Offset = "0x2B8E820", VA = "0x182B8F420")]
		private static void KIIGDKOOAIC(EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, Entity JFCNGAACNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x2B8F380", Offset = "0x2B8E780", VA = "0x182B8F380")]
		private static bool EDJHDGCFPJM(EntityManager GKHNMAAJNKF, Entity NOADJCMIKEF, out Transform KFAGMEKKLDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[JLJFNDDLCBO(CBGNDNDJKHL.TransformSyncing)]
	public class L2PToL2WHierarchy : LOFKNNMMOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct GAHFLEAMNMO : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> JHPMEABGOHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> FBHIKPKDNEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> DCKNONEKMFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> CPKLLBKJHEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			public ArchetypeChunkComponentType<LocalToWorldData> GDPBDFNLGIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> KHILNGPPBKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public uint JNNFIEPMAHI;

			[Cpp2IlInjected.Token(Token = "0x6000AA5")]
			[Cpp2IlInjected.Address(RVA = "0x432E320", Offset = "0x432D720", VA = "0x18432E320")]
			[Conditional("DEBUG_BUILD")]
			private void NIHLHJMIHIH(Entity NOADJCMIKEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA6")]
			[Cpp2IlInjected.Address(RVA = "0x432DC30", Offset = "0x432D030", VA = "0x18432DC30", Slot = "4")]
			public void Execute(ArchetypeChunk PPHKNFIBCEA, int HMJKJGLHFKE, int GEABGHEMPGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA7")]
			[Cpp2IlInjected.Address(RVA = "0x432DF20", Offset = "0x432D320", VA = "0x18432DF20")]
			private void GODNLPBAAKD(float4x4 DLNGMIKKEKF, Entity NOADJCMIKEF, bool GLOOOLKPHFM, int FGINFGKNAGK = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private EntityQuery IMPNBKCDKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private EntityQuery DJFLPMGKNLN;

		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAE50", Offset = "0x2BCA250", VA = "0x182BCAE50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x2BCAF70", Offset = "0x2BCA370", VA = "0x182BCAF70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class CJKBOCGLCME : JMIBLMMDFIG
{
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[BurstCompile]
	private struct GHNLJKGCOCO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> JHPMEABGOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public ArchetypeChunkComponentType<LocalToWorldData> GDPBDFNLGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public uint JNNFIEPMAHI;

		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E8E0", Offset = "0x2C9DCE0", VA = "0x182C9E8E0", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int HMJKJGLHFKE, int GEABGHEMPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E860", Offset = "0x2C9DC60", VA = "0x182C9E860")]
		public bool DKIINAMGGNL(ArchetypeChunk PPHKNFIBCEA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	private EntityQuery IMPNBKCDKNI;

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x2B857E0", Offset = "0x2B84BE0", VA = "0x182B857E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x2B85910", Offset = "0x2B84D10", VA = "0x182B85910", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle GBOFACIIBDG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public CJKBOCGLCME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
public class NNMEAAHDOFC : JMIBLMMDFIG
{
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[BurstCompile]
	private struct LJNEOBLBDNA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> HENDGOOHCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public ArchetypeChunkComponentType<WorldPoseData> OJKEOGINLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> PCKMLBMBMNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> PNBAPOFOJJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public uint JNNFIEPMAHI;

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x4332280", Offset = "0x4331680", VA = "0x184332280", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int HMJKJGLHFKE, int GEABGHEMPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x4332200", Offset = "0x4331600", VA = "0x184332200")]
		public bool DKIINAMGGNL(ArchetypeChunk PPHKNFIBCEA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private EntityQuery EDICDNMPJLP;

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x29D8C70", Offset = "0x29D8070", VA = "0x1829D8C70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x29D8D80", Offset = "0x29D8180", VA = "0x1829D8D80", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle GBOFACIIBDG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0")]
	public NNMEAAHDOFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public class DDDDNDNOENG : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[BurstCompile]
	private struct JCNLCEHPFCN : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> OENNAKHOCON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> OCLMJPEGGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> CIKBGIBGKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public ArchetypeChunkComponentType<LocalToParentData> EENNKNHMHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public uint JNNFIEPMAHI;

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FE30", Offset = "0x2C9F230", VA = "0x182C9FE30", Slot = "4")]
		public void Execute(ArchetypeChunk PPHKNFIBCEA, int HMJKJGLHFKE, int GEABGHEMPGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x2C9FD50", Offset = "0x2C9F150", VA = "0x182C9FD50")]
		public bool DKIINAMGGNL(ArchetypeChunk PPHKNFIBCEA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private EntityQuery EDICDNMPJLP;

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x2B90F70", Offset = "0x2B90370", VA = "0x182B90F70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x2B910A0", Offset = "0x2B904A0", VA = "0x182B910A0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle GBOFACIIBDG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x6DFCE0", Offset = "0x6DF0E0", VA = "0x1806DFCE0")]
	public DDDDNDNOENG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[JLJFNDDLCBO(CBGNDNDJKHL.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : LGCNEAPNBIM
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200019D")]
		public struct JICOOEPMDJM : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType IKBMCJMJDGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0x29F15A0", Offset = "0x29F09A0", VA = "0x1829F15A0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override ComponentType LMMFNNCGOBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x29F15D0", Offset = "0x29F09D0", VA = "0x1829F15D0", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override ComponentType CIAIKDECJDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0x29F1570", Offset = "0x29F0970", VA = "0x1829F1570", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x29F14D0", Offset = "0x29F08D0", VA = "0x1829F14D0")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0xF685F0", Offset = "0xF679F0", VA = "0x180F685F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[AJKBHFMLMDJ(ODCPNHEJLHH.Game)]
public class OEDFOBEMIHO : NMCAAIDNBNE
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public Type LKIMPPOOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABF")]
		[Cpp2IlInjected.Address(RVA = "0x29DADA0", Offset = "0x29DA1A0", VA = "0x1829DADA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Type[] FPCDEFFOLON
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x29DA730", Offset = "0x29D9B30", VA = "0x1829DA730", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public OEDFOBEMIHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[AJKBHFMLMDJ(ODCPNHEJLHH.Loading)]
public class CNMGLAGKOHA : NMCAAIDNBNE
{
	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Type LKIMPPOOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC2")]
		[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type[] FPCDEFFOLON
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x2B85A10", Offset = "0x2B84E10", VA = "0x182B85A10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public CNMGLAGKOHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public sealed class HGMJDEJLMJC : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDAE0", Offset = "0x2BBCEE0", VA = "0x182BBDAE0", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public HGMJDEJLMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[AJKBHFMLMDJ(ODCPNHEJLHH.Saving)]
public class DCDGAPJJMFO : NMCAAIDNBNE
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type LKIMPPOOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC8")]
		[Cpp2IlInjected.Address(RVA = "0x67F170", Offset = "0x67E570", VA = "0x18067F170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type[] FPCDEFFOLON
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC9")]
		[Cpp2IlInjected.Address(RVA = "0x2B90E80", Offset = "0x2B90280", VA = "0x182B90E80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public DCDGAPJJMFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public sealed class OPAFCKAAPLH : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x29DDE10", Offset = "0x29DD210", VA = "0x1829DDE10", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public OPAFCKAAPLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
[AJKBHFMLMDJ(ODCPNHEJLHH.Simulation)]
public class CCKNOOJLGEA : NMCAAIDNBNE
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type LKIMPPOOFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACE")]
		[Cpp2IlInjected.Address(RVA = "0x2B83150", Offset = "0x2B82550", VA = "0x182B83150", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type[] FPCDEFFOLON
	{
		[Cpp2IlInjected.Token(Token = "0x6000ACF")]
		[Cpp2IlInjected.Address(RVA = "0x2B82DA0", Offset = "0x2B821A0", VA = "0x182B82DA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public CCKNOOJLGEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[NDGJMMLBLBO(typeof(ONIHOMGICOD), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
internal class ONIHOMGICOD : ENMEIFNEMLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004EF")]
	private global::CLANDGHLNGA<AuthoredParentData, GGMLJPFLIIC, CIDNBOMPPID, AuthoredChildrenData> ECAFOCMILOA;

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x29DDC30", Offset = "0x29DD030", VA = "0x1829DDC30", Slot = "4")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public ONIHOMGICOD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	[JLJFNDDLCBO(CBGNDNDJKHL.HierarchySystems)]
	[NDGJMMLBLBO(typeof(EntityHierarchyParents), new string[] { })]
	internal sealed class EntityHierarchyParents : LNLPIGELLPM, ENMEIFNEMLK
	{
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[HIGIANBBMBE]
		private KAPLNDGMNPC EDICDNMPJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[HIGIANBBMBE]
		private PropertyChangeNetworkRouter BNLKMICELID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private global::OHMGOCMDBOD<Entity> PDLHECKEFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private global::CLANDGHLNGA<ParentData, HDBNINAKBDA, GFMHMCIIHKF, ChildrenData> ECAFOCMILOA;

		[Cpp2IlInjected.Token(Token = "0x6000AD3")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A420", Offset = "0x2B99820", VA = "0x182B9A420", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x2B99FF0", Offset = "0x2B993F0", VA = "0x182B99FF0", Slot = "5")]
		public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A1F0", Offset = "0x2B995F0", VA = "0x182B9A1F0")]
		public Entity IONCGDONMPM(Entity NOADJCMIKEF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A0F0", Offset = "0x2B994F0", VA = "0x182B9A0F0")]
		public bool FJLPJNBNCOH(Entity NOADJCMIKEF, Entity CNMJLCOJOLA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A150", Offset = "0x2B99550", VA = "0x182B9A150")]
		public bool GHJLFEJPDIG(Entity NOADJCMIKEF, Entity CNMJLCOJOLA, bool OIHCFIOFIIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2B9A240", Offset = "0x2B99640", VA = "0x182B9A240")]
		private bool OGEOAOCOCMG(Entity NOADJCMIKEF, Entity CNMJLCOJOLA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[NDGJMMLBLBO(typeof(AMHOHILPKGK), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
internal sealed class AMHOHILPKGK : LNLPIGELLPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	[HIGIANBBMBE]
	private NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery OICFGEFDNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private EntityManager HDMAFEMIPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D9A0", Offset = "0x2B7CDA0", VA = "0x182B7D9A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DD80", Offset = "0x2B7D180", VA = "0x182B7DD80", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D490", Offset = "0x2B7C890", VA = "0x182B7D490", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D3D0", Offset = "0x2B7C7D0", VA = "0x182B7D3D0")]
	public bool DJJKFGBLEGJ(Entity NOADJCMIKEF, Entity BFMALIMGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DB20", Offset = "0x2B7CF20", VA = "0x182B7DB20")]
	public IEnumerable<Entity> MCPDDLPGDOL(Entity NOADJCMIKEF, bool MHPOMONJNNI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D9F0", Offset = "0x2B7CDF0", VA = "0x182B7D9F0")]
	public bool LLKINPIFLGK(Entity NOADJCMIKEF, Entity JKAAFIAPPME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D8A0", Offset = "0x2B7CCA0", VA = "0x182B7D8A0")]
	public bool HAFGFLCKEOI(Entity NOADJCMIKEF, Entity LMKFELFNIAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DCA0", Offset = "0x2B7D0A0", VA = "0x182B7DCA0")]
	public NativeList<Entity> NMNKBDFLFAK(Entity NOADJCMIKEF, bool MHPOMONJNNI = false, Allocator JLPBABJNDBH = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D650", Offset = "0x2B7CA50", VA = "0x182B7D650")]
	public IEnumerable<Entity> FGNCMEHEPDA(Entity NOADJCMIKEF, bool MHPOMONJNNI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D5A0", Offset = "0x2B7C9A0", VA = "0x182B7D5A0")]
	public Entity FDDELAHPCJN(Entity NOADJCMIKEF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D850", Offset = "0x2B7CC50", VA = "0x182B7D850")]
	public NativeArray<Entity> GNINBKHAPJE()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D1B0", Offset = "0x2B7C5B0", VA = "0x182B7D1B0")]
	public bool CIAEECBOFKJ(Entity LMKFELFNIAK, Entity MHLBIJCJLAF, out Entity CIAGICGLOHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D4B0", Offset = "0x2B7C8B0", VA = "0x182B7D4B0")]
	private Entity EOELABBDKKM(Entity NOADJCMIKEF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public AMHOHILPKGK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A7")]
	[JLJFNDDLCBO(CBGNDNDJKHL.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x40640B0", Offset = "0x40634B0", VA = "0x1840640B0")]
		public static void KELJHIKJDOE<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(CLFAHLJOOKN IFCDDJDBLKM, global::HEIJCHPBGLA<Entity> JLNILGJAKJL, out global::CLANDGHLNGA<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> KLFACLBACCG) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, AHLBNOBKMEI where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, AHLBNOBKMEI, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x29EBE70", Offset = "0x29EB270", VA = "0x1829EBE70")]
		public static bool PBODNLKOLEP(MJBBCNDEMML ANICJOOMAKF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
public class CLANDGHLNGA<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, AHLBNOBKMEI where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, AHLBNOBKMEI, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private static readonly DLHDGHMPCLG HCDIHNPPHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private readonly NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private readonly global::OHMGOCMDBOD<Entity> PDLHECKEFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private readonly HNMINHINCFB NPIDLEGBAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private readonly HECNDLCBEON JFCNGAACNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private readonly EntityManager GKHNMAAJNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private readonly HBJNCCNFNHC LGFABECCLDM;

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x277B4A0", Offset = "0x277A8A0", VA = "0x18277B4A0")]
	public CLANDGHLNGA(CLFAHLJOOKN IFCDDJDBLKM, global::HEIJCHPBGLA<Entity> JLNILGJAKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x277B2C0", Offset = "0x277A6C0", VA = "0x18277B2C0")]
	private bool PAEOGBHNPOP(Entity NOADJCMIKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x277A9A0", Offset = "0x2779DA0", VA = "0x18277A9A0")]
	private bool CNDDPKKANJF(Entity NOADJCMIKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x277ABB0", Offset = "0x2779FB0", VA = "0x18277ABB0")]
	public bool FJLPJNBNCOH(Entity NOADJCMIKEF, in Entity CNMJLCOJOLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x277A970", Offset = "0x2779D70", VA = "0x18277A970")]
	public bool CFEHBJDNJPD(Entity NOADJCMIKEF, in Entity CNMJLCOJOLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x277A530", Offset = "0x2779930", VA = "0x18277A530")]
	private bool CFEHBJDNJPD(Entity NOADJCMIKEF, in Entity CNMJLCOJOLA, bool IOGOFIEFPDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	private static void NBCCBNHPADN(Entity NOADJCMIKEF, in Entity CNMJLCOJOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	private static void OJHHLKGDKHE(Entity NOADJCMIKEF, in Entity CNMJLCOJOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	private static void FIEFGGLJNFH(Entity NOADJCMIKEF, in Entity CNMJLCOJOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	private static void NJDJHOAHAGB(Entity NOADJCMIKEF, in Entity CNMJLCOJOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	private static void LLKLMMEBFCA(Entity NOADJCMIKEF, in Entity CNMJLCOJOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x277AAD0", Offset = "0x2779ED0", VA = "0x18277AAD0")]
	private bool DJJKFGBLEGJ(Entity NOADJCMIKEF, Entity BFMALIMGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x277B170", Offset = "0x277A570", VA = "0x18277B170")]
	private void MPACEMPIHML(Entity NOADJCMIKEF, in Entity OOHIPCPJDEM, in Entity CNMJLCOJOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x277ABE0", Offset = "0x2779FE0", VA = "0x18277ABE0")]
	private void GDGNCBGKKNF(Entity NOADJCMIKEF, in Entity OOHIPCPJDEM, in Entity CNMJLCOJOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x277A130", Offset = "0x2779530", VA = "0x18277A130")]
	private bool BLEDACMPICF(FMMIEGJEFPB LPHEADHGPLM, in JCHOAKCKPKK IGPKCMAINMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x277AF20", Offset = "0x277A320", VA = "0x18277AF20")]
	private void HKBMMHHGPCM(Entity JFCNGAACNEO, Entity JKAAFIAPPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x277B050", Offset = "0x277A450", VA = "0x18277B050")]
	private void LJBOEABGKKO(Entity JFCNGAACNEO, Entity JKAAFIAPPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	private void OCMANAHIIAO(Entity NOADJCMIKEF, Entity OOHIPCPJDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	private void GDCMAPNHPLC(Entity NOADJCMIKEF, Entity CNMJLCOJOLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
public struct LNLFDGFBDIJ : IOPHLCGDAFI, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public NFHBINEABBA DHGMGGCIKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(RVA = "0x678000", Offset = "0x677400", VA = "0x180678000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(NFHBINEABBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[NDGJMMLBLBO(typeof(ObjectEmbodimentService), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.Embodiment)]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	internal sealed class ObjectEmbodimentService : GGFJAKOLADN, MCPGEGOMHPG, LNLPIGELLPM, ENMEIFNEMLK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private ObjectLifecycleService MLGFPIININH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[HIGIANBBMBE]
		private KAPLNDGMNPC EDICDNMPJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[HIGIANBBMBE]
		private LLOINIJEHPN GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		[HIGIANBBMBE]
		private AMNPCKPOIGI BHJKPHAEBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		[HIGIANBBMBE]
		private MCECGEJPKFL GCJJKMBEDAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		[HIGIANBBMBE]
		private TransformOwnershipPhase BADJHMHKPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private readonly Dictionary<JCHOAKCKPKK, GHHFOHNOLPM> MPFOFLHMHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private ENKDNJPMIFI JMMKFLOPJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private bool HIBODKPCONP;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		private EntityManager HDMAFEMIPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B01")]
			[Cpp2IlInjected.Address(RVA = "0x29E0650", Offset = "0x29DFA50", VA = "0x1829E0650")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		public int DMMLDCPKEGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B07")]
			[Cpp2IlInjected.Address(RVA = "0x29E1230", Offset = "0x29E0630", VA = "0x1829E1230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		public int DJGPOFBJJEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000B08")]
			[Cpp2IlInjected.Address(RVA = "0x29E0740", Offset = "0x29DFB40", VA = "0x1829E0740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x20B5E80", Offset = "0x20B5280", VA = "0x1820B5E80", Slot = "4")]
		public void FFHOKNLNLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x29E1980", Offset = "0x29E0D80", VA = "0x1829E1980", Slot = "5")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x29E1550", Offset = "0x29E0950", VA = "0x1829E1550")]
		public void MDILLPADACI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x29DE7D0", Offset = "0x29DDBD0", VA = "0x1829DE7D0", Slot = "6")]
		public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B06")]
		[Cpp2IlInjected.Address(RVA = "0x29DED50", Offset = "0x29DE150", VA = "0x1829DED50", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x29E0760", Offset = "0x29DFB60", VA = "0x1829E0760")]
		public int JOEGIDFEMOP(SceneTag MJJNOEJBKMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0x29DEB00", Offset = "0x29DDF00", VA = "0x1829DEB00")]
		public int DDHAGHEMAPL(SceneTag MJJNOEJBKMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x29E0160", Offset = "0x29DF560", VA = "0x1829E0160")]
		public bool IAGODOFNHOI(Entity NOADJCMIKEF, Allocator JLPBABJNDBH, out NativeList<Entity> AMEEIPNMFGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x29E15A0", Offset = "0x29E09A0", VA = "0x1829E15A0")]
		public bool MIBLKFGBODE(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x29DF5E0", Offset = "0x29DE9E0", VA = "0x1829DF5E0")]
		public bool HCOIBJLOEOM(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x29DE940", Offset = "0x29DDD40", VA = "0x1829DE940")]
		public bool DAEHJILGNJN(Entity NOADJCMIKEF, out GHHFOHNOLPM EDKNHLFIHOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x29DE9B0", Offset = "0x29DDDB0", VA = "0x1829DE9B0")]
		private bool DAEHJILGNJN(Transform KFAGMEKKLDA, out GHHFOHNOLPM EDKNHLFIHOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0x29E03B0", Offset = "0x29DF7B0", VA = "0x1829E03B0")]
		private void IEEPJIECGMO(Entity NOADJCMIKEF, GHHFOHNOLPM EDKNHLFIHOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x29DE920", Offset = "0x29DDD20", VA = "0x1829DE920")]
		private bool CPLNPHEEEIK(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x29E0450", Offset = "0x29DF850", VA = "0x1829E0450")]
		public void JGOJGDHNHPP(JCHOAKCKPKK OMKLELDMIKD, GHHFOHNOLPM JMOOMLNHCFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x29DFDC0", Offset = "0x29DF1C0", VA = "0x1829DFDC0")]
		public bool IAFNKAGENNG(Entity NOADJCMIKEF, object MJNGPHMPILM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x29DF9E0", Offset = "0x29DEDE0", VA = "0x1829DF9E0")]
		public bool HDHBMMGDIBB(MOLBNKBNJLI AFGGEMMDNNF, object MJNGPHMPILM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x29DF990", Offset = "0x29DED90", VA = "0x1829DF990")]
		public bool HDHBMMGDIBB(Entity NOADJCMIKEF, [Optional] object MJNGPHMPILM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0x29DF600", Offset = "0x29DEA00", VA = "0x1829DF600")]
		public bool HDHBMMGDIBB(GHHFOHNOLPM ANICJOOMAKF, object MJNGPHMPILM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x29DDFE0", Offset = "0x29DD3E0", VA = "0x1829DDFE0")]
		public bool AAALBIOELEL(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x29DE3B0", Offset = "0x29DD7B0", VA = "0x1829DE3B0")]
		public bool AAALBIOELEL(GHHFOHNOLPM EDKNHLFIHOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x29DF620", Offset = "0x29DEA20", VA = "0x1829DF620")]
		public bool HDHBMMGDIBB(GHHFOHNOLPM EDKNHLFIHOP, [Optional] object MJNGPHMPILM, bool POKKNFLDEOM = false, bool ABAGKLANBBJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x29DE5F0", Offset = "0x29DD9F0", VA = "0x1829DE5F0")]
		public Transform BJLODAMNIKM(Entity NOADJCMIKEF, [Optional] object MJNGPHMPILM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0x29DEE80", Offset = "0x29DE280", VA = "0x1829DEE80")]
		public bool EDJHDGCFPJM(Entity NOADJCMIKEF, out Transform KFAGMEKKLDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x29DE500", Offset = "0x29DD900", VA = "0x1829DE500")]
		public GHHFOHNOLPM BHBJPCCLNNB(Entity NOADJCMIKEF, [Optional] object MJNGPHMPILM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x29DF350", Offset = "0x29DE750", VA = "0x1829DF350")]
		public void HAEIFCIEMHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x29E0E70", Offset = "0x29E0270", VA = "0x1829E0E70")]
		public void KLACLOIMBAD(SceneTag MJJNOEJBKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x29E0890", Offset = "0x29DFC90", VA = "0x1829E0890")]
		private void KDNAFMOGBBE(Entity NOADJCMIKEF, bool JALBLLHJELJ, bool BKCAIAIHNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B20")]
		[Cpp2IlInjected.Address(RVA = "0x29DEA60", Offset = "0x29DDE60", VA = "0x1829DEA60")]
		private void DCCEBCNEIMM(Entity NOADJCMIKEF, GHHFOHNOLPM EDKNHLFIHOP, bool JALBLLHJELJ, bool BKCAIAIHNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x29DF0E0", Offset = "0x29DE4E0", VA = "0x1829DF0E0")]
		public GHHFOHNOLPM GCDCOMHHEPB(Entity NOADJCMIKEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x29E17F0", Offset = "0x29E0BF0", VA = "0x1829E17F0")]
		public bool NEPPNDEPOAB(Entity NOADJCMIKEF, object MJNGPHMPILM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x29E1870", Offset = "0x29E0C70", VA = "0x1829E1870")]
		public bool OPINFFIBJNO(Entity NOADJCMIKEF, object MJNGPHMPILM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x29DE760", Offset = "0x29DDB60", VA = "0x1829DE760")]
		public bool CCCEGLIHGFK(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x29DF130", Offset = "0x29DE530", VA = "0x1829DF130")]
		public bool GDFLCCOAAAL(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x29DF1A0", Offset = "0x29DE5A0", VA = "0x1829DF1A0")]
		public bool GDFLCCOAAAL(NFHBINEABBA CPAMCPHEBME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void AGOALBBGKAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x29E1490", Offset = "0x29E0890", VA = "0x1829E1490")]
		private void LKNFJLFIIOF(bool PKPLICOECHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x29E18F0", Offset = "0x29E0CF0", VA = "0x1829E18F0")]
		private bool PAJHHHOGAGN(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x29E06A0", Offset = "0x29DFAA0", VA = "0x1829E06A0")]
		private GHHFOHNOLPM JKAIJHDCDJF(Entity NOADJCMIKEF, object MJNGPHMPILM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x29E1AB0", Offset = "0x29E0EB0", VA = "0x1829E1AB0")]
		private GHHFOHNOLPM POMFGIKOHCK(Entity NOADJCMIKEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x29E0C50", Offset = "0x29E0050", VA = "0x1829E0C50")]
		private (Vector3, Quaternion, Vector3) KJHOCKLGABI(Entity NOADJCMIKEF)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x29E0780", Offset = "0x29DFB80", VA = "0x1829E0780")]
		private void KCACGFMBLEI(Entity NOADJCMIKEF, APCEPJKMKDM BKEDDPMCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x29DF020", Offset = "0x29DE420", VA = "0x1829DF020")]
		private void FIGEGHFLAIM(MOLBNKBNJLI AFGGEMMDNNF, GHHFOHNOLPM JMOOMLNHCFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x29DE3E0", Offset = "0x29DD7E0", VA = "0x1829DE3E0")]
		private void AKJELEPJFNP(GHHFOHNOLPM JMOOMLNHCFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x29DEB20", Offset = "0x29DDF20", VA = "0x1829DEB20")]
		private void DMFHIEMIGAF(GHHFOHNOLPM EDKNHLFIHOP, Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x29E1250", Offset = "0x29E0650", VA = "0x1829E1250")]
		private void LFDKAKHIEFB(Entity NOADJCMIKEF, GHHFOHNOLPM EDKNHLFIHOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x29DF270", Offset = "0x29DE670", VA = "0x1829DF270")]
		private void GFOINEADAEJ(Entity NOADJCMIKEF, Transform KFAGMEKKLDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x29DFD90", Offset = "0x29DF190", VA = "0x1829DFD90")]
		private MOLBNKBNJLI HDINJCFIENE(Entity NOADJCMIKEF)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x29E1CF0", Offset = "0x29E10F0", VA = "0x1829E1CF0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x29DEF50", Offset = "0x29DE350", VA = "0x1829DEF50")]
		[CompilerGenerated]
		private void EOFIHDLKNFA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
internal static class GJDOEFCLKOC
{
	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x2BBB5D0", Offset = "0x2BBA9D0", VA = "0x182BBB5D0")]
	public static GHHFOHNOLPM BHBJPCCLNNB(this ObjectEmbodimentService LIBFGCDLBNG, MOLBNKBNJLI AFGGEMMDNNF, [Optional] object MJNGPHMPILM)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Lifecycle)]
	[NDGJMMLBLBO(typeof(ObjectLifecycleService), new string[] { })]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	internal sealed class ObjectLifecycleService : LNLPIGELLPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private ObjectEmbodimentService EDKNHLFIHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIJOKICGGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private FMOIFIJGKDN ICOFMBGPIOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private DestroyLocalObjects DAEIFAFBBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private bool HIBODKPCONP;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager HDMAFEMIPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0x29E2F60", Offset = "0x29E2360", VA = "0x1829E2F60")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<Entity, APCEPJKMKDM> BFPDEFGKMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x29E2E60", Offset = "0x29E2260", VA = "0x1829E2E60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0x29E2FB0", Offset = "0x29E23B0", VA = "0x1829E2FB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<Entity> GPFNCKBEHKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x29E2430", Offset = "0x29E1830", VA = "0x1829E2430")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0x29E2720", Offset = "0x29E1B20", VA = "0x1829E2720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x29E3290", Offset = "0x29E2690", VA = "0x1829E3290", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x82D9E0", Offset = "0x82CDE0", VA = "0x18082D9E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x29E2B20", Offset = "0x29E1F20", VA = "0x1829E2B20")]
		public bool HGNKBEMEDCJ(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x29E2BA0", Offset = "0x29E1FA0", VA = "0x1829E2BA0")]
		internal void IFENLFIECKP(Entity NOADJCMIKEF, APCEPJKMKDM BKEDDPMCLJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x29E3050", Offset = "0x29E2450", VA = "0x1829E3050")]
		public void NODIFKMPMND(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x29E2810", Offset = "0x29E1C10", VA = "0x1829E2810")]
		public void DJECLKEDLGI(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x29E2A60", Offset = "0x29E1E60", VA = "0x1829E2A60")]
		private bool GHBEOAHNANN(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x29E3090", Offset = "0x29E2490", VA = "0x1829E3090")]
		public void NPMFLDOJCPB(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x29E24D0", Offset = "0x29E18D0", VA = "0x1829E24D0")]
		private bool BBFPCNIAGHG(Entity NOADJCMIKEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x29E2690", Offset = "0x29E1A90", VA = "0x1829E2690")]
		public void COKPKCAAOBJ(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x29E2F00", Offset = "0x29E2300", VA = "0x1829E2F00")]
		private void JFLJKHJDFPE(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x29E2C00", Offset = "0x29E2000", VA = "0x1829E2C00")]
		private void IGFJOJJJOMG(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x29E27C0", Offset = "0x29E1BC0", VA = "0x1829E27C0")]
		public void DCLJAEAHDLH(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		private void EDMNMOAFOBH(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x29E2860", Offset = "0x29E1C60", VA = "0x1829E2860")]
		private void FDLAKCMNBFG(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[NDGJMMLBLBO(typeof(ObjectPrefabs), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.Prefabs)]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	internal class ObjectPrefabs : JEPHPHGHCPD, LNLPIGELLPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[CompilerGenerated]
		private sealed class JEODKCOKCAL : IEnumerable<(EOLBHDKIGHE, APCEPJKMKDM)>, IEnumerable, IEnumerator<(EOLBHDKIGHE, APCEPJKMKDM)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			private (EOLBHDKIGHE primitiveType, APCEPJKMKDM prefabType) <>2__current;

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
			private (EOLBHDKIGHE, APCEPJKMKDM) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6C")]
				[Cpp2IlInjected.Address(RVA = "0x24E8F80", Offset = "0x24E8380", VA = "0x1824E8F80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((EOLBHDKIGHE, APCEPJKMKDM));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000138")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B6E")]
				[Cpp2IlInjected.Address(RVA = "0x432F1D0", Offset = "0x432E5D0", VA = "0x18432F1D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B69")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EC00", Offset = "0x2C9E000", VA = "0x182C9EC00")]
			[DebuggerHidden]
			public JEODKCOKCAL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6A")]
			[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6B")]
			[Cpp2IlInjected.Address(RVA = "0x432EFF0", Offset = "0x432E3F0", VA = "0x18432EFF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6D")]
			[Cpp2IlInjected.Address(RVA = "0x432F190", Offset = "0x432E590", VA = "0x18432F190", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B6F")]
			[Cpp2IlInjected.Address(RVA = "0x432F0F0", Offset = "0x432E4F0", VA = "0x18432F0F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(EOLBHDKIGHE, APCEPJKMKDM)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0x432F0F0", Offset = "0x432E4F0", VA = "0x18432F0F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIJOKICGGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private World KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private readonly Dictionary<APCEPJKMKDM, Entity> EINHMHCOFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private readonly Dictionary<APCEPJKMKDM, EntityArchetype> JPPLMAIBBGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private readonly Dictionary<EOLBHDKIGHE, APCEPJKMKDM> LFCCNBJEECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private readonly Dictionary<HJJKLCIJMGP, APCEPJKMKDM> NJAFFHABIPM;

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int IGGNICCPKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4E")]
			[Cpp2IlInjected.Address(RVA = "0x29E68F0", Offset = "0x29E5CF0", VA = "0x1829E68F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public EntityManager HDMAFEMIPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x29E66A0", Offset = "0x29E5AA0", VA = "0x1829E66A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x29E6AC0", Offset = "0x29E5EC0", VA = "0x1829E6AC0", Slot = "5")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B51")]
		[Cpp2IlInjected.Address(RVA = "0x29E5CF0", Offset = "0x29E50F0", VA = "0x1829E5CF0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x29E60D0", Offset = "0x29E54D0", VA = "0x1829E60D0")]
		internal IEnumerable<Type> FKMGMIDFAMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x29E6940", Offset = "0x29E5D40", VA = "0x1829E6940")]
		internal JAHABMICOPB MHCDAKKIPCE(Type FPPBLNEEHBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x29E6890", Offset = "0x29E5C90", VA = "0x1829E6890")]
		public EntityArchetype LMKPKHPMKMB(APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x29E5940", Offset = "0x29E4D40", VA = "0x1829E5940")]
		public NativeHashMap<int, EntityArchetype> CEFHKFKBDED(Allocator JLPBABJNDBH = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x29E58D0", Offset = "0x29E4CD0", VA = "0x1829E58D0")]
		public bool CCGCJECHEDF(APCEPJKMKDM BKEDDPMCLJC, out EntityArchetype GMPHNAMECNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x29E66C0", Offset = "0x29E5AC0", VA = "0x1829E66C0", Slot = "4")]
		[IteratorStateMachine(typeof(JEODKCOKCAL))]
		public IEnumerable<(EOLBHDKIGHE, APCEPJKMKDM)> JPAMODDEHGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x29E69B0", Offset = "0x29E5DB0", VA = "0x1829E69B0")]
		public Entity OMPDCCJCDBC(APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x29E5870", Offset = "0x29E4C70", VA = "0x1829E5870")]
		public APCEPJKMKDM AAAJLOIGMEP(HJJKLCIJMGP FPPBLNEEHBP)
		{
			return default(APCEPJKMKDM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x29E5810", Offset = "0x29E4C10", VA = "0x1829E5810")]
		public APCEPJKMKDM AAAJLOIGMEP(EOLBHDKIGHE FPPBLNEEHBP)
		{
			return default(APCEPJKMKDM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x29E6EA0", Offset = "0x29E62A0", VA = "0x1829E6EA0")]
		public NativeHashMap<int, Entity> PIFNGEJFLGG(Allocator JLPBABJNDBH = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x29E6080", Offset = "0x29E5480", VA = "0x1829E6080")]
		public IEnumerable<APCEPJKMKDM> FKGEHOJBCBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x29E6020", Offset = "0x29E5420", VA = "0x1829E6020")]
		public Entity EGHAJHNJIDN(APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x29E7010", Offset = "0x29E6410", VA = "0x1829E7010")]
		public bool PKONOOGOACH(APCEPJKMKDM BKEDDPMCLJC, out Entity JLHMEAKALNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x29E6130", Offset = "0x29E5530", VA = "0x1829E6130")]
		private void GJABFMBIHBG(JAHABMICOPB LLMNFEIBMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x29E5AC0", Offset = "0x29E4EC0", VA = "0x1829E5AC0")]
		internal void DJMLNCAJELI(APCEPJKMKDM BKEDDPMCLJC, GMPCHIGGFPJ CKGHNFMJAFE, NJNPJDPFFOC KHDKKMAEGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x29E6730", Offset = "0x29E5B30", VA = "0x1829E6730")]
		private void LADHKOEKBGP(APCEPJKMKDM BKEDDPMCLJC, GMPCHIGGFPJ BJEBHLCDKKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x29E6580", Offset = "0x29E5980", VA = "0x1829E6580")]
		internal Entity JCCKBEGOJOP(APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x29E70D0", Offset = "0x29E64D0", VA = "0x1829E70D0")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public enum NLOAJENALFM
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
internal interface BGGECHELKEP
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	World GBENHADGLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	OBKBMHJLOIB OHPIHEINELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
internal class OINHGJBEDCJ : HCJCLJLDNOK, IJGOABCPHPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	private readonly OOCPPIFAIJK PGLGDGACCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	private readonly NLOAJENALFM BADJHMHKPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	private readonly List<DMOCJLJENND> LENPADMNLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	private NativeMultiHashMap<Entity, GMLMFELCCEC> HFDCKJPKNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	private NativeHashMap<int, int> IBHGFKKHLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	private JobHandle PAPHKBMFGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	private JobHandle GJAHPMNMCIA;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private World JNJMPHJDCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x29DC480", Offset = "0x29DB880", VA = "0x1829DC480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private OBKBMHJLOIB IBEBMCKEMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x29DC930", Offset = "0x29DBD30", VA = "0x1829DC930", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private GHNILEILBLO OEBNJNOPDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x68CD40", Offset = "0x68C140", VA = "0x18068CD40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private NativeMultiHashMap<Entity, GMLMFELCCEC> APJIDJCAAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x699030", Offset = "0x698430", VA = "0x180699030", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, GMLMFELCCEC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private JobHandle CBMDNAJGGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x100D120", Offset = "0x100C520", VA = "0x18100D120", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x100D040", Offset = "0x100C440", VA = "0x18100D040", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private bool MHBJBKJGFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7E")]
		[Cpp2IlInjected.Address(RVA = "0x29DC920", Offset = "0x29DBD20", VA = "0x1829DC920", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private World KEJLPJFEPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7F")]
		[Cpp2IlInjected.Address(RVA = "0x29DCD30", Offset = "0x29DC130", VA = "0x1829DCD30", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x29DD070", Offset = "0x29DC470", VA = "0x1829DD070")]
	public OINHGJBEDCJ(OOCPPIFAIJK PGLGDGACCPF, NLOAJENALFM BADJHMHKPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x29DC990", Offset = "0x29DBD90", VA = "0x1829DC990", Slot = "11")]
	private void IMAGJKDBGGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x29DCDC0", Offset = "0x29DC1C0", VA = "0x1829DCDC0", Slot = "10")]
	private bool LLAGIOPKOCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x29DC740", Offset = "0x29DBB40", VA = "0x1829DC740", Slot = "12")]
	private void DKKDHDLCDFO(ComponentType JNPJOKNNCJF, in DMOCJLJENND NCLBIHHOKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x29DCD90", Offset = "0x29DC190", VA = "0x1829DCD90", Slot = "13")]
	private bool LJCBMAGIOHE(APCEPJKMKDM BKEDDPMCLJC, out Entity JLHMEAKALNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x29DC9A0", Offset = "0x29DBDA0", VA = "0x1829DC9A0", Slot = "16")]
	private bool JFHMGBEIJNA(out NativeArray<int> GLFMADCFEPH, Allocator JLPBABJNDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x29DCB70", Offset = "0x29DBF70", VA = "0x1829DCB70", Slot = "17")]
	private bool JLGLEKMAJGM(ComponentType JNPJOKNNCJF, out DMOCJLJENND HABFLBKGIKH, out BIOPNJAEFAF KPBJLEKIMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x29DCA40", Offset = "0x29DBE40", VA = "0x1829DCA40", Slot = "18")]
	private bool JLGLEKMAJGM(ComponentType JNPJOKNNCJF, out DMOCJLJENND HABFLBKGIKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x29DC830", Offset = "0x29DBC30", VA = "0x1829DC830", Slot = "19")]
	private DMOCJLJENND EAMLNJHKMII(ComponentType JNPJOKNNCJF)
	{
		return default(DMOCJLJENND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x29DC4E0", Offset = "0x29DB8E0", VA = "0x1829DC4E0", Slot = "20")]
	private AKJEFONBMMI DCNOGLIPJCE()
	{
		return default(AKJEFONBMMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x29DC950", Offset = "0x29DBD50", VA = "0x1829DC950", Slot = "21")]
	private void GNGBLNHBLIE(JobHandle JAACMKMPHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x29DC1D0", Offset = "0x29DB5D0", VA = "0x1829DC1D0")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x29DC520", Offset = "0x29DB920", VA = "0x1829DC520")]
	private bool DJDJAFIOAGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x29DCEE0", Offset = "0x29DC2E0", VA = "0x1829DCEE0")]
	private int NAFADDKFCAE()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
internal class OOCPPIFAIJK : BGGECHELKEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	public NHLELLEJLGC KIJOKICGGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	public ObjectInstantiationService EINHMHCOFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	public OBKBMHJLOIB CBCNHJOHDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	public GHNILEILBLO ENMPBJLPNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	public LBGPMNCANKE KLABEDFFMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	public bool HIBODKPCONP;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public World GBENHADGLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B89")]
		[Cpp2IlInjected.Address(RVA = "0x29DDCD0", Offset = "0x29DD0D0", VA = "0x1829DDCD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public OBKBMHJLOIB OHPIHEINELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public OOCPPIFAIJK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	[JLJFNDDLCBO(CBGNDNDJKHL.PropertyChanges)]
	[NDGJMMLBLBO(typeof(PropertyDiffStateService), new string[] { })]
	internal class PropertyDiffStateService : LNLPIGELLPM, ENMEIFNEMLK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		internal readonly struct EMDOOHMMPLH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			private readonly NLOAJENALFM JCOLELIOCIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			private readonly PropertyDiffStateService IIHJMACAMDH;

			[Cpp2IlInjected.Token(Token = "0x6000B98")]
			[Cpp2IlInjected.Address(RVA = "0x432CD20", Offset = "0x432C120", VA = "0x18432CD20")]
			public EMDOOHMMPLH(PropertyDiffStateService IIHJMACAMDH, NLOAJENALFM NNHFEPADGNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B99")]
			[Cpp2IlInjected.Address(RVA = "0x432CD00", Offset = "0x432C100", VA = "0x18432CD00", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private readonly OOCPPIFAIJK PGLGDGACCPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private readonly OINHGJBEDCJ[] LEGNECDCNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private NLOAJENALFM NJGNEPGLDCM;

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		public BGGECHELKEP ANMOHDKMIAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8C")]
			[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		public IJGOABCPHPF CEBJHJHPMON
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0x29F2C10", Offset = "0x29F2010", VA = "0x1829F2C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		public HCJCLJLDNOK NCBDOJOEAKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0x29F2C10", Offset = "0x29F2010", VA = "0x1829F2C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x8D8880", Offset = "0x8D7C80", VA = "0x1808D8880")]
		public IJGOABCPHPF MFGMAMMMBFD(NLOAJENALFM BADJHMHKPJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x8D8880", Offset = "0x8D7C80", VA = "0x1808D8880")]
		public HCJCLJLDNOK MOLLKGJHAEN(NLOAJENALFM BADJHMHKPJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x29F2C70", Offset = "0x29F2070", VA = "0x1829F2C70", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x29F2770", Offset = "0x29F1B70", VA = "0x1829F2770", Slot = "5")]
		public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x29F2710", Offset = "0x29F1B10", VA = "0x1829F2710")]
		public void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B94")]
		[Cpp2IlInjected.Address(RVA = "0x29F2B30", Offset = "0x29F1F30", VA = "0x1829F2B30", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x29F2C50", Offset = "0x29F2050", VA = "0x1829F2C50")]
		public EMDOOHMMPLH JPMKIBGCMJD(NLOAJENALFM BADJHMHKPJJ)
		{
			return default(EMDOOHMMPLH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x29F2D40", Offset = "0x29F2140", VA = "0x1829F2D40")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B6")]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	[NDGJMMLBLBO(typeof(SceneService), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.HierarchySystems)]
	internal class SceneService : LNLPIGELLPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public static readonly SceneTag CLIIGANHPBN;

		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public const string CBIPCBKGFBC = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private const string NADKDCPLEOJ = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		[HIGIANBBMBE]
		private GBCBOOEHEAG PLHAMBBHMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		[HIGIANBBMBE]
		private ObjectEmbodimentService EDKNHLFIHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		[HIGIANBBMBE]
		private HNMINHINCFB MOHHDKEKALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		[HIGIANBBMBE]
		private SingletonComponentService NGPOMGAONJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private EntityQuery IEGKNOEHLDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private EntityQuery HHILHMFBJFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private EntityQuery LNOPMMCDNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private Entity BMNEGPLDLAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private bool HIBODKPCONP;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public bool PONLNDEOGPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9A")]
			[Cpp2IlInjected.Address(RVA = "0x2CA4760", Offset = "0x2CA3B60", VA = "0x182CA4760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public NativeArray<Entity> MCDKACGFPLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9B")]
			[Cpp2IlInjected.Address(RVA = "0x188FA50", Offset = "0x188EE50", VA = "0x18188FA50")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B9C")]
			[Cpp2IlInjected.Address(RVA = "0x1AFE920", Offset = "0x1AFDD20", VA = "0x181AFE920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public Entity AELJDOJJPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9D")]
			[Cpp2IlInjected.Address(RVA = "0x2CA31E0", Offset = "0x2CA25E0", VA = "0x182CA31E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public SceneTag EFIAIFOGGKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x2CA37D0", Offset = "0x2CA2BD0", VA = "0x182CA37D0")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public Entity HBODIODLICO
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x2CA37D0", Offset = "0x2CA2BD0", VA = "0x182CA37D0")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x2CA3330", Offset = "0x2CA2730", VA = "0x182CA3330")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private EntityManager HDMAFEMIPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0x2CA3820", Offset = "0x2CA2C20", VA = "0x182CA3820")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x2CA49A0", Offset = "0x2CA3DA0", VA = "0x182CA49A0", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x2CA31A0", Offset = "0x2CA25A0", VA = "0x182CA31A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA4")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3140", Offset = "0x2CA2540", VA = "0x182CA3140")]
		public void DECCKGKPAAK(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3410", Offset = "0x2CA2810", VA = "0x182CA3410")]
		public NativeArray<Entity> GKHFIOLEBHF(Allocator JLPBABJNDBH = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4660", Offset = "0x2CA3A60", VA = "0x182CA4660")]
		public void NCGCPFBJGGE(Entity MJJNOEJBKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA45E0", Offset = "0x2CA39E0", VA = "0x182CA45E0")]
		public Entity MGFBLLGBHIL(string DHKKANIEGMN = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x2CA35D0", Offset = "0x2CA29D0", VA = "0x182CA35D0")]
		public void GMLKMGBIIJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3120", Offset = "0x2CA2520", VA = "0x182CA3120")]
		public void CEGDDFOFEOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2CA33A0", Offset = "0x2CA27A0", VA = "0x182CA33A0")]
		public void FCNLPGNPHIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3400", Offset = "0x2CA2800", VA = "0x182CA3400")]
		public void FFNDPGOCJIE(Entity MJJNOEJBKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4840", Offset = "0x2CA3C40", VA = "0x182CA4840")]
		public bool PADOLPFFJOM(Entity MJJNOEJBKMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4530", Offset = "0x2CA3930", VA = "0x182CA4530")]
		public void MAABEIMHLCN(Entity MJJNOEJBKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2CA35F0", Offset = "0x2CA29F0", VA = "0x182CA35F0")]
		public string HLDMBFIFCIH(Entity MJJNOEJBKMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public void KGIOFFOJLHL(Entity MJJNOEJBKMP, string DHKKANIEGMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3180", Offset = "0x2CA2580", VA = "0x182CA3180")]
		public bool DPBEKEEAIGJ(string DHKKANIEGMN, out Entity MJJNOEJBKMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB1")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4420", Offset = "0x2CA3820", VA = "0x182CA4420")]
		public void KHJGMMCODFO(Entity MJJNOEJBKMP, bool FKCCFHMKDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB2")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2FB0", Offset = "0x2CA23B0", VA = "0x182CA2FB0")]
		public void BMCPLLPPNAJ(Entity NOADJCMIKEF, bool BKIGCMKEICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB3")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2F40", Offset = "0x2CA2340", VA = "0x182CA2F40")]
		public void BMCPLLPPNAJ(NativeArray<Entity> NPCFKLDOKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB4")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3030", Offset = "0x2CA2430", VA = "0x182CA3030")]
		public void BMCPLLPPNAJ(EntityQuery JHDPAHIHIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB5")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3C90", Offset = "0x2CA3090", VA = "0x182CA3C90")]
		public void KBGCDGJAACD(Entity NOADJCMIKEF, Entity MJJNOEJBKMP, bool BKIGCMKEICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3AB0", Offset = "0x2CA2EB0", VA = "0x182CA3AB0")]
		public void KBGCDGJAACD(NativeArray<Entity> NPCFKLDOKOP, Entity MJJNOEJBKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3A00", Offset = "0x2CA2E00", VA = "0x182CA3A00")]
		public void KBGCDGJAACD(EntityQuery JHDPAHIHIEJ, Entity MJJNOEJBKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3EC0", Offset = "0x2CA32C0", VA = "0x182CA3EC0")]
		private void KDNLJHBCIKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2F10", Offset = "0x2CA2310", VA = "0x182CA2F10")]
		private void BJIACKHJDNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x2CA31E0", Offset = "0x2CA25E0", VA = "0x182CA31E0")]
		private Entity NMNAOKLGGBG()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3720", Offset = "0x2CA2B20", VA = "0x182CA3720")]
		private void ILAAKEPFHDK(Entity MJJNOEJBKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4070", Offset = "0x2CA3470", VA = "0x182CA4070")]
		private void KFPNIHHNNGA(EntityQuery AKPDBLCBGAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4140", Offset = "0x2CA3540", VA = "0x182CA4140")]
		private void KFPNIHHNNGA(NativeArray<Entity> EKPOPNOIBMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x2CA48F0", Offset = "0x2CA3CF0", VA = "0x182CA48F0")]
		private void PAGBLKHFDOG(Entity MJJNOEJBKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3440", Offset = "0x2CA2840", VA = "0x182CA3440")]
		private void GKKGALFJPEG(Entity MJJNOEJBKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2CA2E70", Offset = "0x2CA2270", VA = "0x182CA2E70")]
		private void AGADFODHPMB(SceneTag BIANLLPIHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3700", Offset = "0x2CA2B00", VA = "0x182CA3700")]
		private void HNPMGMJJMNF(SceneTag BIANLLPIHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2CA3870", Offset = "0x2CA2C70", VA = "0x182CA3870")]
		private void KACHIMHHJKB(SceneTag BIANLLPIHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4540", Offset = "0x2CA3940", VA = "0x182CA4540")]
		private void MAEOEDKFEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x3848490", Offset = "0x3847890", VA = "0x183848490")]
		private void ICMDOLFPCBM<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void OGLJDGPEIFK(SceneTag BIANLLPIHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA47B0", Offset = "0x2CA3BB0", VA = "0x182CA47B0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void ODBMJDCJPPF(EntityQuery JHDPAHIHIEJ, string DHKKANIEGMN, SceneTag BIANLLPIHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA4810", Offset = "0x2CA3C10", VA = "0x182CA4810")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void OIMCHMNCDMC(Entity MJJNOEJBKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void OMLPBBEMFPA(Entity MJJNOEJBKMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[NDGJMMLBLBO(typeof(ILADOCJIBPM), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.HierarchySystems)]
	[DAPOABPDMCD(GPPMCHFFAPH.PhotonRoom)]
	internal class UnitySceneService : LNLPIGELLPM, ILADOCJIBPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[HIGIANBBMBE]
		private SceneService EKPOPNOIBMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private readonly Dictionary<int, Entity> DFFMGGEICHN;

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		private EntityManager HDMAFEMIPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCB")]
			[Cpp2IlInjected.Address(RVA = "0x2CB2900", Offset = "0x2CB1D00", VA = "0x182CB2900")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2950", Offset = "0x2CB1D50", VA = "0x182CB2950", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2CB25A0", Offset = "0x2CB19A0", VA = "0x182CB25A0", Slot = "5")]
		public void DECCKGKPAAK(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2710", Offset = "0x2CB1B10", VA = "0x182CB2710", Slot = "6")]
		public bool IKJHNOANDEA(MOLBNKBNJLI AFGGEMMDNNF, Transform KFAGMEKKLDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2CB2530", Offset = "0x2CB1930", VA = "0x182CB2530")]
		private bool CNBJONNFECA(Scene MJJNOEJBKMP, out Entity MONGOFEGJKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2CB29E0", Offset = "0x2CB1DE0", VA = "0x182CB29E0")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[JLJFNDDLCBO(CBGNDNDJKHL.ComponentSystemTypes)]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	[NDGJMMLBLBO(typeof(SingletonComponentService), new string[] { })]
	internal sealed class SingletonComponentService : LNLPIGELLPM, ENMEIFNEMLK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		[HIGIANBBMBE]
		private HNMINHINCFB MOHHDKEKALA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private Entity NOADJCMIKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private GMPCHIGGFPJ BJEBHLCDKKJ;

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public int IGGNICCPKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD1")]
			[Cpp2IlInjected.Address(RVA = "0x2CA98B0", Offset = "0x2CA8CB0", VA = "0x182CA98B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		public Entity BIMHONKFKHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD2")]
			[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager HDMAFEMIPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BD3")]
			[Cpp2IlInjected.Address(RVA = "0x2CA9860", Offset = "0x2CA8C60", VA = "0x182CA9860")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x3849DC0", Offset = "0x38491C0", VA = "0x183849DC0")]
		public T JLHLNIPLDNM<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x3849E80", Offset = "0x3849280", VA = "0x183849E80")]
		public void KNBGLHDOKIA<T>(T IGDJJEECDAF) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9960", Offset = "0x2CA8D60", VA = "0x182CA9960", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2CA90F0", Offset = "0x2CA84F0", VA = "0x182CA90F0", Slot = "5")]
		public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2CA90F0", Offset = "0x2CA84F0", VA = "0x182CA90F0")]
		private void KCKHPLIEGOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9290", Offset = "0x2CA8690", VA = "0x182CA9290", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2CA9560", Offset = "0x2CA8960", VA = "0x182CA9560")]
		private GMPCHIGGFPJ FGFGFNEHEBA()
		{
			return default(GMPCHIGGFPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		private static void JBLDJIEKBAJ(int LKJCGNNPEOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		private static void LMFEHDBJENN(Type FPPBLNEEHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x2CA98C0", Offset = "0x2CA8CC0", VA = "0x182CA98C0")]
		private static void MHEIBFLPBEK(Type FPPBLNEEHBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001B9")]
internal struct LEDFNAEAOED : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
[NDGJMMLBLBO(typeof(MCECGEJPKFL), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
internal sealed class MCECGEJPKFL : LNLPIGELLPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000552")]
	[HIGIANBBMBE]
	private NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000553")]
	private global::GBMKOGAENAJ<KIENNDGKOGI, Entity> CFDKEBMOPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	private global::PBPLGHILKPA<PNHOCDBNAFH> IDHPNILDICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	private global::PBPLGHILKPA<OGNEGHIJMEK> LINFHPKCDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	private global::PBPLGHILKPA<MMAIEBALOMC> FJHDPBHCLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000557")]
	private global::PBPLGHILKPA<PNJBFKJOGII> FBDKFNLJFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000558")]
	private global::PBPLGHILKPA<LNLFDGFBDIJ> LIBFGCDLBNG;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public global::LMHJIKMILKO<Entity> EDOAPBFNJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public HNIPCOLCLNG CJLDOMOJBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public HNIPCOLCLNG OIEFHNGLAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public HNIPCOLCLNG AILGOAPJEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x68E6F0", Offset = "0x68DAF0", VA = "0x18068E6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public HNIPCOLCLNG INFJGBCGNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x67F570", Offset = "0x67E970", VA = "0x18067F570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public HNIPCOLCLNG CKHDIAKHAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x67F580", Offset = "0x67E980", VA = "0x18067F580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private EntityManager HDMAFEMIPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2BD1540", Offset = "0x2BD0940", VA = "0x182BD1540")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1590", Offset = "0x2BD0990", VA = "0x182BD1590", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x2BD1450", Offset = "0x2BD0850", VA = "0x182BD1450", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x3222750", Offset = "0x3221B50", VA = "0x183222750")]
	private void KELJHIKJDOE<T>(ref global::PBPLGHILKPA<T> AOIGECIOMCP) where T : struct, IOPHLCGDAFI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x3222750", Offset = "0x3221B50", VA = "0x183222750")]
	private void KELJHIKJDOE<TC, TV>(ref global::GBMKOGAENAJ<TC, TV> AOIGECIOMCP) where TC : struct, IOPHLCGDAFI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MCECGEJPKFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[NDGJMMLBLBO(typeof(MCNEBNEEKDO), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
internal sealed class MCNEBNEEKDO : MCPGEGOMHPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	private AMEAPFGBPJG MDAKOIICEJO;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public AMEAPFGBPJG KEDDCABENPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x1D58DA0", Offset = "0x1D581A0", VA = "0x181D58DA0")]
		get
		{
			return default(AMEAPFGBPJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x2BD16B0", Offset = "0x2BD0AB0", VA = "0x182BD16B0", Slot = "4")]
	public void FFHOKNLNLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x2BD16A0", Offset = "0x2BD0AA0", VA = "0x182BD16A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public MCNEBNEEKDO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	[NDGJMMLBLBO(typeof(TransformOwnershipPhase), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001BD")]
		public enum IIEAPPOOICF
		{
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001BE")]
		public struct HIGLNGEIOPB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			private IIEAPPOOICF MOPAJCBILCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			private readonly TransformOwnershipPhase JFCNGAACNEO;

			[Cpp2IlInjected.Token(Token = "0x6000BF8")]
			[Cpp2IlInjected.Address(RVA = "0x432E470", Offset = "0x432D870", VA = "0x18432E470")]
			public HIGLNGEIOPB(TransformOwnershipPhase JFCNGAACNEO, IIEAPPOOICF BADJHMHKPJJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0x432E450", Offset = "0x432D850", VA = "0x18432E450", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		public IIEAPPOOICF BADJHMHKPJJ;

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		public IIEAPPOOICF ILJNENDADDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF0")]
			[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677440", VA = "0x180678040")]
			get
			{
				return default(IIEAPPOOICF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF1")]
			[Cpp2IlInjected.Address(RVA = "0x698F30", Offset = "0x698330", VA = "0x180698F30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		public bool MNAHPAPNKHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0xBFA400", Offset = "0xBF9800", VA = "0x180BFA400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		public bool LKPLMBBBEFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x1007660", Offset = "0x1006A60", VA = "0x181007660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x2CACC90", Offset = "0x2CAC090", VA = "0x182CACC90")]
		public HIGLNGEIOPB BFKEPOPHGJL()
		{
			return default(HIGLNGEIOPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x2CACCC0", Offset = "0x2CAC0C0", VA = "0x182CACCC0")]
		public HIGLNGEIOPB NGLJIOBCLBP()
		{
			return default(HIGLNGEIOPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[NDGJMMLBLBO(typeof(DGKMBHEFMLJ), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.Circuits)]
	public class CircuitsService : LNLPIGELLPM, DGKMBHEFMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		[HIGIANBBMBE]
		private KAEKOILLLLA GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private EntityManager GKHNMAAJNKF;

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x2B874D0", Offset = "0x2B868D0", VA = "0x182B874D0", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x2B86800", Offset = "0x2B85C00", VA = "0x182B86800", Slot = "5")]
		public bool DOBLDLDEFAH(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x2B86E90", Offset = "0x2B86290", VA = "0x182B86E90", Slot = "7")]
		public Guid HFGKKGMNGHJ(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x2B87270", Offset = "0x2B86670", VA = "0x182B87270", Slot = "8")]
		public void PFOBLCBIJHI(MOLBNKBNJLI AFGGEMMDNNF, Guid EPHLNALBLMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x2B87010", Offset = "0x2B86410", VA = "0x182B87010", Slot = "9")]
		public Guid OELPCDIAAHG(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2B86540", Offset = "0x2B85940", VA = "0x182B86540", Slot = "10")]
		public void CKNOIAFAFMJ(MOLBNKBNJLI AFGGEMMDNNF, Guid PMMMOKLLIPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x2B86380", Offset = "0x2B85780", VA = "0x182B86380", Slot = "11")]
		public bool BOALIEMPNAH(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x2B86310", Offset = "0x2B85710", VA = "0x182B86310", Slot = "12")]
		public void BCBHEBFCMHK(MOLBNKBNJLI AFGGEMMDNNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C02")]
		[Cpp2IlInjected.Address(RVA = "0x2B86AD0", Offset = "0x2B85ED0", VA = "0x182B86AD0", Slot = "13")]
		public void HAODGFEEJNB(MOLBNKBNJLI BCPKCLKDOEP, MOLBNKBNJLI JFCNGAACNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x2B863D0", Offset = "0x2B857D0", VA = "0x182B863D0")]
		private void CAKAPPKPCOJ(KJEJJPGIIDJ NLKPJCOAOIC, MOLBNKBNJLI JFCNGAACNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C04")]
		[Cpp2IlInjected.Address(RVA = "0x2B870E0", Offset = "0x2B864E0", VA = "0x182B870E0")]
		private void PBMFPEIMLHM(KJEJJPGIIDJ NLKPJCOAOIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x2B86900", Offset = "0x2B85D00", VA = "0x182B86900")]
		private bool EHEOIGODDJL(MJBBCNDEMML JLBINKLPHKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x2B86F60", Offset = "0x2B86360", VA = "0x182B86F60")]
		private bool LLOFBKEDKBM(MJBBCNDEMML JLBINKLPHKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x2B867A0", Offset = "0x2B85BA0", VA = "0x182B867A0", Slot = "6")]
		public bool DEIIDFFIPAN(MOLBNKBNJLI OACDBCDEFBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C0")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Connectables)]
	[NDGJMMLBLBO(typeof(MBFAONBDNHH), new string[] { })]
	internal class ConnectableService : MBFAONBDNHH, LNLPIGELLPM, ENMEIFNEMLK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		[CompilerGenerated]
		private sealed class GKHOJJPPOGC : IEnumerable<MOLBNKBNJLI>, IEnumerable, IEnumerator<MOLBNKBNJLI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400057D")]
			private MOLBNKBNJLI <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400057E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057F")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000580")]
			private MOLBNKBNJLI localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000581")]
			public MOLBNKBNJLI <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000582")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000583")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700015D")]
			private MOLBNKBNJLI System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C30")]
				[Cpp2IlInjected.Address(RVA = "0x699040", Offset = "0x698440", VA = "0x180699040", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(MOLBNKBNJLI);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700015E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C32")]
				[Cpp2IlInjected.Address(RVA = "0x2C9F020", Offset = "0x2C9E420", VA = "0x182C9F020", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97F60", VA = "0x180A98B60")]
			[DebuggerHidden]
			public GKHOJJPPOGC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F070", Offset = "0x2C9E470", VA = "0x182C9F070", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EC30", Offset = "0x2C9E030", VA = "0x182C9EC30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F140", Offset = "0x2C9E540", VA = "0x182C9F140")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C2F")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F190", Offset = "0x2C9E590", VA = "0x182C9F190")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EFE0", Offset = "0x2C9E3E0", VA = "0x182C9EFE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C33")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EF30", Offset = "0x2C9E330", VA = "0x182C9EF30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MOLBNKBNJLI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C34")]
			[Cpp2IlInjected.Address(RVA = "0x2C9EF30", Offset = "0x2C9E330", VA = "0x182C9EF30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private static readonly DLHDGHMPCLG BJNOPGDKOMN;

		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public const int GDBHDGLECKD = 0;

		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public const int LNKHEGHINCO = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private KAPLNDGMNPC EDICDNMPJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private NHLELLEJLGC KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private LLOINIJEHPN GEEOPHADFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private PropertyEventCallbacksService DJLHEMGEDMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private global::OHMGOCMDBOD<Entity> HGBIDPNKKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private global::OHMGOCMDBOD<float3> CJOGMNKHNIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private global::OHMGOCMDBOD<quaternion> GGMNNDMHGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private global::OHMGOCMDBOD<Entity> JFCNGAACNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private global::OHMGOCMDBOD<float3> BMHPNHLDACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private global::OHMGOCMDBOD<quaternion> BHFNLNKHCPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private HashSet<Entity> PIAGMLLKHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private HashSet<Entity> EDCLPPHMBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private EntityQuery OICFGEFDNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private bool HIBODKPCONP;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public Func<LAMNMLPBGEO> AFKMAHOKIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x68E750", Offset = "0x68DB50", VA = "0x18068E750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x7AB4E0", Offset = "0x7AA8E0", VA = "0x1807AB4E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action<MOLBNKBNJLI, MOLBNKBNJLI> PFBBDKBGLEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x2B8CB30", Offset = "0x2B8BF30", VA = "0x182B8CB30", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0x2B8C520", Offset = "0x2B8B920", VA = "0x182B8C520", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<MOLBNKBNJLI, MOLBNKBNJLI> NGGMKNONKAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B430", Offset = "0x2B8A830", VA = "0x182B8B430", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0D")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B390", Offset = "0x2B8A790", VA = "0x182B8B390", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<MOLBNKBNJLI, MOLBNKBNJLI, MOLBNKBNJLI> KBLCAOADOLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0E")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BBC0", Offset = "0x2B8AFC0", VA = "0x182B8BBC0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B2F0", Offset = "0x2B8A6F0", VA = "0x182B8B2F0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<MOLBNKBNJLI> DPIEONJAEFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0x2B8BF40", Offset = "0x2B8B340", VA = "0x182B8BF40", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x2B8B4D0", Offset = "0x2B8A8D0", VA = "0x182B8B4D0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CC80", Offset = "0x2B8C080", VA = "0x182B8CC80", Slot = "25")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B570", Offset = "0x2B8A970", VA = "0x182B8B570", Slot = "26")]
		public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BA10", Offset = "0x2B8AE10", VA = "0x182B8BA10", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C0F0", Offset = "0x2B8B4F0", VA = "0x182B8C0F0")]
		private void KHHADGINADE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C3B0", Offset = "0x2B8B7B0", VA = "0x182B8C3B0")]
		private void MLIKPBODPKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C8D0", Offset = "0x2B8BCD0", VA = "0x182B8C8D0")]
		private void NLMFBBFMFNI(Entity NOADJCMIKEF, EEJFBJIDABN FCLBEIEGADL, PEABCJAGJAH EMCJDFHKAFD, PEABCJAGJAH ADNCLAHHBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BFE0", Offset = "0x2B8B3E0", VA = "0x182B8BFE0")]
		private void ILPJCCCPNCN(Entity NOADJCMIKEF, EEJFBJIDABN FCLBEIEGADL, PEABCJAGJAH EMCJDFHKAFD, PEABCJAGJAH ADNCLAHHBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA25A0", Offset = "0x1FA19A0", VA = "0x181FA25A0", Slot = "14")]
		public MOLBNKBNJLI CKDKKCHNCBB(MOLBNKBNJLI AFGGEMMDNNF, int DHGFGIIKMKF)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x149BF50", Offset = "0x149B350", VA = "0x18149BF50", Slot = "15")]
		public Color DOEJKBJEBFO(MOLBNKBNJLI AFGGEMMDNNF, int DHGFGIIKMKF)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BC60", Offset = "0x2B8B060", VA = "0x182B8BC60", Slot = "16")]
		public float3 HNGJHEDBILM(MOLBNKBNJLI AFGGEMMDNNF, int DHGFGIIKMKF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C040", Offset = "0x2B8B440", VA = "0x182B8C040", Slot = "17")]
		public bool JAJJNDGHOMN(MOLBNKBNJLI AFGGEMMDNNF, MOLBNKBNJLI PABNCEBILFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CBD0", Offset = "0x2B8BFD0", VA = "0x182B8CBD0", Slot = "18")]
		public MOLBNKBNJLI OPCICMHGPNC(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CE00", Offset = "0x2B8C200", VA = "0x182B8CE00", Slot = "21")]
		public void POCPAGEJLFC(MOLBNKBNJLI AFGGEMMDNNF, Vector3 FHFJOFLLLJK, Quaternion AJONGCKKJCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CA90", Offset = "0x2B8BE90", VA = "0x182B8CA90", Slot = "23")]
		public float3 OELHBKBACGP(NAHMBHEPGCM PLKCHNEPOPK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C320", Offset = "0x2B8B720", VA = "0x182B8C320", Slot = "24")]
		public quaternion MKAKCKALAIL(NAHMBHEPGCM PLKCHNEPOPK)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x2B8BE40", Offset = "0x2B8B240", VA = "0x182B8BE40", Slot = "28")]
		public RigidTransform IFBLIEDBNPL(NAHMBHEPGCM PLKCHNEPOPK)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x2B8B170", Offset = "0x2B8A570", VA = "0x182B8B170", Slot = "22")]
		public bool BJPPKPBKEGB(MOLBNKBNJLI AFGGEMMDNNF, out RigidTransform DBBFMKHPKLM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C5C0", Offset = "0x2B8B9C0", VA = "0x182B8C5C0", Slot = "19")]
		[IteratorStateMachine(typeof(GKHOJJPPOGC))]
		public IEnumerable<MOLBNKBNJLI> NDFBEHFJHFC(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C650", Offset = "0x2B8BA50", VA = "0x182B8C650", Slot = "20")]
		public MOLBNKBNJLI NICJOLCOPDA(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C150", Offset = "0x2B8B550", VA = "0x182B8C150", Slot = "29")]
		public void MABNHGCMLIF(ref List<MOLBNKBNJLI> BKAJFMOPMLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x2B8C7B0", Offset = "0x2B8BBB0", VA = "0x182B8C7B0")]
		private Entity NICJOLCOPDA(Entity NOADJCMIKEF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x2B8CFE0", Offset = "0x2B8C3E0", VA = "0x182B8CFE0")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	[NDGJMMLBLBO(typeof(ObjectInstantiationService), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.Prefabs)]
	internal sealed class ObjectInstantiationService : LNLPIGELLPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIEEJCIFMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		[HIGIANBBMBE]
		private AHOBANHALBL JLGHJLODPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		[HIGIANBBMBE]
		private DMFFLNPOJOF AIBHMCLDLBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		[HIGIANBBMBE]
		private ObjectNetworkToLocalMapService DDKCFDAIGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		[HIGIANBBMBE]
		private ObjectLifecycleService MLGFPIININH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		[HIGIANBBMBE]
		private ObjectPrefabs EINHMHCOFBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[HIGIANBBMBE]
		private DNCKDPFKPCD BBMOHJAFANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private FMOIFIJGKDN ICOFMBGPIOD;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public int NBKJKEKJIDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C35")]
			[Cpp2IlInjected.Address(RVA = "0x29E2050", Offset = "0x29E1450", VA = "0x1829E2050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x29E22B0", Offset = "0x29E16B0", VA = "0x1829E22B0", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x29E21E0", Offset = "0x29E15E0", VA = "0x1829E21E0")]
		public Entity KLAMPCOOJFE(APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x29E1E00", Offset = "0x29E1200", VA = "0x1829E1E00")]
		public Entity BPFKIPKCGPJ(JCHOAKCKPKK OMKLELDMIKD, APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x29E1EA0", Offset = "0x29E12A0", VA = "0x1829E1EA0")]
		public Entity LENFEBGDMNK(APCEPJKMKDM BKEDDPMCLJC, bool NJFCIICKMND)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x29E2010", Offset = "0x29E1410", VA = "0x1829E2010")]
		public Entity LENFEBGDMNK(APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x29E1E60", Offset = "0x29E1260", VA = "0x1829E1E60")]
		public Entity COAICNDGEKM()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x29E2150", Offset = "0x29E1550", VA = "0x1829E2150")]
		public Entity FNKFHLANIFP(EOLBHDKIGHE FPPBLNEEHBP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x29E1D70", Offset = "0x29E1170", VA = "0x1829E1D70")]
		public Entity BNDENKEHBHE(HJJKLCIJMGP FPPBLNEEHBP)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x29E2260", Offset = "0x29E1660", VA = "0x1829E2260")]
		public NativeArray<(MOLBNKBNJLI, MOLBNKBNJLI)> OMPDCCJCDBC(NativeArray<MOLBNKBNJLI> NBALOLEMJAH, Allocator JLPBABJNDBH)
		{
			return default(NativeArray<(MOLBNKBNJLI, MOLBNKBNJLI)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x29E2100", Offset = "0x29E1500", VA = "0x1829E2100")]
		public IEnumerable<APCEPJKMKDM> FKGEHOJBCBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x29E2200", Offset = "0x29E1600", VA = "0x1829E2200")]
		public EntityArchetype LMKPKHPMKMB(APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x29E20A0", Offset = "0x29E14A0", VA = "0x1829E20A0")]
		public Entity EGHAJHNJIDN(APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x29E2010", Offset = "0x29E1410", VA = "0x1829E2010")]
		private Entity DLFDMEMHDOH(APCEPJKMKDM BKEDDPMCLJC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x29E1EA0", Offset = "0x29E12A0", VA = "0x1829E1EA0")]
		private Entity DLFDMEMHDOH(APCEPJKMKDM BKEDDPMCLJC, bool NJFCIICKMND)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x29E1EF0", Offset = "0x29E12F0", VA = "0x1829E1EF0")]
		private Entity DLFDMEMHDOH(APCEPJKMKDM BKEDDPMCLJC, JCHOAKCKPKK OMKLELDMIKD)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[JLJFNDDLCBO(CBGNDNDJKHL.Physics)]
	[NDGJMMLBLBO(typeof(FFGAOMNGKBA), new string[] { })]
	public sealed class PhysicsSceneColliderService : FFGAOMNGKBA, ACNEILCJOBP, MCPGEGOMHPG, LNLPIGELLPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private const string OBKKLEELDOB = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private const int BGMOADFGMFP = -1;

		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private const int GNDPEIIKCAG = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		[HIGIANBBMBE]
		private AMNPCKPOIGI BHJKPHAEBFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private Collider[] LNMFHHGACOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private RaycastHit[] CIHPJAGONCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private global::DAMBNPJKGIF<LCGHEKCHLDL, BoxCollider> MKLJPICGMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private Scene MJJNOEJBKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private PhysicsScene JDDBJHOKJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private GameObject JLHMEAKALNB;

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public int AMOAAJCPMBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x29EC130", Offset = "0x29EB530", VA = "0x1829EC130", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x29EC360", Offset = "0x29EB760", VA = "0x1829EC360", Slot = "9")]
		public void FFHOKNLNLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x29ED160", Offset = "0x29EC560", VA = "0x1829ED160", Slot = "10")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x29EC210", Offset = "0x29EB610", VA = "0x1829EC210", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x29EBEC0", Offset = "0x29EB2C0", VA = "0x1829EBEC0", Slot = "4")]
		public LCGHEKCHLDL CDHOJOLHDAP(Entity NOADJCMIKEF)
		{
			return default(LCGHEKCHLDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x29EC510", Offset = "0x29EB910", VA = "0x1829EC510", Slot = "5")]
		public void IFDCOKICGHP(NativeArray<LCGHEKCHLDL> LMBGEPHNCDH, NativeArray<HEKNCGOBJJM> HGOHIFPNOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x29ECBE0", Offset = "0x29EBFE0", VA = "0x1829ECBE0", Slot = "6")]
		public void KMMNPENPOHE(LCGHEKCHLDL CPAMCPHEBME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x29EC170", Offset = "0x29EB570", VA = "0x1829EC170", Slot = "7")]
		public bool CLHMCDCIHPH(LCGHEKCHLDL CPAMCPHEBME, out Collider MPOAAHNPLID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x29ECCB0", Offset = "0x29EC0B0", VA = "0x1829ECCB0")]
		public bool MNHMCADOMJC(in float3 GGAECKMEFID, in float3 BENEMIPHCAB, float KKONCICCPBC, Allocator JLPBABJNDBH, out NativeArray<Entity> NPCFKLDOKOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x29EC310", Offset = "0x29EB710", VA = "0x1829EC310")]
		private void EHAIIJCPHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0xCBA500", Offset = "0xCB9900", VA = "0x180CBA500")]
		private void HKOLNHJOCEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x29ECB20", Offset = "0x29EBF20", VA = "0x1829ECB20")]
		private void IMIKNPFBFKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x1AFF7E0", Offset = "0x1AFEBE0", VA = "0x181AFF7E0")]
		private void BJJBACHPBNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x29EC010", Offset = "0x29EB410", VA = "0x1829EC010")]
		private BoxCollider CEEDIAIKEDG(Entity NOADJCMIKEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x29ECFD0", Offset = "0x29EC3D0", VA = "0x1829ECFD0")]
		private void OKEODJOLNOE(BoxCollider ADJALLAMOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x29EC4D0", Offset = "0x29EB8D0", VA = "0x1829EC4D0")]
		[Conditional("UNITY_EDITOR")]
		private void GCKACJIGNKD(GameObject FLFBOHHHJJB, Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x29EC720", Offset = "0x29EBB20", VA = "0x1829EC720")]
		private void IFOHIAHJJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x29ED050", Offset = "0x29EC450", VA = "0x1829ED050")]
		private void ONPHFLOGDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x29EC910", Offset = "0x29EBD10", VA = "0x1829EC910")]
		private void IIJCINICGPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x29ECBB0", Offset = "0x29EBFB0", VA = "0x1829ECBB0")]
		private void KGAGGBGJCAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x29EBEB0", Offset = "0x29EB2B0", VA = "0x1829EBEB0")]
		private void AHFPAIHCCPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x29ECB70", Offset = "0x29EBF70", VA = "0x1829ECB70")]
		private void IOHMAIEGNDB(Scene LEJCFIHNDBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x29ECFC0", Offset = "0x29EC3C0", VA = "0x1829ECFC0", Slot = "8")]
		private bool NLDCPDNIKEJ(in float3 GGAECKMEFID, in float3 BENEMIPHCAB, float KKONCICCPBC, Allocator JLPBABJNDBH, out NativeArray<Entity> NPCFKLDOKOP)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
[NDGJMMLBLBO(typeof(LHKNIMEJMPF), new string[] { })]
public sealed class HBCCFPGIIEE : LHKNIMEJMPF, LNLPIGELLPM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	private struct OFBFEJBFDFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public float GBBIKLIFAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public uint OCJJKIPGOAE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private ACNEILCJOBP IAPMLOPGPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private HJKBEMOEMNF JEIHHMBHNHL;

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC920", Offset = "0x2BBBD20", VA = "0x182BBC920", Slot = "5")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC4A0", Offset = "0x2BBB8A0", VA = "0x182BBC4A0")]
	public bool MNHMCADOMJC(in float3 GGAECKMEFID, in float3 BENEMIPHCAB, float KKONCICCPBC, out IFAHBBMEOCE JFOAKFDLEGN, out Entity EDCEJDFIEMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC390", Offset = "0x2BBB790", VA = "0x182BBC390")]
	public static bool LILFCIDMGDO(in Span<IFAHBBMEOCE> PILHNLKJHEC, float KKONCICCPBC, out int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC360", Offset = "0x2BBB760", VA = "0x182BBC360")]
	public static float EEFGHNNKGJM(float GBBIKLIFAMA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public HBCCFPGIIEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC490", Offset = "0x2BBB890", VA = "0x182BBC490", Slot = "4")]
	private bool LLIPFDAAMHG(in float3 GGAECKMEFID, in float3 BENEMIPHCAB, float KKONCICCPBC, out IFAHBBMEOCE JFOAKFDLEGN, out Entity EDCEJDFIEMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
[NDGJMMLBLBO(typeof(HJKBEMOEMNF), new string[] { })]
public sealed class OBLPJGBBEIE : HJKBEMOEMNF, LNLPIGELLPM
{
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[BurstCompile]
	private struct KMJGDCHHGKF : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[ReadOnly]
		public NativeArray<Entity> NPCFKLDOKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[ReadOnly]
		public float3 BMIJOIECMBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[ReadOnly]
		public float3 LBLNBBIGGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> HAMFCDFNMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> JMPDALEEJJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> CLOKPDEMPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> IJPHLGAKDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> HFDOJEONIDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		[WriteOnly]
		public NativeArray<IFAHBBMEOCE> AHPEOLOHMHN;

		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private static readonly IFAHBBMEOCE KJNPGIHPIBE;

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x4331070", Offset = "0x4330470", VA = "0x184331070", Slot = "4")]
		public void Execute(int HMJKJGLHFKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x4331570", Offset = "0x4330970", VA = "0x184331570")]
		private static float3 LBOLHOEHDIP(in float4x4 MGOFOFBJOOE, in float3 ENPADDIHOCB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0x4331640", Offset = "0x4330A40", VA = "0x184331640")]
		private static float3 NOGGFMHHNOM(in float4x4 MGOFOFBJOOE, in float3 BNEELLCBKDL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x43308A0", Offset = "0x432FCA0", VA = "0x1843308A0")]
		private static float3 AHMHEEIFDBK(in float4x4 MGOFOFBJOOE, in float3 ENPADDIHOCB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x4331350", Offset = "0x4330750", VA = "0x184331350")]
		private static float3 KOOCLKLKADF(in float4x4 MGOFOFBJOOE, in float3 BNEELLCBKDL)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x4330550", Offset = "0x432F950", VA = "0x184330550")]
		private bool ABDEILHOAEN(in float3 GGAECKMEFID, in float3 BENEMIPHCAB, in NativeArray<Entity> INBCAAPLLCG, out float3 JFOAKFDLEGN, out float3 HBJDEILKJKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x43309A0", Offset = "0x432FDA0", VA = "0x1843309A0")]
		public static bool BJCNKMOBBCB(in float3 LOOLBMPCAKN, in float3 COOFDKJHPEE, in float3 FMEPIJCCBJB, in float3 PHLKEGMAIOM, float JFPOIPOLJJD, float CLNIMFPKIAF, out float BJKDLBIJMNC, out float3 HOONAHDGCDI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityManager GKHNMAAJNKF;

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x29DA010", Offset = "0x29D9410", VA = "0x1829DA010", Slot = "5")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x29D9B20", Offset = "0x29D8F20", VA = "0x1829D9B20")]
	public void MNHMCADOMJC(in NativeArray<Entity> NPCFKLDOKOP, in float3 GGAECKMEFID, in float3 BENEMIPHCAB, in NativeArray<IFAHBBMEOCE> LJCEEODFKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public OBLPJGBBEIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x29DA000", Offset = "0x29D9400", VA = "0x1829DA000", Slot = "4")]
	private void NBKCEKJNEEJ(in NativeArray<Entity> NPCFKLDOKOP, in float3 GGAECKMEFID, in float3 BENEMIPHCAB, in NativeArray<IFAHBBMEOCE> LJCEEODFKEG)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[NDGJMMLBLBO(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[JLJFNDDLCBO(CBGNDNDJKHL.Embodiment)]
	[DAPOABPDMCD(GPPMCHFFAPH.OMRoom)]
	internal sealed class ObjectNetworkToLocalMapService : LNLPIGELLPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		[HIGIANBBMBE]
		private NHLELLEJLGC KIJOKICGGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		[HIGIANBBMBE]
		private AHOBANHALBL OKJBNHLBLME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		[HIGIANBBMBE]
		private DMFFLNPOJOF BOJLKLHNBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private FOKCOLGHCMD PIPGPNJGNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private NativeHashMap<JCHOAKCKPKK, Entity> HJAHEBKAIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private EntityManager GKHNMAAJNKF;

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		internal NativeHashMap<JCHOAKCKPKK, Entity> GLLANEMLCLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000C72")]
			[Cpp2IlInjected.Address(RVA = "0x100D100", Offset = "0x100C500", VA = "0x18100D100")]
			get
			{
				return default(NativeHashMap<JCHOAKCKPKK, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		internal uint BGMHOAFAHPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C73")]
			[Cpp2IlInjected.Address(RVA = "0x29E5420", Offset = "0x29E4820", VA = "0x1829E5420")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public bool NMHLJFGMGOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000C74")]
			[Cpp2IlInjected.Address(RVA = "0x827CE0", Offset = "0x8270E0", VA = "0x180827CE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C75")]
			[Cpp2IlInjected.Address(RVA = "0xDC75E0", Offset = "0xDC69E0", VA = "0x180DC75E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x29E5610", Offset = "0x29E4A10", VA = "0x1829E5610", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x29E5150", Offset = "0x29E4550", VA = "0x1829E5150", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x29E50D0", Offset = "0x29E44D0", VA = "0x1829E50D0")]
		public void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x29E5450", Offset = "0x29E4850", VA = "0x1829E5450")]
		public void ONGCBPENNFJ(JCHOAKCKPKK OMKLELDMIKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x29E52A0", Offset = "0x29E46A0", VA = "0x1829E52A0")]
		private MOLBNKBNJLI HDINJCFIENE(Entity NOADJCMIKEF)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x29E51C0", Offset = "0x29E45C0", VA = "0x1829E51C0")]
		public MOLBNKBNJLI HCFMGPPNBIF(JCHOAKCKPKK OMKLELDMIKD)
		{
			return default(MOLBNKBNJLI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x29E5730", Offset = "0x29E4B30", VA = "0x1829E5730")]
		public JCHOAKCKPKK POJPFCFFABO(MOLBNKBNJLI AFGGEMMDNNF)
		{
			return default(JCHOAKCKPKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x29E52D0", Offset = "0x29E46D0", VA = "0x1829E52D0")]
		public void IDPOEONFAIO(Entity NOADJCMIKEF, JCHOAKCKPKK OMKLELDMIKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x29E5360", Offset = "0x29E4760", VA = "0x1829E5360")]
		public void JDMDCDOIGID(Entity NOADJCMIKEF, JCHOAKCKPKK OMKLELDMIKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7F")]
		[Cpp2IlInjected.Address(RVA = "0x29E53C0", Offset = "0x29E47C0", VA = "0x1829E53C0")]
		public void KELKLIAAHIE(Entity NOADJCMIKEF, JCHOAKCKPKK OMKLELDMIKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C80")]
		[Cpp2IlInjected.Address(RVA = "0x29E5000", Offset = "0x29E4400", VA = "0x1829E5000")]
		public void AEMHCHBLHBG(Entity NOADJCMIKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[NDGJMMLBLBO(typeof(PropertyEventCallbacksService), new string[] { })]
	[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
	[JLJFNDDLCBO(CBGNDNDJKHL.Callbacks)]
	public class PropertyEventCallbacksService : LNLPIGELLPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		private struct LJJMKFDBLGJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public JPGELEBIAPK MCFINHLOBAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public Type FPPBLNEEHBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public int DEBAMGFBJEH;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		private struct NOEOMJDDNNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public LJJMKFDBLGJ[] OEKBACMEEFA;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CC")]
		public delegate void JPGELEBIAPK(Entity NOADJCMIKEF, EEJFBJIDABN FCLBEIEGADL, PEABCJAGJAH EMCJDFHKAFD, PEABCJAGJAH ADNCLAHHBEC);

		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private static readonly DLHDGHMPCLG HCDIHNPPHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private readonly Dictionary<EEJFBJIDABN, JPGELEBIAPK> LGDEMPJBAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private readonly Dictionary<int, NOEOMJDDNNA> NOIIHLPADHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		private FFMELNGKBPP OEKBACMEEFA;

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action OHBANNEHEDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C83")]
			[Cpp2IlInjected.Address(RVA = "0x29F2DE0", Offset = "0x29F21E0", VA = "0x1829F2DE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C84")]
			[Cpp2IlInjected.Address(RVA = "0x29F3320", Offset = "0x29F2720", VA = "0x1829F3320")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action FBMFKKJPAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000C85")]
			[Cpp2IlInjected.Address(RVA = "0x29F3190", Offset = "0x29F2590", VA = "0x1829F3190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C86")]
			[Cpp2IlInjected.Address(RVA = "0x29F3FC0", Offset = "0x29F33C0", VA = "0x1829F3FC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x29F3F70", Offset = "0x29F3370", VA = "0x1829F3F70", Slot = "4")]
		public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x29F2E80", Offset = "0x29F2280", VA = "0x1829F2E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x29F33C0", Offset = "0x29F27C0", VA = "0x1829F33C0")]
		public void JGOJGDHNHPP(EEJFBJIDABN FCLBEIEGADL, JPGELEBIAPK MCFINHLOBAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x29F3230", Offset = "0x29F2630", VA = "0x1829F3230")]
		public void HCDNKDLABGH(EEJFBJIDABN FCLBEIEGADL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x29F3BF0", Offset = "0x29F2FF0", VA = "0x1829F3BF0")]
		internal void OFOFFNDDBHE(IJGOABCPHPF OHACFAMPHAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8C")]
		[Cpp2IlInjected.Address(RVA = "0x29F3530", Offset = "0x29F2930", VA = "0x1829F3530")]
		private void KFBFEGMOBLF(IJGOABCPHPF OHACFAMPHAM, int LGKEBNGGJEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8D")]
		[Cpp2IlInjected.Address(RVA = "0x29F2F10", Offset = "0x29F2310", VA = "0x1829F2F10")]
		private void EINMJAHEIJI(FPGGICJALNG PKAAAJAKBGK, HBHFLIIDJCA IFOALBGEPOA, LJJMKFDBLGJ JKDKBDIOHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8E")]
		[Cpp2IlInjected.Address(RVA = "0x29F3A70", Offset = "0x29F2E70", VA = "0x1829F3A70")]
		private NOEOMJDDNNA LGCEEIOAFHJ(FPGGICJALNG PKAAAJAKBGK, HBHFLIIDJCA IFOALBGEPOA)
		{
			return default(NOEOMJDDNNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8F")]
		[Cpp2IlInjected.Address(RVA = "0x29F3E80", Offset = "0x29F3280", VA = "0x1829F3E80")]
		private LJJMKFDBLGJ OGCIHHDEHPN(NOEOMJDDNNA KPBJLEKIMFF, FPGGICJALNG PKAAAJAKBGK, HBHFLIIDJCA IFOALBGEPOA)
		{
			return default(LJJMKFDBLGJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C90")]
		[Cpp2IlInjected.Address(RVA = "0x29F40B0", Offset = "0x29F34B0", VA = "0x1829F40B0")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[NDGJMMLBLBO(typeof(MJMALLMJACO), new string[] { })]
public class FALLJFKNMLA : LNLPIGELLPM, ENMEIFNEMLK, MJMALLMJACO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001CE")]
	[CompilerGenerated]
	private sealed class GKOEIAGAFBF : IEnumerable<MOLBNKBNJLI>, IEnumerable, IEnumerator<MOLBNKBNJLI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private MOLBNKBNJLI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public FALLJFKNMLA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private MOLBNKBNJLI splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public MOLBNKBNJLI <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		private MOLBNKBNJLI System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAD")]
			[Cpp2IlInjected.Address(RVA = "0x699040", Offset = "0x698440", VA = "0x180699040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MOLBNKBNJLI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CAF")]
			[Cpp2IlInjected.Address(RVA = "0x2C9F390", Offset = "0x2C9E790", VA = "0x182C9F390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97F60", VA = "0x180A98B60")]
		[DebuggerHidden]
		public GKOEIAGAFBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F1E0", Offset = "0x2C9E5E0", VA = "0x182C9F1E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAE")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F350", Offset = "0x2C9E750", VA = "0x182C9F350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB0")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F2A0", Offset = "0x2C9E6A0", VA = "0x182C9F2A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MOLBNKBNJLI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x2C9F2A0", Offset = "0x2C9E6A0", VA = "0x182C9F2A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private FOKCOLGHCMD PIPGPNJGNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private LMOPGPBPJCF BFPPIPPLMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private ObjectInstantiationService EINHMHCOFBL;

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	private EntityManager HDMAFEMIPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x2BB6440", Offset = "0x2BB5840", VA = "0x182BB6440")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private GDHFGEGLFMK GBPJMMGCLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5EF0", Offset = "0x2BB52F0", VA = "0x182BB5EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C98")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6DB0", Offset = "0x2BB61B0", VA = "0x182BB6DB0", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C99")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5D90", Offset = "0x2BB5190", VA = "0x182BB5D90", Slot = "5")]
	public void CMBAADDFCOC(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5F40", Offset = "0x2BB5340", VA = "0x182BB5F40", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9B")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5FF0", Offset = "0x2BB53F0", VA = "0x182BB5FF0")]
	private void GJKLLKDKPEC(Entity DJOAHPBKNKB, in PEABCJAGJAH EIKDBDKEAPN, in PEABCJAGJAH NDKJFJECHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9C")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5E90", Offset = "0x2BB5290", VA = "0x182BB5E90", Slot = "14")]
	public MOLBNKBNJLI COAICNDGEKM()
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9D")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6930", Offset = "0x2BB5D30", VA = "0x182BB6930", Slot = "10")]
	public void OFCOLDALAEM(MOLBNKBNJLI AFGGEMMDNNF, PHLLHMEAHLO CNMIOIIAHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9E")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6490", Offset = "0x2BB5890", VA = "0x182BB6490", Slot = "9")]
	public PHLLHMEAHLO KPODIHDGGGJ(MOLBNKBNJLI AFGGEMMDNNF)
	{
		return default(PHLLHMEAHLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C9F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6AB0", Offset = "0x2BB5EB0", VA = "0x182BB6AB0", Slot = "11")]
	public MOLBNKBNJLI PFCLJMCGBID(MOLBNKBNJLI JMNNANPLJEH, [Optional] Vector3? EFKMIDDCAKM, [Optional] Quaternion? IAPKIBMDFEP, [Optional] Vector3? IAIJBOFPOEB)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6270", Offset = "0x2BB5670", VA = "0x182BB6270", Slot = "15")]
	public MOLBNKBNJLI HBFELCMKBGH(MOLBNKBNJLI PDKOOIPEPLE, int HMJKJGLHFKE, [Optional] Vector3? EFKMIDDCAKM, [Optional] Quaternion? IAPKIBMDFEP, [Optional] Vector3? IAIJBOFPOEB)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x2BB62B0", Offset = "0x2BB56B0", VA = "0x182BB62B0", Slot = "7")]
	public MOLBNKBNJLI HODMCKJNGBP(MOLBNKBNJLI PDKOOIPEPLE, int HMJKJGLHFKE)
	{
		return default(MOLBNKBNJLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x2BB67B0", Offset = "0x2BB5BB0", VA = "0x182BB67B0", Slot = "16")]
	public void LGLKDGAIKPK(MOLBNKBNJLI PDKOOIPEPLE, MOLBNKBNJLI DJEPACMMDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x2BB5BF0", Offset = "0x2BB4FF0", VA = "0x182BB5BF0", Slot = "12")]
	public void AKIBMMDEHBA(MOLBNKBNJLI PDKOOIPEPLE, int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6610", Offset = "0x2BB5A10", VA = "0x182BB6610", Slot = "17")]
	public void LFMJBGCDEAM(MOLBNKBNJLI PDKOOIPEPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x2BB63A0", Offset = "0x2BB57A0", VA = "0x182BB63A0", Slot = "8")]
	public int JDCMPDBFCPG(MOLBNKBNJLI PDKOOIPEPLE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6580", Offset = "0x2BB5980", VA = "0x182BB6580", Slot = "6")]
	[IteratorStateMachine(typeof(GKOEIAGAFBF))]
	public IEnumerable<MOLBNKBNJLI> LECOMEEEKKA(MOLBNKBNJLI PDKOOIPEPLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6A20", Offset = "0x2BB5E20", VA = "0x182BB6A20")]
	private bool OIBBNBIJBNF(MOLBNKBNJLI PDKOOIPEPLE, out NativeArray<Entity> HEIHGIHIMEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x2BB6870", Offset = "0x2BB5C70", VA = "0x182BB6870")]
	private NativeArray<Entity> MMAKPHBDPAE(MOLBNKBNJLI PDKOOIPEPLE)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public FALLJFKNMLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[NDGJMMLBLBO(typeof(PCGLHKLCLGJ), new string[] { })]
[DAPOABPDMCD(GPPMCHFFAPH.LoadInstance)]
internal sealed class PCGLHKLCLGJ : LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005C5")]
	private NHLELLEJLGC KIEEJCIFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C6")]
	private TransformOwnershipPhase FLKIELBJKJF;

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private FBFMDKPKBLB GEMNOHGEBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x29EA600", Offset = "0x29E9A00", VA = "0x1829EA600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x29EA650", Offset = "0x29E9A50", VA = "0x1829EA650", Slot = "4")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x29EA510", Offset = "0x29E9910", VA = "0x1829EA510")]
	public void HIDPLHNIOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x29EA240", Offset = "0x29E9640", VA = "0x1829EA240")]
	public void ADBKFPNNCKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public PCGLHKLCLGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
public readonly struct DOLPOKPKPHH : IEquatable<DOLPOKPKPHH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005C7")]
	private readonly int LGKEBNGGJEG;

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public Type AKDIGOBFKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB8")]
		[Cpp2IlInjected.Address(RVA = "0x2B92B60", Offset = "0x2B91F60", VA = "0x182B92B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x2B92D40", Offset = "0x2B92140", VA = "0x182B92D40")]
	public DOLPOKPKPHH(Type FPPBLNEEHBP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x2B92CE0", Offset = "0x2B920E0", VA = "0x182B92CE0")]
	public static DOLPOKPKPHH GFKKOGBEPBN(Type FPPBLNEEHBP)
	{
		return default(DOLPOKPKPHH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x2B92CC0", Offset = "0x2B920C0", VA = "0x182B92CC0")]
	public static Type GFKKOGBEPBN(DOLPOKPKPHH CPAMCPHEBME)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0xB8E080", Offset = "0xB8D480", VA = "0x180B8E080")]
	public static bool LPAHFDMKICD(DOLPOKPKPHH GHJDMBPGMHF, DOLPOKPKPHH IKDBBHHKFLJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0xB8E080", Offset = "0xB8D480", VA = "0x180B8E080")]
	public static bool AFMDFHOMNJI(DOLPOKPKPHH GHJDMBPGMHF, DOLPOKPKPHH IKDBBHHKFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x8596A0", Offset = "0x858AA0", VA = "0x1808596A0", Slot = "4")]
	public bool Equals(DOLPOKPKPHH EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x2B92C40", Offset = "0x2B92040", VA = "0x182B92C40", Slot = "0")]
	public override bool Equals(object JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x729E20", Offset = "0x729220", VA = "0x180729E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x2B92D10", Offset = "0x2B92110", VA = "0x182B92D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
public static class AHFBJEGMCKN
{
	[Cpp2IlInjected.Token(Token = "0x40005C8")]
	private static Dictionary<Type, int> ALFIDCIIHJA;

	[Cpp2IlInjected.Token(Token = "0x40005C9")]
	private static List<Type> NKIEIJKLJLM;

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C430", Offset = "0x2B7B830", VA = "0x182B7C430")]
	static AHFBJEGMCKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x15D6770", Offset = "0x15D5B70", VA = "0x1815D6770")]
	public static bool AKBMAMDKLNI<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BF80", Offset = "0x2B7B380", VA = "0x182B7BF80")]
	public static bool AKBMAMDKLNI(Type FPPBLNEEHBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x2B7BFF0", Offset = "0x2B7B3F0", VA = "0x182B7BFF0")]
	private static bool AKBMAMDKLNI(Type FPPBLNEEHBP, out int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC5")]
	[Cpp2IlInjected.Address(RVA = "0x15D68A0", Offset = "0x15D5CA0", VA = "0x1815D68A0")]
	public static int NLBKHCCPJFB<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC6")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C3C0", Offset = "0x2B7B7C0", VA = "0x182B7C3C0")]
	public static int NLBKHCCPJFB(Type FPPBLNEEHBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC7")]
	[Cpp2IlInjected.Address(RVA = "0x15D6800", Offset = "0x15D5C00", VA = "0x1815D6800")]
	public static bool HIJHOGNBHHL<T>(out int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC8")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C280", Offset = "0x2B7B680", VA = "0x182B7C280")]
	public static bool HIJHOGNBHHL(Type FPPBLNEEHBP, out int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC9")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C320", Offset = "0x2B7B720", VA = "0x182B7C320")]
	public static Type JLHLNIPLDNM(int HMJKJGLHFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCA")]
	[Cpp2IlInjected.Address(RVA = "0x2B7C160", Offset = "0x2B7B560", VA = "0x182B7C160")]
	public static bool HIJHOGNBHHL(int HMJKJGLHFKE, out Type FPPBLNEEHBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[DefaultMember("Item")]
public struct PFKCKICDDMD<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CA")]
	private T[] PNMIIEJFOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CB")]
	private int BFFLFOJBLOH;

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public int GCBADAOHFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x7775E0", Offset = "0x7769E0", VA = "0x1807775E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public T HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x1F83590", Offset = "0x1F82990", VA = "0x181F83590")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Span<T> OCDIPMDOHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x28E22C0", Offset = "0x28E16C0", VA = "0x1828E22C0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool IGFHGDGAIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCE")]
		[Cpp2IlInjected.Address(RVA = "0x92FFA0", Offset = "0x92F3A0", VA = "0x18092FFA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x28E24D0", Offset = "0x28E18D0", VA = "0x1828E24D0")]
	public PFKCKICDDMD(int BFFLFOJBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x28E2420", Offset = "0x28E1820", VA = "0x1828E2420")]
	public int PIPJCOJIJLM(T IGDJJEECDAF, int BKLFOLNGODN, int LKJCGNNPEOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x28E2360", Offset = "0x28E1760", VA = "0x1828E2360", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
[DefaultMember("Item")]
public struct FFHMLDMEICH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CC")]
	private global::PFKCKICDDMD<T> PNMIIEJFOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CD")]
	private int BFFLFOJBLOH;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T HIMPFAAIFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD2")]
		[Cpp2IlInjected.Address(RVA = "0x2539DD0", Offset = "0x25391D0", VA = "0x182539DD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int GCBADAOHFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677440", VA = "0x180678040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD4")]
		[Cpp2IlInjected.Address(RVA = "0x2539960", Offset = "0x2538D60", VA = "0x182539960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public int HIDCIHPOCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD5")]
		[Cpp2IlInjected.Address(RVA = "0x253A1F0", Offset = "0x25395F0", VA = "0x18253A1F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CD6")]
		[Cpp2IlInjected.Address(RVA = "0x253A720", Offset = "0x2539B20", VA = "0x18253A720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public bool IGFHGDGAIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD7")]
		[Cpp2IlInjected.Address(RVA = "0x253AC40", Offset = "0x253A040", VA = "0x18253AC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public Span<T> OCDIPMDOHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD8")]
		[Cpp2IlInjected.Address(RVA = "0x25397B0", Offset = "0x2538BB0", VA = "0x1825397B0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x253AE40", Offset = "0x253A240", VA = "0x18253AE40")]
	public FFHMLDMEICH(int BFFLFOJBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x253ABF0", Offset = "0x2539FF0", VA = "0x18253ABF0")]
	public T OMABHGDHAGP(int HMJKJGLHFKE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x253AB80", Offset = "0x2539F80", VA = "0x18253AB80")]
	public void OJNFCEGKFIB(T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x253A080", Offset = "0x2539480", VA = "0x18253A080")]
	public void JLLBHPBJIEA(Span<T> MOBONMBAIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x25394A0", Offset = "0x25388A0", VA = "0x1825394A0")]
	public void AKBMAMDKLNI(T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x253A220", Offset = "0x2539620", VA = "0x18253A220")]
	private void LCNMODMNCBM(int OAKAJHNNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x253A3A0", Offset = "0x25397A0", VA = "0x18253A3A0")]
	public void MAJCBPCOFJK(Span<T> KOPDMFDFEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x253A9E0", Offset = "0x2539DE0", VA = "0x18253A9E0")]
	public void NNIKAMNOCBN(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x2539BB0", Offset = "0x2538FB0", VA = "0x182539BB0")]
	public void GNLDEGLIHLJ(int DBCBAJDDDJO, int AJIMECHHNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x253A770", Offset = "0x2539B70", VA = "0x18253A770")]
	public void MPEIJCCPMAM(int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x253A7D0", Offset = "0x2539BD0", VA = "0x18253A7D0")]
	public void NJBMBBDGCEK(int DBCBAJDDDJO, int AJIMECHHNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x253AD10", Offset = "0x253A110", VA = "0x18253AD10")]
	public void PKPFBILDAJB(int OAKAJHNNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x2539FC0", Offset = "0x25393C0", VA = "0x182539FC0")]
	public void IHBINIBPLJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE6")]
	[Cpp2IlInjected.Address(RVA = "0x253AC80", Offset = "0x253A080", VA = "0x18253AC80")]
	public int PIPJCOJIJLM(T IGDJJEECDAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE7")]
	[Cpp2IlInjected.Address(RVA = "0x2539900", Offset = "0x2538D00", VA = "0x182539900")]
	public bool BJDJCLJIFEK(T IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE8")]
	[Cpp2IlInjected.Address(RVA = "0x2539AF0", Offset = "0x2538EF0", VA = "0x182539AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE9")]
	[Cpp2IlInjected.Address(RVA = "0x253ADD0", Offset = "0x253A1D0", VA = "0x18253ADD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x2539B40", Offset = "0x2538F40", VA = "0x182539B40")]
	public static Span<T> GFKKOGBEPBN(global::FFHMLDMEICH<T> MOBONMBAIDJ)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x253AA40", Offset = "0x2539E40", VA = "0x18253AA40")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void OEAPNGIEHLB(int IGDJJEECDAF, int BFFLFOJBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void IGDKFHIMCKF(int BFFLFOJBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CED")]
	[Cpp2IlInjected.Address(RVA = "0x2539E60", Offset = "0x2539260", VA = "0x182539E60")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void IGDKFHIMCKF(int BFFLFOJBLOH, int HMJKJGLHFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEE")]
	[Cpp2IlInjected.Address(RVA = "0x253A5E0", Offset = "0x25399E0", VA = "0x18253A5E0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void MHGDCBLGJAK(int IGDJJEECDAF, int BFFLFOJBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEF")]
	[Cpp2IlInjected.Address(RVA = "0x25395B0", Offset = "0x25389B0", VA = "0x1825395B0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void BBHFINIDCHP(int DBCBAJDDDJO, int AJIMECHHNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF0")]
	[Cpp2IlInjected.Address(RVA = "0x25399B0", Offset = "0x2538DB0", VA = "0x1825399B0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private static void CKAPLINPJBJ(int IGDJJEECDAF, int BFFLFOJBLOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public struct AMEAPFGBPJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private const int ILHBMKAEJBG = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private NativeList<Entity> NPCFKLDOKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private TransformAccessArray EDICDNMPJLP;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x2B7D010", Offset = "0x2B7C410", VA = "0x182B7D010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public NativeList<Entity> DLPJCMCHBDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0xCE87A0", Offset = "0xCE7BA0", VA = "0x180CE87A0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public TransformAccessArray LNNMHOEOFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF4")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool NMHLJFGMGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF5")]
		[Cpp2IlInjected.Address(RVA = "0x2B7CFE0", Offset = "0x2B7C3E0", VA = "0x182B7CFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF1")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D130", Offset = "0x2B7C530", VA = "0x182B7D130")]
	public AMEAPFGBPJG(int OAKAJHNNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x2B7CF10", Offset = "0x2B7C310", VA = "0x182B7CF10")]
	public Entity CKIDFCCDHGM(int HMJKJGLHFKE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D000", Offset = "0x2B7C400", VA = "0x182B7D000")]
	public Transform JHFEJDPMLDH(int HMJKJGLHFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D0E0", Offset = "0x2B7C4E0", VA = "0x182B7D0E0")]
	public void OLDDKHHDGDP(int OAKAJHNNELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x2B7CE40", Offset = "0x2B7C240", VA = "0x182B7CE40")]
	public int AKBMAMDKLNI(Transform KFAGMEKKLDA, Entity NOADJCMIKEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D060", Offset = "0x2B7C460", VA = "0x182B7D060")]
	public int NNIKAMNOCBN(int HMJKJGLHFKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x2B7CF60", Offset = "0x2B7C360", VA = "0x182B7CF60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x2B7D020", Offset = "0x2B7C420", VA = "0x182B7D020")]
	private void NBGPHKGODKE(int BMOONABBIIA = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
internal class KKLBCGPMJCP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private NativeHashMap<DOLPOKPKPHH, int2> KMNCJAOBHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D2")]
	private NativeList<byte> CCBBJEPJPEO;

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x2BC9150", Offset = "0x2BC8550", VA = "0x182BC9150")]
	public KKLBCGPMJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8A70", Offset = "0x2BC7E70", VA = "0x182BC8A70")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	public void KNBGLHDOKIA<T>(T IGDJJEECDAF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	public T JLHLNIPLDNM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8EA0", Offset = "0x2BC82A0", VA = "0x182BC8EA0")]
	public void KNBGLHDOKIA(Type FPPBLNEEHBP, PEABCJAGJAH IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8C90", Offset = "0x2BC8090", VA = "0x182BC8C90")]
	public PEABCJAGJAH JLHLNIPLDNM(Type FPPBLNEEHBP)
	{
		return default(PEABCJAGJAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x2BC90B0", Offset = "0x2BC84B0", VA = "0x182BC90B0")]
	private NativeArray<byte> ONGENMBNOAE(int2 IPPHOHPDJHC)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8AD0", Offset = "0x2BC7ED0", VA = "0x182BC8AD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8B70", Offset = "0x2BC7F70", VA = "0x182BC8B70", Slot = "1")]
	~KKLBCGPMJCP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D6")]
public struct DOKJBLJCPPA<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x17000177")]
	internal static T KGOGAJOHGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000D06")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	public static global::DOKJBLJCPPA<T> GFKKOGBEPBN(T IGDJJEECDAF)
	{
		return default(global::DOKJBLJCPPA<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	public static T GFKKOGBEPBN(global::DOKJBLJCPPA<T> HNGNIFMJFIP)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public static class KJAKJANIKLE
{
	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	private static readonly KKLBCGPMJCP JLBOFMFMHMA;

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x2BC85B0", Offset = "0x2BC79B0", VA = "0x182BC85B0")]
	internal static void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	public static void KNBGLHDOKIA<T>(T IGDJJEECDAF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8700", Offset = "0x2BC7B00", VA = "0x182BC8700")]
	public static void KNBGLHDOKIA(Type FPPBLNEEHBP, PEABCJAGJAH IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	public static T JLHLNIPLDNM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0D")]
	[Cpp2IlInjected.Address(RVA = "0x2BC8660", Offset = "0x2BC7A60", VA = "0x182BC8660")]
	public static PEABCJAGJAH JLHLNIPLDNM(Type FPPBLNEEHBP)
	{
		return default(PEABCJAGJAH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public class IPFPHLNMOJI : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	public static readonly IPFPHLNMOJI BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x6000D0F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC4880", Offset = "0x2BC3C80", VA = "0x182BC4880", Slot = "4")]
	public bool Equals(LinkedEntityGroup BCJCIOLMPPL, LinkedEntityGroup OIPENDMCMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D10")]
	[Cpp2IlInjected.Address(RVA = "0x2BC48A0", Offset = "0x2BC3CA0", VA = "0x182BC48A0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup JLBINKLPHKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public IPFPHLNMOJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
internal class DHMNFMLIDFC
{
	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void EMPHCBJNDGO(in Vector3 EFKMIDDCAKM, in Quaternion IAPKIBMDFEP, in Vector3 IAIJBOFPOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void ALNEHIKODOE(in Vector3 MCECBNCNFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void BBINBGNNFIG(in Quaternion IAPKIBMDFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void EJFBHDCBGPA(in Vector3 CAGONDMCANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void HGIDOEKLCEN(in Vector3 CAGONDMCANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void AFJMONGAOIA(in float JEBHDDNDEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x2B913E0", Offset = "0x2B907E0", VA = "0x182B913E0")]
	[Conditional("DEBUG_BUILD")]
	public static void DLEKAPELMJE(in float3 IGDJJEECDAF, string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void AEPBGKBLDHK(in float IGDJJEECDAF, string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	[Cpp2IlInjected.Address(RVA = "0x2B91390", Offset = "0x2B90790", VA = "0x182B91390")]
	[Conditional("DEBUG_BUILD")]
	public static void AEPBGKBLDHK(in Vector3 IGDJJEECDAF, string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x2B91360", Offset = "0x2B90760", VA = "0x182B91360")]
	[Conditional("DEBUG_BUILD")]
	public static void AEPBGKBLDHK(in Quaternion IGDJJEECDAF, string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x2B91500", Offset = "0x2B90900", VA = "0x182B91500")]
	[Conditional("DEBUG_BUILD")]
	public static void MCIBMFAFDMG(in float IGDJJEECDAF, string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x2B91490", Offset = "0x2B90890", VA = "0x182B91490")]
	[Conditional("DEBUG_BUILD")]
	public static void MCIBMFAFDMG(in Vector3 IGDJJEECDAF, string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x2B914D0", Offset = "0x2B908D0", VA = "0x182B914D0")]
	[Conditional("DEBUG_BUILD")]
	public static void MCIBMFAFDMG(in Quaternion IGDJJEECDAF, string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public DHMNFMLIDFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public struct AMKCICGGHCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	public Entity NOADJCMIKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	public Entity OOHIPCPJDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	public Entity CNMJLCOJOLA;

	[Cpp2IlInjected.Token(Token = "0x6000D21")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DEE0", Offset = "0x2B7D2E0", VA = "0x182B7DEE0")]
	public AMKCICGGHCJ(Entity NOADJCMIKEF, Entity OOHIPCPJDEM, Entity CNMJLCOJOLA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DEA0", Offset = "0x2B7D2A0", VA = "0x182B7DEA0")]
	public static AMKCICGGHCJ GFKKOGBEPBN((Entity entity, Entity oldParent, Entity newParent) EGMOJPMOOBM)
	{
		return default(AMKCICGGHCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DE80", Offset = "0x2B7D280", VA = "0x182B7DE80")]
	public void ADGEHKFIFPI(out Entity NOADJCMIKEF, out Entity OOHIPCPJDEM, out Entity CNMJLCOJOLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public struct IEBEIBNAHNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	public Entity NOADJCMIKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	public Entity JFCNGAACNEO;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0xF6EA70", Offset = "0xF6DE70", VA = "0x180F6EA70")]
	public IEBEIBNAHNC(Entity NOADJCMIKEF, Entity JFCNGAACNEO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	[Cpp2IlInjected.Address(RVA = "0x2BC39E0", Offset = "0x2BC2DE0", VA = "0x182BC39E0")]
	public static IEBEIBNAHNC GFKKOGBEPBN((Entity entity, Entity parent) EGMOJPMOOBM)
	{
		return default(IEBEIBNAHNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x2BC39D0", Offset = "0x2BC2DD0", VA = "0x182BC39D0")]
	public void ADGEHKFIFPI(out Entity NOADJCMIKEF, out Entity JFCNGAACNEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
public struct FICGCEMEMGA<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private GCHandle CPAMCPHEBME;

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public bool BCNGLDHMDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000D28")]
		[Cpp2IlInjected.Address(RVA = "0x25C83E0", Offset = "0x25C77E0", VA = "0x1825C83E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public T KGOGAJOHGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000D29")]
		[Cpp2IlInjected.Address(RVA = "0x25C8310", Offset = "0x25C7710", VA = "0x1825C8310")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D2A")]
		[Cpp2IlInjected.Address(RVA = "0x25C83F0", Offset = "0x25C77F0", VA = "0x1825C83F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	[Cpp2IlInjected.Address(RVA = "0x25C84B0", Offset = "0x25C78B0", VA = "0x1825C84B0")]
	public FICGCEMEMGA(T IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x25C83B0", Offset = "0x25C77B0", VA = "0x1825C83B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public enum AKBFNMCPNLN
{
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct HFLBLBGKEBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	public AKBFNMCPNLN LFPDNPFENIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	public int PPENGGAAFLO;

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x699050", Offset = "0x698450", VA = "0x180699050")]
	public HFLBLBGKEBE(AKBFNMCPNLN LFPDNPFENIF, int PPENGGAAFLO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D2D")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDAC0", Offset = "0x2BBCEC0", VA = "0x182BBDAC0")]
	public static HFLBLBGKEBE GFKKOGBEPBN((AKBFNMCPNLN eventType, int eventIndex) BCJCIOLMPPL)
	{
		return default(HFLBLBGKEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDAB0", Offset = "0x2BBCEB0", VA = "0x182BBDAB0")]
	public void ADGEHKFIFPI(out AKBFNMCPNLN LFPDNPFENIF, out int PPENGGAAFLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
[NDGJMMLBLBO(typeof(ACNEILCJOBP), new string[] { })]
public sealed class DNLNDNFFLAO : ACNEILCJOBP, LNLPIGELLPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private FFGAOMNGKBA AADPIDIMPMD;

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x2B92B10", Offset = "0x2B91F10", VA = "0x182B92B10", Slot = "5")]
	public void PFOFLCKCLDI(CLFAHLJOOKN IFCDDJDBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x2B92A20", Offset = "0x2B91E20", VA = "0x182B92A20")]
	public bool MNHMCADOMJC(in float3 GGAECKMEFID, in float3 BENEMIPHCAB, float KKONCICCPBC, Allocator JLPBABJNDBH, out NativeArray<Entity> NPCFKLDOKOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public DNLNDNFFLAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x2B92A20", Offset = "0x2B91E20", VA = "0x182B92A20", Slot = "4")]
	private bool NLDCPDNIKEJ(in float3 GGAECKMEFID, in float3 BENEMIPHCAB, float KKONCICCPBC, Allocator JLPBABJNDBH, out NativeArray<Entity> NPCFKLDOKOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
[NIILAANKHKM]
[UpdateInGroup(typeof(FFEMAFADNDK))]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
internal sealed class EDOEFBEPCHK : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x2B949C0", Offset = "0x2B93DC0", VA = "0x182B949C0", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public EDOEFBEPCHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[NIILAANKHKM]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
[UpdateInGroup(typeof(EHONLCGGBPL))]
public sealed class OOHDJCGKGHP : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x29DDD30", Offset = "0x29DD130", VA = "0x1829DDD30", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public OOHDJCGKGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[NIILAANKHKM]
[UpdateInGroup(typeof(OKJDCIDJPAO))]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
internal sealed class MAIEECKHFPJ : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0BE0", Offset = "0x2BCFFE0", VA = "0x182BD0BE0", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public MAIEECKHFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
internal class MGOLKJDNOCE : ADABOGHGFDG
{
	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public MGOLKJDNOCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[ExecuteAlways]
[NIILAANKHKM]
[OKNDCPNCELC(GPPMCHFFAPH.LoadInstance)]
[UpdateInGroup(typeof(HGLDNFGGGGB))]
internal sealed class PFJFMCDJAOF : CGHAJPCIAGI
{
	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x29EA7F0", Offset = "0x29E9BF0", VA = "0x1829EA7F0", Slot = "16")]
	protected override ComponentSystemBase JFNPJNFKGCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0x29D71A0", Offset = "0x29D65A0", VA = "0x1829D71A0")]
	public PFJFMCDJAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[AGANJGMMKAI(typeof(AuthoredLocalPoseData))]
public sealed class OHINJNCFEND : LBKOJPFIAML
{
	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x29DBAC0", Offset = "0x29DAEC0", VA = "0x1829DBAC0", Slot = "8")]
	protected override bool KPCOEHPAIKM(ReadOnlySpan<AuthoredLocalPoseData> KOPDMFDFEFH, OBEFJIDEFOJ JDIPGKNLNAI, out ReadOnlySpan<byte> BIPDDAIIHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x29DBB40", Offset = "0x29DAF40", VA = "0x1829DBB40", Slot = "9")]
	protected override bool LBDKCIOBKJO(int FMCKDMNHLLD, Span<AuthoredLocalPoseData> KOPDMFDFEFH, in ReadOnlySpan<byte> BIPDDAIIHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D43")]
	[Cpp2IlInjected.Address(RVA = "0x29DBC00", Offset = "0x29DB000", VA = "0x1829DBC00")]
	public OHINJNCFEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[AGANJGMMKAI(typeof(LocalPoseData))]
public sealed class GDOKJFFCDDH : EHJHLLIBFLG
{
	[Cpp2IlInjected.Token(Token = "0x6000D44")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA4A0", Offset = "0x2BB98A0", VA = "0x182BBA4A0", Slot = "8")]
	protected override bool KPCOEHPAIKM(ReadOnlySpan<LocalPoseData> KOPDMFDFEFH, OBEFJIDEFOJ JDIPGKNLNAI, out ReadOnlySpan<byte> BIPDDAIIHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D45")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA520", Offset = "0x2BB9920", VA = "0x182BBA520", Slot = "9")]
	protected override bool LBDKCIOBKJO(int FMCKDMNHLLD, Span<LocalPoseData> KOPDMFDFEFH, in ReadOnlySpan<byte> BIPDDAIIHHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA5E0", Offset = "0x2BB99E0", VA = "0x182BBA5E0")]
	public GDOKJFFCDDH()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001E7")]
	[Preserve]
	internal class _RRAssemblyIndex : JAMCEJDIEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000D47")]
		[Cpp2IlInjected.Address(RVA = "0x679B40", Offset = "0x678F40", VA = "0x180679B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D48")]
		[Cpp2IlInjected.Address(RVA = "0x2CBA410", Offset = "0x2CB9810", VA = "0x182CBA410", Slot = "6")]
		public sealed override void FOLCGPFLFII(JPJOAJAPKJJ MCFINHLOBAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D49")]
		[Cpp2IlInjected.Address(RVA = "0x2CBB3B0", Offset = "0x2CBA7B0", VA = "0x182CBB3B0", Slot = "4")]
		public sealed override void PJNICPDDEAL()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001E8")]
public class NLJAGALCJKH
{
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private static byte[] JCLCDCCNAPM;

	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private static int BKAHGFCDIKL;

	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private static int GJMNCFGIJLO;

	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private static BigInteger MOEAOMJCPNL;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NLJAGALCJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x29D7AB0", Offset = "0x29D6EB0", VA = "0x1829D7AB0")]
	private static string EMKPABEMONO(byte[] IKDBBHHKFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x29D7BC0", Offset = "0x29D6FC0", VA = "0x1829D7BC0")]
	public static string NJEIEMNKMPN(byte[] EEMDNKKFCBK, bool DIMJIPPBEJB)
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
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
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
