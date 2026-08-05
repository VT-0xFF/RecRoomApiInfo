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
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
public sealed class KCJANDBFGFM<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class LPGOOGIANOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::KCJANDBFGFM<T> AOJNKIJGDNH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] ENAGKMPEBJK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public LPGOOGIANOH(global::KCJANDBFGFM<T> AOJNKIJGDNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class POIONGLJGBE : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::KCJANDBFGFM<T> <>4__this;

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
		public POIONGLJGBE(int <>1__state)
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
	private const int HMKBOIPPFFD = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> AJMPNHCLIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int INPECHCLOBG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T ICEOJCBPDOD
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
	private bool KJIIGMAMMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool ACKHGMAHMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool BDPNHLCFEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MGOGDIHFDIH
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
	public int CAAMIJFBOBJ
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
	public KCJANDBFGFM(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public KCJANDBFGFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void DIMDCAEDBIF(int MMABPPDCBIB, T EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void CLBKMDGGMLI(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] HHOLENPNECD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void JCGHKBDCGNP(NativeArray<T> KPAFOBEJBIN, int MOIHFCJJBCN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::KCJANDBFGFM<>.POIONGLJGBE))]
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
	public int OCHPPPJPAPL(T EKFBJDGFFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool ADDEDGCCJIP(T EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void EJHHDJAKDAK(int JHEHCOPJFDL, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void EHKKAMJKFPC(int JHEHCOPJFDL, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void KJKNFGGHPCK(int JHEHCOPJFDL, int EGBIMJLECFF, int LGKBEOCJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int IAEGLCELGPL(int MMABPPDCBIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T IKLDOOCAGGF(int MMABPPDCBIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void LPCNBBMEBGI(int MMABPPDCBIB, T EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void MAKPENHKGIF(int MMABPPDCBIB, T EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void CJPEFGFHFDD(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int GLNACCDMJCH(int CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int BIOFHIEILPG(int CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void LMCBIAIIPCE(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void IEMHOENPOJJ(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T HGHLGKMIDAF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T KKINNOPLGKF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void KEPLBCOAPPE(int MMABPPDCBIB, IReadOnlyCollection<T> JBGBCNGIBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void EEOFODLMHHG(int MMABPPDCBIB, int PDFFHKKNBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void KAGHGOKLKJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void HLENNJAIKCA(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void MFBIKDIGEMD(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void DBMHDOPKHCJ(int EGBIMJLECFF, int LGKBEOCJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T HJGCDCHPHFH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T DMJEDPELCAN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[MGJNHNIALFH]
public static class KIEPGABADJG
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A3F0", Offset = "0x3A98BF0", VA = "0x183A9A3F0")]
	static KIEPGABADJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2E2ACC0", Offset = "0x2E294C0", VA = "0x182E2ACC0")]
	public static void GDHIBEDPMBB<T>(T EADBNCPOLHD, ref T JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A0E0", Offset = "0x3A988E0", VA = "0x183A9A0E0")]
	public static void GDHIBEDPMBB(FixedString32 EADBNCPOLHD, ref string JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A380", Offset = "0x3A98B80", VA = "0x183A9A380")]
	public static void GDHIBEDPMBB(string EADBNCPOLHD, ref FixedString32 JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A0B0", Offset = "0x3A988B0", VA = "0x183A9A0B0")]
	public static void GDHIBEDPMBB(FixedString64 EADBNCPOLHD, ref string JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A150", Offset = "0x3A98950", VA = "0x183A9A150")]
	public static void GDHIBEDPMBB(string EADBNCPOLHD, ref FixedString64 JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x31A6FA0", Offset = "0x31A57A0", VA = "0x1831A6FA0")]
	public static void GDHIBEDPMBB(GGBCKKLMAGJ EADBNCPOLHD, ref Vector3 JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A2F0", Offset = "0x3A98AF0", VA = "0x183A9A2F0")]
	public static void GDHIBEDPMBB(Vector3 EADBNCPOLHD, ref GGBCKKLMAGJ JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A350", Offset = "0x3A98B50", VA = "0x183A9A350")]
	public static void GDHIBEDPMBB(MFLBMMHEHMP EADBNCPOLHD, ref Vector4 JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A240", Offset = "0x3A98A40", VA = "0x183A9A240")]
	public static void GDHIBEDPMBB(Vector4 EADBNCPOLHD, ref MFLBMMHEHMP JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A350", Offset = "0x3A98B50", VA = "0x183A9A350")]
	public static void GDHIBEDPMBB(MFLBMMHEHMP EADBNCPOLHD, ref Quaternion JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A240", Offset = "0x3A98A40", VA = "0x183A9A240")]
	public static void GDHIBEDPMBB(Quaternion EADBNCPOLHD, ref MFLBMMHEHMP JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A3C0", Offset = "0x3A98BC0", VA = "0x183A9A3C0")]
	public static void GDHIBEDPMBB(GGBCKKLMAGJ EADBNCPOLHD, ref float3 JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A2F0", Offset = "0x3A98AF0", VA = "0x183A9A2F0")]
	public static void GDHIBEDPMBB(float3 EADBNCPOLHD, ref GGBCKKLMAGJ JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A110", Offset = "0x3A98910", VA = "0x183A9A110")]
	public static void GDHIBEDPMBB(MFLBMMHEHMP EADBNCPOLHD, ref float4 JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A240", Offset = "0x3A98A40", VA = "0x183A9A240")]
	public static void GDHIBEDPMBB(float4 EADBNCPOLHD, ref MFLBMMHEHMP JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A110", Offset = "0x3A98910", VA = "0x183A9A110")]
	public static void GDHIBEDPMBB(MFLBMMHEHMP EADBNCPOLHD, ref quaternion JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A1B0", Offset = "0x3A989B0", VA = "0x183A9A1B0")]
	public static void GDHIBEDPMBB(quaternion EADBNCPOLHD, ref MFLBMMHEHMP JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A2B0", Offset = "0x3A98AB0", VA = "0x183A9A2B0")]
	public static void GDHIBEDPMBB(Entity EADBNCPOLHD, ref DHDJKFAIJMC JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A220", Offset = "0x3A98A20", VA = "0x183A9A220")]
	public static void GDHIBEDPMBB(DHDJKFAIJMC EADBNCPOLHD, ref Entity JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BBHEDGKDAJF : ICEHLGPCFGD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int MACDNMEDCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IBNEEFGBPPM PAHAANGGJJI(Entity GDNDJKDEKFN);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PCNBCAJFMIC(NativeArray<IBNEEFGBPPM> ICIEPJPHBOB, NativeArray<MFPGKDHMCFI> ANAGHLFLMHC);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ACHJKEDIMPM(IBNEEFGBPPM BLIPNDKFLPL);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NFOGJKLJKKE(IBNEEFGBPPM BLIPNDKFLPL, out Collider DMJMICMIACH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PAOAHFGMMNM]
public class PNLPAOCPOLP : ComponentSystem, DNEGIKEIIMB
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EEAJKGBJNOA MOCCPLHNPLK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6E3870", Offset = "0x6E2070", VA = "0x1806E3870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OMBILBANOEN BKOIEKNNDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A60", Offset = "0x6F4260", VA = "0x1806F5A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x384B610", Offset = "0x3849E10", VA = "0x18384B610", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0")]
	public PNLPAOCPOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD7F0", Offset = "0x3AABFF0", VA = "0x183AAD7F0")]
		public static ObjectModelConfigAsset INDEKLGDBGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x81CFC0", Offset = "0x81B7C0", VA = "0x18081CFC0")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[HPLMCJEDJJG(KOEAPPNBOCD.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int JNJAOIIOAAL = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly JJLACLCEPON MNIOACBCBNF;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x51D23C0", Offset = "0x51D0BC0", VA = "0x1851D23C0")]
			public static DDAOHKAFOIC JLFOIJJKCMC(int PCKMECAILKF)
			{
				return default(DDAOHKAFOIC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x51D25F0", Offset = "0x51D0DF0", VA = "0x1851D25F0")]
			public static int NOLFAIKCAJJ(GameObject HBGIADIFHEC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x51D2570", Offset = "0x51D0D70", VA = "0x1851D2570")]
			[Conditional("UNITY_EDITOR")]
			[Conditional("DEBUG_BUILD")]
			private static void MALHAPLNBAG(IOFHLMDPEAL CPBDAEHELGD, int PCKMECAILKF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static PCJIKNDFKDJ DFNJPCAHLCE;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static EKIBDKMJGBC JNIMGFMHNMP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static PCJIKNDFKDJ MOLDMOAGNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3AAE8E0", Offset = "0x3AAD0E0", VA = "0x183AAE8E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3AAEF40", Offset = "0x3AAD740", VA = "0x183AAEF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static EKIBDKMJGBC EOGADIBFGBI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3AADCE0", Offset = "0x3AAC4E0", VA = "0x183AADCE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x3AAE610", Offset = "0x3AACE10", VA = "0x183AAE610")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool DMBOBCAHOHH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3AAE3C0", Offset = "0x3AACBC0", VA = "0x183AAE3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static OMBILBANOEN BKOIEKNNDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3AADC60", Offset = "0x3AAC460", VA = "0x183AADC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LLNLFBIJEEI IPAILOOANFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x3AAE490", Offset = "0x3AACC90", VA = "0x183AAE490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static KGMAJJBPDAG MFPOBIMPBDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3AADA50", Offset = "0x3AAC250", VA = "0x183AADA50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static NCNJODMFFIF PJKMGICLPAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3AADE50", Offset = "0x3AAC650", VA = "0x183AADE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static HCGMPCJKLOI DGFBLHPCMKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3AAE340", Offset = "0x3AACB40", VA = "0x183AAE340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool PJOCAJBJDEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3AAE780", Offset = "0x3AACF80", VA = "0x183AAE780")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3AAE940", Offset = "0x3AAD140", VA = "0x183AAE940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool HKCJDPBFKGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3AADED0", Offset = "0x3AAC6D0", VA = "0x183AADED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3AADC00", Offset = "0x3AAC400", VA = "0x183AADC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool FIANIEOIGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3AAD9F0", Offset = "0x3AAC1F0", VA = "0x183AAD9F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x3AAE9F0", Offset = "0x3AAD1F0", VA = "0x183AAE9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action BGGINHAIIIO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3AAE510", Offset = "0x3AACD10", VA = "0x183AAE510")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x3AAECE0", Offset = "0x3AAD4E0", VA = "0x183AAECE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3AAEA50", Offset = "0x3AAD250", VA = "0x183AAEA50")]
		public static IOFHLMDPEAL NDFJMIJLHMK(GameObject HBGIADIFHEC)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE1C0", Offset = "0x3AAC9C0", VA = "0x183AAE1C0")]
		public static DDAOHKAFOIC JCBOEKFMENI(GameObject HBGIADIFHEC)
		{
			return default(DDAOHKAFOIC);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3AAEE20", Offset = "0x3AAD620", VA = "0x183AAEE20")]
		public static CMIMIKMOPKA OFKDENOCGDA(DDAOHKAFOIC LNNGKIMHKAI)
		{
			return default(CMIMIKMOPKA);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3AAEDE0", Offset = "0x3AAD5E0", VA = "0x183AAEDE0")]
		public static CMIMIKMOPKA OFKDENOCGDA(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default(CMIMIKMOPKA);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3AAE060", Offset = "0x3AAC860", VA = "0x183AAE060")]
		public static (ByteString, IDisposable) HHDOHEHKDKI()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD890", Offset = "0x3AAC090", VA = "0x183AAD890")]
		public static (ByteString, IDisposable) AGCKAEMKIME(IEnumerable<IOFHLMDPEAL> CIJFIAADMDF)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3AADAD0", Offset = "0x3AAC2D0", VA = "0x183AADAD0")]
		public static bool CGOKJOMFBHB(GameObject HBGIADIFHEC, out DDAOHKAFOIC LNNGKIMHKAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3AADF30", Offset = "0x3AAC730", VA = "0x183AADF30")]
		public static bool GCDCIAIFMFN(GameObject HBGIADIFHEC, out bool AFEDMKKOOGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3AAEBB0", Offset = "0x3AAD3B0", VA = "0x183AAEBB0")]
		private static EKIBDKMJGBC NMHNKMFIFNL()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NLBCBKNLKCE
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly JJLACLCEPON MNIOACBCBNF;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x3AA29B0", Offset = "0x3AA11B0", VA = "0x183AA29B0")]
	public static GHMJIBJLDNA IIGIGLNPDMN(GameObject HBGIADIFHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2B90", Offset = "0x3AA1390", VA = "0x183AA2B90")]
	public static GHMJIBJLDNA IIGIGLNPDMN(GameObject HBGIADIFHEC, DDAOHKAFOIC LNNGKIMHKAI)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class DisembodiedObjectView : MonoBehaviour, CILKBEJMALC
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public IOFHLMDPEAL ELJAGEKDLPH
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x74A710", Offset = "0x748F10", VA = "0x18074A710", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(IOFHLMDPEAL);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8FE020", Offset = "0x8FC820", VA = "0x1808FE020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6E7F30", Offset = "0x6E6730", VA = "0x1806E7F30")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleComponent]
	[HPLMCJEDJJG(KOEAPPNBOCD.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, GHMJIBJLDNA, CILKBEJMALC
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string CCNAAKOILDO = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private IOFHLMDPEAL PFLOECMCNHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private DLLAKHALKPJ JCLIGOJKKCI;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IOFHLMDPEAL ELJAGEKDLPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x745CB0", Offset = "0x7444B0", VA = "0x180745CB0", Slot = "11")]
			get
			{
				return default(IOFHLMDPEAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CMIMIKMOPKA EHOCHHJECJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3AF7DA0", Offset = "0x3AF65A0", VA = "0x183AF7DA0", Slot = "4")]
			get
			{
				return default(CMIMIKMOPKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private OMBILBANOEN BKOIEKNNDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x3AF7390", Offset = "0x3AF5B90", VA = "0x183AF7390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private IACMPOBAJCP CDBJAPNEGBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x3AF7C30", Offset = "0x3AF6430", VA = "0x183AF7C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public DLLAKHALKPJ EHPMEKPINPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x74A780", Offset = "0x748F80", VA = "0x18074A780", Slot = "5")]
			get
			{
				return default(DLLAKHALKPJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool FPEMCKPFHNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x71C510", Offset = "0x71AD10", VA = "0x18071C510", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x71C530", Offset = "0x71AD30", VA = "0x18071C530", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> EHNBOGECGAN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x3AF7D00", Offset = "0x3AF6500", VA = "0x183AF7D00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x3AF7DD0", Offset = "0x3AF65D0", VA = "0x183AF7DD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x3AF72B0", Offset = "0x3AF5AB0", VA = "0x183AF72B0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7B10", Offset = "0x3AF6310", VA = "0x183AF7B10", Slot = "13")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7730", Offset = "0x3AF5F30", VA = "0x183AF7730", Slot = "14")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7A80", Offset = "0x3AF6280", VA = "0x183AF7A80", Slot = "8")]
		public void OnEmbody(OMCLDCKMHNM EAMEDKLPJKC, IOFHLMDPEAL PFLOECMCNHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7B00", Offset = "0x3AF6300", VA = "0x183AF7B00", Slot = "9")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7850", Offset = "0x3AF6050", VA = "0x183AF7850", Slot = "10")]
		public void OnDisembody(bool JHPPOHPOIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3AF73E0", Offset = "0x3AF5BE0", VA = "0x183AF73E0")]
		private void JMHOPEIKNJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3AF74E0", Offset = "0x3AF5CE0", VA = "0x183AF74E0")]
		private void NOCKHCGGFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF75A0", Offset = "0x3AF5DA0", VA = "0x183AF75A0")]
		private void OKMIIFMMKKJ(bool KMFDCKDEDNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E7F30", Offset = "0x6E6730", VA = "0x1806E7F30")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x16C83C0", Offset = "0x16C6BC0", VA = "0x1816C83C0", Slot = "7")]
		private GameObject CNEKEKCOBBA()
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
		[Cpp2IlInjected.Address(RVA = "0x6E7F30", Offset = "0x6E6730", VA = "0x1806E7F30")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	[HPLMCJEDJJG(KOEAPPNBOCD.Registration)]
	public sealed class TransformEntity : MonoBehaviour, CILKBEJMALC
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private IOFCPOJDKFL prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private IOFHLMDPEAL CPBDAEHELGD;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IOFCPOJDKFL PEDCKEAKEGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x671690", Offset = "0x66FE90", VA = "0x180671690")]
			get
			{
				return default(IOFCPOJDKFL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x671680", Offset = "0x66FE80", VA = "0x180671680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IOFHLMDPEAL ELJAGEKDLPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x745CB0", Offset = "0x7444B0", VA = "0x180745CB0", Slot = "4")]
			get
			{
				return default(IOFHLMDPEAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal Entity FCMHICMIJCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal NCNJODMFFIF PJKMGICLPAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal IACMPOBAJCP BMOFKAEBDKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x38581D0", Offset = "0x38569D0", VA = "0x1838581D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3857E10", Offset = "0x3856610", VA = "0x183857E10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x38580E0", Offset = "0x38568E0", VA = "0x1838580E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3857E20", Offset = "0x3856620", VA = "0x183857E20")]
		internal void CDFKCHBFAME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x38580E0", Offset = "0x38568E0", VA = "0x1838580E0")]
		internal void GCLFHHNKHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3858240", Offset = "0x3856A40", VA = "0x183858240")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3858320", Offset = "0x3856B20", VA = "0x183858320")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Flags]
public enum PDPEEGAOGNI
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
[OOAPDBLGMJF(typeof(EKIBDKMJGBC), new string[] { })]
public class DCBGKDPAEKA : EKIBDKMJGBC, IDisposable, DMHIFFKBAEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public EEAJKGBJNOA MOCCPLHNPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F5010", Offset = "0x6F3810", VA = "0x1806F5010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HBIJPHJPPAA COEFAKNIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E3870", Offset = "0x6E2070", VA = "0x1806E3870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public OMBILBANOEN BKOIEKNNDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A60", Offset = "0x6F4260", VA = "0x1806F5A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PJOCAJBJDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1460", Offset = "0x3AEFC60", VA = "0x183AF1460", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3AF17F0", Offset = "0x3AEFFF0", VA = "0x183AF17F0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public IMBFPFHIPDB ACNOJBHFKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x106F4B0", Offset = "0x106DCB0", VA = "0x18106F4B0", Slot = "15")]
		get
		{
			return default(IMBFPFHIPDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3AF14D0", Offset = "0x3AEFCD0", VA = "0x183AF14D0")]
	public static DCBGKDPAEKA MFNJFAEBAIM(LDFJPMDODKF AHNMBJFNCGG, PDPEEGAOGNI ALKHBOMOJMO = PDPEEGAOGNI.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1940", Offset = "0x3AF0140", VA = "0x183AF1940")]
	private static void OOGBOJDHBFD(LDFJPMDODKF AHNMBJFNCGG, PDPEEGAOGNI ALKHBOMOJMO = PDPEEGAOGNI.ExcludeIgnore)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3AF10A0", Offset = "0x3AEF8A0", VA = "0x183AF10A0")]
	private static void KPDEFEPDKBI(LDFJPMDODKF AHNMBJFNCGG, PDPEEGAOGNI ALKHBOMOJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0CD0", Offset = "0x3AEF4D0", VA = "0x183AF0CD0")]
	private static string[] GCMFIMOBKCI(PDPEEGAOGNI ALKHBOMOJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1650", Offset = "0x3AEFE50", VA = "0x183AF1650")]
	private static bool NAMMGLFOEDB(PDPEEGAOGNI ALKHBOMOJMO, out string[] EBPPLKIGLIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0A80", Offset = "0x3AEF280", VA = "0x183AF0A80")]
	private static void AJCFGAHIGKB(LDFJPMDODKF AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1A30", Offset = "0x3AF0230", VA = "0x183AF1A30", Slot = "16")]
	public void PGJAPBHHKEM(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xBD3110", Offset = "0xBD1910", VA = "0x180BD3110")]
	private void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3AF13D0", Offset = "0x3AEFBD0", VA = "0x183AF13D0")]
	private void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	private void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0C30", Offset = "0x3AEF430", VA = "0x183AF0C30", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3AF18D0", Offset = "0x3AF00D0", VA = "0x183AF18D0", Slot = "19")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0B50", Offset = "0x3AEF350", VA = "0x183AF0B50", Slot = "9")]
	public void DALNGINDNDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "10")]
	public void GLMFLMDDEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0FC0", Offset = "0x3AEF7C0", VA = "0x183AF0FC0", Slot = "11")]
	public void IHIGOIDMCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0980", Offset = "0x3AEF180", VA = "0x183AF0980", Slot = "7")]
	public void ADHMOLAJGDE(ByteString PJDKPCLOECB, ICHAMCHHHDE ALKHBOMOJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1030", Offset = "0x3AEF830", VA = "0x183AF1030", Slot = "8")]
	public void KIIHOPNIAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0BC0", Offset = "0x3AEF3C0", VA = "0x183AF0BC0", Slot = "12")]
	public void DMGEALDACPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0E60", Offset = "0x3AEF660", VA = "0x183AF0E60", Slot = "13")]
	public void GLBNGIHMHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0ED0", Offset = "0x3AEF6D0", VA = "0x183AF0ED0", Slot = "20")]
	public ByteString HHDOHEHKDKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x65E740", Offset = "0x65CF40", VA = "0x18065E740")]
	private static bool LMGONBENPJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public DCBGKDPAEKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BPOMPEGFCLB
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8F20", Offset = "0x3AE7720", VA = "0x183AE8F20")]
	public static CMIMIKMOPKA KKBHPDPGGIO(this EKIBDKMJGBC JNIMGFMHNMP, DDAOHKAFOIC LNNGKIMHKAI, IOFCPOJDKFL OHBBEKBPFPH)
	{
		return default(CMIMIKMOPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8CE0", Offset = "0x3AE74E0", VA = "0x183AE8CE0")]
	public static LLLDPGKHFIG BNLAGHNGNJO(this EKIBDKMJGBC JNIMGFMHNMP)
	{
		return default(LLLDPGKHFIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9190", Offset = "0x3AE7990", VA = "0x183AE9190")]
	public static IOFHLMDPEAL NDFJMIJLHMK(this EKIBDKMJGBC JNIMGFMHNMP, Entity GDNDJKDEKFN)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9060", Offset = "0x3AE7860", VA = "0x183AE9060")]
	public static IOFHLMDPEAL NDFJMIJLHMK(this EKIBDKMJGBC JNIMGFMHNMP, DDAOHKAFOIC LNNGKIMHKAI)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8E00", Offset = "0x3AE7600", VA = "0x183AE8E00")]
	public static DDAOHKAFOIC JCBOEKFMENI(this EKIBDKMJGBC JNIMGFMHNMP, IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(DDAOHKAFOIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public class GKPBOJPKODO<T> : global::EIBFBEFLHFD<T>, global::NJDICNIFPMB<DDAOHKAFOIC, T>, global::BCFBMFIFGMA<DDAOHKAFOIC>, BDLFOPPLKDB, IDisposable, KONIEIPNKKM where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly global::BCFBMFIFGMA<Entity> MIGODNJAHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly NCNJODMFFIF JHCECLNHNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Delegate BJANLMFOEJC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string AKFKAJPCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x493C600", Offset = "0x493AE00", VA = "0x18493C600", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Type JIDICLJAOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x493C260", Offset = "0x493AA60", VA = "0x18493C260", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICGJPAAOHAG GCDLNKNDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4942480", Offset = "0x4940C80", VA = "0x184942480", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int FNIAHIHPNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4942610", Offset = "0x4940E10", VA = "0x184942610", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public OGIFHIADLBO HCBHFPPKOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x493B4F0", Offset = "0x4939CF0", VA = "0x18493B4F0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x20345D0", Offset = "0x2032DD0", VA = "0x1820345D0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x492F540", Offset = "0x492DD40", VA = "0x18492F540", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event global::GBCMJJGIGAL<DDAOHKAFOIC> IHHEOJAELKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x493F0E0", Offset = "0x493D8E0", VA = "0x18493F0E0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x492F2F0", Offset = "0x492DAF0", VA = "0x18492F2F0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B4E0", Offset = "0x3D79CE0", VA = "0x183D7B4E0")]
	public GKPBOJPKODO(global::BCFBMFIFGMA<Entity> MIGODNJAHNA, NCNJODMFFIF JHCECLNHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4931240", Offset = "0x492FA40", VA = "0x184931240")]
	private Entity EKGOOABIHMK(DDAOHKAFOIC LNNGKIMHKAI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x41C23E0", Offset = "0x41C0BE0", VA = "0x1841C23E0")]
	private DDAOHKAFOIC EKGOOABIHMK(Entity GDNDJKDEKFN)
	{
		return default(DDAOHKAFOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x493D180", Offset = "0x493B980", VA = "0x18493D180", Slot = "4")]
	public T KEEHOGKCDPF(DDAOHKAFOIC LNNGKIMHKAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4930950", Offset = "0x492F150", VA = "0x184930950")]
	public bool DIMECELKFHA(DDAOHKAFOIC LNNGKIMHKAI, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x493B020", Offset = "0x4939820", VA = "0x18493B020")]
	public bool HNBCALPENJO(DDAOHKAFOIC LNNGKIMHKAI, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4934EE0", Offset = "0x49336E0", VA = "0x184934EE0", Slot = "9")]
	public bool FKKMCEBMOMF(DDAOHKAFOIC LNNGKIMHKAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x493B5E0", Offset = "0x4939DE0", VA = "0x18493B5E0", Slot = "26")]
	public object IEJOODGNMJN(DDAOHKAFOIC LNNGKIMHKAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x49391B0", Offset = "0x49379B0", VA = "0x1849391B0")]
	public bool HAHLGEBNGDK(DDAOHKAFOIC LNNGKIMHKAI, in object GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x493CE30", Offset = "0x493B630", VA = "0x18493CE30")]
	public void KEEHOGKCDPF(DDAOHKAFOIC LNNGKIMHKAI, in PEOLEOJFANL CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x49303B0", Offset = "0x492EBB0", VA = "0x1849303B0")]
	public bool DIMECELKFHA(DDAOHKAFOIC LNNGKIMHKAI, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4939DF0", Offset = "0x49385F0", VA = "0x184939DF0")]
	public bool HNBCALPENJO(DDAOHKAFOIC LNNGKIMHKAI, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3D65770", Offset = "0x3D63F70", VA = "0x183D65770", Slot = "21")]
	public void ENNFCPGKJEH(OOBCJOADNJP EDJDHHEMACF, [Optional] object IGBOEABBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4931FF0", Offset = "0x49307F0", VA = "0x184931FF0", Slot = "15")]
	public void ENNFCPGKJEH(DDAOHKAFOIC AGPLDPOAAIC, KLJAFMKEJHN EDJDHHEMACF, object IGBOEABBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x492E8A0", Offset = "0x492D0A0", VA = "0x18492E8A0", Slot = "14")]
	public bool AECOPHMDBCG(DDAOHKAFOIC JNLNIIGJOFO, DDAOHKAFOIC EADBNCPOLHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x31B9A20", Offset = "0x31B8220", VA = "0x1831B9A20", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4942BB0", Offset = "0x49413B0", VA = "0x184942BB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x49353A0", Offset = "0x4933BA0", VA = "0x1849353A0")]
	public string GCKBFFIBNHO(in IKKMGBAJNEB HJIKEFIKPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4941490", Offset = "0x493FC90", VA = "0x184941490")]
	private void MMAENMODJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x493F190", Offset = "0x493D990", VA = "0x18493F190")]
	private void KKMDIIPANCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4935690", Offset = "0x4933E90", VA = "0x184935690")]
	private void GLMAHECJCGI(Entity GDNDJKDEKFN, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x493BCE0", Offset = "0x493A4E0", VA = "0x18493BCE0")]
	private void IIDKMPOJCJL(Entity GDNDJKDEKFN, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4933A50", Offset = "0x4932250", VA = "0x184933A50")]
	[Conditional("DEBUG_BUILD")]
	private static void FANLFIKIPLG(Entity GDNDJKDEKFN, DDAOHKAFOIC LNNGKIMHKAI, string BAOKNJFCNMB, string IFJFEFCEPBI, [CallerMemberName] string OFKKNNHOFPP = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x34AC4C0", Offset = "0x34AACC0", VA = "0x1834AC4C0", Slot = "5")]
	private bool IPIOLNGGNDE(DDAOHKAFOIC AGPLDPOAAIC, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3B31740", Offset = "0x3B2FF40", VA = "0x183B31740", Slot = "6")]
	private bool EFIIAABECAO(DDAOHKAFOIC AGPLDPOAAIC, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8FB0", Offset = "0x2FC77B0", VA = "0x182FC8FB0", Slot = "23")]
	private string EDOHEDLJKPF(in IKKMGBAJNEB CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8F50", Offset = "0x2FC7750", VA = "0x182FC8F50", Slot = "10")]
	private bool BLMFODPLEOP(DDAOHKAFOIC AGPLDPOAAIC, in object GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2FC8E90", Offset = "0x2FC7690", VA = "0x182FC8E90", Slot = "11")]
	private void DOMFEGOCAIG(DDAOHKAFOIC AGPLDPOAAIC, in PEOLEOJFANL CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x41C4580", Offset = "0x41C2D80", VA = "0x1841C4580", Slot = "12")]
	private bool GPMGPLNJLFI(DDAOHKAFOIC AGPLDPOAAIC, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9510", Offset = "0x2FC7D10", VA = "0x182FC9510", Slot = "13")]
	private bool DIIFBMFJBLC(DDAOHKAFOIC AGPLDPOAAIC, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class FNDBOCNPCDA<T> : global::LIGDPEGLOMN<T>, global::NJDICNIFPMB<IOFHLMDPEAL, T>, global::BCFBMFIFGMA<IOFHLMDPEAL>, BDLFOPPLKDB, IDisposable, JODOCAEGKMF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::BCFBMFIFGMA<Entity> MIGODNJAHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly NCNJODMFFIF JHCECLNHNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate BJANLMFOEJC;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string AKFKAJPCNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4282130", Offset = "0x4280930", VA = "0x184282130", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type JIDICLJAOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4281CB0", Offset = "0x42804B0", VA = "0x184281CB0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ICGJPAAOHAG GCDLNKNDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x428A6C0", Offset = "0x4288EC0", VA = "0x18428A6C0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int FNIAHIHPNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x428AB20", Offset = "0x4289320", VA = "0x18428AB20", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public OGIFHIADLBO HCBHFPPKOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4280EB0", Offset = "0x427F6B0", VA = "0x184280EB0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3D77CB0", Offset = "0x3D764B0", VA = "0x183D77CB0", Slot = "23")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D63400", Offset = "0x3D61C00", VA = "0x183D63400", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::GBCMJJGIGAL<IOFHLMDPEAL> IHHEOJAELKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x42858F0", Offset = "0x42840F0", VA = "0x1842858F0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x4274C20", Offset = "0x4273420", VA = "0x184274C20", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3D7B4E0", Offset = "0x3D79CE0", VA = "0x183D7B4E0")]
	public FNDBOCNPCDA(global::BCFBMFIFGMA<Entity> MIGODNJAHNA, NCNJODMFFIF JHCECLNHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x213AB10", Offset = "0x2139310", VA = "0x18213AB10")]
	private Entity EKGOOABIHMK(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3D65430", Offset = "0x3D63C30", VA = "0x183D65430")]
	private IOFHLMDPEAL EKGOOABIHMK(Entity GDNDJKDEKFN)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4283740", Offset = "0x4281F40", VA = "0x184283740", Slot = "4")]
	public T KEEHOGKCDPF(IOFHLMDPEAL CPBDAEHELGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4275E70", Offset = "0x4274670", VA = "0x184275E70")]
	public bool DIMECELKFHA(IOFHLMDPEAL CPBDAEHELGD, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4280790", Offset = "0x427EF90", VA = "0x184280790")]
	public bool HNBCALPENJO(IOFHLMDPEAL CPBDAEHELGD, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4278B60", Offset = "0x4277360", VA = "0x184278B60", Slot = "9")]
	public bool FKKMCEBMOMF(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3D70360", Offset = "0x3D6EB60", VA = "0x183D70360", Slot = "25")]
	public object IEJOODGNMJN(IOFHLMDPEAL CPBDAEHELGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x427DCD0", Offset = "0x427C4D0", VA = "0x18427DCD0")]
	public bool HAHLGEBNGDK(IOFHLMDPEAL CPBDAEHELGD, in object GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x3D741D0", Offset = "0x3D729D0", VA = "0x183D741D0")]
	public void KEEHOGKCDPF(IOFHLMDPEAL CPBDAEHELGD, in PEOLEOJFANL CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x3D63960", Offset = "0x3D62160", VA = "0x183D63960")]
	public bool DIMECELKFHA(IOFHLMDPEAL CPBDAEHELGD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x3D6F520", Offset = "0x3D6DD20", VA = "0x183D6F520")]
	public bool HNBCALPENJO(IOFHLMDPEAL CPBDAEHELGD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3D65770", Offset = "0x3D63F70", VA = "0x183D65770", Slot = "21")]
	public void ENNFCPGKJEH(OOBCJOADNJP EDJDHHEMACF, [Optional] object IGBOEABBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4276EF0", Offset = "0x42756F0", VA = "0x184276EF0", Slot = "15")]
	public void ENNFCPGKJEH(IOFHLMDPEAL AGPLDPOAAIC, KLJAFMKEJHN EDJDHHEMACF, object IGBOEABBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3D625E0", Offset = "0x3D60DE0", VA = "0x183D625E0", Slot = "14")]
	public bool AECOPHMDBCG(IOFHLMDPEAL JNLNIIGJOFO, IOFHLMDPEAL EADBNCPOLHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4289C20", Offset = "0x4288420", VA = "0x184289C20")]
	private void MMAENMODJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4286350", Offset = "0x4284B50", VA = "0x184286350")]
	private void KKMDIIPANCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x427C190", Offset = "0x427A990", VA = "0x18427C190")]
	private void GLMAHECJCGI(Entity GDNDJKDEKFN, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4281350", Offset = "0x427FB50", VA = "0x184281350")]
	private void IIDKMPOJCJL(Entity GDNDJKDEKFN, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3D65400", Offset = "0x3D63C00", VA = "0x183D65400", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x428AD50", Offset = "0x4289550", VA = "0x18428AD50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3D632C0", Offset = "0x3D61AC0", VA = "0x183D632C0", Slot = "5")]
	private bool DGMNHEELBLK(IOFHLMDPEAL AGPLDPOAAIC, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3D6BB20", Offset = "0x3D6A320", VA = "0x183D6BB20", Slot = "6")]
	private bool GOJMGPHJBIN(IOFHLMDPEAL AGPLDPOAAIC, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3B800B0", Offset = "0x3B7E8B0", VA = "0x183B800B0", Slot = "10")]
	private bool ABAEJNBNLNE(IOFHLMDPEAL AGPLDPOAAIC, in object GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3D6DC60", Offset = "0x3D6C460", VA = "0x183D6DC60", Slot = "11")]
	private void HGHHEHIOMBO(IOFHLMDPEAL AGPLDPOAAIC, in PEOLEOJFANL CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3D70FD0", Offset = "0x3D6F7D0", VA = "0x183D70FD0", Slot = "12")]
	private bool JBBHIGPPOHE(IOFHLMDPEAL AGPLDPOAAIC, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3D7A5A0", Offset = "0x3D78DA0", VA = "0x183D7A5A0", Slot = "13")]
	private bool NLCFPMLFACJ(IOFHLMDPEAL AGPLDPOAAIC, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JHMAKDMCKJI : IDisposable, PIALCHFKIHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> PNALEACAIBD;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> ABABFBKNAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7325A0", Offset = "0x730DA0", VA = "0x1807325A0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1B17C50", Offset = "0x1B16450", VA = "0x181B17C50")]
	public JHMAKDMCKJI(NativeArray<EntityRemapUtility.EntityRemapInfo> PNALEACAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3A98C70", Offset = "0x3A97470", VA = "0x183A98C70", Slot = "6")]
	public IOFHLMDPEAL FHPNCPJBFFD(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3A98D60", Offset = "0x3A97560", VA = "0x183A98D60", Slot = "7")]
	public Entity FHPNCPJBFFD(Entity GDNDJKDEKFN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3A98CC0", Offset = "0x3A974C0", VA = "0x183A98CC0", Slot = "8")]
	public IEnumerable<IOFHLMDPEAL> FHPNCPJBFFD(IEnumerable<IOFHLMDPEAL> CIJFIAADMDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3A98C10", Offset = "0x3A97410", VA = "0x183A98C10", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Serialization, new string[] { "Remap" })]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string HGEPFNEBMOK = "Remap";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly JJLACLCEPON KOKMBCCAIPF;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static int GCKADLJALIE;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static PIALCHFKIHC JKEJIABAEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool CGPBJIIMPJH;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> ABABFBKNAEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x3852EB0", Offset = "0x38516B0", VA = "0x183852EB0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static bool MCIDMJPMKKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3853360", Offset = "0x3851B60", VA = "0x183853360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x38533F0", Offset = "0x3851BF0", VA = "0x1838533F0")]
		public static SerializationRemapScope KIFEBDENGNF()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x38534E0", Offset = "0x3851CE0", VA = "0x1838534E0")]
		public SerializationRemapScope(PIALCHFKIHC MBFGLGCOPIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x3852FC0", Offset = "0x38517C0", VA = "0x183852FC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x38530D0", Offset = "0x38518D0", VA = "0x1838530D0")]
		public static IOFHLMDPEAL FHPNCPJBFFD(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3853230", Offset = "0x3851A30", VA = "0x183853230")]
		public static Entity FHPNCPJBFFD(Entity GDNDJKDEKFN)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[OOAPDBLGMJF(typeof(HCGMPCJKLOI), new string[] { })]
public class BBNBOEKHHDB : HCGMPCJKLOI, PPOEDLGAMBE, AFNLLOENMMK, DNEGIKEIIMB, PGECBFIGDKK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NCNJODMFFIF JHCECLNHNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityHierarchyParents AGEKKIIOBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityHierarchyChildren HFOEOPEIJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private PKDIGKBPILP OBHAAPDAKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private ObjectEmbodimentService EGJPJHAOMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::LIGDPEGLOMN<IOFHLMDPEAL> AOJBGOEDBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x746CE0", Offset = "0x7454E0", VA = "0x180746CE0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x74A6B0", Offset = "0x748EB0", VA = "0x18074A6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA0BDC0", Offset = "0xA0A5C0", VA = "0x180A0BDC0", Slot = "13")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5FE0", Offset = "0x3AE47E0", VA = "0x183AE5FE0", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3AE54C0", Offset = "0x3AE3CC0", VA = "0x183AE54C0", Slot = "15")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5E70", Offset = "0x3AE4670", VA = "0x183AE5E70")]
	private IOFHLMDPEAL JDKLAIGHECL(Entity GDNDJKDEKFN)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5D40", Offset = "0x3AE4540", VA = "0x183AE5D40", Slot = "18")]
	public IOFHLMDPEAL IKKJIKAMHEN(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3AE59B0", Offset = "0x3AE41B0", VA = "0x183AE59B0", Slot = "19")]
	public void FKLMDHDNEKK(ref List<IOFHLMDPEAL> LCOODLIGMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5DA0", Offset = "0x3AE45A0", VA = "0x183AE5DA0", Slot = "20")]
	public IEnumerable<IOFHLMDPEAL> IPBOMGOIDCM(IOFHLMDPEAL CPBDAEHELGD, bool FBOPMPBBPKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x3AE60E0", Offset = "0x3AE48E0", VA = "0x183AE60E0", Slot = "21")]
	public IOFHLMDPEAL LHFLPHOIPHJ(IOFHLMDPEAL CPBDAEHELGD, int MMABPPDCBIB)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5900", Offset = "0x3AE4100", VA = "0x183AE5900", Slot = "22")]
	public int FDMNFBOCKJP(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5C40", Offset = "0x3AE4440", VA = "0x183AE5C40", Slot = "7")]
	public int IGNPFNMNMOD(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5F70", Offset = "0x3AE4770", VA = "0x183AE5F70", Slot = "8")]
	public HJHOBDHMCLM LBKMKEPICAJ(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3AE56B0", Offset = "0x3AE3EB0", VA = "0x183AE56B0", Slot = "23")]
	public IEnumerable<IOFHLMDPEAL> DNDIDHHEMJL(IOFHLMDPEAL CPBDAEHELGD, bool FBOPMPBBPKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5780", Offset = "0x3AE3F80", VA = "0x183AE5780", Slot = "11")]
	public IOFHLMDPEAL EGFDMBBCIHG(IOFHLMDPEAL IFLKAOGBEDH, IOFHLMDPEAL KNPAGIAAIJP)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5EA0", Offset = "0x3AE46A0", VA = "0x183AE5EA0", Slot = "12")]
	public bool KDGKGEDFGPG(IOFHLMDPEAL IFLKAOGBEDH, IOFHLMDPEAL KNPAGIAAIJP, out IOFHLMDPEAL FNFLMMJIIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5BA0", Offset = "0x3AE43A0", VA = "0x183AE5BA0", Slot = "4")]
	public IOFHLMDPEAL GECBLHBNBIF(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5650", Offset = "0x3AE3E50", VA = "0x183AE5650", Slot = "10")]
	public bool CMHAFNALMKK(IOFHLMDPEAL CPBDAEHELGD, IOFHLMDPEAL POADJDFNECJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5680", Offset = "0x3AE3E80", VA = "0x183AE5680", Slot = "24")]
	public bool DEEFPGIOMCP(IOFHLMDPEAL CPBDAEHELGD, IOFHLMDPEAL FOCEJAMAOBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x3AE55B0", Offset = "0x3AE3DB0", VA = "0x183AE55B0", Slot = "9")]
	public bool BCBFDHJANCI(IOFHLMDPEAL CPBDAEHELGD, IOFHLMDPEAL IFLKAOGBEDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5850", Offset = "0x3AE4050", VA = "0x183AE5850", Slot = "5")]
	public bool EPDJFMCJDGO(IOFHLMDPEAL CPBDAEHELGD, IOFHLMDPEAL OJKLIAPCMPJ, bool EMJIKBJAOKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x3AE55E0", Offset = "0x3AE3DE0", VA = "0x183AE55E0", Slot = "6")]
	public bool BNDMHFGOGFC(IOFHLMDPEAL CPBDAEHELGD, IOFHLMDPEAL OJKLIAPCMPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xFD3D70", Offset = "0xFD2570", VA = "0x180FD3D70", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BBNBOEKHHDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class PIEJAMPEPCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeList<GGKPENPPBHO> PKPKKAIFHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private NativeList<OJEIBILPNMC> HNINDKIFJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private NativeList<GGKPENPPBHO> MNDLNBADEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeList<GGKPENPPBHO> ILLJDCIHAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7325A0", Offset = "0x730DA0", VA = "0x1807325A0")]
		get
		{
			return default(NativeList<GGKPENPPBHO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeList<OJEIBILPNMC> GLPEEBAAOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x745CB0", Offset = "0x7444B0", VA = "0x180745CB0")]
		get
		{
			return default(NativeList<OJEIBILPNMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeList<GGKPENPPBHO> FKJNKBIBEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7325C0", Offset = "0x730DC0", VA = "0x1807325C0")]
		get
		{
			return default(NativeList<GGKPENPPBHO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NENJDBEJJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x3AB1AB0", Offset = "0x3AB02B0", VA = "0x183AB1AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1C80", Offset = "0x3AB0480", VA = "0x183AB1C80")]
	public PIEJAMPEPCM(Allocator EGJIMBMGFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1B40", Offset = "0x3AB0340", VA = "0x183AB1B40")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1BB0", Offset = "0x3AB03B0", VA = "0x183AB1BB0")]
	public void PDHGAAMLKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3AB18D0", Offset = "0x3AB00D0", VA = "0x183AB18D0")]
	public void CEMPCIEDPMO(Entity GDNDJKDEKFN, Entity CKCPHJMEEKP, Entity ILIAKNFOPLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[HCKNDCEEEAM(typeof(MHOGNFLCFLJ))]
[OOAPDBLGMJF(typeof(LHHEJKEEMLP), new string[] { })]
internal class LHHEJKEEMLP : DNEGIKEIIMB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly Dictionary<int, PIEJAMPEPCM> DJGFMPMEDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private PLPBBGKMDGB GBKDJPJOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MHOGNFLCFLJ IEBMFIFBGIK;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CAC0", Offset = "0x3A9B2C0", VA = "0x183A9CAC0", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CDD0", Offset = "0x3A9B5D0", VA = "0x183A9CDD0")]
	public PIEJAMPEPCM LNGDLHHNAKA(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CBA0", Offset = "0x3A9B3A0", VA = "0x183A9CBA0")]
	public PIEJAMPEPCM LNGDLHHNAKA(FHCGLCCCIJI LKIMNIMPHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CEB0", Offset = "0x3A9B6B0", VA = "0x183A9CEB0")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C860", Offset = "0x3A9B060", VA = "0x183A9C860", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D020", Offset = "0x3A9B820", VA = "0x183A9D020")]
	public LHHEJKEEMLP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DebuggerTypeProxy(typeof(GEPMLPPJOPE))]
	[HPLMCJEDJJG(KOEAPPNBOCD.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		internal class GEPMLPPJOPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private readonly ActionBuffer NCCOCLJLPFP;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public int CAAMIJFBOBJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000155")]
				[Cpp2IlInjected.Address(RVA = "0x3846480", Offset = "0x3844C80", VA = "0x183846480")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public JBDILOLFOCF[] HNAEPMCGJIE
			{
				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x38462C0", Offset = "0x3844AC0", VA = "0x1838462C0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x70E220", Offset = "0x70CA20", VA = "0x18070E220")]
			public GEPMLPPJOPE(ActionBuffer CNJJEFONDHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x3846390", Offset = "0x3844B90", VA = "0x183846390")]
			[CompilerGenerated]
			private JBDILOLFOCF DGGHKIKBAEN(KCDGFHGLMJA NCHNGIGODJK)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal class JBDILOLFOCF : OOBCJOADNJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private readonly ActionBuffer NCCOCLJLPFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private readonly KCDGFHGLMJA NCHNGIGODJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private List<(OCPNCAHNNFG, string, object)> JKAKLGDNGFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private OMMNMAIFOHO CLOGDHPGNHC;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public int CAAMIJFBOBJ
			{
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0x3846F80", Offset = "0x3845780", VA = "0x183846F80")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public List<(OCPNCAHNNFG, string, object)> CHBGDIOAKKM
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x3847310", Offset = "0x3845B10", VA = "0x183847310")]
			public JBDILOLFOCF(ActionBuffer CNJJEFONDHG, KCDGFHGLMJA NCHNGIGODJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3846E80", Offset = "0x3845680", VA = "0x183846E80")]
			private string EKJLAAEHEOA(OCPNCAHNNFG NMDPGMLBILI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3846FD0", Offset = "0x38457D0", VA = "0x183846FD0")]
			private void MADPLDOCFBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x3DA66B0", Offset = "0x3DA4EB0", VA = "0x183DA66B0", Slot = "4")]
			public void CPNDBBPBHFN<TKey, T>(global::NJDICNIFPMB<TKey, T> MIGODNJAHNA, [Optional] object IGBOEABBEHO) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private NativeList<byte> DPDIKACMHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Stack<KCDGFHGLMJA> JAIMFLNBBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly OGFHFMEKKFB KNJIDDHGNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly CHCKBAIGEAG LMCKKENKDOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly FMFHLBFGHJI IEBMFIFBGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly bool BCMKBJPEIAM;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public NPFADAJLONC IKECDOHOPGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x3AE3EB0", Offset = "0x3AE26B0", VA = "0x183AE3EB0")]
			get
			{
				return default(NPFADAJLONC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int CAAMIJFBOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x3AE3990", Offset = "0x3AE2190", VA = "0x183AE3990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4230", Offset = "0x3AE2A30", VA = "0x183AE4230")]
		public ActionBuffer(CHCKBAIGEAG LMCKKENKDOK, FMFHLBFGHJI IEBMFIFBGIK, bool BCMKBJPEIAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3E20", Offset = "0x3AE2620", VA = "0x183AE3E20")]
		public bool LEHJOKFBFDK(out KCDGFHGLMJA NCHNGIGODJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4170", Offset = "0x3AE2970", VA = "0x183AE4170")]
		public void OJEEPLKEKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4030", Offset = "0x3AE2830", VA = "0x183AE4030")]
		public KCDGFHGLMJA MMFGOGFMNKL(IEBCBAINFFE JKAKLGDNGFP, JJENBGOMCNI BCDLAFDPGCJ, uint BJAGEHHPBBC)
		{
			return default(KCDGFHGLMJA);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3CE0", Offset = "0x3AE24E0", VA = "0x183AE3CE0")]
		public bool IFFLFCDOAJD(uint BJAGEHHPBBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3AE35C0", Offset = "0x3AE1DC0", VA = "0x183AE35C0")]
		public bool CMOIEGDOBKP(uint BJAGEHHPBBC, out KCDGFHGLMJA MJPNNJLLLLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3820", Offset = "0x3AE2020", VA = "0x183AE3820")]
		public void EGGMJMNGFDA(KCDGFHGLMJA MJPNNJLLLLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3EF0", Offset = "0x3AE26F0", VA = "0x183AE3EF0")]
		[Conditional("DEBUG_BUILD")]
		private void MJFDPIMDAFJ(KCDGFHGLMJA MJPNNJLLLLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3D10", Offset = "0x3AE2510", VA = "0x183AE3D10")]
		private void KCGLNFJFBOB(KCDGFHGLMJA FMIPOENOOKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE39D0", Offset = "0x3AE21D0", VA = "0x183AE39D0")]
		private void FLBALAEEFFA(OMMNMAIFOHO DAPDMAPOPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3560", Offset = "0x3AE1D60", VA = "0x183AE3560")]
		private void CMOBDLHMPDD(KCDGFHGLMJA NCHNGIGODJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3AE3C20", Offset = "0x3AE2420", VA = "0x183AE3C20")]
		private OMMNMAIFOHO IBJHEFFHFOO(KCDGFHGLMJA NCHNGIGODJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3AE37B0", Offset = "0x3AE1FB0", VA = "0x183AE37B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class OGFHFMEKKFB : OOBCJOADNJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly CHCKBAIGEAG LMCKKENKDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly FMFHLBFGHJI IEBMFIFBGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private DDAOHKAFOIC PFLOECMCNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private OMMNMAIFOHO GMOJFHCEMHP;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x72D3D0", Offset = "0x72BBD0", VA = "0x18072D3D0")]
	public OGFHFMEKKFB(CHCKBAIGEAG LMCKKENKDOK, FMFHLBFGHJI IEBMFIFBGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x395D300", Offset = "0x395BB00", VA = "0x18395D300", Slot = "4")]
	public void CPNDBBPBHFN<TKey, T>(global::NJDICNIFPMB<TKey, T> ENNHENNPOKM, [Optional] object IGBOEABBEHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4DF0", Offset = "0x3AA35F0", VA = "0x183AA4DF0")]
	public void ENNFCPGKJEH(OCPNCAHNNFG NMDPGMLBILI, ref OMMNMAIFOHO DAPDMAPOPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HIKCKCKAEBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct HPAHHEKPGIP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly HIKCKCKAEBF OJKLIAPCMPJ;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x51CD910", Offset = "0x51CC110", VA = "0x1851CD910")]
		public HPAHHEKPGIP(HIKCKCKAEBF OJKLIAPCMPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x51CD8F0", Offset = "0x51CC0F0", VA = "0x1851CD8F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected IEBCBAINFFE JKAKLGDNGFP;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public IEBCBAINFFE CHBGDIOAKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3A940D0", Offset = "0x3A928D0", VA = "0x183A940D0")]
		get
		{
			return default(IEBCBAINFFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool IAHCGBJIDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3A93DB0", Offset = "0x3A925B0", VA = "0x183A93DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3A94200", Offset = "0x3A92A00", VA = "0x183A94200")]
	public HIKCKCKAEBF(IEBCBAINFFE.KKBKGGEDACK ACEIPIDELDE = IEBCBAINFFE.KKBKGGEDACK.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3A94110", Offset = "0x3A92910", VA = "0x183A94110")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3A93F20", Offset = "0x3A92720", VA = "0x183A93F20")]
	public void KELGJPAMBIF(DDAOHKAFOIC PFLOECMCNHK, BBAJGMCCMCB IBHOKKEKMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3A93EC0", Offset = "0x3A926C0", VA = "0x183A93EC0")]
	public void IPLKCJIBGHO(DDAOHKAFOIC PFLOECMCNHK, FHCGLCCCIJI LKIMNIMPHKB, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3A93DD0", Offset = "0x3A925D0", VA = "0x183A93DD0")]
	public void FHEIEPOBCFB(DDAOHKAFOIC PFLOECMCNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x3A94120", Offset = "0x3A92920", VA = "0x183A94120")]
	public void PNODODGFGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x3A93FF0", Offset = "0x3A927F0", VA = "0x183A93FF0")]
	public void LNLDLKLBOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x3A93DC0", Offset = "0x3A925C0", VA = "0x183A93DC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x3A93E90", Offset = "0x3A92690", VA = "0x183A93E90")]
	public HPAHHEKPGIP FOEEADKNKOH()
	{
		return default(HPAHHEKPGIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct OCPNCAHNNFG : IComparable<OCPNCAHNNFG>, IEquatable<OCPNCAHNNFG>
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly OCPNCAHNNFG JNJAOIIOAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public DDAOHKAFOIC PFLOECMCNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public FHCGLCCCIJI LKIMNIMPHKB;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3AA4CD0", Offset = "0x3AA34D0", VA = "0x183AA4CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7E5420", Offset = "0x7E3C20", VA = "0x1807E5420")]
	public OCPNCAHNNFG(DDAOHKAFOIC PFLOECMCNHK, FHCGLCCCIJI LKIMNIMPHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4B90", Offset = "0x3AA3390", VA = "0x183AA4B90")]
	public void DCGAGGEDHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4B50", Offset = "0x3AA3350", VA = "0x183AA4B50", Slot = "4")]
	public int CompareTo(OCPNCAHNNFG IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4D30", Offset = "0x3AA3530", VA = "0x183AA4D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4BF0", Offset = "0x3AA33F0", VA = "0x183AA4BF0", Slot = "0")]
	public override bool Equals(object ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4BA0", Offset = "0x3AA33A0", VA = "0x183AA4BA0", Slot = "5")]
	public bool Equals(OCPNCAHNNFG IIKMMJKCGDO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4B10", Offset = "0x3AA3310", VA = "0x183AA4B10")]
	public static bool CGFEPDNGNBJ(OCPNCAHNNFG FEBCAKEBBCL, OCPNCAHNNFG EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4CE0", Offset = "0x3AA34E0", VA = "0x183AA4CE0")]
	public static bool NODBGCCFDAJ(OCPNCAHNNFG FEBCAKEBBCL, OCPNCAHNNFG EEACLMBPLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4C90", Offset = "0x3AA3490", VA = "0x183AA4C90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HEICHNECIDK : KLJAFMKEJHN
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly JJLACLCEPON MNIOACBCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private CHCKBAIGEAG LMCKKENKDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private DDAOHKAFOIC PFLOECMCNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private ECJNNBLJLBI FLMDCNMMHMK;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3B00340", Offset = "0x3AFEB40", VA = "0x183B00340")]
	public void NHHLDECCNLN(DDAOHKAFOIC PFLOECMCNHK, CHCKBAIGEAG LMCKKENKDOK, ECJNNBLJLBI FLMDCNMMHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3B001F0", Offset = "0x3AFE9F0", VA = "0x183B001F0", Slot = "4")]
	private void IMKOBKNKDBP(BDLFOPPLKDB MIGODNJAHNA, in IKKMGBAJNEB CCIMHDCKHOF, object IGBOEABBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public HEICHNECIDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class MOBHAINPGNJ
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA21A0", Offset = "0x3AA09A0", VA = "0x183AA21A0")]
	public static void IBLFBEBKBGC(IEBCBAINFFE JKAKLGDNGFP, OCPNCAHNNFG NMDPGMLBILI, BBAJGMCCMCB IBHOKKEKMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2340", Offset = "0x3AA0B40", VA = "0x183AA2340")]
	public static void KGBPFEMGELK(IEBCBAINFFE JKAKLGDNGFP, OCPNCAHNNFG NMDPGMLBILI, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA25B0", Offset = "0x3AA0DB0", VA = "0x183AA25B0")]
	public static void PKADDDKGOBE(IEBCBAINFFE JKAKLGDNGFP, OCPNCAHNNFG NMDPGMLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2480", Offset = "0x3AA0C80", VA = "0x183AA2480")]
	public static void LLGOAILEGBN(IEBCBAINFFE JKAKLGDNGFP, OCPNCAHNNFG NMDPGMLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2150", Offset = "0x3AA0950", VA = "0x183AA2150")]
	public static BBAJGMCCMCB GBLIELGMMDM(IEBCBAINFFE JKAKLGDNGFP, OCPNCAHNNFG NMDPGMLBILI)
	{
		return default(BBAJGMCCMCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E0E0", Offset = "0x3A4C8E0", VA = "0x183A4E0E0")]
	public static T FCJGIAGAOBH<T>(IEBCBAINFFE JKAKLGDNGFP, OCPNCAHNNFG NMDPGMLBILI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3A4E0B0", Offset = "0x3A4C8B0", VA = "0x183A4E0B0")]
	public static T FCJGIAGAOBH<T>(ref OMMNMAIFOHO PJDKPCLOECB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2100", Offset = "0x3AA0900", VA = "0x183AA2100")]
	public static BBAJGMCCMCB GBLIELGMMDM(ref OMMNMAIFOHO PJDKPCLOECB)
	{
		return default(BBAJGMCCMCB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[GHGEDCIEICE(typeof(KGMAJJBPDAG))]
[OOAPDBLGMJF(typeof(ECJNNBLJLBI), new string[] { })]
public class ECJNNBLJLBI : DNEGIKEIIMB, IDisposable, KGMAJJBPDAG
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum JFPAKKMEHPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Undoing,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Redoing
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct EEFNHIADCIP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly JFPAKKMEHPI EGJHOONMKNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly ECJNNBLJLBI GJMHFONGMCN;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3845F70", Offset = "0x3844770", VA = "0x183845F70")]
		public EEFNHIADCIP(ECJNNBLJLBI GJMHFONGMCN, bool AKGLPDOPBCJ, uint LDFDMKAILBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3845F40", Offset = "0x3844740", VA = "0x183845F40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class HEONBIGBGIN
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public struct IBFJFPEGIEB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private readonly HEONBIGBGIN KBGJCMKGEHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private readonly bool BLICDINACCG;

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x51CD970", Offset = "0x51CC170", VA = "0x1851CD970")]
			public IBFJFPEGIEB(HEONBIGBGIN KBGJCMKGEHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x51CD940", Offset = "0x51CC140", VA = "0x1851CD940", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public struct JGGBPFPLONA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private readonly HEONBIGBGIN KBGJCMKGEHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly bool BLICDINACCG;

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x51CE8D0", Offset = "0x51CD0D0", VA = "0x1851CE8D0")]
			public JGGBPFPLONA(HEONBIGBGIN KBGJCMKGEHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x51CD940", Offset = "0x51CC140", VA = "0x1851CD940", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly ECJNNBLJLBI FLMDCNMMHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private bool MIBACINGOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int MNBNCJDHOBN;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3846640", Offset = "0x3844E40", VA = "0x183846640")]
		public HEONBIGBGIN(ECJNNBLJLBI FLMDCNMMHMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3846610", Offset = "0x3844E10", VA = "0x183846610")]
		public bool LCEKOBGNEAC(DDAOHKAFOIC PFLOECMCNHK, FHCGLCCCIJI LKIMNIMPHKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x38465F0", Offset = "0x3844DF0", VA = "0x1838465F0")]
		public JGGBPFPLONA KCLPJEAFCJL()
		{
			return default(JGGBPFPLONA);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x38465D0", Offset = "0x3844DD0", VA = "0x1838465D0")]
		public IBFJFPEGIEB JHCHKJPBDPL()
		{
			return default(IBFJFPEGIEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class FPEHKHEHEDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public ECJNNBLJLBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public UndoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public FPEHKHEHEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3846260", Offset = "0x3844A60", VA = "0x183846260")]
		internal RedoAction <Undo>b__0()
		{
			return default(RedoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class KJJHBHPBOKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public ECJNNBLJLBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public RedoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public KJJHBHPBOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3847580", Offset = "0x3845D80", VA = "0x183847580")]
		internal UndoAction <Redo>b__0()
		{
			return default(UndoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class DEDEGNLNGKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public DEDEGNLNGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3845940", Offset = "0x3844140", VA = "0x183845940")]
		internal bool <SyncProperties>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly JJLACLCEPON MNIOACBCBNF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly UndoAction BPPDFPOCBFK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly RedoAction CKGEFKMCMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private HIKCKCKAEBF KJEMAPDCACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private ActionBuffer BCFIILEPOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private ActionBuffer LBGFCGDPNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private PLPBBGKMDGB GBKDJPJOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private ONONPBBGLCA PNKGKGECIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private TransformOwnershipPhase KFAADBMJGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private JJENBGOMCNI BCDLAFDPGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private JFPAKKMEHPI CKGMMEEKNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private uint FLIMOCGJLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private uint GCAHABHHGIH;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private HEONBIGBGIN BFIPCNIKIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8323D0", Offset = "0x830BD0", VA = "0x1808323D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool JOMHNPIFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3430", Offset = "0x3AF1C30", VA = "0x183AF3430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool IFPGPJKDJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF39E0", Offset = "0x3AF21E0", VA = "0x183AF39E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool ICLODOGBLPH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3AF30B0", Offset = "0x3AF18B0", VA = "0x183AF30B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int FKALGHBAIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2E80", Offset = "0x3AF1680", VA = "0x183AF2E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int FAFPOPAFBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4AC0", Offset = "0x3AF32C0", VA = "0x183AF4AC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private bool NNCCLEEJEII
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4B10", Offset = "0x3AF3310", VA = "0x183AF4B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private bool NMHOFMPILJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3AF30A0", Offset = "0x3AF18A0", VA = "0x183AF30A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool MCFNDHNDEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xB59CE0", Offset = "0xB584E0", VA = "0x180B59CE0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xB59D20", Offset = "0xB58520", VA = "0x180B59D20", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private ActionBuffer BHJFJINBGHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4B20", Offset = "0x3AF3320", VA = "0x183AF4B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action OGMIDDDGAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3AF43A0", Offset = "0x3AF2BA0", VA = "0x183AF43A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4440", Offset = "0x3AF2C40", VA = "0x183AF4440", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action BACNJELGBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3AF3940", Offset = "0x3AF2140", VA = "0x183AF3940")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4780", Offset = "0x3AF2F80", VA = "0x183AF4780")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4F00", Offset = "0x3AF3700", VA = "0x183AF4F00")]
	public ECJNNBLJLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3AF44E0", Offset = "0x3AF2CE0", VA = "0x183AF44E0", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3530", Offset = "0x3AF1D30", VA = "0x183AF3530", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3AF33B0", Offset = "0x3AF1BB0", VA = "0x183AF33B0", Slot = "14")]
	public IDisposable CHPCLLPDICF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3AF36C0", Offset = "0x3AF1EC0", VA = "0x183AF36C0", Slot = "9")]
	public IDisposable EEPJJBICCHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4820", Offset = "0x3AF3020", VA = "0x183AF4820", Slot = "6")]
	public UndoAction MMFGOGFMNKL()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4A00", Offset = "0x3AF3200", VA = "0x183AF4A00", Slot = "15")]
	public RedoAction MODOBNPEOEI()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4B30", Offset = "0x3AF3330", VA = "0x183AF4B30", Slot = "16")]
	public UndoAction OANLJOGAMBI()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF48E0", Offset = "0x3AF30E0", VA = "0x183AF48E0", Slot = "7")]
	public RedoAction MODOBNPEOEI(UndoAction MJPNNJLLLLB)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4BF0", Offset = "0x3AF33F0", VA = "0x183AF4BF0", Slot = "8")]
	public UndoAction OANLJOGAMBI(RedoAction MJPNNJLLLLB)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF34F0", Offset = "0x3AF1CF0", VA = "0x183AF34F0")]
	public bool DFMBKPOPGDO(JICEPMCGADA KNJKIMOINAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4D10", Offset = "0x3AF3510", VA = "0x183AF4D10", Slot = "17")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3AF42E0", Offset = "0x3AF2AE0", VA = "0x183AF42E0")]
	public void KELGJPAMBIF(DDAOHKAFOIC PFLOECMCNHK, BBAJGMCCMCB IBHOKKEKMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3C70", Offset = "0x3AF2470", VA = "0x183AF3C70")]
	public void IPLKCJIBGHO(DDAOHKAFOIC PFLOECMCNHK, FHCGLCCCIJI LKIMNIMPHKB, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3890", Offset = "0x3AF2090", VA = "0x183AF3890")]
	public void FHEIEPOBCFB(DDAOHKAFOIC PFLOECMCNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3B80", Offset = "0x3AF2380", VA = "0x183AF3B80")]
	private void GKKCGLAHPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4DF0", Offset = "0x3AF35F0", VA = "0x183AF4DF0")]
	private void OMJHHHABIDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3C00", Offset = "0x3AF2400", VA = "0x183AF3C00")]
	private void IBIBPICNCJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3190", Offset = "0x3AF1990", VA = "0x183AF3190")]
	private KCDGFHGLMJA CCDLCOJHFOC()
	{
		return default(KCDGFHGLMJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3BC0", Offset = "0x3AF23C0", VA = "0x183AF3BC0")]
	private uint GMMOMIKMHBG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3410", Offset = "0x3AF1C10", VA = "0x183AF3410")]
	private bool CNAHPPLBCOF(out KCDGFHGLMJA NCHNGIGODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3BE0", Offset = "0x3AF23E0", VA = "0x183AF3BE0")]
	private bool HEIJAEINDOK(out KCDGFHGLMJA NCHNGIGODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3490", Offset = "0x3AF1C90", VA = "0x183AF3490")]
	private RedoAction DECGMMGGAGL(KCDGFHGLMJA NCHNGIGODJK)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3130", Offset = "0x3AF1930", VA = "0x183AF3130")]
	private UndoAction BOLBJHBFMCI(KCDGFHGLMJA NCHNGIGODJK)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3EF0", Offset = "0x3AF26F0", VA = "0x183AF3EF0")]
	private KCDGFHGLMJA KCGLNFJFBOB(KCDGFHGLMJA NCHNGIGODJK, ActionBuffer JIDMMEPEFPN, bool AKGLPDOPBCJ)
	{
		return default(KCDGFHGLMJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3AA0", Offset = "0x3AF22A0", VA = "0x183AF3AA0")]
	private void GEKLENIMHLL(Action NCHNGIGODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x37EB680", Offset = "0x37E9E80", VA = "0x1837EB680")]
	private T GEKLENIMHLL<T>(Func<T> HKNPNGGIBCL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3100", Offset = "0x3AF1900", VA = "0x183AF3100")]
	private EEFNHIADCIP ALEMOILNAJD(bool AKGLPDOPBCJ, uint LDFDMKAILBI)
	{
		return default(EEFNHIADCIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3D40", Offset = "0x3AF2540", VA = "0x183AF3D40")]
	[CompilerGenerated]
	private UndoAction JCOKADDEJLK()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3720", Offset = "0x3AF1F20", VA = "0x183AF3720")]
	[CompilerGenerated]
	private RedoAction ENONCNHFKDL()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2F40", Offset = "0x3AF1740", VA = "0x183AF2F40")]
	[CompilerGenerated]
	private UndoAction AEBGGAONJKE()
	{
		return default(UndoAction);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct IEBCBAINFFE : IEnumerable<OCPNCAHNNFG>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum KKBKGGEDACK
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private struct ODEFHLAIDOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly IEBCBAINFFE PIJDNOPJENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly JJENBGOMCNI BCDLAFDPGCJ;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x51D1CD0", Offset = "0x51D04D0", VA = "0x1851D1CD0")]
		public ODEFHLAIDOK(IEBCBAINFFE PIJDNOPJENO, JJENBGOMCNI BCDLAFDPGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x51D1630", Offset = "0x51CFE30", VA = "0x1851D1630")]
		public void CKMGPDILFJL(NativeList<byte> JMJPBBLODJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x51D19C0", Offset = "0x51D01C0", VA = "0x1851D19C0")]
		private void EHEMOEAAMGF(OCPNCAHNNFG NMDPGMLBILI, ref FCADEMDJDOO JFCGPBDBIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x51D1C40", Offset = "0x51D0440", VA = "0x1851D1C40")]
		private void JPOOCKFJPLA(OCPNCAHNNFG NMDPGMLBILI, ref FCADEMDJDOO JFCGPBDBIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x51D18D0", Offset = "0x51D00D0", VA = "0x1851D18D0")]
		private NativeArray<byte> EEONGJNAJNJ(NativeList<byte> JMJPBBLODJI)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x51D13E0", Offset = "0x51CFBE0", VA = "0x1851D13E0")]
		private NativeArray<byte> BIGKGKCODEB(NativeList<byte> JMJPBBLODJI, int HOPGLJCPGGA)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x51D1A10", Offset = "0x51D0210", VA = "0x1851D1A10")]
		private int JKPDNBPIHND()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x51D14D0", Offset = "0x51CFCD0", VA = "0x1851D14D0")]
		private bool CFNLNEALKIJ(OCPNCAHNNFG NMDPGMLBILI, out NativeArray<byte> HKNAGLDNKCL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct NNDLPPAFFCO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NativeList<byte> PJDKPCLOECB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private IEBCBAINFFE PIJDNOPJENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly OCPNCAHNNFG LENKHFNFMLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly int OMKHMNIPPGH;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x51D0C70", Offset = "0x51CF470", VA = "0x1851D0C70")]
		internal NNDLPPAFFCO(IEBCBAINFFE PIJDNOPJENO, OCPNCAHNNFG LENKHFNFMLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x51D0C30", Offset = "0x51CF430", VA = "0x1851D0C30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x51D0B00", Offset = "0x51CF300", VA = "0x1851D0B00")]
		public void GMLFHNCHNPM(NativeArray<byte> CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x51D0BD0", Offset = "0x51CF3D0", VA = "0x1851D0BD0")]
		public void CEFFJCEHBMK(NativeArray<byte> CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x51D0C60", Offset = "0x51CF460", VA = "0x1851D0C60")]
		public void JPOOCKFJPLA(in IKKMGBAJNEB CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3D3DB00", Offset = "0x3D3C300", VA = "0x183D3DB00")]
		public void JPOOCKFJPLA<T>(T CCIMHDCKHOF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x51D0B60", Offset = "0x51CF360", VA = "0x1851D0B60")]
		private void BILIIEJMLJP(int CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x51D09F0", Offset = "0x51CF1F0", VA = "0x1851D09F0")]
		private void BILIIEJMLJP(in IKKMGBAJNEB CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x51D0AA0", Offset = "0x51CF2A0", VA = "0x1851D0AA0")]
		private unsafe void BILIIEJMLJP(void* ALKFOKGKFIJ, int HOPGLJCPGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x51D0B00", Offset = "0x51CF300", VA = "0x1851D0B00")]
		private void BILIIEJMLJP(NativeArray<byte> EADBNCPOLHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct CLPACMLOEFA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private IEBCBAINFFE PIJDNOPJENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NativeArray<byte> PJDKPCLOECB;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x51CB7E0", Offset = "0x51C9FE0", VA = "0x1851CB7E0")]
		internal CLPACMLOEFA(IEBCBAINFFE PIJDNOPJENO, NativeArray<byte> PJDKPCLOECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x51CB5E0", Offset = "0x51C9DE0", VA = "0x1851CB5E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x51CB520", Offset = "0x51C9D20", VA = "0x1851CB520")]
		public NativeArray<byte> DMOMLNDJJKD(int HOPGLJCPGGA)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x51CB6F0", Offset = "0x51C9EF0", VA = "0x1851CB6F0")]
		public NativeArray<byte> PDHHELFFDJF()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F0E0", Offset = "0x3D2D8E0", VA = "0x183D2F0E0")]
		public T OALNAJCMKCK<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x51CB5F0", Offset = "0x51C9DF0", VA = "0x1851CB5F0")]
		public void OALNAJCMKCK(in PEOLEOJFANL CCIMHDCKHOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct PAIHOKFNADC : IEnumerator<OCPNCAHNNFG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly NativeArray<OCPNCAHNNFG> KPAFOBEJBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int MMABPPDCBIB;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public OCPNCAHNNFG IKECDOHOPGM
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x51D1F20", Offset = "0x51D0720", VA = "0x1851D1F20", Slot = "4")]
			get
			{
				return default(OCPNCAHNNFG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x51D1EE0", Offset = "0x51D06E0", VA = "0x1851D1EE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3C0FD10", Offset = "0x3C0E510", VA = "0x183C0FD10")]
		internal PAIHOKFNADC(NativeArray<OCPNCAHNNFG> EADBNCPOLHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x51D1E30", Offset = "0x51D0630", VA = "0x1851D1E30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x51D1EA0", Offset = "0x51D06A0", VA = "0x1851D1EA0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private struct MOMOEFENAJI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private const int PAHHCKIPHDA = 0;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private const int HFIKPKAEOOM = 1;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const int GALBBKOFKCH = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private NativeArray<int> PJDKPCLOECB;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public int CHEGJAFNAPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x51D0100", Offset = "0x51CE900", VA = "0x1851D0100")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x51D00B0", Offset = "0x51CE8B0", VA = "0x1851D00B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public KKBKGGEDACK PHOABLFAEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x51D0110", Offset = "0x51CE910", VA = "0x1851D0110")]
			get
			{
				return default(KKBKGGEDACK);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x51D00C0", Offset = "0x51CE8C0", VA = "0x1851D00C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool IAHCGBJIDBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x51CFFD0", Offset = "0x51CE7D0", VA = "0x1851CFFD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x51D0070", Offset = "0x51CE870", VA = "0x1851D0070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool BAMIGCDOJPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x51D0060", Offset = "0x51CE860", VA = "0x1851D0060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x51D0090", Offset = "0x51CE890", VA = "0x1851D0090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x51D0120", Offset = "0x51CE920", VA = "0x1851D0120")]
		public MOMOEFENAJI(KKBKGGEDACK ACEIPIDELDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x51D00D0", Offset = "0x51CE8D0", VA = "0x1851D00D0")]
		private int KEEHOGKCDPF(int EGBIMJLECFF, int EDJOGEJKLPG = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x51CFFE0", Offset = "0x51CE7E0", VA = "0x1851CFFE0")]
		private void DIMECELKFHA(int EGBIMJLECFF, int CCIMHDCKHOF, int EDJOGEJKLPG = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x51D0020", Offset = "0x51CE820", VA = "0x1851D0020", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private const int CBFKANFKLFH = -1;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int BHPHPEAKJOD = 0;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly OCPNCAHNNFG OGJFGGLCIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private NativeHashMap<OCPNCAHNNFG, int> CLOHODLPMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private NativeList<OCPNCAHNNFG> JKAKLGDNGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private NativeList<int> OJHFIIFAFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private NativeList<byte> MOFAGNBFHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NativeList<byte> PJDKPCLOECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private MOMOEFENAJI EPEIMBEMAJE;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool IAHCGBJIDBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A96AC0", Offset = "0x3A952C0", VA = "0x183A96AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool NENJDBEJJHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A97410", Offset = "0x3A95C10", VA = "0x183A97410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int CHEGJAFNAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A97400", Offset = "0x3A95C00", VA = "0x183A97400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int EHJGMEIMDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A97140", Offset = "0x3A95940", VA = "0x183A97140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3A97430", Offset = "0x3A95C30", VA = "0x183A97430")]
	public static IEBCBAINFFE MFNJFAEBAIM(KKBKGGEDACK ACEIPIDELDE = KKBKGGEDACK.Last, int KPMEJBNJFHL = 16, int PIAHBHHLCJI = 256)
	{
		return default(IEBCBAINFFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3A977A0", Offset = "0x3A95FA0", VA = "0x183A977A0")]
	private IEBCBAINFFE(KKBKGGEDACK ACEIPIDELDE, int KPMEJBNJFHL, int PIAHBHHLCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3A96F20", Offset = "0x3A95720", VA = "0x183A96F20", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A97470", Offset = "0x3A95C70", VA = "0x183A97470")]
	public NNDLPPAFFCO NEKOKLMLGBA(OCPNCAHNNFG LENKHFNFMLN)
	{
		return default(NNDLPPAFFCO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A97370", Offset = "0x3A95B70", VA = "0x183A97370")]
	public CLPACMLOEFA LMDMGILHDLO(OCPNCAHNNFG LENKHFNFMLN)
	{
		return default(CLPACMLOEFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A96C40", Offset = "0x3A95440", VA = "0x183A96C40")]
	public bool DAAPNLNAEMC(OCPNCAHNNFG LENKHFNFMLN, out CLPACMLOEFA GGEIAOMMHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A970F0", Offset = "0x3A958F0", VA = "0x183A970F0")]
	public bool IELELMEGGBG(OCPNCAHNNFG LENKHFNFMLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3A97500", Offset = "0x3A95D00", VA = "0x183A97500")]
	public bool NLAKLIJIPGA(OCPNCAHNNFG LENKHFNFMLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A96B50", Offset = "0x3A95350", VA = "0x183A96B50")]
	public void COGOKMCGGNA(NativeList<byte> JMJPBBLODJI, JJENBGOMCNI BCDLAFDPGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2EB08C0", Offset = "0x2EAF0C0", VA = "0x182EB08C0")]
	public T HGMFBEDJIMN<T>(OCPNCAHNNFG LENKHFNFMLN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A975D0", Offset = "0x3A95DD0", VA = "0x183A975D0")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3A96AD0", Offset = "0x3A952D0", VA = "0x183A96AD0")]
	public PAIHOKFNADC CDEDLLPMOKO()
	{
		return default(PAIHOKFNADC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A97180", Offset = "0x3A95980", VA = "0x183A97180")]
	private void JOGOLPIJHJF(OCPNCAHNNFG LENKHFNFMLN, int OMKHMNIPPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3A96E30", Offset = "0x3A95630", VA = "0x183A96E30")]
	private void DCGAGGEDHOB(int GNFLMICMPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3A97000", Offset = "0x3A95800", VA = "0x183A97000")]
	private void HLCIFLAPLCP(OCPNCAHNNFG LENKHFNFMLN, int OMKHMNIPPGH, int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2EB0840", Offset = "0x2EAF040", VA = "0x182EB0840")]
	private static T HGMFBEDJIMN<T>(NativeArray<byte> KPAFOBEJBIN, int EGBIMJLECFF = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3A976E0", Offset = "0x3A95EE0", VA = "0x183A976E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3A976A0", Offset = "0x3A95EA0", VA = "0x183A976A0", Slot = "4")]
	private IEnumerator<OCPNCAHNNFG> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class IFOCMHFKMGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private NativeArray<byte> KPAFOBEJBIN;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int FFGDBGPFOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x671690", Offset = "0x66FE90", VA = "0x180671690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x1B17C50", Offset = "0x1B16450", VA = "0x181B17C50")]
	public IFOCMHFKMGM(NativeArray<byte> KPAFOBEJBIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3A97910", Offset = "0x3A96110", VA = "0x183A97910")]
	public static IFOCMHFKMGM EDIIAGKPKGG(NativeArray<byte> KPAFOBEJBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	public T OALNAJCMKCK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	public NativeArray<T> DMOMLNDJJKD<T>(int HOPGLJCPGGA, Allocator EGJIMBMGFGA) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	public NativeArray<T> PDHHELFFDJF<T>(Allocator EGJIMBMGFGA) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class OMMNMAIFOHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private NativeArray<byte> KPAFOBEJBIN;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int FFGDBGPFOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x671690", Offset = "0x66FE90", VA = "0x180671690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x1B17C50", Offset = "0x1B16450", VA = "0x181B17C50")]
	public OMMNMAIFOHO(NativeArray<byte> KPAFOBEJBIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8050", Offset = "0x3AA6850", VA = "0x183AA8050")]
	public static OMMNMAIFOHO EDIIAGKPKGG(NativeArray<byte> KPAFOBEJBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x39658A0", Offset = "0x39640A0", VA = "0x1839658A0")]
	public T OALNAJCMKCK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	public NativeArray<T> DMOMLNDJJKD<T>(int HOPGLJCPGGA, Allocator EGJIMBMGFGA) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class FCADEMDJDOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private NativeArray<byte> KPAFOBEJBIN;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int FFGDBGPFOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x671690", Offset = "0x66FE90", VA = "0x180671690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x1B17C50", Offset = "0x1B16450", VA = "0x181B17C50")]
	public FCADEMDJDOO(NativeArray<byte> KPAFOBEJBIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3AF99E0", Offset = "0x3AF81E0", VA = "0x183AF99E0")]
	public static FCADEMDJDOO EDIIAGKPKGG(NativeArray<byte> KPAFOBEJBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x399EC30", Offset = "0x399D430", VA = "0x18399EC30")]
	public void CFNNLCLHEGH<T>(in T CCIMHDCKHOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x399EC90", Offset = "0x399D490", VA = "0x18399EC90")]
	public void FAMJEGFNHOD<T>(NativeArray<T> EADBNCPOLHD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	public void KEJBGNCCBPN<T>(NativeArray<T> CCIMHDCKHOF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LOBFAEMEMJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E1F0", Offset = "0x3A9C9F0", VA = "0x183A9E1F0")]
	public static Span<byte> DFBJJPBNILG(this NativeArray<byte> KPAFOBEJBIN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E370", Offset = "0x3A9CB70", VA = "0x183A9E370")]
	public static ReadOnlySpan<byte> HDKJMGLDCGN(this NativeArray<byte> KPAFOBEJBIN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E0F0", Offset = "0x3A9C8F0", VA = "0x183A9E0F0")]
	public static NativeArray<byte> AEJJAHNJJKC(this NativeArray<byte> KPAFOBEJBIN, int OMKHMNIPPGH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E4F0", Offset = "0x3A9CCF0", VA = "0x183A9E4F0")]
	public static NativeArray<byte> HHOLDKCMIKE(this NativeArray<byte> KPAFOBEJBIN, int LGKBEOCJMLG = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x36BAED0", Offset = "0x36B96D0", VA = "0x1836BAED0")]
	public static NativeArray<byte> HHOLDKCMIKE<T>(this NativeArray<byte> KPAFOBEJBIN, int LGKBEOCJMLG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E570", Offset = "0x3A9CD70", VA = "0x183A9E570")]
	public static NativeArray<byte> KLGPHNFGEKC(this NativeArray<byte> KPAFOBEJBIN, int LGKBEOCJMLG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x36BAF30", Offset = "0x36B9730", VA = "0x1836BAF30")]
	public static NativeArray<byte> KLGPHNFGEKC<T>(this NativeArray<byte> KPAFOBEJBIN, int LGKBEOCJMLG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E170", Offset = "0x3A9C970", VA = "0x183A9E170")]
	public static NativeArray<byte> CEBFGCKGOEM(this NativeArray<byte> KPAFOBEJBIN, int LGKBEOCJMLG = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x36B9A30", Offset = "0x36B8230", VA = "0x1836B9A30")]
	public static NativeArray<byte> CEBFGCKGOEM<T>(this NativeArray<byte> KPAFOBEJBIN, int LGKBEOCJMLG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class LMLFAOPOALJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private NativeList<byte> PIJDNOPJENO;

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x1B17C50", Offset = "0x1B16450", VA = "0x181B17C50")]
	public LMLFAOPOALJ(NativeList<byte> PIJDNOPJENO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D870", Offset = "0x3A9C070", VA = "0x183A9D870")]
	public static LMLFAOPOALJ EDIIAGKPKGG(NativeList<byte> KPAFOBEJBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	public void CFNNLCLHEGH<T>(in T CCIMHDCKHOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	public void FAMJEGFNHOD<T>(NativeArray<T> CCIMHDCKHOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	public void KEJBGNCCBPN<T>(NativeArray<T> CCIMHDCKHOF) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[OOAPDBLGMJF(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[HPLMCJEDJJG(KOEAPPNBOCD.PropertyChanges)]
	public class PropertyChangeNetworkRouter : AFNLLOENMMK, DNEGIKEIIMB, OOBCJOADNJP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private HIKCKCKAEBF IMLJHLOOKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private ADGKLIPEEBI FBNHINKPMEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private FMFHLBFGHJI IEBMFIFBGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private MIIBEBDJOEK LBBLJNDAFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private OCPNCAHNNFG NMDPGMLBILI;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public HIKCKCKAEBF KJBPILMMGGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x384EAF0", Offset = "0x384D2F0", VA = "0x18384EAF0")]
		public HIKCKCKAEBF.HPAHHEKPGIP FOEEADKNKOH()
		{
			return default(HIKCKCKAEBF.HPAHHEKPGIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x384EA60", Offset = "0x384D260", VA = "0x18384EA60", Slot = "4")]
		public void FKDGDLIKCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x384ECE0", Offset = "0x384D4E0", VA = "0x18384ECE0", Slot = "5")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x384EDB0", Offset = "0x384D5B0", VA = "0x18384EDB0")]
		public void MMFGOGFMNKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x384EEC0", Offset = "0x384D6C0", VA = "0x18384EEC0")]
		private void NEKOKLMLGBA(OCPNCAHNNFG LENKHFNFMLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x384EB10", Offset = "0x384D310", VA = "0x18384EB10")]
		private void IBLFBEBKBGC(OCPNCAHNNFG LENKHFNFMLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x384F1A0", Offset = "0x384D9A0", VA = "0x18384F1A0")]
		private void PKADDDKGOBE(OCPNCAHNNFG LENKHFNFMLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x384F260", Offset = "0x384DA60", VA = "0x18384F260")]
		private void PNODODGFGHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x384ED90", Offset = "0x384D590", VA = "0x18384ED90")]
		private void LNLDLKLBOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x384EC40", Offset = "0x384D440", VA = "0x18384EC40")]
		private void JAKOJNOLJLO(OCPNCAHNNFG LENKHFNFMLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x4216580", Offset = "0x4214D80", VA = "0x184216580", Slot = "6")]
		private void ANFINHPIGJO<TKey, T>(global::NJDICNIFPMB<TKey, T> MIGODNJAHNA, object IGBOEABBEHO) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x384EA30", Offset = "0x384D230", VA = "0x18384EA30", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[OOAPDBLGMJF(typeof(LJIIAMIGBED), new string[] { })]
public class LJIIAMIGBED : DNEGIKEIIMB, PGECBFIGDKK
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly JJLACLCEPON MNIOACBCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly HEICHNECIDK INPOOODNAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private CHCKBAIGEAG LMCKKENKDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private MHOGNFLCFLJ IEBMFIFBGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private ECJNNBLJLBI FLMDCNMMHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private PropertyChangeNetworkRouter OMDCIJELNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private FHCGLCCCIJI BCFGPBJOHAF;

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D550", Offset = "0x3A9BD50", VA = "0x183A9D550", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D0A0", Offset = "0x3A9B8A0", VA = "0x183A9D0A0", Slot = "5")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D440", Offset = "0x3A9BC40", VA = "0x183A9D440")]
	public void KELGJPAMBIF(DDAOHKAFOIC PFLOECMCNHK, BBAJGMCCMCB IBHOKKEKMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D3C0", Offset = "0x3A9BBC0", VA = "0x183A9D3C0")]
	public void IPLKCJIBGHO(DDAOHKAFOIC PFLOECMCNHK, FHCGLCCCIJI LKIMNIMPHKB, in IKKMGBAJNEB KBMJKBNKEOP, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D1C0", Offset = "0x3A9B9C0", VA = "0x183A9D1C0")]
	public void FHEIEPOBCFB(DDAOHKAFOIC PFLOECMCNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D1A0", Offset = "0x3A9B9A0", VA = "0x183A9D1A0")]
	private void BHEEPKINCLB(DDAOHKAFOIC PFLOECMCNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D630", Offset = "0x3A9BE30", VA = "0x183A9D630")]
	public void OKMAIJBCBFB(DDAOHKAFOIC PFLOECMCNHK, FHCGLCCCIJI LKIMNIMPHKB, in IKKMGBAJNEB KBMJKBNKEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D320", Offset = "0x3A9BB20", VA = "0x183A9D320")]
	private void HCKFGGJCDOF(DDAOHKAFOIC PFLOECMCNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D6B0", Offset = "0x3A9BEB0", VA = "0x183A9D6B0")]
	public LJIIAMIGBED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal abstract class GEEDMJHJDPO : DNEGIKEIIMB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private PLPBBGKMDGB GBKDJPJOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private uint LNHCLHNDILI;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public abstract uint MDFOBKKIMME
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x3AFAB00", Offset = "0x3AF9300", VA = "0x183AFAB00", Slot = "7")]
	public virtual void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA9F0", Offset = "0x3AF91F0", VA = "0x183AFA9F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA9A0", Offset = "0x3AF91A0", VA = "0x183AFA9A0")]
	public DDAOHKAFOIC CPNJFFPDPIN()
	{
		return default(DDAOHKAFOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x3AFAA80", Offset = "0x3AF9280", VA = "0x183AFAA80")]
	public void KHLHOKOFEOM(DDAOHKAFOIC GNEIAJCHPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x10BC460", Offset = "0x10BAC60", VA = "0x1810BC460", Slot = "8")]
	public virtual void PKLFPAMOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	protected GEEDMJHJDPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[OOAPDBLGMJF(typeof(ADOHHLAHGPA), new string[] { })]
internal sealed class ADOHHLAHGPA : GEEDMJHJDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private HBIJPHJPPAA OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private uint GDOGDBJHLHP;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public override uint MDFOBKKIMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x74FA30", Offset = "0x74E230", VA = "0x18074FA30", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2E20", Offset = "0x3AE1620", VA = "0x183AE2E20", Slot = "7")]
	public override void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2DD0", Offset = "0x3AE15D0", VA = "0x183AE2DD0")]
	private void FFOAPLAJKBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2F40", Offset = "0x3AE1740", VA = "0x183AE2F40", Slot = "8")]
	public override void PKLFPAMOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public ADOHHLAHGPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[OOAPDBLGMJF(typeof(DEKONHFJCDH), new string[] { })]
internal sealed class DEKONHFJCDH : GEEDMJHJDPO
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public override uint MDFOBKKIMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6670F0", Offset = "0x6658F0", VA = "0x1806670F0", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public DEKONHFJCDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[HCKNDCEEEAM(typeof(OMCLDCKMHNM))]
[OOAPDBLGMJF(typeof(HDKGDNLMGLC), new string[] { })]
internal sealed class HDKGDNLMGLC : PPOEDLGAMBE, AFNLLOENMMK, DNEGIKEIIMB, PGECBFIGDKK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private OMCLDCKMHNM EAMEDKLPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private NCNJODMFFIF JHCECLNHNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private EntityQuery DHEJHFLHBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private EntityQuery FPBNGFIBFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private EntityQuery BKCABEMEILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private EntityManager FHACAKFHJON
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFFD0", Offset = "0x3AFE7D0", VA = "0x183AFFFD0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EntityQuery PLNKAEGANDH
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x7325C0", Offset = "0x730DC0", VA = "0x1807325C0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public EntityQuery PNJNHEDAJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA17740", Offset = "0xA15F40", VA = "0x180A17740")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EntityQuery NBIGIMGLGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFB30", Offset = "0x3AFE330", VA = "0x183AFFB30")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int OJEAMPGFOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFFB0", Offset = "0x3AFE7B0", VA = "0x183AFFFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int IECKLHINPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF930", Offset = "0x3AFE130", VA = "0x183AFF930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int LPAMKIILJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFEE0", Offset = "0x3AFE6E0", VA = "0x183AFFEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "4")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x3B00160", Offset = "0x3AFE960", VA = "0x183B00160", Slot = "5")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF950", Offset = "0x3AFE150", VA = "0x183AFF950", Slot = "6")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x3B000C0", Offset = "0x3AFE8C0", VA = "0x183B000C0")]
	public HJHOBDHMCLM KOFAJPLFIFK()
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x3AFFBB0", Offset = "0x3AFE3B0", VA = "0x183AFFBB0")]
	public HJHOBDHMCLM BCPPGGPOPAJ()
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x3AFFCA0", Offset = "0x3AFE4A0", VA = "0x183AFFCA0")]
	public HJHOBDHMCLM DFDAOLHFHCB()
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x3AFFD40", Offset = "0x3AFE540", VA = "0x183AFFD40")]
	public DMDFKHMLDPI DFEMBKDBHPB(IOFHLMDPEAL PFLOECMCNHK)
	{
		return default(DMDFKHMLDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x3AFFDF0", Offset = "0x3AFE5F0", VA = "0x183AFFDF0")]
	public DMDFKHMLDPI DFEMBKDBHPB(Entity GDNDJKDEKFN)
	{
		return default(DMDFKHMLDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x3AFFF00", Offset = "0x3AFE700", VA = "0x183AFFF00")]
	public IOFCPOJDKFL FGGMDEJJMHP(Entity GDNDJKDEKFN)
	{
		return default(IOFCPOJDKFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x3AFFEA0", Offset = "0x3AFE6A0", VA = "0x183AFFEA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x3B00020", Offset = "0x3AFE820", VA = "0x183B00020")]
	private HJHOBDHMCLM ICJLAABGPAI(EntityQuery PMKDKHNEPAL)
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3B001E0", Offset = "0x3AFE9E0", VA = "0x183B001E0")]
	public HDKGDNLMGLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[OOAPDBLGMJF(typeof(NCNJODMFFIF), new string[] { })]
public class BFGOKPCEEFC : DNEGIKEIIMB, NCNJODMFFIF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private OMCLDCKMHNM EAMEDKLPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HBIJPHJPPAA OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private ObjectLifecycleService ICECBOBFDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private ObjectEmbodimentService EGJPJHAOMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private ObjectPrefabCreationService KBJJNECALFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private ObjectNetworkToLocalMapService HEAJCLFOHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private HDKGDNLMGLC OBHAAPDAKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private PLPBBGKMDGB GBKDJPJOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public OMBILBANOEN BKOIEKNNDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6980", Offset = "0x3AE5180", VA = "0x183AE6980", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private EntityManager FHACAKFHJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7010", Offset = "0x3AE5810", VA = "0x183AE7010")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int OJEAMPGFOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6E70", Offset = "0x3AE5670", VA = "0x183AE6E70", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int IECKLHINPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6260", Offset = "0x3AE4A60", VA = "0x183AE6260", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int LPAMKIILJII
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6C90", Offset = "0x3AE5490", VA = "0x183AE6C90", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int HDCINPLPMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7120", Offset = "0x3AE5920", VA = "0x183AE7120", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int OMMFOKCAHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7C10", Offset = "0x3AE6410", VA = "0x183AE7C10", Slot = "44")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<IOFHLMDPEAL, IOFCPOJDKFL> BMJEHKPAGKE
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6DD0", Offset = "0x3AE55D0", VA = "0x183AE6DD0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE71E0", Offset = "0x3AE59E0", VA = "0x183AE71E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<IOFHLMDPEAL> OCJPKBABAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3AE66D0", Offset = "0x3AE4ED0", VA = "0x183AE66D0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7060", Offset = "0x3AE5860", VA = "0x183AE7060", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7480", Offset = "0x3AE5C80", VA = "0x183AE7480", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6770", Offset = "0x3AE4F70", VA = "0x183AE6770")]
	private void DDFDEJJOEJJ(Entity GDNDJKDEKFN, IOFCPOJDKFL OHBBEKBPFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6290", Offset = "0x3AE4A90", VA = "0x183AE6290")]
	private void ADDIGKMJMEB(Entity GDNDJKDEKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x3AE71C0", Offset = "0x3AE59C0", VA = "0x183AE71C0")]
	internal IOFHLMDPEAL JDKLAIGHECL(Entity GDNDJKDEKFN)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7C30", Offset = "0x3AE6430", VA = "0x183AE7C30", Slot = "36")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	private void JAJBEFAJIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE69D0", Offset = "0x3AE51D0", VA = "0x183AE69D0", Slot = "38")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE73D0", Offset = "0x3AE5BD0", VA = "0x183AE73D0", Slot = "11")]
	public HJHOBDHMCLM KOFAJPLFIFK()
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x3AE64C0", Offset = "0x3AE4CC0", VA = "0x183AE64C0", Slot = "41")]
	public HJHOBDHMCLM BCPPGGPOPAJ()
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6810", Offset = "0x3AE5010", VA = "0x183AE6810", Slot = "42")]
	public HJHOBDHMCLM DFDAOLHFHCB()
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x3AE68C0", Offset = "0x3AE50C0", VA = "0x183AE68C0", Slot = "12")]
	public DMDFKHMLDPI DFEMBKDBHPB(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(DMDFKHMLDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6CE0", Offset = "0x3AE54E0", VA = "0x183AE6CE0", Slot = "13")]
	public IOFCPOJDKFL FGGMDEJJMHP(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(IOFCPOJDKFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6D20", Offset = "0x3AE5520", VA = "0x183AE6D20", Slot = "35")]
	public bool FKKMCEBMOMF(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6470", Offset = "0x3AE4C70", VA = "0x183AE6470", Slot = "31")]
	public void BCKCNDMGJOA(IOFHLMDPEAL CPBDAEHELGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6F50", Offset = "0x3AE5750", VA = "0x183AE6F50", Slot = "32")]
	public void HCHHHNHJCJG(IOFHLMDPEAL CPBDAEHELGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6DA0", Offset = "0x3AE55A0", VA = "0x183AE6DA0", Slot = "33")]
	public void FODPFOJIHMB(IOFHLMDPEAL CPBDAEHELGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6C60", Offset = "0x3AE5460", VA = "0x183AE6C60", Slot = "37")]
	public void EHGGNHACJJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7280", Offset = "0x3AE5A80", VA = "0x183AE7280", Slot = "25")]
	public CMIMIKMOPKA KELGJPAMBIF(IOFCPOJDKFL OHBBEKBPFPH)
	{
		return default(CMIMIKMOPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7710", Offset = "0x3AE5F10", VA = "0x183AE7710", Slot = "26")]
	public CMIMIKMOPKA LMGGBKFFDDM(IOFCPOJDKFL OHBBEKBPFPH)
	{
		return default(CMIMIKMOPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7300", Offset = "0x3AE5B00", VA = "0x183AE7300", Slot = "27")]
	public CMIMIKMOPKA KKBHPDPGGIO(DDAOHKAFOIC LNNGKIMHKAI, IOFCPOJDKFL OHBBEKBPFPH)
	{
		return default(CMIMIKMOPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6610", Offset = "0x3AE4E10", VA = "0x183AE6610", Slot = "28")]
	public LLLDPGKHFIG BNLAGHNGNJO()
	{
		return default(LLLDPGKHFIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6320", Offset = "0x3AE4B20", VA = "0x183AE6320", Slot = "43")]
	public IMHFCEALJNE AHPAEJDNMCD(BNFPHFLJIBP BCFKLEGAMEO)
	{
		return default(IMHFCEALJNE);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x3AE63C0", Offset = "0x3AE4BC0", VA = "0x183AE63C0", Slot = "29")]
	public JKJOICKOFGD APJGKMKJAME()
	{
		return default(JKJOICKOFGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6EA0", Offset = "0x3AE56A0", VA = "0x183AE6EA0", Slot = "30")]
	public KLKDNACKCDK HACNOOOPBHD(KOILODOMKMM BCFKLEGAMEO)
	{
		return default(KLKDNACKCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7100", Offset = "0x3AE5900", VA = "0x183AE7100", Slot = "15")]
	public void IIGIGLNPDMN(DDAOHKAFOIC LNNGKIMHKAI, GHMJIBJLDNA OMJIFKPFMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7AC0", Offset = "0x3AE62C0", VA = "0x183AE7AC0", Slot = "16")]
	public CMIMIKMOPKA MPHHGOHAHFD(IOFHLMDPEAL CPBDAEHELGD, [Optional] object FDKCIGPLPAB)
	{
		return default(CMIMIKMOPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x3AE77B0", Offset = "0x3AE5FB0", VA = "0x183AE77B0", Slot = "17")]
	public bool LPOPHPNOAOD(IOFHLMDPEAL CPBDAEHELGD, out GHMJIBJLDNA BBELMPNHPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7A70", Offset = "0x3AE6270", VA = "0x183AE7A70", Slot = "45")]
	public Transform MHFIGNMDDFK(IOFHLMDPEAL CPBDAEHELGD, [Optional] object FDKCIGPLPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6D50", Offset = "0x3AE5550", VA = "0x183AE6D50", Slot = "19")]
	public bool FLLDEIOLFNK(IOFHLMDPEAL CPBDAEHELGD, out Transform JDMGKLHBDHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6220", Offset = "0x3AE4A20", VA = "0x183AE6220", Slot = "20")]
	public bool AADNEELLNGM(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6FA0", Offset = "0x3AE57A0", VA = "0x183AE6FA0")]
	public bool HEOPAOOCMKB(GHMJIBJLDNA CCIMHDCKHOF, [Optional] object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6FC0", Offset = "0x3AE57C0", VA = "0x183AE6FC0", Slot = "46")]
	public bool HEOPAOOCMKB(IOFHLMDPEAL CPBDAEHELGD, [Optional] object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7790", Offset = "0x3AE5F90", VA = "0x183AE7790", Slot = "47")]
	public void LNFEFDNFIKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7800", Offset = "0x3AE6000", VA = "0x183AE7800", Slot = "18")]
	public void MCDEMNHEAGJ(GHMJIBJLDNA ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x3AE65D0", Offset = "0x3AE4DD0", VA = "0x183AE65D0", Slot = "48")]
	public void BGLGHHGNAFH(IOFHLMDPEAL CPBDAEHELGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6CC0", Offset = "0x3AE54C0", VA = "0x183AE6CC0", Slot = "21")]
	public void EPHNJFGJMIL(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7DC0", Offset = "0x3AE65C0", VA = "0x183AE7DC0", Slot = "22")]
	public bool OLMBONIFOFC(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE66B0", Offset = "0x3AE4EB0", VA = "0x183AE66B0", Slot = "49")]
	public bool DAHIJCGCDME(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6FF0", Offset = "0x3AE57F0", VA = "0x183AE6FF0", Slot = "50")]
	public bool HJMDCIFEJON(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7140", Offset = "0x3AE5940", VA = "0x183AE7140", Slot = "34")]
	public NativeArray<(IOFHLMDPEAL, IOFHLMDPEAL)> JAAHPLBFDOD(NativeArray<IOFHLMDPEAL> BCIIMKPOHKF, Allocator EGJIMBMGFGA)
	{
		return default(NativeArray<(IOFHLMDPEAL, IOFHLMDPEAL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7190", Offset = "0x3AE5990", VA = "0x183AE7190", Slot = "24")]
	public DDAOHKAFOIC JCBOEKFMENI(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(DDAOHKAFOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7BD0", Offset = "0x3AE63D0", VA = "0x183AE7BD0", Slot = "23")]
	public IOFHLMDPEAL NDFJMIJLHMK(DDAOHKAFOIC LNNGKIMHKAI)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BFGOKPCEEFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[OOAPDBLGMJF(typeof(GLANGEPDNGL), new string[] { })]
internal sealed class GLANGEPDNGL : DNEGIKEIIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private ObjectPrefabCreationService KBJJNECALFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private HDKGDNLMGLC OBHAAPDAKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private JIGACBOPBKP EAMEDKLPJKC;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x3AFCE40", Offset = "0x3AFB640", VA = "0x183AFCE40", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x3AFCD40", Offset = "0x3AFB540", VA = "0x183AFCD40")]
	public NativeArray<(IOFHLMDPEAL, IOFHLMDPEAL)> JAAHPLBFDOD(NativeArray<IOFHLMDPEAL> BCIIMKPOHKF, Allocator EGJIMBMGFGA)
	{
		return default(NativeArray<(IOFHLMDPEAL, IOFHLMDPEAL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x3AFCB60", Offset = "0x3AFB360", VA = "0x183AFCB60")]
	private void IFMNFJAFHBN(NativeMultiHashMap<int, (IOFHLMDPEAL src, IOFHLMDPEAL dst)> HIKJGAOGGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x3AFCF80", Offset = "0x3AFB780", VA = "0x183AFCF80")]
	private void NILFCMLJKCD(NativeMultiHashMap<int, (IOFHLMDPEAL src, IOFHLMDPEAL dst)> HIKJGAOGGDB, int OHBBEKBPFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x3AFC9D0", Offset = "0x3AFB1D0", VA = "0x183AFC9D0")]
	private void BCBMGHHGHJH(NativeMultiHashMap<int, (IOFHLMDPEAL src, IOFHLMDPEAL dst)> HIKJGAOGGDB, int OHBBEKBPFPH, CMKIKNDBPFM IEBMFIFBGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD370", Offset = "0x3AFBB70", VA = "0x183AFD370")]
	private NativeMultiHashMap<int, (IOFHLMDPEAL, IOFHLMDPEAL)> NJGFOIMANGO(Allocator EGJIMBMGFGA, NativeArray<IOFHLMDPEAL> BCIIMKPOHKF, out NativeArray<(IOFHLMDPEAL src, IOFHLMDPEAL dst)> CMHOMDKDOPP)
	{
		return default(NativeMultiHashMap<int, (IOFHLMDPEAL, IOFHLMDPEAL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public GLANGEPDNGL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[OOAPDBLGMJF(typeof(NJMMPJDFPHF), new string[] { })]
	[HPLMCJEDJJG(KOEAPPNBOCD.Physics, new string[] { "Callbacks" })]
	public class PhysicsService : DNEGIKEIIMB, PGECBFIGDKK, NJMMPJDFPHF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private const string BLBICJOMHFI = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private static readonly JJLACLCEPON EBLENELBPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private EntityManager JGGNCNMICJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private NCNJODMFFIF JHCECLNHNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private OMCLDCKMHNM EAMEDKLPJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private BBHEDGKDAJF EBBNPDOHGEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private PropertyEventCallbacksService HODCAEDHJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private global::CIHBFHMIFFK<LKMLNDHMMOF> CDPCFBHECOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool KAIBIFDFALJ;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<IOFHLMDPEAL, LKMLNDHMMOF> OOEOPHOFFPA
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x384D4D0", Offset = "0x384BCD0", VA = "0x18384D4D0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x384CF60", Offset = "0x384B760", VA = "0x18384CF60", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x384D3B0", Offset = "0x384BBB0", VA = "0x18384D3B0", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x384CCC0", Offset = "0x384B4C0", VA = "0x18384CCC0", Slot = "5")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x384D000", Offset = "0x384B800", VA = "0x18384D000", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x384D570", Offset = "0x384BD70", VA = "0x18384D570", Slot = "8")]
		public void OAFGFLKGBMJ(IOFHLMDPEAL CPBDAEHELGD, Vector3 FBDEMBLCHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x384D160", Offset = "0x384B960", VA = "0x18384D160", Slot = "9")]
		public bool EAAIGDKACEP(IOFHLMDPEAL CPBDAEHELGD, out Collider DMJMICMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x384D2F0", Offset = "0x384BAF0", VA = "0x18384D2F0")]
		private void IEEKKOCFGFN(Entity GDNDJKDEKFN, FHCGLCCCIJI LKIMNIMPHKB, IKKMGBAJNEB OHJKCCOELFF, IKKMGBAJNEB DIBLIDDDAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x384D230", Offset = "0x384BA30", VA = "0x18384D230", Slot = "10")]
		public void IBBMCCBJKJF(IOFHLMDPEAL CPBDAEHELGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public PhysicsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class HAJFHAAANFM : BJEGIJOLNFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly string IHPCCBIKCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly HAJFHAAANFM OIENDNJIDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly List<HAJFHAAANFM> ACJPGGBHPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly List<JODOCAEGKMF> IEBMFIFBGIK;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string ABJEHFBOOHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public BJEGIJOLNFA GGDMIIGDNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public IEnumerable<BJEGIJOLNFA> JNMNHLJJKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public IEnumerable<JODOCAEGKMF> HCGNKDEPDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF810", Offset = "0x3AFE010", VA = "0x183AFF810")]
	public HAJFHAAANFM(string FOGNBJMCDMG, HAJFHAAANFM OJKLIAPCMPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[HCKNDCEEEAM(typeof(NJFOAABDNKO))]
[OOAPDBLGMJF(typeof(AGFLDDKAGBE), new string[] { })]
public sealed class CBAOCDPCLGH : AGFLDDKAGBE, PPOEDLGAMBE, AFNLLOENMMK, DNEGIKEIIMB, PGECBFIGDKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class KNCIFABHJNG : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x74A710", Offset = "0x748F10", VA = "0x18074A710", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x38478F0", Offset = "0x38460F0", VA = "0x1838478F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F7420", Offset = "0x7F5C20", VA = "0x1807F7420")]
		[DebuggerHidden]
		public KNCIFABHJNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x38475E0", Offset = "0x3845DE0", VA = "0x1838475E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x38478B0", Offset = "0x38460B0", VA = "0x1838478B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x3847810", Offset = "0x3846010", VA = "0x183847810", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x3847810", Offset = "0x3846010", VA = "0x183847810", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly HOOKOBANMNL LAEKCBEICCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<string, HAJFHAAANFM> LKLGFOHBMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly Dictionary<int, BJEGIJOLNFA> ABOADMFIOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<JODOCAEGKMF> GGJDDKCGLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NJFOAABDNKO IEBMFIFBGIK;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public BJEGIJOLNFA FLCJJCMJFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x3AE9650", Offset = "0x3AE7E50", VA = "0x183AE9650", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public List<JODOCAEGKMF> MPAAJAOFPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "7")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9C00", Offset = "0x3AE8400", VA = "0x183AE9C00", Slot = "8")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9240", Offset = "0x3AE7A40", VA = "0x183AE9240", Slot = "9")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9430", Offset = "0x3AE7C30", VA = "0x183AE9430", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3AE93A0", Offset = "0x3AE7BA0", VA = "0x183AE93A0", Slot = "6")]
	public bool DKJJILINNLA(JODOCAEGKMF MIGODNJAHNA, out BJEGIJOLNFA LGCEOGAHLEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9870", Offset = "0x3AE8070", VA = "0x183AE9870")]
	private void KLGBCMCAJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x3AEA020", Offset = "0x3AE8820", VA = "0x183AEA020")]
	private void PGLPODHKANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9340", Offset = "0x3AE7B40", VA = "0x183AE9340")]
	private HAJFHAAANFM DIKNOLKKNDL(string ACADMDFIHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9650", Offset = "0x3AE7E50", VA = "0x183AE9650")]
	private HAJFHAAANFM JONPGFCHCFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9DB0", Offset = "0x3AE85B0", VA = "0x183AE9DB0")]
	private HAJFHAAANFM PDKPJHPBCDB(string ACADMDFIHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9480", Offset = "0x3AE7C80", VA = "0x183AE9480")]
	private HAJFHAAANFM GLCOMHANNGK(string OIPMKBNDJIF, string FDKCIGPLPAB, [Optional] HAJFHAAANFM OIENDNJIDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9D40", Offset = "0x3AE8540", VA = "0x183AE9D40")]
	[IteratorStateMachine(typeof(KNCIFABHJNG))]
	private IEnumerable<(string, string)> NPFDGOLOOCL(string ACADMDFIHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9260", Offset = "0x3AE7A60", VA = "0x183AE9260")]
	private bool CAEPFOFNNBB(JODOCAEGKMF MIGODNJAHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9790", Offset = "0x3AE7F90", VA = "0x183AE9790")]
	private HOOKOBANMNL IHCLHJMPHAO(JODOCAEGKMF MIGODNJAHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9740", Offset = "0x3AE7F40", VA = "0x183AE9740")]
	private HOOKOBANMNL IEDNCOKCHLB(JODOCAEGKMF MIGODNJAHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3AE96B0", Offset = "0x3AE7EB0", VA = "0x183AE96B0")]
	private HOOKOBANMNL IADMHKLHEMP(JODOCAEGKMF MIGODNJAHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x355B520", Offset = "0x3559D20", VA = "0x18355B520")]
	private T NLKBBGECHFF<T>(JODOCAEGKMF MIGODNJAHNA) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9C60", Offset = "0x3AE8460", VA = "0x183AE9C60")]
	private FieldInfo LOPLGCKHOME(JODOCAEGKMF MIGODNJAHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x3AEA1C0", Offset = "0x3AE89C0", VA = "0x183AEA1C0")]
	public CBAOCDPCLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x3AE92B0", Offset = "0x3AE7AB0", VA = "0x183AE92B0")]
	[CompilerGenerated]
	private int CCDJBKKIFMK(JODOCAEGKMF DOGOAAONBOH, JODOCAEGKMF ENHIJCCJFBF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[OOAPDBLGMJF(typeof(MHOGNFLCFLJ), new string[] { })]
[HCKNDCEEEAM(typeof(KLMCINPKLDN))]
[DefaultMember("Item")]
public class BMCCPMIDJLE : MHOGNFLCFLJ, IEnumerable<MIEGLNNJAGB>, IEnumerable, PPOEDLGAMBE, AFNLLOENMMK, DNEGIKEIIMB, PGECBFIGDKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly Dictionary<(Type, string), int> BKCGEPOPLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private KLMCINPKLDN IEBMFIFBGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private KNNBBMMMJFL HICGDLJCDEP;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x3AE83D0", Offset = "0x3AE6BD0", VA = "0x183AE83D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public MIEGLNNJAGB ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x3AE86D0", Offset = "0x3AE6ED0", VA = "0x183AE86D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public MIEGLNNJAGB ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x3AE86D0", Offset = "0x3AE6ED0", VA = "0x183AE86D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x3AE84D0", Offset = "0x3AE6CD0", VA = "0x183AE84D0", Slot = "11")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8650", Offset = "0x3AE6E50", VA = "0x183AE8650", Slot = "12")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "13")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x3AE80D0", Offset = "0x3AE68D0", VA = "0x183AE80D0")]
	private void DMJFBNHIMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x2464240", Offset = "0x2462A40", VA = "0x182464240")]
	private string BDCNNOMALGA(string FOGNBJMCDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3AE83F0", Offset = "0x3AE6BF0", VA = "0x183AE83F0", Slot = "7")]
	public MIEGLNNJAGB FJHOPHENDCF(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x3AE86F0", Offset = "0x3AE6EF0", VA = "0x183AE86F0")]
	private bool OJLOJIMIFMD(Type BJIDGGBJEAN, string FOGNBJMCDMG, out MIEGLNNJAGB PMOKKAEPEEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8520", Offset = "0x3AE6D20", VA = "0x183AE8520", Slot = "8")]
	public FHCGLCCCIJI GPBGCLPEPLP(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return default(FHCGLCCCIJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8630", Offset = "0x3AE6E30", VA = "0x183AE8630", Slot = "9")]
	public IEnumerator<MIEGLNNJAGB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8630", Offset = "0x3AE6E30", VA = "0x183AE8630", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x3AE89A0", Offset = "0x3AE71A0", VA = "0x183AE89A0")]
	public BMCCPMIDJLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[DefaultMember("Item")]
public interface JJENBGOMCNI
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EKHJNKCFCHL(FHCGLCCCIJI DGFBLJMJMFI, out int FBPAKFCOLHM);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[OOAPDBLGMJF(typeof(JJENBGOMCNI), new string[] { })]
[DefaultMember("Item")]
[HCKNDCEEEAM(typeof(FMFHLBFGHJI))]
public class LELFIDALFIN : DNEGIKEIIMB, PGECBFIGDKK, JJENBGOMCNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<FHCGLCCCIJI, int> FAJDOIOACPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private FMFHLBFGHJI IEBMFIFBGIK;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x3A9C3D0", Offset = "0x3A9ABD0", VA = "0x183A9C3D0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C090", Offset = "0x3A9A890", VA = "0x183A9C090", Slot = "6")]
	public bool EKHJNKCFCHL(FHCGLCCCIJI DGFBLJMJMFI, out int FBPAKFCOLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C100", Offset = "0x3A9A900", VA = "0x183A9C100", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C080", Offset = "0x3A9A880", VA = "0x183A9C080", Slot = "5")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C160", Offset = "0x3A9A960", VA = "0x183A9C160")]
	private void LNPEONEJBDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C430", Offset = "0x3A9AC30", VA = "0x183A9C430")]
	public LELFIDALFIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[OOAPDBLGMJF(typeof(FMFHLBFGHJI), new string[] { })]
[DefaultMember("Item")]
[HCKNDCEEEAM(typeof(MHOGNFLCFLJ))]
public class ACJIDPEGICN : FMFHLBFGHJI, IEnumerable<KONIEIPNKKM>, IEnumerable, PPOEDLGAMBE, AFNLLOENMMK, DNEGIKEIIMB, PGECBFIGDKK, OOBCJOADNJP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NCNJODMFFIF JHCECLNHNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private MHOGNFLCFLJ EGNHAHLMJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private KONIEIPNKKM[] LIAJIDOKKOB;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2650", Offset = "0x3AE0E50", VA = "0x183AE2650", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KONIEIPNKKM ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2940", Offset = "0x3AE1140", VA = "0x183AE2940", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public KONIEIPNKKM ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x3AE2940", Offset = "0x3AE1140", VA = "0x183AE2940", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "10")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2980", Offset = "0x3AE1180", VA = "0x183AE2980", Slot = "11")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "12")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2660", Offset = "0x3AE0E60", VA = "0x183AE2660", Slot = "6")]
	public KONIEIPNKKM FJHOPHENDCF(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2790", Offset = "0x3AE0F90", VA = "0x183AE2790", Slot = "7")]
	public FHCGLCCCIJI GPBGCLPEPLP(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return default(FHCGLCCCIJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2860", Offset = "0x3AE1060", VA = "0x183AE2860", Slot = "8")]
	public IEnumerator<KONIEIPNKKM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2C40", Offset = "0x3AE1440", VA = "0x183AE2C40", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x3120380", Offset = "0x311EB80", VA = "0x183120380", Slot = "13")]
	public void CPNDBBPBHFN<TKey, T>(global::NJDICNIFPMB<TKey, T> MIGODNJAHNA, [Optional] object IGBOEABBEHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2510", Offset = "0x3AE0D10", VA = "0x183AE2510", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public ACJIDPEGICN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2940", Offset = "0x3AE1140", VA = "0x183AE2940")]
	[CompilerGenerated]
	private KONIEIPNKKM KMADHLGNOKL(int GBIDHHJLPLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[HCKNDCEEEAM(typeof(MHOGNFLCFLJ))]
[DefaultMember("Item")]
[OOAPDBLGMJF(typeof(NJFOAABDNKO), new string[] { })]
public class PLOAMNEAJHG : NJFOAABDNKO, IEnumerable<JODOCAEGKMF>, IEnumerable, PPOEDLGAMBE, AFNLLOENMMK, DNEGIKEIIMB, PGECBFIGDKK, OOBCJOADNJP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NCNJODMFFIF JHCECLNHNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MHOGNFLCFLJ EGNHAHLMJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private JODOCAEGKMF[] LIAJIDOKKOB;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x384AE60", Offset = "0x3849660", VA = "0x18384AE60", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public JODOCAEGKMF ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x384B290", Offset = "0x3849A90", VA = "0x18384B290", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public JODOCAEGKMF ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x384B290", Offset = "0x3849A90", VA = "0x18384B290", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "9")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x384B2A0", Offset = "0x3849AA0", VA = "0x18384B2A0", Slot = "10")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x384AB60", Offset = "0x3849360", VA = "0x18384AB60", Slot = "11")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x384B1B0", Offset = "0x38499B0", VA = "0x18384B1B0")]
	private JODOCAEGKMF JJJNFELBPCE(int MMABPPDCBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x384AEB0", Offset = "0x38496B0", VA = "0x18384AEB0", Slot = "6")]
	public JODOCAEGKMF FJHOPHENDCF(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x384AFD0", Offset = "0x38497D0", VA = "0x18384AFD0", Slot = "15")]
	public FHCGLCCCIJI GPBGCLPEPLP(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return default(FHCGLCCCIJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x384B0A0", Offset = "0x38498A0", VA = "0x18384B0A0", Slot = "7")]
	public IEnumerator<JODOCAEGKMF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x384B0A0", Offset = "0x38498A0", VA = "0x18384B0A0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x3973A10", Offset = "0x3972210", VA = "0x183973A10", Slot = "12")]
	public void CPNDBBPBHFN<TKey, T>(global::NJDICNIFPMB<TKey, T> MIGODNJAHNA, [Optional] object IGBOEABBEHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x384ADC0", Offset = "0x38495C0", VA = "0x18384ADC0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public PLOAMNEAJHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x384B290", Offset = "0x3849A90", VA = "0x18384B290")]
	[CompilerGenerated]
	private JODOCAEGKMF LCLMGKNOGMG(int GBIDHHJLPLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[OOAPDBLGMJF(typeof(KLMCINPKLDN), new string[] { })]
[HCKNDCEEEAM(typeof(OMCLDCKMHNM))]
internal class KLMCINPKLDN : DNEGIKEIIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private OMCLDCKMHNM EAMEDKLPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private MHOGNFLCFLJ EGNHAHLMJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NJFOAABDNKO LIMEPMKGBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private FMFHLBFGHJI BMCPNAKJOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private global::GEDPBPAGPNN<CMKIKNDBPFM> INDELOEGBGL;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public KNNBBMMMJFL KFPFPADPOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x726A30", Offset = "0x725230", VA = "0x180726A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x726A50", Offset = "0x725250", VA = "0x180726A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B130", Offset = "0x3A99930", VA = "0x183A9B130", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x3A9AEA0", Offset = "0x3A996A0", VA = "0x183A9AEA0")]
	private void DPLCIFIHHMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x2E2BFB0", Offset = "0x2E2A7B0", VA = "0x182E2BFB0")]
	public T DDBNBLGNDBJ<T>() where T : CMKIKNDBPFM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x3A9ADD0", Offset = "0x3A995D0", VA = "0x183A9ADD0")]
	public MIEGLNNJAGB CPGKFNJOLEL(FAMLDGNAFHF FOGNBJMCDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	public global::CIHBFHMIFFK<T> CPGKFNJOLEL<T>(FAMLDGNAFHF FOGNBJMCDMG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B060", Offset = "0x3A99860", VA = "0x183A9B060")]
	public JODOCAEGKMF KHCHCBBIMIE(FAMLDGNAFHF FOGNBJMCDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2E2BFE0", Offset = "0x2E2A7E0", VA = "0x182E2BFE0")]
	public global::FNDBOCNPCDA<T> KHCHCBBIMIE<T>(FAMLDGNAFHF FOGNBJMCDMG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3A9AF90", Offset = "0x3A99790", VA = "0x183A9AF90")]
	public KONIEIPNKKM EAMMEGCFLPC(FAMLDGNAFHF FOGNBJMCDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	public global::GKPBOJPKODO<T> EAMMEGCFLPC<T>(FAMLDGNAFHF FOGNBJMCDMG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public KLMCINPKLDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class MKNOEOEPPNO
{
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3A4DC20", Offset = "0x3A4C420", VA = "0x183A4DC20")]
	public static global::CIHBFHMIFFK<T> CPGKFNJOLEL<T>(this KLMCINPKLDN OPHPDKKBMMJ, global::JHOLIPIPHIK<T> FOGNBJMCDMG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	public static global::FNDBOCNPCDA<T> KHCHCBBIMIE<T>(this KLMCINPKLDN OPHPDKKBMMJ, global::JHOLIPIPHIK<T> FOGNBJMCDMG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	public static global::GKPBOJPKODO<T> EAMMEGCFLPC<T>(this KLMCINPKLDN OPHPDKKBMMJ, global::JHOLIPIPHIK<T> FOGNBJMCDMG) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[OOAPDBLGMJF(typeof(EIKDJLFFGBK), new string[] { })]
public sealed class EIKDJLFFGBK : DNEGIKEIIMB, PGECBFIGDKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class PKIDHNNKCCO : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7F54B0", Offset = "0x7F3CB0", VA = "0x1807F54B0")]
		[DebuggerHidden]
		public PKIDHNNKCCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x3849A30", Offset = "0x3848230", VA = "0x183849A30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x3849680", Offset = "0x3847E80", VA = "0x183849680", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x3849AB0", Offset = "0x38482B0", VA = "0x183849AB0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x38499F0", Offset = "0x38481F0", VA = "0x1838499F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3849960", Offset = "0x3848160", VA = "0x183849960", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x3849960", Offset = "0x3848160", VA = "0x183849960", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const string EIJBLNPKCAD = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Dictionary<SerializableGuid, EIGCJOLCLNC> MONOOMPKCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly List<SerializableGuid> LIDIBIBLHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly Dictionary<SerializableGuid, GameObject> KBJJNECALFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NCNJODMFFIF JHCECLNHNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NJFOAABDNKO IEBMFIFBGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private HBIJPHJPPAA OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private KAOEDAJOEMH NJIEGCDNDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private OMCLDCKMHNM EAMEDKLPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private BJBGOMFMFBL EDLBGDJBDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private global::LIGDPEGLOMN<EIGCJOLCLNC> LIGHEEKFFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GameObject PDMHPHNPBNG;

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6250", Offset = "0x3AF4A50", VA = "0x183AF6250", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF53A0", Offset = "0x3AF3BA0", VA = "0x183AF53A0", Slot = "5")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF55D0", Offset = "0x3AF3DD0", VA = "0x183AF55D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6240", Offset = "0x3AF4A40", VA = "0x183AF6240")]
	private void KMOCPNGCAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6350", Offset = "0x3AF4B50", VA = "0x183AF6350")]
	internal void MJMHEABOKEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6060", Offset = "0x3AF4860", VA = "0x183AF6060")]
	private void INGBIEMDCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5950", Offset = "0x3AF4150", VA = "0x183AF5950")]
	private void ELPBPPCOECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5ED0", Offset = "0x3AF46D0", VA = "0x183AF5ED0")]
	[IteratorStateMachine(typeof(PKIDHNNKCCO))]
	private IEnumerable<RRCustomPropTag> HOAOELEHKHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5A50", Offset = "0x3AF4250", VA = "0x183AF5A50")]
	private void GKFLJKECNEI(IOFHLMDPEAL CPBDAEHELGD, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5F20", Offset = "0x3AF4720", VA = "0x183AF5F20")]
	private void IIGIGLNPDMN(SerializableGuid PMPGCMIMMLH, GameObject HBGIADIFHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6780", Offset = "0x3AF4F80", VA = "0x183AF6780")]
	private void MMEDOEKINLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3AF5770", Offset = "0x3AF3F70", VA = "0x183AF5770")]
	private bool EAPJFFNLMAI(EIGCJOLCLNC OGJJHKMINGI, Transform OJKLIAPCMPJ, out GameObject NIDJHACIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6B10", Offset = "0x3AF5310", VA = "0x183AF6B10")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6B60", Offset = "0x3AF5360", VA = "0x183AF6B60")]
	public EIKDJLFFGBK()
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
		public SerializableGuid GKDENAACNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x74A710", Offset = "0x748F10", VA = "0x18074A710")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x38518F0", Offset = "0x38500F0", VA = "0x1838518F0")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6E7F30", Offset = "0x6E6730", VA = "0x1806E7F30")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[OOAPDBLGMJF(typeof(LLNLFBIJEEI), new string[] { })]
public class NOPOPPMEIFF : DNEGIKEIIMB, LLNLFBIJEEI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private const string LMCHNIPOBHO = "ScopeService";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private CMIMIKMOPKA GGEIAOMMHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private NCNJODMFFIF JHCECLNHNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private HCGMPCJKLOI ONLIPGCGABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private CANGMNNAPBN LPEPHGEGADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private ObjectEmbodimentService EGJPJHAOMIN;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public IOFHLMDPEAL AJGMLONBPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x74A710", Offset = "0x748F10", VA = "0x18074A710", Slot = "7")]
		get
		{
			return default(IOFHLMDPEAL);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x3AA3780", Offset = "0x3AA1F80", VA = "0x183AA3780", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CMIMIKMOPKA KFEIBKFPKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x74A710", Offset = "0x748F10", VA = "0x18074A710", Slot = "9")]
		get
		{
			return default(CMIMIKMOPKA);
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x3AA3780", Offset = "0x3AA1F80", VA = "0x183AA3780", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event LJMIAPEFJJM HHGCPOLKOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x3AA3DC0", Offset = "0x3AA25C0", VA = "0x183AA3DC0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x3AA4320", Offset = "0x3AA2B20", VA = "0x183AA4320", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4190", Offset = "0x3AA2990", VA = "0x183AA4190", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3970", Offset = "0x3AA2170", VA = "0x183AA3970", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3AC0", Offset = "0x3AA22C0", VA = "0x183AA3AC0", Slot = "11")]
	public IOFHLMDPEAL EGFDMBBCIHG(IOFHLMDPEAL IFLKAOGBEDH, IOFHLMDPEAL KNPAGIAAIJP)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3F80", Offset = "0x3AA2780", VA = "0x183AA3F80", Slot = "12")]
	public bool KDGKGEDFGPG(IOFHLMDPEAL IFLKAOGBEDH, IOFHLMDPEAL KNPAGIAAIJP, out IOFHLMDPEAL FNFLMMJIIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4080", Offset = "0x3AA2880", VA = "0x183AA4080", Slot = "13")]
	public void LDBGIAJMDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3DA0", Offset = "0x3AA25A0", VA = "0x183AA3DA0", Slot = "14")]
	public void FJICHCIPAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3E60", Offset = "0x3AA2660", VA = "0x183AA3E60", Slot = "15")]
	public bool JODJKPOENHL(IOFHLMDPEAL MJPNNJLLLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3BD0", Offset = "0x3AA23D0", VA = "0x183AA3BD0")]
	private bool EOADJFPLNMF(IOFHLMDPEAL AHEEKHBLLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x3AA37A0", Offset = "0x3AA1FA0", VA = "0x183AA37A0")]
	private void CFDAMBHCCGP(CMIMIKMOPKA ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public NOPOPPMEIFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[OOAPDBLGMJF(typeof(CANGMNNAPBN), new string[] { })]
public class BGIFGHFILCG : DNEGIKEIIMB, CANGMNNAPBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private EntityManager JGGNCNMICJO;

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7DE0", Offset = "0x3AE65E0", VA = "0x183AE7DE0", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7E60", Offset = "0x3AE6660", VA = "0x183AE7E60", Slot = "5")]
	public void ODKOKFFHAPD(IOFHLMDPEAL PFLOECMCNHK, bool CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x354B1A0", Offset = "0x35499A0", VA = "0x18354B1A0")]
	private void DIMECELKFHA<T>(IOFHLMDPEAL PFLOECMCNHK, bool CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BGIFGHFILCG()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[OOAPDBLGMJF(typeof(KFOLAMOKFLP), new string[] { })]
	[HPLMCJEDJJG(KOEAPPNBOCD.RenderEffects)]
	public class SelectionService : DNEGIKEIIMB, KFOLAMOKFLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private EntityManager JGGNCNMICJO;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x3852D70", Offset = "0x3851570", VA = "0x183852D70", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x3852DF0", Offset = "0x38515F0", VA = "0x183852DF0", Slot = "5")]
		public void PDEJDPKFFGF(IOFHLMDPEAL PFLOECMCNHK, bool CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x3852D00", Offset = "0x3851500", VA = "0x183852D00", Slot = "6")]
		public void BMHPHDCDGBJ(IOFHLMDPEAL PFLOECMCNHK, bool CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x354B1A0", Offset = "0x35499A0", VA = "0x18354B1A0")]
		private void DIMECELKFHA<T>(IOFHLMDPEAL PFLOECMCNHK, bool CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[OOAPDBLGMJF(typeof(NHBLKFLNCCJ), new string[] { })]
public class EFKPHOOINEA : NHBLKFLNCCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool BNBAMNCLAEI;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool PJOCAJBJDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6F8740", Offset = "0x6F6F40", VA = "0x1806F8740", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5340", Offset = "0x3AF3B40", VA = "0x183AF5340", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<bool> AKPMDOPGMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF52A0", Offset = "0x3AF3AA0", VA = "0x183AF52A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x3AF5200", Offset = "0x3AF3A00", VA = "0x183AF5200", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public EFKPHOOINEA()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[OOAPDBLGMJF(typeof(KAOEDAJOEMH), new string[] { })]
	[HPLMCJEDJJG(KOEAPPNBOCD.Serialization, new string[] { "Timing" })]
	public class SerializationService : DNEGIKEIIMB, KAOEDAJOEMH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct JPJPLDKCMOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public HMKFOAIHMEI CKELMPPHPGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public HMKFOAIHMEI NMILBDNIDIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public HMKFOAIHMEI OJCKGPJIBPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public HMKFOAIHMEI DANHKGNGLOJ;

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x51CE910", Offset = "0x51CD110", VA = "0x1851CE910")]
			public static JPJPLDKCMOI MADPLDOCFBN()
			{
				return default(JPJPLDKCMOI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
			[Conditional("DEBUG_WORLDS")]
			public void PDHGAAMLKHD()
			{
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct HMKFOAIHMEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
			public HMKFOAIHMEI(string NJKKDANCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
			public void AECOPHMDBCG(EntityManager NJKKDANCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
			public void PDHGAAMLKHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private const string AMDFEKMAHOJ = "Timing";

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static readonly JJLACLCEPON OAHFHFPLFKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private EEAJKGBJNOA AHNMBJFNCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private OMCLDCKMHNM EAMEDKLPJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private NHBLKFLNCCJ FDJGLNKJAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private NCNJODMFFIF JHCECLNHNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private SerializationRemapScope LLKGMADOFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private HDKGDNLMGLC OBHAAPDAKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private NMJLMBINCKO HPINPKNGMPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private bool? HHIDLIBNAJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private JPJPLDKCMOI DBMNLCCFKEE;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool FEFMAEHPLCD
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x3853570", Offset = "0x3851D70", VA = "0x183853570", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x38544F0", Offset = "0x3852CF0", VA = "0x1838544F0", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action IHIGOIDMCAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x38538B0", Offset = "0x38520B0", VA = "0x1838538B0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x3854260", Offset = "0x3852A60", VA = "0x183854260", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<PIALCHFKIHC> AEODNBKHDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x3853B80", Offset = "0x3852380", VA = "0x183853B80", Slot = "21")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x3854D50", Offset = "0x3853550", VA = "0x183854D50", Slot = "22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action BEHBHCDLJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x3853E20", Offset = "0x3852620", VA = "0x183853E20", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x3854DF0", Offset = "0x38535F0", VA = "0x183854DF0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action DOGBJPIDLAF
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x38566E0", Offset = "0x3854EE0", VA = "0x1838566E0", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x3856470", Offset = "0x3854C70", VA = "0x183856470", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<PIALCHFKIHC> NFMELJBFMLL
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x3855700", Offset = "0x3853F00", VA = "0x183855700", Slot = "23")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x3853EC0", Offset = "0x38526C0", VA = "0x183853EC0", Slot = "24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x38557A0", Offset = "0x3853FA0", VA = "0x1838557A0", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x3856140", Offset = "0x3854940", VA = "0x183856140", Slot = "11")]
		public void OEEGKBNAKFI(bool CNKCPFJNMAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x3855470", Offset = "0x3853C70", VA = "0x183855470", Slot = "13")]
		public ByteString HHDOHEHKDKI(out IDisposable LLKGMADOFJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x38552A0", Offset = "0x3853AA0", VA = "0x1838552A0", Slot = "12")]
		public ByteString HHDOHEHKDKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x3853870", Offset = "0x3852070", VA = "0x183853870", Slot = "16")]
		public bool ADHMOLAJGDE(ByteString EGFFIMBAAAB, ICHAMCHHHDE ALKHBOMOJMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x3855550", Offset = "0x3853D50", VA = "0x183855550", Slot = "17")]
		public bool KIIHOPNIAKF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x3854250", Offset = "0x3852A50", VA = "0x183854250", Slot = "14")]
		public void DALNGINDNDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x3854B80", Offset = "0x3853380", VA = "0x183854B80", Slot = "27")]
		public void FBBPBCOJECK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x38562C0", Offset = "0x3854AC0", VA = "0x1838562C0", Slot = "15")]
		public void OEHEOOPENCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x3854500", Offset = "0x3852D00", VA = "0x183854500", Slot = "18")]
		public bool DMGEALDACPB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x3854E90", Offset = "0x3853690", VA = "0x183854E90", Slot = "19")]
		public bool GLBNGIHMHOC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x3855180", Offset = "0x3853980", VA = "0x183855180")]
		private void GOBDAOEDHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x25B4040", Offset = "0x25B2840", VA = "0x1825B4040")]
		private void BCJBLHKJDKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x38539B0", Offset = "0x38521B0", VA = "0x1838539B0")]
		private void BBGFOCNJJEC(JHMAKDMCKJI JKEJIABAEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x3853950", Offset = "0x3852150", VA = "0x183853950")]
		private ByteString APHHHCDKHOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x3856020", Offset = "0x3854820", VA = "0x183856020")]
		private ByteString OALKKPPNNCG(ByteString AHJGIIFAPKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x3853AA0", Offset = "0x38522A0", VA = "0x183853AA0")]
		private bool BCMIMFLPNDP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x3855C50", Offset = "0x3854450", VA = "0x183855C50")]
		private void MLFHPHHNPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x38558A0", Offset = "0x38540A0", VA = "0x1838558A0")]
		private void MHGLAJHJKJG(out ByteString AHJGIIFAPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x3854820", Offset = "0x3853020", VA = "0x183854820")]
		private bool EJGNOLABCJG(ByteString EGFFIMBAAAB, ICHAMCHHHDE ALKHBOMOJMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x3853580", Offset = "0x3851D80", VA = "0x183853580")]
		private bool ACGNONLGNKM(ByteString EGFFIMBAAAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x3854300", Offset = "0x3852B00", VA = "0x183854300")]
		private bool DKCGLJGACCB(NMJLMBINCKO.BKHMPJONLOA.HPJBMOAHNKK ELGPOOCMMCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x3853F60", Offset = "0x3852760", VA = "0x183853F60")]
		private void CNJDKFOGBJA(PIALCHFKIHC JKEJIABAEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x3856780", Offset = "0x3854F80", VA = "0x183856780")]
		private JHMAKDMCKJI PMMGHGIPEJH(EntityManager NLDNPCFEGJC, EntityManager KGCHJKNHGKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x3853C20", Offset = "0x3852420", VA = "0x183853C20")]
		private void BPFKLCCBBPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x3856510", Offset = "0x3854D10", VA = "0x183856510")]
		private void OJEEPLKEKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x3854B40", Offset = "0x3853340", VA = "0x183854B40")]
		private void EPPJHJEHHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x3855650", Offset = "0x3853E50", VA = "0x183855650")]
		private NMJLMBINCKO.BKHMPJONLOA.HPJBMOAHNKK KOACOCBCFHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[OOAPDBLGMJF(typeof(BBBIOMKAODA), new string[] { })]
public class BBBIOMKAODA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly Dictionary<KOILODOMKMM, string> NCDCHLBMMDM;

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x3AE50C0", Offset = "0x3AE38C0", VA = "0x183AE50C0")]
	public GameObject FKEFGNCKDGA(KOILODOMKMM IBEHBIFEPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5190", Offset = "0x3AE3990", VA = "0x183AE5190")]
	public BBBIOMKAODA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[OOAPDBLGMJF(typeof(JOFCFLECLCD), new string[] { })]
public class GMMFIAKJODM : JOFCFLECLCD
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDE20", Offset = "0x3AFC620", VA = "0x183AFDE20", Slot = "5")]
	public void INGPAEKCCFB(object NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDFE0", Offset = "0x3AFC7E0", VA = "0x183AFDFE0", Slot = "6")]
	public void LPNJDPILCPB(object NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDF00", Offset = "0x3AFC700", VA = "0x183AFDF00", Slot = "7")]
	public void LGKGPLEPENF(object NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDD10", Offset = "0x3AFC510", VA = "0x183AFDD10", Slot = "4")]
	public IDisposable FPCBFCGBELH(object NJAIIGFCHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public GMMFIAKJODM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[OOAPDBLGMJF(typeof(JLKICMMDFEF), new string[] { })]
public class GLEAFEIPMFN : DNEGIKEIIMB, JLKICMMDFEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private OMCLDCKMHNM EAMEDKLPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private NOCGABKMADN LBIJINBBJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private NHBLKFLNCCJ NOLIDDABIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private TransformOwnershipPhase KFAADBMJGGI;

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDC30", Offset = "0x3AFC430", VA = "0x183AFDC30", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDB60", Offset = "0x3AFC360", VA = "0x183AFDB60", Slot = "6")]
	public void KIEPIGMLFGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD890", Offset = "0x3AFC090", VA = "0x183AFD890", Slot = "5")]
	public void FDIPDDNBMGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD7A0", Offset = "0x3AFBFA0", VA = "0x183AFD7A0", Slot = "7")]
	public void BKLBJKMJJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD960", Offset = "0x3AFC160", VA = "0x183AFD960", Slot = "8")]
	public void GFMHPOKBEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD650", Offset = "0x3AFBE50", VA = "0x183AFD650", Slot = "9")]
	public void AIKBBGGJOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDA30", Offset = "0x3AFC230", VA = "0x183AFDA30", Slot = "10")]
	public void HLDDLOHHEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDAB0", Offset = "0x3AFC2B0", VA = "0x183AFDAB0", Slot = "11")]
	public void IHHPHDNNDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public GLEAFEIPMFN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[HPLMCJEDJJG(KOEAPPNBOCD.TransformSyncing)]
	[OOAPDBLGMJF(typeof(IACMPOBAJCP), new string[] { })]
	public class TransformService : IACMPOBAJCP, DNEGIKEIIMB, PGECBFIGDKK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private OMCLDCKMHNM EAMEDKLPJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private NCNJODMFFIF JHCECLNHNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private HCGMPCJKLOI ONLIPGCGABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TransformOwnershipPhase HOBFBPMLKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private global::CIHBFHMIFFK<Entity> OJKLIAPCMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private ObjectEmbodimentService AIFFIEBBMOL;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private EntityManager FHACAKFHJON
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x3859FF0", Offset = "0x38587F0", VA = "0x183859FF0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		private BJBGOMFMFBL NPECBMJOKEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x385C7D0", Offset = "0x385AFD0", VA = "0x18385C7D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x385ACA0", Offset = "0x38594A0", VA = "0x18385ACA0", Slot = "33")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x3858840", Offset = "0x3857040", VA = "0x183858840", Slot = "34")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x3859130", Offset = "0x3857930", VA = "0x183859130", Slot = "35")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x385B2B0", Offset = "0x3859AB0", VA = "0x18385B2B0", Slot = "36")]
		public bool MGLLJIPMKBF(Transform JDMGKLHBDHC, out IOFHLMDPEAL CPBDAEHELGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x385A040", Offset = "0x3858840", VA = "0x18385A040", Slot = "37")]
		public Transform IAHHILHKCHF(Entity GDNDJKDEKFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x38599E0", Offset = "0x38581E0", VA = "0x1838599E0", Slot = "31")]
		public bool FLLDEIOLFNK(Entity GDNDJKDEKFN, out Transform JDMGKLHBDHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x385B520", Offset = "0x3859D20", VA = "0x18385B520")]
		private void MPLKCEGCBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x385C450", Offset = "0x385AC50", VA = "0x18385C450", Slot = "30")]
		public void OICFMCMFOEC(Entity GDNDJKDEKFN, out Matrix4x4 CLLKBGMNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x385BD80", Offset = "0x385A580", VA = "0x18385BD80", Slot = "4")]
		public void NOCKHCGGFDI(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x3859D20", Offset = "0x3858520", VA = "0x183859D20")]
		private void GIKOEHCBBCL(Entity GDNDJKDEKFN, Vector3 BIFOHEGELJH, Quaternion LLCDBICBDDO, Vector3 AOPAIJHBHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x38591D0", Offset = "0x38579D0", VA = "0x1838591D0")]
		private void ECGMBACNEBD(Entity GDNDJKDEKFN, Vector3 BIFOHEGELJH, Quaternion LLCDBICBDDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x3858970", Offset = "0x3857170", VA = "0x183858970", Slot = "28")]
		public void CBEKIJIOHEG(Entity GDNDJKDEKFN, out Matrix4x4 BBBIPBMOHOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x3858980", Offset = "0x3857180", VA = "0x183858980")]
		public void CBIIKOFOAIB(Entity GDNDJKDEKFN, in Matrix4x4 CLLKBGMNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x385C260", Offset = "0x385AA60", VA = "0x18385C260")]
		private void OGJDDNNPHGI(Entity GDNDJKDEKFN, in Matrix4x4 BNJEBHAJKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x385CC90", Offset = "0x385B490", VA = "0x18385CC90", Slot = "5")]
		public void PALBBHELGBL(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x385A100", Offset = "0x3858900", VA = "0x18385A100", Slot = "6")]
		public Vector3 IJCBPDLLPGF(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x385AB70", Offset = "0x3859370", VA = "0x18385AB70", Slot = "7")]
		public void LEOBIFEABNN(Entity GDNDJKDEKFN, Quaternion CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x3859600", Offset = "0x3857E00", VA = "0x183859600", Slot = "8")]
		public Quaternion FDEIOJHADMF(Entity GDNDJKDEKFN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x385C5A0", Offset = "0x385ADA0", VA = "0x18385C5A0", Slot = "13")]
		public void OIFGLMLKFKL(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x385A980", Offset = "0x3859180", VA = "0x18385A980", Slot = "12")]
		public Vector3 KJIEIDDLGNB(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x3858D30", Offset = "0x3857530", VA = "0x183858D30")]
		private void CKGIEJEDMKL(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x385A8E0", Offset = "0x38590E0", VA = "0x18385A8E0")]
		private Vector3 KFDGODINGOD(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x3859C80", Offset = "0x3858480", VA = "0x183859C80", Slot = "15")]
		public float GHIMLBGBFPH(Entity GDNDJKDEKFN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x385A7C0", Offset = "0x3858FC0", VA = "0x18385A7C0", Slot = "14")]
		public void JICGEDOAIDK(Entity GDNDJKDEKFN, float CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x3859720", Offset = "0x3857F20", VA = "0x183859720")]
		private float FDOOCBBAKEN(Entity GDNDJKDEKFN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x385B460", Offset = "0x3859C60", VA = "0x18385B460")]
		private void MLMHDPPCALI(Entity GDNDJKDEKFN, float JBABODEHNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x3859520", Offset = "0x3857D20", VA = "0x183859520", Slot = "17")]
		public Vector3 FAKAKFGMLLD(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x3858DD0", Offset = "0x38575D0", VA = "0x183858DD0", Slot = "16")]
		public void DGMDJDECKBE(Entity GDNDJKDEKFN, Vector3 NKLDJCGKGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x3859EC0", Offset = "0x38586C0", VA = "0x183859EC0")]
		private Vector3 GPDJIFMOHFK(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x385CDE0", Offset = "0x385B5E0", VA = "0x18385CDE0")]
		private void PKHNCJIEFIJ(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x385A610", Offset = "0x3858E10", VA = "0x18385A610")]
		[Conditional("DEBUG_BUILD")]
		private void JGMBEADKNAF(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x3859810", Offset = "0x3858010", VA = "0x183859810", Slot = "9")]
		public void FFKIICALAOK(Entity GDNDJKDEKFN, Vector3 LPADDFNBONE, Quaternion OIFAPGIKFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x385C0E0", Offset = "0x385A8E0", VA = "0x18385C0E0", Slot = "10")]
		public void OEBBAGCPONH(Entity GDNDJKDEKFN, out Vector3 LPADDFNBONE, out Quaternion OIFAPGIKFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x385C6A0", Offset = "0x385AEA0", VA = "0x18385C6A0", Slot = "11")]
		public void OMLACCAEJFJ(Entity GDNDJKDEKFN, out Vector3 LPADDFNBONE, out Quaternion OIFAPGIKFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x385B8A0", Offset = "0x385A0A0", VA = "0x18385B8A0", Slot = "18")]
		public void NJMMEEGMBKH(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x385AA90", Offset = "0x3859290", VA = "0x18385AA90", Slot = "19")]
		public Vector3 KPAHPLCDFFM(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x385A430", Offset = "0x3858C30", VA = "0x18385A430", Slot = "20")]
		public void JAICONLDEIK(Entity GDNDJKDEKFN, Quaternion CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x3859310", Offset = "0x3857B10", VA = "0x183859310", Slot = "21")]
		public Quaternion EDGMAEAKHGD(Entity GDNDJKDEKFN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x38583E0", Offset = "0x3856BE0", VA = "0x1838583E0", Slot = "23")]
		public void ADIGMAAKNCM(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x3859040", Offset = "0x3857840", VA = "0x183859040", Slot = "22")]
		public Vector3 DOJFBLMNKMN(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x385BA60", Offset = "0x385A260", VA = "0x18385BA60", Slot = "24")]
		public void NNHDGPEOPNA(Entity GDNDJKDEKFN, float FIPBMGPFOAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x3859400", Offset = "0x3857C00", VA = "0x183859400", Slot = "25")]
		public float EFGGDDCNDON(Entity GDNDJKDEKFN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x385C820", Offset = "0x385B020", VA = "0x18385C820", Slot = "26")]
		public void PAJENCKLLJO(Entity GDNDJKDEKFN, Vector3 EMHGCBMDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x3858F00", Offset = "0x3857700", VA = "0x183858F00", Slot = "27")]
		public Vector3 DKPICMFFFDK(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x385AE80", Offset = "0x3859680", VA = "0x18385AE80", Slot = "32")]
		public void LJNDMBEEMDD(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x385A370", Offset = "0x3858B70", VA = "0x18385A370")]
		private void IPJHGINJJJA(Entity GDNDJKDEKFN, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x385A240", Offset = "0x3858A40", VA = "0x18385A240")]
		private void IPJHGINJJJA(Entity GDNDJKDEKFN, in Entity CKCPHJMEEKP, in Entity ILIAKNFOPLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x385C030", Offset = "0x385A830", VA = "0x18385C030")]
		private PCDMNOCOIGO OEBBAGCPONH(Entity GDNDJKDEKFN)
		{
			return default(PCDMNOCOIGO);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x385ADA0", Offset = "0x38595A0", VA = "0x18385ADA0")]
		private bool LJDKINEIEJG(Entity GDNDJKDEKFN, out Entity OJKLIAPCMPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x3859AD0", Offset = "0x38582D0", VA = "0x183859AD0")]
		private void GALCINBLNEG(Entity GDNDJKDEKFN, out Matrix4x4 CLLKBGMNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x385B540", Offset = "0x3859D40", VA = "0x18385B540")]
		public void NEDANDBJKCB(Entity GDNDJKDEKFN, out Matrix4x4 BNJEBHAJKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x385A8D0", Offset = "0x38590D0", VA = "0x18385A8D0", Slot = "29")]
		private void JLLAOIFIHPE(Entity GDNDJKDEKFN, in Matrix4x4 BBBIPBMOHOL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[OOAPDBLGMJF(typeof(MIIBEBDJOEK), new string[] { })]
public class MIIBEBDJOEK
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct GFCKMADGCLE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly MIIBEBDJOEK OJKLIAPCMPJ;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x51CCB10", Offset = "0x51CB310", VA = "0x1851CCB10")]
		public GFCKMADGCLE(MIIBEBDJOEK OJKLIAPCMPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x51CCAF0", Offset = "0x51CB2F0", VA = "0x1851CCAF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int HACCFJJFCBE;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool PKPDOGAONCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x207FE70", Offset = "0x207E670", VA = "0x18207FE70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action PELKMEHKPJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x3A9EAF0", Offset = "0x3A9D2F0", VA = "0x183A9EAF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x3A9EA20", Offset = "0x3A9D220", VA = "0x183A9EA20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A9EAC0", Offset = "0x3A9D2C0", VA = "0x183A9EAC0")]
	public GFCKMADGCLE FOEEADKNKOH()
	{
		return default(GFCKMADGCLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0xB87B10", Offset = "0xB86310", VA = "0x180B87B10")]
	public void PNODODGFGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A9EB90", Offset = "0x3A9D390", VA = "0x183A9EB90")]
	public void LNLDLKLBOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public MIIBEBDJOEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[OOAPDBLGMJF(typeof(OMCLDCKMHNM), new string[] { })]
[HCKNDCEEEAM(typeof(EKIBDKMJGBC))]
public class GNBKLCHNDHE : OMCLDCKMHNM, IDisposable, PPOEDLGAMBE, AFNLLOENMMK, DNEGIKEIIMB, PGECBFIGDKK
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class CIFIFFHJLIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public EEAJKGBJNOA services;

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public CIFIFFHJLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x51CB4C0", Offset = "0x51C9CC0", VA = "0x1851CB4C0")]
		internal void <InitReferences>b__0(DNEGIKEIIMB svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class CEOCCIOEHIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public EEAJKGBJNOA services;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public CEOCCIOEHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x51CB460", Offset = "0x51C9C60", VA = "0x1851CB460")]
		internal void <InitExternal>b__0(PGECBFIGDKK svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly JJLACLCEPON MNIOACBCBNF;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker DJFFOKLNOND;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker NNPJJADPCHC;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker DALHHBNAEAD;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly ProfilerMarker BACFCBJBEIF;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly ProfilerMarker KLCBNKJPODL;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly ProfilerMarker JDHHAOIGBKI;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly ProfilerMarker JGDBOLDGJMN;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly ProfilerMarker MEJOPPCFEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private JIGACBOPBKP EAMEDKLPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public JIGACBOPBKP LJFDDHDKJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public BJBGOMFMFBL NPECBMJOKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x123BBD0", Offset = "0x123A3D0", VA = "0x18123BBD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EntityManager FHACAKFHJON
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE900", Offset = "0x3AFD100", VA = "0x183AFE900", Slot = "9")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public OMBILBANOEN BKOIEKNNDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A60", Offset = "0x6F4260", VA = "0x1806F5A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action DONDFDGGIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE950", Offset = "0x3AFD150", VA = "0x183AFE950", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE0C0", Offset = "0x3AFC8C0", VA = "0x183AFE0C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE6E0", Offset = "0x3AFCEE0", VA = "0x183AFE6E0", Slot = "21")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x3AFEBA0", Offset = "0x3AFD3A0", VA = "0x183AFEBA0", Slot = "22")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE160", Offset = "0x3AFC960", VA = "0x183AFE160", Slot = "23")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE3F0", Offset = "0x3AFCBF0", VA = "0x183AFE3F0", Slot = "11")]
	public void DNGEACFPCPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x3AFEF50", Offset = "0x3AFD750", VA = "0x183AFEF50", Slot = "12")]
	public void OMDNOALHCJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE9F0", Offset = "0x3AFD1F0", VA = "0x183AFE9F0", Slot = "14")]
	public void JCGBBONJCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE310", Offset = "0x3AFCB10", VA = "0x183AFE310", Slot = "15")]
	public void DGLLKHNGIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE250", Offset = "0x3AFCA50", VA = "0x183AFE250", Slot = "13")]
	public void BPLDMKHFMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x3AFEE90", Offset = "0x3AFD690", VA = "0x183AFEE90", Slot = "16")]
	public void OCEBCFDMLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x3AFEDD0", Offset = "0x3AFD5D0", VA = "0x183AFEDD0", Slot = "17")]
	public void OADPHJAFBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x3AFEAB0", Offset = "0x3AFD2B0", VA = "0x183AFEAB0", Slot = "18")]
	public void KCOFLEANIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x3AFEB70", Offset = "0x3AFD370", VA = "0x183AFEB70", Slot = "19")]
	public void KDICLELKEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF010", Offset = "0x3AFD810", VA = "0x183AFF010", Slot = "24")]
	public void PPFJHNNOEMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x3AFECC0", Offset = "0x3AFD4C0", VA = "0x183AFECC0")]
	private void MFNJFAEBAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE4B0", Offset = "0x3AFCCB0", VA = "0x183AFE4B0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE3D0", Offset = "0x3AFCBD0", VA = "0x183AFE3D0", Slot = "10")]
	public ComponentSystemBase DKCDKEAINDG(Type BCFKLEGAMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE920", Offset = "0x3AFD120", VA = "0x183AFE920")]
	public bool IIBFGINLLLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public GNBKLCHNDHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class GJLKOKHONCD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly Func<From, To> KLINPOPBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly Func<To, From> AOAOCMABBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public DynamicBuffer<From> NCCOCLJLPFP;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public To ICEOJCBPDOD
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
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	public GJLKOKHONCD(Func<From, To> KLINPOPBADJ, Func<To, From> AOAOCMABBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] KPAFOBEJBIN, int MOIHFCJJBCN)
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
	public int IndexOf(To EKFBJDGFFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int MMABPPDCBIB, To EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int MMABPPDCBIB)
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
public class LINFENAKNLD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly Func<From, To> KLINPOPBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Func<To, From> AOAOCMABBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public List<From> PIJDNOPJENO;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public To ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3911DA0", Offset = "0x39105A0", VA = "0x183911DA0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x3911E00", Offset = "0x3910600", VA = "0x183911E00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x3911D70", Offset = "0x3910570", VA = "0x183911D70", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6E3880", Offset = "0x6E2080", VA = "0x1806E3880", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6E38B0", Offset = "0x6E20B0", VA = "0x1806E38B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x3911CE0", Offset = "0x39104E0", VA = "0x183911CE0")]
	public LINFENAKNLD(Func<From, To> KLINPOPBADJ, Func<To, From> AOAOCMABBCP, bool ELNPFHKAOAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x3911930", Offset = "0x3910130", VA = "0x183911930", Slot = "11")]
	public void Add(To EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x3756800", Offset = "0x3755000", VA = "0x183756800", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x3911990", Offset = "0x3910190", VA = "0x183911990", Slot = "13")]
	public bool Contains(To EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x39119F0", Offset = "0x39101F0", VA = "0x1839119F0", Slot = "14")]
	public void CopyTo(To[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x3911B00", Offset = "0x3910300", VA = "0x183911B00", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x3911B70", Offset = "0x3910370", VA = "0x183911B70", Slot = "6")]
	public int IndexOf(To EKFBJDGFFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x3911BD0", Offset = "0x39103D0", VA = "0x183911BD0", Slot = "7")]
	public void Insert(int MMABPPDCBIB, To EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x3911C80", Offset = "0x3910480", VA = "0x183911C80", Slot = "15")]
	public bool Remove(To EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x3911C50", Offset = "0x3910450", VA = "0x183911C50", Slot = "8")]
	public void RemoveAt(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x34C4D90", Offset = "0x34C3590", VA = "0x1834C4D90", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class BHJPHCDHIBJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Func<From, To> KLINPOPBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Func<To, From> AOAOCMABBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<From> KPAFOBEJBIN;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public To ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x3662940", Offset = "0x3661140", VA = "0x183662940", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x3662990", Offset = "0x3661190", VA = "0x183662990", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x3662900", Offset = "0x3661100", VA = "0x183662900", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x76F270", Offset = "0x76DA70", VA = "0x18076F270", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2FC9600", Offset = "0x2FC7E00", VA = "0x182FC9600")]
	public BHJPHCDHIBJ(Func<From, To> KLINPOPBADJ, Func<To, From> AOAOCMABBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3662510", Offset = "0x3660D10", VA = "0x183662510", Slot = "11")]
	public void Add(To EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x3662550", Offset = "0x3660D50", VA = "0x183662550", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x3662590", Offset = "0x3660D90", VA = "0x183662590", Slot = "13")]
	public bool Contains(To EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x3662650", Offset = "0x3660E50", VA = "0x183662650", Slot = "14")]
	public void CopyTo(To[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x3662710", Offset = "0x3660F10", VA = "0x183662710", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x36627D0", Offset = "0x3660FD0", VA = "0x1836627D0", Slot = "6")]
	public int IndexOf(To EKFBJDGFFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x3662840", Offset = "0x3661040", VA = "0x183662840", Slot = "7")]
	public void Insert(int MMABPPDCBIB, To EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x36628C0", Offset = "0x36610C0", VA = "0x1836628C0", Slot = "15")]
	public bool Remove(To EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x3662880", Offset = "0x3661080", VA = "0x183662880", Slot = "8")]
	public void RemoveAt(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2EED650", Offset = "0x2EEBE50", VA = "0x182EED650", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public class NKAJCKCMJDD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly Func<From, To> KLINPOPBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Func<To, From> AOAOCMABBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeList<From> PIJDNOPJENO;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public To ICEOJCBPDOD
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
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	public NKAJCKCMJDD(Func<From, To> KLINPOPBADJ, Func<To, From> AOAOCMABBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] KPAFOBEJBIN, int MOIHFCJJBCN)
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
	public int IndexOf(To EKFBJDGFFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int MMABPPDCBIB, To EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int MMABPPDCBIB)
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
public static class FIDAGHBFIPM
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public const string EGGBBJLHAOF = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public const string OBECBPDOCIC = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const string IFCLNNOBGCO = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public const string FCNBODIJKHB = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public const string NPOCNGNIGMH = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public const string MAIIAHHPPLA = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public const string JCELCHAHFJO = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class LEKGLGPCFDG
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class DGNEMCCNDNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public EEAJKGBJNOA services;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public DGNEMCCNDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x51CB960", Offset = "0x51CA160", VA = "0x1851CB960")]
		internal void <InitServices>b__1(DNEGIKEIIMB svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x51CB9C0", Offset = "0x51CA1C0", VA = "0x1851CB9C0")]
		internal void <InitServices>b__2(PGECBFIGDKK svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BE30", Offset = "0x3A9A630", VA = "0x183A9BE30")]
	public static void AHDIHFIOOCJ(this JIGACBOPBKP EAMEDKLPJKC, EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D700", Offset = "0x2E2BF00", VA = "0x182E2D700")]
	public static void BKDJGJBNENH<T>(this JIGACBOPBKP EAMEDKLPJKC, Action<T> CIJADOGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D560", Offset = "0x2E2BD60", VA = "0x182E2D560")]
	public static void ALNKDAFBNBE<T>(this JIGACBOPBKP EAMEDKLPJKC, Action<T> CIJADOGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D830", Offset = "0x2E2C030", VA = "0x182E2D830")]
	public static void DKMIPLJLLPP<T>(this JIGACBOPBKP EAMEDKLPJKC, Action<T> CIJADOGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x2E2DB90", Offset = "0x2E2C390", VA = "0x182E2DB90")]
	public static void MMNGMBLKFPL<T>(this JIGACBOPBKP EAMEDKLPJKC, Action<T> CIJADOGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D9E0", Offset = "0x2E2C1E0", VA = "0x182E2D9E0")]
	public static void EFAPDKJCHBB<T>(this JIGACBOPBKP EAMEDKLPJKC, Action<T> CIJADOGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x2E2D770", Offset = "0x2E2BF70", VA = "0x182E2D770")]
	private static void CEPCDLHOKFJ<T>(object HMIDBHHAMPJ, Action<T> CIJADOGNAEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class GKAFBIHCHFN
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class KNOKOBHLFHC
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	public static bool IEJEPDBIIFG<T>(ref T DOGOAAONBOH, ref T ENHIJCCJFBF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class DNLNEKGGGNG
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class DMFLIOOPGLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public DMFLIOOPGLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1C70", Offset = "0x3AF0470", VA = "0x183AF1C70")]
	public static string IKINBDFAODJ(Transform JDMGKLHBDHC, Transform MJPNNJLLLLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class HLIHHNELGOP : PHGLGJMJAAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly MethodInfo JBDIJCKKIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Type[] GOLEKIJBOAN;

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x3A944E0", Offset = "0x3A92CE0", VA = "0x183A944E0")]
	public HLIHHNELGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action IAGKKNDMOKL();

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x3A942F0", Offset = "0x3A92AF0", VA = "0x183A942F0")]
	public MethodInfo BCFBPPCNIEO(Action NCHNGIGODJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x3A94330", Offset = "0x3A92B30", VA = "0x183A94330", Slot = "4")]
	public void IIGIGLNPDMN(Type BCFKLEGAMEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public abstract class NFBLMBAAGNP : HLIHHNELGOP
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private enum AFJPOODHPKD
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2660", Offset = "0x3AA0E60", VA = "0x183AA2660", Slot = "5")]
	public override Action IAGKKNDMOKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void KFEMFEHPLAF<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x3AA26F0", Offset = "0x3AA0EF0", VA = "0x183AA26F0")]
	[Preserve]
	public void ICJOIIDHCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B4B0", Offset = "0x3A99CB0", VA = "0x183A9B4B0")]
	protected NFBLMBAAGNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class MKOPABNCOHI : HLIHHNELGOP
{
	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x3A9FA50", Offset = "0x3A9E250", VA = "0x183A9FA50", Slot = "5")]
	public override Action IAGKKNDMOKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void BNDCBOEANAJ<T>() where T : JAPJBKCPIOB;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x3A9FAE0", Offset = "0x3A9E2E0", VA = "0x183A9FAE0")]
	[Preserve]
	public void ICJOIIDHCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B4B0", Offset = "0x3A99CB0", VA = "0x183A9B4B0")]
	protected MKOPABNCOHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class KOGLBOKFCDI : HLIHHNELGOP
{
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B390", Offset = "0x3A99B90", VA = "0x183A9B390", Slot = "5")]
	public override Action IAGKKNDMOKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void PDGBFFBPGEF<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B420", Offset = "0x3A99C20", VA = "0x183A9B420")]
	[Preserve]
	public void ICJOIIDHCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B4B0", Offset = "0x3A99CB0", VA = "0x183A9B4B0")]
	protected KOGLBOKFCDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[OOAPDBLGMJF(typeof(OMBILBANOEN), new string[] { })]
public class PKOKKKOPPNK : DMHIFFKBAEI, OMBILBANOEN
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public EEAJKGBJNOA MOCCPLHNPLK
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8060", Offset = "0x6F6860", VA = "0x1806F8060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public HBIJPHJPPAA COEFAKNIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5010", Offset = "0x6F3810", VA = "0x1806F5010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public OMCLDCKMHNM LJFDDHDKJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x6E3870", Offset = "0x6E2070", VA = "0x1806E3870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public JLKICMMDFEF FDJIEGNOFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A60", Offset = "0x6F4260", VA = "0x1806F5A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public EKIBDKMJGBC EOGADIBFGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B40", Offset = "0x6F4340", VA = "0x1806F5B40", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A70", Offset = "0x6F4270", VA = "0x1806F5A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public NCNJODMFFIF PJKMGICLPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x726A30", Offset = "0x725230", VA = "0x180726A30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x726A50", Offset = "0x725250", VA = "0x180726A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public HCGMPCJKLOI DGFBLHPCMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x746CE0", Offset = "0x7454E0", VA = "0x180746CE0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x74A6B0", Offset = "0x748EB0", VA = "0x18074A6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IACMPOBAJCP BMOFKAEBDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x72D250", Offset = "0x72BA50", VA = "0x18072D250", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x72D2B0", Offset = "0x72BAB0", VA = "0x18072D2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public KAOEDAJOEMH CGJIJDPKADF
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x72D290", Offset = "0x72BA90", VA = "0x18072D290", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x72D300", Offset = "0x72BB00", VA = "0x18072D300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public NOCGABKMADN FCLJFANGHHH
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x74A670", Offset = "0x748E70", VA = "0x18074A670", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x857960", Offset = "0x856160", VA = "0x180857960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public NHBLKFLNCCJ FINIDPHNNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x74A6C0", Offset = "0x748EC0", VA = "0x18074A6C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x77BC30", Offset = "0x77A430", VA = "0x18077BC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public NJFOAABDNKO HCGNKDEPDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x8323D0", Offset = "0x830BD0", VA = "0x1808323D0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x8BECB0", Offset = "0x8BD4B0", VA = "0x1808BECB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public KENINKEKDMC JDAJMLPLHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x70D390", Offset = "0x70BB90", VA = "0x18070D390", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x9557B0", Offset = "0x953FB0", VA = "0x1809557B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LINPFIEIHLN MHLHNIJKIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x799E10", VA = "0x18079B610", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x872030", Offset = "0x870830", VA = "0x180872030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public LLNLFBIJEEI IPAILOOANFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x746D00", Offset = "0x745500", VA = "0x180746D00", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x746C80", Offset = "0x745480", VA = "0x180746C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public KGMAJJBPDAG MFPOBIMPBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x7EE390", Offset = "0x7ECB90", VA = "0x1807EE390", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x872A20", Offset = "0x871220", VA = "0x180872A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public NJMMPJDFPHF JFNBHBPHAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x85E8F0", Offset = "0x85D0F0", VA = "0x18085E8F0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x9829A0", Offset = "0x9811A0", VA = "0x1809829A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public CANGMNNAPBN CMLMBGKFDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x76CBD0", Offset = "0x76B3D0", VA = "0x18076CBD0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x76CC90", Offset = "0x76B490", VA = "0x18076CC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public KFOLAMOKFLP ENEPBFJBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x8323E0", Offset = "0x830BE0", VA = "0x1808323E0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x964CE0", Offset = "0x9634E0", VA = "0x180964CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public IMBFPFHIPDB ACNOJBHFKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6F9480", Offset = "0x6F7C80", VA = "0x1806F9480", Slot = "4")]
		get
		{
			return default(IMBFPFHIPDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2B70", Offset = "0x3AB1370", VA = "0x183AB2B70", Slot = "5")]
	public void PGJAPBHHKEM(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public PKOKKKOPPNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
public class MJCBMJEHEKD : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class GOOBIHCBBJC : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public MJCBMJEHEKD <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7CB550", Offset = "0x7C9D50", VA = "0x1807CB550", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x51CD530", Offset = "0x51CBD30", VA = "0x1851CD530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
		[DebuggerHidden]
		public GOOBIHCBBJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x51CD380", Offset = "0x51CBB80", VA = "0x1851CD380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x51CD4F0", Offset = "0x51CBCF0", VA = "0x1851CD4F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400018D")]
	protected const ulong PIHHFIDHEFD = 1uL;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	protected const ulong IPLACEDCFOE = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	protected const int KOPHEBLGKFB = 8;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	protected const int FAPEJLEICEC = 6;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int LLCOMHHFHFK = 64;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	protected const int PADKINIIONG = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly List<ulong> DBEFFMIPBML;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x671690", Offset = "0x66FE90", VA = "0x180671690")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x671680", Offset = "0x66FE80", VA = "0x180671680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public int FMCIMBNBALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x800780", Offset = "0x7FEF80", VA = "0x180800780")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x8CD0A0", Offset = "0x8CB8A0", VA = "0x1808CD0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x3A9F5D0", Offset = "0x3A9DDD0", VA = "0x183A9F5D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x3A9ED80", Offset = "0x3A9D580", VA = "0x183A9ED80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F9D0", Offset = "0x3A9E1D0", VA = "0x183A9F9D0")]
	public MJCBMJEHEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F940", Offset = "0x3A9E140", VA = "0x183A9F940")]
	public MJCBMJEHEKD(int DNLGEKMDGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F4F0", Offset = "0x3A9DCF0", VA = "0x183A9F4F0")]
	public bool LMNLKCIJIFK(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F670", Offset = "0x3A9DE70", VA = "0x183A9F670")]
	public bool MJBNFPBGOAF(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F350", Offset = "0x3A9DB50", VA = "0x183A9F350")]
	public bool JBMMPEHBECB(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F020", Offset = "0x3A9D820", VA = "0x183A9F020")]
	public bool DPHKGIJFNKP(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9ECF0", Offset = "0x3A9D4F0", VA = "0x183A9ECF0")]
	public void CLABMKNNEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F1F0", Offset = "0x3A9D9F0", VA = "0x183A9F1F0")]
	public void FCMHKLCBIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x3A9EF30", Offset = "0x3A9D730", VA = "0x183A9EF30")]
	public void DIMECELKFHA(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F760", Offset = "0x3A9DF60", VA = "0x183A9F760")]
	public void OJEEPLKEKIC(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F8B0", Offset = "0x3A9E0B0", VA = "0x183A9F8B0")]
	public bool ONOFBPEKJJJ(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F3D0", Offset = "0x3A9DBD0", VA = "0x183A9F3D0")]
	public void KOLCGGBJAIH(int EGBIMJLECFF, int LGKBEOCJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F030", Offset = "0x3A9D830", VA = "0x183A9F030")]
	public void FALABANDKPD(int PJLFEJFCFBB, int CKCMLJGEIGK, int LGKBEOCJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x3A9EBB0", Offset = "0x3A9D3B0", VA = "0x183A9EBB0")]
	public int CEMPCIEDPMO(int LGKBEOCJMLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x3A9EC80", Offset = "0x3A9D480", VA = "0x183A9EC80")]
	public int CEMPCIEDPMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F860", Offset = "0x3A9E060", VA = "0x183A9F860")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F2E0", Offset = "0x3A9DAE0", VA = "0x183A9F2E0", Slot = "4")]
	[IteratorStateMachine(typeof(GOOBIHCBBJC))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F2E0", Offset = "0x3A9DAE0", VA = "0x183A9F2E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class IDLHPCIHGLB<T> : global::LCANCFBJDFM<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	protected global::LMEAOAOKCKJ<T> JAKCIDHCLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	protected global::BAIJIAKBDCD<T> JPBCHOPICMD;

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x26B3840", Offset = "0x26B2040", VA = "0x1826B3840")]
	public IDLHPCIHGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B610", Offset = "0x2B29E10", VA = "0x182B2B610")]
	public IDLHPCIHGLB(global::LMEAOAOKCKJ<T> JAKCIDHCLFK, global::BAIJIAKBDCD<T> JPBCHOPICMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x2B2AF20", Offset = "0x2B29720", VA = "0x182B2AF20", Slot = "11")]
	public override T ADHMOLAJGDE(GMABBDHCMBI IJENJGNEIAC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B2B260", Offset = "0x2B29A60", VA = "0x182B2B260", Slot = "12")]
	public override void HHDOHEHKDKI(GMABBDHCMBI IJENJGNEIAC, T CCIMHDCKHOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class PGODMHHFMGG
{
	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x3970220", Offset = "0x396EA20", VA = "0x183970220")]
	public static FHCGLCCCIJI IIGIGLNPDMN<T>(this AMLOIBNNKBM IEBMFIFBGIK, global::JHOLIPIPHIK<T> FOGNBJMCDMG, global::LMEAOAOKCKJ<T> JAKCIDHCLFK, global::BAIJIAKBDCD<T> JPBCHOPICMD) where T : struct
	{
		return default(FHCGLCCCIJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class LJCCBNLHHPD<T> : global::IDLHPCIHGLB<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x3911F60", Offset = "0x3910760", VA = "0x183911F60")]
	public LJCCBNLHHPD(T BNIGPLBPEGC, T EJIIEDBELNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class AKOOFKKCKCP<T> : global::LCANCFBJDFM<T> where T : struct, JAPJBKCPIOB
{
	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x3ED13C0", Offset = "0x3ECFBC0", VA = "0x183ED13C0", Slot = "11")]
	public override T ADHMOLAJGDE(GMABBDHCMBI IJENJGNEIAC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1450", Offset = "0x3ECFC50", VA = "0x183ED1450", Slot = "12")]
	public override void HHDOHEHKDKI(GMABBDHCMBI IJENJGNEIAC, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x329E290", Offset = "0x329CA90", VA = "0x18329E290")]
	public AKOOFKKCKCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class GOODOEBOBPJ : KIMJPFDBIKK
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public abstract Type KCGKFIIHNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void ADHMOLAJGDE(GMABBDHCMBI IJENJGNEIAC, in PEOLEOJFANL CCIMHDCKHOF);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void HHDOHEHKDKI(GMABBDHCMBI IJENJGNEIAC, in IKKMGBAJNEB CCIMHDCKHOF);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void ENNFCPGKJEH(GMABBDHCMBI IJENJGNEIAC, DNKDFNNFDHL EDJDHHEMACF, [Optional] object IGBOEABBEHO);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	protected GOODOEBOBPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class LCANCFBJDFM<T> : GOODOEBOBPJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public override Type KCGKFIIHNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x38FA660", Offset = "0x38F8E60", VA = "0x1838FA660", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T ADHMOLAJGDE(GMABBDHCMBI IJENJGNEIAC);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void HHDOHEHKDKI(GMABBDHCMBI IJENJGNEIAC, T CCIMHDCKHOF);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x38F85F0", Offset = "0x38F6DF0", VA = "0x1838F85F0", Slot = "8")]
	public override void ADHMOLAJGDE(GMABBDHCMBI IJENJGNEIAC, in PEOLEOJFANL MJPNNJLLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x38F9FB0", Offset = "0x38F87B0", VA = "0x1838F9FB0", Slot = "9")]
	public override void HHDOHEHKDKI(GMABBDHCMBI IJENJGNEIAC, in IKKMGBAJNEB LENKHFNFMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x38F9280", Offset = "0x38F7A80", VA = "0x1838F9280", Slot = "10")]
	public override void ENNFCPGKJEH(GMABBDHCMBI IJENJGNEIAC, DNKDFNNFDHL EDJDHHEMACF, object IGBOEABBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x2FD7A60", Offset = "0x2FD6260", VA = "0x182FD7A60")]
	protected LCANCFBJDFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class GJLOEFMFFMK
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class NOFCHFMAEFP
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class JFBLFJGJGJE<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
			public JFBLFJGJGJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x32AE7D0", Offset = "0x32ACFD0", VA = "0x1832AE7D0")]
			internal void <RegisterFixedString>b__0(GMABBDHCMBI p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x32AEAE0", Offset = "0x32AD2E0", VA = "0x1832AEAE0")]
			internal T <RegisterFixedString>b__1(GMABBDHCMBI p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x51D0D10", Offset = "0x51CF510", VA = "0x1851D0D10")]
		public static void DKKDLLIOCBN(FKGGHHOKMHE BOPHPJCPNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D3DB50", Offset = "0x3D3C350", VA = "0x183D3DB50")]
		private static void ABEPHILKAKB<T>(FKGGHHOKMHE BOPHPJCPNOG, int EJIIEDBELNE) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D3E2C0", Offset = "0x3D3CAC0", VA = "0x183D3E2C0")]
		private static void ODGFNMIDMKG<T>(GMABBDHCMBI OGGODOHJPHN, T DCNCBDGEKMD, int EJIIEDBELNE) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D3DC70", Offset = "0x3D3C470", VA = "0x183D3DC70")]
		private static T AGEMIDABIDO<T>(GMABBDHCMBI OGGODOHJPHN, int EJIIEDBELNE) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public NOFCHFMAEFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class CCFPDJFLPFB : NFBLMBAAGNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private FKGGHHOKMHE BOPHPJCPNOG;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EF20", Offset = "0x3D2D720", VA = "0x183D2EF20", Slot = "6")]
		public override void KFEMFEHPLAF<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x38456C0", Offset = "0x3843EC0", VA = "0x1838456C0")]
		public static void FOOABLPAIEK(FKGGHHOKMHE BOPHPJCPNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x3845750", Offset = "0x3843F50", VA = "0x183845750")]
		public CCFPDJFLPFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AFAF80", Offset = "0x3AF9780", VA = "0x183AFAF80")]
	public static void FKIDKGJAAHO(FKGGHHOKMHE BOPHPJCPNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C740", Offset = "0x2E9AF40", VA = "0x182E9C740")]
	public static void JLKOILALNGO<T>(FKGGHHOKMHE BOPHPJCPNOG, global::LMEAOAOKCKJ<T> JAKCIDHCLFK, global::BAIJIAKBDCD<T> JPBCHOPICMD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x2E9C7D0", Offset = "0x2E9AFD0", VA = "0x182E9C7D0")]
	public static void OCJFKAMGOAM<T>(FKGGHHOKMHE PKCBLFIFNIL) where T : struct, JAPJBKCPIOB
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface FKGGHHOKMHE : global::ENDJOKBLCCO<FKGGHHOKMHE>
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIGIGLNPDMN(Type BCFKLEGAMEO, KIMJPFDBIKK PKCBLFIFNIL);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFJHFJBDKOG(Type BCFKLEGAMEO, out KIMJPFDBIKK PKCBLFIFNIL);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class BJMJBNMMAOB
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7F80", Offset = "0x3AE6780", VA = "0x183AE7F80")]
	public static void IIGIGLNPDMN(this FKGGHHOKMHE GJMHFONGMCN, KIMJPFDBIKK PKCBLFIFNIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[OOAPDBLGMJF(typeof(AMLOIBNNKBM), new string[] { })]
public sealed class NOKPJGEBACA : AMLOIBNNKBM, global::ENDJOKBLCCO<AMLOIBNNKBM>, AFNLLOENMMK, DNEGIKEIIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly Dictionary<FHCGLCCCIJI, KIMJPFDBIKK> BOPHPJCPNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private FKGGHHOKMHE NOIDOEALGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private FMFHLBFGHJI IEBMFIFBGIK;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool LFLFHNJKCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x6E3880", Offset = "0x6E2080", VA = "0x1806E3880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x6E38B0", Offset = "0x6E20B0", VA = "0x1806E38B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3700", Offset = "0x3AA1F00", VA = "0x183AA3700")]
	public NOKPJGEBACA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3640", Offset = "0x3AA1E40", VA = "0x183AA3640")]
	public NOKPJGEBACA(Dictionary<FHCGLCCCIJI, KIMJPFDBIKK> BOPHPJCPNOG, bool MDFFJMMCBJO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2F00", Offset = "0x3AA1700", VA = "0x183AA2F00", Slot = "7")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3280", Offset = "0x3AA1A80", VA = "0x183AA3280", Slot = "8")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x3AA35F0", Offset = "0x3AA1DF0", VA = "0x183AA35F0", Slot = "9")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3040", Offset = "0x3AA1840", VA = "0x183AA3040", Slot = "4")]
	public FHCGLCCCIJI GPBGCLPEPLP(FAMLDGNAFHF FOGNBJMCDMG)
	{
		return default(FHCGLCCCIJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3110", Offset = "0x3AA1910", VA = "0x183AA3110", Slot = "5")]
	public void IIGIGLNPDMN(FHCGLCCCIJI DGFBLJMJMFI, KIMJPFDBIKK PKCBLFIFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x3AA34B0", Offset = "0x3AA1CB0", VA = "0x183AA34B0")]
	[Conditional("DEBUG_BUILD")]
	private void NOIEGBPHINC(FHCGLCCCIJI DGFBLJMJMFI, Type BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x3AA3300", Offset = "0x3AA1B00", VA = "0x183AA3300", Slot = "6")]
	public bool MFJHFJBDKOG(FHCGLCCCIJI DGFBLJMJMFI, out KIMJPFDBIKK PKCBLFIFNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2F60", Offset = "0x3AA1760", VA = "0x183AA2F60", Slot = "10")]
	public AMLOIBNNKBM GKCOKIFKCME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[OOAPDBLGMJF(typeof(FKGGHHOKMHE), new string[] { })]
public sealed class HFCMFPPJFIH : AFNLLOENMMK, FKGGHHOKMHE, global::ENDJOKBLCCO<FKGGHHOKMHE>
{
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly JJLACLCEPON MNIOACBCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly Dictionary<Type, KIMJPFDBIKK> BOPHPJCPNOG;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool LFLFHNJKCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x6FD700", Offset = "0x6FBF00", VA = "0x1806FD700")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x6FDC20", Offset = "0x6FC420", VA = "0x1806FDC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B008E0", Offset = "0x3AFF0E0", VA = "0x183B008E0")]
	public HFCMFPPJFIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B00820", Offset = "0x3AFF020", VA = "0x183B00820")]
	public HFCMFPPJFIH(Dictionary<Type, KIMJPFDBIKK> BOPHPJCPNOG, bool MDFFJMMCBJO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x3B004A0", Offset = "0x3AFECA0", VA = "0x183B004A0", Slot = "4")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x3B005E0", Offset = "0x3AFEDE0", VA = "0x183B005E0", Slot = "5")]
	public void IIGIGLNPDMN(Type BCFKLEGAMEO, KIMJPFDBIKK PKCBLFIFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x3B00700", Offset = "0x3AFEF00", VA = "0x183B00700", Slot = "6")]
	public bool MFJHFJBDKOG(Type BCFKLEGAMEO, out KIMJPFDBIKK PKCBLFIFNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x3B00500", Offset = "0x3AFED00", VA = "0x183B00500", Slot = "7")]
	public FKGGHHOKMHE GKCOKIFKCME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[OOAPDBLGMJF(typeof(BOHHBKBJKHC), new string[] { })]
internal sealed class JEKPNGJJHPF : BOHHBKBJKHC, AFNLLOENMMK, DNEGIKEIIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly Dictionary<FHCGLCCCIJI, DHLGGLGOCCP> AGNCBHOBAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private FMFHLBFGHJI IEBMFIFBGIK;

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A98870", Offset = "0x3A97070", VA = "0x183A98870", Slot = "6")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x3A989A0", Offset = "0x3A971A0", VA = "0x183A989A0", Slot = "7")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x3A988C0", Offset = "0x3A970C0", VA = "0x183A988C0", Slot = "4")]
	public void IIGIGLNPDMN(FHCGLCCCIJI LKIMNIMPHKB, Type HABCDENGGON, DHLGGLGOCCP ILPODOBHFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x3A98930", Offset = "0x3A97130", VA = "0x183A98930", Slot = "5")]
	public bool JHNINJDPLIP(FHCGLCCCIJI LKIMNIMPHKB, out DHLGGLGOCCP ILPODOBHFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x3A98A00", Offset = "0x3A97200", VA = "0x183A98A00")]
	[Conditional("DEBUG_BUILD")]
	private void PAKPPEDCPEK(FHCGLCCCIJI LKIMNIMPHKB, Type HABCDENGGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x3A98B90", Offset = "0x3A97390", VA = "0x183A98B90")]
	public JEKPNGJJHPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[HCKNDCEEEAM(typeof(FMFHLBFGHJI))]
[OOAPDBLGMJF(typeof(EIGEODJOOFL), new string[] { })]
internal sealed class OJPCPFOOMFK : EIGEODJOOFL, PPOEDLGAMBE, AFNLLOENMMK, DNEGIKEIIMB, PGECBFIGDKK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly MJCBMJEHEKD IJJNPEHPMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly Dictionary<DDAOHKAFOIC, int> CBJJFCJCGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Stack<int> JOLIJECAEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private FMFHLBFGHJI IEBMFIFBGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private NCNJODMFFIF JHCECLNHNEJ;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private int BMJFFBFFGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x3AA6C60", Offset = "0x3AA5460", VA = "0x183AA6C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool EHHPFKGKIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB30", Offset = "0x6F9330", VA = "0x1806FAB30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6FB050", Offset = "0x6F9850", VA = "0x1806FB050", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6B20", Offset = "0x3AA5320", VA = "0x183AA6B20", Slot = "6")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6D50", Offset = "0x3AA5550", VA = "0x183AA6D50", Slot = "7")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6A70", Offset = "0x3AA5270", VA = "0x183AA6A70", Slot = "8")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6CB0", Offset = "0x3AA54B0", VA = "0x183AA6CB0")]
	private void KHHFONDHJBM(IOFHLMDPEAL CPBDAEHELGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7120", Offset = "0x3AA5920", VA = "0x183AA7120", Slot = "4")]
	public bool ONABLOEHPAF(DDAOHKAFOIC LNNGKIMHKAI, FHCGLCCCIJI MIGODNJAHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6DD0", Offset = "0x3AA55D0", VA = "0x183AA6DD0", Slot = "5")]
	public void LKJKJFKLGID(DDAOHKAFOIC LNNGKIMHKAI, Span<FHCGLCCCIJI> IEBMFIFBGIK, bool GAJCGAEIAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6B20", Offset = "0x3AA5320", VA = "0x183AA6B20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7220", Offset = "0x3AA5A20", VA = "0x183AA7220")]
	public OJPCPFOOMFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class LENJPLLCJCG
{
	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C4B0", Offset = "0x3A9ACB0", VA = "0x183A9C4B0")]
	public static void BDABGCPMMHD(this GMABBDHCMBI IJENJGNEIAC, ReadOnlyMemory<byte> KPKAPHOMBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2E2DD40", Offset = "0x2E2C540", VA = "0x182E2DD40")]
	public static void EPOIFDELDCH<T>(this GMABBDHCMBI IJENJGNEIAC, in T CCIMHDCKHOF) where T : struct, JAPJBKCPIOB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x2E2DE40", Offset = "0x2E2C640", VA = "0x182E2DE40")]
	public static T NMEPGOOIINA<T>(this GMABBDHCMBI IJENJGNEIAC) where T : struct, JAPJBKCPIOB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C560", Offset = "0x3A9AD60", VA = "0x183A9C560")]
	public static void EPOIFDELDCH(this GMABBDHCMBI IJENJGNEIAC, EEAMIIEHJFA GKBNIMHPHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C530", Offset = "0x3A9AD30", VA = "0x183A9C530")]
	public static EEAMIIEHJFA DADDPBFCPPD(this GMABBDHCMBI IJENJGNEIAC)
	{
		return default(EEAMIIEHJFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C6B0", Offset = "0x3A9AEB0", VA = "0x183A9C6B0")]
	public static void HGIGDCNEBAD(this GMABBDHCMBI FBNHINKPMEA, uint PCLONCFBJBB, bool PFMEEDNEAAM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x3A9C590", Offset = "0x3A9AD90", VA = "0x183A9C590")]
	public static uint GACNNCIHGGA(this GMABBDHCMBI CLOGDHPGNHC, bool PFMEEDNEAAM = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class JGCIJFAOBPE
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class PMKECBJMGJA<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public PMKECBJMGJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x3418EC0", Offset = "0x34176C0", VA = "0x183418EC0")]
		internal void <GetByteEnumDelegates>b__0(GMABBDHCMBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x3418F30", Offset = "0x3417730", VA = "0x183418F30")]
		internal T <GetByteEnumDelegates>b__1(GMABBDHCMBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class FOOPHNEALDB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public FOOPHNEALDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x3D82220", Offset = "0x3D80A20", VA = "0x183D82220")]
		internal void <GetSByteEnumDelegates>b__0(GMABBDHCMBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x3D82290", Offset = "0x3D80A90", VA = "0x183D82290")]
		internal T <GetSByteEnumDelegates>b__1(GMABBDHCMBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class MODDOCAEIJI<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public MODDOCAEIJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x38870F0", Offset = "0x38858F0", VA = "0x1838870F0")]
		internal void <GetShortEnumDelegates>b__0(GMABBDHCMBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x3887160", Offset = "0x3885960", VA = "0x183887160")]
		internal T <GetShortEnumDelegates>b__1(GMABBDHCMBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class LNLDOPJMIIG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public LNLDOPJMIIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x375C6C0", Offset = "0x375AEC0", VA = "0x18375C6C0")]
		internal void <GetUShortEnumDelegates>b__0(GMABBDHCMBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x375C730", Offset = "0x375AF30", VA = "0x18375C730")]
		internal T <GetUShortEnumDelegates>b__1(GMABBDHCMBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class IGEANHAAAON<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public IGEANHAAAON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D690", Offset = "0x2B2BE90", VA = "0x182B2D690")]
		internal void <GetIntEnumDelegates>b__0(GMABBDHCMBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x2B2D6F0", Offset = "0x2B2BEF0", VA = "0x182B2D6F0")]
		internal T <GetIntEnumDelegates>b__1(GMABBDHCMBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class NGGIPKOMDBO<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
		public NGGIPKOMDBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x32E1470", Offset = "0x32DFC70", VA = "0x1832E1470")]
		internal void <GetUIntEnumDelegates>b__0(GMABBDHCMBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x32E14D0", Offset = "0x32DFCD0", VA = "0x1832E14D0")]
		internal T <GetUIntEnumDelegates>b__1(GMABBDHCMBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x2E135C0", Offset = "0x2E11DC0", VA = "0x182E135C0")]
	public static void OCHFHJDCICI<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2E13320", Offset = "0x2E11B20", VA = "0x182E13320")]
	private static void KDKOEEFADCG<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x2E13320", Offset = "0x2E11B20", VA = "0x182E13320")]
	private static void FDJOOFAKPEF<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x2E131D0", Offset = "0x2E119D0", VA = "0x182E131D0")]
	private static void CJLKKOMLOCM<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x2E131D0", Offset = "0x2E119D0", VA = "0x182E131D0")]
	private static void NIMCEKPBEMH<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x2E13470", Offset = "0x2E11C70", VA = "0x182E13470")]
	private static void KFLCHLLEPEJ<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x2E13470", Offset = "0x2E11C70", VA = "0x182E13470")]
	private static void OKLBFEPIGEO<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public abstract class JAOBCHLEKPG : APKLEDPALBD, PGECBFIGDKK
{
	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x3A98750", Offset = "0x3A96F50", VA = "0x183A98750", Slot = "4")]
	private void DIJCJEDHHPA(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void ADHIFDAJFNB(AMLOIBNNKBM IEBMFIFBGIK);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0")]
	protected JAOBCHLEKPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[APCNEFCKKAN(typeof(LocalPoseData))]
public sealed class EDDMAMANBLL : JAOBCHLEKPG
{
	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x3AF4FB0", Offset = "0x3AF37B0", VA = "0x183AF4FB0", Slot = "5")]
	protected override void ADHIFDAJFNB(AMLOIBNNKBM IEBMFIFBGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960")]
	public EDDMAMANBLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[InternalBufferCapacity(1)]
internal struct BLECMCBOLCB : ISystemStateBufferElementData, IBufferElementData, IEquatable<BLECMCBOLCB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public FGGNGNPKIFF BLIPNDKFLPL;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8080", Offset = "0x3AE6880", VA = "0x183AE8080", Slot = "4")]
	public bool Equals(BLECMCBOLCB IIKMMJKCGDO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x722C40", Offset = "0x721440", VA = "0x180722C40")]
	public static BLECMCBOLCB EDIIAGKPKGG(FGGNGNPKIFF BLIPNDKFLPL)
	{
		return default(BLECMCBOLCB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[InternalBufferCapacity(4)]
internal struct DNKDBOAOIFO : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public FGGNGNPKIFF BLIPNDKFLPL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x722C40", Offset = "0x721440", VA = "0x180722C40")]
	public static DNKDBOAOIFO EDIIAGKPKGG(FGGNGNPKIFF BLIPNDKFLPL)
	{
		return default(DNKDBOAOIFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
internal struct FGGNGNPKIFF : global::KIMFBICNHMN<FGGNGNPKIFF>, EKJNBJHBEDB, IEquatable<FGGNGNPKIFF>
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public int DCEMEBHPCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x79B630", Offset = "0x799E30", VA = "0x18079B630", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x79CEA0", Offset = "0x79B6A0", VA = "0x18079CEA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7F76F0", Offset = "0x7F5EF0", VA = "0x1807F76F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x7F7700", Offset = "0x7F5F00", VA = "0x1807F7700", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x3AFA5A0", Offset = "0x3AF8DA0", VA = "0x183AFA5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8080", Offset = "0x3AE6880", VA = "0x183AE8080", Slot = "8")]
	public bool Equals(FGGNGNPKIFF IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA5E0", Offset = "0x3AF8DE0", VA = "0x183AFA5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class LLLHPDILIMK : ParentSystemBase<AuthoredParentData, HDODHPJEEDH, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D7B0", Offset = "0x3A9BFB0", VA = "0x183A9D7B0", Slot = "14")]
	protected override EntityQueryDesc HNGMCOJHLNH(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0xA1E020", Offset = "0xA1C820", VA = "0x180A1E020", Slot = "15")]
	protected override EntityQueryDesc CPFDHCLBLCN(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D770", Offset = "0x3A9BF70", VA = "0x183A9D770", Slot = "16")]
	protected override EntityQueryDesc GNOHAGLAAJO(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D730", Offset = "0x3A9BF30", VA = "0x183A9D730", Slot = "17")]
	protected override EntityQueryDesc ECDEGGLBPCN(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D830", Offset = "0x3A9C030", VA = "0x183A9D830")]
	public LLLHPDILIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D7F0", Offset = "0x3A9BFF0", VA = "0x183A9D7F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Connectables)]
	public class UpdateConnectableVisuals : NKMCJEEJMOK, DNEGIKEIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		private struct OKLLPMCJCEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public FGGNGNPKIFF BLIPNDKFLPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public float3 LPADDFNBONE;

			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x51D1E10", Offset = "0x51D0610", VA = "0x1851D1E10")]
			public OKLLPMCJCEG(FGGNGNPKIFF BLIPNDKFLPL, float3 LPADDFNBONE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x51D1DF0", Offset = "0x51D05F0", VA = "0x1851D1DF0")]
			public void DDACMMPHEGD(out FGGNGNPKIFF BLIPNDKFLPL, out float3 LPADDFNBONE)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private struct KGPLBAEGFBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public NativeList<OKLLPMCJCEG> list;

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
			public KGPLBAEGFBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<DNKDBOAOIFO> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private struct CDGKCHDIMKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public NativeList<OKLLPMCJCEG> list;

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
			public CDGKCHDIMKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<BLECMCBOLCB> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private struct MOIBJFIOLJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public NativeList<OKLLPMCJCEG> list;

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
			public MOIBJFIOLJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in NOPNMMPBCNL com, in DynamicBuffer<BLECMCBOLCB> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct DGPBDMHIOAH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200009C")]
			private struct CPMBDEFHEOB
			{
				[Cpp2IlInjected.Token(Token = "0x200009D")]
				public struct MOHFGJJCENE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000205")]
					public LambdaParameterValueProvider_Entity.Runtime FOLFDIJKMHB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000206")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MCACOCKECCH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000207")]
					public LambdaParameterValueProvider_DynamicBuffer<DNKDBOAOIFO>.Runtime GKALIMIHEKN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000202")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity CAKGJJMMLNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000203")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> ODPLNBEHFDL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000204")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<DNKDBOAOIFO> FDCENLMDCJO;

				[Cpp2IlInjected.Token(Token = "0x600057A")]
				[Cpp2IlInjected.Address(RVA = "0x51CB820", Offset = "0x51CA020", VA = "0x1851CB820")]
				public void GPJBIMHIEAK(UpdateConnectableVisuals AKIOJOCDPLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600057B")]
				[Cpp2IlInjected.Address(RVA = "0x51CB8A0", Offset = "0x51CA0A0", VA = "0x1851CB8A0")]
				public MOHFGJJCENE KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
				{
					return default(MOHFGJJCENE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public UpdateConnectableVisuals ANCGMEPLJML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public NativeList<OKLLPMCJCEG> PIJDNOPJENO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			private CPMBDEFHEOB HHAICJKMNOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe CPMBDEFHEOB.MOHFGJJCENE* AHDLDGHJKHI;

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LNJPINDGGKC;

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x51CBA20", Offset = "0x51CA220", VA = "0x1851CBA20")]
			internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, WorldPoseData BNOEIJLKPMM, in DynamicBuffer<DNKDBOAOIFO> JCLIGOJKKCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x51CBF30", Offset = "0x51CA730", VA = "0x1851CBF30", Slot = "5")]
			public void ReadFromDisplayClass(ref KGPLBAEGFBJ PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x51CBF60", Offset = "0x51CA760", VA = "0x1851CBF60", Slot = "6")]
			public void WriteToDisplayClass(ref KGPLBAEGFBJ PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x51CBE10", Offset = "0x51CA610", VA = "0x1851CBE10", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0x51CBCD0", Offset = "0x51CA4D0", VA = "0x1851CBCD0")]
			public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, ref CPMBDEFHEOB.MOHFGJJCENE FNDMFEGAALM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0x51CBEF0", Offset = "0x51CA6F0", VA = "0x1851CBEF0")]
			public void GPJBIMHIEAK(UpdateConnectableVisuals AKIOJOCDPLG, ref KGPLBAEGFBJ PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x51CBC60", Offset = "0x51CA460", VA = "0x1851CBC60")]
			public unsafe static void DOMKBIBFAOB(ArchetypeChunkIterator* HJJIPFNMMEP, void* KKAHEDCANDC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct MKNBEKMFLHJ : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200009F")]
			private struct AFNMGBNBLOE
			{
				[Cpp2IlInjected.Token(Token = "0x20000A0")]
				[NoAlias]
				public struct FDBMFEKGGKK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400020D")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MCACOCKECCH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400020E")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<BLECMCBOLCB>.Runtime GKALIMIHEKN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400020B")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> ODPLNBEHFDL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<BLECMCBOLCB> FDCENLMDCJO;

				[Cpp2IlInjected.Token(Token = "0x6000581")]
				[Cpp2IlInjected.Address(RVA = "0x51CA3E0", Offset = "0x51C8BE0", VA = "0x1851CA3E0")]
				public void GPJBIMHIEAK(UpdateConnectableVisuals AKIOJOCDPLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000582")]
				[Cpp2IlInjected.Address(RVA = "0x51CA450", Offset = "0x51C8C50", VA = "0x1851CA450")]
				public FDBMFEKGGKK KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
				{
					return default(FDBMFEKGGKK);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public NativeList<OKLLPMCJCEG> PIJDNOPJENO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private AFNMGBNBLOE HHAICJKMNOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe AFNMGBNBLOE.FDBMFEKGGKK* AHDLDGHJKHI;

			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0x51CFC80", Offset = "0x51CE480", VA = "0x1851CFC80")]
			internal void BOGFKFCHEFD(in WorldPoseData BNOEIJLKPMM, in DynamicBuffer<BLECMCBOLCB> JCLIGOJKKCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x12DBFB0", Offset = "0x12DA7B0", VA = "0x1812DBFB0", Slot = "5")]
			public void ReadFromDisplayClass(ref CDGKCHDIMKI PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x51CFE60", Offset = "0x51CE660", VA = "0x1851CFE60", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x51CFD90", Offset = "0x51CE590", VA = "0x1851CFD90")]
			public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref AFNMGBNBLOE.FDBMFEKGGKK FNDMFEGAALM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x51CFF30", Offset = "0x51CE730", VA = "0x1851CFF30")]
			public void GPJBIMHIEAK(UpdateConnectableVisuals AKIOJOCDPLG, ref CDGKCHDIMKI PIEBCDLFDLA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct ANINMAHPNPP : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			private struct KCAMCCKDPOA
			{
				[Cpp2IlInjected.Token(Token = "0x20000A3")]
				[NoAlias]
				public struct NOLLJLHGCFF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000215")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime MCACOCKECCH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000216")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<NOPNMMPBCNL>.Runtime OLOMKPJDMJH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000217")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<BLECMCBOLCB>.Runtime GKALIMIHEKN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000212")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> ODPLNBEHFDL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000213")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<NOPNMMPBCNL> KMKFIFHOBIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000214")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_DynamicBuffer<BLECMCBOLCB> FDCENLMDCJO;

				[Cpp2IlInjected.Token(Token = "0x6000588")]
				[Cpp2IlInjected.Address(RVA = "0x51CEEE0", Offset = "0x51CD6E0", VA = "0x1851CEEE0")]
				public void GPJBIMHIEAK(UpdateConnectableVisuals AKIOJOCDPLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000589")]
				[Cpp2IlInjected.Address(RVA = "0x51CEF70", Offset = "0x51CD770", VA = "0x1851CEF70")]
				public NOLLJLHGCFF KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
				{
					return default(NOLLJLHGCFF);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public NativeList<OKLLPMCJCEG> PIJDNOPJENO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private KCAMCCKDPOA HHAICJKMNOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe KCAMCCKDPOA.NOLLJLHGCFF* AHDLDGHJKHI;

			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x51CA4F0", Offset = "0x51C8CF0", VA = "0x1851CA4F0")]
			internal void BOGFKFCHEFD(in WorldPoseData BNOEIJLKPMM, in NOPNMMPBCNL COJCBHNIJLP, in DynamicBuffer<BLECMCBOLCB> JCLIGOJKKCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x12DBFB0", Offset = "0x12DA7B0", VA = "0x1812DBFB0", Slot = "5")]
			public void ReadFromDisplayClass(ref MOIBJFIOLJK PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x51CA770", Offset = "0x51C8F70", VA = "0x1851CA770", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x51CA650", Offset = "0x51C8E50", VA = "0x1851CA650")]
			public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref KCAMCCKDPOA.NOLLJLHGCFF FNDMFEGAALM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x51CA7F0", Offset = "0x51C8FF0", VA = "0x1851CA7F0")]
			public void GPJBIMHIEAK(UpdateConnectableVisuals AKIOJOCDPLG, ref MOIBJFIOLJK PIEBCDLFDLA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private EntityQuery HPPCGMFIJFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private EntityQuery AGHKENPAKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private EntityQuery KIDKODIJHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private EntityQuery AJHKBLBAHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private EntityQuery PLCCMDJNEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private EntityQuery GBHNBKMOBMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private EntityQuery BGDBKHAHJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private EntityQuery BJMDNPJHOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private EntityQuery CPICJCFCOEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private global::KNEIBAGCIPL<FGGNGNPKIFF, GLFPMFLGMPH> GGGNAOBCMPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private MHPBKECLGEM EGCAGCIFDNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private NCNJODMFFIF JHCECLNHNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private LLNLFBIJEEI GGEIAOMMHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private EntityQuery FDFDKLHICHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private ProfilerMarker HCABLAJLNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private EntityQuery EEMDBLGGKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private EntityQuery AAOHAAOMIDP;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public int CAAMIJFBOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0x385E730", Offset = "0x385CF30", VA = "0x18385E730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x385DA70", Offset = "0x385C270", VA = "0x18385DA70")]
		internal GLFPMFLGMPH BMOBDJNMEDK(FGGNGNPKIFF BLIPNDKFLPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x3860CE0", Offset = "0x385F4E0", VA = "0x183860CE0", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x38616C0", Offset = "0x385FEC0", VA = "0x1838616C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x3861480", Offset = "0x385FC80", VA = "0x183861480", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x385FCF0", Offset = "0x385E4F0", VA = "0x18385FCF0")]
		private void JLOLMKMJBGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x385EE30", Offset = "0x385D630", VA = "0x18385EE30")]
		private void GLIBGGIEOAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x385EF80", Offset = "0x385D780", VA = "0x18385EF80")]
		private void GNINNNFMLOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x3861700", Offset = "0x385FF00", VA = "0x183861700", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x385EA00", Offset = "0x385D200", VA = "0x18385EA00")]
		private void FMPDGFOLIAO(EntityQuery LLDKNFNPLPB, EntityQuery MMDMJIGCAOK, EntityQuery OKDHGDLBAGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x385FA90", Offset = "0x385E290", VA = "0x18385FA90")]
		private void JKKJCNGECGD(global::PEOLEGIGBJF<Entity> DNNDLEGGDDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x3860A00", Offset = "0x385F200", VA = "0x183860A00")]
		private void KMPDFAKMMEE(global::PEOLEGIGBJF<Entity> MIEPHMKOCLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x385F970", Offset = "0x385E170", VA = "0x18385F970")]
		private void JDAPBKJLAPG(global::PEOLEGIGBJF<Entity> OMIBPKCANDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x3860EE0", Offset = "0x385F6E0", VA = "0x183860EE0")]
		private void MAEHEPPIFOI(NativeList<FGGNGNPKIFF> JOCMGDNHOIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x3860250", Offset = "0x385EA50", VA = "0x183860250")]
		private NativeList<FGGNGNPKIFF> KFJKLEOGAGH(NativeArray<Entity> NGCJEBOBKNP)
		{
			return default(NativeList<FGGNGNPKIFF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x385F340", Offset = "0x385DB40", VA = "0x18385F340")]
		private void JCHFOBDEHJJ(NativeArray<Entity> NGCJEBOBKNP, NativeList<FGGNGNPKIFF> JOCMGDNHOIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x385E120", Offset = "0x385C920", VA = "0x18385E120")]
		private void EBPEJEMDGAH(NativeArray<Entity> BEIDLIDPMGN, NativeArray<Entity> PPNGEAGGBGM, NativeList<FGGNGNPKIFF> JOLIJECAEFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x385DC80", Offset = "0x385C480", VA = "0x18385DC80")]
		private void DFPBPEJOEPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x3861050", Offset = "0x385F850", VA = "0x183861050")]
		private global::AGEGIHAKIMB<OKLLPMCJCEG> MOOPMJNCIIA(EntityQuery PMKDKHNEPAL, Func<NativeList<OKLLPMCJCEG>, JobHandle> IKFOCGFCGFE)
		{
			return default(global::AGEGIHAKIMB<OKLLPMCJCEG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x3861190", Offset = "0x385F990", VA = "0x183861190")]
		private JobHandle OJEDPELEBAN(NativeList<OKLLPMCJCEG> PIJDNOPJENO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x385D930", Offset = "0x385C130", VA = "0x18385D930")]
		private JobHandle BBBAAGJIDNG(NativeList<OKLLPMCJCEG> PIJDNOPJENO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x3860120", Offset = "0x385E920", VA = "0x183860120")]
		private JobHandle KEOGDGLDJMB(NativeList<OKLLPMCJCEG> PIJDNOPJENO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x385FE00", Offset = "0x385E600", VA = "0x18385FE00")]
		private void KAEDNFOLLJL(global::AGEGIHAKIMB<OKLLPMCJCEG> PIJDNOPJENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x385E770", Offset = "0x385CF70", VA = "0x18385E770")]
		private void EPPDANCPALO(global::AGEGIHAKIMB<OKLLPMCJCEG> PIJDNOPJENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x385F2E0", Offset = "0x385DAE0", VA = "0x18385F2E0")]
		private bool JBIFIEMEABI(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x385E650", Offset = "0x385CE50", VA = "0x18385E650")]
		private NativeArray<Entity> ELGPODGHFIF(Entity GDNDJKDEKFN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x385DAC0", Offset = "0x385C2C0", VA = "0x18385DAC0")]
		private FGGNGNPKIFF COINIKJHAEL(NativeList<FGGNGNPKIFF> JOLIJECAEFM)
		{
			return default(FGGNGNPKIFF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x3860090", Offset = "0x385E890", VA = "0x183860090")]
		private void KDHNECLFHFJ(FGGNGNPKIFF BLIPNDKFLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x3861320", Offset = "0x385FB20", VA = "0x183861320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x3861790", Offset = "0x385FF90", VA = "0x183861790")]
		public static EntityQuery PNHLANAFMFO(ComponentSystemBase AKIOJOCDPLG)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x3860A80", Offset = "0x385F280", VA = "0x183860A80")]
		public static EntityQuery KNOMDJDEEMA(ComponentSystemBase AKIOJOCDPLG)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x3860790", Offset = "0x385EF90", VA = "0x183860790")]
		public static EntityQuery KGODICHFNAO(ComponentSystemBase AKIOJOCDPLG)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class OAGDMILOAHA : NKMCJEEJMOK, DNEGIKEIIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private EntityQuery HJHNEMCKIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private HBIJPHJPPAA OHLAEPJHHCL;

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4710", Offset = "0x3AA2F10", VA = "0x183AA4710", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4760", Offset = "0x3AA2F60", VA = "0x183AA4760", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4820", Offset = "0x3AA3020", VA = "0x183AA4820", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4430", Offset = "0x3AA2C30", VA = "0x183AA4430")]
	protected void GIGPFLIKDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x395D250", Offset = "0x395BA50", VA = "0x18395D250")]
	private bool PIFFIJAPHOD<TComponentData>(EntityQuery PMKDKHNEPAL, out NativeArray<Entity> NGCJEBOBKNP, out NativeArray<TComponentData> GPJMDEPCIAF) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA43C0", Offset = "0x3AA2BC0", VA = "0x183AA43C0")]
	public GHMJIBJLDNA BKPOHCGBFOI(Entity GDNDJKDEKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public OAGDMILOAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(SimulationSystemGroup))]
public class DNIIHKEILBK : NKMCJEEJMOK, DNEGIKEIIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private ObjectEmbodimentService AIFFIEBBMOL;

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1BA0", Offset = "0x3AF03A0", VA = "0x183AF1BA0", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1C00", Offset = "0x3AF0400", VA = "0x183AF1C00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1C30", Offset = "0x3AF0430", VA = "0x183AF1C30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public DNIIHKEILBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class IJHAGLHACDJ : NKMCJEEJMOK, DNEGIKEIIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private EntityQuery CIFNONLAIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private EntityQuery PMDJMEDPLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private EntityQuery HKFLJEBFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private EntityQuery MBGKLGGBBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private ObjectEmbodimentService ABFHPBCFEFN;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public int HDCINPLPMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x3A97B60", Offset = "0x3A96360", VA = "0x183A97B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int OMMFOKCAHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x3A98160", Offset = "0x3A96960", VA = "0x183A98160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x3A97DE0", Offset = "0x3A965E0", VA = "0x183A97DE0", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x3A98170", Offset = "0x3A96970", VA = "0x183A98170", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x3A98360", Offset = "0x3A96B60", VA = "0x183A98360", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x3A97E40", Offset = "0x3A96640", VA = "0x183A97E40")]
	protected void LMGNHEIBHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x3A97B70", Offset = "0x3A96370", VA = "0x183A97B70")]
	protected void JLPGLIDOHIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x3A98380", Offset = "0x3A96B80", VA = "0x183A98380")]
	private bool PIFFIJAPHOD(EntityQuery PMKDKHNEPAL, out NativeArray<Entity> NGCJEBOBKNP, out NativeArray<EACJHPJAFLK> ICIEPJPHBOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x3A98470", Offset = "0x3A96C70", VA = "0x183A98470")]
	public global::PEOLEGIGBJF<Entity> PLHLFLGHDFK(Allocator EGJIMBMGFGA)
	{
		return default(global::PEOLEGIGBJF<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x3A97AC0", Offset = "0x3A962C0", VA = "0x183A97AC0")]
	public global::PEOLEGIGBJF<Entity> GFJMKJKJPON(Allocator EGJIMBMGFGA)
	{
		return default(global::PEOLEGIGBJF<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A97A40", Offset = "0x3A96240", VA = "0x183A97A40")]
	public bool DLJEEIDFJFN(Allocator EGJIMBMGFGA, out global::PEOLEGIGBJF<Entity> EGJPJHAOMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A97970", Offset = "0x3A96170", VA = "0x183A97970")]
	public bool AADNEELLNGM(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A979D0", Offset = "0x3A961D0", VA = "0x183A979D0")]
	public GHMJIBJLDNA BKPOHCGBFOI(Entity GDNDJKDEKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x3A980B0", Offset = "0x3A968B0", VA = "0x183A980B0")]
	public bool LPOPHPNOAOD(Entity GDNDJKDEKFN, out CCFEOLMBFFJ EGJPJHAOMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x3A98120", Offset = "0x3A96920", VA = "0x183A98120")]
	public void NHILCMEGODH(Entity GDNDJKDEKFN, CCFEOLMBFFJ EGJPJHAOMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x3A97B00", Offset = "0x3A96300", VA = "0x183A97B00")]
	public bool GHIMMNHHNIG(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public IJHAGLHACDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class CCFEOLMBFFJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public GHMJIBJLDNA EGJPJHAOMIN;

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public CCFEOLMBFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x70E220", Offset = "0x70CA20", VA = "0x18070E220")]
	public CCFEOLMBFFJ(GHMJIBJLDNA EGJPJHAOMIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(NEOJDEHFHFL))]
public class MPBFHEDOMBL : NKMCJEEJMOK
{
	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public MPBFHEDOMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public abstract class OGKMPINMJKF : NKMCJEEJMOK, DNEGIKEIIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private LHHEJKEEMLP CFBNHCODAHP;

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4F20", Offset = "0x3AA3720", VA = "0x183AA4F20", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4F80", Offset = "0x3AA3780", VA = "0x183AA4F80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	protected OGKMPINMJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class FEHEGKHDIJC : NKMCJEEJMOK, PGECBFIGDKK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct AKCEIDKHDMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public NativeList<GGKPENPPBHO> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public NativeList<OJEIBILPNMC> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public NativeList<GGKPENPPBHO> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		public AKCEIDKHDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, IBNCHDDCFDM previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
		internal void <OnUpdate>b__2(Entity entity, IBNCHDDCFDM previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct DDDBAOEPLNL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		private struct KDPJCEKMGOG
		{
			[Cpp2IlInjected.Token(Token = "0x20000AE")]
			[NoAlias]
			public struct BPMOMDJGBFD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400022E")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FOLFDIJKMHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400022F")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime JGGBLHDFOOF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CAKGJJMMLNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> CDFDODKBLFH;

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x51CF540", Offset = "0x51CDD40", VA = "0x1851CF540")]
			public void GPJBIMHIEAK(FEHEGKHDIJC AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x51CF5A0", Offset = "0x51CDDA0", VA = "0x1851CF5A0")]
			public BPMOMDJGBFD KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
			{
				return default(BPMOMDJGBFD);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public NativeList<GGKPENPPBHO> PKPKKAIFHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private KDPJCEKMGOG HHAICJKMNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KDPJCEKMGOG.BPMOMDJGBFD* AHDLDGHJKHI;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x3845760", Offset = "0x3843F60", VA = "0x183845760")]
		internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, ParentData IMLJHLOOKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x12DBFB0", Offset = "0x12DA7B0", VA = "0x1812DBFB0", Slot = "5")]
		public void ReadFromDisplayClass(ref AKCEIDKHDMF PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x3845890", Offset = "0x3844090", VA = "0x183845890", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x38457E0", Offset = "0x3843FE0", VA = "0x1838457E0")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref KDPJCEKMGOG.BPMOMDJGBFD FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x3845900", Offset = "0x3844100", VA = "0x183845900")]
		public void GPJBIMHIEAK(FEHEGKHDIJC AKIOJOCDPLG, ref AKCEIDKHDMF PIEBCDLFDLA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct IKDNAJFOJEC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		private struct HHGEAGGMHMM
		{
			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[NoAlias]
			public struct ODHCPOMADKI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FOLFDIJKMHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime JGGBLHDFOOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<IBNCHDDCFDM>.Runtime BLICDKFMKDA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CAKGJJMMLNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> CDFDODKBLFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<IBNCHDDCFDM> OAKJNGOBLCN;

			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x51CD760", Offset = "0x51CBF60", VA = "0x1851CD760")]
			public void GPJBIMHIEAK(FEHEGKHDIJC AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x51CD7E0", Offset = "0x51CBFE0", VA = "0x1851CD7E0")]
			public ODHCPOMADKI KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
			{
				return default(ODHCPOMADKI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public NativeList<OJEIBILPNMC> HNINDKIFJCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private HHGEAGGMHMM HHAICJKMNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HHGEAGGMHMM.ODHCPOMADKI* AHDLDGHJKHI;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x3846C20", Offset = "0x3845420", VA = "0x183846C20")]
		internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, ParentData IMLJHLOOKFM, IBNCHDDCFDM NOPNDJAEHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x3846E70", Offset = "0x3845670", VA = "0x183846E70", Slot = "5")]
		public void ReadFromDisplayClass(ref AKCEIDKHDMF PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x3846DC0", Offset = "0x38455C0", VA = "0x183846DC0", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x3846CE0", Offset = "0x38454E0", VA = "0x183846CE0")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref HHGEAGGMHMM.ODHCPOMADKI FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x3846E30", Offset = "0x3845630", VA = "0x183846E30")]
		public void GPJBIMHIEAK(FEHEGKHDIJC AKIOJOCDPLG, ref AKCEIDKHDMF PIEBCDLFDLA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct OGKGGPKEMJB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		private struct PBANHOMGJJB
		{
			[Cpp2IlInjected.Token(Token = "0x20000B4")]
			[NoAlias]
			public struct GOBLACHLAHA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023E")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FOLFDIJKMHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400023F")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<IBNCHDDCFDM>.Runtime BLICDKFMKDA;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CAKGJJMMLNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<IBNCHDDCFDM> OAKJNGOBLCN;

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x51D1F40", Offset = "0x51D0740", VA = "0x1851D1F40")]
			public void GPJBIMHIEAK(FEHEGKHDIJC AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x51D1FA0", Offset = "0x51D07A0", VA = "0x1851D1FA0")]
			public GOBLACHLAHA KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
			{
				return default(GOBLACHLAHA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public NativeList<GGKPENPPBHO> MNDLNBADEHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private PBANHOMGJJB HHAICJKMNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PBANHOMGJJB.GOBLACHLAHA* AHDLDGHJKHI;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x38493B0", Offset = "0x3847BB0", VA = "0x1838493B0")]
		internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, IBNCHDDCFDM NOPNDJAEHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x3849590", Offset = "0x3847D90", VA = "0x183849590", Slot = "5")]
		public void ReadFromDisplayClass(ref AKCEIDKHDMF PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x38494E0", Offset = "0x3847CE0", VA = "0x1838494E0", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x3849430", Offset = "0x3847C30", VA = "0x183849430")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref PBANHOMGJJB.GOBLACHLAHA FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x3849550", Offset = "0x3847D50", VA = "0x183849550")]
		public void GPJBIMHIEAK(FEHEGKHDIJC AKIOJOCDPLG, ref AKCEIDKHDMF PIEBCDLFDLA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private PIEJAMPEPCM MCGOIHBGCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private EntityQuery AFEHGMNDJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private EntityQuery KPOLEFCKMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private EntityQuery BAOLNPIAGPK;

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9B90", Offset = "0x3AF8390", VA = "0x183AF9B90", Slot = "14")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA300", Offset = "0x3AF8B00", VA = "0x183AFA300", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public FEHEGKHDIJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1B20", Offset = "0x3AF0320", VA = "0x183AF1B20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9C70", Offset = "0x3AF8470", VA = "0x183AF9C70")]
	public static EntityQuery AHJIAIKAMBD(ComponentSystemBase AKIOJOCDPLG)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA0D0", Offset = "0x3AF88D0", VA = "0x183AFA0D0")]
	public static EntityQuery MNJBFNEFKJC(ComponentSystemBase AKIOJOCDPLG)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9ED0", Offset = "0x3AF86D0", VA = "0x183AF9ED0")]
	public static EntityQuery JEAAFFKKNAB(ComponentSystemBase AKIOJOCDPLG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class NMBOBHDKNDC : ParentSystemBase<ParentData, IBNCHDDCFDM, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2E60", Offset = "0x3AA1660", VA = "0x183AA2E60", Slot = "14")]
	protected override EntityQueryDesc HNGMCOJHLNH(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0xA1E020", Offset = "0xA1C820", VA = "0x180A1E020", Slot = "15")]
	protected override EntityQueryDesc CPFDHCLBLCN(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2E20", Offset = "0x3AA1620", VA = "0x183AA2E20", Slot = "16")]
	protected override EntityQueryDesc GNOHAGLAAJO(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2DE0", Offset = "0x3AA15E0", VA = "0x183AA2DE0", Slot = "17")]
	protected override EntityQueryDesc ECDEGGLBPCN(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E900", Offset = "0x3A9D100", VA = "0x183A9E900")]
	public NMBOBHDKNDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E8C0", Offset = "0x3A9D0C0", VA = "0x183A9E8C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : OFMIDBOIMPP where ParentData : struct, IComponentData, OLKMAFNAGAF where PreviousParentData : struct, IComponentData, OLKMAFNAGAF where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, OLKMAFNAGAF
	{
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		[BurstCompile]
		private struct CLLNIJBPOAA : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000248")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter MIBBACMNMCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter NLBNJEFIECO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024A")]
			public NativeHashMap<Entity, int>.ParallelWriter MJIEMPBBDOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			public ArchetypeChunkComponentType<PreviousParentData> LOINLPPPLGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> FKHPKDJFMPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			[ReadOnly]
			public ArchetypeChunkEntityType IMMCDODPFBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public uint NMONBMHAJLB;

			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x3878730", Offset = "0x3876F30", VA = "0x183878730", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[BurstCompile]
		private struct FGIGJAPMAKH : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> MJIEMPBBDOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> KHCPOMHGKOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public NativeList<Entity> KLBGGBJIDKE;

			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x34C4990", Offset = "0x34C3190", VA = "0x1834C4990", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		[BurstCompile]
		private struct GFDFKDOIEOF : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> MIBBACMNMCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> NLBNJEFIECO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			[ReadOnly]
			public NativeHashMap<Entity, int> MJIEMPBBDOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			public BufferFromEntity<ChildrenData> KHCPOMHGKOM;

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x41944F0", Offset = "0x4192CF0", VA = "0x1841944F0")]
			private int BNNJFBEALBA(DynamicBuffer<ChildrenData> HFOEOPEIJAG, Entity GDNDJKDEKFN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x4194D90", Offset = "0x4193590", VA = "0x184194D90")]
			private void NGPIHBCNIKL(Entity OJKLIAPCMPJ, DynamicBuffer<ChildrenData> HFOEOPEIJAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x41949D0", Offset = "0x41931D0", VA = "0x1841949D0")]
			private void FGOKKBCLAPK(Entity OJKLIAPCMPJ, DynamicBuffer<ChildrenData> HFOEOPEIJAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x4194870", Offset = "0x4193070", VA = "0x184194870", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[BurstCompile]
		private struct FNBBLJFJPKN : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			public NativeArray<Entity> OCAPDDLKJBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			public NativeList<Entity> KNPEBNPGMCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public BufferFromEntity<ChildrenData> KHCPOMHGKOM;

			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0x4273F80", Offset = "0x4272780", VA = "0x184273F80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		protected EntityQuery EDDKFPMHGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		protected EntityQuery PFHGGAFDNAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		protected EntityQuery IKJMONHEMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		protected EntityQuery EODPPHMFFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		protected ProfilerMarker HFJPIPDGEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		protected ProfilerMarker AABPGPIMIPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		protected ProfilerMarker MEFEEJPOHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		protected ProfilerMarker HMJMEDMHHGD;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x3429730", Offset = "0x3427F30", VA = "0x183429730")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x34277A0", Offset = "0x3425FA0", VA = "0x1834277A0")]
		private int BNNJFBEALBA(DynamicBuffer<ChildrenData> HFOEOPEIJAG, Entity GDNDJKDEKFN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x3429470", Offset = "0x3427C70", VA = "0x183429470")]
		private void PJEKLNMEHAM(Entity IMJDLKJJPPH, Entity KIMLMENBIDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xA1E020", Offset = "0xA1C820", VA = "0x180A1E020", Slot = "14")]
		protected virtual EntityQueryDesc HNGMCOJHLNH(EntityQueryDesc PMKDKHNEPAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xA1E020", Offset = "0xA1C820", VA = "0x180A1E020", Slot = "15")]
		protected virtual EntityQueryDesc CPFDHCLBLCN(EntityQueryDesc PMKDKHNEPAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xA1E020", Offset = "0xA1C820", VA = "0x180A1E020", Slot = "16")]
		protected virtual EntityQueryDesc GNOHAGLAAJO(EntityQueryDesc PMKDKHNEPAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc ECDEGGLBPCN(EntityQueryDesc PMKDKHNEPAL);

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x3429110", Offset = "0x3427910", VA = "0x183429110", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x3428CB0", Offset = "0x34274B0", VA = "0x183428CB0")]
		private void OMACKCBCCFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x3427A60", Offset = "0x3426260", VA = "0x183427A60")]
		private void CMPEAIGIHIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x3427C30", Offset = "0x3426430", VA = "0x183427C30")]
		private void EHAKKPDMDCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x3428610", Offset = "0x3426E10", VA = "0x183428610")]
		private void FCPKINFPEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x34293B0", Offset = "0x3427BB0", VA = "0x1834293B0", Slot = "13")]
		protected override JobHandle OnUpdate(JobHandle FMEBGAACPOB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x337FA20", Offset = "0x337E220", VA = "0x18337FA20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[AlwaysUpdateSystem]
	[HPLMCJEDJJG(KOEAPPNBOCD.RenderEffects)]
	public abstract class PropagateTagsBase<TRootTag, TDescendantTag, TRootSystemTag> : NKMCJEEJMOK, PGECBFIGDKK where TRootTag : struct, IComponentData where TDescendantTag : struct, IComponentData where TRootSystemTag : struct, ISystemStateComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		private struct PLIHBBKDBFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public global::AGEGIHAKIMB<Entity> KEHLENFDCJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public global::AGEGIHAKIMB<Entity> DGDKNCLPAEG;

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x3B3FEE0", Offset = "0x3B3E6E0", VA = "0x183B3FEE0")]
			public PLIHBBKDBFD(NativeList<Entity> KEHLENFDCJE, NativeList<Entity> DGDKNCLPAEG, JobHandle IHONPLJMIOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x3B3FA90", Offset = "0x3B3E290", VA = "0x183B3FA90")]
			public JobHandle OFEOJIGNMCE(JobHandle EKODEGLIDHA)
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x3B3FCB0", Offset = "0x3B3E4B0", VA = "0x183B3FCB0")]
			public void PDHGAAMLKHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[BurstCompile]
		private struct KKJHFDNPKLM : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20000BE")]
			[Flags]
			public enum DLNFDKEMDMH
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
			public NativeList<Entity> NKCOGHNHJOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			[WriteOnly]
			public NativeList<Entity> PJHCNFGPJIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			[ReadOnly]
			public NativeArray<Entity> CBKFPHILJOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> EILPMEOCNOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			[ReadOnly]
			public ComponentDataFromEntity<TRootTag> JCFGLMFCIKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			[ReadOnly]
			public ComponentDataFromEntity<TDescendantTag> CMALKJCDGLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			[ReadOnly]
			public ComponentDataFromEntity<ParentData> OFAIOMFEIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000266")]
			public int HCDJJAMNJEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public int PCNOACOMIOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private DLNFDKEMDMH NAEJNAFGBMH;

			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x3DC9C00", Offset = "0x3DC8400", VA = "0x183DC9C00", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x3DCB150", Offset = "0x3DC9950", VA = "0x183DCB150")]
			private void KPEEHPJBBAJ(Entity GDNDJKDEKFN, bool LOMMFNILBKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x3DCAF30", Offset = "0x3DC9730", VA = "0x183DCAF30")]
			private void IEMDEIKFBPJ(Entity GDNDJKDEKFN, bool LOMMFNILBKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x3DC9570", Offset = "0x3DC7D70", VA = "0x183DC9570")]
			public PLIHBBKDBFD ADANPDDFNGI(NativeArray<Entity> LCOODLIGMCJ, JobHandle EKODEGLIDHA)
			{
				return default(PLIHBBKDBFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x3DCA320", Offset = "0x3DC8B20", VA = "0x183DCA320")]
			public PLIHBBKDBFD FHCDKABJEBP(NativeArray<Entity> LCOODLIGMCJ, JobHandle EKODEGLIDHA)
			{
				return default(PLIHBBKDBFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x3DC9930", Offset = "0x3DC8130", VA = "0x183DC9930")]
			public PLIHBBKDBFD EKGOIPDCIPE(NativeList<GGKPENPPBHO> PIJDNOPJENO, JobHandle EKODEGLIDHA)
			{
				return default(PLIHBBKDBFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x3DCB400", Offset = "0x3DC9C00", VA = "0x183DCB400")]
			public PLIHBBKDBFD PNAIEIMLFDF(NativeList<GGKPENPPBHO> PIJDNOPJENO, JobHandle EKODEGLIDHA)
			{
				return default(PLIHBBKDBFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x3DC9750", Offset = "0x3DC7F50", VA = "0x183DC9750")]
			public PLIHBBKDBFD DBBFKBJAENH(NativeList<OJEIBILPNMC> PIJDNOPJENO, JobHandle EKODEGLIDHA)
			{
				return default(PLIHBBKDBFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x349BDB0", Offset = "0x349A5B0", VA = "0x18349BDB0")]
			private PLIHBBKDBFD GAOABOOJKCH<T>(NativeList<T> PIJDNOPJENO, int CPGBPGNKOAH, int IBKDMEGGOGM, DLNFDKEMDMH PDFIDNNGANB, JobHandle EKODEGLIDHA) where T : struct
			{
				return default(PLIHBBKDBFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x3DCAA70", Offset = "0x3DC9270", VA = "0x183DCAA70")]
			private PLIHBBKDBFD GAOABOOJKCH(NativeArray<Entity> NGCJEBOBKNP, int CPGBPGNKOAH, int IBKDMEGGOGM, DLNFDKEMDMH PDFIDNNGANB, JobHandle EKODEGLIDHA)
			{
				return default(PLIHBBKDBFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private EntityQuery LICMHEELACA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private EntityQuery BKDJNLMAFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private PIEJAMPEPCM APLPCAHGPBB;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x478EB90", Offset = "0x478D390", VA = "0x18478EB90", Slot = "14")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x478F4D0", Offset = "0x478DCD0", VA = "0x18478F4D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x47902E0", Offset = "0x478EAE0", VA = "0x1847902E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x47918A0", Offset = "0x47900A0", VA = "0x1847918A0")]
		private void PPEFKLBLEJF(NativeArray<Entity> PIJDNOPJENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x478F410", Offset = "0x478DC10", VA = "0x18478F410")]
		private void IFFMANHLFMO(NativeArray<Entity> PIJDNOPJENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x478ED50", Offset = "0x478D550", VA = "0x18478ED50")]
		private void BHMPPLENPHJ(PLIHBBKDBFD HKCGLMCFMHB, string EGPAKIILAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x478EFB0", Offset = "0x478D7B0", VA = "0x18478EFB0")]
		private void BHMPPLENPHJ(global::AGEGIHAKIMB<Entity> LBDMCKHPFFG, string EGPAKIILAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x478F1B0", Offset = "0x478D9B0", VA = "0x18478F1B0")]
		private void CCBOBIGAACF(PLIHBBKDBFD HKCGLMCFMHB, string EGPAKIILAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x478F310", Offset = "0x478DB10", VA = "0x18478F310")]
		private void CCBOBIGAACF(global::AGEGIHAKIMB<Entity> LBDMCKHPFFG, string EGPAKIILAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x478F480", Offset = "0x478DC80", VA = "0x18478F480")]
		private bool KBPAJCHBMMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x4791980", Offset = "0x4790180", VA = "0x184791980")]
		protected PropagateTagsBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x337FA20", Offset = "0x337E220", VA = "0x18337FA20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct MFPGKDHMCFI : ISystemStateComponentData, IComponentData, IEquatable<MFPGKDHMCFI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public float3 JDCICFBCNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public float3 BHPBAPJCDCK;

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E840", Offset = "0x3A9D040", VA = "0x183A9E840", Slot = "4")]
	public bool Equals(MFPGKDHMCFI IIKMMJKCGDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class HPDKFCJJFJI : NKMCJEEJMOK, DNEGIKEIIMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct OMOFIKPLEEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public HPDKFCJJFJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		public OMOFIKPLEEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct INKKNPCOIKM : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		private struct ELDBLNNEBPJ
		{
			[Cpp2IlInjected.Token(Token = "0x20000C4")]
			public struct APJDBAJNKNP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027D")]
				public LambdaParameterValueProvider_Entity.Runtime MPEOLFLDDLC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CFKHDOGPKCE;

			[Cpp2IlInjected.Token(Token = "0x6000617")]
			[Cpp2IlInjected.Address(RVA = "0x51CC580", Offset = "0x51CAD80", VA = "0x1851CC580")]
			public void GPJBIMHIEAK(HPDKFCJJFJI AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x51CC590", Offset = "0x51CAD90", VA = "0x1851CC590")]
			public APJDBAJNKNP KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
			{
				return default(APJDBAJNKNP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public HPDKFCJJFJI ANCGMEPLJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public EntityCommandBuffer EFOHOJKJMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private ELDBLNNEBPJ HHAICJKMNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ELDBLNNEBPJ.APJDBAJNKNP* AHDLDGHJKHI;

		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LNJPINDGGKC;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x51CE380", Offset = "0x51CCB80", VA = "0x1851CE380")]
		internal void BOGFKFCHEFD(Entity GHAPGMJOMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x51CC510", Offset = "0x51CAD10", VA = "0x1851CC510", Slot = "5")]
		public void ReadFromDisplayClass(ref OMOFIKPLEEM PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x51CC540", Offset = "0x51CAD40", VA = "0x1851CC540", Slot = "6")]
		public void WriteToDisplayClass(ref OMOFIKPLEEM PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x51CE570", Offset = "0x51CCD70", VA = "0x1851CE570", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x51CE500", Offset = "0x51CCD00", VA = "0x1851CE500")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, ref ELDBLNNEBPJ.APJDBAJNKNP FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x51CE5C0", Offset = "0x51CCDC0", VA = "0x1851CE5C0")]
		public void GPJBIMHIEAK(HPDKFCJJFJI AKIOJOCDPLG, ref OMOFIKPLEEM PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x51CE490", Offset = "0x51CCC90", VA = "0x1851CE490")]
		public unsafe static void DOMKBIBFAOB(ArchetypeChunkIterator* HJJIPFNMMEP, void* KKAHEDCANDC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private KMMBELOOFGA IOPJGDGANBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private BBHEDGKDAJF BJCGAPIHGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private EntityQuery OOKGGACJLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private ProfilerMarker CIEMDGMBDDF;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x3A94E10", Offset = "0x3A93610", VA = "0x183A94E10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x3A94DB0", Offset = "0x3A935B0", VA = "0x183A94DB0", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x3A94E70", Offset = "0x3A93670", VA = "0x183A94E70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public HPDKFCJJFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x3A94590", Offset = "0x3A92D90", VA = "0x183A94590", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x3A94BE0", Offset = "0x3A933E0", VA = "0x183A94BE0")]
	public static EntityQuery FOAGAIBLBBA(ComponentSystemBase AKIOJOCDPLG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public struct IDMLNLEIDAE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public IBNEEFGBPPM BLIPNDKFLPL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x7579C0", Offset = "0x7561C0", VA = "0x1807579C0")]
	public static IDMLNLEIDAE EDIIAGKPKGG(in IBNEEFGBPPM JOMMFCFJBEK)
	{
		return default(IDMLNLEIDAE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x7579C0", Offset = "0x7561C0", VA = "0x1807579C0")]
	public static IBNEEFGBPPM EDIIAGKPKGG(in IDMLNLEIDAE FMGDFOMFFFP)
	{
		return default(IBNEEFGBPPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[OOAPDBLGMJF(typeof(BBHEDGKDAJF), new string[] { })]
public sealed class MNFCGOIENPC : BBHEDGKDAJF, ICEHLGPCFGD, AFNLLOENMMK, DNEGIKEIIMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private const int CLIOKIFIBKI = -1;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private const int JBJOJMMLHNF = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private Collider[] NEDMPPEEHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private RaycastHit[] ANPOENEAEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private global::KNEIBAGCIPL<IBNEEFGBPPM, BoxCollider> DKAMANAFNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private Scene CDOCHABCOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private PhysicsScene KACMKGMLIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private GameObject LGELJKPCDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private KAOEDAJOEMH NJIEGCDNDEF;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int MACDNMEDCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x3AA13C0", Offset = "0x3A9FBC0", VA = "0x183AA13C0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1400", Offset = "0x3A9FC00", VA = "0x183AA1400", Slot = "10")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1B90", Offset = "0x3AA0390", VA = "0x183AA1B90", Slot = "11")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA12C0", Offset = "0x3A9FAC0", VA = "0x183AA12C0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1D90", Offset = "0x3AA0590", VA = "0x183AA1D90", Slot = "5")]
	public IBNEEFGBPPM PAHAANGGJJI(Entity GDNDJKDEKFN)
	{
		return default(IBNEEFGBPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1EE0", Offset = "0x3AA06E0", VA = "0x183AA1EE0", Slot = "6")]
	public void PCNBCAJFMIC(NativeArray<IBNEEFGBPPM> ICIEPJPHBOB, NativeArray<MFPGKDHMCFI> ANAGHLFLMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0DF0", Offset = "0x3A9F5F0", VA = "0x183AA0DF0", Slot = "7")]
	public void ACHJKEDIMPM(IBNEEFGBPPM BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1CF0", Offset = "0x3AA04F0", VA = "0x183AA1CF0", Slot = "8")]
	public bool NFOGJKLJKKE(IBNEEFGBPPM BLIPNDKFLPL, out Collider DMJMICMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x3AA15B0", Offset = "0x3A9FDB0", VA = "0x183AA15B0")]
	public bool GGAAJFEABCL(in float3 JMICGAIDJIF, in float3 LBPFPACOALI, float EIEEMLEJCAI, Allocator EGJIMBMGFGA, out NativeArray<Entity> NGCJEBOBKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0FE0", Offset = "0x3A9F7E0", VA = "0x183AA0FE0")]
	private void BLBEJGIBJGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x105A700", Offset = "0x1058F00", VA = "0x18105A700")]
	private void BIHBJPIFJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1C70", Offset = "0x3AA0470", VA = "0x183AA1C70")]
	private void MFKOOFLJGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x74C0B0", Offset = "0x74A8B0", VA = "0x18074C0B0")]
	private void JBNAJBLHCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0EC0", Offset = "0x3A9F6C0", VA = "0x183AA0EC0")]
	private BoxCollider ANKGFMFFIEO(Entity GDNDJKDEKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x3AA18C0", Offset = "0x3AA00C0", VA = "0x183AA18C0")]
	private void GKNIKNGMGDH(BoxCollider OEKADPILPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1B50", Offset = "0x3AA0350", VA = "0x183AA1B50")]
	[Conditional("UNITY_EDITOR")]
	private void LAAPHNFLFAA(GameObject HBGIADIFHEC, Entity GDNDJKDEKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1030", Offset = "0x3A9F830", VA = "0x183AA1030")]
	private void DAKKNINFBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x3AA11B0", Offset = "0x3A9F9B0", VA = "0x183AA11B0")]
	private void DLBKIEKIJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1940", Offset = "0x3AA0140", VA = "0x183AA1940")]
	private void KNDEGONPJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1CC0", Offset = "0x3AA04C0", VA = "0x183AA1CC0")]
	private void MMFJOFPJHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1C60", Offset = "0x3AA0460", VA = "0x183AA1C60")]
	private void MDKMOOKPCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x3AA1570", Offset = "0x3A9FD70", VA = "0x183AA1570")]
	private void GCENPLDMDGE(Scene HOHHAKDFJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public MNFCGOIENPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x3AA20F0", Offset = "0x3AA08F0", VA = "0x183AA20F0", Slot = "9")]
	private bool PMPNKFEGBLI(in float3 JMICGAIDJIF, in float3 LBPFPACOALI, float EIEEMLEJCAI, Allocator EGJIMBMGFGA, out NativeArray<Entity> NGCJEBOBKNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class KMMBELOOFGA : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960")]
	public KMMBELOOFGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class KAEOPFLFJEH : NKMCJEEJMOK, DNEGIKEIIMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct PHJFFJHFMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public KAEOPFLFJEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		public PHJFFJHFMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
		internal void <OnUpdate>b__0(Entity e, IDMLNLEIDAE ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct EJGGEEMKJAF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		private struct PJMBCHMLEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			public struct DKOJIJFNPNA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000295")]
				public LambdaParameterValueProvider_Entity.Runtime MPEOLFLDDLC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000296")]
				public LambdaParameterValueProvider_IComponentData<IDMLNLEIDAE>.Runtime AOLEOCIDLFE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CFKHDOGPKCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<IDMLNLEIDAE> HBECMKJOIMP;

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x51D21C0", Offset = "0x51D09C0", VA = "0x1851D21C0")]
			public void GPJBIMHIEAK(KAEOPFLFJEH AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x51D2220", Offset = "0x51D0A20", VA = "0x1851D2220")]
			public DKOJIJFNPNA KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
			{
				return default(DKOJIJFNPNA);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public KAEOPFLFJEH ANCGMEPLJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public EntityCommandBuffer EFOHOJKJMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private PJMBCHMLEMJ HHAICJKMNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PJMBCHMLEMJ.DKOJIJFNPNA* AHDLDGHJKHI;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LNJPINDGGKC;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x51CC1C0", Offset = "0x51CA9C0", VA = "0x1851CC1C0")]
		internal void BOGFKFCHEFD(Entity GHAPGMJOMOM, IDMLNLEIDAE BOICHCFMALB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x51CC510", Offset = "0x51CAD10", VA = "0x1851CC510", Slot = "5")]
		public void ReadFromDisplayClass(ref PHJFFJHFMFB PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x51CC540", Offset = "0x51CAD40", VA = "0x1851CC540", Slot = "6")]
		public void WriteToDisplayClass(ref PHJFFJHFMFB PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x51CC3E0", Offset = "0x51CABE0", VA = "0x1851CC3E0", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x51CC330", Offset = "0x51CAB30", VA = "0x1851CC330")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, ref PJMBCHMLEMJ.DKOJIJFNPNA FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x51CC480", Offset = "0x51CAC80", VA = "0x1851CC480")]
		public void GPJBIMHIEAK(KAEOPFLFJEH AKIOJOCDPLG, ref PHJFFJHFMFB PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x51CC2C0", Offset = "0x51CAAC0", VA = "0x1851CC2C0")]
		public unsafe static void DOMKBIBFAOB(ArchetypeChunkIterator* HJJIPFNMMEP, void* KKAHEDCANDC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private KMMBELOOFGA IOPJGDGANBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private BBHEDGKDAJF BJCGAPIHGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery NMEBJOFIFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private ProfilerMarker GCHFNNJPDIC;

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x3A99180", Offset = "0x3A97980", VA = "0x183A99180", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x3A99040", Offset = "0x3A97840", VA = "0x183A99040", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x3A991E0", Offset = "0x3A979E0", VA = "0x183A991E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public KAEOPFLFJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x3A990A0", Offset = "0x3A978A0", VA = "0x183A990A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x3A98E70", Offset = "0x3A97670", VA = "0x183A98E70")]
	public static EntityQuery HABJNGJIPGC(ComponentSystemBase AKIOJOCDPLG)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : NKMCJEEJMOK, DNEGIKEIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		private struct FENENALMBMP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			public EBPNDNCEIPG ILNNOEDPGOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			public NativeHashMap<Entity, FDAEEOMAIHB> NGCJEBOBKNP;

			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x51CC970", Offset = "0x51CB170", VA = "0x1851CC970")]
			public FENENALMBMP(int JAFEKEGLGFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x51CC8F0", Offset = "0x51CB0F0", VA = "0x1851CC8F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		[BurstCompile]
		private struct PJAPPLIBEPL : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			[ReadOnly]
			public NativeArray<Entity> NGCJEBOBKNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> JJDCLONBKIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> EDNLDBCBJPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> PKGGJHMEDFG;

			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0x51D2020", Offset = "0x51D0820", VA = "0x1851D2020", Slot = "4")]
			public void Execute(int MMABPPDCBIB, TransformAccess JDMGKLHBDHC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[BurstCompile]
		private struct MGFFEKMBLOG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			[ReadOnly]
			public NativeArray<Entity> NGCJEBOBKNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> JJDCLONBKIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> PKGGJHMEDFG;

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0x51CFB30", Offset = "0x51CE330", VA = "0x1851CFB30", Slot = "4")]
			public void Execute(int MMABPPDCBIB, TransformAccess JDMGKLHBDHC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private BBHEDGKDAJF BJCGAPIHGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private EntityQuery OLOJOPLBGPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private EntityQuery FFKABAJPDIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery MENEBEGHDCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery FHNLJGHIGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery ALFHMDELACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private JobHandle DEDMKONPKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private FENENALMBMP JHHNJGIOOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private FENENALMBMP OJGAGCKAEDA;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x384C060", Offset = "0x384A860", VA = "0x18384C060", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x384C210", Offset = "0x384AA10", VA = "0x18384C210", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x384C020", Offset = "0x384A820", VA = "0x18384C020", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x384C4D0", Offset = "0x384ACD0", VA = "0x18384C4D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x384C0C0", Offset = "0x384A8C0", VA = "0x18384C0C0")]
		private void LPFGPFPBOHH(EntityQuery PMKDKHNEPAL, out (global::PEOLEGIGBJF<IDMLNLEIDAE> handles, global::PEOLEGIGBJF<MFPGKDHMCFI> bounds) PJDKPCLOECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x384BDC0", Offset = "0x384A5C0", VA = "0x18384BDC0")]
		private void HKDANINOPDF((global::PEOLEGIGBJF<IDMLNLEIDAE> handles, global::PEOLEGIGBJF<MFPGKDHMCFI> bounds) PJDKPCLOECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x384C020", Offset = "0x384A820", VA = "0x18384C020")]
		private void IJOAMAMKDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x384B6C0", Offset = "0x3849EC0", VA = "0x18384B6C0")]
		private void BFDLIFNPFFM(EntityQuery PMKDKHNEPAL, out (global::PEOLEGIGBJF<Entity> entities, global::PEOLEGIGBJF<IDMLNLEIDAE> handles) PJDKPCLOECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x384B840", Offset = "0x384A040", VA = "0x18384B840")]
		private void DLAIGFGFFJC((global::PEOLEGIGBJF<Entity> entities, global::PEOLEGIGBJF<IDMLNLEIDAE> handles) PJDKPCLOECB, FENENALMBMP JCDDFAMPICO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x384BB30", Offset = "0x384A330", VA = "0x18384BB30")]
		private JobHandle DMNOGAMMBPB(FENENALMBMP JCDDFAMPICO, ComponentDataFromEntity<WorldPoseData> JJDCLONBKIB, ComponentDataFromEntity<WorldUniformScaleData> PKGGJHMEDFG, ComponentDataFromEntity<WorldDeformableScaleData> EDNLDBCBJPN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x384BC90", Offset = "0x384A490", VA = "0x18384BC90")]
		private JobHandle ENHGELBMJHP(FENENALMBMP JCDDFAMPICO, ComponentDataFromEntity<WorldPoseData> JJDCLONBKIB, ComponentDataFromEntity<WorldUniformScaleData> PKGGJHMEDFG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[OOAPDBLGMJF(typeof(LINPFIEIHLN), new string[] { })]
public sealed class EBCIOEBHGLK : LINPFIEIHLN, DNEGIKEIIMB
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private struct HKMCOMAJAOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public float BPJEFFCEPEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public uint DIPNKMENNJO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private ICEHLGPCFGD JPHKDGOOFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private KIEEHOGAPNN HEDEIBNHBDG;

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2A40", Offset = "0x3AF1240", VA = "0x183AF2A40", Slot = "5")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x3AF25C0", Offset = "0x3AF0DC0", VA = "0x183AF25C0")]
	public bool GGAAJFEABCL(in float3 JMICGAIDJIF, in float3 LBPFPACOALI, float EIEEMLEJCAI, out ELNKPLJCKEF KJPODJIHEGN, out Entity LPCMCOJAFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2490", Offset = "0x3AF0C90", VA = "0x183AF2490")]
	public static bool BFCJNMPEBDG(in Span<ELNKPLJCKEF> EAECMEIPPHA, float EIEEMLEJCAI, out int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2590", Offset = "0x3AF0D90", VA = "0x183AF2590")]
	public static float CDLABNPDFBE(float BPJEFFCEPEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public EBCIOEBHGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2AB0", Offset = "0x3AF12B0", VA = "0x183AF2AB0", Slot = "4")]
	private bool MIIDGBJHJDM(in float3 JMICGAIDJIF, in float3 LBPFPACOALI, float EIEEMLEJCAI, out ELNKPLJCKEF KJPODJIHEGN, out Entity LPCMCOJAFCC)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct MJPDPILNCHF : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Physics)]
	public class SplineLocalBoundsSystem : NKMCJEEJMOK
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[BurstCompile]
		private struct IENLGNFGMNI : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			[ReadOnly]
			public NativeArray<Entity> IIGONOHECHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> OMACNOCELDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			[ReadOnly]
			public ComponentDataFromEntity<MFPGKDHMCFI> MFANKBFKKLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			[WriteOnly]
			public NativeHashMap<Entity, FDAEEOMAIHB>.ParallelWriter IBAIBIOHAAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter AMJOMFGANFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter LIJPDOCDIDG;

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0x51CE1D0", Offset = "0x51CC9D0", VA = "0x1851CE1D0", Slot = "4")]
			public void Execute(int MMABPPDCBIB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[BurstCompile]
		private struct NAMMLCNFOAC : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[ReadOnly]
			public NativeArray<Entity> DAJHEEKMCGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> PJKGKDLFDLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> OMACNOCELDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<MFPGKDHMCFI> LHIIPJCNHMH;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x51D01A0", Offset = "0x51CE9A0", VA = "0x1851D01A0", Slot = "4")]
			public void Execute(int MMABPPDCBIB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery NCDEAFONGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery ECCDOMEDIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery JBBAHALLNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery NIPOMNDLFCJ;

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x3857630", Offset = "0x3855E30", VA = "0x183857630", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x3857840", Offset = "0x3856040", VA = "0x183857840", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x3857550", Offset = "0x3855D50", VA = "0x183857550")]
		private JobHandle OJIPHNJJEFE(global::PEOLEGIGBJF<Entity> KPAFOBEJBIN, int HOPGLJCPGGA, JobHandle EKODEGLIDHA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x38573A0", Offset = "0x3855BA0", VA = "0x1838573A0")]
		private JobHandle OJIPHNJJEFE(NativeArray<Entity> GPFDPCJJKGJ, int HOPGLJCPGGA, [Optional] JobHandle EKODEGLIDHA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x3857320", Offset = "0x3855B20", VA = "0x183857320")]
		private global::PEOLEGIGBJF<Entity> MIGHFPJCFAE(EntityQuery PMKDKHNEPAL)
		{
			return default(global::PEOLEGIGBJF<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x38568B0", Offset = "0x38550B0", VA = "0x1838568B0")]
		private (global::AGEGIHAKIMB<Entity>, global::AGEGIHAKIMB<Entity>) AFLPFBGGFBH(global::PEOLEGIGBJF<Entity> KHLMCMLDFIE)
		{
			return default((global::AGEGIHAKIMB<Entity>, global::AGEGIHAKIMB<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x38572A0", Offset = "0x3855AA0", VA = "0x1838572A0")]
		private void MBKNCEKEJIL(out NativeArray<Entity> NGCJEBOBKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x3857210", Offset = "0x3855A10", VA = "0x183857210")]
		private void LKGLKMKJHGL(NativeList<Entity> NGCJEBOBKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x3857140", Offset = "0x3855940", VA = "0x183857140")]
		private void LKGLKMKJHGL(NativeArray<Entity> NGCJEBOBKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x3857020", Offset = "0x3855820", VA = "0x183857020")]
		private void LHJNELPBCAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		private static void EBHGOLDEGAA(int JEIMODDJOCE, int GLNIAACHEHF, int FFLDIAIPIKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x3856D00", Offset = "0x3855500", VA = "0x183856D00")]
		private static MFPGKDHMCFI CIJFHLCJMBF(NativeArray<Entity> NKOIHOOEHFE, ComponentDataFromEntity<SplinePointData> OMACNOCELDO)
		{
			return default(MFPGKDHMCFI);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[OOAPDBLGMJF(typeof(KIEEHOGAPNN), new string[] { })]
public sealed class BNFDAOEIPOD : KIEEHOGAPNN, DNEGIKEIIMB
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[BurstCompile]
	private struct NFCEDBKICLP : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		[ReadOnly]
		public NativeArray<Entity> NGCJEBOBKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		[ReadOnly]
		public float3 DHPMHBLPFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		[ReadOnly]
		public float3 JBBNNIPHLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> NMNCCJKMACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> HBCAFNHKGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> PJKGKDLFDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointData> OMACNOCELDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[WriteOnly]
		public NativeArray<ELNKPLJCKEF> NBOEJNFOOPF;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static readonly ELNKPLJCKEF HCCNBFNAKGA;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x3848520", Offset = "0x3846D20", VA = "0x183848520", Slot = "4")]
		public void Execute(int MMABPPDCBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x3848ED0", Offset = "0x38476D0", VA = "0x183848ED0")]
		private static float3 NGFPGGJDABP(in float4x4 JKFNDOABIPP, in float3 OGGODOHJPHN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x3848FA0", Offset = "0x38477A0", VA = "0x183848FA0")]
		private static float3 OCGIPJNCGAF(in float4x4 JKFNDOABIPP, in float3 BOMCMOAJNIE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x3849160", Offset = "0x3847960", VA = "0x183849160")]
		private static float3 OEHBHLMCAIF(in float4x4 JKFNDOABIPP, in float3 OGGODOHJPHN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x3848300", Offset = "0x3846B00", VA = "0x183848300")]
		private static float3 BGHHFPPHLGI(in float4x4 JKFNDOABIPP, in float3 BOMCMOAJNIE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x3848000", Offset = "0x3846800", VA = "0x183848000")]
		private bool APPBOLADGGN(in float3 JMICGAIDJIF, in float3 LBPFPACOALI, in NativeArray<Entity> FIPGEGOGNLK, out float3 KJPODJIHEGN, out float3 DBGMAHNILBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x3848800", Offset = "0x3847000", VA = "0x183848800")]
		public static bool MBDFFGCJNHD(in float3 MELGFKBNLMO, in float3 BIGIDDNIBGE, in float3 KDKFAFCCHCH, in float3 FOLNAAPJPGP, float AOJMBOKLHJC, float EGNBHFPBJNC, out float HLNBIKMPIPM, out float3 JBBGLCJIFHA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private EntityManager JGGNCNMICJO;

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8C60", Offset = "0x3AE7460", VA = "0x183AE8C60", Slot = "5")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8A20", Offset = "0x3AE7220", VA = "0x183AE8A20")]
	public void GGAAJFEABCL(in NativeArray<Entity> NGCJEBOBKNP, in float3 JMICGAIDJIF, in float3 LBPFPACOALI, in NativeArray<ELNKPLJCKEF> PKKBALIENCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BNFDAOEIPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x3AE8A20", Offset = "0x3AE7220", VA = "0x183AE8A20", Slot = "4")]
	private void PEJGINAHEPL(in NativeArray<Entity> NGCJEBOBKNP, in float3 JMICGAIDJIF, in float3 LBPFPACOALI, in NativeArray<ELNKPLJCKEF> PKKBALIENCO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct OLFDKNEMAHB : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Lifecycle)]
	public class DestroyLocalObjects : NKMCJEEJMOK
	{
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private bool KAIBIFDFALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private EntityQuery NNBEHDADGPM;

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF22B0", Offset = "0x3AF0AB0", VA = "0x183AF22B0")]
		public bool PNGACAFMNEF(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2110", Offset = "0x3AF0910", VA = "0x183AF2110", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x3AF21A0", Offset = "0x3AF09A0", VA = "0x183AF21A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x11330B0", Offset = "0x11318B0", VA = "0x1811330B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[HPLMCJEDJJG(KOEAPPNBOCD.NetworkSend)]
	public abstract class EnqueuePropertyDifferenceToNetwork : NKMCJEEJMOK, DNEGIKEIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private FGDPFAFKIEA KHECMBICEPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private NCNJODMFFIF JHCECLNHNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private MHOGNFLCFLJ JFKMKONGCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private KBCEGGHPHAF JCLIGOJKKCI;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		protected abstract ComputePropertyDifferences GGBAIOPHKKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7E70", Offset = "0x3AF6670", VA = "0x183AF7E70", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x3AF7F50", Offset = "0x3AF6750", VA = "0x183AF7F50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		private void KCIGNLPJGEP(Entity GDNDJKDEKFN, DDAOHKAFOIC LNNGKIMHKAI, MIEGLNNJAGB PMOKKAEPEEN, FLFHBOLCLFF LNFBHHADIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		protected EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Callbacks)]
	public abstract class PropertyEventCallbacks : NKMCJEEJMOK, DNEGIKEIIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private PropertyEventCallbacksService FMHLMANFIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private KBCEGGHPHAF JCLIGOJKKCI;

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x3851840", Offset = "0x3850040", VA = "0x183851840", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x38518C0", Offset = "0x38500C0", VA = "0x1838518C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		protected PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public abstract class DOFCILIHAHJ : NKMCJEEJMOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private List<(EntityQuery, ComponentType)> OBHAAPDAKDN;

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1D40", Offset = "0x3AF0540", VA = "0x183AF1D40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1F40", Offset = "0x3AF0740", VA = "0x183AF1F40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2090", Offset = "0x3AF0890", VA = "0x183AF2090")]
	protected DOFCILIHAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal struct KGPNPNHINEF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public int DCEMEBHPCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public int ONIBILKIFBC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A090", Offset = "0x3A98890", VA = "0x183A9A090")]
	public static Entity EDIIAGKPKGG(KGPNPNHINEF PJDKPCLOECB)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A090", Offset = "0x3A98890", VA = "0x183A9A090")]
	public static KGPNPNHINEF EDIIAGKPKGG(Entity GDNDJKDEKFN)
	{
		return default(KGPNPNHINEF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal struct FPGLFOCCLHJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct GEPFMJKLAPN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public readonly ComponentType FMNFFKMHMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public readonly NativeList<int> JNGPJPKCCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public readonly NativeList<int> COJCMOGPEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public readonly NativeArray<Entity> NGCJEBOBKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public readonly NativeArray<Entity> OCBNOMJEMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public readonly NativeArray<byte> NOPNDJAEHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public readonly NativeArray<byte> IMLJHLOOKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public readonly int BEDIBCAKPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public readonly int ADALAGNIINO;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool LDMNOKEMLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x3AFADC0", Offset = "0x3AF95C0", VA = "0x183AFADC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x3AFAEE0", Offset = "0x3AF96E0", VA = "0x183AFAEE0")]
	public GEPFMJKLAPN(ComponentType FMNFFKMHMLD, NativeList<int> JNGPJPKCCHN, NativeList<int> COJCMOGPEEH, NativeArray<Entity> NGCJEBOBKNP, NativeArray<Entity> OCBNOMJEMMJ, NativeArray<byte> NOPNDJAEHGP, NativeArray<byte> IMLJHLOOKFM, int BEDIBCAKPCI, int ADALAGNIINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x3AFABB0", Offset = "0x3AF93B0", VA = "0x183AFABB0")]
	private IKKMGBAJNEB BHIPHGDOOJF(NativeArray<byte> KPAFOBEJBIN, int MMABPPDCBIB)
	{
		return default(IKKMGBAJNEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	private T BHIPHGDOOJF<T>(NativeArray<byte> KPAFOBEJBIN, int MMABPPDCBIB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x3AFAE40", Offset = "0x3AF9640", VA = "0x183AFAE40")]
	public IKKMGBAJNEB NCHCPIHHBMI(int MMABPPDCBIB)
	{
		return default(IKKMGBAJNEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	public T NCHCPIHHBMI<T>(int MMABPPDCBIB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x3AFAE90", Offset = "0x3AF9690", VA = "0x183AFAE90")]
	public IKKMGBAJNEB NKNNNKHNMPK(int MMABPPDCBIB)
	{
		return default(IKKMGBAJNEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	public T NKNNNKHNMPK<T>(int MMABPPDCBIB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x3AFACE0", Offset = "0x3AF94E0", VA = "0x183AFACE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public struct MHOKJGPKENN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public readonly EntityQuery PMKDKHNEPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public readonly NativeArray<CIIDHNJHMHD> IEBMFIFBGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public readonly ComponentType FMNFFKMHMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public readonly int BEDIBCAKPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public readonly int ADALAGNIINO;

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E990", Offset = "0x3A9D190", VA = "0x183A9E990")]
	public MHOKJGPKENN(ComponentType FMNFFKMHMLD, int BEDIBCAKPCI, int ADALAGNIINO, EntityQuery PMKDKHNEPAL, NativeArray<CIIDHNJHMHD> IEBMFIFBGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E940", Offset = "0x3A9D140", VA = "0x183A9E940", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal struct PPBOKIFKECF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public int MMABPPDCBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public int JBBECKGHJMB;

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x7E5420", Offset = "0x7E3C20", VA = "0x1807E5420")]
	public PPBOKIFKECF(int MMABPPDCBIB, int JBBECKGHJMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public struct CIIDHNJHMHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public readonly int EGBIMJLECFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public readonly int FBPAKFCOLHM;

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x7E5420", Offset = "0x7E3C20", VA = "0x1807E5420")]
	public CIIDHNJHMHD(int EGBIMJLECFF, int FBPAKFCOLHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public struct FLFHBOLCLFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly FHCGLCCCIJI DGFBLJMJMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private readonly int BEDIBCAKPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private unsafe readonly byte* NOPNDJAEHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private unsafe readonly byte* IMLJHLOOKFM;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x3AFA810", Offset = "0x3AF9010", VA = "0x183AFA810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public FHCGLCCCIJI LMIDIPHLOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x79B630", Offset = "0x799E30", VA = "0x18079B630")]
		get
		{
			return default(FHCGLCCCIJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA820", Offset = "0x3AF9020", VA = "0x183AFA820")]
	public IKKMGBAJNEB IIBHGDOLJCO(Type BCFKLEGAMEO)
	{
		return default(IKKMGBAJNEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA720", Offset = "0x3AF8F20", VA = "0x183AFA720")]
	public IKKMGBAJNEB FEHNHMJOJON(Type BCFKLEGAMEO)
	{
		return default(IKKMGBAJNEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x39B0D80", Offset = "0x39AF580", VA = "0x1839B0D80")]
	public T IIBHGDOLJCO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x39B0D60", Offset = "0x39AF560", VA = "0x1839B0D60")]
	public T FEHNHMJOJON<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA910", Offset = "0x3AF9110", VA = "0x183AFA910")]
	public unsafe FLFHBOLCLFF(FHCGLCCCIJI DGFBLJMJMFI, int FBPAKFCOLHM, byte* NOPNDJAEHGP, byte* IMLJHLOOKFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class ADGKBJDCBEM
{
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] BGFFHCGBDAA;
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[DefaultMember("Item")]
internal class OKAILPBNPJF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private readonly JJLACLCEPON MNIOACBCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private readonly Dictionary<ComponentType, MHOKJGPKENN> DBNEIDMAJLK;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public MHOKJGPKENN ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x3AA7960", Offset = "0x3AA6160", VA = "0x183AA7960")]
		get
		{
			return default(MHOKJGPKENN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x3AA75B0", Offset = "0x3AA5DB0", VA = "0x183AA75B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7DF0", Offset = "0x3AA65F0", VA = "0x183AA7DF0")]
	public OKAILPBNPJF(OMCLDCKMHNM PDJMGPJCDFP, JJLACLCEPON MNIOACBCBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7380", Offset = "0x3AA5B80", VA = "0x183AA7380")]
	public Dictionary<ComponentType, MHOKJGPKENN>.Enumerator CDEDLLPMOKO()
	{
		return default(Dictionary<ComponentType, MHOKJGPKENN>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7410", Offset = "0x3AA5C10", VA = "0x183AA7410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x3AA79F0", Offset = "0x3AA61F0", VA = "0x183AA79F0")]
	private void MBAJOFAPHKB(IEnumerable<CMKIKNDBPFM> ABICEFOHPIC, EntityManager JGGNCNMICJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7600", Offset = "0x3AA5E00", VA = "0x183AA7600")]
	private static int FKCJBAGLAPD(CMKIKNDBPFM INDELOEGBGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x3AA76B0", Offset = "0x3AA5EB0", VA = "0x183AA76B0")]
	private static NativeArray<CIIDHNJHMHD> KCLALGOLDJF(CMKIKNDBPFM INDELOEGBGL, Allocator EGJIMBMGFGA = Allocator.Persistent)
	{
		return default(NativeArray<CIIDHNJHMHD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal interface KBCEGGHPHAF
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	World BGELJNJGDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AHCMEGNGDAH(out NativeArray<int> DJLHOHAIFKO, Allocator EGJIMBMGFGA);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCGJMGKDGFD(ComponentType FMNFFKMHMLD, out GEPFMJKLAPN EAOLJCKGJEI, out MHOKJGPKENN BDIHABFLOBJ);

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CCGJMGKDGFD(ComponentType FMNFFKMHMLD, out GEPFMJKLAPN EAOLJCKGJEI);

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GEPFMJKLAPN FKFOMEPDNNC(ComponentType FMNFFKMHMLD);

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OPNHKCFKNGE HFFHMEPHFOP();

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DPFCFFFBELJ(JobHandle IHONPLJMIOG);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal interface LFKKHIHIDMG
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	World BGELJNJGDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	OKAILPBNPJF GOEGMBNBPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	MLCOIGILHDE HEKFIJCHEBK
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	NativeMultiHashMap<Entity, FLFHBOLCLFF> JINCPCKLHHN
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	JobHandle BKBOKDBMNMM
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
	void MADPLDOCFBN();

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OJEEPLKEKIC();

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BNPENBJNFLH(ComponentType FMNFFKMHMLD, in GEPFMJKLAPN BPBGAEPNHDA);

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MLJFLABMAGN(IOFCPOJDKFL OHBBEKBPFPH, out Entity LGELJKPCDJN);
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[HPLMCJEDJJG(KOEAPPNBOCD.PropertyChanges)]
	[OOAPDBLGMJF(typeof(PropertyDiffStateService), new string[] { })]
	internal class PropertyDiffStateService : DNEGIKEIIMB, PGECBFIGDKK, LFKKHIHIDMG, KBCEGGHPHAF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private OMCLDCKMHNM PDJMGPJCDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private ObjectPrefabCreationService KBJJNECALFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private PLPBBGKMDGB GBKDJPJOGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private OKAILPBNPJF DBNEIDMAJLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private MLCOIGILHDE FICCOFMIFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private IDOCKOGKDOB DEEDINDGNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private List<GEPFMJKLAPN> BICICHKOPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private NativeMultiHashMap<Entity, FLFHBOLCLFF> FOEDDHIPMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private NativeHashMap<int, int> BHGNKNAOKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private JobHandle NMHNAFDIJFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private JobHandle JINEPKMFKPD;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public bool LDMNOKEMLMO
		{
			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x384F960", Offset = "0x384E160", VA = "0x18384F960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		private World LKMEEGFGGKG
		{
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x384F7B0", Offset = "0x384DFB0", VA = "0x18384F7B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		private OKAILPBNPJF GGFMIPHFNNL
		{
			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		private MLCOIGILHDE NPIDMMELPDF
		{
			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x6F5B40", Offset = "0x6F4340", VA = "0x1806F5B40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private NativeMultiHashMap<Entity, FLFHBOLCLFF> KEFNABIAMAO
		{
			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0x7E9640", Offset = "0x7E7E40", VA = "0x1807E9640", Slot = "9")]
			get
			{
				return default(NativeMultiHashMap<Entity, FLFHBOLCLFF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		private JobHandle DKBIMIJICAM
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x7E9610", Offset = "0x7E7E10", VA = "0x1807E9610", Slot = "10")]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x2044C30", Offset = "0x2043430", VA = "0x182044C30", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		private World PKHCBPAJIMF
		{
			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x3850400", Offset = "0x384EC00", VA = "0x183850400", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x384FED0", Offset = "0x384E6D0", VA = "0x18384FED0", Slot = "13")]
		private void LNHPLFCADHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x384F9B0", Offset = "0x384E1B0", VA = "0x18384F9B0", Slot = "12")]
		private void HCACMDCCGFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x384FC90", Offset = "0x384E490", VA = "0x18384FC90", Slot = "14")]
		private void HKFLMBEPPIC(ComponentType FMNFFKMHMLD, in GEPFMJKLAPN BPBGAEPNHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x384FD80", Offset = "0x384E580", VA = "0x18384FD80", Slot = "15")]
		private bool IKBOOICGECC(IOFCPOJDKFL OHBBEKBPFPH, out Entity LGELJKPCDJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x384FE30", Offset = "0x384E630", VA = "0x18384FE30", Slot = "17")]
		private bool LMGNJBPDKCD(out NativeArray<int> DJLHOHAIFKO, Allocator EGJIMBMGFGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x384F640", Offset = "0x384DE40", VA = "0x18384F640", Slot = "18")]
		private bool BGDGPFHFFJA(ComponentType FMNFFKMHMLD, out GEPFMJKLAPN EAOLJCKGJEI, out MHOKJGPKENN BDIHABFLOBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x384F510", Offset = "0x384DD10", VA = "0x18384F510", Slot = "19")]
		private bool BGDGPFHFFJA(ComponentType FMNFFKMHMLD, out GEPFMJKLAPN EAOLJCKGJEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x384FF20", Offset = "0x384E720", VA = "0x18384FF20", Slot = "20")]
		private GEPFMJKLAPN MMNACAAKGIF(ComponentType FMNFFKMHMLD)
		{
			return default(GEPFMJKLAPN);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x384FEE0", Offset = "0x384E6E0", VA = "0x18384FEE0", Slot = "21")]
		private OPNHKCFKNGE MBDELMDDMGO()
		{
			return default(OPNHKCFKNGE);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x384F970", Offset = "0x384E170", VA = "0x18384F970", Slot = "22")]
		private void GFMHCDIDEFN(JobHandle IHONPLJMIOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x384FDA0", Offset = "0x384E5A0", VA = "0x18384FDA0", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x384F2D0", Offset = "0x384DAD0", VA = "0x18384F2D0", Slot = "5")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x384F810", Offset = "0x384E010", VA = "0x18384F810", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x3850150", Offset = "0x384E950", VA = "0x183850150")]
		private void OJEEPLKEKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x384FA70", Offset = "0x384E270", VA = "0x18384FA70")]
		private bool HEDDCKDINPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x3850010", Offset = "0x384E810", VA = "0x183850010")]
		private int NBANEAJIPJL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x38504B0", Offset = "0x384ECB0", VA = "0x1838504B0")]
		public PropertyDiffStateService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal struct OPNHKCFKNGE
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public struct NDLMGBFFKBD : IEnumerator<FLFHBOLCLFF>, IEnumerator, IDisposable, IEnumerable<FLFHBOLCLFF>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly NativeMultiHashMap<Entity, FLFHBOLCLFF> OOOLCIHHFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly Entity GDNDJKDEKFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private NativeMultiHashMapIterator<Entity> PDAMEMMNPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private FLFHBOLCLFF IMLJHLOOKFM;

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public FLFHBOLCLFF IKECDOHOPGM
		{
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x9781F0", Offset = "0x9769F0", VA = "0x1809781F0", Slot = "4")]
			get
			{
				return default(FLFHBOLCLFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x51D0620", Offset = "0x51CEE20", VA = "0x1851D0620", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x51D0670", Offset = "0x51CEE70", VA = "0x1851D0670")]
		internal NDLMGBFFKBD(NativeMultiHashMap<Entity, FLFHBOLCLFF> OOOLCIHHFKM, Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x51D0410", Offset = "0x51CEC10", VA = "0x1851D0410", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x51D03E0", Offset = "0x51CEBE0", VA = "0x1851D03E0")]
		public NDLMGBFFKBD CDEDLLPMOKO()
		{
			return default(NDLMGBFFKBD);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x51D04E0", Offset = "0x51CECE0", VA = "0x1851D04E0", Slot = "9")]
		private IEnumerator<FLFHBOLCLFF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x51D0580", Offset = "0x51CED80", VA = "0x1851D0580", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private readonly LFKKHIHIDMG JCLIGOJKKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private readonly JobHandle GLCICEKBEHM;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public int FPLACAEMJND
	{
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x3AA88C0", Offset = "0x3AA70C0", VA = "0x183AA88C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool KJFIOINAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8550", Offset = "0x3AA6D50", VA = "0x183AA8550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x2EF18E0", Offset = "0x2EF00E0", VA = "0x182EF18E0")]
	public OPNHKCFKNGE(LFKKHIHIDMG JCLIGOJKKCI, JobHandle GLCICEKBEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x3AA89B0", Offset = "0x3AA71B0", VA = "0x183AA89B0")]
	public bool OKEIANICLIC(Allocator EGJIMBMGFGA, out NativeKeyValueArrays<Entity, FLFHBOLCLFF> BBELMPNHPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8750", Offset = "0x3AA6F50", VA = "0x183AA8750")]
	public bool NAHONCENGKE(Allocator EGJIMBMGFGA, out (NativeArray<Entity> entities, int uniqueCount) BBELMPNHPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8630", Offset = "0x3AA6E30", VA = "0x183AA8630")]
	public NDLMGBFFKBD IHIPMJHDEJD(Entity GDNDJKDEKFN)
	{
		return default(NDLMGBFFKBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[DefaultMember("Item")]
internal class MLCOIGILHDE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly JJLACLCEPON MNIOACBCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private readonly List<MHOKJGPKENN> PIJDNOPJENO;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public MHOKJGPKENN ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x3A9FDA0", Offset = "0x3A9E5A0", VA = "0x183A9FDA0")]
		get
		{
			return default(MHOKJGPKENN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x3A9FD60", Offset = "0x3A9E560", VA = "0x183A9FD60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0140", Offset = "0x3A9E940", VA = "0x183AA0140")]
	public MLCOIGILHDE(OKAILPBNPJF DBNEIDMAJLK, OMCLDCKMHNM PDJMGPJCDFP, JJLACLCEPON MNIOACBCBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x3A9FB70", Offset = "0x3A9E370", VA = "0x183A9FB70")]
	public List<MHOKJGPKENN>.Enumerator CDEDLLPMOKO()
	{
		return default(List<MHOKJGPKENN>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A9FBF0", Offset = "0x3A9E3F0", VA = "0x183A9FBF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A9FE30", Offset = "0x3A9E630", VA = "0x183A9FE30")]
	private void MBAJOFAPHKB(OKAILPBNPJF DBNEIDMAJLK, EntityManager JGGNCNMICJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal class IDOCKOGKDOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private readonly JJLACLCEPON MNIOACBCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private readonly ObjectPrefabCreationService KBJJNECALFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private readonly global::GEDPBPAGPNN<CMKIKNDBPFM> HICGDLJCDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private readonly World NHKJKBOJALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private readonly EntityManager JGGNCNMICJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private NativeHashMap<int, Entity> DEEDINDGNEJ;

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x3A969D0", Offset = "0x3A951D0", VA = "0x183A969D0")]
	public IDOCKOGKDOB(ObjectPrefabCreationService KBJJNECALFP, OMCLDCKMHNM PDJMGPJCDFP, JJLACLCEPON MNIOACBCBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A95C60", Offset = "0x3A94460", VA = "0x183A95C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A96970", Offset = "0x3A95170", VA = "0x183A96970")]
	public bool PJAFDPACMIK(IOFCPOJDKFL OHBBEKBPFPH, out Entity LGELJKPCDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x3A95030", Offset = "0x3A93830", VA = "0x183A95030")]
	private void DBMCOGHFDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x3A96190", Offset = "0x3A94990", VA = "0x183A96190")]
	private EntityArchetype JOLOAEDIPHA(EntityArchetype PDKMCLNBPNB)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A95830", Offset = "0x3A94030", VA = "0x183A95830")]
	public static void DLGLJJIPLNL(EntityManager NLDNPCFEGJC, EntityManager KGCHJKNHGKL, NativeArray<Entity> ALFIJBPBFIH, NativeArray<EntityArchetype> BHFEBKMHAPN, [Optional] NativeArray<Entity> BLAPEJKCKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x3A966C0", Offset = "0x3A94EC0", VA = "0x183A966C0")]
	[Conditional("DEBUG_BUILD")]
	private static void OIONCGDOGOF(NativeArray<EntityArchetype> KEFILCBKOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x3A95E70", Offset = "0x3A94670", VA = "0x183A95E70")]
	private static string GCKBFFIBNHO(EntityArchetype CEMLDGMJKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x3A96830", Offset = "0x3A95030", VA = "0x183A96830")]
	[CompilerGenerated]
	internal static void OKAPINLPJBD(ref Span<ComponentType> NIHMFMJOPAE, ComponentType CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x3A95CC0", Offset = "0x3A944C0", VA = "0x183A95CC0")]
	[CompilerGenerated]
	internal static void FPFNHBODLJH(Span<ComponentType> KPAFOBEJBIN, ref Span<ComponentType> NIHMFMJOPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A960B0", Offset = "0x3A948B0", VA = "0x183A960B0")]
	[CompilerGenerated]
	internal static void IOJHIPCCAOO(Span<ComponentType> KPAFOBEJBIN, ref Span<ComponentType> NIHMFMJOPAE, ComponentType BHJPOAAIHII)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[HPLMCJEDJJG(KOEAPPNBOCD.PropertyChanges)]
	public abstract class ApplyPropertyDifferences : NKMCJEEJMOK, DNEGIKEIIMB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private struct GIBINLKKKON
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
			public LANAFNGMGHB dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
			public GIBINLKKKON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct MGAAKHGPAMP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			[ReadOnly]
			public NativeArray<byte> IMLJHLOOKFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			[ReadOnly]
			public NativeList<int> JNGPJPKCCHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			[ReadOnly]
			public NativeArray<Entity> OCBNOMJEMMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public int BEDIBCAKPCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public LANAFNGMGHB LAFBKJMHFEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public ComponentType FMNFFKMHMLD;

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0x3847B60", Offset = "0x3846360", VA = "0x183847B60")]
			internal void BOGFKFCHEFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x3847D70", Offset = "0x3846570", VA = "0x183847D70", Slot = "5")]
			public void ReadFromDisplayClass(ref GIBINLKKKON PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x3847D40", Offset = "0x3846540", VA = "0x183847D40", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x3847D50", Offset = "0x3846550", VA = "0x183847D50")]
			public void GPJBIMHIEAK(ApplyPropertyDifferences AKIOJOCDPLG, ref GIBINLKKKON PIEBCDLFDLA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private KBCEGGHPHAF JCLIGOJKKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private JobHandle NMHNAFDIJFF;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4370", Offset = "0x3AE2B70", VA = "0x183AE4370")]
		public void ECFFKMLILHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x3AE46F0", Offset = "0x3AE2EF0", VA = "0x183AE46F0", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4750", Offset = "0x3AE2F50", VA = "0x183AE4750", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4380", Offset = "0x3AE2B80", VA = "0x183AE4380")]
		private bool FLCIAJNHNOO(JobHandle EKODEGLIDHA, int NDBJIKBMPCB, out JobHandle LPEFOLIJFEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		protected ApplyPropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[HPLMCJEDJJG(KOEAPPNBOCD.PropertyChanges)]
	public abstract class ComputePropertyDifferences : NKMCJEEJMOK, DNEGIKEIIMB, PGECBFIGDKK
	{
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[BurstCompile]
		internal struct KDKMCLELMLG : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			[ReadOnly]
			public NativeArray<byte> MNMMHCPLEPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeArray<byte> ALLKNONMFMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public NativeArray<CIIDHNJHMHD> HCGNKDEPDNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			[WriteOnly]
			public NativeList<PPBOKIFKECF>.ParallelWriter JAAMNENIAFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public int JKIPKBFIHFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public int BIIAFIGIPFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public ProfilerMarker ICMCDEHCMCL;

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0x3847460", Offset = "0x3845C60", VA = "0x183847460", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x38473D0", Offset = "0x3845BD0", VA = "0x1838473D0")]
			private unsafe int CHOHNFKILID(byte* AMFNDHOFBFL, byte* CHHHDNBJJIO)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		[BurstCompile]
		internal struct PABOBIONNNC : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			[WriteOnly]
			public NativeList<int> JNGPJPKCCHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			[WriteOnly]
			public NativeList<int> OKCHHGBIDKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			[ReadOnly]
			public NativeList<PPBOKIFKECF> OGFHDCELOMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public ProfilerMarker ICMCDEHCMCL;

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x38495A0", Offset = "0x3847DA0", VA = "0x1838495A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		[BurstCompile]
		internal struct BPOMDMLJNMG : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			[WriteOnly]
			public NativeArray<byte> NFLFLAEFPLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			[ReadOnly]
			public NativeArray<Entity> NGCJEBOBKNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			[ReadOnly]
			public LANAFNGMGHB JNLHHLEEMPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public int BEDIBCAKPCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public ProfilerMarker ICMCDEHCMCL;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0x3845560", Offset = "0x3843D60", VA = "0x183845560", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		[BurstCompile]
		internal struct BEKDFMDHNLO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, FLFHBOLCLFF> FADAOEDANGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public NativeArray<byte> NOPNDJAEHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public NativeArray<byte> IMLJHLOOKFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			[ReadOnly]
			public NativeArray<Entity> NGCJEBOBKNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeArray<CIIDHNJHMHD> CEDMMGEMCFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public NativeList<int> COJCMOGPEEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			[ReadOnly]
			public NativeList<int> JNGPJPKCCHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public int NKKEOFPKNIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public int ADALAGNIINO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public ProfilerMarker ICMCDEHCMCL;

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x38452E0", Offset = "0x3843AE0", VA = "0x1838452E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private static readonly ProfilerMarker IAJGDHNGCEA;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private static readonly ProfilerMarker INFFLMBMHNE;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly ProfilerMarker IPIHHKMANAG;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private static readonly ProfilerMarker AMLCMLJNILF;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private static readonly ProfilerMarker LHFLBOFLCDH;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private static readonly ProfilerMarker IOAFFGLCDEL;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly ProfilerMarker LKHPNNMPDND;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private static readonly ProfilerMarker BCHNBPGNJCO;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static readonly ProfilerMarker APHLGJMJINK;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private static readonly ProfilerMarker CPNBAOFBFHJ;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private static readonly ProfilerMarker HELNCJNGFMH;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private static readonly ProfilerMarker HKIJGLOKHEN;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private static readonly ProfilerMarker PKKFDBKNAKE;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private static readonly ProfilerMarker PBBHCAIICKM;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private static readonly ProfilerMarker NKKMKAFKEBI;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private static readonly ProfilerMarker MHIBCPEBOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private LFKKHIHIDMG JCLIGOJKKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private ApplyPropertyDifferences PCLKIOHPKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private EntityQuery HFODMANPIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private EntityQuery LOLPPJPPGJA;

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		protected abstract ApplyPropertyDifferences DMGHDHIHHCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		internal World BGELJNJGDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0x3AEA500", Offset = "0x3AE8D00", VA = "0x183AEA500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x3AEAEB0", Offset = "0x3AE96B0", VA = "0x183AEAEB0")]
		internal MHOKJGPKENN GPHLMPMKLLJ(ComponentType FMNFFKMHMLD)
		{
			return default(MHOKJGPKENN);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBB70", Offset = "0x3AEA370", VA = "0x183AEBB70", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "15")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x3AECFC0", Offset = "0x3AEB7C0", VA = "0x183AECFC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x3AED140", Offset = "0x3AEB940", VA = "0x183AED140", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x3AED0F0", Offset = "0x3AEB8F0", VA = "0x183AED0F0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB690", Offset = "0x3AE9E90", VA = "0x183AEB690")]
		private void JMIIHPPLIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x3AEADF0", Offset = "0x3AE95F0", VA = "0x183AEADF0")]
		private void ECGFNDMEGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA550", Offset = "0x3AE8D50", VA = "0x183AEA550")]
		internal void CJDKKFALLPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x3AECC00", Offset = "0x3AEB400", VA = "0x183AECC00")]
		private void OIOIFCMFJEB(NativeArray<Entity> ALFIJBPBFIH, NativeArray<RRObjectPrefabData> FDKHKDLLEGK, ref NativeArray<Entity> LLAFNNINMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBCD0", Offset = "0x3AEA4D0", VA = "0x183AEBCD0")]
		internal void OALIOACIMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x3AEAF50", Offset = "0x3AE9750", VA = "0x183AEAF50")]
		internal void IGDEMOEKGLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC910", Offset = "0x3AEB110", VA = "0x183AEC910")]
		private void OHLPAGMHALJ(MHOKJGPKENN BDIHABFLOBJ, bool AEGHLAGJCCI, ref JobHandle COMJCNIFKCJ, ref JobHandle DBJKPEJBIIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC8E0", Offset = "0x3AEB0E0", VA = "0x183AEC8E0")]
		internal bool OGODAMEOCPM(in MHOKJGPKENN CHHHDNBJJIO, out JobHandle BLIPNDKFLPL, out GEPFMJKLAPN MGAMHEILFFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC000", Offset = "0x3AEA800", VA = "0x183AEC000")]
		private bool OGODAMEOCPM(in MHOKJGPKENN CHHHDNBJJIO, bool AEGHLAGJCCI, out JobHandle BLIPNDKFLPL, out GEPFMJKLAPN MGAMHEILFFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB930", Offset = "0x3AEA130", VA = "0x183AEB930")]
		internal (NativeList<int>, NativeList<int>) JNJLMEEDMDC(NativeList<PPBOKIFKECF> OGFHDCELOMI, int JAFEKEGLGFD, JobHandle EKODEGLIDHA, out JobHandle IHONPLJMIOG, Allocator EGJIMBMGFGA = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x3AED260", Offset = "0x3AEBA60", VA = "0x183AED260")]
		internal static NativeArray<Entity> PNNLCEDIMNF(EntityQuery PMKDKHNEPAL, out JobHandle FCEPPGJNKGP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBAF0", Offset = "0x3AEA2F0", VA = "0x183AEBAF0")]
		internal static NativeArray<byte> LFLPIMKMNMI(int CDDAIIMDJCN, out JobHandle IBNMDMKFNOA)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA3F0", Offset = "0x3AE8BF0", VA = "0x183AEA3F0")]
		internal static NativeArray<byte> CBLCNLGMEDA(EntityQuery PMKDKHNEPAL, int NDBJIKBMPCB, out JobHandle IBNMDMKFNOA)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBBD0", Offset = "0x3AEA3D0", VA = "0x183AEBBD0")]
		internal static NativeArray<Entity> MIGHFPJCFAE(EntityQuery PMKDKHNEPAL, out JobHandle BNGPIIIAHPA)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEABC0", Offset = "0x3AE93C0", VA = "0x183AEABC0")]
		internal NativeArray<byte> DPMAGHICFJO(NativeArray<Entity> NGCJEBOBKNP, MHOKJGPKENN BDIHABFLOBJ, JobHandle EKODEGLIDHA, out JobHandle IHONPLJMIOG, Allocator EGJIMBMGFGA = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x3AECE30", Offset = "0x3AEB630", VA = "0x183AECE30")]
		internal JobHandle OLHKIAAAFOO(in GEPFMJKLAPN PJDKPCLOECB, in MHOKJGPKENN BDIHABFLOBJ, NativeMultiHashMap<Entity, FLFHBOLCLFF> FADAOEDANGI, JobHandle EKODEGLIDHA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x18E76D0", Offset = "0x18E5ED0", VA = "0x1818E76D0")]
		private JobHandle BANCMBABGMM(JobHandle CMJEGAAHPHC, JobHandle FLNHPFNBKLG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x18E76D0", Offset = "0x18E5ED0", VA = "0x1818E76D0")]
		private JobHandle BANCMBABGMM(JobHandle CMJEGAAHPHC, JobHandle FLNHPFNBKLG, JobHandle ACHJALJLBLH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		protected ComputePropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal abstract class MBGLPMPHBGJ : PropagateTagsBase<global::BMIMCLOBNPA, global::MNNEIAHDBGA, MBGLPMPHBGJ.PDFJFKCCCIB>
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public struct PDFJFKCCCIB : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E620", Offset = "0x3A9CE20", VA = "0x183A9E620")]
	protected MBGLPMPHBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E5E0", Offset = "0x3A9CDE0", VA = "0x183A9E5E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal abstract class FBPNJGJBJFJ : PropagateTagsBase<CMKDAPAMLON, global::NBHLBGLKKKA, FBPNJGJBJFJ.GNLHDDIEALD>
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public struct GNLHDDIEALD : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9970", Offset = "0x3AF8170", VA = "0x183AF9970")]
	protected FBPNJGJBJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9930", Offset = "0x3AF8130", VA = "0x183AF9930", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class GNGPLNHBEJK : NFJLGLCMLLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct NHHFENBAGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public NativeArray<int> array;

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		public NHHFENBAGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
		internal void <OnUpdate>b__0(ref AuthoredLocalPoseData localPose)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[BurstCompile]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct JAKFMKOJKID : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct KGKOLGMGCDC
		{
			[Cpp2IlInjected.Token(Token = "0x20000FE")]
			[NoAlias]
			public struct PJKKPENMGLJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400034E")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData>.Runtime AFLFGFONOFP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData> ADBDMBGMICN;

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x51CF620", Offset = "0x51CDE20", VA = "0x1851CF620")]
			public void GPJBIMHIEAK(GNGPLNHBEJK AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x51CF670", Offset = "0x51CDE70", VA = "0x1851CF670")]
			public PJKKPENMGLJ KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
			{
				return default(PJKKPENMGLJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public NativeArray<int> KPAFOBEJBIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private KGKOLGMGCDC HHAICJKMNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KGKOLGMGCDC.PJKKPENMGLJ* AHDLDGHJKHI;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LNJPINDGGKC;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate FMIIGJIEEDH;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x51CE600", Offset = "0x51CCE00", VA = "0x1851CE600")]
		internal void BOGFKFCHEFD(ref AuthoredLocalPoseData NJEKMIPHAEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x12DBFB0", Offset = "0x12DA7B0", VA = "0x1812DBFB0", Slot = "5")]
		public void ReadFromDisplayClass(ref NHHFENBAGLG PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x33B8930", Offset = "0x33B7130", VA = "0x1833B8930", Slot = "6")]
		public void WriteToDisplayClass(ref NHHFENBAGLG PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x51CE7D0", Offset = "0x51CCFD0", VA = "0x1851CE7D0", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x51CE740", Offset = "0x51CCF40", VA = "0x1851CE740")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref KGKOLGMGCDC.PJKKPENMGLJ FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x51CE850", Offset = "0x51CD050", VA = "0x1851CE850")]
		public void GPJBIMHIEAK(GNGPLNHBEJK AKIOJOCDPLG, ref NHHFENBAGLG PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x51CE6D0", Offset = "0x51CCED0", VA = "0x1851CE6D0")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void DOMKBIBFAOB(ArchetypeChunkIterator* HJJIPFNMMEP, void* KKAHEDCANDC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private EntityQuery GAGEOOJNMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private ProfilerMarker JLFMEIKPDHG;

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF5F0", Offset = "0x3AFDDF0", VA = "0x183AFF5F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public GNGPLNHBEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF3C0", Offset = "0x3AFDBC0", VA = "0x183AFF3C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF260", Offset = "0x3AFDA60", VA = "0x183AFF260")]
	public static EntityQuery LPOLPANKDOG(ComponentSystemBase AKIOJOCDPLG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public class ENOPFEBDGCE : NFJLGLCMLLI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct JGLHAPIANOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		public JGLHAPIANOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct EOEPNGGHEPG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		private struct OFHNAHHMMLK
		{
			[Cpp2IlInjected.Token(Token = "0x2000103")]
			[NoAlias]
			public struct OEDPPEFJPBC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400035B")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FOLFDIJKMHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400035C")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointData>.Runtime HBMMOAJNHGG;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity CAKGJJMMLNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplinePointData> EOEIFBJPCHJ;

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x51D1D10", Offset = "0x51D0510", VA = "0x1851D1D10")]
			public void GPJBIMHIEAK(ENOPFEBDGCE AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x51D1D70", Offset = "0x51D0570", VA = "0x1851D1D70")]
			public OEDPPEFJPBC KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
			{
				return default(OEDPPEFJPBC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public EntityManager JGGNCNMICJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public NativeList<Entity> MBIBBBFFLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private OFHNAHHMMLK HHAICJKMNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe OFHNAHHMMLK.OEDPPEFJPBC* AHDLDGHJKHI;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LNJPINDGGKC;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate FMIIGJIEEDH;

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x3845FD0", Offset = "0x38447D0", VA = "0x183845FD0")]
		internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, SplinePointData ADMEPHMBKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x3846240", Offset = "0x3844A40", VA = "0x183846240", Slot = "5")]
		public void ReadFromDisplayClass(ref JGLHAPIANOH PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x3846250", Offset = "0x3844A50", VA = "0x183846250", Slot = "6")]
		public void WriteToDisplayClass(ref JGLHAPIANOH PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x3846190", Offset = "0x3844990", VA = "0x183846190", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x38460C0", Offset = "0x38448C0", VA = "0x1838460C0")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref OFHNAHHMMLK.OEDPPEFJPBC FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x3846200", Offset = "0x3844A00", VA = "0x183846200")]
		public void GPJBIMHIEAK(ENOPFEBDGCE AKIOJOCDPLG, ref JGLHAPIANOH PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x3846050", Offset = "0x3844850", VA = "0x183846050")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void DOMKBIBFAOB(ArchetypeChunkIterator* HJJIPFNMMEP, void* KKAHEDCANDC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private EntityQuery GAGEOOJNMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private ProfilerMarker JLFMEIKPDHG;

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6FF0", Offset = "0x3AF57F0", VA = "0x183AF6FF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public ENOPFEBDGCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6DC0", Offset = "0x3AF55C0", VA = "0x183AF6DC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x3AF6C60", Offset = "0x3AF5460", VA = "0x183AF6C60")]
	public static EntityQuery LPOLPANKDOG(ComponentSystemBase AKIOJOCDPLG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public class OMFBOPCFNPN : NFJLGLCMLLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private EntityQuery ELPFMMPIBFK;

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7F00", Offset = "0x3AA6700", VA = "0x183AA7F00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x3AA7F90", Offset = "0x3AA6790", VA = "0x183AA7F90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public OMFBOPCFNPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public class APILEEKFEPP : NFJLGLCMLLI, DNEGIKEIIMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct LMDKIALENGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public NativeHashMap<DDAOHKAFOIC, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		public LMDKIALENGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MNMCHABNCMC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000108")]
		private struct INECDBBEDAP
		{
			[Cpp2IlInjected.Token(Token = "0x2000109")]
			public struct JHEODADOMHB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000368")]
				public LambdaParameterValueProvider_Entity.Runtime FOLFDIJKMHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000369")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime HCJDJNEOCFF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CAKGJJMMLNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> FLPFECOGOEO;

			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x51CE2A0", Offset = "0x51CCAA0", VA = "0x1851CE2A0")]
			public void GPJBIMHIEAK(APILEEKFEPP AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0x51CE300", Offset = "0x51CCB00", VA = "0x1851CE300")]
			public JHEODADOMHB KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
			{
				return default(JHEODADOMHB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public NativeHashMap<DDAOHKAFOIC, Entity> OOOLCIHHFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private INECDBBEDAP HHAICJKMNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe INECDBBEDAP.JHEODADOMHB* AHDLDGHJKHI;

		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LNJPINDGGKC;

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x3847DB0", Offset = "0x38465B0", VA = "0x183847DB0")]
		internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, ObjectNetworkIdComponentData KCBCMAMBIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x12DBFB0", Offset = "0x12DA7B0", VA = "0x1812DBFB0", Slot = "5")]
		public void ReadFromDisplayClass(ref LMDKIALENGO PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x33B8930", Offset = "0x33B7130", VA = "0x1833B8930", Slot = "6")]
		public void WriteToDisplayClass(ref LMDKIALENGO PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x3847F50", Offset = "0x3846750", VA = "0x183847F50", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x3847EA0", Offset = "0x38466A0", VA = "0x183847EA0")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, ref INECDBBEDAP.JHEODADOMHB FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x3847FC0", Offset = "0x38467C0", VA = "0x183847FC0")]
		public void GPJBIMHIEAK(APILEEKFEPP AKIOJOCDPLG, ref LMDKIALENGO PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x3847E30", Offset = "0x3846630", VA = "0x183847E30")]
		public unsafe static void DOMKBIBFAOB(ArchetypeChunkIterator* HJJIPFNMMEP, void* KKAHEDCANDC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private ObjectNetworkToLocalMapService HEAJCLFOHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery GAGEOOJNMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private ProfilerMarker JLFMEIKPDHG;

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3060", Offset = "0x3AE1860", VA = "0x183AE3060", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3420", Offset = "0x3AE1C20", VA = "0x183AE3420", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public APILEEKFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3220", Offset = "0x3AE1A20", VA = "0x183AE3220", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x3AE30C0", Offset = "0x3AE18C0", VA = "0x183AE30C0")]
	public static EntityQuery LPOLPANKDOG(ComponentSystemBase AKIOJOCDPLG)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Embodiment)]
	public class PostLoadInitializeEmbodiment : NKMCJEEJMOK, DNEGIKEIIMB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[CompilerGenerated]
		private struct NGFLMFKCMHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public NativeList<DDAOHKAFOIC> networkIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public BufferFromEntity<ChildrenData> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public ComponentDataFromEntity<SerializedEmbodiedData> embodiedFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> networkIdFromEntity;

			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
			public NGFLMFKCMHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
			internal void <AddEmbodiedTopologically>b__0(Entity entity, ObjectNetworkIdComponentData component)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct KDPCICBJAHH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200010D")]
			private struct FLFLAAGHOLD
			{
				[Cpp2IlInjected.Token(Token = "0x200010E")]
				[NoAlias]
				public struct IGDIMCKJKHI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000381")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime FOLFDIJKMHB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000382")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime MAJAFDPNIJG;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity CAKGJJMMLNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000380")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> ONLIAAFJJJM;

				[Cpp2IlInjected.Token(Token = "0x600077A")]
				[Cpp2IlInjected.Address(RVA = "0x51CCA10", Offset = "0x51CB210", VA = "0x1851CCA10")]
				public void GPJBIMHIEAK(PostLoadInitializeEmbodiment AKIOJOCDPLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077B")]
				[Cpp2IlInjected.Address(RVA = "0x51CCA70", Offset = "0x51CB270", VA = "0x1851CCA70")]
				public IGDIMCKJKHI KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
				{
					return default(IGDIMCKJKHI);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public NativeList<Entity> NGCJEBOBKNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeList<DDAOHKAFOIC> MEHAANADAAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public BufferFromEntity<ChildrenData> INLDDJNAEPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public ComponentDataFromEntity<SerializedEmbodiedData> CKDOIOIMGKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> OCKILNCFHPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			private FLFLAAGHOLD HHAICJKMNOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe FLFLAAGHOLD.IGDIMCKJKHI* AHDLDGHJKHI;

			[Cpp2IlInjected.Token(Token = "0x400037D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LNJPINDGGKC;

			[Cpp2IlInjected.Token(Token = "0x400037E")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate FMIIGJIEEDH;

			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x51CF040", Offset = "0x51CD840", VA = "0x1851CF040")]
			internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, ObjectNetworkIdComponentData CHHHDNBJJIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x51CF2C0", Offset = "0x51CDAC0", VA = "0x1851CF2C0")]
			internal void IMJDJLNANNL(Entity GDNDJKDEKFN, ObjectNetworkIdComponentData CHHHDNBJJIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x51CF340", Offset = "0x51CDB40", VA = "0x1851CF340")]
			internal void PEMICLAEIHO(Entity GDNDJKDEKFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x51CF4A0", Offset = "0x51CDCA0", VA = "0x1851CF4A0", Slot = "5")]
			public void ReadFromDisplayClass(ref NGFLMFKCMHB PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x51CF4F0", Offset = "0x51CDCF0", VA = "0x1851CF4F0", Slot = "6")]
			public void WriteToDisplayClass(ref NGFLMFKCMHB PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x51CF190", Offset = "0x51CD990", VA = "0x1851CF190", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x51CF0E0", Offset = "0x51CD8E0", VA = "0x1851CF0E0")]
			public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref FLFLAAGHOLD.IGDIMCKJKHI FNDMFEGAALM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x51CF230", Offset = "0x51CDA30", VA = "0x1851CF230")]
			public void GPJBIMHIEAK(PostLoadInitializeEmbodiment AKIOJOCDPLG, ref NGFLMFKCMHB PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x51CF070", Offset = "0x51CD870", VA = "0x1851CF070")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void DOMKBIBFAOB(ArchetypeChunkIterator* HJJIPFNMMEP, void* KKAHEDCANDC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036A")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private EntityQuery CIFNONLAIJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private HBIJPHJPPAA OHLAEPJHHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private NCNJODMFFIF JHCECLNHNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private IACMPOBAJCP ILNNOEDPGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private EntityQuery CEHMAGOFPJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private ProfilerMarker AKFPJEENGIF;

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x384DB00", Offset = "0x384C300", VA = "0x18384DB00", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x384E5D0", Offset = "0x384CDD0", VA = "0x18384E5D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x384E660", Offset = "0x384CE60", VA = "0x18384E660", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x384DBB0", Offset = "0x384C3B0", VA = "0x18384DBB0")]
		private void MDNCPMALGIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x384DF20", Offset = "0x384C720", VA = "0x18384DF20")]
		private NativeArray<DPIGCKLNOCH> NILAGFHMAGE(NativeArray<DDAOHKAFOIC> MEHAANADAAJ)
		{
			return default(NativeArray<DPIGCKLNOCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x384D8B0", Offset = "0x384C0B0", VA = "0x18384D8B0")]
		private void HELBECFEBJF(NativeList<Entity> NGCJEBOBKNP, NativeList<DDAOHKAFOIC> MEHAANADAAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x384D6C0", Offset = "0x384BEC0", VA = "0x18384D6C0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void EKNBANDHHFE(NativeList<DDAOHKAFOIC> MEHAANADAAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		private static void ANOAJICCIAA(NativeList<DDAOHKAFOIC> MEHAANADAAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		public PostLoadInitializeEmbodiment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x384E490", Offset = "0x384CC90", VA = "0x18384E490", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x384E290", Offset = "0x384CA90", VA = "0x18384E290")]
		public static EntityQuery OINDFBAMLNA(ComponentSystemBase AKIOJOCDPLG)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public class LBAEMAKPPPO : NKMCJEEJMOK, DNEGIKEIIMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private struct HDHJBLPLBPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public NativeHashMap<DDAOHKAFOIC, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		public HDHJBLPLBPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x38452D0", Offset = "0x3843AD0", VA = "0x1838452D0")]
		internal void <OnUpdate>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct NIOAKDELAFJ : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		private struct POFGHPCBBIL
		{
			[Cpp2IlInjected.Token(Token = "0x2000113")]
			[NoAlias]
			public struct KEOJJOOPKEH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400038F")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime FOLFDIJKMHB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000390")]
				[NoAlias]
				public LambdaParameterValueProvider_EntityInQueryIndex.Runtime FJNLGMBCLIA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000391")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime HCJDJNEOCFF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity CAKGJJMMLNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_EntityInQueryIndex PKHBIHNELIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> FLPFECOGOEO;

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x51D22A0", Offset = "0x51D0AA0", VA = "0x1851D22A0")]
			public void GPJBIMHIEAK(LBAEMAKPPPO AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x51D2310", Offset = "0x51D0B10", VA = "0x1851D2310")]
			public KEOJJOOPKEH KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
			{
				return default(KEOJJOOPKEH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public NativeHashMap<DDAOHKAFOIC, Entity> OOOLCIHHFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private POFGHPCBBIL HHAICJKMNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe POFGHPCBBIL.KEOJJOOPKEH* AHDLDGHJKHI;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LNJPINDGGKC;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate FMIIGJIEEDH;

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x51D0690", Offset = "0x51CEE90", VA = "0x1851D0690")]
		internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, int JKEOONCAABA, ref ObjectNetworkIdComponentData KCBCMAMBIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x12DBFB0", Offset = "0x12DA7B0", VA = "0x1812DBFB0", Slot = "5")]
		public void ReadFromDisplayClass(ref HDHJBLPLBPG PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x33B8930", Offset = "0x33B7130", VA = "0x1833B8930", Slot = "6")]
		public void WriteToDisplayClass(ref HDHJBLPLBPG PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x51D0860", Offset = "0x51CF060", VA = "0x1851D0860", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x51D0790", Offset = "0x51CEF90", VA = "0x1851D0790")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref POFGHPCBBIL.KEOJJOOPKEH FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x51D0950", Offset = "0x51CF150", VA = "0x1851D0950")]
		public void GPJBIMHIEAK(LBAEMAKPPPO AKIOJOCDPLG, ref HDHJBLPLBPG PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x51D0720", Offset = "0x51CEF20", VA = "0x1851D0720")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void DOMKBIBFAOB(ArchetypeChunkIterator* HJJIPFNMMEP, void* KKAHEDCANDC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private ObjectNetworkToLocalMapService HEAJCLFOHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private EntityQuery GAGEOOJNMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private ProfilerMarker JLFMEIKPDHG;

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B820", Offset = "0x3A9A020", VA = "0x183A9B820", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BC10", Offset = "0x3A9A410", VA = "0x183A9BC10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public LBAEMAKPPPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B9E0", Offset = "0x3A9A1E0", VA = "0x183A9B9E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B880", Offset = "0x3A9A080", VA = "0x183A9B880")]
	public static EntityQuery LPOLPANKDOG(ComponentSystemBase AKIOJOCDPLG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public class KOCIEKIJKIG : NKMCJEEJMOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private EntityQuery CIFNONLAIJF;

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B260", Offset = "0x3A99A60", VA = "0x183A9B260", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x3A9B2F0", Offset = "0x3A99AF0", VA = "0x183A9B2F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public KOCIEKIJKIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public class KDNNLDPHBFF : NKMCJEEJMOK, DNEGIKEIIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private OMCLDCKMHNM EAMEDKLPJKC;

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x3A99940", Offset = "0x3A98140", VA = "0x183A99940", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x3A99AE0", Offset = "0x3A982E0", VA = "0x183A99AE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x3A99E70", Offset = "0x3A98670", VA = "0x183A99E70")]
	private void PKDNGHPAKMD(NativeList<EntityArchetype> KEFILCBKOCJ, NativeHashMap<int, FDAEEOMAIHB> FOPHMEGGGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x3A99340", Offset = "0x3A97B40", VA = "0x183A99340")]
	private void KHBJDDNBBAI(NativeHashMap<int, FDAEEOMAIHB> FOPHMEGGGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public KDNNLDPHBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x3A999A0", Offset = "0x3A981A0", VA = "0x183A999A0")]
	[CompilerGenerated]
	internal static Span<int> NFNGMKFNELO(EntityArchetype CEMLDGMJKAJ)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Serialization)]
	public class PreSerializeRemoveEntities : NKMCJEEJMOK
	{
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private static JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private EntityQuery LOLPPJPPGJA;

		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x384E750", Offset = "0x384CF50", VA = "0x18384E750", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x384E9A0", Offset = "0x384D1A0", VA = "0x18384E9A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[ExecuteAlways]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(CKOMBPJODGO))]
internal sealed class KLNHKEJFOEP : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public KLNHKEJFOEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[PAOAHFGMMNM]
[UpdateAfter(typeof(KLNHKEJFOEP))]
[UpdateInGroup(typeof(CKOMBPJODGO))]
internal sealed class KLKBCAICNFM : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public KLKBCAICNFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[PAOAHFGMMNM]
[ExecuteAlways]
[UpdateInGroup(typeof(HFPDGCKDHLP))]
internal sealed class FDFAEOCPOAG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public FDFAEOCPOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[ExecuteAlways]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(DMBHLIDHMGJ))]
internal sealed class NOHHCJNKAJB : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public NOHHCJNKAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[PAOAHFGMMNM]
[ExecuteAlways]
[UpdateInGroup(typeof(PJKOLMEHIFH))]
internal sealed class NEOJDEHFHFL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public NEOJDEHFHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
[ExecuteAlways]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(JCBICFNBBEL))]
internal sealed class CIDKHBBGCCM : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public CIDKHBBGCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
[ExecuteAlways]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(SimulationSystemGroup))]
internal sealed class BJEEBKJLCFA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public BJEEBKJLCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[ExecuteAlways]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(HFGEIHKLDGF))]
internal sealed class MMJMFLLBCGP : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public MMJMFLLBCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
[ExecuteAlways]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(SimulationSystemGroup))]
internal sealed class KHBINFJALOG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public KHBINFJALOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[HPLMCJEDJJG(KOEAPPNBOCD.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataFromGameObjects : NKMCJEEJMOK
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		[BurstCompile]
		private struct DJNKNBPEBCN : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			private const float KLOECJAKOML = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public NativeArray<Entity> NGCJEBOBKNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> DLCLMAHNNKH;

			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0x3845970", Offset = "0x3844170", VA = "0x183845970", Slot = "4")]
			public void Execute(int MMABPPDCBIB, TransformAccess JDMGKLHBDHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x3845B90", Offset = "0x3844390", VA = "0x183845B90")]
			private bool HNBBJLBGBIA(float3 DIBLIDDDAFJ, float3 OHJKCCOELFF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x3845BE0", Offset = "0x38443E0", VA = "0x183845BE0")]
			private bool IKEOJCBNBCC(quaternion DIBLIDDDAFJ, quaternion OHJKCCOELFF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x3845C10", Offset = "0x3844410", VA = "0x183845C10")]
			private static bool MMPBLFHCCPK(float3 DOGOAAONBOH, float3 ENHIJCCJFBF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x3845E90", Offset = "0x3844690", VA = "0x183845E90")]
			private static bool MMPBLFHCCPK(quaternion FEBCAKEBBCL, quaternion EEACLMBPLFE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x3845B30", Offset = "0x3844330", VA = "0x183845B30")]
			private static bool GIIKNEBCOCP(float HEMCEBJNLDB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x3845B40", Offset = "0x3844340", VA = "0x183845B40")]
			private static float HFIFHJECNOO(quaternion CFFHBIIGOIL, quaternion FIMJONCNGEJ)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct LDMOKBIFICL : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[ReadOnly]
			public NativeArray<Entity> NGCJEBOBKNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> BJKPMMHJNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> NKNNKOCJIBB;

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0x3847940", Offset = "0x3846140", VA = "0x183847940", Slot = "4")]
			public void Execute(int MMABPPDCBIB, TransformAccess JDMGKLHBDHC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private const string EMMCNBJJJEN = "Pose";

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private const string PFGPEHMGDPE = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private const string NPLONFBOIOP = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private static readonly ProfilerMarker GOPDDCANAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private RegisterTransforms JBFOBKFCMLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private TransformAccessArray LMNDENNNCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private OMCLDCKMHNM PDJMGPJCDFP;

		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF7E0", Offset = "0x3AEDFE0", VA = "0x183AEF7E0")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF840", Offset = "0x3AEE040", VA = "0x183AEF840", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF8B0", Offset = "0x3AEE0B0", VA = "0x183AEF8B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF910", Offset = "0x3AEE110", VA = "0x183AEF910", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[HPLMCJEDJJG(KOEAPPNBOCD.TransformSyncing)]
	public class RegisterTransforms : NKMCJEEJMOK
	{
		[Cpp2IlInjected.Token(Token = "0x2000125")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct FAFOIKIFKBL : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000126")]
			private struct BGKPOCIIGPO
			{
				[Cpp2IlInjected.Token(Token = "0x2000127")]
				public struct FNDAGEKGEEA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003B6")]
					public LambdaParameterValueProvider_Entity.Runtime FOLFDIJKMHB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003B7")]
					public LambdaParameterValueProvider_IComponentData<GMNCMFEFGOD>.Runtime MKFHOLPGCGL;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40003B8")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime FMOHPJOIGAD;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity CAKGJJMMLNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<GMNCMFEFGOD> DCIHPFJPKDD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003B5")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> JGDFHFHNEIG;

				[Cpp2IlInjected.Token(Token = "0x60007D5")]
				[Cpp2IlInjected.Address(RVA = "0x51CB240", Offset = "0x51C9A40", VA = "0x1851CB240")]
				public void GPJBIMHIEAK(RegisterTransforms AKIOJOCDPLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007D6")]
				[Cpp2IlInjected.Address(RVA = "0x51CB2C0", Offset = "0x51C9AC0", VA = "0x1851CB2C0")]
				public FNDAGEKGEEA KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
				{
					return default(FNDAGEKGEEA);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			private BGKPOCIIGPO HHAICJKMNOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe BGKPOCIIGPO.FNDAGEKGEEA* AHDLDGHJKHI;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate LNJPINDGGKC;

			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x51CC5A0", Offset = "0x51CADA0", VA = "0x1851CC5A0")]
			internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, GMNCMFEFGOD MOIHFCJJBCN, Transform JDMGKLHBDHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x51CC7F0", Offset = "0x51CAFF0", VA = "0x1851CC7F0", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x51CC710", Offset = "0x51CAF10", VA = "0x1851CC710")]
			public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, ref BGKPOCIIGPO.FNDAGEKGEEA FNDMFEGAALM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x51CC8E0", Offset = "0x51CB0E0", VA = "0x1851CC8E0")]
			public void GPJBIMHIEAK(RegisterTransforms AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x51CC6A0", Offset = "0x51CAEA0", VA = "0x1851CC6A0")]
			public unsafe static void DOMKBIBFAOB(ArchetypeChunkIterator* HJJIPFNMMEP, void* KKAHEDCANDC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000128")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct EDKIOPFONFM : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			private struct BIIFKLEALBJ
			{
				[Cpp2IlInjected.Token(Token = "0x200012A")]
				[NoAlias]
				public struct HGOHBCGNIEF
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003BD")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime FOLFDIJKMHB;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003BE")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<GMNCMFEFGOD>.Runtime MKFHOLPGCGL;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003BB")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity CAKGJJMMLNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003BC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<GMNCMFEFGOD> DCIHPFJPKDD;

				[Cpp2IlInjected.Token(Token = "0x60007DB")]
				[Cpp2IlInjected.Address(RVA = "0x51CB380", Offset = "0x51C9B80", VA = "0x1851CB380")]
				public void GPJBIMHIEAK(RegisterTransforms AKIOJOCDPLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007DC")]
				[Cpp2IlInjected.Address(RVA = "0x51CB3E0", Offset = "0x51C9BE0", VA = "0x1851CB3E0")]
				public HGOHBCGNIEF KMEBAOPBKHA(ref ArchetypeChunk KFFGGPBBBCP, int ODNCIFBDEFD, int AKLJBKCBEHD)
				{
					return default(HGOHBCGNIEF);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			private BIIFKLEALBJ HHAICJKMNOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe BIIFKLEALBJ.HGOHBCGNIEF* AHDLDGHJKHI;

			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x51CBFA0", Offset = "0x51CA7A0", VA = "0x1851CBFA0")]
			internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, GMNCMFEFGOD MOIHFCJJBCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0x51CC130", Offset = "0x51CA930", VA = "0x1851CC130", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0x51CC080", Offset = "0x51CA880", VA = "0x1851CC080")]
			public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref BIIFKLEALBJ.HGOHBCGNIEF FNDMFEGAALM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0x51CB380", Offset = "0x51C9B80", VA = "0x1851CB380")]
			public void GPJBIMHIEAK(RegisterTransforms AKIOJOCDPLG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private PNHIIFJBMMO NCIENJPEEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EBPNDNCEIPG NODCGJENFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private EntityQuery JKKEKMOBIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private EntityQuery PBNJGMGNFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private EntityQuery KIEHOAGCPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private EntityQuery DKICFNAJNDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private ProfilerMarker JEBEAJBECHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private EntityQuery ICJLPIPJALJ;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public EBPNDNCEIPG DPABKFGODDH
		{
			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0xCE1AA0", Offset = "0xCE02A0", VA = "0x180CE1AA0")]
			get
			{
				return default(EBPNDNCEIPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x3852590", Offset = "0x3850D90", VA = "0x183852590", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x3852760", Offset = "0x3850F60", VA = "0x183852760", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x3852770", Offset = "0x3850F70", VA = "0x183852770", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x3851FF0", Offset = "0x38507F0", VA = "0x183851FF0")]
		private void KINIJKJOKAO(NativeArray<Entity> NGCJEBOBKNP, EBPNDNCEIPG DLHMEKKBAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x3851970", Offset = "0x3850170", VA = "0x183851970")]
		[BurstCompile]
		internal static void ABGDPBOHFNG(NativeArray<GMNCMFEFGOD> MGMFAAEJECC, ComponentDataFromEntity<GMNCMFEFGOD> KLNFALJHMGB, EBPNDNCEIPG DLHMEKKBAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		private static void DAANMBADODI(Transform JDMGKLHBDHC, Entity GDNDJKDEKFN, int MMABPPDCBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		private static void NAFCEAPFBPA(Entity GDNDJKDEKFN, int MMABPPDCBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		private static void HAKNIFEJALB(int MMABPPDCBIB, EBPNDNCEIPG DLHMEKKBAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x3852130", Offset = "0x3850930", VA = "0x183852130")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void LDAOJBDCMLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x3852310", Offset = "0x3850B10", VA = "0x183852310", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x3851E50", Offset = "0x3850650", VA = "0x183851E50")]
		public static EntityQuery FGEIKNOOFNB(ComponentSystemBase AKIOJOCDPLG)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x3851C80", Offset = "0x3850480", VA = "0x183851C80")]
		public static EntityQuery EBNMDFEKDPH(ComponentSystemBase AKIOJOCDPLG)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[HPLMCJEDJJG(KOEAPPNBOCD.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataToGameObjects : NKMCJEEJMOK
	{
		[Cpp2IlInjected.Token(Token = "0x200012C")]
		[BurstCompile]
		private struct NJJGPIFCEGL : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> DLCLMAHNNKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			[ReadOnly]
			public NativeArray<Entity> NGCJEBOBKNP;

			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0x38492D0", Offset = "0x3847AD0", VA = "0x1838492D0", Slot = "4")]
			public void Execute(int MMABPPDCBIB, TransformAccess JDMGKLHBDHC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012D")]
		[BurstCompile]
		private struct CALPEGOOFLN : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> BJKPMMHJNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			[ReadOnly]
			public NativeArray<Entity> NGCJEBOBKNP;

			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x3845620", Offset = "0x3843E20", VA = "0x183845620", Slot = "4")]
			public void Execute(int MMABPPDCBIB, TransformAccess JDMGKLHBDHC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct GKJNKOEBIPP : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> BJKPMMHJNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> NKNNKOCJIBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			[ReadOnly]
			public NativeArray<Entity> NGCJEBOBKNP;

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x38464D0", Offset = "0x3844CD0", VA = "0x1838464D0", Slot = "4")]
			public void Execute(int MMABPPDCBIB, TransformAccess JDMGKLHBDHC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private const string EMMCNBJJJEN = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private const string PFGPEHMGDPE = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private const string NPLONFBOIOP = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly JJLACLCEPON NJLPDJKCJGP;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private static readonly JJLACLCEPON HLCEOBDPHIG;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private static readonly JJLACLCEPON OFHMJDFJIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private PGANDFDLKLA JBFOBKFCMLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private JobHandle BJJJBLBIEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private EntityQuery GJGGJHEHNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery LOJEPBCMKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private EntityQuery ELLKPJJLHEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private TransformAccessArray IFEEHGFBGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private TransformAccessArray KBGBKGBJGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TransformAccessArray KEHKBEHLMEA;

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x3AEFE70", Offset = "0x3AEE670", VA = "0x183AEFE70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x3AF00E0", Offset = "0x3AEE8E0", VA = "0x183AF00E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x745CB0", Offset = "0x7444B0", VA = "0x180745CB0")]
		internal JobHandle FCGELOCOFCA()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0120", Offset = "0x3AEE920", VA = "0x183AF0120", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x3AEFCF0", Offset = "0x3AEE4F0", VA = "0x183AEFCF0")]
		private NativeArray<Entity> BMDMJEAINLH(NativeArray<GMNCMFEFGOD> JNGPJPKCCHN, NativeList<Entity> ALFIJBPBFIH, TransformAccessArray EIHANBNLKFP, TransformAccessArray NNAENIMPPOH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public class MMHIHGBHDFB : NKMCJEEJMOK, PGECBFIGDKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private LHHEJKEEMLP CFBNHCODAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private PIEJAMPEPCM AOBKLHHNECH;

	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0220", Offset = "0x3A9EA20", VA = "0x183AA0220", Slot = "14")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x3AA06A0", Offset = "0x3A9EEA0", VA = "0x183AA06A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x3AA03C0", Offset = "0x3A9EBC0", VA = "0x183AA03C0")]
	private static void EBAKAAKBBPF(EntityManager JGGNCNMICJO, Entity GDNDJKDEKFN, Entity OJKLIAPCMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x3AA05A0", Offset = "0x3A9EDA0", VA = "0x183AA05A0")]
	private static Transform IAHHILHKCHF(EntityManager JGGNCNMICJO, Entity GDNDJKDEKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public MMHIHGBHDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[HPLMCJEDJJG(KOEAPPNBOCD.TransformSyncing)]
	public class L2PToL2WHierarchy : NKMCJEEJMOK
	{
		[Cpp2IlInjected.Token(Token = "0x2000131")]
		[BurstCompile]
		private struct GIADPIBAOFM : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> KGFACDMKOMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> OIIKJOGCPIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> EILPMEOCNOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> KNKLDLFAHNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public ArchetypeChunkComponentType<LocalToWorldData> KIFFFGJMDNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> DEPCGNKONEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public uint NMONBMHAJLB;

			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x51CD2B0", Offset = "0x51CBAB0", VA = "0x1851CD2B0")]
			[Conditional("DEBUG_BUILD")]
			private void PLLODIFHKOE(Entity GDNDJKDEKFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x51CCB40", Offset = "0x51CB340", VA = "0x1851CCB40", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int MMABPPDCBIB, int CHKCAGABANB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x51CCE60", Offset = "0x51CB660", VA = "0x1851CCE60")]
			private bool IEJEPDBIIFG(ArchetypeChunk DAJPMMDPFFK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x51CCF20", Offset = "0x51CB720", VA = "0x1851CCF20")]
			private void KHEHOBPGNPH(float4x4 MLHBPBMGGJG, Entity GDNDJKDEKFN, bool HOGDBEBBPNG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private EntityQuery EGNOPKCEHNK;

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x3A9B4C0", Offset = "0x3A99CC0", VA = "0x183A9B4C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x3A9B560", Offset = "0x3A99D60", VA = "0x183A9B560", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
public class NHFAKPHCDOK : OFMIDBOIMPP
{
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[BurstCompile]
	private struct JPOAAGODIDP : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> KGFACDMKOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public ArchetypeChunkComponentType<LocalToWorldData> KIFFFGJMDNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public uint NMONBMHAJLB;

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0x51CE970", Offset = "0x51CD170", VA = "0x1851CE970", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int MMABPPDCBIB, int CHKCAGABANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x51CEA70", Offset = "0x51CD270", VA = "0x1851CEA70")]
		public bool IEJEPDBIIFG(ArchetypeChunk DAJPMMDPFFK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private EntityQuery EGNOPKCEHNK;

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2780", Offset = "0x3AA0F80", VA = "0x183AA2780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x3AA28B0", Offset = "0x3AA10B0", VA = "0x183AA28B0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle FMEBGAACPOB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public NHFAKPHCDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
public class OIFMLHBPOGG : OFMIDBOIMPP
{
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[BurstCompile]
	private struct BBBHPNOIHHI : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> MPKIFMHKCEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public ArchetypeChunkComponentType<WorldPoseData> AFAHOKJBFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> EHPBOCNILBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> AGPGJGPOKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public uint NMONBMHAJLB;

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x51CAE10", Offset = "0x51C9610", VA = "0x1851CAE10", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int MMABPPDCBIB, int CHKCAGABANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x51CB1C0", Offset = "0x51C99C0", VA = "0x1851CB1C0")]
		public bool IEJEPDBIIFG(ArchetypeChunk DAJPMMDPFFK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private EntityQuery ILNNOEDPGOH;

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6780", Offset = "0x3AA4F80", VA = "0x183AA6780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6890", Offset = "0x3AA5090", VA = "0x183AA6890", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle FMEBGAACPOB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public OIFMLHBPOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
public class PEAALDMLHHD : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[BurstCompile]
	private struct IDCDNDEFOPM : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> MMEFOAPILKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> HCPNMFFHJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> HEAHEEKNHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public ArchetypeChunkComponentType<LocalToParentData> MAHCEHHJLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public uint NMONBMHAJLB;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x51CD9B0", Offset = "0x51CC1B0", VA = "0x1851CD9B0", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int MMABPPDCBIB, int CHKCAGABANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x51CE0F0", Offset = "0x51CC8F0", VA = "0x1851CE0F0")]
		public bool IEJEPDBIIFG(ArchetypeChunk DAJPMMDPFFK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private EntityQuery ILNNOEDPGOH;

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x3AB15C0", Offset = "0x3AAFDC0", VA = "0x183AB15C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x3AB16F0", Offset = "0x3AAFEF0", VA = "0x183AB16F0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle FMEBGAACPOB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960")]
	public PEAALDMLHHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal abstract class PAEKHBEHAKA : PropagateTagsBase<global::GLJNFILDIDJ, global::MGBPOLEKKNF, PAEKHBEHAKA.AJDHHBJHBIB>
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	public struct AJDHHBJHBIB : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000809")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BDC0", Offset = "0x3A9A5C0", VA = "0x183A9BDC0")]
	protected PAEKHBEHAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BD80", Offset = "0x3A9A580", VA = "0x183A9BD80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
[KPDDDDKCLKD(CCPAEMCMCPC.Game)]
public class HOOFOCOIPLI : EOAAJGFHLFL
{
	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public Type CGJAADBHIED
	{
		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x3A94B70", Offset = "0x3A93370", VA = "0x183A94B70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public Type[] CKDBLNKNMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x3A946D0", Offset = "0x3A92ED0", VA = "0x183A946D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public HOOFOCOIPLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[KPDDDDKCLKD(CCPAEMCMCPC.Loading)]
public class FCEDGINPEAJ : EOAAJGFHLFL
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Type CGJAADBHIED
	{
		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x6670F0", Offset = "0x6658F0", VA = "0x1806670F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Type[] CKDBLNKNMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9A40", Offset = "0x3AF8240", VA = "0x183AF9A40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public FCEDGINPEAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
public sealed class PMABMFGMPBA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public PMABMFGMPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(PMABMFGMPBA))]
public sealed class PDGFELEPEIP : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public PDGFELEPEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(PMABMFGMPBA))]
[UpdateAfter(typeof(PDGFELEPEIP))]
public sealed class KJNGLNMAMKD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public KJNGLNMAMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
[KPDDDDKCLKD(CCPAEMCMCPC.Saving)]
public class PKIIOKJDBNN : EOAAJGFHLFL
{
	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public Type CGJAADBHIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x6670F0", Offset = "0x6658F0", VA = "0x1806670F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Type[] CKDBLNKNMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2A80", Offset = "0x3AB1280", VA = "0x183AB2A80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000819")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public PKIIOKJDBNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
public sealed class AKGOFDBJCCO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public AKGOFDBJCCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
[KPDDDDKCLKD(CCPAEMCMCPC.Simulation)]
public class OALOFNNGHBK : EOAAJGFHLFL
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Type CGJAADBHIED
	{
		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x3AA4A80", Offset = "0x3AA3280", VA = "0x183AA4A80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Type[] CKDBLNKNMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x3AA4830", Offset = "0x3AA3030", VA = "0x183AA4830", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public OALOFNNGHBK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Connectables, new string[] { "Callbacks" })]
	[OOAPDBLGMJF(typeof(MHPBKECLGEM), new string[] { })]
	internal class ConnectableService : MHPBKECLGEM, DNEGIKEIIMB, PGECBFIGDKK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000143")]
		[CompilerGenerated]
		private sealed class HJAIFEBOGNC : IEnumerable<IOFHLMDPEAL>, IEnumerable, IEnumerator<IOFHLMDPEAL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			private IOFHLMDPEAL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			private IOFHLMDPEAL localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			public IOFHLMDPEAL <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x170000EB")]
			private IOFHLMDPEAL System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000844")]
				[Cpp2IlInjected.Address(RVA = "0x74A710", Offset = "0x748F10", VA = "0x18074A710", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(IOFHLMDPEAL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EC")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000846")]
				[Cpp2IlInjected.Address(RVA = "0x3846A60", Offset = "0x3845260", VA = "0x183846A60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0x7F7420", Offset = "0x7F5C20", VA = "0x1807F7420")]
			[DebuggerHidden]
			public HJAIFEBOGNC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0x3846AB0", Offset = "0x38452B0", VA = "0x183846AB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0x3846680", Offset = "0x3844E80", VA = "0x183846680", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000842")]
			[Cpp2IlInjected.Address(RVA = "0x3846B80", Offset = "0x3845380", VA = "0x183846B80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000843")]
			[Cpp2IlInjected.Address(RVA = "0x3846BD0", Offset = "0x38453D0", VA = "0x183846BD0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0x3846A20", Offset = "0x3845220", VA = "0x183846A20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0x3846970", Offset = "0x3845170", VA = "0x183846970", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IOFHLMDPEAL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0x3846970", Offset = "0x3845170", VA = "0x183846970", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private const string BLBICJOMHFI = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private static readonly JJLACLCEPON EBLENELBPLH;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public const int CEPFFIGGJEC = 0;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public const int OFFCJCBCMEK = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private NCNJODMFFIF JHCECLNHNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private IACMPOBAJCP ILNNOEDPGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private OMCLDCKMHNM EAMEDKLPJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private HBIJPHJPPAA OHLAEPJHHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private PropertyEventCallbacksService HODCAEDHJPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private global::AFCNIFIINJI<AuthoredParentData, HDODHPJEEDH, KANIAOHNMNJ, AuthoredChildrenData> GNILOBIBNGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private global::CIHBFHMIFFK<Entity> KBNDGJGDLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private global::CIHBFHMIFFK<float3> HDBCFMCDCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private global::CIHBFHMIFFK<quaternion> ACALGGACCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private global::CIHBFHMIFFK<Entity> OJKLIAPCMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private global::CIHBFHMIFFK<float3> BIFOHEGELJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private global::CIHBFHMIFFK<quaternion> LLCDBICBDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private HashSet<Entity> KJGNLPBFPDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private HashSet<Entity> IACBJKEAGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private EntityQuery AEIMKNPBCMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private bool KAIBIFDFALJ;

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public Func<GLFPMFLGMPH> IDCFIFPKFFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000827")]
			[Cpp2IlInjected.Address(RVA = "0x761DA0", Offset = "0x7605A0", VA = "0x180761DA0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0x762070", Offset = "0x760870", VA = "0x180762070", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<IOFHLMDPEAL, IOFHLMDPEAL> LJINJODFJON
		{
			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0x3AEEFB0", Offset = "0x3AED7B0", VA = "0x183AEEFB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0x3AEF310", Offset = "0x3AEDB10", VA = "0x183AEF310", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<IOFHLMDPEAL, IOFHLMDPEAL> NKIIFEHMJNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0x3AEF270", Offset = "0x3AEDA70", VA = "0x183AEF270", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x3AEEF10", Offset = "0x3AED710", VA = "0x183AEEF10", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<IOFHLMDPEAL, IOFHLMDPEAL, IOFHLMDPEAL> NNDOMCIEMIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0x3AEDF50", Offset = "0x3AEC750", VA = "0x183AEDF50", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0x3AEF050", Offset = "0x3AED850", VA = "0x183AEF050", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<IOFHLMDPEAL> JMMDJGLNCPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0x3AEDEB0", Offset = "0x3AEC6B0", VA = "0x183AEDEB0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0x3AEE360", Offset = "0x3AECB60", VA = "0x183AEE360", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF0F0", Offset = "0x3AED8F0", VA = "0x183AEF0F0", Slot = "23")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x3AED6F0", Offset = "0x3AEBEF0", VA = "0x183AED6F0", Slot = "24")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE1B0", Offset = "0x3AEC9B0", VA = "0x183AEE1B0", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE400", Offset = "0x3AECC00", VA = "0x183AEE400")]
		private void EOFPOLBANEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE930", Offset = "0x3AED130", VA = "0x183AEE930")]
		private void HILFIMEEMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x3AEDFF0", Offset = "0x3AEC7F0", VA = "0x183AEDFF0")]
		private void DMIKAHIKBLD(Entity GDNDJKDEKFN, FHCGLCCCIJI LKIMNIMPHKB, IKKMGBAJNEB OHJKCCOELFF, IKKMGBAJNEB DIBLIDDDAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x3AEDC70", Offset = "0x3AEC470", VA = "0x183AEDC70")]
		private void BLGOPFBMCAC(Entity GDNDJKDEKFN, FHCGLCCCIJI LKIMNIMPHKB, IKKMGBAJNEB OHJKCCOELFF, IKKMGBAJNEB DIBLIDDDAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x18E76D0", Offset = "0x18E5ED0", VA = "0x1818E76D0", Slot = "14")]
		public IOFHLMDPEAL CIMKIICGCAJ(IOFHLMDPEAL CPBDAEHELGD, int KDCEBOLCINA)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x2414FD0", Offset = "0x24137D0", VA = "0x182414FD0", Slot = "15")]
		public Color FIPOFPFOMBP(IOFHLMDPEAL CPBDAEHELGD, int KDCEBOLCINA)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x3AEDCD0", Offset = "0x3AEC4D0", VA = "0x183AEDCD0", Slot = "16")]
		public float3 BLPPNLINACG(IOFHLMDPEAL CPBDAEHELGD, int KDCEBOLCINA)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE460", Offset = "0x3AECC60", VA = "0x183AEE460", Slot = "17")]
		public void EPDJFMCJDGO(IOFHLMDPEAL CPBDAEHELGD, IOFHLMDPEAL PCEACEKDHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE700", Offset = "0x3AECF00", VA = "0x183AEE700", Slot = "18")]
		public IOFHLMDPEAL GECBLHBNBIF(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x3AEEAA0", Offset = "0x3AED2A0", VA = "0x183AEEAA0", Slot = "21")]
		public void HNEAMECENCB(IOFHLMDPEAL CPBDAEHELGD, Vector3 EPDCMCDGMOM, Quaternion FNABBPCCGNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF530", Offset = "0x3AEDD30", VA = "0x183AEF530", Slot = "26")]
		public (Vector3, Quaternion) OMLACCAEJFJ(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF3B0", Offset = "0x3AEDBB0", VA = "0x183AEF3B0", Slot = "27")]
		public (Vector3, Quaternion) OEBBAGCPONH(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE7A0", Offset = "0x3AECFA0", VA = "0x183AEE7A0", Slot = "22")]
		public (Vector3, Quaternion, bool) GOOMNMACDEK(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default((Vector3, Quaternion, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x3AEDBE0", Offset = "0x3AEC3E0", VA = "0x183AEDBE0", Slot = "19")]
		[IteratorStateMachine(typeof(HJAIFEBOGNC))]
		public IEnumerable<IOFHLMDPEAL> BEGMMKOFLKO(IOFHLMDPEAL CPBDAEHELGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x3AEECB0", Offset = "0x3AED4B0", VA = "0x183AEECB0", Slot = "20")]
		public IOFHLMDPEAL IKKJIKAMHEN(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE530", Offset = "0x3AECD30", VA = "0x183AEE530", Slot = "28")]
		public void FKLMDHDNEKK(ref List<IOFHLMDPEAL> LCOODLIGMCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x3AEEDF0", Offset = "0x3AED5F0", VA = "0x183AEEDF0")]
		private Entity IKKJIKAMHEN(Entity GDNDJKDEKFN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF730", Offset = "0x3AEDF30", VA = "0x183AEF730")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[OOAPDBLGMJF(typeof(EntityHierarchyChildren), new string[] { })]
	[HPLMCJEDJJG(KOEAPPNBOCD.HierarchySystems)]
	internal sealed class EntityHierarchyChildren : DNEGIKEIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private OMCLDCKMHNM EAMEDKLPJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private PKDIGKBPILP OBHAAPDAKDN;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		private EntityManager FHACAKFHJON
		{
			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0x3AF8690", Offset = "0x3AF6E90", VA = "0x183AF8690")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8AA0", Offset = "0x3AF72A0", VA = "0x183AF8AA0", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8510", Offset = "0x3AF6D10", VA = "0x183AF8510")]
		internal void CMNFPDHNNKL(Entity OJKLIAPCMPJ, Entity FOCEJAMAOBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8EC0", Offset = "0x3AF76C0", VA = "0x183AF8EC0")]
		internal void PDJBCLPHIJB(Entity OJKLIAPCMPJ, Entity FOCEJAMAOBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8D00", Offset = "0x3AF7500", VA = "0x183AF8D00")]
		private int OLFNGHAKDCC(Entity OJKLIAPCMPJ, Entity FOCEJAMAOBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x3AF89D0", Offset = "0x3AF71D0", VA = "0x183AF89D0")]
		internal DynamicBuffer<ChildrenData> KMFFDFLPPHH(Entity GDNDJKDEKFN)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8DF0", Offset = "0x3AF75F0", VA = "0x183AF8DF0")]
		internal DynamicBuffer<ChildrenData> PAGLOLOIANN(Entity GDNDJKDEKFN)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8C30", Offset = "0x3AF7430", VA = "0x183AF8C30")]
		public NativeArray<Entity> MIKFFAGHOIO(Entity GDNDJKDEKFN, Allocator EGJIMBMGFGA)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x3AF87D0", Offset = "0x3AF6FD0", VA = "0x183AF87D0")]
		public bool JPNKKLEBOIA(Entity GDNDJKDEKFN, Allocator EGJIMBMGFGA, out NativeArray<Entity> BDILHNBAAJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x3AF88A0", Offset = "0x3AF70A0", VA = "0x183AF88A0")]
		public NativeArray<Entity> KEDPBHCIMAI(Entity GDNDJKDEKFN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8B20", Offset = "0x3AF7320", VA = "0x183AF8B20")]
		public Entity LHFLPHOIPHJ(Entity GDNDJKDEKFN, int MMABPPDCBIB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x3AF86E0", Offset = "0x3AF6EE0", VA = "0x183AF86E0")]
		public int IGNPFNMNMOD(Entity GDNDJKDEKFN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public EntityHierarchyChildren()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[OOAPDBLGMJF(typeof(EntityHierarchyEvents), new string[] { })]
	[HPLMCJEDJJG(KOEAPPNBOCD.HierarchySystems)]
	internal sealed class EntityHierarchyEvents : DNEGIKEIIMB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private OMCLDCKMHNM EAMEDKLPJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private ObjectEmbodimentService EGJPJHAOMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private ObjectLifecycleService ICECBOBFDDC;

		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9130", Offset = "0x3AF7930", VA = "0x183AF9130", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x3AF8FE0", Offset = "0x3AF77E0", VA = "0x183AF8FE0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		private void CNBELOKPKAI(CMIMIKMOPKA EGJPJHAOMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		private void JLNOHPLNCCK(CMIMIKMOPKA EGJPJHAOMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
		private void KHHFONDHJBM(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public EntityHierarchyEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[HPLMCJEDJJG(KOEAPPNBOCD.HierarchySystems)]
	[OOAPDBLGMJF(typeof(EntityHierarchyParents), new string[] { })]
	internal sealed class EntityHierarchyParents : DNEGIKEIIMB, PGECBFIGDKK
	{
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private IACMPOBAJCP ILNNOEDPGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private global::CIHBFHMIFFK<Entity> MIGODNJAHNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private PropertyChangeNetworkRouter OMDCIJELNIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private global::AFCNIFIINJI<ParentData, IBNCHDDCFDM, OJMGOMNBCIH, ChildrenData> GNILOBIBNGC;

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9680", Offset = "0x3AF7E80", VA = "0x183AF9680", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9430", Offset = "0x3AF7C30", VA = "0x183AF9430", Slot = "5")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9630", Offset = "0x3AF7E30", VA = "0x183AF9630")]
		public Entity GECBLHBNBIF(Entity GDNDJKDEKFN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9530", Offset = "0x3AF7D30", VA = "0x183AF9530")]
		public bool BNDMHFGOGFC(Entity GDNDJKDEKFN, Entity ILIAKNFOPLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9590", Offset = "0x3AF7D90", VA = "0x183AF9590")]
		public bool EPDJFMCJDGO(Entity GDNDJKDEKFN, Entity ILIAKNFOPLO, bool EMJIKBJAOKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x3AF9700", Offset = "0x3AF7F00", VA = "0x183AF9700")]
		private bool LIKPEKNLLJO(Entity GDNDJKDEKFN, Entity ILIAKNFOPLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
[OOAPDBLGMJF(typeof(PKDIGKBPILP), new string[] { })]
[HCKNDCEEEAM(typeof(OMCLDCKMHNM))]
internal sealed class PKDIGKBPILP : DNEGIKEIIMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private sealed class HFLADIGPEGD : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public PKDIGKBPILP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000879")]
			[Cpp2IlInjected.Address(RVA = "0xA02E00", Offset = "0xA01600", VA = "0x180A02E00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600087B")]
			[Cpp2IlInjected.Address(RVA = "0x51CD710", Offset = "0x51CBF10", VA = "0x1851CD710", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x51CADE0", Offset = "0x51C95E0", VA = "0x1851CADE0")]
		[DebuggerHidden]
		public HFLADIGPEGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x51CD580", Offset = "0x51CBD80", VA = "0x1851CD580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x51CD6D0", Offset = "0x51CBED0", VA = "0x1851CD6D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x51CD620", Offset = "0x51CBE20", VA = "0x1851CD620", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x51CD620", Offset = "0x51CBE20", VA = "0x1851CD620", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class KBKMKAEGIBP : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public PKDIGKBPILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private IEnumerator<Entity> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0xA02E00", Offset = "0xA01600", VA = "0x180A02E00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000884")]
			[Cpp2IlInjected.Address(RVA = "0x51CEDB0", Offset = "0x51CD5B0", VA = "0x1851CEDB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x51CADE0", Offset = "0x51C95E0", VA = "0x1851CADE0")]
		[DebuggerHidden]
		public KBKMKAEGIBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x51CEE00", Offset = "0x51CD600", VA = "0x1851CEE00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x51CEAF0", Offset = "0x51CD2F0", VA = "0x1851CEAF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x51CEE90", Offset = "0x51CD690", VA = "0x1851CEE90")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x51CED70", Offset = "0x51CD570", VA = "0x1851CED70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x51CECC0", Offset = "0x51CD4C0", VA = "0x1851CECC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x51CECC0", Offset = "0x51CD4C0", VA = "0x1851CECC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class APEPFCBIENF : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public PKDIGKBPILP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private ChildrenData <childData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private IEnumerator<Entity> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600088C")]
			[Cpp2IlInjected.Address(RVA = "0xA02E00", Offset = "0xA01600", VA = "0x180A02E00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x51CAC20", Offset = "0x51C9420", VA = "0x1851CAC20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x51CADE0", Offset = "0x51C95E0", VA = "0x1851CADE0")]
		[DebuggerHidden]
		public APEPFCBIENF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x51CAC70", Offset = "0x51C9470", VA = "0x1851CAC70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x51CA830", Offset = "0x51C9030", VA = "0x1851CA830", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x51CAD40", Offset = "0x51C9540", VA = "0x1851CAD40")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x51CAD90", Offset = "0x51C9590", VA = "0x1851CAD90")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x51CABE0", Offset = "0x51C93E0", VA = "0x1851CABE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x51CAB30", Offset = "0x51C9330", VA = "0x1851CAB30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x51CAB30", Offset = "0x51C9330", VA = "0x1851CAB30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private OMCLDCKMHNM EAMEDKLPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private EntityHierarchyParents AGEKKIIOBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private EntityHierarchyChildren HFOEOPEIJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private EntityQuery AEIMKNPBCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private EntityManager FHACAKFHJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0x3AB2390", Offset = "0x3AB0B90", VA = "0x183AB2390")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x3AB27E0", Offset = "0x3AB0FE0", VA = "0x183AB27E0", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2320", Offset = "0x3AB0B20", VA = "0x183AB2320", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1EE0", Offset = "0x3AB06E0", VA = "0x183AB1EE0")]
	public bool CMHAFNALMKK(Entity GDNDJKDEKFN, Entity POADJDFNECJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2070", Offset = "0x3AB0870", VA = "0x183AB2070")]
	public bool DCLFBBFLDAH(Entity GDNDJKDEKFN, Entity POADJDFNECJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2470", Offset = "0x3AB0C70", VA = "0x183AB2470")]
	public IEnumerable<Entity> IPBOMGOIDCM(Entity GDNDJKDEKFN, bool FBOPMPBBPKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2940", Offset = "0x3AB1140", VA = "0x183AB2940")]
	[IteratorStateMachine(typeof(HFLADIGPEGD))]
	private IEnumerable<Entity> OCKILBNHFMP(Entity GDNDJKDEKFN, bool FBOPMPBBPKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2150", Offset = "0x3AB0950", VA = "0x183AB2150")]
	public bool DEEFPGIOMCP(Entity GDNDJKDEKFN, Entity FOCEJAMAOBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1D50", Offset = "0x3AB0550", VA = "0x183AB1D50")]
	public bool BCBFDHJANCI(Entity GDNDJKDEKFN, Entity IFLKAOGBEDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2210", Offset = "0x3AB0A10", VA = "0x183AB2210")]
	public IEnumerable<Entity> DNDIDHHEMJL(Entity GDNDJKDEKFN, bool FBOPMPBBPKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x3AB29E0", Offset = "0x3AB11E0", VA = "0x183AB29E0")]
	[IteratorStateMachine(typeof(KBKMKAEGIBP))]
	private IEnumerable<Entity> OMCPMPDIBFC(Entity GDNDJKDEKFN, bool FBOPMPBBPKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2760", Offset = "0x3AB0F60", VA = "0x183AB2760")]
	[IteratorStateMachine(typeof(APEPFCBIENF))]
	private IEnumerable<Entity> KKAAHIDHIAH(Entity GDNDJKDEKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x3AB23E0", Offset = "0x3AB0BE0", VA = "0x183AB23E0")]
	public Entity IKKJIKAMHEN(Entity GDNDJKDEKFN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2340", Offset = "0x3AB0B40", VA = "0x183AB2340")]
	public NativeArray<Entity> FKLMDHDNEKK()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2580", Offset = "0x3AB0D80", VA = "0x183AB2580")]
	public bool KDGKGEDFGPG(Entity IFLKAOGBEDH, Entity KNPAGIAAIJP, out Entity FNFLMMJIIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public PKDIGKBPILP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[HPLMCJEDJJG(KOEAPPNBOCD.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x4B27EB0", Offset = "0x4B266B0", VA = "0x184B27EB0")]
		public static void MADPLDOCFBN<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData>(EEAJKGBJNOA AHNMBJFNCGG, global::JHOLIPIPHIK<Entity> BAOKNJFCNMB, out global::AFCNIFIINJI<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> DJEOMGBJAFP) where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, OLKMAFNAGAF where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, OLKMAFNAGAF, IEquatable<ChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x384B680", Offset = "0x3849E80", VA = "0x18384B680")]
		public static bool LKCHENOJGFI(CMIMIKMOPKA JJOFMICFAJO)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
public class AFCNIFIINJI<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, OLKMAFNAGAF where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, OLKMAFNAGAF, IEquatable<ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private static readonly JJLACLCEPON MNIOACBCBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private readonly OMCLDCKMHNM EAMEDKLPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly global::CIHBFHMIFFK<Entity> MIGODNJAHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly HDKGDNLMGLC HJBDNINBCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly KONIEIPNKKM OJKLIAPCMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private readonly EntityManager JGGNCNMICJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly PIEJAMPEPCM AOBKLHHNECH;

	[Cpp2IlInjected.Token(Token = "0x6000893")]
	[Cpp2IlInjected.Address(RVA = "0x35E3DA0", Offset = "0x35E25A0", VA = "0x1835E3DA0")]
	public AFCNIFIINJI(EEAJKGBJNOA AHNMBJFNCGG, global::JHOLIPIPHIK<Entity> BAOKNJFCNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000894")]
	[Cpp2IlInjected.Address(RVA = "0x35E3A40", Offset = "0x35E2240", VA = "0x1835E3A40")]
	private bool JFKLPDPBCNM(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000895")]
	[Cpp2IlInjected.Address(RVA = "0x35E3AA0", Offset = "0x35E22A0", VA = "0x1835E3AA0")]
	private bool KGKELEFMEFJ(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0x35E2F70", Offset = "0x35E1770", VA = "0x1835E2F70")]
	public bool DCJPOBAADCF(Entity GDNDJKDEKFN, in Entity ILIAKNFOPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	private static void FNOIHBDOHFF(Entity GDNDJKDEKFN, Entity ILIAKNFOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	private static void CAJFEGMAOOB(Entity GDNDJKDEKFN, Entity ILIAKNFOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x35E2E90", Offset = "0x35E1690", VA = "0x1835E2E90")]
	private bool CMHAFNALMKK(Entity GDNDJKDEKFN, Entity POADJDFNECJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0x35E2CD0", Offset = "0x35E14D0", VA = "0x1835E2CD0")]
	private void ABIGLPHFOFN(Entity GDNDJKDEKFN, in Entity CKCPHJMEEKP, in Entity ILIAKNFOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089B")]
	[Cpp2IlInjected.Address(RVA = "0x35E3840", Offset = "0x35E2040", VA = "0x1835E3840")]
	private void HPLELHJHDHD(Entity GDNDJKDEKFN, in Entity CKCPHJMEEKP, in Entity ILIAKNFOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089C")]
	[Cpp2IlInjected.Address(RVA = "0x35E31A0", Offset = "0x35E19A0", VA = "0x1835E31A0")]
	private bool EKFPOMMAAFJ(MFELBFPKDLI GIDAPFFEFMG, in DDAOHKAFOIC MNMMKLLNPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600089D")]
	[Cpp2IlInjected.Address(RVA = "0x35E3AF0", Offset = "0x35E22F0", VA = "0x1835E3AF0")]
	private void KJGBLHPLGKL(Entity OJKLIAPCMPJ, Entity FOCEJAMAOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089E")]
	[Cpp2IlInjected.Address(RVA = "0x35E3580", Offset = "0x35E1D80", VA = "0x1835E3580")]
	private void FDCLLHDIPLE(Entity OJKLIAPCMPJ, Entity FOCEJAMAOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089F")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	private void HAKNIFEJALB(Entity GDNDJKDEKFN, Entity CKCPHJMEEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A0")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	private void DAANMBADODI(Entity GDNDJKDEKFN, Entity ILIAKNFOPLO)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[HPLMCJEDJJG(KOEAPPNBOCD.HierarchySystems)]
	[OOAPDBLGMJF(typeof(TransformOwnershipPhase), new string[] { })]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x200014E")]
		public enum KFBPPGFFIFI
		{
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x200014F")]
		public struct HOBALPECLOI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			private KFBPPGFFIFI FMBGNHHHJOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private readonly TransformOwnershipPhase OJKLIAPCMPJ;

			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0x51CD8A0", Offset = "0x51CC0A0", VA = "0x1851CD8A0")]
			public HOBALPECLOI(TransformOwnershipPhase OJKLIAPCMPJ, KFBPPGFFIFI MOJDHKGIHLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0x51CD880", Offset = "0x51CC080", VA = "0x1851CD880", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public KFBPPGFFIFI MOJDHKGIHLO;

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public KFBPPGFFIFI EHCNGAGFMFH
		{
			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x648800", VA = "0x18064A000")]
			get
			{
				return default(KFBPPGFFIFI);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x6F4C90", Offset = "0x6F3490", VA = "0x1806F4C90")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public bool BJPDGIOHCLM
		{
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0x17E9210", Offset = "0x17E7A10", VA = "0x1817E9210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public bool ANFFLGPHJDC
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x1F4BB40", Offset = "0x1F4A340", VA = "0x181F4BB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x3858330", Offset = "0x3856B30", VA = "0x183858330")]
		public HOBALPECLOI EGBLKMAGBBA()
		{
			return default(HOBALPECLOI);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x3858360", Offset = "0x3856B60", VA = "0x183858360")]
		public HOBALPECLOI GJBAEMHMFCF()
		{
			return default(HOBALPECLOI);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public TransformOwnershipPhase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public struct EACJHPJAFLK : global::KIMFBICNHMN<EACJHPJAFLK>, EKJNBJHBEDB, IEquatable<EACJHPJAFLK>
{
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	public static readonly EACJHPJAFLK JNJAOIIOAAL;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public int DCEMEBHPCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x79B630", Offset = "0x799E30", VA = "0x18079B630", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x79CEA0", Offset = "0x79B6A0", VA = "0x18079CEA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F76F0", Offset = "0x7F5EF0", VA = "0x1807F76F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x7F7700", Offset = "0x7F5F00", VA = "0x1807F7700", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2400", Offset = "0x3AF0C00", VA = "0x183AF2400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B1")]
	[Cpp2IlInjected.Address(RVA = "0x3AF23B0", Offset = "0x3AF0BB0", VA = "0x183AF23B0", Slot = "8")]
	public bool Equals(EACJHPJAFLK IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B2")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2440", Offset = "0x3AF0C40", VA = "0x183AF2440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
public struct NOOGAICANOA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	public EACJHPJAFLK BLIPNDKFLPL;
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal struct LNNNEMBKEFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	private const int PLJDNBANCPK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private readonly Stack<HashSet<object>> JOLIJECAEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private global::KNEIBAGCIPL<EACJHPJAFLK, HashSet<object>> MAADOFPPOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private EntityManager JGGNCNMICJO;

	[Cpp2IlInjected.Token(Token = "0x60008B4")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E010", Offset = "0x3A9C810", VA = "0x183A9E010")]
	public LNNNEMBKEFK(EntityManager JGGNCNMICJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B5")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DB60", Offset = "0x3A9C360", VA = "0x183A9DB60")]
	public void EPHNJFGJMIL(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DE90", Offset = "0x3A9C690", VA = "0x183A9DE90")]
	public bool OLMBONIFOFC(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D930", Offset = "0x3A9C130", VA = "0x183A9D930")]
	public bool DAHIJCGCDME(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D970", Offset = "0x3A9C170", VA = "0x183A9D970")]
	public bool DAHIJCGCDME(EACJHPJAFLK BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DC60", Offset = "0x3A9C460", VA = "0x183A9DC60")]
	public bool HJMDCIFEJON(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DAB0", Offset = "0x3A9C2B0", VA = "0x183A9DAB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DAF0", Offset = "0x3A9C2F0", VA = "0x183A9DAF0")]
	private void EEHCPGNMPHF(HashSet<object> FMPADIAJDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DDC0", Offset = "0x3A9C5C0", VA = "0x183A9DDC0")]
	private bool NFINFCGLAIH(Entity GDNDJKDEKFN, out EACJHPJAFLK BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DD40", Offset = "0x3A9C540", VA = "0x183A9DD40")]
	private void KLAJEOOBJIA(Entity GDNDJKDEKFN, EACJHPJAFLK BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D8D0", Offset = "0x3A9C0D0", VA = "0x183A9D8D0")]
	private bool BKHEOEOKGNO(EACJHPJAFLK EFKJILPBBFJ, out HashSet<object> FMPADIAJDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DA10", Offset = "0x3A9C210", VA = "0x183A9DA10")]
	private HashSet<object> DNKKBBKMEMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
[OOAPDBLGMJF(typeof(PLPBBGKMDGB), new string[] { })]
public sealed class PLPBBGKMDGB
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action MINBOMHPGJK
	{
		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x384B3C0", Offset = "0x3849BC0", VA = "0x18384B3C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x384B500", Offset = "0x3849D00", VA = "0x18384B500")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action GNBJAMIJEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x384B460", Offset = "0x3849C60", VA = "0x18384B460")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x384B320", Offset = "0x3849B20", VA = "0x18384B320")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CBF0", Offset = "0x1E1B3F0", VA = "0x181E1CBF0")]
	public void CLDNLMGPOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x1C71020", Offset = "0x1C6F820", VA = "0x181C71020")]
	public void OKNGGGAPBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public PLPBBGKMDGB()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Embodiment)]
	[OOAPDBLGMJF(typeof(ObjectEmbodimentService), new string[] { })]
	internal sealed class ObjectEmbodimentService : PPOEDLGAMBE, AFNLLOENMMK, DNEGIKEIIMB, PGECBFIGDKK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private readonly Dictionary<DDAOHKAFOIC, GHMJIBJLDNA> JJCAGBEGKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private OMCLDCKMHNM EAMEDKLPJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private NCNJODMFFIF JHCECLNHNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private IACMPOBAJCP ILNNOEDPGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private HBIJPHJPPAA OHLAEPJHHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private IJHAGLHACDJ DIKIHKFMNLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private LNNNEMBKEFK DMDDPBJIPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private EntityHierarchyChildren HFOEOPEIJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private ObjectLifecycleService ICECBOBFDDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private TransformOwnershipPhase MOJDHKGIHLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private bool KAIBIFDFALJ;

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		private EntityManager FHACAKFHJON
		{
			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0x3AAAAD0", Offset = "0x3AA92D0", VA = "0x183AAAAD0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public int HDCINPLPMJE
		{
			[Cpp2IlInjected.Token(Token = "0x60008D0")]
			[Cpp2IlInjected.Address(RVA = "0x3AAAC50", Offset = "0x3AA9450", VA = "0x183AAAC50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int OMMFOKCAHCH
		{
			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0x3AABEA0", Offset = "0x3AAA6A0", VA = "0x183AABEA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<CMIMIKMOPKA> IMKBFAMKCJM
		{
			[Cpp2IlInjected.Token(Token = "0x60008C7")]
			[Cpp2IlInjected.Address(RVA = "0x3AABBA0", Offset = "0x3AAA3A0", VA = "0x183AABBA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008C8")]
			[Cpp2IlInjected.Address(RVA = "0x3AAAFF0", Offset = "0x3AA97F0", VA = "0x183AAAFF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<CMIMIKMOPKA> GOFDLOIOCFK
		{
			[Cpp2IlInjected.Token(Token = "0x60008C9")]
			[Cpp2IlInjected.Address(RVA = "0x3AAA170", Offset = "0x3AA8970", VA = "0x183AAA170")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x3AAC720", Offset = "0x3AAAF20", VA = "0x183AAC720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA020", Offset = "0x3AA8820", VA = "0x183AAA020", Slot = "4")]
		public void FKDGDLIKCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB090", Offset = "0x3AA9890", VA = "0x183AAB090", Slot = "5")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8B60", Offset = "0x3AA7360", VA = "0x183AA8B60", Slot = "6")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x3AA97A0", Offset = "0x3AA7FA0", VA = "0x183AA97A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9310", Offset = "0x3AA7B10", VA = "0x183AA9310")]
		public bool CAAKCPFCLOC(Entity GDNDJKDEKFN, Allocator EGJIMBMGFGA, out NativeList<Entity> JBLKGEEDKLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x3AABCE0", Offset = "0x3AAA4E0", VA = "0x183AABCE0")]
		public global::PEOLEGIGBJF<Entity> NANCLHOJDJJ(Allocator EGJIMBMGFGA)
		{
			return default(global::PEOLEGIGBJF<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8AF0", Offset = "0x3AA72F0", VA = "0x183AA8AF0")]
		public bool AADNEELLNGM(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB570", Offset = "0x3AA9D70", VA = "0x183AAB570")]
		public bool LPOPHPNOAOD(Entity GDNDJKDEKFN, out GHMJIBJLDNA EGJPJHAOMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB4C0", Offset = "0x3AA9CC0", VA = "0x183AAB4C0")]
		private bool LPOPHPNOAOD(Transform JDMGKLHBDHC, out GHMJIBJLDNA EGJPJHAOMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x3AAACF0", Offset = "0x3AA94F0", VA = "0x183AAACF0")]
		internal bool KDBHEBFFFBO(Entity GDNDJKDEKFN, out CCFEOLMBFFJ EGJPJHAOMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x3AABE00", Offset = "0x3AAA600", VA = "0x183AABE00")]
		private void NHILCMEGODH(Entity GDNDJKDEKFN, GHMJIBJLDNA EGJPJHAOMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA100", Offset = "0x3AA8900", VA = "0x183AAA100")]
		private bool GHIMMNHHNIG(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x3AAAB20", Offset = "0x3AA9320", VA = "0x183AAAB20")]
		public void IIGIGLNPDMN(DDAOHKAFOIC LNNGKIMHKAI, GHMJIBJLDNA OMJIFKPFMBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x3AAC100", Offset = "0x3AAA900", VA = "0x183AAC100")]
		public bool OAKONLPOIJF(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA260", Offset = "0x3AA8A60", VA = "0x183AAA260")]
		public bool HEOPAOOCMKB(IOFHLMDPEAL CPBDAEHELGD, object FDKCIGPLPAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA670", Offset = "0x3AA8E70", VA = "0x183AAA670")]
		public bool HEOPAOOCMKB(Entity GDNDJKDEKFN, [Optional] object FDKCIGPLPAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA240", Offset = "0x3AA8A40", VA = "0x183AAA240")]
		public bool HEOPAOOCMKB(GHMJIBJLDNA JJOFMICFAJO, object FDKCIGPLPAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8CF0", Offset = "0x3AA74F0", VA = "0x183AA8CF0")]
		public bool BGLGHHGNAFH(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8CC0", Offset = "0x3AA74C0", VA = "0x183AA8CC0")]
		public bool BGLGHHGNAFH(GHMJIBJLDNA EGJPJHAOMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA6C0", Offset = "0x3AA8EC0", VA = "0x183AAA6C0")]
		public bool HEOPAOOCMKB(GHMJIBJLDNA EGJPJHAOMIN, [Optional] object FDKCIGPLPAB, bool MJJPNLBDKFE = false, bool FDFDBLMIIBO = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB9F0", Offset = "0x3AAA1F0", VA = "0x183AAB9F0")]
		public Transform MHFIGNMDDFK(Entity GDNDJKDEKFN, [Optional] object FDKCIGPLPAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA030", Offset = "0x3AA8830", VA = "0x183AAA030")]
		public bool FLLDEIOLFNK(Entity GDNDJKDEKFN, out Transform JDMGKLHBDHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x3AABC40", Offset = "0x3AAA440", VA = "0x183AABC40")]
		public GHMJIBJLDNA MPHHGOHAHFD(Entity GDNDJKDEKFN, [Optional] object FDKCIGPLPAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB2A0", Offset = "0x3AA9AA0", VA = "0x183AAB2A0")]
		public void LNFEFDNFIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB630", Offset = "0x3AA9E30", VA = "0x183AAB630")]
		public void MCNPDGNJBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9A90", Offset = "0x3AA8290", VA = "0x183AA9A90")]
		private void FAHOMGCOICB(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x3AA96F0", Offset = "0x3AA7EF0", VA = "0x183AA96F0")]
		public GHMJIBJLDNA COOKPCMEDND(Entity GDNDJKDEKFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9A80", Offset = "0x3AA8280", VA = "0x183AA9A80")]
		public void EPHNJFGJMIL(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x3AAC710", Offset = "0x3AAAF10", VA = "0x183AAC710")]
		public bool OLMBONIFOFC(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x3AAAAC0", Offset = "0x3AA92C0", VA = "0x183AAAAC0")]
		public bool HJMDCIFEJON(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9750", Offset = "0x3AA7F50", VA = "0x183AA9750")]
		public bool DAHIJCGCDME(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9740", Offset = "0x3AA7F40", VA = "0x183AA9740")]
		public bool DAHIJCGCDME(EACJHPJAFLK BLIPNDKFLPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9920", Offset = "0x3AA8120", VA = "0x183AA9920")]
		private void EHGGJCNAFDA(bool LEIPDPGDBJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9F90", Offset = "0x3AA8790", VA = "0x183AA9F90")]
		private bool FHPAFOPHOBI(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x3AAAC80", Offset = "0x3AA9480", VA = "0x183AAAC80")]
		private GHMJIBJLDNA IMPEOEEHGAC(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9560", Offset = "0x3AA7D60", VA = "0x183AA9560")]
		private GHMJIBJLDNA CMNGLBGLIAJ(Entity GDNDJKDEKFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x3AAC4F0", Offset = "0x3AAACF0", VA = "0x183AAC4F0")]
		private (Vector3, Quaternion, Vector3) OLGMOLNKKNB(Entity GDNDJKDEKFN)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x3AABED0", Offset = "0x3AAA6D0", VA = "0x183AABED0")]
		private void NPDIGKCJDHO(Entity GDNDJKDEKFN, IOFCPOJDKFL OHBBEKBPFPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x3AA90D0", Offset = "0x3AA78D0", VA = "0x183AA90D0")]
		private void BILMAGJFHIA(IOFHLMDPEAL CPBDAEHELGD, GHMJIBJLDNA OMJIFKPFMBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x3AAAD60", Offset = "0x3AA9560", VA = "0x183AAAD60")]
		private void KGFBHICMOKJ(GHMJIBJLDNA EGJPJHAOMIN, Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9D40", Offset = "0x3AA8540", VA = "0x183AA9D40")]
		private void FGELNKPPNCL(Entity GDNDJKDEKFN, GHMJIBJLDNA EGJPJHAOMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x3AA9230", Offset = "0x3AA7A30", VA = "0x183AA9230")]
		private void BKAFPHOFJEK(Entity GDNDJKDEKFN, Transform JDMGKLHBDHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA210", Offset = "0x3AA8A10", VA = "0x183AAA210")]
		private IOFHLMDPEAL GNCDGGPPKBO(Entity GDNDJKDEKFN)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x3AAC810", Offset = "0x3AAB010", VA = "0x183AAC810")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x3AABD30", Offset = "0x3AAA530", VA = "0x183AABD30")]
		[CompilerGenerated]
		private void NANHEJKOJAD()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal static class DDGCLCKCMBE
{
	[Cpp2IlInjected.Token(Token = "0x60008FC")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1B80", Offset = "0x3AF0380", VA = "0x183AF1B80")]
	public static GHMJIBJLDNA MPHHGOHAHFD(this ObjectEmbodimentService AIFFIEBBMOL, IOFHLMDPEAL CPBDAEHELGD, [Optional] object FDKCIGPLPAB)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Lifecycle)]
	[OOAPDBLGMJF(typeof(ObjectLifecycleService), new string[] { })]
	internal sealed class ObjectLifecycleService : DNEGIKEIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private OMCLDCKMHNM PDJMGPJCDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private ObjectEmbodimentService EGJPJHAOMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private ObjectNetworkToLocalMapService HEAJCLFOHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private EntityHierarchyChildren HFOEOPEIJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private PKDIGKBPILP OBHAAPDAKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private EntityHierarchyParents AGEKKIIOBBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private MOKEONFHKEH PBFLMOKEPBN;

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		private EntityManager FHACAKFHJON
		{
			[Cpp2IlInjected.Token(Token = "0x6000901")]
			[Cpp2IlInjected.Address(RVA = "0x3AACFA0", Offset = "0x3AAB7A0", VA = "0x183AACFA0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<Entity, IOFCPOJDKFL> BMJEHKPAGKE
		{
			[Cpp2IlInjected.Token(Token = "0x60008FD")]
			[Cpp2IlInjected.Address(RVA = "0x3AACD20", Offset = "0x3AAB520", VA = "0x183AACD20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008FE")]
			[Cpp2IlInjected.Address(RVA = "0x3AAD310", Offset = "0x3AABB10", VA = "0x183AAD310")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<Entity> OCJPKBABAHC
		{
			[Cpp2IlInjected.Token(Token = "0x60008FF")]
			[Cpp2IlInjected.Address(RVA = "0x3AACB20", Offset = "0x3AAB320", VA = "0x183AACB20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000900")]
			[Cpp2IlInjected.Address(RVA = "0x3AACFF0", Offset = "0x3AAB7F0", VA = "0x183AACFF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD610", Offset = "0x3AABE10", VA = "0x183AAD610", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x3AACC20", Offset = "0x3AAB420", VA = "0x183AACC20")]
		public bool FKKMCEBMOMF(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x3AACBC0", Offset = "0x3AAB3C0", VA = "0x183AACBC0")]
		internal void EAKGIOPLHEJ(Entity GDNDJKDEKFN, IOFCPOJDKFL OHBBEKBPFPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x3AACF10", Offset = "0x3AAB710", VA = "0x183AACF10")]
		public void HCHHHNHJCJG(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x3AAC9E0", Offset = "0x3AAB1E0", VA = "0x183AAC9E0")]
		public void BCKCNDMGJOA(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x3AACDC0", Offset = "0x3AAB5C0", VA = "0x183AACDC0")]
		private bool GJIPHIPIFGK(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x3AACC90", Offset = "0x3AAB490", VA = "0x183AACC90")]
		public void FODPFOJIHMB(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD770", Offset = "0x3AABF70", VA = "0x183AAD770")]
		private void MCJPBBAFGCF(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD3B0", Offset = "0x3AABBB0", VA = "0x183AAD3B0")]
		private void JEFJIDNPFEA(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD090", Offset = "0x3AAB890", VA = "0x183AAD090")]
		private void IDOHNHCDJKI(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x3AAC890", Offset = "0x3AAB090", VA = "0x183AAC890")]
		private void AOMADBDHGCO(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Embodiment)]
	[OOAPDBLGMJF(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : DNEGIKEIIMB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private NativeHashMap<DDAOHKAFOIC, Entity> OHOFLKHJCDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private OMCLDCKMHNM PDJMGPJCDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private NCNJODMFFIF JHCECLNHNEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private EntityManager JGGNCNMICJO;

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		internal NativeHashMap<DDAOHKAFOIC, Entity> OPDBENMOKJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000910")]
			[Cpp2IlInjected.Address(RVA = "0x7325A0", Offset = "0x730DA0", VA = "0x1807325A0")]
			get
			{
				return default(NativeHashMap<DDAOHKAFOIC, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF460", Offset = "0x3AADC60", VA = "0x183AAF460", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF180", Offset = "0x3AAD980", VA = "0x183AAF180", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF640", Offset = "0x3AADE40", VA = "0x183AAF640")]
		public void OJEEPLKEKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF240", Offset = "0x3AADA40", VA = "0x183AAF240")]
		private IOFHLMDPEAL GNCDGGPPKBO(Entity GDNDJKDEKFN)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF560", Offset = "0x3AADD60", VA = "0x183AAF560")]
		public IOFHLMDPEAL NDFJMIJLHMK(DDAOHKAFOIC LNNGKIMHKAI)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF3D0", Offset = "0x3AADBD0", VA = "0x183AAF3D0")]
		public DDAOHKAFOIC JCBOEKFMENI(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default(DDAOHKAFOIC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF340", Offset = "0x3AADB40", VA = "0x183AAF340")]
		public void IGLDBBPKIEA(Entity GDNDJKDEKFN, DDAOHKAFOIC LNNGKIMHKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF1E0", Offset = "0x3AAD9E0", VA = "0x183AAF1E0")]
		public void GLAJCNDAHJN(Entity GDNDJKDEKFN, DDAOHKAFOIC LNNGKIMHKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF120", Offset = "0x3AAD920", VA = "0x183AAF120")]
		public void ADODJPJMOJL(Entity GDNDJKDEKFN, DDAOHKAFOIC LNNGKIMHKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF270", Offset = "0x3AADA70", VA = "0x183AAF270")]
		public void HIHBPPPPGPM(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal class OICELIFLMNO : LMCNNPNEEFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public BCIHOINOBGK IJFJOBFMOEG
	{
		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5320", Offset = "0x3AA3B20", VA = "0x183AA5320", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x3AA55B0", Offset = "0x3AA3DB0", VA = "0x183AA55B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public BCIHOINOBGK FOLDKHIMCCH
	{
		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5610", Offset = "0x3AA3E10", VA = "0x183AA5610", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5160", Offset = "0x3AA3960", VA = "0x183AA5160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public BCIHOINOBGK PAFAJLJNPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5680", Offset = "0x3AA3E80", VA = "0x183AA5680", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x3AA50F0", Offset = "0x3AA38F0", VA = "0x183AA50F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public BCIHOINOBGK GMBHPGBMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5380", Offset = "0x3AA3B80", VA = "0x183AA5380", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5540", Offset = "0x3AA3D40", VA = "0x183AA5540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public BCIHOINOBGK EPABEDCHIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x3AA54D0", Offset = "0x3AA3CD0", VA = "0x183AA54D0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5240", Offset = "0x3AA3A40", VA = "0x183AA5240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public BCIHOINOBGK LAOGIAIAKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x3AA57D0", Offset = "0x3AA3FD0", VA = "0x183AA57D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x3AA56F0", Offset = "0x3AA3EF0", VA = "0x183AA56F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public BCIHOINOBGK EFKGEOHBODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5010", Offset = "0x3AA3810", VA = "0x183AA5010", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x3AA52B0", Offset = "0x3AA3AB0", VA = "0x183AA52B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public BCIHOINOBGK CEBACLBJNLE
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x3AA51D0", Offset = "0x3AA39D0", VA = "0x183AA51D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5080", Offset = "0x3AA3880", VA = "0x183AA5080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public BCIHOINOBGK LLONECCMPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5460", Offset = "0x3AA3C60", VA = "0x183AA5460", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5760", Offset = "0x3AA3F60", VA = "0x183AA5760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public BCIHOINOBGK DHFDECHIELC
	{
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x3AA4FA0", Offset = "0x3AA37A0", VA = "0x183AA4FA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x3AA53F0", Offset = "0x3AA3BF0", VA = "0x183AA53F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000930")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5840", Offset = "0x3AA4040", VA = "0x183AA5840")]
	public OICELIFLMNO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[OOAPDBLGMJF(typeof(ObjectPrefabCreationService), new string[] { })]
	[HCKNDCEEEAM(typeof(OMCLDCKMHNM))]
	[HPLMCJEDJJG(KOEAPPNBOCD.Prefabs)]
	internal sealed class ObjectPrefabCreationService : PPOEDLGAMBE, AFNLLOENMMK, DNEGIKEIIMB, PGECBFIGDKK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private OMCLDCKMHNM EAMEDKLPJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private DEKONHFJCDH CIOGMLFIAGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private ADOHHLAHGPA KBLLGLCBFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private ObjectNetworkToLocalMapService HEAJCLFOHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private ObjectLifecycleService ICECBOBFDDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private ObjectPrefabs KBJJNECALFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private GLANGEPDNGL OCNJILOFHDE;

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public int OJEAMPGFOKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000944")]
			[Cpp2IlInjected.Address(RVA = "0x3AAFA10", Offset = "0x3AAE210", VA = "0x183AAFA10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "4")]
		public void FKDGDLIKCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFD90", Offset = "0x3AAE590", VA = "0x183AAFD90", Slot = "5")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF6F0", Offset = "0x3AADEF0", VA = "0x183AAF6F0", Slot = "6")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF890", Offset = "0x3AAE090", VA = "0x183AAF890", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF860", Offset = "0x3AAE060", VA = "0x183AAF860")]
		private void CCFGADIKNGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFC20", Offset = "0x3AAE420", VA = "0x183AAFC20")]
		public void JPFMENODJMO(bool MJJPNLBDKFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF860", Offset = "0x3AAE060", VA = "0x183AAF860")]
		private void CAJBJKJIKJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFBE0", Offset = "0x3AAE3E0", VA = "0x183AAFBE0")]
		public Entity JAAHPLBFDOD(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFAF0", Offset = "0x3AAE2F0", VA = "0x183AAFAF0")]
		public Entity JAAHPLBFDOD(IOFCPOJDKFL OHBBEKBPFPH, DDAOHKAFOIC LNNGKIMHKAI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFF20", Offset = "0x3AAE720", VA = "0x183AAFF20")]
		public Entity LMGGBKFFDDM(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFCF0", Offset = "0x3AAE4F0", VA = "0x183AAFCF0")]
		public Entity KKBHPDPGGIO(DDAOHKAFOIC LNNGKIMHKAI, IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFBE0", Offset = "0x3AAE3E0", VA = "0x183AAFBE0")]
		public Entity KELGJPAMBIF(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF820", Offset = "0x3AAE020", VA = "0x183AAF820")]
		public Entity APJGKMKJAME()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFA60", Offset = "0x3AAE260", VA = "0x183AAFA60")]
		public Entity HACNOOOPBHD(KOILODOMKMM BCFKLEGAMEO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF790", Offset = "0x3AADF90", VA = "0x183AAF790")]
		public Entity AHPAEJDNMCD(BNFPHFLJIBP BCFKLEGAMEO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFB90", Offset = "0x3AAE390", VA = "0x183AAFB90")]
		public NativeArray<(IOFHLMDPEAL, IOFHLMDPEAL)> JAAHPLBFDOD(NativeArray<IOFHLMDPEAL> BCIIMKPOHKF, Allocator EGJIMBMGFGA)
		{
			return default(NativeArray<(IOFHLMDPEAL, IOFHLMDPEAL)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0050", Offset = "0x3AAE850", VA = "0x183AB0050")]
		public IEnumerable<IOFCPOJDKFL> PJFFLLCAPBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF9B0", Offset = "0x3AAE1B0", VA = "0x183AAF9B0")]
		public EntityArchetype GDMKGDBFMNG(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x3AAF950", Offset = "0x3AAE150", VA = "0x183AAF950")]
		public Entity FLPFAHPDBME(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFF40", Offset = "0x3AAE740", VA = "0x183AAFF40")]
		private Entity NEPEOHHDIEM(IOFCPOJDKFL OHBBEKBPFPH, DDAOHKAFOIC LNNGKIMHKAI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public ObjectPrefabCreationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Prefabs)]
	internal class ObjectPrefabs : PFBOOACIMCB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		[CompilerGenerated]
		private sealed class LNEHMDPPJGJ : IEnumerable<(KOILODOMKMM, IOFCPOJDKFL)>, IEnumerable, IEnumerator<(KOILODOMKMM, IOFCPOJDKFL)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private (KOILODOMKMM primitiveType, IOFCPOJDKFL prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700010E")]
			private (KOILODOMKMM, IOFCPOJDKFL) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000960")]
				[Cpp2IlInjected.Address(RVA = "0xA02E00", Offset = "0xA01600", VA = "0x180A02E00", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((KOILODOMKMM, IOFCPOJDKFL));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000962")]
				[Cpp2IlInjected.Address(RVA = "0x51CFAE0", Offset = "0x51CE2E0", VA = "0x1851CFAE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600095D")]
			[Cpp2IlInjected.Address(RVA = "0x51CADE0", Offset = "0x51C95E0", VA = "0x1851CADE0")]
			[DebuggerHidden]
			public LNEHMDPPJGJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095E")]
			[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095F")]
			[Cpp2IlInjected.Address(RVA = "0x51CF900", Offset = "0x51CE100", VA = "0x1851CF900", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000961")]
			[Cpp2IlInjected.Address(RVA = "0x51CFAA0", Offset = "0x51CE2A0", VA = "0x1851CFAA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0x51CFA00", Offset = "0x51CE200", VA = "0x1851CFA00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(KOILODOMKMM, IOFCPOJDKFL)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0x51CFA00", Offset = "0x51CE200", VA = "0x1851CFA00", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private readonly World EAMEDKLPJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private readonly Dictionary<IOFCPOJDKFL, Entity> KBJJNECALFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private readonly Dictionary<IOFCPOJDKFL, EntityArchetype> KEFILCBKOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private readonly OICELIFLMNO NHOKCIGJJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private readonly Dictionary<KOILODOMKMM, IOFCPOJDKFL> LNIKEJENGPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private readonly Dictionary<BNFPHFLJIBP, IOFCPOJDKFL> PDFBOFHBMCL;

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		private LMCNNPNEEFJ EDPDDPBNHMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000948")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public int CAAMIJFBOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0x3AB0720", Offset = "0x3AAEF20", VA = "0x183AB0720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public EntityManager FHACAKFHJON
		{
			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0x11C1BE0", Offset = "0x11C03E0", VA = "0x1811C1BE0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x3AB11D0", Offset = "0x3AAF9D0", VA = "0x183AB11D0")]
		public ObjectPrefabs(World EAMEDKLPJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x3AB00F0", Offset = "0x3AAE8F0", VA = "0x183AB00F0")]
		private void CBEKCPDIOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x3AB1100", Offset = "0x3AAF900", VA = "0x183AB1100")]
		internal IEnumerable<Type> NMFCHMFBPJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0CD0", Offset = "0x3AAF4D0", VA = "0x183AB0CD0")]
		internal NPOMLBPEKKD IFAAMEHKFIB(Type BCFKLEGAMEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x3AB08F0", Offset = "0x3AAF0F0", VA = "0x183AB08F0")]
		internal void HEKPGEEIHIK(NPOMLBPEKKD KDHHOJKGJCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0EC0", Offset = "0x3AAF6C0", VA = "0x183AB0EC0")]
		internal void JKEHKDMADCN(IOFCPOJDKFL OHBBEKBPFPH, BCIHOINOBGK KGHLMGHDBBB, OAICBAFPMDG EACGIHHDHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0x3AB02F0", Offset = "0x3AAEAF0", VA = "0x183AB02F0")]
		private void DOLJLDIFBMN(IOFCPOJDKFL OHBBEKBPFPH, BCIHOINOBGK GPJMDEPCIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x3AB10E0", Offset = "0x3AAF8E0", VA = "0x183AB10E0")]
		public void JPFMENODJMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0890", Offset = "0x3AAF090", VA = "0x183AB0890")]
		public EntityArchetype GDMKGDBFMNG(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0D40", Offset = "0x3AAF540", VA = "0x183AB0D40", Slot = "4")]
		[IteratorStateMachine(typeof(LNEHMDPPJGJ))]
		public IEnumerable<(KOILODOMKMM, IOFCPOJDKFL)> IPBMGPMALFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0DB0", Offset = "0x3AAF5B0", VA = "0x183AB0DB0")]
		public Entity JAAHPLBFDOD(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x3AB07D0", Offset = "0x3AAEFD0", VA = "0x183AB07D0")]
		public IOFCPOJDKFL FGGMDEJJMHP(BNFPHFLJIBP BCFKLEGAMEO)
		{
			return default(IOFCPOJDKFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0770", Offset = "0x3AAEF70", VA = "0x183AB0770")]
		public IOFCPOJDKFL FGGMDEJJMHP(KOILODOMKMM BCFKLEGAMEO)
		{
			return default(IOFCPOJDKFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0450", Offset = "0x3AAEC50", VA = "0x183AB0450", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x3AB1130", Offset = "0x3AAF930", VA = "0x183AB1130")]
		public IEnumerable<IOFCPOJDKFL> PJFFLLCAPBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0830", Offset = "0x3AAF030", VA = "0x183AB0830")]
		public Entity FLPFAHPDBME(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x3AB0600", Offset = "0x3AAEE00", VA = "0x183AB0600")]
		internal Entity EELCLHEJNLO(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[HPLMCJEDJJG(KOEAPPNBOCD.Callbacks)]
	[OOAPDBLGMJF(typeof(PropertyEventCallbacksService), new string[] { })]
	public class PropertyEventCallbacksService : DNEGIKEIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x200015D")]
		private struct FFFKDHANALD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public OAPLOPHGFEJ FNAODFKKBJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public Type BCFKLEGAMEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public int FBPAKFCOLHM;
		}

		[Cpp2IlInjected.Token(Token = "0x200015E")]
		private struct BEKELKLKBLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public FFFKDHANALD[] IEBMFIFBGIK;
		}

		[Cpp2IlInjected.Token(Token = "0x200015F")]
		public delegate void OAPLOPHGFEJ(Entity GDNDJKDEKFN, FHCGLCCCIJI LKIMNIMPHKB, IKKMGBAJNEB OHJKCCOELFF, IKKMGBAJNEB DIBLIDDDAFJ);

		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private static readonly JJLACLCEPON MNIOACBCBNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private readonly Dictionary<FHCGLCCCIJI, OAPLOPHGFEJ> MPCHPAFINJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private readonly Dictionary<int, BEKELKLKBLL> JAINHOCCFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private MHOGNFLCFLJ IEBMFIFBGIK;

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action PKNBPMNADIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0x3851340", Offset = "0x384FB40", VA = "0x183851340")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0x3850D90", Offset = "0x384F590", VA = "0x183850D90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action AFFJDIGDOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000967")]
			[Cpp2IlInjected.Address(RVA = "0x3850E30", Offset = "0x384F630", VA = "0x183850E30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000968")]
			[Cpp2IlInjected.Address(RVA = "0x3850CF0", Offset = "0x384F4F0", VA = "0x183850CF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x3851550", Offset = "0x384FD50", VA = "0x183851550", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x38513E0", Offset = "0x384FBE0", VA = "0x1838513E0")]
		public void IIGIGLNPDMN(FHCGLCCCIJI LKIMNIMPHKB, OAPLOPHGFEJ FNAODFKKBJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x3850FC0", Offset = "0x384F7C0", VA = "0x183850FC0")]
		public void HFEONLCKKIF(FHCGLCCCIJI LKIMNIMPHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x38510B0", Offset = "0x384F8B0", VA = "0x1838510B0")]
		internal void HODFAIHJMJB(KBCEGGHPHAF JCLIGOJKKCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x3850530", Offset = "0x384ED30", VA = "0x183850530")]
		private void BODFCFEJING(KBCEGGHPHAF JCLIGOJKKCI, int NDBJIKBMPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x3850A70", Offset = "0x384F270", VA = "0x183850A70")]
		private void DIKGBGOLHAP(MIEGLNNJAGB PMOKKAEPEEN, ICGJPAAOHAG LEJFMAICDGC, FFFKDHANALD LGBLGMCEENE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x38515B0", Offset = "0x384FDB0", VA = "0x1838515B0")]
		private BEKELKLKBLL MOCPPAMLKIH(MIEGLNNJAGB PMOKKAEPEEN, ICGJPAAOHAG LEJFMAICDGC)
		{
			return default(BEKELKLKBLL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x3850ED0", Offset = "0x384F6D0", VA = "0x183850ED0")]
		private FFFKDHANALD GEHBJENPHIE(BEKELKLKBLL BDIHABFLOBJ, MIEGLNNJAGB PMOKKAEPEEN, ICGJPAAOHAG LEJFMAICDGC)
		{
			return default(FFFKDHANALD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x3851780", Offset = "0x384FF80", VA = "0x183851780")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
[OOAPDBLGMJF(typeof(KENINKEKDMC), new string[] { })]
public class PLFBKJCFNFD : DNEGIKEIIMB, PGECBFIGDKK, KENINKEKDMC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class LANIILFHLGJ : IEnumerable<OPJPKCFNLCB>, IEnumerable, IEnumerator<OPJPKCFNLCB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private OPJPKCFNLCB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public PLFBKJCFNFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private BKJCFABOEMG spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public BKJCFABOEMG <>3__spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		private OPJPKCFNLCB System.Collections.Generic.IEnumerator<RecRoom.Components.SplinePoint>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600098C")]
			[Cpp2IlInjected.Address(RVA = "0x74A710", Offset = "0x748F10", VA = "0x18074A710", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(OPJPKCFNLCB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0x51CF8B0", Offset = "0x51CE0B0", VA = "0x1851CF8B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0x7F7420", Offset = "0x7F5C20", VA = "0x1807F7420")]
		[DebuggerHidden]
		public LANIILFHLGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x51CF6C0", Offset = "0x51CDEC0", VA = "0x1851CF6C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0x51CF870", Offset = "0x51CE070", VA = "0x1851CF870", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x51CF7C0", Offset = "0x51CDFC0", VA = "0x1851CF7C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OPJPKCFNLCB> System.Collections.Generic.IEnumerable<RecRoom.Components.SplinePoint>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x51CF7C0", Offset = "0x51CDFC0", VA = "0x1851CF7C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	private OMCLDCKMHNM EAMEDKLPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private HOIFPAIGDHC IJMMKCBFGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private ObjectPrefabCreationService KBJJNECALFP;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private EntityManager FHACAKFHJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0x384A4B0", Offset = "0x3848CB0", VA = "0x18384A4B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private BJBGOMFMFBL NPECBMJOKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x384A8B0", Offset = "0x38490B0", VA = "0x18384A8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x384A690", Offset = "0x3848E90", VA = "0x18384A690", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x3849B00", Offset = "0x3848300", VA = "0x183849B00", Slot = "5")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x3849DD0", Offset = "0x38485D0", VA = "0x183849DD0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x384A160", Offset = "0x3848960", VA = "0x18384A160")]
	private void HBFLFGEBJIO(Entity MEAOLLJGJLP, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x3849C00", Offset = "0x3848400", VA = "0x183849C00", Slot = "12")]
	public BKJCFABOEMG APJGKMKJAME()
	{
		return default(BKJCFABOEMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x3849E80", Offset = "0x3848680", VA = "0x183849E80", Slot = "6")]
	public OPJPKCFNLCB FBHMHHKEIEL(BKJCFABOEMG LGKLIHJHFGE, [Optional] Vector3? LPADDFNBONE, [Optional] Quaternion? OIFAPGIKFEG, [Optional] Vector3? LAMBOPNBCHE)
	{
		return default(OPJPKCFNLCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x384AB20", Offset = "0x3849320", VA = "0x18384AB20", Slot = "13")]
	public OPJPKCFNLCB PMMLABFHENP(BKJCFABOEMG LGKLIHJHFGE, int MMABPPDCBIB, [Optional] Vector3? LPADDFNBONE, [Optional] Quaternion? OIFAPGIKFEG, [Optional] Vector3? LAMBOPNBCHE)
	{
		return default(OPJPKCFNLCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x3849CC0", Offset = "0x38484C0", VA = "0x183849CC0", Slot = "7")]
	public OPJPKCFNLCB BBFIDLPGLPC(BKJCFABOEMG LGKLIHJHFGE, int MMABPPDCBIB)
	{
		return default(OPJPKCFNLCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x384A820", Offset = "0x3849020", VA = "0x18384A820", Slot = "14")]
	public void OKJAJLLLBML(BKJCFABOEMG LGKLIHJHFGE, OPJPKCFNLCB LECJMEPIEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x384A990", Offset = "0x3849190", VA = "0x18384A990", Slot = "8")]
	public void PHGLHFAODGF(BKJCFABOEMG LGKLIHJHFGE, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x384A500", Offset = "0x3848D00", VA = "0x18384A500", Slot = "15")]
	public void IILHFEDKPAP(BKJCFABOEMG LGKLIHJHFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0x384A900", Offset = "0x3849100", VA = "0x18384A900", Slot = "9")]
	public int PBIHDNGLINB(BKJCFABOEMG LGKLIHJHFGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0x384A790", Offset = "0x3848F90", VA = "0x18384A790", Slot = "10")]
	[IteratorStateMachine(typeof(LANIILFHLGJ))]
	public IEnumerable<OPJPKCFNLCB> NIBBKEJPOOM(BKJCFABOEMG LGKLIHJHFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x384A710", Offset = "0x3848F10", VA = "0x18384A710")]
	private bool LIAFMOILBPM(BKJCFABOEMG LGKLIHJHFGE, out NativeArray<Entity> HFOEOPEIJAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x384A400", Offset = "0x3848C00", VA = "0x18384A400")]
	private NativeArray<Entity> HFNGIFNMFLE(BKJCFABOEMG LGKLIHJHFGE)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public PLFBKJCFNFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[OOAPDBLGMJF(typeof(ONONPBBGLCA), new string[] { })]
internal sealed class ONONPBBGLCA : DNEGIKEIIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private OMCLDCKMHNM EAMEDKLPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private TransformOwnershipPhase KFAADBMJGGI;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private JIGACBOPBKP LJFDDHDKJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x3AA8210", Offset = "0x3AA6A10", VA = "0x183AA8210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x3AA84D0", Offset = "0x3AA6CD0", VA = "0x183AA84D0", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8110", Offset = "0x3AA6910", VA = "0x183AA8110")]
	public void BOABIGFGHGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0x3AA8260", Offset = "0x3AA6A60", VA = "0x183AA8260")]
	public void FCHHHKFGLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public ONONPBBGLCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[DefaultMember("Item")]
public struct KMNELEKGPOK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private T[] PJDKPCLOECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private int HOPGLJCPGGA;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public int FFGDBGPFOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x81AE00", Offset = "0x819600", VA = "0x18081AE00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x34C63F0", Offset = "0x34C4BF0", VA = "0x1834C63F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Span<T> HEOCDCDMJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x3DD0340", Offset = "0x3DCEB40", VA = "0x183DD0340")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool KJFIOINAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0xC01360", Offset = "0xBFFB60", VA = "0x180C01360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099A")]
	[Cpp2IlInjected.Address(RVA = "0x3DD03E0", Offset = "0x3DCEBE0", VA = "0x183DD03E0")]
	public KMNELEKGPOK(int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0x3DD0290", Offset = "0x3DCEA90", VA = "0x183DD0290")]
	public int OCHPPPJPAPL(T CCIMHDCKHOF, int OMKHMNIPPGH, int LGKBEOCJMLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x3DD01D0", Offset = "0x3DCE9D0", VA = "0x183DD01D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
[DefaultMember("Item")]
public struct OLKDJHOMLMP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private global::KMNELEKGPOK<T> PJDKPCLOECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private int HOPGLJCPGGA;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x3B88BB0", Offset = "0x3B873B0", VA = "0x183B88BB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public int FFGDBGPFOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x648800", VA = "0x18064A000")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x3B87BA0", Offset = "0x3B863A0", VA = "0x183B87BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public int MGOGDIHFDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B87950", Offset = "0x3B86150", VA = "0x183B87950")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x3B890D0", Offset = "0x3B878D0", VA = "0x183B890D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool KJFIOINAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x3B883E0", Offset = "0x3B86BE0", VA = "0x183B883E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Span<T> HEOCDCDMJEL
	{
		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x3B88E40", Offset = "0x3B87640", VA = "0x183B88E40")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x3B892F0", Offset = "0x3B87AF0", VA = "0x183B892F0")]
	public OLKDJHOMLMP(int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x3B87BF0", Offset = "0x3B863F0", VA = "0x183B87BF0")]
	public T BLGGDAMEJBG(int MMABPPDCBIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x3B88260", Offset = "0x3B86A60", VA = "0x183B88260")]
	public void DPLNNAEFNOP(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x3B88CD0", Offset = "0x3B874D0", VA = "0x183B88CD0")]
	public void OHCKMIDAEHB(Span<T> PIJDNOPJENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x3B87CA0", Offset = "0x3B864A0", VA = "0x183B87CA0")]
	public void CEMPCIEDPMO(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x3B880E0", Offset = "0x3B868E0", VA = "0x183B880E0")]
	private void DEOGPKAPNGF(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x3B886F0", Offset = "0x3B86EF0", VA = "0x183B886F0")]
	public void JLOEGDMEDIN(Span<T> CFFIGFCFHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x3B88690", Offset = "0x3B86E90", VA = "0x183B88690")]
	public void JLCNKBAMAPK(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x3B87980", Offset = "0x3B86180", VA = "0x183B87980")]
	public void BFGNPBHDOKK(int LLIDIILMDBO, int BDPJJHLGMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0x3B87DB0", Offset = "0x3B865B0", VA = "0x183B87DB0")]
	public void CLBKMDGGMLI(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0x3B87ED0", Offset = "0x3B866D0", VA = "0x183B87ED0")]
	public void DBMHDOPKHCJ(int LLIDIILMDBO, int BDPJJHLGMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AF")]
	[Cpp2IlInjected.Address(RVA = "0x3B87E10", Offset = "0x3B86610", VA = "0x183B87E10")]
	public void CMBNIOFBIAF(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0x3B882D0", Offset = "0x3B86AD0", VA = "0x183B882D0")]
	public void DPONOCALBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B1")]
	[Cpp2IlInjected.Address(RVA = "0x3B88C40", Offset = "0x3B87440", VA = "0x183B88C40")]
	public int OCHPPPJPAPL(T CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B2")]
	[Cpp2IlInjected.Address(RVA = "0x3B87C40", Offset = "0x3B86440", VA = "0x183B87C40")]
	public bool CBBIGPLMGHA(T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x3B88390", Offset = "0x3B86B90", VA = "0x183B88390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x3B89280", Offset = "0x3B87A80", VA = "0x183B89280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x3B88420", Offset = "0x3B86C20", VA = "0x183B88420")]
	public static Span<T> EDIIAGKPKGG(global::OLKDJHOMLMP<T> PIJDNOPJENO)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0x3B88A70", Offset = "0x3B87270", VA = "0x183B88A70")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void LBJBFEAFHLP(int CCIMHDCKHOF, int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void PLKLBGELDHE(int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x3B89120", Offset = "0x3B87920", VA = "0x183B89120")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void PLKLBGELDHE(int HOPGLJCPGGA, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B9")]
	[Cpp2IlInjected.Address(RVA = "0x3B88930", Offset = "0x3B87130", VA = "0x183B88930")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void KJCPIPMMKEG(int CCIMHDCKHOF, int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BA")]
	[Cpp2IlInjected.Address(RVA = "0x3B88490", Offset = "0x3B86C90", VA = "0x183B88490")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void IPPHJPLIPJD(int LLIDIILMDBO, int BDPJJHLGMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0x3B88F90", Offset = "0x3B87790", VA = "0x183B88F90")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void OKDDDIKAMJJ(int CCIMHDCKHOF, int HOPGLJCPGGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
public struct EBPNDNCEIPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private const int KACCLEGEMLD = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private NativeList<Entity> NGCJEBOBKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private TransformAccessArray ILNNOEDPGOH;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x3AF2C80", Offset = "0x3AF1480", VA = "0x183AF2C80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public NativeList<Entity> OGPFBBAMELB
	{
		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x765470", Offset = "0x763C70", VA = "0x180765470")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public TransformAccessArray JFGANGCEAML
	{
		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x671670", Offset = "0x66FE70", VA = "0x180671670")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2E00", Offset = "0x3AF1600", VA = "0x183AF2E00")]
	public EBPNDNCEIPG(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C0")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2DB0", Offset = "0x3AF15B0", VA = "0x183AF2DB0")]
	public Entity MGMBLJGHJCJ(int MMABPPDCBIB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C1")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2C90", Offset = "0x3AF1490", VA = "0x183AF2C90")]
	public Transform IAHHILHKCHF(int MMABPPDCBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009C2")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2CA0", Offset = "0x3AF14A0", VA = "0x183AF2CA0")]
	public void JHCCIEMAEOA(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2C10", Offset = "0x3AF1410", VA = "0x183AF2C10")]
	public void EEGBJDDMKHP(int OBIMDJJEEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2AC0", Offset = "0x3AF12C0", VA = "0x183AF2AC0")]
	public int CEMPCIEDPMO(Transform JDMGKLHBDHC, Entity GDNDJKDEKFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2CF0", Offset = "0x3AF14F0", VA = "0x183AF2CF0")]
	public int JLCNKBAMAPK(int MMABPPDCBIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2B90", Offset = "0x3AF1390", VA = "0x183AF2B90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2D70", Offset = "0x3AF1570", VA = "0x183AF2D70")]
	private void LKFGDLPCNCK(int EANCNGLCPPF = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public class JMGAHKABHJN : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	public static readonly JMGAHKABHJN PJLEDACBOPG;

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x3A98D70", Offset = "0x3A97570", VA = "0x183A98D70", Slot = "4")]
	public bool Equals(LinkedEntityGroup ODLLFOGPPIE, LinkedEntityGroup GJCOJHOFJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x3A98D90", Offset = "0x3A97590", VA = "0x183A98D90", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup ODMJCJPGHNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public JMGAHKABHJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal class MFJHLNFKFAJ
{
	[Cpp2IlInjected.Token(Token = "0x60009CC")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	[Conditional("DEBUG_BUILD")]
	public static void JOCEDIGPLJE(in Vector3 LPADDFNBONE, in Quaternion OIFAPGIKFEG, in Vector3 LAMBOPNBCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	[Conditional("DEBUG_BUILD")]
	public static void BAFKEHCAIME(in Vector3 ODPHDNCCPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	[Conditional("DEBUG_BUILD")]
	public static void GHGMPNBEBCI(in Quaternion OIFAPGIKFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	[Conditional("DEBUG_BUILD")]
	public static void PCMCKEKNOGD(in Vector3 EJCENKFLKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	[Conditional("DEBUG_BUILD")]
	public static void KOOGPAPIACO(in Vector3 EJCENKFLKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	[Conditional("DEBUG_BUILD")]
	public static void KGLCHOPGKDA(in float KGLKDBPEDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E710", Offset = "0x3A9CF10", VA = "0x183A9E710")]
	[Conditional("DEBUG_BUILD")]
	public static void KKEIAKLOCOL(in float3 CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970")]
	[Conditional("DEBUG_BUILD")]
	public static void PJPCHHOKEAP(in float CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E7C0", Offset = "0x3A9CFC0", VA = "0x183A9E7C0")]
	[Conditional("DEBUG_BUILD")]
	public static void PJPCHHOKEAP(in Vector3 CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E810", Offset = "0x3A9D010", VA = "0x183A9E810")]
	[Conditional("DEBUG_BUILD")]
	public static void PJPCHHOKEAP(in Quaternion CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E700", Offset = "0x3A9CF00", VA = "0x183A9E700")]
	[Conditional("DEBUG_BUILD")]
	public static void IAOGCAGBGAN(in float CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E6C0", Offset = "0x3A9CEC0", VA = "0x183A9E6C0")]
	[Conditional("DEBUG_BUILD")]
	public static void IAOGCAGBGAN(in Vector3 CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E690", Offset = "0x3A9CE90", VA = "0x183A9E690")]
	[Conditional("DEBUG_BUILD")]
	public static void IAOGCAGBGAN(in Quaternion CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public MFJHLNFKFAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
public struct OJEIBILPNMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public Entity GDNDJKDEKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public Entity CKCPHJMEEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public Entity ILIAKNFOPLO;

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6A60", Offset = "0x3AA5260", VA = "0x183AA6A60")]
	public OJEIBILPNMC(Entity GDNDJKDEKFN, Entity CKCPHJMEEKP, Entity ILIAKNFOPLO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6A20", Offset = "0x3AA5220", VA = "0x183AA6A20")]
	public static OJEIBILPNMC EDIIAGKPKGG((Entity entity, Entity oldParent, Entity newParent) PNOPKIDJMHM)
	{
		return default(OJEIBILPNMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x3AA6A00", Offset = "0x3AA5200", VA = "0x183AA6A00")]
	public void DDACMMPHEGD(out Entity GDNDJKDEKFN, out Entity CKCPHJMEEKP, out Entity ILIAKNFOPLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public struct GGKPENPPBHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public Entity GDNDJKDEKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public Entity OJKLIAPCMPJ;

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0xC018C0", Offset = "0xC000C0", VA = "0x180C018C0")]
	public GGKPENPPBHO(Entity GDNDJKDEKFN, Entity OJKLIAPCMPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x3AFAF50", Offset = "0x3AF9750", VA = "0x183AFAF50")]
	public static GGKPENPPBHO EDIIAGKPKGG((Entity entity, Entity parent) PNOPKIDJMHM)
	{
		return default(GGKPENPPBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x3AFAF40", Offset = "0x3AF9740", VA = "0x183AFAF40")]
	public void DDACMMPHEGD(out Entity GDNDJKDEKFN, out Entity OJKLIAPCMPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public struct GIAFLAKDPOD<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private GCHandle BLIPNDKFLPL;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool KMFOGOJNOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0x3AA4CD0", Offset = "0x3AA34D0", VA = "0x183AA4CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x41A0DF0", Offset = "0x419F5F0", VA = "0x1841A0DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x41A0EC0", Offset = "0x419F6C0", VA = "0x1841A0EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x41A0F80", Offset = "0x419F780", VA = "0x1841A0F80")]
	public GIAFLAKDPOD(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x41A0E90", Offset = "0x419F690", VA = "0x1841A0E90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(AKGOFDBJCCO))]
public sealed class KAOIKEPIFHA : KOCIEKIJKIG
{
	[Cpp2IlInjected.Token(Token = "0x60009E5")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public KAOIKEPIFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E6")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(AKGOFDBJCCO))]
[UpdateAfter(typeof(KAOIKEPIFHA))]
public sealed class NOKCGGCJCGD : PreSerializeRemoveEntities
{
	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2EA0", Offset = "0x3AA16A0", VA = "0x183AA2EA0")]
	public NOKCGGCJCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E8")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
[PAOAHFGMMNM]
[UpdateAfter(typeof(NOKCGGCJCGD))]
[UpdateInGroup(typeof(AKGOFDBJCCO))]
public sealed class MHLFKHNNDCK : KDNNLDPHBFF
{
	[Cpp2IlInjected.Token(Token = "0x60009E9")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public MHLFKHNNDCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EA")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(KJNGLNMAMKD))]
public class ACBBCGJMDMD : ENOPFEBDGCE
{
	[Cpp2IlInjected.Token(Token = "0x60009EB")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public ACBBCGJMDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2500", Offset = "0x3AE0D00", VA = "0x183AE2500", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(KJNGLNMAMKD))]
public class HLBOPKNHIJI : OMFBOPCFNPN
{
	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public HLBOPKNHIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(KJNGLNMAMKD))]
public class LLDCBEEOJJC : GNGPLNHBEJK
{
	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A080", Offset = "0x3A98880", VA = "0x183A9A080")]
	public LLDCBEEOJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D720", Offset = "0x3A9BF20", VA = "0x183A9D720", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(PDGFELEPEIP))]
public sealed class MNGHMLAIBLD : NMBOBHDKNDC
{
	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E900", Offset = "0x3A9D100", VA = "0x183A9E900")]
	public MNGHMLAIBLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E8C0", Offset = "0x3A9D0C0", VA = "0x183A9E8C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(KHBINFJALOG))]
internal class MOKEONFHKEH : DestroyLocalObjects
{
	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x3AA2600", Offset = "0x3AA0E00", VA = "0x183AA2600")]
	public MOKEONFHKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[PAOAHFGMMNM]
[UpdateAfter(typeof(MOKEONFHKEH))]
[UpdateInGroup(typeof(KHBINFJALOG))]
internal class FNKFLGCDOBG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public FNKFLGCDOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(BJEEBKJLCFA))]
internal class NFEFIFPAFKL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public NFEFIFPAFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[PAOAHFGMMNM]
[UpdateAfter(typeof(NFEFIFPAFKL))]
[UpdateInGroup(typeof(BJEEBKJLCFA))]
internal class EBPHOJDIANH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public EBPHOJDIANH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(BJEEBKJLCFA))]
[UpdateAfter(typeof(EBPHOJDIANH))]
internal class IFKCPPKOEAD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public IFKCPPKOEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(IFKCPPKOEAD))]
internal class OCKGOJALEFB : FBPNJGJBJFJ
{
	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4B00", Offset = "0x3AA3300", VA = "0x183AA4B00")]
	public OCKGOJALEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4AF0", Offset = "0x3AA32F0", VA = "0x183AA4AF0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(IFKCPPKOEAD))]
internal class HCFKCDHPHGF : MBGLPMPHBGJ
{
	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF920", Offset = "0x3AFE120", VA = "0x183AFF920")]
	public HCFKCDHPHGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x3AFF910", Offset = "0x3AFE110", VA = "0x183AFF910", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(IFKCPPKOEAD))]
internal class LDCLJOOJEGI : PAEKHBEHAKA
{
	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BDC0", Offset = "0x3A9A5C0", VA = "0x183A9BDC0")]
	public LDCLJOOJEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A02")]
	[Cpp2IlInjected.Address(RVA = "0x3A9BD80", Offset = "0x3A9A580", VA = "0x183A9BD80", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(EBPHOJDIANH))]
internal sealed class DCGGBJHAHPB : FEHEGKHDIJC
{
	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public DCGGBJHAHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1B20", Offset = "0x3AF0320", VA = "0x183AF1B20", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[PAOAHFGMMNM]
[UpdateAfter(typeof(DCGGBJHAHPB))]
[UpdateInGroup(typeof(EBPHOJDIANH))]
internal sealed class MGEHCMBJNHD : NMBOBHDKNDC
{
	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E900", Offset = "0x3A9D100", VA = "0x183A9E900")]
	public MGEHCMBJNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E8C0", Offset = "0x3A9D0C0", VA = "0x183A9E8C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(FNKFLGCDOBG))]
internal sealed class DNJEPEHEADF : LLLHPDILIMK
{
	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1C60", Offset = "0x3AF0460", VA = "0x183AF1C60")]
	public DNJEPEHEADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1C50", Offset = "0x3AF0450", VA = "0x183AF1C50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(FNKFLGCDOBG))]
internal sealed class PGANDFDLKLA : RegisterTransforms
{
	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1870", Offset = "0x3AB0070", VA = "0x183AB1870")]
	public PGANDFDLKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1860", Offset = "0x3AB0060", VA = "0x183AB1860", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(FNKFLGCDOBG))]
[UpdateAfter(typeof(PGANDFDLKLA))]
internal sealed class AFIKCBMAKNM : CopyTransformDataFromGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x3AE2FA0", Offset = "0x3AE17A0", VA = "0x183AE2FA0")]
	public AFIKCBMAKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(MMJMFLLBCGP))]
internal class KOKEECBINFG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public KOKEECBINFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(MMJMFLLBCGP))]
internal class DNLOPGFICBA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public DNLOPGFICBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
[ExecuteAlways]
[PAOAHFGMMNM]
[UpdateAfter(typeof(KOKEECBINFG))]
[UpdateInGroup(typeof(MMJMFLLBCGP))]
internal sealed class LGHMFLEFILI : IJHAGLHACDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public LGHMFLEFILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[PAOAHFGMMNM]
[ExecuteAlways]
[UpdateAfter(typeof(LGHMFLEFILI))]
[UpdateInGroup(typeof(MMJMFLLBCGP))]
internal sealed class ENLPGOOPEBG : OAGDMILOAHA
{
	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A080", Offset = "0x3A98880", VA = "0x183A9A080")]
	public ENLPGOOPEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[PAOAHFGMMNM]
[UpdateAfter(typeof(LGHMFLEFILI))]
[UpdateInGroup(typeof(MMJMFLLBCGP))]
internal sealed class DEMNAGFOCCH : OGKMPINMJKF
{
	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A080", Offset = "0x3A98880", VA = "0x183A9A080")]
	public DEMNAGFOCCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
[AlwaysUpdateSystem]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(DNLOPGFICBA))]
internal sealed class CLHAAPGNPPO : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	protected override ApplyPropertyDifferences DMGHDHIHHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0x3AEA340", Offset = "0x3AE8B40", VA = "0x183AEA340", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x3AEA390", Offset = "0x3AE8B90", VA = "0x183AEA390")]
	public CLHAAPGNPPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(DNLOPGFICBA))]
[UpdateAfter(typeof(CLHAAPGNPPO))]
internal sealed class ALOCMKPAIGL : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE3000", Offset = "0x3AE1800", VA = "0x183AE3000")]
	public ALOCMKPAIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(DNLOPGFICBA))]
[UpdateAfter(typeof(CLHAAPGNPPO))]
internal sealed class KGMMIPEFBMJ : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A080", Offset = "0x3A98880", VA = "0x183A9A080")]
	public KGMMIPEFBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(DNLOPGFICBA))]
[UpdateAfter(typeof(KGMMIPEFBMJ))]
internal sealed class JAPKGGPDDBK : EnqueuePropertyDifferenceToNetwork
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	protected override ComputePropertyDifferences GGBAIOPHKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x3A987B0", Offset = "0x3A96FB0", VA = "0x183A987B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x3A98800", Offset = "0x3A97000", VA = "0x183A98800")]
	public JAPKGGPDDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
[PAOAHFGMMNM]
[UpdateAfter(typeof(JAPKGGPDDBK))]
[UpdateInGroup(typeof(DNLOPGFICBA))]
internal sealed class JDECFPGGBIA : DOFCILIHAHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x3A98860", Offset = "0x3A97060", VA = "0x183A98860")]
	public JDECFPGGBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(KOKEECBINFG))]
internal sealed class PNHIIFJBMMO : CopyTransformDataToGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x384B5B0", Offset = "0x3849DB0", VA = "0x18384B5B0")]
	public PNHIIFJBMMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(KOKEECBINFG))]
internal sealed class BMLJNPLHOGB : MMHIHGBHDFB
{
	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A080", Offset = "0x3A98880", VA = "0x183A9A080")]
	public BMLJNPLHOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(BJEEBKJLCFA))]
internal class KHNOHGEEHNL : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A27")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public KHNOHGEEHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A28")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[PAOAHFGMMNM]
[UpdateAfter(typeof(KHNOHGEEHNL))]
[UpdateInGroup(typeof(BJEEBKJLCFA))]
internal sealed class GDBDGCCGNEC : UpdateConnectableVisuals
{
	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA940", Offset = "0x3AF9140", VA = "0x183AFA940")]
	public GDBDGCCGNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA930", Offset = "0x3AF9130", VA = "0x183AFA930", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[PAOAHFGMMNM]
[ExecuteAlways]
[UpdateInGroup(typeof(BJEEBKJLCFA))]
[UpdateAfter(typeof(KHNOHGEEHNL))]
internal sealed class MEGOJOEBEED : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A2B")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public MEGOJOEBEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[PAOAHFGMMNM]
[ExecuteAlways]
[UpdateInGroup(typeof(MEGOJOEBEED))]
internal sealed class NINPONDAOMA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A2D")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public NINPONDAOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[ExecuteAlways]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(MEGOJOEBEED))]
[UpdateAfter(typeof(NINPONDAOMA))]
internal sealed class COFJMCNHPDF : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0x384B5A0", Offset = "0x3849DA0", VA = "0x18384B5A0")]
	public COFJMCNHPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A30")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(COFJMCNHPDF))]
internal sealed class HMFPGOJLBAA : HPDKFCJJFJI
{
	[Cpp2IlInjected.Token(Token = "0x6000A31")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public HMFPGOJLBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0x3A94590", Offset = "0x3A92D90", VA = "0x183A94590", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(COFJMCNHPDF))]
[UpdateAfter(typeof(HMFPGOJLBAA))]
internal sealed class CBMCAIGEEEA : KAEOPFLFJEH
{
	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A080", Offset = "0x3A98880", VA = "0x183A9A080")]
	public CBMCAIGEEEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x3AEA330", Offset = "0x3AE8B30", VA = "0x183AEA330", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(COFJMCNHPDF))]
[UpdateAfter(typeof(CBMCAIGEEEA))]
internal sealed class JDIPJGPIHOC : KMMBELOOFGA
{
	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960")]
	public JDIPJGPIHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(COFJMCNHPDF))]
[UpdateAfter(typeof(JDIPJGPIHOC))]
internal class OMOKKIMLPJJ : PhysicsSceneUpdateCollidersSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x3AA80B0", Offset = "0x3AA68B0", VA = "0x183AA80B0")]
	public OMOKKIMLPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(NINPONDAOMA))]
internal sealed class MIFNJAIDJOG : SplineLocalBoundsSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E9C0", Offset = "0x3A9D1C0", VA = "0x183A9E9C0")]
	public MIFNJAIDJOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(KHNOHGEEHNL))]
internal sealed class ANEEAABEALJ : PEAALDMLHHD
{
	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public ANEEAABEALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(KHNOHGEEHNL))]
[UpdateAfter(typeof(ANEEAABEALJ))]
internal sealed class HMNNOPECPJD : L2PToL2WHierarchy
{
	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x3A94670", Offset = "0x3A92E70", VA = "0x183A94670")]
	public HMNNOPECPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
[PAOAHFGMMNM]
[UpdateAfter(typeof(ANEEAABEALJ))]
[UpdateInGroup(typeof(KHNOHGEEHNL))]
internal sealed class ANCCMLDCCNK : NHFAKPHCDOK
{
	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A080", Offset = "0x3A98880", VA = "0x183A9A080")]
	public ANCCMLDCCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
[PAOAHFGMMNM]
[UpdateAfter(typeof(HMNNOPECPJD))]
[UpdateAfter(typeof(ANCCMLDCCNK))]
[UpdateInGroup(typeof(KHNOHGEEHNL))]
internal sealed class JDBGIEFJMNB : OIFMLHBPOGG
{
	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public JDBGIEFJMNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(KLKBCAICNFM))]
internal class MMNIIKIHIEL : APILEEKFEPP
{
	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A080", Offset = "0x3A98880", VA = "0x183A9A080")]
	public MMNIIKIHIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x3AA0DE0", Offset = "0x3A9F5E0", VA = "0x183AA0DE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(KLNHKEJFOEP))]
internal sealed class PIMNFNMOPNL : LBAEMAKPPPO
{
	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320")]
	public PIMNFNMOPNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1D40", Offset = "0x3AB0540", VA = "0x183AB1D40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
[PAOAHFGMMNM]
[UpdateAfter(typeof(PIMNFNMOPNL))]
[UpdateInGroup(typeof(KLNHKEJFOEP))]
internal class HPHCDNMIOJB : PostLoadInitializeEmbodiment
{
	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x3A94FD0", Offset = "0x3A937D0", VA = "0x183A94FD0")]
	public HPHCDNMIOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x3A94FC0", Offset = "0x3A937C0", VA = "0x183A94FC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
[AlwaysUpdateSystem]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(KLNHKEJFOEP))]
[UpdateAfter(typeof(HPHCDNMIOJB))]
internal sealed class BHOCHHJGBPF : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override ApplyPropertyDifferences DMGHDHIHHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7ED0", Offset = "0x3AE66D0", VA = "0x183AE7ED0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE7F20", Offset = "0x3AE6720", VA = "0x183AE7F20")]
	public BHOCHHJGBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
[PAOAHFGMMNM]
[UpdateInGroup(typeof(KLNHKEJFOEP))]
[UpdateAfter(typeof(BHOCHHJGBPF))]
internal sealed class FDGPDEOMHAG : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x3AF9B30", Offset = "0x3AF8330", VA = "0x183AF9B30")]
	public FDGPDEOMHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x854960", Offset = "0x853160", VA = "0x180854960", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[PAOAHFGMMNM]
[UpdateAfter(typeof(BHOCHHJGBPF))]
[UpdateInGroup(typeof(KLNHKEJFOEP))]
internal sealed class NDDLHBEAKKI : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0x3A9A080", Offset = "0x3A98880", VA = "0x183A9A080")]
	public NDDLHBEAKKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x1EBD320", Offset = "0x1EBBB20", VA = "0x181EBD320", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[OOAPDBLGMJF(typeof(ICEHLGPCFGD), new string[] { })]
public sealed class FKNOBGCFLIB : ICEHLGPCFGD, DNEGIKEIIMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private BBHEDGKDAJF BJCGAPIHGLL;

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA6D0", Offset = "0x3AF8ED0", VA = "0x183AFA6D0", Slot = "5")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA630", Offset = "0x3AF8E30", VA = "0x183AFA630")]
	public bool GGAAJFEABCL(in float3 JMICGAIDJIF, in float3 LBPFPACOALI, float EIEEMLEJCAI, Allocator EGJIMBMGFGA, out NativeArray<Entity> NGCJEBOBKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public FKNOBGCFLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA630", Offset = "0x3AF8E30", VA = "0x183AFA630", Slot = "4")]
	private bool PMPNKFEGBLI(in float3 JMICGAIDJIF, in float3 LBPFPACOALI, float EIEEMLEJCAI, Allocator EGJIMBMGFGA, out NativeArray<Entity> NGCJEBOBKNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
[OBPEJBMLPEP(typeof(AuthoredLocalPoseData))]
public sealed class INIOKDGONNG : HILHIODFHFE
{
	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x3A984B0", Offset = "0x3A96CB0", VA = "0x183A984B0", Slot = "8")]
	protected override bool GAOBNPLOLGE(ReadOnlySpan<AuthoredLocalPoseData> CFFIGFCFHML, NGNDNHAGNEP HDMBHNNBEPE, out ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x3A98530", Offset = "0x3A96D30", VA = "0x183A98530", Slot = "9")]
	protected override bool IMBMNGNFONL(int LDFDMKAILBI, Span<AuthoredLocalPoseData> CFFIGFCFHML, in ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x3A985F0", Offset = "0x3A96DF0", VA = "0x183A985F0")]
	public INIOKDGONNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[OBPEJBMLPEP(typeof(LocalPoseData))]
public sealed class IPDNNMKHCMN : CABNJLGKDFO
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x3A98600", Offset = "0x3A96E00", VA = "0x183A98600", Slot = "8")]
	protected override bool GAOBNPLOLGE(ReadOnlySpan<LocalPoseData> CFFIGFCFHML, NGNDNHAGNEP HDMBHNNBEPE, out ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x3A98680", Offset = "0x3A96E80", VA = "0x183A98680", Slot = "9")]
	protected override bool IMBMNGNFONL(int LDFDMKAILBI, Span<LocalPoseData> CFFIGFCFHML, in ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x3A98740", Offset = "0x3A96F40", VA = "0x183A98740")]
	public IPDNNMKHCMN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[Preserve]
	internal class _RRAssemblyIndex : NBDBIEGIKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x74FCB0", Offset = "0x74E4B0", VA = "0x18074FCB0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x38619E0", Offset = "0x38601E0", VA = "0x1838619E0", Slot = "6")]
		public sealed override void KPDEFEPDKBI(IBNALNEANOA FNAODFKKBJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x3862410", Offset = "0x3860C10", VA = "0x183862410", Slot = "4")]
		public sealed override void LAFCMKKIOHM()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public class BAADKGJHJEL
{
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private static byte[] ANBHIGGKLGA;

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private static int CIBDKMIJIHM;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private static int HHBBDHEOEDG;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private static BigInteger JHIBJFGIFBI;

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x3AE4A90", Offset = "0x3AE3290", VA = "0x183AE4A90")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x3AE4BA0", Offset = "0x3AE33A0", VA = "0x183AE4BA0")]
	public static string NNIAAAJCFNJ(byte[] CDDAIIMDJCN, bool FNAKCEJPGOO)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20001A5")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
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
