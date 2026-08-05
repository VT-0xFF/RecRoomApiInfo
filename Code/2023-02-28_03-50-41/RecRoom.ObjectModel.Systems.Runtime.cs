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
public sealed class NEGFNANBENH<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class HFMFGPNHKGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::NEGFNANBENH<T> NLCBDHAAOGG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] LNGHMKHMGHE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public HFMFGPNHKGD(global::NEGFNANBENH<T> NLCBDHAAOGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class CLINACEILHB : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::NEGFNANBENH<T> <>4__this;

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
		public CLINACEILHB(int <>1__state)
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
	private const int DINACIHCOAJ = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> JMAKKJPMFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int CCCCKCEIGNL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T NLCLIBHDEBL
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
	private bool KGPJMFHBPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool MLNNOJNJAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool FFKBMMAJCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MGGIOFDCCKN
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
	public int HPEOPAJJAFB
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
	public NEGFNANBENH(int ADCMDGEMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public NEGFNANBENH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void MALJADFLDGA(int GFDMFLGCBKB, T DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void GNBOGKPOKGD(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] PCHEOIJAOFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void OHMAHPGMHJM(NativeArray<T> GNPHBMKMMCM, int PCEAKJKGHMM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::NEGFNANBENH<>.CLINACEILHB))]
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
	public int ODPHFPELANF(T DBLPBNJOGMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool OLCIACFECIH(T DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void ADIJFHIILPP(int CLCGPJGBFIO, int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void ODKFKIAFCMA(int CLCGPJGBFIO, int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void IOBDACAINFM(int CLCGPJGBFIO, int JFKBHBKKACD, int JOBJIONNEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int PFJJKIAFNCN(int GFDMFLGCBKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T IGOGFPJMBFD(int GFDMFLGCBKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void PFNFFABMOFC(int GFDMFLGCBKB, T DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void LNJMPBAEIOP(int GFDMFLGCBKB, T DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void GGKOJLEALPE(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int OPPCFLCFOON(int MNIAGKNOHEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int GADGKHEHNAC(int MNIAGKNOHEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void AFDPMBCAPAE(T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void GHOKFIBOBHO(T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T BELDHAMJFFH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T MCDFKMKLHNH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void NDEHPFDNAEI(int GFDMFLGCBKB, IReadOnlyCollection<T> JBEHLAHMLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void PNCMJBIKCJI(int GFDMFLGCBKB, int LICBKGDBJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void LEPDFKBPJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void NPOEPGBHDDI(T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void GHCNALIPBBI(T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void PBAPJAMMOGE(int JFKBHBKKACD, int JOBJIONNEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T NLCILMLBLGE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T OFEEKDDGAEB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[EFMPJBNPDLE]
public static class IFEFIGEPADA
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2C24650", Offset = "0x2C23050", VA = "0x182C24650")]
	static IFEFIGEPADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2236890", Offset = "0x2235290", VA = "0x182236890")]
	public static void ADJPNCFFMOF<T>(T APKDOIJAGNF, ref T DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2C24580", Offset = "0x2C22F80", VA = "0x182C24580")]
	public static void ADJPNCFFMOF(FixedString32 APKDOIJAGNF, ref string DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2C245E0", Offset = "0x2C22FE0", VA = "0x182C245E0")]
	public static void ADJPNCFFMOF(string APKDOIJAGNF, ref FixedString32 DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2C24550", Offset = "0x2C22F50", VA = "0x182C24550")]
	public static void ADJPNCFFMOF(FixedString64 APKDOIJAGNF, ref string DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2C244F0", Offset = "0x2C22EF0", VA = "0x182C244F0")]
	public static void ADJPNCFFMOF(string APKDOIJAGNF, ref FixedString64 DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2C24620", Offset = "0x2C23020", VA = "0x182C24620")]
	public static void ADJPNCFFMOF(FPDPONGCECJ APKDOIJAGNF, ref Vector3 DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2C24380", Offset = "0x2C22D80", VA = "0x182C24380")]
	public static void ADJPNCFFMOF(Vector3 APKDOIJAGNF, ref FPDPONGCECJ DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2C242E0", Offset = "0x2C22CE0", VA = "0x182C242E0")]
	public static void ADJPNCFFMOF(OOAIBJIIGPH APKDOIJAGNF, ref Vector4 DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2C24310", Offset = "0x2C22D10", VA = "0x182C24310")]
	public static void ADJPNCFFMOF(Vector4 APKDOIJAGNF, ref OOAIBJIIGPH DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2C242E0", Offset = "0x2C22CE0", VA = "0x182C242E0")]
	public static void ADJPNCFFMOF(OOAIBJIIGPH APKDOIJAGNF, ref Quaternion DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2C24310", Offset = "0x2C22D10", VA = "0x182C24310")]
	public static void ADJPNCFFMOF(Quaternion APKDOIJAGNF, ref OOAIBJIIGPH DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C245B0", Offset = "0x2C22FB0", VA = "0x182C245B0")]
	public static void ADJPNCFFMOF(FPDPONGCECJ APKDOIJAGNF, ref float3 DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2C24380", Offset = "0x2C22D80", VA = "0x182C24380")]
	public static void ADJPNCFFMOF(float3 APKDOIJAGNF, ref FPDPONGCECJ DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2C244B0", Offset = "0x2C22EB0", VA = "0x182C244B0")]
	public static void ADJPNCFFMOF(OOAIBJIIGPH APKDOIJAGNF, ref float4 DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2C24310", Offset = "0x2C22D10", VA = "0x182C24310")]
	public static void ADJPNCFFMOF(float4 APKDOIJAGNF, ref OOAIBJIIGPH DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2C244B0", Offset = "0x2C22EB0", VA = "0x182C244B0")]
	public static void ADJPNCFFMOF(OOAIBJIIGPH APKDOIJAGNF, ref quaternion DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2C243E0", Offset = "0x2C22DE0", VA = "0x182C243E0")]
	public static void ADJPNCFFMOF(quaternion APKDOIJAGNF, ref OOAIBJIIGPH DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2C24450", Offset = "0x2C22E50", VA = "0x182C24450")]
	public static void ADJPNCFFMOF(Entity APKDOIJAGNF, ref CMHMDONNGAJ DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2C24490", Offset = "0x2C22E90", VA = "0x182C24490")]
	public static void ADJPNCFFMOF(CMHMDONNGAJ APKDOIJAGNF, ref Entity DJMPGCELNKI, MKAJIBPDGLA GMMMMEKOOIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OFACFEGCPFP]
public class NFKJPCNGHLI : ComponentSystem, MMKNGEFLOAO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NKLKBAHCHOA OHOAOEJOHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DPKHLNGAONH MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7031C0", Offset = "0x701BC0", VA = "0x1807031C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8030", Offset = "0x2AE6A30", VA = "0x182AE8030", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
	public NFKJPCNGHLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OFACFEGCPFP]
[UpdateInGroup(typeof(AIEDIMOOFMM))]
internal class FMFPJCLMELM : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C18570", Offset = "0x2C16F70", VA = "0x182C18570", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2C184F0", Offset = "0x2C16EF0", VA = "0x182C184F0")]
	[Preserve]
	private void DBCJEEKINBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public FMFPJCLMELM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[OFACFEGCPFP]
[UpdateInGroup(typeof(AIEDIMOOFMM))]
internal class GGBBPMOLKNG : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A200", Offset = "0x2C18C00", VA = "0x182C1A200", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public GGBBPMOLKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2AF35B0", Offset = "0x2AF1FB0", VA = "0x182AF35B0")]
		public static ObjectModelConfigAsset NPOLBJEHEDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xE1BFB0", Offset = "0xE1A9B0", VA = "0x180E1BFB0")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[LOEOGANCBGC(EDPDLGMLNHJ.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int EBOAMDEGHNP = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly KGOHPJFJCLE LHMILDDMKBL;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x3FFA8E0", Offset = "0x3FF92E0", VA = "0x183FFA8E0")]
			public static AKLFKNOOHJC KDGKKIPMHJG(int JEGOOADMALM)
			{
				return default(AKLFKNOOHJC);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x3FFACD0", Offset = "0x3FF96D0", VA = "0x183FFACD0")]
			private static void PMKLJFJAHPC(DFKOJFHJBPL ELEHNMDGIDB, DFKOJFHJBPL BFJHPACKLMI, AKLFKNOOHJC AOCEENCOLMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x3FFA710", Offset = "0x3FF9110", VA = "0x183FFA710")]
			public static int JKNCAKJNMLP(GameObject KEHOIMKGHCH)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x3FFA690", Offset = "0x3FF9090", VA = "0x183FFA690")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void CMPNOFOADJO(DFKOJFHJBPL PMMCMCPNCLD, int JEGOOADMALM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static PLIBOCMCGIC KCKJCMPILDG;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static LFHKDFGBJPJ LAHDFCJFOKE;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static PLIBOCMCGIC NOEMDOJLBGM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4010", Offset = "0x2AF2A10", VA = "0x182AF4010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3650", Offset = "0x2AF2050", VA = "0x182AF3650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static LFHKDFGBJPJ MKNLADHOOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4E00", Offset = "0x2AF3800", VA = "0x182AF4E00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3D30", Offset = "0x2AF2730", VA = "0x182AF3D30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static bool MDHIJDHJFCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5190", Offset = "0x2AF3B90", VA = "0x182AF5190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static NKLKBAHCHOA OHOAOEJOHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4C60", Offset = "0x2AF3660", VA = "0x182AF4C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static DPKHLNGAONH MBHDHAMHFAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4170", Offset = "0x2AF2B70", VA = "0x182AF4170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static DGINFINNHOA CLMKLDLCBAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4510", Offset = "0x2AF2F10", VA = "0x182AF4510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static EBIDIPICLGG NBHKGKINMJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3730", Offset = "0x2AF2130", VA = "0x182AF3730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static HGFGJIKNIPL AHIPFOPLBPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3940", Offset = "0x2AF2340", VA = "0x182AF3940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static LAIKDFLJMKI NHHBDODJKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3B90", Offset = "0x2AF2590", VA = "0x182AF3B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool LPBEELCKFMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2AF41F0", Offset = "0x2AF2BF0", VA = "0x182AF41F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool CJJHGODGAFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3810", Offset = "0x2AF2210", VA = "0x182AF3810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool LIPAJACPMFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4740", Offset = "0x2AF3140", VA = "0x182AF4740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static bool GCNPADDLMME
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4330", Offset = "0x2AF2D30", VA = "0x182AF4330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3FB0", Offset = "0x2AF29B0", VA = "0x182AF3FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool MKDICMPBFLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF42D0", Offset = "0x2AF2CD0", VA = "0x182AF42D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2AF46E0", Offset = "0x2AF30E0", VA = "0x182AF46E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		internal static event Action CPLFJIEMCBI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4D00", Offset = "0x2AF3700", VA = "0x182AF4D00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF4070", Offset = "0x2AF2A70", VA = "0x182AF4070")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF39C0", Offset = "0x2AF23C0", VA = "0x182AF39C0")]
		public static DFKOJFHJBPL DHDNGOHCFIF(GameObject KEHOIMKGHCH)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF37B0", Offset = "0x2AF21B0", VA = "0x182AF37B0")]
		public static bool CLOEECIKNOA(ByteString DBKEJGOGOOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3C10", Offset = "0x2AF2610", VA = "0x182AF3C10")]
		public static POPHLPHEEBM EPBPAFABDJA(AKLFKNOOHJC AOCEENCOLMM)
		{
			return default(POPHLPHEEBM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4590", Offset = "0x2AF2F90", VA = "0x182AF4590")]
		public static (ByteString, IDisposable) JHPOCMCIPNJ()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4F20", Offset = "0x2AF3920", VA = "0x182AF4F20")]
		public static (ByteString, IDisposable) OPPJDEFPPHD(IEnumerable<DFKOJFHJBPL> BPPOAHFNBEH)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4B30", Offset = "0x2AF3530", VA = "0x182AF4B30")]
		public static bool KOMOMOEACNP(GameObject KEHOIMKGHCH, out AKLFKNOOHJC AOCEENCOLMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5070", Offset = "0x2AF3A70", VA = "0x182AF5070")]
		public static bool PBEDEGPKDBA(IEnumerable<DMEOMGPBNBN> EMJPLLBFAOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3AB0", Offset = "0x2AF24B0", VA = "0x182AF3AB0")]
		public static void DHNFMPODOCO(bool JECBMIHPMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4390", Offset = "0x2AF2D90", VA = "0x182AF4390")]
		public static Task JCAKBKFBLEA(bool JECBMIHPMOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4A50", Offset = "0x2AF3450", VA = "0x182AF4A50")]
		private static LFHKDFGBJPJ KKIKEFGLHOL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2AF4930", Offset = "0x2AF3330", VA = "0x182AF4930")]
		private static bool KKEDGNLJGAE()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Registration)]
	public static class ObjectViewRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFA000", Offset = "0x2AF8A00", VA = "0x182AFA000")]
		public static bool PEONCIALENF(HBIBAGENGHJ JJFKGAKEAKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9DD0", Offset = "0x2AF87D0", VA = "0x182AF9DD0")]
		public static HBIBAGENGHJ OGMDKKEHOIN(GameObject KEHOIMKGHCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9BD0", Offset = "0x2AF85D0", VA = "0x182AF9BD0")]
		public static HBIBAGENGHJ OGMDKKEHOIN(GameObject KEHOIMKGHCH, AKLFKNOOHJC AOCEENCOLMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2AF97E0", Offset = "0x2AF81E0", VA = "0x182AF97E0")]
		public static bool AFAOEHOPMKL(GameObject ICDBBFEMLLL, string PDKJCGANJMP, bool GGLICGMPONL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2AF98E0", Offset = "0x2AF82E0", VA = "0x182AF98E0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void BPIDJGMJFHN(GameObject ICDBBFEMLLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9AE0", Offset = "0x2AF84E0", VA = "0x182AF9AE0")]
		[CompilerGenerated]
		internal static string NPFBIPFDJFH((GameObject go, string prefabName) KGNEMFGHDAD)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DisembodiedObjectView : MonoBehaviour, NGDEDBHGIBI
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool HNCHBAEIKCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public DFKOJFHJBPL LIBEOLBPDGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6E2040", Offset = "0x6E0A40", VA = "0x1806E2040", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(DFKOJFHJBPL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x259D4D0", Offset = "0x259BED0", VA = "0x18259D4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleComponent]
	[LOEOGANCBGC(EDPDLGMLNHJ.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, HBIBAGENGHJ, NGDEDBHGIBI
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string ICKLJOFCAEC = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ICBHOPCBAFI MKPFHFLNAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private DFKOJFHJBPL EFHLICFAAGO;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public DFKOJFHJBPL LIBEOLBPDGH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2E09590", Offset = "0x2E07F90", VA = "0x182E09590", Slot = "15")]
			get
			{
				return default(DFKOJFHJBPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public POPHLPHEEBM DGOIOLAFIPD
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2E09640", Offset = "0x2E08040", VA = "0x182E09640", Slot = "6")]
			get
			{
				return default(POPHLPHEEBM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool HNCHBAEIKCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2E09580", Offset = "0x2E07F80", VA = "0x182E09580", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ICBHOPCBAFI MFLHBGHJMAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x99B530", Offset = "0x999F30", VA = "0x18099B530", Slot = "7")]
			get
			{
				return default(ICBHOPCBAFI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private DPKHLNGAONH MBHDHAMHFAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2E08CB0", Offset = "0x2E076B0", VA = "0x182E08CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private JOHEJCALJIO CHJJBHMIKNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2E09390", Offset = "0x2E07D90", VA = "0x182E09390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool CKHFNGINNPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x7B1F80", Offset = "0x7B0980", VA = "0x1807B1F80", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x77B170", Offset = "0x779B70", VA = "0x18077B170", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> GLHCANNPFEM
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x2E09440", Offset = "0x2E07E40", VA = "0x182E09440")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x2E09670", Offset = "0x2E08070", VA = "0x182E09670")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<HBIBAGENGHJ> MAAOMMKEHJA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2E094E0", Offset = "0x2E07EE0", VA = "0x182E094E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2E09710", Offset = "0x2E08110", VA = "0x182E09710", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2E08950", Offset = "0x2E07350", VA = "0x182E08950")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2E09240", Offset = "0x2E07C40", VA = "0x182E09240", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2E08EF0", Offset = "0x2E078F0", VA = "0x182E08EF0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2E091B0", Offset = "0x2E07BB0", VA = "0x182E091B0", Slot = "10")]
		public void OnEmbody(DEAGKEFEBKN HDJFKDANOCN, DFKOJFHJBPL EFHLICFAAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2E09230", Offset = "0x2E07C30", VA = "0x182E09230", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2E08FA0", Offset = "0x2E079A0", VA = "0x182E08FA0", Slot = "12")]
		public void OnDisembody(bool EHDMKDFKFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2E08D90", Offset = "0x2E07790", VA = "0x182E08D90")]
		private void KOLAFOMENDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2E08B30", Offset = "0x2E07530", VA = "0x182E08B30")]
		private void EILLAGKIDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x2E08BC0", Offset = "0x2E075C0", VA = "0x182E08BC0")]
		private void FHBBHDHANMM(bool CIALKMDELLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2E08E90", Offset = "0x2E07890", VA = "0x182E08E90", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1090E00", Offset = "0x108F800", VA = "0x181090E00", Slot = "9")]
		private GameObject DBGDDABJHKE()
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

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	[LOEOGANCBGC(EDPDLGMLNHJ.Registration)]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override AOIKBHJMDBO OLGANNLAKEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x2B050A0", Offset = "0x2B03AA0", VA = "0x182B050A0", Slot = "6")]
			get
			{
				return default(AOIKBHJMDBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B05040", Offset = "0x2B03A40", VA = "0x182B05040")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[LOEOGANCBGC(EDPDLGMLNHJ.Registration)]
	public class TransformEntity : MonoBehaviour, NGDEDBHGIBI
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private AOIKBHJMDBO prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private DFKOJFHJBPL PMMCMCPNCLD;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual AOIKBHJMDBO OLGANNLAKEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0", Slot = "6")]
			get
			{
				return default(AOIKBHJMDBO);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x765410", Offset = "0x763E10", VA = "0x180765410", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public DFKOJFHJBPL LIBEOLBPDGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xBF2C40", Offset = "0xBF1640", VA = "0x180BF2C40", Slot = "5")]
			get
			{
				return default(DFKOJFHJBPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool HNCHBAEIKCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6C1030", Offset = "0x6BFA30", VA = "0x1806C1030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xA2B870", Offset = "0xA2A270", VA = "0x180A2B870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal Entity BHDJCIPFNNF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		internal HGFGJIKNIPL AHIPFOPLBPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		internal JOHEJCALJIO AJCEPDOMKOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x2C05A30", Offset = "0x2C04430", VA = "0x182C05A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C05550", Offset = "0x2C03F50", VA = "0x182C05550")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x2C05910", Offset = "0x2C04310", VA = "0x182C05910")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x2C05600", Offset = "0x2C04000", VA = "0x182C05600")]
		internal void JGKFDHOAMGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C05560", Offset = "0x2C03F60", VA = "0x182C05560")]
		private bool GGHOLLNPGJI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C05A00", Offset = "0x2C04400", VA = "0x182C05A00")]
		private void JOHOPAJPIJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C05910", Offset = "0x2C04310", VA = "0x182C05910")]
		internal void JJOEMGIHELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C05AA0", Offset = "0x2C044A0", VA = "0x182C05AA0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C05B80", Offset = "0x2C04580", VA = "0x182C05B80")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DNOPHNKOHLA(typeof(LFHKDFGBJPJ), new string[] { })]
[AKBJAGIAKDO(typeof(CGCFBBFKDEL))]
public class GGEPMBEMDJE : LFHKDFGBJPJ, HFHAMBGAEFF, CGCFBBFKDEL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private IGIBMKFLGBD BKJAOJMOJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private DPKHLNGAONH DBKMNLNGAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private LFIFNADKAEF EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private OHLJMGEOGPF PGFCMPHCIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private IHIPHIAICBG JAINECODPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private PEIGBAPLOKK NLDFOPANEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IGIBMKFLGBD OHOAOEJOHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public LFIFNADKAEF KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public DPKHLNGAONH MBHDHAMHFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IHIPHIAICBG FMHHHIIODEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public PEIGBAPLOKK JDNLHKJJKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool JDCINNHHEGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x873B50", Offset = "0x872550", VA = "0x180873B50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FCANJHPHPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C1A6E0", Offset = "0x2C190E0", VA = "0x182C1A6E0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NAJLEECMFPG IGMFGBGPOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x92E060", Offset = "0x92CA60", VA = "0x18092E060", Slot = "10")]
		get
		{
			return default(NAJLEECMFPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A3B0", Offset = "0x2C18DB0", VA = "0x182C1A3B0")]
	public static GGEPMBEMDJE GANMJPNFBJN(IGIBMKFLGBD BKJAOJMOJPF, MGEKGGAJIBD HLCFNPLAIJP = MGEKGGAJIBD.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	private static void INACEMMHMJO(IGIBMKFLGBD BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	private static void MHDCHDBILMH(IGIBMKFLGBD BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A590", Offset = "0x2C18F90", VA = "0x182C1A590", Slot = "11")]
	public void KMAONFGIHCN(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x24DFC30", Offset = "0x24DE630", VA = "0x1824DFC30")]
	private void BEJHKBIOAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A4A0", Offset = "0x2C18EA0", VA = "0x182C1A4A0")]
	private void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	private void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A350", Offset = "0x2C18D50", VA = "0x182C1A350", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public GGEPMBEMDJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JJHNMOEGDLL
{
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2C2B3D0", Offset = "0x2C29DD0", VA = "0x182C2B3D0")]
	public static POPHLPHEEBM NELDJHBEBDP(this LFHKDFGBJPJ LAHDFCJFOKE, AKLFKNOOHJC AOCEENCOLMM, AOIKBHJMDBO GDAJCNKPBDC)
	{
		return default(POPHLPHEEBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C2B0D0", Offset = "0x2C29AD0", VA = "0x182C2B0D0")]
	public static KAEJCOGFAOC CBDGNLKCMJD(this LFHKDFGBJPJ LAHDFCJFOKE)
	{
		return default(KAEJCOGFAOC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2C2B1F0", Offset = "0x2C29BF0", VA = "0x182C2B1F0")]
	public static DFKOJFHJBPL DHDNGOHCFIF(this LFHKDFGBJPJ LAHDFCJFOKE, Entity GOANOLJBHPF)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2C2B2A0", Offset = "0x2C29CA0", VA = "0x182C2B2A0")]
	public static DFKOJFHJBPL DHDNGOHCFIF(this LFHKDFGBJPJ LAHDFCJFOKE, AKLFKNOOHJC AOCEENCOLMM)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2C2B510", Offset = "0x2C29F10", VA = "0x182C2B510")]
	public static AKLFKNOOHJC OOMNOMGKKMO(this LFHKDFGBJPJ LAHDFCJFOKE, DFKOJFHJBPL PMMCMCPNCLD)
	{
		return default(AKLFKNOOHJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[Flags]
public enum MGEKGGAJIBD
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DNOPHNKOHLA(typeof(PEIGBAPLOKK), new string[] { })]
public class DAKFMLCABNL : PEIGBAPLOKK, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[JIFPDEDMPGC]
	private CGCFBBFKDEL HHKHFGCMHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private IGIBMKFLGBD BKJAOJMOJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private FCADPKIAEAJ JAINECODPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private OHLJMGEOGPF PGFCMPHCIKE;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GIEPDDFBBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2E00240", Offset = "0x2DFEC40", VA = "0x182E00240", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2E002E0", Offset = "0x2DFECE0", VA = "0x182E002E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2E00490", Offset = "0x2DFEE90", VA = "0x182E00490", Slot = "16")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2E00640", Offset = "0x2DFF040", VA = "0x182E00640", Slot = "13")]
	public void LNENNPPILDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "6")]
	public void JCEINNNJCGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2E001F0", Offset = "0x2DFEBF0", VA = "0x182E001F0", Slot = "7")]
	public void BCGCLIKNJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2E00540", Offset = "0x2DFEF40", VA = "0x182E00540", Slot = "8")]
	public void HDCMICPECIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x17AFBF0", Offset = "0x17AE5F0", VA = "0x1817AFBF0", Slot = "9")]
	public void FKDGDIOHBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2E00680", Offset = "0x2DFF080", VA = "0x182E00680", Slot = "10")]
	public void MDDCFGJOPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2E006D0", Offset = "0x2DFF0D0", VA = "0x182E006D0", Slot = "11")]
	public bool PBEDEGPKDBA(IEnumerable<DMEOMGPBNBN> EMJPLLBFAOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2E00380", Offset = "0x2DFED80", VA = "0x182E00380", Slot = "12")]
	public void DGBFGGFLFPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2E005C0", Offset = "0x2DFEFC0", VA = "0x182E005C0", Slot = "14")]
	public void JHKPODDCHJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2E003D0", Offset = "0x2DFEDD0", VA = "0x182E003D0", Slot = "15")]
	public void GENFMKINDFO(bool KODHDLHLAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E00610", Offset = "0x2DFF010", VA = "0x182E00610")]
	private void KOBAHCOJBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public DAKFMLCABNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DNOPHNKOHLA(typeof(IHIPHIAICBG), new string[] { })]
public class HOFIHAPHBKJ : IHIPHIAICBG, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[JIFPDEDMPGC]
	private CGCFBBFKDEL HHKHFGCMHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private IGIBMKFLGBD BKJAOJMOJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private FCADPKIAEAJ JAINECODPLG;

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2C21010", Offset = "0x2C1FA10", VA = "0x182C21010", Slot = "6")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C210A0", Offset = "0x2C1FAA0", VA = "0x182C210A0", Slot = "4")]
	public ByteString JHPOCMCIPNJ(out IDisposable DBHMONFNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C20EF0", Offset = "0x2C1F8F0", VA = "0x182C20EF0", Slot = "5")]
	public void AJGJBLGJHIK(ByteString NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HOFIHAPHBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class HPHDKDPLNJH<T> : global::DPGNOJNMADF<T>, global::DABFAGPIBGD<AKLFKNOOHJC, T>, global::DOCNCNKJBDA<AKLFKNOOHJC>, HBMFMFPPKEB, IDisposable, ABCMNOFLGBA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly global::DOCNCNKJBDA<Entity> OPPPBNFKNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private Delegate IJFPAECDNJD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3603340", Offset = "0x3601D40", VA = "0x183603340", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Type LMEMDFLMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3608100", Offset = "0x3606B00", VA = "0x183608100", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GFMIPKBGENN EAPMLLCMPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x360C030", Offset = "0x360AA30", VA = "0x18360C030", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int CLAMCCCBPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x360BCC0", Offset = "0x360A6C0", VA = "0x18360BCC0", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DIEFECFNKJE IDIBJHDFMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x360E3C0", Offset = "0x360CDC0", VA = "0x18360E3C0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xF65A20", Offset = "0xF64420", VA = "0x180F65A20", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3603140", Offset = "0x3601B40", VA = "0x183603140", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::MEBIEMHBDCI<AKLFKNOOHJC> CPLFJIEMCBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x360C930", Offset = "0x360B330", VA = "0x18360C930", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3609560", Offset = "0x3607F60", VA = "0x183609560", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x23A7340", Offset = "0x23A5D40", VA = "0x1823A7340")]
	public HPHDKDPLNJH(global::DOCNCNKJBDA<Entity> OPPPBNFKNOC, HGFGJIKNIPL CPFOJDHADNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x360C400", Offset = "0x360AE00", VA = "0x18360C400")]
	private Entity KHECJIFKKPO(AKLFKNOOHJC AOCEENCOLMM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x360C0B0", Offset = "0x360AAB0", VA = "0x18360C0B0")]
	private AKLFKNOOHJC KHECJIFKKPO(Entity GOANOLJBHPF)
	{
		return default(AKLFKNOOHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3601A90", Offset = "0x3600490", VA = "0x183601A90", Slot = "4")]
	public T AGGAFJIIBKL(AKLFKNOOHJC AOCEENCOLMM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x360D6E0", Offset = "0x360C0E0", VA = "0x18360D6E0")]
	public bool NLANNFAIKGA(AKLFKNOOHJC AOCEENCOLMM, in T ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3608C30", Offset = "0x3607630", VA = "0x183608C30")]
	public bool FGEIEGOCCHP(AKLFKNOOHJC AOCEENCOLMM, in T ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3607F20", Offset = "0x3606920", VA = "0x183607F20", Slot = "9")]
	public bool FDOEJMJEMDK(AKLFKNOOHJC AOCEENCOLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3604ED0", Offset = "0x36038D0", VA = "0x183604ED0", Slot = "26")]
	public object DBLBKAHEJCH(AKLFKNOOHJC AOCEENCOLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3609A10", Offset = "0x3608410", VA = "0x183609A10")]
	public bool HGPNDIJHPNA(AKLFKNOOHJC AOCEENCOLMM, in object ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3602CD0", Offset = "0x36016D0", VA = "0x183602CD0")]
	public void AGGAFJIIBKL(AKLFKNOOHJC AOCEENCOLMM, in BOPFHHNILGH MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x360DAC0", Offset = "0x360C4C0", VA = "0x18360DAC0")]
	public bool NLANNFAIKGA(AKLFKNOOHJC AOCEENCOLMM, in DHBMIEMIIHO ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3608BB0", Offset = "0x36075B0", VA = "0x183608BB0")]
	public bool FGEIEGOCCHP(AKLFKNOOHJC AOCEENCOLMM, in DHBMIEMIIHO ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2396400", Offset = "0x2394E00", VA = "0x182396400", Slot = "22")]
	public void CIOHKMIJCIH(MKGBMKAAJEJ OFPIDICLDMA, [Optional] object CGFEOLDGFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x36043B0", Offset = "0x3602DB0", VA = "0x1836043B0", Slot = "15")]
	public void CIOHKMIJCIH(AKLFKNOOHJC AJPNMLHDHNM, PGGKBIPLEDG OFPIDICLDMA, object CGFEOLDGFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x360DF90", Offset = "0x360C990", VA = "0x18360DF90", Slot = "14")]
	public bool OOHGDHPLHLD(AKLFKNOOHJC DJMPGCELNKI, AKLFKNOOHJC APKDOIJAGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x235FD40", Offset = "0x235E740", VA = "0x18235FD40", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x360E4B0", Offset = "0x360CEB0", VA = "0x18360E4B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3601930", Offset = "0x3600330", VA = "0x183601930")]
	public string ACNDEKJFKHH(in DHBMIEMIIHO DKOOMNPILLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x3603D20", Offset = "0x3602720", VA = "0x183603D20")]
	private void CEBPALAKFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3605CC0", Offset = "0x36046C0", VA = "0x183605CC0")]
	private void DGCGPOABMIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x3607820", Offset = "0x3606220", VA = "0x183607820")]
	private void FCPDKPNIIBI(Entity GOANOLJBHPF, in DHBMIEMIIHO FAAGLIPDKEL, in DHBMIEMIIHO ONFBDMEKEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x360CB40", Offset = "0x360B540", VA = "0x18360CB40")]
	private void MFNIONMGGCN(Entity GOANOLJBHPF, in DHBMIEMIIHO FAAGLIPDKEL, in DHBMIEMIIHO ONFBDMEKEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x360B1D0", Offset = "0x3609BD0", VA = "0x18360B1D0")]
	[Conditional("DEBUG_BUILD")]
	private static void HPFPCALGEMB(Entity GOANOLJBHPF, AKLFKNOOHJC AOCEENCOLMM, string IJEJFFCLBDM, string OPKIILHADIF, [CallerMemberName] string MLMCPJPAMFK = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2898FE0", Offset = "0x28979E0", VA = "0x182898FE0", Slot = "5")]
	private bool MIPKBMLAJGB(AKLFKNOOHJC AJPNMLHDHNM, in T ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x360CFA0", Offset = "0x360B9A0", VA = "0x18360CFA0", Slot = "6")]
	private bool MNPHCNMBGCH(AKLFKNOOHJC AJPNMLHDHNM, in T ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3609110", Offset = "0x3607B10", VA = "0x183609110", Slot = "10")]
	private bool GLODBMNKJGF(AKLFKNOOHJC AJPNMLHDHNM, in object ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x360C080", Offset = "0x360AA80", VA = "0x18360C080", Slot = "11")]
	private void JDFCANOJDHI(AKLFKNOOHJC AJPNMLHDHNM, in BOPFHHNILGH MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3604DD0", Offset = "0x36037D0", VA = "0x183604DD0", Slot = "12")]
	private bool CKIKOFAIOKE(AKLFKNOOHJC AJPNMLHDHNM, in DHBMIEMIIHO ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3603430", Offset = "0x3601E30", VA = "0x183603430", Slot = "13")]
	private bool BJNBBEAGPPM(AKLFKNOOHJC AJPNMLHDHNM, in DHBMIEMIIHO ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x23A5F00", Offset = "0x23A4900", VA = "0x1823A5F00", Slot = "16")]
	private string CEPIHFOPONP(in DHBMIEMIIHO MNIAGKNOHEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class ILMNIKBAHLP<T> : global::NENALMGBADL<T>, global::DABFAGPIBGD<DFKOJFHJBPL, T>, global::DOCNCNKJBDA<DFKOJFHJBPL>, HBMFMFPPKEB, IDisposable, KNCBBMLNKLK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly global::DOCNCNKJBDA<Entity> OPPPBNFKNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Delegate IJFPAECDNJD;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x40FB150", Offset = "0x40F9B50", VA = "0x1840FB150", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type LMEMDFLMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4107820", Offset = "0x4106220", VA = "0x184107820", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public GFMIPKBGENN EAPMLLCMPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x410D820", Offset = "0x410C220", VA = "0x18410D820", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int CLAMCCCBPDO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x410D550", Offset = "0x410BF50", VA = "0x18410D550", Slot = "21")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DIEFECFNKJE IDIBJHDFMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4111CD0", Offset = "0x41106D0", VA = "0x184111CD0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public T NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2393CC0", Offset = "0x23926C0", VA = "0x182393CC0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2393BC0", Offset = "0x23925C0", VA = "0x182393BC0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event global::MEBIEMHBDCI<DFKOJFHJBPL> CPLFJIEMCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x410E8C0", Offset = "0x410D2C0", VA = "0x18410E8C0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x410A180", Offset = "0x4108B80", VA = "0x18410A180", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x23A7340", Offset = "0x23A5D40", VA = "0x1823A7340")]
	public ILMNIKBAHLP(global::DOCNCNKJBDA<Entity> OPPPBNFKNOC, HGFGJIKNIPL CPFOJDHADNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1D6BCA0", Offset = "0x1D6A6A0", VA = "0x181D6BCA0")]
	private Entity KHECJIFKKPO(DFKOJFHJBPL PMMCMCPNCLD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x23A2E80", Offset = "0x23A1880", VA = "0x1823A2E80")]
	private DFKOJFHJBPL KHECJIFKKPO(Entity GOANOLJBHPF)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x40F8720", Offset = "0x40F7120", VA = "0x1840F8720", Slot = "4")]
	public T AGGAFJIIBKL(DFKOJFHJBPL PMMCMCPNCLD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4110010", Offset = "0x410EA10", VA = "0x184110010")]
	public bool NLANNFAIKGA(DFKOJFHJBPL PMMCMCPNCLD, in T ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4109200", Offset = "0x4107C00", VA = "0x184109200")]
	public bool FGEIEGOCCHP(DFKOJFHJBPL PMMCMCPNCLD, in T ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4107460", Offset = "0x4105E60", VA = "0x184107460", Slot = "9")]
	public bool FDOEJMJEMDK(DFKOJFHJBPL PMMCMCPNCLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x23976B0", Offset = "0x23960B0", VA = "0x1823976B0", Slot = "26")]
	public object DBLBKAHEJCH(DFKOJFHJBPL PMMCMCPNCLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x410BBD0", Offset = "0x410A5D0", VA = "0x18410BBD0")]
	public bool HGPNDIJHPNA(DFKOJFHJBPL PMMCMCPNCLD, in object ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x40F9350", Offset = "0x40F7D50", VA = "0x1840F9350")]
	public void AGGAFJIIBKL(DFKOJFHJBPL PMMCMCPNCLD, in BOPFHHNILGH MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x23A4440", Offset = "0x23A2E40", VA = "0x1823A4440")]
	public bool NLANNFAIKGA(DFKOJFHJBPL PMMCMCPNCLD, in DHBMIEMIIHO ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x239E4E0", Offset = "0x239CEE0", VA = "0x18239E4E0")]
	public bool FGEIEGOCCHP(DFKOJFHJBPL PMMCMCPNCLD, in DHBMIEMIIHO ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2396400", Offset = "0x2394E00", VA = "0x182396400", Slot = "22")]
	public void CIOHKMIJCIH(MKGBMKAAJEJ OFPIDICLDMA, [Optional] object CGFEOLDGFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x40FF1C0", Offset = "0x40FDBC0", VA = "0x1840FF1C0", Slot = "15")]
	public void CIOHKMIJCIH(DFKOJFHJBPL AJPNMLHDHNM, PGGKBIPLEDG OFPIDICLDMA, object CGFEOLDGFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x23A6300", Offset = "0x23A4D00", VA = "0x1823A6300", Slot = "14")]
	public bool OOHGDHPLHLD(DFKOJFHJBPL DJMPGCELNKI, DFKOJFHJBPL APKDOIJAGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x40FD9F0", Offset = "0x40FC3F0", VA = "0x1840FD9F0")]
	private void CEBPALAKFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x40FFFD0", Offset = "0x40FE9D0", VA = "0x1840FFFD0")]
	private void DGCGPOABMIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4101FB0", Offset = "0x41009B0", VA = "0x184101FB0")]
	private void FCPDKPNIIBI(Entity GOANOLJBHPF, in DHBMIEMIIHO FAAGLIPDKEL, in DHBMIEMIIHO ONFBDMEKEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x410EA20", Offset = "0x410D420", VA = "0x18410EA20")]
	private void MFNIONMGGCN(Entity GOANOLJBHPF, in DHBMIEMIIHO FAAGLIPDKEL, in DHBMIEMIIHO ONFBDMEKEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x23997B0", Offset = "0x23981B0", VA = "0x1823997B0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4112130", Offset = "0x4110B30", VA = "0x184112130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3601930", Offset = "0x3600330", VA = "0x183601930")]
	public string ACNDEKJFKHH(in DHBMIEMIIHO DKOOMNPILLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2393B40", Offset = "0x2392540", VA = "0x182393B40", Slot = "5")]
	private bool CJHGEOLGKKK(DFKOJFHJBPL AJPNMLHDHNM, in T ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2394210", Offset = "0x2392C10", VA = "0x182394210", Slot = "6")]
	private bool CAELBOEIPFO(DFKOJFHJBPL AJPNMLHDHNM, in T ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x239FEC0", Offset = "0x239E8C0", VA = "0x18239FEC0", Slot = "10")]
	private bool FMNKFOOJKFK(DFKOJFHJBPL AJPNMLHDHNM, in object ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x23A29E0", Offset = "0x23A13E0", VA = "0x1823A29E0", Slot = "11")]
	private void IKLEPJICADN(DFKOJFHJBPL AJPNMLHDHNM, in BOPFHHNILGH MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2393C80", Offset = "0x2392680", VA = "0x182393C80", Slot = "12")]
	private bool BABFPJMKBJK(DFKOJFHJBPL AJPNMLHDHNM, in DHBMIEMIIHO ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x23A6A40", Offset = "0x23A5440", VA = "0x1823A6A40", Slot = "13")]
	private bool PMLKOKPIPGM(DFKOJFHJBPL AJPNMLHDHNM, in DHBMIEMIIHO ONFBDMEKEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x23A5F00", Offset = "0x23A4900", VA = "0x1823A5F00", Slot = "16")]
	private string NPKAOGEEAHJ(in DHBMIEMIIHO MNIAGKNOHEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OANDAJOBGIN : IDisposable, AENEDCLILGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> PEBFJPNHLBB;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> JDLCDBDGLBA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xCC7400", Offset = "0xCC5E00", VA = "0x180CC7400", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xCCCDD0", Offset = "0xCCB7D0", VA = "0x180CCCDD0")]
	public OANDAJOBGIN(NativeArray<EntityRemapUtility.EntityRemapInfo> PEBFJPNHLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9C30", Offset = "0x2AE8630", VA = "0x182AE9C30", Slot = "6")]
	public DFKOJFHJBPL BLIALODHHOH(DFKOJFHJBPL PMMCMCPNCLD)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9C20", Offset = "0x2AE8620", VA = "0x182AE9C20", Slot = "7")]
	public Entity BLIALODHHOH(Entity GOANOLJBHPF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9B80", Offset = "0x2AE8580", VA = "0x182AE9B80", Slot = "8")]
	public IEnumerable<DFKOJFHJBPL> BLIALODHHOH(IEnumerable<DFKOJFHJBPL> BPPOAHFNBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9C80", Offset = "0x2AE8680", VA = "0x182AE9C80", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Serialization)]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly KGOHPJFJCLE NCJEIIADPNH;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static int CGCBBIDAMHL;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static AENEDCLILGP LEIENNNIAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool JCLEBDPANBO;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> JDLCDBDGLBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x2BFE030", Offset = "0x2BFCA30", VA = "0x182BFE030")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static bool MDKBHHJGOBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2BFDFA0", Offset = "0x2BFC9A0", VA = "0x182BFDFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2BFDE30", Offset = "0x2BFC830", VA = "0x182BFDE30")]
		public static SerializationRemapScope DKIJBLCKPNA()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2BFE1D0", Offset = "0x2BFCBD0", VA = "0x182BFE1D0")]
		public SerializationRemapScope(AENEDCLILGP OOAILEEJKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x2BFDE90", Offset = "0x2BFC890", VA = "0x182BFDE90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x2BFDCD0", Offset = "0x2BFC6D0", VA = "0x182BFDCD0")]
		public static DFKOJFHJBPL BLIALODHHOH(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2BFDBA0", Offset = "0x2BFC5A0", VA = "0x182BFDBA0")]
		public static Entity BLIALODHHOH(Entity GOANOLJBHPF)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
[DNOPHNKOHLA(typeof(LLKJKKOJCCH), new string[] { "Editor" })]
public sealed class LLKJKKOJCCH
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public delegate void KBKBPDPAONF(AKLFKNOOHJC OKAADMJPNLO, LDJLMGPDHCO NIPBPKPBPPP, bool HIFDMDCKIDG);

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public delegate void PMPLGANDJID(AKLFKNOOHJC OKAADMJPNLO, bool HIFDMDCKIDG);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public delegate void BMMIGIHILLF(AKLFKNOOHJC OKAADMJPNLO, JBNNELNIDOD OPPPBNFKNOC, in DHBMIEMIIHO MNIAGKNOHEJ, bool HIFDMDCKIDG);

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event KBKBPDPAONF IKOFJLGPFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2C33050", Offset = "0x2C31A50", VA = "0x182C33050")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2C33230", Offset = "0x2C31C30", VA = "0x182C33230")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event PMPLGANDJID CMAJOJJNMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2C33190", Offset = "0x2C31B90", VA = "0x182C33190")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2C32FB0", Offset = "0x2C319B0", VA = "0x182C32FB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event BMMIGIHILLF OLEGNNJHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2C330F0", Offset = "0x2C31AF0", VA = "0x182C330F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2C332D0", Offset = "0x2C31CD0", VA = "0x182C332D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2C33370", Offset = "0x2C31D70", VA = "0x182C33370")]
	[Conditional("UNITY_EDITOR")]
	public void MOEIPNLFFDD(AKLFKNOOHJC OKAADMJPNLO, in LDJLMGPDHCO NIPBPKPBPPP, bool HIFDMDCKIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2C32F90", Offset = "0x2C31990", VA = "0x182C32F90")]
	[Conditional("UNITY_EDITOR")]
	public void BEEFEBBHPPP(AKLFKNOOHJC OKAADMJPNLO, bool HIFDMDCKIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x2C32F60", Offset = "0x2C31960", VA = "0x182C32F60")]
	[Conditional("UNITY_EDITOR")]
	public void AGJLHOEJDDB(AKLFKNOOHJC OKAADMJPNLO, JBNNELNIDOD OPPPBNFKNOC, in DHBMIEMIIHO MNIAGKNOHEJ, bool HIFDMDCKIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public LLKJKKOJCCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DNOPHNKOHLA(typeof(DBDNMBFJLEK), new string[] { "Editor" })]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public sealed class DBDNMBFJLEK
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public delegate void BHMJLGJNAIJ(AKLFKNOOHJC AOCEENCOLMM, LDJLMGPDHCO NIPBPKPBPPP, bool HIFDMDCKIDG);

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate void EJKPCKLPGHK(AKLFKNOOHJC AOCEENCOLMM, bool HIFDMDCKIDG);

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void NPCJIOJBDKL(AKLFKNOOHJC AOCEENCOLMM, JBNNELNIDOD OPPPBNFKNOC, in DHBMIEMIIHO MNIAGKNOHEJ, bool HIFDMDCKIDG, bool DPPBFMGLJGH);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate void LBPILAMFKIM(AKLFKNOOHJC AOCEENCOLMM, JBNNELNIDOD OPPPBNFKNOC, in DHBMIEMIIHO FAAGLIPDKEL, in DHBMIEMIIHO ONFBDMEKEAL);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate void NEJNAJLNPFK(OLDOIHNNAEE AJPNMLHDHNM, ReadOnlyMemory<byte> EONCDECCEBA);

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public static event Action<World> EONCIFPNBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2E00F30", Offset = "0x2DFF930", VA = "0x182E00F30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2E01460", Offset = "0x2DFFE60", VA = "0x182E01460")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public static event Action<World> NFDPLGKMJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2E00A60", Offset = "0x2DFF460", VA = "0x182E00A60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2E01270", Offset = "0x2DFFC70", VA = "0x182E01270")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event BHMJLGJNAIJ IKOFJLGPFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2E00B20", Offset = "0x2DFF520", VA = "0x182E00B20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2E00D50", Offset = "0x2DFF750", VA = "0x182E00D50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event EJKPCKLPGHK CMAJOJJNMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2E00C60", Offset = "0x2DFF660", VA = "0x182E00C60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2E00730", Offset = "0x2DFF130", VA = "0x182E00730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event BHMJLGJNAIJ PDABNHKDLGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2E00FF0", Offset = "0x2DFF9F0", VA = "0x182E00FF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2E01130", Offset = "0x2DFFB30", VA = "0x182E01130")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event EJKPCKLPGHK GPBJCDPFPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2E015F0", Offset = "0x2DFFFF0", VA = "0x182E015F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2E013C0", Offset = "0x2DFFDC0", VA = "0x182E013C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event NPCJIOJBDKL OLEGNNJHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2E00BC0", Offset = "0x2DFF5C0", VA = "0x182E00BC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2E00DF0", Offset = "0x2DFF7F0", VA = "0x182E00DF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event LBPILAMFKIM LBLMKBMNKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2E011D0", Offset = "0x2DFFBD0", VA = "0x182E011D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x2E00850", Offset = "0x2DFF250", VA = "0x182E00850")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<string, object> BPDHDGFJFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2E01550", Offset = "0x2DFFF50", VA = "0x182E01550")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2E009C0", Offset = "0x2DFF3C0", VA = "0x182E009C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event NEJNAJLNPFK GMIELIOHDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2E00E90", Offset = "0x2DFF890", VA = "0x182E00E90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2E01090", Offset = "0x2DFFA90", VA = "0x182E01090")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2E01520", Offset = "0x2DFFF20", VA = "0x182E01520")]
	[Conditional("UNITY_EDITOR")]
	public void PDDFIMBEGOB(AKLFKNOOHJC AOCEENCOLMM, in LDJLMGPDHCO NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2E01330", Offset = "0x2DFFD30", VA = "0x182E01330")]
	[Conditional("UNITY_EDITOR")]
	public void LKFBLPGCJNN(AKLFKNOOHJC AOCEENCOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2E00D00", Offset = "0x2DFF700", VA = "0x182E00D00")]
	[Conditional("UNITY_EDITOR")]
	public void HBIPEFMGAOM(AKLFKNOOHJC AOCEENCOLMM, in LDJLMGPDHCO NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2E007D0", Offset = "0x2DFF1D0", VA = "0x182E007D0")]
	[Conditional("UNITY_EDITOR")]
	public void BPPAEBEMCFC(AKLFKNOOHJC AOCEENCOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2E00820", Offset = "0x2DFF220", VA = "0x182E00820")]
	[Conditional("UNITY_EDITOR")]
	public void DAEMPFOCKBD(AKLFKNOOHJC AOCEENCOLMM, JBNNELNIDOD OPPPBNFKNOC, in DHBMIEMIIHO MNIAGKNOHEJ, bool DPPBFMGLJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2E00D30", Offset = "0x2DFF730", VA = "0x182E00D30")]
	[Conditional("UNITY_EDITOR")]
	public void HEJLHIAABLN(AKLFKNOOHJC AOCEENCOLMM, JBNNELNIDOD OPPPBNFKNOC, in DHBMIEMIIHO FAAGLIPDKEL, in DHBMIEMIIHO ONFBDMEKEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x2E00960", Offset = "0x2DFF360", VA = "0x182E00960")]
	[Conditional("UNITY_EDITOR")]
	public void EGMPHCHPCML(string ANJJEPIBAGI, object EONCDECCEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2E007F0", Offset = "0x2DFF1F0", VA = "0x182E007F0")]
	[Conditional("UNITY_EDITOR")]
	public void CHEPGLKLJLO(OLDOIHNNAEE AJPNMLHDHNM, ReadOnlyMemory<byte> EONCDECCEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2E008F0", Offset = "0x2DFF2F0", VA = "0x182E008F0")]
	[Conditional("UNITY_EDITOR")]
	public void DKPODHHHEOO(World HDJFKDANOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2E01350", Offset = "0x2DFFD50", VA = "0x182E01350")]
	[Conditional("UNITY_EDITOR")]
	public void LMOHAJJAKMO(World HDJFKDANOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public DBDNMBFJLEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DNOPHNKOHLA(typeof(IFAOBCDFODK), new string[] { })]
public class HIIPDFPIJMP : IFAOBCDFODK
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F080", Offset = "0x2C1DA80", VA = "0x182C1F080", Slot = "5")]
	public void MBOIJENNPMC(object EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F170", Offset = "0x2C1DB70", VA = "0x182C1F170", Slot = "6")]
	public void PBPNHHFHAMJ(object EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2C1EF90", Offset = "0x2C1D990", VA = "0x182C1EF90", Slot = "7")]
	public void GGMFAEHOEJI(object EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2C1EE70", Offset = "0x2C1D870", VA = "0x182C1EE70", Slot = "4")]
	public IDisposable EEDHCHPAAJH(object EJEIJOMMNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HIIPDFPIJMP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Serialization)]
	[DNOPHNKOHLA(typeof(BulkInstantiateSceneObjectService), new string[] { })]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	internal class BulkInstantiateSceneObjectService : MMKNGEFLOAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const string IEAGECODFGH = "om_oni";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[JIFPDEDMPGC]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN ALIKEONHNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[JIFPDEDMPGC]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[JIFPDEDMPGC]
		private JOHEJCALJIO CAJCDELKPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private EntityQuery NCNIGNCDEEF;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private EntityManager FLHDGCEBOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x2DF2B40", Offset = "0x2DF1540", VA = "0x182DF2B40")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF29C0", Offset = "0x2DF13C0", VA = "0x182DF29C0", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2260", Offset = "0x2DF0C60", VA = "0x182DF2260", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3960", Offset = "0x2DF2360", VA = "0x182DF3960")]
		public bool PBEDEGPKDBA(IEnumerable<DMEOMGPBNBN> CJONHNHPLPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3A80", Offset = "0x2DF2480", VA = "0x182DF3A80")]
		public static bool POPCKOGMHNE(DMEOMGPBNBN NONPDGFJDAK, out AKLFKNOOHJC AOCEENCOLMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF1CB0", Offset = "0x2DF06B0", VA = "0x182DF1CB0")]
		private void BKFEDKGJAOA(Dictionary<AKLFKNOOHJC, DMEOMGPBNBN> INLJGFGAJKF, IEnumerable<DMEOMGPBNBN> CJONHNHPLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2030", Offset = "0x2DF0A30", VA = "0x182DF2030")]
		private void CEEEHAEHOFP(Dictionary<AKLFKNOOHJC, DMEOMGPBNBN> INLJGFGAJKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2DF24E0", Offset = "0x2DF0EE0", VA = "0x182DF24E0")]
		private void FNDGAEBFHDA(Dictionary<AKLFKNOOHJC, DMEOMGPBNBN> INLJGFGAJKF, AKLFKNOOHJC AOCEENCOLMM, string ANJJEPIBAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3600", Offset = "0x2DF2000", VA = "0x182DF3600")]
		private void OALAJOBIIHH(Dictionary<AKLFKNOOHJC, DMEOMGPBNBN> INLJGFGAJKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2B90", Offset = "0x2DF1590", VA = "0x182DF2B90")]
		private void LGLFAMHIOJI(Dictionary<AKLFKNOOHJC, DMEOMGPBNBN> INLJGFGAJKF, List<DMEOMGPBNBN> FJALPCNLGIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3430", Offset = "0x2DF1E30", VA = "0x182DF3430")]
		private NativeList<AKLFKNOOHJC> MFEAMEJNKDF(Dictionary<AKLFKNOOHJC, DMEOMGPBNBN> INLJGFGAJKF)
		{
			return default(NativeList<AKLFKNOOHJC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2310", Offset = "0x2DF0D10", VA = "0x182DF2310")]
		private NativeArray<Entity> FIFJPCGBNHD(NativeList<AKLFKNOOHJC> DNBFIALJBOF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x2DF2270", Offset = "0x2DF0C70", VA = "0x182DF2270")]
		private static void EALHHDKCKGL(Dictionary<AKLFKNOOHJC, DMEOMGPBNBN> INLJGFGAJKF, AKLFKNOOHJC AOCEENCOLMM, DMEOMGPBNBN NONPDGFJDAK, string ANJJEPIBAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public BulkInstantiateSceneObjectService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[AINPJLGDEKF(EIJAKMAIFNG.Application)]
	[DNOPHNKOHLA(typeof(DebugWorldsService), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.Serialization)]
	internal class DebugWorldsService : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal static bool FCANJHPHPBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x2E04520", Offset = "0x2E02F20", VA = "0x182E04520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x2E044E0", Offset = "0x2E02EE0", VA = "0x182E044E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static bool FGGMDLKGNCO
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x2E044A0", Offset = "0x2E02EA0", VA = "0x182E044A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x2E04560", Offset = "0x2E02F60", VA = "0x182E04560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		public void GLEAFEPPJMF(string ANJJEPIBAGI, EntityManager BJMEFCCEPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		public static void NMFIICNHENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public DebugWorldsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DNOPHNKOHLA(typeof(OHLJMGEOGPF), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
internal class OHLJMGEOGPF
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool FCANJHPHPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C5250", Offset = "0x6C3C50", VA = "0x1806C5250")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6C5270", Offset = "0x6C3C70", VA = "0x1806C5270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool GAMBHFOHCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7E1E70", Offset = "0x7E0870", VA = "0x1807E1E70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7E1E80", Offset = "0x7E0880", VA = "0x1807E1E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public OHLJMGEOGPF()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[DNOPHNKOHLA(typeof(FCADPKIAEAJ), new string[] { })]
	[AKBJAGIAKDO(typeof(SerializationService))]
	[LOEOGANCBGC(EDPDLGMLNHJ.Serialization)]
	internal class SerializationService : FCADPKIAEAJ, IDisposable, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly KGOHPJFJCLE PCAOIFLAMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[JIFPDEDMPGC]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[JIFPDEDMPGC]
		private PMIFMKBOKIE KJBMIMOPDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[JIFPDEDMPGC]
		private OHLJMGEOGPF PGFCMPHCIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private CNKLABGKIMB CDHOLMHKCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private JAHMKKMLHEN EABIENOHKIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private SerializationRemapScope DBHMONFNCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool? DJGHPNCPNHP;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool HPEDMOLJLGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x2BFEEC0", Offset = "0x2BFD8C0", VA = "0x182BFEEC0", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x2BFE430", Offset = "0x2BFCE30", VA = "0x182BFE430", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool PHPKKMNEHBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x764CE0", Offset = "0x7636E0", VA = "0x180764CE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x765490", Offset = "0x763E90", VA = "0x180765490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public JAHMKKMLHEN DGMKFGECENM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2BFEB80", Offset = "0x2BFD580", VA = "0x182BFEB80", Slot = "16")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x2BFE7A0", Offset = "0x2BFD1A0", VA = "0x182BFE7A0", Slot = "15")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x2BFE440", Offset = "0x2BFCE40", VA = "0x182BFE440")]
		public static bool CLOEECIKNOA(ByteString DBKEJGOGOOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7031C0", Offset = "0x701BC0", VA = "0x1807031C0")]
		public void MGHBDKMBDOG(CNKLABGKIMB BJOCKKDEENH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x2BFEDF0", Offset = "0x2BFD7F0", VA = "0x182BFEDF0", Slot = "5")]
		public void IHGOLKFGALJ(bool JECBMIHPMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x2BFF690", Offset = "0x2BFE090", VA = "0x182BFF690", Slot = "6")]
		public Task JNILELMEKNP(bool JECBMIHPMOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2BFF280", Offset = "0x2BFDC80", VA = "0x182BFF280", Slot = "7")]
		public ByteString JHPOCMCIPNJ(out IDisposable DBHMONFNCDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2BFF0A0", Offset = "0x2BFDAA0", VA = "0x182BFF0A0", Slot = "19")]
		public ByteString JHPOCMCIPNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x2BFE2C0", Offset = "0x2BFCCC0", VA = "0x182BFE2C0", Slot = "9")]
		public bool AJGJBLGJHIK(ByteString AKOIJLIIFEA, IIICADJMPPL HLCFNPLAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x2BFE7B0", Offset = "0x2BFD1B0", VA = "0x182BFE7B0")]
		private bool EBLNGKADOIA(ByteString AKOIJLIIFEA, IIICADJMPPL HLCFNPLAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2BFEC20", Offset = "0x2BFD620", VA = "0x182BFEC20", Slot = "8")]
		public void HCIGFAOHNIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2BFFAE0", Offset = "0x2BFE4E0", VA = "0x182BFFAE0", Slot = "10")]
		public bool MDDCFGJOPOD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x2BFFF50", Offset = "0x2BFE950", VA = "0x182BFFF50", Slot = "11")]
		public bool PBEDEGPKDBA(IEnumerable<DMEOMGPBNBN> EMJPLLBFAOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x2BFFA00", Offset = "0x2BFE400", VA = "0x182BFFA00")]
		public bool LBHLGEEPECA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2BFE570", Offset = "0x2BFCF70", VA = "0x182BFE570", Slot = "12")]
		public bool DGBFGGFLFPL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x2BFF720", Offset = "0x2BFE120", VA = "0x182BFF720")]
		public void KKHMOOPMMCK(JAHMKKMLHEN.JGCHBGMKHGA.MIHPJMHOKBB JAGMMDGFNGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x2BFF400", Offset = "0x2BFDE00", VA = "0x182BFF400")]
		private bool JMDGFKPBDEN(ByteString AKOIJLIIFEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2BFF9B0", Offset = "0x2BFE3B0", VA = "0x182BFF9B0")]
		private void KLBMCNKDCMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2BFE260", Offset = "0x2BFCC60", VA = "0x182BFE260")]
		private ByteString ACBKNCFEIMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BFE320", Offset = "0x2BFCD20", VA = "0x182BFE320")]
		private ByteString BKNBFDPFFJH(ByteString DBKEJGOGOOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x2BFF360", Offset = "0x2BFDD60", VA = "0x182BFF360")]
		private JAHMKKMLHEN.JGCHBGMKHGA.MIHPJMHOKBB JLJLHDGMJLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x2BFFF20", Offset = "0x2BFE920", VA = "0x182BFFF20")]
		private void OCHMLFNOAKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x2BFEED0", Offset = "0x2BFD8D0", VA = "0x182BFEED0", Slot = "13")]
		public bool JHKPODDCHJH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x2BFEAD0", Offset = "0x2BFD4D0", VA = "0x182BFEAD0", Slot = "14")]
		public void GENFMKINDFO(bool KODHDLHLAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x2BFFD50", Offset = "0x2BFE750", VA = "0x182BFFD50")]
		private void NMFIICNHENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DNOPHNKOHLA(typeof(GCELLPHAFPH), new string[] { })]
[AKBJAGIAKDO(typeof(PMIFMKBOKIE))]
internal class PMIFMKBOKIE : GCELLPHAFPH
{
	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action BCGCLIKNJON
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC080", Offset = "0x2AFAA80", VA = "0x182AFC080", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC120", Offset = "0x2AFAB20", VA = "0x182AFC120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<AENEDCLILGP> FBEEPOEHELE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC350", Offset = "0x2AFAD50", VA = "0x182AFC350", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC3F0", Offset = "0x2AFADF0", VA = "0x182AFC3F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action MNMNCNCNHNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC2B0", Offset = "0x2AFACB0", VA = "0x182AFC2B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC670", Offset = "0x2AFB070", VA = "0x182AFC670", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action NHABFBDGMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC5D0", Offset = "0x2AFAFD0", VA = "0x182AFC5D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC1C0", Offset = "0x2AFABC0", VA = "0x182AFC1C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<AENEDCLILGP> BKDAAGBFPEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC530", Offset = "0x2AFAF30", VA = "0x182AFC530", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC490", Offset = "0x2AFAE90", VA = "0x182AFC490", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x101B410", Offset = "0x1019E10", VA = "0x18101B410")]
	public void HCIGFAOHNIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x101B430", Offset = "0x1019E30", VA = "0x18101B430")]
	public void HAFPKCEKHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x11857A0", Offset = "0x11841A0", VA = "0x1811857A0")]
	public void MEKPDJAOHEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x2AFC260", Offset = "0x2AFAC60", VA = "0x182AFC260")]
	public void BPHELDMJEFG(AENEDCLILGP LEIENNNIAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AFC710", Offset = "0x2AFB110", VA = "0x182AFC710")]
	public void OPAAIAANIOM(AENEDCLILGP LEIENNNIAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PMIFMKBOKIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DNOPHNKOHLA(typeof(LAIKDFLJMKI), new string[] { })]
public class HJPGOFBFDPL : LAIKDFLJMKI, EBFNJADEFGO, IPCGJDFHGJG, MMKNGEFLOAO, PKBAIAJJFPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private EntityHierarchyParents FEENBFHHDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private LBIGKNDELFN EIGABIBFMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ObjectEmbodimentService MIDDDIBGPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public global::NENALMGBADL<DFKOJFHJBPL> NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C8580", Offset = "0x6C6F80", VA = "0x1806C8580", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C85A0", Offset = "0x6C6FA0", VA = "0x1806C85A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager FLHDGCEBOEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x2C1FBF0", Offset = "0x2C1E5F0", VA = "0x182C1FBF0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x102B5C0", Offset = "0x1029FC0", VA = "0x18102B5C0", Slot = "14")]
	public void BEJHKBIOAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C1FB20", Offset = "0x2C1E520", VA = "0x182C1FB20", Slot = "15")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C1FA30", Offset = "0x2C1E430", VA = "0x182C1FA30", Slot = "16")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x102B4F0", Offset = "0x1029EF0", VA = "0x18102B4F0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFEC0", Offset = "0x2AEE8C0", VA = "0x182AEFEC0")]
	private DFKOJFHJBPL KEPFDGAGDJI(Entity GOANOLJBHPF)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F870", Offset = "0x2C1E270", VA = "0x182C1F870", Slot = "4")]
	public DFKOJFHJBPL EDPENGKDDJF(DFKOJFHJBPL PMMCMCPNCLD)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2C200A0", Offset = "0x2C1EAA0", VA = "0x182C200A0", Slot = "19")]
	public void LIDLLJHIPIP(ref List<DFKOJFHJBPL> BHEOHMIBBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2C20410", Offset = "0x2C1EE10", VA = "0x182C20410", Slot = "20")]
	public IEnumerable<DFKOJFHJBPL> NFFFFNFFGFM(DFKOJFHJBPL PMMCMCPNCLD, bool HNONKJJDNKE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2C1FE10", Offset = "0x2C1E810", VA = "0x182C1FE10", Slot = "21")]
	public DFKOJFHJBPL KADGDGJNBPA(DFKOJFHJBPL PMMCMCPNCLD, int GFDMFLGCBKB)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2C207B0", Offset = "0x2C1F1B0", VA = "0x182C207B0", Slot = "22")]
	public int PLJCBNLMLMP(DFKOJFHJBPL PMMCMCPNCLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2C20610", Offset = "0x2C1F010", VA = "0x182C20610", Slot = "8")]
	public int NLFFKMDNFBA(DFKOJFHJBPL PMMCMCPNCLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F5C0", Offset = "0x2C1DFC0", VA = "0x182C1F5C0", Slot = "9")]
	public EIIMNNHCANF CFOGOOEEEBP(DFKOJFHJBPL PMMCMCPNCLD)
	{
		return default(EIIMNNHCANF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C1FC40", Offset = "0x2C1E640", VA = "0x182C1FC40", Slot = "23")]
	public bool ILNDCEFACCD(DFKOJFHJBPL PMMCMCPNCLD, out EIIMNNHCANF FKCNAPHBJHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F960", Offset = "0x2C1E360", VA = "0x182C1F960", Slot = "24")]
	public IEnumerable<DFKOJFHJBPL> EPEPDFLBNKD(DFKOJFHJBPL PMMCMCPNCLD, bool HNONKJJDNKE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F450", Offset = "0x2C1DE50", VA = "0x182C1F450", Slot = "12")]
	public DFKOJFHJBPL BPIDCKMFGNC(DFKOJFHJBPL KFMKMKEGGGJ, DFKOJFHJBPL IADBGEPICDI)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C202D0", Offset = "0x2C1ECD0", VA = "0x182C202D0", Slot = "13")]
	public bool LONLDNKLGBI(DFKOJFHJBPL KFMKMKEGGGJ, DFKOJFHJBPL IADBGEPICDI, out DFKOJFHJBPL ENIDPPCMOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F520", Offset = "0x2C1DF20", VA = "0x182C1F520", Slot = "5")]
	public DFKOJFHJBPL CBCDGOOOFFP(DFKOJFHJBPL PMMCMCPNCLD)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C1FFE0", Offset = "0x2C1E9E0", VA = "0x182C1FFE0", Slot = "11")]
	public bool KOAJBNHNOIK(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL OBNNKPFGMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F310", Offset = "0x2C1DD10", VA = "0x182C1F310", Slot = "25")]
	public bool AEAMAMIPHJB(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL DDLMBHAEKGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F6B0", Offset = "0x2C1E0B0", VA = "0x182C1F6B0", Slot = "10")]
	public bool CNEEDNJDFHP(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL KFMKMKEGGGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F7C0", Offset = "0x2C1E1C0", VA = "0x182C1F7C0", Slot = "6")]
	public bool DGJAMCMEJGD(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL ELGBIOMPEHN, bool FMMHJBAPDJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C203A0", Offset = "0x2C1EDA0", VA = "0x182C203A0", Slot = "7")]
	public bool MIGAOKLMMPE(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL ELGBIOMPEHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HJPGOFBFDPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
[DNOPHNKOHLA(typeof(OCJBMLIKJMH), new string[] { })]
internal class OCJBMLIKJMH : MMKNGEFLOAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[JIFPDEDMPGC]
	private BPDJHFAPEAG PDPOLFACNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<int, KLBBFCMIKPN> NGKJGNGAIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA190", Offset = "0x2AE8B90", VA = "0x182AEA190", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA040", Offset = "0x2AE8A40", VA = "0x182AEA040", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9E30", Offset = "0x2AE8830", VA = "0x182AE9E30")]
	public KLBBFCMIKPN DKCMJKKOIIN(GFANKPDBBJN IJEJFFCLBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9CE0", Offset = "0x2AE86E0", VA = "0x182AE9CE0")]
	public KLBBFCMIKPN DKCMJKKOIIN(JBNNELNIDOD ILFNNAAOJHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA1E0", Offset = "0x2AE8BE0", VA = "0x182AEA1E0")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA300", Offset = "0x2AE8D00", VA = "0x182AEA300")]
	public OCJBMLIKJMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class KLBBFCMIKPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<BDJJEEAIANM> KNJDPKIKCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private NativeList<LIOPPALECME> PDJKBGIMOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeList<MIIGEONEKIB> IEPHJABBOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<LIOPPALECME> LCPIPHIFEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<BDJJEEAIANM> OIMDBBCPJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xCC7400", Offset = "0xCC5E00", VA = "0x180CC7400")]
		get
		{
			return default(NativeList<BDJJEEAIANM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<LIOPPALECME> FEANKDAPHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xBF2C40", Offset = "0xBF1640", VA = "0x180BF2C40")]
		get
		{
			return default(NativeList<LIOPPALECME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<MIIGEONEKIB> GFABPEFMDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xEA70B0", Offset = "0xEA5AB0", VA = "0x180EA70B0")]
		get
		{
			return default(NativeList<MIIGEONEKIB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<LIOPPALECME> LCFPBNHFHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x133F010", Offset = "0x133DA10", VA = "0x18133F010")]
		get
		{
			return default(NativeList<LIOPPALECME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle HLEHAGDAEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x12E96C0", Offset = "0x12E80C0", VA = "0x1812E96C0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x12E9AB0", Offset = "0x12E84B0", VA = "0x1812E9AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool JDCINNHHEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1068E10", Offset = "0x1067810", VA = "0x181068E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool JCJLAAEODFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2C2D350", Offset = "0x2C2BD50", VA = "0x182C2D350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D490", Offset = "0x2C2BE90", VA = "0x182C2D490")]
	public KLBBFCMIKPN(Allocator GGPAKDMJHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D400", Offset = "0x2C2BE00", VA = "0x182C2D400")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D220", Offset = "0x2C2BC20", VA = "0x182C2D220")]
	public void JGBMECMGNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2C2CF30", Offset = "0x2C2B930", VA = "0x182C2CF30")]
	public void CPLOAHMOJFD(Entity GOANOLJBHPF, Entity PMJEABCAKDM, Entity DILGNCFGGHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[DNOPHNKOHLA(typeof(GOIDHEAPOIJ), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public class GOIDHEAPOIJ : MMKNGEFLOAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[JIFPDEDMPGC]
	private SceneService DLIDPEKLJKC;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2C1BE40", Offset = "0x2C1A840", VA = "0x182C1BE40", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x2C1BE20", Offset = "0x2C1A820", VA = "0x182C1BE20", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public GOIDHEAPOIJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[DNOPHNKOHLA(typeof(PhotonInstanceCleanupService), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.Lifecycle)]
	[AINPJLGDEKF(EIJAKMAIFNG.PhotonRoom)]
	public class PhotonInstanceCleanupService : MMKNGEFLOAO, IPCGJDFHGJG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private PEIGBAPLOKK MBIMIAEOCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private CGCFBBFKDEL HHKHFGCMHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private NativeList<int> GGLJPPMMMHF;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC980", Offset = "0x2AFB380", VA = "0x182AFC980", Slot = "5")]
		public void BEJHKBIOAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCB70", Offset = "0x2AFB570", VA = "0x182AFCB70", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCAD0", Offset = "0x2AFB4D0", VA = "0x182AFCAD0")]
		public void FDINHLIKDIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC9E0", Offset = "0x2AFB3E0", VA = "0x182AFC9E0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCC20", Offset = "0x2AFB620", VA = "0x182AFCC20")]
		public void OEIGPEDHODN(global::BJBEMKAEBCB<int> AHIEKOKFGIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCBE0", Offset = "0x2AFB5E0", VA = "0x182AFCBE0")]
		public void IMMNGGAGDGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public PhotonInstanceCleanupService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal abstract class FKPEOCNIFDE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private uint JLNFCCGPBCE;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public abstract uint PGEFHGFJHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x999240", Offset = "0x997C40", VA = "0x180999240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x2C183F0", Offset = "0x2C16DF0", VA = "0x182C183F0")]
	public AKLFKNOOHJC HKPPPDDFJJO()
	{
		return default(AKLFKNOOHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x2C18440", Offset = "0x2C16E40", VA = "0x182C18440")]
	public void NBCJLBHDHKD(AKLFKNOOHJC AOCEENCOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x17CD570", Offset = "0x17CBF70", VA = "0x1817CD570", Slot = "6")]
	public virtual void KNCDGFAKBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	protected FKPEOCNIFDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
[DNOPHNKOHLA(typeof(DPFLLDDDCBH), new string[] { })]
internal sealed class DPFLLDDDCBH : FKPEOCNIFDE, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[JIFPDEDMPGC]
	private LFIFNADKAEF EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private uint OACKGFKLPAI;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override uint PGEFHGFJHJB
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6C1010", Offset = "0x6BFA10", VA = "0x1806C1010", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x2E03C40", Offset = "0x2E02640", VA = "0x182E03C40", Slot = "7")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x2E03D40", Offset = "0x2E02740", VA = "0x182E03D40")]
	private void MBCNMFFOPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x2E03CE0", Offset = "0x2E026E0", VA = "0x182E03CE0", Slot = "6")]
	public override void KNCDGFAKBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
	public DPFLLDDDCBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DNOPHNKOHLA(typeof(MDCFPDNJKAF), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
internal sealed class MDCFPDNJKAF : FKPEOCNIFDE
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override uint PGEFHGFJHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
	public MDCFPDNJKAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
[DNOPHNKOHLA(typeof(KHCPECBGMIK), new string[] { })]
internal sealed class KHCPECBGMIK : EBFNJADEFGO, IPCGJDFHGJG, MMKNGEFLOAO, PKBAIAJJFPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[JIFPDEDMPGC]
	private DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private EntityQuery DLMJLCCDPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery LJCOMIOJMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery AKIABNDNPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery BNMJEAAFGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery EMFLFAOKNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery HEAPEFDIAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private EntityManager FLHDGCEBOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C5B0", Offset = "0x2C2AFB0", VA = "0x182C2C5B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public EntityQuery ECPBLBCAFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6E2040", Offset = "0x6E0A40", VA = "0x1806E2040")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery MOABDOJDHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6E2030", Offset = "0x6E0A30", VA = "0x1806E2030")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EntityQuery HHMHKGHFILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x124B0E0", Offset = "0x1249AE0", VA = "0x18124B0E0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EntityQuery JAFGIAIHCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x12E96C0", Offset = "0x12E80C0", VA = "0x1812E96C0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public EntityQuery FPMNHJAJBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x12E85E0", Offset = "0x12E6FE0", VA = "0x1812E85E0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EntityQuery EOGIHILDPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C000", Offset = "0x2C2AA00", VA = "0x182C2C000")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int JJAJLFIFODB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C520", Offset = "0x2C2AF20", VA = "0x182C2C520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int OGEHKGEKLID
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C780", Offset = "0x2C2B180", VA = "0x182C2C780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int LIGFPAMHCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C8B0", Offset = "0x2C2B2B0", VA = "0x182C2C8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int FDIGLDNLLAC
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x2C2BF80", Offset = "0x2C2A980", VA = "0x182C2BF80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int EHOCKNADGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C600", Offset = "0x2C2B000", VA = "0x182C2C600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int MJOAKBFMAHK
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x2C2C540", Offset = "0x2C2AF40", VA = "0x182C2C540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "4")]
	public void BEJHKBIOAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C560", Offset = "0x2C2AF60", VA = "0x182C2C560", Slot = "5")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C080", Offset = "0x2C2AA80", VA = "0x182C2C080", Slot = "6")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C7A0", Offset = "0x2C2B1A0", VA = "0x182C2C7A0")]
	private EntityQueryDesc IOMMIHKJJPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x2C2BFA0", Offset = "0x2C2A9A0", VA = "0x182C2BFA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C6D0", Offset = "0x2C2B0D0", VA = "0x182C2C6D0")]
	public JBPFPNIOEPH GPCPPGBINOB(DFKOJFHJBPL EFHLICFAAGO)
	{
		return default(JBPFPNIOEPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C620", Offset = "0x2C2B020", VA = "0x182C2C620")]
	public JBPFPNIOEPH GPCPPGBINOB(Entity GOANOLJBHPF)
	{
		return default(JBPFPNIOEPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C800", Offset = "0x2C2B200", VA = "0x182C2C800")]
	public AOIKBHJMDBO MGDPAKACCKF(Entity GOANOLJBHPF)
	{
		return default(AOIKBHJMDBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C8D0", Offset = "0x2C2B2D0", VA = "0x182C2C8D0")]
	public KHCPECBGMIK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[LOEOGANCBGC(EDPDLGMLNHJ.All)]
	[DNOPHNKOHLA(typeof(HGFGJIKNIPL), new string[] { })]
	public class ObjectService : MMKNGEFLOAO, HGFGJIKNIPL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly KGOHPJFJCLE FACEODCFNKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[JIFPDEDMPGC]
		private DPKHLNGAONH DBKMNLNGAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[JIFPDEDMPGC]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[JIFPDEDMPGC]
		private ObjectLifecycleService JFLLPKLIMED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[JIFPDEDMPGC]
		private ObjectEmbodimentService MIDDDIBGPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[JIFPDEDMPGC]
		private ObjectInstantiationService HPAFIPNLAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[JIFPDEDMPGC]
		private KHCPECBGMIK EIGABIBFMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ObjectNetworkToLocalMapService KGCOHGMEJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public DPKHLNGAONH MBHDHAMHFAG
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int JJAJLFIFODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2AF80F0", Offset = "0x2AF6AF0", VA = "0x182AF80F0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int OGEHKGEKLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8800", Offset = "0x2AF7200", VA = "0x182AF8800", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int LIGFPAMHCDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2AF9740", Offset = "0x2AF8140", VA = "0x182AF9740", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int FDIGLDNLLAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2AF7860", Offset = "0x2AF6260", VA = "0x182AF7860", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int EHOCKNADGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8570", Offset = "0x2AF6F70", VA = "0x182AF8570", Slot = "39")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int MJOAKBFMAHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2AF8130", Offset = "0x2AF6B30", VA = "0x182AF8130", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<DFKOJFHJBPL, AOIKBHJMDBO> NIEIHPJBMLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2AF96A0", Offset = "0x2AF80A0", VA = "0x182AF96A0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2AF7AF0", Offset = "0x2AF64F0", VA = "0x182AF7AF0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<DFKOJFHJBPL> OJOJFJMPPIB
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2AF88B0", Offset = "0x2AF72B0", VA = "0x182AF88B0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2AF9370", Offset = "0x2AF7D70", VA = "0x182AF9370", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8200", Offset = "0x2AF6C00", VA = "0x182AF8200", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7B90", Offset = "0x2AF6590", VA = "0x182AF7B90", Slot = "34")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8C50", Offset = "0x2AF7650", VA = "0x182AF8C50")]
		private void MCFBNNEAFPF(Entity GOANOLJBHPF, AOIKBHJMDBO GDAJCNKPBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x2AF86B0", Offset = "0x2AF70B0", VA = "0x182AF86B0")]
		private void HHILFENKAJF(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8890", Offset = "0x2AF7290", VA = "0x182AF8890")]
		internal DFKOJFHJBPL KEPFDGAGDJI(Entity GOANOLJBHPF)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7EB0", Offset = "0x2AF68B0", VA = "0x182AF7EB0", Slot = "41")]
		public EIIMNNHCANF FEGKCNKJGJD()
		{
			return default(EIIMNNHCANF);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8150", Offset = "0x2AF6B50", VA = "0x182AF8150", Slot = "42")]
		public EIIMNNHCANF GGECOHJIELF()
		{
			return default(EIIMNNHCANF);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8470", Offset = "0x2AF6E70", VA = "0x182AF8470", Slot = "43")]
		public EIIMNNHCANF GKENPCAIPDN()
		{
			return default(EIIMNNHCANF);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF85E0", Offset = "0x2AF6FE0", VA = "0x182AF85E0", Slot = "10")]
		public JBPFPNIOEPH GPCPPGBINOB(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(JBPFPNIOEPH);
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8CF0", Offset = "0x2AF76F0", VA = "0x182AF8CF0", Slot = "11")]
		public AOIKBHJMDBO MGDPAKACCKF(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(AOIKBHJMDBO);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9220", Offset = "0x2AF7C20", VA = "0x182AF9220")]
		private EIIMNNHCANF NLDGPBDKNBB(EntityQuery CAMLCFELNDE)
		{
			return default(EIIMNNHCANF);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7E20", Offset = "0x2AF6820", VA = "0x182AF7E20", Slot = "33")]
		public bool FDOEJMJEMDK(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x2AF91D0", Offset = "0x2AF7BD0", VA = "0x182AF91D0", Slot = "29")]
		public void NJKFKCNNMGK(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8090", Offset = "0x2AF6A90", VA = "0x182AF8090", Slot = "30")]
		public void FFMAALCHNFN(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x2AF92D0", Offset = "0x2AF7CD0", VA = "0x182AF92D0", Slot = "31")]
		public void ODELNGMKLPF(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8AE0", Offset = "0x2AF74E0", VA = "0x182AF8AE0", Slot = "22")]
		public POPHLPHEEBM LNCOMHGPOAE(AOIKBHJMDBO GDAJCNKPBDC, bool PCDCBPLMECK)
		{
			return default(POPHLPHEEBM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8A30", Offset = "0x2AF7430", VA = "0x182AF8A30", Slot = "23")]
		public POPHLPHEEBM LNCOMHGPOAE(AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(POPHLPHEEBM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7D10", Offset = "0x2AF6710", VA = "0x182AF7D10", Slot = "24")]
		public POPHLPHEEBM EMPCNAPPLAH(AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(POPHLPHEEBM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8EE0", Offset = "0x2AF78E0", VA = "0x182AF8EE0", Slot = "25")]
		public POPHLPHEEBM NELDJHBEBDP(AKLFKNOOHJC AOCEENCOLMM, AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(POPHLPHEEBM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8740", Offset = "0x2AF7140", VA = "0x182AF8740", Slot = "44")]
		public POPHLPHEEBM HKNJNKKEOGL(int OAMBKNHBGDL, AOIKBHJMDBO GDAJCNKPBDC, GameObject KEHOIMKGHCH)
		{
			return default(POPHLPHEEBM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7880", Offset = "0x2AF6280", VA = "0x182AF7880", Slot = "26")]
		public KAEJCOGFAOC CBDGNLKCMJD()
		{
			return default(KAEJCOGFAOC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x2AF90B0", Offset = "0x2AF7AB0", VA = "0x182AF90B0", Slot = "45")]
		public BOLPDANFPGC NILOJCEIBHN(HFJJNJCDHGL MAHAMGBPDNB)
		{
			return default(BOLPDANFPGC);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8950", Offset = "0x2AF7350", VA = "0x182AF8950", Slot = "27")]
		public IHPFPPKPCHF LIJHNKECALI()
		{
			return default(IHPFPPKPCHF);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7F50", Offset = "0x2AF6950", VA = "0x182AF7F50", Slot = "28")]
		public EHLGLNMBADB FEKOEOBMBGE(MGHIFAKDBDN MAHAMGBPDNB)
		{
			return default(EHLGLNMBADB);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9410", Offset = "0x2AF7E10", VA = "0x182AF9410", Slot = "12")]
		public void OGMDKKEHOIN(AKLFKNOOHJC AOCEENCOLMM, HBIBAGENGHJ GKKAOEHIFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9580", Offset = "0x2AF7F80", VA = "0x182AF9580", Slot = "13")]
		public POPHLPHEEBM PIKENIAFHJF(DFKOJFHJBPL PMMCMCPNCLD, [Optional] object DEGCIHEAIBD)
		{
			return default(POPHLPHEEBM);
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8610", Offset = "0x2AF7010", VA = "0x182AF8610", Slot = "14")]
		public bool HAAHLPEEGIO(DFKOJFHJBPL PMMCMCPNCLD, out HBIBAGENGHJ OAFMFLFMLNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9430", Offset = "0x2AF7E30", VA = "0x182AF9430", Slot = "46")]
		public Transform OJLEDFFAAIN(DFKOJFHJBPL PMMCMCPNCLD, [Optional] object DEGCIHEAIBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8590", Offset = "0x2AF6F90", VA = "0x182AF8590", Slot = "16")]
		public bool GOEJCHMLHHD(DFKOJFHJBPL PMMCMCPNCLD, out Transform CLHKPCIOCGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x2AF87B0", Offset = "0x2AF71B0", VA = "0x182AF87B0", Slot = "17")]
		public bool HNGDLAAAHJE(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9520", Offset = "0x2AF7F20", VA = "0x182AF9520")]
		public bool PICEALNHFBA(HBIBAGENGHJ MNIAGKNOHEJ, [Optional] object DEGCIHEAIBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9550", Offset = "0x2AF7F50", VA = "0x182AF9550", Slot = "47")]
		public bool PICEALNHFBA(DFKOJFHJBPL PMMCMCPNCLD, [Optional] object DEGCIHEAIBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8110", Offset = "0x2AF6B10", VA = "0x182AF8110", Slot = "48")]
		public void GCAMBINNBNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8D30", Offset = "0x2AF7730", VA = "0x182AF8D30", Slot = "15")]
		public void MNJLLHMJPCE(HBIBAGENGHJ LAFPICAOEAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8BA0", Offset = "0x2AF75A0", VA = "0x182AF8BA0", Slot = "49")]
		public void LPLCEOMDBFD(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7940", Offset = "0x2AF6340", VA = "0x182AF7940", Slot = "18")]
		public bool CDAPIFCKPGM(Entity GOANOLJBHPF, object DEGCIHEAIBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7DA0", Offset = "0x2AF67A0", VA = "0x182AF7DA0", Slot = "19")]
		public bool ENAJODIBMIM(Entity GOANOLJBHPF, object DEGCIHEAIBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8BE0", Offset = "0x2AF75E0", VA = "0x182AF8BE0", Slot = "50")]
		public bool MBONPEPBIOM(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8820", Offset = "0x2AF7220", VA = "0x182AF8820", Slot = "51")]
		public bool JPOHKNFHLNH(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8510", Offset = "0x2AF6F10", VA = "0x182AF8510", Slot = "32")]
		public NativeArray<(DFKOJFHJBPL, DFKOJFHJBPL)> GKODLOMCAKJ(NativeArray<DFKOJFHJBPL> NNPEDNPMEIC, Allocator GGPAKDMJHLJ)
		{
			return default(NativeArray<(DFKOJFHJBPL, DFKOJFHJBPL)>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9480", Offset = "0x2AF7E80", VA = "0x182AF9480", Slot = "21")]
		public AKLFKNOOHJC OOMNOMGKKMO(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(AKLFKNOOHJC);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7A00", Offset = "0x2AF6400", VA = "0x182AF7A00", Slot = "20")]
		public DFKOJFHJBPL DHDNGOHCFIF(AKLFKNOOHJC AOCEENCOLMM)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF79C0", Offset = "0x2AF63C0", VA = "0x182AF79C0")]
		private void CDMLOGHAJMO(AOIKBHJMDBO GDAJCNKPBDC, DFKOJFHJBPL PMMCMCPNCLD, AKLFKNOOHJC AOCEENCOLMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ObjectService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
[DNOPHNKOHLA(typeof(EEKEFMOLEBM), new string[] { })]
internal sealed class EEKEFMOLEBM : MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private ObjectInstantiationService HPAFIPNLAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[JIFPDEDMPGC]
	private KHCPECBGMIK EIGABIBFMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[JIFPDEDMPGC]
	private DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2E060A0", Offset = "0x2E04AA0", VA = "0x182E060A0", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2E06130", Offset = "0x2E04B30", VA = "0x182E06130")]
	public NativeArray<(DFKOJFHJBPL, DFKOJFHJBPL)> GKODLOMCAKJ(NativeArray<DFKOJFHJBPL> NNPEDNPMEIC, Allocator GGPAKDMJHLJ)
	{
		return default(NativeArray<(DFKOJFHJBPL, DFKOJFHJBPL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2E063C0", Offset = "0x2E04DC0", VA = "0x182E063C0")]
	private void PGFKMKNNHMK(NativeMultiHashMap<int, (DFKOJFHJBPL src, DFKOJFHJBPL dst)> FMMGDELNIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x2E05C10", Offset = "0x2E04610", VA = "0x182E05C10")]
	private void FCILABHIHNO(NativeMultiHashMap<int, (DFKOJFHJBPL src, DFKOJFHJBPL dst)> FMMGDELNIPM, int GDAJCNKPBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2E06230", Offset = "0x2E04C30", VA = "0x182E06230")]
	private void MDKOKHJPBCB(NativeMultiHashMap<int, (DFKOJFHJBPL src, DFKOJFHJBPL dst)> FMMGDELNIPM, int GDAJCNKPBDC, OOILAAHGBJC PDPOLFACNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2E05930", Offset = "0x2E04330", VA = "0x182E05930")]
	private NativeMultiHashMap<int, (DFKOJFHJBPL, DFKOJFHJBPL)> BBOECDMGLPO(Allocator GGPAKDMJHLJ, NativeArray<DFKOJFHJBPL> NNPEDNPMEIC, out NativeArray<(DFKOJFHJBPL src, DFKOJFHJBPL dst)> CIHNMEBBDEM)
	{
		return default(NativeMultiHashMap<int, (DFKOJFHJBPL, DFKOJFHJBPL)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public EEKEFMOLEBM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[LOEOGANCBGC(EDPDLGMLNHJ.TransformSyncing)]
	[AKBJAGIAKDO(typeof(TransformService))]
	[DNOPHNKOHLA(typeof(JOHEJCALJIO), new string[] { })]
	public class TransformService : JOHEJCALJIO, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly KGOHPJFJCLE OMFCNICGAME;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly KGOHPJFJCLE NPPBOLABGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private KJFLPHKBABP OOKLBGAMMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private DEAGKEFEBKN HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private LAIKDFLJMKI HKHMGAMGNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TransformOwnershipPhase CPMEPNLABJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private ObjectEmbodimentService CHJAOAHKKML;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private EntityManager FLHDGCEBOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x2C08210", Offset = "0x2C06C10", VA = "0x182C08210")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private JEHPLMMOFBJ MLKKJKMLPLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x2C0A080", Offset = "0x2C08A80", VA = "0x182C0A080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x2C08100", Offset = "0x2C06B00", VA = "0x182C08100", Slot = "33")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x2C08EF0", Offset = "0x2C078F0", VA = "0x182C08EF0", Slot = "34")]
		public bool LBGADNCAAOJ(Transform CLHKPCIOCGF, out DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x2C09FC0", Offset = "0x2C089C0", VA = "0x182C09FC0", Slot = "35")]
		public Transform NNGDOMLKAEA(Entity GOANOLJBHPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x2C08350", Offset = "0x2C06D50", VA = "0x182C08350", Slot = "30")]
		public bool GOEJCHMLHHD(Entity GOANOLJBHPF, out Transform CLHKPCIOCGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x2C08000", Offset = "0x2C06A00", VA = "0x182C08000")]
		private void FIHMKEGONIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x2C05D10", Offset = "0x2C04710", VA = "0x182C05D10", Slot = "29")]
		public void BBNEHAIAGAD(Entity GOANOLJBHPF, out Matrix4x4 BLCFJOFFEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x2C07540", Offset = "0x2C05F40", VA = "0x182C07540", Slot = "4")]
		public void EILLAGKIDEO(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x2C06440", Offset = "0x2C04E40", VA = "0x182C06440")]
		public void BNKOGLOKAOA(Entity GOANOLJBHPF, Vector3 GBGEGEKJOFF, Quaternion HLMPNEAIKDO, Vector3 PPDOEFDANIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x2C07EF0", Offset = "0x2C068F0", VA = "0x182C07EF0")]
		public void FDFECFOCBIN(Entity GOANOLJBHPF, Vector3 GBGEGEKJOFF, Quaternion HLMPNEAIKDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x2C07DE0", Offset = "0x2C067E0", VA = "0x182C07DE0", Slot = "27")]
		public void FBPCELOJMCB(Entity GOANOLJBHPF, out Matrix4x4 JOMJHADBJOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x2C05E60", Offset = "0x2C04860", VA = "0x182C05E60")]
		public void BCANCOGCMDN(Entity GOANOLJBHPF, in Matrix4x4 BLCFJOFFEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x2C09AF0", Offset = "0x2C084F0", VA = "0x182C09AF0")]
		public void MGDMIJLPGML(Entity GOANOLJBHPF, in Matrix4x4 BLCFJOFFEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2C08D30", Offset = "0x2C07730", VA = "0x182C08D30")]
		public void KGJEECMELCB(Entity GOANOLJBHPF, in Matrix4x4 FAFPKELDEJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A2F0", Offset = "0x2C08CF0", VA = "0x182C0A2F0", Slot = "5")]
		public void OIKLGIPKJJN(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2C06750", Offset = "0x2C05150", VA = "0x182C06750", Slot = "6")]
		public Vector3 CDHMJLLPFOH(Entity GOANOLJBHPF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x2C07DF0", Offset = "0x2C067F0", VA = "0x182C07DF0", Slot = "7")]
		public void FCDOPBINEBB(Entity GOANOLJBHPF, Quaternion MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x2C06C40", Offset = "0x2C05640", VA = "0x182C06C40", Slot = "8")]
		public Quaternion DIJINLDKEFE(Entity GOANOLJBHPF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x2C08B50", Offset = "0x2C07550", VA = "0x182C08B50", Slot = "12")]
		public void JLAHOJLKKDE(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x2C06980", Offset = "0x2C05380", VA = "0x182C06980", Slot = "11")]
		public Vector3 COLINAFGHKL(Entity GOANOLJBHPF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x2C07110", Offset = "0x2C05B10", VA = "0x182C07110")]
		public void EECLLHOAMBJ(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x2C08AB0", Offset = "0x2C074B0", VA = "0x182C08AB0")]
		private Vector3 JAGLGDBDLGA(Entity GOANOLJBHPF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2C087B0", Offset = "0x2C071B0", VA = "0x182C087B0", Slot = "14")]
		public float IJEHGCNMIII(Entity GOANOLJBHPF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A500", Offset = "0x2C08F00", VA = "0x182C0A500", Slot = "13")]
		public void OMBJFGGMNME(Entity GOANOLJBHPF, float MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x2C06350", Offset = "0x2C04D50", VA = "0x182C06350")]
		private float BIOBKPPIIKH(Entity GOANOLJBHPF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x2C06E50", Offset = "0x2C05850", VA = "0x182C06E50")]
		public void DPMNFPEKIJN(Entity GOANOLJBHPF, float IOAOFNEFPLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x2C06670", Offset = "0x2C05070", VA = "0x182C06670", Slot = "16")]
		public Vector3 BPAJOKKJFHG(Entity GOANOLJBHPF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x2C08980", Offset = "0x2C07380", VA = "0x182C08980", Slot = "15")]
		public void IMPGJHCKNLH(Entity GOANOLJBHPF, Vector3 FPLPPOAOBCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x2C08850", Offset = "0x2C07250", VA = "0x182C08850")]
		private Vector3 IMOBHBOFAEJ(Entity GOANOLJBHPF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x2C05C40", Offset = "0x2C04640", VA = "0x182C05C40")]
		public void AHAAOKEHAOD(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A140", Offset = "0x2C08B40", VA = "0x182C0A140")]
		[Conditional("DEBUG_BUILD")]
		private void OELDKNGDIJA(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2C06510", Offset = "0x2C04F10", VA = "0x182C06510", Slot = "36")]
		public void BOCKAIIBECD(Entity GOANOLJBHPF, Vector3 OAALNDIAAOB, Quaternion HOOCPOKGFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A610", Offset = "0x2C09010", VA = "0x182C0A610", Slot = "9")]
		public void PAKJNFOLHCP(Entity GOANOLJBHPF, out Vector3 OAALNDIAAOB, out Quaternion HOOCPOKGFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2C06220", Offset = "0x2C04C20", VA = "0x182C06220", Slot = "10")]
		public void BCLKFJNIGFD(Entity GOANOLJBHPF, out Vector3 OAALNDIAAOB, out Quaternion HOOCPOKGFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x2C08590", Offset = "0x2C06F90", VA = "0x182C08590", Slot = "37")]
		public void HLOKOLGNMEE(Entity GOANOLJBHPF, Vector3 OAALNDIAAOB, Quaternion HOOCPOKGFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x2C07730", Offset = "0x2C06130", VA = "0x182C07730")]
		public void EKCKFHNBBCB(Entity GOANOLJBHPF, Vector3 OAALNDIAAOB, Quaternion HOOCPOKGFMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x2C06EE0", Offset = "0x2C058E0", VA = "0x182C06EE0", Slot = "17")]
		public void ECAJNKONNEH(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2C08020", Offset = "0x2C06A20", VA = "0x182C08020", Slot = "18")]
		public Vector3 FPMGKAGIODP(Entity GOANOLJBHPF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x2C071B0", Offset = "0x2C05BB0", VA = "0x182C071B0", Slot = "19")]
		public void EEJLMNEBFOP(Entity GOANOLJBHPF, Quaternion MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A410", Offset = "0x2C08E10", VA = "0x182C0A410", Slot = "20")]
		public Quaternion OKLKHJOJHEA(Entity GOANOLJBHPF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A7E0", Offset = "0x2C091E0", VA = "0x182C0A7E0", Slot = "22")]
		public void PJAGCBMOGCF(Entity GOANOLJBHPF, Vector3 MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x2C08260", Offset = "0x2C06C60", VA = "0x182C08260", Slot = "21")]
		public Vector3 GMDPNHMFDDK(Entity GOANOLJBHPF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x2C09980", Offset = "0x2C08380", VA = "0x182C09980", Slot = "23")]
		public void LNOHOBMEHFL(Entity GOANOLJBHPF, float DEBNEMODDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x2C06D30", Offset = "0x2C05730", VA = "0x182C06D30", Slot = "24")]
		public float DNBEKFAEPDA(Entity GOANOLJBHPF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x2C078F0", Offset = "0x2C062F0", VA = "0x182C078F0", Slot = "25")]
		public void ELJDFADFNNL(Entity GOANOLJBHPF, Vector3 DGNEKHFMADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x2C08440", Offset = "0x2C06E40", VA = "0x182C08440", Slot = "26")]
		public Vector3 HBPPDKACENN(Entity GOANOLJBHPF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x2C092E0", Offset = "0x2C07CE0", VA = "0x182C092E0", Slot = "31")]
		public void LNMPPIPCKEH(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x2C073F0", Offset = "0x2C05DF0", VA = "0x182C073F0")]
		private DFKOJFHJBPL EHDPFLFBCCG(Transform CLHKPCIOCGF)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2C090B0", Offset = "0x2C07AB0", VA = "0x182C090B0")]
		private static TransformEntity LHKKDGEGBNE(AOIKBHJMDBO MAHAMGBPDNB, GameObject ICDBBFEMLLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2C06860", Offset = "0x2C05260", VA = "0x182C06860", Slot = "32")]
		public void CJFHPOOPMHC(Entity GOANOLJBHPF, Entity PMJEABCAKDM, Entity DILGNCFGGHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2C0A760", Offset = "0x2C09160", VA = "0x182C0A760")]
		private KLDOBHGLMJG PAKJNFOLHCP(Entity GOANOLJBHPF)
		{
			return default(KLDOBHGLMJG);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x2C08C50", Offset = "0x2C07650", VA = "0x182C08C50")]
		private bool JLNKHPBEBDF(Entity GOANOLJBHPF, out Entity ELGBIOMPEHN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x2C06A90", Offset = "0x2C05490", VA = "0x182C06A90")]
		private void DBCOCMHCHKO(Entity GOANOLJBHPF, out Matrix4x4 BLCFJOFFEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x2C09C20", Offset = "0x2C08620", VA = "0x182C09C20")]
		private void NLGIKDKFBMM(Entity GOANOLJBHPF, out Matrix4x4 FAFPKELDEJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x2C08580", Offset = "0x2C06F80", VA = "0x182C08580", Slot = "28")]
		private void HDPHHJLMGGI(Entity GOANOLJBHPF, in Matrix4x4 JOMJHADBJOD)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
[DNOPHNKOHLA(typeof(GKJFBOHJKAA), new string[] { })]
internal sealed class GKJFBOHJKAA : MMKNGEFLOAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[JIFPDEDMPGC]
	private LFIFNADKAEF EDFOBNPNANH;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A900", Offset = "0x2C19300", VA = "0x182C1A900", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A890", Offset = "0x2C19290", VA = "0x182C1A890", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public GKJFBOHJKAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
[DNOPHNKOHLA(typeof(EBNOIJADHJD), new string[] { })]
public class EBNOIJADHJD
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct HPOIIEPGBLP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly EBNOIJADHJD ELGBIOMPEHN;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7D20", Offset = "0x2BF6720", VA = "0x182BF7D20")]
		public HPOIIEPGBLP(EBNOIJADHJD ELGBIOMPEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7D00", Offset = "0x2BF6700", VA = "0x182BF7D00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int AJPNGDLGGNJ;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool BMFDEDDLHII
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x131F6F0", Offset = "0x131E0F0", VA = "0x18131F6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action FEMJMMEGCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x2E05550", Offset = "0x2E03F50", VA = "0x182E05550")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x2E05610", Offset = "0x2E04010", VA = "0x182E05610")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2E05520", Offset = "0x2E03F20", VA = "0x182E05520")]
	public HPOIIEPGBLP BHJCLOPNAGF()
	{
		return default(HPOIIEPGBLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x14890F0", Offset = "0x1487AF0", VA = "0x1814890F0")]
	public void FOKLHKDGDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x2E055F0", Offset = "0x2E03FF0", VA = "0x182E055F0")]
	public void DCGEALCEIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public EBNOIJADHJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[DNOPHNKOHLA(typeof(PMEHOMADNGN), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public class PMEHOMADNGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int AJPNGDLGGNJ;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool FCANJHPHPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xDD4060", Offset = "0xDD2A60", VA = "0x180DD4060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x9A5E10", Offset = "0x9A4810", VA = "0x1809A5E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PMEHOMADNGN()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[DNOPHNKOHLA(typeof(EnableComponentSystemsInScope), new string[] { })]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	[LOEOGANCBGC(EDPDLGMLNHJ.ComponentSystemTypes)]
	public class EnableComponentSystemsInScope : MMKNGEFLOAO, EPNGNNMLNLK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct MALBCNEKCPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private NativeArray<int> LAOJBCAPLDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private NativeArray<int> IMCOAJBLBJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private Dictionary<ComponentSystemBase, int> PJCLNBCAPAD;

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x3FF7290", Offset = "0x3FF5C90", VA = "0x183FF7290")]
			public MALBCNEKCPI(NativeArray<int> LAOJBCAPLDH, NativeArray<int> IMCOAJBLBJG, Dictionary<ComponentSystemBase, int> PJCLNBCAPAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x3FF7010", Offset = "0x3FF5A10", VA = "0x183FF7010")]
			public void CACDPCKGGEN(IEnumerable<ComponentSystemBase> DBKMNLNGAJC, EIJAKMAIFNG PPOMMDEPJFJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class MCKNLNFFMDB : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private ComponentSystemBase <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public EnableComponentSystemsInScope <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private int start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public int <>3__start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private int end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>3__end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
			[DebuggerHidden]
			public MCKNLNFFMDB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x3FF72B0", Offset = "0x3FF5CB0", VA = "0x183FF72B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x3FF7480", Offset = "0x3FF5E80", VA = "0x183FF7480", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x3FF73D0", Offset = "0x3FF5DD0", VA = "0x183FF73D0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x3FF73D0", Offset = "0x3FF5DD0", VA = "0x183FF73D0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public const EIJAKMAIFNG FDGCBAAKFEL = EIJAKMAIFNG.LoadInstance;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private static readonly KGOHPJFJCLE OENHKFLGPHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN ALIKEONHNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private World HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private NKLKBAHCHOA BKJAOJMOJPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private NativeArray<int> JGLBLCNHDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private NativeArray<int> AIDEFCDNADJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private int FMHBAJCDDEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private EIJAKMAIFNG KAPOPKCPBNC;

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x2E09FA0", Offset = "0x2E089A0", VA = "0x182E09FA0", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2E09C10", Offset = "0x2E08610", VA = "0x182E09C10", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A020", Offset = "0x2E08A20", VA = "0x182E0A020")]
		[IteratorStateMachine(typeof(MCKNLNFFMDB))]
		private IEnumerable<ComponentSystemBase> HGJLKGMCGOI(int AGNHLFMCFOJ, int PGDLDMBJJEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A8F0", Offset = "0x2E092F0", VA = "0x182E0A8F0", Slot = "5")]
		public void OABGDDDFKDJ(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x2E09DA0", Offset = "0x2E087A0", VA = "0x182E09DA0")]
		private void EGPODEOMEFN(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2E09CA0", Offset = "0x2E086A0", VA = "0x182E09CA0")]
		public void EGPODEOMEFN(EIJAKMAIFNG BBFFMAKGJDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2E097B0", Offset = "0x2E081B0", VA = "0x182E097B0")]
		private void BODKPPAMPDE(EIJAKMAIFNG BBFFMAKGJDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x2E09F10", Offset = "0x2E08910", VA = "0x182E09F10")]
		private void GCNKFBGLANF(EIJAKMAIFNG BBFFMAKGJDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2E09A40", Offset = "0x2E08440", VA = "0x182E09A40")]
		private void COIIMNHCIFB(EIJAKMAIFNG BBFFMAKGJDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A6A0", Offset = "0x2E090A0", VA = "0x182E0A6A0")]
		private void KIPMEJHHHBP(int AGNHLFMCFOJ, int PGDLDMBJJEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x2E09AA0", Offset = "0x2E084A0", VA = "0x182E09AA0")]
		private void DHNFMPODOCO(int AGNHLFMCFOJ, int PGDLDMBJJEP, bool JECBMIHPMOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x2E09EF0", Offset = "0x2E088F0", VA = "0x182E09EF0")]
		private int EJNPJOOKABD(EIJAKMAIFNG BBFFMAKGJDM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A110", Offset = "0x2E08B10", VA = "0x182E0A110")]
		private bool IPNJNDDMKPN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A800", Offset = "0x2E09200", VA = "0x182E0A800")]
		private Dictionary<ComponentSystemBase, int> NGFJCDAKENA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A7C0", Offset = "0x2E091C0", VA = "0x182E0A7C0")]
		private void LGELEOOMGDP(NativeArray<int> LAOJBCAPLDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x2E09B60", Offset = "0x2E08560", VA = "0x182E09B60")]
		private void DPDBMLCNKKH(NativeArray<int> IMCOAJBLBJG, NativeArray<int> LAOJBCAPLDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A760", Offset = "0x2E09160", VA = "0x182E0A760")]
		private static EIJAKMAIFNG KPNAJFMOKPJ(Type MAHAMGBPDNB, EIJAKMAIFNG OGDNNKNPNAO)
		{
			return default(EIJAKMAIFNG);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A9F0", Offset = "0x2E093F0", VA = "0x182E0A9F0")]
		public EnableComponentSystemsInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A900", Offset = "0x2E09300", VA = "0x182E0A900")]
		[CompilerGenerated]
		private void OOAIPKKIHGB(MMKNGEFLOAO EJIGNNOPIHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2E0A0B0", Offset = "0x2E08AB0", VA = "0x182E0A0B0")]
		[CompilerGenerated]
		private void IDFANOKJEAI(PKBAIAJJFPF EJIGNNOPIHA)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[LOEOGANCBGC(EDPDLGMLNHJ.WorldService)]
	[DNOPHNKOHLA(typeof(ODIDMGCABMI), new string[] { })]
	public class TickService : MMKNGEFLOAO, ODIDMGCABMI
	{
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly ProfilerMarker DMCOOLAFOGA;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ProfilerMarker MOMKKJBNKIN;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly ProfilerMarker GGBGHGOPNAM;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly ProfilerMarker AHEMNGEJDAP;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly ProfilerMarker JJKBLIOEIIP;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly ProfilerMarker DMDLBONIMEO;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly ProfilerMarker JNDMGACMKOI;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly ProfilerMarker HEBFJDPCKNP;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly ProfilerMarker JJFCDGKJPME;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly ProfilerMarker KBCPEPKCANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN ALIKEONHNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[JIFPDEDMPGC]
		private FCADPKIAEAJ JAINECODPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[JIFPDEDMPGC]
		private OHLJMGEOGPF HHPPFLNINLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[JIFPDEDMPGC]
		private TransformOwnershipPhase PMJLEAGPJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[JIFPDEDMPGC]
		private TimeService BNNFECLLHDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private EAPDPHILGKF HDJFKDANOCN;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private bool FKFEKDPOLCA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x2C04D00", Offset = "0x2C03700", VA = "0x182C04D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private bool MALJGKJOEOC
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x2C04B40", Offset = "0x2C03540", VA = "0x182C04B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private bool BNMIBLPJBEM
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x2C04D00", Offset = "0x2C03700", VA = "0x182C04D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool ADJMAMENCCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x2C04D00", Offset = "0x2C03700", VA = "0x182C04D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2C04780", Offset = "0x2C03180", VA = "0x182C04780", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2C03E80", Offset = "0x2C02880", VA = "0x182C03E80", Slot = "14")]
		public void AEIELPFFFNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2C04BE0", Offset = "0x2C035E0", VA = "0x182C04BE0", Slot = "15")]
		public void LHLECKKGEIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x2C04120", Offset = "0x2C02B20", VA = "0x182C04120", Slot = "5")]
		public void DNCKJBGOMFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x2C03FA0", Offset = "0x2C029A0", VA = "0x182C03FA0", Slot = "6")]
		public void DLBBPPGMJPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C048F0", Offset = "0x2C032F0", VA = "0x182C048F0", Slot = "7")]
		public void GMIJFMMNNED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C04D70", Offset = "0x2C03770", VA = "0x182C04D70", Slot = "8")]
		public void NJPCFLEPKAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C04EF0", Offset = "0x2C038F0", VA = "0x182C04EF0", Slot = "9")]
		public void OBLAABLNICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C041F0", Offset = "0x2C02BF0", VA = "0x182C041F0", Slot = "10")]
		public void DPBIOOPBHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C04A70", Offset = "0x2C03470", VA = "0x182C04A70", Slot = "11")]
		public void IGEPBKNBMLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "13")]
		public void LALKIDCIEDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C04630", Offset = "0x2C03030", VA = "0x182C04630", Slot = "12")]
		public void EOOKKCOHGMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public TickService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[DNOPHNKOHLA(typeof(DEAGKEFEBKN), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.WorldService)]
	public class WorldService : DEAGKEFEBKN, IDisposable, IPCGJDFHGJG, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private EAPDPHILGKF HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private DBDNMBFJLEK GEODCBKPIGD;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public EAPDPHILGKF CIFPLKLELPL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public JEHPLMMOFBJ MLKKJKMLPLI
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2AE5BA0", Offset = "0x2AE45A0", VA = "0x182AE5BA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EntityManager FLHDGCEBOEE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2C133E0", Offset = "0x2C11DE0", VA = "0x182C133E0", Slot = "6")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool JDCINNHHEGM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8D0", Offset = "0x6DA2D0", VA = "0x1806DB8D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x2C12F40", Offset = "0x2C11940", VA = "0x182C12F40", Slot = "10")]
		public void BEJHKBIOAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x2C13390", Offset = "0x2C11D90", VA = "0x182C13390", Slot = "11")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x2C13280", Offset = "0x2C11C80", VA = "0x182C13280")]
		private void GANMJPNFBJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C13050", Offset = "0x2C11A50", VA = "0x182C13050", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x2C13400", Offset = "0x2C11E00", VA = "0x182C13400", Slot = "8")]
		public ComponentSystemBase NFLGFLGDLGA(Type MAHAMGBPDNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public WorldService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[DNOPHNKOHLA(typeof(KEPHDBCLKDO), new string[] { })]
public sealed class DECFHBHOHJH : KEPHDBCLKDO, EBFNJADEFGO, IPCGJDFHGJG, MMKNGEFLOAO, PKBAIAJJFPF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class AONNLPOHFHP : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x6E2040", Offset = "0x6E0A40", VA = "0x1806E2040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5D40", Offset = "0x2BF4740", VA = "0x182BF5D40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x968EC0", Offset = "0x9678C0", VA = "0x180968EC0")]
		[DebuggerHidden]
		public AONNLPOHFHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5A30", Offset = "0x2BF4430", VA = "0x182BF5A30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5D00", Offset = "0x2BF4700", VA = "0x182BF5D00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5C60", Offset = "0x2BF4660", VA = "0x182BF5C60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x2BF5C60", Offset = "0x2BF4660", VA = "0x182BF5C60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	[JIFPDEDMPGC]
	private BJKMJANDEAI PDPOLFACNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly ODNEAFEPGJM DLNCLBNOJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly Dictionary<string, CPNCCKOAJEF> KLEHCLEOBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly Dictionary<int, DHNPEMGDPLJ> EDIJNIKCHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly List<KNCBBMLNKLK> BHKEPEGDICK;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public DHNPEMGDPLJ HHHNDDHIHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x2E01B40", Offset = "0x2E00540", VA = "0x182E01B40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public List<KNCBBMLNKLK> IBMMPJGCOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
	public void BEJHKBIOAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x2E01CA0", Offset = "0x2E006A0", VA = "0x182E01CA0", Slot = "8")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2E01BA0", Offset = "0x2E005A0", VA = "0x182E01BA0", Slot = "9")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2E019B0", Offset = "0x2E003B0", VA = "0x182E019B0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x2E01AB0", Offset = "0x2E004B0", VA = "0x182E01AB0", Slot = "6")]
	public bool EFIEMPOLKNI(KNCBBMLNKLK OPPPBNFKNOC, out DHNPEMGDPLJ EAGMPINEKBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x2E02130", Offset = "0x2E00B30", VA = "0x182E02130")]
	private void NBGKCGEGEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x2E024C0", Offset = "0x2E00EC0", VA = "0x182E024C0")]
	private void NIGLMNPJAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x2E02660", Offset = "0x2E01060", VA = "0x182E02660")]
	private CPNCCKOAJEF OKJLILKBOGD(string APHLDLKODFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2E01B40", Offset = "0x2E00540", VA = "0x182E01B40")]
	private CPNCCKOAJEF EOOLLGOHGLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2E01EC0", Offset = "0x2E008C0", VA = "0x182E01EC0")]
	private CPNCCKOAJEF MKBDAOCPCCA(string APHLDLKODFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x2E017E0", Offset = "0x2E001E0", VA = "0x182E017E0")]
	private CPNCCKOAJEF BKDFADKABLO(string NKNOOFILFKG, string DEGCIHEAIBD, [Optional] CPNCCKOAJEF GMNPCIHICBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x2E01A40", Offset = "0x2E00440", VA = "0x182E01A40")]
	[IteratorStateMachine(typeof(AONNLPOHFHP))]
	private IEnumerable<(string, string)> ECBFOLEHLMJ(string APHLDLKODFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x2E01700", Offset = "0x2E00100", VA = "0x182E01700")]
	private bool AGGNBEIBHPG(KNCBBMLNKLK OPPPBNFKNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2E01D00", Offset = "0x2E00700", VA = "0x182E01D00")]
	private ODNEAFEPGJM INLIAENPJJL(KNCBBMLNKLK OPPPBNFKNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x2E01DE0", Offset = "0x2E007E0", VA = "0x182E01DE0")]
	private ODNEAFEPGJM JGKMKJNANOC(KNCBBMLNKLK OPPPBNFKNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2E01E30", Offset = "0x2E00830", VA = "0x182E01E30")]
	private ODNEAFEPGJM KMFDNIBOHFO(KNCBBMLNKLK OPPPBNFKNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1D629C0", Offset = "0x1D613C0", VA = "0x181D629C0")]
	private T IBMFKKINHKB<T>(KNCBBMLNKLK OPPPBNFKNOC) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2E01BC0", Offset = "0x2E005C0", VA = "0x182E01BC0")]
	private FieldInfo GAODAIDICPA(KNCBBMLNKLK OPPPBNFKNOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2E026C0", Offset = "0x2E010C0", VA = "0x182E026C0")]
	public DECFHBHOHJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2E01750", Offset = "0x2E00150", VA = "0x182E01750")]
	[CompilerGenerated]
	private int AIJPDIFCFFL(KNCBBMLNKLK PKEMCIANHMO, KNCBBMLNKLK DLAMIJMLOOE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class CPNCCKOAJEF : DHNPEMGDPLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly string ILBCNNGPJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly CPNCCKOAJEF GMNPCIHICBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly List<CPNCCKOAJEF> KKOFGKCOAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly List<KNCBBMLNKLK> PDPOLFACNJC;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public string LOFFIGMBIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DHNPEMGDPLJ AIELMMPAMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public IEnumerable<DHNPEMGDPLJ> LAMJMBKENMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IEnumerable<KNCBBMLNKLK> KPGMMAHBADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4C30", Offset = "0x2DF3630", VA = "0x182DF4C30")]
	public CPNCCKOAJEF(string ANJJEPIBAGI, CPNCCKOAJEF ELGBIOMPEHN)
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[DNOPHNKOHLA(typeof(EBIDIPICLGG), new string[] { })]
	[AKBJAGIAKDO(typeof(HistoryService))]
	[LOEOGANCBGC(EDPDLGMLNHJ.History)]
	public class HistoryService : MMKNGEFLOAO, IDisposable, EBIDIPICLGG
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private enum JGLPMEOIOMD
		{
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Undoing,
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			Normal,
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			Redoing
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private readonly struct JLCBFDGPIKG : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly JGLPMEOIOMD FOFBBHDFEON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly HistoryService DMALFCEFIJB;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4E10", Offset = "0x3FF3810", VA = "0x183FF4E10")]
			public JLCBFDGPIKG(HistoryService DMALFCEFIJB, bool BAJFDHKJPIE, uint FMHBAJCDDEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4DE0", Offset = "0x3FF37E0", VA = "0x183FF4DE0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public class MHJAPFAKNFF
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			public struct ONJNBPICIBB : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				private readonly MHJAPFAKNFF GLGBBCABHHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				private readonly bool GINKKHJNPNJ;

				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0x3FF9A90", Offset = "0x3FF8490", VA = "0x183FF9A90")]
				public ONJNBPICIBB(MHJAPFAKNFF GLGBBCABHHI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600035F")]
				[Cpp2IlInjected.Address(RVA = "0x3FF1D10", Offset = "0x3FF0710", VA = "0x183FF1D10", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public struct GCNNOFMMOCO : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				private readonly MHJAPFAKNFF GLGBBCABHHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				private readonly bool GINKKHJNPNJ;

				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0x3FF1D40", Offset = "0x3FF0740", VA = "0x183FF1D40")]
				public GCNNOFMMOCO(MHJAPFAKNFF GLGBBCABHHI)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000361")]
				[Cpp2IlInjected.Address(RVA = "0x3FF1D10", Offset = "0x3FF0710", VA = "0x183FF1D10", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly HistoryService EKFKPEJHOIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private bool FPPOIMHJCPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int KCCGGGAPAHA;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x3FF7590", Offset = "0x3FF5F90", VA = "0x183FF7590")]
			public MHJAPFAKNFF(HistoryService EKFKPEJHOIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x3FF7510", Offset = "0x3FF5F10", VA = "0x183FF7510")]
			public bool FPGOLDKBBBM(AKLFKNOOHJC EFHLICFAAGO, JBNNELNIDOD ILFNNAAOJHE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x3FF7540", Offset = "0x3FF5F40", VA = "0x183FF7540")]
			public GCNNOFMMOCO JMFMLJOKCFH()
			{
				return default(GCNNOFMMOCO);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x3FF74C0", Offset = "0x3FF5EC0", VA = "0x183FF74C0")]
			public ONJNBPICIBB DGDLAHFPILC()
			{
				return default(ONJNBPICIBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private sealed class PBHHIGNHFAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public UndoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public PBHHIGNHFAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x3FF9AD0", Offset = "0x3FF84D0", VA = "0x183FF9AD0")]
			internal RedoAction <Undo>b__0()
			{
				return default(RedoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class CLJAMBBJDND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public HistoryService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public RedoAction target;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public CLJAMBBJDND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0760", Offset = "0x3FEF160", VA = "0x183FF0760")]
			internal UndoAction <Redo>b__0()
			{
				return default(UndoAction);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class LDPFNEDEDNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public Action action;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public LDPFNEDEDNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6290", Offset = "0x3FF4C90", VA = "0x183FF6290")]
			internal bool <SyncProperties>b__0()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly UndoAction MMPGGLMLBKN;

		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private static readonly RedoAction EDABHDAEOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private JDANHJOFJID CLJLBMMJEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ActionBuffer DKPDHLNIDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private ActionBuffer BHHHMMHNCNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private FOOJHGAINEN GHECLGAGFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TransformOwnershipPhase PMJLEAGPJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private PropertyChangeRouterService HHAPCEEGLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private FKDIMDHABHE GEOLIFJDGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private JGLPMEOIOMD IKELIIEHKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private MHJAPFAKNFF GLGBBCABHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private PDDEKMBPLOK GNNMJPOKEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private BPDJHFAPEAG PGLPJOOCNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private JBNNELNIDOD LKDEKLNBOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly GatherPropertiesForUndelete JILCDFDFADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private uint IOJLDCFKHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private uint LKHLCOBCGMC;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		private MHJAPFAKNFF MLAJPOHHGOP
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x6D7770", Offset = "0x6D6170", VA = "0x1806D7770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool LJCFCHGDHLK
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x2C235F0", Offset = "0x2C21FF0", VA = "0x182C235F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool LFCKAMBHMOA
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x2C218F0", Offset = "0x2C202F0", VA = "0x182C218F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool DBKAMGIBNIO
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x2C21850", Offset = "0x2C20250", VA = "0x182C21850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int MMBPLJFMIDL
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x2C22800", Offset = "0x2C21200", VA = "0x182C22800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int AKGIMCGMNJB
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x2C23200", Offset = "0x2C21C00", VA = "0x182C23200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		private bool EHBPJCFCLOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2C238E0", Offset = "0x2C222E0", VA = "0x182C238E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private bool IBLJEDJAHNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x2C21880", Offset = "0x2C20280", VA = "0x182C21880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool ICCMMDPOLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x900D70", Offset = "0x8FF770", VA = "0x180900D70", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0xFB18F0", Offset = "0xFB02F0", VA = "0x180FB18F0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private ActionBuffer AMNJGHIPKGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x2C214D0", Offset = "0x2C1FED0", VA = "0x182C214D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action PPFKOKHOCHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x2C237A0", Offset = "0x2C221A0", VA = "0x182C237A0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x2C23840", Offset = "0x2C22240", VA = "0x182C23840", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action CCMDADDFICM
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x2C23160", Offset = "0x2C21B60", VA = "0x182C23160")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x2C22DE0", Offset = "0x2C217E0", VA = "0x182C22DE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x2C220F0", Offset = "0x2C20AF0", VA = "0x182C220F0", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x2C21C50", Offset = "0x2C20650", VA = "0x182C21C50", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x2C22C60", Offset = "0x2C21660", VA = "0x182C22C60")]
		private void JBOMHPGMIGE(AKLFKNOOHJC EFHLICFAAGO, LDJLMGPDHCO PKCDMLNGGAD, bool LCPDIICONJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x2C23220", Offset = "0x2C21C20", VA = "0x182C23220")]
		private void KPKMAABFAMC(AKLFKNOOHJC EFHLICFAAGO, JBNNELNIDOD ILFNNAAOJHE, DHBMIEMIIHO OPDCHLGAPDP, DHBMIEMIIHO ONFBDMEKEAL, bool LCPDIICONJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x2C229A0", Offset = "0x2C213A0", VA = "0x182C229A0")]
		private void IHBEHHCOPCI(AKLFKNOOHJC EFHLICFAAGO, bool LCPDIICONJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x2C227A0", Offset = "0x2C211A0", VA = "0x182C227A0", Slot = "14")]
		public IDisposable HPFMMLNPGKE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x2C22090", Offset = "0x2C20A90", VA = "0x182C22090", Slot = "9")]
		public IDisposable FBBLPPCJNDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x2C22680", Offset = "0x2C21080", VA = "0x182C22680", Slot = "6")]
		public UndoAction HHPEGPECABM()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x2C21410", Offset = "0x2C1FE10", VA = "0x182C21410", Slot = "15")]
		public RedoAction ABFABJHKBPA()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x2C214E0", Offset = "0x2C1FEE0", VA = "0x182C214E0", Slot = "16")]
		public UndoAction AHLFPHBNKGH()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x2C212F0", Offset = "0x2C1FCF0", VA = "0x182C212F0", Slot = "7")]
		public RedoAction ABFABJHKBPA(UndoAction JNODNCHMALF)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x2C215A0", Offset = "0x2C1FFA0", VA = "0x182C215A0", Slot = "8")]
		public UndoAction AHLFPHBNKGH(RedoAction JNODNCHMALF)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x2C23560", Offset = "0x2C21F60", VA = "0x182C23560")]
		public bool MFCLIINNDBN(LOMEPAEHMFH MOJCJBMONNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x2C235A0", Offset = "0x2C21FA0", VA = "0x182C235A0", Slot = "17")]
		public void NMFIICNHENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x2C23260", Offset = "0x2C21C60", VA = "0x182C23260")]
		public void LNCOMHGPOAE(AKLFKNOOHJC EFHLICFAAGO, LDJLMGPDHCO PKCDMLNGGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x2C23660", Offset = "0x2C22060", VA = "0x182C23660")]
		public void PEBCBPJPKKH(AKLFKNOOHJC EFHLICFAAGO, JBNNELNIDOD ILFNNAAOJHE, in DHBMIEMIIHO ONFBDMEKEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x2C21F10", Offset = "0x2C20910", VA = "0x182C21F10")]
		public void FAKDAIKDHFD(AKLFKNOOHJC EFHLICFAAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2C218B0", Offset = "0x2C202B0", VA = "0x182C218B0")]
		private void DHENBBOEAIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2C216C0", Offset = "0x2C200C0", VA = "0x182C216C0")]
		private void BANGKGFALKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x2C21EF0", Offset = "0x2C208F0", VA = "0x182C21EF0")]
		private void FAAIIKIELON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x2C228A0", Offset = "0x2C212A0", VA = "0x182C228A0")]
		private KJBMIFDIHHB ICKCJBOAIMP()
		{
			return default(KJBMIFDIHHB);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x2C21890", Offset = "0x2C20290", VA = "0x182C21890")]
		private uint DEMDCKJPBCJ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x2C23240", Offset = "0x2C21C40", VA = "0x182C23240")]
		private bool LCGGKNHPADG(out KJBMIFDIHHB CKAPOBIDCEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x2C22660", Offset = "0x2C21060", VA = "0x182C22660")]
		private bool HECOEOEMDAC(out KJBMIFDIHHB CKAPOBIDCEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x2C22740", Offset = "0x2C21140", VA = "0x182C22740")]
		private RedoAction HNBKEKLFEAN(KJBMIFDIHHB CKAPOBIDCEI)
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2C233F0", Offset = "0x2C21DF0", VA = "0x182C233F0")]
		private UndoAction LPHGCPLEFBG(KJBMIFDIHHB CKAPOBIDCEI)
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x2C21990", Offset = "0x2C20390", VA = "0x182C21990")]
		private KJBMIFDIHHB DKNEMNEHIAL(KJBMIFDIHHB CKAPOBIDCEI, ActionBuffer GFBBJFDPHKE, bool BAJFDHKJPIE)
		{
			return default(KJBMIFDIHHB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x2C23480", Offset = "0x2C21E80", VA = "0x182C23480")]
		private void MBHEODMGJIO(Action CKAPOBIDCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x2231F90", Offset = "0x2230990", VA = "0x182231F90")]
		private T MBHEODMGJIO<T>(Func<T> FMGENDBPDEG)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x2C23450", Offset = "0x2C21E50", VA = "0x182C23450")]
		private JLCBFDGPIKG LPKGBGDMAHC(bool BAJFDHKJPIE, uint FMHBAJCDDEI)
		{
			return default(JLCBFDGPIKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x2C239D0", Offset = "0x2C223D0", VA = "0x182C239D0")]
		public HistoryService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x2C21700", Offset = "0x2C20100", VA = "0x182C21700")]
		[CompilerGenerated]
		private UndoAction BBDCNPDFLPI()
		{
			return default(UndoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x2C22FE0", Offset = "0x2C219E0", VA = "0x182C22FE0")]
		[CompilerGenerated]
		private RedoAction KDGBCNEFEAB()
		{
			return default(RedoAction);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x2C22E80", Offset = "0x2C21880", VA = "0x182C22E80")]
		[CompilerGenerated]
		private UndoAction JKFOMNLMDOA()
		{
			return default(UndoAction);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class AOCAGEBBIPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private NativeArray<byte> GNPHBMKMMCM;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int GBJCKAFHMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xCCCDD0", Offset = "0xCCB7D0", VA = "0x180CCCDD0")]
	public AOCAGEBBIPC(NativeArray<byte> GNPHBMKMMCM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x2DEEE00", Offset = "0x2DED800", VA = "0x182DEEE00")]
	public static AOCAGEBBIPC EGMKMIPNLBF(NativeArray<byte> GNPHBMKMMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	public T KAKOKJEJFGF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	public NativeArray<T> EMBBDOEDIKJ<T>(int KHNOOLPHJPF, Allocator GGPAKDMJHLJ) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	public NativeArray<T> GGMPDILEFEJ<T>(Allocator GGPAKDMJHLJ) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GFHACAOODPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NativeArray<byte> GNPHBMKMMCM;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int GBJCKAFHMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0xCCCDD0", Offset = "0xCCB7D0", VA = "0x180CCCDD0")]
	public GFHACAOODPP(NativeArray<byte> GNPHBMKMMCM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A180", Offset = "0x2C18B80", VA = "0x182C1A180")]
	public static GFHACAOODPP EGMKMIPNLBF(NativeArray<byte> GNPHBMKMMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x2DC0D80", Offset = "0x2DBF780", VA = "0x182DC0D80")]
	public T KAKOKJEJFGF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	public NativeArray<T> EMBBDOEDIKJ<T>(int KHNOOLPHJPF, Allocator GGPAKDMJHLJ) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class NJMLAEBAMGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NativeArray<byte> GNPHBMKMMCM;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int GBJCKAFHMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0xCCCDD0", Offset = "0xCCB7D0", VA = "0x180CCCDD0")]
	public NJMLAEBAMGF(NativeArray<byte> GNPHBMKMMCM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x2AE80D0", Offset = "0x2AE6AD0", VA = "0x182AE80D0")]
	public static NJMLAEBAMGF EGMKMIPNLBF(NativeArray<byte> GNPHBMKMMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x332DE90", Offset = "0x332C890", VA = "0x18332DE90")]
	public void LPELDCEGLGB<T>(in T MNIAGKNOHEJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x332DD90", Offset = "0x332C790", VA = "0x18332DD90")]
	public void IOKEGDAOJMO<T>(NativeArray<T> APKDOIJAGNF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	public void JHABLPHKJGH<T>(NativeArray<T> MNIAGKNOHEJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class IMMGDKCJPOP
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2C25620", Offset = "0x2C24020", VA = "0x182C25620")]
	public static Span<byte> IIGDAPNIEHH(this NativeArray<byte> GNPHBMKMMCM)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x2C25730", Offset = "0x2C24130", VA = "0x182C25730")]
	public static ReadOnlySpan<byte> KPEFNGIKDJA(this NativeArray<byte> GNPHBMKMMCM)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2C258B0", Offset = "0x2C242B0", VA = "0x182C258B0")]
	public static NativeArray<byte> NLDBCJLJCJP(this NativeArray<byte> GNPHBMKMMCM, int AGNHLFMCFOJ)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2C25930", Offset = "0x2C24330", VA = "0x182C25930")]
	public static NativeArray<byte> PKNGJBNKCHG(this NativeArray<byte> GNPHBMKMMCM, int JOBJIONNEHK = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x223DEE0", Offset = "0x223C8E0", VA = "0x18223DEE0")]
	public static NativeArray<byte> PKNGJBNKCHG<T>(this NativeArray<byte> GNPHBMKMMCM, int JOBJIONNEHK = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2C255B0", Offset = "0x2C23FB0", VA = "0x182C255B0")]
	public static NativeArray<byte> BFOIGHPMEJI(this NativeArray<byte> GNPHBMKMMCM, int JOBJIONNEHK)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x223C940", Offset = "0x223B340", VA = "0x18223C940")]
	public static NativeArray<byte> BFOIGHPMEJI<T>(this NativeArray<byte> GNPHBMKMMCM, int JOBJIONNEHK = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2C256B0", Offset = "0x2C240B0", VA = "0x182C256B0")]
	public static NativeArray<byte> KDAKAFOKKJD(this NativeArray<byte> GNPHBMKMMCM, int JOBJIONNEHK = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x223C9A0", Offset = "0x223B3A0", VA = "0x18223C9A0")]
	public static NativeArray<byte> KDAKAFOKKJD<T>(this NativeArray<byte> GNPHBMKMMCM, int JOBJIONNEHK = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FEJCJJJBGFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeList<byte> OKDFPKLCDDM;

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0xCCCDD0", Offset = "0xCCB7D0", VA = "0x180CCCDD0")]
	public FEJCJJJBGFJ(NativeList<byte> OKDFPKLCDDM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2C17780", Offset = "0x2C16180", VA = "0x182C17780")]
	public static FEJCJJJBGFJ EGMKMIPNLBF(NativeList<byte> GNPHBMKMMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	public void LPELDCEGLGB<T>(in T MNIAGKNOHEJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	public void IOKEGDAOJMO<T>(NativeArray<T> MNIAGKNOHEJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	public void JHABLPHKJGH<T>(NativeArray<T> MNIAGKNOHEJ) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	[DNOPHNKOHLA(typeof(PropertyChangeNetworkRouter), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.PropertyChanges)]
	public class PropertyChangeNetworkRouter : IPCGJDFHGJG, MMKNGEFLOAO, MKGBMKAAJEJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[JIFPDEDMPGC]
		private AMIDHLKBFKD LHGJJBFKNCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[JIFPDEDMPGC]
		private MFCBDCIMKGI PDPOLFACNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[JIFPDEDMPGC]
		private EBNOIJADHJD CLJHGMHDJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[JIFPDEDMPGC]
		private PropertyChangeRouterService HHAPCEEGLHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private JDANHJOFJID AIAOJCAJMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private EOMBAJILNGH CLPDIBEHOBA;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public JDANHJOFJID HPAKLFJKHOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x2B02610", Offset = "0x2B01010", VA = "0x182B02610")]
		public JDANHJOFJID.LFFGMJOGHFH BHJCLOPNAGF()
		{
			return default(JDANHJOFJID.LFFGMJOGHFH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x2B025B0", Offset = "0x2B00FB0", VA = "0x182B025B0", Slot = "4")]
		public void BEJHKBIOAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x2B029B0", Offset = "0x2B013B0", VA = "0x182B029B0", Slot = "5")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x2B02740", Offset = "0x2B01140", VA = "0x182B02740", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2B02C30", Offset = "0x2B01630", VA = "0x182B02C30")]
		public void HHPEGPECABM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x2B032D0", Offset = "0x2B01CD0", VA = "0x182B032D0")]
		public void NMFIICNHENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2B030B0", Offset = "0x2B01AB0", VA = "0x182B030B0")]
		private void JPNFMJECIPC(AKLFKNOOHJC EFHLICFAAGO, LDJLMGPDHCO PKCDMLNGGAD, bool LCPDIICONJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2B02D40", Offset = "0x2B01740", VA = "0x182B02D40")]
		private void HKEANDDGPOF(AKLFKNOOHJC EFHLICFAAGO, JBNNELNIDOD ILFNNAAOJHE, DHBMIEMIIHO OPDCHLGAPDP, DHBMIEMIIHO ONFBDMEKEAL, bool LCPDIICONJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2B02960", Offset = "0x2B01360", VA = "0x182B02960")]
		private void ELEGAIPDPPJ(AKLFKNOOHJC EFHLICFAAGO, bool LCPDIICONJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2B02D80", Offset = "0x2B01780", VA = "0x182B02D80")]
		private void JKEHJDDFHGN(EOMBAJILNGH MMPIIAHIKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2B030E0", Offset = "0x2B01AE0", VA = "0x182B030E0")]
		private void LDCKOOGOJIB(EOMBAJILNGH MMPIIAHIKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2B03210", Offset = "0x2B01C10", VA = "0x182B03210")]
		private void MPEALBEPEDA(EOMBAJILNGH MMPIIAHIKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2B02990", Offset = "0x2B01390", VA = "0x182B02990")]
		private void FOKLHKDGDLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x2B02720", Offset = "0x2B01120", VA = "0x182B02720")]
		private void DCGEALCEIMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x2B02630", Offset = "0x2B01030", VA = "0x182B02630")]
		private void CJKDHAGHMJJ(EOMBAJILNGH MMPIIAHIKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x362C390", Offset = "0x362AD90", VA = "0x18362C390", Slot = "6")]
		private void LBCIDPFNONF<TKey, T>(global::DABFAGPIBGD<TKey, T> OPPPBNFKNOC, object CGFEOLDGFLJ) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[LOEOGANCBGC(EDPDLGMLNHJ.History)]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	[DNOPHNKOHLA(typeof(PropertyChangeRouterService), new string[] { })]
	public class PropertyChangeRouterService
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public delegate void DDDKEGFLCMP(AKLFKNOOHJC EFHLICFAAGO, LDJLMGPDHCO PKCDMLNGGAD, bool LCPDIICONJD);

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public delegate void EFJOGPLPJBL(AKLFKNOOHJC EFHLICFAAGO, JBNNELNIDOD ILFNNAAOJHE, DHBMIEMIIHO OPDCHLGAPDP, DHBMIEMIIHO ONFBDMEKEAL, bool LCPDIICONJD);

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public delegate void PLGLLBFHEED(AKLFKNOOHJC EFHLICFAAGO, bool LCPDIICONJD);

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public DDDKEGFLCMP GANMJPNFBJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public EFJOGPLPJBL MFFHFGOGLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public PLGLLBFHEED NJKFKCNNMGK;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x2B03360", Offset = "0x2B01D60", VA = "0x182B03360")]
		public void LNCOMHGPOAE(AKLFKNOOHJC EFHLICFAAGO, LDJLMGPDHCO PKCDMLNGGAD, bool LCPDIICONJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x2B03380", Offset = "0x2B01D80", VA = "0x182B03380")]
		public void PEBCBPJPKKH(AKLFKNOOHJC EFHLICFAAGO, JBNNELNIDOD ILFNNAAOJHE, in DHBMIEMIIHO OPDCHLGAPDP, in DHBMIEMIIHO ONFBDMEKEAL, bool LCPDIICONJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x2B03340", Offset = "0x2B01D40", VA = "0x182B03340")]
		public void FAKDAIKDHFD(AKLFKNOOHJC EFHLICFAAGO, bool LCPDIICONJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public PropertyChangeRouterService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DebuggerTypeProxy(typeof(BOADBJAINFG))]
	[LOEOGANCBGC(EDPDLGMLNHJ.History)]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		internal class BOADBJAINFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			private readonly ActionBuffer DFIIPKJNKEL;

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public int HPEOPAJJAFB
			{
				[Cpp2IlInjected.Token(Token = "0x60003BC")]
				[Cpp2IlInjected.Address(RVA = "0x2BF6A70", Offset = "0x2BF5470", VA = "0x182BF6A70")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public PCAOILGMKIJ[] PFNIAIECPNJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0x2BF6AC0", Offset = "0x2BF54C0", VA = "0x182BF6AC0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
			public BOADBJAINFG(ActionBuffer AGILADGNGBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6980", Offset = "0x2BF5380", VA = "0x182BF6980")]
			[CompilerGenerated]
			private PCAOILGMKIJ JCOKHEPJJLN(KJBMIFDIHHB CKAPOBIDCEI)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		internal class PCAOILGMKIJ : MKGBMKAAJEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private readonly ActionBuffer DFIIPKJNKEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			private readonly KJBMIFDIHHB CKAPOBIDCEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			private List<(EOMBAJILNGH, string, object)> KJBMIMOPDKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private GFHACAOODPP ALGAFFHCPAP;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public int HPEOPAJJAFB
			{
				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0x2BFA280", Offset = "0x2BF8C80", VA = "0x182BFA280")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public List<(EOMBAJILNGH, string, object)> NPALOFKONDE
			{
				[Cpp2IlInjected.Token(Token = "0x60003C4")]
				[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x2BFA2D0", Offset = "0x2BF8CD0", VA = "0x182BFA2D0")]
			public PCAOILGMKIJ(ActionBuffer AGILADGNGBL, KJBMIFDIHHB CKAPOBIDCEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9E40", Offset = "0x2BF8840", VA = "0x182BF9E40")]
			private string FPDPEEPJPKJ(EOMBAJILNGH CLPDIBEHOBA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9F40", Offset = "0x2BF8940", VA = "0x182BF9F40")]
			private void HAKOKLHEDIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x2DD4F00", Offset = "0x2DD3900", VA = "0x182DD4F00", Slot = "4")]
			public void PDNIFDPKFPO<TKey, T>(global::DABFAGPIBGD<TKey, T> OPPPBNFKNOC, [Optional] object CGFEOLDGFLJ) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NativeList<byte> PHDLBHDMOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly Stack<KJBMIFDIHHB> OJOIGFCFHGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly FJIENBKNDOC LCBBIKIPPPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly PDDEKMBPLOK GNNMJPOKEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly MFCBDCIMKGI PDPOLFACNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly bool GBGFENMFOLI;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public LJKDLPPCHKH PKICFDONLKD
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x2DEF670", Offset = "0x2DEE070", VA = "0x182DEF670")]
			get
			{
				return default(LJKDLPPCHKH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int HPEOPAJJAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x2DEF630", Offset = "0x2DEE030", VA = "0x182DEF630")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFB60", Offset = "0x2DEE560", VA = "0x182DEFB60")]
		public ActionBuffer(PDDEKMBPLOK GNNMJPOKEFN, MFCBDCIMKGI PDPOLFACNJC, bool GBGFENMFOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF110", Offset = "0x2DEDB10", VA = "0x182DEF110")]
		public bool AKAEAFFMNIM(out KJBMIFDIHHB CKAPOBIDCEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF8B0", Offset = "0x2DEE2B0", VA = "0x182DEF8B0")]
		public void NMFIICNHENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF4F0", Offset = "0x2DEDEF0", VA = "0x182DEF4F0")]
		public KJBMIFDIHHB HHPEGPECABM(LCBGOPDINBN KJBMIMOPDKI, FKDIMDHABHE GEOLIFJDGHC, uint HJOABHDPJEH)
		{
			return default(KJBMIFDIHHB);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF0E0", Offset = "0x2DEDAE0", VA = "0x182DEF0E0")]
		public bool AIANBMMJDKI(uint HJOABHDPJEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF920", Offset = "0x2DEE320", VA = "0x182DEF920")]
		public bool OECNLAIFJIH(uint HJOABHDPJEH, out KJBMIFDIHHB JNODNCHMALF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF310", Offset = "0x2DEDD10", VA = "0x182DEF310")]
		public void DPFAPPKNFLP(KJBMIFDIHHB JNODNCHMALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF6B0", Offset = "0x2DEE0B0", VA = "0x182DEF6B0")]
		[Conditional("DEBUG_BUILD")]
		private void LPAMEOIFFBI(KJBMIFDIHHB JNODNCHMALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF1A0", Offset = "0x2DEDBA0", VA = "0x182DEF1A0")]
		private void DKNEMNEHIAL(KJBMIFDIHHB KJGNNONGCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x2DEEE60", Offset = "0x2DED860", VA = "0x182DEEE60")]
		private void AEMHPKPOICL(GFHACAOODPP PLHAKBGJDFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF2B0", Offset = "0x2DEDCB0", VA = "0x182DEF2B0")]
		private void DNIKAKEHODN(KJBMIFDIHHB CKAPOBIDCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF7F0", Offset = "0x2DEE1F0", VA = "0x182DEF7F0")]
		private GFHACAOODPP MBDMAGDOFHF(KJBMIFDIHHB CKAPOBIDCEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x2DEF480", Offset = "0x2DEDE80", VA = "0x182DEF480", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class FJIENBKNDOC : MKGBMKAAJEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly PDDEKMBPLOK GNNMJPOKEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly MFCBDCIMKGI PDPOLFACNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private AKLFKNOOHJC EFHLICFAAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private GFHACAOODPP CJGKEHMIKLM;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6C16E0", Offset = "0x6C00E0", VA = "0x1806C16E0")]
	public FJIENBKNDOC(PDDEKMBPLOK GNNMJPOKEFN, MFCBDCIMKGI PDPOLFACNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x2DAEA50", Offset = "0x2DAD450", VA = "0x182DAEA50", Slot = "4")]
	public void PDNIFDPKFPO<TKey, T>(global::DABFAGPIBGD<TKey, T> KGNAEPGCGAO, [Optional] object CGFEOLDGFLJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x2C182D0", Offset = "0x2C16CD0", VA = "0x182C182D0")]
	public void CIOHKMIJCIH(EOMBAJILNGH CLPDIBEHOBA, ref GFHACAOODPP PLHAKBGJDFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class JDANHJOFJID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public struct LFFGMJOGHFH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly JDANHJOFJID ELGBIOMPEHN;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x3FF62E0", Offset = "0x3FF4CE0", VA = "0x183FF62E0")]
		public LFFGMJOGHFH(JDANHJOFJID ELGBIOMPEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x3FF62C0", Offset = "0x3FF4CC0", VA = "0x183FF62C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	protected LCBGOPDINBN KJBMIMOPDKI;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public LCBGOPDINBN NPALOFKONDE
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C2AAD0", Offset = "0x2C294D0", VA = "0x182C2AAD0")]
		get
		{
			return default(LCBGOPDINBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool MHBJIMDDMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C2AB10", Offset = "0x2C29510", VA = "0x182C2AB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2C2AB20", Offset = "0x2C29520", VA = "0x182C2AB20")]
	public JDANHJOFJID(LCBGOPDINBN.MBDAPOBOGBM JHOLNGLBBKI = LCBGOPDINBN.MBDAPOBOGBM.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x2C2AA30", Offset = "0x2C29430", VA = "0x182C2AA30")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x2C2A940", Offset = "0x2C29340", VA = "0x182C2A940")]
	public void LNCOMHGPOAE(AKLFKNOOHJC EFHLICFAAGO, LDJLMGPDHCO PKCDMLNGGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x2C2AA40", Offset = "0x2C29440", VA = "0x182C2AA40")]
	public void PEBCBPJPKKH(AKLFKNOOHJC EFHLICFAAGO, JBNNELNIDOD ILFNNAAOJHE, in DHBMIEMIIHO ONFBDMEKEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x2C2A760", Offset = "0x2C29160", VA = "0x182C2A760")]
	public void FAKDAIKDHFD(AKLFKNOOHJC EFHLICFAAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2C2A840", Offset = "0x2C29240", VA = "0x182C2A840")]
	public void FOKLHKDGDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C2A650", Offset = "0x2C29050", VA = "0x182C2A650")]
	public void DCGEALCEIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x2C2A750", Offset = "0x2C29150", VA = "0x182C2A750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C2A620", Offset = "0x2C29020", VA = "0x182C2A620")]
	public LFFGMJOGHFH BHJCLOPNAGF()
	{
		return default(LFFGMJOGHFH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public struct EOMBAJILNGH : IComparable<EOMBAJILNGH>, IEquatable<EOMBAJILNGH>
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public static readonly EOMBAJILNGH EBOAMDEGHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public AKLFKNOOHJC EFHLICFAAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public JBNNELNIDOD ILFNNAAOJHE;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool MPANJOCJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2E087A0", Offset = "0x2E071A0", VA = "0x182E087A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6E2050", Offset = "0x6E0A50", VA = "0x1806E2050")]
	public EOMBAJILNGH(AKLFKNOOHJC EFHLICFAAGO, JBNNELNIDOD ILFNNAAOJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x2E08840", Offset = "0x2E07240", VA = "0x182E08840")]
	public void JKLFCCJKFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x2E08670", Offset = "0x2E07070", VA = "0x182E08670", Slot = "4")]
	public int CompareTo(EOMBAJILNGH DFHJPOKNFFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x2E08890", Offset = "0x2E07290", VA = "0x182E08890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E086B0", Offset = "0x2E070B0", VA = "0x182E086B0", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x2E08750", Offset = "0x2E07150", VA = "0x182E08750", Slot = "5")]
	public bool Equals(EOMBAJILNGH DFHJPOKNFFB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x2E08850", Offset = "0x2E07250", VA = "0x182E08850")]
	public static bool NENBKMMGKMN(EOMBAJILNGH CIEDPJMPBGL, EOMBAJILNGH FAJJLJONDOF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x2E087F0", Offset = "0x2E071F0", VA = "0x182E087F0")]
	public static bool HCCIHOFGPHE(EOMBAJILNGH CIEDPJMPBGL, EOMBAJILNGH FAJJLJONDOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x2E087B0", Offset = "0x2E071B0", VA = "0x182E087B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[LOEOGANCBGC(EDPDLGMLNHJ.History)]
	public class GatherPropertiesForUndelete : PGGKBIPLEDG
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private PDDEKMBPLOK GNNMJPOKEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private AKLFKNOOHJC EFHLICFAAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private HistoryService EKFKPEJHOIE;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2C1DFA0", Offset = "0x2C1C9A0", VA = "0x182C1DFA0")]
		public void JBAFBPOPDBL(AKLFKNOOHJC EFHLICFAAGO, PDDEKMBPLOK GNNMJPOKEFN, HistoryService EKFKPEJHOIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2C1E0B0", Offset = "0x2C1CAB0", VA = "0x182C1E0B0", Slot = "4")]
		private void LDDDPAAHIIM(HBMFMFPPKEB OPPPBNFKNOC, in DHBMIEMIIHO MNIAGKNOHEJ, object CGFEOLDGFLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public GatherPropertiesForUndelete()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public static class EHHOHNJPBKC
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x2E06770", Offset = "0x2E05170", VA = "0x182E06770")]
	public static void LDCKOOGOJIB(LCBGOPDINBN KJBMIMOPDKI, EOMBAJILNGH CLPDIBEHOBA, LDJLMGPDHCO PKCDMLNGGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x2E066B0", Offset = "0x2E050B0", VA = "0x182E066B0")]
	public static void JBBGOEFPOFP(LCBGOPDINBN KJBMIMOPDKI, EOMBAJILNGH CLPDIBEHOBA, in DHBMIEMIIHO ONFBDMEKEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x2E06870", Offset = "0x2E05270", VA = "0x182E06870")]
	public static void MPEALBEPEDA(LCBGOPDINBN KJBMIMOPDKI, EOMBAJILNGH CLPDIBEHOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x2E068C0", Offset = "0x2E052C0", VA = "0x182E068C0")]
	public static void OKDJECLNBFO(LCBGOPDINBN KJBMIMOPDKI, EOMBAJILNGH CLPDIBEHOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2E06610", Offset = "0x2E05010", VA = "0x182E06610")]
	public static LDJLMGPDHCO IOPBPBHMBHO(LCBGOPDINBN KJBMIMOPDKI, EOMBAJILNGH CLPDIBEHOBA)
	{
		return default(LDJLMGPDHCO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x22F8EB0", Offset = "0x22F78B0", VA = "0x1822F8EB0")]
	public static T NKDCEDPMIGF<T>(LCBGOPDINBN KJBMIMOPDKI, EOMBAJILNGH CLPDIBEHOBA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x22F8ED0", Offset = "0x22F78D0", VA = "0x1822F8ED0")]
	public static T NKDCEDPMIGF<T>(ref GFHACAOODPP NIPBPKPBPPP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2E06660", Offset = "0x2E05060", VA = "0x182E06660")]
	public static LDJLMGPDHCO IOPBPBHMBHO(ref GFHACAOODPP NIPBPKPBPPP)
	{
		return default(LDJLMGPDHCO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public struct LCBGOPDINBN : IEnumerable<EOMBAJILNGH>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum MBDAPOBOGBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private struct MKEPACCIGHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly LCBGOPDINBN OKDFPKLCDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly FKDIMDHABHE GEOLIFJDGHC;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x3FF80B0", Offset = "0x3FF6AB0", VA = "0x183FF80B0")]
		public MKEPACCIGHE(LCBGOPDINBN OKDFPKLCDDM, FKDIMDHABHE GEOLIFJDGHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x3FF77A0", Offset = "0x3FF61A0", VA = "0x183FF77A0")]
		public void EONKNEPEDMI(NativeList<byte> BODAGHDNFBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7A40", Offset = "0x3FF6440", VA = "0x183FF7A40")]
		private void JGKLNAEBLEM(EOMBAJILNGH CLPDIBEHOBA, ref NJMLAEBAMGF MKANKBGBEKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7F30", Offset = "0x3FF6930", VA = "0x183FF7F30")]
		private void PCNCDABCADA(EOMBAJILNGH CLPDIBEHOBA, ref NJMLAEBAMGF MKANKBGBEKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7A90", Offset = "0x3FF6490", VA = "0x183FF7A90")]
		private NativeArray<byte> JMALKIANGAK(NativeList<byte> BODAGHDNFBD)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7FC0", Offset = "0x3FF69C0", VA = "0x183FF7FC0")]
		private NativeArray<byte> PGIKBDKPLMD(NativeList<byte> BODAGHDNFBD, int KHNOOLPHJPF)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7CE0", Offset = "0x3FF66E0", VA = "0x183FF7CE0")]
		private int OHPHBHDHPPB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7B80", Offset = "0x3FF6580", VA = "0x183FF7B80")]
		private bool OCECPCEILJC(EOMBAJILNGH CLPDIBEHOBA, out NativeArray<byte> GOIIGBJAMGN)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct BBIECNNPIAO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private NativeList<byte> NIPBPKPBPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private LCBGOPDINBN OKDFPKLCDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly EOMBAJILNGH MMPIIAHIKHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly int AGNHLFMCFOJ;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF480", Offset = "0x3FEDE80", VA = "0x183FEF480")]
		internal BBIECNNPIAO(LCBGOPDINBN OKDFPKLCDDM, EOMBAJILNGH MMPIIAHIKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF260", Offset = "0x3FEDC60", VA = "0x183FEF260", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF360", Offset = "0x3FEDD60", VA = "0x183FEF360")]
		public void MAJLKAOFNCK(NativeArray<byte> MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF200", Offset = "0x3FEDC00", VA = "0x183FEF200")]
		public void CFNLCAMMEMC(NativeArray<byte> MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF470", Offset = "0x3FEDE70", VA = "0x183FEF470")]
		public void PCNCDABCADA(in DHBMIEMIIHO MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x343D760", Offset = "0x343C160", VA = "0x18343D760")]
		public void PCNCDABCADA<T>(T MNIAGKNOHEJ) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF2F0", Offset = "0x3FEDCF0", VA = "0x183FEF2F0")]
		private void GKDAJDIKJCK(int MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF3C0", Offset = "0x3FEDDC0", VA = "0x183FEF3C0")]
		private void GKDAJDIKJCK(in DHBMIEMIIHO MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF290", Offset = "0x3FEDC90", VA = "0x183FEF290")]
		private unsafe void GKDAJDIKJCK(void* ECOGPKHHOLF, int KHNOOLPHJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF360", Offset = "0x3FEDD60", VA = "0x183FEF360")]
		private void GKDAJDIKJCK(NativeArray<byte> APKDOIJAGNF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct LFGDIDHHLAJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private LCBGOPDINBN OKDFPKLCDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private NativeArray<byte> NIPBPKPBPPP;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x3FF65D0", Offset = "0x3FF4FD0", VA = "0x183FF65D0")]
		internal LFGDIDHHLAJ(LCBGOPDINBN OKDFPKLCDDM, NativeArray<byte> NIPBPKPBPPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6310", Offset = "0x3FF4D10", VA = "0x183FF6310", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6320", Offset = "0x3FF4D20", VA = "0x183FF6320")]
		public NativeArray<byte> EMBBDOEDIKJ(int KHNOOLPHJPF)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x3FF63E0", Offset = "0x3FF4DE0", VA = "0x183FF63E0")]
		public NativeArray<byte> GGMPDILEFEJ()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x3454830", Offset = "0x3453230", VA = "0x183454830")]
		public T KAKOKJEJFGF<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x3FF64D0", Offset = "0x3FF4ED0", VA = "0x183FF64D0")]
		public void KAKOKJEJFGF(in BOPFHHNILGH MNIAGKNOHEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public struct MIDNJKDOLHE : IEnumerator<EOMBAJILNGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly NativeList<EOMBAJILNGH> GNPHBMKMMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private int GFDMFLGCBKB;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public EOMBAJILNGH PKICFDONLKD
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x3FF7750", Offset = "0x3FF6150", VA = "0x183FF7750", Slot = "4")]
			get
			{
				return default(EOMBAJILNGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF7710", Offset = "0x3FF6110", VA = "0x183FF7710", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x30DD8C0", Offset = "0x30DC2C0", VA = "0x1830DD8C0")]
		internal MIDNJKDOLHE(NativeList<EOMBAJILNGH> APKDOIJAGNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x3FF75D0", Offset = "0x3FF5FD0", VA = "0x183FF75D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x3FF76D0", Offset = "0x3FF60D0", VA = "0x183FF76D0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct EBGOIAPEOAK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private const int JMCEFCHIJEH = 0;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private const int OOKMNLHKCLI = 1;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private const int GCNHONAJKLF = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private NativeArray<int> NIPBPKPBPPP;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool NJLNECGPIBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0B60", Offset = "0x3FEF560", VA = "0x183FF0B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public int IFCHJGCAMMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0BD0", Offset = "0x3FEF5D0", VA = "0x183FF0BD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0B10", Offset = "0x3FEF510", VA = "0x183FF0B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public MBDAPOBOGBM PKEBDCAJCAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0C20", Offset = "0x3FEF620", VA = "0x183FF0C20")]
			get
			{
				return default(MBDAPOBOGBM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0B00", Offset = "0x3FEF500", VA = "0x183FF0B00")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool MHBJIMDDMAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0C30", Offset = "0x3FEF630", VA = "0x183FF0C30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0AE0", Offset = "0x3FEF4E0", VA = "0x183FF0AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool CPMNEOAAFFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0BC0", Offset = "0x3FEF5C0", VA = "0x183FF0BC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0BA0", Offset = "0x3FEF5A0", VA = "0x183FF0BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0C40", Offset = "0x3FEF640", VA = "0x183FF0C40")]
		public EBGOIAPEOAK(MBDAPOBOGBM JHOLNGLBBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0AB0", Offset = "0x3FEF4B0", VA = "0x183FF0AB0")]
		private int AGGAFJIIBKL(int JFKBHBKKACD, int NAPOJPPGEMB = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0BE0", Offset = "0x3FEF5E0", VA = "0x183FF0BE0")]
		private void NLANNFAIKGA(int JFKBHBKKACD, int MNIAGKNOHEJ, int NAPOJPPGEMB = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x3FF0B20", Offset = "0x3FEF520", VA = "0x183FF0B20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private const int OMDOMCHKDKB = -1;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private const int AAOGPINLJPG = 0;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly EOMBAJILNGH JKJBPLFLEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeHashMap<EOMBAJILNGH, int> MDBFCMCEBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private NativeList<EOMBAJILNGH> KJBMIMOPDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private NativeList<int> AIDEFCDNADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private NativeList<byte> LACNIPLHLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private NativeList<byte> NIPBPKPBPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private EBGOIAPEOAK HKHEDELGBLL;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool MHBJIMDDMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x2C30200", Offset = "0x2C2EC00", VA = "0x182C30200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool JCJLAAEODFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C2FFE0", Offset = "0x2C2E9E0", VA = "0x182C2FFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int IFCHJGCAMMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C30000", Offset = "0x2C2EA00", VA = "0x182C30000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int POIAOLEJCGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C2FB60", Offset = "0x2C2E560", VA = "0x182C2FB60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool NJLNECGPIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C2FB20", Offset = "0x2C2E520", VA = "0x182C2FB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C2FBA0", Offset = "0x2C2E5A0", VA = "0x182C2FBA0")]
	public static LCBGOPDINBN GANMJPNFBJN(MBDAPOBOGBM JHOLNGLBBKI = MBDAPOBOGBM.Last, int PFLMFBNNMFN = 16, int GBIDONFBGPL = 256)
	{
		return default(LCBGOPDINBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C30400", Offset = "0x2C2EE00", VA = "0x182C30400")]
	private LCBGOPDINBN(MBDAPOBOGBM JHOLNGLBBKI, int PFLMFBNNMFN, int GBIDONFBGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C2FA40", Offset = "0x2C2E440", VA = "0x182C2FA40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C2FC70", Offset = "0x2C2E670", VA = "0x182C2FC70")]
	public BBIECNNPIAO JKEHJDDFHGN(EOMBAJILNGH MMPIIAHIKHE)
	{
		return default(BBIECNNPIAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x2C2FBE0", Offset = "0x2C2E5E0", VA = "0x182C2FBE0")]
	public LFGDIDHHLAJ HHCBCNBFAFC(EOMBAJILNGH MMPIIAHIKHE)
	{
		return default(LFGDIDHHLAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F760", Offset = "0x2C2E160", VA = "0x182C2F760")]
	public bool BPLDNAEHOED(EOMBAJILNGH MMPIIAHIKHE, out LFGDIDHHLAJ KGLBMDPKPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F710", Offset = "0x2C2E110", VA = "0x182C2F710")]
	public bool ANGCILOIHNP(EOMBAJILNGH MMPIIAHIKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C300F0", Offset = "0x2C2EAF0", VA = "0x182C300F0")]
	public bool OAMBEDMLOPE(EOMBAJILNGH MMPIIAHIKHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x2C30210", Offset = "0x2C2EC10", VA = "0x182C30210")]
	public void PNPADMJHIFL(NativeList<byte> BODAGHDNFBD, FKDIMDHABHE GEOLIFJDGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x25D92F0", Offset = "0x25D7CF0", VA = "0x1825D92F0")]
	public T LEJAKIOEKDC<T>(EOMBAJILNGH MMPIIAHIKHE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x2C30010", Offset = "0x2C2EA10", VA = "0x182C30010")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x2C301C0", Offset = "0x2C2EBC0", VA = "0x182C301C0")]
	public MIDNJKDOLHE OGILHMGHFKK()
	{
		return default(MIDNJKDOLHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x2C2FDF0", Offset = "0x2C2E7F0", VA = "0x182C2FDF0")]
	private void KBGDHEFHOOC(EOMBAJILNGH MMPIIAHIKHE, int AGNHLFMCFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C2FD00", Offset = "0x2C2E700", VA = "0x182C2FD00")]
	private void JKLFCCJKFNG(int HFCCOEPLJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F950", Offset = "0x2C2E350", VA = "0x182C2F950")]
	private void CKJDIPMLELH(EOMBAJILNGH MMPIIAHIKHE, int AGNHLFMCFOJ, int KHNOOLPHJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x25D9270", Offset = "0x25D7C70", VA = "0x1825D9270")]
	private static T LEJAKIOEKDC<T>(NativeArray<byte> GNPHBMKMMCM, int JFKBHBKKACD = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x2C30340", Offset = "0x2C2ED40", VA = "0x182C30340", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x2C30300", Offset = "0x2C2ED00", VA = "0x182C30300", Slot = "4")]
	private IEnumerator<EOMBAJILNGH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Preserve]
internal sealed class OGHNCEOBPGF<T> : FOMCGHGDFHL where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private EntityQuery CAMLCFELNDE;

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x2EACAC0", Offset = "0x2EAB4C0", VA = "0x182EACAC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x2EACB50", Offset = "0x2EAB550", VA = "0x182EACB50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x2EACBC0", Offset = "0x2EAB5C0", VA = "0x182EACBC0")]
	public OGHNCEOBPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x17A91C0", Offset = "0x17A7BC0", VA = "0x1817A91C0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	internal class CleanupRigidbodyExImpl : FOMCGHGDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private EntityQuery CAMLCFELNDE;

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6A50", Offset = "0x2DF5450", VA = "0x182DF6A50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6AF0", Offset = "0x2DF54F0", VA = "0x182DF6AF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public CleanupRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[Preserve]
internal class DHGBNEABHCF : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private EntityQuery DJCIKLPKEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2E02D00", Offset = "0x2E01700", VA = "0x182E02D00", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2E02D50", Offset = "0x2E01750", VA = "0x182E02D50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2E02DE0", Offset = "0x2E017E0", VA = "0x182E02DE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public DHGBNEABHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
internal class LHOCHBDBKGM : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private PropertyDiffStateService BFNKEPJCMJM;

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x2C32770", Offset = "0x2C31170", VA = "0x182C32770", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2C327C0", Offset = "0x2C311C0", VA = "0x182C327C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public LHOCHBDBKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	internal class DisposeAboutToBeDestroyedRigidbodyExImpl : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private EntityQuery CAMLCFELNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private SceneService OOKLBGAMMBI;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2E04CC0", Offset = "0x2E036C0", VA = "0x182E04CC0", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2E04D10", Offset = "0x2E03710", VA = "0x182E04D10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x2E04DA0", Offset = "0x2E037A0", VA = "0x182E04DA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public DisposeAboutToBeDestroyedRigidbodyExImpl()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
	[DNOPHNKOHLA(typeof(CullingBandService), new string[] { })]
	public class CullingBandService : MMKNGEFLOAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly List<NativeListAsync<KLEFKDIFLJN>> CDMMCLCBLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN ALIKEONHNHI;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2E00060", Offset = "0x2DFEA60", VA = "0x182E00060", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2E000B0", Offset = "0x2DFEAB0", VA = "0x182E000B0")]
		public void MAKOAMGIDMJ(NativeListAsync<KLEFKDIFLJN> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFBF0", Offset = "0x2DFE5F0", VA = "0x182DFFBF0")]
		public void EGEBGMAAEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFFA80", Offset = "0x2DFE480", VA = "0x182DFFA80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2E00170", Offset = "0x2DFEB70", VA = "0x182E00170")]
		public CullingBandService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[DNOPHNKOHLA(typeof(MNMIJEOGALA), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	public class PhysicsService : MMKNGEFLOAO, PKBAIAJJFPF, MNMIJEOGALA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly KGOHPJFJCLE OEOMMNNMKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private EntityManager BJMEFCCEPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private DEAGKEFEBKN HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private FEKPIDGPAOL BEJILFMCOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private PropertyEventCallbacksService BDLNKGOJBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private global::BBFFFGFDPOL<LJOEKOFPECD> ALEPJHGLNGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action<DFKOJFHJBPL, LJOEKOFPECD> FCDDPDJBKEP
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x2B00000", Offset = "0x2AFEA00", VA = "0x182B00000", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x2AFFCB0", Offset = "0x2AFE6B0", VA = "0x182AFFCB0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFD50", Offset = "0x2AFE750", VA = "0x182AFFD50", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF950", Offset = "0x2AFE350", VA = "0x182AFF950", Slot = "5")]
		public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF7F0", Offset = "0x2AFE1F0", VA = "0x182AFF7F0", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFE70", Offset = "0x2AFE870", VA = "0x182AFFE70", Slot = "8")]
		public bool HIKPOGCHOCE(DFKOJFHJBPL PMMCMCPNCLD, out Collider FGPOCJNLNLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFF40", Offset = "0x2AFE940", VA = "0x182AFFF40")]
		private void NGLLNIFECJD(Entity GOANOLJBHPF, JBNNELNIDOD ILFNNAAOJHE, DHBMIEMIIHO HKLCHIBFNAM, DHBMIEMIIHO APGCALANEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFBF0", Offset = "0x2AFE5F0", VA = "0x182AFFBF0", Slot = "9")]
		public void FKBKOAAHGLL(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public PhysicsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	[DNOPHNKOHLA(typeof(GHMLCJKOGGN), new string[] { })]
	public class RbexService : MMKNGEFLOAO, GHMLCJKOGGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private DEAGKEFEBKN ALIKEONHNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private World HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private ABOINJIGLHC LOIBKFNKCGM;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private EntityManager FLHDGCEBOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x2B06570", Offset = "0x2B04F70", VA = "0x182B06570")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2B064C0", Offset = "0x2B04EC0", VA = "0x182B064C0", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2B07EB0", Offset = "0x2B068B0", VA = "0x182B07EB0", Slot = "6")]
		public AJLHDLPKFOJ OJNLFBAEICK(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x2B05E50", Offset = "0x2B04850", VA = "0x182B05E50", Slot = "5")]
		public void EJLPFLNDBAA(DFKOJFHJBPL PMMCMCPNCLD, AJLHDLPKFOJ MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2B05B50", Offset = "0x2B04550", VA = "0x182B05B50", Slot = "34")]
		public CollisionDetectionMode DKEHNMAKBMN(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(CollisionDetectionMode);
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2B06E10", Offset = "0x2B05810", VA = "0x182B06E10", Slot = "35")]
		public void KAMEEIPFMAB(DFKOJFHJBPL PMMCMCPNCLD, CollisionDetectionMode MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2B07CB0", Offset = "0x2B066B0", VA = "0x182B07CB0", Slot = "36")]
		public FHGIMEJNAKL OGJONGFNFMK(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(FHGIMEJNAKL);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2B06610", Offset = "0x2B05010", VA = "0x182B06610", Slot = "37")]
		public void HMCDILOIAIL(DFKOJFHJBPL PMMCMCPNCLD, FHGIMEJNAKL MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2B06B90", Offset = "0x2B05590", VA = "0x182B06B90", Slot = "38")]
		public bool JHHPIFOEOLL(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2B07C40", Offset = "0x2B06640", VA = "0x182B07C40", Slot = "39")]
		public void OFAPPAFLAMC(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2B05BB0", Offset = "0x2B045B0", VA = "0x182B05BB0", Slot = "40")]
		public DFKOJFHJBPL EDPENGKDDJF(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B03BF0", VA = "0x182B051F0", Slot = "41")]
		public void AHFAOJLGMLP(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2B05930", Offset = "0x2B04330", VA = "0x182B05930", Slot = "42")]
		public DFKOJFHJBPL CBCDGOOOFFP(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2B05AD0", Offset = "0x2B044D0", VA = "0x182B05AD0", Slot = "43")]
		public void DGJAMCMEJGD(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2B06710", Offset = "0x2B05110", VA = "0x182B06710", Slot = "7")]
		public void IBAFGGCIFCB(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x2B08020", Offset = "0x2B06A20", VA = "0x182B08020", Slot = "8")]
		public void ONHPMCGNOEF(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x2B079D0", Offset = "0x2B063D0", VA = "0x182B079D0", Slot = "9")]
		public int NLFFKMDNFBA(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x2B06CF0", Offset = "0x2B056F0", VA = "0x182B06CF0", Slot = "10")]
		public DFKOJFHJBPL KADGDGJNBPA(DFKOJFHJBPL PMMCMCPNCLD, int GFDMFLGCBKB)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x2B07860", Offset = "0x2B06260", VA = "0x182B07860", Slot = "11")]
		public void MMHPOHCMKNI(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2B052E0", Offset = "0x2B03CE0", VA = "0x182B052E0", Slot = "12")]
		public void BDBCJIDBAKL(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD, DFKOJFHJBPL MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2B06180", Offset = "0x2B04B80", VA = "0x182B06180", Slot = "13")]
		public void FPAMLDLBGAM(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2B06360", Offset = "0x2B04D60", VA = "0x182B06360", Slot = "14")]
		public bool GIOPNDLOMAB(DFKOJFHJBPL PMMCMCPNCLD, out DFKOJFHJBPL MNIAGKNOHEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x2B08190", Offset = "0x2B06B90", VA = "0x182B08190", Slot = "15")]
		public void OOOCFMLLNCA(DFKOJFHJBPL PMMCMCPNCLD, float3 MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x2B07380", Offset = "0x2B05D80", VA = "0x182B07380", Slot = "16")]
		public bool LPLCBIHMCDE(DFKOJFHJBPL PMMCMCPNCLD, out float3 MNIAGKNOHEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2B07950", Offset = "0x2B06350", VA = "0x182B07950", Slot = "17")]
		public void NAEAPNJPOFC(DFKOJFHJBPL PMMCMCPNCLD, float3 MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2B057D0", Offset = "0x2B041D0", VA = "0x182B057D0", Slot = "18")]
		public bool CANGNKNIGIB(DFKOJFHJBPL PMMCMCPNCLD, out float3 MNIAGKNOHEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2B074E0", Offset = "0x2B05EE0", VA = "0x182B074E0", Slot = "26")]
		public float3 MAPFGENNBGE(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2B070C0", Offset = "0x2B05AC0", VA = "0x182B070C0", Slot = "27")]
		public void KLHFKODODKK(DFKOJFHJBPL PMMCMCPNCLD, float3 MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2B05F90", Offset = "0x2B04990", VA = "0x182B05F90", Slot = "28")]
		public float ENODHFLJJJH(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2B07BD0", Offset = "0x2B065D0", VA = "0x182B07BD0", Slot = "29")]
		public void OFALDBALNCH(DFKOJFHJBPL PMMCMCPNCLD, float MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2B06A70", Offset = "0x2B05470", VA = "0x182B06A70", Slot = "30")]
		public float IPAFIJDAGND(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2B07310", Offset = "0x2B05D10", VA = "0x182B07310", Slot = "31")]
		public void LOAMHNJDNGE(DFKOJFHJBPL PMMCMCPNCLD, float MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2B05C30", Offset = "0x2B04630", VA = "0x182B05C30", Slot = "32")]
		public bool EEGFPLAGGBB(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2B06F80", Offset = "0x2B05980", VA = "0x182B06F80", Slot = "33")]
		public void KGIPKAJKCEE(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2B06590", Offset = "0x2B04F90", VA = "0x182B06590", Slot = "19")]
		public void GLJHHGNCMIP(DFKOJFHJBPL PMMCMCPNCLD, float3 MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2B07D50", Offset = "0x2B06750", VA = "0x182B07D50", Slot = "20")]
		public bool OHCDCFEMMHN(DFKOJFHJBPL PMMCMCPNCLD, out float3 MNIAGKNOHEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2B07140", Offset = "0x2B05B40", VA = "0x182B07140", Slot = "21")]
		public void KNPPMCFEHLG(DFKOJFHJBPL PMMCMCPNCLD, quaternion MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2B05410", Offset = "0x2B03E10", VA = "0x182B05410", Slot = "22")]
		public bool BHHMAONJEBM(DFKOJFHJBPL PMMCMCPNCLD, out quaternion MNIAGKNOHEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2B07560", Offset = "0x2B05F60", VA = "0x182B07560", Slot = "23")]
		public bool MHHFPFAJBHJ(DFKOJFHJBPL PMMCMCPNCLD, out float3 COEKEIABEDK, out quaternion LEBLACCFLIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2B07220", Offset = "0x2B05C20", VA = "0x182B07220", Slot = "44")]
		public IHGNHGBDMIK LKCOGGMBFPM(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(IHGNHGBDMIK);
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2B05570", Offset = "0x2B03F70", VA = "0x182B05570", Slot = "45")]
		public void BHJELIPHEFA(DFKOJFHJBPL PMMCMCPNCLD, IHGNHGBDMIK MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2B08350", Offset = "0x2B06D50", VA = "0x182B08350", Slot = "72")]
		public void PLGMLLNHEEC(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x2B06080", Offset = "0x2B04A80", VA = "0x182B06080", Slot = "73")]
		public void FIHFGPAAHAA(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2B06F00", Offset = "0x2B05900", VA = "0x182B06F00", Slot = "74")]
		public bool KDCCDPDAHLO(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2B05A40", Offset = "0x2B04440", VA = "0x182B05A40", Slot = "81")]
		public void COHPBIMGGHJ(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x2B05FF0", Offset = "0x2B049F0", VA = "0x182B05FF0", Slot = "82")]
		public void EOGDKCBFICD(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x2B05170", Offset = "0x2B03B70", VA = "0x182B05170", Slot = "83")]
		public bool AHBPCAGBENM(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x2B083E0", Offset = "0x2B06DE0", VA = "0x182B083E0", Slot = "84")]
		public IEnumerable<object> POBHMGBPEOP(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x2B06A10", Offset = "0x2B05410", VA = "0x182B06A10", Slot = "46")]
		public bool IOKECMIFPJO(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x2B07AF0", Offset = "0x2B064F0", VA = "0x182B07AF0", Slot = "47")]
		public void OEKMAFIIPNC(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x2B082F0", Offset = "0x2B06CF0", VA = "0x182B082F0", Slot = "48")]
		public bool PJMDLLFDBGG(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x2B08280", Offset = "0x2B06C80", VA = "0x182B08280", Slot = "49")]
		public void PBLFACHHCDF(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x2B06B30", Offset = "0x2B05530", VA = "0x182B06B30", Slot = "50")]
		public bool JAHIJMPPKHP(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2B06110", Offset = "0x2B04B10", VA = "0x182B06110", Slot = "51")]
		public void FNGDFNGLCKH(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2B06AD0", Offset = "0x2B054D0", VA = "0x182B06AD0", Slot = "52")]
		public RigidbodyConstraints IPPKINOEALC(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(RigidbodyConstraints);
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2B07FB0", Offset = "0x2B069B0", VA = "0x182B07FB0", Slot = "53")]
		public void OKNFIEIGOLN(DFKOJFHJBPL PMMCMCPNCLD, RigidbodyConstraints MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2B050B0", Offset = "0x2B03AB0", VA = "0x182B050B0", Slot = "54")]
		public float ACGHHLKHFGF(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2B071B0", Offset = "0x2B05BB0", VA = "0x182B071B0", Slot = "55")]
		public void KPLKGDIDEDC(DFKOJFHJBPL PMMCMCPNCLD, float MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x2B06210", Offset = "0x2B04C10", VA = "0x182B06210", Slot = "56")]
		public float GDNNBMJHCPA(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x2B06BF0", Offset = "0x2B055F0", VA = "0x182B06BF0", Slot = "57")]
		public void JKBLDOMNELK(DFKOJFHJBPL PMMCMCPNCLD, float MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2B066B0", Offset = "0x2B050B0", VA = "0x182B066B0", Slot = "58")]
		public bool HPKGGMLANHC(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2B05270", Offset = "0x2B03C70", VA = "0x182B05270", Slot = "59")]
		public void AKNPAHDPKHC(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2B06270", Offset = "0x2B04C70", VA = "0x182B06270", Slot = "60")]
		public bool GDPDEMPDMDC(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x2B084E0", Offset = "0x2B06EE0", VA = "0x182B084E0", Slot = "61")]
		public void PPFGLDEDDMJ(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2B05110", Offset = "0x2B03B10", VA = "0x182B05110", Slot = "62")]
		public int ADHOHDPMKLA(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2B08210", Offset = "0x2B06C10", VA = "0x182B08210", Slot = "63")]
		public void OPFNLFMFAMO(DFKOJFHJBPL PMMCMCPNCLD, int MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2B062D0", Offset = "0x2B04CD0", VA = "0x182B062D0", Slot = "64")]
		public Rigidbody GIGCCLLKFPJ(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2B05C90", Offset = "0x2B04690", VA = "0x182B05C90", Slot = "65")]
		public void EFMPBCOLNJE(DFKOJFHJBPL PMMCMCPNCLD, Rigidbody MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2B06C60", Offset = "0x2B05660", VA = "0x182B06C60", Slot = "75")]
		public void JLJBLNPMNBL(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x2B055E0", Offset = "0x2B03FE0", VA = "0x182B055E0", Slot = "76")]
		public void BLBMOHDCAEI(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2B06E80", Offset = "0x2B05880", VA = "0x182B06E80", Slot = "77")]
		public bool KCAMJICICMP(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x2B07280", Offset = "0x2B05C80", VA = "0x182B07280", Slot = "66")]
		public object LNNHDIFPPEI(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x2B05670", Offset = "0x2B04070", VA = "0x182B05670", Slot = "67")]
		public void BLOOOPDAFCN(DFKOJFHJBPL PMMCMCPNCLD, object MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2B05F00", Offset = "0x2B04900", VA = "0x182B05F00", Slot = "68")]
		public object EKDCDCCBCMO(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x2B068B0", Offset = "0x2B052B0", VA = "0x182B068B0", Slot = "69")]
		public void IOJKJPLIKPC(DFKOJFHJBPL PMMCMCPNCLD, object MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2B05DF0", Offset = "0x2B047F0", VA = "0x182B05DF0", Slot = "70")]
		public float EGFBANNMNBE(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x2B07F40", Offset = "0x2B06940", VA = "0x182B07F40", Slot = "71")]
		public void OKNAAJMEFPA(DFKOJFHJBPL PMMCMCPNCLD, float MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2B077D0", Offset = "0x2B061D0", VA = "0x182B077D0", Slot = "78")]
		public void MHNCHAHDOAL(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2B06820", Offset = "0x2B05220", VA = "0x182B06820", Slot = "79")]
		public void IDGEAMHIIOJ(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B07B50", Offset = "0x2B06550", VA = "0x182B07B50", Slot = "80")]
		public bool OELPHIMKEME(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B059E0", Offset = "0x2B043E0", VA = "0x182B059E0", Slot = "24")]
		public void CLDGNHJJLOF(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B08130", Offset = "0x2B06B30", VA = "0x182B08130", Slot = "25")]
		public void ONKHPDLIBFO(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x4518A70", Offset = "0x4517470", VA = "0x184518A70")]
		private void LLHKCKGAGKB<T>(DFKOJFHJBPL PMMCMCPNCLD, bool MNIAGKNOHEJ) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x4518B20", Offset = "0x4517520", VA = "0x184518B20")]
		private bool NKLFNAEJLDD<T>(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x4518B80", Offset = "0x4517580", VA = "0x184518B80")]
		private void OLCIACFECIH<T>(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x4517E40", Offset = "0x4516840", VA = "0x184517E40")]
		private bool JEPCCBDPJCF<TC, TV>(DFKOJFHJBPL PMMCMCPNCLD, Func<TC, TV> FMGENDBPDEG, out TV MNIAGKNOHEJ) where TC : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x4517700", Offset = "0x4516100", VA = "0x184517700")]
		private bool JEPCCBDPJCF<T>(DFKOJFHJBPL PMMCMCPNCLD, out T MNIAGKNOHEJ) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x4518620", Offset = "0x4517020", VA = "0x184518620")]
		private T LBEBDNPKBGI<T>(DFKOJFHJBPL PMMCMCPNCLD) where T : struct, IComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x4517780", Offset = "0x4516180", VA = "0x184517780")]
		private void DENKOLJGECH<T>(DFKOJFHJBPL PMMCMCPNCLD, T MNIAGKNOHEJ) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x4517FC0", Offset = "0x45169C0", VA = "0x184517FC0")]
		private void JKOAOALLMEA<T>(DFKOJFHJBPL PMMCMCPNCLD, T MNIAGKNOHEJ) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x4517700", Offset = "0x4516100", VA = "0x184517700")]
		private bool AJIKLCBGOKH<T>(DFKOJFHJBPL PMMCMCPNCLD, out T MNIAGKNOHEJ) where T : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x4518AC0", Offset = "0x45174C0", VA = "0x184518AC0")]
		private T LONIJAOKMEO<T>(DFKOJFHJBPL PMMCMCPNCLD) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x4517700", Offset = "0x4516100", VA = "0x184517700")]
		private void NGAOFLBOKHA<T>(DFKOJFHJBPL PMMCMCPNCLD, T MNIAGKNOHEJ) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x4517CD0", Offset = "0x45166D0", VA = "0x184517CD0")]
		private void HNMDDPLCHLC<T>(DFKOJFHJBPL PMMCMCPNCLD, T MNIAGKNOHEJ) where T : class
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B07AC0", Offset = "0x2B064C0", VA = "0x182B07AC0")]
		private DFKOJFHJBPL NLFFOFOKMLB(Entity GOANOLJBHPF)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x2B06FF0", Offset = "0x2B059F0", VA = "0x182B06FF0")]
		private DynamicBuffer<Entity> KHMJGOAPAKJ(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(DynamicBuffer<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x4517D80", Offset = "0x4516780", VA = "0x184517D80")]
		private void JEJLFIOHOGP<T>(DFKOJFHJBPL PMMCMCPNCLD, object MNIAGKNOHEJ, Func<object, T> FMGENDBPDEG) where T : class, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		private void HAKOKLHEDIO<T>(ref global::MMCBEEPMOEL<T> GLOEEIEEKAA) where T : struct, IMOHFLKNJIO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		private void HAKOKLHEDIO<TC, TV>(ref global::GBCMHMFPJGH<TC, TV> GLOEEIEEKAA) where TC : struct, IMOHFLKNJIO
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public RbexService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
	[DNOPHNKOHLA(typeof(KinematicSleepChangeService), new string[] { })]
	public class KinematicSleepChangeService : MMKNGEFLOAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class PHNICNKCFDK : IEnumerable<AJLHDLPKFOJ>, IEnumerable, IEnumerator<AJLHDLPKFOJ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private AJLHDLPKFOJ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public KinematicSleepChangeService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			private NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public NativeArray<Entity> <>3__entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private EntityManager <entityManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x170000A4")]
			private AJLHDLPKFOJ System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D2")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A5")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60004D4")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
			[DebuggerHidden]
			public PHNICNKCFDK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x3FFA0A0", Offset = "0x3FF8AA0", VA = "0x183FFA0A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x3FF9D60", Offset = "0x3FF8760", VA = "0x183FF9D60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0x3FFA120", Offset = "0x3FF8B20", VA = "0x183FFA120")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x3FFA060", Offset = "0x3FF8A60", VA = "0x183FFA060", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D5")]
			[Cpp2IlInjected.Address(RVA = "0x3FF9FB0", Offset = "0x3FF89B0", VA = "0x183FF9FB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<AJLHDLPKFOJ> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60004D6")]
			[Cpp2IlInjected.Address(RVA = "0x3FF9FB0", Offset = "0x3FF89B0", VA = "0x183FF9FB0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> JFFEENFHOHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN ALIKEONHNHI;

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x2C2DB70", Offset = "0x2C2C570", VA = "0x182C2DB70", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x2C2E410", Offset = "0x2C2CE10", VA = "0x182C2E410")]
		public void MAKOAMGIDMJ(NativeArray<Entity> CGCCIONMJJA, bool OCPGNFCELHN, bool GINPOJPPJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x2C2D960", Offset = "0x2C2C360", VA = "0x182C2D960")]
		public void EGEBGMAAEHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C2DBC0", Offset = "0x2C2C5C0", VA = "0x182C2DBC0")]
		private void IHLLEEAOBAM(NativeArray<Entity> CGCCIONMJJA, bool OCPGNFCELHN, bool GINPOJPPJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C2E380", Offset = "0x2C2CD80", VA = "0x182C2E380")]
		[IteratorStateMachine(typeof(PHNICNKCFDK))]
		private IEnumerable<AJLHDLPKFOJ> KIPJFOKOJOE(NativeArray<Entity> CGCCIONMJJA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C2D810", Offset = "0x2C2C210", VA = "0x182C2D810", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C2E580", Offset = "0x2C2CF80", VA = "0x182C2E580")]
		public KinematicSleepChangeService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
[DNOPHNKOHLA(typeof(BPDJHFAPEAG), new string[] { })]
public class OEBILBAGEIK : BPDJHFAPEAG, IEnumerable<FBPCPDKHEOJ>, IEnumerable, EBFNJADEFGO, IPCGJDFHGJG, MMKNGEFLOAO, PKBAIAJJFPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[JIFPDEDMPGC]
	private BCEHDKHLBBB PDPOLFACNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly Dictionary<(Type, string), int> DKAGJCMHGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private OOENDMBBEKK OPIKAFFOFCL;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x2AEAB20", Offset = "0x2AE9520", VA = "0x182AEAB20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public FBPCPDKHEOJ NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA460", Offset = "0x2AE8E60", VA = "0x182AEA460", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public FBPCPDKHEOJ NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x2AEA460", Offset = "0x2AE8E60", VA = "0x182AEA460", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA480", Offset = "0x2AE8E80", VA = "0x182AEA480", Slot = "11")]
	public void BEJHKBIOAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAA80", Offset = "0x2AE9480", VA = "0x182AEAA80", Slot = "12")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "13")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA4D0", Offset = "0x2AE8ED0", VA = "0x182AEA4D0")]
	private void ENOIHKGBDPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x24DC340", Offset = "0x24DAD40", VA = "0x1824DC340")]
	private string FGJONOCEDPC(string ANJJEPIBAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA380", Offset = "0x2AE8D80", VA = "0x182AEA380", Slot = "7")]
	public FBPCPDKHEOJ BBNMBMIAFFD(GFANKPDBBJN IJEJFFCLBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AEA7D0", Offset = "0x2AE91D0", VA = "0x182AEA7D0")]
	private bool FGJHMDIHDOG(Type IGMAFPJOAIE, string ANJJEPIBAGI, out FBPCPDKHEOJ ALMPKNLFFLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAB40", Offset = "0x2AE9540", VA = "0x182AEAB40", Slot = "8")]
	public JBNNELNIDOD MFJEOJEBIAI(GFANKPDBBJN IJEJFFCLBDM)
	{
		return default(JBNNELNIDOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAB00", Offset = "0x2AE9500", VA = "0x182AEAB00", Slot = "9")]
	public IEnumerator<FBPCPDKHEOJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAB00", Offset = "0x2AE9500", VA = "0x182AEAB00", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2AEAC50", Offset = "0x2AE9650", VA = "0x182AEAC50")]
	public OEBILBAGEIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
[DefaultMember("Item")]
public interface FKDIMDHABHE
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AHNKPJNGOAC(JBNNELNIDOD OGGLMCNMCLJ, out int HGBOOPNCHBL);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
[DNOPHNKOHLA(typeof(FKDIMDHABHE), new string[] { })]
public class DIEKOFKOONN : MMKNGEFLOAO, PKBAIAJJFPF, FKDIMDHABHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	[JIFPDEDMPGC]
	private MFCBDCIMKGI PDPOLFACNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly Dictionary<JBNNELNIDOD, int> NFFOLJFDMBD;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public int NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x2E037A0", Offset = "0x2E021A0", VA = "0x182E037A0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2E03730", Offset = "0x2E02130", VA = "0x182E03730", Slot = "6")]
	public bool AHNKPJNGOAC(JBNNELNIDOD OGGLMCNMCLJ, out int HGBOOPNCHBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x2E03A80", Offset = "0x2E02480", VA = "0x182E03A80", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2E03A70", Offset = "0x2E02470", VA = "0x182E03A70", Slot = "5")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2E03800", Offset = "0x2E02200", VA = "0x182E03800")]
	private void BKCLBJAAJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2E03AE0", Offset = "0x2E024E0", VA = "0x182E03AE0")]
	public DIEKOFKOONN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[DNOPHNKOHLA(typeof(MFCBDCIMKGI), new string[] { })]
[DefaultMember("Item")]
public class LKOLFONLJHM : MFCBDCIMKGI, IEnumerable<ABCMNOFLGBA>, IEnumerable, EBFNJADEFGO, IPCGJDFHGJG, MMKNGEFLOAO, PKBAIAJJFPF, MKGBMKAAJEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	[JIFPDEDMPGC]
	private HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	[JIFPDEDMPGC]
	private BPDJHFAPEAG PGLPJOOCNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private ABCMNOFLGBA[] KOHILECGEAM;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C32E50", Offset = "0x2C31850", VA = "0x182C32E50", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public ABCMNOFLGBA NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x2C32950", Offset = "0x2C31350", VA = "0x182C32950", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public ABCMNOFLGBA NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C32950", Offset = "0x2C31350", VA = "0x182C32950", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "10")]
	public void BEJHKBIOAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2C32AD0", Offset = "0x2C314D0", VA = "0x182C32AD0", Slot = "11")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "12")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2C32820", Offset = "0x2C31220", VA = "0x182C32820", Slot = "6")]
	public ABCMNOFLGBA BBNMBMIAFFD(GFANKPDBBJN IJEJFFCLBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x2C32E60", Offset = "0x2C31860", VA = "0x182C32E60", Slot = "7")]
	public JBNNELNIDOD MFJEOJEBIAI(GFANKPDBBJN IJEJFFCLBDM)
	{
		return default(JBNNELNIDOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2C32D70", Offset = "0x2C31770", VA = "0x182C32D70", Slot = "8")]
	public IEnumerator<ABCMNOFLGBA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2C32F30", Offset = "0x2C31930", VA = "0x182C32F30", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x39857D0", Offset = "0x39841D0", VA = "0x1839857D0", Slot = "13")]
	public void PDNIFDPKFPO<TKey, T>(global::DABFAGPIBGD<TKey, T> OPPPBNFKNOC, [Optional] object CGFEOLDGFLJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C32990", Offset = "0x2C31390", VA = "0x182C32990", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public LKOLFONLJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2C32950", Offset = "0x2C31350", VA = "0x182C32950")]
	[CompilerGenerated]
	private ABCMNOFLGBA DJIGELEKDPI(int ALJNHCKDPKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
[DNOPHNKOHLA(typeof(BJKMJANDEAI), new string[] { })]
public class ACNBGNCBPLK : BJKMJANDEAI, IEnumerable<KNCBBMLNKLK>, IEnumerable, MMKNGEFLOAO, PKBAIAJJFPF, MKGBMKAAJEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[JIFPDEDMPGC]
	private HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[JIFPDEDMPGC]
	private BPDJHFAPEAG PGLPJOOCNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private KNCBBMLNKLK[] KOHILECGEAM;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE060", Offset = "0x2DECA60", VA = "0x182DEE060", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public KNCBBMLNKLK NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x2DEDAF0", Offset = "0x2DEC4F0", VA = "0x182DEDAF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public KNCBBMLNKLK NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x2DEDAF0", Offset = "0x2DEC4F0", VA = "0x182DEDAF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDEE0", Offset = "0x2DEC8E0", VA = "0x182DEDEE0", Slot = "9")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDBA0", Offset = "0x2DEC5A0", VA = "0x182DEDBA0", Slot = "10")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDE00", Offset = "0x2DEC800", VA = "0x182DEDE00")]
	private KNCBBMLNKLK GBIFCLEFMKI(int GFDMFLGCBKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2DED9D0", Offset = "0x2DEC3D0", VA = "0x182DED9D0", Slot = "6")]
	public KNCBBMLNKLK BBNMBMIAFFD(GFANKPDBBJN IJEJFFCLBDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE0B0", Offset = "0x2DECAB0", VA = "0x182DEE0B0", Slot = "14")]
	public JBNNELNIDOD MFJEOJEBIAI(GFANKPDBBJN IJEJFFCLBDM)
	{
		return default(JBNNELNIDOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDF50", Offset = "0x2DEC950", VA = "0x182DEDF50", Slot = "7")]
	public IEnumerator<KNCBBMLNKLK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDF50", Offset = "0x2DEC950", VA = "0x182DEDF50", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x23DC760", Offset = "0x23DB160", VA = "0x1823DC760", Slot = "11")]
	public void PDNIFDPKFPO<TKey, T>(global::DABFAGPIBGD<TKey, T> OPPPBNFKNOC, [Optional] object CGFEOLDGFLJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDB00", Offset = "0x2DEC500", VA = "0x182DEDB00", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public ACNBGNCBPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2DEDAF0", Offset = "0x2DEC4F0", VA = "0x182DEDAF0")]
	[CompilerGenerated]
	private KNCBBMLNKLK DJIGELEKDPI(int ALJNHCKDPKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[DNOPHNKOHLA(typeof(BCEHDKHLBBB), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
internal class BCEHDKHLBBB : MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private BPDJHFAPEAG PGLPJOOCNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private BJKMJANDEAI JACHJJNGKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private MFCBDCIMKGI JLMHGPFJCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private global::OKLNGFEDEOH<OOILAAHGBJC> HEGIPKLPDFM;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public OOENDMBBEKK BGMHDFJODOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x6C8590", Offset = "0x6C6F90", VA = "0x1806C8590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2DF09F0", Offset = "0x2DEF3F0", VA = "0x182DF09F0", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0B20", Offset = "0x2DEF520", VA = "0x182DF0B20")]
	private void HMJIGEEBBOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2602F20", Offset = "0x2601920", VA = "0x182602F20")]
	public T NLFEPGOIEOJ<T>() where T : OOILAAHGBJC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0C10", Offset = "0x2DEF610", VA = "0x182DF0C10")]
	public FBPCPDKHEOJ PCPLCPGABGA(GFANKPDBBJN ANJJEPIBAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	public global::BBFFFGFDPOL<T> PCPLCPGABGA<T>(GFANKPDBBJN ANJJEPIBAGI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0850", Offset = "0x2DEF250", VA = "0x182DF0850")]
	public KNCBBMLNKLK CDMGCFFCGDA(GFANKPDBBJN ANJJEPIBAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2676DE0", Offset = "0x26757E0", VA = "0x182676DE0")]
	public global::ILMNIKBAHLP<T> CDMGCFFCGDA<T>(GFANKPDBBJN ANJJEPIBAGI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0920", Offset = "0x2DEF320", VA = "0x182DF0920")]
	public ABCMNOFLGBA DGIFEMLMBEG(GFANKPDBBJN ANJJEPIBAGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	public global::HPHDKDPLNJH<T> DGIFEMLMBEG<T>(GFANKPDBBJN ANJJEPIBAGI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public BCEHDKHLBBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class ELIGKMOOPHF
{
	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2171450", Offset = "0x216FE50", VA = "0x182171450")]
	public static global::BBFFFGFDPOL<T> PCPLCPGABGA<T>(this BCEHDKHLBBB KPGKMEENODO, global::BBEGIGBIOHM<T> ANJJEPIBAGI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	public static global::ILMNIKBAHLP<T> CDMGCFFCGDA<T>(this BCEHDKHLBBB KPGKMEENODO, global::BBEGIGBIOHM<T> ANJJEPIBAGI) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	public static global::HPHDKDPLNJH<T> DGIFEMLMBEG<T>(this BCEHDKHLBBB KPGKMEENODO, global::BBEGIGBIOHM<T> ANJJEPIBAGI) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[DNOPHNKOHLA(typeof(OEIFMOIECOL), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public class OEIFMOIECOL : MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private PDDEKMBPLOK GNNMJPOKEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private JBNNELNIDOD[] MAFNLGHMLJO;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x2AEADF0", Offset = "0x2AE97F0", VA = "0x182AEADF0", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x2AEACD0", Offset = "0x2AE96D0", VA = "0x182AEACD0")]
	public void FHBBHDHANMM(AKLFKNOOHJC AOCEENCOLMM, bool CIALKMDELLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public OEIFMOIECOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DNOPHNKOHLA(typeof(GPJJFEHBDKD), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public sealed class GPJJFEHBDKD : MMKNGEFLOAO, PKBAIAJJFPF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class HJEDHGIKLED : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x89C150", Offset = "0x89AB50", VA = "0x18089C150")]
		[DebuggerHidden]
		public HJEDHGIKLED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3000", Offset = "0x3FF1A00", VA = "0x183FF3000", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2C50", Offset = "0x3FF1650", VA = "0x183FF2C50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3080", Offset = "0x3FF1A80", VA = "0x183FF3080")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2FC0", Offset = "0x3FF19C0", VA = "0x183FF2FC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2F30", Offset = "0x3FF1930", VA = "0x183FF2F30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x3FF2F30", Offset = "0x3FF1930", VA = "0x183FF2F30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string EEFFGPLDCOP = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<SerializableGuid, KDAOBJAJCNI> LFNMGEAFFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly List<SerializableGuid> GNCKDGHIJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly Dictionary<SerializableGuid, GameObject> HPAFIPNLAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private BJKMJANDEAI PDPOLFACNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private LFIFNADKAEF EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private GCELLPHAFPH JAINECODPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private JEHPLMMOFBJ OEJDFENKCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private global::NENALMGBADL<KDAOBJAJCNI> EAHLNPNOFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private GameObject PINPDAJIGEN;

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x2C1CCD0", Offset = "0x2C1B6D0", VA = "0x182C1CCD0", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x2C1CAA0", Offset = "0x2C1B4A0", VA = "0x182C1CAA0", Slot = "5")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C8F0", Offset = "0x2C1B2F0", VA = "0x182C1C8F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2C1CA90", Offset = "0x2C1B490", VA = "0x182C1CA90")]
	private void EHMFNOEGACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2C1CDA0", Offset = "0x2C1B7A0", VA = "0x182C1CDA0")]
	internal void HAGICBBJFLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C710", Offset = "0x2C1B110", VA = "0x182C1C710")]
	private void DLOEKIHDDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2C1DDA0", Offset = "0x2C1C7A0", VA = "0x182C1DDA0")]
	private void PLFEKMPILBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2C1DD50", Offset = "0x2C1C750", VA = "0x182C1DD50")]
	[IteratorStateMachine(typeof(HJEDHGIKLED))]
	private IEnumerable<RRCustomPropTag> PHAMGGEEBBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D1D0", Offset = "0x2C1BBD0", VA = "0x182C1D1D0")]
	private void IFANACAOHAE(DFKOJFHJBPL PMMCMCPNCLD, in DHBMIEMIIHO FAAGLIPDKEL, in DHBMIEMIIHO ONFBDMEKEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2C1DA30", Offset = "0x2C1C430", VA = "0x182C1DA30")]
	private void OGMDKKEHOIN(SerializableGuid CKAFGMOJCKA, GameObject KEHOIMKGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D650", Offset = "0x2C1C050", VA = "0x182C1D650")]
	private void MBOPDJPKJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2C1DB70", Offset = "0x2C1C570", VA = "0x182C1DB70")]
	private bool OMIINJKBILA(KDAOBJAJCNI HOGFGIKBHGJ, Transform ELGBIOMPEHN, out GameObject AIDJCJOCGNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D9E0", Offset = "0x2C1C3E0", VA = "0x182C1D9E0")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x2C1DEA0", Offset = "0x2C1C8A0", VA = "0x182C1DEA0")]
	public GPJJFEHBDKD()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public SerializableGuid HDNFGGCIKOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000532")]
			[Cpp2IlInjected.Address(RVA = "0x6E2040", Offset = "0x6E0A40", VA = "0x1806E2040")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2B04FC0", Offset = "0x2B039C0", VA = "0x182B04FC0")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DNOPHNKOHLA(typeof(CPFAHCFNIOH), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public class CPFAHCFNIOH : MMKNGEFLOAO
{
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private const string ILJHDPGNGFL = "Main";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private SceneService DLIDPEKLJKC;

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4BA0", Offset = "0x2DF35A0", VA = "0x182DF4BA0", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public CPFAHCFNIOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DNOPHNKOHLA(typeof(FDOEOHJDFPI), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public class FDOEOHJDFPI : MMKNGEFLOAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[JIFPDEDMPGC]
	private EnableComponentSystemsInScope JKCKMOHEJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[JIFPDEDMPGC]
	private SceneService DLIDPEKLJKC;

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2C176F0", Offset = "0x2C160F0", VA = "0x182C176F0", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2C176B0", Offset = "0x2C160B0", VA = "0x182C176B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2C17760", Offset = "0x2C16160", VA = "0x182C17760")]
	private void KFILGBHBPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x2C17680", Offset = "0x2C16080", VA = "0x182C17680")]
	private void AJCDJOJEMDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public FDOEOHJDFPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DNOPHNKOHLA(typeof(DGINFINNHOA), new string[] { })]
public class IPKKBDPNKGC : MMKNGEFLOAO, PKBAIAJJFPF, DGINFINNHOA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private LAIKDFLJMKI HKHMGAMGNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private DHGIMBCJOIN CHNNBDJLLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private PropertyEventCallbacksService BDLNKGOJBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private LocalPlayerScopeSystem JEJKOBEJMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private int PGBBODHFKBH;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool LPBEELCKFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x2C263B0", Offset = "0x2C24DB0", VA = "0x182C263B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public DFKOJFHJBPL IGBEIJAJIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2C26310", Offset = "0x2C24D10", VA = "0x182C26310", Slot = "9")]
		get
		{
			return default(DFKOJFHJBPL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2C25BB0", Offset = "0x2C245B0", VA = "0x182C25BB0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public POPHLPHEEBM EPPEEBLENIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2C268E0", Offset = "0x2C252E0", VA = "0x182C268E0", Slot = "11")]
		get
		{
			return default(POPHLPHEEBM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2C25BB0", Offset = "0x2C245B0", VA = "0x182C25BB0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public POPHLPHEEBM BHFGHFHGKMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2C26AF0", Offset = "0x2C254F0", VA = "0x182C26AF0", Slot = "13")]
		get
		{
			return default(POPHLPHEEBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private uint ELLJEMAPNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2C26A40", Offset = "0x2C25440", VA = "0x182C26A40")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event COILGKAGPMO OABGDDDFKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2C25BD0", Offset = "0x2C245D0", VA = "0x182C25BD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x2C269A0", Offset = "0x2C253A0", VA = "0x182C269A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2C26240", Offset = "0x2C24C40", VA = "0x182C26240", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x2C25F10", Offset = "0x2C24910", VA = "0x182C25F10", Slot = "5")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x2C25C70", Offset = "0x2C24670", VA = "0x182C25C70", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x2C266E0", Offset = "0x2C250E0", VA = "0x182C266E0")]
	private void MBMDHDNBLKC(Entity GOANOLJBHPF, JBNNELNIDOD ILFNNAAOJHE, DHBMIEMIIHO HKLCHIBFNAM, DHBMIEMIIHO APGCALANEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2C25AA0", Offset = "0x2C244A0", VA = "0x182C25AA0", Slot = "14")]
	public DFKOJFHJBPL BPIDCKMFGNC(DFKOJFHJBPL KFMKMKEGGGJ, DFKOJFHJBPL IADBGEPICDI)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2C265E0", Offset = "0x2C24FE0", VA = "0x182C265E0", Slot = "15")]
	public bool LONLDNKLGBI(DFKOJFHJBPL KFMKMKEGGGJ, DFKOJFHJBPL IADBGEPICDI, out DFKOJFHJBPL ENIDPPCMOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2C260B0", Offset = "0x2C24AB0", VA = "0x182C260B0", Slot = "16")]
	public void GDPKFEMKHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2C265C0", Offset = "0x2C24FC0", VA = "0x182C265C0", Slot = "17")]
	public void JGJLIJCILCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2C25D20", Offset = "0x2C24720", VA = "0x182C25D20", Slot = "18")]
	public bool EONMGNFOEPG(DFKOJFHJBPL JNODNCHMALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2C26450", Offset = "0x2C24E50", VA = "0x182C26450")]
	private void IPMHODLCDCH(DFKOJFHJBPL MEKKGAEJGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public IPKKBDPNKGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DNOPHNKOHLA(typeof(DIOGGBHHPCP), new string[] { })]
public class IOOIIBDEMIH : MMKNGEFLOAO, DIOGGBHHPCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private EntityManager BJMEFCCEPHI;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2C259B0", Offset = "0x2C243B0", VA = "0x182C259B0", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2C25A30", Offset = "0x2C24430", VA = "0x182C25A30", Slot = "5")]
	public void MKHBPKCBCDA(DFKOJFHJBPL EFHLICFAAGO, bool MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x223EB60", Offset = "0x223D560", VA = "0x18223EB60")]
	private void NLANNFAIKGA<T>(DFKOJFHJBPL EFHLICFAAGO, bool MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public IOOIIBDEMIH()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[DNOPHNKOHLA(typeof(HOHEDKHFMCC), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.RenderEffects)]
	public class SelectionService : MMKNGEFLOAO, HOHEDKHFMCC
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private EntityManager BJMEFCCEPHI;

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD9F0", Offset = "0x2BFC3F0", VA = "0x182BFD9F0", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x2BFDAE0", Offset = "0x2BFC4E0", VA = "0x182BFDAE0", Slot = "5")]
		public void KOGFLHNCOKL(DFKOJFHJBPL EFHLICFAAGO, bool MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x2BFDA70", Offset = "0x2BFC470", VA = "0x182BFDA70", Slot = "6")]
		public void IIDBFMCDFLO(DFKOJFHJBPL EFHLICFAAGO, bool MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x223EB60", Offset = "0x223D560", VA = "0x18223EB60")]
		private void NLANNFAIKGA<T>(DFKOJFHJBPL EFHLICFAAGO, bool MNIAGKNOHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
[DNOPHNKOHLA(typeof(JAMGAAIGANJ), new string[] { })]
internal sealed class JAMGAAIGANJ : MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	[JIFPDEDMPGC]
	private ObjectEmbodimentService MIDDDIBGPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	[JIFPDEDMPGC]
	private DEAGKEFEBKN ALIKEONHNHI;

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x2C27810", Offset = "0x2C26210", VA = "0x182C27810", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public JAMGAAIGANJ()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Serialization)]
	[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
	[DNOPHNKOHLA(typeof(WorldSerialization), new string[] { })]
	internal sealed class WorldSerialization : MMKNGEFLOAO, CNKLABGKIMB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private static readonly KGOHPJFJCLE PCAOIFLAMFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[JIFPDEDMPGC]
		private ODIDMGCABMI EEKPEHGPCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[JIFPDEDMPGC]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[JIFPDEDMPGC]
		private SerializationService JAINECODPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[JIFPDEDMPGC]
		private PMIFMKBOKIE KJBMIMOPDKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[JIFPDEDMPGC]
		private DebugWorldsService JDKNHOAGOCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[JIFPDEDMPGC]
		private BulkInstantiateSceneObjectService BPAGFIDGFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private NKLKBAHCHOA BKJAOJMOJPF;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private JAHMKKMLHEN DGMKFGECENM
		{
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0xC17E90", Offset = "0xC16890", VA = "0x180C17E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2C12810", Offset = "0x2C11210", VA = "0x182C12810", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA EMAGHNACJLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x2C122B0", Offset = "0x2C10CB0", VA = "0x182C122B0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x2C12D50", Offset = "0x2C11750", VA = "0x182C12D50", Slot = "6")]
		public bool OABJFBAJFGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2C12D30", Offset = "0x2C11730", VA = "0x182C12D30", Slot = "7")]
		public bool MEDIFIIJCIK(IEnumerable<DMEOMGPBNBN> EMJPLLBFAOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2C12380", Offset = "0x2C10D80", VA = "0x182C12380", Slot = "5")]
		public ByteString EOPJHDNOGBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x2C12D10", Offset = "0x2C11710", VA = "0x182C12D10")]
		private void JHAEGDMEKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x2C12C40", Offset = "0x2C11640", VA = "0x182C12C40")]
		private void HMCPGMBJIID(OANDAJOBGIN LEIENNNIAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2C11D80", Offset = "0x2C10780", VA = "0x182C11D80")]
		private void AKGEPDOBLBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2C12960", Offset = "0x2C11360", VA = "0x182C12960")]
		private void HGPBMKJBCBG(AENEDCLILGP LEIENNNIAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2C12260", Offset = "0x2C10C60", VA = "0x182C12260", Slot = "8")]
		public void DGBFGGFLFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2C122E0", Offset = "0x2C10CE0", VA = "0x182C122E0")]
		private OANDAJOBGIN EEFAADOHGMJ(EntityManager OIBJDJMEICO, EntityManager NCLMKLFAEMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public WorldSerialization()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[DNOPHNKOHLA(typeof(GNGOPCBCEEB), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
public class GNGOPCBCEEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private readonly Dictionary<MGHIFAKDBDN, string> CBMJLDDPGFC;

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B8E0", Offset = "0x2C1A2E0", VA = "0x182C1B8E0")]
	public GameObject HOJBMHFFMJK(MGHIFAKDBDN OKDDBKPIHCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B9B0", Offset = "0x2C1A3B0", VA = "0x182C1B9B0")]
	public GNGOPCBCEEB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	[DNOPHNKOHLA(typeof(TimeService), new string[] { })]
	public class TimeService : IPCGJDFHGJG, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[JIFPDEDMPGC]
		private SingletonComponentService PGLIIKOEFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private bool GHLFAJEMFHI;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public TimeData NDICEIPHCNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x2C05300", Offset = "0x2C03D00", VA = "0x182C05300")]
			get
			{
				return default(TimeData);
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x2C05480", Offset = "0x2C03E80", VA = "0x182C05480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool LHDDLGOFCPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8D0", Offset = "0x6DA2D0", VA = "0x1806DB8D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x6FD000", Offset = "0x6FBA00", VA = "0x1806FD000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x21A9490", Offset = "0x21A7E90", VA = "0x1821A9490", Slot = "4")]
		public void BEJHKBIOAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2C05370", Offset = "0x2C03D70", VA = "0x182C05370", Slot = "5")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2C053C0", Offset = "0x2C03DC0", VA = "0x182C053C0")]
		public void JAPNDBJHHAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public TimeService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[LOEOGANCBGC(EDPDLGMLNHJ.TransformSyncing)]
	[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
	[DNOPHNKOHLA(typeof(SetTransformParentIfParentPropertyChanges), new string[] { })]
	internal class SetTransformParentIfParentPropertyChanges : MMKNGEFLOAO, PKBAIAJJFPF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private JOHEJCALJIO CAJCDELKPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private global::BBFFFGFDPOL<Entity> ELGBIOMPEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private ObjectEmbodimentService CHJAOAHKKML;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x2C01650", Offset = "0x2C00050", VA = "0x182C01650", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x2C01520", Offset = "0x2BFFF20", VA = "0x182C01520", Slot = "5")]
		public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2C01480", Offset = "0x2BFFE80", VA = "0x182C01480", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2C016C0", Offset = "0x2C000C0", VA = "0x182C016C0")]
		private void NJELEOJGGHH(Entity GOANOLJBHPF, in DHBMIEMIIHO FAAGLIPDKEL, in DHBMIEMIIHO ONFBDMEKEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public SetTransformParentIfParentPropertyChanges()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Services)]
	[DNOPHNKOHLA(typeof(EnableTransmissionOnlyInLoadInstance), new string[] { })]
	[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
	public class EnableTransmissionOnlyInLoadInstance : MMKNGEFLOAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[JIFPDEDMPGC]
		private PMEHOMADNGN JECBMIHPMOH;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		private IEBFLHIHGDJ FICEECAFNHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x2E0AA70", Offset = "0x2E09470", VA = "0x182E0AA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		private LGDNCDJDAEI BFEAIEKIGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x2E0AA20", Offset = "0x2E09420", VA = "0x182E0AA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x2E0AAC0", Offset = "0x2E094C0", VA = "0x182E0AAC0", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x2E0AA00", Offset = "0x2E09400", VA = "0x182E0AA00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public EnableTransmissionOnlyInLoadInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[DNOPHNKOHLA(typeof(JDJADFLICON), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public class JDJADFLICON : HFHAMBGAEFF, EBFNJADEFGO, IPCGJDFHGJG, MMKNGEFLOAO, PKBAIAJJFPF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class ANEJOOJMECJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public NKLKBAHCHOA services;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ANEJOOJMECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x3FEEFA0", Offset = "0x3FED9A0", VA = "0x183FEEFA0")]
		internal void <InitReferences>b__0(MMKNGEFLOAO svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class LLAIEGMDDDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public NKLKBAHCHOA services;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LLAIEGMDDDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6F40", Offset = "0x3FF5940", VA = "0x183FF6F40")]
		internal void <InitExternal>b__0(PKBAIAJJFPF svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	[JIFPDEDMPGC]
	private DEAGKEFEBKN ALIKEONHNHI;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public NAJLEECMFPG IGMFGBGPOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x92E060", Offset = "0x92CA60", VA = "0x18092E060", Slot = "4")]
		get
		{
			return default(NAJLEECMFPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private EAPDPHILGKF CIFPLKLELPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x2C2AF50", Offset = "0x2C29950", VA = "0x182C2AF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2C2B080", Offset = "0x2C29A80", VA = "0x182C2B080", Slot = "5")]
	public void KMAONFGIHCN(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2C2AC10", Offset = "0x2C29610", VA = "0x182C2AC10", Slot = "6")]
	public void BEJHKBIOAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x2C2AFA0", Offset = "0x2C299A0", VA = "0x182C2AFA0", Slot = "7")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x2C2AE70", Offset = "0x2C29870", VA = "0x182C2AE70", Slot = "8")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x2C2AD40", Offset = "0x2C29740", VA = "0x182C2AD40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x28389A0", Offset = "0x28373A0", VA = "0x1828389A0")]
	private void GMPPKECBIPP<T>(Action<T> KIPNCAHABCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public JDJADFLICON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DefaultMember("Item")]
public class PMFHHFKPKIK<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly Func<From, To> JDMAAJJIAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly Func<To, From> JIGHDAFLPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public DynamicBuffer<From> DFIIPKJNKEL;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public To NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool IBHDBAOIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	public PMFHHFKPKIK(Func<From, To> JDMAAJJIAIA, Func<To, From> JIGHDAFLPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] GNPHBMKMMCM, int PCEAKJKGHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To DBLPBNJOGMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int GFDMFLGCBKB, To DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DefaultMember("Item")]
public class LPDJLPFDHPJ<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Func<From, To> JDMAAJJIAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly Func<To, From> JIGHDAFLPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public List<From> OKDFPKLCDDM;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public To NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x299BC20", Offset = "0x299A620", VA = "0x18299BC20", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x299BC80", Offset = "0x299A680", VA = "0x18299BC80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x299BBF0", Offset = "0x299A5F0", VA = "0x18299BBF0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool IBHDBAOIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F80", Offset = "0x7B0980", VA = "0x1807B1F80", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x77B170", Offset = "0x779B70", VA = "0x18077B170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x2999C30", Offset = "0x2998630", VA = "0x182999C30")]
	public LPDJLPFDHPJ(Func<From, To> JDMAAJJIAIA, Func<To, From> JIGHDAFLPPD, bool IJLDOICDBDC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x299B810", Offset = "0x299A210", VA = "0x18299B810", Slot = "11")]
	public void Add(To DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x299B870", Offset = "0x299A270", VA = "0x18299B870", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x299B8A0", Offset = "0x299A2A0", VA = "0x18299B8A0", Slot = "13")]
	public bool Contains(To DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x299B900", Offset = "0x299A300", VA = "0x18299B900", Slot = "14")]
	public void CopyTo(To[] GNPHBMKMMCM, int PCEAKJKGHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x299BA10", Offset = "0x299A410", VA = "0x18299BA10", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x299BA80", Offset = "0x299A480", VA = "0x18299BA80", Slot = "6")]
	public int IndexOf(To DBLPBNJOGMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x299BAE0", Offset = "0x299A4E0", VA = "0x18299BAE0", Slot = "7")]
	public void Insert(int GFDMFLGCBKB, To DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x299BB90", Offset = "0x299A590", VA = "0x18299BB90", Slot = "15")]
	public bool Remove(To DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x299BB60", Offset = "0x299A560", VA = "0x18299BB60", Slot = "8")]
	public void RemoveAt(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x289E150", Offset = "0x289CB50", VA = "0x18289E150", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DefaultMember("Item")]
public class BANMOLGFIBM<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly Func<From, To> JDMAAJJIAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly Func<To, From> JIGHDAFLPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeArray<From> GNPHBMKMMCM;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public To NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x4ABFD00", Offset = "0x4ABE700", VA = "0x184ABFD00", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x4ABFD50", Offset = "0x4ABE750", VA = "0x184ABFD50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x4ABFCC0", Offset = "0x4ABE6C0", VA = "0x184ABFCC0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool IBHDBAOIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2764360", Offset = "0x2762D60", VA = "0x182764360")]
	public BANMOLGFIBM(Func<From, To> JDMAAJJIAIA, Func<To, From> JIGHDAFLPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x4ABF880", Offset = "0x4ABE280", VA = "0x184ABF880", Slot = "11")]
	public void Add(To DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x4ABF8C0", Offset = "0x4ABE2C0", VA = "0x184ABF8C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x4ABF900", Offset = "0x4ABE300", VA = "0x184ABF900", Slot = "13")]
	public bool Contains(To DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x4ABF9C0", Offset = "0x4ABE3C0", VA = "0x184ABF9C0", Slot = "14")]
	public void CopyTo(To[] GNPHBMKMMCM, int PCEAKJKGHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x4ABFA80", Offset = "0x4ABE480", VA = "0x184ABFA80", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x4ABFB90", Offset = "0x4ABE590", VA = "0x184ABFB90", Slot = "6")]
	public int IndexOf(To DBLPBNJOGMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x4ABFC00", Offset = "0x4ABE600", VA = "0x184ABFC00", Slot = "7")]
	public void Insert(int GFDMFLGCBKB, To DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x4ABFC80", Offset = "0x4ABE680", VA = "0x184ABFC80", Slot = "15")]
	public bool Remove(To DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x4ABFC40", Offset = "0x4ABE640", VA = "0x184ABFC40", Slot = "8")]
	public void RemoveAt(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FDF840", Offset = "0x1FDE240", VA = "0x181FDF840", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DefaultMember("Item")]
public class EBIALKIDJLE<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private readonly Func<From, To> JDMAAJJIAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private readonly Func<To, From> JIGHDAFLPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeList<From> OKDFPKLCDDM;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public To NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool IBHDBAOIIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	public EBIALKIDJLE(Func<From, To> JDMAAJJIAIA, Func<To, From> JIGHDAFLPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] GNPHBMKMMCM, int PCEAKJKGHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To DBLPBNJOGMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int GFDMFLGCBKB, To DBLPBNJOGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To DBLPBNJOGMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class OIOFCABEKAP
{
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public const string KGFPMEPCLOE = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public const string BGBIBEODKDC = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public const string GLIAPMGBKED = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public const string FKFKICOHEDD = "The hierarchy is deeper than allowed";

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public const string MNGKCMEMMNL = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public const string GLHALFIAMPF = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public const string PHFMKCAGDJI = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public const string MFHFFOAFAFD = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class EJIJEIPIGOB
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class OCDHPENGJDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public NKLKBAHCHOA services;

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public OCDHPENGJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x2BF97D0", Offset = "0x2BF81D0", VA = "0x182BF97D0")]
		internal void <InitServices>b__1(MMKNGEFLOAO svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2BF9830", Offset = "0x2BF8230", VA = "0x182BF9830")]
		internal void <InitServices>b__2(PKBAIAJJFPF svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x2E07DA0", Offset = "0x2E067A0", VA = "0x182E07DA0")]
	public static void KFJDAFPAHMP(this EAPDPHILGKF HDJFKDANOCN, NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x2170B50", Offset = "0x216F550", VA = "0x182170B50")]
	public static void GMPPKECBIPP<T>(this EAPDPHILGKF HDJFKDANOCN, Action<T> KIPNCAHABCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x2170D30", Offset = "0x216F730", VA = "0x182170D30")]
	public static void JBGONLIEAAI<T>(this EAPDPHILGKF HDJFKDANOCN, Action<T> KIPNCAHABCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x21709A0", Offset = "0x216F3A0", VA = "0x1821709A0")]
	public static void FFJDPEHBPCL<T>(this EAPDPHILGKF HDJFKDANOCN, Action<T> KIPNCAHABCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0x2170ED0", Offset = "0x216F8D0", VA = "0x182170ED0")]
	public static void JMEMNLJHCLB<T>(this EAPDPHILGKF HDJFKDANOCN, Action<T> KIPNCAHABCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x2171140", Offset = "0x216FB40", VA = "0x182171140")]
	public static void ONHBIACGHMD<T>(this EAPDPHILGKF HDJFKDANOCN, Action<T> KIPNCAHABCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0x2170BC0", Offset = "0x216F5C0", VA = "0x182170BC0")]
	public static void JBGONLIEAAI<T>(IEnumerable<ComponentSystemBase> DBKMNLNGAJC, Action<T> KIPNCAHABCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x2171080", Offset = "0x216FA80", VA = "0x182171080")]
	private static void MGKHEIFCLAP<T>(object GFDIEIODBJH, Action<T> KIPNCAHABCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class KOBONOEBNNB
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class FKGPGIPPAJB
{
	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C183A0", Offset = "0x2C16DA0", VA = "0x182C183A0")]
	public static void EDKDLKDHLEC(ComponentSystemBase GFDIEIODBJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class JNPIOOGPHDI
{
	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	public static bool GGJNAKDJGFB<T>(ref T PKEMCIANHMO, ref T DLAMIJMLOOE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class JKACDCOBAIC
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class OGOLLEMFLNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public OGOLLEMFLNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C2B630", Offset = "0x2C2A030", VA = "0x182C2B630")]
	public static string BGJMIGOOGMH(Transform CLHKPCIOCGF, Transform JNODNCHMALF)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Services)]
	internal static class ServiceInitialization
	{
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C00360", Offset = "0x2BFED60", VA = "0x182C00360")]
		public static void EPCHFMECFAE(this IGIBMKFLGBD BKJAOJMOJPF, MGEKGGAJIBD HLCFNPLAIJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x2C00590", Offset = "0x2BFEF90", VA = "0x182C00590")]
		public static void GDGFHAPKHBL(this IGIBMKFLGBD BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x2C00250", Offset = "0x2BFEC50", VA = "0x182C00250")]
		public static void EPCHFMECFAE(this IGIBMKFLGBD BKJAOJMOJPF, [Optional] string[] NJDEGDBIHCA, [Optional] string[] AEJPLAGNCHP, [Optional] string[] DONJJCAJMOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x2C00690", Offset = "0x2BFF090", VA = "0x182C00690")]
		public static void HMGGDFNNHOB(this IGIBMKFLGBD BKJAOJMOJPF, params string[] FEACCCIJAIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x2C00940", Offset = "0x2BFF340", VA = "0x182C00940")]
		public static void LNJBPKCIIMI(this IGIBMKFLGBD BKJAOJMOJPF, params string[] FEACCCIJAIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x2C00740", Offset = "0x2BFF140", VA = "0x182C00740")]
		private static string[] JHPIHNIDEEL(MGEKGGAJIBD HLCFNPLAIJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x2C009F0", Offset = "0x2BFF3F0", VA = "0x182C009F0")]
		private static bool OLBKKHDMADI(MGEKGGAJIBD HLCFNPLAIJP, out string[] FKIHEBCBJKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00")]
		private static bool GGHNKLPNJLG()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public abstract class IHEOCMFIPLO : DLPKICFOGOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly MethodInfo OBPDJCCINKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Type[] KGNEMFGHDAD;

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x2C175D0", Offset = "0x2C15FD0", VA = "0x182C175D0")]
	public IHEOCMFIPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action GHIKHJHHPDP();

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x2C25030", Offset = "0x2C23A30", VA = "0x182C25030")]
	public MethodInfo LLEKDHMNGNN(Action CKAPOBIDCEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x2C25070", Offset = "0x2C23A70", VA = "0x182C25070", Slot = "4")]
	public void OGMDKKEHOIN(Type MAHAMGBPDNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public abstract class FCABLEPPAKE : IHEOCMFIPLO
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum ADDDFPHDHGB
	{

	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x2C174B0", Offset = "0x2C15EB0", VA = "0x182C174B0", Slot = "5")]
	public override Action GHIKHJHHPDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void EEIODAPDOJK<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x2C17540", Offset = "0x2C15F40", VA = "0x182C17540")]
	[Preserve]
	public void GLNIGFMCMNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C175D0", Offset = "0x2C15FD0", VA = "0x182C175D0")]
	protected FCABLEPPAKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public abstract class NPNBFGKJLBJ : IHEOCMFIPLO
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9900", Offset = "0x2AE8300", VA = "0x182AE9900", Slot = "5")]
	public override Action GHIKHJHHPDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void DDCLIBLPFJO<T>() where T : PHKDHEJMAMA;

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9990", Offset = "0x2AE8390", VA = "0x182AE9990")]
	[Preserve]
	public void GLNIGFMCMNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9A20", Offset = "0x2AE8420", VA = "0x182AE9A20")]
	protected NPNBFGKJLBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public abstract class DHFHLNGANPL : IHEOCMFIPLO
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x2E02BE0", Offset = "0x2E015E0", VA = "0x182E02BE0", Slot = "5")]
	public override Action GHIKHJHHPDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void HGMOMKJIJIE<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x2E02C70", Offset = "0x2E01670", VA = "0x182E02C70")]
	[Preserve]
	public void GLNIGFMCMNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9A20", Offset = "0x2AE8420", VA = "0x182AE9A20")]
	protected DHFHLNGANPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class AJOPKLNIJHE
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE640", Offset = "0x2DED040", VA = "0x182DEE640")]
	public static Entity HELANJOIFBC(this EntityManager BJMEFCCEPHI)
	{
		return default(Entity);
	}
}
namespace RecRoom.ObjectModel.HierarchyExtensions
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[LOEOGANCBGC(EDPDLGMLNHJ.HierarchySystems)]
	public static class EntityManagerHierarchyExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		[CompilerGenerated]
		private sealed class OBLMMOMGFJN : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
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
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000625")]
				[Cpp2IlInjected.Address(RVA = "0x24CCB30", Offset = "0x24CB530", VA = "0x1824CCB30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000627")]
				[Cpp2IlInjected.Address(RVA = "0x3FF90E0", Offset = "0x3FF7AE0", VA = "0x183FF90E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2C20", Offset = "0x3FF1620", VA = "0x183FF2C20")]
			[DebuggerHidden]
			public OBLMMOMGFJN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0x3FF8F10", Offset = "0x3FF7910", VA = "0x183FF8F10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0x3FF90A0", Offset = "0x3FF7AA0", VA = "0x183FF90A0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x3FF8FF0", Offset = "0x3FF79F0", VA = "0x183FF8FF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x3FF8FF0", Offset = "0x3FF79F0", VA = "0x183FF8FF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class JHGNBJJMDKD : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private bool includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public bool <>3__includeSelf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			private IEnumerator<Entity> <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600062E")]
				[Cpp2IlInjected.Address(RVA = "0x24CCB30", Offset = "0x24CB530", VA = "0x1824CCB30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000630")]
				[Cpp2IlInjected.Address(RVA = "0x3FF4CB0", Offset = "0x3FF36B0", VA = "0x183FF4CB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2C20", Offset = "0x3FF1620", VA = "0x183FF2C20")]
			[DebuggerHidden]
			public JHGNBJJMDKD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4D00", Offset = "0x3FF3700", VA = "0x183FF4D00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062C")]
			[Cpp2IlInjected.Address(RVA = "0x3FF49D0", Offset = "0x3FF33D0", VA = "0x183FF49D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4D90", Offset = "0x3FF3790", VA = "0x183FF4D90")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4C70", Offset = "0x3FF3670", VA = "0x183FF4C70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4BC0", Offset = "0x3FF35C0", VA = "0x183FF4BC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4BC0", Offset = "0x3FF35C0", VA = "0x183FF4BC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		[CompilerGenerated]
		private sealed class HICIDHBKAIL : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			private Entity <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private EntityManager entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public EntityManager <>3__entityManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			private Entity entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public Entity <>3__entity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			private ChildrenData <childData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			private IEnumerator<Entity> <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x170000D3")]
			Entity IEnumerator<Entity>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000638")]
				[Cpp2IlInjected.Address(RVA = "0x24CCB30", Offset = "0x24CB530", VA = "0x1824CCB30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Entity);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D4")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600063A")]
				[Cpp2IlInjected.Address(RVA = "0x3FF2A60", Offset = "0x3FF1460", VA = "0x183FF2A60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2C20", Offset = "0x3FF1620", VA = "0x183FF2C20")]
			[DebuggerHidden]
			public HICIDHBKAIL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2AB0", Offset = "0x3FF14B0", VA = "0x183FF2AB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2650", Offset = "0x3FF1050", VA = "0x183FF2650", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2B80", Offset = "0x3FF1580", VA = "0x183FF2B80")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2BD0", Offset = "0x3FF15D0", VA = "0x183FF2BD0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2A20", Offset = "0x3FF1420", VA = "0x183FF2A20", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2980", Offset = "0x3FF1380", VA = "0x183FF2980", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2980", Offset = "0x3FF1380", VA = "0x183FF2980", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x2C16FC0", Offset = "0x2C159C0", VA = "0x182C16FC0")]
		public static Entity NEFGBGOGMPM(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x2C16640", Offset = "0x2C15040", VA = "0x182C16640")]
		public static DynamicBuffer<ChildrenData> IHPCPKAMFFB(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2C17250", Offset = "0x2C15C50", VA = "0x182C17250")]
		public static DynamicBuffer<ChildrenData> OIBCICECOCA(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x2C15C90", Offset = "0x2C14690", VA = "0x182C15C90")]
		public static NativeArray<Entity> BCMGKCJAJMB(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, Allocator GGPAKDMJHLJ)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x2C16D20", Offset = "0x2C15720", VA = "0x182C16D20")]
		public static bool LEHFACIJNCH(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, Allocator GGPAKDMJHLJ, out NativeArray<Entity> LIEEKLEMALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x2C15FD0", Offset = "0x2C149D0", VA = "0x182C15FD0")]
		public static NativeArray<Entity> EEFEPFEBDKN(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x2C166D0", Offset = "0x2C150D0", VA = "0x182C166D0")]
		public static Entity KADGDGJNBPA(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, int GFDMFLGCBKB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x2C17140", Offset = "0x2C15B40", VA = "0x182C17140")]
		public static int NLFFKMDNFBA(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x2C168E0", Offset = "0x2C152E0", VA = "0x182C168E0")]
		public static void KCDOGDOEJAI(NativeArray<Entity> FEENBFHHDPC, NativeArray<Entity> PFGJBHEKNMH, EntityManager BJMEFCCEPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x2C172E0", Offset = "0x2C15CE0", VA = "0x182C172E0")]
		public static int OPHJDINEHKN(this EntityManager BJMEFCCEPHI, Entity ELGBIOMPEHN, Entity DDLMBHAEKGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x2C16B40", Offset = "0x2C15540", VA = "0x182C16B40")]
		public static bool KOAJBNHNOIK(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, Entity OBNNKPFGMNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x2C17030", Offset = "0x2C15A30", VA = "0x182C17030")]
		public static IEnumerable<Entity> NFFFFNFFGFM(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, bool HNONKJJDNKE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x2C15BE0", Offset = "0x2C145E0", VA = "0x182C15BE0")]
		public static bool AEAMAMIPHJB(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, Entity DDLMBHAEKGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x2C15DC0", Offset = "0x2C147C0", VA = "0x182C15DC0")]
		public static bool CNEEDNJDFHP(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, Entity KFMKMKEGGGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x2C16130", Offset = "0x2C14B30", VA = "0x182C16130")]
		public static NativeList<Entity> EMHMOKHNBJK(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, bool HNONKJJDNKE = false, Allocator GGPAKDMJHLJ = Allocator.Temp)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x2C16340", Offset = "0x2C14D40", VA = "0x182C16340")]
		public static IEnumerable<Entity> EPEPDFLBNKD(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, bool HNONKJJDNKE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0x2C15ED0", Offset = "0x2C148D0", VA = "0x182C15ED0")]
		public static Entity EDPENGKDDJF(this EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x2C16E20", Offset = "0x2C15820", VA = "0x182C16E20")]
		public static bool LONLDNKLGBI(this EntityManager BJMEFCCEPHI, Entity KFMKMKEGGGJ, Entity IADBGEPICDI, out Entity ENIDPPCMOFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x2C165C0", Offset = "0x2C14FC0", VA = "0x182C165C0")]
		internal static void IHEFNPOBAKN(EntityManager BJMEFCCEPHI, Entity ELGBIOMPEHN, Entity DDLMBHAEKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x2C164C0", Offset = "0x2C14EC0", VA = "0x182C164C0")]
		internal static void HDGKNMKLGNN(EntityManager BJMEFCCEPHI, Entity ELGBIOMPEHN, Entity DDLMBHAEKGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x2C17390", Offset = "0x2C15D90", VA = "0x182C17390")]
		[IteratorStateMachine(typeof(OBLMMOMGFJN))]
		private static IEnumerable<Entity> PDFKPNFFEPA(EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, bool HNONKJJDNKE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x2C15E40", Offset = "0x2C14840", VA = "0x182C15E40")]
		[IteratorStateMachine(typeof(JHGNBJJMDKD))]
		private static IEnumerable<Entity> DGGDCOKLEEM(EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, bool HNONKJJDNKE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x2C16CA0", Offset = "0x2C156A0", VA = "0x182C16CA0")]
		[IteratorStateMachine(typeof(HICIDHBKAIL))]
		private static IEnumerable<Entity> LBKDBMMHFME(EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x2C16800", Offset = "0x2C15200", VA = "0x182C16800")]
		private static bool KBNMCNFLIOD(EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, Entity OBNNKPFGMNE)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[DNOPHNKOHLA(typeof(DPKHLNGAONH), new string[] { })]
public class OJCDOICGOPP : DPKHLNGAONH, HFHAMBGAEFF, EPNGNNMLNLK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private NKLKBAHCHOA BKJAOJMOJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private LFIFNADKAEF EDFOBNPNANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private ODIDMGCABMI EEKPEHGPCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private LFHKDFGBJPJ LAHDFCJFOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private LAIKDFLJMKI HKHMGAMGNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private JOHEJCALJIO CAJCDELKPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private FCADPKIAEAJ JAINECODPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private MICBEGMKIKM FBKFNMHPGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private BJKMJANDEAI PDPOLFACNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private JFFIFAIOBGL BNCJNLJBPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private HIOHMPHFJEM FNGGLOABMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private DGINFINNHOA KGLBMDPKPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private EBIDIPICLGG EKFKPEJHOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private MNMIJEOGALA KHJKMBPFHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private DIOGGBHHPCP AOCAKMGOGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private HOHEDKHFMCC NPFCKFNFMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private OFJGIHJMMMN PFMNHKDJLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private CPMCACBEBDN GMKCGHFBHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private GHMLCJKOGGN MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public NKLKBAHCHOA OHOAOEJOHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public LFIFNADKAEF KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public DEAGKEFEBKN CIFPLKLELPL
	{
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public ODIDMGCABMI BIKAFAMGBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public LFHKDFGBJPJ MKNLADHOOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public HGFGJIKNIPL AHIPFOPLBPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public LAIKDFLJMKI NHHBDODJKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x6C8580", Offset = "0x6C6F80", VA = "0x1806C8580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public JOHEJCALJIO AJCEPDOMKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x6C10D0", Offset = "0x6BFAD0", VA = "0x1806C10D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public FCADPKIAEAJ FMHHHIIODEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x6D7760", Offset = "0x6D6160", VA = "0x1806D7760", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public MICBEGMKIKM NNJEBHMJHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x6C10B0", Offset = "0x6BFAB0", VA = "0x1806C10B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public BJKMJANDEAI KPGMMAHBADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x6D7770", Offset = "0x6D6170", VA = "0x1806D7770", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public JFFIFAIOBGL ABOICNGPLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x6D7780", Offset = "0x6D6180", VA = "0x1806D7780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public HIOHMPHFJEM BALFGABDJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x6D7700", Offset = "0x6D6100", VA = "0x1806D7700", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public DGINFINNHOA CLMKLDLCBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x6D7710", Offset = "0x6D6110", VA = "0x1806D7710", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public EBIDIPICLGG NBHKGKINMJE
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6D0", Offset = "0x6FC0D0", VA = "0x1806FD6D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public MNMIJEOGALA GLLNJCEHHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D80", Offset = "0x6C6780", VA = "0x1806C7D80", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public DIOGGBHHPCP MCMEIKFCIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E20", Offset = "0x6C6820", VA = "0x1806C7E20", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public HOHEDKHFMCC EKALPMIIDFP
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6A0", Offset = "0x6FC0A0", VA = "0x1806FD6A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public OFJGIHJMMMN FHBDODLFDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x6D7720", Offset = "0x6D6120", VA = "0x1806D7720", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public CPMCACBEBDN AHFMIIFADFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x6D7730", Offset = "0x6D6130", VA = "0x1806D7730", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public GHMLCJKOGGN HNAEGLAMKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x6D7750", Offset = "0x6D6150", VA = "0x1806D7750", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public NAJLEECMFPG IGMFGBGPOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x6E7AA0", Offset = "0x6E64A0", VA = "0x1806E7AA0", Slot = "21")]
		get
		{
			return default(NAJLEECMFPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x2AECBF0", Offset = "0x2AEB5F0", VA = "0x182AECBF0", Slot = "22")]
	public void KMAONFGIHCN(NKLKBAHCHOA EMAGHNACJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x1981930", Offset = "0x1980330", VA = "0x181981930", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x2AECEE0", Offset = "0x2AEB8E0", VA = "0x182AECEE0", Slot = "23")]
	public void OABGDDDFKDJ(NKLKBAHCHOA EMAGHNACJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public OJCDOICGOPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DefaultMember("Item")]
public class JBFDMBHMBDB : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class GPCEIELBIEE : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public JBFDMBHMBDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000672")]
			[Cpp2IlInjected.Address(RVA = "0x6D7790", Offset = "0x6D6190", VA = "0x1806D7790", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x3FF1FA0", Offset = "0x3FF09A0", VA = "0x183FF1FA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public GPCEIELBIEE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1DF0", Offset = "0x3FF07F0", VA = "0x183FF1DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1F60", Offset = "0x3FF0960", VA = "0x183FF1F60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	protected const ulong FALDFIDNJDA = 1uL;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected const ulong DMPEFCIPBEN = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected const int JFPCHLLCAKD = 8;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	protected const int GBPEIGPDAAD = 6;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public const int MIHBAFDOBMA = 64;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	protected const int LDBEAEFKDCI = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private readonly List<ulong> HNKMHNDGFIO;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x765410", Offset = "0x763E10", VA = "0x180765410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int JFECKHMAGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC90", Offset = "0x6DB690", VA = "0x1806DCC90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x765320", Offset = "0x763D20", VA = "0x180765320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x2C27B70", Offset = "0x2C26570", VA = "0x182C27B70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x2C279C0", Offset = "0x2C263C0", VA = "0x182C279C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x2C28660", Offset = "0x2C27060", VA = "0x182C28660")]
	public JBFDMBHMBDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x2C286E0", Offset = "0x2C270E0", VA = "0x182C286E0")]
	public JBFDMBHMBDB(int MKLBKBICADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x2C280F0", Offset = "0x2C26AF0", VA = "0x182C280F0")]
	public bool KODNKMCPDBM(int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x2C278D0", Offset = "0x2C262D0", VA = "0x182C278D0")]
	public bool AGLHJEJMDOM(int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x2C281D0", Offset = "0x2C26BD0", VA = "0x182C281D0")]
	public bool LJMFBKHJPCH(int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x2C28250", Offset = "0x2C26C50", VA = "0x182C28250")]
	public bool MPANJOCJMHO(int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x2C28060", Offset = "0x2C26A60", VA = "0x182C28060")]
	public void IBBPJDDCPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x2C27C10", Offset = "0x2C26610", VA = "0x182C27C10")]
	public void CPCCGAJNKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x2C28260", Offset = "0x2C26C60", VA = "0x182C28260")]
	public void NLANNFAIKGA(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x2C283A0", Offset = "0x2C26DA0", VA = "0x182C283A0")]
	public void NMFIICNHENP(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x2C27E40", Offset = "0x2C26840", VA = "0x182C27E40")]
	public bool ELPHOIAOCEH(int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x2C27F40", Offset = "0x2C26940", VA = "0x182C27F40")]
	public void HJPKHKICCEO(int JFKBHBKKACD, int JOBJIONNEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x2C284A0", Offset = "0x2C26EA0", VA = "0x182C284A0")]
	public void PPKDDKKEBMP(int KJCIFPEICMG, int BBPFPCFMEIH, int JOBJIONNEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x2C27D70", Offset = "0x2C26770", VA = "0x182C27D70")]
	public int CPLOAHMOJFD(int JOBJIONNEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x2C27D00", Offset = "0x2C26700", VA = "0x182C27D00")]
	public int CPLOAHMOJFD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x2C28350", Offset = "0x2C26D50", VA = "0x182C28350")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x2C27ED0", Offset = "0x2C268D0", VA = "0x182C27ED0", Slot = "4")]
	[IteratorStateMachine(typeof(GPCEIELBIEE))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x2C27ED0", Offset = "0x2C268D0", VA = "0x182C27ED0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class AAJKJLDBHDO<T> : global::CBMBFKIKLHL<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	protected global::GAPEKLNJAML<T> MNCMPMDGFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	protected global::NFJCIIMFIEB<T> OHLACLDAPOC;

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x1757C60", Offset = "0x1756660", VA = "0x181757C60")]
	public AAJKJLDBHDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0x35A2FA0", Offset = "0x35A19A0", VA = "0x1835A2FA0")]
	public AAJKJLDBHDO(global::GAPEKLNJAML<T> MNCMPMDGFID, global::NFJCIIMFIEB<T> OHLACLDAPOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x35A28B0", Offset = "0x35A12B0", VA = "0x1835A28B0", Slot = "11")]
	public override T AJGJBLGJHIK(FCMEKODKCDO FNNADNFGBNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x35A2D00", Offset = "0x35A1700", VA = "0x1835A2D00", Slot = "12")]
	public override void JHPOCMCIPNJ(FCMEKODKCDO FNNADNFGBNJ, T MNIAGKNOHEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class FJHBEPAJECL
{
	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE9B0", Offset = "0x2DAD3B0", VA = "0x182DAE9B0")]
	public static JBNNELNIDOD OGMDKKEHOIN<T>(this DOHECIMNHKO PDPOLFACNJC, global::BBEGIGBIOHM<T> ANJJEPIBAGI, global::GAPEKLNJAML<T> MNCMPMDGFID, global::NFJCIIMFIEB<T> OHLACLDAPOC) where T : struct
	{
		return default(JBNNELNIDOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public sealed class OHCFLFGJLND<T> : global::AAJKJLDBHDO<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x2EADC40", Offset = "0x2EAC640", VA = "0x182EADC40")]
	public OHCFLFGJLND(T MMCAICBMAII, T OPOPHNBOOKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class HLKCGHLOJOB<T> : global::CBMBFKIKLHL<T> where T : struct, PHKDHEJMAMA
{
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x35F4080", Offset = "0x35F2A80", VA = "0x1835F4080", Slot = "11")]
	public override T AJGJBLGJHIK(FCMEKODKCDO FNNADNFGBNJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x35F4170", Offset = "0x35F2B70", VA = "0x1835F4170", Slot = "12")]
	public override void JHPOCMCIPNJ(FCMEKODKCDO FNNADNFGBNJ, T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x2435F60", Offset = "0x2434960", VA = "0x182435F60")]
	public HLKCGHLOJOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class FLBJHHBBJNE : IOJPBBFOGCI
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public abstract Type DFGNPGBMDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void AJGJBLGJHIK(FCMEKODKCDO FNNADNFGBNJ, in BOPFHHNILGH MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void JHPOCMCIPNJ(FCMEKODKCDO FNNADNFGBNJ, in DHBMIEMIIHO MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void CIOHKMIJCIH(FCMEKODKCDO FNNADNFGBNJ, CAJMDJAFFLI OFPIDICLDMA, [Optional] object CGFEOLDGFLJ);

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	protected FLBJHHBBJNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public abstract class CBMBFKIKLHL<T> : FLBJHHBBJNE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public override Type DFGNPGBMDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x3364400", Offset = "0x3362E00", VA = "0x183364400", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T AJGJBLGJHIK(FCMEKODKCDO FNNADNFGBNJ);

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void JHPOCMCIPNJ(FCMEKODKCDO FNNADNFGBNJ, T MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x3362BA0", Offset = "0x33615A0", VA = "0x183362BA0", Slot = "8")]
	public override void AJGJBLGJHIK(FCMEKODKCDO FNNADNFGBNJ, in BOPFHHNILGH JNODNCHMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x3364070", Offset = "0x3362A70", VA = "0x183364070", Slot = "9")]
	public override void JHPOCMCIPNJ(FCMEKODKCDO FNNADNFGBNJ, in DHBMIEMIIHO MMPIIAHIKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x3363A40", Offset = "0x3362440", VA = "0x183363A40", Slot = "10")]
	public override void CIOHKMIJCIH(FCMEKODKCDO FNNADNFGBNJ, CAJMDJAFFLI OFPIDICLDMA, object CGFEOLDGFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x17A91C0", Offset = "0x17A7BC0", VA = "0x1817A91C0")]
	protected CBMBFKIKLHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class JBPANFMKOBH
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	private class BMAJACEMBGC
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class AHAJIOFLJNK<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
			public AHAJIOFLJNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x306DC00", Offset = "0x306C600", VA = "0x18306DC00")]
			internal void <RegisterFixedString>b__0(FCMEKODKCDO p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x306DFD0", Offset = "0x306C9D0", VA = "0x18306DFD0")]
			internal T <RegisterFixedString>b__1(FCMEKODKCDO p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF860", Offset = "0x3FEE260", VA = "0x183FEF860")]
		public static void GBHKPOGIANO(GFMJFJFLLKC NMBOIKOFMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x343DE90", Offset = "0x343C890", VA = "0x18343DE90")]
		private static void LONLPEEDGDO<T>(GFMJFJFLLKC NMBOIKOFMEF, int OPOPHNBOOKJ) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x343DE00", Offset = "0x343C800", VA = "0x18343DE00")]
		private static void EBGGEFNKJBN<T>(FCMEKODKCDO LHIIFNPNDIA, T ELMMBEILPIG, int OPOPHNBOOKJ) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x343D7B0", Offset = "0x343C1B0", VA = "0x18343D7B0")]
		private static T CNBPFFMNKEN<T>(FCMEKODKCDO LHIIFNPNDIA, int OPOPHNBOOKJ) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public BMAJACEMBGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private class PJLNDMNFKBK : FCABLEPPAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private GFMJFJFLLKC NMBOIKOFMEF;

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x3455140", Offset = "0x3453B40", VA = "0x183455140", Slot = "6")]
		public override void EEIODAPDOJK<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x3FFA170", Offset = "0x3FF8B70", VA = "0x183FFA170")]
		public static void CHDBIPEDGEL(GFMJFJFLLKC NMBOIKOFMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x2AE9A20", Offset = "0x2AE8420", VA = "0x182AE9A20")]
		public PJLNDMNFKBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x2C28820", Offset = "0x2C27220", VA = "0x182C28820")]
	public static void LBLGPPEKJBB(GFMJFJFLLKC NMBOIKOFMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x28364B0", Offset = "0x2834EB0", VA = "0x1828364B0")]
	public static void IIIJENANMLO<T>(GFMJFJFLLKC NMBOIKOFMEF, global::GAPEKLNJAML<T> MNCMPMDGFID, global::NFJCIIMFIEB<T> OHLACLDAPOC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x2836540", Offset = "0x2834F40", VA = "0x182836540")]
	public static void NOCHMHDDOMA<T>(GFMJFJFLLKC BAMJJNCDPBB) where T : struct, PHKDHEJMAMA
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
public interface GFMJFJFLLKC : global::CCBGOOILJBP<GFMJFJFLLKC>
{
	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGMDKKEHOIN(Type MAHAMGBPDNB, IOJPBBFOGCI BAMJJNCDPBB);

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BHPOPCGLBJN(Type MAHAMGBPDNB, out IOJPBBFOGCI BAMJJNCDPBB);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class MIOOKJENBGH
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE68F0", Offset = "0x2AE52F0", VA = "0x182AE68F0")]
	public static void OGMDKKEHOIN(this GFMJFJFLLKC DMALFCEFIJB, IOJPBBFOGCI BAMJJNCDPBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[DNOPHNKOHLA(typeof(DOHECIMNHKO), new string[] { })]
public sealed class GOMKOABGIHA : DOHECIMNHKO, global::CCBGOOILJBP<DOHECIMNHKO>, IPCGJDFHGJG, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private readonly Dictionary<JBNNELNIDOD, IOJPBBFOGCI> NMBOIKOFMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private GFMJFJFLLKC DMNCHDLCKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private MFCBDCIMKGI PDPOLFACNJC;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool KNJPBFAPDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F80", Offset = "0x7B0980", VA = "0x1807B1F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x77B170", Offset = "0x779B70", VA = "0x18077B170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C5D0", Offset = "0x2C1AFD0", VA = "0x182C1C5D0")]
	public GOMKOABGIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C650", Offset = "0x2C1B050", VA = "0x182C1C650")]
	public GOMKOABGIHA(Dictionary<JBNNELNIDOD, IOJPBBFOGCI> NMBOIKOFMEF, bool PAGPEEGMPMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x2C1BE90", Offset = "0x2C1A890", VA = "0x182C1BE90", Slot = "7")]
	public void BEJHKBIOAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C180", Offset = "0x2C1AB80", VA = "0x182C1C180", Slot = "8")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C410", Offset = "0x2C1AE10", VA = "0x182C1C410", Slot = "9")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C200", Offset = "0x2C1AC00", VA = "0x182C1C200", Slot = "4")]
	public JBNNELNIDOD MFJEOJEBIAI(GFANKPDBBJN ANJJEPIBAGI)
	{
		return default(JBNNELNIDOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C460", Offset = "0x2C1AE60", VA = "0x182C1C460", Slot = "5")]
	public void OGMDKKEHOIN(JBNNELNIDOD OGGLMCNMCLJ, IOJPBBFOGCI BAMJJNCDPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C2D0", Offset = "0x2C1ACD0", VA = "0x182C1C2D0")]
	[Conditional("DEBUG_BUILD")]
	private void MIIBFCJEBFC(JBNNELNIDOD OGGLMCNMCLJ, Type MAHAMGBPDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x2C1BEF0", Offset = "0x2C1A8F0", VA = "0x182C1BEF0", Slot = "6")]
	public bool BHPOPCGLBJN(JBNNELNIDOD OGGLMCNMCLJ, out IOJPBBFOGCI BAMJJNCDPBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C0A0", Offset = "0x2C1AAA0", VA = "0x182C1C0A0", Slot = "10")]
	public DOHECIMNHKO FIJLEKMEGPK()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[DNOPHNKOHLA(typeof(GFMJFJFLLKC), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.TypeSerializer)]
	public sealed class TypeSerializerService : IPCGJDFHGJG, GFMJFJFLLKC, global::CCBGOOILJBP<GFMJFJFLLKC>
	{
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private readonly Dictionary<Type, IOJPBBFOGCI> NMBOIKOFMEF;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		public bool KNJPBFAPDGK
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8D0", Offset = "0x6DA2D0", VA = "0x1806DB8D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C8")]
			[Cpp2IlInjected.Address(RVA = "0x6FD000", Offset = "0x6FBA00", VA = "0x1806FD000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B140", Offset = "0x2C09B40", VA = "0x182C0B140")]
		public TypeSerializerService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B1C0", Offset = "0x2C09BC0", VA = "0x182C0B1C0")]
		public TypeSerializerService(Dictionary<Type, IOJPBBFOGCI> NMBOIKOFMEF, bool PAGPEEGMPMF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x2C0ADB0", Offset = "0x2C097B0", VA = "0x182C0ADB0", Slot = "4")]
		public void BEJHKBIOAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AFD0", Offset = "0x2C099D0", VA = "0x182C0AFD0", Slot = "5")]
		public void OGMDKKEHOIN(Type MAHAMGBPDNB, IOJPBBFOGCI BAMJJNCDPBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AE10", Offset = "0x2C09810", VA = "0x182C0AE10", Slot = "6")]
		public bool BHPOPCGLBJN(Type MAHAMGBPDNB, out IOJPBBFOGCI BAMJJNCDPBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AEF0", Offset = "0x2C098F0", VA = "0x182C0AEF0", Slot = "7")]
		public GFMJFJFLLKC FIJLEKMEGPK()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[DNOPHNKOHLA(typeof(GPJMLDLMFCI), new string[] { })]
internal sealed class LLNLFMKGIND : GPJMLDLMFCI, IPCGJDFHGJG, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Dictionary<JBNNELNIDOD, IBEEOABNALJ> JEPMBFDBFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private MFCBDCIMKGI PDPOLFACNJC;

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x2C33390", Offset = "0x2C31D90", VA = "0x182C33390", Slot = "6")]
	public void BEJHKBIOAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x2C33570", Offset = "0x2C31F70", VA = "0x182C33570", Slot = "7")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x2C33640", Offset = "0x2C32040", VA = "0x182C33640", Slot = "4")]
	public void OGMDKKEHOIN(JBNNELNIDOD ILFNNAAOJHE, Type PEFGKHIJHAC, IBEEOABNALJ BIHNFLHANJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x2C335D0", Offset = "0x2C31FD0", VA = "0x182C335D0", Slot = "5")]
	public bool NLCLDEKAPKC(JBNNELNIDOD ILFNNAAOJHE, out IBEEOABNALJ BIHNFLHANJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x2C333E0", Offset = "0x2C31DE0", VA = "0x182C333E0")]
	[Conditional("DEBUG_BUILD")]
	private void GJNDAOCNODN(JBNNELNIDOD ILFNNAAOJHE, Type PEFGKHIJHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x2C336B0", Offset = "0x2C320B0", VA = "0x182C336B0")]
	public LLNLFMKGIND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[DNOPHNKOHLA(typeof(JLBBIMNDMNG), new string[] { })]
internal sealed class DIEGDNAGEPG : JLBBIMNDMNG, EBFNJADEFGO, IPCGJDFHGJG, MMKNGEFLOAO, PKBAIAJJFPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly JBFDMBHMBDB EDBBHLGEPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private readonly Dictionary<AKLFKNOOHJC, int> GNKDFNGKHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private readonly Stack<int> KNBEMOIPCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	[JIFPDEDMPGC]
	private MFCBDCIMKGI PDPOLFACNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	[JIFPDEDMPGC]
	private HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private int KAAPHANLKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x2E031D0", Offset = "0x2E01BD0", VA = "0x182E031D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public bool FCANJHPHPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x78C540", Offset = "0x78AF40", VA = "0x18078C540", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x922440", Offset = "0x920E40", VA = "0x180922440", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x2E03020", Offset = "0x2E01A20", VA = "0x182E03020", Slot = "6")]
	public void BEJHKBIOAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x2E032D0", Offset = "0x2E01CD0", VA = "0x182E032D0", Slot = "7")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x2E03220", Offset = "0x2E01C20", VA = "0x182E03220", Slot = "8")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x2E03130", Offset = "0x2E01B30", VA = "0x182E03130")]
	private void CAKJGLDLDNH(DFKOJFHJBPL PMMCMCPNCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x2E03570", Offset = "0x2E01F70", VA = "0x182E03570", Slot = "4")]
	public bool IJGLPDIBFBE(AKLFKNOOHJC AOCEENCOLMM, JBNNELNIDOD OPPPBNFKNOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x2E03350", Offset = "0x2E01D50", VA = "0x182E03350", Slot = "5")]
	public void HBNKLMKLJKD(AKLFKNOOHJC AOCEENCOLMM, Span<JBNNELNIDOD> PDPOLFACNJC, bool FJBLBFMGAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x2E03020", Offset = "0x2E01A20", VA = "0x182E03020", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x2E03630", Offset = "0x2E02030", VA = "0x182E03630")]
	public DIEGDNAGEPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class DEJLCCMAEHM
{
	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x2E02A40", Offset = "0x2E01440", VA = "0x182E02A40")]
	public static void OGDBFDGJFAJ(this FCMEKODKCDO FNNADNFGBNJ, ReadOnlyMemory<byte> PFDMCNCHDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(RVA = "0x1D62E80", Offset = "0x1D61880", VA = "0x181D62E80")]
	public static void BPBNENCMAFM<T>(this FCMEKODKCDO FNNADNFGBNJ, in T MNIAGKNOHEJ) where T : struct, PHKDHEJMAMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x1D62FB0", Offset = "0x1D619B0", VA = "0x181D62FB0")]
	public static T DDOEEOLDMCC<T>(this FCMEKODKCDO FNNADNFGBNJ) where T : struct, PHKDHEJMAMA
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x2E02830", Offset = "0x2E01230", VA = "0x182E02830")]
	public static void BPBNENCMAFM(this FCMEKODKCDO FNNADNFGBNJ, FIGJEGKDICC PJOLHEJCFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x2E02A10", Offset = "0x2E01410", VA = "0x182E02A10")]
	public static FIGJEGKDICC KHJDIHHMCCF(this FCMEKODKCDO FNNADNFGBNJ)
	{
		return default(FIGJEGKDICC);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x2E02860", Offset = "0x2E01260", VA = "0x182E02860")]
	public static void FBPBIGHJGJL(this FCMEKODKCDO LHGJJBFKNCG, uint NOPKLKIGFGO, bool GBPAFLONCMB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x2E02AC0", Offset = "0x2E014C0", VA = "0x182E02AC0")]
	public static uint OKPKJLKMIOF(this FCMEKODKCDO ALGAFFHCPAP, bool GBPAFLONCMB = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public static class LIBCHPMEOBC
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class LILMBDICLNL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public LILMBDICLNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x2560680", Offset = "0x255F080", VA = "0x182560680")]
		internal void <GetByteEnumDelegates>b__0(FCMEKODKCDO b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x25606F0", Offset = "0x255F0F0", VA = "0x1825606F0")]
		internal T <GetByteEnumDelegates>b__1(FCMEKODKCDO b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class GIKHOCNOFPJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public GIKHOCNOFPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x312A2C0", Offset = "0x3128CC0", VA = "0x18312A2C0")]
		internal void <GetSByteEnumDelegates>b__0(FCMEKODKCDO b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x312A330", Offset = "0x3128D30", VA = "0x18312A330")]
		internal T <GetSByteEnumDelegates>b__1(FCMEKODKCDO b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private sealed class LAEFEHDNGON<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public LAEFEHDNGON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA1F0", Offset = "0x1FE8BF0", VA = "0x181FEA1F0")]
		internal void <GetShortEnumDelegates>b__0(FCMEKODKCDO b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA260", Offset = "0x1FE8C60", VA = "0x181FEA260")]
		internal T <GetShortEnumDelegates>b__1(FCMEKODKCDO b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class MFNCAAIPGEG<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public MFNCAAIPGEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x2B13560", Offset = "0x2B11F60", VA = "0x182B13560")]
		internal void <GetUShortEnumDelegates>b__0(FCMEKODKCDO b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x2B135D0", Offset = "0x2B11FD0", VA = "0x182B135D0")]
		internal T <GetUShortEnumDelegates>b__1(FCMEKODKCDO b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class DPEHPFFIJGN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public DPEHPFFIJGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x32A9900", Offset = "0x32A8300", VA = "0x1832A9900")]
		internal void <GetIntEnumDelegates>b__0(FCMEKODKCDO b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x32A9960", Offset = "0x32A8360", VA = "0x1832A9960")]
		internal T <GetIntEnumDelegates>b__1(FCMEKODKCDO b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class FBMHCJKJBME<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public FBMHCJKJBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x29FF600", Offset = "0x29FE000", VA = "0x1829FF600")]
		internal void <GetUIntEnumDelegates>b__0(FCMEKODKCDO b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x29FF660", Offset = "0x29FE060", VA = "0x1829FF660")]
		internal T <GetUIntEnumDelegates>b__1(FCMEKODKCDO b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x25DF120", Offset = "0x25DDB20", VA = "0x1825DF120")]
	public static void NAJOPPPCEBF<T>(T MMCAICBMAII, T OPOPHNBOOKJ, out global::GAPEKLNJAML<T> LFOFFGNOMMG, out global::NFJCIIMFIEB<T> HKKBLICHOFH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x25DEFD0", Offset = "0x25DD9D0", VA = "0x1825DEFD0")]
	private static void MDPFJCMDLGN<T>(T MMCAICBMAII, T OPOPHNBOOKJ, out global::GAPEKLNJAML<T> LFOFFGNOMMG, out global::NFJCIIMFIEB<T> HKKBLICHOFH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x25DEFD0", Offset = "0x25DD9D0", VA = "0x1825DEFD0")]
	private static void PPBEJIKFAMA<T>(T MMCAICBMAII, T OPOPHNBOOKJ, out global::GAPEKLNJAML<T> LFOFFGNOMMG, out global::NFJCIIMFIEB<T> HKKBLICHOFH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x25DED30", Offset = "0x25DD730", VA = "0x1825DED30")]
	private static void BOEIDJLDEGO<T>(T MMCAICBMAII, T OPOPHNBOOKJ, out global::GAPEKLNJAML<T> LFOFFGNOMMG, out global::NFJCIIMFIEB<T> HKKBLICHOFH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x25DED30", Offset = "0x25DD730", VA = "0x1825DED30")]
	private static void HNFHABCCLCA<T>(T MMCAICBMAII, T OPOPHNBOOKJ, out global::GAPEKLNJAML<T> LFOFFGNOMMG, out global::NFJCIIMFIEB<T> HKKBLICHOFH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x25DEE80", Offset = "0x25DD880", VA = "0x1825DEE80")]
	private static void EIPAGMKFBEE<T>(T MMCAICBMAII, T OPOPHNBOOKJ, out global::GAPEKLNJAML<T> LFOFFGNOMMG, out global::NFJCIIMFIEB<T> HKKBLICHOFH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x25DEE80", Offset = "0x25DD880", VA = "0x1825DEE80")]
	private static void HBMJIGDIAMC<T>(T MMCAICBMAII, T OPOPHNBOOKJ, out global::GAPEKLNJAML<T> LFOFFGNOMMG, out global::NFJCIIMFIEB<T> HKKBLICHOFH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public abstract class BDIOFIHEEJL : JDLAEJBBJBL, PKBAIAJJFPF
{
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1050", Offset = "0x2DEFA50", VA = "0x182DF1050", Slot = "4")]
	private void HGGCPBBJCOJ(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void KMICFGAIOMN(DOHECIMNHKO PDPOLFACNJC);

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
	protected BDIOFIHEEJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[COOJPHDNGHI(typeof(LocalPoseData))]
public sealed class CNGIBIHCDBL : BDIOFIHEEJL
{
	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4950", Offset = "0x2DF3350", VA = "0x182DF4950", Slot = "5")]
	protected override void KMICFGAIOMN(DOHECIMNHKO PDPOLFACNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
	public CNGIBIHCDBL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[LOEOGANCBGC(EDPDLGMLNHJ.Scope)]
	internal class CopyAuthorityToEntity : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private EntityQuery ACDKGJLCOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private EntityQuery CEPFNNLNFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private EntityQuery HJEJCIHGFEI;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFD000", Offset = "0x2DFBA00", VA = "0x182DFD000", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFD300", Offset = "0x2DFBD00", VA = "0x182DFD300", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFD480", Offset = "0x2DFBE80", VA = "0x182DFD480", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x2DFD450", Offset = "0x2DFBE50", VA = "0x182DFD450", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC630", Offset = "0x2DFB030", VA = "0x182DFC630")]
		private void CMDFFKCOBIF(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x2DFCC50", Offset = "0x2DFB650", VA = "0x182DFCC50")]
		private void DLKFIEDBGEA(NativeArray<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC970", Offset = "0x2DFB370", VA = "0x182DFC970")]
		private void DHOFDHIIKGM(NativeArray<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x2DFD070", Offset = "0x2DFBA70", VA = "0x182DFD070")]
		private void MJAPCHMPGLA(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x2DFCDF0", Offset = "0x2DFB7F0", VA = "0x182DFCDF0")]
		private void EHBOLALIDCF(NativeArray<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x2DFD220", Offset = "0x2DFBC20", VA = "0x182DFD220")]
		private void MLCODOGGCFB(DFKOJFHJBPL PMMCMCPNCLD, int OACKGFKLPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public CopyAuthorityToEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal class FNNMGOLNJPI : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EntityQuery CAMLCFELNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private LFIFNADKAEF EDFOBNPNANH;

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x2C19470", Offset = "0x2C17E70", VA = "0x182C19470", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0x2C194C0", Offset = "0x2C17EC0", VA = "0x182C194C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x2C19580", Offset = "0x2C17F80", VA = "0x182C19580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x2C18E90", Offset = "0x2C17890", VA = "0x182C18E90")]
	private void FJJKMCFHENF(NativeArray<Entity> CGCCIONMJJA, NativeList<Entity> CDMMCLCBLOL, ComponentDataFromEntity<FCBEJMBJNHK> JHMHGDPHIKG, BufferFromEntity<ChildrenData> BDCAEOPLPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public FNNMGOLNJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public class LMHPBBOPOAA : ParentSystemBase<AuthoredParentData, ODAFCNOHOHL, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x2C33730", Offset = "0x2C32130", VA = "0x182C33730", Slot = "14")]
	protected override EntityQueryDesc HOOHEPPJBOH(EntityQueryDesc CAMLCFELNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x76C6B0", Offset = "0x76B0B0", VA = "0x18076C6B0", Slot = "15")]
	protected override EntityQueryDesc KHNLBLBIGEO(EntityQueryDesc CAMLCFELNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x2C337B0", Offset = "0x2C321B0", VA = "0x182C337B0", Slot = "16")]
	protected override EntityQueryDesc OMGFLMJLKFK(EntityQueryDesc CAMLCFELNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x2C33770", Offset = "0x2C32170", VA = "0x182C33770", Slot = "17")]
	protected override EntityQueryDesc JICLHGAFPOJ(EntityQueryDesc CAMLCFELNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x2C33830", Offset = "0x2C32230", VA = "0x182C33830")]
	public LMHPBBOPOAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x2C337F0", Offset = "0x2C321F0", VA = "0x182C337F0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class JCHBKBJMOBH : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private EntityQuery CAMLCFELNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private object OIBANLOBFAD;

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x2C2A280", Offset = "0x2C28C80", VA = "0x182C2A280", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x2C2A300", Offset = "0x2C28D00", VA = "0x182C2A300", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x2C2A3A0", Offset = "0x2C28DA0", VA = "0x182C2A3A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public JCHBKBJMOBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class PGFEFIJIIML : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private EntityQuery CAMLCFELNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	private object OIBANLOBFAD;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAB40", Offset = "0x2AF9540", VA = "0x182AFAB40", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x2AFABC0", Offset = "0x2AF95C0", VA = "0x182AFABC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAC60", Offset = "0x2AF9660", VA = "0x182AFAC60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public PGFEFIJIIML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[InternalBufferCapacity(1)]
internal struct LLFKPEOPMLA : ISystemStateBufferElementData, IBufferElementData, IEquatable<LLFKPEOPMLA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public DJHDBFKHFCB BIONDBIGACN;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x2C32F50", Offset = "0x2C31950", VA = "0x182C32F50", Slot = "4")]
	public bool Equals(LLFKPEOPMLA DFHJPOKNFFB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE00", Offset = "0x7DE800", VA = "0x1807DFE00")]
	public static LLFKPEOPMLA EGMKMIPNLBF(DJHDBFKHFCB BIONDBIGACN)
	{
		return default(LLFKPEOPMLA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[InternalBufferCapacity(4)]
internal struct BPKFIPDNOMC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public DJHDBFKHFCB BIONDBIGACN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x7DFE00", Offset = "0x7DE800", VA = "0x1807DFE00")]
	public static BPKFIPDNOMC EGMKMIPNLBF(DJHDBFKHFCB BIONDBIGACN)
	{
		return default(BPKFIPDNOMC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal abstract class OKEBJJPBFKF : LMHPBLKGIKP
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x2AECF00", Offset = "0x2AEB900", VA = "0x182AECF00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x2AED090", Offset = "0x2AEBA90", VA = "0x182AED090", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x2AED130", Offset = "0x2AEBB30", VA = "0x182AED130")]
	protected OKEBJJPBFKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[GCANBDAKNID]
internal abstract class LMHPBLKGIKP : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	protected EntityQuery CAMLCFELNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	protected HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	protected GHMLCJKOGGN MPLGHJJKMAH;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected abstract LHAMFCENGBB IBKJLLCHEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x2C33AF0", Offset = "0x2C324F0", VA = "0x182C33AF0", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x2C33BD0", Offset = "0x2C325D0", VA = "0x182C33BD0")]
	protected void PADPOIHEAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x2C33870", Offset = "0x2C32270", VA = "0x182C33870")]
	protected void BFDIPPPBNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x2C33B60", Offset = "0x2C32560", VA = "0x182C33B60")]
	protected EIIMNNHCANF NLDGPBDKNBB()
	{
		return default(EIIMNNHCANF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	protected LMHPBLKGIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal abstract class CBHHPMPAPFC : LMHPBLKGIKP
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3BE0", Offset = "0x2DF25E0", VA = "0x182DF3BE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3D70", Offset = "0x2DF2770", VA = "0x182DF3D70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x2AED130", Offset = "0x2AEBB30", VA = "0x182AED130")]
	protected CBHHPMPAPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class GGJICBMEPKM : LMHPBLKGIKP
{
	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A6F0", Offset = "0x2C190F0", VA = "0x182C1A6F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A800", Offset = "0x2C19200", VA = "0x182C1A800", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	protected GGJICBMEPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class JMGJLPFHGJH : OKEBJJPBFKF
{
	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	protected override LHAMFCENGBB IBKJLLCHEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x2C2B700", Offset = "0x2C2A100", VA = "0x182C2B700", Slot = "15")]
		get
		{
			return default(LHAMFCENGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x2AFBBA0", Offset = "0x2AFA5A0", VA = "0x182AFBBA0")]
	public JMGJLPFHGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class PLCPAACADMG : CBHHPMPAPFC
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	protected override LHAMFCENGBB IBKJLLCHEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x2AFBB30", Offset = "0x2AFA530", VA = "0x182AFBB30", Slot = "15")]
		get
		{
			return default(LHAMFCENGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x2AFBBA0", Offset = "0x2AFA5A0", VA = "0x182AFBBA0")]
	public PLCPAACADMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class HIACLBBLDNI : GGJICBMEPKM
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	protected override LHAMFCENGBB IBKJLLCHEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x2C1EE00", Offset = "0x2C1D800", VA = "0x182C1EE00", Slot = "15")]
		get
		{
			return default(LHAMFCENGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public HIACLBBLDNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class EAFGNPHKNCJ : OKEBJJPBFKF
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	protected override LHAMFCENGBB IBKJLLCHEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x2E05210", Offset = "0x2E03C10", VA = "0x182E05210", Slot = "15")]
		get
		{
			return default(LHAMFCENGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x2AFBBA0", Offset = "0x2AFA5A0", VA = "0x182AFBBA0")]
	public EAFGNPHKNCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class EFALMEFIHNB : CBHHPMPAPFC
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected override LHAMFCENGBB IBKJLLCHEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x2E065A0", Offset = "0x2E04FA0", VA = "0x182E065A0", Slot = "15")]
		get
		{
			return default(LHAMFCENGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x2AED130", Offset = "0x2AEBB30", VA = "0x182AED130")]
	public EFALMEFIHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class PDKEHPADMDO : GGJICBMEPKM
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected override LHAMFCENGBB IBKJLLCHEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAA70", Offset = "0x2AF9470", VA = "0x182AFAA70", Slot = "15")]
		get
		{
			return default(LHAMFCENGBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x2AED130", Offset = "0x2AEBB30", VA = "0x182AED130")]
	public PDKEHPADMDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct DBGHOOEFNFA : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct MINLAEPOMLO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct NIAOLJPGHCB : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public readonly struct LHAMFCENGBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly ComponentType NIAMNELIJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly ComponentType EKEDPKMICKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly object DEGCIHEAIBD;

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x2C32750", Offset = "0x2C31150", VA = "0x182C32750")]
	public LHAMFCENGBB(ComponentType NIAMNELIJLG, ComponentType EKEDPKMICKJ, object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x25DE8C0", Offset = "0x25DD2C0", VA = "0x1825DE8C0")]
	public static LHAMFCENGBB KHECJIFKKPO<TReq, TTag>(object DEGCIHEAIBD)
	{
		return default(LHAMFCENGBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public static class EMLBAINFBAI
{
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public const string HALEFGBBMKI = "Parented";

	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public const string KAOHNKFLPFB = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly LHAMFCENGBB EKALPMIIDFP;

	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	public static readonly LHAMFCENGBB DBEHOHMACOB;
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct DJHDBFKHFCB : global::HFJJIJCEKGL<DJHDBFKHFCB>, HOKCJDBMKAA, IEquatable<DJHDBFKHFCB>
{
	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int FOHLPAKJEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x772D90", Offset = "0x771790", VA = "0x180772D90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int BNNADFINGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x88A590", Offset = "0x888F90", VA = "0x18088A590", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xEA60A0", Offset = "0xEA4AA0", VA = "0x180EA60A0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public bool MPANJOCJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x2E03BB0", Offset = "0x2E025B0", VA = "0x182E03BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x2E03B60", Offset = "0x2E02560", VA = "0x182E03B60", Slot = "8")]
	public bool Equals(DJHDBFKHFCB DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x2E03BF0", Offset = "0x2E025F0", VA = "0x182E03BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[GCANBDAKNID]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[LOEOGANCBGC(EDPDLGMLNHJ.Connectables)]
	public class UpdateConnectableVisuals : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		private struct KHJKHNJHGGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public DJHDBFKHFCB BIONDBIGACN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public float3 OAALNDIAAOB;

			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0x3FF5EC0", Offset = "0x3FF48C0", VA = "0x183FF5EC0")]
			public KHJKHNJHGGO(DJHDBFKHFCB BIONDBIGACN, float3 OAALNDIAAOB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x3FF5EA0", Offset = "0x3FF48A0", VA = "0x183FF5EA0")]
			public void LEMACGHMFAF(out DJHDBFKHFCB BIONDBIGACN, out float3 OAALNDIAAOB)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct KEODLMHLKDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public NativeList<KHJKHNJHGGO> list;

			[Cpp2IlInjected.Token(Token = "0x6000789")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
			public KEODLMHLKDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078A")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<BPKFIPDNOMC> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private struct BNCLELPKFED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			public NativeList<KHJKHNJHGGO> list;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
			public BNCLELPKFED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<LLFKPEOPMLA> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private struct FOEFHFPMMLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public NativeList<KHJKHNJHGGO> list;

			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
			public FOEFHFPMMLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in DJMNNLBIEOG com, in DynamicBuffer<LLFKPEOPMLA> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct HFONDNGJAIE : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			private struct PLHIGBPJMED
			{
				[Cpp2IlInjected.Token(Token = "0x20000E6")]
				public struct LOOEMJFJDFB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D1")]
					public LambdaParameterValueProvider_Entity.Runtime GOMPAMBNHKE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002D2")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime LKLFFFGJLFM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002D3")]
					public LambdaParameterValueProvider_DynamicBuffer<BPKFIPDNOMC>.Runtime ICJNPGJPMEN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002CE")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity ONOBANIBHPN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40002CF")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> GHHOHJLPMCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x40002D0")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<BPKFIPDNOMC> HNANBKLJBLA;

				[Cpp2IlInjected.Token(Token = "0x6000796")]
				[Cpp2IlInjected.Address(RVA = "0x3FFA4B0", Offset = "0x3FF8EB0", VA = "0x183FFA4B0")]
				public void DMNACDEGIGE(UpdateConnectableVisuals PIJJDNMKBBD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000797")]
				[Cpp2IlInjected.Address(RVA = "0x3FFA530", Offset = "0x3FF8F30", VA = "0x183FFA530")]
				public LOOEMJFJDFB KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
				{
					return default(LOOEMJFJDFB);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public UpdateConnectableVisuals ALMIJAPBMBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public NativeList<KHJKHNJHGGO> OKDFPKLCDDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			private PLHIGBPJMED NNPBNEEGOKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe PLHIGBPJMED.LOOEMJFJDFB* BEIHMNNJOAB;

			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IMKGCCNGKJM;

			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2110", Offset = "0x3FF0B10", VA = "0x183FF2110")]
			internal void EJGOAEBMHCL(Entity GOANOLJBHPF, WorldPoseData CANAECPNINK, in DynamicBuffer<BPKFIPDNOMC> MKPFHFLNAEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x3FF25E0", Offset = "0x3FF0FE0", VA = "0x183FF25E0", Slot = "5")]
			public void ReadFromDisplayClass(ref KEODLMHLKDD LAJFEJAHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2610", Offset = "0x3FF1010", VA = "0x183FF2610", Slot = "6")]
			public void WriteToDisplayClass(ref KEODLMHLKDD LAJFEJAHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2350", Offset = "0x3FF0D50", VA = "0x183FF2350", Slot = "4")]
			public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x3FF24A0", Offset = "0x3FF0EA0", VA = "0x183FF24A0")]
			public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, ref PLHIGBPJMED.LOOEMJFJDFB DNOHEDJMLNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x3FF20D0", Offset = "0x3FF0AD0", VA = "0x183FF20D0")]
			public void DMNACDEGIGE(UpdateConnectableVisuals PIJJDNMKBBD, ref KEODLMHLKDD LAJFEJAHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2430", Offset = "0x3FF0E30", VA = "0x183FF2430")]
			public unsafe static void IDLGLLJOIMC(ArchetypeChunkIterator* MBPLNPAGJMC, void* MAKNNDOILNI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct ABKNKKEIMFB : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			private struct ILMCALMJNJC
			{
				[Cpp2IlInjected.Token(Token = "0x20000E9")]
				[NoAlias]
				public struct DOJKEALHBOC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002D9")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime LKLFFFGJLFM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002DA")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<LLFKPEOPMLA>.Runtime ICJNPGJPMEN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002D7")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> GHHOHJLPMCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002D8")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<LLFKPEOPMLA> HNANBKLJBLA;

				[Cpp2IlInjected.Token(Token = "0x600079D")]
				[Cpp2IlInjected.Address(RVA = "0x3FF46A0", Offset = "0x3FF30A0", VA = "0x183FF46A0")]
				public void DMNACDEGIGE(UpdateConnectableVisuals PIJJDNMKBBD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600079E")]
				[Cpp2IlInjected.Address(RVA = "0x3FF4710", Offset = "0x3FF3110", VA = "0x183FF4710")]
				public DOJKEALHBOC KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
				{
					return default(DOJKEALHBOC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			public NativeList<KHJKHNJHGGO> OKDFPKLCDDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			private ILMCALMJNJC NNPBNEEGOKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe ILMCALMJNJC.DOJKEALHBOC* BEIHMNNJOAB;

			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x3FEEA10", Offset = "0x3FED410", VA = "0x183FEEA10")]
			internal void EJGOAEBMHCL(in WorldPoseData CANAECPNINK, in DynamicBuffer<LLFKPEOPMLA> MKPFHFLNAEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0x11488C0", Offset = "0x11472C0", VA = "0x1811488C0", Slot = "5")]
			public void ReadFromDisplayClass(ref BNCLELPKFED LAJFEJAHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0x3FEEB20", Offset = "0x3FED520", VA = "0x183FEEB20", Slot = "4")]
			public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x3FEEBF0", Offset = "0x3FED5F0", VA = "0x183FEEBF0")]
			public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, [NoAlias] ref ILMCALMJNJC.DOJKEALHBOC DNOHEDJMLNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0x3FEE970", Offset = "0x3FED370", VA = "0x183FEE970")]
			public void DMNACDEGIGE(UpdateConnectableVisuals PIJJDNMKBBD, ref BNCLELPKFED LAJFEJAHEJB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct BEOCNECDBHF : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000EB")]
			private struct NODPAAMOHNL
			{
				[Cpp2IlInjected.Token(Token = "0x20000EC")]
				[NoAlias]
				public struct FGJNNOJDMAH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40002E1")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime LKLFFFGJLFM;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40002E2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<DJMNNLBIEOG>.Runtime BOIAEHIAEKD;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40002E3")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<LLFKPEOPMLA>.Runtime ICJNPGJPMEN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40002DE")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> GHHOHJLPMCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40002DF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<DJMNNLBIEOG> GOPCJEAEAIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40002E0")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<LLFKPEOPMLA> HNANBKLJBLA;

				[Cpp2IlInjected.Token(Token = "0x60007A4")]
				[Cpp2IlInjected.Address(RVA = "0x3FF8A30", Offset = "0x3FF7430", VA = "0x183FF8A30")]
				public void DMNACDEGIGE(UpdateConnectableVisuals PIJJDNMKBBD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007A5")]
				[Cpp2IlInjected.Address(RVA = "0x3FF8AC0", Offset = "0x3FF74C0", VA = "0x183FF8AC0")]
				public FGJNNOJDMAH KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
				{
					return default(FGJNNOJDMAH);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public NativeList<KHJKHNJHGGO> OKDFPKLCDDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private NODPAAMOHNL NNPBNEEGOKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NODPAAMOHNL.FGJNNOJDMAH* BEIHMNNJOAB;

			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x3FEF560", Offset = "0x3FEDF60", VA = "0x183FEF560")]
			internal void EJGOAEBMHCL(in WorldPoseData CANAECPNINK, in DJMNNLBIEOG BJHIIPFMCHA, in DynamicBuffer<LLFKPEOPMLA> MKPFHFLNAEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x11488C0", Offset = "0x11472C0", VA = "0x1811488C0", Slot = "5")]
			public void ReadFromDisplayClass(ref FOEFHFPMMLK LAJFEJAHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x3FEF6C0", Offset = "0x3FEE0C0", VA = "0x183FEF6C0", Slot = "4")]
			public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x3FEF740", Offset = "0x3FEE140", VA = "0x183FEF740")]
			public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, [NoAlias] ref NODPAAMOHNL.FGJNNOJDMAH DNOHEDJMLNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x3FEF520", Offset = "0x3FEDF20", VA = "0x183FEF520")]
			public void DMNACDEGIGE(UpdateConnectableVisuals PIJJDNMKBBD, ref FOEFHFPMMLK LAJFEJAHEJB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private EntityQuery OPFFJGGEKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery EKDPHBOMFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery CEAOLBJKDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery LPFJKFBPIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery BKLMGADKOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private EntityQuery PIJKBCFEPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private EntityQuery LIIEEFBLCBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private EntityQuery OONIPBJMCDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery DMBEFMEJOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery JHJIOPACKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private global::PJDAAKMMIMP<DJHDBFKHFCB, OILFFIBNFMI> HPEGHDNONKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private CPMCACBEBDN GMKCGHFBHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private DGINFINNHOA KGLBMDPKPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private DJAEBDNKOIG FAOBHJFCICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private EntityQuery GLIEMMLNMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private ProfilerMarker MDOGMAFFHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery KGEJMFPJEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery DHFBJGMCAOO;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public int HPEOPAJJAFB
		{
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x2C0E6B0", Offset = "0x2C0D0B0", VA = "0x182C0E6B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C180", Offset = "0x2C0AB80", VA = "0x182C0C180")]
		internal OILFFIBNFMI BKDAHLHJGHN(DJHDBFKHFCB BIONDBIGACN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E0F0", Offset = "0x2C0CAF0", VA = "0x182C0E0F0", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F6D0", Offset = "0x2C0E0D0", VA = "0x182C0F6D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F950", Offset = "0x2C0E350", VA = "0x182C0F950", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x2C0FAE0", Offset = "0x2C0E4E0", VA = "0x182C0FAE0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F910", Offset = "0x2C0E310", VA = "0x182C0F910", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x2C0CFA0", Offset = "0x2C0B9A0", VA = "0x182C0CFA0")]
		private void DCIJLAFNHID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x2C0DD20", Offset = "0x2C0C720", VA = "0x182C0DD20")]
		private void FGBDGIJENDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x2C0D110", Offset = "0x2C0BB10", VA = "0x182C0D110")]
		private void DKAACKCJPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x2C0FB20", Offset = "0x2C0E520", VA = "0x182C0FB20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x2C0BCA0", Offset = "0x2C0A6A0", VA = "0x182C0BCA0")]
		private void BBFMMOJDOFP(EntityQuery ACDKGJLCOEC, EntityQuery JHMHIFHEEJH, EntityQuery CEPFNNLNFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F4A0", Offset = "0x2C0DEA0", VA = "0x182C0F4A0")]
		private void OLCIACFECIH(EntityQuery CEPFNNLNFOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x2C0FC50", Offset = "0x2C0E650", VA = "0x182C0FC50")]
		private void PACMKNJEKIN(NativeArrayAsync<Entity> MAOBNHICFHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x2C0D4C0", Offset = "0x2C0BEC0", VA = "0x182C0D4C0")]
		private void DNNNPCKEAAC(NativeArrayAsync<Entity> IFJIHFMLODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x2C0BB00", Offset = "0x2C0A500", VA = "0x182C0BB00")]
		private void BAHKOHBOKHM(NativeArrayAsync<Entity> GEHMNHOPPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x2C0ED30", Offset = "0x2C0D730", VA = "0x182C0ED30")]
		private void LIBKIKAJLJD(NativeList<DJHDBFKHFCB> LKLKJBCNMKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x2C0CA80", Offset = "0x2C0B480", VA = "0x182C0CA80")]
		private NativeList<DJHDBFKHFCB> CNNOHEDACAD(NativeArray<Entity> CGCCIONMJJA)
		{
			return default(NativeList<DJHDBFKHFCB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x2C0D5D0", Offset = "0x2C0BFD0", VA = "0x182C0D5D0")]
		private void EEFFNJOENJB(NativeArray<Entity> CGCCIONMJJA, NativeList<DJHDBFKHFCB> LKLKJBCNMKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x2C0EEA0", Offset = "0x2C0D8A0", VA = "0x182C0EEA0")]
		private void MKKDAAFFKLH(NativeArray<Entity> MJJGHKAOJNC, NativeArray<Entity> LGFJBKEAKEO, NativeList<DJHDBFKHFCB> KNBEMOIPCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E880", Offset = "0x2C0D280", VA = "0x182C0E880")]
		private void KIFAICANBDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x2C0DFB0", Offset = "0x2C0C9B0", VA = "0x182C0DFB0")]
		private NativeListAsync<KHJKHNJHGGO> GCGAJECPGAM(EntityQuery CAMLCFELNDE, Func<NativeList<KHJKHNJHGGO>, JobHandle> ONMBCPBDAOG)
		{
			return default(NativeListAsync<KHJKHNJHGGO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E6F0", Offset = "0x2C0D0F0", VA = "0x182C0E6F0")]
		private JobHandle KIBBDKIGDNG(NativeList<KHJKHNJHGGO> OKDFPKLCDDM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x2C0DE70", Offset = "0x2C0C870", VA = "0x182C0DE70")]
		private JobHandle FPMEHMHNALL(NativeList<KHJKHNJHGGO> OKDFPKLCDDM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x2C0DBF0", Offset = "0x2C0C5F0", VA = "0x182C0DBF0")]
		private JobHandle FAMIHKNPFDH(NativeList<KHJKHNJHGGO> OKDFPKLCDDM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E1B0", Offset = "0x2C0CBB0", VA = "0x182C0E1B0")]
		private void HICGGBKFNAM(NativeListAsync<KHJKHNJHGGO> OKDFPKLCDDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C1D0", Offset = "0x2C0ABD0", VA = "0x182C0C1D0")]
		private void BPEGCPHBGCC(NativeListAsync<KHJKHNJHGGO> OKDFPKLCDDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x2C0D0B0", Offset = "0x2C0BAB0", VA = "0x182C0D0B0")]
		private bool DECJMHEHNKA(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F3D0", Offset = "0x2C0DDD0", VA = "0x182C0F3D0")]
		private NativeArray<Entity> NAKBAAIPAFF(Entity GOANOLJBHPF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C8C0", Offset = "0x2C0B2C0", VA = "0x182C0C8C0")]
		private DJHDBFKHFCB CJJMOPJFPHG(NativeList<DJHDBFKHFCB> KNBEMOIPCBK)
		{
			return default(DJHDBFKHFCB);
		}

		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x2C0BA70", Offset = "0x2C0A470", VA = "0x182C0BA70")]
		private void AFEBAFBEDGE(DJHDBFKHFCB BIONDBIGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F570", Offset = "0x2C0DF70", VA = "0x182C0F570", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C460", Offset = "0x2C0AE60", VA = "0x182C0C460")]
		public static EntityQuery CGAKLPGLMLI(ComponentSystemBase PIJJDNMKBBD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x2C0C660", Offset = "0x2C0B060", VA = "0x182C0C660")]
		public static EntityQuery CILJJLHNAMB(ComponentSystemBase PIJJDNMKBBD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x2C0E440", Offset = "0x2C0CE40", VA = "0x182C0E440")]
		public static EntityQuery IOKOKFJIJCF(ComponentSystemBase PIJJDNMKBBD)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[LOEOGANCBGC(EDPDLGMLNHJ.ConfigUI)]
	public sealed class PropagateContainerNameChangeToObjectBoard : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private EntityQuery CAMLCFELNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private LAIKDFLJMKI HKHMGAMGNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private IBAGHJGNPCO IAFNLEMBNNM;

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x2B01CF0", Offset = "0x2B006F0", VA = "0x182B01CF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x2B01C60", Offset = "0x2B00660", VA = "0x182B01C60", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0x2B01DF0", Offset = "0x2B007F0", VA = "0x182B01DF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public PropagateContainerNameChangeToObjectBoard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public class DBECMJFGJAI : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	public HBIBAGENGHJ MIDDDIBGPID;

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public DBECMJFGJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
	public DBECMJFGJAI(HBIBAGENGHJ MIDDDIBGPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x2E01690", Offset = "0x2E00090", VA = "0x182E01690", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public abstract class HJLMACIJNAK : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	private ObjectEmbodimentService CHJAOAHKKML;

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F260", Offset = "0x2C1DC60", VA = "0x182C1F260", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F2C0", Offset = "0x2C1DCC0", VA = "0x182C1F2C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x2C1F2F0", Offset = "0x2C1DCF0", VA = "0x182C1F2F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	protected HJLMACIJNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class JAEMCNMCCLN : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private EntityQuery MOINFJCBIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery LMKOILCEPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private EntityQuery MFHDHKJDPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private EntityQuery CJAKOPDMCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private ObjectEmbodimentService KIDMNGPKNEC;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public int PPFFIKBMELP
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C26F70", Offset = "0x2C25970", VA = "0x182C26F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int OLGGKIKIIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x2C26F60", Offset = "0x2C25960", VA = "0x182C26F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x2C26FD0", Offset = "0x2C259D0", VA = "0x182C26FD0", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x2C275F0", Offset = "0x2C25FF0", VA = "0x182C275F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x2C277F0", Offset = "0x2C261F0", VA = "0x182C277F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(RVA = "0x2C272C0", Offset = "0x2C25CC0", VA = "0x182C272C0")]
	public int MPPANIDCDOM(SceneTag BBIKMOACHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x2C27370", Offset = "0x2C25D70", VA = "0x182C27370")]
	public int NGKAKFLJHOE(SceneTag BBIKMOACHCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x2C27390", Offset = "0x2C25D90", VA = "0x182C27390")]
	protected void NJDDIKMIIJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x2C27160", Offset = "0x2C25B60", VA = "0x182C27160")]
	protected void JBDGDPOMHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x2C27270", Offset = "0x2C25C70", VA = "0x182C27270")]
	public NativeArrayAsync<Entity> LJAOCBLBJED(SceneTag BBIKMOACHCN, Allocator GGPAKDMJHLJ = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x2C26F80", Offset = "0x2C25980", VA = "0x182C26F80")]
	public NativeArrayAsync<Entity> CMDPHNNLMDL(SceneTag BBIKMOACHCN, Allocator GGPAKDMJHLJ = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x2C272E0", Offset = "0x2C25CE0", VA = "0x182C272E0")]
	public bool NBBGGGMCKAP(SceneTag BBIKMOACHCN, out NativeArrayAsync<Entity> MIDDDIBGPID, Allocator GGPAKDMJHLJ = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x2C27100", Offset = "0x2C25B00", VA = "0x182C27100")]
	public bool HNGDLAAAHJE(Entity GOANOLJBHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x2C26EF0", Offset = "0x2C258F0", VA = "0x182C26EF0")]
	public HBIBAGENGHJ AAIHKAHGCAJ(Entity GOANOLJBHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C27030", Offset = "0x2C25A30", VA = "0x182C27030")]
	public bool HAAHLPEEGIO(Entity GOANOLJBHPF, out DBECMJFGJAI MIDDDIBGPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C275B0", Offset = "0x2C25FB0", VA = "0x182C275B0")]
	public void OLPJFPPHFAE(Entity GOANOLJBHPF, DBECMJFGJAI MIDDDIBGPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C270A0", Offset = "0x2C25AA0", VA = "0x182C270A0")]
	public bool HNDEOLJNCJF(Entity GOANOLJBHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("DEBUG_BUILD")]
	[Conditional("UNITY_EDITOR")]
	public void JKCNKCPCFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public JAEMCNMCCLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal class MEDMLIJPKOJ : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private EntityQuery KPNLNEPFBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private LFIFNADKAEF EDFOBNPNANH;

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5360", Offset = "0x2AE3D60", VA = "0x182AE5360", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x2AE53B0", Offset = "0x2AE3DB0", VA = "0x182AE53B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5470", Offset = "0x2AE3E70", VA = "0x182AE5470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x2603E40", Offset = "0x2602840", VA = "0x182603E40")]
	private bool PPFDJBEBBEH<TComponentData>(EntityQuery CAMLCFELNDE, out NativeArray<Entity> CGCCIONMJJA, out NativeArray<TComponentData> LODPHDEIJJI) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x2AE52F0", Offset = "0x2AE3CF0", VA = "0x182AE52F0")]
	public HBIBAGENGHJ AAIHKAHGCAJ(Entity GOANOLJBHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public MEDMLIJPKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Lifecycle)]
	public class SetInactiveEmbodiedObjectsWithHiddenTag : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private EntityQuery JBAJONEHFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private EntityQuery OGKCKJPHIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private EntityQuery JHAMEFICLMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private EntityQuery HJEJCIHGFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x2C01010", Offset = "0x2BFFA10", VA = "0x182C01010", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C010D0", Offset = "0x2BFFAD0", VA = "0x182C010D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C01300", Offset = "0x2BFFD00", VA = "0x182C01300", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C00FA0", Offset = "0x2BFF9A0", VA = "0x182C00FA0")]
		private void CPLOAHMOJFD(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x2C01060", Offset = "0x2BFFA60", VA = "0x182C01060")]
		private void OLCIACFECIH(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x2C01290", Offset = "0x2BFFC90", VA = "0x182C01290", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x2C00C40", Offset = "0x2BFF640", VA = "0x182C00C40")]
		private void ALMKIGHFILO(EntityQuery CAMLCFELNDE, bool MHJJEDNLELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public SetInactiveEmbodiedObjectsWithHiddenTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal sealed class BGKLCPFKHME : FOMCGHGDFHL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct HKALGCEJNDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		public HKALGCEJNDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
		internal void <OnUpdate>b__1(Entity splinePoint, SplinePointParentData splinePointParentData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct ELGKKKJNPNB : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		private struct KPHGJPMPHLH
		{
			[Cpp2IlInjected.Token(Token = "0x20000F8")]
			[NoAlias]
			public struct GLNPDHIIPJJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000303")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime OABCPNDJBFF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000304")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplineShapeData>.Runtime HMJANLHHDCA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000305")]
				[NoAlias]
				public LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup>.Runtime APEMFGOKHMC;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity DCLONPJDLLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000301")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplineShapeData> NPJCPBBIKCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			[NoAlias]
			private LambdaParameterValueProvider_DynamicBuffer<LinkedEntityGroup> MLDMKKOBDBM;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6150", Offset = "0x3FF4B50", VA = "0x183FF6150")]
			public void DMNACDEGIGE(BGKLCPFKHME PIJJDNMKBBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x3FF61D0", Offset = "0x3FF4BD0", VA = "0x183FF61D0")]
			public GLNPDHIIPJJ KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
			{
				return default(GLNPDHIIPJJ);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private KPHGJPMPHLH NNPBNEEGOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KPHGJPMPHLH.GLNPDHIIPJJ* BEIHMNNJOAB;

		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x2BF75B0", Offset = "0x2BF5FB0", VA = "0x182BF75B0")]
		internal void EJGOAEBMHCL(Entity MONEONMODDL, SplineShapeData PAGKANKNAEA, DynamicBuffer<LinkedEntityGroup> DFIIPKJNKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7610", Offset = "0x2BF6010", VA = "0x182BF7610", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7690", Offset = "0x2BF6090", VA = "0x182BF7690")]
		public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, [NoAlias] ref KPHGJPMPHLH.GLNPDHIIPJJ DNOHEDJMLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x2BF75A0", Offset = "0x2BF5FA0", VA = "0x182BF75A0")]
		public void DMNACDEGIGE(BGKLCPFKHME PIJJDNMKBBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct CKFOKCJEMHC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		private struct AEMCLAFOKJI
		{
			[Cpp2IlInjected.Token(Token = "0x20000FB")]
			[NoAlias]
			public struct IEPMGEALOLO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400030B")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime MJKIGJEBDPP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400030C")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime KOEGNMBBNJE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity FINJBDNOBOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> CKEJKEJCJHK;

			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x3FEECC0", Offset = "0x3FED6C0", VA = "0x183FEECC0")]
			public void DMNACDEGIGE(BGKLCPFKHME PIJJDNMKBBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x3FEED20", Offset = "0x3FED720", VA = "0x183FEED20")]
			public IEPMGEALOLO KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
			{
				return default(IEPMGEALOLO);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public BufferFromEntity<LinkedEntityGroup> DEIMBFAODFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private AEMCLAFOKJI NNPBNEEGOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe AEMCLAFOKJI.IEPMGEALOLO* BEIHMNNJOAB;

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x2BF6C70", Offset = "0x2BF5670", VA = "0x182BF6C70")]
		internal void EJGOAEBMHCL(Entity EJLMJOEHKAN, SplinePointParentData OEOBLDJKBKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x2BF6E20", Offset = "0x2BF5820", VA = "0x182BF6E20", Slot = "5")]
		public void ReadFromDisplayClass(ref HKALGCEJNDD LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x2BF6D00", Offset = "0x2BF5700", VA = "0x182BF6D00", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BF6D70", Offset = "0x2BF5770", VA = "0x182BF6D70")]
		public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, [NoAlias] ref AEMCLAFOKJI.IEPMGEALOLO DNOHEDJMLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BF6C30", Offset = "0x2BF5630", VA = "0x182BF6C30")]
		public void DMNACDEGIGE(BGKLCPFKHME PIJJDNMKBBD, ref HKALGCEJNDD LAJFEJAHEJB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private EntityQuery CAMLCFELNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private EntityQuery FFAOEMPKNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery HOJILDJHCLM;

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x2DF17A0", Offset = "0x2DF01A0", VA = "0x182DF17A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1850", Offset = "0x2DF0250", VA = "0x182DF1850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public BGKLCPFKHME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1500", Offset = "0x2DEFF00", VA = "0x182DF1500", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1200", Offset = "0x2DEFC00", VA = "0x182DF1200")]
	public static EntityQuery GHIOHFNMEMD(ComponentSystemBase PIJJDNMKBBD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x2DF13A0", Offset = "0x2DEFDA0", VA = "0x182DF13A0")]
	public static EntityQuery OLKDENKLCJK(ComponentSystemBase PIJJDNMKBBD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
public sealed class HMJAAKFENAB : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	private OCJBMLIKJMH BDCGBDOJMDM;

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x2C20E70", Offset = "0x2C1F870", VA = "0x182C20E70", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x2C20ED0", Offset = "0x2C1F8D0", VA = "0x182C20ED0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public HMJAAKFENAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class OGBKAAOIFMM : FOMCGHGDFHL, PKBAIAJJFPF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	[CompilerGenerated]
	private struct GLADJNPKOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public NativeList<LIOPPALECME> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public NativeList<MIIGEONEKIB> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public NativeList<LIOPPALECME> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		public GLADJNPKOPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, OGPCKNJKEMC previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
		internal void <OnUpdate>b__2(Entity entity, OGPCKNJKEMC previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct OBCMJJCEMMC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct JDJEMJLFKDA
		{
			[Cpp2IlInjected.Token(Token = "0x2000101")]
			[NoAlias]
			public struct FPCDONJMLBE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400031A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime GOMPAMBNHKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400031B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime DEPDJIBOLHF;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity ONOBANIBHPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> JNMJLOLMDDD;

			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x3FF48F0", Offset = "0x3FF32F0", VA = "0x183FF48F0")]
			public void DMNACDEGIGE(OGBKAAOIFMM PIJJDNMKBBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4950", Offset = "0x3FF3350", VA = "0x183FF4950")]
			public FPCDONJMLBE KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
			{
				return default(FPCDONJMLBE);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public NativeList<LIOPPALECME> PDJKBGIMOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private JDJEMJLFKDA NNPBNEEGOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JDJEMJLFKDA.FPCDONJMLBE* BEIHMNNJOAB;

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8D40", Offset = "0x3FF7740", VA = "0x183FF8D40")]
		internal void EJGOAEBMHCL(Entity GOANOLJBHPF, ParentData AIAOJCAJMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x11488C0", Offset = "0x11472C0", VA = "0x1811488C0", Slot = "5")]
		public void ReadFromDisplayClass(ref GLADJNPKOPN LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8DC0", Offset = "0x3FF77C0", VA = "0x183FF8DC0", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8E60", Offset = "0x3FF7860", VA = "0x183FF8E60")]
		public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, [NoAlias] ref JDJEMJLFKDA.FPCDONJMLBE DNOHEDJMLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8CB0", Offset = "0x3FF76B0", VA = "0x183FF8CB0")]
		public void DMNACDEGIGE(OGBKAAOIFMM PIJJDNMKBBD, ref GLADJNPKOPN LAJFEJAHEJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct FNAEGOMNKEL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct FIDHDIFPGPE
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct JJBPIGAMGKL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000322")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime GOMPAMBNHKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000323")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime DEPDJIBOLHF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000324")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<OGPCKNJKEMC>.Runtime PEPGMJOKBEL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity ONOBANIBHPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> JNMJLOLMDDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<OGPCKNJKEMC> CNCJCBLHANA;

			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x3FF17E0", Offset = "0x3FF01E0", VA = "0x183FF17E0")]
			public void DMNACDEGIGE(OGBKAAOIFMM PIJJDNMKBBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x3FF1860", Offset = "0x3FF0260", VA = "0x183FF1860")]
			public JJBPIGAMGKL KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
			{
				return default(JJBPIGAMGKL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public NativeList<MIIGEONEKIB> IEPHJABBOGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private FIDHDIFPGPE NNPBNEEGOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FIDHDIFPGPE.JJBPIGAMGKL* BEIHMNNJOAB;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1940", Offset = "0x3FF0340", VA = "0x183FF1940")]
		internal void EJGOAEBMHCL(Entity GOANOLJBHPF, ParentData AIAOJCAJMCP, OGPCKNJKEMC BOEPCGGJPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1BB0", Offset = "0x3FF05B0", VA = "0x183FF1BB0", Slot = "5")]
		public void ReadFromDisplayClass(ref GLADJNPKOPN LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1A00", Offset = "0x3FF0400", VA = "0x183FF1A00", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1AD0", Offset = "0x3FF04D0", VA = "0x183FF1AD0")]
		public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, [NoAlias] ref FIDHDIFPGPE.JJBPIGAMGKL DNOHEDJMLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x3FF1900", Offset = "0x3FF0300", VA = "0x183FF1900")]
		public void DMNACDEGIGE(OGBKAAOIFMM PIJJDNMKBBD, ref GLADJNPKOPN LAJFEJAHEJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct KKEHMDDCFEF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000106")]
		private struct ENEGFDABIJO
		{
			[Cpp2IlInjected.Token(Token = "0x2000107")]
			[NoAlias]
			public struct ANDEPJDIGFI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400032A")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime GOMPAMBNHKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400032B")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<OGPCKNJKEMC>.Runtime PEPGMJOKBEL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity ONOBANIBHPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<OGPCKNJKEMC> CNCJCBLHANA;

			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0x3FF15C0", Offset = "0x3FEFFC0", VA = "0x183FF15C0")]
			public void DMNACDEGIGE(OGBKAAOIFMM PIJJDNMKBBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x3FF1620", Offset = "0x3FF0020", VA = "0x183FF1620")]
			public ANDEPJDIGFI KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
			{
				return default(ANDEPJDIGFI);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public NativeList<LIOPPALECME> LCPIPHIFEJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private ENEGFDABIJO NNPBNEEGOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe ENEGFDABIJO.ANDEPJDIGFI* BEIHMNNJOAB;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x3FF5F70", Offset = "0x3FF4970", VA = "0x183FF5F70")]
		internal void EJGOAEBMHCL(Entity GOANOLJBHPF, OGPCKNJKEMC BOEPCGGJPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6140", Offset = "0x3FF4B40", VA = "0x183FF6140", Slot = "5")]
		public void ReadFromDisplayClass(ref GLADJNPKOPN LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x3FF5FF0", Offset = "0x3FF49F0", VA = "0x183FF5FF0", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6090", Offset = "0x3FF4A90", VA = "0x183FF6090")]
		public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, [NoAlias] ref ENEGFDABIJO.ANDEPJDIGFI DNOHEDJMLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x3FF5EE0", Offset = "0x3FF48E0", VA = "0x183FF5EE0")]
		public void DMNACDEGIGE(OGBKAAOIFMM PIJJDNMKBBD, ref GLADJNPKOPN LAJFEJAHEJB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	private KLBBFCMIKPN MHJJFKHNBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	private EntityQuery GODGPKKFHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private EntityQuery MMDFKPOHMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	private EntityQuery ICIHCKADDKE;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB600", Offset = "0x2AEA000", VA = "0x182AEB600", Slot = "14")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB940", Offset = "0x2AEA340", VA = "0x182AEB940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public OGBKAAOIFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB8E0", Offset = "0x2AEA2E0", VA = "0x182AEB8E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB3A0", Offset = "0x2AE9DA0", VA = "0x182AEB3A0")]
	public static EntityQuery AJBBJPGNEAF(ComponentSystemBase PIJJDNMKBBD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB170", Offset = "0x2AE9B70", VA = "0x182AEB170")]
	public static EntityQuery AFPCNOGIPLI(ComponentSystemBase PIJJDNMKBBD)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x2AEB6E0", Offset = "0x2AEA0E0", VA = "0x182AEB6E0")]
	public static EntityQuery IAAOHMJIPNH(ComponentSystemBase PIJJDNMKBBD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Connectables)]
	public class InitializeRigidbodyExHierarchy : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private EntityQuery CAMLCFELNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private EMFKELAKBNJ EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x2C26C20", Offset = "0x2C25620", VA = "0x182C26C20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x2C26BB0", Offset = "0x2C255B0", VA = "0x182C26BB0", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x2C26CB0", Offset = "0x2C256B0", VA = "0x182C26CB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public InitializeRigidbodyExHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class BEOCJADHEJP : ParentSystemBase<ParentData, OGPCKNJKEMC, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x2DF10C0", Offset = "0x2DEFAC0", VA = "0x182DF10C0", Slot = "14")]
	protected override EntityQueryDesc HOOHEPPJBOH(EntityQueryDesc CAMLCFELNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x76C6B0", Offset = "0x76B0B0", VA = "0x18076C6B0", Slot = "15")]
	protected override EntityQueryDesc KHNLBLBIGEO(EntityQueryDesc CAMLCFELNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1140", Offset = "0x2DEFB40", VA = "0x182DF1140", Slot = "16")]
	protected override EntityQueryDesc OMGFLMJLKFK(EntityQueryDesc CAMLCFELNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1100", Offset = "0x2DEFB00", VA = "0x182DF1100", Slot = "17")]
	protected override EntityQueryDesc JICLHGAFPOJ(EntityQueryDesc CAMLCFELNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x2DF11C0", Offset = "0x2DEFBC0", VA = "0x182DF11C0")]
	public BEOCJADHEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1180", Offset = "0x2DEFB80", VA = "0x182DF1180", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : FOMCGHGDFHL where ParentData : struct, IComponentData, JJGDMAAEPIP where PreviousParentData : struct, IComponentData, JJGDMAAEPIP where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, JJGDMAAEPIP
	{
		[Cpp2IlInjected.Token(Token = "0x200010B")]
		[BurstCompile]
		private struct AMBNIEMGAJD : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter PNIIMICLHJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter MCKKNMKKCEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public NativeHashMap<Entity, int>.ParallelWriter HMGGMBDPPFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public ArchetypeChunkComponentType<PreviousParentData> CDMIAOMKMEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> OPFBLLNNJDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public ArchetypeChunkEntityType MCGILGCNKDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public uint EJHKEBDOLEM;

			[Cpp2IlInjected.Token(Token = "0x6000830")]
			[Cpp2IlInjected.Address(RVA = "0x308F280", Offset = "0x308DC80", VA = "0x18308F280", Slot = "4")]
			public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[BurstCompile]
		private struct BDECGPCNOLD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> HMGGMBDPPFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> EONJBEFKCGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public NativeList<Entity> EOIGBAOAJOH;

			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x26C88B0", Offset = "0x26C72B0", VA = "0x1826C88B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[BurstCompile]
		private struct PKBMCHIALEI : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> PNIIMICLHJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> MCKKNMKKCEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			[ReadOnly]
			public NativeHashMap<Entity, int> HMGGMBDPPFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public BufferFromEntity<ChildrenData> EONJBEFKCGG;

			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x2A54930", Offset = "0x2A53330", VA = "0x182A54930")]
			private int NLMFJDGLNPI(DynamicBuffer<ChildrenData> PFGJBHEKNMH, Entity GOANOLJBHPF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0x2A54400", Offset = "0x2A52E00", VA = "0x182A54400")]
			private void BCHBEAJIGMG(Entity ELGBIOMPEHN, DynamicBuffer<ChildrenData> PFGJBHEKNMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0x2A54B70", Offset = "0x2A53570", VA = "0x182A54B70")]
			private void OJLDNDKDBGG(Entity ELGBIOMPEHN, DynamicBuffer<ChildrenData> PFGJBHEKNMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000835")]
			[Cpp2IlInjected.Address(RVA = "0x2A546C0", Offset = "0x2A530C0", VA = "0x182A546C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		[BurstCompile]
		private struct CJFJBGHHLCJ : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public NativeArray<Entity> IHIOEHLHENP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public NativeList<Entity> DLHGIFABMAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public BufferFromEntity<ChildrenData> EONJBEFKCGG;

			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0x24E17A0", Offset = "0x24E01A0", VA = "0x1824E17A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected EntityQuery MPKBGPDIFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected EntityQuery PLEAFEHPOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected EntityQuery FOJFIGFEIEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected EntityQuery JFMKEOHGJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected ProfilerMarker NLAFIOGDHLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected ProfilerMarker CJLOHENIDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected ProfilerMarker BJLJMPDPGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected ProfilerMarker NPOFPBLEHJI;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x276BA40", Offset = "0x276A440", VA = "0x18276BA40")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x276B0C0", Offset = "0x2769AC0", VA = "0x18276B0C0")]
		private int NLMFJDGLNPI(DynamicBuffer<ChildrenData> PFGJBHEKNMH, Entity GOANOLJBHPF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x276AF60", Offset = "0x2769960", VA = "0x18276AF60")]
		private void NKHHACKGIAG(Entity KCHEMIKFJPH, Entity EPPABMKEFFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x76C6B0", Offset = "0x76B0B0", VA = "0x18076C6B0", Slot = "14")]
		protected virtual EntityQueryDesc HOOHEPPJBOH(EntityQueryDesc CAMLCFELNDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x76C6B0", Offset = "0x76B0B0", VA = "0x18076C6B0", Slot = "15")]
		protected virtual EntityQueryDesc KHNLBLBIGEO(EntityQueryDesc CAMLCFELNDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x76C6B0", Offset = "0x76B0B0", VA = "0x18076C6B0", Slot = "16")]
		protected virtual EntityQueryDesc OMGFLMJLKFK(EntityQueryDesc CAMLCFELNDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc JICLHGAFPOJ(EntityQueryDesc CAMLCFELNDE);

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x276B540", Offset = "0x2769F40", VA = "0x18276B540", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x276A2D0", Offset = "0x2768CD0", VA = "0x18276A2D0")]
		private void HLPCBOJKFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x276A040", Offset = "0x2768A40", VA = "0x18276A040")]
		private void CDMCIAAGAGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x276A8D0", Offset = "0x27692D0", VA = "0x18276A8D0")]
		private JobHandle MNAOLCFFOOH(JobHandle MJAFFEAEOFD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0x2769BA0", Offset = "0x27685A0", VA = "0x182769BA0")]
		private void ABAIAKOFIPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x276B810", Offset = "0x276A210", VA = "0x18276B810", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x276B7E0", Offset = "0x276A1E0", VA = "0x18276B7E0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x17A91C0", Offset = "0x17A7BC0", VA = "0x1817A91C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[AlwaysUpdateSystem]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
public abstract class NNMABKLJCPE : FOMCGHGDFHL, PKBAIAJJFPF
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private struct AJKMKJLABKG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public NativeListAsync<Entity> DBJKBMLDMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public NativeListAsync<Entity> BMMGDMOKPGN;

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x3FEEEB0", Offset = "0x3FED8B0", VA = "0x183FEEEB0")]
		public AJKMKJLABKG(NativeList<Entity> DBJKBMLDMGO, NativeList<Entity> BMMGDMOKPGN, JobHandle NNGFCFNIJKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x3FEEE30", Offset = "0x3FED830", VA = "0x183FEEE30")]
		public JobHandle EIHBEICGHBM(JobHandle MJAFFEAEOFD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x3FEEDA0", Offset = "0x3FED7A0", VA = "0x183FEEDA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct LKPINGPJKDH : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		[Flags]
		public enum BBLGJAAAHLF
		{
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		[WriteOnly]
		public NativeList<Entity> NMFEBMILGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[WriteOnly]
		public NativeList<Entity> ANCAAIACNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[ReadOnly]
		public NativeArray<Entity> FNNDCLBMDAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> AAOIPBGKKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		[ReadOnly]
		public ComponentDataFromEntity GMAPBOIJOLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[ReadOnly]
		public ComponentDataFromEntity ALLBFGPILKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> KHIOHGDIMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public int BHONKILOFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int FHBKECKINGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private BBLGJAAAHLF OMDDDNFJDBB;

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6690", Offset = "0x3FF5090", VA = "0x183FF6690", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6EB0", Offset = "0x3FF58B0", VA = "0x183FF6EB0")]
		private void PAJFHOIHPMM(Entity GOANOLJBHPF, bool JDMEFAMONKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6A60", Offset = "0x3FF5460", VA = "0x183FF6A60")]
		private void MFNFPGACPNH(Entity GOANOLJBHPF, bool JDMEFAMONKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6610", Offset = "0x3FF5010", VA = "0x183FF6610")]
		public AJKMKJLABKG CHGECLNCFDB(NativeArray<Entity> BHEOHMIBBOB, JobHandle MJAFFEAEOFD)
		{
			return default(AJKMKJLABKG);
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x3FF69E0", Offset = "0x3FF53E0", VA = "0x183FF69E0")]
		public AJKMKJLABKG KGMBPPKMBAG(NativeArray<Entity> BHEOHMIBBOB, JobHandle MJAFFEAEOFD)
		{
			return default(AJKMKJLABKG);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6B70", Offset = "0x3FF5570", VA = "0x183FF6B70")]
		public AJKMKJLABKG NGCDHFIKLJH(NativeList<LIOPPALECME> OKDFPKLCDDM, JobHandle MJAFFEAEOFD)
		{
			return default(AJKMKJLABKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6900", Offset = "0x3FF5300", VA = "0x183FF6900")]
		public AJKMKJLABKG HMOFDEMECHI(NativeList<LIOPPALECME> OKDFPKLCDDM, JobHandle MJAFFEAEOFD)
		{
			return default(AJKMKJLABKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6820", Offset = "0x3FF5220", VA = "0x183FF6820")]
		public AJKMKJLABKG FBIEDCGLGIM(NativeList<MIIGEONEKIB> OKDFPKLCDDM, JobHandle MJAFFEAEOFD)
		{
			return default(AJKMKJLABKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x34548D0", Offset = "0x34532D0", VA = "0x1834548D0")]
		private AJKMKJLABKG OBEOAAIOMCE<T>(NativeList<T> OKDFPKLCDDM, int COOGGFDDIBA, int CBBMKCMAPHH, BBLGJAAAHLF HLAMMHNAHAB, JobHandle MJAFFEAEOFD) where T : struct
		{
			return default(AJKMKJLABKG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6C50", Offset = "0x3FF5650", VA = "0x183FF6C50")]
		private AJKMKJLABKG OBEOAAIOMCE(NativeArray<Entity> CGCCIONMJJA, int COOGGFDDIBA, int CBBMKCMAPHH, BBLGJAAAHLF HLAMMHNAHAB, JobHandle MJAFFEAEOFD)
		{
			return default(AJKMKJLABKG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private readonly KGOHPJFJCLE LHMILDDMKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private EntityQuery ICPLJHNCMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private EntityQuery OAOKLABFMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private KLBBFCMIKPN IKELKCIFHEF;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	protected abstract ComponentType ANPOJKNNCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	protected abstract ComponentType ECFGABMNABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected abstract ComponentType BKLNMJPBNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE98C0", Offset = "0x2AE82C0", VA = "0x182AE98C0")]
	protected NNMABKLJCPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8380", Offset = "0x2AE6D80", VA = "0x182AE8380", Slot = "14")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8820", Offset = "0x2AE7220", VA = "0x182AE8820", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8A50", Offset = "0x2AE7450", VA = "0x182AE8A50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x7EBA80", Offset = "0x7EA480", VA = "0x1807EBA80", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE87C0", Offset = "0x2AE71C0", VA = "0x182AE87C0")]
	private void LOGDICHEMHG(NativeArray<Entity> OKDFPKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8720", Offset = "0x2AE7120", VA = "0x182AE8720")]
	private void KFOCOOPJLNH(NativeArray<Entity> OKDFPKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x2AE85E0", Offset = "0x2AE6FE0", VA = "0x182AE85E0")]
	private void JOAJIKIBGMI(AJKMKJLABKG BLHBJJDEOKN, string FNEFGEBNEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x2AE84D0", Offset = "0x2AE6ED0", VA = "0x182AE84D0")]
	private void JOAJIKIBGMI(NativeListAsync<Entity> OBKBAAHAHHA, string FNEFGEBNEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8240", Offset = "0x2AE6C40", VA = "0x182AE8240")]
	private void DDIADIFIDMF(AJKMKJLABKG BLHBJJDEOKN, string FNEFGEBNEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8130", Offset = "0x2AE6B30", VA = "0x182AE8130")]
	private void DDIADIFIDMF(NativeListAsync<Entity> OBKBAAHAHHA, string FNEFGEBNEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8460", Offset = "0x2AE6E60", VA = "0x182AE8460")]
	private bool ICMGNOMFKDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
public class AHLGPLMOKMJ : FOMCGHGDFHL, MMKNGEFLOAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct KOHNCPOPOGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public AHLGPLMOKMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		public KOHNCPOPOGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HDODIMBHKCH : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct MNJANAOBMJK
		{
			[Cpp2IlInjected.Token(Token = "0x2000117")]
			public struct JAILAMHFCMM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public LambdaParameterValueProvider_Entity.Runtime FBIMIEOCNCL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GKGFLMFKKIA;

			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0x3FF8440", Offset = "0x3FF6E40", VA = "0x183FF8440")]
			public void DMNACDEGIGE(AHLGPLMOKMJ PIJJDNMKBBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x3FF8450", Offset = "0x3FF6E50", VA = "0x183FF8450")]
			public JAILAMHFCMM KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
			{
				return default(JAILAMHFCMM);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AHLGPLMOKMJ ALMIJAPBMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public EntityCommandBuffer GNKKMHFFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private MNJANAOBMJK NNPBNEEGOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe MNJANAOBMJK.JAILAMHFCMM* BEIHMNNJOAB;

		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IMKGCCNGKJM;

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x2BF77F0", Offset = "0x2BF61F0", VA = "0x182BF77F0")]
		internal void EJGOAEBMHCL(Entity NJOLKOHDHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7A30", Offset = "0x2BF6430", VA = "0x182BF7A30", Slot = "5")]
		public void ReadFromDisplayClass(ref KOHNCPOPOGI LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7A60", Offset = "0x2BF6460", VA = "0x182BF7A60", Slot = "6")]
		public void WriteToDisplayClass(ref KOHNCPOPOGI LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7900", Offset = "0x2BF6300", VA = "0x182BF7900", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x2BF79C0", Offset = "0x2BF63C0", VA = "0x182BF79C0")]
		public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, ref MNJANAOBMJK.JAILAMHFCMM DNOHEDJMLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x2BF77B0", Offset = "0x2BF61B0", VA = "0x182BF77B0")]
		public void DMNACDEGIGE(AHLGPLMOKMJ PIJJDNMKBBD, ref KOHNCPOPOGI LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7950", Offset = "0x2BF6350", VA = "0x182BF7950")]
		public unsafe static void IDLGLLJOIMC(ArchetypeChunkIterator* MBPLNPAGJMC, void* MAKNNDOILNI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private NJHODHMBKHE LFLKGJCKHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private FEKPIDGPAOL CBJNFMJDGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery AKPJODFBNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private ProfilerMarker GFOGBDADPGH;

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE2C0", Offset = "0x2DECCC0", VA = "0x182DEE2C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE180", Offset = "0x2DECB80", VA = "0x182DEE180", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE320", Offset = "0x2DECD20", VA = "0x182DEE320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public AHLGPLMOKMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE1E0", Offset = "0x2DECBE0", VA = "0x182DEE1E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000859")]
	[Cpp2IlInjected.Address(RVA = "0x2DEE470", Offset = "0x2DECE70", VA = "0x182DEE470")]
	public static EntityQuery PHLCEDDBAKO(ComponentSystemBase PIJJDNMKBBD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[GCANBDAKNID]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
public class GMMHEFHALCL : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private FEKPIDGPAOL CBJNFMJDGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private SceneService OOKLBGAMMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private EntityQuery CAMLCFELNDE;

	[Cpp2IlInjected.Token(Token = "0x6000865")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B480", Offset = "0x2C19E80", VA = "0x182C1B480", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000866")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B4F0", Offset = "0x2C19EF0", VA = "0x182C1B4F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000867")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B590", Offset = "0x2C19F90", VA = "0x182C1B590", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public GMMHEFHALCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public struct PNJPFBAHHDF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	public DNIHOJPPGJK BIONDBIGACN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
	public static PNJPFBAHHDF EGMKMIPNLBF(in DNIHOJPPGJK KHOHMFLEPOG)
	{
		return default(PNJPFBAHHDF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000")]
	public static DNIHOJPPGJK EGMKMIPNLBF(in PNJPFBAHHDF OKHEGEKPCLE)
	{
		return default(DNIHOJPPGJK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[AlwaysUpdateSystem]
public class NJHODHMBKHE : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE80A0", Offset = "0x2AE6AA0", VA = "0x182AE80A0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0")]
	public NJHODHMBKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[AlwaysUpdateSystem]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
public class PLNBKMCDHON : FOMCGHGDFHL, MMKNGEFLOAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct IEALLLDMNLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public PLNBKMCDHON <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		public IEALLLDMNLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
		internal void <OnUpdate>b__0(Entity e, PNJPFBAHHDF ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct MLCJJANMJPL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct HBNLBDPMEEM
		{
			[Cpp2IlInjected.Token(Token = "0x200011F")]
			public struct BANNJAIIBEP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400037D")]
				public LambdaParameterValueProvider_Entity.Runtime FBIMIEOCNCL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400037E")]
				public LambdaParameterValueProvider_IComponentData<PNJPFBAHHDF>.Runtime PMICFACJBEB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity GKGFLMFKKIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<PNJPFBAHHDF> IEDOAENCKJL;

			[Cpp2IlInjected.Token(Token = "0x600087E")]
			[Cpp2IlInjected.Address(RVA = "0x3FF1FF0", Offset = "0x3FF09F0", VA = "0x183FF1FF0")]
			public void DMNACDEGIGE(PLNBKMCDHON PIJJDNMKBBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2050", Offset = "0x3FF0A50", VA = "0x183FF2050")]
			public BANNJAIIBEP KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
			{
				return default(BANNJAIIBEP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public PLNBKMCDHON ALMIJAPBMBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EntityCommandBuffer GNKKMHFFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private HBNLBDPMEEM NNPBNEEGOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe HBNLBDPMEEM.BANNJAIIBEP* BEIHMNNJOAB;

		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IMKGCCNGKJM;

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8180", Offset = "0x3FF6B80", VA = "0x183FF8180")]
		internal void EJGOAEBMHCL(Entity NJOLKOHDHLL, PNJPFBAHHDF ABBEKDHKMNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7A30", Offset = "0x2BF6430", VA = "0x182BF7A30", Slot = "5")]
		public void ReadFromDisplayClass(ref IEALLLDMNLG LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7A60", Offset = "0x2BF6460", VA = "0x182BF7A60", Slot = "6")]
		public void WriteToDisplayClass(ref IEALLLDMNLG LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8280", Offset = "0x3FF6C80", VA = "0x183FF8280", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8390", Offset = "0x3FF6D90", VA = "0x183FF8390")]
		public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, ref HBNLBDPMEEM.BANNJAIIBEP DNOHEDJMLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x3FF80F0", Offset = "0x3FF6AF0", VA = "0x183FF80F0")]
		public void DMNACDEGIGE(PLNBKMCDHON PIJJDNMKBBD, ref IEALLLDMNLG LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8320", Offset = "0x3FF6D20", VA = "0x183FF8320")]
		public unsafe static void IDLGLLJOIMC(ArchetypeChunkIterator* MBPLNPAGJMC, void* MAKNNDOILNI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private NJHODHMBKHE LFLKGJCKHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private FEKPIDGPAOL CBJNFMJDGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery AHDCAOPPJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000373")]
	private ProfilerMarker MENACKKGJAB;

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x2AFBEC0", Offset = "0x2AFA8C0", VA = "0x182AFBEC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x2AFBBB0", Offset = "0x2AFA5B0", VA = "0x182AFBBB0", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x2AFBF20", Offset = "0x2AFA920", VA = "0x182AFBF20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public PLNBKMCDHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x2AFBDE0", Offset = "0x2AFA7E0", VA = "0x182AFBDE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x2AFBC10", Offset = "0x2AFA610", VA = "0x182AFBC10")]
	public static EntityQuery KHBHPKGOKPK(ComponentSystemBase PIJJDNMKBBD)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct OGANOLPPFIE : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public BCPGIKNGDDK CAJCDELKPBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public NativeHashMap<Entity, OHKLLNGFCGP> CGCCIONMJJA;

			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x3FF96A0", Offset = "0x3FF80A0", VA = "0x183FF96A0")]
			public OGANOLPPFIE(int ADCMDGEMNDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF9620", Offset = "0x3FF8020", VA = "0x183FF9620", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct NILFILJGHEC : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			[ReadOnly]
			public NativeArray<Entity> CGCCIONMJJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> OODMFJMGGFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> NIFLCCAICPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> BIMGCNBCFIJ;

			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x3FF8890", Offset = "0x3FF7290", VA = "0x183FF8890", Slot = "4")]
			public void Execute(int GFDMFLGCBKB, TransformAccess CLHKPCIOCGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct GBHMIAJMIBA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[ReadOnly]
			public NativeArray<Entity> CGCCIONMJJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> OODMFJMGGFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> BIMGCNBCFIJ;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x3FF1BC0", Offset = "0x3FF05C0", VA = "0x183FF1BC0", Slot = "4")]
			public void Execute(int GFDMFLGCBKB, TransformAccess CLHKPCIOCGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private FEKPIDGPAOL CBJNFMJDGJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery ANOJPBHMCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery NOMBJIOFAPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery PEDMIOGLEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private EntityQuery EJEMFAEMGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EntityQuery DEIOAABHBAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private JobHandle NPLKPENOMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private OGANOLPPFIE KLAIDKNPPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private OGANOLPPFIE JACJKCOGNAN;

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE870", Offset = "0x2AFD270", VA = "0x182AFE870", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x2AFED40", Offset = "0x2AFD740", VA = "0x182AFED40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEA10", Offset = "0x2AFD410", VA = "0x182AFEA10", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF000", Offset = "0x2AFDA00", VA = "0x182AFF000", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE730", Offset = "0x2AFD130", VA = "0x182AFE730")]
		private void CPLPODCJLEA(EntityQuery CAMLCFELNDE, out (NativeArrayAsync<PNJPFBAHHDF> handles, NativeArrayAsync<IDMLAGGFJCC> bounds) NIPBPKPBPPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE4D0", Offset = "0x2AFCED0", VA = "0x182AFE4D0")]
		private void AJMEPGKGNGC((NativeArrayAsync<PNJPFBAHHDF> handles, NativeArrayAsync<IDMLAGGFJCC> bounds) NIPBPKPBPPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEA10", Offset = "0x2AFD410", VA = "0x182AFEA10")]
		private void LIGMGIDIMHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE8D0", Offset = "0x2AFD2D0", VA = "0x182AFE8D0")]
		private void LGGJJBAGAAH(EntityQuery CAMLCFELNDE, out (NativeArrayAsync<Entity> entities, NativeArrayAsync<PNJPFBAHHDF> handles) NIPBPKPBPPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEA50", Offset = "0x2AFD450", VA = "0x182AFEA50")]
		private void OPPEHFNELIK((NativeArrayAsync<Entity> entities, NativeArrayAsync<PNJPFBAHHDF> handles) NIPBPKPBPPP, OGANOLPPFIE JEFPNAKLJNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE240", Offset = "0x2AFCC40", VA = "0x182AFE240")]
		private JobHandle ACFJBHOMFGF(OGANOLPPFIE JEFPNAKLJNI, ComponentDataFromEntity<WorldPoseData> OODMFJMGGFL, ComponentDataFromEntity<WorldUniformScaleData> BIMGCNBCFIJ, ComponentDataFromEntity<WorldDeformableScaleData> NIFLCCAICPG)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE3A0", Offset = "0x2AFCDA0", VA = "0x182AFE3A0")]
		private JobHandle AHKHDHMHELD(OGANOLPPFIE JEFPNAKLJNI, ComponentDataFromEntity<WorldPoseData> OODMFJMGGFL, ComponentDataFromEntity<WorldUniformScaleData> BIMGCNBCFIJ)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000124")]
public struct ABMECCHDIAL : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[GCANBDAKNID]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	public class SplineLocalBoundsSystem : FOMCGHGDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[BurstCompile]
		private struct ENLDOHOJMIJ : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			[ReadOnly]
			public NativeArray<Entity> CFGHHNJALCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointParentData> OHKGBFJACIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			[ReadOnly]
			public ComponentDataFromEntity<IDMLAGGFJCC> GPJMCEMIKPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			[WriteOnly]
			public NativeHashMap<Entity, OHKLLNGFCGP>.ParallelWriter ONKBGOLCCOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter BIKDJIOELCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter OPHOIDHOINF;

			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0x3FF16A0", Offset = "0x3FF00A0", VA = "0x183FF16A0", Slot = "4")]
			public void Execute(int GFDMFLGCBKB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000127")]
		[BurstCompile]
		private struct OEIPAPJFKIF : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			[ReadOnly]
			public NativeArray<Entity> GNFEELDKCPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> OHKKFDMMHGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointPositionData> IMJOODNHCEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointScaleData> KNAFIIIOCLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<IDMLAGGFJCC> NONMBKCKMDA;

			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x3FF9390", Offset = "0x3FF7D90", VA = "0x183FF9390", Slot = "4")]
			public void Execute(int GFDMFLGCBKB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private EntityQuery OIGBINKEMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private EntityQuery ANGENOFGMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private EntityQuery LHMEPNFEPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery ALNKCEHPMKH;

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x2C03700", Offset = "0x2C02100", VA = "0x182C03700", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x2C03910", Offset = "0x2C02310", VA = "0x182C03910", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x2C02B00", Offset = "0x2C01500", VA = "0x182C02B00")]
		private JobHandle ACLFHJGHDDP(NativeArrayAsync<Entity> GNPHBMKMMCM, int KHNOOLPHJPF, JobHandle MJAFFEAEOFD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x2C02920", Offset = "0x2C01320", VA = "0x182C02920")]
		private JobHandle ACLFHJGHDDP(NativeArray<Entity> ICAFJIAIHDI, int KHNOOLPHJPF, [Optional] JobHandle MJAFFEAEOFD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x2C02BE0", Offset = "0x2C015E0", VA = "0x182C02BE0")]
		private NativeArrayAsync<Entity> APAAGHKAPAM(EntityQuery CAMLCFELNDE)
		{
			return default(NativeArrayAsync<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x2C02C60", Offset = "0x2C01660", VA = "0x182C02C60")]
		private (NativeListAsync<Entity>, NativeListAsync<Entity>) BAIIPBOIHID(NativeArrayAsync<Entity> DJCCBJEBCHH)
		{
			return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x2C03670", Offset = "0x2C02070", VA = "0x182C03670")]
		private void ICIBOPFDGDB(out NativeArray<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x2C034B0", Offset = "0x2C01EB0", VA = "0x182C034B0")]
		private void HEBOGKFANBA(NativeList<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x2C033E0", Offset = "0x2C01DE0", VA = "0x182C033E0")]
		private void HEBOGKFANBA(NativeArray<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x2C03540", Offset = "0x2C01F40", VA = "0x182C03540")]
		private void HGECBGFPBPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		private static void BPPCPPIILDL(int KFPBKDKKKIM, int CGEPHPPOCFO, int MHCPJFNAPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x2C030B0", Offset = "0x2C01AB0", VA = "0x182C030B0")]
		private static IDMLAGGFJCC BDLKGKDLEHB(NativeArray<Entity> MBJFPMMLING, ComponentDataFromEntity<SplinePointPositionData> IMJOODNHCEF, ComponentDataFromEntity<SplinePointScaleData> KNAFIIIOCLK)
		{
			return default(IDMLAGGFJCC);
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000128")]
internal struct DKIEHMOBMAJ : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[GCANBDAKNID]
	[LOEOGANCBGC(EDPDLGMLNHJ.Lifecycle)]
	public class DestroyLocalObjects : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		[JIFPDEDMPGC]
		private ObjectNetworkToLocalMapService KGCOHGMEJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		[JIFPDEDMPGC]
		private ObjectLifecycleService JFLLPKLIMED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private EntityQuery BJMJGPOANOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EntityQuery DGNFAGHCGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private EntityQuery HJEJCIHGFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x2E04690", Offset = "0x2E03090", VA = "0x182E04690", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x2E04A70", Offset = "0x2E03470", VA = "0x182E04A70")]
		public bool MMPCJLFNPIH(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x2E04B20", Offset = "0x2E03520", VA = "0x182E04B20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x2E045A0", Offset = "0x2E02FA0", VA = "0x182E045A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x2E04C50", Offset = "0x2E03650", VA = "0x182E04C50", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x11D9410", Offset = "0x11D7E10", VA = "0x1811D9410", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x2E045A0", Offset = "0x2E02FA0", VA = "0x182E045A0")]
		private void CDNLJAKBCMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x2E045E0", Offset = "0x2E02FE0", VA = "0x182E045E0")]
		private void EFEHGHKPAFC(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x2E04700", Offset = "0x2E03100", VA = "0x182E04700")]
		private void HIMFHEPFNNJ(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x2E04960", Offset = "0x2E03360", VA = "0x182E04960")]
		private void MGDLALMHOPM(NativeArray<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x2E04840", Offset = "0x2E03240", VA = "0x182E04840")]
		private void KKEOBMFLGEO(NativeArray<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[LOEOGANCBGC(EDPDLGMLNHJ.NetworkSend)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	public sealed class EnqueuePropertyDifferenceToNetwork : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private static DHNNDIENLFJ[] CKDGFICNEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private MMLIDNKEONJ GDCPACDGFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private BPDJHFAPEAG JFBDMNCEACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private PropertyDiffStateService CPODMNBDJHH;

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x2C14F60", Offset = "0x2C13960", VA = "0x182C14F60", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x2C155A0", Offset = "0x2C13FA0", VA = "0x182C155A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x2C15010", Offset = "0x2C13A10", VA = "0x182C15010")]
		private void HONPBLPNIPC(DHNNDIENLFJ GIFOAOGCBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		private void BAFHDBHBKLD(Entity GOANOLJBHPF, AKLFKNOOHJC AOCEENCOLMM, FBPCPDKHEOJ ALMPKNLFFLI, NDHLMGGHOHI HBDADKJLILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Callbacks)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	public sealed class PropertyEventCallbacks : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private PropertyEventCallbacksService MPEBEBMNLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private PropertyDiffStateService CPODMNBDJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private TransformOwnershipPhase GIFOAOGCBEF;

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x2B04E60", Offset = "0x2B03860", VA = "0x182B04E60", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x2B04EF0", Offset = "0x2B038F0", VA = "0x182B04EF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[UpdateAfter(typeof(EnqueuePropertyDifferenceToNetwork))]
	[LOEOGANCBGC(EDPDLGMLNHJ.NetworkSend)]
	internal class TransmitNetworkDataSystem : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private MICBEGMKIKM FBKFNMHPGPB;

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AD10", Offset = "0x2C09710", VA = "0x182C0AD10", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x2C0AD60", Offset = "0x2C09760", VA = "0x182C0AD60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public TransmitNetworkDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C0")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[GCANBDAKNID]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	public class CalculateCullingBandChanges : FOMCGHGDFHL, IPCGJDFHGJG, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct APACNPJCHBI : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ArchetypeChunkEntityType EGLNLBJKFLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			[ReadOnly]
			public ArchetypeChunkComponentType<WorldPoseData> JCNBKBODDIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[WriteOnly]
			public NativeList<KLEFKDIFLJN>.ParallelWriter GJPHMNOEJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public ArchetypeChunkComponentType<FHPDGDEELHM> GNJBMEHDEFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public float3 JNODNCHMALF;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private static readonly float4x2 LDHKGEDBLGP;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private static readonly float4x2 GDDFDFBOOCO;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private static readonly int4x2 MCJDOFNENMK;

			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x2BF5D90", Offset = "0x2BF4790", VA = "0x182BF5D90", Slot = "4")]
			public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private static KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private const int KIAJPPPNAEP = 10;

		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private const double DHKJJHHCJBH = 0.1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private EntityQuery HJAHHJDBAMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private EntityQuery LMEFHDGAIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private double DOBJJFLFBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private CullingBandService JIJNBHMKEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TimeService BNNFECLLHDL;

		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4D30", Offset = "0x2DF3730", VA = "0x182DF4D30", Slot = "14")]
		public void BEJHKBIOAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4D40", Offset = "0x2DF3740", VA = "0x182DF4D40", Slot = "15")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5180", Offset = "0x2DF3B80", VA = "0x182DF5180", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x2DF52D0", Offset = "0x2DF3CD0", VA = "0x182DF52D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C5")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4DD0", Offset = "0x2DF37D0", VA = "0x182DF4DD0")]
		private bool GNKMHGPDLCD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4E40", Offset = "0x2DF3840", VA = "0x182DF4E40")]
		private void NOLHMNAAKLK(EntityQuery CAMLCFELNDE, float3 LJFBPMMONEN, string ANJJEPIBAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public CalculateCullingBandChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public struct KLEFKDIFLJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public Entity GOANOLJBHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public EIFFOLHELAI HKLCHIBFNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public EIFFOLHELAI APGCALANEIN;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	public class ProcessCullingBandChangeCallbacks : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private CullingBandService JIJNBHMKEJD;

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x2B01B80", Offset = "0x2B00580", VA = "0x182B01B80", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x2B01BD0", Offset = "0x2B005D0", VA = "0x182B01BD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public ProcessCullingBandChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Connectables)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	public class UpdateInertialProperties : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private EntityQuery PKLFFHHIFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private GEIPPHFKOBG PNGKLOGDEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x2C119E0", Offset = "0x2C103E0", VA = "0x182C119E0", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x2C11A50", Offset = "0x2C10450", VA = "0x182C11A50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x2C11AE0", Offset = "0x2C104E0", VA = "0x182C11AE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public UpdateInertialProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000132")]
	[GCANBDAKNID]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	public class EnqueueKinematicSleepChangeEvents : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DOCCNPHKKEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> FCNPPJIHHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> FAKPFNEPFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private KinematicSleepChangeService POFDAFAPCHD;

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B3A0", Offset = "0x2E09DA0", VA = "0x182E0B3A0", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B9F0", Offset = "0x2E0A3F0", VA = "0x182E0B9F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B290", Offset = "0x2E09C90", VA = "0x182E0B290")]
		private void GBPDDIMIOOL(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> OKDFPKLCDDM, EntityQueryDesc BICIGDBEBGI, bool NIGLNONICLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B150", Offset = "0x2E09B50", VA = "0x182E0B150")]
		private void GBPDDIMIOOL(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> OKDFPKLCDDM, EntityQueryDesc BICIGDBEBGI, bool NIGLNONICLM, bool DDEOINEGECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x2E0BC50", Offset = "0x2E0A650", VA = "0x182E0BC50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B4C0", Offset = "0x2E09EC0", VA = "0x182E0B4C0")]
		private void MHHNJOOIKBA(EntityQuery CAMLCFELNDE, bool OJPENOBODJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x2E0ABD0", Offset = "0x2E095D0", VA = "0x182E0ABD0")]
		private void BIOFBBENCBM(EntityQuery CAMLCFELNDE, bool GINPOJPPJAK, bool OJPENOBODJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B6B0", Offset = "0x2E0A0B0", VA = "0x182E0B6B0")]
		private void MKJLLKFABOE(NativeArray<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x2E0ADE0", Offset = "0x2E097E0", VA = "0x182E0ADE0")]
		private void CHAGEPONMKG(NativeList<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B8D0", Offset = "0x2E0A2D0", VA = "0x182E0B8D0")]
		private void NPMPAHFCKMH(NativeArray<Entity> CGCCIONMJJA, bool GINPOJPPJAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x2E0AF50", Offset = "0x2E09950", VA = "0x182E0AF50")]
		private NativeList<Entity> DBMDECACLJP(NativeArray<Entity> CGCCIONMJJA)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x2E0AB90", Offset = "0x2E09590", VA = "0x182E0AB90")]
		private NativeList<Entity> BCPLCBIHHGJ(NativeArray<Entity> CGCCIONMJJA)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B3F0", Offset = "0x2E09DF0", VA = "0x182E0B3F0")]
		private NativeList<Entity> JLKKLJFPAKH(NativeArray<Entity> CGCCIONMJJA)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x2E0BF20", Offset = "0x2E0A920", VA = "0x182E0BF20")]
		private NativeList<Entity> PHENJMMKPOI(NativeArray<Entity> CGCCIONMJJA, bool DPLKPCPLIFB)
		{
			return default(NativeList<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x2E0B430", Offset = "0x2E09E30", VA = "0x182E0B430")]
		private CNBHDBOMFGL KIPJFOKOJOE(NativeArray<Entity> CGCCIONMJJA)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(CNBHDBOMFGL);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x2E0C110", Offset = "0x2E0AB10", VA = "0x182E0C110")]
		public EnqueueKinematicSleepChangeEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	public class ProcessKinematicSleepChangeCallbacks : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private KinematicSleepChangeService POFDAFAPCHD;

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x2B01BF0", Offset = "0x2B005F0", VA = "0x182B01BF0", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0x2B01C40", Offset = "0x2B00640", VA = "0x182B01C40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public ProcessKinematicSleepChangeCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	public class DebugSyncPropertiesFromUnityRigidbody : PPPEJONEMKB
	{
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private static KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private EntityQuery GIAGJJLMJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private EntityQuery MDIMECJAEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private EntityQuery BNODJMLEAOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private EntityQuery PIJBJEJIGJM;

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x2E04210", Offset = "0x2E02C10", VA = "0x182E04210", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x2E043D0", Offset = "0x2E02DD0", VA = "0x182E043D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x2E03FD0", Offset = "0x2E029D0", VA = "0x182E03FD0")]
		private void IJLJHFLMMPO(EntityQuery CAMLCFELNDE, bool OLFHPKNHJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x2E03D90", Offset = "0x2E02790", VA = "0x182E03D90")]
		private void FAKPMMMEJHK(EntityQuery CAMLCFELNDE, bool OLFHPKNHJOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public DebugSyncPropertiesFromUnityRigidbody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Scope)]
	internal class AssignPlayerIdsSystem : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private EntityQuery IOHPEHIKHEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery IALNONCMMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private SceneService DLIDPEKLJKC;

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0030", Offset = "0x2DEEA30", VA = "0x182DF0030", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0670", Offset = "0x2DEF070", VA = "0x182DF0670", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0780", Offset = "0x2DEF180", VA = "0x182DF0780", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFE10", Offset = "0x2DEE810", VA = "0x182DEFE10")]
		private void AGAHNOPPFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x2DF00A0", Offset = "0x2DEEAA0", VA = "0x182DF00A0")]
		private void KPFMEOEAOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0210", Offset = "0x2DEEC10", VA = "0x182DF0210")]
		private void LBNCGCCNIPB(NativeArray<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0530", Offset = "0x2DEEF30", VA = "0x182DF0530")]
		private void MKEECOFHKEI(NativeArray<Entity> CGCCIONMJJA, int KEHIOHCJBBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFF20", Offset = "0x2DEE920", VA = "0x182DEFF20")]
		private void CCODDMMEEKM(NativeArray<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x2DF07A0", Offset = "0x2DEF1A0", VA = "0x182DF07A0")]
		private void PEPGMDCABCC(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		private static void PFAMALCFBFE(int OACKGFKLPAI, Transform CLHKPCIOCGF, Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public AssignPlayerIdsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal static class KAPENIIMANJ
{
	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x2C2B770", Offset = "0x2C2A170", VA = "0x182C2B770")]
	public static bool FKOLBFEODHB(this SystemBase GFDIEIODBJH, out Entity GOANOLJBHPF)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[LOEOGANCBGC(EDPDLGMLNHJ.Scope)]
	internal class ClearScopeOnLocalPlayerChangeSystem : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private EntityQuery BLJMGFIKKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private DGINFINNHOA AJKFPKEIFME;

		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6EA0", Offset = "0x2DF58A0", VA = "0x182DF6EA0", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6EF0", Offset = "0x2DF58F0", VA = "0x182DF6EF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6FB0", Offset = "0x2DF59B0", VA = "0x182DF6FB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public ClearScopeOnLocalPlayerChangeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[LOEOGANCBGC(EDPDLGMLNHJ.Scope)]
	internal class LocalPlayerScopeSystem : ScopeSystemBase<MCLDEMNJGIB>, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private const string KOJPKLNIFEI = "LocalPlayerScopeSystem";

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private DIOGGBHHPCP AOCAKMGOGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityQuery GLOCLIHJJGO;

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		private Entity KBGPPHIFLOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0x2C33F50", Offset = "0x2C32950", VA = "0x182C33F50")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x2C34600", Offset = "0x2C33000", VA = "0x182C34600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		private Entity EFECEPDGOLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x2C34660", Offset = "0x2C33060", VA = "0x182C34660")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public DFKOJFHJBPL CHCICGODBCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0x2C34570", Offset = "0x2C32F70", VA = "0x182C34570")]
			get
			{
				return default(DFKOJFHJBPL);
			}
			[Cpp2IlInjected.Token(Token = "0x600090A")]
			[Cpp2IlInjected.Address(RVA = "0x2C34100", Offset = "0x2C32B00", VA = "0x182C34100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public DFKOJFHJBPL OJODKJEIIOL
		{
			[Cpp2IlInjected.Token(Token = "0x600090B")]
			[Cpp2IlInjected.Address(RVA = "0x2C34480", Offset = "0x2C32E80", VA = "0x182C34480")]
			get
			{
				return default(DFKOJFHJBPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x2C34810", Offset = "0x2C33210", VA = "0x182C34810", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x2C34170", Offset = "0x2C32B70", VA = "0x182C34170", Slot = "15")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x2C348B0", Offset = "0x2C332B0", VA = "0x182C348B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x2C33FB0", Offset = "0x2C329B0", VA = "0x182C33FB0", Slot = "14")]
		protected override void GILMEPGMBMB(NativeArray<Entity> CGCCIONMJJA, NativeArray<Entity> JCAOFGAOHHH, NativeArray<Entity> GFMALAJIIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x2C346C0", Offset = "0x2C330C0", VA = "0x182C346C0")]
		private void ODLCGFHHABO(NativeArray<Entity> CGCCIONMJJA, NativeArray<Entity> GFMALAJIIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x2C341E0", Offset = "0x2C32BE0", VA = "0x182C341E0")]
		private void JELPJHKKHJE(Entity GOANOLJBHPF, Entity HPNMIFDJGEE, Entity NFNADCOJKLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x2602DD0", Offset = "0x26017D0", VA = "0x182602DD0")]
		private bool BHPOPCGLBJN<T>(out T MNIAGKNOHEJ) where T : struct, IComponentData
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x2602E60", Offset = "0x2601860", VA = "0x182602E60")]
		private void PCGCFIEHINB<T>(T MNIAGKNOHEJ) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x2C34510", Offset = "0x2C32F10", VA = "0x182C34510")]
		public bool MEIGGNOBABM(DFKOJFHJBPL BIGMOINDGKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x2C347A0", Offset = "0x2C331A0", VA = "0x182C347A0")]
		private static bool OKOJMOABGOK(DFKOJFHJBPL KLOAOOHFAPO, DFKOJFHJBPL FACAFMKPABD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x2C34980", Offset = "0x2C33380", VA = "0x182C34980")]
		public LocalPlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x2C347D0", Offset = "0x2C331D0", VA = "0x182C347D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Scope)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	internal class CreateContainerPivotOnEnterScopeSystem : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private EntityQuery CAMLCFELNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF3E0", Offset = "0x2DFDDE0", VA = "0x182DFF3E0", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF540", Offset = "0x2DFDF40", VA = "0x182DFF540", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF5E0", Offset = "0x2DFDFE0", VA = "0x182DFF5E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF290", Offset = "0x2DFDC90", VA = "0x182DFF290")]
		private NativeArray<Entity> GCOJLGALLOJ(int JOBJIONNEHK)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x2DFF430", Offset = "0x2DFDE30", VA = "0x182DFF430")]
		private void MLPDDNKPDKB(NativeArray<Entity> CNHNGMCNOBG, NativeArray<Entity> FAFFAHGEOPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public CreateContainerPivotOnEnterScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Scope)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	internal class HideRemotePivotsNotInScope : FOMCGHGDFHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery AJGDMOHPLGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery CJFGDEHPCGJ;

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x2C21160", Offset = "0x2C1FB60", VA = "0x182C21160", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x2C21250", Offset = "0x2C1FC50", VA = "0x182C21250", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public HideRemotePivotsNotInScope()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal static class FONHOMGHHLL
{
	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	public const string ELHEKOFOLLL = "PivotInScope";

	[Cpp2IlInjected.Token(Token = "0x6000925")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8130", Offset = "0x2DB6B30", VA = "0x182DB8130")]
	public static NativeArray<T> OBEOAAIOMCE<T>(NativeArray<Entity> CGCCIONMJJA, EntityManager BJMEFCCEPHI) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000926")]
	[Cpp2IlInjected.Address(RVA = "0x2C19950", Offset = "0x2C18350", VA = "0x182C19950")]
	public static void FCIIAJCNBGH(EntityQuery CAMLCFELNDE, EntityManager BJMEFCCEPHI, HGFGJIKNIPL CPFOJDHADNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000927")]
	[Cpp2IlInjected.Address(RVA = "0x2C19BC0", Offset = "0x2C185C0", VA = "0x182C19BC0")]
	public static void OEAMKJFOEPK(NativeArray<Entity> CNHNGMCNOBG, HGFGJIKNIPL CPFOJDHADNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000928")]
	[Cpp2IlInjected.Address(RVA = "0x2C19A90", Offset = "0x2C18490", VA = "0x182C19A90")]
	public static void NCHKFIJPGKL(NativeArray<Entity> CNHNGMCNOBG, HGFGJIKNIPL CPFOJDHADNE)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Scope)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	internal class UpdateContainerPivotOnExitScopeSystem : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private EntityQuery CAMLCFELNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private TransformService CAJCDELKPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private ObjectLifecycleService JFLLPKLIMED;

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x2C10BB0", Offset = "0x2C0F5B0", VA = "0x182C10BB0", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x2C11450", Offset = "0x2C0FE50", VA = "0x182C11450", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x2C114F0", Offset = "0x2C0FEF0", VA = "0x182C114F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x2C10C40", Offset = "0x2C0F640", VA = "0x182C10C40")]
		private void NAJHMJNLFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x2C10AA0", Offset = "0x2C0F4A0", VA = "0x182C10AA0")]
		private void GIKEBDAJCFP(NativeArray<Entity> CNHNGMCNOBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x2C101D0", Offset = "0x2C0EBD0", VA = "0x182C101D0")]
		private void GHOLPPBLKEP(NativeArray<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x2C0FF80", Offset = "0x2C0E980", VA = "0x182C0FF80")]
		private void EDEBJHENLDJ(NativeArray<Entity> FAFFAHGEOPN, NativeArray<RigidTransform> NMEIIGLGCDH, NativeArray<RigidTransform> AIDMNBOJBKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x2C11500", Offset = "0x2C0FF00", VA = "0x182C11500")]
		private void PGJPEPJIOIF(NativeArray<RigidTransform> AIDMNBOJBKM, NativeArray<Entity> FAFFAHGEOPN, NativeList<Entity> FBIPDCCKLDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public UpdateContainerPivotOnExitScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Scope)]
	internal class PostGameplayOnScopeChange : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private EntityQuery BLJMGFIKKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private EntityQuery OMMKKPKCEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x2B00130", Offset = "0x2AFEB30", VA = "0x182B00130", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x2B00210", Offset = "0x2AFEC10", VA = "0x182B00210", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x2B00360", Offset = "0x2AFED60", VA = "0x182B00360", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x2B001A0", Offset = "0x2AFEBA0", VA = "0x182B001A0")]
		private void HDDMNONJNBD(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public PostGameplayOnScopeChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[LOEOGANCBGC(EDPDLGMLNHJ.Scope)]
	internal class PreventDisembodiedScopesSystem : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private EntityQuery OFFPHOPFBNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private EntityHierarchyParents FEENBFHHDPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private DGINFINNHOA AJKFPKEIFME;

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x2B01860", Offset = "0x2B00260", VA = "0x182B01860", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x2B01A80", Offset = "0x2B00480", VA = "0x182B01A80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x2B01B20", Offset = "0x2B00520", VA = "0x182B01B20", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x2B018F0", Offset = "0x2B002F0", VA = "0x182B018F0")]
		private void MLEDFPKAKMK(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public PreventDisembodiedScopesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Scope)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	internal class RemotePlayerScopeSystem : ScopeSystemBase<DFMDAICAJLO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x2BFBAC0", Offset = "0x2BFA4C0", VA = "0x182BFBAC0", Slot = "14")]
		protected override void GILMEPGMBMB(NativeArray<Entity> CGCCIONMJJA, NativeArray<Entity> JCAOFGAOHHH, NativeArray<Entity> GFMALAJIIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x2BFB9F0", Offset = "0x2BFA3F0", VA = "0x182BFB9F0")]
		[BurstCompile]
		private static void GILMEPGMBMB(NativeArray<Entity> CGCCIONMJJA, NativeArray<Entity> GFMALAJIIAP, ComponentDataFromEntity<global::CBEKEBCALNB> KDPECKCIHAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x2BFBC50", Offset = "0x2BFA650", VA = "0x182BFBC50")]
		public RemotePlayerScopeSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x2BFBC10", Offset = "0x2BFA610", VA = "0x182BFBC10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Scope)]
	internal abstract class ScopeSystemBase<TPlayerTag> : FOMCGHGDFHL where TPlayerTag : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private EntityQuery CEPBFJKJFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private EntityQuery ENMBKNJBPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private EntityQuery KFKCIBIFILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private EntityQuery CFEECGKENEL;

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x3D30220", Offset = "0x3D2EC20", VA = "0x183D30220", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x3D30420", Offset = "0x3D2EE20", VA = "0x183D30420", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x3D303F0", Offset = "0x3D2EDF0", VA = "0x183D303F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F370", Offset = "0x3D2DD70", VA = "0x183D2F370")]
		private void IJOLNFONMPJ(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E750", Offset = "0x3D2D150", VA = "0x183D2E750")]
		private void BEPCIGCDPOJ(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FC00", Offset = "0x3D2E600", VA = "0x183D2FC00")]
		private void OFAONDLCJDN(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void GILMEPGMBMB(NativeArray<Entity> CGCCIONMJJA, NativeArray<Entity> JCAOFGAOHHH, NativeArray<Entity> GFMALAJIIAP);

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x2EACBC0", Offset = "0x2EAB5C0", VA = "0x182EACBC0")]
		protected ScopeSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x17A91C0", Offset = "0x17A7BC0", VA = "0x1817A91C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class FGEECEJLLKG : FOMCGHGDFHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	private List<(EntityQuery, ComponentType)> EIGABIBFMBF;

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x2C177E0", Offset = "0x2C161E0", VA = "0x182C177E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x2C179E0", Offset = "0x2C163E0", VA = "0x182C179E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x2C17B30", Offset = "0x2C16530", VA = "0x182C17B30")]
	public FGEECEJLLKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct GFPOOOEKNFJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public int FOHLPAKJEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public int BNNADFINGPC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A1E0", Offset = "0x2C18BE0", VA = "0x182C1A1E0")]
	public static Entity EGMKMIPNLBF(GFPOOOEKNFJ NIPBPKPBPPP)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A1E0", Offset = "0x2C18BE0", VA = "0x182C1A1E0")]
	public static GFPOOOEKNFJ EGMKMIPNLBF(Entity GOANOLJBHPF)
	{
		return default(GFPOOOEKNFJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct KMGNKCDMNEA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct IMKLILNFGJP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly ComponentType NOIFPDMFLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	public readonly NativeList<int> IMCOAJBLBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	public readonly NativeList<int> DPEDIDCCLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	public readonly NativeArray<Entity> CGCCIONMJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	public readonly NativeArray<Entity> GJDONBOOLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	public readonly NativeArray<byte> BOEPCGGJPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	public readonly NativeArray<byte> AIAOJCAJMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	public readonly int PAKMGNPBKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	public readonly int HBKKMJCJHNG;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool DEBDHPIAODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x2C25480", Offset = "0x2C23E80", VA = "0x182C25480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x2C25550", Offset = "0x2C23F50", VA = "0x182C25550")]
	public IMKLILNFGJP(ComponentType NOIFPDMFLMJ, NativeList<int> IMCOAJBLBJG, NativeList<int> DPEDIDCCLEO, NativeArray<Entity> CGCCIONMJJA, NativeArray<Entity> GJDONBOOLLP, NativeArray<byte> BOEPCGGJPAN, NativeArray<byte> AIAOJCAJMCP, int PAKMGNPBKNN, int HBKKMJCJHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000958")]
	[Cpp2IlInjected.Address(RVA = "0x2C25220", Offset = "0x2C23C20", VA = "0x182C25220")]
	private DHBMIEMIIHO BFMAPNIEKEC(NativeArray<byte> GNPHBMKMMCM, int GFDMFLGCBKB)
	{
		return default(DHBMIEMIIHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000959")]
	private T BFMAPNIEKEC<T>(NativeArray<byte> GNPHBMKMMCM, int GFDMFLGCBKB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095A")]
	[Cpp2IlInjected.Address(RVA = "0x2C25350", Offset = "0x2C23D50", VA = "0x182C25350")]
	public DHBMIEMIIHO DNPEGJKDFKK(int GFDMFLGCBKB)
	{
		return default(DHBMIEMIIHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600095B")]
	public T DNPEGJKDFKK<T>(int GFDMFLGCBKB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095C")]
	[Cpp2IlInjected.Address(RVA = "0x2C25500", Offset = "0x2C23F00", VA = "0x182C25500")]
	public DHBMIEMIIHO PIAJFKJBHAI(int GFDMFLGCBKB)
	{
		return default(DHBMIEMIIHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600095D")]
	public T PIAJFKJBHAI<T>(int GFDMFLGCBKB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x2C253A0", Offset = "0x2C23DA0", VA = "0x182C253A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public readonly struct NEHEJIIOPJI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	public readonly EntityQuery CAMLCFELNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	public readonly NativeArray<JMBKIJJOIEJ> PDPOLFACNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	public readonly ComponentType NOIFPDMFLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	public readonly int PAKMGNPBKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400040C")]
	public readonly int HBKKMJCJHNG;

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE8000", Offset = "0x2AE6A00", VA = "0x182AE8000")]
	public NEHEJIIOPJI(ComponentType NOIFPDMFLMJ, int PAKMGNPBKNN, int HBKKMJCJHNG, EntityQuery CAMLCFELNDE, NativeArray<JMBKIJJOIEJ> PDPOLFACNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7FB0", Offset = "0x2AE69B0", VA = "0x182AE7FB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal struct CNDBOAFKMJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	public int GFDMFLGCBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	public int JIHPNJMIBKG;

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x6E2050", Offset = "0x6E0A50", VA = "0x1806E2050")]
	public CNDBOAFKMJH(int GFDMFLGCBKB, int JIHPNJMIBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public struct JMBKIJJOIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	public readonly int JFKBHBKKACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	public readonly int HGBOOPNCHBL;

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x6E2050", Offset = "0x6E0A50", VA = "0x1806E2050")]
	public JMBKIJJOIEJ(int JFKBHBKKACD, int HGBOOPNCHBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
public struct NDHLMGGHOHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private readonly JBNNELNIDOD OGGLMCNMCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly int PAKMGNPBKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private unsafe readonly byte* BOEPCGGJPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private unsafe readonly byte* AIAOJCAJMCP;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool MPANJOCJMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7DA0", Offset = "0x2AE67A0", VA = "0x182AE7DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public JBNNELNIDOD OBLECFEGGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20")]
		get
		{
			return default(JBNNELNIDOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7EA0", Offset = "0x2AE68A0", VA = "0x182AE7EA0")]
	public DHBMIEMIIHO KLMCDEGJHBF(Type MAHAMGBPDNB)
	{
		return default(DHBMIEMIIHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7DB0", Offset = "0x2AE67B0", VA = "0x182AE7DB0")]
	public DHBMIEMIIHO KDFGOIJCFKM(Type MAHAMGBPDNB)
	{
		return default(DHBMIEMIIHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x2BF12C0", Offset = "0x2BEFCC0", VA = "0x182BF12C0")]
	public T KLMCDEGJHBF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x2BF12A0", Offset = "0x2BEFCA0", VA = "0x182BF12A0")]
	public T KDFGOIJCFKM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7F90", Offset = "0x2AE6990", VA = "0x182AE7F90")]
	public unsafe NDHLMGGHOHI(JBNNELNIDOD OGGLMCNMCLJ, int HGBOOPNCHBL, byte* BOEPCGGJPAN, byte* AIAOJCAJMCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal abstract class GMDJAPANGIH : PMCACKOJIOD, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private PropertyDiffStateService CPODMNBDJHH;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected abstract DHNNDIENLFJ LCCGLIHDNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A9D0", Offset = "0x2C193D0", VA = "0x182C1A9D0", Slot = "17")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x2C1AC60", Offset = "0x2C19660", VA = "0x182C1AC60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x2C1AA20", Offset = "0x2C19420", VA = "0x182C1AA20", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	protected GMDJAPANGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public static class POOAKGEBDHD
{
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] ADNCBLHKPEK;
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
[DefaultMember("Item")]
internal class OPOIKGEPLKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly KGOHPJFJCLE LHMILDDMKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly Dictionary<ComponentType, NEHEJIIOPJI> OLKMBFLGFFN;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public NEHEJIIOPJI NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x2AED530", Offset = "0x2AEBF30", VA = "0x182AED530")]
		get
		{
			return default(NEHEJIIOPJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x2AEDE80", Offset = "0x2AEC880", VA = "0x182AEDE80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDF60", Offset = "0x2AEC960", VA = "0x182AEDF60")]
	public OPOIKGEPLKG(DEAGKEFEBKN ALIKEONHNHI, KGOHPJFJCLE LHMILDDMKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x2AED9C0", Offset = "0x2AEC3C0", VA = "0x182AED9C0")]
	public bool CKMNFEFPOIP(ComponentType NOIFPDMFLMJ, out NEHEJIIOPJI JAGMMDGFNGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDED0", Offset = "0x2AEC8D0", VA = "0x182AEDED0")]
	public Dictionary<ComponentType, NEHEJIIOPJI>.Enumerator OGILHMGHFKK()
	{
		return default(Dictionary<ComponentType, NEHEJIIOPJI>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDA30", Offset = "0x2AEC430", VA = "0x182AEDA30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x2AED5C0", Offset = "0x2AEBFC0", VA = "0x182AED5C0")]
	private void CBCONFGMCFO(IEnumerable<OOILAAHGBJC> IMLPKBNPJKJ, EntityManager BJMEFCCEPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x2AED480", Offset = "0x2AEBE80", VA = "0x182AED480")]
	private static int BCDFNMIHKGG(OOILAAHGBJC HEGIPKLPDFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x2AEDBD0", Offset = "0x2AEC5D0", VA = "0x182AEDBD0")]
	private static NativeArray<JMBKIJJOIEJ> IPELDFDKEME(OOILAAHGBJC HEGIPKLPDFM, Allocator GGPAKDMJHLJ = Allocator.Persistent)
	{
		return default(NativeArray<JMBKIJJOIEJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal interface NEBKGLHCLEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	bool DEBDHPIAODG
	{
		[Cpp2IlInjected.Token(Token = "0x600097B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	World HPHMIKCABBH
	{
		[Cpp2IlInjected.Token(Token = "0x600097C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MEDEEIHFLGP(out NativeArray<int> GLMCNJLIMCG, Allocator GGPAKDMJHLJ);

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NNFDACGCHJF(ComponentType NOIFPDMFLMJ, out IMKLILNFGJP JFLKLBLBBCJ, out NEHEJIIOPJI KHEIMOEOLED);

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NNFDACGCHJF(ComponentType NOIFPDMFLMJ, out IMKLILNFGJP JFLKLBLBBCJ);

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IMKLILNFGJP PMMLNDALEBB(ComponentType NOIFPDMFLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HKJCDGEBOAC FPNPDBHMHKD();

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LDHLHCOOHON(JobHandle NNGFCFNIJKL);
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
internal interface DLFINNIIPGN
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	World HPHMIKCABBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000983")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	OPOIKGEPLKG GOKOLGJLJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	EIAFJKLDNIF NKFCJOKKMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	NativeMultiHashMap<Entity, NDHLMGGHOHI> LAPIECJNMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	JobHandle OODMMJMGJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000988")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HAKOKLHEDIO();

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMFIICNHENP();

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NCPDAFIIPOO(ComponentType NOIFPDMFLMJ, in IMKLILNFGJP JIIHAKIHFMH);

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LJHJBEBFDGM(AOIKBHJMDBO GDAJCNKPBDC, out Entity JFEEEILBEOO);
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal struct HKJCDGEBOAC
{
	[Cpp2IlInjected.Token(Token = "0x200014F")]
	public struct IALHJFOPCBM : IEnumerator<NDHLMGGHOHI>, IEnumerator, IDisposable, IEnumerable<NDHLMGGHOHI>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private readonly NativeMultiHashMap<Entity, NDHLMGGHOHI> INLJGFGAJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private readonly Entity GOANOLJBHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private NativeMultiHashMapIterator<Entity> ACPBDFJABKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private NDHLMGGHOHI AIAOJCAJMCP;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		public NDHLMGGHOHI PKICFDONLKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0xCB8D70", Offset = "0xCB7770", VA = "0x180CB8D70", Slot = "4")]
			get
			{
				return default(NDHLMGGHOHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4630", Offset = "0x3FF3030", VA = "0x183FF4630", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4680", Offset = "0x3FF3080", VA = "0x183FF4680")]
		internal IALHJFOPCBM(NativeMultiHashMap<Entity, NDHLMGGHOHI> INLJGFGAJKF, Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x3FF43F0", Offset = "0x3FF2DF0", VA = "0x183FF43F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x3FF44C0", Offset = "0x3FF2EC0", VA = "0x183FF44C0")]
		public IALHJFOPCBM OGILHMGHFKK()
		{
			return default(IALHJFOPCBM);
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x3FF44F0", Offset = "0x3FF2EF0", VA = "0x183FF44F0", Slot = "9")]
		private IEnumerator<NDHLMGGHOHI> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4590", Offset = "0x3FF2F90", VA = "0x183FF4590", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly DLFINNIIPGN MKPFHFLNAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly JobHandle LMOBHBPPBPO;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public int GCDFHEFEFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x2C20D80", Offset = "0x2C1F780", VA = "0x182C20D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool NJLNECGPIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x2C209F0", Offset = "0x2C1F3F0", VA = "0x182C209F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE41D0", Offset = "0x1FE2BD0", VA = "0x181FE41D0")]
	public HKJCDGEBOAC(DLFINNIIPGN MKPFHFLNAEL, JobHandle LMOBHBPPBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x2C20AD0", Offset = "0x2C1F4D0", VA = "0x182C20AD0")]
	public bool FHHHBBHFEIF(Allocator GGPAKDMJHLJ, out NativeKeyValueArrays<Entity, NDHLMGGHOHI> OAFMFLFMLNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x2C20C10", Offset = "0x2C1F610", VA = "0x182C20C10")]
	public bool JMIEFFCCEEK(Allocator GGPAKDMJHLJ, out (NativeArray<Entity> entities, int uniqueCount) OAFMFLFMLNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x2C208D0", Offset = "0x2C1F2D0", VA = "0x182C208D0")]
	public IALHJFOPCBM AJLJNLCGALF(Entity GOANOLJBHPF)
	{
		return default(IALHJFOPCBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[DefaultMember("Item")]
internal class EIAFJKLDNIF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly KGOHPJFJCLE LHMILDDMKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly List<NEHEJIIOPJI> OKDFPKLCDDM;

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public NEHEJIIOPJI NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x2E076B0", Offset = "0x2E060B0", VA = "0x182E076B0")]
		get
		{
			return default(NEHEJIIOPJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x2E07C00", Offset = "0x2E06600", VA = "0x182E07C00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x2E07CC0", Offset = "0x2E066C0", VA = "0x182E07CC0")]
	public EIAFJKLDNIF(OPOIKGEPLKG OLKMBFLGFFN, DEAGKEFEBKN ALIKEONHNHI, KGOHPJFJCLE LHMILDDMKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x2E07C40", Offset = "0x2E06640", VA = "0x182E07C40")]
	public List<NEHEJIIOPJI>.Enumerator OGILHMGHFKK()
	{
		return default(List<NEHEJIIOPJI>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x2E07A80", Offset = "0x2E06480", VA = "0x182E07A80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x2E07740", Offset = "0x2E06140", VA = "0x182E07740")]
	private void CBCONFGMCFO(OPOIKGEPLKG OLKMBFLGFFN, EntityManager BJMEFCCEPHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal class LFCKLHJEONJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private readonly KGOHPJFJCLE LHMILDDMKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private readonly ObjectInstantiationService HPAFIPNLAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private readonly global::OKLNGFEDEOH<OOILAAHGBJC> OPIKAFFOFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private readonly World LMPFDLJPFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private readonly EntityManager BJMEFCCEPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private NativeHashMap<int, Entity> DPLECGMODAI;

	[Cpp2IlInjected.Token(Token = "0x60009A2")]
	[Cpp2IlInjected.Address(RVA = "0x2C32060", Offset = "0x2C30A60", VA = "0x182C32060")]
	public LFCKLHJEONJ(ObjectInstantiationService HPAFIPNLAIL, DEAGKEFEBKN ALIKEONHNHI, KGOHPJFJCLE LHMILDDMKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A3")]
	[Cpp2IlInjected.Address(RVA = "0x2C30E90", Offset = "0x2C2F890", VA = "0x182C30E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A4")]
	[Cpp2IlInjected.Address(RVA = "0x2C31BD0", Offset = "0x2C305D0", VA = "0x182C31BD0")]
	public bool HNHIBNDKIOP(AOIKBHJMDBO GDAJCNKPBDC, out Entity JFEEEILBEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x2C30F60", Offset = "0x2C2F960", VA = "0x182C30F60")]
	private void FBAFIMMJNEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x2C316A0", Offset = "0x2C300A0", VA = "0x182C316A0")]
	private EntityArchetype HDKCPNOEFAM(EntityArchetype NPDNJIBICCD)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x2C31C30", Offset = "0x2C30630", VA = "0x182C31C30")]
	public static void JKOAHDDAJHJ(EntityManager OIBJDJMEICO, EntityManager NCLMKLFAEMH, NativeArray<Entity> LDEKFDONKGC, NativeArray<EntityArchetype> FBBPACCDGAJ, [Optional] NativeArray<Entity> IOKHLOLAHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x2C30D20", Offset = "0x2C2F720", VA = "0x182C30D20")]
	[Conditional("DEBUG_BUILD")]
	private static void DOLFLENHHJI(NativeArray<EntityArchetype> HLFMABEDCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x2C307F0", Offset = "0x2C2F1F0", VA = "0x182C307F0")]
	private static string ACNDEKJFKHH(EntityArchetype COAKPOHIAFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x2C30A30", Offset = "0x2C2F430", VA = "0x182C30A30")]
	[CompilerGenerated]
	internal static void AMBKEOHAAOJ(ref Span<ComponentType> FHFDAIPIGKG, ComponentType MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x2C30B70", Offset = "0x2C2F570", VA = "0x182C30B70")]
	[CompilerGenerated]
	internal static void CDHMOOLOIEF(Span<ComponentType> GNPHBMKMMCM, ref Span<ComponentType> FHFDAIPIGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x2C315C0", Offset = "0x2C2FFC0", VA = "0x182C315C0")]
	[CompilerGenerated]
	internal static void FBEKNJDEPDB(Span<ComponentType> GNPHBMKMMCM, ref Span<ComponentType> FHFDAIPIGKG, ComponentType NIAMNELIJLG)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[LOEOGANCBGC(EDPDLGMLNHJ.PropertyChanges)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	public sealed class ApplyPropertyDifferencesToShadowWorld : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private ShadowWorldApplyPropertyDifferencesToShadowWorld LHECKAMADGM;

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFCA0", Offset = "0x2DEE6A0", VA = "0x182DEFCA0", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x2DEFD60", Offset = "0x2DEE760", VA = "0x182DEFD60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public ApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[AlwaysUpdateSystem]
	[LOEOGANCBGC(EDPDLGMLNHJ.PropertyChanges)]
	public class ComputeDifferencesFromShadowWorld : FOMCGHGDFHL, MMKNGEFLOAO, PKBAIAJJFPF
	{
		[Cpp2IlInjected.Token(Token = "0x2000154")]
		[BurstCompile]
		internal struct BHCFNEOMPHH : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			[ReadOnly]
			public NativeArray<byte> AOOCEFJDAHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			[ReadOnly]
			public NativeArray<byte> OHLLEECICOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			[ReadOnly]
			public NativeArray<JMBKIJJOIEJ> KPGMMAHBADM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			[WriteOnly]
			public NativeList<CNDBOAFKMJH>.ParallelWriter HFOGMBLMNAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public int HMGFLPHOJOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int IACMFPCMDEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public ProfilerMarker JOJLKFBDDJE;

			[Cpp2IlInjected.Token(Token = "0x60009CE")]
			[Cpp2IlInjected.Address(RVA = "0x2BF62F0", Offset = "0x2BF4CF0", VA = "0x182BF62F0", Slot = "4")]
			public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009CF")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6430", Offset = "0x2BF4E30", VA = "0x182BF6430")]
			private unsafe int MOMDGAHEPEK(byte* ELPCCKEDKKL, byte* DCIOCIFFEAC)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000155")]
		[BurstCompile]
		internal struct KAIPNDMCGMD : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			[WriteOnly]
			public NativeList<int> IMCOAJBLBJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			[WriteOnly]
			public NativeList<int> MGNOLGOJKOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			[ReadOnly]
			public NativeList<CNDBOAFKMJH> CDMMCLCBLOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public ProfilerMarker JOJLKFBDDJE;

			[Cpp2IlInjected.Token(Token = "0x60009D0")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7E50", Offset = "0x2BF6850", VA = "0x182BF7E50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000156")]
		[BurstCompile]
		internal struct EFCJACDKIIL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			[WriteOnly]
			public NativeArray<byte> CCJPJDCAGNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			[ReadOnly]
			public NativeArray<Entity> CGCCIONMJJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			[ReadOnly]
			public ComponentDataFromEntity MFDPIDPKMMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int PAKMGNPBKNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public ProfilerMarker JOJLKFBDDJE;

			[Cpp2IlInjected.Token(Token = "0x60009D1")]
			[Cpp2IlInjected.Address(RVA = "0x2BF70A0", Offset = "0x2BF5AA0", VA = "0x182BF70A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000157")]
		[BurstCompile]
		internal struct KLBIMOMCHBJ : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, NDHLMGGHOHI> PLEGODNICJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			[ReadOnly]
			public NativeArray<byte> BOEPCGGJPAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			[ReadOnly]
			public NativeArray<byte> AIAOJCAJMCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			[ReadOnly]
			public NativeArray<Entity> CGCCIONMJJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			[ReadOnly]
			public NativeArray<JMBKIJJOIEJ> LIDPPGPILCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			[ReadOnly]
			public NativeList<int> DPEDIDCCLEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			[ReadOnly]
			public NativeList<int> IMCOAJBLBJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int OFJJECLCODK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public int HBKKMJCJHNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public ProfilerMarker JOJLKFBDDJE;

			[Cpp2IlInjected.Token(Token = "0x60009D2")]
			[Cpp2IlInjected.Address(RVA = "0x2BF80B0", Offset = "0x2BF6AB0", VA = "0x182BF80B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private static readonly ProfilerMarker BKLGKHCCJGP;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private static readonly ProfilerMarker ABHLAJOCCIJ;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private static readonly ProfilerMarker PGHHGMIAEHB;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private static readonly ProfilerMarker GLMACEJHKJL;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private static readonly ProfilerMarker EBKBFJLJFLD;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private static readonly ProfilerMarker FDLDEODPECC;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private static readonly ProfilerMarker CLJCHACENPG;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private static readonly ProfilerMarker BAMDPCFOBLP;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private static readonly ProfilerMarker FBBKFHAJAPC;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private static readonly ProfilerMarker KJDNHFMNOFP;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private static readonly ProfilerMarker HLFIAOJFMMP;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private static readonly ProfilerMarker IIIOHNKLFAE;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private static readonly ProfilerMarker FLHGAJKNGNN;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private static readonly ProfilerMarker OGCCGMPKPOH;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private static readonly ProfilerMarker CLBIEJMOFBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private PropertyDiffStateService CPODMNBDJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private EntityQuery ACDKGJLCOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private EntityQuery CEPFNNLNFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private EntityQuery HJEJCIHGFEI;

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		internal World HPHMIKCABBH
		{
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x2DF9790", Offset = "0x2DF8190", VA = "0x182DF9790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		private DLFINNIIPGN MFLHBGHJMAA
		{
			[Cpp2IlInjected.Token(Token = "0x60009B2")]
			[Cpp2IlInjected.Address(RVA = "0x2DF83C0", Offset = "0x2DF6DC0", VA = "0x182DF83C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x2DF83E0", Offset = "0x2DF6DE0", VA = "0x182DF83E0", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "15")]
		public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA060", Offset = "0x2DF8A60", VA = "0x182DFA060", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B6")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA220", Offset = "0x2DF8C20", VA = "0x182DFA220", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA1B0", Offset = "0x2DF8BB0", VA = "0x182DFA1B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7B70", Offset = "0x2DF6570", VA = "0x182DF7B70")]
		private void DFLKNHELOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7B50", Offset = "0x2DF6550", VA = "0x182DF7B50")]
		internal void DAFKOIKEBHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7380", Offset = "0x2DF5D80", VA = "0x182DF7380")]
		private void DAFKOIKEBHD(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9440", Offset = "0x2DF7E40", VA = "0x182DF9440")]
		private void JOFLHBKJGBA(NativeArray<Entity> LDEKFDONKGC, NativeArray<RRObjectPrefabData> CJOLHGALFLB, ref NativeArray<Entity> OBAAMIECGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x2DF85F0", Offset = "0x2DF6FF0", VA = "0x182DF85F0")]
		internal void JEELJBDJDKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8610", Offset = "0x2DF7010", VA = "0x182DF8610")]
		private void JEELJBDJDKM(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9900", Offset = "0x2DF8300", VA = "0x182DF9900")]
		internal void NMPODBPHPHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7E70", Offset = "0x2DF6870", VA = "0x182DF7E70")]
		private void EMOBOODLNAA(DLFINNIIPGN MKPFHFLNAEL, NEHEJIIOPJI KHEIMOEOLED, bool NJEBLJFKGJJ, ref JobHandle CLAINIGAPCO, ref JobHandle MNLMNHPADMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8A10", Offset = "0x2DF7410", VA = "0x182DF8A10")]
		internal bool JOFJNCBDMCH(in NEHEJIIOPJI DCIOCIFFEAC, out JobHandle BIONDBIGACN, out IMKLILNFGJP LOFFNHEHLIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C1")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8A40", Offset = "0x2DF7440", VA = "0x182DF8A40")]
		private bool JOFJNCBDMCH(in NEHEJIIOPJI DCIOCIFFEAC, bool NJEBLJFKGJJ, out JobHandle BIONDBIGACN, out IMKLILNFGJP LOFFNHEHLIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C2")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8430", Offset = "0x2DF6E30", VA = "0x182DF8430")]
		internal (NativeList<int>, NativeList<int>) JEAHJJNJKLJ(NativeList<CNDBOAFKMJH> CDMMCLCBLOL, int ADCMDGEMNDH, JobHandle MJAFFEAEOFD, out JobHandle NNGFCFNIJKL, Allocator GGPAKDMJHLJ = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x60009C3")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9850", Offset = "0x2DF8250", VA = "0x182DF9850")]
		internal static NativeArray<Entity> LDAINGBIPIO(EntityQuery CAMLCFELNDE, out JobHandle BMJMMJDPFBC)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C4")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7300", Offset = "0x2DF5D00", VA = "0x182DF7300")]
		internal static NativeArray<byte> CFKBILHGIDP(int FMIGDHLBIKP, out JobHandle LODDPABEBFB)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C5")]
		[Cpp2IlInjected.Address(RVA = "0x2DF9680", Offset = "0x2DF8080", VA = "0x182DF9680")]
		internal static NativeArray<byte> KGACNKNEKBL(EntityQuery CAMLCFELNDE, int MDNDIFHMDOM, out JobHandle LODDPABEBFB)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7070", Offset = "0x2DF5A70", VA = "0x182DF7070")]
		internal static NativeArray<Entity> APAAGHKAPAM(EntityQuery CAMLCFELNDE, out JobHandle BNCODPOIPNN)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x2DF8150", Offset = "0x2DF6B50", VA = "0x182DF8150")]
		internal NativeArray<byte> FEAGPFDDDDN(NativeArray<Entity> CGCCIONMJJA, NEHEJIIOPJI KHEIMOEOLED, JobHandle MJAFFEAEOFD, out JobHandle NNGFCFNIJKL, Allocator GGPAKDMJHLJ = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x2DF7170", Offset = "0x2DF5B70", VA = "0x182DF7170")]
		internal JobHandle BGNDDJMDHFB(in IMKLILNFGJP NIPBPKPBPPP, in NEHEJIIOPJI KHEIMOEOLED, NativeMultiHashMap<Entity, NDHLMGGHOHI> PLEGODNICJP, JobHandle MJAFFEAEOFD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x19EC320", Offset = "0x19EAD20", VA = "0x1819EC320")]
		private JobHandle CCHEDHLIBHJ(JobHandle OPOOKHLMDBD, JobHandle MNJGAIKEDAC)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x19EC320", Offset = "0x19EAD20", VA = "0x1819EC320")]
		private JobHandle CCHEDHLIBHJ(JobHandle OPOOKHLMDBD, JobHandle MNJGAIKEDAC, JobHandle HDGEJMKDGKN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public ComputeDifferencesFromShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[LOEOGANCBGC(EDPDLGMLNHJ.RenderEffects)]
	internal class PropagateHoverRootTag : NNMABKLJCPE
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000159")]
		public struct COLEKFBMADG : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		protected override ComponentType ANPOJKNNCKC
		{
			[Cpp2IlInjected.Token(Token = "0x60009D3")]
			[Cpp2IlInjected.Address(RVA = "0x2B02430", Offset = "0x2B00E30", VA = "0x182B02430", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		protected override ComponentType ECFGABMNABP
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x2B02400", Offset = "0x2B00E00", VA = "0x182B02400", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		protected override ComponentType BKLNMJPBNAG
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0x2B02460", Offset = "0x2B00E60", VA = "0x182B02460", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x2AE98C0", Offset = "0x2AE82C0", VA = "0x182AE98C0")]
		public PropagateHoverRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[LOEOGANCBGC(EDPDLGMLNHJ.RenderEffects)]
	internal class PropagateSelectionRootTag : NNMABKLJCPE
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200015B")]
		public struct LPOHKCJPLCL : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		protected override ComponentType ANPOJKNNCKC
		{
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x2B024C0", Offset = "0x2B00EC0", VA = "0x182B024C0", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		protected override ComponentType ECFGABMNABP
		{
			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x2B02490", Offset = "0x2B00E90", VA = "0x182B02490", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override ComponentType BKLNMJPBNAG
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0x2B024F0", Offset = "0x2B00EF0", VA = "0x182B024F0", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x2AE98C0", Offset = "0x2AE82C0", VA = "0x182AE98C0")]
		public PropagateSelectionRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DC")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
[GCANBDAKNID]
public class FIDEMMBEJME : PPPEJONEMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	private EntityQuery CAMLCFELNDE;

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x2C17BB0", Offset = "0x2C165B0", VA = "0x182C17BB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x2C17C40", Offset = "0x2C16640", VA = "0x182C17C40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public FIDEMMBEJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
[GCANBDAKNID]
public class KJJFFLCPILE : PPPEJONEMKB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct DPIBNKCFBBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		public DPIBNKCFBBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointParentData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct OLJKLDAAGHL : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000160")]
		private struct KFNEFNJEJIL
		{
			[Cpp2IlInjected.Token(Token = "0x2000161")]
			[NoAlias]
			public struct JNFFPPPALBB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000463")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime GOMPAMBNHKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000464")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointParentData>.Runtime MNGPNDPGOPO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity ONOBANIBHPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<SplinePointParentData> HHLBDGDGDLC;

			[Cpp2IlInjected.Token(Token = "0x60009EE")]
			[Cpp2IlInjected.Address(RVA = "0x3FF5DC0", Offset = "0x3FF47C0", VA = "0x183FF5DC0")]
			public void DMNACDEGIGE(KJJFFLCPILE PIJJDNMKBBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009EF")]
			[Cpp2IlInjected.Address(RVA = "0x3FF5E20", Offset = "0x3FF4820", VA = "0x183FF5E20")]
			public JNFFPPPALBB KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
			{
				return default(JNFFPPPALBB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public EntityManager BJMEFCCEPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public NativeList<Entity> IIGILJBOBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private KFNEFNJEJIL NNPBNEEGOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KFNEFNJEJIL.JNFFPPPALBB* BEIHMNNJOAB;

		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IMKGCCNGKJM;

		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KLJOCPOGLLD;

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x3FF9840", Offset = "0x3FF8240", VA = "0x183FF9840")]
		internal void EJGOAEBMHCL(Entity GOANOLJBHPF, SplinePointParentData OMMEPJAJELH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x3FF9A70", Offset = "0x3FF8470", VA = "0x183FF9A70", Slot = "5")]
		public void ReadFromDisplayClass(ref DPIBNKCFBBL LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x3FF9A80", Offset = "0x3FF8480", VA = "0x183FF9A80", Slot = "6")]
		public void WriteToDisplayClass(ref DPIBNKCFBBL LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x3FF98B0", Offset = "0x3FF82B0", VA = "0x183FF98B0", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x3FF99C0", Offset = "0x3FF83C0", VA = "0x183FF99C0")]
		public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, [NoAlias] ref KFNEFNJEJIL.JNFFPPPALBB DNOHEDJMLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x3FF97B0", Offset = "0x3FF81B0", VA = "0x183FF97B0")]
		public void DMNACDEGIGE(KJJFFLCPILE PIJJDNMKBBD, ref DPIBNKCFBBL LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x3FF9950", Offset = "0x3FF8350", VA = "0x183FF9950")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void IDLGLLJOIMC(ArchetypeChunkIterator* MBPLNPAGJMC, void* MAKNNDOILNI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private EntityQuery FFAOEMPKNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private ProfilerMarker NABCJPPGAGC;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C2CC70", Offset = "0x2C2B670", VA = "0x182C2CC70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public KJJFFLCPILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C2CA40", Offset = "0x2C2B440", VA = "0x182C2CA40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x2C2C8E0", Offset = "0x2C2B2E0", VA = "0x182C2C8E0")]
	public static EntityQuery GHIOHFNMEMD(ComponentSystemBase PIJJDNMKBBD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
[GCANBDAKNID]
public class AKCGAJDACFH : PPPEJONEMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private EntityQuery JLPAHNJKDDH;

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x2DEEB60", Offset = "0x2DED560", VA = "0x182DEEB60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x2DEEBF0", Offset = "0x2DED5F0", VA = "0x182DEEBF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public AKCGAJDACFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[UpdateAfter(typeof(FIDEMMBEJME))]
public class DHIAHAAAMHH : FOMCGHGDFHL
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x2E02E20", Offset = "0x2E01820", VA = "0x182E02E20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public DHIAHAAAMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
public class ELCOADILHFP : PPPEJONEMKB, MMKNGEFLOAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	private struct KNBLFNGOFAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public NativeHashMap<AKLFKNOOHJC, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		public KNBLFNGOFAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HFPCLOOJPPA : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000167")]
		private struct JNJFBDNKBIC
		{
			[Cpp2IlInjected.Token(Token = "0x2000168")]
			public struct OEHOEMLOFHH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000470")]
				public LambdaParameterValueProvider_Entity.Runtime GOMPAMBNHKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000471")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime LMHGHHDCDHJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity ONOBANIBHPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> LALLHBMJBFL;

			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4E80", Offset = "0x3FF3880", VA = "0x183FF4E80")]
			public void DMNACDEGIGE(ELCOADILHFP PIJJDNMKBBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0x3FF4EE0", Offset = "0x3FF38E0", VA = "0x183FF4EE0")]
			public OEHOEMLOFHH KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
			{
				return default(OEHOEMLOFHH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public NativeHashMap<AKLFKNOOHJC, Entity> INLJGFGAJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private JNJFBDNKBIC NNPBNEEGOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe JNJFBDNKBIC.OEHOEMLOFHH* BEIHMNNJOAB;

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IMKGCCNGKJM;

		[Cpp2IlInjected.Token(Token = "0x60009FE")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7AE0", Offset = "0x2BF64E0", VA = "0x182BF7AE0")]
		internal void EJGOAEBMHCL(Entity GOANOLJBHPF, ObjectNetworkIdComponentData GDDOKOBFJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FF")]
		[Cpp2IlInjected.Address(RVA = "0x11488C0", Offset = "0x11472C0", VA = "0x1811488C0", Slot = "5")]
		public void ReadFromDisplayClass(ref KNBLFNGOFAL LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A00")]
		[Cpp2IlInjected.Address(RVA = "0x22D7DA0", Offset = "0x22D67A0", VA = "0x1822D7DA0", Slot = "6")]
		public void WriteToDisplayClass(ref KNBLFNGOFAL LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7B60", Offset = "0x2BF6560", VA = "0x182BF7B60", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7C40", Offset = "0x2BF6640", VA = "0x182BF7C40")]
		public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, ref JNJFBDNKBIC.OEHOEMLOFHH DNOHEDJMLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A03")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7AA0", Offset = "0x2BF64A0", VA = "0x182BF7AA0")]
		public void DMNACDEGIGE(ELCOADILHFP PIJJDNMKBBD, ref KNBLFNGOFAL LAJFEJAHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7BD0", Offset = "0x2BF65D0", VA = "0x182BF7BD0")]
		public unsafe static void IDLGLLJOIMC(ArchetypeChunkIterator* MBPLNPAGJMC, void* MAKNNDOILNI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private ObjectNetworkToLocalMapService KGCOHGMEJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private EntityQuery FFAOEMPKNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private ProfilerMarker NABCJPPGAGC;

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x2E08150", Offset = "0x2E06B50", VA = "0x182E08150", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0x2E083B0", Offset = "0x2E06DB0", VA = "0x182E083B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public ELCOADILHFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x2E081B0", Offset = "0x2E06BB0", VA = "0x182E081B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x2E07FF0", Offset = "0x2E069F0", VA = "0x182E07FF0")]
	public static EntityQuery GHIOHFNMEMD(ComponentSystemBase PIJJDNMKBBD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public class HFBIICPHLAN : PPPEJONEMKB, MMKNGEFLOAO
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct OCFBHPCBLHN : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		private struct NFCJLCGCNHI
		{
			[Cpp2IlInjected.Token(Token = "0x200016C")]
			public struct IJABJFMMDPB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400047B")]
				public LambdaParameterValueProvider_Entity.Runtime GOMPAMBNHKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400047C")]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime LMNNKCFGEGJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity ONOBANIBHPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> HBHOAPGCGOP;

			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x3FF87B0", Offset = "0x3FF71B0", VA = "0x183FF87B0")]
			public void DMNACDEGIGE(HFBIICPHLAN PIJJDNMKBBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0x3FF8810", Offset = "0x3FF7210", VA = "0x183FF8810")]
			public IJABJFMMDPB KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
			{
				return default(IJABJFMMDPB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public HFBIICPHLAN FAADGALECEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private NFCJLCGCNHI NNPBNEEGOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NFCJLCGCNHI.IJABJFMMDPB* BEIHMNNJOAB;

		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IMKGCCNGKJM;

		[Cpp2IlInjected.Token(Token = "0x6000A0D")]
		[Cpp2IlInjected.Address(RVA = "0x3FF91B0", Offset = "0x3FF7BB0", VA = "0x183FF91B0")]
		public void EJGOAEBMHCL(Entity GOANOLJBHPF, ParentData JCMAHEMHNEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0E")]
		[Cpp2IlInjected.Address(RVA = "0x3FF91D0", Offset = "0x3FF7BD0", VA = "0x183FF91D0", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0F")]
		[Cpp2IlInjected.Address(RVA = "0x3FF92E0", Offset = "0x3FF7CE0", VA = "0x183FF92E0")]
		public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, ref NFCJLCGCNHI.IJABJFMMDPB DNOHEDJMLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A10")]
		[Cpp2IlInjected.Address(RVA = "0x3FF9130", Offset = "0x3FF7B30", VA = "0x183FF9130")]
		public void DMNACDEGIGE(HFBIICPHLAN PIJJDNMKBBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A11")]
		[Cpp2IlInjected.Address(RVA = "0x3FF9270", Offset = "0x3FF7C70", VA = "0x183FF9270")]
		public unsafe static void IDLGLLJOIMC(ArchetypeChunkIterator* MBPLNPAGJMC, void* MAKNNDOILNI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	private HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private EntityQuery FFAOEMPKNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private ProfilerMarker NABCJPPGAGC;

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x2C1E330", Offset = "0x2C1CD30", VA = "0x182C1E330", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x2C1E780", Offset = "0x2C1D180", VA = "0x182C1E780", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public HFBIICPHLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x2C1E390", Offset = "0x2C1CD90", VA = "0x182C1E390")]
	[CompilerGenerated]
	private void IPLPIJHJLKE(Entity GOANOLJBHPF, ParentData JCMAHEMHNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x2C1E580", Offset = "0x2C1CF80", VA = "0x182C1E580", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x2C1E1D0", Offset = "0x2C1CBD0", VA = "0x182C1E1D0")]
	public static EntityQuery GHIOHFNMEMD(ComponentSystemBase PIJJDNMKBBD)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class GMMDFPHLNLC : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private int IEHNMFIGENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private EntityQuery CAMLCFELNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private ObjectPrefabs HPAFIPNLAIL;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x2C1AE20", Offset = "0x2C19820", VA = "0x182C1AE20", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B1C0", Offset = "0x2C19BC0", VA = "0x182C1B1C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B2A0", Offset = "0x2C19CA0", VA = "0x182C1B2A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x2C1AE70", Offset = "0x2C19870", VA = "0x182C1AE70")]
	private void KDMGCKMDKEF(Entity GOANOLJBHPF, AOIKBHJMDBO GDAJCNKPBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public GMMDFPHLNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Serialization)]
	[UpdateBefore(typeof(GMMDFPHLNLC))]
	public class PostLoadAddSceneTagEntity : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private SceneService DLIDPEKLJKC;

		[Cpp2IlInjected.Token(Token = "0x6000A1A")]
		[Cpp2IlInjected.Address(RVA = "0x2B00470", Offset = "0x2AFEE70", VA = "0x182B00470", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1B")]
		[Cpp2IlInjected.Address(RVA = "0x2B004C0", Offset = "0x2AFEEC0", VA = "0x182B004C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public PostLoadAddSceneTagEntity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[PNKDNOBPNFK(EIJAKMAIFNG.OMRoom)]
	[LOEOGANCBGC(EDPDLGMLNHJ.Serialization)]
	public class PostLoadInitializeNetworkId : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		[CompilerGenerated]
		private struct IELKPJJHGPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public NativeHashMap<AKLFKNOOHJC, Entity> map;

			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
			public IELKPJJHGPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2A")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
			internal void <AddRoomEntitiesFromActiveScene>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[NoAlias]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		private struct KBJAKBLNDDP : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000172")]
			private struct NONCDGLAHAN
			{
				[Cpp2IlInjected.Token(Token = "0x2000173")]
				[NoAlias]
				public struct ALPBCGDGLJE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000491")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime GOMPAMBNHKE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000492")]
					[NoAlias]
					public LambdaParameterValueProvider_EntityInQueryIndex.Runtime NPHIJNGIBLH;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000493")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime LMHGHHDCDHJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400048E")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity ONOBANIBHPN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x400048F")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_EntityInQueryIndex HDGMEIBBOBA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000490")]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> LALLHBMJBFL;

				[Cpp2IlInjected.Token(Token = "0x6000A32")]
				[Cpp2IlInjected.Address(RVA = "0x3FF8B90", Offset = "0x3FF7590", VA = "0x183FF8B90")]
				public void DMNACDEGIGE(PostLoadInitializeNetworkId PIJJDNMKBBD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A33")]
				[Cpp2IlInjected.Address(RVA = "0x3FF8C00", Offset = "0x3FF7600", VA = "0x183FF8C00")]
				public ALPBCGDGLJE KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
				{
					return default(ALPBCGDGLJE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public NativeHashMap<AKLFKNOOHJC, Entity> INLJGFGAJKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private NONCDGLAHAN NNPBNEEGOKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe NONCDGLAHAN.ALPBCGDGLJE* BEIHMNNJOAB;

			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IMKGCCNGKJM;

			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate KLJOCPOGLLD;

			[Cpp2IlInjected.Token(Token = "0x6000A2B")]
			[Cpp2IlInjected.Address(RVA = "0x3FF5430", Offset = "0x3FF3E30", VA = "0x183FF5430")]
			internal void EJGOAEBMHCL(Entity GOANOLJBHPF, int HOHOMGCNENL, ref ObjectNetworkIdComponentData GDDOKOBFJIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x11488C0", Offset = "0x11472C0", VA = "0x1811488C0", Slot = "5")]
			public void ReadFromDisplayClass(ref IELKPJJHGPE LAJFEJAHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0x22D7DA0", Offset = "0x22D67A0", VA = "0x1822D7DA0", Slot = "6")]
			public void WriteToDisplayClass(ref IELKPJJHGPE LAJFEJAHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x3FF54C0", Offset = "0x3FF3EC0", VA = "0x183FF54C0", Slot = "4")]
			public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A2F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF5620", Offset = "0x3FF4020", VA = "0x183FF5620")]
			public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, [NoAlias] ref NONCDGLAHAN.ALPBCGDGLJE DNOHEDJMLNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A30")]
			[Cpp2IlInjected.Address(RVA = "0x3FF5390", Offset = "0x3FF3D90", VA = "0x183FF5390")]
			public void DMNACDEGIGE(PostLoadInitializeNetworkId PIJJDNMKBBD, ref IELKPJJHGPE LAJFEJAHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x3FF55B0", Offset = "0x3FF3FB0", VA = "0x183FF55B0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void IDLGLLJOIMC(ArchetypeChunkIterator* MBPLNPAGJMC, void* MAKNNDOILNI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		[JIFPDEDMPGC]
		private ObjectNetworkToLocalMapService KGCOHGMEJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		[JIFPDEDMPGC]
		private SceneService OOKLBGAMMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private EntityQuery CAMLCFELNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private EntityQuery KKAKEDNHGKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private ProfilerMarker CEAJMPMBEAN;

		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x2B00940", Offset = "0x2AFF340", VA = "0x182B00940", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x2B013F0", Offset = "0x2AFFDF0", VA = "0x182B013F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x2B00870", Offset = "0x2AFF270", VA = "0x182B00870", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x2B00870", Offset = "0x2AFF270", VA = "0x182B00870")]
		public void DCPOOIFDLIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x2B00C10", Offset = "0x2AFF610", VA = "0x182B00C10")]
		private void KCMEBIKKKAA(NativeHashMap<AKLFKNOOHJC, Entity> INLJGFGAJKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x2B009B0", Offset = "0x2AFF3B0", VA = "0x182B009B0")]
		private void IHELOFIPIME(NativeHashMap<AKLFKNOOHJC, Entity> INLJGFGAJKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public PostLoadInitializeNetworkId()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x2B01160", Offset = "0x2AFFB60", VA = "0x182B01160", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x2B006D0", Offset = "0x2AFF0D0", VA = "0x182B006D0")]
		public static EntityQuery CCKOLMLFOPG(ComponentSystemBase PIJJDNMKBBD)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public class GMGPNAPPAMP : FOMCGHGDFHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	private EntityQuery MOINFJCBIJK;

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x2C1ACF0", Offset = "0x2C196F0", VA = "0x182C1ACF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x2C1AD80", Offset = "0x2C19780", VA = "0x182C1AD80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public GMGPNAPPAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
public class EHNEOGMHCED : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	private DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	private global::OKLNGFEDEOH<PMOBPEKLJMO> MKJGOKFPIMC;

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x2E07240", Offset = "0x2E05C40", VA = "0x182E07240", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x2E073B0", Offset = "0x2E05DB0", VA = "0x182E073B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x2E06970", Offset = "0x2E05370", VA = "0x182E06970")]
	private void AKFNMJCEHEC(NativeList<EntityArchetype> HLFMABEDCDB, NativeHashMap<int, OHKLLNGFCGP> KPPJHMEBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x2E06B00", Offset = "0x2E05500", VA = "0x182E06B00")]
	private Span<int> CJLHKOFOKEO(EntityArchetype COAKPOHIAFK)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x2E072E0", Offset = "0x2E05CE0", VA = "0x182E072E0")]
	private bool LMLOKLHKEDH(int MDNDIFHMDOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x2E06C40", Offset = "0x2E05640", VA = "0x182E06C40")]
	private void EDDJMCCHLNF(NativeHashMap<int, OHKLLNGFCGP> KPPJHMEBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public EHNEOGMHCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Serialization)]
	public class PreSerializeRemoveEntities : FOMCGHGDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private static KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private EntityQuery OFCDFCNLLAM;

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x2B014E0", Offset = "0x2AFFEE0", VA = "0x182B014E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x2B01760", Offset = "0x2B00160", VA = "0x182B01760", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[LOEOGANCBGC(EDPDLGMLNHJ.PropertyChanges)]
	internal sealed class ShadowWorldApplyPropertyDifferencesToShadowWorld : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000178")]
		[CompilerGenerated]
		private struct HLFOKMGOFOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public ComponentDataFromEntity dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
			public HLFOKMGOFOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4D")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7CF0", Offset = "0x2BF66F0", VA = "0x182BF7CF0")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct CECKIEECBAJ : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			[ReadOnly]
			public NativeList<int> IMCOAJBLBJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			[ReadOnly]
			public NativeArray<Entity> GJDONBOOLLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public ComponentDataFromEntity DMNKLOOKJGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			[ReadOnly]
			public NativeArray<byte> AIAOJCAJMCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public int PAKMGNPBKNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public ComponentType NOIFPDMFLMJ;

			[Cpp2IlInjected.Token(Token = "0x6000A4E")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0550", Offset = "0x3FEEF50", VA = "0x183FF0550")]
			internal void EJGOAEBMHCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A4F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0720", Offset = "0x3FEF120", VA = "0x183FF0720", Slot = "5")]
			public void ReadFromDisplayClass(ref HLFOKMGOFOL LAJFEJAHEJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A50")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0710", Offset = "0x3FEF110", VA = "0x183FF0710", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A51")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0530", Offset = "0x3FEEF30", VA = "0x183FF0530")]
			public void DMNACDEGIGE(ShadowWorldApplyPropertyDifferencesToShadowWorld PIJJDNMKBBD, ref HLFOKMGOFOL LAJFEJAHEJB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private PropertyDiffStateService CPODMNBDJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private JobHandle PFOMEBOIFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private JobHandle DBGJCCCGODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private NEBKGLHCLEJ MKPFHFLNAEL;

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x2C01890", Offset = "0x2C00290", VA = "0x182C01890", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x2C01850", Offset = "0x2C00250", VA = "0x182C01850")]
		public JobHandle DOPNFPDAKAG(JobHandle MJAFFEAEOFD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x2C01C00", Offset = "0x2C00600", VA = "0x182C01C00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x2C018F0", Offset = "0x2C002F0", VA = "0x182C018F0")]
		private bool IIBKCNAKGLG(JobHandle MJAFFEAEOFD, int MDNDIFHMDOM, out JobHandle PAPECLFKBKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public ShadowWorldApplyPropertyDifferencesToShadowWorld()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[OFACFEGCPFP]
[ExecuteAlways]
[UpdateInGroup(typeof(KCNPDCCNDNC))]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
internal sealed class MLJMNAACNHI : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7CA0", Offset = "0x2AE66A0", VA = "0x182AE7CA0", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public MLJMNAACNHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[OFACFEGCPFP]
[ExecuteAlways]
[UpdateInGroup(typeof(EGLPLOIDBAA))]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
internal sealed class KFPAFBCGNPA : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x2C2BE30", Offset = "0x2C2A830", VA = "0x182C2BE30", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public KFPAFBCGNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[OFACFEGCPFP]
[ExecuteAlways]
[UpdateInGroup(typeof(NEMIBAOEOBF))]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
internal sealed class OAIDOBMFBKK : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x2AE9A30", Offset = "0x2AE8430", VA = "0x182AE9A30", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public OAIDOBMFBKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[OFACFEGCPFP]
[ExecuteAlways]
[UpdateInGroup(typeof(GEFAPMJJHKL))]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
internal sealed class IEBFLHIHGDJ : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x2C24160", Offset = "0x2C22B60", VA = "0x182C24160", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public IEBFLHIHGDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
internal class OJBHOHJJBNE : GMDJAPANGIH
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override DHNNDIENLFJ LCCGLIHDNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5E")]
		[Cpp2IlInjected.Address(RVA = "0x6E7AA0", Offset = "0x6E64A0", VA = "0x1806E7AA0", Slot = "18")]
		get
		{
			return default(DHNNDIENLFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7C90", Offset = "0x2AE6690", VA = "0x182AE7C90")]
	public OJBHOHJJBNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[OFACFEGCPFP]
[ExecuteAlways]
[UpdateInGroup(typeof(KOCBDEHJFOP))]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
internal sealed class CHDGHGMFHMB : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x2DF3F00", Offset = "0x2DF2900", VA = "0x182DF3F00", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public CHDGHGMFHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
internal class PBBAKJACMJI : FPJLAJEOELD
{
	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public PBBAKJACMJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
internal class MJKDJJNFPDE : GMDJAPANGIH
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	protected override DHNNDIENLFJ LCCGLIHDNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "18")]
		get
		{
			return default(DHNNDIENLFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7C90", Offset = "0x2AE6690", VA = "0x182AE7C90")]
	public MJKDJJNFPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[OFACFEGCPFP]
[ExecuteAlways]
[UpdateInGroup(typeof(GFIDBFKGNMD))]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
internal sealed class OHJKPDHBCLC : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x2AEBC00", Offset = "0x2AEA600", VA = "0x182AEBC00", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public OHJKPDHBCLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
internal class JDOLBEPMKJE : FPJLAJEOELD
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public JDOLBEPMKJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal class FMLCNFCJIJI : FPJLAJEOELD
{
	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public FMLCNFCJIJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class FOEGBGGCLMK : FOMCGHGDFHL
{
	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public FOEGBGGCLMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[GCANBDAKNID]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
public class POELCMEBHEF : FOMCGHGDFHL, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private TimeService BNNFECLLHDL;

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x2AFC760", Offset = "0x2AFB160", VA = "0x182AFC760", Slot = "14")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x2AFC7B0", Offset = "0x2AFB1B0", VA = "0x182AFC7B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public POELCMEBHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[LOEOGANCBGC(EDPDLGMLNHJ.TransformSyncing)]
	public class CopyTransformDataFromGameObjects : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile]
		private struct DHPIALKMIKB : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private const float MDIIEGGLFIH = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			[ReadOnly]
			public NativeArray<Entity> CGCCIONMJJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> JJOBDGBGFCA;

			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6E30", Offset = "0x2BF5830", VA = "0x182BF6E30", Slot = "4")]
			public void Execute(int GFDMFLGCBKB, TransformAccess CLHKPCIOCGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A80")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7060", Offset = "0x2BF5A60", VA = "0x182BF7060")]
			private bool NJEHGGKEKGJ(float3 APGCALANEIN, float3 HKLCHIBFNAM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000A81")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6FF0", Offset = "0x2BF59F0", VA = "0x182BF6FF0")]
			private bool IEEINPHIGIG(quaternion APGCALANEIN, quaternion HKLCHIBFNAM)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[BurstCompile]
		private struct PELKNHCECFD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			[ReadOnly]
			public NativeArray<Entity> CGCCIONMJJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> LDFHJCCMEDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> EDMCNCEKGDJ;

			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0x2BFA390", Offset = "0x2BF8D90", VA = "0x182BFA390", Slot = "4")]
			public void Execute(int GFDMFLGCBKB, TransformAccess CLHKPCIOCGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private static readonly KGOHPJFJCLE LEDIPMMGPNC;

		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private static readonly KGOHPJFJCLE DPHJANBJEEN;

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private static readonly KGOHPJFJCLE ILELBKFDOHM;

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private static readonly ProfilerMarker PDMNMLLGIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private PCBLNGPNPOI DODBMNJJCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private DEAGKEFEBKN ALIKEONHNHI;

		[Cpp2IlInjected.Token(Token = "0x6000A79")]
		[Cpp2IlInjected.Address(RVA = "0x2DFD510", Offset = "0x2DFBF10", VA = "0x182DFD510", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFD580", Offset = "0x2DFBF80", VA = "0x182DFD580", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFD5B0", Offset = "0x2DFBFB0", VA = "0x182DFD5B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A7E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[LOEOGANCBGC(EDPDLGMLNHJ.TransformSyncing)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	public class RegisterTransforms : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct NCLOBAMCJII : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200018D")]
			private struct JCGGMPOGGEB
			{
				[Cpp2IlInjected.Token(Token = "0x200018E")]
				public struct GPGELLHDKCE
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004CA")]
					public LambdaParameterValueProvider_Entity.Runtime GOMPAMBNHKE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004CB")]
					public LambdaParameterValueProvider_IComponentData<BGBPLMKMCDD>.Runtime HEPBGDMCDBA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40004CC")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime DILPODDLLBG;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004C7")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity ONOBANIBHPN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004C8")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<BGBPLMKMCDD> DNLAOIAPOPD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40004C9")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> IMLHFJLHNCM;

				[Cpp2IlInjected.Token(Token = "0x6000A9D")]
				[Cpp2IlInjected.Address(RVA = "0x3FF47B0", Offset = "0x3FF31B0", VA = "0x183FF47B0")]
				public void DMNACDEGIGE(RegisterTransforms PIJJDNMKBBD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A9E")]
				[Cpp2IlInjected.Address(RVA = "0x3FF4830", Offset = "0x3FF3230", VA = "0x183FF4830")]
				public GPGELLHDKCE KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
				{
					return default(GPGELLHDKCE);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private JCGGMPOGGEB NNPBNEEGOKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe JCGGMPOGGEB.GPGELLHDKCE* BEIHMNNJOAB;

			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate IMKGCCNGKJM;

			[Cpp2IlInjected.Token(Token = "0x6000A98")]
			[Cpp2IlInjected.Address(RVA = "0x3FF8470", Offset = "0x3FF6E70", VA = "0x183FF8470")]
			internal void EJGOAEBMHCL(Entity GOANOLJBHPF, BGBPLMKMCDD PCEAKJKGHMM, Transform CLHKPCIOCGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A99")]
			[Cpp2IlInjected.Address(RVA = "0x3FF8570", Offset = "0x3FF6F70", VA = "0x183FF8570", Slot = "4")]
			public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9A")]
			[Cpp2IlInjected.Address(RVA = "0x3FF86D0", Offset = "0x3FF70D0", VA = "0x183FF86D0")]
			public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, ref JCGGMPOGGEB.GPGELLHDKCE DNOHEDJMLNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9B")]
			[Cpp2IlInjected.Address(RVA = "0x3FF8460", Offset = "0x3FF6E60", VA = "0x183FF8460")]
			public void DMNACDEGIGE(RegisterTransforms PIJJDNMKBBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A9C")]
			[Cpp2IlInjected.Address(RVA = "0x3FF8660", Offset = "0x3FF7060", VA = "0x183FF8660")]
			public unsafe static void IDLGLLJOIMC(ArchetypeChunkIterator* MBPLNPAGJMC, void* MAKNNDOILNI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct EDLKCEAGNCG : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000190")]
			private struct FEEEEFNDJNL
			{
				[Cpp2IlInjected.Token(Token = "0x2000191")]
				[NoAlias]
				public struct KPCJOAMEOGI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40004D1")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime GOMPAMBNHKE;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40004D2")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<BGBPLMKMCDD>.Runtime HEPBGDMCDBA;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40004CF")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity ONOBANIBHPN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40004D0")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<BGBPLMKMCDD> DNLAOIAPOPD;

				[Cpp2IlInjected.Token(Token = "0x6000AA3")]
				[Cpp2IlInjected.Address(RVA = "0x3FF0CC0", Offset = "0x3FEF6C0", VA = "0x183FF0CC0")]
				public void DMNACDEGIGE(RegisterTransforms PIJJDNMKBBD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000AA4")]
				[Cpp2IlInjected.Address(RVA = "0x3FF1760", Offset = "0x3FF0160", VA = "0x183FF1760")]
				public KPCJOAMEOGI KLONJGFKCKL(ref ArchetypeChunk JLFJALGLFAD, int FBBPNGIPIPG, int EBMMGNOJPKA)
				{
					return default(KPCJOAMEOGI);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CD")]
			private FEEEEFNDJNL NNPBNEEGOKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe FEEEEFNDJNL.KPCJOAMEOGI* BEIHMNNJOAB;

			[Cpp2IlInjected.Token(Token = "0x6000A9F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0D20", Offset = "0x3FEF720", VA = "0x183FF0D20")]
			internal void EJGOAEBMHCL(Entity GOANOLJBHPF, BGBPLMKMCDD PCEAKJKGHMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA0")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0E00", Offset = "0x3FEF800", VA = "0x183FF0E00", Slot = "4")]
			public void Execute(ArchetypeChunk MHMFPFMJMPM, int FCHLMALIADD, int KENHKHFNJAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA1")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0E90", Offset = "0x3FEF890", VA = "0x183FF0E90")]
			public void OJGGAIPDCAE(ref ArchetypeChunk MHMFPFMJMPM, [NoAlias] ref FEEEEFNDJNL.KPCJOAMEOGI DNOHEDJMLNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AA2")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0CC0", Offset = "0x3FEF6C0", VA = "0x183FF0CC0")]
			public void DMNACDEGIGE(RegisterTransforms PIJJDNMKBBD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private PCBLNGPNPOI DODBMNJJCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private EntityQuery KGKIBBMFJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private EntityQuery BMBONNGLFPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private EntityQuery POKKOCADCHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private EntityQuery LIKNJHDNPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private EntityQuery FKIMPOMHECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private ProfilerMarker LFFALABAJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private EntityQuery OBNOLNDHNLL;

		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x2BFAA60", Offset = "0x2BF9460", VA = "0x182BFAA60", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x2BFB6C0", Offset = "0x2BFA0C0", VA = "0x182BFB6C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x2BFB8D0", Offset = "0x2BFA2D0", VA = "0x182BFB8D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x2BFAC90", Offset = "0x2BF9690", VA = "0x182BFAC90")]
		private void JBNKENAELFE(EntityQuery CAMLCFELNDE, BCPGIKNGDDK IEOADJKOPIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x2BFAED0", Offset = "0x2BF98D0", VA = "0x182BFAED0")]
		private void JOACBAAMPEO(EntityQuery CAMLCFELNDE, BCPGIKNGDDK IEOADJKOPIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x2BFB870", Offset = "0x2BFA270", VA = "0x182BFB870", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x2BFB140", Offset = "0x2BF9B40", VA = "0x182BFB140")]
		private void KDIKDKHLCKD(NativeArray<Entity> CGCCIONMJJA, BCPGIKNGDDK IEOADJKOPIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x2BFA750", Offset = "0x2BF9150", VA = "0x182BFA750")]
		[BurstCompile]
		internal static void FPFAPJGALEE(NativeArray<BGBPLMKMCDD> EFFBNPLFMEF, ComponentDataFromEntity<BGBPLMKMCDD> CFKHFJNGNFF, BCPGIKNGDDK IEOADJKOPIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		private static void IJOEKGKHLDC(Transform CLHKPCIOCGF, Entity GOANOLJBHPF, int GFDMFLGCBKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		private static void FIJOEKDJBIJ(Entity GOANOLJBHPF, int GFDMFLGCBKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		private static void JCOKINECMOJ(int GFDMFLGCBKB, BCPGIKNGDDK IEOADJKOPIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x2BFAAB0", Offset = "0x2BF94B0", VA = "0x182BFAAB0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void ILBMBGHDHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x2BFB450", Offset = "0x2BF9E50", VA = "0x182BFB450", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x2BFA5B0", Offset = "0x2BF8FB0", VA = "0x182BFA5B0")]
		public static EntityQuery FENACFFFKPJ(ComponentSystemBase PIJJDNMKBBD)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x2BFB280", Offset = "0x2BF9C80", VA = "0x182BFB280")]
		public static EntityQuery MLABIELPFAP(ComponentSystemBase PIJJDNMKBBD)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	[LOEOGANCBGC(EDPDLGMLNHJ.TransformSyncing)]
	public class CopyTransformDataToGameObjects : FOMCGHGDFHL, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x2000193")]
		[BurstCompile]
		private struct BLBEDMDMFMD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> JJOBDGBGFCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			[ReadOnly]
			public NativeArray<Entity> CGCCIONMJJA;

			[Cpp2IlInjected.Token(Token = "0x6000AAE")]
			[Cpp2IlInjected.Address(RVA = "0x2BF68A0", Offset = "0x2BF52A0", VA = "0x182BF68A0", Slot = "4")]
			public void Execute(int GFDMFLGCBKB, TransformAccess CLHKPCIOCGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000194")]
		[BurstCompile]
		private struct BOAMFKMAOBE : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> LDFHJCCMEDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public NativeArray<Entity> CGCCIONMJJA;

			[Cpp2IlInjected.Token(Token = "0x6000AAF")]
			[Cpp2IlInjected.Address(RVA = "0x2BF6B90", Offset = "0x2BF5590", VA = "0x182BF6B90", Slot = "4")]
			public void Execute(int GFDMFLGCBKB, TransformAccess CLHKPCIOCGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000195")]
		[BurstCompile]
		private struct JHALKHHKGJL : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> LDFHJCCMEDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> EDMCNCEKGDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			[ReadOnly]
			public NativeArray<Entity> CGCCIONMJJA;

			[Cpp2IlInjected.Token(Token = "0x6000AB0")]
			[Cpp2IlInjected.Address(RVA = "0x2BF7D50", Offset = "0x2BF6750", VA = "0x182BF7D50", Slot = "4")]
			public void Execute(int GFDMFLGCBKB, TransformAccess CLHKPCIOCGF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private static readonly KGOHPJFJCLE LEDIPMMGPNC;

		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private static readonly KGOHPJFJCLE DPHJANBJEEN;

		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private static readonly KGOHPJFJCLE ILELBKFDOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private PCBLNGPNPOI DODBMNJJCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private EntityQuery NKGBJCNLKPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private EntityQuery FBJAMABFJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private EntityQuery PLHJJNKHFIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private TransformAccessArray FDOOJAJOBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private TransformAccessArray EKLHALELCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private TransformAccessArray CIPPGJFOPPH;

		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x2DFDBE0", Offset = "0x2DFC5E0", VA = "0x182DFDBE0", Slot = "14")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA6")]
		[Cpp2IlInjected.Address(RVA = "0x2DFDC30", Offset = "0x2DFC630", VA = "0x182DFDC30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x2DFDE20", Offset = "0x2DFC820", VA = "0x182DFDE20", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x2DFDEB0", Offset = "0x2DFC8B0", VA = "0x182DFDEB0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AA9")]
		[Cpp2IlInjected.Address(RVA = "0x2DFDEE0", Offset = "0x2DFC8E0", VA = "0x182DFDEE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAA")]
		[Cpp2IlInjected.Address(RVA = "0x2DFDA60", Offset = "0x2DFC460", VA = "0x182DFDA60")]
		private NativeArray<Entity> GFOCMCLNHAG(NativeArray<BGBPLMKMCDD> IMCOAJBLBJG, NativeList<Entity> LDEKFDONKGC, TransformAccessArray OCJNPMAPNIM, TransformAccessArray BFMIKBDMNHE)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[LOEOGANCBGC(EDPDLGMLNHJ.TransformSyncing)]
	[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
	public class CopyTransformParentsToGameObjects : FOMCGHGDFHL, PKBAIAJJFPF
	{
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private OCJBMLIKJMH BDCGBDOJMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private KLBBFCMIKPN GNIBBBNGGIK;

		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x2B01B20", Offset = "0x2B00520", VA = "0x182B01B20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE810", Offset = "0x2DFD210", VA = "0x182DFE810", Slot = "14")]
		public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB3")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEB40", Offset = "0x2DFD540", VA = "0x182DFEB40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x2DFE920", Offset = "0x2DFD320", VA = "0x182DFE920")]
		private static void FKCPCHHGNLF(EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, Entity ELGBIOMPEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x2DFEAA0", Offset = "0x2DFD4A0", VA = "0x182DFEAA0")]
		private static bool GOEJCHMLHHD(EntityManager BJMEFCCEPHI, Entity GOANOLJBHPF, out Transform CLHKPCIOCGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public CopyTransformParentsToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[LOEOGANCBGC(EDPDLGMLNHJ.TransformSyncing)]
	public class L2PToL2WHierarchy : FOMCGHGDFHL
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		[BurstCompile]
		private struct CCGMHFCFOBG : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> AAJLDMANMKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> OLCKBGOBAJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> AAOIPBGKKLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> DFGOBOAPKMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public ArchetypeChunkComponentType<LocalToWorldData> DPCMDBFLOMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> MCNBJBENKCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public uint EJHKEBDOLEM;

			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0460", Offset = "0x3FEEE60", VA = "0x183FF0460")]
			[Conditional("DEBUG_BUILD")]
			private void LFDFLAEEMGI(Entity GOANOLJBHPF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x3FEFD70", Offset = "0x3FEE770", VA = "0x183FEFD70", Slot = "4")]
			public void Execute(ArchetypeChunk MHMFPFMJMPM, int GFDMFLGCBKB, int KFPBPGBBDHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0060", Offset = "0x3FEEA60", VA = "0x183FF0060")]
			private void FNHJIDCOFNK(float4x4 LDIPNPNPEHD, Entity GOANOLJBHPF, bool FBMHBGPLFDI, int GLPDCHNEBJK = 1)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private EntityQuery HEGLOOLELMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private EntityQuery NLJLDODBABP;

		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x2C2E600", Offset = "0x2C2D000", VA = "0x182C2E600", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x2C2E720", Offset = "0x2C2D120", VA = "0x182C2E720", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class CLKFFANJJNH : CGIMNOJBJNJ
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[BurstCompile]
	private struct KFDOBNDGKAL : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> AAJLDMANMKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public ArchetypeChunkComponentType<LocalToWorldData> DPCMDBFLOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public uint EJHKEBDOLEM;

		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x2BF7F30", Offset = "0x2BF6930", VA = "0x182BF7F30", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int GFDMFLGCBKB, int KFPBPGBBDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8030", Offset = "0x2BF6A30", VA = "0x182BF8030")]
		public bool GGJNAKDJGFB(ArchetypeChunk MHMFPFMJMPM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	private EntityQuery HEGLOOLELMA;

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4720", Offset = "0x2DF3120", VA = "0x182DF4720", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x2DF4850", Offset = "0x2DF3250", VA = "0x182DF4850", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PMAFEBLAIKC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public CLKFFANJJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class LDCMKBJKFOJ : CGIMNOJBJNJ
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct KAFBFNJAKMK : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> NFBIJFOJNDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public ArchetypeChunkComponentType<WorldPoseData> BLLDGOGCEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> AGHICNNNMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> GGKNCCMPPPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public uint EJHKEBDOLEM;

		[Cpp2IlInjected.Token(Token = "0x6000ACB")]
		[Cpp2IlInjected.Address(RVA = "0x3FF4F60", Offset = "0x3FF3960", VA = "0x183FF4F60", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int GFDMFLGCBKB, int KFPBPGBBDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000ACC")]
		[Cpp2IlInjected.Address(RVA = "0x3FF5310", Offset = "0x3FF3D10", VA = "0x183FF5310")]
		public bool GGJNAKDJGFB(ArchetypeChunk MHMFPFMJMPM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private EntityQuery CAJCDELKPBE;

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x2C30570", Offset = "0x2C2EF70", VA = "0x182C30570", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x2C30680", Offset = "0x2C2F080", VA = "0x182C30680", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PMAFEBLAIKC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0xEA4F40", Offset = "0xEA3940", VA = "0x180EA4F40")]
	public LDCMKBJKFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
public class EBJIEJOHODH : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct LGNNKPFCBEK : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> PLENBFFBPAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> ILLLGAIGLPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> LMCDPHDEJGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public ArchetypeChunkComponentType<LocalToParentData> DGIIOJHIOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public uint EJHKEBDOLEM;

		[Cpp2IlInjected.Token(Token = "0x6000AD1")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8770", Offset = "0x2BF7170", VA = "0x182BF8770", Slot = "4")]
		public void Execute(ArchetypeChunk MHMFPFMJMPM, int GFDMFLGCBKB, int KFPBPGBBDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD2")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8E80", Offset = "0x2BF7880", VA = "0x182BF8E80")]
		public bool GGJNAKDJGFB(ArchetypeChunk MHMFPFMJMPM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private EntityQuery CAJCDELKPBE;

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x2E05280", Offset = "0x2E03C80", VA = "0x182E05280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x2E053B0", Offset = "0x2E03DB0", VA = "0x182E053B0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PMAFEBLAIKC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x728CE0", Offset = "0x7276E0", VA = "0x180728CE0")]
	public EBJIEJOHODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[LOEOGANCBGC(EDPDLGMLNHJ.RenderEffects)]
	internal class PropagateWorldFadeScopeRootTag : NNMABKLJCPE
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x20001A0")]
		public struct EALCPDEMFCD : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		protected override ComponentType ANPOJKNNCKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0x2B02550", Offset = "0x2B00F50", VA = "0x182B02550", Slot = "15")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		protected override ComponentType ECFGABMNABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0x2B02520", Offset = "0x2B00F20", VA = "0x182B02520", Slot = "16")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		protected override ComponentType BKLNMJPBNAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x2B02580", Offset = "0x2B00F80", VA = "0x182B02580", Slot = "17")]
			get
			{
				return default(ComponentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x2AE98C0", Offset = "0x2AE82C0", VA = "0x182AE98C0")]
		public PropagateWorldFadeScopeRootTag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AD7")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[MPALKKKLACC(IDCNBKCHOBE.Game)]
public class FNGDMIBJNCL : CKNFIKGHKPF
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Type FCCCLFMKNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD8")]
		[Cpp2IlInjected.Address(RVA = "0x2C187B0", Offset = "0x2C171B0", VA = "0x182C187B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Type[] MOMFGDPMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD9")]
		[Cpp2IlInjected.Address(RVA = "0x2C18820", Offset = "0x2C17220", VA = "0x182C18820", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public FNGDMIBJNCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[MPALKKKLACC(IDCNBKCHOBE.Loading)]
public class CCAPIDFEKFG : CKNFIKGHKPF
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Type FCCCLFMKNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Type[] MOMFGDPMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x2DF3E10", Offset = "0x2DF2810", VA = "0x182DF3E10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public CCAPIDFEKFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
public sealed class OOEBMIKPKKJ : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x2AED140", Offset = "0x2AEBB40", VA = "0x182AED140", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public OOEBMIKPKKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[MPALKKKLACC(IDCNBKCHOBE.Saving)]
public class OEKMPHJCIGH : CKNFIKGHKPF
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Type FCCCLFMKNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Type[] MOMFGDPMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE2")]
		[Cpp2IlInjected.Address(RVA = "0x2AEB080", Offset = "0x2AE9A80", VA = "0x182AEB080", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public OEKMPHJCIGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A5")]
public sealed class MEFBJILCBGO : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5750", Offset = "0x2AE4150", VA = "0x182AE5750", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public MEFBJILCBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A6")]
[MPALKKKLACC(IDCNBKCHOBE.Simulation)]
public class AKBLHEONIIM : CKNFIKGHKPF
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public Type FCCCLFMKNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE740", Offset = "0x2DED140", VA = "0x182DEE740", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public Type[] MOMFGDPMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x2DEE7B0", Offset = "0x2DED1B0", VA = "0x182DEE7B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public AKBLHEONIIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A7")]
[DNOPHNKOHLA(typeof(ELFMIDCENBA), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
internal class ELFMIDCENBA : PKBAIAJJFPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	private global::KOMLKGNCAAK<AuthoredParentData, ODAFCNOHOHL, CDJCAJGBPPN, AuthoredChildrenData> AJAFMNPEGPG;

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x2E084F0", Offset = "0x2E06EF0", VA = "0x182E084F0", Slot = "4")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public ELFMIDCENBA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	[DNOPHNKOHLA(typeof(EntityHierarchyParents), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.HierarchySystems)]
	internal sealed class EntityHierarchyParents : MMKNGEFLOAO, PKBAIAJJFPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[JIFPDEDMPGC]
		private JOHEJCALJIO CAJCDELKPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[JIFPDEDMPGC]
		private PropertyChangeNetworkRouter DLPDJBHFEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private global::BBFFFGFDPOL<Entity> OPPPBNFKNOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private global::KOMLKGNCAAK<ParentData, OGPCKNJKEMC, CGGHENOPEAA, ChildrenData> AJAFMNPEGPG;

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x2C15AC0", Offset = "0x2C144C0", VA = "0x182C15AC0", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x2C159C0", Offset = "0x2C143C0", VA = "0x182C159C0", Slot = "5")]
		public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x2C158D0", Offset = "0x2C142D0", VA = "0x182C158D0")]
		public Entity CBCDGOOOFFP(Entity GOANOLJBHPF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x2C15B30", Offset = "0x2C14530", VA = "0x182C15B30")]
		public bool MIGAOKLMMPE(Entity GOANOLJBHPF, Entity DILGNCFGGHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x2C15920", Offset = "0x2C14320", VA = "0x182C15920")]
		public bool DGJAMCMEJGD(Entity GOANOLJBHPF, Entity DILGNCFGGHK, bool FMMHJBAPDJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x2C156F0", Offset = "0x2C140F0", VA = "0x182C156F0")]
		private bool BNGJCKBNIJF(Entity GOANOLJBHPF, Entity DILGNCFGGHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A9")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
[DNOPHNKOHLA(typeof(LBIGKNDELFN), new string[] { })]
internal sealed class LBIGKNDELFN : MMKNGEFLOAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	[JIFPDEDMPGC]
	private DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private EntityQuery IAAKEDMNPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private EntityManager FLHDGCEBOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x2C2F120", Offset = "0x2C2DB20", VA = "0x182C2F120")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F020", Offset = "0x2C2DA20", VA = "0x182C2F020", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x2C2EC70", Offset = "0x2C2D670", VA = "0x182C2EC70", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F170", Offset = "0x2C2DB70", VA = "0x182C2F170")]
	public bool KOAJBNHNOIK(Entity GOANOLJBHPF, Entity OBNNKPFGMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F590", Offset = "0x2C2DF90", VA = "0x182C2F590")]
	public IEnumerable<Entity> NFFFFNFFGFM(Entity GOANOLJBHPF, bool HNONKJJDNKE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x2C2EA40", Offset = "0x2C2D440", VA = "0x182C2EA40")]
	public bool AEAMAMIPHJB(Entity GOANOLJBHPF, Entity DDLMBHAEKGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x2C2EB70", Offset = "0x2C2D570", VA = "0x182C2EB70")]
	public bool CNEEDNJDFHP(Entity GOANOLJBHPF, Entity KFMKMKEGGGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x2C2ED40", Offset = "0x2C2D740", VA = "0x182C2ED40")]
	public NativeList<Entity> EMHMOKHNBJK(Entity GOANOLJBHPF, bool HNONKJJDNKE = false, Allocator GGPAKDMJHLJ = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x2C2EE20", Offset = "0x2C2D820", VA = "0x182C2EE20")]
	public IEnumerable<Entity> EPEPDFLBNKD(Entity GOANOLJBHPF, bool HNONKJJDNKE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFD")]
	[Cpp2IlInjected.Address(RVA = "0x2C2EC90", Offset = "0x2C2D690", VA = "0x182C2EC90")]
	public Entity EDPENGKDDJF(Entity GOANOLJBHPF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFE")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F230", Offset = "0x2C2DC30", VA = "0x182C2F230")]
	public NativeArray<Entity> LIDLLJHIPIP()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F280", Offset = "0x2C2DC80", VA = "0x182C2F280")]
	public bool LONLDNKLGBI(Entity KFMKMKEGGGJ, Entity IADBGEPICDI, out Entity ENIDPPCMOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x2C2F4A0", Offset = "0x2C2DEA0", VA = "0x182C2F4A0")]
	private Entity NEFGBGOGMPM(Entity GOANOLJBHPF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public LBIGKNDELFN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[LOEOGANCBGC(EDPDLGMLNHJ.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x4BD7B70", Offset = "0x4BD6570", VA = "0x184BD7B70")]
		public static void HAKOKLHEDIO<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(NKLKBAHCHOA BKJAOJMOJPF, global::BBEGIGBIOHM<Entity> IJEJFFCLBDM, out global::KOMLKGNCAAK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> BKHEOALBIHA) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, JJGDMAAEPIP where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, JJGDMAAEPIP, IEquatable<TChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x2AFC940", Offset = "0x2AFB340", VA = "0x182AFC940")]
		public static bool GBPDFONKOAN(POPHLPHEEBM DICLGEOGLMC)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class KOMLKGNCAAK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, JJGDMAAEPIP where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, JJGDMAAEPIP, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	private static readonly KGOHPJFJCLE LHMILDDMKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050C")]
	private readonly DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050D")]
	private readonly global::BBFFFGFDPOL<Entity> OPPPBNFKNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	private readonly KHCPECBGMIK CDPNKALONGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400050F")]
	private readonly ABCMNOFLGBA ELGBIOMPEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private readonly EntityManager BJMEFCCEPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private readonly KLBBFCMIKPN GNIBBBNGGIK;

	[Cpp2IlInjected.Token(Token = "0x6000B04")]
	[Cpp2IlInjected.Address(RVA = "0x4CDCD30", Offset = "0x4CDB730", VA = "0x184CDCD30")]
	public KOMLKGNCAAK(NKLKBAHCHOA BKJAOJMOJPF, global::BBEGIGBIOHM<Entity> IJEJFFCLBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x4CDC520", Offset = "0x4CDAF20", VA = "0x184CDC520")]
	private bool MCNFPKCNNDL(Entity GOANOLJBHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x4CDB5E0", Offset = "0x4CD9FE0", VA = "0x184CDB5E0")]
	private bool HAKBIOKOCFL(Entity GOANOLJBHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x4CDC580", Offset = "0x4CDAF80", VA = "0x184CDC580")]
	public bool MIGAOKLMMPE(Entity GOANOLJBHPF, in Entity DILGNCFGGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x4CDC490", Offset = "0x4CDAE90", VA = "0x184CDC490")]
	public bool LLJCNDGNLIM(Entity GOANOLJBHPF, in Entity DILGNCFGGHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x4CDC050", Offset = "0x4CDAA50", VA = "0x184CDC050")]
	private bool LLJCNDGNLIM(Entity GOANOLJBHPF, in Entity DILGNCFGGHK, bool NGBJLANINBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	private static void BKAKFLNKLEA(Entity GOANOLJBHPF, in Entity DILGNCFGGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	private static void LNIHGOMIIIO(Entity GOANOLJBHPF, in Entity DILGNCFGGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	private static void LODEIOODKLO(Entity GOANOLJBHPF, in Entity DILGNCFGGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	private static void FKFFBPCLGEF(Entity GOANOLJBHPF, in Entity DILGNCFGGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	private static void LFHBAPJAJII(Entity GOANOLJBHPF, in Entity DILGNCFGGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x4CDBE90", Offset = "0x4CDA890", VA = "0x184CDBE90")]
	private bool KOAJBNHNOIK(Entity GOANOLJBHPF, Entity OBNNKPFGMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x4CDB4F0", Offset = "0x4CD9EF0", VA = "0x184CDB4F0")]
	private void FIKMPJLILMB(Entity GOANOLJBHPF, in Entity PMJEABCAKDM, in Entity DILGNCFGGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x4CDB7D0", Offset = "0x4CDA1D0", VA = "0x184CDB7D0")]
	private void HBGGGPPALPC(Entity GOANOLJBHPF, in Entity PMJEABCAKDM, in Entity DILGNCFGGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x4CDBA90", Offset = "0x4CDA490", VA = "0x184CDBA90")]
	private bool IBHKIPDEAJK(FIBFBJPKNCP CPLEKHLBDBH, in AKLFKNOOHJC NLCBBNKAPNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x4CDC5B0", Offset = "0x4CDAFB0", VA = "0x184CDC5B0")]
	private void ONHPMCGNOEF(Entity ELGBIOMPEHN, Entity DDLMBHAEKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x4CDB970", Offset = "0x4CDA370", VA = "0x184CDB970")]
	private void IBAFGGCIFCB(Entity ELGBIOMPEHN, Entity DDLMBHAEKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	private void JCOKINECMOJ(Entity GOANOLJBHPF, Entity PMJEABCAKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	private void IJOEKGKHLDC(Entity GOANOLJBHPF, Entity DILGNCFGGHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AC")]
public struct KJIGHOHBPOO : IMOHFLKNJIO, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public EIJALHDNNPP MIOGPCOPEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x6C1000", Offset = "0x6BFA00", VA = "0x1806C1000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(EIJALHDNNPP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x7264E0", Offset = "0x724EE0", VA = "0x1807264E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[DNOPHNKOHLA(typeof(ObjectEmbodimentService), new string[] { })]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	[LOEOGANCBGC(EDPDLGMLNHJ.Embodiment)]
	internal sealed class ObjectEmbodimentService : EBFNJADEFGO, IPCGJDFHGJG, MMKNGEFLOAO, PKBAIAJJFPF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private ObjectLifecycleService JFLLPKLIMED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		[JIFPDEDMPGC]
		private JOHEJCALJIO CAJCDELKPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		[JIFPDEDMPGC]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[JIFPDEDMPGC]
		private GCELLPHAFPH JAINECODPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[JIFPDEDMPGC]
		private ABOINJIGLHC KBPNLDAOCNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[JIFPDEDMPGC]
		private TransformOwnershipPhase GIFOAOGCBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private readonly Dictionary<AKLFKNOOHJC, HBIBAGENGHJ> IGDALLADBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private JAEMCNMCCLN AKAIPEJKBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private EntityManager FLHDGCEBOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B1A")]
			[Cpp2IlInjected.Address(RVA = "0x2AEF590", Offset = "0x2AEDF90", VA = "0x182AEF590")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		public int PPFFIKBMELP
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x2AEE090", Offset = "0x2AECA90", VA = "0x182AEE090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		public int OLGGKIKIIAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000B21")]
			[Cpp2IlInjected.Address(RVA = "0x2AEE070", Offset = "0x2AECA70", VA = "0x182AEE070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1B")]
		[Cpp2IlInjected.Address(RVA = "0xF3A080", Offset = "0xF38A80", VA = "0x180F3A080", Slot = "4")]
		public void BEJHKBIOAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1C")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF460", Offset = "0x2AEDE60", VA = "0x182AEF460", Slot = "5")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFF60", Offset = "0x2AEE960", VA = "0x182AEFF60")]
		public void KIGCJINOOCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF080", Offset = "0x2AEDA80", VA = "0x182AEF080", Slot = "6")]
		public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE880", Offset = "0x2AED280", VA = "0x182AEE880", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B22")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0930", Offset = "0x2AEF330", VA = "0x182AF0930")]
		public int MPPANIDCDOM(SceneTag BBIKMOACHCN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0950", Offset = "0x2AEF350", VA = "0x182AF0950")]
		public int NGKAKFLJHOE(SceneTag BBIKMOACHCN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE2E0", Offset = "0x2AECCE0", VA = "0x182AEE2E0")]
		public bool CAPHHOGGDFE(Entity GOANOLJBHPF, Allocator GGPAKDMJHLJ, out NativeList<Entity> FMHCACLGCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x2AF06E0", Offset = "0x2AEF0E0", VA = "0x182AF06E0")]
		public bool MICICOEMFMJ(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFBE0", Offset = "0x2AEE5E0", VA = "0x182AEFBE0")]
		public bool HNGDLAAAHJE(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF6B0", Offset = "0x2AEE0B0", VA = "0x182AEF6B0")]
		public bool HAAHLPEEGIO(Entity GOANOLJBHPF, out HBIBAGENGHJ MIDDDIBGPID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF720", Offset = "0x2AEE120", VA = "0x182AEF720")]
		private bool HAAHLPEEGIO(Transform CLHKPCIOCGF, out HBIBAGENGHJ MIDDDIBGPID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1580", Offset = "0x2AEFF80", VA = "0x182AF1580")]
		private void OLPJFPPHFAE(Entity GOANOLJBHPF, HBIBAGENGHJ MIDDDIBGPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFBC0", Offset = "0x2AEE5C0", VA = "0x182AEFBC0")]
		private bool HNDEOLJNCJF(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1210", Offset = "0x2AEFC10", VA = "0x182AF1210")]
		public void OGMDKKEHOIN(AKLFKNOOHJC AOCEENCOLMM, HBIBAGENGHJ GKKAOEHIFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0C30", Offset = "0x2AEF630", VA = "0x182AF0C30")]
		public bool NMHDENAFJAI(Entity GOANOLJBHPF, object DEGCIHEAIBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF19A0", Offset = "0x2AF03A0", VA = "0x182AF19A0")]
		public bool PICEALNHFBA(DFKOJFHJBPL PMMCMCPNCLD, object DEGCIHEAIBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1D50", Offset = "0x2AF0750", VA = "0x182AF1D50")]
		public bool PICEALNHFBA(Entity GOANOLJBHPF, [Optional] object DEGCIHEAIBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1610", Offset = "0x2AF0010", VA = "0x182AF1610")]
		public bool PICEALNHFBA(HBIBAGENGHJ DICLGEOGLMC, object DEGCIHEAIBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x2AF00F0", Offset = "0x2AEEAF0", VA = "0x182AF00F0")]
		public bool LPLCEOMDBFD(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x2AF00C0", Offset = "0x2AEEAC0", VA = "0x182AF00C0")]
		public bool LPLCEOMDBFD(HBIBAGENGHJ MIDDDIBGPID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1630", Offset = "0x2AF0030", VA = "0x182AF1630")]
		public bool PICEALNHFBA(HBIBAGENGHJ MIDDDIBGPID, [Optional] object DEGCIHEAIBD, bool GONNPACEKOP = false, bool OOECKEDLBNG = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1410", Offset = "0x2AEFE10", VA = "0x182AF1410")]
		public Transform OJLEDFFAAIN(Entity GOANOLJBHPF, [Optional] object DEGCIHEAIBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF5E0", Offset = "0x2AEDFE0", VA = "0x182AEF5E0")]
		public bool GOEJCHMLHHD(Entity GOANOLJBHPF, out Transform CLHKPCIOCGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B35")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1DA0", Offset = "0x2AF07A0", VA = "0x182AF1DA0")]
		public HBIBAGENGHJ PIKENIAFHJF(Entity GOANOLJBHPF, [Optional] object DEGCIHEAIBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B36")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF1D0", Offset = "0x2AEDBD0", VA = "0x182AEF1D0")]
		public void GCAMBINNBNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B37")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF7D0", Offset = "0x2AEE1D0", VA = "0x182AEF7D0")]
		public void HGDMDGLPIGD(SceneTag BBIKMOACHCN, bool BEJBHLCKAAH, global::BJBEMKAEBCB<int> FHLGIAEAPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B38")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE9B0", Offset = "0x2AED3B0", VA = "0x182AEE9B0")]
		private void EFGALNMNJEO(Entity GOANOLJBHPF, bool BEJBHLCKAAH, bool MDAAFJCELDJ, global::BJBEMKAEBCB<int> FHLGIAEAPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B39")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFE20", Offset = "0x2AEE820", VA = "0x182AEFE20")]
		private void IGGGEMJEMDI(Entity GOANOLJBHPF, HBIBAGENGHJ MIDDDIBGPID, bool BEJBHLCKAAH, bool MDAAFJCELDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0070", Offset = "0x2AEEA70", VA = "0x182AF0070")]
		public HBIBAGENGHJ LCMPMNFINPC(Entity GOANOLJBHPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE530", Offset = "0x2AECF30", VA = "0x182AEE530")]
		public bool CDAPIFCKPGM(Entity GOANOLJBHPF, object DEGCIHEAIBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x2AEF000", Offset = "0x2AEDA00", VA = "0x182AEF000")]
		public bool ENAJODIBMIM(Entity GOANOLJBHPF, object DEGCIHEAIBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFEF0", Offset = "0x2AEE8F0", VA = "0x182AEFEF0")]
		public bool JPOHKNFHLNH(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0590", Offset = "0x2AEEF90", VA = "0x182AF0590")]
		public bool MBONPEPBIOM(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF04C0", Offset = "0x2AEEEC0", VA = "0x182AF04C0")]
		public bool MBONPEPBIOM(EIJALHDNNPP BIONDBIGACN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void JKCNKCPCFNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEF40", Offset = "0x2AED940", VA = "0x182AEEF40")]
		private void EKJHCPNLFIA(bool PJIDDOOMHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0x2AEEEB0", Offset = "0x2AED8B0", VA = "0x182AEEEB0")]
		private bool EHPIDPGOIHO(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE7E0", Offset = "0x2AED1E0", VA = "0x182AEE7E0")]
		private HBIBAGENGHJ DPCJKEKNAGF(Entity GOANOLJBHPF, object DEGCIHEAIBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0970", Offset = "0x2AEF370", VA = "0x182AF0970")]
		private HBIBAGENGHJ NIEFMJMHONO(Entity GOANOLJBHPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFC00", Offset = "0x2AEE600", VA = "0x182AEFC00")]
		private (Vector3, Quaternion, Vector3) HPJCPDGJDGI(Entity GOANOLJBHPF)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE0B0", Offset = "0x2AECAB0", VA = "0x182AEE0B0")]
		private void BAGJGJLNJNC(Entity GOANOLJBHPF, AOIKBHJMDBO GDAJCNKPBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFFB0", Offset = "0x2AEE9B0", VA = "0x182AEFFB0")]
		private void KOOAEJGNLEE(DFKOJFHJBPL PMMCMCPNCLD, HBIBAGENGHJ GKKAOEHIFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE1C0", Offset = "0x2AECBC0", VA = "0x182AEE1C0")]
		private void BBFHHICFDAC(HBIBAGENGHJ GKKAOEHIFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B49")]
		[Cpp2IlInjected.Address(RVA = "0x2AEE5B0", Offset = "0x2AECFB0", VA = "0x182AEE5B0")]
		private void DGLEHIGGECG(HBIBAGENGHJ MIDDDIBGPID, Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0FD0", Offset = "0x2AEF9D0", VA = "0x182AF0FD0")]
		private void OANBAGDKOHG(Entity GOANOLJBHPF, HBIBAGENGHJ MIDDDIBGPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0600", Offset = "0x2AEF000", VA = "0x182AF0600")]
		private void MHFHEBBDOLG(Entity GOANOLJBHPF, Transform CLHKPCIOCGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4C")]
		[Cpp2IlInjected.Address(RVA = "0x2AEFEC0", Offset = "0x2AEE8C0", VA = "0x182AEFEC0")]
		private DFKOJFHJBPL IIGKKDDMFJO(Entity GOANOLJBHPF)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1EE0", Offset = "0x2AF08E0", VA = "0x182AF1EE0")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B4F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0B60", Offset = "0x2AEF560", VA = "0x182AF0B60")]
		[CompilerGenerated]
		private void NLOPPKKICCF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
internal static class NACKPNFIEMD
{
	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7D80", Offset = "0x2AE6780", VA = "0x182AE7D80")]
	public static HBIBAGENGHJ PIKENIAFHJF(this ObjectEmbodimentService CHJAOAHKKML, DFKOJFHJBPL PMMCMCPNCLD, [Optional] object DEGCIHEAIBD)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AF")]
	[DNOPHNKOHLA(typeof(ObjectLifecycleService), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.Lifecycle)]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	internal sealed class ObjectLifecycleService : MMKNGEFLOAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private ObjectEmbodimentService MIDDDIBGPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN ALIKEONHNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private DBDNMBFJLEK GEODCBKPIGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private DestroyLocalObjects GEAFNJBHPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		private EntityManager FLHDGCEBOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B55")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2A20", Offset = "0x2AF1420", VA = "0x182AF2A20")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<Entity, AOIKBHJMDBO> NIEIHPJBMLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x2AF34C0", Offset = "0x2AF1EC0", VA = "0x182AF34C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B52")]
			[Cpp2IlInjected.Address(RVA = "0x2AF26E0", Offset = "0x2AF10E0", VA = "0x182AF26E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event Action<Entity> GNPBFKGILAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000B53")]
			[Cpp2IlInjected.Address(RVA = "0x2AF2780", Offset = "0x2AF1180", VA = "0x182AF2780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000B54")]
			[Cpp2IlInjected.Address(RVA = "0x2AF3140", Offset = "0x2AF1B40", VA = "0x182AF3140")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2940", Offset = "0x2AF1340", VA = "0x182AF2940", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x102B4F0", Offset = "0x1029EF0", VA = "0x18102B4F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2820", Offset = "0x2AF1220", VA = "0x182AF2820")]
		public bool FDOEJMJEMDK(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x2AF28E0", Offset = "0x2AF12E0", VA = "0x182AF28E0")]
		internal void GDPOEAPLEGG(Entity GOANOLJBHPF, AOIKBHJMDBO GDAJCNKPBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF28A0", Offset = "0x2AF12A0", VA = "0x182AF28A0")]
		public void FFMAALCHNFN(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2EF0", Offset = "0x2AF18F0", VA = "0x182AF2EF0")]
		public void JOMAKIIALKC(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2620", Offset = "0x2AF1020", VA = "0x182AF2620")]
		private bool ANDGIKBKEMP(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3230", Offset = "0x2AF1C30", VA = "0x182AF3230")]
		public void NJKFKCNNMGK(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2AD0", Offset = "0x2AF14D0", VA = "0x182AF2AD0")]
		private bool IHDEFNKOJMK(Entity GOANOLJBHPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF3430", Offset = "0x2AF1E30", VA = "0x182AF3430")]
		public void ODELNGMKLPF(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2A70", Offset = "0x2AF1470", VA = "0x182AF2A70")]
		private void HBJEGHBDHHI(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2C90", Offset = "0x2AF1690", VA = "0x182AF2C90")]
		private void JKMPJGNFCHB(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x2AF31E0", Offset = "0x2AF1BE0", VA = "0x182AF31E0")]
		public void MGDLALMHOPM(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		private void PAMHHGDOJDE(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2F40", Offset = "0x2AF1940", VA = "0x182AF2F40")]
		private void KOIPHFICKOP(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	[DNOPHNKOHLA(typeof(ObjectPrefabs), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.Prefabs)]
	internal class ObjectPrefabs : DFMKILDNMLK, MMKNGEFLOAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[CompilerGenerated]
		private sealed class PCCAJJDJEDB : IEnumerable<(MGHIFAKDBDN, AOIKBHJMDBO)>, IEnumerable, IEnumerator<(MGHIFAKDBDN, AOIKBHJMDBO)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000532")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000533")]
			private (MGHIFAKDBDN primitiveType, AOIKBHJMDBO prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000534")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700013A")]
			private (MGHIFAKDBDN, AOIKBHJMDBO) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B85")]
				[Cpp2IlInjected.Address(RVA = "0x24CCB30", Offset = "0x24CB530", VA = "0x1824CCB30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((MGHIFAKDBDN, AOIKBHJMDBO));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700013B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000B87")]
				[Cpp2IlInjected.Address(RVA = "0x3FF9D10", Offset = "0x3FF8710", VA = "0x183FF9D10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x3FF2C20", Offset = "0x3FF1620", VA = "0x183FF2C20")]
			[DebuggerHidden]
			public PCCAJJDJEDB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x3FF9B30", Offset = "0x3FF8530", VA = "0x183FF9B30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x3FF9CD0", Offset = "0x3FF86D0", VA = "0x183FF9CD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x3FF9C30", Offset = "0x3FF8630", VA = "0x183FF9C30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(MGHIFAKDBDN, AOIKBHJMDBO)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x3FF9C30", Offset = "0x3FF8630", VA = "0x183FF9C30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN ALIKEONHNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private World HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private readonly Dictionary<AOIKBHJMDBO, Entity> HPAFIPNLAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private readonly Dictionary<AOIKBHJMDBO, EntityArchetype> HLFMABEDCDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private readonly Dictionary<MGHIFAKDBDN, AOIKBHJMDBO> LLANOAHEODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private readonly Dictionary<HFJJNJCDHGL, AOIKBHJMDBO> JPBEMBJAHJJ;

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		public int HPEOPAJJAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000B67")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6E90", Offset = "0x2AF5890", VA = "0x182AF6E90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		public EntityManager FLHDGCEBOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000B68")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6E00", Offset = "0x2AF5800", VA = "0x182AF6E00")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6910", Offset = "0x2AF5310", VA = "0x182AF6910", Slot = "5")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6410", Offset = "0x2AF4E10", VA = "0x182AF6410", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7350", Offset = "0x2AF5D50", VA = "0x182AF7350")]
		internal IEnumerable<Type> LOAPCCPOJCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF61C0", Offset = "0x2AF4BC0", VA = "0x182AF61C0")]
		internal EDJDLABAIND BBIEFLDIIHJ(Type MAHAMGBPDNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6230", Offset = "0x2AF4C30", VA = "0x182AF6230")]
		public EntityArchetype DHCHHNALECL(AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6290", Offset = "0x2AF4C90", VA = "0x182AF6290")]
		public NativeHashMap<int, EntityArchetype> DHLANCHAGDE(Allocator GGPAKDMJHLJ = Allocator.Temp)
		{
			return default(NativeHashMap<int, EntityArchetype>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6740", Offset = "0x2AF5140", VA = "0x182AF6740")]
		public bool EFGAJFKCCAG(AOIKBHJMDBO GDAJCNKPBDC, out EntityArchetype COAKPOHIAFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x2AF72E0", Offset = "0x2AF5CE0", VA = "0x182AF72E0", Slot = "4")]
		[IteratorStateMachine(typeof(PCCAJJDJEDB))]
		public IEnumerable<(MGHIFAKDBDN, AOIKBHJMDBO)> LJIMDEEFLLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6CF0", Offset = "0x2AF56F0", VA = "0x182AF6CF0")]
		public Entity GKODLOMCAKJ(AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B72")]
		[Cpp2IlInjected.Address(RVA = "0x2AF7410", Offset = "0x2AF5E10", VA = "0x182AF7410")]
		public AOIKBHJMDBO MGDPAKACCKF(HFJJNJCDHGL MAHAMGBPDNB)
		{
			return default(AOIKBHJMDBO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B73")]
		[Cpp2IlInjected.Address(RVA = "0x2AF73B0", Offset = "0x2AF5DB0", VA = "0x182AF73B0")]
		public AOIKBHJMDBO MGDPAKACCKF(MGHIFAKDBDN MAHAMGBPDNB)
		{
			return default(AOIKBHJMDBO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B74")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5C00", Offset = "0x2AF4600", VA = "0x182AF5C00")]
		public NativeHashMap<int, Entity> AJPLHBNIKGA(Allocator GGPAKDMJHLJ = Allocator.Temp)
		{
			return default(NativeHashMap<int, Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6F40", Offset = "0x2AF5940", VA = "0x182AF6F40")]
		public IEnumerable<AOIKBHJMDBO> KLELAJFLFEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6EE0", Offset = "0x2AF58E0", VA = "0x182AF6EE0")]
		public Entity KBACFGPJNJM(AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6E20", Offset = "0x2AF5820", VA = "0x182AF6E20")]
		public bool HNHIBNDKIOP(AOIKBHJMDBO GDAJCNKPBDC, out Entity JFEEEILBEOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B78")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5D70", Offset = "0x2AF4770", VA = "0x182AF5D70")]
		private void AKLIDILFEMK(EDJDLABAIND PLLALHACBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B79")]
		[Cpp2IlInjected.Address(RVA = "0x2AF6F90", Offset = "0x2AF5990", VA = "0x182AF6F90")]
		internal void KLIIMOMFCAK(AOIKBHJMDBO GDAJCNKPBDC, ComponentTypeList IHBIJOPCCEO, FHINBEIIHEC LCAPNNMOLIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF67B0", Offset = "0x2AF51B0", VA = "0x182AF67B0")]
		private void GEDJJNOEAJN(AOIKBHJMDBO GDAJCNKPBDC, ComponentTypeList LODPHDEIJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF71C0", Offset = "0x2AF5BC0", VA = "0x182AF71C0")]
		internal Entity LGHILGDDHAA(AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF74C0", Offset = "0x2AF5EC0", VA = "0x182AF74C0")]
		public ObjectPrefabs()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public enum DHNNDIENLFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20001B4")]
internal interface PLEBHECDJPF
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	World HPHMIKCABBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	OPOIKGEPLKG GOKOLGJLJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
internal class MIIFFNKAFAF : DLFINNIIPGN, NEBKGLHCLEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	private readonly PEAHLBLIMKC PHMFLDLOMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private readonly DHNNDIENLFJ GIFOAOGCBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private readonly List<IMKLILNFGJP> OLIPJHPNPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private NativeMultiHashMap<Entity, NDHLMGGHOHI> FNAJLOCDDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private NativeHashMap<int, int> KBIMOEIGHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private JobHandle EDOPPEJPCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	private JobHandle OOFKNEIFCHF;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	private World IGNKEOFJBOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x2AE5A50", Offset = "0x2AE4450", VA = "0x182AE5A50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private OPOIKGEPLKG HBEFBPCCAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x2AE5BA0", Offset = "0x2AE45A0", VA = "0x182AE5BA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private EIAFJKLDNIF AKKHIELEADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5D40", Offset = "0x6D4740", VA = "0x1806D5D40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private NativeMultiHashMap<Entity, NDHLMGGHOHI> LHHJOMHCKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x6E2030", Offset = "0x6E0A30", VA = "0x1806E2030", Slot = "7")]
		get
		{
			return default(NativeMultiHashMap<Entity, NDHLMGGHOHI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private JobHandle CJHAGKHDKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x143D240", Offset = "0x143BC40", VA = "0x18143D240", Slot = "8")]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x1521000", Offset = "0x151FA00", VA = "0x181521000", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private bool AOOGPENLBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6760", Offset = "0x2AE5160", VA = "0x182AE6760", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private World OAACLIFDAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x2AE6770", Offset = "0x2AE5170", VA = "0x182AE6770", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE67D0", Offset = "0x2AE51D0", VA = "0x182AE67D0")]
	public MIIFFNKAFAF(PEAHLBLIMKC PHMFLDLOMDJ, DHNNDIENLFJ GIFOAOGCBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x2AE64A0", Offset = "0x2AE4EA0", VA = "0x182AE64A0", Slot = "11")]
	private void NGEMJMBFOCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5930", Offset = "0x2AE4330", VA = "0x182AE5930", Slot = "10")]
	private bool CMLIHBNFFEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x2AE63B0", Offset = "0x2AE4DB0", VA = "0x182AE63B0", Slot = "12")]
	private void LCPGDMBDFNB(ComponentType NOIFPDMFLMJ, in IMKLILNFGJP JIIHAKIHFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5E80", Offset = "0x2AE4880", VA = "0x182AE5E80", Slot = "13")]
	private bool IAJHCJLMBEJ(AOIKBHJMDBO GDAJCNKPBDC, out Entity JFEEEILBEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5BC0", Offset = "0x2AE45C0", VA = "0x182AE5BC0", Slot = "16")]
	private bool FODMINEINIA(out NativeArray<int> GLMCNJLIMCG, Allocator GGPAKDMJHLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE61F0", Offset = "0x2AE4BF0", VA = "0x182AE61F0", Slot = "17")]
	private bool JOFAHBEHHOC(ComponentType NOIFPDMFLMJ, out IMKLILNFGJP JFLKLBLBBCJ, out NEHEJIIOPJI KHEIMOEOLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x2AE60C0", Offset = "0x2AE4AC0", VA = "0x182AE60C0", Slot = "18")]
	private bool JOFAHBEHHOC(ComponentType NOIFPDMFLMJ, out IMKLILNFGJP JFLKLBLBBCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5AB0", Offset = "0x2AE44B0", VA = "0x182AE5AB0", Slot = "19")]
	private IMKLILNFGJP COJMBLEHLLO(ComponentType NOIFPDMFLMJ)
	{
		return default(IMKLILNFGJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5EB0", Offset = "0x2AE48B0", VA = "0x182AE5EB0", Slot = "20")]
	private HKJCDGEBOAC IELIGFGPHLL()
	{
		return default(HKJCDGEBOAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5EF0", Offset = "0x2AE48F0", VA = "0x182AE5EF0", Slot = "21")]
	private void IEMMPOMOBOI(JobHandle NNGFCFNIJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE64B0", Offset = "0x2AE4EB0", VA = "0x182AE64B0")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5C60", Offset = "0x2AE4660", VA = "0x182AE5C60")]
	private bool GOLOLNODELP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5F30", Offset = "0x2AE4930", VA = "0x182AE5F30")]
	private int IFOFELBKLFL()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal class PEAHLBLIMKC : PLEBHECDJPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	public DEAGKEFEBKN ALIKEONHNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000543")]
	public ObjectInstantiationService HPAFIPNLAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000544")]
	public OPOIKGEPLKG OLKMBFLGFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000545")]
	public EIAFJKLDNIF KMBFKFIKBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	public LFCKLHJEONJ DPLECGMODAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	public bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public World HPHMIKCABBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA2")]
		[Cpp2IlInjected.Address(RVA = "0x2AFAAE0", Offset = "0x2AF94E0", VA = "0x182AFAAE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public OPOIKGEPLKG GOKOLGJLJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA3")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PEAHLBLIMKC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B7")]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	[DNOPHNKOHLA(typeof(PropertyDiffStateService), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.PropertyChanges)]
	internal class PropertyDiffStateService : MMKNGEFLOAO, PKBAIAJJFPF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001B8")]
		internal readonly struct GFDJGKMCIHL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054C")]
			private readonly DHNNDIENLFJ LEFCLDKBIDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			private readonly PropertyDiffStateService DMALFCEFIJB;

			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0x3FF1DA0", Offset = "0x3FF07A0", VA = "0x183FF1DA0")]
			public GFDJGKMCIHL(PropertyDiffStateService DMALFCEFIJB, DHNNDIENLFJ MOBMHMDBGHC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x3FF1D80", Offset = "0x3FF0780", VA = "0x183FF1D80", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private readonly PEAHLBLIMKC PHMFLDLOMDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private readonly MIIFFNKAFAF[] HOMFFFBLBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private DHNNDIENLFJ MLKBFAPCLDO;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		public PLEBHECDJPF CKGAPBOEMBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		public NEBKGLHCLEJ IDBPLKDDDKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x2A60C60", Offset = "0x2A5F660", VA = "0x182A60C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		public DLFINNIIPGN NJACHHOLEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x2A60C60", Offset = "0x2A5F660", VA = "0x182A60C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x88EEA0", Offset = "0x88D8A0", VA = "0x18088EEA0")]
		public NEBKGLHCLEJ HPOPDNEMBMC(DHNNDIENLFJ GIFOAOGCBEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0x88EEA0", Offset = "0x88D8A0", VA = "0x18088EEA0")]
		public DLFINNIIPGN EDJGCCHFHFE(DHNNDIENLFJ GIFOAOGCBEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAA")]
		[Cpp2IlInjected.Address(RVA = "0x2B038E0", Offset = "0x2B022E0", VA = "0x182B038E0", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAB")]
		[Cpp2IlInjected.Address(RVA = "0x2B03520", Offset = "0x2B01F20", VA = "0x182B03520", Slot = "5")]
		public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAC")]
		[Cpp2IlInjected.Address(RVA = "0x2B03980", Offset = "0x2B02380", VA = "0x182B03980")]
		public void NMFIICNHENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0x2B03440", Offset = "0x2B01E40", VA = "0x182B03440", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x2B03960", Offset = "0x2B02360", VA = "0x182B03960")]
		public GFDJGKMCIHL KNPDNCJIPIE(DHNNDIENLFJ GIFOAOGCBEF)
		{
			return default(GFDJGKMCIHL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x2B03A30", Offset = "0x2B02430", VA = "0x182B03A30")]
		public PropertyDiffStateService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	[LOEOGANCBGC(EDPDLGMLNHJ.HierarchySystems)]
	[DNOPHNKOHLA(typeof(SceneService), new string[] { })]
	internal class SceneService : MMKNGEFLOAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public static readonly SceneTag DCAEDMKBOPM;

		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public const string IPGGGEHJAPP = "DontDestroyOnLoadScene";

		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private const string IHMLOHGDFFJ = "<All Scenes>";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		[JIFPDEDMPGC]
		private ODIDMGCABMI EEKPEHGPCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		[JIFPDEDMPGC]
		private ObjectEmbodimentService MIDDDIBGPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		[JIFPDEDMPGC]
		private KHCPECBGMIK EIGABIBFMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		[JIFPDEDMPGC]
		private SingletonComponentService CNJMFAEGKKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		[JIFPDEDMPGC]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		[JIFPDEDMPGC]
		private PhotonInstanceCleanupService HDNPPFAEJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private EntityQuery IBJIEEPLACE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private EntityQuery LFLNDHBGBIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private EntityQuery FEEEADHEMHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private Entity ICDHBFOLFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		public bool LPPPHGAENMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0x2BFC550", Offset = "0x2BFAF50", VA = "0x182BFC550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		public NativeArray<Entity> ONGLBIMICMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0x1612200", Offset = "0x1610C00", VA = "0x181612200")]
			[CompilerGenerated]
			get
			{
				return default(NativeArray<Entity>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0x1BB71D0", Offset = "0x1BB5BD0", VA = "0x181BB71D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		public Entity PICLPIEABOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x2BFC400", Offset = "0x2BFAE00", VA = "0x182BFC400")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		public SceneTag MJKMLCLEHEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(RVA = "0x2BFBD30", Offset = "0x2BFA730", VA = "0x182BFBD30")]
			get
			{
				return default(SceneTag);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		public Entity OHMKDLDFMCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(RVA = "0x2BFBD30", Offset = "0x2BFA730", VA = "0x182BFBD30")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(RVA = "0x2BFCD10", Offset = "0x2BFB710", VA = "0x182BFCD10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		private EntityManager FLHDGCEBOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(RVA = "0x2BFC6C0", Offset = "0x2BFB0C0", VA = "0x182BFC6C0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC5A0", Offset = "0x2BFAFA0", VA = "0x182BFC5A0", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC2B0", Offset = "0x2BFACB0", VA = "0x182BFC2B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x2BFBD80", Offset = "0x2BFA780", VA = "0x182BFBD80")]
		public void BFBFMNAAHAD(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC710", Offset = "0x2BFB110", VA = "0x182BFC710")]
		public NativeArray<Entity> HOJKJKFAGOC(Allocator GGPAKDMJHLJ = Allocator.TempJob)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC300", Offset = "0x2BFAD00", VA = "0x182BFC300")]
		public void EBCKGCBHDLM(Entity BBIKMOACHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x2BFBEB0", Offset = "0x2BFA8B0", VA = "0x182BFBEB0")]
		public Entity CNLHLNPOMNJ(string ANJJEPIBAGI = "")
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD960", Offset = "0x2BFC360", VA = "0x182BFD960")]
		public void PJOEAELOOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x2BFCCF0", Offset = "0x2BFB6F0", VA = "0x182BFCCF0")]
		public void KFILGBHBPDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x2BFCC90", Offset = "0x2BFB690", VA = "0x182BFCC90")]
		public void JLPHONDPCPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC4")]
		[Cpp2IlInjected.Address(RVA = "0x2BFCC80", Offset = "0x2BFB680", VA = "0x182BFCC80")]
		public void JIGIGMMLOLC(Entity BBIKMOACHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD8B0", Offset = "0x2BFC2B0", VA = "0x182BFD8B0")]
		public bool PJIGAJONCAM(Entity BBIKMOACHCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD6E0", Offset = "0x2BFC0E0", VA = "0x182BFD6E0")]
		public void PAPCHHHCEAF(Entity BBIKMOACHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD0E0", Offset = "0x2BFBAE0", VA = "0x182BFD0E0")]
		public string MKMDECAHAKE(Entity BBIKMOACHCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC8")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		public void ANKCLDCCCOA(Entity BBIKMOACHCN, string ANJJEPIBAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC9")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD0C0", Offset = "0x2BFBAC0", VA = "0x182BFD0C0")]
		public bool MEBFAAJGHJF(string ANJJEPIBAGI, out Entity BBIKMOACHCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCA")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD6F0", Offset = "0x2BFC0F0", VA = "0x182BFD6F0")]
		public void PBBGBLALBPH(Entity BBIKMOACHCN, bool PDMBHLGGGGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCB")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC1C0", Offset = "0x2BFABC0", VA = "0x182BFC1C0")]
		public void DJJKBHCOFLH(Entity GOANOLJBHPF, bool GBJONCEHEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCC")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC240", Offset = "0x2BFAC40", VA = "0x182BFC240")]
		public void DJJKBHCOFLH(NativeArray<Entity> CGCCIONMJJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCD")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC0D0", Offset = "0x2BFAAD0", VA = "0x182BFC0D0")]
		public void DJJKBHCOFLH(EntityQuery CAMLCFELNDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCE")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD480", Offset = "0x2BFBE80", VA = "0x182BFD480")]
		public void MPOIIKFLHOI(Entity GOANOLJBHPF, Entity BBIKMOACHCN, bool GBJONCEHEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD1F0", Offset = "0x2BFBBF0", VA = "0x182BFD1F0")]
		public void MPOIIKFLHOI(NativeArray<Entity> CGCCIONMJJA, Entity BBIKMOACHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD3D0", Offset = "0x2BFBDD0", VA = "0x182BFD3D0")]
		public void MPOIIKFLHOI(EntityQuery CAMLCFELNDE, Entity BBIKMOACHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD1")]
		[Cpp2IlInjected.Address(RVA = "0x2BFCD80", Offset = "0x2BFB780", VA = "0x182BFCD80")]
		private void LCCNBKOPOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD2")]
		[Cpp2IlInjected.Address(RVA = "0x2BFBF30", Offset = "0x2BFA930", VA = "0x182BFBF30")]
		private void DAAAAPELIBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD3")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC400", Offset = "0x2BFAE00", VA = "0x182BFC400")]
		private Entity FOBAINEPCOK()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD4")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD800", Offset = "0x2BFC200", VA = "0x182BFD800")]
		private void PDBPLCPDEON(Entity BBIKMOACHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC740", Offset = "0x2BFB140", VA = "0x182BFC740")]
		private void IAKEJCMLIOO(EntityQuery INJNJGEFLBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x2BFC810", Offset = "0x2BFB210", VA = "0x182BFC810")]
		private void IAKEJCMLIOO(NativeArray<Entity> OOKLBGAMMBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x2BFBE00", Offset = "0x2BFA800", VA = "0x182BFBE00")]
		private void CLODLIJLPKL(Entity BBIKMOACHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x2BFCF30", Offset = "0x2BFB930", VA = "0x182BFCF30")]
		private void LMKGLIAGBPC(Entity BBIKMOACHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x2BFBF60", Offset = "0x2BFA960", VA = "0x182BFBF60")]
		private void DJDPPHNIDJN(SceneTag IKMKMICIEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x2BFBDC0", Offset = "0x2BFA7C0", VA = "0x182BFBDC0")]
		private void CFJMGFPMIDE(SceneTag IKMKMICIEDL, global::BJBEMKAEBCB<int> FHLGIAEAPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x2BFCAF0", Offset = "0x2BFB4F0", VA = "0x182BFCAF0")]
		private void ICEIDFACPEP(SceneTag IKMKMICIEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x2BFBC90", Offset = "0x2BFA690", VA = "0x182BFBC90")]
		private void ACEHIAGDIML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x3729290", Offset = "0x3727C90", VA = "0x183729290")]
		private void GPIPLGEIMII<T>() where T : ComponentSystemBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void GGLHDOBPALP(SceneTag IKMKMICIEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD060", Offset = "0x2BFBA60", VA = "0x182BFD060")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void MDKMHECJMBD(EntityQuery CAMLCFELNDE, string ANJJEPIBAGI, SceneTag IKMKMICIEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x2BFD6B0", Offset = "0x2BFC0B0", VA = "0x182BFD6B0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void OJPCCPMJBMJ(Entity BBIKMOACHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void NKCPHIFMOBD(Entity BBIKMOACHCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public SceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[AINPJLGDEKF(EIJAKMAIFNG.PhotonRoom)]
	[DNOPHNKOHLA(typeof(KJFLPHKBABP), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.HierarchySystems)]
	internal class UnitySceneService : MMKNGEFLOAO, KJFLPHKBABP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		[JIFPDEDMPGC]
		private SceneService OOKLBGAMMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private readonly Dictionary<int, Entity> CBBDJMABKHP;

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		private EntityManager FLHDGCEBOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x2C0B7B0", Offset = "0x2C0A1B0", VA = "0x182C0B7B0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B720", Offset = "0x2C0A120", VA = "0x182C0B720", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B540", Offset = "0x2C09F40", VA = "0x182C0B540", Slot = "5")]
		public void BFBFMNAAHAD(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE7")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B800", Offset = "0x2C0A200", VA = "0x182C0B800", Slot = "6")]
		public bool KKFEOEDEOBJ(DFKOJFHJBPL PMMCMCPNCLD, Transform CLHKPCIOCGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B6B0", Offset = "0x2C0A0B0", VA = "0x182C0B6B0")]
		private bool DDIDOIHAJBG(Scene BBIKMOACHCN, out Entity BKFFFCDBEOD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x2C0B9F0", Offset = "0x2C0A3F0", VA = "0x182C0B9F0")]
		public UnitySceneService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BB")]
	[LOEOGANCBGC(EDPDLGMLNHJ.ComponentSystemTypes)]
	[DNOPHNKOHLA(typeof(SingletonComponentService), new string[] { })]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	internal sealed class SingletonComponentService : MMKNGEFLOAO, PKBAIAJJFPF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		[JIFPDEDMPGC]
		private KHCPECBGMIK EIGABIBFMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private Entity GOANOLJBHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private ComponentTypeList LODPHDEIJJI;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public int HPEOPAJJAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEA")]
			[Cpp2IlInjected.Address(RVA = "0x2C028C0", Offset = "0x2C012C0", VA = "0x182C028C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public Entity BHDJCIPFNNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEB")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		private EntityManager FLHDGCEBOEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000BEC")]
			[Cpp2IlInjected.Address(RVA = "0x2C027D0", Offset = "0x2C011D0", VA = "0x182C027D0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x372AB80", Offset = "0x3729580", VA = "0x18372AB80")]
		public T AGGAFJIIBKL<T>() where T : struct, ISystemStateComponentData
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x372AC40", Offset = "0x3729640", VA = "0x18372AC40")]
		public void NLANNFAIKGA<T>(T MNIAGKNOHEJ) where T : struct, ISystemStateComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x2C02760", Offset = "0x2C01160", VA = "0x182C02760", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x2C01FF0", Offset = "0x2C009F0", VA = "0x182C01FF0", Slot = "5")]
		public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF1")]
		[Cpp2IlInjected.Address(RVA = "0x2C01FF0", Offset = "0x2C009F0", VA = "0x182C01FF0")]
		private void CFBIBDGEJCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF2")]
		[Cpp2IlInjected.Address(RVA = "0x2C02490", Offset = "0x2C00E90", VA = "0x182C02490", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF3")]
		[Cpp2IlInjected.Address(RVA = "0x2C02190", Offset = "0x2C00B90", VA = "0x182C02190")]
		private ComponentTypeList DEMEAGMCGIF()
		{
			return default(ComponentTypeList);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		private static void PBBFAMIGFPB(int JOBJIONNEHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		private static void DPHNMBEOOOA(Type MAHAMGBPDNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x2C02820", Offset = "0x2C01220", VA = "0x182C02820")]
		private static void JGIBDCNAEDB(Type MAHAMGBPDNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public SingletonComponentService()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BC")]
internal struct FCIAPLBJKHE : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
[DNOPHNKOHLA(typeof(ABOINJIGLHC), new string[] { })]
internal sealed class ABOINJIGLHC : MMKNGEFLOAO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	[JIFPDEDMPGC]
	private DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	private global::GBCMHMFPJGH<JFHJAKPCJDO, Entity> IBLKGEJGAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	private global::MMCBEEPMOEL<COJJCAEFPDP> FLHCEGLJOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	private global::MMCBEEPMOEL<IHCHBKCIFNG> LFABHMGOJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	private global::MMCBEEPMOEL<MDHJMEMJNJM> DCJLLCIGLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	private global::MMCBEEPMOEL<LGFAJKOANJE> IJJBFGNDBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	private global::MMCBEEPMOEL<KJIGHOHBPOO> CHJAOAHKKML;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public global::MFOCLGLDEAM<Entity> NMNBGPDHLBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public HCLJNDNCLEM CPCLFICDHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public HCLJNDNCLEM CPAMBGKMNPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public HCLJNDNCLEM AFHAJNPIBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public HCLJNDNCLEM KOIJFHLNDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public HCLJNDNCLEM ABLHDPCEJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x6C8580", Offset = "0x6C6F80", VA = "0x1806C8580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private EntityManager FLHDGCEBOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x2DED980", Offset = "0x2DEC380", VA = "0x182DED980")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C00")]
	[Cpp2IlInjected.Address(RVA = "0x2DED870", Offset = "0x2DEC270", VA = "0x182DED870", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x2DED780", Offset = "0x2DEC180", VA = "0x182DED780", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x23DBD80", Offset = "0x23DA780", VA = "0x1823DBD80")]
	private void HAKOKLHEDIO<T>(ref global::MMCBEEPMOEL<T> GLOEEIEEKAA) where T : struct, IMOHFLKNJIO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x23DBD80", Offset = "0x23DA780", VA = "0x1823DBD80")]
	private void HAKOKLHEDIO<TC, TV>(ref global::GBCMHMFPJGH<TC, TV> GLOEEIEEKAA) where TC : struct, IMOHFLKNJIO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public ABOINJIGLHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[DNOPHNKOHLA(typeof(PCBLNGPNPOI), new string[] { })]
[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
internal sealed class PCBLNGPNPOI : IPCGJDFHGJG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	private BCPGIKNGDDK GGHMEIMJMHH;

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public BCPGIKNGDDK CIAIPGHKONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x1FE53E0", Offset = "0x1FE3DE0", VA = "0x181FE53E0")]
		get
		{
			return default(BCPGIKNGDDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA140", Offset = "0x2AF8B40", VA = "0x182AFA140", Slot = "4")]
	public void BEJHKBIOAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA190", Offset = "0x2AF8B90", VA = "0x182AFA190", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PCBLNGPNPOI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	[DNOPHNKOHLA(typeof(TransformOwnershipPhase), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.HierarchySystems)]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x20001C0")]
		public enum JMGLONJAMFB
		{
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x20001C1")]
		public struct LPIDGAINDMN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			private JMGLONJAMFB EOOPKOAGBHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			private readonly TransformOwnershipPhase ELGBIOMPEHN;

			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6FC0", Offset = "0x3FF59C0", VA = "0x183FF6FC0")]
			public LPIDGAINDMN(TransformOwnershipPhase ELGBIOMPEHN, JMGLONJAMFB GIFOAOGCBEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6FA0", Offset = "0x3FF59A0", VA = "0x183FF6FA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		public JMGLONJAMFB GIFOAOGCBEF;

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public JMGLONJAMFB NPAINDCMEDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C09")]
			[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040")]
			get
			{
				return default(JMGLONJAMFB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C0A")]
			[Cpp2IlInjected.Address(RVA = "0x6E1F30", Offset = "0x6E0930", VA = "0x1806E1F30")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public bool DDMHFIEBADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0B")]
			[Cpp2IlInjected.Address(RVA = "0xB5B250", Offset = "0xB59C50", VA = "0x180B5B250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public bool EPAGGCANLCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0C")]
			[Cpp2IlInjected.Address(RVA = "0x21904A0", Offset = "0x218EEA0", VA = "0x1821904A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x2C05B90", Offset = "0x2C04590", VA = "0x182C05B90")]
		public LPIDGAINDMN GAKJKANLHEL()
		{
			return default(LPIDGAINDMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x2C05BC0", Offset = "0x2C045C0", VA = "0x182C05BC0")]
		public LPIDGAINDMN NPPIOCLMPMA()
		{
			return default(LPIDGAINDMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public TransformOwnershipPhase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C2")]
	[DNOPHNKOHLA(typeof(OFJGIHJMMMN), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.Circuits)]
	public class CircuitsService : MMKNGEFLOAO, OFJGIHJMMMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		[JIFPDEDMPGC]
		private PEDCBEJAKGP EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private EntityManager BJMEFCCEPHI;

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5E00", Offset = "0x2DF4800", VA = "0x182DF5E00", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x2DF67F0", Offset = "0x2DF51F0", VA = "0x182DF67F0", Slot = "5")]
		public bool ODFNLHBOEEC(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5960", Offset = "0x2DF4360", VA = "0x182DF5960", Slot = "7")]
		public bool DGHNIPAPIAI(DFKOJFHJBPL PMMCMCPNCLD, out Guid LDLPOFLCBNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x2DF68F0", Offset = "0x2DF52F0", VA = "0x182DF68F0", Slot = "8")]
		public Guid PLLMEPDDHNN(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5A50", Offset = "0x2DF4450", VA = "0x182DF5A50", Slot = "9")]
		public void FDKCEKDJMBJ(DFKOJFHJBPL PMMCMCPNCLD, Guid LDLPOFLCBNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5CB0", Offset = "0x2DF46B0", VA = "0x182DF5CB0", Slot = "10")]
		public bool FHIDGNNLHIP(DFKOJFHJBPL PMMCMCPNCLD, out Guid OIGKBPKEMEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x2DF66E0", Offset = "0x2DF50E0", VA = "0x182DF66E0", Slot = "11")]
		public Guid LBKJNAEBHMJ(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5590", Offset = "0x2DF3F90", VA = "0x182DF5590", Slot = "12")]
		public void CAKOKKBAGCP(DFKOJFHJBPL PMMCMCPNCLD, Guid OIGKBPKEMEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5540", Offset = "0x2DF3F40", VA = "0x182DF5540", Slot = "13")]
		public bool BIKHPIIDDEH(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6670", Offset = "0x2DF5070", VA = "0x182DF6670", Slot = "14")]
		public void KPFMHMGEEPN(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6200", Offset = "0x2DF4C00", VA = "0x182DF6200", Slot = "15")]
		public void KCEBCIAEALA(DFKOJFHJBPL JNODNCHMALF, DFKOJFHJBPL ELGBIOMPEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x2DF57F0", Offset = "0x2DF41F0", VA = "0x182DF57F0")]
		private void DCIDDFOIFJP(OPGCAADJABC FKEDBDBBHNO, DFKOJFHJBPL ELGBIOMPEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF6070", Offset = "0x2DF4A70", VA = "0x182DF6070")]
		private void JNOODOMDKDE(OPGCAADJABC FKEDBDBBHNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5EA0", Offset = "0x2DF48A0", VA = "0x182DF5EA0")]
		private bool HAAIDCONAHK(POPHLPHEEBM LAFPICAOEAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x2DF65C0", Offset = "0x2DF4FC0", VA = "0x182DF65C0")]
		private bool KNOCMNCHFGI(POPHLPHEEBM LAFPICAOEAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x2DF5DA0", Offset = "0x2DF47A0", VA = "0x182DF5DA0", Slot = "6")]
		public bool FMOPPCGJAFL(DFKOJFHJBPL EFHLICFAAGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public CircuitsService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[DNOPHNKOHLA(typeof(CPMCACBEBDN), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.Connectables)]
	internal class ConnectableService : CPMCACBEBDN, MMKNGEFLOAO, PKBAIAJJFPF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[CompilerGenerated]
		private sealed class OJCFLFDCDAE : IEnumerable<DFKOJFHJBPL>, IEnumerable, IEnumerator<DFKOJFHJBPL>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			private DFKOJFHJBPL <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000595")]
			private DFKOJFHJBPL localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000596")]
			public DFKOJFHJBPL <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000160")]
			private DFKOJFHJBPL System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4B")]
				[Cpp2IlInjected.Address(RVA = "0x6E2040", Offset = "0x6E0A40", VA = "0x1806E2040", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(DFKOJFHJBPL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000161")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C4D")]
				[Cpp2IlInjected.Address(RVA = "0x2BF9C80", Offset = "0x2BF8680", VA = "0x182BF9C80", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C46")]
			[Cpp2IlInjected.Address(RVA = "0x968EC0", Offset = "0x9678C0", VA = "0x180968EC0")]
			[DebuggerHidden]
			public OJCFLFDCDAE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C47")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9CD0", Offset = "0x2BF86D0", VA = "0x182BF9CD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C48")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9890", Offset = "0x2BF8290", VA = "0x182BF9890", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C49")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9DA0", Offset = "0x2BF87A0", VA = "0x182BF9DA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4A")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9DF0", Offset = "0x2BF87F0", VA = "0x182BF9DF0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4C")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9C40", Offset = "0x2BF8640", VA = "0x182BF9C40", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4E")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9B90", Offset = "0x2BF8590", VA = "0x182BF9B90", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<DFKOJFHJBPL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C4F")]
			[Cpp2IlInjected.Address(RVA = "0x2BF9B90", Offset = "0x2BF8590", VA = "0x182BF9B90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private static readonly KGOHPJFJCLE OEOMMNNMKLJ;

		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public const int DNEINOLCCPI = 0;

		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public const int IHAEEDAICFB = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private JOHEJCALJIO CAJCDELKPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private DEAGKEFEBKN HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private LFIFNADKAEF EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private PropertyEventCallbacksService BDLNKGOJBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private global::BBFFFGFDPOL<Entity> FIKCPIEANKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private global::BBFFFGFDPOL<float3> EPKNBIMALFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private global::BBFFFGFDPOL<quaternion> DALJNAMKHAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private global::BBFFFGFDPOL<Entity> ELGBIOMPEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private global::BBFFFGFDPOL<float3> GBGEGEKJOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private global::BBFFFGFDPOL<quaternion> HLMPNEAIKDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private HashSet<Entity> PBFLHAANLFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private HashSet<Entity> JNPONOIJPMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private EntityQuery IAAKEDMNPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public Func<OILFFIBNFMI> DFNFJBENIEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2D")]
			[Cpp2IlInjected.Address(RVA = "0x6D7750", Offset = "0x6D6150", VA = "0x1806D7750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2E")]
			[Cpp2IlInjected.Address(RVA = "0x7F4100", Offset = "0x7F2B00", VA = "0x1807F4100", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event Action<DFKOJFHJBPL, DFKOJFHJBPL> LAFCHHLEOGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000C25")]
			[Cpp2IlInjected.Address(RVA = "0x2DFB9F0", Offset = "0x2DFA3F0", VA = "0x182DFB9F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C26")]
			[Cpp2IlInjected.Address(RVA = "0x2DFAA30", Offset = "0x2DF9430", VA = "0x182DFAA30", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event Action<DFKOJFHJBPL, DFKOJFHJBPL> AEIKDLAFHHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C27")]
			[Cpp2IlInjected.Address(RVA = "0x2DFC450", Offset = "0x2DFAE50", VA = "0x182DFC450", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x2DFB720", Offset = "0x2DFA120", VA = "0x182DFB720", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action<DFKOJFHJBPL, DFKOJFHJBPL, DFKOJFHJBPL> FBIJMAJAKCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000C29")]
			[Cpp2IlInjected.Address(RVA = "0x2DFB8C0", Offset = "0x2DFA2C0", VA = "0x182DFB8C0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x2DFC3B0", Offset = "0x2DFADB0", VA = "0x182DFC3B0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action<DFKOJFHJBPL> LDFDFIFCLHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2B")]
			[Cpp2IlInjected.Address(RVA = "0x2DFA990", Offset = "0x2DF9390", VA = "0x182DFA990", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C2C")]
			[Cpp2IlInjected.Address(RVA = "0x2DFBBE0", Offset = "0x2DFA5E0", VA = "0x182DFBBE0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB5A0", Offset = "0x2DF9FA0", VA = "0x182DFB5A0", Slot = "25")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C30")]
		[Cpp2IlInjected.Address(RVA = "0x2DFAEA0", Offset = "0x2DF98A0", VA = "0x182DFAEA0", Slot = "26")]
		public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C31")]
		[Cpp2IlInjected.Address(RVA = "0x2DFAC90", Offset = "0x2DF9690", VA = "0x182DFAC90", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x2DFAE40", Offset = "0x2DF9840", VA = "0x182DFAE40")]
		private void EDNJKLANNHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBD90", Offset = "0x2DFA790", VA = "0x182DFBD90")]
		private void NFLKBPIGJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x2DFAAD0", Offset = "0x2DF94D0", VA = "0x182DFAAD0")]
		private void DACDLPBGPMI(Entity GOANOLJBHPF, JBNNELNIDOD ILFNNAAOJHE, DHBMIEMIIHO HKLCHIBFNAM, DHBMIEMIIHO APGCALANEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBC80", Offset = "0x2DFA680", VA = "0x182DFBC80")]
		private void MDICBGFIHFN(Entity GOANOLJBHPF, JBNNELNIDOD ILFNNAAOJHE, DHBMIEMIIHO HKLCHIBFNAM, DHBMIEMIIHO APGCALANEIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x19EC320", Offset = "0x19EAD20", VA = "0x1819EC320", Slot = "14")]
		public DFKOJFHJBPL NMFLIPCIPEC(DFKOJFHJBPL PMMCMCPNCLD, int CDMHHELDENI)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x14E8CE0", Offset = "0x14E76E0", VA = "0x1814E8CE0", Slot = "15")]
		public Color LMHLENJAFLI(DFKOJFHJBPL PMMCMCPNCLD, int CDMHHELDENI)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC1D0", Offset = "0x2DFABD0", VA = "0x182DFC1D0", Slot = "16")]
		public float3 OCCFDHJKJGK(DFKOJFHJBPL PMMCMCPNCLD, int CDMHHELDENI)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBCE0", Offset = "0x2DFA6E0", VA = "0x182DFBCE0", Slot = "17")]
		public bool MGMJBECAIEC(DFKOJFHJBPL PMMCMCPNCLD, DFKOJFHJBPL BPIPBLPIHDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBA90", Offset = "0x2DFA490", VA = "0x182DFBA90", Slot = "18")]
		public DFKOJFHJBPL LKOJBNOAMID(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC080", Offset = "0x2DFAA80", VA = "0x182DFC080", Slot = "21")]
		public void OBOCFKLPPGD(DFKOJFHJBPL PMMCMCPNCLD, Vector3 LNCOLOGFNJN, Quaternion DBMPKDBKHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBB40", Offset = "0x2DFA540", VA = "0x182DFBB40", Slot = "23")]
		public float3 LOCKKGIHGAE(NNINMABELDO MMKMHECDHFO)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB340", Offset = "0x2DF9D40", VA = "0x182DFB340", Slot = "24")]
		public quaternion GAFGHHFJLEA(NNINMABELDO MMKMHECDHFO)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB7C0", Offset = "0x2DFA1C0", VA = "0x182DFB7C0", Slot = "28")]
		public RigidTransform HIPNAJKPDKA(NNINMABELDO MMKMHECDHFO)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x2DFBF00", Offset = "0x2DFA900", VA = "0x182DFBF00", Slot = "22")]
		public bool NLOCCADHLLD(DFKOJFHJBPL PMMCMCPNCLD, out RigidTransform GEHMBECKLCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB960", Offset = "0x2DFA360", VA = "0x182DFB960", Slot = "19")]
		[IteratorStateMachine(typeof(OJCFLFDCDAE))]
		public IEnumerable<DFKOJFHJBPL> IIIIKGEJAOB(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA710", Offset = "0x2DF9110", VA = "0x182DFA710", Slot = "20")]
		public DFKOJFHJBPL CEBAMPKELFM(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB3D0", Offset = "0x2DF9DD0", VA = "0x182DFB3D0", Slot = "29")]
		public void GAJHGLHBPNP(ref List<DFKOJFHJBPL> BHEOHMIBBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x2DFA870", Offset = "0x2DF9270", VA = "0x182DFA870")]
		private Entity CEBAMPKELFM(Entity GOANOLJBHPF)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x2DFC580", Offset = "0x2DFAF80", VA = "0x182DFC580")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Prefabs)]
	[DNOPHNKOHLA(typeof(ObjectInstantiationService), new string[] { })]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	internal sealed class ObjectInstantiationService : MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN HDJFKDANOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		[JIFPDEDMPGC]
		private MDCFPDNJKAF ONPCCIDBKJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		[JIFPDEDMPGC]
		private DPFLLDDDCBH DOIIJCNKJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		[JIFPDEDMPGC]
		private ObjectNetworkToLocalMapService KGCOHGMEJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		[JIFPDEDMPGC]
		private ObjectLifecycleService JFLLPKLIMED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		[JIFPDEDMPGC]
		private ObjectPrefabs HPAFIPNLAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[JIFPDEDMPGC]
		private EEKEFMOLEBM BOMHONMIMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private DBDNMBFJLEK GEODCBKPIGD;

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		public int OGEHKGEKLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000C50")]
			[Cpp2IlInjected.Address(RVA = "0x2AF23A0", Offset = "0x2AF0DA0", VA = "0x182AF23A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2220", Offset = "0x2AF0C20", VA = "0x182AF2220", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2170", Offset = "0x2AF0B70", VA = "0x182AF2170")]
		public Entity EMPCNAPPLAH(AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x2AF24E0", Offset = "0x2AF0EE0", VA = "0x182AF24E0")]
		public Entity NELDJHBEBDP(AKLFKNOOHJC AOCEENCOLMM, AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1F60", Offset = "0x2AF0960", VA = "0x182AF1F60")]
		public Entity LNCOMHGPOAE(AOIKBHJMDBO GDAJCNKPBDC, bool PCDCBPLMECK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x2AF20D0", Offset = "0x2AF0AD0", VA = "0x182AF20D0")]
		public Entity LNCOMHGPOAE(AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x2AF24A0", Offset = "0x2AF0EA0", VA = "0x182AF24A0")]
		public Entity LIJHNKECALI()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2190", Offset = "0x2AF0B90", VA = "0x182AF2190")]
		public Entity FEKOEOBMBGE(MGHIFAKDBDN MAHAMGBPDNB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2540", Offset = "0x2AF0F40", VA = "0x182AF2540")]
		public Entity NILOJCEIBHN(HFJJNJCDHGL MAHAMGBPDNB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2350", Offset = "0x2AF0D50", VA = "0x182AF2350")]
		public NativeArray<(DFKOJFHJBPL, DFKOJFHJBPL)> GKODLOMCAKJ(NativeArray<DFKOJFHJBPL> NNPEDNPMEIC, Allocator GGPAKDMJHLJ)
		{
			return default(NativeArray<(DFKOJFHJBPL, DFKOJFHJBPL)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2450", Offset = "0x2AF0E50", VA = "0x182AF2450")]
		public IEnumerable<AOIKBHJMDBO> KLELAJFLFEI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF2110", Offset = "0x2AF0B10", VA = "0x182AF2110")]
		public EntityArchetype DHCHHNALECL(AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5C")]
		[Cpp2IlInjected.Address(RVA = "0x2AF23F0", Offset = "0x2AF0DF0", VA = "0x182AF23F0")]
		public Entity KBACFGPJNJM(AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5D")]
		[Cpp2IlInjected.Address(RVA = "0x2AF20D0", Offset = "0x2AF0AD0", VA = "0x182AF20D0")]
		private Entity BBMNFKCDFEA(AOIKBHJMDBO GDAJCNKPBDC)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1F60", Offset = "0x2AF0960", VA = "0x182AF1F60")]
		private Entity BBMNFKCDFEA(AOIKBHJMDBO GDAJCNKPBDC, bool PCDCBPLMECK)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x2AF1FB0", Offset = "0x2AF09B0", VA = "0x182AF1FB0")]
		private Entity BBMNFKCDFEA(AOIKBHJMDBO GDAJCNKPBDC, AKLFKNOOHJC AOCEENCOLMM)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ObjectInstantiationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	[DNOPHNKOHLA(typeof(FEKPIDGPAOL), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	public sealed class PhysicsSceneColliderService : FEKPIDGPAOL, HJNCNJMLHIG, IPCGJDFHGJG, MMKNGEFLOAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private const string JHOIPIFDJMO = "OMPhysicsScene";

		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private const int IKEPCCABOLF = -1;

		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private const int KLGDJOFOHCO = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		[JIFPDEDMPGC]
		private GCELLPHAFPH JAINECODPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private Collider[] NGIELIJGKBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private RaycastHit[] EDAMKFLHBPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private global::PJDAAKMMIMP<DNIHOJPPGJK, BoxCollider> PKGEOFGCKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private Scene BBIKMOACHCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private PhysicsScene AKLNHHEOCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private GameObject JFEEEILBEOO;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		public int HBDHEBAOIFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000C65")]
			[Cpp2IlInjected.Address(RVA = "0x2AFE0D0", Offset = "0x2AFCAD0", VA = "0x182AFE0D0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD090", Offset = "0x2AFBA90", VA = "0x182AFD090", Slot = "9")]
		public void BEJHKBIOAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDAE0", Offset = "0x2AFC4E0", VA = "0x182AFDAE0", Slot = "10")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD6A0", Offset = "0x2AFC0A0", VA = "0x182AFD6A0", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD430", Offset = "0x2AFBE30", VA = "0x182AFD430", Slot = "4")]
		public DNIHOJPPGJK DBDGKDHDKEP(Entity GOANOLJBHPF)
		{
			return default(DNIHOJPPGJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0x2AFCE80", Offset = "0x2AFB880", VA = "0x182AFCE80", Slot = "5")]
		public void ACPFDPGIMEH(NativeArray<DNIHOJPPGJK> ODGNPDGECIO, NativeArray<IDMLAGGFJCC> NFOBGIKPBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE110", Offset = "0x2AFCB10", VA = "0x182AFE110", Slot = "6")]
		public void OIOIAPODBNB(DNIHOJPPGJK BIONDBIGACN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C69")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDBA0", Offset = "0x2AFC5A0", VA = "0x182AFDBA0", Slot = "7")]
		public bool HEKMCKKNMIP(DNIHOJPPGJK BIONDBIGACN, out Collider FGPOCJNLNLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD7D0", Offset = "0x2AFC1D0", VA = "0x182AFD7D0")]
		public bool GAOOJLNOKIK(in float3 DKLFBNALGBC, in float3 PANBGKEJNBF, float OEPBPFIFMKK, Allocator GGPAKDMJHLJ, out NativeArray<Entity> CGCCIONMJJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDC40", Offset = "0x2AFC640", VA = "0x182AFDC40")]
		private void HIHECBAEKFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6C")]
		[Cpp2IlInjected.Address(RVA = "0xBFB600", Offset = "0xBFA000", VA = "0x180BFB600")]
		private void FIMGGLAEFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6D")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE080", Offset = "0x2AFCA80", VA = "0x182AFE080")]
		private void MCBIDNLKLLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x9650C0", Offset = "0x963AC0", VA = "0x1809650C0")]
		private void NHHBCFBKMAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD580", Offset = "0x2AFBF80", VA = "0x182AFD580")]
		private BoxCollider DEDHDENGFPC(Entity GOANOLJBHPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDFF0", Offset = "0x2AFC9F0", VA = "0x182AFDFF0")]
		private void LHLIIFPOPEF(BoxCollider FIEGMLNKEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C71")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDC90", Offset = "0x2AFC690", VA = "0x182AFDC90")]
		[Conditional("UNITY_EDITOR")]
		private void IFMAOJMEPMK(GameObject KEHOIMKGHCH, Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD200", Offset = "0x2AFBC00", VA = "0x182AFD200")]
		private void CAICBHKHAGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDEE0", Offset = "0x2AFC8E0", VA = "0x182AFDEE0")]
		private void KPEGNDOKJBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x2AFDCD0", Offset = "0x2AFC6D0", VA = "0x182AFDCD0")]
		private void KEDBPNMJMAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD7A0", Offset = "0x2AFC1A0", VA = "0x182AFD7A0")]
		private void FIAANNMAJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE1E0", Offset = "0x2AFCBE0", VA = "0x182AFE1E0")]
		private void PFFEGDIHDFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x2AFD3F0", Offset = "0x2AFBDF0", VA = "0x182AFD3F0")]
		private void CCGIHAIDKOA(Scene IADBHEOJMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public PhysicsSceneColliderService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE070", Offset = "0x2AFCA70", VA = "0x182AFE070", Slot = "8")]
		private bool LNDHKGBLIKP(in float3 DKLFBNALGBC, in float3 PANBGKEJNBF, float OEPBPFIFMKK, Allocator GGPAKDMJHLJ, out NativeArray<Entity> CGCCIONMJJA)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
[DNOPHNKOHLA(typeof(HIOHMPHFJEM), new string[] { })]
public sealed class PKJJEHPFBCA : HIOHMPHFJEM, MMKNGEFLOAO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	private struct MDKKBJPELHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public float IOFOPGHCAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public uint EJBEKBOMHMF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005AD")]
	private HJNCNJMLHIG EOOJJCPFKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005AE")]
	private ACDGEFNBFLP IHJBCJCOAJO;

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x2AFBAB0", Offset = "0x2AFA4B0", VA = "0x182AFBAB0", Slot = "5")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB630", Offset = "0x2AFA030", VA = "0x182AFB630")]
	public bool GAOOJLNOKIK(in float3 DKLFBNALGBC, in float3 PANBGKEJNBF, float OEPBPFIFMKK, out PEGPNOJBJNL LLAEOCBHPAM, out Entity BACOHNNEACN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB530", Offset = "0x2AF9F30", VA = "0x182AFB530")]
	public static bool FFAIJBIHANL(in Span<PEGPNOJBJNL> BAJPDMLILOC, float OEPBPFIFMKK, out int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB500", Offset = "0x2AF9F00", VA = "0x182AFB500")]
	public static float BKFLPBMMMHB(float IOFOPGHCAAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public PKJJEHPFBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x2AFBB20", Offset = "0x2AFA520", VA = "0x182AFBB20", Slot = "4")]
	private bool NPOBNALKGEF(in float3 DKLFBNALGBC, in float3 PANBGKEJNBF, float OEPBPFIFMKK, out PEGPNOJBJNL LLAEOCBHPAM, out Entity BACOHNNEACN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
[DNOPHNKOHLA(typeof(ACDGEFNBFLP), new string[] { })]
public sealed class HFNLJBLJGBD : ACDGEFNBFLP, MMKNGEFLOAO
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[BurstCompile]
	private struct HMMPBEHFJPA : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[ReadOnly]
		public NativeArray<Entity> CGCCIONMJJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[ReadOnly]
		public float3 ILFLEAHDIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[ReadOnly]
		public float3 BNCGHDEDHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> GFOPFIPAMHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> ILKGKPFKPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> OHKKFDMMHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointPositionData> IOMKNBDHCKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointScaleData> KNAFIIIOCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		[WriteOnly]
		public NativeArray<PEGPNOJBJNL> JOFKBLOJLOF;

		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private static readonly PEGPNOJBJNL DPIDKDGJHDK;

		[Cpp2IlInjected.Token(Token = "0x6000C85")]
		[Cpp2IlInjected.Address(RVA = "0x3FF31D0", Offset = "0x3FF1BD0", VA = "0x183FF31D0", Slot = "4")]
		public void Execute(int GFDMFLGCBKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C86")]
		[Cpp2IlInjected.Address(RVA = "0x3FF34B0", Offset = "0x3FF1EB0", VA = "0x183FF34B0")]
		private static float3 GFGJJPDNFEF(in float4x4 OABFCHODFMC, in float3 LHIIFNPNDIA)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C87")]
		[Cpp2IlInjected.Address(RVA = "0x3FF41C0", Offset = "0x3FF2BC0", VA = "0x183FF41C0")]
		private static float3 PGMOHKOGHAP(in float4x4 OABFCHODFMC, in float3 FLLMGCJHMCP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C88")]
		[Cpp2IlInjected.Address(RVA = "0x3FF30D0", Offset = "0x3FF1AD0", VA = "0x183FF30D0")]
		private static float3 AAILFILNNIC(in float4x4 OABFCHODFMC, in float3 LHIIFNPNDIA)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C89")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3580", Offset = "0x3FF1F80", VA = "0x183FF3580")]
		private static float3 HBACAAMMDBK(in float4x4 OABFCHODFMC, in float3 FLLMGCJHMCP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8A")]
		[Cpp2IlInjected.Address(RVA = "0x3FF3E70", Offset = "0x3FF2870", VA = "0x183FF3E70")]
		private bool NEOEEFPFCCI(in float3 DKLFBNALGBC, in float3 PANBGKEJNBF, in NativeArray<Entity> MEAPGLKPHNG, out float3 LLAEOCBHPAM, out float3 PIELFIAEDGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C8B")]
		[Cpp2IlInjected.Address(RVA = "0x3FF37A0", Offset = "0x3FF21A0", VA = "0x183FF37A0")]
		public static bool MFPMNEDOEKH(in float3 EMLEPDEKKKG, in float3 LJHEELNKGBF, in float3 EKHMAPLBLAI, in float3 JLHIMNGHLBE, float GKOINLPAEMD, float FNGKGEMFFOG, out float KNGDLMLNDII, out float3 DMOPMBKFMFH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EntityManager BJMEFCCEPHI;

	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x2C1ED80", Offset = "0x2C1D780", VA = "0x182C1ED80", Slot = "5")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x2C1E8A0", Offset = "0x2C1D2A0", VA = "0x182C1E8A0")]
	public void GAOOJLNOKIK(in NativeArray<Entity> CGCCIONMJJA, in float3 DKLFBNALGBC, in float3 PANBGKEJNBF, in NativeArray<PEGPNOJBJNL> EHJEDFKHHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HFNLJBLJGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x2C1E890", Offset = "0x2C1D290", VA = "0x182C1E890", Slot = "4")]
	private void DFLFGHGGCNC(in NativeArray<Entity> CGCCIONMJJA, in float3 DKLFBNALGBC, in float3 PANBGKEJNBF, in NativeArray<PEGPNOJBJNL> EHJEDFKHHBG)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CB")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Embodiment)]
	[AINPJLGDEKF(EIJAKMAIFNG.OMRoom)]
	[DNOPHNKOHLA(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	internal sealed class ObjectNetworkToLocalMapService : MMKNGEFLOAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		[JIFPDEDMPGC]
		private DEAGKEFEBKN ALIKEONHNHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		[JIFPDEDMPGC]
		private MDCFPDNJKAF GHIOENLNNDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		[JIFPDEDMPGC]
		private DPFLLDDDCBH BEFFBDHDDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private HGFGJIKNIPL CPFOJDHADNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private NativeHashMap<AKLFKNOOHJC, Entity> IJJAGGNCFEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private EntityManager BJMEFCCEPHI;

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		internal NativeHashMap<AKLFKNOOHJC, Entity> NLCACLBNECB
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8D")]
			[Cpp2IlInjected.Address(RVA = "0xEA70B0", Offset = "0xEA5AB0", VA = "0x180EA70B0")]
			get
			{
				return default(NativeHashMap<AKLFKNOOHJC, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		internal uint MPLFPKJBDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8E")]
			[Cpp2IlInjected.Address(RVA = "0x2AF5820", Offset = "0x2AF4220", VA = "0x182AF5820")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public bool JDCINNHHEGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000C8F")]
			[Cpp2IlInjected.Address(RVA = "0x8C1DE0", Offset = "0x8C07E0", VA = "0x1808C1DE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C90")]
			[Cpp2IlInjected.Address(RVA = "0xD09290", Offset = "0xD07C90", VA = "0x180D09290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C91")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5700", Offset = "0x2AF4100", VA = "0x182AF5700", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C92")]
		[Cpp2IlInjected.Address(RVA = "0x2AF55C0", Offset = "0x2AF3FC0", VA = "0x182AF55C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C93")]
		[Cpp2IlInjected.Address(RVA = "0x2AF58E0", Offset = "0x2AF42E0", VA = "0x182AF58E0")]
		public void NMFIICNHENP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C94")]
		[Cpp2IlInjected.Address(RVA = "0x2AF59F0", Offset = "0x2AF43F0", VA = "0x182AF59F0")]
		public void PHNAJAFOGNL(AKLFKNOOHJC AOCEENCOLMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C95")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5850", Offset = "0x2AF4250", VA = "0x182AF5850")]
		private DFKOJFHJBPL IIGKKDDMFJO(Entity GOANOLJBHPF)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C96")]
		[Cpp2IlInjected.Address(RVA = "0x2AF54E0", Offset = "0x2AF3EE0", VA = "0x182AF54E0")]
		public DFKOJFHJBPL DHDNGOHCFIF(AKLFKNOOHJC AOCEENCOLMM)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5960", Offset = "0x2AF4360", VA = "0x182AF5960")]
		public AKLFKNOOHJC OOMNOMGKKMO(DFKOJFHJBPL PMMCMCPNCLD)
		{
			return default(AKLFKNOOHJC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5450", Offset = "0x2AF3E50", VA = "0x182AF5450")]
		public void AIKHJKHEOPM(Entity GOANOLJBHPF, AKLFKNOOHJC AOCEENCOLMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5880", Offset = "0x2AF4280", VA = "0x182AF5880")]
		public void LPOMGMHABEO(Entity GOANOLJBHPF, AKLFKNOOHJC AOCEENCOLMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x2AF53F0", Offset = "0x2AF3DF0", VA = "0x182AF53F0")]
		public void AHBHNCEMAMN(Entity GOANOLJBHPF, AKLFKNOOHJC AOCEENCOLMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x2AF5630", Offset = "0x2AF4030", VA = "0x182AF5630")]
		public void GAKOKLFEOBI(Entity GOANOLJBHPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CC")]
	[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
	[DNOPHNKOHLA(typeof(PropertyEventCallbacksService), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.Callbacks)]
	public class PropertyEventCallbacksService : MMKNGEFLOAO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x20001CD")]
		private struct PHCHPNDLKHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			public KEKDAIEAPLN JOIALDGLEAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CB")]
			public Type MAHAMGBPDNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005CC")]
			public int HGBOOPNCHBL;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		private struct GOMHBCEMCHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public PHCHPNDLKHC[] PDPOLFACNJC;
		}

		[Cpp2IlInjected.Token(Token = "0x20001CF")]
		public delegate void KEKDAIEAPLN(Entity GOANOLJBHPF, JBNNELNIDOD ILFNNAAOJHE, DHBMIEMIIHO HKLCHIBFNAM, DHBMIEMIIHO APGCALANEIN);

		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private readonly Dictionary<JBNNELNIDOD, KEKDAIEAPLN> DGOOINKOEAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private readonly Dictionary<int, GOMHBCEMCHN> IACJKKHLKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private BPDJHFAPEAG PDPOLFACNJC;

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action NCGBGMDLGME
		{
			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0x2B04820", Offset = "0x2B03220", VA = "0x182B04820")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000C9F")]
			[Cpp2IlInjected.Address(RVA = "0x2B03D40", Offset = "0x2B02740", VA = "0x182B03D40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action BACEPGPPKKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000CA0")]
			[Cpp2IlInjected.Address(RVA = "0x2B04B40", Offset = "0x2B03540", VA = "0x182B04B40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000CA1")]
			[Cpp2IlInjected.Address(RVA = "0x2B044F0", Offset = "0x2B02EF0", VA = "0x182B044F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x2B03DE0", Offset = "0x2B027E0", VA = "0x182B03DE0", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x2B03BC0", Offset = "0x2B025C0", VA = "0x182B03BC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x2B04BE0", Offset = "0x2B035E0", VA = "0x182B04BE0")]
		public void OGMDKKEHOIN(JBNNELNIDOD ILFNNAAOJHE, KEKDAIEAPLN JOIALDGLEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x2B03AD0", Offset = "0x2B024D0", VA = "0x182B03AD0")]
		public void DDIDMMIANOF(JBNNELNIDOD ILFNNAAOJHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x2B04590", Offset = "0x2B02F90", VA = "0x182B04590")]
		internal void LHCKNHOLEDK(NEBKGLHCLEJ MKPFHFLNAEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x2B03E30", Offset = "0x2B02830", VA = "0x182B03E30")]
		private void HFOLDAHKLNI(NEBKGLHCLEJ MKPFHFLNAEL, int MDNDIFHMDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x2B048C0", Offset = "0x2B032C0", VA = "0x182B048C0")]
		private void ODCHJNDGPIK(FBPCPDKHEOJ ALMPKNLFFLI, GFMIPKBGENN JDBJPCNMDLB, PHCHPNDLKHC NCPPKIJJHCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA9")]
		[Cpp2IlInjected.Address(RVA = "0x2B04370", Offset = "0x2B02D70", VA = "0x182B04370")]
		private GOMHBCEMCHN HHJAGOKAOON(FBPCPDKHEOJ ALMPKNLFFLI, GFMIPKBGENN JDBJPCNMDLB)
		{
			return default(GOMHBCEMCHN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x2B03C50", Offset = "0x2B02650", VA = "0x182B03C50")]
		private PHCHPNDLKHC FJEDMMDPEJN(GOMHBCEMCHN KHEIMOEOLED, FBPCPDKHEOJ ALMPKNLFFLI, GFMIPKBGENN JDBJPCNMDLB)
		{
			return default(PHCHPNDLKHC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x2B04DA0", Offset = "0x2B037A0", VA = "0x182B04DA0")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[DNOPHNKOHLA(typeof(JFFIFAIOBGL), new string[] { })]
public class MJDPDFFNPAL : MMKNGEFLOAO, PKBAIAJJFPF, JFFIFAIOBGL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[CompilerGenerated]
	private sealed class AOMEDFIJENB : IEnumerable<DFKOJFHJBPL>, IEnumerable, IEnumerator<DFKOJFHJBPL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private DFKOJFHJBPL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public MJDPDFFNPAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private DFKOJFHJBPL splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public DFKOJFHJBPL <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		private DFKOJFHJBPL System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CC8")]
			[Cpp2IlInjected.Address(RVA = "0x6E2040", Offset = "0x6E0A40", VA = "0x1806E2040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(DFKOJFHJBPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000CCA")]
			[Cpp2IlInjected.Address(RVA = "0x3FEF1B0", Offset = "0x3FEDBB0", VA = "0x183FEF1B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC5")]
		[Cpp2IlInjected.Address(RVA = "0x968EC0", Offset = "0x9678C0", VA = "0x180968EC0")]
		[DebuggerHidden]
		public AOMEDFIJENB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC6")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC7")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF000", Offset = "0x3FEDA00", VA = "0x183FEF000", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CC9")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF170", Offset = "0x3FEDB70", VA = "0x183FEF170", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCB")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF0C0", Offset = "0x3FEDAC0", VA = "0x183FEF0C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<DFKOJFHJBPL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CCC")]
		[Cpp2IlInjected.Address(RVA = "0x3FEF0C0", Offset = "0x3FEDAC0", VA = "0x183FEF0C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005CE")]
	private DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005CF")]
	private HGFGJIKNIPL CPFOJDHADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D0")]
	private NLLKAFDHJLK KOBFGPINJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005D1")]
	private ObjectInstantiationService HPAFIPNLAIL;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EntityManager FLHDGCEBOEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB1")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7640", Offset = "0x2AE6040", VA = "0x182AE7640")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private JEHPLMMOFBJ MLKKJKMLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB2")]
		[Cpp2IlInjected.Address(RVA = "0x2AE7970", Offset = "0x2AE6370", VA = "0x182AE7970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB3")]
	[Cpp2IlInjected.Address(RVA = "0x2AE75B0", Offset = "0x2AE5FB0", VA = "0x182AE75B0", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB4")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7190", Offset = "0x2AE5B90", VA = "0x182AE7190", Slot = "5")]
	public void FDINHLIKDIM(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB5")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7020", Offset = "0x2AE5A20", VA = "0x182AE7020", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB6")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6C50", Offset = "0x2AE5650", VA = "0x182AE6C50")]
	private void BHGMAFLJOMO(Entity CLGDGGHOANC, in DHBMIEMIIHO FAAGLIPDKEL, in DHBMIEMIIHO ONFBDMEKEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x2AE78F0", Offset = "0x2AE62F0", VA = "0x182AE78F0", Slot = "14")]
	public DFKOJFHJBPL LIJHNKECALI()
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x2AE69F0", Offset = "0x2AE53F0", VA = "0x182AE69F0", Slot = "10")]
	public void ANDAHFJEMDI(DFKOJFHJBPL PMMCMCPNCLD, MJPONBKEEHJ HKHEDELGBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB9")]
	[Cpp2IlInjected.Address(RVA = "0x2AE70D0", Offset = "0x2AE5AD0", VA = "0x182AE70D0", Slot = "9")]
	public MJPONBKEEHJ EAMFJKAEEGI(DFKOJFHJBPL PMMCMCPNCLD)
	{
		return default(MJPONBKEEHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBA")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7290", Offset = "0x2AE5C90", VA = "0x182AE7290", Slot = "11")]
	public DFKOJFHJBPL GBCKOCKIAIL(DFKOJFHJBPL MONEONMODDL, [Optional] Vector3? OAALNDIAAOB, [Optional] Quaternion? HOOCPOKGFMC, [Optional] Vector3? HKGHFAPJIOG)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBB")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7690", Offset = "0x2AE6090", VA = "0x182AE7690", Slot = "15")]
	public DFKOJFHJBPL HLKCLCGLEBI(DFKOJFHJBPL EAPAIPCDGJI, int GFDMFLGCBKB, [Optional] Vector3? OAALNDIAAOB, [Optional] Quaternion? HOOCPOKGFMC, [Optional] Vector3? HKGHFAPJIOG)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBC")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7800", Offset = "0x2AE6200", VA = "0x182AE7800", Slot = "7")]
	public DFKOJFHJBPL KBEKEOPFACM(DFKOJFHJBPL EAPAIPCDGJI, int GFDMFLGCBKB)
	{
		return default(DFKOJFHJBPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBD")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7A30", Offset = "0x2AE6430", VA = "0x182AE7A30", Slot = "16")]
	public void PMKDKBFPIFA(DFKOJFHJBPL EAPAIPCDGJI, DFKOJFHJBPL EJLMJOEHKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBE")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7AF0", Offset = "0x2AE64F0", VA = "0x182AE7AF0", Slot = "12")]
	public void PPILEPIHBDK(DFKOJFHJBPL EAPAIPCDGJI, int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CBF")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6AB0", Offset = "0x2AE54B0", VA = "0x182AE6AB0", Slot = "17")]
	public void BCPKMLGIDEJ(DFKOJFHJBPL EAPAIPCDGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC0")]
	[Cpp2IlInjected.Address(RVA = "0x2AE76D0", Offset = "0x2AE60D0", VA = "0x182AE76D0", Slot = "8")]
	public int HMPAHAOLOJL(DFKOJFHJBPL EAPAIPCDGJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC1")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7770", Offset = "0x2AE6170", VA = "0x182AE7770", Slot = "6")]
	[IteratorStateMachine(typeof(AOMEDFIJENB))]
	public IEnumerable<DFKOJFHJBPL> KBCPHGKJLGB(DFKOJFHJBPL EAPAIPCDGJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC2")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6ED0", Offset = "0x2AE58D0", VA = "0x182AE6ED0")]
	private bool BODDMAJNOOA(DFKOJFHJBPL EAPAIPCDGJI, out NativeArray<Entity> PFGJBHEKNMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC3")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6F60", Offset = "0x2AE5960", VA = "0x182AE6F60")]
	private NativeArray<Entity> CFABPKPKLLP(DFKOJFHJBPL EAPAIPCDGJI)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CC4")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public MJDPDFFNPAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[AINPJLGDEKF(EIJAKMAIFNG.LoadInstance)]
[DNOPHNKOHLA(typeof(FOOJHGAINEN), new string[] { })]
internal sealed class FOOJHGAINEN : MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private DEAGKEFEBKN HDJFKDANOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private TransformOwnershipPhase PMJLEAGPJNB;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	private EAPDPHILGKF CIFPLKLELPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CCD")]
		[Cpp2IlInjected.Address(RVA = "0x2C19FC0", Offset = "0x2C189C0", VA = "0x182C19FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCE")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A010", Offset = "0x2C18A10", VA = "0x182C1A010", Slot = "4")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CCF")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A090", Offset = "0x2C18A90", VA = "0x182C1A090")]
	public void MBNIELEONJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD0")]
	[Cpp2IlInjected.Address(RVA = "0x2C19CF0", Offset = "0x2C186F0", VA = "0x182C19CF0")]
	public void DMLMABGFLFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD1")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public FOOJHGAINEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public readonly struct EDPGDBLKBOA : IEquatable<EDPGDBLKBOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private readonly int MDNDIFHMDOM;

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public Type LMEMDFLMCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000CD3")]
		[Cpp2IlInjected.Address(RVA = "0x2E057E0", Offset = "0x2E041E0", VA = "0x182E057E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD2")]
	[Cpp2IlInjected.Address(RVA = "0x2E058C0", Offset = "0x2E042C0", VA = "0x182E058C0")]
	public EDPGDBLKBOA(Type MAHAMGBPDNB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD4")]
	[Cpp2IlInjected.Address(RVA = "0x2E05700", Offset = "0x2E04100", VA = "0x182E05700")]
	public static EDPGDBLKBOA EGMKMIPNLBF(Type MAHAMGBPDNB)
	{
		return default(EDPGDBLKBOA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD5")]
	[Cpp2IlInjected.Address(RVA = "0x2E056B0", Offset = "0x2E040B0", VA = "0x182E056B0")]
	public static Type EGMKMIPNLBF(EDPGDBLKBOA BIONDBIGACN)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD6")]
	[Cpp2IlInjected.Address(RVA = "0x13CB770", Offset = "0x13CA170", VA = "0x1813CB770")]
	public static bool NENBKMMGKMN(EDPGDBLKBOA PKEMCIANHMO, EDPGDBLKBOA DLAMIJMLOOE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000CD7")]
	[Cpp2IlInjected.Address(RVA = "0x13CB770", Offset = "0x13CA170", VA = "0x1813CB770")]
	public static bool HCCIHOFGPHE(EDPGDBLKBOA PKEMCIANHMO, EDPGDBLKBOA DLAMIJMLOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD8")]
	[Cpp2IlInjected.Address(RVA = "0x868560", Offset = "0x866F60", VA = "0x180868560", Slot = "4")]
	public bool Equals(EDPGDBLKBOA DFHJPOKNFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CD9")]
	[Cpp2IlInjected.Address(RVA = "0x2E05760", Offset = "0x2E04160", VA = "0x182E05760", Slot = "0")]
	public override bool Equals(object LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDA")]
	[Cpp2IlInjected.Address(RVA = "0x772E20", Offset = "0x771820", VA = "0x180772E20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDB")]
	[Cpp2IlInjected.Address(RVA = "0x2E05840", Offset = "0x2E04240", VA = "0x182E05840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
public static class PIOGDDMNHCF
{
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private static Dictionary<Type, int> OBNELIIECON;

	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private static List<Type> LIKLEJKJOPE;

	[Cpp2IlInjected.Token(Token = "0x6000CDC")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB390", Offset = "0x2AF9D90", VA = "0x182AFB390")]
	static PIOGDDMNHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDD")]
	[Cpp2IlInjected.Address(RVA = "0x291E790", Offset = "0x291D190", VA = "0x18291E790")]
	public static bool CPLOAHMOJFD<T>()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDE")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB2B0", Offset = "0x2AF9CB0", VA = "0x182AFB2B0")]
	public static bool CPLOAHMOJFD(Type MAHAMGBPDNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CDF")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB140", Offset = "0x2AF9B40", VA = "0x182AFB140")]
	private static bool CPLOAHMOJFD(Type MAHAMGBPDNB, out int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE0")]
	[Cpp2IlInjected.Address(RVA = "0x291E820", Offset = "0x291D220", VA = "0x18291E820")]
	public static int FGPIIJFONFI<T>()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE1")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB320", Offset = "0x2AF9D20", VA = "0x182AFB320")]
	public static int FGPIIJFONFI(Type MAHAMGBPDNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE2")]
	[Cpp2IlInjected.Address(RVA = "0x291E6F0", Offset = "0x291D0F0", VA = "0x18291E6F0")]
	public static bool BHPOPCGLBJN<T>(out int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE3")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAF80", Offset = "0x2AF9980", VA = "0x182AFAF80")]
	public static bool BHPOPCGLBJN(Type MAHAMGBPDNB, out int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE4")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAEE0", Offset = "0x2AF98E0", VA = "0x182AFAEE0")]
	public static Type AGGAFJIIBKL(int GFDMFLGCBKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CE5")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB020", Offset = "0x2AF9A20", VA = "0x182AFB020")]
	public static bool BHPOPCGLBJN(int GFDMFLGCBKB, out Type MAHAMGBPDNB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[DefaultMember("Item")]
public struct CEICKIDCCIM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private T[] NIPBPKPBPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E0")]
	private int KHNOOLPHJPF;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public int GBJCKAFHMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE6")]
		[Cpp2IlInjected.Address(RVA = "0x7E1EE0", Offset = "0x7E08E0", VA = "0x1807E1EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public T NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE7")]
		[Cpp2IlInjected.Address(RVA = "0x25D9220", Offset = "0x25D7C20", VA = "0x1825D9220")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public Span<T> DGJGACJLFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE8")]
		[Cpp2IlInjected.Address(RVA = "0x379A3E0", Offset = "0x3798DE0", VA = "0x18379A3E0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public bool NJLNECGPIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CE9")]
		[Cpp2IlInjected.Address(RVA = "0x8E65F0", Offset = "0x8E4FF0", VA = "0x1808E65F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEA")]
	[Cpp2IlInjected.Address(RVA = "0x379A5F0", Offset = "0x3798FF0", VA = "0x18379A5F0")]
	public CEICKIDCCIM(int KHNOOLPHJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEB")]
	[Cpp2IlInjected.Address(RVA = "0x379A540", Offset = "0x3798F40", VA = "0x18379A540")]
	public int ODPHFPELANF(T MNIAGKNOHEJ, int AGNHLFMCFOJ, int JOBJIONNEHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CEC")]
	[Cpp2IlInjected.Address(RVA = "0x379A480", Offset = "0x3798E80", VA = "0x18379A480", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[DefaultMember("Item")]
public struct CJHBHFICOID<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E1")]
	private global::CEICKIDCCIM<T> NIPBPKPBPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private int KHNOOLPHJPF;

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public T NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CED")]
		[Cpp2IlInjected.Address(RVA = "0x24E1FF0", Offset = "0x24E09F0", VA = "0x1824E1FF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int GBJCKAFHMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000CEE")]
		[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CEF")]
		[Cpp2IlInjected.Address(RVA = "0x24E3260", Offset = "0x24E1C60", VA = "0x1824E3260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int MGGIOFDCCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF0")]
		[Cpp2IlInjected.Address(RVA = "0x24E2C50", Offset = "0x24E1650", VA = "0x1824E2C50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000CF1")]
		[Cpp2IlInjected.Address(RVA = "0x24E3210", Offset = "0x24E1C10", VA = "0x1824E3210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public bool NJLNECGPIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF2")]
		[Cpp2IlInjected.Address(RVA = "0x24E2890", Offset = "0x24E1290", VA = "0x1824E2890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public Span<T> DGJGACJLFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000CF3")]
		[Cpp2IlInjected.Address(RVA = "0x24E1EA0", Offset = "0x24E08A0", VA = "0x1824E1EA0")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF4")]
	[Cpp2IlInjected.Address(RVA = "0x24E3840", Offset = "0x24E2240", VA = "0x1824E3840")]
	public CJHBHFICOID(int KHNOOLPHJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF5")]
	[Cpp2IlInjected.Address(RVA = "0x24E2C00", Offset = "0x24E1600", VA = "0x1824E2C00")]
	public T IDJMDELCOFH(int GFDMFLGCBKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF6")]
	[Cpp2IlInjected.Address(RVA = "0x24E2B30", Offset = "0x24E1530", VA = "0x1824E2B30")]
	public void GLHJGAKFPDE(T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF7")]
	[Cpp2IlInjected.Address(RVA = "0x24E2F40", Offset = "0x24E1940", VA = "0x1824E2F40")]
	public void LAGAODNLFJA(Span<T> OKDFPKLCDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF8")]
	[Cpp2IlInjected.Address(RVA = "0x24E26C0", Offset = "0x24E10C0", VA = "0x1824E26C0")]
	public void CPLOAHMOJFD(T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CF9")]
	[Cpp2IlInjected.Address(RVA = "0x24E2DC0", Offset = "0x24E17C0", VA = "0x1824E2DC0")]
	private void JOFDONMLBKP(int ADCMDGEMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFA")]
	[Cpp2IlInjected.Address(RVA = "0x24E2280", Offset = "0x24E0C80", VA = "0x1824E2280")]
	public void BIFBNKEJGFP(Span<T> KPKJFELPMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFB")]
	[Cpp2IlInjected.Address(RVA = "0x24E3340", Offset = "0x24E1D40", VA = "0x1824E3340")]
	public void ONIJIJJBDOI(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFC")]
	[Cpp2IlInjected.Address(RVA = "0x24E35B0", Offset = "0x24E1FB0", VA = "0x1824E35B0")]
	public void PEOLHCMKLNA(int BAJCHMIIBKP, int PGDLDMBJJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFD")]
	[Cpp2IlInjected.Address(RVA = "0x24E2BA0", Offset = "0x24E15A0", VA = "0x1824E2BA0")]
	public void GNBOGKPOKGD(int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFE")]
	[Cpp2IlInjected.Address(RVA = "0x24E33A0", Offset = "0x24E1DA0", VA = "0x1824E33A0")]
	public void PBAPJAMMOGE(int BAJCHMIIBKP, int PGDLDMBJJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CFF")]
	[Cpp2IlInjected.Address(RVA = "0x24E2930", Offset = "0x24E1330", VA = "0x1824E2930")]
	public void GHOIIFOGFPK(int ADCMDGEMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D00")]
	[Cpp2IlInjected.Address(RVA = "0x24E21C0", Offset = "0x24E0BC0", VA = "0x1824E21C0")]
	public void BHEIOMENMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D01")]
	[Cpp2IlInjected.Address(RVA = "0x24E32B0", Offset = "0x24E1CB0", VA = "0x1824E32B0")]
	public int ODPHFPELANF(T MNIAGKNOHEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D02")]
	[Cpp2IlInjected.Address(RVA = "0x24E28D0", Offset = "0x24E12D0", VA = "0x1824E28D0")]
	public bool GGIBFCBBJNK(T MNIAGKNOHEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D03")]
	[Cpp2IlInjected.Address(RVA = "0x24E27D0", Offset = "0x24E11D0", VA = "0x1824E27D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D04")]
	[Cpp2IlInjected.Address(RVA = "0x24E37D0", Offset = "0x24E21D0", VA = "0x1824E37D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D05")]
	[Cpp2IlInjected.Address(RVA = "0x24E2820", Offset = "0x24E1220", VA = "0x1824E2820")]
	public static Span<T> EGMKMIPNLBF(global::CJHBHFICOID<T> OKDFPKLCDDM)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D06")]
	[Cpp2IlInjected.Address(RVA = "0x24E2080", Offset = "0x24E0A80", VA = "0x1824E2080")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void BHBPHHHLNBO(int MNIAGKNOHEJ, int KHNOOLPHJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D07")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void LFJIOPPFDIF(int KHNOOLPHJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D08")]
	[Cpp2IlInjected.Address(RVA = "0x24E30B0", Offset = "0x24E1AB0", VA = "0x1824E30B0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void LFJIOPPFDIF(int KHNOOLPHJPF, int GFDMFLGCBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D09")]
	[Cpp2IlInjected.Address(RVA = "0x24E29F0", Offset = "0x24E13F0", VA = "0x1824E29F0")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void GLCGKDFFOLA(int MNIAGKNOHEJ, int KHNOOLPHJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0A")]
	[Cpp2IlInjected.Address(RVA = "0x24E24C0", Offset = "0x24E0EC0", VA = "0x1824E24C0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	private void CJMGODGPKNG(int BAJCHMIIBKP, int PGDLDMBJJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0B")]
	[Cpp2IlInjected.Address(RVA = "0x24E2C80", Offset = "0x24E1680", VA = "0x1824E2C80")]
	[Conditional("ENABLE_ECS_SAFETY_CHECKS")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void JBOHNEGOIMI(int MNIAGKNOHEJ, int KHNOOLPHJPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
public struct BCPGIKNGDDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private const int DLGBIEIILCA = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private NativeList<Entity> CGCCIONMJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private TransformAccessArray CAJCDELKPBE;

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0D")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0EE0", Offset = "0x2DEF8E0", VA = "0x182DF0EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public NativeList<Entity> JHLGFCFCAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0E")]
		[Cpp2IlInjected.Address(RVA = "0xC29900", Offset = "0xC28300", VA = "0x180C29900")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public TransformAccessArray FAJIAIGCAPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000D0F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public bool JDCINNHHEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000D10")]
		[Cpp2IlInjected.Address(RVA = "0x2DF0E80", Offset = "0x2DEF880", VA = "0x182DF0E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D0C")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0FD0", Offset = "0x2DEF9D0", VA = "0x182DF0FD0")]
	public BCPGIKNGDDK(int ADCMDGEMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D11")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0EF0", Offset = "0x2DEF8F0", VA = "0x182DF0EF0")]
	public Entity MNMLEMMMPJN(int GFDMFLGCBKB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D12")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0F40", Offset = "0x2DEF940", VA = "0x182DF0F40")]
	public Transform NNGDOMLKAEA(int GFDMFLGCBKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D13")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0DB0", Offset = "0x2DEF7B0", VA = "0x182DF0DB0")]
	public void DDGIAPACLJA(int ADCMDGEMNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D14")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0CE0", Offset = "0x2DEF6E0", VA = "0x182DF0CE0")]
	public int CPLOAHMOJFD(Transform CLHKPCIOCGF, Entity GOANOLJBHPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D15")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0F50", Offset = "0x2DEF950", VA = "0x182DF0F50")]
	public int ONIJIJJBDOI(int GFDMFLGCBKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D16")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0E00", Offset = "0x2DEF800", VA = "0x182DF0E00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D17")]
	[Cpp2IlInjected.Address(RVA = "0x2DF0EA0", Offset = "0x2DEF8A0", VA = "0x182DF0EA0")]
	private void IOIFGGHNBKG(int DLFBNHIJNGI = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
internal class PCPINBHEAKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private NativeHashMap<EDPGDBLKBOA, int2> LLFJKHCJHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private NativeList<byte> DFIIPKJNKEL;

	[Cpp2IlInjected.Token(Token = "0x6000D18")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA9D0", Offset = "0x2AF93D0", VA = "0x182AFA9D0")]
	public PCPINBHEAKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D19")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA970", Offset = "0x2AF9370", VA = "0x182AFA970")]
	public void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1A")]
	public void NLANNFAIKGA<T>(T MNIAGKNOHEJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1B")]
	public T AGGAFJIIBKL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1C")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA760", Offset = "0x2AF9160", VA = "0x182AFA760")]
	public void NLANNFAIKGA(Type MAHAMGBPDNB, DHBMIEMIIHO MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1D")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA2F0", Offset = "0x2AF8CF0", VA = "0x182AFA2F0")]
	public DHBMIEMIIHO AGGAFJIIBKL(Type MAHAMGBPDNB)
	{
		return default(DHBMIEMIIHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1E")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA6C0", Offset = "0x2AF90C0", VA = "0x182AFA6C0")]
	private NativeArray<byte> KBBIEGIFNEJ(int2 OBFIKJLHJML)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D1F")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA500", Offset = "0x2AF8F00", VA = "0x182AFA500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D20")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA5A0", Offset = "0x2AF8FA0", VA = "0x182AFA5A0", Slot = "1")]
	~PCPINBHEAKI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001D9")]
public struct PBDCIHCLFCA<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	internal static T ACPLDDIHALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000D21")]
		get
		{
			return (T)null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D22")]
	public static global::PBDCIHCLFCA<T> EGMKMIPNLBF(T MNIAGKNOHEJ)
	{
		return default(global::PBDCIHCLFCA<T>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D23")]
	public static T EGMKMIPNLBF(global::PBDCIHCLFCA<T> OGDNNKNPNAO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public static class BHLJAGIOENC
{
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private static readonly PCPINBHEAKI OFODCPMHCMG;

	[Cpp2IlInjected.Token(Token = "0x6000D24")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1BD0", Offset = "0x2DF05D0", VA = "0x182DF1BD0")]
	internal static void NMFIICNHENP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D25")]
	public static void NLANNFAIKGA<T>(T MNIAGKNOHEJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D26")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1B30", Offset = "0x2DF0530", VA = "0x182DF1B30")]
	public static void NLANNFAIKGA(Type MAHAMGBPDNB, DHBMIEMIIHO MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D27")]
	public static T AGGAFJIIBKL<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D28")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1A90", Offset = "0x2DF0490", VA = "0x182DF1A90")]
	public static DHBMIEMIIHO AGGAFJIIBKL(Type MAHAMGBPDNB)
	{
		return default(DHBMIEMIIHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
public class LNJBMCBCAEF : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	public static readonly LNJBMCBCAEF JPMFPEEJFPH;

	[Cpp2IlInjected.Token(Token = "0x6000D2A")]
	[Cpp2IlInjected.Address(RVA = "0x2C33E50", Offset = "0x2C32850", VA = "0x182C33E50", Slot = "4")]
	public bool Equals(LinkedEntityGroup MEALLDFELFM, LinkedEntityGroup LOIOEMHMDAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2B")]
	[Cpp2IlInjected.Address(RVA = "0x2C33E70", Offset = "0x2C32870", VA = "0x182C33E70", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup LAFPICAOEAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public LNJBMCBCAEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class KPPFCJACLOK
{
	[Cpp2IlInjected.Token(Token = "0x6000D2E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void FJECFPAHOLE(in Vector3 OAALNDIAAOB, in Quaternion HOOCPOKGFMC, in Vector3 HKGHFAPJIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D2F")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void OKPFFGBCOJG(in Vector3 PFHGOFCKPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D30")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void OACIEBNMHJF(in Quaternion HOOCPOKGFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D31")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void GIKLHIEPDGP(in Vector3 FLLODDHPGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D32")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void ELNIFIPDLHK(in Vector3 FLLODDHPGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D33")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void JODIDJKPJPC(in float EIMFGGDMPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D34")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D6E0", Offset = "0x2C2C0E0", VA = "0x182C2D6E0")]
	[Conditional("DEBUG_BUILD")]
	public static void CMCEJDIOJKO(in float3 MNIAGKNOHEJ, string EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D35")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
	[Conditional("DEBUG_BUILD")]
	public static void AHOHMBIEANO(in float MNIAGKNOHEJ, string EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D36")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D690", Offset = "0x2C2C090", VA = "0x182C2D690")]
	[Conditional("DEBUG_BUILD")]
	public static void AHOHMBIEANO(in Vector3 MNIAGKNOHEJ, string EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D37")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D660", Offset = "0x2C2C060", VA = "0x182C2D660")]
	[Conditional("DEBUG_BUILD")]
	public static void AHOHMBIEANO(in Quaternion MNIAGKNOHEJ, string EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D38")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D790", Offset = "0x2C2C190", VA = "0x182C2D790")]
	[Conditional("DEBUG_BUILD")]
	public static void JLFGAEJFINH(in float MNIAGKNOHEJ, string EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D39")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D7A0", Offset = "0x2C2C1A0", VA = "0x182C2D7A0")]
	[Conditional("DEBUG_BUILD")]
	public static void JLFGAEJFINH(in Vector3 MNIAGKNOHEJ, string EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3A")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D7E0", Offset = "0x2C2C1E0", VA = "0x182C2D7E0")]
	[Conditional("DEBUG_BUILD")]
	public static void JLFGAEJFINH(in Quaternion MNIAGKNOHEJ, string EJEIJOMMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KPPFCJACLOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
public struct MIIGEONEKIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	public Entity GOANOLJBHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	public Entity PMJEABCAKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	public Entity DILGNCFGGHK;

	[Cpp2IlInjected.Token(Token = "0x6000D3C")]
	[Cpp2IlInjected.Address(RVA = "0x2AE68E0", Offset = "0x2AE52E0", VA = "0x182AE68E0")]
	public MIIGEONEKIB(Entity GOANOLJBHPF, Entity PMJEABCAKDM, Entity DILGNCFGGHK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D3D")]
	[Cpp2IlInjected.Address(RVA = "0x2AE6880", Offset = "0x2AE5280", VA = "0x182AE6880")]
	public static MIIGEONEKIB EGMKMIPNLBF((Entity entity, Entity oldParent, Entity newParent) BKDFLNHPDJL)
	{
		return default(MIIGEONEKIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D3E")]
	[Cpp2IlInjected.Address(RVA = "0x2AE68C0", Offset = "0x2AE52C0", VA = "0x182AE68C0")]
	public void LEMACGHMFAF(out Entity GOANOLJBHPF, out Entity PMJEABCAKDM, out Entity DILGNCFGGHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
public struct LIOPPALECME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005ED")]
	public Entity GOANOLJBHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005EE")]
	public Entity ELGBIOMPEHN;

	[Cpp2IlInjected.Token(Token = "0x6000D3F")]
	[Cpp2IlInjected.Address(RVA = "0xEAB980", Offset = "0xEAA380", VA = "0x180EAB980")]
	public LIOPPALECME(Entity GOANOLJBHPF, Entity ELGBIOMPEHN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D40")]
	[Cpp2IlInjected.Address(RVA = "0x2C327E0", Offset = "0x2C311E0", VA = "0x182C327E0")]
	public static LIOPPALECME EGMKMIPNLBF((Entity entity, Entity parent) BKDFLNHPDJL)
	{
		return default(LIOPPALECME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D41")]
	[Cpp2IlInjected.Address(RVA = "0x2C32810", Offset = "0x2C31210", VA = "0x182C32810")]
	public void LEMACGHMFAF(out Entity GOANOLJBHPF, out Entity ELGBIOMPEHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
public struct JADBHKIHDEM<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private GCHandle BIONDBIGACN;

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public bool JMDEDHGDCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000D43")]
		[Cpp2IlInjected.Address(RVA = "0x2E087A0", Offset = "0x2E071A0", VA = "0x182E087A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public T ACPLDDIHALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000D44")]
		[Cpp2IlInjected.Address(RVA = "0x30A9C60", Offset = "0x30A8660", VA = "0x1830A9C60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000D45")]
		[Cpp2IlInjected.Address(RVA = "0x30A9D00", Offset = "0x30A8700", VA = "0x1830A9D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000D42")]
	[Cpp2IlInjected.Address(RVA = "0x30A9DC0", Offset = "0x30A87C0", VA = "0x1830A9DC0")]
	public JADBHKIHDEM(T MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D46")]
	[Cpp2IlInjected.Address(RVA = "0x30A9C30", Offset = "0x30A8630", VA = "0x1830A9C30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public enum FJNJHKNKHCI
{
	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
public struct BDJJEEAIANM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	public FJNJHKNKHCI JMMHPLCCLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	public int HFCCOEPLJDK;

	[Cpp2IlInjected.Token(Token = "0x6000D47")]
	[Cpp2IlInjected.Address(RVA = "0x6E2050", Offset = "0x6E0A50", VA = "0x1806E2050")]
	public BDJJEEAIANM(FJNJHKNKHCI JMMHPLCCLIP, int HFCCOEPLJDK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000D48")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A1E0", Offset = "0x2C18BE0", VA = "0x182C1A1E0")]
	public static BDJJEEAIANM EGMKMIPNLBF((FJNJHKNKHCI eventType, int eventIndex) MEALLDFELFM)
	{
		return default(BDJJEEAIANM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D49")]
	[Cpp2IlInjected.Address(RVA = "0x2DF10B0", Offset = "0x2DEFAB0", VA = "0x182DF10B0")]
	public void LEMACGHMFAF(out FJNJHKNKHCI JMMHPLCCLIP, out int HFCCOEPLJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[DNOPHNKOHLA(typeof(HJNCNJMLHIG), new string[] { })]
public sealed class GOBHJEDFKDM : HJNCNJMLHIG, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private FEKPIDGPAOL CBJNFMJDGJI;

	[Cpp2IlInjected.Token(Token = "0x6000D4A")]
	[Cpp2IlInjected.Address(RVA = "0x2C1BDD0", Offset = "0x2C1A7D0", VA = "0x182C1BDD0", Slot = "5")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4B")]
	[Cpp2IlInjected.Address(RVA = "0x2C1BCE0", Offset = "0x2C1A6E0", VA = "0x182C1BCE0")]
	public bool GAOOJLNOKIK(in float3 DKLFBNALGBC, in float3 PANBGKEJNBF, float OEPBPFIFMKK, Allocator GGPAKDMJHLJ, out NativeArray<Entity> CGCCIONMJJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public GOBHJEDFKDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4D")]
	[Cpp2IlInjected.Address(RVA = "0x2C1BCE0", Offset = "0x2C1A6E0", VA = "0x182C1BCE0", Slot = "4")]
	private bool LNDHKGBLIKP(in float3 DKLFBNALGBC, in float3 PANBGKEJNBF, float OEPBPFIFMKK, Allocator GGPAKDMJHLJ, out NativeArray<Entity> CGCCIONMJJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[OFACFEGCPFP]
[UpdateInGroup(typeof(PDIHPADFJCF))]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
internal sealed class LFLGKOPHDOI : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000D4E")]
	[Cpp2IlInjected.Address(RVA = "0x2C32150", Offset = "0x2C30B50", VA = "0x182C32150", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D4F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public LFLGKOPHDOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D50")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[OFACFEGCPFP]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
[UpdateInGroup(typeof(CAMFPPPODPD))]
public sealed class KLKLBHPMBML : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000D51")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D580", Offset = "0x2C2BF80", VA = "0x182C2D580", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D52")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public KLKLBHPMBML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D53")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
[OFACFEGCPFP]
[UpdateInGroup(typeof(DMPHECIDDCJ))]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
internal sealed class IBBLIKOLGBE : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000D54")]
	[Cpp2IlInjected.Address(RVA = "0x2C23A50", Offset = "0x2C22450", VA = "0x182C23A50", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D55")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public IBBLIKOLGBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D56")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
internal class CIELLLLFELF : FPJLAJEOELD
{
	[Cpp2IlInjected.Token(Token = "0x6000D57")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public CIELLLLFELF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D58")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
[OFACFEGCPFP]
[ExecuteAlways]
[PNKDNOBPNFK(EIJAKMAIFNG.LoadInstance)]
[UpdateInGroup(typeof(IELIJNMCAKM))]
internal sealed class LGDNCDJDAEI : PMCACKOJIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000D59")]
	[Cpp2IlInjected.Address(RVA = "0x2C32670", Offset = "0x2C31070", VA = "0x182C32670", Slot = "16")]
	protected override ComponentSystemBase KPBIBFOBGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5A")]
	[Cpp2IlInjected.Address(RVA = "0x2AE5920", Offset = "0x2AE4320", VA = "0x182AE5920")]
	public LGDNCDJDAEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E8")]
[HNPKKIDOILC(typeof(AuthoredLocalPoseData))]
public sealed class ALGJBNOMACP : ECMDEGLPGHG
{
	[Cpp2IlInjected.Token(Token = "0x6000D5C")]
	[Cpp2IlInjected.Address(RVA = "0x2DEECB0", Offset = "0x2DED6B0", VA = "0x182DEECB0", Slot = "8")]
	protected override bool GLGEGDNOAGK(ReadOnlySpan<AuthoredLocalPoseData> KPKJFELPMLM, MKAJIBPDGLA GMMMMEKOOIB, out ReadOnlySpan<byte> DBKEJGOGOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5D")]
	[Cpp2IlInjected.Address(RVA = "0x2DEED30", Offset = "0x2DED730", VA = "0x182DEED30", Slot = "9")]
	protected override bool JJMDHHBNBBO(int FMHBAJCDDEI, Span<AuthoredLocalPoseData> KPKJFELPMLM, in ReadOnlySpan<byte> DBKEJGOGOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D5E")]
	[Cpp2IlInjected.Address(RVA = "0x2DEEDF0", Offset = "0x2DED7F0", VA = "0x182DEEDF0")]
	public ALGJBNOMACP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
[HNPKKIDOILC(typeof(LocalPoseData))]
public sealed class PCDDEMBFLON : KLNDBDNNLLB
{
	[Cpp2IlInjected.Token(Token = "0x6000D5F")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA1A0", Offset = "0x2AF8BA0", VA = "0x182AFA1A0", Slot = "8")]
	protected override bool GLGEGDNOAGK(ReadOnlySpan<LocalPoseData> KPKJFELPMLM, MKAJIBPDGLA GMMMMEKOOIB, out ReadOnlySpan<byte> DBKEJGOGOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D60")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA220", Offset = "0x2AF8C20", VA = "0x182AFA220", Slot = "9")]
	protected override bool JJMDHHBNBBO(int FMHBAJCDDEI, Span<LocalPoseData> KPKJFELPMLM, in ReadOnlySpan<byte> DBKEJGOGOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000D61")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA2E0", Offset = "0x2AF8CE0", VA = "0x182AFA2E0")]
	public PCDDEMBFLON()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[Preserve]
	internal class _RRAssemblyIndex : NMOBLBLJIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000D62")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D63")]
		[Cpp2IlInjected.Address(RVA = "0x2C13F40", Offset = "0x2C12940", VA = "0x182C13F40", Slot = "6")]
		public sealed override void EPCHFMECFAE(HCFBHIJDBLF JOIALDGLEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000D64")]
		[Cpp2IlInjected.Address(RVA = "0x2C13470", Offset = "0x2C11E70", VA = "0x182C13470", Slot = "4")]
		public sealed override void DBHAPDCLOEH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x40005FA")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x6000D65")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000D67")]
	[Cpp2IlInjected.Address(RVA = "0x2C2BB50", Offset = "0x2C2A550", VA = "0x182C2BB50")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000D68")]
	[Cpp2IlInjected.Address(RVA = "0x2C2B800", Offset = "0x2C2A200", VA = "0x182C2B800")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20001ED")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000D69")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001EE")]
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
