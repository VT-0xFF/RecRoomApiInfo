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
	[Cpp2IlInjected.Address(RVA = "0x2C77560", Offset = "0x2C76560", VA = "0x182C77560")]
	static KIEPGABADJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1EB79C0", Offset = "0x1EB69C0", VA = "0x181EB79C0")]
	public static void GDHIBEDPMBB<T>(T EADBNCPOLHD, ref T JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C77250", Offset = "0x2C76250", VA = "0x182C77250")]
	public static void GDHIBEDPMBB(FixedString32 EADBNCPOLHD, ref string JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2C774F0", Offset = "0x2C764F0", VA = "0x182C774F0")]
	public static void GDHIBEDPMBB(string EADBNCPOLHD, ref FixedString32 JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2C77220", Offset = "0x2C76220", VA = "0x182C77220")]
	public static void GDHIBEDPMBB(FixedString64 EADBNCPOLHD, ref string JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2C772C0", Offset = "0x2C762C0", VA = "0x182C772C0")]
	public static void GDHIBEDPMBB(string EADBNCPOLHD, ref FixedString64 JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2235020", Offset = "0x2234020", VA = "0x182235020")]
	public static void GDHIBEDPMBB(GGBCKKLMAGJ EADBNCPOLHD, ref Vector3 JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2C77460", Offset = "0x2C76460", VA = "0x182C77460")]
	public static void GDHIBEDPMBB(Vector3 EADBNCPOLHD, ref GGBCKKLMAGJ JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2C774C0", Offset = "0x2C764C0", VA = "0x182C774C0")]
	public static void GDHIBEDPMBB(MFLBMMHEHMP EADBNCPOLHD, ref Vector4 JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2C773B0", Offset = "0x2C763B0", VA = "0x182C773B0")]
	public static void GDHIBEDPMBB(Vector4 EADBNCPOLHD, ref MFLBMMHEHMP JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2C774C0", Offset = "0x2C764C0", VA = "0x182C774C0")]
	public static void GDHIBEDPMBB(MFLBMMHEHMP EADBNCPOLHD, ref Quaternion JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2C773B0", Offset = "0x2C763B0", VA = "0x182C773B0")]
	public static void GDHIBEDPMBB(Quaternion EADBNCPOLHD, ref MFLBMMHEHMP JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C77530", Offset = "0x2C76530", VA = "0x182C77530")]
	public static void GDHIBEDPMBB(GGBCKKLMAGJ EADBNCPOLHD, ref float3 JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2C77460", Offset = "0x2C76460", VA = "0x182C77460")]
	public static void GDHIBEDPMBB(float3 EADBNCPOLHD, ref GGBCKKLMAGJ JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2C77280", Offset = "0x2C76280", VA = "0x182C77280")]
	public static void GDHIBEDPMBB(MFLBMMHEHMP EADBNCPOLHD, ref float4 JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2C773B0", Offset = "0x2C763B0", VA = "0x182C773B0")]
	public static void GDHIBEDPMBB(float4 EADBNCPOLHD, ref MFLBMMHEHMP JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2C77280", Offset = "0x2C76280", VA = "0x182C77280")]
	public static void GDHIBEDPMBB(MFLBMMHEHMP EADBNCPOLHD, ref quaternion JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2C77320", Offset = "0x2C76320", VA = "0x182C77320")]
	public static void GDHIBEDPMBB(quaternion EADBNCPOLHD, ref MFLBMMHEHMP JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2C77420", Offset = "0x2C76420", VA = "0x182C77420")]
	public static void GDHIBEDPMBB(Entity EADBNCPOLHD, ref DHDJKFAIJMC JNLNIIGJOFO, NGNDNHAGNEP HDMBHNNBEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2C77390", Offset = "0x2C76390", VA = "0x182C77390")]
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
		[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64B130", Offset = "0x64A130", VA = "0x18064B130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OMBILBANOEN BKOIEKNNDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x68C1C0", Offset = "0x68B1C0", VA = "0x18068C1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x29C0010", Offset = "0x29BF010", VA = "0x1829C0010", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40")]
	public PNLPAOCPOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A960", Offset = "0x2C89960", VA = "0x182C8A960")]
		public static ObjectModelConfigAsset INDEKLGDBGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xEE0200", Offset = "0xEDF200", VA = "0x180EE0200")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED67E0", Offset = "0x4ED57E0", VA = "0x184ED67E0")]
			public static DDAOHKAFOIC JLFOIJJKCMC(int PCKMECAILKF)
			{
				return default(DDAOHKAFOIC);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x4ED6A10", Offset = "0x4ED5A10", VA = "0x184ED6A10")]
			public static int NOLFAIKCAJJ(GameObject HBGIADIFHEC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x4ED6990", Offset = "0x4ED5990", VA = "0x184ED6990")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C8BA50", Offset = "0x2C8AA50", VA = "0x182C8BA50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x2C8C0B0", Offset = "0x2C8B0B0", VA = "0x182C8C0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static EKIBDKMJGBC EOGADIBFGBI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2C8AE50", Offset = "0x2C89E50", VA = "0x182C8AE50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B780", Offset = "0x2C8A780", VA = "0x182C8B780")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool DMBOBCAHOHH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B530", Offset = "0x2C8A530", VA = "0x182C8B530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static OMBILBANOEN BKOIEKNNDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2C8ADD0", Offset = "0x2C89DD0", VA = "0x182C8ADD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LLNLFBIJEEI IPAILOOANFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B600", Offset = "0x2C8A600", VA = "0x182C8B600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static KGMAJJBPDAG MFPOBIMPBDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2C8ABC0", Offset = "0x2C89BC0", VA = "0x182C8ABC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static NCNJODMFFIF PJKMGICLPAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2C8AFC0", Offset = "0x2C89FC0", VA = "0x182C8AFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static HCGMPCJKLOI DGFBLHPCMKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B4B0", Offset = "0x2C8A4B0", VA = "0x182C8B4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool PJOCAJBJDEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B8F0", Offset = "0x2C8A8F0", VA = "0x182C8B8F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2C8BAB0", Offset = "0x2C8AAB0", VA = "0x182C8BAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool HKCJDPBFKGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B040", Offset = "0x2C8A040", VA = "0x182C8B040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2C8AD70", Offset = "0x2C89D70", VA = "0x182C8AD70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool FIANIEOIGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2C8AB60", Offset = "0x2C89B60", VA = "0x182C8AB60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2C8BB60", Offset = "0x2C8AB60", VA = "0x182C8BB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action BGGINHAIIIO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2C8B680", Offset = "0x2C8A680", VA = "0x182C8B680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2C8BE50", Offset = "0x2C8AE50", VA = "0x182C8BE50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2C8BBC0", Offset = "0x2C8ABC0", VA = "0x182C8BBC0")]
		public static IOFHLMDPEAL NDFJMIJLHMK(GameObject HBGIADIFHEC)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B330", Offset = "0x2C8A330", VA = "0x182C8B330")]
		public static DDAOHKAFOIC JCBOEKFMENI(GameObject HBGIADIFHEC)
		{
			return default(DDAOHKAFOIC);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2C8BF90", Offset = "0x2C8AF90", VA = "0x182C8BF90")]
		public static CMIMIKMOPKA OFKDENOCGDA(DDAOHKAFOIC LNNGKIMHKAI)
		{
			return default(CMIMIKMOPKA);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2C8BF50", Offset = "0x2C8AF50", VA = "0x182C8BF50")]
		public static CMIMIKMOPKA OFKDENOCGDA(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default(CMIMIKMOPKA);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B1D0", Offset = "0x2C8A1D0", VA = "0x182C8B1D0")]
		public static (ByteString, IDisposable) HHDOHEHKDKI()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AA00", Offset = "0x2C89A00", VA = "0x182C8AA00")]
		public static (ByteString, IDisposable) AGCKAEMKIME(IEnumerable<IOFHLMDPEAL> CIJFIAADMDF)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2C8AC40", Offset = "0x2C89C40", VA = "0x182C8AC40")]
		public static bool CGOKJOMFBHB(GameObject HBGIADIFHEC, out DDAOHKAFOIC LNNGKIMHKAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2C8B0A0", Offset = "0x2C8A0A0", VA = "0x182C8B0A0")]
		public static bool GCDCIAIFMFN(GameObject HBGIADIFHEC, out bool AFEDMKKOOGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2C8BD20", Offset = "0x2C8AD20", VA = "0x182C8BD20")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7FB20", Offset = "0x2C7EB20", VA = "0x182C7FB20")]
	public static GHMJIBJLDNA IIGIGLNPDMN(GameObject HBGIADIFHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FD00", Offset = "0x2C7ED00", VA = "0x182C7FD00")]
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
			[Cpp2IlInjected.Address(RVA = "0x66B040", Offset = "0x66A040", VA = "0x18066B040", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(IOFHLMDPEAL);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x2CF73E0", Offset = "0x2CF63E0", VA = "0x182CF73E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
			[Cpp2IlInjected.Address(RVA = "0xCBE830", Offset = "0xCBD830", VA = "0x180CBE830", Slot = "11")]
			get
			{
				return default(IOFHLMDPEAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CMIMIKMOPKA EHOCHHJECJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2CFCDF0", Offset = "0x2CFBDF0", VA = "0x182CFCDF0", Slot = "4")]
			get
			{
				return default(CMIMIKMOPKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private OMBILBANOEN BKOIEKNNDNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2CFC3E0", Offset = "0x2CFB3E0", VA = "0x182CFC3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private IACMPOBAJCP CDBJAPNEGBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x2CFCC80", Offset = "0x2CFBC80", VA = "0x182CFCC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public DLLAKHALKPJ EHPMEKPINPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x73F5B0", Offset = "0x73E5B0", VA = "0x18073F5B0", Slot = "5")]
			get
			{
				return default(DLLAKHALKPJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool FPEMCKPFHNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x64A030", Offset = "0x649030", VA = "0x18064A030", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x800230", Offset = "0x7FF230", VA = "0x180800230", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> EHNBOGECGAN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2CFCD50", Offset = "0x2CFBD50", VA = "0x182CFCD50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2CFCE20", Offset = "0x2CFBE20", VA = "0x182CFCE20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC300", Offset = "0x2CFB300", VA = "0x182CFC300")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x2CFCB60", Offset = "0x2CFBB60", VA = "0x182CFCB60", Slot = "13")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC780", Offset = "0x2CFB780", VA = "0x182CFC780", Slot = "14")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2CFCAD0", Offset = "0x2CFBAD0", VA = "0x182CFCAD0", Slot = "8")]
		public void OnEmbody(OMCLDCKMHNM EAMEDKLPJKC, IOFHLMDPEAL PFLOECMCNHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2CFCB50", Offset = "0x2CFBB50", VA = "0x182CFCB50", Slot = "9")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC8A0", Offset = "0x2CFB8A0", VA = "0x182CFC8A0", Slot = "10")]
		public void OnDisembody(bool JHPPOHPOIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC430", Offset = "0x2CFB430", VA = "0x182CFC430")]
		private void JMHOPEIKNJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC530", Offset = "0x2CFB530", VA = "0x182CFC530")]
		private void NOCKHCGGFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2CFC5F0", Offset = "0x2CFB5F0", VA = "0x182CFC5F0")]
		private void OKMIIFMMKKJ(bool KMFDCKDEDNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xFA2D00", Offset = "0xFA1D00", VA = "0x180FA2D00", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BBD0", Offset = "0x64ABD0", VA = "0x18064BBD0")]
			get
			{
				return default(IOFCPOJDKFL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6EE410", Offset = "0x6ED410", VA = "0x1806EE410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IOFHLMDPEAL ELJAGEKDLPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCBE830", Offset = "0xCBD830", VA = "0x180CBE830", Slot = "4")]
			get
			{
				return default(IOFHLMDPEAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal Entity FCMHICMIJCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal NCNJODMFFIF PJKMGICLPAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal IACMPOBAJCP BMOFKAEBDKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x29CCBD0", Offset = "0x29CBBD0", VA = "0x1829CCBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x29CC810", Offset = "0x29CB810", VA = "0x1829CC810")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x29CCAE0", Offset = "0x29CBAE0", VA = "0x1829CCAE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x29CC820", Offset = "0x29CB820", VA = "0x1829CC820")]
		internal void CDFKCHBFAME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x29CCAE0", Offset = "0x29CBAE0", VA = "0x1829CCAE0")]
		internal void GCLFHHNKHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x29CCC40", Offset = "0x29CBC40", VA = "0x1829CCC40")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x29CCD20", Offset = "0x29CBD20", VA = "0x1829CCD20")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x66A140", Offset = "0x669140", VA = "0x18066A140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HBIJPHJPPAA COEFAKNIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x64B130", Offset = "0x64A130", VA = "0x18064B130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public OMBILBANOEN BKOIEKNNDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x68C1C0", Offset = "0x68B1C0", VA = "0x18068C1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PJOCAJBJDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6490", Offset = "0x2CF5490", VA = "0x182CF6490", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6820", Offset = "0x2CF5820", VA = "0x182CF6820", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public IMBFPFHIPDB ACNOJBHFKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B5F60", Offset = "0x8B4F60", VA = "0x1808B5F60", Slot = "15")]
		get
		{
			return default(IMBFPFHIPDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6500", Offset = "0x2CF5500", VA = "0x182CF6500")]
	public static DCBGKDPAEKA MFNJFAEBAIM(LDFJPMDODKF AHNMBJFNCGG, PDPEEGAOGNI ALKHBOMOJMO = PDPEEGAOGNI.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6970", Offset = "0x2CF5970", VA = "0x182CF6970")]
	private static void OOGBOJDHBFD(LDFJPMDODKF AHNMBJFNCGG, PDPEEGAOGNI ALKHBOMOJMO = PDPEEGAOGNI.ExcludeIgnore)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x2CF60D0", Offset = "0x2CF50D0", VA = "0x182CF60D0")]
	private static void KPDEFEPDKBI(LDFJPMDODKF AHNMBJFNCGG, PDPEEGAOGNI ALKHBOMOJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5D00", Offset = "0x2CF4D00", VA = "0x182CF5D00")]
	private static string[] GCMFIMOBKCI(PDPEEGAOGNI ALKHBOMOJMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6680", Offset = "0x2CF5680", VA = "0x182CF6680")]
	private static bool NAMMGLFOEDB(PDPEEGAOGNI ALKHBOMOJMO, out string[] EBPPLKIGLIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5AB0", Offset = "0x2CF4AB0", VA = "0x182CF5AB0")]
	private static void AJCFGAHIGKB(LDFJPMDODKF AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6A60", Offset = "0x2CF5A60", VA = "0x182CF6A60", Slot = "16")]
	public void PGJAPBHHKEM(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x10DD740", Offset = "0x10DC740", VA = "0x1810DD740")]
	private void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6400", Offset = "0x2CF5400", VA = "0x182CF6400")]
	private void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	private void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5C60", Offset = "0x2CF4C60", VA = "0x182CF5C60", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6900", Offset = "0x2CF5900", VA = "0x182CF6900", Slot = "19")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5B80", Offset = "0x2CF4B80", VA = "0x182CF5B80", Slot = "9")]
	public void DALNGINDNDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "10")]
	public void GLMFLMDDEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5FF0", Offset = "0x2CF4FF0", VA = "0x182CF5FF0", Slot = "11")]
	public void IHIGOIDMCAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2CF59B0", Offset = "0x2CF49B0", VA = "0x182CF59B0", Slot = "7")]
	public void ADHMOLAJGDE(ByteString PJDKPCLOECB, ICHAMCHHHDE ALKHBOMOJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6060", Offset = "0x2CF5060", VA = "0x182CF6060", Slot = "8")]
	public void KIIHOPNIAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5BF0", Offset = "0x2CF4BF0", VA = "0x182CF5BF0", Slot = "12")]
	public void DMGEALDACPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5E90", Offset = "0x2CF4E90", VA = "0x182CF5E90", Slot = "13")]
	public void GLBNGIHMHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2CF5F00", Offset = "0x2CF4F00", VA = "0x182CF5F00", Slot = "20")]
	public ByteString HHDOHEHKDKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00")]
	private static bool LMGONBENPJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public DCBGKDPAEKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class BPOMPEGFCLB
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2CEDF50", Offset = "0x2CECF50", VA = "0x182CEDF50")]
	public static CMIMIKMOPKA KKBHPDPGGIO(this EKIBDKMJGBC JNIMGFMHNMP, DDAOHKAFOIC LNNGKIMHKAI, IOFCPOJDKFL OHBBEKBPFPH)
	{
		return default(CMIMIKMOPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2CEDD10", Offset = "0x2CECD10", VA = "0x182CEDD10")]
	public static LLLDPGKHFIG BNLAGHNGNJO(this EKIBDKMJGBC JNIMGFMHNMP)
	{
		return default(LLLDPGKHFIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE1C0", Offset = "0x2CED1C0", VA = "0x182CEE1C0")]
	public static IOFHLMDPEAL NDFJMIJLHMK(this EKIBDKMJGBC JNIMGFMHNMP, Entity GDNDJKDEKFN)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE090", Offset = "0x2CED090", VA = "0x182CEE090")]
	public static IOFHLMDPEAL NDFJMIJLHMK(this EKIBDKMJGBC JNIMGFMHNMP, DDAOHKAFOIC LNNGKIMHKAI)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2CEDE30", Offset = "0x2CECE30", VA = "0x182CEDE30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4395520", Offset = "0x4394520", VA = "0x184395520", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Type JIDICLJAOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4395180", Offset = "0x4394180", VA = "0x184395180", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ICGJPAAOHAG GCDLNKNDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x439B3A0", Offset = "0x439A3A0", VA = "0x18439B3A0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int FNIAHIHPNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x439B530", Offset = "0x439A530", VA = "0x18439B530", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public OGIFHIADLBO HCBHFPPKOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4394410", Offset = "0x4393410", VA = "0x184394410", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x10BB570", Offset = "0x10BA570", VA = "0x1810BB570", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4388460", Offset = "0x4387460", VA = "0x184388460", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event global::GBCMJJGIGAL<DDAOHKAFOIC> IHHEOJAELKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4398000", Offset = "0x4397000", VA = "0x184398000", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4388210", Offset = "0x4387210", VA = "0x184388210", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x30361B0", Offset = "0x30351B0", VA = "0x1830361B0")]
	public GKPBOJPKODO(global::BCFBMFIFGMA<Entity> MIGODNJAHNA, NCNJODMFFIF JHCECLNHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x438A160", Offset = "0x4389160", VA = "0x18438A160")]
	private Entity EKGOOABIHMK(DDAOHKAFOIC LNNGKIMHKAI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x378D550", Offset = "0x378C550", VA = "0x18378D550")]
	private DDAOHKAFOIC EKGOOABIHMK(Entity GDNDJKDEKFN)
	{
		return default(DDAOHKAFOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x43960A0", Offset = "0x43950A0", VA = "0x1843960A0", Slot = "4")]
	public T KEEHOGKCDPF(DDAOHKAFOIC LNNGKIMHKAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4389870", Offset = "0x4388870", VA = "0x184389870")]
	public bool DIMECELKFHA(DDAOHKAFOIC LNNGKIMHKAI, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4393F40", Offset = "0x4392F40", VA = "0x184393F40")]
	public bool HNBCALPENJO(DDAOHKAFOIC LNNGKIMHKAI, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x438DE00", Offset = "0x438CE00", VA = "0x18438DE00", Slot = "9")]
	public bool FKKMCEBMOMF(DDAOHKAFOIC LNNGKIMHKAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4394500", Offset = "0x4393500", VA = "0x184394500", Slot = "26")]
	public object IEJOODGNMJN(DDAOHKAFOIC LNNGKIMHKAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x43920D0", Offset = "0x43910D0", VA = "0x1843920D0")]
	public bool HAHLGEBNGDK(DDAOHKAFOIC LNNGKIMHKAI, in object GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4395D50", Offset = "0x4394D50", VA = "0x184395D50")]
	public void KEEHOGKCDPF(DDAOHKAFOIC LNNGKIMHKAI, in PEOLEOJFANL CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x43892D0", Offset = "0x43882D0", VA = "0x1843892D0")]
	public bool DIMECELKFHA(DDAOHKAFOIC LNNGKIMHKAI, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4392D10", Offset = "0x4391D10", VA = "0x184392D10")]
	public bool HNBCALPENJO(DDAOHKAFOIC LNNGKIMHKAI, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3020440", Offset = "0x301F440", VA = "0x183020440", Slot = "21")]
	public void ENNFCPGKJEH(OOBCJOADNJP EDJDHHEMACF, [Optional] object IGBOEABBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x438AF10", Offset = "0x4389F10", VA = "0x18438AF10", Slot = "15")]
	public void ENNFCPGKJEH(DDAOHKAFOIC AGPLDPOAAIC, KLJAFMKEJHN EDJDHHEMACF, object IGBOEABBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x43877C0", Offset = "0x43867C0", VA = "0x1843877C0", Slot = "14")]
	public bool AECOPHMDBCG(DDAOHKAFOIC JNLNIIGJOFO, DDAOHKAFOIC EADBNCPOLHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2247AA0", Offset = "0x2246AA0", VA = "0x182247AA0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x439BAD0", Offset = "0x439AAD0", VA = "0x18439BAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x438E2C0", Offset = "0x438D2C0", VA = "0x18438E2C0")]
	public string GCKBFFIBNHO(in IKKMGBAJNEB HJIKEFIKPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x439A3B0", Offset = "0x43993B0", VA = "0x18439A3B0")]
	private void MMAENMODJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x43980B0", Offset = "0x43970B0", VA = "0x1843980B0")]
	private void KKMDIIPANCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x438E5B0", Offset = "0x438D5B0", VA = "0x18438E5B0")]
	private void GLMAHECJCGI(Entity GDNDJKDEKFN, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4394C00", Offset = "0x4393C00", VA = "0x184394C00")]
	private void IIDKMPOJCJL(Entity GDNDJKDEKFN, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x438C970", Offset = "0x438B970", VA = "0x18438C970")]
	[Conditional("DEBUG_BUILD")]
	private static void FANLFIKIPLG(Entity GDNDJKDEKFN, DDAOHKAFOIC LNNGKIMHKAI, string BAOKNJFCNMB, string IFJFEFCEPBI, [CallerMemberName] string OFKKNNHOFPP = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x25A2AB0", Offset = "0x25A1AB0", VA = "0x1825A2AB0", Slot = "5")]
	private bool IPIOLNGGNDE(DDAOHKAFOIC AGPLDPOAAIC, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D36920", Offset = "0x2D35920", VA = "0x182D36920", Slot = "6")]
	private bool EFIIAABECAO(DDAOHKAFOIC AGPLDPOAAIC, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2056BB0", Offset = "0x2055BB0", VA = "0x182056BB0", Slot = "23")]
	private string EDOHEDLJKPF(in IKKMGBAJNEB CCIMHDCKHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2056B50", Offset = "0x2055B50", VA = "0x182056B50", Slot = "10")]
	private bool BLMFODPLEOP(DDAOHKAFOIC AGPLDPOAAIC, in object GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2056A90", Offset = "0x2055A90", VA = "0x182056A90", Slot = "11")]
	private void DOMFEGOCAIG(DDAOHKAFOIC AGPLDPOAAIC, in PEOLEOJFANL CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x378F6F0", Offset = "0x378E6F0", VA = "0x18378F6F0", Slot = "12")]
	private bool GPMGPLNJLFI(DDAOHKAFOIC AGPLDPOAAIC, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2057110", Offset = "0x2056110", VA = "0x182057110", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x3894DD0", Offset = "0x3893DD0", VA = "0x183894DD0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type JIDICLJAOHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3894950", Offset = "0x3893950", VA = "0x183894950", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ICGJPAAOHAG GCDLNKNDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x389D360", Offset = "0x389C360", VA = "0x18389D360", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int FNIAHIHPNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x389D7C0", Offset = "0x389C7C0", VA = "0x18389D7C0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public OGIFHIADLBO HCBHFPPKOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3893B50", Offset = "0x3892B50", VA = "0x183893B50", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x3032980", Offset = "0x3031980", VA = "0x183032980", Slot = "23")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x301E0D0", Offset = "0x301D0D0", VA = "0x18301E0D0", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::GBCMJJGIGAL<IOFHLMDPEAL> IHHEOJAELKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3898590", Offset = "0x3897590", VA = "0x183898590", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x38878C0", Offset = "0x38868C0", VA = "0x1838878C0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x30361B0", Offset = "0x30351B0", VA = "0x1830361B0")]
	public FNDBOCNPCDA(global::BCFBMFIFGMA<Entity> MIGODNJAHNA, NCNJODMFFIF JHCECLNHNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x11C2950", Offset = "0x11C1950", VA = "0x1811C2950")]
	private Entity EKGOOABIHMK(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3020100", Offset = "0x301F100", VA = "0x183020100")]
	private IOFHLMDPEAL EKGOOABIHMK(Entity GDNDJKDEKFN)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x38963E0", Offset = "0x38953E0", VA = "0x1838963E0", Slot = "4")]
	public T KEEHOGKCDPF(IOFHLMDPEAL CPBDAEHELGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3888B10", Offset = "0x3887B10", VA = "0x183888B10")]
	public bool DIMECELKFHA(IOFHLMDPEAL CPBDAEHELGD, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3893430", Offset = "0x3892430", VA = "0x183893430")]
	public bool HNBCALPENJO(IOFHLMDPEAL CPBDAEHELGD, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x388B800", Offset = "0x388A800", VA = "0x18388B800", Slot = "9")]
	public bool FKKMCEBMOMF(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x302B030", Offset = "0x302A030", VA = "0x18302B030", Slot = "25")]
	public object IEJOODGNMJN(IOFHLMDPEAL CPBDAEHELGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3890970", Offset = "0x388F970", VA = "0x183890970")]
	public bool HAHLGEBNGDK(IOFHLMDPEAL CPBDAEHELGD, in object GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x302EEA0", Offset = "0x302DEA0", VA = "0x18302EEA0")]
	public void KEEHOGKCDPF(IOFHLMDPEAL CPBDAEHELGD, in PEOLEOJFANL CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x301E630", Offset = "0x301D630", VA = "0x18301E630")]
	public bool DIMECELKFHA(IOFHLMDPEAL CPBDAEHELGD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x302A1F0", Offset = "0x30291F0", VA = "0x18302A1F0")]
	public bool HNBCALPENJO(IOFHLMDPEAL CPBDAEHELGD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x3020440", Offset = "0x301F440", VA = "0x183020440", Slot = "21")]
	public void ENNFCPGKJEH(OOBCJOADNJP EDJDHHEMACF, [Optional] object IGBOEABBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3889B90", Offset = "0x3888B90", VA = "0x183889B90", Slot = "15")]
	public void ENNFCPGKJEH(IOFHLMDPEAL AGPLDPOAAIC, KLJAFMKEJHN EDJDHHEMACF, object IGBOEABBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x301D2B0", Offset = "0x301C2B0", VA = "0x18301D2B0", Slot = "14")]
	public bool AECOPHMDBCG(IOFHLMDPEAL JNLNIIGJOFO, IOFHLMDPEAL EADBNCPOLHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x389C8C0", Offset = "0x389B8C0", VA = "0x18389C8C0")]
	private void MMAENMODJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3898FF0", Offset = "0x3897FF0", VA = "0x183898FF0")]
	private void KKMDIIPANCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x388EE30", Offset = "0x388DE30", VA = "0x18388EE30")]
	private void GLMAHECJCGI(Entity GDNDJKDEKFN, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3893FF0", Offset = "0x3892FF0", VA = "0x183893FF0")]
	private void IIDKMPOJCJL(Entity GDNDJKDEKFN, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x30200D0", Offset = "0x301F0D0", VA = "0x1830200D0", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x389D9F0", Offset = "0x389C9F0", VA = "0x18389D9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x301DF90", Offset = "0x301CF90", VA = "0x18301DF90", Slot = "5")]
	private bool DGMNHEELBLK(IOFHLMDPEAL AGPLDPOAAIC, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x30267F0", Offset = "0x30257F0", VA = "0x1830267F0", Slot = "6")]
	private bool GOJMGPHJBIN(IOFHLMDPEAL AGPLDPOAAIC, in T GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2D852B0", Offset = "0x2D842B0", VA = "0x182D852B0", Slot = "10")]
	private bool ABAEJNBNLNE(IOFHLMDPEAL AGPLDPOAAIC, in object GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3028930", Offset = "0x3027930", VA = "0x183028930", Slot = "11")]
	private void HGHHEHIOMBO(IOFHLMDPEAL AGPLDPOAAIC, in PEOLEOJFANL CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x302BCA0", Offset = "0x302ACA0", VA = "0x18302BCA0", Slot = "12")]
	private bool JBBHIGPPOHE(IOFHLMDPEAL AGPLDPOAAIC, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3035270", Offset = "0x3034270", VA = "0x183035270", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0xD92380", Offset = "0xD91380", VA = "0x180D92380", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xD97D20", Offset = "0xD96D20", VA = "0x180D97D20")]
	public JHMAKDMCKJI(NativeArray<EntityRemapUtility.EntityRemapInfo> PNALEACAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2C75DE0", Offset = "0x2C74DE0", VA = "0x182C75DE0", Slot = "6")]
	public IOFHLMDPEAL FHPNCPJBFFD(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2C75ED0", Offset = "0x2C74ED0", VA = "0x182C75ED0", Slot = "7")]
	public Entity FHPNCPJBFFD(Entity GDNDJKDEKFN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2C75E30", Offset = "0x2C74E30", VA = "0x182C75E30", Slot = "8")]
	public IEnumerable<IOFHLMDPEAL> FHPNCPJBFFD(IEnumerable<IOFHLMDPEAL> CIJFIAADMDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2C75D80", Offset = "0x2C74D80", VA = "0x182C75D80", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x29C78B0", Offset = "0x29C68B0", VA = "0x1829C78B0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static bool MCIDMJPMKKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x29C7D60", Offset = "0x29C6D60", VA = "0x1829C7D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x29C7DF0", Offset = "0x29C6DF0", VA = "0x1829C7DF0")]
		public static SerializationRemapScope KIFEBDENGNF()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x29C7EE0", Offset = "0x29C6EE0", VA = "0x1829C7EE0")]
		public SerializationRemapScope(PIALCHFKIHC MBFGLGCOPIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x29C79C0", Offset = "0x29C69C0", VA = "0x1829C79C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x29C7AD0", Offset = "0x29C6AD0", VA = "0x1829C7AD0")]
		public static IOFHLMDPEAL FHPNCPJBFFD(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x29C7C30", Offset = "0x29C6C30", VA = "0x1829C7C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x651580", Offset = "0x650580", VA = "0x180651580", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6515A0", Offset = "0x6505A0", VA = "0x1806515A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1233B90", Offset = "0x1232B90", VA = "0x181233B90", Slot = "13")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB010", Offset = "0x2CEA010", VA = "0x182CEB010", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA4F0", Offset = "0x2CE94F0", VA = "0x182CEA4F0", Slot = "15")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2CEAEA0", Offset = "0x2CE9EA0", VA = "0x182CEAEA0")]
	private IOFHLMDPEAL JDKLAIGHECL(Entity GDNDJKDEKFN)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2CEAD70", Offset = "0x2CE9D70", VA = "0x182CEAD70", Slot = "18")]
	public IOFHLMDPEAL IKKJIKAMHEN(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA9E0", Offset = "0x2CE99E0", VA = "0x182CEA9E0", Slot = "19")]
	public void FKLMDHDNEKK(ref List<IOFHLMDPEAL> LCOODLIGMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2CEADD0", Offset = "0x2CE9DD0", VA = "0x182CEADD0", Slot = "20")]
	public IEnumerable<IOFHLMDPEAL> IPBOMGOIDCM(IOFHLMDPEAL CPBDAEHELGD, bool FBOPMPBBPKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB110", Offset = "0x2CEA110", VA = "0x182CEB110", Slot = "21")]
	public IOFHLMDPEAL LHFLPHOIPHJ(IOFHLMDPEAL CPBDAEHELGD, int MMABPPDCBIB)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA930", Offset = "0x2CE9930", VA = "0x182CEA930", Slot = "22")]
	public int FDMNFBOCKJP(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2CEAC70", Offset = "0x2CE9C70", VA = "0x182CEAC70", Slot = "7")]
	public int IGNPFNMNMOD(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2CEAFA0", Offset = "0x2CE9FA0", VA = "0x182CEAFA0", Slot = "8")]
	public HJHOBDHMCLM LBKMKEPICAJ(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA6E0", Offset = "0x2CE96E0", VA = "0x182CEA6E0", Slot = "23")]
	public IEnumerable<IOFHLMDPEAL> DNDIDHHEMJL(IOFHLMDPEAL CPBDAEHELGD, bool FBOPMPBBPKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA7B0", Offset = "0x2CE97B0", VA = "0x182CEA7B0", Slot = "11")]
	public IOFHLMDPEAL EGFDMBBCIHG(IOFHLMDPEAL IFLKAOGBEDH, IOFHLMDPEAL KNPAGIAAIJP)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2CEAED0", Offset = "0x2CE9ED0", VA = "0x182CEAED0", Slot = "12")]
	public bool KDGKGEDFGPG(IOFHLMDPEAL IFLKAOGBEDH, IOFHLMDPEAL KNPAGIAAIJP, out IOFHLMDPEAL FNFLMMJIIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2CEABD0", Offset = "0x2CE9BD0", VA = "0x182CEABD0", Slot = "4")]
	public IOFHLMDPEAL GECBLHBNBIF(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA680", Offset = "0x2CE9680", VA = "0x182CEA680", Slot = "10")]
	public bool CMHAFNALMKK(IOFHLMDPEAL CPBDAEHELGD, IOFHLMDPEAL POADJDFNECJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA6B0", Offset = "0x2CE96B0", VA = "0x182CEA6B0", Slot = "24")]
	public bool DEEFPGIOMCP(IOFHLMDPEAL CPBDAEHELGD, IOFHLMDPEAL FOCEJAMAOBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA5E0", Offset = "0x2CE95E0", VA = "0x182CEA5E0", Slot = "9")]
	public bool BCBFDHJANCI(IOFHLMDPEAL CPBDAEHELGD, IOFHLMDPEAL IFLKAOGBEDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA880", Offset = "0x2CE9880", VA = "0x182CEA880", Slot = "5")]
	public bool EPDJFMCJDGO(IOFHLMDPEAL CPBDAEHELGD, IOFHLMDPEAL OJKLIAPCMPJ, bool EMJIKBJAOKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA610", Offset = "0x2CE9610", VA = "0x182CEA610", Slot = "6")]
	public bool BNDMHFGOGFC(IOFHLMDPEAL CPBDAEHELGD, IOFHLMDPEAL OJKLIAPCMPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x81A4B0", Offset = "0x8194B0", VA = "0x18081A4B0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0xD92380", Offset = "0xD91380", VA = "0x180D92380")]
		get
		{
			return default(NativeList<GGKPENPPBHO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeList<OJEIBILPNMC> GLPEEBAAOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xCBE830", Offset = "0xCBD830", VA = "0x180CBE830")]
		get
		{
			return default(NativeList<OJEIBILPNMC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeList<GGKPENPPBHO> FKJNKBIBEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x11927E0", Offset = "0x11917E0", VA = "0x1811927E0")]
		get
		{
			return default(NativeList<GGKPENPPBHO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NENJDBEJJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2C8EC20", Offset = "0x2C8DC20", VA = "0x182C8EC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2C8EDF0", Offset = "0x2C8DDF0", VA = "0x182C8EDF0")]
	public PIEJAMPEPCM(Allocator EGJIMBMGFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2C8ECB0", Offset = "0x2C8DCB0", VA = "0x182C8ECB0")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2C8ED20", Offset = "0x2C8DD20", VA = "0x182C8ED20")]
	public void PDHGAAMLKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2C8EA40", Offset = "0x2C8DA40", VA = "0x182C8EA40")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C79C30", Offset = "0x2C78C30", VA = "0x182C79C30", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2C79F40", Offset = "0x2C78F40", VA = "0x182C79F40")]
	public PIEJAMPEPCM LNGDLHHNAKA(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2C79D10", Offset = "0x2C78D10", VA = "0x182C79D10")]
	public PIEJAMPEPCM LNGDLHHNAKA(FHCGLCCCIJI LKIMNIMPHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A020", Offset = "0x2C79020", VA = "0x182C7A020")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2C799D0", Offset = "0x2C789D0", VA = "0x182C799D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A190", Offset = "0x2C79190", VA = "0x182C7A190")]
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
				[Cpp2IlInjected.Address(RVA = "0x29BAE80", Offset = "0x29B9E80", VA = "0x1829BAE80")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public JBDILOLFOCF[] HNAEPMCGJIE
			{
				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x29BACC0", Offset = "0x29B9CC0", VA = "0x1829BACC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
			public GEPMLPPJOPE(ActionBuffer CNJJEFONDHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x29BAD90", Offset = "0x29B9D90", VA = "0x1829BAD90")]
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
				[Cpp2IlInjected.Address(RVA = "0x29BB980", Offset = "0x29BA980", VA = "0x1829BB980")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public List<(OCPNCAHNNFG, string, object)> CHBGDIOAKKM
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x29BBD10", Offset = "0x29BAD10", VA = "0x1829BBD10")]
			public JBDILOLFOCF(ActionBuffer CNJJEFONDHG, KCDGFHGLMJA NCHNGIGODJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x29BB880", Offset = "0x29BA880", VA = "0x1829BB880")]
			private string EKJLAAEHEOA(OCPNCAHNNFG NMDPGMLBILI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x29BB9D0", Offset = "0x29BA9D0", VA = "0x1829BB9D0")]
			private void MADPLDOCFBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x30831C0", Offset = "0x30821C0", VA = "0x1830831C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CE8EE0", Offset = "0x2CE7EE0", VA = "0x182CE8EE0")]
			get
			{
				return default(NPFADAJLONC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int CAAMIJFBOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x2CE89C0", Offset = "0x2CE79C0", VA = "0x182CE89C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9260", Offset = "0x2CE8260", VA = "0x182CE9260")]
		public ActionBuffer(CHCKBAIGEAG LMCKKENKDOK, FMFHLBFGHJI IEBMFIFBGIK, bool BCMKBJPEIAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8E50", Offset = "0x2CE7E50", VA = "0x182CE8E50")]
		public bool LEHJOKFBFDK(out KCDGFHGLMJA NCHNGIGODJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2CE91A0", Offset = "0x2CE81A0", VA = "0x182CE91A0")]
		public void OJEEPLKEKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9060", Offset = "0x2CE8060", VA = "0x182CE9060")]
		public KCDGFHGLMJA MMFGOGFMNKL(IEBCBAINFFE JKAKLGDNGFP, JJENBGOMCNI BCDLAFDPGCJ, uint BJAGEHHPBBC)
		{
			return default(KCDGFHGLMJA);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8D10", Offset = "0x2CE7D10", VA = "0x182CE8D10")]
		public bool IFFLFCDOAJD(uint BJAGEHHPBBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2CE85F0", Offset = "0x2CE75F0", VA = "0x182CE85F0")]
		public bool CMOIEGDOBKP(uint BJAGEHHPBBC, out KCDGFHGLMJA MJPNNJLLLLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8850", Offset = "0x2CE7850", VA = "0x182CE8850")]
		public void EGGMJMNGFDA(KCDGFHGLMJA MJPNNJLLLLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8F20", Offset = "0x2CE7F20", VA = "0x182CE8F20")]
		[Conditional("DEBUG_BUILD")]
		private void MJFDPIMDAFJ(KCDGFHGLMJA MJPNNJLLLLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8D40", Offset = "0x2CE7D40", VA = "0x182CE8D40")]
		private void KCGLNFJFBOB(KCDGFHGLMJA FMIPOENOOKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8A00", Offset = "0x2CE7A00", VA = "0x182CE8A00")]
		private void FLBALAEEFFA(OMMNMAIFOHO DAPDMAPOPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8590", Offset = "0x2CE7590", VA = "0x182CE8590")]
		private void CMOBDLHMPDD(KCDGFHGLMJA NCHNGIGODJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2CE8C50", Offset = "0x2CE7C50", VA = "0x182CE8C50")]
		private OMMNMAIFOHO IBJHEFFHFOO(KCDGFHGLMJA NCHNGIGODJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2CE87E0", Offset = "0x2CE77E0", VA = "0x182CE87E0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x64A6E0", Offset = "0x6496E0", VA = "0x18064A6E0")]
	public OGFHFMEKKFB(CHCKBAIGEAG LMCKKENKDOK, FMFHLBFGHJI IEBMFIFBGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2AF57A0", Offset = "0x2AF47A0", VA = "0x182AF57A0", Slot = "4")]
	public void CPNDBBPBHFN<TKey, T>(global::NJDICNIFPMB<TKey, T> ENNHENNPOKM, [Optional] object IGBOEABBEHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2C81F60", Offset = "0x2C80F60", VA = "0x182C81F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ED1D30", Offset = "0x4ED0D30", VA = "0x184ED1D30")]
		public HPAHHEKPGIP(HIKCKCKAEBF OJKLIAPCMPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4ED1D10", Offset = "0x4ED0D10", VA = "0x184ED1D10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C71240", Offset = "0x2C70240", VA = "0x182C71240")]
		get
		{
			return default(IEBCBAINFFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool IAHCGBJIDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2C70F20", Offset = "0x2C6FF20", VA = "0x182C70F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2C71370", Offset = "0x2C70370", VA = "0x182C71370")]
	public HIKCKCKAEBF(IEBCBAINFFE.KKBKGGEDACK ACEIPIDELDE = IEBCBAINFFE.KKBKGGEDACK.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2C71280", Offset = "0x2C70280", VA = "0x182C71280")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2C71090", Offset = "0x2C70090", VA = "0x182C71090")]
	public void KELGJPAMBIF(DDAOHKAFOIC PFLOECMCNHK, BBAJGMCCMCB IBHOKKEKMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2C71030", Offset = "0x2C70030", VA = "0x182C71030")]
	public void IPLKCJIBGHO(DDAOHKAFOIC PFLOECMCNHK, FHCGLCCCIJI LKIMNIMPHKB, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2C70F40", Offset = "0x2C6FF40", VA = "0x182C70F40")]
	public void FHEIEPOBCFB(DDAOHKAFOIC PFLOECMCNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2C71290", Offset = "0x2C70290", VA = "0x182C71290")]
	public void PNODODGFGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2C71160", Offset = "0x2C70160", VA = "0x182C71160")]
	public void LNLDLKLBOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2C70F30", Offset = "0x2C6FF30", VA = "0x182C70F30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2C71000", Offset = "0x2C70000", VA = "0x182C71000")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C81E40", Offset = "0x2C80E40", VA = "0x182C81E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x66B050", Offset = "0x66A050", VA = "0x18066B050")]
	public OCPNCAHNNFG(DDAOHKAFOIC PFLOECMCNHK, FHCGLCCCIJI LKIMNIMPHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2C81D00", Offset = "0x2C80D00", VA = "0x182C81D00")]
	public void DCGAGGEDHOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2C81CC0", Offset = "0x2C80CC0", VA = "0x182C81CC0", Slot = "4")]
	public int CompareTo(OCPNCAHNNFG IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2C81EA0", Offset = "0x2C80EA0", VA = "0x182C81EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2C81D60", Offset = "0x2C80D60", VA = "0x182C81D60", Slot = "0")]
	public override bool Equals(object ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2C81D10", Offset = "0x2C80D10", VA = "0x182C81D10", Slot = "5")]
	public bool Equals(OCPNCAHNNFG IIKMMJKCGDO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2C81C80", Offset = "0x2C80C80", VA = "0x182C81C80")]
	public static bool CGFEPDNGNBJ(OCPNCAHNNFG FEBCAKEBBCL, OCPNCAHNNFG EEACLMBPLFE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2C81E50", Offset = "0x2C80E50", VA = "0x182C81E50")]
	public static bool NODBGCCFDAJ(OCPNCAHNNFG FEBCAKEBBCL, OCPNCAHNNFG EEACLMBPLFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2C81E00", Offset = "0x2C80E00", VA = "0x182C81E00", Slot = "2")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D053C0", Offset = "0x2D043C0", VA = "0x182D053C0")]
	public void NHHLDECCNLN(DDAOHKAFOIC PFLOECMCNHK, CHCKBAIGEAG LMCKKENKDOK, ECJNNBLJLBI FLMDCNMMHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2D05270", Offset = "0x2D04270", VA = "0x182D05270", Slot = "4")]
	private void IMKOBKNKDBP(BDLFOPPLKDB MIGODNJAHNA, in IKKMGBAJNEB CCIMHDCKHOF, object IGBOEABBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public HEICHNECIDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class MOBHAINPGNJ
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F310", Offset = "0x2C7E310", VA = "0x182C7F310")]
	public static void IBLFBEBKBGC(IEBCBAINFFE JKAKLGDNGFP, OCPNCAHNNFG NMDPGMLBILI, BBAJGMCCMCB IBHOKKEKMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F4B0", Offset = "0x2C7E4B0", VA = "0x182C7F4B0")]
	public static void KGBPFEMGELK(IEBCBAINFFE JKAKLGDNGFP, OCPNCAHNNFG NMDPGMLBILI, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F720", Offset = "0x2C7E720", VA = "0x182C7F720")]
	public static void PKADDDKGOBE(IEBCBAINFFE JKAKLGDNGFP, OCPNCAHNNFG NMDPGMLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F5F0", Offset = "0x2C7E5F0", VA = "0x182C7F5F0")]
	public static void LLGOAILEGBN(IEBCBAINFFE JKAKLGDNGFP, OCPNCAHNNFG NMDPGMLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F2C0", Offset = "0x2C7E2C0", VA = "0x182C7F2C0")]
	public static BBAJGMCCMCB GBLIELGMMDM(IEBCBAINFFE JKAKLGDNGFP, OCPNCAHNNFG NMDPGMLBILI)
	{
		return default(BBAJGMCCMCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2C2AF90", Offset = "0x2C29F90", VA = "0x182C2AF90")]
	public static T FCJGIAGAOBH<T>(IEBCBAINFFE JKAKLGDNGFP, OCPNCAHNNFG NMDPGMLBILI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2C2AF60", Offset = "0x2C29F60", VA = "0x182C2AF60")]
	public static T FCJGIAGAOBH<T>(ref OMMNMAIFOHO PJDKPCLOECB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F270", Offset = "0x2C7E270", VA = "0x182C7F270")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BA970", Offset = "0x29B9970", VA = "0x1829BA970")]
		public EEFNHIADCIP(ECJNNBLJLBI GJMHFONGMCN, bool AKGLPDOPBCJ, uint LDFDMKAILBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x29BA940", Offset = "0x29B9940", VA = "0x1829BA940", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED1D90", Offset = "0x4ED0D90", VA = "0x184ED1D90")]
			public IBFJFPEGIEB(HEONBIGBGIN KBGJCMKGEHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1D60", Offset = "0x4ED0D60", VA = "0x184ED1D60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED2CF0", Offset = "0x4ED1CF0", VA = "0x184ED2CF0")]
			public JGGBPFPLONA(HEONBIGBGIN KBGJCMKGEHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1D60", Offset = "0x4ED0D60", VA = "0x184ED1D60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BB040", Offset = "0x29BA040", VA = "0x1829BB040")]
		public HEONBIGBGIN(ECJNNBLJLBI FLMDCNMMHMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x29BB010", Offset = "0x29BA010", VA = "0x1829BB010")]
		public bool LCEKOBGNEAC(DDAOHKAFOIC PFLOECMCNHK, FHCGLCCCIJI LKIMNIMPHKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x29BAFF0", Offset = "0x29B9FF0", VA = "0x1829BAFF0")]
		public JGGBPFPLONA KCLPJEAFCJL()
		{
			return default(JGGBPFPLONA);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x29BAFD0", Offset = "0x29B9FD0", VA = "0x1829BAFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public FPEHKHEHEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x29BAC60", Offset = "0x29B9C60", VA = "0x1829BAC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public KJJHBHPBOKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x29BBF80", Offset = "0x29BAF80", VA = "0x1829BBF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public DEDEGNLNGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x29BA340", Offset = "0x29B9340", VA = "0x1829BA340")]
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
		[Cpp2IlInjected.Address(RVA = "0x660780", Offset = "0x65F780", VA = "0x180660780")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF8480", Offset = "0x2CF7480", VA = "0x182CF8480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool IFPGPJKDJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2CF8A30", Offset = "0x2CF7A30", VA = "0x182CF8A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool ICLODOGBLPH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2CF8100", Offset = "0x2CF7100", VA = "0x182CF8100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int FKALGHBAIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7ED0", Offset = "0x2CF6ED0", VA = "0x182CF7ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int FAFPOPAFBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2CF9B10", Offset = "0x2CF8B10", VA = "0x182CF9B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private bool NNCCLEEJEII
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2CF9B60", Offset = "0x2CF8B60", VA = "0x182CF9B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private bool NMHOFMPILJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2CF80F0", Offset = "0x2CF70F0", VA = "0x182CF80F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool MCFNDHNDEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x79D070", Offset = "0x79C070", VA = "0x18079D070", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x79D2C0", Offset = "0x79C2C0", VA = "0x18079D2C0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private ActionBuffer BHJFJINBGHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2CF9B70", Offset = "0x2CF8B70", VA = "0x182CF9B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action OGMIDDDGAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2CF93F0", Offset = "0x2CF83F0", VA = "0x182CF93F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2CF9490", Offset = "0x2CF8490", VA = "0x182CF9490", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action BACNJELGBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2CF8990", Offset = "0x2CF7990", VA = "0x182CF8990")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2CF97D0", Offset = "0x2CF87D0", VA = "0x182CF97D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9F50", Offset = "0x2CF8F50", VA = "0x182CF9F50")]
	public ECJNNBLJLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9530", Offset = "0x2CF8530", VA = "0x182CF9530", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8580", Offset = "0x2CF7580", VA = "0x182CF8580", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8400", Offset = "0x2CF7400", VA = "0x182CF8400", Slot = "14")]
	public IDisposable CHPCLLPDICF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8710", Offset = "0x2CF7710", VA = "0x182CF8710", Slot = "9")]
	public IDisposable EEPJJBICCHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9870", Offset = "0x2CF8870", VA = "0x182CF9870", Slot = "6")]
	public UndoAction MMFGOGFMNKL()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9A50", Offset = "0x2CF8A50", VA = "0x182CF9A50", Slot = "15")]
	public RedoAction MODOBNPEOEI()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9B80", Offset = "0x2CF8B80", VA = "0x182CF9B80", Slot = "16")]
	public UndoAction OANLJOGAMBI()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9930", Offset = "0x2CF8930", VA = "0x182CF9930", Slot = "7")]
	public RedoAction MODOBNPEOEI(UndoAction MJPNNJLLLLB)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9C40", Offset = "0x2CF8C40", VA = "0x182CF9C40", Slot = "8")]
	public UndoAction OANLJOGAMBI(RedoAction MJPNNJLLLLB)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8540", Offset = "0x2CF7540", VA = "0x182CF8540")]
	public bool DFMBKPOPGDO(JICEPMCGADA KNJKIMOINAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9D60", Offset = "0x2CF8D60", VA = "0x182CF9D60", Slot = "17")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9330", Offset = "0x2CF8330", VA = "0x182CF9330")]
	public void KELGJPAMBIF(DDAOHKAFOIC PFLOECMCNHK, BBAJGMCCMCB IBHOKKEKMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8CC0", Offset = "0x2CF7CC0", VA = "0x182CF8CC0")]
	public void IPLKCJIBGHO(DDAOHKAFOIC PFLOECMCNHK, FHCGLCCCIJI LKIMNIMPHKB, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2CF88E0", Offset = "0x2CF78E0", VA = "0x182CF88E0")]
	public void FHEIEPOBCFB(DDAOHKAFOIC PFLOECMCNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8BD0", Offset = "0x2CF7BD0", VA = "0x182CF8BD0")]
	private void GKKCGLAHPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2CF9E40", Offset = "0x2CF8E40", VA = "0x182CF9E40")]
	private void OMJHHHABIDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8C50", Offset = "0x2CF7C50", VA = "0x182CF8C50")]
	private void IBIBPICNCJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2CF81E0", Offset = "0x2CF71E0", VA = "0x182CF81E0")]
	private KCDGFHGLMJA CCDLCOJHFOC()
	{
		return default(KCDGFHGLMJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8C10", Offset = "0x2CF7C10", VA = "0x182CF8C10")]
	private uint GMMOMIKMHBG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8460", Offset = "0x2CF7460", VA = "0x182CF8460")]
	private bool CNAHPPLBCOF(out KCDGFHGLMJA NCHNGIGODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8C30", Offset = "0x2CF7C30", VA = "0x182CF8C30")]
	private bool HEIJAEINDOK(out KCDGFHGLMJA NCHNGIGODJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2CF84E0", Offset = "0x2CF74E0", VA = "0x182CF84E0")]
	private RedoAction DECGMMGGAGL(KCDGFHGLMJA NCHNGIGODJK)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8180", Offset = "0x2CF7180", VA = "0x182CF8180")]
	private UndoAction BOLBJHBFMCI(KCDGFHGLMJA NCHNGIGODJK)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8F40", Offset = "0x2CF7F40", VA = "0x182CF8F40")]
	private KCDGFHGLMJA KCGLNFJFBOB(KCDGFHGLMJA NCHNGIGODJK, ActionBuffer JIDMMEPEFPN, bool AKGLPDOPBCJ)
	{
		return default(KCDGFHGLMJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8AF0", Offset = "0x2CF7AF0", VA = "0x182CF8AF0")]
	private void GEKLENIMHLL(Action NCHNGIGODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2922E10", Offset = "0x2921E10", VA = "0x182922E10")]
	private T GEKLENIMHLL<T>(Func<T> HKNPNGGIBCL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8150", Offset = "0x2CF7150", VA = "0x182CF8150")]
	private EEFNHIADCIP ALEMOILNAJD(bool AKGLPDOPBCJ, uint LDFDMKAILBI)
	{
		return default(EEFNHIADCIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8D90", Offset = "0x2CF7D90", VA = "0x182CF8D90")]
	[CompilerGenerated]
	private UndoAction JCOKADDEJLK()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2CF8770", Offset = "0x2CF7770", VA = "0x182CF8770")]
	[CompilerGenerated]
	private RedoAction ENONCNHFKDL()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7F90", Offset = "0x2CF6F90", VA = "0x182CF7F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ED60F0", Offset = "0x4ED50F0", VA = "0x184ED60F0")]
		public ODEFHLAIDOK(IEBCBAINFFE PIJDNOPJENO, JJENBGOMCNI BCDLAFDPGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4ED5A50", Offset = "0x4ED4A50", VA = "0x184ED5A50")]
		public void CKMGPDILFJL(NativeList<byte> JMJPBBLODJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4ED5DE0", Offset = "0x4ED4DE0", VA = "0x184ED5DE0")]
		private void EHEMOEAAMGF(OCPNCAHNNFG NMDPGMLBILI, ref FCADEMDJDOO JFCGPBDBIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6060", Offset = "0x4ED5060", VA = "0x184ED6060")]
		private void JPOOCKFJPLA(OCPNCAHNNFG NMDPGMLBILI, ref FCADEMDJDOO JFCGPBDBIKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4ED5CF0", Offset = "0x4ED4CF0", VA = "0x184ED5CF0")]
		private NativeArray<byte> EEONGJNAJNJ(NativeList<byte> JMJPBBLODJI)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4ED5800", Offset = "0x4ED4800", VA = "0x184ED5800")]
		private NativeArray<byte> BIGKGKCODEB(NativeList<byte> JMJPBBLODJI, int HOPGLJCPGGA)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4ED5E30", Offset = "0x4ED4E30", VA = "0x184ED5E30")]
		private int JKPDNBPIHND()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4ED58F0", Offset = "0x4ED48F0", VA = "0x184ED58F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ED5090", Offset = "0x4ED4090", VA = "0x184ED5090")]
		internal NNDLPPAFFCO(IEBCBAINFFE PIJDNOPJENO, OCPNCAHNNFG LENKHFNFMLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4ED5050", Offset = "0x4ED4050", VA = "0x184ED5050", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4F20", Offset = "0x4ED3F20", VA = "0x184ED4F20")]
		public void GMLFHNCHNPM(NativeArray<byte> CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4FF0", Offset = "0x4ED3FF0", VA = "0x184ED4FF0")]
		public void CEFFJCEHBMK(NativeArray<byte> CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4ED5080", Offset = "0x4ED4080", VA = "0x184ED5080")]
		public void JPOOCKFJPLA(in IKKMGBAJNEB CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x2FD73A0", Offset = "0x2FD63A0", VA = "0x182FD73A0")]
		public void JPOOCKFJPLA<T>(T CCIMHDCKHOF) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4F80", Offset = "0x4ED3F80", VA = "0x184ED4F80")]
		private void BILIIEJMLJP(int CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4E10", Offset = "0x4ED3E10", VA = "0x184ED4E10")]
		private void BILIIEJMLJP(in IKKMGBAJNEB CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4EC0", Offset = "0x4ED3EC0", VA = "0x184ED4EC0")]
		private unsafe void BILIIEJMLJP(void* ALKFOKGKFIJ, int HOPGLJCPGGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4F20", Offset = "0x4ED3F20", VA = "0x184ED4F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ECFC00", Offset = "0x4ECEC00", VA = "0x184ECFC00")]
		internal CLPACMLOEFA(IEBCBAINFFE PIJDNOPJENO, NativeArray<byte> PJDKPCLOECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x4ECFA00", Offset = "0x4ECEA00", VA = "0x184ECFA00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF940", Offset = "0x4ECE940", VA = "0x184ECF940")]
		public NativeArray<byte> DMOMLNDJJKD(int HOPGLJCPGGA)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4ECFB10", Offset = "0x4ECEB10", VA = "0x184ECFB10")]
		public NativeArray<byte> PDHHELFFDJF()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8980", Offset = "0x2FC7980", VA = "0x182FC8980")]
		public T OALNAJCMKCK<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4ECFA10", Offset = "0x4ECEA10", VA = "0x184ECFA10")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED6340", Offset = "0x4ED5340", VA = "0x184ED6340", Slot = "4")]
			get
			{
				return default(OCPNCAHNNFG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x4ED6300", Offset = "0x4ED5300", VA = "0x184ED6300", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2E35E70", Offset = "0x2E34E70", VA = "0x182E35E70")]
		internal PAIHOKFNADC(NativeArray<OCPNCAHNNFG> EADBNCPOLHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x4ED6250", Offset = "0x4ED5250", VA = "0x184ED6250", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x4ED62C0", Offset = "0x4ED52C0", VA = "0x184ED62C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED4520", Offset = "0x4ED3520", VA = "0x184ED4520")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x4ED44D0", Offset = "0x4ED34D0", VA = "0x184ED44D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public KKBKGGEDACK PHOABLFAEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x4ED4530", Offset = "0x4ED3530", VA = "0x184ED4530")]
			get
			{
				return default(KKBKGGEDACK);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x4ED44E0", Offset = "0x4ED34E0", VA = "0x184ED44E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool IAHCGBJIDBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x4ED43F0", Offset = "0x4ED33F0", VA = "0x184ED43F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x4ED4490", Offset = "0x4ED3490", VA = "0x184ED4490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool BAMIGCDOJPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x4ED4480", Offset = "0x4ED3480", VA = "0x184ED4480")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x4ED44B0", Offset = "0x4ED34B0", VA = "0x184ED44B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4540", Offset = "0x4ED3540", VA = "0x184ED4540")]
		public MOMOEFENAJI(KKBKGGEDACK ACEIPIDELDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x4ED44F0", Offset = "0x4ED34F0", VA = "0x184ED44F0")]
		private int KEEHOGKCDPF(int EGBIMJLECFF, int EDJOGEJKLPG = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4400", Offset = "0x4ED3400", VA = "0x184ED4400")]
		private void DIMECELKFHA(int EGBIMJLECFF, int CCIMHDCKHOF, int EDJOGEJKLPG = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4440", Offset = "0x4ED3440", VA = "0x184ED4440", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C73C30", Offset = "0x2C72C30", VA = "0x182C73C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool NENJDBEJJHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x2C74580", Offset = "0x2C73580", VA = "0x182C74580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int CHEGJAFNAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x2C74570", Offset = "0x2C73570", VA = "0x182C74570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int EHJGMEIMDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C742B0", Offset = "0x2C732B0", VA = "0x182C742B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2C745A0", Offset = "0x2C735A0", VA = "0x182C745A0")]
	public static IEBCBAINFFE MFNJFAEBAIM(KKBKGGEDACK ACEIPIDELDE = KKBKGGEDACK.Last, int KPMEJBNJFHL = 16, int PIAHBHHLCJI = 256)
	{
		return default(IEBCBAINFFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C74910", Offset = "0x2C73910", VA = "0x182C74910")]
	private IEBCBAINFFE(KKBKGGEDACK ACEIPIDELDE, int KPMEJBNJFHL, int PIAHBHHLCJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2C74090", Offset = "0x2C73090", VA = "0x182C74090", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2C745E0", Offset = "0x2C735E0", VA = "0x182C745E0")]
	public NNDLPPAFFCO NEKOKLMLGBA(OCPNCAHNNFG LENKHFNFMLN)
	{
		return default(NNDLPPAFFCO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2C744E0", Offset = "0x2C734E0", VA = "0x182C744E0")]
	public CLPACMLOEFA LMDMGILHDLO(OCPNCAHNNFG LENKHFNFMLN)
	{
		return default(CLPACMLOEFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2C73DB0", Offset = "0x2C72DB0", VA = "0x182C73DB0")]
	public bool DAAPNLNAEMC(OCPNCAHNNFG LENKHFNFMLN, out CLPACMLOEFA GGEIAOMMHHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2C74260", Offset = "0x2C73260", VA = "0x182C74260")]
	public bool IELELMEGGBG(OCPNCAHNNFG LENKHFNFMLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2C74670", Offset = "0x2C73670", VA = "0x182C74670")]
	public bool NLAKLIJIPGA(OCPNCAHNNFG LENKHFNFMLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C73CC0", Offset = "0x2C72CC0", VA = "0x182C73CC0")]
	public void COGOKMCGGNA(NativeList<byte> JMJPBBLODJI, JJENBGOMCNI BCDLAFDPGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F3D620", Offset = "0x1F3C620", VA = "0x181F3D620")]
	public T HGMFBEDJIMN<T>(OCPNCAHNNFG LENKHFNFMLN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C74740", Offset = "0x2C73740", VA = "0x182C74740")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C73C40", Offset = "0x2C72C40", VA = "0x182C73C40")]
	public PAIHOKFNADC CDEDLLPMOKO()
	{
		return default(PAIHOKFNADC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C742F0", Offset = "0x2C732F0", VA = "0x182C742F0")]
	private void JOGOLPIJHJF(OCPNCAHNNFG LENKHFNFMLN, int OMKHMNIPPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C73FA0", Offset = "0x2C72FA0", VA = "0x182C73FA0")]
	private void DCGAGGEDHOB(int GNFLMICMPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C74170", Offset = "0x2C73170", VA = "0x182C74170")]
	private void HLCIFLAPLCP(OCPNCAHNNFG LENKHFNFMLN, int OMKHMNIPPGH, int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F3D5A0", Offset = "0x1F3C5A0", VA = "0x181F3D5A0")]
	private static T HGMFBEDJIMN<T>(NativeArray<byte> KPAFOBEJBIN, int EGBIMJLECFF = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C74850", Offset = "0x2C73850", VA = "0x182C74850", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C74810", Offset = "0x2C73810", VA = "0x182C74810", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BBD0", Offset = "0x64ABD0", VA = "0x18064BBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xD97D20", Offset = "0xD96D20", VA = "0x180D97D20")]
	public IFOCMHFKMGM(NativeArray<byte> KPAFOBEJBIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2C74A80", Offset = "0x2C73A80", VA = "0x182C74A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BBD0", Offset = "0x64ABD0", VA = "0x18064BBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xD97D20", Offset = "0xD96D20", VA = "0x180D97D20")]
	public OMMNMAIFOHO(NativeArray<byte> KPAFOBEJBIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2C851C0", Offset = "0x2C841C0", VA = "0x182C851C0")]
	public static OMMNMAIFOHO EDIIAGKPKGG(NativeArray<byte> KPAFOBEJBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2AFDD40", Offset = "0x2AFCD40", VA = "0x182AFDD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BBD0", Offset = "0x64ABD0", VA = "0x18064BBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xD97D20", Offset = "0xD96D20", VA = "0x180D97D20")]
	public FCADEMDJDOO(NativeArray<byte> KPAFOBEJBIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x2CFEA30", Offset = "0x2CFDA30", VA = "0x182CFEA30")]
	public static FCADEMDJDOO EDIIAGKPKGG(NativeArray<byte> KPAFOBEJBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2B50F80", Offset = "0x2B4FF80", VA = "0x182B50F80")]
	public void CFNNLCLHEGH<T>(in T CCIMHDCKHOF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2B50FE0", Offset = "0x2B4FFE0", VA = "0x182B50FE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7B360", Offset = "0x2C7A360", VA = "0x182C7B360")]
	public static Span<byte> DFBJJPBNILG(this NativeArray<byte> KPAFOBEJBIN)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B4E0", Offset = "0x2C7A4E0", VA = "0x182C7B4E0")]
	public static ReadOnlySpan<byte> HDKJMGLDCGN(this NativeArray<byte> KPAFOBEJBIN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B260", Offset = "0x2C7A260", VA = "0x182C7B260")]
	public static NativeArray<byte> AEJJAHNJJKC(this NativeArray<byte> KPAFOBEJBIN, int OMKHMNIPPGH)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B660", Offset = "0x2C7A660", VA = "0x182C7B660")]
	public static NativeArray<byte> HHOLDKCMIKE(this NativeArray<byte> KPAFOBEJBIN, int LGKBEOCJMLG = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x27F1F60", Offset = "0x27F0F60", VA = "0x1827F1F60")]
	public static NativeArray<byte> HHOLDKCMIKE<T>(this NativeArray<byte> KPAFOBEJBIN, int LGKBEOCJMLG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B6E0", Offset = "0x2C7A6E0", VA = "0x182C7B6E0")]
	public static NativeArray<byte> KLGPHNFGEKC(this NativeArray<byte> KPAFOBEJBIN, int LGKBEOCJMLG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x27F1FC0", Offset = "0x27F0FC0", VA = "0x1827F1FC0")]
	public static NativeArray<byte> KLGPHNFGEKC<T>(this NativeArray<byte> KPAFOBEJBIN, int LGKBEOCJMLG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B2E0", Offset = "0x2C7A2E0", VA = "0x182C7B2E0")]
	public static NativeArray<byte> CEBFGCKGOEM(this NativeArray<byte> KPAFOBEJBIN, int LGKBEOCJMLG = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x27F0AC0", Offset = "0x27EFAC0", VA = "0x1827F0AC0")]
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
	[Cpp2IlInjected.Address(RVA = "0xD97D20", Offset = "0xD96D20", VA = "0x180D97D20")]
	public LMLFAOPOALJ(NativeList<byte> PIJDNOPJENO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A9E0", Offset = "0x2C799E0", VA = "0x182C7A9E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x29C34F0", Offset = "0x29C24F0", VA = "0x1829C34F0")]
		public HIKCKCKAEBF.HPAHHEKPGIP FOEEADKNKOH()
		{
			return default(HIKCKCKAEBF.HPAHHEKPGIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x29C3460", Offset = "0x29C2460", VA = "0x1829C3460", Slot = "4")]
		public void FKDGDLIKCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x29C36E0", Offset = "0x29C26E0", VA = "0x1829C36E0", Slot = "5")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x29C37B0", Offset = "0x29C27B0", VA = "0x1829C37B0")]
		public void MMFGOGFMNKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x29C38C0", Offset = "0x29C28C0", VA = "0x1829C38C0")]
		private void NEKOKLMLGBA(OCPNCAHNNFG LENKHFNFMLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x29C3510", Offset = "0x29C2510", VA = "0x1829C3510")]
		private void IBLFBEBKBGC(OCPNCAHNNFG LENKHFNFMLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x29C3BA0", Offset = "0x29C2BA0", VA = "0x1829C3BA0")]
		private void PKADDDKGOBE(OCPNCAHNNFG LENKHFNFMLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x29C3C60", Offset = "0x29C2C60", VA = "0x1829C3C60")]
		private void PNODODGFGHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x29C3790", Offset = "0x29C2790", VA = "0x1829C3790")]
		private void LNLDLKLBOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x29C3640", Offset = "0x29C2640", VA = "0x1829C3640")]
		private void JAKOJNOLJLO(OCPNCAHNNFG LENKHFNFMLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x37F26B0", Offset = "0x37F16B0", VA = "0x1837F26B0", Slot = "6")]
		private void ANFINHPIGJO<TKey, T>(global::NJDICNIFPMB<TKey, T> MIGODNJAHNA, object IGBOEABBEHO) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x29C3430", Offset = "0x29C2430", VA = "0x1829C3430", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7A6C0", Offset = "0x2C796C0", VA = "0x182C7A6C0", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A210", Offset = "0x2C79210", VA = "0x182C7A210", Slot = "5")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A5B0", Offset = "0x2C795B0", VA = "0x182C7A5B0")]
	public void KELGJPAMBIF(DDAOHKAFOIC PFLOECMCNHK, BBAJGMCCMCB IBHOKKEKMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A530", Offset = "0x2C79530", VA = "0x182C7A530")]
	public void IPLKCJIBGHO(DDAOHKAFOIC PFLOECMCNHK, FHCGLCCCIJI LKIMNIMPHKB, in IKKMGBAJNEB KBMJKBNKEOP, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A330", Offset = "0x2C79330", VA = "0x182C7A330")]
	public void FHEIEPOBCFB(DDAOHKAFOIC PFLOECMCNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A310", Offset = "0x2C79310", VA = "0x182C7A310")]
	private void BHEEPKINCLB(DDAOHKAFOIC PFLOECMCNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A7A0", Offset = "0x2C797A0", VA = "0x182C7A7A0")]
	public void OKMAIJBCBFB(DDAOHKAFOIC PFLOECMCNHK, FHCGLCCCIJI LKIMNIMPHKB, in IKKMGBAJNEB KBMJKBNKEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A490", Offset = "0x2C79490", VA = "0x182C7A490")]
	private void HCKFGGJCDOF(DDAOHKAFOIC PFLOECMCNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A820", Offset = "0x2C79820", VA = "0x182C7A820")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CFFB50", Offset = "0x2CFEB50", VA = "0x182CFFB50", Slot = "7")]
	public virtual void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFA40", Offset = "0x2CFEA40", VA = "0x182CFFA40", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF9F0", Offset = "0x2CFE9F0", VA = "0x182CFF9F0")]
	public DDAOHKAFOIC CPNJFFPDPIN()
	{
		return default(DDAOHKAFOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFAD0", Offset = "0x2CFEAD0", VA = "0x182CFFAD0")]
	public void KHLHOKOFEOM(DDAOHKAFOIC GNEIAJCHPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFC00", Offset = "0x2CFEC00", VA = "0x182CFFC00", Slot = "8")]
	public virtual void PKLFPAMOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x66C1B0", Offset = "0x66B1B0", VA = "0x18066C1B0", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7E50", Offset = "0x2CE6E50", VA = "0x182CE7E50", Slot = "7")]
	public override void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7E00", Offset = "0x2CE6E00", VA = "0x182CE7E00")]
	private void FFOAPLAJKBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7F70", Offset = "0x2CE6F70", VA = "0x182CE7F70", Slot = "8")]
	public override void PKLFPAMOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x651170", Offset = "0x650170", VA = "0x180651170", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D05050", Offset = "0x2D04050", VA = "0x182D05050")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EntityQuery PLNKAEGANDH
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x11927E0", Offset = "0x11917E0", VA = "0x1811927E0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public EntityQuery PNJNHEDAJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1285B70", Offset = "0x1284B70", VA = "0x181285B70")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EntityQuery NBIGIMGLGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2D04BB0", Offset = "0x2D03BB0", VA = "0x182D04BB0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int OJEAMPGFOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2D05030", Offset = "0x2D04030", VA = "0x182D05030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int IECKLHINPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2D049B0", Offset = "0x2D039B0", VA = "0x182D049B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int LPAMKIILJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2D04F60", Offset = "0x2D03F60", VA = "0x182D04F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "4")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x2D051E0", Offset = "0x2D041E0", VA = "0x182D051E0", Slot = "5")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x2D049D0", Offset = "0x2D039D0", VA = "0x182D049D0", Slot = "6")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x2D05140", Offset = "0x2D04140", VA = "0x182D05140")]
	public HJHOBDHMCLM KOFAJPLFIFK()
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x2D04C30", Offset = "0x2D03C30", VA = "0x182D04C30")]
	public HJHOBDHMCLM BCPPGGPOPAJ()
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2D04D20", Offset = "0x2D03D20", VA = "0x182D04D20")]
	public HJHOBDHMCLM DFDAOLHFHCB()
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x2D04DC0", Offset = "0x2D03DC0", VA = "0x182D04DC0")]
	public DMDFKHMLDPI DFEMBKDBHPB(IOFHLMDPEAL PFLOECMCNHK)
	{
		return default(DMDFKHMLDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x2D04E70", Offset = "0x2D03E70", VA = "0x182D04E70")]
	public DMDFKHMLDPI DFEMBKDBHPB(Entity GDNDJKDEKFN)
	{
		return default(DMDFKHMLDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x2D04F80", Offset = "0x2D03F80", VA = "0x182D04F80")]
	public IOFCPOJDKFL FGGMDEJJMHP(Entity GDNDJKDEKFN)
	{
		return default(IOFCPOJDKFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2D04F20", Offset = "0x2D03F20", VA = "0x182D04F20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x2D050A0", Offset = "0x2D040A0", VA = "0x182D050A0")]
	private HJHOBDHMCLM ICJLAABGPAI(EntityQuery PMKDKHNEPAL)
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2D05260", Offset = "0x2D04260", VA = "0x182D05260")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CEB9B0", Offset = "0x2CEA9B0", VA = "0x182CEB9B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private EntityManager FHACAKFHJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC040", Offset = "0x2CEB040", VA = "0x182CEC040")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int OJEAMPGFOKC
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2CEBEA0", Offset = "0x2CEAEA0", VA = "0x182CEBEA0", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int IECKLHINPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB290", Offset = "0x2CEA290", VA = "0x182CEB290", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int LPAMKIILJII
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2CEBCC0", Offset = "0x2CEACC0", VA = "0x182CEBCC0", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int HDCINPLPMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC150", Offset = "0x2CEB150", VA = "0x182CEC150", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int OMMFOKCAHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2CECC40", Offset = "0x2CEBC40", VA = "0x182CECC40", Slot = "44")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<IOFHLMDPEAL, IOFCPOJDKFL> BMJEHKPAGKE
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2CEBE00", Offset = "0x2CEAE00", VA = "0x182CEBE00", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC210", Offset = "0x2CEB210", VA = "0x182CEC210", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<IOFHLMDPEAL> OCJPKBABAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB700", Offset = "0x2CEA700", VA = "0x182CEB700", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2CEC090", Offset = "0x2CEB090", VA = "0x182CEC090", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC4B0", Offset = "0x2CEB4B0", VA = "0x182CEC4B0", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB7A0", Offset = "0x2CEA7A0", VA = "0x182CEB7A0")]
	private void DDFDEJJOEJJ(Entity GDNDJKDEKFN, IOFCPOJDKFL OHBBEKBPFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB2C0", Offset = "0x2CEA2C0", VA = "0x182CEB2C0")]
	private void ADDIGKMJMEB(Entity GDNDJKDEKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC1F0", Offset = "0x2CEB1F0", VA = "0x182CEC1F0")]
	internal IOFHLMDPEAL JDKLAIGHECL(Entity GDNDJKDEKFN)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x2CECC60", Offset = "0x2CEBC60", VA = "0x182CECC60", Slot = "36")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	private void JAJBEFAJIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBA00", Offset = "0x2CEAA00", VA = "0x182CEBA00", Slot = "38")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC400", Offset = "0x2CEB400", VA = "0x182CEC400", Slot = "11")]
	public HJHOBDHMCLM KOFAJPLFIFK()
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB4F0", Offset = "0x2CEA4F0", VA = "0x182CEB4F0", Slot = "41")]
	public HJHOBDHMCLM BCPPGGPOPAJ()
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB840", Offset = "0x2CEA840", VA = "0x182CEB840", Slot = "42")]
	public HJHOBDHMCLM DFDAOLHFHCB()
	{
		return default(HJHOBDHMCLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB8F0", Offset = "0x2CEA8F0", VA = "0x182CEB8F0", Slot = "12")]
	public DMDFKHMLDPI DFEMBKDBHPB(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(DMDFKHMLDPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBD10", Offset = "0x2CEAD10", VA = "0x182CEBD10", Slot = "13")]
	public IOFCPOJDKFL FGGMDEJJMHP(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(IOFCPOJDKFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBD50", Offset = "0x2CEAD50", VA = "0x182CEBD50", Slot = "35")]
	public bool FKKMCEBMOMF(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB4A0", Offset = "0x2CEA4A0", VA = "0x182CEB4A0", Slot = "31")]
	public void BCKCNDMGJOA(IOFHLMDPEAL CPBDAEHELGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBF80", Offset = "0x2CEAF80", VA = "0x182CEBF80", Slot = "32")]
	public void HCHHHNHJCJG(IOFHLMDPEAL CPBDAEHELGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBDD0", Offset = "0x2CEADD0", VA = "0x182CEBDD0", Slot = "33")]
	public void FODPFOJIHMB(IOFHLMDPEAL CPBDAEHELGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBC90", Offset = "0x2CEAC90", VA = "0x182CEBC90", Slot = "37")]
	public void EHGGNHACJJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC2B0", Offset = "0x2CEB2B0", VA = "0x182CEC2B0", Slot = "25")]
	public CMIMIKMOPKA KELGJPAMBIF(IOFCPOJDKFL OHBBEKBPFPH)
	{
		return default(CMIMIKMOPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC740", Offset = "0x2CEB740", VA = "0x182CEC740", Slot = "26")]
	public CMIMIKMOPKA LMGGBKFFDDM(IOFCPOJDKFL OHBBEKBPFPH)
	{
		return default(CMIMIKMOPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC330", Offset = "0x2CEB330", VA = "0x182CEC330", Slot = "27")]
	public CMIMIKMOPKA KKBHPDPGGIO(DDAOHKAFOIC LNNGKIMHKAI, IOFCPOJDKFL OHBBEKBPFPH)
	{
		return default(CMIMIKMOPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB640", Offset = "0x2CEA640", VA = "0x182CEB640", Slot = "28")]
	public LLLDPGKHFIG BNLAGHNGNJO()
	{
		return default(LLLDPGKHFIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB350", Offset = "0x2CEA350", VA = "0x182CEB350", Slot = "43")]
	public IMHFCEALJNE AHPAEJDNMCD(BNFPHFLJIBP BCFKLEGAMEO)
	{
		return default(IMHFCEALJNE);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB3F0", Offset = "0x2CEA3F0", VA = "0x182CEB3F0", Slot = "29")]
	public JKJOICKOFGD APJGKMKJAME()
	{
		return default(JKJOICKOFGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBED0", Offset = "0x2CEAED0", VA = "0x182CEBED0", Slot = "30")]
	public KLKDNACKCDK HACNOOOPBHD(KOILODOMKMM BCFKLEGAMEO)
	{
		return default(KLKDNACKCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC130", Offset = "0x2CEB130", VA = "0x182CEC130", Slot = "15")]
	public void IIGIGLNPDMN(DDAOHKAFOIC LNNGKIMHKAI, GHMJIBJLDNA OMJIFKPFMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x2CECAF0", Offset = "0x2CEBAF0", VA = "0x182CECAF0", Slot = "16")]
	public CMIMIKMOPKA MPHHGOHAHFD(IOFHLMDPEAL CPBDAEHELGD, [Optional] object FDKCIGPLPAB)
	{
		return default(CMIMIKMOPKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC7E0", Offset = "0x2CEB7E0", VA = "0x182CEC7E0", Slot = "17")]
	public bool LPOPHPNOAOD(IOFHLMDPEAL CPBDAEHELGD, out GHMJIBJLDNA BBELMPNHPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x2CECAA0", Offset = "0x2CEBAA0", VA = "0x182CECAA0", Slot = "45")]
	public Transform MHFIGNMDDFK(IOFHLMDPEAL CPBDAEHELGD, [Optional] object FDKCIGPLPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBD80", Offset = "0x2CEAD80", VA = "0x182CEBD80", Slot = "19")]
	public bool FLLDEIOLFNK(IOFHLMDPEAL CPBDAEHELGD, out Transform JDMGKLHBDHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB250", Offset = "0x2CEA250", VA = "0x182CEB250", Slot = "20")]
	public bool AADNEELLNGM(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBFD0", Offset = "0x2CEAFD0", VA = "0x182CEBFD0")]
	public bool HEOPAOOCMKB(GHMJIBJLDNA CCIMHDCKHOF, [Optional] object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBFF0", Offset = "0x2CEAFF0", VA = "0x182CEBFF0", Slot = "46")]
	public bool HEOPAOOCMKB(IOFHLMDPEAL CPBDAEHELGD, [Optional] object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC7C0", Offset = "0x2CEB7C0", VA = "0x182CEC7C0", Slot = "47")]
	public void LNFEFDNFIKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC830", Offset = "0x2CEB830", VA = "0x182CEC830", Slot = "18")]
	public void MCDEMNHEAGJ(GHMJIBJLDNA ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB600", Offset = "0x2CEA600", VA = "0x182CEB600", Slot = "48")]
	public void BGLGHHGNAFH(IOFHLMDPEAL CPBDAEHELGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x2CEBCF0", Offset = "0x2CEACF0", VA = "0x182CEBCF0", Slot = "21")]
	public void EPHNJFGJMIL(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x2CECDF0", Offset = "0x2CEBDF0", VA = "0x182CECDF0", Slot = "22")]
	public bool OLMBONIFOFC(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB6E0", Offset = "0x2CEA6E0", VA = "0x182CEB6E0", Slot = "49")]
	public bool DAHIJCGCDME(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC020", Offset = "0x2CEB020", VA = "0x182CEC020", Slot = "50")]
	public bool HJMDCIFEJON(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC170", Offset = "0x2CEB170", VA = "0x182CEC170", Slot = "34")]
	public NativeArray<(IOFHLMDPEAL, IOFHLMDPEAL)> JAAHPLBFDOD(NativeArray<IOFHLMDPEAL> BCIIMKPOHKF, Allocator EGJIMBMGFGA)
	{
		return default(NativeArray<(IOFHLMDPEAL, IOFHLMDPEAL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x2CEC1C0", Offset = "0x2CEB1C0", VA = "0x182CEC1C0", Slot = "24")]
	public DDAOHKAFOIC JCBOEKFMENI(IOFHLMDPEAL CPBDAEHELGD)
	{
		return default(DDAOHKAFOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x2CECC00", Offset = "0x2CEBC00", VA = "0x182CECC00", Slot = "23")]
	public IOFHLMDPEAL NDFJMIJLHMK(DDAOHKAFOIC LNNGKIMHKAI)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D01EA0", Offset = "0x2D00EA0", VA = "0x182D01EA0", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2D01DA0", Offset = "0x2D00DA0", VA = "0x182D01DA0")]
	public NativeArray<(IOFHLMDPEAL, IOFHLMDPEAL)> JAAHPLBFDOD(NativeArray<IOFHLMDPEAL> BCIIMKPOHKF, Allocator EGJIMBMGFGA)
	{
		return default(NativeArray<(IOFHLMDPEAL, IOFHLMDPEAL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x2D01BC0", Offset = "0x2D00BC0", VA = "0x182D01BC0")]
	private void IFMNFJAFHBN(NativeMultiHashMap<int, (IOFHLMDPEAL src, IOFHLMDPEAL dst)> HIKJGAOGGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x2D01FE0", Offset = "0x2D00FE0", VA = "0x182D01FE0")]
	private void NILFCMLJKCD(NativeMultiHashMap<int, (IOFHLMDPEAL src, IOFHLMDPEAL dst)> HIKJGAOGGDB, int OHBBEKBPFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x2D01A30", Offset = "0x2D00A30", VA = "0x182D01A30")]
	private void BCBMGHHGHJH(NativeMultiHashMap<int, (IOFHLMDPEAL src, IOFHLMDPEAL dst)> HIKJGAOGGDB, int OHBBEKBPFPH, CMKIKNDBPFM IEBMFIFBGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x2D023D0", Offset = "0x2D013D0", VA = "0x182D023D0")]
	private NativeMultiHashMap<int, (IOFHLMDPEAL, IOFHLMDPEAL)> NJGFOIMANGO(Allocator EGJIMBMGFGA, NativeArray<IOFHLMDPEAL> BCIIMKPOHKF, out NativeArray<(IOFHLMDPEAL src, IOFHLMDPEAL dst)> CMHOMDKDOPP)
	{
		return default(NativeMultiHashMap<int, (IOFHLMDPEAL, IOFHLMDPEAL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x29C1ED0", Offset = "0x29C0ED0", VA = "0x1829C1ED0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x29C1960", Offset = "0x29C0960", VA = "0x1829C1960", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x29C1DB0", Offset = "0x29C0DB0", VA = "0x1829C1DB0", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x29C16C0", Offset = "0x29C06C0", VA = "0x1829C16C0", Slot = "5")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x29C1A00", Offset = "0x29C0A00", VA = "0x1829C1A00", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x29C1F70", Offset = "0x29C0F70", VA = "0x1829C1F70", Slot = "8")]
		public void OAFGFLKGBMJ(IOFHLMDPEAL CPBDAEHELGD, Vector3 FBDEMBLCHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x29C1B60", Offset = "0x29C0B60", VA = "0x1829C1B60", Slot = "9")]
		public bool EAAIGDKACEP(IOFHLMDPEAL CPBDAEHELGD, out Collider DMJMICMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x29C1CF0", Offset = "0x29C0CF0", VA = "0x1829C1CF0")]
		private void IEEKKOCFGFN(Entity GDNDJKDEKFN, FHCGLCCCIJI LKIMNIMPHKB, IKKMGBAJNEB OHJKCCOELFF, IKKMGBAJNEB DIBLIDDDAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x29C1C30", Offset = "0x29C0C30", VA = "0x1829C1C30", Slot = "10")]
		public void IBBMCCBJKJF(IOFHLMDPEAL CPBDAEHELGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public BJEGIJOLNFA GGDMIIGDNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public IEnumerable<BJEGIJOLNFA> JNMNHLJJKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public IEnumerable<JODOCAEGKMF> HCGNKDEPDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2D04890", Offset = "0x2D03890", VA = "0x182D04890")]
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
			[Cpp2IlInjected.Address(RVA = "0x66B040", Offset = "0x66A040", VA = "0x18066B040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x29BC2F0", Offset = "0x29BB2F0", VA = "0x1829BC2F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xAA5B20", Offset = "0xAA4B20", VA = "0x180AA5B20")]
		[DebuggerHidden]
		public KNCIFABHJNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x29BBFE0", Offset = "0x29BAFE0", VA = "0x1829BBFE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x29BC2B0", Offset = "0x29BB2B0", VA = "0x1829BC2B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x29BC210", Offset = "0x29BB210", VA = "0x1829BC210", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x29BC210", Offset = "0x29BB210", VA = "0x1829BC210", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CEE680", Offset = "0x2CED680", VA = "0x182CEE680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public List<JODOCAEGKMF> MPAAJAOFPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2CEEC30", Offset = "0x2CEDC30", VA = "0x182CEEC30", Slot = "8")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE270", Offset = "0x2CED270", VA = "0x182CEE270", Slot = "9")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE460", Offset = "0x2CED460", VA = "0x182CEE460", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE3D0", Offset = "0x2CED3D0", VA = "0x182CEE3D0", Slot = "6")]
	public bool DKJJILINNLA(JODOCAEGKMF MIGODNJAHNA, out BJEGIJOLNFA LGCEOGAHLEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE8A0", Offset = "0x2CED8A0", VA = "0x182CEE8A0")]
	private void KLGBCMCAJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2CEF050", Offset = "0x2CEE050", VA = "0x182CEF050")]
	private void PGLPODHKANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE370", Offset = "0x2CED370", VA = "0x182CEE370")]
	private HAJFHAAANFM DIKNOLKKNDL(string ACADMDFIHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE680", Offset = "0x2CED680", VA = "0x182CEE680")]
	private HAJFHAAANFM JONPGFCHCFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x2CEEDE0", Offset = "0x2CEDDE0", VA = "0x182CEEDE0")]
	private HAJFHAAANFM PDKPJHPBCDB(string ACADMDFIHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE4B0", Offset = "0x2CED4B0", VA = "0x182CEE4B0")]
	private HAJFHAAANFM GLCOMHANNGK(string OIPMKBNDJIF, string FDKCIGPLPAB, [Optional] HAJFHAAANFM OIENDNJIDAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2CEED70", Offset = "0x2CEDD70", VA = "0x182CEED70")]
	[IteratorStateMachine(typeof(KNCIFABHJNG))]
	private IEnumerable<(string, string)> NPFDGOLOOCL(string ACADMDFIHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE290", Offset = "0x2CED290", VA = "0x182CEE290")]
	private bool CAEPFOFNNBB(JODOCAEGKMF MIGODNJAHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE7C0", Offset = "0x2CED7C0", VA = "0x182CEE7C0")]
	private HOOKOBANMNL IHCLHJMPHAO(JODOCAEGKMF MIGODNJAHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE770", Offset = "0x2CED770", VA = "0x182CEE770")]
	private HOOKOBANMNL IEDNCOKCHLB(JODOCAEGKMF MIGODNJAHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE6E0", Offset = "0x2CED6E0", VA = "0x182CEE6E0")]
	private HOOKOBANMNL IADMHKLHEMP(JODOCAEGKMF MIGODNJAHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x2651E90", Offset = "0x2650E90", VA = "0x182651E90")]
	private T NLKBBGECHFF<T>(JODOCAEGKMF MIGODNJAHNA) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2CEEC90", Offset = "0x2CEDC90", VA = "0x182CEEC90")]
	private FieldInfo LOPLGCKHOME(JODOCAEGKMF MIGODNJAHNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x2CEF1F0", Offset = "0x2CEE1F0", VA = "0x182CEF1F0")]
	public CBAOCDPCLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x2CEE2E0", Offset = "0x2CED2E0", VA = "0x182CEE2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CED400", Offset = "0x2CEC400", VA = "0x182CED400", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public MIEGLNNJAGB ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2CED700", Offset = "0x2CEC700", VA = "0x182CED700", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public MIEGLNNJAGB ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2CED700", Offset = "0x2CEC700", VA = "0x182CED700", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x2CED500", Offset = "0x2CEC500", VA = "0x182CED500", Slot = "11")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2CED680", Offset = "0x2CEC680", VA = "0x182CED680", Slot = "12")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "13")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x2CED100", Offset = "0x2CEC100", VA = "0x182CED100")]
	private void DMJFBNHIMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x14EE290", Offset = "0x14ED290", VA = "0x1814EE290")]
	private string BDCNNOMALGA(string FOGNBJMCDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x2CED420", Offset = "0x2CEC420", VA = "0x182CED420", Slot = "7")]
	public MIEGLNNJAGB FJHOPHENDCF(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2CED720", Offset = "0x2CEC720", VA = "0x182CED720")]
	private bool OJLOJIMIFMD(Type BJIDGGBJEAN, string FOGNBJMCDMG, out MIEGLNNJAGB PMOKKAEPEEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2CED550", Offset = "0x2CEC550", VA = "0x182CED550", Slot = "8")]
	public FHCGLCCCIJI GPBGCLPEPLP(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return default(FHCGLCCCIJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2CED660", Offset = "0x2CEC660", VA = "0x182CED660", Slot = "9")]
	public IEnumerator<MIEGLNNJAGB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2CED660", Offset = "0x2CEC660", VA = "0x182CED660", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2CED9D0", Offset = "0x2CEC9D0", VA = "0x182CED9D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C79540", Offset = "0x2C78540", VA = "0x182C79540", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2C79200", Offset = "0x2C78200", VA = "0x182C79200", Slot = "6")]
	public bool EKHJNKCFCHL(FHCGLCCCIJI DGFBLJMJMFI, out int FBPAKFCOLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2C79270", Offset = "0x2C78270", VA = "0x182C79270", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C791F0", Offset = "0x2C781F0", VA = "0x182C791F0", Slot = "5")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C792D0", Offset = "0x2C782D0", VA = "0x182C792D0")]
	private void LNPEONEJBDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C795A0", Offset = "0x2C785A0", VA = "0x182C795A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CE7680", Offset = "0x2CE6680", VA = "0x182CE7680", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public KONIEIPNKKM ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7970", Offset = "0x2CE6970", VA = "0x182CE7970", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public KONIEIPNKKM ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x2CE7970", Offset = "0x2CE6970", VA = "0x182CE7970", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "10")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2CE79B0", Offset = "0x2CE69B0", VA = "0x182CE79B0", Slot = "11")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "12")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7690", Offset = "0x2CE6690", VA = "0x182CE7690", Slot = "6")]
	public KONIEIPNKKM FJHOPHENDCF(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x2CE77C0", Offset = "0x2CE67C0", VA = "0x182CE77C0", Slot = "7")]
	public FHCGLCCCIJI GPBGCLPEPLP(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return default(FHCGLCCCIJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7890", Offset = "0x2CE6890", VA = "0x182CE7890", Slot = "8")]
	public IEnumerator<KONIEIPNKKM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7C70", Offset = "0x2CE6C70", VA = "0x182CE7C70", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x21AE1C0", Offset = "0x21AD1C0", VA = "0x1821AE1C0", Slot = "13")]
	public void CPNDBBPBHFN<TKey, T>(global::NJDICNIFPMB<TKey, T> MIGODNJAHNA, [Optional] object IGBOEABBEHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7540", Offset = "0x2CE6540", VA = "0x182CE7540", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public ACJIDPEGICN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7970", Offset = "0x2CE6970", VA = "0x182CE7970")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BF860", Offset = "0x29BE860", VA = "0x1829BF860", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public JODOCAEGKMF ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x29BFC90", Offset = "0x29BEC90", VA = "0x1829BFC90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public JODOCAEGKMF ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x29BFC90", Offset = "0x29BEC90", VA = "0x1829BFC90", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "9")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x29BFCA0", Offset = "0x29BECA0", VA = "0x1829BFCA0", Slot = "10")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x29BF560", Offset = "0x29BE560", VA = "0x1829BF560", Slot = "11")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x29BFBB0", Offset = "0x29BEBB0", VA = "0x1829BFBB0")]
	private JODOCAEGKMF JJJNFELBPCE(int MMABPPDCBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x29BF8B0", Offset = "0x29BE8B0", VA = "0x1829BF8B0", Slot = "6")]
	public JODOCAEGKMF FJHOPHENDCF(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x29BF9D0", Offset = "0x29BE9D0", VA = "0x1829BF9D0", Slot = "15")]
	public FHCGLCCCIJI GPBGCLPEPLP(FAMLDGNAFHF BAOKNJFCNMB)
	{
		return default(FHCGLCCCIJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x29BFAA0", Offset = "0x29BEAA0", VA = "0x1829BFAA0", Slot = "7")]
	public IEnumerator<JODOCAEGKMF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x29BFAA0", Offset = "0x29BEAA0", VA = "0x1829BFAA0", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x2B0BEB0", Offset = "0x2B0AEB0", VA = "0x182B0BEB0", Slot = "12")]
	public void CPNDBBPBHFN<TKey, T>(global::NJDICNIFPMB<TKey, T> MIGODNJAHNA, [Optional] object IGBOEABBEHO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x29BF7C0", Offset = "0x29BE7C0", VA = "0x1829BF7C0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public PLOAMNEAJHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x29BFC90", Offset = "0x29BEC90", VA = "0x1829BFC90")]
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
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x651590", Offset = "0x650590", VA = "0x180651590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C782A0", Offset = "0x2C772A0", VA = "0x182C782A0", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C78010", Offset = "0x2C77010", VA = "0x182C78010")]
	private void DPLCIFIHHMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8CB0", Offset = "0x1EB7CB0", VA = "0x181EB8CB0")]
	public T DDBNBLGNDBJ<T>() where T : CMKIKNDBPFM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x2C77F40", Offset = "0x2C76F40", VA = "0x182C77F40")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C781D0", Offset = "0x2C771D0", VA = "0x182C781D0")]
	public JODOCAEGKMF KHCHCBBIMIE(FAMLDGNAFHF FOGNBJMCDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1EB8CE0", Offset = "0x1EB7CE0", VA = "0x181EB8CE0")]
	public global::FNDBOCNPCDA<T> KHCHCBBIMIE<T>(FAMLDGNAFHF FOGNBJMCDMG) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x2C78100", Offset = "0x2C77100", VA = "0x182C78100")]
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
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public KLMCINPKLDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class MKNOEOEPPNO
{
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2C2AAD0", Offset = "0x2C29AD0", VA = "0x182C2AAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E90", Offset = "0x8D5E90", VA = "0x1808D6E90")]
		[DebuggerHidden]
		public PKIDHNNKCCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x29BE430", Offset = "0x29BD430", VA = "0x1829BE430", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x29BE080", Offset = "0x29BD080", VA = "0x1829BE080", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x29BE4B0", Offset = "0x29BD4B0", VA = "0x1829BE4B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x29BE3F0", Offset = "0x29BD3F0", VA = "0x1829BE3F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x29BE360", Offset = "0x29BD360", VA = "0x1829BE360", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x29BE360", Offset = "0x29BD360", VA = "0x1829BE360", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CFB2A0", Offset = "0x2CFA2A0", VA = "0x182CFB2A0", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2CFA3F0", Offset = "0x2CF93F0", VA = "0x182CFA3F0", Slot = "5")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2CFA620", Offset = "0x2CF9620", VA = "0x182CFA620", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2CFB290", Offset = "0x2CFA290", VA = "0x182CFB290")]
	private void KMOCPNGCAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2CFB3A0", Offset = "0x2CFA3A0", VA = "0x182CFB3A0")]
	internal void MJMHEABOKEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2CFB0B0", Offset = "0x2CFA0B0", VA = "0x182CFB0B0")]
	private void INGBIEMDCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2CFA9A0", Offset = "0x2CF99A0", VA = "0x182CFA9A0")]
	private void ELPBPPCOECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2CFAF20", Offset = "0x2CF9F20", VA = "0x182CFAF20")]
	[IteratorStateMachine(typeof(PKIDHNNKCCO))]
	private IEnumerable<RRCustomPropTag> HOAOELEHKHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2CFAAA0", Offset = "0x2CF9AA0", VA = "0x182CFAAA0")]
	private void GKFLJKECNEI(IOFHLMDPEAL CPBDAEHELGD, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2CFAF70", Offset = "0x2CF9F70", VA = "0x182CFAF70")]
	private void IIGIGLNPDMN(SerializableGuid PMPGCMIMMLH, GameObject HBGIADIFHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2CFB7D0", Offset = "0x2CFA7D0", VA = "0x182CFB7D0")]
	private void MMEDOEKINLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2CFA7C0", Offset = "0x2CF97C0", VA = "0x182CFA7C0")]
	private bool EAPJFFNLMAI(EIGCJOLCLNC OGJJHKMINGI, Transform OJKLIAPCMPJ, out GameObject NIDJHACIMJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2CFBB60", Offset = "0x2CFAB60", VA = "0x182CFBB60")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2CFBBB0", Offset = "0x2CFABB0", VA = "0x182CFBBB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x66B040", Offset = "0x66A040", VA = "0x18066B040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x29C62F0", Offset = "0x29C52F0", VA = "0x1829C62F0")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xF99740", Offset = "0xF98740", VA = "0x180F99740")]
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
		[Cpp2IlInjected.Address(RVA = "0x66B040", Offset = "0x66A040", VA = "0x18066B040", Slot = "7")]
		get
		{
			return default(IOFHLMDPEAL);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x2C808F0", Offset = "0x2C7F8F0", VA = "0x182C808F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CMIMIKMOPKA KFEIBKFPKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x66B040", Offset = "0x66A040", VA = "0x18066B040", Slot = "9")]
		get
		{
			return default(CMIMIKMOPKA);
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x2C808F0", Offset = "0x2C7F8F0", VA = "0x182C808F0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event LJMIAPEFJJM HHGCPOLKOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2C80F30", Offset = "0x2C7FF30", VA = "0x182C80F30", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2C81490", Offset = "0x2C80490", VA = "0x182C81490", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2C81300", Offset = "0x2C80300", VA = "0x182C81300", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2C80AE0", Offset = "0x2C7FAE0", VA = "0x182C80AE0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2C80C30", Offset = "0x2C7FC30", VA = "0x182C80C30", Slot = "11")]
	public IOFHLMDPEAL EGFDMBBCIHG(IOFHLMDPEAL IFLKAOGBEDH, IOFHLMDPEAL KNPAGIAAIJP)
	{
		return default(IOFHLMDPEAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2C810F0", Offset = "0x2C800F0", VA = "0x182C810F0", Slot = "12")]
	public bool KDGKGEDFGPG(IOFHLMDPEAL IFLKAOGBEDH, IOFHLMDPEAL KNPAGIAAIJP, out IOFHLMDPEAL FNFLMMJIIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2C811F0", Offset = "0x2C801F0", VA = "0x182C811F0", Slot = "13")]
	public void LDBGIAJMDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2C80F10", Offset = "0x2C7FF10", VA = "0x182C80F10", Slot = "14")]
	public void FJICHCIPAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2C80FD0", Offset = "0x2C7FFD0", VA = "0x182C80FD0", Slot = "15")]
	public bool JODJKPOENHL(IOFHLMDPEAL MJPNNJLLLLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2C80D40", Offset = "0x2C7FD40", VA = "0x182C80D40")]
	private bool EOADJFPLNMF(IOFHLMDPEAL AHEEKHBLLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x2C80910", Offset = "0x2C7F910", VA = "0x182C80910")]
	private void CFDAMBHCCGP(CMIMIKMOPKA ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CECE10", Offset = "0x2CEBE10", VA = "0x182CECE10", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2CECE90", Offset = "0x2CEBE90", VA = "0x182CECE90", Slot = "5")]
	public void ODKOKFFHAPD(IOFHLMDPEAL PFLOECMCNHK, bool CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2641B10", Offset = "0x2640B10", VA = "0x182641B10")]
	private void DIMECELKFHA<T>(IOFHLMDPEAL PFLOECMCNHK, bool CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x29C7770", Offset = "0x29C6770", VA = "0x1829C7770", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x29C77F0", Offset = "0x29C67F0", VA = "0x1829C77F0", Slot = "5")]
		public void PDEJDPKFFGF(IOFHLMDPEAL PFLOECMCNHK, bool CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x29C7700", Offset = "0x29C6700", VA = "0x1829C7700", Slot = "6")]
		public void BMHPHDCDGBJ(IOFHLMDPEAL PFLOECMCNHK, bool CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x2641B10", Offset = "0x2640B10", VA = "0x182641B10")]
		private void DIMECELKFHA<T>(IOFHLMDPEAL PFLOECMCNHK, bool CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x64E250", Offset = "0x64D250", VA = "0x18064E250", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x2CFA390", Offset = "0x2CF9390", VA = "0x182CFA390", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<bool> AKPMDOPGMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x2CFA2F0", Offset = "0x2CF92F0", VA = "0x182CFA2F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x2CFA250", Offset = "0x2CF9250", VA = "0x182CFA250", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED2D30", Offset = "0x4ED1D30", VA = "0x184ED2D30")]
			public static JPJPLDKCMOI MADPLDOCFBN()
			{
				return default(JPJPLDKCMOI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
			public HMKFOAIHMEI(string NJKKDANCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
			public void AECOPHMDBCG(EntityManager NJKKDANCIMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x29C7F70", Offset = "0x29C6F70", VA = "0x1829C7F70", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x29C8EF0", Offset = "0x29C7EF0", VA = "0x1829C8EF0", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action IHIGOIDMCAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x29C82B0", Offset = "0x29C72B0", VA = "0x1829C82B0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x29C8C60", Offset = "0x29C7C60", VA = "0x1829C8C60", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<PIALCHFKIHC> AEODNBKHDPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x29C8580", Offset = "0x29C7580", VA = "0x1829C8580", Slot = "21")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x29C9750", Offset = "0x29C8750", VA = "0x1829C9750", Slot = "22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action BEHBHCDLJJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x29C8820", Offset = "0x29C7820", VA = "0x1829C8820", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x29C97F0", Offset = "0x29C87F0", VA = "0x1829C97F0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action DOGBJPIDLAF
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x29CB0E0", Offset = "0x29CA0E0", VA = "0x1829CB0E0", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x29CAE70", Offset = "0x29C9E70", VA = "0x1829CAE70", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<PIALCHFKIHC> NFMELJBFMLL
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x29CA100", Offset = "0x29C9100", VA = "0x1829CA100", Slot = "23")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x29C88C0", Offset = "0x29C78C0", VA = "0x1829C88C0", Slot = "24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x29CA1A0", Offset = "0x29C91A0", VA = "0x1829CA1A0", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x29CAB40", Offset = "0x29C9B40", VA = "0x1829CAB40", Slot = "11")]
		public void OEEGKBNAKFI(bool CNKCPFJNMAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x29C9E70", Offset = "0x29C8E70", VA = "0x1829C9E70", Slot = "13")]
		public ByteString HHDOHEHKDKI(out IDisposable LLKGMADOFJC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x29C9CA0", Offset = "0x29C8CA0", VA = "0x1829C9CA0", Slot = "12")]
		public ByteString HHDOHEHKDKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x29C8270", Offset = "0x29C7270", VA = "0x1829C8270", Slot = "16")]
		public bool ADHMOLAJGDE(ByteString EGFFIMBAAAB, ICHAMCHHHDE ALKHBOMOJMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x29C9F50", Offset = "0x29C8F50", VA = "0x1829C9F50", Slot = "17")]
		public bool KIIHOPNIAKF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x29C8C50", Offset = "0x29C7C50", VA = "0x1829C8C50", Slot = "14")]
		public void DALNGINDNDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x29C9580", Offset = "0x29C8580", VA = "0x1829C9580", Slot = "27")]
		public void FBBPBCOJECK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x29CACC0", Offset = "0x29C9CC0", VA = "0x1829CACC0", Slot = "15")]
		public void OEHEOOPENCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x29C8F00", Offset = "0x29C7F00", VA = "0x1829C8F00", Slot = "18")]
		public bool DMGEALDACPB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x29C9890", Offset = "0x29C8890", VA = "0x1829C9890", Slot = "19")]
		public bool GLBNGIHMHOC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x29C9B80", Offset = "0x29C8B80", VA = "0x1829C9B80")]
		private void GOBDAOEDHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x163E5C0", Offset = "0x163D5C0", VA = "0x18163E5C0")]
		private void BCJBLHKJDKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x29C83B0", Offset = "0x29C73B0", VA = "0x1829C83B0")]
		private void BBGFOCNJJEC(JHMAKDMCKJI JKEJIABAEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x29C8350", Offset = "0x29C7350", VA = "0x1829C8350")]
		private ByteString APHHHCDKHOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x29CAA20", Offset = "0x29C9A20", VA = "0x1829CAA20")]
		private ByteString OALKKPPNNCG(ByteString AHJGIIFAPKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x29C84A0", Offset = "0x29C74A0", VA = "0x1829C84A0")]
		private bool BCMIMFLPNDP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x29CA650", Offset = "0x29C9650", VA = "0x1829CA650")]
		private void MLFHPHHNPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x29CA2A0", Offset = "0x29C92A0", VA = "0x1829CA2A0")]
		private void MHGLAJHJKJG(out ByteString AHJGIIFAPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x29C9220", Offset = "0x29C8220", VA = "0x1829C9220")]
		private bool EJGNOLABCJG(ByteString EGFFIMBAAAB, ICHAMCHHHDE ALKHBOMOJMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x29C7F80", Offset = "0x29C6F80", VA = "0x1829C7F80")]
		private bool ACGNONLGNKM(ByteString EGFFIMBAAAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x29C8D00", Offset = "0x29C7D00", VA = "0x1829C8D00")]
		private bool DKCGLJGACCB(NMJLMBINCKO.BKHMPJONLOA.HPJBMOAHNKK ELGPOOCMMCJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x29C8960", Offset = "0x29C7960", VA = "0x1829C8960")]
		private void CNJDKFOGBJA(PIALCHFKIHC JKEJIABAEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x29CB180", Offset = "0x29CA180", VA = "0x1829CB180")]
		private JHMAKDMCKJI PMMGHGIPEJH(EntityManager NLDNPCFEGJC, EntityManager KGCHJKNHGKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x29C8620", Offset = "0x29C7620", VA = "0x1829C8620")]
		private void BPFKLCCBBPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x29CAF10", Offset = "0x29C9F10", VA = "0x1829CAF10")]
		private void OJEEPLKEKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x29C9540", Offset = "0x29C8540", VA = "0x1829C9540")]
		private void EPPJHJEHHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x29CA050", Offset = "0x29C9050", VA = "0x1829CA050")]
		private NMJLMBINCKO.BKHMPJONLOA.HPJBMOAHNKK KOACOCBCFHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CEA0F0", Offset = "0x2CE90F0", VA = "0x182CEA0F0")]
	public GameObject FKEFGNCKDGA(KOILODOMKMM IBEHBIFEPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA1C0", Offset = "0x2CE91C0", VA = "0x182CEA1C0")]
	public BBBIOMKAODA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[OOAPDBLGMJF(typeof(JOFCFLECLCD), new string[] { })]
public class GMMFIAKJODM : JOFCFLECLCD
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2D02E80", Offset = "0x2D01E80", VA = "0x182D02E80", Slot = "5")]
	public void INGPAEKCCFB(object NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2D03040", Offset = "0x2D02040", VA = "0x182D03040", Slot = "6")]
	public void LPNJDPILCPB(object NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2D02F60", Offset = "0x2D01F60", VA = "0x182D02F60", Slot = "7")]
	public void LGKGPLEPENF(object NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2D02D70", Offset = "0x2D01D70", VA = "0x182D02D70", Slot = "4")]
	public IDisposable FPCBFCGBELH(object NJAIIGFCHNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D02C90", Offset = "0x2D01C90", VA = "0x182D02C90", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2D02BC0", Offset = "0x2D01BC0", VA = "0x182D02BC0", Slot = "6")]
	public void KIEPIGMLFGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2D028F0", Offset = "0x2D018F0", VA = "0x182D028F0", Slot = "5")]
	public void FDIPDDNBMGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2D02800", Offset = "0x2D01800", VA = "0x182D02800", Slot = "7")]
	public void BKLBJKMJJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2D029C0", Offset = "0x2D019C0", VA = "0x182D029C0", Slot = "8")]
	public void GFMHPOKBEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2D026B0", Offset = "0x2D016B0", VA = "0x182D026B0", Slot = "9")]
	public void AIKBBGGJOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2D02A90", Offset = "0x2D01A90", VA = "0x182D02A90", Slot = "10")]
	public void HLDDLOHHEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2D02B10", Offset = "0x2D01B10", VA = "0x182D02B10", Slot = "11")]
	public void IHHPHDNNDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x29CE9F0", Offset = "0x29CD9F0", VA = "0x1829CE9F0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		private BJBGOMFMFBL NPECBMJOKEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x29D11D0", Offset = "0x29D01D0", VA = "0x1829D11D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x29CF6A0", Offset = "0x29CE6A0", VA = "0x1829CF6A0", Slot = "33")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x29CD240", Offset = "0x29CC240", VA = "0x1829CD240", Slot = "34")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x29CDB30", Offset = "0x29CCB30", VA = "0x1829CDB30", Slot = "35")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x29CFCB0", Offset = "0x29CECB0", VA = "0x1829CFCB0", Slot = "36")]
		public bool MGLLJIPMKBF(Transform JDMGKLHBDHC, out IOFHLMDPEAL CPBDAEHELGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x29CEA40", Offset = "0x29CDA40", VA = "0x1829CEA40", Slot = "37")]
		public Transform IAHHILHKCHF(Entity GDNDJKDEKFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x29CE3E0", Offset = "0x29CD3E0", VA = "0x1829CE3E0", Slot = "31")]
		public bool FLLDEIOLFNK(Entity GDNDJKDEKFN, out Transform JDMGKLHBDHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x29CFF20", Offset = "0x29CEF20", VA = "0x1829CFF20")]
		private void MPLKCEGCBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x29D0E50", Offset = "0x29CFE50", VA = "0x1829D0E50", Slot = "30")]
		public void OICFMCMFOEC(Entity GDNDJKDEKFN, out Matrix4x4 CLLKBGMNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x29D0780", Offset = "0x29CF780", VA = "0x1829D0780", Slot = "4")]
		public void NOCKHCGGFDI(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x29CE720", Offset = "0x29CD720", VA = "0x1829CE720")]
		private void GIKOEHCBBCL(Entity GDNDJKDEKFN, Vector3 BIFOHEGELJH, Quaternion LLCDBICBDDO, Vector3 AOPAIJHBHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x29CDBD0", Offset = "0x29CCBD0", VA = "0x1829CDBD0")]
		private void ECGMBACNEBD(Entity GDNDJKDEKFN, Vector3 BIFOHEGELJH, Quaternion LLCDBICBDDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x29CD370", Offset = "0x29CC370", VA = "0x1829CD370", Slot = "28")]
		public void CBEKIJIOHEG(Entity GDNDJKDEKFN, out Matrix4x4 BBBIPBMOHOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x29CD380", Offset = "0x29CC380", VA = "0x1829CD380")]
		public void CBIIKOFOAIB(Entity GDNDJKDEKFN, in Matrix4x4 CLLKBGMNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x29D0C60", Offset = "0x29CFC60", VA = "0x1829D0C60")]
		private void OGJDDNNPHGI(Entity GDNDJKDEKFN, in Matrix4x4 BNJEBHAJKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x29D1690", Offset = "0x29D0690", VA = "0x1829D1690", Slot = "5")]
		public void PALBBHELGBL(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x29CEB00", Offset = "0x29CDB00", VA = "0x1829CEB00", Slot = "6")]
		public Vector3 IJCBPDLLPGF(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x29CF570", Offset = "0x29CE570", VA = "0x1829CF570", Slot = "7")]
		public void LEOBIFEABNN(Entity GDNDJKDEKFN, Quaternion CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x29CE000", Offset = "0x29CD000", VA = "0x1829CE000", Slot = "8")]
		public Quaternion FDEIOJHADMF(Entity GDNDJKDEKFN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x29D0FA0", Offset = "0x29CFFA0", VA = "0x1829D0FA0", Slot = "13")]
		public void OIFGLMLKFKL(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x29CF380", Offset = "0x29CE380", VA = "0x1829CF380", Slot = "12")]
		public Vector3 KJIEIDDLGNB(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x29CD730", Offset = "0x29CC730", VA = "0x1829CD730")]
		private void CKGIEJEDMKL(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x29CF2E0", Offset = "0x29CE2E0", VA = "0x1829CF2E0")]
		private Vector3 KFDGODINGOD(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x29CE680", Offset = "0x29CD680", VA = "0x1829CE680", Slot = "15")]
		public float GHIMLBGBFPH(Entity GDNDJKDEKFN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x29CF1C0", Offset = "0x29CE1C0", VA = "0x1829CF1C0", Slot = "14")]
		public void JICGEDOAIDK(Entity GDNDJKDEKFN, float CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x29CE120", Offset = "0x29CD120", VA = "0x1829CE120")]
		private float FDOOCBBAKEN(Entity GDNDJKDEKFN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x29CFE60", Offset = "0x29CEE60", VA = "0x1829CFE60")]
		private void MLMHDPPCALI(Entity GDNDJKDEKFN, float JBABODEHNLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x29CDF20", Offset = "0x29CCF20", VA = "0x1829CDF20", Slot = "17")]
		public Vector3 FAKAKFGMLLD(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x29CD7D0", Offset = "0x29CC7D0", VA = "0x1829CD7D0", Slot = "16")]
		public void DGMDJDECKBE(Entity GDNDJKDEKFN, Vector3 NKLDJCGKGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x29CE8C0", Offset = "0x29CD8C0", VA = "0x1829CE8C0")]
		private Vector3 GPDJIFMOHFK(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x29D17E0", Offset = "0x29D07E0", VA = "0x1829D17E0")]
		private void PKHNCJIEFIJ(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x29CF010", Offset = "0x29CE010", VA = "0x1829CF010")]
		[Conditional("DEBUG_BUILD")]
		private void JGMBEADKNAF(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x29CE210", Offset = "0x29CD210", VA = "0x1829CE210", Slot = "9")]
		public void FFKIICALAOK(Entity GDNDJKDEKFN, Vector3 LPADDFNBONE, Quaternion OIFAPGIKFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x29D0AE0", Offset = "0x29CFAE0", VA = "0x1829D0AE0", Slot = "10")]
		public void OEBBAGCPONH(Entity GDNDJKDEKFN, out Vector3 LPADDFNBONE, out Quaternion OIFAPGIKFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x29D10A0", Offset = "0x29D00A0", VA = "0x1829D10A0", Slot = "11")]
		public void OMLACCAEJFJ(Entity GDNDJKDEKFN, out Vector3 LPADDFNBONE, out Quaternion OIFAPGIKFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x29D02A0", Offset = "0x29CF2A0", VA = "0x1829D02A0", Slot = "18")]
		public void NJMMEEGMBKH(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x29CF490", Offset = "0x29CE490", VA = "0x1829CF490", Slot = "19")]
		public Vector3 KPAHPLCDFFM(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE30", Offset = "0x29CDE30", VA = "0x1829CEE30", Slot = "20")]
		public void JAICONLDEIK(Entity GDNDJKDEKFN, Quaternion CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x29CDD10", Offset = "0x29CCD10", VA = "0x1829CDD10", Slot = "21")]
		public Quaternion EDGMAEAKHGD(Entity GDNDJKDEKFN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x29CCDE0", Offset = "0x29CBDE0", VA = "0x1829CCDE0", Slot = "23")]
		public void ADIGMAAKNCM(Entity GDNDJKDEKFN, Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x29CDA40", Offset = "0x29CCA40", VA = "0x1829CDA40", Slot = "22")]
		public Vector3 DOJFBLMNKMN(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x29D0460", Offset = "0x29CF460", VA = "0x1829D0460", Slot = "24")]
		public void NNHDGPEOPNA(Entity GDNDJKDEKFN, float FIPBMGPFOAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x29CDE00", Offset = "0x29CCE00", VA = "0x1829CDE00", Slot = "25")]
		public float EFGGDDCNDON(Entity GDNDJKDEKFN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x29D1220", Offset = "0x29D0220", VA = "0x1829D1220", Slot = "26")]
		public void PAJENCKLLJO(Entity GDNDJKDEKFN, Vector3 EMHGCBMDABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x29CD900", Offset = "0x29CC900", VA = "0x1829CD900", Slot = "27")]
		public Vector3 DKPICMFFFDK(Entity GDNDJKDEKFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x29CF880", Offset = "0x29CE880", VA = "0x1829CF880", Slot = "32")]
		public void LJNDMBEEMDD(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x29CED70", Offset = "0x29CDD70", VA = "0x1829CED70")]
		private void IPJHGINJJJA(Entity GDNDJKDEKFN, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x29CEC40", Offset = "0x29CDC40", VA = "0x1829CEC40")]
		private void IPJHGINJJJA(Entity GDNDJKDEKFN, in Entity CKCPHJMEEKP, in Entity ILIAKNFOPLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x29D0A30", Offset = "0x29CFA30", VA = "0x1829D0A30")]
		private PCDMNOCOIGO OEBBAGCPONH(Entity GDNDJKDEKFN)
		{
			return default(PCDMNOCOIGO);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x29CF7A0", Offset = "0x29CE7A0", VA = "0x1829CF7A0")]
		private bool LJDKINEIEJG(Entity GDNDJKDEKFN, out Entity OJKLIAPCMPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x29CE4D0", Offset = "0x29CD4D0", VA = "0x1829CE4D0")]
		private void GALCINBLNEG(Entity GDNDJKDEKFN, out Matrix4x4 CLLKBGMNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x29CFF40", Offset = "0x29CEF40", VA = "0x1829CFF40")]
		public void NEDANDBJKCB(Entity GDNDJKDEKFN, out Matrix4x4 BNJEBHAJKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x29CF2D0", Offset = "0x29CE2D0", VA = "0x1829CF2D0", Slot = "29")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ED0F30", Offset = "0x4ECFF30", VA = "0x184ED0F30")]
		public GFCKMADGCLE(MIIBEBDJOEK OJKLIAPCMPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x4ED0F10", Offset = "0x4ECFF10", VA = "0x184ED0F10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x11070E0", Offset = "0x11060E0", VA = "0x1811070E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action PELKMEHKPJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BC60", Offset = "0x2C7AC60", VA = "0x182C7BC60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BB90", Offset = "0x2C7AB90", VA = "0x182C7BB90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BC30", Offset = "0x2C7AC30", VA = "0x182C7BC30")]
	public GFCKMADGCLE FOEEADKNKOH()
	{
		return default(GFCKMADGCLE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x1542DC0", Offset = "0x1541DC0", VA = "0x181542DC0")]
	public void PNODODGFGHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BD00", Offset = "0x2C7AD00", VA = "0x182C7BD00")]
	public void LNLDLKLBOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public CIFIFFHJLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF8E0", Offset = "0x4ECE8E0", VA = "0x184ECF8E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public CEOCCIOEHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF880", Offset = "0x4ECE880", VA = "0x184ECF880")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public BJBGOMFMFBL NPECBMJOKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2D04070", Offset = "0x2D03070", VA = "0x182D04070", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EntityManager FHACAKFHJON
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2D03960", Offset = "0x2D02960", VA = "0x182D03960", Slot = "9")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public OMBILBANOEN BKOIEKNNDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x68C1C0", Offset = "0x68B1C0", VA = "0x18068C1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action DONDFDGGIAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2D039B0", Offset = "0x2D029B0", VA = "0x182D039B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x2D03120", Offset = "0x2D02120", VA = "0x182D03120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D03740", Offset = "0x2D02740", VA = "0x182D03740", Slot = "21")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D03C00", Offset = "0x2D02C00", VA = "0x182D03C00", Slot = "22")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D031C0", Offset = "0x2D021C0", VA = "0x182D031C0", Slot = "23")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D03450", Offset = "0x2D02450", VA = "0x182D03450", Slot = "11")]
	public void DNGEACFPCPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D03FB0", Offset = "0x2D02FB0", VA = "0x182D03FB0", Slot = "12")]
	public void OMDNOALHCJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D03A50", Offset = "0x2D02A50", VA = "0x182D03A50", Slot = "14")]
	public void JCGBBONJCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D03370", Offset = "0x2D02370", VA = "0x182D03370", Slot = "15")]
	public void DGLLKHNGIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D032B0", Offset = "0x2D022B0", VA = "0x182D032B0", Slot = "13")]
	public void BPLDMKHFMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x2D03EF0", Offset = "0x2D02EF0", VA = "0x182D03EF0", Slot = "16")]
	public void OCEBCFDMLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D03E30", Offset = "0x2D02E30", VA = "0x182D03E30", Slot = "17")]
	public void OADPHJAFBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D03B10", Offset = "0x2D02B10", VA = "0x182D03B10", Slot = "18")]
	public void KCOFLEANIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D03BD0", Offset = "0x2D02BD0", VA = "0x182D03BD0", Slot = "19")]
	public void KDICLELKEBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D04090", Offset = "0x2D03090", VA = "0x182D04090", Slot = "24")]
	public void PPFJHNNOEMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2D03D20", Offset = "0x2D02D20", VA = "0x182D03D20")]
	private void MFNJFAEBAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2D03510", Offset = "0x2D02510", VA = "0x182D03510", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2D03430", Offset = "0x2D02430", VA = "0x182D03430", Slot = "10")]
	public ComponentSystemBase DKCDKEAINDG(Type BCFKLEGAMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2D03980", Offset = "0x2D02980", VA = "0x182D03980")]
	public bool IIBFGINLLLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2AAA240", Offset = "0x2AA9240", VA = "0x182AAA240", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA2A0", Offset = "0x2AA92A0", VA = "0x182AAA2A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x2AAA210", Offset = "0x2AA9210", VA = "0x182AAA210", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x755B40", Offset = "0x754B40", VA = "0x180755B40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x704170", Offset = "0x703170", VA = "0x180704170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA180", Offset = "0x2AA9180", VA = "0x182AAA180")]
	public LINFENAKNLD(Func<From, To> KLINPOPBADJ, Func<To, From> AOAOCMABBCP, bool ELNPFHKAOAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9DD0", Offset = "0x2AA8DD0", VA = "0x182AA9DD0", Slot = "11")]
	public void Add(To EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x288D8D0", Offset = "0x288C8D0", VA = "0x18288D8D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9E30", Offset = "0x2AA8E30", VA = "0x182AA9E30", Slot = "13")]
	public bool Contains(To EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9E90", Offset = "0x2AA8E90", VA = "0x182AA9E90", Slot = "14")]
	public void CopyTo(To[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9FA0", Offset = "0x2AA8FA0", VA = "0x182AA9FA0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA010", Offset = "0x2AA9010", VA = "0x182AAA010", Slot = "6")]
	public int IndexOf(To EKFBJDGFFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA070", Offset = "0x2AA9070", VA = "0x182AAA070", Slot = "7")]
	public void Insert(int MMABPPDCBIB, To EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA120", Offset = "0x2AA9120", VA = "0x182AAA120", Slot = "15")]
	public bool Remove(To EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA0F0", Offset = "0x2AA90F0", VA = "0x182AAA0F0", Slot = "8")]
	public void RemoveAt(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x25BB6C0", Offset = "0x25BA6C0", VA = "0x1825BB6C0", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x27747D0", Offset = "0x27737D0", VA = "0x1827747D0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x2774820", Offset = "0x2773820", VA = "0x182774820", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2774790", Offset = "0x2773790", VA = "0x182774790", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2057200", Offset = "0x2056200", VA = "0x182057200")]
	public BHJPHCDHIBJ(Func<From, To> KLINPOPBADJ, Func<To, From> AOAOCMABBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x27743A0", Offset = "0x27733A0", VA = "0x1827743A0", Slot = "11")]
	public void Add(To EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x27743E0", Offset = "0x27733E0", VA = "0x1827743E0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2774420", Offset = "0x2773420", VA = "0x182774420", Slot = "13")]
	public bool Contains(To EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x27744E0", Offset = "0x27734E0", VA = "0x1827744E0", Slot = "14")]
	public void CopyTo(To[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x27745A0", Offset = "0x27735A0", VA = "0x1827745A0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2774660", Offset = "0x2773660", VA = "0x182774660", Slot = "6")]
	public int IndexOf(To EKFBJDGFFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x27746D0", Offset = "0x27736D0", VA = "0x1827746D0", Slot = "7")]
	public void Insert(int MMABPPDCBIB, To EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x2774750", Offset = "0x2773750", VA = "0x182774750", Slot = "15")]
	public bool Remove(To EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2774710", Offset = "0x2773710", VA = "0x182774710", Slot = "8")]
	public void RemoveAt(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x1F7A590", Offset = "0x1F79590", VA = "0x181F7A590", Slot = "17")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public DGNEMCCNDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x4ECFD80", Offset = "0x4ECED80", VA = "0x184ECFD80")]
		internal void <InitServices>b__1(DNEGIKEIIMB svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x4ECFDE0", Offset = "0x4ECEDE0", VA = "0x184ECFDE0")]
		internal void <InitServices>b__2(PGECBFIGDKK svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2C78FA0", Offset = "0x2C77FA0", VA = "0x182C78FA0")]
	public static void AHDIHFIOOCJ(this JIGACBOPBKP EAMEDKLPJKC, EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA400", Offset = "0x1EB9400", VA = "0x181EBA400")]
	public static void BKDJGJBNENH<T>(this JIGACBOPBKP EAMEDKLPJKC, Action<T> CIJADOGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA260", Offset = "0x1EB9260", VA = "0x181EBA260")]
	public static void ALNKDAFBNBE<T>(this JIGACBOPBKP EAMEDKLPJKC, Action<T> CIJADOGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA530", Offset = "0x1EB9530", VA = "0x181EBA530")]
	public static void DKMIPLJLLPP<T>(this JIGACBOPBKP EAMEDKLPJKC, Action<T> CIJADOGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA890", Offset = "0x1EB9890", VA = "0x181EBA890")]
	public static void MMNGMBLKFPL<T>(this JIGACBOPBKP EAMEDKLPJKC, Action<T> CIJADOGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA6E0", Offset = "0x1EB96E0", VA = "0x181EBA6E0")]
	public static void EFAPDKJCHBB<T>(this JIGACBOPBKP EAMEDKLPJKC, Action<T> CIJADOGNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA470", Offset = "0x1EB9470", VA = "0x181EBA470")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public DMFLIOOPGLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6CA0", Offset = "0x2CF5CA0", VA = "0x182CF6CA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C71650", Offset = "0x2C70650", VA = "0x182C71650")]
	public HLIHHNELGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action IAGKKNDMOKL();

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2C71460", Offset = "0x2C70460", VA = "0x182C71460")]
	public MethodInfo BCFBPPCNIEO(Action NCHNGIGODJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2C714A0", Offset = "0x2C704A0", VA = "0x182C714A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7F7D0", Offset = "0x2C7E7D0", VA = "0x182C7F7D0", Slot = "5")]
	public override Action IAGKKNDMOKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void KFEMFEHPLAF<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F860", Offset = "0x2C7E860", VA = "0x182C7F860")]
	[Preserve]
	public void ICJOIIDHCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2C78620", Offset = "0x2C77620", VA = "0x182C78620")]
	protected NFBLMBAAGNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class MKOPABNCOHI : HLIHHNELGOP
{
	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CBC0", Offset = "0x2C7BBC0", VA = "0x182C7CBC0", Slot = "5")]
	public override Action IAGKKNDMOKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void BNDCBOEANAJ<T>() where T : JAPJBKCPIOB;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CC50", Offset = "0x2C7BC50", VA = "0x182C7CC50")]
	[Preserve]
	public void ICJOIIDHCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2C78620", Offset = "0x2C77620", VA = "0x182C78620")]
	protected MKOPABNCOHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class KOGLBOKFCDI : HLIHHNELGOP
{
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2C78500", Offset = "0x2C77500", VA = "0x182C78500", Slot = "5")]
	public override Action IAGKKNDMOKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void PDGBFFBPGEF<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2C78590", Offset = "0x2C77590", VA = "0x182C78590")]
	[Preserve]
	public void ICJOIIDHCIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2C78620", Offset = "0x2C77620", VA = "0x182C78620")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x66A130", Offset = "0x669130", VA = "0x18066A130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public HBIJPHJPPAA COEFAKNIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x66A140", Offset = "0x669140", VA = "0x18066A140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public OMCLDCKMHNM LJFDDHDKJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x64B130", Offset = "0x64A130", VA = "0x18064B130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public JLKICMMDFEF FDJIEGNOFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x68C1C0", Offset = "0x68B1C0", VA = "0x18068C1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public EKIBDKMJGBC EOGADIBFGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x6606F0", Offset = "0x65F6F0", VA = "0x1806606F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AE0", Offset = "0x6E1AE0", VA = "0x1806E2AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public NCNJODMFFIF PJKMGICLPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x651570", Offset = "0x650570", VA = "0x180651570", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x651590", Offset = "0x650590", VA = "0x180651590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public HCGMPCJKLOI DGFBLHPCMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x651580", Offset = "0x650580", VA = "0x180651580", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x6515A0", Offset = "0x6505A0", VA = "0x1806515A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IACMPOBAJCP BMOFKAEBDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x64A0D0", Offset = "0x6490D0", VA = "0x18064A0D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x72D4A0", Offset = "0x72C4A0", VA = "0x18072D4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public KAOEDAJOEMH CGJIJDPKADF
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x660760", Offset = "0x65F760", VA = "0x180660760", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6D4000", Offset = "0x6D3000", VA = "0x1806D4000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public NOCGABKMADN FCLJFANGHHH
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x64A0B0", Offset = "0x6490B0", VA = "0x18064A0B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x72D490", Offset = "0x72C490", VA = "0x18072D490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public NHBLKFLNCCJ FINIDPHNNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x660770", Offset = "0x65F770", VA = "0x180660770", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x6EBAB0", Offset = "0x6EAAB0", VA = "0x1806EBAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public NJFOAABDNKO HCGNKDEPDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x660780", Offset = "0x65F780", VA = "0x180660780", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x75CEB0", Offset = "0x75BEB0", VA = "0x18075CEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public KENINKEKDMC JDAJMLPLHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x660700", Offset = "0x65F700", VA = "0x180660700", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x672860", Offset = "0x671860", VA = "0x180672860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LINPFIEIHLN MHLHNIJKIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x660710", Offset = "0x65F710", VA = "0x180660710", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x681DB0", Offset = "0x680DB0", VA = "0x180681DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public LLNLFBIJEEI IPAILOOANFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x6866D0", Offset = "0x6856D0", VA = "0x1806866D0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x681D90", Offset = "0x680D90", VA = "0x180681D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public KGMAJJBPDAG MFPOBIMPBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x650D80", Offset = "0x64FD80", VA = "0x180650D80", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x902300", Offset = "0x901300", VA = "0x180902300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public NJMMPJDFPHF JFNBHBPHAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x650E20", Offset = "0x64FE20", VA = "0x180650E20", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4510", Offset = "0x7E3510", VA = "0x1807E4510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public CANGMNNAPBN CMLMBGKFDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x6866A0", Offset = "0x6856A0", VA = "0x1806866A0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x901920", Offset = "0x900920", VA = "0x180901920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public KFOLAMOKFLP ENEPBFJBFCL
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x660720", Offset = "0x65F720", VA = "0x180660720", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x681DA0", Offset = "0x680DA0", VA = "0x180681DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public IMBFPFHIPDB ACNOJBHFKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x670AA0", Offset = "0x66FAA0", VA = "0x180670AA0", Slot = "4")]
		get
		{
			return default(IMBFPFHIPDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x2C8FCE0", Offset = "0x2C8ECE0", VA = "0x182C8FCE0", Slot = "5")]
	public void PGJAPBHHKEM(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x660790", Offset = "0x65F790", VA = "0x180660790", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED1950", Offset = "0x4ED0950", VA = "0x184ED1950", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x64E200", Offset = "0x64D200", VA = "0x18064E200")]
		[DebuggerHidden]
		public GOOBIHCBBJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x4ED17A0", Offset = "0x4ED07A0", VA = "0x184ED17A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x4ED1910", Offset = "0x4ED0910", VA = "0x184ED1910", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BBD0", Offset = "0x64ABD0", VA = "0x18064BBD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x6EE410", Offset = "0x6ED410", VA = "0x1806EE410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public int FMCIMBNBALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x665C90", Offset = "0x664C90", VA = "0x180665C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x6EE320", Offset = "0x6ED320", VA = "0x1806EE320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2C7C740", Offset = "0x2C7B740", VA = "0x182C7C740")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BEF0", Offset = "0x2C7AEF0", VA = "0x182C7BEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CB40", Offset = "0x2C7BB40", VA = "0x182C7CB40")]
	public MJCBMJEHEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CAB0", Offset = "0x2C7BAB0", VA = "0x182C7CAB0")]
	public MJCBMJEHEKD(int DNLGEKMDGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C660", Offset = "0x2C7B660", VA = "0x182C7C660")]
	public bool LMNLKCIJIFK(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C7E0", Offset = "0x2C7B7E0", VA = "0x182C7C7E0")]
	public bool MJBNFPBGOAF(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C4C0", Offset = "0x2C7B4C0", VA = "0x182C7C4C0")]
	public bool JBMMPEHBECB(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C190", Offset = "0x2C7B190", VA = "0x182C7C190")]
	public bool DPHKGIJFNKP(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BE60", Offset = "0x2C7AE60", VA = "0x182C7BE60")]
	public void CLABMKNNEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C360", Offset = "0x2C7B360", VA = "0x182C7C360")]
	public void FCMHKLCBIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C0A0", Offset = "0x2C7B0A0", VA = "0x182C7C0A0")]
	public void DIMECELKFHA(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C8D0", Offset = "0x2C7B8D0", VA = "0x182C7C8D0")]
	public void OJEEPLKEKIC(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CA20", Offset = "0x2C7BA20", VA = "0x182C7CA20")]
	public bool ONOFBPEKJJJ(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C540", Offset = "0x2C7B540", VA = "0x182C7C540")]
	public void KOLCGGBJAIH(int EGBIMJLECFF, int LGKBEOCJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C1A0", Offset = "0x2C7B1A0", VA = "0x182C7C1A0")]
	public void FALABANDKPD(int PJLFEJFCFBB, int CKCMLJGEIGK, int LGKBEOCJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BD20", Offset = "0x2C7AD20", VA = "0x182C7BD20")]
	public int CEMPCIEDPMO(int LGKBEOCJMLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BDF0", Offset = "0x2C7ADF0", VA = "0x182C7BDF0")]
	public int CEMPCIEDPMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C9D0", Offset = "0x2C7B9D0", VA = "0x182C7C9D0")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C450", Offset = "0x2C7B450", VA = "0x182C7C450", Slot = "4")]
	[IteratorStateMachine(typeof(GOOBIHCBBJC))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7C450", Offset = "0x2C7B450", VA = "0x182C7C450", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x173E7A0", Offset = "0x173D7A0", VA = "0x18173E7A0")]
	public IDLHPCIHGLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x1BB7B90", Offset = "0x1BB6B90", VA = "0x181BB7B90")]
	public IDLHPCIHGLB(global::LMEAOAOKCKJ<T> JAKCIDHCLFK, global::BAIJIAKBDCD<T> JPBCHOPICMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x1BB74A0", Offset = "0x1BB64A0", VA = "0x181BB74A0", Slot = "11")]
	public override T ADHMOLAJGDE(GMABBDHCMBI IJENJGNEIAC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x1BB77E0", Offset = "0x1BB67E0", VA = "0x181BB77E0", Slot = "12")]
	public override void HHDOHEHKDKI(GMABBDHCMBI IJENJGNEIAC, T CCIMHDCKHOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class PGODMHHFMGG
{
	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B086C0", Offset = "0x2B076C0", VA = "0x182B086C0")]
	public static FHCGLCCCIJI IIGIGLNPDMN<T>(this AMLOIBNNKBM IEBMFIFBGIK, global::JHOLIPIPHIK<T> FOGNBJMCDMG, global::LMEAOAOKCKJ<T> JAKCIDHCLFK, global::BAIJIAKBDCD<T> JPBCHOPICMD) where T : struct
	{
		return default(FHCGLCCCIJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class LJCCBNLHHPD<T> : global::IDLHPCIHGLB<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA400", Offset = "0x2AA9400", VA = "0x182AAA400")]
	public LJCCBNLHHPD(T BNIGPLBPEGC, T EJIIEDBELNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class AKOOFKKCKCP<T> : global::LCANCFBJDFM<T> where T : struct, JAPJBKCPIOB
{
	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x3240820", Offset = "0x323F820", VA = "0x183240820", Slot = "11")]
	public override T ADHMOLAJGDE(GMABBDHCMBI IJENJGNEIAC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x32408B0", Offset = "0x323F8B0", VA = "0x1832408B0", Slot = "12")]
	public override void HHDOHEHKDKI(GMABBDHCMBI IJENJGNEIAC, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x232C390", Offset = "0x232B390", VA = "0x18232C390")]
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
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A92AA0", Offset = "0x2A91AA0", VA = "0x182A92AA0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A90A30", Offset = "0x2A8FA30", VA = "0x182A90A30", Slot = "8")]
	public override void ADHMOLAJGDE(GMABBDHCMBI IJENJGNEIAC, in PEOLEOJFANL MJPNNJLLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x2A923F0", Offset = "0x2A913F0", VA = "0x182A923F0", Slot = "9")]
	public override void HHDOHEHKDKI(GMABBDHCMBI IJENJGNEIAC, in IKKMGBAJNEB LENKHFNFMLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x2A916C0", Offset = "0x2A906C0", VA = "0x182A916C0", Slot = "10")]
	public override void ENNFCPGKJEH(GMABBDHCMBI IJENJGNEIAC, DNKDFNNFDHL EDJDHHEMACF, object IGBOEABBEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x2065660", Offset = "0x2064660", VA = "0x182065660")]
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
			[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
			public JFBLFJGJGJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x233C940", Offset = "0x233B940", VA = "0x18233C940")]
			internal void <RegisterFixedString>b__0(GMABBDHCMBI p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x233CC50", Offset = "0x233BC50", VA = "0x18233CC50")]
			internal T <RegisterFixedString>b__1(GMABBDHCMBI p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x4ED5130", Offset = "0x4ED4130", VA = "0x184ED5130")]
		public static void DKKDLLIOCBN(FKGGHHOKMHE BOPHPJCPNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x2FD73F0", Offset = "0x2FD63F0", VA = "0x182FD73F0")]
		private static void ABEPHILKAKB<T>(FKGGHHOKMHE BOPHPJCPNOG, int EJIIEDBELNE) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7B60", Offset = "0x2FD6B60", VA = "0x182FD7B60")]
		private static void ODGFNMIDMKG<T>(GMABBDHCMBI OGGODOHJPHN, T DCNCBDGEKMD, int EJIIEDBELNE) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x2FD7510", Offset = "0x2FD6510", VA = "0x182FD7510")]
		private static T AGEMIDABIDO<T>(GMABBDHCMBI OGGODOHJPHN, int EJIIEDBELNE) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2FC87C0", Offset = "0x2FC77C0", VA = "0x182FC87C0", Slot = "6")]
		public override void KFEMFEHPLAF<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x29BA0B0", Offset = "0x29B90B0", VA = "0x1829BA0B0")]
		public static void FOOABLPAIEK(FKGGHHOKMHE BOPHPJCPNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x29BA140", Offset = "0x29B9140", VA = "0x1829BA140")]
		public CCFPDJFLPFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFFE0", Offset = "0x2CFEFE0", VA = "0x182CFFFE0")]
	public static void FKIDKGJAAHO(FKGGHHOKMHE BOPHPJCPNOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F294A0", Offset = "0x1F284A0", VA = "0x181F294A0")]
	public static void JLKOILALNGO<T>(FKGGHHOKMHE BOPHPJCPNOG, global::LMEAOAOKCKJ<T> JAKCIDHCLFK, global::BAIJIAKBDCD<T> JPBCHOPICMD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x1F29530", Offset = "0x1F28530", VA = "0x181F29530")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CECFB0", Offset = "0x2CEBFB0", VA = "0x182CECFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x755B40", Offset = "0x754B40", VA = "0x180755B40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x704170", Offset = "0x703170", VA = "0x180704170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C80870", Offset = "0x2C7F870", VA = "0x182C80870")]
	public NOKPJGEBACA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2C807B0", Offset = "0x2C7F7B0", VA = "0x182C807B0")]
	public NOKPJGEBACA(Dictionary<FHCGLCCCIJI, KIMJPFDBIKK> BOPHPJCPNOG, bool MDFFJMMCBJO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C80070", Offset = "0x2C7F070", VA = "0x182C80070", Slot = "7")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C803F0", Offset = "0x2C7F3F0", VA = "0x182C803F0", Slot = "8")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C80760", Offset = "0x2C7F760", VA = "0x182C80760", Slot = "9")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C801B0", Offset = "0x2C7F1B0", VA = "0x182C801B0", Slot = "4")]
	public FHCGLCCCIJI GPBGCLPEPLP(FAMLDGNAFHF FOGNBJMCDMG)
	{
		return default(FHCGLCCCIJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C80280", Offset = "0x2C7F280", VA = "0x182C80280", Slot = "5")]
	public void IIGIGLNPDMN(FHCGLCCCIJI DGFBLJMJMFI, KIMJPFDBIKK PKCBLFIFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2C80620", Offset = "0x2C7F620", VA = "0x182C80620")]
	[Conditional("DEBUG_BUILD")]
	private void NOIEGBPHINC(FHCGLCCCIJI DGFBLJMJMFI, Type BCFKLEGAMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C80470", Offset = "0x2C7F470", VA = "0x182C80470", Slot = "6")]
	public bool MFJHFJBDKOG(FHCGLCCCIJI DGFBLJMJMFI, out KIMJPFDBIKK PKCBLFIFNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C800D0", Offset = "0x2C7F0D0", VA = "0x182C800D0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6648D0", Offset = "0x6638D0", VA = "0x1806648D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x686000", Offset = "0x685000", VA = "0x180686000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2D05960", Offset = "0x2D04960", VA = "0x182D05960")]
	public HFCMFPPJFIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2D058A0", Offset = "0x2D048A0", VA = "0x182D058A0")]
	public HFCMFPPJFIH(Dictionary<Type, KIMJPFDBIKK> BOPHPJCPNOG, bool MDFFJMMCBJO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2D05520", Offset = "0x2D04520", VA = "0x182D05520", Slot = "4")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2D05660", Offset = "0x2D04660", VA = "0x182D05660", Slot = "5")]
	public void IIGIGLNPDMN(Type BCFKLEGAMEO, KIMJPFDBIKK PKCBLFIFNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2D05780", Offset = "0x2D04780", VA = "0x182D05780", Slot = "6")]
	public bool MFJHFJBDKOG(Type BCFKLEGAMEO, out KIMJPFDBIKK PKCBLFIFNIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D05580", Offset = "0x2D04580", VA = "0x182D05580", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C759E0", Offset = "0x2C749E0", VA = "0x182C759E0", Slot = "6")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C75B10", Offset = "0x2C74B10", VA = "0x182C75B10", Slot = "7")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C75A30", Offset = "0x2C74A30", VA = "0x182C75A30", Slot = "4")]
	public void IIGIGLNPDMN(FHCGLCCCIJI LKIMNIMPHKB, Type HABCDENGGON, DHLGGLGOCCP ILPODOBHFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C75AA0", Offset = "0x2C74AA0", VA = "0x182C75AA0", Slot = "5")]
	public bool JHNINJDPLIP(FHCGLCCCIJI LKIMNIMPHKB, out DHLGGLGOCCP ILPODOBHFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2C75B70", Offset = "0x2C74B70", VA = "0x182C75B70")]
	[Conditional("DEBUG_BUILD")]
	private void PAKPPEDCPEK(FHCGLCCCIJI LKIMNIMPHKB, Type HABCDENGGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2C75D00", Offset = "0x2C74D00", VA = "0x182C75D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C83DD0", Offset = "0x2C82DD0", VA = "0x182C83DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool EHHPFKGKIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x715540", Offset = "0x714540", VA = "0x180715540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x9586A0", Offset = "0x9576A0", VA = "0x1809586A0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2C83C90", Offset = "0x2C82C90", VA = "0x182C83C90", Slot = "6")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2C83EC0", Offset = "0x2C82EC0", VA = "0x182C83EC0", Slot = "7")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2C83BE0", Offset = "0x2C82BE0", VA = "0x182C83BE0", Slot = "8")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2C83E20", Offset = "0x2C82E20", VA = "0x182C83E20")]
	private void KHHFONDHJBM(IOFHLMDPEAL CPBDAEHELGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2C84290", Offset = "0x2C83290", VA = "0x182C84290", Slot = "4")]
	public bool ONABLOEHPAF(DDAOHKAFOIC LNNGKIMHKAI, FHCGLCCCIJI MIGODNJAHNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2C83F40", Offset = "0x2C82F40", VA = "0x182C83F40", Slot = "5")]
	public void LKJKJFKLGID(DDAOHKAFOIC LNNGKIMHKAI, Span<FHCGLCCCIJI> IEBMFIFBGIK, bool GAJCGAEIAJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2C83C90", Offset = "0x2C82C90", VA = "0x182C83C90", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2C84390", Offset = "0x2C83390", VA = "0x182C84390")]
	public OJPCPFOOMFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class LENJPLLCJCG
{
	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2C79620", Offset = "0x2C78620", VA = "0x182C79620")]
	public static void BDABGCPMMHD(this GMABBDHCMBI IJENJGNEIAC, ReadOnlyMemory<byte> KPKAPHOMBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x1EBAA40", Offset = "0x1EB9A40", VA = "0x181EBAA40")]
	public static void EPOIFDELDCH<T>(this GMABBDHCMBI IJENJGNEIAC, in T CCIMHDCKHOF) where T : struct, JAPJBKCPIOB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x1EBAB40", Offset = "0x1EB9B40", VA = "0x181EBAB40")]
	public static T NMEPGOOIINA<T>(this GMABBDHCMBI IJENJGNEIAC) where T : struct, JAPJBKCPIOB
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2C796D0", Offset = "0x2C786D0", VA = "0x182C796D0")]
	public static void EPOIFDELDCH(this GMABBDHCMBI IJENJGNEIAC, EEAMIIEHJFA GKBNIMHPHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2C796A0", Offset = "0x2C786A0", VA = "0x182C796A0")]
	public static EEAMIIEHJFA DADDPBFCPPD(this GMABBDHCMBI IJENJGNEIAC)
	{
		return default(EEAMIIEHJFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2C79820", Offset = "0x2C78820", VA = "0x182C79820")]
	public static void HGIGDCNEBAD(this GMABBDHCMBI FBNHINKPMEA, uint PCLONCFBJBB, bool PFMEEDNEAAM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x2C79700", Offset = "0x2C78700", VA = "0x182C79700")]
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
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public PMKECBJMGJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x250F410", Offset = "0x250E410", VA = "0x18250F410")]
		internal void <GetByteEnumDelegates>b__0(GMABBDHCMBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x250F480", Offset = "0x250E480", VA = "0x18250F480")]
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
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public FOOPHNEALDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x303CEF0", Offset = "0x303BEF0", VA = "0x18303CEF0")]
		internal void <GetSByteEnumDelegates>b__0(GMABBDHCMBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x303CF60", Offset = "0x303BF60", VA = "0x18303CF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public MODDOCAEIJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x2A1F4E0", Offset = "0x2A1E4E0", VA = "0x182A1F4E0")]
		internal void <GetShortEnumDelegates>b__0(GMABBDHCMBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x2A1F550", Offset = "0x2A1E550", VA = "0x182A1F550")]
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
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public LNLDOPJMIIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x28937B0", Offset = "0x28927B0", VA = "0x1828937B0")]
		internal void <GetUShortEnumDelegates>b__0(GMABBDHCMBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x2893820", Offset = "0x2892820", VA = "0x182893820")]
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
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public IGEANHAAAON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x1BB9C10", Offset = "0x1BB8C10", VA = "0x181BB9C10")]
		internal void <GetIntEnumDelegates>b__0(GMABBDHCMBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x1BB9C70", Offset = "0x1BB8C70", VA = "0x181BB9C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public NGGIPKOMDBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x236FFE0", Offset = "0x236EFE0", VA = "0x18236FFE0")]
		internal void <GetUIntEnumDelegates>b__0(GMABBDHCMBI b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x2370040", Offset = "0x236F040", VA = "0x182370040")]
		internal T <GetUIntEnumDelegates>b__1(GMABBDHCMBI b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x1EA02C0", Offset = "0x1E9F2C0", VA = "0x181EA02C0")]
	public static void OCHFHJDCICI<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0020", Offset = "0x1E9F020", VA = "0x181EA0020")]
	private static void KDKOEEFADCG<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0020", Offset = "0x1E9F020", VA = "0x181EA0020")]
	private static void FDJOOFAKPEF<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FED0", Offset = "0x1E9EED0", VA = "0x181E9FED0")]
	private static void CJLKKOMLOCM<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x1E9FED0", Offset = "0x1E9EED0", VA = "0x181E9FED0")]
	private static void NIMCEKPBEMH<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0170", Offset = "0x1E9F170", VA = "0x181EA0170")]
	private static void KFLCHLLEPEJ<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x1EA0170", Offset = "0x1E9F170", VA = "0x181EA0170")]
	private static void OKLBFEPIGEO<T>(T BNIGPLBPEGC, T EJIIEDBELNE, out global::LMEAOAOKCKJ<T> NKEPOIHFBNN, out global::BAIJIAKBDCD<T> DPCGNLPGKAG) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public abstract class JAOBCHLEKPG : APKLEDPALBD, PGECBFIGDKK
{
	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x2C758C0", Offset = "0x2C748C0", VA = "0x182C758C0", Slot = "4")]
	private void DIJCJEDHHPA(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void ADHIFDAJFNB(AMLOIBNNKBM IEBMFIFBGIK);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40")]
	protected JAOBCHLEKPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[APCNEFCKKAN(typeof(LocalPoseData))]
public sealed class EDDMAMANBLL : JAOBCHLEKPG
{
	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2CFA000", Offset = "0x2CF9000", VA = "0x182CFA000", Slot = "5")]
	protected override void ADHIFDAJFNB(AMLOIBNNKBM IEBMFIFBGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CED0B0", Offset = "0x2CEC0B0", VA = "0x182CED0B0", Slot = "4")]
	public bool Equals(BLECMCBOLCB IIKMMJKCGDO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x72A040", Offset = "0x729040", VA = "0x18072A040")]
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
	[Cpp2IlInjected.Address(RVA = "0x72A040", Offset = "0x729040", VA = "0x18072A040")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FBE20", Offset = "0x6FAE20", VA = "0x1806FBE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD90", Offset = "0x6FAD90", VA = "0x1806FBD90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x8A3600", Offset = "0x8A2600", VA = "0x1808A3600", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xE9D080", Offset = "0xE9C080", VA = "0x180E9D080", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2CFF5F0", Offset = "0x2CFE5F0", VA = "0x182CFF5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x2CED0B0", Offset = "0x2CEC0B0", VA = "0x182CED0B0", Slot = "8")]
	public bool Equals(FGGNGNPKIFF IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF630", Offset = "0x2CFE630", VA = "0x182CFF630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class LLLHPDILIMK : ParentSystemBase<AuthoredParentData, HDODHPJEEDH, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A920", Offset = "0x2C79920", VA = "0x182C7A920", Slot = "14")]
	protected override EntityQueryDesc HNGMCOJHLNH(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x6F56B0", Offset = "0x6F46B0", VA = "0x1806F56B0", Slot = "15")]
	protected override EntityQueryDesc CPFDHCLBLCN(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A8E0", Offset = "0x2C798E0", VA = "0x182C7A8E0", Slot = "16")]
	protected override EntityQueryDesc GNOHAGLAAJO(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A8A0", Offset = "0x2C798A0", VA = "0x182C7A8A0", Slot = "17")]
	protected override EntityQueryDesc ECDEGGLBPCN(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A9A0", Offset = "0x2C799A0", VA = "0x182C7A9A0")]
	public LLLHPDILIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A960", Offset = "0x2C79960", VA = "0x182C7A960", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED6230", Offset = "0x4ED5230", VA = "0x184ED6230")]
			public OKLLPMCJCEG(FGGNGNPKIFF BLIPNDKFLPL, float3 LPADDFNBONE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x4ED6210", Offset = "0x4ED5210", VA = "0x184ED6210")]
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
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
			public KGPLBAEGFBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
			public CDGKCHDIMKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
			public MOIBJFIOLJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4ECFC40", Offset = "0x4ECEC40", VA = "0x184ECFC40")]
				public void GPJBIMHIEAK(UpdateConnectableVisuals AKIOJOCDPLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600057B")]
				[Cpp2IlInjected.Address(RVA = "0x4ECFCC0", Offset = "0x4ECECC0", VA = "0x184ECFCC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ECFE40", Offset = "0x4ECEE40", VA = "0x184ECFE40")]
			internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, WorldPoseData BNOEIJLKPMM, in DynamicBuffer<DNKDBOAOIFO> JCLIGOJKKCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0350", Offset = "0x4ECF350", VA = "0x184ED0350", Slot = "5")]
			public void ReadFromDisplayClass(ref KGPLBAEGFBJ PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0380", Offset = "0x4ECF380", VA = "0x184ED0380", Slot = "6")]
			public void WriteToDisplayClass(ref KGPLBAEGFBJ PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0230", Offset = "0x4ECF230", VA = "0x184ED0230", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0x4ED00F0", Offset = "0x4ECF0F0", VA = "0x184ED00F0")]
			public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, ref CPMBDEFHEOB.MOHFGJJCENE FNDMFEGAALM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0310", Offset = "0x4ECF310", VA = "0x184ED0310")]
			public void GPJBIMHIEAK(UpdateConnectableVisuals AKIOJOCDPLG, ref KGPLBAEGFBJ PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0080", Offset = "0x4ECF080", VA = "0x184ED0080")]
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
				[Cpp2IlInjected.Address(RVA = "0x4ECE800", Offset = "0x4ECD800", VA = "0x184ECE800")]
				public void GPJBIMHIEAK(UpdateConnectableVisuals AKIOJOCDPLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000582")]
				[Cpp2IlInjected.Address(RVA = "0x4ECE870", Offset = "0x4ECD870", VA = "0x184ECE870")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED40A0", Offset = "0x4ED30A0", VA = "0x184ED40A0")]
			internal void BOGFKFCHEFD(in WorldPoseData BNOEIJLKPMM, in DynamicBuffer<BLECMCBOLCB> JCLIGOJKKCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x29BA330", Offset = "0x29B9330", VA = "0x1829BA330", Slot = "5")]
			public void ReadFromDisplayClass(ref CDGKCHDIMKI PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x4ED4280", Offset = "0x4ED3280", VA = "0x184ED4280", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x4ED41B0", Offset = "0x4ED31B0", VA = "0x184ED41B0")]
			public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref AFNMGBNBLOE.FDBMFEKGGKK FNDMFEGAALM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x4ED4350", Offset = "0x4ED3350", VA = "0x184ED4350")]
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
				[Cpp2IlInjected.Address(RVA = "0x4ED3300", Offset = "0x4ED2300", VA = "0x184ED3300")]
				public void GPJBIMHIEAK(UpdateConnectableVisuals AKIOJOCDPLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000589")]
				[Cpp2IlInjected.Address(RVA = "0x4ED3390", Offset = "0x4ED2390", VA = "0x184ED3390")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ECE910", Offset = "0x4ECD910", VA = "0x184ECE910")]
			internal void BOGFKFCHEFD(in WorldPoseData BNOEIJLKPMM, in NOPNMMPBCNL COJCBHNIJLP, in DynamicBuffer<BLECMCBOLCB> JCLIGOJKKCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x29BA330", Offset = "0x29B9330", VA = "0x1829BA330", Slot = "5")]
			public void ReadFromDisplayClass(ref MOIBJFIOLJK PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x4ECEB90", Offset = "0x4ECDB90", VA = "0x184ECEB90", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0x4ECEA70", Offset = "0x4ECDA70", VA = "0x184ECEA70")]
			public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref KCAMCCKDPOA.NOLLJLHGCFF FNDMFEGAALM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x4ECEC10", Offset = "0x4ECDC10", VA = "0x184ECEC10")]
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
			[Cpp2IlInjected.Address(RVA = "0x29D3130", Offset = "0x29D2130", VA = "0x1829D3130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x29D2470", Offset = "0x29D1470", VA = "0x1829D2470")]
		internal GLFPMFLGMPH BMOBDJNMEDK(FGGNGNPKIFF BLIPNDKFLPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x29D56E0", Offset = "0x29D46E0", VA = "0x1829D56E0", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x29D60C0", Offset = "0x29D50C0", VA = "0x1829D60C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x29D5E80", Offset = "0x29D4E80", VA = "0x1829D5E80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x29D46F0", Offset = "0x29D36F0", VA = "0x1829D46F0")]
		private void JLOLMKMJBGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x29D3830", Offset = "0x29D2830", VA = "0x1829D3830")]
		private void GLIBGGIEOAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x29D3980", Offset = "0x29D2980", VA = "0x1829D3980")]
		private void GNINNNFMLOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x29D6100", Offset = "0x29D5100", VA = "0x1829D6100", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x29D3400", Offset = "0x29D2400", VA = "0x1829D3400")]
		private void FMPDGFOLIAO(EntityQuery LLDKNFNPLPB, EntityQuery MMDMJIGCAOK, EntityQuery OKDHGDLBAGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x29D4490", Offset = "0x29D3490", VA = "0x1829D4490")]
		private void JKKJCNGECGD(global::PEOLEGIGBJF<Entity> DNNDLEGGDDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x29D5400", Offset = "0x29D4400", VA = "0x1829D5400")]
		private void KMPDFAKMMEE(global::PEOLEGIGBJF<Entity> MIEPHMKOCLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x29D4370", Offset = "0x29D3370", VA = "0x1829D4370")]
		private void JDAPBKJLAPG(global::PEOLEGIGBJF<Entity> OMIBPKCANDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x29D58E0", Offset = "0x29D48E0", VA = "0x1829D58E0")]
		private void MAEHEPPIFOI(NativeList<FGGNGNPKIFF> JOCMGDNHOIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x29D4C50", Offset = "0x29D3C50", VA = "0x1829D4C50")]
		private NativeList<FGGNGNPKIFF> KFJKLEOGAGH(NativeArray<Entity> NGCJEBOBKNP)
		{
			return default(NativeList<FGGNGNPKIFF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x29D3D40", Offset = "0x29D2D40", VA = "0x1829D3D40")]
		private void JCHFOBDEHJJ(NativeArray<Entity> NGCJEBOBKNP, NativeList<FGGNGNPKIFF> JOCMGDNHOIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x29D2B20", Offset = "0x29D1B20", VA = "0x1829D2B20")]
		private void EBPEJEMDGAH(NativeArray<Entity> BEIDLIDPMGN, NativeArray<Entity> PPNGEAGGBGM, NativeList<FGGNGNPKIFF> JOLIJECAEFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x29D2680", Offset = "0x29D1680", VA = "0x1829D2680")]
		private void DFPBPEJOEPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x29D5A50", Offset = "0x29D4A50", VA = "0x1829D5A50")]
		private global::AGEGIHAKIMB<OKLLPMCJCEG> MOOPMJNCIIA(EntityQuery PMKDKHNEPAL, Func<NativeList<OKLLPMCJCEG>, JobHandle> IKFOCGFCGFE)
		{
			return default(global::AGEGIHAKIMB<OKLLPMCJCEG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x29D5B90", Offset = "0x29D4B90", VA = "0x1829D5B90")]
		private JobHandle OJEDPELEBAN(NativeList<OKLLPMCJCEG> PIJDNOPJENO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x29D2330", Offset = "0x29D1330", VA = "0x1829D2330")]
		private JobHandle BBBAAGJIDNG(NativeList<OKLLPMCJCEG> PIJDNOPJENO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x29D4B20", Offset = "0x29D3B20", VA = "0x1829D4B20")]
		private JobHandle KEOGDGLDJMB(NativeList<OKLLPMCJCEG> PIJDNOPJENO)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x29D4800", Offset = "0x29D3800", VA = "0x1829D4800")]
		private void KAEDNFOLLJL(global::AGEGIHAKIMB<OKLLPMCJCEG> PIJDNOPJENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x29D3170", Offset = "0x29D2170", VA = "0x1829D3170")]
		private void EPPDANCPALO(global::AGEGIHAKIMB<OKLLPMCJCEG> PIJDNOPJENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x29D3CE0", Offset = "0x29D2CE0", VA = "0x1829D3CE0")]
		private bool JBIFIEMEABI(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x29D3050", Offset = "0x29D2050", VA = "0x1829D3050")]
		private NativeArray<Entity> ELGPODGHFIF(Entity GDNDJKDEKFN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x29D24C0", Offset = "0x29D14C0", VA = "0x1829D24C0")]
		private FGGNGNPKIFF COINIKJHAEL(NativeList<FGGNGNPKIFF> JOLIJECAEFM)
		{
			return default(FGGNGNPKIFF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x29D4A90", Offset = "0x29D3A90", VA = "0x1829D4A90")]
		private void KDHNECLFHFJ(FGGNGNPKIFF BLIPNDKFLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x29D5D20", Offset = "0x29D4D20", VA = "0x1829D5D20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x29D6190", Offset = "0x29D5190", VA = "0x1829D6190")]
		public static EntityQuery PNHLANAFMFO(ComponentSystemBase AKIOJOCDPLG)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x29D5480", Offset = "0x29D4480", VA = "0x1829D5480")]
		public static EntityQuery KNOMDJDEEMA(ComponentSystemBase AKIOJOCDPLG)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x29D5190", Offset = "0x29D4190", VA = "0x1829D5190")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C81880", Offset = "0x2C80880", VA = "0x182C81880", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2C818D0", Offset = "0x2C808D0", VA = "0x182C818D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2C81990", Offset = "0x2C80990", VA = "0x182C81990", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x2C815A0", Offset = "0x2C805A0", VA = "0x182C815A0")]
	protected void GIGPFLIKDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x2AF56F0", Offset = "0x2AF46F0", VA = "0x182AF56F0")]
	private bool PIFFIJAPHOD<TComponentData>(EntityQuery PMKDKHNEPAL, out NativeArray<Entity> NGCJEBOBKNP, out NativeArray<TComponentData> GPJMDEPCIAF) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x2C81530", Offset = "0x2C80530", VA = "0x182C81530")]
	public GHMJIBJLDNA BKPOHCGBFOI(Entity GDNDJKDEKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public OAGDMILOAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CF6BD0", Offset = "0x2CF5BD0", VA = "0x182CF6BD0", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6C30", Offset = "0x2CF5C30", VA = "0x182CF6C30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6C60", Offset = "0x2CF5C60", VA = "0x182CF6C60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public DNIIHKEILBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C74CD0", Offset = "0x2C73CD0", VA = "0x182C74CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int OMMFOKCAHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x2C752D0", Offset = "0x2C742D0", VA = "0x182C752D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x2C74F50", Offset = "0x2C73F50", VA = "0x182C74F50", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2C752E0", Offset = "0x2C742E0", VA = "0x182C752E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2C754D0", Offset = "0x2C744D0", VA = "0x182C754D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2C74FB0", Offset = "0x2C73FB0", VA = "0x182C74FB0")]
	protected void LMGNHEIBHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2C74CE0", Offset = "0x2C73CE0", VA = "0x182C74CE0")]
	protected void JLPGLIDOHIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2C754F0", Offset = "0x2C744F0", VA = "0x182C754F0")]
	private bool PIFFIJAPHOD(EntityQuery PMKDKHNEPAL, out NativeArray<Entity> NGCJEBOBKNP, out NativeArray<EACJHPJAFLK> ICIEPJPHBOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x2C755E0", Offset = "0x2C745E0", VA = "0x182C755E0")]
	public global::PEOLEGIGBJF<Entity> PLHLFLGHDFK(Allocator EGJIMBMGFGA)
	{
		return default(global::PEOLEGIGBJF<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x2C74C30", Offset = "0x2C73C30", VA = "0x182C74C30")]
	public global::PEOLEGIGBJF<Entity> GFJMKJKJPON(Allocator EGJIMBMGFGA)
	{
		return default(global::PEOLEGIGBJF<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x2C74BB0", Offset = "0x2C73BB0", VA = "0x182C74BB0")]
	public bool DLJEEIDFJFN(Allocator EGJIMBMGFGA, out global::PEOLEGIGBJF<Entity> EGJPJHAOMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C74AE0", Offset = "0x2C73AE0", VA = "0x182C74AE0")]
	public bool AADNEELLNGM(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C74B40", Offset = "0x2C73B40", VA = "0x182C74B40")]
	public GHMJIBJLDNA BKPOHCGBFOI(Entity GDNDJKDEKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C75220", Offset = "0x2C74220", VA = "0x182C75220")]
	public bool LPOPHPNOAOD(Entity GDNDJKDEKFN, out CCFEOLMBFFJ EGJPJHAOMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C75290", Offset = "0x2C74290", VA = "0x182C75290")]
	public void NHILCMEGODH(Entity GDNDJKDEKFN, CCFEOLMBFFJ EGJPJHAOMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C74C70", Offset = "0x2C73C70", VA = "0x182C74C70")]
	public bool GHIMMNHHNIG(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public IJHAGLHACDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public CCFEOLMBFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
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
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public MPBFHEDOMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C82090", Offset = "0x2C81090", VA = "0x182C82090", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C820F0", Offset = "0x2C810F0", VA = "0x182C820F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	protected OGKMPINMJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public AKCEIDKHDMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, IBNCHDDCFDM previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED3960", Offset = "0x4ED2960", VA = "0x184ED3960")]
			public void GPJBIMHIEAK(FEHEGKHDIJC AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x4ED39C0", Offset = "0x4ED29C0", VA = "0x184ED39C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BA150", Offset = "0x29B9150", VA = "0x1829BA150")]
		internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, ParentData IMLJHLOOKFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x29BA330", Offset = "0x29B9330", VA = "0x1829BA330", Slot = "5")]
		public void ReadFromDisplayClass(ref AKCEIDKHDMF PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x29BA280", Offset = "0x29B9280", VA = "0x1829BA280", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x29BA1D0", Offset = "0x29B91D0", VA = "0x1829BA1D0")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref KDPJCEKMGOG.BPMOMDJGBFD FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x29BA2F0", Offset = "0x29B92F0", VA = "0x1829BA2F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED1B80", Offset = "0x4ED0B80", VA = "0x184ED1B80")]
			public void GPJBIMHIEAK(FEHEGKHDIJC AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1C00", Offset = "0x4ED0C00", VA = "0x184ED1C00")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BB620", Offset = "0x29BA620", VA = "0x1829BB620")]
		internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, ParentData IMLJHLOOKFM, IBNCHDDCFDM NOPNDJAEHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x29BB870", Offset = "0x29BA870", VA = "0x1829BB870", Slot = "5")]
		public void ReadFromDisplayClass(ref AKCEIDKHDMF PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x29BB7C0", Offset = "0x29BA7C0", VA = "0x1829BB7C0", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x29BB6E0", Offset = "0x29BA6E0", VA = "0x1829BB6E0")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref HHGEAGGMHMM.ODHCPOMADKI FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x29BB830", Offset = "0x29BA830", VA = "0x1829BB830")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED6360", Offset = "0x4ED5360", VA = "0x184ED6360")]
			public void GPJBIMHIEAK(FEHEGKHDIJC AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x4ED63C0", Offset = "0x4ED53C0", VA = "0x184ED63C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BDDB0", Offset = "0x29BCDB0", VA = "0x1829BDDB0")]
		internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, IBNCHDDCFDM NOPNDJAEHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x29BDF90", Offset = "0x29BCF90", VA = "0x1829BDF90", Slot = "5")]
		public void ReadFromDisplayClass(ref AKCEIDKHDMF PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x29BDEE0", Offset = "0x29BCEE0", VA = "0x1829BDEE0", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x29BDE30", Offset = "0x29BCE30", VA = "0x1829BDE30")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref PBANHOMGJJB.GOBLACHLAHA FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x29BDF50", Offset = "0x29BCF50", VA = "0x1829BDF50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CFEBE0", Offset = "0x2CFDBE0", VA = "0x182CFEBE0", Slot = "14")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF350", Offset = "0x2CFE350", VA = "0x182CFF350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public FEHEGKHDIJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6B50", Offset = "0x2CF5B50", VA = "0x182CF6B50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2CFECC0", Offset = "0x2CFDCC0", VA = "0x182CFECC0")]
	public static EntityQuery AHJIAIKAMBD(ComponentSystemBase AKIOJOCDPLG)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF120", Offset = "0x2CFE120", VA = "0x182CFF120")]
	public static EntityQuery MNJBFNEFKJC(ComponentSystemBase AKIOJOCDPLG)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x2CFEF20", Offset = "0x2CFDF20", VA = "0x182CFEF20")]
	public static EntityQuery JEAAFFKKNAB(ComponentSystemBase AKIOJOCDPLG)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class NMBOBHDKNDC : ParentSystemBase<ParentData, IBNCHDDCFDM, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FFD0", Offset = "0x2C7EFD0", VA = "0x182C7FFD0", Slot = "14")]
	protected override EntityQueryDesc HNGMCOJHLNH(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F56B0", Offset = "0x6F46B0", VA = "0x1806F56B0", Slot = "15")]
	protected override EntityQueryDesc CPFDHCLBLCN(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FF90", Offset = "0x2C7EF90", VA = "0x182C7FF90", Slot = "16")]
	protected override EntityQueryDesc GNOHAGLAAJO(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FF50", Offset = "0x2C7EF50", VA = "0x182C7FF50", Slot = "17")]
	protected override EntityQueryDesc ECDEGGLBPCN(EntityQueryDesc PMKDKHNEPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BA70", Offset = "0x2C7AA70", VA = "0x182C7BA70")]
	public NMBOBHDKNDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BA30", Offset = "0x2C7AA30", VA = "0x182C7BA30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A10B20", Offset = "0x2A0FB20", VA = "0x182A10B20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x25BB2C0", Offset = "0x25BA2C0", VA = "0x1825BB2C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x375F610", Offset = "0x375E610", VA = "0x18375F610")]
			private int BNNJFBEALBA(DynamicBuffer<ChildrenData> HFOEOPEIJAG, Entity GDNDJKDEKFN)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x375FEB0", Offset = "0x375EEB0", VA = "0x18375FEB0")]
			private void NGPIHBCNIKL(Entity OJKLIAPCMPJ, DynamicBuffer<ChildrenData> HFOEOPEIJAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x375FAF0", Offset = "0x375EAF0", VA = "0x18375FAF0")]
			private void FGOKKBCLAPK(Entity OJKLIAPCMPJ, DynamicBuffer<ChildrenData> HFOEOPEIJAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x375F990", Offset = "0x375E990", VA = "0x18375F990", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3886C20", Offset = "0x3885C20", VA = "0x183886C20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x251FCC0", Offset = "0x251ECC0", VA = "0x18251FCC0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x251DD30", Offset = "0x251CD30", VA = "0x18251DD30")]
		private int BNNJFBEALBA(DynamicBuffer<ChildrenData> HFOEOPEIJAG, Entity GDNDJKDEKFN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x251FA00", Offset = "0x251EA00", VA = "0x18251FA00")]
		private void PJEKLNMEHAM(Entity IMJDLKJJPPH, Entity KIMLMENBIDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x6F56B0", Offset = "0x6F46B0", VA = "0x1806F56B0", Slot = "14")]
		protected virtual EntityQueryDesc HNGMCOJHLNH(EntityQueryDesc PMKDKHNEPAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6F56B0", Offset = "0x6F46B0", VA = "0x1806F56B0", Slot = "15")]
		protected virtual EntityQueryDesc CPFDHCLBLCN(EntityQueryDesc PMKDKHNEPAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F56B0", Offset = "0x6F46B0", VA = "0x1806F56B0", Slot = "16")]
		protected virtual EntityQueryDesc GNOHAGLAAJO(EntityQueryDesc PMKDKHNEPAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc ECDEGGLBPCN(EntityQueryDesc PMKDKHNEPAL);

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x251F6A0", Offset = "0x251E6A0", VA = "0x18251F6A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x251F240", Offset = "0x251E240", VA = "0x18251F240")]
		private void OMACKCBCCFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x251DFF0", Offset = "0x251CFF0", VA = "0x18251DFF0")]
		private void CMPEAIGIHIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x251E1C0", Offset = "0x251D1C0", VA = "0x18251E1C0")]
		private void EHAKKPDMDCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x251EBA0", Offset = "0x251DBA0", VA = "0x18251EBA0")]
		private void FCPKINFPEME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x251F940", Offset = "0x251E940", VA = "0x18251F940", Slot = "13")]
		protected override JobHandle OnUpdate(JobHandle FMEBGAACPOB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x240E760", Offset = "0x240D760", VA = "0x18240E760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2D450E0", Offset = "0x2D440E0", VA = "0x182D450E0")]
			public PLIHBBKDBFD(NativeList<Entity> KEHLENFDCJE, NativeList<Entity> DGDKNCLPAEG, JobHandle IHONPLJMIOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x2D44C90", Offset = "0x2D43C90", VA = "0x182D44C90")]
			public JobHandle OFEOJIGNMCE(JobHandle EKODEGLIDHA)
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x2D44EB0", Offset = "0x2D43EB0", VA = "0x182D44EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x30C2820", Offset = "0x30C1820", VA = "0x1830C2820", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x30C3D70", Offset = "0x30C2D70", VA = "0x1830C3D70")]
			private void KPEEHPJBBAJ(Entity GDNDJKDEKFN, bool LOMMFNILBKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x30C3B50", Offset = "0x30C2B50", VA = "0x1830C3B50")]
			private void IEMDEIKFBPJ(Entity GDNDJKDEKFN, bool LOMMFNILBKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x30C2190", Offset = "0x30C1190", VA = "0x1830C2190")]
			public PLIHBBKDBFD ADANPDDFNGI(NativeArray<Entity> LCOODLIGMCJ, JobHandle EKODEGLIDHA)
			{
				return default(PLIHBBKDBFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x30C2F40", Offset = "0x30C1F40", VA = "0x1830C2F40")]
			public PLIHBBKDBFD FHCDKABJEBP(NativeArray<Entity> LCOODLIGMCJ, JobHandle EKODEGLIDHA)
			{
				return default(PLIHBBKDBFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x30C2550", Offset = "0x30C1550", VA = "0x1830C2550")]
			public PLIHBBKDBFD EKGOIPDCIPE(NativeList<GGKPENPPBHO> PIJDNOPJENO, JobHandle EKODEGLIDHA)
			{
				return default(PLIHBBKDBFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x30C4020", Offset = "0x30C3020", VA = "0x1830C4020")]
			public PLIHBBKDBFD PNAIEIMLFDF(NativeList<GGKPENPPBHO> PIJDNOPJENO, JobHandle EKODEGLIDHA)
			{
				return default(PLIHBBKDBFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x30C2370", Offset = "0x30C1370", VA = "0x1830C2370")]
			public PLIHBBKDBFD DBBFKBJAENH(NativeList<OJEIBILPNMC> PIJDNOPJENO, JobHandle EKODEGLIDHA)
			{
				return default(PLIHBBKDBFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0x25923A0", Offset = "0x25913A0", VA = "0x1825923A0")]
			private PLIHBBKDBFD GAOABOOJKCH<T>(NativeList<T> PIJDNOPJENO, int CPGBPGNKOAH, int IBKDMEGGOGM, DLNFDKEMDMH PDFIDNNGANB, JobHandle EKODEGLIDHA) where T : struct
			{
				return default(PLIHBBKDBFD);
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x30C3690", Offset = "0x30C2690", VA = "0x1830C3690")]
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
		[Cpp2IlInjected.Address(RVA = "0x413C130", Offset = "0x413B130", VA = "0x18413C130", Slot = "14")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x413CA70", Offset = "0x413BA70", VA = "0x18413CA70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x413D880", Offset = "0x413C880", VA = "0x18413D880", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x413EE40", Offset = "0x413DE40", VA = "0x18413EE40")]
		private void PPEFKLBLEJF(NativeArray<Entity> PIJDNOPJENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x413C9B0", Offset = "0x413B9B0", VA = "0x18413C9B0")]
		private void IFFMANHLFMO(NativeArray<Entity> PIJDNOPJENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x413C2F0", Offset = "0x413B2F0", VA = "0x18413C2F0")]
		private void BHMPPLENPHJ(PLIHBBKDBFD HKCGLMCFMHB, string EGPAKIILAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x413C550", Offset = "0x413B550", VA = "0x18413C550")]
		private void BHMPPLENPHJ(global::AGEGIHAKIMB<Entity> LBDMCKHPFFG, string EGPAKIILAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x413C750", Offset = "0x413B750", VA = "0x18413C750")]
		private void CCBOBIGAACF(PLIHBBKDBFD HKCGLMCFMHB, string EGPAKIILAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x413C8B0", Offset = "0x413B8B0", VA = "0x18413C8B0")]
		private void CCBOBIGAACF(global::AGEGIHAKIMB<Entity> LBDMCKHPFFG, string EGPAKIILAAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x413CA20", Offset = "0x413BA20", VA = "0x18413CA20")]
		private bool KBPAJCHBMMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x413EF20", Offset = "0x413DF20", VA = "0x18413EF20")]
		protected PropagateTagsBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x240E760", Offset = "0x240D760", VA = "0x18240E760", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7B9B0", Offset = "0x2C7A9B0", VA = "0x182C7B9B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public OMOFIKPLEEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED09A0", Offset = "0x4ECF9A0", VA = "0x184ED09A0")]
			public void GPJBIMHIEAK(HPDKFCJJFJI AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x4ED09B0", Offset = "0x4ECF9B0", VA = "0x184ED09B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ED27A0", Offset = "0x4ED17A0", VA = "0x184ED27A0")]
		internal void BOGFKFCHEFD(Entity GHAPGMJOMOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x4ED0930", Offset = "0x4ECF930", VA = "0x184ED0930", Slot = "5")]
		public void ReadFromDisplayClass(ref OMOFIKPLEEM PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x4ED0960", Offset = "0x4ECF960", VA = "0x184ED0960", Slot = "6")]
		public void WriteToDisplayClass(ref OMOFIKPLEEM PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2990", Offset = "0x4ED1990", VA = "0x184ED2990", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2920", Offset = "0x4ED1920", VA = "0x184ED2920")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, ref ELDBLNNEBPJ.APJDBAJNKNP FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x4ED29E0", Offset = "0x4ED19E0", VA = "0x184ED29E0")]
		public void GPJBIMHIEAK(HPDKFCJJFJI AKIOJOCDPLG, ref OMOFIKPLEEM PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x4ED28B0", Offset = "0x4ED18B0", VA = "0x184ED28B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C71F80", Offset = "0x2C70F80", VA = "0x182C71F80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x2C71F20", Offset = "0x2C70F20", VA = "0x182C71F20", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x2C71FE0", Offset = "0x2C70FE0", VA = "0x182C71FE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public HPDKFCJJFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x2C71700", Offset = "0x2C70700", VA = "0x182C71700", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x2C71D50", Offset = "0x2C70D50", VA = "0x182C71D50")]
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
	[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x649000", VA = "0x18064A000")]
	public static IDMLNLEIDAE EDIIAGKPKGG(in IBNEEFGBPPM JOMMFCFJBEK)
	{
		return default(IDMLNLEIDAE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x649000", VA = "0x18064A000")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C7E530", Offset = "0x2C7D530", VA = "0x182C7E530", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E570", Offset = "0x2C7D570", VA = "0x182C7E570", Slot = "10")]
	public void FKDGDLIKCPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x2C7ED00", Offset = "0x2C7DD00", VA = "0x182C7ED00", Slot = "11")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E430", Offset = "0x2C7D430", VA = "0x182C7E430", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EF00", Offset = "0x2C7DF00", VA = "0x182C7EF00", Slot = "5")]
	public IBNEEFGBPPM PAHAANGGJJI(Entity GDNDJKDEKFN)
	{
		return default(IBNEEFGBPPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F050", Offset = "0x2C7E050", VA = "0x182C7F050", Slot = "6")]
	public void PCNBCAJFMIC(NativeArray<IBNEEFGBPPM> ICIEPJPHBOB, NativeArray<MFPGKDHMCFI> ANAGHLFLMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x2C7DF60", Offset = "0x2C7CF60", VA = "0x182C7DF60", Slot = "7")]
	public void ACHJKEDIMPM(IBNEEFGBPPM BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EE60", Offset = "0x2C7DE60", VA = "0x182C7EE60", Slot = "8")]
	public bool NFOGJKLJKKE(IBNEEFGBPPM BLIPNDKFLPL, out Collider DMJMICMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E720", Offset = "0x2C7D720", VA = "0x182C7E720")]
	public bool GGAAJFEABCL(in float3 JMICGAIDJIF, in float3 LBPFPACOALI, float EIEEMLEJCAI, Allocator EGJIMBMGFGA, out NativeArray<Entity> NGCJEBOBKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E150", Offset = "0x2C7D150", VA = "0x182C7E150")]
	private void BLBEJGIBJGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x88B660", Offset = "0x88A660", VA = "0x18088B660")]
	private void BIHBJPIFJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EDE0", Offset = "0x2C7DDE0", VA = "0x182C7EDE0")]
	private void MFKOOFLJGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0xCC71F0", Offset = "0xCC61F0", VA = "0x180CC71F0")]
	private void JBNAJBLHCDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E030", Offset = "0x2C7D030", VA = "0x182C7E030")]
	private BoxCollider ANKGFMFFIEO(Entity GDNDJKDEKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EA30", Offset = "0x2C7DA30", VA = "0x182C7EA30")]
	private void GKNIKNGMGDH(BoxCollider OEKADPILPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x2C7ECC0", Offset = "0x2C7DCC0", VA = "0x182C7ECC0")]
	[Conditional("UNITY_EDITOR")]
	private void LAAPHNFLFAA(GameObject HBGIADIFHEC, Entity GDNDJKDEKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E1A0", Offset = "0x2C7D1A0", VA = "0x182C7E1A0")]
	private void DAKKNINFBDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E320", Offset = "0x2C7D320", VA = "0x182C7E320")]
	private void DLBKIEKIJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EAB0", Offset = "0x2C7DAB0", VA = "0x182C7EAB0")]
	private void KNDEGONPJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EE30", Offset = "0x2C7DE30", VA = "0x182C7EE30")]
	private void MMFJOFPJHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x2C7EDD0", Offset = "0x2C7DDD0", VA = "0x182C7EDD0")]
	private void MDKMOOKPCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x2C7E6E0", Offset = "0x2C7D6E0", VA = "0x182C7E6E0")]
	private void GCENPLDMDGE(Scene HOHHAKDFJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public MNFCGOIENPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F260", Offset = "0x2C7E260", VA = "0x182C7F260", Slot = "9")]
	private bool PMPNKFEGBLI(in float3 JMICGAIDJIF, in float3 LBPFPACOALI, float EIEEMLEJCAI, Allocator EGJIMBMGFGA, out NativeArray<Entity> NGCJEBOBKNP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class KMMBELOOFGA : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
	public KMMBELOOFGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public PHJFFJHFMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED65E0", Offset = "0x4ED55E0", VA = "0x184ED65E0")]
			public void GPJBIMHIEAK(KAEOPFLFJEH AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x4ED6640", Offset = "0x4ED5640", VA = "0x184ED6640")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ED05E0", Offset = "0x4ECF5E0", VA = "0x184ED05E0")]
		internal void BOGFKFCHEFD(Entity GHAPGMJOMOM, IDMLNLEIDAE BOICHCFMALB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x4ED0930", Offset = "0x4ECF930", VA = "0x184ED0930", Slot = "5")]
		public void ReadFromDisplayClass(ref PHJFFJHFMFB PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x4ED0960", Offset = "0x4ECF960", VA = "0x184ED0960", Slot = "6")]
		public void WriteToDisplayClass(ref PHJFFJHFMFB PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x4ED0800", Offset = "0x4ECF800", VA = "0x184ED0800", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x4ED0750", Offset = "0x4ECF750", VA = "0x184ED0750")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, ref PJMBCHMLEMJ.DKOJIJFNPNA FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x4ED08A0", Offset = "0x4ECF8A0", VA = "0x184ED08A0")]
		public void GPJBIMHIEAK(KAEOPFLFJEH AKIOJOCDPLG, ref PHJFFJHFMFB PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x4ED06E0", Offset = "0x4ECF6E0", VA = "0x184ED06E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C762F0", Offset = "0x2C752F0", VA = "0x182C762F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x2C761B0", Offset = "0x2C751B0", VA = "0x182C761B0", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x2C76350", Offset = "0x2C75350", VA = "0x182C76350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public KAEOPFLFJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x2C76210", Offset = "0x2C75210", VA = "0x182C76210", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x2C75FE0", Offset = "0x2C74FE0", VA = "0x182C75FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED0D90", Offset = "0x4ECFD90", VA = "0x184ED0D90")]
			public FENENALMBMP(int JAFEKEGLGFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0D10", Offset = "0x4ECFD10", VA = "0x184ED0D10", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED6440", Offset = "0x4ED5440", VA = "0x184ED6440", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED3F50", Offset = "0x4ED2F50", VA = "0x184ED3F50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x29C0A60", Offset = "0x29BFA60", VA = "0x1829C0A60", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x29C0C10", Offset = "0x29BFC10", VA = "0x1829C0C10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x29C0A20", Offset = "0x29BFA20", VA = "0x1829C0A20", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x29C0ED0", Offset = "0x29BFED0", VA = "0x1829C0ED0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x29C0AC0", Offset = "0x29BFAC0", VA = "0x1829C0AC0")]
		private void LPFGPFPBOHH(EntityQuery PMKDKHNEPAL, out (global::PEOLEGIGBJF<IDMLNLEIDAE> handles, global::PEOLEGIGBJF<MFPGKDHMCFI> bounds) PJDKPCLOECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x29C07C0", Offset = "0x29BF7C0", VA = "0x1829C07C0")]
		private void HKDANINOPDF((global::PEOLEGIGBJF<IDMLNLEIDAE> handles, global::PEOLEGIGBJF<MFPGKDHMCFI> bounds) PJDKPCLOECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x29C0A20", Offset = "0x29BFA20", VA = "0x1829C0A20")]
		private void IJOAMAMKDGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x29C00C0", Offset = "0x29BF0C0", VA = "0x1829C00C0")]
		private void BFDLIFNPFFM(EntityQuery PMKDKHNEPAL, out (global::PEOLEGIGBJF<Entity> entities, global::PEOLEGIGBJF<IDMLNLEIDAE> handles) PJDKPCLOECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x29C0240", Offset = "0x29BF240", VA = "0x1829C0240")]
		private void DLAIGFGFFJC((global::PEOLEGIGBJF<Entity> entities, global::PEOLEGIGBJF<IDMLNLEIDAE> handles) PJDKPCLOECB, FENENALMBMP JCDDFAMPICO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x29C0530", Offset = "0x29BF530", VA = "0x1829C0530")]
		private JobHandle DMNOGAMMBPB(FENENALMBMP JCDDFAMPICO, ComponentDataFromEntity<WorldPoseData> JJDCLONBKIB, ComponentDataFromEntity<WorldUniformScaleData> PKGGJHMEDFG, ComponentDataFromEntity<WorldDeformableScaleData> EDNLDBCBJPN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x29C0690", Offset = "0x29BF690", VA = "0x1829C0690")]
		private JobHandle ENHGELBMJHP(FENENALMBMP JCDDFAMPICO, ComponentDataFromEntity<WorldPoseData> JJDCLONBKIB, ComponentDataFromEntity<WorldUniformScaleData> PKGGJHMEDFG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CF7A90", Offset = "0x2CF6A90", VA = "0x182CF7A90", Slot = "5")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7610", Offset = "0x2CF6610", VA = "0x182CF7610")]
	public bool GGAAJFEABCL(in float3 JMICGAIDJIF, in float3 LBPFPACOALI, float EIEEMLEJCAI, out ELNKPLJCKEF KJPODJIHEGN, out Entity LPCMCOJAFCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x2CF74E0", Offset = "0x2CF64E0", VA = "0x182CF74E0")]
	public static bool BFCJNMPEBDG(in Span<ELNKPLJCKEF> EAECMEIPPHA, float EIEEMLEJCAI, out int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x2CF75E0", Offset = "0x2CF65E0", VA = "0x182CF75E0")]
	public static float CDLABNPDFBE(float BPJEFFCEPEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public EBCIOEBHGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7B00", Offset = "0x2CF6B00", VA = "0x182CF7B00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED25F0", Offset = "0x4ED15F0", VA = "0x184ED25F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED45C0", Offset = "0x4ED35C0", VA = "0x184ED45C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x29CC030", Offset = "0x29CB030", VA = "0x1829CC030", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x29CC240", Offset = "0x29CB240", VA = "0x1829CC240", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x29CBF50", Offset = "0x29CAF50", VA = "0x1829CBF50")]
		private JobHandle OJIPHNJJEFE(global::PEOLEGIGBJF<Entity> KPAFOBEJBIN, int HOPGLJCPGGA, JobHandle EKODEGLIDHA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x29CBDA0", Offset = "0x29CADA0", VA = "0x1829CBDA0")]
		private JobHandle OJIPHNJJEFE(NativeArray<Entity> GPFDPCJJKGJ, int HOPGLJCPGGA, [Optional] JobHandle EKODEGLIDHA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x29CBD20", Offset = "0x29CAD20", VA = "0x1829CBD20")]
		private global::PEOLEGIGBJF<Entity> MIGHFPJCFAE(EntityQuery PMKDKHNEPAL)
		{
			return default(global::PEOLEGIGBJF<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x29CB2B0", Offset = "0x29CA2B0", VA = "0x1829CB2B0")]
		private (global::AGEGIHAKIMB<Entity>, global::AGEGIHAKIMB<Entity>) AFLPFBGGFBH(global::PEOLEGIGBJF<Entity> KHLMCMLDFIE)
		{
			return default((global::AGEGIHAKIMB<Entity>, global::AGEGIHAKIMB<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x29CBCA0", Offset = "0x29CACA0", VA = "0x1829CBCA0")]
		private void MBKNCEKEJIL(out NativeArray<Entity> NGCJEBOBKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x29CBC10", Offset = "0x29CAC10", VA = "0x1829CBC10")]
		private void LKGLKMKJHGL(NativeList<Entity> NGCJEBOBKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x29CBB40", Offset = "0x29CAB40", VA = "0x1829CBB40")]
		private void LKGLKMKJHGL(NativeArray<Entity> NGCJEBOBKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x29CBA20", Offset = "0x29CAA20", VA = "0x1829CBA20")]
		private void LHJNELPBCAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		private static void EBHGOLDEGAA(int JEIMODDJOCE, int GLNIAACHEHF, int FFLDIAIPIKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x29CB700", Offset = "0x29CA700", VA = "0x1829CB700")]
		private static MFPGKDHMCFI CIJFHLCJMBF(NativeArray<Entity> NKOIHOOEHFE, ComponentDataFromEntity<SplinePointData> OMACNOCELDO)
		{
			return default(MFPGKDHMCFI);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BCF20", Offset = "0x29BBF20", VA = "0x1829BCF20", Slot = "4")]
		public void Execute(int MMABPPDCBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x29BD8D0", Offset = "0x29BC8D0", VA = "0x1829BD8D0")]
		private static float3 NGFPGGJDABP(in float4x4 JKFNDOABIPP, in float3 OGGODOHJPHN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x29BD9A0", Offset = "0x29BC9A0", VA = "0x1829BD9A0")]
		private static float3 OCGIPJNCGAF(in float4x4 JKFNDOABIPP, in float3 BOMCMOAJNIE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x29BDB60", Offset = "0x29BCB60", VA = "0x1829BDB60")]
		private static float3 OEHBHLMCAIF(in float4x4 JKFNDOABIPP, in float3 OGGODOHJPHN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x29BCD00", Offset = "0x29BBD00", VA = "0x1829BCD00")]
		private static float3 BGHHFPPHLGI(in float4x4 JKFNDOABIPP, in float3 BOMCMOAJNIE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x29BCA00", Offset = "0x29BBA00", VA = "0x1829BCA00")]
		private bool APPBOLADGGN(in float3 JMICGAIDJIF, in float3 LBPFPACOALI, in NativeArray<Entity> FIPGEGOGNLK, out float3 KJPODJIHEGN, out float3 DBGMAHNILBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x29BD200", Offset = "0x29BC200", VA = "0x1829BD200")]
		public static bool MBDFFGCJNHD(in float3 MELGFKBNLMO, in float3 BIGIDDNIBGE, in float3 KDKFAFCCHCH, in float3 FOLNAAPJPGP, float AOJMBOKLHJC, float EGNBHFPBJNC, out float HLNBIKMPIPM, out float3 JBBGLCJIFHA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private EntityManager JGGNCNMICJO;

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x2CEDC90", Offset = "0x2CECC90", VA = "0x182CEDC90", Slot = "5")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x2CEDA50", Offset = "0x2CECA50", VA = "0x182CEDA50")]
	public void GGAAJFEABCL(in NativeArray<Entity> NGCJEBOBKNP, in float3 JMICGAIDJIF, in float3 LBPFPACOALI, in NativeArray<ELNKPLJCKEF> PKKBALIENCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BNFDAOEIPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x2CEDA50", Offset = "0x2CECA50", VA = "0x182CEDA50", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF72E0", Offset = "0x2CF62E0", VA = "0x182CF72E0")]
		public bool PNGACAFMNEF(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7140", Offset = "0x2CF6140", VA = "0x182CF7140", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x2CF71D0", Offset = "0x2CF61D0", VA = "0x182CF71D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x120F8B0", Offset = "0x120E8B0", VA = "0x18120F8B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFCEC0", Offset = "0x2CFBEC0", VA = "0x182CFCEC0", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x2CFCFA0", Offset = "0x2CFBFA0", VA = "0x182CFCFA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		private void KCIGNLPJGEP(Entity GDNDJKDEKFN, DDAOHKAFOIC LNNGKIMHKAI, MIEGLNNJAGB PMOKKAEPEEN, FLFHBOLCLFF LNFBHHADIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		protected EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x29C6240", Offset = "0x29C5240", VA = "0x1829C6240", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x29C62C0", Offset = "0x29C52C0", VA = "0x1829C62C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		protected PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CF6D70", Offset = "0x2CF5D70", VA = "0x182CF6D70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6F70", Offset = "0x2CF5F70", VA = "0x182CF6F70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF70C0", Offset = "0x2CF60C0", VA = "0x182CF70C0")]
	protected DOFCILIHAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C77200", Offset = "0x2C76200", VA = "0x182C77200")]
	public static Entity EDIIAGKPKGG(KGPNPNHINEF PJDKPCLOECB)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x2C77200", Offset = "0x2C76200", VA = "0x182C77200")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFFE20", Offset = "0x2CFEE20", VA = "0x182CFFE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFF40", Offset = "0x2CFEF40", VA = "0x182CFFF40")]
	public GEPFMJKLAPN(ComponentType FMNFFKMHMLD, NativeList<int> JNGPJPKCCHN, NativeList<int> COJCMOGPEEH, NativeArray<Entity> NGCJEBOBKNP, NativeArray<Entity> OCBNOMJEMMJ, NativeArray<byte> NOPNDJAEHGP, NativeArray<byte> IMLJHLOOKFM, int BEDIBCAKPCI, int ADALAGNIINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFC10", Offset = "0x2CFEC10", VA = "0x182CFFC10")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CFFEA0", Offset = "0x2CFEEA0", VA = "0x182CFFEA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CFFEF0", Offset = "0x2CFEEF0", VA = "0x182CFFEF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CFFD40", Offset = "0x2CFED40", VA = "0x182CFFD40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7BB00", Offset = "0x2C7AB00", VA = "0x182C7BB00")]
	public MHOKJGPKENN(ComponentType FMNFFKMHMLD, int BEDIBCAKPCI, int ADALAGNIINO, EntityQuery PMKDKHNEPAL, NativeArray<CIIDHNJHMHD> IEBMFIFBGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BAB0", Offset = "0x2C7AAB0", VA = "0x182C7BAB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x66B050", Offset = "0x66A050", VA = "0x18066B050")]
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
	[Cpp2IlInjected.Address(RVA = "0x66B050", Offset = "0x66A050", VA = "0x18066B050")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFF860", Offset = "0x2CFE860", VA = "0x182CFF860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public FHCGLCCCIJI LMIDIPHLOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE20", Offset = "0x6FAE20", VA = "0x1806FBE20")]
		get
		{
			return default(FHCGLCCCIJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF870", Offset = "0x2CFE870", VA = "0x182CFF870")]
	public IKKMGBAJNEB IIBHGDOLJCO(Type BCFKLEGAMEO)
	{
		return default(IKKMGBAJNEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF770", Offset = "0x2CFE770", VA = "0x182CFF770")]
	public IKKMGBAJNEB FEHNHMJOJON(Type BCFKLEGAMEO)
	{
		return default(IKKMGBAJNEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x2B630D0", Offset = "0x2B620D0", VA = "0x182B630D0")]
	public T IIBHGDOLJCO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x2B630B0", Offset = "0x2B620B0", VA = "0x182B630B0")]
	public T FEHNHMJOJON<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF960", Offset = "0x2CFE960", VA = "0x182CFF960")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C84AD0", Offset = "0x2C83AD0", VA = "0x182C84AD0")]
		get
		{
			return default(MHOKJGPKENN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C84720", Offset = "0x2C83720", VA = "0x182C84720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C84F60", Offset = "0x2C83F60", VA = "0x182C84F60")]
	public OKAILPBNPJF(OMCLDCKMHNM PDJMGPJCDFP, JJLACLCEPON MNIOACBCBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x2C844F0", Offset = "0x2C834F0", VA = "0x182C844F0")]
	public Dictionary<ComponentType, MHOKJGPKENN>.Enumerator CDEDLLPMOKO()
	{
		return default(Dictionary<ComponentType, MHOKJGPKENN>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C84580", Offset = "0x2C83580", VA = "0x182C84580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x2C84B60", Offset = "0x2C83B60", VA = "0x182C84B60")]
	private void MBAJOFAPHKB(IEnumerable<CMKIKNDBPFM> ABICEFOHPIC, EntityManager JGGNCNMICJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x2C84770", Offset = "0x2C83770", VA = "0x182C84770")]
	private static int FKCJBAGLAPD(CMKIKNDBPFM INDELOEGBGL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C84820", Offset = "0x2C83820", VA = "0x182C84820")]
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
			[Cpp2IlInjected.Address(RVA = "0x29C4360", Offset = "0x29C3360", VA = "0x1829C4360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		private World LKMEEGFGGKG
		{
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0x29C41B0", Offset = "0x29C31B0", VA = "0x1829C41B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		private OKAILPBNPJF GGFMIPHFNNL
		{
			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		private MLCOIGILHDE NPIDMMELPDF
		{
			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x6606F0", Offset = "0x65F6F0", VA = "0x1806606F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private NativeMultiHashMap<Entity, FLFHBOLCLFF> KEFNABIAMAO
		{
			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0x10E7D70", Offset = "0x10E6D70", VA = "0x1810E7D70", Slot = "9")]
			get
			{
				return default(NativeMultiHashMap<Entity, FLFHBOLCLFF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		private JobHandle DKBIMIJICAM
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x10CD1E0", Offset = "0x10CC1E0", VA = "0x1810CD1E0", Slot = "10")]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x10CBC50", Offset = "0x10CAC50", VA = "0x1810CBC50", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		private World PKHCBPAJIMF
		{
			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x29C4E00", Offset = "0x29C3E00", VA = "0x1829C4E00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x29C48D0", Offset = "0x29C38D0", VA = "0x1829C48D0", Slot = "13")]
		private void LNHPLFCADHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x29C43B0", Offset = "0x29C33B0", VA = "0x1829C43B0", Slot = "12")]
		private void HCACMDCCGFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x29C4690", Offset = "0x29C3690", VA = "0x1829C4690", Slot = "14")]
		private void HKFLMBEPPIC(ComponentType FMNFFKMHMLD, in GEPFMJKLAPN BPBGAEPNHDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x29C4780", Offset = "0x29C3780", VA = "0x1829C4780", Slot = "15")]
		private bool IKBOOICGECC(IOFCPOJDKFL OHBBEKBPFPH, out Entity LGELJKPCDJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x29C4830", Offset = "0x29C3830", VA = "0x1829C4830", Slot = "17")]
		private bool LMGNJBPDKCD(out NativeArray<int> DJLHOHAIFKO, Allocator EGJIMBMGFGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x29C4040", Offset = "0x29C3040", VA = "0x1829C4040", Slot = "18")]
		private bool BGDGPFHFFJA(ComponentType FMNFFKMHMLD, out GEPFMJKLAPN EAOLJCKGJEI, out MHOKJGPKENN BDIHABFLOBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x29C3F10", Offset = "0x29C2F10", VA = "0x1829C3F10", Slot = "19")]
		private bool BGDGPFHFFJA(ComponentType FMNFFKMHMLD, out GEPFMJKLAPN EAOLJCKGJEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x29C4920", Offset = "0x29C3920", VA = "0x1829C4920", Slot = "20")]
		private GEPFMJKLAPN MMNACAAKGIF(ComponentType FMNFFKMHMLD)
		{
			return default(GEPFMJKLAPN);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x29C48E0", Offset = "0x29C38E0", VA = "0x1829C48E0", Slot = "21")]
		private OPNHKCFKNGE MBDELMDDMGO()
		{
			return default(OPNHKCFKNGE);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x29C4370", Offset = "0x29C3370", VA = "0x1829C4370", Slot = "22")]
		private void GFMHCDIDEFN(JobHandle IHONPLJMIOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x29C47A0", Offset = "0x29C37A0", VA = "0x1829C47A0", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x29C3CD0", Offset = "0x29C2CD0", VA = "0x1829C3CD0", Slot = "5")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x29C4210", Offset = "0x29C3210", VA = "0x1829C4210", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x29C4B50", Offset = "0x29C3B50", VA = "0x1829C4B50")]
		private void OJEEPLKEKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x29C4470", Offset = "0x29C3470", VA = "0x1829C4470")]
		private bool HEDDCKDINPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x29C4A10", Offset = "0x29C3A10", VA = "0x1829C4A10")]
		private int NBANEAJIPJL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x29C4EB0", Offset = "0x29C3EB0", VA = "0x1829C4EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD84240", Offset = "0xD83240", VA = "0x180D84240", Slot = "4")]
			get
			{
				return default(FLFHBOLCLFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x4ED4A40", Offset = "0x4ED3A40", VA = "0x184ED4A40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4A90", Offset = "0x4ED3A90", VA = "0x184ED4A90")]
		internal NDLMGBFFKBD(NativeMultiHashMap<Entity, FLFHBOLCLFF> OOOLCIHHFKM, Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4830", Offset = "0x4ED3830", VA = "0x184ED4830", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4800", Offset = "0x4ED3800", VA = "0x184ED4800")]
		public NDLMGBFFKBD CDEDLLPMOKO()
		{
			return default(NDLMGBFFKBD);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4900", Offset = "0x4ED3900", VA = "0x184ED4900", Slot = "9")]
		private IEnumerator<FLFHBOLCLFF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x4ED49A0", Offset = "0x4ED39A0", VA = "0x184ED49A0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C85A30", Offset = "0x2C84A30", VA = "0x182C85A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool KJFIOINAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x2C856C0", Offset = "0x2C846C0", VA = "0x182C856C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E820", Offset = "0x1F7D820", VA = "0x181F7E820")]
	public OPNHKCFKNGE(LFKKHIHIDMG JCLIGOJKKCI, JobHandle GLCICEKBEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C85B20", Offset = "0x2C84B20", VA = "0x182C85B20")]
	public bool OKEIANICLIC(Allocator EGJIMBMGFGA, out NativeKeyValueArrays<Entity, FLFHBOLCLFF> BBELMPNHPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x2C858C0", Offset = "0x2C848C0", VA = "0x182C858C0")]
	public bool NAHONCENGKE(Allocator EGJIMBMGFGA, out (NativeArray<Entity> entities, int uniqueCount) BBELMPNHPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x2C857A0", Offset = "0x2C847A0", VA = "0x182C857A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C7CF10", Offset = "0x2C7BF10", VA = "0x182C7CF10")]
		get
		{
			return default(MHOKJGPKENN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C7CED0", Offset = "0x2C7BED0", VA = "0x182C7CED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D2B0", Offset = "0x2C7C2B0", VA = "0x182C7D2B0")]
	public MLCOIGILHDE(OKAILPBNPJF DBNEIDMAJLK, OMCLDCKMHNM PDJMGPJCDFP, JJLACLCEPON MNIOACBCBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CCE0", Offset = "0x2C7BCE0", VA = "0x182C7CCE0")]
	public List<MHOKJGPKENN>.Enumerator CDEDLLPMOKO()
	{
		return default(List<MHOKJGPKENN>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CD60", Offset = "0x2C7BD60", VA = "0x182C7CD60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C7CFA0", Offset = "0x2C7BFA0", VA = "0x182C7CFA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C73B40", Offset = "0x2C72B40", VA = "0x182C73B40")]
	public IDOCKOGKDOB(ObjectPrefabCreationService KBJJNECALFP, OMCLDCKMHNM PDJMGPJCDFP, JJLACLCEPON MNIOACBCBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C72DD0", Offset = "0x2C71DD0", VA = "0x182C72DD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C73AE0", Offset = "0x2C72AE0", VA = "0x182C73AE0")]
	public bool PJAFDPACMIK(IOFCPOJDKFL OHBBEKBPFPH, out Entity LGELJKPCDJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C721A0", Offset = "0x2C711A0", VA = "0x182C721A0")]
	private void DBMCOGHFDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C73300", Offset = "0x2C72300", VA = "0x182C73300")]
	private EntityArchetype JOLOAEDIPHA(EntityArchetype PDKMCLNBPNB)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x2C729A0", Offset = "0x2C719A0", VA = "0x182C729A0")]
	public static void DLGLJJIPLNL(EntityManager NLDNPCFEGJC, EntityManager KGCHJKNHGKL, NativeArray<Entity> ALFIJBPBFIH, NativeArray<EntityArchetype> BHFEBKMHAPN, [Optional] NativeArray<Entity> BLAPEJKCKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C73830", Offset = "0x2C72830", VA = "0x182C73830")]
	[Conditional("DEBUG_BUILD")]
	private static void OIONCGDOGOF(NativeArray<EntityArchetype> KEFILCBKOCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C72FE0", Offset = "0x2C71FE0", VA = "0x182C72FE0")]
	private static string GCKBFFIBNHO(EntityArchetype CEMLDGMJKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C739A0", Offset = "0x2C729A0", VA = "0x182C739A0")]
	[CompilerGenerated]
	internal static void OKAPINLPJBD(ref Span<ComponentType> NIHMFMJOPAE, ComponentType CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x2C72E30", Offset = "0x2C71E30", VA = "0x182C72E30")]
	[CompilerGenerated]
	internal static void FPFNHBODLJH(Span<ComponentType> KPAFOBEJBIN, ref Span<ComponentType> NIHMFMJOPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x2C73220", Offset = "0x2C72220", VA = "0x182C73220")]
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
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
			public GIBINLKKKON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x29BC560", Offset = "0x29BB560", VA = "0x1829BC560")]
			internal void BOGFKFCHEFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x29BC770", Offset = "0x29BB770", VA = "0x1829BC770", Slot = "5")]
			public void ReadFromDisplayClass(ref GIBINLKKKON PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x29BC740", Offset = "0x29BB740", VA = "0x1829BC740", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x29BC750", Offset = "0x29BB750", VA = "0x1829BC750")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CE93A0", Offset = "0x2CE83A0", VA = "0x182CE93A0")]
		public void ECFFKMLILHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9720", Offset = "0x2CE8720", VA = "0x182CE9720", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x2CE9780", Offset = "0x2CE8780", VA = "0x182CE9780", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x2CE93B0", Offset = "0x2CE83B0", VA = "0x182CE93B0")]
		private bool FLCIAJNHNOO(JobHandle EKODEGLIDHA, int NDBJIKBMPCB, out JobHandle LPEFOLIJFEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		protected ApplyPropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x29BBE60", Offset = "0x29BAE60", VA = "0x1829BBE60", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0x29BBDD0", Offset = "0x29BADD0", VA = "0x1829BBDD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x29BDFA0", Offset = "0x29BCFA0", VA = "0x1829BDFA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x29B9F50", Offset = "0x29B8F50", VA = "0x1829B9F50", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x29B9CD0", Offset = "0x29B8CD0", VA = "0x1829B9CD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CEF530", Offset = "0x2CEE530", VA = "0x182CEF530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2CEFEE0", Offset = "0x2CEEEE0", VA = "0x182CEFEE0")]
		internal MHOKJGPKENN GPHLMPMKLLJ(ComponentType FMNFFKMHMLD)
		{
			return default(MHOKJGPKENN);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2CF0BA0", Offset = "0x2CEFBA0", VA = "0x182CF0BA0", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "15")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1FF0", Offset = "0x2CF0FF0", VA = "0x182CF1FF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2170", Offset = "0x2CF1170", VA = "0x182CF2170", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2120", Offset = "0x2CF1120", VA = "0x182CF2120", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x2CF06C0", Offset = "0x2CEF6C0", VA = "0x182CF06C0")]
		private void JMIIHPPLIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x2CEFE20", Offset = "0x2CEEE20", VA = "0x182CEFE20")]
		private void ECGFNDMEGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x2CEF580", Offset = "0x2CEE580", VA = "0x182CEF580")]
		internal void CJDKKFALLPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1C30", Offset = "0x2CF0C30", VA = "0x182CF1C30")]
		private void OIOIFCMFJEB(NativeArray<Entity> ALFIJBPBFIH, NativeArray<RRObjectPrefabData> FDKHKDLLEGK, ref NativeArray<Entity> LLAFNNINMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x2CF0D00", Offset = "0x2CEFD00", VA = "0x182CF0D00")]
		internal void OALIOACIMFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x2CEFF80", Offset = "0x2CEEF80", VA = "0x182CEFF80")]
		internal void IGDEMOEKGLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1940", Offset = "0x2CF0940", VA = "0x182CF1940")]
		private void OHLPAGMHALJ(MHOKJGPKENN BDIHABFLOBJ, bool AEGHLAGJCCI, ref JobHandle COMJCNIFKCJ, ref JobHandle DBJKPEJBIIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1910", Offset = "0x2CF0910", VA = "0x182CF1910")]
		internal bool OGODAMEOCPM(in MHOKJGPKENN CHHHDNBJJIO, out JobHandle BLIPNDKFLPL, out GEPFMJKLAPN MGAMHEILFFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1030", Offset = "0x2CF0030", VA = "0x182CF1030")]
		private bool OGODAMEOCPM(in MHOKJGPKENN CHHHDNBJJIO, bool AEGHLAGJCCI, out JobHandle BLIPNDKFLPL, out GEPFMJKLAPN MGAMHEILFFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x2CF0960", Offset = "0x2CEF960", VA = "0x182CF0960")]
		internal (NativeList<int>, NativeList<int>) JNJLMEEDMDC(NativeList<PPBOKIFKECF> OGFHDCELOMI, int JAFEKEGLGFD, JobHandle EKODEGLIDHA, out JobHandle IHONPLJMIOG, Allocator EGJIMBMGFGA = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2290", Offset = "0x2CF1290", VA = "0x182CF2290")]
		internal static NativeArray<Entity> PNNLCEDIMNF(EntityQuery PMKDKHNEPAL, out JobHandle FCEPPGJNKGP)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x2CF0B20", Offset = "0x2CEFB20", VA = "0x182CF0B20")]
		internal static NativeArray<byte> LFLPIMKMNMI(int CDDAIIMDJCN, out JobHandle IBNMDMKFNOA)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x2CEF420", Offset = "0x2CEE420", VA = "0x182CEF420")]
		internal static NativeArray<byte> CBLCNLGMEDA(EntityQuery PMKDKHNEPAL, int NDBJIKBMPCB, out JobHandle IBNMDMKFNOA)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x2CF0C00", Offset = "0x2CEFC00", VA = "0x182CF0C00")]
		internal static NativeArray<Entity> MIGHFPJCFAE(EntityQuery PMKDKHNEPAL, out JobHandle BNGPIIIAHPA)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x2CEFBF0", Offset = "0x2CEEBF0", VA = "0x182CEFBF0")]
		internal NativeArray<byte> DPMAGHICFJO(NativeArray<Entity> NGCJEBOBKNP, MHOKJGPKENN BDIHABFLOBJ, JobHandle EKODEGLIDHA, out JobHandle IHONPLJMIOG, Allocator EGJIMBMGFGA = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x2CF1E60", Offset = "0x2CF0E60", VA = "0x182CF1E60")]
		internal JobHandle OLHKIAAAFOO(in GEPFMJKLAPN PJDKPCLOECB, in MHOKJGPKENN BDIHABFLOBJ, NativeMultiHashMap<Entity, FLFHBOLCLFF> FADAOEDANGI, JobHandle EKODEGLIDHA)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x2017100", Offset = "0x2016100", VA = "0x182017100")]
		private JobHandle BANCMBABGMM(JobHandle CMJEGAAHPHC, JobHandle FLNHPFNBKLG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x2017100", Offset = "0x2016100", VA = "0x182017100")]
		private JobHandle BANCMBABGMM(JobHandle CMJEGAAHPHC, JobHandle FLNHPFNBKLG, JobHandle ACHJALJLBLH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		protected ComputePropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7B790", Offset = "0x2C7A790", VA = "0x182C7B790")]
	protected MBGLPMPHBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B750", Offset = "0x2C7A750", VA = "0x182C7B750", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CFE9C0", Offset = "0x2CFD9C0", VA = "0x182CFE9C0")]
	protected FBPNJGJBJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x2CFE980", Offset = "0x2CFD980", VA = "0x182CFE980", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public NHHFENBAGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED3A40", Offset = "0x4ED2A40", VA = "0x184ED3A40")]
			public void GPJBIMHIEAK(GNGPLNHBEJK AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x4ED3A90", Offset = "0x4ED2A90", VA = "0x184ED3A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ED2A20", Offset = "0x4ED1A20", VA = "0x184ED2A20")]
		internal void BOGFKFCHEFD(ref AuthoredLocalPoseData NJEKMIPHAEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0x29BA330", Offset = "0x29B9330", VA = "0x1829BA330", Slot = "5")]
		public void ReadFromDisplayClass(ref NHHFENBAGLG PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x24AEC20", Offset = "0x24ADC20", VA = "0x1824AEC20", Slot = "6")]
		public void WriteToDisplayClass(ref NHHFENBAGLG PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2BF0", Offset = "0x4ED1BF0", VA = "0x184ED2BF0", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2B60", Offset = "0x4ED1B60", VA = "0x184ED2B60")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref KGKOLGMGCDC.PJKKPENMGLJ FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2C70", Offset = "0x4ED1C70", VA = "0x184ED2C70")]
		public void GPJBIMHIEAK(GNGPLNHBEJK AKIOJOCDPLG, ref NHHFENBAGLG PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2AF0", Offset = "0x4ED1AF0", VA = "0x184ED2AF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D04670", Offset = "0x2D03670", VA = "0x182D04670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public GNGPLNHBEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2D04440", Offset = "0x2D03440", VA = "0x182D04440", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x2D042E0", Offset = "0x2D032E0", VA = "0x182D042E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public JGLHAPIANOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED6130", Offset = "0x4ED5130", VA = "0x184ED6130")]
			public void GPJBIMHIEAK(ENOPFEBDGCE AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x4ED6190", Offset = "0x4ED5190", VA = "0x184ED6190")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BA9D0", Offset = "0x29B99D0", VA = "0x1829BA9D0")]
		internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, SplinePointData ADMEPHMBKKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x29BAC40", Offset = "0x29B9C40", VA = "0x1829BAC40", Slot = "5")]
		public void ReadFromDisplayClass(ref JGLHAPIANOH PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x29BAC50", Offset = "0x29B9C50", VA = "0x1829BAC50", Slot = "6")]
		public void WriteToDisplayClass(ref JGLHAPIANOH PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x29BAB90", Offset = "0x29B9B90", VA = "0x1829BAB90", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x29BAAC0", Offset = "0x29B9AC0", VA = "0x1829BAAC0")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref OFHNAHHMMLK.OEDPPEFJPBC FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x29BAC00", Offset = "0x29B9C00", VA = "0x1829BAC00")]
		public void GPJBIMHIEAK(ENOPFEBDGCE AKIOJOCDPLG, ref JGLHAPIANOH PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x29BAA50", Offset = "0x29B9A50", VA = "0x1829BAA50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CFC040", Offset = "0x2CFB040", VA = "0x182CFC040", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public ENOPFEBDGCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x2CFBE10", Offset = "0x2CFAE10", VA = "0x182CFBE10", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x2CFBCB0", Offset = "0x2CFACB0", VA = "0x182CFBCB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C85070", Offset = "0x2C84070", VA = "0x182C85070", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x2C85100", Offset = "0x2C84100", VA = "0x182C85100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public OMFBOPCFNPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public LMDKIALENGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED26C0", Offset = "0x4ED16C0", VA = "0x184ED26C0")]
			public void GPJBIMHIEAK(APILEEKFEPP AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0x4ED2720", Offset = "0x4ED1720", VA = "0x184ED2720")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BC7B0", Offset = "0x29BB7B0", VA = "0x1829BC7B0")]
		internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, ObjectNetworkIdComponentData KCBCMAMBIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x29BA330", Offset = "0x29B9330", VA = "0x1829BA330", Slot = "5")]
		public void ReadFromDisplayClass(ref LMDKIALENGO PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x24AEC20", Offset = "0x24ADC20", VA = "0x1824AEC20", Slot = "6")]
		public void WriteToDisplayClass(ref LMDKIALENGO PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x29BC950", Offset = "0x29BB950", VA = "0x1829BC950", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x29BC8A0", Offset = "0x29BB8A0", VA = "0x1829BC8A0")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, ref INECDBBEDAP.JHEODADOMHB FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x29BC9C0", Offset = "0x29BB9C0", VA = "0x1829BC9C0")]
		public void GPJBIMHIEAK(APILEEKFEPP AKIOJOCDPLG, ref LMDKIALENGO PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x29BC830", Offset = "0x29BB830", VA = "0x1829BC830")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CE8090", Offset = "0x2CE7090", VA = "0x182CE8090", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8450", Offset = "0x2CE7450", VA = "0x182CE8450", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public APILEEKFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x2CE8250", Offset = "0x2CE7250", VA = "0x182CE8250", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x2CE80F0", Offset = "0x2CE70F0", VA = "0x182CE80F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
			public NGFLMFKCMHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4ED0E30", Offset = "0x4ECFE30", VA = "0x184ED0E30")]
				public void GPJBIMHIEAK(PostLoadInitializeEmbodiment AKIOJOCDPLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077B")]
				[Cpp2IlInjected.Address(RVA = "0x4ED0E90", Offset = "0x4ECFE90", VA = "0x184ED0E90")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED3460", Offset = "0x4ED2460", VA = "0x184ED3460")]
			internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, ObjectNetworkIdComponentData CHHHDNBJJIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0x4ED36E0", Offset = "0x4ED26E0", VA = "0x184ED36E0")]
			internal void IMJDJLNANNL(Entity GDNDJKDEKFN, ObjectNetworkIdComponentData CHHHDNBJJIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0x4ED3760", Offset = "0x4ED2760", VA = "0x184ED3760")]
			internal void PEMICLAEIHO(Entity GDNDJKDEKFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0x4ED38C0", Offset = "0x4ED28C0", VA = "0x184ED38C0", Slot = "5")]
			public void ReadFromDisplayClass(ref NGFLMFKCMHB PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0x4ED3910", Offset = "0x4ED2910", VA = "0x184ED3910", Slot = "6")]
			public void WriteToDisplayClass(ref NGFLMFKCMHB PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x4ED35B0", Offset = "0x4ED25B0", VA = "0x184ED35B0", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0x4ED3500", Offset = "0x4ED2500", VA = "0x184ED3500")]
			public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref FLFLAAGHOLD.IGDIMCKJKHI FNDMFEGAALM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0x4ED3650", Offset = "0x4ED2650", VA = "0x184ED3650")]
			public void GPJBIMHIEAK(PostLoadInitializeEmbodiment AKIOJOCDPLG, ref NGFLMFKCMHB PIEBCDLFDLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0x4ED3490", Offset = "0x4ED2490", VA = "0x184ED3490")]
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
		[Cpp2IlInjected.Address(RVA = "0x29C2500", Offset = "0x29C1500", VA = "0x1829C2500", Slot = "14")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x29C2FD0", Offset = "0x29C1FD0", VA = "0x1829C2FD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x29C3060", Offset = "0x29C2060", VA = "0x1829C3060", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x29C25B0", Offset = "0x29C15B0", VA = "0x1829C25B0")]
		private void MDNCPMALGIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x29C2920", Offset = "0x29C1920", VA = "0x1829C2920")]
		private NativeArray<DPIGCKLNOCH> NILAGFHMAGE(NativeArray<DDAOHKAFOIC> MEHAANADAAJ)
		{
			return default(NativeArray<DPIGCKLNOCH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x29C22B0", Offset = "0x29C12B0", VA = "0x1829C22B0")]
		private void HELBECFEBJF(NativeList<Entity> NGCJEBOBKNP, NativeList<DDAOHKAFOIC> MEHAANADAAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x29C20C0", Offset = "0x29C10C0", VA = "0x1829C20C0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void EKNBANDHHFE(NativeList<DDAOHKAFOIC> MEHAANADAAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		private static void ANOAJICCIAA(NativeList<DDAOHKAFOIC> MEHAANADAAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		public PostLoadInitializeEmbodiment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x29C2E90", Offset = "0x29C1E90", VA = "0x1829C2E90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x29C2C90", Offset = "0x29C1C90", VA = "0x1829C2C90")]
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
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		public HDHJBLPLBPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x29B9CC0", Offset = "0x29B8CC0", VA = "0x1829B9CC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED66C0", Offset = "0x4ED56C0", VA = "0x184ED66C0")]
			public void GPJBIMHIEAK(LBAEMAKPPPO AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x4ED6730", Offset = "0x4ED5730", VA = "0x184ED6730")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ED4AB0", Offset = "0x4ED3AB0", VA = "0x184ED4AB0")]
		internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, int JKEOONCAABA, ref ObjectNetworkIdComponentData KCBCMAMBIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x29BA330", Offset = "0x29B9330", VA = "0x1829BA330", Slot = "5")]
		public void ReadFromDisplayClass(ref HDHJBLPLBPG PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x24AEC20", Offset = "0x24ADC20", VA = "0x1824AEC20", Slot = "6")]
		public void WriteToDisplayClass(ref HDHJBLPLBPG PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4C80", Offset = "0x4ED3C80", VA = "0x184ED4C80", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4BB0", Offset = "0x4ED3BB0", VA = "0x184ED4BB0")]
		public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref POFGHPCBBIL.KEOJJOOPKEH FNDMFEGAALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4D70", Offset = "0x4ED3D70", VA = "0x184ED4D70")]
		public void GPJBIMHIEAK(LBAEMAKPPPO AKIOJOCDPLG, ref HDHJBLPLBPG PIEBCDLFDLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x4ED4B40", Offset = "0x4ED3B40", VA = "0x184ED4B40")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C78990", Offset = "0x2C77990", VA = "0x182C78990", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x2C78D80", Offset = "0x2C77D80", VA = "0x182C78D80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public LBAEMAKPPPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x2C78B50", Offset = "0x2C77B50", VA = "0x182C78B50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x2C789F0", Offset = "0x2C779F0", VA = "0x182C789F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C783D0", Offset = "0x2C773D0", VA = "0x182C783D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x2C78460", Offset = "0x2C77460", VA = "0x182C78460", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public KOCIEKIJKIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C76AB0", Offset = "0x2C75AB0", VA = "0x182C76AB0", Slot = "14")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x2C76C50", Offset = "0x2C75C50", VA = "0x182C76C50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x2C76FE0", Offset = "0x2C75FE0", VA = "0x182C76FE0")]
	private void PKDNGHPAKMD(NativeList<EntityArchetype> KEFILCBKOCJ, NativeHashMap<int, FDAEEOMAIHB> FOPHMEGGGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x2C764B0", Offset = "0x2C754B0", VA = "0x182C764B0")]
	private void KHBJDDNBBAI(NativeHashMap<int, FDAEEOMAIHB> FOPHMEGGGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public KDNNLDPHBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x2C76B10", Offset = "0x2C75B10", VA = "0x182C76B10")]
	[CompilerGenerated]
	internal static Span<int> NFNGMKFNELO(EntityArchetype CEMLDGMJKAJ)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x29C3150", Offset = "0x29C2150", VA = "0x1829C3150", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x29C33A0", Offset = "0x29C23A0", VA = "0x1829C33A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public KLNHKEJFOEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public KLKBCAICNFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public FDFAEOCPOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public NOHHCJNKAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public NEOJDEHFHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public CIDKHBBGCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public BJEEBKJLCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public MMJMFLLBCGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public KHBINFJALOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x29BA370", Offset = "0x29B9370", VA = "0x1829BA370", Slot = "4")]
			public void Execute(int MMABPPDCBIB, TransformAccess JDMGKLHBDHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x29BA590", Offset = "0x29B9590", VA = "0x1829BA590")]
			private bool HNBBJLBGBIA(float3 DIBLIDDDAFJ, float3 OHJKCCOELFF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x29BA5E0", Offset = "0x29B95E0", VA = "0x1829BA5E0")]
			private bool IKEOJCBNBCC(quaternion DIBLIDDDAFJ, quaternion OHJKCCOELFF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0x29BA610", Offset = "0x29B9610", VA = "0x1829BA610")]
			private static bool MMPBLFHCCPK(float3 DOGOAAONBOH, float3 ENHIJCCJFBF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0x29BA890", Offset = "0x29B9890", VA = "0x1829BA890")]
			private static bool MMPBLFHCCPK(quaternion FEBCAKEBBCL, quaternion EEACLMBPLFE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0x29BA530", Offset = "0x29B9530", VA = "0x1829BA530")]
			private static bool GIIKNEBCOCP(float HEMCEBJNLDB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x29BA540", Offset = "0x29B9540", VA = "0x1829BA540")]
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
			[Cpp2IlInjected.Address(RVA = "0x29BC340", Offset = "0x29BB340", VA = "0x1829BC340", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF4810", Offset = "0x2CF3810", VA = "0x182CF4810")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4870", Offset = "0x2CF3870", VA = "0x182CF4870", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x2CF48E0", Offset = "0x2CF38E0", VA = "0x182CF48E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4940", Offset = "0x2CF3940", VA = "0x182CF4940", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4ECF660", Offset = "0x4ECE660", VA = "0x184ECF660")]
				public void GPJBIMHIEAK(RegisterTransforms AKIOJOCDPLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007D6")]
				[Cpp2IlInjected.Address(RVA = "0x4ECF6E0", Offset = "0x4ECE6E0", VA = "0x184ECF6E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED09C0", Offset = "0x4ECF9C0", VA = "0x184ED09C0")]
			internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, GMNCMFEFGOD MOIHFCJJBCN, Transform JDMGKLHBDHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0C10", Offset = "0x4ECFC10", VA = "0x184ED0C10", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0B30", Offset = "0x4ECFB30", VA = "0x184ED0B30")]
			public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, ref BGKPOCIIGPO.FNDAGEKGEEA FNDMFEGAALM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0D00", Offset = "0x4ECFD00", VA = "0x184ED0D00")]
			public void GPJBIMHIEAK(RegisterTransforms AKIOJOCDPLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0AC0", Offset = "0x4ECFAC0", VA = "0x184ED0AC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4ECF7A0", Offset = "0x4ECE7A0", VA = "0x184ECF7A0")]
				public void GPJBIMHIEAK(RegisterTransforms AKIOJOCDPLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007DC")]
				[Cpp2IlInjected.Address(RVA = "0x4ECF800", Offset = "0x4ECE800", VA = "0x184ECF800")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED03C0", Offset = "0x4ECF3C0", VA = "0x184ED03C0")]
			internal void BOGFKFCHEFD(Entity GDNDJKDEKFN, GMNCMFEFGOD MOIHFCJJBCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0550", Offset = "0x4ECF550", VA = "0x184ED0550", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int IADGFBHBNBE, int DKDOLDKLKBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0x4ED04A0", Offset = "0x4ECF4A0", VA = "0x184ED04A0")]
			public void EIHGJFMEHBP(ref ArchetypeChunk DAJPMMDPFFK, [NoAlias] ref BIIFKLEALBJ.HGOHBCGNIEF FNDMFEGAALM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0x4ECF7A0", Offset = "0x4ECE7A0", VA = "0x184ECF7A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x11AD580", Offset = "0x11AC580", VA = "0x1811AD580")]
			get
			{
				return default(EBPNDNCEIPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x29C6F90", Offset = "0x29C5F90", VA = "0x1829C6F90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x29C7160", Offset = "0x29C6160", VA = "0x1829C7160", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x29C7170", Offset = "0x29C6170", VA = "0x1829C7170", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x29C69F0", Offset = "0x29C59F0", VA = "0x1829C69F0")]
		private void KINIJKJOKAO(NativeArray<Entity> NGCJEBOBKNP, EBPNDNCEIPG DLHMEKKBAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x29C6370", Offset = "0x29C5370", VA = "0x1829C6370")]
		[BurstCompile]
		internal static void ABGDPBOHFNG(NativeArray<GMNCMFEFGOD> MGMFAAEJECC, ComponentDataFromEntity<GMNCMFEFGOD> KLNFALJHMGB, EBPNDNCEIPG DLHMEKKBAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		private static void DAANMBADODI(Transform JDMGKLHBDHC, Entity GDNDJKDEKFN, int MMABPPDCBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		private static void NAFCEAPFBPA(Entity GDNDJKDEKFN, int MMABPPDCBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		private static void HAKNIFEJALB(int MMABPPDCBIB, EBPNDNCEIPG DLHMEKKBAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x29C6B30", Offset = "0x29C5B30", VA = "0x1829C6B30")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void LDAOJBDCMLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x29C6D10", Offset = "0x29C5D10", VA = "0x1829C6D10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x29C6850", Offset = "0x29C5850", VA = "0x1829C6850")]
		public static EntityQuery FGEIKNOOFNB(ComponentSystemBase AKIOJOCDPLG)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x29C6680", Offset = "0x29C5680", VA = "0x1829C6680")]
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
			[Cpp2IlInjected.Address(RVA = "0x29BDCD0", Offset = "0x29BCCD0", VA = "0x1829BDCD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x29BA010", Offset = "0x29B9010", VA = "0x1829BA010", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x29BAED0", Offset = "0x29B9ED0", VA = "0x1829BAED0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF4EA0", Offset = "0x2CF3EA0", VA = "0x182CF4EA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x2CF5110", Offset = "0x2CF4110", VA = "0x182CF5110", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xCBE830", Offset = "0xCBD830", VA = "0x180CBE830")]
		internal JobHandle FCGELOCOFCA()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x2CF5150", Offset = "0x2CF4150", VA = "0x182CF5150", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4D20", Offset = "0x2CF3D20", VA = "0x182CF4D20")]
		private NativeArray<Entity> BMDMJEAINLH(NativeArray<GMNCMFEFGOD> JNGPJPKCCHN, NativeList<Entity> ALFIJBPBFIH, TransformAccessArray EIHANBNLKFP, TransformAccessArray NNAENIMPPOH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7D390", Offset = "0x2C7C390", VA = "0x182C7D390", Slot = "14")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D810", Offset = "0x2C7C810", VA = "0x182C7D810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D530", Offset = "0x2C7C530", VA = "0x182C7D530")]
	private static void EBAKAAKBBPF(EntityManager JGGNCNMICJO, Entity GDNDJKDEKFN, Entity OJKLIAPCMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C7D710", Offset = "0x2C7C710", VA = "0x182C7D710")]
	private static Transform IAHHILHKCHF(EntityManager JGGNCNMICJO, Entity GDNDJKDEKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public MMHIHGBHDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED16D0", Offset = "0x4ED06D0", VA = "0x184ED16D0")]
			[Conditional("DEBUG_BUILD")]
			private void PLLODIFHKOE(Entity GDNDJKDEKFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x4ED0F60", Offset = "0x4ECFF60", VA = "0x184ED0F60", Slot = "4")]
			public void Execute(ArchetypeChunk DAJPMMDPFFK, int MMABPPDCBIB, int CHKCAGABANB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1280", Offset = "0x4ED0280", VA = "0x184ED1280")]
			private bool IEJEPDBIIFG(ArchetypeChunk DAJPMMDPFFK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1340", Offset = "0x4ED0340", VA = "0x184ED1340")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C78630", Offset = "0x2C77630", VA = "0x182C78630", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C786D0", Offset = "0x2C776D0", VA = "0x182C786D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ED2D90", Offset = "0x4ED1D90", VA = "0x184ED2D90", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int MMABPPDCBIB, int CHKCAGABANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2E90", Offset = "0x4ED1E90", VA = "0x184ED2E90")]
		public bool IEJEPDBIIFG(ArchetypeChunk DAJPMMDPFFK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private EntityQuery EGNOPKCEHNK;

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C7F8F0", Offset = "0x2C7E8F0", VA = "0x182C7F8F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FA20", Offset = "0x2C7EA20", VA = "0x182C7FA20", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle FMEBGAACPOB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public NHFAKPHCDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ECF230", Offset = "0x4ECE230", VA = "0x184ECF230", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int MMABPPDCBIB, int CHKCAGABANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF5E0", Offset = "0x4ECE5E0", VA = "0x184ECF5E0")]
		public bool IEJEPDBIIFG(ArchetypeChunk DAJPMMDPFFK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private EntityQuery ILNNOEDPGOH;

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C838F0", Offset = "0x2C828F0", VA = "0x182C838F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C83A00", Offset = "0x2C82A00", VA = "0x182C83A00", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle FMEBGAACPOB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public OIFMLHBPOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ED1DD0", Offset = "0x4ED0DD0", VA = "0x184ED1DD0", Slot = "4")]
		public void Execute(ArchetypeChunk DAJPMMDPFFK, int MMABPPDCBIB, int CHKCAGABANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2510", Offset = "0x4ED1510", VA = "0x184ED2510")]
		public bool IEJEPDBIIFG(ArchetypeChunk DAJPMMDPFFK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private EntityQuery ILNNOEDPGOH;

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x2C8E730", Offset = "0x2C8D730", VA = "0x182C8E730", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x2C8E860", Offset = "0x2C8D860", VA = "0x182C8E860", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle FMEBGAACPOB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
	public PEAALDMLHHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C78F30", Offset = "0x2C77F30", VA = "0x182C78F30")]
	protected PAEKHBEHAKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x2C78EF0", Offset = "0x2C77EF0", VA = "0x182C78EF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C71CE0", Offset = "0x2C70CE0", VA = "0x182C71CE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public Type[] CKDBLNKNMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x2C71840", Offset = "0x2C70840", VA = "0x182C71840", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x651170", Offset = "0x650170", VA = "0x180651170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Type[] CKDBLNKNMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x2CFEA90", Offset = "0x2CFDA90", VA = "0x182CFEA90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public FCEDGINPEAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
public sealed class PMABMFGMPBA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public PMABMFGMPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public PDGFELEPEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public KJNGLNMAMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x651170", Offset = "0x650170", VA = "0x180651170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Type[] CKDBLNKNMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x2C8FBF0", Offset = "0x2C8EBF0", VA = "0x182C8FBF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000819")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public PKIIOKJDBNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
public sealed class AKGOFDBJCCO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public AKGOFDBJCCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C81BF0", Offset = "0x2C80BF0", VA = "0x182C81BF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Type[] CKDBLNKNMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x2C819A0", Offset = "0x2C809A0", VA = "0x182C819A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
				[Cpp2IlInjected.Address(RVA = "0x66B040", Offset = "0x66A040", VA = "0x18066B040", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x29BB460", Offset = "0x29BA460", VA = "0x1829BB460", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5B20", Offset = "0xAA4B20", VA = "0x180AA5B20")]
			[DebuggerHidden]
			public HJAIFEBOGNC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0x29BB4B0", Offset = "0x29BA4B0", VA = "0x1829BB4B0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0x29BB080", Offset = "0x29BA080", VA = "0x1829BB080", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000842")]
			[Cpp2IlInjected.Address(RVA = "0x29BB580", Offset = "0x29BA580", VA = "0x1829BB580")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000843")]
			[Cpp2IlInjected.Address(RVA = "0x29BB5D0", Offset = "0x29BA5D0", VA = "0x1829BB5D0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0x29BB420", Offset = "0x29BA420", VA = "0x1829BB420", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0x29BB370", Offset = "0x29BA370", VA = "0x1829BB370", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IOFHLMDPEAL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0x29BB370", Offset = "0x29BA370", VA = "0x1829BB370", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x660740", Offset = "0x65F740", VA = "0x180660740", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0x681DC0", Offset = "0x680DC0", VA = "0x180681DC0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<IOFHLMDPEAL, IOFHLMDPEAL> LJINJODFJON
		{
			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0x2CF3FE0", Offset = "0x2CF2FE0", VA = "0x182CF3FE0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0x2CF4340", Offset = "0x2CF3340", VA = "0x182CF4340", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<IOFHLMDPEAL, IOFHLMDPEAL> NKIIFEHMJNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0x2CF42A0", Offset = "0x2CF32A0", VA = "0x182CF42A0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0x2CF3F40", Offset = "0x2CF2F40", VA = "0x182CF3F40", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<IOFHLMDPEAL, IOFHLMDPEAL, IOFHLMDPEAL> NNDOMCIEMIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0x2CF2F80", Offset = "0x2CF1F80", VA = "0x182CF2F80", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0x2CF4080", Offset = "0x2CF3080", VA = "0x182CF4080", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<IOFHLMDPEAL> JMMDJGLNCPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0x2CF2EE0", Offset = "0x2CF1EE0", VA = "0x182CF2EE0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0x2CF3390", Offset = "0x2CF2390", VA = "0x182CF3390", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4120", Offset = "0x2CF3120", VA = "0x182CF4120", Slot = "23")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2720", Offset = "0x2CF1720", VA = "0x182CF2720", Slot = "24")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x2CF31E0", Offset = "0x2CF21E0", VA = "0x182CF31E0", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3430", Offset = "0x2CF2430", VA = "0x182CF3430")]
		private void EOFPOLBANEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3960", Offset = "0x2CF2960", VA = "0x182CF3960")]
		private void HILFIMEEMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3020", Offset = "0x2CF2020", VA = "0x182CF3020")]
		private void DMIKAHIKBLD(Entity GDNDJKDEKFN, FHCGLCCCIJI LKIMNIMPHKB, IKKMGBAJNEB OHJKCCOELFF, IKKMGBAJNEB DIBLIDDDAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2CA0", Offset = "0x2CF1CA0", VA = "0x182CF2CA0")]
		private void BLGOPFBMCAC(Entity GDNDJKDEKFN, FHCGLCCCIJI LKIMNIMPHKB, IKKMGBAJNEB OHJKCCOELFF, IKKMGBAJNEB DIBLIDDDAFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x2017100", Offset = "0x2016100", VA = "0x182017100", Slot = "14")]
		public IOFHLMDPEAL CIMKIICGCAJ(IOFHLMDPEAL CPBDAEHELGD, int KDCEBOLCINA)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x149EA00", Offset = "0x149DA00", VA = "0x18149EA00", Slot = "15")]
		public Color FIPOFPFOMBP(IOFHLMDPEAL CPBDAEHELGD, int KDCEBOLCINA)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2D00", Offset = "0x2CF1D00", VA = "0x182CF2D00", Slot = "16")]
		public float3 BLPPNLINACG(IOFHLMDPEAL CPBDAEHELGD, int KDCEBOLCINA)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3490", Offset = "0x2CF2490", VA = "0x182CF3490", Slot = "17")]
		public void EPDJFMCJDGO(IOFHLMDPEAL CPBDAEHELGD, IOFHLMDPEAL PCEACEKDHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3730", Offset = "0x2CF2730", VA = "0x182CF3730", Slot = "18")]
		public IOFHLMDPEAL GECBLHBNBIF(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3AD0", Offset = "0x2CF2AD0", VA = "0x182CF3AD0", Slot = "21")]
		public void HNEAMECENCB(IOFHLMDPEAL CPBDAEHELGD, Vector3 EPDCMCDGMOM, Quaternion FNABBPCCGNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4560", Offset = "0x2CF3560", VA = "0x182CF4560", Slot = "26")]
		public (Vector3, Quaternion) OMLACCAEJFJ(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x2CF43E0", Offset = "0x2CF33E0", VA = "0x182CF43E0", Slot = "27")]
		public (Vector3, Quaternion) OEBBAGCPONH(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x2CF37D0", Offset = "0x2CF27D0", VA = "0x182CF37D0", Slot = "22")]
		public (Vector3, Quaternion, bool) GOOMNMACDEK(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default((Vector3, Quaternion, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x2CF2C10", Offset = "0x2CF1C10", VA = "0x182CF2C10", Slot = "19")]
		[IteratorStateMachine(typeof(HJAIFEBOGNC))]
		public IEnumerable<IOFHLMDPEAL> BEGMMKOFLKO(IOFHLMDPEAL CPBDAEHELGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3CE0", Offset = "0x2CF2CE0", VA = "0x182CF3CE0", Slot = "20")]
		public IOFHLMDPEAL IKKJIKAMHEN(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3560", Offset = "0x2CF2560", VA = "0x182CF3560", Slot = "28")]
		public void FKLMDHDNEKK(ref List<IOFHLMDPEAL> LCOODLIGMCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x2CF3E20", Offset = "0x2CF2E20", VA = "0x182CF3E20")]
		private Entity IKKJIKAMHEN(Entity GDNDJKDEKFN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x2CF4760", Offset = "0x2CF3760", VA = "0x182CF4760")]
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
			[Cpp2IlInjected.Address(RVA = "0x2CFD6E0", Offset = "0x2CFC6E0", VA = "0x182CFD6E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x2CFDAF0", Offset = "0x2CFCAF0", VA = "0x182CFDAF0", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x2CFD560", Offset = "0x2CFC560", VA = "0x182CFD560")]
		internal void CMNFPDHNNKL(Entity OJKLIAPCMPJ, Entity FOCEJAMAOBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x2CFDF10", Offset = "0x2CFCF10", VA = "0x182CFDF10")]
		internal void PDJBCLPHIJB(Entity OJKLIAPCMPJ, Entity FOCEJAMAOBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x2CFDD50", Offset = "0x2CFCD50", VA = "0x182CFDD50")]
		private int OLFNGHAKDCC(Entity OJKLIAPCMPJ, Entity FOCEJAMAOBP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x2CFDA20", Offset = "0x2CFCA20", VA = "0x182CFDA20")]
		internal DynamicBuffer<ChildrenData> KMFFDFLPPHH(Entity GDNDJKDEKFN)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x2CFDE40", Offset = "0x2CFCE40", VA = "0x182CFDE40")]
		internal DynamicBuffer<ChildrenData> PAGLOLOIANN(Entity GDNDJKDEKFN)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x2CFDC80", Offset = "0x2CFCC80", VA = "0x182CFDC80")]
		public NativeArray<Entity> MIKFFAGHOIO(Entity GDNDJKDEKFN, Allocator EGJIMBMGFGA)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x2CFD820", Offset = "0x2CFC820", VA = "0x182CFD820")]
		public bool JPNKKLEBOIA(Entity GDNDJKDEKFN, Allocator EGJIMBMGFGA, out NativeArray<Entity> BDILHNBAAJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x2CFD8F0", Offset = "0x2CFC8F0", VA = "0x182CFD8F0")]
		public NativeArray<Entity> KEDPBHCIMAI(Entity GDNDJKDEKFN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x2CFDB70", Offset = "0x2CFCB70", VA = "0x182CFDB70")]
		public Entity LHFLPHOIPHJ(Entity GDNDJKDEKFN, int MMABPPDCBIB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x2CFD730", Offset = "0x2CFC730", VA = "0x182CFD730")]
		public int IGNPFNMNMOD(Entity GDNDJKDEKFN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFE180", Offset = "0x2CFD180", VA = "0x182CFE180", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x2CFE030", Offset = "0x2CFD030", VA = "0x182CFE030", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		private void CNBELOKPKAI(CMIMIKMOPKA EGJPJHAOMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		private void JLNOHPLNCCK(CMIMIKMOPKA EGJPJHAOMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
		private void KHHFONDHJBM(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CFE6D0", Offset = "0x2CFD6D0", VA = "0x182CFE6D0", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x2CFE480", Offset = "0x2CFD480", VA = "0x182CFE480", Slot = "5")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x2CFE680", Offset = "0x2CFD680", VA = "0x182CFE680")]
		public Entity GECBLHBNBIF(Entity GDNDJKDEKFN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x2CFE580", Offset = "0x2CFD580", VA = "0x182CFE580")]
		public bool BNDMHFGOGFC(Entity GDNDJKDEKFN, Entity ILIAKNFOPLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x2CFE5E0", Offset = "0x2CFD5E0", VA = "0x182CFE5E0")]
		public bool EPDJFMCJDGO(Entity GDNDJKDEKFN, Entity ILIAKNFOPLO, bool EMJIKBJAOKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x2CFE750", Offset = "0x2CFD750", VA = "0x182CFE750")]
		private bool LIKPEKNLLJO(Entity GDNDJKDEKFN, Entity ILIAKNFOPLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x21F1DD0", Offset = "0x21F0DD0", VA = "0x1821F1DD0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED1B30", Offset = "0x4ED0B30", VA = "0x184ED1B30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF200", Offset = "0x4ECE200", VA = "0x184ECF200")]
		[DebuggerHidden]
		public HFLADIGPEGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x4ED19A0", Offset = "0x4ED09A0", VA = "0x184ED19A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x4ED1AF0", Offset = "0x4ED0AF0", VA = "0x184ED1AF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x4ED1A40", Offset = "0x4ED0A40", VA = "0x184ED1A40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x4ED1A40", Offset = "0x4ED0A40", VA = "0x184ED1A40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x21F1DD0", Offset = "0x21F0DD0", VA = "0x1821F1DD0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED31D0", Offset = "0x4ED21D0", VA = "0x184ED31D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF200", Offset = "0x4ECE200", VA = "0x184ECF200")]
		[DebuggerHidden]
		public KBKMKAEGIBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x4ED3220", Offset = "0x4ED2220", VA = "0x184ED3220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2F10", Offset = "0x4ED1F10", VA = "0x184ED2F10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x4ED32B0", Offset = "0x4ED22B0", VA = "0x184ED32B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x4ED3190", Offset = "0x4ED2190", VA = "0x184ED3190", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x4ED30E0", Offset = "0x4ED20E0", VA = "0x184ED30E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x4ED30E0", Offset = "0x4ED20E0", VA = "0x184ED30E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x21F1DD0", Offset = "0x21F0DD0", VA = "0x1821F1DD0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ECF040", Offset = "0x4ECE040", VA = "0x184ECF040", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF200", Offset = "0x4ECE200", VA = "0x184ECF200")]
		[DebuggerHidden]
		public APEPFCBIENF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF090", Offset = "0x4ECE090", VA = "0x184ECF090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x4ECEC50", Offset = "0x4ECDC50", VA = "0x184ECEC50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF160", Offset = "0x4ECE160", VA = "0x184ECF160")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF1B0", Offset = "0x4ECE1B0", VA = "0x184ECF1B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF000", Offset = "0x4ECE000", VA = "0x184ECF000", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x4ECEF50", Offset = "0x4ECDF50", VA = "0x184ECEF50", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x4ECEF50", Offset = "0x4ECDF50", VA = "0x184ECEF50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C8F500", Offset = "0x2C8E500", VA = "0x182C8F500")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F950", Offset = "0x2C8E950", VA = "0x182C8F950", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F490", Offset = "0x2C8E490", VA = "0x182C8F490", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F050", Offset = "0x2C8E050", VA = "0x182C8F050")]
	public bool CMHAFNALMKK(Entity GDNDJKDEKFN, Entity POADJDFNECJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F1E0", Offset = "0x2C8E1E0", VA = "0x182C8F1E0")]
	public bool DCLFBBFLDAH(Entity GDNDJKDEKFN, Entity POADJDFNECJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F5E0", Offset = "0x2C8E5E0", VA = "0x182C8F5E0")]
	public IEnumerable<Entity> IPBOMGOIDCM(Entity GDNDJKDEKFN, bool FBOPMPBBPKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x2C8FAB0", Offset = "0x2C8EAB0", VA = "0x182C8FAB0")]
	[IteratorStateMachine(typeof(HFLADIGPEGD))]
	private IEnumerable<Entity> OCKILBNHFMP(Entity GDNDJKDEKFN, bool FBOPMPBBPKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F2C0", Offset = "0x2C8E2C0", VA = "0x182C8F2C0")]
	public bool DEEFPGIOMCP(Entity GDNDJKDEKFN, Entity FOCEJAMAOBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x2C8EEC0", Offset = "0x2C8DEC0", VA = "0x182C8EEC0")]
	public bool BCBFDHJANCI(Entity GDNDJKDEKFN, Entity IFLKAOGBEDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F380", Offset = "0x2C8E380", VA = "0x182C8F380")]
	public IEnumerable<Entity> DNDIDHHEMJL(Entity GDNDJKDEKFN, bool FBOPMPBBPKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x2C8FB50", Offset = "0x2C8EB50", VA = "0x182C8FB50")]
	[IteratorStateMachine(typeof(KBKMKAEGIBP))]
	private IEnumerable<Entity> OMCPMPDIBFC(Entity GDNDJKDEKFN, bool FBOPMPBBPKC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F8D0", Offset = "0x2C8E8D0", VA = "0x182C8F8D0")]
	[IteratorStateMachine(typeof(APEPFCBIENF))]
	private IEnumerable<Entity> KKAAHIDHIAH(Entity GDNDJKDEKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F550", Offset = "0x2C8E550", VA = "0x182C8F550")]
	public Entity IKKJIKAMHEN(Entity GDNDJKDEKFN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F4B0", Offset = "0x2C8E4B0", VA = "0x182C8F4B0")]
	public NativeArray<Entity> FKLMDHDNEKK()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x2C8F6F0", Offset = "0x2C8E6F0", VA = "0x182C8F6F0")]
	public bool KDGKGEDFGPG(Entity IFLKAOGBEDH, Entity KNPAGIAAIJP, out Entity FNFLMMJIIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4634C70", Offset = "0x4633C70", VA = "0x184634C70")]
		public static void MADPLDOCFBN<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData>(EEAJKGBJNOA AHNMBJFNCGG, global::JHOLIPIPHIK<Entity> BAOKNJFCNMB, out global::AFCNIFIINJI<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> DJEOMGBJAFP) where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, OLKMAFNAGAF where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, OLKMAFNAGAF, IEquatable<ChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x29C0080", Offset = "0x29BF080", VA = "0x1829C0080")]
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
	[Cpp2IlInjected.Address(RVA = "0x26DAF10", Offset = "0x26D9F10", VA = "0x1826DAF10")]
	public AFCNIFIINJI(EEAJKGBJNOA AHNMBJFNCGG, global::JHOLIPIPHIK<Entity> BAOKNJFCNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000894")]
	[Cpp2IlInjected.Address(RVA = "0x26DABB0", Offset = "0x26D9BB0", VA = "0x1826DABB0")]
	private bool JFKLPDPBCNM(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000895")]
	[Cpp2IlInjected.Address(RVA = "0x26DAC10", Offset = "0x26D9C10", VA = "0x1826DAC10")]
	private bool KGKELEFMEFJ(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0x26DA0E0", Offset = "0x26D90E0", VA = "0x1826DA0E0")]
	public bool DCJPOBAADCF(Entity GDNDJKDEKFN, in Entity ILIAKNFOPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	private static void FNOIHBDOHFF(Entity GDNDJKDEKFN, Entity ILIAKNFOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	private static void CAJFEGMAOOB(Entity GDNDJKDEKFN, Entity ILIAKNFOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x26DA000", Offset = "0x26D9000", VA = "0x1826DA000")]
	private bool CMHAFNALMKK(Entity GDNDJKDEKFN, Entity POADJDFNECJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0x26D9E40", Offset = "0x26D8E40", VA = "0x1826D9E40")]
	private void ABIGLPHFOFN(Entity GDNDJKDEKFN, in Entity CKCPHJMEEKP, in Entity ILIAKNFOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089B")]
	[Cpp2IlInjected.Address(RVA = "0x26DA9B0", Offset = "0x26D99B0", VA = "0x1826DA9B0")]
	private void HPLELHJHDHD(Entity GDNDJKDEKFN, in Entity CKCPHJMEEKP, in Entity ILIAKNFOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089C")]
	[Cpp2IlInjected.Address(RVA = "0x26DA310", Offset = "0x26D9310", VA = "0x1826DA310")]
	private bool EKFPOMMAAFJ(MFELBFPKDLI GIDAPFFEFMG, in DDAOHKAFOIC MNMMKLLNPBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600089D")]
	[Cpp2IlInjected.Address(RVA = "0x26DAC60", Offset = "0x26D9C60", VA = "0x1826DAC60")]
	private void KJGBLHPLGKL(Entity OJKLIAPCMPJ, Entity FOCEJAMAOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089E")]
	[Cpp2IlInjected.Address(RVA = "0x26DA6F0", Offset = "0x26D96F0", VA = "0x1826DA6F0")]
	private void FDCLLHDIPLE(Entity OJKLIAPCMPJ, Entity FOCEJAMAOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089F")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	private void HAKNIFEJALB(Entity GDNDJKDEKFN, Entity CKCPHJMEEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A0")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED1CC0", Offset = "0x4ED0CC0", VA = "0x184ED1CC0")]
			public HOBALPECLOI(TransformOwnershipPhase OJKLIAPCMPJ, KFBPPGFFIFI MOJDHKGIHLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0x4ED1CA0", Offset = "0x4ED0CA0", VA = "0x184ED1CA0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x64A040", Offset = "0x649040", VA = "0x18064A040")]
			get
			{
				return default(KFBPPGFFIFI);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x66AF30", Offset = "0x669F30", VA = "0x18066AF30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public bool BJPDGIOHCLM
		{
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0xC070F0", Offset = "0xC060F0", VA = "0x180C070F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public bool ANFFLGPHJDC
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0xFD27F0", Offset = "0xFD17F0", VA = "0x180FD27F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x29CCD30", Offset = "0x29CBD30", VA = "0x1829CCD30")]
		public HOBALPECLOI EGBLKMAGBBA()
		{
			return default(HOBALPECLOI);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x29CCD60", Offset = "0x29CBD60", VA = "0x1829CCD60")]
		public HOBALPECLOI GJBAEMHMFCF()
		{
			return default(HOBALPECLOI);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FBE20", Offset = "0x6FAE20", VA = "0x1806FBE20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD90", Offset = "0x6FAD90", VA = "0x1806FBD90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x8A3600", Offset = "0x8A2600", VA = "0x1808A3600", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xE9D080", Offset = "0xE9C080", VA = "0x180E9D080", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool DPHKGIJFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7450", Offset = "0x2CF6450", VA = "0x182CF7450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B1")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7400", Offset = "0x2CF6400", VA = "0x182CF7400", Slot = "8")]
	public bool Equals(EACJHPJAFLK IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B2")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7490", Offset = "0x2CF6490", VA = "0x182CF7490", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7B180", Offset = "0x2C7A180", VA = "0x182C7B180")]
	public LNNNEMBKEFK(EntityManager JGGNCNMICJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B5")]
	[Cpp2IlInjected.Address(RVA = "0x2C7ACD0", Offset = "0x2C79CD0", VA = "0x182C7ACD0")]
	public void EPHNJFGJMIL(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B000", Offset = "0x2C7A000", VA = "0x182C7B000")]
	public bool OLMBONIFOFC(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AAA0", Offset = "0x2C79AA0", VA = "0x182C7AAA0")]
	public bool DAHIJCGCDME(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B8")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AAE0", Offset = "0x2C79AE0", VA = "0x182C7AAE0")]
	public bool DAHIJCGCDME(EACJHPJAFLK BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C7ADD0", Offset = "0x2C79DD0", VA = "0x182C7ADD0")]
	public bool HJMDCIFEJON(Entity GDNDJKDEKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BA")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AC20", Offset = "0x2C79C20", VA = "0x182C7AC20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AC60", Offset = "0x2C79C60", VA = "0x182C7AC60")]
	private void EEHCPGNMPHF(HashSet<object> FMPADIAJDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AF30", Offset = "0x2C79F30", VA = "0x182C7AF30")]
	private bool NFINFCGLAIH(Entity GDNDJKDEKFN, out EACJHPJAFLK BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AEB0", Offset = "0x2C79EB0", VA = "0x182C7AEB0")]
	private void KLAJEOOBJIA(Entity GDNDJKDEKFN, EACJHPJAFLK BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AA40", Offset = "0x2C79A40", VA = "0x182C7AA40")]
	private bool BKHEOEOKGNO(EACJHPJAFLK EFKJILPBBFJ, out HashSet<object> FMPADIAJDEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BF")]
	[Cpp2IlInjected.Address(RVA = "0x2C7AB80", Offset = "0x2C79B80", VA = "0x182C7AB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BFDC0", Offset = "0x29BEDC0", VA = "0x1829BFDC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x29BFF00", Offset = "0x29BEF00", VA = "0x1829BFF00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action GNBJAMIJEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x29BFE60", Offset = "0x29BEE60", VA = "0x1829BFE60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x29BFD20", Offset = "0x29BED20", VA = "0x1829BFD20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(RVA = "0x11B46E0", Offset = "0x11B36E0", VA = "0x1811B46E0")]
	public void CLDNLMGPOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x10E6CF0", Offset = "0x10E5CF0", VA = "0x1810E6CF0")]
	public void OKNGGGAPBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C87C40", Offset = "0x2C86C40", VA = "0x182C87C40")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public int HDCINPLPMJE
		{
			[Cpp2IlInjected.Token(Token = "0x60008D0")]
			[Cpp2IlInjected.Address(RVA = "0x2C87DC0", Offset = "0x2C86DC0", VA = "0x182C87DC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int OMMFOKCAHCH
		{
			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0x2C89010", Offset = "0x2C88010", VA = "0x182C89010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<CMIMIKMOPKA> IMKBFAMKCJM
		{
			[Cpp2IlInjected.Token(Token = "0x60008C7")]
			[Cpp2IlInjected.Address(RVA = "0x2C88D10", Offset = "0x2C87D10", VA = "0x182C88D10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008C8")]
			[Cpp2IlInjected.Address(RVA = "0x2C88160", Offset = "0x2C87160", VA = "0x182C88160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<CMIMIKMOPKA> GOFDLOIOCFK
		{
			[Cpp2IlInjected.Token(Token = "0x60008C9")]
			[Cpp2IlInjected.Address(RVA = "0x2C872E0", Offset = "0x2C862E0", VA = "0x182C872E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x2C89890", Offset = "0x2C88890", VA = "0x182C89890")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C87190", Offset = "0x2C86190", VA = "0x182C87190", Slot = "4")]
		public void FKDGDLIKCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x2C88200", Offset = "0x2C87200", VA = "0x182C88200", Slot = "5")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x2C85CD0", Offset = "0x2C84CD0", VA = "0x182C85CD0", Slot = "6")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x2C86910", Offset = "0x2C85910", VA = "0x182C86910", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C86480", Offset = "0x2C85480", VA = "0x182C86480")]
		public bool CAAKCPFCLOC(Entity GDNDJKDEKFN, Allocator EGJIMBMGFGA, out NativeList<Entity> JBLKGEEDKLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C88E50", Offset = "0x2C87E50", VA = "0x182C88E50")]
		public global::PEOLEGIGBJF<Entity> NANCLHOJDJJ(Allocator EGJIMBMGFGA)
		{
			return default(global::PEOLEGIGBJF<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C85C60", Offset = "0x2C84C60", VA = "0x182C85C60")]
		public bool AADNEELLNGM(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C886E0", Offset = "0x2C876E0", VA = "0x182C886E0")]
		public bool LPOPHPNOAOD(Entity GDNDJKDEKFN, out GHMJIBJLDNA EGJPJHAOMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x2C88630", Offset = "0x2C87630", VA = "0x182C88630")]
		private bool LPOPHPNOAOD(Transform JDMGKLHBDHC, out GHMJIBJLDNA EGJPJHAOMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x2C87E60", Offset = "0x2C86E60", VA = "0x182C87E60")]
		internal bool KDBHEBFFFBO(Entity GDNDJKDEKFN, out CCFEOLMBFFJ EGJPJHAOMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x2C88F70", Offset = "0x2C87F70", VA = "0x182C88F70")]
		private void NHILCMEGODH(Entity GDNDJKDEKFN, GHMJIBJLDNA EGJPJHAOMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2C87270", Offset = "0x2C86270", VA = "0x182C87270")]
		private bool GHIMMNHHNIG(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x2C87C90", Offset = "0x2C86C90", VA = "0x182C87C90")]
		public void IIGIGLNPDMN(DDAOHKAFOIC LNNGKIMHKAI, GHMJIBJLDNA OMJIFKPFMBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x2C89270", Offset = "0x2C88270", VA = "0x182C89270")]
		public bool OAKONLPOIJF(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x2C873D0", Offset = "0x2C863D0", VA = "0x182C873D0")]
		public bool HEOPAOOCMKB(IOFHLMDPEAL CPBDAEHELGD, object FDKCIGPLPAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x2C877E0", Offset = "0x2C867E0", VA = "0x182C877E0")]
		public bool HEOPAOOCMKB(Entity GDNDJKDEKFN, [Optional] object FDKCIGPLPAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x2C873B0", Offset = "0x2C863B0", VA = "0x182C873B0")]
		public bool HEOPAOOCMKB(GHMJIBJLDNA JJOFMICFAJO, object FDKCIGPLPAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x2C85E60", Offset = "0x2C84E60", VA = "0x182C85E60")]
		public bool BGLGHHGNAFH(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x2C85E30", Offset = "0x2C84E30", VA = "0x182C85E30")]
		public bool BGLGHHGNAFH(GHMJIBJLDNA EGJPJHAOMIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2C87830", Offset = "0x2C86830", VA = "0x182C87830")]
		public bool HEOPAOOCMKB(GHMJIBJLDNA EGJPJHAOMIN, [Optional] object FDKCIGPLPAB, bool MJJPNLBDKFE = false, bool FDFDBLMIIBO = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x2C88B60", Offset = "0x2C87B60", VA = "0x182C88B60")]
		public Transform MHFIGNMDDFK(Entity GDNDJKDEKFN, [Optional] object FDKCIGPLPAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x2C871A0", Offset = "0x2C861A0", VA = "0x182C871A0")]
		public bool FLLDEIOLFNK(Entity GDNDJKDEKFN, out Transform JDMGKLHBDHC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x2C88DB0", Offset = "0x2C87DB0", VA = "0x182C88DB0")]
		public GHMJIBJLDNA MPHHGOHAHFD(Entity GDNDJKDEKFN, [Optional] object FDKCIGPLPAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x2C88410", Offset = "0x2C87410", VA = "0x182C88410")]
		public void LNFEFDNFIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x2C887A0", Offset = "0x2C877A0", VA = "0x182C887A0")]
		public void MCNPDGNJBFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C86C00", Offset = "0x2C85C00", VA = "0x182C86C00")]
		private void FAHOMGCOICB(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C86860", Offset = "0x2C85860", VA = "0x182C86860")]
		public GHMJIBJLDNA COOKPCMEDND(Entity GDNDJKDEKFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C86BF0", Offset = "0x2C85BF0", VA = "0x182C86BF0")]
		public void EPHNJFGJMIL(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C89880", Offset = "0x2C88880", VA = "0x182C89880")]
		public bool OLMBONIFOFC(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x2C87C30", Offset = "0x2C86C30", VA = "0x182C87C30")]
		public bool HJMDCIFEJON(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C868C0", Offset = "0x2C858C0", VA = "0x182C868C0")]
		public bool DAHIJCGCDME(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C868B0", Offset = "0x2C858B0", VA = "0x182C868B0")]
		public bool DAHIJCGCDME(EACJHPJAFLK BLIPNDKFLPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C86A90", Offset = "0x2C85A90", VA = "0x182C86A90")]
		private void EHGGJCNAFDA(bool LEIPDPGDBJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C87100", Offset = "0x2C86100", VA = "0x182C87100")]
		private bool FHPAFOPHOBI(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C87DF0", Offset = "0x2C86DF0", VA = "0x182C87DF0")]
		private GHMJIBJLDNA IMPEOEEHGAC(Entity GDNDJKDEKFN, object FDKCIGPLPAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x2C866D0", Offset = "0x2C856D0", VA = "0x182C866D0")]
		private GHMJIBJLDNA CMNGLBGLIAJ(Entity GDNDJKDEKFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C89660", Offset = "0x2C88660", VA = "0x182C89660")]
		private (Vector3, Quaternion, Vector3) OLGMOLNKKNB(Entity GDNDJKDEKFN)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C89040", Offset = "0x2C88040", VA = "0x182C89040")]
		private void NPDIGKCJDHO(Entity GDNDJKDEKFN, IOFCPOJDKFL OHBBEKBPFPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C86240", Offset = "0x2C85240", VA = "0x182C86240")]
		private void BILMAGJFHIA(IOFHLMDPEAL CPBDAEHELGD, GHMJIBJLDNA OMJIFKPFMBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C87ED0", Offset = "0x2C86ED0", VA = "0x182C87ED0")]
		private void KGFBHICMOKJ(GHMJIBJLDNA EGJPJHAOMIN, Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2C86EB0", Offset = "0x2C85EB0", VA = "0x182C86EB0")]
		private void FGELNKPPNCL(Entity GDNDJKDEKFN, GHMJIBJLDNA EGJPJHAOMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2C863A0", Offset = "0x2C853A0", VA = "0x182C863A0")]
		private void BKAFPHOFJEK(Entity GDNDJKDEKFN, Transform JDMGKLHBDHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2C87380", Offset = "0x2C86380", VA = "0x182C87380")]
		private IOFHLMDPEAL GNCDGGPPKBO(Entity GDNDJKDEKFN)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x2C89980", Offset = "0x2C88980", VA = "0x182C89980")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x2C88EA0", Offset = "0x2C87EA0", VA = "0x182C88EA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CF6BB0", Offset = "0x2CF5BB0", VA = "0x182CF6BB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C8A110", Offset = "0x2C89110", VA = "0x182C8A110")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<Entity, IOFCPOJDKFL> BMJEHKPAGKE
		{
			[Cpp2IlInjected.Token(Token = "0x60008FD")]
			[Cpp2IlInjected.Address(RVA = "0x2C89E90", Offset = "0x2C88E90", VA = "0x182C89E90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008FE")]
			[Cpp2IlInjected.Address(RVA = "0x2C8A480", Offset = "0x2C89480", VA = "0x182C8A480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<Entity> OCJPKBABAHC
		{
			[Cpp2IlInjected.Token(Token = "0x60008FF")]
			[Cpp2IlInjected.Address(RVA = "0x2C89C90", Offset = "0x2C88C90", VA = "0x182C89C90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000900")]
			[Cpp2IlInjected.Address(RVA = "0x2C8A160", Offset = "0x2C89160", VA = "0x182C8A160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A780", Offset = "0x2C89780", VA = "0x182C8A780", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x2C89D90", Offset = "0x2C88D90", VA = "0x182C89D90")]
		public bool FKKMCEBMOMF(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x2C89D30", Offset = "0x2C88D30", VA = "0x182C89D30")]
		internal void EAKGIOPLHEJ(Entity GDNDJKDEKFN, IOFCPOJDKFL OHBBEKBPFPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A080", Offset = "0x2C89080", VA = "0x182C8A080")]
		public void HCHHHNHJCJG(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x2C89B50", Offset = "0x2C88B50", VA = "0x182C89B50")]
		public void BCKCNDMGJOA(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x2C89F30", Offset = "0x2C88F30", VA = "0x182C89F30")]
		private bool GJIPHIPIFGK(Entity GDNDJKDEKFN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x2C89E00", Offset = "0x2C88E00", VA = "0x182C89E00")]
		public void FODPFOJIHMB(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A8E0", Offset = "0x2C898E0", VA = "0x182C8A8E0")]
		private void MCJPBBAFGCF(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A520", Offset = "0x2C89520", VA = "0x182C8A520")]
		private void JEFJIDNPFEA(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A200", Offset = "0x2C89200", VA = "0x182C8A200")]
		private void IDOHNHCDJKI(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x2C89A00", Offset = "0x2C88A00", VA = "0x182C89A00")]
		private void AOMADBDHGCO(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
			[Cpp2IlInjected.Address(RVA = "0xD92380", Offset = "0xD91380", VA = "0x180D92380")]
			get
			{
				return default(NativeHashMap<DDAOHKAFOIC, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C5D0", Offset = "0x2C8B5D0", VA = "0x182C8C5D0", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C2F0", Offset = "0x2C8B2F0", VA = "0x182C8C2F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C7B0", Offset = "0x2C8B7B0", VA = "0x182C8C7B0")]
		public void OJEEPLKEKIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C3B0", Offset = "0x2C8B3B0", VA = "0x182C8C3B0")]
		private IOFHLMDPEAL GNCDGGPPKBO(Entity GDNDJKDEKFN)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C6D0", Offset = "0x2C8B6D0", VA = "0x182C8C6D0")]
		public IOFHLMDPEAL NDFJMIJLHMK(DDAOHKAFOIC LNNGKIMHKAI)
		{
			return default(IOFHLMDPEAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C540", Offset = "0x2C8B540", VA = "0x182C8C540")]
		public DDAOHKAFOIC JCBOEKFMENI(IOFHLMDPEAL CPBDAEHELGD)
		{
			return default(DDAOHKAFOIC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C4B0", Offset = "0x2C8B4B0", VA = "0x182C8C4B0")]
		public void IGLDBBPKIEA(Entity GDNDJKDEKFN, DDAOHKAFOIC LNNGKIMHKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C350", Offset = "0x2C8B350", VA = "0x182C8C350")]
		public void GLAJCNDAHJN(Entity GDNDJKDEKFN, DDAOHKAFOIC LNNGKIMHKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C290", Offset = "0x2C8B290", VA = "0x182C8C290")]
		public void ADODJPJMOJL(Entity GDNDJKDEKFN, DDAOHKAFOIC LNNGKIMHKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C3E0", Offset = "0x2C8B3E0", VA = "0x182C8C3E0")]
		public void HIHBPPPPGPM(Entity GDNDJKDEKFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C82490", Offset = "0x2C81490", VA = "0x182C82490", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2C82720", Offset = "0x2C81720", VA = "0x182C82720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public BCIHOINOBGK FOLDKHIMCCH
	{
		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x2C82780", Offset = "0x2C81780", VA = "0x182C82780", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x2C822D0", Offset = "0x2C812D0", VA = "0x182C822D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public BCIHOINOBGK PAFAJLJNPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x2C827F0", Offset = "0x2C817F0", VA = "0x182C827F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x2C82260", Offset = "0x2C81260", VA = "0x182C82260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public BCIHOINOBGK GMBHPGBMLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x2C824F0", Offset = "0x2C814F0", VA = "0x182C824F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x2C826B0", Offset = "0x2C816B0", VA = "0x182C826B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public BCIHOINOBGK EPABEDCHIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x2C82640", Offset = "0x2C81640", VA = "0x182C82640", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x2C823B0", Offset = "0x2C813B0", VA = "0x182C823B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public BCIHOINOBGK LAOGIAIAKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x2C82940", Offset = "0x2C81940", VA = "0x182C82940", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x2C82860", Offset = "0x2C81860", VA = "0x182C82860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public BCIHOINOBGK EFKGEOHBODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x2C82180", Offset = "0x2C81180", VA = "0x182C82180", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2C82420", Offset = "0x2C81420", VA = "0x182C82420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public BCIHOINOBGK CEBACLBJNLE
	{
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2C82340", Offset = "0x2C81340", VA = "0x182C82340", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2C821F0", Offset = "0x2C811F0", VA = "0x182C821F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public BCIHOINOBGK LLONECCMPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2C825D0", Offset = "0x2C815D0", VA = "0x182C825D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2C828D0", Offset = "0x2C818D0", VA = "0x182C828D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public BCIHOINOBGK DHFDECHIELC
	{
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2C82110", Offset = "0x2C81110", VA = "0x182C82110", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(BCIHOINOBGK);
		}
		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2C82560", Offset = "0x2C81560", VA = "0x182C82560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000930")]
	[Cpp2IlInjected.Address(RVA = "0x2C829B0", Offset = "0x2C819B0", VA = "0x182C829B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2C8CB80", Offset = "0x2C8BB80", VA = "0x182C8CB80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "4")]
		public void FKDGDLIKCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CF00", Offset = "0x2C8BF00", VA = "0x182C8CF00", Slot = "5")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C860", Offset = "0x2C8B860", VA = "0x182C8C860", Slot = "6")]
		public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CA00", Offset = "0x2C8BA00", VA = "0x182C8CA00", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C9D0", Offset = "0x2C8B9D0", VA = "0x182C8C9D0")]
		private void CCFGADIKNGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CD90", Offset = "0x2C8BD90", VA = "0x182C8CD90")]
		public void JPFMENODJMO(bool MJJPNLBDKFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C9D0", Offset = "0x2C8B9D0", VA = "0x182C8C9D0")]
		private void CAJBJKJIKJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CD50", Offset = "0x2C8BD50", VA = "0x182C8CD50")]
		public Entity JAAHPLBFDOD(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CC60", Offset = "0x2C8BC60", VA = "0x182C8CC60")]
		public Entity JAAHPLBFDOD(IOFCPOJDKFL OHBBEKBPFPH, DDAOHKAFOIC LNNGKIMHKAI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D090", Offset = "0x2C8C090", VA = "0x182C8D090")]
		public Entity LMGGBKFFDDM(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CE60", Offset = "0x2C8BE60", VA = "0x182C8CE60")]
		public Entity KKBHPDPGGIO(DDAOHKAFOIC LNNGKIMHKAI, IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CD50", Offset = "0x2C8BD50", VA = "0x182C8CD50")]
		public Entity KELGJPAMBIF(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C990", Offset = "0x2C8B990", VA = "0x182C8C990")]
		public Entity APJGKMKJAME()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CBD0", Offset = "0x2C8BBD0", VA = "0x182C8CBD0")]
		public Entity HACNOOOPBHD(KOILODOMKMM BCFKLEGAMEO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C900", Offset = "0x2C8B900", VA = "0x182C8C900")]
		public Entity AHPAEJDNMCD(BNFPHFLJIBP BCFKLEGAMEO)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CD00", Offset = "0x2C8BD00", VA = "0x182C8CD00")]
		public NativeArray<(IOFHLMDPEAL, IOFHLMDPEAL)> JAAHPLBFDOD(NativeArray<IOFHLMDPEAL> BCIIMKPOHKF, Allocator EGJIMBMGFGA)
		{
			return default(NativeArray<(IOFHLMDPEAL, IOFHLMDPEAL)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D1C0", Offset = "0x2C8C1C0", VA = "0x182C8D1C0")]
		public IEnumerable<IOFCPOJDKFL> PJFFLLCAPBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CB20", Offset = "0x2C8BB20", VA = "0x182C8CB20")]
		public EntityArchetype GDMKGDBFMNG(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x2C8CAC0", Offset = "0x2C8BAC0", VA = "0x182C8CAC0")]
		public Entity FLPFAHPDBME(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D0B0", Offset = "0x2C8C0B0", VA = "0x182C8D0B0")]
		private Entity NEPEOHHDIEM(IOFCPOJDKFL OHBBEKBPFPH, DDAOHKAFOIC LNNGKIMHKAI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
				[Cpp2IlInjected.Address(RVA = "0x21F1DD0", Offset = "0x21F0DD0", VA = "0x1821F1DD0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x4ED3F00", Offset = "0x4ED2F00", VA = "0x184ED3F00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600095D")]
			[Cpp2IlInjected.Address(RVA = "0x4ECF200", Offset = "0x4ECE200", VA = "0x184ECF200")]
			[DebuggerHidden]
			public LNEHMDPPJGJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095E")]
			[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095F")]
			[Cpp2IlInjected.Address(RVA = "0x4ED3D20", Offset = "0x4ED2D20", VA = "0x184ED3D20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000961")]
			[Cpp2IlInjected.Address(RVA = "0x4ED3EC0", Offset = "0x4ED2EC0", VA = "0x184ED3EC0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0x4ED3E20", Offset = "0x4ED2E20", VA = "0x184ED3E20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(KOILODOMKMM, IOFCPOJDKFL)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0x4ED3E20", Offset = "0x4ED2E20", VA = "0x184ED3E20", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public int CAAMIJFBOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0x2C8D890", Offset = "0x2C8C890", VA = "0x182C8D890")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public EntityManager FHACAKFHJON
		{
			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0x8CF0E0", Offset = "0x8CE0E0", VA = "0x1808CF0E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E340", Offset = "0x2C8D340", VA = "0x182C8E340")]
		public ObjectPrefabs(World EAMEDKLPJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D260", Offset = "0x2C8C260", VA = "0x182C8D260")]
		private void CBEKCPDIOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E270", Offset = "0x2C8D270", VA = "0x182C8E270")]
		internal IEnumerable<Type> NMFCHMFBPJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DE40", Offset = "0x2C8CE40", VA = "0x182C8DE40")]
		internal NPOMLBPEKKD IFAAMEHKFIB(Type BCFKLEGAMEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DA60", Offset = "0x2C8CA60", VA = "0x182C8DA60")]
		internal void HEKPGEEIHIK(NPOMLBPEKKD KDHHOJKGJCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E030", Offset = "0x2C8D030", VA = "0x182C8E030")]
		internal void JKEHKDMADCN(IOFCPOJDKFL OHBBEKBPFPH, BCIHOINOBGK KGHLMGHDBBB, OAICBAFPMDG EACGIHHDHMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D460", Offset = "0x2C8C460", VA = "0x182C8D460")]
		private void DOLJLDIFBMN(IOFCPOJDKFL OHBBEKBPFPH, BCIHOINOBGK GPJMDEPCIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E250", Offset = "0x2C8D250", VA = "0x182C8E250")]
		public void JPFMENODJMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DA00", Offset = "0x2C8CA00", VA = "0x182C8DA00")]
		public EntityArchetype GDMKGDBFMNG(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DEB0", Offset = "0x2C8CEB0", VA = "0x182C8DEB0", Slot = "4")]
		[IteratorStateMachine(typeof(LNEHMDPPJGJ))]
		public IEnumerable<(KOILODOMKMM, IOFCPOJDKFL)> IPBMGPMALFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x2C8DF20", Offset = "0x2C8CF20", VA = "0x182C8DF20")]
		public Entity JAAHPLBFDOD(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D940", Offset = "0x2C8C940", VA = "0x182C8D940")]
		public IOFCPOJDKFL FGGMDEJJMHP(BNFPHFLJIBP BCFKLEGAMEO)
		{
			return default(IOFCPOJDKFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D8E0", Offset = "0x2C8C8E0", VA = "0x182C8D8E0")]
		public IOFCPOJDKFL FGGMDEJJMHP(KOILODOMKMM BCFKLEGAMEO)
		{
			return default(IOFCPOJDKFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D5C0", Offset = "0x2C8C5C0", VA = "0x182C8D5C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x2C8E2A0", Offset = "0x2C8D2A0", VA = "0x182C8E2A0")]
		public IEnumerable<IOFCPOJDKFL> PJFFLLCAPBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D9A0", Offset = "0x2C8C9A0", VA = "0x182C8D9A0")]
		public Entity FLPFAHPDBME(IOFCPOJDKFL OHBBEKBPFPH)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x2C8D770", Offset = "0x2C8C770", VA = "0x182C8D770")]
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
			[Cpp2IlInjected.Address(RVA = "0x29C5D40", Offset = "0x29C4D40", VA = "0x1829C5D40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0x29C5790", Offset = "0x29C4790", VA = "0x1829C5790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action AFFJDIGDOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000967")]
			[Cpp2IlInjected.Address(RVA = "0x29C5830", Offset = "0x29C4830", VA = "0x1829C5830")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000968")]
			[Cpp2IlInjected.Address(RVA = "0x29C56F0", Offset = "0x29C46F0", VA = "0x1829C56F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0x29C5F50", Offset = "0x29C4F50", VA = "0x1829C5F50", Slot = "4")]
		public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x29C5DE0", Offset = "0x29C4DE0", VA = "0x1829C5DE0")]
		public void IIGIGLNPDMN(FHCGLCCCIJI LKIMNIMPHKB, OAPLOPHGFEJ FNAODFKKBJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x29C59C0", Offset = "0x29C49C0", VA = "0x1829C59C0")]
		public void HFEONLCKKIF(FHCGLCCCIJI LKIMNIMPHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x29C5AB0", Offset = "0x29C4AB0", VA = "0x1829C5AB0")]
		internal void HODFAIHJMJB(KBCEGGHPHAF JCLIGOJKKCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x29C4F30", Offset = "0x29C3F30", VA = "0x1829C4F30")]
		private void BODFCFEJING(KBCEGGHPHAF JCLIGOJKKCI, int NDBJIKBMPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x29C5470", Offset = "0x29C4470", VA = "0x1829C5470")]
		private void DIKGBGOLHAP(MIEGLNNJAGB PMOKKAEPEEN, ICGJPAAOHAG LEJFMAICDGC, FFFKDHANALD LGBLGMCEENE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x29C5FB0", Offset = "0x29C4FB0", VA = "0x1829C5FB0")]
		private BEKELKLKBLL MOCPPAMLKIH(MIEGLNNJAGB PMOKKAEPEEN, ICGJPAAOHAG LEJFMAICDGC)
		{
			return default(BEKELKLKBLL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x29C58D0", Offset = "0x29C48D0", VA = "0x1829C58D0")]
		private FFFKDHANALD GEHBJENPHIE(BEKELKLKBLL BDIHABFLOBJ, MIEGLNNJAGB PMOKKAEPEEN, ICGJPAAOHAG LEJFMAICDGC)
		{
			return default(FFFKDHANALD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x29C6180", Offset = "0x29C5180", VA = "0x1829C6180")]
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
			[Cpp2IlInjected.Address(RVA = "0x66B040", Offset = "0x66A040", VA = "0x18066B040", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4ED3CD0", Offset = "0x4ED2CD0", VA = "0x184ED3CD0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000989")]
		[Cpp2IlInjected.Address(RVA = "0xAA5B20", Offset = "0xAA4B20", VA = "0x180AA5B20")]
		[DebuggerHidden]
		public LANIILFHLGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x4ED3AE0", Offset = "0x4ED2AE0", VA = "0x184ED3AE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0x4ED3C90", Offset = "0x4ED2C90", VA = "0x184ED3C90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x4ED3BE0", Offset = "0x4ED2BE0", VA = "0x184ED3BE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<OPJPKCFNLCB> System.Collections.Generic.IEnumerable<RecRoom.Components.SplinePoint>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x4ED3BE0", Offset = "0x4ED2BE0", VA = "0x184ED3BE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x29BEEB0", Offset = "0x29BDEB0", VA = "0x1829BEEB0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private BJBGOMFMFBL NPECBMJOKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0x29BF2B0", Offset = "0x29BE2B0", VA = "0x1829BF2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x29BF090", Offset = "0x29BE090", VA = "0x1829BF090", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x29BE500", Offset = "0x29BD500", VA = "0x1829BE500", Slot = "5")]
	public void AFNIHKGGDKG(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x29BE7D0", Offset = "0x29BD7D0", VA = "0x1829BE7D0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x29BEB60", Offset = "0x29BDB60", VA = "0x1829BEB60")]
	private void HBFLFGEBJIO(Entity MEAOLLJGJLP, in IKKMGBAJNEB HPCIBJGHKFD, in IKKMGBAJNEB GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x29BE600", Offset = "0x29BD600", VA = "0x1829BE600", Slot = "12")]
	public BKJCFABOEMG APJGKMKJAME()
	{
		return default(BKJCFABOEMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x29BE880", Offset = "0x29BD880", VA = "0x1829BE880", Slot = "6")]
	public OPJPKCFNLCB FBHMHHKEIEL(BKJCFABOEMG LGKLIHJHFGE, [Optional] Vector3? LPADDFNBONE, [Optional] Quaternion? OIFAPGIKFEG, [Optional] Vector3? LAMBOPNBCHE)
	{
		return default(OPJPKCFNLCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x29BF520", Offset = "0x29BE520", VA = "0x1829BF520", Slot = "13")]
	public OPJPKCFNLCB PMMLABFHENP(BKJCFABOEMG LGKLIHJHFGE, int MMABPPDCBIB, [Optional] Vector3? LPADDFNBONE, [Optional] Quaternion? OIFAPGIKFEG, [Optional] Vector3? LAMBOPNBCHE)
	{
		return default(OPJPKCFNLCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x29BE6C0", Offset = "0x29BD6C0", VA = "0x1829BE6C0", Slot = "7")]
	public OPJPKCFNLCB BBFIDLPGLPC(BKJCFABOEMG LGKLIHJHFGE, int MMABPPDCBIB)
	{
		return default(OPJPKCFNLCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x29BF220", Offset = "0x29BE220", VA = "0x1829BF220", Slot = "14")]
	public void OKJAJLLLBML(BKJCFABOEMG LGKLIHJHFGE, OPJPKCFNLCB LECJMEPIEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x29BF390", Offset = "0x29BE390", VA = "0x1829BF390", Slot = "8")]
	public void PHGLHFAODGF(BKJCFABOEMG LGKLIHJHFGE, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x29BEF00", Offset = "0x29BDF00", VA = "0x1829BEF00", Slot = "15")]
	public void IILHFEDKPAP(BKJCFABOEMG LGKLIHJHFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0x29BF300", Offset = "0x29BE300", VA = "0x1829BF300", Slot = "9")]
	public int PBIHDNGLINB(BKJCFABOEMG LGKLIHJHFGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0x29BF190", Offset = "0x29BE190", VA = "0x1829BF190", Slot = "10")]
	[IteratorStateMachine(typeof(LANIILFHLGJ))]
	public IEnumerable<OPJPKCFNLCB> NIBBKEJPOOM(BKJCFABOEMG LGKLIHJHFGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x29BF110", Offset = "0x29BE110", VA = "0x1829BF110")]
	private bool LIAFMOILBPM(BKJCFABOEMG LGKLIHJHFGE, out NativeArray<Entity> HFOEOPEIJAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x29BEE00", Offset = "0x29BDE00", VA = "0x1829BEE00")]
	private NativeArray<Entity> HFNGIFNMFLE(BKJCFABOEMG LGKLIHJHFGE)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C85380", Offset = "0x2C84380", VA = "0x182C85380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x2C85640", Offset = "0x2C84640", VA = "0x182C85640", Slot = "4")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x2C85280", Offset = "0x2C84280", VA = "0x182C85280")]
	public void BOABIGFGHGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0x2C853D0", Offset = "0x2C843D0", VA = "0x182C853D0")]
	public void FCHHHKFGLAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x764170", Offset = "0x763170", VA = "0x180764170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x25BCD40", Offset = "0x25BBD40", VA = "0x1825BCD40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Span<T> HEOCDCDMJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x30C8F60", Offset = "0x30C7F60", VA = "0x1830C8F60")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool KJFIOINAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x91CA20", Offset = "0x91BA20", VA = "0x18091CA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099A")]
	[Cpp2IlInjected.Address(RVA = "0x30C9000", Offset = "0x30C8000", VA = "0x1830C9000")]
	public KMNELEKGPOK(int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0x30C8EB0", Offset = "0x30C7EB0", VA = "0x1830C8EB0")]
	public int OCHPPPJPAPL(T CCIMHDCKHOF, int OMKHMNIPPGH, int LGKBEOCJMLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x30C8DF0", Offset = "0x30C7DF0", VA = "0x1830C8DF0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2D8DDB0", Offset = "0x2D8CDB0", VA = "0x182D8DDB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public int FFGDBGPFOJE
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x64A040", Offset = "0x649040", VA = "0x18064A040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x2D8CDA0", Offset = "0x2D8BDA0", VA = "0x182D8CDA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public int MGOGDIHFDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x2D8CB50", Offset = "0x2D8BB50", VA = "0x182D8CB50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E2D0", Offset = "0x2D8D2D0", VA = "0x182D8E2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool KJFIOINAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x2D8D5E0", Offset = "0x2D8C5E0", VA = "0x182D8D5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Span<T> HEOCDCDMJEL
	{
		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E040", Offset = "0x2D8D040", VA = "0x182D8E040")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E4F0", Offset = "0x2D8D4F0", VA = "0x182D8E4F0")]
	public OLKDJHOMLMP(int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x2D8CDF0", Offset = "0x2D8BDF0", VA = "0x182D8CDF0")]
	public T BLGGDAMEJBG(int MMABPPDCBIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D460", Offset = "0x2D8C460", VA = "0x182D8D460")]
	public void DPLNNAEFNOP(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x2D8DED0", Offset = "0x2D8CED0", VA = "0x182D8DED0")]
	public void OHCKMIDAEHB(Span<T> PIJDNOPJENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x2D8CEA0", Offset = "0x2D8BEA0", VA = "0x182D8CEA0")]
	public void CEMPCIEDPMO(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D2E0", Offset = "0x2D8C2E0", VA = "0x182D8D2E0")]
	private void DEOGPKAPNGF(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D8F0", Offset = "0x2D8C8F0", VA = "0x182D8D8F0")]
	public void JLOEGDMEDIN(Span<T> CFFIGFCFHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D890", Offset = "0x2D8C890", VA = "0x182D8D890")]
	public void JLCNKBAMAPK(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x2D8CB80", Offset = "0x2D8BB80", VA = "0x182D8CB80")]
	public void BFGNPBHDOKK(int LLIDIILMDBO, int BDPJJHLGMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0x2D8CFB0", Offset = "0x2D8BFB0", VA = "0x182D8CFB0")]
	public void CLBKMDGGMLI(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D0D0", Offset = "0x2D8C0D0", VA = "0x182D8D0D0")]
	public void DBMHDOPKHCJ(int LLIDIILMDBO, int BDPJJHLGMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AF")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D010", Offset = "0x2D8C010", VA = "0x182D8D010")]
	public void CMBNIOFBIAF(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D4D0", Offset = "0x2D8C4D0", VA = "0x182D8D4D0")]
	public void DPONOCALBOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B1")]
	[Cpp2IlInjected.Address(RVA = "0x2D8DE40", Offset = "0x2D8CE40", VA = "0x182D8DE40")]
	public int OCHPPPJPAPL(T CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B2")]
	[Cpp2IlInjected.Address(RVA = "0x2D8CE40", Offset = "0x2D8BE40", VA = "0x182D8CE40")]
	public bool CBBIGPLMGHA(T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D590", Offset = "0x2D8C590", VA = "0x182D8D590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E480", Offset = "0x2D8D480", VA = "0x182D8E480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D620", Offset = "0x2D8C620", VA = "0x182D8D620")]
	public static Span<T> EDIIAGKPKGG(global::OLKDJHOMLMP<T> PIJDNOPJENO)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0x2D8DC70", Offset = "0x2D8CC70", VA = "0x182D8DC70")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void LBJBFEAFHLP(int CCIMHDCKHOF, int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void PLKLBGELDHE(int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E320", Offset = "0x2D8D320", VA = "0x182D8E320")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void PLKLBGELDHE(int HOPGLJCPGGA, int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B9")]
	[Cpp2IlInjected.Address(RVA = "0x2D8DB30", Offset = "0x2D8CB30", VA = "0x182D8DB30")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void KJCPIPMMKEG(int CCIMHDCKHOF, int HOPGLJCPGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BA")]
	[Cpp2IlInjected.Address(RVA = "0x2D8D690", Offset = "0x2D8C690", VA = "0x182D8D690")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void IPPHJPLIPJD(int LLIDIILMDBO, int BDPJJHLGMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0x2D8E190", Offset = "0x2D8D190", VA = "0x182D8E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CF7CD0", Offset = "0x2CF6CD0", VA = "0x182CF7CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public NativeList<Entity> OGPFBBAMELB
	{
		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0xCF5400", Offset = "0xCF4400", VA = "0x180CF5400")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public TransformAccessArray JFGANGCEAML
	{
		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7E50", Offset = "0x2CF6E50", VA = "0x182CF7E50")]
	public EBPNDNCEIPG(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C0")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7E00", Offset = "0x2CF6E00", VA = "0x182CF7E00")]
	public Entity MGMBLJGHJCJ(int MMABPPDCBIB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C1")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7CE0", Offset = "0x2CF6CE0", VA = "0x182CF7CE0")]
	public Transform IAHHILHKCHF(int MMABPPDCBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009C2")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7CF0", Offset = "0x2CF6CF0", VA = "0x182CF7CF0")]
	public void JHCCIEMAEOA(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7C60", Offset = "0x2CF6C60", VA = "0x182CF7C60")]
	public void EEGBJDDMKHP(int OBIMDJJEEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7B10", Offset = "0x2CF6B10", VA = "0x182CF7B10")]
	public int CEMPCIEDPMO(Transform JDMGKLHBDHC, Entity GDNDJKDEKFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7D40", Offset = "0x2CF6D40", VA = "0x182CF7D40")]
	public int JLCNKBAMAPK(int MMABPPDCBIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7BE0", Offset = "0x2CF6BE0", VA = "0x182CF7BE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7DC0", Offset = "0x2CF6DC0", VA = "0x182CF7DC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C75EE0", Offset = "0x2C74EE0", VA = "0x182C75EE0", Slot = "4")]
	public bool Equals(LinkedEntityGroup ODLLFOGPPIE, LinkedEntityGroup GJCOJHOFJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C75F00", Offset = "0x2C74F00", VA = "0x182C75F00", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup ODMJCJPGHNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public JMGAHKABHJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
internal class MFJHLNFKFAJ
{
	[Cpp2IlInjected.Token(Token = "0x60009CC")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void JOCEDIGPLJE(in Vector3 LPADDFNBONE, in Quaternion OIFAPGIKFEG, in Vector3 LAMBOPNBCHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void BAFKEHCAIME(in Vector3 ODPHDNCCPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void GHGMPNBEBCI(in Quaternion OIFAPGIKFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void PCMCKEKNOGD(in Vector3 EJCENKFLKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void KOOGPAPIACO(in Vector3 EJCENKFLKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void KGLCHOPGKDA(in float KGLKDBPEDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B880", Offset = "0x2C7A880", VA = "0x182C7B880")]
	[Conditional("DEBUG_BUILD")]
	public static void KKEIAKLOCOL(in float3 CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	[Conditional("DEBUG_BUILD")]
	public static void PJPCHHOKEAP(in float CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B930", Offset = "0x2C7A930", VA = "0x182C7B930")]
	[Conditional("DEBUG_BUILD")]
	public static void PJPCHHOKEAP(in Vector3 CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B980", Offset = "0x2C7A980", VA = "0x182C7B980")]
	[Conditional("DEBUG_BUILD")]
	public static void PJPCHHOKEAP(in Quaternion CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B870", Offset = "0x2C7A870", VA = "0x182C7B870")]
	[Conditional("DEBUG_BUILD")]
	public static void IAOGCAGBGAN(in float CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B830", Offset = "0x2C7A830", VA = "0x182C7B830")]
	[Conditional("DEBUG_BUILD")]
	public static void IAOGCAGBGAN(in Vector3 CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x2C7B800", Offset = "0x2C7A800", VA = "0x182C7B800")]
	[Conditional("DEBUG_BUILD")]
	public static void IAOGCAGBGAN(in Quaternion CCIMHDCKHOF, string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C83BD0", Offset = "0x2C82BD0", VA = "0x182C83BD0")]
	public OJEIBILPNMC(Entity GDNDJKDEKFN, Entity CKCPHJMEEKP, Entity ILIAKNFOPLO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x2C83B90", Offset = "0x2C82B90", VA = "0x182C83B90")]
	public static OJEIBILPNMC EDIIAGKPKGG((Entity entity, Entity oldParent, Entity newParent) PNOPKIDJMHM)
	{
		return default(OJEIBILPNMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C83B70", Offset = "0x2C82B70", VA = "0x182C83B70")]
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
	[Cpp2IlInjected.Address(RVA = "0xF59900", Offset = "0xF58900", VA = "0x180F59900")]
	public GGKPENPPBHO(Entity GDNDJKDEKFN, Entity OJKLIAPCMPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFFB0", Offset = "0x2CFEFB0", VA = "0x182CFFFB0")]
	public static GGKPENPPBHO EDIIAGKPKGG((Entity entity, Entity parent) PNOPKIDJMHM)
	{
		return default(GGKPENPPBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x2CFFFA0", Offset = "0x2CFEFA0", VA = "0x182CFFFA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C81E40", Offset = "0x2C80E40", VA = "0x182C81E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x376BF10", Offset = "0x376AF10", VA = "0x18376BF10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x376BFE0", Offset = "0x376AFE0", VA = "0x18376BFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x376C0A0", Offset = "0x376B0A0", VA = "0x18376C0A0")]
	public GIAFLAKDPOD(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x376BFB0", Offset = "0x376AFB0", VA = "0x18376BFB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public KAOIKEPIFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E6")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C80010", Offset = "0x2C7F010", VA = "0x182C80010")]
	public NOKCGGCJCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E8")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public MHLFKHNNDCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EA")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public ACBBCGJMDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0x2CE7530", Offset = "0x2CE6530", VA = "0x182CE7530", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public HLBOPKNHIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C771F0", Offset = "0x2C761F0", VA = "0x182C771F0")]
	public LLDCBEEOJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x2C7A890", Offset = "0x2C79890", VA = "0x182C7A890", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7BA70", Offset = "0x2C7AA70", VA = "0x182C7BA70")]
	public MNGHMLAIBLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BA30", Offset = "0x2C7AA30", VA = "0x182C7BA30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7F770", Offset = "0x2C7E770", VA = "0x182C7F770")]
	public MOKEONFHKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public FNKFLGCDOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public NFEFIFPAFKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public EBPHOJDIANH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public IFKCPPKOEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C81C70", Offset = "0x2C80C70", VA = "0x182C81C70")]
	public OCKGOJALEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C81C60", Offset = "0x2C80C60", VA = "0x182C81C60", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D049A0", Offset = "0x2D039A0", VA = "0x182D049A0")]
	public HCFKCDHPHGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x2D04990", Offset = "0x2D03990", VA = "0x182D04990", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C78F30", Offset = "0x2C77F30", VA = "0x182C78F30")]
	public LDCLJOOJEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A02")]
	[Cpp2IlInjected.Address(RVA = "0x2C78EF0", Offset = "0x2C77EF0", VA = "0x182C78EF0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public DCGGBJHAHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6B50", Offset = "0x2CF5B50", VA = "0x182CF6B50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7BA70", Offset = "0x2C7AA70", VA = "0x182C7BA70")]
	public MGEHCMBJNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x2C7BA30", Offset = "0x2C7AA30", VA = "0x182C7BA30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CF6C90", Offset = "0x2CF5C90", VA = "0x182CF6C90")]
	public DNJEPEHEADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x2CF6C80", Offset = "0x2CF5C80", VA = "0x182CF6C80", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C8E9E0", Offset = "0x2C8D9E0", VA = "0x182C8E9E0")]
	public PGANDFDLKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x2C8E9D0", Offset = "0x2C8D9D0", VA = "0x182C8E9D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CE7FD0", Offset = "0x2CE6FD0", VA = "0x182CE7FD0")]
	public AFIKCBMAKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public KOKEECBINFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public DNLOPGFICBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public LGHMFLEFILI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C771F0", Offset = "0x2C761F0", VA = "0x182C771F0")]
	public ENLPGOOPEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C771F0", Offset = "0x2C761F0", VA = "0x182C771F0")]
	public DEMNAGFOCCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CEF370", Offset = "0x2CEE370", VA = "0x182CEF370", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x2CEF3C0", Offset = "0x2CEE3C0", VA = "0x182CEF3C0")]
	public CLHAAPGNPPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CE8030", Offset = "0x2CE7030", VA = "0x182CE8030")]
	public ALOCMKPAIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C771F0", Offset = "0x2C761F0", VA = "0x182C771F0")]
	public KGMMIPEFBMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2C75920", Offset = "0x2C74920", VA = "0x182C75920", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x2C75970", Offset = "0x2C74970", VA = "0x182C75970")]
	public JAPKGGPDDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C759D0", Offset = "0x2C749D0", VA = "0x182C759D0")]
	public JDECFPGGBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFB0", Offset = "0x29BEFB0", VA = "0x1829BFFB0")]
	public PNHIIFJBMMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C771F0", Offset = "0x2C761F0", VA = "0x182C771F0")]
	public BMLJNPLHOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public KHNOHGEEHNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A28")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CFF990", Offset = "0x2CFE990", VA = "0x182CFF990")]
	public GDBDGCCGNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF980", Offset = "0x2CFE980", VA = "0x182CFF980", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public MEGOJOEBEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public NINPONDAOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x29BFFA0", Offset = "0x29BEFA0", VA = "0x1829BFFA0")]
	public COFJMCNHPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A30")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public HMFPGOJLBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0x2C71700", Offset = "0x2C70700", VA = "0x182C71700", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C771F0", Offset = "0x2C761F0", VA = "0x182C771F0")]
	public CBMCAIGEEEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x2CEF360", Offset = "0x2CEE360", VA = "0x182CEF360", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
	public JDIPJGPIHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C85220", Offset = "0x2C84220", VA = "0x182C85220")]
	public OMOKKIMLPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C7BB30", Offset = "0x2C7AB30", VA = "0x182C7BB30")]
	public MIFNJAIDJOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public ANEEAABEALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C717E0", Offset = "0x2C707E0", VA = "0x182C717E0")]
	public HMNNOPECPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C771F0", Offset = "0x2C761F0", VA = "0x182C771F0")]
	public ANCCMLDCCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public JDBGIEFJMNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C771F0", Offset = "0x2C761F0", VA = "0x182C771F0")]
	public MMNIIKIHIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x2C7DF50", Offset = "0x2C7CF50", VA = "0x182C7DF50", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0")]
	public PIMNFNMOPNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x2C8EEB0", Offset = "0x2C8DEB0", VA = "0x182C8EEB0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C72140", Offset = "0x2C71140", VA = "0x182C72140")]
	public HPHCDNMIOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0x2C72130", Offset = "0x2C71130", VA = "0x182C72130", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2CECF00", Offset = "0x2CEBF00", VA = "0x182CECF00", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4A")]
	[Cpp2IlInjected.Address(RVA = "0x2CECF50", Offset = "0x2CEBF50", VA = "0x182CECF50")]
	public BHOCHHJGBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CFEB80", Offset = "0x2CFDB80", VA = "0x182CFEB80")]
	public FDGPDEOMHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C771F0", Offset = "0x2C761F0", VA = "0x182C771F0")]
	public NDDLHBEAKKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0xF54BA0", Offset = "0xF53BA0", VA = "0x180F54BA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CFF720", Offset = "0x2CFE720", VA = "0x182CFF720", Slot = "5")]
	public void LGPDKIMOJEB(EEAJKGBJNOA AHNMBJFNCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF680", Offset = "0x2CFE680", VA = "0x182CFF680")]
	public bool GGAAJFEABCL(in float3 JMICGAIDJIF, in float3 LBPFPACOALI, float EIEEMLEJCAI, Allocator EGJIMBMGFGA, out NativeArray<Entity> NGCJEBOBKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public FKNOBGCFLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x2CFF680", Offset = "0x2CFE680", VA = "0x182CFF680", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2C75620", Offset = "0x2C74620", VA = "0x182C75620", Slot = "8")]
	protected override bool GAOBNPLOLGE(ReadOnlySpan<AuthoredLocalPoseData> CFFIGFCFHML, NGNDNHAGNEP HDMBHNNBEPE, out ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x2C756A0", Offset = "0x2C746A0", VA = "0x182C756A0", Slot = "9")]
	protected override bool IMBMNGNFONL(int LDFDMKAILBI, Span<AuthoredLocalPoseData> CFFIGFCFHML, in ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x2C75760", Offset = "0x2C74760", VA = "0x182C75760")]
	public INIOKDGONNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[OBPEJBMLPEP(typeof(LocalPoseData))]
public sealed class IPDNNMKHCMN : CABNJLGKDFO
{
	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x2C75770", Offset = "0x2C74770", VA = "0x182C75770", Slot = "8")]
	protected override bool GAOBNPLOLGE(ReadOnlySpan<LocalPoseData> CFFIGFCFHML, NGNDNHAGNEP HDMBHNNBEPE, out ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x2C757F0", Offset = "0x2C747F0", VA = "0x182C757F0", Slot = "9")]
	protected override bool IMBMNGNFONL(int LDFDMKAILBI, Span<LocalPoseData> CFFIGFCFHML, in ReadOnlySpan<byte> AHJGIIFAPKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x2C758B0", Offset = "0x2C748B0", VA = "0x182C758B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB40", Offset = "0x64AB40", VA = "0x18064BB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x29D63E0", Offset = "0x29D53E0", VA = "0x1829D63E0", Slot = "6")]
		public sealed override void KPDEFEPDKBI(IBNALNEANOA FNAODFKKBJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x29D6E10", Offset = "0x29D5E10", VA = "0x1829D6E10", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9AC0", Offset = "0x2CE8AC0", VA = "0x182CE9AC0")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x2CE9BD0", Offset = "0x2CE8BD0", VA = "0x182CE9BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
